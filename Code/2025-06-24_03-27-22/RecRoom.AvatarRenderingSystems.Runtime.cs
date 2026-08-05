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
	public class LogRegistrationIndex : KHEEPBINELP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7BFB180", Offset = "0x7BF9D80", VA = "0x187BFB180", Slot = "4")]
		public override void KHPGHNAFBFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA478F0", Offset = "0xA464F0", VA = "0x180A478F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA24670", Offset = "0xA23270", VA = "0x180A24670", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override string AssetGUID
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x7C08680", Offset = "0x7C07280", VA = "0x187C08680", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7C08610", Offset = "0x7C07210", VA = "0x187C08610", Slot = "17")]
		public override bool RuntimeKeyIsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7C08640", Offset = "0x7C07240", VA = "0x187C08640")]
		public RecNetCDNAssetReference(RecNetCDNKey MEPFFFGIFGB)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class RecNetCDNKey
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public enum LKJEGGCGIPI : byte
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
			[Cpp2IlInjected.Address(RVA = "0xA1EB40", Offset = "0xA1D740", VA = "0x180A1EB40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xA1EB20", Offset = "0xA1D720", VA = "0x180A1EB20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string UniqueItemIdentifier
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xA1F7B0", Offset = "0xA1E3B0", VA = "0x180A1F7B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string CacheHash
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xA20EB0", Offset = "0xA1FAB0", VA = "0x180A20EB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xA1F7C0", Offset = "0xA1E3C0", VA = "0x180A1F7C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RecNetCDNKey Dependency
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xA246B0", Offset = "0xA232B0", VA = "0x180A246B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xA27D40", Offset = "0xA26940", VA = "0x180A27D40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool AttemptPrecacheLookup
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xA4B580", Offset = "0xA4A180", VA = "0x180A4B580")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA4B3A0", Offset = "0xA49FA0", VA = "0x180A4B3A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public LKJEGGCGIPI PathHint
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xE6EDF0", Offset = "0xE6D9F0", VA = "0x180E6EDF0")]
			[CompilerGenerated]
			get
			{
				return default(LKJEGGCGIPI);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x1484AE0", Offset = "0x14836E0", VA = "0x181484AE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string ItemPath
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x7C08790", Offset = "0x7C07390", VA = "0x187C08790")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7C08710", Offset = "0x7C07310", VA = "0x187C08710")]
		public static RecNetCDNKey FKKBIJKFBDO(string LCODHMJLAHI, LKJEGGCGIPI KJPLMIAPBFM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7C086C0", Offset = "0x7C072C0", VA = "0x187C086C0")]
		public void FCPOPKGGPPG(string NPNAJCPCEJH, string COEHPKCLNDD, bool LHKDEGFCBNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public RecNetCDNKey()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[BOOMHEJPJEF]
public class DKLDKEIEJEK : JJHOBFIADIB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	protected readonly List<Mesh> BCNMPLHAKJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	protected readonly List<byte[]> CICDIDBMJIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	protected readonly List<Matrix4x4> BHDKJADFPPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	protected readonly List<bool> FENKFEECNKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	protected readonly List<long> ALEGNFOOHAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	protected readonly List<bool> ICINLABHEEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	protected readonly List<int> BBJIKEBEIIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	protected Allocator IIBDJKHEOOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected OAKJHNENFNC OMKFLMGDCKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected byte KPFMPEDALFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected IList<int> GKHDHHAOBLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected IList<int> DABHFOFLLMO;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7BF5600", Offset = "0x7BF4200", VA = "0x187BF5600", Slot = "4")]
	public void IPFAKHLFCOE(Mesh BFDKALDCPEN, Matrix4x4 DPPPNPACNJH, byte[] OBDIEKPNNPB, bool IKIEJAHIOPM = false, IONAMLJCLBI.EPMFDMLBDCD MFNNIEGNODK = (IONAMLJCLBI.EPMFDMLBDCD)0L, int KDIBBKDBADJ = -1, bool BGDOAPOABHM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7BF59C0", Offset = "0x7BF45C0", VA = "0x187BF59C0", Slot = "5")]
	public void IPGLPJDGHFG(Allocator CMJGNOOCEGA, OAKJHNENFNC OBHHKIOIHLB, byte EOMAKFBPFJB, [Optional] IList<int> LKHKBJHNPOO, [Optional] IList<int> JPIHBOHEBGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7BF5A00", Offset = "0x7BF4600", VA = "0x187BF5A00")]
	private static void KCAHMIPODDE(Mesh BFDKALDCPEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7BF5C60", Offset = "0x7BF4860", VA = "0x187BF5C60")]
	public DKLDKEIEJEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[BOOMHEJPJEF]
public struct AELEIGOMFIB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	[ReadOnly]
	public DMEHFHFIHIH JCIOOKDKFCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[ReadOnly]
	public int BJNHJMCBCCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public IOGGJBBCLAB LDCNBHNJLBK;

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7BF20F0", Offset = "0x7BF0CF0", VA = "0x187BF20F0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[BOOMHEJPJEF]
[NativeContainer]
public struct IOGGJBBCLAB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct CMEEJNFFLEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Vector3 ONKEHMPMEJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public Vector3 AKLPJIPJBIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public Vector4 IIFNKGDIONN;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct MCIFOHDMOAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public float CIHDGGFFMJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public float KEPFFCACLCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public float LAKMGACKOPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public float HHBMOKBEJDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public byte CCJHPKHDPMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public byte NLFFGIIGANP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public byte NMOCHIAKFLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public byte ILMNPIOLLFB;
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct MNNNNKKNJKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public half CIHDGGFFMJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public half KEPFFCACLCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public half LAKMGACKOPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public half HHBMOKBEJDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public byte CCJHPKHDPMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public byte NLFFGIIGANP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public byte NMOCHIAKFLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public byte ILMNPIOLLFB;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct LFOHDALMMGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public half4 GCKOLKABAJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public half2 GFMDGLBGKLM;
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct LBGNBHOABOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public half4 GCKOLKABAJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public half2 GFMDGLBGKLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public half2 GJDEIOJPEBO;
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct BNAOGHPICFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public half4 GCKOLKABAJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public half2 GFMDGLBGKLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public half2 GJDEIOJPEBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public half2 LBKMFFCDAGJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct AGNJPLFDKJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public half4 GCKOLKABAJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public half2 GFMDGLBGKLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public half2 GJDEIOJPEBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public half2 LBKMFFCDAGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public half2 MHCGFPBKHFK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct EOOJJMKBHNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public float CIHDGGFFMJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public float KEPFFCACLCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public float LAKMGACKOPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public float HHBMOKBEJDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int CCJHPKHDPMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int NLFFGIIGANP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int NMOCHIAKFLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int ILMNPIOLLFB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct HKMNLEFBDDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Color GCKOLKABAJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Vector2 GFMDGLBGKLM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct LGFNOEOFGDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Color GCKOLKABAJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Vector2 GFMDGLBGKLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Vector2 GJDEIOJPEBO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct JBGNFBFLGNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Color GCKOLKABAJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Vector2 GFMDGLBGKLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Vector2 GJDEIOJPEBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Vector2 LBKMFFCDAGJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct IDBOHGECEDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Color GCKOLKABAJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Vector2 GFMDGLBGKLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Vector2 GJDEIOJPEBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Vector2 LBKMFFCDAGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Vector2 MHCGFPBKHFK;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private bool NJAJDGJJBNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<CMEEJNFFLEB> IMNEBDEFFCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<LFOHDALMMGJ> NGEPHINEGIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<LBGNBHOABOH> HJLHDHKNIEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<BNAOGHPICFE> EPKEMHEHBJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<AGNJPLFDKJJ> EDLIJDEODCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<MNNNNKKNJKB> EILFIBEOAJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<MCIFOHDMOAD> IIGDEMEGCDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NativeArray<HKMNLEFBDDM> LGOFGNKFIOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NativeArray<LGFNOEOFGDH> ILFPNKILFBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public NativeArray<JBGNFBFLGNL> BOIBPNPEPKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public NativeArray<IDBOHGECEDD> CBNHOHAPNDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public NativeArray<EOOJJMKBHNE> ABFIMHKIAAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public NativeArray<int> FIJMMKHBOGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public NativeArray<int> FOLJMMDNABP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private NativeArray<int> KIBCCNBGLBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NativeArray<int> ABOJEPGLMNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<int> AJGPLCBBAED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public NativeArray<int> HKGNPMLPNJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public NativeArray<int> KGAICMMFIIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public NativeArray<BoneWeight> MOFDEDJFCED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeArray<int> GALEDNLDGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private bool BODBGHDHCNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x159")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private bool IIPMKDBFOJL;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int CPMPAEJBCJA
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7BF8810", Offset = "0x7BF7410", VA = "0x187BF8810")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7BFA020", Offset = "0x7BF8C20", VA = "0x187BFA020")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int MLJBKBJPEDH
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7BF81F0", Offset = "0x7BF6DF0", VA = "0x187BF81F0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7BFA3E0", Offset = "0x7BF8FE0", VA = "0x187BFA3E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int MKAMGGFOPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7BF8530", Offset = "0x7BF7130", VA = "0x187BF8530")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7BF85A0", Offset = "0x7BF71A0", VA = "0x187BF85A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int DPFAHCNDGCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7BF9ED0", Offset = "0x7BF8AD0", VA = "0x187BF9ED0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7BFA480", Offset = "0x7BF9080", VA = "0x187BFA480")]
	public IOGGJBBCLAB(int DMMLONIKHJK, int DGGKPEIKPDJ, int DGCPHHBEAOE, int DGCJJFCDOOG, Allocator CMJGNOOCEGA, int DMBBNDPCKIL, BEJNMHPKKIN NOIMMGHFPPG, bool BODBGHDHCNH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7BFA3F0", Offset = "0x7BF8FF0", VA = "0x187BFA3F0")]
	public void PKDMGFOHNPB(int EMMACFPOKFB, Vector3 GCKEIIMJEBO, Vector3 IJDADKHAHCN, Vector4 LPCHKKFEGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7BF8C20", Offset = "0x7BF7820", VA = "0x187BF8C20")]
	public void GOGKNAPAJAF(int EMMACFPOKFB, BoneWeight IJMOKCJEFNK, NativeSlice<byte> OBDIEKPNNPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7BF8200", Offset = "0x7BF6E00", VA = "0x187BF8200")]
	public Color BCKCBHEFLPL(int EMMACFPOKFB)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7BF8820", Offset = "0x7BF7420", VA = "0x187BF8820")]
	public void EGHHFLCMDCK(int EMMACFPOKFB, Color OFHHGNENJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7BFA030", Offset = "0x7BF8C30", VA = "0x187BFA030")]
	public void LFIBNMPMAKD(byte NILBKMNBFDH, int EMMACFPOKFB, Vector2 HMGNPMMNGMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7BFA010", Offset = "0x7BF8C10", VA = "0x187BFA010")]
	public void KKAFDEFENDG(int EMMACFPOKFB, int OBHKOKLJMOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7BF8540", Offset = "0x7BF7140", VA = "0x187BF8540")]
	public bool BOJJHOIOEJO(int NILBKMNBFDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7BF9F40", Offset = "0x7BF8B40", VA = "0x187BF9F40")]
	public void KHDENMDDLHD(int NBKDFHMCMMP, int KPHEINADMCH, int FMOIHNPEKPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7BF85B0", Offset = "0x7BF71B0", VA = "0x187BF85B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7BF9050", Offset = "0x7BF7C50", VA = "0x187BF9050")]
	public Mesh IJBOLOALJCL([Optional] string KEPNEELPECP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
[NativeContainer]
[BOOMHEJPJEF]
public struct DMEHFHFIHIH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public Mesh.MeshDataArray MLFFDLKINBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public NativeArray<int> NFMGOHLBJJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public NativeArray<int> AAHJMGOJBIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public NativeArray<BoneWeight> MOFDEDJFCED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private NativeArray<Matrix4x4> JDBMNGAEDAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private NativeArray<long> NFGCOEDMJEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private NativeArray<byte> FADPHINJALA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private NativeArray<int> DDBPDJJDJLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private NativeArray<int> GGPKBILHCFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public NativeArray<sbyte> HOHDDAMHLJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public NativeArray<byte> NLHELAFBJGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public NativeArray<bool> BGDOAPOABHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NativeArray<int> KDIBBKDBADJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private bool BODBGHDHCNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeArray<int> FCDAPDDDNAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private bool IIPMKDBFOJL;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int KKOEKCIDNHC
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7BF6210", Offset = "0x7BF4E10", VA = "0x187BF6210")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int LLFMKHKKEKD
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7BF5FA0", Offset = "0x7BF4BA0", VA = "0x187BF5FA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int NHOIGLLHCKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7BF5FB0", Offset = "0x7BF4BB0", VA = "0x187BF5FB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int LJBOBEFHKEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7BF64C0", Offset = "0x7BF50C0", VA = "0x187BF64C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7BF6220", Offset = "0x7BF4E20", VA = "0x187BF6220")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int CPMPAEJBCJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7BF6200", Offset = "0x7BF4E00", VA = "0x187BF6200")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7BF6490", Offset = "0x7BF5090", VA = "0x187BF6490")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int NEAFDAJHHBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7BF64D0", Offset = "0x7BF50D0", VA = "0x187BF64D0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7BF64A0", Offset = "0x7BF50A0", VA = "0x187BF64A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public OAKJHNENFNC MBPFFJMGAGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7BF5EC0", Offset = "0x7BF4AC0", VA = "0x187BF5EC0")]
		get
		{
			return default(OAKJHNENFNC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7BF64B0", Offset = "0x7BF50B0", VA = "0x187BF64B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public byte KPJFMDJIGEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7BF5EB0", Offset = "0x7BF4AB0", VA = "0x187BF5EB0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7BF6480", Offset = "0x7BF5080", VA = "0x187BF6480")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public CNEOICDGICI HHFPMPGGMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7BF6230", Offset = "0x7BF4E30", VA = "0x187BF6230")]
		get
		{
			return default(CNEOICDGICI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7BF64E0", Offset = "0x7BF50E0", VA = "0x187BF64E0")]
	public DMEHFHFIHIH(IList<Mesh> EPGDJLNCGHI, IList<Matrix4x4> NAMGMCKAJAO, IList<bool> BGDOAPOABHM, byte EOMAKFBPFJB, IList<byte[]> AAOKMFAJGNF, IList<long> JPOMBPOEFDP, IList<bool> KLGDLOOBBLI, IList<int> KDIBBKDBADJ, IList<int> LKHKBJHNPOO, IList<int> CCKJKFJKJDB, Allocator CMJGNOOCEGA, OAKJHNENFNC OBHHKIOIHLB, bool BODBGHDHCNH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7BF5ED0", Offset = "0x7BF4AD0", VA = "0x187BF5ED0")]
	public IOGGJBBCLAB CEHPBEEMHFI(Allocator CMJGNOOCEGA, BEJNMHPKKIN NOIMMGHFPPG)
	{
		return default(IOGGJBBCLAB);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7BF6080", Offset = "0x7BF4C80", VA = "0x187BF6080", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[BOOMHEJPJEF]
public class IEFBLEMDIIG : DKLDKEIEJEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public bool BBGPMDABCPL;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly ProfilerMarker LJFKLOHKEFC;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7BF7DB0", Offset = "0x7BF69B0", VA = "0x187BF7DB0")]
	public DMEHFHFIHIH IDOHOHIGBOA()
	{
		return default(DMEHFHFIHIH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7BF80B0", Offset = "0x7BF6CB0", VA = "0x187BF80B0")]
	public IEFBLEMDIIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct CNEOICDGICI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public Mesh.MeshData CABNLMGKFGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public NativeSlice<BoneWeight> MOFDEDJFCED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public NativeSlice<byte> KGGDKGIANLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public int NFNBKHOIMPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public Matrix4x4 NCEALKNHBCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public long EDEFCNFKNPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public NativeSlice<byte> OBDIEKPNNPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public bool PNPJDOPCFEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public int JDFALLOLLMF;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class ONACKJBPCGK : JOAGHKKNMDI
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class EPDKFBDJFNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public bool hideTorsoInFirstPersonBeanMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public ONACKJBPCGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public LKEMGHMAMLP buildMeshPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public Action<KeyValuePair<string, PHKGFEHMLBA<Texture2D>>> <>9__19;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public EPDKFBDJFNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7BF7910", Offset = "0x7BF6510", VA = "0x187BF7910")]
		internal bool BLPOCPDBPFH(LLGDDBJNDAK item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7BF7950", Offset = "0x7BF6550", VA = "0x187BF7950")]
		internal void HPCEJGPIIII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x7BF7AF0", Offset = "0x7BF66F0", VA = "0x187BF7AF0")]
		internal void KBODNIAMDOE(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7BF7950", Offset = "0x7BF6550", VA = "0x187BF7950")]
		internal void CNFHPLAODEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7BF7AF0", Offset = "0x7BF66F0", VA = "0x187BF7AF0")]
		internal void JMBCIPBOMHI(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7BF7B40", Offset = "0x7BF6740", VA = "0x187BF7B40")]
		internal void PNFGHOIGMCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7BF7B10", Offset = "0x7BF6710", VA = "0x187BF7B10")]
		internal void PAEGOHDJGII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7BF7A30", Offset = "0x7BF6630", VA = "0x187BF7A30")]
		internal void IPKOJAJPBOE(Dictionary<string, PHKGFEHMLBA<Texture2D>> resourceHandleDictionary)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7BF7970", Offset = "0x7BF6570", VA = "0x187BF7970")]
		internal void HFLENFHLIFO(KeyValuePair<string, PHKGFEHMLBA<Texture2D>> kvp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xA20EB0", Offset = "0xA1FAB0", VA = "0x180A20EB0")]
		internal AFMJGMMOLON HIPPPDFIGIB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class DCBLGADMJLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public int lowestPossibleLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public EPDKFBDJFNG CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public DCBLGADMJLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x7BF5500", Offset = "0x7BF4100", VA = "0x187BF5500")]
		internal IJOHFINFEHF JDLBPAFFBMO(int lod)
		{
			return default(IJOHFINFEHF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class JNFGDCLGHLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public KLHBLGBFFDH<Dictionary<string, PHKGFEHMLBA<Texture2D>>> ugcTextureDictionaryPromise;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public JNFGDCLGHLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xA1EB40", Offset = "0xA1D740", VA = "0x180A1EB40")]
		internal KLHBLGBFFDH<Dictionary<string, PHKGFEHMLBA<Texture2D>>> LELOLEPPEHB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class IMNLKABJJAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public List<LKEMGHMAMLP> innerPromises;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public IMNLKABJJAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7BF80C0", Offset = "0x7BF6CC0", VA = "0x187BF80C0")]
		internal void PDHOAPMEDHE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class KIBLNNBPJME : IEnumerator<FCPCPCAPDCM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private FCPCPCAPDCM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public bool shouldWait;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public ONACKJBPCGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public List<HEEODOPGCJL> parts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public List<LKEMGHMAMLP> innerPromises;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public bool isFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public Func<int, IJOHFINFEHF> getLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public JIJBLAMHAHH materialPropertyBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public Material materialInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private int <lodIndex>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private FCPCPCAPDCM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xA1FD90", Offset = "0xA1E990", VA = "0x180A1FD90")]
		[DebuggerHidden]
		public KIBLNNBPJME(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7BFAEB0", Offset = "0x7BF9AB0", VA = "0x187BFAEB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7BFB130", Offset = "0x7BF9D30", VA = "0x187BFB130", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class OBAABJNOFCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public HMMOILLMCHC cancelable;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public OBAABJNOFCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xB33EE0", Offset = "0xB32AE0", VA = "0x180B33EE0")]
		internal void KBNEJGHOGLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xDA6110", Offset = "0xDA4D10", VA = "0x180DA6110")]
		internal void HNPMNKAKOFA(string err)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class LMBCKKJHFIE
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
		public ONACKJBPCGK <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public LMBCKKJHFIE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class GNAOMDNDLDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public IOGGJBBCLAB defaultMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public DMEHFHFIHIH defaultAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public LMBCKKJHFIE CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public GNAOMDNDLDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7BF7B70", Offset = "0x7BF6770", VA = "0x187BF7B70")]
		internal void PAGPAHGBING()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x13B1700", Offset = "0x13B0300", VA = "0x1813B1700")]
		internal void OKFPOMAGPCO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class EHAPLKFOBHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public HJNLIDHLCPM legacyMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public AGPBFKGBEPK legacyAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public LMBCKKJHFIE CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public EHAPLKFOBHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7BF76D0", Offset = "0x7BF62D0", VA = "0x187BF76D0")]
		internal void EKGBNLFDLFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x13B0B40", Offset = "0x13AF740", VA = "0x1813B0B40")]
		internal void MJGAPIDMFLB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class DHGJCOAHAFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public ONACKJBPCGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public float power;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public Color color;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public DHGJCOAHAFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7BF55C0", Offset = "0x7BF41C0", VA = "0x187BF55C0")]
		internal void CKEPAPHBMFA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class PONALONGBMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public string overrideItemIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public HBNDGNKPEKC overrideBodyPart;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public PONALONGBMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7C08590", Offset = "0x7C07190", VA = "0x187C08590")]
		internal bool IHCBBNLPHJA(KeyValuePair<string, LLGDDBJNDAK> entry)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly HBAAEHCBNNO LIKMMEAHCEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly HBAAEHCBNNO JPBDOAFBMMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Dictionary<IEKNNJIHFMK, float> CMCPNMEHOGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private Dictionary<AFLDMIJCCDM, float> ODAIFMEDOLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Dictionary<PPFKBBIJKBH, float> JDHMBKLHEMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private IReadOnlyDictionary<string, LMCCLMLIJIC> CBEBMEPPNCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Dictionary<string, LMCCLMLIJIC> LLPIDCGMAHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Dictionary<string, LMCCLMLIJIC> BFIBNJCEMJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private Dictionary<string, LMCCLMLIJIC> DBGEPIGMPDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private FPAJOPAEPNO HFCJBDHBHLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private FPAJOPAEPNO BDJEEPBFFMA;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static float LBLAEAKGKLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private bool? OHNIILGNHNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x62")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private bool? IPHPOOOJPFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private bool? CLNILEBGLIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x66")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private bool? OMCCEFEPMDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private AvatarConfiguration MADDHBDCJIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private Transform PCMECILBNDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private AvatarSkinAssetItem BCELDIBCIBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private AssetReference KLJCODCCIJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private GameObject JOBKDEHDADO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private GameObject IIPCGEBPDHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private SkinnedMeshRenderer OLFMCCBDHNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private AvatarSkinnedMeshBoneOrderRemapsData EHDCNNEDCOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private Transform[] JOLKKBMKJOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private Matrix4x4[] PLLHGJJLILA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private Material EINOFGPMNMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private Material LAJLLIMBNJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private Material EGGAAPGDHFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private Material OLJPOLFAPGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private Shader BMOADNCBHHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Shader PLHMPHIEOLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private Animator NBGBNECHFFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private Renderer[] DNIDEMPGPHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private IONAMLJCLBI.EPMFDMLBDCD HJNNIJIPBDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private AvatarBodyPartShapesManager CMEMLDKLPCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private IReadOnlyDictionary<string, Transform> FGEKHPOIHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private AvatarFaceShapeData.LBCIECHIFGF KODAOKAKKCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private AvatarBodyShapeData.IPHFNEHEGNI OHNACLAFAHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private KMBJPNFNLBA MFGMFALOACJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private bool PFJAAEOOKAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11D")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private bool CNNBGLMCFGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private Color AOOBAGKBKLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private Color HKMJNEIDPCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private Color EHCFLCHGOCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private Color? EOPLPOIEJAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x164")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private Color? ABOIHNMFNOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private Color? OMIFKBHLFBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private Color? GHBPLCDPDNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private Texture2D LOLLMFIBBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private Texture2D NKNHBCNAJFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	[CanBeNull]
	private LLGDDBJNDAK AGHDLFMBNED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private Texture EFGEPIDLJJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private Color BJBBKMMCAMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public Dictionary<Renderer, JIJBLAMHAHH> NFDGNFEJFMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private Dictionary<Renderer, JIJBLAMHAHH> FEOCBDIJLFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private Dictionary<string, List<MMFKGIKBNFG>> OMLMGGNIHEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private Dictionary<string, List<MMFKGIKBNFG>> AOCCKBMJEOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly List<PHBEKKNOPBH> IKONFDPBHCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly List<PHBEKKNOPBH> NENGAFLBBHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly List<PHBEKKNOPBH> MHPLPNKPJIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly List<PHBEKKNOPBH> IDHFHLLPKEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private Dictionary<MMFKGIKBNFG, Material> IEBHCGCILJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private Dictionary<MMFKGIKBNFG, Material> NMMDOGPKLJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private SkinnedMeshRenderer[] MKIDCDJMEDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private SkinnedMeshRenderer[] NJFBFHLPEDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private SkinnedMeshRenderer[] LEKLFKENBGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private SkinnedMeshRenderer[] OGBMHGHODHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly Dictionary<string, PHKGFEHMLBA<Texture2D>> AOCMBCBBCFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly Dictionary<string, PHKGFEHMLBA<Texture2D>> MOEIAHJPNMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private AdditionalHatData OABKEMLKCGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private AdditionalHatData INJEONFNMFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private HairData MEFGAJEEMCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private HairData IELAONBABMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private JJMEKHLKNJB NADFDEJCHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private bool? KHOEDIDLHPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x27C")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private PositionAndRotation AAMJCFNCPNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private Transform DEALBODHMAH;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private Material KGIINAKNMGL;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private Material IHFEEKCJLFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private Dictionary<string, LLGDDBJNDAK> NAFDODKLFFD;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static readonly int PGJNLAILLEE;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static readonly int DAAPFKCCIED;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly int OHHNGLKCJHB;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly int DGDJMPMPIHG;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly int GIJBHOFOCJJ;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly int GOOIEFFCLEB;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private static readonly int KNCOJAIGODO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool FLOIMMHABCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private List<Action> CEHIDMKHFAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private AKKOOIDKLNO IFELOKINMPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private SkinnedMeshRenderer[] MINPJCPOPGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private int PCHIAMPMKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2DC")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private bool MNKKAAHAMLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private int ICEJJILFLIO;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public HBAAEHCBNNO EBFOJDAAFLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA1EB40", Offset = "0xA1D740", VA = "0x180A1EB40", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public HBAAEHCBNNO DCMNHAFECDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private FJCEKCIPLIL DDNEOJGAKLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7C06D00", Offset = "0x7C05900", VA = "0x187C06D00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool IMDLEGCBBNE
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7BFC810", Offset = "0x7BFB410", VA = "0x187BFC810")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private bool GNFBOLMECNE
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7C05590", Offset = "0x7C04190", VA = "0x187C05590")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private bool DIIEPPELIEO
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7C03DC0", Offset = "0x7C029C0", VA = "0x187C03DC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private bool PKEOLGBIPON
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7C050D0", Offset = "0x7C03CD0", VA = "0x187C050D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public AvatarConfiguration DHGFBPPBBBP
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA1C700", Offset = "0xA1B300", VA = "0x180A1C700", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool ILALNKPDCKM
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7C00E30", Offset = "0x7BFFA30", VA = "0x187C00E30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7C014C0", Offset = "0x7C000C0", VA = "0x187C014C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private Material JCPHBDLALKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7C05B10", Offset = "0x7C04710", VA = "0x187C05B10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private Material FPMIADHIHNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7C00BD0", Offset = "0x7BFF7D0", VA = "0x187C00BD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private bool GIOBNMAKIPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA38390", Offset = "0xA36F90", VA = "0x180A38390")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public CIFHCHIGFCF MANMLIOLGMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x240DF80", Offset = "0x240CB80", VA = "0x18240DF80", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return default(CIFHCHIGFCF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7C00E20", Offset = "0x7BFFA20", VA = "0x187C00E20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public Material IFNKPPEELDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA9A0D0", Offset = "0xA98CD0", VA = "0x180A9A0D0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public SkinnedMeshRenderer[] LHCJHHMEACC
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x1A6D3F0", Offset = "0x1A6BFF0", VA = "0x181A6D3F0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public Renderer[] MFKNMAFKONA
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xA8C610", Offset = "0xA8B210", VA = "0x180A8C610", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool FAHAOBKPMFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7C06B70", Offset = "0x7C05770", VA = "0x187C06B70", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public IONAMLJCLBI.EPMFDMLBDCD ADFGECDCPGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xA91310", Offset = "0xA8FF10", VA = "0x180A91310", Slot = "20")]
		get
		{
			return default(IONAMLJCLBI.EPMFDMLBDCD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int OHFKDILAMML
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x275CFD0", Offset = "0x275BBD0", VA = "0x18275CFD0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7C00FB0", Offset = "0x7BFFBB0", VA = "0x187C00FB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private bool MAACAJCFHAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7C00E40", Offset = "0x7BFFA40", VA = "0x187C00E40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private static bool ALMJNEKIDIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7C06B10", Offset = "0x7C05710", VA = "0x187C06B10", Slot = "15")]
	public LKEMGHMAMLP OFEHKPBBJAB(BPPOMJONOGG OBLKGLCKNNP, bool GGFOKGACMJM, int[] AOMGOCOHHKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7C07900", Offset = "0x7C06500", VA = "0x187C07900", Slot = "14")]
	public LKEMGHMAMLP PMHPEGFHGFJ(BPPOMJONOGG OBLKGLCKNNP, bool GGFOKGACMJM, int[] AOMGOCOHHKN, Func<Dictionary<string, LLGDDBJNDAK>, (LKEMGHMAMLP, KLHBLGBFFDH<Dictionary<string, PHKGFEHMLBA<Texture2D>>>)> NOECOFPPOCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7BFF020", Offset = "0x7BFDC20", VA = "0x187BFF020")]
	public LKEMGHMAMLP DDLBHMHEPDN(BPPOMJONOGG OBLKGLCKNNP, bool GGFOKGACMJM, int[] AOMGOCOHHKN, bool IBMNGCPFPFC, FPAJOPAEPNO JFAPHHIFFGJ, [Optional] Func<Dictionary<string, LLGDDBJNDAK>, (LKEMGHMAMLP, KLHBLGBFFDH<Dictionary<string, PHKGFEHMLBA<Texture2D>>>)> NOECOFPPOCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7BFBF30", Offset = "0x7BFAB30", VA = "0x187BFBF30")]
	private bool BGMJPCNIDCB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7C06F70", Offset = "0x7C05B70", VA = "0x187C06F70")]
	private LKEMGHMAMLP PHMGOPBLMHC(bool GGFOKGACMJM, List<HEEODOPGCJL> KALLEFNCFGJ, int[] AOMGOCOHHKN, Func<int, IJOHFINFEHF> PDIDDBMEEDO, bool IBMNGCPFPFC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7C01BC0", Offset = "0x7C007C0", VA = "0x187C01BC0")]
	[IteratorStateMachine(typeof(KIBLNNBPJME))]
	private IEnumerator<FCPCPCAPDCM> FPGCLLCFCEO(bool GGFOKGACMJM, List<HEEODOPGCJL> KALLEFNCFGJ, int[] AOMGOCOHHKN, Func<int, IJOHFINFEHF> PDIDDBMEEDO, JIJBLAMHAHH IFAFILPGBNP, Material EKIHHOIIIHL, List<LKEMGHMAMLP> PNCCGMHJCKM, bool IANPEPDIDNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7C03F20", Offset = "0x7C02B20", VA = "0x187C03F20")]
	private void KCOGCLPHNDI(List<HEEODOPGCJL> KALLEFNCFGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7C01DC0", Offset = "0x7C009C0", VA = "0x187C01DC0")]
	private LKEMGHMAMLP GBKPMKDMOED(List<HEEODOPGCJL> KALLEFNCFGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7BFDF20", Offset = "0x7BFCB20", VA = "0x187BFDF20")]
	private GCBFJNEKOIO DDENHLBKHCH(List<HEEODOPGCJL> KALLEFNCFGJ, int FEJALILJGHL, bool GGFOKGACMJM, IJOHFINFEHF EFIHPJLECIH, bool HMBFMFKCGNP, JIJBLAMHAHH IFAFILPGBNP, Material EKIHHOIIIHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7C02730", Offset = "0x7C01330", VA = "0x187C02730", Slot = "27")]
	public void GCMIGKJMHOC(IEKNNJIHFMK EGADONEDPAC, float OOHGFGHCOAJ, bool BHJMHIMEMCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7BFDDB0", Offset = "0x7BFC9B0", VA = "0x187BFDDB0", Slot = "29")]
	public void CMIPAAIJLGD(AFLDMIJCCDM MDFALFHFLME, float OOHGFGHCOAJ, bool KPBJMIGOJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7C03880", Offset = "0x7C02480", VA = "0x187C03880", Slot = "30")]
	public void IJJGLJCCCED(PPFKBBIJKBH EEMPKBDIOGI, float OOHGFGHCOAJ, bool LBLFCEDCDIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7BFB5D0", Offset = "0x7BFA1D0", VA = "0x187BFB5D0", Slot = "28")]
	public void AJGEDCOLJCO(bool AKNPPECOPCI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7C02840", Offset = "0x7C01440", VA = "0x187C02840", Slot = "31")]
	public void GGFCPCDJPCK(bool AKNPPECOPCI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7BFCC20", Offset = "0x7BFB820", VA = "0x187BFCC20", Slot = "32")]
	public void CFFFJPFCMJL(bool AKNPPECOPCI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7C05CB0", Offset = "0x7C048B0", VA = "0x187C05CB0")]
	private void NBOHNNLMECD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7C030E0", Offset = "0x7C01CE0", VA = "0x187C030E0")]
	private void HGJDJHJFBFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7C048C0", Offset = "0x7C034C0", VA = "0x187C048C0")]
	private void LAPLKJJPICF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7C03A80", Offset = "0x7C02680", VA = "0x187C03A80", Slot = "25")]
	public void ILPLJOFIJIL(AvatarFaceShape OANIPCLJBHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7BFB730", Offset = "0x7BFA330", VA = "0x187BFB730", Slot = "26")]
	public void BDEOJLJJJLJ(AvatarBodyShape NLMAEIDEOID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0xB52060", Offset = "0xB50C60", VA = "0x180B52060", Slot = "33")]
	public void POGBOBDAIPD(KMBJPNFNLBA MAPLPIGEHBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7C051B0", Offset = "0x7C03DB0", VA = "0x187C051B0", Slot = "35")]
	public void LLOCHOINOKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7C05980", Offset = "0x7C04580", VA = "0x187C05980", Slot = "39")]
	public void MFLONHCDJDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7C034C0", Offset = "0x7C020C0", VA = "0x187C034C0", Slot = "34")]
	public void IBALOJOACIH(bool NEOADBHBGGE, bool LEENJDNBDAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7C076A0", Offset = "0x7C062A0", VA = "0x187C076A0")]
	private void PJMOLDCLBBE(SkinnedMeshRenderer ECJEMNDIMFL, int FEJALILJGHL, Mesh BFDKALDCPEN, List<Material> DHFGNMCMOBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7C02010", Offset = "0x7C00C10", VA = "0x187C02010")]
	private static Material GBLECKDKKOM(Dictionary<MMFKGIKBNFG, Material> AEIOEINECBE, Material HCIBNJFNKOE, CHMPAKGJEMJ KDHDOJGANHL, IEENCACOFDN AMGKCPMFOHO, HBNDGNKPEKC PMGLBCDCDJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7C01660", Offset = "0x7C00260", VA = "0x187C01660")]
	private static CHMPAKGJEMJ FBDHBIOHBJJ(HEEODOPGCJL HCPJCHFLCJE, int CJLABNGCJFH)
	{
		return default(CHMPAKGJEMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7C010B0", Offset = "0x7BFFCB0", VA = "0x187C010B0")]
	private void EHIJPCABMEJ(int BNDMLLLLIFG, Material IMKAMKEPJBL, HEEODOPGCJL HCPJCHFLCJE, [Out] Texture2D NEABOCHKDMP, [Out] Vector4 PBADIOGGHEF, [Out] Texture2D GOPMGNDADMA, [Out] Texture2D HAAECOGBPDP, [Out] Texture2D EMLKCLCFMOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7BFC2F0", Offset = "0x7BFAEF0", VA = "0x187BFC2F0")]
	private void BKJMOOGAOLC(int BNDMLLLLIFG, Material IMKAMKEPJBL, HEEODOPGCJL HCPJCHFLCJE, [Out] Color DELLAIPLOAD, [Out] Color EPECBPKFFMM, [Out] Color GGBCNKJOKOF, [Out] Color HJMMCCGJFEK, [Out] Color DCCHECKDFEA, [Out] Color OJDELFLFEKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7BFBCD0", Offset = "0x7BFA8D0", VA = "0x187BFBCD0")]
	private bool BEHKNJOMCFC(Material IMKAMKEPJBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7C03830", Offset = "0x7C02430", VA = "0x187C03830")]
	private static Material IEMADOGOHMN(int BNDMLLLLIFG, FJKKMBFKEKO HCPJCHFLCJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7C01CE0", Offset = "0x7C008E0", VA = "0x187C01CE0")]
	private static IEENCACOFDN FPHMPFHJAAG(HEEODOPGCJL HCPJCHFLCJE, int CJLABNGCJFH)
	{
		return default(IEENCACOFDN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7C05D30", Offset = "0x7C04930", VA = "0x187C05D30")]
	private static void NDCDGBLGOIJ(Dictionary<string, List<MMFKGIKBNFG>> IGFGOFBOBHO, HEEODOPGCJL LHIGOHPMBEL, Material HCIBNJFNKOE, CHMPAKGJEMJ EJKOOEFJHNG, IEENCACOFDN PEMGCOHLNAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7C05670", Offset = "0x7C04270", VA = "0x187C05670")]
	private static SkinnedMeshRenderer LPPOFEGLBCG(Transform GGLDFNBLAJB, Transform CNJAIHEABNH, SkinnedMeshRenderer[] CJNELIGBCMK, int FEJALILJGHL, IJOHFINFEHF EFIHPJLECIH, bool GGFOKGACMJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7C07BE0", Offset = "0x7C067E0", VA = "0x187C07BE0")]
	public ONACKJBPCGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7C04CD0", Offset = "0x7C038D0", VA = "0x187C04CD0")]
	public void LEIJOMGLGOC([In] EPLCEEHGJGF KIMCFPDKNBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7C03D40", Offset = "0x7C02940", VA = "0x187C03D40")]
	public void LFDKLMDJMNB([In] MMNFJHLEJHG FAPCDBOJNBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7C00FB0", Offset = "0x7BFFBB0", VA = "0x187C00FB0", Slot = "5")]
	public void GPAHMHFKIMC(int FEJALILJGHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7C03B40", Offset = "0x7C02740", VA = "0x187C03B40", Slot = "10")]
	public void JCHAKOBHKBL(JOKFPFKNGNJ PEMGCOHLNAD, Texture2D BDAIEAKKDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xA38390", Offset = "0xA36F90", VA = "0x180A38390")]
	public static bool PBEAIFINLBG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7BFCAB0", Offset = "0x7BFB6B0", VA = "0x187BFCAB0", Slot = "11")]
	public bool CFBOIEBFHAE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7C05FD0", Offset = "0x7C04BD0", VA = "0x187C05FD0", Slot = "9")]
	public void NGHGJCAJBOD(ELNPIJIEBOB EJKOOEFJHNG, Color? GCKOLKABAJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7BFB630", Offset = "0x7BFA230", VA = "0x187BFB630")]
	private void ANKBNBHACAL(Action NCBAOHKOKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7C00F40", Offset = "0x7BFFB40", VA = "0x187C00F40", Slot = "6")]
	public void EFICKOPONGE(LLGDDBJNDAK ANANENHFKHF, Texture AGBELKENJFI, Color GODGBCOHAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7C014C0", Offset = "0x7C000C0", VA = "0x187C014C0", Slot = "7")]
	public void ILHCJEGKHKM(bool IANPEPDIDNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1DB7570", Offset = "0x1DB6170", VA = "0x181DB7570", Slot = "8")]
	public void FNCFAOKGCOF(AKKOOIDKLNO GALEDNLDGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7BFDB90", Offset = "0x7BFC790", VA = "0x187BFDB90", Slot = "16")]
	public void CJJDALLIIAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7C014D0", Offset = "0x7C000D0", VA = "0x187C014D0", Slot = "36")]
	public void EKDBPINOKDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7BFCC80", Offset = "0x7BFB880", VA = "0x187BFCC80", Slot = "37")]
	public void CFFPACDHBEL([Optional] JJMEKHLKNJB KFFFNCOIDFN, [Optional] bool? OBCMEHLLCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7C034D0", Offset = "0x7C020D0", VA = "0x187C034D0")]
	private bool IBMDPNHGDHH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7BFB710", Offset = "0x7BFA310", VA = "0x187BFB710", Slot = "21")]
	public bool BANIGEDOCIP(IONAMLJCLBI.EPMFDMLBDCD EEDJFLPHBGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7C077F0", Offset = "0x7C063F0", VA = "0x187C077F0", Slot = "38")]
	public void PKOPGCDNGNP(float KOGLMODGKLP, Color GCKOLKABAJC, bool NOKPILMLOPP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7C04540", Offset = "0x7C03140", VA = "0x187C04540")]
	public void KGKCLKHNMOA(float KOGLMODGKLP, Color GCKOLKABAJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7C039A0", Offset = "0x7C025A0", VA = "0x187C039A0")]
	private static bool ILKIIBDNPBD(Material EKIHHOIIIHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7BFB410", Offset = "0x7BFA010", VA = "0x187BFB410")]
	private void AIPNGHKLFOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7C05AD0", Offset = "0x7C046D0", VA = "0x187C05AD0")]
	private void MKEKELPKDLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7C07930", Offset = "0x7C06530", VA = "0x187C07930")]
	private static void PPGJFICCHFL(Dictionary<MMFKGIKBNFG, Material> AEIOEINECBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7BFB2A0", Offset = "0x7BF9EA0", VA = "0x187BFB2A0")]
	private static void AFKIHBBPCGP(Dictionary<Renderer, JIJBLAMHAHH> IBHILDLAAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7C033A0", Offset = "0x7C01FA0", VA = "0x187C033A0")]
	private void HOHLONFLMPJ(SkinnedMeshRenderer[] CJNELIGBCMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7C01530", Offset = "0x7C00130", VA = "0x187C01530")]
	private void EOPECGIPHAI(SkinnedMeshRenderer APIEKGDHKJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7C01760", Offset = "0x7C00360", VA = "0x187C01760")]
	private void FDCFCEMMCHE(List<PHBEKKNOPBH> NELLFFDLDOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7BFC8F0", Offset = "0x7BFB4F0", VA = "0x187BFC8F0")]
	private void BPBMLDIEGJJ(Dictionary<string, PHKGFEHMLBA<Texture2D>> IGFGOFBOBHO, bool PKJFOCAHNKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7C03090", Offset = "0x7C01C90", VA = "0x187C03090")]
	private void HGGMIDOCMEN(Dictionary<string, List<MMFKGIKBNFG>> IGFGOFBOBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7C07550", Offset = "0x7C06150", VA = "0x187C07550")]
	private void PJDDHHCOPKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7C03610", Offset = "0x7C02210", VA = "0x187C03610")]
	private void ICOAPJIDMKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7C02170", Offset = "0x7C00D70", VA = "0x187C02170")]
	private void GCIGPCIOIAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7BFDAC0", Offset = "0x7BFC6C0", VA = "0x187BFDAC0")]
	private void CFKHFMCFGBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7C01940", Offset = "0x7C00540", VA = "0x187C01940")]
	private void FEEGFEPMOHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7C01A70", Offset = "0x7C00670", VA = "0x187C01A70")]
	private void FPFGNLOEIIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7C06D70", Offset = "0x7C05970", VA = "0x187C06D70")]
	private void PECFJDNEBCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7C00FD0", Offset = "0x7BFFBD0", VA = "0x187C00FD0")]
	private void EFLLGCKDMKN(bool FKLLCIBPBLG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7C03EA0", Offset = "0x7C02AA0", VA = "0x187C03EA0")]
	private void JOCMLAJBELI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7C058A0", Offset = "0x7C044A0", VA = "0x187C058A0")]
	private void MCAILLNKLNE(bool FKLLCIBPBLG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7C063D0", Offset = "0x7C04FD0", VA = "0x187C063D0")]
	private void NIIGDCLLCHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7BFB7F0", Offset = "0x7BFA3F0", VA = "0x187BFB7F0")]
	private void BDMGFBDBMEA(Material EKIHHOIIIHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7C069A0", Offset = "0x7C055A0", VA = "0x187C069A0")]
	private void OBMHDPKKMLL(Material EKIHHOIIIHL, Color LCGNODDHHLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7C03160", Offset = "0x7C01D60", VA = "0x187C03160")]
	private void HIABIGNOFJM(Material EKIHHOIIIHL, Color LCGNODDHHLI, Color KJDBIIONCGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7BFC000", Offset = "0x7BFAC00", VA = "0x187BFC000")]
	private void BHINGNPAAOP(Material EKIHHOIIIHL, Color DELLAIPLOAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7C067B0", Offset = "0x7C053B0", VA = "0x187C067B0")]
	private void NOFJMINCKAK(Material EKIHHOIIIHL, Texture2D BDAIEAKKDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7C00CC0", Offset = "0x7BFF8C0", VA = "0x187C00CC0")]
	private void DJBIGLNMHKG(Material EKIHHOIIIHL, Texture PGKCECJMBBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7BFC190", Offset = "0x7BFAD90", VA = "0x187BFC190")]
	private void BIDIJLABMBB(Action<JIJBLAMHAHH> ELAHKDJEBIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7C06DF0", Offset = "0x7C059F0", VA = "0x187C06DF0")]
	private void PEFPEBNFIMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7C028A0", Offset = "0x7C014A0", VA = "0x187C028A0")]
	private void GLDOMEFENAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7C02CC0", Offset = "0x7C018C0", VA = "0x187C02CC0")]
	private void HANNAMKMDPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7C04940", Offset = "0x7C03540", VA = "0x187C04940")]
	public void LEHAKHGBGNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7C03D40", Offset = "0x7C02940", VA = "0x187C03D40", Slot = "4")]
	private void JEHLIIIDIFH([In] MMNFJHLEJHG FAPCDBOJNBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x7BFCA70", Offset = "0x7BFB670", VA = "0x187BFCA70")]
	[CompilerGenerated]
	private AFMJGMMOLON CBKKADFECAE(HEEODOPGCJL MBEDIGACNGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7C015D0", Offset = "0x7C001D0", VA = "0x187C015D0")]
	[CompilerGenerated]
	private void EPNODIFDKLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7C06780", Offset = "0x7C05380", VA = "0x187C06780")]
	[CompilerGenerated]
	private void NLEKBEEACKJ(JIJBLAMHAHH FAFCDNLNADB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7BFDE90", Offset = "0x7BFCA90", VA = "0x187BFDE90")]
	[CompilerGenerated]
	private void CPMDEOHHHEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7C06CE0", Offset = "0x7C058E0", VA = "0x187C06CE0")]
	[CompilerGenerated]
	private void OMBKGDKAKDG(JIJBLAMHAHH FAFCDNLNADB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7C066F0", Offset = "0x7C052F0", VA = "0x187C066F0")]
	[CompilerGenerated]
	private void NJJONHNONME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7BFDD90", Offset = "0x7BFC990", VA = "0x187BFDD90")]
	[CompilerGenerated]
	private void CMEAMGOEOFE(JIJBLAMHAHH FAFCDNLNADB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7C019D0", Offset = "0x7C005D0", VA = "0x187C019D0")]
	[CompilerGenerated]
	private void FHDEFIBMPDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7BFC7E0", Offset = "0x7BFB3E0", VA = "0x187BFC7E0")]
	[CompilerGenerated]
	private void BOIBJKKDABM(JIJBLAMHAHH FAFCDNLNADB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7BFB210", Offset = "0x7BF9E10", VA = "0x187BFB210")]
	[CompilerGenerated]
	private void ABGCCHFINJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7C06B40", Offset = "0x7C05740", VA = "0x187C06B40")]
	[CompilerGenerated]
	private void OHLLBHJPMKO(JIJBLAMHAHH FAFCDNLNADB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7C037A0", Offset = "0x7C023A0", VA = "0x187C037A0")]
	[CompilerGenerated]
	private void IDJFMJADJJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7C02810", Offset = "0x7C01410", VA = "0x187C02810")]
	[CompilerGenerated]
	private void GFNLKGKJIHO(JIJBLAMHAHH FAFCDNLNADB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7C05040", Offset = "0x7C03C40", VA = "0x187C05040")]
	[CompilerGenerated]
	private void LGEPGPAPNIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7C05AE0", Offset = "0x7C046E0", VA = "0x187C05AE0")]
	[CompilerGenerated]
	private void MLGADIDNJML(JIJBLAMHAHH FAFCDNLNADB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7C00EC0", Offset = "0x7BFFAC0", VA = "0x187C00EC0")]
	[CompilerGenerated]
	private void EBCGKBDJBEL(KeyValuePair<string, PHKGFEHMLBA<Texture2D>> IFNMAHCBHMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7C01A60", Offset = "0x7C00660", VA = "0x187C01A60")]
	[CompilerGenerated]
	private void FOFKNINIKBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7BFC7B0", Offset = "0x7BFB3B0", VA = "0x187BFC7B0")]
	[CompilerGenerated]
	private void BKNCNLMEDEL(JIJBLAMHAHH FAFCDNLNADB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7BFB400", Offset = "0x7BFA000", VA = "0x187BFB400")]
	[CompilerGenerated]
	private void AHDMDPJELEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7C03970", Offset = "0x7C02570", VA = "0x187C03970")]
	[CompilerGenerated]
	private void IKLNIOJHFHI(JIJBLAMHAHH FAFCDNLNADB)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class AvatarElbowBendHelperController : MonoBehaviour, KIJBPNOFNNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		[GHKDIKFNBMM(EBAHNMNBCJP.Self, false, false, false)]
		[SerializeField]
		private Transform ElbowHelperBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		[SerializeField]
		private Transform UpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[SerializeField]
		private Transform LowerArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[SerializeField]
		private float MinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[SerializeField]
		private float MaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		[FormerlySerializedAs("MinScaleValues")]
		[Header("Scale")]
		[SerializeField]
		private Vector3 ScaleValuesAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		[FormerlySerializedAs("MaxScaleValues")]
		[SerializeField]
		private Vector3 ScaleValuesAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		[SerializeField]
		[FormerlySerializedAs("MinLocalPositionalOffset")]
		[Header("Positional Offset")]
		private Vector3 PositionalOffsetAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		[FormerlySerializedAs("MaxLocalPositionOffset")]
		[SerializeField]
		private Vector3 PositionalOffsetAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private Vector3? IEBHGIBKOHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private bool PHGHJFECKON;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7BF3BB0", Offset = "0x7BF27B0", VA = "0x187BF3BB0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7BF41D0", Offset = "0x7BF2DD0", VA = "0x187BF41D0", Slot = "4")]
		public void UpdateController(float DJGAODFCDIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xCF0760", Offset = "0xCEF360", VA = "0x180CF0760", Slot = "6")]
		public void SetEnabled(bool OOHGFGHCOAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7BF3C90", Offset = "0x7BF2890", VA = "0x187BF3C90")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7BF4690", Offset = "0x7BF3290", VA = "0x187BF4690")]
		public AvatarElbowBendHelperController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class AvatarElbowBendTargetController : MonoBehaviour, KIJBPNOFNNH
	{
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private const float MENLEKCPBBJ = 45f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[SerializeField]
		[GHKDIKFNBMM(EBAHNMNBCJP.Self, false, false, false)]
		private Transform ElbowBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[SerializeField]
		private Transform NeckBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		[SerializeField]
		private Transform UpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		[SerializeField]
		private bool Left;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		[SerializeField]
		private float MinTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		[SerializeField]
		private float MaxTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		[SerializeField]
		private float TwistWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		[SerializeField]
		private float ElbowSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		[SerializeField]
		private float RestTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		[SerializeField]
		private float RestTwistWhenClose;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		[SerializeField]
		private float RestTwistDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private Vector3 OIAGFGIIEDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private Vector3 ACJOMBHOFOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private bool PHGHJFECKON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private float JODJLOILJLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private float JLFMDJLDFPG;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7BF4A10", Offset = "0x7BF3610", VA = "0x187BF4A10", Slot = "4")]
		public void UpdateController(float DJGAODFCDIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xF325D0", Offset = "0xF311D0", VA = "0x180F325D0", Slot = "6")]
		public void SetEnabled(bool OOHGFGHCOAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7BF4730", Offset = "0x7BF3330", VA = "0x187BF4730")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7BF54D0", Offset = "0x7BF40D0", VA = "0x187BF54D0")]
		public AvatarElbowBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class BGIHBEMGGAL : DKHBNCECMKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static readonly int JMLCLIGPNON;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private static readonly int KBNBNENKJOM;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static readonly int OOLMGABDKEL;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static readonly int KCOJHHKEIFC;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private static readonly int KABIHJGAAMM;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private static readonly int IIBOKKPICOH;

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private static readonly int BIIKCEMNKPI;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private static readonly int KDJJJAPDHNC;

	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private static readonly int LLLPIMHCAGB;

	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private static readonly int LGMAEEKGKHL;

	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private static readonly int NPKMDEKNPHF;

	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private static readonly int LEOGOGNJBGM;

	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private static readonly int FINPIBFCNHA;

	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private static readonly int MKEMGPDCJKM;

	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private static readonly int CKDDKILCHOF;

	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private static readonly int LHPPJFOJILA;

	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private static readonly int EKHHFPEMDDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private Transform OBPKPCKNMAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private Transform HJAKFLEBGHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private Transform IJOMKJEBPLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private Transform IEJFHLEFFLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private Transform JPGDFACCOPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private Transform LACHOJMKLHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private MHLPKNEKDOF KBIKABEPDGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private Material ILKKLDCJCCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private SkinnedMeshRenderer[] EPEEJIMKPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private readonly List<Material> IGBMIMAIHMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private OEGCNCIIODM JLBDENPCHKO;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public HBAAEHCBNNO BBEJJBMAHDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0xA1EB40", Offset = "0xA1D740", VA = "0x180A1EB40", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private OEGCNCIIODM AIDKBJPJFAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7C0DE90", Offset = "0x7C0CA90", VA = "0x187C0DE90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool PPEBHELAIMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7C0DD30", Offset = "0x7C0C930", VA = "0x187C0DD30", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x7C0F7A0", Offset = "0x7C0E3A0", VA = "0x187C0F7A0")]
	public void LEIJOMGLGOC([In] MHLPKNEKDOF LBGNBDPOHCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7C0F370", Offset = "0x7C0DF70", VA = "0x187C0F370")]
	public void JBNFLNOAFBO([In] HEILDFICPPP MBCFMKDOGBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x7C0D820", Offset = "0x7C0C420", VA = "0x187C0D820", Slot = "6")]
	public void AEMJGDBCGMJ(LMICPILDBNN BACJLJILCKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7C0F850", Offset = "0x7C0E450", VA = "0x187C0F850")]
	private Vector2 ONPFNLJPFPD(Vector2 LCCFFCCDOEF)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7C0E440", Offset = "0x7C0D040", VA = "0x187C0E440")]
	public void HJENFOGBGIP([In] EABIGMNFGNA MBCFMKDOGBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7C0E070", Offset = "0x7C0CC70", VA = "0x187C0E070")]
	private void GHKOJGCJLDL(HGJOAKNDMGF OELEKJGNECA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7C0F410", Offset = "0x7C0E010", VA = "0x187C0F410")]
	private void JCJNCAINGHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7C0E000", Offset = "0x7C0CC00", VA = "0x187C0E000")]
	private void LPBKMJFGAPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x7C0E000", Offset = "0x7C0CC00", VA = "0x187C0E000", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7C0FB80", Offset = "0x7C0E780", VA = "0x187C0FB80")]
	public BGIHBEMGGAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7C0F370", Offset = "0x7C0DF70", VA = "0x187C0F370", Slot = "5")]
	private void JFKHDLNDKJE([In] HEILDFICPPP MBCFMKDOGBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7C0DE80", Offset = "0x7C0CA80", VA = "0x187C0DE80", Slot = "7")]
	private void BMDLMDPGMCF([In] EABIGMNFGNA MBCFMKDOGBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7C0E430", Offset = "0x7C0D030", VA = "0x187C0E430")]
	[CompilerGenerated]
	internal static float HEHBMEKJLNE(float OOHGFGHCOAJ, float OHLKEIOKDNG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7C0DF10", Offset = "0x7C0CB10", VA = "0x187C0DF10")]
	[CompilerGenerated]
	internal static void DGFCAHKDMBP(Vector2 HEKKEJMBPPF, Vector2 PHGGIKNPBNH, Vector2 DKFJGBGJGBG, Vector2 PNMBBJAACMD, Vector2 LMOAHCJOHNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x7C0F330", Offset = "0x7C0DF30", VA = "0x187C0F330")]
	[CompilerGenerated]
	internal static Vector4 JBJIJOPKDKD(Vector2 IIBJECFMAJC, Vector2 LHHOCCKJGIB)
	{
		return default(Vector4);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class AvatarForearmRollController : MonoBehaviour, KIJBPNOFNNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		[SerializeField]
		private Transform TwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		[SerializeField]
		private Transform LowerArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		[SerializeField]
		private Transform UpperArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		[SerializeField]
		private Transform ElbowTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		[SerializeField]
		private float RollTowardsWristAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		[SerializeField]
		private float RollSoftMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		[SerializeField]
		private float RollSoftMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		[SerializeField]
		private float LowerArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		[SerializeField]
		private float UpperArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		[SerializeField]
		private float ElbowTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private float JODJLOILJLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private bool PHGHJFECKON;

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7C0AEF0", Offset = "0x7C09AF0", VA = "0x187C0AEF0", Slot = "4")]
		public void UpdateController(float DJGAODFCDIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x20FBCF0", Offset = "0x20FA8F0", VA = "0x1820FBCF0", Slot = "6")]
		public void SetEnabled(bool OOHGFGHCOAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x7C0B750", Offset = "0x7C0A350", VA = "0x187C0B750")]
		public AvatarForearmRollController()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class AvatarHandDisplaySettings
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public class AnimationOverride
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000170")]
			[Tooltip("Name of animation original state to override")]
			public string OriginalName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000171")]
			[Tooltip("Name of animation state to use as an override")]
			public string OverrideName;

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
			public AnimationOverride()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		[SerializeField]
		private AnimationOverride[] HandStateOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private Dictionary<int, int> _animationOverrides;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x7C0B780", Offset = "0x7C0A380", VA = "0x187C0B780")]
		public void GFFHNKPMBNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x7C0B8A0", Offset = "0x7C0A4A0", VA = "0x187C0B8A0")]
		public int MLKDBNJHHFD(int KJFDPLFEBMJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public AvatarHandDisplaySettings()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class GBGKJEHAAAI : MMPGIIHBAPF
{
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7C141D0", Offset = "0x7C12DD0", VA = "0x187C141D0", Slot = "24")]
	public override float BMDDFHNBJNN()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x7C14220", Offset = "0x7C12E20", VA = "0x187C14220")]
	public GBGKJEHAAAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class MMPGIIHBAPF : KGCOEBBKGCN
{
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private static int GCPBFONEBOA;

	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private static int PJIPPAFFIHJ;

	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private static int HLNKJLIDBEH;

	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private static int ABNKADGFHOB;

	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private static int IAPDOKHPICP;

	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private static int ILJOOPNFFDJ;

	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private static int GHBNLHGJEAB;

	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private static int[] PBLPAJEFKEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private IKGGABJJCMA KBIKABEPDGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private ILCGLEGGDGK IJBBNHGDKCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private int HJLEILIPBNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private float EBONNFCKKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	protected Animator NBGBNECHFFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	protected AvatarConfiguration KMMGNAPKOLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	protected int KFPGLAMALAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private int EMLDBBFMAFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private int COJLKKMHCBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private bool NKIBIDBBEFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private NFIEDKKPELO CEOFIANBHMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private int EFOJOOECJMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private float IDLGEHMBABK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private AvatarHandDisplaySettings IENIDDCMLHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private CIFHCHIGFCF NPJDGJKDGFH;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Transform JHCGDBBOPKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xA1EB40", Offset = "0xA1D740", VA = "0x180A1EB40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0xA1EB20", Offset = "0xA1D720", VA = "0x180A1EB20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public Vector3 FADPDGDCHDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x17FCBA0", Offset = "0x17FB7A0", VA = "0x1817FCBA0")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x17FC950", Offset = "0x17FB550", VA = "0x1817FC950")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Quaternion HDIJKLNCNNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0xDCF4E0", Offset = "0xDCE0E0", VA = "0x180DCF4E0")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xF9CDF0", Offset = "0xF9B9F0", VA = "0x180F9CDF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool CDANHNMJLBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x7C1A5C0", Offset = "0x7C191C0", VA = "0x187C1A5C0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7C19FB0", Offset = "0x7C18BB0", VA = "0x187C19FB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool IBJPLGKIFLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xBE52E0", Offset = "0xBE3EE0", VA = "0x180BE52E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public Vector3 DONEAIBKKIM
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xA4A0C0", Offset = "0xA48CC0", VA = "0x180A4A0C0", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0xA4A0A0", Offset = "0xA48CA0", VA = "0x180A4A0A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Quaternion MBCECDJMEDC
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x1152BD0", Offset = "0x11517D0", VA = "0x181152BD0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x15B7100", Offset = "0x15B5D00", VA = "0x1815B7100")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public CNIBPJLPBFA LHIOEEEDAED
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0xAA07A0", Offset = "0xA9F3A0", VA = "0x180AA07A0", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return default(CNIBPJLPBFA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xA9FE60", Offset = "0xA9EA60", VA = "0x180A9FE60", Slot = "4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public CNIBPJLPBFA FLGIOEJEGCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xAA0790", Offset = "0xA9F390", VA = "0x180AA0790", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(CNIBPJLPBFA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xA9FE70", Offset = "0xA9EA70", VA = "0x180A9FE70", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public float LBJKDGAIFJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xB52B30", Offset = "0xB51730", VA = "0x180B52B30", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xFB10C0", Offset = "0xFAFCC0", VA = "0x180FB10C0", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool NGEEKJCDJDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7C1A5B0", Offset = "0x7C191B0", VA = "0x187C1A5B0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7C19F20", Offset = "0x7C18B20", VA = "0x187C19F20", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool JKLOBLEJFGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x7C1A400", Offset = "0x7C19000", VA = "0x187C1A400")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool BALBKMKCGLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x7C19F80", Offset = "0x7C18B80", VA = "0x187C19F80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool NNBOGBDOKAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x7C19F90", Offset = "0x7C18B90", VA = "0x187C19F90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool KLKIKEIFBML
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x7C19FA0", Offset = "0x7C18BA0", VA = "0x187C19FA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x7C1A410", Offset = "0x7C19010", VA = "0x187C1A410", Slot = "23")]
	public void LEIJOMGLGOC(IKGGABJJCMA LBGNBDPOHCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x7C19D10", Offset = "0x7C18910", VA = "0x187C19D10")]
	public void AIHBFGCCIHE(ILCGLEGGDGK DFNMCAPPCOP, AvatarHandDisplaySettings FDABCNCAEIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x7C1A5F0", Offset = "0x7C191F0", VA = "0x187C1A5F0", Slot = "14")]
	public void NKKNOCIOLHC(bool AENFHNMCJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x7C19FF0", Offset = "0x7C18BF0", VA = "0x187C19FF0", Slot = "13")]
	public void ICAJLJGGDCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0xB52B30", Offset = "0xB51730", VA = "0x180B52B30", Slot = "24")]
	public virtual float BMDDFHNBJNN()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7C1A680", Offset = "0x7C19280", VA = "0x187C1A680")]
	private int OMLHGDIGPJB(CNIBPJLPBFA JDBOPLIKLDF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x7C19D60", Offset = "0x7C18960", VA = "0x187C19D60")]
	private void BDILGJFBIJD(int JDNJKFGACKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7C1A3E0", Offset = "0x7C18FE0", VA = "0x187C1A3E0", Slot = "15")]
	public bool KGEICNGMCME()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7C1A360", Offset = "0x7C18F60", VA = "0x187C1A360", Slot = "16")]
	public bool IENJBNCAIGI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x7C1A370", Offset = "0x7C18F70", VA = "0x187C1A370")]
	private CNIBPJLPBFA IGJKCLIFMOA()
	{
		return default(CNIBPJLPBFA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x1D80060", Offset = "0x1D7EC60", VA = "0x181D80060", Slot = "17")]
	public void AOKEDCGEJCK(bool AENFHNMCJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7C1A800", Offset = "0x7C19400", VA = "0x187C1A800", Slot = "12")]
	public void PCDGKBKGNND(int JDNJKFGACKH, float BBFNOHNDNLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x7C1A3C0", Offset = "0x7C18FC0", VA = "0x187C1A3C0", Slot = "10")]
	public void JCBGAPIBLBL(NFIEDKKPELO DKILGKEHOLM, bool AENDFIMJKFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x7C19FE0", Offset = "0x7C18BE0", VA = "0x187C19FE0", Slot = "11")]
	public void HNALLBEJPOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x7C19F30", Offset = "0x7C18B30", VA = "0x187C19F30", Slot = "18")]
	public void CHNHJLKAEDD(Transform LIPFJJEAFCE, Vector3 IHIJHMKCPPP, Quaternion LOJMBNJIMDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x7C1AAD0", Offset = "0x7C196D0", VA = "0x187C1AAD0")]
	public MMPGIIHBAPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class FJKKMBFKEKO : HEEODOPGCJL
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class BBIPIMGHINJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public FJKKMBFKEKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public List<PHBEKKNOPBH> prefabHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public List<PHBEKKNOPBH> materialHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public PHKGFEHMLBA<Material[]> loadMaterialsHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public PHKGFEHMLBA<PCNGHJMBNDJ> loadPrefabHandle;

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public BBIPIMGHINJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7C0D5E0", Offset = "0x7C0C1E0", VA = "0x187C0D5E0")]
		internal AFMJGMMOLON HJJDDFCNBHN(string error)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	public LLGDDBJNDAK HLOBKCHOLEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	public PCNGHJMBNDJ HMJOEEGFLEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private PHKGFEHMLBA<PCNGHJMBNDJ> BJBHBGIBFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private PHKGFEHMLBA<Material[]> OAMGPDDPPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	public Material[] KKJIKKANHMK;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool AAPNMAOELAI
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0xA4B580", Offset = "0xA4A180", VA = "0x180A4B580")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0xA4B3A0", Offset = "0xA49FA0", VA = "0x180A4B3A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public IONAMLJCLBI.EPMFDMLBDCD LAFKIGMOFGA
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0xA24650", Offset = "0xA23250", VA = "0x180A24650")]
		[CompilerGenerated]
		get
		{
			return default(IONAMLJCLBI.EPMFDMLBDCD);
		}
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0xA282A0", Offset = "0xA26EA0", VA = "0x180A282A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x7C13A90", Offset = "0x7C12690", VA = "0x187C13A90")]
	public FJKKMBFKEKO(HBNDGNKPEKC KABAKPPFEEI, LLGDDBJNDAK JNCBLLJJFKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x7C132C0", Offset = "0x7C11EC0", VA = "0x187C132C0", Slot = "6")]
	public override AFMJGMMOLON NKBEGPLDEPI(List<PHBEKKNOPBH> GAICAFGEPAL, List<PHBEKKNOPBH> GDIHGPOIAMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7C12FC0", Offset = "0x7C11BC0", VA = "0x187C12FC0")]
	public AFMJGMMOLON MDDODHAPHDM(List<PHBEKKNOPBH> GAICAFGEPAL, List<PHBEKKNOPBH> GDIHGPOIAMD, PHKGFEHMLBA<Material[]> OAMGPDDPPPI, [Optional] PHKGFEHMLBA<PCNGHJMBNDJ> FIIBELJEGFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7C12BA0", Offset = "0x7C117A0", VA = "0x187C12BA0")]
	public (PHKGFEHMLBA<Material[]>, PHKGFEHMLBA<PCNGHJMBNDJ>) LNIAENPGICP(List<PHBEKKNOPBH> GAICAFGEPAL, List<PHBEKKNOPBH> GDIHGPOIAMD)
	{
		return default((PHKGFEHMLBA<Material[]>, PHKGFEHMLBA<PCNGHJMBNDJ>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x7C12A70", Offset = "0x7C11670", VA = "0x187C12A70", Slot = "7")]
	public override EMKPFPGHPGK KILGKCKKKOP(uint FEJALILJGHL, AvatarSkinnedMeshBoneOrderRemapsData KOGIGHLMGHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x7C13830", Offset = "0x7C12430", VA = "0x187C13830")]
	public EMKPFPGHPGK ONHJJJKKFLC(GameObject KHKNEOJDCIG, uint FEJALILJGHL, bool NHMEDELDBHL, bool CMGKCFLICEJ, AvatarSkinnedMeshBoneOrderRemapsData KOGIGHLMGHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x7C126F0", Offset = "0x7C112F0", VA = "0x187C126F0")]
	public static bool AAIEAPGCBFM(Renderer[] CJNELIGBCMK, string JBMEBOCOPIP, [Out] Renderer AGNJCECIGKM, [Out] Renderer BEFEEEMFIEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x7C13A40", Offset = "0x7C12640", VA = "0x187C13A40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x7C13760", Offset = "0x7C12360", VA = "0x187C13760")]
	private (PHKGFEHMLBA<PCNGHJMBNDJ>, PHKGFEHMLBA<Material[]>) ODLLLEOKBIE()
	{
		return default((PHKGFEHMLBA<PCNGHJMBNDJ>, PHKGFEHMLBA<Material[]>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x7C12A50", Offset = "0x7C11650", VA = "0x187C12A50")]
	[CompilerGenerated]
	private void BBKAKIDDNHF(PCNGHJMBNDJ DBJBIPJCIKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0xA1C690", Offset = "0xA1B290", VA = "0x180A1C690")]
	[CompilerGenerated]
	private void KABFAGKOPPC(Material[] DBJBIPJCIKA)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class AvatarKneeBendTargetController : MonoBehaviour, KIJBPNOFNNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		[SerializeField]
		[GHKDIKFNBMM(EBAHNMNBCJP.Self, false, false, false)]
		private Transform KneeBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		[SerializeField]
		private Transform RootSpineBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		[SerializeField]
		private Transform ThighBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		[SerializeField]
		private Transform FootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		[SerializeField]
		private float WeightToFootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		[SerializeField]
		private Vector3 BendTargetOffsetFromHipToFootMidPoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		[SerializeField]
		private Bounds KneeTargetConstrainedBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private Vector3 OIAGFGIIEDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private Vector3 DCCPMJADJJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private Vector3 BDAMDMNGLDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private Matrix4x4 LPBLMEJEBLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private bool PHGHJFECKON;

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x7C0BD80", Offset = "0x7C0A980", VA = "0x187C0BD80", Slot = "4")]
		public void UpdateController(float DJGAODFCDIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x7C0BD70", Offset = "0x7C0A970", VA = "0x187C0BD70", Slot = "6")]
		public void SetEnabled(bool OOHGFGHCOAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7C0B910", Offset = "0x7C0A510", VA = "0x187C0B910")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x7C0C440", Offset = "0x7C0B040", VA = "0x187C0C440")]
		public AvatarKneeBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[BOOMHEJPJEF]
public struct DPDKJBAHOMK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	[ReadOnly]
	public AGPBFKGBEPK JCIOOKDKFCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	[ReadOnly]
	public int BJNHJMCBCCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public HJNLIDHLCPM LDCNBHNJLBK;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x7C111C0", Offset = "0x7C0FDC0", VA = "0x187C111C0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[NativeContainer]
[BOOMHEJPJEF]
public struct HJNLIDHLCPM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public NativeArray<Vector3> MKENBMIHMDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public NativeArray<Vector3> KKDCOFEBEMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public NativeArray<Vector4> JNLJAIICJPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public NativeArray<Vector2> OGBLGGGGOIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public NativeArray<Vector2> LBKMFFCDAGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public NativeArray<Vector2> MHCGFPBKHFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	public NativeArray<Vector2> CKMDFHDNBNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	public NativeArray<Color> GNEJLECEADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public NativeArray<int> FIJMMKHBOGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	public NativeArray<int> FOLJMMDNABP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private NativeArray<int> KIBCCNBGLBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private NativeArray<int> ABOJEPGLMNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	public NativeArray<int> AJGPLCBBAED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	public NativeArray<int> HKGNPMLPNJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	public NativeArray<int> KGAICMMFIIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	public NativeArray<BoneWeight> FPOLPGKOGIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private NativeArray<int> GALEDNLDGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private bool IIPMKDBFOJL;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int CPMPAEJBCJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7C14720", Offset = "0x7C13320", VA = "0x187C14720")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x7C14DB0", Offset = "0x7C139B0", VA = "0x187C14DB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int MLJBKBJPEDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x7C144F0", Offset = "0x7C130F0", VA = "0x187C144F0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x7C14EC0", Offset = "0x7C13AC0", VA = "0x187C14EC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public int MKAMGGFOPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x7C14520", Offset = "0x7C13120", VA = "0x187C14520")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x7C14560", Offset = "0x7C13160", VA = "0x187C14560")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x7C14F40", Offset = "0x7C13B40", VA = "0x187C14F40")]
	public HJNLIDHLCPM(int DMMLONIKHJK, int DGGKPEIKPDJ, int DGCPHHBEAOE, int DGCJJFCDOOG, Allocator CMJGNOOCEGA, int DMBBNDPCKIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x7C14ED0", Offset = "0x7C13AD0", VA = "0x187C14ED0")]
	public void PKDMGFOHNPB(int EMMACFPOKFB, Vector3 GCKEIIMJEBO, Vector3 IJDADKHAHCN, Vector4 LPCHKKFEGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x7C14750", Offset = "0x7C13350", VA = "0x187C14750")]
	public void GOGKNAPAJAF(int EMMACFPOKFB, BoneWeight IJMOKCJEFNK, NativeSlice<byte> OBDIEKPNNPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x7C14500", Offset = "0x7C13100", VA = "0x187C14500")]
	public Color BCKCBHEFLPL(int EMMACFPOKFB)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x7C14730", Offset = "0x7C13330", VA = "0x187C14730")]
	public void EGHHFLCMDCK(int EMMACFPOKFB, Color OFHHGNENJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7C14E70", Offset = "0x7C13A70", VA = "0x187C14E70")]
	public void LFIBNMPMAKD(byte NILBKMNBFDH, int EMMACFPOKFB, Vector2 HMGNPMMNGMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x7C14DA0", Offset = "0x7C139A0", VA = "0x187C14DA0")]
	public void KKAFDEFENDG(int EMMACFPOKFB, int OBHKOKLJMOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x7C14530", Offset = "0x7C13130", VA = "0x187C14530")]
	public bool BOJJHOIOEJO(int NILBKMNBFDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x7C14CD0", Offset = "0x7C138D0", VA = "0x187C14CD0")]
	public void KHDENMDDLHD(int NBKDFHMCMMP, int KPHEINADMCH, int FMOIHNPEKPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x7C14DC0", Offset = "0x7C139C0", VA = "0x187C14DC0")]
	public int[] LEOLEJGBJFJ(int NBKDFHMCMMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x7C148F0", Offset = "0x7C134F0", VA = "0x187C148F0")]
	private NativeSlice<int> HBMDDGCFAFD(int NBKDFHMCMMP)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x7C14570", Offset = "0x7C13170", VA = "0x187C14570", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x7C14980", Offset = "0x7C13580", VA = "0x187C14980")]
	public Mesh IJBOLOALJCL([Optional] string KEPNEELPECP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[BOOMHEJPJEF]
[DefaultMember("Item")]
[NativeContainer]
public struct AGPBFKGBEPK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public NativeArray<Vector3> MKENBMIHMDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public NativeArray<Vector3> KKDCOFEBEMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public NativeArray<Vector4> JNLJAIICJPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public NativeArray<Vector2> OGBLGGGGOIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public NativeArray<Vector2> LBKMFFCDAGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public NativeArray<Vector2> MHCGFPBKHFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	public NativeArray<Vector2> CKMDFHDNBNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public NativeArray<Color> GNEJLECEADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public NativeArray<int> BABBDOIFOJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public NativeArray<int> DDMIDDOGFBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public NativeArray<int> LOIGNFKOHAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	public NativeArray<int> EOLMEHBGAHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	public NativeArray<bool> BGDOAPOABHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	public NativeArray<int> KDIBBKDBADJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	public NativeArray<int> AAHJMGOJBIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	public NativeArray<BoneWeight> MOFDEDJFCED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private NativeArray<Matrix4x4> JDBMNGAEDAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private NativeArray<long> NFGCOEDMJEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private NativeArray<byte> FADPHINJALA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private NativeArray<int> DDBPDJJDJLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private NativeArray<int> GGPKBILHCFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public NativeArray<sbyte> HOHDDAMHLJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public NativeArray<byte> NLHELAFBJGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private NativeArray<int> FCDAPDDDNAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private bool IIPMKDBFOJL;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int KKOEKCIDNHC
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xE4EF80", Offset = "0xE4DB80", VA = "0x180E4EF80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int LLFMKHKKEKD
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xCF3410", Offset = "0xCF2010", VA = "0x180CF3410")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public int NHOIGLLHCKK
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7C08E00", Offset = "0x7C07A00", VA = "0x187C08E00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public int LJBOBEFHKEM
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7C09630", Offset = "0x7C08230", VA = "0x187C09630")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x7C090B0", Offset = "0x7C07CB0", VA = "0x187C090B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public int CPMPAEJBCJA
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7C090A0", Offset = "0x7C07CA0", VA = "0x187C090A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x7C09600", Offset = "0x7C08200", VA = "0x187C09600")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int NEAFDAJHHBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7C09640", Offset = "0x7C08240", VA = "0x187C09640")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x7C09610", Offset = "0x7C08210", VA = "0x187C09610")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public OAKJHNENFNC MBPFFJMGAGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x7C08D20", Offset = "0x7C07920", VA = "0x187C08D20")]
		get
		{
			return default(OAKJHNENFNC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x7C09620", Offset = "0x7C08220", VA = "0x187C09620")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public byte KPJFMDJIGEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x7C08D10", Offset = "0x7C07910", VA = "0x187C08D10")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x7C095F0", Offset = "0x7C081F0", VA = "0x187C095F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public IHPGADJBMFJ HHFPMPGGMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x7C090C0", Offset = "0x7C07CC0", VA = "0x187C090C0")]
		get
		{
			return default(IHPGADJBMFJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x7C09650", Offset = "0x7C08250", VA = "0x187C09650")]
	public AGPBFKGBEPK(IList<Mesh> EPGDJLNCGHI, IList<Matrix4x4> NAMGMCKAJAO, IList<bool> BGDOAPOABHM, byte EOMAKFBPFJB, IList<byte[]> AAOKMFAJGNF, IList<long> JPOMBPOEFDP, IList<bool> KLGDLOOBBLI, IList<int> KDIBBKDBADJ, IList<int> LKHKBJHNPOO, IList<int> CCKJKFJKJDB, Allocator CMJGNOOCEGA, OAKJHNENFNC OBHHKIOIHLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x7C08D30", Offset = "0x7C07930", VA = "0x187C08D30")]
	public HJNLIDHLCPM CEHPBEEMHFI(Allocator CMJGNOOCEGA)
	{
		return default(HJNLIDHLCPM);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x7C08E30", Offset = "0x7C07A30", VA = "0x187C08E30", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[BOOMHEJPJEF]
public class EJKGDPFOOOP : DKLDKEIEJEK
{
	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x7C12600", Offset = "0x7C11200", VA = "0x187C12600")]
	public AGPBFKGBEPK IDOHOHIGBOA()
	{
		return default(AGPBFKGBEPK);
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x7BF80B0", Offset = "0x7BF6CB0", VA = "0x187BF80B0")]
	public EJKGDPFOOOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct IHPGADJBMFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public NativeSlice<Vector3> MKENBMIHMDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public NativeSlice<Vector3> KKDCOFEBEMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public NativeSlice<Vector4> JNLJAIICJPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public NativeSlice<Vector2> OGBLGGGGOIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	public NativeSlice<Vector2> LBKMFFCDAGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public NativeSlice<Vector2> MHCGFPBKHFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public NativeSlice<Vector2> CKMDFHDNBNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public NativeSlice<Color> GNEJLECEADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public NativeSlice<int> JHBCAPBNKAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	public NativeSlice<int> EOLMEHBGAHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public NativeSlice<BoneWeight> MOFDEDJFCED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public NativeSlice<byte> KGGDKGIANLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public int NFNBKHOIMPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public Matrix4x4 NCEALKNHBCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	public long EDEFCNFKNPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	public NativeSlice<byte> OBDIEKPNNPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	public bool PNPJDOPCFEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	public int JDFALLOLLMF;
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal readonly struct MMFKGIKBNFG : IEquatable<MMFKGIKBNFG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	internal readonly Material NCKFIMBLHAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	internal readonly CHMPAKGJEMJ FNPPGJJPCNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	internal readonly IEENCACOFDN KHBOMCEAEAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	internal readonly HBNDGNKPEKC GHADCCEDMPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	internal readonly bool CHEIMKJIKMP;

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x7C19BD0", Offset = "0x7C187D0", VA = "0x187C19BD0")]
	public MMFKGIKBNFG(Material IMKAMKEPJBL, CHMPAKGJEMJ KDHDOJGANHL, IEENCACOFDN AMGKCPMFOHO, HBNDGNKPEKC PMGLBCDCDJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x7C19930", Offset = "0x7C18530", VA = "0x187C19930", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x7C19690", Offset = "0x7C18290", VA = "0x187C19690", Slot = "4")]
	public bool Equals(MMFKGIKBNFG GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x7C19720", Offset = "0x7C18320", VA = "0x187C19720", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x7C19820", Offset = "0x7C18420", VA = "0x187C19820", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyDisplayBehaviour : MonoBehaviour, JOPNFGGDFLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		[SerializeField]
		[Header("Configuration")]
		protected AvatarConfiguration configuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		[SerializeField]
		protected Animator skeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		[SerializeField]
		protected Renderer[] watchRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		[Header("Configuration")]
		[SerializeField]
		private CIFHCHIGFCF avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		[SerializeField]
		private AvatarSkinAssetItem potatoAvatarSkinAssetItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		[FormerlySerializedAs("avatarSkinAsset")]
		[SerializeField]
		private AssetReference avatarSkinAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		[SerializeField]
		private GameObject firstPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		[SerializeField]
		public GameObject thirdPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		[SerializeField]
		private GameObject[] hideInFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		[SerializeField]
		protected Transform headAdditiveBaseBoneTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		[FormerlySerializedAs("BodyMaterial")]
		[SerializeField]
		private Material BodyMaterialSkinGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		[SerializeField]
		private Material BodyMaterialNonGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		[SerializeField]
		private Material FaceMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		[SerializeField]
		private Material DefaultAvatarItemMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		[SerializeField]
		private Shader AvatarDefaultShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		[SerializeField]
		private Shader AvatarUberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		[SerializeField]
		private Transform DeformRigRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		[SerializeField]
		private SkinnedMeshRenderer BaseSkinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		[SerializeField]
		protected AvatarSkinnedMeshBoneOrderRemapsData BoneOrderRemapsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		[Header("Arm Animation Controllers")]
		[SerializeField]
		private AvatarForearmRollController LeftForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		[SerializeField]
		private AvatarElbowBendHelperController LeftElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		[SerializeField]
		private AvatarElbowBendTargetController LeftElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		[SerializeField]
		private AvatarKneeBendTargetController LeftKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		[SerializeField]
		private AvatarForearmRollController RightForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		[SerializeField]
		private AvatarElbowBendHelperController RightElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		[SerializeField]
		private AvatarElbowBendTargetController RightElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		[SerializeField]
		private AvatarKneeBendTargetController RightKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		[SerializeField]
		private Transform LeftEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		[SerializeField]
		private Transform LeftEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		[SerializeField]
		private Transform RightEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		[SerializeField]
		private Transform RightEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		[SerializeField]
		private Transform NoseMoveTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		[SerializeField]
		private Transform MouthBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		[SerializeField]
		private AvatarBodyPartShapesManager avatarBodyPartShapesManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		[SerializeField]
		private Transform HatAnchorBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		[SerializeField]
		private Transform LeftHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		[SerializeField]
		private Transform RightHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		[SerializeField]
		private GameObject LeftHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		[SerializeField]
		private GameObject RightHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		private JOAGHKKNMDI LFBDCADGLCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private DKHBNCECMKL EIAAOCJBJEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		private KGCOEBBKGCN ANBPHJLOBEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		private KGCOEBBKGCN OCPBHEBDGBA;

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public JOAGHKKNMDI ENMDGKKFJHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x7C0D480", Offset = "0x7C0C080", VA = "0x187C0D480", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public DKHBNCECMKL AJNOHKDKICA
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x7C0D4D0", Offset = "0x7C0C0D0", VA = "0x187C0D4D0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public KGCOEBBKGCN KCPFOGJKIAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x7C0D520", Offset = "0x7C0C120", VA = "0x187C0D520", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public KGCOEBBKGCN ALBLEJFMLHP
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x7C0D570", Offset = "0x7C0C170", VA = "0x187C0D570", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public Transform GNLOAOBIKGL
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x7C0D5C0", Offset = "0x7C0C1C0", VA = "0x187C0D5C0", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public CIFHCHIGFCF HMOHOLHLCEL
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0xA28290", Offset = "0xA26E90", VA = "0x180A28290", Slot = "12")]
			get
			{
				return default(CIFHCHIGFCF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7C0C450", Offset = "0x7C0B050", VA = "0x187C0C450")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x7C0D2E0", Offset = "0x7C0BEE0", VA = "0x187C0D2E0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x7C0CF40", Offset = "0x7C0BB40", VA = "0x187C0CF40", Slot = "8")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x7C0D2E0", Offset = "0x7C0BEE0", VA = "0x187C0D2E0", Slot = "9")]
		public void TeardownAvatarDisplaySystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x7C0C4C0", Offset = "0x7C0B0C0", VA = "0x187C0C4C0", Slot = "10")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x7C0D390", Offset = "0x7C0BF90", VA = "0x187C0D390")]
		public void UpdatePostIKAnimControllers(float DJGAODFCDIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x7C0CB40", Offset = "0x7C0B740", VA = "0x187C0CB40")]
		private void FOLICCCALBA(GameObject KDKJDFFGNJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x7C0CBD0", Offset = "0x7C0B7D0", VA = "0x187C0CBD0")]
		private JOAGHKKNMDI GCEKLMBJLMN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x7C0CFA0", Offset = "0x7C0BBA0", VA = "0x187C0CFA0")]
		private DKHBNCECMKL NNCBDGNFPFO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x7C0C8B0", Offset = "0x7C0B4B0", VA = "0x187C0C8B0")]
		private KGCOEBBKGCN EFFGCBEJIKJ(AHDEEIHKKKF CJJOHBMDBIG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x7C0D470", Offset = "0x7C0C070", VA = "0x187C0D470")]
		public AvatarModernBodyDisplayBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class JIJBLAMHAHH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	private MaterialPropertyBlock IBKFHJGGKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	public Color? LBNBBCJLKNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	public Color? NFKOJOJBGCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	public Color? MPBJFDBNPOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	public Color? DMGGGPGCKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	public Color NMLNFLMACLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	public Color EPKOHHFBLBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	public Color LOCMILKKEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	public float BLIHAACAFED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	public Texture2D BAAIBFBBNAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	public Texture2D DFGKMGHHOLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	private Dictionary<MMFKGIKBNFG, int> IFOEKJBBNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private CHMPAKGJEMJ[] BBCBKCDLHEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	private IEENCACOFDN[] CJOIFOJCCNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public Vector4[] GIKBECGEIKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public Vector4[] EJNDBLHMNJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public Vector4[] NCGLNICIHPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public Vector4[] JOPELFFCDFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public Vector4[] MKDMOMBCNJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public Vector4[] MDCLGOBEIEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private List<Texture2D> OJFCPDNJCBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private Vector4[] NNOMBHPOMBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private List<Texture2D> OPAMJKBAMHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	private float[] CDMLHIMLNIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private Vector4[] MHDJPKPHADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private float[] IPGCKFEDHEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public float[] FMCOPHKACPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	private List<Texture2D> LGMNGJJEKGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private float[] IHOIAPIEGJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private List<Texture2D> APCAMJHJPGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private Vector4[] AGHHEDMDEJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private float[] HCPDFAALLLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private Vector4[] JENFCNAJEMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	public float[] FJDHLJFOGMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public Texture2DArray PJFKMPJKOIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	public Texture2DArray JGOFCENJMOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public Texture2DArray GPCEAPFJEJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public Texture2DArray NNBMKDBELGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private bool IBIODGAMEAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private int FLAFJKPDKGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private Vector2? BCOPJOCBIKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	private TextureFormat PNLKLKKMFJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	private Vector2? JCPLPFIBFOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private TextureFormat CEGGACAPELD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	private Vector2? PKPLDDHAICD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	private TextureFormat IDAEACABFOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	private Vector2? PFDDKCPOCBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	private TextureFormat DBGFKMKGNMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private bool OCBGCPNOEJE;

	[Cpp2IlInjected.Token(Token = "0x4000251")]
	private static int EGHEGMJJIHJ;

	[Cpp2IlInjected.Token(Token = "0x4000252")]
	private static int HHPJHBOLBIL;

	[Cpp2IlInjected.Token(Token = "0x4000253")]
	private static int DJEGPBPIOOA;

	[Cpp2IlInjected.Token(Token = "0x4000254")]
	private static int DEKEOODOAGM;

	[Cpp2IlInjected.Token(Token = "0x4000255")]
	private static int GFKIBHCEJPP;

	[Cpp2IlInjected.Token(Token = "0x4000256")]
	private static int PNCJEAPDCOL;

	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private static int KKJJBLDALBN;

	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private static int AFLDJBNCJLO;

	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private static int OPFBCAGPLOB;

	[Cpp2IlInjected.Token(Token = "0x400025A")]
	private static int MOCHAOLAAGG;

	[Cpp2IlInjected.Token(Token = "0x400025B")]
	private static int NLKKDPLIIMH;

	[Cpp2IlInjected.Token(Token = "0x400025C")]
	private static int EHCMOKDEFGD;

	[Cpp2IlInjected.Token(Token = "0x400025D")]
	private static int IKHKJLNNNLB;

	[Cpp2IlInjected.Token(Token = "0x400025E")]
	private static int HPMBNBBFLON;

	[Cpp2IlInjected.Token(Token = "0x400025F")]
	private static int LHOIPNMFFGK;

	[Cpp2IlInjected.Token(Token = "0x4000260")]
	private static int EDOFBKKACDM;

	[Cpp2IlInjected.Token(Token = "0x4000261")]
	private static int EMFDEILPCPK;

	[Cpp2IlInjected.Token(Token = "0x4000262")]
	private static int MDHMAFGGMHL;

	[Cpp2IlInjected.Token(Token = "0x4000263")]
	private static int OFACPOCCKMN;

	[Cpp2IlInjected.Token(Token = "0x4000264")]
	private static int PJAABJOIDNP;

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x7C18430", Offset = "0x7C17030", VA = "0x187C18430")]
	private JIJBLAMHAHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x7C18370", Offset = "0x7C16F70", VA = "0x187C18370")]
	public JIJBLAMHAHH(Color OHKIPPABEGA, Color MFGKLCICHBB, Color CFGHMHCILII, Color? ECGJAPDFIMO, Color? HGKEICNNAHH, Color? IKPGLGBDPJK, Texture2D ONOIJOFDNOA, Texture2D LCJLDHABCHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x7C170F0", Offset = "0x7C15CF0", VA = "0x187C170F0")]
	internal int KBNLKDOPPNL(Material ELKOBNFIOIE, CHMPAKGJEMJ KDHDOJGANHL, IEENCACOFDN AMGKCPMFOHO, HBNDGNKPEKC PMGLBCDCDJE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x7C171C0", Offset = "0x7C15DC0", VA = "0x187C171C0")]
	private int KBNLKDOPPNL(MMFKGIKBNFG MEPFFFGIFGB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x7C17250", Offset = "0x7C15E50", VA = "0x187C17250")]
	internal int OFHLKKADKPC(Material ELKOBNFIOIE, Color DELLAIPLOAD, Color EPECBPKFFMM, Color GGBCNKJOKOF, Color HJMMCCGJFEK, Color DCCHECKDFEA, Texture2D KEJBCDDMNBG, Vector4 HLAFDKNBBDG, Texture2D KELHEBMHKKE, Vector4 PCFJEOIJPIF, float OJHNNGPFEBH, float FFCMNCGCMDI, Texture2D NDCBBBLJFME, Vector4 DLDPIIJCDOC, float MKBGFHOPHEB, Texture2D HDNPGEIMLML, Color OJDELFLFEKM, Vector4 AKPDFJGIAMN, CHMPAKGJEMJ KDHDOJGANHL, IEENCACOFDN AMGKCPMFOHO, HBNDGNKPEKC PMGLBCDCDJE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x7C15D80", Offset = "0x7C14980", VA = "0x187C15D80")]
	private void ADDCFADIDPD(List<Texture2D> OJFCPDNJCBH, [Out] Texture2DArray DDFHIJPJHOM, [Out] Texture2DArray ODMKBFJBKEG, [Out] Texture2DArray HJHOJEKNFAP, [Out] Texture2DArray NLCCIKHIFBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x7C16F60", Offset = "0x7C15B60", VA = "0x187C16F60")]
	public void DHBDJAJKEDP(Shader AABENNHBDDJ, Renderer GJIEBJCNJLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x7C16150", Offset = "0x7C14D50", VA = "0x187C16150")]
	private void BOMFGMDANPA(Shader AABENNHBDDJ, Renderer GJIEBJCNJLG, int EAHLCBGKEFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x7C17E20", Offset = "0x7C16A20", VA = "0x187C17E20")]
	private Color PBHDKBCCEOB(Color PLDBBLPEEJP, CHMPAKGJEMJ EJKOOEFJHNG)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x7C16E10", Offset = "0x7C15A10", VA = "0x187C16E10")]
	private Color CKGLIBALMGM(Color FDNKJIOBPMN, CHMPAKGJEMJ EJKOOEFJHNG)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x7C15F40", Offset = "0x7C14B40", VA = "0x187C15F40")]
	private bool AKDOGJABMOL(Texture2D LCOBCDEANCK, IEENCACOFDN PEMGCOHLNAD, [Out] Texture2D HBHADJDPLKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x7C160A0", Offset = "0x7C14CA0", VA = "0x187C160A0")]
	private void BBKDENJHHKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x7C170B0", Offset = "0x7C15CB0", VA = "0x187C170B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public abstract class HEEODOPGCJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	public readonly HBNDGNKPEKC IGJFEOCOCDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	protected bool JKKGGHADCBN;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public bool AKEHBLDALIG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0xAA8AD0", Offset = "0xAA76D0", VA = "0x180AA8AD0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0xAA8AE0", Offset = "0xAA76E0", VA = "0x180AA8AE0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool KLOOIEJKFDH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0xAA8AC0", Offset = "0xAA76C0", VA = "0x180AA8AC0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xAA8B50", Offset = "0xAA7750", VA = "0x180AA8B50")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public virtual IONAMLJCLBI.EPMFDMLBDCD EDEFCNFKNPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(IONAMLJCLBI.EPMFDMLBDCD);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0xCFB360", Offset = "0xCF9F60", VA = "0x180CFB360", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool HDPGAHAJCDE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x1436790", Offset = "0x1435390", VA = "0x181436790")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public bool MCBKPLHJMEO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x7C144B0", Offset = "0x7C130B0", VA = "0x187C144B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public bool NIAPCELILBC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x7C144A0", Offset = "0x7C130A0", VA = "0x187C144A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public bool NKBJCPFPKMK
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x7C14480", Offset = "0x7C13080", VA = "0x187C14480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x7C144C0", Offset = "0x7C130C0", VA = "0x187C144C0")]
	protected HEEODOPGCJL(HBNDGNKPEKC KABAKPPFEEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract AFMJGMMOLON NKBEGPLDEPI(List<PHBEKKNOPBH> GAICAFGEPAL, List<PHBEKKNOPBH> GDIHGPOIAMD);

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract EMKPFPGHPGK KILGKCKKKOP(uint FEJALILJGHL, AvatarSkinnedMeshBoneOrderRemapsData KOGIGHLMGHL);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class IGAKCLLGNEJ : DPABCNJJAOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	private AvatarSkinAssetItem BCELDIBCIBB;

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x7C15940", Offset = "0x7C14540", VA = "0x187C15940")]
	public IGAKCLLGNEJ(AvatarSkinAssetItem DPKGCJEIJKC, AvatarSkinAssetItem.GAFFNLKCHJN PBOIINNJFOK, HBNDGNKPEKC PMGLBCDCDJE, [Optional] DOLBAFHNJDK? HAHIPFJADAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x7C156E0", Offset = "0x7C142E0", VA = "0x187C156E0", Slot = "6")]
	public override AFMJGMMOLON NKBEGPLDEPI(List<PHBEKKNOPBH> GAICAFGEPAL, List<PHBEKKNOPBH> GDIHGPOIAMD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class LACDEFEEALI
{
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	private static readonly int[] FOMCLPAOLNM;

	[Cpp2IlInjected.Token(Token = "0x400026C")]
	private static readonly int[] IALKHDGKGPD;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public static int[] MGIDEEBMHPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x7C189C0", Offset = "0x7C175C0", VA = "0x187C189C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x7C18A10", Offset = "0x7C17610", VA = "0x187C18A10")]
	public static int[] IOLICELPOPB(bool FEFHJBIBGBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x7C18930", Offset = "0x7C17530", VA = "0x187C18930")]
	public static int AJOFJNDKLHN(OEENMKMDDDK AEFBDEJJPBM, bool FEFHJBIBGBH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x7C18AB0", Offset = "0x7C176B0", VA = "0x187C18AB0")]
	private static int PFOCMJONNJP(OEENMKMDDDK AEFBDEJJPBM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x7C18A90", Offset = "0x7C17690", VA = "0x187C18A90")]
	private static int KNBNEKOPNFP(OEENMKMDDDK AEFBDEJJPBM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class FJLEFKPCKLI
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class JHFHACJGEPJ : IEnumerator<FCPCPCAPDCM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		private FCPCPCAPDCM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		private FCPCPCAPDCM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0xA1FD90", Offset = "0xA1E990", VA = "0x180A1FD90")]
		[DebuggerHidden]
		public JHFHACJGEPJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x13AF560", Offset = "0x13AE160", VA = "0x1813AF560", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x7C15D30", Offset = "0x7C14930", VA = "0x187C15D30", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80")]
	public static void HDMIJAMKMOC(string ALPNKEJICNA, int FEJALILJGHL, long IPFJHGLKMKN, long EOIKLACHICA, long CMFAIPLDHEI, long LPGGKKCHPHO, long DGDLBBAMDNL, long ECNOBJKEEMK, long NLOHHPGCFMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x7C13B00", Offset = "0x7C12700", VA = "0x187C13B00")]
	public static GCBFJNEKOIO AAMCEKBLOME(JobHandle HINMIIHKGID, bool MNDKPABIBOK, bool GIOBNMAKIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7C13BF0", Offset = "0x7C127F0", VA = "0x187C13BF0")]
	[IteratorStateMachine(typeof(JHFHACJGEPJ))]
	private static IEnumerator<FCPCPCAPDCM> JNOAGHCJMAN(JobHandle BEPAMKMBKNC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class IDKKLKOLIAJ
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public enum NKCBNHAHEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		General,
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		ColoredHair
	}

	[Cpp2IlInjected.Token(Token = "0x4000270")]
	public static readonly int OJGHAJLIFED;

	[Cpp2IlInjected.Token(Token = "0x4000271")]
	public static readonly int KEALCNDKHCP;

	[Cpp2IlInjected.Token(Token = "0x4000272")]
	public static readonly int KHLPHNKNGNJ;

	[Cpp2IlInjected.Token(Token = "0x4000273")]
	public static readonly int OAEEPKIGHOG;

	[Cpp2IlInjected.Token(Token = "0x4000274")]
	public static readonly int KHNCKDJIOHM;

	[Cpp2IlInjected.Token(Token = "0x4000275")]
	public static readonly int BOLKBJOJMNC;

	[Cpp2IlInjected.Token(Token = "0x4000276")]
	public static readonly int DNNJLGJFGBP;

	[Cpp2IlInjected.Token(Token = "0x4000277")]
	public static readonly int LMEKAJJEGOJ;

	[Cpp2IlInjected.Token(Token = "0x4000278")]
	public static readonly int ONLLBJOANBL;

	[Cpp2IlInjected.Token(Token = "0x4000279")]
	public static readonly int ILKACBMJDLH;

	[Cpp2IlInjected.Token(Token = "0x400027A")]
	public static readonly int ENENFJKOOJE;

	[Cpp2IlInjected.Token(Token = "0x400027B")]
	public static readonly int CPFDJNPOLCI;

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x7C15460", Offset = "0x7C14060", VA = "0x187C15460")]
	public static bool JJOPEENLIEG(Material IMKAMKEPJBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x7C153A0", Offset = "0x7C13FA0", VA = "0x187C153A0")]
	public static bool FPBFKCDNNDN(Material IMKAMKEPJBL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class DPABCNJJAOM : HEEODOPGCJL
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class FKOAODLLDFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public PHKGFEHMLBA<GameObject> skinAvatarItemPrefabHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public DPABCNJJAOM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public Action<string> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public FKOAODLLDFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x7C13DA0", Offset = "0x7C129A0", VA = "0x187C13DA0")]
		internal void IMKCLCIICAL(GameObject result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x7C13C60", Offset = "0x7C12860", VA = "0x187C13C60")]
		internal void HJJDDFCNBHN(string error)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	protected AvatarSkinAssetItem CLMPDFKLGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	protected Material[] OPBKDHOMBAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	private readonly AvatarSkinAssetItem.GAFFNLKCHJN MGNLLFOKCCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	private readonly AssetReference KLJCODCCIJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	private readonly DOLBAFHNJDK? PEJBOGEOKHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	private SkinnedMeshRenderer[] PANEDIMDAKK;

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public override IONAMLJCLBI.EPMFDMLBDCD EDEFCNFKNPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0xA246B0", Offset = "0xA232B0", VA = "0x180A246B0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(IONAMLJCLBI.EPMFDMLBDCD);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0xA24640", Offset = "0xA23240", VA = "0x180A24640", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x7C11090", Offset = "0x7C0FC90", VA = "0x187C11090")]
	public DPABCNJJAOM(AvatarSkinAssetItem.GAFFNLKCHJN PBOIINNJFOK, AssetReference ILMILFKJPCG, Material LJJAIBJEDCE, HBNDGNKPEKC PMGLBCDCDJE, IONAMLJCLBI.EPMFDMLBDCD MEBAOADOHDK = (IONAMLJCLBI.EPMFDMLBDCD)0L, [Optional] DOLBAFHNJDK? HAHIPFJADAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x7C10F70", Offset = "0x7C0FB70", VA = "0x187C10F70")]
	public DPABCNJJAOM(AvatarSkinAssetItem.GAFFNLKCHJN PBOIINNJFOK, AssetReference ILMILFKJPCG, Material LJJAIBJEDCE, IONAMLJCLBI.EPMFDMLBDCD MEBAOADOHDK = (IONAMLJCLBI.EPMFDMLBDCD)0L, [Optional] DOLBAFHNJDK? HAHIPFJADAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x7C10CE0", Offset = "0x7C0F8E0", VA = "0x187C10CE0", Slot = "6")]
	public override AFMJGMMOLON NKBEGPLDEPI(List<PHBEKKNOPBH> GAICAFGEPAL, List<PHBEKKNOPBH> GDIHGPOIAMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x7C10AD0", Offset = "0x7C0F6D0", VA = "0x187C10AD0", Slot = "7")]
	public override EMKPFPGHPGK KILGKCKKKOP(uint FEJALILJGHL, AvatarSkinnedMeshBoneOrderRemapsData KOGIGHLMGHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x7C10F00", Offset = "0x7C0FB00", VA = "0x187C10F00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x7C10A80", Offset = "0x7C0F680", VA = "0x187C10A80")]
	protected void COAEODKKIDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class NHGEJMHFGFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	private List<int> JHANFCMIKKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	private List<ECAKAPBNLFC> HGLIGDEGKGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	private HashSet<Transform> NJAIEBHPECO;

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x7C1B500", Offset = "0x7C1A100", VA = "0x187C1B500")]
	public static NHGEJMHFGFB FKCIFOJMDFP(Transform LPCHKKFEGJO, Dictionary<Transform, OutfitType?> FEPLHDBOJJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x7C1B1E0", Offset = "0x7C19DE0", VA = "0x187C1B1E0")]
	private void DEPBDBFICCM(Transform LPCHKKFEGJO, HBNDGNKPEKC PMGLBCDCDJE, Dictionary<Transform, OutfitType?> FEPLHDBOJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x7C1BA80", Offset = "0x7C1A680", VA = "0x187C1BA80")]
	private void HOHMHIFLGGB(Transform OKEPFFAIAAN, HBNDGNKPEKC PMGLBCDCDJE, bool CIBLCAJLEDH, OutfitType? HAJIOJJELDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x7C1B690", Offset = "0x7C1A290", VA = "0x187C1B690")]
	public DGOLMMLPMGG HLFINEDJDAI(HashSet<string> ALHCMFKEKKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x7C1BC10", Offset = "0x7C1A810", VA = "0x187C1BC10")]
	public NHGEJMHFGFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class DGOLMMLPMGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	private List<ECAKAPBNLFC> HGLIGDEGKGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	private List<Matrix4x4> GPFECMCJKNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	private Transform[] BJDEOHLNJKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	private Matrix4x4[] MIDGCCHACLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	private Dictionary<NKOKOALFGMA, int> JFFGGJNLDHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	private List<JGPOLGMKHCE> EDLCEKAAMDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	private bool FACOGMHJILI;

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public int OJAJOFHLGMI
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x7C10720", Offset = "0x7C0F320", VA = "0x187C10720")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public Transform[] IHPGJEMEJEB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x7C105C0", Offset = "0x7C0F1C0", VA = "0x187C105C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public Matrix4x4[] PIPEPKEBPIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x7C0FCC0", Offset = "0x7C0E8C0", VA = "0x187C0FCC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x7C10060", Offset = "0x7C0EC60", VA = "0x187C10060")]
	public void HOHMHIFLGGB(Transform OKEPFFAIAAN, HBNDGNKPEKC PMGLBCDCDJE, OutfitType? HAJIOJJELDP, bool CFCFLFPGLPK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x7C10250", Offset = "0x7C0EE50", VA = "0x187C10250")]
	private void HOHMHIFLGGB(Transform OKEPFFAIAAN, HBNDGNKPEKC PMGLBCDCDJE, OutfitType? HAJIOJJELDP, bool CFCFLFPGLPK, Matrix4x4 HFLBAFDGHIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x7C10760", Offset = "0x7C0F360", VA = "0x187C10760")]
	public int LLCJFHFIHDN(NKOKOALFGMA MEPFFFGIFGB, bool FFGENPCNHPP, [Optional] OutfitType? HAJIOJJELDP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x7C0FE70", Offset = "0x7C0EA70", VA = "0x187C0FE70")]
	public int HGBBKJCIIJB(HBNDGNKPEKC PMGLBCDCDJE, [Optional] OutfitType? HAJIOJJELDP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x7C0FF70", Offset = "0x7C0EB70", VA = "0x187C0FF70")]
	public void HJGOIPOEFEO(NKOKOALFGMA MEPFFFGIFGB, Matrix4x4 FKOOEJIGGEB, bool FFGENPCNHPP = false, [Optional] OutfitType? HAJIOJJELDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x7C0FD30", Offset = "0x7C0E930", VA = "0x187C0FD30")]
	public Matrix4x4 GFKIMGNOAMA(NKOKOALFGMA MEPFFFGIFGB, bool FFGENPCNHPP, [Optional] OutfitType? HAJIOJJELDP)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x148D130", Offset = "0x148BD30", VA = "0x18148D130")]
	public void EOAEBIHNIIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x7C10910", Offset = "0x7C0F510", VA = "0x187C10910")]
	public DGOLMMLPMGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct NKOKOALFGMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public readonly string KFJCKFHGCEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public readonly HBNDGNKPEKC GHADCCEDMPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public readonly OutfitType? NHHENGPFMPI;

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x7C1BFC0", Offset = "0x7C1ABC0", VA = "0x187C1BFC0")]
	public NKOKOALFGMA(string NHALHFDGPIO, HBNDGNKPEKC PMGLBCDCDJE, [Optional] OutfitType? HAJIOJJELDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x7C1BF10", Offset = "0x7C1AB10", VA = "0x187C1BF10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x7C1BD40", Offset = "0x7C1A940", VA = "0x187C1BD40")]
	public bool BFCLAADBIMC(NKOKOALFGMA GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x7C1BE00", Offset = "0x7C1AA00", VA = "0x187C1BE00", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x7C1BEA0", Offset = "0x7C1AAA0", VA = "0x187C1BEA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct JGPOLGMKHCE : IEquatable<JGPOLGMKHCE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public readonly HBNDGNKPEKC GHADCCEDMPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public readonly OutfitType? BDJCCFAKNEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public readonly int MNONDOJCPOH;

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x7C15D20", Offset = "0x7C14920", VA = "0x187C15D20")]
	public JGPOLGMKHCE(HBNDGNKPEKC PMGLBCDCDJE, int KHNOGFGPGFN, [Optional] OutfitType? FAEJEMGEACH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x7C15C50", Offset = "0x7C14850", VA = "0x187C15C50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x6E31FF0", Offset = "0x6E30BF0", VA = "0x186E31FF0")]
	public bool LHILOCHGEPH(HBNDGNKPEKC PMGLBCDCDJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x7C15A40", Offset = "0x7C14640", VA = "0x187C15A40")]
	public bool BLKLDPDFHIM(OutfitType? FAEJEMGEACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x7C15AC0", Offset = "0x7C146C0", VA = "0x187C15AC0", Slot = "4")]
	public bool Equals(JGPOLGMKHCE GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x7C15B10", Offset = "0x7C14710", VA = "0x187C15B10", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x7C15C00", Offset = "0x7C14800", VA = "0x187C15C00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public struct ECAKAPBNLFC : IEquatable<ECAKAPBNLFC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public readonly Transform PKAOJEJKDPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public readonly bool IJCICAOBFEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public readonly HBNDGNKPEKC MPKOLACAPCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public readonly OutfitType? NHHENGPFMPI;

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x7C125B0", Offset = "0x7C111B0", VA = "0x187C125B0")]
	public ECAKAPBNLFC(Transform OKEPFFAIAAN, bool CIBLCAJLEDH, HBNDGNKPEKC DAKJBFJLFHJ, [Optional] OutfitType? IFHKNMNHJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x7C123A0", Offset = "0x7C10FA0", VA = "0x187C123A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x7C12220", Offset = "0x7C10E20", VA = "0x187C12220", Slot = "4")]
	public bool Equals(ECAKAPBNLFC GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x7C12140", Offset = "0x7C10D40", VA = "0x187C12140", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x7C12320", Offset = "0x7C10F20", VA = "0x187C12320", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[ExecuteInEditMode]
	public class FitMeshHemisphereUpdater : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public const float DEFAULT_Y_POSITION_OFFSET = 0.04f;

		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public const float MAX_HEMISPHERE_POSITION_OFFSET = 0.05f;

		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public const float MAX_HEMISPHERE_ROTATION_OFFSET = 45f;

		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public const float MAX_HEMISPHERE_SCALE = 2f;

		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public const float MIN_HEMISPHERE_SCALE = 0.75f;

		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public const float MAX_HEMISPHERE_RADIUS = 0.25f;

		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public const float MIN_HEMISPHERE_RADIUS = 0.125f;

		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public static GameObject ContainerGO;

		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public static GameObject CurrentHairHemisphereGO;

		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public static Transform CurrentHairHemisphereMeshTransform;

		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public static FitMeshHemisphereUpdater CurrentHairHemisphereUpdater;

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x7C14170", Offset = "0x7C12D70", VA = "0x187C14170")]
		public static void DespawnHairHemisphere()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80")]
		public void UpdateValues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE70", Offset = "0xA1CA70", VA = "0x180A1DE70")]
		public FitMeshHemisphereUpdater()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface JJHOBFIADIB
{
	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IPFAKHLFCOE(Mesh BFDKALDCPEN, Matrix4x4 DPPPNPACNJH, byte[] OBDIEKPNNPB, bool IKIEJAHIOPM = false, IONAMLJCLBI.EPMFDMLBDCD MFNNIEGNODK = (IONAMLJCLBI.EPMFDMLBDCD)0L, int KDIBBKDBADJ = -1, bool BGDOAPOABHM = false);

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IPGLPJDGHFG(Allocator CMJGNOOCEGA, OAKJHNENFNC OBHHKIOIHLB, byte EOMAKFBPFJB, [Optional] IList<int> LKHKBJHNPOO, [Optional] IList<int> JPIHBOHEBGL);
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public readonly struct PCNGHJMBNDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public readonly GameObject KHKNEOJDCIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	private readonly AvatarItemMaterial HOGPHLPECFK;

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0xB5F450", Offset = "0xB5E050", VA = "0x180B5F450")]
	public PCNGHJMBNDJ(GameObject KHKNEOJDCIG, AvatarItemMaterial HOGPHLPECFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x7C1C4E0", Offset = "0x7C1B0E0", VA = "0x187C1C4E0")]
	public void EONHPDPLCMA(Material IMKAMKEPJBL, int BNDMLLLLIFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class MNOMDHFBKAF : NPMGHAEOMBC<Task<(GameObject, AvatarItemMaterial)>, PCNGHJMBNDJ>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct MEEKHIHJJHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public AsyncTaskMethodBuilder<(GameObject, AvatarItemMaterial)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public Task<GameObject> goTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public Task<AvatarItemMaterial> materialTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private GameObject <go>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private TaskAwaiter<GameObject> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private TaskAwaiter<AvatarItemMaterial> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x7C19120", Offset = "0x7C17D20", VA = "0x187C19120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x7C19620", Offset = "0x7C18220", VA = "0x187C19620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	private PHKGFEHMLBA<GameObject> EONCOJBMNCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	private PHKGFEHMLBA<AvatarItemMaterial> HPDFOFLAIJF;

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x7C1B150", Offset = "0x7C19D50", VA = "0x187C1B150")]
	private MNOMDHFBKAF(Task<(GameObject, AvatarItemMaterial)> NKDMFOKACBI, PHKGFEHMLBA<GameObject> DOGJFOAFLIL, PHKGFEHMLBA<AvatarItemMaterial> AAFMOCMGBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x7C1AAF0", Offset = "0x7C196F0", VA = "0x187C1AAF0")]
	public static MNOMDHFBKAF GLOMJONEBBE(AssetReference GFEBGLHIAIJ, [Optional] AssetReference OFLGABCNLLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x7C1AF00", Offset = "0x7C19B00", VA = "0x187C1AF00", Slot = "11")]
	protected override PCNGHJMBNDJ ILJIACAMOOL(Task<(GameObject, AvatarItemMaterial)> LPMOOKPIFIM)
	{
		return default(PCNGHJMBNDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x7C1AFA0", Offset = "0x7C19BA0", VA = "0x187C1AFA0", Slot = "12")]
	protected override void NKHLLJLLELB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x7C1B020", Offset = "0x7C19C20", VA = "0x187C1B020")]
	[AsyncStateMachine(typeof(MEEKHIHJJHB))]
	private static Task<(GameObject, AvatarItemMaterial)> PCAICLLFDFP(Task<GameObject> MOEKCHKBKAF, Task<AvatarItemMaterial> CHJOFBAECDO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class NLCBBIFHLHM
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class LNGHPDMGEEO : NPMGHAEOMBC<Task<MaterialMapAsset>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		private PHKGFEHMLBA<MaterialMapAsset> BEPAMKMBKNC;

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x7C19040", Offset = "0x7C17C40", VA = "0x187C19040")]
		public LNGHPDMGEEO(PHKGFEHMLBA<MaterialMapAsset> BEPAMKMBKNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x7C18BC0", Offset = "0x7C177C0", VA = "0x187C18BC0", Slot = "11")]
		protected override Material[] ILJIACAMOOL(Task<MaterialMapAsset> NKDMFOKACBI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x7C18FE0", Offset = "0x7C17BE0", VA = "0x187C18FE0", Slot = "12")]
		protected override void NKHLLJLLELB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class GDKFIFBKEJA : NPMGHAEOMBC<Task<Material[]>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		private List<PHKGFEHMLBA<Material>> EJOMAHOPPJE;

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x7C14410", Offset = "0x7C13010", VA = "0x187C14410")]
		public GDKFIFBKEJA(Task<Material[]> NKDMFOKACBI, List<PHKGFEHMLBA<Material>> EJOMAHOPPJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x7C14280", Offset = "0x7C12E80", VA = "0x187C14280", Slot = "11")]
		protected override Material[] ILJIACAMOOL(Task<Material[]> LPMOOKPIFIM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x7C142D0", Offset = "0x7C12ED0", VA = "0x187C142D0", Slot = "12")]
		protected override void NKHLLJLLELB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	private static readonly JPIBGNDAFKP FAOMHPPHFKM;

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x7C1C000", Offset = "0x7C1AC00", VA = "0x187C1C000")]
	public static PHKGFEHMLBA<Material[]> IIJJCIIPBKI(AssetReference[] ELIDCBCGOEB)
	{
		return null;
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[DisallowMultipleComponent]
	public class PlayerAvatarDisplayBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public enum LEHNFDDPOEE
		{
			[Cpp2IlInjected.Token(Token = "0x400034B")]
			None,
			[Cpp2IlInjected.Token(Token = "0x400034C")]
			TeamItem,
			[Cpp2IlInjected.Token(Token = "0x400034D")]
			SkinColor,
			[Cpp2IlInjected.Token(Token = "0x400034E")]
			HairColor,
			[Cpp2IlInjected.Token(Token = "0x400034F")]
			BeardColor,
			[Cpp2IlInjected.Token(Token = "0x4000350")]
			UGCShirtColor
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public enum OCMMCABFCJD
		{
			[Cpp2IlInjected.Token(Token = "0x4000352")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000353")]
			HairTexture,
			[Cpp2IlInjected.Token(Token = "0x4000354")]
			BeardTexture,
			[Cpp2IlInjected.Token(Token = "0x4000355")]
			UGCShirtTexture
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		public enum IACPADJPHGP : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000357")]
			All,
			[Cpp2IlInjected.Token(Token = "0x4000358")]
			LOD0Only,
			[Cpp2IlInjected.Token(Token = "0x4000359")]
			EditorToolAll
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		public struct OBPHMPFCLKB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400035A")]
			public readonly Material NCKFIMBLHAO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400035B")]
			public readonly LEHNFDDPOEE FNPPGJJPCNB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400035C")]
			public readonly OCMMCABFCJD KHBOMCEAEAO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400035D")]
			public readonly HBNDGNKPEKC GHADCCEDMPJ;

			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x7C335B0", Offset = "0x7C321B0", VA = "0x187C335B0")]
			public OBPHMPFCLKB(Material IMKAMKEPJBL, LEHNFDDPOEE KDHDOJGANHL, OCMMCABFCJD AMGKCPMFOHO, HBNDGNKPEKC PMGLBCDCDJE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x7C33390", Offset = "0x7C31F90", VA = "0x187C33390", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x7C33190", Offset = "0x7C31D90", VA = "0x187C33190")]
			public bool BFCLAADBIMC(OBPHMPFCLKB GMNGNCHKEBK)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x7C33210", Offset = "0x7C31E10", VA = "0x187C33210", Slot = "0")]
			public override bool Equals(object KDKJDFFGNJJ)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x7C332F0", Offset = "0x7C31EF0", VA = "0x187C332F0", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		protected class LKNIGGBJNGJ : IComparable<LKNIGGBJNGJ>, IEquatable<LKNIGGBJNGJ>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400035E")]
			public int MGFFMKNNCCG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400035F")]
			public PlayerAvatarDisplayBase NEEGIDJCGEP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000360")]
			public IList<HJFHBFBJOPE> AOKMJAGEJGI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000361")]
			public AvatarItemBodyType AHHONGPMGAE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000362")]
			public FPAJOPAEPNO KBKMDNFHJBK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000363")]
			public bool LODPAPILAKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
			[Cpp2IlInjected.Token(Token = "0x4000364")]
			public bool ALAAFFDEJKG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000365")]
			public int[] AOMGOCOHHKN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000366")]
			public float FGIMOFHDCCK;

			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x7C32AE0", Offset = "0x7C316E0", VA = "0x187C32AE0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0x7C32990", Offset = "0x7C31590", VA = "0x187C32990", Slot = "4")]
			public int CompareTo(LKNIGGBJNGJ GMNGNCHKEBK)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0x7C329C0", Offset = "0x7C315C0", VA = "0x187C329C0", Slot = "5")]
			public bool Equals(LKNIGGBJNGJ GMNGNCHKEBK)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
			public LKNIGGBJNGJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		protected abstract class CKOEEDBHFPN
		{
			[Cpp2IlInjected.Token(Token = "0x200005C")]
			public class ADNDINAKBAA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400036A")]
				public readonly Mesh MAPHLJEMNGI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400036B")]
				public readonly Material[] GPIOFJCAEDE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400036C")]
				public readonly Transform[] CAKHFNMIIKB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400036D")]
				public readonly Matrix4x4[] MAEPACMACGB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400036E")]
				public readonly Transform HACAPKILAEM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400036F")]
				public readonly bool ACONLFMOBGK;

				[Cpp2IlInjected.Token(Token = "0x6000307")]
				[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
				protected ADNDINAKBAA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000308")]
				[Cpp2IlInjected.Address(RVA = "0x7C2BBE0", Offset = "0x7C2A7E0", VA = "0x187C2BBE0")]
				public ADNDINAKBAA(Mesh BFDKALDCPEN, Material[] FEHHJFLFMGL, bool EKPCKHKEDDD, Transform[] AJDCHCNBIKJ, Transform OGKDDDLPNAA, Matrix4x4[] CKBIEINEHBP)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000309")]
				[Cpp2IlInjected.Address(RVA = "0x7C2C090", Offset = "0x7C2AC90", VA = "0x187C2C090")]
				private ADNDINAKBAA(SkinnedMeshRenderer APIEKGDHKJG, Material[] INOMMMLPMED)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600030A")]
				[Cpp2IlInjected.Address(RVA = "0x7C2C150", Offset = "0x7C2AD50", VA = "0x187C2C150")]
				private ADNDINAKBAA(MeshRenderer LEGKKAFFGOL, Transform OGKDDDLPNAA, Material[] INOMMMLPMED)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600030B")]
				[Cpp2IlInjected.Address(RVA = "0x7C2B8C0", Offset = "0x7C2A4C0", VA = "0x187C2B8C0")]
				public static ADNDINAKBAA ODHDDCCGBOG(Renderer GJIEBJCNJLG, Material[] INOMMMLPMED)
				{
					return null;
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000367")]
			public readonly HBNDGNKPEKC GHADCCEDMPJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000368")]
			public readonly Transform JBDGPCOJGIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000369")]
			public readonly bool DACOHCFMHPM;

			[Cpp2IlInjected.Token(Token = "0x1700008F")]
			public virtual bool AKEHBLDALIG
			{
				[Cpp2IlInjected.Token(Token = "0x6000300")]
				[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000090")]
			public virtual bool KLOOIEJKFDH
			{
				[Cpp2IlInjected.Token(Token = "0x6000301")]
				[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000091")]
			public virtual IONAMLJCLBI.EPMFDMLBDCD EDEFCNFKNPE
			{
				[Cpp2IlInjected.Token(Token = "0x6000302")]
				[Cpp2IlInjected.Address(RVA = "0xA1DE90", Offset = "0xA1CA90", VA = "0x180A1DE90", Slot = "6")]
				get
				{
					return default(IONAMLJCLBI.EPMFDMLBDCD);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000092")]
			public bool PNPJDOPCFEC
			{
				[Cpp2IlInjected.Token(Token = "0x6000303")]
				[Cpp2IlInjected.Address(RVA = "0x7C2F3F0", Offset = "0x7C2DFF0", VA = "0x187C2F3F0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x7C2F400", Offset = "0x7C2E000", VA = "0x187C2F400")]
			protected CKOEEDBHFPN(HBNDGNKPEKC PMGLBCDCDJE, Transform IOHLICFGIMF, bool BIGMKOIKCKB = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract AFMJGMMOLON NKBEGPLDEPI(List<PHBEKKNOPBH> GAICAFGEPAL, List<PHBEKKNOPBH> GDIHGPOIAMD);

			[Cpp2IlInjected.Token(Token = "0x6000306")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract ADNDINAKBAA KILGKCKKKOP(int FEJALILJGHL, PlayerHandBones PHLOFMCJGKG);
		}

		[Cpp2IlInjected.Token(Token = "0x200005D")]
		protected class BPFIAECJEHL : CKOEEDBHFPN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000370")]
			protected readonly BodyPartLODs PANEDIMDAKK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000371")]
			protected readonly Material[] OPBKDHOMBAF;

			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0x7C2F2F0", Offset = "0x7C2DEF0", VA = "0x187C2F2F0")]
			public BPFIAECJEHL(HBNDGNKPEKC PMGLBCDCDJE, BodyPartLODs NBBBPOFEALO, Material LJJAIBJEDCE, [Optional] Transform IOHLICFGIMF, bool BIGMKOIKCKB = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x7C2F1F0", Offset = "0x7C2DDF0", VA = "0x187C2F1F0", Slot = "7")]
			public override AFMJGMMOLON NKBEGPLDEPI(List<PHBEKKNOPBH> GAICAFGEPAL, List<PHBEKKNOPBH> GDIHGPOIAMD)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x7C2F030", Offset = "0x7C2DC30", VA = "0x187C2F030", Slot = "8")]
			public override ADNDINAKBAA KILGKCKKKOP(int FEJALILJGHL, PlayerHandBones PHLOFMCJGKG)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x7C2F280", Offset = "0x7C2DE80", VA = "0x187C2F280", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005E")]
		protected class AOFEALLEFNJ : CKOEEDBHFPN
		{
			[Cpp2IlInjected.Token(Token = "0x17000093")]
			public override bool AKEHBLDALIG
			{
				[Cpp2IlInjected.Token(Token = "0x6000310")]
				[Cpp2IlInjected.Address(RVA = "0xA38390", Offset = "0xA36F90", VA = "0x180A38390", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000094")]
			public override bool KLOOIEJKFDH
			{
				[Cpp2IlInjected.Token(Token = "0x6000311")]
				[Cpp2IlInjected.Address(RVA = "0x7C2C240", Offset = "0x7C2AE40", VA = "0x187C2C240", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000095")]
			public FGFHPLNOLGF BHCEJCNKPMI
			{
				[Cpp2IlInjected.Token(Token = "0x6000312")]
				[Cpp2IlInjected.Address(RVA = "0xA246B0", Offset = "0xA232B0", VA = "0x180A246B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000313")]
				[Cpp2IlInjected.Address(RVA = "0xA27D40", Offset = "0xA26940", VA = "0x180A27D40")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x7C2C390", Offset = "0x7C2AF90", VA = "0x187C2C390")]
			public AOFEALLEFNJ(HBNDGNKPEKC PMGLBCDCDJE, Transform IOHLICFGIMF, FGFHPLNOLGF BLPDIDCADLB, bool BIGMKOIKCKB = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x7C2C290", Offset = "0x7C2AE90", VA = "0x187C2C290", Slot = "7")]
			public override AFMJGMMOLON NKBEGPLDEPI(List<PHBEKKNOPBH> GAICAFGEPAL, List<PHBEKKNOPBH> GDIHGPOIAMD)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0xA1DE90", Offset = "0xA1CA90", VA = "0x180A1DE90", Slot = "8")]
			public override ADNDINAKBAA KILGKCKKKOP(int FEJALILJGHL, PlayerHandBones PHLOFMCJGKG)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x7C2C320", Offset = "0x7C2AF20", VA = "0x187C2C320", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		public class ICEFPDCEIHE
		{
			[Cpp2IlInjected.Token(Token = "0x2000060")]
			public enum HFINOIMDHOP
			{
				[Cpp2IlInjected.Token(Token = "0x4000383")]
				PLAYER_PUPPET,
				[Cpp2IlInjected.Token(Token = "0x4000384")]
				PLAYER_DISPLAY_POSER,
				[Cpp2IlInjected.Token(Token = "0x4000385")]
				PLAYER_HAND,
				[Cpp2IlInjected.Token(Token = "0x4000386")]
				STNMONSTERCOSTUME_OPTION_HIDE_EXCEPT_UI,
				[Cpp2IlInjected.Token(Token = "0x4000387")]
				PLAYER_HAND_POINTING,
				[Cpp2IlInjected.Token(Token = "0x4000388")]
				STNMONSTERCOSTUME_OPTION_ALWAYS_HIDE,
				[Cpp2IlInjected.Token(Token = "0x4000389")]
				EDITOR
			}

			[Cpp2IlInjected.Token(Token = "0x4000373")]
			public static readonly int FDDPBIEBIAB;

			[Cpp2IlInjected.Token(Token = "0x4000374")]
			public static readonly int GAKMNPADFMC;

			[Cpp2IlInjected.Token(Token = "0x4000375")]
			public static readonly int BLMBPIGKGDA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000376")]
			protected readonly AHDEEIHKKKF CJJOHBMDBIG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000377")]
			protected readonly IFDHKIAMFBD PALAGAPDPGH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000378")]
			protected readonly Animator DDILOAJJFEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000379")]
			protected readonly Transform EDHCMOJGJKC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400037A")]
			public Vector3 EIANFJEJHIJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400037B")]
			protected readonly Transform JNCMOCCBPKB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400037C")]
			public Vector3 IJNFNMMOONI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x400037D")]
			protected bool JEILFPKDLGK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400037E")]
			protected KGCOEBBKGCN MHDEBEDGCNL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400037F")]
			protected bool GEEACKEPLGL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x4000380")]
			protected float KKDJFGNNMLK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000381")]
			protected IJAJCKGOONC<CNIBPJLPBFA> CDBMJMGMCBG;

			[Cpp2IlInjected.Token(Token = "0x17000096")]
			public KGCOEBBKGCN BCEBDCACAAK
			{
				[Cpp2IlInjected.Token(Token = "0x6000318")]
				[Cpp2IlInjected.Address(RVA = "0xA1C6E0", Offset = "0xA1B2E0", VA = "0x180A1C6E0")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000319")]
				[Cpp2IlInjected.Address(RVA = "0xA1C6F0", Offset = "0xA1B2F0", VA = "0x180A1C6F0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000097")]
			public bool KENCKGNPALF
			{
				[Cpp2IlInjected.Token(Token = "0x600031A")]
				[Cpp2IlInjected.Address(RVA = "0xCADB40", Offset = "0xCAC740", VA = "0x180CADB40")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600031B")]
				[Cpp2IlInjected.Address(RVA = "0x7C30D90", Offset = "0x7C2F990", VA = "0x187C30D90")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000098")]
			public bool JCMAFCFBHIK
			{
				[Cpp2IlInjected.Token(Token = "0x600031C")]
				[Cpp2IlInjected.Address(RVA = "0xA24790", Offset = "0xA23390", VA = "0x180A24790")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600031D")]
				[Cpp2IlInjected.Address(RVA = "0x7C31100", Offset = "0x7C2FD00", VA = "0x187C31100")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000099")]
			public float ALBILDMIJFM
			{
				[Cpp2IlInjected.Token(Token = "0x600031E")]
				[Cpp2IlInjected.Address(RVA = "0xD26CA0", Offset = "0xD258A0", VA = "0x180D26CA0")]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x600031F")]
				[Cpp2IlInjected.Address(RVA = "0x7C30E60", Offset = "0x7C2FA60", VA = "0x187C30E60")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009A")]
			public CNIBPJLPBFA ABBJDPLEHHJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000320")]
				[Cpp2IlInjected.Address(RVA = "0x7C30900", Offset = "0x7C2F500", VA = "0x187C30900")]
				get
				{
					return default(CNIBPJLPBFA);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x7C30FF0", Offset = "0x7C2FBF0", VA = "0x187C30FF0")]
			public bool NLCNHEBLLIB(CNIBPJLPBFA CHGIDPEBBPD, object HEDGIMBCGHA, HFINOIMDHOP NBHPMDIDLEB)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x7C313E0", Offset = "0x7C2FFE0", VA = "0x187C313E0")]
			public bool PJAJHOHKLAC(object HEDGIMBCGHA)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x7C31580", Offset = "0x7C30180", VA = "0x187C31580")]
			protected ICEFPDCEIHE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x7C31610", Offset = "0x7C30210", VA = "0x187C31610")]
			public ICEFPDCEIHE(AHDEEIHKKKF CJJOHBMDBIG, KGCOEBBKGCN OBAOKJKNFDN, Animator DDILOAJJFEN, Transform EDHCMOJGJKC, Transform JNCMOCCBPKB, Vector3 EIANFJEJHIJ, Vector3 IJNFNMMOONI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x7C30940", Offset = "0x7C2F540", VA = "0x187C30940")]
			private void APPHJKKOAKN(ushort MCABMABBJLF, ushort MGBFEJAMBDB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x7C311D0", Offset = "0x7C2FDD0", VA = "0x187C311D0")]
			protected void PGDGDOKOLOE(ushort MCABMABBJLF, ushort MGBFEJAMBDB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x7C30AA0", Offset = "0x7C2F6A0", VA = "0x187C30AA0")]
			protected void GBCCJIINBPD(ushort MCABMABBJLF, ushort MGBFEJAMBDB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x7C312C0", Offset = "0x7C2FEC0", VA = "0x187C312C0")]
			protected void PHFHGNAEAOD(ushort MCABMABBJLF, ushort MGBFEJAMBDB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x7C30C80", Offset = "0x7C2F880", VA = "0x187C30C80")]
			protected void IFBENILDPJF(ushort MCABMABBJLF, ushort MGBFEJAMBDB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x7C309F0", Offset = "0x7C2F5F0", VA = "0x187C309F0")]
			protected void CMMKGBAKKMN(ushort MCABMABBJLF, ushort MGBFEJAMBDB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x7C30A50", Offset = "0x7C2F650", VA = "0x187C30A50")]
			protected void EKMOCONKBLC(ushort MCABMABBJLF, ushort MGBFEJAMBDB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x7C30FA0", Offset = "0x7C2FBA0", VA = "0x187C30FA0")]
			protected void NIPCOMMGPJE(ushort MCABMABBJLF, ushort MGBFEJAMBDB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x7C30B60", Offset = "0x7C2F760", VA = "0x187C30B60")]
			protected void GJHFDBAJCEM(ushort MCABMABBJLF, ushort MGBFEJAMBDB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000061")]
		public class BLCAJLBEBDC : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x400038A")]
			public const int AKKDFPJICMO = 16;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400038B")]
			protected MaterialPropertyBlock IBKFHJGGKPM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400038C")]
			public Color? LBNBBCJLKNK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400038D")]
			public Color? MPBJFDBNPOI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400038E")]
			public Color? DMGGGPGCKFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			public Color NMLNFLMACLD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x4000390")]
			public Color EPKOHHFBLBF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x4000391")]
			public Color LOCMILKKEPI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000392")]
			public Texture2D BAAIBFBBNAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000393")]
			public Texture2D DFGKMGHHOLC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x4000394")]
			protected Dictionary<OBPHMPFCLKB, int> IFOEKJBBNAH;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x4000395")]
			protected LEHNFDDPOEE[] BBCBKCDLHEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x4000396")]
			public Vector4[] GIKBECGEIKI;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x4000397")]
			public Vector4[] EJNDBLHMNJA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x4000398")]
			public Vector4[] NCGLNICIHPN;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000399")]
			public Vector4[] JOPELFFCDFN;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x400039A")]
			public Vector4[] MKDMOMBCNJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x400039B")]
			public Vector4[] MDCLGOBEIEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			protected List<Texture2D> OJFCPDNJCBH;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400039D")]
			protected Vector4[] NNOMBHPOMBE;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
			[Cpp2IlInjected.Token(Token = "0x400039E")]
			protected List<Texture2D> OPAMJKBAMHM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
			[Cpp2IlInjected.Token(Token = "0x400039F")]
			protected float[] CDMLHIMLNIP;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
			[Cpp2IlInjected.Token(Token = "0x40003A0")]
			protected Vector4[] MHDJPKPHADP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x40003A1")]
			protected float[] IPGCKFEDHEO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
			[Cpp2IlInjected.Token(Token = "0x40003A2")]
			public float[] FMCOPHKACPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
			[Cpp2IlInjected.Token(Token = "0x40003A3")]
			protected List<Texture2D> LGMNGJJEKGD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
			[Cpp2IlInjected.Token(Token = "0x40003A4")]
			protected float[] IHOIAPIEGJH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
			[Cpp2IlInjected.Token(Token = "0x40003A5")]
			protected List<Texture2D> APCAMJHJPGF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
			[Cpp2IlInjected.Token(Token = "0x40003A6")]
			protected Vector4[] AGHHEDMDEJD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
			[Cpp2IlInjected.Token(Token = "0x40003A7")]
			protected float[] HCPDFAALLLC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
			[Cpp2IlInjected.Token(Token = "0x40003A8")]
			protected Vector4[] JENFCNAJEMD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x40003A9")]
			public float[] FJDHLJFOGMK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
			[Cpp2IlInjected.Token(Token = "0x40003AA")]
			public Texture2DArray PJFKMPJKOIA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x40003AB")]
			public Texture2DArray JGOFCENJMOB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
			[Cpp2IlInjected.Token(Token = "0x40003AC")]
			public Texture2DArray GPCEAPFJEJE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
			[Cpp2IlInjected.Token(Token = "0x40003AD")]
			public Texture2DArray NNBMKDBELGE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x40003AE")]
			protected bool IBIODGAMEAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
			[Cpp2IlInjected.Token(Token = "0x40003AF")]
			protected int FLAFJKPDKGK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
			[Cpp2IlInjected.Token(Token = "0x40003B0")]
			protected Vector2? BCOPJOCBIKL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
			[Cpp2IlInjected.Token(Token = "0x40003B1")]
			protected TextureFormat PNLKLKKMFJH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
			[Cpp2IlInjected.Token(Token = "0x40003B2")]
			protected Vector2? JCPLPFIBFOC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
			[Cpp2IlInjected.Token(Token = "0x40003B3")]
			protected TextureFormat CEGGACAPELD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
			[Cpp2IlInjected.Token(Token = "0x40003B4")]
			protected Vector2? PKPLDDHAICD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
			[Cpp2IlInjected.Token(Token = "0x40003B5")]
			protected TextureFormat IDAEACABFOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
			[Cpp2IlInjected.Token(Token = "0x40003B6")]
			protected Vector2? PFDDKCPOCBF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
			[Cpp2IlInjected.Token(Token = "0x40003B7")]
			protected TextureFormat DBGFKMKGNMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
			[Cpp2IlInjected.Token(Token = "0x40003B8")]
			protected bool OCBGCPNOEJE;

			[Cpp2IlInjected.Token(Token = "0x40003B9")]
			protected static int EGHEGMJJIHJ;

			[Cpp2IlInjected.Token(Token = "0x40003BA")]
			protected static int HHPJHBOLBIL;

			[Cpp2IlInjected.Token(Token = "0x40003BB")]
			protected static int DJEGPBPIOOA;

			[Cpp2IlInjected.Token(Token = "0x40003BC")]
			protected static int DEKEOODOAGM;

			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			protected static int GFKIBHCEJPP;

			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			protected static int PNCJEAPDCOL;

			[Cpp2IlInjected.Token(Token = "0x40003BF")]
			protected static int KKJJBLDALBN;

			[Cpp2IlInjected.Token(Token = "0x40003C0")]
			protected static int AFLDJBNCJLO;

			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			protected static int OPFBCAGPLOB;

			[Cpp2IlInjected.Token(Token = "0x40003C2")]
			protected static int MOCHAOLAAGG;

			[Cpp2IlInjected.Token(Token = "0x40003C3")]
			protected static int NLKKDPLIIMH;

			[Cpp2IlInjected.Token(Token = "0x40003C4")]
			protected static int EHCMOKDEFGD;

			[Cpp2IlInjected.Token(Token = "0x40003C5")]
			protected static int IKHKJLNNNLB;

			[Cpp2IlInjected.Token(Token = "0x40003C6")]
			protected static int HPMBNBBFLON;

			[Cpp2IlInjected.Token(Token = "0x40003C7")]
			protected static int LHOIPNMFFGK;

			[Cpp2IlInjected.Token(Token = "0x40003C8")]
			protected static int EDOFBKKACDM;

			[Cpp2IlInjected.Token(Token = "0x40003C9")]
			protected static int EMFDEILPCPK;

			[Cpp2IlInjected.Token(Token = "0x40003CA")]
			protected static int MDHMAFGGMHL;

			[Cpp2IlInjected.Token(Token = "0x40003CB")]
			protected static int OFACPOCCKMN;

			[Cpp2IlInjected.Token(Token = "0x40003CC")]
			protected static int PJAABJOIDNP;

			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x7C2EB70", Offset = "0x7C2D770", VA = "0x187C2EB70")]
			protected BLCAJLBEBDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x7C2EAE0", Offset = "0x7C2D6E0", VA = "0x187C2EAE0")]
			public BLCAJLBEBDC(Color OHKIPPABEGA, Color MFGKLCICHBB, Color CFGHMHCILII, Color? ECGJAPDFIMO, Color? HGKEICNNAHH, Color? IKPGLGBDPJK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x7C2D7C0", Offset = "0x7C2C3C0", VA = "0x187C2D7C0")]
			public int KBNLKDOPPNL(Material ELKOBNFIOIE, LEHNFDDPOEE KDHDOJGANHL, OCMMCABFCJD AMGKCPMFOHO, HBNDGNKPEKC PMGLBCDCDJE)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x7C2D730", Offset = "0x7C2C330", VA = "0x187C2D730")]
			public int KBNLKDOPPNL(OBPHMPFCLKB MEPFFFGIFGB)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(RVA = "0x7C2D8B0", Offset = "0x7C2C4B0", VA = "0x187C2D8B0")]
			public int OFHLKKADKPC(Material ELKOBNFIOIE, Color DELLAIPLOAD, Color EPECBPKFFMM, Color GGBCNKJOKOF, Color HJMMCCGJFEK, Color DCCHECKDFEA, Texture2D KEJBCDDMNBG, Vector4 HLAFDKNBBDG, Texture2D KELHEBMHKKE, Vector4 PCFJEOIJPIF, float OJHNNGPFEBH, float FFCMNCGCMDI, Texture2D NDCBBBLJFME, Vector4 DLDPIIJCDOC, float MKBGFHOPHEB, Texture2D HDNPGEIMLML, float GCJIBPKOKNO, Color OJDELFLFEKM, Vector4 AKPDFJGIAMN, LEHNFDDPOEE KDHDOJGANHL, OCMMCABFCJD AMGKCPMFOHO, HBNDGNKPEKC PMGLBCDCDJE)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x7C2C600", Offset = "0x7C2B200", VA = "0x187C2C600")]
			protected void ADDCFADIDPD([Out] Texture2DArray DDFHIJPJHOM, [Out] Texture2DArray ODMKBFJBKEG, [Out] Texture2DArray HJHOJEKNFAP, [Out] Texture2DArray NLCCIKHIFBK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0x7C2D340", Offset = "0x7C2BF40", VA = "0x187C2D340")]
			public void DHBDJAJKEDP(PlayerAvatarDisplayBase KLILICKMJIF, Renderer GJIEBJCNJLG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000336")]
			[Cpp2IlInjected.Address(RVA = "0x7C2C850", Offset = "0x7C2B450", VA = "0x187C2C850")]
			protected void BOMFGMDANPA(PlayerAvatarDisplayBase KLILICKMJIF, Renderer GJIEBJCNJLG, int EAHLCBGKEFE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x7C2E5A0", Offset = "0x7C2D1A0", VA = "0x187C2E5A0")]
			private Color PBHDKBCCEOB(Color PLDBBLPEEJP, LEHNFDDPOEE EJKOOEFJHNG)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0x7C2D5E0", Offset = "0x7C2C1E0", VA = "0x187C2D5E0")]
			private Color GEEAGMKALJN(Color FABGCJLNMKN, LEHNFDDPOEE EJKOOEFJHNG)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x7C2C7C0", Offset = "0x7C2B3C0", VA = "0x187C2C7C0")]
			protected void BBKDENJHHKM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x7C2D5A0", Offset = "0x7C2C1A0", VA = "0x187C2D5A0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		public struct PlayerHandBones
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003CD")]
			public Transform[] LeftHandBones;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003CE")]
			public Transform LeftHandRoot;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003CF")]
			public Transform[] RightHandBones;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003D0")]
			public Transform RightHandRoot;

			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x7C3A1F0", Offset = "0x7C38DF0", VA = "0x187C3A1F0")]
			public void HDDJAJFCCCJ(HBNDGNKPEKC PMGLBCDCDJE, [Out] Transform HMGDINOCJAI, [Out] Transform[] AJDCHCNBIKJ)
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000063")]
		protected struct BodyPartLODs
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D1")]
			public Mesh[] LODs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003D2")]
			public bool UseHandBones;
		}

		[Cpp2IlInjected.Token(Token = "0x2000065")]
		[CompilerGenerated]
		private sealed class IFAIDINHAME : IEnumerable<SkinnedMeshRenderer>, IEnumerable, IEnumerator<SkinnedMeshRenderer>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003DA")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003DB")]
			private SkinnedMeshRenderer <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003DC")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003DD")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003DE")]
			private SkinnedMeshRenderer[] <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003DF")]
			private int <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x1700009B")]
			SkinnedMeshRenderer IEnumerator<SkinnedMeshRenderer>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000348")]
				[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009C")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600034A")]
				[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0xF21C60", Offset = "0xF20860", VA = "0x180F21C60")]
			[DebuggerHidden]
			public IFAIDINHAME(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0x7C31C00", Offset = "0x7C30800", VA = "0x187C31C00", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x7C31E80", Offset = "0x7C30A80", VA = "0x187C31E80", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x7C31DD0", Offset = "0x7C309D0", VA = "0x187C31DD0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<SkinnedMeshRenderer> IEnumerable<SkinnedMeshRenderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x7C31DD0", Offset = "0x7C309D0", VA = "0x187C31DD0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class FIHBAENBCJE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003E0")]
			public PlayerAvatarDisplayBase display;

			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
			public FIHBAENBCJE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x7C2FD80", Offset = "0x7C2E980", VA = "0x187C2FD80")]
			internal bool ODPGBIFGFBP()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000067")]
		[CompilerGenerated]
		private sealed class JFNACEHDGFK : IEnumerator<FCPCPCAPDCM>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003E1")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003E2")]
			private FCPCPCAPDCM <>2__current;

			[Cpp2IlInjected.Token(Token = "0x1700009D")]
			private FCPCPCAPDCM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000352")]
				[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009E")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000354")]
				[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0xA1FD90", Offset = "0xA1E990", VA = "0x180A1FD90")]
			[DebuggerHidden]
			public JFNACEHDGFK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x7C31ED0", Offset = "0x7C30AD0", VA = "0x187C31ED0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x7C32210", Offset = "0x7C30E10", VA = "0x187C32210", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000068")]
		[CompilerGenerated]
		private struct GGIIJCEIMIO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003E3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003E4")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003E5")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003E6")]
			public FKBFMJFEIFH avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003E7")]
			private bool <forceRebuild>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003E8")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0x7C2FE60", Offset = "0x7C2EA60", VA = "0x187C2FE60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x7C30200", Offset = "0x7C2EE00", VA = "0x187C30200", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000069")]
		[CompilerGenerated]
		private sealed class ADECBKGOIPD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003E9")]
			public string overrideIdentifier;

			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
			public ADECBKGOIPD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x7C2B890", Offset = "0x7C2A490", VA = "0x187C2B890")]
			internal bool IHCBBNLPHJA(HJFHBFBJOPE selection)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006A")]
		[CompilerGenerated]
		private sealed class PKFKFJMLFNG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003EA")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003EB")]
			public AvatarItemBodyType avatarItemBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003EC")]
			public Func<KLHBLGBFFDH<Dictionary<string, PHKGFEHMLBA<Texture2D>>>> <>9__2;

			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
			public PKFKFJMLFNG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x7C339D0", Offset = "0x7C325D0", VA = "0x187C339D0")]
			internal (LKEMGHMAMLP, KLHBLGBFFDH<Dictionary<string, PHKGFEHMLBA<Texture2D>>>) LMDNHCMFBHG(Dictionary<string, LLGDDBJNDAK> avatarItems)
			{
				return default((LKEMGHMAMLP, KLHBLGBFFDH<Dictionary<string, PHKGFEHMLBA<Texture2D>>>));
			}

			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x7C33920", Offset = "0x7C32520", VA = "0x187C33920")]
			internal KLHBLGBFFDH<Dictionary<string, PHKGFEHMLBA<Texture2D>>> ALKCCJMBEMJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x7C33990", Offset = "0x7C32590", VA = "0x187C33990")]
			internal void JLELLCDGFFF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006B")]
		[CompilerGenerated]
		private sealed class OPOLPAJKLBF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003ED")]
			public Transform transformToCheck;

			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
			public OPOLPAJKLBF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x7C335F0", Offset = "0x7C321F0", VA = "0x187C335F0")]
			internal bool ONALOHOEKHC(SkinnedMeshRenderer x)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006C")]
		[CompilerGenerated]
		private struct KIFBJPAKPNJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003EE")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003EF")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003F0")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003F1")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x7C32550", Offset = "0x7C31150", VA = "0x187C32550", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x7C32720", Offset = "0x7C31320", VA = "0x187C32720", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		protected static readonly int DAAPFKCCIED;

		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		protected static readonly int OHHNGLKCJHB;

		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		protected static readonly int DGDJMPMPIHG;

		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		protected static readonly int GIJBHOFOCJJ;

		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		protected static readonly int GOOIEFFCLEB;

		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		protected static readonly int KNCOJAIGODO;

		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		protected static readonly int[] FCJICIBANOJ;

		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		protected static readonly int[] FPFNCHLBJBA;

		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		protected static readonly int[] GMLFFAANLOP;

		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		protected static readonly int[] LDPHDBAAGLJ;

		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		protected static readonly int[] LFJKLFKLGHH;

		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		protected static readonly int[] AANFBICJEGD;

		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		protected static List<PlayerAvatarDisplayBase> IFGBLMKPAIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		protected GCHCDGNDLCF ICIGOEDFNGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		protected bool NEOADBHBGGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		protected bool LEENJDNBDAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		[SerializeField]
		public AvatarBodyShapeVault BodyShapeVault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		[SerializeField]
		public AvatarFaceShapeVault FaceShapeVault;

		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		protected static readonly int[] MLDNHHDPFHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		[SerializeField]
		protected Material bodyPartMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		protected Dictionary<OBPHMPFCLKB, Material> IKHPLGCAJBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		protected Dictionary<OBPHMPFCLKB, Material> AEEPMGJDLLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		[SerializeField]
		protected bool ignorePlayerMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		[SerializeField]
		protected Transform trackingSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		[SerializeField]
		protected BodyPartLODs Head;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		[SerializeField]
		protected BodyPartLODs Ear;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		[SerializeField]
		protected BodyPartLODs Torso;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		[SerializeField]
		protected BodyPartLODs Hand;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		[SerializeField]
		protected BodyPartLODs HandPointing;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		[SerializeField]
		public PlayerHandBones HandBones;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		[SerializeField]
		public Transform remoteMeshBase;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public readonly SkinnedMeshRenderer[] CurrentDefaultSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public readonly SkinnedMeshRenderer[] NextDefaultSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public readonly SkinnedMeshRenderer[] CurrentVisibleInFirstPersonSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public readonly SkinnedMeshRenderer[] NextVisibleInFirstPersonSkinnedMeshRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		[SerializeField]
		public Transform firstPersonMeshBase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		[SerializeField]
		protected Shader uberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		[SerializeField]
		protected Shader agAvatarShader;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		protected Material KGIINAKNMGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		protected JOAGHKKNMDI MCIPGJMENEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		private KGCOEBBKGCN ANBPHJLOBEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		private KGCOEBBKGCN OCPBHEBDGBA;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		protected Material IHFEEKCJLFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		[SerializeField]
		protected Transform headPropAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		[SerializeField]
		protected Transform hatAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		[SerializeField]
		public Transform hemisphereBase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		protected FitMeshHemisphere NPDFEJAEFBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		protected bool AMGCFKOAKCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		protected JJMEKHLKNJB JLPGPPPGNOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		protected bool KKKHLCILBCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		protected AnchorParamsRestrictions HICPJJOGLBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		protected bool GFNDFFPMCDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		protected Transform HGMMFICPLJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		protected bool LBOLOPGFLJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B1")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		protected bool KCAGGJMCOMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		protected Vector3 JMPEGMANPKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		protected Quaternion KIHCLEHIHNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		protected Vector2 LHDIEDIGAPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		protected FitMeshHemisphere IMLOLCDLFFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		[SerializeField]
		[GHKDIKFNBMM(EBAHNMNBCJP.SelfAndChildren, false, false, false)]
		protected PlayerFacialAnimatorBase facialAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		[SerializeField]
		protected Transform torsoPropAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		[SerializeField]
		protected Transform torsoRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		[SerializeField]
		protected Transform headRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		[SerializeField]
		protected Transform leftHandRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		[SerializeField]
		protected Transform leftHandDefaultScaleRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		[SerializeField]
		protected Transform rightHandRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		[SerializeField]
		protected Transform rightHandDefaultScaleRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		[SerializeField]
		protected Animator leftHandAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		[SerializeField]
		protected Animator rightHandAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		[SerializeField]
		protected Transform leftHandPointingRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		[SerializeField]
		protected Transform rightHandPointingRoot;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		protected Collider[] CGGENCHNDNK;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		protected Collider[] IBGIFPMLEJP;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		protected ICEFPDCEIHE[] IHJPHHOMONP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		[SerializeField]
		protected Mesh faceMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public Dictionary<Renderer, BLCAJLBEBDC> currentPropertyBlocks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		protected Dictionary<Renderer, BLCAJLBEBDC> EPOCCHHCGGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		protected NHGEJMHFGFB KOEABCKCBMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		protected LKEMGHMAMLP ENNEFMFBMCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public OEENMKMDDDK DistanceBand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x284")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		protected int ICEJJILFLIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		protected (bool isLodForced, int forcedLOD) BOGJLLNIMMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		protected IJAJCKGOONC<IFDHKIAMFBD> CDBMJMGMCBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		protected bool MNGOAPFECNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		protected Dictionary<HJFHBFBJOPE, List<OBPHMPFCLKB>> CNGNICHAMDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		protected Dictionary<HJFHBFBJOPE, List<OBPHMPFCLKB>> FELBNKJKDNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		protected readonly Dictionary<string, PHKGFEHMLBA<Texture2D>> MNNJJEKNBLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		protected readonly Dictionary<string, PHKGFEHMLBA<Texture2D>> EGJPLCGKMAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		protected bool HCIKEKDBJIH;

		[Cpp2IlInjected.Token(Token = "0x4000323")]
		protected static int IIBFHIAAMAB;

		[Cpp2IlInjected.Token(Token = "0x4000324")]
		protected static List<LKNIGGBJNGJ> HFLADOFKEOF;

		[Cpp2IlInjected.Token(Token = "0x4000325")]
		protected static List<LKNIGGBJNGJ> LGGAAGOJHNP;

		[Cpp2IlInjected.Token(Token = "0x4000326")]
		protected static GCBFJNEKOIO OOBMIAOONBN;

		[Cpp2IlInjected.Token(Token = "0x4000327")]
		protected static Func<List<LKNIGGBJNGJ>, LKNIGGBJNGJ> NMPEDLDOOCC;

		[Cpp2IlInjected.Token(Token = "0x4000328")]
		protected static bool JMIIDOHGIIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		protected Color? GOODMNNEPJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E4")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		protected bool KCPIDIHDCIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		protected Color DDDCKPLDFNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		protected Color ANFGJDBIFFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		protected Color MAIPJNJKFGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		protected AvatarHairPattern NCBBBNLJEHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		protected FGFHPLNOLGF KAIAJFELIBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		protected Color LKHOHFFDHKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		protected Color NELKGLIJMPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		protected AvatarHairPattern EOJFDFHBGIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		protected FGFHPLNOLGF DBHHBBHOIKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		protected FGFHPLNOLGF CKBBGCCIBDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		protected Color NDMDJCFNGKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		private AdditionalFeetData AJPOHABCOKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		protected HJFHBFBJOPE? JBJGBHMJMCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		protected Texture LALKNFKGOFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		protected Color APGHFEKPPAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		protected readonly IList<HJFHBFBJOPE> ECGOECNFEGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		protected readonly IList<HJFHBFBJOPE> CJOHCFPJLLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		private AvatarItemBodyType NPNJBEDGHDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		[SerializeField]
		protected AvatarFaceShape _currentFaceShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C8")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		[SerializeField]
		protected AvatarBodyShape _currentBodyShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D0")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		[SerializeField]
		protected KMBJPNFNLBA _currentNoseType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D4")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		[SerializeField]
		protected bool _hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D5")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		protected IACPADJPHGP KFEOPLLJDFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		protected int[] MPEEIBONFOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E0")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		protected bool COGCBFAJGOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E8")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		protected int[] KJNFKMJFDHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F0")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		protected bool MNHHFBBGFGC;

		[Cpp2IlInjected.Token(Token = "0x4000346")]
		private static readonly IONAMLJCLBI.EPMFDMLBDCD NPBHCFKFKOE;

		[Cpp2IlInjected.Token(Token = "0x4000347")]
		private static readonly IONAMLJCLBI.EPMFDMLBDCD LJPMGJEDABG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F1")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		protected bool NALJHBBKFBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F8")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		protected AKKOOIDKLNO IFELOKINMPL;

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public string FAGENHCJDKB
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0xA24650", Offset = "0xA23250", VA = "0x180A24650")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0xA24690", Offset = "0xA23290", VA = "0x180A24690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public bool ILALNKPDCKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0xCA8BD0", Offset = "0xCA77D0", VA = "0x180CA8BD0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0xCA7FF0", Offset = "0xCA6BF0", VA = "0x180CA7FF0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public virtual bool OOEDGPKJOJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool EEOBDPLEHKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x7C2A050", Offset = "0x7C28C50", VA = "0x187C2A050")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public virtual bool JJOFENGBDEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public virtual bool ILAGFNEGFNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0xA38390", Offset = "0xA36F90", VA = "0x180A38390", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public virtual bool FLHKDMDGJHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public virtual bool KMANMMBEJCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public JOAGHKKNMDI IGDIPBCAEEG
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0xB4E480", Offset = "0xB4D080", VA = "0x180B4E480")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x7C2A820", Offset = "0x7C29420", VA = "0x187C2A820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public KGCOEBBKGCN KCPFOGJKIAE
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0xB45D90", Offset = "0xB44990", VA = "0x180B45D90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x7C2AC20", Offset = "0x7C29820", VA = "0x187C2AC20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public KGCOEBBKGCN ALBLEJFMLHP
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0xB5AFF0", Offset = "0xB59BF0", VA = "0x180B5AFF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x7C2AEF0", Offset = "0x7C29AF0", VA = "0x187C2AEF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		protected Material JCPHBDLALKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x7C23640", Offset = "0x7C22240", VA = "0x187C23640")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		protected Material FPMIADHIHNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x7C203F0", Offset = "0x7C1EFF0", VA = "0x187C203F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public bool KGHBGCDIIFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x1288080", Offset = "0x1286C80", VA = "0x181288080")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public PlayerFacialAnimatorBase IBCAHCAMPIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0xB5B1F0", Offset = "0xB59DF0", VA = "0x180B5B1F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public ICEFPDCEIHE[] MIMOMDJAODF
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x7C29BE0", Offset = "0x7C287E0", VA = "0x187C29BE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public ICEFPDCEIHE ACMGNBKPMJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x7C2A250", Offset = "0x7C28E50", VA = "0x187C2A250")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public ICEFPDCEIHE KEHHLNGMLIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x7C2A290", Offset = "0x7C28E90", VA = "0x187C2A290")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public Mesh KBHECAEJGCN
		{
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0xB5B940", Offset = "0xB5A540", VA = "0x180B5B940")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		protected NHGEJMHFGFB NDNDNNCKHEN
		{
			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x7C22610", Offset = "0x7C21210", VA = "0x187C22610")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		protected LKEMGHMAMLP KBMJNKCBLDM
		{
			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0xB5BCD0", Offset = "0xB5A8D0", VA = "0x180B5BCD0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x7C22490", Offset = "0x7C21090", VA = "0x187C22490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		protected bool GIOBNMAKIPF
		{
			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0xA38390", Offset = "0xA36F90", VA = "0x180A38390")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public bool GFNDLCDCFIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x7C2A240", Offset = "0x7C28E40", VA = "0x187C2A240")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public int OHFKDILAMML
		{
			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x7C2A280", Offset = "0x7C28E80", VA = "0x187C2A280")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x7C2AE30", Offset = "0x7C29A30", VA = "0x187C2AE30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public int BLMNCGKAKKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x7C2AB70", Offset = "0x7C29770", VA = "0x187C2AB70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		protected virtual bool ACBPNPGJBAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		protected virtual int[] KJBDPNKMCMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x7C22B20", Offset = "0x7C21720", VA = "0x187C22B20", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		protected bool MAACAJCFHAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x7C205F0", Offset = "0x7C1F1F0", VA = "0x187C205F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		protected static bool ALMJNEKIDIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public bool KCDAEJGBFPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x275D850", Offset = "0x275C450", VA = "0x18275D850")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x7C2B100", Offset = "0x7C29D00", VA = "0x187C2B100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public IEnumerable<SkinnedMeshRenderer> MEBGOPCPIME
		{
			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x7C29A60", Offset = "0x7C28660", VA = "0x187C29A60")]
			[IteratorStateMachine(typeof(IFAIDINHAME))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public bool PPEBHELAIMP
		{
			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x7C2A230", Offset = "0x7C28E30", VA = "0x187C2A230")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x7C235F0", Offset = "0x7C221F0", VA = "0x187C235F0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public CIFHCHIGFCF MANMLIOLGMH
		{
			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x7C29AE0", Offset = "0x7C286E0", VA = "0x187C29AE0")]
			get
			{
				return default(CIFHCHIGFCF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public static bool NLIIHHCEFJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0x7C29F80", Offset = "0x7C28B80", VA = "0x187C29F80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		protected static GCBFJNEKOIO KLBHNMHBIPJ
		{
			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0x7C23DB0", Offset = "0x7C229B0", VA = "0x187C23DB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0x7C21000", Offset = "0x7C1FC00", VA = "0x187C21000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		protected Color MPBJFDBNPOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000299")]
			[Cpp2IlInjected.Address(RVA = "0x7C1E430", Offset = "0x7C1D030", VA = "0x187C1E430")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		protected Color DMGGGPGCKFP
		{
			[Cpp2IlInjected.Token(Token = "0x600029A")]
			[Cpp2IlInjected.Address(RVA = "0x7C23500", Offset = "0x7C22100", VA = "0x187C23500")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		protected Texture2D DHNKIOCPBGO
		{
			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0x7C23380", Offset = "0x7C21F80", VA = "0x187C23380")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public Color NMLNFLMACLD
		{
			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(RVA = "0x7C29B90", Offset = "0x7C28790", VA = "0x187C29B90")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		protected Color EPKOHHFBLBF
		{
			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0x7C20900", Offset = "0x7C1F500", VA = "0x187C20900")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public FGFHPLNOLGF OJOAAFEGHPF
		{
			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0x7C29B50", Offset = "0x7C28750", VA = "0x187C29B50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		protected Texture2D OIHNLIOGHBC
		{
			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0x7C24040", Offset = "0x7C22C40", VA = "0x187C24040")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public float NIEFLINMNNM
		{
			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0x7C29B70", Offset = "0x7C28770", VA = "0x187C29B70")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public float KENFEFIGKGF
		{
			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x7C2A030", Offset = "0x7C28C30", VA = "0x187C2A030")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public bool OAOGLMPIKNM
		{
			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(RVA = "0x7C29B40", Offset = "0x7C28740", VA = "0x187C29B40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002E1")]
			[Cpp2IlInjected.Address(RVA = "0x7C2A600", Offset = "0x7C29200", VA = "0x187C2A600")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action EBFOJDAAFLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x7C297C0", Offset = "0x7C283C0", VA = "0x187C297C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x7C2A360", Offset = "0x7C28F60", VA = "0x187C2A360")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action LECLOCNHMBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x7C29720", Offset = "0x7C28320", VA = "0x187C29720")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x7C2A2C0", Offset = "0x7C28EC0", VA = "0x187C2A2C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action NFOKPEPLGGI
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x7C29860", Offset = "0x7C28460", VA = "0x187C29860")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x7C2A400", Offset = "0x7C29000", VA = "0x187C2A400")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action OCJGKCMOKAL
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x7C29900", Offset = "0x7C28500", VA = "0x187C29900")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x7C2A4A0", Offset = "0x7C290A0", VA = "0x187C2A4A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<AHDEEIHKKKF, CNIBPJLPBFA> DDHOHAFIBIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0x7C299A0", Offset = "0x7C285A0", VA = "0x187C299A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x7C2A540", Offset = "0x7C29140", VA = "0x187C2A540")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x7C26010", Offset = "0x7C24C10", VA = "0x187C26010")]
		public bool SetDeformation(bool NEOADBHBGGE, bool LEENJDNBDAA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x7C21420", Offset = "0x7C20020", VA = "0x187C21420")]
		protected static Material GBLECKDKKOM(Dictionary<OBPHMPFCLKB, Material> AEIOEINECBE, Material HCIBNJFNKOE, LEHNFDDPOEE KDHDOJGANHL, OCMMCABFCJD AMGKCPMFOHO, HBNDGNKPEKC PMGLBCDCDJE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x7C1C6D0", Offset = "0x7C1B2D0", VA = "0x187C1C6D0")]
		protected void AGBFELAOHOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x7C1E5F0", Offset = "0x7C1D1F0", VA = "0x187C1E5F0")]
		protected bool CNGMLKDNEKM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x7C21980", Offset = "0x7C20580", VA = "0x187C21980")]
		protected void GNDLNHCLMBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x7C22300", Offset = "0x7C20F00", VA = "0x187C22300", Slot = "11")]
		protected virtual void ICOAPJIDMKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x7C23880", Offset = "0x7C22480", VA = "0x187C23880")]
		public int MeshesAtLODCount(int ACJPKPPPPEO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x7C23AF0", Offset = "0x7C226F0", VA = "0x187C23AF0")]
		protected static void NDCDGBLGOIJ(Dictionary<HJFHBFBJOPE, List<OBPHMPFCLKB>> IGFGOFBOBHO, CKOEEDBHFPN LHIGOHPMBEL, Material HCIBNJFNKOE, LEHNFDDPOEE EJKOOEFJHNG, OCMMCABFCJD PEMGCOHLNAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x7C1D900", Offset = "0x7C1C500", VA = "0x187C1D900")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x7C22630", Offset = "0x7C21230", VA = "0x187C22630")]
		protected void JGHPJLKOMOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x7C24710", Offset = "0x7C23310", VA = "0x187C24710")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "12")]
		protected virtual void HBKACMPIHJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x7C22BB0", Offset = "0x7C217B0", VA = "0x187C22BB0")]
		protected static void KKNJJIPLOEL(List<Material> HOGPGIFINIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x7C251D0", Offset = "0x7C23DD0", VA = "0x187C251D0")]
		protected static void PPGJFICCHFL(Dictionary<OBPHMPFCLKB, Material> AEIOEINECBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x7C1C570", Offset = "0x7C1B170", VA = "0x187C1C570")]
		protected static void AFKIHBBPCGP(Dictionary<Renderer, BLCAJLBEBDC> IBHILDLAAOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x7C22050", Offset = "0x7C20C50", VA = "0x187C22050")]
		protected void HOHLONFLMPJ(SkinnedMeshRenderer[] CJNELIGBCMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x7C20A20", Offset = "0x7C1F620", VA = "0x187C20A20")]
		protected void EOPECGIPHAI(SkinnedMeshRenderer APIEKGDHKJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x7C20950", Offset = "0x7C1F550", VA = "0x187C20950")]
		protected void EOPECGIPHAI(MeshRenderer LEGKKAFFGOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x7C20D20", Offset = "0x7C1F920", VA = "0x187C20D20")]
		protected void FDCFCEMMCHE(List<PHBEKKNOPBH> NELLFFDLDOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x7C1E2B0", Offset = "0x7C1CEB0", VA = "0x187C1E2B0")]
		protected void BPBMLDIEGJJ(Dictionary<string, PHKGFEHMLBA<Texture2D>> IGFGOFBOBHO, bool PKJFOCAHNKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x7C249B0", Offset = "0x7C235B0", VA = "0x187C249B0")]
		protected void PBBOCMIJGPB(Dictionary<HJFHBFBJOPE, List<OBPHMPFCLKB>> IGFGOFBOBHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x7C21C00", Offset = "0x7C20800", VA = "0x187C21C00")]
		public float GetHandOpenClosedAxis(AHDEEIHKKKF CJJOHBMDBIG)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x7C268B0", Offset = "0x7C254B0", VA = "0x187C268B0")]
		public void SetHandOpenClosedAxis(AHDEEIHKKKF CJJOHBMDBIG, float AOANBCEBMDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x7C21C40", Offset = "0x7C20840", VA = "0x187C21C40")]
		public CNIBPJLPBFA GetHandVisualState(AHDEEIHKKKF CJJOHBMDBIG)
		{
			return default(CNIBPJLPBFA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x7C1D040", Offset = "0x7C1BC40", VA = "0x187C1D040")]
		public bool AddHandVisualStateToken(AHDEEIHKKKF CJJOHBMDBIG, CNIBPJLPBFA BIJDFHOCAAC, object HEDGIMBCGHA, ICEFPDCEIHE.HFINOIMDHOP NBHPMDIDLEB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x7C28140", Offset = "0x7C26D40", VA = "0x187C28140")]
		public void SetWatchHand(AHDEEIHKKKF CJJOHBMDBIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x7C28200", Offset = "0x7C26E00", VA = "0x187C28200")]
		public void SetWatchHands(bool NMGAHAGBIIG, bool BCKCJHMPJIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x7C256D0", Offset = "0x7C242D0", VA = "0x187C256D0")]
		public bool RemoveHandVisualStateToken(AHDEEIHKKKF CJJOHBMDBIG, object HEDGIMBCGHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x7C21CC0", Offset = "0x7C208C0", VA = "0x187C21CC0")]
		public bool GetThumbsUpActive(AHDEEIHKKKF CJJOHBMDBIG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x7C27B50", Offset = "0x7C26750", VA = "0x187C27B50")]
		public void SetThumbsUpActive(AHDEEIHKKKF CJJOHBMDBIG, bool CPBOBKNDPBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x7C21C80", Offset = "0x7C20880", VA = "0x187C21C80")]
		public bool GetHandshakeActive(AHDEEIHKKKF CJJOHBMDBIG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x7C26900", Offset = "0x7C25500", VA = "0x187C26900")]
		public void SetHandshakeActive(AHDEEIHKKKF CJJOHBMDBIG, bool DMGPDNMNDEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x7C213D0", Offset = "0x7C1FFD0", VA = "0x187C213D0")]
		public void ForceUpdateHandsVisualState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x7C28030", Offset = "0x7C26C30", VA = "0x187C28030")]
		public void SetUseClassicBeanHandScale(bool OOHGFGHCOAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x7C1EE50", Offset = "0x7C1DA50", VA = "0x187C1EE50")]
		public static void ClearQueuedBuilds()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7C21D00", Offset = "0x7C20900", VA = "0x187C21D00")]
		private static void HADHKILPAOM(Scene IPOHHENOLFI, LoadSceneMode KEGLMDPKKID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x7C24A00", Offset = "0x7C23600", VA = "0x187C24A00")]
		protected static void PDOPKAONIHC(PlayerAvatarDisplayBase JOABLLCGGBI, List<LKNIGGBJNGJ> EKEDMCJHLFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x7C253E0", Offset = "0x7C23FE0", VA = "0x187C253E0")]
		public AFMJGMMOLON Rebuild(bool DOLOCGBPBPF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x7C222A0", Offset = "0x7C20EA0", VA = "0x187C222A0")]
		protected AFMJGMMOLON IBMKNMFGMLM(bool DOLOCGBPBPF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x7C22170", Offset = "0x7C20D70", VA = "0x187C22170", Slot = "13")]
		protected virtual AFMJGMMOLON IBMKNMFGMLM(IList<HJFHBFBJOPE> KAKFAMMBHGF, AvatarItemBodyType KOFINMMLEPL, bool GGFOKGACMJM, bool DFCKONMPFCM, int[] BMBLCPJHPNK, bool DOLOCGBPBPF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x7C1CAF0", Offset = "0x7C1B6F0", VA = "0x187C1CAF0")]
		protected static AFMJGMMOLON AJNAIOAIODG(LKNIGGBJNGJ FIHCLBGBJNF, List<LKNIGGBJNGJ> EKEDMCJHLFC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x7C21A10", Offset = "0x7C20610", VA = "0x187C21A10")]
		[IteratorStateMachine(typeof(JFNACEHDGFK))]
		protected static IEnumerator<FCPCPCAPDCM> GNEEGICJLAK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x7C22360", Offset = "0x7C20F60", VA = "0x187C22360")]
		protected static LKNIGGBJNGJ IJEDMDOLKHB(List<LKNIGGBJNGJ> EKEDMCJHLFC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x7C26120", Offset = "0x7C24D20", VA = "0x187C26120")]
		[AsyncStateMachine(typeof(GGIIJCEIMIO))]
		public Task SetFaceCustomizationSettings(FKBFMJFEIFH HCIFJIKKCEI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x7C28360", Offset = "0x7C26F60", VA = "0x187C28360")]
		public bool UpdateFaceAndBodyCustomizationSettings(FKBFMJFEIFH HCIFJIKKCEI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x7C22530", Offset = "0x7C21130", VA = "0x187C22530")]
		public void InitializeFaceFeatures(AvatarConfiguration PMPPDEBFBJJ, CIFHCHIGFCF GLKFEKCCCKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x7C278A0", Offset = "0x7C264A0", VA = "0x187C278A0")]
		public void SetTeamColors(Color? IKPGLGBDPJK, bool JHJKOFPKNFM, Color IAKPECCKCJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x13FE440", Offset = "0x13FD040", VA = "0x1813FE440")]
		private static void IGIPNDMAAAA(Material IMKAMKEPJBL, Color OOHGFGHCOAJ, params int[] PBOOKGANCKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x13FEC70", Offset = "0x13FD870", VA = "0x1813FEC70")]
		private static void NDODNHKPGAH(Material IMKAMKEPJBL, Texture OOHGFGHCOAJ, params int[] PBOOKGANCKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x7C1DC50", Offset = "0x7C1C850", VA = "0x187C1DC50")]
		protected void BDMGFBDBMEA(Material EKIHHOIIIHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x7C24200", Offset = "0x7C22E00", VA = "0x187C24200")]
		protected void OBMHDPKKMLL(Material EKIHHOIIIHL, Color LCGNODDHHLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x7C21E30", Offset = "0x7C20A30", VA = "0x187C21E30")]
		protected void HIABIGNOFJM(Material EKIHHOIIIHL, Color LCGNODDHHLI, Color KJDBIIONCGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x7C22DA0", Offset = "0x7C219A0", VA = "0x187C22DA0")]
		protected void KNJGHLAIAFO(Material EKIHHOIIIHL, Texture2D BDAIEAKKDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x7C204E0", Offset = "0x7C1F0E0", VA = "0x187C204E0")]
		protected void DJBIGLNMHKG(Material EKIHHOIIIHL, Texture PGKCECJMBBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x7C1DED0", Offset = "0x7C1CAD0", VA = "0x187C1DED0")]
		protected void BIDIJLABMBB(Action<BLCAJLBEBDC> ELAHKDJEBIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x7C23E00", Offset = "0x7C22A00", VA = "0x187C23E00")]
		protected void NIIGDCLLCHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x7C24B00", Offset = "0x7C23700", VA = "0x187C24B00")]
		protected void PEFPEBNFIMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x7C21620", Offset = "0x7C20220", VA = "0x187C21620")]
		protected void GLDOMEFENAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x7C1D390", Offset = "0x7C1BF90", VA = "0x187C1D390")]
		public void ApplyUgcItemOverrides()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x7C25A90", Offset = "0x7C24690", VA = "0x187C25A90")]
		public void SetBeardPrimaryColor([Optional] Color? CBJNKFLFBEE, bool PIGFDCBFCOM = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x7C25CB0", Offset = "0x7C248B0", VA = "0x187C25CB0")]
		public void SetBeardSecondaryColor([Optional] Color? CBJNKFLFBEE, bool PIGFDCBFCOM = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x7C25950", Offset = "0x7C24550", VA = "0x187C25950")]
		public void SetBeardPattern([Optional] AvatarHairPattern HPJENPFPEMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x7C1DAE0", Offset = "0x7C1C6E0", VA = "0x187C1DAE0")]
		private void BCFEDDEGCBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x7C25330", Offset = "0x7C23F30", VA = "0x187C25330")]
		private bool PPIJJABIONB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x7C26490", Offset = "0x7C25090", VA = "0x187C26490")]
		public void SetHairPrimaryColor([Optional] Color? EIKKPCBMDNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x7C266A0", Offset = "0x7C252A0", VA = "0x187C266A0")]
		public void SetHairSecondaryColor([Optional] Color? EIKKPCBMDNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x7C26360", Offset = "0x7C24F60", VA = "0x187C26360")]
		public void SetHairPattern([Optional] AvatarHairPattern HPJENPFPEMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x7C25570", Offset = "0x7C24170", VA = "0x187C25570")]
		public void RefreshHair()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x7C24140", Offset = "0x7C22D40", VA = "0x187C24140")]
		private bool NNPEGHDOMGF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x7C276E0", Offset = "0x7C262E0", VA = "0x187C276E0")]
		public void SetSkinColor(Color OHKIPPABEGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x7C27BA0", Offset = "0x7C267A0", VA = "0x187C27BA0")]
		public void SetUgcItemVisualOverrides(HJFHBFBJOPE ANANENHFKHF, CIFHCHIGFCF GLKFEKCCCKO, Texture OPLMCCLAAID, Color KHNGGFHHMGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x7C1EF20", Offset = "0x7C1DB20", VA = "0x187C1EF20")]
		public void ClearUgcItemVisualOverrides()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x7C26220", Offset = "0x7C24E20", VA = "0x187C26220")]
		public bool SetFaceShape(AvatarFaceShape OANIPCLJBHC, bool MLIEKBNGHOP = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x7C21580", Offset = "0x7C20180", VA = "0x187C21580")]
		private void GCMIGKJMHOC(IEKNNJIHFMK EGADONEDPAC, float OOHGFGHCOAJ, bool BHJMHIMEMCL = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x7C24320", Offset = "0x7C22F20", VA = "0x187C24320")]
		private void OEFKGOJECJG(BCOPMDEMNEO LHPDFIJGOAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x7C1E550", Offset = "0x7C1D150", VA = "0x187C1E550")]
		private void CMIPAAIJLGD(AFLDMIJCCDM MDFALFHFLME, float OOHGFGHCOAJ, bool KPBJMIGOJCG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x7C223F0", Offset = "0x7C20FF0", VA = "0x187C223F0")]
		private void IJJGLJCCCED(PPFKBBIJKBH EEMPKBDIOGI, float OOHGFGHCOAJ, bool LBLFCEDCDIH = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x7C239E0", Offset = "0x7C225E0", VA = "0x187C239E0")]
		private void NANINPIJCMC(MELPABDIIMN KKKILOFDFAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x7C1E030", Offset = "0x7C1CC30", VA = "0x187C1E030")]
		private void BJCMKFFELDK(OJOKKAEBAMK EEFAGNIOKHD, float HLKKBGIIOOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x7C25ED0", Offset = "0x7C24AD0", VA = "0x187C25ED0")]
		public bool SetBodyShape(AvatarBodyShape NLMAEIDEOID, bool MLIEKBNGHOP = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x7C27570", Offset = "0x7C26170", VA = "0x187C27570")]
		public bool SetNoseType(KMBJPNFNLBA MAPLPIGEHBJ, bool MLIEKBNGHOP = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x7C28A40", Offset = "0x7C27640", VA = "0x187C28A40")]
		public bool UpdateFaceAndBodyShapes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x7C27550", Offset = "0x7C26150", VA = "0x187C27550")]
		public bool SetHideEars(bool AADLIMEPGDC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x7C27540", Offset = "0x7C26140", VA = "0x187C27540")]
		public bool SetHelmetHair(GCHCDGNDLCF APDDMOACFIC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x7C26FA0", Offset = "0x7C25BA0", VA = "0x187C26FA0")]
		public void SetHatAnchorParameters(JJMEKHLKNJB CMPCMANLMOH, bool HLDFHLGODNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x7C282D0", Offset = "0x7C26ED0", VA = "0x187C282D0")]
		public void SetupDisplayLODs(IACPADJPHGP KCMGKIHCBBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x7C24CC0", Offset = "0x7C238C0", VA = "0x187C24CC0")]
		protected int[] PFBEEONNPDG(IACPADJPHGP KCMGKIHCBBF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x7C276A0", Offset = "0x7C262A0", VA = "0x187C276A0")]
		public void SetOutfitSelections(IList<HJFHBFBJOPE> KAKFAMMBHGF, AvatarItemBodyType KOFINMMLEPL, bool DFCKONMPFCM, bool DOLOCGBPBPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x7C27610", Offset = "0x7C26210", VA = "0x187C27610")]
		public void SetOutfitSelections(IList<HJFHBFBJOPE> KAKFAMMBHGF, AvatarItemBodyType KOFINMMLEPL, bool GGFOKGACMJM, bool DFCKONMPFCM, bool DOLOCGBPBPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x7C27660", Offset = "0x7C26260", VA = "0x187C27660")]
		public AFMJGMMOLON SetOutfitSelections(IList<HJFHBFBJOPE> KAKFAMMBHGF, AvatarItemBodyType KOFINMMLEPL, IACPADJPHGP KCMGKIHCBBF, bool GGFOKGACMJM, bool DFCKONMPFCM, bool MLIEKBNGHOP = false, bool DOLOCGBPBPF = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x7C1C870", Offset = "0x7C1B470", VA = "0x187C1C870", Slot = "14")]
		protected virtual AFMJGMMOLON AJKBFBNMLCF(IList<HJFHBFBJOPE> KAKFAMMBHGF, AvatarItemBodyType KOFINMMLEPL, bool GGFOKGACMJM, bool DFCKONMPFCM, IACPADJPHGP KCMGKIHCBBF, bool MLIEKBNGHOP, bool DOLOCGBPBPF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x7C20F00", Offset = "0x7C1FB00", VA = "0x187C20F00")]
		protected int[] FGCGFDMLCEI(IACPADJPHGP KCMGKIHCBBF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE90", Offset = "0xA1CA90", VA = "0x180A1DE90", Slot = "15")]
		protected virtual LKEMGHMAMLP EDIJLEIPKLK(AvatarItemBodyType CAKCPCANKDP, Dictionary<string, LLGDDBJNDAK> FDIHKONKIII, Dictionary<string, PHKGFEHMLBA<Texture2D>> JFKPMOBPHAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x7C24E90", Offset = "0x7C23A90", VA = "0x187C24E90", Slot = "16")]
		protected virtual AFMJGMMOLON PMMKECHOFEK(IList<HJFHBFBJOPE> KAKFAMMBHGF, AvatarItemBodyType KOFINMMLEPL, bool GGFOKGACMJM, bool DFCKONMPFCM, int[] AOMGOCOHHKN, FPAJOPAEPNO CHMKFNIJHIJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x7C1FF70", Offset = "0x7C1EB70", VA = "0x187C1FF70", Slot = "17")]
		protected virtual LLGDDBJNDAK DCBDMCFHIMA(FGFHPLNOLGF BLPDIDCADLB, AvatarItemBodyType CAKCPCANKDP, HBNDGNKPEKC PMGLBCDCDJE, LLGDDBJNDAK IOJPMONNOOC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE90", Offset = "0xA1CA90", VA = "0x180A1DE90", Slot = "18")]
		protected virtual LLGDDBJNDAK AIJMOPNFDLH(AvatarItemBodyType CAKCPCANKDP, HBNDGNKPEKC PMGLBCDCDJE, NMMPCPHAGGP BNLGIODIEPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x7C1C7F0", Offset = "0x7C1B3F0", VA = "0x187C1C7F0")]
		protected void AJCOCGGKHOG(BPPOMJONOGG HJFICNKJEJP, IONAMLJCLBI.EPMFDMLBDCD GIBPMNAECDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x7C1E480", Offset = "0x7C1D080", VA = "0x187C1E480")]
		protected void CJAMIALLKNB(BPPOMJONOGG HJFICNKJEJP, IONAMLJCLBI.EPMFDMLBDCD GIBPMNAECDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0xA84210", Offset = "0xA82E10", VA = "0x180A84210", Slot = "19")]
		protected virtual BPPOMJONOGG NEKHKGEBHEK(BPPOMJONOGG HJFICNKJEJP, HelmetHairStyle OKBAIJBEAJD, bool CCEPMCALLHO, AvatarItemBodyType KOFINMMLEPL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x7C1EF70", Offset = "0x7C1DB70", VA = "0x187C1EF70")]
		protected BPPOMJONOGG DALJNNNLELM(IList<HJFHBFBJOPE> KAKFAMMBHGF, AvatarItemBodyType PLBLMPBAGJC, bool DFCKONMPFCM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x7C1ED30", Offset = "0x7C1D930", VA = "0x187C1ED30")]
		public void CleanupDisplayResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x7C22CF0", Offset = "0x7C218F0", VA = "0x187C22CF0")]
		protected void KMFEICGNENE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x7C23050", Offset = "0x7C21C50", VA = "0x187C23050")]
		protected void LADJDDDKFMP(Transform LIFFGOLLEON, IEnumerable<SkinnedMeshRenderer> GAOPLHADHJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x7C20C60", Offset = "0x7C1F860", VA = "0x187C20C60")]
		protected IONAMLJCLBI.EPMFDMLBDCD FBKLELPODCJ(IONAMLJCLBI.EPMFDMLBDCD EEDJFLPHBGN, HBNDGNKPEKC KABAKPPFEEI)
		{
			return default(IONAMLJCLBI.EPMFDMLBDCD);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x7C23550", Offset = "0x7C22150", VA = "0x187C23550")]
		protected void LOFHNMABHID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x1925940", Offset = "0x1924540", VA = "0x181925940")]
		protected void BJEJBDOANOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x7C24600", Offset = "0x7C23200", VA = "0x187C24600")]
		protected void OPNMOBGDJPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x7C21A70", Offset = "0x7C20670", VA = "0x187C21A70")]
		[AsyncStateMachine(typeof(KIFBJPAKPNJ))]
		protected Task GNOBKPADIGP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x7C20AC0", Offset = "0x7C1F6C0", VA = "0x187C20AC0")]
		protected static LEHNFDDPOEE FBDHBIOHBJJ(CKOEEDBHFPN HCPJCHFLCJE, int CJLABNGCJFH)
		{
			return default(LEHNFDDPOEE);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x7C21280", Offset = "0x7C1FE80", VA = "0x187C21280")]
		protected static OCMMCABFCJD FPHMPFHJAAG(CKOEEDBHFPN HCPJCHFLCJE, int CJLABNGCJFH)
		{
			return default(OCMMCABFCJD);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x7C24520", Offset = "0x7C23120", VA = "0x187C24520")]
		protected Transform OGGAEHIFDEN(HBNDGNKPEKC PMGLBCDCDJE, OutfitType HAJIOJJELDP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x7C20700", Offset = "0x7C1F300", VA = "0x187C20700")]
		protected void EHIJPCABMEJ(int BNDMLLLLIFG, Material IMKAMKEPJBL, CKOEEDBHFPN HCPJCHFLCJE, [Out] Texture2D NEABOCHKDMP, [Out] Vector4 PBADIOGGHEF, [Out] Texture2D GOPMGNDADMA, [Out] Texture2D HAAECOGBPDP, [Out] Texture2D EMLKCLCFMOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x7C1E160", Offset = "0x7C1CD60", VA = "0x187C1E160")]
		protected void BKJMOOGAOLC(int BNDMLLLLIFG, Material IMKAMKEPJBL, CKOEEDBHFPN HCPJCHFLCJE, [Out] Color DELLAIPLOAD, [Out] Color EPECBPKFFMM, [Out] Color GGBCNKJOKOF, [Out] Color HJMMCCGJFEK, [Out] Color DCCHECKDFEA, [Out] Color OJDELFLFEKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x7C25160", Offset = "0x7C23D60", VA = "0x187C25160")]
		protected void POKGHOHHDPF(Vector3 AIFJIFCFPDH, Quaternion FFNFOABACEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x7C26950", Offset = "0x7C25550", VA = "0x187C26950")]
		public void SetHatAnchorParameters(JJMEKHLKNJB CMPCMANLMOH, AnchorParamsRestrictions LAPNEKFHKJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x7C1E850", Offset = "0x7C1D450", VA = "0x187C1E850")]
		public static void CalculateHatAnchorParams(FitMeshHemisphere NPDFEJAEFBI, Transform HGMMFICPLJH, JJMEKHLKNJB CMPCMANLMOH, AnchorParamsRestrictions HICPJJOGLBD, [Out] Vector3 MICNLECKIBH, [Out] Quaternion HNIPNOOHHIL, [Out] JJMEKHLKNJB NGKJMBBCEAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x7C257E0", Offset = "0x7C243E0", VA = "0x187C257E0")]
		public void ResetHatAnchor(Vector2 DOIPNPFPMAB, Vector3 PMDEGCGIELK, Vector3 OMFMCCKINJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0xB37AB0", Offset = "0xB366B0", VA = "0x180B37AB0")]
		public GLHFHEBNGPD GetAnchorParamsRestrictions()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x7C1D1C0", Offset = "0x7C1BDC0", VA = "0x187C1D1C0")]
		public void ApplyBlocks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x7C1D300", Offset = "0x7C1BF00", VA = "0x187C1D300")]
		public void ApplyHairPattern()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x7C1D130", Offset = "0x7C1BD30", VA = "0x187C1D130")]
		public void ApplyBeardPattern()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x7C28300", Offset = "0x7C26F00", VA = "0x187C28300", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x7C21B40", Offset = "0x7C20740", VA = "0x187C21B40")]
		protected void GNPJKOGFAIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x7C280C0", Offset = "0x7C26CC0", VA = "0x187C280C0")]
		public void SetWaitForUgcTextureLoads(bool IANPEPDIDNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x7C27F40", Offset = "0x7C26B40", VA = "0x187C27F40")]
		public void SetUgcTextureParameters(AKKOOIDKLNO GALEDNLDGCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x7C29120", Offset = "0x7C27D20", VA = "0x187C29120")]
		public PlayerAvatarDisplayBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x7C24570", Offset = "0x7C23170", VA = "0x187C24570")]
		[CompilerGenerated]
		private void OOFAIIBGKPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x7C21250", Offset = "0x7C1FE50", VA = "0x187C21250")]
		[CompilerGenerated]
		private void FOEIKLFBHHG(BLCAJLBEBDC FAFCDNLNADB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x7C23560", Offset = "0x7C22160", VA = "0x187C23560")]
		[CompilerGenerated]
		private void MAONBMOOOPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x7C22FB0", Offset = "0x7C21BB0", VA = "0x187C22FB0")]
		[CompilerGenerated]
		private void KOCKDCCOMDG(BLCAJLBEBDC FAFCDNLNADB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x7C23470", Offset = "0x7C22070", VA = "0x187C23470")]
		[CompilerGenerated]
		private void LIFAEGMBGJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x7C23940", Offset = "0x7C22540", VA = "0x187C23940")]
		[CompilerGenerated]
		private void NADIKKJEOND(BLCAJLBEBDC FAFCDNLNADB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x7C22A90", Offset = "0x7C21690", VA = "0x187C22A90")]
		[CompilerGenerated]
		private void JPMGBENAMJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x7C1E500", Offset = "0x7C1D100", VA = "0x187C1E500")]
		[CompilerGenerated]
		private void CMFEFLCNMDF(BLCAJLBEBDC FAFCDNLNADB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x7C211C0", Offset = "0x7C1FDC0", VA = "0x187C211C0")]
		[CompilerGenerated]
		private void FJIFIAJMBJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x7C22A40", Offset = "0x7C21640", VA = "0x187C22A40")]
		[CompilerGenerated]
		private void JJNNLHJMICA(BLCAJLBEBDC FAFCDNLNADB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x7C20670", Offset = "0x7C1F270", VA = "0x187C20670")]
		[CompilerGenerated]
		private void ECJEBNAHDPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x7C24E70", Offset = "0x7C23A70", VA = "0x187C24E70")]
		[CompilerGenerated]
		private void PHFJMLKKFNP(BLCAJLBEBDC FAFCDNLNADB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x7C22960", Offset = "0x7C21560", VA = "0x187C22960")]
		[CompilerGenerated]
		internal static bool JIMLCCGEGHM(Transform NDOHFHOLACJ, IEnumerable<SkinnedMeshRenderer> BCNMPLHAKJD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x7C23600", Offset = "0x7C22200", VA = "0x187C23600")]
		[CompilerGenerated]
		private void MOIFJPFMKFJ(BLCAJLBEBDC FAFCDNLNADB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x7C1E810", Offset = "0x7C1D410", VA = "0x187C1E810")]
		[CompilerGenerated]
		private void COABLEAHCPH(BLCAJLBEBDC FAFCDNLNADB)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[ExecuteAlways]
	public class PlayerFacialAnimatorBase : MonoBehaviour, MIGNIEJDGMD
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		[CompilerGenerated]
		private struct JHHDDEBIIBD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400046A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400046B")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400046C")]
			public FKBFMJFEIFH avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400046D")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400046E")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x7C32260", Offset = "0x7C30E60", VA = "0x187C32260", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x7C324F0", Offset = "0x7C310F0", VA = "0x187C324F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		[CompilerGenerated]
		private struct ABABALMOGJH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400046F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000470")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000471")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000472")]
			public int eyeSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000473")]
			public int eyeBrowSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000474")]
			public int noseSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000475")]
			public int mouthSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000476")]
			public CIFHCHIGFCF avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000477")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x7C2B650", Offset = "0x7C2A250", VA = "0x187C2B650", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x7C2B830", Offset = "0x7C2A430", VA = "0x187C2B830", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private struct BGDDEDCGELF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000478")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000479")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400047A")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400047B")]
			public FaceFeatureType featureType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400047C")]
			public int selectionIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400047D")]
			public CIFHCHIGFCF avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400047E")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0x7C2C400", Offset = "0x7C2B000", VA = "0x187C2C400", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x7C2C5A0", Offset = "0x7C2B1A0", VA = "0x187C2C5A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private struct LIGHMPEKJAL : IAsyncStateMachine
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
			public FKBFMJFEIFH avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000483")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x7C32780", Offset = "0x7C31380", VA = "0x187C32780", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x7C32930", Offset = "0x7C31530", VA = "0x187C32930", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		[CompilerGenerated]
		private struct EBMEDONELHK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000484")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000485")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000486")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000487")]
			public CIFHCHIGFCF avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000488")]
			private TaskAwaiter<BEKEHOGMLKK> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0x7C2F460", Offset = "0x7C2E060", VA = "0x187C2F460", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x7C2F8A0", Offset = "0x7C2E4A0", VA = "0x187C2F8A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		[CompilerGenerated]
		private struct ELJGBCLDFLK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000489")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400048A")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400048B")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400048C")]
			public bool forceRebuild;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400048D")]
			public CIFHCHIGFCF avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400048E")]
			private FaceStyleSet <styleSet>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400048F")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0x7C2F900", Offset = "0x7C2E500", VA = "0x187C2F900", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0x7C2FD20", Offset = "0x7C2E920", VA = "0x187C2FD20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		protected const float MHECPIJAJHB = 0.5f;

		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		protected const int AALOMBLAIED = 5;

		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		private static readonly int JMLCLIGPNON;

		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		private static readonly int KBNBNENKJOM;

		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		private static readonly int KCOJHHKEIFC;

		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public static readonly int IdleID;

		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public static readonly int SmileID;

		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public static readonly int HugeSmileID;

		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public static readonly int ScoreID;

		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public static readonly int SadID;

		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public static readonly int DisgustID;

		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public static readonly int HitID;

		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public static readonly int ConcentrateID;

		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public static readonly int KissID;

		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public static readonly int TalkingID;

		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public static readonly int MuteID;

		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public static readonly int AFKID;

		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public static readonly int HappyID;

		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public static readonly int EmoteFlatID;

		[Cpp2IlInjected.Token(Token = "0x4000405")]
		public static readonly int EmoteHappyID;

		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public static readonly int EmoteSadID;

		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public static readonly int EmoteLoveID;

		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public static readonly int EmoteAngryID;

		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public static readonly int EmoteLaughID;

		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public static readonly int EmoteTongueOutID;

		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public static readonly int EmoteGrimacingID;

		[Cpp2IlInjected.Token(Token = "0x400040C")]
		public static readonly int EmoteWinkID;

		[Cpp2IlInjected.Token(Token = "0x400040D")]
		public static readonly int EmoteShockedID;

		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public static readonly int EmoteNauseatedID;

		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public static readonly int EmoteSmileSweatID;

		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public static readonly int EmoteSleepingID;

		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public static readonly int EmoteThinkingID;

		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public static readonly int EmoteSmirkID;

		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public static readonly int EmoteSmileID;

		[Cpp2IlInjected.Token(Token = "0x4000414")]
		protected static readonly Dictionary<FJCICCHHDBL.KIENFNONBGN, int> EIHPGGGMOII;

		[Cpp2IlInjected.Token(Token = "0x4000415")]
		[CanBeNull]
		protected static IEnumerable<FaceFeatureType> ENDNAMGILAO;

		[Cpp2IlInjected.Token(Token = "0x4000416")]
		protected static readonly int GDHMAANJPEF;

		[Cpp2IlInjected.Token(Token = "0x4000417")]
		protected static readonly int MIDFLHDKLEO;

		[Cpp2IlInjected.Token(Token = "0x4000418")]
		protected static readonly int MMLEGPHMLGC;

		[Cpp2IlInjected.Token(Token = "0x4000419")]
		protected static readonly int EEGOOFAKGCH;

		[Cpp2IlInjected.Token(Token = "0x400041A")]
		protected static readonly int LHPPJFOJILA;

		[Cpp2IlInjected.Token(Token = "0x400041B")]
		protected static Vector2 ILAFCOMCNHE;

		[Cpp2IlInjected.Token(Token = "0x400041C")]
		protected static Vector2 PFMNDHKFDOM;

		[Cpp2IlInjected.Token(Token = "0x400041D")]
		protected static Vector2 CPMCOFHEDCA;

		[Cpp2IlInjected.Token(Token = "0x400041E")]
		protected static Vector2 IOOJKAPOGJG;

		[Cpp2IlInjected.Token(Token = "0x400041F")]
		protected static Vector2 DNMHDCFAFMC;

		[Cpp2IlInjected.Token(Token = "0x4000420")]
		protected static Vector2 HMPHNMELGBC;

		[Cpp2IlInjected.Token(Token = "0x4000421")]
		protected static Vector2 CKAMKAJHJKP;

		[Cpp2IlInjected.Token(Token = "0x4000422")]
		protected static Vector2 IIKDKJMFDEC;

		[Cpp2IlInjected.Token(Token = "0x4000423")]
		protected static Vector2 MCGCHMFIMCO;

		[Cpp2IlInjected.Token(Token = "0x4000424")]
		protected static Vector2 IMIIBIAPHNN;

		[Cpp2IlInjected.Token(Token = "0x4000425")]
		protected static Vector2 MECCKKKJCOF;

		[Cpp2IlInjected.Token(Token = "0x4000426")]
		protected static Vector2 AFCIMDKDDHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		[GHKDIKFNBMM(EBAHNMNBCJP.Self, false, false, false)]
		[SerializeField]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		[SerializeField]
		[Header("Rendering")]
		public FaceStyleSet faceStyleSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		[SerializeField]
		protected Renderer faceRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		[SerializeField]
		protected float jitterFPS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		[Header("Emotes")]
		[SerializeField]
		public Renderer[] emoteEffectRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		[SerializeField]
		[Header("Modern Avatar Facial Features")]
		[FormerlySerializedAs("fullBodyFaceStyleSet")]
		public FaceStyleSet modernBodyFaceStyleSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		private CIFHCHIGFCF DOAHDAGGIPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		private FaceStyleSet CIHPFFEBLDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		[SerializeField]
		protected bool debugEyeJitterInEditor;

		[Cpp2IlInjected.Token(Token = "0x4000430")]
		protected const int EPEKGOICDBP = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		protected int JDOJNGNLFCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		protected int HHLAHBNBFGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		protected int AHAGADIPBJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		protected int GIJKPGHKLBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		protected Vector2 KOPDFCELBEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		protected float DFHAKJHBEGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		protected float ICIKCCMPNLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		protected float BBCMCGJHCAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		protected Vector2 BHMGELMCECH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		protected float JPHHNNFJADO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		protected float IPMNNBGJNEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		protected float PEEDKLBNJLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		protected Vector2 FAPFGHOFPAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		protected float GAJABLNAPPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		protected float KPLMCMGDFIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		protected float PDCMEKAOGJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		protected Vector2 IJPJEEPLLAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		protected float CBGBDKJIPJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		protected float AGANLKCEHFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		protected float APLOIMFGBGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		protected List<SelectableFaceOption> HIIJILFIMLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		protected List<SelectableFaceOption> CCKJJMGHNBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		protected List<SelectableFaceOption> LDIOFMGOIOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		protected List<SelectableFaceOption> DIJFBNOKPLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		protected Coroutine LPMKDNNDHPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		protected int? GDMDGEOOHEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		protected int LPHKHILKJMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		protected int JOKDMGBFLHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		protected int AAMCADPGPJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		protected int OJHBLLNEONH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		protected Sprite IOJBANHDHJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		protected Sprite DHMOEBLFNAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		protected Sprite IEILOPAHCJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		protected Sprite HGGIBCJNAIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		protected bool MHOKEGCJHOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		protected string FOPPCAHMKLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		protected string MLPBMOKEGAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		protected string PDMMNENPDJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		protected string BFIDBAOAGDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		[ReadOnlyField]
		public Sprite eyeSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		[ReadOnlyField]
		public Sprite leftEyeOnlySprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		[ReadOnlyField]
		public Sprite rightEyeOnlySprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public Color leftEyeColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public Color leftEyeGleamColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public Color rightEyeColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public Color rightEyeGleamColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		[ReadOnlyField]
		public Sprite mouthSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		protected AvatarConfiguration PMPPDEBFBJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		protected BEKEHOGMLKK LBAMKMNLPLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		private readonly List<Material> IGBMIMAIHMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		protected OEGCNCIIODM PFOGCAJLIOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		protected Dictionary<string, int> FJMMONPMFEK;

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public FaceStyleSet FABNPHJOBHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x7C39F40", Offset = "0x7C38B40", VA = "0x187C39F40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public bool FOFOENEBAKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x24957D0", Offset = "0x24943D0", VA = "0x1824957D0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x25656F0", Offset = "0x25642F0", VA = "0x1825656F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		protected virtual bool FAMBNEIACDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		protected virtual bool KEJLPIEHHOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0xA38390", Offset = "0xA36F90", VA = "0x180A38390", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		protected int FHIAGEKBPIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x7C34A90", Offset = "0x7C33690", VA = "0x187C34A90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public Renderer JBIMPHBDGAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0xA246B0", Offset = "0xA232B0", VA = "0x180A246B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public bool ONGDJJKJOMF
		{
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x2569D10", Offset = "0x2568910", VA = "0x182569D10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x255DD00", Offset = "0x255C900", VA = "0x18255DD00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public Renderer[] FCGKOLIJNBD
		{
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0xA24650", Offset = "0xA23250", VA = "0x180A24650")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		public bool BJBAECMICMA
		{
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x7C39F90", Offset = "0x7C38B90", VA = "0x187C39F90")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x7C3A150", Offset = "0x7C38D50", VA = "0x187C3A150")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		protected int FLLNDIIEMLH
		{
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x7C34FB0", Offset = "0x7C33BB0", VA = "0x187C34FB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		protected int DBAFILAODGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x7C35860", Offset = "0x7C34460", VA = "0x187C35860")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public float LFMJHFCHANP
		{
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0x7C39F70", Offset = "0x7C38B70", VA = "0x187C39F70")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0x7C3A130", Offset = "0x7C38D30", VA = "0x187C3A130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public DKHBNCECMKL AJNOHKDKICA
		{
			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0xB5C0C0", Offset = "0xB5ACC0", VA = "0x180B5C0C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0xB8CBB0", Offset = "0xB8B7B0", VA = "0x180B8CBB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public BEKEHOGMLKK JMJCCJPAOEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000390")]
			[Cpp2IlInjected.Address(RVA = "0xAE59A0", Offset = "0xAE45A0", VA = "0x180AE59A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000391")]
			[Cpp2IlInjected.Address(RVA = "0x7C3A0B0", Offset = "0x7C38CB0", VA = "0x187C3A0B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public NoseFaceOption KICCIDHIGPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000392")]
			[Cpp2IlInjected.Address(RVA = "0xAC0740", Offset = "0xABF340", VA = "0x180AC0740")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0xB418F0", Offset = "0xB404F0", VA = "0x180B418F0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		protected OEGCNCIIODM AIDKBJPJFAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000394")]
			[Cpp2IlInjected.Address(RVA = "0x7C34930", Offset = "0x7C33530", VA = "0x187C34930")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action EDNAKBFANPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x7C39E90", Offset = "0x7C38A90", VA = "0x187C39E90")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x7C3A000", Offset = "0x7C38C00", VA = "0x187C3A000")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x7C36AE0", Offset = "0x7C356E0", VA = "0x187C36AE0")]
		public void LocalPlayEmote(FJCICCHHDBL.KIENFNONBGN FNFMBBJKFHD, float KKFJNMKHOMG = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x7C35DD0", Offset = "0x7C349D0", VA = "0x187C35DD0")]
		public bool IsEmotePlaying(FJCICCHHDBL.KIENFNONBGN FNFMBBJKFHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x7C37EB0", Offset = "0x7C36AB0", VA = "0x187C37EB0")]
		public void SetIdleHappy(bool HPNKMAMNEGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x7C34BC0", Offset = "0x7C337C0", VA = "0x187C34BC0")]
		protected void DIDMEFAHOLJ(bool OEHNAMBNDCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x7C37420", Offset = "0x7C36020", VA = "0x187C37420")]
		protected void PACDAKKFPHH(bool MFLFCGGKAFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x7C34C40", Offset = "0x7C33840", VA = "0x187C34C40")]
		protected void DINHAOOHFAF(HBNDGNKPEKC PMGLBCDCDJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x7C36F50", Offset = "0x7C35B50", VA = "0x187C36F50")]
		protected void MNOEICACCIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x7C37580", Offset = "0x7C36180", VA = "0x187C37580")]
		public void PlayExpression(int MGOOGINPCJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x7C36720", Offset = "0x7C35320", VA = "0x187C36720")]
		protected void KKIFJBCDCDK(bool DGADIDDNINF, bool KAJDLGLMIID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x7C35490", Offset = "0x7C34090", VA = "0x187C35490")]
		public List<SelectableFaceOption> GetAvailableFeatures(FaceFeatureType PLAKOGIALAM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x7C358C0", Offset = "0x7C344C0", VA = "0x187C358C0")]
		public void InitializeFaceFeatureRanges(AvatarConfiguration PMPPDEBFBJJ, CIFHCHIGFCF GLKFEKCCCKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x7C37B50", Offset = "0x7C36750", VA = "0x187C37B50")]
		[AsyncStateMachine(typeof(JHHDDEBIIBD))]
		public Task SetFaceSettings(FKBFMJFEIFH HCIFJIKKCEI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x7C37C40", Offset = "0x7C36840", VA = "0x187C37C40")]
		[AsyncStateMachine(typeof(ABABALMOGJH))]
		public Task SetFaceSettings(int CLLEKIEENDN, int GPFDMDECJEB, int JNIBCGIGFGI, int IAKENFMFNFE, CIFHCHIGFCF GLKFEKCCCKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x7C37F30", Offset = "0x7C36B30", VA = "0x187C37F30")]
		[AsyncStateMachine(typeof(BGDDEDCGELF))]
		public Task SetSelectedFaceFeatureAndBuildFaceStyle(FaceFeatureType PLAKOGIALAM, int IABGOFLGFPK, CIFHCHIGFCF GLKFEKCCCKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x7C34450", Offset = "0x7C33050", VA = "0x187C34450")]
		protected void BBGHOLDNPLH(FaceFeatureType PLAKOGIALAM, DOLBAFHNJDK DPAFHHMCBDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x7C33BD0", Offset = "0x7C327D0", VA = "0x187C33BD0")]
		protected void AIGPEJJMENM(FaceFeatureType PLAKOGIALAM, int IABGOFLGFPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x7C352C0", Offset = "0x7C33EC0", VA = "0x187C352C0")]
		public static IEnumerable<FaceFeatureType> GetAllFaceFeatureTypes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x7C36CC0", Offset = "0x7C358C0", VA = "0x187C36CC0")]
		[AsyncStateMachine(typeof(LIGHMPEKJAL))]
		protected Task MDLFHHNGEPN(FKBFMJFEIFH HCIFJIKKCEI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x7C34CB0", Offset = "0x7C338B0", VA = "0x187C34CB0")]
		protected void EBICEPCGCOO(FKBFMJFEIFH HCIFJIKKCEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x7C36950", Offset = "0x7C35550", VA = "0x187C36950")]
		protected static void LAKDILGEKGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x7C345D0", Offset = "0x7C331D0", VA = "0x187C345D0")]
		private void BGELBHKGHGK(bool FCLCFJEDNHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x7C354D0", Offset = "0x7C340D0", VA = "0x187C354D0")]
		protected void HGMJDFNLNAG(FaceFeatureType PLAKOGIALAM, Vector2 OJBMIFEPHEK, CIFHCHIGFCF GLKFEKCCCKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x7C375A0", Offset = "0x7C361A0", VA = "0x187C375A0")]
		public void SetFaceFeatureNormalizedPositionOffset(FaceFeatureType PLAKOGIALAM, Vector2 GJDBGDHEFHP, CIFHCHIGFCF GLKFEKCCCKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x7C36FC0", Offset = "0x7C35BC0", VA = "0x187C36FC0")]
		protected void NJGEHFLKMFJ(FaceFeatureType PLAKOGIALAM, float CBGOOAGMHKM, CIFHCHIGFCF GLKFEKCCCKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x7C367D0", Offset = "0x7C353D0", VA = "0x187C367D0")]
		protected void KOBKBKGCOBF(FaceFeatureType PLAKOGIALAM, float BFEELDCLMGM, CIFHCHIGFCF GLKFEKCCCKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x7C37140", Offset = "0x7C35D40", VA = "0x187C37140")]
		protected void OHDAFNHCDFB(FaceFeatureType PLAKOGIALAM, float OHLKEIOKDNG, CIFHCHIGFCF GLKFEKCCCKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x7C37930", Offset = "0x7C36530", VA = "0x187C37930")]
		public void SetFaceFeatureNormalizedScaleOffset(FaceFeatureType PLAKOGIALAM, float NKHFILFCACH, CIFHCHIGFCF GLKFEKCCCKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x7C36BE0", Offset = "0x7C357E0", VA = "0x187C36BE0")]
		[AsyncStateMachine(typeof(EBMEDONELHK))]
		protected Task MAPMBKBMNEK(CIFHCHIGFCF GLKFEKCCCKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x7C35BC0", Offset = "0x7C347C0", VA = "0x187C35BC0")]
		public void InitializeFaceFeatureStyleSet(CIFHCHIGFCF GLKFEKCCCKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x7C349B0", Offset = "0x7C335B0", VA = "0x187C349B0")]
		protected bool CLIFJLNFEMF(string JJPFPBDAIAO, [Out] int EMMACFPOKFB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x7C34310", Offset = "0x7C32F10", VA = "0x187C34310")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x7C38040", Offset = "0x7C36C40", VA = "0x187C38040", Slot = "8")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x7C37210", Offset = "0x7C35E10", VA = "0x187C37210")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x7C39030", Offset = "0x7C37C30", VA = "0x187C39030")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x7C34830", Offset = "0x7C33430", VA = "0x187C34830")]
		[AsyncStateMachine(typeof(ELJGBCLDFLK))]
		public Task BuildFaceStyleAsyncIfChanged(CIFHCHIGFCF GLKFEKCCCKO, bool MLIEKBNGHOP = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x7C38940", Offset = "0x7C37540", VA = "0x187C38940")]
		public void UpdateFaceDisplays(bool EEGGIGOKHGD = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x7C35EF0", Offset = "0x7C34AF0", VA = "0x187C35EF0")]
		protected bool KDAKPKGLHED(bool EEGGIGOKHGD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x7C386A0", Offset = "0x7C372A0", VA = "0x187C386A0")]
		public void UpdateFaceDisplayFeatureTextures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x7C37D70", Offset = "0x7C36970", VA = "0x187C37D70")]
		public void SetFaceSpriteIndices(string GLNJFPPOAGK, string OKNNNCEBIBC, string HIFCKLBBCLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x7C38050", Offset = "0x7C36C50", VA = "0x187C38050")]
		public void UpdateFaceDisplayFeaturePositions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x7C38B60", Offset = "0x7C37760", VA = "0x187C38B60")]
		public void UpdateFaceJitterMultiplier()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x7C38D50", Offset = "0x7C37950", VA = "0x187C38D50")]
		public bool UpdateLegacyFaceVectors()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x7C36630", Offset = "0x7C35230", VA = "0x187C36630")]
		protected void KIKJLPGJHME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x7C35010", Offset = "0x7C33C10", VA = "0x187C35010")]
		private void GGFCPCDJPCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x7C36DB0", Offset = "0x7C359B0", VA = "0x187C36DB0")]
		private void MEJLPPCKHCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x7C39C40", Offset = "0x7C38840", VA = "0x187C39C40")]
		public PlayerFacialAnimatorBase()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0xA4B1A0", Offset = "0xA49DA0", VA = "0x180A4B1A0", Slot = "4")]
		private bool PNAGGHBGEHF()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public struct FLNNGFCCDIF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public string AJPMCBKCCJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public int PAAINMNNDIB;
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
		private struct PJBDAINMIKA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004F1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004F2")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004F3")]
			public PlayerModernBodyEditorAvatarValidator <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004F4")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003E9")]
			[Cpp2IlInjected.Address(RVA = "0x7C336A0", Offset = "0x7C322A0", VA = "0x187C336A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EA")]
			[Cpp2IlInjected.Address(RVA = "0xA6B020", Offset = "0xA69C20", VA = "0x180A6B020", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000078")]
		[CompilerGenerated]
		private struct MFCLALPOLFB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004F5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004F6")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004F7")]
			public PlayerModernBodyEditorAvatarValidator <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004F8")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003EB")]
			[Cpp2IlInjected.Address(RVA = "0x7C32C30", Offset = "0x7C31830", VA = "0x187C32C30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EC")]
			[Cpp2IlInjected.Address(RVA = "0x7C33130", Offset = "0x7C31D30", VA = "0x187C33130", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public const string IDLE_ANIM_NAME = "Idle";

		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public const string A_POSE_ANIM_NAME = "A Pose";

		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public const string ANIMATION_OVERRIDE_STATE_NAME = "Override";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public CIFHCHIGFCF avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public Color hairPrimaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public Color hairSecondaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public Color beardPrimaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public Color beardSecondaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public Color skinColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public int faceShapeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public int bodyShapeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public int hairPatternIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public int beardPatternIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public AvatarFaceShape[] faceShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public AvatarBodyShape[] bodyShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public AvatarHairPattern[] hairPatterns;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public float _avatarScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public bool enablePosing;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public int poseIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public AnimationClip animationOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		[Range(0f, 4f)]
		public float animationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public GCHCDGNDLCF useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public JJMEKHLKNJB hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public GLHFHEBNGPD HatAnchorRestrictions;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public bool UseHairFitMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD1")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public bool usesHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public GameObject hatPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public GameObject hairPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public GameObject earPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public GameObject eyePrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public GameObject mouthPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public GameObject neckPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public GameObject shirtPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public GameObject beltPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public GameObject shoulderPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public GameObject rightHandPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public GameObject leftHandPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public GameObject legsPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public GameObject feetPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public long baseSkinCullingMask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		[GHKDIKFNBMM(EBAHNMNBCJP.Self, false, false, false)]
		[SerializeField]
		public PlayerAvatarDisplayBase _avatarDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		private JOPNFGGDFLO HOEDHDMLOFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		[GHKDIKFNBMM(EBAHNMNBCJP.Self, false, false, false)]
		[SerializeField]
		public PlayerFacialAnimatorBase facialAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public AnimationClip animationClipToOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		private AnimatorOverrideController GHPJHLAPDJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		private List<KeyValuePair<AnimationClip, AnimationClip>> DKAJFBFLOOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public Transform headIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public Transform leftHandIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public Transform rightHandIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		[Range(0f, 2f)]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public int rightHandGestureStateIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		[Range(0f, 1f)]
		public float rightHandCurl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public int leftHandGestureStateIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		[Range(0f, 1f)]
		public float leftHandCurl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public int eyeBrowSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public int eyeSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public int noseSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public int mouthSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public float eyeBrowPositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public float eyeBrowPositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public float eyeBrowScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public float eyePositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public float eyePositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public float eyeScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D4")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public float nosePositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public float noseScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1DC")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public float mouthPositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public float mouthPositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E4")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public float mouthScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public float hatNormalizedPositionX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EC")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public float hatNormalizedPositionY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public Vector3 hatHemispherePositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1FC")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public Vector3 hatHemisphereRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public int facialExpressionIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20C")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		[Range(0f, 1f)]
		public float normalizedTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public readonly FLNNGFCCDIF[] FacialExpressions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public readonly string[] BodyPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public readonly (string, CNIBPJLPBFA)[] HandPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public bool hideLeftWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x229")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public bool hideRightWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22A")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		protected bool IIPMKDBFOJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22C")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		protected Guid HNBABAHMICC;

		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		protected static Guid BANPDNLCFDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		private JOAGHKKNMDI LFBDCADGLCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		private DKHBNCECMKL EIAAOCJBJEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		private KGCOEBBKGCN ANBPHJLOBEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		private KGCOEBBKGCN OCPBHEBDGBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		private AdditionalHatData HHCHIDGNKPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		private readonly Dictionary<GameObject, FGFHPLNOLGF> GMCOHEAABBI;

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public static Func<NMMPCPHAGGP> EDBCNDHIKNK
		{
			[Cpp2IlInjected.Token(Token = "0x60003B7")]
			[Cpp2IlInjected.Address(RVA = "0x7C3F140", Offset = "0x7C3DD40", VA = "0x187C3F140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0x7C3F780", Offset = "0x7C3E380", VA = "0x187C3F780")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public bool NNPEGHDOMGF
		{
			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0x7C3F2A0", Offset = "0x7C3DEA0", VA = "0x187C3F2A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public bool PPIJJABIONB
		{
			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x7C3F190", Offset = "0x7C3DD90", VA = "0x187C3F190")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		public PlayerAvatarDisplayBase KLILICKMJIF
		{
			[Cpp2IlInjected.Token(Token = "0x60003BC")]
			[Cpp2IlInjected.Address(RVA = "0xB45D90", Offset = "0xB44990", VA = "0x180B45D90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		protected static Guid FCGMDLOKAGL
		{
			[Cpp2IlInjected.Token(Token = "0x60003BD")]
			[Cpp2IlInjected.Address(RVA = "0x7C3CD20", Offset = "0x7C3B920", VA = "0x187C3CD20")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public (GameObject, HBNDGNKPEKC)[] OPOCCNAPNBK
		{
			[Cpp2IlInjected.Token(Token = "0x60003D3")]
			[Cpp2IlInjected.Address(RVA = "0x7C3F3B0", Offset = "0x7C3DFB0", VA = "0x187C3F3B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x7C3CEE0", Offset = "0x7C3BAE0", VA = "0x187C3CEE0")]
		[ContextMenu("Refresh Avatar")]
		private void RebuildTestAvatarContextMenu()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x7C3A380", Offset = "0x7C38F80", VA = "0x187C3A380")]
		private IEnumerable<GameObject> AOIEMLCHMDC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x7C3D3B0", Offset = "0x7C3BFB0", VA = "0x187C3D3B0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x7C3A2A0", Offset = "0x7C38EA0", VA = "0x187C3A2A0")]
		private void AJPKLEEFJJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x13C5E90", Offset = "0x13C4A90", VA = "0x1813C5E90")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x7C3C2D0", Offset = "0x7C3AED0", VA = "0x187C3C2D0")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x7C3D3C0", Offset = "0x7C3BFC0", VA = "0x187C3D3C0")]
		public void Teardown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x7C3D1D0", Offset = "0x7C3BDD0", VA = "0x187C3D1D0")]
		public void ShowPose(AnimationClip LIAJFGLFJOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x7C3D380", Offset = "0x7C3BF80", VA = "0x187C3D380")]
		public void ShowPose(string DJGPJNKFBJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x7C3D030", Offset = "0x7C3BC30", VA = "0x187C3D030")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x7C3CEF0", Offset = "0x7C3BAF0", VA = "0x187C3CEF0")]
		public void ResetHandPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x7C3DE90", Offset = "0x7C3CA90", VA = "0x187C3DE90")]
		public void UpdateHandAnimation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x7C3DCE0", Offset = "0x7C3C8E0", VA = "0x187C3DCE0")]
		public void UpdateFaceAndBodyShapes(bool MLIEKBNGHOP = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x7C3E290", Offset = "0x7C3CE90", VA = "0x187C3E290")]
		public void UpdateNoseShape(KMBJPNFNLBA MAPLPIGEHBJ, bool MLIEKBNGHOP = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x7C3E260", Offset = "0x7C3CE60", VA = "0x187C3E260")]
		public void UpdateLODOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x7C3B430", Offset = "0x7C3A030", VA = "0x187C3B430", Slot = "4")]
		protected virtual void CMGAEGIDLBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x7C3C060", Offset = "0x7C3AC60", VA = "0x187C3C060", Slot = "5")]
		protected virtual void GMNANMGJHIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x7C3A9B0", Offset = "0x7C395B0", VA = "0x187C3A9B0")]
		public void ApplyHatData(AdditionalHatData EOEJLMMEJKD, bool CHPCFOOEOPE = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x7C3A7F0", Offset = "0x7C393F0", VA = "0x187C3A7F0")]
		public void ApplyHatAdjustmentsToHatAnchorParams()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x7C3AD10", Offset = "0x7C39910", VA = "0x187C3AD10")]
		public void ApplyHatUVOverride(Vector2 PHLMOBMMGBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x7C3AC30", Offset = "0x7C39830", VA = "0x187C3AC30")]
		public void ApplyHatPositionAdjustment(Vector3 HBNCAJBGFAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x7C3ACA0", Offset = "0x7C398A0", VA = "0x187C3ACA0")]
		public void ApplyHatRotationAdjustment(Vector3 OBJAMIMIGOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x7C3AD80", Offset = "0x7C39980", VA = "0x187C3AD80")]
		public HJFHBFBJOPE BuildAvatarItemSelection(GameObject KAPGLFDIHMD, CIFHCHIGFCF CAKCPCANKDP, HBNDGNKPEKC APEIOHLGPKL)
		{
			return default(HJFHBFBJOPE);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x7C3AE20", Offset = "0x7C39A20", VA = "0x187C3AE20")]
		public void BuildAvatar(bool MLIEKBNGHOP = false, bool CHPCFOOEOPE = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x7C3D720", Offset = "0x7C3C320", VA = "0x187C3D720")]
		public void UpdateColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x7C3A930", Offset = "0x7C39530", VA = "0x187C3A930")]
		public void ApplyHatAnchor()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x7C3E0B0", Offset = "0x7C3CCB0", VA = "0x187C3E0B0")]
		public void UpdateHatAnchor(bool CHPCFOOEOPE = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x7C3DDE0", Offset = "0x7C3C9E0", VA = "0x187C3DDE0")]
		[AsyncStateMachine(typeof(PJBDAINMIKA))]
		public void UpdateFaceFeatures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x7C3CE10", Offset = "0x7C3BA10", VA = "0x187C3CE10")]
		[AsyncStateMachine(typeof(MFCLALPOLFB))]
		private Task OJDIKJMJENL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x7C3CA60", Offset = "0x7C3B660", VA = "0x187C3CA60")]
		private void JINDBEJJACG(FaceFeatureType PKPCHIEAIOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x7C3C9D0", Offset = "0x7C3B5D0", VA = "0x187C3C9D0")]
		private void JBPGHHGNBNI(FaceFeatureType PKPCHIEAIOJ, [Out] float GKPPDMBDANH, [Out] float HEIBMEEINMK, [Out] float LHHOCCKJGIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x7C3DBA0", Offset = "0x7C3C7A0", VA = "0x187C3DBA0")]
		public void UpdateEmote()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x7C3DF40", Offset = "0x7C3CB40", VA = "0x187C3DF40")]
		public void UpdateHandPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x7C3B730", Offset = "0x7C3A330", VA = "0x187C3B730")]
		private void DGKOHGICIIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80")]
		private void MHIICEJDCKK(FGFHPLNOLGF BLPDIDCADLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80")]
		private void OPPFCNECPHA(FGFHPLNOLGF BLPDIDCADLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x7C3BD00", Offset = "0x7C3A900", VA = "0x187C3BD00")]
		private void GGHKHOBFELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x7C3E310", Offset = "0x7C3CF10", VA = "0x187C3E310")]
		public PlayerModernBodyEditorAvatarValidator()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x7C3BC50", Offset = "0x7C3A850", VA = "0x187C3BC50")]
		[CompilerGenerated]
		private HJFHBFBJOPE ECGAPJGANBL((GameObject, HBNDGNKPEKC) MFKMLFMHEOO)
		{
			return default(HJFHBFBJOPE);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class SkinnedMeshBonesInspector : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		[GHKDIKFNBMM(EBAHNMNBCJP.Self, false, false, false)]
		[SerializeField]
		private SkinnedMeshRenderer skinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		[SerializeField]
		private int BoneWeightsDisplayStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		[SerializeField]
		private int BoneWeightsDisplayAmount;

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE70", Offset = "0xA1CA70", VA = "0x180A1DE70")]
		public SkinnedMeshBonesInspector()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct HJFHBFBJOPE
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class PJJEFJHAMCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		public IEnumerable<OutfitType> otherOutfitTypes;

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public PJJEFJHAMCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x7C338A0", Offset = "0x7C324A0", VA = "0x187C338A0")]
		internal bool HACEELDOEJB(OutfitType outfitType)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	private FGFHPLNOLGF MPOHFHCEJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	private HBNDGNKPEKC HLGJGFBJPBO;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public FGFHPLNOLGF BHCEJCNKPMI
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public HBNDGNKPEKC GHADCCEDMPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0xDCF0E0", Offset = "0xDCDCE0", VA = "0x180DCF0E0")]
		get
		{
			return default(HBNDGNKPEKC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public string AMLAEGNGNCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x7C30300", Offset = "0x7C2EF00", VA = "0x187C30300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public bool CFGAKMOKMKC
	{
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x7C30260", Offset = "0x7C2EE60", VA = "0x187C30260")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool PCNPFBPOIAD
	{
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x7C302B0", Offset = "0x7C2EEB0", VA = "0x187C302B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x193B530", Offset = "0x193A130", VA = "0x18193B530")]
	public HJFHBFBJOPE(FGFHPLNOLGF BLPDIDCADLB, HBNDGNKPEKC PMGLBCDCDJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x7C303F0", Offset = "0x7C2EFF0", VA = "0x187C303F0")]
	public bool LIJMFECLIEF(OutfitType HEGODPMKOKD, HBNDGNKPEKC PECJCDPGHAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x7C306A0", Offset = "0x7C2F2A0", VA = "0x187C306A0")]
	public bool OPFCKOIFHFG(OutfitType HEGODPMKOKD, HBNDGNKPEKC PECJCDPGHAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x7C304B0", Offset = "0x7C2F0B0", VA = "0x187C304B0")]
	public bool MHFPMHNKKMH(HJFHBFBJOPE IOPMMODIFIO)
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
