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
		[Cpp2IlInjected.Address(RVA = "0x7AA2F50", Offset = "0x7AA1F50", VA = "0x187AA2F50", Slot = "4")]
		public override void AMBIAOGNIIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA1A700", Offset = "0xA19700", VA = "0x180A1A700")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F6810", Offset = "0x9F5810", VA = "0x1809F6810", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override string AssetGUID
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x7AA5280", Offset = "0x7AA4280", VA = "0x187AA5280", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5210", Offset = "0x7AA4210", VA = "0x187AA5210", Slot = "17")]
		public override bool RuntimeKeyIsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5240", Offset = "0x7AA4240", VA = "0x187AA5240")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string UniqueItemIdentifier
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string CacheHash
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x9F0CD0", Offset = "0x9EFCD0", VA = "0x1809F0CD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RecNetCDNKey Dependency
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x9F1550", Offset = "0x9F0550", VA = "0x1809F1550")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x9F5A20", Offset = "0x9F4A20", VA = "0x1809F5A20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool AttemptPrecacheLookup
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xA1DF60", Offset = "0xA1CF60", VA = "0x180A1DF60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA1DD80", Offset = "0xA1CD80", VA = "0x180A1DD80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public LGHANJFEDKG PathHint
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xDA8D50", Offset = "0xDA7D50", VA = "0x180DA8D50")]
			[CompilerGenerated]
			get
			{
				return default(LGHANJFEDKG);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x12F0210", Offset = "0x12EF210", VA = "0x1812F0210")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string ItemPath
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x7AA5390", Offset = "0x7AA4390", VA = "0x187AA5390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7AA52C0", Offset = "0x7AA42C0", VA = "0x187AA52C0")]
		public static RecNetCDNKey BFIJMBOABGP(string IAJMCIIEMIA, LGHANJFEDKG NICNCJIIMND)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5340", Offset = "0x7AA4340", VA = "0x187AA5340")]
		public void BNIMMBNJKLL(string PNJLMAHAELH, string CNOOJBJPLMK, bool LDPOOPAGCOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
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
	[Cpp2IlInjected.Address(RVA = "0x7AA3280", Offset = "0x7AA2280", VA = "0x187AA3280", Slot = "4")]
	public void GKAHHFADIKG(Mesh PEPFHNJFNIL, Matrix4x4 GBOHAMAACHL, byte[] AHOGHGIIKDO, bool COHLFCDAJAJ = false, DJMKKMKOHOE.KHMINOCKMDE FHNEEDJLIKD = (DJMKKMKOHOE.KHMINOCKMDE)0L, int ACGKBLDNMLK = -1, bool DLDPOELFKGB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7AA2FE0", Offset = "0x7AA1FE0", VA = "0x187AA2FE0", Slot = "5")]
	public void EKELMPDKPON(Allocator NDFENJBGNOB, EONPPOBGAOL BEBBIOKLEJJ, byte GGNNMGDCEED, [Optional] IList<int> IGEECJJEHIN, [Optional] IList<int> LKLIOGJGKMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7AA3020", Offset = "0x7AA2020", VA = "0x187AA3020")]
	private static void FBDDFDPPDDM(Mesh PEPFHNJFNIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7AA3500", Offset = "0x7AA2500", VA = "0x187AA3500")]
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
	[Cpp2IlInjected.Address(RVA = "0x7AA3750", Offset = "0x7AA2750", VA = "0x187AA3750", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[NativeContainer]
[HJNCDIOGCJG]
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
		[Cpp2IlInjected.Address(RVA = "0x7A90AE0", Offset = "0x7A8FAE0", VA = "0x187A90AE0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7A92140", Offset = "0x7A91140", VA = "0x187A92140")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int KMEAPHNMOHI
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7A90AD0", Offset = "0x7A8FAD0", VA = "0x187A90AD0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7A92D90", Offset = "0x7A91D90", VA = "0x187A92D90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int DCEBGGCGCON
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7A92DA0", Offset = "0x7A91DA0", VA = "0x187A92DA0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7A92DB0", Offset = "0x7A91DB0", VA = "0x187A92DB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int OFAGCOAPCCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7A92DC0", Offset = "0x7A91DC0", VA = "0x187A92DC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7A92E30", Offset = "0x7A91E30", VA = "0x187A92E30")]
	public BCABEAKKLHP(int DLOLGMFGMCF, int KHMLDEKGOGN, int OKKKFJPPJBM, int NCOLCNECKHG, Allocator NDFENJBGNOB, int LJHHEIGDCPK, PHFAILKPHNL KCDJDDGAADL, bool NIIMKNLENEM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7A920B0", Offset = "0x7A910B0", VA = "0x187A920B0")]
	public void HDLFLBKAKKF(int OHHMJGCBCKD, Vector3 IINHKHEMEHJ, Vector3 KLJKHLHNLGP, Vector4 LEMBKBGMCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7A92480", Offset = "0x7A91480", VA = "0x187A92480")]
	public void JDOKECODNDF(int OHHMJGCBCKD, BoneWeight NHAPOAOKIGM, NativeSlice<byte> AHOGHGIIKDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7A92150", Offset = "0x7A91150", VA = "0x187A92150")]
	public Color HPNCCIMOPBK(int OHHMJGCBCKD)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7A92990", Offset = "0x7A91990", VA = "0x187A92990")]
	public void NEMFFJAMDMK(int OHHMJGCBCKD, Color JKIBOICMIDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7A90AF0", Offset = "0x7A8FAF0", VA = "0x187A90AF0")]
	public void CLCMMOGNEHO(byte KCDFLKCBIKJ, int OHHMJGCBCKD, Vector2 MGPLIBEEABL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7A928B0", Offset = "0x7A918B0", VA = "0x187A928B0")]
	public void KEFDAKBCNKF(int OHHMJGCBCKD, int HIJGCANIBGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7A91100", Offset = "0x7A90100", VA = "0x187A91100")]
	public bool ENKKJEKEEDM(int KCDFLKCBIKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7A928C0", Offset = "0x7A918C0", VA = "0x187A928C0")]
	public void MAAFKJANCOD(int GNDDIJKFHIM, int LLPAIMMACAP, int DDGBDMFPMAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7A90EA0", Offset = "0x7A8FEA0", VA = "0x187A90EA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7A91160", Offset = "0x7A90160", VA = "0x187A91160")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A941D0", Offset = "0x7A931D0", VA = "0x187A941D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int PEMPMDIKECC
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7A942D0", Offset = "0x7A932D0", VA = "0x187A942D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int LALFONMEHBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7A942E0", Offset = "0x7A932E0", VA = "0x187A942E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int IDMIEAGHKAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7A942C0", Offset = "0x7A932C0", VA = "0x187A942C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7A941B0", Offset = "0x7A931B0", VA = "0x187A941B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int HINGJKKACPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7A94000", Offset = "0x7A93000", VA = "0x187A94000")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7A941E0", Offset = "0x7A931E0", VA = "0x187A941E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int IFCJDIOLHID
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7A94010", Offset = "0x7A93010", VA = "0x187A94010")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7A943C0", Offset = "0x7A933C0", VA = "0x187A943C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public EONPPOBGAOL DNJJAFNOEIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7A93DA0", Offset = "0x7A92DA0", VA = "0x187A93DA0")]
		get
		{
			return default(EONPPOBGAOL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7A941A0", Offset = "0x7A931A0", VA = "0x187A941A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public byte KDIIKCBKGNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7A941C0", Offset = "0x7A931C0", VA = "0x187A941C0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7A943B0", Offset = "0x7A933B0", VA = "0x187A943B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public GBGGPFBECJI OEMFNNCKNFG
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7A93DB0", Offset = "0x7A92DB0", VA = "0x187A93DB0")]
		get
		{
			return default(GBGGPFBECJI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7A943D0", Offset = "0x7A933D0", VA = "0x187A943D0")]
	public ELDEMJODJGF(IList<Mesh> KBDLEKHEHMN, IList<Matrix4x4> DJFOKBGCCNJ, IList<bool> DLDPOELFKGB, byte GGNNMGDCEED, IList<byte[]> FONLLDDLMJH, IList<long> CKKFOPFCAOD, IList<bool> FNOHPKAEEOI, IList<int> ACGKBLDNMLK, IList<int> IGEECJJEHIN, IList<int> GNFGAAOIHNM, Allocator NDFENJBGNOB, EONPPOBGAOL BEBBIOKLEJJ, bool NIIMKNLENEM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7A941F0", Offset = "0x7A931F0", VA = "0x187A941F0")]
	public BCABEAKKLHP IPMEGOIAMCA(Allocator NDFENJBGNOB, PHFAILKPHNL KCDJDDGAADL)
	{
		return default(BCABEAKKLHP);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7A94020", Offset = "0x7A93020", VA = "0x187A94020", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x7A95830", Offset = "0x7A94830", VA = "0x187A95830")]
	public ELDEMJODJGF GDGODOCMIHG()
	{
		return default(ELDEMJODJGF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7A95AF0", Offset = "0x7A94AF0", VA = "0x187A95AF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public FLJNPNCIPBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7A957E0", Offset = "0x7A947E0", VA = "0x187A957E0")]
		internal bool PDOFCBMOCJO(ALBBMKANDAF item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7A956D0", Offset = "0x7A946D0", VA = "0x187A956D0")]
		internal void LCOONBNLJDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7A955C0", Offset = "0x7A945C0", VA = "0x187A955C0")]
		internal void FJFCPOPIBEK(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7A956D0", Offset = "0x7A946D0", VA = "0x187A956D0")]
		internal void IJNHJNELBPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7A955C0", Offset = "0x7A945C0", VA = "0x187A955C0")]
		internal void MAOBAFHGNAE(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x7A955E0", Offset = "0x7A945E0", VA = "0x187A955E0")]
		internal void HLNPKEINFPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7A956F0", Offset = "0x7A946F0", VA = "0x187A956F0")]
		internal void LOGIFJBNJHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7A95610", Offset = "0x7A94610", VA = "0x187A95610")]
		internal void IDJPCNELGEJ(Dictionary<string, GKHPBLLBAIL<Texture2D>> resourceHandleDictionary)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7A95720", Offset = "0x7A94720", VA = "0x187A95720")]
		internal void MLBGGNMOOHM(KeyValuePair<string, GKHPBLLBAIL<Texture2D>> kvp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public EJILKMLNIGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7A93CE0", Offset = "0x7A92CE0", VA = "0x187A93CE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public BLDJGCJOHIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
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
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public IOAINOIGBLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x7A95DD0", Offset = "0x7A94DD0", VA = "0x187A95DD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x9F28C0", Offset = "0x9F18C0", VA = "0x1809F28C0")]
		[DebuggerHidden]
		public INDCFPMDHON(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7A95B00", Offset = "0x7A94B00", VA = "0x187A95B00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7A95D80", Offset = "0x7A94D80", VA = "0x187A95D80", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public FBDDNPBECPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0xA83500", Offset = "0xA82500", VA = "0x180A83500")]
		internal void DPNNKIBFAFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0xCC7720", Offset = "0xCC6720", VA = "0x180CC7720")]
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
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
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
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public DOKMDMKNHMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x7A93AA0", Offset = "0x7A92AA0", VA = "0x187A93AA0")]
		internal void FMBNECOIEIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x1247700", Offset = "0x1246700", VA = "0x181247700")]
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
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public DKAHONPHIPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7A93860", Offset = "0x7A92860", VA = "0x187A93860")]
		internal void KMOLIEMEOLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x12496F0", Offset = "0x12486F0", VA = "0x1812496F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public KEEDDFBPBHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7A95F00", Offset = "0x7A94F00", VA = "0x187A95F00")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public GCADBNOOJOM FKICFHPEPLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private JAHOCBPGMLL AJHJEIPEGEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7A9B4A0", Offset = "0x7A9A4A0", VA = "0x187A9B4A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool KEFCAAODOCD
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7AA0EC0", Offset = "0x7A9FEC0", VA = "0x187AA0EC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private bool IKJDKMFPOPD
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7A9B7F0", Offset = "0x7A9A7F0", VA = "0x187A9B7F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private bool HJAHMFDBGGE
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7A9AB90", Offset = "0x7A99B90", VA = "0x187A9AB90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private bool CMAOHLEHMFA
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7A97EB0", Offset = "0x7A96EB0", VA = "0x187A97EB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public AvatarConfiguration MMMOHDOGNHL
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x9F4CF0", Offset = "0x9F3CF0", VA = "0x1809F4CF0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool NBOCNNCLLHG
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x1367680", Offset = "0x1366680", VA = "0x181367680")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2597530", Offset = "0x2596530", VA = "0x182597530")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private Material AFMMCPLDBKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7A97F90", Offset = "0x7A96F90", VA = "0x187A97F90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private Material NBKJBKDHABD
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7A9A900", Offset = "0x7A99900", VA = "0x187A9A900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private bool KJIMCOKKLJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A680", VA = "0x180A0B680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public BLMBMEMIHNO CGILOPKPFBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x11D7F10", Offset = "0x11D6F10", VA = "0x1811D7F10", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return default(BLMBMEMIHNO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x11D6DD0", Offset = "0x11D5DD0", VA = "0x1811D6DD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public Material AIDPAHHCHLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xCC0110", Offset = "0xCBF110", VA = "0x180CC0110", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public SkinnedMeshRenderer[] BCDFCKMLPFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x1C0C680", Offset = "0x1C0B680", VA = "0x181C0C680", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public Renderer[] LAPDFLIBNND
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xA8D7A0", Offset = "0xA8C7A0", VA = "0x180A8D7A0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool FBBAILFPMON
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7A9AE70", Offset = "0x7A99E70", VA = "0x187A9AE70", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public DJMKKMKOHOE.KHMINOCKMDE BNDOMBIBDNM
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xA87B50", Offset = "0xA86B50", VA = "0x180A87B50", Slot = "20")]
		get
		{
			return default(DJMKKMKOHOE.KHMINOCKMDE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int IOPMMHKPGGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x11D7620", Offset = "0x11D6620", VA = "0x1811D7620")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7A9BD30", Offset = "0x7A9AD30", VA = "0x187A9BD30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private bool JIFPFCLIKKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7AA0050", Offset = "0x7A9F050", VA = "0x187AA0050")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private static bool CNGCPGLIGCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xA3A820", Offset = "0xA39820", VA = "0x180A3A820")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7A9B510", Offset = "0x7A9A510", VA = "0x187A9B510", Slot = "15")]
	public ALBMIKCECHI FBLCEBCCAMP(OMFDGHDDKHE EAEKJMJLOAC, bool EEAEBGKMHGP, int[] KIOKNKHEIMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7A9F7E0", Offset = "0x7A9E7E0", VA = "0x187A9F7E0", Slot = "14")]
	public ALBMIKCECHI KBANOGBGLKK(OMFDGHDDKHE EAEKJMJLOAC, bool EEAEBGKMHGP, int[] KIOKNKHEIMB, Func<Dictionary<string, ALBBMKANDAF>, (ALBMIKCECHI, KGAPFDAFEHM<Dictionary<string, GKHPBLLBAIL<Texture2D>>>)> CLMFFEADJPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7A961E0", Offset = "0x7A951E0", VA = "0x187A961E0")]
	public ALBMIKCECHI ADPKDBKPFMP(OMFDGHDDKHE EAEKJMJLOAC, bool EEAEBGKMHGP, int[] KIOKNKHEIMB, bool AOHPOOECADH, JICFHOJONOI AJGOHICNHCN, [Optional] Func<Dictionary<string, ALBBMKANDAF>, (ALBMIKCECHI, KGAPFDAFEHM<Dictionary<string, GKHPBLLBAIL<Texture2D>>>)> CLMFFEADJPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7A9FE10", Offset = "0x7A9EE10", VA = "0x187A9FE10")]
	private bool LACMOOMOOMG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7A9EF70", Offset = "0x7A9DF70", VA = "0x187A9EF70")]
	private ALBMIKCECHI JJNLMMKCDGE(bool EEAEBGKMHGP, List<OEHMJDNAMGC> HIIHIMPLCJH, int[] KIOKNKHEIMB, Func<int, NNEHDADGDHM> EPEKJNBCPPI, bool AOHPOOECADH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7A9D900", Offset = "0x7A9C900", VA = "0x187A9D900")]
	[IteratorStateMachine(typeof(INDCFPMDHON))]
	private IEnumerator<NFNODNEANBN> IHJJGGANBOI(bool EEAEBGKMHGP, List<OEHMJDNAMGC> HIIHIMPLCJH, int[] KIOKNKHEIMB, Func<int, NNEHDADGDHM> EPEKJNBCPPI, DCAOEHPAGLN BFBOFDJKBCP, Material KCFANBEOAGC, List<ALBMIKCECHI> NJGJCFNACDF, bool LKECFFEIFNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7A9C070", Offset = "0x7A9B070", VA = "0x187A9C070")]
	private void HEJHKKKCOBB(List<OEHMJDNAMGC> HIIHIMPLCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7AA0FA0", Offset = "0x7A9FFA0", VA = "0x187AA0FA0")]
	private ALBMIKCECHI NAPCODBGHCH(List<OEHMJDNAMGC> HIIHIMPLCJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7A99170", Offset = "0x7A98170", VA = "0x187A99170")]
	private OLILOOIADED CCFBPLFLACH(List<OEHMJDNAMGC> HIIHIMPLCJH, int GKGMDAMJCNF, bool EEAEBGKMHGP, NNEHDADGDHM JGGBDGJFMCJ, bool CJNICDHMFGF, DCAOEHPAGLN BFBOFDJKBCP, Material KCFANBEOAGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7AA16F0", Offset = "0x7AA06F0", VA = "0x187AA16F0", Slot = "27")]
	public void OCOHJLBJOOC(OAIBHFEEBFF OHKLPMGKCNP, float OHLIHBDBKCE, bool NGGBHLHDOAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7A9EE30", Offset = "0x7A9DE30", VA = "0x187A9EE30", Slot = "29")]
	public void IPEJBKIPPIA(OGHEPKGNCBA LHCBLABBENF, float OHLIHBDBKCE, bool CNDBMNGCPEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7A9F690", Offset = "0x7A9E690", VA = "0x187A9F690", Slot = "30")]
	public void JMAGOFIIPAD(OJGFLCIKIFC GKKKGOHEELC, float OHLIHBDBKCE, bool ONLNMKMBDBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7A9EF10", Offset = "0x7A9DF10", VA = "0x187A9EF10", Slot = "28")]
	public void JBIOIOBPKBN(bool MMPAHNIJNOD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7A9BD50", Offset = "0x7A9AD50", VA = "0x187A9BD50", Slot = "31")]
	public void GNAAJEMACEG(bool MMPAHNIJNOD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7A98AC0", Offset = "0x7A97AC0", VA = "0x187A98AC0", Slot = "32")]
	public void BDDPIPKHGLL(bool MMPAHNIJNOD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7A9A270", Offset = "0x7A99270", VA = "0x187A9A270")]
	private void CEGAJGCGDLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7AA11F0", Offset = "0x7AA01F0", VA = "0x187AA11F0")]
	private void NDGPIDGGJIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7AA0A00", Offset = "0x7A9FA00", VA = "0x187AA0A00")]
	private void MFDANGMPDKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7A9CA20", Offset = "0x7A9BA20", VA = "0x187A9CA20", Slot = "25")]
	public void HIHMNPDOBII(AvatarFaceShape NOLJPELCPGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7A9AFE0", Offset = "0x7A99FE0", VA = "0x187A9AFE0", Slot = "26")]
	public void DPPAKFIKPJJ(AvatarBodyShape JNNFLNPDLLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2304AC0", Offset = "0x2303AC0", VA = "0x182304AC0", Slot = "33")]
	public void BDGEOCHDEIN(ABOJDNCODIG AEHFOHDJDBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7A9CD30", Offset = "0x7A9BD30", VA = "0x187A9CD30", Slot = "35")]
	public void ICPFDPMIICI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7A9FF10", Offset = "0x7A9EF10", VA = "0x187A9FF10", Slot = "38")]
	public void LFKPNLFGGDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7AA1480", Offset = "0x7AA0480", VA = "0x187AA1480", Slot = "34")]
	public void NNHKGAFNBNJ(bool APHODKKNMPK, bool BKPHMFMOBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7AA22F0", Offset = "0x7AA12F0", VA = "0x187AA22F0")]
	private void PJPABNLDLPG(SkinnedMeshRenderer CENGCBFBEJP, int GKGMDAMJCNF, Mesh PEPFHNJFNIL, List<Material> OKFFFEHEGBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7A95FB0", Offset = "0x7A94FB0", VA = "0x187A95FB0")]
	private static Material ACNIMILDKCE(Dictionary<GLNGPPKPMIG, Material> KEMDFPKPCOM, Material OJHFGKAFIEJ, FOHOLFICGPJ GMLOOFHADHO, BEEBHKAMNNL PGOOBBKNDOF, LEMFDNDBDJC BDNPFHIBMNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7A9D800", Offset = "0x7A9C800", VA = "0x187A9D800")]
	private static FOHOLFICGPJ IGLIHIPGIPB(OEHMJDNAMGC DADFPFCEPAK, int FPNNGFNMBMA)
	{
		return default(FOHOLFICGPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7AA17D0", Offset = "0x7AA07D0", VA = "0x187AA17D0")]
	private void ODEGJEIOILA(int KMLNOHKPNFG, Material CANJBFKPEMF, OEHMJDNAMGC DADFPFCEPAK, [Out] Texture2D MGPEMBAGNBN, [Out] Vector4 ANNENBEHPMI, [Out] Texture2D KMMLDOAJCOM, [Out] Texture2D BNKFBNNLFHF, [Out] Texture2D IEHNFAOCACL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7A98130", Offset = "0x7A97130", VA = "0x187A98130")]
	private void ALKFAAJACAO(int KMLNOHKPNFG, Material CANJBFKPEMF, OEHMJDNAMGC DADFPFCEPAK, [Out] Color BCJBJCJEEOB, [Out] Color DENCMJLNDEA, [Out] Color GNOGEJFGEHI, [Out] Color EMEEOLPKGGL, [Out] Color MEAICLBLNAP, [Out] Color MOIBEGCKKBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7AA1D40", Offset = "0x7AA0D40", VA = "0x187AA1D40")]
	private bool OHLIFBPBBLK(Material CANJBFKPEMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7AA0A80", Offset = "0x7A9FA80", VA = "0x187AA0A80")]
	private static Material MFGBLABBHNG(int KMLNOHKPNFG, NCKDDFHNPMI DADFPFCEPAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7A9AAB0", Offset = "0x7A99AB0", VA = "0x187A9AAB0")]
	private static BEEBHKAMNNL DKELNJIGIDP(OEHMJDNAMGC DADFPFCEPAK, int FPNNGFNMBMA)
	{
		return default(BEEBHKAMNNL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7A9BDB0", Offset = "0x7A9ADB0", VA = "0x187A9BDB0")]
	private static void GOJDBMHGHLN(Dictionary<string, List<GLNGPPKPMIG>> DHPEMHCCIBM, OEHMJDNAMGC DNPMBJLIGEP, Material OJHFGKAFIEJ, FOHOLFICGPJ FKAIEBDGNCN, BEEBHKAMNNL IHIJDFFNDNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7AA0230", Offset = "0x7A9F230", VA = "0x187AA0230")]
	private static SkinnedMeshRenderer MBIOPHJMPOL(Transform DJEJFBBPOLK, Transform GIKHOJKDBHI, SkinnedMeshRenderer[] GMCMJGGCAFJ, int GKGMDAMJCNF, NNEHDADGDHM JGGBDGJFMCJ, bool EEAEBGKMHGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7AA25B0", Offset = "0x7AA15B0", VA = "0x187AA25B0")]
	public KPPCNHOKIIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7A985F0", Offset = "0x7A975F0", VA = "0x187A985F0")]
	public void ANJKPBDKBKO([In] AIIHNJMODJF FLFKJIOMIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7A9B990", Offset = "0x7A9A990", VA = "0x187A9B990")]
	public void LMDIFILKIOE([In] HMAAKGCFJIK EFGPLJKHBGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7A9BD30", Offset = "0x7A9AD30", VA = "0x187A9BD30", Slot = "5")]
	public void GMCJHMAKKJD(int GKGMDAMJCNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7A9B5D0", Offset = "0x7A9A5D0", VA = "0x187A9B5D0", Slot = "10")]
	public void FEDEOKJHDPN(GFLLLLCANOK IHIJDFFNDNI, Texture2D BFGBBIJNNHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A680", VA = "0x180A0B680")]
	public static bool MJMPPGBOJIO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7AA0880", Offset = "0x7A9F880", VA = "0x187AA0880", Slot = "11")]
	public bool MDFLBHLKJAF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7A9B0A0", Offset = "0x7A9A0A0", VA = "0x187A9B0A0", Slot = "9")]
	public void EHAKGAGPGAI(MCGIHJPPCCH FKAIEBDGNCN, Color? NGGKCKILBNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7A9F760", Offset = "0x7A9E760", VA = "0x187A9F760")]
	private void JOJLFPFEINN(Action JDMMPPCKHLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7AA20D0", Offset = "0x7AA10D0", VA = "0x187AA20D0", Slot = "6")]
	public void PBBPFKMBGJB(ALBBMKANDAF HNMCGDBFDGH, Texture MOBCKEBGPFC, Color CHOGCLCILKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2597530", Offset = "0x2596530", VA = "0x182597530", Slot = "7")]
	public void DMJLKLMFLHD(bool LKECFFEIFNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x132AA20", Offset = "0x1329A20", VA = "0x18132AA20", Slot = "8")]
	public void AIBLNAAHMKF(NAFFPEBCHPI PMLCGCAHNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7A9AC70", Offset = "0x7A99C70", VA = "0x187A9AC70", Slot = "16")]
	public void DMLDIIKDBJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7A9B540", Offset = "0x7A9A540", VA = "0x187A9B540", Slot = "36")]
	public void FDMFMABKNNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7A9DA20", Offset = "0x7A9CA20", VA = "0x187A9DA20", Slot = "37")]
	public void IMAHGOINCBB([Optional] HMAKLDEGKBC OGABAGJHKNB, [Optional] bool? AGLEHBFANOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7A9F550", Offset = "0x7A9E550", VA = "0x187A9F550")]
	private bool JLLBGKMGEAA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7A9CAE0", Offset = "0x7A9BAE0", VA = "0x187A9CAE0", Slot = "21")]
	public bool HKGLBHMPOCG(DJMKKMKOHOE.KHMINOCKMDE PPBPOBKGLON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7A9F890", Offset = "0x7A9E890", VA = "0x187A9F890")]
	private void KDBPHKMPPLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7AA1490", Offset = "0x7AA0490", VA = "0x187AA1490")]
	private void NOPIBLIGNMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7AA1BE0", Offset = "0x7AA0BE0", VA = "0x187AA1BE0")]
	private static void OELFCHAKDMH(Dictionary<GLNGPPKPMIG, Material> KEMDFPKPCOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7AA00D0", Offset = "0x7A9F0D0", VA = "0x187AA00D0")]
	private static void LNHBEJIKCOC(Dictionary<Renderer, DCAOEHPAGLN> JGEDDGOCJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7AA0DA0", Offset = "0x7A9FDA0", VA = "0x187AA0DA0")]
	private void MOMLGHGHKAB(SkinnedMeshRenderer[] GMCMJGGCAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7AA1650", Offset = "0x7AA0650", VA = "0x187AA1650")]
	private void OBKENODFJNH(SkinnedMeshRenderer KMAINCIGCMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7AA0AD0", Offset = "0x7A9FAD0", VA = "0x187AA0AD0")]
	private void MNCEHLGEMCP(List<KBJDIMPKBHI> HOFMPDNMMNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7AA1270", Offset = "0x7AA0270", VA = "0x187AA1270")]
	private void NFGNFEFIHCM(Dictionary<string, GKHPBLLBAIL<Texture2D>> DHPEMHCCIBM, bool HPAPGOPEPHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7AA0830", Offset = "0x7A9F830", VA = "0x187AA0830")]
	private void MCGAJABICJK(Dictionary<string, List<GLNGPPKPMIG>> DHPEMHCCIBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7A9FA60", Offset = "0x7A9EA60", VA = "0x187A9FA60")]
	private void KDMOFAFAAMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7AA14C0", Offset = "0x7AA04C0", VA = "0x187AA14C0")]
	private void OAACECFAIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7A9E870", Offset = "0x7A9D870", VA = "0x187A9E870")]
	private void IMCBDOLMLIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7AA0CB0", Offset = "0x7A9FCB0", VA = "0x187AA0CB0")]
	private void MOABECDHBCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7AA1FA0", Offset = "0x7AA0FA0", VA = "0x187AA1FA0")]
	private void OLHIFDCNAIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7A9A610", Offset = "0x7A99610", VA = "0x187A9A610")]
	private void CLHBCHLPMGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7A9A540", Offset = "0x7A99540", VA = "0x187A9A540")]
	private void CJFIMONNIAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7AA2150", Offset = "0x7AA1150", VA = "0x187AA2150")]
	private void PIOIFLENEBA(bool KEMGAMGEOGD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7A96110", Offset = "0x7A95110", VA = "0x187A96110")]
	private void ADEKJEGHAIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7A9FD30", Offset = "0x7A9ED30", VA = "0x187A9FD30")]
	private void KOPFBGKGPPE(bool KEMGAMGEOGD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7A9BA10", Offset = "0x7A9AA10", VA = "0x187A9BA10")]
	private void GHAGFEOHPJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7A9D300", Offset = "0x7A9C300", VA = "0x187A9D300")]
	private void IFJBJDIBEEP(Material KCFANBEOAGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7A9FBB0", Offset = "0x7A9EBB0", VA = "0x187A9FBB0")]
	private void KNDDBHAJDDH(Material KCFANBEOAGC, Color FFKDKFFFLJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7A9A2F0", Offset = "0x7A992F0", VA = "0x187A9A2F0")]
	private void CGBAJANPKDH(Material KCFANBEOAGC, Color FFKDKFFFLJI, Color PCNBINHACDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7A9A760", Offset = "0x7A99760", VA = "0x187A9A760")]
	private void COHLDCGBLHO(Material KCFANBEOAGC, Color BCJBJCJEEOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7A9D110", Offset = "0x7A9C110", VA = "0x187A9D110")]
	private void IDEJADEEPCC(Material KCFANBEOAGC, Texture2D BFGBBIJNNHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7A98B20", Offset = "0x7A97B20", VA = "0x187A98B20")]
	private void BIFKOANKICK(Material KCFANBEOAGC, Texture LJGGMGAEHBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7A9CBD0", Offset = "0x7A9BBD0", VA = "0x187A9CBD0")]
	private void IBBNNJCLPEJ(Action<DCAOEHPAGLN> GBFPEDHKGBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7A98940", Offset = "0x7A97940", VA = "0x187A98940")]
	private void BBIKNLDPMGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7A98D50", Offset = "0x7A97D50", VA = "0x187A98D50")]
	private void CAPNFLHKIKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7AA0460", Offset = "0x7A9F460", VA = "0x187AA0460")]
	private void MCBAKJPICOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7A9C690", Offset = "0x7A9B690", VA = "0x187A9C690")]
	public void HGPFPPHDEON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7A9B990", Offset = "0x7A9A990", VA = "0x187A9B990", Slot = "4")]
	private void GAFHEDEAHLB([In] HMAAKGCFJIK EFGPLJKHBGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7A9CB90", Offset = "0x7A9BB90", VA = "0x187A9CB90")]
	[CompilerGenerated]
	private HPIGCMLNLFB HMMEOJBCOED(OEHMJDNAMGC NOOBIPOJNNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7A98C90", Offset = "0x7A97C90", VA = "0x187A98C90")]
	[CompilerGenerated]
	private void BKNBFAFHIOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7A9B960", Offset = "0x7A9A960", VA = "0x187A9B960")]
	[CompilerGenerated]
	private void FKAEIOMLNMK(DCAOEHPAGLN FHHMDKONHLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x7A9A9F0", Offset = "0x7A999F0", VA = "0x187A9A9F0")]
	[CompilerGenerated]
	private void DEMEKEIKKIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7AA0D80", Offset = "0x7A9FD80", VA = "0x187AA0D80")]
	[CompilerGenerated]
	private void MOICDOMNIKK(DCAOEHPAGLN FHHMDKONHLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7A9CB00", Offset = "0x7A9BB00", VA = "0x187A9CB00")]
	[CompilerGenerated]
	private void HLPBFHELLMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7AA14A0", Offset = "0x7AA04A0", VA = "0x187AA14A0")]
	[CompilerGenerated]
	private void NPAALKFEGOL(DCAOEHPAGLN FHHMDKONHLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7AA2040", Offset = "0x7AA1040", VA = "0x187AA2040")]
	[CompilerGenerated]
	private void PAKCLIKCHPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7A95F80", Offset = "0x7A94F80", VA = "0x187A95F80")]
	[CompilerGenerated]
	private void ACAACAIBPFM(DCAOEHPAGLN FHHMDKONHLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7A9B8D0", Offset = "0x7A9A8D0", VA = "0x187A9B8D0")]
	[CompilerGenerated]
	private void FJIPKGHFBEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7A98D20", Offset = "0x7A97D20", VA = "0x187A98D20")]
	[CompilerGenerated]
	private void BMIOMOKEKIM(DCAOEHPAGLN FHHMDKONHLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7AA2230", Offset = "0x7AA1230", VA = "0x187AA2230")]
	[CompilerGenerated]
	private void PJNFIHFEEBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7A9B5A0", Offset = "0x7A9A5A0", VA = "0x187A9B5A0")]
	[CompilerGenerated]
	private void FDNJOEKIBGM(DCAOEHPAGLN FHHMDKONHLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7AA13F0", Offset = "0x7AA03F0", VA = "0x187AA13F0")]
	[CompilerGenerated]
	private void NNFLIFBIJCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7A9AA80", Offset = "0x7A99A80", VA = "0x187A9AA80")]
	[CompilerGenerated]
	private void DINKMLIODNC(DCAOEHPAGLN FHHMDKONHLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7A9F810", Offset = "0x7A9E810", VA = "0x187A9F810")]
	[CompilerGenerated]
	private void KBNFDLPLIMO(KeyValuePair<string, GKHPBLLBAIL<Texture2D>> MKENHCDLPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7AA2140", Offset = "0x7AA1140", VA = "0x187AA2140")]
	[CompilerGenerated]
	private void PHCIFEKAJNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7A9FEE0", Offset = "0x7A9EEE0", VA = "0x187A9FEE0")]
	[CompilerGenerated]
	private void LFGJJANLOBC(DCAOEHPAGLN FHHMDKONHLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7AA2030", Offset = "0x7AA1030", VA = "0x187AA2030")]
	[CompilerGenerated]
	private void OMIFPODPAGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7AA22C0", Offset = "0x7AA12C0", VA = "0x187AA22C0")]
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
		[ANKANEOPOFH(JINCPHMLLKA.Self, false, false, false)]
		[SerializeField]
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
		[SerializeField]
		[FormerlySerializedAs("MaxScaleValues")]
		private Vector3 ScaleValuesAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[Header("Positional Offset")]
		[FormerlySerializedAs("MinLocalPositionalOffset")]
		[SerializeField]
		private Vector3 PositionalOffsetAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[FormerlySerializedAs("MaxLocalPositionOffset")]
		[SerializeField]
		private Vector3 PositionalOffsetAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private Vector3? AMLCIJLPALA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private bool NGOJKHPONJC;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7A8F170", Offset = "0x7A8E170", VA = "0x187A8F170", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7A8F7A0", Offset = "0x7A8E7A0", VA = "0x187A8F7A0", Slot = "4")]
		public void UpdateController(float CJIPMCGKHCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xC19120", Offset = "0xC18120", VA = "0x180C19120", Slot = "6")]
		public void SetEnabled(bool OHLIHBDBKCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7A8F250", Offset = "0x7A8E250", VA = "0x187A8F250")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7A8FC60", Offset = "0x7A8EC60", VA = "0x187A8FC60")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7A8FFE0", Offset = "0x7A8EFE0", VA = "0x187A8FFE0", Slot = "4")]
		public void UpdateController(float CJIPMCGKHCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x13FC510", Offset = "0x13FB510", VA = "0x1813FC510", Slot = "6")]
		public void SetEnabled(bool OHLIHBDBKCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7A8FD00", Offset = "0x7A8ED00", VA = "0x187A8FD00")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7A90AA0", Offset = "0x7A8FAA0", VA = "0x187A90AA0")]
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
	private Transform CFIGMNJOICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private Transform NLPGKNNMNFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private DJNEMBCDFBB IKEDLLJHPCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private Material INOPPGLPKEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private SkinnedMeshRenderer[] IJFBAEOOKCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private readonly List<Material> HCIADMPJHDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private GMCHJHHGEBP LIHDPFOGBBH;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public GCADBNOOJOM OOHBJBGFLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570", Slot = "9")]
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
		[Cpp2IlInjected.Address(RVA = "0x7AAB9A0", Offset = "0x7AAA9A0", VA = "0x187AAB9A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool DINPHDIMOPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7AAB1F0", Offset = "0x7AAA1F0", VA = "0x187AAB1F0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x7AA9CB0", Offset = "0x7AA8CB0", VA = "0x187AA9CB0")]
	public void ANJKPBDKBKO([In] DJNEMBCDFBB KLDHMLLFEDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x7AA9C10", Offset = "0x7AA8C10", VA = "0x187AA9C10")]
	public void DGFLOGPPDFF([In] BJABNEMFONN JOIIFDKKKIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x7AAAD10", Offset = "0x7AA9D10", VA = "0x187AAAD10", Slot = "6")]
	public void DCINBHCDCKF(FEBJLGDBOMJ LINHHCIFANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x7AAB3F0", Offset = "0x7AAA3F0", VA = "0x187AAB3F0")]
	private Vector2 GIADCGJDPOI(Vector2 MEKPPHHJOHD)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x7AA9D80", Offset = "0x7AA8D80", VA = "0x187AA9D80")]
	public void BJPPMMGMBIH([In] MEGLFPKOFKP JOIIFDKKKIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7AABA30", Offset = "0x7AAAA30", VA = "0x187AABA30")]
	private void PKGADBJMEDN(JNCABIABPCN LDKGBCHHGEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7AAB520", Offset = "0x7AAA520", VA = "0x187AAB520")]
	private void LOINKDEDGPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x7AAB370", Offset = "0x7AAA370", VA = "0x187AAB370")]
	private void FNLCIAJLGBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7AAB370", Offset = "0x7AAA370", VA = "0x187AAB370", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7AAC160", Offset = "0x7AAB160", VA = "0x187AAC160")]
	public CGBJAHEPEBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7AA9C10", Offset = "0x7AA8C10", VA = "0x187AA9C10", Slot = "5")]
	private void AHHCJBBCMKK([In] BJABNEMFONN JOIIFDKKKIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7AAB3E0", Offset = "0x7AAA3E0", VA = "0x187AAB3E0", Slot = "7")]
	private void FLGLODCEAML([In] MEGLFPKOFKP JOIIFDKKKIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x7AABA20", Offset = "0x7AAAA20", VA = "0x187AABA20")]
	[CompilerGenerated]
	internal static float NJGFENEOFPP(float OHLIHBDBKCE, float LJOCPPONLJF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7AAB8B0", Offset = "0x7AAA8B0", VA = "0x187AAB8B0")]
	[CompilerGenerated]
	internal static void MFCPHMLEFIG(Vector2 KIBNLFAIDNK, Vector2 GDKPINFECCI, Vector2 CFNMLMNHCMF, Vector2 COJGDIKBGKB, Vector2 JNIBMOMFMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7AAB490", Offset = "0x7AAA490", VA = "0x187AAB490")]
	[CompilerGenerated]
	internal static (float, float) JDJMLPIPKFL(float LMDEMKCNJBJ)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7AAB450", Offset = "0x7AAA450", VA = "0x187AAB450")]
	[CompilerGenerated]
	internal static Vector4 HKPJJFDBNKC(Vector2 EPCLGOKLIPO, Vector2 HDLKNIPAJGK)
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
		private float OONJILLHKNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private bool NGOJKHPONJC;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7AA6310", Offset = "0x7AA5310", VA = "0x187AA6310", Slot = "4")]
		public void UpdateController(float CJIPMCGKHCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x1677450", Offset = "0x1676450", VA = "0x181677450", Slot = "6")]
		public void SetEnabled(bool OHLIHBDBKCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x7AA6B80", Offset = "0x7AA5B80", VA = "0x187AA6B80")]
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

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
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

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x7AA6BB0", Offset = "0x7AA5BB0", VA = "0x187AA6BB0")]
		public void EEBICEODLFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7AA6CD0", Offset = "0x7AA5CD0", VA = "0x187AA6CD0")]
		public int FNAPAHPDNME(int MKDGMAIADPH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public AvatarHandDisplaySettings()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class HDJDJLAMOAI : HEGHJMBLKOO
{
	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7AB2D70", Offset = "0x7AB1D70", VA = "0x187AB2D70", Slot = "22")]
	public override float GMPOCHCOCNJ()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x7AB2DC0", Offset = "0x7AB1DC0", VA = "0x187AB2DC0")]
	public HDJDJLAMOAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class HEGHJMBLKOO : EKFIOJKBHPO
{
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private static int ABCGPAEDGJN;

	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private static int KFFJKPAFGNL;

	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private static int BBODBJBHIOG;

	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private static int FCFJKGNMFLP;

	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private static int FMLJEDOIIMA;

	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private static int IJEAEMGBKKJ;

	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private static int GADJOOHMLJK;

	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private static int[] AIJAFLGJILC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private DMEHENLMGJH IKEDLLJHPCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private MMKICHODPJH INHFDGIMPGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private int ODFCGHCJBGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private float KHAIMLCJHFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	protected Animator MILKLFGDHHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	protected bool ICHDAIFJPGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	protected AvatarConfiguration JGKNHDNFNIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	protected int NLJAJPIBBIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private int LACMCHAHLAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private int GNLEJDGMEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private bool HJAGCICBIHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private OKECFPHNFBM GHCLEMFBJEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private int HNFBBNCHPKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private float LGDBNAJHNPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private AvatarHandDisplaySettings JANFNOBCGGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private BLMBMEMIHNO MCCGPEKDGIF;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Transform ELCODABBAGK
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public Vector3 KAABAPECGIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x166CA00", Offset = "0x166BA00", VA = "0x18166CA00")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x166CBD0", Offset = "0x166BBD0", VA = "0x18166CBD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Quaternion CAFBADJHJAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xCFC9D0", Offset = "0xCFB9D0", VA = "0x180CFC9D0")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0xF26B40", Offset = "0xF25B40", VA = "0x180F26B40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool GOGOMIOHLME
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7AB37B0", Offset = "0x7AB27B0", VA = "0x187AB37B0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7AB3970", Offset = "0x7AB2970", VA = "0x187AB3970")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public Vector3 EMENJINFHHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x7AB2E30", Offset = "0x7AB1E30", VA = "0x187AB2E30", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x7AB30A0", Offset = "0x7AB20A0", VA = "0x187AB30A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public Quaternion HJGKPPALEPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x7AB3040", Offset = "0x7AB2040", VA = "0x187AB3040", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7AB30C0", Offset = "0x7AB20C0", VA = "0x187AB30C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public ACKOLLANMDJ CFAKDOIEGPC
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xB75D90", Offset = "0xB74D90", VA = "0x180B75D90", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(ACKOLLANMDJ);
		}
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xB75550", Offset = "0xB74550", VA = "0x180B75550", Slot = "4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public ACKOLLANMDJ PFHACCAHHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x24689A0", Offset = "0x24679A0", VA = "0x1824689A0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(ACKOLLANMDJ);
		}
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x2467DC0", Offset = "0x2466DC0", VA = "0x182467DC0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public float MDAKCDIKJOD
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x14963B0", Offset = "0x14953B0", VA = "0x1814963B0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0xF36260", Offset = "0xF35260", VA = "0x180F36260", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool DNOHGGGLGMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7AB3730", Offset = "0x7AB2730", VA = "0x187AB3730")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool NCOBFILDJDP
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x7AB30E0", Offset = "0x7AB20E0", VA = "0x187AB30E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool ODAEEBKKKFF
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x7AB3130", Offset = "0x7AB2130", VA = "0x187AB3130")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool IEFMFOLOPKL
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x7AB3720", Offset = "0x7AB2720", VA = "0x187AB3720")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x7AB2E50", Offset = "0x7AB1E50", VA = "0x187AB2E50", Slot = "21")]
	public void ANJKPBDKBKO(DMEHENLMGJH KLDHMLLFEDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x7AB3740", Offset = "0x7AB2740", VA = "0x187AB3740")]
	public void NPJOAFGLBEI(MMKICHODPJH AGPMMEOIJKA, AvatarHandDisplaySettings OHPJOMKGGBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x7AB3320", Offset = "0x7AB2320", VA = "0x187AB3320", Slot = "12")]
	public void JKDCAAMODLN(bool MIHGKLOAIPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x7AB33B0", Offset = "0x7AB23B0", VA = "0x187AB33B0", Slot = "11")]
	public void JOPMFAEKJFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x14963B0", Offset = "0x14953B0", VA = "0x1814963B0", Slot = "22")]
	public virtual float GMPOCHCOCNJ()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x7AB37E0", Offset = "0x7AB27E0", VA = "0x187AB37E0")]
	private int PFNAIGOJIMJ(ACKOLLANMDJ EJEBDHOKGAM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x7AB3160", Offset = "0x7AB2160", VA = "0x187AB3160")]
	private void JFOHEHKJEEK(int PHIKMMCANBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x7AB3790", Offset = "0x7AB2790", VA = "0x187AB3790", Slot = "13")]
	public bool OMFFKBHGPOJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x7AB2E20", Offset = "0x7AB1E20", VA = "0x187AB2E20", Slot = "14")]
	public bool AENLDHPCDDH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x7AB2FF0", Offset = "0x7AB1FF0", VA = "0x187AB2FF0")]
	private ACKOLLANMDJ BPLCONLGBMM()
	{
		return default(ACKOLLANMDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x1D7A320", Offset = "0x1D79320", VA = "0x181D7A320", Slot = "15")]
	public void DCPHJHIKMJN(bool MIHGKLOAIPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7AB30F0", Offset = "0x7AB20F0", VA = "0x187AB30F0", Slot = "10")]
	public void HPGKJHEKAMN(int PHIKMMCANBH, float CGBONFJILMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7AB3140", Offset = "0x7AB2140", VA = "0x187AB3140", Slot = "8")]
	public void IMNCKNLNKCG(OKECFPHNFBM IDAKFFICKHC, bool CBHHPIGGAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x7AB30D0", Offset = "0x7AB20D0", VA = "0x187AB30D0", Slot = "9")]
	public void HKANKMCPKMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7AB3050", Offset = "0x7AB2050", VA = "0x187AB3050", Slot = "16")]
	public void COOCPPOKIJB(Transform JHDAOHEONAC, Vector3 MKBIPJMOOAN, Quaternion IADANCLOJAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x7AB3C70", Offset = "0x7AB2C70", VA = "0x187AB3C70")]
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
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public NCKDDFHNPMI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public List<KBJDIMPKBHI> prefabHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public List<KBJDIMPKBHI> materialHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public GKHPBLLBAIL<Material[]> loadMaterialsHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public GKHPBLLBAIL<HAJFBGNLPCB> loadPrefabHandle;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public OFGNCOPANGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x7AB6620", Offset = "0x7AB5620", VA = "0x187AB6620")]
		internal HPIGCMLNLFB DPKBNDMOCLL(string error)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	public ALBBMKANDAF JAJLHFMKFFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	public HAJFBGNLPCB HMHHKJPBFJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private GKHPBLLBAIL<HAJFBGNLPCB> IFAEJMIBMFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private GKHPBLLBAIL<Material[]> JBMBHBJAIKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	public Material[] JNBBNJHINOG;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool FJPOBBHMHEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0xA1DF60", Offset = "0xA1CF60", VA = "0x180A1DF60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0xA1DD80", Offset = "0xA1CD80", VA = "0x180A1DD80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public DJMKKMKOHOE.KHMINOCKMDE PHBMKMKLKMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x9F1780", Offset = "0x9F0780", VA = "0x1809F1780")]
		[CompilerGenerated]
		get
		{
			return default(DJMKKMKOHOE.KHMINOCKMDE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x9F6800", Offset = "0x9F5800", VA = "0x1809F6800")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x7AB63E0", Offset = "0x7AB53E0", VA = "0x187AB63E0")]
	public NCKDDFHNPMI(LEMFDNDBDJC OJOHFHDBACP, ALBBMKANDAF LGIKDEFBHHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x7AB5A70", Offset = "0x7AB4A70", VA = "0x187AB5A70", Slot = "6")]
	public override HPIGCMLNLFB LKGBAHIGMNB(List<KBJDIMPKBHI> MKIPMDAKLBD, List<KBJDIMPKBHI> BBGGIAKGEEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x7AB52A0", Offset = "0x7AB42A0", VA = "0x187AB52A0")]
	public HPIGCMLNLFB CMGDAOOLDEM(List<KBJDIMPKBHI> MKIPMDAKLBD, List<KBJDIMPKBHI> BBGGIAKGEEL, GKHPBLLBAIL<Material[]> JBMBHBJAIKN, [Optional] GKHPBLLBAIL<HAJFBGNLPCB> ENBIBBBCMFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x7AB5F30", Offset = "0x7AB4F30", VA = "0x187AB5F30")]
	public (GKHPBLLBAIL<Material[]>, GKHPBLLBAIL<HAJFBGNLPCB>) MDCJCLPFFIJ(List<KBJDIMPKBHI> MKIPMDAKLBD, List<KBJDIMPKBHI> BBGGIAKGEEL)
	{
		return default((GKHPBLLBAIL<Material[]>, GKHPBLLBAIL<HAJFBGNLPCB>));
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x7AB5940", Offset = "0x7AB4940", VA = "0x187AB5940", Slot = "7")]
	public override OLNAGKBEHCB LEBDIAJMBFP(uint GKGMDAMJCNF, AvatarSkinnedMeshBoneOrderRemapsData PCHECJMOKMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x7AB5090", Offset = "0x7AB4090", VA = "0x187AB5090")]
	public OLNAGKBEHCB AKIELJOOAOC(GameObject CFDBIKMCOBM, uint GKGMDAMJCNF, bool GCLDNCLHPBC, bool EMLACCABLNJ, AvatarSkinnedMeshBoneOrderRemapsData PCHECJMOKMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x7AB55B0", Offset = "0x7AB45B0", VA = "0x187AB55B0")]
	public static bool EFFHBPIJODE(Renderer[] GMCMJGGCAFJ, string FJFIBOCIHMF, [Out] Renderer BLBNOAMHOCI, [Out] Renderer EJPCGAKHDCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x7AB6390", Offset = "0x7AB5390", VA = "0x187AB6390", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x7AB62C0", Offset = "0x7AB52C0", VA = "0x187AB62C0")]
	private (GKHPBLLBAIL<HAJFBGNLPCB>, GKHPBLLBAIL<Material[]>) PEPJBMBMKAN()
	{
		return default((GKHPBLLBAIL<HAJFBGNLPCB>, GKHPBLLBAIL<Material[]>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7AB5920", Offset = "0x7AB4920", VA = "0x187AB5920")]
	[CompilerGenerated]
	private void IEKDGFMIENC(HAJFBGNLPCB OBOOAPELMPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x9F46C0", Offset = "0x9F36C0", VA = "0x1809F46C0")]
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
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		[SerializeField]
		[ANKANEOPOFH(JINCPHMLLKA.Self, false, false, false)]
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
		private Vector3 HJEIFAIOFNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private Vector3 NKNAJLDJHJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private Vector3 PINFALKKIMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private Matrix4x4 JEBMBPBKBDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private bool NGOJKHPONJC;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x7AA71B0", Offset = "0x7AA61B0", VA = "0x187AA71B0", Slot = "4")]
		public void UpdateController(float CJIPMCGKHCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7AA71A0", Offset = "0x7AA61A0", VA = "0x187AA71A0", Slot = "6")]
		public void SetEnabled(bool OHLIHBDBKCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x7AA6D40", Offset = "0x7AA5D40", VA = "0x187AA6D40")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x7AA7870", Offset = "0x7AA6870", VA = "0x187AA7870")]
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
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	[ReadOnly]
	public PLEFCEKBJLA NFBNCDAFDCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	[ReadOnly]
	public int OGHFEPGBEDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	public EBEEGCNLDFE GAJLKEHBMPI;

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7AA8C90", Offset = "0x7AA7C90", VA = "0x187AA8C90", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[NativeContainer]
[HJNCDIOGCJG]
public struct EBEEGCNLDFE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public NativeArray<Vector3> JAIBDMKDPON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public NativeArray<Vector3> COEAFKGHHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public NativeArray<Vector4> IABDNJIKDAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public NativeArray<Vector2> HJOLBLABKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public NativeArray<Vector2> NIIIGPHODFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public NativeArray<Vector2> GENNKFIGGKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public NativeArray<Vector2> PHAHDPDBMHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	public NativeArray<Color> ANJLCAODDFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	public NativeArray<int> HECOEAMAHLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public NativeArray<int> KAODBKFLMFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private NativeArray<int> LPPAPOBKIEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private NativeArray<int> CNHHIFNMEHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public NativeArray<int> OLKBDAMMBPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	public NativeArray<int> MNAAOOIJBGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	public NativeArray<int> FLLPPOBDFDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	public NativeArray<BoneWeight> FMAFIGJMNBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private NativeArray<int> PMLCGCAHNGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private bool INLAHEKHDGL;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public int HINGJKKACPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x7AAEEF0", Offset = "0x7AADEF0", VA = "0x187AAEEF0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x7AAF4F0", Offset = "0x7AAE4F0", VA = "0x187AAF4F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int KMEAPHNMOHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x7AAEEE0", Offset = "0x7AADEE0", VA = "0x187AAEEE0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x7AAF7C0", Offset = "0x7AAE7C0", VA = "0x187AAF7C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int DCEBGGCGCON
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7AAF7D0", Offset = "0x7AAE7D0", VA = "0x187AAF7D0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x7AAF890", Offset = "0x7AAE890", VA = "0x187AAF890")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x7AAF930", Offset = "0x7AAE930", VA = "0x187AAF930")]
	public EBEEGCNLDFE(int DLOLGMFGMCF, int KHMLDEKGOGN, int OKKKFJPPJBM, int NCOLCNECKHG, Allocator NDFENJBGNOB, int LJHHEIGDCPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x7AAF480", Offset = "0x7AAE480", VA = "0x187AAF480")]
	public void HDLFLBKAKKF(int OHHMJGCBCKD, Vector3 IINHKHEMEHJ, Vector3 KLJKHLHNLGP, Vector4 LEMBKBGMCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x7AAF520", Offset = "0x7AAE520", VA = "0x187AAF520")]
	public void JDOKECODNDF(int OHHMJGCBCKD, BoneWeight NHAPOAOKIGM, NativeSlice<byte> AHOGHGIIKDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x7AAF500", Offset = "0x7AAE500", VA = "0x187AAF500")]
	public Color HPNCCIMOPBK(int OHHMJGCBCKD)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x7AAF7A0", Offset = "0x7AAE7A0", VA = "0x187AAF7A0")]
	public void NEMFFJAMDMK(int OHHMJGCBCKD, Color JKIBOICMIDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x7AAEF00", Offset = "0x7AADF00", VA = "0x187AAEF00")]
	public void CLCMMOGNEHO(byte KCDFLKCBIKJ, int OHHMJGCBCKD, Vector2 MGPLIBEEABL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x7AAF6C0", Offset = "0x7AAE6C0", VA = "0x187AAF6C0")]
	public void KEFDAKBCNKF(int OHHMJGCBCKD, int HIJGCANIBGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x7AAF100", Offset = "0x7AAE100", VA = "0x187AAF100")]
	public bool ENKKJEKEEDM(int KCDFLKCBIKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x7AAF6D0", Offset = "0x7AAE6D0", VA = "0x187AAF6D0")]
	public void MAAFKJANCOD(int GNDDIJKFHIM, int LLPAIMMACAP, int DDGBDMFPMAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x7AAF7E0", Offset = "0x7AAE7E0", VA = "0x187AAF7E0")]
	public int[] NOADIHPCDBG(int GNDDIJKFHIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x7AAF8A0", Offset = "0x7AAE8A0", VA = "0x187AAF8A0")]
	private NativeSlice<int> PPPFFNFFNHI(int GNDDIJKFHIM)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x7AAEF50", Offset = "0x7AADF50", VA = "0x187AAEF50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7AAF130", Offset = "0x7AAE130", VA = "0x187AAF130")]
	public Mesh GHGLJPLOCLP([Optional] string IGLCIHNNBAL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[HJNCDIOGCJG]
[DefaultMember("Item")]
[NativeContainer]
public struct PLEFCEKBJLA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	public NativeArray<Vector3> JAIBDMKDPON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public NativeArray<Vector3> COEAFKGHHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public NativeArray<Vector4> IABDNJIKDAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public NativeArray<Vector2> HJOLBLABKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public NativeArray<Vector2> NIIIGPHODFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public NativeArray<Vector2> GENNKFIGGKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public NativeArray<Vector2> PHAHDPDBMHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	public NativeArray<Color> ANJLCAODDFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public NativeArray<int> JPJKJJAOEGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public NativeArray<int> EHJMIACINHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public NativeArray<int> PNGIGHDAOAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public NativeArray<int> FNBEINLGMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	public NativeArray<bool> DLDPOELFKGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	public NativeArray<int> ACGKBLDNMLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	public NativeArray<int> FEEGHAKIELF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	public NativeArray<BoneWeight> ELLAKLBKHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private NativeArray<Matrix4x4> PCLMDBCJANG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private NativeArray<long> GNNBDHEBKFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private NativeArray<byte> CLPOAEFNCPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private NativeArray<int> FKGMGNGNNFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private NativeArray<int> GHJDMLGKFPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	public NativeArray<sbyte> KKENHNPIKCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public NativeArray<byte> BCOEJMPEBJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	private NativeArray<int> AJEMBDGPNIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private bool INLAHEKHDGL;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int KJJANABCHPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xD949C0", Offset = "0xD939C0", VA = "0x180D949C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public int PEMPMDIKECC
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xC1B860", Offset = "0xC1A860", VA = "0x180C1B860")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int LALFONMEHBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7AB74C0", Offset = "0x7AB64C0", VA = "0x187AB74C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int IDMIEAGHKAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x7AB74B0", Offset = "0x7AB64B0", VA = "0x187AB74B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7AB73B0", Offset = "0x7AB63B0", VA = "0x187AB73B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public int HINGJKKACPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7AB7110", Offset = "0x7AB6110", VA = "0x187AB7110")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x7AB73D0", Offset = "0x7AB63D0", VA = "0x187AB73D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public int IFCJDIOLHID
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x7AB7120", Offset = "0x7AB6120", VA = "0x187AB7120")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7AB7500", Offset = "0x7AB6500", VA = "0x187AB7500")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public EONPPOBGAOL DNJJAFNOEIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7AB6BD0", Offset = "0x7AB5BD0", VA = "0x187AB6BD0")]
		get
		{
			return default(EONPPOBGAOL);
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7AB73A0", Offset = "0x7AB63A0", VA = "0x187AB73A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public byte KDIIKCBKGNP
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x7AB73C0", Offset = "0x7AB63C0", VA = "0x187AB73C0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7AB74F0", Offset = "0x7AB64F0", VA = "0x187AB74F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public MDNDLIPPLEK OEMFNNCKNFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x7AB6BE0", Offset = "0x7AB5BE0", VA = "0x187AB6BE0")]
		get
		{
			return default(MDNDLIPPLEK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x7AB7510", Offset = "0x7AB6510", VA = "0x187AB7510")]
	public PLEFCEKBJLA(IList<Mesh> KBDLEKHEHMN, IList<Matrix4x4> DJFOKBGCCNJ, IList<bool> DLDPOELFKGB, byte GGNNMGDCEED, IList<byte[]> FONLLDDLMJH, IList<long> CKKFOPFCAOD, IList<bool> FNOHPKAEEOI, IList<int> ACGKBLDNMLK, IList<int> IGEECJJEHIN, IList<int> GNFGAAOIHNM, Allocator NDFENJBGNOB, EONPPOBGAOL BEBBIOKLEJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x7AB73E0", Offset = "0x7AB63E0", VA = "0x187AB73E0")]
	public EBEEGCNLDFE IPMEGOIAMCA(Allocator NDFENJBGNOB)
	{
		return default(EBEEGCNLDFE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x7AB7130", Offset = "0x7AB6130", VA = "0x187AB7130", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[HJNCDIOGCJG]
public class AFMLLJCKJLN : NFJIGMCMHCJ
{
	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x7AA6020", Offset = "0x7AA5020", VA = "0x187AA6020")]
	public PLEFCEKBJLA GDGODOCMIHG()
	{
		return default(PLEFCEKBJLA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x7A95AF0", Offset = "0x7A94AF0", VA = "0x187A95AF0")]
	public AFMLLJCKJLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct MDNDLIPPLEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public NativeSlice<Vector3> JAIBDMKDPON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public NativeSlice<Vector3> COEAFKGHHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public NativeSlice<Vector4> IABDNJIKDAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public NativeSlice<Vector2> HJOLBLABKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public NativeSlice<Vector2> NIIIGPHODFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	public NativeSlice<Vector2> GENNKFIGGKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public NativeSlice<Vector2> PHAHDPDBMHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public NativeSlice<Color> ANJLCAODDFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public NativeSlice<int> PNCBJEOGGML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public NativeSlice<int> FNBEINLGMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	public NativeSlice<BoneWeight> ELLAKLBKHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public NativeSlice<byte> LFFGEMJALDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public int LBBEGJCDLKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public Matrix4x4 HBJLJGGBCBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public long CHNHHCCDPAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	public NativeSlice<byte> AHOGHGIIKDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	public bool PJHKDJOGIAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	public int MIFGHABDOFH;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal readonly struct GLNGPPKPMIG : IEquatable<GLNGPPKPMIG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	internal readonly Material FNLBLGEDCDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	internal readonly FOHOLFICGPJ BKAEHKCCAPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	internal readonly BEEBHKAMNNL FNBHMEMNEPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	internal readonly LEMFDNDBDJC IFCMMFOJBML;

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x7AB29D0", Offset = "0x7AB19D0", VA = "0x187AB29D0")]
	public GLNGPPKPMIG(Material CANJBFKPEMF, FOHOLFICGPJ GMLOOFHADHO, BEEBHKAMNNL PGOOBBKNDOF, LEMFDNDBDJC BDNPFHIBMNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x7AB27A0", Offset = "0x7AB17A0", VA = "0x187AB27A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x7AB2590", Offset = "0x7AB1590", VA = "0x187AB2590", Slot = "4")]
	public bool Equals(GLNGPPKPMIG MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x7AB2610", Offset = "0x7AB1610", VA = "0x187AB2610", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x7AB2700", Offset = "0x7AB1700", VA = "0x187AB2700", Slot = "2")]
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
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		[SerializeField]
		[Header("Configuration")]
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
		[SerializeField]
		[Header("Configuration")]
		private BLMBMEMIHNO avatarBodyType;

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
		[Header("Arm Animation Controllers")]
		[SerializeField]
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
		private EEFKKODIKGJ PBMIFJMNDNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		private CPCAHHNKCEK GMCECMEINAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		private EKFIOJKBHPO MGCOAJDDCHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private EKFIOJKBHPO NCPPMDKMJDM;

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public EEFKKODIKGJ OLIAKELJPGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x7AA8890", Offset = "0x7AA7890", VA = "0x187AA8890", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public CPCAHHNKCEK AHDDGCHGPPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x7AA88E0", Offset = "0x7AA78E0", VA = "0x187AA88E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public EKFIOJKBHPO LGEIPIKACBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x7AA8930", Offset = "0x7AA7930", VA = "0x187AA8930", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public EKFIOJKBHPO MEJGBGHHDEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x7AA8980", Offset = "0x7AA7980", VA = "0x187AA8980", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public Transform KLBBKNPLNCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x7AA89D0", Offset = "0x7AA79D0", VA = "0x187AA89D0", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public BLMBMEMIHNO JOABLBMPDKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x9F6440", Offset = "0x9F5440", VA = "0x1809F6440", Slot = "12")]
			get
			{
				return default(BLMBMEMIHNO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x7AA7880", Offset = "0x7AA6880", VA = "0x187AA7880")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7AA86F0", Offset = "0x7AA76F0", VA = "0x187AA86F0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x7AA8600", Offset = "0x7AA7600", VA = "0x187AA8600", Slot = "8")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7AA86F0", Offset = "0x7AA76F0", VA = "0x187AA86F0", Slot = "9")]
		public void TeardownAvatarDisplaySystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x7AA7C90", Offset = "0x7AA6C90", VA = "0x187AA7C90", Slot = "10")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x7AA87A0", Offset = "0x7AA77A0", VA = "0x187AA87A0")]
		public void UpdatePostIKAnimControllers(float CJIPMCGKHCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x7AA8660", Offset = "0x7AA7660", VA = "0x187AA8660")]
		private void NIIKDBLCGKK(GameObject BOMDCGFKGKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x7AA7FC0", Offset = "0x7AA6FC0", VA = "0x187AA7FC0")]
		private EEFKKODIKGJ HDGFAFEIGAO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x7AA78F0", Offset = "0x7AA68F0", VA = "0x187AA78F0")]
		private CPCAHHNKCEK CJMMMKGGIEH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x7AA8370", Offset = "0x7AA7370", VA = "0x187AA8370")]
		private EKFIOJKBHPO IMAHJBOJCDF(ECEPGPDPDKI LKCJMGGAGMB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x7AA8880", Offset = "0x7AA7880", VA = "0x187AA8880")]
		public AvatarModernBodyDisplayBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class DCAOEHPAGLN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private MaterialPropertyBlock FHJBEKLNOIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	public Color? KKNAKKAEGIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	public Color? EIKMLKNEGHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	public Color? CIANNEIDAAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	public Color? GFMAIPOMMOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	public Color JIPGBOFPJKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	public Color BCLIKDAECBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	public Color HBBFGFAMEGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	public Texture2D MDLNPPNJNHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	public Texture2D FIGMALLLLIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	private Dictionary<GLNGPPKPMIG, int> LGPLODMABGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	private FOHOLFICGPJ[] BDBFLMBDBJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	private BEEBHKAMNNL[] DBPKBGEAOON;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public Vector4[] JPGNJBKOJAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public Vector4[] MKAHLKIOKKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public Vector4[] ONDIMBFLFCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public Vector4[] GEJPNHNNGDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public Vector4[] CFCBPLMPOJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public Vector4[] KHOJIJJBIKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private List<Texture2D> FNFNEIKOCII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private Vector4[] JCJEGIAILNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private List<Texture2D> DCNJNLGAKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private float[] GHLPFEFMGLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private Vector4[] KHIHCCMGENO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private float[] NPGGOFMHIJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public float[] GIFAANIMJGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private List<Texture2D> GINLIKAOMPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private float[] FJLGCABMEFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private List<Texture2D> KKBKNABELAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	private Vector4[] NPKIMGGPLII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private float[] KCCINMAOMII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private Vector4[] FBHJHFBGJIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public float[] BAGAFAIFKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public Texture2DArray LPAAPNDFAGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	public Texture2DArray LDKLKEPMPOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	public Texture2DArray IJPLODGLPHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public Texture2DArray PHHAKOHADLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private bool GGOEHDGAGFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	private int JBGMFGMAFPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private Vector2? AKGNJFDOMBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private TextureFormat BLPAAKGPDIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private Vector2? EHHEDLILGNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private TextureFormat AGAOMJDKGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	private Vector2? HBNLBDPDODL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	private TextureFormat CGLPDKOMBPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private Vector2? JAINKCEEJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	private TextureFormat NAENFMFPCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	private bool CIAFEFCBLPC;

	[Cpp2IlInjected.Token(Token = "0x400024E")]
	private static int JEPOFHHIKDD;

	[Cpp2IlInjected.Token(Token = "0x400024F")]
	private static int FFGAEADGFKA;

	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private static int FOLKBAOILNN;

	[Cpp2IlInjected.Token(Token = "0x4000251")]
	private static int JALPLCEEJLB;

	[Cpp2IlInjected.Token(Token = "0x4000252")]
	private static int KLLAILCEFGF;

	[Cpp2IlInjected.Token(Token = "0x4000253")]
	private static int MCJBEIMFHJK;

	[Cpp2IlInjected.Token(Token = "0x4000254")]
	private static int CPJAHIIKPHO;

	[Cpp2IlInjected.Token(Token = "0x4000255")]
	private static int MEPCFOIFIPH;

	[Cpp2IlInjected.Token(Token = "0x4000256")]
	private static int KIHEGEMHAPJ;

	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private static int PIOENPMIFAO;

	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private static int GJKPPCEFLHJ;

	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private static int BEJABIKAHIC;

	[Cpp2IlInjected.Token(Token = "0x400025A")]
	private static int NEHLPBDHIDG;

	[Cpp2IlInjected.Token(Token = "0x400025B")]
	private static int PCDOOMCEBIH;

	[Cpp2IlInjected.Token(Token = "0x400025C")]
	private static int DGENLFJKLOJ;

	[Cpp2IlInjected.Token(Token = "0x400025D")]
	private static int DELINIDPAHL;

	[Cpp2IlInjected.Token(Token = "0x400025E")]
	private static int FHDHOCAINGL;

	[Cpp2IlInjected.Token(Token = "0x400025F")]
	private static int LLBCPPKHJIM;

	[Cpp2IlInjected.Token(Token = "0x4000260")]
	private static int JGFDHCEEAOE;

	[Cpp2IlInjected.Token(Token = "0x4000261")]
	private static int ALODDBNCMFI;

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x7AAE9F0", Offset = "0x7AAD9F0", VA = "0x187AAE9F0")]
	private DCAOEHPAGLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x7AAE930", Offset = "0x7AAD930", VA = "0x187AAE930")]
	public DCAOEHPAGLN(Color HOKBFOFIGDG, Color IAGHPLIANOJ, Color ABOLANAFPPL, Color? JDPPHLLCPEO, Color? MOPPNOHCOMC, Color? CDCECCBAMKD, Texture2D HMEHFKKONPO, Texture2D CBNPCICNANG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x7AAC330", Offset = "0x7AAB330", VA = "0x187AAC330")]
	internal int CNJDCFDGLMF(Material BAJKNHFGJJI, FOHOLFICGPJ GMLOOFHADHO, BEEBHKAMNNL PGOOBBKNDOF, LEMFDNDBDJC BDNPFHIBMNH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x7AAC2A0", Offset = "0x7AAB2A0", VA = "0x187AAC2A0")]
	private int CNJDCFDGLMF(GLNGPPKPMIG OEHHKNIGGMI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x7AAC910", Offset = "0x7AAB910", VA = "0x187AAC910")]
	internal int GOGANAFBLKG(Material BAJKNHFGJJI, Color BCJBJCJEEOB, Color DENCMJLNDEA, Color GNOGEJFGEHI, Color EMEEOLPKGGL, Color MEAICLBLNAP, Texture2D FBBOIOEBNGH, Vector4 LOFGABLDGHM, Texture2D DAHLDLNOCME, Vector4 LBDAHPLCDDC, float GMHCCLLJIFJ, float KAICNIDJOJG, Texture2D DBDDDEKIGBM, Vector4 ADHIKGJFAME, float EEKJGFDCJEG, Texture2D FGNNMCDGMKK, Color MOIBEGCKKBB, Vector4 DJEDIOJLPIK, FOHOLFICGPJ GMLOOFHADHO, BEEBHKAMNNL PGOOBBKNDOF, LEMFDNDBDJC BDNPFHIBMNH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x7AAE330", Offset = "0x7AAD330", VA = "0x187AAE330")]
	private void KPFPDMEMEAG(List<Texture2D> FNFNEIKOCII, [Out] Texture2DArray EFDPLBHEFAA, [Out] Texture2DArray CMIGHGEHPCB, [Out] Texture2DArray IBFEMALCFAE, [Out] Texture2DArray ABNGOBMBIHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x7AAD4E0", Offset = "0x7AAC4E0", VA = "0x187AAD4E0")]
	public void HPJNJIJIJLF(Shader JJNGHIMLANK, Renderer CCKFDFMBDLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x7AAD630", Offset = "0x7AAC630", VA = "0x187AAD630")]
	private void ICNGOPDCFED(Shader JJNGHIMLANK, Renderer CCKFDFMBDLN, int GBGAFEDFAJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x7AAC570", Offset = "0x7AAB570", VA = "0x187AAC570")]
	private Color DDCNNEECBOG(Color IMAFKGFPPAB, FOHOLFICGPJ FKAIEBDGNCN)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x7AAC420", Offset = "0x7AAB420", VA = "0x187AAC420")]
	private Color CPJDMEJNDNO(Color DHFMPMLDGKG, FOHOLFICGPJ FKAIEBDGNCN)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x7AAC7B0", Offset = "0x7AAB7B0", VA = "0x187AAC7B0")]
	private bool ENOFOBJDKEM(Texture2D NOMMHBGDFHE, BEEBHKAMNNL IHIJDFFNDNI, [Out] Texture2D ODLCMICFHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x7AAE4F0", Offset = "0x7AAD4F0", VA = "0x187AAE4F0")]
	private void LIEDJNDHOEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x7AAC770", Offset = "0x7AAB770", VA = "0x187AAC770", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public abstract class OEHMJDNAMGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	public readonly LEMFDNDBDJC GAFMECPOEGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	protected bool CJCDPHEAMHG;

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public bool FONOBOLGJOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xC649F0", Offset = "0xC639F0", VA = "0x180C649F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0xC648C0", Offset = "0xC638C0", VA = "0x180C648C0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public bool AGMHOCMMNLI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0xC64A00", Offset = "0xC63A00", VA = "0x180C64A00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0xC648D0", Offset = "0xC638D0", VA = "0x180C648D0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public virtual DJMKKMKOHOE.KHMINOCKMDE CHNHHCCDPAN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(DJMKKMKOHOE.KHMINOCKMDE);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xC5C130", Offset = "0xC5B130", VA = "0x180C5C130", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool LPEGJDNGLLP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x12BA220", Offset = "0x12B9220", VA = "0x1812BA220")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public bool HJILDDHKHMK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x7AB65C0", Offset = "0x7AB55C0", VA = "0x187AB65C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool OANINHDKAKD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x7AB65B0", Offset = "0x7AB55B0", VA = "0x187AB65B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public bool OKFCBCLHBEA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x7AB65D0", Offset = "0x7AB55D0", VA = "0x187AB65D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x7AB65F0", Offset = "0x7AB55F0", VA = "0x187AB65F0")]
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
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	private AvatarSkinAssetItem NPELAGBPGGH;

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x7AB6AD0", Offset = "0x7AB5AD0", VA = "0x187AB6AD0")]
	public ONNIECAEOBP(AvatarSkinAssetItem AFHFOPBNIJD, AvatarSkinAssetItem.OMJMGGAGHPG IKIJFLKILNA, LEMFDNDBDJC BDNPFHIBMNH, [Optional] MCAONEJPGJL? BNBENPAGBAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x7AB6860", Offset = "0x7AB5860", VA = "0x187AB6860", Slot = "6")]
	public override HPIGCMLNLFB LKGBAHIGMNB(List<KBJDIMPKBHI> MKIPMDAKLBD, List<KBJDIMPKBHI> BBGGIAKGEEL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class CABEGIMOHPH
{
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	private static readonly int[] MIGKAELLCFO;

	[Cpp2IlInjected.Token(Token = "0x4000269")]
	private static readonly int[] CGIKIEMNIDF;

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public static int[] LFFJFJJEPMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x7AA8B40", Offset = "0x7AA7B40", VA = "0x187AA8B40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x7AA8AA0", Offset = "0x7AA7AA0", VA = "0x187AA8AA0")]
	public static int[] DPDJODCJDGA(bool IADHJPHPKHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x7AA89F0", Offset = "0x7AA79F0", VA = "0x187AA89F0")]
	public static int APCOAFCHCJI(MEACMOOJHJN FLHKCFOEJLN, bool IADHJPHPKHP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x7AA8B30", Offset = "0x7AA7B30", VA = "0x187AA8B30")]
	private static int HIJPIDBJADI(MEACMOOJHJN FLHKCFOEJLN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x7AA8A80", Offset = "0x7AA7A80", VA = "0x187AA8A80")]
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
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private NFNODNEANBN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		private NFNODNEANBN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x9F28C0", Offset = "0x9F18C0", VA = "0x1809F28C0")]
		[DebuggerHidden]
		public PNLFNKNCCBG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x124E890", Offset = "0x124D890", VA = "0x18124E890", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x7AB8DB0", Offset = "0x7AB7DB0", VA = "0x187AB8DB0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
	public static void OAFPJEBJIFD(string HJPLNJNIFLL, int GKGMDAMJCNF, long LCMLPLJCIJO, long FKMHDOKHBNC, long BOPFEFFDLKH, long DHLBPOJKGOM, long BICFMCIKJCK, long MKJNIGEPDCN, long HDKEGHCIIKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x7AB6450", Offset = "0x7AB5450", VA = "0x187AB6450")]
	public static OLILOOIADED CKKDEELJIEP(JobHandle GFMBLBMBIML, bool PLLMADNBOIJ, bool KJIMCOKKLJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x7AB6540", Offset = "0x7AB5540", VA = "0x187AB6540")]
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
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		General,
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		ColoredHair
	}

	[Cpp2IlInjected.Token(Token = "0x400026D")]
	public static readonly int DLLOHOIBMCG;

	[Cpp2IlInjected.Token(Token = "0x400026E")]
	public static readonly int FPDPDOLNPMA;

	[Cpp2IlInjected.Token(Token = "0x400026F")]
	public static readonly int HALLMDLCMGI;

	[Cpp2IlInjected.Token(Token = "0x4000270")]
	public static readonly int OLGMJLENALF;

	[Cpp2IlInjected.Token(Token = "0x4000271")]
	public static readonly int ILFEJNLHGBI;

	[Cpp2IlInjected.Token(Token = "0x4000272")]
	public static readonly int BDAIMPBNNIM;

	[Cpp2IlInjected.Token(Token = "0x4000273")]
	public static readonly int BCJMFFHPMNH;

	[Cpp2IlInjected.Token(Token = "0x4000274")]
	public static readonly int APALPOJLJLI;

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7AB0E70", Offset = "0x7AAFE70", VA = "0x187AB0E70")]
	public static bool LMDNCLBKNLJ(Material CANJBFKPEMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x7AB0DB0", Offset = "0x7AAFDB0", VA = "0x187AB0DB0")]
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
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public GKHPBLLBAIL<GameObject> skinAvatarItemPrefabHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public ACGLIOHHLFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public Action<string> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public MMLCIKGPOHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x7AB4B70", Offset = "0x7AB3B70", VA = "0x187AB4B70")]
		internal void CKKILCNJLJA(GameObject result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x7AB4F50", Offset = "0x7AB3F50", VA = "0x187AB4F50")]
		internal void DPKBNDMOCLL(string error)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	protected AvatarSkinAssetItem ECDMDJHGGLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	protected Material[] ADHMBFMPJBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	private readonly AvatarSkinAssetItem.OMJMGGAGHPG PFCKKGANPLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	private readonly AssetReference HNEFLPHAHKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	private readonly MCAONEJPGJL? EENFEGLHOBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	private SkinnedMeshRenderer[] FCNPHNMCNLK;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public override DJMKKMKOHOE.KHMINOCKMDE CHNHHCCDPAN
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x9F1550", Offset = "0x9F0550", VA = "0x1809F1550", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(DJMKKMKOHOE.KHMINOCKMDE);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x9F1790", Offset = "0x9F0790", VA = "0x1809F1790", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5DD0", Offset = "0x7AA4DD0", VA = "0x187AA5DD0")]
	public ACGLIOHHLFA(AvatarSkinAssetItem.OMJMGGAGHPG IKIJFLKILNA, AssetReference IDFMDCFBOGG, Material JKOIHDOGJBL, LEMFDNDBDJC BDNPFHIBMNH, DJMKKMKOHOE.KHMINOCKMDE PAODEGDIMGF = (DJMKKMKOHOE.KHMINOCKMDE)0L, [Optional] MCAONEJPGJL? BNBENPAGBAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5F00", Offset = "0x7AA4F00", VA = "0x187AA5F00")]
	public ACGLIOHHLFA(AvatarSkinAssetItem.OMJMGGAGHPG IKIJFLKILNA, AssetReference IDFMDCFBOGG, Material JKOIHDOGJBL, DJMKKMKOHOE.KHMINOCKMDE PAODEGDIMGF = (DJMKKMKOHOE.KHMINOCKMDE)0L, [Optional] MCAONEJPGJL? BNBENPAGBAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5B40", Offset = "0x7AA4B40", VA = "0x187AA5B40", Slot = "6")]
	public override HPIGCMLNLFB LKGBAHIGMNB(List<KBJDIMPKBHI> MKIPMDAKLBD, List<KBJDIMPKBHI> BBGGIAKGEEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5930", Offset = "0x7AA4930", VA = "0x187AA5930", Slot = "7")]
	public override OLNAGKBEHCB LEBDIAJMBFP(uint GKGMDAMJCNF, AvatarSkinnedMeshBoneOrderRemapsData PCHECJMOKMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5D60", Offset = "0x7AA4D60", VA = "0x187AA5D60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5D10", Offset = "0x7AA4D10", VA = "0x187AA5D10")]
	protected void OHEJKOEKLMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class FKKJNMIPHBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	private List<int> ABDLPMBBFLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	private List<MHJEJAKECKD> COJHDCAENKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	private HashSet<Transform> GGGHEFDJDHF;

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x7AB0830", Offset = "0x7AAF830", VA = "0x187AB0830")]
	public static FKKJNMIPHBA ONFCAKGIHCM(Transform LEMBKBGMCDG, Dictionary<Transform, OutfitType?> KMACIEFBIGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x7AB09C0", Offset = "0x7AAF9C0", VA = "0x187AB09C0")]
	private void PCCGKIBNJAM(Transform LEMBKBGMCDG, LEMFDNDBDJC BDNPFHIBMNH, Dictionary<Transform, OutfitType?> KMACIEFBIGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x7AB0700", Offset = "0x7AAF700", VA = "0x187AB0700")]
	private void MFHNJFHFFNI(Transform NGNHNPHIJOK, LEMFDNDBDJC BDNPFHIBMNH, bool AHBNMILFECC, OutfitType? KAMFIEKLGNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x7AB0310", Offset = "0x7AAF310", VA = "0x187AB0310")]
	public GKAFCBDLFII CKDLCEHIKGJ(HashSet<string> KLBEMONCPPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x7AB0C80", Offset = "0x7AAFC80", VA = "0x187AB0C80")]
	public FKKJNMIPHBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class GKAFCBDLFII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	private List<MHJEJAKECKD> COJHDCAENKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	private List<Matrix4x4> KAAPHLGGKJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private Transform[] DMGKGPCHPMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	private Matrix4x4[] KJACCKFOBDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	private Dictionary<HBCCCBHLICH, int> KBBBIAMMKPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	private List<PNLFNLOCNLC> BBAJMIILFEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	private bool KKNNDPFMJCM;

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public int CMIOJAJFIMN
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x7AB1CB0", Offset = "0x7AB0CB0", VA = "0x187AB1CB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public Transform[] IOMIJAIJMBM
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x7AB2240", Offset = "0x7AB1240", VA = "0x187AB2240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public Matrix4x4[] AGDHPELHHNG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x7AB23B0", Offset = "0x7AB13B0", VA = "0x187AB23B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x7AB2040", Offset = "0x7AB1040", VA = "0x187AB2040")]
	public void MFHNJFHFFNI(Transform NGNHNPHIJOK, LEMFDNDBDJC BDNPFHIBMNH, OutfitType? KAMFIEKLGNP, bool PCLFIDOGJOJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x7AB1CF0", Offset = "0x7AB0CF0", VA = "0x187AB1CF0")]
	private void MFHNJFHFFNI(Transform NGNHNPHIJOK, LEMFDNDBDJC BDNPFHIBMNH, OutfitType? KAMFIEKLGNP, bool PCLFIDOGJOJ, Matrix4x4 HKLGJJKHJMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x7AB1B00", Offset = "0x7AB0B00", VA = "0x187AB1B00")]
	public int KACNIOBLKLI(HBCCCBHLICH OEHHKNIGGMI, bool AOJFJFFJEBO, [Optional] OutfitType? KAMFIEKLGNP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x7AB18B0", Offset = "0x7AB08B0", VA = "0x187AB18B0")]
	public int CLBEDMCKMFI(LEMFDNDBDJC BDNPFHIBMNH, [Optional] OutfitType? KAMFIEKLGNP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7AB17C0", Offset = "0x7AB07C0", VA = "0x187AB17C0")]
	public void ACNFOIHPKMB(HBCCCBHLICH OEHHKNIGGMI, Matrix4x4 DBIOLKCJDPL, bool AOJFJFFJEBO = false, [Optional] OutfitType? KAMFIEKLGNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x7AB19B0", Offset = "0x7AB09B0", VA = "0x187AB19B0")]
	public Matrix4x4 DICFOKHOOFM(HBCCCBHLICH OEHHKNIGGMI, bool AOJFJFFJEBO, [Optional] OutfitType? KAMFIEKLGNP)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x12F3CD0", Offset = "0x12F2CD0", VA = "0x1812F3CD0")]
	public void BAJDMPAKPAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x7AB2420", Offset = "0x7AB1420", VA = "0x187AB2420")]
	public GKAFCBDLFII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct HBCCCBHLICH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public readonly string JEJBACCKIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public readonly LEMFDNDBDJC IFCMMFOJBML;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public readonly OutfitType? HDBKMDGNHHJ;

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x7AB2D30", Offset = "0x7AB1D30", VA = "0x187AB2D30")]
	public HBCCCBHLICH(string HFLPGENJMGG, LEMFDNDBDJC BDNPFHIBMNH, [Optional] OutfitType? KAMFIEKLGNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x7AB2C80", Offset = "0x7AB1C80", VA = "0x187AB2C80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x7AB2BC0", Offset = "0x7AB1BC0", VA = "0x187AB2BC0")]
	public bool NJNJIHOCGFM(HBCCCBHLICH MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x7AB2AA0", Offset = "0x7AB1AA0", VA = "0x187AB2AA0", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x7AB2B50", Offset = "0x7AB1B50", VA = "0x187AB2B50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct PNLFNLOCNLC : IEquatable<PNLFNLOCNLC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public readonly LEMFDNDBDJC IFCMMFOJBML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public readonly OutfitType? MCFHPCEKJJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public readonly int MOENHOFKKPG;

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x7AB90E0", Offset = "0x7AB80E0", VA = "0x187AB90E0")]
	public PNLFNLOCNLC(LEMFDNDBDJC BDNPFHIBMNH, int NMBCFKFFHJM, [Optional] OutfitType? BOKCMDJOODF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x7AB9010", Offset = "0x7AB8010", VA = "0x187AB9010", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x6D02D70", Offset = "0x6D01D70", VA = "0x186D02D70")]
	public bool JLMBFOAHFIK(LEMFDNDBDJC BDNPFHIBMNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x7AB8E00", Offset = "0x7AB7E00", VA = "0x187AB8E00")]
	public bool APECIMBJJOP(OutfitType? BOKCMDJOODF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x7AB8F70", Offset = "0x7AB7F70", VA = "0x187AB8F70", Slot = "4")]
	public bool Equals(PNLFNLOCNLC MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x7AB8E80", Offset = "0x7AB7E80", VA = "0x187AB8E80", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x7AB8FC0", Offset = "0x7AB7FC0", VA = "0x187AB8FC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct MHJEJAKECKD : IEquatable<MHJEJAKECKD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public readonly Transform JDEHADDKJBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public readonly bool AKPKHFOOJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public readonly LEMFDNDBDJC LNELLOCHKJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public readonly OutfitType? HDBKMDGNHHJ;

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x7AB4680", Offset = "0x7AB3680", VA = "0x187AB4680")]
	public MHJEJAKECKD(Transform NGNHNPHIJOK, bool AHBNMILFECC, LEMFDNDBDJC JAEENGJBIPN, [Optional] OutfitType? AOMDFBDKEIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x7AB4460", Offset = "0x7AB3460", VA = "0x187AB4460", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x7AB4200", Offset = "0x7AB3200", VA = "0x187AB4200", Slot = "4")]
	public bool Equals(MHJEJAKECKD MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x7AB4300", Offset = "0x7AB3300", VA = "0x187AB4300", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x7AB43E0", Offset = "0x7AB33E0", VA = "0x187AB43E0", Slot = "2")]
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

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x7AB1060", Offset = "0x7AB0060", VA = "0x187AB1060")]
		public static void DespawnHairHemisphere()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public void UpdateValues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x9F0210", Offset = "0x9EF210", VA = "0x1809F0210")]
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
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public readonly GameObject CFDBIKMCOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	private readonly AvatarItemMaterial JFBDMNNMAPP;

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0xAAAD70", Offset = "0xAA9D70", VA = "0x180AAAD70")]
	public HAJFBGNLPCB(GameObject CFDBIKMCOBM, AvatarItemMaterial JFBDMNNMAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x7AB2A10", Offset = "0x7AB1A10", VA = "0x187AB2A10")]
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

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x7AB3C90", Offset = "0x7AB2C90", VA = "0x187AB3C90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x7AB4190", Offset = "0x7AB3190", VA = "0x187AB4190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	private GKHPBLLBAIL<GameObject> MHHEDEBBMCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	private GKHPBLLBAIL<AvatarItemMaterial> FCKOBBCAMLD;

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x7AB1730", Offset = "0x7AB0730", VA = "0x187AB1730")]
	private GIBFJIMDLBM(Task<(GameObject, AvatarItemMaterial)> BGKKDAHMDLM, GKHPBLLBAIL<GameObject> NEAKMOEKCBI, GKHPBLLBAIL<AvatarItemMaterial> JDEOMEJOMDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x7AB10D0", Offset = "0x7AB00D0", VA = "0x187AB10D0")]
	public static GIBFJIMDLBM FLLMCNLHKNL(AssetReference IICOGDKMOMF, [Optional] AssetReference JKICLJFOHJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x7AB14E0", Offset = "0x7AB04E0", VA = "0x187AB14E0", Slot = "11")]
	protected override HAJFBGNLPCB JJMIGMFGBMB(Task<(GameObject, AvatarItemMaterial)> KBOFPPNJEHF)
	{
		return default(HAJFBGNLPCB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x7AB16B0", Offset = "0x7AB06B0", VA = "0x187AB16B0", Slot = "12")]
	protected override void OAEBBEFCKCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x7AB1580", Offset = "0x7AB0580", VA = "0x187AB1580")]
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
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private GKHPBLLBAIL<MaterialMapAsset> BOJCEMEJOMP;

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x7AB0230", Offset = "0x7AAF230", VA = "0x187AB0230")]
		public ENJHKNGFBGA(GKHPBLLBAIL<MaterialMapAsset> BOJCEMEJOMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x7AAFD90", Offset = "0x7AAED90", VA = "0x187AAFD90", Slot = "11")]
		protected override Material[] JJMIGMFGBMB(Task<MaterialMapAsset> BGKKDAHMDLM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x7AB01D0", Offset = "0x7AAF1D0", VA = "0x187AB01D0", Slot = "12")]
		protected override void OAEBBEFCKCM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class AIBDOGOJPLO : GFMCNLLODOK<Task<Material[]>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private List<GKHPBLLBAIL<Material>> LPJEPOMELAF;

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x7AA62A0", Offset = "0x7AA52A0", VA = "0x187AA62A0")]
		public AIBDOGOJPLO(Task<Material[]> BGKKDAHMDLM, List<GKHPBLLBAIL<Material>> LPJEPOMELAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x7AA6110", Offset = "0x7AA5110", VA = "0x187AA6110", Slot = "11")]
		protected override Material[] JJMIGMFGBMB(Task<Material[]> KBOFPPNJEHF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x7AA6160", Offset = "0x7AA5160", VA = "0x187AA6160", Slot = "12")]
		protected override void OAEBBEFCKCM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	private static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x7AB46D0", Offset = "0x7AB36D0", VA = "0x187AB46D0")]
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
		public enum NNMEKCBBIJP
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
		public enum NMOIBHCNNGG : byte
		{
			[Cpp2IlInjected.Token(Token = "0x400034E")]
			All,
			[Cpp2IlInjected.Token(Token = "0x400034F")]
			LOD0Only,
			[Cpp2IlInjected.Token(Token = "0x4000350")]
			EditorToolAll
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		public struct DAACLJKOJBJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000351")]
			public readonly Material FNLBLGEDCDN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000352")]
			public readonly IBAFKCJOEOA BKAEHKCCAPD;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000353")]
			public readonly NNMEKCBBIJP FNBHMEMNEPE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000354")]
			public readonly LEMFDNDBDJC IFCMMFOJBML;

			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x7AB29D0", Offset = "0x7AB19D0", VA = "0x187AB29D0")]
			public DAACLJKOJBJ(Material CANJBFKPEMF, IBAFKCJOEOA GMLOOFHADHO, NNMEKCBBIJP PGOOBBKNDOF, LEMFDNDBDJC BDNPFHIBMNH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x7AC81B0", Offset = "0x7AC71B0", VA = "0x187AC81B0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x7AB2590", Offset = "0x7AB1590", VA = "0x187AB2590")]
			public bool NJNJIHOCGFM(DAACLJKOJBJ MIJLJBIHDMP)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x7AC8020", Offset = "0x7AC7020", VA = "0x187AC8020", Slot = "0")]
			public override bool Equals(object BOMDCGFKGKF)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x7AC8110", Offset = "0x7AC7110", VA = "0x187AC8110", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		protected struct BBOCIFIGBHP : IComparable<BBOCIFIGBHP>, IEquatable<BBOCIFIGBHP>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000355")]
			public int DHLNJJDKAFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000356")]
			public PlayerAvatarDisplayBase JJNMHFCAPPI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000357")]
			public IList<EMNJOPNCDMC> IMGNGICNHLI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000358")]
			public AvatarItemBodyType AEDAMHBBOFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000359")]
			public JICFHOJONOI AHIIALKIOOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400035A")]
			public bool PKOMNKDJGAD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400035B")]
			public int[] KIOKNKHEIMB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400035C")]
			public float MHNIDGOLKKJ;

			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x7AC7ED0", Offset = "0x7AC6ED0", VA = "0x187AC7ED0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x7AC7D70", Offset = "0x7AC6D70", VA = "0x187AC7D70", Slot = "4")]
			public int CompareTo(BBOCIFIGBHP MIJLJBIHDMP)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x7AC7D90", Offset = "0x7AC6D90", VA = "0x187AC7D90", Slot = "5")]
			public bool Equals(BBOCIFIGBHP MIJLJBIHDMP)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		protected abstract class GDNBCAAJINI
		{
			[Cpp2IlInjected.Token(Token = "0x200005B")]
			public class DJANBEJOIHO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000360")]
				public readonly Mesh FHOGKLAGICP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000361")]
				public readonly Material[] EILAPPHKHIB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000362")]
				public readonly Transform[] KAADIMKDEBH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000363")]
				public readonly Matrix4x4[] DMADKIFECCD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000364")]
				public readonly Transform BBOEGCDDHHN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000365")]
				public readonly bool OEAPIIDJMIH;

				[Cpp2IlInjected.Token(Token = "0x60002FC")]
				[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
				protected DJANBEJOIHO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002FD")]
				[Cpp2IlInjected.Address(RVA = "0x7AC87C0", Offset = "0x7AC77C0", VA = "0x187AC87C0")]
				public DJANBEJOIHO(Mesh PEPFHNJFNIL, Material[] KDFCLGAFNHL, bool FCIFGNMGKMM, Transform[] IFACPDBOEIA, Transform IAOCGEGAPKO, Matrix4x4[] FKEHAENBMII)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002FE")]
				[Cpp2IlInjected.Address(RVA = "0x7AC8700", Offset = "0x7AC7700", VA = "0x187AC8700")]
				private DJANBEJOIHO(SkinnedMeshRenderer KMAINCIGCMG, Material[] KHMKOLBHGEN)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002FF")]
				[Cpp2IlInjected.Address(RVA = "0x7AC8C70", Offset = "0x7AC7C70", VA = "0x187AC8C70")]
				private DJANBEJOIHO(MeshRenderer NHJJDLPOEGL, Transform IAOCGEGAPKO, Material[] KHMKOLBHGEN)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000300")]
				[Cpp2IlInjected.Address(RVA = "0x7AC83E0", Offset = "0x7AC73E0", VA = "0x187AC83E0")]
				public static DJANBEJOIHO GKIPFIPICAH(Renderer CCKFDFMBDLN, Material[] KHMKOLBHGEN)
				{
					return null;
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400035D")]
			public readonly LEMFDNDBDJC IFCMMFOJBML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400035E")]
			public readonly Transform EJFHFFMPDKH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400035F")]
			public readonly bool NOCFBPFMPIK;

			[Cpp2IlInjected.Token(Token = "0x1700008C")]
			public virtual bool FONOBOLGJOE
			{
				[Cpp2IlInjected.Token(Token = "0x60002F5")]
				[Cpp2IlInjected.Address(RVA = "0xA3A820", Offset = "0xA39820", VA = "0x180A3A820", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008D")]
			public virtual bool AGMHOCMMNLI
			{
				[Cpp2IlInjected.Token(Token = "0x60002F6")]
				[Cpp2IlInjected.Address(RVA = "0xA3A820", Offset = "0xA39820", VA = "0x180A3A820", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008E")]
			public virtual DJMKKMKOHOE.KHMINOCKMDE CHNHHCCDPAN
			{
				[Cpp2IlInjected.Token(Token = "0x60002F7")]
				[Cpp2IlInjected.Address(RVA = "0x9F0230", Offset = "0x9EF230", VA = "0x1809F0230", Slot = "6")]
				get
				{
					return default(DJMKKMKOHOE.KHMINOCKMDE);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008F")]
			public bool PJHKDJOGIAN
			{
				[Cpp2IlInjected.Token(Token = "0x60002F8")]
				[Cpp2IlInjected.Address(RVA = "0x7ACD830", Offset = "0x7ACC830", VA = "0x187ACD830")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x7ACD840", Offset = "0x7ACC840", VA = "0x187ACD840")]
			protected GDNBCAAJINI(LEMFDNDBDJC BDNPFHIBMNH, Transform OGJFOPFMFCO, bool JCJJCHMGOCK = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract HPIGCMLNLFB LKGBAHIGMNB(List<KBJDIMPKBHI> MKIPMDAKLBD, List<KBJDIMPKBHI> BBGGIAKGEEL);

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract DJANBEJOIHO LEBDIAJMBFP(int GKGMDAMJCNF, PlayerHandBones AMCJMGNBBHF);
		}

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		protected class OGMCCMMPOPH : GDNBCAAJINI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000366")]
			protected readonly BodyPartLODs FCNPHNMCNLK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000367")]
			protected readonly Material[] ADHMBFMPJBP;

			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x7ACF640", Offset = "0x7ACE640", VA = "0x187ACF640")]
			public OGMCCMMPOPH(LEMFDNDBDJC BDNPFHIBMNH, BodyPartLODs FBDONGLADBG, Material JKOIHDOGJBL, [Optional] Transform OGJFOPFMFCO, bool JCJJCHMGOCK = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0x7ACF540", Offset = "0x7ACE540", VA = "0x187ACF540", Slot = "7")]
			public override HPIGCMLNLFB LKGBAHIGMNB(List<KBJDIMPKBHI> MKIPMDAKLBD, List<KBJDIMPKBHI> BBGGIAKGEEL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x7ACF380", Offset = "0x7ACE380", VA = "0x187ACF380", Slot = "8")]
			public override DJANBEJOIHO LEBDIAJMBFP(int GKGMDAMJCNF, PlayerHandBones AMCJMGNBBHF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x7ACF5D0", Offset = "0x7ACE5D0", VA = "0x187ACF5D0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005D")]
		protected class KBMEBDAENDC : GDNBCAAJINI
		{
			[Cpp2IlInjected.Token(Token = "0x17000090")]
			public override bool FONOBOLGJOE
			{
				[Cpp2IlInjected.Token(Token = "0x6000305")]
				[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A680", VA = "0x180A0B680", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000091")]
			public override bool AGMHOCMMNLI
			{
				[Cpp2IlInjected.Token(Token = "0x6000306")]
				[Cpp2IlInjected.Address(RVA = "0x7ACD950", Offset = "0x7ACC950", VA = "0x187ACD950", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000092")]
			public CKKEFOLDDDM GBHHDDAPDIC
			{
				[Cpp2IlInjected.Token(Token = "0x6000307")]
				[Cpp2IlInjected.Address(RVA = "0x9F1550", Offset = "0x9F0550", VA = "0x1809F1550")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000308")]
				[Cpp2IlInjected.Address(RVA = "0x9F5A20", Offset = "0x9F4A20", VA = "0x1809F5A20")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0x7ACDAA0", Offset = "0x7ACCAA0", VA = "0x187ACDAA0")]
			public KBMEBDAENDC(LEMFDNDBDJC BDNPFHIBMNH, Transform OGJFOPFMFCO, CKKEFOLDDDM NPDKKINBDDF, bool JCJJCHMGOCK = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0x7ACD9A0", Offset = "0x7ACC9A0", VA = "0x187ACD9A0", Slot = "7")]
			public override HPIGCMLNLFB LKGBAHIGMNB(List<KBJDIMPKBHI> MKIPMDAKLBD, List<KBJDIMPKBHI> BBGGIAKGEEL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0x9F0230", Offset = "0x9EF230", VA = "0x1809F0230", Slot = "8")]
			public override DJANBEJOIHO LEBDIAJMBFP(int GKGMDAMJCNF, PlayerHandBones AMCJMGNBBHF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0x7ACDA30", Offset = "0x7ACCA30", VA = "0x187ACDA30", Slot = "3")]
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
			public static readonly int NHIIHMBKJCN;

			[Cpp2IlInjected.Token(Token = "0x400036A")]
			public static readonly int DJLEPMNELJC;

			[Cpp2IlInjected.Token(Token = "0x400036B")]
			public static readonly int LJCCJAKLOAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400036C")]
			protected readonly ECEPGPDPDKI LKCJMGGAGMB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400036D")]
			protected readonly BELFFFDFKLH IHLPOFPAKDN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400036E")]
			protected readonly Animator ONNIEABMGBG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400036F")]
			protected readonly Transform MNLNCALALAP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000370")]
			protected readonly Vector3 KMIJABPLEIA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000371")]
			protected readonly Transform AHKIHBGCMLD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000372")]
			protected readonly Vector3 NNGKFDBEDCL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000373")]
			protected bool MBLMHJLBENI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000374")]
			protected EKFIOJKBHPO FMGBNAOBIOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000375")]
			protected bool DHBDCCHCLFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x4000376")]
			protected float IEMFALAFBDE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000377")]
			protected LBBJFFOLGFF<ACKOLLANMDJ> OEMGGDMODNM;

			[Cpp2IlInjected.Token(Token = "0x17000093")]
			public EKFIOJKBHPO DEDOKBIIEBL
			{
				[Cpp2IlInjected.Token(Token = "0x600030D")]
				[Cpp2IlInjected.Address(RVA = "0x9F4710", Offset = "0x9F3710", VA = "0x1809F4710")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600030E")]
				[Cpp2IlInjected.Address(RVA = "0x9F46D0", Offset = "0x9F36D0", VA = "0x1809F46D0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000094")]
			public bool BPDHJLGHAGA
			{
				[Cpp2IlInjected.Token(Token = "0x600030F")]
				[Cpp2IlInjected.Address(RVA = "0xBE1E20", Offset = "0xBE0E20", VA = "0x180BE1E20")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000310")]
				[Cpp2IlInjected.Address(RVA = "0x7ACC750", Offset = "0x7ACB750", VA = "0x187ACC750")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000095")]
			public bool GOCLHNPOCMA
			{
				[Cpp2IlInjected.Token(Token = "0x6000311")]
				[Cpp2IlInjected.Address(RVA = "0x9FACA0", Offset = "0x9F9CA0", VA = "0x1809FACA0")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000312")]
				[Cpp2IlInjected.Address(RVA = "0x7ACC820", Offset = "0x7ACB820", VA = "0x187ACC820")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000096")]
			public float ELGCCLKIILN
			{
				[Cpp2IlInjected.Token(Token = "0x6000313")]
				[Cpp2IlInjected.Address(RVA = "0xC658A0", Offset = "0xC648A0", VA = "0x180C658A0")]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000314")]
				[Cpp2IlInjected.Address(RVA = "0x7ACCFC0", Offset = "0x7ACBFC0", VA = "0x187ACCFC0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000097")]
			public ACKOLLANMDJ FINEDPMJOBP
			{
				[Cpp2IlInjected.Token(Token = "0x6000315")]
				[Cpp2IlInjected.Address(RVA = "0x7ACCAA0", Offset = "0x7ACBAA0", VA = "0x187ACCAA0")]
				get
				{
					return default(ACKOLLANMDJ);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x7ACCD40", Offset = "0x7ACBD40", VA = "0x187ACCD40")]
			public bool KEJPKCHIMHE(ACKOLLANMDJ FNMJJEKIDLE, object EJJDDFFADPC, AABNHAOHPIF DPEJEDCKJBD)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x7ACC9A0", Offset = "0x7ACB9A0", VA = "0x187ACC9A0")]
			public bool CPJCEMHDELM(object EJJDDFFADPC)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x7ACD1B0", Offset = "0x7ACC1B0", VA = "0x187ACD1B0")]
			protected GBHBDCHAKAB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0x7ACD240", Offset = "0x7ACC240", VA = "0x187ACD240")]
			public GBHBDCHAKAB(ECEPGPDPDKI LKCJMGGAGMB, EKFIOJKBHPO EJODGNCGFLE, Animator ONNIEABMGBG, Transform MNLNCALALAP, Transform AHKIHBGCMLD, Vector3 KMIJABPLEIA, Vector3 NNGKFDBEDCL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0x7ACC8F0", Offset = "0x7ACB8F0", VA = "0x187ACC8F0")]
			private void COFEPPECBEP(ushort KPBBLBKEMIC, ushort HBFAAELLBGE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x7ACCAE0", Offset = "0x7ACBAE0", VA = "0x187ACCAE0")]
			protected void FEPCNPOHBOO(ushort KPBBLBKEMIC, ushort HBFAAELLBGE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x7ACCE50", Offset = "0x7ACBE50", VA = "0x187ACCE50")]
			protected void OIAKBNCDKDP(ushort KPBBLBKEMIC, ushort HBFAAELLBGE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x7ACC620", Offset = "0x7ACB620", VA = "0x187ACC620")]
			protected void BGFBOANDFLN(ushort KPBBLBKEMIC, ushort HBFAAELLBGE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x7ACC510", Offset = "0x7ACB510", VA = "0x187ACC510")]
			protected void ANIDNENDAEI(ushort KPBBLBKEMIC, ushort HBFAAELLBGE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x7ACCF60", Offset = "0x7ACBF60", VA = "0x187ACCF60")]
			protected void PGOCJCNJEFL(ushort KPBBLBKEMIC, ushort HBFAAELLBGE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x7ACCF10", Offset = "0x7ACBF10", VA = "0x187ACCF10")]
			protected void PAIGLPHCMDB(ushort KPBBLBKEMIC, ushort HBFAAELLBGE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x7ACCCF0", Offset = "0x7ACBCF0", VA = "0x187ACCCF0")]
			protected void KBKHBGMLADF(ushort KPBBLBKEMIC, ushort HBFAAELLBGE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x7ACCBD0", Offset = "0x7ACBBD0", VA = "0x187ACCBD0")]
			protected void HHMCIAMLDJK(ushort KPBBLBKEMIC, ushort HBFAAELLBGE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000060")]
		public class DNOBIKFHBLF : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x4000380")]
			public const int IJDEJBCFGDH = 16;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000381")]
			protected MaterialPropertyBlock FHJBEKLNOIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000382")]
			public Color? KKNAKKAEGIG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000383")]
			public Color? CIANNEIDAAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000384")]
			public Color? GFMAIPOMMOC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000385")]
			public Color JIPGBOFPJKE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x4000386")]
			public Color BCLIKDAECBK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x4000387")]
			public Color HBBFGFAMEGL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000388")]
			public Texture2D MDLNPPNJNHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000389")]
			public Texture2D FIGMALLLLIF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x400038A")]
			protected Dictionary<DAACLJKOJBJ, int> LGPLODMABGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x400038B")]
			protected IBAFKCJOEOA[] BDBFLMBDBJK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x400038C")]
			public Vector4[] JPGNJBKOJAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x400038D")]
			public Vector4[] MKAHLKIOKKD;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x400038E")]
			public Vector4[] ONDIMBFLFCN;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			public Vector4[] GEJPNHNNGDB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x4000390")]
			public Vector4[] CFCBPLMPOJD;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000391")]
			public Vector4[] KHOJIJJBIKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000392")]
			protected List<Texture2D> FNFNEIKOCII;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000393")]
			protected Vector4[] JCJEGIAILNJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
			[Cpp2IlInjected.Token(Token = "0x4000394")]
			protected List<Texture2D> DCNJNLGAKPH;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
			[Cpp2IlInjected.Token(Token = "0x4000395")]
			protected float[] GHLPFEFMGLA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
			[Cpp2IlInjected.Token(Token = "0x4000396")]
			protected Vector4[] KHIHCCMGENO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x4000397")]
			protected float[] NPGGOFMHIJM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
			[Cpp2IlInjected.Token(Token = "0x4000398")]
			public float[] GIFAANIMJGG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
			[Cpp2IlInjected.Token(Token = "0x4000399")]
			protected List<Texture2D> GINLIKAOMPB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
			[Cpp2IlInjected.Token(Token = "0x400039A")]
			protected float[] FJLGCABMEFB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
			[Cpp2IlInjected.Token(Token = "0x400039B")]
			protected List<Texture2D> KKBKNABELAH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			protected Vector4[] NPKIMGGPLII;

			[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
			[Cpp2IlInjected.Token(Token = "0x400039D")]
			protected float[] KCCINMAOMII;

			[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
			[Cpp2IlInjected.Token(Token = "0x400039E")]
			protected Vector4[] FBHJHFBGJIG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x400039F")]
			public float[] BAGAFAIFKKJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
			[Cpp2IlInjected.Token(Token = "0x40003A0")]
			public Texture2DArray LPAAPNDFAGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x40003A1")]
			public Texture2DArray LDKLKEPMPOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
			[Cpp2IlInjected.Token(Token = "0x40003A2")]
			public Texture2DArray IJPLODGLPHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
			[Cpp2IlInjected.Token(Token = "0x40003A3")]
			public Texture2DArray PHHAKOHADLH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x40003A4")]
			protected bool GGOEHDGAGFD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
			[Cpp2IlInjected.Token(Token = "0x40003A5")]
			protected int JBGMFGMAFPA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
			[Cpp2IlInjected.Token(Token = "0x40003A6")]
			protected Vector2? AKGNJFDOMBF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
			[Cpp2IlInjected.Token(Token = "0x40003A7")]
			protected TextureFormat BLPAAKGPDIO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
			[Cpp2IlInjected.Token(Token = "0x40003A8")]
			protected Vector2? EHHEDLILGNK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
			[Cpp2IlInjected.Token(Token = "0x40003A9")]
			protected TextureFormat AGAOMJDKGPB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
			[Cpp2IlInjected.Token(Token = "0x40003AA")]
			protected Vector2? HBNLBDPDODL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
			[Cpp2IlInjected.Token(Token = "0x40003AB")]
			protected TextureFormat CGLPDKOMBPN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
			[Cpp2IlInjected.Token(Token = "0x40003AC")]
			protected Vector2? JAINKCEEJED;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
			[Cpp2IlInjected.Token(Token = "0x40003AD")]
			protected TextureFormat NAENFMFPCOO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
			[Cpp2IlInjected.Token(Token = "0x40003AE")]
			protected bool CIAFEFCBLPC;

			[Cpp2IlInjected.Token(Token = "0x40003AF")]
			protected static int JEPOFHHIKDD;

			[Cpp2IlInjected.Token(Token = "0x40003B0")]
			protected static int FFGAEADGFKA;

			[Cpp2IlInjected.Token(Token = "0x40003B1")]
			protected static int FOLKBAOILNN;

			[Cpp2IlInjected.Token(Token = "0x40003B2")]
			protected static int JALPLCEEJLB;

			[Cpp2IlInjected.Token(Token = "0x40003B3")]
			protected static int KLLAILCEFGF;

			[Cpp2IlInjected.Token(Token = "0x40003B4")]
			protected static int MCJBEIMFHJK;

			[Cpp2IlInjected.Token(Token = "0x40003B5")]
			protected static int CPJAHIIKPHO;

			[Cpp2IlInjected.Token(Token = "0x40003B6")]
			protected static int MEPCFOIFIPH;

			[Cpp2IlInjected.Token(Token = "0x40003B7")]
			protected static int KIHEGEMHAPJ;

			[Cpp2IlInjected.Token(Token = "0x40003B8")]
			protected static int PIOENPMIFAO;

			[Cpp2IlInjected.Token(Token = "0x40003B9")]
			protected static int GJKPPCEFLHJ;

			[Cpp2IlInjected.Token(Token = "0x40003BA")]
			protected static int BEJABIKAHIC;

			[Cpp2IlInjected.Token(Token = "0x40003BB")]
			protected static int NEHLPBDHIDG;

			[Cpp2IlInjected.Token(Token = "0x40003BC")]
			protected static int PCDOOMCEBIH;

			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			protected static int DGENLFJKLOJ;

			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			protected static int DELINIDPAHL;

			[Cpp2IlInjected.Token(Token = "0x40003BF")]
			protected static int FHDHOCAINGL;

			[Cpp2IlInjected.Token(Token = "0x40003C0")]
			protected static int LLBCPPKHJIM;

			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			protected static int JGFDHCEEAOE;

			[Cpp2IlInjected.Token(Token = "0x40003C2")]
			protected static int ALODDBNCMFI;

			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x7ACB600", Offset = "0x7ACA600", VA = "0x187ACB600")]
			protected DNOBIKFHBLF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x7ACB570", Offset = "0x7ACA570", VA = "0x187ACB570")]
			public DNOBIKFHBLF(Color HOKBFOFIGDG, Color IAGHPLIANOJ, Color ABOLANAFPPL, Color? JDPPHLLCPEO, Color? MOPPNOHCOMC, Color? CDCECCBAMKD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x7AC8FF0", Offset = "0x7AC7FF0", VA = "0x187AC8FF0")]
			public int CNJDCFDGLMF(Material BAJKNHFGJJI, IBAFKCJOEOA GMLOOFHADHO, NNMEKCBBIJP PGOOBBKNDOF, LEMFDNDBDJC BDNPFHIBMNH)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x7AC90E0", Offset = "0x7AC80E0", VA = "0x187AC90E0")]
			public int CNJDCFDGLMF(DAACLJKOJBJ OEHHKNIGGMI)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x7AC93A0", Offset = "0x7AC83A0", VA = "0x187AC93A0")]
			public int GOGANAFBLKG(Material BAJKNHFGJJI, Color BCJBJCJEEOB, Color DENCMJLNDEA, Color GNOGEJFGEHI, Color EMEEOLPKGGL, Color MEAICLBLNAP, Texture2D FBBOIOEBNGH, Vector4 LOFGABLDGHM, Texture2D DAHLDLNOCME, Vector4 LBDAHPLCDDC, float GMHCCLLJIFJ, float KAICNIDJOJG, Texture2D DBDDDEKIGBM, Vector4 ADHIKGJFAME, float EEKJGFDCJEG, Texture2D FGNNMCDGMKK, float BAHPONNGANN, Color MOIBEGCKKBB, Vector4 DJEDIOJLPIK, IBAFKCJOEOA GMLOOFHADHO, NNMEKCBBIJP PGOOBBKNDOF, LEMFDNDBDJC BDNPFHIBMNH)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x7ACAE40", Offset = "0x7AC9E40", VA = "0x187ACAE40")]
			protected void KPFPDMEMEAG([Out] Texture2DArray EFDPLBHEFAA, [Out] Texture2DArray CMIGHGEHPCB, [Out] Texture2DArray IBFEMALCFAE, [Out] Texture2DArray ABNGOBMBIHG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x7ACA0A0", Offset = "0x7AC90A0", VA = "0x187ACA0A0")]
			public void HPJNJIJIJLF(PlayerAvatarDisplayBase JBDLPFCPPOM, Renderer CCKFDFMBDLN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x7ACA310", Offset = "0x7AC9310", VA = "0x187ACA310")]
			protected void ICNGOPDCFED(PlayerAvatarDisplayBase JBDLPFCPPOM, Renderer CCKFDFMBDLN, int GBGAFEDFAJB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x7AC9170", Offset = "0x7AC8170", VA = "0x187AC9170")]
			private Color DDCNNEECBOG(Color IMAFKGFPPAB, IBAFKCJOEOA FKAIEBDGNCN)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x7ACB090", Offset = "0x7ACA090", VA = "0x187ACB090")]
			private Color MMIPNIGOFPK(Color AJNJDEBHJIG, IBAFKCJOEOA FKAIEBDGNCN)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x7ACB000", Offset = "0x7ACA000", VA = "0x187ACB000")]
			protected void LIEDJNDHOEE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x7AC9360", Offset = "0x7AC8360", VA = "0x187AC9360", Slot = "4")]
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

			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x7AD7000", Offset = "0x7AD6000", VA = "0x187AD7000")]
			public void EHKOLIDBMHA(LEMFDNDBDJC BDNPFHIBMNH, [Out] Transform KNNDNAPJIDP, [Out] Transform[] IFACPDBOEIA)
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
		private sealed class LJKKABCBPLB : IEnumerable<SkinnedMeshRenderer>, IEnumerable, IEnumerator<SkinnedMeshRenderer>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Token(Token = "0x600033D")]
				[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000099")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600033F")]
				[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0xE8B5B0", Offset = "0xE8A5B0", VA = "0x180E8B5B0")]
			[DebuggerHidden]
			public LJKKABCBPLB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x7ACE6D0", Offset = "0x7ACD6D0", VA = "0x187ACE6D0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x7ACE950", Offset = "0x7ACD950", VA = "0x187ACE950", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x7ACE8A0", Offset = "0x7ACD8A0", VA = "0x187ACE8A0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<SkinnedMeshRenderer> IEnumerable<SkinnedMeshRenderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x7ACE8A0", Offset = "0x7ACD8A0", VA = "0x187ACE8A0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000065")]
		[CompilerGenerated]
		private sealed class FBGFJAGPEBF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003D6")]
			public PlayerAvatarDisplayBase display;

			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public FBGFJAGPEBF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x7ACC180", Offset = "0x7ACB180", VA = "0x187ACC180")]
			internal bool GNACENGHOJJ()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class KEEBFFFINOI : IEnumerator<NFNODNEANBN>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003D7")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003D8")]
			private NFNODNEANBN <>2__current;

			[Cpp2IlInjected.Token(Token = "0x1700009A")]
			private NFNODNEANBN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000347")]
				[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000349")]
				[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x9F28C0", Offset = "0x9F18C0", VA = "0x1809F28C0")]
			[DebuggerHidden]
			public KEEBFFFINOI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0x7ACDB10", Offset = "0x7ACCB10", VA = "0x187ACDB10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(RVA = "0x7ACDEF0", Offset = "0x7ACCEF0", VA = "0x187ACDEF0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000067")]
		[CompilerGenerated]
		private struct PIILMPKDMDA : IAsyncStateMachine
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
			public MAKBECHNCGC avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003DD")]
			private bool <forceRebuild>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003DE")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0x7ACFB50", Offset = "0x7ACEB50", VA = "0x187ACFB50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x7AD0430", Offset = "0x7ACF430", VA = "0x187AD0430", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000068")]
		[CompilerGenerated]
		private sealed class LDHLBJILLFE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003DF")]
			public string overrideIdentifier;

			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public LDHLBJILLFE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0x7ACE3B0", Offset = "0x7ACD3B0", VA = "0x187ACE3B0")]
			internal bool ECGKHJOGDED(EMNJOPNCDMC selection)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000069")]
		[CompilerGenerated]
		private sealed class FOAOINPNFED
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003E0")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003E1")]
			public AvatarItemBodyType avatarItemBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003E2")]
			public Func<KGAPFDAFEHM<Dictionary<string, GKHPBLLBAIL<Texture2D>>>> <>9__2;

			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public FOAOINPNFED()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0x7ACC2D0", Offset = "0x7ACB2D0", VA = "0x187ACC2D0")]
			internal (ALBMIKCECHI, KGAPFDAFEHM<Dictionary<string, GKHPBLLBAIL<Texture2D>>>) IAIIFBCJMKD(Dictionary<string, ALBBMKANDAF> avatarItems)
			{
				return default((ALBMIKCECHI, KGAPFDAFEHM<Dictionary<string, GKHPBLLBAIL<Texture2D>>>));
			}

			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0x7ACC260", Offset = "0x7ACB260", VA = "0x187ACC260")]
			internal KGAPFDAFEHM<Dictionary<string, GKHPBLLBAIL<Texture2D>>> AKBANKDLFPK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x7ACC4D0", Offset = "0x7ACB4D0", VA = "0x187ACC4D0")]
			internal void KCIICELOIHG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006A")]
		[CompilerGenerated]
		private sealed class JOBMJHDCJGD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003E3")]
			public Transform transformToCheck;

			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public JOBMJHDCJGD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x7ACD8A0", Offset = "0x7ACC8A0", VA = "0x187ACD8A0")]
			internal bool OMHACECFEAG(SkinnedMeshRenderer x)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006B")]
		[CompilerGenerated]
		private struct KKCGNEAAMDP : IAsyncStateMachine
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

			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0x7ACDF40", Offset = "0x7ACCF40", VA = "0x187ACDF40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0x7ACE110", Offset = "0x7ACD110", VA = "0x187ACE110", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		protected static readonly int LFCAOGDGBCF;

		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		protected static readonly int IFPHMMKBMAI;

		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		protected static readonly int LHFDEPFMMLE;

		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		protected static readonly int MDFOIADEHEK;

		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		protected static readonly int GDALFNBDFLA;

		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		protected static readonly int NEBJJGMDHAO;

		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		protected static readonly int[] EECBBBIEJGK;

		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		protected static readonly int[] OJEEFIMBPCE;

		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		protected static readonly int[] LKEPKNABEFJ;

		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		protected static readonly int[] DCFJMDGDPAJ;

		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		protected static readonly int[] NOKOCDPEOEJ;

		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		protected static readonly int[] BKELIMLBDBD;

		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		protected static List<PlayerAvatarDisplayBase> KAMEHMIEHIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		protected OJELMNHDJHH AHGOJHIKDCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		protected bool APHODKKNMPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		protected bool BKPHMFMOBOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		[SerializeField]
		public AvatarBodyShapeVault BodyShapeVault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		[SerializeField]
		public AvatarFaceShapeVault FaceShapeVault;

		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		protected static readonly int[] NOJDNENCBHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		[SerializeField]
		protected Material bodyPartMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		protected Dictionary<DAACLJKOJBJ, Material> HKDBJGOGBOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		protected Dictionary<DAACLJKOJBJ, Material> EKJOLFDKJBF;

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
		protected Material PFJKIDMMJPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		protected EEFKKODIKGJ HLDDCPCMHDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		private EKFIOJKBHPO MGCOAJDDCHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		private EKFIOJKBHPO NCPPMDKMJDM;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		protected Material PBJKOGACHKD;

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
		protected FitMeshHemisphere CPHGACAMCNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		protected bool EDGMLKOMGHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		protected HMAKLDEGKBC MJOPHNIAFAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		protected bool CFFEAMDBGMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		protected AnchorParamsRestrictions DFNIKEMKODL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		protected bool HEMHLCGCIFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		protected Transform GCAOHBMKLFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		protected bool BANGFONGFJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B1")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		protected bool LDHJILONLNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		protected Vector3 CCJKKCMOIBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		protected Quaternion IIPGOIHEKNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		protected Vector2 FMLCFFLGFIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		protected FitMeshHemisphere AHEPBELAMIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		[ANKANEOPOFH(JINCPHMLLKA.SelfAndChildren, false, false, false)]
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
		protected Collider[] OCDDDLCCPEP;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		protected Collider[] MCEBECNIKEK;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		protected GBHBDCHAKAB[] LMGBEDDNFAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		[SerializeField]
		protected Mesh faceMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public Dictionary<Renderer, DNOBIKFHBLF> currentPropertyBlocks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		protected Dictionary<Renderer, DNOBIKFHBLF> AIEJIELPEKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		protected FKKJNMIPHBA GPJGGHKDAKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		protected ALBMIKCECHI DIPNFLLGAFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public MEACMOOJHJN DistanceBand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x284")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		protected int FCNENKGLAIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		protected (bool isLodForced, int forcedLOD) DHMLGECLLHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		protected LBBJFFOLGFF<BELFFFDFKLH> OEMGGDMODNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		protected bool JPJCGKKDHON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		protected Dictionary<EMNJOPNCDMC, List<DAACLJKOJBJ>> EPLBHKAHKDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		protected Dictionary<EMNJOPNCDMC, List<DAACLJKOJBJ>> IOIDOLNNMHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		protected readonly Dictionary<string, GKHPBLLBAIL<Texture2D>> KBNBLOHCPMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		protected readonly Dictionary<string, GKHPBLLBAIL<Texture2D>> HKEFNCKNMIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		protected bool LHOJALKLPIL;

		[Cpp2IlInjected.Token(Token = "0x400031C")]
		protected static int HJBLOHLBKHA;

		[Cpp2IlInjected.Token(Token = "0x400031D")]
		protected static List<BBOCIFIGBHP> GPAPFLPNLCP;

		[Cpp2IlInjected.Token(Token = "0x400031E")]
		protected static List<BBOCIFIGBHP> OGBPAEOOLNA;

		[Cpp2IlInjected.Token(Token = "0x400031F")]
		protected static OLILOOIADED NLBOBIFIGOJ;

		[Cpp2IlInjected.Token(Token = "0x4000320")]
		protected static bool GMGOOCHOFAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		protected Color? EJKJNOKBEHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E4")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		protected bool JBBHHIKOIIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		protected Color IPOCBFHCDAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		protected Color IGPAGEHDJPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		protected Color IBDABKKJKNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		protected AvatarHairPattern AHIIOKJHAIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		protected CKKEFOLDDDM BJAFODBKKJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		protected Color OHLFKGIOOGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		protected Color BBDJCMHAJBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		protected AvatarHairPattern MLDNKJMPPDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		protected CKKEFOLDDDM BONEKFLIMFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		protected CKKEFOLDDDM KAOBBKOAHGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		protected Color DAAEAECKLHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		private AdditionalFeetData LMPPPEJFEPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		protected EMNJOPNCDMC? HNJDFMHFBIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		protected Texture GALENMMJOBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		protected Color HGCJOBDAACE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		protected readonly IList<EMNJOPNCDMC> KKJAOFKKOCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		protected readonly IList<EMNJOPNCDMC> DABFJEOPOLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		private AvatarItemBodyType LLHMKNNLCMI;

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
		protected ABOJDNCODIG _currentNoseType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D4")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		[SerializeField]
		protected bool _hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D5")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		protected NMOIBHCNNGG JKJOHBDOKPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		protected int[] PEFNBPAMJHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E0")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		protected bool EOKOIAMAGLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E8")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		protected int[] IKLKLFPIGKK;

		[Cpp2IlInjected.Token(Token = "0x400033D")]
		private static readonly DJMKKMKOHOE.KHMINOCKMDE FFJFAMHEMFI;

		[Cpp2IlInjected.Token(Token = "0x400033E")]
		private static readonly DJMKKMKOHOE.KHMINOCKMDE AKBBFADJBFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F0")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		protected bool GNDIPGLNBGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F8")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		protected NAFFPEBCHPI PALKBJEOGPL;

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public string ADJHNEMOGHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x9F1780", Offset = "0x9F0780", VA = "0x1809F1780")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x9F1770", Offset = "0x9F0770", VA = "0x1809F1770")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public bool NBOCNNCLLHG
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0xBF8AB0", Offset = "0xBF7AB0", VA = "0x180BF8AB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0xBF8020", Offset = "0xBF7020", VA = "0x180BF8020")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public virtual bool CBCABKOBHNK
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0xA3A820", Offset = "0xA39820", VA = "0x180A3A820", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public bool EOEIMOLOCDF
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x7AC6710", Offset = "0x7AC5710", VA = "0x187AC6710")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public virtual bool PHCKAPCMLDD
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0xA3A820", Offset = "0xA39820", VA = "0x180A3A820", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public virtual bool ILILGPBGCPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A680", VA = "0x180A0B680", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public virtual bool DAPKBBHDKOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0xA3A820", Offset = "0xA39820", VA = "0x180A3A820", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public EEFKKODIKGJ PGJMAJLFKCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0xA9F930", Offset = "0xA9E930", VA = "0x180A9F930")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x7AC6ED0", Offset = "0x7AC5ED0", VA = "0x187AC6ED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public EKFIOJKBHPO LGEIPIKACBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0xAA0EB0", Offset = "0xA9FEB0", VA = "0x180AA0EB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x7AC72D0", Offset = "0x7AC62D0", VA = "0x187AC72D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public EKFIOJKBHPO MEJGBGHHDEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0xAB04C0", Offset = "0xAAF4C0", VA = "0x180AB04C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x7AC75A0", Offset = "0x7AC65A0", VA = "0x187AC75A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		protected Material AFMMCPLDBKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x7AB97D0", Offset = "0x7AB87D0", VA = "0x187AB97D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		protected Material NBKJBKDHABD
		{
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x7ABC730", Offset = "0x7ABB730", VA = "0x187ABC730")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public bool ONIOPBNDBLD
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x21A07A0", Offset = "0x219F7A0", VA = "0x1821A07A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public PlayerFacialAnimatorBase JHNDPNFOGKE
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0xAB06D0", Offset = "0xAAF6D0", VA = "0x180AB06D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public GBHBDCHAKAB[] JOAEMCNBDEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x7AC62D0", Offset = "0x7AC52D0", VA = "0x187AC62D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public GBHBDCHAKAB DHLJDEDPMHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x7AC6910", Offset = "0x7AC5910", VA = "0x187AC6910")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public GBHBDCHAKAB PCGIEIEEJPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x7AC6940", Offset = "0x7AC5940", VA = "0x187AC6940")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public Mesh IMFLEJGCGOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0xAB0EE0", Offset = "0xAAFEE0", VA = "0x180AB0EE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		protected FKKJNMIPHBA BFNIKHIFEIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x7ABD220", Offset = "0x7ABC220", VA = "0x187ABD220")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		protected ALBMIKCECHI AAGMEDKDFHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0xAB1270", Offset = "0xAB0270", VA = "0x180AB1270")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x7ABE4E0", Offset = "0x7ABD4E0", VA = "0x187ABE4E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		protected bool KJIMCOKKLJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A680", VA = "0x180A0B680")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public bool OJIOHDKBAJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x7AC6900", Offset = "0x7AC5900", VA = "0x187AC6900")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public int IOPMMHKPGGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x11D5D80", Offset = "0x11D4D80", VA = "0x1811D5D80")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x7AC74E0", Offset = "0x7AC64E0", VA = "0x187AC74E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public int JKKLGABGFDJ
		{
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x7AC7220", Offset = "0x7AC6220", VA = "0x187AC7220")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		protected virtual bool GELBALGDKNO
		{
			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0xA3A820", Offset = "0xA39820", VA = "0x180A3A820", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		protected virtual int[] NKHBJLBCEMH
		{
			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x7AC15F0", Offset = "0x7AC05F0", VA = "0x187AC15F0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		protected bool JIFPFCLIKKP
		{
			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x7ABFEB0", Offset = "0x7ABEEB0", VA = "0x187ABFEB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		protected static bool CNGCPGLIGCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0xA3A820", Offset = "0xA39820", VA = "0x180A3A820")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public bool FOKCFFDOPNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x11D7020", Offset = "0x11D6020", VA = "0x1811D7020")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x7AC77C0", Offset = "0x7AC67C0", VA = "0x187AC77C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public IEnumerable<SkinnedMeshRenderer> KFBIHPKPNGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x7AC61B0", Offset = "0x7AC51B0", VA = "0x187AC61B0")]
			[IteratorStateMachine(typeof(LJKKABCBPLB))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public bool DINPHDIMOPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x11D7FE0", Offset = "0x11D6FE0", VA = "0x1811D7FE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x11D7EA0", Offset = "0x11D6EA0", VA = "0x1811D7EA0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public BLMBMEMIHNO CGILOPKPFBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x7AC6230", Offset = "0x7AC5230", VA = "0x187AC6230")]
			get
			{
				return default(BLMBMEMIHNO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public static bool NPGPGBMBKAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x7AC6680", Offset = "0x7AC5680", VA = "0x187AC6680")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		protected static OLILOOIADED GAHENGCMMCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x7ABE200", Offset = "0x7ABD200", VA = "0x187ABE200")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0x7AC1680", Offset = "0x7AC0680", VA = "0x187AC1680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		protected Color CIANNEIDAAI
		{
			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0x7ABE610", Offset = "0x7ABD610", VA = "0x187ABE610")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		protected Color GFMAIPOMMOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0x7ABC6E0", Offset = "0x7ABB6E0", VA = "0x187ABC6E0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		protected Texture2D DGNKKCNDKPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000291")]
			[Cpp2IlInjected.Address(RVA = "0x7AC1FA0", Offset = "0x7AC0FA0", VA = "0x187AC1FA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		protected Color JIPGBOFPJKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000297")]
			[Cpp2IlInjected.Address(RVA = "0x7AC00E0", Offset = "0x7ABF0E0", VA = "0x187AC00E0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		protected Color BCLIKDAECBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(RVA = "0x7AC1030", Offset = "0x7AC0030", VA = "0x187AC1030")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public CKKEFOLDDDM PMGOFHFODNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000299")]
			[Cpp2IlInjected.Address(RVA = "0x7AC6290", Offset = "0x7AC5290", VA = "0x187AC6290")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		protected Texture2D BMFIBAMHPDE
		{
			[Cpp2IlInjected.Token(Token = "0x600029A")]
			[Cpp2IlInjected.Address(RVA = "0x7ABC540", Offset = "0x7ABB540", VA = "0x187ABC540")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public float PJBKIBAJDBK
		{
			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(RVA = "0x7AC62B0", Offset = "0x7AC52B0", VA = "0x187AC62B0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public float GJAJBMMKLPF
		{
			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0x7AC66F0", Offset = "0x7AC56F0", VA = "0x187AC66F0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public bool LKCOOOOPHDC
		{
			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x1336CD0", Offset = "0x1335CD0", VA = "0x181336CD0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x7AC6CB0", Offset = "0x7AC5CB0", VA = "0x187AC6CB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action GIJDKDPBBDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x7AC5F10", Offset = "0x7AC4F10", VA = "0x187AC5F10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x7AC6A10", Offset = "0x7AC5A10", VA = "0x187AC6A10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action LFPIFNOBAOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x7AC5E70", Offset = "0x7AC4E70", VA = "0x187AC5E70")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x7AC6970", Offset = "0x7AC5970", VA = "0x187AC6970")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action KJLOLHLFIGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x7AC5FB0", Offset = "0x7AC4FB0", VA = "0x187AC5FB0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x7AC6AB0", Offset = "0x7AC5AB0", VA = "0x187AC6AB0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action BJOIGICLNOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x7AC6050", Offset = "0x7AC5050", VA = "0x187AC6050")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x7AC6B50", Offset = "0x7AC5B50", VA = "0x187AC6B50")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<ECEPGPDPDKI, ACKOLLANMDJ> OHCGCLHBHHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x7AC60F0", Offset = "0x7AC50F0", VA = "0x187AC60F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x7AC6BF0", Offset = "0x7AC5BF0", VA = "0x187AC6BF0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x7AC2CB0", Offset = "0x7AC1CB0", VA = "0x187AC2CB0")]
		public bool SetDeformation(bool APHODKKNMPK, bool BKPHMFMOBOE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x7AB9340", Offset = "0x7AB8340", VA = "0x187AB9340")]
		protected static Material ACNIMILDKCE(Dictionary<DAACLJKOJBJ, Material> KEMDFPKPCOM, Material OJHFGKAFIEJ, IBAFKCJOEOA GMLOOFHADHO, NNMEKCBBIJP PGOOBBKNDOF, LEMFDNDBDJC BDNPFHIBMNH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x7ABE8E0", Offset = "0x7ABD8E0", VA = "0x187ABE8E0")]
		protected void IGFNPGNBCFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x7AC0130", Offset = "0x7ABF130", VA = "0x187AC0130")]
		protected bool MJFGPAOJKGH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x7ABEDB0", Offset = "0x7ABDDB0", VA = "0x187ABEDB0")]
		protected void JDLJBJNHCAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x7AC0FD0", Offset = "0x7ABFFD0", VA = "0x187AC0FD0", Slot = "10")]
		protected virtual void OAACECFAIIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x7AC0D90", Offset = "0x7ABFD90", VA = "0x187AC0D90")]
		public int MeshesAtLODCount(int BAGGAHKJIOH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x7ABDAA0", Offset = "0x7ABCAA0", VA = "0x187ABDAA0")]
		protected static void GOJDBMHGHLN(Dictionary<EMNJOPNCDMC, List<DAACLJKOJBJ>> DHPEMHCCIBM, GDNBCAAJINI DNPMBJLIGEP, Material OJHFGKAFIEJ, IBAFKCJOEOA FKAIEBDGNCN, NNMEKCBBIJP IHIJDFFNDNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x7ABB510", Offset = "0x7ABA510", VA = "0x187ABB510")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x7ABC210", Offset = "0x7ABB210", VA = "0x187ABC210")]
		protected void CGDAEDIEINB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x7AC1C20", Offset = "0x7AC0C20", VA = "0x187AC1C20")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "11")]
		protected virtual void KJOJBNECHKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x7AB90F0", Offset = "0x7AB80F0", VA = "0x187AB90F0")]
		protected static void AALDLHGPDBG(List<Material> HAIHHPIOHNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x7AC1490", Offset = "0x7AC0490", VA = "0x187AC1490")]
		protected static void OELFCHAKDMH(Dictionary<DAACLJKOJBJ, Material> KEMDFPKPCOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x7ABFF30", Offset = "0x7ABEF30", VA = "0x187ABFF30")]
		protected static void LNHBEJIKCOC(Dictionary<Renderer, DNOBIKFHBLF> JGEDDGOCJII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x7AC0C70", Offset = "0x7ABFC70", VA = "0x187AC0C70")]
		protected void MOMLGHGHKAB(SkinnedMeshRenderer[] GMCMJGGCAFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x7AC1080", Offset = "0x7AC0080", VA = "0x187AC1080")]
		protected void OBKENODFJNH(SkinnedMeshRenderer KMAINCIGCMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x7AC1120", Offset = "0x7AC0120", VA = "0x187AC1120")]
		protected void OBKENODFJNH(MeshRenderer NHJJDLPOEGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x7AC0A90", Offset = "0x7ABFA90", VA = "0x187AC0A90")]
		protected void MNCEHLGEMCP(List<KBJDIMPKBHI> HOFMPDNMMNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x7AC0E50", Offset = "0x7ABFE50", VA = "0x187AC0E50")]
		protected void NFGNFEFIHCM(Dictionary<string, GKHPBLLBAIL<Texture2D>> DHPEMHCCIBM, bool HPAPGOPEPHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x7ABF800", Offset = "0x7ABE800", VA = "0x187ABF800")]
		protected void KGPAMBHLJJO(Dictionary<EMNJOPNCDMC, List<DAACLJKOJBJ>> DHPEMHCCIBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x7ABDD90", Offset = "0x7ABCD90", VA = "0x187ABDD90")]
		public float GetHandOpenClosedAxis(ECEPGPDPDKI LKCJMGGAGMB)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x7AC3550", Offset = "0x7AC2550", VA = "0x187AC3550")]
		public void SetHandOpenClosedAxis(ECEPGPDPDKI LKCJMGGAGMB, float JONIFPGEBGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x7ABDDD0", Offset = "0x7ABCDD0", VA = "0x187ABDDD0")]
		public ACKOLLANMDJ GetHandVisualState(ECEPGPDPDKI LKCJMGGAGMB)
		{
			return default(ACKOLLANMDJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x7ABAC50", Offset = "0x7AB9C50", VA = "0x187ABAC50")]
		public bool AddHandVisualStateToken(ECEPGPDPDKI LKCJMGGAGMB, ACKOLLANMDJ CKNBEIHOPMB, object EJJDDFFADPC, GBHBDCHAKAB.AABNHAOHPIF DPEJEDCKJBD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x7AC4D60", Offset = "0x7AC3D60", VA = "0x187AC4D60")]
		public void SetWatchHand(ECEPGPDPDKI LKCJMGGAGMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x7AC4E20", Offset = "0x7AC3E20", VA = "0x187AC4E20")]
		public void SetWatchHands(bool LOHLPDEMOJD, bool PEAMGGIJCDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x7AC2370", Offset = "0x7AC1370", VA = "0x187AC2370")]
		public bool RemoveHandVisualStateToken(ECEPGPDPDKI LKCJMGGAGMB, object EJJDDFFADPC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x7ABDE50", Offset = "0x7ABCE50", VA = "0x187ABDE50")]
		public bool GetThumbsUpActive(ECEPGPDPDKI LKCJMGGAGMB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x7AC4800", Offset = "0x7AC3800", VA = "0x187AC4800")]
		public void SetThumbsUpActive(ECEPGPDPDKI LKCJMGGAGMB, bool EIKAKAHNFFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x7ABDE10", Offset = "0x7ABCE10", VA = "0x187ABDE10")]
		public bool GetHandshakeActive(ECEPGPDPDKI LKCJMGGAGMB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x7AC35A0", Offset = "0x7AC25A0", VA = "0x187AC35A0")]
		public void SetHandshakeActive(ECEPGPDPDKI LKCJMGGAGMB, bool EHBJGIHGLOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x7ABD540", Offset = "0x7ABC540", VA = "0x187ABD540")]
		public void ForceUpdateHandsVisualState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x7ABCE20", Offset = "0x7ABBE20", VA = "0x187ABCE20")]
		public static void ClearQueuedBuilds()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x7ABE250", Offset = "0x7ABD250", VA = "0x187ABE250")]
		private static void HNFGGECEKFE(Scene CHJMGPBPDEK, LoadSceneMode MECLDBHCDJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x7AB9230", Offset = "0x7AB8230", VA = "0x187AB9230")]
		protected static void ABMBGDJGFDN(PlayerAvatarDisplayBase FDDEDELKECL, List<BBOCIFIGBHP> JCKEJHBHIKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x7AC2090", Offset = "0x7AC1090", VA = "0x187AC2090")]
		public HPIGCMLNLFB Rebuild(bool CHCCINKDNBK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x7ABBA00", Offset = "0x7ABAA00", VA = "0x187ABBA00")]
		protected HPIGCMLNLFB BMJPBCDIMBJ(bool CHCCINKDNBK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x7ABBA50", Offset = "0x7ABAA50", VA = "0x187ABBA50", Slot = "12")]
		protected virtual HPIGCMLNLFB BMJPBCDIMBJ(IList<EMNJOPNCDMC> CBHKPCEHICG, AvatarItemBodyType JJNOCFGNJGJ, bool EEAEBGKMHGP, int[] GDHEBGBAJMD, bool CHCCINKDNBK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x7ABEFB0", Offset = "0x7ABDFB0", VA = "0x187ABEFB0")]
		protected static HPIGCMLNLFB JJIMMIOOKEO(BBOCIFIGBHP IFPIKDGGHIP, List<BBOCIFIGBHP> JCKEJHBHIKC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x7ABD1C0", Offset = "0x7ABC1C0", VA = "0x187ABD1C0")]
		[IteratorStateMachine(typeof(KEEBFFFINOI))]
		protected static IEnumerator<NFNODNEANBN> EJDCOLHPJPA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x7AC09D0", Offset = "0x7ABF9D0", VA = "0x187AC09D0")]
		protected static BBOCIFIGBHP MMGKKCBFHNG(List<BBOCIFIGBHP> JCKEJHBHIKC)
		{
			return default(BBOCIFIGBHP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x7AC2DC0", Offset = "0x7AC1DC0", VA = "0x187AC2DC0")]
		[AsyncStateMachine(typeof(PIILMPKDMDA))]
		public Task SetFaceCustomizationSettings(MAKBECHNCGC MNFOAJDGMOA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7ABECF0", Offset = "0x7ABDCF0", VA = "0x187ABECF0")]
		public void InitializeFaceFeatures(AvatarConfiguration NGKBNOKDLJN, BLMBMEMIHNO JDMGBLFHDLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x7AC4550", Offset = "0x7AC3550", VA = "0x187AC4550")]
		public void SetTeamColors(Color? CDCECCBAMKD, bool PMLJACMFCGB, Color FOOPJDADBNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x1280700", Offset = "0x127F700", VA = "0x181280700")]
		private static void ABLICHLPEJG(Material CANJBFKPEMF, Color OHLIHBDBKCE, params int[] PEPHNJHHFII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x1281F20", Offset = "0x1280F20", VA = "0x181281F20")]
		private static void KGLHLJGLLOO(Material CANJBFKPEMF, Texture OHLIHBDBKCE, params int[] PEPHNJHHFII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x7ABE660", Offset = "0x7ABD660", VA = "0x187ABE660")]
		protected void IFJBJDIBEEP(Material KCFANBEOAGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x7ABF960", Offset = "0x7ABE960", VA = "0x187ABF960")]
		protected void KNDDBHAJDDH(Material KCFANBEOAGC, Color FFKDKFFFLJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x7ABBFE0", Offset = "0x7ABAFE0", VA = "0x187ABBFE0")]
		protected void CGBAJANPKDH(Material KCFANBEOAGC, Color FFKDKFFFLJI, Color PCNBINHACDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x7ABD640", Offset = "0x7ABC640", VA = "0x187ABD640")]
		protected void GGMLDEFFPBC(Material KCFANBEOAGC, Texture2D BFGBBIJNNHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x7ABB8F0", Offset = "0x7ABA8F0", VA = "0x187ABB8F0")]
		protected void BIFKOANKICK(Material KCFANBEOAGC, Texture LJGGMGAEHBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x7ABE380", Offset = "0x7ABD380", VA = "0x187ABE380")]
		protected void IBBNNJCLPEJ(Action<DNOBIKFHBLF> GBFPEDHKGBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x7ABD860", Offset = "0x7ABC860", VA = "0x187ABD860")]
		protected void GHAGFEOHPJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x7ABB6A0", Offset = "0x7ABA6A0", VA = "0x187ABB6A0")]
		protected void BBIKNLDPMGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x7ABBBF0", Offset = "0x7ABABF0", VA = "0x187ABBBF0")]
		protected void CAPNFLHKIKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x7ABAFA0", Offset = "0x7AB9FA0", VA = "0x187ABAFA0")]
		public void ApplyUgcItemOverrides()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x7AC2730", Offset = "0x7AC1730", VA = "0x187AC2730")]
		public void SetBeardPrimaryColor([Optional] Color? OEBIHMNGAHE, bool EDCNDCKDDHI = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x7AC2950", Offset = "0x7AC1950", VA = "0x187AC2950")]
		public void SetBeardSecondaryColor([Optional] Color? OEBIHMNGAHE, bool EDCNDCKDDHI = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x7AC25F0", Offset = "0x7AC15F0", VA = "0x187AC25F0")]
		public void SetBeardPattern([Optional] AvatarHairPattern HBKAMIDNPLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x7ABEE40", Offset = "0x7ABDE40", VA = "0x187ABEE40")]
		private void JEMOPPLHLHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x7ABEBA0", Offset = "0x7ABDBA0", VA = "0x187ABEBA0")]
		private bool INELLDPGPKA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x7AC3130", Offset = "0x7AC2130", VA = "0x187AC3130")]
		public void SetHairPrimaryColor([Optional] Color? FAOPFFICEGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x7AC3340", Offset = "0x7AC2340", VA = "0x187AC3340")]
		public void SetHairSecondaryColor([Optional] Color? FAOPFFICEGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x7AC3000", Offset = "0x7AC2000", VA = "0x187AC3000")]
		public void SetHairPattern([Optional] AvatarHairPattern HBKAMIDNPLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x7AC2210", Offset = "0x7AC1210", VA = "0x187AC2210")]
		public void RefreshHair()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x7ABFB10", Offset = "0x7ABEB10", VA = "0x187ABFB10")]
		private bool LCDGIPEHJJF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x7AC4390", Offset = "0x7AC3390", VA = "0x187AC4390")]
		public void SetSkinColor(Color HOKBFOFIGDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x7AC4850", Offset = "0x7AC3850", VA = "0x187AC4850")]
		public void SetUgcItemVisualOverrides(EMNJOPNCDMC HNMCGDBFDGH, BLMBMEMIHNO JDMGBLFHDLB, Texture FKIMBDHIBDN, Color FMGCKKPOHKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x7ABCEF0", Offset = "0x7ABBEF0", VA = "0x187ABCEF0")]
		public void ClearUgcItemVisualOverrides()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x7AC2EC0", Offset = "0x7AC1EC0", VA = "0x187AC2EC0")]
		public bool SetFaceShape(AvatarFaceShape NOLJPELCPGH, bool HFPBIAGEELK = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x7AC11F0", Offset = "0x7AC01F0", VA = "0x187AC11F0")]
		private void OCOHJLBJOOC(OAIBHFEEBFF OHKLPMGKCNP, float OHLIHBDBKCE, bool NGGBHLHDOAO = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x7AC0350", Offset = "0x7ABF350", VA = "0x187AC0350")]
		private void MJNHAGFKPDE(KCGDHGHDIFP FGHDADLFLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x7ABEC50", Offset = "0x7ABDC50", VA = "0x187ABEC50")]
		private void IPEJBKIPPIA(OGHEPKGNCBA LHCBLABBENF, float OHLIHBDBKCE, bool CNDBMNGCPEP = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x7ABF5D0", Offset = "0x7ABE5D0", VA = "0x187ABF5D0")]
		private void JMAGOFIIPAD(OJGFLCIKIFC GKKKGOHEELC, float OHLIHBDBKCE, bool ONLNMKMBDBE = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x7ABF850", Offset = "0x7ABE850", VA = "0x187ABF850")]
		private void KHMBFAFJHHO(MDLGKOMCHJL ABCMKKBACLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x7AC18A0", Offset = "0x7AC08A0", VA = "0x187AC18A0")]
		private void OIKCHILEPGD(NOIJAGJBAKE GFGHPGGNOIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x7AC2B70", Offset = "0x7AC1B70", VA = "0x187AC2B70")]
		public bool SetBodyShape(AvatarBodyShape JNNFLNPDLLA, bool HFPBIAGEELK = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x7AC4220", Offset = "0x7AC3220", VA = "0x187AC4220")]
		public bool SetNoseType(ABOJDNCODIG AEHFOHDJDBI, bool HFPBIAGEELK = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x7AC4F80", Offset = "0x7AC3F80", VA = "0x187AC4F80")]
		public bool UpdateFaceAndBodyShapes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x7AC4200", Offset = "0x7AC3200", VA = "0x187AC4200")]
		public bool SetHideEars(bool MFMFGJHHMIK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x7AC41F0", Offset = "0x7AC31F0", VA = "0x187AC41F0")]
		public bool SetHelmetHair(OJELMNHDJHH LPMFGFAMFBN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x7AC35F0", Offset = "0x7AC25F0", VA = "0x187AC35F0")]
		public void SetHatAnchorParameters(HMAKLDEGKBC PKHDLMKMENB, bool GFMMOMPEDID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x7AC4EF0", Offset = "0x7AC3EF0", VA = "0x187AC4EF0")]
		public void SetupDisplayLODs(NMOIBHCNNGG FFKEGPJGFCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x7ABD280", Offset = "0x7ABC280", VA = "0x187ABD280")]
		protected int[] EOJPPJDCFJG(NMOIBHCNNGG FFKEGPJGFCC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x7AC42C0", Offset = "0x7AC32C0", VA = "0x187AC42C0")]
		public void SetOutfitSelections(IList<EMNJOPNCDMC> CBHKPCEHICG, AvatarItemBodyType JJNOCFGNJGJ, bool CHCCINKDNBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x7AC4300", Offset = "0x7AC3300", VA = "0x187AC4300")]
		public void SetOutfitSelections(IList<EMNJOPNCDMC> CBHKPCEHICG, AvatarItemBodyType JJNOCFGNJGJ, bool EEAEBGKMHGP, bool CHCCINKDNBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x7AC4340", Offset = "0x7AC3340", VA = "0x187AC4340")]
		public HPIGCMLNLFB SetOutfitSelections(IList<EMNJOPNCDMC> CBHKPCEHICG, AvatarItemBodyType JJNOCFGNJGJ, NMOIBHCNNGG FFKEGPJGFCC, bool EEAEBGKMHGP, bool HFPBIAGEELK = false, bool CHCCINKDNBK = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x7ABFBD0", Offset = "0x7ABEBD0", VA = "0x187ABFBD0", Slot = "13")]
		protected virtual HPIGCMLNLFB LFHIKEMHCEG(IList<EMNJOPNCDMC> CBHKPCEHICG, AvatarItemBodyType JJNOCFGNJGJ, bool EEAEBGKMHGP, NMOIBHCNNGG FFKEGPJGFCC, bool HFPBIAGEELK, bool CHCCINKDNBK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x7AC19A0", Offset = "0x7AC09A0", VA = "0x187AC19A0")]
		protected int[] OJODJKDMAJL(NMOIBHCNNGG FFKEGPJGFCC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x9F0230", Offset = "0x9EF230", VA = "0x1809F0230", Slot = "14")]
		protected virtual ALBMIKCECHI ELODBECDEDF(AvatarItemBodyType MLPKEOCLJHM, Dictionary<string, ALBBMKANDAF> CPOJAFHJIFH, Dictionary<string, GKHPBLLBAIL<Texture2D>> FCLOCFEJAMM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x7ABDF30", Offset = "0x7ABCF30", VA = "0x187ABDF30", Slot = "15")]
		protected virtual HPIGCMLNLFB HKCIHMLEPNG(IList<EMNJOPNCDMC> CBHKPCEHICG, AvatarItemBodyType JJNOCFGNJGJ, bool EEAEBGKMHGP, int[] KIOKNKHEIMB, JICFHOJONOI BDDLEIHELIB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x7AC0550", Offset = "0x7ABF550", VA = "0x187AC0550", Slot = "16")]
		protected virtual ALBBMKANDAF MKHAOJDCPCD(CKKEFOLDDDM NPDKKINBDDF, AvatarItemBodyType MLPKEOCLJHM, LEMFDNDBDJC BDNPFHIBMNH, ALBBMKANDAF COELBOAOKHO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x9F0230", Offset = "0x9EF230", VA = "0x1809F0230", Slot = "17")]
		protected virtual ALBBMKANDAF PHLHBNHBHKF(AvatarItemBodyType MLPKEOCLJHM, LEMFDNDBDJC BDNPFHIBMNH, GADAOPIMBPG JDPKJPILGNF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x7ABF670", Offset = "0x7ABE670", VA = "0x187ABF670")]
		protected void KCAGDNGKKHE(OMFDGHDDKHE HDLDJFCINHD, DJMKKMKOHOE.KHMINOCKMDE PFMMBFIBAED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x7ABF6F0", Offset = "0x7ABE6F0", VA = "0x187ABF6F0")]
		protected void KCNFGFAOLDN(OMFDGHDDKHE HDLDJFCINHD, DJMKKMKOHOE.KHMINOCKMDE PFMMBFIBAED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0xA75AA0", Offset = "0xA74AA0", VA = "0x180A75AA0", Slot = "18")]
		protected virtual OMFDGHDDKHE PMIDAJGBINL(OMFDGHDDKHE HDLDJFCINHD, HelmetHairStyle EKBENDICGMI, bool NGLAKBLHMLH, AvatarItemBodyType JJNOCFGNJGJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x7AB9A10", Offset = "0x7AB8A10", VA = "0x187AB9A10")]
		protected OMFDGHDDKHE ALBJFCDCIFJ(IList<EMNJOPNCDMC> CBHKPCEHICG, AvatarItemBodyType FLBPMOLOPPJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x7ABCD00", Offset = "0x7ABBD00", VA = "0x187ABCD00")]
		public void CleanupDisplayResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x7ABD590", Offset = "0x7ABC590", VA = "0x187ABD590")]
		protected void GBLAEBPNDEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x7AB94A0", Offset = "0x7AB84A0", VA = "0x187AB94A0")]
		protected void ADPKIHPOJEP(Transform MGBMHIAPDFD, IEnumerable<SkinnedMeshRenderer> DNDNGDEDHHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x7ABD480", Offset = "0x7ABC480", VA = "0x187ABD480")]
		protected DJMKKMKOHOE.KHMINOCKMDE FPLJPPJCAIA(DJMKKMKOHOE.KHMINOCKMDE PPBPOBKGLON, LEMFDNDBDJC OJOHFHDBACP)
		{
			return default(DJMKKMKOHOE.KHMINOCKMDE);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x7ABD010", Offset = "0x7ABC010", VA = "0x187ABD010")]
		protected void DFCLCNFGEDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x1207680", Offset = "0x1206680", VA = "0x181207680")]
		protected void IKMHBEDBLIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x7AC1AA0", Offset = "0x7AC0AA0", VA = "0x187AC1AA0")]
		protected void OKKEOHOEAHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x7AC1ED0", Offset = "0x7AC0ED0", VA = "0x187AC1ED0")]
		[AsyncStateMachine(typeof(KKCGNEAAMDP))]
		protected Task PCDDELKMMBC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x7ABEA00", Offset = "0x7ABDA00", VA = "0x187ABEA00")]
		protected static IBAFKCJOEOA IGLIHIPGIPB(GDNBCAAJINI DADFPFCEPAK, int FPNNGFNMBMA)
		{
			return default(IBAFKCJOEOA);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x7ABD070", Offset = "0x7ABC070", VA = "0x187ABD070")]
		protected static NNMEKCBBIJP DKELNJIGIDP(GDNBCAAJINI DADFPFCEPAK, int FPNNGFNMBMA)
		{
			return default(NNMEKCBBIJP);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x7AC1850", Offset = "0x7AC0850", VA = "0x187AC1850")]
		protected Transform OIJOOMFAPHM(LEMFDNDBDJC BDNPFHIBMNH, OutfitType KAMFIEKLGNP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x7AC1290", Offset = "0x7AC0290", VA = "0x187AC1290")]
		protected void ODEGJEIOILA(int KMLNOHKPNFG, Material CANJBFKPEMF, GDNBCAAJINI DADFPFCEPAK, [Out] Texture2D MGPEMBAGNBN, [Out] Vector4 ANNENBEHPMI, [Out] Texture2D KMMLDOAJCOM, [Out] Texture2D BNKFBNNLFHF, [Out] Texture2D IEHNFAOCACL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x7ABAA20", Offset = "0x7AB9A20", VA = "0x187ABAA20")]
		protected void ALKFAAJACAO(int KMLNOHKPNFG, Material CANJBFKPEMF, GDNBCAAJINI DADFPFCEPAK, [Out] Color BCJBJCJEEOB, [Out] Color DENCMJLNDEA, [Out] Color GNOGEJFGEHI, [Out] Color EMEEOLPKGGL, [Out] Color MEAICLBLNAP, [Out] Color MOIBEGCKKBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x7AC1BB0", Offset = "0x7AC0BB0", VA = "0x187AC1BB0")]
		protected void OLBOAKKALAI(Vector3 MJJFMHOFJKF, Quaternion GMKIGHDIIHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x7AC3BA0", Offset = "0x7AC2BA0", VA = "0x187AC3BA0")]
		public void SetHatAnchorParameters(HMAKLDEGKBC PKHDLMKMENB, AnchorParamsRestrictions FOKOPHDADKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x7ABC820", Offset = "0x7ABB820", VA = "0x187ABC820")]
		public static void CalculateHatAnchorParams(FitMeshHemisphere CPHGACAMCNJ, Transform GCAOHBMKLFM, HMAKLDEGKBC PKHDLMKMENB, AnchorParamsRestrictions DFNIKEMKODL, [Out] Vector3 IHMLAPGNLCC, [Out] Quaternion JHMNNKLOODA, [Out] HMAKLDEGKBC JBGPOMHMLMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x7AC2480", Offset = "0x7AC1480", VA = "0x187AC2480")]
		public void ResetHatAnchor(Vector2 FFELCDAPPJI, Vector3 LGAJDNIMLAA, Vector3 GILNNGGNLNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0xA8C110", Offset = "0xA8B110", VA = "0x180A8C110")]
		public NFNPBLMBHAL GetAnchorParamsRestrictions()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x7ABADD0", Offset = "0x7AB9DD0", VA = "0x187ABADD0")]
		public void ApplyBlocks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x7ABAF10", Offset = "0x7AB9F10", VA = "0x187ABAF10")]
		public void ApplyHairPattern()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x7ABAD40", Offset = "0x7AB9D40", VA = "0x187ABAD40")]
		public void ApplyBeardPattern()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x7AC4F20", Offset = "0x7AC3F20", VA = "0x187AC4F20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x7ABCF40", Offset = "0x7ABBF40", VA = "0x187ABCF40")]
		protected void DDHACPAMCEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x7AC4CE0", Offset = "0x7AC3CE0", VA = "0x187AC4CE0")]
		public void SetWaitForUgcTextureLoads(bool LKECFFEIFNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x7AC4BF0", Offset = "0x7AC3BF0", VA = "0x187AC4BF0")]
		public void SetUgcTextureParameters(NAFFPEBCHPI PMLCGCAHNGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x7AC5860", Offset = "0x7AC4860", VA = "0x187AC5860")]
		public PlayerAvatarDisplayBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x7ABF770", Offset = "0x7ABE770", VA = "0x187ABF770")]
		[CompilerGenerated]
		private void KEBPLPGHJJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x7ABBBC0", Offset = "0x7ABABC0", VA = "0x187ABBBC0")]
		[CompilerGenerated]
		private void BPNCMELENGC(DNOBIKFHBLF FHHMDKONHLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x7ABFA80", Offset = "0x7ABEA80", VA = "0x187ABFA80")]
		[CompilerGenerated]
		private void LBKLOOENCNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x7ABC640", Offset = "0x7ABB640", VA = "0x187ABC640")]
		[CompilerGenerated]
		private void CJDEPNNKLKN(DNOBIKFHBLF FHHMDKONHLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x7ABE580", Offset = "0x7ABD580", VA = "0x187ABE580")]
		[CompilerGenerated]
		private void IEMMMLKDJKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x7ABDE90", Offset = "0x7ABCE90", VA = "0x187ABDE90")]
		[CompilerGenerated]
		private void HJMNNAJNEMC(DNOBIKFHBLF FHHMDKONHLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x7ABBF50", Offset = "0x7ABAF50", VA = "0x187ABBF50")]
		[CompilerGenerated]
		private void CCEPHOLBBBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x7AC0090", Offset = "0x7ABF090", VA = "0x187AC0090")]
		[CompilerGenerated]
		private void MAJDEAJHJJC(DNOBIKFHBLF FHHMDKONHLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x7ABFE20", Offset = "0x7ABEE20", VA = "0x187ABFE20")]
		[CompilerGenerated]
		private void LFNOHJHMAGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x7ABD020", Offset = "0x7ABC020", VA = "0x187ABD020")]
		[CompilerGenerated]
		private void DGOHBKEFPLJ(DNOBIKFHBLF FHHMDKONHLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x7ABB860", Offset = "0x7ABA860", VA = "0x187ABB860")]
		[CompilerGenerated]
		private void BDJDHOBLOCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x7ABBBA0", Offset = "0x7ABABA0", VA = "0x187ABBBA0")]
		[CompilerGenerated]
		private void BNGLEOMFDKA(DNOBIKFHBLF FHHMDKONHLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x7ABAB70", Offset = "0x7AB9B70", VA = "0x187ABAB70")]
		[CompilerGenerated]
		internal static bool AOLICEMBLOH(Transform JOKAGHLDFKD, IEnumerable<SkinnedMeshRenderer> NHMDKOPANCI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x7ABD440", Offset = "0x7ABC440", VA = "0x187ABD440")]
		[CompilerGenerated]
		private void EPCLJCCEPKI(DNOBIKFHBLF FHHMDKONHLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x7ABD240", Offset = "0x7ABC240", VA = "0x187ABD240")]
		[CompilerGenerated]
		private void EOGJKDMHFBE(DNOBIKFHBLF FHHMDKONHLB)
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
			[Cpp2IlInjected.Token(Token = "0x4000462")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000463")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000464")]
			public MAKBECHNCGC avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000465")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000466")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0x7ACE3E0", Offset = "0x7ACD3E0", VA = "0x187ACE3E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039E")]
			[Cpp2IlInjected.Address(RVA = "0x7ACE670", Offset = "0x7ACD670", VA = "0x187ACE670", Slot = "5")]
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
			public BLMBMEMIHNO avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400046F")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0x7ACE170", Offset = "0x7ACD170", VA = "0x187ACE170", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A0")]
			[Cpp2IlInjected.Address(RVA = "0x7ACE350", Offset = "0x7ACD350", VA = "0x187ACE350", Slot = "5")]
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
			public BLMBMEMIHNO avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000476")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A1")]
			[Cpp2IlInjected.Address(RVA = "0x7ACF950", Offset = "0x7ACE950", VA = "0x187ACF950", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0x7ACFAF0", Offset = "0x7ACEAF0", VA = "0x187ACFAF0", Slot = "5")]
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
			public MAKBECHNCGC avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400047B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0x7AC8DE0", Offset = "0x7AC7DE0", VA = "0x187AC8DE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x7AC8F90", Offset = "0x7AC7F90", VA = "0x187AC8F90", Slot = "5")]
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
			public BLMBMEMIHNO avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000480")]
			private TaskAwaiter<KIAELDLCAEI> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x7ACE9A0", Offset = "0x7ACD9A0", VA = "0x187ACE9A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x7ACEDE0", Offset = "0x7ACDDE0", VA = "0x187ACEDE0", Slot = "5")]
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
			public BLMBMEMIHNO avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000486")]
			private FaceStyleSet <styleSet>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000487")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x7ACEE40", Offset = "0x7ACDE40", VA = "0x187ACEE40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x7ACF320", Offset = "0x7ACE320", VA = "0x187ACF320", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		protected const float BNCECIOJIHF = 0.5f;

		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		protected const int ECNMMMGOGDF = 5;

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
		protected static readonly Dictionary<GOPMEEGJDMI.MONNCAKECLO, int> HOPKPIFMJJF;

		[Cpp2IlInjected.Token(Token = "0x4000408")]
		[CanBeNull]
		protected static IEnumerable<FaceFeatureType> NPHEOCFMGDC;

		[Cpp2IlInjected.Token(Token = "0x4000409")]
		protected static readonly int NJJJCPCPFLJ;

		[Cpp2IlInjected.Token(Token = "0x400040A")]
		protected static readonly int KDHILIFKAKB;

		[Cpp2IlInjected.Token(Token = "0x400040B")]
		protected static readonly int MGNCCFMICBK;

		[Cpp2IlInjected.Token(Token = "0x400040C")]
		protected static readonly int PFEELKDLGJC;

		[Cpp2IlInjected.Token(Token = "0x400040D")]
		protected static readonly int JFOOAEDJKDF;

		[Cpp2IlInjected.Token(Token = "0x400040E")]
		protected static readonly int LPLADOHJNLE;

		[Cpp2IlInjected.Token(Token = "0x400040F")]
		protected static readonly int HGNKPOHAEMC;

		[Cpp2IlInjected.Token(Token = "0x4000410")]
		protected static readonly int HGBCAOBHHBE;

		[Cpp2IlInjected.Token(Token = "0x4000411")]
		protected static Vector2 OCFJPIJKGMN;

		[Cpp2IlInjected.Token(Token = "0x4000412")]
		protected static Vector2 CAJIAHNGOOG;

		[Cpp2IlInjected.Token(Token = "0x4000413")]
		protected static Vector2 POJJHJOOJMD;

		[Cpp2IlInjected.Token(Token = "0x4000414")]
		protected static Vector2 MNBFLCHECGC;

		[Cpp2IlInjected.Token(Token = "0x4000415")]
		protected static Vector2 EBHACDIBFHB;

		[Cpp2IlInjected.Token(Token = "0x4000416")]
		protected static Vector2 DHJNJBAGPMD;

		[Cpp2IlInjected.Token(Token = "0x4000417")]
		protected static Vector2 EKALDCKCFBC;

		[Cpp2IlInjected.Token(Token = "0x4000418")]
		protected static Vector2 PKAJKBPDNGH;

		[Cpp2IlInjected.Token(Token = "0x4000419")]
		protected static Vector2 LDNPMHFBFPK;

		[Cpp2IlInjected.Token(Token = "0x400041A")]
		protected static Vector2 ADDJFIPHLGJ;

		[Cpp2IlInjected.Token(Token = "0x400041B")]
		protected static Vector2 CGPOAGJFINH;

		[Cpp2IlInjected.Token(Token = "0x400041C")]
		protected static Vector2 CLLDGGCKCOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		[ANKANEOPOFH(JINCPHMLLKA.Self, false, false, false)]
		[SerializeField]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		[SerializeField]
		[Header("Rendering")]
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
		[FormerlySerializedAs("fullBodyFaceStyleSet")]
		[Header("Modern Avatar Facial Features")]
		public FaceStyleSet modernBodyFaceStyleSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		private BLMBMEMIHNO JDJLHMGNBCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		private FaceStyleSet OMNBJICGPPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		[SerializeField]
		protected bool debugEyeJitterInEditor;

		[Cpp2IlInjected.Token(Token = "0x4000426")]
		protected const int OAMKHIMOOMD = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		protected int IFJPCPOMLFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		protected int ENIAECAJGBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		protected int FKIGGHDHLAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		protected int MLMBOGGDAJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		protected Vector2 GILFALADJBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		protected float PCBOMOLLCAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		protected float GEDCCKPOFDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		protected float IJMAJJKDNPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		protected Vector2 LNCMALJHPFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		protected float KKLHHODBDEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		protected float FCLAGBJNJOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		protected float MPPFOMPDPLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		protected Vector2 LMFACMHKIFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		protected float CBLOELEIBKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		protected float LIKALEJKKLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		protected float KKLLLNHBADB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		protected Vector2 LKDAOBKKHAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		protected float BEFCLFECFID;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		protected float GGIFPFBGPDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		protected float HAPGNAEBHEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		protected List<SelectableFaceOption> NPFCLIEONGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		protected List<SelectableFaceOption> CDJPDICMMID;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		protected List<SelectableFaceOption> MBCKFICICCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		protected List<SelectableFaceOption> DDOPJECABLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		protected Coroutine NCEHLPJFEBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		protected int? DPLIFPLOCGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		protected int NLCMENNAMEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		protected int NCLDABGGCDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		protected int LOKKGGJGFJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		protected int FOPOKMFMJIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		protected int NCEHBKDOEAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		protected int DCPFIMELPDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		protected Sprite HDOLKKIFGGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		protected Sprite OKHGAHDDEOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		protected Sprite LLJAELLDDCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		protected Sprite PBDDJMILPII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		protected bool IANIDBBKDFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		protected string HJKOHEBEPIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		protected string CKLOMHMKDGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		protected string JIALAKOGAGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		protected string NBLEGDIDJIH;

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
		protected AvatarConfiguration NGKBNOKDLJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		protected KIAELDLCAEI KJHHIJDHIFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		private readonly List<Material> HCIADMPJHDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		protected GMCHJHHGEBP BNANBKEFBGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		protected Dictionary<string, int> BDILEJGHPDB;

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public FaceStyleSet BFKPDOGMKAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x7AD6D40", Offset = "0x7AD5D40", VA = "0x187AD6D40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public bool OECNNBLFMJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0xABCE90", Offset = "0xABBE90", VA = "0x180ABCE90", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x121B170", Offset = "0x121A170", VA = "0x18121B170")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		protected virtual bool JLKJDNMEKEC
		{
			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0xA3A820", Offset = "0xA39820", VA = "0x180A3A820", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		protected virtual bool HCBNGIHJGHB
		{
			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A680", VA = "0x180A0B680", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		protected int OGBHMDAJJDD
		{
			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x7AD1750", Offset = "0x7AD0750", VA = "0x187AD1750")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public Renderer LCACIANOOHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x9F1550", Offset = "0x9F0550", VA = "0x1809F1550")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public bool ELNEHMNDILI
		{
			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0xABA070", Offset = "0xAB9070", VA = "0x180ABA070")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x7AD6FF0", Offset = "0x7AD5FF0", VA = "0x187AD6FF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public Renderer[] ALEDHEMFIII
		{
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x9F1780", Offset = "0x9F0780", VA = "0x1809F1780")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public bool AGPBOHGGCAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x7AD6D90", Offset = "0x7AD5D90", VA = "0x187AD6D90")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x7AD6F50", Offset = "0x7AD5F50", VA = "0x187AD6F50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		protected int EBDGKBBKKJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x7AD2890", Offset = "0x7AD1890", VA = "0x187AD2890")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		protected int IHIJCEFOPLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x7AD09F0", Offset = "0x7ACF9F0", VA = "0x187AD09F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		public float HDDJNIMKHME
		{
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x7AD6D70", Offset = "0x7AD5D70", VA = "0x187AD6D70")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x7AD6F30", Offset = "0x7AD5F30", VA = "0x187AD6F30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public CPCAHHNKCEK AHDDGCHGPPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0xA9ED90", Offset = "0xA9DD90", VA = "0x180A9ED90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0xADA160", Offset = "0xAD9160", VA = "0x180ADA160")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public KIAELDLCAEI EPIKIJKLJPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000385")]
			[Cpp2IlInjected.Address(RVA = "0xAB06E0", Offset = "0xAAF6E0", VA = "0x180AB06E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000386")]
			[Cpp2IlInjected.Address(RVA = "0x7AD6EB0", Offset = "0x7AD5EB0", VA = "0x187AD6EB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public NoseFaceOption NAGNBIHDOHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000387")]
			[Cpp2IlInjected.Address(RVA = "0xA96310", Offset = "0xA95310", VA = "0x180A96310")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000388")]
			[Cpp2IlInjected.Address(RVA = "0xB304D0", Offset = "0xB2F4D0", VA = "0x180B304D0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		protected GMCHJHHGEBP DDPLHOMMJAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000389")]
			[Cpp2IlInjected.Address(RVA = "0x7AD37C0", Offset = "0x7AD27C0", VA = "0x187AD37C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action LNFADNDNLHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0x7AD6C90", Offset = "0x7AD5C90", VA = "0x187AD6C90")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x7AD6E00", Offset = "0x7AD5E00", VA = "0x187AD6E00")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x7AD3650", Offset = "0x7AD2650", VA = "0x187AD3650")]
		public void LocalPlayEmote(GOPMEEGJDMI.MONNCAKECLO MKAOFLLKCGA, float HOLBMGNIFPF = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x7AD2470", Offset = "0x7AD1470", VA = "0x187AD2470")]
		public bool IsEmotePlaying(GOPMEEGJDMI.MONNCAKECLO MKAOFLLKCGA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x7AD4BA0", Offset = "0x7AD3BA0", VA = "0x187AD4BA0")]
		public void SetIdleHappy(bool HCIFHLCCBGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x7AD3FA0", Offset = "0x7AD2FA0", VA = "0x187AD3FA0")]
		protected void OEKEJGFPHIF(bool CPABBKEHFCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x7AD12A0", Offset = "0x7AD02A0", VA = "0x187AD12A0")]
		protected void FBICNGFJFJA(bool OIOMKMPMIKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x7AD3750", Offset = "0x7AD2750", VA = "0x187AD3750")]
		protected void NHANMKFOPHP(LEMFDNDBDJC BDNPFHIBMNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x7AD1ED0", Offset = "0x7AD0ED0", VA = "0x187AD1ED0")]
		protected void IEDOLGPHGMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x7AD43B0", Offset = "0x7AD33B0", VA = "0x187AD43B0")]
		public void PlayExpression(int IHLFBGKHMBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x7AD1690", Offset = "0x7AD0690", VA = "0x187AD1690")]
		protected void FPPFLCHNNLC(bool PKLDANANAGN, bool PMHJIKMLKBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x7AD1D10", Offset = "0x7AD0D10", VA = "0x187AD1D10")]
		public List<SelectableFaceOption> GetAvailableFeatures(FaceFeatureType MKKIEOCNHPD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x7AD1F40", Offset = "0x7AD0F40", VA = "0x187AD1F40")]
		public void InitializeFaceFeatureRanges(AvatarConfiguration NGKBNOKDLJN, BLMBMEMIHNO JDMGBLFHDLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x7AD4AB0", Offset = "0x7AD3AB0", VA = "0x187AD4AB0")]
		[AsyncStateMachine(typeof(LEMGGHEDINN))]
		public Task SetFaceSettings(MAKBECHNCGC MNFOAJDGMOA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x7AD4980", Offset = "0x7AD3980", VA = "0x187AD4980")]
		[AsyncStateMachine(typeof(LCJHLFBMNAG))]
		public Task SetFaceSettings(int FIFKMEIKBAC, int LFMFAANBNDE, int JEEJOPHMHEL, int CEIBLIDDHFC, BLMBMEMIHNO JDMGBLFHDLB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x7AD4C20", Offset = "0x7AD3C20", VA = "0x187AD4C20")]
		[AsyncStateMachine(typeof(PHNKNNBLACN))]
		public Task SetSelectedFaceFeatureAndBuildFaceStyle(FaceFeatureType MKKIEOCNHPD, int DKCFEEFLGFE, BLMBMEMIHNO JDMGBLFHDLB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x7AD3140", Offset = "0x7AD2140", VA = "0x187AD3140")]
		protected void LFOEDIBIDAP(FaceFeatureType MKKIEOCNHPD, MCAONEJPGJL BPNLDPBPOKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x7AD3840", Offset = "0x7AD2840", VA = "0x187AD3840")]
		protected void NPAKDEGFLNF(FaceFeatureType MKKIEOCNHPD, int DKCFEEFLGFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x7AD1B30", Offset = "0x7AD0B30", VA = "0x187AD1B30")]
		public static IEnumerable<FaceFeatureType> GetAllFaceFeatureTypes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x7AD15A0", Offset = "0x7AD05A0", VA = "0x187AD15A0")]
		[AsyncStateMachine(typeof(DKDAMNINJFN))]
		protected Task FHFGKDAONEC(MAKBECHNCGC MNFOAJDGMOA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x7AD2590", Offset = "0x7AD1590", VA = "0x187AD2590")]
		protected void KKHFENGJMGB(MAKBECHNCGC MNFOAJDGMOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x7AD1400", Offset = "0x7AD0400", VA = "0x187AD1400")]
		protected static void FHBGFLGJKHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x7AD0C70", Offset = "0x7ACFC70", VA = "0x187AD0C70")]
		private void BFIAFOKHOEB(bool IEJJHIGCHKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x7AD32C0", Offset = "0x7AD22C0", VA = "0x187AD32C0")]
		protected void LNCCBKKMNGK(FaceFeatureType MKKIEOCNHPD, Vector2 GMGOHHNEGED, BLMBMEMIHNO JDMGBLFHDLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x7AD43D0", Offset = "0x7AD33D0", VA = "0x187AD43D0")]
		public void SetFaceFeatureNormalizedPositionOffset(FaceFeatureType MKKIEOCNHPD, Vector2 PEEIFNEOGOI, BLMBMEMIHNO JDMGBLFHDLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x7AD4230", Offset = "0x7AD3230", VA = "0x187AD4230")]
		protected void PGABCOHDKML(FaceFeatureType MKKIEOCNHPD, float EIIHOPBEFCC, BLMBMEMIHNO JDMGBLFHDLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x7AD1D50", Offset = "0x7AD0D50", VA = "0x187AD1D50")]
		protected void HCKOMNLAIIH(FaceFeatureType MKKIEOCNHPD, float OOBEGCNALKF, BLMBMEMIHNO JDMGBLFHDLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x7AD0FE0", Offset = "0x7ACFFE0", VA = "0x187AD0FE0")]
		protected void BHJMGAHCPOB(FaceFeatureType MKKIEOCNHPD, float LJOCPPONLJF, BLMBMEMIHNO JDMGBLFHDLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x7AD4760", Offset = "0x7AD3760", VA = "0x187AD4760")]
		public void SetFaceFeatureNormalizedScaleOffset(FaceFeatureType MKKIEOCNHPD, float NNPJOGAMMKB, BLMBMEMIHNO JDMGBLFHDLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x7AD0A50", Offset = "0x7ACFA50", VA = "0x187AD0A50")]
		[AsyncStateMachine(typeof(OCOEMDDDHGD))]
		protected Task ANAOKCGJDCO(BLMBMEMIHNO JDMGBLFHDLB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x7AD2260", Offset = "0x7AD1260", VA = "0x187AD2260")]
		public void InitializeFaceFeatureStyleSet(BLMBMEMIHNO JDMGBLFHDLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x7AD0F00", Offset = "0x7ACFF00", VA = "0x187AD0F00")]
		protected bool BGPDGJBIJJB(string LBJFIPOFPPN, [Out] int OHHMJGCBCKD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x7AD0B30", Offset = "0x7ACFB30", VA = "0x187AD0B30")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x1616370", Offset = "0x1615370", VA = "0x181616370", Slot = "8")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x7AD4020", Offset = "0x7AD3020", VA = "0x187AD4020")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x7AD5D40", Offset = "0x7AD4D40", VA = "0x187AD5D40")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x7AD10B0", Offset = "0x7AD00B0", VA = "0x187AD10B0")]
		[AsyncStateMachine(typeof(OFCGEHKPDJK))]
		public Task BuildFaceStyleAsyncIfChanged(BLMBMEMIHNO JDMGBLFHDLB, bool HFPBIAGEELK = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x7AD5660", Offset = "0x7AD4660", VA = "0x187AD5660")]
		public void UpdateFaceDisplays(bool JNJPBNKKPBH = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x7AD28F0", Offset = "0x7AD18F0", VA = "0x187AD28F0")]
		protected bool LDLACHGFELL(bool JNJPBNKKPBH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x7AD5380", Offset = "0x7AD4380", VA = "0x187AD5380")]
		public void UpdateFaceDisplayFeatureTextures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x7AD4D30", Offset = "0x7AD3D30", VA = "0x187AD4D30")]
		public void UpdateFaceDisplayFeaturePositions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x7AD5870", Offset = "0x7AD4870", VA = "0x187AD5870")]
		public void UpdateFaceJitterMultiplier()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x7AD5A60", Offset = "0x7AD4A60", VA = "0x187AD5A60")]
		public bool UpdateLegacyFaceVectors()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x7AD11B0", Offset = "0x7AD01B0", VA = "0x187AD11B0")]
		protected void EMHGBDDKEGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x7AD1880", Offset = "0x7AD0880", VA = "0x187AD1880")]
		private void GNAAJEMACEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x7AD6A30", Offset = "0x7AD5A30", VA = "0x187AD6A30")]
		public PlayerFacialAnimatorBase()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0xA1D840", Offset = "0xA1C840", VA = "0x180A1D840", Slot = "4")]
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
	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public string IJKBIMCGCEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public int OJLJBFKDCDP;
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[SelectionBase]
	[ExecuteInEditMode]
	public class PlayerModernBodyEditorAvatarValidator : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000076")]
		[CompilerGenerated]
		private struct OLGLCBHGIFC : IAsyncStateMachine
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

			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0x7ACF750", Offset = "0x7ACE750", VA = "0x187ACF750", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0xA45C40", Offset = "0xA44C40", VA = "0x180A45C40", Slot = "5")]
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

			[Cpp2IlInjected.Token(Token = "0x60003DE")]
			[Cpp2IlInjected.Address(RVA = "0x7AD0490", Offset = "0x7ACF490", VA = "0x187AD0490", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0x7AD0990", Offset = "0x7ACF990", VA = "0x187AD0990", Slot = "5")]
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
		public BLMBMEMIHNO avatarBodyType;

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
		public OJELMNHDJHH useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public HMAKLDEGKBC hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public NFNPBLMBHAL HatAnchorRestrictions;

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
		[ANKANEOPOFH(JINCPHMLLKA.Self, false, false, false)]
		public PlayerAvatarDisplayBase _avatarDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		private GBFNELEFJAC LEBCMFOLOIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		[SerializeField]
		[ANKANEOPOFH(JINCPHMLLKA.Self, false, false, false)]
		public PlayerFacialAnimatorBase facialAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public AnimationClip animationClipToOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		private AnimatorOverrideController AOBDDBLIHIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		private List<KeyValuePair<AnimationClip, AnimationClip>> FHAFKEIODFC;

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
		public readonly LLCKJOKJMMI[] FacialExpressions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public readonly string[] BodyPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public readonly (string, ACKOLLANMDJ)[] HandPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public bool hideLeftWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x229")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public bool hideRightWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22A")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		protected bool INLAHEKHDGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22C")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		protected Guid GOPLMMMJDHM;

		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		protected static Guid LJEAKBOHHGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		private EEFKKODIKGJ PBMIFJMNDNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		private CPCAHHNKCEK GMCECMEINAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		private EKFIOJKBHPO MGCOAJDDCHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		private EKFIOJKBHPO NCPPMDKMJDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		private AdditionalHatData PGDHKGCOJOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		private readonly Dictionary<GameObject, CKKEFOLDDDM> IAGOLCLBMDK;

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public static Func<GADAOPIMBPG> OHPAADMHPCH
		{
			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x7ADC010", Offset = "0x7ADB010", VA = "0x187ADC010")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x7ADC650", Offset = "0x7ADB650", VA = "0x187ADC650")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public bool LCDGIPEHJJF
		{
			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x7ADC170", Offset = "0x7ADB170", VA = "0x187ADC170")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		public bool INELLDPGPKA
		{
			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x7ADC060", Offset = "0x7ADB060", VA = "0x187ADC060")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public PlayerAvatarDisplayBase JBDLPFCPPOM
		{
			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0xAA0EB0", Offset = "0xA9FEB0", VA = "0x180AA0EB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		protected static Guid MEEJNPIBHLB
		{
			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x7AD9340", Offset = "0x7AD8340", VA = "0x187AD9340")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public (GameObject, LEMFDNDBDJC)[] ACALACGHLEO
		{
			[Cpp2IlInjected.Token(Token = "0x60003C6")]
			[Cpp2IlInjected.Address(RVA = "0x7ADC280", Offset = "0x7ADB280", VA = "0x187ADC280")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x7AD9D20", Offset = "0x7AD8D20", VA = "0x187AD9D20")]
		[ContextMenu("Refresh Avatar")]
		private void RebuildTestAvatarContextMenu()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x7AD8590", Offset = "0x7AD7590", VA = "0x187AD8590")]
		private IEnumerable<GameObject> EOJMKANJKMK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x7ADA210", Offset = "0x7AD9210", VA = "0x187ADA210")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x7AD8A20", Offset = "0x7AD7A20", VA = "0x187AD8A20")]
		private void HJJKFILBCJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x1264BC0", Offset = "0x1263BC0", VA = "0x181264BC0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x7AD8B90", Offset = "0x7AD7B90", VA = "0x187AD8B90")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x7ADA220", Offset = "0x7AD9220", VA = "0x187ADA220")]
		public void Teardown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x7ADA010", Offset = "0x7AD9010", VA = "0x187ADA010")]
		public void ShowPose(AnimationClip ICKENEFAALA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x7ADA1E0", Offset = "0x7AD91E0", VA = "0x187ADA1E0")]
		public void ShowPose(string NCKELHEKOGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x7AD9E70", Offset = "0x7AD8E70", VA = "0x187AD9E70")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x7AD9D30", Offset = "0x7AD8D30", VA = "0x187AD9D30")]
		public void ResetHandPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x7ADACF0", Offset = "0x7AD9CF0", VA = "0x187ADACF0")]
		public void UpdateHandAnimation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x7ADAB40", Offset = "0x7AD9B40", VA = "0x187ADAB40")]
		public void UpdateFaceAndBodyShapes(bool HFPBIAGEELK = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x7ADB0F0", Offset = "0x7ADA0F0", VA = "0x187ADB0F0")]
		public void UpdateNoseShape(ABOJDNCODIG AEHFOHDJDBI, bool HFPBIAGEELK = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x7ADB0C0", Offset = "0x7ADA0C0", VA = "0x187ADB0C0")]
		public void UpdateLODOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x7AD9430", Offset = "0x7AD8430", VA = "0x187AD9430", Slot = "4")]
		protected virtual void LKMLNJCFJOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x7AD70B0", Offset = "0x7AD60B0", VA = "0x187AD70B0", Slot = "5")]
		protected virtual void AJGFCJMCCHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x7AD74E0", Offset = "0x7AD64E0", VA = "0x187AD74E0")]
		public void ApplyHatData(AdditionalHatData OIFEEKHFHPE, bool ALDIAIHDCKC = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x7AD7320", Offset = "0x7AD6320", VA = "0x187AD7320")]
		public void ApplyHatAdjustmentsToHatAnchorParams()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x7AD7840", Offset = "0x7AD6840", VA = "0x187AD7840")]
		public void ApplyHatUVOverride(Vector2 ENPNPELINAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x7AD7760", Offset = "0x7AD6760", VA = "0x187AD7760")]
		public void ApplyHatPositionAdjustment(Vector3 HMNICACDGIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x7AD77D0", Offset = "0x7AD67D0", VA = "0x187AD77D0")]
		public void ApplyHatRotationAdjustment(Vector3 ECOBOIKCNJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x7AD78B0", Offset = "0x7AD68B0", VA = "0x187AD78B0")]
		public EMNJOPNCDMC BuildAvatarItemSelection(GameObject KMJIGOCPILL, BLMBMEMIHNO MLPKEOCLJHM, LEMFDNDBDJC PAMAJIDJFOH)
		{
			return default(EMNJOPNCDMC);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x7AD7950", Offset = "0x7AD6950", VA = "0x187AD7950")]
		public void BuildAvatar(bool HFPBIAGEELK = false, bool ALDIAIHDCKC = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x7ADA580", Offset = "0x7AD9580", VA = "0x187ADA580")]
		public void UpdateColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x7AD7460", Offset = "0x7AD6460", VA = "0x187AD7460")]
		public void ApplyHatAnchor()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x7ADAF10", Offset = "0x7AD9F10", VA = "0x187ADAF10")]
		public void UpdateHatAnchor(bool ALDIAIHDCKC = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x7ADAC40", Offset = "0x7AD9C40", VA = "0x187ADAC40")]
		[AsyncStateMachine(typeof(OLGLCBHGIFC))]
		public void UpdateFaceFeatures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x7AD9730", Offset = "0x7AD8730", VA = "0x187AD9730")]
		[AsyncStateMachine(typeof(POEGMOGFLDG))]
		private Task NJIOBJBAEHG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x7AD7F60", Offset = "0x7AD6F60", VA = "0x187AD7F60")]
		private void CIFEGEKNOGN(FaceFeatureType FHPHLNGNANC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x7AD8B00", Offset = "0x7AD7B00", VA = "0x187AD8B00")]
		private void HKFHKBMGJFC(FaceFeatureType FHPHLNGNANC, [Out] float IAOMFOLOIIC, [Out] float FNBIPEPKGLK, [Out] float HDLKNIPAJGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x7ADAA00", Offset = "0x7AD9A00", VA = "0x187ADAA00")]
		public void UpdateEmote()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x7ADADA0", Offset = "0x7AD9DA0", VA = "0x187ADADA0")]
		public void UpdateHandPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x7AD9800", Offset = "0x7AD8800", VA = "0x187AD9800")]
		private void OPNCBHMKICB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		private void DNNHGHABHIO(CKKEFOLDDDM NPDKKINBDDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		private void MLDOJDENLKH(CKKEFOLDDDM NPDKKINBDDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x7AD8230", Offset = "0x7AD7230", VA = "0x187AD8230")]
		private void DCCHPMCLHKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x7ADB180", Offset = "0x7ADA180", VA = "0x187ADB180")]
		public PlayerModernBodyEditorAvatarValidator()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x7AD9290", Offset = "0x7AD8290", VA = "0x187AD9290")]
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
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		[SerializeField]
		[ANKANEOPOFH(JINCPHMLLKA.Self, false, false, false)]
		private SkinnedMeshRenderer skinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		[SerializeField]
		private int BoneWeightsDisplayStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		[SerializeField]
		private int BoneWeightsDisplayAmount;

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x9F0210", Offset = "0x9EF210", VA = "0x1809F0210")]
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
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public IEnumerable<OutfitType> otherOutfitTypes;

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public DJNOMFCLKKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x7AC8D60", Offset = "0x7AC7D60", VA = "0x187AC8D60")]
		internal bool EIGEJBPCIOP(OutfitType outfitType)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	private CKKEFOLDDDM AGPBCGMGMGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	private LEMFDNDBDJC OOKAJCIPPLG;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public CKKEFOLDDDM GBHHDDAPDIC
	{
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0xCFF9C0", Offset = "0xCFE9C0", VA = "0x180CFF9C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public LEMFDNDBDJC IFCMMFOJBML
	{
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0xCFF940", Offset = "0xCFE940", VA = "0x180CFF940")]
		get
		{
			return default(LEMFDNDBDJC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public string FPFIMAEMPOF
	{
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x7ACBD50", Offset = "0x7ACAD50", VA = "0x187ACBD50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public bool NALDFNNIJPG
	{
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x7ACBCB0", Offset = "0x7ACACB0", VA = "0x187ACBCB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public bool MOHAACLMKGA
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x7ACBD00", Offset = "0x7ACAD00", VA = "0x187ACBD00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x17930E0", Offset = "0x17920E0", VA = "0x1817930E0")]
	public EMNJOPNCDMC(CKKEFOLDDDM NPDKKINBDDF, LEMFDNDBDJC BDNPFHIBMNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x7ACC0B0", Offset = "0x7ACB0B0", VA = "0x187ACC0B0")]
	public bool PCEHNCJFCHN(OutfitType BFDFGEPOLJJ, LEMFDNDBDJC EENFKJBCPAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x7ACBE40", Offset = "0x7ACAE40", VA = "0x187ACBE40")]
	public bool MLFBEHEMPBC(OutfitType BFDFGEPOLJJ, LEMFDNDBDJC EENFKJBCPAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x7ACBAC0", Offset = "0x7ACAAC0", VA = "0x187ACBAC0")]
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
