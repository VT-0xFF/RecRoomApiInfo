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
	public class LogRegistrationIndex : BDONJGGEMII
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x76C9000", Offset = "0x76C8400", VA = "0x1876C9000", Slot = "4")]
		public override void GEAMIGHEOPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9BE830", Offset = "0x9BDC30", VA = "0x1809BE830")]
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
			[Cpp2IlInjected.Address(RVA = "0x994360", Offset = "0x993760", VA = "0x180994360", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override string AssetGUID
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x76CB680", Offset = "0x76CAA80", VA = "0x1876CB680", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x76CB610", Offset = "0x76CAA10", VA = "0x1876CB610", Slot = "17")]
		public override bool RuntimeKeyIsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x76CB640", Offset = "0x76CAA40", VA = "0x1876CB640")]
		public RecNetCDNAssetReference(RecNetCDNKey DJBLFBEBKGO)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class RecNetCDNKey
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public enum HECPALDOCEK : byte
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
			[Cpp2IlInjected.Address(RVA = "0x9943E0", Offset = "0x9937E0", VA = "0x1809943E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x994500", Offset = "0x993900", VA = "0x180994500")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string UniqueItemIdentifier
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x993210", Offset = "0x992610", VA = "0x180993210")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string CacheHash
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x9931D0", Offset = "0x9925D0", VA = "0x1809931D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x993260", Offset = "0x992660", VA = "0x180993260")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RecNetCDNKey Dependency
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x9943D0", Offset = "0x9937D0", VA = "0x1809943D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x99A2A0", Offset = "0x9996A0", VA = "0x18099A2A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool AttemptPrecacheLookup
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x9C1F60", Offset = "0x9C1360", VA = "0x1809C1F60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x9C1D80", Offset = "0x9C1180", VA = "0x1809C1D80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public HECPALDOCEK PathHint
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xD08A60", Offset = "0xD07E60", VA = "0x180D08A60")]
			[CompilerGenerated]
			get
			{
				return default(HECPALDOCEK);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x120EB90", Offset = "0x120DF90", VA = "0x18120EB90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string ItemPath
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x76CB790", Offset = "0x76CAB90", VA = "0x1876CB790")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x76CB710", Offset = "0x76CAB10", VA = "0x1876CB710")]
		public static RecNetCDNKey NEMJCNNEBLP(string GNCDADOJDCO, HECPALDOCEK ANIPHKIMNII)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x76CB6C0", Offset = "0x76CAAC0", VA = "0x1876CB6C0")]
		public void GKBBHCAFBOB(string MKONIOFDKLJ, string FJJIBEAAGGP, bool NHKLJEOPFIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public RecNetCDNKey()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[CBAKGNGODOD]
public class OCLPEOEADBD : LBFPDNMDDAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	protected readonly List<Mesh> ENBDBLMJPKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	protected readonly List<byte[]> JPHEEBJHJPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	protected readonly List<Matrix4x4> OKIECGPLHOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	protected readonly List<bool> DPMPDEPKNAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	protected readonly List<long> GCHPKPCCJIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	protected readonly List<bool> MODBCDPAPPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	protected readonly List<int> GLKJBDNJNOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	protected Allocator CDBACFEIKNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected HFFMPENDMEE GLKDADCBMGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected byte DDPADLFFPIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected IList<int> FCMLOPJCHEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected IList<int> FDKDCENGPOJ;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x76C9150", Offset = "0x76C8550", VA = "0x1876C9150", Slot = "4")]
	public void FAMPOKEIFCM(Mesh MPJNANLNCGP, Matrix4x4 DJBBDGIGPGO, byte[] OBGHAFBHOGG, bool MLDLIAHCMCI = false, JBHNNEJDMMC.KMAIJNBJDFP NHMGGEENPLB = (JBHNNEJDMMC.KMAIJNBJDFP)0L, int HNEMHJDIGJH = -1, bool NOLCGOAAOJG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x76C9630", Offset = "0x76C8A30", VA = "0x1876C9630", Slot = "5")]
	public void PKKPOIHKLLC(Allocator JMEGNHGDHIA, HFFMPENDMEE DEJBHCJFPDI, byte AFFPLBBLOJI, [Optional] IList<int> NPLNEADEMNM, [Optional] IList<int> FDELNJIGMDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x76C93D0", Offset = "0x76C87D0", VA = "0x1876C93D0")]
	private static void GMCCLEPJPFM(Mesh MPJNANLNCGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x76C9670", Offset = "0x76C8A70", VA = "0x1876C9670")]
	public OCLPEOEADBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[CBAKGNGODOD]
public struct AKDHLDNOGAM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	[ReadOnly]
	public OJGAEGMNKPF DCBCBFABCCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[ReadOnly]
	public int FOBMKEAODAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public EIHEAOOLCBC ANOFEJEBBPJ;

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x76B5500", Offset = "0x76B4900", VA = "0x1876B5500", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[CBAKGNGODOD]
[NativeContainer]
public struct EIHEAOOLCBC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct IGGBGPGBFIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Vector3 GDJKBHJPMPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public Vector3 BELINKGJHGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public Vector4 HNPFPDNMBIN;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct AJMOCAOBHAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public float BGDCMJIGIFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public float MFKMFKMIPMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public float CPBJMPEIDGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public float GHCMNJAIFFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public byte JBAACKNHECO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public byte PGCCNCFOPBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public byte IHEPFDMNPAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public byte NPFEGJKFLMG;
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct EJBGHDKALJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public half BGDCMJIGIFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public half MFKMFKMIPMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public half CPBJMPEIDGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public half GHCMNJAIFFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public byte JBAACKNHECO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public byte PGCCNCFOPBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public byte IHEPFDMNPAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public byte NPFEGJKFLMG;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct HFDONFEMBIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public half4 ODFBFMBMBOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public half2 KBNMPFFCONN;
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct BGMENLEOAME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public half4 ODFBFMBMBOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public half2 KBNMPFFCONN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public half2 GIHHHFALHFL;
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct GHGGBLBJOLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public half4 ODFBFMBMBOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public half2 KBNMPFFCONN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public half2 GIHHHFALHFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public half2 JOCCNPFMNOM;
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct CMBAMOAHKKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public half4 ODFBFMBMBOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public half2 KBNMPFFCONN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public half2 GIHHHFALHFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public half2 JOCCNPFMNOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public half2 JILPCEAFHBM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct NLGNGHIGBFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public float BGDCMJIGIFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public float MFKMFKMIPMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public float CPBJMPEIDGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public float GHCMNJAIFFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int JBAACKNHECO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int PGCCNCFOPBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int IHEPFDMNPAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int NPFEGJKFLMG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct OPLNFEKBFON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Color ODFBFMBMBOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Vector2 KBNMPFFCONN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct CHEFFMDEGDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Color ODFBFMBMBOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Vector2 KBNMPFFCONN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Vector2 GIHHHFALHFL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct NBCNLCAGLLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Color ODFBFMBMBOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Vector2 KBNMPFFCONN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Vector2 GIHHHFALHFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Vector2 JOCCNPFMNOM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct NDNHIAPHLBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Color ODFBFMBMBOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Vector2 KBNMPFFCONN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Vector2 GIHHHFALHFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Vector2 JOCCNPFMNOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Vector2 JILPCEAFHBM;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private bool KPMHICKLHNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<IGGBGPGBFIO> JAKNBLLHEAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<HFDONFEMBIL> IKCKOFMKHBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<BGMENLEOAME> GAOHOEJKEDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<GHGGBLBJOLG> IMEKBFKDBCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<CMBAMOAHKKL> LPOGFGMPLHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<EJBGHDKALJG> CAJDDOPMCJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<AJMOCAOBHAD> BEHMEEOCJFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NativeArray<OPLNFEKBFON> DGOFJEEIAIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NativeArray<CHEFFMDEGDG> LLGMACCBPKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public NativeArray<NBCNLCAGLLL> ICJKGOGCPAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public NativeArray<NDNHIAPHLBH> CEJGHOPAPLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public NativeArray<NLGNGHIGBFJ> EABBICEGCNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public NativeArray<int> CPINBDBNLGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public NativeArray<int> FEEGBAJOFID;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private NativeArray<int> OKBIFJEKODC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NativeArray<int> JOKPPIOGMEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<int> GOGLBKCLEGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public NativeArray<int> CNGAHDLLMCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public NativeArray<int> GPJOFDHDDPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public NativeArray<BoneWeight> EJECAJMIOHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeArray<int> MHBNBGGMEBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private bool JADHPDBELKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x159")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private bool LNNNHLFANLN;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int DCKNFJFKMKI
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x76B9090", Offset = "0x76B8490", VA = "0x1876B9090")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x76B8D40", Offset = "0x76B8140", VA = "0x1876B8D40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int MLGNOAIIFEN
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x76B98E0", Offset = "0x76B8CE0", VA = "0x1876B98E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x76B8D50", Offset = "0x76B8150", VA = "0x1876B8D50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int EFCLLLDIEKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x76B9D00", Offset = "0x76B9100", VA = "0x1876B9D00")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x76B98F0", Offset = "0x76B8CF0", VA = "0x1876B98F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int JHHOPMDPFLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x76B8DC0", Offset = "0x76B81C0", VA = "0x1876B8DC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x76BB090", Offset = "0x76BA490", VA = "0x1876BB090")]
	public EIHEAOOLCBC(int JJIDMCADEFA, int OMLNHNIEGID, int HIAFJMIONDF, int LANIBOJEEGA, Allocator JMEGNHGDHIA, int MMIMFFDCAKM, LHHKKPCFOCL JNCHFIADHDK, bool JADHPDBELKG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x76B90A0", Offset = "0x76B84A0", VA = "0x1876B90A0")]
	public void EFCBMGCICGM(int CJFNAFNJJLB, Vector3 CHAOGBKCKEH, Vector3 AHDECIMNHGG, Vector4 OOLNPDLPIEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x76BAC50", Offset = "0x76BA050", VA = "0x1876BAC50")]
	public void NBAFBPCJPNE(int CJFNAFNJJLB, BoneWeight MEAFOLFDFBL, NativeSlice<byte> OBGHAFBHOGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x76B95B0", Offset = "0x76B89B0", VA = "0x1876B95B0")]
	public Color HGJKJIKGIHJ(int CJFNAFNJJLB)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x76B9900", Offset = "0x76B8D00", VA = "0x1876B9900")]
	public void KEHGDFHEKLG(int CJFNAFNJJLB, Color NOBKOCLLFNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x76B9200", Offset = "0x76B8600", VA = "0x1876B9200")]
	public void HBPGCELDAMA(byte BIMJAPHHFLP, int CJFNAFNJJLB, Vector2 DPMOFNCLKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x76BB080", Offset = "0x76BA480", VA = "0x1876BB080")]
	public void POFONKINKNE(int CJFNAFNJJLB, int EPDCBDABJAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x76B8D60", Offset = "0x76B8160", VA = "0x1876B8D60")]
	public bool CGMBNHHFHLF(int BIMJAPHHFLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x76B9130", Offset = "0x76B8530", VA = "0x1876B9130")]
	public void FFBLCLNKDMP(int MNHKHCPIHFJ, int HGHGCNDALFP, int BFBCILDCBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x76B8E30", Offset = "0x76B8230", VA = "0x1876B8E30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x76B9D10", Offset = "0x76B9110", VA = "0x1876B9D10")]
	public Mesh MGBHMKNEIIE([Optional] string LNGJKEMDIKI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
[CBAKGNGODOD]
[NativeContainer]
public struct OJGAEGMNKPF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public Mesh.MeshDataArray CALLOIALOHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public NativeArray<int> KNOMHOGPCCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public NativeArray<int> NAFNDIDLJGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public NativeArray<BoneWeight> EJECAJMIOHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private NativeArray<Matrix4x4> APPIKCMDLHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private NativeArray<long> FMKDBDCDMBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private NativeArray<byte> OIKBDKACAIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private NativeArray<int> IGCBBOOABNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private NativeArray<int> DCKHPEFMFDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public NativeArray<sbyte> ACEBCELBGIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public NativeArray<byte> MKFKFDAIGOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public NativeArray<bool> NOLCGOAAOJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NativeArray<int> HNEMHJDIGJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private bool JADHPDBELKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeArray<int> PFKMLPENIHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private bool LNNNHLFANLN;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int JENAMBIPACK
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x76C9E10", Offset = "0x76C9210", VA = "0x1876C9E10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int FJDOBMBJEHC
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x76C9D00", Offset = "0x76C9100", VA = "0x1876C9D00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int GCPFGHLEIKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x76C9E20", Offset = "0x76C9220", VA = "0x1876C9E20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int IMKFNPDDOKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x76C9CF0", Offset = "0x76C90F0", VA = "0x1876C9CF0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x76C9D10", Offset = "0x76C9110", VA = "0x1876C9D10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int DCKNFJFKMKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x76C9CC0", Offset = "0x76C90C0", VA = "0x1876C9CC0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x76C98C0", Offset = "0x76C8CC0", VA = "0x1876C98C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int HBEBCKMJJDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x76C9B20", Offset = "0x76C8F20", VA = "0x1876C9B20")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x76C9CD0", Offset = "0x76C90D0", VA = "0x1876C9CD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public HFFMPENDMEE AEKJLICOGOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x76C9CE0", Offset = "0x76C90E0", VA = "0x1876C9CE0")]
		get
		{
			return default(HFFMPENDMEE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x76C9D30", Offset = "0x76C9130", VA = "0x1876C9D30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public byte EAHEPFGAENH
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x76C9D20", Offset = "0x76C9120", VA = "0x1876C9D20")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x76C9B30", Offset = "0x76C8F30", VA = "0x1876C9B30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public MEGKJMEGJPF JODHLAKLPCM
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x76C98D0", Offset = "0x76C8CD0", VA = "0x1876C98D0")]
		get
		{
			return default(MEGKJMEGJPF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x76C9EF0", Offset = "0x76C92F0", VA = "0x1876C9EF0")]
	public OJGAEGMNKPF(IList<Mesh> FIOBADEPIAK, IList<Matrix4x4> HOIOCOJOJJM, IList<bool> NOLCGOAAOJG, byte AFFPLBBLOJI, IList<byte[]> FCHIADDCHCB, IList<long> KOCKHIOHICN, IList<bool> EAPLJNBGHHC, IList<int> HNEMHJDIGJH, IList<int> NPLNEADEMNM, IList<int> MMEDBPFPKJM, Allocator JMEGNHGDHIA, HFFMPENDMEE DEJBHCJFPDI, bool JADHPDBELKG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x76C9D40", Offset = "0x76C9140", VA = "0x1876C9D40")]
	public EIHEAOOLCBC MLIJBIPEHPE(Allocator JMEGNHGDHIA, LHHKKPCFOCL JNCHFIADHDK)
	{
		return default(EIHEAOOLCBC);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x76C9B40", Offset = "0x76C8F40", VA = "0x1876C9B40", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[CBAKGNGODOD]
public class IDAPMKAGAPD : OCLPEOEADBD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public bool AKIFEMEEBKG;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly ProfilerMarker OEBLDMFIPFK;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x76C8D30", Offset = "0x76C8130", VA = "0x1876C8D30")]
	public OJGAEGMNKPF EJEGJMMHJBH()
	{
		return default(OJGAEGMNKPF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x76C8FF0", Offset = "0x76C83F0", VA = "0x1876C8FF0")]
	public IDAPMKAGAPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct MEGKJMEGJPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public Mesh.MeshData ELBGCOFJPCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public NativeSlice<BoneWeight> EJECAJMIOHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public NativeSlice<byte> AGFBMAHHFIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public int AJIACOHOIBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public Matrix4x4 JCJPFHGJEBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public long CJPGAIEKNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public NativeSlice<byte> OBGHAFBHOGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public bool HJGIKEGJIDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public int BDHCPLPHKLE;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class FGEPGNFMAOA : EDHLCJGGGBG
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class DALOCBPMCCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public OAFHNHABDJM avatarBuildParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public FGEPGNFMAOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public NAHOFKDLLJE buildMeshPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public Action<KeyValuePair<string, HLFDOLJKNKL<Texture2D>>> <>9__19;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public DALOCBPMCCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x76B8AF0", Offset = "0x76B7EF0", VA = "0x1876B8AF0")]
		internal bool AGLDAKLIIPK(FGHBCIPAAPJ item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x76B8AD0", Offset = "0x76B7ED0", VA = "0x1876B8AD0")]
		internal void AFCPLAGPPOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x76B8C00", Offset = "0x76B8000", VA = "0x1876B8C00")]
		internal void GNPCEDCNLGB(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x76B8AD0", Offset = "0x76B7ED0", VA = "0x1876B8AD0")]
		internal void LNBANHDKPAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x76B8C00", Offset = "0x76B8000", VA = "0x1876B8C00")]
		internal void OCFGKCCFECK(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x76B8CE0", Offset = "0x76B80E0", VA = "0x1876B8CE0")]
		internal void JKOODGOKFLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x76B8D10", Offset = "0x76B8110", VA = "0x1876B8D10")]
		internal void PLACCLNDPAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x76B8B40", Offset = "0x76B7F40", VA = "0x1876B8B40")]
		internal void GEKGGFCKNHN(Dictionary<string, HLFDOLJKNKL<Texture2D>> resourceHandleDictionary)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x76B8C20", Offset = "0x76B8020", VA = "0x1876B8C20")]
		internal void JCFBMIJPJBB(KeyValuePair<string, HLFDOLJKNKL<Texture2D>> kvp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x9931D0", Offset = "0x9925D0", VA = "0x1809931D0")]
		internal DJNFHDJGNJD AOPNGJNDNOP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class NCNKGLDABEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public int lowestPossibleLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public DALOCBPMCCF CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public NCNKGLDABEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x76C9090", Offset = "0x76C8490", VA = "0x1876C9090")]
		internal BBALLFNENKK OBKBDIBAGHH(int lod)
		{
			return default(BBALLFNENKK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class FOLLOANBJCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public GOBMEFCJDOP<Dictionary<string, HLFDOLJKNKL<Texture2D>>> ugcTextureDictionaryPromise;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public FOLLOANBJCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x9943E0", Offset = "0x9937E0", VA = "0x1809943E0")]
		internal GOBMEFCJDOP<Dictionary<string, HLFDOLJKNKL<Texture2D>>> JADKGNJMMDE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class BPEFEGKDOPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public List<NAHOFKDLLJE> innerPromises;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public BPEFEGKDOPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x76B89A0", Offset = "0x76B7DA0", VA = "0x1876B89A0")]
		internal void EGKPLENONEP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class POMOCHHJIJH : IEnumerator<CIKDDGFOAFI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private CIKDDGFOAFI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public bool shouldWait;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public FGEPGNFMAOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public List<NGHMJIOLEDC> parts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public List<NAHOFKDLLJE> innerPromises;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public bool isFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public Func<int, BBALLFNENKK> getLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public MNIMKLBOFPM materialPropertyBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public Material materialInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private int <lodIndex>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private CIKDDGFOAFI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x999C60", Offset = "0x999060", VA = "0x180999C60")]
		[DebuggerHidden]
		public POMOCHHJIJH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x76CB340", Offset = "0x76CA740", VA = "0x1876CB340", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x76CB5C0", Offset = "0x76CA9C0", VA = "0x1876CB5C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class OFICJENHHMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public MHGNMOLLGMD cancelable;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public OFICJENHHMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0xB1C7D0", Offset = "0xB1BBD0", VA = "0x180B1C7D0")]
		internal void EMLOHCNABPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0xC31300", Offset = "0xC30700", VA = "0x180C31300")]
		internal void GFMCBMHHCKO(string err)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class BCEENLCDMAE
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
		public FGEPGNFMAOA <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public BCEENLCDMAE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class HLKMHAHHHFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public EIHEAOOLCBC defaultMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public OJGAEGMNKPF defaultAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public BCEENLCDMAE CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public HLKMHAHHHFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x76C8AF0", Offset = "0x76C7EF0", VA = "0x1876C8AF0")]
		internal void DOIPCKKLGPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x116A7F0", Offset = "0x1169BF0", VA = "0x18116A7F0")]
		internal void FFDKLCCCJFH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class OPNPNFLIEPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public EALIIKDALFP legacyMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public MOJOBHGAFLG legacyAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public BCEENLCDMAE CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public OPNPNFLIEPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x76CB100", Offset = "0x76CA500", VA = "0x1876CB100")]
		internal void IHPLEBFFEEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x116A990", Offset = "0x1169D90", VA = "0x18116A990")]
		internal void ENKLFDFILAD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class BMJGLOLGMOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public string overrideItemIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public IDINMFOPJOG overrideBodyPart;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public BMJGLOLGMOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x76B8920", Offset = "0x76B7D20", VA = "0x1876B8920")]
		internal bool BEOBNMELGAO(KeyValuePair<string, FGHBCIPAAPJ> entry)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly OPNNLJDPBAB MNDMEODCGCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly OPNNLJDPBAB LLNKBIDBJMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Dictionary<GOJPKMAJKNJ, float> GDPFOEGCFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private Dictionary<MBOBCJEIEEI, float> POHPKGEBGLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Dictionary<ODNBJGOJGEE, float> KCAEHMLDBLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private IReadOnlyDictionary<string, FLFDPLFNCAC> GOHDIJAHNLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Dictionary<string, FLFDPLFNCAC> HMHANGDOGOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Dictionary<string, FLFDPLFNCAC> MMBAKHPIPDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private Dictionary<string, FLFDPLFNCAC> ILEMBCAMDDF;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private static float ODDJPFMOBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private bool? CBJPKJJGJBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private bool? JODOMMBDCIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private bool? EDPDHJIFECJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5E")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private bool? GIFDFHBINDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private AvatarConfiguration BHJNMMLNOHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private Transform BLFAKFAHDLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private AvatarSkinAssetItem LNNCCBAOPEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private AssetReference LLPIHOEAALM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private GameObject AGOPEBEIICM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private GameObject MMINCDKMHFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private SkinnedMeshRenderer EEOJPPIMCKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private AvatarSkinnedMeshBoneOrderRemapsData KMJFEJNOHLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private Transform[] EBJFNOAFDJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private Matrix4x4[] PIOMCGNBANL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private Material MCANCGBKDJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private Material EMKJOFGCDJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private Material DCKNJPEGCII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private Shader BCHFHOHFNLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private Shader JOABGDMBINL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private Animator MHLAOMKCHLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private Renderer[] OKBHPPCIIDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private JBHNNEJDMMC.KMAIJNBJDFP FPJKBGAHMPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private AvatarBodyPartShapesManager DKHOMDDCOAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private IReadOnlyDictionary<string, Transform> KGNBABEFKEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private AvatarFaceShapeData.MJIPLIHJOCE NPLCCPCNBBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private AvatarBodyShapeData.MHHALAOCKHM FNLBAAHKBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private PPJFLGDEIOL CEAOJKNNHNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private bool NNFPAGBIBMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10D")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private bool NFIPKDCEELE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private Color EIHLMHDEEEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private Color AEBBGNNCKNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private Color MIEKDJCDOEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private Color? HDELDEFMGIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x154")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private Color? POIIFLOPCFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private Color? OAHMEGDIDCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private Color? AJPHFKHLOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private Texture2D HACCBNFFILC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private Texture2D GONOOLOLNCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[CanBeNull]
	private FGHBCIPAAPJ DBGGCOJCLKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private Texture MBBKBJOCLJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private Color DGDNGPDNPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public Dictionary<Renderer, MNIMKLBOFPM> ILJEAPHCKHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private Dictionary<Renderer, MNIMKLBOFPM> GOPCGMAPNIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private Dictionary<string, List<KMNHLOMAIEO>> FFICNICKLHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private Dictionary<string, List<KMNHLOMAIEO>> EEDHMCNGIHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly List<MFCONHIDCBK> GFJNBNKNKAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly List<MFCONHIDCBK> DLACEAFHAAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly List<MFCONHIDCBK> KGJJDPOJGAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly List<MFCONHIDCBK> GPMLODPHBBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private Dictionary<KMNHLOMAIEO, Material> PJBKFDAGNGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private Dictionary<KMNHLOMAIEO, Material> OPFJEAGIJHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private SkinnedMeshRenderer[] LKKKPLGCAHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private SkinnedMeshRenderer[] LCBNBBIAIHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private SkinnedMeshRenderer[] CGLCLEEMHNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private SkinnedMeshRenderer[] AFLHKMLJKCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private readonly Dictionary<string, HLFDOLJKNKL<Texture2D>> BOHCLNGICHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private readonly Dictionary<string, HLFDOLJKNKL<Texture2D>> NKJGGGAPHIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private DGPDCGECHDA IFJBBIDBLCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x244")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private DGPDCGECHDA FOCJOFMEFEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private AdditionalHatData LDPLPDHKMBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private AdditionalHatData KGNFLKDBJEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private HairData HDNPCFMCGLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private HairData BEGIGOPGKNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private KGGLBONGBPM FLFIMEHLHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private bool? OFFHIBNENHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x274")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private PositionAndRotation CJNKABIDLFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private Transform BFALBJNICNM;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private Material OHCDPDCJFGK;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private Material IPOIBCKDFNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private Dictionary<string, FGHBCIPAAPJ> FABFHHAFGON;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static readonly int OHLOIJHPCNE;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static readonly int FNCEDKBJHBH;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static readonly int NFMCNFALIBI;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly int HBJBOGHHIMP;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly int NLDOEDBOOJB;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly int PDEEDLLAABG;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly int EIMECPJNHBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private bool CJOKCPEBFAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private List<Action> DAMCIDIFJOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private BGAIKOLNNLM OHGKCIBNBIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private SkinnedMeshRenderer[] FBMKNIMOEHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private int IBIGPJFEHPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D4")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private bool KBEAOIAMCIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private int ACFOHFCFHMN;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public OPNNLJDPBAB FDBHJHDFJGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9943E0", Offset = "0x9937E0", VA = "0x1809943E0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public OPNNLJDPBAB BBINDLKCNBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private NNOOHIAHMIG ENFLKMBLIJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x76BC6C0", Offset = "0x76BBAC0", VA = "0x1876BC6C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool BIFGLDHMDIB
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x76BD920", Offset = "0x76BCD20", VA = "0x1876BD920")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private bool CCGOKKBOMLP
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x76C00F0", Offset = "0x76BF4F0", VA = "0x1876C00F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private bool EPPALNBNJFE
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x76BF7A0", Offset = "0x76BEBA0", VA = "0x1876BF7A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private bool CPEDBGJJBJE
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x76C7850", Offset = "0x76C6C50", VA = "0x1876C7850")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public AvatarConfiguration CAAEHJNMLDP
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x993A50", Offset = "0x992E50", VA = "0x180993A50", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool IMFHCABELPP
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x125D780", Offset = "0x125CB80", VA = "0x18125D780")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x246FAF0", Offset = "0x246EEF0", VA = "0x18246FAF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private Material IJDCCHJCGHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x76BD590", Offset = "0x76BC990", VA = "0x1876BD590")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private Material MHHPLIHBNPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x76BFB10", Offset = "0x76BEF10", VA = "0x1876BFB10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private bool EGPLPPODLAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x9AF690", Offset = "0x9AEA90", VA = "0x1809AF690")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public GEHKDDKOMID BDHJEGDKAFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x1238950", Offset = "0x1237D50", VA = "0x181238950", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return default(GEHKDDKOMID);
		}
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x76BFB00", Offset = "0x76BEF00", VA = "0x1876BFB00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public Material DPJLPKGBHFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xC86D50", Offset = "0xC86150", VA = "0x180C86D50", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public SkinnedMeshRenderer[] GDLBHKJNEMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x1238700", Offset = "0x1237B00", VA = "0x181238700", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public Renderer[] JMCOOPGFIIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xA1AEF0", Offset = "0xA1A2F0", VA = "0x180A1AEF0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool MGAPAHOLKAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x76C7BF0", Offset = "0x76C6FF0", VA = "0x1876C7BF0", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public JBHNNEJDMMC.KMAIJNBJDFP IGKCFFKGEBN
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xA1AA80", Offset = "0xA19E80", VA = "0x180A1AA80", Slot = "20")]
		get
		{
			return default(JBHNNEJDMMC.KMAIJNBJDFP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int KEKHDNIPPCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x10CECA0", Offset = "0x10CE0A0", VA = "0x1810CECA0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x76C2100", Offset = "0x76C1500", VA = "0x1876C2100")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private bool IMCHNIOBPHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x76C7B40", Offset = "0x76C6F40", VA = "0x1876C7B40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private static bool MCKOHILLIBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x9DE710", Offset = "0x9DDB10", VA = "0x1809DE710")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x76BFAD0", Offset = "0x76BEED0", VA = "0x1876BFAD0", Slot = "15")]
	public NAHOFKDLLJE FLLGHAELBJA(OAFHNHABDJM MPMPHAFGBDG, bool OIOIAELKKLB, int[] HANJMFKKEEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x76C5A60", Offset = "0x76C4E60", VA = "0x1876C5A60", Slot = "14")]
	public NAHOFKDLLJE MCKJEAPEHPA(OAFHNHABDJM MPMPHAFGBDG, bool OIOIAELKKLB, int[] HANJMFKKEEC, Func<Dictionary<string, FGHBCIPAAPJ>, (NAHOFKDLLJE, GOBMEFCJDOP<Dictionary<string, HLFDOLJKNKL<Texture2D>>>)> JFEAOFNIJOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x76C3C20", Offset = "0x76C3020", VA = "0x1876C3C20")]
	public NAHOFKDLLJE MAEEGJKCKIO(OAFHNHABDJM MPMPHAFGBDG, bool OIOIAELKKLB, int[] HANJMFKKEEC, bool PFNPNNKFPIH, DGPDCGECHDA AAAHMMGLDKA, [Optional] Func<Dictionary<string, FGHBCIPAAPJ>, (NAHOFKDLLJE, GOBMEFCJDOP<Dictionary<string, HLFDOLJKNKL<Texture2D>>>)> JFEAOFNIJOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x76BFC00", Offset = "0x76BF000", VA = "0x1876BFC00")]
	private bool GAOLLMNHFOP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x76C0B10", Offset = "0x76BFF10", VA = "0x1876C0B10")]
	private NAHOFKDLLJE IBAHCLHDLMK(bool OIOIAELKKLB, List<NGHMJIOLEDC> HJKDLHMCKLO, int[] HANJMFKKEEC, Func<int, BBALLFNENKK> IKNNIKBBBIG, bool PFNPNNKFPIH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x76C1BA0", Offset = "0x76C0FA0", VA = "0x1876C1BA0")]
	[IteratorStateMachine(typeof(POMOCHHJIJH))]
	private IEnumerator<CIKDDGFOAFI> JPPMPKIFFHM(bool OIOIAELKKLB, List<NGHMJIOLEDC> HJKDLHMCKLO, int[] HANJMFKKEEC, Func<int, BBALLFNENKK> IKNNIKBBBIG, MNIMKLBOFPM KDLKIPFCFBA, Material DILEJOPAIDP, List<NAHOFKDLLJE> OJPLHOPIGCH, bool GJCOKPGPOGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x76BEAF0", Offset = "0x76BDEF0", VA = "0x1876BEAF0")]
	private void EKHEOFAIMMA(List<NGHMJIOLEDC> HJKDLHMCKLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x76BF880", Offset = "0x76BEC80", VA = "0x1876BF880")]
	private NAHOFKDLLJE FJJCENHDJBI(List<NGHMJIOLEDC> HJKDLHMCKLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x76C2120", Offset = "0x76C1520", VA = "0x1876C2120")]
	private LBKCJDEOHAA KJDJBPNLIHM(List<NGHMJIOLEDC> HJKDLHMCKLO, int KHCIAPOHNBN, bool OIOIAELKKLB, BBALLFNENKK DMGLPHIJGLL, bool JMIOKKCKIAG, MNIMKLBOFPM KDLKIPFCFBA, Material DILEJOPAIDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x76C0260", Offset = "0x76BF660", VA = "0x1876C0260", Slot = "27")]
	public void GKKAAKKANDK(GOJPKMAJKNJ FEKPJECLIPO, float FFOEEMKIKJO, bool NKFCDNLGJEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x76C1180", Offset = "0x76C0580", VA = "0x1876C1180", Slot = "29")]
	public void ICLBPPKDOPK(MBOBCJEIEEI LJELEPPPBKP, float FFOEEMKIKJO, bool COINMODEMLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x76C6490", Offset = "0x76C5890", VA = "0x1876C6490", Slot = "30")]
	public void NLECMHNNGNJ(ODNBJGOJGEE ALNKLILJEIN, float FFOEEMKIKJO, bool OKHNDFMBPPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x76C5F70", Offset = "0x76C5370", VA = "0x1876C5F70", Slot = "28")]
	public void MEOHIJOJNDJ(bool MBFGCLEAILE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x76BC2B0", Offset = "0x76BB6B0", VA = "0x1876BC2B0", Slot = "31")]
	public void AGJFEKEMLCM(bool MBFGCLEAILE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x76BC900", Offset = "0x76BBD00", VA = "0x1876BC900", Slot = "32")]
	public void BPKFKFLECFH(bool MBFGCLEAILE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x76BF310", Offset = "0x76BE710", VA = "0x1876BF310")]
	private void FAMIMJPAJBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x76C66B0", Offset = "0x76C5AB0", VA = "0x1876C66B0")]
	private void NOMAAJEIBJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x76BC310", Offset = "0x76BB710", VA = "0x1876BC310")]
	private void ALHMJMMCOGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x76BC4F0", Offset = "0x76BB8F0", VA = "0x1876BC4F0", Slot = "25")]
	public void BLDNFHFFGKC(AvatarFaceShape HFAJOGNGLHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x76C5EB0", Offset = "0x76C52B0", VA = "0x1876C5EB0", Slot = "26")]
	public void MECGCLHBMCC(AvatarBodyShape KIOFEFFHDLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0xB059F0", Offset = "0xB04DF0", VA = "0x180B059F0", Slot = "33")]
	public void FIJGOAFFACK(PPJFLGDEIOL OACPMMCOLIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x76C04C0", Offset = "0x76BF8C0", VA = "0x1876C04C0", Slot = "35")]
	public void GNCIEHPFKOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x76BD460", Offset = "0x76BC860", VA = "0x1876BD460", Slot = "38")]
	public void CEHAOGHLHAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x76C66A0", Offset = "0x76C5AA0", VA = "0x1876C66A0", Slot = "34")]
	public void NOJDODABDNA(bool HPEDGPPIECB, bool KJCFNBBKOKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x76C1A50", Offset = "0x76C0E50", VA = "0x1876C1A50")]
	private void JOECFBPDLBP(SkinnedMeshRenderer OKCBBEFADKL, int KHCIAPOHNBN, Mesh MPJNANLNCGP, List<Material> IBIDNIBHLDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x76BD730", Offset = "0x76BCB30", VA = "0x1876BD730")]
	private static Material CJCCBFFCCFH(Dictionary<KMNHLOMAIEO, Material> ILNLOAGHLCL, Material DDDEEPBEPAO, BMDLICOBDLK FCGJMAEHANG, BBBIKDINNPL PDMDFLCCFFL, IDINMFOPJOG OFBICLFFJFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x76BC5B0", Offset = "0x76BB9B0", VA = "0x1876BC5B0")]
	private static BMDLICOBDLK BLNPDMNHKGM(NGHMJIOLEDC FFAGJMPJFJA, int HIOGNDFFEBE)
	{
		return default(BMDLICOBDLK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x76BF390", Offset = "0x76BE790", VA = "0x1876BF390")]
	private void FBILMDEFCFG(int POEJHNPGIGD, Material ANOGJJADLNE, NGHMJIOLEDC FFAGJMPJFJA, [Out] Texture2D KNANCOIDGEG, [Out] Vector4 CMHBECGDJEK, [Out] Texture2D DDEHPMDHHJF, [Out] Texture2D KKJBDMNPDAC, [Out] Texture2D POFPEENAKBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x76C1260", Offset = "0x76C0660", VA = "0x1876C1260")]
	private void IJABFOFLPID(int POEJHNPGIGD, Material ANOGJJADLNE, NGHMJIOLEDC FFAGJMPJFJA, [Out] Color HKHGLNNHJFE, [Out] Color JGBGABHDJDM, [Out] Color MGJEBCBGKBF, [Out] Color JGKEIMMLDAA, [Out] Color FBJAFFGIBBA, [Out] Color EBPPMIGDMGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x76BC050", Offset = "0x76BB450", VA = "0x1876BC050")]
	private bool AGEIBGBDEEH(Material ANOGJJADLNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x76BDC90", Offset = "0x76BD090", VA = "0x1876BDC90")]
	private static Material DMBKCDKIEHB(int POEJHNPGIGD, BACMLKOLNGP FFAGJMPJFJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x76C32D0", Offset = "0x76C26D0", VA = "0x1876C32D0")]
	private static BBBIKDINNPL LCMGMFIGAOI(NGHMJIOLEDC FFAGJMPJFJA, int HIOGNDFFEBE)
	{
		return default(BBBIKDINNPL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x76C1CC0", Offset = "0x76C10C0", VA = "0x1876C1CC0")]
	private static void KAAJFPBDJHC(Dictionary<string, List<KMNHLOMAIEO>> IMOLDFICHHJ, NGHMJIOLEDC DGIJJDIIGND, Material DDDEEPBEPAO, BMDLICOBDLK AINADGKHJIK, BBBIKDINNPL AFJGMPGENGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x76C39C0", Offset = "0x76C2DC0", VA = "0x1876C39C0")]
	private static SkinnedMeshRenderer LPKDENGLDCD(Transform MIPPCBGEAIP, Transform HFEAKFGFCCN, SkinnedMeshRenderer[] DHPLKIODLHG, int KHCIAPOHNBN, BBALLFNENKK DMGLPHIJGLL, bool OIOIAELKKLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x76C8150", Offset = "0x76C7550", VA = "0x1876C8150")]
	public FGEPGNFMAOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x76BFDA0", Offset = "0x76BF1A0", VA = "0x1876BFDA0")]
	public void GDCNGOALEGL([In] BNJHGFIMAOB EEDNHIKKFAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x76C6730", Offset = "0x76C5B30", VA = "0x1876C6730")]
	public void PBDFCMIDHFP([In] NPKFMKIPBFA GJCECMMMGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x76C2100", Offset = "0x76C1500", VA = "0x1876C2100", Slot = "5")]
	public void PLBGELDOCCC(int KHCIAPOHNBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x76C67B0", Offset = "0x76C5BB0", VA = "0x1876C67B0", Slot = "10")]
	public void OHNHOEMJAMG(NFDLFPBHKED AFJGMPGENGN, Texture2D NPCKAAANCNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x9AF690", Offset = "0x9AEA90", VA = "0x1809AF690")]
	public static bool OLDGDGJCFCE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x76C1F80", Offset = "0x76C1380", VA = "0x1876C1F80", Slot = "11")]
	public bool KEMLKACEOBJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x76BDCE0", Offset = "0x76BD0E0", VA = "0x1876BDCE0", Slot = "9")]
	public void DMFBDFFBKIN(PFJPJCKDAPI AINADGKHJIK, Color? ODFBFMBMBOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x76C1100", Offset = "0x76C0500", VA = "0x1876C1100")]
	private void IBEIBGCPKAK(Action IGMOKEONLFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x76C5FD0", Offset = "0x76C53D0", VA = "0x1876C5FD0", Slot = "6")]
	public void MHANMKBCBCF(FGHBCIPAAPJ GAGINAEGHAC, Texture LOACBHCEHAF, Color OGFLHNDCEHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x246FAF0", Offset = "0x246EEF0", VA = "0x18246FAF0", Slot = "7")]
	public void JFLAFLPLELI(bool GJCOKPGPOGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x2186A30", Offset = "0x2185E30", VA = "0x182186A30", Slot = "8")]
	public void IMGIONKPGLG(BGAIKOLNNLM MHBNBGGMEBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x76C7930", Offset = "0x76C6D30", VA = "0x1876C7930", Slot = "16")]
	public void OKNLHNCBKHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x76C6640", Offset = "0x76C5A40", VA = "0x1876C6640", Slot = "36")]
	public void NLKJDJLCHCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x76C69D0", Offset = "0x76C5DD0", VA = "0x1876C69D0", Slot = "37")]
	public void OJNBHKODOAD([Optional] KGGLBONGBPM JCNNIJENAJB, [Optional] bool? EKBDBNEDODM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x76C6350", Offset = "0x76C5750", VA = "0x1876C6350")]
	private bool NLCKCGLDJDH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x76BE0E0", Offset = "0x76BD4E0", VA = "0x1876BE0E0", Slot = "21")]
	public bool DOKOCEMPKIE(JBHNNEJDMMC.KMAIJNBJDFP CLCIDDOHAJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x76BC730", Offset = "0x76BBB30", VA = "0x1876BC730")]
	private void BPCLMNFENGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x76BDA00", Offset = "0x76BCE00", VA = "0x1876BDA00")]
	private void CKKHADOMJFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x76C7E80", Offset = "0x76C7280", VA = "0x1876C7E80")]
	private static void POKCAMDDOIP(Dictionary<KMNHLOMAIEO, Material> ILNLOAGHLCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x76C3780", Offset = "0x76C2B80", VA = "0x1876C3780")]
	private static void LGFIIOPNNHB(Dictionary<Renderer, MNIMKLBOFPM> DNHPNPEGPAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x76C7D60", Offset = "0x76C7160", VA = "0x1876C7D60")]
	private void PNBMGLOLACA(SkinnedMeshRenderer[] DHPLKIODLHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x76C6040", Offset = "0x76C5440", VA = "0x1876C6040")]
	private void MLLEFHFKKKK(SkinnedMeshRenderer GNGKKHFDIMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x76BE890", Offset = "0x76BDC90", VA = "0x1876BE890")]
	private void EJGMMDEOKAK(List<MFCONHIDCBK> GKEOOMMAFFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x76C18D0", Offset = "0x76C0CD0", VA = "0x1876C18D0")]
	private void JLNCLMAEMIL(Dictionary<string, HLFDOLJKNKL<Texture2D>> IMOLDFICHHJ, bool JKFHNJNLLNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x76BC390", Offset = "0x76BB790", VA = "0x1876BC390")]
	private void AOMDHGEMFIK(Dictionary<string, List<KMNHLOMAIEO>> IMOLDFICHHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x76BDA10", Offset = "0x76BCE10", VA = "0x1876BDA10")]
	private void DAOEODCNIKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x76C1720", Offset = "0x76C0B20", VA = "0x1876C1720")]
	private void IPLDLCIMAGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x76BCE90", Offset = "0x76BC290", VA = "0x1876BCE90")]
	private void CEEKABINIMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x76BFCD0", Offset = "0x76BF0D0", VA = "0x1876BFCD0")]
	private void GCMNMPLILKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x76C62C0", Offset = "0x76C56C0", VA = "0x1876C62C0")]
	private void NKOIBKKOKMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x76C6170", Offset = "0x76C5570", VA = "0x1876C6170")]
	private void NENBJKINCLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x76BDBC0", Offset = "0x76BCFC0", VA = "0x1876BDBC0")]
	private void DLFMAGFLAIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x76BC3E0", Offset = "0x76BB7E0", VA = "0x1876BC3E0")]
	private void BHFNJAMMONO(bool LMOOIJBFOPJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x76C08A0", Offset = "0x76BFCA0", VA = "0x1876C08A0")]
	private void HAHFBOALEHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x76C6560", Offset = "0x76C5960", VA = "0x1876C6560")]
	private void NLGAGHALIPB(bool LMOOIJBFOPJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x76BE4D0", Offset = "0x76BD8D0", VA = "0x1876BE4D0")]
	private void EBOPJCJGKJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x76BBAC0", Offset = "0x76BAEC0", VA = "0x1876BBAC0")]
	private void ABCPHBNIOFK(Material DILEJOPAIDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x76C0340", Offset = "0x76BF740", VA = "0x1876C0340")]
	private void GKPLDDDFBLD(Material DILEJOPAIDP, Color DMBDFAPEJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x76C3530", Offset = "0x76C2930", VA = "0x1876C3530")]
	private void LFGAFCALCIN(Material DILEJOPAIDP, Color DMBDFAPEJJI, Color GGOELMDJHNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x76BC960", Offset = "0x76BBD60", VA = "0x1876BC960")]
	private void CAHCDABHMCE(Material DILEJOPAIDP, Color HKHGLNNHJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x76BF120", Offset = "0x76BE520", VA = "0x1876BF120")]
	private void FAEGBHJMDJB(Material DILEJOPAIDP, Texture2D NPCKAAANCNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x76C58F0", Offset = "0x76C4CF0", VA = "0x1876C58F0")]
	private void MCAJEEJNDKD(Material DILEJOPAIDP, Texture MIFMMNOOACP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x76C0970", Offset = "0x76BFD70", VA = "0x1876C0970")]
	private void HCHJFIPNGKM(Action<MNIMKLBOFPM> KLKPLKKHBOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x76C33B0", Offset = "0x76C27B0", VA = "0x1876C33B0")]
	private void LDOHMPIHHBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x76C5A90", Offset = "0x76C4E90", VA = "0x1876C5A90")]
	private void MDPLDHJEJHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x76BE100", Offset = "0x76BD500", VA = "0x1876BE100")]
	private void DPONLCJKLLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x76BCB00", Offset = "0x76BBF00", VA = "0x1876BCB00")]
	public void CCHJACBGNLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x76C6730", Offset = "0x76C5B30", VA = "0x1876C6730", Slot = "4")]
	private void OCPPGAKDHDN([In] NPKFMKIPBFA GJCECMMMGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x76C0AD0", Offset = "0x76BFED0", VA = "0x1876C0AD0")]
	[CompilerGenerated]
	private DJNFHDJGNJD HMPCEOOBKED(NGHMJIOLEDC ICNDIBLBLJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x76C60E0", Offset = "0x76C54E0", VA = "0x1876C60E0")]
	[CompilerGenerated]
	private void NDLIAFBODGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x76BDB90", Offset = "0x76BCF90", VA = "0x1876BDB90")]
	[CompilerGenerated]
	private void DLFECMACEOK(MNIMKLBOFPM HPMHIJECEGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x76BE7F0", Offset = "0x76BDBF0", VA = "0x1876BE7F0")]
	[CompilerGenerated]
	private void EICDLPDFGJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x76C18B0", Offset = "0x76C0CB0", VA = "0x1876C18B0")]
	[CompilerGenerated]
	private void IPPPEANBDPC(MNIMKLBOFPM HPMHIJECEGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x76C3240", Offset = "0x76C2640", VA = "0x1876C3240")]
	[CompilerGenerated]
	private void KLHMCLKJJEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x76C3970", Offset = "0x76C2D70", VA = "0x1876C3970")]
	[CompilerGenerated]
	private void LHIJAILIGKO(MNIMKLBOFPM HPMHIJECEGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x76BBFC0", Offset = "0x76BB3C0", VA = "0x1876BBFC0")]
	[CompilerGenerated]
	private void ADCBEHKKOJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x76C3BF0", Offset = "0x76C2FF0", VA = "0x1876C3BF0")]
	[CompilerGenerated]
	private void MACLANFMICJ(MNIMKLBOFPM HPMHIJECEGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x76C01D0", Offset = "0x76BF5D0", VA = "0x1876C01D0")]
	[CompilerGenerated]
	private void GKAIAOMPLOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x76C7BC0", Offset = "0x76C6FC0", VA = "0x1876C7BC0")]
	[CompilerGenerated]
	private void PIFEMBAADJH(MNIMKLBOFPM HPMHIJECEGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x76BD890", Offset = "0x76BCC90", VA = "0x1876BD890")]
	[CompilerGenerated]
	private void CJDMCAHEIFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x76C7820", Offset = "0x76C6C20", VA = "0x1876C7820")]
	[CompilerGenerated]
	private void OKLAHPPHHFA(MNIMKLBOFPM HPMHIJECEGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x76C38E0", Offset = "0x76C2CE0", VA = "0x1876C38E0")]
	[CompilerGenerated]
	private void LHFCHKEKHNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x76C3990", Offset = "0x76C2D90", VA = "0x1876C3990")]
	[CompilerGenerated]
	private void LJGJIIHANMN(MNIMKLBOFPM HPMHIJECEGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x76BEA70", Offset = "0x76BDE70", VA = "0x1876BEA70")]
	[CompilerGenerated]
	private void EKHDCGKHOFE(KeyValuePair<string, HLFDOLJKNKL<Texture2D>> DPDEDCODDKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x76BE880", Offset = "0x76BDC80", VA = "0x1876BE880")]
	[CompilerGenerated]
	private void EJAEEHBGCDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x76BDB60", Offset = "0x76BCF60", VA = "0x1876BDB60")]
	[CompilerGenerated]
	private void DGBMDJEBPOM(MNIMKLBOFPM HPMHIJECEGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x76C7B30", Offset = "0x76C6F30", VA = "0x1876C7B30")]
	[CompilerGenerated]
	private void PCDIKHIPLML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x76BC4C0", Offset = "0x76BB8C0", VA = "0x1876BC4C0")]
	[CompilerGenerated]
	private void BIGFPGHNIFC(MNIMKLBOFPM HPMHIJECEGN)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class AvatarElbowBendHelperController : MonoBehaviour, DAKFJKMHLMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		[SerializeField]
		[HCOGNCHHAAD(GKKLJNPNNON.Self, false, false, false)]
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
		[Header("Scale")]
		[FormerlySerializedAs("MinScaleValues")]
		[SerializeField]
		private Vector3 ScaleValuesAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[FormerlySerializedAs("MaxScaleValues")]
		[SerializeField]
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
		private Vector3? CNAIOALGGCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private bool CGPMIJNJDKL;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x76B6FC0", Offset = "0x76B63C0", VA = "0x1876B6FC0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x76B75F0", Offset = "0x76B69F0", VA = "0x1876B75F0", Slot = "4")]
		public void UpdateController(float JNFHMFBFJPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xBA6340", Offset = "0xBA5740", VA = "0x180BA6340", Slot = "6")]
		public void SetEnabled(bool FFOEEMKIKJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x76B70A0", Offset = "0x76B64A0", VA = "0x1876B70A0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x76B7AB0", Offset = "0x76B6EB0", VA = "0x1876B7AB0")]
		public AvatarElbowBendHelperController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class AvatarElbowBendTargetController : MonoBehaviour, DAKFJKMHLMM
	{
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private const float HDJIINPLLOP = 45f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		[SerializeField]
		[HCOGNCHHAAD(GKKLJNPNNON.Self, false, false, false)]
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
		private Vector3 MKCODBLEPFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private Vector3 GHJDPFGCEJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private bool CGPMIJNJDKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private float FEMPPCKJCCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private float IDMICICOOBK;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x76B7E30", Offset = "0x76B7230", VA = "0x1876B7E30", Slot = "4")]
		public void UpdateController(float JNFHMFBFJPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x12FE2C0", Offset = "0x12FD6C0", VA = "0x1812FE2C0", Slot = "6")]
		public void SetEnabled(bool FFOEEMKIKJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x76B7B50", Offset = "0x76B6F50", VA = "0x1876B7B50")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x76B88F0", Offset = "0x76B7CF0", VA = "0x1876B88F0")]
		public AvatarElbowBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class FMDNJMEBKIG : EGAPJAGIONO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private static readonly int LGALGPGDMDO;

	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private static readonly int LABPBHDFNKI;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private static readonly int BIGPIHIMJEF;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private static readonly int AELPDKMANPD;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static readonly int JKEBODBKCMN;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private static readonly int NEADABFFHED;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static readonly int HIMOEAHNGHO;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static readonly int INOMJDJLIFN;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private static readonly int ANHPNFNKJAB;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private static readonly int DBOPJECGKEL;

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private static readonly int LFNKPODCPLC;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private static readonly int LAOCDIJDFOA;

	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private static readonly int ALKIIAACJLJ;

	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private static readonly int APMEDKPJENB;

	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private static readonly int DEHBLGABKDF;

	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private static readonly int MENLOBKABPH;

	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private static readonly int ACBHEAOLLCG;

	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private static readonly int OHMKGMLELFP;

	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private static readonly int LJNAIJIFLJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private Transform PNINGIJCCDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private Transform BLENBCHBIMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private Transform CNJADMHAFPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private Transform FOLDICDGMOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private Transform PFNCONDEHEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private Transform OGPHDMAMBLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private Transform EJEPDKFEOOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private JDDFNHHKOFB FAPMBJIHBMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private Material ALJBFPNBDFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private SkinnedMeshRenderer[] DFCEPIICGCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private readonly List<Material> JOEDJELEPFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private KMPMOEJAKEI NDJJMIMLKKL;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public OPNNLJDPBAB BHLAGHEEGDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x9943E0", Offset = "0x9937E0", VA = "0x1809943E0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private KMPMOEJAKEI ADAKNFNGGAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x76D5990", Offset = "0x76D4D90", VA = "0x1876D5990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool LCONPCPHNJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x76D3DC0", Offset = "0x76D31C0", VA = "0x1876D3DC0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x76D3FE0", Offset = "0x76D33E0", VA = "0x1876D3FE0")]
	public void GDCNGOALEGL([In] JDDFNHHKOFB IMDJMOGIAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x76D3F40", Offset = "0x76D3340", VA = "0x1876D3F40")]
	public void IPFALMNLIBO([In] JKHKDHEEBMP FPEANNOHINP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x76D54A0", Offset = "0x76D48A0", VA = "0x1876D54A0", Slot = "6")]
	public void LBBNNCDMKHG(PJHOGCHAHPE DKBNFNGAIEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x76D40B0", Offset = "0x76D34B0", VA = "0x1876D40B0")]
	private Vector2 GNDCGGPMENB(Vector2 DIJDFEAPIPE)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x76D4110", Offset = "0x76D3510", VA = "0x1876D4110")]
	public void JLOFKOGFNBL([In] KJDMHCBGAFE FPEANNOHINP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x76D50D0", Offset = "0x76D44D0", VA = "0x1876D50D0")]
	private void KEBABKFMPAF(OJFGEBMFNOB AMCKKPEMFGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x76D3A30", Offset = "0x76D2E30", VA = "0x1876D3A30")]
	private void EKCJPPGJOKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x76D39B0", Offset = "0x76D2DB0", VA = "0x1876D39B0")]
	private void MCFDNFHLKDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x76D39B0", Offset = "0x76D2DB0", VA = "0x1876D39B0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x76D5D70", Offset = "0x76D5170", VA = "0x1876D5D70")]
	public FMDNJMEBKIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x76D3F40", Offset = "0x76D3340", VA = "0x1876D3F40", Slot = "5")]
	private void GCMMPNPBBCN([In] JKHKDHEEBMP FPEANNOHINP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x76D5980", Offset = "0x76D4D80", VA = "0x1876D5980", Slot = "7")]
	private void MJGEBLMHKLC([In] KJDMHCBGAFE FPEANNOHINP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x76D3A20", Offset = "0x76D2E20", VA = "0x1876D3A20")]
	[CompilerGenerated]
	internal static float EBJHEAEKOHI(float FFOEEMKIKJO, float KOMIJPKDNMJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x76D5040", Offset = "0x76D4440", VA = "0x1876D5040")]
	[CompilerGenerated]
	internal static (float, float) JOCLIFPPNID(float PIAILFKMGHG)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x76D3970", Offset = "0x76D2D70", VA = "0x1876D3970")]
	[CompilerGenerated]
	internal static Vector4 DAKMIGLIDEN(Vector2 INHMOEHIHAJ, Vector2 KJPCKOGHHCN)
	{
		return default(Vector4);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class AvatarForearmRollController : MonoBehaviour, DAKFJKMHLMM
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
		private float FEMPPCKJCCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private bool CGPMIJNJDKL;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x76CD460", Offset = "0x76CC860", VA = "0x1876CD460", Slot = "4")]
		public void UpdateController(float JNFHMFBFJPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x1587F20", Offset = "0x1587320", VA = "0x181587F20", Slot = "6")]
		public void SetEnabled(bool FFOEEMKIKJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x76CDEF0", Offset = "0x76CD2F0", VA = "0x1876CDEF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
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
		[Cpp2IlInjected.Address(RVA = "0x76CDF20", Offset = "0x76CD320", VA = "0x1876CDF20")]
		public void BECHPFCMIHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x76CE040", Offset = "0x76CD440", VA = "0x1876CE040")]
		public int GGCLEGLAPOO(int JGBBHBNHNJO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public AvatarHandDisplaySettings()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class KBBMLEHBPBD : ACEHPGNKFNG
{
	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x76D7D40", Offset = "0x76D7140", VA = "0x1876D7D40", Slot = "22")]
	public override float PJKMPPFCMMK()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x76D7D90", Offset = "0x76D7190", VA = "0x1876D7D90")]
	public KBBMLEHBPBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class ACEHPGNKFNG : APBOJJNEGEB
{
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private static int CCNPDIHNJFP;

	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private static int CBKGCBJLJKC;

	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private static int LLBHEICOMPG;

	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private static int PPMHOEBIFHD;

	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private static int IDDKPLCJGEM;

	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private static int KEICHCAJBIC;

	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private static int DLKPKMIIKGM;

	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private static int[] CNFNBHHMCFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private CHKJNNMBAOH FAPMBJIHBMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private HCMMFDPDMMP BFBIMJOAPGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private int JKGBHHFOPOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private float DMHGKLOPAPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	protected Animator MHLAOMKCHLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	protected bool GNJBOCHCJLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	protected AvatarConfiguration LMOLHILJFOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	protected int OLNNLDJFPMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private int CNLCHNGGFPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private int NOODGJCHKGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private bool ABNGICLLPJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private CNDKGHPACGG EHJGJCGJEPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private int AGHBJEAKAPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private float IMMHPMADIPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private AvatarHandDisplaySettings KBBOBAEMOCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private GEHKDDKOMID EJHLNCHBCCC;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Transform MIGMIKGPDBL
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x9943E0", Offset = "0x9937E0", VA = "0x1809943E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x994500", Offset = "0x993900", VA = "0x180994500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public Vector3 NKMLIKEBDOP
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x1565F20", Offset = "0x1565320", VA = "0x181565F20")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x1565F70", Offset = "0x1565370", VA = "0x181565F70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Quaternion EJCCHLPLBCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xC71570", Offset = "0xC70970", VA = "0x180C71570")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xE67CB0", Offset = "0xE670B0", VA = "0x180E67CB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool HCPAEPIONOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x76CC3E0", Offset = "0x76CB7E0", VA = "0x1876CC3E0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x76CC0B0", Offset = "0x76CB4B0", VA = "0x1876CC0B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public Vector3 IJKJJOLALHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x76CC860", Offset = "0x76CBC60", VA = "0x1876CC860", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x76CC840", Offset = "0x76CBC40", VA = "0x1876CC840")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public Quaternion FEIGFGKKGFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x7617B40", Offset = "0x7616F40", VA = "0x187617B40", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x76CC0A0", Offset = "0x76CB4A0", VA = "0x1876CC0A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public AFKKKEFLPGM EFBDMOPDJLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xAF9960", Offset = "0xAF8D60", VA = "0x180AF9960", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(AFKKKEFLPGM);
		}
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xAF8E40", Offset = "0xAF8240", VA = "0x180AF8E40", Slot = "4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public AFKKKEFLPGM KJFBFMJGELO
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x235D620", Offset = "0x235CA20", VA = "0x18235D620", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(AFKKKEFLPGM);
		}
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x235CEC0", Offset = "0x235C2C0", VA = "0x18235CEC0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public float DEKPMLBGEIM
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x137E980", Offset = "0x137DD80", VA = "0x18137E980", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0xE5D3C0", Offset = "0xE5C7C0", VA = "0x180E5D3C0", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool MGIPGNFGPIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x76CC3D0", Offset = "0x76CB7D0", VA = "0x1876CC3D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool CPIPEOFFMEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x76CC3C0", Offset = "0x76CB7C0", VA = "0x1876CC3C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool LDLLJKLEALN
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x76CC070", Offset = "0x76CB470", VA = "0x1876CC070")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool NFPFHJGAECM
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x76CC0E0", Offset = "0x76CB4E0", VA = "0x1876CC0E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x76CC220", Offset = "0x76CB620", VA = "0x1876CC220", Slot = "21")]
	public void GDCNGOALEGL(CHKJNNMBAOH IMDJMOGIAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x76CC1D0", Offset = "0x76CB5D0", VA = "0x1876CC1D0")]
	public void GBJDBADAIJN(HCMMFDPDMMP BKCGHNNBNBL, AvatarHandDisplaySettings JLDKPAAABKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x76CC140", Offset = "0x76CB540", VA = "0x1876CC140", Slot = "12")]
	public void FGJMKMFEMHM(bool IBPGEKGMGLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x76CC460", Offset = "0x76CB860", VA = "0x1876CC460", Slot = "11")]
	public void MOJBPHJHEJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x137E980", Offset = "0x137DD80", VA = "0x18137E980", Slot = "22")]
	public virtual float PJKMPPFCMMK()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x76CBD10", Offset = "0x76CB110", VA = "0x1876CBD10")]
	private int BDDOLCFPKPG(AFKKKEFLPGM MLGNKPAOBIG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x76CBEA0", Offset = "0x76CB2A0", VA = "0x1876CBEA0")]
	private void BGDLMHACJLD(int PEFHCNDPLBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x76CC820", Offset = "0x76CBC20", VA = "0x1876CC820", Slot = "13")]
	public bool PBEJCKPALDL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x76CC450", Offset = "0x76CB850", VA = "0x1876CC450", Slot = "14")]
	public bool LDCHFNODEEF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x76CC7D0", Offset = "0x76CBBD0", VA = "0x1876CC7D0")]
	private AFKKKEFLPGM OEKMEGOIEBK()
	{
		return default(AFKKKEFLPGM);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x1C66DD0", Offset = "0x1C661D0", VA = "0x181C66DD0", Slot = "15")]
	public void EBOKGDHOLDH(bool IBPGEKGMGLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x76CC410", Offset = "0x76CB810", VA = "0x1876CC410", Slot = "10")]
	public void LACIDKICLHF(int PEFHCNDPLBD, float BCIENGPNEOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x76CC080", Offset = "0x76CB480", VA = "0x1876CC080", Slot = "8")]
	public void BOAHNGALPEF(CNDKGHPACGG DHJOIBPBMPI, bool HLCLADEIGNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x76CC060", Offset = "0x76CB460", VA = "0x1876CC060", Slot = "9")]
	public void BLJOACLDKGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x76CC0F0", Offset = "0x76CB4F0", VA = "0x1876CC0F0", Slot = "16")]
	public void DOKNDBAIJBD(Transform KLDFHLFOOFN, Vector3 MKJEPMILFBJ, Quaternion KBJLKJKDCGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x76CCB50", Offset = "0x76CBF50", VA = "0x1876CCB50")]
	public ACEHPGNKFNG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class BACMLKOLNGP : NGHMJIOLEDC
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class FFIPHBGNAFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public BACMLKOLNGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public List<MFCONHIDCBK> prefabHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public List<MFCONHIDCBK> materialHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public HLFDOLJKNKL<Material[]> loadMaterialsHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public HLFDOLJKNKL<DECBJBGILIP> loadPrefabHandle;

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public FFIPHBGNAFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x76D3730", Offset = "0x76D2B30", VA = "0x1876D3730")]
		internal DJNFHDJGNJD GPOCAAJFJGM(string error)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	public FGHBCIPAAPJ LMMEGLLLOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	public DECBJBGILIP NIBOEGKGEBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private HLFDOLJKNKL<DECBJBGILIP> IABBCIKOCJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private HLFDOLJKNKL<Material[]> HMNHABCCAPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	public Material[] EEGDOMOHAID;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool NNIMGKLGFEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x9C1F60", Offset = "0x9C1360", VA = "0x1809C1F60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x9C1D80", Offset = "0x9C1180", VA = "0x1809C1D80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public JBHNNEJDMMC.KMAIJNBJDFP PDHJIFHGNCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x9943F0", Offset = "0x9937F0", VA = "0x1809943F0")]
		[CompilerGenerated]
		get
		{
			return default(JBHNNEJDMMC.KMAIJNBJDFP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x99A0D0", Offset = "0x9994D0", VA = "0x18099A0D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x76D1090", Offset = "0x76D0490", VA = "0x1876D1090")]
	public BACMLKOLNGP(IDINMFOPJOG LCOILGLMJOJ, FGHBCIPAAPJ LPNOHDGKFBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x76CFD60", Offset = "0x76CF160", VA = "0x1876CFD60", Slot = "6")]
	public override DJNFHDJGNJD AJJPLOPHDKA(List<MFCONHIDCBK> GCJBIGFPFDD, List<MFCONHIDCBK> IGGLCKOJNNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x76D0D40", Offset = "0x76D0140", VA = "0x1876D0D40")]
	public DJNFHDJGNJD OHBNGGLNGDE(List<MFCONHIDCBK> GCJBIGFPFDD, List<MFCONHIDCBK> IGGLCKOJNNO, HLFDOLJKNKL<Material[]> HMNHABCCAPH, [Optional] HLFDOLJKNKL<DECBJBGILIP> COPJLCMPJFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x76D09B0", Offset = "0x76CFDB0", VA = "0x1876D09B0")]
	public (HLFDOLJKNKL<Material[]>, HLFDOLJKNKL<DECBJBGILIP>) MCMFOBOICHO(List<MFCONHIDCBK> GCJBIGFPFDD, List<MFCONHIDCBK> IGGLCKOJNNO)
	{
		return default((HLFDOLJKNKL<Material[]>, HLFDOLJKNKL<DECBJBGILIP>));
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x76D0670", Offset = "0x76CFA70", VA = "0x1876D0670", Slot = "7")]
	public override EDDDFACLKHE JDGLLIGNMAL(uint KHCIAPOHNBN, AvatarSkinnedMeshBoneOrderRemapsData GGDAOGBIBIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x76D07A0", Offset = "0x76CFBA0", VA = "0x1876D07A0")]
	public EDDDFACLKHE LADNBAEMIDK(GameObject MACOPPPDJAK, uint KHCIAPOHNBN, bool OFDCLHNJNHN, bool CGOHCCGPCCO, AvatarSkinnedMeshBoneOrderRemapsData GGDAOGBIBIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x76D0300", Offset = "0x76CF700", VA = "0x1876D0300")]
	public static bool GCJOJGPFJGC(Renderer[] DHPLKIODLHG, string JHFCFINBMNJ, [Out] Renderer AOBLJAIDJCD, [Out] Renderer FEKFGDIJOIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x76D1040", Offset = "0x76D0440", VA = "0x1876D1040", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x76D0230", Offset = "0x76CF630", VA = "0x1876D0230")]
	private (HLFDOLJKNKL<DECBJBGILIP>, HLFDOLJKNKL<Material[]>) FAKDPFMBIAP()
	{
		return default((HLFDOLJKNKL<DECBJBGILIP>, HLFDOLJKNKL<Material[]>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x76D0210", Offset = "0x76CF610", VA = "0x1876D0210")]
	[CompilerGenerated]
	private void CKOHHCDOIKH(DECBJBGILIP HBALBIOOGIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x993AA0", Offset = "0x992EA0", VA = "0x180993AA0")]
	[CompilerGenerated]
	private void CJFBMGFHNJN(Material[] HBALBIOOGIJ)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class AvatarKneeBendTargetController : MonoBehaviour, DAKFJKMHLMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		[HCOGNCHHAAD(GKKLJNPNNON.Self, false, false, false)]
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
		private Vector3 MKCODBLEPFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private Vector3 BMHGIGHGKAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private Vector3 OMEIHCPAMLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private Matrix4x4 BAOCKCGPNIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private bool CGPMIJNJDKL;

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x76CE520", Offset = "0x76CD920", VA = "0x1876CE520", Slot = "4")]
		public void UpdateController(float JNFHMFBFJPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x76CE510", Offset = "0x76CD910", VA = "0x1876CE510", Slot = "6")]
		public void SetEnabled(bool FFOEEMKIKJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x76CE0B0", Offset = "0x76CD4B0", VA = "0x1876CE0B0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x76CEBE0", Offset = "0x76CDFE0", VA = "0x1876CEBE0")]
		public AvatarKneeBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[CBAKGNGODOD]
public struct GIPKNHAPBJD : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	[ReadOnly]
	public MOJOBHGAFLG DCBCBFABCCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	[ReadOnly]
	public int FOBMKEAODAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	public EALIIKDALFP ANOFEJEBBPJ;

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x76D6120", Offset = "0x76D5520", VA = "0x1876D6120", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[CBAKGNGODOD]
[NativeContainer]
public struct EALIIKDALFP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public NativeArray<Vector3> ICOPMAAFPKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public NativeArray<Vector3> FPLAKNMCHCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public NativeArray<Vector4> CDJLDGBLGCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public NativeArray<Vector2> DJPLNIDBKIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public NativeArray<Vector2> JOCCNPFMNOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public NativeArray<Vector2> JILPCEAFHBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public NativeArray<Vector2> KHGDKNBBMKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	public NativeArray<Color> HJBAPDAJDBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	public NativeArray<int> CPINBDBNLGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public NativeArray<int> FEEGBAJOFID;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private NativeArray<int> OKBIFJEKODC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private NativeArray<int> JOKPPIOGMEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public NativeArray<int> GOGLBKCLEGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	public NativeArray<int> CNGAHDLLMCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	public NativeArray<int> GPJOFDHDDPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	public NativeArray<BoneWeight> BNCBOBOKAPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private NativeArray<int> MHBNBGGMEBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private bool LNNNHLFANLN;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public int DCKNFJFKMKI
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x76D2790", Offset = "0x76D1B90", VA = "0x1876D2790")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x76D2590", Offset = "0x76D1990", VA = "0x1876D2590")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int MLGNOAIIFEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x76D29E0", Offset = "0x76D1DE0", VA = "0x1876D29E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x76D25A0", Offset = "0x76D19A0", VA = "0x1876D25A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int EFCLLLDIEKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x76D2AD0", Offset = "0x76D1ED0", VA = "0x1876D2AD0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x76D2AA0", Offset = "0x76D1EA0", VA = "0x1876D2AA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x76D2FE0", Offset = "0x76D23E0", VA = "0x1876D2FE0")]
	public EALIIKDALFP(int JJIDMCADEFA, int OMLNHNIEGID, int HIAFJMIONDF, int LANIBOJEEGA, Allocator JMEGNHGDHIA, int MMIMFFDCAKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x76D27A0", Offset = "0x76D1BA0", VA = "0x1876D27A0")]
	public void EFCBMGCICGM(int CJFNAFNJJLB, Vector3 CHAOGBKCKEH, Vector3 AHDECIMNHGG, Vector4 OOLNPDLPIEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x76D2E30", Offset = "0x76D2230", VA = "0x1876D2E30")]
	public void NBAFBPCJPNE(int CJFNAFNJJLB, BoneWeight MEAFOLFDFBL, NativeSlice<byte> OBGHAFBHOGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x76D2930", Offset = "0x76D1D30", VA = "0x1876D2930")]
	public Color HGJKJIKGIHJ(int CJFNAFNJJLB)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x76D2AB0", Offset = "0x76D1EB0", VA = "0x1876D2AB0")]
	public void KEHGDFHEKLG(int CJFNAFNJJLB, Color NOBKOCLLFNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x76D28E0", Offset = "0x76D1CE0", VA = "0x1876D28E0")]
	public void HBPGCELDAMA(byte BIMJAPHHFLP, int CJFNAFNJJLB, Vector2 DPMOFNCLKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x76D2FD0", Offset = "0x76D23D0", VA = "0x1876D2FD0")]
	public void POFONKINKNE(int CJFNAFNJJLB, int EPDCBDABJAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x76D25B0", Offset = "0x76D19B0", VA = "0x1876D25B0")]
	public bool CGMBNHHFHLF(int BIMJAPHHFLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x76D2810", Offset = "0x76D1C10", VA = "0x1876D2810")]
	public void FFBLCLNKDMP(int MNHKHCPIHFJ, int HGHGCNDALFP, int BFBCILDCBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x76D29F0", Offset = "0x76D1DF0", VA = "0x1876D29F0")]
	public int[] JPGPKOJFCFN(int MNHKHCPIHFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x76D2950", Offset = "0x76D1D50", VA = "0x1876D2950")]
	private NativeSlice<int> IMEIDBOLNAA(int MNHKHCPIHFJ)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x76D25E0", Offset = "0x76D19E0", VA = "0x1876D25E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x76D2AE0", Offset = "0x76D1EE0", VA = "0x1876D2AE0")]
	public Mesh MGBHMKNEIIE([Optional] string LNGJKEMDIKI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[DefaultMember("Item")]
[CBAKGNGODOD]
[NativeContainer]
public struct MOJOBHGAFLG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	public NativeArray<Vector3> ICOPMAAFPKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public NativeArray<Vector3> FPLAKNMCHCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public NativeArray<Vector4> CDJLDGBLGCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public NativeArray<Vector2> DJPLNIDBKIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public NativeArray<Vector2> JOCCNPFMNOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public NativeArray<Vector2> JILPCEAFHBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public NativeArray<Vector2> KHGDKNBBMKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	public NativeArray<Color> HJBAPDAJDBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public NativeArray<int> NMHHDDCCPBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public NativeArray<int> MLBMHJKJJDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public NativeArray<int> MLJPNHGFLEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public NativeArray<int> NAKCGPCNHHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	public NativeArray<bool> NOLCGOAAOJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	public NativeArray<int> HNEMHJDIGJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	public NativeArray<int> NAFNDIDLJGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	public NativeArray<BoneWeight> EJECAJMIOHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private NativeArray<Matrix4x4> APPIKCMDLHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private NativeArray<long> FMKDBDCDMBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private NativeArray<byte> OIKBDKACAIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private NativeArray<int> IGCBBOOABNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private NativeArray<int> DCKHPEFMFDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	public NativeArray<sbyte> ACEBCELBGIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public NativeArray<byte> MKFKFDAIGOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	private NativeArray<int> PFKMLPENIHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private bool LNNNHLFANLN;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int JENAMBIPACK
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xD18FD0", Offset = "0xD183D0", VA = "0x180D18FD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public int FJDOBMBJEHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xBA9180", Offset = "0xBA8580", VA = "0x180BA9180")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int GCPFGHLEIKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x76DC050", Offset = "0x76DB450", VA = "0x1876DC050")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int IMKFNPDDOKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x76DBF40", Offset = "0x76DB340", VA = "0x1876DBF40")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x76DBF50", Offset = "0x76DB350", VA = "0x1876DBF50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public int DCKNFJFKMKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x76DBF10", Offset = "0x76DB310", VA = "0x1876DBF10")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x76DB740", Offset = "0x76DAB40", VA = "0x1876DB740")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public int HBEBCKMJJDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x76DBC80", Offset = "0x76DB080", VA = "0x1876DBC80")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x76DBF20", Offset = "0x76DB320", VA = "0x1876DBF20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public HFFMPENDMEE AEKJLICOGOA
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x76DBF30", Offset = "0x76DB330", VA = "0x1876DBF30")]
		get
		{
			return default(HFFMPENDMEE);
		}
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x76DBF70", Offset = "0x76DB370", VA = "0x1876DBF70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public byte EAHEPFGAENH
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x76DBF60", Offset = "0x76DB360", VA = "0x1876DBF60")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x76DBC90", Offset = "0x76DB090", VA = "0x1876DBC90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public DJMDJNEEDIA JODHLAKLPCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x76DB750", Offset = "0x76DAB50", VA = "0x1876DB750")]
		get
		{
			return default(DJMDJNEEDIA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x76DC080", Offset = "0x76DB480", VA = "0x1876DC080")]
	public MOJOBHGAFLG(IList<Mesh> FIOBADEPIAK, IList<Matrix4x4> HOIOCOJOJJM, IList<bool> NOLCGOAAOJG, byte AFFPLBBLOJI, IList<byte[]> FCHIADDCHCB, IList<long> KOCKHIOHICN, IList<bool> EAPLJNBGHHC, IList<int> HNEMHJDIGJH, IList<int> NPLNEADEMNM, IList<int> MMEDBPFPKJM, Allocator JMEGNHGDHIA, HFFMPENDMEE DEJBHCJFPDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x76DBF80", Offset = "0x76DB380", VA = "0x1876DBF80")]
	public EALIIKDALFP MLIJBIPEHPE(Allocator JMEGNHGDHIA)
	{
		return default(EALIIKDALFP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x76DBCA0", Offset = "0x76DB0A0", VA = "0x1876DBCA0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[CBAKGNGODOD]
public class KGENEOAMKBC : OCLPEOEADBD
{
	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x76D80A0", Offset = "0x76D74A0", VA = "0x1876D80A0")]
	public MOJOBHGAFLG EJEGJMMHJBH()
	{
		return default(MOJOBHGAFLG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x76C8FF0", Offset = "0x76C83F0", VA = "0x1876C8FF0")]
	public KGENEOAMKBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct DJMDJNEEDIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public NativeSlice<Vector3> ICOPMAAFPKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public NativeSlice<Vector3> FPLAKNMCHCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public NativeSlice<Vector4> CDJLDGBLGCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public NativeSlice<Vector2> DJPLNIDBKIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public NativeSlice<Vector2> JOCCNPFMNOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	public NativeSlice<Vector2> JILPCEAFHBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public NativeSlice<Vector2> KHGDKNBBMKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public NativeSlice<Color> HJBAPDAJDBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public NativeSlice<int> LMILJCIMMFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public NativeSlice<int> NAKCGPCNHHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	public NativeSlice<BoneWeight> EJECAJMIOHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public NativeSlice<byte> AGFBMAHHFIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public int AJIACOHOIBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public Matrix4x4 JCJPFHGJEBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public long CJPGAIEKNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	public NativeSlice<byte> OBGHAFBHOGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	public bool HJGIKEGJIDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	public int BDHCPLPHKLE;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal readonly struct KMNHLOMAIEO : IEquatable<KMNHLOMAIEO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	internal readonly Material MEFOBPAMFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	internal readonly BMDLICOBDLK IOGKJAIKDMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	internal readonly BBBIKDINNPL LKIDLDEMDPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	internal readonly IDINMFOPJOG OBPBHLFABFI;

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x76D8AD0", Offset = "0x76D7ED0", VA = "0x1876D8AD0")]
	public KMNHLOMAIEO(Material ANOGJJADLNE, BMDLICOBDLK FCGJMAEHANG, BBBIKDINNPL PDMDFLCCFFL, IDINMFOPJOG OFBICLFFJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x76D88B0", Offset = "0x76D7CB0", VA = "0x1876D88B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x76D86B0", Offset = "0x76D7AB0", VA = "0x1876D86B0", Slot = "4")]
	public bool Equals(KMNHLOMAIEO KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x76D8730", Offset = "0x76D7B30", VA = "0x1876D8730", Slot = "0")]
	public override bool Equals(object BLFGIKOAKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x76D8810", Offset = "0x76D7C10", VA = "0x1876D8810", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyDisplayBehaviour : MonoBehaviour, NNLIIHHADMC
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
		private GEHKDDKOMID avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		[SerializeField]
		private AvatarSkinAssetItem potatoAvatarSkinAssetItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		[FormerlySerializedAs("avatarSkinAsset")]
		[SerializeField]
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
		private EDHLCJGGGBG LONLBLMNCAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		private EGAPJAGIONO MFGFECCKJBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		private APBOJJNEGEB HPBIPHPIKPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private APBOJJNEGEB PMJLLMBGDBP;

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public EDHLCJGGGBG PMLFNHNKAJH
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x76CFC00", Offset = "0x76CF000", VA = "0x1876CFC00", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public EGAPJAGIONO IOKHLOAJJMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x76CFC50", Offset = "0x76CF050", VA = "0x1876CFC50", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public APBOJJNEGEB KBLBNCNJEBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x76CFCA0", Offset = "0x76CF0A0", VA = "0x1876CFCA0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public APBOJJNEGEB ODOHDKFMEAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x76CFCF0", Offset = "0x76CF0F0", VA = "0x1876CFCF0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public Transform DEBDOHLKJBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x76CFD40", Offset = "0x76CF140", VA = "0x1876CFD40", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public GEHKDDKOMID HDDJMHIPOLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x99A290", Offset = "0x999690", VA = "0x18099A290", Slot = "12")]
			get
			{
				return default(GEHKDDKOMID);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x76CEBF0", Offset = "0x76CDFF0", VA = "0x1876CEBF0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x76CF9D0", Offset = "0x76CEDD0", VA = "0x1876CF9D0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x76CF220", Offset = "0x76CE620", VA = "0x1876CF220", Slot = "8")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x76CF9D0", Offset = "0x76CEDD0", VA = "0x1876CF9D0", Slot = "9")]
		public void TeardownAvatarDisplaySystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x76CEEF0", Offset = "0x76CE2F0", VA = "0x1876CEEF0", Slot = "10")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x76CFB10", Offset = "0x76CEF10", VA = "0x1876CFB10")]
		public void UpdatePostIKAnimControllers(float JNFHMFBFJPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x76CFA80", Offset = "0x76CEE80", VA = "0x1876CFA80")]
		private void PHHPJOHPFDK(GameObject BLFGIKOAKOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x76CF620", Offset = "0x76CEA20", VA = "0x1876CF620")]
		private EDHLCJGGGBG OCCJHLBHJBN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x76CF280", Offset = "0x76CE680", VA = "0x1876CF280")]
		private EGAPJAGIONO JFFMNGOGBFA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x76CEC60", Offset = "0x76CE060", VA = "0x1876CEC60")]
		private APBOJJNEGEB BKCCFKIBCHA(BGOCLMPPLEM PBLGGONEKMP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x76CFBF0", Offset = "0x76CEFF0", VA = "0x1876CFBF0")]
		public AvatarModernBodyDisplayBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class MNIMKLBOFPM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private MaterialPropertyBlock FCJJLEIAMJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	public Color? IMLNIOGJCDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	public Color? FKNEOAFBMGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	public Color? ILMICKLMJLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	public Color? LPHIAKCKCBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	public Color BBLOGEFICMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	public Color KAPBBKKGNNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	public Color BIGGHCFJBIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	public Texture2D BMJHMNCBPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	public Texture2D POCMOAENGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	private Dictionary<KMNHLOMAIEO, int> PEGFIHJCACG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	private BMDLICOBDLK[] JGJLLKKNOFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	private BBBIKDINNPL[] HIGNAIECCOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public Vector4[] CLCHDFDBAFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public Vector4[] HLDFLGPIJLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public Vector4[] NCLBFFGCEGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public Vector4[] LDEAGOHNDED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public Vector4[] PGLCOOKMMOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public Vector4[] NCNLJOCEDEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private List<Texture2D> PDIKLIPGAFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private Vector4[] NPKCNELMPIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private List<Texture2D> PEDHHLIHPBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private float[] MANFKHCMJFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private Vector4[] EFHCINIPBIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private float[] CDGOIDKMLFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public float[] GLAIPPOGFPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private List<Texture2D> OBOJECKBAJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private float[] AMIHHLCHKCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private List<Texture2D> AMDOMHGBAIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	private Vector4[] KCFGOMICIPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private float[] BGPIHCNFCLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private Vector4[] ELHAAJNHJMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public float[] BLCEPEEOFGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public Texture2DArray ADKGLHJJDHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	public Texture2DArray NINMEGLIBKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	public Texture2DArray PKJCFIGLEGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public Texture2DArray NBLDBCCEBBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private bool FJJGNKIJDDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	private int KEAIEDHDBHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private Vector2? LCJCEOMDLGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private TextureFormat JPIMEBPPPHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private Vector2? AJEDOBAHPGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private TextureFormat FFAPLJKONGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	private Vector2? IOFOGIOJFKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	private TextureFormat IGFIAKOJGKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private Vector2? CGDIPFHGFPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	private TextureFormat MGJOGAHFONH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	private bool ACJJLPFCEAB;

	[Cpp2IlInjected.Token(Token = "0x400024E")]
	private static int FGHBOELLJJG;

	[Cpp2IlInjected.Token(Token = "0x400024F")]
	private static int GOFOIIOPFEG;

	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private static int LFPHHIFINPA;

	[Cpp2IlInjected.Token(Token = "0x4000251")]
	private static int HNCPFHLAPFG;

	[Cpp2IlInjected.Token(Token = "0x4000252")]
	private static int EOMFPBBCGDK;

	[Cpp2IlInjected.Token(Token = "0x4000253")]
	private static int NLPEANDNGFO;

	[Cpp2IlInjected.Token(Token = "0x4000254")]
	private static int BONGMEFKIGL;

	[Cpp2IlInjected.Token(Token = "0x4000255")]
	private static int NPPOFBNFCAI;

	[Cpp2IlInjected.Token(Token = "0x4000256")]
	private static int JJEFIDGNOKM;

	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private static int CBCOAKJIMEC;

	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private static int HPKFGAABDBI;

	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private static int KIJGPNDKGBN;

	[Cpp2IlInjected.Token(Token = "0x400025A")]
	private static int GBJOIBJGBOC;

	[Cpp2IlInjected.Token(Token = "0x400025B")]
	private static int PBBNIKCJFDD;

	[Cpp2IlInjected.Token(Token = "0x400025C")]
	private static int AIJEEFPJPAG;

	[Cpp2IlInjected.Token(Token = "0x400025D")]
	private static int CABGFDMFNOM;

	[Cpp2IlInjected.Token(Token = "0x400025E")]
	private static int AHLCCMLAEHI;

	[Cpp2IlInjected.Token(Token = "0x400025F")]
	private static int GLMIABFLPCB;

	[Cpp2IlInjected.Token(Token = "0x4000260")]
	private static int IFEGFJJNPOO;

	[Cpp2IlInjected.Token(Token = "0x4000261")]
	private static int LCEAEDEGFIH;

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x76DB190", Offset = "0x76DA590", VA = "0x1876DB190")]
	private MNIMKLBOFPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x76DB680", Offset = "0x76DAA80", VA = "0x1876DB680")]
	public MNIMKLBOFPM(Color HDBPNDDKNHP, Color CGKOBJNHOMJ, Color BPFNAAONJAH, Color? ALHKJGNJMIE, Color? HPAJAPJIFEG, Color? OBJKHJCOIFB, Texture2D PJOKBJHOPOC, Texture2D HOFKALPPLLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x76D8BA0", Offset = "0x76D7FA0", VA = "0x1876D8BA0")]
	internal int BIHOOKHLEPK(Material HNEOFKEOPLL, BMDLICOBDLK FCGJMAEHANG, BBBIKDINNPL PDMDFLCCFFL, IDINMFOPJOG OFBICLFFJFE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x76D8B10", Offset = "0x76D7F10", VA = "0x1876D8B10")]
	private int BIHOOKHLEPK(KMNHLOMAIEO DJBLFBEBKGO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x76D9090", Offset = "0x76D8490", VA = "0x1876D9090")]
	internal int GJLPNGKBAIN(Material HNEOFKEOPLL, Color HKHGLNNHJFE, Color JGBGABHDJDM, Color MGJEBCBGKBF, Color JGKEIMMLDAA, Color FBJAFFGIBBA, Texture2D BHNKJPPPKJL, Vector4 NMHBFLJEHGL, Texture2D ENIOLJKJDPK, Vector4 DKEDKKLLMAD, float GAKAEGEEGMJ, float NLHDHCEBHNP, Texture2D IDHLCEKPBKM, Vector4 FDKENLAPOHL, float JPNJLKBKONM, Texture2D MLECCENGIAK, Color EBPPMIGDMGB, Vector4 JCKPMLJAJPL, BMDLICOBDLK FCGJMAEHANG, BBBIKDINNPL PDMDFLCCFFL, IDINMFOPJOG OFBICLFFJFE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x76D8C90", Offset = "0x76D8090", VA = "0x1876D8C90")]
	private void BJDCPLFLOBD(List<Texture2D> PDIKLIPGAFP, [Out] Texture2DArray IIGFKNHBBBG, [Out] Texture2DArray BFEIBDCJEHP, [Out] Texture2DArray GFANGBJBFNL, [Out] Texture2DArray LHCNINEMBOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x76D9C60", Offset = "0x76D9060", VA = "0x1876D9C60")]
	public void IJAFFOBMDFF(Shader EEMBOGAAGJM, Renderer IDCFNEAMCIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x76D9E60", Offset = "0x76D9260", VA = "0x1876D9E60")]
	private void JOLDPAMLOBF(Shader EEMBOGAAGJM, Renderer IDCFNEAMCIG, int EAAOPJDGAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x76D8E90", Offset = "0x76D8290", VA = "0x1876D8E90")]
	private Color EKGBELAOPJA(Color BGKPJHKNOCB, BMDLICOBDLK AINADGKHJIK)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x76DAB50", Offset = "0x76D9F50", VA = "0x1876DAB50")]
	private Color KBLLLMNKHKH(Color DIFGAKKONCD, BMDLICOBDLK AINADGKHJIK)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x76DACA0", Offset = "0x76DA0A0", VA = "0x1876DACA0")]
	private bool MFFOFHIJGIF(Texture2D FOCDNMEPCLL, BBBIKDINNPL AFJGMPGENGN, [Out] Texture2D LGJMCCNAFCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x76D9DB0", Offset = "0x76D91B0", VA = "0x1876D9DB0")]
	private void IJJNIPNIOAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x76D8E50", Offset = "0x76D8250", VA = "0x1876D8E50", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public abstract class NGHMJIOLEDC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	public readonly IDINMFOPJOG FPIFJDFGNIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	protected bool PFIHILCLIDL;

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public bool IHIJFFEMHCI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xBE3960", Offset = "0xBE2D60", VA = "0x180BE3960")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xBE35F0", Offset = "0xBE29F0", VA = "0x180BE35F0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public bool JCBOFELACPD
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0xBE3600", Offset = "0xBE2A00", VA = "0x180BE3600")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0xBE4590", Offset = "0xBE3990", VA = "0x180BE4590")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public virtual JBHNNEJDMMC.KMAIJNBJDFP CJPGAIEKNAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(JBHNNEJDMMC.KMAIJNBJDFP);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0xBCC2A0", Offset = "0xBCB6A0", VA = "0x180BCC2A0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool OEADJLIMMBG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x11D7590", Offset = "0x11D6990", VA = "0x1811D7590")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public bool KCHOKDOIMCO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x76DD960", Offset = "0x76DCD60", VA = "0x1876DD960")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool FJMMIICMMCB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x76DD950", Offset = "0x76DCD50", VA = "0x1876DD950")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public bool ENGFGDLIFBE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x76DD930", Offset = "0x76DCD30", VA = "0x1876DD930")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x76DD970", Offset = "0x76DCD70", VA = "0x1876DD970")]
	protected NGHMJIOLEDC(IDINMFOPJOG LCOILGLMJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract DJNFHDJGNJD AJJPLOPHDKA(List<MFCONHIDCBK> GCJBIGFPFDD, List<MFCONHIDCBK> IGGLCKOJNNO);

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract EDDDFACLKHE JDGLLIGNMAL(uint KHCIAPOHNBN, AvatarSkinnedMeshBoneOrderRemapsData GGDAOGBIBIG);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class ALENDMJEOHB : GMFDCLOOCLK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	private AvatarSkinAssetItem LNNCCBAOPEH;

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x76CCDE0", Offset = "0x76CC1E0", VA = "0x1876CCDE0")]
	public ALENDMJEOHB(AvatarSkinAssetItem NCDFFKMFIHP, AvatarSkinAssetItem.EIJDJJJBCAD AKDJECDDHGI, IDINMFOPJOG OFBICLFFJFE, [Optional] IAPKGHKBDIJ? PNHJAMLGODD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x76CCB70", Offset = "0x76CBF70", VA = "0x1876CCB70", Slot = "6")]
	public override DJNFHDJGNJD AJJPLOPHDKA(List<MFCONHIDCBK> GCJBIGFPFDD, List<MFCONHIDCBK> IGGLCKOJNNO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class IFECCJINOIE
{
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	private static readonly int[] BEBAJEAPOMB;

	[Cpp2IlInjected.Token(Token = "0x4000269")]
	private static readonly int[] MPFDJLKKJED;

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public static int[] ANABOMLMDPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x76D7930", Offset = "0x76D6D30", VA = "0x1876D7930")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x76D78A0", Offset = "0x76D6CA0", VA = "0x1876D78A0")]
	public static int[] OGAGJJHCIDK(bool GNBPMPBAJAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x76D77F0", Offset = "0x76D6BF0", VA = "0x1876D77F0")]
	public static int FMILLPJIGMK(FIEJAHACKON AGLJMFGGJPE, bool GNBPMPBAJAK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x76D77E0", Offset = "0x76D6BE0", VA = "0x1876D77E0")]
	private static int CBKMBHMMDGA(FIEJAHACKON AGLJMFGGJPE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x76D7880", Offset = "0x76D6C80", VA = "0x1876D7880")]
	private static int IMIPDMKELDC(FIEJAHACKON AGLJMFGGJPE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class ODOAKKMPCPA
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class GOFFIFLNOJH : IEnumerator<CIKDDGFOAFI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private CIKDDGFOAFI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		private CIKDDGFOAFI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x999C60", Offset = "0x999060", VA = "0x180999C60")]
		[DebuggerHidden]
		public GOFFIFLNOJH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x117AC50", Offset = "0x117A050", VA = "0x18117AC50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x76D7790", Offset = "0x76D6B90", VA = "0x1876D7790", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0")]
	public static void OKDGOHLANGB(string NCJKGMLAKGH, int KHCIAPOHNBN, long ADGDEGCLOPF, long GGAMOOBHHLI, long CLLKNPKOEMF, long JHNEPLLGAPF, long AEFEMIBEONL, long LDKKIHJCAKJ, long LLGOLFGFLFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x76DE610", Offset = "0x76DDA10", VA = "0x1876DE610")]
	public static LBKCJDEOHAA EHLEFJFDHMG(JobHandle ICILHMBPHCC, bool IIGMFCNIDFO, bool EGPLPPODLAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x76DE700", Offset = "0x76DDB00", VA = "0x1876DE700")]
	[IteratorStateMachine(typeof(GOFFIFLNOJH))]
	private static IEnumerator<CIKDDGFOAFI> ODKMMNBEDHO(JobHandle GGBKPDHLOJF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class KFFFIKOHMBO
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public enum MGMEMNHIDAP
	{
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		General,
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		ColoredHair
	}

	[Cpp2IlInjected.Token(Token = "0x400026D")]
	public static readonly int FLKGHDCACNB;

	[Cpp2IlInjected.Token(Token = "0x400026E")]
	public static readonly int ONPOMHCJFDI;

	[Cpp2IlInjected.Token(Token = "0x400026F")]
	public static readonly int KJPKAFHOHLM;

	[Cpp2IlInjected.Token(Token = "0x4000270")]
	public static readonly int CABHDMOGIAE;

	[Cpp2IlInjected.Token(Token = "0x4000271")]
	public static readonly int GHNOPJNPMLB;

	[Cpp2IlInjected.Token(Token = "0x4000272")]
	public static readonly int DCBOJMFGAHG;

	[Cpp2IlInjected.Token(Token = "0x4000273")]
	public static readonly int EEIDAECBAFB;

	[Cpp2IlInjected.Token(Token = "0x4000274")]
	public static readonly int JANNBGGGMEE;

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x76D7EB0", Offset = "0x76D72B0", VA = "0x1876D7EB0")]
	public static bool MOHIGNIJEEL(Material ANOGJJADLNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x76D7DF0", Offset = "0x76D71F0", VA = "0x1876D7DF0")]
	public static bool DIDIDHMPOFD(Material ANOGJJADLNE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class GMFDCLOOCLK : NGHMJIOLEDC
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class KKBGCBEFGIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public HLFDOLJKNKL<GameObject> skinAvatarItemPrefabHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public GMFDCLOOCLK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public Action<string> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public KKBGCBEFGIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x76D82D0", Offset = "0x76D76D0", VA = "0x1876D82D0")]
		internal void JJCBHOGGFBF(GameObject result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x76D8190", Offset = "0x76D7590", VA = "0x1876D8190")]
		internal void GPOCAAJFJGM(string error)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	protected AvatarSkinAssetItem LDINOMHFJBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	protected Material[] EOJBNLBGLNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	private readonly AvatarSkinAssetItem.EIJDJJJBCAD IHGPKNNOLDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	private readonly AssetReference LLPIHOEAALM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	private readonly IAPKGHKBDIJ? ABOBGPIPONG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	private SkinnedMeshRenderer[] FNFMHCKLKPJ;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public override JBHNNEJDMMC.KMAIJNBJDFP CJPGAIEKNAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x9943D0", Offset = "0x9937D0", VA = "0x1809943D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(JBHNNEJDMMC.KMAIJNBJDFP);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x9943B0", Offset = "0x9937B0", VA = "0x1809943B0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x76D7660", Offset = "0x76D6A60", VA = "0x1876D7660")]
	public GMFDCLOOCLK(AvatarSkinAssetItem.EIJDJJJBCAD AKDJECDDHGI, AssetReference IMFAHIBIJOM, Material ECNJJPLEAAO, IDINMFOPJOG OFBICLFFJFE, JBHNNEJDMMC.KMAIJNBJDFP LEDGDLJFANA = (JBHNNEJDMMC.KMAIJNBJDFP)0L, [Optional] IAPKGHKBDIJ? PNHJAMLGODD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x76D7540", Offset = "0x76D6940", VA = "0x1876D7540")]
	public GMFDCLOOCLK(AvatarSkinAssetItem.EIJDJJJBCAD AKDJECDDHGI, AssetReference IMFAHIBIJOM, Material ECNJJPLEAAO, JBHNNEJDMMC.KMAIJNBJDFP LEDGDLJFANA = (JBHNNEJDMMC.KMAIJNBJDFP)0L, [Optional] IAPKGHKBDIJ? PNHJAMLGODD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x76D70A0", Offset = "0x76D64A0", VA = "0x1876D70A0", Slot = "6")]
	public override DJNFHDJGNJD AJJPLOPHDKA(List<MFCONHIDCBK> GCJBIGFPFDD, List<MFCONHIDCBK> IGGLCKOJNNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x76D72C0", Offset = "0x76D66C0", VA = "0x1876D72C0", Slot = "7")]
	public override EDDDFACLKHE JDGLLIGNMAL(uint KHCIAPOHNBN, AvatarSkinnedMeshBoneOrderRemapsData GGDAOGBIBIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x76D74D0", Offset = "0x76D68D0", VA = "0x1876D74D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x76D7270", Offset = "0x76D6670", VA = "0x1876D7270")]
	protected void EKKMPFJFKEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class BMLDHDCJJIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	private List<int> DMAKLPDNIIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	private List<BFFMMCEDIOA> LFDGIBAABHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	private HashSet<Transform> OIOOAEHJELK;

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x76D1DA0", Offset = "0x76D11A0", VA = "0x1876D1DA0")]
	public static BMLDHDCJJIL OLAPCIKHFPI(Transform OOLNPDLPIEB, Dictionary<Transform, OutfitType?> OOHAEJHMMKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x76D15C0", Offset = "0x76D09C0", VA = "0x1876D15C0")]
	private void GNFANKEBMFI(Transform OOLNPDLPIEB, IDINMFOPJOG OFBICLFFJFE, Dictionary<Transform, OutfitType?> OOHAEJHMMKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x76D1C70", Offset = "0x76D1070", VA = "0x1876D1C70")]
	private void MOAJJOOHFIJ(Transform OMLNJEFBNLA, IDINMFOPJOG OFBICLFFJFE, bool GLGOBADMILG, OutfitType? MHKBEDJHKOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x76D1880", Offset = "0x76D0C80", VA = "0x1876D1880")]
	public OIGBPKGKDPE LFELLMCCJHI(HashSet<string> CJGCOJPFGLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x76D1F30", Offset = "0x76D1330", VA = "0x1876D1F30")]
	public BMLDHDCJJIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class OIGBPKGKDPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	private List<BFFMMCEDIOA> LFDGIBAABHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	private List<Matrix4x4> JHCPDKIFGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private Transform[] OHIEIFFJDHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	private Matrix4x4[] OLFJJKGLLKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	private Dictionary<IPIHDANOFDN, int> HBLAJNBEPKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	private List<ENHDMLMLLPB> CFCKOKFAAKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	private bool HKOODBFNBJD;

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public int GMILMIAEFMI
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x76DEBD0", Offset = "0x76DDFD0", VA = "0x1876DEBD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public Transform[] IGMPCKCEJNF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x76DEC10", Offset = "0x76DE010", VA = "0x1876DEC10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public Matrix4x4[] FLHMOJNDBJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x76DE920", Offset = "0x76DDD20", VA = "0x1876DE920")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x76DED80", Offset = "0x76DE180", VA = "0x1876DED80")]
	public void MOAJJOOHFIJ(Transform OMLNJEFBNLA, IDINMFOPJOG OFBICLFFJFE, OutfitType? MHKBEDJHKOJ, bool CFMHALEJMMJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x76DEF80", Offset = "0x76DE380", VA = "0x1876DEF80")]
	private void MOAJJOOHFIJ(Transform OMLNJEFBNLA, IDINMFOPJOG OFBICLFFJFE, OutfitType? MHKBEDJHKOJ, bool CFMHALEJMMJ, Matrix4x4 OFLIHEFEBHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x76DE770", Offset = "0x76DDB70", VA = "0x1876DE770")]
	public int BAKNOOIKLBF(IPIHDANOFDN DJBLFBEBKGO, bool CGMKJHPFPCD, [Optional] OutfitType? MHKBEDJHKOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x76DF2C0", Offset = "0x76DE6C0", VA = "0x1876DF2C0")]
	public int OHEMNHADHLF(IDINMFOPJOG OFBICLFFJFE, [Optional] OutfitType? MHKBEDJHKOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x76DEAE0", Offset = "0x76DDEE0", VA = "0x1876DEAE0")]
	public void DABKGJOBKEK(IPIHDANOFDN DJBLFBEBKGO, Matrix4x4 GKPFLJCKNCP, bool CGMKJHPFPCD = false, [Optional] OutfitType? MHKBEDJHKOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x76DE990", Offset = "0x76DDD90", VA = "0x1876DE990")]
	public Matrix4x4 BOEOLHEABAF(IPIHDANOFDN DJBLFBEBKGO, bool CGMKJHPFPCD, [Optional] OutfitType? MHKBEDJHKOJ)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x1212AC0", Offset = "0x1211EC0", VA = "0x181212AC0")]
	public void EFILIADDMKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x76DF3C0", Offset = "0x76DE7C0", VA = "0x1876DF3C0")]
	public OIGBPKGKDPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct IPIHDANOFDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public readonly string BCJDAILMDGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public readonly IDINMFOPJOG OBPBHLFABFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public readonly OutfitType? BBEGOPLAFFE;

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x76D7D00", Offset = "0x76D7100", VA = "0x1876D7D00")]
	public IPIHDANOFDN(string NKODMGPOEPB, IDINMFOPJOG OFBICLFFJFE, [Optional] OutfitType? MHKBEDJHKOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x76D7C50", Offset = "0x76D7050", VA = "0x1876D7C50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x76D7B90", Offset = "0x76D6F90", VA = "0x1876D7B90")]
	public bool HNBOIHPBBGL(IPIHDANOFDN KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x76D7A80", Offset = "0x76D6E80", VA = "0x1876D7A80", Slot = "0")]
	public override bool Equals(object BLFGIKOAKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x76D7B20", Offset = "0x76D6F20", VA = "0x1876D7B20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct ENHDMLMLLPB : IEquatable<ENHDMLMLLPB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public readonly IDINMFOPJOG OBPBHLFABFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public readonly OutfitType? HPBBGCFCDHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public readonly int KCAGFLMPPFK;

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x76D3720", Offset = "0x76D2B20", VA = "0x1876D3720")]
	public ENHDMLMLLPB(IDINMFOPJOG OFBICLFFJFE, int EBDGFHMKAMK, [Optional] OutfitType? PNJEHGLHHKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x76D3650", Offset = "0x76D2A50", VA = "0x1876D3650", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x696DE30", Offset = "0x696D230", VA = "0x18696DE30")]
	public bool KGLEMNLABAG(IDINMFOPJOG OFBICLFFJFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x76D3440", Offset = "0x76D2840", VA = "0x1876D3440")]
	public bool AMJLHMCPFCL(OutfitType? PNJEHGLHHKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x76D34C0", Offset = "0x76D28C0", VA = "0x1876D34C0", Slot = "4")]
	public bool Equals(ENHDMLMLLPB KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x76D3510", Offset = "0x76D2910", VA = "0x1876D3510", Slot = "0")]
	public override bool Equals(object BLFGIKOAKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x76D3600", Offset = "0x76D2A00", VA = "0x1876D3600", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct BFFMMCEDIOA : IEquatable<BFFMMCEDIOA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public readonly Transform MOKKNOIHNGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public readonly bool OHGFMIHJPOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public readonly IDINMFOPJOG BHMDJIICMOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public readonly OutfitType? BBEGOPLAFFE;

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x76D1570", Offset = "0x76D0970", VA = "0x1876D1570")]
	public BFFMMCEDIOA(Transform OMLNJEFBNLA, bool GLGOBADMILG, IDINMFOPJOG PCKLHMKOHCI, [Optional] OutfitType? EADLJDOKCFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x76D1360", Offset = "0x76D0760", VA = "0x1876D1360", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x76D11E0", Offset = "0x76D05E0", VA = "0x1876D11E0", Slot = "4")]
	public bool Equals(BFFMMCEDIOA KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x76D1100", Offset = "0x76D0500", VA = "0x1876D1100", Slot = "0")]
	public override bool Equals(object BLFGIKOAKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x76D12E0", Offset = "0x76D06E0", VA = "0x1876D12E0", Slot = "2")]
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
		[Cpp2IlInjected.Address(RVA = "0x76D5EB0", Offset = "0x76D52B0", VA = "0x1876D5EB0")]
		public static void DespawnHairHemisphere()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0")]
		public void UpdateValues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x996AD0", Offset = "0x995ED0", VA = "0x180996AD0")]
		public FitMeshHemisphereUpdater()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface LBFPDNMDDAN
{
	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FAMPOKEIFCM(Mesh MPJNANLNCGP, Matrix4x4 DJBBDGIGPGO, byte[] OBGHAFBHOGG, bool MLDLIAHCMCI = false, JBHNNEJDMMC.KMAIJNBJDFP NHMGGEENPLB = (JBHNNEJDMMC.KMAIJNBJDFP)0L, int HNEMHJDIGJH = -1, bool NOLCGOAAOJG = false);

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PKKPOIHKLLC(Allocator JMEGNHGDHIA, HFFMPENDMEE DEJBHCJFPDI, byte AFFPLBBLOJI, [Optional] IList<int> NPLNEADEMNM, [Optional] IList<int> FDELNJIGMDF);
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public readonly struct DECBJBGILIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public readonly GameObject MACOPPPDJAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	private readonly AvatarItemMaterial OFLAGLLFDDA;

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0xA147A0", Offset = "0xA13BA0", VA = "0x180A147A0")]
	public DECBJBGILIP(GameObject MACOPPPDJAK, AvatarItemMaterial OFLAGLLFDDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x76D2060", Offset = "0x76D1460", VA = "0x1876D2060")]
	public void ABBLGDAAIAI(Material ANOGJJADLNE, int POEJHNPGIGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class NIBBKBDOPOL : KKJEIOEMIAF<Task<(GameObject, AvatarItemMaterial)>, DECBJBGILIP>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct ODHBCAMEEHE : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x76DE0A0", Offset = "0x76DD4A0", VA = "0x1876DE0A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x76DE5A0", Offset = "0x76DD9A0", VA = "0x1876DE5A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	private HLFDOLJKNKL<GameObject> FIOFLDFNDMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	private HLFDOLJKNKL<AvatarItemMaterial> BBBDCLECOHI;

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x76DE010", Offset = "0x76DD410", VA = "0x1876DE010")]
	private NIBBKBDOPOL(Task<(GameObject, AvatarItemMaterial)> NHNFPALEEPM, HLFDOLJKNKL<GameObject> IKBFDIPFKFN, HLFDOLJKNKL<AvatarItemMaterial> CAMFKEDDMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x76DDA20", Offset = "0x76DCE20", VA = "0x1876DDA20")]
	public static NIBBKBDOPOL GNHEPACBJCH(AssetReference LOBBHDOHNDA, [Optional] AssetReference CCGEFMGJAEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x76DDE40", Offset = "0x76DD240", VA = "0x1876DDE40", Slot = "11")]
	protected override DECBJBGILIP MFPNANIKEBM(Task<(GameObject, AvatarItemMaterial)> LNJEGKCLOPP)
	{
		return default(DECBJBGILIP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x76DD9A0", Offset = "0x76DCDA0", VA = "0x1876DD9A0", Slot = "12")]
	protected override void DDHGIEAEBOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x76DDEE0", Offset = "0x76DD2E0", VA = "0x1876DDEE0")]
	[AsyncStateMachine(typeof(ODHBCAMEEHE))]
	private static Task<(GameObject, AvatarItemMaterial)> PHGDHIIMLMO(Task<GameObject> JIGKJLBLKMK, Task<AvatarItemMaterial> FJJKLMANNKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class DPONNLKHBFF
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class APHHAIFKCEM : KKJEIOEMIAF<Task<MaterialMapAsset>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private HLFDOLJKNKL<MaterialMapAsset> GGBKPDHLOJF;

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x76CD380", Offset = "0x76CC780", VA = "0x1876CD380")]
		public APHHAIFKCEM(HLFDOLJKNKL<MaterialMapAsset> GGBKPDHLOJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x76CCF40", Offset = "0x76CC340", VA = "0x1876CCF40", Slot = "11")]
		protected override Material[] MFPNANIKEBM(Task<MaterialMapAsset> NHNFPALEEPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x76CCEE0", Offset = "0x76CC2E0", VA = "0x1876CCEE0", Slot = "12")]
		protected override void DDHGIEAEBOC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class GCLJKKELOGK : KKJEIOEMIAF<Task<Material[]>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private List<HLFDOLJKNKL<Material>> JGEIDAMJLAD;

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x76D60B0", Offset = "0x76D54B0", VA = "0x1876D60B0")]
		public GCLJKKELOGK(Task<Material[]> NHNFPALEEPM, List<HLFDOLJKNKL<Material>> JGEIDAMJLAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x76D6060", Offset = "0x76D5460", VA = "0x1876D6060", Slot = "11")]
		protected override Material[] MFPNANIKEBM(Task<Material[]> LNJEGKCLOPP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x76D5F20", Offset = "0x76D5320", VA = "0x1876D5F20", Slot = "12")]
		protected override void DDHGIEAEBOC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	private static readonly GBHBOJAPDOA DPDKJPMBJOA;

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x76D20F0", Offset = "0x76D14F0", VA = "0x1876D20F0")]
	public static HLFDOLJKNKL<Material[]> HGBJLOFFFPN(AssetReference[] AKAIHCJGHFE)
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
		public enum AIFGJAFAFIJ
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
		public enum DHFGNLHLKIK
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
		public enum JCPDPJJOFHL : byte
		{
			[Cpp2IlInjected.Token(Token = "0x400034E")]
			All,
			[Cpp2IlInjected.Token(Token = "0x400034F")]
			LOD0Only,
			[Cpp2IlInjected.Token(Token = "0x4000350")]
			EditorToolAll
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		public struct KCLHFNGCKOB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000351")]
			public readonly Material MEFOBPAMFDE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000352")]
			public readonly AIFGJAFAFIJ IOGKJAIKDMC;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000353")]
			public readonly DHFGNLHLKIK LKIDLDEMDPB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000354")]
			public readonly IDINMFOPJOG OBPBHLFABFI;

			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0x76D8AD0", Offset = "0x76D7ED0", VA = "0x1876D8AD0")]
			public KCLHFNGCKOB(Material ANOGJJADLNE, AIFGJAFAFIJ FCGJMAEHANG, DHFGNLHLKIK PDMDFLCCFFL, IDINMFOPJOG OFBICLFFJFE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x76F2210", Offset = "0x76F1610", VA = "0x1876F2210", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x76D86B0", Offset = "0x76D7AB0", VA = "0x1876D86B0")]
			public bool HNBOIHPBBGL(KCLHFNGCKOB KNCKFHOKGJM)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x76F2090", Offset = "0x76F1490", VA = "0x1876F2090", Slot = "0")]
			public override bool Equals(object BLFGIKOAKOL)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x76F2170", Offset = "0x76F1570", VA = "0x1876F2170", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		protected struct CAMNINMICME : IComparable<CAMNINMICME>, IEquatable<CAMNINMICME>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000355")]
			public int CDFKPLECNLL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000356")]
			public PlayerAvatarDisplayBase JIBLDGHIHFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000357")]
			public IList<AAHMPIDJKPO> IEHPGPLMEIG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000358")]
			public AvatarItemBodyType OHEFLLKJOCN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000359")]
			public DGPDCGECHDA KALGEDNIAFE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400035A")]
			public bool FPOIPCJLODK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400035B")]
			public int[] HANJMFKKEEC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400035C")]
			public float KCOBLCMJBKO;

			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x76EF550", Offset = "0x76EE950", VA = "0x1876EF550", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x76EF3F0", Offset = "0x76EE7F0", VA = "0x1876EF3F0", Slot = "4")]
			public int CompareTo(CAMNINMICME KNCKFHOKGJM)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x76EF410", Offset = "0x76EE810", VA = "0x1876EF410", Slot = "5")]
			public bool Equals(CAMNINMICME KNCKFHOKGJM)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		protected abstract class IIDFKPPJKHC
		{
			[Cpp2IlInjected.Token(Token = "0x200005B")]
			public class DDLBGMLJJLK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000360")]
				public readonly Mesh EFGLFAPJFBK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000361")]
				public readonly Material[] LBPKOMGLGEJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000362")]
				public readonly Transform[] OFBHBOMDAJE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000363")]
				public readonly Matrix4x4[] LGKHNLEDEEJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000364")]
				public readonly Transform HDMLKFHKANN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000365")]
				public readonly bool GJAMHNAJPJK;

				[Cpp2IlInjected.Token(Token = "0x60002FB")]
				[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
				protected DDLBGMLJJLK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002FC")]
				[Cpp2IlInjected.Address(RVA = "0x76F0220", Offset = "0x76EF620", VA = "0x1876F0220")]
				public DDLBGMLJJLK(Mesh MPJNANLNCGP, Material[] NBKGLIELFCO, bool ENMHHBNAGNA, Transform[] HOFLLLMEFDN, Transform HNJDMABBNBC, Matrix4x4[] IADIBMPICNN)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002FD")]
				[Cpp2IlInjected.Address(RVA = "0x76F07C0", Offset = "0x76EFBC0", VA = "0x1876F07C0")]
				private DDLBGMLJJLK(SkinnedMeshRenderer GNGKKHFDIMO, Material[] ANADCFMLJFC)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002FE")]
				[Cpp2IlInjected.Address(RVA = "0x76F06D0", Offset = "0x76EFAD0", VA = "0x1876F06D0")]
				private DDLBGMLJJLK(MeshRenderer AKELHEKLFOB, Transform HNJDMABBNBC, Material[] ANADCFMLJFC)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002FF")]
				[Cpp2IlInjected.Address(RVA = "0x76EFEF0", Offset = "0x76EF2F0", VA = "0x1876EFEF0")]
				public static DDLBGMLJJLK DDALNEPNPOA(Renderer IDCFNEAMCIG, Material[] ANADCFMLJFC)
				{
					return null;
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400035D")]
			public readonly IDINMFOPJOG OBPBHLFABFI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400035E")]
			public readonly Transform GHJKJFFIIIL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400035F")]
			public readonly bool OBHKPOKLBIF;

			[Cpp2IlInjected.Token(Token = "0x1700008C")]
			public virtual bool IHIJFFEMHCI
			{
				[Cpp2IlInjected.Token(Token = "0x60002F4")]
				[Cpp2IlInjected.Address(RVA = "0x9DE710", Offset = "0x9DDB10", VA = "0x1809DE710", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008D")]
			public virtual bool JCBOFELACPD
			{
				[Cpp2IlInjected.Token(Token = "0x60002F5")]
				[Cpp2IlInjected.Address(RVA = "0x9DE710", Offset = "0x9DDB10", VA = "0x1809DE710", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008E")]
			public virtual JBHNNEJDMMC.KMAIJNBJDFP CJPGAIEKNAP
			{
				[Cpp2IlInjected.Token(Token = "0x60002F6")]
				[Cpp2IlInjected.Address(RVA = "0x996AF0", Offset = "0x995EF0", VA = "0x180996AF0", Slot = "6")]
				get
				{
					return default(JBHNNEJDMMC.KMAIJNBJDFP);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008F")]
			public bool HJGIKEGJIDE
			{
				[Cpp2IlInjected.Token(Token = "0x60002F7")]
				[Cpp2IlInjected.Address(RVA = "0x76F17C0", Offset = "0x76F0BC0", VA = "0x1876F17C0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x76F17D0", Offset = "0x76F0BD0", VA = "0x1876F17D0")]
			protected IIDFKPPJKHC(IDINMFOPJOG OFBICLFFJFE, Transform BFAAOIGLKCL, bool LPDIBGCGODP = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract DJNFHDJGNJD AJJPLOPHDKA(List<MFCONHIDCBK> GCJBIGFPFDD, List<MFCONHIDCBK> IGGLCKOJNNO);

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract DDLBGMLJJLK JDGLLIGNMAL(int KHCIAPOHNBN, PlayerHandBones CPHKPMCJKHP);
		}

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		protected class ACEBPOEHGAO : IIDFKPPJKHC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000366")]
			protected readonly BodyPartLODs FNFMHCKLKPJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000367")]
			protected readonly Material[] EOJBNLBGLNN;

			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x76EEBE0", Offset = "0x76EDFE0", VA = "0x1876EEBE0")]
			public ACEBPOEHGAO(IDINMFOPJOG OFBICLFFJFE, BodyPartLODs PNAKGNNPDPL, Material ECNJJPLEAAO, [Optional] Transform BFAAOIGLKCL, bool LPDIBGCGODP = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x76EE920", Offset = "0x76EDD20", VA = "0x1876EE920", Slot = "7")]
			public override DJNFHDJGNJD AJJPLOPHDKA(List<MFCONHIDCBK> GCJBIGFPFDD, List<MFCONHIDCBK> IGGLCKOJNNO)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0x76EE9B0", Offset = "0x76EDDB0", VA = "0x1876EE9B0", Slot = "8")]
			public override DDLBGMLJJLK JDGLLIGNMAL(int KHCIAPOHNBN, PlayerHandBones CPHKPMCJKHP)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x76EEB70", Offset = "0x76EDF70", VA = "0x1876EEB70", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005D")]
		protected class AINOKAFLJHL : IIDFKPPJKHC
		{
			[Cpp2IlInjected.Token(Token = "0x17000090")]
			public override bool IHIJFFEMHCI
			{
				[Cpp2IlInjected.Token(Token = "0x6000304")]
				[Cpp2IlInjected.Address(RVA = "0x9AF690", Offset = "0x9AEA90", VA = "0x1809AF690", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000091")]
			public override bool JCBOFELACPD
			{
				[Cpp2IlInjected.Token(Token = "0x6000305")]
				[Cpp2IlInjected.Address(RVA = "0x76EED70", Offset = "0x76EE170", VA = "0x1876EED70", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000092")]
			public KKCFCNHCCMP CHGPKINKEEF
			{
				[Cpp2IlInjected.Token(Token = "0x6000306")]
				[Cpp2IlInjected.Address(RVA = "0x9943D0", Offset = "0x9937D0", VA = "0x1809943D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000307")]
				[Cpp2IlInjected.Address(RVA = "0x99A2A0", Offset = "0x9996A0", VA = "0x18099A2A0")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000308")]
			[Cpp2IlInjected.Address(RVA = "0x76EEE30", Offset = "0x76EE230", VA = "0x1876EEE30")]
			public AINOKAFLJHL(IDINMFOPJOG OFBICLFFJFE, Transform BFAAOIGLKCL, KKCFCNHCCMP PEDNHHPFCLE, bool LPDIBGCGODP = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0x76EECE0", Offset = "0x76EE0E0", VA = "0x1876EECE0", Slot = "7")]
			public override DJNFHDJGNJD AJJPLOPHDKA(List<MFCONHIDCBK> GCJBIGFPFDD, List<MFCONHIDCBK> IGGLCKOJNNO)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0x996AF0", Offset = "0x995EF0", VA = "0x180996AF0", Slot = "8")]
			public override DDLBGMLJJLK JDGLLIGNMAL(int KHCIAPOHNBN, PlayerHandBones CPHKPMCJKHP)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0x76EEDC0", Offset = "0x76EE1C0", VA = "0x1876EEDC0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005E")]
		public class PIDABBNFJOC
		{
			[Cpp2IlInjected.Token(Token = "0x200005F")]
			public enum ELBBEIJGDJH
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
			public static readonly int NCEEGNMGGJJ;

			[Cpp2IlInjected.Token(Token = "0x400036A")]
			public static readonly int CNMHDDDMMBP;

			[Cpp2IlInjected.Token(Token = "0x400036B")]
			public static readonly int DLMJONEILHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400036C")]
			protected readonly BGOCLMPPLEM PBLGGONEKMP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400036D")]
			protected readonly CNIKIJHBKDD HOFNMCPKLED;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400036E")]
			protected readonly Animator DKPMKGHGDGN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400036F")]
			protected readonly Transform CGFOCOHCLLB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000370")]
			protected readonly Vector3 ALDFICDKBBM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000371")]
			protected readonly Transform GIGJAINOAGK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000372")]
			protected readonly Vector3 IBCAOPFEAAG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000373")]
			protected bool CODCLLFMHBM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000374")]
			protected APBOJJNEGEB JGFPNNAAADM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000375")]
			protected bool EJFCBEEEKFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x4000376")]
			protected float IPDBNPCBEIO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000377")]
			protected EOEMODHNBOJ<AFKKKEFLPGM> MICBKIDNBPH;

			[Cpp2IlInjected.Token(Token = "0x17000093")]
			public APBOJJNEGEB PKHHGFCHIDM
			{
				[Cpp2IlInjected.Token(Token = "0x600030C")]
				[Cpp2IlInjected.Address(RVA = "0x993A80", Offset = "0x992E80", VA = "0x180993A80")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600030D")]
				[Cpp2IlInjected.Address(RVA = "0x993A90", Offset = "0x992E90", VA = "0x180993A90")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000094")]
			public bool BGDDKHMNKLM
			{
				[Cpp2IlInjected.Token(Token = "0x600030E")]
				[Cpp2IlInjected.Address(RVA = "0xB4AEB0", Offset = "0xB4A2B0", VA = "0x180B4AEB0")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600030F")]
				[Cpp2IlInjected.Address(RVA = "0x76F6570", Offset = "0x76F5970", VA = "0x1876F6570")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000095")]
			public bool MFKHEPHOKHO
			{
				[Cpp2IlInjected.Token(Token = "0x6000310")]
				[Cpp2IlInjected.Address(RVA = "0x994380", Offset = "0x993780", VA = "0x180994380")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000311")]
				[Cpp2IlInjected.Address(RVA = "0x76F6100", Offset = "0x76F5500", VA = "0x1876F6100")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000096")]
			public float ENJDMDDAPPF
			{
				[Cpp2IlInjected.Token(Token = "0x6000312")]
				[Cpp2IlInjected.Address(RVA = "0xBE35E0", Offset = "0xBE29E0", VA = "0x180BE35E0")]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000313")]
				[Cpp2IlInjected.Address(RVA = "0x76F5AE0", Offset = "0x76F4EE0", VA = "0x1876F5AE0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000097")]
			public AFKKKEFLPGM ODANBIMJDHD
			{
				[Cpp2IlInjected.Token(Token = "0x6000314")]
				[Cpp2IlInjected.Address(RVA = "0x76F6690", Offset = "0x76F5A90", VA = "0x1876F6690")]
				get
				{
					return default(AFKKKEFLPGM);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x76F5EA0", Offset = "0x76F52A0", VA = "0x1876F5EA0")]
			public bool EAIJDBKEKFK(AFKKKEFLPGM CCLHBAPKJHA, object HHGPJKKLNIG, ELBBEIJGDJH PKKOAIHLPOK)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x76F5DA0", Offset = "0x76F51A0", VA = "0x1876F5DA0")]
			public bool DNCHMGAEKBH(object HHGPJKKLNIG)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x76F6D70", Offset = "0x76F6170", VA = "0x1876F6D70")]
			protected PIDABBNFJOC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x76F6780", Offset = "0x76F5B80", VA = "0x1876F6780")]
			public PIDABBNFJOC(BGOCLMPPLEM PBLGGONEKMP, APBOJJNEGEB OGKJGEDOCHH, Animator DKPMKGHGDGN, Transform CGFOCOHCLLB, Transform GIGJAINOAGK, Vector3 ALDFICDKBBM, Vector3 IBCAOPFEAAG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0x76F61D0", Offset = "0x76F55D0", VA = "0x1876F61D0")]
			private void HOHNEHIGOBG(ushort AIPGKFHCHLI, ushort OGCMOIIIKAF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0x76F5FB0", Offset = "0x76F53B0", VA = "0x1876F5FB0")]
			protected void EFPNDMGMGIG(ushort AIPGKFHCHLI, ushort OGCMOIIIKAF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x76F6280", Offset = "0x76F5680", VA = "0x1876F6280")]
			protected void JELMOFPCPCB(ushort AIPGKFHCHLI, ushort OGCMOIIIKAF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x76F5C20", Offset = "0x76F5020", VA = "0x1876F5C20")]
			protected void BBDFEJJHPEC(ushort AIPGKFHCHLI, ushort OGCMOIIIKAF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x76F6340", Offset = "0x76F5740", VA = "0x1876F6340")]
			protected void JEMIKFMODAD(ushort AIPGKFHCHLI, ushort OGCMOIIIKAF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x76F60A0", Offset = "0x76F54A0", VA = "0x1876F60A0")]
			protected void EJHPPFDIKOJ(ushort AIPGKFHCHLI, ushort OGCMOIIIKAF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x76F5D50", Offset = "0x76F5150", VA = "0x1876F5D50")]
			protected void BHAFPONDEOK(ushort AIPGKFHCHLI, ushort OGCMOIIIKAF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x76F6640", Offset = "0x76F5A40", VA = "0x1876F6640")]
			protected void KLLBOHAPDHA(ushort AIPGKFHCHLI, ushort OGCMOIIIKAF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x76F6450", Offset = "0x76F5850", VA = "0x1876F6450")]
			protected void KFHKEPKLFMO(ushort AIPGKFHCHLI, ushort OGCMOIIIKAF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000060")]
		public class MGOKNFFLJHC : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x4000380")]
			public const int EKGDDCDJEPE = 16;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000381")]
			protected MaterialPropertyBlock FCJJLEIAMJG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000382")]
			public Color? IMLNIOGJCDJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000383")]
			public Color? ILMICKLMJLH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000384")]
			public Color? LPHIAKCKCBC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000385")]
			public Color BBLOGEFICMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x4000386")]
			public Color KAPBBKKGNNE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x4000387")]
			public Color BIGGHCFJBIB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000388")]
			public Texture2D BMJHMNCBPMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000389")]
			public Texture2D POCMOAENGEG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x400038A")]
			protected Dictionary<KCLHFNGCKOB, int> PEGFIHJCACG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x400038B")]
			protected AIFGJAFAFIJ[] JGJLLKKNOFI;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x400038C")]
			public Vector4[] CLCHDFDBAFF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x400038D")]
			public Vector4[] HLDFLGPIJLF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x400038E")]
			public Vector4[] NCLBFFGCEGE;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			public Vector4[] LDEAGOHNDED;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x4000390")]
			public Vector4[] PGLCOOKMMOC;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000391")]
			public Vector4[] NCNLJOCEDEA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000392")]
			protected List<Texture2D> PDIKLIPGAFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000393")]
			protected Vector4[] NPKCNELMPIF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
			[Cpp2IlInjected.Token(Token = "0x4000394")]
			protected List<Texture2D> PEDHHLIHPBC;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
			[Cpp2IlInjected.Token(Token = "0x4000395")]
			protected float[] MANFKHCMJFG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
			[Cpp2IlInjected.Token(Token = "0x4000396")]
			protected Vector4[] EFHCINIPBIA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x4000397")]
			protected float[] CDGOIDKMLFF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
			[Cpp2IlInjected.Token(Token = "0x4000398")]
			public float[] GLAIPPOGFPG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
			[Cpp2IlInjected.Token(Token = "0x4000399")]
			protected List<Texture2D> OBOJECKBAJF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
			[Cpp2IlInjected.Token(Token = "0x400039A")]
			protected float[] AMIHHLCHKCO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
			[Cpp2IlInjected.Token(Token = "0x400039B")]
			protected List<Texture2D> AMDOMHGBAIA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			protected Vector4[] KCFGOMICIPM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
			[Cpp2IlInjected.Token(Token = "0x400039D")]
			protected float[] BGPIHCNFCLK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
			[Cpp2IlInjected.Token(Token = "0x400039E")]
			protected Vector4[] ELHAAJNHJMJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x400039F")]
			public float[] BLCEPEEOFGH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
			[Cpp2IlInjected.Token(Token = "0x40003A0")]
			public Texture2DArray ADKGLHJJDHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x40003A1")]
			public Texture2DArray NINMEGLIBKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
			[Cpp2IlInjected.Token(Token = "0x40003A2")]
			public Texture2DArray PKJCFIGLEGD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
			[Cpp2IlInjected.Token(Token = "0x40003A3")]
			public Texture2DArray NBLDBCCEBBJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x40003A4")]
			protected bool FJJGNKIJDDK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
			[Cpp2IlInjected.Token(Token = "0x40003A5")]
			protected int KEAIEDHDBHB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
			[Cpp2IlInjected.Token(Token = "0x40003A6")]
			protected Vector2? LCJCEOMDLGK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
			[Cpp2IlInjected.Token(Token = "0x40003A7")]
			protected TextureFormat JPIMEBPPPHB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
			[Cpp2IlInjected.Token(Token = "0x40003A8")]
			protected Vector2? AJEDOBAHPGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
			[Cpp2IlInjected.Token(Token = "0x40003A9")]
			protected TextureFormat FFAPLJKONGD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
			[Cpp2IlInjected.Token(Token = "0x40003AA")]
			protected Vector2? IOFOGIOJFKA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
			[Cpp2IlInjected.Token(Token = "0x40003AB")]
			protected TextureFormat IGFIAKOJGKD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
			[Cpp2IlInjected.Token(Token = "0x40003AC")]
			protected Vector2? CGDIPFHGFPI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
			[Cpp2IlInjected.Token(Token = "0x40003AD")]
			protected TextureFormat MGJOGAHFONH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
			[Cpp2IlInjected.Token(Token = "0x40003AE")]
			protected bool ACJJLPFCEAB;

			[Cpp2IlInjected.Token(Token = "0x40003AF")]
			protected static int FGHBOELLJJG;

			[Cpp2IlInjected.Token(Token = "0x40003B0")]
			protected static int GOFOIIOPFEG;

			[Cpp2IlInjected.Token(Token = "0x40003B1")]
			protected static int LFPHHIFINPA;

			[Cpp2IlInjected.Token(Token = "0x40003B2")]
			protected static int HNCPFHLAPFG;

			[Cpp2IlInjected.Token(Token = "0x40003B3")]
			protected static int EOMFPBBCGDK;

			[Cpp2IlInjected.Token(Token = "0x40003B4")]
			protected static int NLPEANDNGFO;

			[Cpp2IlInjected.Token(Token = "0x40003B5")]
			protected static int BONGMEFKIGL;

			[Cpp2IlInjected.Token(Token = "0x40003B6")]
			protected static int NPPOFBNFCAI;

			[Cpp2IlInjected.Token(Token = "0x40003B7")]
			protected static int JJEFIDGNOKM;

			[Cpp2IlInjected.Token(Token = "0x40003B8")]
			protected static int CBCOAKJIMEC;

			[Cpp2IlInjected.Token(Token = "0x40003B9")]
			protected static int HPKFGAABDBI;

			[Cpp2IlInjected.Token(Token = "0x40003BA")]
			protected static int KIJGPNDKGBN;

			[Cpp2IlInjected.Token(Token = "0x40003BB")]
			protected static int GBJOIBJGBOC;

			[Cpp2IlInjected.Token(Token = "0x40003BC")]
			protected static int PBBNIKCJFDD;

			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			protected static int AIJEEFPJPAG;

			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			protected static int CABGFDMFNOM;

			[Cpp2IlInjected.Token(Token = "0x40003BF")]
			protected static int AHLCCMLAEHI;

			[Cpp2IlInjected.Token(Token = "0x40003C0")]
			protected static int GLMIABFLPCB;

			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			protected static int IFEGFJJNPOO;

			[Cpp2IlInjected.Token(Token = "0x40003C2")]
			protected static int LCEAEDEGFIH;

			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x76F5230", Offset = "0x76F4630", VA = "0x1876F5230")]
			protected MGOKNFFLJHC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x76F56F0", Offset = "0x76F4AF0", VA = "0x1876F56F0")]
			public MGOKNFFLJHC(Color HDBPNDDKNHP, Color CGKOBJNHOMJ, Color BPFNAAONJAH, Color? ALHKJGNJMIE, Color? HPAJAPJIFEG, Color? OBJKHJCOIFB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x76F2CC0", Offset = "0x76F20C0", VA = "0x1876F2CC0")]
			public int BIHOOKHLEPK(Material HNEOFKEOPLL, AIFGJAFAFIJ FCGJMAEHANG, DHFGNLHLKIK PDMDFLCCFFL, IDINMFOPJOG OFBICLFFJFE)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x76F2DB0", Offset = "0x76F21B0", VA = "0x1876F2DB0")]
			public int BIHOOKHLEPK(KCLHFNGCKOB DJBLFBEBKGO)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x76F3230", Offset = "0x76F2630", VA = "0x1876F3230")]
			public int GJLPNGKBAIN(Material HNEOFKEOPLL, Color HKHGLNNHJFE, Color JGBGABHDJDM, Color MGJEBCBGKBF, Color JGKEIMMLDAA, Color FBJAFFGIBBA, Texture2D BHNKJPPPKJL, Vector4 NMHBFLJEHGL, Texture2D ENIOLJKJDPK, Vector4 DKEDKKLLMAD, float GAKAEGEEGMJ, float NLHDHCEBHNP, Texture2D IDHLCEKPBKM, Vector4 FDKENLAPOHL, float JPNJLKBKONM, Texture2D MLECCENGIAK, float EMDKEJLLOMJ, Color EBPPMIGDMGB, Vector4 JCKPMLJAJPL, AIFGJAFAFIJ FCGJMAEHANG, DHFGNLHLKIK PDMDFLCCFFL, IDINMFOPJOG OFBICLFFJFE)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x76F2E40", Offset = "0x76F2240", VA = "0x1876F2E40")]
			protected void BJDCPLFLOBD([Out] Texture2DArray IIGFKNHBBBG, [Out] Texture2DArray BFEIBDCJEHP, [Out] Texture2DArray GFANGBJBFNL, [Out] Texture2DArray LHCNINEMBOB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x76F4080", Offset = "0x76F3480", VA = "0x1876F4080")]
			public void IJAFFOBMDFF(PlayerAvatarDisplayBase IGLHCLKLFFD, Renderer IDCFNEAMCIG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x76F4380", Offset = "0x76F3780", VA = "0x1876F4380")]
			protected void JOLDPAMLOBF(PlayerAvatarDisplayBase IGLHCLKLFFD, Renderer IDCFNEAMCIG, int EAAOPJDGAFA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x76F3040", Offset = "0x76F2440", VA = "0x1876F3040")]
			private Color EKGBELAOPJA(Color BGKPJHKNOCB, AIFGJAFAFIJ AINADGKHJIK)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x76F3F30", Offset = "0x76F3330", VA = "0x1876F3F30")]
			private Color HJJNILBELHN(Color PCDLJDGGFFA, AIFGJAFAFIJ AINADGKHJIK)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x76F42F0", Offset = "0x76F36F0", VA = "0x1876F42F0")]
			protected void IJJNIPNIOAO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x76F3000", Offset = "0x76F2400", VA = "0x1876F3000", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x76FD3C0", Offset = "0x76FC7C0", VA = "0x1876FD3C0")]
			public void FJGDBEIDEMI(IDINMFOPJOG OFBICLFFJFE, [Out] Transform BKHMOJGGBFN, [Out] Transform[] HOFLLLMEFDN)
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
		private sealed class HHMGBBBCAKG : IEnumerable<SkinnedMeshRenderer>, IEnumerable, IEnumerator<SkinnedMeshRenderer>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0xDE6750", Offset = "0xDE5B50", VA = "0x180DE6750")]
			[DebuggerHidden]
			public HHMGBBBCAKG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x76F1410", Offset = "0x76F0810", VA = "0x1876F1410", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x76F1690", Offset = "0x76F0A90", VA = "0x1876F1690", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x76F15E0", Offset = "0x76F09E0", VA = "0x1876F15E0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<SkinnedMeshRenderer> IEnumerable<SkinnedMeshRenderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x76F15E0", Offset = "0x76F09E0", VA = "0x1876F15E0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000065")]
		[CompilerGenerated]
		private sealed class HLFFHGFMEDF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003D6")]
			public PlayerAvatarDisplayBase display;

			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
			public HLFFHGFMEDF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x76F16E0", Offset = "0x76F0AE0", VA = "0x1876F16E0")]
			internal bool LDKJIGFJGDL()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class IJEDMANICPE : IEnumerator<CIKDDGFOAFI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003D7")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003D8")]
			private CIKDDGFOAFI <>2__current;

			[Cpp2IlInjected.Token(Token = "0x1700009A")]
			private CIKDDGFOAFI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000346")]
				[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x999C60", Offset = "0x999060", VA = "0x180999C60")]
			[DebuggerHidden]
			public IJEDMANICPE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0x76F1830", Offset = "0x76F0C30", VA = "0x1876F1830", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0x76F1C10", Offset = "0x76F1010", VA = "0x1876F1C10", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000067")]
		[CompilerGenerated]
		private struct KJGLIFLCGHK : IAsyncStateMachine
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
			public FKAIDAOIGIH avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003DD")]
			private bool <forceRebuild>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003DE")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x76F2430", Offset = "0x76F1830", VA = "0x1876F2430", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0x76F2C60", Offset = "0x76F2060", VA = "0x1876F2C60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000068")]
		[CompilerGenerated]
		private sealed class PGGPAGANKJP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003DF")]
			public string overrideIdentifier;

			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
			public PGGPAGANKJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x76F5AB0", Offset = "0x76F4EB0", VA = "0x1876F5AB0")]
			internal bool BEOBNMELGAO(AAHMPIDJKPO selection)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000069")]
		[CompilerGenerated]
		private sealed class OCFLAJMBMAA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003E0")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003E1")]
			public AvatarItemBodyType avatarItemBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003E2")]
			public Func<GOBMEFCJDOP<Dictionary<string, HLFDOLJKNKL<Texture2D>>>> <>9__2;

			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
			public OCFLAJMBMAA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x76F5800", Offset = "0x76F4C00", VA = "0x1876F5800")]
			internal (NAHOFKDLLJE, GOBMEFCJDOP<Dictionary<string, HLFDOLJKNKL<Texture2D>>>) CCMIOCOOJHK(Dictionary<string, FGHBCIPAAPJ> avatarItems)
			{
				return default((NAHOFKDLLJE, GOBMEFCJDOP<Dictionary<string, HLFDOLJKNKL<Texture2D>>>));
			}

			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0x76F5A00", Offset = "0x76F4E00", VA = "0x1876F5A00")]
			internal GOBMEFCJDOP<Dictionary<string, HLFDOLJKNKL<Texture2D>>> ECMEBJJBEKC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0x76F5A70", Offset = "0x76F4E70", VA = "0x1876F5A70")]
			internal void JEPLJHKGCOJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006A")]
		[CompilerGenerated]
		private sealed class ALHIEIDPFCI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003E3")]
			public Transform transformToCheck;

			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
			public ALHIEIDPFCI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x76EEEA0", Offset = "0x76EE2A0", VA = "0x1876EEEA0")]
			internal bool PJLHDNCBKKH(SkinnedMeshRenderer x)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006B")]
		[CompilerGenerated]
		private struct IMHKGDEIJKP : IAsyncStateMachine
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
			[Cpp2IlInjected.Address(RVA = "0x76F1C60", Offset = "0x76F1060", VA = "0x1876F1C60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0x76F1E30", Offset = "0x76F1230", VA = "0x1876F1E30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		protected static readonly int FNCEDKBJHBH;

		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		protected static readonly int NFMCNFALIBI;

		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		protected static readonly int HBJBOGHHIMP;

		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		protected static readonly int NLDOEDBOOJB;

		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		protected static readonly int PDEEDLLAABG;

		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		protected static readonly int EIMECPJNHBN;

		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		protected static readonly int[] HLGCJEPNBMD;

		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		protected static readonly int[] OPOLJJDHNAK;

		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		protected static readonly int[] PGIKKBIHNIJ;

		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		protected static readonly int[] ALKODMLJGDC;

		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		protected static readonly int[] LGGMHDFEMMO;

		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		protected static readonly int[] GNBOBDIKMJI;

		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		protected static List<PlayerAvatarDisplayBase> KNHDNBDMDEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		protected HPMNLDEHFIP GGCHEIHLMAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		protected bool HPEDGPPIECB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		protected bool KJCFNBBKOKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		[SerializeField]
		public AvatarBodyShapeVault BodyShapeVault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		[SerializeField]
		public AvatarFaceShapeVault FaceShapeVault;

		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		protected static readonly int[] JHBKGEEBMPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		[SerializeField]
		protected Material bodyPartMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		protected Dictionary<KCLHFNGCKOB, Material> PIBJKECLMOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		protected Dictionary<KCLHFNGCKOB, Material> HBLKINNFNMI;

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
		protected Material OHCDPDCJFGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		protected EDHLCJGGGBG MDCIBHGGNFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		private APBOJJNEGEB HPBIPHPIKPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		private APBOJJNEGEB PMJLLMBGDBP;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		protected Material IPOIBCKDFNM;

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
		protected FitMeshHemisphere EBADMPMDAMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		protected bool BAJEMGGOHAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		protected KGGLBONGBPM ACPHBAAHEMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		protected bool EMEJGEEDCGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		protected AnchorParamsRestrictions KNKEILADEIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		protected bool BIKCHKJNPEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		protected Transform BDOCHBCOPGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		protected bool FEAMJAMJBLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B1")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		protected bool OFMPECBKPFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		protected Vector3 OLEPJDFPMKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		protected Quaternion BLHBIFHMMPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		protected Vector2 EIOLLFHBNIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		protected FitMeshHemisphere DEMCNFNKLKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		[HCOGNCHHAAD(GKKLJNPNNON.SelfAndChildren, false, false, false)]
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
		protected Collider[] MLOGIHGLHMA;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		protected Collider[] IMEHKDAJOBH;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		protected PIDABBNFJOC[] EELALLDCNAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		[SerializeField]
		protected Mesh faceMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public Dictionary<Renderer, MGOKNFFLJHC> currentPropertyBlocks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		protected Dictionary<Renderer, MGOKNFFLJHC> CANCDLMKOJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		protected BMLDHDCJJIL PAMLFBJIFJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		protected NAHOFKDLLJE FHNKBKNHAEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public FIEJAHACKON DistanceBand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x284")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		protected int ACFOHFCFHMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		protected (bool isLodForced, int forcedLOD) KEMBEPCFGJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		protected EOEMODHNBOJ<CNIKIJHBKDD> MICBKIDNBPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		protected bool EMJKDBLAOJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		protected Dictionary<AAHMPIDJKPO, List<KCLHFNGCKOB>> MNFAPGJFOKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		protected Dictionary<AAHMPIDJKPO, List<KCLHFNGCKOB>> MKGDNHNEIHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		protected readonly Dictionary<string, HLFDOLJKNKL<Texture2D>> JFPHIPLHPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		protected readonly Dictionary<string, HLFDOLJKNKL<Texture2D>> DKNHJGEKFIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		protected bool NDDEINJIFKD;

		[Cpp2IlInjected.Token(Token = "0x400031C")]
		protected static int IJCADCBNING;

		[Cpp2IlInjected.Token(Token = "0x400031D")]
		protected static List<CAMNINMICME> NJKGIHANHEN;

		[Cpp2IlInjected.Token(Token = "0x400031E")]
		protected static List<CAMNINMICME> IIDNMCIINGL;

		[Cpp2IlInjected.Token(Token = "0x400031F")]
		protected static LBKCJDEOHAA EFEJEACIIIC;

		[Cpp2IlInjected.Token(Token = "0x4000320")]
		protected static bool FCHECDECPOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		protected Color? AJEAOLPNEKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E4")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		protected bool GNFFPBLHLIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		protected Color KCHBICHIODF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		protected Color FODAIDKJGJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		protected Color EJEINCINGDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		protected AvatarHairPattern PCPPNOIDFCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		protected KKCFCNHCCMP LOHPKOCINLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		protected Color PBAKINIMBFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		protected Color GMCMPIDMKCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		protected AvatarHairPattern NADIJFDPJOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		protected KKCFCNHCCMP PHDNBILIALE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		protected KKCFCNHCCMP FOLEJFBOKJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		protected Color HAMFOIHPHBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		private AdditionalFeetData BGBHNJJNHIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		protected AAHMPIDJKPO? CABPENICDCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		protected Texture GEALEPIJIMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		protected Color AOPNPGHCDME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		protected readonly IList<AAHMPIDJKPO> AEKJGMPDFOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		protected readonly IList<AAHMPIDJKPO> AJPLOCKOBKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		private AvatarItemBodyType CLIDDLCGIBM;

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
		protected PPJFLGDEIOL _currentNoseType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D4")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		[SerializeField]
		protected bool _hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D5")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		protected JCPDPJJOFHL JNBJPKLFFHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		protected int[] OPENJPLLAGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E0")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		protected bool OEBCIJMABCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E8")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		protected int[] LACFKMCJDPI;

		[Cpp2IlInjected.Token(Token = "0x400033D")]
		private static readonly JBHNNEJDMMC.KMAIJNBJDFP IGALLNNAKAL;

		[Cpp2IlInjected.Token(Token = "0x400033E")]
		private static readonly JBHNNEJDMMC.KMAIJNBJDFP MFGEEMENJJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F0")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		protected bool CKKMAIKCIKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F8")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		protected BGAIKOLNNLM OHGKCIBNBIN;

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public string LKNBJACMPAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x9943F0", Offset = "0x9937F0", VA = "0x1809943F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x994400", Offset = "0x993800", VA = "0x180994400")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public bool IMFHCABELPP
		{
			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0xB459B0", Offset = "0xB44DB0", VA = "0x180B459B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0xB45690", Offset = "0xB44A90", VA = "0x180B45690")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public virtual bool CLABDICFGPL
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x9DE710", Offset = "0x9DDB10", VA = "0x1809DE710", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public bool GPEPGFMLIDB
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x76ECBF0", Offset = "0x76EBFF0", VA = "0x1876ECBF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public virtual bool OPCDNIFHCBF
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x9DE710", Offset = "0x9DDB10", VA = "0x1809DE710", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public virtual bool HPEIAHHKHDP
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x9AF690", Offset = "0x9AEA90", VA = "0x1809AF690", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public virtual bool IJGKDJKAICI
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x9DE710", Offset = "0x9DDB10", VA = "0x1809DE710", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public EDHLCJGGGBG MPLFFAOGBMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0xA0C680", Offset = "0xA0BA80", VA = "0x180A0C680")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x76ED3D0", Offset = "0x76EC7D0", VA = "0x1876ED3D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public APBOJJNEGEB KBLBNCNJEBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0xA04FC0", Offset = "0xA043C0", VA = "0x180A04FC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x76ED7D0", Offset = "0x76ECBD0", VA = "0x1876ED7D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public APBOJJNEGEB ODOHDKFMEAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0xA1A500", Offset = "0xA19900", VA = "0x180A1A500")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x76EDAA0", Offset = "0x76ECEA0", VA = "0x1876EDAA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		protected Material IJDCCHJCGHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x76E0EA0", Offset = "0x76E02A0", VA = "0x1876E0EA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		protected Material MHHPLIHBNPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x76E2710", Offset = "0x76E1B10", VA = "0x1876E2710")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public bool IIJFFHHMJDH
		{
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x2067390", Offset = "0x2066790", VA = "0x182067390")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public PlayerFacialAnimatorBase DDANGGLPDLL
		{
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0xA1A710", Offset = "0xA19B10", VA = "0x180A1A710")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public PIDABBNFJOC[] NPCBOBEJEEB
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x76EC7B0", Offset = "0x76EBBB0", VA = "0x1876EC7B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public PIDABBNFJOC MELBAHGOEPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x76ECE00", Offset = "0x76EC200", VA = "0x1876ECE00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public PIDABBNFJOC EEIALHHFAOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x76ECE30", Offset = "0x76EC230", VA = "0x1876ECE30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public Mesh BFNEBPDOMMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0xA1AF30", Offset = "0xA1A330", VA = "0x180A1AF30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		protected BMLDHDCJJIL JKEEMLHDPJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x76E3EB0", Offset = "0x76E32B0", VA = "0x1876E3EB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		protected NAHOFKDLLJE AHBBOIEPMJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0xA1B2C0", Offset = "0xA1A6C0", VA = "0x180A1B2C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x76E6B80", Offset = "0x76E5F80", VA = "0x1876E6B80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		protected bool EGPLPPODLAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x9AF690", Offset = "0x9AEA90", VA = "0x1809AF690")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public bool CJFBIEFAMDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x76ECDF0", Offset = "0x76EC1F0", VA = "0x1876ECDF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public int KEKHDNIPPCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x20DDFD0", Offset = "0x20DD3D0", VA = "0x1820DDFD0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x76ED9E0", Offset = "0x76ECDE0", VA = "0x1876ED9E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public int ONCIJFAOIDE
		{
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x76ED720", Offset = "0x76ECB20", VA = "0x1876ED720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		protected virtual bool MBIGFDJJJNB
		{
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x9DE710", Offset = "0x9DDB10", VA = "0x1809DE710", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		protected virtual int[] FOGLLIAAJHL
		{
			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x76E7D90", Offset = "0x76E7190", VA = "0x1876E7D90", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		protected bool IMCHNIOBPHC
		{
			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x76E81F0", Offset = "0x76E75F0", VA = "0x1876E81F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		protected static bool MCKOHILLIBE
		{
			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x9DE710", Offset = "0x9DDB10", VA = "0x1809DE710")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public bool CPHGIJPPKNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x2444A50", Offset = "0x2443E50", VA = "0x182444A50")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x76EDCB0", Offset = "0x76ED0B0", VA = "0x1876EDCB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public IEnumerable<SkinnedMeshRenderer> NMLIPOOBLAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x76EC690", Offset = "0x76EBA90", VA = "0x1876EC690")]
			[IteratorStateMachine(typeof(HHMGBBBCAKG))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public bool LCONPCPHNJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x76ECDE0", Offset = "0x76EC1E0", VA = "0x1876ECDE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x76E1A90", Offset = "0x76E0E90", VA = "0x1876E1A90")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public GEHKDDKOMID BDHJEGDKAFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x76EC710", Offset = "0x76EBB10", VA = "0x1876EC710")]
			get
			{
				return default(GEHKDDKOMID);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public static bool OCJLPNLAIDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x76ECB60", Offset = "0x76EBF60", VA = "0x1876ECB60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		protected static LBKCJDEOHAA GJHOCOOGMHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x76DF9D0", Offset = "0x76DEDD0", VA = "0x1876DF9D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x76E4130", Offset = "0x76E3530", VA = "0x1876E4130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		protected Color ILMICKLMJLH
		{
			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x76E3C10", Offset = "0x76E3010", VA = "0x1876E3C10")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		protected Color LPHIAKCKCBC
		{
			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0x76E7D40", Offset = "0x76E7140", VA = "0x1876E7D40")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		protected Texture2D EPNHLMACAGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0x76E0DB0", Offset = "0x76E01B0", VA = "0x1876E0DB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		protected Color BBLOGEFICMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000296")]
			[Cpp2IlInjected.Address(RVA = "0x76E1C80", Offset = "0x76E1080", VA = "0x1876E1C80")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		protected Color KAPBBKKGNNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000297")]
			[Cpp2IlInjected.Address(RVA = "0x76E3F60", Offset = "0x76E3360", VA = "0x1876E3F60")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public KKCFCNHCCMP DBKHGJDPGOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(RVA = "0x76EC770", Offset = "0x76EBB70", VA = "0x1876EC770")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		protected Texture2D KIDCHBKCIAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000299")]
			[Cpp2IlInjected.Address(RVA = "0x76E63B0", Offset = "0x76E57B0", VA = "0x1876E63B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public float DDCHOMKAFNK
		{
			[Cpp2IlInjected.Token(Token = "0x60002A0")]
			[Cpp2IlInjected.Address(RVA = "0x76EC790", Offset = "0x76EBB90", VA = "0x1876EC790")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public float IGOKIBIBIGD
		{
			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(RVA = "0x76ECBD0", Offset = "0x76EBFD0", VA = "0x1876ECBD0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public bool DLEGKOAGHLK
		{
			[Cpp2IlInjected.Token(Token = "0x60002D5")]
			[Cpp2IlInjected.Address(RVA = "0x12383D0", Offset = "0x12377D0", VA = "0x1812383D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x76ED1A0", Offset = "0x76EC5A0", VA = "0x1876ED1A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action FDBHJHDFJGN
		{
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x76EC3F0", Offset = "0x76EB7F0", VA = "0x1876EC3F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x76ECF00", Offset = "0x76EC300", VA = "0x1876ECF00")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action FDDADAMEHJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x76EC350", Offset = "0x76EB750", VA = "0x1876EC350")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x76ECE60", Offset = "0x76EC260", VA = "0x1876ECE60")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action CIEAHGICGDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x76EC490", Offset = "0x76EB890", VA = "0x1876EC490")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x76ECFA0", Offset = "0x76EC3A0", VA = "0x1876ECFA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action ONENBFFFMOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x76EC530", Offset = "0x76EB930", VA = "0x1876EC530")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x76ED040", Offset = "0x76EC440", VA = "0x1876ED040")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<BGOCLMPPLEM, AFKKKEFLPGM> PDGPCKBEHAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x76EC5D0", Offset = "0x76EB9D0", VA = "0x1876EC5D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x76ED0E0", Offset = "0x76EC4E0", VA = "0x1876ED0E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x76E9170", Offset = "0x76E8570", VA = "0x1876E9170")]
		public bool SetDeformation(bool HPEDGPPIECB, bool KJCFNBBKOKC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x76E10E0", Offset = "0x76E04E0", VA = "0x1876E10E0")]
		protected static Material CJCCBFFCCFH(Dictionary<KCLHFNGCKOB, Material> ILNLOAGHLCL, Material DDDEEPBEPAO, AIFGJAFAFIJ FCGJMAEHANG, DHFGNLHLKIK PDMDFLCCFFL, IDINMFOPJOG OFBICLFFJFE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x76E3300", Offset = "0x76E2700", VA = "0x1876E3300")]
		protected void IFGCNPIHAGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x76DF530", Offset = "0x76DE930", VA = "0x1876DF530")]
		protected bool AAHMDPKKKAO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x76E1FA0", Offset = "0x76E13A0", VA = "0x1876E1FA0")]
		protected void EFMGELFPNPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x76E3C60", Offset = "0x76E3060", VA = "0x1876E3C60", Slot = "10")]
		protected virtual void IPLDLCIMAGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x76E7440", Offset = "0x76E6840", VA = "0x1876E7440")]
		public int MeshesAtLODCount(int GBLAEFKBGCM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x76E4300", Offset = "0x76E3700", VA = "0x1876E4300")]
		protected static void KAAJFPBDJHC(Dictionary<AAHMPIDJKPO, List<KCLHFNGCKOB>> IMOLDFICHHJ, IIDFKPPJKHC DGIJJDIIGND, Material DDDEEPBEPAO, AIFGJAFAFIJ AINADGKHJIK, DHFGNLHLKIK AFJGMPGENGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x76E0560", Offset = "0x76DF960", VA = "0x1876E0560")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x76E7970", Offset = "0x76E6D70", VA = "0x1876E7970")]
		protected void NHAFOJEOCJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x76E7E70", Offset = "0x76E7270", VA = "0x1876E7E70")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "11")]
		protected virtual void POPKDBMJAFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x76E7500", Offset = "0x76E6900", VA = "0x1876E7500")]
		protected static void NBMHLGDIFMG(List<Material> MAFIKJJPIMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x76E83D0", Offset = "0x76E77D0", VA = "0x1876E83D0")]
		protected static void POKCAMDDOIP(Dictionary<KCLHFNGCKOB, Material> ILNLOAGHLCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x76E4F50", Offset = "0x76E4350", VA = "0x1876E4F50")]
		protected static void LGFIIOPNNHB(Dictionary<Renderer, MGOKNFFLJHC> DNHPNPEGPAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x76E82B0", Offset = "0x76E76B0", VA = "0x1876E82B0")]
		protected void PNBMGLOLACA(SkinnedMeshRenderer[] DHPLKIODLHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x76E6C60", Offset = "0x76E6060", VA = "0x1876E6C60")]
		protected void MLLEFHFKKKK(SkinnedMeshRenderer GNGKKHFDIMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x76E6D00", Offset = "0x76E6100", VA = "0x1876E6D00")]
		protected void MLLEFHFKKKK(MeshRenderer AKELHEKLFOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x76E2040", Offset = "0x76E1440", VA = "0x1876E2040")]
		protected void EJGMMDEOKAK(List<MFCONHIDCBK> GKEOOMMAFFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x76E3FB0", Offset = "0x76E33B0", VA = "0x1876E3FB0")]
		protected void JLNCLMAEMIL(Dictionary<string, HLFDOLJKNKL<Texture2D>> IMOLDFICHHJ, bool JKFHNJNLLNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x76E73F0", Offset = "0x76E67F0", VA = "0x1876E73F0")]
		protected void MPHFOLGMNBA(Dictionary<AAHMPIDJKPO, List<KCLHFNGCKOB>> IMOLDFICHHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x76E2CB0", Offset = "0x76E20B0", VA = "0x1876E2CB0")]
		public float GetHandOpenClosedAxis(BGOCLMPPLEM PBLGGONEKMP)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x76E9A30", Offset = "0x76E8E30", VA = "0x1876E9A30")]
		public void SetHandOpenClosedAxis(BGOCLMPPLEM PBLGGONEKMP, float BPJKPOPBCPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x76E2CF0", Offset = "0x76E20F0", VA = "0x1876E2CF0")]
		public AFKKKEFLPGM GetHandVisualState(BGOCLMPPLEM PBLGGONEKMP)
		{
			return default(AFKKKEFLPGM);
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x76DFCA0", Offset = "0x76DF0A0", VA = "0x1876DFCA0")]
		public bool AddHandVisualStateToken(BGOCLMPPLEM PBLGGONEKMP, AFKKKEFLPGM IKNOMGPBMCJ, object HHGPJKKLNIG, PIDABBNFJOC.ELBBEIJGDJH PKKOAIHLPOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x76EB240", Offset = "0x76EA640", VA = "0x1876EB240")]
		public void SetWatchHand(BGOCLMPPLEM PBLGGONEKMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x76EB300", Offset = "0x76EA700", VA = "0x1876EB300")]
		public void SetWatchHands(bool GAJJCFDOEHB, bool GCMBNFALADB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x76E8810", Offset = "0x76E7C10", VA = "0x1876E8810")]
		public bool RemoveHandVisualStateToken(BGOCLMPPLEM PBLGGONEKMP, object HHGPJKKLNIG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x76E2D70", Offset = "0x76E2170", VA = "0x1876E2D70")]
		public bool GetThumbsUpActive(BGOCLMPPLEM PBLGGONEKMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x76EACE0", Offset = "0x76EA0E0", VA = "0x1876EACE0")]
		public void SetThumbsUpActive(BGOCLMPPLEM PBLGGONEKMP, bool PMDAIKCNLLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x76E2D30", Offset = "0x76E2130", VA = "0x1876E2D30")]
		public bool GetHandshakeActive(BGOCLMPPLEM PBLGGONEKMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x76E9A80", Offset = "0x76E8E80", VA = "0x1876E9A80")]
		public void SetHandshakeActive(BGOCLMPPLEM PBLGGONEKMP, bool FHGFFLONCJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x76E2800", Offset = "0x76E1C00", VA = "0x1876E2800")]
		public void ForceUpdateHandsVisualState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x76E1970", Offset = "0x76E0D70", VA = "0x1876E1970")]
		public static void ClearQueuedBuilds()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x76DFB70", Offset = "0x76DEF70", VA = "0x1876DFB70")]
		private static void AKBBOMJEMBJ(Scene GMKDGAGFJCJ, LoadSceneMode KGLDBFDNHBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x76E3DA0", Offset = "0x76E31A0", VA = "0x1876E3DA0")]
		protected static void JFMFPOMJHGG(PlayerAvatarDisplayBase ELPCHJGNIIO, List<CAMNINMICME> IGKDFMNLNMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x76E8530", Offset = "0x76E7930", VA = "0x1876E8530")]
		public void Rebuild(bool HKODJPLEAAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x76E64B0", Offset = "0x76E58B0", VA = "0x1876E64B0")]
		protected void LMPIKDLENDE(bool HKODJPLEAAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x76E6500", Offset = "0x76E5900", VA = "0x1876E6500", Slot = "12")]
		protected virtual DJNFHDJGNJD LMPIKDLENDE(IList<AAHMPIDJKPO> GADNLLBBOFP, AvatarItemBodyType ALPNAIIGFFB, bool OIOIAELKKLB, int[] DGCLBIBMELG, bool HKODJPLEAAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x76E6DD0", Offset = "0x76E61D0", VA = "0x1876E6DD0")]
		protected static DJNFHDJGNJD MPCJLJBLCLC(CAMNINMICME JMADLFJJHHK, List<CAMNINMICME> IGKDFMNLNMI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x76E3650", Offset = "0x76E2A50", VA = "0x1876E3650")]
		[IteratorStateMachine(typeof(IJEDMANICPE))]
		protected static IEnumerator<CIKDDGFOAFI> IMIKLEJMCME()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x76E6AC0", Offset = "0x76E5EC0", VA = "0x1876E6AC0")]
		protected static CAMNINMICME MEEECEIPJJA(List<CAMNINMICME> IGKDFMNLNMI)
		{
			return default(CAMNINMICME);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x76E9280", Offset = "0x76E8680", VA = "0x1876E9280")]
		[AsyncStateMachine(typeof(KJGLIFLCGHK))]
		public Task SetFaceCustomizationSettings(FKAIDAOIGIH IGGKLFCOGPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x76E3CC0", Offset = "0x76E30C0", VA = "0x1876E3CC0")]
		public void InitializeFaceFeatures(AvatarConfiguration NEBFOMGFFFF, GEHKDDKOMID IOAAKAMPEPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x76EAA30", Offset = "0x76E9E30", VA = "0x1876EAA30")]
		public void SetTeamColors(Color? OBJKHJCOIFB, bool MEJBCMHAAFD, Color JGICKNPJCFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x119DD20", Offset = "0x119D120", VA = "0x18119DD20")]
		private static void FAIKHKHADCM(Material ANOGJJADLNE, Color FFOEEMKIKJO, params int[] HDAEADJOMHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x119DC80", Offset = "0x119D080", VA = "0x18119DC80")]
		private static void CAFPBBLIMPD(Material ANOGJJADLNE, Texture FFOEEMKIKJO, params int[] HDAEADJOMHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x76DF750", Offset = "0x76DEB50", VA = "0x1876DF750")]
		protected void ABCPHBNIOFK(Material DILEJOPAIDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x76E2B90", Offset = "0x76E1F90", VA = "0x1876E2B90")]
		protected void GKPLDDDFBLD(Material DILEJOPAIDP, Color DMBDFAPEJJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x76E4D20", Offset = "0x76E4120", VA = "0x1876E4D20")]
		protected void LFGAFCALCIN(Material DILEJOPAIDP, Color DMBDFAPEJJI, Color GGOELMDJHNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x76E6190", Offset = "0x76E5590", VA = "0x1876E6190")]
		protected void LMBFBBMBPMO(Material DILEJOPAIDP, Texture2D NPCKAAANCNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x76E6650", Offset = "0x76E5A50", VA = "0x1876E6650")]
		protected void MCAJEEJNDKD(Material DILEJOPAIDP, Texture MIFMMNOOACP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x76E2DB0", Offset = "0x76E21B0", VA = "0x1876E2DB0")]
		protected void HCHJFIPNGKM(Action<MGOKNFFLJHC> KLKPLKKHBOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x76E1CD0", Offset = "0x76E10D0", VA = "0x1876E1CD0")]
		protected void EBOPJCJGKJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x76E4B60", Offset = "0x76E3F60", VA = "0x1876E4B60")]
		protected void LDOHMPIHHBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x76E6760", Offset = "0x76E5B60", VA = "0x1876E6760")]
		protected void MDPLDHJEJHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x76DFFF0", Offset = "0x76DF3F0", VA = "0x1876DFFF0")]
		public void ApplyUgcItemOverrides()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x76E8BD0", Offset = "0x76E7FD0", VA = "0x1876E8BD0")]
		public void SetBeardPrimaryColor([Optional] Color? PDOPNHGHLFK, bool PBGFLEDHDNF = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x76E8E00", Offset = "0x76E8200", VA = "0x1876E8E00")]
		public void SetBeardSecondaryColor([Optional] Color? PDOPNHGHLFK, bool PBGFLEDHDNF = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x76E8A90", Offset = "0x76E7E90", VA = "0x1876E8A90")]
		public void SetBeardPattern([Optional] AvatarHairPattern ADFIGEKKDLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x76E4710", Offset = "0x76E3B10", VA = "0x1876E4710")]
		private void KNFDJENCHNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x76E2660", Offset = "0x76E1A60", VA = "0x1876E2660")]
		private bool FMKGALPGIFI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x76E95F0", Offset = "0x76E89F0", VA = "0x1876E95F0")]
		public void SetHairPrimaryColor([Optional] Color? HNOIDHLIJLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x76E9810", Offset = "0x76E8C10", VA = "0x1876E9810")]
		public void SetHairSecondaryColor([Optional] Color? HNOIDHLIJLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x76E94C0", Offset = "0x76E88C0", VA = "0x1876E94C0")]
		public void SetHairPattern([Optional] AvatarHairPattern ADFIGEKKDLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x76E86B0", Offset = "0x76E7AB0", VA = "0x1876E86B0")]
		public void RefreshHair()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x76E2220", Offset = "0x76E1620", VA = "0x1876E2220")]
		private bool ELHKKJPGFEJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x76EA870", Offset = "0x76E9C70", VA = "0x1876EA870")]
		public void SetSkinColor(Color HDBPNDDKNHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x76EAD30", Offset = "0x76EA130", VA = "0x1876EAD30")]
		public void SetUgcItemVisualOverrides(AAHMPIDJKPO GAGINAEGHAC, GEHKDDKOMID IOAAKAMPEPH, Texture IBNIEKLNIOJ, Color ENONGPNGNOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x76E1A40", Offset = "0x76E0E40", VA = "0x1876E1A40")]
		public void ClearUgcItemVisualOverrides()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x76E9380", Offset = "0x76E8780", VA = "0x1876E9380")]
		public bool SetFaceShape(AvatarFaceShape HFAJOGNGLHF, bool FEPPBEEBJJH = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x76E2AF0", Offset = "0x76E1EF0", VA = "0x1876E2AF0")]
		private void GKKAAKKANDK(GOJPKMAJKNJ FEKPJECLIPO, float FFOEEMKIKJO, bool NKFCDNLGJEL = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x76E28F0", Offset = "0x76E1CF0", VA = "0x1876E28F0")]
		private void GIMONGNFGKH(GNIJEMCHOMF IIDKKAHLLPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x76E3260", Offset = "0x76E2660", VA = "0x1876E3260")]
		private void ICLBPPKDOPK(MBOBCJEIEEI LJELEPPPBKP, float FFOEEMKIKJO, bool COINMODEMLG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x76E7CA0", Offset = "0x76E70A0", VA = "0x1876E7CA0")]
		private void NLECMHNNGNJ(ODNBJGOJGEE ALNKLILJEIN, float FFOEEMKIKJO, bool OKHNDFMBPPK = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x76E2550", Offset = "0x76E1950", VA = "0x1876E2550")]
		private void FCKJHHLCBJK(MELJJIDBPEI LCIBDBLGNEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x76E1AF0", Offset = "0x76E0EF0", VA = "0x1876E1AF0")]
		private void DDOHOAOMAHO(BEJEAHCIOOG CMBGFMPOPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x76E9030", Offset = "0x76E8430", VA = "0x1876E9030")]
		public bool SetBodyShape(AvatarBodyShape KIOFEFFHDLG, bool FEPPBEEBJJH = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x76EA700", Offset = "0x76E9B00", VA = "0x1876EA700")]
		public bool SetNoseType(PPJFLGDEIOL OACPMMCOLIP, bool FEPPBEEBJJH = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x76EB460", Offset = "0x76EA860", VA = "0x1876EB460")]
		public bool UpdateFaceAndBodyShapes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x76EA6E0", Offset = "0x76E9AE0", VA = "0x1876EA6E0")]
		public bool SetHideEars(bool EJLAENPCCGC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x76EA6D0", Offset = "0x76E9AD0", VA = "0x1876EA6D0")]
		public bool SetHelmetHair(HPMNLDEHFIP LIDJNFDDOOH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x76E9AD0", Offset = "0x76E8ED0", VA = "0x1876E9AD0")]
		public void SetHatAnchorParameters(KGGLBONGBPM BJOEGNFCKJL, bool AJIMPEOIDKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x76EB3D0", Offset = "0x76EA7D0", VA = "0x1876EB3D0")]
		public void SetupDisplayLODs(JCPDPJJOFHL BJMNMOKMKED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x76E2F90", Offset = "0x76E2390", VA = "0x1876E2F90")]
		protected int[] IAGHPHHHMCD(JCPDPJJOFHL BJMNMOKMKED)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x76EA7F0", Offset = "0x76E9BF0", VA = "0x1876EA7F0")]
		public void SetOutfitSelections(IList<AAHMPIDJKPO> GADNLLBBOFP, AvatarItemBodyType ALPNAIIGFFB, bool HKODJPLEAAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x76EA830", Offset = "0x76E9C30", VA = "0x1876EA830")]
		public void SetOutfitSelections(IList<AAHMPIDJKPO> GADNLLBBOFP, AvatarItemBodyType ALPNAIIGFFB, bool OIOIAELKKLB, bool HKODJPLEAAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x76EA7A0", Offset = "0x76E9BA0", VA = "0x1876EA7A0")]
		public DJNFHDJGNJD SetOutfitSelections(IList<AAHMPIDJKPO> GADNLLBBOFP, AvatarItemBodyType ALPNAIIGFFB, JCPDPJJOFHL BJMNMOKMKED, bool OIOIAELKKLB, bool FEPPBEEBJJH = false, bool HKODJPLEAAP = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x76E0890", Offset = "0x76DFC90", VA = "0x1876E0890", Slot = "13")]
		protected virtual DJNFHDJGNJD BPBGJPEHOLK(IList<AAHMPIDJKPO> GADNLLBBOFP, AvatarItemBodyType ALPNAIIGFFB, bool OIOIAELKKLB, JCPDPJJOFHL BJMNMOKMKED, bool FEPPBEEBJJH, bool HKODJPLEAAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x76E4910", Offset = "0x76E3D10", VA = "0x1876E4910")]
		protected int[] LBAOLMFCNHP(JCPDPJJOFHL BJMNMOKMKED)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x996AF0", Offset = "0x995EF0", VA = "0x180996AF0", Slot = "14")]
		protected virtual NAHOFKDLLJE BFFLPMJAPNA(AvatarItemBodyType MBNOKBJPAMD, Dictionary<string, FGHBCIPAAPJ> GPIPPLBLJBP, Dictionary<string, HLFDOLJKNKL<Texture2D>> HHBLFKDNNHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x76E0AE0", Offset = "0x76DFEE0", VA = "0x1876E0AE0", Slot = "15")]
		protected virtual DJNFHDJGNJD BPHIEMFKBIJ(IList<AAHMPIDJKPO> GADNLLBBOFP, AvatarItemBodyType ALPNAIIGFFB, bool OIOIAELKKLB, int[] HANJMFKKEEC, DGPDCGECHDA GGPLMPINPBN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x76E36B0", Offset = "0x76E2AB0", VA = "0x1876E36B0", Slot = "16")]
		protected virtual FGHBCIPAAPJ INDPHGDHEKD(KKCFCNHCCMP PEDNHHPFCLE, AvatarItemBodyType MBNOKBJPAMD, IDINMFOPJOG OFBICLFFJFE, FGHBCIPAAPJ EFHCLGJALNA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x996AF0", Offset = "0x995EF0", VA = "0x180996AF0", Slot = "17")]
		protected virtual FGHBCIPAAPJ EJALDHIHJAN(AvatarItemBodyType MBNOKBJPAMD, IDINMFOPJOG OFBICLFFJFE, APPNDOGBMGJ CJADGLGGCKK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x76E1240", Offset = "0x76E0640", VA = "0x1876E1240")]
		protected void CLGPGLHPKKC(OAFHNHABDJM JAEPFHNLNPO, JBHNNEJDMMC.KMAIJNBJDFP ANLHOONNDNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x76DFA20", Offset = "0x76DEE20", VA = "0x1876DFA20")]
		protected void AGAMKJJDBLA(OAFHNHABDJM JAEPFHNLNPO, JBHNNEJDMMC.KMAIJNBJDFP ANLHOONNDNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0xD5A0F0", Offset = "0xD594F0", VA = "0x180D5A0F0", Slot = "18")]
		protected virtual OAFHNHABDJM LADICCBDNCF(OAFHNHABDJM JAEPFHNLNPO, HelmetHairStyle HCLKKILBGCI, bool BABBNGIGJPH, AvatarItemBodyType ALPNAIIGFFB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x76E5140", Offset = "0x76E4540", VA = "0x1876E5140")]
		protected OAFHNHABDJM LKLLDAHKIFK(IList<AAHMPIDJKPO> GADNLLBBOFP, AvatarItemBodyType KKEODBFDIGN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x76E1850", Offset = "0x76E0C50", VA = "0x1876E1850")]
		public void CleanupDisplayResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x76E12C0", Offset = "0x76E06C0", VA = "0x1876E12C0")]
		protected void COMFOACLOIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x76E7640", Offset = "0x76E6A40", VA = "0x1876E7640")]
		protected void NDMEDOAHGBE(Transform CJLLKPOKJAK, IEnumerable<SkinnedMeshRenderer> KPDOOHMKMPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x76E3590", Offset = "0x76E2990", VA = "0x1876E3590")]
		protected JBHNNEJDMMC.KMAIJNBJDFP IKIAMBJPHCA(JBHNNEJDMMC.KMAIJNBJDFP CLCIDDOHAJE, IDINMFOPJOG LCOILGLMJOJ)
		{
			return default(JBHNNEJDMMC.KMAIJNBJDFP);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x76E2030", Offset = "0x76E1430", VA = "0x1876E2030")]
		protected void EJACIKEEOKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x1111B60", Offset = "0x1110F60", VA = "0x181111B60")]
		protected void IAACPJHPEPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x76E3150", Offset = "0x76E2550", VA = "0x1876E3150")]
		protected void IBKPLHBAINL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x76DFAA0", Offset = "0x76DEEA0", VA = "0x1876DFAA0")]
		[AsyncStateMachine(typeof(IMHKGDEIJKP))]
		protected Task AJHODDKNGCN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x76E06F0", Offset = "0x76DFAF0", VA = "0x1876E06F0")]
		protected static AIFGJAFAFIJ BLNPDMNHKGM(IIDFKPPJKHC FFAGJMPJFJA, int HIOGNDFFEBE)
		{
			return default(AIFGJAFAFIJ);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x76E4A10", Offset = "0x76E3E10", VA = "0x1876E4A10")]
		protected static DHFGNLHLKIK LCMGMFIGAOI(IIDFKPPJKHC FFAGJMPJFJA, int HIOGNDFFEBE)
		{
			return default(DHFGNLHLKIK);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x76E7E20", Offset = "0x76E7220", VA = "0x1876E7E20")]
		protected Transform OFAIOMAMGLF(IDINMFOPJOG OFBICLFFJFE, OutfitType MHKBEDJHKOJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x76E2350", Offset = "0x76E1750", VA = "0x1876E2350")]
		protected void FBILMDEFCFG(int POEJHNPGIGD, Material ANOGJJADLNE, IIDFKPPJKHC FFAGJMPJFJA, [Out] Texture2D KNANCOIDGEG, [Out] Vector4 CMHBECGDJEK, [Out] Texture2D DDEHPMDHHJF, [Out] Texture2D KKJBDMNPDAC, [Out] Texture2D POFPEENAKBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x76E3440", Offset = "0x76E2840", VA = "0x1876E3440")]
		protected void IJABFOFLPID(int POEJHNPGIGD, Material ANOGJJADLNE, IIDFKPPJKHC FFAGJMPJFJA, [Out] Color HKHGLNNHJFE, [Out] Color JGBGABHDJDM, [Out] Color MGJEBCBGKBF, [Out] Color JGKEIMMLDAA, [Out] Color FBJAFFGIBBA, [Out] Color EBPPMIGDMGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x76E22E0", Offset = "0x76E16E0", VA = "0x1876E22E0")]
		protected void FAHHGDAHDKG(Vector3 KLIFIKMFFNL, Quaternion APIEPNJDKPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x76EA080", Offset = "0x76E9480", VA = "0x1876EA080")]
		public void SetHatAnchorParameters(KGGLBONGBPM BJOEGNFCKJL, AnchorParamsRestrictions EMJPOFCKJLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x76E1370", Offset = "0x76E0770", VA = "0x1876E1370")]
		public static void CalculateHatAnchorParams(FitMeshHemisphere EBADMPMDAMJ, Transform BDOCHBCOPGF, KGGLBONGBPM BJOEGNFCKJL, AnchorParamsRestrictions KNKEILADEIB, [Out] Vector3 MABKBAPDDLM, [Out] Quaternion NHANCIDGOLF, [Out] KGGLBONGBPM CNJNNGFJCPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x76E8920", Offset = "0x76E7D20", VA = "0x1876E8920")]
		public void ResetHatAnchor(Vector2 JCFCPJPKHPK, Vector3 JJFMMKBGHBD, Vector3 CEGIKJLFFBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0xA072A0", Offset = "0xA066A0", VA = "0x180A072A0")]
		public NHCILBFLPCB GetAnchorParamsRestrictions()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x76DFE20", Offset = "0x76DF220", VA = "0x1876DFE20")]
		public void ApplyBlocks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x76DFF60", Offset = "0x76DF360", VA = "0x1876DFF60")]
		public void ApplyHairPattern()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x76DFD90", Offset = "0x76DF190", VA = "0x1876DFD90")]
		public void ApplyBeardPattern()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x76EB400", Offset = "0x76EA800", VA = "0x1876EB400", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x76E8120", Offset = "0x76E7520", VA = "0x1876E8120")]
		protected void PGIKDDLMAJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x76EB1C0", Offset = "0x76EA5C0", VA = "0x1876EB1C0")]
		public void SetWaitForUgcTextureLoads(bool GJCOKPGPOGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x76EB0D0", Offset = "0x76EA4D0", VA = "0x1876EB0D0")]
		public void SetUgcTextureParameters(BGAIKOLNNLM MHBNBGGMEBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x76EBD40", Offset = "0x76EB140", VA = "0x1876EBD40")]
		public PlayerAvatarDisplayBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x76E3ED0", Offset = "0x76E32D0", VA = "0x1876E3ED0")]
		[CompilerGenerated]
		private void JKBOFMNKAKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x76E2F60", Offset = "0x76E2360", VA = "0x1876E2F60")]
		[CompilerGenerated]
		private void HNODBAMLKGP(MGOKNFFLJHC HPMHIJECEGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x76E4880", Offset = "0x76E3C80", VA = "0x1876E4880")]
		[CompilerGenerated]
		private void KOINPFCBPEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x76E2850", Offset = "0x76E1C50", VA = "0x1876E2850")]
		[CompilerGenerated]
		private void GBHPGMNOCBI(MGOKNFFLJHC HPMHIJECEGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x76E50B0", Offset = "0x76E44B0", VA = "0x1876E50B0")]
		[CompilerGenerated]
		private void LILCNBEOEHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x76E4670", Offset = "0x76E3A70", VA = "0x1876E4670")]
		[CompilerGenerated]
		private void KGMLMPNOFOM(MGOKNFFLJHC HPMHIJECEGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x76E1F10", Offset = "0x76E1310", VA = "0x1876E1F10")]
		[CompilerGenerated]
		private void ECHGPFOLHHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x76E2F10", Offset = "0x76E2310", VA = "0x1876E2F10")]
		[CompilerGenerated]
		private void HMANMJJECJK(MGOKNFFLJHC HPMHIJECEGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x76E45E0", Offset = "0x76E39E0", VA = "0x1876E45E0")]
		[CompilerGenerated]
		private void KFHEHFJDOEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x76E1AA0", Offset = "0x76E0EA0", VA = "0x1876E1AA0")]
		[CompilerGenerated]
		private void DDLMHFLLDGG(MGOKNFFLJHC HPMHIJECEGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x76E1BF0", Offset = "0x76E0FF0", VA = "0x1876E1BF0")]
		[CompilerGenerated]
		private void DIBJANJEAGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x76E3420", Offset = "0x76E2820", VA = "0x1876E3420")]
		[CompilerGenerated]
		private void IICPONBHHKL(MGOKNFFLJHC HPMHIJECEGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x76E3B30", Offset = "0x76E2F30", VA = "0x1876E3B30")]
		[CompilerGenerated]
		internal static bool IOHDNKALLLE(Transform DCCJJNMNFIJ, IEnumerable<SkinnedMeshRenderer> ENBDBLMJPKJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x76E6C20", Offset = "0x76E6020", VA = "0x1876E6C20")]
		[CompilerGenerated]
		private void MJFJJKAMDEL(MGOKNFFLJHC HPMHIJECEGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x76E8270", Offset = "0x76E7670", VA = "0x1876E8270")]
		[CompilerGenerated]
		private void PMJJEMGNMDP(MGOKNFFLJHC HPMHIJECEGN)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[ExecuteAlways]
	public class PlayerFacialAnimatorBase : MonoBehaviour, LEGAGIOCBAL
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		[CompilerGenerated]
		private struct DBIHKBPJAAN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000462")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000463")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000464")]
			public FKAIDAOIGIH avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000465")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000466")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0x76EFC00", Offset = "0x76EF000", VA = "0x1876EFC00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0x76EFE90", Offset = "0x76EF290", VA = "0x1876EFE90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		[CompilerGenerated]
		private struct FMAJONFPDLK : IAsyncStateMachine
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
			public GEHKDDKOMID avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400046F")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600039E")]
			[Cpp2IlInjected.Address(RVA = "0x76F11D0", Offset = "0x76F05D0", VA = "0x1876F11D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0x76F13B0", Offset = "0x76F07B0", VA = "0x1876F13B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		[CompilerGenerated]
		private struct DLCHJIAPLFK : IAsyncStateMachine
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
			public GEHKDDKOMID avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000476")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A0")]
			[Cpp2IlInjected.Address(RVA = "0x76F0880", Offset = "0x76EFC80", VA = "0x1876F0880", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A1")]
			[Cpp2IlInjected.Address(RVA = "0x76F0A20", Offset = "0x76EFE20", VA = "0x1876F0A20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private struct EEIOFEPEKIJ : IAsyncStateMachine
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
			public FKAIDAOIGIH avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400047B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0x76F0FC0", Offset = "0x76F03C0", VA = "0x1876F0FC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0x76F1170", Offset = "0x76F0570", VA = "0x1876F1170", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private struct AMLCJNAJMBB : IAsyncStateMachine
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
			public GEHKDDKOMID avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000480")]
			private TaskAwaiter<IOFGMJBMBAH> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x76EEF50", Offset = "0x76EE350", VA = "0x1876EEF50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x76EF390", Offset = "0x76EE790", VA = "0x1876EF390", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		[CompilerGenerated]
		private struct DLGFBAKAHHJ : IAsyncStateMachine
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
			public GEHKDDKOMID avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000486")]
			private FaceStyleSet <styleSet>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000487")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x76F0A80", Offset = "0x76EFE80", VA = "0x1876F0A80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x76F0F60", Offset = "0x76F0360", VA = "0x1876F0F60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		protected const float MODJLOAAJMP = 0.5f;

		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		protected const int DKKOIODAHKI = 5;

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
		protected static readonly Dictionary<GKOEFNFCCHK.MIIPLMAMHMN, int> HCOKCFAKPFK;

		[Cpp2IlInjected.Token(Token = "0x4000408")]
		[CanBeNull]
		protected static IEnumerable<FaceFeatureType> CLKGEEEABAO;

		[Cpp2IlInjected.Token(Token = "0x4000409")]
		protected static readonly int LGALGPGDMDO;

		[Cpp2IlInjected.Token(Token = "0x400040A")]
		protected static readonly int PBEOEJDCCDE;

		[Cpp2IlInjected.Token(Token = "0x400040B")]
		protected static readonly int NEADABFFHED;

		[Cpp2IlInjected.Token(Token = "0x400040C")]
		protected static readonly int ANOFFGAOEFH;

		[Cpp2IlInjected.Token(Token = "0x400040D")]
		protected static readonly int LAOCDIJDFOA;

		[Cpp2IlInjected.Token(Token = "0x400040E")]
		protected static readonly int JKNKKNNHONO;

		[Cpp2IlInjected.Token(Token = "0x400040F")]
		protected static readonly int ACBHEAOLLCG;

		[Cpp2IlInjected.Token(Token = "0x4000410")]
		protected static readonly int OHMKGMLELFP;

		[Cpp2IlInjected.Token(Token = "0x4000411")]
		protected static Vector2 BCKEMEMCNIB;

		[Cpp2IlInjected.Token(Token = "0x4000412")]
		protected static Vector2 IEOMPKIMMPH;

		[Cpp2IlInjected.Token(Token = "0x4000413")]
		protected static Vector2 IMGKJKENHEE;

		[Cpp2IlInjected.Token(Token = "0x4000414")]
		protected static Vector2 KCFFHPHAJEK;

		[Cpp2IlInjected.Token(Token = "0x4000415")]
		protected static Vector2 FABEOAFAIEF;

		[Cpp2IlInjected.Token(Token = "0x4000416")]
		protected static Vector2 GKNNLOPHOIK;

		[Cpp2IlInjected.Token(Token = "0x4000417")]
		protected static Vector2 JLCFEPBKMLL;

		[Cpp2IlInjected.Token(Token = "0x4000418")]
		protected static Vector2 ELOEENMEACJ;

		[Cpp2IlInjected.Token(Token = "0x4000419")]
		protected static Vector2 DODKNAJBABI;

		[Cpp2IlInjected.Token(Token = "0x400041A")]
		protected static Vector2 BBICCOLGPCD;

		[Cpp2IlInjected.Token(Token = "0x400041B")]
		protected static Vector2 BBFHHNKAEAI;

		[Cpp2IlInjected.Token(Token = "0x400041C")]
		protected static Vector2 DDGOCALBBPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		[SerializeField]
		[HCOGNCHHAAD(GKKLJNPNNON.Self, false, false, false)]
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
		private GEHKDDKOMID DKMLEGKJCAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		private FaceStyleSet MFBAHPJKAMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		[SerializeField]
		protected bool debugEyeJitterInEditor;

		[Cpp2IlInjected.Token(Token = "0x4000426")]
		protected const int EHGAFMNKALN = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		protected int ACLCLLMFFIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		protected int GOGAJGKFIFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		protected int CJIOFCLAHBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		protected int PJLKDFPLHNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		protected Vector2 DOCOPCHNJNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		protected float KKOPLGKDPFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		protected float MECEOEBOEDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		protected float JLICPJFKPKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		protected Vector2 ANGDNKJALCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		protected float EGCIAHLBKCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		protected float LANPMMHDJPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		protected float JEAKADLOJAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		protected Vector2 NBIBALNOJMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		protected float LADNAPGOHIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		protected float HJPBMIKKPMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		protected float MAHGIMMIDPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		protected Vector2 DDACKBLCOJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		protected float EJFBMBAJLJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		protected float JJMGAJGGOAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		protected float KJEGJJAJOFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		protected List<SelectableFaceOption> MDBNIAIABHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		protected List<SelectableFaceOption> KNNBPEPPNCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		protected List<SelectableFaceOption> NHJJHIMDHLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		protected List<SelectableFaceOption> FCNLANDGDEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		protected Coroutine BEJJPECEDGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		protected int? AGEFKIOJHBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		protected int BNFGMFACFKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		protected int BJNCEKENIJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		protected int IECANNPKONL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		protected int CBMMCMCEOFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		protected int ECMLDJDICAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		protected int MOHIMCOEFHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		protected Sprite DHPEMNHEEHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		protected Sprite BOLHOMINADI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		protected Sprite NPLKODFNJOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		protected Sprite HECHDALHDGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		protected bool BIDBFMOAHIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		protected string NLKIOIEGCOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		protected string GIBAMNGAKLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		protected string HFEABMDCNLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		protected string ADGPGOIIJBB;

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
		protected AvatarConfiguration NEBFOMGFFFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		protected IOFGMJBMBAH EPODCKDBMGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		private readonly List<Material> JOEDJELEPFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		protected KMPMOEJAKEI HEPHHKKCJDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		protected Dictionary<string, int> NMKGBOMDEED;

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public FaceStyleSet FINOJKNEDPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0x76FD100", Offset = "0x76FC500", VA = "0x1876FD100")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public bool LOAGEPKNJCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0xA29270", Offset = "0xA28670", VA = "0x180A29270", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x20A13D0", Offset = "0x20A07D0", VA = "0x1820A13D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		protected virtual bool ENAMIIAHILB
		{
			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x9DE710", Offset = "0x9DDB10", VA = "0x1809DE710", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		protected virtual bool JMHLOEEDBKL
		{
			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x9AF690", Offset = "0x9AEA90", VA = "0x1809AF690", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		protected int CNOJADMLEIC
		{
			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x76F73D0", Offset = "0x76F67D0", VA = "0x1876F73D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public Renderer BDAMCKMJEDJ
		{
			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x9943D0", Offset = "0x9937D0", VA = "0x1809943D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public bool JPKMEDHHMLN
		{
			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0xA314E0", Offset = "0xA308E0", VA = "0x180A314E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x76FD3B0", Offset = "0x76FC7B0", VA = "0x1876FD3B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public Renderer[] MDCNHHJDINF
		{
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x9943F0", Offset = "0x9937F0", VA = "0x1809943F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public bool FLDLKCKOLFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x76FD150", Offset = "0x76FC550", VA = "0x1876FD150")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x76FD310", Offset = "0x76FC710", VA = "0x1876FD310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		protected int LCDBPPILJCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x76FA4F0", Offset = "0x76F98F0", VA = "0x1876FA4F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		protected int PNLFCBNOBJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x76F8CB0", Offset = "0x76F80B0", VA = "0x1876F8CB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		public float KGJJLEIEDAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x76FD130", Offset = "0x76FC530", VA = "0x1876FD130")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x76FD2F0", Offset = "0x76FC6F0", VA = "0x1876FD2F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public EGAPJAGIONO IOKHLOAJJMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0xA06C80", Offset = "0xA06080", VA = "0x180A06C80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0xA4C130", Offset = "0xA4B530", VA = "0x180A4C130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public IOFGMJBMBAH LPLPIMJLDOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000384")]
			[Cpp2IlInjected.Address(RVA = "0xA1A720", Offset = "0xA19B20", VA = "0x180A1A720")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000385")]
			[Cpp2IlInjected.Address(RVA = "0x76FD270", Offset = "0x76FC670", VA = "0x1876FD270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public NoseFaceOption EPKDHIBIJHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000386")]
			[Cpp2IlInjected.Address(RVA = "0xA04870", Offset = "0xA03C70", VA = "0x180A04870")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000387")]
			[Cpp2IlInjected.Address(RVA = "0xA96CB0", Offset = "0xA960B0", VA = "0x180A96CB0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		protected KMPMOEJAKEI ADAKNFNGGAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000388")]
			[Cpp2IlInjected.Address(RVA = "0x76FA380", Offset = "0x76F9780", VA = "0x1876FA380")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action KGDEGLKKDBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x76FD050", Offset = "0x76FC450", VA = "0x1876FD050")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0x76FD1C0", Offset = "0x76FC5C0", VA = "0x1876FD1C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x76F9960", Offset = "0x76F8D60", VA = "0x1876F9960")]
		public void LocalPlayEmote(GKOEFNFCCHK.MIIPLMAMHMN OPICNDKBMLI, float GKPGJFIFDKM = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x76F8B90", Offset = "0x76F7F90", VA = "0x1876F8B90")]
		public bool IsEmotePlaying(GKOEFNFCCHK.MIIPLMAMHMN OPICNDKBMLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x76FAF50", Offset = "0x76FA350", VA = "0x1876FAF50")]
		public void SetIdleHappy(bool FNHDCCEAMIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x76F98E0", Offset = "0x76F8CE0", VA = "0x1876F98E0")]
		protected void LMNDIPOMMLL(bool AHEEGMFBPGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x76F76A0", Offset = "0x76F6AA0", VA = "0x1876F76A0")]
		protected void EEGCEFMNPFB(bool FDAHBGIGDJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x76F8640", Offset = "0x76F7A40", VA = "0x1876F8640")]
		protected void IGENDNNLBLO(IDINMFOPJOG OFBICLFFJFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x76F9790", Offset = "0x76F8B90", VA = "0x1876F9790")]
		protected void LDNLLBCBIBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x76FA760", Offset = "0x76F9B60", VA = "0x1876FA760")]
		public void PlayExpression(int LMEBOHPIHGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x76FA2C0", Offset = "0x76F96C0", VA = "0x1876FA2C0")]
		protected void NBFEKGPCPBO(bool LOBIDAEBDJH, bool CHOLEOFDOMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x76F8300", Offset = "0x76F7700", VA = "0x1876F8300")]
		public List<SelectableFaceOption> GetAvailableFeatures(FaceFeatureType PHPMGGFLIFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x76F86B0", Offset = "0x76F7AB0", VA = "0x1876F86B0")]
		public void InitializeFaceFeatureRanges(AvatarConfiguration NEBFOMGFFFF, GEHKDDKOMID IOAAKAMPEPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x76FAD30", Offset = "0x76FA130", VA = "0x1876FAD30")]
		[AsyncStateMachine(typeof(DBIHKBPJAAN))]
		public Task SetFaceSettings(FKAIDAOIGIH IGGKLFCOGPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x76FAE20", Offset = "0x76FA220", VA = "0x1876FAE20")]
		[AsyncStateMachine(typeof(FMAJONFPDLK))]
		public Task SetFaceSettings(int IMEHFPEMGOA, int HGGMDAHCCAG, int KEKJKJIBIIF, int OIMJODNPAIK, GEHKDDKOMID IOAAKAMPEPH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x76FAFD0", Offset = "0x76FA3D0", VA = "0x1876FAFD0")]
		[AsyncStateMachine(typeof(DLCHJIAPLFK))]
		public Task SetSelectedFaceFeatureAndBuildFaceStyle(FaceFeatureType PHPMGGFLIFN, int MHNDPFGPBJL, GEHKDDKOMID IOAAKAMPEPH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x76F8340", Offset = "0x76F7740", VA = "0x1876F8340")]
		protected void HEJFEDMKBCD(FaceFeatureType PHPMGGFLIFN, IAPKGHKBDIJ AJPENPGIMCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x76F8D10", Offset = "0x76F8110", VA = "0x1876F8D10")]
		protected void KADMLJEKEIG(FaceFeatureType PHPMGGFLIFN, int MHNDPFGPBJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x76F8120", Offset = "0x76F7520", VA = "0x1876F8120")]
		public static IEnumerable<FaceFeatureType> GetAllFaceFeatureTypes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x76FA400", Offset = "0x76F9800", VA = "0x1876FA400")]
		[AsyncStateMachine(typeof(EEIOFEPEKIJ))]
		protected Task NGMJJAJJCHF(FKAIDAOIGIH IGGKLFCOGPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x76F7E20", Offset = "0x76F7220", VA = "0x1876F7E20")]
		protected void GNAELALNEBJ(FKAIDAOIGIH IGGKLFCOGPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x76F7500", Offset = "0x76F6900", VA = "0x1876F7500")]
		protected static void CKHCKKJLCNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x76F7B90", Offset = "0x76F6F90", VA = "0x1876F7B90")]
		private void GJBDBKNFBOJ(bool IJOLMMNHAPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x76F7800", Offset = "0x76F6C00", VA = "0x1876F7800")]
		protected void FPDCDCFHBBH(FaceFeatureType PHPMGGFLIFN, Vector2 FDFIPAIMCCP, GEHKDDKOMID IOAAKAMPEPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x76FA780", Offset = "0x76F9B80", VA = "0x1876FA780")]
		public void SetFaceFeatureNormalizedPositionOffset(FaceFeatureType PHPMGGFLIFN, Vector2 CNAPJBKAMFB, GEHKDDKOMID IOAAKAMPEPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x76F84C0", Offset = "0x76F78C0", VA = "0x1876F84C0")]
		protected void HIGCODMFJII(FaceFeatureType PHPMGGFLIFN, float PBGGIDHPDGK, GEHKDDKOMID IOAAKAMPEPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x76F9610", Offset = "0x76F8A10", VA = "0x1876F9610")]
		protected void KHBADLMFFCB(FaceFeatureType PHPMGGFLIFN, float AJFJKBHPFHG, GEHKDDKOMID IOAAKAMPEPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x76F9450", Offset = "0x76F8850", VA = "0x1876F9450")]
		protected void KCMOBMHFCDC(FaceFeatureType PHPMGGFLIFN, float KOMIJPKDNMJ, GEHKDDKOMID IOAAKAMPEPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x76FAB10", Offset = "0x76F9F10", VA = "0x1876FAB10")]
		public void SetFaceFeatureNormalizedScaleOffset(FaceFeatureType PHPMGGFLIFN, float KGKKBNCPIJF, GEHKDDKOMID IOAAKAMPEPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x76F70B0", Offset = "0x76F64B0", VA = "0x1876F70B0")]
		[AsyncStateMachine(typeof(AMLCJNAJMBB))]
		protected Task AOLCAKLFCFM(GEHKDDKOMID IOAAKAMPEPH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x76F8980", Offset = "0x76F7D80", VA = "0x1876F8980")]
		public void InitializeFaceFeatureStyleSet(GEHKDDKOMID IOAAKAMPEPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x76F9800", Offset = "0x76F8C00", VA = "0x1876F9800")]
		protected bool LKPBILCGCBK(string LGGNLAAMAKD, [Out] int CJFNAFNJJLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x76F7190", Offset = "0x76F6590", VA = "0x1876F7190")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x14FD4F0", Offset = "0x14FC8F0", VA = "0x1814FD4F0", Slot = "8")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x76FA550", Offset = "0x76F9950", VA = "0x1876FA550")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x76FC100", Offset = "0x76FB500", VA = "0x1876FC100")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x76F72D0", Offset = "0x76F66D0", VA = "0x1876F72D0")]
		[AsyncStateMachine(typeof(DLGFBAKAHHJ))]
		public Task BuildFaceStyleAsyncIfChanged(GEHKDDKOMID IOAAKAMPEPH, bool FEPPBEEBJJH = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x76FBA20", Offset = "0x76FAE20", VA = "0x1876FBA20")]
		public void UpdateFaceDisplays(bool JFHBCOCFKBL = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x76F9A60", Offset = "0x76F8E60", VA = "0x1876F9A60")]
		protected bool MNLEGCDJOMI(bool JFHBCOCFKBL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x76FB740", Offset = "0x76FAB40", VA = "0x1876FB740")]
		public void UpdateFaceDisplayFeatureTextures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x76FB0E0", Offset = "0x76FA4E0", VA = "0x1876FB0E0")]
		public void UpdateFaceDisplayFeaturePositions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x76FBC30", Offset = "0x76FB030", VA = "0x1876FBC30")]
		public void UpdateFaceJitterMultiplier()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x76FBE20", Offset = "0x76FB220", VA = "0x1876FBE20")]
		public bool UpdateLegacyFaceVectors()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x76F9520", Offset = "0x76F8920", VA = "0x1876F9520")]
		protected void KGOOGKAKIDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x76F6E00", Offset = "0x76F6200", VA = "0x1876F6E00")]
		private void AGJFEKEMLCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x76FCDF0", Offset = "0x76FC1F0", VA = "0x1876FCDF0")]
		public PlayerFacialAnimatorBase()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x9C0950", Offset = "0x9BFD50", VA = "0x1809C0950", Slot = "4")]
		private bool CBMMHJLPIMM()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct DFEAOFEPDMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public string KAFLMFCDNKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public int GEEBDAOOGGP;
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
		private struct JNOINNBFILN : IAsyncStateMachine
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
			[Cpp2IlInjected.Address(RVA = "0x76F1E90", Offset = "0x76F1290", VA = "0x1876F1E90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0x9F4FB0", Offset = "0x9F43B0", VA = "0x1809F4FB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000077")]
		[CompilerGenerated]
		private struct DBEPMMGNCPJ : IAsyncStateMachine
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
			[Cpp2IlInjected.Address(RVA = "0x76EF6A0", Offset = "0x76EEAA0", VA = "0x1876EF6A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DE")]
			[Cpp2IlInjected.Address(RVA = "0x76EFBA0", Offset = "0x76EEFA0", VA = "0x1876EFBA0", Slot = "5")]
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
		public GEHKDDKOMID avatarBodyType;

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
		public HPMNLDEHFIP useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public KGGLBONGBPM hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public NHCILBFLPCB HatAnchorRestrictions;

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
		[HCOGNCHHAAD(GKKLJNPNNON.Self, false, false, false)]
		public PlayerAvatarDisplayBase _avatarDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		private NNLIIHHADMC OKCMGOBEONF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		[SerializeField]
		[HCOGNCHHAAD(GKKLJNPNNON.Self, false, false, false)]
		public PlayerFacialAnimatorBase facialAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public AnimationClip animationClipToOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		private AnimatorOverrideController LBOMEEOCEAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		private List<KeyValuePair<AnimationClip, AnimationClip>> BAOALKOJIHK;

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
		public readonly DFEAOFEPDMF[] FacialExpressions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public readonly string[] BodyPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public readonly (string, AFKKKEFLPGM)[] HandPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public bool hideLeftWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x229")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public bool hideRightWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22A")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		protected bool LNNNHLFANLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22C")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		protected Guid MIEDLDAINOF;

		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		protected static Guid OGELIIALKHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		private EDHLCJGGGBG LONLBLMNCAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		private EGAPJAGIONO MFGFECCKJBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		private APBOJJNEGEB HPBIPHPIKPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		private APBOJJNEGEB PMJLLMBGDBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		private AdditionalHatData DGKMKFHFGDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		private readonly Dictionary<GameObject, KKCFCNHCCMP> MEKBKHJLGBB;

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public static Func<APPNDOGBMGJ> DJNJABGIOAJ
		{
			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x77023D0", Offset = "0x77017D0", VA = "0x1877023D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x7702A10", Offset = "0x7701E10", VA = "0x187702A10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public bool ELHKKJPGFEJ
		{
			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x7702530", Offset = "0x7701930", VA = "0x187702530")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		public bool FMKGALPGIFI
		{
			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x7702420", Offset = "0x7701820", VA = "0x187702420")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public PlayerAvatarDisplayBase IGLHCLKLFFD
		{
			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0xA04FC0", Offset = "0xA043C0", VA = "0x180A04FC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		protected static Guid HFKFAIKEDPC
		{
			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x76FD470", Offset = "0x76FC870", VA = "0x1876FD470")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public (GameObject, IDINMFOPJOG)[] KPAJNPHJCPE
		{
			[Cpp2IlInjected.Token(Token = "0x60003C5")]
			[Cpp2IlInjected.Address(RVA = "0x7702640", Offset = "0x7701A40", VA = "0x187702640")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x77000F0", Offset = "0x76FF4F0", VA = "0x1877000F0")]
		[ContextMenu("Refresh Avatar")]
		private void RebuildTestAvatarContextMenu()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x76FEA80", Offset = "0x76FDE80", VA = "0x1876FEA80")]
		private IEnumerable<GameObject> HGBMALBNGKK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x77005E0", Offset = "0x76FF9E0", VA = "0x1877005E0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x76FF6A0", Offset = "0x76FEAA0", VA = "0x1876FF6A0")]
		private void KAOCLJDGMGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x1182D50", Offset = "0x1182150", VA = "0x181182D50")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x76FEEF0", Offset = "0x76FE2F0", VA = "0x1876FEEF0")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x77005F0", Offset = "0x76FF9F0", VA = "0x1877005F0")]
		public void Teardown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x77003E0", Offset = "0x76FF7E0", VA = "0x1877003E0")]
		public void ShowPose(AnimationClip MPPKBNONGCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x77005B0", Offset = "0x76FF9B0", VA = "0x1877005B0")]
		public void ShowPose(string ADCNIHDPHLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x7700240", Offset = "0x76FF640", VA = "0x187700240")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x7700100", Offset = "0x76FF500", VA = "0x187700100")]
		public void ResetHandPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x77010C0", Offset = "0x77004C0", VA = "0x1877010C0")]
		public void UpdateHandAnimation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x7700F10", Offset = "0x7700310", VA = "0x187700F10")]
		public void UpdateFaceAndBodyShapes(bool FEPPBEEBJJH = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x77014C0", Offset = "0x77008C0", VA = "0x1877014C0")]
		public void UpdateNoseShape(PPJFLGDEIOL OACPMMCOLIP, bool FEPPBEEBJJH = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x7701490", Offset = "0x7700890", VA = "0x187701490")]
		public void UpdateLODOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x76FE6E0", Offset = "0x76FDAE0", VA = "0x1876FE6E0", Slot = "4")]
		protected virtual void HAHDCEIPNEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x76FFDB0", Offset = "0x76FF1B0", VA = "0x1876FFDB0", Slot = "5")]
		protected virtual void PCEBJENMEFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x76FD720", Offset = "0x76FCB20", VA = "0x1876FD720")]
		public void ApplyHatData(AdditionalHatData MNIPLHFNEGA, bool FGEEPHEGLCK = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x76FD560", Offset = "0x76FC960", VA = "0x1876FD560")]
		public void ApplyHatAdjustmentsToHatAnchorParams()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x76FDA80", Offset = "0x76FCE80", VA = "0x1876FDA80")]
		public void ApplyHatUVOverride(Vector2 BAGPJBDKCHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x76FD9A0", Offset = "0x76FCDA0", VA = "0x1876FD9A0")]
		public void ApplyHatPositionAdjustment(Vector3 GKDPJIOODGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x76FDA10", Offset = "0x76FCE10", VA = "0x1876FDA10")]
		public void ApplyHatRotationAdjustment(Vector3 FOHHMEMDPMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x76FDAF0", Offset = "0x76FCEF0", VA = "0x1876FDAF0")]
		public AAHMPIDJKPO BuildAvatarItemSelection(GameObject MMPOOFEEMHL, GEHKDDKOMID MBNOKBJPAMD, IDINMFOPJOG BNJHIIEDKCI)
		{
			return default(AAHMPIDJKPO);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x76FDB90", Offset = "0x76FCF90", VA = "0x1876FDB90")]
		public void BuildAvatar(bool FEPPBEEBJJH = false, bool FGEEPHEGLCK = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x7700950", Offset = "0x76FFD50", VA = "0x187700950")]
		public void UpdateColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x76FD6A0", Offset = "0x76FCAA0", VA = "0x1876FD6A0")]
		public void ApplyHatAnchor()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x77012E0", Offset = "0x77006E0", VA = "0x1877012E0")]
		public void UpdateHatAnchor(bool FGEEPHEGLCK = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x7701010", Offset = "0x7700410", VA = "0x187701010")]
		[AsyncStateMachine(typeof(JNOINNBFILN))]
		public void UpdateFaceFeatures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x7700020", Offset = "0x76FF420", VA = "0x187700020")]
		[AsyncStateMachine(typeof(DBEPMMGNCPJ))]
		private Task PGPHEKGBPJH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x76FFAE0", Offset = "0x76FEEE0", VA = "0x1876FFAE0")]
		private void LLBNMCEBEON(FaceFeatureType MODHLEEDKMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x76FE9F0", Offset = "0x76FDDF0", VA = "0x1876FE9F0")]
		private void HDAMCBFNIJO(FaceFeatureType MODHLEEDKMM, [Out] float MJNKLIDNBHG, [Out] float PFLCNMENAMM, [Out] float KJPCKOGHHCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x7700DD0", Offset = "0x77001D0", VA = "0x187700DD0")]
		public void UpdateEmote()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x7701170", Offset = "0x7700570", VA = "0x187701170")]
		public void UpdateHandPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x76FE1B0", Offset = "0x76FD5B0", VA = "0x1876FE1B0")]
		private void EBJHDIPDJHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0")]
		private void KCNMDNIKKNA(KKCFCNHCCMP PEDNHHPFCLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0")]
		private void LDEKJNBHKHD(KKCFCNHCCMP PEDNHHPFCLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x76FF780", Offset = "0x76FEB80", VA = "0x1876FF780")]
		private void KKGPGPNPKBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x7701550", Offset = "0x7700950", VA = "0x187701550")]
		public PlayerModernBodyEditorAvatarValidator()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x76FF5F0", Offset = "0x76FE9F0", VA = "0x1876FF5F0")]
		[CompilerGenerated]
		private AAHMPIDJKPO JEGJMACPGHC((GameObject, IDINMFOPJOG) MMEMFHEIKDO)
		{
			return default(AAHMPIDJKPO);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class SkinnedMeshBonesInspector : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		[HCOGNCHHAAD(GKKLJNPNNON.Self, false, false, false)]
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
		[Cpp2IlInjected.Address(RVA = "0x996AD0", Offset = "0x995ED0", VA = "0x180996AD0")]
		public SkinnedMeshBonesInspector()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct AAHMPIDJKPO
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class MOEMCFCJEIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public IEnumerable<OutfitType> otherOutfitTypes;

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public MOEMCFCJEIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x76F5780", Offset = "0x76F4B80", VA = "0x1876F5780")]
		internal bool HDFDEDBIDCG(OutfitType outfitType)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	private KKCFCNHCCMP OEIAJEPHEOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	private IDINMFOPJOG HMDNBFPMHHB;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public KKCFCNHCCMP CHGPKINKEEF
	{
		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0xC6E710", Offset = "0xC6DB10", VA = "0x180C6E710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public IDINMFOPJOG OBPBHLFABFI
	{
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0xC6E5E0", Offset = "0xC6D9E0", VA = "0x180C6E5E0")]
		get
		{
			return default(IDINMFOPJOG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public string HDIEEINEIEE
	{
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x76EE830", Offset = "0x76EDC30", VA = "0x1876EE830")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public bool GBBNDBHOJLI
	{
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x76EE260", Offset = "0x76ED660", VA = "0x1876EE260")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public bool ENPDPAIKMHF
	{
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x76EE7E0", Offset = "0x76EDBE0", VA = "0x1876EE7E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x1692140", Offset = "0x1691540", VA = "0x181692140")]
	public AAHMPIDJKPO(KKCFCNHCCMP PEDNHHPFCLE, IDINMFOPJOG OFBICLFFJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x76EE2B0", Offset = "0x76ED6B0", VA = "0x1876EE2B0")]
	public bool DICOHOCJDFO(OutfitType INGBDDLKLFP, IDINMFOPJOG AMPKNHKAIHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x76EE380", Offset = "0x76ED780", VA = "0x1876EE380")]
	public bool EJCFAOGCICI(OutfitType INGBDDLKLFP, IDINMFOPJOG AMPKNHKAIHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x76EE5F0", Offset = "0x76ED9F0", VA = "0x1876EE5F0")]
	public bool JKKIDBPAHPI(AAHMPIDJKPO IBNGJCCJPIC)
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
