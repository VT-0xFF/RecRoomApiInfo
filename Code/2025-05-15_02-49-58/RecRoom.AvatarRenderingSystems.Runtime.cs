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
	public class LogRegistrationIndex : BPLGCOBKJGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7A73130", Offset = "0x7A71730", VA = "0x187A73130", Slot = "4")]
		public override void AMBIAOGNIIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA149D0", Offset = "0xA12FD0", VA = "0x180A149D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F0820", Offset = "0x9EEE20", VA = "0x1809F0820", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override string AssetGUID
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x7A75460", Offset = "0x7A73A60", VA = "0x187A75460", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7A753F0", Offset = "0x7A739F0", VA = "0x187A753F0", Slot = "17")]
		public override bool RuntimeKeyIsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7A75420", Offset = "0x7A73A20", VA = "0x187A75420")]
		public RecNetCDNAssetReference(RecNetCDNKey OEHHKNIGGMI)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class RecNetCDNKey
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public enum LGHANJFEDKG : byte
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
			[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string UniqueItemIdentifier
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string CacheHash
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x9EACD0", Offset = "0x9E92D0", VA = "0x1809EACD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RecNetCDNKey Dependency
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x9EB550", Offset = "0x9E9B50", VA = "0x1809EB550")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x9EFA10", Offset = "0x9EE010", VA = "0x1809EFA10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool AttemptPrecacheLookup
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xA18200", Offset = "0xA16800", VA = "0x180A18200")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA18020", Offset = "0xA16620", VA = "0x180A18020")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public LGHANJFEDKG PathHint
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xDBB480", Offset = "0xDB9A80", VA = "0x180DBB480")]
			[CompilerGenerated]
			get
			{
				return default(LGHANJFEDKG);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x1327520", Offset = "0x1325B20", VA = "0x181327520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string ItemPath
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x7A75570", Offset = "0x7A73B70", VA = "0x187A75570")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7A754A0", Offset = "0x7A73AA0", VA = "0x187A754A0")]
		public static RecNetCDNKey BFIJMBOABGP(string IAJMCIIEMIA, LGHANJFEDKG NICNCJIIMND)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7A75520", Offset = "0x7A73B20", VA = "0x187A75520")]
		public void BNIMMBNJKLL(string PNJLMAHAELH, string CNOOJBJPLMK, bool LDPOOPAGCOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public RecNetCDNKey()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[HJNCDIOGCJG]
public class NFJIGMCMHCJ : GLFHFBMHEFL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	protected readonly List<Mesh> NHMDKOPANCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	protected readonly List<byte[]> FMLJEKAMMHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	protected readonly List<Matrix4x4> DCHLFCFIIGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	protected readonly List<bool> EADDHEABKAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	protected readonly List<long> LHPKEPKDOPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	protected readonly List<bool> NAMPNMMCPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	protected readonly List<int> IDJNPPGJEML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	protected Allocator BFLNDLDDDNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected EONPPOBGAOL ADGBJEIHIHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected byte HONNPKHEGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected IList<int> NNEEJGJBMHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected IList<int> ILDADOPHNKI;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7A73460", Offset = "0x7A71A60", VA = "0x187A73460", Slot = "4")]
	public void GKAHHFADIKG(Mesh PEPFHNJFNIL, Matrix4x4 GBOHAMAACHL, byte[] AHOGHGIIKDO, bool COHLFCDAJAJ = false, DJMKKMKOHOE.KHMINOCKMDE FHNEEDJLIKD = (DJMKKMKOHOE.KHMINOCKMDE)0L, int ACGKBLDNMLK = -1, bool DLDPOELFKGB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7A731C0", Offset = "0x7A717C0", VA = "0x187A731C0", Slot = "5")]
	public void EKELMPDKPON(Allocator NDFENJBGNOB, EONPPOBGAOL BEBBIOKLEJJ, byte GGNNMGDCEED, [Optional] IList<int> IGEECJJEHIN, [Optional] IList<int> LKLIOGJGKMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7A73200", Offset = "0x7A71800", VA = "0x187A73200")]
	private static void FBDDFDPPDDM(Mesh PEPFHNJFNIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7A736E0", Offset = "0x7A71CE0", VA = "0x187A736E0")]
	public NFJIGMCMHCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[HJNCDIOGCJG]
public struct OGAIDKCNFGJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	[ReadOnly]
	public ELDEMJODJGF NFBNCDAFDCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[ReadOnly]
	public int OGHFEPGBEDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public BCABEAKKLHP GAJLKEHBMPI;

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7A73930", Offset = "0x7A71F30", VA = "0x187A73930", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[HJNCDIOGCJG]
[NativeContainer]
public struct BCABEAKKLHP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct LGJLKKDAJIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Vector3 ELPKAJMHPJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public Vector3 HPAMHMBDLLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public Vector4 OFDPNDMFOFN;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct HCNLKPBDIIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public float CCIPLCODKJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public float KDGPKGFNPOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public float NJFJLKOKIED;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public float NACONHMKKCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public byte CGOKFMAFHAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public byte ENENLNMBDKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public byte FBKHGNOHODJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public byte HCAPPGMAIGA;
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct DKHIEHFFBPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public half CCIPLCODKJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public half KDGPKGFNPOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public half NJFJLKOKIED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public half NACONHMKKCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public byte CGOKFMAFHAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public byte ENENLNMBDKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public byte FBKHGNOHODJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public byte HCAPPGMAIGA;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct CCJLBDMANDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public half4 NGGKCKILBNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public half2 EDENJOBDNIJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct OOFLJIGDMIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public half4 NGGKCKILBNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public half2 EDENJOBDNIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public half2 CFOOPOEBKLL;
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct OAIAFDIGFCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public half4 NGGKCKILBNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public half2 EDENJOBDNIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public half2 CFOOPOEBKLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public half2 NIIIGPHODFD;
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct MHDLPJIPCHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public half4 NGGKCKILBNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public half2 EDENJOBDNIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public half2 CFOOPOEBKLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public half2 NIIIGPHODFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public half2 GENNKFIGGKC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct GHGNAOMOJKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public float CCIPLCODKJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public float KDGPKGFNPOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public float NJFJLKOKIED;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public float NACONHMKKCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int CGOKFMAFHAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int ENENLNMBDKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int FBKHGNOHODJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int HCAPPGMAIGA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct HDCHEEAOHNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Color NGGKCKILBNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Vector2 EDENJOBDNIJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct ANOIFBNNMEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Color NGGKCKILBNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Vector2 EDENJOBDNIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Vector2 CFOOPOEBKLL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct AMOJFGGOAMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Color NGGKCKILBNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Vector2 EDENJOBDNIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Vector2 CFOOPOEBKLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Vector2 NIIIGPHODFD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct DDJMGBDENHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Color NGGKCKILBNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Vector2 EDENJOBDNIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Vector2 CFOOPOEBKLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Vector2 NIIIGPHODFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Vector2 GENNKFIGGKC;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private bool CJOANJNKGLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<LGJLKKDAJIN> HIMMCDPGMDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<CCJLBDMANDH> OKMHNKPDMAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<OOFLJIGDMIG> IDGOHJPEDLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<OAIAFDIGFCJ> ENKNBMBOADK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<MHDLPJIPCHH> PKENADLCBKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<DKHIEHFFBPB> JEBJAFMEBMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<HCNLKPBDIIK> JPBOPNIGPAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NativeArray<HDCHEEAOHNH> IADNEAMPJKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NativeArray<ANOIFBNNMEE> DENINKGMMGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public NativeArray<AMOJFGGOAMC> LKKBKFDACAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public NativeArray<DDJMGBDENHK> DJMPCMPLBIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public NativeArray<GHGNAOMOJKI> FBKFLFEKFLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public NativeArray<int> HECOEAMAHLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public NativeArray<int> KAODBKFLMFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private NativeArray<int> LPPAPOBKIEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NativeArray<int> CNHHIFNMEHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<int> OLKBDAMMBPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public NativeArray<int> MNAAOOIJBGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public NativeArray<int> FLLPPOBDFDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public NativeArray<BoneWeight> ELLAKLBKHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeArray<int> PMLCGCAHNGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private bool NIIMKNLENEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x159")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private bool INLAHEKHDGL;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int HINGJKKACPM
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7A60D50", Offset = "0x7A5F350", VA = "0x187A60D50")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7A623A0", Offset = "0x7A609A0", VA = "0x187A623A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int KMEAPHNMOHI
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7A60D40", Offset = "0x7A5F340", VA = "0x187A60D40")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7A62FF0", Offset = "0x7A615F0", VA = "0x187A62FF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int DCEBGGCGCON
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7A63000", Offset = "0x7A61600", VA = "0x187A63000")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7A63010", Offset = "0x7A61610", VA = "0x187A63010")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int OFAGCOAPCCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7A63020", Offset = "0x7A61620", VA = "0x187A63020")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7A63090", Offset = "0x7A61690", VA = "0x187A63090")]
	public BCABEAKKLHP(int DLOLGMFGMCF, int KHMLDEKGOGN, int OKKKFJPPJBM, int NCOLCNECKHG, Allocator NDFENJBGNOB, int LJHHEIGDCPK, PHFAILKPHNL KCDJDDGAADL, bool NIIMKNLENEM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7A62310", Offset = "0x7A60910", VA = "0x187A62310")]
	public void HDLFLBKAKKF(int OHHMJGCBCKD, Vector3 IINHKHEMEHJ, Vector3 KLJKHLHNLGP, Vector4 LEMBKBGMCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7A626E0", Offset = "0x7A60CE0", VA = "0x187A626E0")]
	public void JDOKECODNDF(int OHHMJGCBCKD, BoneWeight NHAPOAOKIGM, NativeSlice<byte> AHOGHGIIKDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7A623B0", Offset = "0x7A609B0", VA = "0x187A623B0")]
	public Color HPNCCIMOPBK(int OHHMJGCBCKD)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7A62BF0", Offset = "0x7A611F0", VA = "0x187A62BF0")]
	public void NEMFFJAMDMK(int OHHMJGCBCKD, Color JKIBOICMIDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7A60D60", Offset = "0x7A5F360", VA = "0x187A60D60")]
	public void CLCMMOGNEHO(byte KCDFLKCBIKJ, int OHHMJGCBCKD, Vector2 MGPLIBEEABL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7A62B10", Offset = "0x7A61110", VA = "0x187A62B10")]
	public void KEFDAKBCNKF(int OHHMJGCBCKD, int HIJGCANIBGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7A61370", Offset = "0x7A5F970", VA = "0x187A61370")]
	public bool ENKKJEKEEDM(int KCDFLKCBIKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7A62B20", Offset = "0x7A61120", VA = "0x187A62B20")]
	public void MAAFKJANCOD(int GNDDIJKFHIM, int LLPAIMMACAP, int DDGBDMFPMAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7A61110", Offset = "0x7A5F710", VA = "0x187A61110", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7A613D0", Offset = "0x7A5F9D0", VA = "0x187A613D0")]
	public Mesh GHGLJPLOCLP([Optional] string IGLCIHNNBAL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
[HJNCDIOGCJG]
[NativeContainer]
public struct ELDEMJODJGF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public Mesh.MeshDataArray DGPAGJMEJAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public NativeArray<int> KPKNNHHJINB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public NativeArray<int> FEEGHAKIELF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public NativeArray<BoneWeight> ELLAKLBKHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private NativeArray<Matrix4x4> PCLMDBCJANG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private NativeArray<long> GNNBDHEBKFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private NativeArray<byte> CLPOAEFNCPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private NativeArray<int> FKGMGNGNNFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private NativeArray<int> GHJDMLGKFPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public NativeArray<sbyte> KKENHNPIKCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public NativeArray<byte> BCOEJMPEBJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public NativeArray<bool> DLDPOELFKGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NativeArray<int> ACGKBLDNMLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private bool NIIMKNLENEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeArray<int> AJEMBDGPNIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private bool INLAHEKHDGL;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int KJJANABCHPF
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7A64430", Offset = "0x7A62A30", VA = "0x187A64430")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int PEMPMDIKECC
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7A64530", Offset = "0x7A62B30", VA = "0x187A64530")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int LALFONMEHBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7A64540", Offset = "0x7A62B40", VA = "0x187A64540")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int IDMIEAGHKAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7A64520", Offset = "0x7A62B20", VA = "0x187A64520")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7A64410", Offset = "0x7A62A10", VA = "0x187A64410")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int HINGJKKACPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7A64260", Offset = "0x7A62860", VA = "0x187A64260")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7A64440", Offset = "0x7A62A40", VA = "0x187A64440")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int IFCJDIOLHID
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7A64270", Offset = "0x7A62870", VA = "0x187A64270")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7A64620", Offset = "0x7A62C20", VA = "0x187A64620")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public EONPPOBGAOL DNJJAFNOEIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7A64000", Offset = "0x7A62600", VA = "0x187A64000")]
		get
		{
			return default(EONPPOBGAOL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7A64400", Offset = "0x7A62A00", VA = "0x187A64400")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public byte KDIIKCBKGNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7A64420", Offset = "0x7A62A20", VA = "0x187A64420")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7A64610", Offset = "0x7A62C10", VA = "0x187A64610")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public GBGGPFBECJI OEMFNNCKNFG
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7A64010", Offset = "0x7A62610", VA = "0x187A64010")]
		get
		{
			return default(GBGGPFBECJI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7A64630", Offset = "0x7A62C30", VA = "0x187A64630")]
	public ELDEMJODJGF(IList<Mesh> KBDLEKHEHMN, IList<Matrix4x4> DJFOKBGCCNJ, IList<bool> DLDPOELFKGB, byte GGNNMGDCEED, IList<byte[]> FONLLDDLMJH, IList<long> CKKFOPFCAOD, IList<bool> FNOHPKAEEOI, IList<int> ACGKBLDNMLK, IList<int> IGEECJJEHIN, IList<int> GNFGAAOIHNM, Allocator NDFENJBGNOB, EONPPOBGAOL BEBBIOKLEJJ, bool NIIMKNLENEM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7A64450", Offset = "0x7A62A50", VA = "0x187A64450")]
	public BCABEAKKLHP IPMEGOIAMCA(Allocator NDFENJBGNOB, PHFAILKPHNL KCDJDDGAADL)
	{
		return default(BCABEAKKLHP);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7A64280", Offset = "0x7A62880", VA = "0x187A64280", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[HJNCDIOGCJG]
public class IGFHGDPFCAI : NFJIGMCMHCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public bool KNHOPNMIEML;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly ProfilerMarker CNMJCHCGGAH;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7A65A90", Offset = "0x7A64090", VA = "0x187A65A90")]
	public ELDEMJODJGF GDGODOCMIHG()
	{
		return default(ELDEMJODJGF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7A65D90", Offset = "0x7A64390", VA = "0x187A65D90")]
	public IGFHGDPFCAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct GBGGPFBECJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public Mesh.MeshData MEDEJIAPIAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public NativeSlice<BoneWeight> ELLAKLBKHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public NativeSlice<byte> LFFGEMJALDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public int LBBEGJCDLKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public Matrix4x4 HBJLJGGBCBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public long CHNHHCCDPAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public NativeSlice<byte> AHOGHGIIKDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public bool PJHKDJOGIAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public int MIFGHABDOFH;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class KPPCNHOKIIC : EEFKKODIKGJ
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class FLJNPNCIPBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public OMFDGHDDKHE avatarBuildParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public KPPCNHOKIIC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public ALBMIKCECHI buildMeshPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public Action<KeyValuePair<string, GKHPBLLBAIL<Texture2D>>> <>9__19;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public FLJNPNCIPBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7A65A40", Offset = "0x7A64040", VA = "0x187A65A40")]
		internal bool PDOFCBMOCJO(ALBBMKANDAF item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7A65930", Offset = "0x7A63F30", VA = "0x187A65930")]
		internal void LCOONBNLJDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7A65820", Offset = "0x7A63E20", VA = "0x187A65820")]
		internal void FJFCPOPIBEK(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7A65930", Offset = "0x7A63F30", VA = "0x187A65930")]
		internal void IJNHJNELBPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7A65820", Offset = "0x7A63E20", VA = "0x187A65820")]
		internal void MAOBAFHGNAE(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x7A65840", Offset = "0x7A63E40", VA = "0x187A65840")]
		internal void HLNPKEINFPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7A65950", Offset = "0x7A63F50", VA = "0x187A65950")]
		internal void LOGIFJBNJHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7A65870", Offset = "0x7A63E70", VA = "0x187A65870")]
		internal void IDJPCNELGEJ(Dictionary<string, GKHPBLLBAIL<Texture2D>> resourceHandleDictionary)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7A65980", Offset = "0x7A63F80", VA = "0x187A65980")]
		internal void MLBGGNMOOHM(KeyValuePair<string, GKHPBLLBAIL<Texture2D>> kvp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
		internal HPIGCMLNLFB GONJKEPBFOL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class EJILKMLNIGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public int lowestPossibleLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public FLJNPNCIPBJ CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public EJILKMLNIGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7A63F40", Offset = "0x7A62540", VA = "0x187A63F40")]
		internal NNEHDADGDHM IMJGJOAADLE(int lod)
		{
			return default(NNEHDADGDHM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class BLDJGCJOHIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public KGAPFDAFEHM<Dictionary<string, GKHPBLLBAIL<Texture2D>>> ugcTextureDictionaryPromise;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public BLDJGCJOHIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		internal KGAPFDAFEHM<Dictionary<string, GKHPBLLBAIL<Texture2D>>> OBBDMOOKKCO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class IOAINOIGBLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public List<ALBMIKCECHI> innerPromises;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public IOAINOIGBLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x7A66070", Offset = "0x7A64670", VA = "0x187A66070")]
		internal void JAJFKKFGGJL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class INDCFPMDHON : IEnumerator<NFNODNEANBN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private NFNODNEANBN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public bool shouldWait;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public KPPCNHOKIIC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public List<OEHMJDNAMGC> parts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public List<ALBMIKCECHI> innerPromises;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public bool isFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public Func<int, NNEHDADGDHM> getLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public DCAOEHPAGLN materialPropertyBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public Material materialInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private int <lodIndex>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private NFNODNEANBN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x9EC8D0", Offset = "0x9EAED0", VA = "0x1809EC8D0")]
		[DebuggerHidden]
		public INDCFPMDHON(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7A65DA0", Offset = "0x7A643A0", VA = "0x187A65DA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7A66020", Offset = "0x7A64620", VA = "0x187A66020", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class FBDDNPBECPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public ILCPGOOBIBP cancelable;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public FBDDNPBECPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0xA97380", Offset = "0xA95980", VA = "0x180A97380")]
		internal void DPNNKIBFAFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0xCDC010", Offset = "0xCDA610", VA = "0x180CDC010")]
		internal void LBEKMBHFLHI(string err)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class IBLOMOAKAIM
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
		public KPPCNHOKIIC <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public IBLOMOAKAIM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class DOKMDMKNHMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public BCABEAKKLHP defaultMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public ELDEMJODJGF defaultAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public IBLOMOAKAIM CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public DOKMDMKNHMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x7A63D00", Offset = "0x7A62300", VA = "0x187A63D00")]
		internal void FMBNECOIEIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x12613C0", Offset = "0x125F9C0", VA = "0x1812613C0")]
		internal void MOMJBIELBOH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class DKAHONPHIPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public EBEEGCNLDFE legacyMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public PLEFCEKBJLA legacyAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public IBLOMOAKAIM CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public DKAHONPHIPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7A63AC0", Offset = "0x7A620C0", VA = "0x187A63AC0")]
		internal void KMOLIEMEOLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x1263390", Offset = "0x1261990", VA = "0x181263390")]
		internal void MHMDGBGADNC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class KEEDDFBPBHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public string overrideItemIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public LEMFDNDBDJC overrideBodyPart;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public KEEDDFBPBHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7A661A0", Offset = "0x7A647A0", VA = "0x187A661A0")]
		internal bool ECGKHJOGDED(KeyValuePair<string, ALBBMKANDAF> entry)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly GCADBNOOJOM BLDHJENEMBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly GCADBNOOJOM JEIANKNJFAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Dictionary<OAIBHFEEBFF, float> KODJPBIHMAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private Dictionary<OGHEPKGNCBA, float> OLJODGMLDHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Dictionary<OJGFLCIKIFC, float> HFLMHILKNLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private IReadOnlyDictionary<string, OMFJAKPBEAO> LCLCMMHOICJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Dictionary<string, OMFJAKPBEAO> CIMKJEOMFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Dictionary<string, OMFJAKPBEAO> OBLKGGCGIGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private Dictionary<string, OMFJAKPBEAO> ANMJNLPBONN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private JICFHOJONOI LHFMGEDFFNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private JICFHOJONOI DLFLFAGMGLI;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static float ANPELJPBGCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private bool? HPIAJGAKLLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x62")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private bool? COIBOHNDLJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private bool? DAAIDNFFCAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x66")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private bool? JMEBNIEJNEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private AvatarConfiguration NGFNACOPBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private Transform GIFINLCMGOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private AvatarSkinAssetItem NPELAGBPGGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private AssetReference HNEFLPHAHKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private GameObject EOCBENHFALB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private GameObject CGNNCMMHBED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private SkinnedMeshRenderer IEOFEJIOBMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private AvatarSkinnedMeshBoneOrderRemapsData DNBBBFFHFPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private Transform[] AMODIIKJDAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private Matrix4x4[] CAHNIDGLLDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private Material AOCGDNHMNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private Material OPNGMCDFPIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private Material JFDHANNJPGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private Shader HMCDLDEBPEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private Shader NCLGALCLLKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Animator MILKLFGDHHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private Renderer[] DEMPEPENGKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private DJMKKMKOHOE.KHMINOCKMDE JDPIIDIHBNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private AvatarBodyPartShapesManager LFNKPOOJJAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private IReadOnlyDictionary<string, Transform> CAFCAMDFIPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private AvatarFaceShapeData.EJGOAPJJEAB AKGHJJJADAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private AvatarBodyShapeData.BDLDEOFKLHF KIGJMILJMBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private ABOJDNCODIG PJCFAMLABIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private bool FCCEAFFOKCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x115")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private bool OGDCBDOOHFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private Color LJIEEGNPKLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private Color IGJNFCANDHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private Color GAKFDEIOCOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private Color? FFECHGGDCAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15C")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private Color? ENBAALFMJCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private Color? MELPBHPHJDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private Color? ABGJKILOAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private Texture2D POGGBEMKEGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private Texture2D BGLNIHAIOCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	[CanBeNull]
	private ALBBMKANDAF BGCKBKNJIGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private Texture ELACHNCDAOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private Color FKJBDMILMFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public Dictionary<Renderer, DCAOEHPAGLN> PMFMLMLCLDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private Dictionary<Renderer, DCAOEHPAGLN> LBNANJIFMIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private Dictionary<string, List<GLNGPPKPMIG>> NJIBIBFNAMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private Dictionary<string, List<GLNGPPKPMIG>> LPJHPBAJECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly List<KBJDIMPKBHI> LLEJJAJBIPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly List<KBJDIMPKBHI> IPDFKDFLCMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly List<KBJDIMPKBHI> KFPEKBEJHMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly List<KBJDIMPKBHI> IEJDFIPOIEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private Dictionary<GLNGPPKPMIG, Material> KCDGFEJIBGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private Dictionary<GLNGPPKPMIG, Material> CNHELDMEALI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private SkinnedMeshRenderer[] FCLECLFEEGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private SkinnedMeshRenderer[] CMFIOCJEKLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private SkinnedMeshRenderer[] MKHJKOBILHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private SkinnedMeshRenderer[] IAIGPODOAKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Dictionary<string, GKHPBLLBAIL<Texture2D>> FPCJKCJGNIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly Dictionary<string, GKHPBLLBAIL<Texture2D>> FEIFJPBNIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private AdditionalHatData ABAPPAFKHBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private AdditionalHatData NMIEHHICIDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private HairData DHMJLBECBHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private HairData FFCKMIHCFII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private HMAKLDEGKBC ODGMOFPMNAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private bool? MAPIHPFOIEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x274")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private PositionAndRotation GNFEDHCILNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private Transform KBBCHBNBNAE;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private Material PFJKIDMMJPB;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private Material PBJKOGACHKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private Dictionary<string, ALBBMKANDAF> LDIFGLHEGDO;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static readonly int LEKLCKMLHKP;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static readonly int LFCAOGDGBCF;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static readonly int IFPHMMKBMAI;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly int LHFDEPFMMLE;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly int MDFOIADEHEK;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly int GDALFNBDFLA;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly int NEBJJGMDHAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private bool LMPKJMFNCMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private List<Action> PJAADJGAPKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private NAFFPEBCHPI PALKBJEOGPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private SkinnedMeshRenderer[] PJNKJHKEDEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private int PEPONHADFPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D4")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private bool LJHKAHLGPJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private int FCNENKGLAIH;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public GCADBNOOJOM GIJDKDPBBDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public GCADBNOOJOM FKICFHPEPLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private JAHOCBPGMLL AJHJEIPEGEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7A6B6A0", Offset = "0x7A69CA0", VA = "0x187A6B6A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool KEFCAAODOCD
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7A710B0", Offset = "0x7A6F6B0", VA = "0x187A710B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private bool IKJDKMFPOPD
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7A6B9F0", Offset = "0x7A69FF0", VA = "0x187A6B9F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private bool HJAHMFDBGGE
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7A6AD90", Offset = "0x7A69390", VA = "0x187A6AD90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private bool CMAOHLEHMFA
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7A680E0", Offset = "0x7A666E0", VA = "0x187A680E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public AvatarConfiguration MMMOHDOGNHL
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x9EECF0", Offset = "0x9ED2F0", VA = "0x1809EECF0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool NBOCNNCLLHG
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x13837D0", Offset = "0x1381DD0", VA = "0x1813837D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x25B4EF0", Offset = "0x25B34F0", VA = "0x1825B4EF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private Material AFMMCPLDBKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7A681C0", Offset = "0x7A667C0", VA = "0x187A681C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private Material NBKJBKDHABD
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7A6AB00", Offset = "0x7A69100", VA = "0x187A6AB00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private bool KJIMCOKKLJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA05830", Offset = "0xA03E30", VA = "0x180A05830")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public BLMBMEMIHNO CGILOPKPFBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x11EBC10", Offset = "0x11EA210", VA = "0x1811EBC10", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return default(BLMBMEMIHNO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x11EAAA0", Offset = "0x11E90A0", VA = "0x1811EAAA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public Material AIDPAHHCHLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xCD6580", Offset = "0xCD4B80", VA = "0x180CD6580", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public SkinnedMeshRenderer[] BCDFCKMLPFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x1C24680", Offset = "0x1C22C80", VA = "0x181C24680", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public Renderer[] LAPDFLIBNND
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xAA1470", Offset = "0xA9FA70", VA = "0x180AA1470", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool FBBAILFPMON
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7A6B070", Offset = "0x7A69670", VA = "0x187A6B070", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public DJMKKMKOHOE.KHMINOCKMDE BNDOMBIBDNM
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xAA2AA0", Offset = "0xAA10A0", VA = "0x180AA2AA0", Slot = "20")]
		get
		{
			return default(DJMKKMKOHOE.KHMINOCKMDE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int IOPMMHKPGGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x11EB2F0", Offset = "0x11E98F0", VA = "0x1811EB2F0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7A6BF30", Offset = "0x7A6A530", VA = "0x187A6BF30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private bool JIFPFCLIKKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7A70250", Offset = "0x7A6E850", VA = "0x187A70250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private static bool CNGCPGLIGCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7A6B710", Offset = "0x7A69D10", VA = "0x187A6B710", Slot = "15")]
	public ALBMIKCECHI FBLCEBCCAMP(OMFDGHDDKHE EAEKJMJLOAC, bool EEAEBGKMHGP, int[] KIOKNKHEIMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7A6F9F0", Offset = "0x7A6DFF0", VA = "0x187A6F9F0", Slot = "14")]
	public ALBMIKCECHI KBANOGBGLKK(OMFDGHDDKHE EAEKJMJLOAC, bool EEAEBGKMHGP, int[] KIOKNKHEIMB, Func<Dictionary<string, ALBBMKANDAF>, (ALBMIKCECHI, KGAPFDAFEHM<Dictionary<string, GKHPBLLBAIL<Texture2D>>>)> CLMFFEADJPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7A66480", Offset = "0x7A64A80", VA = "0x187A66480")]
	public ALBMIKCECHI ADPKDBKPFMP(OMFDGHDDKHE EAEKJMJLOAC, bool EEAEBGKMHGP, int[] KIOKNKHEIMB, bool AOHPOOECADH, JICFHOJONOI AJGOHICNHCN, [Optional] Func<Dictionary<string, ALBBMKANDAF>, (ALBMIKCECHI, KGAPFDAFEHM<Dictionary<string, GKHPBLLBAIL<Texture2D>>>)> CLMFFEADJPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7A70000", Offset = "0x7A6E600", VA = "0x187A70000")]
	private bool LACMOOMOOMG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7A6F160", Offset = "0x7A6D760", VA = "0x187A6F160")]
	private ALBMIKCECHI JJNLMMKCDGE(bool EEAEBGKMHGP, List<OEHMJDNAMGC> HIIHIMPLCJH, int[] KIOKNKHEIMB, Func<int, NNEHDADGDHM> EPEKJNBCPPI, bool AOHPOOECADH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7A6DB00", Offset = "0x7A6C100", VA = "0x187A6DB00")]
	[IteratorStateMachine(typeof(INDCFPMDHON))]
	private IEnumerator<NFNODNEANBN> IHJJGGANBOI(bool EEAEBGKMHGP, List<OEHMJDNAMGC> HIIHIMPLCJH, int[] KIOKNKHEIMB, Func<int, NNEHDADGDHM> EPEKJNBCPPI, DCAOEHPAGLN BFBOFDJKBCP, Material KCFANBEOAGC, List<ALBMIKCECHI> NJGJCFNACDF, bool LKECFFEIFNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7A6C270", Offset = "0x7A6A870", VA = "0x187A6C270")]
	private void HEJHKKKCOBB(List<OEHMJDNAMGC> HIIHIMPLCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7A71190", Offset = "0x7A6F790", VA = "0x187A71190")]
	private ALBMIKCECHI NAPCODBGHCH(List<OEHMJDNAMGC> HIIHIMPLCJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7A69390", Offset = "0x7A67990", VA = "0x187A69390")]
	private OLILOOIADED CCFBPLFLACH(List<OEHMJDNAMGC> HIIHIMPLCJH, int GKGMDAMJCNF, bool EEAEBGKMHGP, NNEHDADGDHM JGGBDGJFMCJ, bool CJNICDHMFGF, DCAOEHPAGLN BFBOFDJKBCP, Material KCFANBEOAGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7A718E0", Offset = "0x7A6FEE0", VA = "0x187A718E0", Slot = "27")]
	public void OCOHJLBJOOC(OAIBHFEEBFF OHKLPMGKCNP, float OHLIHBDBKCE, bool NGGBHLHDOAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7A6F020", Offset = "0x7A6D620", VA = "0x187A6F020", Slot = "29")]
	public void IPEJBKIPPIA(OGHEPKGNCBA LHCBLABBENF, float OHLIHBDBKCE, bool CNDBMNGCPEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7A6F880", Offset = "0x7A6DE80", VA = "0x187A6F880", Slot = "30")]
	public void JMAGOFIIPAD(OJGFLCIKIFC GKKKGOHEELC, float OHLIHBDBKCE, bool ONLNMKMBDBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7A6F100", Offset = "0x7A6D700", VA = "0x187A6F100", Slot = "28")]
	public void JBIOIOBPKBN(bool MMPAHNIJNOD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7A6BF50", Offset = "0x7A6A550", VA = "0x187A6BF50", Slot = "31")]
	public void GNAAJEMACEG(bool MMPAHNIJNOD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7A68CF0", Offset = "0x7A672F0", VA = "0x187A68CF0", Slot = "32")]
	public void BDDPIPKHGLL(bool MMPAHNIJNOD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7A6A490", Offset = "0x7A68A90", VA = "0x187A6A490")]
	private void CEGAJGCGDLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7A713E0", Offset = "0x7A6F9E0", VA = "0x187A713E0")]
	private void NDGPIDGGJIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7A70BF0", Offset = "0x7A6F1F0", VA = "0x187A70BF0")]
	private void MFDANGMPDKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7A6CC30", Offset = "0x7A6B230", VA = "0x187A6CC30", Slot = "25")]
	public void HIHMNPDOBII(AvatarFaceShape NOLJPELCPGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7A6B1E0", Offset = "0x7A697E0", VA = "0x187A6B1E0", Slot = "26")]
	public void DPPAKFIKPJJ(AvatarBodyShape JNNFLNPDLLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x231D9B0", Offset = "0x231BFB0", VA = "0x18231D9B0", Slot = "33")]
	public void BDGEOCHDEIN(ABOJDNCODIG AEHFOHDJDBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7A6CF40", Offset = "0x7A6B540", VA = "0x187A6CF40", Slot = "35")]
	public void ICPFDPMIICI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7A70100", Offset = "0x7A6E700", VA = "0x187A70100", Slot = "38")]
	public void LFKPNLFGGDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7A71670", Offset = "0x7A6FC70", VA = "0x187A71670", Slot = "34")]
	public void NNHKGAFNBNJ(bool APHODKKNMPK, bool BKPHMFMOBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7A724E0", Offset = "0x7A70AE0", VA = "0x187A724E0")]
	private void PJPABNLDLPG(SkinnedMeshRenderer CENGCBFBEJP, int GKGMDAMJCNF, Mesh PEPFHNJFNIL, List<Material> OKFFFEHEGBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7A66250", Offset = "0x7A64850", VA = "0x187A66250")]
	private static Material ACNIMILDKCE(Dictionary<GLNGPPKPMIG, Material> KEMDFPKPCOM, Material OJHFGKAFIEJ, FOHOLFICGPJ GMLOOFHADHO, BEEBHKAMNNL PGOOBBKNDOF, LEMFDNDBDJC BDNPFHIBMNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7A6D9F0", Offset = "0x7A6BFF0", VA = "0x187A6D9F0")]
	private static FOHOLFICGPJ IGLIHIPGIPB(OEHMJDNAMGC DADFPFCEPAK, int FPNNGFNMBMA)
	{
		return default(FOHOLFICGPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7A719C0", Offset = "0x7A6FFC0", VA = "0x187A719C0")]
	private void ODEGJEIOILA(int KMLNOHKPNFG, Material CANJBFKPEMF, OEHMJDNAMGC DADFPFCEPAK, [Out] Texture2D MGPEMBAGNBN, [Out] Vector4 ANNENBEHPMI, [Out] Texture2D KMMLDOAJCOM, [Out] Texture2D BNKFBNNLFHF, [Out] Texture2D IEHNFAOCACL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7A68360", Offset = "0x7A66960", VA = "0x187A68360")]
	private void ALKFAAJACAO(int KMLNOHKPNFG, Material CANJBFKPEMF, OEHMJDNAMGC DADFPFCEPAK, [Out] Color BCJBJCJEEOB, [Out] Color DENCMJLNDEA, [Out] Color GNOGEJFGEHI, [Out] Color EMEEOLPKGGL, [Out] Color MEAICLBLNAP, [Out] Color MOIBEGCKKBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7A71F30", Offset = "0x7A70530", VA = "0x187A71F30")]
	private bool OHLIFBPBBLK(Material CANJBFKPEMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7A70C70", Offset = "0x7A6F270", VA = "0x187A70C70")]
	private static Material MFGBLABBHNG(int KMLNOHKPNFG, NCKDDFHNPMI DADFPFCEPAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7A6ACB0", Offset = "0x7A692B0", VA = "0x187A6ACB0")]
	private static BEEBHKAMNNL DKELNJIGIDP(OEHMJDNAMGC DADFPFCEPAK, int FPNNGFNMBMA)
	{
		return default(BEEBHKAMNNL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7A6BFB0", Offset = "0x7A6A5B0", VA = "0x187A6BFB0")]
	private static void GOJDBMHGHLN(Dictionary<string, List<GLNGPPKPMIG>> DHPEMHCCIBM, OEHMJDNAMGC DNPMBJLIGEP, Material OJHFGKAFIEJ, FOHOLFICGPJ FKAIEBDGNCN, BEEBHKAMNNL IHIJDFFNDNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7A70430", Offset = "0x7A6EA30", VA = "0x187A70430")]
	private static SkinnedMeshRenderer MBIOPHJMPOL(Transform DJEJFBBPOLK, Transform GIKHOJKDBHI, SkinnedMeshRenderer[] GMCMJGGCAFJ, int GKGMDAMJCNF, NNEHDADGDHM JGGBDGJFMCJ, bool EEAEBGKMHGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7A72780", Offset = "0x7A70D80", VA = "0x187A72780")]
	public KPPCNHOKIIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7A68820", Offset = "0x7A66E20", VA = "0x187A68820")]
	public void ANJKPBDKBKO([In] AIIHNJMODJF FLFKJIOMIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7A6BB90", Offset = "0x7A6A190", VA = "0x187A6BB90")]
	public void LMDIFILKIOE([In] HMAAKGCFJIK EFGPLJKHBGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7A6BF30", Offset = "0x7A6A530", VA = "0x187A6BF30", Slot = "5")]
	public void GMCJHMAKKJD(int GKGMDAMJCNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7A6B7D0", Offset = "0x7A69DD0", VA = "0x187A6B7D0", Slot = "10")]
	public void FEDEOKJHDPN(GFLLLLCANOK IHIJDFFNDNI, Texture2D BFGBBIJNNHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xA05830", Offset = "0xA03E30", VA = "0x180A05830")]
	public static bool MJMPPGBOJIO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7A70A80", Offset = "0x7A6F080", VA = "0x187A70A80", Slot = "11")]
	public bool MDFLBHLKJAF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7A6B2A0", Offset = "0x7A698A0", VA = "0x187A6B2A0", Slot = "9")]
	public void EHAKGAGPGAI(MCGIHJPPCCH FKAIEBDGNCN, Color? NGGKCKILBNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7A6F970", Offset = "0x7A6DF70", VA = "0x187A6F970")]
	private void JOJLFPFEINN(Action JDMMPPCKHLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7A722C0", Offset = "0x7A708C0", VA = "0x187A722C0", Slot = "6")]
	public void PBBPFKMBGJB(ALBBMKANDAF HNMCGDBFDGH, Texture MOBCKEBGPFC, Color CHOGCLCILKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x25B4EF0", Offset = "0x25B34F0", VA = "0x1825B4EF0", Slot = "7")]
	public void DMJLKLMFLHD(bool LKECFFEIFNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x220CFF0", Offset = "0x220B5F0", VA = "0x18220CFF0", Slot = "8")]
	public void AIBLNAAHMKF(NAFFPEBCHPI PMLCGCAHNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7A6AE70", Offset = "0x7A69470", VA = "0x187A6AE70", Slot = "16")]
	public void DMLDIIKDBJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7A6B740", Offset = "0x7A69D40", VA = "0x187A6B740", Slot = "36")]
	public void FDMFMABKNNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7A6DC20", Offset = "0x7A6C220", VA = "0x187A6DC20", Slot = "37")]
	public void IMAHGOINCBB([Optional] HMAKLDEGKBC OGABAGJHKNB, [Optional] bool? AGLEHBFANOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7A6F740", Offset = "0x7A6DD40", VA = "0x187A6F740")]
	private bool JLLBGKMGEAA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7A6CCF0", Offset = "0x7A6B2F0", VA = "0x187A6CCF0", Slot = "21")]
	public bool HKGLBHMPOCG(DJMKKMKOHOE.KHMINOCKMDE PPBPOBKGLON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7A6FAA0", Offset = "0x7A6E0A0", VA = "0x187A6FAA0")]
	private void KDBPHKMPPLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7A71680", Offset = "0x7A6FC80", VA = "0x187A71680")]
	private void NOPIBLIGNMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7A71DD0", Offset = "0x7A703D0", VA = "0x187A71DD0")]
	private static void OELFCHAKDMH(Dictionary<GLNGPPKPMIG, Material> KEMDFPKPCOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7A702D0", Offset = "0x7A6E8D0", VA = "0x187A702D0")]
	private static void LNHBEJIKCOC(Dictionary<Renderer, DCAOEHPAGLN> JGEDDGOCJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7A70F90", Offset = "0x7A6F590", VA = "0x187A70F90")]
	private void MOMLGHGHKAB(SkinnedMeshRenderer[] GMCMJGGCAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7A71840", Offset = "0x7A6FE40", VA = "0x187A71840")]
	private void OBKENODFJNH(SkinnedMeshRenderer KMAINCIGCMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7A70CC0", Offset = "0x7A6F2C0", VA = "0x187A70CC0")]
	private void MNCEHLGEMCP(List<KBJDIMPKBHI> HOFMPDNMMNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7A71460", Offset = "0x7A6FA60", VA = "0x187A71460")]
	private void NFGNFEFIHCM(Dictionary<string, GKHPBLLBAIL<Texture2D>> DHPEMHCCIBM, bool HPAPGOPEPHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7A70A30", Offset = "0x7A6F030", VA = "0x187A70A30")]
	private void MCGAJABICJK(Dictionary<string, List<GLNGPPKPMIG>> DHPEMHCCIBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7A6FC60", Offset = "0x7A6E260", VA = "0x187A6FC60")]
	private void KDMOFAFAAMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7A716B0", Offset = "0x7A6FCB0", VA = "0x187A716B0")]
	private void OAACECFAIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7A6EA60", Offset = "0x7A6D060", VA = "0x187A6EA60")]
	private void IMCBDOLMLIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7A70EA0", Offset = "0x7A6F4A0", VA = "0x187A70EA0")]
	private void MOABECDHBCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7A72190", Offset = "0x7A70790", VA = "0x187A72190")]
	private void OLHIFDCNAIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7A6A820", Offset = "0x7A68E20", VA = "0x187A6A820")]
	private void CLHBCHLPMGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7A6A750", Offset = "0x7A68D50", VA = "0x187A6A750")]
	private void CJFIMONNIAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7A72340", Offset = "0x7A70940", VA = "0x187A72340")]
	private void PIOIFLENEBA(bool KEMGAMGEOGD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7A663B0", Offset = "0x7A649B0", VA = "0x187A663B0")]
	private void ADEKJEGHAIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7A6FF20", Offset = "0x7A6E520", VA = "0x187A6FF20")]
	private void KOPFBGKGPPE(bool KEMGAMGEOGD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7A6BC10", Offset = "0x7A6A210", VA = "0x187A6BC10")]
	private void GHAGFEOHPJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7A6D510", Offset = "0x7A6BB10", VA = "0x187A6D510")]
	private void IFJBJDIBEEP(Material KCFANBEOAGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7A6FDB0", Offset = "0x7A6E3B0", VA = "0x187A6FDB0")]
	private void KNDDBHAJDDH(Material KCFANBEOAGC, Color FFKDKFFFLJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7A6A510", Offset = "0x7A68B10", VA = "0x187A6A510")]
	private void CGBAJANPKDH(Material KCFANBEOAGC, Color FFKDKFFFLJI, Color PCNBINHACDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7A6A970", Offset = "0x7A68F70", VA = "0x187A6A970")]
	private void COHLDCGBLHO(Material KCFANBEOAGC, Color BCJBJCJEEOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7A6D320", Offset = "0x7A6B920", VA = "0x187A6D320")]
	private void IDEJADEEPCC(Material KCFANBEOAGC, Texture2D BFGBBIJNNHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7A68D50", Offset = "0x7A67350", VA = "0x187A68D50")]
	private void BIFKOANKICK(Material KCFANBEOAGC, Texture LJGGMGAEHBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7A6CDE0", Offset = "0x7A6B3E0", VA = "0x187A6CDE0")]
	private void IBBNNJCLPEJ(Action<DCAOEHPAGLN> GBFPEDHKGBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7A68B70", Offset = "0x7A67170", VA = "0x187A68B70")]
	private void BBIKNLDPMGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7A68F70", Offset = "0x7A67570", VA = "0x187A68F70")]
	private void CAPNFLHKIKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7A70660", Offset = "0x7A6EC60", VA = "0x187A70660")]
	private void MCBAKJPICOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7A6C8A0", Offset = "0x7A6AEA0", VA = "0x187A6C8A0")]
	public void HGPFPPHDEON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7A6BB90", Offset = "0x7A6A190", VA = "0x187A6BB90", Slot = "4")]
	private void GAFHEDEAHLB([In] HMAAKGCFJIK EFGPLJKHBGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7A6CDA0", Offset = "0x7A6B3A0", VA = "0x187A6CDA0")]
	[CompilerGenerated]
	private HPIGCMLNLFB HMMEOJBCOED(OEHMJDNAMGC NOOBIPOJNNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7A68EB0", Offset = "0x7A674B0", VA = "0x187A68EB0")]
	[CompilerGenerated]
	private void BKNBFAFHIOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7A6BB60", Offset = "0x7A6A160", VA = "0x187A6BB60")]
	[CompilerGenerated]
	private void FKAEIOMLNMK(DCAOEHPAGLN FHHMDKONHLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x7A6ABF0", Offset = "0x7A691F0", VA = "0x187A6ABF0")]
	[CompilerGenerated]
	private void DEMEKEIKKIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7A70F70", Offset = "0x7A6F570", VA = "0x187A70F70")]
	[CompilerGenerated]
	private void MOICDOMNIKK(DCAOEHPAGLN FHHMDKONHLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7A6CD10", Offset = "0x7A6B310", VA = "0x187A6CD10")]
	[CompilerGenerated]
	private void HLPBFHELLMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7A71690", Offset = "0x7A6FC90", VA = "0x187A71690")]
	[CompilerGenerated]
	private void NPAALKFEGOL(DCAOEHPAGLN FHHMDKONHLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7A72230", Offset = "0x7A70830", VA = "0x187A72230")]
	[CompilerGenerated]
	private void PAKCLIKCHPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7A66220", Offset = "0x7A64820", VA = "0x187A66220")]
	[CompilerGenerated]
	private void ACAACAIBPFM(DCAOEHPAGLN FHHMDKONHLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7A6BAD0", Offset = "0x7A6A0D0", VA = "0x187A6BAD0")]
	[CompilerGenerated]
	private void FJIPKGHFBEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7A68F40", Offset = "0x7A67540", VA = "0x187A68F40")]
	[CompilerGenerated]
	private void BMIOMOKEKIM(DCAOEHPAGLN FHHMDKONHLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7A72420", Offset = "0x7A70A20", VA = "0x187A72420")]
	[CompilerGenerated]
	private void PJNFIHFEEBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7A6B7A0", Offset = "0x7A69DA0", VA = "0x187A6B7A0")]
	[CompilerGenerated]
	private void FDNJOEKIBGM(DCAOEHPAGLN FHHMDKONHLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7A715E0", Offset = "0x7A6FBE0", VA = "0x187A715E0")]
	[CompilerGenerated]
	private void NNFLIFBIJCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7A6AC80", Offset = "0x7A69280", VA = "0x187A6AC80")]
	[CompilerGenerated]
	private void DINKMLIODNC(DCAOEHPAGLN FHHMDKONHLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7A6FA20", Offset = "0x7A6E020", VA = "0x187A6FA20")]
	[CompilerGenerated]
	private void KBNFDLPLIMO(KeyValuePair<string, GKHPBLLBAIL<Texture2D>> MKENHCDLPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7A72330", Offset = "0x7A70930", VA = "0x187A72330")]
	[CompilerGenerated]
	private void PHCIFEKAJNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7A700D0", Offset = "0x7A6E6D0", VA = "0x187A700D0")]
	[CompilerGenerated]
	private void LFGJJANLOBC(DCAOEHPAGLN FHHMDKONHLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7A72220", Offset = "0x7A70820", VA = "0x187A72220")]
	[CompilerGenerated]
	private void OMIFPODPAGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7A724B0", Offset = "0x7A70AB0", VA = "0x187A724B0")]
	[CompilerGenerated]
	private void PJOLENPLLIB(DCAOEHPAGLN FHHMDKONHLB)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class AvatarElbowBendHelperController : MonoBehaviour, FNDPENBBHHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		[SerializeField]
		[ANKANEOPOFH(JINCPHMLLKA.Self, false, false, false)]
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
		[SerializeField]
		[FormerlySerializedAs("MinScaleValues")]
		[Header("Scale")]
		private Vector3 ScaleValuesAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[SerializeField]
		[FormerlySerializedAs("MaxScaleValues")]
		private Vector3 ScaleValuesAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[FormerlySerializedAs("MinLocalPositionalOffset")]
		[Header("Positional Offset")]
		[SerializeField]
		private Vector3 PositionalOffsetAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[SerializeField]
		[FormerlySerializedAs("MaxLocalPositionOffset")]
		private Vector3 PositionalOffsetAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private Vector3? AMLCIJLPALA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private bool NGOJKHPONJC;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7A5F3F0", Offset = "0x7A5D9F0", VA = "0x187A5F3F0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7A5FA10", Offset = "0x7A5E010", VA = "0x187A5FA10", Slot = "4")]
		public void UpdateController(float CJIPMCGKHCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xC4D830", Offset = "0xC4BE30", VA = "0x180C4D830", Slot = "6")]
		public void SetEnabled(bool OHLIHBDBKCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7A5F4D0", Offset = "0x7A5DAD0", VA = "0x187A5F4D0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7A5FED0", Offset = "0x7A5E4D0", VA = "0x187A5FED0")]
		public AvatarElbowBendHelperController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class AvatarElbowBendTargetController : MonoBehaviour, FNDPENBBHHD
	{
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private const float BFLNMEKIELO = 45f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		[SerializeField]
		[ANKANEOPOFH(JINCPHMLLKA.Self, false, false, false)]
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
		private Vector3 HJEIFAIOFNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private Vector3 KFHNBMCCOHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private bool NGOJKHPONJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private float OONJILLHKNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private float CBFPOMJNHNH;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7A60250", Offset = "0x7A5E850", VA = "0x187A60250", Slot = "4")]
		public void UpdateController(float CJIPMCGKHCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xE8A7F0", Offset = "0xE88DF0", VA = "0x180E8A7F0", Slot = "6")]
		public void SetEnabled(bool OHLIHBDBKCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7A5FF70", Offset = "0x7A5E570", VA = "0x187A5FF70")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7A60D10", Offset = "0x7A5F310", VA = "0x187A60D10")]
		public AvatarElbowBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class CGBJAHEPEBP : CPCAHHNKCEK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private static readonly int NJJJCPCPFLJ;

	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private static readonly int MJHHFJNKJEF;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private static readonly int OCIDILOCMAC;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private static readonly int BEJEEAPNFMP;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static readonly int LDNODBHMBKJ;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private static readonly int MGNCCFMICBK;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static readonly int DBIPGNMGAEP;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static readonly int JBOPEFECFII;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private static readonly int IFMFIAMJNCA;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private static readonly int NOILOECBOOA;

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private static readonly int MDFOACBHLFA;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private static readonly int JFOOAEDJKDF;

	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private static readonly int FGEMNOHBGBJ;

	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private static readonly int IDMFENOKKCG;

	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private static readonly int JKKHBPLANAE;

	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private static readonly int LGGKIBLHIKA;

	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private static readonly int HGNKPOHAEMC;

	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private static readonly int HGBCAOBHHBE;

	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private static readonly int JLLPGECHPHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private Transform FCICGIENLMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private Transform MAMOOMCNPIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private Transform GGILGKACNCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private Transform NALHOIEOLAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private Transform KLJAFAFLLKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private Transform NLPGKNNMNFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private DJNEMBCDFBB IKEDLLJHPCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private Material INOPPGLPKEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private SkinnedMeshRenderer[] IJFBAEOOKCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private readonly List<Material> HCIADMPJHDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private GMCHJHHGEBP LIHDPFOGBBH;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public GCADBNOOJOM OOHBJBGFLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private GMCHJHHGEBP DDPLHOMMJAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7A7B920", Offset = "0x7A79F20", VA = "0x187A7B920")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool DINPHDIMOPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7A7B260", Offset = "0x7A79860", VA = "0x187A7B260", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x7A79E30", Offset = "0x7A78430", VA = "0x187A79E30")]
	public void ANJKPBDKBKO([In] DJNEMBCDFBB KLDHMLLFEDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x7A79D90", Offset = "0x7A78390", VA = "0x187A79D90")]
	public void DGFLOGPPDFF([In] BJABNEMFONN JOIIFDKKKIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x7A7ADA0", Offset = "0x7A793A0", VA = "0x187A7ADA0", Slot = "6")]
	public void DCINBHCDCKF(FEBJLGDBOMJ LINHHCIFANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x7A7B440", Offset = "0x7A79A40", VA = "0x187A7B440")]
	private Vector2 GIADCGJDPOI(Vector2 MEKPPHHJOHD)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x7A79EE0", Offset = "0x7A784E0", VA = "0x187A79EE0")]
	public void BJPPMMGMBIH([In] MEGLFPKOFKP JOIIFDKKKIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7A7B9A0", Offset = "0x7A79FA0", VA = "0x187A7B9A0")]
	private void PKGADBJMEDN(JNCABIABPCN LDKGBCHHGEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7A7B4A0", Offset = "0x7A79AA0", VA = "0x187A7B4A0")]
	private void LOINKDEDGPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x7A7B3B0", Offset = "0x7A799B0", VA = "0x187A7B3B0")]
	private void FNLCIAJLGBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7A7B3B0", Offset = "0x7A799B0", VA = "0x187A7B3B0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7A7C080", Offset = "0x7A7A680", VA = "0x187A7C080")]
	public CGBJAHEPEBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7A79D90", Offset = "0x7A78390", VA = "0x187A79D90", Slot = "5")]
	private void AHHCJBBCMKK([In] BJABNEMFONN JOIIFDKKKIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7A7B430", Offset = "0x7A79A30", VA = "0x187A7B430", Slot = "7")]
	private void FLGLODCEAML([In] MEGLFPKOFKP JOIIFDKKKIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x7A7B420", Offset = "0x7A79A20", VA = "0x187A7B420")]
	[CompilerGenerated]
	internal static float FCBMNJCHJJG(float OHLIHBDBKCE, float LJOCPPONLJF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7A7B830", Offset = "0x7A79E30", VA = "0x187A7B830")]
	[CompilerGenerated]
	internal static void MDCNNLBMNEN(Vector2 KIBNLFAIDNK, Vector2 GDKPINFECCI, Vector2 CFNMLMNHCMF, Vector2 COJGDIKBGKB, Vector2 JNIBMOMFMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7A79D50", Offset = "0x7A78350", VA = "0x187A79D50")]
	[CompilerGenerated]
	internal static Vector4 AFFKDEHLBCF(Vector2 EPCLGOKLIPO, Vector2 HDLKNIPAJGK)
	{
		return default(Vector4);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class AvatarForearmRollController : MonoBehaviour, FNDPENBBHHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		[SerializeField]
		private Transform TwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		[SerializeField]
		private Transform LowerArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		[SerializeField]
		private Transform UpperArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		[SerializeField]
		private Transform ElbowTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		[SerializeField]
		private float RollTowardsWristAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		[SerializeField]
		private float RollSoftMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		[SerializeField]
		private float RollSoftMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		[SerializeField]
		private float LowerArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		[SerializeField]
		private float UpperArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		[SerializeField]
		private float ElbowTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private float OONJILLHKNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private bool NGOJKHPONJC;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x7A764D0", Offset = "0x7A74AD0", VA = "0x187A764D0", Slot = "4")]
		public void UpdateController(float CJIPMCGKHCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x1692230", Offset = "0x1690830", VA = "0x181692230", Slot = "6")]
		public void SetEnabled(bool OHLIHBDBKCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x7A76D30", Offset = "0x7A75330", VA = "0x187A76D30")]
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
			[Cpp2IlInjected.Token(Token = "0x400016E")]
			[Tooltip("Name of animation original state to override")]
			public string OriginalName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400016F")]
			[Tooltip("Name of animation state to use as an override")]
			public string OverrideName;

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public AnimationOverride()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		[SerializeField]
		private AnimationOverride[] HandStateOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private Dictionary<int, int> _animationOverrides;

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x7A76D60", Offset = "0x7A75360", VA = "0x187A76D60")]
		public void EEBICEODLFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x7A76E80", Offset = "0x7A75480", VA = "0x187A76E80")]
		public int FNAPAHPDNME(int MKDGMAIADPH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public AvatarHandDisplaySettings()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class HDJDJLAMOAI : HEGHJMBLKOO
{
	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x7A82B60", Offset = "0x7A81160", VA = "0x187A82B60", Slot = "22")]
	public override float GMPOCHCOCNJ()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7A82BB0", Offset = "0x7A811B0", VA = "0x187A82BB0")]
	public HDJDJLAMOAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class HEGHJMBLKOO : EKFIOJKBHPO
{
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private static int ABCGPAEDGJN;

	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private static int KFFJKPAFGNL;

	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private static int BBODBJBHIOG;

	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private static int FCFJKGNMFLP;

	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private static int FMLJEDOIIMA;

	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private static int IJEAEMGBKKJ;

	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private static int GADJOOHMLJK;

	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private static int[] AIJAFLGJILC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private DMEHENLMGJH IKEDLLJHPCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private MMKICHODPJH INHFDGIMPGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private int ODFCGHCJBGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private float KHAIMLCJHFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	protected Animator MILKLFGDHHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	protected AvatarConfiguration JGKNHDNFNIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	protected int NLJAJPIBBIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private int LACMCHAHLAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private int GNLEJDGMEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private bool HJAGCICBIHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private OKECFPHNFBM GHCLEMFBJEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private int HNFBBNCHPKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private float LGDBNAJHNPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private AvatarHandDisplaySettings JANFNOBCGGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private BLMBMEMIHNO MCCGPEKDGIF;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Transform ELCODABBAGK
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public Vector3 KAABAPECGIO
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x16866D0", Offset = "0x1684CD0", VA = "0x1816866D0")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x16868A0", Offset = "0x1684EA0", VA = "0x1816868A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Quaternion CAFBADJHJAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xD2BF50", Offset = "0xD2A550", VA = "0x180D2BF50")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xF38230", Offset = "0xF36830", VA = "0x180F38230")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool GOGOMIOHLME
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7A83540", Offset = "0x7A81B40", VA = "0x187A83540")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7A836F0", Offset = "0x7A81CF0", VA = "0x187A836F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool PJHPPCIEHPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0xD31730", Offset = "0xD2FD30", VA = "0x180D31730")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public Vector3 EMENJINFHHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0xA179B0", Offset = "0xA15FB0", VA = "0x180A179B0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xA17970", Offset = "0xA15F70", VA = "0x180A17970")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Quaternion HJGKPPALEPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x10BFCA0", Offset = "0x10BE2A0", VA = "0x1810BFCA0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x145F3A0", Offset = "0x145D9A0", VA = "0x18145F3A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public ACKOLLANMDJ CFAKDOIEGPC
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xABF8C0", Offset = "0xABDEC0", VA = "0x180ABF8C0", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(ACKOLLANMDJ);
		}
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xABF6C0", Offset = "0xABDCC0", VA = "0x180ABF6C0", Slot = "4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public ACKOLLANMDJ PFHACCAHHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x25371E0", Offset = "0x25357E0", VA = "0x1825371E0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(ACKOLLANMDJ);
		}
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x25359E0", Offset = "0x2533FE0", VA = "0x1825359E0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public float MDAKCDIKJOD
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0xABA670", Offset = "0xAB8C70", VA = "0x180ABA670", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0xF475D0", Offset = "0xF45BD0", VA = "0x180F475D0", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool DNOHGGGLGMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7A834C0", Offset = "0x7A81AC0", VA = "0x187A834C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool NCOBFILDJDP
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x7A82E70", Offset = "0x7A81470", VA = "0x187A82E70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool ODAEEBKKKFF
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x7A82EC0", Offset = "0x7A814C0", VA = "0x187A82EC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool IEFMFOLOPKL
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x7A834B0", Offset = "0x7A81AB0", VA = "0x187A834B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x7A82C20", Offset = "0x7A81220", VA = "0x187A82C20", Slot = "21")]
	public void ANJKPBDKBKO(DMEHENLMGJH KLDHMLLFEDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x7A834D0", Offset = "0x7A81AD0", VA = "0x187A834D0")]
	public void NPJOAFGLBEI(MMKICHODPJH AGPMMEOIJKA, AvatarHandDisplaySettings OHPJOMKGGBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x7A830B0", Offset = "0x7A816B0", VA = "0x187A830B0", Slot = "12")]
	public void JKDCAAMODLN(bool MIHGKLOAIPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x7A83140", Offset = "0x7A81740", VA = "0x187A83140", Slot = "11")]
	public void JOPMFAEKJFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0xABA670", Offset = "0xAB8C70", VA = "0x180ABA670", Slot = "22")]
	public virtual float GMPOCHCOCNJ()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x7A83570", Offset = "0x7A81B70", VA = "0x187A83570")]
	private int PFNAIGOJIMJ(ACKOLLANMDJ EJEBDHOKGAM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x7A82EF0", Offset = "0x7A814F0", VA = "0x187A82EF0")]
	private void JFOHEHKJEEK(int PHIKMMCANBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x7A83520", Offset = "0x7A81B20", VA = "0x187A83520", Slot = "13")]
	public bool OMFFKBHGPOJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x7A82C10", Offset = "0x7A81210", VA = "0x187A82C10", Slot = "14")]
	public bool AENLDHPCDDH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x7A82DC0", Offset = "0x7A813C0", VA = "0x187A82DC0")]
	private ACKOLLANMDJ BPLCONLGBMM()
	{
		return default(ACKOLLANMDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x1BE6630", Offset = "0x1BE4C30", VA = "0x181BE6630", Slot = "15")]
	public void DCPHJHIKMJN(bool MIHGKLOAIPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7A82E80", Offset = "0x7A81480", VA = "0x187A82E80", Slot = "10")]
	public void HPGKJHEKAMN(int PHIKMMCANBH, float CGBONFJILMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7A82ED0", Offset = "0x7A814D0", VA = "0x187A82ED0", Slot = "8")]
	public void IMNCKNLNKCG(OKECFPHNFBM IDAKFFICKHC, bool CBHHPIGGAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x7A82E60", Offset = "0x7A81460", VA = "0x187A82E60", Slot = "9")]
	public void HKANKMCPKMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7A82E10", Offset = "0x7A81410", VA = "0x187A82E10", Slot = "16")]
	public void COOCPPOKIJB(Transform JHDAOHEONAC, Vector3 MKBIPJMOOAN, Quaternion IADANCLOJAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x7A839B0", Offset = "0x7A81FB0", VA = "0x187A839B0")]
	public HEGHJMBLKOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class NCKDDFHNPMI : OEHMJDNAMGC
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class OFGNCOPANGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public NCKDDFHNPMI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public List<KBJDIMPKBHI> prefabHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public List<KBJDIMPKBHI> materialHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public GKHPBLLBAIL<Material[]> loadMaterialsHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public GKHPBLLBAIL<HAJFBGNLPCB> loadPrefabHandle;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public OFGNCOPANGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x7A862F0", Offset = "0x7A848F0", VA = "0x187A862F0")]
		internal HPIGCMLNLFB DPKBNDMOCLL(string error)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	public ALBBMKANDAF JAJLHFMKFFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	public HAJFBGNLPCB HMHHKJPBFJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private GKHPBLLBAIL<HAJFBGNLPCB> IFAEJMIBMFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private GKHPBLLBAIL<Material[]> JBMBHBJAIKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	public Material[] JNBBNJHINOG;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool FJPOBBHMHEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0xA18200", Offset = "0xA16800", VA = "0x180A18200")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0xA18020", Offset = "0xA16620", VA = "0x180A18020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public DJMKKMKOHOE.KHMINOCKMDE PHBMKMKLKMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x9EB780", Offset = "0x9E9D80", VA = "0x1809EB780")]
		[CompilerGenerated]
		get
		{
			return default(DJMKKMKOHOE.KHMINOCKMDE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x9F0810", Offset = "0x9EEE10", VA = "0x1809F0810")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x7A860B0", Offset = "0x7A846B0", VA = "0x187A860B0")]
	public NCKDDFHNPMI(LEMFDNDBDJC OJOHFHDBACP, ALBBMKANDAF LGIKDEFBHHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x7A85760", Offset = "0x7A83D60", VA = "0x187A85760", Slot = "6")]
	public override HPIGCMLNLFB LKGBAHIGMNB(List<KBJDIMPKBHI> MKIPMDAKLBD, List<KBJDIMPKBHI> BBGGIAKGEEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x7A84FB0", Offset = "0x7A835B0", VA = "0x187A84FB0")]
	public HPIGCMLNLFB CMGDAOOLDEM(List<KBJDIMPKBHI> MKIPMDAKLBD, List<KBJDIMPKBHI> BBGGIAKGEEL, GKHPBLLBAIL<Material[]> JBMBHBJAIKN, [Optional] GKHPBLLBAIL<HAJFBGNLPCB> ENBIBBBCMFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x7A85C00", Offset = "0x7A84200", VA = "0x187A85C00")]
	public (GKHPBLLBAIL<Material[]>, GKHPBLLBAIL<HAJFBGNLPCB>) MDCJCLPFFIJ(List<KBJDIMPKBHI> MKIPMDAKLBD, List<KBJDIMPKBHI> BBGGIAKGEEL)
	{
		return default((GKHPBLLBAIL<Material[]>, GKHPBLLBAIL<HAJFBGNLPCB>));
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x7A85630", Offset = "0x7A83C30", VA = "0x187A85630", Slot = "7")]
	public override OLNAGKBEHCB LEBDIAJMBFP(uint GKGMDAMJCNF, AvatarSkinnedMeshBoneOrderRemapsData PCHECJMOKMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x7A84DA0", Offset = "0x7A833A0", VA = "0x187A84DA0")]
	public OLNAGKBEHCB AKIELJOOAOC(GameObject CFDBIKMCOBM, uint GKGMDAMJCNF, bool GCLDNCLHPBC, bool EMLACCABLNJ, AvatarSkinnedMeshBoneOrderRemapsData PCHECJMOKMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x7A852B0", Offset = "0x7A838B0", VA = "0x187A852B0")]
	public static bool EFFHBPIJODE(Renderer[] GMCMJGGCAFJ, string FJFIBOCIHMF, [Out] Renderer BLBNOAMHOCI, [Out] Renderer EJPCGAKHDCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x7A86060", Offset = "0x7A84660", VA = "0x187A86060", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x7A85F90", Offset = "0x7A84590", VA = "0x187A85F90")]
	private (GKHPBLLBAIL<HAJFBGNLPCB>, GKHPBLLBAIL<Material[]>) PEPJBMBMKAN()
	{
		return default((GKHPBLLBAIL<HAJFBGNLPCB>, GKHPBLLBAIL<Material[]>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7A85610", Offset = "0x7A83C10", VA = "0x187A85610")]
	[CompilerGenerated]
	private void IEKDGFMIENC(HAJFBGNLPCB OBOOAPELMPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x9EE6B0", Offset = "0x9ECCB0", VA = "0x1809EE6B0")]
	[CompilerGenerated]
	private void ACAEGLCAOKJ(Material[] OBOOAPELMPF)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class AvatarKneeBendTargetController : MonoBehaviour, FNDPENBBHHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		[SerializeField]
		[ANKANEOPOFH(JINCPHMLLKA.Self, false, false, false)]
		private Transform KneeBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		[SerializeField]
		private Transform RootSpineBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		[SerializeField]
		private Transform ThighBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		[SerializeField]
		private Transform FootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		[SerializeField]
		private float WeightToFootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		[SerializeField]
		private Vector3 BendTargetOffsetFromHipToFootMidPoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		[SerializeField]
		private Bounds KneeTargetConstrainedBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private Vector3 HJEIFAIOFNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private Vector3 NKNAJLDJHJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private Vector3 PINFALKKIMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private Matrix4x4 JEBMBPBKBDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private bool NGOJKHPONJC;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x7A77360", Offset = "0x7A75960", VA = "0x187A77360", Slot = "4")]
		public void UpdateController(float CJIPMCGKHCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7A77350", Offset = "0x7A75950", VA = "0x187A77350", Slot = "6")]
		public void SetEnabled(bool OHLIHBDBKCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x7A76EF0", Offset = "0x7A754F0", VA = "0x187A76EF0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x7A77A20", Offset = "0x7A76020", VA = "0x187A77A20")]
		public AvatarKneeBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[HJNCDIOGCJG]
public struct CCLABJMPOGL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	[ReadOnly]
	public PLEFCEKBJLA NFBNCDAFDCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	[ReadOnly]
	public int OGHFEPGBEDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	public EBEEGCNLDFE GAJLKEHBMPI;

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7A78DD0", Offset = "0x7A773D0", VA = "0x187A78DD0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[HJNCDIOGCJG]
[NativeContainer]
public struct EBEEGCNLDFE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	public NativeArray<Vector3> JAIBDMKDPON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	public NativeArray<Vector3> COEAFKGHHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public NativeArray<Vector4> IABDNJIKDAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public NativeArray<Vector2> HJOLBLABKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public NativeArray<Vector2> NIIIGPHODFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public NativeArray<Vector2> GENNKFIGGKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public NativeArray<Vector2> PHAHDPDBMHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public NativeArray<Color> ANJLCAODDFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public NativeArray<int> HECOEAMAHLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	public NativeArray<int> KAODBKFLMFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private NativeArray<int> LPPAPOBKIEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private NativeArray<int> CNHHIFNMEHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	public NativeArray<int> OLKBDAMMBPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	public NativeArray<int> MNAAOOIJBGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public NativeArray<int> FLLPPOBDFDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	public NativeArray<BoneWeight> FMAFIGJMNBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private NativeArray<int> PMLCGCAHNGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private bool INLAHEKHDGL;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int HINGJKKACPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x7A7ED90", Offset = "0x7A7D390", VA = "0x187A7ED90")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x7A7F390", Offset = "0x7A7D990", VA = "0x187A7F390")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int KMEAPHNMOHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x7A7ED80", Offset = "0x7A7D380", VA = "0x187A7ED80")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x7A7F660", Offset = "0x7A7DC60", VA = "0x187A7F660")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int DCEBGGCGCON
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7A7F670", Offset = "0x7A7DC70", VA = "0x187A7F670")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x7A7F730", Offset = "0x7A7DD30", VA = "0x187A7F730")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x7A7F7D0", Offset = "0x7A7DDD0", VA = "0x187A7F7D0")]
	public EBEEGCNLDFE(int DLOLGMFGMCF, int KHMLDEKGOGN, int OKKKFJPPJBM, int NCOLCNECKHG, Allocator NDFENJBGNOB, int LJHHEIGDCPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x7A7F320", Offset = "0x7A7D920", VA = "0x187A7F320")]
	public void HDLFLBKAKKF(int OHHMJGCBCKD, Vector3 IINHKHEMEHJ, Vector3 KLJKHLHNLGP, Vector4 LEMBKBGMCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x7A7F3C0", Offset = "0x7A7D9C0", VA = "0x187A7F3C0")]
	public void JDOKECODNDF(int OHHMJGCBCKD, BoneWeight NHAPOAOKIGM, NativeSlice<byte> AHOGHGIIKDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x7A7F3A0", Offset = "0x7A7D9A0", VA = "0x187A7F3A0")]
	public Color HPNCCIMOPBK(int OHHMJGCBCKD)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x7A7F640", Offset = "0x7A7DC40", VA = "0x187A7F640")]
	public void NEMFFJAMDMK(int OHHMJGCBCKD, Color JKIBOICMIDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x7A7EDA0", Offset = "0x7A7D3A0", VA = "0x187A7EDA0")]
	public void CLCMMOGNEHO(byte KCDFLKCBIKJ, int OHHMJGCBCKD, Vector2 MGPLIBEEABL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x7A7F560", Offset = "0x7A7DB60", VA = "0x187A7F560")]
	public void KEFDAKBCNKF(int OHHMJGCBCKD, int HIJGCANIBGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x7A7EFA0", Offset = "0x7A7D5A0", VA = "0x187A7EFA0")]
	public bool ENKKJEKEEDM(int KCDFLKCBIKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x7A7F570", Offset = "0x7A7DB70", VA = "0x187A7F570")]
	public void MAAFKJANCOD(int GNDDIJKFHIM, int LLPAIMMACAP, int DDGBDMFPMAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x7A7F680", Offset = "0x7A7DC80", VA = "0x187A7F680")]
	public int[] NOADIHPCDBG(int GNDDIJKFHIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x7A7F740", Offset = "0x7A7DD40", VA = "0x187A7F740")]
	private NativeSlice<int> PPPFFNFFNHI(int GNDDIJKFHIM)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x7A7EDF0", Offset = "0x7A7D3F0", VA = "0x187A7EDF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7A7EFD0", Offset = "0x7A7D5D0", VA = "0x187A7EFD0")]
	public Mesh GHGLJPLOCLP([Optional] string IGLCIHNNBAL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[NativeContainer]
[DefaultMember("Item")]
[HJNCDIOGCJG]
public struct PLEFCEKBJLA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	public NativeArray<Vector3> JAIBDMKDPON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	public NativeArray<Vector3> COEAFKGHHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	public NativeArray<Vector4> IABDNJIKDAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public NativeArray<Vector2> HJOLBLABKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public NativeArray<Vector2> NIIIGPHODFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public NativeArray<Vector2> GENNKFIGGKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public NativeArray<Vector2> PHAHDPDBMHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public NativeArray<Color> ANJLCAODDFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public NativeArray<int> JPJKJJAOEGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	public NativeArray<int> EHJMIACINHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public NativeArray<int> PNGIGHDAOAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public NativeArray<int> FNBEINLGMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public NativeArray<bool> DLDPOELFKGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public NativeArray<int> ACGKBLDNMLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	public NativeArray<int> FEEGHAKIELF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	public NativeArray<BoneWeight> ELLAKLBKHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private NativeArray<Matrix4x4> PCLMDBCJANG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private NativeArray<long> GNNBDHEBKFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private NativeArray<byte> CLPOAEFNCPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private NativeArray<int> FKGMGNGNNFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private NativeArray<int> GHJDMLGKFPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	public NativeArray<sbyte> KKENHNPIKCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	public NativeArray<byte> BCOEJMPEBJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private NativeArray<int> AJEMBDGPNIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	private bool INLAHEKHDGL;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public int KJJANABCHPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xDA6E90", Offset = "0xDA5490", VA = "0x180DA6E90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int PEMPMDIKECC
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xC4FF50", Offset = "0xC4E550", VA = "0x180C4FF50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int LALFONMEHBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7A87180", Offset = "0x7A85780", VA = "0x187A87180")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public int IDMIEAGHKAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x7A87170", Offset = "0x7A85770", VA = "0x187A87170")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7A87070", Offset = "0x7A85670", VA = "0x187A87070")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public int HINGJKKACPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7A86DD0", Offset = "0x7A853D0", VA = "0x187A86DD0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x7A87090", Offset = "0x7A85690", VA = "0x187A87090")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public int IFCJDIOLHID
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x7A86DE0", Offset = "0x7A853E0", VA = "0x187A86DE0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7A871C0", Offset = "0x7A857C0", VA = "0x187A871C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public EONPPOBGAOL DNJJAFNOEIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7A86890", Offset = "0x7A84E90", VA = "0x187A86890")]
		get
		{
			return default(EONPPOBGAOL);
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7A87060", Offset = "0x7A85660", VA = "0x187A87060")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public byte KDIIKCBKGNP
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x7A87080", Offset = "0x7A85680", VA = "0x187A87080")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7A871B0", Offset = "0x7A857B0", VA = "0x187A871B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public MDNDLIPPLEK OEMFNNCKNFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x7A868A0", Offset = "0x7A84EA0", VA = "0x187A868A0")]
		get
		{
			return default(MDNDLIPPLEK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x7A871D0", Offset = "0x7A857D0", VA = "0x187A871D0")]
	public PLEFCEKBJLA(IList<Mesh> KBDLEKHEHMN, IList<Matrix4x4> DJFOKBGCCNJ, IList<bool> DLDPOELFKGB, byte GGNNMGDCEED, IList<byte[]> FONLLDDLMJH, IList<long> CKKFOPFCAOD, IList<bool> FNOHPKAEEOI, IList<int> ACGKBLDNMLK, IList<int> IGEECJJEHIN, IList<int> GNFGAAOIHNM, Allocator NDFENJBGNOB, EONPPOBGAOL BEBBIOKLEJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x7A870A0", Offset = "0x7A856A0", VA = "0x187A870A0")]
	public EBEEGCNLDFE IPMEGOIAMCA(Allocator NDFENJBGNOB)
	{
		return default(EBEEGCNLDFE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x7A86DF0", Offset = "0x7A853F0", VA = "0x187A86DF0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[HJNCDIOGCJG]
public class AFMLLJCKJLN : NFJIGMCMHCJ
{
	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x7A761E0", Offset = "0x7A747E0", VA = "0x187A761E0")]
	public PLEFCEKBJLA GDGODOCMIHG()
	{
		return default(PLEFCEKBJLA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x7A65D90", Offset = "0x7A64390", VA = "0x187A65D90")]
	public AFMLLJCKJLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct MDNDLIPPLEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	public NativeSlice<Vector3> JAIBDMKDPON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public NativeSlice<Vector3> COEAFKGHHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public NativeSlice<Vector4> IABDNJIKDAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public NativeSlice<Vector2> HJOLBLABKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public NativeSlice<Vector2> NIIIGPHODFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public NativeSlice<Vector2> GENNKFIGGKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public NativeSlice<Vector2> PHAHDPDBMHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	public NativeSlice<Color> ANJLCAODDFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public NativeSlice<int> PNCBJEOGGML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public NativeSlice<int> FNBEINLGMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public NativeSlice<BoneWeight> ELLAKLBKHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public NativeSlice<byte> LFFGEMJALDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	public int LBBEGJCDLKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public Matrix4x4 HBJLJGGBCBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public long CHNHHCCDPAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public NativeSlice<byte> AHOGHGIIKDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public bool PJHKDJOGIAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	public int MIFGHABDOFH;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal readonly struct GLNGPPKPMIG : IEquatable<GLNGPPKPMIG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	internal readonly Material FNLBLGEDCDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	internal readonly FOHOLFICGPJ BKAEHKCCAPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	internal readonly BEEBHKAMNNL FNBHMEMNEPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	internal readonly LEMFDNDBDJC IFCMMFOJBML;

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x7A827D0", Offset = "0x7A80DD0", VA = "0x187A827D0")]
	public GLNGPPKPMIG(Material CANJBFKPEMF, FOHOLFICGPJ GMLOOFHADHO, BEEBHKAMNNL PGOOBBKNDOF, LEMFDNDBDJC BDNPFHIBMNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x7A825B0", Offset = "0x7A80BB0", VA = "0x187A825B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x7A823B0", Offset = "0x7A809B0", VA = "0x187A823B0", Slot = "4")]
	public bool Equals(GLNGPPKPMIG MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x7A82430", Offset = "0x7A80A30", VA = "0x187A82430", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x7A82510", Offset = "0x7A80B10", VA = "0x187A82510", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyDisplayBehaviour : MonoBehaviour, GBFNELEFJAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		[Header("Configuration")]
		[SerializeField]
		protected AvatarConfiguration configuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		[SerializeField]
		protected Animator skeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		[SerializeField]
		protected Renderer[] watchRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		[Header("Configuration")]
		[SerializeField]
		private BLMBMEMIHNO avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		[SerializeField]
		private AvatarSkinAssetItem potatoAvatarSkinAssetItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		[FormerlySerializedAs("avatarSkinAsset")]
		[SerializeField]
		private AssetReference avatarSkinAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		[SerializeField]
		private GameObject firstPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		[SerializeField]
		public GameObject thirdPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		[SerializeField]
		private GameObject[] hideInFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		[SerializeField]
		protected Transform headAdditiveBaseBoneTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		[SerializeField]
		private Material BodyMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		[SerializeField]
		private Material FaceMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		[SerializeField]
		private Material DefaultAvatarItemMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		[SerializeField]
		private Shader AvatarDefaultShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		[SerializeField]
		private Shader AvatarUberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		[SerializeField]
		private Transform DeformRigRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		[SerializeField]
		private SkinnedMeshRenderer BaseSkinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		[SerializeField]
		protected AvatarSkinnedMeshBoneOrderRemapsData BoneOrderRemapsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		[SerializeField]
		[Header("Arm Animation Controllers")]
		private AvatarForearmRollController LeftForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		[SerializeField]
		private AvatarElbowBendHelperController LeftElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		[SerializeField]
		private AvatarElbowBendTargetController LeftElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		[SerializeField]
		private AvatarKneeBendTargetController LeftKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		[SerializeField]
		private AvatarForearmRollController RightForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		[SerializeField]
		private AvatarElbowBendHelperController RightElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		[SerializeField]
		private AvatarElbowBendTargetController RightElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		[SerializeField]
		private AvatarKneeBendTargetController RightKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		[SerializeField]
		private Transform LeftEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		[SerializeField]
		private Transform LeftEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		[SerializeField]
		private Transform RightEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		[SerializeField]
		private Transform RightEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		[SerializeField]
		private Transform NoseMoveTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		[SerializeField]
		private Transform MouthBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		[SerializeField]
		private AvatarBodyPartShapesManager avatarBodyPartShapesManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		[SerializeField]
		private Transform HatAnchorBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		[SerializeField]
		private Transform LeftHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		[SerializeField]
		private Transform RightHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		[SerializeField]
		private GameObject LeftHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		[SerializeField]
		private GameObject RightHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private EEFKKODIKGJ PBMIFJMNDNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private CPCAHHNKCEK GMCECMEINAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		private EKFIOJKBHPO MGCOAJDDCHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		private EKFIOJKBHPO NCPPMDKMJDM;

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public EEFKKODIKGJ OLIAKELJPGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x7A789E0", Offset = "0x7A76FE0", VA = "0x187A789E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public CPCAHHNKCEK AHDDGCHGPPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x7A78A30", Offset = "0x7A77030", VA = "0x187A78A30", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public EKFIOJKBHPO LGEIPIKACBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x7A78A80", Offset = "0x7A77080", VA = "0x187A78A80", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public EKFIOJKBHPO MEJGBGHHDEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x7A78AD0", Offset = "0x7A770D0", VA = "0x187A78AD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public Transform KLBBKNPLNCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x7A78B20", Offset = "0x7A77120", VA = "0x187A78B20", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public BLMBMEMIHNO JOABLBMPDKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x9F0430", Offset = "0x9EEA30", VA = "0x1809F0430", Slot = "12")]
			get
			{
				return default(BLMBMEMIHNO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x7A77A30", Offset = "0x7A76030", VA = "0x187A77A30")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7A78840", Offset = "0x7A76E40", VA = "0x187A78840")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x7A78750", Offset = "0x7A76D50", VA = "0x187A78750", Slot = "8")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7A78840", Offset = "0x7A76E40", VA = "0x187A78840", Slot = "9")]
		public void TeardownAvatarDisplaySystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x7A77DE0", Offset = "0x7A763E0", VA = "0x187A77DE0", Slot = "10")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x7A788F0", Offset = "0x7A76EF0", VA = "0x187A788F0")]
		public void UpdatePostIKAnimControllers(float CJIPMCGKHCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x7A787B0", Offset = "0x7A76DB0", VA = "0x187A787B0")]
		private void NIIKDBLCGKK(GameObject BOMDCGFKGKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x7A78110", Offset = "0x7A76710", VA = "0x187A78110")]
		private EEFKKODIKGJ HDGFAFEIGAO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x7A77AA0", Offset = "0x7A760A0", VA = "0x187A77AA0")]
		private CPCAHHNKCEK CJMMMKGGIEH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x7A784C0", Offset = "0x7A76AC0", VA = "0x187A784C0")]
		private EKFIOJKBHPO IMAHJBOJCDF(ECEPGPDPDKI LKCJMGGAGMB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x7A789D0", Offset = "0x7A76FD0", VA = "0x187A789D0")]
		public AvatarModernBodyDisplayBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class DCAOEHPAGLN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private MaterialPropertyBlock FHJBEKLNOIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	public Color? KKNAKKAEGIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	public Color? EIKMLKNEGHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	public Color? CIANNEIDAAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	public Color? GFMAIPOMMOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	public Color JIPGBOFPJKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	public Color BCLIKDAECBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	public Color HBBFGFAMEGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	public Texture2D MDLNPPNJNHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	public Texture2D FIGMALLLLIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	private Dictionary<GLNGPPKPMIG, int> LGPLODMABGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	private FOHOLFICGPJ[] BDBFLMBDBJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	private BEEBHKAMNNL[] DBPKBGEAOON;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	public Vector4[] JPGNJBKOJAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	public Vector4[] MKAHLKIOKKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	public Vector4[] ONDIMBFLFCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public Vector4[] GEJPNHNNGDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public Vector4[] CFCBPLMPOJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public Vector4[] KHOJIJJBIKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	private List<Texture2D> FNFNEIKOCII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private Vector4[] JCJEGIAILNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private List<Texture2D> DCNJNLGAKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private float[] GHLPFEFMGLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private Vector4[] KHIHCCMGENO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private float[] NPGGOFMHIJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public float[] GIFAANIMJGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private List<Texture2D> GINLIKAOMPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private float[] FJLGCABMEFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	private List<Texture2D> KKBKNABELAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private Vector4[] NPKIMGGPLII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private float[] KCCINMAOMII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private Vector4[] FBHJHFBGJIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public float[] BAGAFAIFKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public Texture2DArray LPAAPNDFAGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	public Texture2DArray LDKLKEPMPOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public Texture2DArray IJPLODGLPHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public Texture2DArray PHHAKOHADLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private bool GGOEHDGAGFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private int JBGMFGMAFPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private Vector2? AKGNJFDOMBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private TextureFormat BLPAAKGPDIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	private Vector2? EHHEDLILGNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private TextureFormat AGAOMJDKGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private Vector2? HBNLBDPDODL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private TextureFormat CGLPDKOMBPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private Vector2? JAINKCEEJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	private TextureFormat NAENFMFPCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	private bool CIAFEFCBLPC;

	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private static int JEPOFHHIKDD;

	[Cpp2IlInjected.Token(Token = "0x400024C")]
	private static int FFGAEADGFKA;

	[Cpp2IlInjected.Token(Token = "0x400024D")]
	private static int FOLKBAOILNN;

	[Cpp2IlInjected.Token(Token = "0x400024E")]
	private static int JALPLCEEJLB;

	[Cpp2IlInjected.Token(Token = "0x400024F")]
	private static int KLLAILCEFGF;

	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private static int MCJBEIMFHJK;

	[Cpp2IlInjected.Token(Token = "0x4000251")]
	private static int CPJAHIIKPHO;

	[Cpp2IlInjected.Token(Token = "0x4000252")]
	private static int MEPCFOIFIPH;

	[Cpp2IlInjected.Token(Token = "0x4000253")]
	private static int KIHEGEMHAPJ;

	[Cpp2IlInjected.Token(Token = "0x4000254")]
	private static int PIOENPMIFAO;

	[Cpp2IlInjected.Token(Token = "0x4000255")]
	private static int GJKPPCEFLHJ;

	[Cpp2IlInjected.Token(Token = "0x4000256")]
	private static int BEJABIKAHIC;

	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private static int NEHLPBDHIDG;

	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private static int PCDOOMCEBIH;

	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private static int DGENLFJKLOJ;

	[Cpp2IlInjected.Token(Token = "0x400025A")]
	private static int DELINIDPAHL;

	[Cpp2IlInjected.Token(Token = "0x400025B")]
	private static int FHDHOCAINGL;

	[Cpp2IlInjected.Token(Token = "0x400025C")]
	private static int LLBCPPKHJIM;

	[Cpp2IlInjected.Token(Token = "0x400025D")]
	private static int JGFDHCEEAOE;

	[Cpp2IlInjected.Token(Token = "0x400025E")]
	private static int ALODDBNCMFI;

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x7A7E890", Offset = "0x7A7CE90", VA = "0x187A7E890")]
	private DCAOEHPAGLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x7A7E7D0", Offset = "0x7A7CDD0", VA = "0x187A7E7D0")]
	public DCAOEHPAGLN(Color HOKBFOFIGDG, Color IAGHPLIANOJ, Color ABOLANAFPPL, Color? JDPPHLLCPEO, Color? MOPPNOHCOMC, Color? CDCECCBAMKD, Texture2D HMEHFKKONPO, Texture2D CBNPCICNANG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x7A7C250", Offset = "0x7A7A850", VA = "0x187A7C250")]
	internal int CNJDCFDGLMF(Material BAJKNHFGJJI, FOHOLFICGPJ GMLOOFHADHO, BEEBHKAMNNL PGOOBBKNDOF, LEMFDNDBDJC BDNPFHIBMNH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x7A7C1C0", Offset = "0x7A7A7C0", VA = "0x187A7C1C0")]
	private int CNJDCFDGLMF(GLNGPPKPMIG OEHHKNIGGMI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x7A7C830", Offset = "0x7A7AE30", VA = "0x187A7C830")]
	internal int GOGANAFBLKG(Material BAJKNHFGJJI, Color BCJBJCJEEOB, Color DENCMJLNDEA, Color GNOGEJFGEHI, Color EMEEOLPKGGL, Color MEAICLBLNAP, Texture2D FBBOIOEBNGH, Vector4 LOFGABLDGHM, Texture2D DAHLDLNOCME, Vector4 LBDAHPLCDDC, float GMHCCLLJIFJ, float KAICNIDJOJG, Texture2D DBDDDEKIGBM, Vector4 ADHIKGJFAME, float EEKJGFDCJEG, Texture2D FGNNMCDGMKK, Color MOIBEGCKKBB, Vector4 DJEDIOJLPIK, FOHOLFICGPJ GMLOOFHADHO, BEEBHKAMNNL PGOOBBKNDOF, LEMFDNDBDJC BDNPFHIBMNH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x7A7E210", Offset = "0x7A7C810", VA = "0x187A7E210")]
	private void KPFPDMEMEAG(List<Texture2D> FNFNEIKOCII, [Out] Texture2DArray EFDPLBHEFAA, [Out] Texture2DArray CMIGHGEHPCB, [Out] Texture2DArray IBFEMALCFAE, [Out] Texture2DArray ABNGOBMBIHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x7A7D400", Offset = "0x7A7BA00", VA = "0x187A7D400")]
	public void HPJNJIJIJLF(Shader JJNGHIMLANK, Renderer CCKFDFMBDLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x7A7D550", Offset = "0x7A7BB50", VA = "0x187A7D550")]
	private void ICNGOPDCFED(Shader JJNGHIMLANK, Renderer CCKFDFMBDLN, int GBGAFEDFAJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x7A7C490", Offset = "0x7A7AA90", VA = "0x187A7C490")]
	private Color DDCNNEECBOG(Color IMAFKGFPPAB, FOHOLFICGPJ FKAIEBDGNCN)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x7A7C340", Offset = "0x7A7A940", VA = "0x187A7C340")]
	private Color CPJDMEJNDNO(Color DHFMPMLDGKG, FOHOLFICGPJ FKAIEBDGNCN)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x7A7C6D0", Offset = "0x7A7ACD0", VA = "0x187A7C6D0")]
	private bool ENOFOBJDKEM(Texture2D NOMMHBGDFHE, BEEBHKAMNNL IHIJDFFNDNI, [Out] Texture2D ODLCMICFHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x7A7E3D0", Offset = "0x7A7C9D0", VA = "0x187A7E3D0")]
	private void LIEDJNDHOEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x7A7C690", Offset = "0x7A7AC90", VA = "0x187A7C690", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public abstract class OEHMJDNAMGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	public readonly LEMFDNDBDJC GAFMECPOEGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	protected bool CJCDPHEAMHG;

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public bool FONOBOLGJOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xC8F7E0", Offset = "0xC8DDE0", VA = "0x180C8F7E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0xC8F720", Offset = "0xC8DD20", VA = "0x180C8F720")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public bool AGMHOCMMNLI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0xC8F7F0", Offset = "0xC8DDF0", VA = "0x180C8F7F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0xC8F730", Offset = "0xC8DD30", VA = "0x180C8F730")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public virtual DJMKKMKOHOE.KHMINOCKMDE CHNHHCCDPAN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(DJMKKMKOHOE.KHMINOCKMDE);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xC5E900", Offset = "0xC5CF00", VA = "0x180C5E900", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public bool LPEGJDNGLLP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xF59450", Offset = "0xF57A50", VA = "0x180F59450")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool HJILDDHKHMK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x7A86290", Offset = "0x7A84890", VA = "0x187A86290")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public bool OANINHDKAKD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x7A86280", Offset = "0x7A84880", VA = "0x187A86280")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public bool OKFCBCLHBEA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x7A862A0", Offset = "0x7A848A0", VA = "0x187A862A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x7A862C0", Offset = "0x7A848C0", VA = "0x187A862C0")]
	protected OEHMJDNAMGC(LEMFDNDBDJC OJOHFHDBACP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract HPIGCMLNLFB LKGBAHIGMNB(List<KBJDIMPKBHI> MKIPMDAKLBD, List<KBJDIMPKBHI> BBGGIAKGEEL);

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract OLNAGKBEHCB LEBDIAJMBFP(uint GKGMDAMJCNF, AvatarSkinnedMeshBoneOrderRemapsData PCHECJMOKMD);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class ONNIECAEOBP : ACGLIOHHLFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	private AvatarSkinAssetItem NPELAGBPGGH;

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x7A86790", Offset = "0x7A84D90", VA = "0x187A86790")]
	public ONNIECAEOBP(AvatarSkinAssetItem AFHFOPBNIJD, AvatarSkinAssetItem.OMJMGGAGHPG IKIJFLKILNA, LEMFDNDBDJC BDNPFHIBMNH, [Optional] MCAONEJPGJL? BNBENPAGBAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x7A86530", Offset = "0x7A84B30", VA = "0x187A86530", Slot = "6")]
	public override HPIGCMLNLFB LKGBAHIGMNB(List<KBJDIMPKBHI> MKIPMDAKLBD, List<KBJDIMPKBHI> BBGGIAKGEEL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class CABEGIMOHPH
{
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	private static readonly int[] MIGKAELLCFO;

	[Cpp2IlInjected.Token(Token = "0x4000266")]
	private static readonly int[] CGIKIEMNIDF;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public static int[] LFFJFJJEPMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x7A78C80", Offset = "0x7A77280", VA = "0x187A78C80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x7A78BF0", Offset = "0x7A771F0", VA = "0x187A78BF0")]
	public static int[] DPDJODCJDGA(bool IADHJPHPKHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x7A78B40", Offset = "0x7A77140", VA = "0x187A78B40")]
	public static int APCOAFCHCJI(MEACMOOJHJN FLHKCFOEJLN, bool IADHJPHPKHP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x7A78C70", Offset = "0x7A77270", VA = "0x187A78C70")]
	private static int HIJPIDBJADI(MEACMOOJHJN FLHKCFOEJLN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x7A78BD0", Offset = "0x7A771D0", VA = "0x187A78BD0")]
	private static int BPFMNADJLMF(MEACMOOJHJN FLHKCFOEJLN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class OBKDEBGIJPA
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class PNLFNKNCCBG : IEnumerator<NFNODNEANBN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		private NFNODNEANBN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		private NFNODNEANBN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x9EC8D0", Offset = "0x9EAED0", VA = "0x1809EC8D0")]
		[DebuggerHidden]
		public PNLFNKNCCBG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x12684A0", Offset = "0x1266AA0", VA = "0x1812684A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x7A88A70", Offset = "0x7A87070", VA = "0x187A88A70", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
	public static void OAFPJEBJIFD(string HJPLNJNIFLL, int GKGMDAMJCNF, long LCMLPLJCIJO, long FKMHDOKHBNC, long BOPFEFFDLKH, long DHLBPOJKGOM, long BICFMCIKJCK, long MKJNIGEPDCN, long HDKEGHCIIKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x7A86120", Offset = "0x7A84720", VA = "0x187A86120")]
	public static OLILOOIADED CKKDEELJIEP(JobHandle GFMBLBMBIML, bool PLLMADNBOIJ, bool KJIMCOKKLJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x7A86210", Offset = "0x7A84810", VA = "0x187A86210")]
	[IteratorStateMachine(typeof(PNLFNKNCCBG))]
	private static IEnumerator<NFNODNEANBN> PDLMNGGBOKI(JobHandle BOJCEMEJOMP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class FNBJHFCKICA
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public enum IKFHLABAHFJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		General,
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		ColoredHair
	}

	[Cpp2IlInjected.Token(Token = "0x400026A")]
	public static readonly int DLLOHOIBMCG;

	[Cpp2IlInjected.Token(Token = "0x400026B")]
	public static readonly int FPDPDOLNPMA;

	[Cpp2IlInjected.Token(Token = "0x400026C")]
	public static readonly int HALLMDLCMGI;

	[Cpp2IlInjected.Token(Token = "0x400026D")]
	public static readonly int OLGMJLENALF;

	[Cpp2IlInjected.Token(Token = "0x400026E")]
	public static readonly int ILFEJNLHGBI;

	[Cpp2IlInjected.Token(Token = "0x400026F")]
	public static readonly int BDAIMPBNNIM;

	[Cpp2IlInjected.Token(Token = "0x4000270")]
	public static readonly int BCJMFFHPMNH;

	[Cpp2IlInjected.Token(Token = "0x4000271")]
	public static readonly int APALPOJLJLI;

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7A80CF0", Offset = "0x7A7F2F0", VA = "0x187A80CF0")]
	public static bool LMDNCLBKNLJ(Material CANJBFKPEMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x7A80C30", Offset = "0x7A7F230", VA = "0x187A80C30")]
	public static bool BJMDCLFJPNC(Material CANJBFKPEMF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class ACGLIOHHLFA : OEHMJDNAMGC
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class MMLCIKGPOHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public GKHPBLLBAIL<GameObject> skinAvatarItemPrefabHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public ACGLIOHHLFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public Action<string> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public MMLCIKGPOHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x7A84890", Offset = "0x7A82E90", VA = "0x187A84890")]
		internal void CKKILCNJLJA(GameObject result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x7A84C60", Offset = "0x7A83260", VA = "0x187A84C60")]
		internal void DPKBNDMOCLL(string error)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	protected AvatarSkinAssetItem ECDMDJHGGLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	protected Material[] ADHMBFMPJBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	private readonly AvatarSkinAssetItem.OMJMGGAGHPG PFCKKGANPLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	private readonly AssetReference HNEFLPHAHKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	private readonly MCAONEJPGJL? EENFEGLHOBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	private SkinnedMeshRenderer[] FCNPHNMCNLK;

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public override DJMKKMKOHOE.KHMINOCKMDE CHNHHCCDPAN
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x9EB550", Offset = "0x9E9B50", VA = "0x1809EB550", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(DJMKKMKOHOE.KHMINOCKMDE);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x9EB790", Offset = "0x9E9D90", VA = "0x1809EB790", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x7A75F90", Offset = "0x7A74590", VA = "0x187A75F90")]
	public ACGLIOHHLFA(AvatarSkinAssetItem.OMJMGGAGHPG IKIJFLKILNA, AssetReference IDFMDCFBOGG, Material JKOIHDOGJBL, LEMFDNDBDJC BDNPFHIBMNH, DJMKKMKOHOE.KHMINOCKMDE PAODEGDIMGF = (DJMKKMKOHOE.KHMINOCKMDE)0L, [Optional] MCAONEJPGJL? BNBENPAGBAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x7A760C0", Offset = "0x7A746C0", VA = "0x187A760C0")]
	public ACGLIOHHLFA(AvatarSkinAssetItem.OMJMGGAGHPG IKIJFLKILNA, AssetReference IDFMDCFBOGG, Material JKOIHDOGJBL, DJMKKMKOHOE.KHMINOCKMDE PAODEGDIMGF = (DJMKKMKOHOE.KHMINOCKMDE)0L, [Optional] MCAONEJPGJL? BNBENPAGBAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x7A75D00", Offset = "0x7A74300", VA = "0x187A75D00", Slot = "6")]
	public override HPIGCMLNLFB LKGBAHIGMNB(List<KBJDIMPKBHI> MKIPMDAKLBD, List<KBJDIMPKBHI> BBGGIAKGEEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x7A75AF0", Offset = "0x7A740F0", VA = "0x187A75AF0", Slot = "7")]
	public override OLNAGKBEHCB LEBDIAJMBFP(uint GKGMDAMJCNF, AvatarSkinnedMeshBoneOrderRemapsData PCHECJMOKMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x7A75F20", Offset = "0x7A74520", VA = "0x187A75F20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x7A75ED0", Offset = "0x7A744D0", VA = "0x187A75ED0")]
	protected void OHEJKOEKLMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class FKKJNMIPHBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	private List<int> ABDLPMBBFLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	private List<MHJEJAKECKD> COJHDCAENKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	private HashSet<Transform> GGGHEFDJDHF;

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x7A806B0", Offset = "0x7A7ECB0", VA = "0x187A806B0")]
	public static FKKJNMIPHBA ONFCAKGIHCM(Transform LEMBKBGMCDG, Dictionary<Transform, OutfitType?> KMACIEFBIGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x7A80840", Offset = "0x7A7EE40", VA = "0x187A80840")]
	private void PCCGKIBNJAM(Transform LEMBKBGMCDG, LEMFDNDBDJC BDNPFHIBMNH, Dictionary<Transform, OutfitType?> KMACIEFBIGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x7A80580", Offset = "0x7A7EB80", VA = "0x187A80580")]
	private void MFHNJFHFFNI(Transform NGNHNPHIJOK, LEMFDNDBDJC BDNPFHIBMNH, bool AHBNMILFECC, OutfitType? KAMFIEKLGNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x7A80190", Offset = "0x7A7E790", VA = "0x187A80190")]
	public GKAFCBDLFII CKDLCEHIKGJ(HashSet<string> KLBEMONCPPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x7A80B00", Offset = "0x7A7F100", VA = "0x187A80B00")]
	public FKKJNMIPHBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class GKAFCBDLFII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	private List<MHJEJAKECKD> COJHDCAENKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	private List<Matrix4x4> KAAPHLGGKJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	private Transform[] DMGKGPCHPMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	private Matrix4x4[] KJACCKFOBDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	private Dictionary<HBCCCBHLICH, int> KBBBIAMMKPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private List<PNLFNLOCNLC> BBAJMIILFEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	private bool KKNNDPFMJCM;

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public int CMIOJAJFIMN
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x7A81B00", Offset = "0x7A80100", VA = "0x187A81B00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public Transform[] IOMIJAIJMBM
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x7A82070", Offset = "0x7A80670", VA = "0x187A82070")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public Matrix4x4[] AGDHPELHHNG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x7A821D0", Offset = "0x7A807D0", VA = "0x187A821D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x7A81E80", Offset = "0x7A80480", VA = "0x187A81E80")]
	public void MFHNJFHFFNI(Transform NGNHNPHIJOK, LEMFDNDBDJC BDNPFHIBMNH, OutfitType? KAMFIEKLGNP, bool PCLFIDOGJOJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x7A81B40", Offset = "0x7A80140", VA = "0x187A81B40")]
	private void MFHNJFHFFNI(Transform NGNHNPHIJOK, LEMFDNDBDJC BDNPFHIBMNH, OutfitType? KAMFIEKLGNP, bool PCLFIDOGJOJ, Matrix4x4 HKLGJJKHJMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x7A81950", Offset = "0x7A7FF50", VA = "0x187A81950")]
	public int KACNIOBLKLI(HBCCCBHLICH OEHHKNIGGMI, bool AOJFJFFJEBO, [Optional] OutfitType? KAMFIEKLGNP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x7A81710", Offset = "0x7A7FD10", VA = "0x187A81710")]
	public int CLBEDMCKMFI(LEMFDNDBDJC BDNPFHIBMNH, [Optional] OutfitType? KAMFIEKLGNP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7A81620", Offset = "0x7A7FC20", VA = "0x187A81620")]
	public void ACNFOIHPKMB(HBCCCBHLICH OEHHKNIGGMI, Matrix4x4 DBIOLKCJDPL, bool AOJFJFFJEBO = false, [Optional] OutfitType? KAMFIEKLGNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x7A81810", Offset = "0x7A7FE10", VA = "0x187A81810")]
	public Matrix4x4 DICFOKHOOFM(HBCCCBHLICH OEHHKNIGGMI, bool AOJFJFFJEBO, [Optional] OutfitType? KAMFIEKLGNP)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x132AFB0", Offset = "0x13295B0", VA = "0x18132AFB0")]
	public void BAJDMPAKPAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x7A82240", Offset = "0x7A80840", VA = "0x187A82240")]
	public GKAFCBDLFII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct HBCCCBHLICH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public readonly string JEJBACCKIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public readonly LEMFDNDBDJC IFCMMFOJBML;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public readonly OutfitType? HDBKMDGNHHJ;

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x7A82B20", Offset = "0x7A81120", VA = "0x187A82B20")]
	public HBCCCBHLICH(string HFLPGENJMGG, LEMFDNDBDJC BDNPFHIBMNH, [Optional] OutfitType? KAMFIEKLGNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x7A82A70", Offset = "0x7A81070", VA = "0x187A82A70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x7A829B0", Offset = "0x7A80FB0", VA = "0x187A829B0")]
	public bool NJNJIHOCGFM(HBCCCBHLICH MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x7A828A0", Offset = "0x7A80EA0", VA = "0x187A828A0", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x7A82940", Offset = "0x7A80F40", VA = "0x187A82940", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct PNLFNLOCNLC : IEquatable<PNLFNLOCNLC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public readonly LEMFDNDBDJC IFCMMFOJBML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public readonly OutfitType? MCFHPCEKJJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public readonly int MOENHOFKKPG;

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x7A88DA0", Offset = "0x7A873A0", VA = "0x187A88DA0")]
	public PNLFNLOCNLC(LEMFDNDBDJC BDNPFHIBMNH, int NMBCFKFFHJM, [Optional] OutfitType? BOKCMDJOODF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x7A88CD0", Offset = "0x7A872D0", VA = "0x187A88CD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x6CDD2D0", Offset = "0x6CDB8D0", VA = "0x186CDD2D0")]
	public bool JLMBFOAHFIK(LEMFDNDBDJC BDNPFHIBMNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x7A88AC0", Offset = "0x7A870C0", VA = "0x187A88AC0")]
	public bool APECIMBJJOP(OutfitType? BOKCMDJOODF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x7A88C30", Offset = "0x7A87230", VA = "0x187A88C30", Slot = "4")]
	public bool Equals(PNLFNLOCNLC MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x7A88B40", Offset = "0x7A87140", VA = "0x187A88B40", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x7A88C80", Offset = "0x7A87280", VA = "0x187A88C80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct MHJEJAKECKD : IEquatable<MHJEJAKECKD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public readonly Transform JDEHADDKJBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public readonly bool AKPKHFOOJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public readonly LEMFDNDBDJC LNELLOCHKJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public readonly OutfitType? HDBKMDGNHHJ;

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x7A843B0", Offset = "0x7A829B0", VA = "0x187A843B0")]
	public MHJEJAKECKD(Transform NGNHNPHIJOK, bool AHBNMILFECC, LEMFDNDBDJC JAEENGJBIPN, [Optional] OutfitType? AOMDFBDKEIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x7A841A0", Offset = "0x7A827A0", VA = "0x187A841A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x7A83F40", Offset = "0x7A82540", VA = "0x187A83F40", Slot = "4")]
	public bool Equals(MHJEJAKECKD MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x7A84040", Offset = "0x7A82640", VA = "0x187A84040", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x7A84120", Offset = "0x7A82720", VA = "0x187A84120", Slot = "2")]
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
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public const float DEFAULT_Y_POSITION_OFFSET = 0.04f;

		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public const float MAX_HEMISPHERE_POSITION_OFFSET = 0.05f;

		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public const float MAX_HEMISPHERE_ROTATION_OFFSET = 45f;

		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public const float MAX_HEMISPHERE_SCALE = 2f;

		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public const float MIN_HEMISPHERE_SCALE = 0.75f;

		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public const float MAX_HEMISPHERE_RADIUS = 0.25f;

		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public const float MIN_HEMISPHERE_RADIUS = 0.125f;

		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public static GameObject ContainerGO;

		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public static GameObject CurrentHairHemisphereGO;

		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public static Transform CurrentHairHemisphereMeshTransform;

		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public static FitMeshHemisphereUpdater CurrentHairHemisphereUpdater;

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x7A80ED0", Offset = "0x7A7F4D0", VA = "0x187A80ED0")]
		public static void DespawnHairHemisphere()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public void UpdateValues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x9EA210", Offset = "0x9E8810", VA = "0x1809EA210")]
		public FitMeshHemisphereUpdater()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface GLFHFBMHEFL
{
	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GKAHHFADIKG(Mesh PEPFHNJFNIL, Matrix4x4 GBOHAMAACHL, byte[] AHOGHGIIKDO, bool COHLFCDAJAJ = false, DJMKKMKOHOE.KHMINOCKMDE FHNEEDJLIKD = (DJMKKMKOHOE.KHMINOCKMDE)0L, int ACGKBLDNMLK = -1, bool DLDPOELFKGB = false);

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EKELMPDKPON(Allocator NDFENJBGNOB, EONPPOBGAOL BEBBIOKLEJJ, byte GGNNMGDCEED, [Optional] IList<int> IGEECJJEHIN, [Optional] IList<int> LKLIOGJGKMJ);
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public readonly struct HAJFBGNLPCB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public readonly GameObject CFDBIKMCOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	private readonly AvatarItemMaterial JFBDMNNMAPP;

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0xABB7D0", Offset = "0xAB9DD0", VA = "0x180ABB7D0")]
	public HAJFBGNLPCB(GameObject CFDBIKMCOBM, AvatarItemMaterial JFBDMNNMAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x7A82810", Offset = "0x7A80E10", VA = "0x187A82810")]
	public void NAFGJNNKKMA(Material CANJBFKPEMF, int KMLNOHKPNFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class GIBFJIMDLBM : GFMCNLLODOK<Task<(GameObject, AvatarItemMaterial)>, HAJFBGNLPCB>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct HGIFAFIKEPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public AsyncTaskMethodBuilder<(GameObject, AvatarItemMaterial)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public Task<GameObject> goTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public Task<AvatarItemMaterial> materialTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		private GameObject <go>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		private TaskAwaiter<GameObject> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		private TaskAwaiter<AvatarItemMaterial> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x7A839D0", Offset = "0x7A81FD0", VA = "0x187A839D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x7A83ED0", Offset = "0x7A824D0", VA = "0x187A83ED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	private GKHPBLLBAIL<GameObject> MHHEDEBBMCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	private GKHPBLLBAIL<AvatarItemMaterial> FCKOBBCAMLD;

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x7A81590", Offset = "0x7A7FB90", VA = "0x187A81590")]
	private GIBFJIMDLBM(Task<(GameObject, AvatarItemMaterial)> BGKKDAHMDLM, GKHPBLLBAIL<GameObject> NEAKMOEKCBI, GKHPBLLBAIL<AvatarItemMaterial> JDEOMEJOMDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x7A80F30", Offset = "0x7A7F530", VA = "0x187A80F30")]
	public static GIBFJIMDLBM FLLMCNLHKNL(AssetReference IICOGDKMOMF, [Optional] AssetReference JKICLJFOHJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x7A81340", Offset = "0x7A7F940", VA = "0x187A81340", Slot = "11")]
	protected override HAJFBGNLPCB JJMIGMFGBMB(Task<(GameObject, AvatarItemMaterial)> KBOFPPNJEHF)
	{
		return default(HAJFBGNLPCB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x7A81510", Offset = "0x7A7FB10", VA = "0x187A81510", Slot = "12")]
	protected override void OAEBBEFCKCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x7A813E0", Offset = "0x7A7F9E0", VA = "0x187A813E0")]
	[AsyncStateMachine(typeof(HGIFAFIKEPM))]
	private static Task<(GameObject, AvatarItemMaterial)> NACPCOLOIOB(Task<GameObject> FONKIMOAHPA, Task<AvatarItemMaterial> DLJIEFJMKAH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class MMBHIJGFIKL
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class ENJHKNGFBGA : GFMCNLLODOK<Task<MaterialMapAsset>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private GKHPBLLBAIL<MaterialMapAsset> BOJCEMEJOMP;

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x7A800B0", Offset = "0x7A7E6B0", VA = "0x187A800B0")]
		public ENJHKNGFBGA(GKHPBLLBAIL<MaterialMapAsset> BOJCEMEJOMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x7A7FC30", Offset = "0x7A7E230", VA = "0x187A7FC30", Slot = "11")]
		protected override Material[] JJMIGMFGBMB(Task<MaterialMapAsset> BGKKDAHMDLM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x7A80050", Offset = "0x7A7E650", VA = "0x187A80050", Slot = "12")]
		protected override void OAEBBEFCKCM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class AIBDOGOJPLO : GFMCNLLODOK<Task<Material[]>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private List<GKHPBLLBAIL<Material>> LPJEPOMELAF;

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x7A76460", Offset = "0x7A74A60", VA = "0x187A76460")]
		public AIBDOGOJPLO(Task<Material[]> BGKKDAHMDLM, List<GKHPBLLBAIL<Material>> LPJEPOMELAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x7A762D0", Offset = "0x7A748D0", VA = "0x187A762D0", Slot = "11")]
		protected override Material[] JJMIGMFGBMB(Task<Material[]> KBOFPPNJEHF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x7A76320", Offset = "0x7A74920", VA = "0x187A76320", Slot = "12")]
		protected override void OAEBBEFCKCM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	private static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x7A84400", Offset = "0x7A82A00", VA = "0x187A84400")]
	public static GKHPBLLBAIL<Material[]> JMFFOGKIKLN(AssetReference[] MACBJAJPPKH)
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
		public enum IBAFKCJOEOA
		{
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000341")]
			TeamItem,
			[Cpp2IlInjected.Token(Token = "0x4000342")]
			SkinColor,
			[Cpp2IlInjected.Token(Token = "0x4000343")]
			HairColor,
			[Cpp2IlInjected.Token(Token = "0x4000344")]
			BeardColor,
			[Cpp2IlInjected.Token(Token = "0x4000345")]
			UGCShirtColor
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public enum NNMEKCBBIJP
		{
			[Cpp2IlInjected.Token(Token = "0x4000347")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000348")]
			HairTexture,
			[Cpp2IlInjected.Token(Token = "0x4000349")]
			BeardTexture,
			[Cpp2IlInjected.Token(Token = "0x400034A")]
			UGCShirtTexture
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public enum NMOIBHCNNGG : byte
		{
			[Cpp2IlInjected.Token(Token = "0x400034C")]
			All,
			[Cpp2IlInjected.Token(Token = "0x400034D")]
			LOD0Only,
			[Cpp2IlInjected.Token(Token = "0x400034E")]
			EditorToolAll
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		public struct DAACLJKOJBJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400034F")]
			public readonly Material FNLBLGEDCDN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000350")]
			public readonly IBAFKCJOEOA BKAEHKCCAPD;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000351")]
			public readonly NNMEKCBBIJP FNBHMEMNEPE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000352")]
			public readonly LEMFDNDBDJC IFCMMFOJBML;

			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x7A827D0", Offset = "0x7A80DD0", VA = "0x187A827D0")]
			public DAACLJKOJBJ(Material CANJBFKPEMF, IBAFKCJOEOA GMLOOFHADHO, NNMEKCBBIJP PGOOBBKNDOF, LEMFDNDBDJC BDNPFHIBMNH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x7A980F0", Offset = "0x7A966F0", VA = "0x187A980F0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x7A823B0", Offset = "0x7A809B0", VA = "0x187A823B0")]
			public bool NJNJIHOCGFM(DAACLJKOJBJ MIJLJBIHDMP)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x7A97F70", Offset = "0x7A96570", VA = "0x187A97F70", Slot = "0")]
			public override bool Equals(object BOMDCGFKGKF)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x7A98050", Offset = "0x7A96650", VA = "0x187A98050", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		protected class BBOCIFIGBHP : IComparable<BBOCIFIGBHP>, IEquatable<BBOCIFIGBHP>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000353")]
			public int DHLNJJDKAFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000354")]
			public PlayerAvatarDisplayBase JJNMHFCAPPI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000355")]
			public IList<EMNJOPNCDMC> IMGNGICNHLI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000356")]
			public AvatarItemBodyType AEDAMHBBOFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000357")]
			public JICFHOJONOI AHIIALKIOOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000358")]
			public bool PKOMNKDJGAD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000359")]
			public int[] KIOKNKHEIMB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400035A")]
			public float MHNIDGOLKKJ;

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x7A97E20", Offset = "0x7A96420", VA = "0x187A97E20", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x7A97CD0", Offset = "0x7A962D0", VA = "0x187A97CD0", Slot = "4")]
			public int CompareTo(BBOCIFIGBHP MIJLJBIHDMP)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x7A97D00", Offset = "0x7A96300", VA = "0x187A97D00", Slot = "5")]
			public bool Equals(BBOCIFIGBHP MIJLJBIHDMP)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public BBOCIFIGBHP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		protected abstract class GDNBCAAJINI
		{
			[Cpp2IlInjected.Token(Token = "0x200005B")]
			public class DJANBEJOIHO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400035E")]
				public readonly Mesh FHOGKLAGICP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400035F")]
				public readonly Material[] EILAPPHKHIB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000360")]
				public readonly Transform[] KAADIMKDEBH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000361")]
				public readonly Matrix4x4[] DMADKIFECCD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000362")]
				public readonly Transform BBOEGCDDHHN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000363")]
				public readonly bool OEAPIIDJMIH;

				[Cpp2IlInjected.Token(Token = "0x60002FE")]
				[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
				protected DJANBEJOIHO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002FF")]
				[Cpp2IlInjected.Address(RVA = "0x7A98700", Offset = "0x7A96D00", VA = "0x187A98700")]
				public DJANBEJOIHO(Mesh PEPFHNJFNIL, Material[] KDFCLGAFNHL, bool FCIFGNMGKMM, Transform[] IFACPDBOEIA, Transform IAOCGEGAPKO, Matrix4x4[] FKEHAENBMII)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000300")]
				[Cpp2IlInjected.Address(RVA = "0x7A98640", Offset = "0x7A96C40", VA = "0x187A98640")]
				private DJANBEJOIHO(SkinnedMeshRenderer KMAINCIGCMG, Material[] KHMKOLBHGEN)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000301")]
				[Cpp2IlInjected.Address(RVA = "0x7A98BB0", Offset = "0x7A971B0", VA = "0x187A98BB0")]
				private DJANBEJOIHO(MeshRenderer NHJJDLPOEGL, Transform IAOCGEGAPKO, Material[] KHMKOLBHGEN)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000302")]
				[Cpp2IlInjected.Address(RVA = "0x7A98310", Offset = "0x7A96910", VA = "0x187A98310")]
				public static DJANBEJOIHO GKIPFIPICAH(Renderer CCKFDFMBDLN, Material[] KHMKOLBHGEN)
				{
					return null;
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400035B")]
			public readonly LEMFDNDBDJC IFCMMFOJBML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400035C")]
			public readonly Transform EJFHFFMPDKH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400035D")]
			public readonly bool NOCFBPFMPIK;

			[Cpp2IlInjected.Token(Token = "0x1700008D")]
			public virtual bool FONOBOLGJOE
			{
				[Cpp2IlInjected.Token(Token = "0x60002F7")]
				[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008E")]
			public virtual bool AGMHOCMMNLI
			{
				[Cpp2IlInjected.Token(Token = "0x60002F8")]
				[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008F")]
			public virtual DJMKKMKOHOE.KHMINOCKMDE CHNHHCCDPAN
			{
				[Cpp2IlInjected.Token(Token = "0x60002F9")]
				[Cpp2IlInjected.Address(RVA = "0x9EA230", Offset = "0x9E8830", VA = "0x1809EA230", Slot = "6")]
				get
				{
					return default(DJMKKMKOHOE.KHMINOCKMDE);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000090")]
			public bool PJHKDJOGIAN
			{
				[Cpp2IlInjected.Token(Token = "0x60002FA")]
				[Cpp2IlInjected.Address(RVA = "0x7A9D330", Offset = "0x7A9B930", VA = "0x187A9D330")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x7A9D340", Offset = "0x7A9B940", VA = "0x187A9D340")]
			protected GDNBCAAJINI(LEMFDNDBDJC BDNPFHIBMNH, Transform OGJFOPFMFCO, bool JCJJCHMGOCK = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract HPIGCMLNLFB LKGBAHIGMNB(List<KBJDIMPKBHI> MKIPMDAKLBD, List<KBJDIMPKBHI> BBGGIAKGEEL);

			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract DJANBEJOIHO LEBDIAJMBFP(int GKGMDAMJCNF, PlayerHandBones AMCJMGNBBHF);
		}

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		protected class OGMCCMMPOPH : GDNBCAAJINI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000364")]
			protected readonly BodyPartLODs FCNPHNMCNLK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000365")]
			protected readonly Material[] ADHMBFMPJBP;

			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x7A9F3B0", Offset = "0x7A9D9B0", VA = "0x187A9F3B0")]
			public OGMCCMMPOPH(LEMFDNDBDJC BDNPFHIBMNH, BodyPartLODs FBDONGLADBG, Material JKOIHDOGJBL, [Optional] Transform OGJFOPFMFCO, bool JCJJCHMGOCK = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x7A9F2B0", Offset = "0x7A9D8B0", VA = "0x187A9F2B0", Slot = "7")]
			public override HPIGCMLNLFB LKGBAHIGMNB(List<KBJDIMPKBHI> MKIPMDAKLBD, List<KBJDIMPKBHI> BBGGIAKGEEL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0x7A9F0F0", Offset = "0x7A9D6F0", VA = "0x187A9F0F0", Slot = "8")]
			public override DJANBEJOIHO LEBDIAJMBFP(int GKGMDAMJCNF, PlayerHandBones AMCJMGNBBHF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000306")]
			[Cpp2IlInjected.Address(RVA = "0x7A9F340", Offset = "0x7A9D940", VA = "0x187A9F340", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005D")]
		protected class KBMEBDAENDC : GDNBCAAJINI
		{
			[Cpp2IlInjected.Token(Token = "0x17000091")]
			public override bool FONOBOLGJOE
			{
				[Cpp2IlInjected.Token(Token = "0x6000307")]
				[Cpp2IlInjected.Address(RVA = "0xA05830", Offset = "0xA03E30", VA = "0x180A05830", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000092")]
			public override bool AGMHOCMMNLI
			{
				[Cpp2IlInjected.Token(Token = "0x6000308")]
				[Cpp2IlInjected.Address(RVA = "0x7A9D3A0", Offset = "0x7A9B9A0", VA = "0x187A9D3A0", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000093")]
			public CKKEFOLDDDM GBHHDDAPDIC
			{
				[Cpp2IlInjected.Token(Token = "0x6000309")]
				[Cpp2IlInjected.Address(RVA = "0x9EB550", Offset = "0x9E9B50", VA = "0x1809EB550")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600030A")]
				[Cpp2IlInjected.Address(RVA = "0x9EFA10", Offset = "0x9EE010", VA = "0x1809EFA10")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0x7A9D4F0", Offset = "0x7A9BAF0", VA = "0x187A9D4F0")]
			public KBMEBDAENDC(LEMFDNDBDJC BDNPFHIBMNH, Transform OGJFOPFMFCO, CKKEFOLDDDM NPDKKINBDDF, bool JCJJCHMGOCK = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0x7A9D3F0", Offset = "0x7A9B9F0", VA = "0x187A9D3F0", Slot = "7")]
			public override HPIGCMLNLFB LKGBAHIGMNB(List<KBJDIMPKBHI> MKIPMDAKLBD, List<KBJDIMPKBHI> BBGGIAKGEEL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x9EA230", Offset = "0x9E8830", VA = "0x1809EA230", Slot = "8")]
			public override DJANBEJOIHO LEBDIAJMBFP(int GKGMDAMJCNF, PlayerHandBones AMCJMGNBBHF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x7A9D480", Offset = "0x7A9BA80", VA = "0x187A9D480", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005E")]
		public class GBHBDCHAKAB
		{
			[Cpp2IlInjected.Token(Token = "0x200005F")]
			public enum AABNHAOHPIF
			{
				[Cpp2IlInjected.Token(Token = "0x4000377")]
				PLAYER_PUPPET,
				[Cpp2IlInjected.Token(Token = "0x4000378")]
				PLAYER_DISPLAY_POSER,
				[Cpp2IlInjected.Token(Token = "0x4000379")]
				PLAYER_HAND,
				[Cpp2IlInjected.Token(Token = "0x400037A")]
				STNMONSTERCOSTUME_OPTION_HIDE_EXCEPT_UI,
				[Cpp2IlInjected.Token(Token = "0x400037B")]
				PLAYER_HAND_POINTING,
				[Cpp2IlInjected.Token(Token = "0x400037C")]
				STNMONSTERCOSTUME_OPTION_ALWAYS_HIDE,
				[Cpp2IlInjected.Token(Token = "0x400037D")]
				EDITOR
			}

			[Cpp2IlInjected.Token(Token = "0x4000367")]
			public static readonly int NHIIHMBKJCN;

			[Cpp2IlInjected.Token(Token = "0x4000368")]
			public static readonly int DJLEPMNELJC;

			[Cpp2IlInjected.Token(Token = "0x4000369")]
			public static readonly int LJCCJAKLOAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400036A")]
			protected readonly ECEPGPDPDKI LKCJMGGAGMB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400036B")]
			protected readonly BELFFFDFKLH IHLPOFPAKDN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400036C")]
			protected readonly Animator ONNIEABMGBG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400036D")]
			protected readonly Transform MNLNCALALAP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400036E")]
			protected readonly Vector3 KMIJABPLEIA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400036F")]
			protected readonly Transform AHKIHBGCMLD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000370")]
			protected readonly Vector3 NNGKFDBEDCL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000371")]
			protected bool MBLMHJLBENI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000372")]
			protected EKFIOJKBHPO FMGBNAOBIOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000373")]
			protected bool DHBDCCHCLFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x4000374")]
			protected float IEMFALAFBDE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000375")]
			protected LBBJFFOLGFF<ACKOLLANMDJ> OEMGGDMODNM;

			[Cpp2IlInjected.Token(Token = "0x17000094")]
			public EKFIOJKBHPO DEDOKBIIEBL
			{
				[Cpp2IlInjected.Token(Token = "0x600030F")]
				[Cpp2IlInjected.Address(RVA = "0x9EE700", Offset = "0x9ECD00", VA = "0x1809EE700")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000310")]
				[Cpp2IlInjected.Address(RVA = "0x9EE6C0", Offset = "0x9ECCC0", VA = "0x1809EE6C0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000095")]
			public bool BPDHJLGHAGA
			{
				[Cpp2IlInjected.Token(Token = "0x6000311")]
				[Cpp2IlInjected.Address(RVA = "0xC0A3E0", Offset = "0xC089E0", VA = "0x180C0A3E0")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000312")]
				[Cpp2IlInjected.Address(RVA = "0x7A9C260", Offset = "0x7A9A860", VA = "0x187A9C260")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000096")]
			public bool GOCLHNPOCMA
			{
				[Cpp2IlInjected.Token(Token = "0x6000313")]
				[Cpp2IlInjected.Address(RVA = "0x9F4CA0", Offset = "0x9F32A0", VA = "0x1809F4CA0")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000314")]
				[Cpp2IlInjected.Address(RVA = "0x7A9C330", Offset = "0x7A9A930", VA = "0x187A9C330")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000097")]
			public float ELGCCLKIILN
			{
				[Cpp2IlInjected.Token(Token = "0x6000315")]
				[Cpp2IlInjected.Address(RVA = "0xC905F0", Offset = "0xC8EBF0", VA = "0x180C905F0")]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000316")]
				[Cpp2IlInjected.Address(RVA = "0x7A9CAD0", Offset = "0x7A9B0D0", VA = "0x187A9CAD0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000098")]
			public ACKOLLANMDJ FINEDPMJOBP
			{
				[Cpp2IlInjected.Token(Token = "0x6000317")]
				[Cpp2IlInjected.Address(RVA = "0x7A9C5B0", Offset = "0x7A9ABB0", VA = "0x187A9C5B0")]
				get
				{
					return default(ACKOLLANMDJ);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x7A9C850", Offset = "0x7A9AE50", VA = "0x187A9C850")]
			public bool KEJPKCHIMHE(ACKOLLANMDJ FNMJJEKIDLE, object EJJDDFFADPC, AABNHAOHPIF DPEJEDCKJBD)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0x7A9C4B0", Offset = "0x7A9AAB0", VA = "0x187A9C4B0")]
			public bool CPJCEMHDELM(object EJJDDFFADPC)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0x7A9CCB0", Offset = "0x7A9B2B0", VA = "0x187A9CCB0")]
			protected GBHBDCHAKAB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x7A9CD40", Offset = "0x7A9B340", VA = "0x187A9CD40")]
			public GBHBDCHAKAB(ECEPGPDPDKI LKCJMGGAGMB, EKFIOJKBHPO EJODGNCGFLE, Animator ONNIEABMGBG, Transform MNLNCALALAP, Transform AHKIHBGCMLD, Vector3 KMIJABPLEIA, Vector3 NNGKFDBEDCL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x7A9C400", Offset = "0x7A9AA00", VA = "0x187A9C400")]
			private void COFEPPECBEP(ushort KPBBLBKEMIC, ushort HBFAAELLBGE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x7A9C5F0", Offset = "0x7A9ABF0", VA = "0x187A9C5F0")]
			protected void FEPCNPOHBOO(ushort KPBBLBKEMIC, ushort HBFAAELLBGE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x7A9C960", Offset = "0x7A9AF60", VA = "0x187A9C960")]
			protected void OIAKBNCDKDP(ushort KPBBLBKEMIC, ushort HBFAAELLBGE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x7A9C140", Offset = "0x7A9A740", VA = "0x187A9C140")]
			protected void BGFBOANDFLN(ushort KPBBLBKEMIC, ushort HBFAAELLBGE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x7A9C030", Offset = "0x7A9A630", VA = "0x187A9C030")]
			protected void ANIDNENDAEI(ushort KPBBLBKEMIC, ushort HBFAAELLBGE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x7A9CA70", Offset = "0x7A9B070", VA = "0x187A9CA70")]
			protected void PGOCJCNJEFL(ushort KPBBLBKEMIC, ushort HBFAAELLBGE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x7A9CA20", Offset = "0x7A9B020", VA = "0x187A9CA20")]
			protected void PAIGLPHCMDB(ushort KPBBLBKEMIC, ushort HBFAAELLBGE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x7A9C800", Offset = "0x7A9AE00", VA = "0x187A9C800")]
			protected void KBKHBGMLADF(ushort KPBBLBKEMIC, ushort HBFAAELLBGE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x7A9C6E0", Offset = "0x7A9ACE0", VA = "0x187A9C6E0")]
			protected void HHMCIAMLDJK(ushort KPBBLBKEMIC, ushort HBFAAELLBGE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000060")]
		public class DNOBIKFHBLF : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x400037E")]
			public const int IJDEJBCFGDH = 16;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400037F")]
			protected MaterialPropertyBlock FHJBEKLNOIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000380")]
			public Color? KKNAKKAEGIG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000381")]
			public Color? CIANNEIDAAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000382")]
			public Color? GFMAIPOMMOC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000383")]
			public Color JIPGBOFPJKE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x4000384")]
			public Color BCLIKDAECBK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x4000385")]
			public Color HBBFGFAMEGL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000386")]
			public Texture2D MDLNPPNJNHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000387")]
			public Texture2D FIGMALLLLIF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x4000388")]
			protected Dictionary<DAACLJKOJBJ, int> LGPLODMABGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x4000389")]
			protected IBAFKCJOEOA[] BDBFLMBDBJK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x400038A")]
			public Vector4[] JPGNJBKOJAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x400038B")]
			public Vector4[] MKAHLKIOKKD;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x400038C")]
			public Vector4[] ONDIMBFLFCN;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400038D")]
			public Vector4[] GEJPNHNNGDB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x400038E")]
			public Vector4[] CFCBPLMPOJD;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			public Vector4[] KHOJIJJBIKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000390")]
			protected List<Texture2D> FNFNEIKOCII;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000391")]
			protected Vector4[] JCJEGIAILNJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
			[Cpp2IlInjected.Token(Token = "0x4000392")]
			protected List<Texture2D> DCNJNLGAKPH;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
			[Cpp2IlInjected.Token(Token = "0x4000393")]
			protected float[] GHLPFEFMGLA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
			[Cpp2IlInjected.Token(Token = "0x4000394")]
			protected Vector4[] KHIHCCMGENO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x4000395")]
			protected float[] NPGGOFMHIJM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
			[Cpp2IlInjected.Token(Token = "0x4000396")]
			public float[] GIFAANIMJGG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
			[Cpp2IlInjected.Token(Token = "0x4000397")]
			protected List<Texture2D> GINLIKAOMPB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
			[Cpp2IlInjected.Token(Token = "0x4000398")]
			protected float[] FJLGCABMEFB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
			[Cpp2IlInjected.Token(Token = "0x4000399")]
			protected List<Texture2D> KKBKNABELAH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
			[Cpp2IlInjected.Token(Token = "0x400039A")]
			protected Vector4[] NPKIMGGPLII;

			[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
			[Cpp2IlInjected.Token(Token = "0x400039B")]
			protected float[] KCCINMAOMII;

			[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			protected Vector4[] FBHJHFBGJIG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x400039D")]
			public float[] BAGAFAIFKKJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
			[Cpp2IlInjected.Token(Token = "0x400039E")]
			public Texture2DArray LPAAPNDFAGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x400039F")]
			public Texture2DArray LDKLKEPMPOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
			[Cpp2IlInjected.Token(Token = "0x40003A0")]
			public Texture2DArray IJPLODGLPHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
			[Cpp2IlInjected.Token(Token = "0x40003A1")]
			public Texture2DArray PHHAKOHADLH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x40003A2")]
			protected bool GGOEHDGAGFD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
			[Cpp2IlInjected.Token(Token = "0x40003A3")]
			protected int JBGMFGMAFPA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
			[Cpp2IlInjected.Token(Token = "0x40003A4")]
			protected Vector2? AKGNJFDOMBF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
			[Cpp2IlInjected.Token(Token = "0x40003A5")]
			protected TextureFormat BLPAAKGPDIO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
			[Cpp2IlInjected.Token(Token = "0x40003A6")]
			protected Vector2? EHHEDLILGNK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
			[Cpp2IlInjected.Token(Token = "0x40003A7")]
			protected TextureFormat AGAOMJDKGPB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
			[Cpp2IlInjected.Token(Token = "0x40003A8")]
			protected Vector2? HBNLBDPDODL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
			[Cpp2IlInjected.Token(Token = "0x40003A9")]
			protected TextureFormat CGLPDKOMBPN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
			[Cpp2IlInjected.Token(Token = "0x40003AA")]
			protected Vector2? JAINKCEEJED;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
			[Cpp2IlInjected.Token(Token = "0x40003AB")]
			protected TextureFormat NAENFMFPCOO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
			[Cpp2IlInjected.Token(Token = "0x40003AC")]
			protected bool CIAFEFCBLPC;

			[Cpp2IlInjected.Token(Token = "0x40003AD")]
			protected static int JEPOFHHIKDD;

			[Cpp2IlInjected.Token(Token = "0x40003AE")]
			protected static int FFGAEADGFKA;

			[Cpp2IlInjected.Token(Token = "0x40003AF")]
			protected static int FOLKBAOILNN;

			[Cpp2IlInjected.Token(Token = "0x40003B0")]
			protected static int JALPLCEEJLB;

			[Cpp2IlInjected.Token(Token = "0x40003B1")]
			protected static int KLLAILCEFGF;

			[Cpp2IlInjected.Token(Token = "0x40003B2")]
			protected static int MCJBEIMFHJK;

			[Cpp2IlInjected.Token(Token = "0x40003B3")]
			protected static int CPJAHIIKPHO;

			[Cpp2IlInjected.Token(Token = "0x40003B4")]
			protected static int MEPCFOIFIPH;

			[Cpp2IlInjected.Token(Token = "0x40003B5")]
			protected static int KIHEGEMHAPJ;

			[Cpp2IlInjected.Token(Token = "0x40003B6")]
			protected static int PIOENPMIFAO;

			[Cpp2IlInjected.Token(Token = "0x40003B7")]
			protected static int GJKPPCEFLHJ;

			[Cpp2IlInjected.Token(Token = "0x40003B8")]
			protected static int BEJABIKAHIC;

			[Cpp2IlInjected.Token(Token = "0x40003B9")]
			protected static int NEHLPBDHIDG;

			[Cpp2IlInjected.Token(Token = "0x40003BA")]
			protected static int PCDOOMCEBIH;

			[Cpp2IlInjected.Token(Token = "0x40003BB")]
			protected static int DGENLFJKLOJ;

			[Cpp2IlInjected.Token(Token = "0x40003BC")]
			protected static int DELINIDPAHL;

			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			protected static int FHDHOCAINGL;

			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			protected static int LLBCPPKHJIM;

			[Cpp2IlInjected.Token(Token = "0x40003BF")]
			protected static int JGFDHCEEAOE;

			[Cpp2IlInjected.Token(Token = "0x40003C0")]
			protected static int ALODDBNCMFI;

			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x7A9B4A0", Offset = "0x7A99AA0", VA = "0x187A9B4A0")]
			protected DNOBIKFHBLF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x7A9B410", Offset = "0x7A99A10", VA = "0x187A9B410")]
			public DNOBIKFHBLF(Color HOKBFOFIGDG, Color IAGHPLIANOJ, Color ABOLANAFPPL, Color? JDPPHLLCPEO, Color? MOPPNOHCOMC, Color? CDCECCBAMKD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x7A98F30", Offset = "0x7A97530", VA = "0x187A98F30")]
			public int CNJDCFDGLMF(Material BAJKNHFGJJI, IBAFKCJOEOA GMLOOFHADHO, NNMEKCBBIJP PGOOBBKNDOF, LEMFDNDBDJC BDNPFHIBMNH)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x7A99020", Offset = "0x7A97620", VA = "0x187A99020")]
			public int CNJDCFDGLMF(DAACLJKOJBJ OEHHKNIGGMI)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x7A992E0", Offset = "0x7A978E0", VA = "0x187A992E0")]
			public int GOGANAFBLKG(Material BAJKNHFGJJI, Color BCJBJCJEEOB, Color DENCMJLNDEA, Color GNOGEJFGEHI, Color EMEEOLPKGGL, Color MEAICLBLNAP, Texture2D FBBOIOEBNGH, Vector4 LOFGABLDGHM, Texture2D DAHLDLNOCME, Vector4 LBDAHPLCDDC, float GMHCCLLJIFJ, float KAICNIDJOJG, Texture2D DBDDDEKIGBM, Vector4 ADHIKGJFAME, float EEKJGFDCJEG, Texture2D FGNNMCDGMKK, float BAHPONNGANN, Color MOIBEGCKKBB, Vector4 DJEDIOJLPIK, IBAFKCJOEOA GMLOOFHADHO, NNMEKCBBIJP PGOOBBKNDOF, LEMFDNDBDJC BDNPFHIBMNH)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x7A9AD20", Offset = "0x7A99320", VA = "0x187A9AD20")]
			protected void KPFPDMEMEAG([Out] Texture2DArray EFDPLBHEFAA, [Out] Texture2DArray CMIGHGEHPCB, [Out] Texture2DArray IBFEMALCFAE, [Out] Texture2DArray ABNGOBMBIHG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x7A99FD0", Offset = "0x7A985D0", VA = "0x187A99FD0")]
			public void HPJNJIJIJLF(PlayerAvatarDisplayBase JBDLPFCPPOM, Renderer CCKFDFMBDLN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x7A9A230", Offset = "0x7A98830", VA = "0x187A9A230")]
			protected void ICNGOPDCFED(PlayerAvatarDisplayBase JBDLPFCPPOM, Renderer CCKFDFMBDLN, int GBGAFEDFAJB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x7A990B0", Offset = "0x7A976B0", VA = "0x187A990B0")]
			private Color DDCNNEECBOG(Color IMAFKGFPPAB, IBAFKCJOEOA FKAIEBDGNCN)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x7A9AF70", Offset = "0x7A99570", VA = "0x187A9AF70")]
			private Color MMIPNIGOFPK(Color AJNJDEBHJIG, IBAFKCJOEOA FKAIEBDGNCN)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x7A9AEE0", Offset = "0x7A994E0", VA = "0x187A9AEE0")]
			protected void LIEDJNDHOEE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x7A992A0", Offset = "0x7A978A0", VA = "0x187A992A0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000061")]
		public struct PlayerHandBones
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			public Transform[] LeftHandBones;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003C2")]
			public Transform LeftHandRoot;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003C3")]
			public Transform[] RightHandBones;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003C4")]
			public Transform RightHandRoot;

			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(RVA = "0x7AA67D0", Offset = "0x7AA4DD0", VA = "0x187AA67D0")]
			public void EHKOLIDBMHA(LEMFDNDBDJC BDNPFHIBMNH, [Out] Transform KNNDNAPJIDP, [Out] Transform[] IFACPDBOEIA)
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		protected struct BodyPartLODs
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003C5")]
			public Mesh[] LODs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003C6")]
			public bool UseHandBones;
		}

		[Cpp2IlInjected.Token(Token = "0x2000064")]
		[CompilerGenerated]
		private sealed class LJKKABCBPLB : IEnumerable<SkinnedMeshRenderer>, IEnumerable, IEnumerator<SkinnedMeshRenderer>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003CE")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003CF")]
			private SkinnedMeshRenderer <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003D0")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003D1")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003D2")]
			private SkinnedMeshRenderer[] <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003D3")]
			private int <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x17000099")]
			SkinnedMeshRenderer IEnumerator<SkinnedMeshRenderer>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600033F")]
				[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009A")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000341")]
				[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0xE9CA20", Offset = "0xE9B020", VA = "0x180E9CA20")]
			[DebuggerHidden]
			public LJKKABCBPLB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x7A9E370", Offset = "0x7A9C970", VA = "0x187A9E370", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x7A9E5F0", Offset = "0x7A9CBF0", VA = "0x187A9E5F0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x7A9E540", Offset = "0x7A9CB40", VA = "0x187A9E540", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<SkinnedMeshRenderer> IEnumerable<SkinnedMeshRenderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x7A9E540", Offset = "0x7A9CB40", VA = "0x187A9E540", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000065")]
		[CompilerGenerated]
		private sealed class MGHEJOEBBIO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003D4")]
			public PlayerAvatarDisplayBase display;

			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public MGHEJOEBBIO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0x7A9E640", Offset = "0x7A9CC40", VA = "0x187A9E640")]
			internal bool GNACENGHOJJ()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class PBJIEGHEHJF : IEnumerator<NFNODNEANBN>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003D5")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003D6")]
			private NFNODNEANBN <>2__current;

			[Cpp2IlInjected.Token(Token = "0x1700009B")]
			private NFNODNEANBN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000349")]
				[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009C")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600034B")]
				[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0x9EC8D0", Offset = "0x9EAED0", VA = "0x1809EC8D0")]
			[DebuggerHidden]
			public PBJIEGHEHJF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(RVA = "0x7A9F6B0", Offset = "0x7A9DCB0", VA = "0x187A9F6B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0x7A9F9F0", Offset = "0x7A9DFF0", VA = "0x187A9F9F0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000067")]
		[CompilerGenerated]
		private struct LAPKKJPFALF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003D8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003D9")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003DA")]
			public MAKBECHNCGC avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003DB")]
			private bool <forceRebuild>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003DC")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x7A9D810", Offset = "0x7A9BE10", VA = "0x187A9D810", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0x7A9DBB0", Offset = "0x7A9C1B0", VA = "0x187A9DBB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000068")]
		[CompilerGenerated]
		private sealed class EKPIDMHEKHG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003DD")]
			public string overrideIdentifier;

			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public EKPIDMHEKHG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0x7A9B960", Offset = "0x7A99F60", VA = "0x187A9B960")]
			internal bool ECGKHJOGDED(EMNJOPNCDMC selection)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000069")]
		[CompilerGenerated]
		private sealed class KCIDPKBHILG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003DE")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003DF")]
			public AvatarItemBodyType avatarItemBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003E0")]
			public Func<KGAPFDAFEHM<Dictionary<string, GKHPBLLBAIL<Texture2D>>>> <>9__2;

			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public KCIDPKBHILG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x7A9D5D0", Offset = "0x7A9BBD0", VA = "0x187A9D5D0")]
			internal (ALBMIKCECHI, KGAPFDAFEHM<Dictionary<string, GKHPBLLBAIL<Texture2D>>>) IAIIFBCJMKD(Dictionary<string, ALBBMKANDAF> avatarItems)
			{
				return default((ALBMIKCECHI, KGAPFDAFEHM<Dictionary<string, GKHPBLLBAIL<Texture2D>>>));
			}

			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x7A9D560", Offset = "0x7A9BB60", VA = "0x187A9D560")]
			internal KGAPFDAFEHM<Dictionary<string, GKHPBLLBAIL<Texture2D>>> AKBANKDLFPK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x7A9D7D0", Offset = "0x7A9BDD0", VA = "0x187A9D7D0")]
			internal void KCIICELOIHG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006A")]
		[CompilerGenerated]
		private sealed class PGBIELFNMGC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003E1")]
			public Transform transformToCheck;

			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public PGBIELFNMGC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0x7A9FA40", Offset = "0x7A9E040", VA = "0x187A9FA40")]
			internal bool OMHACECFEAG(SkinnedMeshRenderer x)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006B")]
		[CompilerGenerated]
		private struct LHHGGHBPNDA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003E2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003E3")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003E4")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003E5")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x7A9E140", Offset = "0x7A9C740", VA = "0x187A9E140", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0x7A9E310", Offset = "0x7A9C910", VA = "0x187A9E310", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		protected static readonly int LFCAOGDGBCF;

		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		protected static readonly int IFPHMMKBMAI;

		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		protected static readonly int LHFDEPFMMLE;

		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		protected static readonly int MDFOIADEHEK;

		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		protected static readonly int GDALFNBDFLA;

		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		protected static readonly int NEBJJGMDHAO;

		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		protected static readonly int[] EECBBBIEJGK;

		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		protected static readonly int[] OJEEFIMBPCE;

		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		protected static readonly int[] LKEPKNABEFJ;

		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		protected static readonly int[] DCFJMDGDPAJ;

		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		protected static readonly int[] NOKOCDPEOEJ;

		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		protected static readonly int[] BKELIMLBDBD;

		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		protected static List<PlayerAvatarDisplayBase> KAMEHMIEHIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		protected OJELMNHDJHH AHGOJHIKDCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		protected bool APHODKKNMPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		protected bool BKPHMFMOBOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		[SerializeField]
		public AvatarBodyShapeVault BodyShapeVault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		[SerializeField]
		public AvatarFaceShapeVault FaceShapeVault;

		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		protected static readonly int[] NOJDNENCBHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		[SerializeField]
		protected Material bodyPartMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		protected Dictionary<DAACLJKOJBJ, Material> HKDBJGOGBOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		protected Dictionary<DAACLJKOJBJ, Material> EKJOLFDKJBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		[SerializeField]
		protected bool ignorePlayerMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		[SerializeField]
		protected Transform trackingSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		[SerializeField]
		protected BodyPartLODs Head;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		[SerializeField]
		protected BodyPartLODs Ear;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		[SerializeField]
		protected BodyPartLODs Torso;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		[SerializeField]
		protected BodyPartLODs Hand;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		[SerializeField]
		protected BodyPartLODs HandPointing;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		[SerializeField]
		public PlayerHandBones HandBones;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		[SerializeField]
		public Transform remoteMeshBase;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public readonly SkinnedMeshRenderer[] CurrentDefaultSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public readonly SkinnedMeshRenderer[] NextDefaultSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public readonly SkinnedMeshRenderer[] CurrentVisibleInFirstPersonSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public readonly SkinnedMeshRenderer[] NextVisibleInFirstPersonSkinnedMeshRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		[SerializeField]
		public Transform firstPersonMeshBase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		[SerializeField]
		protected Shader uberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		[SerializeField]
		protected Shader agAvatarShader;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		protected Material PFJKIDMMJPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		protected EEFKKODIKGJ HLDDCPCMHDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		private EKFIOJKBHPO MGCOAJDDCHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		private EKFIOJKBHPO NCPPMDKMJDM;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		protected Material PBJKOGACHKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		[SerializeField]
		protected Transform headPropAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		[SerializeField]
		protected Transform hatAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		[SerializeField]
		public Transform hemisphereBase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		protected FitMeshHemisphere CPHGACAMCNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		protected bool EDGMLKOMGHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		protected HMAKLDEGKBC MJOPHNIAFAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		protected bool CFFEAMDBGMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		protected AnchorParamsRestrictions DFNIKEMKODL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		protected bool HEMHLCGCIFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		protected Transform GCAOHBMKLFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		protected bool BANGFONGFJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B1")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		protected bool LDHJILONLNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		protected Vector3 CCJKKCMOIBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		protected Quaternion IIPGOIHEKNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		protected Vector2 FMLCFFLGFIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		protected FitMeshHemisphere AHEPBELAMIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		[SerializeField]
		[ANKANEOPOFH(JINCPHMLLKA.SelfAndChildren, false, false, false)]
		protected PlayerFacialAnimatorBase facialAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		[SerializeField]
		protected Transform torsoPropAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		[SerializeField]
		protected Transform torsoRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		[SerializeField]
		protected Transform headRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		[SerializeField]
		protected Transform leftHandRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		[SerializeField]
		protected Transform leftHandDefaultScaleRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		[SerializeField]
		protected Transform rightHandRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		[SerializeField]
		protected Transform rightHandDefaultScaleRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		[SerializeField]
		protected Animator leftHandAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		[SerializeField]
		protected Animator rightHandAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		[SerializeField]
		protected Transform leftHandPointingRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		[SerializeField]
		protected Transform rightHandPointingRoot;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		protected Collider[] OCDDDLCCPEP;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		protected Collider[] MCEBECNIKEK;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		protected GBHBDCHAKAB[] LMGBEDDNFAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		[SerializeField]
		protected Mesh faceMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public Dictionary<Renderer, DNOBIKFHBLF> currentPropertyBlocks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		protected Dictionary<Renderer, DNOBIKFHBLF> AIEJIELPEKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		protected FKKJNMIPHBA GPJGGHKDAKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		protected ALBMIKCECHI DIPNFLLGAFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public MEACMOOJHJN DistanceBand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x284")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		protected int FCNENKGLAIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		protected (bool isLodForced, int forcedLOD) DHMLGECLLHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		protected LBBJFFOLGFF<BELFFFDFKLH> OEMGGDMODNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		protected bool JPJCGKKDHON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		protected Dictionary<EMNJOPNCDMC, List<DAACLJKOJBJ>> EPLBHKAHKDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		protected Dictionary<EMNJOPNCDMC, List<DAACLJKOJBJ>> IOIDOLNNMHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		protected readonly Dictionary<string, GKHPBLLBAIL<Texture2D>> KBNBLOHCPMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		protected readonly Dictionary<string, GKHPBLLBAIL<Texture2D>> HKEFNCKNMIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		protected bool LHOJALKLPIL;

		[Cpp2IlInjected.Token(Token = "0x4000319")]
		protected static int HJBLOHLBKHA;

		[Cpp2IlInjected.Token(Token = "0x400031A")]
		protected static List<BBOCIFIGBHP> GPAPFLPNLCP;

		[Cpp2IlInjected.Token(Token = "0x400031B")]
		protected static List<BBOCIFIGBHP> OGBPAEOOLNA;

		[Cpp2IlInjected.Token(Token = "0x400031C")]
		protected static OLILOOIADED NLBOBIFIGOJ;

		[Cpp2IlInjected.Token(Token = "0x400031D")]
		protected static Func<List<BBOCIFIGBHP>, BBOCIFIGBHP> GEHOEKCFJHD;

		[Cpp2IlInjected.Token(Token = "0x400031E")]
		protected static bool GMGOOCHOFAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		protected Color? EJKJNOKBEHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E4")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		protected bool JBBHHIKOIIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		protected Color IPOCBFHCDAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		protected Color IGPAGEHDJPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		protected Color IBDABKKJKNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		protected AvatarHairPattern AHIIOKJHAIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		protected CKKEFOLDDDM BJAFODBKKJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		protected Color OHLFKGIOOGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		protected Color BBDJCMHAJBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		protected AvatarHairPattern MLDNKJMPPDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		protected CKKEFOLDDDM BONEKFLIMFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		protected CKKEFOLDDDM KAOBBKOAHGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		protected Color DAAEAECKLHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		private AdditionalFeetData LMPPPEJFEPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		protected EMNJOPNCDMC? HNJDFMHFBIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		protected Texture GALENMMJOBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		protected Color HGCJOBDAACE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		protected readonly IList<EMNJOPNCDMC> KKJAOFKKOCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		protected readonly IList<EMNJOPNCDMC> DABFJEOPOLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		private AvatarItemBodyType LLHMKNNLCMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		[SerializeField]
		protected AvatarFaceShape _currentFaceShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C8")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		[SerializeField]
		protected AvatarBodyShape _currentBodyShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D0")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		[SerializeField]
		protected ABOJDNCODIG _currentNoseType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D4")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		[SerializeField]
		protected bool _hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D5")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		protected NMOIBHCNNGG JKJOHBDOKPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		protected int[] PEFNBPAMJHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E0")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		protected bool EOKOIAMAGLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E8")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		protected int[] IKLKLFPIGKK;

		[Cpp2IlInjected.Token(Token = "0x400033B")]
		private static readonly DJMKKMKOHOE.KHMINOCKMDE FFJFAMHEMFI;

		[Cpp2IlInjected.Token(Token = "0x400033C")]
		private static readonly DJMKKMKOHOE.KHMINOCKMDE AKBBFADJBFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F0")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		protected bool GNDIPGLNBGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F8")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		protected NAFFPEBCHPI PALKBJEOGPL;

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public string ADJHNEMOGHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x9EB780", Offset = "0x9E9D80", VA = "0x1809EB780")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x9EB770", Offset = "0x9E9D70", VA = "0x1809EB770")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public bool NBOCNNCLLHG
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0xC03FA0", Offset = "0xC025A0", VA = "0x180C03FA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0xC03560", Offset = "0xC01B60", VA = "0x180C03560")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public virtual bool CBCABKOBHNK
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public bool EOEIMOLOCDF
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x7A966F0", Offset = "0x7A94CF0", VA = "0x187A966F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public virtual bool PHCKAPCMLDD
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public virtual bool ILILGPBGCPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0xA05830", Offset = "0xA03E30", VA = "0x180A05830", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public virtual bool DAPKBBHDKOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public EEFKKODIKGJ PGJMAJLFKCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0xAB0900", Offset = "0xAAEF00", VA = "0x180AB0900")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x7A96EA0", Offset = "0x7A954A0", VA = "0x187A96EA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public EKFIOJKBHPO LGEIPIKACBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0xAB1E80", Offset = "0xAB0480", VA = "0x180AB1E80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x7A972A0", Offset = "0x7A958A0", VA = "0x187A972A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public EKFIOJKBHPO MEJGBGHHDEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0xAC1510", Offset = "0xABFB10", VA = "0x180AC1510")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x7A97570", Offset = "0x7A95B70", VA = "0x187A97570")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		protected Material AFMMCPLDBKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x7A89510", Offset = "0x7A87B10", VA = "0x187A89510")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		protected Material NBKJBKDHABD
		{
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x7A8C1F0", Offset = "0x7A8A7F0", VA = "0x187A8C1F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public bool ONIOPBNDBLD
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x21AFB30", Offset = "0x21AE130", VA = "0x1821AFB30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public PlayerFacialAnimatorBase JHNDPNFOGKE
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0xA6A6B0", Offset = "0xA68CB0", VA = "0x180A6A6B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public GBHBDCHAKAB[] JOAEMCNBDEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x7A96280", Offset = "0x7A94880", VA = "0x187A96280")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public GBHBDCHAKAB DHLJDEDPMHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x7A968E0", Offset = "0x7A94EE0", VA = "0x187A968E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public GBHBDCHAKAB PCGIEIEEJPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x7A96910", Offset = "0x7A94F10", VA = "0x187A96910")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public Mesh IMFLEJGCGOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0xAC1ED0", Offset = "0xAC04D0", VA = "0x180AC1ED0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		protected FKKJNMIPHBA BFNIKHIFEIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x7A8CD10", Offset = "0x7A8B310", VA = "0x187A8CD10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		protected ALBMIKCECHI AAGMEDKDFHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0xAC2260", Offset = "0xAC0860", VA = "0x180AC2260")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x7A8DFC0", Offset = "0x7A8C5C0", VA = "0x187A8DFC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		protected bool KJIMCOKKLJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0xA05830", Offset = "0xA03E30", VA = "0x180A05830")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public bool OJIOHDKBAJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x7A968D0", Offset = "0x7A94ED0", VA = "0x187A968D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public int IOPMMHKPGGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x11E9A40", Offset = "0x11E8040", VA = "0x1811E9A40")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x7A974B0", Offset = "0x7A95AB0", VA = "0x187A974B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public int JKKLGABGFDJ
		{
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x7A971F0", Offset = "0x7A957F0", VA = "0x187A971F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		protected virtual bool GELBALGDKNO
		{
			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		protected virtual int[] NKHBJLBCEMH
		{
			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x7A90FA0", Offset = "0x7A8F5A0", VA = "0x187A90FA0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		protected bool JIFPFCLIKKP
		{
			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x7A8F770", Offset = "0x7A8DD70", VA = "0x187A8F770")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		protected static bool CNGCPGLIGCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public bool FOKCFFDOPNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x11EACF0", Offset = "0x11E92F0", VA = "0x1811EACF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x7A97780", Offset = "0x7A95D80", VA = "0x187A97780")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public IEnumerable<SkinnedMeshRenderer> KFBIHPKPNGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x7A96160", Offset = "0x7A94760", VA = "0x187A96160")]
			[IteratorStateMachine(typeof(LJKKABCBPLB))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public bool DINPHDIMOPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x11EBCE0", Offset = "0x11EA2E0", VA = "0x1811EBCE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x11EBBA0", Offset = "0x11EA1A0", VA = "0x1811EBBA0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public BLMBMEMIHNO CGILOPKPFBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x7A961E0", Offset = "0x7A947E0", VA = "0x187A961E0")]
			get
			{
				return default(BLMBMEMIHNO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public static bool NPGPGBMBKAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x7A96620", Offset = "0x7A94C20", VA = "0x187A96620")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		protected static OLILOOIADED GAHENGCMMCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x7A8DCE0", Offset = "0x7A8C2E0", VA = "0x187A8DCE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0x7A91030", Offset = "0x7A8F630", VA = "0x187A91030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		protected Color CIANNEIDAAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0x7A8E060", Offset = "0x7A8C660", VA = "0x187A8E060")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		protected Color GFMAIPOMMOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000291")]
			[Cpp2IlInjected.Address(RVA = "0x7A8C1A0", Offset = "0x7A8A7A0", VA = "0x187A8C1A0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		protected Texture2D DGNKKCNDKPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000292")]
			[Cpp2IlInjected.Address(RVA = "0x7A91A90", Offset = "0x7A90090", VA = "0x187A91A90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		protected Color JIPGBOFPJKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(RVA = "0x7A8F9E0", Offset = "0x7A8DFE0", VA = "0x187A8F9E0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		protected Color BCLIKDAECBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000299")]
			[Cpp2IlInjected.Address(RVA = "0x7A909E0", Offset = "0x7A8EFE0", VA = "0x187A909E0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public CKKEFOLDDDM PMGOFHFODNJ
		{
			[Cpp2IlInjected.Token(Token = "0x600029A")]
			[Cpp2IlInjected.Address(RVA = "0x7A96240", Offset = "0x7A94840", VA = "0x187A96240")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		protected Texture2D BMFIBAMHPDE
		{
			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0x7A8C0A0", Offset = "0x7A8A6A0", VA = "0x187A8C0A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public float PJBKIBAJDBK
		{
			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0x7A96260", Offset = "0x7A94860", VA = "0x187A96260")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public float GJAJBMMKLPF
		{
			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0x7A966D0", Offset = "0x7A94CD0", VA = "0x187A966D0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public bool LKCOOOOPHDC
		{
			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x13506A0", Offset = "0x134ECA0", VA = "0x1813506A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x7A96C80", Offset = "0x7A95280", VA = "0x187A96C80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action GIJDKDPBBDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x7A95EC0", Offset = "0x7A944C0", VA = "0x187A95EC0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x7A969E0", Offset = "0x7A94FE0", VA = "0x187A969E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action LFPIFNOBAOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x7A95E20", Offset = "0x7A94420", VA = "0x187A95E20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x7A96940", Offset = "0x7A94F40", VA = "0x187A96940")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action KJLOLHLFIGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x7A95F60", Offset = "0x7A94560", VA = "0x187A95F60")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x7A96A80", Offset = "0x7A95080", VA = "0x187A96A80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action BJOIGICLNOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x7A96000", Offset = "0x7A94600", VA = "0x187A96000")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x7A96B20", Offset = "0x7A95120", VA = "0x187A96B20")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<ECEPGPDPDKI, ACKOLLANMDJ> OHCGCLHBHHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x7A960A0", Offset = "0x7A946A0", VA = "0x187A960A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x7A96BC0", Offset = "0x7A951C0", VA = "0x187A96BC0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x7A927A0", Offset = "0x7A90DA0", VA = "0x187A927A0")]
		public bool SetDeformation(bool APHODKKNMPK, bool BKPHMFMOBOE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x7A88FF0", Offset = "0x7A875F0", VA = "0x187A88FF0")]
		protected static Material ACNIMILDKCE(Dictionary<DAACLJKOJBJ, Material> KEMDFPKPCOM, Material OJHFGKAFIEJ, IBAFKCJOEOA GMLOOFHADHO, NNMEKCBBIJP PGOOBBKNDOF, LEMFDNDBDJC BDNPFHIBMNH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x7A8E330", Offset = "0x7A8C930", VA = "0x187A8E330")]
		protected void IGFNPGNBCFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x7A8FA30", Offset = "0x7A8E030", VA = "0x187A8FA30")]
		protected bool MJFGPAOJKGH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x7A8E8A0", Offset = "0x7A8CEA0", VA = "0x187A8E8A0")]
		protected void JDLJBJNHCAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x7A90980", Offset = "0x7A8EF80", VA = "0x187A90980", Slot = "10")]
		protected virtual void OAACECFAIIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x7A90660", Offset = "0x7A8EC60", VA = "0x187A90660")]
		public int MeshesAtLODCount(int BAGGAHKJIOH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x7A8D630", Offset = "0x7A8BC30", VA = "0x187A8D630")]
		protected static void GOJDBMHGHLN(Dictionary<EMNJOPNCDMC, List<DAACLJKOJBJ>> DHPEMHCCIBM, GDNBCAAJINI DNPMBJLIGEP, Material OJHFGKAFIEJ, IBAFKCJOEOA FKAIEBDGNCN, NNMEKCBBIJP IHIJDFFNDNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x7A8B1A0", Offset = "0x7A897A0", VA = "0x187A8B1A0")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x7A8BD70", Offset = "0x7A8A370", VA = "0x187A8BD70")]
		protected void CGDAEDIEINB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x7A91630", Offset = "0x7A8FC30", VA = "0x187A91630")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "11")]
		protected virtual void KJOJBNECHKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x7A88DB0", Offset = "0x7A873B0", VA = "0x187A88DB0")]
		protected static void AALDLHGPDBG(List<Material> HAIHHPIOHNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x7A90E40", Offset = "0x7A8F440", VA = "0x187A90E40")]
		protected static void OELFCHAKDMH(Dictionary<DAACLJKOJBJ, Material> KEMDFPKPCOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x7A8F7F0", Offset = "0x7A8DDF0", VA = "0x187A8F7F0")]
		protected static void LNHBEJIKCOC(Dictionary<Renderer, DNOBIKFHBLF> JGEDDGOCJII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x7A90540", Offset = "0x7A8EB40", VA = "0x187A90540")]
		protected void MOMLGHGHKAB(SkinnedMeshRenderer[] GMCMJGGCAFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x7A90A30", Offset = "0x7A8F030", VA = "0x187A90A30")]
		protected void OBKENODFJNH(SkinnedMeshRenderer KMAINCIGCMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x7A90AD0", Offset = "0x7A8F0D0", VA = "0x187A90AD0")]
		protected void OBKENODFJNH(MeshRenderer NHJJDLPOEGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x7A90360", Offset = "0x7A8E960", VA = "0x187A90360")]
		protected void MNCEHLGEMCP(List<KBJDIMPKBHI> HOFMPDNMMNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x7A90800", Offset = "0x7A8EE00", VA = "0x187A90800")]
		protected void NFGNFEFIHCM(Dictionary<string, GKHPBLLBAIL<Texture2D>> DHPEMHCCIBM, bool HPAPGOPEPHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x7A8F1E0", Offset = "0x7A8D7E0", VA = "0x187A8F1E0")]
		protected void KGPAMBHLJJO(Dictionary<EMNJOPNCDMC, List<DAACLJKOJBJ>> DHPEMHCCIBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x7A8D910", Offset = "0x7A8BF10", VA = "0x187A8D910")]
		public float GetHandOpenClosedAxis(ECEPGPDPDKI LKCJMGGAGMB)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x7A93040", Offset = "0x7A91640", VA = "0x187A93040")]
		public void SetHandOpenClosedAxis(ECEPGPDPDKI LKCJMGGAGMB, float JONIFPGEBGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x7A8D950", Offset = "0x7A8BF50", VA = "0x187A8D950")]
		public ACKOLLANMDJ GetHandVisualState(ECEPGPDPDKI LKCJMGGAGMB)
		{
			return default(ACKOLLANMDJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x7A8A8E0", Offset = "0x7A88EE0", VA = "0x187A8A8E0")]
		public bool AddHandVisualStateToken(ECEPGPDPDKI LKCJMGGAGMB, ACKOLLANMDJ CKNBEIHOPMB, object EJJDDFFADPC, GBHBDCHAKAB.AABNHAOHPIF DPEJEDCKJBD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x7A94840", Offset = "0x7A92E40", VA = "0x187A94840")]
		public void SetWatchHand(ECEPGPDPDKI LKCJMGGAGMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x7A94900", Offset = "0x7A92F00", VA = "0x187A94900")]
		public void SetWatchHands(bool LOHLPDEMOJD, bool PEAMGGIJCDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x7A91E60", Offset = "0x7A90460", VA = "0x187A91E60")]
		public bool RemoveHandVisualStateToken(ECEPGPDPDKI LKCJMGGAGMB, object EJJDDFFADPC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x7A8D9D0", Offset = "0x7A8BFD0", VA = "0x187A8D9D0")]
		public bool GetThumbsUpActive(ECEPGPDPDKI LKCJMGGAGMB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x7A942E0", Offset = "0x7A928E0", VA = "0x187A942E0")]
		public void SetThumbsUpActive(ECEPGPDPDKI LKCJMGGAGMB, bool EIKAKAHNFFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x7A8D990", Offset = "0x7A8BF90", VA = "0x187A8D990")]
		public bool GetHandshakeActive(ECEPGPDPDKI LKCJMGGAGMB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x7A93090", Offset = "0x7A91690", VA = "0x187A93090")]
		public void SetHandshakeActive(ECEPGPDPDKI LKCJMGGAGMB, bool EHBJGIHGLOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x7A8CFA0", Offset = "0x7A8B5A0", VA = "0x187A8CFA0")]
		public void ForceUpdateHandsVisualState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x7A8C8E0", Offset = "0x7A8AEE0", VA = "0x187A8C8E0")]
		public static void ClearQueuedBuilds()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x7A8DD30", Offset = "0x7A8C330", VA = "0x187A8DD30")]
		private static void HNFGGECEKFE(Scene CHJMGPBPDEK, LoadSceneMode MECLDBHCDJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x7A88EF0", Offset = "0x7A874F0", VA = "0x187A88EF0")]
		protected static void ABMBGDJGFDN(PlayerAvatarDisplayBase FDDEDELKECL, List<BBOCIFIGBHP> JCKEJHBHIKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x7A91B80", Offset = "0x7A90180", VA = "0x187A91B80")]
		public HPIGCMLNLFB Rebuild(bool CHCCINKDNBK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x7A8B5F0", Offset = "0x7A89BF0", VA = "0x187A8B5F0")]
		protected HPIGCMLNLFB BMJPBCDIMBJ(bool CHCCINKDNBK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x7A8B640", Offset = "0x7A89C40", VA = "0x187A8B640", Slot = "12")]
		protected virtual HPIGCMLNLFB BMJPBCDIMBJ(IList<EMNJOPNCDMC> CBHKPCEHICG, AvatarItemBodyType JJNOCFGNJGJ, bool EEAEBGKMHGP, int[] GDHEBGBAJMD, bool CHCCINKDNBK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x7A8EAA0", Offset = "0x7A8D0A0", VA = "0x187A8EAA0")]
		protected static HPIGCMLNLFB JJIMMIOOKEO(BBOCIFIGBHP IFPIKDGGHIP, List<BBOCIFIGBHP> JCKEJHBHIKC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x7A8CCB0", Offset = "0x7A8B2B0", VA = "0x187A8CCB0")]
		[IteratorStateMachine(typeof(PBJIEGHEHJF))]
		protected static IEnumerator<NFNODNEANBN> EJDCOLHPJPA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x7A902D0", Offset = "0x7A8E8D0", VA = "0x187A902D0")]
		protected static BBOCIFIGBHP MMGKKCBFHNG(List<BBOCIFIGBHP> JCKEJHBHIKC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x7A928B0", Offset = "0x7A90EB0", VA = "0x187A928B0")]
		[AsyncStateMachine(typeof(LAPKKJPFALF))]
		public Task SetFaceCustomizationSettings(MAKBECHNCGC MNFOAJDGMOA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7A94A60", Offset = "0x7A93060", VA = "0x187A94A60")]
		public bool UpdateFaceAndBodyCustomizationSettings(MAKBECHNCGC MNFOAJDGMOA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x7A8E7C0", Offset = "0x7A8CDC0", VA = "0x187A8E7C0")]
		public void InitializeFaceFeatures(AvatarConfiguration NGKBNOKDLJN, BLMBMEMIHNO JDMGBLFHDLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x7A94030", Offset = "0x7A92630", VA = "0x187A94030")]
		public void SetTeamColors(Color? CDCECCBAMKD, bool PMLJACMFCGB, Color FOOPJDADBNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x1299E70", Offset = "0x1298470", VA = "0x181299E70")]
		private static void ABLICHLPEJG(Material CANJBFKPEMF, Color OHLIHBDBKCE, params int[] PEPHNJHHFII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x129B670", Offset = "0x1299C70", VA = "0x18129B670")]
		private static void KGLHLJGLLOO(Material CANJBFKPEMF, Texture OHLIHBDBKCE, params int[] PEPHNJHHFII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x7A8E0B0", Offset = "0x7A8C6B0", VA = "0x187A8E0B0")]
		protected void IFJBJDIBEEP(Material KCFANBEOAGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x7A8F340", Offset = "0x7A8D940", VA = "0x187A8F340")]
		protected void KNDDBHAJDDH(Material KCFANBEOAGC, Color FFKDKFFFLJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x7A8BB50", Offset = "0x7A8A150", VA = "0x187A8BB50")]
		protected void CGBAJANPKDH(Material KCFANBEOAGC, Color FFKDKFFFLJI, Color PCNBINHACDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x7A8D0A0", Offset = "0x7A8B6A0", VA = "0x187A8D0A0")]
		protected void GGMLDEFFPBC(Material KCFANBEOAGC, Texture2D BFGBBIJNNHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x7A8B4E0", Offset = "0x7A89AE0", VA = "0x187A8B4E0")]
		protected void BIFKOANKICK(Material KCFANBEOAGC, Texture LJGGMGAEHBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x7A8DE60", Offset = "0x7A8C460", VA = "0x187A8DE60")]
		protected void IBBNNJCLPEJ(Action<DNOBIKFHBLF> GBFPEDHKGBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x7A8D2B0", Offset = "0x7A8B8B0", VA = "0x187A8D2B0")]
		protected void GHAGFEOHPJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x7A8B320", Offset = "0x7A89920", VA = "0x187A8B320")]
		protected void BBIKNLDPMGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x7A8B7F0", Offset = "0x7A89DF0", VA = "0x187A8B7F0")]
		protected void CAPNFLHKIKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x7A8AC30", Offset = "0x7A89230", VA = "0x187A8AC30")]
		public void ApplyUgcItemOverrides()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x7A92220", Offset = "0x7A90820", VA = "0x187A92220")]
		public void SetBeardPrimaryColor([Optional] Color? OEBIHMNGAHE, bool EDCNDCKDDHI = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x7A92440", Offset = "0x7A90A40", VA = "0x187A92440")]
		public void SetBeardSecondaryColor([Optional] Color? OEBIHMNGAHE, bool EDCNDCKDDHI = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x7A920E0", Offset = "0x7A906E0", VA = "0x187A920E0")]
		public void SetBeardPattern([Optional] AvatarHairPattern HBKAMIDNPLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x7A8E930", Offset = "0x7A8CF30", VA = "0x187A8E930")]
		private void JEMOPPLHLHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x7A8E670", Offset = "0x7A8CC70", VA = "0x187A8E670")]
		private bool INELLDPGPKA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x7A92C20", Offset = "0x7A91220", VA = "0x187A92C20")]
		public void SetHairPrimaryColor([Optional] Color? FAOPFFICEGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x7A92E30", Offset = "0x7A91430", VA = "0x187A92E30")]
		public void SetHairSecondaryColor([Optional] Color? FAOPFFICEGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x7A92AF0", Offset = "0x7A910F0", VA = "0x187A92AF0")]
		public void SetHairPattern([Optional] AvatarHairPattern HBKAMIDNPLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x7A91D00", Offset = "0x7A90300", VA = "0x187A91D00")]
		public void RefreshHair()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x7A8F460", Offset = "0x7A8DA60", VA = "0x187A8F460")]
		private bool LCDGIPEHJJF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x7A93E70", Offset = "0x7A92470", VA = "0x187A93E70")]
		public void SetSkinColor(Color HOKBFOFIGDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x7A94330", Offset = "0x7A92930", VA = "0x187A94330")]
		public void SetUgcItemVisualOverrides(EMNJOPNCDMC HNMCGDBFDGH, BLMBMEMIHNO JDMGBLFHDLB, Texture FKIMBDHIBDN, Color FMGCKKPOHKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x7A8C9B0", Offset = "0x7A8AFB0", VA = "0x187A8C9B0")]
		public void ClearUgcItemVisualOverrides()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x7A929B0", Offset = "0x7A90FB0", VA = "0x187A929B0")]
		public bool SetFaceShape(AvatarFaceShape NOLJPELCPGH, bool HFPBIAGEELK = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x7A90BA0", Offset = "0x7A8F1A0", VA = "0x187A90BA0")]
		private void OCOHJLBJOOC(OAIBHFEEBFF OHKLPMGKCNP, float OHLIHBDBKCE, bool NGGBHLHDOAO = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x7A8FC50", Offset = "0x7A8E250", VA = "0x187A8FC50")]
		private void MJNHAGFKPDE(KCGDHGHDIFP FGHDADLFLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x7A8E720", Offset = "0x7A8CD20", VA = "0x187A8E720")]
		private void IPEJBKIPPIA(OGHEPKGNCBA LHCBLABBENF, float OHLIHBDBKCE, bool CNDBMNGCPEP = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x7A8EFA0", Offset = "0x7A8D5A0", VA = "0x187A8EFA0")]
		private void JMAGOFIIPAD(OJGFLCIKIFC GKKKGOHEELC, float OHLIHBDBKCE, bool ONLNMKMBDBE = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x7A8F230", Offset = "0x7A8D830", VA = "0x187A8F230")]
		private void KHMBFAFJHHO(MDLGKOMCHJL ABCMKKBACLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x7A91240", Offset = "0x7A8F840", VA = "0x187A91240")]
		private void OIKCHILEPGD(NOIJAGJBAKE GFGHPGGNOIK, float DDOOGPGCAFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x7A92660", Offset = "0x7A90C60", VA = "0x187A92660")]
		public bool SetBodyShape(AvatarBodyShape JNNFLNPDLLA, bool HFPBIAGEELK = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x7A93D00", Offset = "0x7A92300", VA = "0x187A93D00")]
		public bool SetNoseType(ABOJDNCODIG AEHFOHDJDBI, bool HFPBIAGEELK = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x7A95140", Offset = "0x7A93740", VA = "0x187A95140")]
		public bool UpdateFaceAndBodyShapes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x7A93CE0", Offset = "0x7A922E0", VA = "0x187A93CE0")]
		public bool SetHideEars(bool MFMFGJHHMIK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x7A93CD0", Offset = "0x7A922D0", VA = "0x187A93CD0")]
		public bool SetHelmetHair(OJELMNHDJHH LPMFGFAMFBN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x7A930E0", Offset = "0x7A916E0", VA = "0x187A930E0")]
		public void SetHatAnchorParameters(HMAKLDEGKBC PKHDLMKMENB, bool GFMMOMPEDID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x7A949D0", Offset = "0x7A92FD0", VA = "0x187A949D0")]
		public void SetupDisplayLODs(NMOIBHCNNGG FFKEGPJGFCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x7A8CD30", Offset = "0x7A8B330", VA = "0x187A8CD30")]
		protected int[] EOJPPJDCFJG(NMOIBHCNNGG FFKEGPJGFCC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x7A93DA0", Offset = "0x7A923A0", VA = "0x187A93DA0")]
		public void SetOutfitSelections(IList<EMNJOPNCDMC> CBHKPCEHICG, AvatarItemBodyType JJNOCFGNJGJ, bool CHCCINKDNBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x7A93DE0", Offset = "0x7A923E0", VA = "0x187A93DE0")]
		public void SetOutfitSelections(IList<EMNJOPNCDMC> CBHKPCEHICG, AvatarItemBodyType JJNOCFGNJGJ, bool EEAEBGKMHGP, bool CHCCINKDNBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x7A93E20", Offset = "0x7A92420", VA = "0x187A93E20")]
		public HPIGCMLNLFB SetOutfitSelections(IList<EMNJOPNCDMC> CBHKPCEHICG, AvatarItemBodyType JJNOCFGNJGJ, NMOIBHCNNGG FFKEGPJGFCC, bool EEAEBGKMHGP, bool HFPBIAGEELK = false, bool CHCCINKDNBK = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x7A8F520", Offset = "0x7A8DB20", VA = "0x187A8F520", Slot = "13")]
		protected virtual HPIGCMLNLFB LFHIKEMHCEG(IList<EMNJOPNCDMC> CBHKPCEHICG, AvatarItemBodyType JJNOCFGNJGJ, bool EEAEBGKMHGP, NMOIBHCNNGG FFKEGPJGFCC, bool HFPBIAGEELK, bool CHCCINKDNBK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x7A91370", Offset = "0x7A8F970", VA = "0x187A91370")]
		protected int[] OJODJKDMAJL(NMOIBHCNNGG FFKEGPJGFCC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x9EA230", Offset = "0x9E8830", VA = "0x1809EA230", Slot = "14")]
		protected virtual ALBMIKCECHI ELODBECDEDF(AvatarItemBodyType MLPKEOCLJHM, Dictionary<string, ALBBMKANDAF> CPOJAFHJIFH, Dictionary<string, GKHPBLLBAIL<Texture2D>> FCLOCFEJAMM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x7A8DA10", Offset = "0x7A8C010", VA = "0x187A8DA10", Slot = "15")]
		protected virtual HPIGCMLNLFB HKCIHMLEPNG(IList<EMNJOPNCDMC> CBHKPCEHICG, AvatarItemBodyType JJNOCFGNJGJ, bool EEAEBGKMHGP, int[] KIOKNKHEIMB, JICFHOJONOI BDDLEIHELIB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x7A8FE50", Offset = "0x7A8E450", VA = "0x187A8FE50", Slot = "16")]
		protected virtual ALBBMKANDAF MKHAOJDCPCD(CKKEFOLDDDM NPDKKINBDDF, AvatarItemBodyType MLPKEOCLJHM, LEMFDNDBDJC BDNPFHIBMNH, ALBBMKANDAF COELBOAOKHO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x9EA230", Offset = "0x9E8830", VA = "0x1809EA230", Slot = "17")]
		protected virtual ALBBMKANDAF PHLHBNHBHKF(AvatarItemBodyType MLPKEOCLJHM, LEMFDNDBDJC BDNPFHIBMNH, GADAOPIMBPG JDPKJPILGNF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x7A8F0E0", Offset = "0x7A8D6E0", VA = "0x187A8F0E0")]
		protected void KCAGDNGKKHE(OMFDGHDDKHE HDLDJFCINHD, DJMKKMKOHOE.KHMINOCKMDE PFMMBFIBAED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x7A8F160", Offset = "0x7A8D760", VA = "0x187A8F160")]
		protected void KCNFGFAOLDN(OMFDGHDDKHE HDLDJFCINHD, DJMKKMKOHOE.KHMINOCKMDE PFMMBFIBAED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0xA89310", Offset = "0xA87910", VA = "0x180A89310", Slot = "18")]
		protected virtual OMFDGHDDKHE PMIDAJGBINL(OMFDGHDDKHE HDLDJFCINHD, HelmetHairStyle EKBENDICGMI, bool NGLAKBLHMLH, AvatarItemBodyType JJNOCFGNJGJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x7A89750", Offset = "0x7A87D50", VA = "0x187A89750")]
		protected OMFDGHDDKHE ALBJFCDCIFJ(IList<EMNJOPNCDMC> CBHKPCEHICG, AvatarItemBodyType FLBPMOLOPPJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x7A8C7C0", Offset = "0x7A8ADC0", VA = "0x187A8C7C0")]
		public void CleanupDisplayResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x7A8CFF0", Offset = "0x7A8B5F0", VA = "0x187A8CFF0")]
		protected void GBLAEBPNDEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x7A891E0", Offset = "0x7A877E0", VA = "0x187A891E0")]
		protected void ADPKIHPOJEP(Transform MGBMHIAPDFD, IEnumerable<SkinnedMeshRenderer> DNDNGDEDHHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x7A8CEE0", Offset = "0x7A8B4E0", VA = "0x187A8CEE0")]
		protected DJMKKMKOHOE.KHMINOCKMDE FPLJPPJCAIA(DJMKKMKOHOE.KHMINOCKMDE PPBPOBKGLON, LEMFDNDBDJC OJOHFHDBACP)
		{
			return default(DJMKKMKOHOE.KHMINOCKMDE);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x7A8CAC0", Offset = "0x7A8B0C0", VA = "0x187A8CAC0")]
		protected void DFCLCNFGEDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x121BD90", Offset = "0x121A390", VA = "0x18121BD90")]
		protected void IKMHBEDBLIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x7A91470", Offset = "0x7A8FA70", VA = "0x187A91470")]
		protected void OKKEOHOEAHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x7A91920", Offset = "0x7A8FF20", VA = "0x187A91920")]
		[AsyncStateMachine(typeof(LHHGGHBPNDA))]
		protected Task PCDDELKMMBC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x7A8E450", Offset = "0x7A8CA50", VA = "0x187A8E450")]
		protected static IBAFKCJOEOA IGLIHIPGIPB(GDNBCAAJINI DADFPFCEPAK, int FPNNGFNMBMA)
		{
			return default(IBAFKCJOEOA);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x7A8CAD0", Offset = "0x7A8B0D0", VA = "0x187A8CAD0")]
		protected static NNMEKCBBIJP DKELNJIGIDP(GDNBCAAJINI DADFPFCEPAK, int FPNNGFNMBMA)
		{
			return default(NNMEKCBBIJP);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x7A911F0", Offset = "0x7A8F7F0", VA = "0x187A911F0")]
		protected Transform OIJOOMFAPHM(LEMFDNDBDJC BDNPFHIBMNH, OutfitType KAMFIEKLGNP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x7A90C40", Offset = "0x7A8F240", VA = "0x187A90C40")]
		protected void ODEGJEIOILA(int KMLNOHKPNFG, Material CANJBFKPEMF, GDNBCAAJINI DADFPFCEPAK, [Out] Texture2D MGPEMBAGNBN, [Out] Vector4 ANNENBEHPMI, [Out] Texture2D KMMLDOAJCOM, [Out] Texture2D BNKFBNNLFHF, [Out] Texture2D IEHNFAOCACL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x7A8A740", Offset = "0x7A88D40", VA = "0x187A8A740")]
		protected void ALKFAAJACAO(int KMLNOHKPNFG, Material CANJBFKPEMF, GDNBCAAJINI DADFPFCEPAK, [Out] Color BCJBJCJEEOB, [Out] Color DENCMJLNDEA, [Out] Color GNOGEJFGEHI, [Out] Color EMEEOLPKGGL, [Out] Color MEAICLBLNAP, [Out] Color MOIBEGCKKBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x7A91580", Offset = "0x7A8FB80", VA = "0x187A91580")]
		protected void OLBOAKKALAI(Vector3 MJJFMHOFJKF, Quaternion GMKIGHDIIHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x7A93680", Offset = "0x7A91C80", VA = "0x187A93680")]
		public void SetHatAnchorParameters(HMAKLDEGKBC PKHDLMKMENB, AnchorParamsRestrictions FOKOPHDADKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x7A8C2E0", Offset = "0x7A8A8E0", VA = "0x187A8C2E0")]
		public static void CalculateHatAnchorParams(FitMeshHemisphere CPHGACAMCNJ, Transform GCAOHBMKLFM, HMAKLDEGKBC PKHDLMKMENB, AnchorParamsRestrictions DFNIKEMKODL, [Out] Vector3 IHMLAPGNLCC, [Out] Quaternion JHMNNKLOODA, [Out] HMAKLDEGKBC JBGPOMHMLMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x7A91F70", Offset = "0x7A90570", VA = "0x187A91F70")]
		public void ResetHatAnchor(Vector2 FFELCDAPPJI, Vector3 LGAJDNIMLAA, Vector3 GILNNGGNLNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0xA9FEF0", Offset = "0xA9E4F0", VA = "0x180A9FEF0")]
		public NFNPBLMBHAL GetAnchorParamsRestrictions()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x7A8AA60", Offset = "0x7A89060", VA = "0x187A8AA60")]
		public void ApplyBlocks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x7A8ABA0", Offset = "0x7A891A0", VA = "0x187A8ABA0")]
		public void ApplyHairPattern()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x7A8A9D0", Offset = "0x7A88FD0", VA = "0x187A8A9D0")]
		public void ApplyBeardPattern()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x7A94A00", Offset = "0x7A93000", VA = "0x187A94A00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x7A8CA00", Offset = "0x7A8B000", VA = "0x187A8CA00")]
		protected void DDHACPAMCEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x7A947C0", Offset = "0x7A92DC0", VA = "0x187A947C0")]
		public void SetWaitForUgcTextureLoads(bool LKECFFEIFNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x7A946D0", Offset = "0x7A92CD0", VA = "0x187A946D0")]
		public void SetUgcTextureParameters(NAFFPEBCHPI PMLCGCAHNGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x7A95820", Offset = "0x7A93E20", VA = "0x187A95820")]
		public PlayerAvatarDisplayBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x7A89150", Offset = "0x7A87750", VA = "0x187A89150")]
		[CompilerGenerated]
		private void ADEOLLAMDFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x7A8E5F0", Offset = "0x7A8CBF0", VA = "0x187A8E5F0")]
		[CompilerGenerated]
		private void IIFIOPOHHHA(DNOBIKFHBLF FHHMDKONHLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x7A8CC20", Offset = "0x7A8B220", VA = "0x187A8CC20")]
		[CompilerGenerated]
		private void DLFOPOKFEHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x7A919F0", Offset = "0x7A8FFF0", VA = "0x187A919F0")]
		[CompilerGenerated]
		private void PCNDCEDIPHO(DNOBIKFHBLF FHHMDKONHLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x7A8D4F0", Offset = "0x7A8BAF0", VA = "0x187A8D4F0")]
		[CompilerGenerated]
		private void GLGOFHBKMIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x7A8F040", Offset = "0x7A8D640", VA = "0x187A8F040")]
		[CompilerGenerated]
		private void JPPCBIMDPEJ(DNOBIKFHBLF FHHMDKONHLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x7A8B760", Offset = "0x7A89D60", VA = "0x187A8B760")]
		[CompilerGenerated]
		private void BPIPGNLGHEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x7A8E620", Offset = "0x7A8CC20", VA = "0x187A8E620")]
		[CompilerGenerated]
		private void IMBMIABPGBK(DNOBIKFHBLF FHHMDKONHLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x7A8D5A0", Offset = "0x7A8BBA0", VA = "0x187A8D5A0")]
		[CompilerGenerated]
		private void GOEJGBLFNAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x7A8A890", Offset = "0x7A88E90", VA = "0x187A8A890")]
		[CompilerGenerated]
		private void AOAHGKIFCPO(DNOBIKFHBLF FHHMDKONHLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x7A8F950", Offset = "0x7A8DF50", VA = "0x187A8F950")]
		[CompilerGenerated]
		private void LPPJHJKOGNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x7A8D580", Offset = "0x7A8BB80", VA = "0x187A8D580")]
		[CompilerGenerated]
		private void GMGJGMOFAMO(DNOBIKFHBLF FHHMDKONHLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x7A90720", Offset = "0x7A8ED20", VA = "0x187A90720")]
		[CompilerGenerated]
		internal static bool NDEFPAGMBDC(Transform JOKAGHLDFKD, IEnumerable<SkinnedMeshRenderer> NHMDKOPANCI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x7A918E0", Offset = "0x7A8FEE0", VA = "0x187A918E0")]
		[CompilerGenerated]
		private void PBIMGFMPIHE(DNOBIKFHBLF FHHMDKONHLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x7A915F0", Offset = "0x7A8FBF0", VA = "0x187A915F0")]
		[CompilerGenerated]
		private void OMDKBJJHEGD(DNOBIKFHBLF FHHMDKONHLB)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[ExecuteAlways]
	public class PlayerFacialAnimatorBase : MonoBehaviour, FHBMACKKPGL
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		[CompilerGenerated]
		private struct LEMGGHEDINN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000460")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000461")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000462")]
			public MAKBECHNCGC avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000463")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000464")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A0")]
			[Cpp2IlInjected.Address(RVA = "0x7A9DE50", Offset = "0x7A9C450", VA = "0x187A9DE50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A1")]
			[Cpp2IlInjected.Address(RVA = "0x7A9E0E0", Offset = "0x7A9C6E0", VA = "0x187A9E0E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		[CompilerGenerated]
		private struct LCJHLFBMNAG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000465")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000466")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000467")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000468")]
			public int eyeSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000469")]
			public int eyeBrowSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400046A")]
			public int noseSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x400046B")]
			public int mouthSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400046C")]
			public BLMBMEMIHNO avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400046D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0x7A9DC10", Offset = "0x7A9C210", VA = "0x187A9DC10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0x7A9DDF0", Offset = "0x7A9C3F0", VA = "0x187A9DDF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		[CompilerGenerated]
		private struct PHNKNNBLACN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400046E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400046F")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000470")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000471")]
			public FaceFeatureType featureType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000472")]
			public int selectionIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000473")]
			public BLMBMEMIHNO avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000474")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x7A9FAF0", Offset = "0x7A9E0F0", VA = "0x187A9FAF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x7A9FC90", Offset = "0x7A9E290", VA = "0x187A9FC90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private struct DKDAMNINJFN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000475")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000476")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000477")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000478")]
			public MAKBECHNCGC avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000479")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x7A98D20", Offset = "0x7A97320", VA = "0x187A98D20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x7A98ED0", Offset = "0x7A974D0", VA = "0x187A98ED0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private struct OCOEMDDDHGD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400047A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400047B")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400047C")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400047D")]
			public BLMBMEMIHNO avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400047E")]
			private TaskAwaiter<KIAELDLCAEI> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x7A9E720", Offset = "0x7A9CD20", VA = "0x187A9E720", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x7A9EB60", Offset = "0x7A9D160", VA = "0x187A9EB60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		[CompilerGenerated]
		private struct OFCGEHKPDJK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400047F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000480")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000481")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000482")]
			public bool forceRebuild;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000483")]
			public BLMBMEMIHNO avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000484")]
			private FaceStyleSet <styleSet>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000485")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x7A9EBC0", Offset = "0x7A9D1C0", VA = "0x187A9EBC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x7A9F090", Offset = "0x7A9D690", VA = "0x187A9F090", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		protected const float BNCECIOJIHF = 0.5f;

		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		protected const int ECNMMMGOGDF = 5;

		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public static readonly int IdleID;

		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public static readonly int SmileID;

		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public static readonly int HugeSmileID;

		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public static readonly int ScoreID;

		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public static readonly int SadID;

		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public static readonly int DisgustID;

		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public static readonly int HitID;

		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public static readonly int ConcentrateID;

		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public static readonly int KissID;

		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public static readonly int TalkingID;

		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public static readonly int MuteID;

		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public static readonly int AFKID;

		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public static readonly int HappyID;

		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public static readonly int EmoteFlatID;

		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public static readonly int EmoteHappyID;

		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public static readonly int EmoteSadID;

		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public static readonly int EmoteLoveID;

		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public static readonly int EmoteAngryID;

		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public static readonly int EmoteLaughID;

		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public static readonly int EmoteTongueOutID;

		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public static readonly int EmoteGrimacingID;

		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public static readonly int EmoteWinkID;

		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public static readonly int EmoteShockedID;

		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public static readonly int EmoteNauseatedID;

		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public static readonly int EmoteSmileSweatID;

		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public static readonly int EmoteSleepingID;

		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public static readonly int EmoteThinkingID;

		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public static readonly int EmoteSmirkID;

		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public static readonly int EmoteSmileID;

		[Cpp2IlInjected.Token(Token = "0x4000405")]
		protected static readonly Dictionary<GOPMEEGJDMI.MONNCAKECLO, int> HOPKPIFMJJF;

		[Cpp2IlInjected.Token(Token = "0x4000406")]
		[CanBeNull]
		protected static IEnumerable<FaceFeatureType> NPHEOCFMGDC;

		[Cpp2IlInjected.Token(Token = "0x4000407")]
		protected static readonly int NJJJCPCPFLJ;

		[Cpp2IlInjected.Token(Token = "0x4000408")]
		protected static readonly int KDHILIFKAKB;

		[Cpp2IlInjected.Token(Token = "0x4000409")]
		protected static readonly int MGNCCFMICBK;

		[Cpp2IlInjected.Token(Token = "0x400040A")]
		protected static readonly int PFEELKDLGJC;

		[Cpp2IlInjected.Token(Token = "0x400040B")]
		protected static readonly int JFOOAEDJKDF;

		[Cpp2IlInjected.Token(Token = "0x400040C")]
		protected static readonly int LPLADOHJNLE;

		[Cpp2IlInjected.Token(Token = "0x400040D")]
		protected static readonly int HGNKPOHAEMC;

		[Cpp2IlInjected.Token(Token = "0x400040E")]
		protected static readonly int HGBCAOBHHBE;

		[Cpp2IlInjected.Token(Token = "0x400040F")]
		protected static Vector2 OCFJPIJKGMN;

		[Cpp2IlInjected.Token(Token = "0x4000410")]
		protected static Vector2 CAJIAHNGOOG;

		[Cpp2IlInjected.Token(Token = "0x4000411")]
		protected static Vector2 POJJHJOOJMD;

		[Cpp2IlInjected.Token(Token = "0x4000412")]
		protected static Vector2 MNBFLCHECGC;

		[Cpp2IlInjected.Token(Token = "0x4000413")]
		protected static Vector2 EBHACDIBFHB;

		[Cpp2IlInjected.Token(Token = "0x4000414")]
		protected static Vector2 DHJNJBAGPMD;

		[Cpp2IlInjected.Token(Token = "0x4000415")]
		protected static Vector2 EKALDCKCFBC;

		[Cpp2IlInjected.Token(Token = "0x4000416")]
		protected static Vector2 PKAJKBPDNGH;

		[Cpp2IlInjected.Token(Token = "0x4000417")]
		protected static Vector2 LDNPMHFBFPK;

		[Cpp2IlInjected.Token(Token = "0x4000418")]
		protected static Vector2 ADDJFIPHLGJ;

		[Cpp2IlInjected.Token(Token = "0x4000419")]
		protected static Vector2 CGPOAGJFINH;

		[Cpp2IlInjected.Token(Token = "0x400041A")]
		protected static Vector2 CLLDGGCKCOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		[ANKANEOPOFH(JINCPHMLLKA.Self, false, false, false)]
		[SerializeField]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		[SerializeField]
		[Header("Rendering")]
		public FaceStyleSet faceStyleSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		[SerializeField]
		protected Renderer faceRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		[SerializeField]
		protected float jitterFPS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		[Header("Emotes")]
		[SerializeField]
		public Renderer[] emoteEffectRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		[SerializeField]
		[FormerlySerializedAs("fullBodyFaceStyleSet")]
		[Header("Modern Avatar Facial Features")]
		public FaceStyleSet modernBodyFaceStyleSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		private BLMBMEMIHNO JDJLHMGNBCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		private FaceStyleSet OMNBJICGPPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		[SerializeField]
		protected bool debugEyeJitterInEditor;

		[Cpp2IlInjected.Token(Token = "0x4000424")]
		protected const int OAMKHIMOOMD = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		protected int IFJPCPOMLFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		protected int ENIAECAJGBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		protected int FKIGGHDHLAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		protected int MLMBOGGDAJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		protected Vector2 GILFALADJBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		protected float PCBOMOLLCAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		protected float GEDCCKPOFDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		protected float IJMAJJKDNPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		protected Vector2 LNCMALJHPFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		protected float KKLHHODBDEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		protected float FCLAGBJNJOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		protected float MPPFOMPDPLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		protected Vector2 LMFACMHKIFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		protected float CBLOELEIBKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		protected float LIKALEJKKLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		protected float KKLLLNHBADB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		protected Vector2 LKDAOBKKHAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		protected float BEFCLFECFID;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		protected float GGIFPFBGPDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		protected float HAPGNAEBHEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		protected List<SelectableFaceOption> NPFCLIEONGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		protected List<SelectableFaceOption> CDJPDICMMID;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		protected List<SelectableFaceOption> MBCKFICICCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		protected List<SelectableFaceOption> DDOPJECABLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		protected Coroutine NCEHLPJFEBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		protected int? DPLIFPLOCGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		protected int NLCMENNAMEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		protected int NCLDABGGCDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		protected int LOKKGGJGFJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		protected int FOPOKMFMJIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		protected int NCEHBKDOEAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		protected int DCPFIMELPDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		protected Sprite HDOLKKIFGGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		protected Sprite OKHGAHDDEOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		protected Sprite LLJAELLDDCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		protected Sprite PBDDJMILPII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		protected bool IANIDBBKDFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		protected string HJKOHEBEPIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		protected string CKLOMHMKDGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		protected string JIALAKOGAGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		protected string NBLEGDIDJIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		[ReadOnlyField]
		public Sprite eyeSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		[ReadOnlyField]
		public Sprite leftEyeOnlySprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		[ReadOnlyField]
		public Sprite rightEyeOnlySprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public Color leftEyeColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public Color leftEyeGleamColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public Color rightEyeColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public Color rightEyeGleamColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		[ReadOnlyField]
		public Sprite mouthSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		protected AvatarConfiguration NGKBNOKDLJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		protected KIAELDLCAEI KJHHIJDHIFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		private readonly List<Material> HCIADMPJHDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		protected GMCHJHHGEBP BNANBKEFBGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		protected Dictionary<string, int> BDILEJGHPDB;

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public FaceStyleSet BFKPDOGMKAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x7AA6520", Offset = "0x7AA4B20", VA = "0x187AA6520")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public bool OECNNBLFMJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0xACCDC0", Offset = "0xACB3C0", VA = "0x180ACCDC0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x122F860", Offset = "0x122DE60", VA = "0x18122F860")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		protected virtual bool JLKJDNMEKEC
		{
			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		protected virtual bool HCBNGIHJGHB
		{
			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0xA05830", Offset = "0xA03E30", VA = "0x180A05830", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		protected int OGBHMDAJJDD
		{
			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x7AA0F60", Offset = "0x7A9F560", VA = "0x187AA0F60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public Renderer LCACIANOOHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x9EB550", Offset = "0x9E9B50", VA = "0x1809EB550")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public bool ELNEHMNDILI
		{
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0xAC9F70", Offset = "0xAC8570", VA = "0x180AC9F70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x1DA5200", Offset = "0x1DA3800", VA = "0x181DA5200")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public Renderer[] ALEDHEMFIII
		{
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x9EB780", Offset = "0x9E9D80", VA = "0x1809EB780")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public bool AGPBOHGGCAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x7AA6570", Offset = "0x7AA4B70", VA = "0x187AA6570")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x7AA6730", Offset = "0x7AA4D30", VA = "0x187AA6730")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		protected int EBDGKBBKKJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x7AA2060", Offset = "0x7AA0660", VA = "0x187AA2060")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		protected int IHIJCEFOPLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x7AA0250", Offset = "0x7A9E850", VA = "0x187AA0250")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public float HDDJNIMKHME
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x7AA6550", Offset = "0x7AA4B50", VA = "0x187AA6550")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x7AA6710", Offset = "0x7AA4D10", VA = "0x187AA6710")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public CPCAHHNKCEK AHDDGCHGPPH
		{
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0xAAFD70", Offset = "0xAAE370", VA = "0x180AAFD70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0xAF0D40", Offset = "0xAEF340", VA = "0x180AF0D40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public KIAELDLCAEI EPIKIJKLJPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000387")]
			[Cpp2IlInjected.Address(RVA = "0xAC1720", Offset = "0xABFD20", VA = "0x180AC1720")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000388")]
			[Cpp2IlInjected.Address(RVA = "0x7AA6690", Offset = "0x7AA4C90", VA = "0x187AA6690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public NoseFaceOption NAGNBIHDOHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000389")]
			[Cpp2IlInjected.Address(RVA = "0xAA73D0", Offset = "0xAA59D0", VA = "0x180AA73D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600038A")]
			[Cpp2IlInjected.Address(RVA = "0xB46620", Offset = "0xB44C20", VA = "0x180B46620")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		protected GMCHJHHGEBP DDPLHOMMJAC
		{
			[Cpp2IlInjected.Token(Token = "0x600038B")]
			[Cpp2IlInjected.Address(RVA = "0x7AA2F70", Offset = "0x7AA1570", VA = "0x187AA2F70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action LNFADNDNLHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x7AA6470", Offset = "0x7AA4A70", VA = "0x187AA6470")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x7AA65E0", Offset = "0x7AA4BE0", VA = "0x187AA65E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x7AA2E10", Offset = "0x7AA1410", VA = "0x187AA2E10")]
		public void LocalPlayEmote(GOPMEEGJDMI.MONNCAKECLO MKAOFLLKCGA, float HOLBMGNIFPF = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x7AA1C50", Offset = "0x7AA0250", VA = "0x187AA1C50")]
		public bool IsEmotePlaying(GOPMEEGJDMI.MONNCAKECLO MKAOFLLKCGA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x7AA4470", Offset = "0x7AA2A70", VA = "0x187AA4470")]
		public void SetIdleHappy(bool HCIFHLCCBGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x7AA3730", Offset = "0x7AA1D30", VA = "0x187AA3730")]
		protected void OEKEJGFPHIF(bool CPABBKEHFCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x7AA0AD0", Offset = "0x7A9F0D0", VA = "0x187AA0AD0")]
		protected void FBICNGFJFJA(bool OIOMKMPMIKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x7AA2F00", Offset = "0x7AA1500", VA = "0x187AA2F00")]
		protected void NHANMKFOPHP(LEMFDNDBDJC BDNPFHIBMNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x7AA16D0", Offset = "0x7A9FCD0", VA = "0x187AA16D0")]
		protected void IEDOLGPHGMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x7AA3B40", Offset = "0x7AA2140", VA = "0x187AA3B40")]
		public void PlayExpression(int IHLFBGKHMBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x7AA0EB0", Offset = "0x7A9F4B0", VA = "0x187AA0EB0")]
		protected void FPPFLCHNNLC(bool PKLDANANAGN, bool PMHJIKMLKBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x7AA1510", Offset = "0x7A9FB10", VA = "0x187AA1510")]
		public List<SelectableFaceOption> GetAvailableFeatures(FaceFeatureType MKKIEOCNHPD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x7AA1740", Offset = "0x7A9FD40", VA = "0x187AA1740")]
		public void InitializeFaceFeatureRanges(AvatarConfiguration NGKBNOKDLJN, BLMBMEMIHNO JDMGBLFHDLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x7AA4240", Offset = "0x7AA2840", VA = "0x187AA4240")]
		[AsyncStateMachine(typeof(LEMGGHEDINN))]
		public Task SetFaceSettings(MAKBECHNCGC MNFOAJDGMOA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x7AA4110", Offset = "0x7AA2710", VA = "0x187AA4110")]
		[AsyncStateMachine(typeof(LCJHLFBMNAG))]
		public Task SetFaceSettings(int FIFKMEIKBAC, int LFMFAANBNDE, int JEEJOPHMHEL, int CEIBLIDDHFC, BLMBMEMIHNO JDMGBLFHDLB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x7AA44F0", Offset = "0x7AA2AF0", VA = "0x187AA44F0")]
		[AsyncStateMachine(typeof(PHNKNNBLACN))]
		public Task SetSelectedFaceFeatureAndBuildFaceStyle(FaceFeatureType MKKIEOCNHPD, int DKCFEEFLGFE, BLMBMEMIHNO JDMGBLFHDLB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x7AA2900", Offset = "0x7AA0F00", VA = "0x187AA2900")]
		protected void LFOEDIBIDAP(FaceFeatureType MKKIEOCNHPD, MCAONEJPGJL BPNLDPBPOKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x7AA2FF0", Offset = "0x7AA15F0", VA = "0x187AA2FF0")]
		protected void NPAKDEGFLNF(FaceFeatureType MKKIEOCNHPD, int DKCFEEFLGFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x7AA1340", Offset = "0x7A9F940", VA = "0x187AA1340")]
		public static IEnumerable<FaceFeatureType> GetAllFaceFeatureTypes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x7AA0DC0", Offset = "0x7A9F3C0", VA = "0x187AA0DC0")]
		[AsyncStateMachine(typeof(DKDAMNINJFN))]
		protected Task FHFGKDAONEC(MAKBECHNCGC MNFOAJDGMOA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x7AA1D60", Offset = "0x7AA0360", VA = "0x187AA1D60")]
		protected void KKHFENGJMGB(MAKBECHNCGC MNFOAJDGMOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x7AA0C30", Offset = "0x7A9F230", VA = "0x187AA0C30")]
		protected static void FHBGFLGJKHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x7AA04D0", Offset = "0x7A9EAD0", VA = "0x187AA04D0")]
		private void BFIAFOKHOEB(bool IEJJHIGCHKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x7AA2A80", Offset = "0x7AA1080", VA = "0x187AA2A80")]
		protected void LNCCBKKMNGK(FaceFeatureType MKKIEOCNHPD, Vector2 GMGOHHNEGED, BLMBMEMIHNO JDMGBLFHDLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x7AA3B60", Offset = "0x7AA2160", VA = "0x187AA3B60")]
		public void SetFaceFeatureNormalizedPositionOffset(FaceFeatureType MKKIEOCNHPD, Vector2 PEEIFNEOGOI, BLMBMEMIHNO JDMGBLFHDLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x7AA39C0", Offset = "0x7AA1FC0", VA = "0x187AA39C0")]
		protected void PGABCOHDKML(FaceFeatureType MKKIEOCNHPD, float EIIHOPBEFCC, BLMBMEMIHNO JDMGBLFHDLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x7AA1550", Offset = "0x7A9FB50", VA = "0x187AA1550")]
		protected void HCKOMNLAIIH(FaceFeatureType MKKIEOCNHPD, float OOBEGCNALKF, BLMBMEMIHNO JDMGBLFHDLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x7AA0810", Offset = "0x7A9EE10", VA = "0x187AA0810")]
		protected void BHJMGAHCPOB(FaceFeatureType MKKIEOCNHPD, float LJOCPPONLJF, BLMBMEMIHNO JDMGBLFHDLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x7AA3EF0", Offset = "0x7AA24F0", VA = "0x187AA3EF0")]
		public void SetFaceFeatureNormalizedScaleOffset(FaceFeatureType MKKIEOCNHPD, float NNPJOGAMMKB, BLMBMEMIHNO JDMGBLFHDLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x7AA02B0", Offset = "0x7A9E8B0", VA = "0x187AA02B0")]
		[AsyncStateMachine(typeof(OCOEMDDDHGD))]
		protected Task ANAOKCGJDCO(BLMBMEMIHNO JDMGBLFHDLB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x7AA1A40", Offset = "0x7AA0040", VA = "0x187AA1A40")]
		public void InitializeFaceFeatureStyleSet(BLMBMEMIHNO JDMGBLFHDLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x7AA0730", Offset = "0x7A9ED30", VA = "0x187AA0730")]
		protected bool BGPDGJBIJJB(string LBJFIPOFPPN, [Out] int OHHMJGCBCKD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x7AA0390", Offset = "0x7A9E990", VA = "0x187AA0390")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x1630F60", Offset = "0x162F560", VA = "0x181630F60", Slot = "8")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x7AA37B0", Offset = "0x7AA1DB0", VA = "0x187AA37B0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5610", Offset = "0x7AA3C10", VA = "0x187AA5610")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x7AA08E0", Offset = "0x7A9EEE0", VA = "0x187AA08E0")]
		[AsyncStateMachine(typeof(OFCGEHKPDJK))]
		public Task BuildFaceStyleAsyncIfChanged(BLMBMEMIHNO JDMGBLFHDLB, bool HFPBIAGEELK = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x7AA4F30", Offset = "0x7AA3530", VA = "0x187AA4F30")]
		public void UpdateFaceDisplays(bool JNJPBNKKPBH = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x7AA20C0", Offset = "0x7AA06C0", VA = "0x187AA20C0")]
		protected bool LDLACHGFELL(bool JNJPBNKKPBH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x7AA4C50", Offset = "0x7AA3250", VA = "0x187AA4C50")]
		public void UpdateFaceDisplayFeatureTextures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x7AA4330", Offset = "0x7AA2930", VA = "0x187AA4330")]
		public void SetFaceSpriteIndices(string LGCGLIJCGID, string MFHMPOEOBON, string GEGMHLDPODA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x7AA4600", Offset = "0x7AA2C00", VA = "0x187AA4600")]
		public void UpdateFaceDisplayFeaturePositions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5140", Offset = "0x7AA3740", VA = "0x187AA5140")]
		public void UpdateFaceJitterMultiplier()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5330", Offset = "0x7AA3930", VA = "0x187AA5330")]
		public bool UpdateLegacyFaceVectors()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x7AA09E0", Offset = "0x7A9EFE0", VA = "0x187AA09E0")]
		protected void EMHGBDDKEGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x7AA1090", Offset = "0x7A9F690", VA = "0x187AA1090")]
		private void GNAAJEMACEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x7AA6220", Offset = "0x7AA4820", VA = "0x187AA6220")]
		public PlayerFacialAnimatorBase()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0xA17AF0", Offset = "0xA160F0", VA = "0x180A17AF0", Slot = "4")]
		private bool OAGFDLFCCPO()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct LLCKJOKJMMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public string IJKBIMCGCEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public int OJLJBFKDCDP;
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
		private struct OLGLCBHGIFC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004E7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004E8")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004E9")]
			public PlayerModernBodyEditorAvatarValidator <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004EA")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0x7A9F4B0", Offset = "0x7A9DAB0", VA = "0x187A9F4B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E0")]
			[Cpp2IlInjected.Address(RVA = "0xA40260", Offset = "0xA3E860", VA = "0x180A40260", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000077")]
		[CompilerGenerated]
		private struct POEGMOGFLDG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004EB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004EC")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004ED")]
			public PlayerModernBodyEditorAvatarValidator <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004EE")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003E1")]
			[Cpp2IlInjected.Address(RVA = "0x7A9FCF0", Offset = "0x7A9E2F0", VA = "0x187A9FCF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E2")]
			[Cpp2IlInjected.Address(RVA = "0x7AA01F0", Offset = "0x7A9E7F0", VA = "0x187AA01F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public const string IDLE_ANIM_NAME = "Idle";

		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public const string A_POSE_ANIM_NAME = "A Pose";

		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public const string ANIMATION_OVERRIDE_STATE_NAME = "Override";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public BLMBMEMIHNO avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public Color hairPrimaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public Color hairSecondaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public Color beardPrimaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public Color beardSecondaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public Color skinColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public int faceShapeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public int bodyShapeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public int hairPatternIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public int beardPatternIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public AvatarFaceShape[] faceShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public AvatarBodyShape[] bodyShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public AvatarHairPattern[] hairPatterns;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public float _avatarScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public bool enablePosing;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public int poseIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public AnimationClip animationOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		[Range(0f, 4f)]
		public float animationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public OJELMNHDJHH useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public HMAKLDEGKBC hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public NFNPBLMBHAL HatAnchorRestrictions;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public bool UseHairFitMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD1")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public bool usesHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public GameObject hatPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public GameObject hairPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public GameObject earPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public GameObject eyePrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public GameObject mouthPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public GameObject neckPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public GameObject shirtPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public GameObject beltPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public GameObject shoulderPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public GameObject rightHandPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public GameObject leftHandPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public GameObject legsPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public GameObject feetPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public long baseSkinCullingMask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		[SerializeField]
		[ANKANEOPOFH(JINCPHMLLKA.Self, false, false, false)]
		public PlayerAvatarDisplayBase _avatarDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		private GBFNELEFJAC LEBCMFOLOIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		[SerializeField]
		[ANKANEOPOFH(JINCPHMLLKA.Self, false, false, false)]
		public PlayerFacialAnimatorBase facialAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public AnimationClip animationClipToOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		private AnimatorOverrideController AOBDDBLIHIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		private List<KeyValuePair<AnimationClip, AnimationClip>> FHAFKEIODFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public Transform headIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public Transform leftHandIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public Transform rightHandIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		[Range(0f, 2f)]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public int rightHandGestureStateIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		[Range(0f, 1f)]
		public float rightHandCurl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public int leftHandGestureStateIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		[Range(0f, 1f)]
		public float leftHandCurl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public int eyeBrowSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public int eyeSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public int noseSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public int mouthSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public float eyeBrowPositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public float eyeBrowPositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public float eyeBrowScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public float eyePositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public float eyePositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public float eyeScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D4")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public float nosePositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public float noseScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1DC")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public float mouthPositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public float mouthPositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E4")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public float mouthScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public float hatNormalizedPositionX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EC")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public float hatNormalizedPositionY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public Vector3 hatHemispherePositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1FC")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public Vector3 hatHemisphereRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public int facialExpressionIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20C")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		[Range(0f, 1f)]
		public float normalizedTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public readonly LLCKJOKJMMI[] FacialExpressions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public readonly string[] BodyPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public readonly (string, ACKOLLANMDJ)[] HandPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public bool hideLeftWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x229")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public bool hideRightWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22A")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		protected bool INLAHEKHDGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22C")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		protected Guid GOPLMMMJDHM;

		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		protected static Guid LJEAKBOHHGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		private EEFKKODIKGJ PBMIFJMNDNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		private CPCAHHNKCEK GMCECMEINAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		private EKFIOJKBHPO MGCOAJDDCHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		private EKFIOJKBHPO NCPPMDKMJDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		private AdditionalHatData PGDHKGCOJOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		private readonly Dictionary<GameObject, CKKEFOLDDDM> IAGOLCLBMDK;

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public static Func<GADAOPIMBPG> OHPAADMHPCH
		{
			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x7AAB740", Offset = "0x7AA9D40", VA = "0x187AAB740")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0x7AABD80", Offset = "0x7AAA380", VA = "0x187AABD80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		public bool LCDGIPEHJJF
		{
			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x7AAB8A0", Offset = "0x7AA9EA0", VA = "0x187AAB8A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public bool INELLDPGPKA
		{
			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x7AAB790", Offset = "0x7AA9D90", VA = "0x187AAB790")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public PlayerAvatarDisplayBase JBDLPFCPPOM
		{
			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0xAB1E80", Offset = "0xAB0480", VA = "0x180AB1E80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		protected static Guid MEEJNPIBHLB
		{
			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x7AA8AD0", Offset = "0x7AA70D0", VA = "0x187AA8AD0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		public (GameObject, LEMFDNDBDJC)[] ACALACGHLEO
		{
			[Cpp2IlInjected.Token(Token = "0x60003C9")]
			[Cpp2IlInjected.Address(RVA = "0x7AAB9B0", Offset = "0x7AA9FB0", VA = "0x187AAB9B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x7AA94C0", Offset = "0x7AA7AC0", VA = "0x187AA94C0")]
		[ContextMenu("Refresh Avatar")]
		private void RebuildTestAvatarContextMenu()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x7AA7D40", Offset = "0x7AA6340", VA = "0x187AA7D40")]
		private IEnumerable<GameObject> EOJMKANJKMK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x7AA99B0", Offset = "0x7AA7FB0", VA = "0x187AA99B0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x7AA81B0", Offset = "0x7AA67B0", VA = "0x187AA81B0")]
		private void HJJKFILBCJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x127E730", Offset = "0x127CD30", VA = "0x18127E730")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x7AA8320", Offset = "0x7AA6920", VA = "0x187AA8320")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x7AA99C0", Offset = "0x7AA7FC0", VA = "0x187AA99C0")]
		public void Teardown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x7AA97B0", Offset = "0x7AA7DB0", VA = "0x187AA97B0")]
		public void ShowPose(AnimationClip ICKENEFAALA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x7AA9980", Offset = "0x7AA7F80", VA = "0x187AA9980")]
		public void ShowPose(string NCKELHEKOGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x7AA9610", Offset = "0x7AA7C10", VA = "0x187AA9610")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x7AA94D0", Offset = "0x7AA7AD0", VA = "0x187AA94D0")]
		public void ResetHandPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x7AAA490", Offset = "0x7AA8A90", VA = "0x187AAA490")]
		public void UpdateHandAnimation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x7AAA2E0", Offset = "0x7AA88E0", VA = "0x187AAA2E0")]
		public void UpdateFaceAndBodyShapes(bool HFPBIAGEELK = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x7AAA890", Offset = "0x7AA8E90", VA = "0x187AAA890")]
		public void UpdateNoseShape(ABOJDNCODIG AEHFOHDJDBI, bool HFPBIAGEELK = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x7AAA860", Offset = "0x7AA8E60", VA = "0x187AAA860")]
		public void UpdateLODOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x7AA8BC0", Offset = "0x7AA71C0", VA = "0x187AA8BC0", Slot = "4")]
		protected virtual void LKMLNJCFJOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x7AA6880", Offset = "0x7AA4E80", VA = "0x187AA6880", Slot = "5")]
		protected virtual void AJGFCJMCCHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x7AA6CB0", Offset = "0x7AA52B0", VA = "0x187AA6CB0")]
		public void ApplyHatData(AdditionalHatData OIFEEKHFHPE, bool ALDIAIHDCKC = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x7AA6AF0", Offset = "0x7AA50F0", VA = "0x187AA6AF0")]
		public void ApplyHatAdjustmentsToHatAnchorParams()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x7AA7010", Offset = "0x7AA5610", VA = "0x187AA7010")]
		public void ApplyHatUVOverride(Vector2 ENPNPELINAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x7AA6F30", Offset = "0x7AA5530", VA = "0x187AA6F30")]
		public void ApplyHatPositionAdjustment(Vector3 HMNICACDGIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x7AA6FA0", Offset = "0x7AA55A0", VA = "0x187AA6FA0")]
		public void ApplyHatRotationAdjustment(Vector3 ECOBOIKCNJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x7AA7080", Offset = "0x7AA5680", VA = "0x187AA7080")]
		public EMNJOPNCDMC BuildAvatarItemSelection(GameObject KMJIGOCPILL, BLMBMEMIHNO MLPKEOCLJHM, LEMFDNDBDJC PAMAJIDJFOH)
		{
			return default(EMNJOPNCDMC);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x7AA7120", Offset = "0x7AA5720", VA = "0x187AA7120")]
		public void BuildAvatar(bool HFPBIAGEELK = false, bool ALDIAIHDCKC = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x7AA9D20", Offset = "0x7AA8320", VA = "0x187AA9D20")]
		public void UpdateColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x7AA6C30", Offset = "0x7AA5230", VA = "0x187AA6C30")]
		public void ApplyHatAnchor()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x7AAA6B0", Offset = "0x7AA8CB0", VA = "0x187AAA6B0")]
		public void UpdateHatAnchor(bool ALDIAIHDCKC = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x7AAA3E0", Offset = "0x7AA89E0", VA = "0x187AAA3E0")]
		[AsyncStateMachine(typeof(OLGLCBHGIFC))]
		public void UpdateFaceFeatures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x7AA8ED0", Offset = "0x7AA74D0", VA = "0x187AA8ED0")]
		[AsyncStateMachine(typeof(POEGMOGFLDG))]
		private Task NJIOBJBAEHG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x7AA7720", Offset = "0x7AA5D20", VA = "0x187AA7720")]
		private void CIFEGEKNOGN(FaceFeatureType FHPHLNGNANC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x7AA8290", Offset = "0x7AA6890", VA = "0x187AA8290")]
		private void HKFHKBMGJFC(FaceFeatureType FHPHLNGNANC, [Out] float IAOMFOLOIIC, [Out] float FNBIPEPKGLK, [Out] float HDLKNIPAJGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x7AAA1A0", Offset = "0x7AA87A0", VA = "0x187AAA1A0")]
		public void UpdateEmote()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x7AAA540", Offset = "0x7AA8B40", VA = "0x187AAA540")]
		public void UpdateHandPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x7AA8FA0", Offset = "0x7AA75A0", VA = "0x187AA8FA0")]
		private void OPNCBHMKICB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		private void DNNHGHABHIO(CKKEFOLDDDM NPDKKINBDDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		private void MLDOJDENLKH(CKKEFOLDDDM NPDKKINBDDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x7AA79E0", Offset = "0x7AA5FE0", VA = "0x187AA79E0")]
		private void DCCHPMCLHKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x7AAA910", Offset = "0x7AA8F10", VA = "0x187AAA910")]
		public PlayerModernBodyEditorAvatarValidator()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x7AA8A20", Offset = "0x7AA7020", VA = "0x187AA8A20")]
		[CompilerGenerated]
		private EMNJOPNCDMC JDDAICKNPCG((GameObject, LEMFDNDBDJC) NEDFAKEKHOG)
		{
			return default(EMNJOPNCDMC);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class SkinnedMeshBonesInspector : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		[ANKANEOPOFH(JINCPHMLLKA.Self, false, false, false)]
		[SerializeField]
		private SkinnedMeshRenderer skinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		[SerializeField]
		private int BoneWeightsDisplayStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		[SerializeField]
		private int BoneWeightsDisplayAmount;

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x9EA210", Offset = "0x9E8810", VA = "0x1809EA210")]
		public SkinnedMeshBonesInspector()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct EMNJOPNCDMC
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class DJNOMFCLKKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public IEnumerable<OutfitType> otherOutfitTypes;

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public DJNOMFCLKKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x7A98CA0", Offset = "0x7A972A0", VA = "0x187A98CA0")]
		internal bool EIGEJBPCIOP(OutfitType outfitType)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	private CKKEFOLDDDM AGPBCGMGMGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	private LEMFDNDBDJC OOKAJCIPPLG;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public CKKEFOLDDDM GBHHDDAPDIC
	{
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public LEMFDNDBDJC IFCMMFOJBML
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0xD2EE80", Offset = "0xD2D480", VA = "0x180D2EE80")]
		get
		{
			return default(LEMFDNDBDJC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public string FPFIMAEMPOF
	{
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x7A9BC20", Offset = "0x7A9A220", VA = "0x187A9BC20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public bool NALDFNNIJPG
	{
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x7A9BB80", Offset = "0x7A9A180", VA = "0x187A9BB80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool MOHAACLMKGA
	{
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x7A9BBD0", Offset = "0x7A9A1D0", VA = "0x187A9BBD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x17AD290", Offset = "0x17AB890", VA = "0x1817AD290")]
	public EMNJOPNCDMC(CKKEFOLDDDM NPDKKINBDDF, LEMFDNDBDJC BDNPFHIBMNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x7A9BF70", Offset = "0x7A9A570", VA = "0x187A9BF70")]
	public bool PCEHNCJFCHN(OutfitType BFDFGEPOLJJ, LEMFDNDBDJC EENFKJBCPAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x7A9BD10", Offset = "0x7A9A310", VA = "0x187A9BD10")]
	public bool MLFBEHEMPBC(OutfitType BFDFGEPOLJJ, LEMFDNDBDJC EENFKJBCPAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x7A9B990", Offset = "0x7A99F90", VA = "0x187A9B990")]
	public bool CDCOKAECNKN(EMNJOPNCDMC OJJPAPEPLKG)
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
