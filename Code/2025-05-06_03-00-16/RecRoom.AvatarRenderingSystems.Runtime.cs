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
	public class LogRegistrationIndex : ONLGCKOFHPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7968910", Offset = "0x7967110", VA = "0x187968910", Slot = "4")]
		public override void JNEAPGDNFGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9E2460", Offset = "0x9E0C60", VA = "0x1809E2460", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override string AssetGUID
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x796D490", Offset = "0x796BC90", VA = "0x18796D490", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x796D420", Offset = "0x796BC20", VA = "0x18796D420", Slot = "17")]
		public override bool RuntimeKeyIsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x796D450", Offset = "0x796BC50", VA = "0x18796D450")]
		public RecNetCDNAssetReference(RecNetCDNKey BELIEAFHDAH)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class RecNetCDNKey
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public enum NHCFPHDMCOP : byte
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
			[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string UniqueItemIdentifier
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string CacheHash
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x9DF740", Offset = "0x9DDF40", VA = "0x1809DF740")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RecNetCDNKey Dependency
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x9DF790", Offset = "0x9DDF90", VA = "0x1809DF790")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x9DF780", Offset = "0x9DDF80", VA = "0x1809DF780")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool AttemptPrecacheLookup
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xA0BF30", Offset = "0xA0A730", VA = "0x180A0BF30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA0BCB0", Offset = "0xA0A4B0", VA = "0x180A0BCB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public NHCFPHDMCOP PathHint
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xD83040", Offset = "0xD81840", VA = "0x180D83040")]
			[CompilerGenerated]
			get
			{
				return default(NHCFPHDMCOP);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x12C97F0", Offset = "0x12C7FF0", VA = "0x1812C97F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string ItemPath
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x796D5A0", Offset = "0x796BDA0", VA = "0x18796D5A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x796D520", Offset = "0x796BD20", VA = "0x18796D520")]
		public static RecNetCDNKey PBNHLNANCHH(string OGKOPDOCIBJ, NHCFPHDMCOP JHIOBCHGHDM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x796D4D0", Offset = "0x796BCD0", VA = "0x18796D4D0")]
		public void DPALIFICLDF(string OLPIHBKGGPG, string EGAIPBFBDLP, bool BDBHEOMHGMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public RecNetCDNKey()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DBBJMDENMLB]
public class INJHGMNEEAG : GKBKIIEGCLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	protected readonly List<Mesh> GMCIILAJMPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	protected readonly List<byte[]> DPBMAKPJBCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	protected readonly List<Matrix4x4> NHDGPDEEHGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	protected readonly List<bool> LJHBDBMHMOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	protected readonly List<long> DMEEJNNPNAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	protected readonly List<bool> EPHLPONLMHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	protected readonly List<int> FJEAAOHJEFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	protected Allocator GOLJFMPANJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected DHGIOBOEMOO DNNIEHKBPCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected byte MHJKECPNDHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected IList<int> NPDNJAKGIGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected IList<int> GAFKDPJFIHC;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7967D30", Offset = "0x7966530", VA = "0x187967D30", Slot = "4")]
	public void DMAPEONODMJ(Mesh ABAPBBKNPBC, Matrix4x4 EFJJIALLDBB, byte[] GMHNAIDBKOB, bool OOBBFEAABPO = false, HHPKDLEJEOP.OOIFDIEICOH PCMEIMGHCGF = (HHPKDLEJEOP.OOIFDIEICOH)0L, int MKMIMOONMNK = -1, bool HOHMAILBEJD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7967CF0", Offset = "0x79664F0", VA = "0x187967CF0", Slot = "5")]
	public void BHPGFNGHEHN(Allocator KKCJNCNIICO, DHGIOBOEMOO BGGJAHNONJI, byte PIKFHPDFBNG, [Optional] IList<int> CHIAJBFBFLM, [Optional] IList<int> FLIGFOAOIPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7967FB0", Offset = "0x79667B0", VA = "0x187967FB0")]
	private static void GDFHHNMIEBA(Mesh ABAPBBKNPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7968210", Offset = "0x7966A10", VA = "0x187968210")]
	public INJHGMNEEAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[DBBJMDENMLB]
public struct MKLPFBACODF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	[ReadOnly]
	public ANFKCANLJJE HFLBBCHNHFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[ReadOnly]
	public int MLMCJFBMLGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public NAAANLOENHA FILCIAPKDHP;

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x79689A0", Offset = "0x79671A0", VA = "0x1879689A0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[NativeContainer]
[DBBJMDENMLB]
public struct NAAANLOENHA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct HGDBOELNDOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Vector3 JDKDMFEJLIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public Vector3 GLANACDLEOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public Vector4 EFPHCCMNKBP;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct FJLAPPKHAPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public float MGMCDCJGPKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public float IEKPDHCCPCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public float GDDGPJCFNNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public float DCKADEJJOHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public byte LEJGACBPNDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public byte GLCFPBJOMEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public byte OCHOMJHODIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public byte JFANKLAAKLO;
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct GELAAOOOFFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public half MGMCDCJGPKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public half IEKPDHCCPCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public half GDDGPJCFNNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public half DCKADEJJOHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public byte LEJGACBPNDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public byte GLCFPBJOMEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public byte OCHOMJHODIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public byte JFANKLAAKLO;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct EGABBINNDLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public half4 AGNHOOELDII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public half2 GEPMJKFEFFB;
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct KHOOJNOGKCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public half4 AGNHOOELDII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public half2 GEPMJKFEFFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public half2 EMMHCDHNBGE;
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct EBCFOCBJBEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public half4 AGNHOOELDII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public half2 GEPMJKFEFFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public half2 EMMHCDHNBGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public half2 HPFKILELFII;
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct MCKHNGOCCHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public half4 AGNHOOELDII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public half2 GEPMJKFEFFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public half2 EMMHCDHNBGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public half2 HPFKILELFII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public half2 PAHFOPJMONI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct IHMNJHLBFHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public float MGMCDCJGPKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public float IEKPDHCCPCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public float GDDGPJCFNNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public float DCKADEJJOHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int LEJGACBPNDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int GLCFPBJOMEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int OCHOMJHODIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int JFANKLAAKLO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct LDOJMPIIJOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Color AGNHOOELDII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Vector2 GEPMJKFEFFB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct NNOBOIKHBAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Color AGNHOOELDII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Vector2 GEPMJKFEFFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Vector2 EMMHCDHNBGE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct GIOCDCHNKFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Color AGNHOOELDII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Vector2 GEPMJKFEFFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Vector2 EMMHCDHNBGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Vector2 HPFKILELFII;
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct BKIHOKACHPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Color AGNHOOELDII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Vector2 GEPMJKFEFFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Vector2 EMMHCDHNBGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Vector2 HPFKILELFII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Vector2 PAHFOPJMONI;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private bool LCGGDLINJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<HGDBOELNDOO> DHCIAOICPNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<EGABBINNDLP> IICJGDOJIHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<KHOOJNOGKCK> HDCGEANGAFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<EBCFOCBJBEO> DBOOFFJKPHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<MCKHNGOCCHD> CAAFLOJIOPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<GELAAOOOFFK> CJNHAOKLLFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<FJLAPPKHAPC> ALOABAEMNPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NativeArray<LDOJMPIIJOK> IKGDDECHPCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NativeArray<NNOBOIKHBAL> GNDJKNOBADI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public NativeArray<GIOCDCHNKFN> JOEAAOGPOGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public NativeArray<BKIHOKACHPC> LDFLDJJJINA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public NativeArray<IHMNJHLBFHL> BPHGJGJMPND;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public NativeArray<int> APDDPPNIMDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public NativeArray<int> BKMOEANAHOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private NativeArray<int> PDHEPJABFMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NativeArray<int> NBJMDAGCIHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<int> LAIKAAELAAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public NativeArray<int> NMOGMKGOPAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public NativeArray<int> OGNEHHBJHJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public NativeArray<BoneWeight> KJMMFLCKLOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeArray<int> KIAKHLGFPAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private bool CNAALJEGBJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x159")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private bool EKFBLLOBFOA;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int EELKBEMMDFD
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x796C3A0", Offset = "0x796ABA0", VA = "0x18796C3A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x796ABF0", Offset = "0x79693F0", VA = "0x18796ABF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int HPBDDBNKMLN
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x796A460", Offset = "0x7968C60", VA = "0x18796A460")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x796BEE0", Offset = "0x796A6E0", VA = "0x18796BEE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int JKDJAIJFPMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x796BED0", Offset = "0x796A6D0", VA = "0x18796BED0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x796A470", Offset = "0x7968C70", VA = "0x18796A470")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int MLOIBNMILLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x796BEF0", Offset = "0x796A6F0", VA = "0x18796BEF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x796C7B0", Offset = "0x796AFB0", VA = "0x18796C7B0")]
	public NAAANLOENHA(int BIDKEEGHOIH, int FLDOODJDFIG, int DJAGAELMJMD, int KBDEMJGCIBK, Allocator KKCJNCNIICO, int AEFCKLBAFAE, JPLMFCPHLHI CGGJDFAMKFE, bool CNAALJEGBJK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x796A480", Offset = "0x7968C80", VA = "0x18796A480")]
	public void CNCMDDIJEHJ(int FPEOONOJHML, Vector3 AALALMNDJKO, Vector3 PEDIPEHLBOO, Vector4 NACLDKPPPKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x796BF70", Offset = "0x796A770", VA = "0x18796BF70")]
	public void PCCJOMOABCA(int FPEOONOJHML, BoneWeight AFHJFBNKCKJ, NativeSlice<byte> GMHNAIDBKOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x796BB40", Offset = "0x796A340", VA = "0x18796BB40")]
	public Color LJGPALENMAB(int FPEOONOJHML)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x796C3B0", Offset = "0x796ABB0", VA = "0x18796C3B0")]
	public void PJLOKKAFKNE(int FPEOONOJHML, Color JDLOGJMLBHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x796A840", Offset = "0x7969040", VA = "0x18796A840")]
	public void ICGNIBDFHEJ(byte COIKJNGOPIB, int FPEOONOJHML, Vector2 PKNKMPJDMGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x796BF60", Offset = "0x796A760", VA = "0x18796BF60")]
	public void ONKMJODFMKP(int FPEOONOJHML, int LCLBAPONGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x796BE70", Offset = "0x796A670", VA = "0x18796BE70")]
	public bool LLDECDINGCN(int COIKJNGOPIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x796A510", Offset = "0x7968D10", VA = "0x18796A510")]
	public void DJLCCDDGHGG(int EEPCCOOAMGI, int BFKGIFAKMAP, int IMNFCKGEMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x796A5E0", Offset = "0x7968DE0", VA = "0x18796A5E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x796AC00", Offset = "0x7969400", VA = "0x18796AC00")]
	public Mesh KNBKFICELPD([Optional] string JBOCJAMDNJG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
[DBBJMDENMLB]
[NativeContainer]
public struct ANFKCANLJJE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public Mesh.MeshDataArray MHLHDLDMGNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public NativeArray<int> COJPHJAMINH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public NativeArray<int> LKLCKBBNHGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public NativeArray<BoneWeight> KJMMFLCKLOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private NativeArray<Matrix4x4> FAINNGILNGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private NativeArray<long> MBDKEKPADNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private NativeArray<byte> ACAMLLJMHEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private NativeArray<int> HEDPJBGABIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private NativeArray<int> DPGDHOCJBEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public NativeArray<sbyte> HIIFLKDLBBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public NativeArray<byte> PHOCPKMJFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public NativeArray<bool> HOHMAILBEJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NativeArray<int> MKMIMOONMNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private bool CNAALJEGBJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeArray<int> BOMLANFBMPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private bool EKFBLLOBFOA;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int EKEAAMJKMAE
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x79579A0", Offset = "0x79561A0", VA = "0x1879579A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int LNFNCHLJPFF
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7957870", Offset = "0x7956070", VA = "0x187957870")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int LBBFFEDGGFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x79579B0", Offset = "0x79561B0", VA = "0x1879579B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int CDPEOHACFGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7957960", Offset = "0x7956160", VA = "0x187957960")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7957A90", Offset = "0x7956290", VA = "0x187957A90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int EELKBEMMDFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7957A80", Offset = "0x7956280", VA = "0x187957A80")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7957980", Offset = "0x7956180", VA = "0x187957980")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int JFIJMGNPGBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7957AB0", Offset = "0x79562B0", VA = "0x187957AB0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7957AA0", Offset = "0x79562A0", VA = "0x187957AA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public DHGIOBOEMOO BFEGAHBOKIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7957970", Offset = "0x7956170", VA = "0x187957970")]
		get
		{
			return default(DHGIOBOEMOO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x79576E0", Offset = "0x7955EE0", VA = "0x1879576E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public byte NDONKFFGKAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7957990", Offset = "0x7956190", VA = "0x187957990")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7957880", Offset = "0x7956080", VA = "0x187957880")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public ELOMEJKCPKH EMAHJNALJJD
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7957490", Offset = "0x7955C90", VA = "0x187957490")]
		get
		{
			return default(ELOMEJKCPKH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7957AC0", Offset = "0x79562C0", VA = "0x187957AC0")]
	public ANFKCANLJJE(IList<Mesh> OODOBGLCLDP, IList<Matrix4x4> MEBOBDABIFI, IList<bool> HOHMAILBEJD, byte PIKFHPDFBNG, IList<byte[]> BEPALNMFNGK, IList<long> MFGPEPCMMEP, IList<bool> OPNNCCCOEDO, IList<int> MKMIMOONMNK, IList<int> CHIAJBFBFLM, IList<int> MHBADMKPEEO, Allocator KKCJNCNIICO, DHGIOBOEMOO BGGJAHNONJI, bool CNAALJEGBJK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7957890", Offset = "0x7956090", VA = "0x187957890")]
	public NAAANLOENHA INFOPLADKMH(Allocator KKCJNCNIICO, JPLMFCPHLHI CGGJDFAMKFE)
	{
		return default(NAAANLOENHA);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x79576F0", Offset = "0x7955EF0", VA = "0x1879576F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DBBJMDENMLB]
public class IHNKAANLKLM : INJHGMNEEAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public bool LPJINFECKPO;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly ProfilerMarker BGBEBODPBPG;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x79679E0", Offset = "0x79661E0", VA = "0x1879679E0")]
	public ANFKCANLJJE OMLLALJIBGC()
	{
		return default(ANFKCANLJJE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7967CE0", Offset = "0x79664E0", VA = "0x187967CE0")]
	public IHNKAANLKLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct ELOMEJKCPKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public Mesh.MeshData GJDMHJPDODH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public NativeSlice<BoneWeight> KJMMFLCKLOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public NativeSlice<byte> GBJHOHKGENL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public int OMGIPLEPLOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public Matrix4x4 PPOHNAMANDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public long DOAJGOPDLJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public NativeSlice<byte> GMHNAIDBKOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public bool MEDEIDLELGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public int IPOBOLKGMLO;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class HLFKGFHMNDN : MKBPDMPFCMC
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class JFLGHIPLLIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public MCGPNNFIPKM avatarBuildParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public HLFKGFHMNDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public LLDEFGHLBOH buildMeshPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public Action<KeyValuePair<string, GOANNPAHNKI<Texture2D>>> <>9__19;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public JFLGHIPLLIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x79686A0", Offset = "0x7966EA0", VA = "0x1879686A0")]
		internal bool BDKKKHPHPIO(KNAIBICOJFM item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x79687E0", Offset = "0x7966FE0", VA = "0x1879687E0")]
		internal void IFNMDBHIPBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x79688F0", Offset = "0x79670F0", VA = "0x1879688F0")]
		internal void LJGNANDDIIN(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x79687E0", Offset = "0x7966FE0", VA = "0x1879687E0")]
		internal void JNPPCOLAOFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x79688F0", Offset = "0x79670F0", VA = "0x1879688F0")]
		internal void PCPNONAJPIF(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x79687B0", Offset = "0x7966FB0", VA = "0x1879687B0")]
		internal void FIPLNDIIEDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7968800", Offset = "0x7967000", VA = "0x187968800")]
		internal void ILNGPFEONGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7968830", Offset = "0x7967030", VA = "0x187968830")]
		internal void KNFPFGJIEOF(Dictionary<string, GOANNPAHNKI<Texture2D>> resourceHandleDictionary)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x79686F0", Offset = "0x7966EF0", VA = "0x1879686F0")]
		internal void FDPNGDBFGKA(KeyValuePair<string, GOANNPAHNKI<Texture2D>> kvp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730")]
		internal ELBPMMKABPA INDBMMFDBHA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class HCIEIKJLOBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public int lowestPossibleLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public JFLGHIPLLIA CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public HCIEIKJLOBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x795A730", Offset = "0x7958F30", VA = "0x18795A730")]
		internal OKGKMNPHJLF PNEEGLDNNCN(int lod)
		{
			return default(OKGKMNPHJLF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class IMECGBDHJJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public KJPDFMLMKLI<Dictionary<string, GOANNPAHNKI<Texture2D>>> ugcTextureDictionaryPromise;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public IMECGBDHJJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		internal KJPDFMLMKLI<Dictionary<string, GOANNPAHNKI<Texture2D>>> HIBDGPPJNNL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class DFINNDNMFBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public List<LLDEFGHLBOH> innerPromises;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public DFINNDNMFBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x795A600", Offset = "0x7958E00", VA = "0x18795A600")]
		internal void ONLBEOGMHGB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class HHNDIDBINPG : IEnumerator<IGCELENFGND>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private IGCELENFGND <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public bool shouldWait;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public HLFKGFHMNDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public List<BFFBFCDHOIA> parts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public List<LLDEFGHLBOH> innerPromises;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public bool isFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public Func<int, OKGKMNPHJLF> getLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public ICEACEDDBKN materialPropertyBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public Material materialInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private int <lodIndex>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private IGCELENFGND System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF30", Offset = "0x9EA730", VA = "0x1809EBF30")]
		[DebuggerHidden]
		public HHNDIDBINPG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x795A7F0", Offset = "0x7958FF0", VA = "0x18795A7F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x795AA70", Offset = "0x7959270", VA = "0x18795AA70", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class HLCKPDFKALB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public EAALJLDPGGJ cancelable;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public HLCKPDFKALB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0xA6E010", Offset = "0xA6C810", VA = "0x180A6E010")]
		internal void DGIDBAHJOFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0xCBEA10", Offset = "0xCBD210", VA = "0x180CBEA10")]
		internal void JBBABGKPCME(string err)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class KNOCJLBJONC
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
		public HLFKGFHMNDN <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public KNOCJLBJONC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class ONKJODOMOFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public NAAANLOENHA defaultMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public ANFKCANLJJE defaultAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public KNOCJLBJONC CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public ONKJODOMOFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x796D1E0", Offset = "0x796B9E0", VA = "0x18796D1E0")]
		internal void CFECIAJAIKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x122E9B0", Offset = "0x122D1B0", VA = "0x18122E9B0")]
		internal void DOJCICJGACD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class JCOCBIDKLPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public MGBOFKJAJDI legacyMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public NCPCEJIIOIK legacyAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public KNOCJLBJONC CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public JCOCBIDKLPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7968460", Offset = "0x7966C60", VA = "0x187968460")]
		internal void FKBPNFHPCMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x1230300", Offset = "0x122EB00", VA = "0x181230300")]
		internal void BJANFAOGJLH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class IECLIMLCEOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public string overrideItemIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public PNLIIGCPIIK overrideBodyPart;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public IECLIMLCEOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7967960", Offset = "0x7966160", VA = "0x187967960")]
		internal bool GMDPLMIMDPE(KeyValuePair<string, KNAIBICOJFM> entry)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly FIEKIAHLEMJ FHKCMAJJKDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly FIEKIAHLEMJ MPPNHNJIKLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Dictionary<JIFBLNLKJIG, float> OMOODCGLPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private Dictionary<CNOECLPIEKB, float> FFFINHBGCDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Dictionary<FEBPCDMMGMN, float> LGCIIIIHKFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private IReadOnlyDictionary<string, DOBLLPEHFPB> FOBGMOLMDBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Dictionary<string, DOBLLPEHFPB> LACMMDOBOIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Dictionary<string, DOBLLPEHFPB> NHHHGAKCGNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private Dictionary<string, DOBLLPEHFPB> GCIKMICDMOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private GKEGCDPOLMK CCBMHOMGEPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private GKEGCDPOLMK MKACPKPJKAH;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static float NCANCLMPMAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private bool? MGGLIILHKEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x62")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private bool? FPCIGJKBAMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private bool? GKFGHGILAEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x66")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private bool? ANOBNNHHMEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private AvatarConfiguration ODNNODMMNJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private Transform FIHAMEBDHKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private AvatarSkinAssetItem JIBFCNOIFOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private AssetReference FOBOONIHGJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private GameObject JMIDAOGKCNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private GameObject MPAJDKAAEHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private SkinnedMeshRenderer AHCHDKHHMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private AvatarSkinnedMeshBoneOrderRemapsData FONHGFEBLGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private Transform[] PFKBEIGJBBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private Matrix4x4[] HBIKJBFLKAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private Material ICLOJJKOOFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private Material LDPANIAKMNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private Material EJOCKINOEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private Shader NPKINIKJPJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private Shader MJGHGNBHAIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Animator JELBAGIHDIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private Renderer[] IDOLHCAFMOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private HHPKDLEJEOP.OOIFDIEICOH FPAGDLMNHBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private AvatarBodyPartShapesManager AIDMCPENLDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private IReadOnlyDictionary<string, Transform> PEGGCMLCFLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private AvatarFaceShapeData.KHOFAFCPDPE FCANKHILOOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private AvatarBodyShapeData.IKDIGDKBAMJ OLIOCHPPFIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private DPOJOKMIJDG DLFILOPMMAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private bool FGMGJMAFCBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x115")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private bool NMNNMNMHHGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private Color JCMFDJPJIBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private Color OEKNJALJCMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private Color MCGNNDAJDPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private Color? JFOCCLHLACN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15C")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private Color? MJFCHNGCEKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private Color? KGKGBIEGBNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private Color? BJCPCPPABIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private Texture2D LMHAHJLADJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private Texture2D NAMAKHFAEOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	[CanBeNull]
	private KNAIBICOJFM MCHAEOPEJJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private Texture FALFCIHCAKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private Color PMBKDACHFBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public Dictionary<Renderer, ICEACEDDBKN> LIGGMIGGGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private Dictionary<Renderer, ICEACEDDBKN> EIHBDKDELDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private Dictionary<string, List<IKOFHHAONMF>> KLAAFNIAIBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private Dictionary<string, List<IKOFHHAONMF>> GEPPAPKPIIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly List<IAIDKAIACPE> GCKELKPAHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly List<IAIDKAIACPE> OMJFNONMMNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly List<IAIDKAIACPE> CFCFBHPKJCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly List<IAIDKAIACPE> LIGJEAIDAJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private Dictionary<IKOFHHAONMF, Material> ADPJPNKLOAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private Dictionary<IKOFHHAONMF, Material> IPEKDBBLPCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private SkinnedMeshRenderer[] INFDDJOHMKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private SkinnedMeshRenderer[] KABDAMEEFBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private SkinnedMeshRenderer[] KDMFJKAFIOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private SkinnedMeshRenderer[] EJONICINPFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Dictionary<string, GOANNPAHNKI<Texture2D>> CHJENBKDCAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly Dictionary<string, GOANNPAHNKI<Texture2D>> FCKPNFPIMBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private AdditionalHatData IGBNEGEJIPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private AdditionalHatData ALJKNPAHKAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private HairData EEMDIDFEOFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private HairData HLDAFMFPIPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private PNINFJFLLCD PFHJBKHPMIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private bool? NLDJBGMKMFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x274")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private PositionAndRotation HMPMDIDPOPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private Transform JBDMKOMEGDL;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private Material MBCNJEIEEPM;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private Material BAKCLMJDFGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private Dictionary<string, KNAIBICOJFM> FFCHMJAJNOO;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static readonly int HFHAKLBPDAE;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static readonly int DALEPHNPMKG;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static readonly int FJALLMJILEF;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly int ABHELKOKCBB;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly int FKBDIJMCCDE;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly int CFIBMLHJJCI;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly int JDGLOFBNNFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private bool ICFFHKLIAPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private List<Action> BKGJBPNGIID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private NLDCDOOJMDE HFALMBBKIAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private SkinnedMeshRenderer[] HOFMEGKMOEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private int HMIBFHBCDMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D4")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private bool ACCIHNFEJCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private int IKOIFAIJFME;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public FIEKIAHLEMJ HLILNHINGBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public FIEKIAHLEMJ MHDOBKLNFIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private AGPOKEKNOGC HFMDFHLKMEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x795C350", Offset = "0x795AB50", VA = "0x18795C350")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool AALELGCDAEB
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x795D430", Offset = "0x795BC30", VA = "0x18795D430")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private bool BBDFFCKLDEB
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7965DF0", Offset = "0x79645F0", VA = "0x187965DF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private bool MHDCJCBFCMD
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x795C450", Offset = "0x795AC50", VA = "0x18795C450")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private bool EIKKEJLIBDF
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x795CE20", Offset = "0x795B620", VA = "0x18795CE20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public AvatarConfiguration OLGDJBFMBNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1C0", Offset = "0x9DB9C0", VA = "0x1809DD1C0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool IEMAMIOFEPL
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x134B330", Offset = "0x1349B30", VA = "0x18134B330")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x25675D0", Offset = "0x2565DD0", VA = "0x1825675D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private Material LFFDMDPKHJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7965460", Offset = "0x7963C60", VA = "0x187965460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private Material LGPNINNONBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7962A00", Offset = "0x7961200", VA = "0x187962A00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private bool HAIFIFEKBGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x9F9540", Offset = "0x9F7D40", VA = "0x1809F9540")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public DODMAGIBHBA DCHHGBFKGNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x11ADA20", Offset = "0x11AC220", VA = "0x1811ADA20", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return default(DODMAGIBHBA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x11AE270", Offset = "0x11ACA70", VA = "0x1811AE270")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public Material CGKGFEEIOEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xCAAF00", Offset = "0xCA9700", VA = "0x180CAAF00", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public SkinnedMeshRenderer[] OALOIICJDLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x1BE76F0", Offset = "0x1BE5EF0", VA = "0x181BE76F0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public Renderer[] OENIBLCKENM
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xA7B0F0", Offset = "0xA798F0", VA = "0x180A7B0F0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool HLOKIGENLJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x79665E0", Offset = "0x7964DE0", VA = "0x1879665E0", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public HHPKDLEJEOP.OOIFDIEICOH JDBCHMHEKFG
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xA74730", Offset = "0xA72F30", VA = "0x180A74730", Slot = "20")]
		get
		{
			return default(HHPKDLEJEOP.OOIFDIEICOH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int CNAELNJIJHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x11AC990", Offset = "0x11AB190", VA = "0x1811AC990")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x795D5F0", Offset = "0x795BDF0", VA = "0x18795D5F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private bool OLCMDPKCJBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7961130", Offset = "0x795F930", VA = "0x187961130")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private static bool CBMMGECAOKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x79615E0", Offset = "0x795FDE0", VA = "0x1879615E0", Slot = "15")]
	public LLDEFGHLBOH HOCBAENHILJ(MCGPNNFIPKM LDFONGCNDBA, bool MNFBONIMPPG, int[] NFJGPMPHDCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7963D00", Offset = "0x7962500", VA = "0x187963D00", Slot = "14")]
	public LLDEFGHLBOH LEKJMINPINB(MCGPNNFIPKM LDFONGCNDBA, bool MNFBONIMPPG, int[] NFJGPMPHDCD, Func<Dictionary<string, KNAIBICOJFM>, (LLDEFGHLBOH, KJPDFMLMKLI<Dictionary<string, GOANNPAHNKI<Texture2D>>>)> EIEICEINNEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x795EE80", Offset = "0x795D680", VA = "0x18795EE80")]
	public LLDEFGHLBOH FNENLLJGPKO(MCGPNNFIPKM LDFONGCNDBA, bool MNFBONIMPPG, int[] NFJGPMPHDCD, bool PLEACLDAABG, GKEGCDPOLMK IPHOFPGDPGH, [Optional] Func<Dictionary<string, KNAIBICOJFM>, (LLDEFGHLBOH, KJPDFMLMKLI<Dictionary<string, GOANNPAHNKI<Texture2D>>>)> EIEICEINNEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x795D9E0", Offset = "0x795C1E0", VA = "0x18795D9E0")]
	private bool FKFAFMHIJAB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x79667E0", Offset = "0x7964FE0", VA = "0x1879667E0")]
	private LLDEFGHLBOH PNAMOBEDDNO(bool MNFBONIMPPG, List<BFFBFCDHOIA> FIJIAOGGNAK, int[] NFJGPMPHDCD, Func<int, OKGKMNPHJLF> PNKACPKDJIJ, bool PLEACLDAABG = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x795D620", Offset = "0x795BE20", VA = "0x18795D620")]
	[IteratorStateMachine(typeof(HHNDIDBINPG))]
	private IEnumerator<IGCELENFGND> EMFIFNHDPHB(bool MNFBONIMPPG, List<BFFBFCDHOIA> FIJIAOGGNAK, int[] NFJGPMPHDCD, Func<int, OKGKMNPHJLF> PNKACPKDJIJ, ICEACEDDBKN KFBAIGJGEEM, Material JACFHOAGGKK, List<LLDEFGHLBOH> AFKPDKIPGIO, bool HINCJFFOLIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7961F10", Offset = "0x7960710", VA = "0x187961F10")]
	private void JPKBNGDBCIC(List<BFFBFCDHOIA> FIJIAOGGNAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7965F60", Offset = "0x7964760", VA = "0x187965F60")]
	private LLDEFGHLBOH OHGLFFHDDOB(List<BFFBFCDHOIA> FIJIAOGGNAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x795DAB0", Offset = "0x795C2B0", VA = "0x18795DAB0")]
	private KIJPFMOACHH FKIEAKGCHIJ(List<BFFBFCDHOIA> FIJIAOGGNAK, int BIPGHKPGBAC, bool MNFBONIMPPG, OKGKMNPHJLF JGBCIPMOKIK, bool DAAGHMNPIKE, ICEACEDDBKN KFBAIGJGEEM, Material JACFHOAGGKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x795C0D0", Offset = "0x795A8D0", VA = "0x18795C0D0", Slot = "27")]
	public void BDJBNBKPIDF(JIFBLNLKJIG OFFLKMPHDPK, float OPMIAMEJKDH, bool FJKHIBKGEGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7960AE0", Offset = "0x795F2E0", VA = "0x187960AE0", Slot = "29")]
	public void FNGEGPGBEJL(CNOECLPIEKB JJOCGLIBDAN, float OPMIAMEJKDH, bool CJPNFEMOAFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x795D360", Offset = "0x795BB60", VA = "0x18795D360", Slot = "30")]
	public void DJIIGNKFHOE(FEBPCDMMGMN KKCCMLIGNFL, float OPMIAMEJKDH, bool OCPMNHGHALD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7962C60", Offset = "0x7961460", VA = "0x187962C60", Slot = "28")]
	public void KKLENOJLJEE(bool LMENICCMMEJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x795AAC0", Offset = "0x79592C0", VA = "0x18795AAC0", Slot = "31")]
	public void AEKGOCAPFJB(bool LMENICCMMEJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x79652C0", Offset = "0x7963AC0", VA = "0x1879652C0", Slot = "32")]
	public void NFBIBIOLEIG(bool LMENICCMMEJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x795D940", Offset = "0x795C140", VA = "0x18795D940")]
	private void FGEDPOIDOBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x795D2D0", Offset = "0x795BAD0", VA = "0x18795D2D0")]
	private void DHDAMFGGLFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7961610", Offset = "0x795FE10", VA = "0x187961610")]
	private void IDONKGDHKGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7961E50", Offset = "0x7960650", VA = "0x187961E50", Slot = "25")]
	public void JOJGJAOKGGM(AvatarFaceShape JFHNLKMCHKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7961690", Offset = "0x795FE90", VA = "0x187961690", Slot = "26")]
	public void ILGFKGMMLCB(AvatarBodyShape NAPFJCHLPMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x22D92A0", Offset = "0x22D7AA0", VA = "0x1822D92A0", Slot = "33")]
	public void MPOCLFKLNON(DPOJOKMIJDG BCGOGBNIGIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x795CA40", Offset = "0x795B240", VA = "0x18795CA40", Slot = "35")]
	public void CJFPLGIHMKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7963BC0", Offset = "0x79623C0", VA = "0x187963BC0", Slot = "38")]
	public void LEIFMEOCDCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x795D350", Offset = "0x795BB50", VA = "0x18795D350", Slot = "34")]
	public void DIPJFOOBABH(bool EEAOOBHHOMF, bool JEGHNMNFCDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x795ED30", Offset = "0x795D530", VA = "0x18795ED30")]
	private void FLPMCELNALC(SkinnedMeshRenderer FHFCGBBDOEL, int BIPGHKPGBAC, Mesh ABAPBBKNPBC, List<Material> NEJIEFGEHEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7964890", Offset = "0x7963090", VA = "0x187964890")]
	private static Material MCLCFFHDNIE(Dictionary<IKOFHHAONMF, Material> EPLFLDCEKNL, Material HKHBPBHJKNG, NMINLHPKGCA DEODPNNAHDB, CIPOGJIBMCP IHEENGIGNMA, PNLIIGCPIIK MDILONMHHMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7961CB0", Offset = "0x79604B0", VA = "0x187961CB0")]
	private static NMINLHPKGCA JMBIGBGACMF(BFFBFCDHOIA JJIPHMPADLA, int OKBBCMAODEN)
	{
		return default(NMINLHPKGCA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7961830", Offset = "0x7960030", VA = "0x187961830")]
	private void IONHJJMIBKF(int JNNOAPGEOAD, Material OALKCGACMLD, BFFBFCDHOIA JJIPHMPADLA, [Out] Texture2D MIMNOJIBEOO, [Out] Vector4 NLIHHMJECOI, [Out] Texture2D EFOLEOBBCCL, [Out] Texture2D ADBCLAFKJJH, [Out] Texture2D IGCFGPLGGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7963FB0", Offset = "0x79627B0", VA = "0x187963FB0")]
	private void LPPIGMNHKDJ(int JNNOAPGEOAD, Material OALKCGACMLD, BFFBFCDHOIA JJIPHMPADLA, [Out] Color FPFEOKGHPHB, [Out] Color PDFDAEFEJLA, [Out] Color CMKKLECIAMK, [Out] Color BFOBPBHBHKF, [Out] Color GOEMDOOCABH, [Out] Color LDHHMAHGKGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x79661B0", Offset = "0x79649B0", VA = "0x1879661B0")]
	private bool PBNKEABGHDG(Material OALKCGACMLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7962CC0", Offset = "0x79614C0", VA = "0x187962CC0")]
	private static Material KMGLKIKCEJK(int JNNOAPGEOAD, HPLJIJMACAO JJIPHMPADLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x795D510", Offset = "0x795BD10", VA = "0x18795D510")]
	private static CIPOGJIBMCP EAAPDIAMCAE(BFFBFCDHOIA JJIPHMPADLA, int OKBBCMAODEN)
	{
		return default(CIPOGJIBMCP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x795ABD0", Offset = "0x79593D0", VA = "0x18795ABD0")]
	private static void AIGCANJJDHC(Dictionary<string, List<IKOFHHAONMF>> BGBFHIDBILE, BFFBFCDHOIA DHBOFLCIJIE, Material HKHBPBHJKNG, NMINLHPKGCA IFFOBJIAHML, CIPOGJIBMCP GNABHHKCLPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7965BC0", Offset = "0x79643C0", VA = "0x187965BC0")]
	private static SkinnedMeshRenderer OBLJJGMMIFB(Transform LMNGIIFNMCO, Transform FGEOGLPINHD, SkinnedMeshRenderer[] OIMBCHPJGIF, int BIPGHKPGBAC, OKGKMNPHJLF JGBCIPMOKIK, bool MNFBONIMPPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7966FC0", Offset = "0x79657C0", VA = "0x187966FC0")]
	public HLFKGFHMNDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7965850", Offset = "0x7964050", VA = "0x187965850")]
	public void NPIOKLMMDIH([In] EDPBDFELEDH BOEOCKNDNIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x795AB50", Offset = "0x7959350", VA = "0x18795AB50")]
	public void NBMDJKMLJEF([In] EKBHECGFNJC MCPBLJPDPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x795D5F0", Offset = "0x795BDF0", VA = "0x18795D5F0", Slot = "5")]
	public void HMBLCMCOFMO(int BIPGHKPGBAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x795AE80", Offset = "0x7959680", VA = "0x18795AE80", Slot = "10")]
	public void AJHGDFMDPHA(HJAGPJFAJIO GNABHHKCLPK, Texture2D OAGLIKEGCPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x9F9540", Offset = "0x9F7D40", VA = "0x1809F9540")]
	public static bool LJAHKHJBCGH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7965600", Offset = "0x7963E00", VA = "0x187965600", Slot = "11")]
	public bool NKCELOCBDDK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7960BC0", Offset = "0x795F3C0", VA = "0x187960BC0", Slot = "9")]
	public void GNHKIJLCOIB(ODFNGAHMFGO IFFOBJIAHML, Color? AGNHOOELDII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7966560", Offset = "0x7964D60", VA = "0x187966560")]
	private void PEODJLLPMBF(Action FAFFDFAKIJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7961C40", Offset = "0x7960440", VA = "0x187961C40", Slot = "6")]
	public void JLFGPFMCOBG(KNAIBICOJFM GKIGDKILOIE, Texture DNLILGKBBFL, Color BGFOOAMOCAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x25675D0", Offset = "0x2565DD0", VA = "0x1825675D0", Slot = "7")]
	public void JPNNOELNCCK(bool HINCJFFOLIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1307700", Offset = "0x1305F00", VA = "0x181307700", Slot = "8")]
	public void MMOLDMLMOIC(NLDCDOOJMDE KIAKHLGFPAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x795D740", Offset = "0x795BF40", VA = "0x18795D740", Slot = "16")]
	public void FBJANABPJBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7963DC0", Offset = "0x79625C0", VA = "0x187963DC0", Slot = "36")]
	public void LKAFPMMLMEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x795B0A0", Offset = "0x79598A0", VA = "0x18795B0A0", Slot = "37")]
	public void BAFNFFCPHHF([Optional] PNINFJFLLCD KKJGLMBGHPB, [Optional] bool? DIIFGDNLAHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7965320", Offset = "0x7963B20", VA = "0x187965320")]
	private bool NIBMKBPILDM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7965BA0", Offset = "0x79643A0", VA = "0x187965BA0", Slot = "21")]
	public bool OBFGAMJMGPO(HHPKDLEJEOP.OOIFDIEICOH NKHMCDBPGOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x795C850", Offset = "0x795B050", VA = "0x18795C850")]
	private void BPKKPBHIMGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7960FC0", Offset = "0x795F7C0", VA = "0x187960FC0")]
	private void HABILDGBKPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x795CF80", Offset = "0x795B780", VA = "0x18795CF80")]
	private static void CNNGBOAFAMM(Dictionary<IKOFHHAONMF, Material> EPLFLDCEKNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7960FD0", Offset = "0x795F7D0", VA = "0x187960FD0")]
	private static void HANNGEJFCDN(Dictionary<Renderer, ICEACEDDBKN> GEFDGNPDLCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x795D0E0", Offset = "0x795B8E0", VA = "0x18795D0E0")]
	private void DBOJFBLLJCG(SkinnedMeshRenderer[] OIMBCHPJGIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7961DB0", Offset = "0x79605B0", VA = "0x187961DB0")]
	private void JMCPAMMLGPM(SkinnedMeshRenderer CCHCFBGLLFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7965020", Offset = "0x7963820", VA = "0x187965020")]
	private void NAKPPBGELPM(List<IAIDKAIACPE> AIDIFDOIBFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x795EBB0", Offset = "0x795D3B0", VA = "0x18795EBB0")]
	private void FLBICCMAILL(Dictionary<string, GOANNPAHNKI<Texture2D>> BGBFHIDBILE, bool PGLIEOINGLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x795CF30", Offset = "0x795B730", VA = "0x18795CF30")]
	private void CMJLAEKELFB(Dictionary<string, List<IKOFHHAONMF>> BGBFHIDBILE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x79649F0", Offset = "0x79631F0", VA = "0x1879649F0")]
	private void MEKDBPCGAND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x795C530", Offset = "0x795AD30", VA = "0x18795C530")]
	private void BLCKDIEJCMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7963270", Offset = "0x7961A70", VA = "0x187963270")]
	private void LDJHADEHANL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x795D200", Offset = "0x795BA00", VA = "0x18795D200")]
	private void DDNABIGKCNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7965ED0", Offset = "0x79646D0", VA = "0x187965ED0")]
	private void OFFCMLJGDNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7966410", Offset = "0x7964C10", VA = "0x187966410")]
	private void PECLBADNBJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7962900", Offset = "0x7961100", VA = "0x187962900")]
	private void KAKIDDCBGHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7965770", Offset = "0x7963F70", VA = "0x187965770")]
	private void NNGGLNHGJDG(bool CLFFCJHKCFH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x795C780", Offset = "0x795AF80", VA = "0x18795C780")]
	private void BODEJJPHLJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7961750", Offset = "0x795FF50", VA = "0x187961750")]
	private void IMHOIPPAGCE(bool CLFFCJHKCFH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7962F50", Offset = "0x7961750", VA = "0x187962F50")]
	private void KMMCCFFDGEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7964B40", Offset = "0x7963340", VA = "0x187964B40")]
	private void MOLEAAOEBIA(Material JACFHOAGGKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7961350", Offset = "0x795FB50", VA = "0x187961350")]
	private void HJHNOINNHPH(Material JACFHOAGGKK, Color FLCOAHLNKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7962D10", Offset = "0x7961510", VA = "0x187962D10")]
	private void KMKCEDPNIDL(Material JACFHOAGGKK, Color FLCOAHLNKBD, Color JOLEPPOOGNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7963E20", Offset = "0x7962620", VA = "0x187963E20")]
	private void LKOFMOOOHEH(Material JACFHOAGGKK, Color FPFEOKGHPHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x795BEE0", Offset = "0x795A6E0", VA = "0x18795BEE0")]
	private void BCPKEKIMIEP(Material JACFHOAGGKK, Texture2D OAGLIKEGCPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x795C1F0", Offset = "0x795A9F0", VA = "0x18795C1F0")]
	private void BGHCLABEONM(Material JACFHOAGGKK, Texture DDFLPPIKLIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7962B00", Offset = "0x7961300", VA = "0x187962B00")]
	private void KKEDOFLNMBA(Action<ICEACEDDBKN> FMLBEBMIKMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x79611B0", Offset = "0x795F9B0", VA = "0x1879611B0")]
	private void HHEJDOLGFBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7964470", Offset = "0x7962C70", VA = "0x187964470")]
	private void MBPBGCJDJEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7962530", Offset = "0x7960D30", VA = "0x187962530")]
	private void JPMOGJFGNGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7963830", Offset = "0x7962030", VA = "0x187963830")]
	public void LEEJKEIBAOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x795AB50", Offset = "0x7959350", VA = "0x18795AB50", Slot = "4")]
	private void AHHBDJFEPJP([In] EKBHECGFNJC MCPBLJPDPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x795C1B0", Offset = "0x795A9B0", VA = "0x18795C1B0")]
	[CompilerGenerated]
	private ELBPMMKABPA BGHBFFKEJNK(BFFBFCDHOIA GOHMPMCJCDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7961550", Offset = "0x795FD50", VA = "0x187961550")]
	[CompilerGenerated]
	private void HMBNBKGNCHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7965200", Offset = "0x7963A00", VA = "0x187965200")]
	[CompilerGenerated]
	private void NDFAKGNJKJG(ICEACEDDBKN NBOBEHBFADD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x7963D30", Offset = "0x7962530", VA = "0x187963D30")]
	[CompilerGenerated]
	private void LFHLPHBKBKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x795D9C0", Offset = "0x795C1C0", VA = "0x18795D9C0")]
	[CompilerGenerated]
	private void FJNFFAOEKFB(ICEACEDDBKN NBOBEHBFADD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7966750", Offset = "0x7964F50", VA = "0x187966750")]
	[CompilerGenerated]
	private void PHDNEEKDNLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7961330", Offset = "0x795FB30", VA = "0x187961330")]
	[CompilerGenerated]
	private void HIOPBLJJBOC(ICEACEDDBKN NBOBEHBFADD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x795C6C0", Offset = "0x795AEC0", VA = "0x18795C6C0")]
	[CompilerGenerated]
	private void BMGGEIIFLOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7966E40", Offset = "0x7965640", VA = "0x187966E40")]
	[CompilerGenerated]
	private void POPLBNGKMAB(ICEACEDDBKN NBOBEHBFADD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x79614C0", Offset = "0x795FCC0", VA = "0x1879614C0")]
	[CompilerGenerated]
	private void HLIFOMPGJFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x795CF00", Offset = "0x795B700", VA = "0x18795CF00")]
	[CompilerGenerated]
	private void CMDEJELJFBH(ICEACEDDBKN NBOBEHBFADD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7965230", Offset = "0x7963A30", VA = "0x187965230")]
	[CompilerGenerated]
	private void NEFFMEOMFKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x795C750", Offset = "0x795AF50", VA = "0x18795C750")]
	[CompilerGenerated]
	private void BNHAIOJONMN(ICEACEDDBKN NBOBEHBFADD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x795C3C0", Offset = "0x795ABC0", VA = "0x18795C3C0")]
	[CompilerGenerated]
	private void BHJBFHFFPHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x795CA10", Offset = "0x795B210", VA = "0x18795CA10")]
	[CompilerGenerated]
	private void CACLLIPPCCM(ICEACEDDBKN NBOBEHBFADD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7966DC0", Offset = "0x79655C0", VA = "0x187966DC0")]
	[CompilerGenerated]
	private void PNCEAIGOKMA(KeyValuePair<string, GOANNPAHNKI<Texture2D>> KLDHFHKDFJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x795D610", Offset = "0x795BE10", VA = "0x18795D610")]
	[CompilerGenerated]
	private void ELEPBJFDAIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x795AB20", Offset = "0x7959320", VA = "0x18795AB20")]
	[CompilerGenerated]
	private void AFAOEDLJFDO(ICEACEDDBKN NBOBEHBFADD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7962AF0", Offset = "0x79612F0", VA = "0x187962AF0")]
	[CompilerGenerated]
	private void KHEPCFDGJCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x79629D0", Offset = "0x79611D0", VA = "0x1879629D0")]
	[CompilerGenerated]
	private void KBHEGCFFCLH(ICEACEDDBKN NBOBEHBFADD)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class AvatarElbowBendHelperController : MonoBehaviour, KGKIJCCCBBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		[DAFFCFHPHBO(HNCMILCNFNF.Self, false, false, false)]
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
		private Vector3? ALNCKCIDIPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private bool CEABMGJLCJG;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7958CB0", Offset = "0x79574B0", VA = "0x187958CB0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x79592D0", Offset = "0x7957AD0", VA = "0x1879592D0", Slot = "4")]
		public void UpdateController(float LMCBAJKHEDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xC048E0", Offset = "0xC030E0", VA = "0x180C048E0", Slot = "6")]
		public void SetEnabled(bool OPMIAMEJKDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7958D90", Offset = "0x7957590", VA = "0x187958D90")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7959790", Offset = "0x7957F90", VA = "0x187959790")]
		public AvatarElbowBendHelperController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class AvatarElbowBendTargetController : MonoBehaviour, KGKIJCCCBBA
	{
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private const float GOLLMIDPFKA = 45f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		[SerializeField]
		[DAFFCFHPHBO(HNCMILCNFNF.Self, false, false, false)]
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
		private Vector3 NKADPJGODBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private Vector3 HMPIKIJBBDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private bool CEABMGJLCJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private float BGMMHAHNPCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private float NFJMKBEOIGH;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7959B10", Offset = "0x7958310", VA = "0x187959B10", Slot = "4")]
		public void UpdateController(float LMCBAJKHEDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x13E0150", Offset = "0x13DE950", VA = "0x1813E0150", Slot = "6")]
		public void SetEnabled(bool OPMIAMEJKDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7959830", Offset = "0x7958030", VA = "0x187959830")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x795A5D0", Offset = "0x7958DD0", VA = "0x18795A5D0")]
		public AvatarElbowBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class NPFOAJJMFAJ : EGMADKKHCJK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private static readonly int MAEPFMKHLFO;

	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private static readonly int FABJNKLHIBK;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private static readonly int EFADONFGIIE;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private static readonly int IGOLHLBBCFG;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static readonly int EAEEIOKPAMF;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private static readonly int GHFLBNNDJHN;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static readonly int HBFMAKIPPCK;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static readonly int LFAHLFPKMCH;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private static readonly int OIJHCJIGAPL;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private static readonly int OMDLPIGBFOF;

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private static readonly int IOILMNJDNCF;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private static readonly int LLGGFNKPCBF;

	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private static readonly int BBDDAHPPCLO;

	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private static readonly int LPDBAFFHIGJ;

	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private static readonly int OJEIEENFDOI;

	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private static readonly int CNELMOIBJHJ;

	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private static readonly int DLBDAMBLPED;

	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private static readonly int JFIBEGJOHNK;

	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private static readonly int FGHJFIHHFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private Transform GPOCEJHJPDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private Transform ACMNGNPLJLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private Transform HBOLJKDBNPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private Transform FBFFLLKGJMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private Transform DKNNDLCPEPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private Transform NHNGAGHLMLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private Transform HFOPBGLLJIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private NLEPPIICHML HGOIEHJLLPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private Material LHCNEGNPBHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private SkinnedMeshRenderer[] KAPBEAIOBJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private readonly List<Material> PMICOCGBIKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private LJMHOCKELDN IFJJENGGOCN;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public FIEKIAHLEMJ BIHAEOBAKBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private LJMHOCKELDN FMGHNPEEJCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x797FAF0", Offset = "0x797E2F0", VA = "0x18797FAF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool ABPKKBNEOIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7980A60", Offset = "0x797F260", VA = "0x187980A60", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x7980600", Offset = "0x797EE00", VA = "0x187980600")]
	public void NPIOKLMMDIH([In] NLEPPIICHML KJEMKFAOGEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x797FA10", Offset = "0x797E210", VA = "0x18797FA10")]
	public void LKCELPPDJDA([In] CFNIEHNGKLF HNAMKALFCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x797FFA0", Offset = "0x797E7A0", VA = "0x18797FFA0", Slot = "6")]
	public void IINEFLHCCKB(GDJMINGHPLL HAKHJMNFPAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x797EA20", Offset = "0x797D220", VA = "0x18797EA20")]
	private Vector2 BAEEADDPHOL(Vector2 CKOHBAFDLED)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x797EA80", Offset = "0x797D280", VA = "0x18797EA80")]
	public void BCMAKFKPCJI([In] HHCGMBNDBPG HNAMKALFCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x797FBE0", Offset = "0x797E3E0", VA = "0x18797FBE0")]
	private void HJGHJIIGBBL(OPDLEHKLJNL EAHHHFIODBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x79806D0", Offset = "0x797EED0", VA = "0x1879806D0")]
	private void OLMOLAEDLBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x797FB70", Offset = "0x797E370", VA = "0x18797FB70")]
	private void JGGMKNEGIIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x797FB70", Offset = "0x797E370", VA = "0x18797FB70", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7980F00", Offset = "0x797F700", VA = "0x187980F00")]
	public NPFOAJJMFAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x797FA10", Offset = "0x797E210", VA = "0x18797FA10", Slot = "5")]
	private void CFMEPGBIILB([In] CFNIEHNGKLF HNAMKALFCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7980460", Offset = "0x797EC60", VA = "0x187980460", Slot = "7")]
	private void JBPBHBGJOPC([In] HHCGMBNDBPG HNAMKALFCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x7980470", Offset = "0x797EC70", VA = "0x187980470")]
	[CompilerGenerated]
	internal static float JGODKPNENOG(float OPMIAMEJKDH, float GOKBHMBGOCI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7980510", Offset = "0x797ED10", VA = "0x187980510")]
	[CompilerGenerated]
	internal static void LDHDPLIJBHL(Vector2 GLHGJLEIGNM, Vector2 GBJCDEBBPEN, Vector2 LBLAFDELPAC, Vector2 EDGENFDJJHO, Vector2 FGNFJAMALCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7980480", Offset = "0x797EC80", VA = "0x187980480")]
	[CompilerGenerated]
	internal static (float, float) KGLGDGBLCLG(float OPHNDHGPPFB)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x797FAB0", Offset = "0x797E2B0", VA = "0x18797FAB0")]
	[CompilerGenerated]
	internal static Vector4 CGAMGAGOPLA(Vector2 NCGKJMOKFAF, Vector2 EGLHBCAIJLF)
	{
		return default(Vector4);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class AvatarForearmRollController : MonoBehaviour, KGKIJCCCBBA
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
		private float BGMMHAHNPCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private bool CEABMGJLCJG;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x796E340", Offset = "0x796CB40", VA = "0x18796E340", Slot = "4")]
		public void UpdateController(float LMCBAJKHEDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x16589A0", Offset = "0x16571A0", VA = "0x1816589A0", Slot = "6")]
		public void SetEnabled(bool OPMIAMEJKDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x796EBA0", Offset = "0x796D3A0", VA = "0x18796EBA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
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
		[Cpp2IlInjected.Address(RVA = "0x796EC40", Offset = "0x796D440", VA = "0x18796EC40")]
		public void ILJHHMHPGDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x796EBD0", Offset = "0x796D3D0", VA = "0x18796EBD0")]
		public int EGKGFBLNNIG(int OGIIDFFGAOB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public AvatarHandDisplaySettings()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class NFIFJGNJPKF : IBFHECCDKHF
{
	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x797E970", Offset = "0x797D170", VA = "0x18797E970", Slot = "22")]
	public override float EMCBANCGFNI()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x797E9C0", Offset = "0x797D1C0", VA = "0x18797E9C0")]
	public NFIFJGNJPKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class IBFHECCDKHF : NDBEIHDKPNF
{
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private static int NIBBOAMHDGD;

	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private static int INLFOMMIDIB;

	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private static int HJEPBHGGLIO;

	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private static int BGHNDLMLCOF;

	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private static int CEOBKDLABFK;

	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private static int JOADAFMJIFP;

	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private static int HMGODNMDOLN;

	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private static int[] LOIFFEELJMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private FGCGEOOLAMI HGOIEHJLLPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private ADEKGPFKEJG GAKPECDIIMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private int HIAAIKAAIDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private float PMANAGBLAPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	protected Animator JELBAGIHDIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	protected bool CHOOIGABMLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	protected AvatarConfiguration LFFPBFNLDMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	protected int DDHKEIKIAHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private int BIMLPLLHOLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private int IBMCDPEKGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private bool IJCOCGKKLFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private JMDBCOCCLED BHHFECCDOBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private int NBJCHBJHFDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private float JGKHOMKDOPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private AvatarHandDisplaySettings AFDINJOKEOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private DODMAGIBHBA NIIALPPBMNN;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Transform IAOFFIAHHEE
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public Vector3 LPJOOOBGHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x1654270", Offset = "0x1652A70", VA = "0x181654270")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x1654570", Offset = "0x1652D70", VA = "0x181654570")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Quaternion NGLFPNLPFKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xCF7CC0", Offset = "0xCF64C0", VA = "0x180CF7CC0")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0xF05A80", Offset = "0xF04280", VA = "0x180F05A80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool PHMCPGLEAOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7974B70", Offset = "0x7973370", VA = "0x187974B70")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x79756B0", Offset = "0x7973EB0", VA = "0x1879756B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public Vector3 JAMHPBNDLNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x7974F70", Offset = "0x7973770", VA = "0x187974F70", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x79753F0", Offset = "0x7973BF0", VA = "0x1879753F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public Quaternion PJIEMBFJFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x7975460", Offset = "0x7973C60", VA = "0x187975460", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7974FB0", Offset = "0x79737B0", VA = "0x187974FB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public CFPNNJDNDCC IKGABKFMIBC
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xB621B0", Offset = "0xB609B0", VA = "0x180B621B0", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(CFPNNJDNDCC);
		}
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xB61F40", Offset = "0xB60740", VA = "0x180B61F40", Slot = "4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public CFPNNJDNDCC PFEODHONAGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x2439AD0", Offset = "0x24382D0", VA = "0x182439AD0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(CFPNNJDNDCC);
		}
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x2438D60", Offset = "0x2437560", VA = "0x182438D60", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public float POOCLCCOJLN
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x1479030", Offset = "0x1477830", VA = "0x181479030", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0xF1DB30", Offset = "0xF1C330", VA = "0x180F1DB30", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool KHIJBDJBDOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7974FC0", Offset = "0x79737C0", VA = "0x187974FC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool OBCCFBICFHB
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x79753E0", Offset = "0x7973BE0", VA = "0x1879753E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool JMFFBCBBNJA
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x7975380", Offset = "0x7973B80", VA = "0x187975380")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool INBPDEBCOJO
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x7975610", Offset = "0x7973E10", VA = "0x187975610")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x7975470", Offset = "0x7973C70", VA = "0x187975470", Slot = "21")]
	public void NPIOKLMMDIH(FGCGEOOLAMI KJEMKFAOGEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x7974F20", Offset = "0x7973720", VA = "0x187974F20")]
	public void CBCFOECENKM(ADEKGPFKEJG AAJMDELFJCK, AvatarHandDisplaySettings MOMLNLMLNBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x7975620", Offset = "0x7973E20", VA = "0x187975620", Slot = "12")]
	public void OJKMBDDCCML(bool CEHDHOOIGBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x7974FF0", Offset = "0x79737F0", VA = "0x187974FF0", Slot = "11")]
	public void IAALIKKALEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x1479030", Offset = "0x1477830", VA = "0x181479030", Slot = "22")]
	public virtual float EMCBANCGFNI()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x7974BA0", Offset = "0x79733A0", VA = "0x187974BA0")]
	private int BCHGBHLIBPK(CFPNNJDNDCC OIJKDMFANBO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x7974D60", Offset = "0x7973560", VA = "0x187974D60")]
	private void BHDGEEHNFAH(int AABKGCJODDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x7975360", Offset = "0x7973B60", VA = "0x187975360", Slot = "13")]
	public bool IKMPPFDCJBP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x7974FD0", Offset = "0x79737D0", VA = "0x187974FD0", Slot = "14")]
	public bool HHAPNPCPDJK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x7975410", Offset = "0x7973C10", VA = "0x187975410")]
	private CFPNNJDNDCC LJJGCJBLDIH()
	{
		return default(CFPNNJDNDCC);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x1D53A00", Offset = "0x1D52200", VA = "0x181D53A00", Slot = "15")]
	public void JHKIGNGOJIG(bool CEHDHOOIGBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7974D20", Offset = "0x7973520", VA = "0x187974D20", Slot = "10")]
	public void BCJHGCEIFEE(int AABKGCJODDG, float HNHPOEHLLKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7974F90", Offset = "0x7973790", VA = "0x187974F90", Slot = "8")]
	public void EBPNPEGOBIH(JMDBCOCCLED LLNIPANPIOA, bool AKADIMLNNID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x7974FE0", Offset = "0x79737E0", VA = "0x187974FE0", Slot = "9")]
	public void HPLKPFBCPKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7975390", Offset = "0x7973B90", VA = "0x187975390", Slot = "16")]
	public void JBMDCFFLDHG(Transform DFPCBMGPBFO, Vector3 JBAELAMNKJN, Quaternion CLKCJIGAMFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x7975970", Offset = "0x7974170", VA = "0x187975970")]
	public IBFHECCDKHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class HPLJIJMACAO : BFFBFCDHOIA
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class HGIPJDLODNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public HPLJIJMACAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public List<IAIDKAIACPE> prefabHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public List<IAIDKAIACPE> materialHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public GOANNPAHNKI<Material[]> loadMaterialsHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public GOANNPAHNKI<CACKNDPEEAN> loadPrefabHandle;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public HGIPJDLODNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x79735B0", Offset = "0x7971DB0", VA = "0x1879735B0")]
		internal ELBPMMKABPA BGDLLPIEOGN(string error)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	public KNAIBICOJFM BJBFCDJFHJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	public CACKNDPEEAN PIPDOIGCGCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private GOANNPAHNKI<CACKNDPEEAN> BHPMEGBHFFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private GOANNPAHNKI<Material[]> JKBPMJHEHFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	public Material[] KDMDGCMJPCI;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool GCIGGIDEJIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0xA0BF30", Offset = "0xA0A730", VA = "0x180A0BF30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0xA0BCB0", Offset = "0xA0A4B0", VA = "0x180A0BCB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public HHPKDLEJEOP.OOIFDIEICOH FJBOGILHHMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DB0", Offset = "0x9DF5B0", VA = "0x1809E0DB0")]
		[CompilerGenerated]
		get
		{
			return default(HHPKDLEJEOP.OOIFDIEICOH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x9E4300", Offset = "0x9E2B00", VA = "0x1809E4300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x7974B00", Offset = "0x7973300", VA = "0x187974B00")]
	public HPLJIJMACAO(PNLIIGCPIIK DMFMCGBHGNN, KNAIBICOJFM HMPELPJNOPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x7974610", Offset = "0x7972E10", VA = "0x187974610", Slot = "6")]
	public override ELBPMMKABPA OLPPPFBDNHB(List<IAIDKAIACPE> CPPEGJHNHCC, List<IAIDKAIACPE> MNHPBJAJLBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x7973EE0", Offset = "0x79726E0", VA = "0x187973EE0")]
	public ELBPMMKABPA FCBKHNNMMNC(List<IAIDKAIACPE> CPPEGJHNHCC, List<IAIDKAIACPE> MNHPBJAJLBN, GOANNPAHNKI<Material[]> JKBPMJHEHFF, [Optional] GOANNPAHNKI<CACKNDPEEAN> IANCDIHHOCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x7973B50", Offset = "0x7972350", VA = "0x187973B50")]
	public (GOANNPAHNKI<Material[]>, GOANNPAHNKI<CACKNDPEEAN>) AOOIBJCBGBF(List<IAIDKAIACPE> CPPEGJHNHCC, List<IAIDKAIACPE> MNHPBJAJLBN)
	{
		return default((GOANNPAHNKI<Material[]>, GOANNPAHNKI<CACKNDPEEAN>));
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x79742B0", Offset = "0x7972AB0", VA = "0x1879742B0", Slot = "7")]
	public override DDJFKHBJKPH GOJAMDOCNOG(uint BIPGHKPGBAC, AvatarSkinnedMeshBoneOrderRemapsData PBJLLLJMBGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x79743E0", Offset = "0x7972BE0", VA = "0x1879743E0")]
	public DDJFKHBJKPH KGDLBPFMNBI(GameObject PEGAFKOECEF, uint BIPGHKPGBAC, bool DCJFIPBEGIN, bool OJCDFMNFCIA, AvatarSkinnedMeshBoneOrderRemapsData PBJLLLJMBGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x79737F0", Offset = "0x7971FF0", VA = "0x1879737F0")]
	public static bool AIJCNBAGBIL(Renderer[] OIMBCHPJGIF, string KEMPALHDNHH, [Out] Renderer MPBOALOEEME, [Out] Renderer ECMDBALKHMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x7974AB0", Offset = "0x79732B0", VA = "0x187974AB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x79741E0", Offset = "0x79729E0", VA = "0x1879741E0")]
	private (GOANNPAHNKI<CACKNDPEEAN>, GOANNPAHNKI<Material[]>) GBOHACAGALH()
	{
		return default((GOANNPAHNKI<CACKNDPEEAN>, GOANNPAHNKI<Material[]>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x79745F0", Offset = "0x7972DF0", VA = "0x1879745F0")]
	[CompilerGenerated]
	private void LPDFFBADDJA(CACKNDPEEAN HLPIAOANGMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x9DD220", Offset = "0x9DBA20", VA = "0x1809DD220")]
	[CompilerGenerated]
	private void IBJBEBDJGBK(Material[] HLPIAOANGMD)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class AvatarKneeBendTargetController : MonoBehaviour, KGKIJCCCBBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		[SerializeField]
		[DAFFCFHPHBO(HNCMILCNFNF.Self, false, false, false)]
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
		private Vector3 NKADPJGODBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private Vector3 HPHBLDPCGAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private Vector3 NACDCGNIOGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private Matrix4x4 PGKPGEHLIAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private bool CEABMGJLCJG;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x796F1D0", Offset = "0x796D9D0", VA = "0x18796F1D0", Slot = "4")]
		public void UpdateController(float LMCBAJKHEDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x796F1C0", Offset = "0x796D9C0", VA = "0x18796F1C0", Slot = "6")]
		public void SetEnabled(bool OPMIAMEJKDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x796ED60", Offset = "0x796D560", VA = "0x18796ED60")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x796F890", Offset = "0x796E090", VA = "0x18796F890")]
		public AvatarKneeBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[DBBJMDENMLB]
public struct MOHHGFPDPAP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	[ReadOnly]
	public NCPCEJIIOIK HFLBBCHNHFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	[ReadOnly]
	public int MLMCJFBMLGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	public MGBOFKJAJDI FILCIAPKDHP;

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x797ABB0", Offset = "0x79793B0", VA = "0x18797ABB0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[NativeContainer]
[DBBJMDENMLB]
public struct MGBOFKJAJDI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public NativeArray<Vector3> DKEHLHGLLGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public NativeArray<Vector3> MGBCOPHNCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public NativeArray<Vector4> FNNEEPHEDNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public NativeArray<Vector2> PODDLGCCEPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public NativeArray<Vector2> HPFKILELFII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public NativeArray<Vector2> PAHFOPJMONI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public NativeArray<Vector2> FFJMDOKOFBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	public NativeArray<Color> KMDKLFGALID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	public NativeArray<int> APDDPPNIMDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public NativeArray<int> BKMOEANAHOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private NativeArray<int> PDHEPJABFMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private NativeArray<int> NBJMDAGCIHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public NativeArray<int> LAIKAAELAAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	public NativeArray<int> NMOGMKGOPAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	public NativeArray<int> OGNEHHBJHJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	public NativeArray<BoneWeight> HAHDFJPLPAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private NativeArray<int> KIAKHLGFPAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private bool EKFBLLOBFOA;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public int EELKBEMMDFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x797A720", Offset = "0x7978F20", VA = "0x18797A720")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x797A1A0", Offset = "0x79789A0", VA = "0x18797A1A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int HPBDDBNKMLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x7979D00", Offset = "0x7978500", VA = "0x187979D00")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x797A560", Offset = "0x7978D60", VA = "0x18797A560")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int JKDJAIJFPMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x797A550", Offset = "0x7978D50", VA = "0x18797A550")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x7979D10", Offset = "0x7978510", VA = "0x187979D10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x797A750", Offset = "0x7978F50", VA = "0x18797A750")]
	public MGBOFKJAJDI(int BIDKEEGHOIH, int FLDOODJDFIG, int DJAGAELMJMD, int KBDEMJGCIBK, Allocator KKCJNCNIICO, int AEFCKLBAFAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x7979D20", Offset = "0x7978520", VA = "0x187979D20")]
	public void CNCMDDIJEHJ(int FPEOONOJHML, Vector3 AALALMNDJKO, Vector3 PEDIPEHLBOO, Vector4 NACLDKPPPKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x797A580", Offset = "0x7978D80", VA = "0x18797A580")]
	public void PCCJOMOABCA(int FPEOONOJHML, BoneWeight AFHJFBNKCKJ, NativeSlice<byte> GMHNAIDBKOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x797A500", Offset = "0x7978D00", VA = "0x18797A500")]
	public Color LJGPALENMAB(int FPEOONOJHML)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x797A730", Offset = "0x7978F30", VA = "0x18797A730")]
	public void PJLOKKAFKNE(int FPEOONOJHML, Color JDLOGJMLBHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x797A150", Offset = "0x7978950", VA = "0x18797A150")]
	public void ICGNIBDFHEJ(byte COIKJNGOPIB, int FPEOONOJHML, Vector2 PKNKMPJDMGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x797A570", Offset = "0x7978D70", VA = "0x18797A570")]
	public void ONKMJODFMKP(int FPEOONOJHML, int LCLBAPONGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x797A520", Offset = "0x7978D20", VA = "0x18797A520")]
	public bool LLDECDINGCN(int COIKJNGOPIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x7979D90", Offset = "0x7978590", VA = "0x187979D90")]
	public void DJLCCDDGHGG(int EEPCCOOAMGI, int BFKGIFAKMAP, int IMNFCKGEMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x797A010", Offset = "0x7978810", VA = "0x18797A010")]
	public int[] FMNOCCIAHBB(int EEPCCOOAMGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x797A0C0", Offset = "0x79788C0", VA = "0x18797A0C0")]
	private NativeSlice<int> GFEFNBAGKFG(int EEPCCOOAMGI)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x7979E60", Offset = "0x7978660", VA = "0x187979E60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x797A1B0", Offset = "0x79789B0", VA = "0x18797A1B0")]
	public Mesh KNBKFICELPD([Optional] string JBOCJAMDNJG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[DBBJMDENMLB]
[DefaultMember("Item")]
[NativeContainer]
public struct NCPCEJIIOIK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	public NativeArray<Vector3> DKEHLHGLLGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public NativeArray<Vector3> MGBCOPHNCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public NativeArray<Vector4> FNNEEPHEDNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public NativeArray<Vector2> PODDLGCCEPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public NativeArray<Vector2> HPFKILELFII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public NativeArray<Vector2> PAHFOPJMONI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public NativeArray<Vector2> FFJMDOKOFBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	public NativeArray<Color> KMDKLFGALID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public NativeArray<int> BCOKBHFMCFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public NativeArray<int> CKLEIMPPFHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public NativeArray<int> HPHGDJKIMLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public NativeArray<int> GFJGCPAPAHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	public NativeArray<bool> HOHMAILBEJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	public NativeArray<int> MKMIMOONMNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	public NativeArray<int> LKLCKBBNHGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	public NativeArray<BoneWeight> KJMMFLCKLOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private NativeArray<Matrix4x4> FAINNGILNGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private NativeArray<long> MBDKEKPADNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private NativeArray<byte> ACAMLLJMHEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private NativeArray<int> HEDPJBGABIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private NativeArray<int> DPGDHOCJBEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	public NativeArray<sbyte> HIIFLKDLBBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public NativeArray<byte> PHOCPKMJFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	private NativeArray<int> BOMLANFBMPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private bool EKFBLLOBFOA;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int EKEAAMJKMAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xD87030", Offset = "0xD85830", VA = "0x180D87030")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public int LNFNCHLJPFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xC076F0", Offset = "0xC05EF0", VA = "0x180C076F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int LBBFFEDGGFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x797D060", Offset = "0x797B860", VA = "0x18797D060")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int CDPEOHACFGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x797D020", Offset = "0x797B820", VA = "0x18797D020")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x797D0A0", Offset = "0x797B8A0", VA = "0x18797D0A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public int EELKBEMMDFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x797D090", Offset = "0x797B890", VA = "0x18797D090")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x797D040", Offset = "0x797B840", VA = "0x18797D040")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public int JFIJMGNPGBM
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x797D0C0", Offset = "0x797B8C0", VA = "0x18797D0C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x797D0B0", Offset = "0x797B8B0", VA = "0x18797D0B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public DHGIOBOEMOO BFEGAHBOKIB
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x797D030", Offset = "0x797B830", VA = "0x18797D030")]
		get
		{
			return default(DHGIOBOEMOO);
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x797CCC0", Offset = "0x797B4C0", VA = "0x18797CCC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public byte NDONKFFGKAG
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x797D050", Offset = "0x797B850", VA = "0x18797D050")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x797CF40", Offset = "0x797B740", VA = "0x18797CF40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public NMHGNMGNPNM EMAHJNALJJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x797C790", Offset = "0x797AF90", VA = "0x18797C790")]
		get
		{
			return default(NMHGNMGNPNM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x797D0D0", Offset = "0x797B8D0", VA = "0x18797D0D0")]
	public NCPCEJIIOIK(IList<Mesh> OODOBGLCLDP, IList<Matrix4x4> MEBOBDABIFI, IList<bool> HOHMAILBEJD, byte PIKFHPDFBNG, IList<byte[]> BEPALNMFNGK, IList<long> MFGPEPCMMEP, IList<bool> OPNNCCCOEDO, IList<int> MKMIMOONMNK, IList<int> CHIAJBFBFLM, IList<int> MHBADMKPEEO, Allocator KKCJNCNIICO, DHGIOBOEMOO BGGJAHNONJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x797CF50", Offset = "0x797B750", VA = "0x18797CF50")]
	public MGBOFKJAJDI INFOPLADKMH(Allocator KKCJNCNIICO)
	{
		return default(MGBOFKJAJDI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x797CCD0", Offset = "0x797B4D0", VA = "0x18797CCD0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[DBBJMDENMLB]
public class BJJMNKDEKGO : INJHGMNEEAG
{
	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x7971D20", Offset = "0x7970520", VA = "0x187971D20")]
	public NCPCEJIIOIK OMLLALJIBGC()
	{
		return default(NCPCEJIIOIK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x7967CE0", Offset = "0x79664E0", VA = "0x187967CE0")]
	public BJJMNKDEKGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct NMHGNMGNPNM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public NativeSlice<Vector3> DKEHLHGLLGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public NativeSlice<Vector3> MGBCOPHNCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public NativeSlice<Vector4> FNNEEPHEDNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public NativeSlice<Vector2> PODDLGCCEPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public NativeSlice<Vector2> HPFKILELFII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	public NativeSlice<Vector2> PAHFOPJMONI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public NativeSlice<Vector2> FFJMDOKOFBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public NativeSlice<Color> KMDKLFGALID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public NativeSlice<int> CKEOAAGPINJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public NativeSlice<int> GFJGCPAPAHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	public NativeSlice<BoneWeight> KJMMFLCKLOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public NativeSlice<byte> GBJHOHKGENL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public int OMGIPLEPLOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public Matrix4x4 PPOHNAMANDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public long DOAJGOPDLJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	public NativeSlice<byte> GMHNAIDBKOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	public bool MEDEIDLELGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	public int IPOBOLKGMLO;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal readonly struct IKOFHHAONMF : IEquatable<IKOFHHAONMF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	internal readonly Material AHJGKHIHKBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	internal readonly NMINLHPKGCA BCIGCMPIBFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	internal readonly CIPOGJIBMCP FKPBJFIOHPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	internal readonly PNLIIGCPIIK NLNKGOHMIHB;

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x7978C00", Offset = "0x7977400", VA = "0x187978C00")]
	public IKOFHHAONMF(Material OALKCGACMLD, NMINLHPKGCA DEODPNNAHDB, CIPOGJIBMCP IHEENGIGNMA, PNLIIGCPIIK MDILONMHHMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x79789E0", Offset = "0x79771E0", VA = "0x1879789E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x79788C0", Offset = "0x79770C0", VA = "0x1879788C0", Slot = "4")]
	public bool Equals(IKOFHHAONMF PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x79787E0", Offset = "0x7976FE0", VA = "0x1879787E0", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x7978940", Offset = "0x7977140", VA = "0x187978940", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyDisplayBehaviour : MonoBehaviour, IMDLIGJOCDI
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
		private DODMAGIBHBA avatarBodyType;

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
		private MKBPDMPFCMC JNOHPJBKJPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		private EGMADKKHCJK AMMOCJCAKGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		private NDBEIHDKPNF ILPFFCHGJNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private NDBEIHDKPNF EPMGJAGAANH;

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public MKBPDMPFCMC IBIMLILOHIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x79708B0", Offset = "0x796F0B0", VA = "0x1879708B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public EGMADKKHCJK FOFIGEDFPLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x7970900", Offset = "0x796F100", VA = "0x187970900", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public NDBEIHDKPNF DPPBNCMHJLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x7970950", Offset = "0x796F150", VA = "0x187970950", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public NDBEIHDKPNF LPKJCIGBGMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x79709A0", Offset = "0x796F1A0", VA = "0x1879709A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public Transform KNKIHENFOJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x79709F0", Offset = "0x796F1F0", VA = "0x1879709F0", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public DODMAGIBHBA FNKKGBAANJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x9E4120", Offset = "0x9E2920", VA = "0x1809E4120", Slot = "12")]
			get
			{
				return default(DODMAGIBHBA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x796F8A0", Offset = "0x796E0A0", VA = "0x18796F8A0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x79702D0", Offset = "0x796EAD0", VA = "0x1879702D0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x796FED0", Offset = "0x796E6D0", VA = "0x18796FED0", Slot = "8")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x79702D0", Offset = "0x796EAD0", VA = "0x1879702D0", Slot = "9")]
		public void TeardownAvatarDisplaySystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x796F910", Offset = "0x796E110", VA = "0x18796F910", Slot = "10")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x79707C0", Offset = "0x796EFC0", VA = "0x1879707C0")]
		public void UpdatePostIKAnimControllers(float LMCBAJKHEDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x7970730", Offset = "0x796EF30", VA = "0x187970730")]
		private void PGEINBIOAHO(GameObject PNHCNFOFAFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x7970380", Offset = "0x796EB80", VA = "0x187970380")]
		private MKBPDMPFCMC PGCCMDLAMJM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x796FF30", Offset = "0x796E730", VA = "0x18796FF30")]
		private EGMADKKHCJK JDHAGJPEEGF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x796FC40", Offset = "0x796E440", VA = "0x18796FC40")]
		private NDBEIHDKPNF IHBGHNJFMJP(ELGEGIFKKGD MOFOOFPBFBC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x79708A0", Offset = "0x796F0A0", VA = "0x1879708A0")]
		public AvatarModernBodyDisplayBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class ICEACEDDBKN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private MaterialPropertyBlock OCCKEIMIMDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	public Color? MEHEKLAKENE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	public Color? HHINKOEHMCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	public Color? PLNHGLJAGMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	public Color? CIPEHBAGAGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	public Color JJAHBNNEDOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	public Color AKBDLNIACIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	public Color BMFKBDBBCFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	public Texture2D NGIELPPFEAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	public Texture2D PPEDODIBJME;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	private Dictionary<IKOFHHAONMF, int> JDJEBBAHLBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	private NMINLHPKGCA[] APCFNBGFKHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	private CIPOGJIBMCP[] DBCDEFMIJHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public Vector4[] IMFMFNNNFGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public Vector4[] LCBNFGDJDCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public Vector4[] OPOCJAABHEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public Vector4[] BLLHOHIDIGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public Vector4[] HLPMJJEHNHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public Vector4[] AJOGCKCHKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private List<Texture2D> FKCGNOLJOJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private Vector4[] CFLGCDICDJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private List<Texture2D> JCBJDBMPMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private float[] JJJNLIHCJFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private Vector4[] NHCLNLMODKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private float[] EFOCPCMJBEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public float[] IAHBGOFDDFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private List<Texture2D> FJNHLHDBJOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private float[] DJFNCPGPCEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private List<Texture2D> OKOHMICMHOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	private Vector4[] EIAFPGPGICD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private float[] PIMJIIOLDGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private Vector4[] BKLCNDJIFDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public float[] DFACMHGNDKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public Texture2DArray PFKNEIPKOBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	public Texture2DArray LJJLKDFFLAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	public Texture2DArray MIEGLPGJJMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public Texture2DArray NMAGGALCCBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private bool EEBFLCJMFOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	private int AFBDKIHJOOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private Vector2? BBOIIBEJNOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private TextureFormat MGMBKLJEFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private Vector2? BHHBFIDDLJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private TextureFormat JGIEMBIKBNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	private Vector2? NDKBKBOMBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	private TextureFormat MCNFDPCKJMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private Vector2? ELAHGBMMJNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	private TextureFormat DFOEHGGFDNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	private bool HGKGNONOPPK;

	[Cpp2IlInjected.Token(Token = "0x400024E")]
	private static int AKNAGBLKIHG;

	[Cpp2IlInjected.Token(Token = "0x400024F")]
	private static int DALDOGMJPOG;

	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private static int KMANELKKJKI;

	[Cpp2IlInjected.Token(Token = "0x4000251")]
	private static int HBNPMGKCAMG;

	[Cpp2IlInjected.Token(Token = "0x4000252")]
	private static int JNJCLAFNDBG;

	[Cpp2IlInjected.Token(Token = "0x4000253")]
	private static int PLHOJFEBDBL;

	[Cpp2IlInjected.Token(Token = "0x4000254")]
	private static int GILJCPNDEIB;

	[Cpp2IlInjected.Token(Token = "0x4000255")]
	private static int JFFPFBBOILG;

	[Cpp2IlInjected.Token(Token = "0x4000256")]
	private static int CIFDNMONGBC;

	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private static int AGAOACHMBAA;

	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private static int CKNOGBPBPMJ;

	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private static int GBHFLBIFLHH;

	[Cpp2IlInjected.Token(Token = "0x400025A")]
	private static int OFEKIPKDLCL;

	[Cpp2IlInjected.Token(Token = "0x400025B")]
	private static int MBJCFKCNPAJ;

	[Cpp2IlInjected.Token(Token = "0x400025C")]
	private static int FFEKPMFGBNG;

	[Cpp2IlInjected.Token(Token = "0x400025D")]
	private static int LELIFHIPFFM;

	[Cpp2IlInjected.Token(Token = "0x400025E")]
	private static int FANHNEGCIHE;

	[Cpp2IlInjected.Token(Token = "0x400025F")]
	private static int BMGNGGLBDPJ;

	[Cpp2IlInjected.Token(Token = "0x4000260")]
	private static int MNMCHDOENOB;

	[Cpp2IlInjected.Token(Token = "0x4000261")]
	private static int BMNBDLHJJMM;

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x7978060", Offset = "0x7976860", VA = "0x187978060")]
	private ICEACEDDBKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x7977FA0", Offset = "0x79767A0", VA = "0x187977FA0")]
	public ICEACEDDBKN(Color GKIKDNIBDLJ, Color OLBBCMGGNOB, Color BIGBKBCGGNN, Color? FMMKLDBMEBN, Color? EMIOMMAPOFD, Color? OMJPBCDLOEA, Texture2D MJAGIBEHMLI, Texture2D ALEKDMKBJKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x79777A0", Offset = "0x7975FA0", VA = "0x1879777A0")]
	internal int IAGMEHOFIBB(Material LFMNNDCMMGC, NMINLHPKGCA DEODPNNAHDB, CIPOGJIBMCP IHEENGIGNMA, PNLIIGCPIIK MDILONMHHMF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x7977710", Offset = "0x7975F10", VA = "0x187977710")]
	private int IAGMEHOFIBB(IKOFHHAONMF BELIEAFHDAH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x79769E0", Offset = "0x79751E0", VA = "0x1879769E0")]
	internal int FOKBEGOEHNA(Material LFMNNDCMMGC, Color FPFEOKGHPHB, Color PDFDAEFEJLA, Color CMKKLECIAMK, Color BFOBPBHBHKF, Color GOEMDOOCABH, Texture2D GCEKLDNBLCC, Vector4 HIIPPBBPEGI, Texture2D AIOJKGBMPCG, Vector4 EDCFFJNPDPN, float GNOFDMMFNOI, float ONGNDMFINFJ, Texture2D NKDAMFIHMKC, Vector4 INGIEIAEIAK, float EPBABECPJDH, Texture2D KDBEIAAPEEH, Color LDHHMAHGKGE, Vector4 LNBGJEOLCNK, NMINLHPKGCA DEODPNNAHDB, CIPOGJIBMCP IHEENGIGNMA, PNLIIGCPIIK MDILONMHHMF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x7977A90", Offset = "0x7976290", VA = "0x187977A90")]
	private void PAAHNEIFPBH(List<Texture2D> FKCGNOLJOJE, [Out] Texture2DArray MOALABAIHNE, [Out] Texture2DArray FHJGKLMMGMD, [Out] Texture2DArray LCGDKEKBBHM, [Out] Texture2DArray MIDGKAPOJEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x7975AE0", Offset = "0x79742E0", VA = "0x187975AE0")]
	public void CJKKKFINCOA(Shader BBLELNDDPGI, Renderer JGPHFKDOCBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x7975C30", Offset = "0x7974430", VA = "0x187975C30")]
	private void DHEDFGBBJMA(Shader BBLELNDDPGI, Renderer JGPHFKDOCBN, int BODBCFHPHMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x7977890", Offset = "0x7976090", VA = "0x187977890")]
	private Color OCMMMIHFLJP(Color JIDFMDLOPPP, NMINLHPKGCA IFFOBJIAHML)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x7975990", Offset = "0x7974190", VA = "0x187975990")]
	private Color AKHMOCPOIIE(Color NFCNBIJANDK, NMINLHPKGCA IFFOBJIAHML)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x79775B0", Offset = "0x7975DB0", VA = "0x1879775B0")]
	private bool HPDJOBNEAHO(Texture2D KOJJPIMGNFG, CIPOGJIBMCP GNABHHKCLPK, [Out] Texture2D LBBBKLIEMBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x79768F0", Offset = "0x79750F0", VA = "0x1879768F0")]
	private void DMNBPJAKBGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x79769A0", Offset = "0x79751A0", VA = "0x1879769A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public abstract class BFFBFCDHOIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	public readonly PNLIIGCPIIK GALNAPPAFDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	protected bool LBFMMBIKJHH;

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public bool LPEHGKJGNJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xC47930", Offset = "0xC46130", VA = "0x180C47930")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0xC466E0", Offset = "0xC44EE0", VA = "0x180C466E0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public bool FKPMFBDBNBN
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0xC46E20", Offset = "0xC45620", VA = "0x180C46E20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0xC466C0", Offset = "0xC44EC0", VA = "0x180C466C0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public virtual HHPKDLEJEOP.OOIFDIEICOH DOAJGOPDLJM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(HHPKDLEJEOP.OOIFDIEICOH);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xC57CB0", Offset = "0xC564B0", VA = "0x180C57CB0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool NFCDFKKFMMC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x129E8E0", Offset = "0x129D0E0", VA = "0x18129E8E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public bool AJLOFENJOBN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x7970A10", Offset = "0x796F210", VA = "0x187970A10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool GNHDDFALKDO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x7970A40", Offset = "0x796F240", VA = "0x187970A40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public bool KHGEJCOAAHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x7970A20", Offset = "0x796F220", VA = "0x187970A20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x7970A50", Offset = "0x796F250", VA = "0x187970A50")]
	protected BFFBFCDHOIA(PNLIIGCPIIK DMFMCGBHGNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract ELBPMMKABPA OLPPPFBDNHB(List<IAIDKAIACPE> CPPEGJHNHCC, List<IAIDKAIACPE> MNHPBJAJLBN);

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract DDJFKHBJKPH GOJAMDOCNOG(uint BIPGHKPGBAC, AvatarSkinnedMeshBoneOrderRemapsData PBJLLLJMBGG);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class ALANDNAPIGC : NCLAFBEOMAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	private AvatarSkinAssetItem JIBFCNOIFOP;

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x796E240", Offset = "0x796CA40", VA = "0x18796E240")]
	public ALANDNAPIGC(AvatarSkinAssetItem NGCNMLCEKNA, AvatarSkinAssetItem.JOEMGEIOIPE BJENAEIKOON, PNLIIGCPIIK MDILONMHHMF, [Optional] MFGHHKBHMBD? PPGHGKIFDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x796DFE0", Offset = "0x796C7E0", VA = "0x18796DFE0", Slot = "6")]
	public override ELBPMMKABPA OLPPPFBDNHB(List<IAIDKAIACPE> CPPEGJHNHCC, List<IAIDKAIACPE> MNHPBJAJLBN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class IHBCPAOADHG
{
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	private static readonly int[] DFPABEPJPLF;

	[Cpp2IlInjected.Token(Token = "0x4000269")]
	private static readonly int[] OBGGGBCLNKO;

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public static int[] LEAOBEDJOBP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x79785E0", Offset = "0x7976DE0", VA = "0x1879785E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x7978550", Offset = "0x7976D50", VA = "0x187978550")]
	public static int[] CHAHPHKKHNC(bool NAJGEIGFJMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x7978650", Offset = "0x7976E50", VA = "0x187978650")]
	public static int MNOMDICLCAM(GLBLJMJHHNB LCDGODDNNOK, bool NAJGEIGFJMA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x79785D0", Offset = "0x7976DD0", VA = "0x1879785D0")]
	private static int CLBFJNGKGGK(GLBLJMJHHNB LCDGODDNNOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x7978630", Offset = "0x7976E30", VA = "0x187978630")]
	private static int GPAAHLKMLIG(GLBLJMJHHNB LCDGODDNNOK)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class LNNNKFPOCDG
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class KOOPHAGAFNP : IEnumerator<IGCELENFGND>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private IGCELENFGND <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		private IGCELENFGND System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF30", Offset = "0x9EA730", VA = "0x1809EBF30")]
		[DebuggerHidden]
		public KOOPHAGAFNP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x1231FB0", Offset = "0x12307B0", VA = "0x181231FB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x79795F0", Offset = "0x7977DF0", VA = "0x1879795F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
	public static void MAOJONOEMPP(string MLBCMOLHELH, int BIPGHKPGBAC, long DCGKJNEFALO, long JDBAIFAOAMA, long ILFNIMBBCJD, long FEGFBPBMFML, long FMGBJBGMCCL, long GDMMIFOMOAE, long NIECLJIKGHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x7979BA0", Offset = "0x79783A0", VA = "0x187979BA0")]
	public static KIJPFMOACHH BPECMJGGMCH(JobHandle BEBOCOPDAHC, bool AEDCJPOJALJ, bool HAIFIFEKBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x7979C90", Offset = "0x7978490", VA = "0x187979C90")]
	[IteratorStateMachine(typeof(KOOPHAGAFNP))]
	private static IEnumerator<IGCELENFGND> LIIOLMOMEHK(JobHandle EKNJAMPDKID)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class DJENPNPFJPK
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public enum AEIJDIFGMEN
	{
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		General,
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		ColoredHair
	}

	[Cpp2IlInjected.Token(Token = "0x400026D")]
	public static readonly int LCDIPBIFJJI;

	[Cpp2IlInjected.Token(Token = "0x400026E")]
	public static readonly int LCEBNGKIKHN;

	[Cpp2IlInjected.Token(Token = "0x400026F")]
	public static readonly int BILDLMMADLB;

	[Cpp2IlInjected.Token(Token = "0x4000270")]
	public static readonly int INGOBALMHGO;

	[Cpp2IlInjected.Token(Token = "0x4000271")]
	public static readonly int EGELEMHJOAE;

	[Cpp2IlInjected.Token(Token = "0x4000272")]
	public static readonly int NLAJBJEGMLE;

	[Cpp2IlInjected.Token(Token = "0x4000273")]
	public static readonly int PLAPJHKPIKM;

	[Cpp2IlInjected.Token(Token = "0x4000274")]
	public static readonly int JLCGOBAKODB;

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7971F60", Offset = "0x7970760", VA = "0x187971F60")]
	public static bool LPMALADMMPF(Material OALKCGACMLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x7971EA0", Offset = "0x79706A0", VA = "0x187971EA0")]
	public static bool IHDBAHIMGJA(Material OALKCGACMLD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class NCLAFBEOMAB : BFFBFCDHOIA
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class BHPNJJPNDJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public GOANNPAHNKI<GameObject> skinAvatarItemPrefabHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public NCLAFBEOMAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public Action<string> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public BHPNJJPNDJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x7971950", Offset = "0x7970150", VA = "0x187971950")]
		internal void KGJJLDIOJPM(GameObject result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x7971810", Offset = "0x7970010", VA = "0x187971810")]
		internal void BGDLLPIEOGN(string error)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	protected AvatarSkinAssetItem IBAAKLHPICC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	protected Material[] AFFNPAAIHNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	private readonly AvatarSkinAssetItem.JOEMGEIOIPE JGJPKHOOHJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	private readonly AssetReference FOBOONIHGJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	private readonly MFGHHKBHMBD? ANKCOECAOJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	private SkinnedMeshRenderer[] CBLLOCPBLKI;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public override HHPKDLEJEOP.OOIFDIEICOH DOAJGOPDLJM
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x9DF790", Offset = "0x9DDF90", VA = "0x1809DF790", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(HHPKDLEJEOP.OOIFDIEICOH);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DE0", Offset = "0x9DF5E0", VA = "0x1809E0DE0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x797C540", Offset = "0x797AD40", VA = "0x18797C540")]
	public NCLAFBEOMAB(AvatarSkinAssetItem.JOEMGEIOIPE BJENAEIKOON, AssetReference GHOPIJHBEIC, Material LLOMLGDFLLC, PNLIIGCPIIK MDILONMHHMF, HHPKDLEJEOP.OOIFDIEICOH CPCOMNKNCPO = (HHPKDLEJEOP.OOIFDIEICOH)0L, [Optional] MFGHHKBHMBD? PPGHGKIFDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x797C670", Offset = "0x797AE70", VA = "0x18797C670")]
	public NCLAFBEOMAB(AvatarSkinAssetItem.JOEMGEIOIPE BJENAEIKOON, AssetReference GHOPIJHBEIC, Material LLOMLGDFLLC, HHPKDLEJEOP.OOIFDIEICOH CPCOMNKNCPO = (HHPKDLEJEOP.OOIFDIEICOH)0L, [Optional] MFGHHKBHMBD? PPGHGKIFDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x797C2B0", Offset = "0x797AAB0", VA = "0x18797C2B0", Slot = "6")]
	public override ELBPMMKABPA OLPPPFBDNHB(List<IAIDKAIACPE> CPPEGJHNHCC, List<IAIDKAIACPE> MNHPBJAJLBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x797C0A0", Offset = "0x797A8A0", VA = "0x18797C0A0", Slot = "7")]
	public override DDJFKHBJKPH GOJAMDOCNOG(uint BIPGHKPGBAC, AvatarSkinnedMeshBoneOrderRemapsData PBJLLLJMBGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x797C4D0", Offset = "0x797ACD0", VA = "0x18797C4D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x797C480", Offset = "0x797AC80", VA = "0x18797C480")]
	protected void PBGGFNILEMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class FIOHGAFMEBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	private List<int> BONMFGAHLGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	private List<AKKELCBABED> MDADCKOLAOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	private HashSet<Transform> KJLFAPKJIAM;

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x7972C10", Offset = "0x7971410", VA = "0x187972C10")]
	public static FIOHGAFMEBA PJCIGFDFDKM(Transform NACLDKPPPKG, Dictionary<Transform, OutfitType?> PINIDGFFJIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x7972820", Offset = "0x7971020", VA = "0x187972820")]
	private void ELDKNFHHFOM(Transform NACLDKPPPKG, PNLIIGCPIIK MDILONMHHMF, Dictionary<Transform, OutfitType?> PINIDGFFJIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x7972AE0", Offset = "0x79712E0", VA = "0x187972AE0")]
	private void MONCENNLKOJ(Transform PBMCIAKIPDK, PNLIIGCPIIK MDILONMHHMF, bool FNMEHMEMIOJ, OutfitType? IDPHALEDPIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x7972430", Offset = "0x7970C30", VA = "0x187972430")]
	public BGGNNFLBBCM BAEBGNHGJJH(HashSet<string> KMBJNOBLODM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x7972DA0", Offset = "0x79715A0", VA = "0x187972DA0")]
	public FIOHGAFMEBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class BGGNNFLBBCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	private List<AKKELCBABED> MDADCKOLAOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	private List<Matrix4x4> JLEINJLCOLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private Transform[] OKJHBMIPPEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	private Matrix4x4[] MHBOHMDBLMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	private Dictionary<KMOGPOMILLI, int> OGHOHBEBHIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	private List<FCKPEDFOEPD> BABJHMLDJLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	private bool CNOIFCGLBMK;

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public int FCHJPHAGFMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x7970A80", Offset = "0x796F280", VA = "0x187970A80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public Transform[] DFCGONFMJFI
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x7971440", Offset = "0x796FC40", VA = "0x187971440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public Matrix4x4[] DEJONMLBJEE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x7970EA0", Offset = "0x796F6A0", VA = "0x187970EA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x7971250", Offset = "0x796FA50", VA = "0x187971250")]
	public void MONCENNLKOJ(Transform PBMCIAKIPDK, PNLIIGCPIIK MDILONMHHMF, OutfitType? IDPHALEDPIM, bool HCAFDKJNODK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x7970F10", Offset = "0x796F710", VA = "0x187970F10")]
	private void MONCENNLKOJ(Transform PBMCIAKIPDK, PNLIIGCPIIK MDILONMHHMF, OutfitType? IDPHALEDPIM, bool HCAFDKJNODK, Matrix4x4 ABJHGAEJOKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x7970C00", Offset = "0x796F400", VA = "0x187970C00")]
	public int FILFLLNMDDK(KMOGPOMILLI BELIEAFHDAH, bool HOFEPGLDBLL, [Optional] OutfitType? IDPHALEDPIM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x79715A0", Offset = "0x796FDA0", VA = "0x1879715A0")]
	public int PGMKJHACPIF(PNLIIGCPIIK MDILONMHHMF, [Optional] OutfitType? IDPHALEDPIM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7970DB0", Offset = "0x796F5B0", VA = "0x187970DB0")]
	public void IKLDGMNCBNH(KMOGPOMILLI BELIEAFHDAH, Matrix4x4 MBEDGIOCNMG, bool HOFEPGLDBLL = false, [Optional] OutfitType? IDPHALEDPIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x7970AC0", Offset = "0x796F2C0", VA = "0x187970AC0")]
	public Matrix4x4 CICFEBPNLBN(KMOGPOMILLI BELIEAFHDAH, bool HOFEPGLDBLL, [Optional] OutfitType? IDPHALEDPIM)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x12D7F90", Offset = "0x12D6790", VA = "0x1812D7F90")]
	public void BFJNEDOMEKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x79716A0", Offset = "0x796FEA0", VA = "0x1879716A0")]
	public BGGNNFLBBCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct KMOGPOMILLI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public readonly string DLDHOKEFMJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public readonly PNLIIGCPIIK NLNKGOHMIHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public readonly OutfitType? PMIHGDLDLOD;

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x79795B0", Offset = "0x7977DB0", VA = "0x1879795B0")]
	public KMOGPOMILLI(string KJMMMDHHBDO, PNLIIGCPIIK MDILONMHHMF, [Optional] OutfitType? IDPHALEDPIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x7979500", Offset = "0x7977D00", VA = "0x187979500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x79793D0", Offset = "0x7977BD0", VA = "0x1879793D0")]
	public bool GNBACMEALJB(KMOGPOMILLI PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x7979330", Offset = "0x7977B30", VA = "0x187979330", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x7979490", Offset = "0x7977C90", VA = "0x187979490", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct FCKPEDFOEPD : IEquatable<FCKPEDFOEPD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public readonly PNLIIGCPIIK NLNKGOHMIHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public readonly OutfitType? HNOEBNCOCAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public readonly int MMCBMIMPLBE;

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x7972420", Offset = "0x7970C20", VA = "0x187972420")]
	public FCKPEDFOEPD(PNLIIGCPIIK MDILONMHHMF, int ADHHGKKMNIO, [Optional] OutfitType? DCAKMKJCDNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x7972350", Offset = "0x7970B50", VA = "0x187972350", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x6BE5880", Offset = "0x6BE4080", VA = "0x186BE5880")]
	public bool NLCBBAFCKIC(PNLIIGCPIIK MDILONMHHMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x7972140", Offset = "0x7970940", VA = "0x187972140")]
	public bool BHOPMJEKHLG(OutfitType? DCAKMKJCDNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x79722B0", Offset = "0x7970AB0", VA = "0x1879722B0", Slot = "4")]
	public bool Equals(FCKPEDFOEPD PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x79721C0", Offset = "0x79709C0", VA = "0x1879721C0", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x7972300", Offset = "0x7970B00", VA = "0x187972300", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct AKKELCBABED : IEquatable<AKKELCBABED>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public readonly Transform CFLADAFCBOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public readonly bool AOOGNALOPKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public readonly PNLIIGCPIIK BBLIEAFPMOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public readonly OutfitType? PMIHGDLDLOD;

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x796DF90", Offset = "0x796C790", VA = "0x18796DF90")]
	public AKKELCBABED(Transform PBMCIAKIPDK, bool FNMEHMEMIOJ, PNLIIGCPIIK JAKDPPOICDO, [Optional] OutfitType? AOCJFINFAEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x796DD80", Offset = "0x796C580", VA = "0x18796DD80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x796DB20", Offset = "0x796C320", VA = "0x18796DB20", Slot = "4")]
	public bool Equals(AKKELCBABED PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x796DC20", Offset = "0x796C420", VA = "0x18796DC20", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x796DD00", Offset = "0x796C500", VA = "0x18796DD00", Slot = "2")]
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
		[Cpp2IlInjected.Address(RVA = "0x7972ED0", Offset = "0x79716D0", VA = "0x187972ED0")]
		public static void DespawnHairHemisphere()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
		public void UpdateValues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x9DECA0", Offset = "0x9DD4A0", VA = "0x1809DECA0")]
		public FitMeshHemisphereUpdater()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface GKBKIIEGCLC
{
	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DMAPEONODMJ(Mesh ABAPBBKNPBC, Matrix4x4 EFJJIALLDBB, byte[] GMHNAIDBKOB, bool OOBBFEAABPO = false, HHPKDLEJEOP.OOIFDIEICOH PCMEIMGHCGF = (HHPKDLEJEOP.OOIFDIEICOH)0L, int MKMIMOONMNK = -1, bool HOHMAILBEJD = false);

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BHPGFNGHEHN(Allocator KKCJNCNIICO, DHGIOBOEMOO BGGJAHNONJI, byte PIKFHPDFBNG, [Optional] IList<int> CHIAJBFBFLM, [Optional] IList<int> FLIGFOAOIPC);
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public readonly struct CACKNDPEEAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public readonly GameObject PEGAFKOECEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	private readonly AvatarItemMaterial ALLDNGDJPEL;

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0xA81780", Offset = "0xA7FF80", VA = "0x180A81780")]
	public CACKNDPEEAN(GameObject PEGAFKOECEF, AvatarItemMaterial ALLDNGDJPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x7971E10", Offset = "0x7970610", VA = "0x187971E10")]
	public void PLJCCEACGAF(Material OALKCGACMLD, int JNNOAPGEOAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class KBEGOACJHDG : BMPLGFEOOOC<Task<(GameObject, AvatarItemMaterial)>, CACKNDPEEAN>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct MOJDLJBNOGG : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x797BB30", Offset = "0x797A330", VA = "0x18797BB30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x797C030", Offset = "0x797A830", VA = "0x18797C030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	private GOANNPAHNKI<GameObject> IPGFPJFMMKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	private GOANNPAHNKI<AvatarItemMaterial> DNGEALOHHJO;

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x79792A0", Offset = "0x7977AA0", VA = "0x1879792A0")]
	private KBEGOACJHDG(Task<(GameObject, AvatarItemMaterial)> BFOIMBMKJIA, GOANNPAHNKI<GameObject> LHDAHEGAABA, GOANNPAHNKI<AvatarItemMaterial> MCBHKAKDIOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x7978E90", Offset = "0x7977690", VA = "0x187978E90")]
	public static KBEGOACJHDG NKIHIDGHACP(AssetReference ILKEALHLPEI, [Optional] AssetReference IIAFEJMAFDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x7978C40", Offset = "0x7977440", VA = "0x187978C40", Slot = "11")]
	protected override CACKNDPEEAN CNPDEIBAFOP(Task<(GameObject, AvatarItemMaterial)> IMPHMKOLDHP)
	{
		return default(CACKNDPEEAN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x7978E10", Offset = "0x7977610", VA = "0x187978E10", Slot = "12")]
	protected override void NGLIAILHNGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x7978CE0", Offset = "0x79774E0", VA = "0x187978CE0")]
	[AsyncStateMachine(typeof(MOJDLJBNOGG))]
	private static Task<(GameObject, AvatarItemMaterial)> LADDNIECIDB(Task<GameObject> FKKKKJHNEJA, Task<AvatarItemMaterial> ALIPIPOHHIG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class GOLDMNCMHKH
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class KPNKHFMGHOC : BMPLGFEOOOC<Task<MaterialMapAsset>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private GOANNPAHNKI<MaterialMapAsset> EKNJAMPDKID;

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x7979AC0", Offset = "0x79782C0", VA = "0x187979AC0")]
		public KPNKHFMGHOC(GOANNPAHNKI<MaterialMapAsset> EKNJAMPDKID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x7979640", Offset = "0x7977E40", VA = "0x187979640", Slot = "11")]
		protected override Material[] CNPDEIBAFOP(Task<MaterialMapAsset> BFOIMBMKJIA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x7979A60", Offset = "0x7978260", VA = "0x187979A60", Slot = "12")]
		protected override void NGLIAILHNGF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class GEDNABIFLCI : BMPLGFEOOOC<Task<Material[]>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private List<GOANNPAHNKI<Material>> HAIKNNMBBDO;

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x79730C0", Offset = "0x79718C0", VA = "0x1879730C0")]
		public GEDNABIFLCI(Task<Material[]> BFOIMBMKJIA, List<GOANNPAHNKI<Material>> HAIKNNMBBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x7972F30", Offset = "0x7971730", VA = "0x187972F30", Slot = "11")]
		protected override Material[] CNPDEIBAFOP(Task<Material[]> IMPHMKOLDHP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x7972F80", Offset = "0x7971780", VA = "0x187972F80", Slot = "12")]
		protected override void NGLIAILHNGF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	private static readonly LLPKKNNAIAE NOMHFHBJHNN;

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x7973130", Offset = "0x7971930", VA = "0x187973130")]
	public static GOANNPAHNKI<Material[]> ADOLLOGLJLD(AssetReference[] EAHNHLHBMCL)
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
		public enum CNIPHPLMKHC
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
		public enum BHHEHLDEJFH
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
		public enum GNMOMKEJAIC : byte
		{
			[Cpp2IlInjected.Token(Token = "0x400034E")]
			All,
			[Cpp2IlInjected.Token(Token = "0x400034F")]
			LOD0Only,
			[Cpp2IlInjected.Token(Token = "0x4000350")]
			EditorToolAll
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		public struct FJIABMDFBND
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000351")]
			public readonly Material AHJGKHIHKBD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000352")]
			public readonly CNIPHPLMKHC BCIGCMPIBFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000353")]
			public readonly BHHEHLDEJFH FKPBJFIOHPI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000354")]
			public readonly PNLIIGCPIIK NLNKGOHMIHB;

			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x7978C00", Offset = "0x7977400", VA = "0x187978C00")]
			public FJIABMDFBND(Material OALKCGACMLD, CNIPHPLMKHC DEODPNNAHDB, BHHEHLDEJFH IHEENGIGNMA, PNLIIGCPIIK MDILONMHHMF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x79953E0", Offset = "0x7993BE0", VA = "0x1879953E0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x79788C0", Offset = "0x79770C0", VA = "0x1879788C0")]
			public bool GNBACMEALJB(FJIABMDFBND PGPJMFPAKOO)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x7995260", Offset = "0x7993A60", VA = "0x187995260", Slot = "0")]
			public override bool Equals(object PNHCNFOFAFI)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x7995340", Offset = "0x7993B40", VA = "0x187995340", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		protected struct HKMKLBKJBDJ : IComparable<HKMKLBKJBDJ>, IEquatable<HKMKLBKJBDJ>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000355")]
			public int GAMDMHFGKKK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000356")]
			public PlayerAvatarDisplayBase KCDPOCMBOHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000357")]
			public IList<IKELHKNDDPA> JOLJOLBLELL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000358")]
			public AvatarItemBodyType MCILHOEMOJJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000359")]
			public GKEGCDPOLMK CPKDABOMKJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400035A")]
			public bool EIFBLAFPOHC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400035B")]
			public int[] NFJGPMPHDCD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400035C")]
			public float MLANLEIGIEB;

			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x7995C80", Offset = "0x7994480", VA = "0x187995C80", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x7995B20", Offset = "0x7994320", VA = "0x187995B20", Slot = "4")]
			public int CompareTo(HKMKLBKJBDJ PGPJMFPAKOO)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x7995B40", Offset = "0x7994340", VA = "0x187995B40", Slot = "5")]
			public bool Equals(HKMKLBKJBDJ PGPJMFPAKOO)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		protected abstract class MJFHMLPJNNP
		{
			[Cpp2IlInjected.Token(Token = "0x200005B")]
			public class KLKFABCCBOA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000360")]
				public readonly Mesh JHGJDPBIIIO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000361")]
				public readonly Material[] JJEFBDJBDLA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000362")]
				public readonly Transform[] PHFFNKEOCCH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000363")]
				public readonly Matrix4x4[] JHEIPHBBFJL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000364")]
				public readonly Transform HLDPCAMCEKF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000365")]
				public readonly bool BOHHOCKCKCA;

				[Cpp2IlInjected.Token(Token = "0x60002FC")]
				[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
				protected KLKFABCCBOA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002FD")]
				[Cpp2IlInjected.Address(RVA = "0x7996E50", Offset = "0x7995650", VA = "0x187996E50")]
				public KLKFABCCBOA(Mesh ABAPBBKNPBC, Material[] DOAHBNAHEIP, bool HANGCNGDKNF, Transform[] HODLOHLIOFK, Transform HOKMAKOFCNA, Matrix4x4[] JFKLOPLBLKK)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002FE")]
				[Cpp2IlInjected.Address(RVA = "0x7997300", Offset = "0x7995B00", VA = "0x187997300")]
				private KLKFABCCBOA(SkinnedMeshRenderer CCHCFBGLLFL, Material[] HNAJPAELIIB)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002FF")]
				[Cpp2IlInjected.Address(RVA = "0x7996D60", Offset = "0x7995560", VA = "0x187996D60")]
				private KLKFABCCBOA(MeshRenderer MGFHHNMELPK, Transform HOKMAKOFCNA, Material[] HNAJPAELIIB)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000300")]
				[Cpp2IlInjected.Address(RVA = "0x7996A40", Offset = "0x7995240", VA = "0x187996A40")]
				public static KLKFABCCBOA CPBALNPMHLD(Renderer JGPHFKDOCBN, Material[] HNAJPAELIIB)
				{
					return null;
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400035D")]
			public readonly PNLIIGCPIIK NLNKGOHMIHB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400035E")]
			public readonly Transform MEMHDEBEKJK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400035F")]
			public readonly bool NPJPAAFPPNN;

			[Cpp2IlInjected.Token(Token = "0x1700008C")]
			public virtual bool LPEHGKJGNJE
			{
				[Cpp2IlInjected.Token(Token = "0x60002F5")]
				[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008D")]
			public virtual bool FKPMFBDBNBN
			{
				[Cpp2IlInjected.Token(Token = "0x60002F6")]
				[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008E")]
			public virtual HHPKDLEJEOP.OOIFDIEICOH DOAJGOPDLJM
			{
				[Cpp2IlInjected.Token(Token = "0x60002F7")]
				[Cpp2IlInjected.Address(RVA = "0x9DECC0", Offset = "0x9DD4C0", VA = "0x1809DECC0", Slot = "6")]
				get
				{
					return default(HHPKDLEJEOP.OOIFDIEICOH);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008F")]
			public bool MEDEIDLELGO
			{
				[Cpp2IlInjected.Token(Token = "0x60002F8")]
				[Cpp2IlInjected.Address(RVA = "0x79975C0", Offset = "0x7995DC0", VA = "0x1879975C0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x79975D0", Offset = "0x7995DD0", VA = "0x1879975D0")]
			protected MJFHMLPJNNP(PNLIIGCPIIK MDILONMHHMF, Transform BNBDGMKJCFI, bool JKALHPINPCJ = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract ELBPMMKABPA OLPPPFBDNHB(List<IAIDKAIACPE> CPPEGJHNHCC, List<IAIDKAIACPE> MNHPBJAJLBN);

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract KLKFABCCBOA GOJAMDOCNOG(int BIPGHKPGBAC, PlayerHandBones NHIFAOLFDPI);
		}

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		protected class PGBCLGEJJNF : MJFHMLPJNNP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000366")]
			protected readonly BodyPartLODs CBLLOCPBLKI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000367")]
			protected readonly Material[] AFFNPAAIHNJ;

			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x7998510", Offset = "0x7996D10", VA = "0x187998510")]
			public PGBCLGEJJNF(PNLIIGCPIIK MDILONMHHMF, BodyPartLODs MNCOCNPBFIJ, Material LLOMLGDFLLC, [Optional] Transform BNBDGMKJCFI, bool JKALHPINPCJ = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0x7998410", Offset = "0x7996C10", VA = "0x187998410", Slot = "7")]
			public override ELBPMMKABPA OLPPPFBDNHB(List<IAIDKAIACPE> CPPEGJHNHCC, List<IAIDKAIACPE> MNHPBJAJLBN)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x7998250", Offset = "0x7996A50", VA = "0x187998250", Slot = "8")]
			public override KLKFABCCBOA GOJAMDOCNOG(int BIPGHKPGBAC, PlayerHandBones NHIFAOLFDPI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x79984A0", Offset = "0x7996CA0", VA = "0x1879984A0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005D")]
		protected class DFEPDMOLMCL : MJFHMLPJNNP
		{
			[Cpp2IlInjected.Token(Token = "0x17000090")]
			public override bool LPEHGKJGNJE
			{
				[Cpp2IlInjected.Token(Token = "0x6000305")]
				[Cpp2IlInjected.Address(RVA = "0x9F9540", Offset = "0x9F7D40", VA = "0x1809F9540", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000091")]
			public override bool FKPMFBDBNBN
			{
				[Cpp2IlInjected.Token(Token = "0x6000306")]
				[Cpp2IlInjected.Address(RVA = "0x7994B40", Offset = "0x7993340", VA = "0x187994B40", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000092")]
			public PNHCLNCDOAA NJOHAKIGIOP
			{
				[Cpp2IlInjected.Token(Token = "0x6000307")]
				[Cpp2IlInjected.Address(RVA = "0x9DF790", Offset = "0x9DDF90", VA = "0x1809DF790")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000308")]
				[Cpp2IlInjected.Address(RVA = "0x9DF780", Offset = "0x9DDF80", VA = "0x1809DF780")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0x7994C90", Offset = "0x7993490", VA = "0x187994C90")]
			public DFEPDMOLMCL(PNLIIGCPIIK MDILONMHHMF, Transform BNBDGMKJCFI, PNHCLNCDOAA BIOAJNKDOMN, bool JKALHPINPCJ = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0x7994B90", Offset = "0x7993390", VA = "0x187994B90", Slot = "7")]
			public override ELBPMMKABPA OLPPPFBDNHB(List<IAIDKAIACPE> CPPEGJHNHCC, List<IAIDKAIACPE> MNHPBJAJLBN)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0x9DECC0", Offset = "0x9DD4C0", VA = "0x1809DECC0", Slot = "8")]
			public override KLKFABCCBOA GOJAMDOCNOG(int BIPGHKPGBAC, PlayerHandBones NHIFAOLFDPI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0x7994C20", Offset = "0x7993420", VA = "0x187994C20", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005E")]
		public class BCPOPBGAHMA
		{
			[Cpp2IlInjected.Token(Token = "0x200005F")]
			public enum EIHHAEJHGGI
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
			public static readonly int DOAKNLEOGBE;

			[Cpp2IlInjected.Token(Token = "0x400036A")]
			public static readonly int IAAIFCMINIO;

			[Cpp2IlInjected.Token(Token = "0x400036B")]
			public static readonly int BBFBEOEDKNH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400036C")]
			protected readonly ELGEGIFKKGD MOFOOFPBFBC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400036D")]
			protected readonly IAJDFJCEOHK AFLBLBPKOJN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400036E")]
			protected readonly Animator LMMBLCNMFGE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400036F")]
			protected readonly Transform MGHOLEMMCHP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000370")]
			protected readonly Vector3 HHCPOMIIOCC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000371")]
			protected readonly Transform MDNHIAOFBNC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000372")]
			protected readonly Vector3 OBIMPPPNBPE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000373")]
			protected bool JMODMNBNKGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000374")]
			protected NDBEIHDKPNF LHPJCMGBCLC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000375")]
			protected bool JBCDPMLAAPC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x4000376")]
			protected float DLHIGJPKMKK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000377")]
			protected KPIDBFOJEAM<CFPNNJDNDCC> NEHAPNILCBG;

			[Cpp2IlInjected.Token(Token = "0x17000093")]
			public NDBEIHDKPNF CDKEFFKFGHN
			{
				[Cpp2IlInjected.Token(Token = "0x600030D")]
				[Cpp2IlInjected.Address(RVA = "0x9DD230", Offset = "0x9DBA30", VA = "0x1809DD230")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600030E")]
				[Cpp2IlInjected.Address(RVA = "0x9DD1D0", Offset = "0x9DB9D0", VA = "0x1809DD1D0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000094")]
			public bool CNOIGJHMLJP
			{
				[Cpp2IlInjected.Token(Token = "0x600030F")]
				[Cpp2IlInjected.Address(RVA = "0xBCE330", Offset = "0xBCCB30", VA = "0x180BCE330")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000310")]
				[Cpp2IlInjected.Address(RVA = "0x7993240", Offset = "0x7991A40", VA = "0x187993240")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000095")]
			public bool IEBGMNPHMMF
			{
				[Cpp2IlInjected.Token(Token = "0x6000311")]
				[Cpp2IlInjected.Address(RVA = "0x9E24B0", Offset = "0x9E0CB0", VA = "0x1809E24B0")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000312")]
				[Cpp2IlInjected.Address(RVA = "0x7993170", Offset = "0x7991970", VA = "0x187993170")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000096")]
			public float IIIPCOBDCJG
			{
				[Cpp2IlInjected.Token(Token = "0x6000313")]
				[Cpp2IlInjected.Address(RVA = "0xC466D0", Offset = "0xC44ED0", VA = "0x180C466D0")]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000314")]
				[Cpp2IlInjected.Address(RVA = "0x79936A0", Offset = "0x7991EA0", VA = "0x1879936A0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000097")]
			public CFPNNJDNDCC JINBKFMNBDL
			{
				[Cpp2IlInjected.Token(Token = "0x6000315")]
				[Cpp2IlInjected.Address(RVA = "0x79930E0", Offset = "0x79918E0", VA = "0x1879930E0")]
				get
				{
					return default(CFPNNJDNDCC);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x7992F10", Offset = "0x7991710", VA = "0x187992F10")]
			public bool BFFCEOCAIFM(CFPNNJDNDCC CKHCKOICGEI, object JILOCOLKOMJ, EIHHAEJHGGI IEAGNNNDKKH)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x79937E0", Offset = "0x7991FE0", VA = "0x1879937E0")]
			public bool NAMELLHEOML(object JILOCOLKOMJ)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x7994090", Offset = "0x7992890", VA = "0x187994090")]
			protected BCPOPBGAHMA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0x7993AA0", Offset = "0x79922A0", VA = "0x187993AA0")]
			public BCPOPBGAHMA(ELGEGIFKKGD MOFOOFPBFBC, NDBEIHDKPNF GMALKCILJOC, Animator LMMBLCNMFGE, Transform MGHOLEMMCHP, Transform MDNHIAOFBNC, Vector3 HHCPOMIIOCC, Vector3 OBIMPPPNBPE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0x79935F0", Offset = "0x7991DF0", VA = "0x1879935F0")]
			private void KMDKKCLEGDB(ushort GJDIKOACLLN, ushort DNOIGNCJMBD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x7992E20", Offset = "0x7991620", VA = "0x187992E20")]
			protected void BDOLCFIJJGM(ushort GJDIKOACLLN, ushort DNOIGNCJMBD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x7993020", Offset = "0x7991820", VA = "0x187993020")]
			protected void CALFNGJBPAA(ushort GJDIKOACLLN, ushort DNOIGNCJMBD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x7993360", Offset = "0x7991B60", VA = "0x187993360")]
			protected void JJOFHDCNNOM(ushort GJDIKOACLLN, ushort DNOIGNCJMBD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x79934E0", Offset = "0x7991CE0", VA = "0x1879934E0")]
			protected void KLFFDBMJAAJ(ushort GJDIKOACLLN, ushort DNOIGNCJMBD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x7993480", Offset = "0x7991C80", VA = "0x187993480")]
			protected void JNHCMDDBNGG(ushort GJDIKOACLLN, ushort DNOIGNCJMBD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x7993310", Offset = "0x7991B10", VA = "0x187993310")]
			protected void JIMNOBMPKDN(ushort GJDIKOACLLN, ushort DNOIGNCJMBD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x7993120", Offset = "0x7991920", VA = "0x187993120")]
			protected void EBJIAIAJEBB(ushort GJDIKOACLLN, ushort DNOIGNCJMBD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x79938E0", Offset = "0x79920E0", VA = "0x1879938E0")]
			protected void OCMBOFJEPNI(ushort GJDIKOACLLN, ushort DNOIGNCJMBD)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000060")]
		public class ALLCBLIOLGB : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x4000380")]
			public const int MGHFFAJHCLK = 16;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000381")]
			protected MaterialPropertyBlock OCCKEIMIMDG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000382")]
			public Color? MEHEKLAKENE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000383")]
			public Color? PLNHGLJAGMJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000384")]
			public Color? CIPEHBAGAGK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000385")]
			public Color JJAHBNNEDOC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x4000386")]
			public Color AKBDLNIACIL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x4000387")]
			public Color BMFKBDBBCFH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000388")]
			public Texture2D NGIELPPFEAJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000389")]
			public Texture2D PPEDODIBJME;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x400038A")]
			protected Dictionary<FJIABMDFBND, int> JDJEBBAHLBG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x400038B")]
			protected CNIPHPLMKHC[] APCFNBGFKHB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x400038C")]
			public Vector4[] IMFMFNNNFGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x400038D")]
			public Vector4[] LCBNFGDJDCD;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x400038E")]
			public Vector4[] OPOCJAABHEL;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			public Vector4[] BLLHOHIDIGD;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x4000390")]
			public Vector4[] HLPMJJEHNHF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000391")]
			public Vector4[] AJOGCKCHKPH;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000392")]
			protected List<Texture2D> FKCGNOLJOJE;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000393")]
			protected Vector4[] CFLGCDICDJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
			[Cpp2IlInjected.Token(Token = "0x4000394")]
			protected List<Texture2D> JCBJDBMPMLL;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
			[Cpp2IlInjected.Token(Token = "0x4000395")]
			protected float[] JJJNLIHCJFB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
			[Cpp2IlInjected.Token(Token = "0x4000396")]
			protected Vector4[] NHCLNLMODKC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x4000397")]
			protected float[] EFOCPCMJBEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
			[Cpp2IlInjected.Token(Token = "0x4000398")]
			public float[] IAHBGOFDDFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
			[Cpp2IlInjected.Token(Token = "0x4000399")]
			protected List<Texture2D> FJNHLHDBJOK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
			[Cpp2IlInjected.Token(Token = "0x400039A")]
			protected float[] DJFNCPGPCEH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
			[Cpp2IlInjected.Token(Token = "0x400039B")]
			protected List<Texture2D> OKOHMICMHOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			protected Vector4[] EIAFPGPGICD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
			[Cpp2IlInjected.Token(Token = "0x400039D")]
			protected float[] PIMJIIOLDGD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
			[Cpp2IlInjected.Token(Token = "0x400039E")]
			protected Vector4[] BKLCNDJIFDG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x400039F")]
			public float[] DFACMHGNDKL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
			[Cpp2IlInjected.Token(Token = "0x40003A0")]
			public Texture2DArray PFKNEIPKOBG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x40003A1")]
			public Texture2DArray LJJLKDFFLAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
			[Cpp2IlInjected.Token(Token = "0x40003A2")]
			public Texture2DArray MIEGLPGJJMA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
			[Cpp2IlInjected.Token(Token = "0x40003A3")]
			public Texture2DArray NMAGGALCCBC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x40003A4")]
			protected bool EEBFLCJMFOL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
			[Cpp2IlInjected.Token(Token = "0x40003A5")]
			protected int AFBDKIHJOOL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
			[Cpp2IlInjected.Token(Token = "0x40003A6")]
			protected Vector2? BBOIIBEJNOG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
			[Cpp2IlInjected.Token(Token = "0x40003A7")]
			protected TextureFormat MGMBKLJEFOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
			[Cpp2IlInjected.Token(Token = "0x40003A8")]
			protected Vector2? BHHBFIDDLJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
			[Cpp2IlInjected.Token(Token = "0x40003A9")]
			protected TextureFormat JGIEMBIKBNE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
			[Cpp2IlInjected.Token(Token = "0x40003AA")]
			protected Vector2? NDKBKBOMBDE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
			[Cpp2IlInjected.Token(Token = "0x40003AB")]
			protected TextureFormat MCNFDPCKJMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
			[Cpp2IlInjected.Token(Token = "0x40003AC")]
			protected Vector2? ELAHGBMMJNH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
			[Cpp2IlInjected.Token(Token = "0x40003AD")]
			protected TextureFormat DFOEHGGFDNK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
			[Cpp2IlInjected.Token(Token = "0x40003AE")]
			protected bool HGKGNONOPPK;

			[Cpp2IlInjected.Token(Token = "0x40003AF")]
			protected static int AKNAGBLKIHG;

			[Cpp2IlInjected.Token(Token = "0x40003B0")]
			protected static int DALDOGMJPOG;

			[Cpp2IlInjected.Token(Token = "0x40003B1")]
			protected static int KMANELKKJKI;

			[Cpp2IlInjected.Token(Token = "0x40003B2")]
			protected static int HBNPMGKCAMG;

			[Cpp2IlInjected.Token(Token = "0x40003B3")]
			protected static int JNJCLAFNDBG;

			[Cpp2IlInjected.Token(Token = "0x40003B4")]
			protected static int PLHOJFEBDBL;

			[Cpp2IlInjected.Token(Token = "0x40003B5")]
			protected static int GILJCPNDEIB;

			[Cpp2IlInjected.Token(Token = "0x40003B6")]
			protected static int JFFPFBBOILG;

			[Cpp2IlInjected.Token(Token = "0x40003B7")]
			protected static int CIFDNMONGBC;

			[Cpp2IlInjected.Token(Token = "0x40003B8")]
			protected static int AGAOACHMBAA;

			[Cpp2IlInjected.Token(Token = "0x40003B9")]
			protected static int CKNOGBPBPMJ;

			[Cpp2IlInjected.Token(Token = "0x40003BA")]
			protected static int GBHFLBIFLHH;

			[Cpp2IlInjected.Token(Token = "0x40003BB")]
			protected static int OFEKIPKDLCL;

			[Cpp2IlInjected.Token(Token = "0x40003BC")]
			protected static int MBJCFKCNPAJ;

			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			protected static int FFEKPMFGBNG;

			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			protected static int LELIFHIPFFM;

			[Cpp2IlInjected.Token(Token = "0x40003BF")]
			protected static int FANHNEGCIHE;

			[Cpp2IlInjected.Token(Token = "0x40003C0")]
			protected static int BMGNGGLBDPJ;

			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			protected static int MNMCHDOENOB;

			[Cpp2IlInjected.Token(Token = "0x40003C2")]
			protected static int BMNBDLHJJMM;

			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x7992960", Offset = "0x7991160", VA = "0x187992960")]
			protected ALLCBLIOLGB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x79928D0", Offset = "0x79910D0", VA = "0x1879928D0")]
			public ALLCBLIOLGB(Color GKIKDNIBDLJ, Color OLBBCMGGNOB, Color BIGBKBCGGNN, Color? FMMKLDBMEBN, Color? EMIOMMAPOFD, Color? OMJPBCDLOEA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x79920E0", Offset = "0x79908E0", VA = "0x1879920E0")]
			public int IAGMEHOFIBB(Material LFMNNDCMMGC, CNIPHPLMKHC DEODPNNAHDB, BHHEHLDEJFH IHEENGIGNMA, PNLIIGCPIIK MDILONMHHMF)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x7992050", Offset = "0x7990850", VA = "0x187992050")]
			public int IAGMEHOFIBB(FJIABMDFBND BELIEAFHDAH)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x7991360", Offset = "0x798FB60", VA = "0x187991360")]
			public int FOKBEGOEHNA(Material LFMNNDCMMGC, Color FPFEOKGHPHB, Color PDFDAEFEJLA, Color CMKKLECIAMK, Color BFOBPBHBHKF, Color GOEMDOOCABH, Texture2D GCEKLDNBLCC, Vector4 HIIPPBBPEGI, Texture2D AIOJKGBMPCG, Vector4 EDCFFJNPDPN, float GNOFDMMFNOI, float ONGNDMFINFJ, Texture2D NKDAMFIHMKC, Vector4 INGIEIAEIAK, float EPBABECPJDH, Texture2D KDBEIAAPEEH, float HBFOEDJCONP, Color LDHHMAHGKGE, Vector4 LNBGJEOLCNK, CNIPHPLMKHC DEODPNNAHDB, BHHEHLDEJFH IHEENGIGNMA, PNLIIGCPIIK MDILONMHHMF)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x79923C0", Offset = "0x7990BC0", VA = "0x1879923C0")]
			protected void PAAHNEIFPBH([Out] Texture2DArray MOALABAIHNE, [Out] Texture2DArray FHJGKLMMGMD, [Out] Texture2DArray LCGDKEKBBHM, [Out] Texture2DArray MIDGKAPOJEJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x79903F0", Offset = "0x798EBF0", VA = "0x1879903F0")]
			public void CJKKKFINCOA(PlayerAvatarDisplayBase LEOBIMPFAMO, Renderer JGPHFKDOCBN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x7990650", Offset = "0x798EE50", VA = "0x187990650")]
			protected void DHEDFGBBJMA(PlayerAvatarDisplayBase LEOBIMPFAMO, Renderer JGPHFKDOCBN, int BODBCFHPHMI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x79921D0", Offset = "0x79909D0", VA = "0x1879921D0")]
			private Color OCMMMIHFLJP(Color JIDFMDLOPPP, CNIPHPLMKHC IFFOBJIAHML)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x7991140", Offset = "0x798F940", VA = "0x187991140")]
			private Color DJMPOOGLDAG(Color OFJAHOKBADK, CNIPHPLMKHC IFFOBJIAHML)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x7991290", Offset = "0x798FA90", VA = "0x187991290")]
			protected void DMNBPJAKBGP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x7991320", Offset = "0x798FB20", VA = "0x187991320", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x799EA60", Offset = "0x799D260", VA = "0x18799EA60")]
			public void GOPHCJEKOKP(PNLIIGCPIIK MDILONMHHMF, [Out] Transform PNDCHGJLEGG, [Out] Transform[] HODLOHLIOFK)
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
		private sealed class ADFOAKDPFKD : IEnumerable<SkinnedMeshRenderer>, IEnumerable, IEnumerator<SkinnedMeshRenderer>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0xE73320", Offset = "0xE71B20", VA = "0x180E73320")]
			[DebuggerHidden]
			public ADFOAKDPFKD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x798FAD0", Offset = "0x798E2D0", VA = "0x18798FAD0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x798FD50", Offset = "0x798E550", VA = "0x18798FD50", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x798FCA0", Offset = "0x798E4A0", VA = "0x18798FCA0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<SkinnedMeshRenderer> IEnumerable<SkinnedMeshRenderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x798FCA0", Offset = "0x798E4A0", VA = "0x18798FCA0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000065")]
		[CompilerGenerated]
		private sealed class JLINNKOJKCK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003D6")]
			public PlayerAvatarDisplayBase display;

			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public JLINNKOJKCK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x7996960", Offset = "0x7995160", VA = "0x187996960")]
			internal bool KDGHFKNEFCL()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class AFEJBHLFNFG : IEnumerator<IGCELENFGND>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003D7")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003D8")]
			private IGCELENFGND <>2__current;

			[Cpp2IlInjected.Token(Token = "0x1700009A")]
			private IGCELENFGND System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000347")]
				[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x9EBF30", Offset = "0x9EA730", VA = "0x1809EBF30")]
			[DebuggerHidden]
			public AFEJBHLFNFG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0x798FDA0", Offset = "0x798E5A0", VA = "0x18798FDA0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(RVA = "0x7990170", Offset = "0x798E970", VA = "0x187990170", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000067")]
		[CompilerGenerated]
		private struct MPDMBPOJNIO : IAsyncStateMachine
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
			public AHOGOONMGAK avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003DD")]
			private bool <forceRebuild>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003DE")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0x7997710", Offset = "0x7995F10", VA = "0x187997710", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x7997FE0", Offset = "0x79967E0", VA = "0x187997FE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000068")]
		[CompilerGenerated]
		private sealed class MLPBJFJLPIC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003DF")]
			public string overrideIdentifier;

			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public MLPBJFJLPIC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0x7997630", Offset = "0x7995E30", VA = "0x187997630")]
			internal bool GMDPLMIMDPE(IKELHKNDDPA selection)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000069")]
		[CompilerGenerated]
		private sealed class IMJMIKJKMII
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003E0")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003E1")]
			public AvatarItemBodyType avatarItemBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003E2")]
			public Func<KJPDFMLMKLI<Dictionary<string, GOANNPAHNKI<Texture2D>>>> <>9__2;

			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public IMJMIKJKMII()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0x7996520", Offset = "0x7994D20", VA = "0x187996520")]
			internal (LLDEFGHLBOH, KJPDFMLMKLI<Dictionary<string, GOANNPAHNKI<Texture2D>>>) PKCMEHGCCMJ(Dictionary<string, KNAIBICOJFM> avatarItems)
			{
				return default((LLDEFGHLBOH, KJPDFMLMKLI<Dictionary<string, GOANNPAHNKI<Texture2D>>>));
			}

			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0x79964B0", Offset = "0x7994CB0", VA = "0x1879964B0")]
			internal KJPDFMLMKLI<Dictionary<string, GOANNPAHNKI<Texture2D>>> PEMBLCJEAOD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x7996470", Offset = "0x7994C70", VA = "0x187996470")]
			internal void NOEHBDJBKFI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006A")]
		[CompilerGenerated]
		private sealed class MPALPNIOMBF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003E3")]
			public Transform transformToCheck;

			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public MPALPNIOMBF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x7997660", Offset = "0x7995E60", VA = "0x187997660")]
			internal bool DENEHEBLGGC(SkinnedMeshRenderer x)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006B")]
		[CompilerGenerated]
		private struct AJMIBHOOLED : IAsyncStateMachine
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
			[Cpp2IlInjected.Address(RVA = "0x79901C0", Offset = "0x798E9C0", VA = "0x1879901C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0x7990390", Offset = "0x798EB90", VA = "0x187990390", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		protected static readonly int DALEPHNPMKG;

		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		protected static readonly int FJALLMJILEF;

		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		protected static readonly int ABHELKOKCBB;

		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		protected static readonly int FKBDIJMCCDE;

		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		protected static readonly int CFIBMLHJJCI;

		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		protected static readonly int JDGLOFBNNFJ;

		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		protected static readonly int[] CCIGMBINAEC;

		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		protected static readonly int[] LLIOJPPMPDE;

		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		protected static readonly int[] BCPADJAMEMG;

		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		protected static readonly int[] OKJLANCDLDM;

		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		protected static readonly int[] DFICMIHGLBD;

		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		protected static readonly int[] IGOILFDJCKD;

		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		protected static List<PlayerAvatarDisplayBase> KNIJFHAKJFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		protected LHGCMFLMCGH OJPNFPHDOOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		protected bool EEAOOBHHOMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		protected bool JEGHNMNFCDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		[SerializeField]
		public AvatarBodyShapeVault BodyShapeVault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		[SerializeField]
		public AvatarFaceShapeVault FaceShapeVault;

		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		protected static readonly int[] GCAHGGDCAHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		[SerializeField]
		protected Material bodyPartMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		protected Dictionary<FJIABMDFBND, Material> JKDKJELHNJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		protected Dictionary<FJIABMDFBND, Material> EEEMGILEALJ;

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
		protected Material MBCNJEIEEPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		protected MKBPDMPFCMC LDPGIMKDJDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		private NDBEIHDKPNF ILPFFCHGJNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		private NDBEIHDKPNF EPMGJAGAANH;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		protected Material BAKCLMJDFGB;

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
		protected FitMeshHemisphere ECDEMKPAJBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		protected bool JAEHABCLGCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		protected PNINFJFLLCD FBMHFMJGHMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		protected bool PGIPLEAOHKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		protected AnchorParamsRestrictions DPFCGKICJNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		protected bool EOLDKDNOJLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		protected Transform MGDCKCKADNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		protected bool NBIOAJMMLFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B1")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		protected bool OAJGCAMHGAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		protected Vector3 JIBDKKIGOCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		protected Quaternion JPJCFGOJDDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		protected Vector2 OMCPCOJODPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		protected FitMeshHemisphere HGKGIAOLJPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		[DAFFCFHPHBO(HNCMILCNFNF.SelfAndChildren, false, false, false)]
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
		protected Collider[] IKJLPPPPFPF;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		protected Collider[] DBCDBEKCPEK;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		protected BCPOPBGAHMA[] CIPDPICGOPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		[SerializeField]
		protected Mesh faceMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public Dictionary<Renderer, ALLCBLIOLGB> currentPropertyBlocks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		protected Dictionary<Renderer, ALLCBLIOLGB> FDGNPPIDCGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		protected FIOHGAFMEBA GDMNJKADNCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		protected LLDEFGHLBOH AFKHJJMIHHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public GLBLJMJHHNB DistanceBand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x284")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		protected int IKOIFAIJFME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		protected (bool isLodForced, int forcedLOD) NHIEOCJDGNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		protected KPIDBFOJEAM<IAJDFJCEOHK> NEHAPNILCBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		protected bool LHOGHNAIAIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		protected Dictionary<IKELHKNDDPA, List<FJIABMDFBND>> AKCKMBNEOAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		protected Dictionary<IKELHKNDDPA, List<FJIABMDFBND>> NJHOIJAMPKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		protected readonly Dictionary<string, GOANNPAHNKI<Texture2D>> GCGPOHDPEEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		protected readonly Dictionary<string, GOANNPAHNKI<Texture2D>> JIKIHBJCEIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		protected bool NJMOPEFHDFN;

		[Cpp2IlInjected.Token(Token = "0x400031C")]
		protected static int DIOJLFJFEAA;

		[Cpp2IlInjected.Token(Token = "0x400031D")]
		protected static List<HKMKLBKJBDJ> KFECCDMCADG;

		[Cpp2IlInjected.Token(Token = "0x400031E")]
		protected static List<HKMKLBKJBDJ> LHMBJEAPDEI;

		[Cpp2IlInjected.Token(Token = "0x400031F")]
		protected static KIJPFMOACHH NNANDCEFDHM;

		[Cpp2IlInjected.Token(Token = "0x4000320")]
		protected static bool HMPIDGNPEIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		protected Color? JHKKJBAIIIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E4")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		protected bool NHIPMBMAHKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		protected Color JCNANHDLFLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		protected Color MKCLDBFMPFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		protected Color GJGBCGIBFIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		protected AvatarHairPattern CGCLADIHGAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		protected PNHCLNCDOAA KJGKMGEDDOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		protected Color PBBFNPNEKMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		protected Color EDCAIGOMOMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		protected AvatarHairPattern EIGHINFIGEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		protected PNHCLNCDOAA GOEALPIDGMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		protected PNHCLNCDOAA DOAKEGMANLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		protected Color CONADCAAKFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		private AdditionalFeetData OIDEAOKHDHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		protected IKELHKNDDPA? NDICCCDIPDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		protected Texture AFMIIOEDGOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		protected Color LJJNALMIFCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		protected readonly IList<IKELHKNDDPA> DFLPEDHLPCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		protected readonly IList<IKELHKNDDPA> GLFJAOFAIDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		private AvatarItemBodyType DNCBJAJCFNP;

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
		protected DPOJOKMIJDG _currentNoseType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D4")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		[SerializeField]
		protected bool _hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D5")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		protected GNMOMKEJAIC HHPCBMFGIPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		protected int[] KHKGMDNPPIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E0")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		protected bool LOEEOPDFCLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E8")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		protected int[] IEHIMIHMPLH;

		[Cpp2IlInjected.Token(Token = "0x400033D")]
		private static readonly HHPKDLEJEOP.OOIFDIEICOH HAIOEHGEBMO;

		[Cpp2IlInjected.Token(Token = "0x400033E")]
		private static readonly HHPKDLEJEOP.OOIFDIEICOH EBKMOMDPOBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F0")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		protected bool EDMAABCMLHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F8")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		protected NLDCDOOJMDE HFALMBBKIAI;

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public string BLHMGEIBBKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x9E0DB0", Offset = "0x9DF5B0", VA = "0x1809E0DB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x9E0DC0", Offset = "0x9DF5C0", VA = "0x1809E0DC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public bool IEMAMIOFEPL
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0xBE2D10", Offset = "0xBE1510", VA = "0x180BE2D10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0xBE24A0", Offset = "0xBE0CA0", VA = "0x180BE24A0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public virtual bool CPCOKNCJFOI
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public bool ICDLAHPMGFP
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x798E4F0", Offset = "0x798CCF0", VA = "0x18798E4F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public virtual bool OCDENIKLOMB
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public virtual bool BBMDIBPHDAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x9F9540", Offset = "0x9F7D40", VA = "0x1809F9540", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public virtual bool OLCAIGKHKKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public MKBPDMPFCMC GBBCKHIFMNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0xA88030", Offset = "0xA86830", VA = "0x180A88030")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x798ECA0", Offset = "0x798D4A0", VA = "0x18798ECA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public NDBEIHDKPNF DPPBNCMHJLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0xA898F0", Offset = "0xA880F0", VA = "0x180A898F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x798F0A0", Offset = "0x798D8A0", VA = "0x18798F0A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public NDBEIHDKPNF LPKJCIGBGMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0xA9DCD0", Offset = "0xA9C4D0", VA = "0x180A9DCD0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x798F370", Offset = "0x798DB70", VA = "0x18798F370")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		protected Material LFFDMDPKHJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x7988CD0", Offset = "0x79874D0", VA = "0x187988CD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		protected Material LGPNINNONBA
		{
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x79874D0", Offset = "0x7985CD0", VA = "0x1879874D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public bool ANNNMPECOBA
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x21783B0", Offset = "0x2176BB0", VA = "0x1821783B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public PlayerFacialAnimatorBase OGDGHEGEHHA
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0xA9DEE0", Offset = "0xA9C6E0", VA = "0x180A9DEE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public BCPOPBGAHMA[] HCPPCFIBBPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x798E0C0", Offset = "0x798C8C0", VA = "0x18798E0C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public BCPOPBGAHMA JCJDNAOGDBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x798E6E0", Offset = "0x798CEE0", VA = "0x18798E6E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public BCPOPBGAHMA POOIIOGFHIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x798E710", Offset = "0x798CF10", VA = "0x18798E710")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public Mesh LABFGBPCKDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0xA9E6F0", Offset = "0xA9CEF0", VA = "0x180A9E6F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		protected FIOHGAFMEBA MDPPMCEDEMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x7984EF0", Offset = "0x79836F0", VA = "0x187984EF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		protected LLDEFGHLBOH CAEJBAFMKFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0xA9EA80", Offset = "0xA9D280", VA = "0x180A9EA80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x7986510", Offset = "0x7984D10", VA = "0x187986510")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		protected bool HAIFIFEKBGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x9F9540", Offset = "0x9F7D40", VA = "0x1809F9540")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public bool BDDMNBAGMJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x798E6D0", Offset = "0x798CED0", VA = "0x18798E6D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public int CNAELNJIJHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x11AE760", Offset = "0x11ACF60", VA = "0x1811AE760")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x798F2B0", Offset = "0x798DAB0", VA = "0x18798F2B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public int LFLLLNGDDGE
		{
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x798EFF0", Offset = "0x798D7F0", VA = "0x18798EFF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		protected virtual bool KIIBDEJODKE
		{
			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		protected virtual int[] MMJJNDHBJKF
		{
			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x7988560", Offset = "0x7986D60", VA = "0x187988560", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		protected bool OLCMDPKCJBE
		{
			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x7986490", Offset = "0x7984C90", VA = "0x187986490")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		protected static bool CBMMGECAOKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public bool DDAAJACBFIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x11AD770", Offset = "0x11ABF70", VA = "0x1811AD770")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x798F580", Offset = "0x798DD80", VA = "0x18798F580")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public IEnumerable<SkinnedMeshRenderer> NDGDBANMOAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x798DFA0", Offset = "0x798C7A0", VA = "0x18798DFA0")]
			[IteratorStateMachine(typeof(ADFOAKDPFKD))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public bool ABPKKBNEOIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x11AEA90", Offset = "0x11AD290", VA = "0x1811AEA90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x11AE130", Offset = "0x11AC930", VA = "0x1811AE130")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public DODMAGIBHBA DCHHGBFKGNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x798E020", Offset = "0x798C820", VA = "0x18798E020")]
			get
			{
				return default(DODMAGIBHBA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public static bool KLICNLJGPIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x798E460", Offset = "0x798CC60", VA = "0x18798E460")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		protected static KIJPFMOACHH HMOEHMJOMHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x7986EA0", Offset = "0x79856A0", VA = "0x187986EA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0x7988B10", Offset = "0x7987310", VA = "0x187988B10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		protected Color PLNHGLJAGMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0x7985B70", Offset = "0x7984370", VA = "0x187985B70")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		protected Color CIPEHBAGAGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0x7988F10", Offset = "0x7987710", VA = "0x187988F10")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		protected Texture2D GDJLHJBMFDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000291")]
			[Cpp2IlInjected.Address(RVA = "0x79899A0", Offset = "0x79881A0", VA = "0x1879899A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		protected Color JJAHBNNEDOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000297")]
			[Cpp2IlInjected.Address(RVA = "0x7987CF0", Offset = "0x79864F0", VA = "0x187987CF0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		protected Color AKBDLNIACIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(RVA = "0x7988460", Offset = "0x7986C60", VA = "0x187988460")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public PNHCLNCDOAA EGKBKKNCOHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000299")]
			[Cpp2IlInjected.Address(RVA = "0x798E080", Offset = "0x798C880", VA = "0x18798E080")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		protected Texture2D PKLGMLNCANB
		{
			[Cpp2IlInjected.Token(Token = "0x600029A")]
			[Cpp2IlInjected.Address(RVA = "0x7981040", Offset = "0x797F840", VA = "0x187981040")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public float NJICGHDLMFL
		{
			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(RVA = "0x798E0A0", Offset = "0x798C8A0", VA = "0x18798E0A0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public float LCGNIONJIEN
		{
			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0x798E4D0", Offset = "0x798CCD0", VA = "0x18798E4D0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public bool EAPPBKILGFP
		{
			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x131AE90", Offset = "0x1319690", VA = "0x18131AE90")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x798EA80", Offset = "0x798D280", VA = "0x18798EA80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action HLILNHINGBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x798DD00", Offset = "0x798C500", VA = "0x18798DD00")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x798E7E0", Offset = "0x798CFE0", VA = "0x18798E7E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action KBNJIAJFEHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x798DC60", Offset = "0x798C460", VA = "0x18798DC60")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x798E740", Offset = "0x798CF40", VA = "0x18798E740")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action GGIPKPJBMAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x798DDA0", Offset = "0x798C5A0", VA = "0x18798DDA0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x798E880", Offset = "0x798D080", VA = "0x18798E880")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action BNJDBDKMMDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x798DE40", Offset = "0x798C640", VA = "0x18798DE40")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x798E920", Offset = "0x798D120", VA = "0x18798E920")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<ELGEGIFKKGD, CFPNNJDNDCC> GACPCODIKMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x798DEE0", Offset = "0x798C6E0", VA = "0x18798DEE0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x798E9C0", Offset = "0x798D1C0", VA = "0x18798E9C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x798AB40", Offset = "0x7989340", VA = "0x18798AB40")]
		public bool SetDeformation(bool EEAOOBHHOMF, bool JEGHNMNFCDE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x7988300", Offset = "0x7986B00", VA = "0x187988300")]
		protected static Material MCLCFFHDNIE(Dictionary<FJIABMDFBND, Material> EPLFLDCEKNL, Material HKHBPBHJKNG, CNIPHPLMKHC DEODPNNAHDB, BHHEHLDEJFH IHEENGIGNMA, PNLIIGCPIIK MDILONMHHMF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x7985D40", Offset = "0x7984540", VA = "0x187985D40")]
		protected void FMIKGOFOHPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x7985060", Offset = "0x7983860", VA = "0x187985060")]
		protected bool EEHHFPPPPLO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x7981140", Offset = "0x797F940", VA = "0x187981140")]
		protected void ACOEPJEOEOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x79836D0", Offset = "0x7981ED0", VA = "0x1879836D0", Slot = "10")]
		protected virtual void BLCKDIEJCMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x7988870", Offset = "0x7987070", VA = "0x187988870")]
		public int MeshesAtLODCount(int LKOFHCENDMA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x7982300", Offset = "0x7980B00", VA = "0x187982300")]
		protected static void AIGCANJJDHC(Dictionary<IKELHKNDDPA, List<FJIABMDFBND>> BGBFHIDBILE, MJFHMLPJNNP DHBOFLCIJIE, Material HKHBPBHJKNG, CNIPHPLMKHC IFFOBJIAHML, BHHEHLDEJFH GNABHHKCLPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x79833A0", Offset = "0x7981BA0", VA = "0x1879833A0")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x7983730", Offset = "0x7981F30", VA = "0x187983730")]
		protected void BODFOJHJEHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x7989700", Offset = "0x7987F00", VA = "0x187989700")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "11")]
		protected virtual void LBBIFLPFFJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x7984B60", Offset = "0x7983360", VA = "0x187984B60")]
		protected static void DMFDFJHKMEC(List<Material> DGCKKJLFJNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x7984000", Offset = "0x7982800", VA = "0x187984000")]
		protected static void CNNGBOAFAMM(Dictionary<FJIABMDFBND, Material> EPLFLDCEKNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x7986330", Offset = "0x7984B30", VA = "0x187986330")]
		protected static void HANNGEJFCDN(Dictionary<Renderer, ALLCBLIOLGB> GEFDGNPDLCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x7984910", Offset = "0x7983110", VA = "0x187984910")]
		protected void DBOJFBLLJCG(SkinnedMeshRenderer[] OIMBCHPJGIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x7987430", Offset = "0x7985C30", VA = "0x187987430")]
		protected void JMCPAMMLGPM(SkinnedMeshRenderer CCHCFBGLLFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x7987360", Offset = "0x7985B60", VA = "0x187987360")]
		protected void JMCPAMMLGPM(MeshRenderer MGFHHNMELPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x7988930", Offset = "0x7987130", VA = "0x187988930")]
		protected void NAKPPBGELPM(List<IAIDKAIACPE> AIDIFDOIBFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x7985BC0", Offset = "0x79843C0", VA = "0x187985BC0")]
		protected void FLBICCMAILL(Dictionary<string, GOANNPAHNKI<Texture2D>> BGBFHIDBILE, bool PGLIEOINGLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x79860A0", Offset = "0x79848A0", VA = "0x1879860A0")]
		protected void GALOLEMGGNK(Dictionary<IKELHKNDDPA, List<FJIABMDFBND>> BGBFHIDBILE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x7986230", Offset = "0x7984A30", VA = "0x187986230")]
		public float GetHandOpenClosedAxis(ELGEGIFKKGD MOFOOFPBFBC)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x798B3E0", Offset = "0x7989BE0", VA = "0x18798B3E0")]
		public void SetHandOpenClosedAxis(ELGEGIFKKGD MOFOOFPBFBC, float OKDGPDBMPMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x7986270", Offset = "0x7984A70", VA = "0x187986270")]
		public CFPNNJDNDCC GetHandVisualState(ELGEGIFKKGD MOFOOFPBFBC)
		{
			return default(CFPNNJDNDCC);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x7982AE0", Offset = "0x79812E0", VA = "0x187982AE0")]
		public bool AddHandVisualStateToken(ELGEGIFKKGD MOFOOFPBFBC, CFPNNJDNDCC EJJHBLLALOC, object JILOCOLKOMJ, BCPOPBGAHMA.EIHHAEJHGGI IEAGNNNDKKH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x798CBE0", Offset = "0x798B3E0", VA = "0x18798CBE0")]
		public void SetWatchHand(ELGEGIFKKGD MOFOOFPBFBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x798CCA0", Offset = "0x798B4A0", VA = "0x18798CCA0")]
		public void SetWatchHands(bool JKPKMOLPLGF, bool NMACCMMAKMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x798A200", Offset = "0x7988A00", VA = "0x18798A200")]
		public bool RemoveHandVisualStateToken(ELGEGIFKKGD MOFOOFPBFBC, object JILOCOLKOMJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x79862F0", Offset = "0x7984AF0", VA = "0x1879862F0")]
		public bool GetThumbsUpActive(ELGEGIFKKGD MOFOOFPBFBC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x798C680", Offset = "0x798AE80", VA = "0x18798C680")]
		public void SetThumbsUpActive(ELGEGIFKKGD MOFOOFPBFBC, bool PEJFMHHCCDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x79862B0", Offset = "0x7984AB0", VA = "0x1879862B0")]
		public bool GetHandshakeActive(ELGEGIFKKGD MOFOOFPBFBC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x798B430", Offset = "0x7989C30", VA = "0x18798B430")]
		public void SetHandshakeActive(ELGEGIFKKGD MOFOOFPBFBC, bool CNDBLLCGEPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x7986050", Offset = "0x7984850", VA = "0x187986050")]
		public void ForceUpdateHandsVisualState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x79847F0", Offset = "0x7982FF0", VA = "0x1879847F0")]
		public static void ClearQueuedBuilds()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x79852B0", Offset = "0x7983AB0", VA = "0x1879852B0")]
		private static void EEKLEDPMEMN(Scene MGAACDLILLD, LoadSceneMode MGNGIPCHJJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x7986C20", Offset = "0x7985420", VA = "0x187986C20")]
		protected static void IFMEPOIPFJN(PlayerAvatarDisplayBase PGFGMNHCFEO, List<HKMKLBKJBDJ> AIEBILLKIPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x7989F20", Offset = "0x7988720", VA = "0x187989F20")]
		public ELBPMMKABPA Rebuild(bool IFECDLBJDKE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x79868B0", Offset = "0x79850B0", VA = "0x1879868B0")]
		protected ELBPMMKABPA HIBBNKFOPOA(bool IFECDLBJDKE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x7986770", Offset = "0x7984F70", VA = "0x187986770", Slot = "12")]
		protected virtual ELBPMMKABPA HIBBNKFOPOA(IList<IKELHKNDDPA> LAOOOHPKNAM, AvatarItemBodyType INMIPKKNFMA, bool MNFBONIMPPG, int[] BIACAOKDIKH, bool IFECDLBJDKE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x79853E0", Offset = "0x7983BE0", VA = "0x1879853E0")]
		protected static ELBPMMKABPA EGAJCJDGDLF(HKMKLBKJBDJ GLIDPFAKCAJ, List<HKMKLBKJBDJ> AIEBILLKIPG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x7989CB0", Offset = "0x79884B0", VA = "0x187989CB0")]
		[IteratorStateMachine(typeof(AFEJBHLFNFG))]
		protected static IEnumerator<IGCELENFGND> PNHLJHPEFGC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x7989BF0", Offset = "0x79883F0", VA = "0x187989BF0")]
		protected static HKMKLBKJBDJ PMOGMFOBEHA(List<HKMKLBKJBDJ> AIEBILLKIPG)
		{
			return default(HKMKLBKJBDJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x798AC50", Offset = "0x7989450", VA = "0x18798AC50")]
		[AsyncStateMachine(typeof(MPDMBPOJNIO))]
		public Task SetFaceCustomizationSettings(AHOGOONMGAK BAEHAEFCNBH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x79870F0", Offset = "0x79858F0", VA = "0x1879870F0")]
		public void InitializeFaceFeatures(AvatarConfiguration HGGOEBFPIIL, DODMAGIBHBA CLLFKOMCOND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x798C3D0", Offset = "0x798ABD0", VA = "0x18798C3D0")]
		public void SetTeamColors(Color? OMJPBCDLOEA, bool MCCCEHLEAIL, Color IPNPIJNPBIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x1265960", Offset = "0x1264160", VA = "0x181265960")]
		private static void EFBPJAEPHBI(Material OALKCGACMLD, Color OPMIAMEJKDH, params int[] OAEELDNCDKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x12671E0", Offset = "0x12659E0", VA = "0x1812671E0")]
		private static void PPAGEAEAMKO(Material OALKCGACMLD, Texture OPMIAMEJKDH, params int[] OAEELDNCDKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x79885F0", Offset = "0x7986DF0", VA = "0x1879885F0")]
		protected void MOLEAAOEBIA(Material JACFHOAGGKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x7986900", Offset = "0x7985100", VA = "0x187986900")]
		protected void HJHNOINNHPH(Material JACFHOAGGKK, Color FLCOAHLNKBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x79877F0", Offset = "0x7985FF0", VA = "0x1879877F0")]
		protected void KMKCEDPNIDL(Material JACFHOAGGKK, Color FLCOAHLNKBD, Color JOLEPPOOGNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x7989D10", Offset = "0x7988510", VA = "0x187989D10")]
		protected void POMGPABNAFJ(Material JACFHOAGGKK, Texture2D OAGLIKEGCPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x79835C0", Offset = "0x7981DC0", VA = "0x1879835C0")]
		protected void BGHCLABEONM(Material JACFHOAGGKK, Texture DDFLPPIKLIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x7987690", Offset = "0x7985E90", VA = "0x187987690")]
		protected void KKEDOFLNMBA(Action<ALLCBLIOLGB> FMLBEBMIKMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x7987A10", Offset = "0x7986210", VA = "0x187987A10")]
		protected void KMMCCFFDGEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x79865B0", Offset = "0x7984DB0", VA = "0x1879865B0")]
		protected void HHEJDOLGFBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x7987E90", Offset = "0x7986690", VA = "0x187987E90")]
		protected void MBPBGCJDJEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x7982E30", Offset = "0x7981630", VA = "0x187982E30")]
		public void ApplyUgcItemOverrides()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x798A5C0", Offset = "0x7988DC0", VA = "0x18798A5C0")]
		public void SetBeardPrimaryColor([Optional] Color? GGCKLGJCBCL, bool KPBACFGPJBG = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x798A7E0", Offset = "0x7988FE0", VA = "0x18798A7E0")]
		public void SetBeardSecondaryColor([Optional] Color? GGCKLGJCBCL, bool KPBACFGPJBG = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x798A480", Offset = "0x7988C80", VA = "0x18798A480")]
		public void SetBeardPattern([Optional] AvatarHairPattern LEOMMPEBBPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x7986D30", Offset = "0x7985530", VA = "0x187986D30")]
		private void IJDOKKFJJBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x79884B0", Offset = "0x7986CB0", VA = "0x1879884B0")]
		private bool MJBLHBELPLI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x798AFC0", Offset = "0x79897C0", VA = "0x18798AFC0")]
		public void SetHairPrimaryColor([Optional] Color? JOMPIHICHIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x798B1D0", Offset = "0x79899D0", VA = "0x18798B1D0")]
		public void SetHairSecondaryColor([Optional] Color? JOMPIHICHIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x798AE90", Offset = "0x7989690", VA = "0x18798AE90")]
		public void SetHairPattern([Optional] AvatarHairPattern LEOMMPEBBPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x798A0A0", Offset = "0x79888A0", VA = "0x18798A0A0")]
		public void RefreshHair()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x7985F90", Offset = "0x7984790", VA = "0x187985F90")]
		private bool FOLMIKJKAGJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x798C210", Offset = "0x798AA10", VA = "0x18798C210")]
		public void SetSkinColor(Color GKIKDNIBDLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x798C6D0", Offset = "0x798AED0", VA = "0x18798C6D0")]
		public void SetUgcItemVisualOverrides(IKELHKNDDPA GKIGDKILOIE, DODMAGIBHBA CLLFKOMCOND, Texture DDHDKNNDJOP, Color NMIGAPCDJHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x79848C0", Offset = "0x79830C0", VA = "0x1879848C0")]
		public void ClearUgcItemVisualOverrides()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x798AD50", Offset = "0x7989550", VA = "0x18798AD50")]
		public bool SetFaceShape(AvatarFaceShape JFHNLKMCHKA, bool JMGDCCNPBCI = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x7983520", Offset = "0x7981D20", VA = "0x187983520")]
		private void BDJBNBKPIDF(JIFBLNLKJIG OFFLKMPHDPK, float OPMIAMEJKDH, bool FJKHIBKGEGN = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x7986A20", Offset = "0x7985220", VA = "0x187986A20")]
		private void HLHPIEMIHCF(MEDMAJJIMDC FMIMBGEGCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x7985EF0", Offset = "0x79846F0", VA = "0x187985EF0")]
		private void FNGEGPGBEJL(CNOECLPIEKB JJOCGLIBDAN, float OPMIAMEJKDH, bool CJPNFEMOAFF = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x7984A30", Offset = "0x7983230", VA = "0x187984A30")]
		private void DJIIGNKFHOE(FEBPCDMMGMN KKCCMLIGNFL, float OPMIAMEJKDH, bool OCPMNHGHALD = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x79881F0", Offset = "0x79869F0", VA = "0x1879881F0")]
		private void MCCAANDLCIG(FGDENIBGIDI BKDEHAHFKKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x7986130", Offset = "0x7984930", VA = "0x187986130")]
		private void GFLMEEDPIDK(EGDDHJOJKMC JHOLLOAECPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x798AA00", Offset = "0x7989200", VA = "0x18798AA00")]
		public bool SetBodyShape(AvatarBodyShape NAPFJCHLPMM, bool JMGDCCNPBCI = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x798C0A0", Offset = "0x798A8A0", VA = "0x18798C0A0")]
		public bool SetNoseType(DPOJOKMIJDG BCGOGBNIGIL, bool JMGDCCNPBCI = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x798CE00", Offset = "0x798B600", VA = "0x18798CE00")]
		public bool UpdateFaceAndBodyShapes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x798C080", Offset = "0x798A880", VA = "0x18798C080")]
		public bool SetHideEars(bool MOKFGEMKELL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x798C070", Offset = "0x798A870", VA = "0x18798C070")]
		public bool SetHelmetHair(LHGCMFLMCGH ONDBEGLDLKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x798BAD0", Offset = "0x798A2D0", VA = "0x18798BAD0")]
		public void SetHatAnchorParameters(PNINFJFLLCD ECGHPMBMCAC, bool LINKCMGJNFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x798CD70", Offset = "0x798B570", VA = "0x18798CD70")]
		public void SetupDisplayLODs(GNMOMKEJAIC FPHGDOHDALG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x7988F60", Offset = "0x7987760", VA = "0x187988F60")]
		protected int[] NKCNFFABKDK(GNMOMKEJAIC FPHGDOHDALG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x798C180", Offset = "0x798A980", VA = "0x18798C180")]
		public void SetOutfitSelections(IList<IKELHKNDDPA> LAOOOHPKNAM, AvatarItemBodyType INMIPKKNFMA, bool IFECDLBJDKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x798C140", Offset = "0x798A940", VA = "0x18798C140")]
		public void SetOutfitSelections(IList<IKELHKNDDPA> LAOOOHPKNAM, AvatarItemBodyType INMIPKKNFMA, bool MNFBONIMPPG, bool IFECDLBJDKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x798C1C0", Offset = "0x798A9C0", VA = "0x18798C1C0")]
		public ELBPMMKABPA SetOutfitSelections(IList<IKELHKNDDPA> LAOOOHPKNAM, AvatarItemBodyType INMIPKKNFMA, GNMOMKEJAIC FPHGDOHDALG, bool MNFBONIMPPG, bool JMGDCCNPBCI = false, bool IFECDLBJDKE = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x7984CA0", Offset = "0x79834A0", VA = "0x187984CA0", Slot = "13")]
		protected virtual ELBPMMKABPA DOBILMCLKBD(IList<IKELHKNDDPA> LAOOOHPKNAM, AvatarItemBodyType INMIPKKNFMA, bool MNFBONIMPPG, GNMOMKEJAIC FPHGDOHDALG, bool JMGDCCNPBCI, bool IFECDLBJDKE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x79811D0", Offset = "0x797F9D0", VA = "0x1879811D0")]
		protected int[] AFBEFAJOEEP(GNMOMKEJAIC FPHGDOHDALG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x9DECC0", Offset = "0x9DD4C0", VA = "0x1809DECC0", Slot = "14")]
		protected virtual LLDEFGHLBOH LJGOKDKFMOA(AvatarItemBodyType HECCPBIHNCK, Dictionary<string, KNAIBICOJFM> EJGLFJGKDFE, Dictionary<string, GOANNPAHNKI<Texture2D>> NONLPGLNNOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x7983C60", Offset = "0x7982460", VA = "0x187983C60", Slot = "15")]
		protected virtual ELBPMMKABPA CDBJHLCHGOM(IList<IKELHKNDDPA> LAOOOHPKNAM, AvatarItemBodyType INMIPKKNFMA, bool MNFBONIMPPG, int[] NFJGPMPHDCD, GKEGCDPOLMK JLCADIGHIND)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x7982660", Offset = "0x7980E60", VA = "0x187982660", Slot = "16")]
		protected virtual KNAIBICOJFM ANPCKBLCKKF(PNHCLNCDOAA BIOAJNKDOMN, AvatarItemBodyType HECCPBIHNCK, PNLIIGCPIIK MDILONMHHMF, KNAIBICOJFM MHGIMNPJCKM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x9DECC0", Offset = "0x9DD4C0", VA = "0x1809DECC0", Slot = "17")]
		protected virtual KNAIBICOJFM PNOIDEFOHKB(AvatarItemBodyType HECCPBIHNCK, PNLIIGCPIIK MDILONMHHMF, DKOHFMOEGNF MHBIGPFAJHC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x79825E0", Offset = "0x7980DE0", VA = "0x1879825E0")]
		protected void ANCEGNMCOMK(MCGPNNFIPKM NOBHLMENPGL, HHPKDLEJEOP.OOIFDIEICOH JIMLHBCHMAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x7989500", Offset = "0x7987D00", VA = "0x187989500")]
		protected void OIJLCPKKNGB(MCGPNNFIPKM NOBHLMENPGL, HHPKDLEJEOP.OOIFDIEICOH JIMLHBCHMAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0xA63AC0", Offset = "0xA622C0", VA = "0x180A63AC0", Slot = "18")]
		protected virtual MCGPNNFIPKM NFGIJNHNOCF(MCGPNNFIPKM NOBHLMENPGL, HelmetHairStyle BKOJGPKHAAC, bool OCJIJFPGJBC, AvatarItemBodyType INMIPKKNFMA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x7981320", Offset = "0x797FB20", VA = "0x187981320")]
		protected MCGPNNFIPKM AGPMABOFPPM(IList<IKELHKNDDPA> LAOOOHPKNAM, AvatarItemBodyType CBFLCODPFBD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x79846D0", Offset = "0x7982ED0", VA = "0x1879846D0")]
		public void CleanupDisplayResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x7985A00", Offset = "0x7984200", VA = "0x187985A00")]
		protected void EHEABLELHIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x79891D0", Offset = "0x79879D0", VA = "0x1879891D0")]
		protected void OHMLLDCPHPD(Transform NOHIAKELKJI, IEnumerable<SkinnedMeshRenderer> CJAHMBFBHOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x7989580", Offset = "0x7987D80", VA = "0x187989580")]
		protected HHPKDLEJEOP.OOIFDIEICOH OKGEJOPPKIO(HHPKDLEJEOP.OOIFDIEICOH NKHMCDBPGOH, PNLIIGCPIIK DMFMCGBHGNN)
		{
			return default(HHPKDLEJEOP.OOIFDIEICOH);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x79871B0", Offset = "0x79859B0", VA = "0x1879871B0")]
		protected void JBHDPKLMDEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x11ECC90", Offset = "0x11EB490", VA = "0x1811ECC90")]
		protected void JAIJJOBHIAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x7989A90", Offset = "0x7988290", VA = "0x187989A90")]
		protected void PAMKBFAOALL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x79875C0", Offset = "0x7985DC0", VA = "0x1879875C0")]
		[AsyncStateMachine(typeof(AJMIBHOOLED))]
		protected Task KIBPEADAGDN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x79871C0", Offset = "0x79859C0", VA = "0x1879871C0")]
		protected static CNIPHPLMKHC JMBIGBGACMF(MJFHMLPJNNP JJIPHMPADLA, int OKBBCMAODEN)
		{
			return default(CNIPHPLMKHC);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x7984F10", Offset = "0x7983710", VA = "0x187984F10")]
		protected static BHHEHLDEJFH EAAPDIAMCAE(MJFHMLPJNNP JJIPHMPADLA, int OKBBCMAODEN)
		{
			return default(BHHEHLDEJFH);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x79812D0", Offset = "0x797FAD0", VA = "0x1879812D0")]
		protected Transform AGONGINJCGN(PNLIIGCPIIK MDILONMHHMF, OutfitType IDPHALEDPIM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x7986EF0", Offset = "0x79856F0", VA = "0x187986EF0")]
		protected void IONHJJMIBKF(int JNNOAPGEOAD, Material OALKCGACMLD, MJFHMLPJNNP JJIPHMPADLA, [Out] Texture2D MIMNOJIBEOO, [Out] Vector4 NLIHHMJECOI, [Out] Texture2D EFOLEOBBCCL, [Out] Texture2D ADBCLAFKJJH, [Out] Texture2D IGCFGPLGGGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x7987D40", Offset = "0x7986540", VA = "0x187987D40")]
		protected void LPPIGMNHKDJ(int JNNOAPGEOAD, Material OALKCGACMLD, MJFHMLPJNNP JJIPHMPADLA, [Out] Color FPFEOKGHPHB, [Out] Color PDFDAEFEJLA, [Out] Color CMKKLECIAMK, [Out] Color BFOBPBHBHKF, [Out] Color GOEMDOOCABH, [Out] Color LDHHMAHGKGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x7989690", Offset = "0x7987E90", VA = "0x187989690")]
		protected void OMPNEJBDDBD(Vector3 COFBFGOOFOF, Quaternion PHMBAJJGPAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x798B480", Offset = "0x7989C80", VA = "0x18798B480")]
		public void SetHatAnchorParameters(PNINFJFLLCD ECGHPMBMCAC, AnchorParamsRestrictions LIFPEPALDMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x79841F0", Offset = "0x79829F0", VA = "0x1879841F0")]
		public static void CalculateHatAnchorParams(FitMeshHemisphere ECDEMKPAJBF, Transform MGDCKCKADNM, PNINFJFLLCD ECGHPMBMCAC, AnchorParamsRestrictions DPFCGKICJNA, [Out] Vector3 IKAECBBFJHO, [Out] Quaternion KOBOFDGKPML, [Out] PNINFJFLLCD NEAHDHMBIFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x798A310", Offset = "0x7988B10", VA = "0x18798A310")]
		public void ResetHatAnchor(Vector2 BIHJDBDHFDF, Vector3 DENCFLNAPGJ, Vector3 EGGHFEMCBAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0xA79A60", Offset = "0xA78260", VA = "0x180A79A60")]
		public FFGGGJLBFJP GetAnchorParamsRestrictions()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x7982C60", Offset = "0x7981460", VA = "0x187982C60")]
		public void ApplyBlocks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x7982DA0", Offset = "0x79815A0", VA = "0x187982DA0")]
		public void ApplyHairPattern()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x7982BD0", Offset = "0x79813D0", VA = "0x187982BD0")]
		public void ApplyBeardPattern()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x798CDA0", Offset = "0x798B5A0", VA = "0x18798CDA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x7989110", Offset = "0x7987910", VA = "0x187989110")]
		protected void NLAJAIABIBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x798CB60", Offset = "0x798B360", VA = "0x18798CB60")]
		public void SetWaitForUgcTextureLoads(bool HINCJFFOLIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x798CA70", Offset = "0x798B270", VA = "0x18798CA70")]
		public void SetUgcTextureParameters(NLDCDOOJMDE KIAKHLGFPAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x798D660", Offset = "0x798BE60", VA = "0x18798D660")]
		public PlayerAvatarDisplayBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x7983A60", Offset = "0x7982260", VA = "0x187983A60")]
		[CompilerGenerated]
		private void BPLGMIBOKAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x7985280", Offset = "0x7983A80", VA = "0x187985280")]
		[CompilerGenerated]
		private void EEIAFFGGDBP(ALLCBLIOLGB NBOBEHBFADD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x7983F70", Offset = "0x7982770", VA = "0x187983F70")]
		[CompilerGenerated]
		private void CHKAIJKJJGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x7987C50", Offset = "0x7986450", VA = "0x187987C50")]
		[CompilerGenerated]
		private void LBEKKJBPMPB(ALLCBLIOLGB NBOBEHBFADD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x7984AD0", Offset = "0x79832D0", VA = "0x187984AD0")]
		[CompilerGenerated]
		private void DLKMKCEEKCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x7985AD0", Offset = "0x79842D0", VA = "0x187985AD0")]
		[CompilerGenerated]
		private void FIENONJDKCN(ALLCBLIOLGB NBOBEHBFADD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x7985E60", Offset = "0x7984660", VA = "0x187985E60")]
		[CompilerGenerated]
		private void FNBPNMPFLDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x7989BA0", Offset = "0x79883A0", VA = "0x187989BA0")]
		[CompilerGenerated]
		private void PBOMMLADGHH(ALLCBLIOLGB NBOBEHBFADD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x7984160", Offset = "0x7982960", VA = "0x187984160")]
		[CompilerGenerated]
		private void COIAGFLJLGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x7989640", Offset = "0x7987E40", VA = "0x187989640")]
		[CompilerGenerated]
		private void OKHPBLAELOC(ALLCBLIOLGB NBOBEHBFADD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x7983BD0", Offset = "0x79823D0", VA = "0x187983BD0")]
		[CompilerGenerated]
		private void CBHCAAIDPKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x7985AB0", Offset = "0x79842B0", VA = "0x187985AB0")]
		[CompilerGenerated]
		private void FAPJKBKJCPD(ALLCBLIOLGB NBOBEHBFADD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x7983AF0", Offset = "0x79822F0", VA = "0x187983AF0")]
		[CompilerGenerated]
		internal static bool BPNMMOFEJAF(Transform FFAABEHKFDO, IEnumerable<SkinnedMeshRenderer> GMCIILAJMPJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x7983F30", Offset = "0x7982730", VA = "0x187983F30")]
		[CompilerGenerated]
		private void CFDKKAEADBM(ALLCBLIOLGB NBOBEHBFADD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x79860F0", Offset = "0x79848F0", VA = "0x1879860F0")]
		[CompilerGenerated]
		private void GCMFGNHDMLM(ALLCBLIOLGB NBOBEHBFADD)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[ExecuteAlways]
	public class PlayerFacialAnimatorBase : MonoBehaviour, BBHLBLBMBEP
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		[CompilerGenerated]
		private struct CHDCPKPGGFF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000462")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000463")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000464")]
			public AHOGOONMGAK avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000465")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000466")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0x7994850", Offset = "0x7993050", VA = "0x187994850", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039E")]
			[Cpp2IlInjected.Address(RVA = "0x7994AE0", Offset = "0x79932E0", VA = "0x187994AE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		[CompilerGenerated]
		private struct IOEHBEADJHE : IAsyncStateMachine
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
			public DODMAGIBHBA avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400046F")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0x7996720", Offset = "0x7994F20", VA = "0x187996720", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A0")]
			[Cpp2IlInjected.Address(RVA = "0x7996900", Offset = "0x7995100", VA = "0x187996900", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		[CompilerGenerated]
		private struct KPJFHFILPBG : IAsyncStateMachine
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
			public DODMAGIBHBA avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000476")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A1")]
			[Cpp2IlInjected.Address(RVA = "0x79973C0", Offset = "0x7995BC0", VA = "0x1879973C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0x7997560", Offset = "0x7995D60", VA = "0x187997560", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private struct OEBNFCCDOAP : IAsyncStateMachine
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
			public AHOGOONMGAK avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400047B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0x7998040", Offset = "0x7996840", VA = "0x187998040", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x79981F0", Offset = "0x79969F0", VA = "0x1879981F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private struct HHLBINAEPJN : IAsyncStateMachine
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
			public DODMAGIBHBA avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000480")]
			private TaskAwaiter<HDJOIAGFMIA> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x7995680", Offset = "0x7993E80", VA = "0x187995680", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x7995AC0", Offset = "0x79942C0", VA = "0x187995AC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		[CompilerGenerated]
		private struct CBBKDPPPADE : IAsyncStateMachine
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
			public DODMAGIBHBA avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000486")]
			private FaceStyleSet <styleSet>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000487")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x7994320", Offset = "0x7992B20", VA = "0x187994320", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x79947F0", Offset = "0x7992FF0", VA = "0x1879947F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		protected const float NIOCIDDDGPI = 0.5f;

		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		protected const int JBLNPFKNLGJ = 5;

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
		protected static readonly Dictionary<GEKMFAEANGI.GKJOEAALMGF, int> PMAFBNGDAFK;

		[Cpp2IlInjected.Token(Token = "0x4000408")]
		[CanBeNull]
		protected static IEnumerable<FaceFeatureType> PDBLJILGJKG;

		[Cpp2IlInjected.Token(Token = "0x4000409")]
		protected static readonly int MAEPFMKHLFO;

		[Cpp2IlInjected.Token(Token = "0x400040A")]
		protected static readonly int LELDDJOACJK;

		[Cpp2IlInjected.Token(Token = "0x400040B")]
		protected static readonly int GHFLBNNDJHN;

		[Cpp2IlInjected.Token(Token = "0x400040C")]
		protected static readonly int NBBHMLMHBEH;

		[Cpp2IlInjected.Token(Token = "0x400040D")]
		protected static readonly int LLGGFNKPCBF;

		[Cpp2IlInjected.Token(Token = "0x400040E")]
		protected static readonly int DPCIKHMFDHH;

		[Cpp2IlInjected.Token(Token = "0x400040F")]
		protected static readonly int DLBDAMBLPED;

		[Cpp2IlInjected.Token(Token = "0x4000410")]
		protected static readonly int JFIBEGJOHNK;

		[Cpp2IlInjected.Token(Token = "0x4000411")]
		protected static Vector2 NKPMGPPFBAP;

		[Cpp2IlInjected.Token(Token = "0x4000412")]
		protected static Vector2 NJIPDEAHGIK;

		[Cpp2IlInjected.Token(Token = "0x4000413")]
		protected static Vector2 OGDBOLOPIHO;

		[Cpp2IlInjected.Token(Token = "0x4000414")]
		protected static Vector2 KMHJHPOCGLH;

		[Cpp2IlInjected.Token(Token = "0x4000415")]
		protected static Vector2 ADLPECBEPMF;

		[Cpp2IlInjected.Token(Token = "0x4000416")]
		protected static Vector2 EELHFEKDFIC;

		[Cpp2IlInjected.Token(Token = "0x4000417")]
		protected static Vector2 NIFANJPHEOI;

		[Cpp2IlInjected.Token(Token = "0x4000418")]
		protected static Vector2 EHDKCJLANGJ;

		[Cpp2IlInjected.Token(Token = "0x4000419")]
		protected static Vector2 KODKODNKGKK;

		[Cpp2IlInjected.Token(Token = "0x400041A")]
		protected static Vector2 AKILCPBCGOA;

		[Cpp2IlInjected.Token(Token = "0x400041B")]
		protected static Vector2 MGOKJBGCHJC;

		[Cpp2IlInjected.Token(Token = "0x400041C")]
		protected static Vector2 NLMFLNEPPDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		[DAFFCFHPHBO(HNCMILCNFNF.Self, false, false, false)]
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
		private DODMAGIBHBA HDKDOEDLCJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		private FaceStyleSet LFBLCFCIPOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		[SerializeField]
		protected bool debugEyeJitterInEditor;

		[Cpp2IlInjected.Token(Token = "0x4000426")]
		protected const int LLLMCPNBBJB = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		protected int GFDPKBOLECH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		protected int GGPIPFHONFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		protected int PEKMCJCFEGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		protected int NIJNJIHINEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		protected Vector2 ABDACGJHPCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		protected float EHKCJCDNAJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		protected float NHAHNPPBFOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		protected float FIHMKDKCHOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		protected Vector2 LBKCKAFKEFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		protected float CNCEFGBKDOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		protected float PCDPDFBPABI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		protected float JEKHFKPALKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		protected Vector2 LMKHEALMLEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		protected float BLDHJAHJFEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		protected float KAHDMCBFGJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		protected float NGKHDMHMEBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		protected Vector2 HHEMKJIOJCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		protected float LIJGAPNPOCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		protected float LKOEJKIFHDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		protected float LKONDCEHMFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		protected List<SelectableFaceOption> KKKNAEOOMMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		protected List<SelectableFaceOption> GBDGBKMJEAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		protected List<SelectableFaceOption> ANMMGNNFOFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		protected List<SelectableFaceOption> ODPMAPFIKMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		protected Coroutine PMKJKIKOLPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		protected int? PAGMIPOCEEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		protected int PMHBECMIPCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		protected int HEEKHGMDPBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		protected int JDPCCKGIKLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		protected int OFFDHGGLANH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		protected int MBBBIDKHIBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		protected int KCKLDGBAMDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		protected Sprite PDIMPFMOJNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		protected Sprite HDCHPLEKCBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		protected Sprite IEEFMOKNIHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		protected Sprite HFOHIFKFICB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		protected bool GOACPCNLDBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		protected string NAKPGNNLKMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		protected string ICPODFBMDKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		protected string PKBPBFGJHJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		protected string KFMDAFBCKLD;

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
		protected AvatarConfiguration HGGOEBFPIIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		protected HDJOIAGFMIA NPPFKHJOFFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		private readonly List<Material> PMICOCGBIKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		protected LJMHOCKELDN GLJDBKNGEJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		protected Dictionary<string, int> BCJLHBKPJFC;

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public FaceStyleSet JOAHPCBFAGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x799E7A0", Offset = "0x799CFA0", VA = "0x18799E7A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public bool GJDHMDIAJII
		{
			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0xAB2730", Offset = "0xAB0F30", VA = "0x180AB2730", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x12006B0", Offset = "0x11FEEB0", VA = "0x1812006B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		protected virtual bool JNAKENOEMKH
		{
			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		protected virtual bool MCPPMIDPBND
		{
			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x9F9540", Offset = "0x9F7D40", VA = "0x1809F9540", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		protected int FMOJGHCCLBM
		{
			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x7999460", Offset = "0x7997C60", VA = "0x187999460")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public Renderer LBPFIFEHCNN
		{
			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x9DF790", Offset = "0x9DDF90", VA = "0x1809DF790")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public bool BNFFNPPEJFM
		{
			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0xAA65B0", Offset = "0xAA4DB0", VA = "0x180AA65B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x799EA50", Offset = "0x799D250", VA = "0x18799EA50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public Renderer[] OAHAHMOFIBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x9E0DB0", Offset = "0x9DF5B0", VA = "0x1809E0DB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public bool LPEIMPLJAIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x799E7F0", Offset = "0x799CFF0", VA = "0x18799E7F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x799E9B0", Offset = "0x799D1B0", VA = "0x18799E9B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		protected int DEDPOJOOJAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x799A9F0", Offset = "0x79991F0", VA = "0x18799A9F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		protected int GPGDMJCIMGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x799B280", Offset = "0x7999A80", VA = "0x18799B280")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		public float INLBNNFPPNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x799E7D0", Offset = "0x799CFD0", VA = "0x18799E7D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x799E990", Offset = "0x799D190", VA = "0x18799E990")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public EGMADKKHCJK FOFIGEDFPLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0xA90E30", Offset = "0xA8F630", VA = "0x180A90E30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0xABD600", Offset = "0xABBE00", VA = "0x180ABD600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public HDJOIAGFMIA MAEAABBPJLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000385")]
			[Cpp2IlInjected.Address(RVA = "0xA9DEF0", Offset = "0xA9C6F0", VA = "0x180A9DEF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000386")]
			[Cpp2IlInjected.Address(RVA = "0x799E910", Offset = "0x799D110", VA = "0x18799E910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public NoseFaceOption FCNMFGBFCCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000387")]
			[Cpp2IlInjected.Address(RVA = "0xA88020", Offset = "0xA86820", VA = "0x180A88020")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000388")]
			[Cpp2IlInjected.Address(RVA = "0xB1D340", Offset = "0xB1BB40", VA = "0x180B1D340")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		protected LJMHOCKELDN FMGHNPEEJCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000389")]
			[Cpp2IlInjected.Address(RVA = "0x79993E0", Offset = "0x7997BE0", VA = "0x1879993E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action APLKILNGFOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0x799E6F0", Offset = "0x799CEF0", VA = "0x18799E6F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x799E860", Offset = "0x799D060", VA = "0x18799E860")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x799AA50", Offset = "0x7999250", VA = "0x18799AA50")]
		public void LocalPlayEmote(GEKMFAEANGI.GKJOEAALMGF PABCGCPKGGJ, float FPHKFKOBLBF = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x799A6D0", Offset = "0x7998ED0", VA = "0x18799A6D0")]
		public bool IsEmotePlaying(GEKMFAEANGI.GKJOEAALMGF PABCGCPKGGJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x799C6F0", Offset = "0x799AEF0", VA = "0x18799C6F0")]
		public void SetIdleHappy(bool BGPLEDDHHNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x79991E0", Offset = "0x79979E0", VA = "0x1879991E0")]
		protected void CAOGACPAKPB(bool OGCKKPPIJOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x79997F0", Offset = "0x7997FF0", VA = "0x1879997F0")]
		protected void DHEHADGOFMJ(bool IMNDFNHCMNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x799A7E0", Offset = "0x7998FE0", VA = "0x18799A7E0")]
		protected void JCPKMNKKCMD(PNLIIGCPIIK MDILONMHHMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x7999CE0", Offset = "0x79984E0", VA = "0x187999CE0")]
		protected void GBGJICMNLDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x799BF00", Offset = "0x799A700", VA = "0x18799BF00")]
		public void PlayExpression(int OAKGGAAFJJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x799A850", Offset = "0x7999050", VA = "0x18799A850")]
		protected void KGJAJDALOBE(bool MBILOMIAJGD, bool MPCEPMCJIPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x7999F20", Offset = "0x7998720", VA = "0x187999F20")]
		public List<SelectableFaceOption> GetAvailableFeatures(FaceFeatureType KIMBBBOIMAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x799A1C0", Offset = "0x79989C0", VA = "0x18799A1C0")]
		public void InitializeFaceFeatureRanges(AvatarConfiguration HGGOEBFPIIL, DODMAGIBHBA CLLFKOMCOND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x799C4D0", Offset = "0x799ACD0", VA = "0x18799C4D0")]
		[AsyncStateMachine(typeof(CHDCPKPGGFF))]
		public Task SetFaceSettings(AHOGOONMGAK BAEHAEFCNBH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x799C5C0", Offset = "0x799ADC0", VA = "0x18799C5C0")]
		[AsyncStateMachine(typeof(IOEHBEADJHE))]
		public Task SetFaceSettings(int KKOJKOEEMJJ, int CJGFOLKNFKO, int LOLAKMKPMEC, int IFEGINFLNPE, DODMAGIBHBA CLLFKOMCOND)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x799C770", Offset = "0x799AF70", VA = "0x18799C770")]
		[AsyncStateMachine(typeof(KPJFHFILPBG))]
		public Task SetSelectedFaceFeatureAndBuildFaceStyle(FaceFeatureType KIMBBBOIMAP, int NLBBHNLBHBI, DODMAGIBHBA CLLFKOMCOND)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x7998A40", Offset = "0x7997240", VA = "0x187998A40")]
		protected void ANFIBHIDHPI(FaceFeatureType KIMBBBOIMAP, MFGHHKBHMBD DEDDEMFLPGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x799AB40", Offset = "0x7999340", VA = "0x18799AB40")]
		protected void MANPAIBBELJ(FaceFeatureType KIMBBBOIMAP, int NLBBHNLBHBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x7999D50", Offset = "0x7998550", VA = "0x187999D50")]
		public static IEnumerable<FaceFeatureType> GetAllFaceFeatureTypes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x799A900", Offset = "0x7999100", VA = "0x18799A900")]
		[AsyncStateMachine(typeof(OEBNFCCDOAP))]
		protected Task LAMLAPEICAJ(AHOGOONMGAK BAEHAEFCNBH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x7998DE0", Offset = "0x79975E0", VA = "0x187998DE0")]
		protected void BKAOBIKNFOJ(AHOGOONMGAK BAEHAEFCNBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x7999F60", Offset = "0x7998760", VA = "0x187999F60")]
		protected static void HFNGEBEMEKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x7999590", Offset = "0x7997D90", VA = "0x187999590")]
		private void COEKGADAMAB(bool KGBBDAAMPCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x7999950", Offset = "0x7998150", VA = "0x187999950")]
		protected void EBLILEJDHCK(FaceFeatureType KIMBBBOIMAP, Vector2 AIKKKIPJCNA, DODMAGIBHBA CLLFKOMCOND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x799BF20", Offset = "0x799A720", VA = "0x18799BF20")]
		public void SetFaceFeatureNormalizedPositionOffset(FaceFeatureType KIMBBBOIMAP, Vector2 KKBIFLDEPNO, DODMAGIBHBA CLLFKOMCOND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x7999260", Offset = "0x7997A60", VA = "0x187999260")]
		protected void CCGKCEOJNPP(FaceFeatureType KIMBBBOIMAP, float DMPEMPFKELM, DODMAGIBHBA CLLFKOMCOND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x79988C0", Offset = "0x79970C0", VA = "0x1879988C0")]
		protected void AJFHFOCGKOI(FaceFeatureType KIMBBBOIMAP, float PMHMEKBKJJA, DODMAGIBHBA CLLFKOMCOND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x799A0F0", Offset = "0x79988F0", VA = "0x18799A0F0")]
		protected void INMDDLEOHAD(FaceFeatureType KIMBBBOIMAP, float GOKBHMBGOCI, DODMAGIBHBA CLLFKOMCOND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x799C2B0", Offset = "0x799AAB0", VA = "0x18799C2B0")]
		public void SetFaceFeatureNormalizedScaleOffset(FaceFeatureType KIMBBBOIMAP, float ALFNELEBCCM, DODMAGIBHBA CLLFKOMCOND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x7998D00", Offset = "0x7997500", VA = "0x187998D00")]
		[AsyncStateMachine(typeof(HHLBINAEPJN))]
		protected Task BDPNJBIBJFD(DODMAGIBHBA CLLFKOMCOND)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x799A4C0", Offset = "0x7998CC0", VA = "0x18799A4C0")]
		public void InitializeFaceFeatureStyleSet(DODMAGIBHBA CLLFKOMCOND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x799B2E0", Offset = "0x7999AE0", VA = "0x18799B2E0")]
		protected bool OBNNNJNGKNG(string MKPFPNFLDOG, [Out] int FPEOONOJHML)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x7998BC0", Offset = "0x79973C0", VA = "0x187998BC0")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x15F7710", Offset = "0x15F5F10", VA = "0x1815F7710", Slot = "8")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x799BCF0", Offset = "0x799A4F0", VA = "0x18799BCF0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x799D890", Offset = "0x799C090", VA = "0x18799D890")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x79990E0", Offset = "0x79978E0", VA = "0x1879990E0")]
		[AsyncStateMachine(typeof(CBBKDPPPADE))]
		public Task BuildFaceStyleAsyncIfChanged(DODMAGIBHBA CLLFKOMCOND, bool JMGDCCNPBCI = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x799D1B0", Offset = "0x799B9B0", VA = "0x18799D1B0")]
		public void UpdateFaceDisplays(bool NIFGCLANBFE = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x799B3C0", Offset = "0x7999BC0", VA = "0x18799B3C0")]
		protected bool OJGBFIMECIC(bool NIFGCLANBFE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x799CED0", Offset = "0x799B6D0", VA = "0x18799CED0")]
		public void UpdateFaceDisplayFeatureTextures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x799C880", Offset = "0x799B080", VA = "0x18799C880")]
		public void UpdateFaceDisplayFeaturePositions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x799D3C0", Offset = "0x799BBC0", VA = "0x18799D3C0")]
		public void UpdateFaceJitterMultiplier()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x799D5B0", Offset = "0x799BDB0", VA = "0x18799D5B0")]
		public bool UpdateLegacyFaceVectors()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x799BC00", Offset = "0x799A400", VA = "0x18799BC00")]
		protected void OKBILPKFGGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x7998610", Offset = "0x7996E10", VA = "0x187998610")]
		private void AEKGOCAPFJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x799E4A0", Offset = "0x799CCA0", VA = "0x18799E4A0")]
		public PlayerFacialAnimatorBase()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0xA0A8D0", Offset = "0xA090D0", VA = "0x180A0A8D0", Slot = "4")]
		private bool CCGJAFGIMCA()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct AAIIBAPJBED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public string ACOJEEABMOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public int NGHJMEDCGPM;
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
		private struct BKEJEPFCEOG : IAsyncStateMachine
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
			[Cpp2IlInjected.Address(RVA = "0x7994120", Offset = "0x7992920", VA = "0x187994120", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0xA2F200", Offset = "0xA2DA00", VA = "0x180A2F200", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000077")]
		[CompilerGenerated]
		private struct DHGIPOEAOEG : IAsyncStateMachine
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
			[Cpp2IlInjected.Address(RVA = "0x7994D00", Offset = "0x7993500", VA = "0x187994D00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0x7995200", Offset = "0x7993A00", VA = "0x187995200", Slot = "5")]
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
		public DODMAGIBHBA avatarBodyType;

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
		public LHGCMFLMCGH useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public PNINFJFLLCD hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public FFGGGJLBFJP HatAnchorRestrictions;

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
		[DAFFCFHPHBO(HNCMILCNFNF.Self, false, false, false)]
		public PlayerAvatarDisplayBase _avatarDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		private IMDLIGJOCDI HADLHOBPLBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		[SerializeField]
		[DAFFCFHPHBO(HNCMILCNFNF.Self, false, false, false)]
		public PlayerFacialAnimatorBase facialAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public AnimationClip animationClipToOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		private AnimatorOverrideController OCJDENLBGHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		private List<KeyValuePair<AnimationClip, AnimationClip>> DIPAKKEINGP;

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
		public readonly AAIIBAPJBED[] FacialExpressions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public readonly string[] BodyPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public readonly (string, CFPNNJDNDCC)[] HandPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public bool hideLeftWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x229")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public bool hideRightWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22A")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		protected bool EKFBLLOBFOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22C")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		protected Guid LCNJOIOLILG;

		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		protected static Guid MNMOOOIPDNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		private MKBPDMPFCMC JNOHPJBKJPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		private EGMADKKHCJK AMMOCJCAKGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		private NDBEIHDKPNF ILPFFCHGJNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		private NDBEIHDKPNF EPMGJAGAANH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		private AdditionalHatData GDJAMAGKLPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		private readonly Dictionary<GameObject, PNHCLNCDOAA> FCDCCBLBMBL;

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public static Func<DKOHFMOEGNF> GBOCLOPCFPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x79A39C0", Offset = "0x79A21C0", VA = "0x1879A39C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x79A4000", Offset = "0x79A2800", VA = "0x1879A4000")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public bool FOLMIKJKAGJ
		{
			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x79A3B20", Offset = "0x79A2320", VA = "0x1879A3B20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		public bool MJBLHBELPLI
		{
			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x79A3A10", Offset = "0x79A2210", VA = "0x1879A3A10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public PlayerAvatarDisplayBase LEOBIMPFAMO
		{
			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0xA898F0", Offset = "0xA880F0", VA = "0x180A898F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		protected static Guid HPFOBKDNCDI
		{
			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x799FD90", Offset = "0x799E590", VA = "0x18799FD90")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public (GameObject, PNLIIGCPIIK)[] JBNJIKNMNOE
		{
			[Cpp2IlInjected.Token(Token = "0x60003C6")]
			[Cpp2IlInjected.Address(RVA = "0x79A3C30", Offset = "0x79A2430", VA = "0x1879A3C30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x79A1740", Offset = "0x799FF40", VA = "0x1879A1740")]
		[ContextMenu("Refresh Avatar")]
		private void RebuildTestAvatarContextMenu()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x79A1170", Offset = "0x799F970", VA = "0x1879A1170")]
		private IEnumerable<GameObject> OEOENNJPHBK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x79A1C30", Offset = "0x79A0430", VA = "0x1879A1C30")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x799F9B0", Offset = "0x799E1B0", VA = "0x18799F9B0")]
		private void DBKMKEBFGGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x1249A30", Offset = "0x1248230", VA = "0x181249A30")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x799FE80", Offset = "0x799E680", VA = "0x18799FE80")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x79A1C40", Offset = "0x79A0440", VA = "0x1879A1C40")]
		public void Teardown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x79A1A30", Offset = "0x79A0230", VA = "0x1879A1A30")]
		public void ShowPose(AnimationClip NAIBNNNHEIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x79A1C00", Offset = "0x79A0400", VA = "0x1879A1C00")]
		public void ShowPose(string BDGAAPFAKHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x79A1890", Offset = "0x79A0090", VA = "0x1879A1890")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x79A1750", Offset = "0x799FF50", VA = "0x1879A1750")]
		public void ResetHandPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x79A2710", Offset = "0x79A0F10", VA = "0x1879A2710")]
		public void UpdateHandAnimation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x79A2560", Offset = "0x79A0D60", VA = "0x1879A2560")]
		public void UpdateFaceAndBodyShapes(bool JMGDCCNPBCI = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x79A2B10", Offset = "0x79A1310", VA = "0x1879A2B10")]
		public void UpdateNoseShape(DPOJOKMIJDG BCGOGBNIGIL, bool JMGDCCNPBCI = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x79A2AE0", Offset = "0x79A12E0", VA = "0x1879A2AE0")]
		public void UpdateLODOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x799FA90", Offset = "0x799E290", VA = "0x18799FA90", Slot = "4")]
		protected virtual void GIHOABFPAOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x799EB10", Offset = "0x799D310", VA = "0x18799EB10", Slot = "5")]
		protected virtual void APIAPAKNOJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x799EF40", Offset = "0x799D740", VA = "0x18799EF40")]
		public void ApplyHatData(AdditionalHatData AABOLPFKFCB, bool FGLFAKJBJJI = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x799ED80", Offset = "0x799D580", VA = "0x18799ED80")]
		public void ApplyHatAdjustmentsToHatAnchorParams()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x799F2A0", Offset = "0x799DAA0", VA = "0x18799F2A0")]
		public void ApplyHatUVOverride(Vector2 DEKIIBGHCPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x799F1C0", Offset = "0x799D9C0", VA = "0x18799F1C0")]
		public void ApplyHatPositionAdjustment(Vector3 CHIJBNJFGOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x799F230", Offset = "0x799DA30", VA = "0x18799F230")]
		public void ApplyHatRotationAdjustment(Vector3 LDLEMFGNGDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x799F310", Offset = "0x799DB10", VA = "0x18799F310")]
		public IKELHKNDDPA BuildAvatarItemSelection(GameObject NBNEIOPBBLE, DODMAGIBHBA HECCPBIHNCK, PNLIIGCPIIK AHBBECMMPOG)
		{
			return default(IKELHKNDDPA);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x799F3B0", Offset = "0x799DBB0", VA = "0x18799F3B0")]
		public void BuildAvatar(bool JMGDCCNPBCI = false, bool FGLFAKJBJJI = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x79A1FA0", Offset = "0x79A07A0", VA = "0x1879A1FA0")]
		public void UpdateColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x799EEC0", Offset = "0x799D6C0", VA = "0x18799EEC0")]
		public void ApplyHatAnchor()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x79A2930", Offset = "0x79A1130", VA = "0x1879A2930")]
		public void UpdateHatAnchor(bool FGLFAKJBJJI = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x79A2660", Offset = "0x79A0E60", VA = "0x1879A2660")]
		[AsyncStateMachine(typeof(BKEJEPFCEOG))]
		public void UpdateFaceFeatures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x79A1670", Offset = "0x799FE70", VA = "0x1879A1670")]
		[AsyncStateMachine(typeof(DHGIPOEAOEG))]
		private Task PNBIFNDNEPP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x79A0EB0", Offset = "0x799F6B0", VA = "0x1879A0EB0")]
		private void ODKJBCLCKHM(FaceFeatureType GJOMIGIHMND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x79A15E0", Offset = "0x799FDE0", VA = "0x1879A15E0")]
		private void PHFPIHKGEAC(FaceFeatureType GJOMIGIHMND, [Out] float GMDKKGOMKIG, [Out] float FLLPLNOJNPJ, [Out] float EGLHBCAIJLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x79A2420", Offset = "0x79A0C20", VA = "0x1879A2420")]
		public void UpdateEmote()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x79A27C0", Offset = "0x79A0FC0", VA = "0x1879A27C0")]
		public void UpdateHandPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x79A0630", Offset = "0x799EE30", VA = "0x1879A0630")]
		private void LDJILDFBPIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
		private void HKAMOBNDJIP(PNHCLNCDOAA BIOAJNKDOMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
		private void IBEGCFEFBNJ(PNHCLNCDOAA BIOAJNKDOMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x79A0B50", Offset = "0x799F350", VA = "0x1879A0B50")]
		private void LJGNPGGPPMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x79A2B90", Offset = "0x79A1390", VA = "0x1879A2B90")]
		public PlayerModernBodyEditorAvatarValidator()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x79A0580", Offset = "0x799ED80", VA = "0x1879A0580")]
		[CompilerGenerated]
		private IKELHKNDDPA KLADGGOELND((GameObject, PNLIIGCPIIK) EOPEOKDCKLG)
		{
			return default(IKELHKNDDPA);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class SkinnedMeshBonesInspector : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		[SerializeField]
		[DAFFCFHPHBO(HNCMILCNFNF.Self, false, false, false)]
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
		[Cpp2IlInjected.Address(RVA = "0x9DECA0", Offset = "0x9DD4A0", VA = "0x1809DECA0")]
		public SkinnedMeshBonesInspector()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct IKELHKNDDPA
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class GCKNJINDEEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public IEnumerable<OutfitType> otherOutfitTypes;

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public GCKNJINDEEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x7995600", Offset = "0x7993E00", VA = "0x187995600")]
		internal bool KDJBCDGEMDG(OutfitType outfitType)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	private PNHCLNCDOAA PPNGNDJLEPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	private PNLIIGCPIIK GLHFLBECMPK;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public PNHCLNCDOAA NJOHAKIGIOP
	{
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public PNLIIGCPIIK NLNKGOHMIHB
	{
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE70", Offset = "0xCEC670", VA = "0x180CEDE70")]
		get
		{
			return default(PNLIIGCPIIK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public string DCDLIDOFHJH
	{
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x7996330", Offset = "0x7994B30", VA = "0x187996330")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public bool FINCKLKJCFD
	{
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x7996420", Offset = "0x7994C20", VA = "0x187996420")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public bool IJFIJAIJFNH
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x7996220", Offset = "0x7994A20", VA = "0x187996220")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x1774470", Offset = "0x1772C70", VA = "0x181774470")]
	public IKELHKNDDPA(PNHCLNCDOAA BIOAJNKDOMN, PNLIIGCPIIK MDILONMHHMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x7996270", Offset = "0x7994A70", VA = "0x187996270")]
	public bool IGDJLKHNLNP(OutfitType DHJFLLGOMAE, PNLIIGCPIIK IBGGLNOEPKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x7995FC0", Offset = "0x79947C0", VA = "0x187995FC0")]
	public bool FBFAOKNBKJF(OutfitType DHJFLLGOMAE, PNLIIGCPIIK IBGGLNOEPKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x7995DD0", Offset = "0x79945D0", VA = "0x187995DD0")]
	public bool AJANMDMAKIK(IKELHKNDDPA NGIDEKMOEOM)
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
