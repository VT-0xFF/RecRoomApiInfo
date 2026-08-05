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
	public class LogRegistrationIndex : HJMIPPBHOKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7DD4CD0", Offset = "0x7DD34D0", VA = "0x187DD4CD0", Slot = "4")]
		public override void KELFLPPCOLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA2D5F0", Offset = "0xA2BDF0", VA = "0x180A2D5F0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override string AssetGUID
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x7DE3FC0", Offset = "0x7DE27C0", VA = "0x187DE3FC0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7DE3F50", Offset = "0x7DE2750", VA = "0x187DE3F50", Slot = "17")]
		public override bool RuntimeKeyIsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7DE3F80", Offset = "0x7DE2780", VA = "0x187DE3F80")]
		public RecNetCDNAssetReference(RecNetCDNKey MNMCNOJCKAF)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class RecNetCDNKey
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public enum IIJCNDMACPP : byte
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
			[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string UniqueItemIdentifier
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string CacheHash
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xA2A970", Offset = "0xA29170", VA = "0x180A2A970")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RecNetCDNKey Dependency
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xA2D3B0", Offset = "0xA2BBB0", VA = "0x180A2D3B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xA2EE70", Offset = "0xA2D670", VA = "0x180A2EE70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool AttemptPrecacheLookup
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xA56260", Offset = "0xA54A60", VA = "0x180A56260")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA56080", Offset = "0xA54880", VA = "0x180A56080")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public IIJCNDMACPP PathHint
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xE32F80", Offset = "0xE31780", VA = "0x180E32F80")]
			[CompilerGenerated]
			get
			{
				return default(IIJCNDMACPP);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x13EED50", Offset = "0x13ED550", VA = "0x1813EED50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string ItemPath
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x7DE40D0", Offset = "0x7DE28D0", VA = "0x187DE40D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7DE4050", Offset = "0x7DE2850", VA = "0x187DE4050")]
		public static RecNetCDNKey EKDIHJJDIJD(string EHKCOEDBAAH, IIJCNDMACPP LDCHKCKCOCD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7DE4000", Offset = "0x7DE2800", VA = "0x187DE4000")]
		public void DFJIENCCKJJ(string CEGOFOBPJOM, string CEGOJJNEECN, bool CHMGOJGGMIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public RecNetCDNKey()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DIADIMJDNBG]
public class DCKNHLLJCKO : CIMAOIGMEBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	protected readonly List<Mesh> FJMJFAHIPMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	protected readonly List<byte[]> AENFOMNHEEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	protected readonly List<Matrix4x4> IHFPHIMAFLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	protected readonly List<bool> IJEJOMACKHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	protected readonly List<long> MDJCJMIBEEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	protected readonly List<bool> KEAMDHPAFAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	protected readonly List<int> MEEODHKDHDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	protected Allocator KIBHOGPOOCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected MIKMGDAKPOO IFBFLJNBOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected byte OLMEBMEHHKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected IList<int> OGGOCHEHEOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected IList<int> ELDLFGEBDIF;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7DCFC70", Offset = "0x7DCE470", VA = "0x187DCFC70", Slot = "4")]
	public void EPDPODEMOHI(Mesh MLCGFPJFGFN, Matrix4x4 IFLBNIMLIKF, byte[] FFJDDCBJKKI, bool GGIOLMBGPCE = false, AFHHIDGAGFC.KICMKFFCOMP HBEHEOCGCFL = (AFHHIDGAGFC.KICMKFFCOMP)0L, int NJILOLKKMNL = -1, bool AFHOKGPBJBM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7DCFEF0", Offset = "0x7DCE6F0", VA = "0x187DCFEF0", Slot = "5")]
	public void PBPKKKDMPCH(Allocator GFNKGIEEHMD, MIKMGDAKPOO DKKFHFNCCLG, byte JGFKHBHDMJL, [Optional] IList<int> PNFAPCOKEOB, [Optional] IList<int> BFKGBAAKIAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7DCFA10", Offset = "0x7DCE210", VA = "0x187DCFA10")]
	private static void BGCFONAMJJA(Mesh MLCGFPJFGFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7DCFF30", Offset = "0x7DCE730", VA = "0x187DCFF30")]
	public DCKNHLLJCKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[DIADIMJDNBG]
public struct LPEPOEBEHGF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	[ReadOnly]
	public PLLGANNBEAC OIJBFACMGHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[ReadOnly]
	public int CGALNJNLDAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public IBMNCCNGJKD HLPABCACJAN;

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7DD3210", Offset = "0x7DD1A10", VA = "0x187DD3210", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[DIADIMJDNBG]
[NativeContainer]
public struct IBMNCCNGJKD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct LHJHPPOAIJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Vector3 NMKLHJIEKLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public Vector3 IILAMILCBNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public Vector4 GENEBLLECDJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct EAKNLJIDFBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public float MKLDDKIHKIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public float COLFBHMKFHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public float PDEJPLDMJBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public float CNMLPBABJAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public byte DMHKAMJAMLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public byte IOCFCEKKMIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public byte LDCHCEMABMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public byte AOLJFCFOLMD;
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct KKOPGNLHGJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public half MKLDDKIHKIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public half COLFBHMKFHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public half PDEJPLDMJBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public half CNMLPBABJAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public byte DMHKAMJAMLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public byte IOCFCEKKMIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public byte LDCHCEMABMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public byte AOLJFCFOLMD;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct JLMGNNEMMNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public half4 BIKIHAKPCIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public half2 DFNPOJLGEOH;
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct FEKKBHNLJKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public half4 BIKIHAKPCIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public half2 DFNPOJLGEOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public half2 IIJONMDEFFE;
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct DACNANDAPBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public half4 BIKIHAKPCIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public half2 DFNPOJLGEOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public half2 IIJONMDEFFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public half2 OPKCAOIANAM;
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct BFMKLDFDFMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public half4 BIKIHAKPCIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public half2 DFNPOJLGEOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public half2 IIJONMDEFFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public half2 OPKCAOIANAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public half2 OECLHOAHAIO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct AEJMKIAKOBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public float MKLDDKIHKIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public float COLFBHMKFHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public float PDEJPLDMJBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public float CNMLPBABJAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int DMHKAMJAMLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int IOCFCEKKMIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int LDCHCEMABMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int AOLJFCFOLMD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct CGAJEJNEFBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Color BIKIHAKPCIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Vector2 DFNPOJLGEOH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct BFMEDMKJKJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Color BIKIHAKPCIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Vector2 DFNPOJLGEOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Vector2 IIJONMDEFFE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct ODMJGLBOOKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Color BIKIHAKPCIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Vector2 DFNPOJLGEOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Vector2 IIJONMDEFFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Vector2 OPKCAOIANAM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct IPKLHGEOMDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Color BIKIHAKPCIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Vector2 DFNPOJLGEOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Vector2 IIJONMDEFFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Vector2 OPKCAOIANAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Vector2 OECLHOAHAIO;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private bool EJMPPEBOAEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<LHJHPPOAIJA> BOEMGOEKJMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<JLMGNNEMMNP> IMAHCJFBIKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<FEKKBHNLJKA> FANLJKMIGCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<DACNANDAPBE> KEJPBFOAJOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<BFMKLDFDFMG> BHIHEINMJOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<KKOPGNLHGJN> FCGNJMHPBAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<EAKNLJIDFBK> CFJBLFIEKCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NativeArray<CGAJEJNEFBF> EFAIKMDDIKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NativeArray<BFMEDMKJKJF> KFGCCJOCKPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public NativeArray<ODMJGLBOOKK> IMPPEONJCBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public NativeArray<IPKLHGEOMDG> GKBCFOPPNCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public NativeArray<AEJMKIAKOBK> ODFOJHNEEAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public NativeArray<int> BFBBKFOJBNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public NativeArray<int> KMKJAHOKANB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private NativeArray<int> BFBEOFJHDPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NativeArray<int> BMJKCCHEBOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<int> MJLJNADNNGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public NativeArray<int> NDGMHLIEPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public NativeArray<int> HHJKPMBJBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public NativeArray<BoneWeight> DADOCABOBDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeArray<int> JCPNJLMMOLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private bool AFBNPDMGFOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x159")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private bool NEFGIMNFAEJ;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int LCHAMOGKKEO
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7DD2590", Offset = "0x7DD0D90", VA = "0x187DD2590")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7DD1610", Offset = "0x7DCFE10", VA = "0x187DD1610")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int JJFPHPMPKJI
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7DD1250", Offset = "0x7DCFA50", VA = "0x187DD1250")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7DD02D0", Offset = "0x7DCEAD0", VA = "0x187DD02D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int MGKIJOBAFFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7DD1620", Offset = "0x7DCFE20", VA = "0x187DD1620")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7DD1630", Offset = "0x7DCFE30", VA = "0x187DD1630")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int EHCODGGMIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7DD1260", Offset = "0x7DCFA60", VA = "0x187DD1260")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7DD25A0", Offset = "0x7DD0DA0", VA = "0x187DD25A0")]
	public IBMNCCNGJKD(int JFJPHDJMCJC, int KADPIJFKHLP, int FNMACDCMJEN, int APNABPPLLGE, Allocator GFNKGIEEHMD, int GIFEJMIEOGD, BHOAPCPECNL GEFGJCGNHNF, bool AFBNPDMGFOJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7DD0240", Offset = "0x7DCEA40", VA = "0x187DD0240")]
	public void AAMGNKNCBEF(int PNJCJGEIDHG, Vector3 KENANDNBOGI, Vector3 IHGBDKLNHAA, Vector4 ODKLOJBBLOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7DD03B0", Offset = "0x7DCEBB0", VA = "0x187DD03B0")]
	public void DLICADLICMI(int PNJCJGEIDHG, BoneWeight MLEBNNLGKNK, NativeSlice<byte> FFJDDCBJKKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7DD12E0", Offset = "0x7DCFAE0", VA = "0x187DD12E0")]
	public Color LABPCADJLOI(int PNJCJGEIDHG)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7DD0A40", Offset = "0x7DCF240", VA = "0x187DD0A40")]
	public void EKLELLGJOAB(int PNJCJGEIDHG, Color GJJIDOPGHFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7DD0EA0", Offset = "0x7DCF6A0", VA = "0x187DD0EA0")]
	public void IHLEFFMCHED(byte FKGKGDHMPAI, int PNJCJGEIDHG, Vector2 DCPFNGLMDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7DD12D0", Offset = "0x7DCFAD0", VA = "0x187DD12D0")]
	public void KIMENEEMMIF(int PNJCJGEIDHG, int KGLLBNOCJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7DD0E40", Offset = "0x7DCF640", VA = "0x187DD0E40")]
	public bool FODOGJAIINM(int FKGKGDHMPAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7DD02E0", Offset = "0x7DCEAE0", VA = "0x187DD02E0")]
	public void DINOIHDKCKM(int KFODBDJKPLA, int BJCMHPBMOOK, int AEPPOMGGPKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7DD07E0", Offset = "0x7DCEFE0", VA = "0x187DD07E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7DD1640", Offset = "0x7DCFE40", VA = "0x187DD1640")]
	public Mesh PMILKEDBPEK([Optional] string FLMOIPFGGHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
[NativeContainer]
[DIADIMJDNBG]
public struct PLLGANNBEAC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public Mesh.MeshDataArray PCOOMGOABDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public NativeArray<int> PAKDFKAJPPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public NativeArray<int> PBFEKDDPBLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public NativeArray<BoneWeight> DADOCABOBDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private NativeArray<Matrix4x4> HIOBIDLHBHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private NativeArray<long> JGLFANHBIMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private NativeArray<byte> ONGNACPPMOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private NativeArray<int> BNACHEPEGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private NativeArray<int> DMFCDLCOILG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public NativeArray<sbyte> ANJJALDOLBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public NativeArray<byte> CJCKHJAOAFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public NativeArray<bool> AFHOKGPBJBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NativeArray<int> NJILOLKKMNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private bool AFBNPDMGFOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeArray<int> ICEBONNPFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private bool NEFGIMNFAEJ;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int KLLEPPDBBKG
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7DE2A30", Offset = "0x7DE1230", VA = "0x187DE2A30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int KOHLKBKOFLK
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7DE2A40", Offset = "0x7DE1240", VA = "0x187DE2A40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int APJJLAOFBLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7DE2960", Offset = "0x7DE1160", VA = "0x187DE2960")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int LIPPLPFLKKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7DE2770", Offset = "0x7DE0F70", VA = "0x187DE2770")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7DE2790", Offset = "0x7DE0F90", VA = "0x187DE2790")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int LCHAMOGKKEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7DE2D90", Offset = "0x7DE1590", VA = "0x187DE2D90")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7DE2B30", Offset = "0x7DE1330", VA = "0x187DE2B30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int APBEBHANDIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7DE2940", Offset = "0x7DE1140", VA = "0x187DE2940")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7DE2950", Offset = "0x7DE1150", VA = "0x187DE2950")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public MIKMGDAKPOO GDHAEGPEDIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7DE27B0", Offset = "0x7DE0FB0", VA = "0x187DE27B0")]
		get
		{
			return default(MIKMGDAKPOO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7DE2A50", Offset = "0x7DE1250", VA = "0x187DE2A50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public byte LCDHAHAFNPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7DE27A0", Offset = "0x7DE0FA0", VA = "0x187DE27A0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7DE2780", Offset = "0x7DE0F80", VA = "0x187DE2780")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public EMMLGHHBFPF NOJAFKJLFLI
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7DE2B40", Offset = "0x7DE1340", VA = "0x187DE2B40")]
		get
		{
			return default(EMMLGHHBFPF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7DE2DA0", Offset = "0x7DE15A0", VA = "0x187DE2DA0")]
	public PLLGANNBEAC(IList<Mesh> LOGBKDFDENO, IList<Matrix4x4> EBFLOLCFNCE, IList<bool> AFHOKGPBJBM, byte JGFKHBHDMJL, IList<byte[]> MJGDOBIIGAI, IList<long> FOBNDAABCJG, IList<bool> AGCFCINHFGI, IList<int> NJILOLKKMNL, IList<int> PNFAPCOKEOB, IList<int> FLHGCIIPJHJ, Allocator GFNKGIEEHMD, MIKMGDAKPOO DKKFHFNCCLG, bool AFBNPDMGFOJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7DE2A60", Offset = "0x7DE1260", VA = "0x187DE2A60")]
	public IBMNCCNGJKD MIMCLHIALEP(Allocator GFNKGIEEHMD, BHOAPCPECNL GEFGJCGNHNF)
	{
		return default(IBMNCCNGJKD);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7DE27C0", Offset = "0x7DE0FC0", VA = "0x187DE27C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DIADIMJDNBG]
public class CMFECDIGEME : DCKNHLLJCKO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public bool IOGOIFELHPH;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly ProfilerMarker IENPFBDLBAO;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7DCF700", Offset = "0x7DCDF00", VA = "0x187DCF700")]
	public PLLGANNBEAC EPDGAIEIOHL()
	{
		return default(PLLGANNBEAC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7DCFA00", Offset = "0x7DCE200", VA = "0x187DCFA00")]
	public CMFECDIGEME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct EMMLGHHBFPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public Mesh.MeshData DCHLEJEKMIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public NativeSlice<BoneWeight> DADOCABOBDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public NativeSlice<byte> PCLMGMFNIMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public int JIDGABGHBEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public Matrix4x4 CJPBIOCPGMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public long DBEGBAPKAGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public NativeSlice<byte> FFJDDCBJKKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public bool HLIPLCHOLBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public int ODOOEIPGFCC;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class OEIDMFLEFCG : MEKGIBHCPGB
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class MNMHMPFHHHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public MIBIOPCDBNF avatarBuildParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public OEIDMFLEFCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public JLFAJMGNMDK buildMeshPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public Action<KeyValuePair<string, OBKOLGEFKBC<Texture2D>>> <>9__19;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public MNMHMPFHHHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7DD4DB0", Offset = "0x7DD35B0", VA = "0x187DD4DB0")]
		internal bool EHJOAMNFMPA(OPEJGCCNPHE item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7DD4EF0", Offset = "0x7DD36F0", VA = "0x187DD4EF0")]
		internal void JFODJAJMJHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7DD4D60", Offset = "0x7DD3560", VA = "0x187DD4D60")]
		internal void CJGKDDDEFPM(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x7DD4EF0", Offset = "0x7DD36F0", VA = "0x187DD4EF0")]
		internal void HCBOFJPCOCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7DD4D60", Offset = "0x7DD3560", VA = "0x187DD4D60")]
		internal void DHMKOGAMECP(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7DD4E00", Offset = "0x7DD3600", VA = "0x187DD4E00")]
		internal void FLNOJGDEFLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7DD4D80", Offset = "0x7DD3580", VA = "0x187DD4D80")]
		internal void CPICHDAOHMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7DD4E30", Offset = "0x7DD3630", VA = "0x187DD4E30")]
		internal void FNIKMKFOGNM(Dictionary<string, OBKOLGEFKBC<Texture2D>> resourceHandleDictionary)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7DD4F10", Offset = "0x7DD3710", VA = "0x187DD4F10")]
		internal void MBPOFCEKPHH(KeyValuePair<string, OBKOLGEFKBC<Texture2D>> kvp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60")]
		internal FKGMEHDMFDF KJCFFDJHBDB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class EBHBBBIMLFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public int lowestPossibleLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public MNMHMPFHHHA CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public EBHBBBIMLFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x7DD0180", Offset = "0x7DCE980", VA = "0x187DD0180")]
		internal EEJNACPNKOG JOOJCOHINMJ(int lod)
		{
			return default(EEJNACPNKOG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class IKMOMGHMKDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public BFIFKPBFBML<Dictionary<string, OBKOLGEFKBC<Texture2D>>> ugcTextureDictionaryPromise;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public IKMOMGHMKDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		internal BFIFKPBFBML<Dictionary<string, OBKOLGEFKBC<Texture2D>>> MKPBFIBFDJG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class NCNMAJFPBFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public List<JLFAJMGNMDK> innerPromises;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public NCNMAJFPBFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x7DD5210", Offset = "0x7DD3A10", VA = "0x187DD5210")]
		internal void KFFEJNFLNGO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class BIKAFAEILJM : IEnumerator<ENGFNCJEKHI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private ENGFNCJEKHI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public bool shouldWait;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public OEIDMFLEFCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public List<JNAOBMPIJBG> parts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public List<JLFAJMGNMDK> innerPromises;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public bool isFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public Func<int, EEJNACPNKOG> getLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public JDGBFDAALDB materialPropertyBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public Material materialInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private int <lodIndex>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private ENGFNCJEKHI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0xA2B740", Offset = "0xA29F40", VA = "0x180A2B740")]
		[DebuggerHidden]
		public BIKAFAEILJM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7DCF430", Offset = "0x7DCDC30", VA = "0x187DCF430", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7DCF6B0", Offset = "0x7DCDEB0", VA = "0x187DCF6B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class ONJLPPJHFDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public FIHBAFMCLPL cancelable;

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public ONJLPPJHFDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0xB0E7E0", Offset = "0xB0CFE0", VA = "0x180B0E7E0")]
		internal void DEGHJGINNIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xD7F200", Offset = "0xD7DA00", VA = "0x180D7F200")]
		internal void APKEAIEEMHD(string err)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class HPPLPHBKCAM
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
		public OEIDMFLEFCG <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public HPPLPHBKCAM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class NAEFAMHMOHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public IBMNCCNGJKD defaultMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public PLLGANNBEAC defaultAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public HPPLPHBKCAM CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public NAEFAMHMOHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7DD4FD0", Offset = "0x7DD37D0", VA = "0x187DD4FD0")]
		internal void AKLDJPPHDNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x13502A0", Offset = "0x134EAA0", VA = "0x1813502A0")]
		internal void FFBKHLIPLIJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class LJCFJOEDMLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public MEIGAEBCJLK legacyMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public DPIJEMNNPFN legacyAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public HPPLPHBKCAM CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public LJCFJOEDMLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7DD2FD0", Offset = "0x7DD17D0", VA = "0x187DD2FD0")]
		internal void FAGOOIIBICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x1350670", Offset = "0x134EE70", VA = "0x181350670")]
		internal void HHMMKLPKLJL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class NJDOEHNHDAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public string overrideItemIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public AMKHIMALNFB overrideBodyPart;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public NJDOEHNHDAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7DD5340", Offset = "0x7DD3B40", VA = "0x187DD5340")]
		internal bool AJNPCPGHBEF(KeyValuePair<string, OPEJGCCNPHE> entry)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly KECNPIDOCPH AMAFNPLJCIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly KECNPIDOCPH JKHKOADMCOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Dictionary<HCPABEIHEAJ, float> GENIEOPIGIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private Dictionary<LHAJKAMPCKL, float> CBDFOHMAAIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Dictionary<DOGKIFENHJN, float> OEPBAPPABOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private IReadOnlyDictionary<string, GIJPFBPMKLD> JELAIHLHBMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Dictionary<string, GIJPFBPMKLD> PCPEOCOGBJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Dictionary<string, GIJPFBPMKLD> NLAEJOGJFPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private Dictionary<string, GIJPFBPMKLD> DIAPIFOAMFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private KKCINKBPNJO PPJDKODEFHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private KKCINKBPNJO KKNGIBAFDGD;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static float MJOKCIMJKKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private bool? HABDHLIEPAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x62")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private bool? AEAGAJPBPEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private bool? JOOGHACDEFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x66")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private bool? CPBAHMDJHNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private AvatarConfiguration COMJCIBINGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private Transform OBAMPMCFMFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private AvatarSkinAssetItem PPJNPFAJNMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private AssetReference DPCOCHDCBBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private GameObject ALFDDKJBMDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private GameObject MEENFHBICGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private SkinnedMeshRenderer BLCKELAHACE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private AvatarSkinnedMeshBoneOrderRemapsData BGMLDDPAADK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private Transform[] GDDALMAJKPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private Matrix4x4[] PFFOJMGMELC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private Material GHENNBBECGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private Material DJCGILNFODI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private Material CDAOOPFODJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private Material AIFGGMFHENC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private Shader ECIKMCMBFNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Shader OAGHGCGKMOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private Animator NEHAHKIIDKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private Renderer[] ILDIBDGOBOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private AFHHIDGAGFC.KICMKFFCOMP BJODBLIJNDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private AvatarBodyPartShapesManager DNIOJGBEJAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private IReadOnlyDictionary<string, Transform> KGCBKLHCAGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private AvatarFaceShapeData.JPCJMKBGGNA NGPAAHENGOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private AvatarBodyShapeData.NJMGEHOMLOJ GBPFGLNOFJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private HJAEKHPBLDG AJECGNKIJAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private bool EIOIMEIKGBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11D")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private bool IENOEIMIJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private Color DCFCJDNKCNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private Color LJEMKDJNIML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private Color OGFKHCHDCAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private Color? CDCOKKJMPDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x164")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private Color? LMBGEHGJHPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private Color? PEBMKGNAEAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private Color? NGLOKNIAKBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private Texture2D HGANNIMENKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private Texture2D IEJJHKJPOEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	[CanBeNull]
	private OPEJGCCNPHE AJKJFLGOJKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private Texture PCFKDMBILAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private Color NCEHNEBDABH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public Dictionary<Renderer, JDGBFDAALDB> LGHCLHELCPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private Dictionary<Renderer, JDGBFDAALDB> PKCLMABEDLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private Dictionary<string, List<ECBDBECHDME>> NHJNACIOHMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private Dictionary<string, List<ECBDBECHDME>> GEKFCDICHLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly List<CJHHFDGDDDE> GKPPNBCOCFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly List<CJHHFDGDDDE> KHJEHKMHHGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly List<CJHHFDGDDDE> BCGIFCKHIKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly List<CJHHFDGDDDE> PHNAGPHKOKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private Dictionary<ECBDBECHDME, Material> NCAMKFFCODN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private Dictionary<ECBDBECHDME, Material> GAMPENIAJJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private SkinnedMeshRenderer[] JCGDOJINENC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private SkinnedMeshRenderer[] HJGHKJCIFAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private SkinnedMeshRenderer[] CFHGPCLANJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private SkinnedMeshRenderer[] AGBMBFGGLJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly Dictionary<string, OBKOLGEFKBC<Texture2D>> CJPNGPIDHNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly Dictionary<string, OBKOLGEFKBC<Texture2D>> FHKDGOPGIHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private AdditionalHatData AEJMPLPOAKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private AdditionalHatData MOLMGJGIJLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private HairData BLIMHHJOBOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private HairData OLIHJHBIODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private CPOALKJLKJO AOEBANMOIGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private bool? BAJENODCIAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x27C")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private PositionAndRotation LDEGCHCCBKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private Transform DLKBGBALBFO;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private Material PAKEKNNIIIE;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private Material IMHHEHOEGPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private Dictionary<string, OPEJGCCNPHE> PHMFHDJIOAC;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static readonly int AEOBGPEKLNA;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static readonly int JPJDMGFLHBM;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly int GJOMKFEPEON;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly int BIOGGHALFKE;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly int EMPIMMNENAA;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly int GKKAPEBCPOG;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private static readonly int FPDNNIHDNMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool CPIAMMJBJKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private List<Action> LMPNIKLNLOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private FOIPDPBDMCD LGCGMHDCIJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private SkinnedMeshRenderer[] JMLDCJDDDDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private int HGFPOMDBECN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2DC")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private bool ABPNMHFHIAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private int GMFBOOPEKEH;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public KECNPIDOCPH JMKHBDENEGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public KECNPIDOCPH BGPGLJFHADA
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private OPHBELKNMNO NJNLAMHGMGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7DD54D0", Offset = "0x7DD3CD0", VA = "0x187DD54D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool HOIDDDEFHHL
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7DE13C0", Offset = "0x7DDFBC0", VA = "0x187DE13C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private bool FEDNEPCCLPE
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7DE08D0", Offset = "0x7DDF0D0", VA = "0x187DE08D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private bool OFHAJIBEMEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7DE1B90", Offset = "0x7DE0390", VA = "0x187DE1B90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private bool PJPEGBKBFEP
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7DD5B10", Offset = "0x7DD4310", VA = "0x187DD5B10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public AvatarConfiguration HICJKOOOICD
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA27510", Offset = "0xA25D10", VA = "0x180A27510", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool LJOJLPNGJLD
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7DDB2E0", Offset = "0x7DD9AE0", VA = "0x187DDB2E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7DDD060", Offset = "0x7DDB860", VA = "0x187DDD060")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private Material BGDABDFBPCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7DDD7F0", Offset = "0x7DDBFF0", VA = "0x187DDD7F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private Material NCIPCEABMPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7DE1160", Offset = "0x7DDF960", VA = "0x187DE1160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private bool DMMPCADAEMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA43700", Offset = "0xA41F00", VA = "0x180A43700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public CJONCCGGHCH DNFAHGOCPPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7DDC130", Offset = "0x7DDA930", VA = "0x187DDC130", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return default(CJONCCGGHCH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7DDFE20", Offset = "0x7DDE620", VA = "0x187DDFE20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public Material NMNBCMMMBGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xABDCA0", Offset = "0xABC4A0", VA = "0x180ABDCA0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public SkinnedMeshRenderer[] DJNINMODIFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x19FE830", Offset = "0x19FD030", VA = "0x1819FE830", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public Renderer[] CHNIFJCHIOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xB26550", Offset = "0xB24D50", VA = "0x180B26550", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool OGFLDFCEMGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7DDFCB0", Offset = "0x7DDE4B0", VA = "0x187DDFCB0", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public AFHHIDGAGFC.KICMKFFCOMP EGHIPGEPJFN
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xAB0A90", Offset = "0xAAF290", VA = "0x180AB0A90", Slot = "20")]
		get
		{
			return default(AFHHIDGAGFC.KICMKFFCOMP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int JAFNKCDIFOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x122D970", Offset = "0x122C170", VA = "0x18122D970")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7DDA7B0", Offset = "0x7DD8FB0", VA = "0x187DDA7B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private bool LBDBDBJLAOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7DDB2F0", Offset = "0x7DD9AF0", VA = "0x187DDB2F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private static bool JOIKFIAELOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7DD9DD0", Offset = "0x7DD85D0", VA = "0x187DD9DD0", Slot = "15")]
	public JLFAJMGNMDK DHCLOPIDHBD(MIBIOPCDBNF LFKEJLCGEEE, bool GOIIKIMOADK, int[] NBLMCPIIPBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7DD78B0", Offset = "0x7DD60B0", VA = "0x187DD78B0", Slot = "14")]
	public JLFAJMGNMDK BMPLOPDFCKB(MIBIOPCDBNF LFKEJLCGEEE, bool GOIIKIMOADK, int[] NBLMCPIIPBK, Func<Dictionary<string, OPEJGCCNPHE>, (JLFAJMGNMDK, BFIFKPBFBML<Dictionary<string, OBKOLGEFKBC<Texture2D>>>)> ABGEKACAPJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7DDDDF0", Offset = "0x7DDC5F0", VA = "0x187DDDDF0")]
	public JLFAJMGNMDK LHHIEMLKCDJ(MIBIOPCDBNF LFKEJLCGEEE, bool GOIIKIMOADK, int[] NBLMCPIIPBK, bool BDGOHOAONKL, KKCINKBPNJO OMKAHKNNHDH, [Optional] Func<Dictionary<string, OPEJGCCNPHE>, (JLFAJMGNMDK, BFIFKPBFBML<Dictionary<string, OBKOLGEFKBC<Texture2D>>>)> ABGEKACAPJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8DE0", Offset = "0x7DD75E0", VA = "0x187DD8DE0")]
	private bool CDDPHIBJDCG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7DDC560", Offset = "0x7DDAD60", VA = "0x187DDC560")]
	private JLFAJMGNMDK JHBHLGCJAFA(bool GOIIKIMOADK, List<JNAOBMPIJBG> NIGBHBDGPJE, int[] NBLMCPIIPBK, Func<int, EEJNACPNKOG> FACCKPAHHGN, bool BDGOHOAONKL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7DE0210", Offset = "0x7DDEA10", VA = "0x187DE0210")]
	[IteratorStateMachine(typeof(BIKAFAEILJM))]
	private IEnumerator<ENGFNCJEKHI> MMEMODFBNII(bool GOIIKIMOADK, List<JNAOBMPIJBG> NIGBHBDGPJE, int[] NBLMCPIIPBK, Func<int, EEJNACPNKOG> FACCKPAHHGN, JDGBFDAALDB KDGGNCPPECO, Material JFDDANCAOID, List<JLFAJMGNMDK> MILCBCJJDEI, bool PAHGNOCMEIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7DDAB50", Offset = "0x7DD9350", VA = "0x187DDAB50")]
	private void FPFFPEJAOAB(List<JNAOBMPIJBG> NIGBHBDGPJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7DDFA60", Offset = "0x7DDE260", VA = "0x187DDFA60")]
	private JLFAJMGNMDK LJJCHOABPNC(List<JNAOBMPIJBG> NIGBHBDGPJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7DD78E0", Offset = "0x7DD60E0", VA = "0x187DD78E0")]
	private NGLIALCAJHK BNOCNKLNDLD(List<JNAOBMPIJBG> NIGBHBDGPJE, int MBAOJAPNLMO, bool GOIIKIMOADK, EEJNACPNKOG GBIENHEIENE, bool LFIJFEIKCPC, JDGBFDAALDB KDGGNCPPECO, Material JFDDANCAOID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7DE12E0", Offset = "0x7DDFAE0", VA = "0x187DE12E0", Slot = "27")]
	public void PCPIEOMMHLJ(HCPABEIHEAJ MDHBPDAGPJP, float MGONBEDEDON, bool DLINACMNDMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7DD93E0", Offset = "0x7DD7BE0", VA = "0x187DD93E0", Slot = "29")]
	public void CGANCHDNFND(LHAJKAMPCKL HBCBKEFIGGL, float MGONBEDEDON, bool NHBCHDEKNEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7DD94D0", Offset = "0x7DD7CD0", VA = "0x187DD94D0", Slot = "30")]
	public void CODBBJGLFNP(DOGKIFENHJN IKAIJLAMGFH, float MGONBEDEDON, bool MNIPDPOOLBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7DE01B0", Offset = "0x7DDE9B0", VA = "0x187DE01B0", Slot = "28")]
	public void MKANGOEMAIE(bool EDPOPIPFHKE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7DDDAD0", Offset = "0x7DDC2D0", VA = "0x187DDDAD0", Slot = "31")]
	public void LEHPNFOBNFI(bool EDPOPIPFHKE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7DD53F0", Offset = "0x7DD3BF0", VA = "0x187DD53F0", Slot = "32")]
	public void ACIEIFGCIHL(bool EDPOPIPFHKE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7DE1850", Offset = "0x7DE0050", VA = "0x187DE1850")]
	private void PGOPKGPMPOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7DE1250", Offset = "0x7DDFA50", VA = "0x187DE1250")]
	private void ONJKOOCJPPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7DD5450", Offset = "0x7DD3C50", VA = "0x187DD5450")]
	private void ADGBPGBLJAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7DE18D0", Offset = "0x7DE00D0", VA = "0x187DE18D0", Slot = "25")]
	public void PJKBMENIPKH(AvatarFaceShape DJKIBLENKKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7DD5BF0", Offset = "0x7DD43F0", VA = "0x187DD5BF0", Slot = "26")]
	public void AJIBNBBOPKC(AvatarBodyShape BNAGLBHEBAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0xB3D6D0", Offset = "0xB3BED0", VA = "0x180B3D6D0", Slot = "33")]
	public void DCKHBCPMPMO(HJAEKHPBLDG DHBONOABFMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7DD99C0", Offset = "0x7DD81C0", VA = "0x187DD99C0", Slot = "35")]
	public void DBJFFAJFCKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7DDD6A0", Offset = "0x7DDBEA0", VA = "0x187DDD6A0", Slot = "39")]
	public void KHBOKNEBCPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7DDD9C0", Offset = "0x7DDC1C0", VA = "0x187DDD9C0", Slot = "34")]
	public void LABOPOFHOEK(bool FJOMIJFACGD, bool OHILAFABJDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7DD6E30", Offset = "0x7DD5630", VA = "0x187DD6E30")]
	private void BEGDNPFKNMK(SkinnedMeshRenderer EIPKNGIKLDF, int MBAOJAPNLMO, Mesh MLCGFPJFGFN, List<Material> FEOCNAPANNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7DDCCB0", Offset = "0x7DDB4B0", VA = "0x187DDCCB0")]
	private static Material JMBGMFPAOOG(Dictionary<ECBDBECHDME, Material> MBEFJGBJNEI, Material EHBFKOKKEME, FEGKPDMKNPP LPHCFMKOJHP, AKAPHFAPJFJ IGJBFJBCPIK, AMKHIMALNFB BHONCPBICBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7DDD9D0", Offset = "0x7DDC1D0", VA = "0x187DDD9D0")]
	private static FEGKPDMKNPP LCGPPHHAAJB(JNAOBMPIJBG AMIADACPHOE, int ALCDHADGBBH)
	{
		return default(FEGKPDMKNPP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7DDB370", Offset = "0x7DD9B70", VA = "0x187DDB370")]
	private void HEDFFOCFHAA(int OBCBHDBACIL, Material IPKNLMFNGIO, JNAOBMPIJBG AMIADACPHOE, [Out] Texture2D MKCBDFHGFNG, [Out] Vector4 GNIJIMNMHIK, [Out] Texture2D LKFDHGEJDAB, [Out] Texture2D LHEFACKLEFI, [Out] Texture2D BMJCNKGBLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8F20", Offset = "0x7DD7720", VA = "0x187DD8F20")]
	private void CDNFKKCEDKE(int OBCBHDBACIL, Material IPKNLMFNGIO, JNAOBMPIJBG AMIADACPHOE, [Out] Color GHACELNNKIA, [Out] Color JGCCIMLMHPP, [Out] Color INBBHDHGJBD, [Out] Color DKEMBKEAHOB, [Out] Color IJMCOMPCOHA, [Out] Color BNDLCFCECGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7DD73A0", Offset = "0x7DD5BA0", VA = "0x187DD73A0")]
	private bool BLPKJGGCEJK(Material IPKNLMFNGIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7DE03B0", Offset = "0x7DDEBB0", VA = "0x187DE03B0")]
	private static Material NDPIGDPFPDB(int OBCBHDBACIL, PJHHKEHLNOA AMIADACPHOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7DE1AB0", Offset = "0x7DE02B0", VA = "0x187DE1AB0")]
	private static AKAPHFAPJFJ PLMMMCDBHED(JNAOBMPIJBG AMIADACPHOE, int ALCDHADGBBH)
	{
		return default(AKAPHFAPJFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7DDB8C0", Offset = "0x7DDA0C0", VA = "0x187DDB8C0")]
	private static void HOGPMDKIPNE(Dictionary<string, List<ECBDBECHDME>> LILGCKMMEFL, JNAOBMPIJBG ABJPPKEBCFK, Material EHBFKOKKEME, FEGKPDMKNPP HGNBOIAPBOF, AKAPHFAPJFJ JNKNLKDBMCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7DE14A0", Offset = "0x7DDFCA0", VA = "0x187DE14A0")]
	private static SkinnedMeshRenderer PDPKMIKFEHB(Transform HCCOLCOCOAB, Transform DEPEFMHNNIO, SkinnedMeshRenderer[] CBBJPOGILOI, int MBAOJAPNLMO, EEJNACPNKOG GBIENHEIENE, bool GOIIKIMOADK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7DE1DC0", Offset = "0x7DE05C0", VA = "0x187DE1DC0")]
	public OEIDMFLEFCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7DDBD30", Offset = "0x7DDA530", VA = "0x187DDBD30")]
	public void IEAMPCKAMFG([In] HAOEIENGOCP FCGOPOMDMPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7DDBBA0", Offset = "0x7DDA3A0", VA = "0x187DDBBA0")]
	public void HPIMFHNOKNC([In] PBODBAOOJMB BOCMNLKCKGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7DDA7B0", Offset = "0x7DD8FB0", VA = "0x187DDA7B0", Slot = "5")]
	public void EPPGMGDNKEI(int MBAOJAPNLMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7DD5D90", Offset = "0x7DD4590", VA = "0x187DD5D90", Slot = "10")]
	public void APBCIMNKJJB(INNPPBNCKOC JNKNLKDBMCF, Texture2D AILALHOICPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xA43700", Offset = "0xA41F00", VA = "0x180A43700")]
	public static bool HGPLHBIEAAO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7DDCB40", Offset = "0x7DDB340", VA = "0x187DDCB40", Slot = "11")]
	public bool JKIFJEGHIJH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7DD95C0", Offset = "0x7DD7DC0", VA = "0x187DD95C0", Slot = "9")]
	public void COPEJGMAPIM(PEJFOJFEPIJ HGNBOIAPBOF, Color? BIKIHAKPCIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7DDBC20", Offset = "0x7DDA420", VA = "0x187DDBC20")]
	private void IBBPMMILHLA(Action GBELEIHPJCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8EB0", Offset = "0x7DD76B0", VA = "0x187DD8EB0", Slot = "6")]
	public void CDLEBEMFCEB(OPEJGCCNPHE IBKPFDCPMEG, Texture GBDJEAJIPHN, Color DAINAFFLJMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7DDD060", Offset = "0x7DDB860", VA = "0x187DDD060", Slot = "7")]
	public void LKJJLJLBALN(bool PAHGNOCMEIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1D2DB60", Offset = "0x1D2C360", VA = "0x181D2DB60", Slot = "8")]
	public void OAOGHKEANHJ(FOIPDPBDMCD JCPNJLMMOLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7DE05B0", Offset = "0x7DDEDB0", VA = "0x187DE05B0", Slot = "16")]
	public void NIKNJLKBDOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7DDB780", Offset = "0x7DD9F80", VA = "0x187DDB780", Slot = "36")]
	public void HNHKGIMDEPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7DD5FB0", Offset = "0x7DD47B0", VA = "0x187DD5FB0", Slot = "37")]
	public void APNKJFFIHFA([Optional] CPOALKJLKJO BEELNCKOPGF, [Optional] bool? GECEDKEPDPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7DDC420", Offset = "0x7DDAC20", VA = "0x187DDC420")]
	private bool JEBDMCGIJBN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7DDBB80", Offset = "0x7DDA380", VA = "0x187DDBB80", Slot = "21")]
	public bool HPGMGMMCGLF(AFHHIDGAGFC.KICMKFFCOMP OBIBDPIHBOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7DDA7D0", Offset = "0x7DD8FD0", VA = "0x187DDA7D0", Slot = "38")]
	public void FKJCPBKFNCO(float OOMFPJMFDLP, Color BIKIHAKPCIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7DDB7E0", Offset = "0x7DD9FE0", VA = "0x187DDB7E0")]
	private static bool HOBGBIAFJOD(Material JFDDANCAOID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7DD89E0", Offset = "0x7DD71E0", VA = "0x187DD89E0")]
	private void BOGBOMLFAEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7DD5D80", Offset = "0x7DD4580", VA = "0x187DD5D80")]
	private void AOAGIOCEPPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7DD5540", Offset = "0x7DD3D40", VA = "0x187DD5540")]
	private static void AFOPCMFGPPO(Dictionary<ECBDBECHDME, Material> MBEFJGBJNEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7DDDB30", Offset = "0x7DDC330", VA = "0x187DDDB30")]
	private static void LEIFEBLDKHL(Dictionary<Renderer, JDGBFDAALDB> NMJLECJDNEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7DE07B0", Offset = "0x7DDEFB0", VA = "0x187DE07B0")]
	private void NMCGAEIMALD(SkinnedMeshRenderer[] CBBJPOGILOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7DDD070", Offset = "0x7DDB870", VA = "0x187DDD070")]
	private void KCCINBNHOEE(SkinnedMeshRenderer MPBIIJKLLOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7DD7600", Offset = "0x7DD5E00", VA = "0x187DD7600")]
	private void BMEKNNINHOJ(List<CJHHFDGDDDE> DGHEEGKBAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7DE16D0", Offset = "0x7DDFED0", VA = "0x187DE16D0")]
	private void PGIALMKONGN(Dictionary<string, OBKOLGEFKBC<Texture2D>> LILGCKMMEFL, bool FGHNHICOFNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7DD9E00", Offset = "0x7DD8600", VA = "0x187DD9E00")]
	private void DNLECLAPDCO(Dictionary<string, List<ECBDBECHDME>> LILGCKMMEFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7DD59C0", Offset = "0x7DD41C0", VA = "0x187DD59C0")]
	private void AICAIKHLAIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7DDC260", Offset = "0x7DDAA60", VA = "0x187DDC260")]
	private void JAEMBDLLIIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7DE09B0", Offset = "0x7DDF1B0", VA = "0x187DE09B0")]
	private void NMOIECFEPBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7DD5CB0", Offset = "0x7DD44B0", VA = "0x187DD5CB0")]
	private void AMAJBMLGPEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7DDC0A0", Offset = "0x7DDA8A0", VA = "0x187DDC0A0")]
	private void IHINDHEIMBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7DDCE40", Offset = "0x7DDB640", VA = "0x187DDCE40")]
	private void JNMAJGJNDNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7DDC170", Offset = "0x7DDA970", VA = "0x187DDC170")]
	private void IKHJIBJEHID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7DD77D0", Offset = "0x7DD5FD0", VA = "0x187DD77D0")]
	private void BMOIEPPOCLC(bool EPCBDLBPDHI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7DDCF90", Offset = "0x7DDB790", VA = "0x187DDCF90")]
	private void JOKAKLEIKJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7DDB170", Offset = "0x7DD9970", VA = "0x187DDB170")]
	private void GJELPBFLBHB(bool EPCBDLBPDHI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7DD56A0", Offset = "0x7DD3EA0", VA = "0x187DD56A0")]
	private void AHOAOHAKFDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7DD9E50", Offset = "0x7DD8650", VA = "0x187DD9E50")]
	private void EAODKBJLOFB(Material JFDDANCAOID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7DDD4A0", Offset = "0x7DDBCA0", VA = "0x187DDD4A0")]
	private void KFIMALDGIGH(Material JFDDANCAOID, Color DNPEIDEPJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8BA0", Offset = "0x7DD73A0", VA = "0x187DD8BA0")]
	private void BOMNHHJJHJJ(Material JFDDANCAOID, Color DNPEIDEPJGF, Color CBLEFOEFMDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7DE0020", Offset = "0x7DDE820", VA = "0x187DE0020")]
	private void MHBPKKHGPKN(Material JFDDANCAOID, Color GHACELNNKIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7DDFE30", Offset = "0x7DDE630", VA = "0x187DDFE30")]
	private void MEKDADNELGC(Material JFDDANCAOID, Texture2D AILALHOICPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7DE0F70", Offset = "0x7DDF770", VA = "0x187DE0F70")]
	private void ODDPAMGPEGO(Material JFDDANCAOID, Texture JCLBCHGJCPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7DDDC90", Offset = "0x7DDC490", VA = "0x187DDDC90")]
	private void LEMBNJOFICA(Action<JDGBFDAALDB> BODKMEIHEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7DE0430", Offset = "0x7DDEC30", VA = "0x187DE0430")]
	private void NGADMPGNEMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7DD6F80", Offset = "0x7DD5780", VA = "0x187DD6F80")]
	private void BIBIKPGFEGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7DDA3E0", Offset = "0x7DD8BE0", VA = "0x187DDA3E0")]
	private void EPEEFMBPCNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7DDD110", Offset = "0x7DDB910", VA = "0x187DDD110")]
	public void KDIPJGNJCNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7DDBBA0", Offset = "0x7DDA3A0", VA = "0x187DDBBA0", Slot = "4")]
	private void PKNBNOIIOGJ([In] PBODBAOOJMB BOCMNLKCKGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7DD6DF0", Offset = "0x7DD55F0", VA = "0x187DD6DF0")]
	[CompilerGenerated]
	private FKGMEHDMFDF BADEENAMAIK(JNAOBMPIJBG LNKCJPMONLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x7DE10D0", Offset = "0x7DDF8D0", VA = "0x187DE10D0")]
	[CompilerGenerated]
	private void ODLFCMKCEDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7DDCE10", Offset = "0x7DDB610", VA = "0x187DDCE10")]
	[CompilerGenerated]
	private void JNADNDFOJCD(JDGBFDAALDB HEMLFKMOIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7DDA350", Offset = "0x7DD8B50", VA = "0x187DDA350")]
	[CompilerGenerated]
	private void EGAMNKLEJLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7DDC240", Offset = "0x7DDAA40", VA = "0x187DDC240")]
	[CompilerGenerated]
	private void INJDMALKALA(JDGBFDAALDB HEMLFKMOIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7DDBCA0", Offset = "0x7DDA4A0", VA = "0x187DDBCA0")]
	[CompilerGenerated]
	private void ICBLEGNILMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7DDA330", Offset = "0x7DD8B30", VA = "0x187DDA330")]
	[CompilerGenerated]
	private void EBHOICPBPOF(JDGBFDAALDB HEMLFKMOIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7DDD610", Offset = "0x7DDBE10", VA = "0x187DDD610")]
	[CompilerGenerated]
	private void KFLDLNAPKPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7DDD990", Offset = "0x7DDC190", VA = "0x187DDD990")]
	[CompilerGenerated]
	private void KKLNMDNDNOA(JDGBFDAALDB HEMLFKMOIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7DE1A20", Offset = "0x7DE0220", VA = "0x187DE1A20")]
	[CompilerGenerated]
	private void PLFLFOIGBFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7DD9DA0", Offset = "0x7DD85A0", VA = "0x187DD9DA0")]
	[CompilerGenerated]
	private void DGBABDNDEDC(JDGBFDAALDB HEMLFKMOIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7DE1990", Offset = "0x7DE0190", VA = "0x187DE1990")]
	[CompilerGenerated]
	private void PJOGBFJLFAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7DE0400", Offset = "0x7DDEC00", VA = "0x187DE0400")]
	[CompilerGenerated]
	private void NFLEAOHONIA(JDGBFDAALDB HEMLFKMOIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7DDB250", Offset = "0x7DD9A50", VA = "0x187DDB250")]
	[CompilerGenerated]
	private void GKMDGNDPGLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7DDC140", Offset = "0x7DDA940", VA = "0x187DDC140")]
	[CompilerGenerated]
	private void IJMCDEJINBA(JDGBFDAALDB HEMLFKMOIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7DE0330", Offset = "0x7DDEB30", VA = "0x187DE0330")]
	[CompilerGenerated]
	private void NDDBBPOCGEL(KeyValuePair<string, OBKOLGEFKBC<Texture2D>> BHFFIDJKCOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7DD94C0", Offset = "0x7DD7CC0", VA = "0x187DD94C0")]
	[CompilerGenerated]
	private void CIECHMPHFGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7DD53C0", Offset = "0x7DD3BC0", VA = "0x187DD53C0")]
	[CompilerGenerated]
	private void AAHIDDDBKCO(JDGBFDAALDB HEMLFKMOIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7DE12D0", Offset = "0x7DDFAD0", VA = "0x187DE12D0")]
	[CompilerGenerated]
	private void PBNEDENPHFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7DDC3F0", Offset = "0x7DDABF0", VA = "0x187DDC3F0")]
	[CompilerGenerated]
	private void JDDBAHDCNOE(JDGBFDAALDB HEMLFKMOIDL)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class AvatarElbowBendHelperController : MonoBehaviour, IOOHCENIFJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		[GKBMICLOBGF(CGAFHOMJNOP.Self, false, false, false)]
		[SerializeField]
		private Transform ElbowHelperBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		[SerializeField]
		private Transform UpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		[SerializeField]
		private Transform LowerArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		[SerializeField]
		private float MinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		[SerializeField]
		private float MaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[SerializeField]
		[Header("Scale")]
		[FormerlySerializedAs("MinScaleValues")]
		private Vector3 ScaleValuesAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[SerializeField]
		[FormerlySerializedAs("MaxScaleValues")]
		private Vector3 ScaleValuesAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[Header("Positional Offset")]
		[SerializeField]
		[FormerlySerializedAs("MinLocalPositionalOffset")]
		private Vector3 PositionalOffsetAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		[SerializeField]
		[FormerlySerializedAs("MaxLocalPositionOffset")]
		private Vector3 PositionalOffsetAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private Vector3? BCDJDGIKMEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private bool JAONOJPFPFM;

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7DCDAE0", Offset = "0x7DCC2E0", VA = "0x187DCDAE0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7DCE100", Offset = "0x7DCC900", VA = "0x187DCE100", Slot = "4")]
		public void UpdateController(float JGHFILFLDDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xCD0E30", Offset = "0xCCF630", VA = "0x180CD0E30", Slot = "6")]
		public void SetEnabled(bool MGONBEDEDON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7DCDBC0", Offset = "0x7DCC3C0", VA = "0x187DCDBC0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7DCE5C0", Offset = "0x7DCCDC0", VA = "0x187DCE5C0")]
		public AvatarElbowBendHelperController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class AvatarElbowBendTargetController : MonoBehaviour, IOOHCENIFJI
	{
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private const float LKCKEJHBLKC = 45f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		[GKBMICLOBGF(CGAFHOMJNOP.Self, false, false, false)]
		[SerializeField]
		private Transform ElbowBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		[SerializeField]
		private Transform NeckBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[SerializeField]
		private Transform UpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[SerializeField]
		private bool Left;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		[SerializeField]
		private float MinTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		[SerializeField]
		private float MaxTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		[SerializeField]
		private float TwistWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		[SerializeField]
		private float ElbowSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		[SerializeField]
		private float RestTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		[SerializeField]
		private float RestTwistWhenClose;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		[SerializeField]
		private float RestTwistDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private Vector3 BDCFAINIIGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private Vector3 EKBCFIMFACD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private bool JAONOJPFPFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private float CFGGGLNGGFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private float HJCAMGBLDGG;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7DCE940", Offset = "0x7DCD140", VA = "0x187DCE940", Slot = "4")]
		public void UpdateController(float JGHFILFLDDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0xF06CE0", Offset = "0xF054E0", VA = "0x180F06CE0", Slot = "6")]
		public void SetEnabled(bool MGONBEDEDON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x7DCE660", Offset = "0x7DCCE60", VA = "0x187DCE660")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7DCF400", Offset = "0x7DCDC00", VA = "0x187DCF400")]
		public AvatarElbowBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class GEDBPIOCADA : DEJGECFFKMC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private static readonly int OPFLBLJDCJA;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private static readonly int HKKLNGECKAL;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private static readonly int JCCJBGNLOJO;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static readonly int JLFFMLPBEIA;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private static readonly int ELOAGLGEMKA;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static readonly int KFEINOAOBBE;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static readonly int MONAOGDOCKO;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private static readonly int LLEKNAKAMGA;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private static readonly int MDNBDCCKIOC;

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private static readonly int DJDBHGCBPOH;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private static readonly int MENKBFPFGNI;

	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private static readonly int DEAFALFMHJN;

	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private static readonly int EGHACCEDAAE;

	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private static readonly int ALNIALFJGOL;

	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private static readonly int PJALEHFMMGA;

	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private static readonly int DPOIMKOGOIE;

	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private static readonly int KBFIGODIPMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private Transform GFDGLMNEBDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private Transform BPHPPADGMHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private Transform GLHDKIPEBKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private Transform LFIKBELEANG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private Transform EPCGEKADLAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private Transform GHMFEGMEJJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private EALJFBNDNNC FADNEFADOLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private Material MABCDKAGFDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private SkinnedMeshRenderer[] OHIHFJPFBKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private readonly List<Material> MHKJFJMOHEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private KOABCLNMMFE NHLGNIEJMDC;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public KECNPIDOCPH FLNNHPPIPMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private KOABCLNMMFE LACPBJDPKOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7DEF080", Offset = "0x7DED880", VA = "0x187DEF080")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool HFNFNBOGCLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x7DEDB50", Offset = "0x7DEC350", VA = "0x187DEDB50", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x7DEEFD0", Offset = "0x7DED7D0", VA = "0x187DEEFD0")]
	public void IEAMPCKAMFG([In] EALJFBNDNNC PANINBEMOCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x7DEDAB0", Offset = "0x7DEC2B0", VA = "0x187DEDAB0")]
	public void CDDHBNIMEAD([In] JBKGMOCMIAO EOIGFLMHAMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x7DED5A0", Offset = "0x7DEBDA0", VA = "0x187DED5A0", Slot = "6")]
	public void BFBMPDFBKHI(LICFMLEECPJ DJMNLHANBEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7DEF240", Offset = "0x7DEDA40", VA = "0x187DEF240")]
	private Vector2 OGFNJBEFGFP(Vector2 JCNEMEMJBKK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7DEE0E0", Offset = "0x7DEC8E0", VA = "0x187DEE0E0")]
	public void HPELJBPGJLM([In] KDJMGKJFBEN EOIGFLMHAMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x7DEDCA0", Offset = "0x7DEC4A0", VA = "0x187DEDCA0")]
	private void CPNCLCPAJHJ(IJMFKIEOCHI GNNKIPBGOFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7DED210", Offset = "0x7DEBA10", VA = "0x187DED210")]
	private void BDAMHGNMJNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7DEE060", Offset = "0x7DEC860", VA = "0x187DEE060")]
	private void NILMHAPBKKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7DEE060", Offset = "0x7DEC860", VA = "0x187DEE060", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7DEF570", Offset = "0x7DEDD70", VA = "0x187DEF570")]
	public GEDBPIOCADA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x7DEDAB0", Offset = "0x7DEC2B0", VA = "0x187DEDAB0", Slot = "5")]
	private void LKLFLNEFGPB([In] JBKGMOCMIAO EOIGFLMHAMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7DEE0D0", Offset = "0x7DEC8D0", VA = "0x187DEE0D0", Slot = "7")]
	private void GEDFJDIJFJK([In] KDJMGKJFBEN EOIGFLMHAMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7DEF100", Offset = "0x7DED900", VA = "0x187DEF100")]
	[CompilerGenerated]
	internal static float JKGIBDOEDGA(float MGONBEDEDON, float JOEAEIKOONH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7DEF150", Offset = "0x7DED950", VA = "0x187DEF150")]
	[CompilerGenerated]
	internal static void KIKGAJPJDAM(Vector2 BCNNFBOLBMM, Vector2 BLONNAEPFDN, Vector2 GGIJOHIPOOO, Vector2 EDBIKCGPICF, Vector2 PIMEBNLNKIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7DEF110", Offset = "0x7DED910", VA = "0x187DEF110")]
	[CompilerGenerated]
	internal static Vector4 KBDFDODFCOI(Vector2 KKEEFCOJJFM, Vector2 DKMKOJPHLDD)
	{
		return default(Vector4);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class AvatarForearmRollController : MonoBehaviour, IOOHCENIFJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		[SerializeField]
		private Transform TwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		[SerializeField]
		private Transform LowerArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		[SerializeField]
		private Transform UpperArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		[SerializeField]
		private Transform ElbowTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		[SerializeField]
		private float RollTowardsWristAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		[SerializeField]
		private float RollSoftMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		[SerializeField]
		private float RollSoftMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		[SerializeField]
		private float LowerArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		[SerializeField]
		private float UpperArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		[SerializeField]
		private float ElbowTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private float CFGGGLNGGFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private bool JAONOJPFPFM;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x7DE4B10", Offset = "0x7DE3310", VA = "0x187DE4B10", Slot = "4")]
		public void UpdateController(float JGHFILFLDDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x17A3400", Offset = "0x17A1C00", VA = "0x1817A3400", Slot = "6")]
		public void SetEnabled(bool MGONBEDEDON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x7DE5370", Offset = "0x7DE3B70", VA = "0x187DE5370")]
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
			[Cpp2IlInjected.Token(Token = "0x400016D")]
			[Tooltip("Name of animation original state to override")]
			public string OriginalName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400016E")]
			[Tooltip("Name of animation state to use as an override")]
			public string OverrideName;

			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
			public AnimationOverride()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		[SerializeField]
		private AnimationOverride[] HandStateOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private Dictionary<int, int> _animationOverrides;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7DE53A0", Offset = "0x7DE3BA0", VA = "0x187DE53A0")]
		public void HNPKBJNJFKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x7DE54C0", Offset = "0x7DE3CC0", VA = "0x187DE54C0")]
		public int JBKDPHENCJL(int JOHDLHFLIEA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public AvatarHandDisplaySettings()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class JCBCLFGKHFJ : FNNDMPFNBGB
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x7DF1900", Offset = "0x7DF0100", VA = "0x187DF1900", Slot = "24")]
	public override float FBAKOIMLIDP()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7DF1950", Offset = "0x7DF0150", VA = "0x187DF1950")]
	public JCBCLFGKHFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class FNNDMPFNBGB : KKBENOBLINI
{
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private static int MAPFAEKFAHK;

	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private static int PFPMDAIELCJ;

	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private static int DEABBIEFGHO;

	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private static int PFBAMMNNAMD;

	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private static int BKNMCEDNEKG;

	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private static int CGDLCNFGGNG;

	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private static int NIOODDBKCEB;

	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private static int[] MMFOAEHOBBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private JMKBONANGLP FADNEFADOLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private DGDAEJELKMP JDDOFIOFBOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private int POIOCHHDIAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private float GGHPAOKAHBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	protected Animator NEHAHKIIDKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	protected AvatarConfiguration LBAOIAIDFAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	protected int EHBJGHJMKNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private int JGCOKOMGJKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private int EENBILKKFAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private bool BLJCPJKAMJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private EJCPKEJBBCH JHDCLHMGHPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private int FBAJANMPGOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private float JEJIKONOELJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private AvatarHandDisplaySettings JOBHJEEHDMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private CJONCCGGHCH JHJNKOFDBKE;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Transform ABFDEMKJDDD
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public Vector3 FEIGALPOKMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x17A5D00", Offset = "0x17A4500", VA = "0x1817A5D00")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x17A5F00", Offset = "0x17A4700", VA = "0x1817A5F00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Quaternion EMAIEPHFLHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0xDC47C0", Offset = "0xDC2FC0", VA = "0x180DC47C0")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0xF8F3E0", Offset = "0xF8DBE0", VA = "0x180F8F3E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool FMDCHDEGKCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7DECD60", Offset = "0x7DEB560", VA = "0x187DECD60")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x7DEC5E0", Offset = "0x7DEADE0", VA = "0x187DEC5E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool PCFBCGFDOMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xA927A0", Offset = "0xA90FA0", VA = "0x180A927A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public Vector3 BKCGGFDMKNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0xA54BE0", Offset = "0xA533E0", VA = "0x180A54BE0", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xA55B50", Offset = "0xA54350", VA = "0x180A55B50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Quaternion DJBGAKJFNDL
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x1122A90", Offset = "0x1121290", VA = "0x181122A90", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x154B050", Offset = "0x1549850", VA = "0x18154B050")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public BHFEFPLJLMD NDNDMDLEFCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0xB44520", Offset = "0xB42D20", VA = "0x180B44520", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return default(BHFEFPLJLMD);
		}
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xB44460", Offset = "0xB42C60", VA = "0x180B44460", Slot = "4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public BHFEFPLJLMD IOHJDPKFIAM
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x1124DB0", Offset = "0x11235B0", VA = "0x181124DB0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(BHFEFPLJLMD);
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x2658FE0", Offset = "0x26577E0", VA = "0x182658FE0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public float LKPNIEFMBJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xB3DE10", Offset = "0xB3C610", VA = "0x180B3DE10", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xF79050", Offset = "0xF77850", VA = "0x180F79050", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool CBECMLJHMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7DECC90", Offset = "0x7DEB490", VA = "0x187DECC90", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7DEC900", Offset = "0x7DEB100", VA = "0x187DEC900", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool OKDIHHACCOO
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x7DECD90", Offset = "0x7DEB590", VA = "0x187DECD90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool KCBILKBGGBL
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x7DEC620", Offset = "0x7DEAE20", VA = "0x187DEC620")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool JLDNLIHPCLB
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x7DEC8F0", Offset = "0x7DEB0F0", VA = "0x187DEC8F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool HMHCOKPLPJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x7DEC610", Offset = "0x7DEAE10", VA = "0x187DEC610")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x7DEC950", Offset = "0x7DEB150", VA = "0x187DEC950", Slot = "23")]
	public void IEAMPCKAMFG(JMKBONANGLP PANINBEMOCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x7DECD10", Offset = "0x7DEB510", VA = "0x187DECD10")]
	public void NOFJCJJHKJC(DGDAEJELKMP HECBLBAKOBH, AvatarHandDisplaySettings OIIBNOKOCAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x7DEC630", Offset = "0x7DEAE30", VA = "0x187DEC630", Slot = "14")]
	public void FOGJMALPAME(bool CCCAKBLNGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x7DEC270", Offset = "0x7DEAA70", VA = "0x187DEC270", Slot = "13")]
	public void BAHKHJCGICF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0xB3DE10", Offset = "0xB3C610", VA = "0x180B3DE10", Slot = "24")]
	public virtual float FBAKOIMLIDP()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x7DECB10", Offset = "0x7DEB310", VA = "0x187DECB10")]
	private int KLCFGDICIKP(BHFEFPLJLMD KLOIKONCKDK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x7DEC710", Offset = "0x7DEAF10", VA = "0x187DEC710")]
	private void GHKPPFALHMG(int NGHBAIIPGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x7DECAF0", Offset = "0x7DEB2F0", VA = "0x187DECAF0", Slot = "15")]
	public bool JEPCNCKMDKI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7DECD00", Offset = "0x7DEB500", VA = "0x187DECD00", Slot = "16")]
	public bool NFCBKNPMHMB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x7DEC6C0", Offset = "0x7DEAEC0", VA = "0x187DEC6C0")]
	private BHFEFPLJLMD GCIOPFJBDAH()
	{
		return default(BHFEFPLJLMD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x1CFCFD0", Offset = "0x1CFB7D0", VA = "0x181CFCFD0", Slot = "17")]
	public void FJLLCNGOMLN(bool CCCAKBLNGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x7DEC910", Offset = "0x7DEB110", VA = "0x187DEC910", Slot = "12")]
	public void IDEMGGPKCML(int NGHBAIIPGAK, float OJFCEFANOBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x7DEC8D0", Offset = "0x7DEB0D0", VA = "0x187DEC8D0", Slot = "10")]
	public void GLDGKHLPEEO(EJCPKEJBBCH OJGLGPLNKGO, bool CICNLBIFCMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x7DECCF0", Offset = "0x7DEB4F0", VA = "0x187DECCF0", Slot = "11")]
	public void MGDPKHFCHBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7DECCA0", Offset = "0x7DEB4A0", VA = "0x187DECCA0", Slot = "18")]
	public void LPAKNBPJIFJ(Transform MJNLMOPPION, Vector3 NDENPKKMCME, Quaternion IKAPNPCFHMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x7DED030", Offset = "0x7DEB830", VA = "0x187DED030")]
	public FNNDMPFNBGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class PJHHKEHLNOA : JNAOBMPIJBG
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class CKFBPONEBJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public PJHHKEHLNOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public List<CJHHFDGDDDE> prefabHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public List<CJHHFDGDDDE> materialHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public OBKOLGEFKBC<Material[]> loadMaterialsHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public OBKOLGEFKBC<DEAEKBLCCPD> loadPrefabHandle;

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public CKFBPONEBJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x7DE80E0", Offset = "0x7DE68E0", VA = "0x187DE80E0")]
		internal FKGMEHDMFDF OBDBEHPFAFC(string error)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	public OPEJGCCNPHE KNEKFLLJIJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	public DEAEKBLCCPD HDIKIGOIGJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private OBKOLGEFKBC<DEAEKBLCCPD> KIEEDGMKPPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private OBKOLGEFKBC<Material[]> DJCFOJNKFKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	public Material[] CLEICODICJP;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool OIJIHPOFDNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0xA56260", Offset = "0xA54A60", VA = "0x180A56260")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0xA56080", Offset = "0xA54880", VA = "0x180A56080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public AFHHIDGAGFC.KICMKFFCOMP FHOCOKEPBNO
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0xA2D4A0", Offset = "0xA2BCA0", VA = "0x180A2D4A0")]
		[CompilerGenerated]
		get
		{
			return default(AFHHIDGAGFC.KICMKFFCOMP);
		}
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0xA30040", Offset = "0xA2E840", VA = "0x180A30040")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x7DF7870", Offset = "0x7DF6070", VA = "0x187DF7870")]
	public PJHHKEHLNOA(AMKHIMALNFB ALHFMAIGMHK, OPEJGCCNPHE BAGIBCLBBOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x7DF6AA0", Offset = "0x7DF52A0", VA = "0x187DF6AA0", Slot = "6")]
	public override FKGMEHDMFDF DEDHPBLDALP(List<CJHHFDGDDDE> AGFGEFFAFDM, List<CJHHFDGDDDE> CNJNIOPOLCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x7DF67A0", Offset = "0x7DF4FA0", VA = "0x187DF67A0")]
	public FKGMEHDMFDF CPMAHDAFLDD(List<CJHHFDGDDDE> AGFGEFFAFDM, List<CJHHFDGDDDE> CNJNIOPOLCH, OBKOLGEFKBC<Material[]> DJCFOJNKFKI, [Optional] OBKOLGEFKBC<DEAEKBLCCPD> OAJPMLANEDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x7DF74B0", Offset = "0x7DF5CB0", VA = "0x187DF74B0")]
	public (OBKOLGEFKBC<Material[]>, OBKOLGEFKBC<DEAEKBLCCPD>) ONDDKDKLABP(List<CJHHFDGDDDE> AGFGEFFAFDM, List<CJHHFDGDDDE> CNJNIOPOLCH)
	{
		return default((OBKOLGEFKBC<Material[]>, OBKOLGEFKBC<DEAEKBLCCPD>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x7DF6650", Offset = "0x7DF4E50", VA = "0x187DF6650", Slot = "7")]
	public override OCMBNCGAGIF BLHKKBOPOEG(uint MBAOJAPNLMO, AvatarSkinnedMeshBoneOrderRemapsData OCNBNBLGNOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7DF6F40", Offset = "0x7DF5740", VA = "0x187DF6F40")]
	public OCMBNCGAGIF JAKPJLMLBJH(GameObject CBNHNEHIMKE, uint MBAOJAPNLMO, bool DGGPHLFBCLF, bool AADFGKKEGCF, AvatarSkinnedMeshBoneOrderRemapsData OCNBNBLGNOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7DF7150", Offset = "0x7DF5950", VA = "0x187DF7150")]
	public static bool NPEHBNNBBEC(Renderer[] CBBJPOGILOI, string PLEJBHDDNPH, [Out] Renderer PFJPKGMDGBJ, [Out] Renderer CKBLHILLIBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x7DF7820", Offset = "0x7DF6020", VA = "0x187DF7820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x7DF6580", Offset = "0x7DF4D80", VA = "0x187DF6580")]
	private (OBKOLGEFKBC<DEAEKBLCCPD>, OBKOLGEFKBC<Material[]>) BDAKMANDJLG()
	{
		return default((OBKOLGEFKBC<DEAEKBLCCPD>, OBKOLGEFKBC<Material[]>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x7DF6780", Offset = "0x7DF4F80", VA = "0x187DF6780")]
	[CompilerGenerated]
	private void CNPLMNNKFMP(DEAEKBLCCPD KJCFPPKBAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0xA274E0", Offset = "0xA25CE0", VA = "0x180A274E0")]
	[CompilerGenerated]
	private void EABKGDOCMJO(Material[] KJCFPPKBAOB)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class AvatarKneeBendTargetController : MonoBehaviour, IOOHCENIFJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		[GKBMICLOBGF(CGAFHOMJNOP.Self, false, false, false)]
		[SerializeField]
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
		private Vector3 BDCFAINIIGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private Vector3 CIMGPAMIFOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private Vector3 PICNKGOJKAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private Matrix4x4 MBEHAGIJLJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private bool JAONOJPFPFM;

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7DE59A0", Offset = "0x7DE41A0", VA = "0x187DE59A0", Slot = "4")]
		public void UpdateController(float JGHFILFLDDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x7DE5990", Offset = "0x7DE4190", VA = "0x187DE5990", Slot = "6")]
		public void SetEnabled(bool MGONBEDEDON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x7DE5530", Offset = "0x7DE3D30", VA = "0x187DE5530")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x7DE6060", Offset = "0x7DE4860", VA = "0x187DE6060")]
		public AvatarKneeBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[DIADIMJDNBG]
public struct GFCIKNOLKPL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	[ReadOnly]
	public DPIJEMNNPFN OIJBFACMGHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	[ReadOnly]
	public int CGALNJNLDAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	public MEIGAEBCJLK HLPABCACJAN;

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x7DEF6B0", Offset = "0x7DEDEB0", VA = "0x187DEF6B0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[DIADIMJDNBG]
[NativeContainer]
public struct MEIGAEBCJLK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	public NativeArray<Vector3> AFOMPMKEHIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	public NativeArray<Vector3> NEBBAAMKBDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public NativeArray<Vector4> CIJLIHGKMBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public NativeArray<Vector2> AFFHJGKJDJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public NativeArray<Vector2> OPKCAOIANAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public NativeArray<Vector2> OECLHOAHAIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public NativeArray<Vector2> GKBCJBKIINH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public NativeArray<Color> ADHIECAEHKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public NativeArray<int> BFBBKFOJBNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	public NativeArray<int> KMKJAHOKANB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private NativeArray<int> BFBEOFJHDPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private NativeArray<int> BMJKCCHEBOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	public NativeArray<int> MJLJNADNNGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	public NativeArray<int> NDGMHLIEPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public NativeArray<int> HHJKPMBJBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	public NativeArray<BoneWeight> NCGNMFHOFBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private NativeArray<int> JCPNJLMMOLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private bool NEFGIMNFAEJ;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int LCHAMOGKKEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7DF5D60", Offset = "0x7DF4560", VA = "0x187DF5D60")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x7DF5930", Offset = "0x7DF4130", VA = "0x187DF5930")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int JJFPHPMPKJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x7DF5860", Offset = "0x7DF4060", VA = "0x187DF5860")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7DF5390", Offset = "0x7DF3B90", VA = "0x187DF5390")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public int MGKIJOBAFFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x7DF59F0", Offset = "0x7DF41F0", VA = "0x187DF59F0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x7DF5A00", Offset = "0x7DF4200", VA = "0x187DF5A00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x7DF5D70", Offset = "0x7DF4570", VA = "0x187DF5D70")]
	public MEIGAEBCJLK(int JFJPHDJMCJC, int KADPIJFKHLP, int FNMACDCMJEN, int APNABPPLLGE, Allocator GFNKGIEEHMD, int GIFEJMIEOGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x7DF5320", Offset = "0x7DF3B20", VA = "0x187DF5320")]
	public void AAMGNKNCBEF(int PNJCJGEIDHG, Vector3 KENANDNBOGI, Vector3 IHGBDKLNHAA, Vector4 ODKLOJBBLOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x7DF5470", Offset = "0x7DF3C70", VA = "0x187DF5470")]
	public void DLICADLICMI(int PNJCJGEIDHG, BoneWeight MLEBNNLGKNK, NativeSlice<byte> FFJDDCBJKKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x7DF5880", Offset = "0x7DF4080", VA = "0x187DF5880")]
	public Color LABPCADJLOI(int PNJCJGEIDHG)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x7DF57C0", Offset = "0x7DF3FC0", VA = "0x187DF57C0")]
	public void EKLELLGJOAB(int PNJCJGEIDHG, Color GJJIDOPGHFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x7DF5810", Offset = "0x7DF4010", VA = "0x187DF5810")]
	public void IHLEFFMCHED(byte FKGKGDHMPAI, int PNJCJGEIDHG, Vector2 DCPFNGLMDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x7DF5870", Offset = "0x7DF4070", VA = "0x187DF5870")]
	public void KIMENEEMMIF(int PNJCJGEIDHG, int KGLLBNOCJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x7DF57E0", Offset = "0x7DF3FE0", VA = "0x187DF57E0")]
	public bool FODOGJAIINM(int FKGKGDHMPAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7DF53A0", Offset = "0x7DF3BA0", VA = "0x187DF53A0")]
	public void DINOIHDKCKM(int KFODBDJKPLA, int BJCMHPBMOOK, int AEPPOMGGPKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x7DF5940", Offset = "0x7DF4140", VA = "0x187DF5940")]
	public int[] OMINALIOFJM(int KFODBDJKPLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x7DF58A0", Offset = "0x7DF40A0", VA = "0x187DF58A0")]
	private NativeSlice<int> MGKALIOPOOA(int KFODBDJKPLA)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x7DF5610", Offset = "0x7DF3E10", VA = "0x187DF5610", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x7DF5A10", Offset = "0x7DF4210", VA = "0x187DF5A10")]
	public Mesh PMILKEDBPEK([Optional] string FLMOIPFGGHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[NativeContainer]
[DefaultMember("Item")]
[DIADIMJDNBG]
public struct DPIJEMNNPFN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	public NativeArray<Vector3> AFOMPMKEHIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	public NativeArray<Vector3> NEBBAAMKBDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	public NativeArray<Vector4> CIJLIHGKMBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public NativeArray<Vector2> AFFHJGKJDJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public NativeArray<Vector2> OPKCAOIANAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public NativeArray<Vector2> OECLHOAHAIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public NativeArray<Vector2> GKBCJBKIINH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public NativeArray<Color> ADHIECAEHKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public NativeArray<int> DHEIDJKOMJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	public NativeArray<int> AJGGBDAACNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public NativeArray<int> PPNCFHMPLJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public NativeArray<int> GHPHPPAAJEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public NativeArray<bool> AFHOKGPBJBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public NativeArray<int> NJILOLKKMNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	public NativeArray<int> PBFEKDDPBLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	public NativeArray<BoneWeight> DADOCABOBDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private NativeArray<Matrix4x4> HIOBIDLHBHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private NativeArray<long> JGLFANHBIMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private NativeArray<byte> ONGNACPPMOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private NativeArray<int> BNACHEPEGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private NativeArray<int> DMFCDLCOILG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	public NativeArray<sbyte> ANJJALDOLBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	public NativeArray<byte> CJCKHJAOAFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private NativeArray<int> ICEBONNPFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	private bool NEFGIMNFAEJ;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int KLLEPPDBBKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xE48A70", Offset = "0xE47270", VA = "0x180E48A70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int KOHLKBKOFLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xCD3CC0", Offset = "0xCD24C0", VA = "0x180CD3CC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public int APJJLAOFBLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x7DE8BA0", Offset = "0x7DE73A0", VA = "0x187DE8BA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public int LIPPLPFLKKK
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x7DE88C0", Offset = "0x7DE70C0", VA = "0x187DE88C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7DE88E0", Offset = "0x7DE70E0", VA = "0x187DE88E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public int LCHAMOGKKEO
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7DE91F0", Offset = "0x7DE79F0", VA = "0x187DE91F0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7DE8CB0", Offset = "0x7DE74B0", VA = "0x187DE8CB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int APBEBHANDIG
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x7DE8B80", Offset = "0x7DE7380", VA = "0x187DE8B80")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7DE8B90", Offset = "0x7DE7390", VA = "0x187DE8B90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public MIKMGDAKPOO GDHAEGPEDIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x7DE8900", Offset = "0x7DE7100", VA = "0x187DE8900")]
		get
		{
			return default(MIKMGDAKPOO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7DE8BD0", Offset = "0x7DE73D0", VA = "0x187DE8BD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public byte LCDHAHAFNPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x7DE88F0", Offset = "0x7DE70F0", VA = "0x187DE88F0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x7DE88D0", Offset = "0x7DE70D0", VA = "0x187DE88D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public CLIIHPFPEEH NOJAFKJLFLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x7DE8CC0", Offset = "0x7DE74C0", VA = "0x187DE8CC0")]
		get
		{
			return default(CLIIHPFPEEH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x7DE9200", Offset = "0x7DE7A00", VA = "0x187DE9200")]
	public DPIJEMNNPFN(IList<Mesh> LOGBKDFDENO, IList<Matrix4x4> EBFLOLCFNCE, IList<bool> AFHOKGPBJBM, byte JGFKHBHDMJL, IList<byte[]> MJGDOBIIGAI, IList<long> FOBNDAABCJG, IList<bool> AGCFCINHFGI, IList<int> NJILOLKKMNL, IList<int> PNFAPCOKEOB, IList<int> FLHGCIIPJHJ, Allocator GFNKGIEEHMD, MIKMGDAKPOO DKKFHFNCCLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x7DE8BE0", Offset = "0x7DE73E0", VA = "0x187DE8BE0")]
	public MEIGAEBCJLK MIMCLHIALEP(Allocator GFNKGIEEHMD)
	{
		return default(MEIGAEBCJLK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x7DE8910", Offset = "0x7DE7110", VA = "0x187DE8910", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[DIADIMJDNBG]
public class NNJKJIIBGNF : DCKNHLLJCKO
{
	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x7DF61D0", Offset = "0x7DF49D0", VA = "0x187DF61D0")]
	public DPIJEMNNPFN EPDGAIEIOHL()
	{
		return default(DPIJEMNNPFN);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x7DCFA00", Offset = "0x7DCE200", VA = "0x187DCFA00")]
	public NNJKJIIBGNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct CLIIHPFPEEH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	public NativeSlice<Vector3> AFOMPMKEHIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public NativeSlice<Vector3> NEBBAAMKBDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public NativeSlice<Vector4> CIJLIHGKMBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public NativeSlice<Vector2> AFFHJGKJDJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public NativeSlice<Vector2> OPKCAOIANAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public NativeSlice<Vector2> OECLHOAHAIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public NativeSlice<Vector2> GKBCJBKIINH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	public NativeSlice<Color> ADHIECAEHKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public NativeSlice<int> ALJIPPFCLMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public NativeSlice<int> GHPHPPAAJEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public NativeSlice<BoneWeight> DADOCABOBDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public NativeSlice<byte> PCLMGMFNIMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	public int JIDGABGHBEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public Matrix4x4 CJPBIOCPGMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public long DBEGBAPKAGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public NativeSlice<byte> FFJDDCBJKKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public bool HLIPLCHOLBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	public int ODOOEIPGFCC;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal readonly struct ECBDBECHDME : IEquatable<ECBDBECHDME>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	internal readonly Material CCOKKNAJIML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	internal readonly FEGKPDMKNPP PIAFOAPCIHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	internal readonly AKAPHFAPJFJ FCDLDNDIAPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	internal readonly AMKHIMALNFB IKMAIEDBJHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	internal readonly bool NDODGHIAAHG;

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x7DEAFB0", Offset = "0x7DE97B0", VA = "0x187DEAFB0")]
	public ECBDBECHDME(Material IPKNLMFNGIO, FEGKPDMKNPP LPHCFMKOJHP, AKAPHFAPJFJ IGJBFJBCPIK, AMKHIMALNFB BHONCPBICBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x7DEAD10", Offset = "0x7DE9510", VA = "0x187DEAD10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x7DEAA70", Offset = "0x7DE9270", VA = "0x187DEAA70", Slot = "4")]
	public bool Equals(ECBDBECHDME KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x7DEAB00", Offset = "0x7DE9300", VA = "0x187DEAB00", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x7DEAC00", Offset = "0x7DE9400", VA = "0x187DEAC00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyDisplayBehaviour : MonoBehaviour, OAEBMBIDNEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		[SerializeField]
		[Header("Configuration")]
		protected AvatarConfiguration configuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		[SerializeField]
		protected Animator skeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		[SerializeField]
		protected Renderer[] watchRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		[SerializeField]
		[Header("Configuration")]
		private CJONCCGGHCH avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		[SerializeField]
		private AvatarSkinAssetItem potatoAvatarSkinAssetItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		[SerializeField]
		[FormerlySerializedAs("avatarSkinAsset")]
		private AssetReference avatarSkinAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		[SerializeField]
		private GameObject firstPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		[SerializeField]
		public GameObject thirdPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		[SerializeField]
		private GameObject[] hideInFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		[SerializeField]
		protected Transform headAdditiveBaseBoneTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		[FormerlySerializedAs("BodyMaterial")]
		[SerializeField]
		private Material BodyMaterialSkinGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		[SerializeField]
		private Material BodyMaterialNonGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		[SerializeField]
		private Material FaceMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		[SerializeField]
		private Material DefaultAvatarItemMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		[SerializeField]
		private Shader AvatarDefaultShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		[SerializeField]
		private Shader AvatarUberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		[SerializeField]
		private Transform DeformRigRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		[SerializeField]
		private SkinnedMeshRenderer BaseSkinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		[SerializeField]
		protected AvatarSkinnedMeshBoneOrderRemapsData BoneOrderRemapsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		[SerializeField]
		[Header("Arm Animation Controllers")]
		private AvatarForearmRollController LeftForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		[SerializeField]
		private AvatarElbowBendHelperController LeftElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		[SerializeField]
		private AvatarElbowBendTargetController LeftElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		[SerializeField]
		private AvatarKneeBendTargetController LeftKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		[SerializeField]
		private AvatarForearmRollController RightForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		[SerializeField]
		private AvatarElbowBendHelperController RightElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		[SerializeField]
		private AvatarElbowBendTargetController RightElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		[SerializeField]
		private AvatarKneeBendTargetController RightKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		[SerializeField]
		private Transform LeftEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		[SerializeField]
		private Transform LeftEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		[SerializeField]
		private Transform RightEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		[SerializeField]
		private Transform RightEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		[SerializeField]
		private Transform NoseMoveTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		[SerializeField]
		private Transform MouthBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		[SerializeField]
		private AvatarBodyPartShapesManager avatarBodyPartShapesManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		[SerializeField]
		private Transform HatAnchorBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		[SerializeField]
		private Transform LeftHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		[SerializeField]
		private Transform RightHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		[SerializeField]
		private GameObject LeftHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		[SerializeField]
		private GameObject RightHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		private MEKGIBHCPGB KHCINGPIIKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		private DEJGECFFKMC DMLEKOPKHED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		private KKBENOBLINI BNKBIKALFEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		private KKBENOBLINI KAJBMDAPDBG;

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public MEKGIBHCPGB IBINANPDIPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x7DE6FE0", Offset = "0x7DE57E0", VA = "0x187DE6FE0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public DEJGECFFKMC DLHFIMANFGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x7DE7030", Offset = "0x7DE5830", VA = "0x187DE7030", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public KKBENOBLINI PGONDBIHNIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x7DE7080", Offset = "0x7DE5880", VA = "0x187DE7080", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public KKBENOBLINI CDCPNLHMHDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x7DE70D0", Offset = "0x7DE58D0", VA = "0x187DE70D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public Transform DIJJOEEBMAH
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x7DE7120", Offset = "0x7DE5920", VA = "0x187DE7120", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public CJONCCGGHCH FKBBHJAMMBK
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0xA30050", Offset = "0xA2E850", VA = "0x180A30050", Slot = "12")]
			get
			{
				return default(CJONCCGGHCH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x7DE6070", Offset = "0x7DE4870", VA = "0x187DE6070")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x7DE6BB0", Offset = "0x7DE53B0", VA = "0x187DE6BB0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x7DE64A0", Offset = "0x7DE4CA0", VA = "0x187DE64A0", Slot = "8")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x7DE6BB0", Offset = "0x7DE53B0", VA = "0x187DE6BB0", Slot = "9")]
		public void TeardownAvatarDisplaySystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x7DE60E0", Offset = "0x7DE48E0", VA = "0x187DE60E0", Slot = "10")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x7DE6EF0", Offset = "0x7DE56F0", VA = "0x187DE6EF0")]
		public void UpdatePostIKAnimControllers(float JGHFILFLDDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x7DE6410", Offset = "0x7DE4C10", VA = "0x187DE6410")]
		private void GCJOLNGJBEA(GameObject HPLLAPMNIJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x7DE6500", Offset = "0x7DE4D00", VA = "0x187DE6500")]
		private MEKGIBHCPGB LAHKJIDBDCN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x7DE6870", Offset = "0x7DE5070", VA = "0x187DE6870")]
		private DEJGECFFKMC MIKLOCBKNMA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x7DE6C60", Offset = "0x7DE5460", VA = "0x187DE6C60")]
		private KKBENOBLINI PHNJOMNNPLK(JMNLGEOMELD FJLCMJLPIEE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x7DE6FD0", Offset = "0x7DE57D0", VA = "0x187DE6FD0")]
		public AvatarModernBodyDisplayBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class JDGBFDAALDB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private MaterialPropertyBlock LPKKIAOKJKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	public Color? JBFHCJDLLPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	public Color? HPAAAJENFJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	public Color? DEMIJNNJIOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	public Color? HPMGIMNMKGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	public Color OMFPLJOPJAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	public Color ADNAOHDFMDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	public Color DPKFCHEAMNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	public float GPNNOKPGDCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	public Texture2D OCEFAEBLJGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	public Texture2D CNICDPNHPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	private Dictionary<ECBDBECHDME, int> CMAFOJOGEIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	private FEGKPDMKNPP[] BFEGIGBBNND;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	private AKAPHFAPJFJ[] LMEGMMGEOKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public Vector4[] PPKPIMCCHPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public Vector4[] PMMBBEOGJJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public Vector4[] EPMDMNMCNMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public Vector4[] JHOKEBGOIJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public Vector4[] EDGEAHFOCJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public Vector4[] JIFCDIHBNKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private List<Texture2D> APHBGJFLBGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private Vector4[] LDLFPLJHIGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private List<Texture2D> ENHDFLKAFNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private float[] EMKJNGBAKML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private Vector4[] MACEDOEGKFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private float[] JJBDEJMJIEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public float[] IFHDPIEGILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private List<Texture2D> JEKAHKDLECO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private float[] DCLOEHJDJDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private List<Texture2D> LAGGJFKOKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	private Vector4[] GFBGMJIANAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private float[] HGKIPPCNJOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private Vector4[] CHJECCJPLDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public float[] HEFPBFJKBPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public Texture2DArray POMBIKODELJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	public Texture2DArray DFBFBMHODDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	public Texture2DArray HALDNHDKCHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public Texture2DArray PINNDCMIHPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private bool BMBAAJMHMBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	private int DADNDBFBLIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private Vector2? CEPPIHMBOKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private TextureFormat BIKJIADJPLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private Vector2? GKLHAKCBHBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private TextureFormat MCCMPGJBNKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	private Vector2? ABNEJJFJKNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	private TextureFormat PDKJJODJHJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private Vector2? GMANOHMOOAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	private TextureFormat MCFOFDOAKKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	private bool DMJNBPLABAL;

	[Cpp2IlInjected.Token(Token = "0x400024E")]
	private static int KJJCDFPGHJO;

	[Cpp2IlInjected.Token(Token = "0x400024F")]
	private static int BFENKEBBCNL;

	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private static int PENLAIJNIOG;

	[Cpp2IlInjected.Token(Token = "0x4000251")]
	private static int KGLMDMJAAHH;

	[Cpp2IlInjected.Token(Token = "0x4000252")]
	private static int ILFCHJALGLP;

	[Cpp2IlInjected.Token(Token = "0x4000253")]
	private static int DLGDFIGDOFC;

	[Cpp2IlInjected.Token(Token = "0x4000254")]
	private static int MGDACJIEIDJ;

	[Cpp2IlInjected.Token(Token = "0x4000255")]
	private static int AALIHNAMFPN;

	[Cpp2IlInjected.Token(Token = "0x4000256")]
	private static int IJDDLMKMEGD;

	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private static int KIDLFJHFKMJ;

	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private static int GKNPHBBNKNJ;

	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private static int MCCAJMMIBJL;

	[Cpp2IlInjected.Token(Token = "0x400025A")]
	private static int PLKLCCDLBGO;

	[Cpp2IlInjected.Token(Token = "0x400025B")]
	private static int NKJLGGIMJBI;

	[Cpp2IlInjected.Token(Token = "0x400025C")]
	private static int CIFPKLHJEBH;

	[Cpp2IlInjected.Token(Token = "0x400025D")]
	private static int BKBBGCDCCCN;

	[Cpp2IlInjected.Token(Token = "0x400025E")]
	private static int LJOAIFDGDKM;

	[Cpp2IlInjected.Token(Token = "0x400025F")]
	private static int GNPNHLMKLML;

	[Cpp2IlInjected.Token(Token = "0x4000260")]
	private static int AMGAOLHBBFG;

	[Cpp2IlInjected.Token(Token = "0x4000261")]
	private static int PDMLDJBABAN;

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x7DF3FA0", Offset = "0x7DF27A0", VA = "0x187DF3FA0")]
	private JDGBFDAALDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x7DF44A0", Offset = "0x7DF2CA0", VA = "0x187DF44A0")]
	public JDGBFDAALDB(Color BCPDIPOOKFD, Color PIBKIFNBJNE, Color COFJIPFAILP, Color? ECNMEJLJFLF, Color? GCGAFOOEEEP, Color? NGKONEFHJON, Texture2D JALHLAKJODH, Texture2D ALMOFNAJMLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x7DF2100", Offset = "0x7DF0900", VA = "0x187DF2100")]
	internal int JGNAFNABOML(Material OJHLMEAJFPP, FEGKPDMKNPP LPHCFMKOJHP, AKAPHFAPJFJ IGJBFJBCPIK, AMKHIMALNFB BHONCPBICBN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x7DF21D0", Offset = "0x7DF09D0", VA = "0x187DF21D0")]
	private int JGNAFNABOML(ECBDBECHDME MNMCNOJCKAF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x7DF2F20", Offset = "0x7DF1720", VA = "0x187DF2F20")]
	internal int KIAJPHBFDIP(Material OJHLMEAJFPP, Color GHACELNNKIA, Color JGCCIMLMHPP, Color INBBHDHGJBD, Color DKEMBKEAHOB, Color IJMCOMPCOHA, Texture2D DJAJJKKDFFA, Vector4 NKLLAOJGLMC, Texture2D AJDMMHPPICA, Vector4 OCBOGJAPIGK, float NBGMNFKGKFA, float JPDHAPFNOKB, Texture2D CIPMEDHIKGD, Vector4 ELEAGFCODOH, float GBGBAGBOOHL, Texture2D CDONCBKADCE, Color BNDLCFCECGA, Vector4 DMDIDNOCNOI, FEGKPDMKNPP LPHCFMKOJHP, AKAPHFAPJFJ IGJBFJBCPIK, AMKHIMALNFB BHONCPBICBN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x7DF19B0", Offset = "0x7DF01B0", VA = "0x187DF19B0")]
	private void AKJADEMBIFG(List<Texture2D> APHBGJFLBGE, [Out] Texture2DArray CHNKHPLAOJG, [Out] Texture2DArray ADJCIBNNNKH, [Out] Texture2DArray ACHKGAAODGM, [Out] Texture2DArray CLGLIFOOEMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x7DF1FB0", Offset = "0x7DF07B0", VA = "0x187DF1FB0")]
	public void IFANLJADGBF(Shader HIIHGFGNNEG, Renderer FKGIDFBJGGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x7DF2260", Offset = "0x7DF0A60", VA = "0x187DF2260")]
	private void KIAHFEPCDJG(Shader HIIHGFGNNEG, Renderer FKGIDFBJGGD, int MFECNKLMLKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x7DF1CC0", Offset = "0x7DF04C0", VA = "0x187DF1CC0")]
	private Color CGHBKLMEKKI(Color GBEDHIJOGGF, FEGKPDMKNPP HGNBOIAPBOF)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x7DF1B70", Offset = "0x7DF0370", VA = "0x187DF1B70")]
	private Color BHHHMOLEGLH(Color OKGPBOFLGMC, FEGKPDMKNPP HGNBOIAPBOF)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x7DF3AF0", Offset = "0x7DF22F0", VA = "0x187DF3AF0")]
	private bool LMDNCBOJJAL(Texture2D ILAIHPBABLG, AKAPHFAPJFJ JNKNLKDBMCF, [Out] Texture2D CKMAJPIAGGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x7DF1F00", Offset = "0x7DF0700", VA = "0x187DF1F00")]
	private void FJLDDJMNOOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x7DF1EC0", Offset = "0x7DF06C0", VA = "0x187DF1EC0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public abstract class JNAOBMPIJBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	public readonly AMKHIMALNFB CGOOJHLFEDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	protected bool KBJDOOHLCKG;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public bool LAPCGNPLMDI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0xA9E9A0", Offset = "0xA9D1A0", VA = "0x180A9E9A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xA9E9B0", Offset = "0xA9D1B0", VA = "0x180A9E9B0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool PCIFJLBFJKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xA9E920", Offset = "0xA9D120", VA = "0x180A9E920")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0xA9E930", Offset = "0xA9D130", VA = "0x180A9E930")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public virtual AFHHIDGAGFC.KICMKFFCOMP DBEGBAPKAGC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(AFHHIDGAGFC.KICMKFFCOMP);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0xCE5900", Offset = "0xCE4100", VA = "0x180CE5900", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool BAEHEIENAJB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xFAF9C0", Offset = "0xFAE1C0", VA = "0x180FAF9C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public bool OHNADIMJNND
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x7DF4590", Offset = "0x7DF2D90", VA = "0x187DF4590")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public bool EPKAIHINFLM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x7DF4580", Offset = "0x7DF2D80", VA = "0x187DF4580")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public bool KDGJAHEEGGA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x7DF4560", Offset = "0x7DF2D60", VA = "0x187DF4560")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x7DF45A0", Offset = "0x7DF2DA0", VA = "0x187DF45A0")]
	protected JNAOBMPIJBG(AMKHIMALNFB ALHFMAIGMHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract FKGMEHDMFDF DEDHPBLDALP(List<CJHHFDGDDDE> AGFGEFFAFDM, List<CJHHFDGDDDE> CNJNIOPOLCH);

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract OCMBNCGAGIF BLHKKBOPOEG(uint MBAOJAPNLMO, AvatarSkinnedMeshBoneOrderRemapsData OCNBNBLGNOI);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class LLAKBJABMMN : IOGMNIMBIDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	private AvatarSkinAssetItem PPJNPFAJNMA;

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x7DF5220", Offset = "0x7DF3A20", VA = "0x187DF5220")]
	public LLAKBJABMMN(AvatarSkinAssetItem EJKGEEBJLAE, AvatarSkinAssetItem.MCLPHNMPHFK OIDEPEDPKJJ, AMKHIMALNFB BHONCPBICBN, [Optional] JKBFIDNMNPD? GHECFCIJJBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x7DF4FC0", Offset = "0x7DF37C0", VA = "0x187DF4FC0", Slot = "6")]
	public override FKGMEHDMFDF DEDHPBLDALP(List<CJHHFDGDDDE> AGFGEFFAFDM, List<CJHHFDGDDDE> CNJNIOPOLCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class POFPBGDFBGD
{
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	private static readonly int[] BMLJKELPNOG;

	[Cpp2IlInjected.Token(Token = "0x4000269")]
	private static readonly int[] KFAGLDPHNNF;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public static int[] MBAFCFJKNCF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x7DF7980", Offset = "0x7DF6180", VA = "0x187DF7980")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x7DF79D0", Offset = "0x7DF61D0", VA = "0x187DF79D0")]
	public static int[] MCAOHODMCID(bool OGEGKPPHJEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x7DF78F0", Offset = "0x7DF60F0", VA = "0x187DF78F0")]
	public static int GILFEFLADFE(KEIJGPDJMGG PFNOPBFECIM, bool OGEGKPPHJEB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x7DF78E0", Offset = "0x7DF60E0", VA = "0x187DF78E0")]
	private static int BLNEFEFHCBB(KEIJGPDJMGG PFNOPBFECIM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x7DF7A50", Offset = "0x7DF6250", VA = "0x187DF7A50")]
	private static int MGDKEDNHAHH(KEIJGPDJMGG PFNOPBFECIM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class GBPCHMALHFP
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class HDCIDOCDJAN : IEnumerator<ENGFNCJEKHI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private ENGFNCJEKHI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		private ENGFNCJEKHI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0xA2B740", Offset = "0xA29F40", VA = "0x180A2B740")]
		[DebuggerHidden]
		public HDCIDOCDJAN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x134F590", Offset = "0x134DD90", VA = "0x18134F590", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x7DF0920", Offset = "0x7DEF120", VA = "0x187DF0920", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
	public static void IPOKMMEANJH(string EBHOIBHGECB, int MBAOJAPNLMO, long NPJBEDFAIID, long CIHGCBLDFIB, long DEGLHPAJBGE, long AMECBGALDLL, long FJOFHOJCKDG, long JNKOJBNKCPI, long PLPGJEBLJKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x7DED120", Offset = "0x7DEB920", VA = "0x187DED120")]
	public static NGLIALCAJHK PDOIEKCJNKH(JobHandle KKELKEEOMNL, bool NLJPFKNNDEA, bool DMMPCADAEMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x7DED0B0", Offset = "0x7DEB8B0", VA = "0x187DED0B0")]
	[IteratorStateMachine(typeof(HDCIDOCDJAN))]
	private static IEnumerator<ENGFNCJEKHI> CIDFGGDCBPN(JobHandle DAMJGGDGMEF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class IBEEKEKDFBK
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public enum DOIGAIGOKON
	{
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		General,
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		ColoredHair
	}

	[Cpp2IlInjected.Token(Token = "0x400026D")]
	public static readonly int BDCNKIBFGDP;

	[Cpp2IlInjected.Token(Token = "0x400026E")]
	public static readonly int HLCKCKKFJLB;

	[Cpp2IlInjected.Token(Token = "0x400026F")]
	public static readonly int PDKDCGGCLPA;

	[Cpp2IlInjected.Token(Token = "0x4000270")]
	public static readonly int BDHCMDMLIHN;

	[Cpp2IlInjected.Token(Token = "0x4000271")]
	public static readonly int EKDNBJMOIAB;

	[Cpp2IlInjected.Token(Token = "0x4000272")]
	public static readonly int FELFPHJOPGP;

	[Cpp2IlInjected.Token(Token = "0x4000273")]
	public static readonly int BKPOMCLBECJ;

	[Cpp2IlInjected.Token(Token = "0x4000274")]
	public static readonly int KIEGPNBKFHC;

	[Cpp2IlInjected.Token(Token = "0x4000275")]
	public static readonly int PINKCBLAFIP;

	[Cpp2IlInjected.Token(Token = "0x4000276")]
	public static readonly int AIJADPNKHFE;

	[Cpp2IlInjected.Token(Token = "0x4000277")]
	public static readonly int LFMICFKIFME;

	[Cpp2IlInjected.Token(Token = "0x4000278")]
	public static readonly int PAPKKGBIOOC;

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x7DF0970", Offset = "0x7DEF170", VA = "0x187DF0970")]
	public static bool KBNKMAKHCON(Material IPKNLMFNGIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x7DF09E0", Offset = "0x7DEF1E0", VA = "0x187DF09E0")]
	public static bool PCCKBEALBJL(Material IPKNLMFNGIO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class IOGMNIMBIDH : JNAOBMPIJBG
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class DOEIBBIMNPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public OBKOLGEFKBC<GameObject> skinAvatarItemPrefabHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public IOGMNIMBIDH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public Action<string> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public DOEIBBIMNPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x7DE83B0", Offset = "0x7DE6BB0", VA = "0x187DE83B0")]
		internal void DALKLBLBOBP(GameObject result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x7DE8780", Offset = "0x7DE6F80", VA = "0x187DE8780")]
		internal void OBDBEHPFAFC(string error)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	protected AvatarSkinAssetItem KGHGNPEBBEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	protected Material[] APMCFALMMEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	private readonly AvatarSkinAssetItem.MCLPHNMPHFK MHJCJCFDKOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	private readonly AssetReference DPCOCHDCBBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	private readonly JKBFIDNMNPD? EIHLHHGIADG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	private SkinnedMeshRenderer[] GKFDFFOPGDK;

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public override AFHHIDGAGFC.KICMKFFCOMP DBEGBAPKAGC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0xA2D3B0", Offset = "0xA2BBB0", VA = "0x180A2D3B0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(AFHHIDGAGFC.KICMKFFCOMP);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0xA2D4E0", Offset = "0xA2BCE0", VA = "0x180A2D4E0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x7DF16B0", Offset = "0x7DEFEB0", VA = "0x187DF16B0")]
	public IOGMNIMBIDH(AvatarSkinAssetItem.MCLPHNMPHFK OIDEPEDPKJJ, AssetReference MLLKHECPPHM, Material COOLNDBIDBL, AMKHIMALNFB BHONCPBICBN, AFHHIDGAGFC.KICMKFFCOMP LLCDEGGKANM = (AFHHIDGAGFC.KICMKFFCOMP)0L, [Optional] JKBFIDNMNPD? GHECFCIJJBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x7DF17E0", Offset = "0x7DEFFE0", VA = "0x187DF17E0")]
	public IOGMNIMBIDH(AvatarSkinAssetItem.MCLPHNMPHFK OIDEPEDPKJJ, AssetReference MLLKHECPPHM, Material COOLNDBIDBL, AFHHIDGAGFC.KICMKFFCOMP LLCDEGGKANM = (AFHHIDGAGFC.KICMKFFCOMP)0L, [Optional] JKBFIDNMNPD? GHECFCIJJBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x7DF1420", Offset = "0x7DEFC20", VA = "0x187DF1420", Slot = "6")]
	public override FKGMEHDMFDF DEDHPBLDALP(List<CJHHFDGDDDE> AGFGEFFAFDM, List<CJHHFDGDDDE> CNJNIOPOLCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x7DF1210", Offset = "0x7DEFA10", VA = "0x187DF1210", Slot = "7")]
	public override OCMBNCGAGIF BLHKKBOPOEG(uint MBAOJAPNLMO, AvatarSkinnedMeshBoneOrderRemapsData OCNBNBLGNOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x7DF1640", Offset = "0x7DEFE40", VA = "0x187DF1640", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x7DF15F0", Offset = "0x7DEFDF0", VA = "0x187DF15F0")]
	protected void DEOPBHPFBEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class FKOMKPCCFKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	private List<int> MNMDAPCAGIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private List<AHCKAMGFJMA> ELKIELJELLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	private HashSet<Transform> GBCIJKEBJED;

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x7DEB7D0", Offset = "0x7DE9FD0", VA = "0x187DEB7D0")]
	public static FKOMKPCCFKE GCGHFGMAHLK(Transform ODKLOJBBLOI, Dictionary<Transform, OutfitType?> ICPJEKMOKJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x7DEB960", Offset = "0x7DEA160", VA = "0x187DEB960")]
	private void GDDADMOHJMC(Transform ODKLOJBBLOI, AMKHIMALNFB BHONCPBICBN, Dictionary<Transform, OutfitType?> ICPJEKMOKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x7DEC010", Offset = "0x7DEA810", VA = "0x187DEC010")]
	private void PPAFGGPDGEK(Transform MLKJJEMGGBP, AMKHIMALNFB BHONCPBICBN, bool JAOMHNIGBLI, OutfitType? CLJIDLBOOFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x7DEBC20", Offset = "0x7DEA420", VA = "0x187DEBC20")]
	public BJHALGJGJNJ GIMIIJJINEN(HashSet<string> HFJKABGLLNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x7DEC140", Offset = "0x7DEA940", VA = "0x187DEC140")]
	public FKOMKPCCFKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class BJHALGJGJNJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	private List<AHCKAMGFJMA> ELKIELJELLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	private List<Matrix4x4> LHCPBBEGMFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	private Transform[] JFGKDJNPOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	private Matrix4x4[] MAAJBJDNLHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	private Dictionary<NOKHKCLAACM, int> EAGNKNPNCEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	private List<GHEOBILGHHP> HJDKGFALKPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	private bool FPNKCIDPFLA;

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public int JAJBNKBAONK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x7DE7700", Offset = "0x7DE5F00", VA = "0x187DE7700")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public Transform[] HHLJFIIBAEB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x7DE75A0", Offset = "0x7DE5DA0", VA = "0x187DE75A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public Matrix4x4[] NLDCILIJIKO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x7DE7430", Offset = "0x7DE5C30", VA = "0x187DE7430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7DE7830", Offset = "0x7DE6030", VA = "0x187DE7830")]
	public void PPAFGGPDGEK(Transform MLKJJEMGGBP, AMKHIMALNFB BHONCPBICBN, OutfitType? CLJIDLBOOFI, bool ANPEAJKJJLC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x7DE7A20", Offset = "0x7DE6220", VA = "0x187DE7A20")]
	private void PPAFGGPDGEK(Transform MLKJJEMGGBP, AMKHIMALNFB BHONCPBICBN, OutfitType? CLJIDLBOOFI, bool ANPEAJKJJLC, Matrix4x4 BJGKIAEKCMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x7DE7280", Offset = "0x7DE5A80", VA = "0x187DE7280")]
	public int COMCHCIIBMI(NOKHKCLAACM MNMCNOJCKAF, bool FKBGKMJKDHO, [Optional] OutfitType? CLJIDLBOOFI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x7DE74A0", Offset = "0x7DE5CA0", VA = "0x187DE74A0")]
	public int HDIDBPDNGBP(AMKHIMALNFB BHONCPBICBN, [Optional] OutfitType? CLJIDLBOOFI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x7DE7740", Offset = "0x7DE5F40", VA = "0x187DE7740")]
	public void OBCFFKMJBOJ(NOKHKCLAACM MNMCNOJCKAF, Matrix4x4 FJOEPJPPDGD, bool FKBGKMJKDHO = false, [Optional] OutfitType? CLJIDLBOOFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x7DE7140", Offset = "0x7DE5940", VA = "0x187DE7140")]
	public Matrix4x4 AMNIBEHIOAJ(NOKHKCLAACM MNMCNOJCKAF, bool FKBGKMJKDHO, [Optional] OutfitType? CLJIDLBOOFI)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x1415340", Offset = "0x1413B40", VA = "0x181415340")]
	public void IFALMOICFEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x7DE7D70", Offset = "0x7DE6570", VA = "0x187DE7D70")]
	public BJHALGJGJNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct NOKHKCLAACM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public readonly string AAOPDBFCMBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public readonly AMKHIMALNFB IKMAIEDBJHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public readonly OutfitType? INPGFODIOEA;

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x7DF6540", Offset = "0x7DF4D40", VA = "0x187DF6540")]
	public NOKHKCLAACM(string AOACOOAOMDJ, AMKHIMALNFB BHONCPBICBN, [Optional] OutfitType? CLJIDLBOOFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x7DF6490", Offset = "0x7DF4C90", VA = "0x187DF6490", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x7DF63D0", Offset = "0x7DF4BD0", VA = "0x187DF63D0")]
	public bool NELGIOIGCOE(NOKHKCLAACM KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x7DF62C0", Offset = "0x7DF4AC0", VA = "0x187DF62C0", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x7DF6360", Offset = "0x7DF4B60", VA = "0x187DF6360", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct GHEOBILGHHP : IEquatable<GHEOBILGHHP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public readonly AMKHIMALNFB IKMAIEDBJHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public readonly OutfitType? PCLOAHJMMAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public readonly int JPBLHMDDPAA;

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x7DF0910", Offset = "0x7DEF110", VA = "0x187DF0910")]
	public GHEOBILGHHP(AMKHIMALNFB BHONCPBICBN, int GNOFFKNGLAE, [Optional] OutfitType? GOJEAFHLJDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x7DF0840", Offset = "0x7DEF040", VA = "0x187DF0840", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x703F320", Offset = "0x703DB20", VA = "0x18703F320")]
	public bool OPBIGNGLHEO(AMKHIMALNFB BHONCPBICBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x7DF07C0", Offset = "0x7DEEFC0", VA = "0x187DF07C0")]
	public bool IAPHOAAIHNM(OutfitType? GOJEAFHLJDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x7DF0630", Offset = "0x7DEEE30", VA = "0x187DF0630", Slot = "4")]
	public bool Equals(GHEOBILGHHP KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x7DF0680", Offset = "0x7DEEE80", VA = "0x187DF0680", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x7DF0770", Offset = "0x7DEEF70", VA = "0x187DF0770", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct AHCKAMGFJMA : IEquatable<AHCKAMGFJMA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public readonly Transform CGDNKENIGHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public readonly bool ILMGOLHLKCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public readonly AMKHIMALNFB PKGACPHKICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public readonly OutfitType? INPGFODIOEA;

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x7DE4AC0", Offset = "0x7DE32C0", VA = "0x187DE4AC0")]
	public AHCKAMGFJMA(Transform MLKJJEMGGBP, bool JAOMHNIGBLI, AMKHIMALNFB OHJCJBCPOAC, [Optional] OutfitType? EKKCEFAOGBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x7DE48B0", Offset = "0x7DE30B0", VA = "0x187DE48B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x7DE4650", Offset = "0x7DE2E50", VA = "0x187DE4650", Slot = "4")]
	public bool Equals(AHCKAMGFJMA KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x7DE4750", Offset = "0x7DE2F50", VA = "0x187DE4750", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x7DE4830", Offset = "0x7DE3030", VA = "0x187DE4830", Slot = "2")]
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
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public const float DEFAULT_Y_POSITION_OFFSET = 0.04f;

		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public const float MAX_HEMISPHERE_POSITION_OFFSET = 0.05f;

		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public const float MAX_HEMISPHERE_ROTATION_OFFSET = 45f;

		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public const float MAX_HEMISPHERE_SCALE = 2f;

		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public const float MIN_HEMISPHERE_SCALE = 0.75f;

		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public const float MAX_HEMISPHERE_RADIUS = 0.25f;

		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public const float MIN_HEMISPHERE_RADIUS = 0.125f;

		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public static GameObject ContainerGO;

		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public static GameObject CurrentHairHemisphereGO;

		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public static Transform CurrentHairHemisphereMeshTransform;

		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public static FitMeshHemisphereUpdater CurrentHairHemisphereUpdater;

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x7DED050", Offset = "0x7DEB850", VA = "0x187DED050")]
		public static void DespawnHairHemisphere()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
		public void UpdateValues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0xA28D30", Offset = "0xA27530", VA = "0x180A28D30")]
		public FitMeshHemisphereUpdater()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface CIMAOIGMEBF
{
	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EPDPODEMOHI(Mesh MLCGFPJFGFN, Matrix4x4 IFLBNIMLIKF, byte[] FFJDDCBJKKI, bool GGIOLMBGPCE = false, AFHHIDGAGFC.KICMKFFCOMP HBEHEOCGCFL = (AFHHIDGAGFC.KICMKFFCOMP)0L, int NJILOLKKMNL = -1, bool AFHOKGPBJBM = false);

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PBPKKKDMPCH(Allocator GFNKGIEEHMD, MIKMGDAKPOO DKKFHFNCCLG, byte JGFKHBHDMJL, [Optional] IList<int> PNFAPCOKEOB, [Optional] IList<int> BFKGBAAKIAG);
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public readonly struct DEAEKBLCCPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public readonly GameObject CBNHNEHIMKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	private readonly AvatarItemMaterial KCFGJHAODAF;

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0xB4C820", Offset = "0xB4B020", VA = "0x180B4C820")]
	public DEAEKBLCCPD(GameObject CBNHNEHIMKE, AvatarItemMaterial KCFGJHAODAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x7DE8320", Offset = "0x7DE6B20", VA = "0x187DE8320")]
	public void LCPEMHJMAGA(Material IPKNLMFNGIO, int OBCBHDBACIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class FJOGPFOHLCH : ODIFDDDFOJE<Task<(GameObject, AvatarItemMaterial)>, DEAEKBLCCPD>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct LGEIPDGOABE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public AsyncTaskMethodBuilder<(GameObject, AvatarItemMaterial)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public Task<GameObject> goTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public Task<AvatarItemMaterial> materialTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		private GameObject <go>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		private TaskAwaiter<GameObject> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private TaskAwaiter<AvatarItemMaterial> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x7DF4A50", Offset = "0x7DF3250", VA = "0x187DF4A50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x7DF4F50", Offset = "0x7DF3750", VA = "0x187DF4F50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	private OBKOLGEFKBC<GameObject> HEKLNOKEBMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	private OBKOLGEFKBC<AvatarItemMaterial> EDLDDDDHBAN;

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x7DEB740", Offset = "0x7DE9F40", VA = "0x187DEB740")]
	private FJOGPFOHLCH(Task<(GameObject, AvatarItemMaterial)> FEGBHCAEMDO, OBKOLGEFKBC<GameObject> BHHJKADNOEG, OBKOLGEFKBC<AvatarItemMaterial> LACIGEEJFEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x7DEB0F0", Offset = "0x7DE98F0", VA = "0x187DEB0F0")]
	public static FJOGPFOHLCH INHDMBAMCNE(AssetReference GBGBFJLJMOA, [Optional] AssetReference KIHDNAHBLCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x7DEB570", Offset = "0x7DE9D70", VA = "0x187DEB570", Slot = "11")]
	protected override DEAEKBLCCPD MAKDFIIPLFD(Task<(GameObject, AvatarItemMaterial)> LLOMGGPJHIF)
	{
		return default(DEAEKBLCCPD);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x7DEB4F0", Offset = "0x7DE9CF0", VA = "0x187DEB4F0", Slot = "12")]
	protected override void JBPHFNLMCHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x7DEB610", Offset = "0x7DE9E10", VA = "0x187DEB610")]
	[AsyncStateMachine(typeof(LGEIPDGOABE))]
	private static Task<(GameObject, AvatarItemMaterial)> OKNIOBDEOPD(Task<GameObject> KEPLLAIIKJG, Task<AvatarItemMaterial> BCACDKLHCLB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class JPKOKHPFLGK
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class IGFHLILPONK : ODIFDDDFOJE<Task<MaterialMapAsset>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private OBKOLGEFKBC<MaterialMapAsset> DAMJGGDGMEF;

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x7DF1130", Offset = "0x7DEF930", VA = "0x187DF1130")]
		public IGFHLILPONK(OBKOLGEFKBC<MaterialMapAsset> DAMJGGDGMEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x7DF0D10", Offset = "0x7DEF510", VA = "0x187DF0D10", Slot = "11")]
		protected override Material[] MAKDFIIPLFD(Task<MaterialMapAsset> FEGBHCAEMDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x7DF0CB0", Offset = "0x7DEF4B0", VA = "0x187DF0CB0", Slot = "12")]
		protected override void JBPHFNLMCHP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class CAPNELIINGD : ODIFDDDFOJE<Task<Material[]>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		private List<OBKOLGEFKBC<Material>> NBGKLLBKMKP;

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x7DE8070", Offset = "0x7DE6870", VA = "0x187DE8070")]
		public CAPNELIINGD(Task<Material[]> FEGBHCAEMDO, List<OBKOLGEFKBC<Material>> NBGKLLBKMKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x7DE8020", Offset = "0x7DE6820", VA = "0x187DE8020", Slot = "11")]
		protected override Material[] MAKDFIIPLFD(Task<Material[]> LLOMGGPJHIF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x7DE7EE0", Offset = "0x7DE66E0", VA = "0x187DE7EE0", Slot = "12")]
		protected override void JBPHFNLMCHP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	private static readonly BMELPJIFPCL GLHOMCPEEHH;

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x7DF45D0", Offset = "0x7DF2DD0", VA = "0x187DF45D0")]
	public static OBKOLGEFKBC<Material[]> AAOJEIBKMFD(AssetReference[] FOFJHICEHGH)
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
		public enum KCFFIELKIDL
		{
			[Cpp2IlInjected.Token(Token = "0x4000349")]
			None,
			[Cpp2IlInjected.Token(Token = "0x400034A")]
			TeamItem,
			[Cpp2IlInjected.Token(Token = "0x400034B")]
			SkinColor,
			[Cpp2IlInjected.Token(Token = "0x400034C")]
			HairColor,
			[Cpp2IlInjected.Token(Token = "0x400034D")]
			BeardColor,
			[Cpp2IlInjected.Token(Token = "0x400034E")]
			UGCShirtColor
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public enum EDDDLPNPAHM
		{
			[Cpp2IlInjected.Token(Token = "0x4000350")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000351")]
			HairTexture,
			[Cpp2IlInjected.Token(Token = "0x4000352")]
			BeardTexture,
			[Cpp2IlInjected.Token(Token = "0x4000353")]
			UGCShirtTexture
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public enum JCGMBILIKIK : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000355")]
			All,
			[Cpp2IlInjected.Token(Token = "0x4000356")]
			LOD0Only,
			[Cpp2IlInjected.Token(Token = "0x4000357")]
			EditorToolAll
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		public struct NHLENANOCCI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000358")]
			public readonly Material CCOKKNAJIML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000359")]
			public readonly KCFFIELKIDL PIAFOAPCIHJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400035A")]
			public readonly EDDDLPNPAHM FCDLDNDIAPH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400035B")]
			public readonly AMKHIMALNFB IKMAIEDBJHE;

			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x7E0E2C0", Offset = "0x7E0CAC0", VA = "0x187E0E2C0")]
			public NHLENANOCCI(Material IPKNLMFNGIO, KCFFIELKIDL LPHCFMKOJHP, EDDDLPNPAHM IGJBFJBCPIK, AMKHIMALNFB BHONCPBICBN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x7E0E0A0", Offset = "0x7E0C8A0", VA = "0x187E0E0A0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x7E0E020", Offset = "0x7E0C820", VA = "0x187E0E020")]
			public bool NELGIOIGCOE(NHLENANOCCI KEKEFPAJGHD)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x7E0DEA0", Offset = "0x7E0C6A0", VA = "0x187E0DEA0", Slot = "0")]
			public override bool Equals(object HPLLAPMNIJF)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x7E0DF80", Offset = "0x7E0C780", VA = "0x187E0DF80", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		protected class KBPMJOEKBJP : IComparable<KBPMJOEKBJP>, IEquatable<KBPMJOEKBJP>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400035C")]
			public int MFNEFBJFABM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400035D")]
			public PlayerAvatarDisplayBase JKBFHJHLJNK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400035E")]
			public IList<MGAECJPIAGF> IKDPJGHCHDK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400035F")]
			public AvatarItemBodyType GOFHGNNIFMC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000360")]
			public KKCINKBPNJO KOAEIHMEKJA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000361")]
			public bool CNAGGHNDLGK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
			[Cpp2IlInjected.Token(Token = "0x4000362")]
			public bool JLNBIEELBPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000363")]
			public int[] NBLMCPIIPBK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000364")]
			public float EKKGHIIFODE;

			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x7E0D1A0", Offset = "0x7E0B9A0", VA = "0x187E0D1A0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x7E0D050", Offset = "0x7E0B850", VA = "0x187E0D050", Slot = "4")]
			public int CompareTo(KBPMJOEKBJP KEKEFPAJGHD)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x7E0D080", Offset = "0x7E0B880", VA = "0x187E0D080", Slot = "5")]
			public bool Equals(KBPMJOEKBJP KEKEFPAJGHD)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
			public KBPMJOEKBJP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		protected abstract class FFBDGBOMFME
		{
			[Cpp2IlInjected.Token(Token = "0x200005B")]
			public class HGHPAOAGEMH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000368")]
				public readonly Mesh DNFDMEMKGHF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000369")]
				public readonly Material[] EPJECMOCKEB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400036A")]
				public readonly Transform[] LILCIKJEJBE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400036B")]
				public readonly Matrix4x4[] DBCAAJJPAAJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400036C")]
				public readonly Transform DLHAOCNLJIP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400036D")]
				public readonly bool GCLDPLBJBEE;

				[Cpp2IlInjected.Token(Token = "0x6000304")]
				[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
				protected HGHPAOAGEMH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000305")]
				[Cpp2IlInjected.Address(RVA = "0x7E09D60", Offset = "0x7E08560", VA = "0x187E09D60")]
				public HGHPAOAGEMH(Mesh MLCGFPJFGFN, Material[] OABNJNEJMJL, bool OKAOFELBFCK, Transform[] HHELPIMKKJE, Transform FIPBADLKMEA, Matrix4x4[] EHDOHGCCLGL)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000306")]
				[Cpp2IlInjected.Address(RVA = "0x7E09CA0", Offset = "0x7E084A0", VA = "0x187E09CA0")]
				private HGHPAOAGEMH(SkinnedMeshRenderer MPBIIJKLLOL, Material[] DJMEFPEBCKL)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000307")]
				[Cpp2IlInjected.Address(RVA = "0x7E0A210", Offset = "0x7E08A10", VA = "0x187E0A210")]
				private HGHPAOAGEMH(MeshRenderer LHFMAOBELNM, Transform FIPBADLKMEA, Material[] DJMEFPEBCKL)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000308")]
				[Cpp2IlInjected.Address(RVA = "0x7E09980", Offset = "0x7E08180", VA = "0x187E09980")]
				public static HGHPAOAGEMH APDICKHMHIE(Renderer FKGIDFBJGGD, Material[] DJMEFPEBCKL)
				{
					return null;
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000365")]
			public readonly AMKHIMALNFB IKMAIEDBJHE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000366")]
			public readonly Transform FGCJGDLOFJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000367")]
			public readonly bool EJLLAOLFMLA;

			[Cpp2IlInjected.Token(Token = "0x1700008E")]
			public virtual bool LAPCGNPLMDI
			{
				[Cpp2IlInjected.Token(Token = "0x60002FD")]
				[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008F")]
			public virtual bool PCIFJLBFJKL
			{
				[Cpp2IlInjected.Token(Token = "0x60002FE")]
				[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000090")]
			public virtual AFHHIDGAGFC.KICMKFFCOMP DBEGBAPKAGC
			{
				[Cpp2IlInjected.Token(Token = "0x60002FF")]
				[Cpp2IlInjected.Address(RVA = "0xA28D50", Offset = "0xA27550", VA = "0x180A28D50", Slot = "6")]
				get
				{
					return default(AFHHIDGAGFC.KICMKFFCOMP);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000091")]
			public bool HLIPLCHOLBI
			{
				[Cpp2IlInjected.Token(Token = "0x6000300")]
				[Cpp2IlInjected.Address(RVA = "0x7E083E0", Offset = "0x7E06BE0", VA = "0x187E083E0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x7E083F0", Offset = "0x7E06BF0", VA = "0x187E083F0")]
			protected FFBDGBOMFME(AMKHIMALNFB BHONCPBICBN, Transform ECOHEKIKPPL, bool JBNMOKANJGC = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract FKGMEHDMFDF DEDHPBLDALP(List<CJHHFDGDDDE> AGFGEFFAFDM, List<CJHHFDGDDDE> CNJNIOPOLCH);

			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract HGHPAOAGEMH BLHKKBOPOEG(int MBAOJAPNLMO, PlayerHandBones CPFAJOGMGAL);
		}

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		protected class PPBLDGBKLGG : FFBDGBOMFME
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400036E")]
			protected readonly BodyPartLODs GKFDFFOPGDK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400036F")]
			protected readonly Material[] APMCFALMMEI;

			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0x7E0F0B0", Offset = "0x7E0D8B0", VA = "0x187E0F0B0")]
			public PPBLDGBKLGG(AMKHIMALNFB BHONCPBICBN, BodyPartLODs HLKEHKEOELL, Material COOLNDBIDBL, [Optional] Transform ECOHEKIKPPL, bool JBNMOKANJGC = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0x7E0EFB0", Offset = "0x7E0D7B0", VA = "0x187E0EFB0", Slot = "7")]
			public override FKGMEHDMFDF DEDHPBLDALP(List<CJHHFDGDDDE> AGFGEFFAFDM, List<CJHHFDGDDDE> CNJNIOPOLCH)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0x7E0EDF0", Offset = "0x7E0D5F0", VA = "0x187E0EDF0", Slot = "8")]
			public override HGHPAOAGEMH BLHKKBOPOEG(int MBAOJAPNLMO, PlayerHandBones CPFAJOGMGAL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0x7E0F040", Offset = "0x7E0D840", VA = "0x187E0F040", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005D")]
		protected class MNKMNGNDEKA : FFBDGBOMFME
		{
			[Cpp2IlInjected.Token(Token = "0x17000092")]
			public override bool LAPCGNPLMDI
			{
				[Cpp2IlInjected.Token(Token = "0x600030D")]
				[Cpp2IlInjected.Address(RVA = "0xA43700", Offset = "0xA41F00", VA = "0x180A43700", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000093")]
			public override bool PCIFJLBFJKL
			{
				[Cpp2IlInjected.Token(Token = "0x600030E")]
				[Cpp2IlInjected.Address(RVA = "0x7E0DD70", Offset = "0x7E0C570", VA = "0x187E0DD70", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000094")]
			public OANMLALNFNA KMMGJGLCMAD
			{
				[Cpp2IlInjected.Token(Token = "0x600030F")]
				[Cpp2IlInjected.Address(RVA = "0xA2D3B0", Offset = "0xA2BBB0", VA = "0x180A2D3B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000310")]
				[Cpp2IlInjected.Address(RVA = "0xA2EE70", Offset = "0xA2D670", VA = "0x180A2EE70")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000311")]
			[Cpp2IlInjected.Address(RVA = "0x7E0DE30", Offset = "0x7E0C630", VA = "0x187E0DE30")]
			public MNKMNGNDEKA(AMKHIMALNFB BHONCPBICBN, Transform ECOHEKIKPPL, OANMLALNFNA JCNEIFHNADD, bool JBNMOKANJGC = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000312")]
			[Cpp2IlInjected.Address(RVA = "0x7E0DCE0", Offset = "0x7E0C4E0", VA = "0x187E0DCE0", Slot = "7")]
			public override FKGMEHDMFDF DEDHPBLDALP(List<CJHHFDGDDDE> AGFGEFFAFDM, List<CJHHFDGDDDE> CNJNIOPOLCH)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0xA28D50", Offset = "0xA27550", VA = "0x180A28D50", Slot = "8")]
			public override HGHPAOAGEMH BLHKKBOPOEG(int MBAOJAPNLMO, PlayerHandBones CPFAJOGMGAL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x7E0DDC0", Offset = "0x7E0C5C0", VA = "0x187E0DDC0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005E")]
		public class GACELNMGIPE
		{
			[Cpp2IlInjected.Token(Token = "0x200005F")]
			public enum LAHLGAJAOFE
			{
				[Cpp2IlInjected.Token(Token = "0x4000381")]
				PLAYER_PUPPET,
				[Cpp2IlInjected.Token(Token = "0x4000382")]
				PLAYER_DISPLAY_POSER,
				[Cpp2IlInjected.Token(Token = "0x4000383")]
				PLAYER_HAND,
				[Cpp2IlInjected.Token(Token = "0x4000384")]
				STNMONSTERCOSTUME_OPTION_HIDE_EXCEPT_UI,
				[Cpp2IlInjected.Token(Token = "0x4000385")]
				PLAYER_HAND_POINTING,
				[Cpp2IlInjected.Token(Token = "0x4000386")]
				STNMONSTERCOSTUME_OPTION_ALWAYS_HIDE,
				[Cpp2IlInjected.Token(Token = "0x4000387")]
				EDITOR
			}

			[Cpp2IlInjected.Token(Token = "0x4000371")]
			public static readonly int KKMNAEACOBC;

			[Cpp2IlInjected.Token(Token = "0x4000372")]
			public static readonly int HAKDFHPBBIO;

			[Cpp2IlInjected.Token(Token = "0x4000373")]
			public static readonly int DCJOGBACFCF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000374")]
			protected readonly JMNLGEOMELD FJLCMJLPIEE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000375")]
			protected readonly DIGFFPMCPNM KIFOKLMNKHG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000376")]
			protected readonly Animator IGKGMPGEFDA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000377")]
			protected readonly Transform FHNKDCLIAIB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000378")]
			public Vector3 ANIJHIECKCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000379")]
			protected readonly Transform IBNFDAGGPED;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400037A")]
			public Vector3 KEBPKCDOBFM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x400037B")]
			protected bool OOHBAMJNAJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400037C")]
			protected KKBENOBLINI FMFGHCKPFNB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400037D")]
			protected bool FLMBGCJMJOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x400037E")]
			protected float IPNIGDHAIGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400037F")]
			protected IJCFLIBNNJN<BHFEFPLJLMD> PHEBHFGOCFE;

			[Cpp2IlInjected.Token(Token = "0x17000095")]
			public KKBENOBLINI LCGHCPEAJOJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000315")]
				[Cpp2IlInjected.Address(RVA = "0xA27530", Offset = "0xA25D30", VA = "0x180A27530")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000316")]
				[Cpp2IlInjected.Address(RVA = "0xA27500", Offset = "0xA25D00", VA = "0x180A27500")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000096")]
			public bool EOMCEBOEOHF
			{
				[Cpp2IlInjected.Token(Token = "0x6000317")]
				[Cpp2IlInjected.Address(RVA = "0xC8E670", Offset = "0xC8CE70", VA = "0x180C8E670")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000318")]
				[Cpp2IlInjected.Address(RVA = "0x7E08880", Offset = "0x7E07080", VA = "0x187E08880")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000097")]
			public bool MEPBDJILLOI
			{
				[Cpp2IlInjected.Token(Token = "0x6000319")]
				[Cpp2IlInjected.Address(RVA = "0xA2D4B0", Offset = "0xA2BCB0", VA = "0x180A2D4B0")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600031A")]
				[Cpp2IlInjected.Address(RVA = "0x7E087B0", Offset = "0x7E06FB0", VA = "0x187E087B0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000098")]
			public float IDDDNGAMIIP
			{
				[Cpp2IlInjected.Token(Token = "0x600031B")]
				[Cpp2IlInjected.Address(RVA = "0xD13080", Offset = "0xD11880", VA = "0x180D13080")]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x600031C")]
				[Cpp2IlInjected.Address(RVA = "0x7E08F90", Offset = "0x7E07790", VA = "0x187E08F90")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000099")]
			public BHFEFPLJLMD NGPDJAJIEGM
			{
				[Cpp2IlInjected.Token(Token = "0x600031D")]
				[Cpp2IlInjected.Address(RVA = "0x7E090D0", Offset = "0x7E078D0", VA = "0x187E090D0")]
				get
				{
					return default(BHFEFPLJLMD);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x7E08D30", Offset = "0x7E07530", VA = "0x187E08D30")]
			public bool MFOPLKADLLB(BHFEFPLJLMD MDEIKAOMPKJ, object KAJENDFCCBJ, LAHLGAJAOFE IAOOMFIBPGC)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x7E08E40", Offset = "0x7E07640", VA = "0x187E08E40")]
			public bool MLGDBNNNGNI(object KAJENDFCCBJ)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x7E098C0", Offset = "0x7E080C0", VA = "0x187E098C0")]
			protected GACELNMGIPE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x7E092D0", Offset = "0x7E07AD0", VA = "0x187E092D0")]
			public GACELNMGIPE(JMNLGEOMELD FJLCMJLPIEE, KKBENOBLINI OJMHCHJKBIH, Animator IGKGMPGEFDA, Transform FHNKDCLIAIB, Transform IBNFDAGGPED, Vector3 ANIJHIECKCB, Vector3 KEBPKCDOBFM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x7E08AD0", Offset = "0x7E072D0", VA = "0x187E08AD0")]
			private void HCIKDOIKGGH(ushort APJEJLPDJEJ, ushort FHABDKGCHPO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x7E08C40", Offset = "0x7E07440", VA = "0x187E08C40")]
			protected void JJBCDHJECLJ(ushort APJEJLPDJEJ, ushort FHABDKGCHPO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x7E08B80", Offset = "0x7E07380", VA = "0x187E08B80")]
			protected void IAPFJHMNHNM(ushort APJEJLPDJEJ, ushort FHABDKGCHPO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x7E09110", Offset = "0x7E07910", VA = "0x187E09110")]
			protected void OBIECNAEFDG(ushort APJEJLPDJEJ, ushort FHABDKGCHPO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x7E086A0", Offset = "0x7E06EA0", VA = "0x187E086A0")]
			protected void CHNLGJIDEBN(ushort APJEJLPDJEJ, ushort FHABDKGCHPO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x7E08A70", Offset = "0x7E07270", VA = "0x187E08A70")]
			protected void EMKAPJGBEFP(ushort APJEJLPDJEJ, ushort FHABDKGCHPO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x7E08F40", Offset = "0x7E07740", VA = "0x187E08F40")]
			protected void NBDGPHHMDBF(ushort APJEJLPDJEJ, ushort FHABDKGCHPO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x7E08650", Offset = "0x7E06E50", VA = "0x187E08650")]
			protected void CBLKNPCAIKE(ushort APJEJLPDJEJ, ushort FHABDKGCHPO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x7E08950", Offset = "0x7E07150", VA = "0x187E08950")]
			protected void EAKCMDDEGCD(ushort APJEJLPDJEJ, ushort FHABDKGCHPO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000060")]
		public class IBJCHDNGGMK : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x4000388")]
			public const int DOJBAGAPJOL = 16;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000389")]
			protected MaterialPropertyBlock LPKKIAOKJKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400038A")]
			public Color? JBFHCJDLLPG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400038B")]
			public Color? DEMIJNNJIOO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400038C")]
			public Color? HPMGIMNMKGD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x400038D")]
			public Color OMFPLJOPJAN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x400038E")]
			public Color ADNAOHDFMDF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			public Color DPKFCHEAMNC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000390")]
			public Texture2D OCEFAEBLJGC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000391")]
			public Texture2D CNICDPNHPPP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x4000392")]
			protected Dictionary<NHLENANOCCI, int> CMAFOJOGEIH;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x4000393")]
			protected KCFFIELKIDL[] BFEGIGBBNND;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x4000394")]
			public Vector4[] PPKPIMCCHPG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x4000395")]
			public Vector4[] PMMBBEOGJJC;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x4000396")]
			public Vector4[] EPMDMNMCNMD;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000397")]
			public Vector4[] JHOKEBGOIJM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x4000398")]
			public Vector4[] EDGEAHFOCJA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000399")]
			public Vector4[] JIFCDIHBNKL;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400039A")]
			protected List<Texture2D> APHBGJFLBGE;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400039B")]
			protected Vector4[] LDLFPLJHIGB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			protected List<Texture2D> ENHDFLKAFNO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
			[Cpp2IlInjected.Token(Token = "0x400039D")]
			protected float[] EMKJNGBAKML;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
			[Cpp2IlInjected.Token(Token = "0x400039E")]
			protected Vector4[] MACEDOEGKFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x400039F")]
			protected float[] JJBDEJMJIEE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
			[Cpp2IlInjected.Token(Token = "0x40003A0")]
			public float[] IFHDPIEGILB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
			[Cpp2IlInjected.Token(Token = "0x40003A1")]
			protected List<Texture2D> JEKAHKDLECO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
			[Cpp2IlInjected.Token(Token = "0x40003A2")]
			protected float[] DCLOEHJDJDC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
			[Cpp2IlInjected.Token(Token = "0x40003A3")]
			protected List<Texture2D> LAGGJFKOKAJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
			[Cpp2IlInjected.Token(Token = "0x40003A4")]
			protected Vector4[] GFBGMJIANAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
			[Cpp2IlInjected.Token(Token = "0x40003A5")]
			protected float[] HGKIPPCNJOI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
			[Cpp2IlInjected.Token(Token = "0x40003A6")]
			protected Vector4[] CHJECCJPLDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x40003A7")]
			public float[] HEFPBFJKBPB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
			[Cpp2IlInjected.Token(Token = "0x40003A8")]
			public Texture2DArray POMBIKODELJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x40003A9")]
			public Texture2DArray DFBFBMHODDI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
			[Cpp2IlInjected.Token(Token = "0x40003AA")]
			public Texture2DArray HALDNHDKCHM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
			[Cpp2IlInjected.Token(Token = "0x40003AB")]
			public Texture2DArray PINNDCMIHPP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x40003AC")]
			protected bool BMBAAJMHMBP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
			[Cpp2IlInjected.Token(Token = "0x40003AD")]
			protected int DADNDBFBLIF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
			[Cpp2IlInjected.Token(Token = "0x40003AE")]
			protected Vector2? CEPPIHMBOKB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
			[Cpp2IlInjected.Token(Token = "0x40003AF")]
			protected TextureFormat BIKJIADJPLM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
			[Cpp2IlInjected.Token(Token = "0x40003B0")]
			protected Vector2? GKLHAKCBHBN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
			[Cpp2IlInjected.Token(Token = "0x40003B1")]
			protected TextureFormat MCCMPGJBNKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
			[Cpp2IlInjected.Token(Token = "0x40003B2")]
			protected Vector2? ABNEJJFJKNB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
			[Cpp2IlInjected.Token(Token = "0x40003B3")]
			protected TextureFormat PDKJJODJHJI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
			[Cpp2IlInjected.Token(Token = "0x40003B4")]
			protected Vector2? GMANOHMOOAH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
			[Cpp2IlInjected.Token(Token = "0x40003B5")]
			protected TextureFormat MCFOFDOAKKH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
			[Cpp2IlInjected.Token(Token = "0x40003B6")]
			protected bool DMJNBPLABAL;

			[Cpp2IlInjected.Token(Token = "0x40003B7")]
			protected static int KJJCDFPGHJO;

			[Cpp2IlInjected.Token(Token = "0x40003B8")]
			protected static int BFENKEBBCNL;

			[Cpp2IlInjected.Token(Token = "0x40003B9")]
			protected static int PENLAIJNIOG;

			[Cpp2IlInjected.Token(Token = "0x40003BA")]
			protected static int KGLMDMJAAHH;

			[Cpp2IlInjected.Token(Token = "0x40003BB")]
			protected static int ILFCHJALGLP;

			[Cpp2IlInjected.Token(Token = "0x40003BC")]
			protected static int DLGDFIGDOFC;

			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			protected static int MGDACJIEIDJ;

			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			protected static int AALIHNAMFPN;

			[Cpp2IlInjected.Token(Token = "0x40003BF")]
			protected static int IJDDLMKMEGD;

			[Cpp2IlInjected.Token(Token = "0x40003C0")]
			protected static int KIDLFJHFKMJ;

			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			protected static int GKNPHBBNKNJ;

			[Cpp2IlInjected.Token(Token = "0x40003C2")]
			protected static int MCCAJMMIBJL;

			[Cpp2IlInjected.Token(Token = "0x40003C3")]
			protected static int PLKLCCDLBGO;

			[Cpp2IlInjected.Token(Token = "0x40003C4")]
			protected static int NKJLGGIMJBI;

			[Cpp2IlInjected.Token(Token = "0x40003C5")]
			protected static int CIFPKLHJEBH;

			[Cpp2IlInjected.Token(Token = "0x40003C6")]
			protected static int BKBBGCDCCCN;

			[Cpp2IlInjected.Token(Token = "0x40003C7")]
			protected static int LJOAIFDGDKM;

			[Cpp2IlInjected.Token(Token = "0x40003C8")]
			protected static int GNPNHLMKLML;

			[Cpp2IlInjected.Token(Token = "0x40003C9")]
			protected static int AMGAOLHBBFG;

			[Cpp2IlInjected.Token(Token = "0x40003CA")]
			protected static int PDMLDJBABAN;

			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x7E0C7E0", Offset = "0x7E0AFE0", VA = "0x187E0C7E0")]
			protected IBJCHDNGGMK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x7E0CCA0", Offset = "0x7E0B4A0", VA = "0x187E0CCA0")]
			public IBJCHDNGGMK(Color BCPDIPOOKFD, Color PIBKIFNBJNE, Color COFJIPFAILP, Color? ECNMEJLJFLF, Color? GCGAFOOEEEP, Color? NGKONEFHJON)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x7E0AB30", Offset = "0x7E09330", VA = "0x187E0AB30")]
			public int JGNAFNABOML(Material OJHLMEAJFPP, KCFFIELKIDL LPHCFMKOJHP, EDDDLPNPAHM IGJBFJBCPIK, AMKHIMALNFB BHONCPBICBN)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x7E0AC20", Offset = "0x7E09420", VA = "0x187E0AC20")]
			public int JGNAFNABOML(NHLENANOCCI MNMCNOJCKAF)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x7E0B7A0", Offset = "0x7E09FA0", VA = "0x187E0B7A0")]
			public int KIAJPHBFDIP(Material OJHLMEAJFPP, Color GHACELNNKIA, Color JGCCIMLMHPP, Color INBBHDHGJBD, Color DKEMBKEAHOB, Color IJMCOMPCOHA, Texture2D DJAJJKKDFFA, Vector4 NKLLAOJGLMC, Texture2D AJDMMHPPICA, Vector4 OCBOGJAPIGK, float NBGMNFKGKFA, float JPDHAPFNOKB, Texture2D CIPMEDHIKGD, Vector4 ELEAGFCODOH, float GBGBAGBOOHL, Texture2D CDONCBKADCE, float LCKKIEMPJJN, Color BNDLCFCECGA, Vector4 DMDIDNOCNOI, KCFFIELKIDL LPHCFMKOJHP, EDDDLPNPAHM IGJBFJBCPIK, AMKHIMALNFB BHONCPBICBN)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x7E0A300", Offset = "0x7E08B00", VA = "0x187E0A300")]
			protected void AKJADEMBIFG([Out] Texture2DArray CHNKHPLAOJG, [Out] Texture2DArray ADJCIBNNNKH, [Out] Texture2DArray ACHKGAAODGM, [Out] Texture2DArray CLGLIFOOEMK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x7E0A8D0", Offset = "0x7E090D0", VA = "0x187E0A8D0")]
			public void IFANLJADGBF(PlayerAvatarDisplayBase HLKMEHLOBIC, Renderer FKGIDFBJGGD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(RVA = "0x7E0ACB0", Offset = "0x7E094B0", VA = "0x187E0ACB0")]
			protected void KIAHFEPCDJG(PlayerAvatarDisplayBase HLKMEHLOBIC, Renderer FKGIDFBJGGD, int MFECNKLMLKG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x7E0A4C0", Offset = "0x7E08CC0", VA = "0x187E0A4C0")]
			private Color CGHBKLMEKKI(Color GBEDHIJOGGF, KCFFIELKIDL HGNBOIAPBOF)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0x7E0A6F0", Offset = "0x7E08EF0", VA = "0x187E0A6F0")]
			private Color FFFEHKJKAPD(Color LHEACIDNPKK, KCFFIELKIDL HGNBOIAPBOF)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x6000336")]
			[Cpp2IlInjected.Address(RVA = "0x7E0A840", Offset = "0x7E09040", VA = "0x187E0A840")]
			protected void FJLDDJMNOOP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x7E0A6B0", Offset = "0x7E08EB0", VA = "0x187E0A6B0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000061")]
		public struct PlayerHandBones
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003CB")]
			public Transform[] LeftHandBones;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003CC")]
			public Transform LeftHandRoot;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003CD")]
			public Transform[] RightHandBones;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003CE")]
			public Transform RightHandRoot;

			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x7E157C0", Offset = "0x7E13FC0", VA = "0x187E157C0")]
			public void MIJBPIMHOBG(AMKHIMALNFB BHONCPBICBN, [Out] Transform MJAMEBJFAIN, [Out] Transform[] HHELPIMKKJE)
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		protected struct BodyPartLODs
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003CF")]
			public Mesh[] LODs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003D0")]
			public bool UseHandBones;
		}

		[Cpp2IlInjected.Token(Token = "0x2000064")]
		[CompilerGenerated]
		private sealed class KPAOJJKIFBE : IEnumerable<SkinnedMeshRenderer>, IEnumerable, IEnumerator<SkinnedMeshRenderer>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003D8")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003D9")]
			private SkinnedMeshRenderer <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003DA")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003DB")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003DC")]
			private SkinnedMeshRenderer[] <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003DD")]
			private int <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x1700009A")]
			SkinnedMeshRenderer IEnumerator<SkinnedMeshRenderer>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000345")]
				[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000347")]
				[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0xF10EA0", Offset = "0xF0F6A0", VA = "0x180F10EA0")]
			[DebuggerHidden]
			public KPAOJJKIFBE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x7E0D370", Offset = "0x7E0BB70", VA = "0x187E0D370", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0x7E0D5F0", Offset = "0x7E0BDF0", VA = "0x187E0D5F0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(RVA = "0x7E0D540", Offset = "0x7E0BD40", VA = "0x187E0D540", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<SkinnedMeshRenderer> IEnumerable<SkinnedMeshRenderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x7E0D540", Offset = "0x7E0BD40", VA = "0x187E0D540", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000065")]
		[CompilerGenerated]
		private sealed class ICLANNNJADM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003DE")]
			public PlayerAvatarDisplayBase display;

			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
			public ICLANNNJADM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x7E0CD30", Offset = "0x7E0B530", VA = "0x187E0CD30")]
			internal bool NFOLPIIHONO()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class OEEGCOGLCBI : IEnumerator<ENGFNCJEKHI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003DF")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003E0")]
			private ENGFNCJEKHI <>2__current;

			[Cpp2IlInjected.Token(Token = "0x1700009C")]
			private ENGFNCJEKHI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600034F")]
				[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009D")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000351")]
				[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0xA2B740", Offset = "0xA29F40", VA = "0x180A2B740")]
			[DebuggerHidden]
			public OEEGCOGLCBI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x7E0E5E0", Offset = "0x7E0CDE0", VA = "0x187E0E5E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0x7E0E920", Offset = "0x7E0D120", VA = "0x187E0E920", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000067")]
		[CompilerGenerated]
		private struct DFDCPJHANAN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003E1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003E2")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003E3")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003E4")]
			public BLGOLEELJGA avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003E5")]
			private bool <forceRebuild>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003E6")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x7E07DE0", Offset = "0x7E065E0", VA = "0x187E07DE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x7E08180", Offset = "0x7E06980", VA = "0x187E08180", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000068")]
		[CompilerGenerated]
		private sealed class HCAOMINIGPC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003E7")]
			public string overrideIdentifier;

			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
			public HCAOMINIGPC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0x7E09950", Offset = "0x7E08150", VA = "0x187E09950")]
			internal bool AJNPCPGHBEF(MGAECJPIAGF selection)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000069")]
		[CompilerGenerated]
		private sealed class DBMAPICCNJG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003E8")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003E9")]
			public AvatarItemBodyType avatarItemBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003EA")]
			public Func<BFIFKPBFBML<Dictionary<string, OBKOLGEFKBC<Texture2D>>>> <>9__2;

			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
			public DBMAPICCNJG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0x7E07900", Offset = "0x7E06100", VA = "0x187E07900")]
			internal (JLFAJMGNMDK, BFIFKPBFBML<Dictionary<string, OBKOLGEFKBC<Texture2D>>>) PKJEFMLCAIM(Dictionary<string, OPEJGCCNPHE> avatarItems)
			{
				return default((JLFAJMGNMDK, BFIFKPBFBML<Dictionary<string, OBKOLGEFKBC<Texture2D>>>));
			}

			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x7E07890", Offset = "0x7E06090", VA = "0x187E07890")]
			internal BFIFKPBFBML<Dictionary<string, OBKOLGEFKBC<Texture2D>>> KBOMFKNJJDF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x7E07850", Offset = "0x7E06050", VA = "0x187E07850")]
			internal void BDFDPPHOHDF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006A")]
		[CompilerGenerated]
		private sealed class NLCDBJHMHOA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003EB")]
			public Transform transformToCheck;

			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
			public NLCDBJHMHOA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x7E0E530", Offset = "0x7E0CD30", VA = "0x187E0E530")]
			internal bool DMJCKODOBBF(SkinnedMeshRenderer x)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006B")]
		[CompilerGenerated]
		private struct NKFFKKHMMGF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003EC")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003ED")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003EE")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003EF")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x7E0E300", Offset = "0x7E0CB00", VA = "0x187E0E300", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x7E0E4D0", Offset = "0x7E0CCD0", VA = "0x187E0E4D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		protected static readonly int JPJDMGFLHBM;

		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		protected static readonly int GJOMKFEPEON;

		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		protected static readonly int BIOGGHALFKE;

		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		protected static readonly int EMPIMMNENAA;

		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		protected static readonly int GKKAPEBCPOG;

		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		protected static readonly int FPDNNIHDNMK;

		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		protected static readonly int[] PPOOHKGAOCE;

		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		protected static readonly int[] LGEIDDDLHNI;

		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		protected static readonly int[] DJPIBKIFNDP;

		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		protected static readonly int[] GKHBENFHLAI;

		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		protected static readonly int[] NOEEBEFBPLK;

		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		protected static readonly int[] KOCNKJHGAEN;

		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		protected static List<PlayerAvatarDisplayBase> NGJELDPNKNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		protected ODBDPJODIME HILOKOLPKME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		protected bool FJOMIJFACGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		protected bool OHILAFABJDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		[SerializeField]
		public AvatarBodyShapeVault BodyShapeVault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		[SerializeField]
		public AvatarFaceShapeVault FaceShapeVault;

		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		protected static readonly int[] JAPLAJBCOFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		[SerializeField]
		protected Material bodyPartMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		private MNNECKEBGGO GJACEFBNHDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		protected Dictionary<NHLENANOCCI, Material> HOFNFLMODPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		protected Dictionary<NHLENANOCCI, Material> IGLPFLOMMKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		[SerializeField]
		protected bool ignorePlayerMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		[SerializeField]
		protected Transform trackingSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		[SerializeField]
		protected BodyPartLODs Head;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		[SerializeField]
		protected BodyPartLODs Ear;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		[SerializeField]
		protected BodyPartLODs Torso;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		[SerializeField]
		protected BodyPartLODs Hand;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		[SerializeField]
		protected BodyPartLODs HandPointing;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		[SerializeField]
		public PlayerHandBones HandBones;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		[SerializeField]
		public Transform remoteMeshBase;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public readonly SkinnedMeshRenderer[] CurrentDefaultSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public readonly SkinnedMeshRenderer[] NextDefaultSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public readonly SkinnedMeshRenderer[] CurrentVisibleInFirstPersonSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public readonly SkinnedMeshRenderer[] NextVisibleInFirstPersonSkinnedMeshRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		[SerializeField]
		public Transform firstPersonMeshBase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		[SerializeField]
		protected Shader uberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		[SerializeField]
		protected Shader agAvatarShader;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		protected Material PAKEKNNIIIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		protected MEKGIBHCPGB BHECNDKNHDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		private KKBENOBLINI BNKBIKALFEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		private KKBENOBLINI KAJBMDAPDBG;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		protected Material IMHHEHOEGPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		[SerializeField]
		protected Transform headPropAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		[SerializeField]
		protected Transform hatAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		[SerializeField]
		public Transform hemisphereBase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		protected FitMeshHemisphere JGANABKABFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		protected bool DKBJGKJAPHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		protected CPOALKJLKJO OMPBAAGKIFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		protected bool DIHOONKAFHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		protected AnchorParamsRestrictions DDMPCJHKHKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		protected bool HJLBDCLGHIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		protected Transform PJBKGJIMGHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		protected bool BPHIAILPANK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B9")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		protected bool LPOOHLEKBKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		protected Vector3 ECOKLGKKGBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		protected Quaternion OFJDFJDJAPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		protected Vector2 NODCPNBPECE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		protected FitMeshHemisphere PONFJNPFOLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		[SerializeField]
		[GKBMICLOBGF(CGAFHOMJNOP.SelfAndChildren, false, false, false)]
		protected PlayerFacialAnimatorBase facialAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		[SerializeField]
		protected Transform torsoPropAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		[SerializeField]
		protected Transform torsoRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		[SerializeField]
		protected Transform headRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		[SerializeField]
		protected Transform leftHandRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		[SerializeField]
		protected Transform leftHandDefaultScaleRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		[SerializeField]
		protected Transform rightHandRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		[SerializeField]
		protected Transform rightHandDefaultScaleRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		[SerializeField]
		protected Animator leftHandAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		[SerializeField]
		protected Animator rightHandAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		[SerializeField]
		protected Transform leftHandPointingRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		[SerializeField]
		protected Transform rightHandPointingRoot;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		protected Collider[] CPJHGONAILD;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		protected Collider[] PONFICPCCAC;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		protected GACELNMGIPE[] JMODMBOFFHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		[SerializeField]
		protected Mesh faceMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public Dictionary<Renderer, IBJCHDNGGMK> currentPropertyBlocks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		protected Dictionary<Renderer, IBJCHDNGGMK> JGBBHMPHHMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		protected FKOMKPCCFKE LDGCFHDNDDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		protected JLFAJMGNMDK BDFNEMJGPCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public KEIJGPDJMGG DistanceBand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28C")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		protected int GMFBOOPEKEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		protected (bool isLodForced, int forcedLOD) CFFNMHCANPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		protected IJCFLIBNNJN<DIGFFPMCPNM> PHEBHFGOCFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		protected bool GFEMNCLFKLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		protected Dictionary<MGAECJPIAGF, List<NHLENANOCCI>> NBJGHKPCBNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		protected Dictionary<MGAECJPIAGF, List<NHLENANOCCI>> NKPHFKNOFGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		protected readonly Dictionary<string, OBKOLGEFKBC<Texture2D>> HMAGFJBMDFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		protected readonly Dictionary<string, OBKOLGEFKBC<Texture2D>> MHHMEOKMGHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		protected bool EOIPEOHNPHC;

		[Cpp2IlInjected.Token(Token = "0x4000321")]
		protected static int ENAIFPHBCHB;

		[Cpp2IlInjected.Token(Token = "0x4000322")]
		protected static List<KBPMJOEKBJP> FFLPJBKJNIG;

		[Cpp2IlInjected.Token(Token = "0x4000323")]
		protected static List<KBPMJOEKBJP> GPDLDBDNJHB;

		[Cpp2IlInjected.Token(Token = "0x4000324")]
		protected static NGLIALCAJHK BOGIBGMMGEB;

		[Cpp2IlInjected.Token(Token = "0x4000325")]
		protected static Func<List<KBPMJOEKBJP>, KBPMJOEKBJP> OFBFKNAEDLG;

		[Cpp2IlInjected.Token(Token = "0x4000326")]
		protected static bool LAAAFHPBCHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		protected Color? AJCPHKMIGLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2EC")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		protected bool IOMDIAAJBDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		protected Color NALANAMOJNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		protected Color FLHKLOIDHLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		protected Color OMAKNPGKLFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		protected AvatarHairPattern APCGAEGKKNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		protected OANMLALNFNA NNJILKDFELI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		protected Color BCNKEDELCNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		protected Color NLEEMJBKNAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		protected AvatarHairPattern BDHAJKMJJAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		protected OANMLALNFNA IKLMCJDAMAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		protected OANMLALNFNA KOKEJPOABOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		protected Color ALAABIEFOLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		private AdditionalFeetData NAIDHKJOBJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		protected MGAECJPIAGF? EOIIGPHGODI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		protected Texture MFJCDKJNBDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		protected Color KPLPGOFEFDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		protected readonly IList<MGAECJPIAGF> AFMAHJNILPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		protected readonly IList<MGAECJPIAGF> KJLHDJIINBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		private AvatarItemBodyType EENMOPGHDKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C8")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		[SerializeField]
		protected AvatarFaceShape _currentFaceShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D0")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		[SerializeField]
		protected AvatarBodyShape _currentBodyShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		[SerializeField]
		protected HJAEKHPBLDG _currentNoseType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3DC")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		[SerializeField]
		protected bool _hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3DD")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		protected JCGMBILIKIK KJGMMKFNOAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E0")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		protected int[] PIKGECANBFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E8")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		protected bool FCAPEMMNFDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F0")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		protected int[] IOILEPOOLFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F8")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		protected bool BEGFKOMCMPP;

		[Cpp2IlInjected.Token(Token = "0x4000344")]
		private static readonly AFHHIDGAGFC.KICMKFFCOMP PELIDCEPAFH;

		[Cpp2IlInjected.Token(Token = "0x4000345")]
		private static readonly AFHHIDGAGFC.KICMKFFCOMP IKPFOFEOMFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F9")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		protected bool KDNJKFKBFDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x400")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		protected FOIPDPBDMCD LGCGMHDCIJM;

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public string JBLIABKICIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0xA2D4A0", Offset = "0xA2BCA0", VA = "0x180A2D4A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0xA2D540", Offset = "0xA2BD40", VA = "0x180A2D540")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public bool LJOJLPNGJLD
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0xC84660", Offset = "0xC82E60", VA = "0x180C84660")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0xC839B0", Offset = "0xC821B0", VA = "0x180C839B0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public virtual bool INDOJKHMPLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool BLFMAIFCJLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x7E05650", Offset = "0x7E03E50", VA = "0x187E05650")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public virtual bool GFCNIMJLGOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public virtual bool CILHAPFLBBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0xA43700", Offset = "0xA41F00", VA = "0x180A43700", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public virtual bool LNFIOIKLCNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public MEKGIBHCPGB GAECDNFMMLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0xB33C60", Offset = "0xB32460", VA = "0x180B33C60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x7E05E20", Offset = "0x7E04620", VA = "0x187E05E20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public KKBENOBLINI PGONDBIHNIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0xB46150", Offset = "0xB44950", VA = "0x180B46150")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x7E06220", Offset = "0x7E04A20", VA = "0x187E06220")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public KKBENOBLINI CDCPNLHMHDI
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0xB2EAA0", Offset = "0xB2D2A0", VA = "0x180B2EAA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x7E064F0", Offset = "0x7E04CF0", VA = "0x187E064F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		protected Material BGDABDFBPCK
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x7DFE050", Offset = "0x7DFC850", VA = "0x187DFE050")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		protected Material NCIPCEABMPL
		{
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x7DFFCF0", Offset = "0x7DFE4F0", VA = "0x187DFFCF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public bool AFKGCJKAHAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0xB2ECD0", Offset = "0xB2D4D0", VA = "0x180B2ECD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public PlayerFacialAnimatorBase GHDNCJIOMMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0xAB0BC0", Offset = "0xAAF3C0", VA = "0x180AB0BC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public GACELNMGIPE[] GANEKMMJLIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x7E051E0", Offset = "0x7E039E0", VA = "0x187E051E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public GACELNMGIPE KILDEOMFKNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x7E05850", Offset = "0x7E04050", VA = "0x187E05850")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public GACELNMGIPE JEFMJLEBMEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x7E05880", Offset = "0x7E04080", VA = "0x187E05880")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public Mesh IDOINHHLHAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0xB47130", Offset = "0xB45930", VA = "0x180B47130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		protected FKOMKPCCFKE LNFNLDGLLNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x7DF7B70", Offset = "0x7DF6370", VA = "0x187DF7B70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		protected JLFAJMGNMDK FMKAHHPPALP
		{
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0xB46E50", Offset = "0xB45650", VA = "0x180B46E50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x7DFAA90", Offset = "0x7DF9290", VA = "0x187DFAA90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		protected bool DMMPCADAEMD
		{
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0xA43700", Offset = "0xA41F00", VA = "0x180A43700")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public bool GHBNDCPGNHD
		{
			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x7E05840", Offset = "0x7E04040", VA = "0x187E05840")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public int JAFNKCDIFOL
		{
			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x234F4E0", Offset = "0x234DCE0", VA = "0x18234F4E0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x7E06430", Offset = "0x7E04C30", VA = "0x187E06430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public int MLMEBGJLDJH
		{
			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x7E06170", Offset = "0x7E04970", VA = "0x187E06170")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		protected virtual bool PNPGDJIMFKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		protected virtual int[] NIGEHCBLGHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x7DFCA90", Offset = "0x7DFB290", VA = "0x187DFCA90", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		protected bool LBDBDBJLAOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x7DFC340", Offset = "0x7DFAB40", VA = "0x187DFC340")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		protected static bool JOIKFIAELOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public bool PEEBMNGAJID
		{
			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x7E058B0", Offset = "0x7E040B0", VA = "0x187E058B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x7E06700", Offset = "0x7E04F00", VA = "0x187E06700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public IEnumerable<SkinnedMeshRenderer> OMKFPLEOJPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x7E050B0", Offset = "0x7E038B0", VA = "0x187E050B0")]
			[IteratorStateMachine(typeof(KPAOJJKIFBE))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public bool HFNFNBOGCLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x7E05830", Offset = "0x7E04030", VA = "0x187E05830")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x7DFE6F0", Offset = "0x7DFCEF0", VA = "0x187DFE6F0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public CJONCCGGHCH DNFAHGOCPPN
		{
			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x7E05130", Offset = "0x7E03930", VA = "0x187E05130")]
			get
			{
				return default(CJONCCGGHCH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public static bool ENOKNFFEIDD
		{
			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(RVA = "0x7E05580", Offset = "0x7E03D80", VA = "0x187E05580")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		protected static NGLIALCAJHK GHLGHHIDKCO
		{
			[Cpp2IlInjected.Token(Token = "0x600027B")]
			[Cpp2IlInjected.Address(RVA = "0x7DF93D0", Offset = "0x7DF7BD0", VA = "0x187DF93D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0x7DF7B90", Offset = "0x7DF6390", VA = "0x187DF7B90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		protected Color DEMIJNNJIOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000296")]
			[Cpp2IlInjected.Address(RVA = "0x7DFF780", Offset = "0x7DFDF80", VA = "0x187DFF780")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		protected Color HPMGIMNMKGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000297")]
			[Cpp2IlInjected.Address(RVA = "0x7DFAB30", Offset = "0x7DF9330", VA = "0x187DFAB30")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		protected Texture2D FMMFLKPBMLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(RVA = "0x7DFFAF0", Offset = "0x7DFE2F0", VA = "0x187DFFAF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		protected Color OMFPLJOPJAN
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0x7DFF060", Offset = "0x7DFD860", VA = "0x187DFF060")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		protected Color ADNAOHDFMDF
		{
			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0x7DF9640", Offset = "0x7DF7E40", VA = "0x187DF9640")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public OANMLALNFNA JBAOGLJKDKM
		{
			[Cpp2IlInjected.Token(Token = "0x60002A0")]
			[Cpp2IlInjected.Address(RVA = "0x7E051A0", Offset = "0x7E039A0", VA = "0x187E051A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		protected Texture2D CENDKKDIEHF
		{
			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(RVA = "0x7DFBD50", Offset = "0x7DFA550", VA = "0x187DFBD50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public float IIGGGLCCEDL
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x7E051C0", Offset = "0x7E039C0", VA = "0x187E051C0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public float LENLPEHALPM
		{
			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0x7E05630", Offset = "0x7E03E30", VA = "0x187E05630")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public bool ECHHPJNPHJO
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0x7E05190", Offset = "0x7E03990", VA = "0x187E05190")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x7E05C00", Offset = "0x7E04400", VA = "0x187E05C00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action JMKHBDENEGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x7E04E10", Offset = "0x7E03610", VA = "0x187E04E10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x7E05960", Offset = "0x7E04160", VA = "0x187E05960")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action PBHLNNHPHLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x7E04D70", Offset = "0x7E03570", VA = "0x187E04D70")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x7E058C0", Offset = "0x7E040C0", VA = "0x187E058C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action HJNJJCBBBLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x7E04EB0", Offset = "0x7E036B0", VA = "0x187E04EB0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x7E05A00", Offset = "0x7E04200", VA = "0x187E05A00")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action ACHBCJHFKFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x7E04F50", Offset = "0x7E03750", VA = "0x187E04F50")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x7E05AA0", Offset = "0x7E042A0", VA = "0x187E05AA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<JMNLGEOMELD, BHFEFPLJLMD> MGCGEALDOMB
		{
			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x7E04FF0", Offset = "0x7E037F0", VA = "0x187E04FF0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x7E05B40", Offset = "0x7E04340", VA = "0x187E05B40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x7E01620", Offset = "0x7DFFE20", VA = "0x187E01620")]
		public bool SetDeformation(bool FJOMIJFACGD, bool OHILAFABJDB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x7DFDB60", Offset = "0x7DFC360", VA = "0x187DFDB60")]
		protected static Material JMBGMFPAOOG(Dictionary<NHLENANOCCI, Material> MBEFJGBJNEI, Material EHBFKOKKEME, KCFFIELKIDL LPHCFMKOJHP, EDDDLPNPAHM IGJBFJBCPIK, AMKHIMALNFB BHONCPBICBN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x7DFFE30", Offset = "0x7DFE630", VA = "0x187DFFE30")]
		protected void OOHAPLNEDBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x7DFC640", Offset = "0x7DFAE40", VA = "0x187DFC640")]
		protected bool HCADINOHMAB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD010", Offset = "0x7DFB810", VA = "0x187DFD010")]
		protected void IKPKMAAMEHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD6F0", Offset = "0x7DFBEF0", VA = "0x187DFD6F0", Slot = "10")]
		protected virtual void JAEMBDLLIIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x7DFECD0", Offset = "0x7DFD4D0", VA = "0x187DFECD0")]
		public int MeshesAtLODCount(int ALOHHFDOADL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x7DFCB70", Offset = "0x7DFB370", VA = "0x187DFCB70")]
		protected static void HOGPMDKIPNE(Dictionary<MGAECJPIAGF, List<NHLENANOCCI>> LILGCKMMEFL, FFBDGBOMFME ABJPPKEBCFK, Material EHBFKOKKEME, KCFFIELKIDL HGNBOIAPBOF, EDDDLPNPAHM JNKNLKDBMCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x7DF8C30", Offset = "0x7DF7430", VA = "0x187DF8C30")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD0A0", Offset = "0x7DFB8A0", VA = "0x187DFD0A0")]
		protected void IOFAKONIKHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x7DFFF50", Offset = "0x7DFE750", VA = "0x187DFFF50")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "11")]
		protected virtual void MKLMLIFLFLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x7E038C0", Offset = "0x7E020C0", VA = "0x187E038C0")]
		public void StartAvatarEffect(MNNECKEBGGO HKEJBJLDGKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x7DF8220", Offset = "0x7DF6A20", VA = "0x187DF8220")]
		protected static void AOJBOJPMHMG(List<Material> HJHMAPAGDDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x7DF7DE0", Offset = "0x7DF65E0", VA = "0x187DF7DE0")]
		protected static void AFOPCMFGPPO(Dictionary<NHLENANOCCI, Material> MBEFJGBJNEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x7DFE430", Offset = "0x7DFCC30", VA = "0x187DFE430")]
		protected static void LEIFEBLDKHL(Dictionary<Renderer, IBJCHDNGGMK> NMJLECJDNEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x7DFF660", Offset = "0x7DFDE60", VA = "0x187DFF660")]
		protected void NMCGAEIMALD(SkinnedMeshRenderer[] CBBJPOGILOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x7DFDCC0", Offset = "0x7DFC4C0", VA = "0x187DFDCC0")]
		protected void KCCINBNHOEE(SkinnedMeshRenderer MPBIIJKLLOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x7DFDD60", Offset = "0x7DFC560", VA = "0x187DFDD60")]
		protected void KCCINBNHOEE(MeshRenderer LHFMAOBELNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x7DF9170", Offset = "0x7DF7970", VA = "0x187DF9170")]
		protected void BMEKNNINHOJ(List<CJHHFDGDDDE> DGHEEGKBAFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x7E00340", Offset = "0x7DFEB40", VA = "0x187E00340")]
		protected void PGIALMKONGN(Dictionary<string, OBKOLGEFKBC<Texture2D>> LILGCKMMEFL, bool FGHNHICOFNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x7DFC3C0", Offset = "0x7DFABC0", VA = "0x187DFC3C0")]
		protected void GNFPOCKKIBO(Dictionary<MGAECJPIAGF, List<NHLENANOCCI>> LILGCKMMEFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x7DFC540", Offset = "0x7DFAD40", VA = "0x187DFC540")]
		public float GetHandOpenClosedAxis(JMNLGEOMELD FJLCMJLPIEE)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x7E01EB0", Offset = "0x7E006B0", VA = "0x187E01EB0")]
		public void SetHandOpenClosedAxis(JMNLGEOMELD FJLCMJLPIEE, float OCJLKOGPICE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x7DFC580", Offset = "0x7DFAD80", VA = "0x187DFC580")]
		public BHFEFPLJLMD GetHandVisualState(JMNLGEOMELD FJLCMJLPIEE)
		{
			return default(BHFEFPLJLMD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x7DF8370", Offset = "0x7DF6B70", VA = "0x187DF8370")]
		public bool AddHandVisualStateToken(JMNLGEOMELD FJLCMJLPIEE, BHFEFPLJLMD OKPAFKLOKIK, object KAJENDFCCBJ, GACELNMGIPE.LAHLGAJAOFE IAOOMFIBPGC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x7E03700", Offset = "0x7E01F00", VA = "0x187E03700")]
		public void SetWatchHand(JMNLGEOMELD FJLCMJLPIEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x7E037C0", Offset = "0x7E01FC0", VA = "0x187E037C0")]
		public void SetWatchHands(bool AFAJCGCOIDE, bool NALCNDNNDOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x7E00CE0", Offset = "0x7DFF4E0", VA = "0x187E00CE0")]
		public bool RemoveHandVisualStateToken(JMNLGEOMELD FJLCMJLPIEE, object KAJENDFCCBJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x7DFC600", Offset = "0x7DFAE00", VA = "0x187DFC600")]
		public bool GetThumbsUpActive(JMNLGEOMELD FJLCMJLPIEE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x7E03130", Offset = "0x7E01930", VA = "0x187E03130")]
		public void SetThumbsUpActive(JMNLGEOMELD FJLCMJLPIEE, bool NBMJLFEGLCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x7DFC5C0", Offset = "0x7DFADC0", VA = "0x187DFC5C0")]
		public bool GetHandshakeActive(JMNLGEOMELD FJLCMJLPIEE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x7E01F00", Offset = "0x7E00700", VA = "0x187E01F00")]
		public void SetHandshakeActive(JMNLGEOMELD FJLCMJLPIEE, bool IIOFAOIDLAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x7DFBBD0", Offset = "0x7DFA3D0", VA = "0x187DFBBD0")]
		public void ForceUpdateHandsVisualState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x7E035F0", Offset = "0x7E01DF0", VA = "0x187E035F0")]
		public void SetUseClassicBeanHandScale(bool MGONBEDEDON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x7DFA0D0", Offset = "0x7DF88D0", VA = "0x187DFA0D0")]
		public static void ClearQueuedBuilds()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x7DFBC20", Offset = "0x7DFA420", VA = "0x187DFBC20")]
		private static void GBKBFBIHEGI(Scene NBLBLIGFFMD, LoadSceneMode MFMCIMMKBLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x7DFDE30", Offset = "0x7DFC630", VA = "0x187DFDE30")]
		protected static void KFIAMIONADK(PlayerAvatarDisplayBase GJINHNDJGIG, List<KBPMJOEKBJP> ONDCIBEBHLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x7E009F0", Offset = "0x7DFF1F0", VA = "0x187E009F0")]
		public FKGMEHDMFDF Rebuild(bool FBKDIGABMDM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD9D0", Offset = "0x7DFC1D0", VA = "0x187DFD9D0")]
		protected FKGMEHDMFDF JLEOOCDBKDA(bool FBKDIGABMDM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x7DFDA30", Offset = "0x7DFC230", VA = "0x187DFDA30", Slot = "12")]
		protected virtual FKGMEHDMFDF JLEOOCDBKDA(IList<MGAECJPIAGF> ALAODDCKPCB, AvatarItemBodyType KENCFGCGDCD, bool GOIIKIMOADK, bool PBCOKGJDDCL, int[] BAGEAHKEMPD, bool FBKDIGABMDM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x7DFE7D0", Offset = "0x7DFCFD0", VA = "0x187DFE7D0")]
		protected static FKGMEHDMFDF MPJNKDMMGKP(KBPMJOEKBJP EAHADJBOLLF, List<KBPMJOEKBJP> ONDCIBEBHLG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x7DF8DB0", Offset = "0x7DF75B0", VA = "0x187DF8DB0")]
		[IteratorStateMachine(typeof(OEEGCOGLCBI))]
		protected static IEnumerator<ENGFNCJEKHI> BHPIPNCHGJF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x7DFA970", Offset = "0x7DF9170", VA = "0x187DFA970")]
		protected static KBPMJOEKBJP EFBNJJEJHOJ(List<KBPMJOEKBJP> ONDCIBEBHLG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x7E01720", Offset = "0x7DFFF20", VA = "0x187E01720")]
		[AsyncStateMachine(typeof(DFDCPJHANAN))]
		public Task SetFaceCustomizationSettings(BLGOLEELJGA CLPELFLAOOD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x7E039B0", Offset = "0x7E021B0", VA = "0x187E039B0")]
		public bool UpdateFaceAndBodyCustomizationSettings(BLGOLEELJGA CLPELFLAOOD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD610", Offset = "0x7DFBE10", VA = "0x187DFD610")]
		public void InitializeFaceFeatures(AvatarConfiguration NAFGJACICLO, CJONCCGGHCH KFPNMIJCCJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x7E02E90", Offset = "0x7E01690", VA = "0x187E02E90")]
		public void SetTeamColors(Color? NGKONEFHJON, bool GDBBFFDHMBD, Color IGLLPPGDCDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x13A1B90", Offset = "0x13A0390", VA = "0x1813A1B90")]
		private static void NOGLKIEFBOK(Material IPKNLMFNGIO, Color MGONBEDEDON, params int[] NPAGGJONIDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x13A1300", Offset = "0x139FB00", VA = "0x1813A1300")]
		private static void NILAKGNHDEK(Material IPKNLMFNGIO, Texture MGONBEDEDON, params int[] NPAGGJONIDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x7DFA470", Offset = "0x7DF8C70", VA = "0x187DFA470")]
		protected void EAODKBJLOFB(Material JFDDANCAOID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x7DFDF30", Offset = "0x7DFC730", VA = "0x187DFDF30")]
		protected void KFIMALDGIGH(Material JFDDANCAOID, Color DNPEIDEPJGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x7DF9420", Offset = "0x7DF7C20", VA = "0x187DF9420")]
		protected void BOMNHHJJHJJ(Material JFDDANCAOID, Color DNPEIDEPJGF, Color CBLEFOEFMDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x7E00670", Offset = "0x7DFEE70", VA = "0x187E00670")]
		protected void PMJMAHOMGHM(Material JFDDANCAOID, Texture2D AILALHOICPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x7DFFBE0", Offset = "0x7DFE3E0", VA = "0x187DFFBE0")]
		protected void ODDPAMGPEGO(Material JFDDANCAOID, Texture JCLBCHGJCPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x7DFE590", Offset = "0x7DFCD90", VA = "0x187DFE590")]
		protected void LEMBNJOFICA(Action<IBJCHDNGGMK> BODKMEIHEFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x7DF7FE0", Offset = "0x7DF67E0", VA = "0x187DF7FE0")]
		protected void AHOAOHAKFDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x7DFF0B0", Offset = "0x7DFD8B0", VA = "0x187DFF0B0")]
		protected void NGADMPGNEMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x7DF8E10", Offset = "0x7DF7610", VA = "0x187DF8E10")]
		protected void BIBIKPGFEGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x7DF86C0", Offset = "0x7DF6EC0", VA = "0x187DF86C0")]
		public void ApplyUgcItemOverrides()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x7E010A0", Offset = "0x7DFF8A0", VA = "0x187E010A0")]
		public void SetBeardPrimaryColor([Optional] Color? FGLHCLDJCCA, bool MENANFPIBEP = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x7E012C0", Offset = "0x7DFFAC0", VA = "0x187E012C0")]
		public void SetBeardSecondaryColor([Optional] Color? FGLHCLDJCCA, bool MENANFPIBEP = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x7E00F60", Offset = "0x7DFF760", VA = "0x187E00F60")]
		public void SetBeardPattern([Optional] AvatarHairPattern CHLBIGHKFKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD860", Offset = "0x7DFC060", VA = "0x187DFD860")]
		private void JIPFDCEBDHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x7DF9870", Offset = "0x7DF8070", VA = "0x187DF9870")]
		private bool CFKJOEDKGJJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x7E01A90", Offset = "0x7E00290", VA = "0x187E01A90")]
		public void SetHairPrimaryColor([Optional] Color? JBDOCKGBBEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x7E01CA0", Offset = "0x7E004A0", VA = "0x187E01CA0")]
		public void SetHairSecondaryColor([Optional] Color? JBDOCKGBBEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x7E01960", Offset = "0x7E00160", VA = "0x187E01960")]
		public void SetHairPattern([Optional] AvatarHairPattern CHLBIGHKFKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x7E00B80", Offset = "0x7DFF380", VA = "0x187E00B80")]
		public void RefreshHair()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x7DFCE50", Offset = "0x7DFB650", VA = "0x187DFCE50")]
		private bool HPANLFOHLJN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x7E02CD0", Offset = "0x7E014D0", VA = "0x187E02CD0")]
		public void SetSkinColor(Color BCPDIPOOKFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x7E03180", Offset = "0x7E01980", VA = "0x187E03180")]
		public void SetUgcItemVisualOverrides(MGAECJPIAGF IBKPFDCPMEG, CJONCCGGHCH KFPNMIJCCJO, Texture CMIADGEJACP, Color MDNNFNJMIJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x7DFA1A0", Offset = "0x7DF89A0", VA = "0x187DFA1A0")]
		public void ClearUgcItemVisualOverrides()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x7E01820", Offset = "0x7E00020", VA = "0x187E01820")]
		public bool SetFaceShape(AvatarFaceShape DJKIBLENKKK, bool BFCEAMOBHKH = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x7E002A0", Offset = "0x7DFEAA0", VA = "0x187E002A0")]
		private void PCPIEOMMHLJ(HCPABEIHEAJ MDHBPDAGPJP, float MGONBEDEDON, bool DLINACMNDMJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x7DFF350", Offset = "0x7DFDB50", VA = "0x187DFF350")]
		private void NLLLECOEJEM(ENGOKCEMLHN KFBOCFIJJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x7DF9920", Offset = "0x7DF8120", VA = "0x187DF9920")]
		private void CGANCHDNFND(LHAJKAMPCKL HBCBKEFIGGL, float MGONBEDEDON, bool NHBCHDEKNEL = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x7DF9A30", Offset = "0x7DF8230", VA = "0x187DF9A30")]
		private void CODBBJGLFNP(DOGKIFENHJN IKAIJLAMGFH, float MGONBEDEDON, bool MNIPDPOOLBH = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD750", Offset = "0x7DFBF50", VA = "0x187DFD750")]
		private void JHLLNBGIJKE(CEKDJAHLBLK FKLBHAGLOKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x7DFC410", Offset = "0x7DFAC10", VA = "0x187DFC410")]
		private void GNOECIJLGHO(MCAAEPNCNNP GLNAIJKBGNM, float MOHOHDMLOMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x7E014E0", Offset = "0x7DFFCE0", VA = "0x187E014E0")]
		public bool SetBodyShape(AvatarBodyShape BNAGLBHEBAD, bool BFCEAMOBHKH = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x7E02B60", Offset = "0x7E01360", VA = "0x187E02B60")]
		public bool SetNoseType(HJAEKHPBLDG DHBONOABFMP, bool BFCEAMOBHKH = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x7E04090", Offset = "0x7E02890", VA = "0x187E04090")]
		public bool UpdateFaceAndBodyShapes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x7E02B40", Offset = "0x7E01340", VA = "0x187E02B40")]
		public bool SetHideEars(bool MIAIDMDPKFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x7E02B30", Offset = "0x7E01330", VA = "0x187E02B30")]
		public bool SetHelmetHair(ODBDPJODIME FACDEHPLHIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x7E025A0", Offset = "0x7E00DA0", VA = "0x187E025A0")]
		public void SetHatAnchorParameters(CPOALKJLKJO JLPAAFOKDGC, bool BOMHMIAFEHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x7E03890", Offset = "0x7E02090", VA = "0x187E03890")]
		public void SetupDisplayLODs(JCGMBILIKIK DPIMOONOLKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD460", Offset = "0x7DFBC60", VA = "0x187DFD460")]
		protected int[] IPDNDKPJOPL(JCGMBILIKIK DPIMOONOLKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x7E02C90", Offset = "0x7E01490", VA = "0x187E02C90")]
		public void SetOutfitSelections(IList<MGAECJPIAGF> ALAODDCKPCB, AvatarItemBodyType KENCFGCGDCD, bool PBCOKGJDDCL, bool FBKDIGABMDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x7E02C40", Offset = "0x7E01440", VA = "0x187E02C40")]
		public void SetOutfitSelections(IList<MGAECJPIAGF> ALAODDCKPCB, AvatarItemBodyType KENCFGCGDCD, bool GOIIKIMOADK, bool PBCOKGJDDCL, bool FBKDIGABMDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x7E02C00", Offset = "0x7E01400", VA = "0x187E02C00")]
		public FKGMEHDMFDF SetOutfitSelections(IList<MGAECJPIAGF> ALAODDCKPCB, AvatarItemBodyType KENCFGCGDCD, JCGMBILIKIK DPIMOONOLKO, bool GOIIKIMOADK, bool PBCOKGJDDCL, bool BFCEAMOBHKH = false, bool FBKDIGABMDM = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x7DFA6F0", Offset = "0x7DF8EF0", VA = "0x187DFA6F0", Slot = "13")]
		protected virtual FKGMEHDMFDF EBJAAOBNNLO(IList<MGAECJPIAGF> ALAODDCKPCB, AvatarItemBodyType KENCFGCGDCD, bool GOIIKIMOADK, bool PBCOKGJDDCL, JCGMBILIKIK DPIMOONOLKO, bool BFCEAMOBHKH, bool FBKDIGABMDM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x7DFCF10", Offset = "0x7DFB710", VA = "0x187DFCF10")]
		protected int[] IEPHGGCGPAI(JCGMBILIKIK DPIMOONOLKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0xA28D50", Offset = "0xA27550", VA = "0x180A28D50", Slot = "14")]
		protected virtual JLFAJMGNMDK INNDDFCKFGN(AvatarItemBodyType DDFBAFHFINE, Dictionary<string, OPEJGCCNPHE> CLNFFJJDPMJ, Dictionary<string, OBKOLGEFKBC<Texture2D>> CMLCODMFDDK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x7DFED90", Offset = "0x7DFD590", VA = "0x187DFED90", Slot = "15")]
		protected virtual FKGMEHDMFDF NDHPJOHGOGI(IList<MGAECJPIAGF> ALAODDCKPCB, AvatarItemBodyType KENCFGCGDCD, bool GOIIKIMOADK, bool PBCOKGJDDCL, int[] NBLMCPIIPBK, KKCINKBPNJO LBPEIEGMOGF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x7DFBE50", Offset = "0x7DFA650", VA = "0x187DFBE50", Slot = "16")]
		protected virtual OPEJGCCNPHE GGANIHNABEJ(OANMLALNFNA JCNEIFHNADD, AvatarItemBodyType DDFBAFHFINE, AMKHIMALNFB BHONCPBICBN, OPEJGCCNPHE JHDAMCLNDKK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0xA28D50", Offset = "0xA27550", VA = "0x180A28D50", Slot = "17")]
		protected virtual OPEJGCCNPHE JLABIFAFHHE(AvatarItemBodyType DDFBAFHFINE, AMKHIMALNFB BHONCPBICBN, FLMOPOMFAIA DLJGBAKBBOP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x7E00220", Offset = "0x7DFEA20", VA = "0x187E00220")]
		protected void PCADGIDDAEA(MIBIOPCDBNF ADKEBKFMBHG, AFHHIDGAGFC.KICMKFFCOMP HCOBMBADFEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x7DFBB50", Offset = "0x7DFA350", VA = "0x187DFBB50")]
		protected void FNKOHHNIJNI(MIBIOPCDBNF ADKEBKFMBHG, AFHHIDGAGFC.KICMKFFCOMP HCOBMBADFEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0xAA1C90", Offset = "0xAA0490", VA = "0x180AA1C90", Slot = "18")]
		protected virtual MIBIOPCDBNF IALJAONLNKH(MIBIOPCDBNF ADKEBKFMBHG, HelmetHairStyle EEIONCHAADC, bool BIDFGGEJIIP, AvatarItemBodyType KENCFGCGDCD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x7DFAB80", Offset = "0x7DF9380", VA = "0x187DFAB80")]
		protected MIBIOPCDBNF FNHHNNCHCML(IList<MGAECJPIAGF> ALAODDCKPCB, AvatarItemBodyType ACFJNAFFHEO, bool PBCOKGJDDCL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x7DF9FB0", Offset = "0x7DF87B0", VA = "0x187DF9FB0")]
		public void CleanupDisplayResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x7DFA300", Offset = "0x7DF8B00", VA = "0x187DFA300")]
		protected void DPCDHDAMAHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x7DFF7D0", Offset = "0x7DFDFD0", VA = "0x187DFF7D0")]
		protected void OBFDEDENHIA(Transform KHENBMPLPOB, IEnumerable<SkinnedMeshRenderer> KKHOCGIOAOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x7DFA240", Offset = "0x7DF8A40", VA = "0x187DFA240")]
		protected AFHHIDGAGFC.KICMKFFCOMP DFGOIPBMDMB(AFHHIDGAGFC.KICMKFFCOMP OBIBDPIHBOJ, AMKHIMALNFB ALHFMAIGMHK)
		{
			return default(AFHHIDGAGFC.KICMKFFCOMP);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x7DF8360", Offset = "0x7DF6B60", VA = "0x187DF8360")]
		protected void APGHAHFPBKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0xA87E30", Offset = "0xA86630", VA = "0x180A87E30")]
		protected void IEMFKKCHCIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x7DFF550", Offset = "0x7DFDD50", VA = "0x187DFF550")]
		protected void NLNODGLOIGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x7E00880", Offset = "0x7DFF080", VA = "0x187E00880")]
		[AsyncStateMachine(typeof(NKFFKKHMMGF))]
		protected Task POIKIFJAPFK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x7DFE290", Offset = "0x7DFCA90", VA = "0x187DFE290")]
		protected static KCFFIELKIDL LCGPPHHAAJB(FFBDGBOMFME AMIADACPHOE, int ALCDHADGBBH)
		{
			return default(KCFFIELKIDL);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x7E00520", Offset = "0x7DFED20", VA = "0x187E00520")]
		protected static EDDDLPNPAHM PLMMMCDBHED(FFBDGBOMFME AMIADACPHOE, int ALCDHADGBBH)
		{
			return default(EDDDLPNPAHM);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x7DFA1F0", Offset = "0x7DF89F0", VA = "0x187DFA1F0")]
		protected Transform DAHEAIBHHIL(AMKHIMALNFB BHONCPBICBN, OutfitType CLJIDLBOOFI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x7DFC890", Offset = "0x7DFB090", VA = "0x187DFC890")]
		protected void HEDFFOCFHAA(int OBCBHDBACIL, Material IPKNLMFNGIO, FFBDGBOMFME AMIADACPHOE, [Out] Texture2D MKCBDFHGFNG, [Out] Vector4 GNIJIMNMHIK, [Out] Texture2D LKFDHGEJDAB, [Out] Texture2D LHEFACKLEFI, [Out] Texture2D BMJCNKGBLGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x7DF9690", Offset = "0x7DF7E90", VA = "0x187DF9690")]
		protected void CDNFKKCEDKE(int OBCBHDBACIL, Material IPKNLMFNGIO, FFBDGBOMFME AMIADACPHOE, [Out] Color GHACELNNKIA, [Out] Color JGCCIMLMHPP, [Out] Color INBBHDHGJBD, [Out] Color DKEMBKEAHOB, [Out] Color IJMCOMPCOHA, [Out] Color BNDLCFCECGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x7DF99C0", Offset = "0x7DF81C0", VA = "0x187DF99C0")]
		protected void CHGLCMNBHGE(Vector3 EOALAOOGNLB, Quaternion FAABMGBBECF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x7E01F50", Offset = "0x7E00750", VA = "0x187E01F50")]
		public void SetHatAnchorParameters(CPOALKJLKJO JLPAAFOKDGC, AnchorParamsRestrictions IPICFBMEDBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x7DF9AD0", Offset = "0x7DF82D0", VA = "0x187DF9AD0")]
		public static void CalculateHatAnchorParams(FitMeshHemisphere JGANABKABFL, Transform PJBKGJIMGHD, CPOALKJLKJO JLPAAFOKDGC, AnchorParamsRestrictions DDMPCJHKHKC, [Out] Vector3 BAIEFBENFCP, [Out] Quaternion HBPGIGGIBDO, [Out] CPOALKJLKJO JPAKKLJBDNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x7E00DF0", Offset = "0x7DFF5F0", VA = "0x187E00DF0")]
		public void ResetHatAnchor(Vector2 MFGKFFDGMMD, Vector3 GEGHMHKIJGM, Vector3 DHNKBJGALEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xAA63E0", Offset = "0xAA4BE0", VA = "0x180AA63E0")]
		public GLDFLNAFMAP GetAnchorParamsRestrictions()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x7DF84F0", Offset = "0x7DF6CF0", VA = "0x187DF84F0")]
		public void ApplyBlocks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x7DF8630", Offset = "0x7DF6E30", VA = "0x187DF8630")]
		public void ApplyHairPattern()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x7DF8460", Offset = "0x7DF6C60", VA = "0x187DF8460")]
		public void ApplyBeardPattern()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x7E03950", Offset = "0x7E02150", VA = "0x187E03950", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x7DFA3B0", Offset = "0x7DF8BB0", VA = "0x187DFA3B0")]
		protected void EAMAJMCNKMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x7E03680", Offset = "0x7E01E80", VA = "0x187E03680")]
		public void SetWaitForUgcTextureLoads(bool PAHGNOCMEIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x7E03510", Offset = "0x7E01D10", VA = "0x187E03510")]
		public void SetUgcTextureParameters(FOIPDPBDMCD JCPNJLMMOLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x7E04770", Offset = "0x7E02F70", VA = "0x187E04770")]
		public PlayerAvatarDisplayBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD3D0", Offset = "0x7DFBBD0", VA = "0x187DFD3D0")]
		[CompilerGenerated]
		private void IOJGKKNGLGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x7DFC860", Offset = "0x7DFB060", VA = "0x187DFC860")]
		[CompilerGenerated]
		private void HEDCNEFFIBN(IBJCHDNGGMK HEMLFKMOIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x7DFE740", Offset = "0x7DFCF40", VA = "0x187DFE740")]
		[CompilerGenerated]
		private void LLIENNFLCKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x7DF7F40", Offset = "0x7DF6740", VA = "0x187DF7F40")]
		[CompilerGenerated]
		private void AHCKEDEDDDK(IBJCHDNGGMK HEMLFKMOIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x7DF97E0", Offset = "0x7DF7FE0", VA = "0x187DF97E0")]
		[CompilerGenerated]
		private void CENNJKJPMOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x7E00950", Offset = "0x7DFF150", VA = "0x187E00950")]
		[CompilerGenerated]
		private void POKEPCIIFPB(IBJCHDNGGMK HEMLFKMOIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x7DFAA00", Offset = "0x7DF9200", VA = "0x187DFAA00")]
		[CompilerGenerated]
		private void EHICOJOBEGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x7DFCB20", Offset = "0x7DFB320", VA = "0x187DFCB20")]
		[CompilerGenerated]
		private void HHMEKBJMHHG(IBJCHDNGGMK HEMLFKMOIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x7DF7D50", Offset = "0x7DF6550", VA = "0x187DF7D50")]
		[CompilerGenerated]
		private void ACOENBBCCCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x7DFFDE0", Offset = "0x7DFE5E0", VA = "0x187DFFDE0")]
		[CompilerGenerated]
		private void OFACKKDDGDC(IBJCHDNGGMK HEMLFKMOIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x7DF9340", Offset = "0x7DF7B40", VA = "0x187DF9340")]
		[CompilerGenerated]
		private void BMMDAKFHNLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x7E00500", Offset = "0x7DFED00", VA = "0x187E00500")]
		[CompilerGenerated]
		private void PJFCBIEMIJO(IBJCHDNGGMK HEMLFKMOIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x7DFF270", Offset = "0x7DFDA70", VA = "0x187DFF270")]
		[CompilerGenerated]
		internal static bool NHHJONKDMFK(Transform NPOEEKPBFHC, IEnumerable<SkinnedMeshRenderer> FJMJFAHIPMO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x7DFE700", Offset = "0x7DFCF00", VA = "0x187DFE700")]
		[CompilerGenerated]
		private void LLEEOPHBJIF(IBJCHDNGGMK HEMLFKMOIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x7E004C0", Offset = "0x7DFECC0", VA = "0x187E004C0")]
		[CompilerGenerated]
		private void PHMILCFDEOP(IBJCHDNGGMK HEMLFKMOIDL)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[ExecuteAlways]
	public class PlayerFacialAnimatorBase : MonoBehaviour, GKEGMHGFIBN
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		[CompilerGenerated]
		private struct DEFJACDOLCO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000468")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000469")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400046A")]
			public BLGOLEELJGA avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400046B")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400046C")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x7E07AF0", Offset = "0x7E062F0", VA = "0x187E07AF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x7E07D80", Offset = "0x7E06580", VA = "0x187E07D80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		[CompilerGenerated]
		private struct JJLIAJNKDPG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400046D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400046E")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400046F")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000470")]
			public int eyeSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000471")]
			public int eyeBrowSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000472")]
			public int noseSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000473")]
			public int mouthSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000474")]
			public CJONCCGGHCH avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000475")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x7E0CE10", Offset = "0x7E0B610", VA = "0x187E0CE10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x7E0CFF0", Offset = "0x7E0B7F0", VA = "0x187E0CFF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		[CompilerGenerated]
		private struct FPAIEAKPCHH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000476")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000477")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000478")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000479")]
			public FaceFeatureType featureType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400047A")]
			public int selectionIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400047B")]
			public CJONCCGGHCH avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400047C")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x7E08450", Offset = "0x7E06C50", VA = "0x187E08450", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x7E085F0", Offset = "0x7E06DF0", VA = "0x187E085F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private struct DAGKIHEKJLA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400047D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400047E")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400047F")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000480")]
			public BLGOLEELJGA avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000481")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x7E07640", Offset = "0x7E05E40", VA = "0x187E07640", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0x7E077F0", Offset = "0x7E05FF0", VA = "0x187E077F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private struct AHDKHIEHMGF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000482")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000483")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000484")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000485")]
			public CJONCCGGHCH avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000486")]
			private TaskAwaiter<KLIALBMKNDO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x7E06C50", Offset = "0x7E05450", VA = "0x187E06C50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x7E07090", Offset = "0x7E05890", VA = "0x187E07090", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		[CompilerGenerated]
		private struct PCNDNLDNHFI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000487")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000488")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000489")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400048A")]
			public bool forceRebuild;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400048B")]
			public CJONCCGGHCH avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400048C")]
			private FaceStyleSet <styleSet>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400048D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x7E0E970", Offset = "0x7E0D170", VA = "0x187E0E970", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0x7E0ED90", Offset = "0x7E0D590", VA = "0x187E0ED90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		protected const float HJGBGBNBODO = 0.5f;

		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		protected const int MNGGPGJCDHO = 5;

		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		private static readonly int OPFLBLJDCJA;

		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		private static readonly int HKKLNGECKAL;

		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		private static readonly int JLFFMLPBEIA;

		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public static readonly int IdleID;

		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public static readonly int SmileID;

		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public static readonly int HugeSmileID;

		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public static readonly int ScoreID;

		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public static readonly int SadID;

		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public static readonly int DisgustID;

		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public static readonly int HitID;

		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public static readonly int ConcentrateID;

		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public static readonly int KissID;

		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public static readonly int TalkingID;

		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public static readonly int MuteID;

		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public static readonly int AFKID;

		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public static readonly int HappyID;

		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public static readonly int EmoteFlatID;

		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public static readonly int EmoteHappyID;

		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public static readonly int EmoteSadID;

		[Cpp2IlInjected.Token(Token = "0x4000405")]
		public static readonly int EmoteLoveID;

		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public static readonly int EmoteAngryID;

		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public static readonly int EmoteLaughID;

		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public static readonly int EmoteTongueOutID;

		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public static readonly int EmoteGrimacingID;

		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public static readonly int EmoteWinkID;

		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public static readonly int EmoteShockedID;

		[Cpp2IlInjected.Token(Token = "0x400040C")]
		public static readonly int EmoteNauseatedID;

		[Cpp2IlInjected.Token(Token = "0x400040D")]
		public static readonly int EmoteSmileSweatID;

		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public static readonly int EmoteSleepingID;

		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public static readonly int EmoteThinkingID;

		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public static readonly int EmoteSmirkID;

		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public static readonly int EmoteSmileID;

		[Cpp2IlInjected.Token(Token = "0x4000412")]
		protected static readonly Dictionary<EKFDHDPCMJC.JDGAOBPPMLJ, int> LEMPNBAPJME;

		[Cpp2IlInjected.Token(Token = "0x4000413")]
		[CanBeNull]
		protected static IEnumerable<FaceFeatureType> IFILMGFBLKG;

		[Cpp2IlInjected.Token(Token = "0x4000414")]
		protected static readonly int MLMAHMLEHNN;

		[Cpp2IlInjected.Token(Token = "0x4000415")]
		protected static readonly int APCPKDAKFJN;

		[Cpp2IlInjected.Token(Token = "0x4000416")]
		protected static readonly int OIEJBPAJHDK;

		[Cpp2IlInjected.Token(Token = "0x4000417")]
		protected static readonly int ONJNNHFJNEG;

		[Cpp2IlInjected.Token(Token = "0x4000418")]
		protected static readonly int DPOIMKOGOIE;

		[Cpp2IlInjected.Token(Token = "0x4000419")]
		protected static Vector2 IGNHBPHBKIJ;

		[Cpp2IlInjected.Token(Token = "0x400041A")]
		protected static Vector2 HDDCFBHDFDE;

		[Cpp2IlInjected.Token(Token = "0x400041B")]
		protected static Vector2 MOIAMKFEPMG;

		[Cpp2IlInjected.Token(Token = "0x400041C")]
		protected static Vector2 FFJEBMNBGEI;

		[Cpp2IlInjected.Token(Token = "0x400041D")]
		protected static Vector2 HLMCKLEFJMJ;

		[Cpp2IlInjected.Token(Token = "0x400041E")]
		protected static Vector2 JDMKKLOJPKP;

		[Cpp2IlInjected.Token(Token = "0x400041F")]
		protected static Vector2 DAHNBCMAPGK;

		[Cpp2IlInjected.Token(Token = "0x4000420")]
		protected static Vector2 GJKBGNAMJFE;

		[Cpp2IlInjected.Token(Token = "0x4000421")]
		protected static Vector2 GAPPAIMBBHA;

		[Cpp2IlInjected.Token(Token = "0x4000422")]
		protected static Vector2 IHBHCDBBIDK;

		[Cpp2IlInjected.Token(Token = "0x4000423")]
		protected static Vector2 PGGHNGGLFGI;

		[Cpp2IlInjected.Token(Token = "0x4000424")]
		protected static Vector2 AFHPHEKLIFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		[GKBMICLOBGF(CGAFHOMJNOP.Self, false, false, false)]
		[SerializeField]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		[Header("Rendering")]
		[SerializeField]
		public FaceStyleSet faceStyleSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		[SerializeField]
		protected Renderer faceRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		[SerializeField]
		protected float jitterFPS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		[SerializeField]
		[Header("Emotes")]
		public Renderer[] emoteEffectRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		[SerializeField]
		[Header("Modern Avatar Facial Features")]
		[FormerlySerializedAs("fullBodyFaceStyleSet")]
		public FaceStyleSet modernBodyFaceStyleSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		private CJONCCGGHCH DFOHDHMKIKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		private FaceStyleSet FNEDCCAKPDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		[SerializeField]
		protected bool debugEyeJitterInEditor;

		[Cpp2IlInjected.Token(Token = "0x400042E")]
		protected const int MCIDMHMKEOD = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		protected int EHJMILDMIJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		protected int ENKDGAGCDFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		protected int OPDBDKOBBPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		protected int MOJNCJPJKBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		protected Vector2 OMKOIKDDKPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		protected float BIHOLIBEDBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		protected float JCOFMFMMAIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		protected float MGEGKEPPNKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		protected Vector2 GDJGBENJOLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		protected float DIIIMKELOII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		protected float FBJOCPLFHCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		protected float CMMCLGDEIBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		protected Vector2 ECGFMHMNKIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		protected float BNEDLPKEJGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		protected float NIIDAPMAHAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		protected float BGBEDOGCEND;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		protected Vector2 AMFNKOGNMFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		protected float PAHBOAPBGAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		protected float PAMPDHLIADK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		protected float KMKHNMILGPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		protected List<SelectableFaceOption> KBOMJABFJNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		protected List<SelectableFaceOption> ODHJJOJFGMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		protected List<SelectableFaceOption> IPGHDBFGABE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		protected List<SelectableFaceOption> IPELDHBCFLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		protected Coroutine BNIKBLCBKKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		protected int? CJLLPGEBDAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		protected int FOMAKOJKHCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		protected int MPAALANCJEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		protected int FDMEPFGJKGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		protected int EBGALJAIJPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		protected Sprite FEGOCLFNJHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		protected Sprite ABCBMJBDEOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		protected Sprite HLGNCABLADD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		protected Sprite IFIIHLCFOGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		protected bool MCAKKFBEHCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		protected string EHHFJGINODH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		protected string MDJMOKDGFKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		protected string MFODNLBGJOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		protected string ILHEBIPCKOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		[ReadOnlyField]
		public Sprite eyeSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		[ReadOnlyField]
		public Sprite leftEyeOnlySprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		[ReadOnlyField]
		public Sprite rightEyeOnlySprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public Color leftEyeColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public Color leftEyeGleamColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public Color rightEyeColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public Color rightEyeGleamColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		[ReadOnlyField]
		public Sprite mouthSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		protected AvatarConfiguration NAFGJACICLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		protected KLIALBMKNDO AHIKHONOHBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		private readonly List<Material> MHKJFJMOHEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		protected KOABCLNMMFE CGBGAIACIGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		protected Dictionary<string, int> HKFDNEOJCEP;

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public FaceStyleSet KGOEHIJKOIH
		{
			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x7E15510", Offset = "0x7E13D10", VA = "0x187E15510")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public bool NPBENHPKCNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x23ECEA0", Offset = "0x23EB6A0", VA = "0x1823ECEA0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x24BF120", Offset = "0x24BD920", VA = "0x1824BF120")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		protected virtual bool PAJONOPCCEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		protected virtual bool MLLKBPMCFIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0xA43700", Offset = "0xA41F00", VA = "0x180A43700", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		protected int PIDJBNFIJMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x7E0F9D0", Offset = "0x7E0E1D0", VA = "0x187E0F9D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public Renderer BAOHOGPLEEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0xA2D3B0", Offset = "0xA2BBB0", VA = "0x180A2D3B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public bool JPPDEMALEPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x218AC50", Offset = "0x2189450", VA = "0x18218AC50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x24C0480", Offset = "0x24BEC80", VA = "0x1824C0480")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public Renderer[] FIFMDJOOKCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0xA2D4A0", Offset = "0xA2BCA0", VA = "0x180A2D4A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public bool ANFIPKDPHAD
		{
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x7E15560", Offset = "0x7E13D60", VA = "0x187E15560")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x7E15720", Offset = "0x7E13F20", VA = "0x187E15720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		protected int DOHICGAMABG
		{
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x7E112F0", Offset = "0x7E0FAF0", VA = "0x187E112F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		protected int HAAKPCOHDFN
		{
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x7E0FED0", Offset = "0x7E0E6D0", VA = "0x187E0FED0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public float NKLLPBEHJEA
		{
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x7E15540", Offset = "0x7E13D40", VA = "0x187E15540")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x7E15700", Offset = "0x7E13F00", VA = "0x187E15700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public DEJGECFFKMC DLHFIMANFGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0xB47230", Offset = "0xB45A30", VA = "0x180B47230")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0xB79410", Offset = "0xB77C10", VA = "0x180B79410")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public KLIALBMKNDO JKGHHIBHGJC
		{
			[Cpp2IlInjected.Token(Token = "0x600038D")]
			[Cpp2IlInjected.Address(RVA = "0xB46AA0", Offset = "0xB452A0", VA = "0x180B46AA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600038E")]
			[Cpp2IlInjected.Address(RVA = "0x7E15680", Offset = "0x7E13E80", VA = "0x187E15680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public NoseFaceOption LMPBCMMFMIL
		{
			[Cpp2IlInjected.Token(Token = "0x600038F")]
			[Cpp2IlInjected.Address(RVA = "0xAB0B30", Offset = "0xAAF330", VA = "0x180AB0B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000390")]
			[Cpp2IlInjected.Address(RVA = "0xB2B7F0", Offset = "0xB29FF0", VA = "0x180B2B7F0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		protected KOABCLNMMFE LACPBJDPKOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000391")]
			[Cpp2IlInjected.Address(RVA = "0x7E103A0", Offset = "0x7E0EBA0", VA = "0x187E103A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action CFGICMIDBGE
		{
			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x7E15460", Offset = "0x7E13C60", VA = "0x187E15460")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x7E155D0", Offset = "0x7E13DD0", VA = "0x187E155D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x7E11350", Offset = "0x7E0FB50", VA = "0x187E11350")]
		public void LocalPlayEmote(EKFDHDPCMJC.JDGAOBPPMLJ EEKMBPCOBHO, float EOMNNGIGIDG = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x7E10930", Offset = "0x7E0F130", VA = "0x187E10930")]
		public bool IsEmotePlaying(EKFDHDPCMJC.JDGAOBPPMLJ EEKMBPCOBHO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x7E13490", Offset = "0x7E11C90", VA = "0x187E13490")]
		public void SetIdleHappy(bool LOLOJIJNOHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x7E0FE50", Offset = "0x7E0E650", VA = "0x187E0FE50")]
		protected void FICJKDEFFIL(bool BJMOFEDFAMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x7E0F470", Offset = "0x7E0DC70", VA = "0x187E0F470")]
		protected void BBHGMPFIKDJ(bool MAGBKLBLCGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x7E10120", Offset = "0x7E0E920", VA = "0x187E10120")]
		protected void GPGIBACPBNJ(AMKHIMALNFB BHONCPBICBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x7E100B0", Offset = "0x7E0E8B0", VA = "0x187E100B0")]
		protected void GBPAJDHNIDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x7E12B60", Offset = "0x7E11360", VA = "0x187E12B60")]
		public void PlayExpression(int IODEIBHBPBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x7E10B20", Offset = "0x7E0F320", VA = "0x187E10B20")]
		protected void KCKAJKEDAHF(bool MELFFBDFDFC, bool PPANJJBJHCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x7E10360", Offset = "0x7E0EB60", VA = "0x187E10360")]
		public List<SelectableFaceOption> GetAvailableFeatures(FaceFeatureType AAPGDMAKKKB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x7E10420", Offset = "0x7E0EC20", VA = "0x187E10420")]
		public void InitializeFaceFeatureRanges(AvatarConfiguration NAFGJACICLO, CJONCCGGHCH KFPNMIJCCJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x7E13260", Offset = "0x7E11A60", VA = "0x187E13260")]
		[AsyncStateMachine(typeof(DEFJACDOLCO))]
		public Task SetFaceSettings(BLGOLEELJGA CLPELFLAOOD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x7E13130", Offset = "0x7E11930", VA = "0x187E13130")]
		[AsyncStateMachine(typeof(JJLIAJNKDPG))]
		public Task SetFaceSettings(int GOEGIFGBLDO, int BPCLNMENFLF, int PLBEEIMHNOE, int NPOHCIGKMGL, CJONCCGGHCH KFPNMIJCCJO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x7E13510", Offset = "0x7E11D10", VA = "0x187E13510")]
		[AsyncStateMachine(typeof(FPAIEAKPCHH))]
		public Task SetSelectedFaceFeatureAndBuildFaceStyle(FaceFeatureType AAPGDMAKKKB, int NNCLIANJPMA, CJONCCGGHCH KFPNMIJCCJO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x7E0F1B0", Offset = "0x7E0D9B0", VA = "0x187E0F1B0")]
		protected void ACBJPIGKFOO(FaceFeatureType AAPGDMAKKKB, JKBFIDNMNPD HDLFDFIDMPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x7E11FA0", Offset = "0x7E107A0", VA = "0x187E11FA0")]
		protected void OPILHIMKCEG(FaceFeatureType AAPGDMAKKKB, int NNCLIANJPMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x7E10190", Offset = "0x7E0E990", VA = "0x187E10190")]
		public static IEnumerable<FaceFeatureType> GetAllFaceFeatureTypes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x7E0FB00", Offset = "0x7E0E300", VA = "0x187E0FB00")]
		[AsyncStateMachine(typeof(DAGKIHEKJLA))]
		protected Task EILNMKGKIML(BLGOLEELJGA CLPELFLAOOD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x7E0F6D0", Offset = "0x7E0DED0", VA = "0x187E0F6D0")]
		protected void DFMLBJGILIL(BLGOLEELJGA CLPELFLAOOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x7E128F0", Offset = "0x7E110F0", VA = "0x187E128F0")]
		protected static void PGBDAOPMGON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x7E0FBF0", Offset = "0x7E0E3F0", VA = "0x187E0FBF0")]
		private void FEHDPAINFCI(bool CCHGHNAMPGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x7E10CB0", Offset = "0x7E0F4B0", VA = "0x187E10CB0")]
		protected void LCNCONOPOFF(FaceFeatureType AAPGDMAKKKB, Vector2 NHEHGCMBBBI, CJONCCGGHCH KFPNMIJCCJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x7E12B80", Offset = "0x7E11380", VA = "0x187E12B80")]
		public void SetFaceFeatureNormalizedPositionOffset(FaceFeatureType AAPGDMAKKKB, Vector2 JLCKHGMFLLG, CJONCCGGHCH KFPNMIJCCJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x7E0FF30", Offset = "0x7E0E730", VA = "0x187E0FF30")]
		protected void GAAPJFPAOIK(FaceFeatureType AAPGDMAKKKB, float NHKOKLGIOOM, CJONCCGGHCH KFPNMIJCCJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x7E11E20", Offset = "0x7E10620", VA = "0x187E11E20")]
		protected void OMADDCJAJGP(FaceFeatureType AAPGDMAKKKB, float FENAGHBAFHI, CJONCCGGHCH KFPNMIJCCJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x7E10A50", Offset = "0x7E0F250", VA = "0x187E10A50")]
		protected void JNCFFDDGGIO(FaceFeatureType AAPGDMAKKKB, float JOEAEIKOONH, CJONCCGGHCH KFPNMIJCCJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x7E12F10", Offset = "0x7E11710", VA = "0x187E12F10")]
		public void SetFaceFeatureNormalizedScaleOffset(FaceFeatureType AAPGDMAKKKB, float BEJBCLBMLMN, CJONCCGGHCH KFPNMIJCCJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x7E12A80", Offset = "0x7E11280", VA = "0x187E12A80")]
		[AsyncStateMachine(typeof(AHDKHIEHMGF))]
		protected Task PLPPIKIJPOC(CJONCCGGHCH KFPNMIJCCJO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x7E10720", Offset = "0x7E0EF20", VA = "0x187E10720")]
		public void InitializeFaceFeatureStyleSet(CJONCCGGHCH KFPNMIJCCJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x7E10BD0", Offset = "0x7E0F3D0", VA = "0x187E10BD0")]
		protected bool KMHDPKHNGGJ(string CGJINGAJMGP, [Out] int PNJCJGEIDHG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x7E0F330", Offset = "0x7E0DB30", VA = "0x187E0F330")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x7E13620", Offset = "0x7E11E20", VA = "0x187E13620", Slot = "8")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x7E126E0", Offset = "0x7E10EE0", VA = "0x187E126E0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x7E14600", Offset = "0x7E12E00", VA = "0x187E14600")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x7E0F5D0", Offset = "0x7E0DDD0", VA = "0x187E0F5D0")]
		[AsyncStateMachine(typeof(PCNDNLDNHFI))]
		public Task BuildFaceStyleAsyncIfChanged(CJONCCGGHCH KFPNMIJCCJO, bool BFCEAMOBHKH = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x7E13F10", Offset = "0x7E12710", VA = "0x187E13F10")]
		public void UpdateFaceDisplays(bool GOFNKMAMLCA = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x7E115F0", Offset = "0x7E0FDF0", VA = "0x187E115F0")]
		protected bool OGJHMGPLPJL(bool GOFNKMAMLCA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x7E13C70", Offset = "0x7E12470", VA = "0x187E13C70")]
		public void UpdateFaceDisplayFeatureTextures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x7E13350", Offset = "0x7E11B50", VA = "0x187E13350")]
		public void SetFaceSpriteIndices(string FCIEEGDKKAF, string ABMDGEPCOLF, string FHJNLDNJHOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x7E13630", Offset = "0x7E11E30", VA = "0x187E13630")]
		public void UpdateFaceDisplayFeaturePositions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x7E14130", Offset = "0x7E12930", VA = "0x187E14130")]
		public void UpdateFaceJitterMultiplier()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x7E14320", Offset = "0x7E12B20", VA = "0x187E14320")]
		public bool UpdateLegacyFaceVectors()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x7E11D30", Offset = "0x7E10530", VA = "0x187E11D30")]
		protected void OGPAHIFJEPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x7E11040", Offset = "0x7E0F840", VA = "0x187E11040")]
		private void LEHPNFOBNFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x7E11450", Offset = "0x7E0FC50", VA = "0x187E11450")]
		private void MDINLCFPJDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x7E15210", Offset = "0x7E13A10", VA = "0x187E15210")]
		public PlayerFacialAnimatorBase()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0xA55AC0", Offset = "0xA542C0", VA = "0x180A55AC0", Slot = "4")]
		private bool LNOMDLNGNMA()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct BDIMBPLNLPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public string NCBGIDALPJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public int FIOOAILODJA;
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
		private struct EILFKGNGINF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004EF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004F0")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004F1")]
			public PlayerModernBodyEditorAvatarValidator <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004F2")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003E6")]
			[Cpp2IlInjected.Address(RVA = "0x7E081E0", Offset = "0x7E069E0", VA = "0x187E081E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E7")]
			[Cpp2IlInjected.Address(RVA = "0xA86C20", Offset = "0xA85420", VA = "0x180A86C20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000077")]
		[CompilerGenerated]
		private struct CDFOMBAPBFP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004F3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004F4")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004F5")]
			public PlayerModernBodyEditorAvatarValidator <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004F6")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003E8")]
			[Cpp2IlInjected.Address(RVA = "0x7E070F0", Offset = "0x7E058F0", VA = "0x187E070F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E9")]
			[Cpp2IlInjected.Address(RVA = "0x7E075E0", Offset = "0x7E05DE0", VA = "0x187E075E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public const string IDLE_ANIM_NAME = "Idle";

		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public const string A_POSE_ANIM_NAME = "A Pose";

		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public const string ANIMATION_OVERRIDE_STATE_NAME = "Override";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public CJONCCGGHCH avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public Color hairPrimaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public Color hairSecondaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public Color beardPrimaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public Color beardSecondaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public Color skinColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public int faceShapeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public int bodyShapeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public int hairPatternIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public int beardPatternIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public AvatarFaceShape[] faceShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public AvatarBodyShape[] bodyShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public AvatarHairPattern[] hairPatterns;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public float _avatarScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public bool enablePosing;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public int poseIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public AnimationClip animationOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		[Range(0f, 4f)]
		public float animationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public ODBDPJODIME useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public CPOALKJLKJO hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public GLDFLNAFMAP HatAnchorRestrictions;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public bool UseHairFitMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD1")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public bool usesHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public GameObject hatPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public GameObject hairPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public GameObject earPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public GameObject eyePrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public GameObject mouthPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public GameObject neckPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public GameObject shirtPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public GameObject beltPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public GameObject shoulderPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public GameObject rightHandPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public GameObject leftHandPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public GameObject legsPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public GameObject feetPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public long baseSkinCullingMask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		[GKBMICLOBGF(CGAFHOMJNOP.Self, false, false, false)]
		[SerializeField]
		public PlayerAvatarDisplayBase _avatarDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		private OAEBMBIDNEB KPJAEDIFLBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		[SerializeField]
		[GKBMICLOBGF(CGAFHOMJNOP.Self, false, false, false)]
		public PlayerFacialAnimatorBase facialAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public AnimationClip animationClipToOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		private AnimatorOverrideController EHCMLFHCCLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		private List<KeyValuePair<AnimationClip, AnimationClip>> HLGEJPPNELN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public Transform headIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public Transform leftHandIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public Transform rightHandIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		[Range(0f, 2f)]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public int rightHandGestureStateIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		[Range(0f, 1f)]
		public float rightHandCurl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public int leftHandGestureStateIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		[Range(0f, 1f)]
		public float leftHandCurl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public int eyeBrowSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public int eyeSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public int noseSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public int mouthSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public float eyeBrowPositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public float eyeBrowPositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public float eyeBrowScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public float eyePositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public float eyePositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public float eyeScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D4")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public float nosePositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public float noseScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1DC")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public float mouthPositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public float mouthPositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E4")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public float mouthScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public float hatNormalizedPositionX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EC")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public float hatNormalizedPositionY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public Vector3 hatHemispherePositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1FC")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public Vector3 hatHemisphereRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public int facialExpressionIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20C")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		[Range(0f, 1f)]
		public float normalizedTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public readonly BDIMBPLNLPB[] FacialExpressions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public readonly string[] BodyPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public readonly (string, BHFEFPLJLMD)[] HandPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public bool hideLeftWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x229")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public bool hideRightWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22A")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		protected bool NEFGIMNFAEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22C")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		protected Guid PDADAOCAKLM;

		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		protected static Guid BEAIBMCJOBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		private MEKGIBHCPGB KHCINGPIIKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		private DEJGECFFKMC DMLEKOPKHED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		private KKBENOBLINI BNKBIKALFEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		private KKBENOBLINI KAJBMDAPDBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		private AdditionalHatData IIKKJGHKPHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		private readonly Dictionary<GameObject, OANMLALNFNA> BHKBECIGOJO;

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		public static Func<FLMOPOMFAIA> KOGCMKOJONJ
		{
			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0x7E1A730", Offset = "0x7E18F30", VA = "0x187E1A730")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0x7E1AD70", Offset = "0x7E19570", VA = "0x187E1AD70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public bool HPANLFOHLJN
		{
			[Cpp2IlInjected.Token(Token = "0x60003B6")]
			[Cpp2IlInjected.Address(RVA = "0x7E1A890", Offset = "0x7E19090", VA = "0x187E1A890")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public bool CFKJOEDKGJJ
		{
			[Cpp2IlInjected.Token(Token = "0x60003B7")]
			[Cpp2IlInjected.Address(RVA = "0x7E1A780", Offset = "0x7E18F80", VA = "0x187E1A780")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public PlayerAvatarDisplayBase HLKMEHLOBIC
		{
			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0xB33C60", Offset = "0xB32460", VA = "0x180B33C60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		protected static Guid BFJEBJLHCAD
		{
			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x7E17330", Offset = "0x7E15B30", VA = "0x187E17330")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		public (GameObject, AMKHIMALNFB)[] FMGIAIFOEAL
		{
			[Cpp2IlInjected.Token(Token = "0x60003D0")]
			[Cpp2IlInjected.Address(RVA = "0x7E1A9A0", Offset = "0x7E191A0", VA = "0x187E1A9A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x7E184B0", Offset = "0x7E16CB0", VA = "0x187E184B0")]
		[ContextMenu("Refresh Avatar")]
		private void RebuildTestAvatarContextMenu()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x7E169A0", Offset = "0x7E151A0", VA = "0x187E169A0")]
		private IEnumerable<GameObject> FHADMLNPECP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x7E189A0", Offset = "0x7E171A0", VA = "0x187E189A0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x7E16810", Offset = "0x7E15010", VA = "0x187E16810")]
		private void DAONIFEKMNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x1369680", Offset = "0x1367E80", VA = "0x181369680")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x7E174B0", Offset = "0x7E15CB0", VA = "0x187E174B0")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x7E189B0", Offset = "0x7E171B0", VA = "0x187E189B0")]
		public void Teardown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x7E187A0", Offset = "0x7E16FA0", VA = "0x187E187A0")]
		public void ShowPose(AnimationClip KMAMDOOHJOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x7E18970", Offset = "0x7E17170", VA = "0x187E18970")]
		public void ShowPose(string LINFFPFCOAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x7E18600", Offset = "0x7E16E00", VA = "0x187E18600")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x7E184C0", Offset = "0x7E16CC0", VA = "0x187E184C0")]
		public void ResetHandPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x7E19480", Offset = "0x7E17C80", VA = "0x187E19480")]
		public void UpdateHandAnimation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x7E192D0", Offset = "0x7E17AD0", VA = "0x187E192D0")]
		public void UpdateFaceAndBodyShapes(bool BFCEAMOBHKH = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x7E19880", Offset = "0x7E18080", VA = "0x187E19880")]
		public void UpdateNoseShape(HJAEKHPBLDG DHBONOABFMP, bool BFCEAMOBHKH = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x7E19850", Offset = "0x7E18050", VA = "0x187E19850")]
		public void UpdateLODOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x7E17C80", Offset = "0x7E16480", VA = "0x187E17C80", Slot = "4")]
		protected virtual void MNDECODFPFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x7E17F80", Offset = "0x7E16780", VA = "0x187E17F80", Slot = "5")]
		protected virtual void NMAIPHIDOJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x7E15D90", Offset = "0x7E14590", VA = "0x187E15D90")]
		public void ApplyHatData(AdditionalHatData ODNEDPAIDBP, bool NEEGJINAIAJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x7E15BD0", Offset = "0x7E143D0", VA = "0x187E15BD0")]
		public void ApplyHatAdjustmentsToHatAnchorParams()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x7E160F0", Offset = "0x7E148F0", VA = "0x187E160F0")]
		public void ApplyHatUVOverride(Vector2 FGLDOPBENFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x7E16010", Offset = "0x7E14810", VA = "0x187E16010")]
		public void ApplyHatPositionAdjustment(Vector3 OPPLEKFBBHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x7E16080", Offset = "0x7E14880", VA = "0x187E16080")]
		public void ApplyHatRotationAdjustment(Vector3 LJKNEKCOOFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x7E16160", Offset = "0x7E14960", VA = "0x187E16160")]
		public MGAECJPIAGF BuildAvatarItemSelection(GameObject GLALDMENNJH, CJONCCGGHCH DDFBAFHFINE, AMKHIMALNFB PDGAOLJEHNA)
		{
			return default(MGAECJPIAGF);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x7E16200", Offset = "0x7E14A00", VA = "0x187E16200")]
		public void BuildAvatar(bool BFCEAMOBHKH = false, bool NEEGJINAIAJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x7E18D10", Offset = "0x7E17510", VA = "0x187E18D10")]
		public void UpdateColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x7E15D10", Offset = "0x7E14510", VA = "0x187E15D10")]
		public void ApplyHatAnchor()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x7E196A0", Offset = "0x7E17EA0", VA = "0x187E196A0")]
		public void UpdateHatAnchor(bool NEEGJINAIAJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x7E193D0", Offset = "0x7E17BD0", VA = "0x187E193D0")]
		[AsyncStateMachine(typeof(EILFKGNGINF))]
		public void UpdateFaceFeatures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x7E17BB0", Offset = "0x7E163B0", VA = "0x187E17BB0")]
		[AsyncStateMachine(typeof(CDFOMBAPBFP))]
		private Task KAKMDNKILPC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x7E181F0", Offset = "0x7E169F0", VA = "0x187E181F0")]
		private void PINNJCBFJKF(FaceFeatureType GMDJKCMLNPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x7E17420", Offset = "0x7E15C20", VA = "0x187E17420")]
		private void IMLKAKEDLHB(FaceFeatureType GMDJKCMLNPH, [Out] float NKDFDBINJFF, [Out] float FPLEJFJAKKH, [Out] float DKMKOJPHLDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x7E19190", Offset = "0x7E17990", VA = "0x187E19190")]
		public void UpdateEmote()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x7E19530", Offset = "0x7E17D30", VA = "0x187E19530")]
		public void UpdateHandPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x7E16E10", Offset = "0x7E15610", VA = "0x187E16E10")]
		private void FOKPNMEHBAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
		private void OBDHOHHJKOA(OANMLALNFNA JCNEIFHNADD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
		private void PGOFMIHJBBC(OANMLALNFNA JCNEIFHNADD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x7E15870", Offset = "0x7E14070", VA = "0x187E15870")]
		private void ABMICDDMOOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x7E19900", Offset = "0x7E18100", VA = "0x187E19900")]
		public PlayerModernBodyEditorAvatarValidator()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x7E168F0", Offset = "0x7E150F0", VA = "0x187E168F0")]
		[CompilerGenerated]
		private MGAECJPIAGF DLHGNECIJKP((GameObject, AMKHIMALNFB) KAOEKJPANJK)
		{
			return default(MGAECJPIAGF);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class SkinnedMeshBonesInspector : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		[GKBMICLOBGF(CGAFHOMJNOP.Self, false, false, false)]
		[SerializeField]
		private SkinnedMeshRenderer skinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		[SerializeField]
		private int BoneWeightsDisplayStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		[SerializeField]
		private int BoneWeightsDisplayAmount;

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0xA28D30", Offset = "0xA27530", VA = "0x180A28D30")]
		public SkinnedMeshBonesInspector()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct MGAECJPIAGF
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class KFPMLIJLHED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		public IEnumerable<OutfitType> otherOutfitTypes;

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public KFPMLIJLHED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x7E0D2F0", Offset = "0x7E0BAF0", VA = "0x187E0D2F0")]
		internal bool AJMOKJEHDNI(OutfitType outfitType)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	private OANMLALNFNA FMEPAJPBPMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	private AMKHIMALNFB EGGNEGMMNKE;

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public OANMLALNFNA KMMGJGLCMAD
	{
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public AMKHIMALNFB IKMAIEDBJHE
	{
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0xDB8C20", Offset = "0xDB7420", VA = "0x180DB8C20")]
		get
		{
			return default(AMKHIMALNFB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public string BLEGDBJIHDD
	{
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x7E0D640", Offset = "0x7E0BE40", VA = "0x187E0D640")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool CGKNOGLHDPF
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x7E0D7F0", Offset = "0x7E0BFF0", VA = "0x187E0D7F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public bool LENFPMJNLCI
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x7E0D840", Offset = "0x7E0C040", VA = "0x187E0D840")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x18D8EE0", Offset = "0x18D76E0", VA = "0x1818D8EE0")]
	public MGAECJPIAGF(OANMLALNFNA JCNEIFHNADD, AMKHIMALNFB BHONCPBICBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x7E0D730", Offset = "0x7E0BF30", VA = "0x187E0D730")]
	public bool DLIEJPAPOGM(OutfitType HPDHCNEFDEG, AMKHIMALNFB NPMMBJADAEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x7E0DA80", Offset = "0x7E0C280", VA = "0x187E0DA80")]
	public bool JCHFJBBDNJN(OutfitType HPDHCNEFDEG, AMKHIMALNFB NPMMBJADAEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x7E0D890", Offset = "0x7E0C090", VA = "0x187E0D890")]
	public bool GMGHGCCJCPD(MGAECJPIAGF OFFLLGDBGAL)
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
