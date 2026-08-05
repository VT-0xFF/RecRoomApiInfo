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
		[Cpp2IlInjected.Address(RVA = "0x734EB40", Offset = "0x734D140", VA = "0x18734EB40", Slot = "4")]
		public override void OCICFIBHEPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x97B910", Offset = "0x979F10", VA = "0x18097B910")]
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
			[Cpp2IlInjected.Address(RVA = "0x9529D0", Offset = "0x950FD0", VA = "0x1809529D0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override string AssetGUID
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x73554F0", Offset = "0x7353AF0", VA = "0x1873554F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7355480", Offset = "0x7353A80", VA = "0x187355480", Slot = "17")]
		public override bool RuntimeKeyIsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x73554B0", Offset = "0x7353AB0", VA = "0x1873554B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x950410", Offset = "0x94EA10", VA = "0x180950410")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x950400", Offset = "0x94EA00", VA = "0x180950400")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string UniqueItemIdentifier
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x9529B0", Offset = "0x950FB0", VA = "0x1809529B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string CacheHash
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x952800", Offset = "0x950E00", VA = "0x180952800")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x952A00", Offset = "0x951000", VA = "0x180952A00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RecNetCDNKey Dependency
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x9529E0", Offset = "0x950FE0", VA = "0x1809529E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x9527E0", Offset = "0x950DE0", VA = "0x1809527E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool AttemptPrecacheLookup
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x97F1A0", Offset = "0x97D7A0", VA = "0x18097F1A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x97EF20", Offset = "0x97D520", VA = "0x18097EF20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public HCDEKIODBAJ PathHint
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xC46D10", Offset = "0xC45310", VA = "0x180C46D10")]
			[CompilerGenerated]
			get
			{
				return default(HCDEKIODBAJ);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x111C6B0", Offset = "0x111ACB0", VA = "0x18111C6B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string ItemPath
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x7355600", Offset = "0x7353C00", VA = "0x187355600")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7355580", Offset = "0x7353B80", VA = "0x187355580")]
		public static RecNetCDNKey HNDKJCJHHIB(string GIBLLGOENJK, HCDEKIODBAJ MJNGGKMDGNO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7355530", Offset = "0x7353B30", VA = "0x187355530")]
		public void FHEGHKAAMBH(string HODIIHGJIOP, string MGPEIJNPFNJ, bool JJEFKMNMPJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
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
	protected readonly List<long> MCNGCOAMNBA;

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
	[Cpp2IlInjected.Address(RVA = "0x73534F0", Offset = "0x7351AF0", VA = "0x1873534F0", Slot = "4")]
	public void BMFCBKCPPJP(Mesh LCGHOEMEOEK, Matrix4x4 OGMKAOPLLDA, byte[] FFEHGHDGBPA, bool CBFKEKGDGGD = false, KBAIGJMAONF.FALICHFPADL IPOKALCDIKI = (KBAIGJMAONF.FALICHFPADL)0L, int ELAEEHODNCP = -1, bool MBLBPIKGHBL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7353770", Offset = "0x7351D70", VA = "0x187353770", Slot = "5")]
	public void JKGNMOLLMOL(Allocator LEILKJFLDFN, LDBIEKJHPFI KKPPEJOKKDF, byte DDBNJCIKGBE, [Optional] IList<int> MPNCJGPMPPN, [Optional] IList<int> KKBDINDOJJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x73537B0", Offset = "0x7351DB0", VA = "0x1873537B0")]
	private static void PGMACMDMPGL(Mesh LCGHOEMEOEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7353A10", Offset = "0x7352010", VA = "0x187353A10")]
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
	[Cpp2IlInjected.Address(RVA = "0x7351E00", Offset = "0x7350400", VA = "0x187351E00", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[GAFKBMEFLIK]
[NativeContainer]
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
		[Cpp2IlInjected.Address(RVA = "0x734F6F0", Offset = "0x734DCF0", VA = "0x18734F6F0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x734FE00", Offset = "0x734E400", VA = "0x18734FE00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int FKDAOBCELNH
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x734FDE0", Offset = "0x734E3E0", VA = "0x18734FDE0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x734EEA0", Offset = "0x734D4A0", VA = "0x18734EEA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int BIJLPBFCEML
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x734EF80", Offset = "0x734D580", VA = "0x18734EF80")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x734FDF0", Offset = "0x734E3F0", VA = "0x18734FDF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int MCPONCKMDGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x734F1F0", Offset = "0x734D7F0", VA = "0x18734F1F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7351190", Offset = "0x734F790", VA = "0x187351190")]
	public MMONHKFFOCH(int DCAPCHJBFBL, int KIJGJIIFKFG, int JGOLOKHACFH, int KMLBPKIICHM, Allocator LEILKJFLDFN, int PJIBNECOEEF, NNBGPGNKBMB CBJDPLCEFOH, bool ACAFJGKPGAH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x734F660", Offset = "0x734DC60", VA = "0x18734F660")]
	public void HHPMHFMNAJF(int EAHKFAJBNDN, Vector3 EFDAGALIIFI, Vector3 EOJJAMCHAEH, Vector4 CHBEBLKFDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x734FE10", Offset = "0x734E410", VA = "0x18734FE10")]
	public void OKJKLFJLGAK(int EAHKFAJBNDN, BoneWeight OMGFMBIBPEF, NativeSlice<byte> FFEHGHDGBPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x734FAB0", Offset = "0x734E0B0", VA = "0x18734FAB0")]
	public Color JNLBMPGFNHP(int EAHKFAJBNDN)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x734F260", Offset = "0x734D860", VA = "0x18734F260")]
	public void HEJAGELOGAE(int EAHKFAJBNDN, Color OPLPABIPAJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x734F700", Offset = "0x734DD00", VA = "0x18734F700")]
	public void HPCGJKIOAEP(byte PNAPGIMAEDK, int EAHKFAJBNDN, Vector2 JLECHKDJMOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7350240", Offset = "0x734E840", VA = "0x187350240")]
	public void ONEPFBFBNOF(int EAHKFAJBNDN, int LFPNFLHKPCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x734EE40", Offset = "0x734D440", VA = "0x18734EE40")]
	public bool ABJNLCGOEJM(int PNAPGIMAEDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x734EEB0", Offset = "0x734D4B0", VA = "0x18734EEB0")]
	public void APGKCNCJEMG(int GCNALCOKJIM, int FDJGEFDKBBO, int GIGAFKHMOHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x734EF90", Offset = "0x734D590", VA = "0x18734EF90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7350250", Offset = "0x734E850", VA = "0x187350250")]
	public Mesh PCNJPGHJCAK([Optional] string IHJJNKIBIDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
[NativeContainer]
[GAFKBMEFLIK]
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
	private NativeArray<long> PCGCNHMBOII;

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
		[Cpp2IlInjected.Address(RVA = "0x7353F10", Offset = "0x7352510", VA = "0x187353F10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int IPNIHLGMKHD
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7353D50", Offset = "0x7352350", VA = "0x187353D50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int AKEIDLPADKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x73541C0", Offset = "0x73527C0", VA = "0x1873541C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int NGNEIPBLGEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7353F20", Offset = "0x7352520", VA = "0x187353F20")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x73541A0", Offset = "0x73527A0", VA = "0x1873541A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int GMBBBJCHFML
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7353F00", Offset = "0x7352500", VA = "0x187353F00")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7354190", Offset = "0x7352790", VA = "0x187354190")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int KLOCEPDAPGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7353C60", Offset = "0x7352260", VA = "0x187353C60")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7353D40", Offset = "0x7352340", VA = "0x187353D40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public LDBIEKJHPFI NEICIGCPFDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x73541B0", Offset = "0x73527B0", VA = "0x1873541B0")]
		get
		{
			return default(LDBIEKJHPFI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7353EE0", Offset = "0x73524E0", VA = "0x187353EE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public byte PEEONGELKEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7353EF0", Offset = "0x73524F0", VA = "0x187353EF0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7354180", Offset = "0x7352780", VA = "0x187354180")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public MNOIKDLBMCH NMMCMNBCFHB
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7353F30", Offset = "0x7352530", VA = "0x187353F30")]
		get
		{
			return default(MNOIKDLBMCH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7354290", Offset = "0x7352890", VA = "0x187354290")]
	public PDBKIDCBHPE(IList<Mesh> JMIOOBAANOC, IList<Matrix4x4> AIGFAHJHCPH, IList<bool> MBLBPIKGHBL, byte DDBNJCIKGBE, IList<byte[]> ONOJOCHFGBF, IList<long> AJBCMOLPIAF, IList<bool> OKLIGHJAMIK, IList<int> ELAEEHODNCP, IList<int> MPNCJGPMPPN, IList<int> LDFOIFFKFJH, Allocator LEILKJFLDFN, LDBIEKJHPFI KKPPEJOKKDF, bool ACAFJGKPGAH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7353C70", Offset = "0x7352270", VA = "0x187353C70")]
	public MMONHKFFOCH AODCLOLHDIH(Allocator LEILKJFLDFN, NNBGPGNKBMB CBJDPLCEFOH)
	{
		return default(MMONHKFFOCH);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7353D60", Offset = "0x7352360", VA = "0x187353D60", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x734E570", Offset = "0x734CB70", VA = "0x18734E570")]
	public PDBKIDCBHPE PCKDJDEKJBB()
	{
		return default(PDBKIDCBHPE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x734E830", Offset = "0x734CE30", VA = "0x18734E830")]
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

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public long JIJOKOIODIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public NativeSlice<byte> FFEHGHDGBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public bool CEPINDKOFMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public int CMNAJANMPNF;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class ADOHCHALOBL : AHBNJGDEGOO
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class MJOIPEAOKAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public HNNBNAMEAIG avatarBuildParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public ADOHCHALOBL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public AEIHFJALFJE buildMeshPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public Action<KeyValuePair<string, EBHOPDBMNPK<Texture2D>>> <>9__19;

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public MJOIPEAOKAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x734ECE0", Offset = "0x734D2E0", VA = "0x18734ECE0")]
		internal bool FCJGJPONKNF(LJKKDAKGHIG item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x734ECC0", Offset = "0x734D2C0", VA = "0x18734ECC0")]
		internal void EKJFJKNGIDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x734EDF0", Offset = "0x734D3F0", VA = "0x18734EDF0")]
		internal void LHCPKADLJAB(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x734ECC0", Offset = "0x734D2C0", VA = "0x18734ECC0")]
		internal void FKDBKPOAGKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x734EDF0", Offset = "0x734D3F0", VA = "0x18734EDF0")]
		internal void OADCENNENPD(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x734EC90", Offset = "0x734D290", VA = "0x18734EC90")]
		internal void DNAJNDJKDBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x734EE10", Offset = "0x734D410", VA = "0x18734EE10")]
		internal void NBMEFOCDKOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x734ED30", Offset = "0x734D330", VA = "0x18734ED30")]
		internal void GEKEBGLBEEA(Dictionary<string, EBHOPDBMNPK<Texture2D>> resourceHandleDictionary)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x734EBD0", Offset = "0x734D1D0", VA = "0x18734EBD0")]
		internal void ALKBBAIFBNB(KeyValuePair<string, EBHOPDBMNPK<Texture2D>> kvp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x952800", Offset = "0x950E00", VA = "0x180952800")]
		internal HJOKANJAKGB KCCAMEFCJLD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class HJFGMCHCAOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public int lowestPossibleLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public MJOIPEAOKAE CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public HJFGMCHCAOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x734EA80", Offset = "0x734D080", VA = "0x18734EA80")]
		internal CLDEBNIPJAK JEGAGGLNGBE(int lod)
		{
			return default(CLDEBNIPJAK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class KDLKHLFGJNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public NEEPBAPEEOL<Dictionary<string, EBHOPDBMNPK<Texture2D>>> ugcTextureDictionaryPromise;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public KDLKHLFGJNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x950410", Offset = "0x94EA10", VA = "0x180950410")]
		internal NEEPBAPEEOL<Dictionary<string, EBHOPDBMNPK<Texture2D>>> PBHMBBGAHEK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class BMLPLJNGFDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public List<AEIHFJALFJE> innerPromises;

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public BMLPLJNGFDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x734E170", Offset = "0x734C770", VA = "0x18734E170")]
		internal void CLACDCHEKMM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class ECODNEDKLBP : IEnumerator<FBLKJCIOKGP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private FBLKJCIOKGP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public bool shouldWait;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public ADOHCHALOBL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public List<CEHPNHHBNNM> parts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public List<AEIHFJALFJE> innerPromises;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public bool isFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public Func<int, CLDEBNIPJAK> getLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public MIGKACJGENE materialPropertyBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public Material materialInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private int <lodIndex>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		private FBLKJCIOKGP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x9527A0", Offset = "0x950DA0", VA = "0x1809527A0")]
		[DebuggerHidden]
		public ECODNEDKLBP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x734E2A0", Offset = "0x734C8A0", VA = "0x18734E2A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x734E520", Offset = "0x734CB20", VA = "0x18734E520", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class HJOLEIBEAAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public CLHPMPABOAJ cancelable;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public HJOLEIBEAAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xA704C0", Offset = "0xA6EAC0", VA = "0x180A704C0")]
		internal void CJHFNNHEHCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xB8E030", Offset = "0xB8C630", VA = "0x180B8E030")]
		internal void GKDDJNMAEJL(string err)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class EGHBNKOHFBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public long jobComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public Stopwatch stopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public SkinnedMeshRenderer lodRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public long meshComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public string meshName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public long meshCopyComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public ADOHCHALOBL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public List<Material> newUniqueMaterials;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public int frameStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public long lodBuildStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public long startCombineBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public long jobScheduled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public Action onFinally;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public EGHBNKOHFBA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class MOHPNPLECAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public MMONHKFFOCH defaultMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public PDBKIDCBHPE defaultAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public EGHBNKOHFBA CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public MOHPNPLECAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x7351BC0", Offset = "0x73501C0", VA = "0x187351BC0")]
		internal void OFCOLPDEBKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x1069440", Offset = "0x1067A40", VA = "0x181069440")]
		internal void HKNAPPEKAJH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class HDHCEAJNBJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public NHEMOJHNGLC legacyMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public PFCDOEJMIDA legacyAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public EGHBNKOHFBA CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public HDHCEAJNBJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x734E840", Offset = "0x734CE40", VA = "0x18734E840")]
		internal void PKNAGMNPLDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x106AD70", Offset = "0x1069370", VA = "0x18106AD70")]
		internal void BIPDCGEIEKE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class BMEKHEPILJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public string overrideItemIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public OBJHNMCDGDL overrideBodyPart;

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public BMEKHEPILJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x734E0F0", Offset = "0x734C6F0", VA = "0x18734E0F0")]
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
	private static Dictionary<EEHFKDPJPMH, float> LNNNIMEOGEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private IReadOnlyDictionary<string, MKHCFAMCDEP> FFPMJHGBIMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private IReadOnlyDictionary<string, MKHCFAMCDEP> JLDPAJLEAKE;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static float FLKNNLDFOEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private bool? EOIMBOFMGLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private bool? KHLDBNPIDIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private AvatarConfiguration KKLCLENFPKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private Transform LECEGBEGODE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private AvatarSkinAssetItem BBCPEMJPNHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private AssetReference MFCJFMIOAIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private GameObject KBAHLOMKKPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private GameObject KCAEABMDGFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private SkinnedMeshRenderer FMOLKKFBKNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private AvatarSkinnedMeshBoneOrderRemapsData HMPHGIKKCHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private Transform[] OMKDLOFLNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private Matrix4x4[] CPMMFLLAOKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private Material EILPOGCGFPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private Material PABGJMMHGGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private Material BBPEFDGPLED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private Shader LADOIPHNDNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private Shader HENLIHMFHIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private Animator EJJCIBPIAHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private Renderer[] OGDHLGKLDMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private KBAIGJMAONF.FALICHFPADL ACJCGODKLIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private AvatarBodyPartShapesManager KGCNKDKLAPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private IReadOnlyDictionary<string, Transform> FILEAMKALPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private AvatarFaceShapeData.NFLOKLBCILG GHINLBGNMEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private AvatarBodyShapeData.BKBJCOHDGGC MMELNFGKBEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private EHLDDELHBFB EMNGJFNFECE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private bool JFDONDNABBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE5")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private bool HCCOIJLNDIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private Color DAGJLDLMCHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private Color JMKCHGNFHPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private Color MCPLMEPMMLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private Color? NLFDIBDJPAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private Color? PFKGJOBAALK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private Color? NBJGONEDKCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x154")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private Color? OIEKNDJIDFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private Texture2D LDBBMEJOIHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private Texture2D HOHLFDPPEPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	[CanBeNull]
	private LJKKDAKGHIG FDBGEIJGPBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private Texture ALHEGKGOEEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private Color BIIEBCKIDPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public Dictionary<Renderer, MIGKACJGENE> BGMJAEEPDEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private Dictionary<Renderer, MIGKACJGENE> BADIABDKJJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private Dictionary<string, List<IMJMIIIPNLF>> ONEDBDFCKCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private Dictionary<string, List<IMJMIIIPNLF>> IHFAFHCNCAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private readonly List<BELJNJGLPJA> GFIECIAKOMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly List<BELJNJGLPJA> DCHBJMMMJDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly List<BELJNJGLPJA> OHNMOGHPOHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly List<BELJNJGLPJA> CNIIEIOFJDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private Dictionary<IMJMIIIPNLF, Material> HGBHOMEPAAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private Dictionary<IMJMIIIPNLF, Material> IIPOBONAJDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private SkinnedMeshRenderer[] GFGHAHLCDOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private SkinnedMeshRenderer[] NNACCEKFCBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private SkinnedMeshRenderer[] KFJGJHNLIGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private SkinnedMeshRenderer[] CBEECFOHHDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly Dictionary<string, EBHOPDBMNPK<Texture2D>> GJODDODIDOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly Dictionary<string, EBHOPDBMNPK<Texture2D>> KEIPCMPJLDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private IIFAJIGINPD NCPNEHANKDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21C")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private IIFAJIGINPD NJEBJIJCCBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private AdditionalHatData NLAPCHMOKAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private AdditionalHatData PLPOCHJOOLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private HairData ENLFHMLFOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private HairData EHMJDIAKGFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private KOIFPCMFICK BBAPNNFAODH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private bool? FHIAJODCCFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24C")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private PositionAndRotation HMOBLCNFKBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private Transform KMGDPDKNDEL;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private Material KLPAIIMPKMH;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private Material IFAHJHJIBEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private Dictionary<string, LJKKDAKGHIG> IEECIKDJPME;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static readonly int HNJJHJPBPOB;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private static readonly int EENGMNKCIPB;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private static readonly int DBFMBBCPHAL;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private static readonly int AJEDMGPCFNL;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private static readonly int JOECFFLEBJE;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private static readonly int GBCMFLNPEMM;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static readonly int HAFGEAALIDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private bool CIBJIMPMFKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private List<Action> NNCDPIDIOMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private IKKEFGFKHCN PKLGHJOCJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private SkinnedMeshRenderer[] HAIEBPOHPME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private int DOIJDHJLOIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2AC")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool LMOLOABGPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private int HPJIMKEBIGA;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public FKDOIPNGGAF DMIIGPCLCJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x950410", Offset = "0x94EA10", VA = "0x180950410", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public FKDOIPNGGAF DMCLJIPCDNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private FIIDOADKEDD MGBNFJALEFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7346190", Offset = "0x7344790", VA = "0x187346190")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool INKILOONHHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x733FA20", Offset = "0x733E020", VA = "0x18733FA20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private bool CNBIIKIAHLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7343920", Offset = "0x7341F20", VA = "0x187343920")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public AvatarConfiguration LJNPOLOCLOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x952DD0", Offset = "0x9513D0", VA = "0x180952DD0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool BIJDDCNCAGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xFE8760", Offset = "0xFE6D60", VA = "0x180FE8760")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xFE9780", Offset = "0xFE7D80", VA = "0x180FE9780")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private Material ICLFDEAAPPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x733E7D0", Offset = "0x733CDD0", VA = "0x18733E7D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private Material PNFKECHGNEL
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7346200", Offset = "0x7344800", VA = "0x187346200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private bool KNAMMMJKBJE
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x96C540", Offset = "0x96AB40", VA = "0x18096C540")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public PKOOKMMPLDP CBKHCHACMEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x1FA5AD0", Offset = "0x1FA40D0", VA = "0x181FA5AD0", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return default(PKOOKMMPLDP);
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7346180", Offset = "0x7344780", VA = "0x187346180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public Material BHJJGIONPII
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA740D0", Offset = "0xA726D0", VA = "0x180A740D0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public SkinnedMeshRenderer[] CGDMKJBOCEH
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA141B0", Offset = "0xA127B0", VA = "0x180A141B0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public Renderer[] MACMNPGKNND
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xBE34D0", Offset = "0xBE1AD0", VA = "0x180BE34D0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool MMHJEADAFHH
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x73474A0", Offset = "0x7345AA0", VA = "0x1873474A0", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public KBAIGJMAONF.FALICHFPADL OBJPNGNOONK
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xB8B460", Offset = "0xB89A60", VA = "0x180B8B460", Slot = "20")]
		get
		{
			return default(KBAIGJMAONF.FALICHFPADL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public int DMLAADHPPMO
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x204C980", Offset = "0x204AF80", VA = "0x18204C980")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x733DD30", Offset = "0x733C330", VA = "0x18733DD30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool MAFFHLMNBPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7347B40", Offset = "0x7346140", VA = "0x187347B40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private static bool OGFKAKDJLFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7349700", Offset = "0x7347D00", VA = "0x187349700", Slot = "15")]
	public AEIHFJALFJE POGJIFLHOJD(HNNBNAMEAIG MLFKDAKANJM, bool IEOMHDBLFBH, int[] MOFBLKNOEOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x733DD50", Offset = "0x733C350", VA = "0x18733DD50", Slot = "14")]
	public AEIHFJALFJE BDBBCCPEGHA(HNNBNAMEAIG MLFKDAKANJM, bool IEOMHDBLFBH, int[] MOFBLKNOEOE, Func<Dictionary<string, LJKKDAKGHIG>, (AEIHFJALFJE, NEEPBAPEEOL<Dictionary<string, EBHOPDBMNPK<Texture2D>>>)> BBCBCLNEBCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7340360", Offset = "0x733E960", VA = "0x187340360")]
	public AEIHFJALFJE DBJIBOMOEPG(HNNBNAMEAIG MLFKDAKANJM, bool IEOMHDBLFBH, int[] MOFBLKNOEOE, bool JEPIIFHOIHA, IIFAJIGINPD AAADLNMKLFC, [Optional] Func<Dictionary<string, LJKKDAKGHIG>, (AEIHFJALFJE, NEEPBAPEEOL<Dictionary<string, EBHOPDBMNPK<Texture2D>>>)> BBCBCLNEBCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7343AE0", Offset = "0x73420E0", VA = "0x187343AE0")]
	private bool GAPMAJAPGDG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x733EFB0", Offset = "0x733D5B0", VA = "0x18733EFB0")]
	private AEIHFJALFJE CGHEDJLJCHJ(bool IEOMHDBLFBH, List<CEHPNHHBNNM> OBBNKCEMAMM, int[] MOFBLKNOEOE, Func<int, CLDEBNIPJAK> ODCKOKNKPGI, bool JEPIIFHOIHA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7348B60", Offset = "0x7347160", VA = "0x187348B60")]
	[IteratorStateMachine(typeof(ECODNEDKLBP))]
	private IEnumerator<FBLKJCIOKGP> PGKDBLFLLCN(bool IEOMHDBLFBH, List<CEHPNHHBNNM> OBBNKCEMAMM, int[] MOFBLKNOEOE, Func<int, CLDEBNIPJAK> ODCKOKNKPGI, MIGKACJGENE BBIJHOEALAG, Material PFHJOFPFGCD, List<AEIHFJALFJE> JCONMNAEBLJ, bool OENELICLIHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x73484F0", Offset = "0x7346AF0", VA = "0x1873484F0")]
	private void PFGFPMOEOGJ(List<CEHPNHHBNNM> OBBNKCEMAMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7345F00", Offset = "0x7344500", VA = "0x187345F00")]
	private AEIHFJALFJE JAMEIILFMKE(List<CEHPNHHBNNM> OBBNKCEMAMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7344200", Offset = "0x7342800", VA = "0x187344200")]
	private HPLGDNGCOKN GMLEPOHMBKP(List<CEHPNHHBNNM> OBBNKCEMAMM, int GNAJNFCKONF, bool IEOMHDBLFBH, CLDEBNIPJAK GKKHJGBAALN, bool JGIAELKDBPI, MIGKACJGENE BBIJHOEALAG, Material PFHJOFPFGCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7343080", Offset = "0x7341680", VA = "0x187343080", Slot = "27")]
	public void EKABGBOGIKA(EEHFKDPJPMH BBBFKIMAKIC, float KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7348240", Offset = "0x7346840", VA = "0x187348240", Slot = "28")]
	public void OPDBHCJMCBC(bool INODCMLFBJJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x733E6D0", Offset = "0x733CCD0", VA = "0x18733E6D0")]
	private void BNPAAOBPKKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x73479A0", Offset = "0x7345FA0", VA = "0x1873479A0", Slot = "25")]
	public void NFCHKCGEBJJ(AvatarFaceShape NGODEJMKEBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7346C80", Offset = "0x7345280", VA = "0x187346C80", Slot = "26")]
	public void LEKEMDKGABJ(AvatarBodyShape LJFANJBKMBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0xDC6580", Offset = "0xDC4B80", VA = "0x180DC6580", Slot = "29")]
	public void NHPFIPHCDNK(EHLDDELHBFB DIKOIBEAEJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x733DD80", Offset = "0x733C380", VA = "0x18733DD80", Slot = "31")]
	public void BDOLLGIJEOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7348B20", Offset = "0x7347120", VA = "0x187348B20", Slot = "34")]
	public void PFOKONAMMGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x733DC40", Offset = "0x733C240", VA = "0x18733DC40", Slot = "30")]
	public void AKNGCJGIMNF(bool KHFOHCPJDLH, bool EPFJHEKEEKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x73483B0", Offset = "0x73469B0", VA = "0x1873483B0")]
	private void PFAGFAHHDAD(SkinnedMeshRenderer GCOMIOEIBEI, int GNAJNFCKONF, Mesh LCGHOEMEOEK, List<Material> INAPLHEDMCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x73437C0", Offset = "0x7341DC0", VA = "0x1873437C0")]
	private static Material FNBMMPFEOGN(Dictionary<IMJMIIIPNLF, Material> FMPOBMMKKCL, Material EAOFNOHCOIK, BJGDFBKEINK PIEGLLCHINN, DDOKGHHJODE IPEPMKFNFHH, OBJHNMCDGDL DBDEIKJCEBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7340250", Offset = "0x733E850", VA = "0x187340250")]
	private static BJGDFBKEINK DBDPHCDEDDD(CEHPNHHBNNM FAHICGIKPOG, int MFCLFEPKGAD)
	{
		return default(BJGDFBKEINK);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7345A50", Offset = "0x7344050", VA = "0x187345A50")]
	private void IILLJHAHBOI(int CLLOKPKIGEH, Material HJCEHLILOIG, CEHPNHHBNNM FAHICGIKPOG, [Out] Texture2D KNJHLLDKNBN, [Out] Vector4 LEBIOKJNNBM, [Out] Texture2D HCBHLHALDCK, [Out] Texture2D AOLJNNMDFDK, [Out] Texture2D OIPGNFEPIAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7348C80", Offset = "0x7347280", VA = "0x187348C80")]
	private void PIKIKHNHLMM(int CLLOKPKIGEH, Material HJCEHLILOIG, CEHPNHHBNNM FAHICGIKPOG, [Out] Color KDBCFKGNGJP, [Out] Color OJKPDPFPHGP, [Out] Color EKKHNINCDDG, [Out] Color AJJDBGBBOLB, [Out] Color CEJFGPJEHDN, [Out] Color DDPMLLMDLNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x733EAF0", Offset = "0x733D0F0", VA = "0x18733EAF0")]
	private bool CALGCLAMBEH(Material HJCEHLILOIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x733ED50", Offset = "0x733D350", VA = "0x18733ED50")]
	private static Material CDLCCIALEGJ(int CLLOKPKIGEH, IMMLCIEBDAG FAHICGIKPOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7342F60", Offset = "0x7341560", VA = "0x187342F60")]
	private static DDOKGHHJODE EFGPFDDOCGO(CEHPNHHBNNM FAHICGIKPOG, int MFCLFEPKGAD)
	{
		return default(DDOKGHHJODE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7346790", Offset = "0x7344D90", VA = "0x187346790")]
	private static void KGKDIECJCLK(Dictionary<string, List<IMJMIIIPNLF>> JAGFBALGAPL, CEHPNHHBNNM GCHFPPMPGNO, Material EAOFNOHCOIK, BJGDFBKEINK PIKKFHOHKHL, DDOKGHHJODE CJLDBFGOACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x733F620", Offset = "0x733DC20", VA = "0x18733F620")]
	private static SkinnedMeshRenderer CHBPAFEELOA(Transform HBHDBMDKCGC, Transform CBIJFIEIFAK, SkinnedMeshRenderer[] LGCGHBBEHDN, int GNAJNFCKONF, CLDEBNIPJAK GKKHJGBAALN, bool IEOMHDBLFBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7349E30", Offset = "0x7348430", VA = "0x187349E30")]
	public ADOHCHALOBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x73454E0", Offset = "0x7343AE0", VA = "0x1873454E0")]
	public void HPHCPPKCEKM([In] CFPFBPBKEJA KMDGKLFIKLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x73431A0", Offset = "0x73417A0", VA = "0x1873431A0")]
	public void PMBMMACDLKD([In] ADGPJAEELJF AMOHALPGLJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x733DD30", Offset = "0x733C330", VA = "0x18733DD30", Slot = "5")]
	public void AMMEFDJGJNP(int GNAJNFCKONF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7345800", Offset = "0x7343E00", VA = "0x187345800", Slot = "10")]
	public void HPHIDJEIAKN(LHELENKBGMO CJLDBFGOACG, Texture2D IHOMIJNFMIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x96C540", Offset = "0x96AB40", VA = "0x18096C540")]
	public static bool MANMJDMEOGH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x733F850", Offset = "0x733DE50", VA = "0x18733F850", Slot = "11")]
	public bool CIJGIEJAKCE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x73462F0", Offset = "0x73448F0", VA = "0x1873462F0", Slot = "9")]
	public void KEBKKELILPK(GOEIDDHPLEF PIKKFHOHKHL, Color? NHCBHMJDLHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7345430", Offset = "0x7343A30", VA = "0x187345430")]
	private void HBKJDGHELGJ(Action GHJKPFPLGEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x733DA70", Offset = "0x733C070", VA = "0x18733DA70", Slot = "6")]
	public void ACMOENGJDMC(LJKKDAKGHIG JKFGJFHCKPG, Texture HBJIGNEMNAE, Color MIFGFNOKIJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xFE9780", Offset = "0xFE7D80", VA = "0x180FE9780", Slot = "7")]
	public void FHFEHAGHIGE(bool OENELICLIHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0xA2F590", Offset = "0xA2DB90", VA = "0x180A2F590", Slot = "8")]
	public void KADGANNDBCN(IKKEFGFKHCN FJJOKDBOKAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7348040", Offset = "0x7346640", VA = "0x187348040", Slot = "16")]
	public void ONKGPPOKPJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7347A60", Offset = "0x7346060", VA = "0x187347A60", Slot = "32")]
	public void NHGCNFNGFLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7342010", Offset = "0x7340610", VA = "0x187342010", Slot = "33")]
	public void DENPBNBCMIF([Optional] KOIFPCMFICK KOIJGLMEEHK, [Optional] bool? JFFMIJPCLEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7347200", Offset = "0x7345800", VA = "0x187347200")]
	private bool MDBPECIGIGF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7348390", Offset = "0x7346990", VA = "0x187348390", Slot = "21")]
	public bool PFABJPBEEBP(KBAIGJMAONF.FALICHFPADL NOAAJJKCHIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x73435F0", Offset = "0x7341BF0", VA = "0x1873435F0")]
	private void FMOGAMFFKEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7345E60", Offset = "0x7344460", VA = "0x187345E60")]
	private void IKNANBHBDAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x73440A0", Offset = "0x73426A0", VA = "0x1873440A0")]
	private static void GLEFBGGLDOE(Dictionary<IMJMIIIPNLF, Material> FMPOBMMKKCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7347340", Offset = "0x7345940", VA = "0x187347340")]
	private static void MJJBIKBIJAJ(Dictionary<Renderer, MIGKACJGENE> GEMDCFELCIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7343340", Offset = "0x7341940", VA = "0x187343340")]
	private void FKCLIPAIKLH(SkinnedMeshRenderer[] LGCGHBBEHDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x73466F0", Offset = "0x7344CF0", VA = "0x1873466F0")]
	private void KFIADIGLLCL(SkinnedMeshRenderer BNBIMMBDEGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x733E420", Offset = "0x733CA20", VA = "0x18733E420")]
	private void BHFKGFPBMHJ(List<BELJNJGLPJA> MNMNOHFPEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x733E970", Offset = "0x733CF70", VA = "0x18733E970")]
	private void CAIEKJGOFML(Dictionary<string, EBHOPDBMNPK<Texture2D>> JAGFBALGAPL, bool EFJOBKAGFFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x733F9D0", Offset = "0x733DFD0", VA = "0x18733F9D0")]
	private void CLLAHGOCKNB(Dictionary<string, List<IMJMIIIPNLF>> JAGFBALGAPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7347BD0", Offset = "0x73461D0", VA = "0x187347BD0")]
	private void ODCMPKEKNCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7346E40", Offset = "0x7345440", VA = "0x187346E40")]
	private void LPBEFJCMGJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x733FC80", Offset = "0x733E280", VA = "0x18733FC80")]
	private void DBAIAPIILEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7346D40", Offset = "0x7345340", VA = "0x187346D40")]
	private void LFKMMFOACNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x733E140", Offset = "0x733C740", VA = "0x18733E140")]
	private void BFIMLPECHEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x733FB30", Offset = "0x733E130", VA = "0x18733FB30")]
	private void CMDJHDLPEJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7342E90", Offset = "0x7341490", VA = "0x187342E90")]
	private void ECNGNBJDNCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7343A00", Offset = "0x7342000", VA = "0x187343A00")]
	private void GAIFEHJDNPM(bool HNDDCLFFMIK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x733E600", Offset = "0x733CC00", VA = "0x18733E600")]
	private void BJHIEHKBHFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x733DC50", Offset = "0x733C250", VA = "0x18733DC50")]
	private void ALGJOIFHCLL(bool HNDDCLFFMIK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7347D20", Offset = "0x7346320", VA = "0x187347D20")]
	private void OEIPAJKFPDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7343BA0", Offset = "0x73421A0", VA = "0x187343BA0")]
	private void GFFKCEINPGG(Material PFHJOFPFGCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7346FF0", Offset = "0x73455F0", VA = "0x187346FF0")]
	private void LPOKHIGGAFD(Material PFHJOFPFGCD, Color MHFFAABGINO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x733E1D0", Offset = "0x733C7D0", VA = "0x18733E1D0")]
	private void BHDHMDFKPKI(Material PFHJOFPFGCD, Color MHFFAABGINO, Color OCMCDEJGILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7349140", Offset = "0x7347740", VA = "0x187349140")]
	private void PJAIJHDGNNK(Material PFHJOFPFGCD, Color KDBCFKGNGJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x733EDA0", Offset = "0x733D3A0", VA = "0x18733EDA0")]
	private void CECPCFJCCGD(Material PFHJOFPFGCD, Texture2D IHOMIJNFMIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7346B10", Offset = "0x7345110", VA = "0x187346B10")]
	private void LDBPDDIDAKN(Material PFHJOFPFGCD, Texture NCEMIDDEIKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x733DAE0", Offset = "0x733C0E0", VA = "0x18733DAE0")]
	private void AGKEIJHGJBH(Action<MIGKACJGENE> EGIANMPBNKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7343460", Offset = "0x7341A60", VA = "0x187343460")]
	private void FKJKJIHKKKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x73492E0", Offset = "0x73478E0", VA = "0x1873492E0")]
	private void PMMHFCAJJJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7349730", Offset = "0x7347D30", VA = "0x187349730")]
	private void PPBJFNHBJDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7347610", Offset = "0x7345C10", VA = "0x187347610")]
	public void NBNLELFONJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x73431A0", Offset = "0x73417A0", VA = "0x1873431A0", Slot = "4")]
	private void EONHMMPPIIL([In] ADGPJAEELJF AMOHALPGLJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7343040", Offset = "0x7341640", VA = "0x187343040")]
	[CompilerGenerated]
	private HJOKANJAKGB EJDABMAJPFD(CEHPNHHBNNM FCEAHINHNGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7345E70", Offset = "0x7344470", VA = "0x187345E70")]
	[CompilerGenerated]
	private void JACHEAJDNLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7346A50", Offset = "0x7345050", VA = "0x187346A50")]
	[CompilerGenerated]
	private void KNMJHEPOHGP(MIGKACJGENE AKHBEIJLAGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7343220", Offset = "0x7341820", VA = "0x187343220")]
	[CompilerGenerated]
	private void FFBDMLAEFHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7348370", Offset = "0x7346970", VA = "0x187348370")]
	[CompilerGenerated]
	private void PAFKAIDPKJK(MIGKACJGENE AKHBEIJLAGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x73453A0", Offset = "0x73439A0", VA = "0x1873453A0")]
	[CompilerGenerated]
	private void GPBCMCGEPEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7346FD0", Offset = "0x73455D0", VA = "0x187346FD0")]
	[CompilerGenerated]
	private void LPLAGDMGGGF(MIGKACJGENE AKHBEIJLAGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x73432B0", Offset = "0x73418B0", VA = "0x1873432B0")]
	[CompilerGenerated]
	private void FJBGFPOGNIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x733FB00", Offset = "0x733E100", VA = "0x18733FB00")]
	[CompilerGenerated]
	private void CMBEJLNGKMF(MIGKACJGENE AKHBEIJLAGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7346A80", Offset = "0x7345080", VA = "0x187346A80")]
	[CompilerGenerated]
	private void KPDMKICIOJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7346E10", Offset = "0x7345410", VA = "0x187346E10")]
	[CompilerGenerated]
	private void LJBEAGBODLA(MIGKACJGENE AKHBEIJLAGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x7347170", Offset = "0x7345770", VA = "0x187347170")]
	[CompilerGenerated]
	private void MBBLABPJMPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7342E60", Offset = "0x7341460", VA = "0x187342E60")]
	[CompilerGenerated]
	private void DOIGMIDGLCM(MIGKACJGENE AKHBEIJLAGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x733F590", Offset = "0x733DB90", VA = "0x18733F590")]
	[CompilerGenerated]
	private void CGKNGLBKKEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7346150", Offset = "0x7344750", VA = "0x187346150")]
	[CompilerGenerated]
	private void JAPEMILPJLP(MIGKACJGENE AKHBEIJLAGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7347AC0", Offset = "0x73460C0", VA = "0x187347AC0")]
	[CompilerGenerated]
	private void NIAFNMJDGNM(KeyValuePair<string, EBHOPDBMNPK<Texture2D>> ONFJMGPMMKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7347BC0", Offset = "0x73461C0", VA = "0x187347BC0")]
	[CompilerGenerated]
	private void OCFJFLNBKEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x73454B0", Offset = "0x7343AB0", VA = "0x1873454B0")]
	[CompilerGenerated]
	private void HIIKKOMJBIE(MIGKACJGENE AKHBEIJLAGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x73435E0", Offset = "0x7341BE0", VA = "0x1873435E0")]
	[CompilerGenerated]
	private void FLMGOJPMAIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7345A20", Offset = "0x7344020", VA = "0x187345A20")]
	[CompilerGenerated]
	private void IGCEBIMHFBP(MIGKACJGENE AKHBEIJLAGO)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class AvatarElbowBendHelperController : MonoBehaviour, GGHNALLMHEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		[ALEFAIIJNEI(KCNGGJNCENB.Self, false, false, false)]
		[SerializeField]
		private Transform ElbowHelperBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		[SerializeField]
		private Transform UpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		[SerializeField]
		private Transform LowerArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		[SerializeField]
		private float MinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		[SerializeField]
		private float MaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		[FormerlySerializedAs("MinScaleValues")]
		[Header("Scale")]
		[SerializeField]
		private Vector3 ScaleValuesAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		[FormerlySerializedAs("MaxScaleValues")]
		[SerializeField]
		private Vector3 ScaleValuesAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		[FormerlySerializedAs("MinLocalPositionalOffset")]
		[SerializeField]
		[Header("Positional Offset")]
		private Vector3 PositionalOffsetAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		[FormerlySerializedAs("MaxLocalPositionOffset")]
		[SerializeField]
		private Vector3 PositionalOffsetAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private Vector3? GANOPDCMOMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private bool NOMGHFOBMPE;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x734C790", Offset = "0x734AD90", VA = "0x18734C790", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x734CDC0", Offset = "0x734B3C0", VA = "0x18734CDC0", Slot = "4")]
		public void UpdateController(float HIBCBLOKLEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xAE5880", Offset = "0xAE3E80", VA = "0x180AE5880", Slot = "6")]
		public void SetEnabled(bool KBGCCIOIGBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x734C870", Offset = "0x734AE70", VA = "0x18734C870")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x734D280", Offset = "0x734B880", VA = "0x18734D280")]
		public AvatarElbowBendHelperController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class AvatarElbowBendTargetController : MonoBehaviour, GGHNALLMHEG
	{
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private const float OKCJLFHHIEE = 45f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[ALEFAIIJNEI(KCNGGJNCENB.Self, false, false, false)]
		[SerializeField]
		private Transform ElbowBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[SerializeField]
		private Transform NeckBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[SerializeField]
		private Transform UpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		[SerializeField]
		private bool Left;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		[SerializeField]
		private float MinTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		[SerializeField]
		private float MaxTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		[SerializeField]
		private float TwistWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		[SerializeField]
		private float ElbowSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[SerializeField]
		private float RestTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[SerializeField]
		private float RestTwistWhenClose;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[SerializeField]
		private float RestTwistDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private Vector3 AHCEBGJJBDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private Vector3 EBNHCOCJNCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private bool NOMGHFOBMPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private float LFEPJIIJABL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private float CIFJOMCFDKC;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x734D600", Offset = "0x734BC00", VA = "0x18734D600", Slot = "4")]
		public void UpdateController(float HIBCBLOKLEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xF8C960", Offset = "0xF8AF60", VA = "0x180F8C960", Slot = "6")]
		public void SetEnabled(bool KBGCCIOIGBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x734D320", Offset = "0x734B920", VA = "0x18734D320")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x734E0C0", Offset = "0x734C6C0", VA = "0x18734E0C0")]
		public AvatarElbowBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class APDDFGMKIOL : JGOJAJEODNM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private static readonly int IBFGCGCFPBP;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private static readonly int GPAFEDGFKPO;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private static readonly int AMNJFDJKANF;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private static readonly int FIOJCHLFMNC;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly int FIOFPOGEFAO;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static readonly int AGFCBCFADAI;

	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private static readonly int DHMMGKGJKKD;

	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private static readonly int JJJGJKLIDJA;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private static readonly int MNNEDHLIKFG;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private static readonly int BNOLNCMPKDM;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static readonly int OFHLLPFGONH;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private static readonly int AIJNMDMEGKG;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static readonly int KBAKEIEOCBJ;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static readonly int PFFANECHCDF;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private static readonly int FGIDBHPEKBP;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private static readonly int LHBNHJJFIBG;

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private static readonly int IDHKHCAGJBL;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private static readonly int MEPJFDNIMPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private Transform GDMCHKLBOGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private Transform IPKKODOFLLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private Transform BGLMCNONJAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private Transform LBFOFALKNGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private Transform NEDHPLMMHCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private Transform JMFEKECIDKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private Transform NGKMLAFOBII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private HCEOCPHCBKP GCHMGNNGODI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private Material MDKPPEMMGGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private SkinnedMeshRenderer[] IGOAMNMIHOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private readonly List<Material> IMMNOELIFLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private ANAHCJOGKFH AIEEDLJCECF;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public FKDOIPNGGAF HNELGOJBNPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x950410", Offset = "0x94EA10", VA = "0x180950410", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	private ANAHCJOGKFH LLDPFCIIMIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x734B420", Offset = "0x7349A20", VA = "0x18734B420")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool KFMLNKJFEGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x734ADC0", Offset = "0x73493C0", VA = "0x18734ADC0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x734A960", Offset = "0x7348F60", VA = "0x18734A960")]
	public void HPHCPPKCEKM([In] HCEOCPHCBKP JGMKPBHIMFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x734A3D0", Offset = "0x73489D0", VA = "0x18734A3D0")]
	public void HCAEKEIHCKK([In] EBEGNBNODAH FOGHNNFMDBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x734AF40", Offset = "0x7349540", VA = "0x18734AF40", Slot = "6")]
	public void JLBPJMLBHDM(LJHCODOFFPO OANFHMCJHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x734A900", Offset = "0x7348F00", VA = "0x18734A900")]
	private Vector2 FILCJHCAKBD(Vector2 FEMIJKGPBOF)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x734B4B0", Offset = "0x7349AB0", VA = "0x18734B4B0")]
	public void OIKAMCFDLFG([In] KJFGCCOFHCI FOGHNNFMDBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x734A5B0", Offset = "0x7348BB0", VA = "0x18734A5B0")]
	private void FIAHCJICMKH(PJLHDFEOPIO GNENFLCKOEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x734AA30", Offset = "0x7349030", VA = "0x18734AA30")]
	private void IFNFMHLBFID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x734A540", Offset = "0x7348B40", VA = "0x18734A540")]
	private void HIAEKHLABAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x734A540", Offset = "0x7348B40", VA = "0x18734A540", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x734C690", Offset = "0x734AC90", VA = "0x18734C690")]
	public APDDFGMKIOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x734A3D0", Offset = "0x73489D0", VA = "0x18734A3D0", Slot = "5")]
	private void BEPIMAKFNFN([In] EBEGNBNODAH FOGHNNFMDBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x734B4A0", Offset = "0x7349AA0", VA = "0x18734B4A0", Slot = "7")]
	private void LHBJKAFFFBB([In] KJFGCCOFHCI FOGHNNFMDBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x734A470", Offset = "0x7348A70", VA = "0x18734A470")]
	[CompilerGenerated]
	internal static (float, float) DACBKLPBOHD(float JNINICKAAEA)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x734A500", Offset = "0x7348B00", VA = "0x18734A500")]
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
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		[SerializeField]
		private Transform TwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		[SerializeField]
		private Transform LowerArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		[SerializeField]
		private Transform UpperArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		[SerializeField]
		private Transform ElbowTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		[SerializeField]
		private float RollTowardsWristAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		[SerializeField]
		private float RollSoftMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		[SerializeField]
		private float RollSoftMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		[SerializeField]
		private float LowerArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		[SerializeField]
		private float UpperArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		[SerializeField]
		private float ElbowTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private float LFEPJIIJABL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private bool NOMGHFOBMPE;

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7356020", Offset = "0x7354620", VA = "0x187356020", Slot = "4")]
		public void UpdateController(float HIBCBLOKLEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x14698D0", Offset = "0x1467ED0", VA = "0x1814698D0", Slot = "6")]
		public void SetEnabled(bool KBGCCIOIGBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7356AB0", Offset = "0x73550B0", VA = "0x187356AB0")]
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
			[Cpp2IlInjected.Token(Token = "0x4000168")]
			[Tooltip("Name of animation original state to override")]
			public string OriginalName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000169")]
			[Tooltip("Name of animation state to use as an override")]
			public string OverrideName;

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
			public AnimationOverride()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		[SerializeField]
		private AnimationOverride[] HandStateOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private Dictionary<int, int> _animationOverrides;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x7356AE0", Offset = "0x73550E0", VA = "0x187356AE0")]
		public void CIDIOEOELJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7356C00", Offset = "0x7355200", VA = "0x187356C00")]
		public int JDPBEDLFJKE(int CCOKICHEIDB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public AvatarHandDisplaySettings()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class MNJGAOGMOGO : MMBJEOAHHDI
{
	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7361C00", Offset = "0x7360200", VA = "0x187361C00", Slot = "22")]
	public override float EBDMMHCFIAE()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7361C50", Offset = "0x7360250", VA = "0x187361C50")]
	public MNJGAOGMOGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class MMBJEOAHHDI : ODFMHACHCFM
{
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private static int LOGPJIFCGOO;

	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private static int OMOOFGINEAH;

	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private static int MCICBJKDIBC;

	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private static int LANGJNOKKOJ;

	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private static int OLLDOJHKJJE;

	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private static int MHOPBAGDJDK;

	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private static int PJDJBGIJOBM;

	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private static int[] HJAAIAKFBBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private IGLCKFKINMF GCHMGNNGODI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private EJIHPHLOCCI AAKOPGCJKCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private int GJHCLAJLJBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private float CAJDOHBGPHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	protected Animator EJJCIBPIAHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	protected bool LOFMAMCHNDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	protected AvatarConfiguration EIDMBNPDBFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	protected int MNKANOBGEMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private int LJECJCNMOHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private int OPDBNIEBOCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private bool LJEMCLEEPBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private BDFIOIHGFPK EPIFEAPMJOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private int BDPEKAOKCJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private float MIDEJGJADPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private AvatarHandDisplaySettings PFPGBAJIFEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private PKOOKMMPLDP IEKFNPGCMLH;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Transform KGNNJLOOJEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x950410", Offset = "0x94EA10", VA = "0x180950410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x950400", Offset = "0x94EA00", VA = "0x180950400")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public Vector3 PPNHFIJIFMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x146C5B0", Offset = "0x146ABB0", VA = "0x18146C5B0")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x146C5A0", Offset = "0x146ABA0", VA = "0x18146C5A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Quaternion AJLIFHAIEDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xBCCAB0", Offset = "0xBCB0B0", VA = "0x180BCCAB0")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x1527560", Offset = "0x1525B60", VA = "0x181527560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool POEAFFIIBMB
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x73618E0", Offset = "0x735FEE0", VA = "0x1873618E0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x7361270", Offset = "0x735F870", VA = "0x187361270")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Vector3 MMLBMEAMOJD
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x7360DE0", Offset = "0x735F3E0", VA = "0x187360DE0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x73613B0", Offset = "0x735F9B0", VA = "0x1873613B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public Quaternion MKEJBNNGPFP
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x73612A0", Offset = "0x735F8A0", VA = "0x1873612A0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x7361560", Offset = "0x735FB60", VA = "0x187361560")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public BKMINCPGJKF AIIFODLIICG
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xA42C50", Offset = "0xA41250", VA = "0x180A42C50", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(BKMINCPGJKF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xA42570", Offset = "0xA40B70", VA = "0x180A42570", Slot = "4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public BKMINCPGJKF ODIPAAPDCBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x22164A0", Offset = "0x2214AA0", VA = "0x1822164A0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(BKMINCPGJKF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x2215400", Offset = "0x2213A00", VA = "0x182215400", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public float FGHNCMHKPHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x12A8110", Offset = "0x12A6710", VA = "0x1812A8110", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0xD80890", Offset = "0xD7EE90", VA = "0x180D80890", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool CBOOKLCDGIM
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7361310", Offset = "0x735F910", VA = "0x187361310")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool JPPNIHOEPLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x73610B0", Offset = "0x735F6B0", VA = "0x1873610B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool JJEGJBBEDPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x7361260", Offset = "0x735F860", VA = "0x187361260")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool KIHHPHKKEAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7360EC0", Offset = "0x735F4C0", VA = "0x187360EC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x73610C0", Offset = "0x735F6C0", VA = "0x1873610C0", Slot = "21")]
	public void HPHCPPKCEKM(IGLCKFKINMF JGMKPBHIMFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x7360D90", Offset = "0x735F390", VA = "0x187360D90")]
	public void ADCJCMBAKIL(EJIHPHLOCCI HEFCMACDPLN, AvatarHandDisplaySettings KPGGOJINIFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x7360E20", Offset = "0x735F420", VA = "0x187360E20", Slot = "12")]
	public void EDAHKMEMLOP(bool BDDPPMGPFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x7361570", Offset = "0x735FB70", VA = "0x187361570", Slot = "11")]
	public void OMAKKDABCOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x12A8110", Offset = "0x12A6710", VA = "0x1812A8110", Slot = "22")]
	public virtual float EBDMMHCFIAE()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x73613D0", Offset = "0x735F9D0", VA = "0x1873613D0")]
	private int NDPCOEKEMOD(BKMINCPGJKF FBELANIEJHJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x7360ED0", Offset = "0x735F4D0", VA = "0x187360ED0")]
	private void FDJFOKPCBEP(int DLKPDCFEICC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x7361090", Offset = "0x735F690", VA = "0x187361090", Slot = "13")]
	public bool GHMCGLBCKEN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x7360EB0", Offset = "0x735F4B0", VA = "0x187360EB0", Slot = "14")]
	public bool EDGPGBLGCEG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x7361320", Offset = "0x735F920", VA = "0x187361320")]
	private BKMINCPGJKF LGJAGLKANJM()
	{
		return default(BKMINCPGJKF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x1B56620", Offset = "0x1B54C20", VA = "0x181B56620", Slot = "15")]
	public void PNMEIICHOJD(bool BDDPPMGPFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x7361370", Offset = "0x735F970", VA = "0x187361370", Slot = "10")]
	public void LPAJNDKNONK(int DLKPDCFEICC, float NONELKGPFBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x7360E00", Offset = "0x735F400", VA = "0x187360E00", Slot = "8")]
	public void CEBEGADHIPH(BDFIOIHGFPK CEGAGHAOIDD, bool IMLBMCFLIEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x73612B0", Offset = "0x735F8B0", VA = "0x1873612B0", Slot = "9")]
	public void JMNCFNELJHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x73612C0", Offset = "0x735F8C0", VA = "0x1873612C0", Slot = "16")]
	public void KCNGJAFNLMF(Transform LDIAONMHHPK, Vector3 ELJHIGPGIBG, Quaternion ODOBDLNNBLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x7361BE0", Offset = "0x73601E0", VA = "0x187361BE0")]
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
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public IMMLCIEBDAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public List<BELJNJGLPJA> prefabHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public List<BELJNJGLPJA> materialHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public EBHOPDBMNPK<Material[]> loadMaterialsHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public EBHOPDBMNPK<FMPJGLDDHNE> loadPrefabHandle;

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public CHLLADLMKPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x7359120", Offset = "0x7357720", VA = "0x187359120")]
		internal HJOKANJAKGB LOGAJHNFGKB(string error)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	public LJKKDAKGHIG PFICMLEHNHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	public FMPJGLDDHNE CCNGHIHCOMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private EBHOPDBMNPK<FMPJGLDDHNE> LIJEDLKIJCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private EBHOPDBMNPK<Material[]> GBNOEKKHCEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public Material[] PKMHMAPNIDB;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool IPKEKBKAGEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x97F1A0", Offset = "0x97D7A0", VA = "0x18097F1A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x97EF20", Offset = "0x97D520", VA = "0x18097EF20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public KBAIGJMAONF.FALICHFPADL ONDEFDKNLBG
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x952DD0", Offset = "0x9513D0", VA = "0x180952DD0")]
		[CompilerGenerated]
		get
		{
			return default(KBAIGJMAONF.FALICHFPADL);
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x9529C0", Offset = "0x950FC0", VA = "0x1809529C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x735CA80", Offset = "0x735B080", VA = "0x18735CA80")]
	public IMMLCIEBDAG(OBJHNMCDGDL MKJCGACHDHK, LJKKDAKGHIG GLBBLAAJPLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x735B800", Offset = "0x7359E00", VA = "0x18735B800", Slot = "6")]
	public override HJOKANJAKGB EJFPOGPKNJP(List<BELJNJGLPJA> NJNODBJNKGK, List<BELJNJGLPJA> CFOHIHHANCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x735C510", Offset = "0x735AB10", VA = "0x18735C510")]
	public HJOKANJAKGB OPLBBAGBMLP(List<BELJNJGLPJA> NJNODBJNKGK, List<BELJNJGLPJA> CFOHIHHANCN, EBHOPDBMNPK<Material[]> GBNOEKKHCEM, [Optional] EBHOPDBMNPK<FMPJGLDDHNE> GJJHPPJIBFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x735BCC0", Offset = "0x735A2C0", VA = "0x18735BCC0")]
	public (EBHOPDBMNPK<Material[]>, EBHOPDBMNPK<FMPJGLDDHNE>) EOJKJNHONLL(List<BELJNJGLPJA> NJNODBJNKGK, List<BELJNJGLPJA> CFOHIHHANCN)
	{
		return default((EBHOPDBMNPK<Material[]>, EBHOPDBMNPK<FMPJGLDDHNE>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x735C3C0", Offset = "0x735A9C0", VA = "0x18735C3C0", Slot = "7")]
	public override KIFHJDJPHPE HHCBKNFBCHD(uint GNAJNFCKONF, AvatarSkinnedMeshBoneOrderRemapsData MINBMMFMOIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x735C820", Offset = "0x735AE20", VA = "0x18735C820")]
	public KIFHJDJPHPE PLLNNKHCJDO(GameObject MOCILOCGFBE, uint GNAJNFCKONF, bool IHELEDGMCLB, bool HCEJKJKCPLD, AvatarSkinnedMeshBoneOrderRemapsData MINBMMFMOIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x735C050", Offset = "0x735A650", VA = "0x18735C050")]
	public static bool FAGEKODAMGL(Renderer[] LGCGHBBEHDN, string ANKMHOKKNFA, [Out] Renderer AKCIMNHMBGI, [Out] Renderer LKGPDOBPHMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x735CA30", Offset = "0x735B030", VA = "0x18735CA30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x735B730", Offset = "0x7359D30", VA = "0x18735B730")]
	private (EBHOPDBMNPK<FMPJGLDDHNE>, EBHOPDBMNPK<Material[]>) AMMOKNKHOIK()
	{
		return default((EBHOPDBMNPK<FMPJGLDDHNE>, EBHOPDBMNPK<Material[]>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x735C4F0", Offset = "0x735AAF0", VA = "0x18735C4F0")]
	[CompilerGenerated]
	private void IGIINABNLPD(FMPJGLDDHNE BIEIOPPGBOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x958C70", Offset = "0x957270", VA = "0x180958C70")]
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
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		[SerializeField]
		[ALEFAIIJNEI(KCNGGJNCENB.Self, false, false, false)]
		private Transform KneeBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		[SerializeField]
		private Transform RootSpineBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		[SerializeField]
		private Transform ThighBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		[SerializeField]
		private Transform FootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		[SerializeField]
		private float WeightToFootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		[SerializeField]
		private Vector3 BendTargetOffsetFromHipToFootMidPoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		[SerializeField]
		private Bounds KneeTargetConstrainedBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private Vector3 AHCEBGJJBDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private Vector3 EFNPGILCGPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private Vector3 NAJFLODHIIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private Matrix4x4 HBCBOEGDBAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private bool NOMGHFOBMPE;

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x73570E0", Offset = "0x73556E0", VA = "0x1873570E0", Slot = "4")]
		public void UpdateController(float HIBCBLOKLEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x73570D0", Offset = "0x73556D0", VA = "0x1873570D0", Slot = "6")]
		public void SetEnabled(bool KBGCCIOIGBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x7356C70", Offset = "0x7355270", VA = "0x187356C70")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x73577A0", Offset = "0x7355DA0", VA = "0x1873577A0")]
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
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	[ReadOnly]
	public PFCDOEJMIDA FBAIBDOFCNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	[ReadOnly]
	public int JHFADOMOOGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public NHEMOJHNGLC DFGJCDCKNNI;

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x7362B60", Offset = "0x7361160", VA = "0x187362B60", Slot = "4")]
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
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public NativeArray<Vector3> PJPHLIICOIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	public NativeArray<Vector3> MFHDKAJNHGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	public NativeArray<Vector4> EAGILGGDNGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	public NativeArray<Vector2> ALODLBEKEAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	public NativeArray<Vector2> PJLCOIJPIGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	public NativeArray<Vector2> NOHDKIBMBNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	public NativeArray<Vector2> CNBIBBCOKBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public NativeArray<Color> OFGJFMEFBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public NativeArray<int> BJHAHFBHIIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public NativeArray<int> JGLDDBAALLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private NativeArray<int> HAMIKIAMKCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private NativeArray<int> GNFLPDPHGLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public NativeArray<int> PBAPNCFANJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public NativeArray<int> PBBOIIKEKLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	public NativeArray<int> ABEBHMJIFGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	public NativeArray<BoneWeight> EECFMIFBEOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private NativeArray<int> FJJOKDBOKAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private bool LAMMAOBONGB;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public int GMBBBJCHFML
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7362150", Offset = "0x7360750", VA = "0x187362150")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x73621F0", Offset = "0x73607F0", VA = "0x1873621F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int FKDAOBCELNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x73621D0", Offset = "0x73607D0", VA = "0x1873621D0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x7361CE0", Offset = "0x73602E0", VA = "0x187361CE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public int BIJLPBFCEML
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x7361F00", Offset = "0x7360500", VA = "0x187361F00")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x73621E0", Offset = "0x73607E0", VA = "0x1873621E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x7362700", Offset = "0x7360D00", VA = "0x187362700")]
	public NHEMOJHNGLC(int DCAPCHJBFBL, int KIJGJIIFKFG, int JGOLOKHACFH, int KMLBPKIICHM, Allocator LEILKJFLDFN, int PJIBNECOEEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x73620E0", Offset = "0x73606E0", VA = "0x1873620E0")]
	public void HHPMHFMNAJF(int EAHKFAJBNDN, Vector3 EFDAGALIIFI, Vector3 EOJJAMCHAEH, Vector4 CHBEBLKFDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7362200", Offset = "0x7360800", VA = "0x187362200")]
	public void OKJKLFJLGAK(int EAHKFAJBNDN, BoneWeight OMGFMBIBPEF, NativeSlice<byte> FFEHGHDGBPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x73621B0", Offset = "0x73607B0", VA = "0x1873621B0")]
	public Color JNLBMPGFNHP(int EAHKFAJBNDN)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x73620C0", Offset = "0x73606C0", VA = "0x1873620C0")]
	public void HEJAGELOGAE(int EAHKFAJBNDN, Color OPLPABIPAJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x7362160", Offset = "0x7360760", VA = "0x187362160")]
	public void HPCGJKIOAEP(byte PNAPGIMAEDK, int EAHKFAJBNDN, Vector2 JLECHKDJMOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x73623A0", Offset = "0x73609A0", VA = "0x1873623A0")]
	public void ONEPFBFBNOF(int EAHKFAJBNDN, int LFPNFLHKPCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x7361CB0", Offset = "0x73602B0", VA = "0x187361CB0")]
	public bool ABJNLCGOEJM(int PNAPGIMAEDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x7361DA0", Offset = "0x73603A0", VA = "0x187361DA0")]
	public void APGKCNCJEMG(int GCNALCOKJIM, int FDJGEFDKBBO, int GIGAFKHMOHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x7361CF0", Offset = "0x73602F0", VA = "0x187361CF0")]
	public int[] APFFNBBENFP(int GCNALCOKJIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x7361E70", Offset = "0x7360470", VA = "0x187361E70")]
	private NativeSlice<int> BGDJEAFBDKM(int GCNALCOKJIM)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x7361F10", Offset = "0x7360510", VA = "0x187361F10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x73623B0", Offset = "0x73609B0", VA = "0x1873623B0")]
	public Mesh PCNJPGHJCAK([Optional] string IHJJNKIBIDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[GAFKBMEFLIK]
[DefaultMember("Item")]
[NativeContainer]
public struct PFCDOEJMIDA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	public NativeArray<Vector3> PJPHLIICOIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public NativeArray<Vector3> MFHDKAJNHGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	public NativeArray<Vector4> EAGILGGDNGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	public NativeArray<Vector2> ALODLBEKEAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	public NativeArray<Vector2> PJLCOIJPIGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	public NativeArray<Vector2> NOHDKIBMBNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	public NativeArray<Vector2> CNBIBBCOKBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	public NativeArray<Color> OFGJFMEFBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public NativeArray<int> AMKEHPEMAPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public NativeArray<int> EONDMLIJCFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public NativeArray<int> OFMEBMPMPHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public NativeArray<int> FDODPKLBOFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public NativeArray<bool> MBLBPIKGHBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public NativeArray<int> ELAEEHODNCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	public NativeArray<int> HJCAIMNKFOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public NativeArray<BoneWeight> DCJEJNMJFBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private NativeArray<Matrix4x4> IEGPKLJFIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private NativeArray<long> PCGCNHMBOII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private NativeArray<byte> MNDAPPCMLNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private NativeArray<int> BGDEOHHMEIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private NativeArray<int> GPIMJGLPKAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	public NativeArray<sbyte> CBPNDGKJKKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	public NativeArray<byte> IMBLHDMFKOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private NativeArray<int> LJCGAEHNNDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private bool LAMMAOBONGB;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int AILANCGLNEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x2587DE0", Offset = "0x25863E0", VA = "0x182587DE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int IPNIHLGMKHD
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xAE82A0", Offset = "0xAE68A0", VA = "0x180AE82A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int AKEIDLPADKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x7365370", Offset = "0x7363970", VA = "0x187365370")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public int NGNEIPBLGEK
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x7364DF0", Offset = "0x73633F0", VA = "0x187364DF0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x7365350", Offset = "0x7363950", VA = "0x187365350")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int GMBBBJCHFML
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x7364DE0", Offset = "0x73633E0", VA = "0x187364DE0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7365340", Offset = "0x7363940", VA = "0x187365340")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int KLOCEPDAPGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x7364A60", Offset = "0x7363060", VA = "0x187364A60")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x7364B40", Offset = "0x7363140", VA = "0x187364B40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public LDBIEKJHPFI NEICIGCPFDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x7365360", Offset = "0x7363960", VA = "0x187365360")]
		get
		{
			return default(LDBIEKJHPFI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x7364DC0", Offset = "0x73633C0", VA = "0x187364DC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public byte PEEONGELKEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x7364DD0", Offset = "0x73633D0", VA = "0x187364DD0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7365330", Offset = "0x7363930", VA = "0x187365330")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public BMIFNDOJLHO NMMCMNBCFHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7364E00", Offset = "0x7363400", VA = "0x187364E00")]
		get
		{
			return default(BMIFNDOJLHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x73653A0", Offset = "0x73639A0", VA = "0x1873653A0")]
	public PFCDOEJMIDA(IList<Mesh> JMIOOBAANOC, IList<Matrix4x4> AIGFAHJHCPH, IList<bool> MBLBPIKGHBL, byte DDBNJCIKGBE, IList<byte[]> ONOJOCHFGBF, IList<long> AJBCMOLPIAF, IList<bool> OKLIGHJAMIK, IList<int> ELAEEHODNCP, IList<int> MPNCJGPMPPN, IList<int> LDFOIFFKFJH, Allocator LEILKJFLDFN, LDBIEKJHPFI KKPPEJOKKDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x7364A70", Offset = "0x7363070", VA = "0x187364A70")]
	public NHEMOJHNGLC AODCLOLHDIH(Allocator LEILKJFLDFN)
	{
		return default(NHEMOJHNGLC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x7364B50", Offset = "0x7363150", VA = "0x187364B50", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[GAFKBMEFLIK]
public class DPCLJJNJOGA : NJGDPEGMCOM
{
	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x7359610", Offset = "0x7357C10", VA = "0x187359610")]
	public PFCDOEJMIDA PCKDJDEKJBB()
	{
		return default(PFCDOEJMIDA);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x734E830", Offset = "0x734CE30", VA = "0x18734E830")]
	public DPCLJJNJOGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct BMIFNDOJLHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	public NativeSlice<Vector3> PJPHLIICOIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	public NativeSlice<Vector3> MFHDKAJNHGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public NativeSlice<Vector4> EAGILGGDNGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public NativeSlice<Vector2> ALODLBEKEAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public NativeSlice<Vector2> PJLCOIJPIGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	public NativeSlice<Vector2> NOHDKIBMBNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public NativeSlice<Vector2> CNBIBBCOKBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public NativeSlice<Color> OFGJFMEFBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public NativeSlice<int> GOOIBFEMHJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public NativeSlice<int> FDODPKLBOFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public NativeSlice<BoneWeight> DCJEJNMJFBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public NativeSlice<byte> OPHBJCBBLNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	public int OCJOEDICIGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public Matrix4x4 ABJKIHNEOGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public long JIJOKOIODIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public NativeSlice<byte> FFEHGHDGBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public bool CEPINDKOFMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	public int CMNAJANMPNF;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal readonly struct IMJMIIIPNLF : IEquatable<IMJMIIIPNLF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	internal readonly Material IAODGAIPHAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	internal readonly BJGDFBKEINK ACJJLKFOJDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	internal readonly DDOKGHHJODE AOAFMIIPOPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	internal readonly OBJHNMCDGDL IDLHGNGCIKJ;

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x735B6F0", Offset = "0x7359CF0", VA = "0x18735B6F0")]
	public IMJMIIIPNLF(Material HJCEHLILOIG, BJGDFBKEINK PIEGLLCHINN, DDOKGHHJODE IPEPMKFNFHH, OBJHNMCDGDL DBDEIKJCEBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x735B4C0", Offset = "0x7359AC0", VA = "0x18735B4C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x735B2B0", Offset = "0x73598B0", VA = "0x18735B2B0", Slot = "4")]
	public bool Equals(IMJMIIIPNLF OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x735B330", Offset = "0x7359930", VA = "0x18735B330", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x735B420", Offset = "0x7359A20", VA = "0x18735B420", Slot = "2")]
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
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		[SerializeField]
		[Header("Configuration")]
		protected AvatarConfiguration configuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		[SerializeField]
		protected Animator skeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		[SerializeField]
		protected Renderer[] watchRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		[SerializeField]
		[Header("Configuration")]
		private PKOOKMMPLDP avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		[SerializeField]
		private AvatarSkinAssetItem potatoAvatarSkinAssetItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		[SerializeField]
		[FormerlySerializedAs("avatarSkinAsset")]
		private AssetReference avatarSkinAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		[SerializeField]
		private GameObject firstPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		[SerializeField]
		public GameObject thirdPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		[SerializeField]
		private GameObject[] hideInFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		[SerializeField]
		protected Transform headAdditiveBaseBoneTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		[SerializeField]
		private Material BodyMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		[SerializeField]
		private Material FaceMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		[SerializeField]
		private Material DefaultAvatarItemMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		[SerializeField]
		private Shader AvatarDefaultShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		[SerializeField]
		private Shader AvatarUberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		[SerializeField]
		private Transform DeformRigRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		[SerializeField]
		private SkinnedMeshRenderer BaseSkinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		[SerializeField]
		protected AvatarSkinnedMeshBoneOrderRemapsData BoneOrderRemapsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		[Header("Arm Animation Controllers")]
		[SerializeField]
		private AvatarForearmRollController LeftForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		[SerializeField]
		private AvatarElbowBendHelperController LeftElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		[SerializeField]
		private AvatarElbowBendTargetController LeftElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		[SerializeField]
		private AvatarKneeBendTargetController LeftKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		[SerializeField]
		private AvatarForearmRollController RightForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		[SerializeField]
		private AvatarElbowBendHelperController RightElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		[SerializeField]
		private AvatarElbowBendTargetController RightElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		[SerializeField]
		private AvatarKneeBendTargetController RightKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		[SerializeField]
		private Transform LeftEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		[SerializeField]
		private Transform LeftEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		[SerializeField]
		private Transform RightEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		[SerializeField]
		private Transform RightEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		[SerializeField]
		private Transform NoseMoveTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		[SerializeField]
		private Transform NoseScaleTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		[SerializeField]
		private Transform MouthBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		[SerializeField]
		private AvatarBodyPartShapesManager avatarBodyPartShapesManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		[SerializeField]
		private Transform HatAnchorBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		[SerializeField]
		private Transform LeftHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		[SerializeField]
		private Transform RightHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		[SerializeField]
		private GameObject LeftHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		[SerializeField]
		private GameObject RightHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private AHBNJGDEGOO CLLKMBMJEFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private JGOJAJEODNM GMIJCCPBOIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private ODFMHACHCFM PKJKEKAGLJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private ODFMHACHCFM CLFKCPDLIKB;

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public AHBNJGDEGOO HBMMMILEKCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x7358610", Offset = "0x7356C10", VA = "0x187358610", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public JGOJAJEODNM MJHKIHENJIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x7358660", Offset = "0x7356C60", VA = "0x187358660", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public ODFMHACHCFM DIHHKCLABAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x7358880", Offset = "0x7356E80", VA = "0x187358880", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public ODFMHACHCFM NKCLBCHHOOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x73588D0", Offset = "0x7356ED0", VA = "0x1873588D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public Transform CDCDMNLCAEH
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x7358920", Offset = "0x7356F20", VA = "0x187358920", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public PKOOKMMPLDP MFJBHKOKOAD
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x952DE0", Offset = "0x9513E0", VA = "0x180952DE0", Slot = "12")]
			get
			{
				return default(PKOOKMMPLDP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x73577B0", Offset = "0x7355DB0", VA = "0x1873577B0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x7358470", Offset = "0x7356A70", VA = "0x187358470")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x7358190", Offset = "0x7356790", VA = "0x187358190", Slot = "8")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x7358470", Offset = "0x7356A70", VA = "0x187358470", Slot = "9")]
		public void TeardownAvatarDisplaySystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x7357820", Offset = "0x7355E20", VA = "0x187357820", Slot = "10")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x7358520", Offset = "0x7356B20", VA = "0x187358520")]
		public void UpdatePostIKAnimControllers(float HIBCBLOKLEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x73583E0", Offset = "0x73569E0", VA = "0x1873583E0")]
		private void KDBGCODNDJN(GameObject GMFKPONAANG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x7357DE0", Offset = "0x73563E0", VA = "0x187357DE0")]
		private AHBNJGDEGOO HCJDDKGGCMI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x73581F0", Offset = "0x73567F0", VA = "0x1873581F0")]
		private JGOJAJEODNM JAPDDEELOII()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x7357B50", Offset = "0x7356150", VA = "0x187357B50")]
		private ODFMHACHCFM FFKBENDIDNF(ALIFPIFLCBK PHOLKKAAHFB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x7358600", Offset = "0x7356C00", VA = "0x187358600")]
		public AvatarModernBodyDisplayBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class MIGKACJGENE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	private MaterialPropertyBlock POJMKDMPEIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	public Color? DBFOGHLDJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	public Color? LKEIBHMGPLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	public Color? ECJHEDNAHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	public Color? KKEFJABJJAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	public Color NGGONCEKJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	public Color GKNLPPDHKEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	public Color JHGGCJMNIIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	public Texture2D PEMJGFCGPDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	public Texture2D OJMNJIKGIAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private Dictionary<IMJMIIIPNLF, int> EDEDDIPBAKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private BJGDFBKEINK[] OLGAPGAFCHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private DDOKGHHJODE[] MLMMHJBIJCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	public Vector4[] HOJBCIMGAAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	public Vector4[] BDBEABPMDEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	public Vector4[] KJIEKGGINDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	public Vector4[] JFGADDKDPFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	public Vector4[] HFBGOEODNAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	public Vector4[] JAEKGDEJLIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	private List<Texture2D> OPOKJAJLMNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	private Vector4[] BNGCKLBFOHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private List<Texture2D> JLAFFJPDHMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	private float[] NDBEGEBBMCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	private Vector4[] BGPBFAMDCNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private float[] GKIAFCDHIHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public float[] EBGAFMNGHCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private List<Texture2D> FEMNFDNOCAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private float[] OBHLACGDJEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private List<Texture2D> MJPMAEAHEFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private Vector4[] IOJLMDDLGIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private float[] MNPJFHPKEJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private Vector4[] KEILFGELNAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public float[] NBOOGPMEMPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	public Texture2DArray KPEGGKDEHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	public Texture2DArray GFPLLCKOODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public Texture2DArray EGAPGMHFKMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public Texture2DArray NAPIIOFHDCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private bool DBKFKABAANI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private int INGGKPCIDHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private Vector2? JBBELKDHKLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private TextureFormat NGMJABNEGJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private Vector2? CADHEHGAHML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private TextureFormat HAIDPOCPDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private Vector2? CKIKGHGFLIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private TextureFormat NDKEFKCMEDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	private Vector2? ELNCKGGCOLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private TextureFormat NCBKONCKIGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private bool LIABCKHNDHI;

	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private static int JBBPANEJIAG;

	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private static int HJAJBKIFOCD;

	[Cpp2IlInjected.Token(Token = "0x4000249")]
	private static int BBCJEOJMLAJ;

	[Cpp2IlInjected.Token(Token = "0x400024A")]
	private static int MJGPALFPDEM;

	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private static int CGCHFBIFEOG;

	[Cpp2IlInjected.Token(Token = "0x400024C")]
	private static int OAAIHKJABCD;

	[Cpp2IlInjected.Token(Token = "0x400024D")]
	private static int NMLGBBJNHCH;

	[Cpp2IlInjected.Token(Token = "0x400024E")]
	private static int MBFFNHDMPCD;

	[Cpp2IlInjected.Token(Token = "0x400024F")]
	private static int GEAGJCFCCAK;

	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private static int HNDKJNBCNPP;

	[Cpp2IlInjected.Token(Token = "0x4000251")]
	private static int OPEGEMNONGG;

	[Cpp2IlInjected.Token(Token = "0x4000252")]
	private static int JLAMHKENNND;

	[Cpp2IlInjected.Token(Token = "0x4000253")]
	private static int GAHBGIPKNBC;

	[Cpp2IlInjected.Token(Token = "0x4000254")]
	private static int LOEMIFOJCBL;

	[Cpp2IlInjected.Token(Token = "0x4000255")]
	private static int PGCKGHEENJP;

	[Cpp2IlInjected.Token(Token = "0x4000256")]
	private static int HAPMHMNCHHB;

	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private static int EGNOEHCMCKC;

	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private static int HLMHFCCNEFI;

	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private static int LMLBKGIEJBB;

	[Cpp2IlInjected.Token(Token = "0x400025A")]
	private static int KLPBMFFPJAO;

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x73607E0", Offset = "0x735EDE0", VA = "0x1873607E0")]
	private MIGKACJGENE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x7360CD0", Offset = "0x735F2D0", VA = "0x187360CD0")]
	public MIGKACJGENE(Color IEBFENEMEIK, Color LOAJNIGDFIE, Color EAPIHGGHMMD, Color? AINKANFBEBP, Color? IHKBKDHEBPP, Color? LMMBMHGICJK, Texture2D NEKCGAHBFJF, Texture2D DJCPDCPKMGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x73602D0", Offset = "0x735E8D0", VA = "0x1873602D0")]
	internal int OMBEAPDGBME(Material GAOIEHMCMOL, BJGDFBKEINK PIEGLLCHINN, DDOKGHHJODE IPEPMKFNFHH, OBJHNMCDGDL DBDEIKJCEBF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x73603C0", Offset = "0x735E9C0", VA = "0x1873603C0")]
	private int OMBEAPDGBME(IMJMIIIPNLF LKMGECEEGEE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x735EE50", Offset = "0x735D450", VA = "0x18735EE50")]
	internal int DBKADKAPBAC(Material GAOIEHMCMOL, Color KDBCFKGNGJP, Color OJKPDPFPHGP, Color EKKHNINCDDG, Color AJJDBGBBOLB, Color CEJFGPJEHDN, Texture2D PEJBFDIAPAA, Vector4 PHIIPKGLPLE, Texture2D DOJBPMEJOBE, Vector4 IFCCKHDPJEB, float FJNCKBNFJAI, float IGLGBOOJJAK, Texture2D IDDFMOLLGGE, Vector4 BAIJHFDMEEF, float HPGDACJJKHN, Texture2D BOEADKHPNCM, Color DDPMLLMDLNO, Vector4 HBDHPJCLBEB, BJGDFBKEINK PIEGLLCHINN, DDOKGHHJODE IPEPMKFNFHH, OBJHNMCDGDL DBDEIKJCEBF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x735FDB0", Offset = "0x735E3B0", VA = "0x18735FDB0")]
	private void IKMNPHEGCBH(List<Texture2D> OPOKJAJLMNK, [Out] Texture2DArray DHCFOIPLAJB, [Out] Texture2DArray AKKHPCLFJAI, [Out] Texture2DArray CPKNNGHENAK, [Out] Texture2DArray GNGDKHFMOBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x7360020", Offset = "0x735E620", VA = "0x187360020")]
	public void MCPMPJFJMIF(Shader KLLALGPLCJG, Renderer EHMEICJAGNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x735E150", Offset = "0x735C750", VA = "0x18735E150")]
	private void ALIOBPFNCIG(Shader KLLALGPLCJG, Renderer EHMEICJAGNO, int EJODJKFNBCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x735FBB0", Offset = "0x735E1B0", VA = "0x18735FBB0")]
	private Color EHOAOMHALFA(Color OIICHJCCJLN, BJGDFBKEINK PIKKFHOHKHL)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x735FA20", Offset = "0x735E020", VA = "0x18735FA20")]
	private Color DHOIBNHFPKO(Color GPOLAKINJJB, BJGDFBKEINK PIKKFHOHKHL)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x7360170", Offset = "0x735E770", VA = "0x187360170")]
	private bool OFFJCKDDIFP(Texture2D GEMLMEAOFCE, DDOKGHHJODE CJLDBFGOACG, [Out] Texture2D HHDJOOBGCLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x735FF70", Offset = "0x735E570", VA = "0x18735FF70")]
	private void LFLFHOBPLME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x735FB70", Offset = "0x735E170", VA = "0x18735FB70", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public abstract class CEHPNHHBNNM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	public readonly OBJHNMCDGDL CHEMOMFDFNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	protected bool BKPFFCNLCBE;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public bool FBIBJGKLKIG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xB459D0", Offset = "0xB43FD0", VA = "0x180B459D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0xB45120", Offset = "0xB43720", VA = "0x180B45120")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool CNPLEMFMLHF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xB45090", Offset = "0xB43690", VA = "0x180B45090")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0xB45940", Offset = "0xB43F40", VA = "0x180B45940")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public virtual KBAIGJMAONF.FALICHFPADL JIJOKOIODIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(KBAIGJMAONF.FALICHFPADL);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xAF2910", Offset = "0xAF0F10", VA = "0x180AF2910", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public bool PHFBELMLHIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x1112A70", Offset = "0x1111070", VA = "0x181112A70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public bool LHOBEADACPN
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x73590C0", Offset = "0x73576C0", VA = "0x1873590C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool PGJNPMBMKFF
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x73590B0", Offset = "0x73576B0", VA = "0x1873590B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public bool NNIMFLNNHBI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x73590D0", Offset = "0x73576D0", VA = "0x1873590D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x73590F0", Offset = "0x73576F0", VA = "0x1873590F0")]
	protected CEHPNHHBNNM(OBJHNMCDGDL MKJCGACHDHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract HJOKANJAKGB EJFPOGPKNJP(List<BELJNJGLPJA> NJNODBJNKGK, List<BELJNJGLPJA> CFOHIHHANCN);

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract KIFHJDJPHPE HHCBKNFBCHD(uint GNAJNFCKONF, AvatarSkinnedMeshBoneOrderRemapsData MINBMMFMOIL);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class PMLAJDCJGNF : DPJCMIHGKMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	private AvatarSkinAssetItem BBCPEMJPNHM;

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x7366EB0", Offset = "0x73654B0", VA = "0x187366EB0")]
	public PMLAJDCJGNF(AvatarSkinAssetItem NKOJECCKCBD, AvatarSkinAssetItem.MBKPHICBOOJ GHHKFIEAPCG, OBJHNMCDGDL DBDEIKJCEBF, [Optional] EJPJNNNFMKK? IFJJNEIHMGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x7366C40", Offset = "0x7365240", VA = "0x187366C40", Slot = "6")]
	public override HJOKANJAKGB EJFPOGPKNJP(List<BELJNJGLPJA> NJNODBJNKGK, List<BELJNJGLPJA> CFOHIHHANCN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class BAIMMPILMAD
{
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	private static readonly int[] FDIAGOKLIOI;

	[Cpp2IlInjected.Token(Token = "0x4000262")]
	private static readonly int[] PMBIKBOLCGJ;

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public static int[] JBLEEOFMNMH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x7358950", Offset = "0x7356F50", VA = "0x187358950")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x73589A0", Offset = "0x7356FA0", VA = "0x1873589A0")]
	public static int[] HBMIGFKHDLI(bool EABGLLFKNPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x7358A30", Offset = "0x7357030", VA = "0x187358A30")]
	public static int NBCNDKGMCEH(OINJBHOKJEJ FGGAKOCECCL, bool EABGLLFKNPC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x7358940", Offset = "0x7356F40", VA = "0x187358940")]
	private static int CJCAKKHJJBJ(OINJBHOKJEJ FGGAKOCECCL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x7358AC0", Offset = "0x73570C0", VA = "0x187358AC0")]
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
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		private FBLKJCIOKGP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		private FBLKJCIOKGP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x9527A0", Offset = "0x950DA0", VA = "0x1809527A0")]
		[DebuggerHidden]
		public LFABBMJKEGE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x106A400", Offset = "0x1068A00", VA = "0x18106A400", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x735CC50", Offset = "0x735B250", VA = "0x18735CC50", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60")]
	public static void AFGLAHBJJPN(string KGHCKLKGJKM, int GNAJNFCKONF, long ELBKCAMKOII, long GJDKAECMJLH, long MNKMGFLAHEK, long PIBDMPFGMDF, long MCFPHOIIJBC, long KAMECLDLOEA, long JLFPLKEMDAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x735CAF0", Offset = "0x735B0F0", VA = "0x18735CAF0")]
	public static HPLGDNGCOKN NIPFIIPJNEF(JobHandle KICDBOCICCM, bool LKAJPOPBDDB, bool KNAMMMJKBJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x735CBE0", Offset = "0x735B1E0", VA = "0x18735CBE0")]
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
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		General,
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		ColoredHair
	}

	[Cpp2IlInjected.Token(Token = "0x4000266")]
	public static readonly int FIKMOLOIHHO;

	[Cpp2IlInjected.Token(Token = "0x4000267")]
	public static readonly int COAOBHCKNMD;

	[Cpp2IlInjected.Token(Token = "0x4000268")]
	public static readonly int AJADFOAGDFH;

	[Cpp2IlInjected.Token(Token = "0x4000269")]
	public static readonly int POCMBLGAEFE;

	[Cpp2IlInjected.Token(Token = "0x400026A")]
	public static readonly int HOKNBKGKLJB;

	[Cpp2IlInjected.Token(Token = "0x400026B")]
	public static readonly int KDGNJNEBPOC;

	[Cpp2IlInjected.Token(Token = "0x400026C")]
	public static readonly int GDELFCKFKMB;

	[Cpp2IlInjected.Token(Token = "0x400026D")]
	public static readonly int PJHNPDNNFPC;

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x7359420", Offset = "0x7357A20", VA = "0x187359420")]
	public static bool KDIILKEKEJN(Material HJCEHLILOIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x7359360", Offset = "0x7357960", VA = "0x187359360")]
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
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public EBHOPDBMNPK<GameObject> skinAvatarItemPrefabHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public DPJCMIHGKMA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public Action<string> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public HBNFPPJNMMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x735AAA0", Offset = "0x73590A0", VA = "0x18735AAA0")]
		internal void AHCJACCJBEC(GameObject result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x735AE80", Offset = "0x7359480", VA = "0x18735AE80")]
		internal void LOGAJHNFGKB(string error)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	protected AvatarSkinAssetItem EHEPODAOOLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	protected Material[] IOHJEFICLMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	private readonly AvatarSkinAssetItem.MBKPHICBOOJ GLNNBBEPJGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	private readonly AssetReference MFCJFMIOAIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	private readonly EJPJNNNFMKK? MAMGJOHCPPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	private SkinnedMeshRenderer[] AGCBOMOEKBK;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public override KBAIGJMAONF.FALICHFPADL JIJOKOIODIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x9529E0", Offset = "0x950FE0", VA = "0x1809529E0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(KBAIGJMAONF.FALICHFPADL);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x956CB0", Offset = "0x9552B0", VA = "0x180956CB0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x7359C60", Offset = "0x7358260", VA = "0x187359C60")]
	public DPJCMIHGKMA(AvatarSkinAssetItem.MBKPHICBOOJ GHHKFIEAPCG, AssetReference CEFBPHKNGKO, Material IFINEEFKJJB, OBJHNMCDGDL DBDEIKJCEBF, KBAIGJMAONF.FALICHFPADL FOGBHKGEFLC = (KBAIGJMAONF.FALICHFPADL)0L, [Optional] EJPJNNNFMKK? IFJJNEIHMGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x7359D90", Offset = "0x7358390", VA = "0x187359D90")]
	public DPJCMIHGKMA(AvatarSkinAssetItem.MBKPHICBOOJ GHHKFIEAPCG, AssetReference CEFBPHKNGKO, Material IFINEEFKJJB, KBAIGJMAONF.FALICHFPADL FOGBHKGEFLC = (KBAIGJMAONF.FALICHFPADL)0L, [Optional] EJPJNNNFMKK? IFJJNEIHMGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x7359700", Offset = "0x7357D00", VA = "0x187359700", Slot = "6")]
	public override HJOKANJAKGB EJFPOGPKNJP(List<BELJNJGLPJA> NJNODBJNKGK, List<BELJNJGLPJA> CFOHIHHANCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x73598D0", Offset = "0x7357ED0", VA = "0x1873598D0", Slot = "7")]
	public override KIFHJDJPHPE HHCBKNFBCHD(uint GNAJNFCKONF, AvatarSkinnedMeshBoneOrderRemapsData MINBMMFMOIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x7359BF0", Offset = "0x73581F0", VA = "0x187359BF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7359BA0", Offset = "0x73581A0", VA = "0x187359BA0")]
	protected void NCGEAFKKDHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class ODNKPFEIMKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	private List<int> PEGKHMDIJEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	private List<BAMEFJKOEPC> GNAKNOBFNDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	private HashSet<Transform> OOODODAECPI;

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x73647A0", Offset = "0x7362DA0", VA = "0x1873647A0")]
	public static ODNKPFEIMKD PDELBJIKOKA(Transform CHBEBLKFDBC, Dictionary<Transform, OutfitType?> OFMFEKNJICE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x7363FC0", Offset = "0x73625C0", VA = "0x187363FC0")]
	private void BNCMGNIEPMI(Transform CHBEBLKFDBC, OBJHNMCDGDL DBDEIKJCEBF, Dictionary<Transform, OutfitType?> OFMFEKNJICE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x7364670", Offset = "0x7362C70", VA = "0x187364670")]
	private void GDNJHFCNBCN(Transform JCFEMBBMLPO, OBJHNMCDGDL DBDEIKJCEBF, bool CHKLMCBNHGI, OutfitType? CNBEFNFJEEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x7364280", Offset = "0x7362880", VA = "0x187364280")]
	public LJJJGEKILBB CFIOBLMMGOG(HashSet<string> PEKMMPLCJOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x7364930", Offset = "0x7362F30", VA = "0x187364930")]
	public ODNKPFEIMKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class LJJJGEKILBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	private List<BAMEFJKOEPC> GNAKNOBFNDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	private List<Matrix4x4> PADOINEHBLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	private Transform[] OGJHKALBBCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	private Matrix4x4[] NFKBIMNKJDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	private Dictionary<OADOAICIFLN, int> JFLKCCJFEON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	private List<IHLJLBIIEIJ> IJEOMNDNCDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	private bool EMNIGDBNJHL;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public int AGHLCEGEAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x735D8B0", Offset = "0x735BEB0", VA = "0x18735D8B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public Transform[] AKNFNJGGNLO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x735CCA0", Offset = "0x735B2A0", VA = "0x18735CCA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public Matrix4x4[] CMPKBJJLILP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x735D600", Offset = "0x735BC00", VA = "0x18735D600")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x735D400", Offset = "0x735BA00", VA = "0x18735D400")]
	public void GDNJHFCNBCN(Transform JCFEMBBMLPO, OBJHNMCDGDL DBDEIKJCEBF, OutfitType? CNBEFNFJEEJ, bool KIKFLHBEBPF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x735D0C0", Offset = "0x735B6C0", VA = "0x18735D0C0")]
	private void GDNJHFCNBCN(Transform JCFEMBBMLPO, OBJHNMCDGDL DBDEIKJCEBF, OutfitType? CNBEFNFJEEJ, bool KIKFLHBEBPF, Matrix4x4 BMEGOLAAOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x735CE10", Offset = "0x735B410", VA = "0x18735CE10")]
	public int EFMFAHFBCHL(OADOAICIFLN LKMGECEEGEE, bool PJGFKPDOMOM, [Optional] OutfitType? CNBEFNFJEEJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x735CFC0", Offset = "0x735B5C0", VA = "0x18735CFC0")]
	public int FNPOCFABELO(OBJHNMCDGDL DBDEIKJCEBF, [Optional] OutfitType? CNBEFNFJEEJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x735D7C0", Offset = "0x735BDC0", VA = "0x18735D7C0")]
	public void OGFOGPHFLLF(OADOAICIFLN LKMGECEEGEE, Matrix4x4 FFCKKKAIOMF, bool PJGFKPDOMOM = false, [Optional] OutfitType? CNBEFNFJEEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x735D670", Offset = "0x735BC70", VA = "0x18735D670")]
	public Matrix4x4 JCCBGHCDFIN(OADOAICIFLN LKMGECEEGEE, bool PJGFKPDOMOM, [Optional] OutfitType? CNBEFNFJEEJ)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x1149B40", Offset = "0x1148140", VA = "0x181149B40")]
	public void IPLHNBAJKNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x735D8F0", Offset = "0x735BEF0", VA = "0x18735D8F0")]
	public LJJJGEKILBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct OADOAICIFLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	public readonly string MPOOIKLEGIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	public readonly OBJHNMCDGDL IDLHGNGCIKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	public readonly OutfitType? GHHMKNNILOF;

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x7363D80", Offset = "0x7362380", VA = "0x187363D80")]
	public OADOAICIFLN(string MHIJJLMKFIP, OBJHNMCDGDL DBDEIKJCEBF, [Optional] OutfitType? CNBEFNFJEEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x7363CD0", Offset = "0x73622D0", VA = "0x187363CD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7363C10", Offset = "0x7362210", VA = "0x187363C10")]
	public bool ONNLACEOLHH(OADOAICIFLN OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x7363AF0", Offset = "0x73620F0", VA = "0x187363AF0", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x7363BA0", Offset = "0x73621A0", VA = "0x187363BA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct IHLJLBIIEIJ : IEquatable<IHLJLBIIEIJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	public readonly OBJHNMCDGDL IDLHGNGCIKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public readonly OutfitType? OMLPHCLBOPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public readonly int CNHJEMEDEKG;

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x735B2A0", Offset = "0x73598A0", VA = "0x18735B2A0")]
	public IHLJLBIIEIJ(OBJHNMCDGDL DBDEIKJCEBF, int HKKLOAOPFED, [Optional] OutfitType? LGHIBMHGALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x735B1D0", Offset = "0x73597D0", VA = "0x18735B1D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x6651690", Offset = "0x664FC90", VA = "0x186651690")]
	public bool IMMNOKNDIIE(OBJHNMCDGDL DBDEIKJCEBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x735B100", Offset = "0x7359700", VA = "0x18735B100")]
	public bool GBFEDJGHMNP(OutfitType? LGHIBMHGALF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x735AFC0", Offset = "0x73595C0", VA = "0x18735AFC0", Slot = "4")]
	public bool Equals(IHLJLBIIEIJ OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x735B010", Offset = "0x7359610", VA = "0x18735B010", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x735B180", Offset = "0x7359780", VA = "0x18735B180", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct BAMEFJKOEPC : IEquatable<BAMEFJKOEPC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public readonly Transform LDHGIKPHDPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public readonly bool HPOLAEKJMMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public readonly OBJHNMCDGDL CCHPAJJHHMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public readonly OutfitType? GHHMKNNILOF;

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x7359060", Offset = "0x7357660", VA = "0x187359060")]
	public BAMEFJKOEPC(Transform JCFEMBBMLPO, bool CHKLMCBNHGI, OBJHNMCDGDL GOMFDEPAONA, [Optional] OutfitType? GMBCGJHDMJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x7358E40", Offset = "0x7357440", VA = "0x187358E40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x7358CC0", Offset = "0x73572C0", VA = "0x187358CC0", Slot = "4")]
	public bool Equals(BAMEFJKOEPC OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x7358BE0", Offset = "0x73571E0", VA = "0x187358BE0", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x7358DC0", Offset = "0x73573C0", VA = "0x187358DC0", Slot = "2")]
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
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		public const float DEFAULT_Y_POSITION_OFFSET = 0.04f;

		[Cpp2IlInjected.Token(Token = "0x4000293")]
		public const float MAX_HEMISPHERE_POSITION_OFFSET = 0.05f;

		[Cpp2IlInjected.Token(Token = "0x4000294")]
		public const float MAX_HEMISPHERE_ROTATION_OFFSET = 45f;

		[Cpp2IlInjected.Token(Token = "0x4000295")]
		public const float MAX_HEMISPHERE_SCALE = 2f;

		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public const float MIN_HEMISPHERE_SCALE = 0.75f;

		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public const float MAX_HEMISPHERE_RADIUS = 0.25f;

		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public const float MIN_HEMISPHERE_RADIUS = 0.125f;

		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public static GameObject ContainerGO;

		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public static GameObject CurrentHairHemisphereGO;

		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public static Transform CurrentHairHemisphereMeshTransform;

		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public static FitMeshHemisphereUpdater CurrentHairHemisphereUpdater;

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x735A4B0", Offset = "0x7358AB0", VA = "0x18735A4B0")]
		public static void DespawnHairHemisphere()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60")]
		public void UpdateValues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x951A50", Offset = "0x950050", VA = "0x180951A50")]
		public FitMeshHemisphereUpdater()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface HPHBLHCBCNN
{
	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BMFCBKCPPJP(Mesh LCGHOEMEOEK, Matrix4x4 OGMKAOPLLDA, byte[] FFEHGHDGBPA, bool CBFKEKGDGGD = false, KBAIGJMAONF.FALICHFPADL IPOKALCDIKI = (KBAIGJMAONF.FALICHFPADL)0L, int ELAEEHODNCP = -1, bool MBLBPIKGHBL = false);

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JKGNMOLLMOL(Allocator LEILKJFLDFN, LDBIEKJHPFI KKPPEJOKKDF, byte DDBNJCIKGBE, [Optional] IList<int> MPNCJGPMPPN, [Optional] IList<int> KKBDINDOJJG);
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public readonly struct FMPJGLDDHNE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public readonly GameObject MOCILOCGFBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	private readonly AvatarItemMaterial PBNNLPIPCPF;

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x9B2EC0", Offset = "0x9B14C0", VA = "0x1809B2EC0")]
	public FMPJGLDDHNE(GameObject MOCILOCGFBE, AvatarItemMaterial PBNNLPIPCPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x735A420", Offset = "0x7358A20", VA = "0x18735A420")]
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
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public AsyncTaskMethodBuilder<(GameObject, AvatarItemMaterial)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public Task<GameObject> goTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public Task<AvatarItemMaterial> materialTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		private GameObject <go>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		private TaskAwaiter<GameObject> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		private TaskAwaiter<AvatarItemMaterial> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x7359EB0", Offset = "0x73584B0", VA = "0x187359EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x735A3B0", Offset = "0x73589B0", VA = "0x18735A3B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	private EBHOPDBMNPK<GameObject> HOFKJJADEFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	private EBHOPDBMNPK<AvatarItemMaterial> BHKJEPJJCIP;

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x735E0C0", Offset = "0x735C6C0", VA = "0x18735E0C0")]
	private LPFPHDKGGJG(Task<(GameObject, AvatarItemMaterial)> CBPINBDBDCO, EBHOPDBMNPK<GameObject> MEOBHAMACOG, EBHOPDBMNPK<AvatarItemMaterial> MNCBGJFMKJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x735DCB0", Offset = "0x735C2B0", VA = "0x18735DCB0")]
	public static LPFPHDKGGJG OILMBKHFGKP(AssetReference LMDMGMLONEC, [Optional] AssetReference ACDEDFBKHJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x735DC10", Offset = "0x735C210", VA = "0x18735DC10", Slot = "11")]
	protected override FMPJGLDDHNE DHKALHEMICK(Task<(GameObject, AvatarItemMaterial)> OJHAAGOGBNE)
	{
		return default(FMPJGLDDHNE);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x735DB90", Offset = "0x735C190", VA = "0x18735DB90", Slot = "12")]
	protected override void DHGLNKNCHGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x735DA60", Offset = "0x735C060", VA = "0x18735DA60")]
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
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		private EBHOPDBMNPK<MaterialMapAsset> ILIIBOPHLDK;

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x735A9C0", Offset = "0x7358FC0", VA = "0x18735A9C0")]
		public GHKKKGCCDOD(EBHOPDBMNPK<MaterialMapAsset> ILIIBOPHLDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x735A580", Offset = "0x7358B80", VA = "0x18735A580", Slot = "11")]
		protected override Material[] DHKALHEMICK(Task<MaterialMapAsset> CBPINBDBDCO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x735A520", Offset = "0x7358B20", VA = "0x18735A520", Slot = "12")]
		protected override void DHGLNKNCHGP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class OBLKMDKGADC : IDPINFFBPGI<Task<Material[]>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private List<EBHOPDBMNPK<Material>> FEJHOLHIAPJ;

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x7363F50", Offset = "0x7362550", VA = "0x187363F50")]
		public OBLKMDKGADC(Task<Material[]> CBPINBDBDCO, List<EBHOPDBMNPK<Material>> FEJHOLHIAPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x7363F00", Offset = "0x7362500", VA = "0x187363F00", Slot = "11")]
		protected override Material[] DHKALHEMICK(Task<Material[]> OJHAAGOGBNE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x7363DC0", Offset = "0x73623C0", VA = "0x187363DC0", Slot = "12")]
		protected override void DHGLNKNCHGP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	private static readonly IBCMILIKEJG DDKJAEALMGF;

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x7355B80", Offset = "0x7354180", VA = "0x187355B80")]
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
			[Cpp2IlInjected.Token(Token = "0x4000339")]
			None,
			[Cpp2IlInjected.Token(Token = "0x400033A")]
			TeamItem,
			[Cpp2IlInjected.Token(Token = "0x400033B")]
			SkinColor,
			[Cpp2IlInjected.Token(Token = "0x400033C")]
			HairColor,
			[Cpp2IlInjected.Token(Token = "0x400033D")]
			BeardColor,
			[Cpp2IlInjected.Token(Token = "0x400033E")]
			UGCShirtColor
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public enum FKJFCNDMIGG
		{
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000341")]
			HairTexture,
			[Cpp2IlInjected.Token(Token = "0x4000342")]
			BeardTexture,
			[Cpp2IlInjected.Token(Token = "0x4000343")]
			UGCShirtTexture
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public enum BKKKDFDJABB : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000345")]
			All,
			[Cpp2IlInjected.Token(Token = "0x4000346")]
			LOD0Only,
			[Cpp2IlInjected.Token(Token = "0x4000347")]
			EditorToolAll
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		public struct LNEMEGHNMGK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000348")]
			public readonly Material IAODGAIPHAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000349")]
			public readonly ELDJGACMLPI ACJJLKFOJDE;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400034A")]
			public readonly FKJFCNDMIGG AOAFMIIPOPC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400034B")]
			public readonly OBJHNMCDGDL IDLHGNGCIKJ;

			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0x735B6F0", Offset = "0x7359CF0", VA = "0x18735B6F0")]
			public LNEMEGHNMGK(Material HJCEHLILOIG, ELDJGACMLPI PIEGLLCHINN, FKJFCNDMIGG IPEPMKFNFHH, OBJHNMCDGDL DBDEIKJCEBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0x737CE80", Offset = "0x737B480", VA = "0x18737CE80", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x735B2B0", Offset = "0x73598B0", VA = "0x18735B2B0")]
			public bool ONNLACEOLHH(LNEMEGHNMGK OKCHLIEAIJP)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0x737CCF0", Offset = "0x737B2F0", VA = "0x18737CCF0", Slot = "0")]
			public override bool Equals(object GMFKPONAANG)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x737CDE0", Offset = "0x737B3E0", VA = "0x18737CDE0", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		protected struct MJOIPLEFGEK : IComparable<MJOIPLEFGEK>, IEquatable<MJOIPLEFGEK>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400034C")]
			public int KMLDDFPOOAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400034D")]
			public PlayerAvatarDisplayBase BBCHEHFFEBG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400034E")]
			public IList<DKLBEPIMGOL> OGOKKEIDLED;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400034F")]
			public AvatarItemBodyType CIIOLIKMEAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000350")]
			public IIFAJIGINPD IFCKEGGHKCC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000351")]
			public bool FIHAFEEGAGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000352")]
			public int[] MOFBLKNOEOE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000353")]
			public float MOEAGHOMEOM;

			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0x737D210", Offset = "0x737B810", VA = "0x18737D210", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(RVA = "0x737D0B0", Offset = "0x737B6B0", VA = "0x18737D0B0", Slot = "4")]
			public int CompareTo(MJOIPLEFGEK OKCHLIEAIJP)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002E1")]
			[Cpp2IlInjected.Address(RVA = "0x737D0D0", Offset = "0x737B6D0", VA = "0x18737D0D0", Slot = "5")]
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
				[Cpp2IlInjected.Token(Token = "0x4000357")]
				public readonly Mesh KFDGIAJINED;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000358")]
				public readonly Material[] KNEEJKFKEII;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000359")]
				public readonly Transform[] GMLOJIKNGNI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400035A")]
				public readonly Matrix4x4[] NPKOJEOEIDO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400035B")]
				public readonly Transform GIEMGBAOEND;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400035C")]
				public readonly bool FNHHMLAJPBC;

				[Cpp2IlInjected.Token(Token = "0x60002E9")]
				[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
				protected GIEBLOPMBKG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002EA")]
				[Cpp2IlInjected.Address(RVA = "0x73773A0", Offset = "0x73759A0", VA = "0x1873773A0")]
				public GIEBLOPMBKG(Mesh LCGHOEMEOEK, Material[] JHJJAFEAONB, bool HMLEKJDHBAO, Transform[] BLNGGKCOHMF, Transform FHNGLJKKLGK, Matrix4x4[] HFMNNJGNFEK)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002EB")]
				[Cpp2IlInjected.Address(RVA = "0x73772E0", Offset = "0x73758E0", VA = "0x1873772E0")]
				private GIEBLOPMBKG(SkinnedMeshRenderer BNBIMMBDEGH, Material[] GDFHBJLKHMG)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002EC")]
				[Cpp2IlInjected.Address(RVA = "0x7377850", Offset = "0x7375E50", VA = "0x187377850")]
				private GIEBLOPMBKG(MeshRenderer AADKLBCKCDD, Transform FHNGLJKKLGK, Material[] GDFHBJLKHMG)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002ED")]
				[Cpp2IlInjected.Address(RVA = "0x7376FB0", Offset = "0x73755B0", VA = "0x187376FB0")]
				public static GIEBLOPMBKG DBGIJHFGGDN(Renderer EHMEICJAGNO, Material[] GDFHBJLKHMG)
				{
					return null;
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000354")]
			public readonly OBJHNMCDGDL IDLHGNGCIKJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000355")]
			public readonly Transform BHCNCFIOPCN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000356")]
			public readonly bool IGFKONMHBPM;

			[Cpp2IlInjected.Token(Token = "0x1700008A")]
			public virtual bool FBIBJGKLKIG
			{
				[Cpp2IlInjected.Token(Token = "0x60002E2")]
				[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008B")]
			public virtual bool CNPLEMFMLHF
			{
				[Cpp2IlInjected.Token(Token = "0x60002E3")]
				[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008C")]
			public virtual KBAIGJMAONF.FALICHFPADL JIJOKOIODIH
			{
				[Cpp2IlInjected.Token(Token = "0x60002E4")]
				[Cpp2IlInjected.Address(RVA = "0x951A70", Offset = "0x950070", VA = "0x180951A70", Slot = "6")]
				get
				{
					return default(KBAIGJMAONF.FALICHFPADL);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008D")]
			public bool CEPINDKOFMB
			{
				[Cpp2IlInjected.Token(Token = "0x60002E5")]
				[Cpp2IlInjected.Address(RVA = "0x737D7E0", Offset = "0x737BDE0", VA = "0x18737D7E0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0x737D7F0", Offset = "0x737BDF0", VA = "0x18737D7F0")]
			protected OGMDKFDFBIB(OBJHNMCDGDL DBDEIKJCEBF, Transform AALAFJLGDAL, bool JPPIHJIOHKC = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E7")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract HJOKANJAKGB EJFPOGPKNJP(List<BELJNJGLPJA> NJNODBJNKGK, List<BELJNJGLPJA> CFOHIHHANCN);

			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract GIEBLOPMBKG HHCBKNFBCHD(int GNAJNFCKONF, PlayerHandBones OKCCOEOJCAI);
		}

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		protected class EGNICOOMJBK : OGMDKFDFBIB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400035D")]
			protected readonly BodyPartLODs AGCBOMOEKBK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400035E")]
			protected readonly Material[] IOHJEFICLMF;

			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x7376CA0", Offset = "0x73752A0", VA = "0x187376CA0")]
			public EGNICOOMJBK(OBJHNMCDGDL DBDEIKJCEBF, BodyPartLODs DJJJKBGJECN, Material IFINEEFKJJB, [Optional] Transform AALAFJLGDAL, bool JPPIHJIOHKC = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x73769E0", Offset = "0x7374FE0", VA = "0x1873769E0", Slot = "7")]
			public override HJOKANJAKGB EJFPOGPKNJP(List<BELJNJGLPJA> NJNODBJNKGK, List<BELJNJGLPJA> CFOHIHHANCN)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x7376A70", Offset = "0x7375070", VA = "0x187376A70", Slot = "8")]
			public override GIEBLOPMBKG HHCBKNFBCHD(int GNAJNFCKONF, PlayerHandBones OKCCOEOJCAI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x7376C30", Offset = "0x7375230", VA = "0x187376C30", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005D")]
		protected class KONAGGEKGFJ : OGMDKFDFBIB
		{
			[Cpp2IlInjected.Token(Token = "0x1700008E")]
			public override bool FBIBJGKLKIG
			{
				[Cpp2IlInjected.Token(Token = "0x60002F2")]
				[Cpp2IlInjected.Address(RVA = "0x96C540", Offset = "0x96AB40", VA = "0x18096C540", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008F")]
			public override bool CNPLEMFMLHF
			{
				[Cpp2IlInjected.Token(Token = "0x60002F3")]
				[Cpp2IlInjected.Address(RVA = "0x737CBC0", Offset = "0x737B1C0", VA = "0x18737CBC0", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000090")]
			public LBKMHAIBEMP HCAGBBDPLIN
			{
				[Cpp2IlInjected.Token(Token = "0x60002F4")]
				[Cpp2IlInjected.Address(RVA = "0x9529E0", Offset = "0x950FE0", VA = "0x1809529E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60002F5")]
				[Cpp2IlInjected.Address(RVA = "0x9527E0", Offset = "0x950DE0", VA = "0x1809527E0")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x737CC80", Offset = "0x737B280", VA = "0x18737CC80")]
			public KONAGGEKGFJ(OBJHNMCDGDL DBDEIKJCEBF, Transform AALAFJLGDAL, LBKMHAIBEMP HBNIICBFICF, bool JPPIHJIOHKC = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x737CB30", Offset = "0x737B130", VA = "0x18737CB30", Slot = "7")]
			public override HJOKANJAKGB EJFPOGPKNJP(List<BELJNJGLPJA> NJNODBJNKGK, List<BELJNJGLPJA> CFOHIHHANCN)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x951A70", Offset = "0x950070", VA = "0x180951A70", Slot = "8")]
			public override GIEBLOPMBKG HHCBKNFBCHD(int GNAJNFCKONF, PlayerHandBones OKCCOEOJCAI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x737CC10", Offset = "0x737B210", VA = "0x18737CC10", Slot = "3")]
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
				[Cpp2IlInjected.Token(Token = "0x4000370")]
				PLAYER_PUPPET,
				[Cpp2IlInjected.Token(Token = "0x4000371")]
				PLAYER_DISPLAY_POSER,
				[Cpp2IlInjected.Token(Token = "0x4000372")]
				PLAYER_HAND,
				[Cpp2IlInjected.Token(Token = "0x4000373")]
				STNMONSTERCOSTUME_OPTION_HIDE_EXCEPT_UI,
				[Cpp2IlInjected.Token(Token = "0x4000374")]
				PLAYER_HAND_POINTING,
				[Cpp2IlInjected.Token(Token = "0x4000375")]
				STNMONSTERCOSTUME_OPTION_ALWAYS_HIDE,
				[Cpp2IlInjected.Token(Token = "0x4000376")]
				EDITOR
			}

			[Cpp2IlInjected.Token(Token = "0x4000360")]
			public static readonly int BIDKNBGNPMO;

			[Cpp2IlInjected.Token(Token = "0x4000361")]
			public static readonly int BNHBEOLDEBD;

			[Cpp2IlInjected.Token(Token = "0x4000362")]
			public static readonly int BPIBMDKJCHH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000363")]
			protected readonly ALIFPIFLCBK PHOLKKAAHFB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000364")]
			protected readonly GGAINOJCJPJ PBBHHFJDGGI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000365")]
			protected readonly Animator IEACKBDAGDE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000366")]
			protected readonly Transform FJGLBBJIGOO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000367")]
			protected readonly Vector3 JFOFOHGOEAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000368")]
			protected readonly Transform PMLHOOBBPAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000369")]
			protected readonly Vector3 JHABGBAOAJH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x400036A")]
			protected bool MLJDAKCNCHC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400036B")]
			protected ODFMHACHCFM LONFFBLGCLL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400036C")]
			protected bool KNFLLHIMAIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x400036D")]
			protected float ACODDJADCDO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400036E")]
			protected GJKLJJDNPDD<BKMINCPGJKF> NCKEEFGIMMN;

			[Cpp2IlInjected.Token(Token = "0x17000091")]
			public ODFMHACHCFM GIHFFLGNHCM
			{
				[Cpp2IlInjected.Token(Token = "0x60002FA")]
				[Cpp2IlInjected.Address(RVA = "0x956CC0", Offset = "0x9552C0", VA = "0x180956CC0")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60002FB")]
				[Cpp2IlInjected.Address(RVA = "0x956D40", Offset = "0x955340", VA = "0x180956D40")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000092")]
			public bool BNCGLLGIOGP
			{
				[Cpp2IlInjected.Token(Token = "0x60002FC")]
				[Cpp2IlInjected.Address(RVA = "0xAA1400", Offset = "0xA9FA00", VA = "0x180AA1400")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60002FD")]
				[Cpp2IlInjected.Address(RVA = "0x7377F30", Offset = "0x7376530", VA = "0x187377F30")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000093")]
			public bool ILDDEFJEBNP
			{
				[Cpp2IlInjected.Token(Token = "0x60002FE")]
				[Cpp2IlInjected.Address(RVA = "0x956C70", Offset = "0x955270", VA = "0x180956C70")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60002FF")]
				[Cpp2IlInjected.Address(RVA = "0x7378000", Offset = "0x7376600", VA = "0x187378000")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000094")]
			public float BAAJDGOAOJO
			{
				[Cpp2IlInjected.Token(Token = "0x6000300")]
				[Cpp2IlInjected.Address(RVA = "0xB45930", Offset = "0xB43F30", VA = "0x180B45930")]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000301")]
				[Cpp2IlInjected.Address(RVA = "0x7378510", Offset = "0x7376B10", VA = "0x187378510")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000095")]
			public BKMINCPGJKF CKDJDBNIEEN
			{
				[Cpp2IlInjected.Token(Token = "0x6000302")]
				[Cpp2IlInjected.Address(RVA = "0x73784D0", Offset = "0x7376AD0", VA = "0x1873784D0")]
				get
				{
					return default(BKMINCPGJKF);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x7378650", Offset = "0x7376C50", VA = "0x187378650")]
			public bool PHPDOJMIPBP(BKMINCPGJKF DNIICHOJIOP, object LAAJFAFNFCN, CLFGADHCMLH DKBNIPNLNJH)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x7378370", Offset = "0x7376970", VA = "0x187378370")]
			public bool JIIFKOJEADH(object LAAJFAFNFCN)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0x7378810", Offset = "0x7376E10", VA = "0x187378810")]
			protected HEGIBBBEJHN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000306")]
			[Cpp2IlInjected.Address(RVA = "0x73788A0", Offset = "0x7376EA0", VA = "0x1873788A0")]
			public HEGIBBBEJHN(ALIFPIFLCBK PHOLKKAAHFB, ODFMHACHCFM OKBAPKKKGCK, Animator IEACKBDAGDE, Transform FJGLBBJIGOO, Transform PMLHOOBBPAB, Vector3 JFOFOHGOEAF, Vector3 JHABGBAOAJH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000307")]
			[Cpp2IlInjected.Address(RVA = "0x7377DC0", Offset = "0x73763C0", VA = "0x187377DC0")]
			private void DAFLBNBPLCJ(ushort OPEDKOMLKHD, ushort AKLNHNJLKBM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000308")]
			[Cpp2IlInjected.Address(RVA = "0x7378230", Offset = "0x7376830", VA = "0x187378230")]
			protected void HHEMFNDFFJP(ushort OPEDKOMLKHD, ushort AKLNHNJLKBM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0x7377E70", Offset = "0x7376470", VA = "0x187377E70")]
			protected void DMDBIBHKHKB(ushort OPEDKOMLKHD, ushort AKLNHNJLKBM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0x7377C90", Offset = "0x7376290", VA = "0x187377C90")]
			protected void CLKPBDEKAAL(ushort OPEDKOMLKHD, ushort AKLNHNJLKBM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0x7378120", Offset = "0x7376720", VA = "0x187378120")]
			protected void GAMMOOCBILB(ushort OPEDKOMLKHD, ushort AKLNHNJLKBM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0x7378470", Offset = "0x7376A70", VA = "0x187378470")]
			protected void LCBMJCGFEMF(ushort OPEDKOMLKHD, ushort AKLNHNJLKBM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x7378320", Offset = "0x7376920", VA = "0x187378320")]
			protected void IFCPLFNPENG(ushort OPEDKOMLKHD, ushort AKLNHNJLKBM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x73780D0", Offset = "0x73766D0", VA = "0x1873780D0")]
			protected void FLNMFPCGLCJ(ushort OPEDKOMLKHD, ushort AKLNHNJLKBM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x7377B70", Offset = "0x7376170", VA = "0x187377B70")]
			protected void CAMNKKOEFDP(ushort OPEDKOMLKHD, ushort AKLNHNJLKBM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000060")]
		public class KNJLNBBJAHG : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x4000377")]
			public const int HPKJLGGJEKO = 16;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000378")]
			protected MaterialPropertyBlock POJMKDMPEIN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000379")]
			public Color? DBFOGHLDJED;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400037A")]
			public Color? ECJHEDNAHDI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400037B")]
			public Color? KKEFJABJJAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x400037C")]
			public Color NGGONCEKJCA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x400037D")]
			public Color GKNLPPDHKEM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x400037E")]
			public Color JHGGCJMNIIB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x400037F")]
			public Texture2D PEMJGFCGPDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000380")]
			public Texture2D OJMNJIKGIAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x4000381")]
			protected Dictionary<LNEMEGHNMGK, int> EDEDDIPBAKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x4000382")]
			protected ELDJGACMLPI[] OLGAPGAFCHK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x4000383")]
			public Vector4[] HOJBCIMGAAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x4000384")]
			public Vector4[] BDBEABPMDEL;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x4000385")]
			public Vector4[] KJIEKGGINDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000386")]
			public Vector4[] JFGADDKDPFL;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x4000387")]
			public Vector4[] HFBGOEODNAK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000388")]
			public Vector4[] JAEKGDEJLIH;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000389")]
			protected List<Texture2D> OPOKJAJLMNK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400038A")]
			protected Vector4[] BNGCKLBFOHA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
			[Cpp2IlInjected.Token(Token = "0x400038B")]
			protected List<Texture2D> JLAFFJPDHMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
			[Cpp2IlInjected.Token(Token = "0x400038C")]
			protected float[] NDBEGEBBMCO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
			[Cpp2IlInjected.Token(Token = "0x400038D")]
			protected Vector4[] BGPBFAMDCNF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x400038E")]
			protected float[] GKIAFCDHIHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			public float[] EBGAFMNGHCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
			[Cpp2IlInjected.Token(Token = "0x4000390")]
			protected List<Texture2D> FEMNFDNOCAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
			[Cpp2IlInjected.Token(Token = "0x4000391")]
			protected float[] OBHLACGDJEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
			[Cpp2IlInjected.Token(Token = "0x4000392")]
			protected List<Texture2D> MJPMAEAHEFC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
			[Cpp2IlInjected.Token(Token = "0x4000393")]
			protected Vector4[] IOJLMDDLGIN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
			[Cpp2IlInjected.Token(Token = "0x4000394")]
			protected float[] MNPJFHPKEJM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
			[Cpp2IlInjected.Token(Token = "0x4000395")]
			protected Vector4[] KEILFGELNAJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x4000396")]
			public float[] NBOOGPMEMPE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
			[Cpp2IlInjected.Token(Token = "0x4000397")]
			public Texture2DArray KPEGGKDEHEC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x4000398")]
			public Texture2DArray GFPLLCKOODK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
			[Cpp2IlInjected.Token(Token = "0x4000399")]
			public Texture2DArray EGAPGMHFKMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
			[Cpp2IlInjected.Token(Token = "0x400039A")]
			public Texture2DArray NAPIIOFHDCL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x400039B")]
			protected bool DBKFKABAANI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			protected int INGGKPCIDHC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
			[Cpp2IlInjected.Token(Token = "0x400039D")]
			protected Vector2? JBBELKDHKLP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
			[Cpp2IlInjected.Token(Token = "0x400039E")]
			protected TextureFormat NGMJABNEGJE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
			[Cpp2IlInjected.Token(Token = "0x400039F")]
			protected Vector2? CADHEHGAHML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
			[Cpp2IlInjected.Token(Token = "0x40003A0")]
			protected TextureFormat HAIDPOCPDLI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
			[Cpp2IlInjected.Token(Token = "0x40003A1")]
			protected Vector2? CKIKGHGFLIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
			[Cpp2IlInjected.Token(Token = "0x40003A2")]
			protected TextureFormat NDKEFKCMEDB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
			[Cpp2IlInjected.Token(Token = "0x40003A3")]
			protected Vector2? ELNCKGGCOLK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
			[Cpp2IlInjected.Token(Token = "0x40003A4")]
			protected TextureFormat NCBKONCKIGC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
			[Cpp2IlInjected.Token(Token = "0x40003A5")]
			protected bool LIABCKHNDHI;

			[Cpp2IlInjected.Token(Token = "0x40003A6")]
			protected static int JBBPANEJIAG;

			[Cpp2IlInjected.Token(Token = "0x40003A7")]
			protected static int HJAJBKIFOCD;

			[Cpp2IlInjected.Token(Token = "0x40003A8")]
			protected static int BBCJEOJMLAJ;

			[Cpp2IlInjected.Token(Token = "0x40003A9")]
			protected static int MJGPALFPDEM;

			[Cpp2IlInjected.Token(Token = "0x40003AA")]
			protected static int CGCHFBIFEOG;

			[Cpp2IlInjected.Token(Token = "0x40003AB")]
			protected static int OAAIHKJABCD;

			[Cpp2IlInjected.Token(Token = "0x40003AC")]
			protected static int NMLGBBJNHCH;

			[Cpp2IlInjected.Token(Token = "0x40003AD")]
			protected static int MBFFNHDMPCD;

			[Cpp2IlInjected.Token(Token = "0x40003AE")]
			protected static int GEAGJCFCCAK;

			[Cpp2IlInjected.Token(Token = "0x40003AF")]
			protected static int HNDKJNBCNPP;

			[Cpp2IlInjected.Token(Token = "0x40003B0")]
			protected static int OPEGEMNONGG;

			[Cpp2IlInjected.Token(Token = "0x40003B1")]
			protected static int JLAMHKENNND;

			[Cpp2IlInjected.Token(Token = "0x40003B2")]
			protected static int GAHBGIPKNBC;

			[Cpp2IlInjected.Token(Token = "0x40003B3")]
			protected static int LOEMIFOJCBL;

			[Cpp2IlInjected.Token(Token = "0x40003B4")]
			protected static int PGCKGHEENJP;

			[Cpp2IlInjected.Token(Token = "0x40003B5")]
			protected static int HAPMHMNCHHB;

			[Cpp2IlInjected.Token(Token = "0x40003B6")]
			protected static int EGNOEHCMCKC;

			[Cpp2IlInjected.Token(Token = "0x40003B7")]
			protected static int HLMHFCCNEFI;

			[Cpp2IlInjected.Token(Token = "0x40003B8")]
			protected static int LMLBKGIEJBB;

			[Cpp2IlInjected.Token(Token = "0x40003B9")]
			protected static int KLPBMFFPJAO;

			[Cpp2IlInjected.Token(Token = "0x6000311")]
			[Cpp2IlInjected.Address(RVA = "0x737C670", Offset = "0x737AC70", VA = "0x18737C670")]
			protected KNJLNBBJAHG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000312")]
			[Cpp2IlInjected.Address(RVA = "0x737C5E0", Offset = "0x737ABE0", VA = "0x18737C5E0")]
			public KNJLNBBJAHG(Color IEBFENEMEIK, Color LOAJNIGDFIE, Color EAPIHGGHMMD, Color? AINKANFBEBP, Color? IHKBKDHEBPP, Color? LMMBMHGICJK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0x737C0D0", Offset = "0x737A6D0", VA = "0x18737C0D0")]
			public int OMBEAPDGBME(Material GAOIEHMCMOL, ELDJGACMLPI PIEGLLCHINN, FKJFCNDMIGG IPEPMKFNFHH, OBJHNMCDGDL DBDEIKJCEBF)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x737C1C0", Offset = "0x737A7C0", VA = "0x18737C1C0")]
			public int OMBEAPDGBME(LNEMEGHNMGK LKMGECEEGEE)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x737AB90", Offset = "0x7379190", VA = "0x18737AB90")]
			public int DBKADKAPBAC(Material GAOIEHMCMOL, Color KDBCFKGNGJP, Color OJKPDPFPHGP, Color EKKHNINCDDG, Color AJJDBGBBOLB, Color CEJFGPJEHDN, Texture2D PEJBFDIAPAA, Vector4 PHIIPKGLPLE, Texture2D DOJBPMEJOBE, Vector4 IFCCKHDPJEB, float FJNCKBNFJAI, float IGLGBOOJJAK, Texture2D IDDFMOLLGGE, Vector4 BAIJHFDMEEF, float HPGDACJJKHN, Texture2D BOEADKHPNCM, float OBCJIGFDOBJ, Color DDPMLLMDLNO, Vector4 HBDHPJCLBEB, ELDJGACMLPI PIEGLLCHINN, FKJFCNDMIGG IPEPMKFNFHH, OBJHNMCDGDL DBDEIKJCEBF)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x737BC10", Offset = "0x737A210", VA = "0x18737BC10")]
			protected void IKMNPHEGCBH([Out] Texture2DArray DHCFOIPLAJB, [Out] Texture2DArray AKKHPCLFJAI, [Out] Texture2DArray CPKNNGHENAK, [Out] Texture2DArray GNGDKHFMOBP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x737BE60", Offset = "0x737A460", VA = "0x18737BE60")]
			public void MCPMPJFJMIF(PlayerAvatarDisplayBase HEGOBJEGDKO, Renderer EHMEICJAGNO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x737A060", Offset = "0x7378660", VA = "0x18737A060")]
			protected void ALIOBPFNCIG(PlayerAvatarDisplayBase HEGOBJEGDKO, Renderer EHMEICJAGNO, int EJODJKFNBCN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0x737BA20", Offset = "0x737A020", VA = "0x18737BA20")]
			private Color EHOAOMHALFA(Color OIICHJCCJLN, ELDJGACMLPI PIKKFHOHKHL)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0x737B8D0", Offset = "0x7379ED0", VA = "0x18737B8D0")]
			private Color EFACPGNNAKD(Color AMIJDAKAKKP, ELDJGACMLPI PIKKFHOHKHL)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x737BDD0", Offset = "0x737A3D0", VA = "0x18737BDD0")]
			protected void LFLFHOBPLME()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x737B890", Offset = "0x7379E90", VA = "0x18737B890", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000061")]
		public struct PlayerHandBones
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003BA")]
			public Transform[] LeftHandBones;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003BB")]
			public Transform LeftHandRoot;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003BC")]
			public Transform[] RightHandBones;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			public Transform RightHandRoot;

			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x7384310", Offset = "0x7382910", VA = "0x187384310")]
			public void JBFLGMNOKGA(OBJHNMCDGDL DBDEIKJCEBF, [Out] Transform JGHOOBNHEJB, [Out] Transform[] BLNGGKCOHMF)
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		protected struct BodyPartLODs
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			public Mesh[] LODs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003BF")]
			public bool UseHandBones;
		}

		[Cpp2IlInjected.Token(Token = "0x2000064")]
		[CompilerGenerated]
		private sealed class OMPDDABBAAI : IEnumerable<SkinnedMeshRenderer>, IEnumerable, IEnumerator<SkinnedMeshRenderer>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003C7")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003C8")]
			private SkinnedMeshRenderer <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003C9")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003CA")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003CB")]
			private SkinnedMeshRenderer[] <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003CC")]
			private int <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x17000096")]
			SkinnedMeshRenderer IEnumerator<SkinnedMeshRenderer>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600032A")]
				[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000097")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600032C")]
				[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0xD37BA0", Offset = "0xD361A0", VA = "0x180D37BA0")]
			[DebuggerHidden]
			public OMPDDABBAAI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x737D850", Offset = "0x737BE50", VA = "0x18737D850", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x737DAD0", Offset = "0x737C0D0", VA = "0x18737DAD0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x737DA20", Offset = "0x737C020", VA = "0x18737DA20", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<SkinnedMeshRenderer> IEnumerable<SkinnedMeshRenderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x737DA20", Offset = "0x737C020", VA = "0x18737DA20", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000065")]
		[CompilerGenerated]
		private sealed class CEJDPBPHEON
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003CD")]
			public PlayerAvatarDisplayBase display;

			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
			public CEJDPBPHEON()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x7375F60", Offset = "0x7374560", VA = "0x187375F60")]
			internal bool LKOEBPHGGCO()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class JFCBIADKNGN : IEnumerator<FBLKJCIOKGP>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003CE")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003CF")]
			private FBLKJCIOKGP <>2__current;

			[Cpp2IlInjected.Token(Token = "0x17000098")]
			private FBLKJCIOKGP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000334")]
				[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000099")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000336")]
				[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x9527A0", Offset = "0x950DA0", VA = "0x1809527A0")]
			[DebuggerHidden]
			public JFCBIADKNGN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(RVA = "0x7379420", Offset = "0x7377A20", VA = "0x187379420", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0x7379800", Offset = "0x7377E00", VA = "0x187379800", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000067")]
		[CompilerGenerated]
		private struct BILOBGHABJN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003D1")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003D2")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003D3")]
			public PHGEAGLPDDM avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003D4")]
			private bool <forceRebuild>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003D5")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x7375680", Offset = "0x7373C80", VA = "0x187375680", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0x7375E50", Offset = "0x7374450", VA = "0x187375E50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000068")]
		[CompilerGenerated]
		private sealed class CJKMHDKPOBN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003D6")]
			public string overrideIdentifier;

			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
			public CJKMHDKPOBN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x7376040", Offset = "0x7374640", VA = "0x187376040")]
			internal bool PMJJGPMCPGP(DKLBEPIMGOL selection)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000069")]
		[CompilerGenerated]
		private sealed class DBDPACCHNON
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003D7")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003D8")]
			public AvatarItemBodyType avatarItemBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003D9")]
			public Func<NEEPBAPEEOL<Dictionary<string, EBHOPDBMNPK<Texture2D>>>> <>9__2;

			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
			public DBDPACCHNON()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x7376070", Offset = "0x7374670", VA = "0x187376070")]
			internal (AEIHFJALFJE, NEEPBAPEEOL<Dictionary<string, EBHOPDBMNPK<Texture2D>>>) FNHBAMPONEP(Dictionary<string, LJKKDAKGHIG> avatarItems)
			{
				return default((AEIHFJALFJE, NEEPBAPEEOL<Dictionary<string, EBHOPDBMNPK<Texture2D>>>));
			}

			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x73762B0", Offset = "0x73748B0", VA = "0x1873762B0")]
			internal NEEPBAPEEOL<Dictionary<string, EBHOPDBMNPK<Texture2D>>> HDJPIMHPMDD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x7376270", Offset = "0x7374870", VA = "0x187376270")]
			internal void HAJDKDPHGOG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006A")]
		[CompilerGenerated]
		private sealed class CDDCEJNHOBA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003DA")]
			public Transform transformToCheck;

			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
			public CDDCEJNHOBA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x7375EB0", Offset = "0x73744B0", VA = "0x187375EB0")]
			internal bool JOOKCDDJKKP(SkinnedMeshRenderer x)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006B")]
		[CompilerGenerated]
		private struct JPGFIIAMAMN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003DB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003DC")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003DD")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003DE")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x7379E30", Offset = "0x7378430", VA = "0x187379E30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x737A000", Offset = "0x7378600", VA = "0x18737A000", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		protected static readonly int EENGMNKCIPB;

		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		protected static readonly int DBFMBBCPHAL;

		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		protected static readonly int AJEDMGPCFNL;

		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		protected static readonly int JOECFFLEBJE;

		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		protected static readonly int GBCMFLNPEMM;

		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		protected static readonly int HAFGEAALIDC;

		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		protected static readonly int[] MMPPDPODECL;

		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		protected static readonly int[] DOHBKMNICMB;

		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		protected static readonly int[] GCHBGCIKEDA;

		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		protected static readonly int[] DKPBCEHDAKP;

		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		protected static readonly int[] IODDJNAMABK;

		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		protected static readonly int[] LELFALJLLNF;

		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		protected static List<PlayerAvatarDisplayBase> LFCMPEDEBBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		protected MLFKPMGCMHF LCPEEIIIFPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		protected bool KHFOHCPJDLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		protected bool EPFJHEKEEKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		[SerializeField]
		public AvatarBodyShapeVault BodyShapeVault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		[SerializeField]
		public AvatarFaceShapeVault FaceShapeVault;

		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		protected static readonly int[] HMEMLCPNLNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		[SerializeField]
		protected Material bodyPartMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		protected Dictionary<LNEMEGHNMGK, Material> LLMDMJGLMHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		protected Dictionary<LNEMEGHNMGK, Material> EDOHPICCECH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		[SerializeField]
		protected bool ignorePlayerMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		[SerializeField]
		protected Transform trackingSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		[SerializeField]
		protected BodyPartLODs Head;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		[SerializeField]
		protected BodyPartLODs Ear;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		[SerializeField]
		protected BodyPartLODs Torso;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		[SerializeField]
		protected BodyPartLODs Hand;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		[SerializeField]
		protected BodyPartLODs HandPointing;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		[SerializeField]
		public PlayerHandBones HandBones;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		[SerializeField]
		public Transform remoteMeshBase;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public readonly SkinnedMeshRenderer[] CurrentDefaultSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public readonly SkinnedMeshRenderer[] NextDefaultSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public readonly SkinnedMeshRenderer[] CurrentVisibleInFirstPersonSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public readonly SkinnedMeshRenderer[] NextVisibleInFirstPersonSkinnedMeshRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		[SerializeField]
		public Transform firstPersonMeshBase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		[SerializeField]
		protected Shader uberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		[SerializeField]
		protected Shader agAvatarShader;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		protected Material KLPAIIMPKMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		protected AHBNJGDEGOO HHDIOHFFFHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		private ODFMHACHCFM PKJKEKAGLJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		private ODFMHACHCFM CLFKCPDLIKB;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		protected Material IFAHJHJIBEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		[SerializeField]
		protected Transform headPropAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		[SerializeField]
		protected Transform hatAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		[SerializeField]
		public Transform hemisphereBase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		protected FitMeshHemisphere AGNPDMHKOEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		protected bool EMMPNBIAECL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		protected KOIFPCMFICK FCEFAPAPCKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		protected bool CELFBFMLIEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		protected AnchorParamsRestrictions HBMDEFKGEPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		protected bool ELPOACHIOLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		protected Transform JHGKNCGAJBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		protected bool PCBPKJDPPFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A1")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		protected bool KHAFCCBICNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		protected Vector3 OKFBHKFPILO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		protected Quaternion BNKBCEIFNND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		protected Vector2 ICFJIMJLGKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		protected FitMeshHemisphere GHIJIOECEKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		[ALEFAIIJNEI(KCNGGJNCENB.SelfAndChildren, false, false, false)]
		[SerializeField]
		protected PlayerFacialAnimatorBase facialAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		[SerializeField]
		protected Transform torsoPropAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		[SerializeField]
		protected Transform torsoRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		[SerializeField]
		protected Transform headRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		[SerializeField]
		protected Transform leftHandRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		[SerializeField]
		protected Transform leftHandDefaultScaleRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		[SerializeField]
		protected Transform rightHandRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		[SerializeField]
		protected Transform rightHandDefaultScaleRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		[SerializeField]
		protected Animator leftHandAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		[SerializeField]
		protected Animator rightHandAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		[SerializeField]
		protected Transform leftHandPointingRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		[SerializeField]
		protected Transform rightHandPointingRoot;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		protected Collider[] PPLBIFPAJFH;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		protected Collider[] PBLHPOKEKLE;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		protected HEGIBBBEJHN[] GMLMCDNOIGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		[SerializeField]
		protected Mesh faceMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public Dictionary<Renderer, KNJLNBBJAHG> currentPropertyBlocks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		protected Dictionary<Renderer, KNJLNBBJAHG> PMLBLGLJEJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		protected ODNKPFEIMKD JHBLIAABOCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		protected AEIHFJALFJE DFECPEFMFJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public OINJBHOKJEJ DistanceBand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x274")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		protected int HPJIMKEBIGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		protected (bool isLodForced, int forcedLOD) DJJOPGFPBHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		protected GJKLJJDNPDD<GGAINOJCJPJ> NCKEEFGIMMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		protected bool FBMHPFAFMCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		protected Dictionary<DKLBEPIMGOL, List<LNEMEGHNMGK>> ALDJPGNOHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		protected Dictionary<DKLBEPIMGOL, List<LNEMEGHNMGK>> NAPDMGCNNAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		protected readonly Dictionary<string, EBHOPDBMNPK<Texture2D>> EAKKDLJOPCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		protected readonly Dictionary<string, EBHOPDBMNPK<Texture2D>> KNKAHNBLHBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		protected bool PKEDEKCJODK;

		[Cpp2IlInjected.Token(Token = "0x4000313")]
		protected static int FOBNELMHBNG;

		[Cpp2IlInjected.Token(Token = "0x4000314")]
		protected static List<MJOIPLEFGEK> KGKDPLCBKDJ;

		[Cpp2IlInjected.Token(Token = "0x4000315")]
		protected static List<MJOIPLEFGEK> JJFMHDJCKHP;

		[Cpp2IlInjected.Token(Token = "0x4000316")]
		protected static HPLGDNGCOKN ANKJECKPPBO;

		[Cpp2IlInjected.Token(Token = "0x4000317")]
		protected static bool OBACEFNPEEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		protected Color? HBBBAGKEGCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D4")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		protected bool NDEIJGBMGBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		protected Color MDCPKLLCLGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		protected Color EAIAPJMFKLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		protected Color BFBIOPJMJHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		protected AvatarHairPattern MNGNHFEBPHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		protected LBKMHAIBEMP JGKCMNOENLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		protected Color JNNKCABDFKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		protected Color LGJNGKFIDGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		protected AvatarHairPattern HDPDGCIMGLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		protected LBKMHAIBEMP ENFACHIIAOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		protected LBKMHAIBEMP FGFKBLPLAIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		protected Color AAOAAOIMDNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		private AdditionalFeetData MINMJKBNHDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		protected DKLBEPIMGOL? GCMKDMLPHNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		protected Texture JKJNMFGIDKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		protected Color OFHKFHNNOEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		protected readonly IList<DKLBEPIMGOL> FNGNAHPKIHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		protected readonly IList<DKLBEPIMGOL> ALONNONBDKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		private AvatarItemBodyType GHGKJMFKKGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		[SerializeField]
		protected AvatarFaceShape _currentFaceShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		[SerializeField]
		protected AvatarBodyShape _currentBodyShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		[SerializeField]
		protected EHLDDELHBFB _currentNoseType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C4")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		[SerializeField]
		protected bool _hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C5")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		protected BKKKDFDJABB CJLPKDANKGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C8")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		protected int[] ICOIDHHEILP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D0")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		protected bool GFEFHPNLECK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		protected int[] IMMKFBHAGAB;

		[Cpp2IlInjected.Token(Token = "0x4000334")]
		private static readonly KBAIGJMAONF.FALICHFPADL IBHLCNBDIFK;

		[Cpp2IlInjected.Token(Token = "0x4000335")]
		private static readonly KBAIGJMAONF.FALICHFPADL KNILGKKGDHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E0")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		protected bool PPPBJHOPPJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E8")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		protected IKKEFGFKHCN PKLGHJOCJJJ;

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public string MKIPMCLEPNK
		{
			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x9529E0", Offset = "0x950FE0", VA = "0x1809529E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x9527E0", Offset = "0x950DE0", VA = "0x1809527E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool BIJDDCNCAGO
		{
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0xAAE920", Offset = "0xAACF20", VA = "0x180AAE920")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0xAE45B0", Offset = "0xAE2BB0", VA = "0x180AE45B0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public virtual bool GHJLMJIOCHO
		{
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public bool AFHCNNBELPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x7373F60", Offset = "0x7372560", VA = "0x187373F60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public virtual bool GFOONPMPDLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public virtual bool PHGHEPMAOMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x96C540", Offset = "0x96AB40", VA = "0x18096C540", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public virtual bool KNEHHDCHNJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public AHBNJGDEGOO LMEODEAOMEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x9C1A50", Offset = "0x9C0050", VA = "0x1809C1A50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x73745E0", Offset = "0x7372BE0", VA = "0x1873745E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public ODFMHACHCFM DIHHKCLABAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x9C2350", Offset = "0x9C0950", VA = "0x1809C2350")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x73749E0", Offset = "0x7372FE0", VA = "0x1873749E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public ODFMHACHCFM NKCLBCHHOOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x9C0E20", Offset = "0x9BF420", VA = "0x1809C0E20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x7374CB0", Offset = "0x73732B0", VA = "0x187374CB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		protected Material ICLFDEAAPPN
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x7369DF0", Offset = "0x73683F0", VA = "0x187369DF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		protected Material PNFKECHGNEL
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x736D2F0", Offset = "0x736B8F0", VA = "0x18736D2F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public bool CNNEOJNPHOE
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0xA32CE0", Offset = "0xA312E0", VA = "0x180A32CE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public PlayerFacialAnimatorBase IKKFFJALPEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0xACC820", Offset = "0xACAE20", VA = "0x180ACC820")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public HEGIBBBEJHN[] GNIEKCGFAEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x7373B20", Offset = "0x7372120", VA = "0x187373B20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public HEGIBBBEJHN PEFMKDMKOCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x7374160", Offset = "0x7372760", VA = "0x187374160")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public HEGIBBBEJHN CGHDLOOBEPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x7374190", Offset = "0x7372790", VA = "0x187374190")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public Mesh IACIMEKIMKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0xC7EA80", Offset = "0xC7D080", VA = "0x180C7EA80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		protected ODNKPFEIMKD EIPFKLNLHNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x736DB40", Offset = "0x736C140", VA = "0x18736DB40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		protected AEIHFJALFJE JDBNIPDFEHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0xFE9170", Offset = "0xFE7770", VA = "0x180FE9170")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x736DFF0", Offset = "0x736C5F0", VA = "0x18736DFF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		protected bool KNAMMMJKBJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x96C540", Offset = "0x96AB40", VA = "0x18096C540")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public bool OLIDFCMCDJE
		{
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x7374150", Offset = "0x7372750", VA = "0x187374150")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public int DMLAADHPPMO
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0xFE9540", Offset = "0xFE7B40", VA = "0x180FE9540")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x7374BF0", Offset = "0x73731F0", VA = "0x187374BF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public int HEEHNPCCAID
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x7374930", Offset = "0x7372F30", VA = "0x187374930")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		protected virtual bool BOPMHFGJLMK
		{
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		protected virtual int[] EPCDBJMNNKB
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x736B7B0", Offset = "0x7369DB0", VA = "0x18736B7B0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		protected bool MAFFHLMNBPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x736E8A0", Offset = "0x736CEA0", VA = "0x18736E8A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		protected static bool OGFKAKDJLFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public bool MLAMHGNHHOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0xFE9620", Offset = "0xFE7C20", VA = "0x180FE9620")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x7374ED0", Offset = "0x73734D0", VA = "0x187374ED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public IEnumerable<SkinnedMeshRenderer> PGEENBIKCFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x73739F0", Offset = "0x7371FF0", VA = "0x1873739F0")]
			[IteratorStateMachine(typeof(OMPDDABBAAI))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public bool KFMLNKJFEGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0xFE8760", Offset = "0xFE6D60", VA = "0x180FE8760")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0xFE9780", Offset = "0xFE7D80", VA = "0x180FE9780")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public PKOOKMMPLDP CBKHCHACMEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x7373A70", Offset = "0x7372070", VA = "0x187373A70")]
			get
			{
				return default(PKOOKMMPLDP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public static bool KLKFMDFKAEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x7373ED0", Offset = "0x73724D0", VA = "0x187373ED0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		protected static HPLGDNGCOKN AGNJOELKFFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0x736F400", Offset = "0x736DA00", VA = "0x18736F400")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x73676F0", Offset = "0x7365CF0", VA = "0x1873676F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		protected Color ECJHEDNAHDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0x736F3B0", Offset = "0x736D9B0", VA = "0x18736F3B0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		protected Color KKEFJABJJAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0x736CA00", Offset = "0x736B000", VA = "0x18736CA00")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		protected Texture2D KGAIHADCCCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000282")]
			[Cpp2IlInjected.Address(RVA = "0x73673C0", Offset = "0x73659C0", VA = "0x1873673C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		protected Color NGGONCEKJCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000288")]
			[Cpp2IlInjected.Address(RVA = "0x736DFA0", Offset = "0x736C5A0", VA = "0x18736DFA0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		protected Color GKNLPPDHKEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0x73682A0", Offset = "0x73668A0", VA = "0x1873682A0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public LBKMHAIBEMP EINLPAIDPLC
		{
			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0x7373AE0", Offset = "0x73720E0", VA = "0x187373AE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		protected Texture2D CBNMELCECPI
		{
			[Cpp2IlInjected.Token(Token = "0x600028B")]
			[Cpp2IlInjected.Address(RVA = "0x736F0F0", Offset = "0x736D6F0", VA = "0x18736F0F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public float FFOICMBMFFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000292")]
			[Cpp2IlInjected.Address(RVA = "0x7373B00", Offset = "0x7372100", VA = "0x187373B00")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public float NNLEPEFBAEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000293")]
			[Cpp2IlInjected.Address(RVA = "0x7373F40", Offset = "0x7372540", VA = "0x187373F40")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public bool EDHJJAAPPEI
		{
			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0x7373AD0", Offset = "0x73720D0", VA = "0x187373AD0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x73743C0", Offset = "0x73729C0", VA = "0x1873743C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action DMIIGPCLCJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x7373890", Offset = "0x7371E90", VA = "0x187373890")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x7374260", Offset = "0x7372860", VA = "0x187374260")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action EAEKMDELFCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x73737F0", Offset = "0x7371DF0", VA = "0x1873737F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x73741C0", Offset = "0x73727C0", VA = "0x1873741C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<ALIFPIFLCBK, BKMINCPGJKF> GLONJACJJGN
		{
			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x7373930", Offset = "0x7371F30", VA = "0x187373930")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x7374300", Offset = "0x7372900", VA = "0x187374300")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x7370630", Offset = "0x736EC30", VA = "0x187370630")]
		public bool SetDeformation(bool KHFOHCPJDLH, bool EPFJHEKEEKH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x736C150", Offset = "0x736A750", VA = "0x18736C150")]
		protected static Material FNBMMPFEOGN(Dictionary<LNEMEGHNMGK, Material> FMPOBMMKKCL, Material EAOFNOHCOIK, ELDJGACMLPI PIEGLLCHINN, FKJFCNDMIGG IPEPMKFNFHH, OBJHNMCDGDL DBDEIKJCEBF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x736BD50", Offset = "0x736A350", VA = "0x18736BD50")]
		protected void FJNBIIPIADI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x7367120", Offset = "0x7365720", VA = "0x187367120")]
		protected bool AEPHKEKAMPK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x736CCA0", Offset = "0x736B2A0", VA = "0x18736CCA0")]
		protected void ICMNMJNLBIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x736E090", Offset = "0x736C690", VA = "0x18736E090", Slot = "10")]
		protected virtual void LPBEFJCMGJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x736E5F0", Offset = "0x736CBF0", VA = "0x18736E5F0")]
		public int MeshesAtLODCount(int OOKKGNGNINK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x736D860", Offset = "0x736BE60", VA = "0x18736D860")]
		protected static void KGKDIECJCLK(Dictionary<DKLBEPIMGOL, List<LNEMEGHNMGK>> JAGFBALGAPL, OGMDKFDFBIB GCHFPPMPGNO, Material EAOFNOHCOIK, ELDJGACMLPI PIKKFHOHKHL, FKJFCNDMIGG CJLDBFGOACG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x7368180", Offset = "0x7366780", VA = "0x187368180")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x736DB60", Offset = "0x736C160", VA = "0x18736DB60")]
		protected void KPHFFEGGHFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x736EEB0", Offset = "0x736D4B0", VA = "0x18736EEB0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "11")]
		protected virtual void OMJNJIDJPGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x736D3E0", Offset = "0x736B9E0", VA = "0x18736D3E0")]
		protected static void JJCKJLADAIN(List<Material> CFAAEHNEANO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x736C7A0", Offset = "0x736ADA0", VA = "0x18736C7A0")]
		protected static void GLEFBGGLDOE(Dictionary<LNEMEGHNMGK, Material> FMPOBMMKKCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x736E390", Offset = "0x736C990", VA = "0x18736E390")]
		protected static void MJJBIKBIJAJ(Dictionary<Renderer, KNJLNBBJAHG> GEMDCFELCIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x736BE70", Offset = "0x736A470", VA = "0x18736BE70")]
		protected void FKCLIPAIKLH(SkinnedMeshRenderer[] LGCGHBBEHDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x736D730", Offset = "0x736BD30", VA = "0x18736D730")]
		protected void KFIADIGLLCL(SkinnedMeshRenderer BNBIMMBDEGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x736D660", Offset = "0x736BC60", VA = "0x18736D660")]
		protected void KFIADIGLLCL(MeshRenderer AADKLBCKCDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x73685C0", Offset = "0x7366BC0", VA = "0x1873685C0")]
		protected void BHFKGFPBMHJ(List<BELJNJGLPJA> MNMNOHFPEEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x736A030", Offset = "0x7368630", VA = "0x18736A030")]
		protected void CAIEKJGOFML(Dictionary<string, EBHOPDBMNPK<Texture2D>> JAGFBALGAPL, bool EFJOBKAGFFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x736A9E0", Offset = "0x7368FE0", VA = "0x18736A9E0")]
		protected void DANIGJMLNHN(Dictionary<DKLBEPIMGOL, List<LNEMEGHNMGK>> JAGFBALGAPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x736C900", Offset = "0x736AF00", VA = "0x18736C900")]
		public float GetHandOpenClosedAxis(ALIFPIFLCBK PHOLKKAAHFB)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x7370ED0", Offset = "0x736F4D0", VA = "0x187370ED0")]
		public void SetHandOpenClosedAxis(ALIFPIFLCBK PHOLKKAAHFB, float OGFACIKBBAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x736C940", Offset = "0x736AF40", VA = "0x18736C940")]
		public BKMINCPGJKF GetHandVisualState(ALIFPIFLCBK PHOLKKAAHFB)
		{
			return default(BKMINCPGJKF);
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x73678C0", Offset = "0x7365EC0", VA = "0x1873678C0")]
		public bool AddHandVisualStateToken(ALIFPIFLCBK PHOLKKAAHFB, BKMINCPGJKF OJIBKECALBM, object LAAJFAFNFCN, HEGIBBBEJHN.CLFGADHCMLH DKBNIPNLNJH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x73726E0", Offset = "0x7370CE0", VA = "0x1873726E0")]
		public void SetWatchHand(ALIFPIFLCBK PHOLKKAAHFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x73727A0", Offset = "0x7370DA0", VA = "0x1873727A0")]
		public void SetWatchHands(bool HMBIFHBADHN, bool OIBIBKAIBBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x736FCF0", Offset = "0x736E2F0", VA = "0x18736FCF0")]
		public bool RemoveHandVisualStateToken(ALIFPIFLCBK PHOLKKAAHFB, object LAAJFAFNFCN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x736C9C0", Offset = "0x736AFC0", VA = "0x18736C9C0")]
		public bool GetThumbsUpActive(ALIFPIFLCBK PHOLKKAAHFB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x7372180", Offset = "0x7370780", VA = "0x187372180")]
		public void SetThumbsUpActive(ALIFPIFLCBK PHOLKKAAHFB, bool LGBGBEDLGBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x736C980", Offset = "0x736AF80", VA = "0x18736C980")]
		public bool GetHandshakeActive(ALIFPIFLCBK PHOLKKAAHFB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x7370F20", Offset = "0x736F520", VA = "0x187370F20")]
		public void SetHandshakeActive(ALIFPIFLCBK PHOLKKAAHFB, bool JCIGOMMGHAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x736C3C0", Offset = "0x736A9C0", VA = "0x18736C3C0")]
		public void ForceUpdateHandsVisualState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x736A8C0", Offset = "0x7368EC0", VA = "0x18736A8C0")]
		public static void ClearQueuedBuilds()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x736A1B0", Offset = "0x73687B0", VA = "0x18736A1B0")]
		protected static void CGHMDGGCEFB(PlayerAvatarDisplayBase NLNHILLAAMF, List<MJOIPLEFGEK> JIKCGAPMJJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x736FA10", Offset = "0x736E010", VA = "0x18736FA10")]
		public void Rebuild(bool FODJBNONHDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x736E850", Offset = "0x736CE50", VA = "0x18736E850")]
		protected void NGEDDFMLLCJ(bool FODJBNONHDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x736E700", Offset = "0x736CD00", VA = "0x18736E700", Slot = "12")]
		protected virtual HJOKANJAKGB NGEDDFMLLCJ(IList<DKLBEPIMGOL> BPMBLMHNOME, AvatarItemBodyType BLKBJOMPGJP, bool IEOMHDBLFBH, int[] KJEOHKIHMLH, bool FODJBNONHDP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x736AF70", Offset = "0x7369570", VA = "0x18736AF70")]
		protected static HJOKANJAKGB EFODKCHDFOH(MJOIPLEFGEK GANIPEBACIC, List<MJOIPLEFGEK> JIKCGAPMJJP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x736E2D0", Offset = "0x736C8D0", VA = "0x18736E2D0")]
		[IteratorStateMachine(typeof(JFCBIADKNGN))]
		protected static IEnumerator<FBLKJCIOKGP> MGBLCJFHGAM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x736E530", Offset = "0x736CB30", VA = "0x18736E530")]
		protected static MJOIPLEFGEK MMIBKMADJJC(List<MJOIPLEFGEK> JIKCGAPMJJP)
		{
			return default(MJOIPLEFGEK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x7370740", Offset = "0x736ED40", VA = "0x187370740")]
		[AsyncStateMachine(typeof(BILOBGHABJN))]
		public Task SetFaceCustomizationSettings(PHGEAGLPDDM ALBFPGNJIFO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x736D180", Offset = "0x736B780", VA = "0x18736D180")]
		public void InitializeFaceFeatures(AvatarConfiguration BFMGDLDGOKJ, PKOOKMMPLDP HMKELMICGGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x7371ED0", Offset = "0x73704D0", VA = "0x187371ED0")]
		public void SetTeamColors(Color? LMMBMHGICJK, bool HLFKDFPEEPH, Color IDFEHJNHPEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x10B96C0", Offset = "0x10B7CC0", VA = "0x1810B96C0")]
		private static void GACHLMJBBBN(Material HJCEHLILOIG, Color KBGCCIOIGBD, params int[] NFHNBPEAEMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x10BAA00", Offset = "0x10B9000", VA = "0x1810BAA00")]
		private static void OEEIOGMPIJG(Material HJCEHLILOIG, Texture KBGCCIOIGBD, params int[] NFHNBPEAEMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x736C450", Offset = "0x736AA50", VA = "0x18736C450")]
		protected void GFFKCEINPGG(Material PFHJOFPFGCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x736E0F0", Offset = "0x736C6F0", VA = "0x18736E0F0")]
		protected void LPOKHIGGAFD(Material PFHJOFPFGCD, Color MHFFAABGINO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x73682F0", Offset = "0x73668F0", VA = "0x1873682F0")]
		protected void BHDHMDFKPKI(Material PFHJOFPFGCD, Color MHFFAABGINO, Color OCMCDEJGILI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x736B590", Offset = "0x7369B90", VA = "0x18736B590")]
		protected void EGHFCEGEMFF(Material PFHJOFPFGCD, Texture2D IHOMIJNFMIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x736DE90", Offset = "0x736C490", VA = "0x18736DE90")]
		protected void LDBPDDIDAKN(Material PFHJOFPFGCD, Texture NCEMIDDEIKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x73674B0", Offset = "0x7365AB0", VA = "0x1873674B0")]
		protected void AGKEIJHGJBH(Action<KNJLNBBJAHG> EGIANMPBNKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x736E9A0", Offset = "0x736CFA0", VA = "0x18736E9A0")]
		protected void OEIPAJKFPDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x736BF90", Offset = "0x736A590", VA = "0x18736BF90")]
		protected void FKJKJIHKKKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x736F6B0", Offset = "0x736DCB0", VA = "0x18736F6B0")]
		protected void PMMHFCAJJJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x7367C10", Offset = "0x7366210", VA = "0x187367C10")]
		public void ApplyUgcItemOverrides()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x73700B0", Offset = "0x736E6B0", VA = "0x1873700B0")]
		public void SetBeardPrimaryColor([Optional] Color? HJAEBGNBNJK, bool AGDIGGIAMFA = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x73702D0", Offset = "0x736E8D0", VA = "0x1873702D0")]
		public void SetBeardSecondaryColor([Optional] Color? HJAEBGNBNJK, bool AGDIGGIAMFA = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x736FF70", Offset = "0x736E570", VA = "0x18736FF70")]
		public void SetBeardPattern([Optional] AvatarHairPattern EHGMFMGLMKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x7366FB0", Offset = "0x73655B0", VA = "0x187366FB0")]
		private void ABFBMPOPFAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x736CA50", Offset = "0x736B050", VA = "0x18736CA50")]
		private bool HLJIHMLMLKA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x7370AB0", Offset = "0x736F0B0", VA = "0x187370AB0")]
		public void SetHairPrimaryColor([Optional] Color? LGOBFMBCGCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x7370CC0", Offset = "0x736F2C0", VA = "0x187370CC0")]
		public void SetHairSecondaryColor([Optional] Color? LGOBFMBCGCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x7370980", Offset = "0x736EF80", VA = "0x187370980")]
		public void SetHairPattern([Optional] AvatarHairPattern EHGMFMGLMKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x736FB90", Offset = "0x736E190", VA = "0x18736FB90")]
		public void RefreshHair()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x736E210", Offset = "0x736C810", VA = "0x18736E210")]
		private bool MFOIJFPIBNO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x7371D10", Offset = "0x7370310", VA = "0x187371D10")]
		public void SetSkinColor(Color IEBFENEMEIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x73721D0", Offset = "0x73707D0", VA = "0x1873721D0")]
		public void SetUgcItemVisualOverrides(DKLBEPIMGOL JKFGJFHCKPG, PKOOKMMPLDP HMKELMICGGI, Texture EMFNIBFKLLM, Color JKCDHFCOFMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x736A990", Offset = "0x7368F90", VA = "0x18736A990")]
		public void ClearUgcItemVisualOverrides()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x7370840", Offset = "0x736EE40", VA = "0x187370840")]
		public bool SetFaceShape(AvatarFaceShape NGODEJMKEBN, bool KPBEAEKPEMK = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x736B840", Offset = "0x7369E40", VA = "0x18736B840")]
		private void EKABGBOGIKA(EEHFKDPJPMH BBBFKIMAKIC, float KBGCCIOIGBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x73697C0", Offset = "0x7367DC0", VA = "0x1873697C0")]
		private void BKKDPMPKBPA(LDIPODFLGPE AGDMLBHPFCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x73704F0", Offset = "0x736EAF0", VA = "0x1873704F0")]
		public bool SetBodyShape(AvatarBodyShape LJFANJBKMBL, bool KPBEAEKPEMK = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x7371BA0", Offset = "0x73701A0", VA = "0x187371BA0")]
		public bool SetNoseType(EHLDDELHBFB DIKOIBEAEJB, bool KPBEAEKPEMK = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x7372900", Offset = "0x7370F00", VA = "0x187372900")]
		public bool UpdateFaceAndBodyShapes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x7371B80", Offset = "0x7370180", VA = "0x187371B80")]
		public bool SetHideEars(bool LFAHIFJFEJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x7371B70", Offset = "0x7370170", VA = "0x187371B70")]
		public bool SetHelmetHair(MLFKPMGCMHF EAMLADKEKOI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x73715C0", Offset = "0x736FBC0", VA = "0x1873715C0")]
		public void SetHatAnchorParameters(KOIFPCMFICK OHNHANMMLDL, bool FAGLCHKMIHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x7372870", Offset = "0x7370E70", VA = "0x187372870")]
		public void SetupDisplayLODs(BKKKDFDJABB MFGNEKGKMHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x736F1F0", Offset = "0x736D7F0", VA = "0x18736F1F0")]
		protected int[] PCOBANKJNPD(BKKKDFDJABB MFGNEKGKMHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x7371CD0", Offset = "0x73702D0", VA = "0x187371CD0")]
		public void SetOutfitSelections(IList<DKLBEPIMGOL> BPMBLMHNOME, AvatarItemBodyType BLKBJOMPGJP, bool FODJBNONHDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x7371C40", Offset = "0x7370240", VA = "0x187371C40")]
		public void SetOutfitSelections(IList<DKLBEPIMGOL> BPMBLMHNOME, AvatarItemBodyType BLKBJOMPGJP, bool IEOMHDBLFBH, bool FODJBNONHDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x7371C80", Offset = "0x7370280", VA = "0x187371C80")]
		public HJOKANJAKGB SetOutfitSelections(IList<DKLBEPIMGOL> BPMBLMHNOME, AvatarItemBodyType BLKBJOMPGJP, BKKKDFDJABB MFGNEKGKMHE, bool IEOMHDBLFBH, bool KPBEAEKPEMK = false, bool FODJBNONHDP = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x736ABD0", Offset = "0x73691D0", VA = "0x18736ABD0", Slot = "13")]
		protected virtual HJOKANJAKGB DIPPIEKDJDM(IList<DKLBEPIMGOL> BPMBLMHNOME, AvatarItemBodyType BLKBJOMPGJP, bool IEOMHDBLFBH, BKKKDFDJABB MFGNEKGKMHE, bool KPBEAEKPEMK, bool FODJBNONHDP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x736CBA0", Offset = "0x736B1A0", VA = "0x18736CBA0")]
		protected int[] HONFGHFAPDM(BKKKDFDJABB MFGNEKGKMHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x951A70", Offset = "0x950070", VA = "0x180951A70", Slot = "14")]
		protected virtual AEIHFJALFJE EDNGGAPCMBB(AvatarItemBodyType KJBFEELDPAB, Dictionary<string, LJKKDAKGHIG> KAPNBAIJLON, Dictionary<string, EBHOPDBMNPK<Texture2D>> MENIIIJDJEG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x736EBE0", Offset = "0x736D1E0", VA = "0x18736EBE0", Slot = "15")]
		protected virtual HJOKANJAKGB OJGIPBAICDE(IList<DKLBEPIMGOL> BPMBLMHNOME, AvatarItemBodyType BLKBJOMPGJP, bool IEOMHDBLFBH, int[] MOFBLKNOEOE, IIFAJIGINPD ANIFCCOAEDH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x7369970", Offset = "0x7367F70", VA = "0x187369970", Slot = "16")]
		protected virtual LJKKDAKGHIG BMPOGOIJGLF(LBKMHAIBEMP HBNIICBFICF, AvatarItemBodyType KJBFEELDPAB, OBJHNMCDGDL DBDEIKJCEBF, LJKKDAKGHIG KHODDMLOMPP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x951A70", Offset = "0x950070", VA = "0x180951A70", Slot = "17")]
		protected virtual LJKKDAKGHIG HOLKKBAMALH(AvatarItemBodyType KJBFEELDPAB, OBJHNMCDGDL DBDEIKJCEBF, AONNKEALKEA KPHLIDJMEFA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x736E920", Offset = "0x736CF20", VA = "0x18736E920")]
		protected void NPMOACPKFGN(HNNBNAMEAIG IKFNLEDAJJD, KBAIGJMAONF.FALICHFPADL CBLJOJGPCHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x7367340", Offset = "0x7365940", VA = "0x187367340")]
		protected void AGAINFEELAH(HNNBNAMEAIG IKFNLEDAJJD, KBAIGJMAONF.FALICHFPADL CBLJOJGPCHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0xCAE960", Offset = "0xCACF60", VA = "0x180CAE960", Slot = "18")]
		protected virtual HNNBNAMEAIG IIICKCFHEAO(HNNBNAMEAIG IKFNLEDAJJD, HelmetHairStyle JHGKHIPKPEO, bool AKJEDGEFLEH, AvatarItemBodyType BLKBJOMPGJP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x73687A0", Offset = "0x7366DA0", VA = "0x1873687A0")]
		protected HNNBNAMEAIG BJHMHEKGOJJ(IList<DKLBEPIMGOL> BPMBLMHNOME, AvatarItemBodyType OFEJGACFKNP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x736A7A0", Offset = "0x7368DA0", VA = "0x18736A7A0")]
		public void CleanupDisplayResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x736D5B0", Offset = "0x736BBB0", VA = "0x18736D5B0")]
		protected void KCABLCPBMLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x736B950", Offset = "0x7369F50", VA = "0x18736B950")]
		protected void FBOAEMGGFOH(Transform ODFJLPNINFC, IEnumerable<SkinnedMeshRenderer> FGAGLOGNLAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x736D0C0", Offset = "0x736B6C0", VA = "0x18736D0C0")]
		protected KBAIGJMAONF.FALICHFPADL IMGJJICADOD(KBAIGJMAONF.FALICHFPADL NOAAJJKCHIA, OBJHNMCDGDL MKJCGACHDHK)
		{
			return default(KBAIGJMAONF.FALICHFPADL);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x736E330", Offset = "0x736C930", VA = "0x18736E330")]
		protected void MGIKIJNKDOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x1029E10", Offset = "0x1028410", VA = "0x181029E10")]
		protected void HNBHDJGFKEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x736C2B0", Offset = "0x736A8B0", VA = "0x18736C2B0")]
		protected void FPPBIBACHGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x736C6D0", Offset = "0x736ACD0", VA = "0x18736C6D0")]
		[AsyncStateMachine(typeof(JPGFIIAMAMN))]
		protected Task GHJJLNJPPAJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x736AA30", Offset = "0x7369030", VA = "0x18736AA30")]
		protected static ELDJGACMLPI DBDPHCDEDDD(OGMDKFDFBIB FAHICGIKPOG, int MFCLFEPKGAD)
		{
			return default(ELDJGACMLPI);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x736AE20", Offset = "0x7369420", VA = "0x18736AE20")]
		protected static FKJFCNDMIGG EFGPFDDOCGO(OGMDKFDFBIB FAHICGIKPOG, int MFCLFEPKGAD)
		{
			return default(FKJFCNDMIGG);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x73676A0", Offset = "0x7365CA0", VA = "0x1873676A0")]
		protected Transform AHNLNLMNGJJ(OBJHNMCDGDL DBDEIKJCEBF, OutfitType CNBEFNFJEEJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x736CDC0", Offset = "0x736B3C0", VA = "0x18736CDC0")]
		protected void IILLJHAHBOI(int CLLOKPKIGEH, Material HJCEHLILOIG, OGMDKFDFBIB FAHICGIKPOG, [Out] Texture2D KNJHLLDKNBN, [Out] Vector4 LEBIOKJNNBM, [Out] Texture2D HCBHLHALDCK, [Out] Texture2D AOLJNNMDFDK, [Out] Texture2D OIPGNFEPIAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x736F450", Offset = "0x736DA50", VA = "0x18736F450")]
		protected void PIKIKHNHLMM(int CLLOKPKIGEH, Material HJCEHLILOIG, OGMDKFDFBIB FAHICGIKPOG, [Out] Color KDBCFKGNGJP, [Out] Color OJKPDPFPHGP, [Out] Color EKKHNINCDDG, [Out] Color AJJDBGBBOLB, [Out] Color CEJFGPJEHDN, [Out] Color DDPMLLMDLNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x736D050", Offset = "0x736B650", VA = "0x18736D050")]
		protected void ILHEGNOANEF(Vector3 NAMOIOBECGF, Quaternion KGCMOGJCFFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x7370F70", Offset = "0x736F570", VA = "0x187370F70")]
		public void SetHatAnchorParameters(KOIFPCMFICK OHNHANMMLDL, AnchorParamsRestrictions OMNAKBCJIBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x736A2C0", Offset = "0x73688C0", VA = "0x18736A2C0")]
		public static void CalculateHatAnchorParams(FitMeshHemisphere AGNPDMHKOEB, Transform JHGKNCGAJBG, KOIFPCMFICK OHNHANMMLDL, AnchorParamsRestrictions HBMDEFKGEPA, [Out] Vector3 IJNCCGADGJC, [Out] Quaternion BALNGIJIBOK, [Out] KOIFPCMFICK DIFMNIOEHOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x736FE00", Offset = "0x736E400", VA = "0x18736FE00")]
		public void ResetHatAnchor(Vector2 OGFKPOHFILO, Vector3 GFMEDHAJNFG, Vector3 AAOMFNIJCFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x9BE9F0", Offset = "0x9BCFF0", VA = "0x1809BE9F0")]
		public BOEIPLPALDB GetAnchorParamsRestrictions()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x7367A40", Offset = "0x7366040", VA = "0x187367A40")]
		public void ApplyBlocks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x7367B80", Offset = "0x7366180", VA = "0x187367B80")]
		public void ApplyHairPattern()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x73679B0", Offset = "0x7365FB0", VA = "0x1873679B0")]
		public void ApplyBeardPattern()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x73728A0", Offset = "0x7370EA0", VA = "0x1873728A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x736BC80", Offset = "0x736A280", VA = "0x18736BC80")]
		protected void FCLPNKDFAJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x7372660", Offset = "0x7370C60", VA = "0x187372660")]
		public void SetWaitForUgcTextureLoads(bool OENELICLIHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x7372570", Offset = "0x7370B70", VA = "0x187372570")]
		public void SetUgcTextureParameters(IKKEFGFKHCN FJJOKDBOKAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x73731E0", Offset = "0x73717E0", VA = "0x1873731E0")]
		public PlayerAvatarDisplayBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x736CD30", Offset = "0x736B330", VA = "0x18736CD30")]
		[CompilerGenerated]
		private void IDMIMELHMAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x736F680", Offset = "0x736DC80", VA = "0x18736F680")]
		[CompilerGenerated]
		private void PLENBNPJFAH(KNJLNBBJAHG AKHBEIJLAGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x736D7D0", Offset = "0x736BDD0", VA = "0x18736D7D0")]
		[CompilerGenerated]
		private void KFOAFMNHJHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x736CB00", Offset = "0x736B100", VA = "0x18736CB00")]
		[CompilerGenerated]
		private void HOGDBGJCMCB(KNJLNBBJAHG AKHBEIJLAGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x736CFC0", Offset = "0x736B5C0", VA = "0x18736CFC0")]
		[CompilerGenerated]
		private void IJGGFEENFEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x7368520", Offset = "0x7366B20", VA = "0x187368520")]
		[CompilerGenerated]
		private void BHEAAJGELPI(KNJLNBBJAHG AKHBEIJLAGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x736D520", Offset = "0x736BB20", VA = "0x18736D520")]
		[CompilerGenerated]
		private void KABOEANFKHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x736E340", Offset = "0x736C940", VA = "0x18736E340")]
		[CompilerGenerated]
		private void MHJGBKPLIKB(KNJLNBBJAHG AKHBEIJLAGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x7367610", Offset = "0x7365C10", VA = "0x187367610")]
		[CompilerGenerated]
		private void AHGCKBOFJFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x736E6B0", Offset = "0x736CCB0", VA = "0x18736E6B0")]
		[CompilerGenerated]
		private void NDAMJNBKDKK(KNJLNBBJAHG AKHBEIJLAGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x736D260", Offset = "0x736B860", VA = "0x18736D260")]
		[CompilerGenerated]
		private void JACKELNOEAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x736B930", Offset = "0x7369F30", VA = "0x18736B930")]
		[CompilerGenerated]
		private void FBHFJJMFDGK(KNJLNBBJAHG AKHBEIJLAGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x736F5A0", Offset = "0x736DBA0", VA = "0x18736F5A0")]
		[CompilerGenerated]
		internal static bool PJDCOBKHPHI(Transform OJFPEIKDIBB, IEnumerable<SkinnedMeshRenderer> IEJIBIKPCAM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x736C410", Offset = "0x736AA10", VA = "0x18736C410")]
		[CompilerGenerated]
		private void GDIBGEAJIJK(KNJLNBBJAHG AKHBEIJLAGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x736E4F0", Offset = "0x736CAF0", VA = "0x18736E4F0")]
		[CompilerGenerated]
		private void MMFAOPBDCDO(KNJLNBBJAHG AKHBEIJLAGO)
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
			[Cpp2IlInjected.Token(Token = "0x4000451")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000452")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000453")]
			public PHGEAGLPDDM avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000454")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000455")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000388")]
			[Cpp2IlInjected.Address(RVA = "0x737DB20", Offset = "0x737C120", VA = "0x18737DB20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000389")]
			[Cpp2IlInjected.Address(RVA = "0x737DDB0", Offset = "0x737C3B0", VA = "0x18737DDB0", Slot = "5")]
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
			public int eyeSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400045A")]
			public int eyeBrowSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400045B")]
			public int noseSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x400045C")]
			public int mouthSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400045D")]
			public PKOOKMMPLDP avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400045E")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600038A")]
			[Cpp2IlInjected.Address(RVA = "0x7377940", Offset = "0x7375F40", VA = "0x187377940", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600038B")]
			[Cpp2IlInjected.Address(RVA = "0x7377B10", Offset = "0x7376110", VA = "0x187377B10", Slot = "5")]
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
			public FaceFeatureType featureType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000463")]
			public int selectionIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000464")]
			public PKOOKMMPLDP avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000465")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600038C")]
			[Cpp2IlInjected.Address(RVA = "0x7375480", Offset = "0x7373A80", VA = "0x187375480", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600038D")]
			[Cpp2IlInjected.Address(RVA = "0x7375620", Offset = "0x7373C20", VA = "0x187375620", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000466")]
			public PHGEAGLPDDM avatarData;
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private struct JCNMFENPGAO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000467")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000468")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000469")]
			public PHGEAGLPDDM avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400046A")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400046B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600038E")]
			[Cpp2IlInjected.Address(RVA = "0x7378E90", Offset = "0x7377490", VA = "0x187378E90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600038F")]
			[Cpp2IlInjected.Address(RVA = "0x73793C0", Offset = "0x73779C0", VA = "0x1873793C0", Slot = "5")]
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
			public PKOOKMMPLDP avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000470")]
			private TaskAwaiter<JCJBPDFIOHA> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000390")]
			[Cpp2IlInjected.Address(RVA = "0x737D360", Offset = "0x737B960", VA = "0x18737D360", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000391")]
			[Cpp2IlInjected.Address(RVA = "0x737D780", Offset = "0x737BD80", VA = "0x18737D780", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000471")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000472")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000473")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000474")]
			public PKOOKMMPLDP avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000475")]
			private FaceStyleSet <styleSet>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000476")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000392")]
			[Cpp2IlInjected.Address(RVA = "0x737DE10", Offset = "0x737C410", VA = "0x18737DE10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0x737E2D0", Offset = "0x737C8D0", VA = "0x18737E2D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		protected const float GAIBFLDFBCB = 0.5f;

		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		protected const int MAOJDMAEAFG = 5;

		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public static readonly int IdleID;

		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public static readonly int SmileID;

		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public static readonly int HugeSmileID;

		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public static readonly int ScoreID;

		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		public static readonly int SadID;

		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public static readonly int DisgustID;

		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public static readonly int HitID;

		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public static readonly int ConcentrateID;

		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public static readonly int KissID;

		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public static readonly int TalkingID;

		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public static readonly int MuteID;

		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public static readonly int AFKID;

		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public static readonly int HappyID;

		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public static readonly int EmoteFlatID;

		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public static readonly int EmoteHappyID;

		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public static readonly int EmoteSadID;

		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public static readonly int EmoteLoveID;

		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public static readonly int EmoteAngryID;

		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public static readonly int EmoteLaughID;

		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public static readonly int EmoteTongueOutID;

		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public static readonly int EmoteGrimacingID;

		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public static readonly int EmoteWinkID;

		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public static readonly int EmoteShockedID;

		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public static readonly int EmoteNauseatedID;

		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public static readonly int EmoteSmileSweatID;

		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public static readonly int EmoteSleepingID;

		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public static readonly int EmoteThinkingID;

		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public static readonly int EmoteSmirkID;

		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public static readonly int EmoteSmileID;

		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		protected static readonly Dictionary<BCOAPANBCBE.AHFGMPCCCPM, int> IJKIGAOCIGL;

		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		[CanBeNull]
		protected static IEnumerable<FaceFeatureType> PKFHMEDHDIB;

		[Cpp2IlInjected.Token(Token = "0x4000400")]
		protected static readonly int IBFGCGCFPBP;

		[Cpp2IlInjected.Token(Token = "0x4000401")]
		protected static readonly int IGPCGFGGPPE;

		[Cpp2IlInjected.Token(Token = "0x4000402")]
		protected static readonly int AGFCBCFADAI;

		[Cpp2IlInjected.Token(Token = "0x4000403")]
		protected static readonly int KKHHFBGELCM;

		[Cpp2IlInjected.Token(Token = "0x4000404")]
		protected static readonly int AIJNMDMEGKG;

		[Cpp2IlInjected.Token(Token = "0x4000405")]
		protected static readonly int DMOAGAGMAPJ;

		[Cpp2IlInjected.Token(Token = "0x4000406")]
		protected static readonly int IDHKHCAGJBL;

		[Cpp2IlInjected.Token(Token = "0x4000407")]
		protected static readonly int MEPJFDNIMPB;

		[Cpp2IlInjected.Token(Token = "0x4000408")]
		protected static Vector2 OPIDIKAHHGI;

		[Cpp2IlInjected.Token(Token = "0x4000409")]
		protected static Vector2 KMLGDBGGKAB;

		[Cpp2IlInjected.Token(Token = "0x400040A")]
		protected static Vector2 DPBODDCJCKD;

		[Cpp2IlInjected.Token(Token = "0x400040B")]
		protected static Vector2 GHNLFDMFKCH;

		[Cpp2IlInjected.Token(Token = "0x400040C")]
		protected static Vector2 LCGFIACGKAN;

		[Cpp2IlInjected.Token(Token = "0x400040D")]
		protected static Vector2 DNBJOIFEPEA;

		[Cpp2IlInjected.Token(Token = "0x400040E")]
		protected static Vector2 NBGEEMDLFMG;

		[Cpp2IlInjected.Token(Token = "0x400040F")]
		protected static Vector2 EEBADFNPJIF;

		[Cpp2IlInjected.Token(Token = "0x4000410")]
		protected static Vector2 IIDJMBJDPGC;

		[Cpp2IlInjected.Token(Token = "0x4000411")]
		protected static Vector2 HGIJHPAFBFJ;

		[Cpp2IlInjected.Token(Token = "0x4000412")]
		protected static Vector2 AJLFHEJIAHF;

		[Cpp2IlInjected.Token(Token = "0x4000413")]
		protected static Vector2 NEDJAFKGFJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		[ALEFAIIJNEI(KCNGGJNCENB.Self, false, false, false)]
		[SerializeField]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		[SerializeField]
		[Header("Rendering")]
		public FaceStyleSet faceStyleSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		[SerializeField]
		protected Renderer faceRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		[SerializeField]
		protected float jitterFPS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		[SerializeField]
		[Header("Emotes")]
		public Renderer[] emoteEffectRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		[Header("Modern Avatar Facial Features")]
		[FormerlySerializedAs("fullBodyFaceStyleSet")]
		[SerializeField]
		public FaceStyleSet modernBodyFaceStyleSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		private PKOOKMMPLDP FMFHJPKDHPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		private FaceStyleSet JKOGIGIPIGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		[SerializeField]
		protected bool debugEyeJitterInEditor;

		[Cpp2IlInjected.Token(Token = "0x400041D")]
		protected const int LFAAKLBAMEB = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		protected int CIALEKGBMME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		protected int HCOFPIFPNDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		protected int PLBFBDJADCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		protected int BKCNPAGGBDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		protected Vector2 KKOPDFHOHFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		protected float DCKFENLCPAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		protected Vector2 KGMANAKAPEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		protected float KMNFAGBPPDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		protected Vector2 PFPIELJCBEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		protected float PKLDNLECFPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		protected Vector2 AEHAJBLNCIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		protected float IFOMOCEHLGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		protected List<SelectableFaceOption> OMEKOMCKFLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		protected List<SelectableFaceOption> DHLNKHAMHKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		protected List<SelectableFaceOption> JBAKPMJBJFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		protected List<SelectableFaceOption> NDPJIFPFDGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		protected Coroutine JPPAHFBBDMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		protected int? NCFLMILHKKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		protected int KOAAOOGGGKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		protected int COAEBLGAJNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		protected int CBEFCPHNIMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		protected int MDNDPLDNJEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		protected int CJKKOAAFKGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		protected int NOGGIMHDECG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		protected Sprite EKGPAAOCPAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		protected Sprite KMMDBFBKMPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		protected Sprite NIINKNAEBMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		protected Sprite KHGBBJMMFDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		protected bool LDKJGBFHFKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		protected string LBCFNOPDNDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		protected string PPADBNMMODO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		protected string DLEMFHHKHHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		protected string MGBIIPNPIPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		[ReadOnlyField]
		public Sprite eyeSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		[ReadOnlyField]
		public Sprite leftEyeOnlySprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		[ReadOnlyField]
		public Sprite rightEyeOnlySprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public Color leftEyeColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public Color leftEyeGleamColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public Color rightEyeColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public Color rightEyeGleamColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		[ReadOnlyField]
		public Sprite mouthSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		protected AvatarConfiguration BFMGDLDGOKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		protected JCJBPDFIOHA PNIPJOANAPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		private readonly List<Material> IMMNOELIFLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		protected ANAHCJOGKFH JAIKFIODDHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		protected Dictionary<string, int> GLMELDMFGEA;

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		public FaceStyleSet PNFJAMBMPBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x7384070", Offset = "0x7382670", VA = "0x187384070")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public bool KOOLCCHMOJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0xA27AC0", Offset = "0xA260C0", VA = "0x180A27AC0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0x12BF2F0", Offset = "0x12BD8F0", VA = "0x1812BF2F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		protected virtual bool BGPDLKFPHKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		protected virtual bool JKLLANMPCAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x96C540", Offset = "0x96AB40", VA = "0x18096C540", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		protected int KBMFHPMJGLO
		{
			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0x7380700", Offset = "0x737ED00", VA = "0x187380700")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public Renderer KDJCCOHJKGF
		{
			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x9529E0", Offset = "0x950FE0", VA = "0x1809529E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public bool DDCNEJOLHGH
		{
			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x12C4D20", Offset = "0x12C3320", VA = "0x1812C4D20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0x12C5030", Offset = "0x12C3630", VA = "0x1812C5030")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public Renderer[] JKLHKJKLCGG
		{
			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x952DD0", Offset = "0x9513D0", VA = "0x180952DD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public bool EANFPCLCALE
		{
			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0x73840B0", Offset = "0x73826B0", VA = "0x1873840B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0x7384270", Offset = "0x7382870", VA = "0x187384270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		protected int JFHLEBLJIHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x73810F0", Offset = "0x737F6F0", VA = "0x1873810F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		protected int FGJNKMJMPFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x737FF00", Offset = "0x737E500", VA = "0x18737FF00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public float CPDMPGIHPBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x7384090", Offset = "0x7382690", VA = "0x187384090")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0x7384250", Offset = "0x7382850", VA = "0x187384250")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public JGOJAJEODNM MJHKIHENJIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0xABCEE0", Offset = "0xABB4E0", VA = "0x180ABCEE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0xA30C00", Offset = "0xA2F200", VA = "0x180A30C00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		public JCJBPDFIOHA FJJPIOPJPCJ
		{
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0xABD300", Offset = "0xABB900", VA = "0x180ABD300")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x73841D0", Offset = "0x73827D0", VA = "0x1873841D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public NoseFaceOption NLOOKDPHIOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0xA26AA0", Offset = "0xA250A0", VA = "0x180A26AA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0x9B8EB0", Offset = "0x9B74B0", VA = "0x1809B8EB0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		protected ANAHCJOGKFH LLDPFCIIMIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0x7380830", Offset = "0x737EE30", VA = "0x187380830")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action AEEEEOOMLCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x7383FC0", Offset = "0x73825C0", VA = "0x187383FC0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0x7384120", Offset = "0x7382720", VA = "0x187384120")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x73811D0", Offset = "0x737F7D0", VA = "0x1873811D0")]
		public void LocalPlayEmote(BCOAPANBCBE.AHFGMPCCCPM HKHPHIHDFNO, float JJAFHIAMAAF = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x73805E0", Offset = "0x737EBE0", VA = "0x1873805E0")]
		public bool IsEmotePlaying(BCOAPANBCBE.AHFGMPCCCPM HKHPHIHDFNO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x7382020", Offset = "0x7380620", VA = "0x187382020")]
		public void SetIdleHappy(bool IEPOOEEAEDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x7381150", Offset = "0x737F750", VA = "0x187381150")]
		protected void KJNLMDLMDAP(bool MIAODPIBFGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x737E330", Offset = "0x737C930", VA = "0x18737E330")]
		protected void AHEABNLCCAG(bool HELMHCNHIKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x737EDE0", Offset = "0x737D3E0", VA = "0x18737EDE0")]
		protected void EPOLAPJNIGO(OBJHNMCDGDL DBDEIKJCEBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x737FCF0", Offset = "0x737E2F0", VA = "0x18737FCF0")]
		protected void HKBLOMONFPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x7381850", Offset = "0x737FE50", VA = "0x187381850")]
		public void PlayExpression(int JPCDKLCCAEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x737FE40", Offset = "0x737E440", VA = "0x18737FE40")]
		protected void HONHDAKIJCN(bool PCNLIOPPHCO, bool EJEMIGMMNAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x737FCB0", Offset = "0x737E2B0", VA = "0x18737FCB0")]
		public List<SelectableFaceOption> GetAvailableFeatures(FaceFeatureType EFKOOGECDHL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x7380100", Offset = "0x737E700", VA = "0x187380100")]
		public void InitializeFaceFeatureRanges(AvatarConfiguration BFMGDLDGOKJ, PKOOKMMPLDP HMKELMICGGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x7381F30", Offset = "0x7380530", VA = "0x187381F30")]
		[AsyncStateMachine(typeof(ONEIKGJMGAL))]
		public Task SetFaceSettings(PHGEAGLPDDM ALBFPGNJIFO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x7381E00", Offset = "0x7380400", VA = "0x187381E00")]
		[AsyncStateMachine(typeof(HABCCFPALLI))]
		public Task SetFaceSettings(int OOOGIGINOPD, int DHABPCBKOAL, int KONEGDNJDKO, int IBOLAKHKLGO, PKOOKMMPLDP HMKELMICGGI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x73820A0", Offset = "0x73806A0", VA = "0x1873820A0")]
		[AsyncStateMachine(typeof(ALNHEFGIJKO))]
		public Task SetSelectedFaceFeatureAndBuildFaceStyle(FaceFeatureType EFKOOGECDHL, int JJCKEDNCFKB, PKOOKMMPLDP HMKELMICGGI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x737EF80", Offset = "0x737D580", VA = "0x18737EF80")]
		protected void FDOKAJCEGOG(FaceFeatureType EFKOOGECDHL, EJPJNNNFMKK EKOKNCCJHCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x7380990", Offset = "0x737EF90", VA = "0x187380990")]
		protected void KDNLLKNFAFK(FaceFeatureType EFKOOGECDHL, int JJCKEDNCFKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x737FAD0", Offset = "0x737E0D0", VA = "0x18737FAD0")]
		public static IEnumerable<FaceFeatureType> GetAllFaceFeatureTypes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x737EC00", Offset = "0x737D200", VA = "0x18737EC00")]
		[AsyncStateMachine(typeof(JCNMFENPGAO))]
		protected Task DKHINJDMOEE(PHGEAGLPDDM ALBFPGNJIFO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x737FF60", Offset = "0x737E560", VA = "0x18737FF60")]
		protected static void IFFBHOIIFEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x737E490", Offset = "0x737CA90", VA = "0x18737E490")]
		private void AJEBOJDPJGA(bool CLGFOHGAOFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x73814E0", Offset = "0x737FAE0", VA = "0x1873814E0")]
		protected void PPKKCDFDKGO(FaceFeatureType EFKOOGECDHL, Vector2 ILINMNBKBOG, PKOOKMMPLDP HMKELMICGGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x7381870", Offset = "0x737FE70", VA = "0x187381870")]
		public void SetFaceFeatureNormalizedPositionOffset(FaceFeatureType EFKOOGECDHL, Vector2 BACDHEGGABN, PKOOKMMPLDP HMKELMICGGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x737F100", Offset = "0x737D700", VA = "0x18737F100")]
		protected void FJHKNDPHIPJ(FaceFeatureType EFKOOGECDHL, float DHIKJADGNNJ, PKOOKMMPLDP HMKELMICGGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x7381BE0", Offset = "0x73801E0", VA = "0x187381BE0")]
		public void SetFaceFeatureNormalizedScaleOffset(FaceFeatureType EFKOOGECDHL, float OIJMFADLAHH, PKOOKMMPLDP HMKELMICGGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x737FD60", Offset = "0x737E360", VA = "0x18737FD60")]
		[AsyncStateMachine(typeof(NEDPBEGPIOA))]
		protected Task HNLKFLNPLIN(PKOOKMMPLDP HMKELMICGGI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x73803D0", Offset = "0x737E9D0", VA = "0x1873803D0")]
		public void InitializeFaceFeatureStyleSet(PKOOKMMPLDP HMKELMICGGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x73808B0", Offset = "0x737EEB0", VA = "0x1873808B0")]
		protected bool KCLNGNJBOKN(string BHDEFAKNALA, [Out] int EAHKFAJBNDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x737E720", Offset = "0x737CD20", VA = "0x18737E720")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x1343E10", Offset = "0x1342410", VA = "0x181343E10", Slot = "8")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x73812D0", Offset = "0x737F8D0", VA = "0x1873812D0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x7383070", Offset = "0x7381670", VA = "0x187383070")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x737E860", Offset = "0x737CE60", VA = "0x18737E860")]
		[AsyncStateMachine(typeof(PCKGCEMPDPN))]
		public Task BuildFaceStyleAsyncIfChanged(PKOOKMMPLDP HMKELMICGGI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x73829A0", Offset = "0x7380FA0", VA = "0x1873829A0")]
		public void UpdateFaceDisplays(bool DPEALEDPIGL = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x737F280", Offset = "0x737D880", VA = "0x18737F280")]
		protected bool GCGMHOAPEKC(bool DPEALEDPIGL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x73826C0", Offset = "0x7380CC0", VA = "0x1873826C0")]
		public void UpdateFaceDisplayFeatureTextures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x73821B0", Offset = "0x73807B0", VA = "0x1873821B0")]
		public void UpdateFaceDisplayFeaturePositions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x7382BB0", Offset = "0x73811B0", VA = "0x187382BB0")]
		public void UpdateFaceJitterMultiplier()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x7382DA0", Offset = "0x73813A0", VA = "0x187382DA0")]
		public bool UpdateLegacyFaceVectors()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x737ECF0", Offset = "0x737D2F0", VA = "0x18737ECF0")]
		protected void DOMGPDHKOJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x737E950", Offset = "0x737CF50", VA = "0x18737E950")]
		private void CKDOABAJBMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x7383D60", Offset = "0x7382360", VA = "0x187383D60")]
		public PlayerFacialAnimatorBase()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x97DBB0", Offset = "0x97C1B0", VA = "0x18097DBB0", Slot = "4")]
		private bool GIDEPICAEBC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x737EE50", Offset = "0x737D450", VA = "0x18737EE50")]
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
	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public string OPDMIMOEGEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000478")]
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
		private struct FOJAMIHKIAA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004D8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004D9")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004DA")]
			public PlayerModernBodyEditorAvatarValidator <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004DB")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003C7")]
			[Cpp2IlInjected.Address(RVA = "0x7376DB0", Offset = "0x73753B0", VA = "0x187376DB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C8")]
			[Cpp2IlInjected.Address(RVA = "0xA50FB0", Offset = "0xA4F5B0", VA = "0x180A50FB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000078")]
		[CompilerGenerated]
		private struct JODPAHKAFMH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004DC")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004DD")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004DE")]
			public PlayerModernBodyEditorAvatarValidator <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004DF")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003C9")]
			[Cpp2IlInjected.Address(RVA = "0x73798D0", Offset = "0x7377ED0", VA = "0x1873798D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003CA")]
			[Cpp2IlInjected.Address(RVA = "0x7379DD0", Offset = "0x73783D0", VA = "0x187379DD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public const string IDLE_ANIM_NAME = "Idle";

		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public const string A_POSE_ANIM_NAME = "A Pose";

		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public const string ANIMATION_OVERRIDE_STATE_NAME = "Override";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public PKOOKMMPLDP avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public Color hairPrimaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public Color hairSecondaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public Color beardPrimaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public Color beardSecondaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public Color skinColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public int faceShapeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public int bodyShapeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public int hairPatternIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public int beardPatternIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public AvatarFaceShape[] faceShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public AvatarBodyShape[] bodyShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public AvatarHairPattern[] hairPatterns;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public float _avatarScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public bool enablePosing;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public int poseIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public AnimationClip animationOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		[Range(0f, 4f)]
		public float animationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public MLFKPMGCMHF useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public KOIFPCMFICK hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public BOEIPLPALDB HatAnchorRestrictions;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public bool UseHairFitMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD1")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public bool usesHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public GameObject hatPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public GameObject hairPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public GameObject earPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public GameObject eyePrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public GameObject mouthPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public GameObject neckPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public GameObject shirtPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public GameObject beltPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public GameObject shoulderPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public GameObject rightHandPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public GameObject leftHandPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public GameObject legsPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public GameObject feetPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public long baseSkinCullingMask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		[SerializeField]
		[ALEFAIIJNEI(KCNGGJNCENB.Self, false, false, false)]
		public PlayerAvatarDisplayBase _avatarDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		private DDFBFAJGEGF OFAGHFPPCNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		[ALEFAIIJNEI(KCNGGJNCENB.Self, false, false, false)]
		[SerializeField]
		public PlayerFacialAnimatorBase facialAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public AnimationClip animationClipToOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		private AnimatorOverrideController OPJKFGNMPMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		private List<KeyValuePair<AnimationClip, AnimationClip>> NCHFKHFCPNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public Transform headIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public Transform leftHandIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public Transform rightHandIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		[Range(0f, 2f)]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public int rightHandGestureStateIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		[Range(0f, 1f)]
		public float rightHandCurl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public int leftHandGestureStateIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		[Range(0f, 1f)]
		public float leftHandCurl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public int eyeBrowSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public int eyeSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public int noseSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public int mouthSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public float eyeBrowPositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public float eyeBrowPositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public float eyeBrowScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public float eyePositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public float eyePositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public float eyeScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D4")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public float nosePositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public float noseScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1DC")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public float mouthPositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public float mouthPositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E4")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public float mouthScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public float hatNormalizedPositionX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EC")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public float hatNormalizedPositionY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public Vector3 hatHemispherePositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1FC")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public Vector3 hatHemisphereRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public int facialExpressionIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20C")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		[Range(0f, 1f)]
		public float normalizedTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public readonly MOCNMPCJEFJ[] FacialExpressions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public readonly string[] BodyPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public readonly (string, BKMINCPGJKF)[] HandPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public bool hideLeftWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x229")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public bool hideRightWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22A")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		protected bool LAMMAOBONGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22C")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		protected Guid FDGBFEGPCMF;

		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		protected static Guid KHJIFHCAIJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		private AHBNJGDEGOO CLLKMBMJEFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		private JGOJAJEODNM GMIJCCPBOIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		private ODFMHACHCFM PKJKEKAGLJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		private ODFMHACHCFM CLFKCPDLIKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		private AdditionalHatData MCHOHKJPFNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		private readonly Dictionary<GameObject, LBKMHAIBEMP> KFGINMFPHBJ;

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public static Func<AONNKEALKEA> LLAPFKCOLHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000395")]
			[Cpp2IlInjected.Address(RVA = "0x7389330", Offset = "0x7387930", VA = "0x187389330")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000396")]
			[Cpp2IlInjected.Address(RVA = "0x7389970", Offset = "0x7387F70", VA = "0x187389970")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public bool MFOIJFPIBNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000397")]
			[Cpp2IlInjected.Address(RVA = "0x7389490", Offset = "0x7387A90", VA = "0x187389490")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public bool HLJIHMLMLKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0x7389380", Offset = "0x7387980", VA = "0x187389380")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public PlayerAvatarDisplayBase HEGOBJEGDKO
		{
			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0x9C1130", Offset = "0x9BF730", VA = "0x1809C1130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		protected static Guid CJDPAOLNINN
		{
			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0x73843C0", Offset = "0x73829C0", VA = "0x1873843C0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public (GameObject, OBJHNMCDGDL)[] GCHABNKDIAC
		{
			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x73895A0", Offset = "0x7387BA0", VA = "0x1873895A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x7387040", Offset = "0x7385640", VA = "0x187387040")]
		[ContextMenu("Refresh Avatar")]
		private void RebuildTestAvatarContextMenu()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x73850F0", Offset = "0x73836F0", VA = "0x1873850F0")]
		private IEnumerable<GameObject> DCHBIHHKGDN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x7387530", Offset = "0x7385B30", VA = "0x187387530")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x73861F0", Offset = "0x73847F0", VA = "0x1873861F0")]
		private void KDGCCNBOEIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x1082C10", Offset = "0x1081210", VA = "0x181082C10")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x7385AF0", Offset = "0x73840F0", VA = "0x187385AF0")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x7387540", Offset = "0x7385B40", VA = "0x187387540")]
		public void Teardown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x7387330", Offset = "0x7385930", VA = "0x187387330")]
		public void ShowPose(AnimationClip HGFICPLCPIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x7387500", Offset = "0x7385B00", VA = "0x187387500")]
		public void ShowPose(string NMBMLLGENAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x7387190", Offset = "0x7385790", VA = "0x187387190")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x7387050", Offset = "0x7385650", VA = "0x187387050")]
		public void ResetHandPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x7388010", Offset = "0x7386610", VA = "0x187388010")]
		public void UpdateHandAnimation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x7387E60", Offset = "0x7386460", VA = "0x187387E60")]
		public void UpdateFaceAndBodyShapes(bool KPBEAEKPEMK = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x7388410", Offset = "0x7386A10", VA = "0x187388410")]
		public void UpdateNoseShape(EHLDDELHBFB DIKOIBEAEJB, bool KPBEAEKPEMK = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x73883E0", Offset = "0x73869E0", VA = "0x1873883E0")]
		public void UpdateLODOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x7386D30", Offset = "0x7385330", VA = "0x187386D30", Slot = "4")]
		protected virtual void PNLLALKHHFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x73867F0", Offset = "0x7384DF0", VA = "0x1873867F0", Slot = "5")]
		protected virtual void MFEAIHHGKJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x7384670", Offset = "0x7382C70", VA = "0x187384670")]
		public void ApplyHatData(AdditionalHatData APEPHNGDACL, bool IGBOBDIMGID = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x73844B0", Offset = "0x7382AB0", VA = "0x1873844B0")]
		public void ApplyHatAdjustmentsToHatAnchorParams()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x73849D0", Offset = "0x7382FD0", VA = "0x1873849D0")]
		public void ApplyHatUVOverride(Vector2 ALKJAKPMJBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x73848F0", Offset = "0x7382EF0", VA = "0x1873848F0")]
		public void ApplyHatPositionAdjustment(Vector3 GCLMENIDEGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x7384960", Offset = "0x7382F60", VA = "0x187384960")]
		public void ApplyHatRotationAdjustment(Vector3 FGMOOGCBIJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x7384A40", Offset = "0x7383040", VA = "0x187384A40")]
		public DKLBEPIMGOL BuildAvatarItemSelection(GameObject PIDIJCCONEO, PKOOKMMPLDP KJBFEELDPAB, OBJHNMCDGDL OGNNAFLGGHA)
		{
			return default(DKLBEPIMGOL);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x7384AE0", Offset = "0x73830E0", VA = "0x187384AE0")]
		public void BuildAvatar(bool KPBEAEKPEMK = false, bool IGBOBDIMGID = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x73878A0", Offset = "0x7385EA0", VA = "0x1873878A0")]
		public void UpdateColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x73845F0", Offset = "0x7382BF0", VA = "0x1873845F0")]
		public void ApplyHatAnchor()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x7388230", Offset = "0x7386830", VA = "0x187388230")]
		public void UpdateHatAnchor(bool IGBOBDIMGID = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x7387F60", Offset = "0x7386560", VA = "0x187387F60")]
		[AsyncStateMachine(typeof(FOJAMIHKIAA))]
		public void UpdateFaceFeatures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x7385610", Offset = "0x7383C10", VA = "0x187385610")]
		[AsyncStateMachine(typeof(JODPAHKAFMH))]
		private Task FPKFEJGALAL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x7386A60", Offset = "0x7385060", VA = "0x187386A60")]
		private void MIGEPAHCFBF(FaceFeatureType KGLDHIDPHPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x7385580", Offset = "0x7383B80", VA = "0x187385580")]
		private void FLPGOLBHFJH(FaceFeatureType KGLDHIDPHPP, [Out] float OLLMNLIBPHC, [Out] float NLNEKEMHMBN, [Out] float JJCKONKIIAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x7387D20", Offset = "0x7386320", VA = "0x187387D20")]
		public void UpdateEmote()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x73880C0", Offset = "0x73866C0", VA = "0x1873880C0")]
		public void UpdateHandPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x73862D0", Offset = "0x73848D0", VA = "0x1873862D0")]
		private void LABOFNPDNFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60")]
		private void OGJLPIBEODD(LBKMHAIBEMP HBNIICBFICF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60")]
		private void MCDFBLLOEPI(LBKMHAIBEMP HBNIICBFICF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x73856E0", Offset = "0x7383CE0", VA = "0x1873856E0")]
		private void HDEGADBHPJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x73884A0", Offset = "0x7386AA0", VA = "0x1873884A0")]
		public PlayerModernBodyEditorAvatarValidator()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x7385A40", Offset = "0x7384040", VA = "0x187385A40")]
		[CompilerGenerated]
		private DKLBEPIMGOL IPCCAPDJMAA((GameObject, OBJHNMCDGDL) NPILLJODNJH)
		{
			return default(DKLBEPIMGOL);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class SkinnedMeshBonesInspector : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		[SerializeField]
		[ALEFAIIJNEI(KCNGGJNCENB.Self, false, false, false)]
		private SkinnedMeshRenderer skinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		[SerializeField]
		private int BoneWeightsDisplayStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		[SerializeField]
		private int BoneWeightsDisplayAmount;

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x951A50", Offset = "0x950050", VA = "0x180951A50")]
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
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public IEnumerable<OutfitType> otherOutfitTypes;

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public JMHJDLAJJOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x7379850", Offset = "0x7377E50", VA = "0x187379850")]
		internal bool POHIIMCBOBL(OutfitType outfitType)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	private LBKMHAIBEMP PFFFJAKBOKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	private OBJHNMCDGDL JFACDOPDKFB;

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public LBKMHAIBEMP HCAGBBDPLIN
	{
		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public OBJHNMCDGDL IDLHGNGCIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0xBD5480", Offset = "0xBD3A80", VA = "0x180BD5480")]
		get
		{
			return default(OBJHNMCDGDL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public string BAFPMMNNIMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x7376780", Offset = "0x7374D80", VA = "0x187376780")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool FDDABPHKDNI
	{
		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x7376940", Offset = "0x7374F40", VA = "0x187376940")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public bool HHKBBIPLOGC
	{
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x7376990", Offset = "0x7374F90", VA = "0x187376990")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x15917E0", Offset = "0x158FDE0", VA = "0x1815917E0")]
	public DKLBEPIMGOL(LBKMHAIBEMP HBNIICBFICF, OBJHNMCDGDL DBDEIKJCEBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x7376870", Offset = "0x7374E70", VA = "0x187376870")]
	public bool MKIANMGHHGB(OutfitType FOJNKLEFICC, OBJHNMCDGDL LHJANIHNMOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x7376320", Offset = "0x7374920", VA = "0x187376320")]
	public bool AIFJNMEPIAN(OutfitType FOJNKLEFICC, OBJHNMCDGDL LHJANIHNMOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x7376590", Offset = "0x7374B90", VA = "0x187376590")]
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
