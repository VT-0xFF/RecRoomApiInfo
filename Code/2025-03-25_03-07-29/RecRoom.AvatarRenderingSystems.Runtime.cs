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
	public class LogRegistrationIndex : PNJEOLJBAIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7654400", Offset = "0x7653800", VA = "0x187654400", Slot = "4")]
		public override void ELBDPICAHPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
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
			[Cpp2IlInjected.Address(RVA = "0x993430", Offset = "0x992830", VA = "0x180993430", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override string AssetGUID
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x76613D0", Offset = "0x76607D0", VA = "0x1876613D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7661360", Offset = "0x7660760", VA = "0x187661360", Slot = "17")]
		public override bool RuntimeKeyIsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7661390", Offset = "0x7660790", VA = "0x187661390")]
		public RecNetCDNAssetReference(RecNetCDNKey MCBJECJLDOM)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class RecNetCDNKey
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public enum KFJHDAJNOOE : byte
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
			[Cpp2IlInjected.Address(RVA = "0x991DC0", Offset = "0x9911C0", VA = "0x180991DC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x991E00", Offset = "0x991200", VA = "0x180991E00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string UniqueItemIdentifier
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x9933D0", Offset = "0x9927D0", VA = "0x1809933D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string CacheHash
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x991DE0", Offset = "0x9911E0", VA = "0x180991DE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x991DF0", Offset = "0x9911F0", VA = "0x180991DF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RecNetCDNKey Dependency
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x993260", Offset = "0x992660", VA = "0x180993260")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x99BAC0", Offset = "0x99AEC0", VA = "0x18099BAC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool AttemptPrecacheLookup
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x9BF180", Offset = "0x9BE580", VA = "0x1809BF180")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x9BEF00", Offset = "0x9BE300", VA = "0x1809BEF00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public KFJHDAJNOOE PathHint
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xCFD050", Offset = "0xCFC450", VA = "0x180CFD050")]
			[CompilerGenerated]
			get
			{
				return default(KFJHDAJNOOE);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x11F7970", Offset = "0x11F6D70", VA = "0x1811F7970")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string ItemPath
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x76614E0", Offset = "0x76608E0", VA = "0x1876614E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7661460", Offset = "0x7660860", VA = "0x187661460")]
		public static RecNetCDNKey OCLBLOOLOCI(string IHIDAMMPOEN, KFJHDAJNOOE DIBGHFGABBA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7661410", Offset = "0x7660810", VA = "0x187661410")]
		public void EHPFJEMPAFL(string DLHGIOCANHI, string PNBFDJGGCJP, bool EAGHGJAHGBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public RecNetCDNKey()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[NGHELBGCMPC]
public class LPEHBKIOIKC : LENKFLPFNPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	protected readonly List<Mesh> PNNHNHLJGBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	protected readonly List<byte[]> AGBPFLEFLKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	protected readonly List<Matrix4x4> EPPLPMCODIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	protected readonly List<bool> BOLFJEJKMLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	protected readonly List<long> KIIMIJEBGBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	protected readonly List<bool> ENJNKEDDHPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	protected readonly List<int> GHMGACHBBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	protected Allocator EBPFOHLCMJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected JNGKKHAFNLF JHNHNDFGDMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected byte KHFEHPCGEAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected IList<int> LJABHAPCLGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected IList<int> EOPKKCNIMBN;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7653C90", Offset = "0x7653090", VA = "0x187653C90", Slot = "4")]
	public void GKIFFLFABEH(Mesh CNCBOAAEMAB, Matrix4x4 MHENGEAEJHL, byte[] JKBPHIPEBKM, bool MNPLHPGKJOF = false, LDBNJIFCKAL.HECKIELMCBP GHJMLFMOOMI = (LDBNJIFCKAL.HECKIELMCBP)0L, int IMMNIBIAAHO = -1, bool BACJLOEEGNA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7653F10", Offset = "0x7653310", VA = "0x187653F10", Slot = "5")]
	public void HMLOPKFCOKJ(Allocator LENIJMBFHJK, JNGKKHAFNLF NKAEGFFOLJG, byte EIPJJNGFECD, [Optional] IList<int> AJJFFBOJGHK, [Optional] IList<int> OMCFEBBMLDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7653F50", Offset = "0x7653350", VA = "0x187653F50")]
	private static void JJNPCMFKMMG(Mesh CNCBOAAEMAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x76541B0", Offset = "0x76535B0", VA = "0x1876541B0")]
	public LPEHBKIOIKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[NGHELBGCMPC]
public struct HDHIGEBPIMO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	[ReadOnly]
	public KBIBDOLFHDL HCMOMCFCBOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[ReadOnly]
	public int DIKEKINGDBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public CKHPIEFJFIG KMLMGAMIHCM;

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x764FE70", Offset = "0x764F270", VA = "0x18764FE70", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[NGHELBGCMPC]
[NativeContainer]
public struct CKHPIEFJFIG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct DPBICDJIJCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Vector3 PMNDBIDKHCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public Vector3 HAKFDJFOEPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public Vector4 ANPPJJPEOGE;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct IMEKHNHCPNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public float CAJEGKPGBKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public float ELGODGIGMPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public float EGEBCECHDFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public float BKMKBFBCMMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public byte FKFOJKPFEKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public byte EDDHLJBHFMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public byte OMHHCKFGENN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public byte MADCNICEMPD;
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct NNFAPPIHBAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public half CAJEGKPGBKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public half ELGODGIGMPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public half EGEBCECHDFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public half BKMKBFBCMMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public byte FKFOJKPFEKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public byte EDDHLJBHFMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public byte OMHHCKFGENN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public byte MADCNICEMPD;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct DKCNOPFHNJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public half4 CKANMCILFBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public half2 DEMMEMNGNEI;
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct POEEDMKDNFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public half4 CKANMCILFBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public half2 DEMMEMNGNEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public half2 PFENGIMCGGL;
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct BHMMBGDAMEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public half4 CKANMCILFBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public half2 DEMMEMNGNEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public half2 PFENGIMCGGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public half2 JHMJFOGKPLH;
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct JFPCJDIKLMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public half4 CKANMCILFBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public half2 DEMMEMNGNEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public half2 PFENGIMCGGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public half2 JHMJFOGKPLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public half2 IFPOONMEPDJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct FJGBOOJICDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public float CAJEGKPGBKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public float ELGODGIGMPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public float EGEBCECHDFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public float BKMKBFBCMMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int FKFOJKPFEKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int EDDHLJBHFMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int OMHHCKFGENN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int MADCNICEMPD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct ADDDEOOALNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Color CKANMCILFBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Vector2 DEMMEMNGNEI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct LIFMNNMBLEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Color CKANMCILFBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Vector2 DEMMEMNGNEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Vector2 PFENGIMCGGL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct ADNODJIMLEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Color CKANMCILFBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Vector2 DEMMEMNGNEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Vector2 PFENGIMCGGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Vector2 JHMJFOGKPLH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct MNGCLPMDPEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Color CKANMCILFBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Vector2 DEMMEMNGNEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Vector2 PFENGIMCGGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Vector2 JHMJFOGKPLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Vector2 IFPOONMEPDJ;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private bool JFKJGCGGFJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<DPBICDJIJCM> BPELDJKDCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<DKCNOPFHNJG> OCEPFIKPIDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<POEEDMKDNFP> GKGPLIJPCKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<BHMMBGDAMEA> GENBECKFAFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<JFPCJDIKLMI> BEMCMJNOGBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<NNFAPPIHBAN> LIMFGKKKHHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<IMEKHNHCPNC> DIHMABCKCFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NativeArray<ADDDEOOALNA> IOFKCFEEHFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NativeArray<LIFMNNMBLEA> MFMGPPPNHDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public NativeArray<ADNODJIMLEC> AHOMHBNNAFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public NativeArray<MNGCLPMDPEP> DDDGGJEHDNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public NativeArray<FJGBOOJICDI> KADKIBCHIJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public NativeArray<int> GAHABMNGKJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public NativeArray<int> AGIJAIDKLGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private NativeArray<int> EDOCPPOEBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NativeArray<int> JGBGGPHLGII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<int> BLHFFPIJJDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public NativeArray<int> EPNJDHGBHPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public NativeArray<int> MDHHOCOPBKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public NativeArray<BoneWeight> COJMFNFEADL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeArray<int> NFHKMOGHIBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private bool CKBEIPKJJFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x159")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private bool HMNABFCOFHI;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int BACPJGLNGAB
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x764CD80", Offset = "0x764C180", VA = "0x18764CD80")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x764CD90", Offset = "0x764C190", VA = "0x18764CD90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int HGJFFIFCMBN
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x764CD70", Offset = "0x764C170", VA = "0x18764CD70")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x764F0A0", Offset = "0x764E4A0", VA = "0x18764F0A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int ENBFOOMBABB
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x764EBF0", Offset = "0x764DFF0", VA = "0x18764EBF0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x764CD60", Offset = "0x764C160", VA = "0x18764CD60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int MIJPMHOKKIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x764D840", Offset = "0x764CC40", VA = "0x18764D840")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x764F0B0", Offset = "0x764E4B0", VA = "0x18764F0B0")]
	public CKHPIEFJFIG(int CLMLOOPKKFK, int OBMELHCGDFF, int CGCBHFJHIFB, int OLCOGNMFEID, Allocator LENIJMBFHJK, int BFEFHLMBEDJ, AMKEDLBJPID JFFHKEDLLKE, bool CKBEIPKJJFF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x764F010", Offset = "0x764E410", VA = "0x18764F010")]
	public void MIMDIMCJICO(int KDCAMOIGIMA, Vector3 AEPDMGGJHKC, Vector3 OCKNOGIDPFP, Vector4 CFOOONLCHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x764D1A0", Offset = "0x764C5A0", VA = "0x18764D1A0")]
	public void CKGINFMDJNK(int KDCAMOIGIMA, BoneWeight NBHJOBGKHAK, NativeSlice<byte> JKBPHIPEBKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x764D980", Offset = "0x764CD80", VA = "0x18764D980")]
	public Color FLCHAGDLBNA(int KDCAMOIGIMA)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x764CDA0", Offset = "0x764C1A0", VA = "0x18764CDA0")]
	public void CHGBPNLKMLJ(int KDCAMOIGIMA, Color AMLIHKJCCAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x764EC60", Offset = "0x764E060", VA = "0x18764EC60")]
	public void MBAJHFIOMNB(byte IHHHLBHFMFP, int KDCAMOIGIMA, Vector2 EGJOOBNGOMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x764D830", Offset = "0x764CC30", VA = "0x18764D830")]
	public void ECMIDELAHBB(int KDCAMOIGIMA, int CNEIBJELGAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x764EC00", Offset = "0x764E000", VA = "0x18764EC00")]
	public bool LFMGKJDCKND(int IHHHLBHFMFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x764D8B0", Offset = "0x764CCB0", VA = "0x18764D8B0")]
	public void ELDNPFJGOOF(int GNEIJJMEKIN, int NPELPNMIGOA, int GHDAIPOHNAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x764D5D0", Offset = "0x764C9D0", VA = "0x18764D5D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x764DCB0", Offset = "0x764D0B0", VA = "0x18764DCB0")]
	public Mesh GKOEDMEMMFC([Optional] string POBGIKONEEJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
[NGHELBGCMPC]
[NativeContainer]
public struct KBIBDOLFHDL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public Mesh.MeshDataArray LBABFIMFADG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public NativeArray<int> FNMIEMNFFIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public NativeArray<int> GLPGEHAFAFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public NativeArray<BoneWeight> COJMFNFEADL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private NativeArray<Matrix4x4> MLIBKIBJBNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private NativeArray<long> OOGNIMIJDJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private NativeArray<byte> NCDGJKAKGFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private NativeArray<int> OJHKOFBINMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private NativeArray<int> HOHONNDIEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public NativeArray<sbyte> JFGGMOAAOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public NativeArray<byte> BALJPGAKNBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public NativeArray<bool> BACJLOEEGNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NativeArray<int> IMMNIBIAAHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private bool CKBEIPKJJFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeArray<int> CCBEBJGPMON;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private bool HMNABFCOFHI;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int CHJDHBNJGJP
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7652050", Offset = "0x7651450", VA = "0x187652050")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int KPJDFNMILEC
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7652060", Offset = "0x7651460", VA = "0x187652060")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int DBCFNBNOIIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7651F80", Offset = "0x7651380", VA = "0x187651F80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int GDJAJFFMKOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7651DC0", Offset = "0x76511C0", VA = "0x187651DC0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x76522C0", Offset = "0x76516C0", VA = "0x1876522C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int BACPJGLNGAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7651CD0", Offset = "0x76510D0", VA = "0x187651CD0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7651DB0", Offset = "0x76511B0", VA = "0x187651DB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int ANGJLMICBIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x76522D0", Offset = "0x76516D0", VA = "0x1876522D0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x76522E0", Offset = "0x76516E0", VA = "0x1876522E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public JNGKKHAFNLF DJPONGIFIEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7651F60", Offset = "0x7651360", VA = "0x187651F60")]
		get
		{
			return default(JNGKKHAFNLF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x76522F0", Offset = "0x76516F0", VA = "0x1876522F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public byte CNMFJPCJNNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7651F50", Offset = "0x7651350", VA = "0x187651F50")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7651F70", Offset = "0x7651370", VA = "0x187651F70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public BDFBOIEEECM PPOFLIOMKNN
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7652070", Offset = "0x7651470", VA = "0x187652070")]
		get
		{
			return default(BDFBOIEEECM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7652300", Offset = "0x7651700", VA = "0x187652300")]
	public KBIBDOLFHDL(IList<Mesh> OIDGKEJEOFD, IList<Matrix4x4> AIKLKKHNHNL, IList<bool> BACJLOEEGNA, byte EIPJJNGFECD, IList<byte[]> ELKCOIOFDHL, IList<long> DNEHMDAAPNC, IList<bool> HICIPLDOHCJ, IList<int> IMMNIBIAAHO, IList<int> AJJFFBOJGHK, IList<int> PDHCPBKPKGO, Allocator LENIJMBFHJK, JNGKKHAFNLF NKAEGFFOLJG, bool CKBEIPKJJFF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7651CE0", Offset = "0x76510E0", VA = "0x187651CE0")]
	public CKHPIEFJFIG AIPKGAKLOKF(Allocator LENIJMBFHJK, AMKEDLBJPID JFFHKEDLLKE)
	{
		return default(CKHPIEFJFIG);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7651DD0", Offset = "0x76511D0", VA = "0x187651DD0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[NGHELBGCMPC]
public class KFAHJNJKNLA : LPEHBKIOIKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public bool BNEHODDIGHA;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly ProfilerMarker NKDNBJFIJNP;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7653740", Offset = "0x7652B40", VA = "0x187653740")]
	public KBIBDOLFHDL OCNLJGEKMEM()
	{
		return default(KBIBDOLFHDL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7653A40", Offset = "0x7652E40", VA = "0x187653A40")]
	public KFAHJNJKNLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct BDFBOIEEECM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public Mesh.MeshData OPDKDJKGCOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public NativeSlice<BoneWeight> COJMFNFEADL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public NativeSlice<byte> DJJEEFGGNOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public int JINHJKOHAPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public Matrix4x4 MNBOGMCEECP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public long EFGOCACDJFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public NativeSlice<byte> JKBPHIPEBKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public bool OLINMMLHLHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public int CABGDJNIOIJ;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class OOHHGFPAPOG : NGCNOPAGGEC
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class IKFJPBPEJLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public NLGEAGICHBO avatarBuildParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public OOHHGFPAPOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public KPNDCLGPJDN buildMeshPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public Action<KeyValuePair<string, FHGKGMPNNBH<Texture2D>>> <>9__19;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public IKFJPBPEJLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7651A60", Offset = "0x7650E60", VA = "0x187651A60")]
		internal bool AAILMHAKCAK(IKCNPCJGLNP item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7651AE0", Offset = "0x7650EE0", VA = "0x187651AE0")]
		internal void HNNGEOHPHAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7651B00", Offset = "0x7650F00", VA = "0x187651B00")]
		internal void JELOKDNGGHO(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7651AE0", Offset = "0x7650EE0", VA = "0x187651AE0")]
		internal void BONDPDIAFMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7651B00", Offset = "0x7650F00", VA = "0x187651B00")]
		internal void FKOCDPHLKMC(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x7651BE0", Offset = "0x7650FE0", VA = "0x187651BE0")]
		internal void LGNAHDOBHIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7651AB0", Offset = "0x7650EB0", VA = "0x187651AB0")]
		internal void BIIINOOMECO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7651C10", Offset = "0x7651010", VA = "0x187651C10")]
		internal void PBLCJNAAKCP(Dictionary<string, FHGKGMPNNBH<Texture2D>> resourceHandleDictionary)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7651B20", Offset = "0x7650F20", VA = "0x187651B20")]
		internal void KDFIPJOGAOL(KeyValuePair<string, FHGKGMPNNBH<Texture2D>> kvp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x991DE0", Offset = "0x9911E0", VA = "0x180991DE0")]
		internal KMDOHMPCNFD KDKCMDIKEHC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class FMDBFEHFPGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public int lowestPossibleLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public IKFJPBPEJLF CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public FMDBFEHFPGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x764FAE0", Offset = "0x764EEE0", VA = "0x18764FAE0")]
		internal PPJJIFPIFIE HLGCILCHEBD(int lod)
		{
			return default(PPJJIFPIFIE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class EGBLNFNOPCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public COLCOEKKCIF<Dictionary<string, FHGKGMPNNBH<Texture2D>>> ugcTextureDictionaryPromise;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public EGBLNFNOPCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x991DC0", Offset = "0x9911C0", VA = "0x180991DC0")]
		internal COLCOEKKCIF<Dictionary<string, FHGKGMPNNBH<Texture2D>>> GFKNPDPMECO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class HIKOHHAIGFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public List<KPNDCLGPJDN> innerPromises;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public HIKOHHAIGFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x7651930", Offset = "0x7650D30", VA = "0x187651930")]
		internal void CLOJPMJAGAL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class GJGLPDJKCMC : IEnumerator<OAGIBKDGOAG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private OAGIBKDGOAG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public bool shouldWait;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public OOHHGFPAPOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public List<PBIDJKKFFFO> parts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public List<KPNDCLGPJDN> innerPromises;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public bool isFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public Func<int, PPJJIFPIFIE> getLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public MCOHMGPMHLK materialPropertyBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public Material materialInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private int <lodIndex>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private OAGIBKDGOAG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x996A30", Offset = "0x995E30", VA = "0x180996A30")]
		[DebuggerHidden]
		public GJGLPDJKCMC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x764FBA0", Offset = "0x764EFA0", VA = "0x18764FBA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x764FE20", Offset = "0x764F220", VA = "0x18764FE20", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class BECOFKGCFHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public POLPJMCNLLL cancelable;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public BECOFKGCFHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0xB2D240", Offset = "0xB2C640", VA = "0x180B2D240")]
		internal void FAMGOGLOEKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0xC3AF90", Offset = "0xC3A390", VA = "0x180C3AF90")]
		internal void BBPIMFAIOBD(string err)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class OCBBJDFGMKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public long jobComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public Stopwatch stopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public SkinnedMeshRenderer lodRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public long meshComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public string meshName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public long meshCopyComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public OOHHGFPAPOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public List<Material> newUniqueMaterials;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public int frameStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public long lodBuildStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public long startCombineBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public long jobScheduled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public Action onFinally;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public OCBBJDFGMKC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class KCCGHNHLCHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public CKHPIEFJFIG defaultMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public KBIBDOLFHDL defaultAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public OCBBJDFGMKC CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public KCCGHNHLCHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x7653500", Offset = "0x7652900", VA = "0x187653500")]
		internal void BFINOPMONKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x11624A0", Offset = "0x11618A0", VA = "0x1811624A0")]
		internal void GHJBHCAJEPB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class KOHAHEHKEOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public CDGCNJLGFDN legacyMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public JINAGKEBLMN legacyAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public OCBBJDFGMKC CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public KOHAHEHKEOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7653A50", Offset = "0x7652E50", VA = "0x187653A50")]
		internal void PCINDFALOFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x115E960", Offset = "0x115DD60", VA = "0x18115E960")]
		internal void HBNFFKCICEE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class BPOPLCJLLNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public string overrideItemIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public HKLJDIPJMDE overrideBodyPart;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public BPOPLCJLLNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x764CCE0", Offset = "0x764C0E0", VA = "0x18764CCE0")]
		internal bool KPHENABNNCJ(KeyValuePair<string, IKCNPCJGLNP> entry)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly OLDENIALAEA BEAMDEPFPHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly OLDENIALAEA DPDJPIHIOFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Dictionary<KEHGEIMFGPM, float> KAPAPNLCEIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private Dictionary<BGLIFKJGBNO, float> ILAAEBKPCME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Dictionary<BKNDIMCPBGA, float> ALMGKCBOCCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private IReadOnlyDictionary<string, NLPPODAKEIC> FJMFIDHELCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Dictionary<string, NLPPODAKEIC> EILHIBJHPAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Dictionary<string, NLPPODAKEIC> OPEFENAMOJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private Dictionary<string, NLPPODAKEIC> FFFLCIELIOG;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private static float EPKAHHLPIFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private bool? ABNDICEJLBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private bool? KFCBPHEKKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private bool? FGDAKJCMKHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5E")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private bool? MKBFMHMLBJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private AvatarConfiguration HNJKBACFAOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private Transform NEBGMOBBGEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private AvatarSkinAssetItem BHJNNGIOEDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private AssetReference LCHFEGHDLEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private GameObject CKEHADGEBHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private GameObject FHMCNJBNJCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private SkinnedMeshRenderer LPDBAPKFMNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private AvatarSkinnedMeshBoneOrderRemapsData MMCHDDDPKPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private Transform[] KPAAIDFDFMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private Matrix4x4[] PCDPMBJELKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private Material IIFNFMEIOOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private Material PBIBADMLEOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private Material DDAPMBDCKAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private Shader LBJCHOJNFOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private Shader HOJLBIGBNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private Animator JHKALDDIDME;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private Renderer[] JMJJMJCJCOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private LDBNJIFCKAL.HECKIELMCBP MGAENDOKHLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private AvatarBodyPartShapesManager KMJOOCOBEJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private IReadOnlyDictionary<string, Transform> AIMKFGGHDKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private AvatarFaceShapeData.DABNAIFPMMM CHJONDACAFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private AvatarBodyShapeData.CDFJFNCHCBC DOOBIAIKHJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private OMEFKCHKIOM JAPOPJMLJEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private bool NNEMMJLAPIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10D")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private bool CIINIAFGOKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private Color JJPJMHALNKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private Color JOLAJNCHNBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private Color IAPLEHLCJEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private Color? MBHGBNBHDAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x154")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private Color? DNLDGKKDNPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private Color? FFNAKLBCNDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private Color? NDBHEEDOAPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private Texture2D HDPICHGJIIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private Texture2D IGADDKFPFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[CanBeNull]
	private IKCNPCJGLNP GIALLECBHMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private Texture NGGIMHCMALH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private Color ECBCLNCAKFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public Dictionary<Renderer, MCOHMGPMHLK> OGGGCADALNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private Dictionary<Renderer, MCOHMGPMHLK> KJBAGHGBDCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private Dictionary<string, List<KIBGBDABHCI>> MHBOGHDECHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private Dictionary<string, List<KIBGBDABHCI>> JPMBEKDMPBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly List<GCJENIKICGG> DFMJFEFCPMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly List<GCJENIKICGG> BFGEBHHFLBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly List<GCJENIKICGG> BOIAOHOPCNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly List<GCJENIKICGG> FKKDBDJFNKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private Dictionary<KIBGBDABHCI, Material> NJBKLADDKHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private Dictionary<KIBGBDABHCI, Material> BFLEGEABMKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private SkinnedMeshRenderer[] MOPDGHDGGAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private SkinnedMeshRenderer[] NBLMKPJDFGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private SkinnedMeshRenderer[] NCCNLNLJBEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private SkinnedMeshRenderer[] KMGIAJDIPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private readonly Dictionary<string, FHGKGMPNNBH<Texture2D>> JILPFMKMFNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private readonly Dictionary<string, FHGKGMPNNBH<Texture2D>> KECIIGEFGDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private BACEPNDKCHJ HPDEOHKCCHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x244")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private BACEPNDKCHJ LIPFFGDFHDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private AdditionalHatData EPIHLLPECFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private AdditionalHatData EALFEIOOHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private HairData AFIDOBIIOEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private HairData GMFLCHFFCOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private GHDNJFDBFAB DAFBOEMKCDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private bool? EDAOPBAGILM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x274")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private PositionAndRotation FOFCEEKIIGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private Transform OBHNPMEBNAM;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private Material PNPJKOEJFDM;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private Material FIDMCAKDCGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private Dictionary<string, IKCNPCJGLNP> OHMLFBIGMCA;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static readonly int KEPFELNAIKM;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static readonly int MLEGFPBPKIA;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static readonly int IABKMFEMJMN;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly int HIGEPIGMGLG;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly int HDPBFHOJLIJ;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly int KDCBCEEGACE;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly int COHBPMKKHII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private bool DEBLPBLHAJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private List<Action> ADBGPEIKIBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private HDGGCAEIEHM MHMGAFBHCJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private SkinnedMeshRenderer[] GLCNMKHGLFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private int MIGOCNBCGFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D4")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private bool POBNLMNDACC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private int HFGHNJGCHOB;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public OLDENIALAEA CMMIOGBOPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x991DC0", Offset = "0x9911C0", VA = "0x180991DC0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public OLDENIALAEA NOPLGFBEMCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private KIKFEAEKMGH GOOAHAMPCLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x765C690", Offset = "0x765BA90", VA = "0x18765C690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool JGFLJICDLKF
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7659860", Offset = "0x7658C60", VA = "0x187659860")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private bool LMNKDHBIFNF
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x765CAA0", Offset = "0x765BEA0", VA = "0x18765CAA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private bool LBONMJNILHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x76555E0", Offset = "0x76549E0", VA = "0x1876555E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private bool GFJAEIKKPJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7659A00", Offset = "0x7658E00", VA = "0x187659A00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public AvatarConfiguration NACCBFNCPOF
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x997460", Offset = "0x996860", VA = "0x180997460", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool HJMENGGJAGI
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x1253EA0", Offset = "0x12532A0", VA = "0x181253EA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x24412F0", Offset = "0x24406F0", VA = "0x1824412F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private Material PJPNEGAOELK
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7660090", Offset = "0x765F490", VA = "0x187660090")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private Material FEDKNFBBHOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x765F220", Offset = "0x765E620", VA = "0x18765F220")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private bool PAEHAIDBCPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x9AC6E0", Offset = "0x9ABAE0", VA = "0x1809AC6E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public HBFPFNMMLAG JLHDAMOOPGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x122E110", Offset = "0x122D510", VA = "0x18122E110", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return default(HBFPFNMMLAG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x765CB80", Offset = "0x765BF80", VA = "0x18765CB80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public Material DMIAEAAFGPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xC82700", Offset = "0xC81B00", VA = "0x180C82700", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public SkinnedMeshRenderer[] EENAEOCLHGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x122DEC0", Offset = "0x122D2C0", VA = "0x18122DEC0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public Renderer[] ICACEFGPKOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xA18180", Offset = "0xA17580", VA = "0x180A18180", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool AKFIKOPJHLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x765CEE0", Offset = "0x765C2E0", VA = "0x18765CEE0", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public LDBNJIFCKAL.HECKIELMCBP KKEIODIHMOF
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xA17D10", Offset = "0xA17110", VA = "0x180A17D10", Slot = "20")]
		get
		{
			return default(LDBNJIFCKAL.HECKIELMCBP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int NHAKAFFHFBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x10C0F50", Offset = "0x10C0350", VA = "0x1810C0F50")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7655430", Offset = "0x7654830", VA = "0x187655430")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private bool LPOINIENKMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x765F1A0", Offset = "0x765E5A0", VA = "0x18765F1A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private static bool LBGLAEDABNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x9DBC10", Offset = "0x9DB010", VA = "0x1809DBC10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7655DB0", Offset = "0x76551B0", VA = "0x187655DB0", Slot = "15")]
	public KPNDCLGPJDN DANGFOGAMOA(NLGEAGICHBO HCMEIANJNMN, bool ILDCBNAMPLC, int[] BHELONIJEEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7655530", Offset = "0x7654930", VA = "0x187655530", Slot = "14")]
	public KPNDCLGPJDN BKPCNLNKONK(NLGEAGICHBO HCMEIANJNMN, bool ILDCBNAMPLC, int[] BHELONIJEEA, Func<Dictionary<string, IKCNPCJGLNP>, (KPNDCLGPJDN, COLCOEKKCIF<Dictionary<string, FHGKGMPNNBH<Texture2D>>>)> GPMMJHKIIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x765D250", Offset = "0x765C650", VA = "0x18765D250")]
	public KPNDCLGPJDN MJCNMFHFCDK(NLGEAGICHBO HCMEIANJNMN, bool ILDCBNAMPLC, int[] BHELONIJEEA, bool EJJIENCNCMM, BACEPNDKCHJ FKEPOCICAFO, [Optional] Func<Dictionary<string, IKCNPCJGLNP>, (KPNDCLGPJDN, COLCOEKKCIF<Dictionary<string, FHGKGMPNNBH<Texture2D>>>)> GPMMJHKIIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x765D050", Offset = "0x765C450", VA = "0x18765D050")]
	private bool MECKINJJANO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x765A830", Offset = "0x7659C30", VA = "0x18765A830")]
	private KPNDCLGPJDN KOLPOHGGCJD(bool ILDCBNAMPLC, List<PBIDJKKFFFO> IALEJADOGJK, int[] BHELONIJEEA, Func<int, PPJJIFPIFIE> NLCGPDIHCJI, bool EJJIENCNCMM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7660230", Offset = "0x765F630", VA = "0x187660230")]
	[IteratorStateMachine(typeof(GJGLPDJKCMC))]
	private IEnumerator<OAGIBKDGOAG> PILENBIEAON(bool ILDCBNAMPLC, List<PBIDJKKFFFO> IALEJADOGJK, int[] BHELONIJEEA, Func<int, PPJJIFPIFIE> NLCGPDIHCJI, MCOHMGPMHLK FBCDMOOHFPL, Material FFKOMFFNKOA, List<KPNDCLGPJDN> FPJJEGNGLCD, bool OHLLOEBHPFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7657330", Offset = "0x7656730", VA = "0x187657330")]
	private void GKPAMBIHHOB(List<PBIDJKKFFFO> IALEJADOGJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x765C440", Offset = "0x765B840", VA = "0x18765C440")]
	private KPNDCLGPJDN LFBHIGFAKFK(List<PBIDJKKFFFO> IALEJADOGJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x765AE10", Offset = "0x765A210", VA = "0x18765AE10")]
	private INGHODAMJIF KPLBNOFKFCJ(List<PBIDJKKFFFO> IALEJADOGJK, int BALKEAPIFFL, bool ILDCBNAMPLC, PPJJIFPIFIE JBHMHOMJPDO, bool ELOLHJAJCHE, MCOHMGPMHLK FBCDMOOHFPL, Material FFKOMFFNKOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x765BF20", Offset = "0x765B320", VA = "0x18765BF20", Slot = "27")]
	public void KPPAGHONIKN(KEHGEIMFGPM MDPPHLHBJGE, float FIIKLGCIAGG, bool ONGJOCKLGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x765D120", Offset = "0x765C520", VA = "0x18765D120", Slot = "29")]
	public void MGAOOLCKBDL(BGLIFKJGBNO KMJDCBOCFCF, float FIIKLGCIAGG, bool BDJJKLDPMEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7656380", Offset = "0x7655780", VA = "0x187656380", Slot = "30")]
	public void EGEHIPNAJKJ(BKNDIMCPBGA CEHMONGLABB, float FIIKLGCIAGG, bool HPAAHCHOIPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7660510", Offset = "0x765F910", VA = "0x187660510", Slot = "28")]
	public void POACCHIJDOP(bool BMGIFKNGKEE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7655BB0", Offset = "0x7654FB0", VA = "0x187655BB0", Slot = "31")]
	public void CKHJPKMAMLA(bool BMGIFKNGKEE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7656D00", Offset = "0x7656100", VA = "0x187656D00", Slot = "32")]
	public void EMOEHPIHKBF(bool BMGIFKNGKEE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x765FB90", Offset = "0x765EF90", VA = "0x18765FB90")]
	private void OGKHIPNHGOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7655560", Offset = "0x7654960", VA = "0x187655560")]
	private void BLGICJMKOJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7655E10", Offset = "0x7655210", VA = "0x187655E10")]
	private void DIFNGIOECHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7659940", Offset = "0x7658D40", VA = "0x187659940", Slot = "25")]
	public void JJABNPIHGBF(AvatarFaceShape ADLLKLFHIAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x765FA40", Offset = "0x765EE40", VA = "0x18765FA40", Slot = "26")]
	public void OFAEPEKIEDH(AvatarBodyShape EDJLCMFDJBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0xB03180", Offset = "0xB02580", VA = "0x180B03180", Slot = "33")]
	public void FGFKKPJLHCK(OMEFKCHKIOM AJICEFHNLGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7656D60", Offset = "0x7656160", VA = "0x187656D60", Slot = "35")]
	public void EPPHNJMMLGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7657F70", Offset = "0x7657370", VA = "0x187657F70", Slot = "38")]
	public void HGLGLKCCDFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x76556C0", Offset = "0x7654AC0", VA = "0x1876556C0", Slot = "34")]
	public void BNFFLHKDIGE(bool JCGDOIPNFOP, bool LFANGJEKPLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7657140", Offset = "0x7656540", VA = "0x187657140")]
	private void FKHEJPNPIHN(SkinnedMeshRenderer MGKJOKCDKBF, int BALKEAPIFFL, Mesh CNCBOAAEMAB, List<Material> EGHJMLIOIKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x765F430", Offset = "0x765E830", VA = "0x18765F430")]
	private static Material NJCDLJCIHDC(Dictionary<KIBGBDABHCI, Material> OGCFBEKPICG, Material FJFIJCIEEMO, LDPCJHHBCEO LJLEMLICBID, LCIJKJOBINF OHAFHPOHHDO, HKLJDIPJMDE DOIOMNLOJJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x765A630", Offset = "0x7659A30", VA = "0x18765A630")]
	private static LDPCJHHBCEO KMMJPCEJNCJ(PBIDJKKFFFO AMHAGEDJPLA, int FMGKNOADOPP)
	{
		return default(LDPCJHHBCEO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7659440", Offset = "0x7658840", VA = "0x187659440")]
	private void JHFKMFHLPGK(int GDKJNPJDHJB, Material KIEAKCEGOFO, PBIDJKKFFFO AMHAGEDJPLA, [Out] Texture2D FBGHOJFLHKF, [Out] Vector4 LEHNAICDLJH, [Out] Texture2D DJGMLLDLJJA, [Out] Texture2D LLNBCMBBECG, [Out] Texture2D FLFOMGMAEGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7659F30", Offset = "0x7659330", VA = "0x187659F30")]
	private void KENDEONDMHC(int GDKJNPJDHJB, Material KIEAKCEGOFO, PBIDJKKFFFO AMHAGEDJPLA, [Out] Color JINKDGPAFOI, [Out] Color GMKOGPIAFBK, [Out] Color GBLINBDOHEJ, [Out] Color HGHHCNJODAK, [Out] Color AAMOKBMLDIK, [Out] Color BJNBGEACOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x765FC10", Offset = "0x765F010", VA = "0x18765FC10")]
	private bool ONGBOMKGMLA(Material KIEAKCEGOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x765D200", Offset = "0x765C600", VA = "0x18765D200")]
	private static Material MIJFABNMKIK(int GDKJNPJDHJB, NMLFCNFGKCA AMHAGEDJPLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x765F960", Offset = "0x765ED60", VA = "0x18765F960")]
	private static LCIJKJOBINF ODBEDNDKMOA(PBIDJKKFFFO AMHAGEDJPLA, int FMGKNOADOPP)
	{
		return default(LCIJKJOBINF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7658570", Offset = "0x7657970", VA = "0x187658570")]
	private static void HMLDDFMIMEB(Dictionary<string, List<KIBGBDABHCI>> EBAHFMPNPGP, PBIDJKKFFFO HAEMGGLCNPI, Material FJFIJCIEEMO, LDPCJHHBCEO KACJOCGPGGC, LCIJKJOBINF HLFCGCADEAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x765F730", Offset = "0x765EB30", VA = "0x18765F730")]
	private static SkinnedMeshRenderer OCFCMEJHOCN(Transform KHHBFCDCKBC, Transform PKNCMKLAGCF, SkinnedMeshRenderer[] ONLNKCOHNIM, int BALKEAPIFFL, PPJJIFPIFIE JBHMHOMJPDO, bool ILDCBNAMPLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x76609C0", Offset = "0x765FDC0", VA = "0x1876609C0")]
	public OOHHGFPAPOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x765CB90", Offset = "0x765BF90", VA = "0x18765CB90")]
	public void MBHBIOMKKEG([In] GHJLAAKEPPA OOGEEJDIKLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7656300", Offset = "0x7655700", VA = "0x187656300")]
	public void EOIGNCBPFDD([In] BLOINHJMALA IAAFDBNCEPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7655430", Offset = "0x7654830", VA = "0x187655430", Slot = "5")]
	public void BEJNJCPFMHK(int BALKEAPIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7657980", Offset = "0x7656D80", VA = "0x187657980", Slot = "10")]
	public void HEKHAEICLND(GOJKKFOFNHC HLFCGCADEAN, Texture2D HLPGJNCKNML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x9AC6E0", Offset = "0x9ABAE0", VA = "0x1809AC6E0")]
	public static bool AIOGECNNELB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x76556D0", Offset = "0x7654AD0", VA = "0x1876556D0", Slot = "11")]
	public bool BNNNJNKBBMA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x76580A0", Offset = "0x76574A0", VA = "0x1876580A0", Slot = "9")]
	public void HJILODOODPL(CPDABLBNCDE KACJOCGPGGC, Color? CKANMCILFBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x765A730", Offset = "0x7659B30", VA = "0x18765A730")]
	private void KOCKPMFIJFJ(Action IGKBPIHABNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7659300", Offset = "0x7658700", VA = "0x187659300", Slot = "6")]
	public void ILBEIJCPEOK(IKCNPCJGLNP OHHMIFPIBLM, Texture PMLDGMGPAKD, Color KPLEFMLIDMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x24412F0", Offset = "0x24406F0", VA = "0x1824412F0", Slot = "7")]
	public void KHKDEANNLAM(bool OHLLOEBHPFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x215BB70", Offset = "0x215AF70", VA = "0x18215BB70", Slot = "8")]
	public void JENGCNNPCOD(HDGGCAEIEHM NFHKMOGHIBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7656B00", Offset = "0x7655F00", VA = "0x187656B00", Slot = "16")]
	public void ELICBODJFEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7660570", Offset = "0x765F970", VA = "0x187660570", Slot = "36")]
	public void POIJPDEKPLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x76545E0", Offset = "0x76539E0", VA = "0x1876545E0", Slot = "37")]
	public void AGHMHIIIKEE([Optional] GHDNJFDBFAB HENEICJGNKK, [Optional] bool? BIKEDNADPEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7660730", Offset = "0x765FB30", VA = "0x187660730")]
	private bool PPKEDLKEGFJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7655840", Offset = "0x7654C40", VA = "0x187655840", Slot = "21")]
	public bool BOJGPBMACDE(LDBNJIFCKAL.HECKIELMCBP MABLMFGFFFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7660350", Offset = "0x765F750", VA = "0x187660350")]
	private void PNABNIOEAEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7655DA0", Offset = "0x76551A0", VA = "0x187655DA0")]
	private void DAELLLHMFCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x765C860", Offset = "0x765BC60", VA = "0x18765C860")]
	private static void LKLPLJOBNAJ(Dictionary<KIBGBDABHCI, Material> OGCFBEKPICG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7659AE0", Offset = "0x7658EE0", VA = "0x187659AE0")]
	private static void KCLEABLAFID(Dictionary<Renderer, MCOHMGPMHLK> OFPEMIFAHFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x765F310", Offset = "0x765E710", VA = "0x18765F310")]
	private void NFFMEDFJKKI(SkinnedMeshRenderer[] ONLNKCOHNIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7657290", Offset = "0x7656690", VA = "0x187657290")]
	private void FKPLNFJKCMB(SkinnedMeshRenderer ABFNJDDAFNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7658820", Offset = "0x7657C20", VA = "0x187658820")]
	private void IBBCAPOEOGP(List<GCJENIKICGG> HCBFJMCCOJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7655E90", Offset = "0x7655290", VA = "0x187655E90")]
	private void DLEHBANPABC(Dictionary<string, FHGKGMPNNBH<Texture2D>> EBAHFMPNPGP, bool IDFHJHEGFEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x765CA50", Offset = "0x765BE50", VA = "0x18765CA50")]
	private void MALFIBOOGEF(Dictionary<string, List<KIBGBDABHCI>> EBAHFMPNPGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x765F010", Offset = "0x765E410", VA = "0x18765F010")]
	private void MOPBGMDOPIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7655C10", Offset = "0x7655010", VA = "0x187655C10")]
	private void CNLNAHMIHNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7656450", Offset = "0x7655850", VA = "0x187656450")]
	private void EHAIPOKNKGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x76584A0", Offset = "0x76578A0", VA = "0x1876584A0")]
	private void HKLAFMDKFAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x765EEC0", Offset = "0x765E2C0", VA = "0x18765EEC0")]
	private void MJGECKFABAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7654490", Offset = "0x7653890", VA = "0x187654490")]
	private void ACPCJJNLMGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x765C790", Offset = "0x765BB90", VA = "0x18765C790")]
	private void LKJEJJGDFGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x765F5C0", Offset = "0x765E9C0", VA = "0x18765F5C0")]
	private void NLIOFKIELPB(bool ILPIJAJMFED = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7659370", Offset = "0x7658770", VA = "0x187659370")]
	private void IPFDMFPOHDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7656A20", Offset = "0x7655E20", VA = "0x187656A20")]
	private void EHKCHCNPHAB(bool ILPIJAJMFED = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7655860", Offset = "0x7654C60", VA = "0x187655860")]
	private void CANEDGGEIOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7658A90", Offset = "0x7657E90", VA = "0x187658A90")]
	private void IDPLOLONEJI(Material FFKOMFFNKOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7659C40", Offset = "0x7659040", VA = "0x187659C40")]
	private void KDBBBEGKEBI(Material FFKOMFFNKOA, Color KMGEEMGDHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x765A3F0", Offset = "0x76597F0", VA = "0x18765A3F0")]
	private void KIOIPCIEAOG(Material FFKOMFFNKOA, Color KMGEEMGDHIJ, Color OGJDHGMLKFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7656010", Offset = "0x7655410", VA = "0x187656010")]
	private void EAAIAAKPKCN(Material FFKOMFFNKOA, Color JINKDGPAFOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x765FE70", Offset = "0x765F270", VA = "0x18765FE70")]
	private void ONJDGOIMIFM(Material FFKOMFFNKOA, Texture2D HLPGJNCKNML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x76605D0", Offset = "0x765F9D0", VA = "0x1876605D0")]
	private void PPHLPGFCIJL(Material FFKOMFFNKOA, Texture BKMLCHJHFGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x76561A0", Offset = "0x76555A0", VA = "0x1876561A0")]
	private void ECEGIICGDIK(Action<MCOHMGPMHLK> KENJIALEMDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7659DB0", Offset = "0x76591B0", VA = "0x187659DB0")]
	private void KEEJHEGJJPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x765C020", Offset = "0x765B420", VA = "0x18765C020")]
	private void LDLCKAAEPLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7657BA0", Offset = "0x7656FA0", VA = "0x187657BA0")]
	private void HEMPJNDNHOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7658F70", Offset = "0x7658370", VA = "0x187658F70")]
	public void IFHMPFAOCMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7656300", Offset = "0x7655700", VA = "0x187656300", Slot = "4")]
	private void ECIIDPGMNFB([In] BLOINHJMALA IAAFDBNCEPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x765F160", Offset = "0x765E560", VA = "0x18765F160")]
	[CompilerGenerated]
	private KMDOHMPCNFD NCEHFPMKIJE(PBIDJKKFFFO GGAJNINGNDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x76554A0", Offset = "0x76548A0", VA = "0x1876554A0")]
	[CompilerGenerated]
	private void BKLBAFKPNMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7655DE0", Offset = "0x76551E0", VA = "0x187655DE0")]
	[CompilerGenerated]
	private void DFGMCHMPGJD(MCOHMGPMHLK NMAEAHGFFHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x765C9C0", Offset = "0x765BDC0", VA = "0x18765C9C0")]
	[CompilerGenerated]
	private void LLKGOEDLFNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7655480", Offset = "0x7654880", VA = "0x187655480")]
	[CompilerGenerated]
	private void BJFNPGLLMNL(MCOHMGPMHLK NMAEAHGFFHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x765C700", Offset = "0x765BB00", VA = "0x18765C700")]
	[CompilerGenerated]
	private void LJNLDPBKBOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x765C000", Offset = "0x765B400", VA = "0x18765C000")]
	[CompilerGenerated]
	private void LBAHJPBIIOH(MCOHMGPMHLK NMAEAHGFFHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x765FB00", Offset = "0x765EF00", VA = "0x18765FB00")]
	[CompilerGenerated]
	private void OGHMCLKLAOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x765EFE0", Offset = "0x765E3E0", VA = "0x18765EFE0")]
	[CompilerGenerated]
	private void MNDGHMALHAA(MCOHMGPMHLK NMAEAHGFFHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7658A00", Offset = "0x7657E00", VA = "0x187658A00")]
	[CompilerGenerated]
	private void IDEFFOEPKKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7660060", Offset = "0x765F460", VA = "0x187660060")]
	[CompilerGenerated]
	private void OPMDPGJOEHI(MCOHMGPMHLK NMAEAHGFFHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x765F6A0", Offset = "0x765EAA0", VA = "0x18765F6A0")]
	[CompilerGenerated]
	private void NMGCNHLCFMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x765F590", Offset = "0x765E990", VA = "0x18765F590")]
	[CompilerGenerated]
	private void NKCHIDPNLNL(MCOHMGPMHLK NMAEAHGFFHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x765EF50", Offset = "0x765E350", VA = "0x18765EF50")]
	[CompilerGenerated]
	private void MMCCGFCJCPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7657950", Offset = "0x7656D50", VA = "0x187657950")]
	[CompilerGenerated]
	private void HCOLNFIDFLO(MCOHMGPMHLK NMAEAHGFFHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x765A7B0", Offset = "0x7659BB0", VA = "0x18765A7B0")]
	[CompilerGenerated]
	private void KOLPBMKIKPI(KeyValuePair<string, FHGKGMPNNBH<Texture2D>> HJKENFLJHMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7655420", Offset = "0x7654820", VA = "0x187655420")]
	[CompilerGenerated]
	private void AMLDFGPGEHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7655450", Offset = "0x7654850", VA = "0x187655450")]
	[CompilerGenerated]
	private void BIDOCEKEBAK(MCOHMGPMHLK NMAEAHGFFHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7659850", Offset = "0x7658C50", VA = "0x187659850")]
	[CompilerGenerated]
	private void JIJDLENMBGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7655B80", Offset = "0x7654F80", VA = "0x187655B80")]
	[CompilerGenerated]
	private void CCKFEJFENFO(MCOHMGPMHLK NMAEAHGFFHD)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class AvatarElbowBendHelperController : MonoBehaviour, PIBLOCDINDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		[SerializeField]
		[IJJGDJMELDG(FPABMOGJDEH.Self, false, false, false)]
		private Transform ElbowHelperBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		[SerializeField]
		private Transform UpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		[SerializeField]
		private Transform LowerArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		[SerializeField]
		private float MinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		[SerializeField]
		private float MaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		[FormerlySerializedAs("MinScaleValues")]
		[SerializeField]
		[Header("Scale")]
		private Vector3 ScaleValuesAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[SerializeField]
		[FormerlySerializedAs("MaxScaleValues")]
		private Vector3 ScaleValuesAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[SerializeField]
		[FormerlySerializedAs("MinLocalPositionalOffset")]
		[Header("Positional Offset")]
		private Vector3 PositionalOffsetAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[FormerlySerializedAs("MaxLocalPositionOffset")]
		[SerializeField]
		private Vector3 PositionalOffsetAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private Vector3? LEGCEKAKMMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private bool CIMKLMFEJJA;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x764B390", Offset = "0x764A790", VA = "0x18764B390", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x764B9B0", Offset = "0x764ADB0", VA = "0x18764B9B0", Slot = "4")]
		public void UpdateController(float NFEBFCGCNJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xBA2850", Offset = "0xBA1C50", VA = "0x180BA2850", Slot = "6")]
		public void SetEnabled(bool FIIKLGCIAGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x764B470", Offset = "0x764A870", VA = "0x18764B470")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x764BE70", Offset = "0x764B270", VA = "0x18764BE70")]
		public AvatarElbowBendHelperController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class AvatarElbowBendTargetController : MonoBehaviour, PIBLOCDINDP
	{
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private const float LPKHJJDLEKO = 45f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		[SerializeField]
		[IJJGDJMELDG(FPABMOGJDEH.Self, false, false, false)]
		private Transform ElbowBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		[SerializeField]
		private Transform NeckBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		[SerializeField]
		private Transform UpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[SerializeField]
		private bool Left;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[SerializeField]
		private float MinTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		[SerializeField]
		private float MaxTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		[SerializeField]
		private float TwistWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		[SerializeField]
		private float ElbowSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		[SerializeField]
		private float RestTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		[SerializeField]
		private float RestTwistWhenClose;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		[SerializeField]
		private float RestTwistDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private Vector3 ODNKCNFIIAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private Vector3 NOJPCJMINEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private bool CIMKLMFEJJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private float HEHCGJPGGAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private float NJIIBBGGKAC;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x764C1F0", Offset = "0x764B5F0", VA = "0x18764C1F0", Slot = "4")]
		public void UpdateController(float NFEBFCGCNJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x12F1EB0", Offset = "0x12F12B0", VA = "0x1812F1EB0", Slot = "6")]
		public void SetEnabled(bool FIIKLGCIAGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x764BF10", Offset = "0x764B310", VA = "0x18764BF10")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x764CCB0", Offset = "0x764C0B0", VA = "0x18764CCB0")]
		public AvatarElbowBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class OJAIEMLEGJG : PBCNDHELJOL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private static readonly int LBIGKDOLLGI;

	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private static readonly int NEGCCOOKOBP;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private static readonly int MJNHENNICIK;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private static readonly int PNNNGFIJKGL;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static readonly int FJAJGGCKOAO;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private static readonly int MELFBHBLNMA;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static readonly int LJKADLHJGAE;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static readonly int MGKPCGEPGGK;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private static readonly int EBGKMOJNFNC;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private static readonly int FPOAHCHGJDH;

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private static readonly int NAAHEMFGPFB;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private static readonly int KCDCDGECCEJ;

	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private static readonly int PAAJKKMOMDF;

	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private static readonly int NLCIJHHGHCL;

	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private static readonly int PBELHBDHIFM;

	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private static readonly int KKFEICJBNNL;

	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private static readonly int AJCDPFFCHLG;

	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private static readonly int IDBFOIJAPOD;

	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private static readonly int POOECIJKOBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private Transform OOPGOAOIBMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private Transform IDGEFOANHEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private Transform JNDMMKBAJHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private Transform KCJFDKLCOEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private Transform KPKIBLDPINP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private Transform FPKNPFODJMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private Transform FJNDHJFDNCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private GIDHJIMOFKL HPDPDDMPGKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private Material OJKJPPEFJGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private SkinnedMeshRenderer[] OMAFEEFEENM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private readonly List<Material> LLBOEOLIKPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private LLCLPLCGHML MEBMJDPJINJ;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public OLDENIALAEA MDODIFKPAHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x991DC0", Offset = "0x9911C0", VA = "0x180991DC0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private LLCLPLCGHML NIGLMNDIGCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7672850", Offset = "0x7671C50", VA = "0x187672850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool NFLEONEBCBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x76728D0", Offset = "0x7671CD0", VA = "0x1876728D0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x7672E80", Offset = "0x7672280", VA = "0x187672E80")]
	public void MBHBIOMKKEG([In] GIDHJIMOFKL DOOLOCHBFGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x76727A0", Offset = "0x7671BA0", VA = "0x1876727A0")]
	public void DHOIJPLBHOB([In] BHKDFFIKKMI OACDOGEEHNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x76721D0", Offset = "0x76715D0", VA = "0x1876721D0", Slot = "6")]
	public void AFDGAEGBMBM(GOHHKNOFECI INEOKGBFMOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x7672690", Offset = "0x7671A90", VA = "0x187672690")]
	private Vector2 AJMPLCHHOFD(Vector2 OCCNDDHOHEF)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x7673310", Offset = "0x7672710", VA = "0x187673310")]
	public void PNOOBJMBFJK([In] CHODNKAHLOE OACDOGEEHNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7672F50", Offset = "0x7672350", VA = "0x187672F50")]
	private void ODALPFMKILE(EAJEFAHNGIC JNCFNPOHPPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7672A50", Offset = "0x7671E50", VA = "0x187672A50")]
	private void IEAFCCIOIFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x7672730", Offset = "0x7671B30", VA = "0x187672730")]
	private void DAONMJAONDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7672730", Offset = "0x7671B30", VA = "0x187672730", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7674560", Offset = "0x7673960", VA = "0x187674560")]
	public OJAIEMLEGJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x76727A0", Offset = "0x7671BA0", VA = "0x1876727A0", Slot = "5")]
	private void LMPFDHNMFHI([In] BHKDFFIKKMI OACDOGEEHNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7672E70", Offset = "0x7672270", VA = "0x187672E70", Slot = "7")]
	private void KNLGLPJLBMJ([In] CHODNKAHLOE OACDOGEEHNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x7672840", Offset = "0x7671C40", VA = "0x187672840")]
	[CompilerGenerated]
	internal static float FDOCIPDBLLL(float FIIKLGCIAGG, float LNCLJLPOPIK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7672DE0", Offset = "0x76721E0", VA = "0x187672DE0")]
	[CompilerGenerated]
	internal static (float, float) IJGGEBCJMCE(float MGCMCNKIDPH)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x76726F0", Offset = "0x7671AF0", VA = "0x1876726F0")]
	[CompilerGenerated]
	internal static Vector4 COAODPKFPPB(Vector2 JPKKPDPLAGA, Vector2 PGJAFHMCBJK)
	{
		return default(Vector4);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class AvatarForearmRollController : MonoBehaviour, PIBLOCDINDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		[SerializeField]
		private Transform TwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		[SerializeField]
		private Transform LowerArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		[SerializeField]
		private Transform UpperArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		[SerializeField]
		private Transform ElbowTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		[SerializeField]
		private float RollTowardsWristAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		[SerializeField]
		private float RollSoftMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		[SerializeField]
		private float RollSoftMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		[SerializeField]
		private float LowerArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		[SerializeField]
		private float UpperArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		[SerializeField]
		private float ElbowTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private float HEHCGJPGGAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private bool CIMKLMFEJJA;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x7661C80", Offset = "0x7661080", VA = "0x187661C80", Slot = "4")]
		public void UpdateController(float NFEBFCGCNJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x1569080", Offset = "0x1568480", VA = "0x181569080", Slot = "6")]
		public void SetEnabled(bool FIIKLGCIAGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x7662700", Offset = "0x7661B00", VA = "0x187662700")]
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
			[Cpp2IlInjected.Token(Token = "0x400016F")]
			[Tooltip("Name of animation original state to override")]
			public string OriginalName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000170")]
			[Tooltip("Name of animation state to use as an override")]
			public string OverrideName;

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public AnimationOverride()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		[SerializeField]
		private AnimationOverride[] HandStateOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private Dictionary<int, int> _animationOverrides;

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x7662730", Offset = "0x7661B30", VA = "0x187662730")]
		public void AEJOPFDILPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x7662850", Offset = "0x7661C50", VA = "0x187662850")]
		public int LPJPMOPDKBB(int MJFAOOKNMKL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public AvatarHandDisplaySettings()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class CPCOOJBNCJC : HGNFJKNHMMP
{
	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x7665980", Offset = "0x7664D80", VA = "0x187665980", Slot = "22")]
	public override float KEEHODFIHCK()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x76659D0", Offset = "0x7664DD0", VA = "0x1876659D0")]
	public CPCOOJBNCJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class HGNFJKNHMMP : CINJLPKEMIB
{
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private static int OOHNFBLIHHJ;

	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private static int NNIGJAAEHJC;

	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private static int FMJDCPCIMCP;

	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private static int MDKHACPEGJM;

	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private static int HGOBOKHAAOL;

	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private static int LHHEDLMJGKN;

	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private static int GMOOJCBFDBC;

	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private static int[] JFMDMAFJPFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private BOGLILOBOEE HPDPDDMPGKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private NIAEOHFPGPF JHDIIHFKIMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private int LIHKAJAMNJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private float BFMKHBAKPMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	protected Animator JHKALDDIDME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	protected bool EEDHHGGEJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	protected AvatarConfiguration AGOOLBJHAIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	protected int EKEEKPAIKEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private int PAJPEBMNGKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private int JHLHNJIOMJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private bool AMHIPHOMNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private LFGDPDKIHFI MMGHADIAHAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private int CKLBEIPNMHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private float POEBDHLFAAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private AvatarHandDisplaySettings BJCFFNLOBOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private HBFPFNMMLAG FHDPJNOHINP;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Transform CBIMLOHIBEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x991DC0", Offset = "0x9911C0", VA = "0x180991DC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x991E00", Offset = "0x991200", VA = "0x180991E00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public Vector3 GMMNIAEOMEK
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x1545330", Offset = "0x1544730", VA = "0x181545330")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x15454E0", Offset = "0x15448E0", VA = "0x1815454E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Quaternion CLIIAHBGOKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xC6BF60", Offset = "0xC6B360", VA = "0x180C6BF60")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xE6B750", Offset = "0xE6AB50", VA = "0x180E6B750")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool KDBJHDNEPIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7667A70", Offset = "0x7666E70", VA = "0x187667A70")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x76684B0", Offset = "0x76678B0", VA = "0x1876684B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public Vector3 AOJLFGLOECL
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7668490", Offset = "0x7667890", VA = "0x187668490", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x7667AD0", Offset = "0x7666ED0", VA = "0x187667AD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public Quaternion OKELCCGCDHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x75B3CC0", Offset = "0x75B30C0", VA = "0x1875B3CC0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x7667B40", Offset = "0x7666F40", VA = "0x187667B40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public JLDMEMCNCMD LIBPLFPNMJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xAF6230", Offset = "0xAF5630", VA = "0x180AF6230", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(JLDMEMCNCMD);
		}
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xAF5FC0", Offset = "0xAF53C0", VA = "0x180AF5FC0", Slot = "4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public JLDMEMCNCMD ODKGKEOCLML
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x232F4C0", Offset = "0x232E8C0", VA = "0x18232F4C0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(JLDMEMCNCMD);
		}
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x232E500", Offset = "0x232D900", VA = "0x18232E500", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public float GCCKGCMDFLI
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x13721E0", Offset = "0x13715E0", VA = "0x1813721E0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0xE56EE0", Offset = "0xE562E0", VA = "0x180E56EE0", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool AGODNDJMCDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7667CD0", Offset = "0x76670D0", VA = "0x187667CD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool BMHEPBGELNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7667DB0", Offset = "0x76671B0", VA = "0x187667DB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool BOECGCLEPPP
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x76679A0", Offset = "0x7666DA0", VA = "0x1876679A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool LMJFOLKIEIN
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x7667A50", Offset = "0x7666E50", VA = "0x187667A50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x76682F0", Offset = "0x76676F0", VA = "0x1876682F0", Slot = "21")]
	public void MBHBIOMKKEG(BOGLILOBOEE DOOLOCHBFGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x7667A00", Offset = "0x7666E00", VA = "0x187667A00")]
	public void DMNKIMPBHHJ(NIAEOHFPGPF DFHADBADINI, AvatarHandDisplaySettings JJJMCAHFNCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x7667D20", Offset = "0x7667120", VA = "0x187667D20", Slot = "12")]
	public void KAPIDPKLABL(bool ODCIGAJHLFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x7667F80", Offset = "0x7667380", VA = "0x187667F80", Slot = "11")]
	public void LOHGGMBFGJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x13721E0", Offset = "0x13715E0", VA = "0x1813721E0", Slot = "22")]
	public virtual float KEEHODFIHCK()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x7667B50", Offset = "0x7666F50", VA = "0x187667B50")]
	private int HOHKGMMFPIM(JLDMEMCNCMD NIAJLEPMBJI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x7667DC0", Offset = "0x76671C0", VA = "0x187667DC0")]
	private void LCMCNFKJDFE(int HLJKJMCIFDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x7667980", Offset = "0x7666D80", VA = "0x187667980", Slot = "13")]
	public bool BANGLMNLNJJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x7667A60", Offset = "0x7666E60", VA = "0x187667A60", Slot = "14")]
	public bool ENNBLOHGOLF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x76679B0", Offset = "0x7666DB0", VA = "0x1876679B0")]
	private JLDMEMCNCMD DDAOFACMIBM()
	{
		return default(JLDMEMCNCMD);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x1C4CBF0", Offset = "0x1C4BFF0", VA = "0x181C4CBF0", Slot = "15")]
	public void FAJJOMCHOFJ(bool ODCIGAJHLFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7667CE0", Offset = "0x76670E0", VA = "0x187667CE0", Slot = "10")]
	public void JGDJPDKIGOI(int HLJKJMCIFDD, float BJGCENEOGBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7667AB0", Offset = "0x7666EB0", VA = "0x187667AB0", Slot = "8")]
	public void FHOGKOOMMEM(LFGDPDKIHFI FBOKGPFKJCL, bool GIPGMKNGIBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7667AA0", Offset = "0x7666EA0", VA = "0x187667AA0", Slot = "9")]
	public void FHEHOAFOENC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x7667AF0", Offset = "0x7666EF0", VA = "0x187667AF0", Slot = "16")]
	public void FOCBHENNCBA(Transform PBIFOHNGFLL, Vector3 MEFLDLLJODM, Quaternion NOAPNNMFGIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7668770", Offset = "0x7667B70", VA = "0x187668770")]
	public HGNFJKNHMMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class NMLFCNFGKCA : PBIDJKKFFFO
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class ACOHBLBEKMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public NMLFCNFGKCA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public List<GCJENIKICGG> prefabHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public List<GCJENIKICGG> materialHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public FHGKGMPNNBH<Material[]> loadMaterialsHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public FHGKGMPNNBH<CGOMJEHMJKG> loadPrefabHandle;

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public ACOHBLBEKMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x7661A40", Offset = "0x7660E40", VA = "0x187661A40")]
		internal KMDOHMPCNFD CMPABJAKNGP(string error)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	public IKCNPCJGLNP FLHLIJGOENP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	public CGOMJEHMJKG FLADAHLPBLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private FHGKGMPNNBH<CGOMJEHMJKG> FEKMEBMOFOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private FHGKGMPNNBH<Material[]> PKJDHJAKJLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	public Material[] FPNLFPCPNOA;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool FJFNIHJIIDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x9BF180", Offset = "0x9BE580", VA = "0x1809BF180")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x9BEF00", Offset = "0x9BE300", VA = "0x1809BEF00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public LDBNJIFCKAL.HECKIELMCBP IJBCJMJGICK
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x993450", Offset = "0x992850", VA = "0x180993450")]
		[CompilerGenerated]
		get
		{
			return default(LDBNJIFCKAL.HECKIELMCBP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99EC70", VA = "0x18099F870")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x76709F0", Offset = "0x766FDF0", VA = "0x1876709F0")]
	public NMLFCNFGKCA(HKLJDIPJMDE DGBMDLCEMGI, IKCNPCJGLNP PEOGNHIKLPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x76704F0", Offset = "0x766F8F0", VA = "0x1876704F0", Slot = "6")]
	public override KMDOHMPCNFD PKNPAJGCANH(List<GCJENIKICGG> KICMOOOALMA, List<GCJENIKICGG> MIEANBHCDON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x766F6C0", Offset = "0x766EAC0", VA = "0x18766F6C0")]
	public KMDOHMPCNFD FJGCEKCMNBG(List<GCJENIKICGG> KICMOOOALMA, List<GCJENIKICGG> MIEANBHCDON, FHGKGMPNNBH<Material[]> PKJDHJAKJLM, [Optional] FHGKGMPNNBH<CGOMJEHMJKG> CAEDOAILMHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x766FCD0", Offset = "0x766F0D0", VA = "0x18766FCD0")]
	public (FHGKGMPNNBH<Material[]>, FHGKGMPNNBH<CGOMJEHMJKG>) LFNJHNFIGJP(List<GCJENIKICGG> KICMOOOALMA, List<GCJENIKICGG> MIEANBHCDON)
	{
		return default((FHGKGMPNNBH<Material[]>, FHGKGMPNNBH<CGOMJEHMJKG>));
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x7670060", Offset = "0x766F460", VA = "0x187670060", Slot = "7")]
	public override CKAJJFHNOBF MDEHKLMAIIL(uint BALKEAPIFFL, AvatarSkinnedMeshBoneOrderRemapsData ENKOGNJKOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x766FAC0", Offset = "0x766EEC0", VA = "0x18766FAC0")]
	public CKAJJFHNOBF LEDNGGLAGKC(GameObject ADOIADHGDCB, uint BALKEAPIFFL, bool AOGBHJKBPGA, bool PGJANAHAICG, AvatarSkinnedMeshBoneOrderRemapsData ENKOGNJKOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x7670190", Offset = "0x766F590", VA = "0x187670190")]
	public static bool OMFKNCKOKIN(Renderer[] ONLNKCOHNIM, string EPGGBHPLPPL, [Out] Renderer MGNNFPONKBF, [Out] Renderer AKCHODOFGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x76709A0", Offset = "0x766FDA0", VA = "0x1876709A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x766F9D0", Offset = "0x766EDD0", VA = "0x18766F9D0")]
	private (FHGKGMPNNBH<CGOMJEHMJKG>, FHGKGMPNNBH<Material[]>) HDCJCHDJIPM()
	{
		return default((FHGKGMPNNBH<CGOMJEHMJKG>, FHGKGMPNNBH<Material[]>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x766FAA0", Offset = "0x766EEA0", VA = "0x18766FAA0")]
	[CompilerGenerated]
	private void KANJIJPHMJM(CGOMJEHMJKG KGODHHBLJOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x997470", Offset = "0x996870", VA = "0x180997470")]
	[CompilerGenerated]
	private void PEABNJENBFM(Material[] KGODHHBLJOE)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class AvatarKneeBendTargetController : MonoBehaviour, PIBLOCDINDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		[IJJGDJMELDG(FPABMOGJDEH.Self, false, false, false)]
		[SerializeField]
		private Transform KneeBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		[SerializeField]
		private Transform RootSpineBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		[SerializeField]
		private Transform ThighBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		[SerializeField]
		private Transform FootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		[SerializeField]
		private float WeightToFootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		[SerializeField]
		private Vector3 BendTargetOffsetFromHipToFootMidPoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		[SerializeField]
		private Bounds KneeTargetConstrainedBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private Vector3 ODNKCNFIIAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private Vector3 OFFFHBEBGNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private Vector3 NBDHIGGFFBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private Matrix4x4 NKDHBBJHIFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private bool CIMKLMFEJJA;

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x7662D30", Offset = "0x7662130", VA = "0x187662D30", Slot = "4")]
		public void UpdateController(float NFEBFCGCNJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x7662D20", Offset = "0x7662120", VA = "0x187662D20", Slot = "6")]
		public void SetEnabled(bool FIIKLGCIAGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x76628C0", Offset = "0x7661CC0", VA = "0x1876628C0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x76633F0", Offset = "0x76627F0", VA = "0x1876633F0")]
		public AvatarKneeBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[NGHELBGCMPC]
public struct OBAMHKENBCJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	[ReadOnly]
	public JINAGKEBLMN HCMOMCFCBOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	[ReadOnly]
	public int DIKEKINGDBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	public CDGCNJLGFDN KMLMGAMIHCM;

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7670DC0", Offset = "0x76701C0", VA = "0x187670DC0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[NGHELBGCMPC]
[NativeContainer]
public struct CDGCNJLGFDN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public NativeArray<Vector3> CPJGKODLBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public NativeArray<Vector3> MAMCGDFCNNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public NativeArray<Vector4> LHKODGKOJJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public NativeArray<Vector2> GKHHECOGPKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public NativeArray<Vector2> JHMJFOGKPLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public NativeArray<Vector2> IFPOONMEPDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public NativeArray<Vector2> EKCAHOKLMPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	public NativeArray<Color> GMBJEHONJLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	public NativeArray<int> GAHABMNGKJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public NativeArray<int> AGIJAIDKLGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private NativeArray<int> EDOCPPOEBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private NativeArray<int> JGBGGPHLGII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public NativeArray<int> BLHFFPIJJDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	public NativeArray<int> EPNJDHGBHPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	public NativeArray<int> MDHHOCOPBKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	public NativeArray<BoneWeight> BPENMNDBMJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private NativeArray<int> NFHKMOGHIBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private bool HMNABFCOFHI;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public int BACPJGLNGAB
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7664A60", Offset = "0x7663E60", VA = "0x187664A60")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x7664A70", Offset = "0x7663E70", VA = "0x187664A70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int HGJFFIFCMBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x7664A50", Offset = "0x7663E50", VA = "0x187664A50")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x7665480", Offset = "0x7664880", VA = "0x187665480")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int ENBFOOMBABB
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x76652D0", Offset = "0x76646D0", VA = "0x1876652D0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7664A40", Offset = "0x7663E40", VA = "0x187664A40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x7665490", Offset = "0x7664890", VA = "0x187665490")]
	public CDGCNJLGFDN(int CLMLOOPKKFK, int OBMELHCGDFF, int CGCBHFJHIFB, int OLCOGNMFEID, Allocator LENIJMBFHJK, int BFEFHLMBEDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x7665410", Offset = "0x7664810", VA = "0x187665410")]
	public void MIMDIMCJICO(int KDCAMOIGIMA, Vector3 AEPDMGGJHKC, Vector3 OCKNOGIDPFP, Vector4 CFOOONLCHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x7664AA0", Offset = "0x7663EA0", VA = "0x187664AA0")]
	public void CKGINFMDJNK(int KDCAMOIGIMA, BoneWeight NBHJOBGKHAK, NativeSlice<byte> JKBPHIPEBKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x7664F60", Offset = "0x7664360", VA = "0x187664F60")]
	public Color FLCHAGDLBNA(int KDCAMOIGIMA)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x7664A80", Offset = "0x7663E80", VA = "0x187664A80")]
	public void CHGBPNLKMLJ(int KDCAMOIGIMA, Color AMLIHKJCCAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x76653C0", Offset = "0x76647C0", VA = "0x1876653C0")]
	public void MBAJHFIOMNB(byte IHHHLBHFMFP, int KDCAMOIGIMA, Vector2 EGJOOBNGOMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x7664E80", Offset = "0x7664280", VA = "0x187664E80")]
	public void ECMIDELAHBB(int KDCAMOIGIMA, int CNEIBJELGAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x7665390", Offset = "0x7664790", VA = "0x187665390")]
	public bool LFMGKJDCKND(int IHHHLBHFMFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x7664E90", Offset = "0x7664290", VA = "0x187664E90")]
	public void ELDNPFJGOOF(int GNEIJJMEKIN, int NPELPNMIGOA, int GHDAIPOHNAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x76652E0", Offset = "0x76646E0", VA = "0x1876652E0")]
	public int[] JDNNMNDAONO(int GNEIJJMEKIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x7664DF0", Offset = "0x76641F0", VA = "0x187664DF0")]
	private NativeSlice<int> ECGMJFCGMLF(int GNEIJJMEKIN)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x7664C40", Offset = "0x7664040", VA = "0x187664C40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x7664F80", Offset = "0x7664380", VA = "0x187664F80")]
	public Mesh GKOEDMEMMFC([Optional] string POBGIKONEEJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[DefaultMember("Item")]
[NGHELBGCMPC]
[NativeContainer]
public struct JINAGKEBLMN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	public NativeArray<Vector3> CPJGKODLBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public NativeArray<Vector3> MAMCGDFCNNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public NativeArray<Vector4> LHKODGKOJJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public NativeArray<Vector2> GKHHECOGPKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public NativeArray<Vector2> JHMJFOGKPLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public NativeArray<Vector2> IFPOONMEPDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public NativeArray<Vector2> EKCAHOKLMPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	public NativeArray<Color> GMBJEHONJLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public NativeArray<int> CMPGDMFHOCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public NativeArray<int> LDEIEHOKHKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public NativeArray<int> IJGBEPGGOOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public NativeArray<int> EMNIAMPADOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	public NativeArray<bool> BACJLOEEGNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	public NativeArray<int> IMMNIBIAAHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	public NativeArray<int> GLPGEHAFAFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	public NativeArray<BoneWeight> COJMFNFEADL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private NativeArray<Matrix4x4> MLIBKIBJBNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private NativeArray<long> OOGNIMIJDJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private NativeArray<byte> NCDGJKAKGFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private NativeArray<int> OJHKOFBINMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private NativeArray<int> HOHONNDIEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	public NativeArray<sbyte> JFGGMOAAOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public NativeArray<byte> BALJPGAKNBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	private NativeArray<int> CCBEBJGPMON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private bool HMNABFCOFHI;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int CHJDHBNJGJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xD074A0", Offset = "0xD068A0", VA = "0x180D074A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public int KPJDFNMILEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xBA57C0", Offset = "0xBA4BC0", VA = "0x180BA57C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int DBCFNBNOIIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x7669380", Offset = "0x7668780", VA = "0x187669380")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int GDJAJFFMKOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x76690D0", Offset = "0x76684D0", VA = "0x1876690D0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x76698E0", Offset = "0x7668CE0", VA = "0x1876698E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public int BACPJGLNGAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7668FE0", Offset = "0x76683E0", VA = "0x187668FE0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x76690C0", Offset = "0x76684C0", VA = "0x1876690C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public int ANGJLMICBIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x76698F0", Offset = "0x7668CF0", VA = "0x1876698F0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x7669900", Offset = "0x7668D00", VA = "0x187669900")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public JNGKKHAFNLF DJPONGIFIEK
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7669360", Offset = "0x7668760", VA = "0x187669360")]
		get
		{
			return default(JNGKKHAFNLF);
		}
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7669910", Offset = "0x7668D10", VA = "0x187669910")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public byte CNMFJPCJNNG
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7669350", Offset = "0x7668750", VA = "0x187669350")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x7669370", Offset = "0x7668770", VA = "0x187669370")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public DDHFDFDCCGJ PPOFLIOMKNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x76693B0", Offset = "0x76687B0", VA = "0x1876693B0")]
		get
		{
			return default(DDHFDFDCCGJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x7669920", Offset = "0x7668D20", VA = "0x187669920")]
	public JINAGKEBLMN(IList<Mesh> OIDGKEJEOFD, IList<Matrix4x4> AIKLKKHNHNL, IList<bool> BACJLOEEGNA, byte EIPJJNGFECD, IList<byte[]> ELKCOIOFDHL, IList<long> DNEHMDAAPNC, IList<bool> HICIPLDOHCJ, IList<int> IMMNIBIAAHO, IList<int> AJJFFBOJGHK, IList<int> PDHCPBKPKGO, Allocator LENIJMBFHJK, JNGKKHAFNLF NKAEGFFOLJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x7668FF0", Offset = "0x76683F0", VA = "0x187668FF0")]
	public CDGCNJLGFDN AIPKGAKLOKF(Allocator LENIJMBFHJK)
	{
		return default(CDGCNJLGFDN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x76690E0", Offset = "0x76684E0", VA = "0x1876690E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[NGHELBGCMPC]
public class LAPDKBKGFDM : LPEHBKIOIKC
{
	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x766C030", Offset = "0x766B430", VA = "0x18766C030")]
	public JINAGKEBLMN OCNLJGEKMEM()
	{
		return default(JINAGKEBLMN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x7653A40", Offset = "0x7652E40", VA = "0x187653A40")]
	public LAPDKBKGFDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct DDHFDFDCCGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public NativeSlice<Vector3> CPJGKODLBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public NativeSlice<Vector3> MAMCGDFCNNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public NativeSlice<Vector4> LHKODGKOJJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public NativeSlice<Vector2> GKHHECOGPKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public NativeSlice<Vector2> JHMJFOGKPLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	public NativeSlice<Vector2> IFPOONMEPDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public NativeSlice<Vector2> EKCAHOKLMPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public NativeSlice<Color> GMBJEHONJLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public NativeSlice<int> LJLNLDBOGPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public NativeSlice<int> EMNIAMPADOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	public NativeSlice<BoneWeight> COJMFNFEADL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public NativeSlice<byte> DJJEEFGGNOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public int JINHJKOHAPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public Matrix4x4 MNBOGMCEECP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public long EFGOCACDJFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	public NativeSlice<byte> JKBPHIPEBKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	public bool OLINMMLHLHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	public int CABGDJNIOIJ;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal readonly struct KIBGBDABHCI : IEquatable<KIBGBDABHCI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	internal readonly Material DHMACONJDOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	internal readonly LDPCJHHBCEO HNIGNIKBLCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	internal readonly LCIJKJOBINF JOKICIMICLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	internal readonly HKLJDIPJMDE FMJEGGKCLMF;

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x766BFF0", Offset = "0x766B3F0", VA = "0x18766BFF0")]
	public KIBGBDABHCI(Material KIEAKCEGOFO, LDPCJHHBCEO LJLEMLICBID, LCIJKJOBINF OHAFHPOHHDO, HKLJDIPJMDE DOIOMNLOJJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x766BDC0", Offset = "0x766B1C0", VA = "0x18766BDC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x766BBB0", Offset = "0x766AFB0", VA = "0x18766BBB0", Slot = "4")]
	public bool Equals(KIBGBDABHCI JAPIEEBOJEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x766BC30", Offset = "0x766B030", VA = "0x18766BC30", Slot = "0")]
	public override bool Equals(object HAPOBHMBDHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x766BD20", Offset = "0x766B120", VA = "0x18766BD20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyDisplayBehaviour : MonoBehaviour, PAHJFAGMNMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		[Header("Configuration")]
		[SerializeField]
		protected AvatarConfiguration configuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		[SerializeField]
		protected Animator skeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		[SerializeField]
		protected Renderer[] watchRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		[Header("Configuration")]
		[SerializeField]
		private HBFPFNMMLAG avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		[SerializeField]
		private AvatarSkinAssetItem potatoAvatarSkinAssetItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		[SerializeField]
		[FormerlySerializedAs("avatarSkinAsset")]
		private AssetReference avatarSkinAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		[SerializeField]
		private GameObject firstPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		[SerializeField]
		public GameObject thirdPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		[SerializeField]
		private GameObject[] hideInFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		[SerializeField]
		protected Transform headAdditiveBaseBoneTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		[SerializeField]
		private Material BodyMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		[SerializeField]
		private Material FaceMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		[SerializeField]
		private Material DefaultAvatarItemMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		[SerializeField]
		private Shader AvatarDefaultShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		[SerializeField]
		private Shader AvatarUberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		[SerializeField]
		private Transform DeformRigRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		[SerializeField]
		private SkinnedMeshRenderer BaseSkinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		[SerializeField]
		protected AvatarSkinnedMeshBoneOrderRemapsData BoneOrderRemapsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		[SerializeField]
		[Header("Arm Animation Controllers")]
		private AvatarForearmRollController LeftForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		[SerializeField]
		private AvatarElbowBendHelperController LeftElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		[SerializeField]
		private AvatarElbowBendTargetController LeftElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		[SerializeField]
		private AvatarKneeBendTargetController LeftKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		[SerializeField]
		private AvatarForearmRollController RightForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		[SerializeField]
		private AvatarElbowBendHelperController RightElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		[SerializeField]
		private AvatarElbowBendTargetController RightElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		[SerializeField]
		private AvatarKneeBendTargetController RightKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		[SerializeField]
		private Transform LeftEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		[SerializeField]
		private Transform LeftEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		[SerializeField]
		private Transform RightEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		[SerializeField]
		private Transform RightEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		[SerializeField]
		private Transform NoseMoveTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		[SerializeField]
		private Transform NoseScaleTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		[SerializeField]
		private Transform MouthBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		[SerializeField]
		private AvatarBodyPartShapesManager avatarBodyPartShapesManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		[SerializeField]
		private Transform HatAnchorBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		[SerializeField]
		private Transform LeftHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		[SerializeField]
		private Transform RightHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		[SerializeField]
		private GameObject LeftHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		[SerializeField]
		private GameObject RightHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		private NGCNOPAGGEC EMILEOFPLNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		private PBCNDHELJOL KGDDNBHNCBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		private CINJLPKEMIB OLMHDGPJCMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private CINJLPKEMIB KDKLFFPDPMA;

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public NGCNOPAGGEC NKOJGAGHPGN
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x7664410", Offset = "0x7663810", VA = "0x187664410", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public PBCNDHELJOL DDECBBMLBHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x7664460", Offset = "0x7663860", VA = "0x187664460", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public CINJLPKEMIB EABBECOKHJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x76644B0", Offset = "0x76638B0", VA = "0x1876644B0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public CINJLPKEMIB JIOEDJAOIEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x7664500", Offset = "0x7663900", VA = "0x187664500", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public Transform HGDMMGDIIMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x7664550", Offset = "0x7663950", VA = "0x187664550", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public HBFPFNMMLAG PMPLAAMDBJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x99F890", Offset = "0x99EC90", VA = "0x18099F890", Slot = "12")]
			get
			{
				return default(HBFPFNMMLAG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x7663490", Offset = "0x7662890", VA = "0x187663490")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x7664270", Offset = "0x7663670", VA = "0x187664270")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x7663830", Offset = "0x7662C30", VA = "0x187663830", Slot = "8")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x7664270", Offset = "0x7663670", VA = "0x187664270", Slot = "9")]
		public void TeardownAvatarDisplaySystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7663500", Offset = "0x7662900", VA = "0x187663500", Slot = "10")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x7664320", Offset = "0x7663720", VA = "0x187664320")]
		public void UpdatePostIKAnimControllers(float NFEBFCGCNJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x7663400", Offset = "0x7662800", VA = "0x187663400")]
		private void AMCDNMDFLEH(GameObject HAPOBHMBDHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x7663C30", Offset = "0x7663030", VA = "0x187663C30")]
		private NGCNOPAGGEC NNABLDAPMHG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x7663890", Offset = "0x7662C90", VA = "0x187663890")]
		private PBCNDHELJOL JJDNCLADCDL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x7663FE0", Offset = "0x76633E0", VA = "0x187663FE0")]
		private CINJLPKEMIB OOBMMBOFILA(DGCBNGMDALH JJCCEBCOJOP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x7664400", Offset = "0x7663800", VA = "0x187664400")]
		public AvatarModernBodyDisplayBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class MCOHMGPMHLK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private MaterialPropertyBlock LGCKNMHHAEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	public Color? ACIKMDPPDBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	public Color? HFIHNMGGMDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	public Color? LLDONGICDIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	public Color? GKIKFMIJPKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	public Color COJFNICFOBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	public Color AGHECDAAHDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	public Color BKNFDKAHCCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	public Texture2D ILEDOMFCKEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	public Texture2D LAFNNJIBBGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	private Dictionary<KIBGBDABHCI, int> JBCNOPHENLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	private LDPCJHHBCEO[] ICCJFOPMNPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	private LCIJKJOBINF[] BJMGKIPLGKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public Vector4[] IAFOPKFKKDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public Vector4[] EDCNJMAIEJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public Vector4[] MOIFHMEEIKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public Vector4[] FJHFGDLOMPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public Vector4[] HGEKADEBNKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public Vector4[] GHKDMGBEAPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private List<Texture2D> CHHIBNAPNEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private Vector4[] OFLPDCFCGNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private List<Texture2D> OGBOAGAGGGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private float[] HDOOHFHOKDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private Vector4[] HEOONEFGIML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private float[] FBEAFAFMBMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public float[] OKJJPEBJLPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private List<Texture2D> JGIHLNFMECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private float[] ADNFGDKNBBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private List<Texture2D> EBAEIIIKMME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	private Vector4[] KEEIMELGKLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private float[] BFDHLKEGHPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private Vector4[] EHPDPFLAMDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public float[] MHLOMEFAKGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public Texture2DArray DKDLBBJIDEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	public Texture2DArray OAFGNGIPJON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	public Texture2DArray NDINDOMABNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public Texture2DArray NFEBIMCMDCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private bool HPOFGJEPAAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	private int NJNBADHADDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private Vector2? DFDEBBJDIEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private TextureFormat NEBOCOOFLKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private Vector2? MLJDEOCDLDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private TextureFormat BNMKJMOKBHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	private Vector2? GGOCOOEJKID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	private TextureFormat NMBNMFMFIBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private Vector2? NJJCNLGJAPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	private TextureFormat AOFMKHOANIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	private bool AOPCOJBCAIK;

	[Cpp2IlInjected.Token(Token = "0x400024E")]
	private static int FAOMBAGAHMC;

	[Cpp2IlInjected.Token(Token = "0x400024F")]
	private static int EGCFAGBKNDL;

	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private static int KDCGLIAOOFI;

	[Cpp2IlInjected.Token(Token = "0x4000251")]
	private static int FMPKEJFHPJN;

	[Cpp2IlInjected.Token(Token = "0x4000252")]
	private static int CFPJEHLHPLL;

	[Cpp2IlInjected.Token(Token = "0x4000253")]
	private static int HEKDLHBHMPH;

	[Cpp2IlInjected.Token(Token = "0x4000254")]
	private static int JOGMLIEICPD;

	[Cpp2IlInjected.Token(Token = "0x4000255")]
	private static int JAOPEDADDIO;

	[Cpp2IlInjected.Token(Token = "0x4000256")]
	private static int HIAFLELOCHP;

	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private static int IOKFGCNPFND;

	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private static int DCBGBEMKBGH;

	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private static int ADENJEBNHLG;

	[Cpp2IlInjected.Token(Token = "0x400025A")]
	private static int LKOPEELBMCJ;

	[Cpp2IlInjected.Token(Token = "0x400025B")]
	private static int NECLMKPMKJB;

	[Cpp2IlInjected.Token(Token = "0x400025C")]
	private static int PPKFJMCFICL;

	[Cpp2IlInjected.Token(Token = "0x400025D")]
	private static int LIHFHDBALBL;

	[Cpp2IlInjected.Token(Token = "0x400025E")]
	private static int PGOBGAGAAAM;

	[Cpp2IlInjected.Token(Token = "0x400025F")]
	private static int LFMMHDHNHNO;

	[Cpp2IlInjected.Token(Token = "0x4000260")]
	private static int GIHNGKJHNFN;

	[Cpp2IlInjected.Token(Token = "0x4000261")]
	private static int PPFOCFNKDDL;

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x766F1D0", Offset = "0x766E5D0", VA = "0x18766F1D0")]
	private MCOHMGPMHLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x766F110", Offset = "0x766E510", VA = "0x18766F110")]
	public MCOHMGPMHLK(Color DCGOGNIANDK, Color OJJLCJBAPOD, Color BAHNBDAIIEK, Color? OCLIJNPNOOO, Color? IIDCNJJPDAE, Color? APAMALEHKHL, Texture2D KKCOAGCAOAA, Texture2D LLCIDFGPFCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x766EC40", Offset = "0x766E040", VA = "0x18766EC40")]
	internal int NPODCAPKKBB(Material NJDPBFDAGAB, LDPCJHHBCEO LJLEMLICBID, LCIJKJOBINF OHAFHPOHHDO, HKLJDIPJMDE DOIOMNLOJJB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x766ED30", Offset = "0x766E130", VA = "0x18766ED30")]
	private int NPODCAPKKBB(KIBGBDABHCI MCBJECJLDOM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x766CB00", Offset = "0x766BF00", VA = "0x18766CB00")]
	internal int AJIBKJHLKIO(Material NJDPBFDAGAB, Color JINKDGPAFOI, Color GMKOGPIAFBK, Color GBLINBDOHEJ, Color HGHHCNJODAK, Color AAMOKBMLDIK, Texture2D NCAKMBBIKKC, Vector4 EEFEKHIIGGE, Texture2D OKJEECBCGJA, Vector4 PNCHHKFKPDB, float BKFFCPEMAAA, float JDGHAEJHKPH, Texture2D JNMFOHGEDJD, Vector4 MLNNCEKFNDA, float ODKFGKBOMAH, Texture2D DOIBJDMLOFB, Color BJNBGEACOBG, Vector4 BHHBBIDKANK, LDPCJHHBCEO LJLEMLICBID, LCIJKJOBINF OHAFHPOHHDO, HKLJDIPJMDE DOIOMNLOJJB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x766E870", Offset = "0x766DC70", VA = "0x18766E870")]
	private void GNEIPLBFBAA(List<Texture2D> CHHIBNAPNEB, [Out] Texture2DArray HCFBPOJCNGA, [Out] Texture2DArray DJLBGNFMAKM, [Out] Texture2DArray FGEHEIGMDCL, [Out] Texture2DArray MHIECOEGNJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x766E390", Offset = "0x766D790", VA = "0x18766E390")]
	public void DCOBHPNNLED(Shader MEKHHONMPEC, Renderer MNIHJHLOJKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x766D6D0", Offset = "0x766CAD0", VA = "0x18766D6D0")]
	private void BHAGFKMEMLO(Shader MEKHHONMPEC, Renderer MNIHJHLOJKH, int EODBDEMEPIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x766E520", Offset = "0x766D920", VA = "0x18766E520")]
	private Color EPOMIFNEPEC(Color LALCPOOHIPO, LDPCJHHBCEO KACJOCGPGGC)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x766E720", Offset = "0x766DB20", VA = "0x18766E720")]
	private Color FDLIGFGEKAJ(Color EENJHCOCPGJ, LDPCJHHBCEO KACJOCGPGGC)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x766EA30", Offset = "0x766DE30", VA = "0x18766EA30")]
	private bool JODHFGBMFBG(Texture2D PCLPODAAIMD, LCIJKJOBINF HLFCGCADEAN, [Out] Texture2D LCEKDLALBEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x766EB90", Offset = "0x766DF90", VA = "0x18766EB90")]
	private void MHIDHBKKLAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x766E4E0", Offset = "0x766D8E0", VA = "0x18766E4E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public abstract class PBIDJKKFFFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	public readonly HKLJDIPJMDE IKGBLBMMOPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	protected bool HPCNLHMDCKH;

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public bool DONNDHPBHBF
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xBD2B40", Offset = "0xBD1F40", VA = "0x180BD2B40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xBD2770", Offset = "0xBD1B70", VA = "0x180BD2770")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public bool GBPOIGJMMJM
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0xBD2670", Offset = "0xBD1A70", VA = "0x180BD2670")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0xBD2B30", Offset = "0xBD1F30", VA = "0x180BD2B30")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public virtual LDBNJIFCKAL.HECKIELMCBP EFGOCACDJFG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(LDBNJIFCKAL.HECKIELMCBP);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0xBBDA20", Offset = "0xBBCE20", VA = "0x180BBDA20", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool ANENBBPNEKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x11CD3A0", Offset = "0x11CC7A0", VA = "0x1811CD3A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public bool AFFFMIJDEDM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x7674DB0", Offset = "0x76741B0", VA = "0x187674DB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool DOGKLFEHOGM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x7674DC0", Offset = "0x76741C0", VA = "0x187674DC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public bool BIMCGFFJJID
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x7674D90", Offset = "0x7674190", VA = "0x187674D90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x7674DD0", Offset = "0x76741D0", VA = "0x187674DD0")]
	protected PBIDJKKFFFO(HKLJDIPJMDE DGBMDLCEMGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract KMDOHMPCNFD PKNPAJGCANH(List<GCJENIKICGG> KICMOOOALMA, List<GCJENIKICGG> MIEANBHCDON);

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract CKAJJFHNOBF MDEHKLMAIIL(uint BALKEAPIFFL, AvatarSkinnedMeshBoneOrderRemapsData ENKOGNJKOHC);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class NOFABIGJLOG : OMDJCKDLKJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	private AvatarSkinAssetItem BHJNNGIOEDG;

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x7670CC0", Offset = "0x76700C0", VA = "0x187670CC0")]
	public NOFABIGJLOG(AvatarSkinAssetItem GIJBCBMDCNN, AvatarSkinAssetItem.ALKGKEONLCC MPAKHCKMADD, HKLJDIPJMDE DOIOMNLOJJB, [Optional] DFJCNMKOGLJ? PDOJAIKJBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x7670A60", Offset = "0x766FE60", VA = "0x187670A60", Slot = "6")]
	public override KMDOHMPCNFD PKNPAJGCANH(List<GCJENIKICGG> KICMOOOALMA, List<GCJENIKICGG> MIEANBHCDON)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class HOHMNPBCMOM
{
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	private static readonly int[] OBEDDJPFCAN;

	[Cpp2IlInjected.Token(Token = "0x4000269")]
	private static readonly int[] OCJCPCHFNCB;

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public static int[] EJEFGMDBGJH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x76688D0", Offset = "0x7667CD0", VA = "0x1876688D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x7668790", Offset = "0x7667B90", VA = "0x187668790")]
	public static int[] DAAOFIHDGKE(bool HMHNFALOADL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x7668830", Offset = "0x7667C30", VA = "0x187668830")]
	public static int HIPFCCGOEBO(GPKPAEJIOJM POMKLIONODJ, bool HMHNFALOADL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x76688C0", Offset = "0x7667CC0", VA = "0x1876688C0")]
	private static int JHDAFNLOGGI(GPKPAEJIOJM POMKLIONODJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x7668810", Offset = "0x7667C10", VA = "0x187668810")]
	private static int HIMBDMMMEBN(GPKPAEJIOJM POMKLIONODJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class FBHMIDDBCKL
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class IAGLDBHKCFA : IEnumerator<OAGIBKDGOAG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private OAGIBKDGOAG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		private OAGIBKDGOAG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x996A30", Offset = "0x995E30", VA = "0x180996A30")]
		[DebuggerHidden]
		public IAGLDBHKCFA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x115EE20", Offset = "0x115E220", VA = "0x18115EE20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x7668A20", Offset = "0x7667E20", VA = "0x187668A20", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340")]
	public static void JBNPPGGMJMN(string IIKCEJDFBDH, int BALKEAPIFFL, long AIDFIIAELIH, long NJEDPBOPFFJ, long FIPPGJJHNOH, long BEILBCMAAKD, long IJBNJDJBFFK, long DHLLBIFCMJC, long CFKGJHLLEBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x7667260", Offset = "0x7666660", VA = "0x187667260")]
	public static INGHODAMJIF LGEKHOPEJPF(JobHandle LNHMONEHJOC, bool JDGKOELOOHB, bool PAEHAIDBCPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x7667350", Offset = "0x7666750", VA = "0x187667350")]
	[IteratorStateMachine(typeof(IAGLDBHKCFA))]
	private static IEnumerator<OAGIBKDGOAG> POEBDGCJDCJ(JobHandle ENGGEIHHCEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class PLMGICHBIKO
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public enum CBEHGKEFPNK
	{
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		General,
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		ColoredHair
	}

	[Cpp2IlInjected.Token(Token = "0x400026D")]
	public static readonly int MIKIBPKKAOB;

	[Cpp2IlInjected.Token(Token = "0x400026E")]
	public static readonly int NBBEPEPFGNN;

	[Cpp2IlInjected.Token(Token = "0x400026F")]
	public static readonly int LADLCACFOEE;

	[Cpp2IlInjected.Token(Token = "0x4000270")]
	public static readonly int NGINHGHOODB;

	[Cpp2IlInjected.Token(Token = "0x4000271")]
	public static readonly int OAMLGMHNCOL;

	[Cpp2IlInjected.Token(Token = "0x4000272")]
	public static readonly int IEDEBODKAJN;

	[Cpp2IlInjected.Token(Token = "0x4000273")]
	public static readonly int HHINIBPOHPF;

	[Cpp2IlInjected.Token(Token = "0x4000274")]
	public static readonly int MPNDCNIDKKI;

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x7674EC0", Offset = "0x76742C0", VA = "0x187674EC0")]
	public static bool KLOBMFOOCLC(Material KIEAKCEGOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7674E00", Offset = "0x7674200", VA = "0x187674E00")]
	public static bool KKLEDNNBOPM(Material KIEAKCEGOFO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class OMDJCKDLKJI : PBIDJKKFFFO
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class LHJNKMPGGHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public FHGKGMPNNBH<GameObject> skinAvatarItemPrefabHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public OMDJCKDLKJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public Action<string> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public LHJNKMPGGHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x766C120", Offset = "0x766B520", VA = "0x18766C120")]
		internal void CFOJDKAPPFF(GameObject result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x766C4F0", Offset = "0x766B8F0", VA = "0x18766C4F0")]
		internal void CMPABJAKNGP(string error)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	protected AvatarSkinAssetItem FJNIMKNIMNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	protected Material[] JCCPJLBJCAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	private readonly AvatarSkinAssetItem.ALKGKEONLCC COGFCEIIDNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	private readonly AssetReference LCHFEGHDLEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	private readonly DFJCNMKOGLJ? IHIMENGGBJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	private SkinnedMeshRenderer[] EBFDDDLODLK;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public override LDBNJIFCKAL.HECKIELMCBP EFGOCACDJFG
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x993260", Offset = "0x992660", VA = "0x180993260", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(LDBNJIFCKAL.HECKIELMCBP);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x9933E0", Offset = "0x9927E0", VA = "0x1809933E0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x7674C60", Offset = "0x7674060", VA = "0x187674C60")]
	public OMDJCKDLKJI(AvatarSkinAssetItem.ALKGKEONLCC MPAKHCKMADD, AssetReference DDKBGGBBJIG, Material PFPILMJGLMJ, HKLJDIPJMDE DOIOMNLOJJB, LDBNJIFCKAL.HECKIELMCBP GCAODMAKJBI = (LDBNJIFCKAL.HECKIELMCBP)0L, [Optional] DFJCNMKOGLJ? PDOJAIKJBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x7674B40", Offset = "0x7673F40", VA = "0x187674B40")]
	public OMDJCKDLKJI(AvatarSkinAssetItem.ALKGKEONLCC MPAKHCKMADD, AssetReference DDKBGGBBJIG, Material PFPILMJGLMJ, LDBNJIFCKAL.HECKIELMCBP GCAODMAKJBI = (LDBNJIFCKAL.HECKIELMCBP)0L, [Optional] DFJCNMKOGLJ? PDOJAIKJBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x7674900", Offset = "0x7673D00", VA = "0x187674900", Slot = "6")]
	public override KMDOHMPCNFD PKNPAJGCANH(List<GCJENIKICGG> KICMOOOALMA, List<GCJENIKICGG> MIEANBHCDON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x76746F0", Offset = "0x7673AF0", VA = "0x1876746F0", Slot = "7")]
	public override CKAJJFHNOBF MDEHKLMAIIL(uint BALKEAPIFFL, AvatarSkinnedMeshBoneOrderRemapsData ENKOGNJKOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x7674AD0", Offset = "0x7673ED0", VA = "0x187674AD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x76746A0", Offset = "0x7673AA0", VA = "0x1876746A0")]
	protected void FAMHIKANBOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class EMECFMIHABK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	private List<int> BMDGKKCOPIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	private List<BJCDPBLOKKA> GHJDMOINLFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	private HashSet<Transform> EHKEBFKAEOM;

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x76667C0", Offset = "0x7665BC0", VA = "0x1876667C0")]
	public static EMECFMIHABK BEGNLGFEMAJ(Transform CFOOONLCHLJ, Dictionary<Transform, OutfitType?> BJANDFGEHGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x7666D40", Offset = "0x7666140", VA = "0x187666D40")]
	private void FICCICEFAEF(Transform CFOOONLCHLJ, HKLJDIPJMDE DOIOMNLOJJB, Dictionary<Transform, OutfitType?> BJANDFGEHGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x7667000", Offset = "0x7666400", VA = "0x187667000")]
	private void OJNNDHIGKKF(Transform DNBILLMKKLD, HKLJDIPJMDE DOIOMNLOJJB, bool IFNJJPMBFFL, OutfitType? LOGDLPHLLJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x7666950", Offset = "0x7665D50", VA = "0x187666950")]
	public EEGBEDNENJM DFDMDEIMIGA(HashSet<string> CMMNPDDDHGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x7667130", Offset = "0x7666530", VA = "0x187667130")]
	public EMECFMIHABK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class EEGBEDNENJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	private List<BJCDPBLOKKA> GHJDMOINLFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	private List<Matrix4x4> PGLIHDJHGFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private Transform[] IAALHHANBHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	private Matrix4x4[] PHGFKPOILIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	private Dictionary<LJHDEAHCMBN, int> MFCCMDNHPGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	private List<JNDLCDOEOBO> CGCPFPGKNHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	private bool PLGEOOCDFBB;

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public int DLMGPHHMEHB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x7665A30", Offset = "0x7664E30", VA = "0x187665A30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public Transform[] JACOAOFINBA
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x7665E10", Offset = "0x7665210", VA = "0x187665E10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public Matrix4x4[] HOELBBJNEOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x7665DA0", Offset = "0x76651A0", VA = "0x187665DA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x7666460", Offset = "0x7665860", VA = "0x187666460")]
	public void OJNNDHIGKKF(Transform DNBILLMKKLD, HKLJDIPJMDE DOIOMNLOJJB, OutfitType? LOGDLPHLLJH, bool AMFEGGOAFDM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x7666120", Offset = "0x7665520", VA = "0x187666120")]
	private void OJNNDHIGKKF(Transform DNBILLMKKLD, HKLJDIPJMDE DOIOMNLOJJB, OutfitType? LOGDLPHLLJH, bool AMFEGGOAFDM, Matrix4x4 NCHFOGCCEHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x7665F70", Offset = "0x7665370", VA = "0x187665F70")]
	public int KOHBIEBCNBH(LJHDEAHCMBN MCBJECJLDOM, bool NPAGBMDFGNB, [Optional] OutfitType? LOGDLPHLLJH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x7665CA0", Offset = "0x76650A0", VA = "0x187665CA0")]
	public int EOMGHPODHNC(HKLJDIPJMDE DOIOMNLOJJB, [Optional] OutfitType? LOGDLPHLLJH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x7665BB0", Offset = "0x7664FB0", VA = "0x187665BB0")]
	public void EOHOPHINGOH(LJHDEAHCMBN MCBJECJLDOM, Matrix4x4 MLBMLOGLIJP, bool NPAGBMDFGNB = false, [Optional] OutfitType? LOGDLPHLLJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7665A70", Offset = "0x7664E70", VA = "0x187665A70")]
	public Matrix4x4 EHCFBOAJAPC(LJHDEAHCMBN MCBJECJLDOM, bool NPAGBMDFGNB, [Optional] OutfitType? LOGDLPHLLJH)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x1208470", Offset = "0x1207870", VA = "0x181208470")]
	public void KLPJEKJILCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x7666650", Offset = "0x7665A50", VA = "0x187666650")]
	public EEGBEDNENJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct LJHDEAHCMBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public readonly string OCHILIJNFKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public readonly HKLJDIPJMDE FMJEGGKCLMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public readonly OutfitType? BFCEGLHNJGC;

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x766C8C0", Offset = "0x766BCC0", VA = "0x18766C8C0")]
	public LJHDEAHCMBN(string JJCBJKEODPH, HKLJDIPJMDE DOIOMNLOJJB, [Optional] OutfitType? LOGDLPHLLJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x766C810", Offset = "0x766BC10", VA = "0x18766C810", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x766C750", Offset = "0x766BB50", VA = "0x18766C750")]
	public bool OBIILKPNMOB(LJHDEAHCMBN JAPIEEBOJEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x766C630", Offset = "0x766BA30", VA = "0x18766C630", Slot = "0")]
	public override bool Equals(object HAPOBHMBDHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x766C6E0", Offset = "0x766BAE0", VA = "0x18766C6E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct JNDLCDOEOBO : IEquatable<JNDLCDOEOBO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public readonly HKLJDIPJMDE FMJEGGKCLMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public readonly OutfitType? DNJLDBGILKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public readonly int KHECJLJPJGL;

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x766B4A0", Offset = "0x766A8A0", VA = "0x18766B4A0")]
	public JNDLCDOEOBO(HKLJDIPJMDE DOIOMNLOJJB, int PJGLBPCBIIJ, [Optional] OutfitType? LJCEMEFADPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x766B3D0", Offset = "0x766A7D0", VA = "0x18766B3D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x6921700", Offset = "0x6920B00", VA = "0x186921700")]
	public bool EEJOKMFFGJD(HKLJDIPJMDE DOIOMNLOJJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x766B350", Offset = "0x766A750", VA = "0x18766B350")]
	public bool IJAMPIIHNGM(OutfitType? LJCEMEFADPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x766B2B0", Offset = "0x766A6B0", VA = "0x18766B2B0", Slot = "4")]
	public bool Equals(JNDLCDOEOBO JAPIEEBOJEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x766B1C0", Offset = "0x766A5C0", VA = "0x18766B1C0", Slot = "0")]
	public override bool Equals(object HAPOBHMBDHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x766B300", Offset = "0x766A700", VA = "0x18766B300", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct BJCDPBLOKKA : IEquatable<BJCDPBLOKKA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public readonly Transform MGOFPIDNBFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public readonly bool DHKDLJMLNJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public readonly HKLJDIPJMDE NCABLAIAGHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public readonly OutfitType? BFCEGLHNJGC;

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x76649F0", Offset = "0x7663DF0", VA = "0x1876649F0")]
	public BJCDPBLOKKA(Transform DNBILLMKKLD, bool IFNJJPMBFFL, HKLJDIPJMDE NCNMNIBHDGK, [Optional] OutfitType? IPNMPMHGGIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x76647D0", Offset = "0x7663BD0", VA = "0x1876647D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x7664570", Offset = "0x7663970", VA = "0x187664570", Slot = "4")]
	public bool Equals(BJCDPBLOKKA JAPIEEBOJEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x7664670", Offset = "0x7663A70", VA = "0x187664670", Slot = "0")]
	public override bool Equals(object HAPOBHMBDHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x7664750", Offset = "0x7663B50", VA = "0x187664750", Slot = "2")]
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
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public const float DEFAULT_Y_POSITION_OFFSET = 0.04f;

		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public const float MAX_HEMISPHERE_POSITION_OFFSET = 0.05f;

		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public const float MAX_HEMISPHERE_ROTATION_OFFSET = 45f;

		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public const float MAX_HEMISPHERE_SCALE = 2f;

		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public const float MIN_HEMISPHERE_SCALE = 0.75f;

		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public const float MAX_HEMISPHERE_RADIUS = 0.25f;

		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public const float MIN_HEMISPHERE_RADIUS = 0.125f;

		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public static GameObject ContainerGO;

		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public static GameObject CurrentHairHemisphereGO;

		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public static Transform CurrentHairHemisphereMeshTransform;

		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public static FitMeshHemisphereUpdater CurrentHairHemisphereUpdater;

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x76673C0", Offset = "0x76667C0", VA = "0x1876673C0")]
		public static void DespawnHairHemisphere()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340")]
		public void UpdateValues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x991330", Offset = "0x990730", VA = "0x180991330")]
		public FitMeshHemisphereUpdater()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface LENKFLPFNPC
{
	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GKIFFLFABEH(Mesh CNCBOAAEMAB, Matrix4x4 MHENGEAEJHL, byte[] JKBPHIPEBKM, bool MNPLHPGKJOF = false, LDBNJIFCKAL.HECKIELMCBP GHJMLFMOOMI = (LDBNJIFCKAL.HECKIELMCBP)0L, int IMMNIBIAAHO = -1, bool BACJLOEEGNA = false);

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HMLOPKFCOKJ(Allocator LENIJMBFHJK, JNGKKHAFNLF NKAEGFFOLJG, byte EIPJJNGFECD, [Optional] IList<int> AJJFFBOJGHK, [Optional] IList<int> OMCFEBBMLDE);
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public readonly struct CGOMJEHMJKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public readonly GameObject ADOIADHGDCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	private readonly AvatarItemMaterial GHANGLHOOPF;

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x9F9CA0", Offset = "0x9F90A0", VA = "0x1809F9CA0")]
	public CGOMJEHMJKG(GameObject ADOIADHGDCB, AvatarItemMaterial GHANGLHOOPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x76658F0", Offset = "0x7664CF0", VA = "0x1876658F0")]
	public void CGKJCJMFHPG(Material KIEAKCEGOFO, int GDKJNPJDHJB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class KCGKFBIPCLD : NCLNOPENJIK<Task<(GameObject, AvatarItemMaterial)>, CGOMJEHMJKG>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct JHAFCJLEOMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public AsyncTaskMethodBuilder<(GameObject, AvatarItemMaterial)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public Task<GameObject> goTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public Task<AvatarItemMaterial> materialTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		private GameObject <go>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private TaskAwaiter<GameObject> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private TaskAwaiter<AvatarItemMaterial> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x7668A70", Offset = "0x7667E70", VA = "0x187668A70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x7668F70", Offset = "0x7668370", VA = "0x187668F70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	private FHGKGMPNNBH<GameObject> OOHNBPMCDPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	private FHGKGMPNNBH<AvatarItemMaterial> FEJELPPHAMM;

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x766BB20", Offset = "0x766AF20", VA = "0x18766BB20")]
	private KCGKFBIPCLD(Task<(GameObject, AvatarItemMaterial)> ALKPEINKLAJ, FHGKGMPNNBH<GameObject> KJBOMEGMEGD, FHGKGMPNNBH<AvatarItemMaterial> IIOGBGEEFNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x766B4B0", Offset = "0x766A8B0", VA = "0x18766B4B0")]
	public static KCGKFBIPCLD DCJNBNANGBG(AssetReference BEPODPCHFND, [Optional] AssetReference DCKCECKNLNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x766BA80", Offset = "0x766AE80", VA = "0x18766BA80", Slot = "11")]
	protected override CGOMJEHMJKG KIGINBMEIMN(Task<(GameObject, AvatarItemMaterial)> HKMAHIDKKII)
	{
		return default(CGOMJEHMJKG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x766B8D0", Offset = "0x766ACD0", VA = "0x18766B8D0", Slot = "12")]
	protected override void EIABPGCJPCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x766B950", Offset = "0x766AD50", VA = "0x18766B950")]
	[AsyncStateMachine(typeof(JHAFCJLEOMM))]
	private static Task<(GameObject, AvatarItemMaterial)> GNMLMCHALFH(Task<GameObject> HCCAACINPPC, Task<AvatarItemMaterial> LPFKHODACAE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class OBBMFMIICJH
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class GDELCJKKEOJ : NCLNOPENJIK<Task<MaterialMapAsset>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private FHGKGMPNNBH<MaterialMapAsset> ENGGEIHHCEE;

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x76678A0", Offset = "0x7666CA0", VA = "0x1876678A0")]
		public GDELCJKKEOJ(FHGKGMPNNBH<MaterialMapAsset> ENGGEIHHCEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x7667480", Offset = "0x7666880", VA = "0x187667480", Slot = "11")]
		protected override Material[] KIGINBMEIMN(Task<MaterialMapAsset> ALKPEINKLAJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x7667420", Offset = "0x7666820", VA = "0x187667420", Slot = "12")]
		protected override void EIABPGCJPCK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class MAMKNDAEBPO : NCLNOPENJIK<Task<Material[]>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private List<FHGKGMPNNBH<Material>> KKPPEGLJPBD;

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x766CA90", Offset = "0x766BE90", VA = "0x18766CA90")]
		public MAMKNDAEBPO(Task<Material[]> ALKPEINKLAJ, List<FHGKGMPNNBH<Material>> KKPPEGLJPBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x766CA40", Offset = "0x766BE40", VA = "0x18766CA40", Slot = "11")]
		protected override Material[] KIGINBMEIMN(Task<Material[]> HKMAHIDKKII)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x766C900", Offset = "0x766BD00", VA = "0x18766C900", Slot = "12")]
		protected override void EIABPGCJPCK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	private static readonly ABDDJEPKCOD LEMJHEDOKDF;

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x7671D40", Offset = "0x7671140", VA = "0x187671D40")]
	public static FHGKGMPNNBH<Material[]> KIGPDICMNMK(AssetReference[] MCEBEGOIJFF)
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
		public enum MMAIHACBKKN
		{
			[Cpp2IlInjected.Token(Token = "0x4000342")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000343")]
			TeamItem,
			[Cpp2IlInjected.Token(Token = "0x4000344")]
			SkinColor,
			[Cpp2IlInjected.Token(Token = "0x4000345")]
			HairColor,
			[Cpp2IlInjected.Token(Token = "0x4000346")]
			BeardColor,
			[Cpp2IlInjected.Token(Token = "0x4000347")]
			UGCShirtColor
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public enum FKOEJHJHOOO
		{
			[Cpp2IlInjected.Token(Token = "0x4000349")]
			None,
			[Cpp2IlInjected.Token(Token = "0x400034A")]
			HairTexture,
			[Cpp2IlInjected.Token(Token = "0x400034B")]
			BeardTexture,
			[Cpp2IlInjected.Token(Token = "0x400034C")]
			UGCShirtTexture
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public enum KHALDBNDEJF : byte
		{
			[Cpp2IlInjected.Token(Token = "0x400034E")]
			All,
			[Cpp2IlInjected.Token(Token = "0x400034F")]
			LOD0Only,
			[Cpp2IlInjected.Token(Token = "0x4000350")]
			EditorToolAll
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		public struct DOEOHEJNFNP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000351")]
			public readonly Material DHMACONJDOG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000352")]
			public readonly MMAIHACBKKN HNIGNIKBLCI;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000353")]
			public readonly FKOEJHJHOOO JOKICIMICLD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000354")]
			public readonly HKLJDIPJMDE FMJEGGKCLMF;

			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0x766BFF0", Offset = "0x766B3F0", VA = "0x18766BFF0")]
			public DOEOHEJNFNP(Material KIEAKCEGOFO, MMAIHACBKKN LJLEMLICBID, FKOEJHJHOOO OHAFHPOHHDO, HKLJDIPJMDE DOIOMNLOJJB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x7686870", Offset = "0x7685C70", VA = "0x187686870", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x766BBB0", Offset = "0x766AFB0", VA = "0x18766BBB0")]
			public bool OBIILKPNMOB(DOEOHEJNFNP JAPIEEBOJEA)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x76866E0", Offset = "0x7685AE0", VA = "0x1876866E0", Slot = "0")]
			public override bool Equals(object HAPOBHMBDHP)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x76867D0", Offset = "0x7685BD0", VA = "0x1876867D0", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		protected struct JFGCGIHPNDO : IComparable<JFGCGIHPNDO>, IEquatable<JFGCGIHPNDO>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000355")]
			public int OBJHLIDAPJF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000356")]
			public PlayerAvatarDisplayBase CHDHFHDBOKA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000357")]
			public IList<DFJHBHAAICO> NAHJOLKLMLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000358")]
			public AvatarItemBodyType AEPBPABJLMH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000359")]
			public BACEPNDKCHJ PJEIMDOPECH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400035A")]
			public bool CPPKCGIELIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400035B")]
			public int[] BHELONIJEEA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400035C")]
			public float MCHABLFMAOG;

			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x768A970", Offset = "0x7689D70", VA = "0x18768A970", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x768A810", Offset = "0x7689C10", VA = "0x18768A810", Slot = "4")]
			public int CompareTo(JFGCGIHPNDO JAPIEEBOJEA)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x768A830", Offset = "0x7689C30", VA = "0x18768A830", Slot = "5")]
			public bool Equals(JFGCGIHPNDO JAPIEEBOJEA)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		protected abstract class HCGMIJJIGJJ
		{
			[Cpp2IlInjected.Token(Token = "0x200005B")]
			public class CPJEPHOJFLP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000360")]
				public readonly Mesh MDMKJCIAIEC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000361")]
				public readonly Material[] DMHJCMJFFGO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000362")]
				public readonly Transform[] PHJOIOFAAEL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000363")]
				public readonly Matrix4x4[] HAEDNPHPOJF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000364")]
				public readonly Transform DLBPEJABENB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000365")]
				public readonly bool LPFHEBNMMPP;

				[Cpp2IlInjected.Token(Token = "0x60002FB")]
				[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
				protected CPJEPHOJFLP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002FC")]
				[Cpp2IlInjected.Address(RVA = "0x7685990", Offset = "0x7684D90", VA = "0x187685990")]
				public CPJEPHOJFLP(Mesh CNCBOAAEMAB, Material[] PGJGMPKFKLB, bool PGBOJNMCMGF, Transform[] INCLCFIJOIC, Transform OIAPOKNMECG, Matrix4x4[] IMLEKONOKNK)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002FD")]
				[Cpp2IlInjected.Address(RVA = "0x76858D0", Offset = "0x7684CD0", VA = "0x1876858D0")]
				private CPJEPHOJFLP(SkinnedMeshRenderer ABFNJDDAFNF, Material[] CEGIHIOBJEI)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002FE")]
				[Cpp2IlInjected.Address(RVA = "0x76857E0", Offset = "0x7684BE0", VA = "0x1876857E0")]
				private CPJEPHOJFLP(MeshRenderer GNAGHNGKPCH, Transform OIAPOKNMECG, Material[] CEGIHIOBJEI)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002FF")]
				[Cpp2IlInjected.Address(RVA = "0x76854C0", Offset = "0x76848C0", VA = "0x1876854C0")]
				public static CPJEPHOJFLP LFCGPGDKCOF(Renderer MNIHJHLOJKH, Material[] CEGIHIOBJEI)
				{
					return null;
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400035D")]
			public readonly HKLJDIPJMDE FMJEGGKCLMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400035E")]
			public readonly Transform JLIANHGMAKB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400035F")]
			public readonly bool OBLNGLNHJHC;

			[Cpp2IlInjected.Token(Token = "0x1700008C")]
			public virtual bool DONNDHPBHBF
			{
				[Cpp2IlInjected.Token(Token = "0x60002F4")]
				[Cpp2IlInjected.Address(RVA = "0x9DBC10", Offset = "0x9DB010", VA = "0x1809DBC10", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008D")]
			public virtual bool GBPOIGJMMJM
			{
				[Cpp2IlInjected.Token(Token = "0x60002F5")]
				[Cpp2IlInjected.Address(RVA = "0x9DBC10", Offset = "0x9DB010", VA = "0x1809DBC10", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008E")]
			public virtual LDBNJIFCKAL.HECKIELMCBP EFGOCACDJFG
			{
				[Cpp2IlInjected.Token(Token = "0x60002F6")]
				[Cpp2IlInjected.Address(RVA = "0x991350", Offset = "0x990750", VA = "0x180991350", Slot = "6")]
				get
				{
					return default(LDBNJIFCKAL.HECKIELMCBP);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008F")]
			public bool OLINMMLHLHD
			{
				[Cpp2IlInjected.Token(Token = "0x60002F7")]
				[Cpp2IlInjected.Address(RVA = "0x768A120", Offset = "0x7689520", VA = "0x18768A120")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x768A130", Offset = "0x7689530", VA = "0x18768A130")]
			protected HCGMIJJIGJJ(HKLJDIPJMDE DOIOMNLOJJB, Transform NCGCNLAAHAJ, bool LFDGDFOGIDE = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract KMDOHMPCNFD PKNPAJGCANH(List<GCJENIKICGG> KICMOOOALMA, List<GCJENIKICGG> MIEANBHCDON);

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract CPJEPHOJFLP MDEHKLMAIIL(int BALKEAPIFFL, PlayerHandBones JAIHJMDLIID);
		}

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		protected class IMNEHBFFIKM : HCGMIJJIGJJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000366")]
			protected readonly BodyPartLODs EBFDDDLODLK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000367")]
			protected readonly Material[] JCCPJLBJCAE;

			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x768A700", Offset = "0x7689B00", VA = "0x18768A700")]
			public IMNEHBFFIKM(HKLJDIPJMDE DOIOMNLOJJB, BodyPartLODs ENBJCONOKIF, Material PFPILMJGLMJ, [Optional] Transform NCGCNLAAHAJ, bool LFDGDFOGIDE = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x768A600", Offset = "0x7689A00", VA = "0x18768A600", Slot = "7")]
			public override KMDOHMPCNFD PKNPAJGCANH(List<GCJENIKICGG> KICMOOOALMA, List<GCJENIKICGG> MIEANBHCDON)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0x768A440", Offset = "0x7689840", VA = "0x18768A440", Slot = "8")]
			public override CPJEPHOJFLP MDEHKLMAIIL(int BALKEAPIFFL, PlayerHandBones JAIHJMDLIID)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x768A690", Offset = "0x7689A90", VA = "0x18768A690", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005D")]
		protected class FKCGMMANIGH : HCGMIJJIGJJ
		{
			[Cpp2IlInjected.Token(Token = "0x17000090")]
			public override bool DONNDHPBHBF
			{
				[Cpp2IlInjected.Token(Token = "0x6000304")]
				[Cpp2IlInjected.Address(RVA = "0x9AC6E0", Offset = "0x9ABAE0", VA = "0x1809AC6E0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000091")]
			public override bool GBPOIGJMMJM
			{
				[Cpp2IlInjected.Token(Token = "0x6000305")]
				[Cpp2IlInjected.Address(RVA = "0x7689870", Offset = "0x7688C70", VA = "0x187689870", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000092")]
			public CEPIODKIFMN OJINKDAJJMN
			{
				[Cpp2IlInjected.Token(Token = "0x6000306")]
				[Cpp2IlInjected.Address(RVA = "0x993260", Offset = "0x992660", VA = "0x180993260")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000307")]
				[Cpp2IlInjected.Address(RVA = "0x99BAC0", Offset = "0x99AEC0", VA = "0x18099BAC0")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000308")]
			[Cpp2IlInjected.Address(RVA = "0x76899C0", Offset = "0x7688DC0", VA = "0x1876899C0")]
			public FKCGMMANIGH(HKLJDIPJMDE DOIOMNLOJJB, Transform NCGCNLAAHAJ, CEPIODKIFMN AKNKKDBDMJE, bool LFDGDFOGIDE = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0x76898C0", Offset = "0x7688CC0", VA = "0x1876898C0", Slot = "7")]
			public override KMDOHMPCNFD PKNPAJGCANH(List<GCJENIKICGG> KICMOOOALMA, List<GCJENIKICGG> MIEANBHCDON)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0x991350", Offset = "0x990750", VA = "0x180991350", Slot = "8")]
			public override CPJEPHOJFLP MDEHKLMAIIL(int BALKEAPIFFL, PlayerHandBones JAIHJMDLIID)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0x7689950", Offset = "0x7688D50", VA = "0x187689950", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005E")]
		public class BJLAPMEOHGF
		{
			[Cpp2IlInjected.Token(Token = "0x200005F")]
			public enum IPMDNKNOICP
			{
				[Cpp2IlInjected.Token(Token = "0x4000379")]
				PLAYER_PUPPET,
				[Cpp2IlInjected.Token(Token = "0x400037A")]
				PLAYER_DISPLAY_POSER,
				[Cpp2IlInjected.Token(Token = "0x400037B")]
				PLAYER_HAND,
				[Cpp2IlInjected.Token(Token = "0x400037C")]
				STNMONSTERCOSTUME_OPTION_HIDE_EXCEPT_UI,
				[Cpp2IlInjected.Token(Token = "0x400037D")]
				PLAYER_HAND_POINTING,
				[Cpp2IlInjected.Token(Token = "0x400037E")]
				STNMONSTERCOSTUME_OPTION_ALWAYS_HIDE,
				[Cpp2IlInjected.Token(Token = "0x400037F")]
				EDITOR
			}

			[Cpp2IlInjected.Token(Token = "0x4000369")]
			public static readonly int HNLKKIPAODO;

			[Cpp2IlInjected.Token(Token = "0x400036A")]
			public static readonly int HCCGIKKEFLL;

			[Cpp2IlInjected.Token(Token = "0x400036B")]
			public static readonly int JJDHHOPMDFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400036C")]
			protected readonly DGCBNGMDALH JJCCEBCOJOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400036D")]
			protected readonly JAHAFOPLAPB HMAHDMEAGKB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400036E")]
			protected readonly Animator EFBEFFHMKEM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400036F")]
			protected readonly Transform EOKDHLPBFEE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000370")]
			protected readonly Vector3 IFCJMHMPEHM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000371")]
			protected readonly Transform CLLNMDIFKAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000372")]
			protected readonly Vector3 IGEANPMILLK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000373")]
			protected bool JMMOLICAJII;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000374")]
			protected CINJLPKEMIB FHOBEENNILG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000375")]
			protected bool GEECLBHPGEA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x4000376")]
			protected float EPPCGAIICJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000377")]
			protected APCFHKHDALJ<JLDMEMCNCMD> MFMELJFOJPH;

			[Cpp2IlInjected.Token(Token = "0x17000093")]
			public CINJLPKEMIB NNLKFOPJGCN
			{
				[Cpp2IlInjected.Token(Token = "0x600030C")]
				[Cpp2IlInjected.Address(RVA = "0x993280", Offset = "0x992680", VA = "0x180993280")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600030D")]
				[Cpp2IlInjected.Address(RVA = "0x993410", Offset = "0x992810", VA = "0x180993410")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000094")]
			public bool DGKKKJGLBLM
			{
				[Cpp2IlInjected.Token(Token = "0x600030E")]
				[Cpp2IlInjected.Address(RVA = "0xB47850", Offset = "0xB46C50", VA = "0x180B47850")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600030F")]
				[Cpp2IlInjected.Address(RVA = "0x76841F0", Offset = "0x76835F0", VA = "0x1876841F0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000095")]
			public bool AEBHAJLJDGE
			{
				[Cpp2IlInjected.Token(Token = "0x6000310")]
				[Cpp2IlInjected.Address(RVA = "0x9933C0", Offset = "0x9927C0", VA = "0x1809933C0")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000311")]
				[Cpp2IlInjected.Address(RVA = "0x76840D0", Offset = "0x76834D0", VA = "0x1876840D0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000096")]
			public float IHMHGGCMOJH
			{
				[Cpp2IlInjected.Token(Token = "0x6000312")]
				[Cpp2IlInjected.Address(RVA = "0xBD2F80", Offset = "0xBD2380", VA = "0x180BD2F80")]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000313")]
				[Cpp2IlInjected.Address(RVA = "0x7683F00", Offset = "0x7683300", VA = "0x187683F00")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000097")]
			public JLDMEMCNCMD IHGHFAICHLB
			{
				[Cpp2IlInjected.Token(Token = "0x6000314")]
				[Cpp2IlInjected.Address(RVA = "0x7684090", Offset = "0x7683490", VA = "0x187684090")]
				get
				{
					return default(JLDMEMCNCMD);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x76845D0", Offset = "0x76839D0", VA = "0x1876845D0")]
			public bool MHJFJHHKNNJ(JLDMEMCNCMD PHFPCBGHHAF, object HEJFDMJNIGB, IPMDNKNOICP CCLELJLNNPJ)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x76843E0", Offset = "0x76837E0", VA = "0x1876843E0")]
			public bool KCABKJIJCNP(object HEJFDMJNIGB)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x7684E90", Offset = "0x7684290", VA = "0x187684E90")]
			protected BJLAPMEOHGF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x76848A0", Offset = "0x7683CA0", VA = "0x1876848A0")]
			public BJLAPMEOHGF(DGCBNGMDALH JJCCEBCOJOP, CINJLPKEMIB LPHFEEFKDKA, Animator EFBEFFHMKEM, Transform EOKDHLPBFEE, Transform CLLNMDIFKAA, Vector3 IFCJMHMPEHM, Vector3 IGEANPMILLK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0x7683E50", Offset = "0x7683250", VA = "0x187683E50")]
			private void BLBJCELFDOH(ushort HDFEFHPCKPA, ushort IIJCJNMNEAA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0x76844E0", Offset = "0x76838E0", VA = "0x1876844E0")]
			protected void KOKMNHOMGGM(ushort HDFEFHPCKPA, ushort IIJCJNMNEAA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x76842C0", Offset = "0x76836C0", VA = "0x1876842C0")]
			protected void HLLKBLACDHN(ushort HDFEFHPCKPA, ushort IIJCJNMNEAA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x7683C20", Offset = "0x7683020", VA = "0x187683C20")]
			protected void ACJDOEFPOIC(ushort HDFEFHPCKPA, ushort IIJCJNMNEAA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x7683D40", Offset = "0x7683140", VA = "0x187683D40")]
			protected void BINGGGFBNOC(ushort HDFEFHPCKPA, ushort IIJCJNMNEAA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x7684380", Offset = "0x7683780", VA = "0x187684380")]
			protected void IGJPIHGPMJF(ushort HDFEFHPCKPA, ushort IIJCJNMNEAA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x76841A0", Offset = "0x76835A0", VA = "0x1876841A0")]
			protected void GBHKIHPEEFM(ushort HDFEFHPCKPA, ushort IIJCJNMNEAA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x7684040", Offset = "0x7683440", VA = "0x187684040")]
			protected void CPKLBOOIKBP(ushort HDFEFHPCKPA, ushort IIJCJNMNEAA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x76846E0", Offset = "0x7683AE0", VA = "0x1876846E0")]
			protected void PBLLPIMPCMJ(ushort HDFEFHPCKPA, ushort IIJCJNMNEAA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000060")]
		public class FHHLANJAFAF : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x4000380")]
			public const int KHLHEMCOEDH = 16;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000381")]
			protected MaterialPropertyBlock LGCKNMHHAEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000382")]
			public Color? ACIKMDPPDBJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000383")]
			public Color? LLDONGICDIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000384")]
			public Color? GKIKFMIJPKA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000385")]
			public Color COJFNICFOBI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x4000386")]
			public Color AGHECDAAHDK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x4000387")]
			public Color BKNFDKAHCCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000388")]
			public Texture2D ILEDOMFCKEL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000389")]
			public Texture2D LAFNNJIBBGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x400038A")]
			protected Dictionary<DOEOHEJNFNP, int> JBCNOPHENLK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x400038B")]
			protected MMAIHACBKKN[] ICCJFOPMNPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x400038C")]
			public Vector4[] IAFOPKFKKDK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x400038D")]
			public Vector4[] EDCNJMAIEJG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x400038E")]
			public Vector4[] MOIFHMEEIKN;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			public Vector4[] FJHFGDLOMPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x4000390")]
			public Vector4[] HGEKADEBNKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000391")]
			public Vector4[] GHKDMGBEAPI;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000392")]
			protected List<Texture2D> CHHIBNAPNEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000393")]
			protected Vector4[] OFLPDCFCGNE;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
			[Cpp2IlInjected.Token(Token = "0x4000394")]
			protected List<Texture2D> OGBOAGAGGGI;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
			[Cpp2IlInjected.Token(Token = "0x4000395")]
			protected float[] HDOOHFHOKDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
			[Cpp2IlInjected.Token(Token = "0x4000396")]
			protected Vector4[] HEOONEFGIML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x4000397")]
			protected float[] FBEAFAFMBMG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
			[Cpp2IlInjected.Token(Token = "0x4000398")]
			public float[] OKJJPEBJLPC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
			[Cpp2IlInjected.Token(Token = "0x4000399")]
			protected List<Texture2D> JGIHLNFMECA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
			[Cpp2IlInjected.Token(Token = "0x400039A")]
			protected float[] ADNFGDKNBBL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
			[Cpp2IlInjected.Token(Token = "0x400039B")]
			protected List<Texture2D> EBAEIIIKMME;

			[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			protected Vector4[] KEEIMELGKLP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
			[Cpp2IlInjected.Token(Token = "0x400039D")]
			protected float[] BFDHLKEGHPB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
			[Cpp2IlInjected.Token(Token = "0x400039E")]
			protected Vector4[] EHPDPFLAMDI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x400039F")]
			public float[] MHLOMEFAKGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
			[Cpp2IlInjected.Token(Token = "0x40003A0")]
			public Texture2DArray DKDLBBJIDEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x40003A1")]
			public Texture2DArray OAFGNGIPJON;

			[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
			[Cpp2IlInjected.Token(Token = "0x40003A2")]
			public Texture2DArray NDINDOMABNE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
			[Cpp2IlInjected.Token(Token = "0x40003A3")]
			public Texture2DArray NFEBIMCMDCM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x40003A4")]
			protected bool HPOFGJEPAAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
			[Cpp2IlInjected.Token(Token = "0x40003A5")]
			protected int NJNBADHADDF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
			[Cpp2IlInjected.Token(Token = "0x40003A6")]
			protected Vector2? DFDEBBJDIEJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
			[Cpp2IlInjected.Token(Token = "0x40003A7")]
			protected TextureFormat NEBOCOOFLKD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
			[Cpp2IlInjected.Token(Token = "0x40003A8")]
			protected Vector2? MLJDEOCDLDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
			[Cpp2IlInjected.Token(Token = "0x40003A9")]
			protected TextureFormat BNMKJMOKBHM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
			[Cpp2IlInjected.Token(Token = "0x40003AA")]
			protected Vector2? GGOCOOEJKID;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
			[Cpp2IlInjected.Token(Token = "0x40003AB")]
			protected TextureFormat NMBNMFMFIBG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
			[Cpp2IlInjected.Token(Token = "0x40003AC")]
			protected Vector2? NJJCNLGJAPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
			[Cpp2IlInjected.Token(Token = "0x40003AD")]
			protected TextureFormat AOFMKHOANIH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
			[Cpp2IlInjected.Token(Token = "0x40003AE")]
			protected bool AOPCOJBCAIK;

			[Cpp2IlInjected.Token(Token = "0x40003AF")]
			protected static int FAOMBAGAHMC;

			[Cpp2IlInjected.Token(Token = "0x40003B0")]
			protected static int EGCFAGBKNDL;

			[Cpp2IlInjected.Token(Token = "0x40003B1")]
			protected static int KDCGLIAOOFI;

			[Cpp2IlInjected.Token(Token = "0x40003B2")]
			protected static int FMPKEJFHPJN;

			[Cpp2IlInjected.Token(Token = "0x40003B3")]
			protected static int CFPJEHLHPLL;

			[Cpp2IlInjected.Token(Token = "0x40003B4")]
			protected static int HEKDLHBHMPH;

			[Cpp2IlInjected.Token(Token = "0x40003B5")]
			protected static int JOGMLIEICPD;

			[Cpp2IlInjected.Token(Token = "0x40003B6")]
			protected static int JAOPEDADDIO;

			[Cpp2IlInjected.Token(Token = "0x40003B7")]
			protected static int HIAFLELOCHP;

			[Cpp2IlInjected.Token(Token = "0x40003B8")]
			protected static int IOKFGCNPFND;

			[Cpp2IlInjected.Token(Token = "0x40003B9")]
			protected static int DCBGBEMKBGH;

			[Cpp2IlInjected.Token(Token = "0x40003BA")]
			protected static int ADENJEBNHLG;

			[Cpp2IlInjected.Token(Token = "0x40003BB")]
			protected static int LKOPEELBMCJ;

			[Cpp2IlInjected.Token(Token = "0x40003BC")]
			protected static int NECLMKPMKJB;

			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			protected static int PPKFJMCFICL;

			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			protected static int LIHFHDBALBL;

			[Cpp2IlInjected.Token(Token = "0x40003BF")]
			protected static int PGOBGAGAAAM;

			[Cpp2IlInjected.Token(Token = "0x40003C0")]
			protected static int LFMMHDHNHNO;

			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			protected static int GIHNGKJHNFN;

			[Cpp2IlInjected.Token(Token = "0x40003C2")]
			protected static int PPFOCFNKDDL;

			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x76893B0", Offset = "0x76887B0", VA = "0x1876893B0")]
			protected FHHLANJAFAF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x7689320", Offset = "0x7688720", VA = "0x187689320")]
			public FHHLANJAFAF(Color DCGOGNIANDK, Color OJJLCJBAPOD, Color BAHNBDAIIEK, Color? OCLIJNPNOOO, Color? IIDCNJJPDAE, Color? APAMALEHKHL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x7688EE0", Offset = "0x76882E0", VA = "0x187688EE0")]
			public int NPODCAPKKBB(Material NJDPBFDAGAB, MMAIHACBKKN LJLEMLICBID, FKOEJHJHOOO OHAFHPOHHDO, HKLJDIPJMDE DOIOMNLOJJB)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x7688E50", Offset = "0x7688250", VA = "0x187688E50")]
			public int NPODCAPKKBB(DOEOHEJNFNP MCBJECJLDOM)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x7686E40", Offset = "0x7686240", VA = "0x187686E40")]
			public int AJIBKJHLKIO(Material NJDPBFDAGAB, Color JINKDGPAFOI, Color GMKOGPIAFBK, Color GBLINBDOHEJ, Color HGHHCNJODAK, Color AAMOKBMLDIK, Texture2D NCAKMBBIKKC, Vector4 EEFEKHIIGGE, Texture2D OKJEECBCGJA, Vector4 PNCHHKFKPDB, float BKFFCPEMAAA, float JDGHAEJHKPH, Texture2D JNMFOHGEDJD, Vector4 MLNNCEKFNDA, float ODKFGKBOMAH, Texture2D DOIBJDMLOFB, float BHNJCGKIANJ, Color BJNBGEACOBG, Vector4 BHHBBIDKANK, MMAIHACBKKN LJLEMLICBID, FKOEJHJHOOO OHAFHPOHHDO, HKLJDIPJMDE DOIOMNLOJJB)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x7688AB0", Offset = "0x7687EB0", VA = "0x187688AB0")]
			protected void GNEIPLBFBAA([Out] Texture2DArray HCFBPOJCNGA, [Out] Texture2DArray DJLBGNFMAKM, [Out] Texture2DArray FGEHEIGMDCL, [Out] Texture2DArray MHIECOEGNJA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x7688620", Offset = "0x7687A20", VA = "0x187688620")]
			public void DCOBHPNNLED(PlayerAvatarDisplayBase OOOMKGPGMEP, Renderer MNIHJHLOJKH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x7687B30", Offset = "0x7686F30", VA = "0x187687B30")]
			protected void BHAGFKMEMLO(PlayerAvatarDisplayBase OOOMKGPGMEP, Renderer MNIHJHLOJKH, int EODBDEMEPIO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x76888C0", Offset = "0x7687CC0", VA = "0x1876888C0")]
			private Color EPOMIFNEPEC(Color LALCPOOHIPO, MMAIHACBKKN KACJOCGPGGC)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x7688C70", Offset = "0x7688070", VA = "0x187688C70")]
			private Color LINLICHANLC(Color ALEMJCHMOLF, MMAIHACBKKN KACJOCGPGGC)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x7688DC0", Offset = "0x76881C0", VA = "0x187688DC0")]
			protected void MHIDHBKKLAD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x7688880", Offset = "0x7687C80", VA = "0x187688880", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000061")]
		public struct PlayerHandBones
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003C3")]
			public Transform[] LeftHandBones;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003C4")]
			public Transform LeftHandRoot;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003C5")]
			public Transform[] RightHandBones;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003C6")]
			public Transform RightHandRoot;

			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x7692AC0", Offset = "0x7691EC0", VA = "0x187692AC0")]
			public void DGKEICLEGLK(HKLJDIPJMDE DOIOMNLOJJB, [Out] Transform FDNIDHBNFHE, [Out] Transform[] INCLCFIJOIC)
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		protected struct BodyPartLODs
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003C7")]
			public Mesh[] LODs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003C8")]
			public bool UseHandBones;
		}

		[Cpp2IlInjected.Token(Token = "0x2000064")]
		[CompilerGenerated]
		private sealed class FKFFCFBDFJH : IEnumerable<SkinnedMeshRenderer>, IEnumerable, IEnumerator<SkinnedMeshRenderer>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003D0")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003D1")]
			private SkinnedMeshRenderer <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003D2")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003D3")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003D4")]
			private SkinnedMeshRenderer[] <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003D5")]
			private int <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x17000098")]
			SkinnedMeshRenderer IEnumerator<SkinnedMeshRenderer>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600033C")]
				[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000099")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600033E")]
				[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0xDDEBA0", Offset = "0xDDDFA0", VA = "0x180DDEBA0")]
			[DebuggerHidden]
			public FKFFCFBDFJH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x7689A30", Offset = "0x7688E30", VA = "0x187689A30", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x7689CB0", Offset = "0x76890B0", VA = "0x187689CB0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x7689C00", Offset = "0x7689000", VA = "0x187689C00", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<SkinnedMeshRenderer> IEnumerable<SkinnedMeshRenderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x7689C00", Offset = "0x7689000", VA = "0x187689C00", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000065")]
		[CompilerGenerated]
		private sealed class EMEHIAINIKB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003D6")]
			public PlayerAvatarDisplayBase display;

			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public EMEHIAINIKB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x7686D60", Offset = "0x7686160", VA = "0x187686D60")]
			internal bool DOLCJMMIEAL()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class FLOOKAOLCNA : IEnumerator<OAGIBKDGOAG>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003D7")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003D8")]
			private OAGIBKDGOAG <>2__current;

			[Cpp2IlInjected.Token(Token = "0x1700009A")]
			private OAGIBKDGOAG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000346")]
				[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000348")]
				[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x996A30", Offset = "0x995E30", VA = "0x180996A30")]
			[DebuggerHidden]
			public FLOOKAOLCNA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0x7689D00", Offset = "0x7689100", VA = "0x187689D00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0x768A0D0", Offset = "0x76894D0", VA = "0x18768A0D0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000067")]
		[CompilerGenerated]
		private struct OHECCGDCLKK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003DA")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003DB")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003DC")]
			public FNHNCLCJBFE avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003DD")]
			private bool <forceRebuild>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003DE")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x768BE10", Offset = "0x768B210", VA = "0x18768BE10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0x768C630", Offset = "0x768BA30", VA = "0x18768C630", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000068")]
		[CompilerGenerated]
		private sealed class ANJLIDHKDFP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003DF")]
			public string overrideIdentifier;

			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public ANJLIDHKDFP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x7683BF0", Offset = "0x7682FF0", VA = "0x187683BF0")]
			internal bool KPHENABNNCJ(DFJHBHAAICO selection)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000069")]
		[CompilerGenerated]
		private sealed class CNJICGELINL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003E0")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003E1")]
			public AvatarItemBodyType avatarItemBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003E2")]
			public Func<COLCOEKKCIF<Dictionary<string, FHGKGMPNNBH<Texture2D>>>> <>9__2;

			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public CNJICGELINL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x7685210", Offset = "0x7684610", VA = "0x187685210")]
			internal (KPNDCLGPJDN, COLCOEKKCIF<Dictionary<string, FHGKGMPNNBH<Texture2D>>>) EPLCIGKMAIB(Dictionary<string, IKCNPCJGLNP> avatarItems)
			{
				return default((KPNDCLGPJDN, COLCOEKKCIF<Dictionary<string, FHGKGMPNNBH<Texture2D>>>));
			}

			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0x7685410", Offset = "0x7684810", VA = "0x187685410")]
			internal COLCOEKKCIF<Dictionary<string, FHGKGMPNNBH<Texture2D>>> HGGHPGDMIOD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0x7685480", Offset = "0x7684880", VA = "0x187685480")]
			internal void KMBBKICKFPG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006A")]
		[CompilerGenerated]
		private sealed class HDCMHBMEIAE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003E3")]
			public Transform transformToCheck;

			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public HDCMHBMEIAE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x768A190", Offset = "0x7689590", VA = "0x18768A190")]
			internal bool OMLKANNFOLJ(SkinnedMeshRenderer x)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006B")]
		[CompilerGenerated]
		private struct JJDPDFDBLKI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003E4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003E5")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003E6")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003E7")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x768ACD0", Offset = "0x768A0D0", VA = "0x18768ACD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0x768AEA0", Offset = "0x768A2A0", VA = "0x18768AEA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		protected static readonly int MLEGFPBPKIA;

		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		protected static readonly int IABKMFEMJMN;

		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		protected static readonly int HIGEPIGMGLG;

		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		protected static readonly int HDPBFHOJLIJ;

		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		protected static readonly int KDCBCEEGACE;

		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		protected static readonly int COHBPMKKHII;

		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		protected static readonly int[] POAMNININHO;

		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		protected static readonly int[] FIAFIPODFPJ;

		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		protected static readonly int[] BCLBFNPCHCN;

		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		protected static readonly int[] FFMOMJFALDP;

		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		protected static readonly int[] GEKPNNJJGDO;

		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		protected static readonly int[] LKMOFEFOIDF;

		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		protected static List<PlayerAvatarDisplayBase> ONENGBDHGKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		protected KJINMAEGIAJ FLKKOPLICCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		protected bool JCGDOIPNFOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		protected bool LFANGJEKPLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		[SerializeField]
		public AvatarBodyShapeVault BodyShapeVault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		[SerializeField]
		public AvatarFaceShapeVault FaceShapeVault;

		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		protected static readonly int[] GONGDFLLLCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		[SerializeField]
		protected Material bodyPartMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		protected Dictionary<DOEOHEJNFNP, Material> PDCOGMPFLAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		protected Dictionary<DOEOHEJNFNP, Material> OLGCJLPEDCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		[SerializeField]
		protected bool ignorePlayerMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		[SerializeField]
		protected Transform trackingSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		[SerializeField]
		protected BodyPartLODs Head;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		[SerializeField]
		protected BodyPartLODs Ear;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		[SerializeField]
		protected BodyPartLODs Torso;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		[SerializeField]
		protected BodyPartLODs Hand;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		[SerializeField]
		protected BodyPartLODs HandPointing;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		[SerializeField]
		public PlayerHandBones HandBones;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		[SerializeField]
		public Transform remoteMeshBase;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public readonly SkinnedMeshRenderer[] CurrentDefaultSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public readonly SkinnedMeshRenderer[] NextDefaultSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public readonly SkinnedMeshRenderer[] CurrentVisibleInFirstPersonSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public readonly SkinnedMeshRenderer[] NextVisibleInFirstPersonSkinnedMeshRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		[SerializeField]
		public Transform firstPersonMeshBase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		[SerializeField]
		protected Shader uberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		[SerializeField]
		protected Shader agAvatarShader;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		protected Material PNPJKOEJFDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		protected NGCNOPAGGEC MEKAEBHNCCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		private CINJLPKEMIB OLMHDGPJCMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		private CINJLPKEMIB KDKLFFPDPMA;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		protected Material FIDMCAKDCGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		[SerializeField]
		protected Transform headPropAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		[SerializeField]
		protected Transform hatAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		[SerializeField]
		public Transform hemisphereBase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		protected FitMeshHemisphere OBOPDPBDLML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		protected bool GECJBMKLKCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		protected GHDNJFDBFAB NNIDBNHCBJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		protected bool IHGCJANJDGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		protected AnchorParamsRestrictions JAECCAMLMHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		protected bool PJCBBPEJCPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		protected Transform DFFGMCGOACG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		protected bool CPMKHMDEKNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B1")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		protected bool LHFHFLFBJHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		protected Vector3 IEFBMFJEJJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		protected Quaternion HPOGOFEBCGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		protected Vector2 PGLLHBKKPLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		protected FitMeshHemisphere JFMKLPHPEAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		[IJJGDJMELDG(FPABMOGJDEH.SelfAndChildren, false, false, false)]
		[SerializeField]
		protected PlayerFacialAnimatorBase facialAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		[SerializeField]
		protected Transform torsoPropAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		[SerializeField]
		protected Transform torsoRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		[SerializeField]
		protected Transform headRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		[SerializeField]
		protected Transform leftHandRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		[SerializeField]
		protected Transform leftHandDefaultScaleRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		[SerializeField]
		protected Transform rightHandRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		[SerializeField]
		protected Transform rightHandDefaultScaleRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		[SerializeField]
		protected Animator leftHandAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		[SerializeField]
		protected Animator rightHandAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		[SerializeField]
		protected Transform leftHandPointingRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		[SerializeField]
		protected Transform rightHandPointingRoot;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		protected Collider[] OLKOCEAHELB;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		protected Collider[] BIKMNNAFJAG;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		protected BJLAPMEOHGF[] IDGFGJOEBFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		[SerializeField]
		protected Mesh faceMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public Dictionary<Renderer, FHHLANJAFAF> currentPropertyBlocks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		protected Dictionary<Renderer, FHHLANJAFAF> PEFMCJIIIPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		protected EMECFMIHABK IEKGKKOPBNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		protected KPNDCLGPJDN MANBFAAHFLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public GPKPAEJIOJM DistanceBand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x284")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		protected int HFGHNJGCHOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		protected (bool isLodForced, int forcedLOD) BGENCFJCAEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		protected APCFHKHDALJ<JAHAFOPLAPB> MFMELJFOJPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		protected bool DHCFEOADGDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		protected Dictionary<DFJHBHAAICO, List<DOEOHEJNFNP>> LNDLGIGIIMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		protected Dictionary<DFJHBHAAICO, List<DOEOHEJNFNP>> PBPGBIMLFHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		protected readonly Dictionary<string, FHGKGMPNNBH<Texture2D>> PMDNKABIMKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		protected readonly Dictionary<string, FHGKGMPNNBH<Texture2D>> NMAPCGDFHPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		protected bool MJHHPGCACEE;

		[Cpp2IlInjected.Token(Token = "0x400031C")]
		protected static int EKEJHFKHHDF;

		[Cpp2IlInjected.Token(Token = "0x400031D")]
		protected static List<JFGCGIHPNDO> LICOMMDMNDG;

		[Cpp2IlInjected.Token(Token = "0x400031E")]
		protected static List<JFGCGIHPNDO> PHDELLNGDGA;

		[Cpp2IlInjected.Token(Token = "0x400031F")]
		protected static INGHODAMJIF NKJLCCAPDMB;

		[Cpp2IlInjected.Token(Token = "0x4000320")]
		protected static bool FCEPFCMFHFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		protected Color? NKGMGKNIKEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E4")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		protected bool NHMFHIBJLFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		protected Color CLOMMCJHNKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		protected Color MCOIEIOODEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		protected Color BBPMHMMIBGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		protected AvatarHairPattern BEMNGAGFONJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		protected CEPIODKIFMN PHGHDPCHGGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		protected Color EBAPAPLBDPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		protected Color CKNEEGHEBHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		protected AvatarHairPattern LOCMIECKONJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		protected CEPIODKIFMN LJKEKHIFKPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		protected CEPIODKIFMN AAHFEKCNDOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		protected Color AHOFKPBCOJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		private AdditionalFeetData FODEFMFDCFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		protected DFJHBHAAICO? NNBFPENJFGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		protected Texture DFLPNOIOIBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		protected Color FNKFHNDDNGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		protected readonly IList<DFJHBHAAICO> AGIHHHEEGGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		protected readonly IList<DFJHBHAAICO> GGOFEGAKOMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		private AvatarItemBodyType HNMNHLGGIPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		[SerializeField]
		protected AvatarFaceShape _currentFaceShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C8")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		[SerializeField]
		protected AvatarBodyShape _currentBodyShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D0")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		[SerializeField]
		protected OMEFKCHKIOM _currentNoseType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D4")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		[SerializeField]
		protected bool _hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D5")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		protected KHALDBNDEJF NCLKKHABOKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		protected int[] BCAHLCIOMHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E0")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		protected bool EFPKBOMAPNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E8")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		protected int[] EMINGLCIAPM;

		[Cpp2IlInjected.Token(Token = "0x400033D")]
		private static readonly LDBNJIFCKAL.HECKIELMCBP PCICOAGGNGD;

		[Cpp2IlInjected.Token(Token = "0x400033E")]
		private static readonly LDBNJIFCKAL.HECKIELMCBP DCLKJDJPHGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F0")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		protected bool PFELAAOINJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F8")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		protected HDGGCAEIEHM MHMGAFBHCJH;

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public string DBIJKPELDBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x993450", Offset = "0x992850", VA = "0x180993450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x993560", Offset = "0x992960", VA = "0x180993560")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public bool HJMENGGJAGI
		{
			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0xB3E920", Offset = "0xB3DD20", VA = "0x180B3E920")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0xB3DF90", Offset = "0xB3D390", VA = "0x180B3DF90")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public virtual bool LNHPPGHFNII
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x9DBC10", Offset = "0x9DB010", VA = "0x1809DBC10", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public bool JCMKNFJBLJF
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x76825F0", Offset = "0x76819F0", VA = "0x1876825F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public virtual bool NJBLOIABHKE
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x9DBC10", Offset = "0x9DB010", VA = "0x1809DBC10", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public virtual bool MOHIBOIEAKF
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x9AC6E0", Offset = "0x9ABAE0", VA = "0x1809AC6E0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public virtual bool DKCBFFCJBFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x9DBC10", Offset = "0x9DB010", VA = "0x1809DBC10", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public NGCNOPAGGEC KECDLPJKCLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0xA08D60", Offset = "0xA08160", VA = "0x180A08D60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x7682DC0", Offset = "0x76821C0", VA = "0x187682DC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public CINJLPKEMIB EABBECOKHJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0xA0DCC0", Offset = "0xA0D0C0", VA = "0x180A0DCC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x76831C0", Offset = "0x76825C0", VA = "0x1876831C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public CINJLPKEMIB JIOEDJAOIEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0xA17790", Offset = "0xA16B90", VA = "0x180A17790")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x7683490", Offset = "0x7682890", VA = "0x187683490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		protected Material PJPNEGAOELK
		{
			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x767DB20", Offset = "0x767CF20", VA = "0x18767DB20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		protected Material FEDKNFBBHOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x767C8B0", Offset = "0x767BCB0", VA = "0x18767C8B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public bool OGNKNPOLLDM
		{
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x2065E30", Offset = "0x2065230", VA = "0x182065E30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public PlayerFacialAnimatorBase HBOLJAMHCAN
		{
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0xA179A0", Offset = "0xA16DA0", VA = "0x180A179A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public BJLAPMEOHGF[] HFHEOHJMCFK
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x76821C0", Offset = "0x76815C0", VA = "0x1876821C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public BJLAPMEOHGF AELJDMKCDEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x76827F0", Offset = "0x7681BF0", VA = "0x1876827F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public BJLAPMEOHGF OKOCNIMNPBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x7682820", Offset = "0x7681C20", VA = "0x187682820")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public Mesh GCIAAANCIKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0xA181C0", Offset = "0xA175C0", VA = "0x180A181C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		protected EMECFMIHABK NKFJLGCHGJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x767A3E0", Offset = "0x76797E0", VA = "0x18767A3E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		protected KPNDCLGPJDN KILCENABHCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0xA18550", Offset = "0xA17950", VA = "0x180A18550")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x7679450", Offset = "0x7678850", VA = "0x187679450")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		protected bool PAEHAIDBCPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x9AC6E0", Offset = "0x9ABAE0", VA = "0x1809AC6E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public bool PJMOIPLMLEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x76827E0", Offset = "0x7681BE0", VA = "0x1876827E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public int NHAKAFFHFBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x20BAE50", Offset = "0x20BA250", VA = "0x1820BAE50")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x76833D0", Offset = "0x76827D0", VA = "0x1876833D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public int CJHALAFPOPK
		{
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x7683110", Offset = "0x7682510", VA = "0x187683110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		protected virtual bool ADLHLLHBCFL
		{
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x9DBC10", Offset = "0x9DB010", VA = "0x1809DBC10", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		protected virtual int[] OPJJLADDKKC
		{
			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x76771C0", Offset = "0x76765C0", VA = "0x1876771C0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		protected bool LPOINIENKMM
		{
			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x767C830", Offset = "0x767BC30", VA = "0x18767C830")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		protected static bool LBGLAEDABNL
		{
			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x9DBC10", Offset = "0x9DB010", VA = "0x1809DBC10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public bool NNCGPOBDEEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x2415E10", Offset = "0x2415210", VA = "0x182415E10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x76836A0", Offset = "0x7682AA0", VA = "0x1876836A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public IEnumerable<SkinnedMeshRenderer> KJJKHMHPLNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x76820A0", Offset = "0x76814A0", VA = "0x1876820A0")]
			[IteratorStateMachine(typeof(FKFFCFBDFJH))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public bool NFLEONEBCBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x76827D0", Offset = "0x7681BD0", VA = "0x1876827D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x76771B0", Offset = "0x76765B0", VA = "0x1876771B0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public HBFPFNMMLAG JLHDAMOOPGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x7682120", Offset = "0x7681520", VA = "0x187682120")]
			get
			{
				return default(HBFPFNMMLAG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public static bool EABFOCBBMBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x7682560", Offset = "0x7681960", VA = "0x187682560")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		protected static INGHODAMJIF FLLJBAKKDKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x76753A0", Offset = "0x76747A0", VA = "0x1876753A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x7677A40", Offset = "0x7676E40", VA = "0x187677A40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		protected Color LLDONGICDIM
		{
			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x767DD60", Offset = "0x767D160", VA = "0x18767DD60")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		protected Color GKIKFMIJPKA
		{
			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0x767D670", Offset = "0x767CA70", VA = "0x18767D670")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		protected Texture2D DKNIIFPIEGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0x767CEB0", Offset = "0x767C2B0", VA = "0x18767CEB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		protected Color COJFNICFOBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000296")]
			[Cpp2IlInjected.Address(RVA = "0x767D6C0", Offset = "0x767CAC0", VA = "0x18767D6C0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		protected Color AGHECDAAHDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000297")]
			[Cpp2IlInjected.Address(RVA = "0x767C7E0", Offset = "0x767BBE0", VA = "0x18767C7E0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public CEPIODKIFMN HMHBEEPAMAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(RVA = "0x7682180", Offset = "0x7681580", VA = "0x187682180")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		protected Texture2D LNINLDHAMAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000299")]
			[Cpp2IlInjected.Address(RVA = "0x76752A0", Offset = "0x76746A0", VA = "0x1876752A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public float PJLACNHBEBB
		{
			[Cpp2IlInjected.Token(Token = "0x60002A0")]
			[Cpp2IlInjected.Address(RVA = "0x76821A0", Offset = "0x76815A0", VA = "0x1876821A0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public float JBPBJCNGAIC
		{
			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(RVA = "0x76825D0", Offset = "0x76819D0", VA = "0x1876825D0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public bool CJMLJDPFCGG
		{
			[Cpp2IlInjected.Token(Token = "0x60002D5")]
			[Cpp2IlInjected.Address(RVA = "0x122DB90", Offset = "0x122CF90", VA = "0x18122DB90")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x7682B90", Offset = "0x7681F90", VA = "0x187682B90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action CMMIOGBOPLJ
		{
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x7681E00", Offset = "0x7681200", VA = "0x187681E00")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x76828F0", Offset = "0x7681CF0", VA = "0x1876828F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action KLMLMDPCHOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x7681D60", Offset = "0x7681160", VA = "0x187681D60")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x7682850", Offset = "0x7681C50", VA = "0x187682850")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action NCHGMPMDDLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x7681EA0", Offset = "0x76812A0", VA = "0x187681EA0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x7682990", Offset = "0x7681D90", VA = "0x187682990")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action HJECGOMNLLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x7681F40", Offset = "0x7681340", VA = "0x187681F40")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x7682A30", Offset = "0x7681E30", VA = "0x187682A30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<DGCBNGMDALH, JLDMEMCNCMD> EGEHBDFPOKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x7681FE0", Offset = "0x76813E0", VA = "0x187681FE0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x7682AD0", Offset = "0x7681ED0", VA = "0x187682AD0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x767EC20", Offset = "0x767E020", VA = "0x18767EC20")]
		public bool SetDeformation(bool JCGDOIPNFOP, bool LFANGJEKPLM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x767CBE0", Offset = "0x767BFE0", VA = "0x18767CBE0")]
		protected static Material NJCDLJCIHDC(Dictionary<DOEOHEJNFNP, Material> OGCFBEKPICG, Material FJFIJCIEEMO, MMAIHACBKKN LJLEMLICBID, FKOEJHJHOOO OHAFHPOHHDO, HKLJDIPJMDE DOIOMNLOJJB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x767CAC0", Offset = "0x767BEC0", VA = "0x18767CAC0")]
		protected void NIGBAONBNIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x7677DF0", Offset = "0x76771F0", VA = "0x187677DF0")]
		protected bool FIDPMGJPCKB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x7677120", Offset = "0x7676520", VA = "0x187677120")]
		protected void DAJPCECDFGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x76769A0", Offset = "0x7675DA0", VA = "0x1876769A0", Slot = "10")]
		protected virtual void CNLNAHMIHNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x767C690", Offset = "0x767BA90", VA = "0x18767C690")]
		public int MeshesAtLODCount(int PPFILPMAOAN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x7679970", Offset = "0x7678D70", VA = "0x187679970")]
		protected static void HMLDDFMIMEB(Dictionary<DFJHBHAAICO, List<DOEOHEJNFNP>> EBAHFMPNPGP, HCGMIJJIGJJ HAEMGGLCNPI, Material FJFIJCIEEMO, MMAIHACBKKN KACJOCGPGGC, FKOEJHJHOOO HLFCGCADEAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x7675CB0", Offset = "0x76750B0", VA = "0x187675CB0")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x76765A0", Offset = "0x76759A0", VA = "0x1876765A0")]
		protected void CFHPKDDJDKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x767D7E0", Offset = "0x767CBE0", VA = "0x18767D7E0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "11")]
		protected virtual void JLEKGDCOEIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x7675E30", Offset = "0x7675230", VA = "0x187675E30")]
		protected static void BDNHCOMDPBE(List<Material> HMLNMEJDDLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x767BA10", Offset = "0x767AE10", VA = "0x18767BA10")]
		protected static void LKLPLJOBNAJ(Dictionary<DOEOHEJNFNP, Material> OGCFBEKPICG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x767AC00", Offset = "0x767A000", VA = "0x18767AC00")]
		protected static void KCLEABLAFID(Dictionary<Renderer, FHHLANJAFAF> OFPEMIFAHFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x767C9A0", Offset = "0x767BDA0", VA = "0x18767C9A0")]
		protected void NFFMEDFJKKI(SkinnedMeshRenderer[] ONLNKCOHNIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x7678010", Offset = "0x7677410", VA = "0x187678010")]
		protected void FKPLNFJKCMB(SkinnedMeshRenderer ABFNJDDAFNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x76780B0", Offset = "0x76774B0", VA = "0x1876780B0")]
		protected void FKPLNFJKCMB(MeshRenderer GNAGHNGKPCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x7679CE0", Offset = "0x76790E0", VA = "0x187679CE0")]
		protected void IBBCAPOEOGP(List<GCJENIKICGG> HCBFJMCCOJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x76773F0", Offset = "0x76767F0", VA = "0x1876773F0")]
		protected void DLEHBANPABC(Dictionary<string, FHGKGMPNNBH<Texture2D>> EBAHFMPNPGP, bool IDFHJHEGFEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x767C530", Offset = "0x767B930", VA = "0x18767C530")]
		protected void MKOELJDKOAF(Dictionary<DFJHBHAAICO, List<DOEOHEJNFNP>> EBAHFMPNPGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x7679550", Offset = "0x7678950", VA = "0x187679550")]
		public float GetHandOpenClosedAxis(DGCBNGMDALH JJCCEBCOJOP)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x767F4E0", Offset = "0x767E8E0", VA = "0x18767F4E0")]
		public void SetHandOpenClosedAxis(DGCBNGMDALH JJCCEBCOJOP, float MGCHGEDFCIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x7679590", Offset = "0x7678990", VA = "0x187679590")]
		public JLDMEMCNCMD GetHandVisualState(DGCBNGMDALH JJCCEBCOJOP)
		{
			return default(JLDMEMCNCMD);
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x76753F0", Offset = "0x76747F0", VA = "0x1876753F0")]
		public bool AddHandVisualStateToken(DGCBNGMDALH JJCCEBCOJOP, JLDMEMCNCMD KDKGPPBAMNG, object HEJFDMJNIGB, BJLAPMEOHGF.IPMDNKNOICP CCLELJLNNPJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x7680CE0", Offset = "0x76800E0", VA = "0x187680CE0")]
		public void SetWatchHand(DGCBNGMDALH JJCCEBCOJOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x7680DA0", Offset = "0x76801A0", VA = "0x187680DA0")]
		public void SetWatchHands(bool FMEAPPPFAFK, bool FMOFIALPPNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x767E2C0", Offset = "0x767D6C0", VA = "0x18767E2C0")]
		public bool RemoveHandVisualStateToken(DGCBNGMDALH JJCCEBCOJOP, object HEJFDMJNIGB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x7679610", Offset = "0x7678A10", VA = "0x187679610")]
		public bool GetThumbsUpActive(DGCBNGMDALH JJCCEBCOJOP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x7680780", Offset = "0x767FB80", VA = "0x187680780")]
		public void SetThumbsUpActive(DGCBNGMDALH JJCCEBCOJOP, bool JOIJJFMGLMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x76795D0", Offset = "0x76789D0", VA = "0x1876795D0")]
		public bool GetHandshakeActive(DGCBNGMDALH JJCCEBCOJOP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x767F530", Offset = "0x767E930", VA = "0x18767F530")]
		public void SetHandshakeActive(DGCBNGMDALH JJCCEBCOJOP, bool LKIOGLBCMAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x76781F0", Offset = "0x76775F0", VA = "0x1876781F0")]
		public void ForceUpdateHandsVisualState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x7677000", Offset = "0x7676400", VA = "0x187677000")]
		public static void ClearQueuedBuilds()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x767BC80", Offset = "0x767B080", VA = "0x18767BC80")]
		private static void MDMJBBKKIOA(Scene MILOFGFNFDO, LoadSceneMode MBENOAGKGBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x7677930", Offset = "0x7676D30", VA = "0x187677930")]
		protected static void EHLDHBMBIGG(PlayerAvatarDisplayBase BEDHJNBLLKD, List<JFGCGIHPNDO> GJOOMCHLGBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x767DFE0", Offset = "0x767D3E0", VA = "0x18767DFE0")]
		public void Rebuild(bool NBEPOABIKLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x7677250", Offset = "0x7676650", VA = "0x187677250")]
		protected void DJMCDACFIBH(bool NBEPOABIKLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x76772A0", Offset = "0x76766A0", VA = "0x1876772A0", Slot = "12")]
		protected virtual KMDOHMPCNFD DJMCDACFIBH(IList<DFJHBHAAICO> GKHPLNICODL, AvatarItemBodyType AJMKGACCJOK, bool ILDCBNAMPLC, int[] CAICJEOFAIA, bool NBEPOABIKLJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x767BDB0", Offset = "0x767B1B0", VA = "0x18767BDB0")]
		protected static KMDOHMPCNFD MENGAKBDFAA(JFGCGIHPNDO IIJDKJNMJEI, List<JFGCGIHPNDO> GJOOMCHLGBC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x76794F0", Offset = "0x76788F0", VA = "0x1876794F0")]
		[IteratorStateMachine(typeof(FLOOKAOLCNA))]
		protected static IEnumerator<OAGIBKDGOAG> GNHFCGFCGLH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x767AB40", Offset = "0x7679F40", VA = "0x18767AB40")]
		protected static JFGCGIHPNDO KAICBHEKOJI(List<JFGCGIHPNDO> GJOOMCHLGBC)
		{
			return default(JFGCGIHPNDO);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x767ED30", Offset = "0x767E130", VA = "0x18767ED30")]
		[AsyncStateMachine(typeof(OHECCGDCLKK))]
		public Task SetFaceCustomizationSettings(FNHNCLCJBFE ADDEPKOGHPN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x767A400", Offset = "0x7679800", VA = "0x18767A400")]
		public void InitializeFaceFeatures(AvatarConfiguration GFAMKDIHJDC, HBFPFNMMLAG IKONFHFIDLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x76804D0", Offset = "0x767F8D0", VA = "0x1876804D0")]
		public void SetTeamColors(Color? APAMALEHKHL, bool EHHDOCLGBKH, Color HLHBGKJPGEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x11959A0", Offset = "0x1194DA0", VA = "0x1811959A0")]
		private static void OFKPJFCLEAI(Material KIEAKCEGOFO, Color FIIKLGCIAGG, params int[] EDFAFPBGDAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x1195150", Offset = "0x1194550", VA = "0x181195150")]
		private static void HPAKFPKKNLF(Material KIEAKCEGOFO, Texture FIIKLGCIAGG, params int[] EDFAFPBGDAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x767A0D0", Offset = "0x76794D0", VA = "0x18767A0D0")]
		protected void IDPLOLONEJI(Material FFKOMFFNKOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x767AD60", Offset = "0x767A160", VA = "0x18767AD60")]
		protected void KDBBBEGKEBI(Material FFKOMFFNKOA, Color KMGEEMGDHIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x767B190", Offset = "0x767A590", VA = "0x18767B190")]
		protected void KIOIPCIEAOG(Material FFKOMFFNKOA, Color KMGEEMGDHIJ, Color OGJDHGMLKFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x7679EC0", Offset = "0x76792C0", VA = "0x187679EC0")]
		protected void ICNFFFEOCMF(Material FFKOMFFNKOA, Texture2D HLPGJNCKNML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x767DED0", Offset = "0x767D2D0", VA = "0x18767DED0")]
		protected void PPHLPGFCIJL(Material FFKOMFFNKOA, Texture BKMLCHJHFGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x7677730", Offset = "0x7676B30", VA = "0x187677730")]
		protected void ECEGIICGDIK(Action<FHHLANJAFAF> KENJIALEMDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x7676360", Offset = "0x7675760", VA = "0x187676360")]
		protected void CANEDGGEIOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x767AE80", Offset = "0x767A280", VA = "0x18767AE80")]
		protected void KEEJHEGJJPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x767B5F0", Offset = "0x767A9F0", VA = "0x18767B5F0")]
		protected void LDLCKAAEPLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x7675740", Offset = "0x7674B40", VA = "0x187675740")]
		public void ApplyUgcItemOverrides()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x767E680", Offset = "0x767DA80", VA = "0x18767E680")]
		public void SetBeardPrimaryColor([Optional] Color? FMBIOIMNCKI, bool BDJEMLALGFI = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x767E8B0", Offset = "0x767DCB0", VA = "0x18767E8B0")]
		public void SetBeardSecondaryColor([Optional] Color? FMBIOIMNCKI, bool BDJEMLALGFI = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x767E540", Offset = "0x767D940", VA = "0x18767E540")]
		public void SetBeardPattern([Optional] AvatarHairPattern BFDCOHLPKAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x767CD40", Offset = "0x767C140", VA = "0x18767CD40")]
		private void NMDDDIINCMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x7677680", Offset = "0x7676A80", VA = "0x187677680")]
		private bool DPLPENKDIEA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x767F0A0", Offset = "0x767E4A0", VA = "0x18767F0A0")]
		public void SetHairPrimaryColor([Optional] Color? CNILMODKHEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x767F2C0", Offset = "0x767E6C0", VA = "0x18767F2C0")]
		public void SetHairSecondaryColor([Optional] Color? CNILMODKHEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x767EF70", Offset = "0x767E370", VA = "0x18767EF70")]
		public void SetHairPattern([Optional] AvatarHairPattern BFDCOHLPKAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x767E160", Offset = "0x767D560", VA = "0x18767E160")]
		public void RefreshHair()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x767B950", Offset = "0x767AD50", VA = "0x18767B950")]
		private bool LKGPFAFGIDO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x7680310", Offset = "0x767F710", VA = "0x187680310")]
		public void SetSkinColor(Color DCGOGNIANDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x76807D0", Offset = "0x767FBD0", VA = "0x1876807D0")]
		public void SetUgcItemVisualOverrides(DFJHBHAAICO OHHMIFPIBLM, HBFPFNMMLAG IKONFHFIDLD, Texture LJBCFKPCEIM, Color KLKBHIFBICA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x76770D0", Offset = "0x76764D0", VA = "0x1876770D0")]
		public void ClearUgcItemVisualOverrides()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x767EE30", Offset = "0x767E230", VA = "0x18767EE30")]
		public bool SetFaceShape(AvatarFaceShape ADLLKLFHIAN, bool ALGGKGMEBHN = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x767B550", Offset = "0x767A950", VA = "0x18767B550")]
		private void KPPAGHONIKN(KEHGEIMFGPM MDPPHLHBJGE, float FIIKLGCIAGG, bool ONGJOCKLGND = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x76750A0", Offset = "0x76744A0", VA = "0x1876750A0")]
		private void AENJFOJLGNA(GBEFNDEKCBP HHMFNNBCHMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x767C3D0", Offset = "0x767B7D0", VA = "0x18767C3D0")]
		private void MGAOOLCKBDL(BGLIFKJGBNO KMJDCBOCFCF, float FIIKLGCIAGG, bool BDJJKLDPMEH = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x7677890", Offset = "0x7676C90", VA = "0x187677890")]
		private void EGEHIPNAJKJ(BKNDIMCPBGA CEHMONGLABB, float FIIKLGCIAGG, bool HPAAHCHOIPP = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x767C580", Offset = "0x767B980", VA = "0x18767C580")]
		private void MLMOFKNJFOO(FKJJDNFPGPF OKCKMADBPIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x767D420", Offset = "0x767C820", VA = "0x18767D420")]
		private void OCOANBCLMJO(HIKBDGAGLNE DEDGKEAIAAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x767EAE0", Offset = "0x767DEE0", VA = "0x18767EAE0")]
		public bool SetBodyShape(AvatarBodyShape EDJLCMFDJBN, bool ALGGKGMEBHN = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x76801A0", Offset = "0x767F5A0", VA = "0x1876801A0")]
		public bool SetNoseType(OMEFKCHKIOM AJICEFHNLGH, bool ALGGKGMEBHN = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x7680F00", Offset = "0x7680300", VA = "0x187680F00")]
		public bool UpdateFaceAndBodyShapes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x7680180", Offset = "0x767F580", VA = "0x187680180")]
		public bool SetHideEars(bool CODEFBNLOFB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x7680170", Offset = "0x767F570", VA = "0x187680170")]
		public bool SetHelmetHair(KJINMAEGIAJ BIEHKFBNGKN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x767FBD0", Offset = "0x767EFD0", VA = "0x18767FBD0")]
		public void SetHatAnchorParameters(GHDNJFDBFAB EKAPHEKNLKL, bool PFEOIELPOJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x7680E70", Offset = "0x7680270", VA = "0x187680E70")]
		public void SetupDisplayLODs(KHALDBNDEJF FIJGNMLCODN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x7679250", Offset = "0x7678650", VA = "0x187679250")]
		protected int[] GEPKKPBDMDD(KHALDBNDEJF FIJGNMLCODN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x76802D0", Offset = "0x767F6D0", VA = "0x1876802D0")]
		public void SetOutfitSelections(IList<DFJHBHAAICO> GKHPLNICODL, AvatarItemBodyType AJMKGACCJOK, bool NBEPOABIKLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x7680290", Offset = "0x767F690", VA = "0x187680290")]
		public void SetOutfitSelections(IList<DFJHBHAAICO> GKHPLNICODL, AvatarItemBodyType AJMKGACCJOK, bool ILDCBNAMPLC, bool NBEPOABIKLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x7680240", Offset = "0x767F640", VA = "0x187680240")]
		public KMDOHMPCNFD SetOutfitSelections(IList<DFJHBHAAICO> GKHPLNICODL, AvatarItemBodyType AJMKGACCJOK, KHALDBNDEJF FIJGNMLCODN, bool ILDCBNAMPLC, bool ALGGKGMEBHN = false, bool NBEPOABIKLJ = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x767A8F0", Offset = "0x7679CF0", VA = "0x18767A8F0", Slot = "13")]
		protected virtual KMDOHMPCNFD JOOLEICKOFE(IList<DFJHBHAAICO> GKHPLNICODL, AvatarItemBodyType AJMKGACCJOK, bool ILDCBNAMPLC, KHALDBNDEJF FIJGNMLCODN, bool ALGGKGMEBHN, bool NBEPOABIKLJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x7677CF0", Offset = "0x76770F0", VA = "0x187677CF0")]
		protected int[] FFJPCKOFLDO(KHALDBNDEJF FIJGNMLCODN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x991350", Offset = "0x990750", VA = "0x180991350", Slot = "14")]
		protected virtual KPNDCLGPJDN KNJJKFLENKK(AvatarItemBodyType GBHGDGJMNEI, Dictionary<string, IKCNPCJGLNP> NKHKNBMNNAD, Dictionary<string, FHGKGMPNNBH<Texture2D>> PACBAONHKEM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x76796A0", Offset = "0x7678AA0", VA = "0x1876796A0", Slot = "15")]
		protected virtual KMDOHMPCNFD HGEHNKHOFKJ(IList<DFJHBHAAICO> GKHPLNICODL, AvatarItemBodyType AJMKGACCJOK, bool ILDCBNAMPLC, int[] BHELONIJEEA, BACEPNDKCHJ NKNPHGCJGIC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x767CFA0", Offset = "0x767C3A0", VA = "0x18767CFA0", Slot = "16")]
		protected virtual IKCNPCJGLNP OBNKCMIDNOE(CEPIODKIFMN AKNKKDBDMJE, AvatarItemBodyType GBHGDGJMNEI, HKLJDIPJMDE DOIOMNLOJJB, IKCNPCJGLNP MGHECJKOPDG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x991350", Offset = "0x990750", VA = "0x180991350", Slot = "17")]
		protected virtual IKCNPCJGLNP HMPEIFIMCEN(AvatarItemBodyType GBHGDGJMNEI, HKLJDIPJMDE DOIOMNLOJJB, ENLOLIMGIBD CLKKBOEEKDJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x7676920", Offset = "0x7675D20", VA = "0x187676920")]
		protected void CJLGAMPFCON(NLGEAGICHBO DBCNHBNIOOG, LDBNJIFCKAL.HECKIELMCBP KAFHNMAFGLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x767C4B0", Offset = "0x767B8B0", VA = "0x18767C4B0")]
		protected void MHLKBDPAIND(NLGEAGICHBO DBCNHBNIOOG, LDBNJIFCKAL.HECKIELMCBP KAFHNMAFGLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0xD54400", Offset = "0xD53800", VA = "0x180D54400", Slot = "18")]
		protected virtual NLGEAGICHBO IFICOPKDHAH(NLGEAGICHBO DBCNHBNIOOG, HelmetHairStyle KHCBKEJDOKM, bool FDFGCGNDGAI, AvatarItemBodyType AJMKGACCJOK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x7678240", Offset = "0x7677640", VA = "0x187678240")]
		protected NLGEAGICHBO GCLFPAIDOFM(IList<DFJHBHAAICO> GKHPLNICODL, AvatarItemBodyType KOABOHKKMMG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x7676EE0", Offset = "0x76762E0", VA = "0x187676EE0")]
		public void CleanupDisplayResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x767A5A0", Offset = "0x76799A0", VA = "0x18767A5A0")]
		protected void JEJJPPMFEDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x7676030", Offset = "0x7675430", VA = "0x187676030")]
		protected void BJGHOGGMCMF(Transform MMGOIPDNGLF, IEnumerable<SkinnedMeshRenderer> GAOIOJCBEOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x7675F70", Offset = "0x7675370", VA = "0x187675F70")]
		protected LDBNJIFCKAL.HECKIELMCBP BJFLBBHKBIE(LDBNJIFCKAL.HECKIELMCBP MABLMFGFFFE, HKLJDIPJMDE DGBMDLCEMGI)
		{
			return default(LDBNJIFCKAL.HECKIELMCBP);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x76773E0", Offset = "0x76767E0", VA = "0x1876773E0")]
		protected void DKCCADDAPHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x10EDF80", Offset = "0x10ED380", VA = "0x1810EDF80")]
		protected void DHEFAHFLKON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x7677570", Offset = "0x7676970", VA = "0x187677570")]
		protected void DPEJGKIIIEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x7677C00", Offset = "0x7677000", VA = "0x187677C00")]
		[AsyncStateMachine(typeof(JJDPDFDBLKI))]
		protected Task EOGCHBGAEPO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x767B3B0", Offset = "0x767A7B0", VA = "0x18767B3B0")]
		protected static MMAIHACBKKN KMMJPCEJNCJ(HCGMIJJIGJJ AMHAGEDJPLA, int FMGKNOADOPP)
		{
			return default(MMAIHACBKKN);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x767D520", Offset = "0x767C920", VA = "0x18767D520")]
		protected static FKOEJHJHOOO ODBEDNDKMOA(HCGMIJJIGJJ AMHAGEDJPLA, int FMGKNOADOPP)
		{
			return default(FKOEJHJHOOO);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x7679400", Offset = "0x7678800", VA = "0x187679400")]
		protected Transform GLGDKCNHJBK(HKLJDIPJMDE DOIOMNLOJJB, OutfitType LOGDLPHLLJH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x767A650", Offset = "0x7679A50", VA = "0x18767A650")]
		protected void JHFKMFHLPGK(int GDKJNPJDHJB, Material KIEAKCEGOFO, HCGMIJJIGJJ AMHAGEDJPLA, [Out] Texture2D FBGHOJFLHKF, [Out] Vector4 LEHNAICDLJH, [Out] Texture2D DJGMLLDLJJA, [Out] Texture2D LLNBCMBBECG, [Out] Texture2D FLFOMGMAEGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x767B040", Offset = "0x767A440", VA = "0x18767B040")]
		protected void KENDEONDMHC(int GDKJNPJDHJB, Material KIEAKCEGOFO, HCGMIJJIGJJ AMHAGEDJPLA, [Out] Color JINKDGPAFOI, [Out] Color GMKOGPIAFBK, [Out] Color GBLINBDOHEJ, [Out] Color HGHHCNJODAK, [Out] Color AAMOKBMLDIK, [Out] Color BJNBGEACOBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x7678180", Offset = "0x7677580", VA = "0x187678180")]
		protected void FNCLHDLAJAE(Vector3 CPGAKMJDLGB, Quaternion DBFFJKGJHAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x767F580", Offset = "0x767E980", VA = "0x18767F580")]
		public void SetHatAnchorParameters(GHDNJFDBFAB EKAPHEKNLKL, AnchorParamsRestrictions EBHHDMCIBND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x7676A00", Offset = "0x7675E00", VA = "0x187676A00")]
		public static void CalculateHatAnchorParams(FitMeshHemisphere OBOPDPBDLML, Transform DFFGMCGOACG, GHDNJFDBFAB EKAPHEKNLKL, AnchorParamsRestrictions JAECCAMLMHE, [Out] Vector3 PFOFJFECKOD, [Out] Quaternion HKMKFJAMILI, [Out] GHDNJFDBFAB KMNBEPNMEGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x767E3D0", Offset = "0x767D7D0", VA = "0x18767E3D0")]
		public void ResetHatAnchor(Vector2 HLAAHMDIEEM, Vector3 PJADLGDPDKD, Vector3 EIHLCKFOEIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0xA07990", Offset = "0xA06D90", VA = "0x180A07990")]
		public GHPIBBIEJJC GetAnchorParamsRestrictions()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x7675570", Offset = "0x7674970", VA = "0x187675570")]
		public void ApplyBlocks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x76756B0", Offset = "0x7674AB0", VA = "0x1876756B0")]
		public void ApplyHairPattern()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x76754E0", Offset = "0x76748E0", VA = "0x1876754E0")]
		public void ApplyBeardPattern()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x7680EA0", Offset = "0x76802A0", VA = "0x187680EA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x767A4E0", Offset = "0x76798E0", VA = "0x18767A4E0")]
		protected void JCEGBNFEFBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x7680C60", Offset = "0x7680060", VA = "0x187680C60")]
		public void SetWaitForUgcTextureLoads(bool OHLLOEBHPFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x7680B70", Offset = "0x767FF70", VA = "0x187680B70")]
		public void SetUgcTextureParameters(HDGGCAEIEHM NFHKMOGHIBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x7681760", Offset = "0x7680B60", VA = "0x187681760")]
		public PlayerAvatarDisplayBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x767DE40", Offset = "0x767D240", VA = "0x18767DE40")]
		[CompilerGenerated]
		private void PKGENKNKHGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x767BC50", Offset = "0x767B050", VA = "0x18767BC50")]
		[CompilerGenerated]
		private void MCNJEMLOGOI(FHHLANJAFAF NMAEAHGFFHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x767DDB0", Offset = "0x767D1B0", VA = "0x18767DDB0")]
		[CompilerGenerated]
		private void PKEBBMINEPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x767DA80", Offset = "0x767CE80", VA = "0x18767DA80")]
		[CompilerGenerated]
		private void PELHMPNHMND(FHHLANJAFAF NMAEAHGFFHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x7679C50", Offset = "0x7679050", VA = "0x187679C50")]
		[CompilerGenerated]
		private void HMMMPGGDNGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x767A850", Offset = "0x7679C50", VA = "0x18767A850")]
		[CompilerGenerated]
		private void JMOKLGGBKHH(FHHLANJAFAF NMAEAHGFFHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x767C750", Offset = "0x767BB50", VA = "0x18767C750")]
		[CompilerGenerated]
		private void NCHAPJBAIHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x76768D0", Offset = "0x7675CD0", VA = "0x1876768D0")]
		[CompilerGenerated]
		private void CFOMEJDJOCA(FHHLANJAFAF NMAEAHGFFHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x767A350", Offset = "0x7679750", VA = "0x18767A350")]
		[CompilerGenerated]
		private void ILGADCNICKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x7679650", Offset = "0x7678A50", VA = "0x187679650")]
		[CompilerGenerated]
		private void HDOJJELCNGF(FHHLANJAFAF NMAEAHGFFHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x767D750", Offset = "0x767CB50", VA = "0x18767D750")]
		[CompilerGenerated]
		private void OLKLPDOEEDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x7677CD0", Offset = "0x76770D0", VA = "0x187677CD0")]
		[CompilerGenerated]
		private void FDKJKPNPALP(FHHLANJAFAF NMAEAHGFFHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x767BB70", Offset = "0x767AF70", VA = "0x18767BB70")]
		[CompilerGenerated]
		internal static bool LPMFLMOBOMA(Transform IJACJOCDEPI, IEnumerable<SkinnedMeshRenderer> PNNHNHLJGBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x767C470", Offset = "0x767B870", VA = "0x18767C470")]
		[CompilerGenerated]
		private void MGECMONHNIP(FHHLANJAFAF NMAEAHGFFHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x767D710", Offset = "0x767CB10", VA = "0x18767D710")]
		[CompilerGenerated]
		private void OLGMDKBKMDC(FHHLANJAFAF NMAEAHGFFHD)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[ExecuteAlways]
	public class PlayerFacialAnimatorBase : MonoBehaviour, OKEGJBDPDCK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		[CompilerGenerated]
		private struct CFGENENBPAA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000462")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000463")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000464")]
			public FNHNCLCJBFE avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000465")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000466")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0x7684F20", Offset = "0x7684320", VA = "0x187684F20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0x76851B0", Offset = "0x76845B0", VA = "0x1876851B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		[CompilerGenerated]
		private struct EBPBCDGLOJH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000467")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000468")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000469")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400046A")]
			public int eyeSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400046B")]
			public int eyeBrowSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400046C")]
			public int noseSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x400046D")]
			public int mouthSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400046E")]
			public HBFPFNMMLAG avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400046F")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600039E")]
			[Cpp2IlInjected.Address(RVA = "0x7686AA0", Offset = "0x7685EA0", VA = "0x187686AA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0x7686C80", Offset = "0x7686080", VA = "0x187686C80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		[CompilerGenerated]
		private struct IHBJKHOMJAG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000470")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000471")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000472")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000473")]
			public FaceFeatureType featureType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000474")]
			public int selectionIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000475")]
			public HBFPFNMMLAG avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000476")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A0")]
			[Cpp2IlInjected.Address(RVA = "0x768A240", Offset = "0x7689640", VA = "0x18768A240", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A1")]
			[Cpp2IlInjected.Address(RVA = "0x768A3E0", Offset = "0x76897E0", VA = "0x18768A3E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private struct JGOLHCONHFC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000477")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000478")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000479")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400047A")]
			public FNHNCLCJBFE avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400047B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0x768AAC0", Offset = "0x7689EC0", VA = "0x18768AAC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0x768AC70", Offset = "0x768A070", VA = "0x18768AC70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private struct MOKFIDJIAKD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400047C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400047D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400047E")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400047F")]
			public HBFPFNMMLAG avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000480")]
			private TaskAwaiter<BCNJMJKENCK> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x768AF00", Offset = "0x768A300", VA = "0x18768AF00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x768B320", Offset = "0x768A720", VA = "0x18768B320", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		[CompilerGenerated]
		private struct NLPFFHADLIC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000481")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000482")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000483")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000484")]
			public bool forceRebuild;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000485")]
			public HBFPFNMMLAG avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000486")]
			private FaceStyleSet <styleSet>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000487")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x768B380", Offset = "0x768A780", VA = "0x18768B380", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x768B850", Offset = "0x768AC50", VA = "0x18768B850", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		protected const float PLEBCKICAGC = 0.5f;

		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		protected const int APKDCNNMJKH = 5;

		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public static readonly int IdleID;

		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public static readonly int SmileID;

		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public static readonly int HugeSmileID;

		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public static readonly int ScoreID;

		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public static readonly int SadID;

		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public static readonly int DisgustID;

		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public static readonly int HitID;

		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public static readonly int ConcentrateID;

		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public static readonly int KissID;

		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public static readonly int TalkingID;

		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public static readonly int MuteID;

		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public static readonly int AFKID;

		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public static readonly int HappyID;

		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public static readonly int EmoteFlatID;

		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public static readonly int EmoteHappyID;

		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public static readonly int EmoteSadID;

		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public static readonly int EmoteLoveID;

		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public static readonly int EmoteAngryID;

		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public static readonly int EmoteLaughID;

		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public static readonly int EmoteTongueOutID;

		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public static readonly int EmoteGrimacingID;

		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public static readonly int EmoteWinkID;

		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public static readonly int EmoteShockedID;

		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public static readonly int EmoteNauseatedID;

		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public static readonly int EmoteSmileSweatID;

		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public static readonly int EmoteSleepingID;

		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public static readonly int EmoteThinkingID;

		[Cpp2IlInjected.Token(Token = "0x4000405")]
		public static readonly int EmoteSmirkID;

		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public static readonly int EmoteSmileID;

		[Cpp2IlInjected.Token(Token = "0x4000407")]
		protected static readonly Dictionary<GPPNJFFGMEN.EPONHNCNHEG, int> AKECNFLOBKM;

		[Cpp2IlInjected.Token(Token = "0x4000408")]
		[CanBeNull]
		protected static IEnumerable<FaceFeatureType> GDPKPGCNLAB;

		[Cpp2IlInjected.Token(Token = "0x4000409")]
		protected static readonly int LBIGKDOLLGI;

		[Cpp2IlInjected.Token(Token = "0x400040A")]
		protected static readonly int IKBCKLLPJNK;

		[Cpp2IlInjected.Token(Token = "0x400040B")]
		protected static readonly int MELFBHBLNMA;

		[Cpp2IlInjected.Token(Token = "0x400040C")]
		protected static readonly int ODEKIAOCFHL;

		[Cpp2IlInjected.Token(Token = "0x400040D")]
		protected static readonly int KCDCDGECCEJ;

		[Cpp2IlInjected.Token(Token = "0x400040E")]
		protected static readonly int KECLKEPOEBA;

		[Cpp2IlInjected.Token(Token = "0x400040F")]
		protected static readonly int AJCDPFFCHLG;

		[Cpp2IlInjected.Token(Token = "0x4000410")]
		protected static readonly int IDBFOIJAPOD;

		[Cpp2IlInjected.Token(Token = "0x4000411")]
		protected static Vector2 BDDMMLFOOMD;

		[Cpp2IlInjected.Token(Token = "0x4000412")]
		protected static Vector2 OPJJFEFJNDM;

		[Cpp2IlInjected.Token(Token = "0x4000413")]
		protected static Vector2 DHPIFBACGKI;

		[Cpp2IlInjected.Token(Token = "0x4000414")]
		protected static Vector2 FLMJOBPLLEG;

		[Cpp2IlInjected.Token(Token = "0x4000415")]
		protected static Vector2 DLLIAHCFPNA;

		[Cpp2IlInjected.Token(Token = "0x4000416")]
		protected static Vector2 OACNNOCHEIE;

		[Cpp2IlInjected.Token(Token = "0x4000417")]
		protected static Vector2 DAHBHMGGIHI;

		[Cpp2IlInjected.Token(Token = "0x4000418")]
		protected static Vector2 HNODJFBLMJG;

		[Cpp2IlInjected.Token(Token = "0x4000419")]
		protected static Vector2 LCFPFBKIBOP;

		[Cpp2IlInjected.Token(Token = "0x400041A")]
		protected static Vector2 ENPLHDEEJGE;

		[Cpp2IlInjected.Token(Token = "0x400041B")]
		protected static Vector2 IJAENHLFGEM;

		[Cpp2IlInjected.Token(Token = "0x400041C")]
		protected static Vector2 HNLKPCMFIIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		[SerializeField]
		[IJJGDJMELDG(FPABMOGJDEH.Self, false, false, false)]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		[Header("Rendering")]
		[SerializeField]
		public FaceStyleSet faceStyleSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		[SerializeField]
		protected Renderer faceRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		[SerializeField]
		protected float jitterFPS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		[Header("Emotes")]
		[SerializeField]
		public Renderer[] emoteEffectRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		[SerializeField]
		[Header("Modern Avatar Facial Features")]
		[FormerlySerializedAs("fullBodyFaceStyleSet")]
		public FaceStyleSet modernBodyFaceStyleSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		private HBFPFNMMLAG BAODHEBJAKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		private FaceStyleSet ABOBEPBGABA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		[SerializeField]
		protected bool debugEyeJitterInEditor;

		[Cpp2IlInjected.Token(Token = "0x4000426")]
		protected const int ABCFBHPEPMB = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		protected int DCPGBGJNPEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		protected int JDKCABEEGBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		protected int DGFNGHHLKAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		protected int JPOGIGIGHHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		protected Vector2 OPNONKPNLMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		protected float CLAPHPBBMHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		protected float ECDCHAFMOAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		protected float KAJLKADNLMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		protected Vector2 MIIEFOFHCPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		protected float FHEFJCACLGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		protected float PKDLBOMJLAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		protected float MGKOELPDPPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		protected Vector2 BDCAGGIPJKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		protected float MHFDLBKBENG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		protected float BCKFGAPEEFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		protected float KMMDLNLMOAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		protected Vector2 HBEPDGLCNLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		protected float HBFDOGBPGHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		protected float MNNBJONIBPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		protected float ECCHHHNGNBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		protected List<SelectableFaceOption> IHAHLHNDEKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		protected List<SelectableFaceOption> LEBLGNGIPNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		protected List<SelectableFaceOption> AEBKHJDPPEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		protected List<SelectableFaceOption> BIGGNABDDJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		protected Coroutine BEBLJEECJGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		protected int? HIMMAKMIBAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		protected int IDACJBEPEFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		protected int CBHNHIBHGFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		protected int JIPFBKPJBJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		protected int IKNDNIBKFOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		protected int IDFPPPHDEKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		protected int KPLGKKBGBAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		protected Sprite IAFAGGMAOGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		protected Sprite HNKKOEIDGLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		protected Sprite JIHAJHOGCPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		protected Sprite LFINGHFEIGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		protected bool BNKABOLLBHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		protected string DNHCOKLPGDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		protected string ADFHNLGKMKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		protected string HBOPCNDGDPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		protected string HEKJANDFPOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		[ReadOnlyField]
		public Sprite eyeSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		[ReadOnlyField]
		public Sprite leftEyeOnlySprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		[ReadOnlyField]
		public Sprite rightEyeOnlySprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public Color leftEyeColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public Color leftEyeGleamColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public Color rightEyeColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public Color rightEyeGleamColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		[ReadOnlyField]
		public Sprite mouthSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		protected AvatarConfiguration GFAMKDIHJDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		protected BCNJMJKENCK OPELDKCMGOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		private readonly List<Material> LLBOEOLIKPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		protected LLCLPLCGHML PGFEPDAKFFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		protected Dictionary<string, int> MFNGHELJPLF;

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public FaceStyleSet NMDDCIFLNOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0x7692810", Offset = "0x7691C10", VA = "0x187692810")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public bool OENONAGGDKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0xA1FA20", Offset = "0xA1EE20", VA = "0x180A1FA20", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x20876F0", Offset = "0x2086AF0", VA = "0x1820876F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		protected virtual bool OIDHLGIACDN
		{
			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x9DBC10", Offset = "0x9DB010", VA = "0x1809DBC10", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		protected virtual bool CEHGKJAHINO
		{
			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x9AC6E0", Offset = "0x9ABAE0", VA = "0x1809AC6E0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		protected int FAFELDOKBCN
		{
			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x768F5D0", Offset = "0x768E9D0", VA = "0x18768F5D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public Renderer EOPJDKHANJA
		{
			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x993260", Offset = "0x992660", VA = "0x180993260")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public bool HIPDKJFKNCB
		{
			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0xA32580", Offset = "0xA31980", VA = "0x180A32580")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x7692AB0", Offset = "0x7691EB0", VA = "0x187692AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public Renderer[] ODMKHCCENEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x993450", Offset = "0x992850", VA = "0x180993450")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public bool KCKLIHBFMEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x7692850", Offset = "0x7691C50", VA = "0x187692850")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x7692A10", Offset = "0x7691E10", VA = "0x187692A10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		protected int IJDFNBGMJLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x768FC90", Offset = "0x768F090", VA = "0x18768FC90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		protected int PHFBKLOKBMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x768E110", Offset = "0x768D510", VA = "0x18768E110")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		public float HABGGIEEPHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x7692830", Offset = "0x7691C30", VA = "0x187692830")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x76929F0", Offset = "0x7691DF0", VA = "0x1876929F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public PBCNDHELJOL DDECBBMLBHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0xA0C7A0", Offset = "0xA0BBA0", VA = "0x180A0C7A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0xA45790", Offset = "0xA44B90", VA = "0x180A45790")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public BCNJMJKENCK LIIKMLFNJGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000384")]
			[Cpp2IlInjected.Address(RVA = "0xA179B0", Offset = "0xA16DB0", VA = "0x180A179B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000385")]
			[Cpp2IlInjected.Address(RVA = "0x7692970", Offset = "0x7691D70", VA = "0x187692970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public NoseFaceOption NELMNKPPEKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000386")]
			[Cpp2IlInjected.Address(RVA = "0xA09EF0", Offset = "0xA092F0", VA = "0x180A09EF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000387")]
			[Cpp2IlInjected.Address(RVA = "0xA9CC40", Offset = "0xA9C040", VA = "0x180A9CC40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		protected LLCLPLCGHML NIGLMNDIGCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000388")]
			[Cpp2IlInjected.Address(RVA = "0x768D630", Offset = "0x768CA30", VA = "0x18768D630")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action OHPINNPENAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x7692760", Offset = "0x7691B60", VA = "0x187692760")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0x76928C0", Offset = "0x7691CC0", VA = "0x1876928C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x768F280", Offset = "0x768E680", VA = "0x18768F280")]
		public void LocalPlayEmote(GPPNJFFGMEN.EPONHNCNHEG BDFHKDNGDGO, float MFNFKEMBADK = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x768EE10", Offset = "0x768E210", VA = "0x18768EE10")]
		public bool IsEmotePlaying(GPPNJFFGMEN.EPONHNCNHEG BDFHKDNGDGO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x7690760", Offset = "0x768FB60", VA = "0x187690760")]
		public void SetIdleHappy(bool EIJLODLKLIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x768F880", Offset = "0x768EC80", VA = "0x18768F880")]
		protected void NNNPHPJEFPE(bool CJJMJJBGEBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x768C8C0", Offset = "0x768BCC0", VA = "0x18768C8C0")]
		protected void ALGAGHHJJAP(bool ICLDAPFBIAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x768E8D0", Offset = "0x768DCD0", VA = "0x18768E8D0")]
		protected void IMKNKNBBAOF(HKLJDIPJMDE DOIOMNLOJJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x768FF00", Offset = "0x768F300", VA = "0x18768FF00")]
		protected void PNDDDPGNPCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x768FF70", Offset = "0x768F370", VA = "0x18768FF70")]
		public void PlayExpression(int MPPACNLDMMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x768C690", Offset = "0x768BA90", VA = "0x18768C690")]
		protected void AELABHPEFCG(bool AJPNAJCCODM, bool IEDKFIBDOIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x768D880", Offset = "0x768CC80", VA = "0x18768D880")]
		public List<SelectableFaceOption> GetAvailableFeatures(FaceFeatureType IJHEKOHILNP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x768E940", Offset = "0x768DD40", VA = "0x18768E940")]
		public void InitializeFaceFeatureRanges(AvatarConfiguration GFAMKDIHJDC, HBFPFNMMLAG IKONFHFIDLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x7690670", Offset = "0x768FA70", VA = "0x187690670")]
		[AsyncStateMachine(typeof(CFGENENBPAA))]
		public Task SetFaceSettings(FNHNCLCJBFE ADDEPKOGHPN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x7690540", Offset = "0x768F940", VA = "0x187690540")]
		[AsyncStateMachine(typeof(EBPBCDGLOJH))]
		public Task SetFaceSettings(int LLMBPLAIOLB, int OOIOGAPGINO, int JBCMCEILJPD, int CNEBDHJOAJA, HBFPFNMMLAG IKONFHFIDLD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x76907E0", Offset = "0x768FBE0", VA = "0x1876907E0")]
		[AsyncStateMachine(typeof(IHBJKHOMJAG))]
		public Task SetSelectedFaceFeatureAndBuildFaceStyle(FaceFeatureType IJHEKOHILNP, int PKHLIIEHDAI, HBFPFNMMLAG IKONFHFIDLD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x768F700", Offset = "0x768EB00", VA = "0x18768F700")]
		protected void NIBOBBFFMIH(FaceFeatureType IJHEKOHILNP, DFJCNMKOGLJ DPJFAILGLPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x768E170", Offset = "0x768D570", VA = "0x18768E170")]
		protected void IKCHFGDAKIE(FaceFeatureType IJHEKOHILNP, int PKHLIIEHDAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x768D6B0", Offset = "0x768CAB0", VA = "0x18768D6B0")]
		public static IEnumerable<FaceFeatureType> GetAllFaceFeatureTypes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x768EF20", Offset = "0x768E320", VA = "0x18768EF20")]
		[AsyncStateMachine(typeof(JGOLHCONHFC))]
		protected Task JCHLJFAFJDJ(FNHNCLCJBFE ADDEPKOGHPN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x768D330", Offset = "0x768C730", VA = "0x18768D330")]
		protected void GCDFELHNLGH(FNHNCLCJBFE ADDEPKOGHPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x768F010", Offset = "0x768E410", VA = "0x18768F010")]
		protected static void LLCEBOODMPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x768D0D0", Offset = "0x768C4D0", VA = "0x18768D0D0")]
		private void ELELPFMDFDD(bool OHOFCDAGPGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x768F900", Offset = "0x768ED00", VA = "0x18768F900")]
		protected void OKOMBOJJINP(FaceFeatureType IJHEKOHILNP, Vector2 FHBEKBPNIFP, HBFPFNMMLAG IKONFHFIDLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x768FF90", Offset = "0x768F390", VA = "0x18768FF90")]
		public void SetFaceFeatureNormalizedPositionOffset(FaceFeatureType IJHEKOHILNP, Vector2 IFMBMJHOHMK, HBFPFNMMLAG IKONFHFIDLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x768C740", Offset = "0x768BB40", VA = "0x18768C740")]
		protected void AFMJCNHDILA(FaceFeatureType IJHEKOHILNP, float MDFMLLDMNBN, HBFPFNMMLAG IKONFHFIDLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x768F370", Offset = "0x768E770", VA = "0x18768F370")]
		protected void MBIINFMEAAM(FaceFeatureType IJHEKOHILNP, float BENMKDDDBDG, HBFPFNMMLAG IKONFHFIDLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x768CB60", Offset = "0x768BF60", VA = "0x18768CB60")]
		protected void BGJMJJPFADM(FaceFeatureType IJHEKOHILNP, float LNCLJLPOPIK, HBFPFNMMLAG IKONFHFIDLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x7690320", Offset = "0x768F720", VA = "0x187690320")]
		public void SetFaceFeatureNormalizedScaleOffset(FaceFeatureType IJHEKOHILNP, float DDDBPKOCBFL, HBFPFNMMLAG IKONFHFIDLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x768F1A0", Offset = "0x768E5A0", VA = "0x18768F1A0")]
		[AsyncStateMachine(typeof(MOKFIDJIAKD))]
		protected Task LNEHGACJPGJ(HBFPFNMMLAG IKONFHFIDLD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x768EC00", Offset = "0x768E000", VA = "0x18768EC00")]
		public void InitializeFaceFeatureStyleSet(HBFPFNMMLAG IKONFHFIDLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x768F4F0", Offset = "0x768E8F0", VA = "0x18768F4F0")]
		protected bool MMHJBJCFKOJ(string IMFEGLGFAMI, [Out] int KDCAMOIGIMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x768CA20", Offset = "0x768BE20", VA = "0x18768CA20")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x14EF390", Offset = "0x14EE790", VA = "0x1814EF390", Slot = "8")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x768FCF0", Offset = "0x768F0F0", VA = "0x18768FCF0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x7691900", Offset = "0x7690D00", VA = "0x187691900")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x768CC30", Offset = "0x768C030", VA = "0x18768CC30")]
		[AsyncStateMachine(typeof(NLPFFHADLIC))]
		public Task BuildFaceStyleAsyncIfChanged(HBFPFNMMLAG IKONFHFIDLD, bool ALGGKGMEBHN = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x7691220", Offset = "0x7690620", VA = "0x187691220")]
		public void UpdateFaceDisplays(bool KIPJEGGKJIB = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x768D8C0", Offset = "0x768CCC0", VA = "0x18768D8C0")]
		protected bool HFIHKHJMAMN(bool KIPJEGGKJIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x7690F40", Offset = "0x7690340", VA = "0x187690F40")]
		public void UpdateFaceDisplayFeatureTextures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x76908F0", Offset = "0x768FCF0", VA = "0x1876908F0")]
		public void UpdateFaceDisplayFeaturePositions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x7691430", Offset = "0x7690830", VA = "0x187691430")]
		public void UpdateFaceJitterMultiplier()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x7691620", Offset = "0x7690A20", VA = "0x187691620")]
		public bool UpdateLegacyFaceVectors()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x768CD30", Offset = "0x768C130", VA = "0x18768CD30")]
		protected void CBEAKPCKEMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x768CE20", Offset = "0x768C220", VA = "0x18768CE20")]
		private void CKHJPKMAMLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x7692510", Offset = "0x7691910", VA = "0x187692510")]
		public PlayerFacialAnimatorBase()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x9BDB30", Offset = "0x9BCF30", VA = "0x1809BDB30", Slot = "4")]
		private bool DBFPPDPFIPJ()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct BIMDKGDCAGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public string EDDDAEGNADF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public int PEOBHBKAJCM;
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[ExecuteInEditMode]
	[SelectionBase]
	public class PlayerModernBodyEditorAvatarValidator : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000076")]
		[CompilerGenerated]
		private struct DOACGONLLBM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004E9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004EA")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004EB")]
			public PlayerModernBodyEditorAvatarValidator <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004EC")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003DB")]
			[Cpp2IlInjected.Address(RVA = "0x76864E0", Offset = "0x76858E0", VA = "0x1876864E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0x9E0290", Offset = "0x9DF690", VA = "0x1809E0290", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000077")]
		[CompilerGenerated]
		private struct OCNBCINEKAB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004ED")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004EE")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004EF")]
			public PlayerModernBodyEditorAvatarValidator <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004F0")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0x768B8B0", Offset = "0x768ACB0", VA = "0x18768B8B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DE")]
			[Cpp2IlInjected.Address(RVA = "0x768BDB0", Offset = "0x768B1B0", VA = "0x18768BDB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public const string IDLE_ANIM_NAME = "Idle";

		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public const string A_POSE_ANIM_NAME = "A Pose";

		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public const string ANIMATION_OVERRIDE_STATE_NAME = "Override";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public HBFPFNMMLAG avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public Color hairPrimaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public Color hairSecondaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public Color beardPrimaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public Color beardSecondaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public Color skinColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public int faceShapeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public int bodyShapeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public int hairPatternIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public int beardPatternIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public AvatarFaceShape[] faceShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public AvatarBodyShape[] bodyShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public AvatarHairPattern[] hairPatterns;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public float _avatarScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public bool enablePosing;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public int poseIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public AnimationClip animationOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		[Range(0f, 4f)]
		public float animationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public KJINMAEGIAJ useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public GHDNJFDBFAB hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public GHPIBBIEJJC HatAnchorRestrictions;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public bool UseHairFitMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD1")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public bool usesHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public GameObject hatPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public GameObject hairPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public GameObject earPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public GameObject eyePrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public GameObject mouthPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public GameObject neckPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public GameObject shirtPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public GameObject beltPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public GameObject shoulderPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public GameObject rightHandPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public GameObject leftHandPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public GameObject legsPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public GameObject feetPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public long baseSkinCullingMask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		[SerializeField]
		[IJJGDJMELDG(FPABMOGJDEH.Self, false, false, false)]
		public PlayerAvatarDisplayBase _avatarDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		private PAHJFAGMNMK GNNKCCBMAAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		[SerializeField]
		[IJJGDJMELDG(FPABMOGJDEH.Self, false, false, false)]
		public PlayerFacialAnimatorBase facialAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public AnimationClip animationClipToOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		private AnimatorOverrideController OIBDHCIKOAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		private List<KeyValuePair<AnimationClip, AnimationClip>> PFALADPIHNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public Transform headIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public Transform leftHandIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public Transform rightHandIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		[Range(0f, 2f)]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public int rightHandGestureStateIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		[Range(0f, 1f)]
		public float rightHandCurl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public int leftHandGestureStateIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		[Range(0f, 1f)]
		public float leftHandCurl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public int eyeBrowSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public int eyeSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public int noseSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public int mouthSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public float eyeBrowPositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public float eyeBrowPositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public float eyeBrowScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public float eyePositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public float eyePositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public float eyeScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D4")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public float nosePositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public float noseScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1DC")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public float mouthPositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public float mouthPositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E4")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public float mouthScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public float hatNormalizedPositionX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EC")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public float hatNormalizedPositionY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public Vector3 hatHemispherePositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1FC")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public Vector3 hatHemisphereRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public int facialExpressionIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20C")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		[Range(0f, 1f)]
		public float normalizedTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public readonly BIMDKGDCAGG[] FacialExpressions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public readonly string[] BodyPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public readonly (string, JLDMEMCNCMD)[] HandPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public bool hideLeftWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x229")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public bool hideRightWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22A")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		protected bool HMNABFCOFHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22C")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		protected Guid BEIEHLEAGCH;

		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		protected static Guid NNKFNCILEAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		private NGCNOPAGGEC EMILEOFPLNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		private PBCNDHELJOL KGDDNBHNCBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		private CINJLPKEMIB OLMHDGPJCMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		private CINJLPKEMIB KDKLFFPDPMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		private AdditionalHatData OFEPAKJNACP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		private readonly Dictionary<GameObject, CEPIODKIFMN> PHOHPACIBPD;

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public static Func<ENLOLIMGIBD> CDANGDLPFMP
		{
			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x7697A80", Offset = "0x7696E80", VA = "0x187697A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x76980C0", Offset = "0x76974C0", VA = "0x1876980C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public bool LKGPFAFGIDO
		{
			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x7697BE0", Offset = "0x7696FE0", VA = "0x187697BE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		public bool DPLPENKDIEA
		{
			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x7697AD0", Offset = "0x7696ED0", VA = "0x187697AD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public PlayerAvatarDisplayBase OOOMKGPGMEP
		{
			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0xA0DCC0", Offset = "0xA0D0C0", VA = "0x180A0DCC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		protected static Guid DPAIMPKACPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x7692B70", Offset = "0x7691F70", VA = "0x187692B70")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public (GameObject, HKLJDIPJMDE)[] DBIIDEOGKFA
		{
			[Cpp2IlInjected.Token(Token = "0x60003C5")]
			[Cpp2IlInjected.Address(RVA = "0x7697CF0", Offset = "0x76970F0", VA = "0x187697CF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x76957F0", Offset = "0x7694BF0", VA = "0x1876957F0")]
		[ContextMenu("Refresh Avatar")]
		private void RebuildTestAvatarContextMenu()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x7695050", Offset = "0x7694450", VA = "0x187695050")]
		private IEnumerable<GameObject> OIJIPANEOLH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x7695CE0", Offset = "0x76950E0", VA = "0x187695CE0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x7694BA0", Offset = "0x7693FA0", VA = "0x187694BA0")]
		private void JJLLOBGNDHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x1178F90", Offset = "0x1178390", VA = "0x181178F90")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x76944A0", Offset = "0x76938A0", VA = "0x1876944A0")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x7695CF0", Offset = "0x76950F0", VA = "0x187695CF0")]
		public void Teardown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x7695AE0", Offset = "0x7694EE0", VA = "0x187695AE0")]
		public void ShowPose(AnimationClip EJCOJFKNPBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x7695CB0", Offset = "0x76950B0", VA = "0x187695CB0")]
		public void ShowPose(string GNLHHHOEFLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x7695940", Offset = "0x7694D40", VA = "0x187695940")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x7695800", Offset = "0x7694C00", VA = "0x187695800")]
		public void ResetHandPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x76967C0", Offset = "0x7695BC0", VA = "0x1876967C0")]
		public void UpdateHandAnimation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x7696610", Offset = "0x7695A10", VA = "0x187696610")]
		public void UpdateFaceAndBodyShapes(bool ALGGKGMEBHN = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x7696BC0", Offset = "0x7695FC0", VA = "0x187696BC0")]
		public void UpdateNoseShape(OMEFKCHKIOM AJICEFHNLGH, bool ALGGKGMEBHN = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x7696B90", Offset = "0x7695F90", VA = "0x187696B90")]
		public void UpdateLODOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x76954E0", Offset = "0x76948E0", VA = "0x1876954E0", Slot = "4")]
		protected virtual void ONBALNKGPDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x7694DE0", Offset = "0x76941E0", VA = "0x187694DE0", Slot = "5")]
		protected virtual void MOODBMDAHFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x7692ED0", Offset = "0x76922D0", VA = "0x187692ED0")]
		public void ApplyHatData(AdditionalHatData BIECGLDOFEE, bool NDEHCJPFJPM = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x7692D10", Offset = "0x7692110", VA = "0x187692D10")]
		public void ApplyHatAdjustmentsToHatAnchorParams()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x7693230", Offset = "0x7692630", VA = "0x187693230")]
		public void ApplyHatUVOverride(Vector2 LEADAAOENED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x7693150", Offset = "0x7692550", VA = "0x187693150")]
		public void ApplyHatPositionAdjustment(Vector3 PFNLCHCGDCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x76931C0", Offset = "0x76925C0", VA = "0x1876931C0")]
		public void ApplyHatRotationAdjustment(Vector3 MMDAKGNPPAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x7693560", Offset = "0x7692960", VA = "0x187693560")]
		public DFJHBHAAICO BuildAvatarItemSelection(GameObject KPLAGEOFMPP, HBFPFNMMLAG GBHGDGJMNEI, HKLJDIPJMDE DOGEJFLHEAM)
		{
			return default(DFJHBHAAICO);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x7693600", Offset = "0x7692A00", VA = "0x187693600")]
		public void BuildAvatar(bool ALGGKGMEBHN = false, bool NDEHCJPFJPM = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x7696050", Offset = "0x7695450", VA = "0x187696050")]
		public void UpdateColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x7692E50", Offset = "0x7692250", VA = "0x187692E50")]
		public void ApplyHatAnchor()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x76969E0", Offset = "0x7695DE0", VA = "0x1876969E0")]
		public void UpdateHatAnchor(bool NDEHCJPFJPM = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x7696710", Offset = "0x7695B10", VA = "0x187696710")]
		[AsyncStateMachine(typeof(DOACGONLLBM))]
		public void UpdateFaceFeatures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x7694C80", Offset = "0x7694080", VA = "0x187694C80")]
		[AsyncStateMachine(typeof(OCNBCINEKAB))]
		private Task JOFAIGEMOLI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x76932A0", Offset = "0x76926A0", VA = "0x1876932A0")]
		private void BGNOJHBICFK(FaceFeatureType GLHIEONCNME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x7694D50", Offset = "0x7694150", VA = "0x187694D50")]
		private void JPHLNOCDPLB(FaceFeatureType GLHIEONCNME, [Out] float IJIEHIGPDIK, [Out] float PJMMOHLNFPP, [Out] float PGJAFHMCBJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x76964D0", Offset = "0x76958D0", VA = "0x1876964D0")]
		public void UpdateEmote()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x7696870", Offset = "0x7695C70", VA = "0x187696870")]
		public void UpdateHandPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x7693C10", Offset = "0x7693010", VA = "0x187693C10")]
		private void CKGIJPCFCKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340")]
		private void ILHCLLDDNMH(CEPIODKIFMN AKNKKDBDMJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340")]
		private void LDLNOLCNFBE(CEPIODKIFMN AKNKKDBDMJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x7694140", Offset = "0x7693540", VA = "0x187694140")]
		private void DOOEMPNOFEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x7696C40", Offset = "0x7696040", VA = "0x187696C40")]
		public PlayerModernBodyEditorAvatarValidator()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x7692C60", Offset = "0x7692060", VA = "0x187692C60")]
		[CompilerGenerated]
		private DFJHBHAAICO ALLACOAIOJB((GameObject, HKLJDIPJMDE) LGDNJAKEGGM)
		{
			return default(DFJHBHAAICO);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class SkinnedMeshBonesInspector : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		[IJJGDJMELDG(FPABMOGJDEH.Self, false, false, false)]
		[SerializeField]
		private SkinnedMeshRenderer skinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		[SerializeField]
		private int BoneWeightsDisplayStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		[SerializeField]
		private int BoneWeightsDisplayAmount;

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x991330", Offset = "0x990730", VA = "0x180991330")]
		public SkinnedMeshBonesInspector()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct DFJHBHAAICO
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class ELLGODBMAHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public IEnumerable<OutfitType> otherOutfitTypes;

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public ELLGODBMAHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x7686CE0", Offset = "0x76860E0", VA = "0x187686CE0")]
		internal bool KINOFMFCCGF(OutfitType outfitType)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	private CEPIODKIFMN COFMGMBHICL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	private HKLJDIPJMDE KFMPKDCEFAC;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public CEPIODKIFMN OJINKDAJJMN
	{
		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0xC67BB0", Offset = "0xC66FB0", VA = "0x180C67BB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public HKLJDIPJMDE FMJEGGKCLMF
	{
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0xC67CD0", Offset = "0xC670D0", VA = "0x180C67CD0")]
		get
		{
			return default(HKLJDIPJMDE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public string NKNJNHDLEDP
	{
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x7686030", Offset = "0x7685430", VA = "0x187686030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public bool LJLBICAKPIH
	{
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x7686490", Offset = "0x7685890", VA = "0x187686490")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public bool LPGMKMPMNEL
	{
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x76861E0", Offset = "0x76855E0", VA = "0x1876861E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x1681620", Offset = "0x1680A20", VA = "0x181681620")]
	public DFJHBHAAICO(CEPIODKIFMN AKNKKDBDMJE, HKLJDIPJMDE DOIOMNLOJJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x7686120", Offset = "0x7685520", VA = "0x187686120")]
	public bool HCMMIIAOLAK(OutfitType JCPMIPNOEAG, HKLJDIPJMDE BIHLBAEPPJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x7686230", Offset = "0x7685630", VA = "0x187686230")]
	public bool KFPFDMPOPKB(OutfitType JCPMIPNOEAG, HKLJDIPJMDE BIHLBAEPPJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x7685E40", Offset = "0x7685240", VA = "0x187685E40")]
	public bool AMGAPDFEBKF(DFJHBHAAICO KKEHOJCIOPF)
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
