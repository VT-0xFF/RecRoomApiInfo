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
	public class LogRegistrationIndex : FNHPAIPGMGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7BDA460", Offset = "0x7BD9260", VA = "0x187BDA460", Slot = "4")]
		public override void KEMEJJLNDFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA0ECA0", Offset = "0xA0DAA0", VA = "0x180A0ECA0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override string AssetGUID
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x7BDDDA0", Offset = "0x7BDCBA0", VA = "0x187BDDDA0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7BDDD30", Offset = "0x7BDCB30", VA = "0x187BDDD30", Slot = "17")]
		public override bool RuntimeKeyIsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7BDDD60", Offset = "0x7BDCB60", VA = "0x187BDDD60")]
		public RecNetCDNAssetReference(RecNetCDNKey MAKJJJECHHB)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class RecNetCDNKey
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public enum DJAJPFOOBBN : byte
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
			[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string UniqueItemIdentifier
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string CacheHash
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xA0CC40", Offset = "0xA0BA40", VA = "0x180A0CC40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RecNetCDNKey Dependency
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xA0EAC0", Offset = "0xA0D8C0", VA = "0x180A0EAC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xA12900", Offset = "0xA11700", VA = "0x180A12900")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool AttemptPrecacheLookup
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xA36F20", Offset = "0xA35D20", VA = "0x180A36F20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA36E80", Offset = "0xA35C80", VA = "0x180A36E80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public DJAJPFOOBBN PathHint
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xDD4380", Offset = "0xDD3180", VA = "0x180DD4380")]
			[CompilerGenerated]
			get
			{
				return default(DJAJPFOOBBN);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x1357120", Offset = "0x1355F20", VA = "0x181357120")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string ItemPath
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x7BDDEB0", Offset = "0x7BDCCB0", VA = "0x187BDDEB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7BDDE30", Offset = "0x7BDCC30", VA = "0x187BDDE30")]
		public static RecNetCDNKey MAIHPMBNJGI(string MCNOBJLDBGF, DJAJPFOOBBN JJIAKHJFNNO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7BDDDE0", Offset = "0x7BDCBE0", VA = "0x187BDDDE0")]
		public void EHMLMELBION(string CLMDDMNPGHL, string CHKEMFCNGMN, bool CGDONHPCAAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public RecNetCDNKey()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DOEGHAPPEHM]
public class NCJGADDIAMJ : EIHKDALLJCO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	protected readonly List<Mesh> IBJDKJAKPHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	protected readonly List<byte[]> FHCKNMJHEEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	protected readonly List<Matrix4x4> CHLGHCPHAFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	protected readonly List<bool> MBBJEMBPHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	protected readonly List<long> DIGEPDKAFEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	protected readonly List<bool> FFCGBNNGJFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	protected readonly List<int> JKABJIGBCNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	protected Allocator CBLKGIEKNKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected DCPCHOGDPLH PEGKNMLFPGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected byte MONCKPNHDAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected IList<int> FEJKIILGOFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected IList<int> GAIOBIGKJJD;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7BDA530", Offset = "0x7BD9330", VA = "0x187BDA530", Slot = "4")]
	public void GNBMLOPAJID(Mesh JIEGCDEFFGO, Matrix4x4 MGGDGJPMBBJ, byte[] ILEDGFFJKMK, bool KLLMIGFFCBP = false, JICHGCEFAAI.NNADHONNNIJ MEFCLCAAJBO = (JICHGCEFAAI.NNADHONNNIJ)0L, int BIGNHIBKBAK = -1, bool GADNNPKNJDH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7BDA4F0", Offset = "0x7BD92F0", VA = "0x187BDA4F0", Slot = "5")]
	public void ALACKKIJAED(Allocator LNMGNHHGHLL, DCPCHOGDPLH GNGFDKFFBEH, byte NKAJHNKOMIJ, [Optional] IList<int> BMCIOFDAFKE, [Optional] IList<int> IBHANKPKCOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7BDA7B0", Offset = "0x7BD95B0", VA = "0x187BDA7B0")]
	private static void JGCPKBPDMMA(Mesh JIEGCDEFFGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7BDAA10", Offset = "0x7BD9810", VA = "0x187BDAA10")]
	public NCJGADDIAMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[DOEGHAPPEHM]
public struct DMJNKNPEDPG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	[ReadOnly]
	public AIAOFNJLGAH LMEPIIEACAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[ReadOnly]
	public int EJCIIHONOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public NCPDDKCEFFD NAGODCCNKLK;

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7BD84E0", Offset = "0x7BD72E0", VA = "0x187BD84E0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[NativeContainer]
[DOEGHAPPEHM]
public struct NCPDDKCEFFD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct DEIPKOIPCCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Vector3 HKPHOPMHFNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public Vector3 KODPDAPHGHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public Vector4 PLJNDIABGEJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct CKNALCDLHIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public float GEHEEEGNACF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public float HKLBPLNGECA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public float AFNGPBIENDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public float GPONEHKJCGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public byte LDNEKIGAGBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public byte BDNCJFFBIMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public byte OLJAIKMGMFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public byte FGPINAJBMOG;
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct LJMKIBGJBBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public half GEHEEEGNACF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public half HKLBPLNGECA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public half AFNGPBIENDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public half GPONEHKJCGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public byte LDNEKIGAGBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public byte BDNCJFFBIMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public byte OLJAIKMGMFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public byte FGPINAJBMOG;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct BGDMIPMLGMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public half4 DEJLIDMJHPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public half2 MONCDGAACLA;
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct LIGJBMJMJKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public half4 DEJLIDMJHPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public half2 MONCDGAACLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public half2 CNNNKJLIAGD;
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct AFCBDMDLEHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public half4 DEJLIDMJHPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public half2 MONCDGAACLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public half2 CNNNKJLIAGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public half2 IHDMOHGPMJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct KCPDOFNHMAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public half4 DEJLIDMJHPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public half2 MONCDGAACLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public half2 CNNNKJLIAGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public half2 IHDMOHGPMJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public half2 GGIDHGHANPD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct MCEJKIPBCHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public float GEHEEEGNACF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public float HKLBPLNGECA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public float AFNGPBIENDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public float GPONEHKJCGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int LDNEKIGAGBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int BDNCJFFBIMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int OLJAIKMGMFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int FGPINAJBMOG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct IKEEOANPCGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Color DEJLIDMJHPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Vector2 MONCDGAACLA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct NHNCIAPDOAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Color DEJLIDMJHPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Vector2 MONCDGAACLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Vector2 CNNNKJLIAGD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct EAMMDEMAJAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Color DEJLIDMJHPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Vector2 MONCDGAACLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Vector2 CNNNKJLIAGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Vector2 IHDMOHGPMJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct FOFGKEFBBMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Color DEJLIDMJHPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Vector2 MONCDGAACLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Vector2 CNNNKJLIAGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Vector2 IHDMOHGPMJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Vector2 GGIDHGHANPD;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private bool CAKPEKGLJIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<DEIPKOIPCCN> KNPKHEFKGMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<BGDMIPMLGMA> EIGNAMMGLMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<LIGJBMJMJKC> NAFDNPPJKNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<AFCBDMDLEHI> KFIPLMALLFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<KCPDOFNHMAK> HGJMBBLBELM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<LJMKIBGJBBL> CAOMGNPFFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<CKNALCDLHIJ> FLGDDEJIDNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NativeArray<IKEEOANPCGA> IGDGMDPNADG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NativeArray<NHNCIAPDOAC> JEDFMIEAMJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public NativeArray<EAMMDEMAJAK> PBLIMMIEHOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public NativeArray<FOFGKEFBBMI> AFCNHGJFJIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public NativeArray<MCEJKIPBCHN> CNLOJNCAMBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public NativeArray<int> PHIPBKFLOOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public NativeArray<int> GFEEEPPFGAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private NativeArray<int> MKCPOJLLACD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NativeArray<int> HLFJGHJCOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<int> OOKAHKGHCFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public NativeArray<int> HBJKEDPKPCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public NativeArray<int> PCFANJPDPBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public NativeArray<BoneWeight> JDBFDBGCGCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeArray<int> CNCKIIIBBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private bool KAKCMBKODOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x159")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private bool HBOGFMBJOAD;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int DOBEAMFNJFE
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7BDACF0", Offset = "0x7BD9AF0", VA = "0x187BDACF0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7BDAFE0", Offset = "0x7BD9DE0", VA = "0x187BDAFE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int MJGOALKKNGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7BDBB60", Offset = "0x7BDA960", VA = "0x187BDBB60")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7BDB390", Offset = "0x7BDA190", VA = "0x187BDB390")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int EJHGFNKJFKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7BDAFF0", Offset = "0x7BD9DF0", VA = "0x187BDAFF0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7BDAD00", Offset = "0x7BD9B00", VA = "0x187BDAD00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int BLAKBNACKEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7BDAD10", Offset = "0x7BD9B10", VA = "0x187BDAD10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7BDCFB0", Offset = "0x7BDBDB0", VA = "0x187BDCFB0")]
	public NCPDDKCEFFD(int IOJMPGFAGPL, int MEDCOGJPDKK, int LDKCNDCDIOM, int OAAONBEOFLP, Allocator LNMGNHHGHLL, int KCNNAKHDAOL, ANBCPHBNMOJ GGDKDJOKDAO, bool KAKCMBKODOD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7BDAC60", Offset = "0x7BD9A60", VA = "0x187BDAC60")]
	public void AHJBJAADLNA(int GLAOLHCPLLG, Vector3 LCFJFNFOMKB, Vector3 KACKFEMGFCF, Vector4 JIJABGNNHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7BDCB80", Offset = "0x7BDB980", VA = "0x187BDCB80")]
	public void PLBAEKFHEIN(int GLAOLHCPLLG, BoneWeight OJDICKPPGNL, NativeSlice<byte> ILEDGFFJKMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7BDB060", Offset = "0x7BD9E60", VA = "0x187BDB060")]
	public Color IHIMDAJOKGM(int GLAOLHCPLLG)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7BDB760", Offset = "0x7BDA560", VA = "0x187BDB760")]
	public void KOIHOIGMCMB(int GLAOLHCPLLG, Color KMBJNMDOLGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7BDB3A0", Offset = "0x7BDA1A0", VA = "0x187BDB3A0")]
	public void JPBPCKEKCHL(byte NLGDMKIKEEP, int GLAOLHCPLLG, Vector2 LMCDMGEBKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7BDB750", Offset = "0x7BDA550", VA = "0x187BDB750")]
	public void KMMLPIJLHKI(int GLAOLHCPLLG, int DHBPNNGGPNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7BDB000", Offset = "0x7BD9E00", VA = "0x187BDB000")]
	public bool GMHOMDCKJGN(int NLGDMKIKEEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7BDBB70", Offset = "0x7BDA970", VA = "0x187BDBB70")]
	public void NEKOLNMDOEA(int IJCIAAHJLIC, int PPPFIBNDOMK, int NPCJGIOCILE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7BDAD80", Offset = "0x7BD9B80", VA = "0x187BDAD80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7BDBC40", Offset = "0x7BDAA40", VA = "0x187BDBC40")]
	public Mesh PJMKBIHGNDJ([Optional] string GLMIDHCLHAB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
[DOEGHAPPEHM]
[NativeContainer]
public struct AIAOFNJLGAH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public Mesh.MeshDataArray LGBFINPMGJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public NativeArray<int> AMCDIDBPEOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public NativeArray<int> ONEDEMEMOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public NativeArray<BoneWeight> JDBFDBGCGCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private NativeArray<Matrix4x4> KHHJPFNGHKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private NativeArray<long> DCCLJBIKMBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private NativeArray<byte> MPKMJMHNBHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private NativeArray<int> EDFKOJFJMIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private NativeArray<int> ILCDFFCJILO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public NativeArray<sbyte> CLIKODHGOAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public NativeArray<byte> IPBGGOJMBNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public NativeArray<bool> GADNNPKNJDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NativeArray<int> BIGNHIBKBAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private bool KAKCMBKODOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeArray<int> KFDICACNJIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private bool HBOGFMBJOAD;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int GNGEKNLJMIK
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7BC8310", Offset = "0x7BC7110", VA = "0x187BC8310")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int KBALHAHBJOM
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7E10", Offset = "0x7BC6C10", VA = "0x187BC7E10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int OEGLBEJHLDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7FF0", Offset = "0x7BC6DF0", VA = "0x187BC7FF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int LODJBLFPPHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7BC8350", Offset = "0x7BC7150", VA = "0x187BC8350")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7FE0", Offset = "0x7BC6DE0", VA = "0x187BC7FE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int DOBEAMFNJFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7E20", Offset = "0x7BC6C20", VA = "0x187BC7E20")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7FD0", Offset = "0x7BC6DD0", VA = "0x187BC7FD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int NNHPOBJJOGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7BC8330", Offset = "0x7BC7130", VA = "0x187BC8330")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7BC8340", Offset = "0x7BC7140", VA = "0x187BC8340")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public DCPCHOGDPLH GNEANCAPCFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7E40", Offset = "0x7BC6C40", VA = "0x187BC7E40")]
		get
		{
			return default(DCPCHOGDPLH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7BC8320", Offset = "0x7BC7120", VA = "0x187BC8320")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public byte LLMIOFLOCGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7BC8360", Offset = "0x7BC7160", VA = "0x187BC8360")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7E30", Offset = "0x7BC6C30", VA = "0x187BC7E30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public EPECOHDABLP ANMDDLMJFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7BC80C0", Offset = "0x7BC6EC0", VA = "0x187BC80C0")]
		get
		{
			return default(EPECOHDABLP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7BC8440", Offset = "0x7BC7240", VA = "0x187BC8440")]
	public AIAOFNJLGAH(IList<Mesh> IANPBMCBCDG, IList<Matrix4x4> OIENDOJDPCI, IList<bool> GADNNPKNJDH, byte NKAJHNKOMIJ, IList<byte[]> EJIEIGOGAJG, IList<long> DNCKFAPENEG, IList<bool> HEFCFNAIHDJ, IList<int> BIGNHIBKBAK, IList<int> BMCIOFDAFKE, IList<int> ANAIIDAGDDE, Allocator LNMGNHHGHLL, DCPCHOGDPLH GNGFDKFFBEH, bool KAKCMBKODOD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7BC8370", Offset = "0x7BC7170", VA = "0x187BC8370")]
	public NCPDDKCEFFD PHGPPABDMKL(Allocator LNMGNHHGHLL, ANBCPHBNMOJ GGDKDJOKDAO)
	{
		return default(NCPDDKCEFFD);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7E50", Offset = "0x7BC6C50", VA = "0x187BC7E50", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DOEGHAPPEHM]
public class HEOBHDKOKLH : NCJGADDIAMJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public bool GEBILMOPJDD;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly ProfilerMarker APLIJOEPADC;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7BD9FA0", Offset = "0x7BD8DA0", VA = "0x187BD9FA0")]
	public AIAOFNJLGAH PENNMMDGFNO()
	{
		return default(AIAOFNJLGAH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7BDA260", Offset = "0x7BD9060", VA = "0x187BDA260")]
	public HEOBHDKOKLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct EPECOHDABLP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public Mesh.MeshData OFPDGGHOEMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public NativeSlice<BoneWeight> JDBFDBGCGCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public NativeSlice<byte> DAOCNPDDMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public int LFPLIOMDKCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public Matrix4x4 GAFMJNFCNKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public long BMJNMGODCHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public NativeSlice<byte> ILEDGFFJKMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public bool FDMKNANIKOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public int FHOHBGOHBDK;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class ANNGEIDPJJP : IGHDDCGAHHH
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class ACNEKHHDLJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public LMPPDFIGPDH avatarBuildParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public ANNGEIDPJJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public OJJOHCMLHDB buildMeshPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public Action<KeyValuePair<string, EHIFMMNJMNN<Texture2D>>> <>9__19;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public ACNEKHHDLJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7BC0", Offset = "0x7BC69C0", VA = "0x187BC7BC0")]
		internal bool CMAPHLJDKDD(KDOBCGFCCMB item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7C10", Offset = "0x7BC6A10", VA = "0x187BC7C10")]
		internal void DENIOKJICKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7BA0", Offset = "0x7BC69A0", VA = "0x187BC7BA0")]
		internal void CAGIDBAOGCL(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7C10", Offset = "0x7BC6A10", VA = "0x187BC7C10")]
		internal void HIACOOPAGEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7BA0", Offset = "0x7BC69A0", VA = "0x187BC7BA0")]
		internal void AMPJIMAJGLO(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7C30", Offset = "0x7BC6A30", VA = "0x187BC7C30")]
		internal void IOHJJGKFFMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7D20", Offset = "0x7BC6B20", VA = "0x187BC7D20")]
		internal void LDANECBGMIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7D50", Offset = "0x7BC6B50", VA = "0x187BC7D50")]
		internal void PGIHHFKDPML(Dictionary<string, EHIFMMNJMNN<Texture2D>> resourceHandleDictionary)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7C60", Offset = "0x7BC6A60", VA = "0x187BC7C60")]
		internal void JIGINJNLIOD(KeyValuePair<string, EHIFMMNJMNN<Texture2D>> kvp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
		internal AAFDGGPNGMA LOBLBGIKNKP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class LLOAJBPPFGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public int lowestPossibleLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public ACNEKHHDLJK CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public LLOAJBPPFGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7BDA3A0", Offset = "0x7BD91A0", VA = "0x187BDA3A0")]
		internal AMBPMCJIDIO BAGLBNDLNIH(int lod)
		{
			return default(AMBPMCJIDIO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class CNOMGIGABMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public HMBEFKLHMDK<Dictionary<string, EHIFMMNJMNN<Texture2D>>> ugcTextureDictionaryPromise;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public CNOMGIGABMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		internal HMBEFKLHMDK<Dictionary<string, EHIFMMNJMNN<Texture2D>>> PPEAGFHOIDH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class JOFAMKOCIJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public List<OJJOHCMLHDB> innerPromises;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public JOFAMKOCIJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x7BDA270", Offset = "0x7BD9070", VA = "0x187BDA270")]
		internal void MEJNAILJMMN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class PMDCFEDNLFH : IEnumerator<GCOFLMDGPIM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private GCOFLMDGPIM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public bool shouldWait;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public ANNGEIDPJJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public List<PDINNKEAMLI> parts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public List<OJJOHCMLHDB> innerPromises;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public bool isFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public Func<int, AMBPMCJIDIO> getLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public IIPKPBDAJNG materialPropertyBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public Material materialInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private int <lodIndex>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private GCOFLMDGPIM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xA10020", Offset = "0xA0EE20", VA = "0x180A10020")]
		[DebuggerHidden]
		public PMDCFEDNLFH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7BDD9E0", Offset = "0x7BDC7E0", VA = "0x187BDD9E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7BDDC60", Offset = "0x7BDCA60", VA = "0x187BDDC60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class PEDOAFMHOCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public HAPIPDPKHDI cancelable;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public PEDOAFMHOCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0xAB6590", Offset = "0xAB5390", VA = "0x180AB6590")]
		internal void HFIPLEOMGPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0xD0B200", Offset = "0xD0A000", VA = "0x180D0B200")]
		internal void HNBAEILGAKB(string err)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class LFPLCAFNDPF
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
		public ANNGEIDPJJP <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public LFPLCAFNDPF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class BNOKGNNGBDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public NCPDDKCEFFD defaultMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public AIAOFNJLGAH defaultAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public LFPLCAFNDPF CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public BNOKGNNGBDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x7BD8060", Offset = "0x7BD6E60", VA = "0x187BD8060")]
		internal void LBJCNPHBKAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x12A14A0", Offset = "0x12A02A0", VA = "0x1812A14A0")]
		internal void LMJOBPHDNKP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class CHEMPICKHEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public CIJJMCHENDN legacyMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public GDHHDFPGJIN legacyAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public LFPLCAFNDPF CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public CHEMPICKHEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7BD82A0", Offset = "0x7BD70A0", VA = "0x187BD82A0")]
		internal void MBAHBHBJPJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x12A3610", Offset = "0x12A2410", VA = "0x1812A3610")]
		internal void AKNFNCBFACJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class PMPGHCIBGCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public string overrideItemIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public HHFLIOCEMDF overrideBodyPart;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public PMPGHCIBGCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7BDDCB0", Offset = "0x7BDCAB0", VA = "0x187BDDCB0")]
		internal bool PHBDJFHBKIM(KeyValuePair<string, KDOBCGFCCMB> entry)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly LLEAAEBCCKF ANNBAMEHEEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly LLEAAEBCCKF OMBLDGHKNGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Dictionary<LOCPCPHLCCB, float> PJJFODGEAFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private Dictionary<KIEGMEAMIFO, float> FJFKKAHGCBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Dictionary<INHKJJEFEGH, float> JFAPKDFCNGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private IReadOnlyDictionary<string, BEJGKABPDLA> NAJBIKMHKJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Dictionary<string, BEJGKABPDLA> GPKJBOKDOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Dictionary<string, BEJGKABPDLA> BIEOIMNKOBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private Dictionary<string, BEJGKABPDLA> NDCLNJNHIAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private BHPMKNNFDOB OHCFOOALFCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private BHPMKNNFDOB LGGDMDHDIJB;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static float DLFPLHNKCHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private bool? JCALHKIEELP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x62")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private bool? NPBCNGMNOLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private bool? FMOCOHGGAIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x66")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private bool? HDMKGLBBFDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private AvatarConfiguration MPOLNPNNIGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private Transform NFCFJCOBLNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private AvatarSkinAssetItem MIKMMFCIPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private AssetReference LBIMKNADINB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private GameObject NBIPGEFFHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private GameObject JPAPKHGGCJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private SkinnedMeshRenderer EBLPFMLKABH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private AvatarSkinnedMeshBoneOrderRemapsData LHFABAPNLAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private Transform[] OHJKLMIOMLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private Matrix4x4[] LPFGFJGPGHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private Material EDEBLMMPMJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private Material IIELIOCJFFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private Material KCALJKMHLOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private Material FPEOPCJOHGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private Shader FEKHLBHMPIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Shader HKCKBCMEHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private Animator JMPIAHLHMEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private Renderer[] MNDLBNDMOFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private JICHGCEFAAI.NNADHONNNIJ LMGKFBPOLJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private AvatarBodyPartShapesManager MGLLPJGOIAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private IReadOnlyDictionary<string, Transform> LCMGJHHJGEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private AvatarFaceShapeData.NHODMBGPCDK PACPBPOEBJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private AvatarBodyShapeData.CAPOGDIJEHA LFBGAFLBDIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private GEMMNCOLLPK NHOILFODHFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private bool HNIIEACKIEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11D")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private bool OPFHIIGCADE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private Color CDKOOKFLKPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private Color MBCAEDDEMDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private Color JAODHIDOAEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private Color? OJJOCDMOPCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x164")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private Color? MBGGFOPIKAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private Color? HFHFACMBCBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private Color? EAPDJOCACOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private Texture2D ALANNBPCGII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private Texture2D PJAPOCCNFMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	[CanBeNull]
	private KDOBCGFCCMB BKLBFNNJOIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private Texture NDPFCNKMFHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private Color LODJMBCHAKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public Dictionary<Renderer, IIPKPBDAJNG> ODPEMCPBPEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private Dictionary<Renderer, IIPKPBDAJNG> NLLHAONECPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private Dictionary<string, List<GPPMDKPHMGP>> LKABDDHOKON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private Dictionary<string, List<GPPMDKPHMGP>> FKENLPGIIAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly List<EPIKNCDFKGD> DGGOKPJGOLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly List<EPIKNCDFKGD> DLMFAFJECNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly List<EPIKNCDFKGD> ENPPKBKCOKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly List<EPIKNCDFKGD> LGEHIIAJFBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private Dictionary<GPPMDKPHMGP, Material> LHMEAGEGLPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private Dictionary<GPPMDKPHMGP, Material> JNBFJGCEHCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private SkinnedMeshRenderer[] NIIANDFNGHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private SkinnedMeshRenderer[] CGFFBKKAEFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private SkinnedMeshRenderer[] EDHNIKDMCFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private SkinnedMeshRenderer[] OHLAHAJBOPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly Dictionary<string, EHIFMMNJMNN<Texture2D>> PIMNCBEEGKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly Dictionary<string, EHIFMMNJMNN<Texture2D>> NBNDOGJALBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private AdditionalHatData KPHHEFJNKDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private AdditionalHatData AAMIMBGOEAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private HairData IICKCKLJAME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private HairData LPJFFDKNDFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private CAOCJKDHCLC MGGEOBGLLFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private bool? LKKPEOHBCOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x27C")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private PositionAndRotation JAKFADPFHJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private Transform HLCDDFILPII;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private Material HHBCPPEHJAJ;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private Material BDDMMPKAPDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private Dictionary<string, KDOBCGFCCMB> AOPBLJPLBDF;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static readonly int BFNAAPCJJDK;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static readonly int PEEDHBDBLMF;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly int OHPDNJOAKNH;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly int HGMOOECCGIG;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly int HMIJJGCEMLK;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly int MOLJAJAIEAP;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private static readonly int OHOHBALCGFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool MABKKLECBKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private List<Action> BJHJOHDFGHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private MNCBCAJDKJB IMPNJBFPIAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private SkinnedMeshRenderer[] LCNCNCFGMKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private int HMOKFGCFNNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2DC")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private bool MKDAJPGIHAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private int MBAHBPBPKDC;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public LLEAAEBCCKF LNIMDCHPPGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public LLEAAEBCCKF AGJHGLAGFDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private IPJEPIMCHKK FMBEDHKNIIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7BCB730", Offset = "0x7BCA530", VA = "0x187BCB730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool MJBFBPKFEPH
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7BD4360", Offset = "0x7BD3160", VA = "0x187BD4360")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private bool DDOFLCJCHEO
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7BD5840", Offset = "0x7BD4640", VA = "0x187BD5840")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private bool ADAKLAILKGH
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7BCC930", Offset = "0x7BCB730", VA = "0x187BCC930")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private bool OMNFJNFKLBH
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7BD2A60", Offset = "0x7BD1860", VA = "0x187BD2A60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public AvatarConfiguration AMKHKKEKGHE
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA0D040", Offset = "0xA0BE40", VA = "0x180A0D040", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool HKGOFOAEEKF
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7BD3990", Offset = "0x7BD2790", VA = "0x187BD3990")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7BCA2B0", Offset = "0x7BC90B0", VA = "0x187BCA2B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private Material EBCLIJBOBEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7BCC350", Offset = "0x7BCB150", VA = "0x187BCC350")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private Material LKPFDAPBAAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7BD1E70", Offset = "0x7BD0C70", VA = "0x187BD1E70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private bool GALFFMMILCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA24630", Offset = "0xA23430", VA = "0x180A24630")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public JBJPAOBCEOK BKHGFCJHLHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x26BA170", Offset = "0x26B8F70", VA = "0x1826BA170", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return default(JBJPAOBCEOK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x26AC3E0", Offset = "0x26AB1E0", VA = "0x1826AC3E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public Material FGIGFJENMND
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xCE6EA0", Offset = "0xCE5CA0", VA = "0x180CE6EA0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public SkinnedMeshRenderer[] ILBHANEJEHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x194C990", Offset = "0x194B790", VA = "0x18194C990", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public Renderer[] GBIIEPNBHBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xAC1A00", Offset = "0xAC0800", VA = "0x180AC1A00", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool KJEAFAFPAJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7BD3000", Offset = "0x7BD1E00", VA = "0x187BD3000", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public JICHGCEFAAI.NNADHONNNIJ NEFNKPOHHKL
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xAC1A10", Offset = "0xAC0810", VA = "0x180AC1A10", Slot = "20")]
		get
		{
			return default(JICHGCEFAAI.NNADHONNNIJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int IFBDELOGPLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x1237370", Offset = "0x1236170", VA = "0x181237370")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7BCCBF0", Offset = "0x7BCB9F0", VA = "0x187BCCBF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private bool KMHPFKKOMIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7BCC1F0", Offset = "0x7BCAFF0", VA = "0x187BCC1F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private static bool IAPOPOPFLBK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7BD11B0", Offset = "0x7BCFFB0", VA = "0x187BD11B0", Slot = "15")]
	public OJJOHCMLHDB HLGEIACNMGM(LMPPDFIGPDH ELLCBALOEMJ, bool KFHDBEBFAPC, int[] DEKFHJHJAFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7BD4330", Offset = "0x7BD3130", VA = "0x187BD4330", Slot = "14")]
	public OJJOHCMLHDB NNCMOJFOIAB(LMPPDFIGPDH ELLCBALOEMJ, bool KFHDBEBFAPC, int[] DEKFHJHJAFD, Func<Dictionary<string, KDOBCGFCCMB>, (OJJOHCMLHDB, HMBEFKLHMDK<Dictionary<string, EHIFMMNJMNN<Texture2D>>>)> HOGHNMGNICC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7BCE400", Offset = "0x7BCD200", VA = "0x187BCE400")]
	public OJJOHCMLHDB FNBAKHFPGKA(LMPPDFIGPDH ELLCBALOEMJ, bool KFHDBEBFAPC, int[] DEKFHJHJAFD, bool FEDGKOPKNFC, BHPMKNNFDOB KCDLDOMNDPB, [Optional] Func<Dictionary<string, KDOBCGFCCMB>, (OJJOHCMLHDB, HMBEFKLHMDK<Dictionary<string, EHIFMMNJMNN<Texture2D>>>)> HOGHNMGNICC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7BC9F80", Offset = "0x7BC8D80", VA = "0x187BC9F80")]
	private bool BBOGIJJMIPI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7BCDD10", Offset = "0x7BCCB10", VA = "0x187BCDD10")]
	private OJJOHCMLHDB FEMKOHOMGMG(bool KFHDBEBFAPC, List<PDINNKEAMLI> OIPAHHAIONO, int[] DEKFHJHJAFD, Func<int, AMBPMCJIDIO> IOCIOKAIDOJ, bool FEDGKOPKNFC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7BD12C0", Offset = "0x7BD00C0", VA = "0x187BD12C0")]
	[IteratorStateMachine(typeof(PMDCFEDNLFH))]
	private IEnumerator<GCOFLMDGPIM> HMIIBHPFHLB(bool KFHDBEBFAPC, List<PDINNKEAMLI> OIPAHHAIONO, int[] DEKFHJHJAFD, Func<int, AMBPMCJIDIO> IOCIOKAIDOJ, IIPKPBDAJNG FOLMANNOIEC, Material LECCGKLMLFA, List<OJJOHCMLHDB> MMKFJFFMCKJ, bool DGMDLOGDLNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7BCA540", Offset = "0x7BC9340", VA = "0x187BCA540")]
	private void CEHOCAKEANL(List<PDINNKEAMLI> OIPAHHAIONO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7BC9680", Offset = "0x7BC8480", VA = "0x187BC9680")]
	private OJJOHCMLHDB ADGAMLPCNDC(List<PDINNKEAMLI> OIPAHHAIONO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7BD44D0", Offset = "0x7BD32D0", VA = "0x187BD44D0")]
	private BGLABEGMMJM OKNCKABDAED(List<PDINNKEAMLI> OIPAHHAIONO, int JGJKFDFMJDO, bool KFHDBEBFAPC, AMBPMCJIDIO PBGGPJCBAMP, bool PJLMKCDMIIL, IIPKPBDAJNG FOLMANNOIEC, Material LECCGKLMLFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7BD0D50", Offset = "0x7BCFB50", VA = "0x187BD0D50", Slot = "27")]
	public void HGGPJFOHBMN(LOCPCPHLCCB LJIBJAKOMJA, float OAIIHELJHLG, bool BDNKGNDKMKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7BD11E0", Offset = "0x7BCFFE0", VA = "0x187BD11E0", Slot = "29")]
	public void HMEMCFAKKJM(KIEGMEAMIFO BHLNGJFAOFK, float OAIIHELJHLG, bool MGIPNNAINDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7BD1850", Offset = "0x7BD0650", VA = "0x187BD1850", Slot = "30")]
	public void IIANKLAKBFA(INHKJJEFEGH BIPIIAGGHDI, float OAIIHELJHLG, bool KLOOBJNPKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7BD2A00", Offset = "0x7BD1800", VA = "0x187BD2A00", Slot = "28")]
	public void KKDEGJCGJOM(bool NJKLNAKEBEI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7BCA4E0", Offset = "0x7BC92E0", VA = "0x187BCA4E0", Slot = "31")]
	public void CDCPIECIMHC(bool NJKLNAKEBEI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7BD1150", Offset = "0x7BCFF50", VA = "0x187BD1150", Slot = "32")]
	public void HHHHKPDONFM(bool NJKLNAKEBEI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7BD55E0", Offset = "0x7BD43E0", VA = "0x187BD55E0")]
	private void OOAJFMCJMBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7BCDAC0", Offset = "0x7BCC8C0", VA = "0x187BCDAC0")]
	private void FDCAKCIDMGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7BD2B40", Offset = "0x7BD1940", VA = "0x187BD2B40")]
	private void KPJKBINFMHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7BD2940", Offset = "0x7BD1740", VA = "0x187BD2940", Slot = "25")]
	public void KHBGIIBOKGA(AvatarFaceShape FLAFHLNGMIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7BD0720", Offset = "0x7BCF520", VA = "0x187BD0720", Slot = "26")]
	public void GIAEHNHPPGK(AvatarBodyShape CDIEHNANIME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0xAD9450", Offset = "0xAD8250", VA = "0x180AD9450", Slot = "33")]
	public void JJDNBGDODEG(GEMMNCOLLPK IBNBMGEBGNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7BCAB60", Offset = "0x7BC9960", VA = "0x187BCAB60", Slot = "35")]
	public void CEIHNMALCJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7BD5920", Offset = "0x7BD4720", VA = "0x187BD5920", Slot = "38")]
	public void PIDCAPGKJDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7BD2BC0", Offset = "0x7BD19C0", VA = "0x187BD2BC0", Slot = "34")]
	public void LEHOKLJGIIL(bool AMJELANJDHF, bool GOOCNEPCJCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7BD3B20", Offset = "0x7BD2920", VA = "0x187BD3B20")]
	private void MPJMKBKNPBO(SkinnedMeshRenderer ALLBNCKCNKL, int JGJKFDFMJDO, Mesh JIEGCDEFFGO, List<Material> JIMCAHFIJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7BD07E0", Offset = "0x7BCF5E0", VA = "0x187BD07E0")]
	private static Material GIMPGKNNPNO(Dictionary<GPPMDKPHMGP, Material> MNEACBJKJAL, Material LCPABANLMJF, KFAGFHCKBGC OJPBOKHAONG, PNHJKJBHLNC LEMNPMJGKPH, HHFLIOCEMDF PEADOPOCNJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7BCE300", Offset = "0x7BCD100", VA = "0x187BCE300")]
	private static KFAGFHCKBGC FIIKBEDAMLJ(PDINNKEAMLI FGBEJFBKAMO, int NIFJNECFBGA)
	{
		return default(KFAGFHCKBGC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7BD0130", Offset = "0x7BCEF30", VA = "0x187BD0130")]
	private void GBHNPEALKLD(int ENGFDNNLAAM, Material EFCBJICGDPB, PDINNKEAMLI FGBEJFBKAMO, [Out] Texture2D CAOPADOGCGA, [Out] Vector4 GDJGPPJGHHG, [Out] Texture2D EGDPIDJGAPJ, [Out] Texture2D LKJMNCKHFAJ, [Out] Texture2D DKINJNMIPIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7BCAF40", Offset = "0x7BC9D40", VA = "0x187BCAF40")]
	private void CHDBMHOIODC(int ENGFDNNLAAM, Material EFCBJICGDPB, PDINNKEAMLI FGBEJFBKAMO, [Out] Color DDFLDEGIBML, [Out] Color FEBJLJHIIBH, [Out] Color FPGBBHHHOKO, [Out] Color FBHPCKGHLOF, [Out] Color OCGPBMABIPG, [Out] Color MKAGPEHHNPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7BCBF90", Offset = "0x7BCAD90", VA = "0x187BCBF90")]
	private bool DKFKNPNIBNF(Material EFCBJICGDPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7BD20C0", Offset = "0x7BD0EC0", VA = "0x187BD20C0")]
	private static Material JJOPKAABCHD(int ENGFDNNLAAM, MDFICHJAFCM FGBEJFBKAMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7BCC270", Offset = "0x7BCB070", VA = "0x187BCC270")]
	private static PNHJKJBHLNC DNFJHPFLJNG(PDINNKEAMLI FGBEJFBKAMO, int NIFJNECFBGA)
	{
		return default(PNHJKJBHLNC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7BC98F0", Offset = "0x7BC86F0", VA = "0x187BC98F0")]
	private static void AFHFHMOLLMA(Dictionary<string, List<GPPMDKPHMGP>> MNMCPCDGAHI, PDINNKEAMLI BGEKACALGGD, Material LCPABANLMJF, KFAGFHCKBGC HMLAEFBLEHF, PNHJKJBHLNC CILJJCOEOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7BCB7A0", Offset = "0x7BCA5A0", VA = "0x187BCB7A0")]
	private static SkinnedMeshRenderer DFGFAHOPCAF(Transform CEHLHDAOPNG, Transform BBHGMECIFMD, SkinnedMeshRenderer[] DNOJAJAILBH, int JGJKFDFMJDO, AMBPMCJIDIO PBGGPJCBAMP, bool KFHDBEBFAPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7BD5D40", Offset = "0x7BD4B40", VA = "0x187BD5D40")]
	public ANNGEIDPJJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7BD1460", Offset = "0x7BD0260", VA = "0x187BD1460")]
	public void IANLJFINMMK([In] FDNCHBLKFEP EHAHEHEAMCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7BD13E0", Offset = "0x7BD01E0", VA = "0x187BD13E0")]
	public void IEANGMJCLKD([In] NFDBBAOJCKP FCMEGKLOAND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7BCCBF0", Offset = "0x7BCB9F0", VA = "0x187BCCBF0", Slot = "5")]
	public void EKHAPDGIEAA(int JGJKFDFMJDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7BD2DE0", Offset = "0x7BD1BE0", VA = "0x187BD2DE0", Slot = "10")]
	public void LJHPIHMJABA(CGAJGDNCFMD CILJJCOEOKI, Texture2D FBFLLKLGAIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xA24630", Offset = "0xA23430", VA = "0x180A24630")]
	public static bool JPBAHBBJOKB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7BD39A0", Offset = "0x7BD27A0", VA = "0x187BD39A0", Slot = "11")]
	public bool MPFIAEMBHGF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7BD2380", Offset = "0x7BD1180", VA = "0x187BD2380", Slot = "9")]
	public void JOOFGMHLIIK(CMCJLFLAALO HMLAEFBLEHF, Color? DEJLIDMJHPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7BD0610", Offset = "0x7BCF410", VA = "0x187BD0610")]
	private void GELJBCKAGLN(Action FIKCBJGDNPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7BD2110", Offset = "0x7BD0F10", VA = "0x187BD2110", Slot = "6")]
	public void JKEDKKEBNEN(KDOBCGFCCMB GJCCIIMFCKD, Texture PJEGBEIHEIO, Color HFBMHNDFCOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7BCA2B0", Offset = "0x7BC90B0", VA = "0x187BCA2B0", Slot = "7")]
	public void BPAKPHFEGLM(bool DGMDLOGDLNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1C9A1C0", Offset = "0x1C98FC0", VA = "0x181C9A1C0", Slot = "8")]
	public void CKGKPFLAION(MNCBCAJDKJB CNCKIIIBBGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7BD2BD0", Offset = "0x7BD19D0", VA = "0x187BD2BD0", Slot = "16")]
	public void LEOIPKKBJIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7BD0CF0", Offset = "0x7BCFAF0", VA = "0x187BD0CF0", Slot = "36")]
	public void HECMMLBEJBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7BCCC10", Offset = "0x7BCBA10", VA = "0x187BCCC10", Slot = "37")]
	public void EMLNMHAPFAG([Optional] CAOCJKDHCLC MABJDEDIHDH, [Optional] bool? NKGIMPJGHHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7BCC7C0", Offset = "0x7BCB5C0", VA = "0x187BCC7C0")]
	private bool EHIBFJMNECH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7BD0940", Offset = "0x7BCF740", VA = "0x187BD0940", Slot = "21")]
	public bool GJOGFBMMBPC(JICHGCEFAAI.NNADHONNNIJ JONLFIIJGCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7BCDB40", Offset = "0x7BCC940", VA = "0x187BCDB40")]
	private void FEFKMNKCBIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7BD2DD0", Offset = "0x7BD1BD0", VA = "0x187BD2DD0")]
	private void LHOJHBLELNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7BCA0E0", Offset = "0x7BC8EE0", VA = "0x187BCA0E0")]
	private static void BFKJAMHMGJC(Dictionary<GPPMDKPHMGP, Material> MNEACBJKJAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7BD3810", Offset = "0x7BD2610", VA = "0x187BD3810")]
	private static void MBGBFBHPLFC(Dictionary<Renderer, IIPKPBDAJNG> ALPPGDDGKKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7BD4210", Offset = "0x7BD3010", VA = "0x187BD4210")]
	private void NKEIOPNDBLL(SkinnedMeshRenderer[] DNOJAJAILBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7BD1BF0", Offset = "0x7BD09F0", VA = "0x187BD1BF0")]
	private void ILHKOPBPDNO(SkinnedMeshRenderer JDOFIMPPNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7BCCA10", Offset = "0x7BCB810", VA = "0x187BCCA10")]
	private void EKGNIHNCEMM(List<EPIKNCDFKGD> NJCFEAEALAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7BCA360", Offset = "0x7BC9160", VA = "0x187BCA360")]
	private void CBMNAFFOCKF(Dictionary<string, EHIFMMNJMNN<Texture2D>> MNMCPCDGAHI, bool AJCADHLNDOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7BD1E20", Offset = "0x7BD0C20", VA = "0x187BD1E20")]
	private void IMGJALHCKKG(Dictionary<string, List<GPPMDKPHMGP>> MNMCPCDGAHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7BD1940", Offset = "0x7BD0740", VA = "0x187BD1940")]
	private void IIMLJGBGPAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7BD1C90", Offset = "0x7BD0A90", VA = "0x187BD1C90")]
	private void ILOHKFICHCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7BCB9D0", Offset = "0x7BCA7D0", VA = "0x187BCB9D0")]
	private void DGNHPDLDGGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7BD5B00", Offset = "0x7BD4900", VA = "0x187BD5B00")]
	private void PLJEJHIDLCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7BD5660", Offset = "0x7BD4460", VA = "0x187BD5660")]
	private void PABPHPJCEFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7BD56F0", Offset = "0x7BD44F0", VA = "0x187BD56F0")]
	private void PALINELNFLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7BD0540", Offset = "0x7BCF340", VA = "0x187BD0540")]
	private void GDCABDJDLNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7BCB650", Offset = "0x7BCA450", VA = "0x187BCB650")]
	private void DDEGFPIBHFN(bool MAMALIMKLFG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7BD1F60", Offset = "0x7BD0D60", VA = "0x187BD1F60")]
	private void JCCGFKPOKGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7BCC6E0", Offset = "0x7BCB4E0", VA = "0x187BCC6E0")]
	private void EFDEJJBPJKI(bool MAMALIMKLFG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7BD0E30", Offset = "0x7BCFC30", VA = "0x187BD0E30")]
	private void HHDMMIKCJIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7BD3170", Offset = "0x7BD1F70", VA = "0x187BD3170")]
	private void MAKGDANAABJ(Material LECCGKLMLFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7BD3C70", Offset = "0x7BD2A70", VA = "0x187BD3C70")]
	private void NCANMPMKMKM(Material LECCGKLMLFA, Color CACINJNLFNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7BCB400", Offset = "0x7BCA200", VA = "0x187BCB400")]
	private void CPFOLLDJICG(Material LECCGKLMLFA, Color CACINJNLFNF, Color LPDOJHDKACB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7BD3670", Offset = "0x7BD2470", VA = "0x187BD3670")]
	private void MBDFJKKDMPD(Material LECCGKLMLFA, Color DDFLDEGIBML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7BCC4F0", Offset = "0x7BCB2F0", VA = "0x187BCC4F0")]
	private void EDJOODGJKDK(Material LECCGKLMLFA, Texture2D FBFLLKLGAIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7BD2180", Offset = "0x7BD0F80", VA = "0x187BD2180")]
	private void JLGGDCODMLB(Material LECCGKLMLFA, Texture IMGFIJHMCNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7BD1A90", Offset = "0x7BD0890", VA = "0x187BD1A90")]
	private void IJBCAADKCLA(Action<IIPKPBDAJNG> KEBLMLEFOKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7BD2780", Offset = "0x7BD1580", VA = "0x187BD2780")]
	private void JPAKHEDDCKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7BD3DF0", Offset = "0x7BD2BF0", VA = "0x187BD3DF0")]
	private void NJAIEKKJCOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7BC9BB0", Offset = "0x7BC89B0", VA = "0x187BC9BB0")]
	private void AHBKEFGKCOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7BD0960", Offset = "0x7BCF760", VA = "0x187BD0960")]
	public void GKIBCDONLKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7BD13E0", Offset = "0x7BD01E0", VA = "0x187BD13E0", Slot = "4")]
	private void HOAAHOKDCJE([In] NFDBBAOJCKP FCMEGKLOAND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7BD2900", Offset = "0x7BD1700", VA = "0x187BD2900")]
	[CompilerGenerated]
	private AAFDGGPNGMA KGMHCJHEDHH(PDINNKEAMLI PJEGPPLKFBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7BD2030", Offset = "0x7BD0E30", VA = "0x187BD2030")]
	[CompilerGenerated]
	private void JCECLFPDHEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7BCDA90", Offset = "0x7BCC890", VA = "0x187BCDA90")]
	[CompilerGenerated]
	private void FCPOIPBAFIK(IIPKPBDAJNG AFHICFOAOIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x7BD5A70", Offset = "0x7BD4870", VA = "0x187BD5A70")]
	[CompilerGenerated]
	private void PJKMDLMJENF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7BC98D0", Offset = "0x7BC86D0", VA = "0x187BC98D0")]
	[CompilerGenerated]
	private void ADGPPBFNCCC(IIPKPBDAJNG AFHICFOAOIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7BCA050", Offset = "0x7BC8E50", VA = "0x187BCA050")]
	[CompilerGenerated]
	private void BCNGOOLLNJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7BD3970", Offset = "0x7BD2770", VA = "0x187BD3970")]
	[CompilerGenerated]
	private void MGFKFBHFODE(IIPKPBDAJNG AFHICFOAOIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7BCA2D0", Offset = "0x7BC90D0", VA = "0x187BCA2D0")]
	[CompilerGenerated]
	private void CBEBGLLLLMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7BCA250", Offset = "0x7BC9050", VA = "0x187BCA250")]
	[CompilerGenerated]
	private void BLNKBEIMPFG(IIPKPBDAJNG AFHICFOAOIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7BD0690", Offset = "0x7BCF490", VA = "0x187BD0690")]
	[CompilerGenerated]
	private void GGGFKCABKPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7BD0100", Offset = "0x7BCEF00", VA = "0x187BD0100")]
	[CompilerGenerated]
	private void FOCLLKDADMF(IIPKPBDAJNG AFHICFOAOIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7BD22F0", Offset = "0x7BD10F0", VA = "0x187BD22F0")]
	[CompilerGenerated]
	private void JLGHPCHMHFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7BCDA60", Offset = "0x7BCC860", VA = "0x187BCDA60")]
	[CompilerGenerated]
	private void FCMMGLOJEHK(IIPKPBDAJNG AFHICFOAOIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7BD4440", Offset = "0x7BD3240", VA = "0x187BD4440")]
	[CompilerGenerated]
	private void OCKHOPIBPLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7BCA280", Offset = "0x7BC9080", VA = "0x187BCA280")]
	[CompilerGenerated]
	private void BNBHLCJECAM(IIPKPBDAJNG AFHICFOAOIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7BD17D0", Offset = "0x7BD05D0", VA = "0x187BD17D0")]
	[CompilerGenerated]
	private void IFOLGIAKEGM(KeyValuePair<string, EHIFMMNJMNN<Texture2D>> JJLFOGKKPCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7BCA240", Offset = "0x7BC9040", VA = "0x187BCA240")]
	[CompilerGenerated]
	private void BGKJPBHINMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7BCC900", Offset = "0x7BCB700", VA = "0x187BCC900")]
	[CompilerGenerated]
	private void EJGOLCIJIMP(IIPKPBDAJNG AFHICFOAOIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7BCA2C0", Offset = "0x7BC90C0", VA = "0x187BCA2C0")]
	[CompilerGenerated]
	private void CAPBIHHACBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7BC9650", Offset = "0x7BC8450", VA = "0x187BC9650")]
	[CompilerGenerated]
	private void AABAODMFCLF(IIPKPBDAJNG AFHICFOAOIL)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class AvatarElbowBendHelperController : MonoBehaviour, AFLDLDLNEBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		[DBPOJNFABNN(CBEHFHOOABN.Self, false, false, false)]
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
		[Header("Scale")]
		[FormerlySerializedAs("MinScaleValues")]
		[SerializeField]
		private Vector3 ScaleValuesAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[FormerlySerializedAs("MaxScaleValues")]
		[SerializeField]
		private Vector3 ScaleValuesAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[FormerlySerializedAs("MinLocalPositionalOffset")]
		[SerializeField]
		[Header("Positional Offset")]
		private Vector3 PositionalOffsetAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		[FormerlySerializedAs("MaxLocalPositionOffset")]
		[SerializeField]
		private Vector3 PositionalOffsetAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private Vector3? CGCPKCOBOLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private bool HHFLIMPPLFC;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7BD6700", Offset = "0x7BD5500", VA = "0x187BD6700", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7BD6D30", Offset = "0x7BD5B30", VA = "0x187BD6D30", Slot = "4")]
		public void UpdateController(float GNNOPFAGLOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xC6FB00", Offset = "0xC6E900", VA = "0x180C6FB00", Slot = "6")]
		public void SetEnabled(bool OAIIHELJHLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7BD67E0", Offset = "0x7BD55E0", VA = "0x187BD67E0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7BD71F0", Offset = "0x7BD5FF0", VA = "0x187BD71F0")]
		public AvatarElbowBendHelperController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class AvatarElbowBendTargetController : MonoBehaviour, AFLDLDLNEBD
	{
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private const float DHMNJEPDBIO = 45f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		[DBPOJNFABNN(CBEHFHOOABN.Self, false, false, false)]
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
		private Vector3 HFPAKIKKCCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private Vector3 MNINNADHJFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private bool HHFLIMPPLFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private float OAMKBLMFCNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private float AADLGJBGNAM;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7BD7570", Offset = "0x7BD6370", VA = "0x187BD7570", Slot = "4")]
		public void UpdateController(float GNNOPFAGLOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xE9B620", Offset = "0xE9A420", VA = "0x180E9B620", Slot = "6")]
		public void SetEnabled(bool OAIIHELJHLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7BD7290", Offset = "0x7BD6090", VA = "0x187BD7290")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7BD8030", Offset = "0x7BD6E30", VA = "0x187BD8030")]
		public AvatarElbowBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class EDKMGJBMKOB : OCOBFHIIAOB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private static readonly int NBJNMFJNCEJ;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private static readonly int CIAEKFKLLAA;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private static readonly int CJGGKDOGAKD;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static readonly int MEOFKBGBFPH;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private static readonly int OOKLHJGOJML;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static readonly int LIJEPHCEJGL;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static readonly int IMLCJOACHKL;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private static readonly int OGMMMCINJND;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private static readonly int CPNGICHDLGD;

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private static readonly int KBMJEKGFCEO;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private static readonly int JIFMHFNHKFB;

	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private static readonly int PAGFOPDBNDM;

	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private static readonly int GNMJDGCNLDH;

	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private static readonly int PDIEDBAJCFD;

	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private static readonly int PCOOBEDGPBJ;

	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private static readonly int CFBMKDBBKNM;

	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private static readonly int PHADAMIDAIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private Transform ONKCINMCMFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private Transform FHGKKICPFPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private Transform ELOKJPGPJFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private Transform MJGBFFHEMBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private Transform DAGFNHCEFNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private Transform IGADGGEOHLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private GBJBNEOMINP LJLIJGENDLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private Material IFJDEDDFENM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private SkinnedMeshRenderer[] ONPIILJBIFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private readonly List<Material> BCGFJHDJLIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private BNDNIILDNMC JOOMGNLMPBL;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public LLEAAEBCCKF MHNGHPDPHPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private BNDNIILDNMC HMMIMEBCAIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7BE2850", Offset = "0x7BE1650", VA = "0x187BE2850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool KNAODMGEKMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7BE3140", Offset = "0x7BE1F40", VA = "0x187BE3140", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x7BE3030", Offset = "0x7BE1E30", VA = "0x187BE3030")]
	public void IANLJFINMMK([In] GBJBNEOMINP OEIHOJGJLKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x7BE2640", Offset = "0x7BE1440", VA = "0x187BE2640")]
	public void IMLMHIBGHID([In] JMNIBAELLDP JNLGJDAPFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x7BE41C0", Offset = "0x7BE2FC0", VA = "0x187BE41C0", Slot = "6")]
	public void PDNCMADEBAB(JJGELAILKFI IJFNDEJJHBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x7BE30E0", Offset = "0x7BE1EE0", VA = "0x187BE30E0")]
	private Vector2 IILAGLHFMPL(Vector2 JAEKADJLPMF)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x7BE32D0", Offset = "0x7BE20D0", VA = "0x187BE32D0")]
	public void OMJFFIBAPHM([In] AEEEFNBFKHG JNLGJDAPFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7BE28D0", Offset = "0x7BE16D0", VA = "0x187BE28D0")]
	private void FHHFCEEEAJK(FFMKBAIGLCO PMICBHDPNIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7BE2CA0", Offset = "0x7BE1AA0", VA = "0x187BE2CA0")]
	private void HKHLAGNCMEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x7BE26E0", Offset = "0x7BE14E0", VA = "0x187BE26E0")]
	private void ECNPKEEMGEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7BE26E0", Offset = "0x7BE14E0", VA = "0x187BE26E0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7BE49C0", Offset = "0x7BE37C0", VA = "0x187BE49C0")]
	public EDKMGJBMKOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7BE2640", Offset = "0x7BE1440", VA = "0x187BE2640", Slot = "5")]
	private void BJOMGLDOFCM([In] JMNIBAELLDP JNLGJDAPFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7BE2750", Offset = "0x7BE1550", VA = "0x187BE2750", Slot = "7")]
	private void EMDANOJCKKP([In] AEEEFNBFKHG JNLGJDAPFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x7BE2630", Offset = "0x7BE1430", VA = "0x187BE2630")]
	[CompilerGenerated]
	internal static float AIFNFNMGHDP(float OAIIHELJHLG, float ENNLGHBJALI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7BE2760", Offset = "0x7BE1560", VA = "0x187BE2760")]
	[CompilerGenerated]
	internal static void FBEPACJKDEN(Vector2 PNAGGHNILKD, Vector2 DJKAFIBCAPD, Vector2 ACINDEOBNPO, Vector2 JJLOIPCKCEC, Vector2 CEDDBAAAIGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7BE3290", Offset = "0x7BE2090", VA = "0x187BE3290")]
	[CompilerGenerated]
	internal static Vector4 MOBELJGGAMA(Vector2 NPJPCFKLMHD, Vector2 JCGDFDLNFJA)
	{
		return default(Vector4);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class AvatarForearmRollController : MonoBehaviour, AFLDLDLNEBD
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
		private float OAMKBLMFCNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private bool HHFLIMPPLFC;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x7BDE720", Offset = "0x7BDD520", VA = "0x187BDE720", Slot = "4")]
		public void UpdateController(float GNNOPFAGLOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x16FD040", Offset = "0x16FBE40", VA = "0x1816FD040", Slot = "6")]
		public void SetEnabled(bool OAIIHELJHLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x7BDEF90", Offset = "0x7BDDD90", VA = "0x187BDEF90")]
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

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
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

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x7BDEFC0", Offset = "0x7BDDDC0", VA = "0x187BDEFC0")]
		public void HLJFBNEKAGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x7BDF0E0", Offset = "0x7BDDEE0", VA = "0x187BDF0E0")]
		public int PLEBKEOHAKE(int BECJIFFOOEH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public AvatarHandDisplaySettings()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class DHLBPGCJDMM : IILGCBLFFFP
{
	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x7BE2580", Offset = "0x7BE1380", VA = "0x187BE2580", Slot = "22")]
	public override float PBKEDALKGPL()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7BE25D0", Offset = "0x7BE13D0", VA = "0x187BE25D0")]
	public DHLBPGCJDMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class IILGCBLFFFP : PPBDPCLLEJH
{
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private static int DEEGIOCKGMB;

	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private static int AMOFFIFCPIM;

	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private static int CPKCLDNAHOO;

	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private static int PEKEMOCFLIL;

	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private static int MMACKIKKIAF;

	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private static int MBPAEEAIMPP;

	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private static int PKMMFOPGLHF;

	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private static int[] JJFGEJGHNFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private JPAIMLCMMDE LJLIJGENDLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private MABAIIAGBIG ANDFFECDEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private int JDMKBPEOELC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private float ONOCGBDADNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	protected Animator JMPIAHLHMEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	protected AvatarConfiguration BICNIDPOCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	protected int DPLNDNCGBOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private int MIDPADJMOGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private int BMLGLPJLDPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private bool OHAIMLHLPIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private JLIOAPNIDNL KANOKPKLLFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private int KEKOBCDMCEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private float EENPIPKNKLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private AvatarHandDisplaySettings OCPDIAOLEPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private JBJPAOBCEOK HOOPBCHKHBM;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Transform AAMHEBBJPAB
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public Vector3 PGDAPIIHCBM
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x1708C70", Offset = "0x1707A70", VA = "0x181708C70")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x1708C90", Offset = "0x1707A90", VA = "0x181708C90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Quaternion BGLEOOILJCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xD5AF70", Offset = "0xD59D70", VA = "0x180D5AF70")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xF76C80", Offset = "0xF75A80", VA = "0x180F76C80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool CCBDOMDHBKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7BE87D0", Offset = "0x7BE75D0", VA = "0x187BE87D0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7BE86E0", Offset = "0x7BE74E0", VA = "0x187BE86E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool MIJBKJAAEJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0xD55D00", Offset = "0xD54B00", VA = "0x180D55D00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public Vector3 IEEIACAJHBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0xA36770", Offset = "0xA35570", VA = "0x180A36770", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xA35890", Offset = "0xA34690", VA = "0x180A35890")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Quaternion HONOMADONPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x11113C0", Offset = "0x11101C0", VA = "0x1811113C0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x14B3E30", Offset = "0x14B2C30", VA = "0x1814B3E30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public INDOKOCMJGN NNLOBABPACH
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xADFCF0", Offset = "0xADEAF0", VA = "0x180ADFCF0", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(INDOKOCMJGN);
		}
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xADFB10", Offset = "0xADE910", VA = "0x180ADFB10", Slot = "4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public INDOKOCMJGN JFFBNBOLOLD
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x111EA40", Offset = "0x111D840", VA = "0x18111EA40", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(INDOKOCMJGN);
		}
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x25BB790", Offset = "0x25BA590", VA = "0x1825BB790", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public float ALAEFHEAMHM
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0xAD9880", Offset = "0xAD8680", VA = "0x180AD9880", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0xF864D0", Offset = "0xF852D0", VA = "0x180F864D0", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool CIBNOMBKCDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7BE86D0", Offset = "0x7BE74D0", VA = "0x187BE86D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool HKJKOBFFLMP
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x7BE8710", Offset = "0x7BE7510", VA = "0x187BE8710")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool OIMHFKHNPOM
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x7BE8EF0", Offset = "0x7BE7CF0", VA = "0x187BE8EF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool BPKNEOGLNLI
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x7BE90C0", Offset = "0x7BE7EC0", VA = "0x187BE90C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x7BE8800", Offset = "0x7BE7600", VA = "0x187BE8800", Slot = "21")]
	public void IANLJFINMMK(JPAIMLCMMDE OEIHOJGJLKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x7BE8680", Offset = "0x7BE7480", VA = "0x187BE8680")]
	public void CPLBKFJJCEC(MABAIIAGBIG LFOLKPONNCO, AvatarHandDisplaySettings PLGMKDFPJAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x7BE8740", Offset = "0x7BE7540", VA = "0x187BE8740", Slot = "12")]
	public void HFDBOIHJHDN(bool HMKCBLNCLGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x7BE8B80", Offset = "0x7BE7980", VA = "0x187BE8B80", Slot = "11")]
	public void MDDKGPPEKJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0xAD9880", Offset = "0xAD8680", VA = "0x180AD9880", Slot = "22")]
	public virtual float PBKEDALKGPL()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x7BE89A0", Offset = "0x7BE77A0", VA = "0x187BE89A0")]
	private int JPEGBMNCDGD(INDOKOCMJGN BFDMBBGBMDF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x7BE8F00", Offset = "0x7BE7D00", VA = "0x187BE8F00")]
	private void OBKNELEOKPK(int NPONMIBAODO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x7BE8720", Offset = "0x7BE7520", VA = "0x187BE8720", Slot = "13")]
	public bool GFDFBDIKDBF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x7BE90D0", Offset = "0x7BE7ED0", VA = "0x187BE90D0", Slot = "14")]
	public bool ONKPMGNKKCD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x7BE8620", Offset = "0x7BE7420", VA = "0x187BE8620")]
	private INDOKOCMJGN APOIHKHDDND()
	{
		return default(INDOKOCMJGN);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x1C526F0", Offset = "0x1C514F0", VA = "0x181C526F0", Slot = "15")]
	public void OHFEGONJMAL(bool HMKCBLNCLGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7BE85C0", Offset = "0x7BE73C0", VA = "0x187BE85C0", Slot = "10")]
	public void ACEIMJEKIJF(int NPONMIBAODO, float EOCELADHEEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7BE8600", Offset = "0x7BE7400", VA = "0x187BE8600", Slot = "8")]
	public void AILAHLBEKFE(JLIOAPNIDNL JNOIIIFBOLM, bool DLKFMHELCEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x7BE8670", Offset = "0x7BE7470", VA = "0x187BE8670", Slot = "9")]
	public void BHPLDDENALJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7BE8B30", Offset = "0x7BE7930", VA = "0x187BE8B30", Slot = "16")]
	public void KDNFFDNFAMB(Transform BOGJJGPKPIJ, Vector3 MJLFCGFHHEA, Quaternion PDBHBOBECDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x7BE93B0", Offset = "0x7BE81B0", VA = "0x187BE93B0")]
	public IILGCBLFFFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class MDFICHJAFCM : PDINNKEAMLI
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class ANMPHGPHHEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public MDFICHJAFCM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public List<EPIKNCDFKGD> prefabHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public List<EPIKNCDFKGD> materialHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public EHIFMMNJMNN<Material[]> loadMaterialsHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public EHIFMMNJMNN<APGDOBPDHHN> loadPrefabHandle;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public ANMPHGPHHEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x7BDE450", Offset = "0x7BDD250", VA = "0x187BDE450")]
		internal AAFDGGPNGMA BIDNFIJMIGH(string error)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	public KDOBCGFCCMB MLEDLECEAFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	public APGDOBPDHHN DEKLDOMONIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private EHIFMMNJMNN<APGDOBPDHHN> HNHDGNPLEDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private EHIFMMNJMNN<Material[]> BBDKDNBEMPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	public Material[] NHPEGMBIHFH;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool GLKGBLEDGDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0xA36F20", Offset = "0xA35D20", VA = "0x180A36F20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0xA36E80", Offset = "0xA35C80", VA = "0x180A36E80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public JICHGCEFAAI.NNADHONNNIJ JMGHBICFPNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAF0", Offset = "0xA0D8F0", VA = "0x180A0EAF0")]
		[CompilerGenerated]
		get
		{
			return default(JICHGCEFAAI.NNADHONNNIJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0xA128F0", Offset = "0xA116F0", VA = "0x180A128F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x7BEED80", Offset = "0x7BEDB80", VA = "0x187BEED80")]
	public MDFICHJAFCM(HHFLIOCEMDF BBEKBGOIPEP, KDOBCGFCCMB BGPHPGHJPMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x7BEDFF0", Offset = "0x7BECDF0", VA = "0x187BEDFF0", Slot = "6")]
	public override AAFDGGPNGMA DKBLFNLECGA(List<EPIKNCDFKGD> EHCEMGOHGBG, List<EPIKNCDFKGD> CHMPLBKBLHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x7BEEA30", Offset = "0x7BED830", VA = "0x187BEEA30")]
	public AAFDGGPNGMA OEAJJEJFOKC(List<EPIKNCDFKGD> EHCEMGOHGBG, List<EPIKNCDFKGD> CHMPLBKBLHN, EHIFMMNJMNN<Material[]> BBDKDNBEMPE, [Optional] EHIFMMNJMNN<APGDOBPDHHN> MFGMLELFBKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x7BEDA50", Offset = "0x7BEC850", VA = "0x187BEDA50")]
	public (EHIFMMNJMNN<Material[]>, EHIFMMNJMNN<APGDOBPDHHN>) AIJMPOOBKCI(List<EPIKNCDFKGD> EHCEMGOHGBG, List<EPIKNCDFKGD> CHMPLBKBLHN)
	{
		return default((EHIFMMNJMNN<Material[]>, EHIFMMNJMNN<APGDOBPDHHN>));
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x7BEE830", Offset = "0x7BED630", VA = "0x187BEE830", Slot = "7")]
	public override GICDLIDANGG KGGDDGMGGLJ(uint JGJKFDFMJDO, AvatarSkinnedMeshBoneOrderRemapsData DIGEJOCNOPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x7BEDDE0", Offset = "0x7BECBE0", VA = "0x187BEDDE0")]
	public GICDLIDANGG BKJNMAJPGLE(GameObject IJEDPNCMHDD, uint JGJKFDFMJDO, bool HINOIOHKPFO, bool MABCPBNACJI, AvatarSkinnedMeshBoneOrderRemapsData DIGEJOCNOPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x7BEE4C0", Offset = "0x7BED2C0", VA = "0x187BEE4C0")]
	public static bool JGCPNKLHGBH(Renderer[] DNOJAJAILBH, string PPNCJGJADBF, [Out] Renderer KIAJJFDJHLE, [Out] Renderer NCCOGMMGFGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x7BEED30", Offset = "0x7BEDB30", VA = "0x187BEED30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x7BEE960", Offset = "0x7BED760", VA = "0x187BEE960")]
	private (EHIFMMNJMNN<APGDOBPDHHN>, EHIFMMNJMNN<Material[]>) KLOEEFJCFHE()
	{
		return default((EHIFMMNJMNN<APGDOBPDHHN>, EHIFMMNJMNN<Material[]>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7BEE4A0", Offset = "0x7BED2A0", VA = "0x187BEE4A0")]
	[CompilerGenerated]
	private void FDAIJLMNLHO(APGDOBPDHHN BPINCJLADGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0xA0CFE0", Offset = "0xA0BDE0", VA = "0x180A0CFE0")]
	[CompilerGenerated]
	private void FPIOLAIHOFE(Material[] BPINCJLADGC)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class AvatarKneeBendTargetController : MonoBehaviour, AFLDLDLNEBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		[SerializeField]
		[DBPOJNFABNN(CBEHFHOOABN.Self, false, false, false)]
		private Transform KneeBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		[SerializeField]
		private Transform RootSpineBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		[SerializeField]
		private Transform ThighBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		[SerializeField]
		private Transform FootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		[SerializeField]
		private float WeightToFootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		[SerializeField]
		private Vector3 BendTargetOffsetFromHipToFootMidPoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		[SerializeField]
		private Bounds KneeTargetConstrainedBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private Vector3 HFPAKIKKCCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private Vector3 OKPKDOHLAKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private Vector3 HHOIJHLGNJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private Matrix4x4 ODKKOMDPEFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private bool HHFLIMPPLFC;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x7BDF5C0", Offset = "0x7BDE3C0", VA = "0x187BDF5C0", Slot = "4")]
		public void UpdateController(float GNNOPFAGLOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7BDF5B0", Offset = "0x7BDE3B0", VA = "0x187BDF5B0", Slot = "6")]
		public void SetEnabled(bool OAIIHELJHLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x7BDF150", Offset = "0x7BDDF50", VA = "0x187BDF150")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x7BDFC80", Offset = "0x7BDEA80", VA = "0x187BDFC80")]
		public AvatarKneeBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[DOEGHAPPEHM]
public struct MMCEKFOLGFE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	[ReadOnly]
	public GDHHDFPGJIN LMEPIIEACAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	[ReadOnly]
	public int EJCIIHONOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	public CIJJMCHENDN NAGODCCNKLK;

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7BEF890", Offset = "0x7BEE690", VA = "0x187BEF890", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[NativeContainer]
[DOEGHAPPEHM]
public struct CIJJMCHENDN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	public NativeArray<Vector3> JILIJIKIFKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	public NativeArray<Vector3> FKFBMOPPFGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	public NativeArray<Vector4> EKNIDIEOBKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public NativeArray<Vector2> BMNMGNJHNDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public NativeArray<Vector2> IHDMOHGPMJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public NativeArray<Vector2> GGIDHGHANPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public NativeArray<Vector2> CCEMNPMOBEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public NativeArray<Color> CJNONEFKKBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public NativeArray<int> PHIPBKFLOOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public NativeArray<int> GFEEEPPFGAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private NativeArray<int> MKCPOJLLACD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private NativeArray<int> HLFJGHJCOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public NativeArray<int> OOKAHKGHCFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	public NativeArray<int> HBJKEDPKPCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	public NativeArray<int> PCFANJPDPBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public NativeArray<BoneWeight> BCIDOEEMCJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private NativeArray<int> CNCKIIIBBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private bool HBOGFMBJOAD;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int DOBEAMFNJFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x7BE14A0", Offset = "0x7BE02A0", VA = "0x187BE14A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x7BE1670", Offset = "0x7BE0470", VA = "0x187BE1670")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int MJGOALKKNGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x7BE1820", Offset = "0x7BE0620", VA = "0x187BE1820")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x7BE1790", Offset = "0x7BE0590", VA = "0x187BE1790")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int EJHGFNKJFKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7BE1680", Offset = "0x7BE0480", VA = "0x187BE1680")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x7BE14B0", Offset = "0x7BE02B0", VA = "0x187BE14B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x7BE1E80", Offset = "0x7BE0C80", VA = "0x187BE1E80")]
	public CIJJMCHENDN(int IOJMPGFAGPL, int MEDCOGJPDKK, int LDKCNDCDIOM, int OAAONBEOFLP, Allocator LNMGNHHGHLL, int KCNNAKHDAOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x7BE1430", Offset = "0x7BE0230", VA = "0x187BE1430")]
	public void AHJBJAADLNA(int GLAOLHCPLLG, Vector3 LCFJFNFOMKB, Vector3 KACKFEMGFCF, Vector4 JIJABGNNHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x7BE1CE0", Offset = "0x7BE0AE0", VA = "0x187BE1CE0")]
	public void PLBAEKFHEIN(int GLAOLHCPLLG, BoneWeight OJDICKPPGNL, NativeSlice<byte> ILEDGFFJKMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x7BE1770", Offset = "0x7BE0570", VA = "0x187BE1770")]
	public Color IHIMDAJOKGM(int GLAOLHCPLLG)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x7BE1800", Offset = "0x7BE0600", VA = "0x187BE1800")]
	public void KOIHOIGMCMB(int GLAOLHCPLLG, Color KMBJNMDOLGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x7BE17A0", Offset = "0x7BE05A0", VA = "0x187BE17A0")]
	public void JPBPCKEKCHL(byte NLGDMKIKEEP, int GLAOLHCPLLG, Vector2 LMCDMGEBKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x7BE17F0", Offset = "0x7BE05F0", VA = "0x187BE17F0")]
	public void KMMLPIJLHKI(int GLAOLHCPLLG, int DHBPNNGGPNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x7BE1740", Offset = "0x7BE0540", VA = "0x187BE1740")]
	public bool GMHOMDCKJGN(int NLGDMKIKEEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x7BE1830", Offset = "0x7BE0630", VA = "0x187BE1830")]
	public void NEKOLNMDOEA(int IJCIAAHJLIC, int PPPFIBNDOMK, int NPCJGIOCILE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x7BE1690", Offset = "0x7BE0490", VA = "0x187BE1690")]
	public int[] GMEKIJDGMFA(int IJCIAAHJLIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x7BE1900", Offset = "0x7BE0700", VA = "0x187BE1900")]
	private NativeSlice<int> OMMNLLMGPNE(int IJCIAAHJLIC)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x7BE14C0", Offset = "0x7BE02C0", VA = "0x187BE14C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7BE1990", Offset = "0x7BE0790", VA = "0x187BE1990")]
	public Mesh PJMKBIHGNDJ([Optional] string GLMIDHCLHAB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[DOEGHAPPEHM]
[DefaultMember("Item")]
[NativeContainer]
public struct GDHHDFPGJIN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	public NativeArray<Vector3> JILIJIKIFKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	public NativeArray<Vector3> FKFBMOPPFGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	public NativeArray<Vector4> EKNIDIEOBKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	public NativeArray<Vector2> BMNMGNJHNDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public NativeArray<Vector2> IHDMOHGPMJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public NativeArray<Vector2> GGIDHGHANPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public NativeArray<Vector2> CCEMNPMOBEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public NativeArray<Color> CJNONEFKKBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public NativeArray<int> LPOAHMEIIAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public NativeArray<int> HHBDCOLHOGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	public NativeArray<int> GEMEOHEJNOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public NativeArray<int> JGKILPNMNDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public NativeArray<bool> GADNNPKNJDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public NativeArray<int> BIGNHIBKBAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public NativeArray<int> ONEDEMEMOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	public NativeArray<BoneWeight> JDBFDBGCGCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private NativeArray<Matrix4x4> KHHJPFNGHKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private NativeArray<long> DCCLJBIKMBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private NativeArray<byte> MPKMJMHNBHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private NativeArray<int> EDFKOJFJMIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private NativeArray<int> ILCDFFCJILO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	public NativeArray<sbyte> CLIKODHGOAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	public NativeArray<byte> IPBGGOJMBNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private NativeArray<int> KFDICACNJIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private bool HBOGFMBJOAD;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public int GNGEKNLJMIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xDE0900", Offset = "0xDDF700", VA = "0x180DE0900")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int KBALHAHBJOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xC72A90", Offset = "0xC71890", VA = "0x180C72A90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int OEGLBEJHLDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7BE55C0", Offset = "0x7BE43C0", VA = "0x187BE55C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public int LODJBLFPPHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x7BE5B50", Offset = "0x7BE4950", VA = "0x187BE5B50")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7BE55B0", Offset = "0x7BE43B0", VA = "0x187BE55B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public int DOBEAMFNJFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7BE5300", Offset = "0x7BE4100", VA = "0x187BE5300")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x7BE55A0", Offset = "0x7BE43A0", VA = "0x187BE55A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public int NNHPOBJJOGC
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x7BE5B30", Offset = "0x7BE4930", VA = "0x187BE5B30")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7BE5B40", Offset = "0x7BE4940", VA = "0x187BE5B40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public DCPCHOGDPLH GNEANCAPCFH
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7BE5320", Offset = "0x7BE4120", VA = "0x187BE5320")]
		get
		{
			return default(DCPCHOGDPLH);
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7BE5B20", Offset = "0x7BE4920", VA = "0x187BE5B20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public byte LLMIOFLOCGH
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x7BE5B60", Offset = "0x7BE4960", VA = "0x187BE5B60")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7BE5310", Offset = "0x7BE4110", VA = "0x187BE5310")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public KGMKKLBPJOL ANMDDLMJFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x7BE55F0", Offset = "0x7BE43F0", VA = "0x187BE55F0")]
		get
		{
			return default(KGMKKLBPJOL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x7BE5C40", Offset = "0x7BE4A40", VA = "0x187BE5C40")]
	public GDHHDFPGJIN(IList<Mesh> IANPBMCBCDG, IList<Matrix4x4> OIENDOJDPCI, IList<bool> GADNNPKNJDH, byte NKAJHNKOMIJ, IList<byte[]> EJIEIGOGAJG, IList<long> DNCKFAPENEG, IList<bool> HEFCFNAIHDJ, IList<int> BIGNHIBKBAK, IList<int> BMCIOFDAFKE, IList<int> ANAIIDAGDDE, Allocator LNMGNHHGHLL, DCPCHOGDPLH GNGFDKFFBEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x7BE5B70", Offset = "0x7BE4970", VA = "0x187BE5B70")]
	public CIJJMCHENDN PHGPPABDMKL(Allocator LNMGNHHGHLL)
	{
		return default(CIJJMCHENDN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x7BE5330", Offset = "0x7BE4130", VA = "0x187BE5330", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[DOEGHAPPEHM]
public class NIHOLLNGJCB : NCJGADDIAMJ
{
	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x7BF0D20", Offset = "0x7BEFB20", VA = "0x187BF0D20")]
	public GDHHDFPGJIN PENNMMDGFNO()
	{
		return default(GDHHDFPGJIN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x7BDA260", Offset = "0x7BD9060", VA = "0x187BDA260")]
	public NIHOLLNGJCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct KGMKKLBPJOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public NativeSlice<Vector3> JILIJIKIFKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	public NativeSlice<Vector3> FKFBMOPPFGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public NativeSlice<Vector4> EKNIDIEOBKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public NativeSlice<Vector2> BMNMGNJHNDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public NativeSlice<Vector2> IHDMOHGPMJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public NativeSlice<Vector2> GGIDHGHANPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public NativeSlice<Vector2> CCEMNPMOBEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public NativeSlice<Color> CJNONEFKKBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	public NativeSlice<int> GKFINKOFKEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public NativeSlice<int> JGKILPNMNDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public NativeSlice<BoneWeight> JDBFDBGCGCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public NativeSlice<byte> DAOCNPDDMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public int LFPLIOMDKCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	public Matrix4x4 GAFMJNFCNKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public long BMJNMGODCHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public NativeSlice<byte> ILEDGFFJKMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public bool FDMKNANIKOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public int FHOHBGOHBDK;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal readonly struct GPPMDKPHMGP : IEquatable<GPPMDKPHMGP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	internal readonly Material HCJHJANFJBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	internal readonly KFAGFHCKBGC IPIGFHKPOKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	internal readonly PNHJKJBHLNC FACKBBADLDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	internal readonly HHFLIOCEMDF HLMNABLPCCF;

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x7BE8580", Offset = "0x7BE7380", VA = "0x187BE8580")]
	public GPPMDKPHMGP(Material EFCBJICGDPB, KFAGFHCKBGC OJPBOKHAONG, PNHJKJBHLNC LEMNPMJGKPH, HHFLIOCEMDF PEADOPOCNJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x7BE8360", Offset = "0x7BE7160", VA = "0x187BE8360", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x7BE8160", Offset = "0x7BE6F60", VA = "0x187BE8160", Slot = "4")]
	public bool Equals(GPPMDKPHMGP HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x7BE81E0", Offset = "0x7BE6FE0", VA = "0x187BE81E0", Slot = "0")]
	public override bool Equals(object GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x7BE82C0", Offset = "0x7BE70C0", VA = "0x187BE82C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyDisplayBehaviour : MonoBehaviour, MAKMIFPFIDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		[Header("Configuration")]
		[SerializeField]
		protected AvatarConfiguration configuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		[SerializeField]
		protected Animator skeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		[SerializeField]
		protected Renderer[] watchRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		[Header("Configuration")]
		[SerializeField]
		private JBJPAOBCEOK avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		[SerializeField]
		private AvatarSkinAssetItem potatoAvatarSkinAssetItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		[SerializeField]
		[FormerlySerializedAs("avatarSkinAsset")]
		private AssetReference avatarSkinAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		[SerializeField]
		private GameObject firstPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		[SerializeField]
		public GameObject thirdPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		[SerializeField]
		private GameObject[] hideInFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		[SerializeField]
		protected Transform headAdditiveBaseBoneTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		[SerializeField]
		[FormerlySerializedAs("BodyMaterial")]
		private Material BodyMaterialSkinGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		[SerializeField]
		private Material BodyMaterialNonGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		[SerializeField]
		private Material FaceMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		[SerializeField]
		private Material DefaultAvatarItemMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		[SerializeField]
		private Shader AvatarDefaultShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		[SerializeField]
		private Shader AvatarUberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		[SerializeField]
		private Transform DeformRigRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		[SerializeField]
		private SkinnedMeshRenderer BaseSkinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		[SerializeField]
		protected AvatarSkinnedMeshBoneOrderRemapsData BoneOrderRemapsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		[SerializeField]
		[Header("Arm Animation Controllers")]
		private AvatarForearmRollController LeftForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		[SerializeField]
		private AvatarElbowBendHelperController LeftElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		[SerializeField]
		private AvatarElbowBendTargetController LeftElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		[SerializeField]
		private AvatarKneeBendTargetController LeftKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		[SerializeField]
		private AvatarForearmRollController RightForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		[SerializeField]
		private AvatarElbowBendHelperController RightElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		[SerializeField]
		private AvatarElbowBendTargetController RightElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		[SerializeField]
		private AvatarKneeBendTargetController RightKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		[SerializeField]
		private Transform LeftEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		[SerializeField]
		private Transform LeftEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		[SerializeField]
		private Transform RightEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		[SerializeField]
		private Transform RightEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		[SerializeField]
		private Transform NoseMoveTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		[SerializeField]
		private Transform MouthBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		[SerializeField]
		private AvatarBodyPartShapesManager avatarBodyPartShapesManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		[SerializeField]
		private Transform HatAnchorBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		[SerializeField]
		private Transform LeftHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		[SerializeField]
		private Transform RightHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		[SerializeField]
		private GameObject LeftHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		[SerializeField]
		private GameObject RightHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private IGHDDCGAHHH OIOGFAIFPCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private OCOBFHIIAOB NLANKFKJKFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		private PPBDPCLLEJH JMKECEGOFOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		private PPBDPCLLEJH GGJAJHDHAOA;

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public IGHDDCGAHHH KFNMCHALKID
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x7BE0C00", Offset = "0x7BDFA00", VA = "0x187BE0C00", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public OCOBFHIIAOB HCLOIMANNPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x7BE0C50", Offset = "0x7BDFA50", VA = "0x187BE0C50", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public PPBDPCLLEJH AONEOOBHNPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x7BE0CA0", Offset = "0x7BDFAA0", VA = "0x187BE0CA0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public PPBDPCLLEJH OIOPJCLOHKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x7BE0CF0", Offset = "0x7BDFAF0", VA = "0x187BE0CF0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public Transform HNEEAFIEIKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x7BE0D40", Offset = "0x7BDFB40", VA = "0x187BE0D40", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public JBJPAOBCEOK POBDILOHIHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0xA123A0", Offset = "0xA111A0", VA = "0x180A123A0", Slot = "12")]
			get
			{
				return default(JBJPAOBCEOK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x7BDFC90", Offset = "0x7BDEA90", VA = "0x187BDFC90")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7BE0A60", Offset = "0x7BDF860", VA = "0x187BE0A60")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x7BE06E0", Offset = "0x7BDF4E0", VA = "0x187BE06E0", Slot = "8")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7BE0A60", Offset = "0x7BDF860", VA = "0x187BE0A60", Slot = "9")]
		public void TeardownAvatarDisplaySystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x7BDFD00", Offset = "0x7BDEB00", VA = "0x187BDFD00", Slot = "10")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x7BE0B10", Offset = "0x7BDF910", VA = "0x187BE0B10")]
		public void UpdatePostIKAnimControllers(float GNNOPFAGLOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x7BE0740", Offset = "0x7BDF540", VA = "0x187BE0740")]
		private void LJFJDAPFEHD(GameObject GLEBGNJJOHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x7BE0370", Offset = "0x7BDF170", VA = "0x187BE0370")]
		private IGHDDCGAHHH FMDFENBHHEF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x7BE0030", Offset = "0x7BDEE30", VA = "0x187BE0030")]
		private OCOBFHIIAOB EDEHBBONNBM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x7BE07D0", Offset = "0x7BDF5D0", VA = "0x187BE07D0")]
		private PPBDPCLLEJH NGIIFNPFMHO(PJHKHIOBOIP LNNCKOKDICI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x7BE0BF0", Offset = "0x7BDF9F0", VA = "0x187BE0BF0")]
		public AvatarModernBodyDisplayBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class IIPKPBDAJNG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private MaterialPropertyBlock MCGCEPANONA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	public Color? FIMFEBAELIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	public Color? HGGCGEGDFNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	public Color? JGMNDILPAEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	public Color? KCMFMOOHOKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	public Color HOEGHGDBLEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	public Color GHLHMLJCLGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	public Color JNHAHDIGDFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	public Texture2D AHOEJDNJHII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	public Texture2D MPHLMKEIPNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	private Dictionary<GPPMDKPHMGP, int> FDALPPCBFML;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	private KFAGFHCKBGC[] NFKMBJCAACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	private PNHJKJBHLNC[] IDABFKOLEIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	public Vector4[] APGBAJPJDMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	public Vector4[] MNBNODELOCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	public Vector4[] GFJOBFGPFGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public Vector4[] ALBELPENFKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public Vector4[] COOJEBMFGDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public Vector4[] PELFJPMLGMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	private List<Texture2D> HMPFMHFEMEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private Vector4[] MKGIFJNPNEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private List<Texture2D> DBPFMMMGLFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private float[] LNPLCADGJIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private Vector4[] IOOKDBCJOCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private float[] DKGFGKBDDGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public float[] ABLMFJHMHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private List<Texture2D> INCHCLIDIPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private float[] JNPDNIBGECK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	private List<Texture2D> FKJABDOIMHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private Vector4[] PJMAMGGLDLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private float[] LCGOAMDHBNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private Vector4[] ICPFBLOKMCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public float[] KHKBPGNDEOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public Texture2DArray FJBNIOOAMNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	public Texture2DArray FFACMBGABAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public Texture2DArray GBONCDIHMFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public Texture2DArray DGACLGMKMHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private bool LIKJHDIAHAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private int FMLIFGGKDGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private Vector2? LBGHOPGDMHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private TextureFormat CEFCANGEJKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	private Vector2? JJLDEDFPANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private TextureFormat GFIEKEHGPLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private Vector2? DBLAKHFOAEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private TextureFormat NHHDMFBJDPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private Vector2? AEGADNGBGBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	private TextureFormat LGCEFLAGHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	private bool OMPJCPABCDP;

	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private static int CKBGLOBFHGA;

	[Cpp2IlInjected.Token(Token = "0x400024C")]
	private static int NPNEOGNGIBD;

	[Cpp2IlInjected.Token(Token = "0x400024D")]
	private static int DHNIMMPKKHB;

	[Cpp2IlInjected.Token(Token = "0x400024E")]
	private static int AOLJBILPCNP;

	[Cpp2IlInjected.Token(Token = "0x400024F")]
	private static int PICFLHHEEFK;

	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private static int BOJLKPPJJAM;

	[Cpp2IlInjected.Token(Token = "0x4000251")]
	private static int GPECJANGKOB;

	[Cpp2IlInjected.Token(Token = "0x4000252")]
	private static int DENDKNPECLJ;

	[Cpp2IlInjected.Token(Token = "0x4000253")]
	private static int FNBJJINFJCI;

	[Cpp2IlInjected.Token(Token = "0x4000254")]
	private static int AGAPFBJOGEA;

	[Cpp2IlInjected.Token(Token = "0x4000255")]
	private static int KBPAPBLALNL;

	[Cpp2IlInjected.Token(Token = "0x4000256")]
	private static int BIJDFEFFCHO;

	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private static int JCAHJKJKDDN;

	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private static int JJIEPHHEGDM;

	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private static int MIMNMFCKHFN;

	[Cpp2IlInjected.Token(Token = "0x400025A")]
	private static int AKMALEHJDBE;

	[Cpp2IlInjected.Token(Token = "0x400025B")]
	private static int NPCIJFOGGEN;

	[Cpp2IlInjected.Token(Token = "0x400025C")]
	private static int AABKALIJEIH;

	[Cpp2IlInjected.Token(Token = "0x400025D")]
	private static int OAFGJEEPPKE;

	[Cpp2IlInjected.Token(Token = "0x400025E")]
	private static int FKOHELNNMEM;

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x7BEBB10", Offset = "0x7BEA910", VA = "0x187BEBB10")]
	private IIPKPBDAJNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x7BEBA50", Offset = "0x7BEA850", VA = "0x187BEBA50")]
	public IIPKPBDAJNG(Color JHMKGMDNNGA, Color NIHKIDAKIPH, Color FDDEFEGLOOE, Color? KABHEAMKKJO, Color? LMLEFAKINBP, Color? MGKIBGFLCOM, Texture2D FBAKNCCICNF, Texture2D CMAAEDBCGJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x7BE9460", Offset = "0x7BE8260", VA = "0x187BE9460")]
	internal int BFINKLHJIOK(Material ACHOFOCAKMK, KFAGFHCKBGC OJPBOKHAONG, PNHJKJBHLNC LEMNPMJGKPH, HHFLIOCEMDF PEADOPOCNJH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x7BE93D0", Offset = "0x7BE81D0", VA = "0x187BE93D0")]
	private int BFINKLHJIOK(GPPMDKPHMGP MAKJJJECHHB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x7BEA790", Offset = "0x7BE9590", VA = "0x187BEA790")]
	internal int KPGDAPJAOFP(Material ACHOFOCAKMK, Color DDFLDEGIBML, Color FEBJLJHIIBH, Color FPGBBHHHOKO, Color FBHPCKGHLOF, Color OCGPBMABIPG, Texture2D AEINLBKLOGG, Vector4 AACDMIHGNDI, Texture2D CAGFBOGCILE, Vector4 HAFEOBNEOMJ, float FDNMBKIOHIM, float AHKDGPJBPEN, Texture2D MMOIKPKHCBI, Vector4 DJPPHNNHEOJ, float NHGIHHPLNPG, Texture2D ENAEKGOEKPH, Color MKAGPEHHNPH, Vector4 JGEDEEANHCK, KFAGFHCKBGC OJPBOKHAONG, PNHJKJBHLNC LEMNPMJGKPH, HHFLIOCEMDF PEADOPOCNJH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x7BE9590", Offset = "0x7BE8390", VA = "0x187BE9590")]
	private void FJGJEMNABOD(List<Texture2D> HMPFMHFEMEG, [Out] Texture2DArray OCOAOOCKLGP, [Out] Texture2DArray IHKAHDFGKCL, [Out] Texture2DArray DODJHJLFLGP, [Out] Texture2DArray FLONBMPCKLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x7BE9950", Offset = "0x7BE8750", VA = "0x187BE9950")]
	public void JHEHFLGEBAN(Shader LLBMBDHNHLH, Renderer NHLDFAAJMGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x7BE9AA0", Offset = "0x7BE88A0", VA = "0x187BE9AA0")]
	private void JIPHJLMCAAH(Shader LLBMBDHNHLH, Renderer NHLDFAAJMGK, int HCHILFNIGLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x7BE9750", Offset = "0x7BE8550", VA = "0x187BE9750")]
	private Color HFKHECIAIDM(Color MBFOGKPLHDN, KFAGFHCKBGC HMLAEFBLEHF)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x7BEB360", Offset = "0x7BEA160", VA = "0x187BEB360")]
	private Color LBBDKPPGJGJ(Color HJFJKMPKOAN, KFAGFHCKBGC HMLAEFBLEHF)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x7BEB560", Offset = "0x7BEA360", VA = "0x187BEB560")]
	private bool OFCOFJPDLMD(Texture2D OAKNPHIAHHM, PNHJKJBHLNC CILJJCOEOKI, [Out] Texture2D CEDNAKHGLNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x7BEB4B0", Offset = "0x7BEA2B0", VA = "0x187BEB4B0")]
	private void MEBAIKIDMNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x7BE9550", Offset = "0x7BE8350", VA = "0x187BE9550", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public abstract class PDINNKEAMLI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	public readonly HHFLIOCEMDF PCHAHNFGNIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	protected bool EDAMIFLKDDE;

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public bool CIFGEIMPFBE
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xCA8320", Offset = "0xCA7120", VA = "0x180CA8320")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0xCA7770", Offset = "0xCA6570", VA = "0x180CA7770")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public bool FKPPBFCECGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0xCA88D0", Offset = "0xCA76D0", VA = "0x180CA88D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0xCA7780", Offset = "0xCA6580", VA = "0x180CA7780")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public virtual JICHGCEFAAI.NNADHONNNIJ BMJNMGODCHH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(JICHGCEFAAI.NNADHONNNIJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xC82C40", Offset = "0xC81A40", VA = "0x180C82C40", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public bool CDHADEAAKDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xF9B930", Offset = "0xF9A730", VA = "0x180F9B930")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool POHKMEAFPDO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x7BF1510", Offset = "0x7BF0310", VA = "0x187BF1510")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public bool AJCHAPOEIOG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x7BF1520", Offset = "0x7BF0320", VA = "0x187BF1520")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public bool BEKJMOELHKE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x7BF1530", Offset = "0x7BF0330", VA = "0x187BF1530")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x7BF1550", Offset = "0x7BF0350", VA = "0x187BF1550")]
	protected PDINNKEAMLI(HHFLIOCEMDF BBEKBGOIPEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract AAFDGGPNGMA DKBLFNLECGA(List<EPIKNCDFKGD> EHCEMGOHGBG, List<EPIKNCDFKGD> CHMPLBKBLHN);

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract GICDLIDANGG KGGDDGMGGLJ(uint JGJKFDFMJDO, AvatarSkinnedMeshBoneOrderRemapsData DIGEJOCNOPE);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class PJPOACEPCKH : GOKHMJKOAPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	private AvatarSkinAssetItem MIKMMFCIPEC;

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x7BF17F0", Offset = "0x7BF05F0", VA = "0x187BF17F0")]
	public PJPOACEPCKH(AvatarSkinAssetItem CFMAEPOMDLB, AvatarSkinAssetItem.PNOLNPJHMLA LCJLBEPFKAL, HHFLIOCEMDF PEADOPOCNJH, [Optional] ACMJCOIHLAN? HJKKFEAKMOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x7BF1580", Offset = "0x7BF0380", VA = "0x187BF1580", Slot = "6")]
	public override AAFDGGPNGMA DKBLFNLECGA(List<EPIKNCDFKGD> EHCEMGOHGBG, List<EPIKNCDFKGD> CHMPLBKBLHN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class CLKGOMLCLNG
{
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	private static readonly int[] HAFJEGDHKCI;

	[Cpp2IlInjected.Token(Token = "0x4000266")]
	private static readonly int[] JGAKIOFJLHE;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public static int[] MJHGIHPEECF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x7BE22E0", Offset = "0x7BE10E0", VA = "0x187BE22E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x7BE2340", Offset = "0x7BE1140", VA = "0x187BE2340")]
	public static int[] IPHADCLJIME(bool GGLIGMODCJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x7BE23F0", Offset = "0x7BE11F0", VA = "0x187BE23F0")]
	public static int NBBKHFNDMGE(MOCFDENFFJA BONNMBCDFEB, bool GGLIGMODCJD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x7BE2330", Offset = "0x7BE1130", VA = "0x187BE2330")]
	private static int ILGEHIFJDIM(MOCFDENFFJA BONNMBCDFEB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x7BE23D0", Offset = "0x7BE11D0", VA = "0x187BE23D0")]
	private static int JDDPLEMPAPL(MOCFDENFFJA BONNMBCDFEB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class CHKGAJKKBKA
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class MMHLLINNLKN : IEnumerator<GCOFLMDGPIM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		private GCOFLMDGPIM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		private GCOFLMDGPIM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xA10020", Offset = "0xA0EE20", VA = "0x180A10020")]
		[DebuggerHidden]
		public MMHLLINNLKN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x12A52D0", Offset = "0x12A40D0", VA = "0x1812A52D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x7BF0810", Offset = "0x7BEF610", VA = "0x187BF0810", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
	public static void HFPFGFEDDIH(string FONJFDCCINO, int JGJKFDFMJDO, long KLJOPLFKAGJ, long FIMNMPJGCKB, long PIMLNOAOCAI, long NJBBBIIJHOB, long MMMNEPELCGC, long BFMIKPCOPDN, long LJKPBNJMMJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x7BE1340", Offset = "0x7BE0140", VA = "0x187BE1340")]
	public static BGLABEGMMJM MOHNLMFNDLG(JobHandle FPALPHPAFMM, bool GCOOBDGHCJI, bool GALFFMMILCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x7BE12D0", Offset = "0x7BE00D0", VA = "0x187BE12D0")]
	[IteratorStateMachine(typeof(MMHLLINNLKN))]
	private static IEnumerator<GCOFLMDGPIM> JAAOFPLLNHP(JobHandle BHHPJCAPOMD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class MCIEIMCLCGL
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public enum BPAHMPOGOMG
	{
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		General,
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		ColoredHair
	}

	[Cpp2IlInjected.Token(Token = "0x400026A")]
	public static readonly int FBPPMFMBHOM;

	[Cpp2IlInjected.Token(Token = "0x400026B")]
	public static readonly int IELOLMMHBJF;

	[Cpp2IlInjected.Token(Token = "0x400026C")]
	public static readonly int EFADEOOFKGM;

	[Cpp2IlInjected.Token(Token = "0x400026D")]
	public static readonly int PNOPFIIACII;

	[Cpp2IlInjected.Token(Token = "0x400026E")]
	public static readonly int NFJKJPLLKDE;

	[Cpp2IlInjected.Token(Token = "0x400026F")]
	public static readonly int ILNABHMBMBK;

	[Cpp2IlInjected.Token(Token = "0x4000270")]
	public static readonly int KLOGDNDONPN;

	[Cpp2IlInjected.Token(Token = "0x4000271")]
	public static readonly int MBLHJIDAMMA;

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7BED860", Offset = "0x7BEC660", VA = "0x187BED860")]
	public static bool EPMDPMCAPKA(Material EFCBJICGDPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x7BED7A0", Offset = "0x7BEC5A0", VA = "0x187BED7A0")]
	public static bool EFMMLLGHCMC(Material EFCBJICGDPB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class GOKHMJKOAPP : PDINNKEAMLI
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class LMMGPNHNEPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public EHIFMMNJMNN<GameObject> skinAvatarItemPrefabHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public GOKHMJKOAPP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public Action<string> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public LMMGPNHNEPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x7BED3C0", Offset = "0x7BEC1C0", VA = "0x187BED3C0")]
		internal void HIDDBLPMNBK(GameObject result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x7BED280", Offset = "0x7BEC080", VA = "0x187BED280")]
		internal void BIDNFIJMIGH(string error)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	protected AvatarSkinAssetItem JIEIKKHELLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	protected Material[] GMMPGGEPFGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	private readonly AvatarSkinAssetItem.PNOLNPJHMLA GJCJOMADHGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	private readonly AssetReference LBIMKNADINB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	private readonly ACMJCOIHLAN? NKNFCBLMEAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	private SkinnedMeshRenderer[] BFDCDBFGGLF;

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public override JICHGCEFAAI.NNADHONNNIJ BMJNMGODCHH
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAC0", Offset = "0xA0D8C0", VA = "0x180A0EAC0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(JICHGCEFAAI.NNADHONNNIJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0xA0ECF0", Offset = "0xA0DAF0", VA = "0x180A0ECF0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x7BE7F10", Offset = "0x7BE6D10", VA = "0x187BE7F10")]
	public GOKHMJKOAPP(AvatarSkinAssetItem.PNOLNPJHMLA LCJLBEPFKAL, AssetReference DPHHOMOODAG, Material AHDNIHIHEKO, HHFLIOCEMDF PEADOPOCNJH, JICHGCEFAAI.NNADHONNNIJ IBDJCFBJIAP = (JICHGCEFAAI.NNADHONNNIJ)0L, [Optional] ACMJCOIHLAN? HJKKFEAKMOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x7BE8040", Offset = "0x7BE6E40", VA = "0x187BE8040")]
	public GOKHMJKOAPP(AvatarSkinAssetItem.PNOLNPJHMLA LCJLBEPFKAL, AssetReference DPHHOMOODAG, Material AHDNIHIHEKO, JICHGCEFAAI.NNADHONNNIJ IBDJCFBJIAP = (JICHGCEFAAI.NNADHONNNIJ)0L, [Optional] ACMJCOIHLAN? HJKKFEAKMOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x7BE7A70", Offset = "0x7BE6870", VA = "0x187BE7A70", Slot = "6")]
	public override AAFDGGPNGMA DKBLFNLECGA(List<EPIKNCDFKGD> EHCEMGOHGBG, List<EPIKNCDFKGD> CHMPLBKBLHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x7BE7C90", Offset = "0x7BE6A90", VA = "0x187BE7C90", Slot = "7")]
	public override GICDLIDANGG KGGDDGMGGLJ(uint JGJKFDFMJDO, AvatarSkinnedMeshBoneOrderRemapsData DIGEJOCNOPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x7BE7EA0", Offset = "0x7BE6CA0", VA = "0x187BE7EA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x7BE7C40", Offset = "0x7BE6A40", VA = "0x187BE7C40")]
	protected void KAFNNFCKIPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class MLJNIOJGMHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	private List<int> IJBAHNLPLEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	private List<JAMHBKAGAHJ> OMOCKHHCIPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	private HashSet<Transform> GLELCDACMOG;

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x7BEF0B0", Offset = "0x7BEDEB0", VA = "0x187BEF0B0")]
	public static MLJNIOJGMHO DJFMLIPLBOP(Transform JIJABGNNHPJ, Dictionary<Transform, OutfitType?> KOALDOGJMJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x7BEEDF0", Offset = "0x7BEDBF0", VA = "0x187BEEDF0")]
	private void BFLOHLCPPKK(Transform JIJABGNNHPJ, HHFLIOCEMDF PEADOPOCNJH, Dictionary<Transform, OutfitType?> KOALDOGJMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x7BEF240", Offset = "0x7BEE040", VA = "0x187BEF240")]
	private void IHNHODLCAHE(Transform FKPAPPADGNF, HHFLIOCEMDF PEADOPOCNJH, bool NFIEGACILGM, OutfitType? OPCLBLFNLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x7BEF370", Offset = "0x7BEE170", VA = "0x187BEF370")]
	public KELFLGFJAMP MGOGFGAEPHK(HashSet<string> DCLHEMJMAJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x7BEF760", Offset = "0x7BEE560", VA = "0x187BEF760")]
	public MLJNIOJGMHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class KELFLGFJAMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	private List<JAMHBKAGAHJ> OMOCKHHCIPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	private List<Matrix4x4> FKJJBNCJPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	private Transform[] CPNABAEFMOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	private Matrix4x4[] APNKDIOEKBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	private Dictionary<NEGHLHMINKC, int> OMKJGANGMCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private List<FGNPKHHEOND> DEEGFMHFNMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	private bool KMNNGAIAPIM;

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public int GFOKFGGJOIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x7BEC670", Offset = "0x7BEB470", VA = "0x187BEC670")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public Transform[] GGLNLNGJKAA
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x7BEC6B0", Offset = "0x7BEB4B0", VA = "0x187BEC6B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public Matrix4x4[] LPBBGMPNJGE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x7BED0A0", Offset = "0x7BEBEA0", VA = "0x187BED0A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x7BECC60", Offset = "0x7BEBA60", VA = "0x187BECC60")]
	public void IHNHODLCAHE(Transform FKPAPPADGNF, HHFLIOCEMDF PEADOPOCNJH, OutfitType? OPCLBLFNLDK, bool FBBNJGLKAIA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x7BEC920", Offset = "0x7BEB720", VA = "0x187BEC920")]
	private void IHNHODLCAHE(Transform FKPAPPADGNF, HHFLIOCEMDF PEADOPOCNJH, OutfitType? OPCLBLFNLDK, bool FBBNJGLKAIA, Matrix4x4 BNLLBEGFCAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x7BEC4C0", Offset = "0x7BEB2C0", VA = "0x187BEC4C0")]
	public int ACBGOGEGGJN(NEGHLHMINKC MAKJJJECHHB, bool HMBIEEAKJKJ, [Optional] OutfitType? OPCLBLFNLDK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x7BEC820", Offset = "0x7BEB620", VA = "0x187BEC820")]
	public int HBEFFFMNMCH(HHFLIOCEMDF PEADOPOCNJH, [Optional] OutfitType? OPCLBLFNLDK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7BECE60", Offset = "0x7BEBC60", VA = "0x187BECE60")]
	public void JIKKMANJLFB(NEGHLHMINKC MAKJJJECHHB, Matrix4x4 GDAOAJENDMP, bool HMBIEEAKJKJ = false, [Optional] OutfitType? OPCLBLFNLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x7BECF50", Offset = "0x7BEBD50", VA = "0x187BECF50")]
	public Matrix4x4 NNACJJMLAJK(NEGHLHMINKC MAKJJJECHHB, bool HMBIEEAKJKJ, [Optional] OutfitType? OPCLBLFNLDK)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x13833C0", Offset = "0x13821C0", VA = "0x1813833C0")]
	public void BLOPNGNPFDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x7BED110", Offset = "0x7BEBF10", VA = "0x187BED110")]
	public KELFLGFJAMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct NEGHLHMINKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public readonly string DLJJOBGGDPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public readonly HHFLIOCEMDF HLMNABLPCCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public readonly OutfitType? GDCMLOLJMJL;

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x7BF0CE0", Offset = "0x7BEFAE0", VA = "0x187BF0CE0")]
	public NEGHLHMINKC(string CEPIIIDDDLH, HHFLIOCEMDF PEADOPOCNJH, [Optional] OutfitType? OPCLBLFNLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x7BF0C30", Offset = "0x7BEFA30", VA = "0x187BF0C30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x7BF0B00", Offset = "0x7BEF900", VA = "0x187BF0B00")]
	public bool GOGCPGAMALL(NEGHLHMINKC HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x7BF0A60", Offset = "0x7BEF860", VA = "0x187BF0A60", Slot = "0")]
	public override bool Equals(object GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x7BF0BC0", Offset = "0x7BEF9C0", VA = "0x187BF0BC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct FGNPKHHEOND : IEquatable<FGNPKHHEOND>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public readonly HHFLIOCEMDF HLMNABLPCCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public readonly OutfitType? PGHECAPINCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public readonly int IGALKECABJC;

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x7BE5280", Offset = "0x7BE4080", VA = "0x187BE5280")]
	public FGNPKHHEOND(HHFLIOCEMDF PEADOPOCNJH, int OFALIDBIKHM, [Optional] OutfitType? MJEDBNGGLAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x7BE51B0", Offset = "0x7BE3FB0", VA = "0x187BE51B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x6E2ACA0", Offset = "0x6E29AA0", VA = "0x186E2ACA0")]
	public bool CFCFAOACJNN(HHFLIOCEMDF PEADOPOCNJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x7BE4FA0", Offset = "0x7BE3DA0", VA = "0x187BE4FA0")]
	public bool CKINKFJBIHI(OutfitType? MJEDBNGGLAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x7BE5110", Offset = "0x7BE3F10", VA = "0x187BE5110", Slot = "4")]
	public bool Equals(FGNPKHHEOND HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x7BE5020", Offset = "0x7BE3E20", VA = "0x187BE5020", Slot = "0")]
	public override bool Equals(object GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x7BE5160", Offset = "0x7BE3F60", VA = "0x187BE5160", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct JAMHBKAGAHJ : IEquatable<JAMHBKAGAHJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public readonly Transform LIKPJKOAIAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public readonly bool BANJEFPJFLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public readonly HHFLIOCEMDF OANDLCDONCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public readonly OutfitType? GDCMLOLJMJL;

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x7BEC470", Offset = "0x7BEB270", VA = "0x187BEC470")]
	public JAMHBKAGAHJ(Transform FKPAPPADGNF, bool NFIEGACILGM, HHFLIOCEMDF OEGBPEKOAFF, [Optional] OutfitType? MHCEPKEAJCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x7BEC260", Offset = "0x7BEB060", VA = "0x187BEC260", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x7BEC000", Offset = "0x7BEAE00", VA = "0x187BEC000", Slot = "4")]
	public bool Equals(JAMHBKAGAHJ HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x7BEC100", Offset = "0x7BEAF00", VA = "0x187BEC100", Slot = "0")]
	public override bool Equals(object GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x7BEC1E0", Offset = "0x7BEAFE0", VA = "0x187BEC1E0", Slot = "2")]
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
		[Cpp2IlInjected.Address(RVA = "0x7BE5290", Offset = "0x7BE4090", VA = "0x187BE5290")]
		public static void DespawnHairHemisphere()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
		public void UpdateValues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9B0", Offset = "0xA097B0", VA = "0x180A0A9B0")]
		public FitMeshHemisphereUpdater()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface EIHKDALLJCO
{
	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GNBMLOPAJID(Mesh JIEGCDEFFGO, Matrix4x4 MGGDGJPMBBJ, byte[] ILEDGFFJKMK, bool KLLMIGFFCBP = false, JICHGCEFAAI.NNADHONNNIJ MEFCLCAAJBO = (JICHGCEFAAI.NNADHONNNIJ)0L, int BIGNHIBKBAK = -1, bool GADNNPKNJDH = false);

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ALACKKIJAED(Allocator LNMGNHHGHLL, DCPCHOGDPLH GNGFDKFFBEH, byte NKAJHNKOMIJ, [Optional] IList<int> BMCIOFDAFKE, [Optional] IList<int> IBHANKPKCOB);
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public readonly struct APGDOBPDHHN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public readonly GameObject IJEDPNCMHDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	private readonly AvatarItemMaterial EOOFODKFNGL;

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0xAE6A40", Offset = "0xAE5840", VA = "0x180AE6A40")]
	public APGDOBPDHHN(GameObject IJEDPNCMHDD, AvatarItemMaterial EOOFODKFNGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x7BDE690", Offset = "0x7BDD490", VA = "0x187BDE690")]
	public void DELFKNGALEC(Material EFCBJICGDPB, int ENGFDNNLAAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class NJOCLHALDCC : GDIHEGKDMCK<Task<(GameObject, AvatarItemMaterial)>, APGDOBPDHHN>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct BMMKGLKOMGK : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7BE0D60", Offset = "0x7BDFB60", VA = "0x187BE0D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x7BE1260", Offset = "0x7BE0060", VA = "0x187BE1260", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	private EHIFMMNJMNN<GameObject> FBJNKIOAOBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	private EHIFMMNJMNN<AvatarItemMaterial> NAPCGGKOHFA;

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x7BF1480", Offset = "0x7BF0280", VA = "0x187BF1480")]
	private NJOCLHALDCC(Task<(GameObject, AvatarItemMaterial)> JDEJDGHOHNF, EHIFMMNJMNN<GameObject> IMEFLJGPNGO, EHIFMMNJMNN<AvatarItemMaterial> EJJCHDIGCAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x7BF0E10", Offset = "0x7BEFC10", VA = "0x187BF0E10")]
	public static NJOCLHALDCC BHEMCOAOOEF(AssetReference CALEPOMAPFP, [Optional] AssetReference NFLDABKLLBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x7BF13E0", Offset = "0x7BF01E0", VA = "0x187BF13E0", Slot = "11")]
	protected override APGDOBPDHHN FJMBDODPJBN(Task<(GameObject, AvatarItemMaterial)> LMDIKPOFAPC)
	{
		return default(APGDOBPDHHN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x7BF1360", Offset = "0x7BF0160", VA = "0x187BF1360", Slot = "12")]
	protected override void EDHIJCBDECA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x7BF1230", Offset = "0x7BF0030", VA = "0x187BF1230")]
	[AsyncStateMachine(typeof(BMMKGLKOMGK))]
	private static Task<(GameObject, AvatarItemMaterial)> DHLLFHEHNIM(Task<GameObject> KAGGDEPHKGL, Task<AvatarItemMaterial> BHGCDMKDPDO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class EENCFILCNHC
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class GOAMPANJNMG : GDIHEGKDMCK<Task<MaterialMapAsset>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private EHIFMMNJMNN<MaterialMapAsset> BHHPJCAPOMD;

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x7BE7990", Offset = "0x7BE6790", VA = "0x187BE7990")]
		public GOAMPANJNMG(EHIFMMNJMNN<MaterialMapAsset> BHHPJCAPOMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x7BE7550", Offset = "0x7BE6350", VA = "0x187BE7550", Slot = "11")]
		protected override Material[] FJMBDODPJBN(Task<MaterialMapAsset> JDEJDGHOHNF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x7BE74F0", Offset = "0x7BE62F0", VA = "0x187BE74F0", Slot = "12")]
		protected override void EDHIJCBDECA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class MPCNMDIOIGO : GDIHEGKDMCK<Task<Material[]>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private List<EHIFMMNJMNN<Material>> FPNAGIBIHJN;

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x7BF09F0", Offset = "0x7BEF7F0", VA = "0x187BF09F0")]
		public MPCNMDIOIGO(Task<Material[]> JDEJDGHOHNF, List<EHIFMMNJMNN<Material>> FPNAGIBIHJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x7BF09A0", Offset = "0x7BEF7A0", VA = "0x187BF09A0", Slot = "11")]
		protected override Material[] FJMBDODPJBN(Task<Material[]> LMDIKPOFAPC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x7BF0860", Offset = "0x7BEF660", VA = "0x187BF0860", Slot = "12")]
		protected override void EDHIJCBDECA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	private static readonly IEBEPMGFCGH NHLEILEPJMB;

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x7BE4B00", Offset = "0x7BE3900", VA = "0x187BE4B00")]
	public static EHIFMMNJMNN<Material[]> LKOMMANMKDB(AssetReference[] JEGPOCKHBDH)
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
		public enum JFCEHBPBALA
		{
			[Cpp2IlInjected.Token(Token = "0x4000341")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000342")]
			TeamItem,
			[Cpp2IlInjected.Token(Token = "0x4000343")]
			SkinColor,
			[Cpp2IlInjected.Token(Token = "0x4000344")]
			HairColor,
			[Cpp2IlInjected.Token(Token = "0x4000345")]
			BeardColor,
			[Cpp2IlInjected.Token(Token = "0x4000346")]
			UGCShirtColor
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public enum GFIPPGLOFIH
		{
			[Cpp2IlInjected.Token(Token = "0x4000348")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000349")]
			HairTexture,
			[Cpp2IlInjected.Token(Token = "0x400034A")]
			BeardTexture,
			[Cpp2IlInjected.Token(Token = "0x400034B")]
			UGCShirtTexture
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public enum GPEBBMHBKBD : byte
		{
			[Cpp2IlInjected.Token(Token = "0x400034D")]
			All,
			[Cpp2IlInjected.Token(Token = "0x400034E")]
			LOD0Only,
			[Cpp2IlInjected.Token(Token = "0x400034F")]
			EditorToolAll
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		public struct DJMMLBNMLPC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000350")]
			public readonly Material HCJHJANFJBD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000351")]
			public readonly JFCEHBPBALA IPIGFHKPOKJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000352")]
			public readonly GFIPPGLOFIH FACKBBADLDB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000353")]
			public readonly HHFLIOCEMDF HLMNABLPCCF;

			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x7BE8580", Offset = "0x7BE7380", VA = "0x187BE8580")]
			public DJMMLBNMLPC(Material EFCBJICGDPB, JFCEHBPBALA OJPBOKHAONG, GFIPPGLOFIH LEMNPMJGKPH, HHFLIOCEMDF PEADOPOCNJH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x7C022F0", Offset = "0x7C010F0", VA = "0x187C022F0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x7BE8160", Offset = "0x7BE6F60", VA = "0x187BE8160")]
			public bool GOGCPGAMALL(DJMMLBNMLPC HBLONCAMFLG)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x7C02170", Offset = "0x7C00F70", VA = "0x187C02170", Slot = "0")]
			public override bool Equals(object GLEBGNJJOHG)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x7C02250", Offset = "0x7C01050", VA = "0x187C02250", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		protected class EMBBHFJLBPC : IComparable<EMBBHFJLBPC>, IEquatable<EMBBHFJLBPC>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000354")]
			public int PLNJBCKPDLN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000355")]
			public PlayerAvatarDisplayBase EEHOEKHGKPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000356")]
			public IList<KIBCEDHJJBM> PLAIBDKMAMG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000357")]
			public AvatarItemBodyType BKLPBNPIPHN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000358")]
			public BHPMKNNFDOB FDOILKLEPDL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000359")]
			public bool PBHOGPDIKJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
			[Cpp2IlInjected.Token(Token = "0x400035A")]
			public bool KEBGBKGCJDP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400035B")]
			public int[] DEKFHJHJAFD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400035C")]
			public float JIMKPCCKHFP;

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x7C02FC0", Offset = "0x7C01DC0", VA = "0x187C02FC0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x7C02E70", Offset = "0x7C01C70", VA = "0x187C02E70", Slot = "4")]
			public int CompareTo(EMBBHFJLBPC HBLONCAMFLG)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x7C02EA0", Offset = "0x7C01CA0", VA = "0x187C02EA0", Slot = "5")]
			public bool Equals(EMBBHFJLBPC HBLONCAMFLG)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public EMBBHFJLBPC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		protected abstract class MADBPELMOLA
		{
			[Cpp2IlInjected.Token(Token = "0x200005B")]
			public class DHFFIONJCPO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000360")]
				public readonly Mesh NKMGMDBKPLC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000361")]
				public readonly Material[] GBHDDJOHDGL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000362")]
				public readonly Transform[] AGJLOMJFNHL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000363")]
				public readonly Matrix4x4[] CNIIKNBOFNK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000364")]
				public readonly Transform NACKMMIGBEI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000365")]
				public readonly bool NPEBNBGBPGC;

				[Cpp2IlInjected.Token(Token = "0x60002FE")]
				[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
				protected DHFFIONJCPO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002FF")]
				[Cpp2IlInjected.Address(RVA = "0x7C01BD0", Offset = "0x7C009D0", VA = "0x187C01BD0")]
				public DHFFIONJCPO(Mesh JIEGCDEFFGO, Material[] PHEFLLFKIAJ, bool EOJMNABPIEH, Transform[] KNEFLMDDNHM, Transform EAIHDLDMOLA, Matrix4x4[] BJOADCBBMDL)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000300")]
				[Cpp2IlInjected.Address(RVA = "0x7C01B10", Offset = "0x7C00910", VA = "0x187C01B10")]
				private DHFFIONJCPO(SkinnedMeshRenderer JDOFIMPPNNB, Material[] JAHMICJJFJC)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000301")]
				[Cpp2IlInjected.Address(RVA = "0x7C02080", Offset = "0x7C00E80", VA = "0x187C02080")]
				private DHFFIONJCPO(MeshRenderer ECNJIKGEEHP, Transform EAIHDLDMOLA, Material[] JAHMICJJFJC)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000302")]
				[Cpp2IlInjected.Address(RVA = "0x7C017F0", Offset = "0x7C005F0", VA = "0x187C017F0")]
				public static DHFFIONJCPO EBFGJFMIMFL(Renderer NHLDFAAJMGK, Material[] JAHMICJJFJC)
				{
					return null;
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400035D")]
			public readonly HHFLIOCEMDF HLMNABLPCCF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400035E")]
			public readonly Transform FJCHDDDOJIB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400035F")]
			public readonly bool NFFKAEGIPGB;

			[Cpp2IlInjected.Token(Token = "0x1700008D")]
			public virtual bool CIFGEIMPFBE
			{
				[Cpp2IlInjected.Token(Token = "0x60002F7")]
				[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008E")]
			public virtual bool FKPPBFCECGL
			{
				[Cpp2IlInjected.Token(Token = "0x60002F8")]
				[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008F")]
			public virtual JICHGCEFAAI.NNADHONNNIJ BMJNMGODCHH
			{
				[Cpp2IlInjected.Token(Token = "0x60002F9")]
				[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA097D0", VA = "0x180A0A9D0", Slot = "6")]
				get
				{
					return default(JICHGCEFAAI.NNADHONNNIJ);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000090")]
			public bool FDMKNANIKOO
			{
				[Cpp2IlInjected.Token(Token = "0x60002FA")]
				[Cpp2IlInjected.Address(RVA = "0x7C05AC0", Offset = "0x7C048C0", VA = "0x187C05AC0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x7C05AD0", Offset = "0x7C048D0", VA = "0x187C05AD0")]
			protected MADBPELMOLA(HHFLIOCEMDF PEADOPOCNJH, Transform BKPOLEPPILL, bool NPBPOMCLOME = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract AAFDGGPNGMA DKBLFNLECGA(List<EPIKNCDFKGD> EHCEMGOHGBG, List<EPIKNCDFKGD> CHMPLBKBLHN);

			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract DHFFIONJCPO KGGDDGMGGLJ(int JGJKFDFMJDO, PlayerHandBones IAIBOKHNHIJ);
		}

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		protected class DDICKGEAFHN : MADBPELMOLA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000366")]
			protected readonly BodyPartLODs BFDCDBFGGLF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000367")]
			protected readonly Material[] GMMPGGEPFGM;

			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x7C016F0", Offset = "0x7C004F0", VA = "0x187C016F0")]
			public DDICKGEAFHN(HHFLIOCEMDF PEADOPOCNJH, BodyPartLODs OPMFNBKHIJE, Material AHDNIHIHEKO, [Optional] Transform BKPOLEPPILL, bool NPBPOMCLOME = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x7C01430", Offset = "0x7C00230", VA = "0x187C01430", Slot = "7")]
			public override AAFDGGPNGMA DKBLFNLECGA(List<EPIKNCDFKGD> EHCEMGOHGBG, List<EPIKNCDFKGD> CHMPLBKBLHN)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0x7C014C0", Offset = "0x7C002C0", VA = "0x187C014C0", Slot = "8")]
			public override DHFFIONJCPO KGGDDGMGGLJ(int JGJKFDFMJDO, PlayerHandBones IAIBOKHNHIJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000306")]
			[Cpp2IlInjected.Address(RVA = "0x7C01680", Offset = "0x7C00480", VA = "0x187C01680", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005D")]
		protected class DPLNMLLLLED : MADBPELMOLA
		{
			[Cpp2IlInjected.Token(Token = "0x17000091")]
			public override bool CIFGEIMPFBE
			{
				[Cpp2IlInjected.Token(Token = "0x6000307")]
				[Cpp2IlInjected.Address(RVA = "0xA24630", Offset = "0xA23430", VA = "0x180A24630", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000092")]
			public override bool FKPPBFCECGL
			{
				[Cpp2IlInjected.Token(Token = "0x6000308")]
				[Cpp2IlInjected.Address(RVA = "0x7C02940", Offset = "0x7C01740", VA = "0x187C02940", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000093")]
			public FLJBCFIDHCI DJPCBFHBPPB
			{
				[Cpp2IlInjected.Token(Token = "0x6000309")]
				[Cpp2IlInjected.Address(RVA = "0xA0EAC0", Offset = "0xA0D8C0", VA = "0x180A0EAC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600030A")]
				[Cpp2IlInjected.Address(RVA = "0xA12900", Offset = "0xA11700", VA = "0x180A12900")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0x7C02A00", Offset = "0x7C01800", VA = "0x187C02A00")]
			public DPLNMLLLLED(HHFLIOCEMDF PEADOPOCNJH, Transform BKPOLEPPILL, FLJBCFIDHCI CACIHEEMLOB, bool NPBPOMCLOME = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0x7C028B0", Offset = "0x7C016B0", VA = "0x187C028B0", Slot = "7")]
			public override AAFDGGPNGMA DKBLFNLECGA(List<EPIKNCDFKGD> EHCEMGOHGBG, List<EPIKNCDFKGD> CHMPLBKBLHN)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA097D0", VA = "0x180A0A9D0", Slot = "8")]
			public override DHFFIONJCPO KGGDDGMGGLJ(int JGJKFDFMJDO, PlayerHandBones IAIBOKHNHIJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x7C02990", Offset = "0x7C01790", VA = "0x187C02990", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005E")]
		public class FPNCDIEEIHP
		{
			[Cpp2IlInjected.Token(Token = "0x200005F")]
			public enum EABPPNMCOLF
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
			public static readonly int LIDNPMCNAJD;

			[Cpp2IlInjected.Token(Token = "0x400036A")]
			public static readonly int AAEIGPGKHEN;

			[Cpp2IlInjected.Token(Token = "0x400036B")]
			public static readonly int NJDJCAJDIKH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400036C")]
			protected readonly PJHKHIOBOIP LNNCKOKDICI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400036D")]
			protected readonly FGEPILAAHDB GALCNNCMHGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400036E")]
			protected readonly Animator CFLPMGAOIMJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400036F")]
			protected readonly Transform MCLPOFKGHIP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000370")]
			protected readonly Vector3 BBPMCCNEJOI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000371")]
			protected readonly Transform BNDAOJKGFJJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000372")]
			protected readonly Vector3 BKCNIBLJALH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000373")]
			protected bool MFLFCFJLJEL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000374")]
			protected PPBDPCLLEJH KCKAAHIFIIA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000375")]
			protected bool DKGCCKENCMB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x4000376")]
			protected float OEGIBPINJGI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000377")]
			protected BPFJNBJNHNK<INDOKOCMJGN> FPMCEKMBOBC;

			[Cpp2IlInjected.Token(Token = "0x17000094")]
			public PPBDPCLLEJH PPFCKMEKEFN
			{
				[Cpp2IlInjected.Token(Token = "0x600030F")]
				[Cpp2IlInjected.Address(RVA = "0xA0D000", Offset = "0xA0BE00", VA = "0x180A0D000")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000310")]
				[Cpp2IlInjected.Address(RVA = "0xA0D030", Offset = "0xA0BE30", VA = "0x180A0D030")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000095")]
			public bool EMHDLJBCECD
			{
				[Cpp2IlInjected.Token(Token = "0x6000311")]
				[Cpp2IlInjected.Address(RVA = "0xC2CF80", Offset = "0xC2BD80", VA = "0x180C2CF80")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000312")]
				[Cpp2IlInjected.Address(RVA = "0x7C03EE0", Offset = "0x7C02CE0", VA = "0x187C03EE0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000096")]
			public bool JEKCBDBLLMP
			{
				[Cpp2IlInjected.Token(Token = "0x6000313")]
				[Cpp2IlInjected.Address(RVA = "0xA0ED40", Offset = "0xA0DB40", VA = "0x180A0ED40")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000314")]
				[Cpp2IlInjected.Address(RVA = "0x7C033C0", Offset = "0x7C021C0", VA = "0x187C033C0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000097")]
			public float HHBJJKBBJJN
			{
				[Cpp2IlInjected.Token(Token = "0x6000315")]
				[Cpp2IlInjected.Address(RVA = "0xCA82A0", Offset = "0xCA70A0", VA = "0x180CA82A0")]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000316")]
				[Cpp2IlInjected.Address(RVA = "0x7C03490", Offset = "0x7C02290", VA = "0x187C03490")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000098")]
			public INDOKOCMJGN KOOFKPHGDEF
			{
				[Cpp2IlInjected.Token(Token = "0x6000317")]
				[Cpp2IlInjected.Address(RVA = "0x7C038B0", Offset = "0x7C026B0", VA = "0x187C038B0")]
				get
				{
					return default(INDOKOCMJGN);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x7C038F0", Offset = "0x7C026F0", VA = "0x187C038F0")]
			public bool GOFELJHGCAA(INDOKOCMJGN PNLIABINBOD, object JLFLGDNCANL, EABPPNMCOLF FBACJIPNPNF)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0x7C037B0", Offset = "0x7C025B0", VA = "0x187C037B0")]
			public bool EMNEMEEKLJH(object JLFLGDNCANL)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0x7C04650", Offset = "0x7C03450", VA = "0x187C04650")]
			protected FPNCDIEEIHP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x7C04060", Offset = "0x7C02E60", VA = "0x187C04060")]
			public FPNCDIEEIHP(PJHKHIOBOIP LNNCKOKDICI, PPBDPCLLEJH DGKOIEJNGDG, Animator CFLPMGAOIMJ, Transform MCLPOFKGHIP, Transform BNDAOJKGFJJ, Vector3 BBPMCCNEJOI, Vector3 BKCNIBLJALH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x7C03B10", Offset = "0x7C02910", VA = "0x187C03B10")]
			private void KEFLPFOCNGE(ushort OGCKHEHOLCB, ushort KNBGBCAGDHF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x7C03CE0", Offset = "0x7C02AE0", VA = "0x187C03CE0")]
			protected void LEJGGJBOIMC(ushort OGCKHEHOLCB, ushort KNBGBCAGDHF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x7C03A00", Offset = "0x7C02800", VA = "0x187C03A00")]
			protected void JIJLNODEIKJ(ushort OGCKHEHOLCB, ushort KNBGBCAGDHF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x7C035D0", Offset = "0x7C023D0", VA = "0x187C035D0")]
			protected void BEAIPPIOMIG(ushort OGCKHEHOLCB, ushort KNBGBCAGDHF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x7C03DD0", Offset = "0x7C02BD0", VA = "0x187C03DD0")]
			protected void MGDJEPNDBAH(ushort OGCKHEHOLCB, ushort KNBGBCAGDHF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x7C03700", Offset = "0x7C02500", VA = "0x187C03700")]
			protected void DAJABALHFLH(ushort OGCKHEHOLCB, ushort KNBGBCAGDHF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x7C03760", Offset = "0x7C02560", VA = "0x187C03760")]
			protected void ECIEPMIKDBK(ushort OGCKHEHOLCB, ushort KNBGBCAGDHF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x7C03AC0", Offset = "0x7C028C0", VA = "0x187C03AC0")]
			protected void KACPBCKJFOM(ushort OGCKHEHOLCB, ushort KNBGBCAGDHF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x7C03BC0", Offset = "0x7C029C0", VA = "0x187C03BC0")]
			protected void KNFIDHMFHHE(ushort OGCKHEHOLCB, ushort KNBGBCAGDHF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000060")]
		public class MMNJOAJNCBN : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x4000380")]
			public const int JNNKPIFAMGO = 16;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000381")]
			protected MaterialPropertyBlock MCGCEPANONA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000382")]
			public Color? FIMFEBAELIJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000383")]
			public Color? JGMNDILPAEC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000384")]
			public Color? KCMFMOOHOKG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000385")]
			public Color HOEGHGDBLEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x4000386")]
			public Color GHLHMLJCLGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x4000387")]
			public Color JNHAHDIGDFD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000388")]
			public Texture2D AHOEJDNJHII;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000389")]
			public Texture2D MPHLMKEIPNB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x400038A")]
			protected Dictionary<DJMMLBNMLPC, int> FDALPPCBFML;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x400038B")]
			protected JFCEHBPBALA[] NFKMBJCAACA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x400038C")]
			public Vector4[] APGBAJPJDMD;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x400038D")]
			public Vector4[] MNBNODELOCH;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x400038E")]
			public Vector4[] GFJOBFGPFGB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			public Vector4[] ALBELPENFKA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x4000390")]
			public Vector4[] COOJEBMFGDI;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000391")]
			public Vector4[] PELFJPMLGMK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000392")]
			protected List<Texture2D> HMPFMHFEMEG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000393")]
			protected Vector4[] MKGIFJNPNEK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
			[Cpp2IlInjected.Token(Token = "0x4000394")]
			protected List<Texture2D> DBPFMMMGLFG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
			[Cpp2IlInjected.Token(Token = "0x4000395")]
			protected float[] LNPLCADGJIE;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
			[Cpp2IlInjected.Token(Token = "0x4000396")]
			protected Vector4[] IOOKDBCJOCA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x4000397")]
			protected float[] DKGFGKBDDGE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
			[Cpp2IlInjected.Token(Token = "0x4000398")]
			public float[] ABLMFJHMHAN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
			[Cpp2IlInjected.Token(Token = "0x4000399")]
			protected List<Texture2D> INCHCLIDIPC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
			[Cpp2IlInjected.Token(Token = "0x400039A")]
			protected float[] JNPDNIBGECK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
			[Cpp2IlInjected.Token(Token = "0x400039B")]
			protected List<Texture2D> FKJABDOIMHP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			protected Vector4[] PJMAMGGLDLN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
			[Cpp2IlInjected.Token(Token = "0x400039D")]
			protected float[] LCGOAMDHBNN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
			[Cpp2IlInjected.Token(Token = "0x400039E")]
			protected Vector4[] ICPFBLOKMCM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x400039F")]
			public float[] KHKBPGNDEOF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
			[Cpp2IlInjected.Token(Token = "0x40003A0")]
			public Texture2DArray FJBNIOOAMNN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x40003A1")]
			public Texture2DArray FFACMBGABAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
			[Cpp2IlInjected.Token(Token = "0x40003A2")]
			public Texture2DArray GBONCDIHMFH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
			[Cpp2IlInjected.Token(Token = "0x40003A3")]
			public Texture2DArray DGACLGMKMHJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x40003A4")]
			protected bool LIKJHDIAHAM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
			[Cpp2IlInjected.Token(Token = "0x40003A5")]
			protected int FMLIFGGKDGG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
			[Cpp2IlInjected.Token(Token = "0x40003A6")]
			protected Vector2? LBGHOPGDMHM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
			[Cpp2IlInjected.Token(Token = "0x40003A7")]
			protected TextureFormat CEFCANGEJKH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
			[Cpp2IlInjected.Token(Token = "0x40003A8")]
			protected Vector2? JJLDEDFPANA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
			[Cpp2IlInjected.Token(Token = "0x40003A9")]
			protected TextureFormat GFIEKEHGPLD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
			[Cpp2IlInjected.Token(Token = "0x40003AA")]
			protected Vector2? DBLAKHFOAEC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
			[Cpp2IlInjected.Token(Token = "0x40003AB")]
			protected TextureFormat NHHDMFBJDPA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
			[Cpp2IlInjected.Token(Token = "0x40003AC")]
			protected Vector2? AEGADNGBGBF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
			[Cpp2IlInjected.Token(Token = "0x40003AD")]
			protected TextureFormat LGCEFLAGHNN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
			[Cpp2IlInjected.Token(Token = "0x40003AE")]
			protected bool OMPJCPABCDP;

			[Cpp2IlInjected.Token(Token = "0x40003AF")]
			protected static int CKBGLOBFHGA;

			[Cpp2IlInjected.Token(Token = "0x40003B0")]
			protected static int NPNEOGNGIBD;

			[Cpp2IlInjected.Token(Token = "0x40003B1")]
			protected static int DHNIMMPKKHB;

			[Cpp2IlInjected.Token(Token = "0x40003B2")]
			protected static int AOLJBILPCNP;

			[Cpp2IlInjected.Token(Token = "0x40003B3")]
			protected static int PICFLHHEEFK;

			[Cpp2IlInjected.Token(Token = "0x40003B4")]
			protected static int BOJLKPPJJAM;

			[Cpp2IlInjected.Token(Token = "0x40003B5")]
			protected static int GPECJANGKOB;

			[Cpp2IlInjected.Token(Token = "0x40003B6")]
			protected static int DENDKNPECLJ;

			[Cpp2IlInjected.Token(Token = "0x40003B7")]
			protected static int FNBJJINFJCI;

			[Cpp2IlInjected.Token(Token = "0x40003B8")]
			protected static int AGAPFBJOGEA;

			[Cpp2IlInjected.Token(Token = "0x40003B9")]
			protected static int KBPAPBLALNL;

			[Cpp2IlInjected.Token(Token = "0x40003BA")]
			protected static int BIJDFEFFCHO;

			[Cpp2IlInjected.Token(Token = "0x40003BB")]
			protected static int JCAHJKJKDDN;

			[Cpp2IlInjected.Token(Token = "0x40003BC")]
			protected static int JJIEPHHEGDM;

			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			protected static int MIMNMFCKHFN;

			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			protected static int AKMALEHJDBE;

			[Cpp2IlInjected.Token(Token = "0x40003BF")]
			protected static int NPCIJFOGGEN;

			[Cpp2IlInjected.Token(Token = "0x40003C0")]
			protected static int AABKALIJEIH;

			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			protected static int OAFGJEEPPKE;

			[Cpp2IlInjected.Token(Token = "0x40003C2")]
			protected static int FKOHELNNMEM;

			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x7C08130", Offset = "0x7C06F30", VA = "0x187C08130")]
			protected MMNJOAJNCBN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x7C080A0", Offset = "0x7C06EA0", VA = "0x187C080A0")]
			public MMNJOAJNCBN(Color JHMKGMDNNGA, Color NIHKIDAKIPH, Color FDDEFEGLOOE, Color? KABHEAMKKJO, Color? LMLEFAKINBP, Color? MGKIBGFLCOM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x7C05B30", Offset = "0x7C04930", VA = "0x187C05B30")]
			public int BFINKLHJIOK(Material ACHOFOCAKMK, JFCEHBPBALA OJPBOKHAONG, GFIPPGLOFIH LEMNPMJGKPH, HHFLIOCEMDF PEADOPOCNJH)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x7C05C20", Offset = "0x7C04A20", VA = "0x187C05C20")]
			public int BFINKLHJIOK(DJMMLBNMLPC MAKJJJECHHB)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x7C06E30", Offset = "0x7C05C30", VA = "0x187C06E30")]
			public int KPGDAPJAOFP(Material ACHOFOCAKMK, Color DDFLDEGIBML, Color FEBJLJHIIBH, Color FPGBBHHHOKO, Color FBHPCKGHLOF, Color OCGPBMABIPG, Texture2D AEINLBKLOGG, Vector4 AACDMIHGNDI, Texture2D CAGFBOGCILE, Vector4 HAFEOBNEOMJ, float FDNMBKIOHIM, float AHKDGPJBPEN, Texture2D MMOIKPKHCBI, Vector4 DJPPHNNHEOJ, float NHGIHHPLNPG, Texture2D ENAEKGOEKPH, float CBEJKLCJEEL, Color MKAGPEHHNPH, Vector4 JGEDEEANHCK, JFCEHBPBALA OJPBOKHAONG, GFIPPGLOFIH LEMNPMJGKPH, HHFLIOCEMDF PEADOPOCNJH)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x7C05CF0", Offset = "0x7C04AF0", VA = "0x187C05CF0")]
			protected void FJGJEMNABOD([Out] Texture2DArray OCOAOOCKLGP, [Out] Texture2DArray IHKAHDFGKCL, [Out] Texture2DArray DODJHJLFLGP, [Out] Texture2DArray FLONBMPCKLH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x7C060A0", Offset = "0x7C04EA0", VA = "0x187C060A0")]
			public void JHEHFLGEBAN(PlayerAvatarDisplayBase CLNNHINKCAH, Renderer NHLDFAAJMGK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x7C06310", Offset = "0x7C05110", VA = "0x187C06310")]
			protected void JIPHJLMCAAH(PlayerAvatarDisplayBase CLNNHINKCAH, Renderer NHLDFAAJMGK, int HCHILFNIGLA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x7C05EB0", Offset = "0x7C04CB0", VA = "0x187C05EB0")]
			private Color HFKHECIAIDM(Color MBFOGKPLHDN, JFCEHBPBALA HMLAEFBLEHF)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x7C07BC0", Offset = "0x7C069C0", VA = "0x187C07BC0")]
			private Color PHBGNKHFIMA(Color JNGELFJLIFK, JFCEHBPBALA HMLAEFBLEHF)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x7C07B30", Offset = "0x7C06930", VA = "0x187C07B30")]
			protected void MEBAIKIDMNK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x7C05CB0", Offset = "0x7C04AB0", VA = "0x187C05CB0", Slot = "4")]
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

			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(RVA = "0x7C0F8A0", Offset = "0x7C0E6A0", VA = "0x187C0F8A0")]
			public void IELNMJMBBPA(HHFLIOCEMDF PEADOPOCNJH, [Out] Transform IPCOMOHMNHK, [Out] Transform[] KNEFLMDDNHM)
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
		private sealed class PIBMECEALFD : IEnumerable<SkinnedMeshRenderer>, IEnumerable, IEnumerator<SkinnedMeshRenderer>, IEnumerator, IDisposable
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

			[Cpp2IlInjected.Token(Token = "0x17000099")]
			SkinnedMeshRenderer IEnumerator<SkinnedMeshRenderer>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600033F")]
				[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0xED60C0", Offset = "0xED4EC0", VA = "0x180ED60C0")]
			[DebuggerHidden]
			public PIBMECEALFD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x7C08D80", Offset = "0x7C07B80", VA = "0x187C08D80", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x7C09000", Offset = "0x7C07E00", VA = "0x187C09000", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x7C08F50", Offset = "0x7C07D50", VA = "0x187C08F50", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<SkinnedMeshRenderer> IEnumerable<SkinnedMeshRenderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x7C08F50", Offset = "0x7C07D50", VA = "0x187C08F50", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000065")]
		[CompilerGenerated]
		private sealed class HNOKIFDIFCA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003D6")]
			public PlayerAvatarDisplayBase display;

			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public HNOKIFDIFCA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0x7C04960", Offset = "0x7C03760", VA = "0x187C04960")]
			internal bool EBDGACNAMID()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class DPIKMCAAKFL : IEnumerator<GCOFLMDGPIM>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003D7")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003D8")]
			private GCOFLMDGPIM <>2__current;

			[Cpp2IlInjected.Token(Token = "0x1700009B")]
			private GCOFLMDGPIM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000349")]
				[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0xA10020", Offset = "0xA0EE20", VA = "0x180A10020")]
			[DebuggerHidden]
			public DPIKMCAAKFL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(RVA = "0x7C02510", Offset = "0x7C01310", VA = "0x187C02510", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0x7C02860", Offset = "0x7C01660", VA = "0x187C02860", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000067")]
		[CompilerGenerated]
		private struct EGJOIKBGILL : IAsyncStateMachine
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
			public PALPOLFGBAG avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003DD")]
			private bool <forceRebuild>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003DE")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x7C02A70", Offset = "0x7C01870", VA = "0x187C02A70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0x7C02E10", Offset = "0x7C01C10", VA = "0x187C02E10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000068")]
		[CompilerGenerated]
		private sealed class JGEJJHNJNMF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003DF")]
			public string overrideIdentifier;

			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public JGEJJHNJNMF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0x7C051A0", Offset = "0x7C03FA0", VA = "0x187C051A0")]
			internal bool PHBDJFHBKIM(KIBCEDHJJBM selection)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000069")]
		[CompilerGenerated]
		private sealed class FGAKFPLGLOH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003E0")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003E1")]
			public AvatarItemBodyType avatarItemBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003E2")]
			public Func<HMBEFKLHMDK<Dictionary<string, EHIFMMNJMNN<Texture2D>>>> <>9__2;

			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public FGAKFPLGLOH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x7C03180", Offset = "0x7C01F80", VA = "0x187C03180")]
			internal (OJJOHCMLHDB, HMBEFKLHMDK<Dictionary<string, EHIFMMNJMNN<Texture2D>>>) HACMLPPIKEF(Dictionary<string, KDOBCGFCCMB> avatarItems)
			{
				return default((OJJOHCMLHDB, HMBEFKLHMDK<Dictionary<string, EHIFMMNJMNN<Texture2D>>>));
			}

			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x7C03110", Offset = "0x7C01F10", VA = "0x187C03110")]
			internal HMBEFKLHMDK<Dictionary<string, EHIFMMNJMNN<Texture2D>>> BABOEHFFKAK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x7C03380", Offset = "0x7C02180", VA = "0x187C03380")]
			internal void HNPBIMNKOIJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006A")]
		[CompilerGenerated]
		private sealed class OIHKLBPGBNL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003E3")]
			public Transform transformToCheck;

			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public OIHKLBPGBNL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0x7C08A90", Offset = "0x7C07890", VA = "0x187C08A90")]
			internal bool CBFMHGENNJJ(SkinnedMeshRenderer x)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006B")]
		[CompilerGenerated]
		private struct LBLMGHLFKAG : IAsyncStateMachine
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

			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x7C05890", Offset = "0x7C04690", VA = "0x187C05890", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0x7C05A60", Offset = "0x7C04860", VA = "0x187C05A60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		protected static readonly int PEEDHBDBLMF;

		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		protected static readonly int OHPDNJOAKNH;

		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		protected static readonly int HGMOOECCGIG;

		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		protected static readonly int HMIJJGCEMLK;

		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		protected static readonly int MOLJAJAIEAP;

		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		protected static readonly int OHOHBALCGFL;

		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		protected static readonly int[] OHBIOGAGBCE;

		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		protected static readonly int[] OGJACMNOFHH;

		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		protected static readonly int[] BKNHFPBMCNC;

		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		protected static readonly int[] JDONGNGPBEF;

		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		protected static readonly int[] GJAJDCOMPBK;

		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		protected static readonly int[] HBLLMPDIGJL;

		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		protected static List<PlayerAvatarDisplayBase> NIOMPLJJLNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		protected COINFHPMIAA KADBLHEOBNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		protected bool AMJELANJDHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		protected bool GOOCNEPCJCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		[SerializeField]
		public AvatarBodyShapeVault BodyShapeVault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		[SerializeField]
		public AvatarFaceShapeVault FaceShapeVault;

		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		protected static readonly int[] AKEMFOIFPBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		[SerializeField]
		protected Material bodyPartMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		protected Dictionary<DJMMLBNMLPC, Material> PBKAAJFNCNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		protected Dictionary<DJMMLBNMLPC, Material> ACOJNHMPNAI;

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
		protected Material HHBCPPEHJAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		protected IGHDDCGAHHH ICMEPOLLEGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		private PPBDPCLLEJH JMKECEGOFOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		private PPBDPCLLEJH GGJAJHDHAOA;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		protected Material BDDMMPKAPDK;

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
		protected FitMeshHemisphere NIKNKPKMNGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		protected bool PMAKGLFJCKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		protected CAOCJKDHCLC EELMNNLEMLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		protected bool APAGDMINOBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		protected AnchorParamsRestrictions GDIHDCPBMDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		protected bool NPEEOFKEINE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		protected Transform HPIEAGEGIBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		protected bool BHLELKJHJEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B1")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		protected bool NKHLKHNPPML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		protected Vector3 FGIBJBANHAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		protected Quaternion IDMEBEGIOAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		protected Vector2 LNAMFPFLICG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		protected FitMeshHemisphere MOCCJJBNDKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		[SerializeField]
		[DBPOJNFABNN(CBEHFHOOABN.SelfAndChildren, false, false, false)]
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
		protected Collider[] PCEKHLBMODB;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		protected Collider[] NEHPDMCNCCG;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		protected FPNCDIEEIHP[] JANLJFIJOML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		[SerializeField]
		protected Mesh faceMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public Dictionary<Renderer, MMNJOAJNCBN> currentPropertyBlocks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		protected Dictionary<Renderer, MMNJOAJNCBN> KMIJHHGHPIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		protected MLJNIOJGMHO PIODJOHNEIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		protected OJJOHCMLHDB JKMFLPDGEAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public MOCFDENFFJA DistanceBand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x284")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		protected int MBAHBPBPKDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		protected (bool isLodForced, int forcedLOD) MODJLIDFPBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		protected BPFJNBJNHNK<FGEPILAAHDB> FPMCEKMBOBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		protected bool BIBDOFMFFEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		protected Dictionary<KIBCEDHJJBM, List<DJMMLBNMLPC>> HEMFAKPIKJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		protected Dictionary<KIBCEDHJJBM, List<DJMMLBNMLPC>> LPHMMOPEBLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		protected readonly Dictionary<string, EHIFMMNJMNN<Texture2D>> EACBJOEMBGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		protected readonly Dictionary<string, EHIFMMNJMNN<Texture2D>> DJNLDBHICOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		protected bool MBGGGJBOFAD;

		[Cpp2IlInjected.Token(Token = "0x4000319")]
		protected static int MBNLCLNPECP;

		[Cpp2IlInjected.Token(Token = "0x400031A")]
		protected static List<EMBBHFJLBPC> OENEMOKPOCH;

		[Cpp2IlInjected.Token(Token = "0x400031B")]
		protected static List<EMBBHFJLBPC> MMIKJODIOOL;

		[Cpp2IlInjected.Token(Token = "0x400031C")]
		protected static BGLABEGMMJM HCCPBMKNHIN;

		[Cpp2IlInjected.Token(Token = "0x400031D")]
		protected static Func<List<EMBBHFJLBPC>, EMBBHFJLBPC> DOAIHAJHKII;

		[Cpp2IlInjected.Token(Token = "0x400031E")]
		protected static bool FACMHOMOHBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		protected Color? FNCBMMJOKDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E4")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		protected bool PICBIDDMELO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		protected Color PBJPDPALLFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		protected Color HMMHHGKKIAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		protected Color LHBDFIHEPAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		protected AvatarHairPattern LLBGDCHCLKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		protected FLJBCFIDHCI GDNOKDBGGPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		protected Color HHFOMCIADCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		protected Color GEAOHPKPCGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		protected AvatarHairPattern AAECFFIDMJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		protected FLJBCFIDHCI FKBDJICFIPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		protected FLJBCFIDHCI NFALKKJOILM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		protected Color NONGLEHHCHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		private AdditionalFeetData MPDNLKDNBCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		protected KIBCEDHJJBM? NBFNLOLKHPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		protected Texture GFMLCKNALKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		protected Color BHMOPNEMBPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		protected readonly IList<KIBCEDHJJBM> KGOJJLENEFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		protected readonly IList<KIBCEDHJJBM> PLJJDKJCNMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		private AvatarItemBodyType APLEOHKJOLG;

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
		protected GEMMNCOLLPK _currentNoseType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D4")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		[SerializeField]
		protected bool _hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D5")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		protected GPEBBMHBKBD MALEJEGCBLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		protected int[] EFGPDFAIHDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E0")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		protected bool KOEPBNIHEHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E8")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		protected int[] NGGIOFOKDPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F0")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		protected bool LCCCLJBNJAJ;

		[Cpp2IlInjected.Token(Token = "0x400033C")]
		private static readonly JICHGCEFAAI.NNADHONNNIJ AOGGHKOHAPC;

		[Cpp2IlInjected.Token(Token = "0x400033D")]
		private static readonly JICHGCEFAAI.NNADHONNNIJ ICJGGBIBHIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F1")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		protected bool DNNLALKBEPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F8")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		protected MNCBCAJDKJB IMPNJBFPIAD;

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public string CNIGFBONFEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0xA0EAF0", Offset = "0xA0D8F0", VA = "0x180A0EAF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0xA0ED00", Offset = "0xA0DB00", VA = "0x180A0ED00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public bool HKGOFOAEEKF
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0xC26320", Offset = "0xC25120", VA = "0x180C26320")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0xC25B50", Offset = "0xC24950", VA = "0x180C25B50")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public virtual bool NOGBOLIIMJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public bool MFCLOIHFENF
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x7BFF450", Offset = "0x7BFE250", VA = "0x187BFF450")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public virtual bool AAHCLMJKAGK
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public virtual bool PMEDCNKNNCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0xA24630", Offset = "0xA23430", VA = "0x180A24630", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public virtual bool IGBGILPBMDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public IGHDDCGAHHH JJKJIGFHEAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0xAC3570", Offset = "0xAC2370", VA = "0x180AC3570")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x7BFFC20", Offset = "0x7BFEA20", VA = "0x187BFFC20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public PPBDPCLLEJH AONEOOBHNPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0xACE460", Offset = "0xACD260", VA = "0x180ACE460")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x7C00020", Offset = "0x7BFEE20", VA = "0x187C00020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public PPBDPCLLEJH OIOPJCLOHKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0xAE1950", Offset = "0xAE0750", VA = "0x180AE1950")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x7C002F0", Offset = "0x7BFF0F0", VA = "0x187C002F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		protected Material EBCLIJBOBEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x7BF47E0", Offset = "0x7BF35E0", VA = "0x187BF47E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		protected Material LKPFDAPBAAO
		{
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x7BF7CC0", Offset = "0x7BF6AC0", VA = "0x187BF7CC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public bool PDBNEHIFMCB
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x2228B40", Offset = "0x2227940", VA = "0x182228B40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public PlayerFacialAnimatorBase CDLBBMBICCK
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0xAE1B60", Offset = "0xAE0960", VA = "0x180AE1B60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public FPNCDIEEIHP[] JOGDADGBCOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x7BFEFD0", Offset = "0x7BFDDD0", VA = "0x187BFEFD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public FPNCDIEEIHP OKIILKPHEGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x7BFF650", Offset = "0x7BFE450", VA = "0x187BFF650")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public FPNCDIEEIHP ALGEJADCKAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x7BFF680", Offset = "0x7BFE480", VA = "0x187BFF680")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public Mesh PDHMHCGPAFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0xAE2310", Offset = "0xAE1110", VA = "0x180AE2310")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		protected MLJNIOJGMHO MOINOEAIMDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x7BF8930", Offset = "0x7BF7730", VA = "0x187BF8930")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		protected OJJOHCMLHDB JMKBAGJFAJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0xAE26A0", Offset = "0xAE14A0", VA = "0x180AE26A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x7BF4C00", Offset = "0x7BF3A00", VA = "0x187BF4C00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		protected bool GALFFMMILCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0xA24630", Offset = "0xA23430", VA = "0x180A24630")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public bool NHJHEILAGAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x7BFF640", Offset = "0x7BFE440", VA = "0x187BFF640")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public int IFBDELOGPLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x1237E50", Offset = "0x1236C50", VA = "0x181237E50")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x7C00230", Offset = "0x7BFF030", VA = "0x187C00230")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public int GKOBCIGHLPC
		{
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x7BFFF70", Offset = "0x7BFED70", VA = "0x187BFFF70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		protected virtual bool JPGEBOPGKAB
		{
			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		protected virtual int[] IBCOJKAKIDI
		{
			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x7BF3640", Offset = "0x7BF2440", VA = "0x187BF3640", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		protected bool KMHPFKKOMIM
		{
			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x7BF44F0", Offset = "0x7BF32F0", VA = "0x187BF44F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		protected static bool IAPOPOPFLBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public bool MFBLHKGFMGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x1237070", Offset = "0x1235E70", VA = "0x181237070")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x7C00500", Offset = "0x7BFF300", VA = "0x187C00500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public IEnumerable<SkinnedMeshRenderer> JDGDNLOJEFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x7BFEEA0", Offset = "0x7BFDCA0", VA = "0x187BFEEA0")]
			[IteratorStateMachine(typeof(PIBMECEALFD))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public bool KNAODMGEKMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x1237A00", Offset = "0x1236800", VA = "0x181237A00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x1237E00", Offset = "0x1236C00", VA = "0x181237E00")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public JBJPAOBCEOK BKHGFCJHLHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x7BFEF20", Offset = "0x7BFDD20", VA = "0x187BFEF20")]
			get
			{
				return default(JBJPAOBCEOK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public static bool EFOHKIDAMBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x7BFF380", Offset = "0x7BFE180", VA = "0x187BFF380")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		protected static BGLABEGMMJM PLKFBCHBDDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x7BF78F0", Offset = "0x7BF66F0", VA = "0x187BF78F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0x7BF1B10", Offset = "0x7BF0910", VA = "0x187BF1B10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		protected Color JGMNDILPAEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0x7BF89D0", Offset = "0x7BF77D0", VA = "0x187BF89D0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		protected Color KCMFMOOHOKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000291")]
			[Cpp2IlInjected.Address(RVA = "0x7BF4E80", Offset = "0x7BF3C80", VA = "0x187BF4E80")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		protected Texture2D DMHFMOOOLFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000292")]
			[Cpp2IlInjected.Address(RVA = "0x7BF4A20", Offset = "0x7BF3820", VA = "0x187BF4A20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		protected Color HOEGHGDBLEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(RVA = "0x7BFA4D0", Offset = "0x7BF92D0", VA = "0x187BFA4D0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		protected Color GHLHMLJCLGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000299")]
			[Cpp2IlInjected.Address(RVA = "0x7BF4570", Offset = "0x7BF3370", VA = "0x187BF4570")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public FLJBCFIDHCI PDIGMLNEOHF
		{
			[Cpp2IlInjected.Token(Token = "0x600029A")]
			[Cpp2IlInjected.Address(RVA = "0x7BFEF90", Offset = "0x7BFDD90", VA = "0x187BFEF90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		protected Texture2D AFHKIOGGDJM
		{
			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0x7BF8430", Offset = "0x7BF7230", VA = "0x187BF8430")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public float LBPOMLOHONO
		{
			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0x7BFEFB0", Offset = "0x7BFDDB0", VA = "0x187BFEFB0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public float OGAEPCIGEMF
		{
			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0x7BFF430", Offset = "0x7BFE230", VA = "0x187BFF430")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public bool MCLIJENJDHK
		{
			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x7BFEF80", Offset = "0x7BFDD80", VA = "0x187BFEF80")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x7BFF9F0", Offset = "0x7BFE7F0", VA = "0x187BFF9F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action LNIMDCHPPGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x7BFEC00", Offset = "0x7BFDA00", VA = "0x187BFEC00")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x7BFF750", Offset = "0x7BFE550", VA = "0x187BFF750")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action ECBAEIMEIHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x7BFEB60", Offset = "0x7BFD960", VA = "0x187BFEB60")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x7BFF6B0", Offset = "0x7BFE4B0", VA = "0x187BFF6B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action IKLLHINPAMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x7BFECA0", Offset = "0x7BFDAA0", VA = "0x187BFECA0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x7BFF7F0", Offset = "0x7BFE5F0", VA = "0x187BFF7F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action EGMDMPJMKBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x7BFED40", Offset = "0x7BFDB40", VA = "0x187BFED40")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x7BFF890", Offset = "0x7BFE690", VA = "0x187BFF890")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<PJHKHIOBOIP, INDOKOCMJGN> HHCHDIENILA
		{
			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x7BFEDE0", Offset = "0x7BFDBE0", VA = "0x187BFEDE0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x7BFF930", Offset = "0x7BFE730", VA = "0x187BFF930")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x7BFB410", Offset = "0x7BFA210", VA = "0x187BFB410")]
		public bool SetDeformation(bool AMJELANJDHF, bool GOOCNEPCJCL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x7BF67B0", Offset = "0x7BF55B0", VA = "0x187BF67B0")]
		protected static Material GIMPGKNNPNO(Dictionary<DJMMLBNMLPC, Material> MNEACBJKJAL, Material LCPABANLMJF, JFCEHBPBALA OJPBOKHAONG, GFIPPGLOFIH LEMNPMJGKPH, HHFLIOCEMDF PEADOPOCNJH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x7BF39A0", Offset = "0x7BF27A0", VA = "0x187BF39A0")]
		protected void CNJLBAMBKDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x7BF18F0", Offset = "0x7BF06F0", VA = "0x187BF18F0")]
		protected bool ADLHAHPOKGO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x7BF4B10", Offset = "0x7BF3910", VA = "0x187BF4B10")]
		protected void EHEJBBKLAFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x7BF7C60", Offset = "0x7BF6A60", VA = "0x187BF7C60", Slot = "10")]
		protected virtual void ILOHKFICHCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x7BF96B0", Offset = "0x7BF84B0", VA = "0x187BF96B0")]
		public int MeshesAtLODCount(int ADBDFCFJNHM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x7BF1CE0", Offset = "0x7BF0AE0", VA = "0x187BF1CE0")]
		protected static void AFHFHMOLLMA(Dictionary<KIBCEDHJJBM, List<DJMMLBNMLPC>> MNMCPCDGAHI, MADBPELMOLA BGEKACALGGD, Material LCPABANLMJF, JFCEHBPBALA HMLAEFBLEHF, GFIPPGLOFIH CILJJCOEOKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x7BF2D80", Offset = "0x7BF1B80", VA = "0x187BF2D80")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x7BF7520", Offset = "0x7BF6320", VA = "0x187BF7520")]
		protected void IDCKDHPINPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x7BFA220", Offset = "0x7BF9020", VA = "0x187BFA220")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "11")]
		protected virtual void EMKEDBLLGHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x7BF9570", Offset = "0x7BF8370", VA = "0x187BF9570")]
		protected static void MPHLINKPJCK(List<Material> ECACEJOHBAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x7BF3410", Offset = "0x7BF2210", VA = "0x187BF3410")]
		protected static void BFKJAMHMGJC(Dictionary<DJMMLBNMLPC, Material> MNEACBJKJAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x7BF8FC0", Offset = "0x7BF7DC0", VA = "0x187BF8FC0")]
		protected static void MBGBFBHPLFC(Dictionary<Renderer, MMNJOAJNCBN> ALPPGDDGKKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x7BF9BF0", Offset = "0x7BF89F0", VA = "0x187BF9BF0")]
		protected void NKEIOPNDBLL(SkinnedMeshRenderer[] DNOJAJAILBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x7BF7BC0", Offset = "0x7BF69C0", VA = "0x187BF7BC0")]
		protected void ILHKOPBPDNO(SkinnedMeshRenderer JDOFIMPPNNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x7BF7AF0", Offset = "0x7BF68F0", VA = "0x187BF7AF0")]
		protected void ILHKOPBPDNO(MeshRenderer ECNJIKGEEHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x7BF4CA0", Offset = "0x7BF3AA0", VA = "0x187BF4CA0")]
		protected void EKGNIHNCEMM(List<EPIKNCDFKGD> NJCFEAEALAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x7BF36D0", Offset = "0x7BF24D0", VA = "0x187BF36D0")]
		protected void CBMNAFFOCKF(Dictionary<string, EHIFMMNJMNN<Texture2D>> MNMCPCDGAHI, bool AJCADHLNDOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x7BF8980", Offset = "0x7BF7780", VA = "0x187BF8980")]
		protected void LFNFCLGHANF(Dictionary<KIBCEDHJJBM, List<DJMMLBNMLPC>> MNMCPCDGAHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x7BF6BF0", Offset = "0x7BF59F0", VA = "0x187BF6BF0")]
		public float GetHandOpenClosedAxis(PJHKHIOBOIP LNNCKOKDICI)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x7BFBCD0", Offset = "0x7BFAAD0", VA = "0x187BFBCD0")]
		public void SetHandOpenClosedAxis(PJHKHIOBOIP LNNCKOKDICI, float BKEFHPIJGLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x7BF6C30", Offset = "0x7BF5A30", VA = "0x187BF6C30")]
		public INDOKOCMJGN GetHandVisualState(PJHKHIOBOIP LNNCKOKDICI)
		{
			return default(INDOKOCMJGN);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x7BF24C0", Offset = "0x7BF12C0", VA = "0x187BF24C0")]
		public bool AddHandVisualStateToken(PJHKHIOBOIP LNNCKOKDICI, INDOKOCMJGN EOPIDEAHBKO, object JLFLGDNCANL, FPNCDIEEIHP.EABPPNMCOLF FBACJIPNPNF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x7BFD4E0", Offset = "0x7BFC2E0", VA = "0x187BFD4E0")]
		public void SetWatchHand(PJHKHIOBOIP LNNCKOKDICI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x7BFD5A0", Offset = "0x7BFC3A0", VA = "0x187BFD5A0")]
		public void SetWatchHands(bool AOILMBLFIJG, bool DLIELHGPBLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x7BFAAB0", Offset = "0x7BF98B0", VA = "0x187BFAAB0")]
		public bool RemoveHandVisualStateToken(PJHKHIOBOIP LNNCKOKDICI, object JLFLGDNCANL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x7BF6CB0", Offset = "0x7BF5AB0", VA = "0x187BF6CB0")]
		public bool GetThumbsUpActive(PJHKHIOBOIP LNNCKOKDICI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x7BFCF80", Offset = "0x7BFBD80", VA = "0x187BFCF80")]
		public void SetThumbsUpActive(PJHKHIOBOIP LNNCKOKDICI, bool ONOPFOGIDMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x7BF6C70", Offset = "0x7BF5A70", VA = "0x187BF6C70")]
		public bool GetHandshakeActive(PJHKHIOBOIP LNNCKOKDICI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x7BFBD20", Offset = "0x7BFAB20", VA = "0x187BFBD20")]
		public void SetHandshakeActive(PJHKHIOBOIP LNNCKOKDICI, bool IPNJGOGGLNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x7BF6390", Offset = "0x7BF5190", VA = "0x187BF6390")]
		public void ForceUpdateHandsVisualState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x7BF42F0", Offset = "0x7BF30F0", VA = "0x187BF42F0")]
		public static void ClearQueuedBuilds()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x7BF9DC0", Offset = "0x7BF8BC0", VA = "0x187BF9DC0")]
		private static void OIEHDADNDPE(Scene EEMDMFPCGLE, LoadSceneMode FIAIMOBPCDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x7BF91A0", Offset = "0x7BF7FA0", VA = "0x187BF91A0")]
		protected static void MKJFMCDHGBD(PlayerAvatarDisplayBase BNGPJNAGBED, List<EMBBHFJLBPC> PMJLMPGHMHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x7BFA7C0", Offset = "0x7BF95C0", VA = "0x187BFA7C0")]
		public AAFDGGPNGMA Rebuild(bool EOAAOFPLKMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x7BF2190", Offset = "0x7BF0F90", VA = "0x187BF2190")]
		protected AAFDGGPNGMA AOMBOEIEDLF(bool EOAAOFPLKMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x7BF2060", Offset = "0x7BF0E60", VA = "0x187BF2060", Slot = "12")]
		protected virtual AAFDGGPNGMA AOMBOEIEDLF(IList<KIBCEDHJJBM> BCDBMMHDPNE, AvatarItemBodyType EJCCGGFDKNA, bool KFHDBEBFAPC, bool EEDCHPHBEOA, int[] LKGOHMIGOBC, bool EOAAOFPLKMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x7BF7F20", Offset = "0x7BF6D20", VA = "0x187BF7F20")]
		protected static AAFDGGPNGMA JDLPEMLGBGF(EMBBHFJLBPC FGEJHEAAOLD, List<EMBBHFJLBPC> PMJLMPGHMHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x7BF4BA0", Offset = "0x7BF39A0", VA = "0x187BF4BA0")]
		[IteratorStateMachine(typeof(DPIKMCAAKFL))]
		protected static IEnumerator<GCOFLMDGPIM> EIEOOEGNJOA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x7BF4460", Offset = "0x7BF3260", VA = "0x187BF4460")]
		protected static EMBBHFJLBPC DBBHEFHCGNC(List<EMBBHFJLBPC> PMJLMPGHMHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x7BFB520", Offset = "0x7BFA320", VA = "0x187BFB520")]
		[AsyncStateMachine(typeof(EGJOIKBGILL))]
		public Task SetFaceCustomizationSettings(PALPOLFGBAG IHBJMAABOGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7BFD700", Offset = "0x7BFC500", VA = "0x187BFD700")]
		public bool UpdateFaceAndBodyCustomizationSettings(PALPOLFGBAG IHBJMAABOGM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x7BF7E40", Offset = "0x7BF6C40", VA = "0x187BF7E40")]
		public void InitializeFaceFeatures(AvatarConfiguration EBICCBNIJAP, JBJPAOBCEOK EKOJNMDAFEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x7BFCCD0", Offset = "0x7BFBAD0", VA = "0x187BFCCD0")]
		public void SetTeamColors(Color? MGKIBGFLCOM, bool KBOFGEHMGAM, Color LFFDHIALAOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x12F4680", Offset = "0x12F3480", VA = "0x1812F4680")]
		private static void FJHPMIFMOOF(Material EFCBJICGDPB, Color OAIIHELJHLG, params int[] AMJBDJHMFHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x12F5200", Offset = "0x12F4000", VA = "0x1812F5200")]
		private static void LDIHFIPAIOK(Material EFCBJICGDPB, Texture OAIIHELJHLG, params int[] AMJBDJHMFHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x7BF8D40", Offset = "0x7BF7B40", VA = "0x187BF8D40")]
		protected void MAKGDANAABJ(Material LECCGKLMLFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x7BF9770", Offset = "0x7BF8570", VA = "0x187BF9770")]
		protected void NCANMPMKMKM(Material LECCGKLMLFA, Color CACINJNLFNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x7BF3AC0", Offset = "0x7BF28C0", VA = "0x187BF3AC0")]
		protected void CPFOLLDJICG(Material LECCGKLMLFA, Color CACINJNLFNF, Color LPDOJHDKACB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x7BF8AB0", Offset = "0x7BF78B0", VA = "0x187BF8AB0")]
		protected void LLHMPLCAKOM(Material LECCGKLMLFA, Texture2D FBFLLKLGAIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x7BF8530", Offset = "0x7BF7330", VA = "0x187BF8530")]
		protected void JLGGDCODMLB(Material LECCGKLMLFA, Texture IMGFIJHMCNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x7BF7940", Offset = "0x7BF6740", VA = "0x187BF7940")]
		protected void IJBCAADKCLA(Action<MMNJOAJNCBN> KEBLMLEFOKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x7BF6E20", Offset = "0x7BF5C20", VA = "0x187BF6E20")]
		protected void HHDMMIKCJIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x7BF8640", Offset = "0x7BF7440", VA = "0x187BF8640")]
		protected void JPAKHEDDCKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x7BF9890", Offset = "0x7BF8690", VA = "0x187BF9890")]
		protected void NJAIEKKJCOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x7BF2810", Offset = "0x7BF1610", VA = "0x187BF2810")]
		public void ApplyUgcItemOverrides()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x7BFAE70", Offset = "0x7BF9C70", VA = "0x187BFAE70")]
		public void SetBeardPrimaryColor([Optional] Color? CLOFNBNMDML, bool JKIGOIINIJA = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x7BFB0A0", Offset = "0x7BF9EA0", VA = "0x187BFB0A0")]
		public void SetBeardSecondaryColor([Optional] Color? CLOFNBNMDML, bool JKIGOIINIJA = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x7BFAD30", Offset = "0x7BF9B30", VA = "0x187BFAD30")]
		public void SetBeardPattern([Optional] AvatarHairPattern PMMHIMPNHFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x7BF72E0", Offset = "0x7BF60E0", VA = "0x187BF72E0")]
		private void IBHBDLNAEJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x7BF9D10", Offset = "0x7BF8B10", VA = "0x187BF9D10")]
		private bool OFFBBPFEBMO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x7BFB890", Offset = "0x7BFA690", VA = "0x187BFB890")]
		public void SetHairPrimaryColor([Optional] Color? DOGGPNBLHNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x7BFBAB0", Offset = "0x7BFA8B0", VA = "0x187BFBAB0")]
		public void SetHairSecondaryColor([Optional] Color? DOGGPNBLHNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x7BFB760", Offset = "0x7BFA560", VA = "0x187BFB760")]
		public void SetHairPattern([Optional] AvatarHairPattern PMMHIMPNHFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x7BFA950", Offset = "0x7BF9750", VA = "0x187BFA950")]
		public void RefreshHair()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x7BF66F0", Offset = "0x7BF54F0", VA = "0x187BF66F0")]
		private bool GIKNHOEFNCB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x7BFCB10", Offset = "0x7BFB910", VA = "0x187BFCB10")]
		public void SetSkinColor(Color JHMKGMDNNGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x7BFCFD0", Offset = "0x7BFBDD0", VA = "0x187BFCFD0")]
		public void SetUgcItemVisualOverrides(KIBCEDHJJBM GJCCIIMFCKD, JBJPAOBCEOK EKOJNMDAFEL, Texture BPLCNFOAHFA, Color PJDGBIKFOLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x7BF43C0", Offset = "0x7BF31C0", VA = "0x187BF43C0")]
		public void ClearUgcItemVisualOverrides()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x7BFB620", Offset = "0x7BFA420", VA = "0x187BFB620")]
		public bool SetFaceShape(AvatarFaceShape FLAFHLNGMIP, bool PFEIPOCMGFP = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x7BF6D80", Offset = "0x7BF5B80", VA = "0x187BF6D80")]
		private void HGGPJFOHBMN(LOCPCPHLCCB LJIBJAKOMJA, float OAIIHELJHLG, bool BDNKGNDKMKM = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x7BF69F0", Offset = "0x7BF57F0", VA = "0x187BF69F0")]
		private void GOKCJFCNOHM(PHAGJOKLIJN NMFPDLNMGFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x7BF7060", Offset = "0x7BF5E60", VA = "0x187BF7060")]
		private void HMEMCFAKKJM(KIEGMEAMIFO BHLNGJFAOFK, float OAIIHELJHLG, bool MGIPNNAINDG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x7BF7850", Offset = "0x7BF6650", VA = "0x187BF7850")]
		private void IIANKLAKBFA(INHKJJEFEGH BIPIIAGGHDI, float OAIIHELJHLG, bool KLOOBJNPKDH = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x7BFA520", Offset = "0x7BF9320", VA = "0x187BFA520")]
		private void PEEOKPIBFNK(MCNLICCCEJC CBHMEFLPKKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x7BF8800", Offset = "0x7BF7600", VA = "0x187BF8800")]
		private void KCOPJJFLGCO(NPCJBJIOGJI BNHBPOLDICG, float AMPGAGADPEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x7BFB2D0", Offset = "0x7BFA0D0", VA = "0x187BFB2D0")]
		public bool SetBodyShape(AvatarBodyShape CDIEHNANIME, bool PFEIPOCMGFP = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x7BFC9A0", Offset = "0x7BFB7A0", VA = "0x187BFC9A0")]
		public bool SetNoseType(GEMMNCOLLPK IBNBMGEBGNE, bool PFEIPOCMGFP = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x7BFDDF0", Offset = "0x7BFCBF0", VA = "0x187BFDDF0")]
		public bool UpdateFaceAndBodyShapes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x7BFC980", Offset = "0x7BFB780", VA = "0x187BFC980")]
		public bool SetHideEars(bool PJFIEMHLHKO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x7BFC970", Offset = "0x7BFB770", VA = "0x187BFC970")]
		public bool SetHelmetHair(COINFHPMIAA CKNPFDJPLAM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x7BFBD70", Offset = "0x7BFAB70", VA = "0x187BFBD70")]
		public void SetHatAnchorParameters(CAOCJKDHCLC NDBMDEMCOFF, bool MBOCHKOKOGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x7BFD670", Offset = "0x7BFC470", VA = "0x187BFD670")]
		public void SetupDisplayLODs(GPEBBMHBKBD APOELKEMJFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x7BF4ED0", Offset = "0x7BF3CD0", VA = "0x187BF4ED0")]
		protected int[] FBGPEIDCPHI(GPEBBMHBKBD APOELKEMJFB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x7BFCA40", Offset = "0x7BFB840", VA = "0x187BFCA40")]
		public void SetOutfitSelections(IList<KIBCEDHJJBM> BCDBMMHDPNE, AvatarItemBodyType EJCCGGFDKNA, bool EEDCHPHBEOA, bool EOAAOFPLKMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x7BFCA80", Offset = "0x7BFB880", VA = "0x187BFCA80")]
		public void SetOutfitSelections(IList<KIBCEDHJJBM> BCDBMMHDPNE, AvatarItemBodyType EJCCGGFDKNA, bool KFHDBEBFAPC, bool EEDCHPHBEOA, bool EOAAOFPLKMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x7BFCAD0", Offset = "0x7BFB8D0", VA = "0x187BFCAD0")]
		public AAFDGGPNGMA SetOutfitSelections(IList<KIBCEDHJJBM> BCDBMMHDPNE, AvatarItemBodyType EJCCGGFDKNA, GPEBBMHBKBD APOELKEMJFB, bool KFHDBEBFAPC, bool EEDCHPHBEOA, bool PFEIPOCMGFP = false, bool EOAAOFPLKMJ = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x7BF92A0", Offset = "0x7BF80A0", VA = "0x187BF92A0", Slot = "13")]
		protected virtual AAFDGGPNGMA MPACCPGJEEB(IList<KIBCEDHJJBM> BCDBMMHDPNE, AvatarItemBodyType EJCCGGFDKNA, bool KFHDBEBFAPC, bool EEDCHPHBEOA, GPEBBMHBKBD APOELKEMJFB, bool PFEIPOCMGFP, bool EOAAOFPLKMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x7BF6260", Offset = "0x7BF5060", VA = "0x187BF6260")]
		protected int[] FIKNJKMKCKD(GPEBBMHBKBD APOELKEMJFB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA097D0", VA = "0x180A0A9D0", Slot = "14")]
		protected virtual OJJOHCMLHDB FCFIMMHOBEK(AvatarItemBodyType NKMICFCAGBL, Dictionary<string, KDOBCGFCCMB> EEDFFCDJGJL, Dictionary<string, EHIFMMNJMNN<Texture2D>> FGPOJEOABLD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x7BF21F0", Offset = "0x7BF0FF0", VA = "0x187BF21F0", Slot = "15")]
		protected virtual AAFDGGPNGMA APMGMCBOJEG(IList<KIBCEDHJJBM> BCDBMMHDPNE, AvatarItemBodyType EJCCGGFDKNA, bool KFHDBEBFAPC, bool EEDCHPHBEOA, int[] DEKFHJHJAFD, BHPMKNNFDOB ODKNMFEAPHJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x7BF2F10", Offset = "0x7BF1D10", VA = "0x187BF2F10", Slot = "16")]
		protected virtual KDOBCGFCCMB BEJDKMOJDPD(FLJBCFIDHCI CACIHEEMLOB, AvatarItemBodyType NKMICFCAGBL, HHFLIOCEMDF PEADOPOCNJH, KDOBCGFCCMB ONBFCKEKFFD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA097D0", VA = "0x180A0A9D0", Slot = "17")]
		protected virtual KDOBCGFCCMB NPKCOMEMNGN(AvatarItemBodyType NKMICFCAGBL, HHFLIOCEMDF PEADOPOCNJH, IHBLLANFAIP NMFFKEACGFO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x7BF9120", Offset = "0x7BF7F20", VA = "0x187BF9120")]
		protected void MFACONPEIOD(LMPPDFIGPDH FLHGBBEAHBN, JICHGCEFAAI.NNADHONNNIJ INDMBEKKFKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x7BF3390", Offset = "0x7BF2190", VA = "0x187BF3390")]
		protected void BEKKPHHNFCI(LMPPDFIGPDH FLHGBBEAHBN, JICHGCEFAAI.NNADHONNNIJ INDMBEKKFKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0xABF9B0", Offset = "0xABE7B0", VA = "0x180ABF9B0", Slot = "18")]
		protected virtual LMPPDFIGPDH PJHMEMEJEDH(LMPPDFIGPDH FLHGBBEAHBN, HelmetHairStyle JMOFCNHNPGD, bool AGLPGCKDNCA, AvatarItemBodyType EJCCGGFDKNA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x7BF5090", Offset = "0x7BF3E90", VA = "0x187BF5090")]
		protected LMPPDFIGPDH FBOPLDGEGMI(IList<KIBCEDHJJBM> BCDBMMHDPNE, AvatarItemBodyType OAPOAGJDCAH, bool EEDCHPHBEOA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x7BF41D0", Offset = "0x7BF2FD0", VA = "0x187BF41D0")]
		public void CleanupDisplayResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x7BF7100", Offset = "0x7BF5F00", VA = "0x187BF7100")]
		protected void HOAOIAEMMLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x7BF9EF0", Offset = "0x7BF8CF0", VA = "0x187BF9EF0")]
		protected void OOMNEPHCOJN(Transform PCGEPBBOIHC, IEnumerable<SkinnedMeshRenderer> FEDBPLPKOON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x7BFA700", Offset = "0x7BF9500", VA = "0x187BFA700")]
		protected JICHGCEFAAI.NNADHONNNIJ PNLPDJOMOID(JICHGCEFAAI.NNADHONNNIJ JONLFIIJGCH, HHFLIOCEMDF BBEKBGOIPEP)
		{
			return default(JICHGCEFAAI.NNADHONNNIJ);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x7BF8950", Offset = "0x7BF7750", VA = "0x187BF8950")]
		protected void KNOJBNAPOMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x1262340", Offset = "0x1261140", VA = "0x181262340")]
		protected void HNOGKKJEIEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x7BF65E0", Offset = "0x7BF53E0", VA = "0x187BF65E0")]
		protected void GEBCCLCHJHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x7BFA630", Offset = "0x7BF9430", VA = "0x187BFA630")]
		[AsyncStateMachine(typeof(LBLMGHLFKAG))]
		protected Task PJMDGJMNIBM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x7BF60C0", Offset = "0x7BF4EC0", VA = "0x187BF60C0")]
		protected static JFCEHBPBALA FIIKBEDAMLJ(MADBPELMOLA FGBEJFBKAMO, int NIFJNECFBGA)
		{
			return default(JFCEHBPBALA);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x7BF4650", Offset = "0x7BF3450", VA = "0x187BF4650")]
		protected static GFIPPGLOFIH DNFJHPFLJNG(MADBPELMOLA FGBEJFBKAMO, int NIFJNECFBGA)
		{
			return default(GFIPPGLOFIH);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x7BF7AA0", Offset = "0x7BF68A0", VA = "0x187BF7AA0")]
		protected Transform IJPPGAPLPLA(HHFLIOCEMDF PEADOPOCNJH, OutfitType OPCLBLFNLDK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x7BF63E0", Offset = "0x7BF51E0", VA = "0x187BF63E0")]
		protected void GBHNPEALKLD(int ENGFDNNLAAM, Material EFCBJICGDPB, MADBPELMOLA FGBEJFBKAMO, [Out] Texture2D CAOPADOGCGA, [Out] Vector4 GDJGPPJGHHG, [Out] Texture2D EGDPIDJGAPJ, [Out] Texture2D LKJMNCKHFAJ, [Out] Texture2D DKINJNMIPIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x7BF3850", Offset = "0x7BF2650", VA = "0x187BF3850")]
		protected void CHDBMHOIODC(int ENGFDNNLAAM, Material EFCBJICGDPB, MADBPELMOLA FGBEJFBKAMO, [Out] Color DDFLDEGIBML, [Out] Color FEBJLJHIIBH, [Out] Color FPGBBHHHOKO, [Out] Color FBHPCKGHLOF, [Out] Color OCGPBMABIPG, [Out] Color MKAGPEHHNPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x7BF8CD0", Offset = "0x7BF7AD0", VA = "0x187BF8CD0")]
		protected void LLJDJEGPOBP(Vector3 HKMBNCFKKMC, Quaternion PHNPMAOBIEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x7BFC320", Offset = "0x7BFB120", VA = "0x187BFC320")]
		public void SetHatAnchorParameters(CAOCJKDHCLC NDBMDEMCOFF, AnchorParamsRestrictions JGABKMJGNMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x7BF3CF0", Offset = "0x7BF2AF0", VA = "0x187BF3CF0")]
		public static void CalculateHatAnchorParams(FitMeshHemisphere NIKNKPKMNGA, Transform HPIEAGEGIBA, CAOCJKDHCLC NDBMDEMCOFF, AnchorParamsRestrictions GDIHDCPBMDI, [Out] Vector3 IMPLDPKOJAO, [Out] Quaternion MEPKHADFMCL, [Out] CAOCJKDHCLC JDMLDLAHMFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x7BFABC0", Offset = "0x7BF99C0", VA = "0x187BFABC0")]
		public void ResetHatAnchor(Vector2 IKEOEPJHIBK, Vector3 JPFLMPFFBNN, Vector3 PIDIGFLDKFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0xABF4F0", Offset = "0xABE2F0", VA = "0x180ABF4F0")]
		public EJLEKMEMFEJ GetAnchorParamsRestrictions()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x7BF2640", Offset = "0x7BF1440", VA = "0x187BF2640")]
		public void ApplyBlocks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x7BF2780", Offset = "0x7BF1580", VA = "0x187BF2780")]
		public void ApplyHairPattern()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x7BF25B0", Offset = "0x7BF13B0", VA = "0x187BF25B0")]
		public void ApplyBeardPattern()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x7BFD6A0", Offset = "0x7BFC4A0", VA = "0x187BFD6A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x7BF7450", Offset = "0x7BF6250", VA = "0x187BF7450")]
		protected void ICNOPDEGIKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x7BFD460", Offset = "0x7BFC260", VA = "0x187BFD460")]
		public void SetWaitForUgcTextureLoads(bool DGMDLOGDLNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x7BFD370", Offset = "0x7BFC170", VA = "0x187BFD370")]
		public void SetUgcTextureParameters(MNCBCAJDKJB CNCKIIIBBGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x7BFE550", Offset = "0x7BFD350", VA = "0x187BFE550")]
		public PlayerAvatarDisplayBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x7BF7DB0", Offset = "0x7BF6BB0", VA = "0x187BF7DB0")]
		[CompilerGenerated]
		private void INCIBELHDNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x7BF6360", Offset = "0x7BF5160", VA = "0x187BF6360")]
		[CompilerGenerated]
		private void FOKKIPAMFCJ(MMNJOAJNCBN AFHICFOAOIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x7BF45C0", Offset = "0x7BF33C0", VA = "0x187BF45C0")]
		[CompilerGenerated]
		private void DNELKCNKOFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x7BF1FC0", Offset = "0x7BF0DC0", VA = "0x187BF1FC0")]
		[CompilerGenerated]
		private void AJCEDPIDBLC(MMNJOAJNCBN AFHICFOAOIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x7BF8A20", Offset = "0x7BF7820", VA = "0x187BF8A20")]
		[CompilerGenerated]
		private void LIJBDNFLLFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x7BF71B0", Offset = "0x7BF5FB0", VA = "0x187BF71B0")]
		[CompilerGenerated]
		private void HOBIKIPNMLC(MMNJOAJNCBN AFHICFOAOIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x7BF3570", Offset = "0x7BF2370", VA = "0x187BF3570")]
		[CompilerGenerated]
		private void BHJDEJCBAKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x7BF9520", Offset = "0x7BF8320", VA = "0x187BF9520")]
		[CompilerGenerated]
		private void MPEJNNECJOO(MMNJOAJNCBN AFHICFOAOIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x7BF6CF0", Offset = "0x7BF5AF0", VA = "0x187BF6CF0")]
		[CompilerGenerated]
		private void HFBGDGCMHGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x7BF4410", Offset = "0x7BF3210", VA = "0x187BF4410")]
		[CompilerGenerated]
		private void DADKFKJIJJG(MMNJOAJNCBN AFHICFOAOIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x7BF7250", Offset = "0x7BF6050", VA = "0x187BF7250")]
		[CompilerGenerated]
		private void IBDCNHJKGLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x7BF8960", Offset = "0x7BF7760", VA = "0x187BF8960")]
		[CompilerGenerated]
		private void LDHOICAJFKG(MMNJOAJNCBN AFHICFOAOIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x7BF6910", Offset = "0x7BF5710", VA = "0x187BF6910")]
		[CompilerGenerated]
		internal static bool GKJPJFAMBJA(Transform KKCKCLFJGAD, IEnumerable<SkinnedMeshRenderer> IBJDKJAKPHJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x7BF47A0", Offset = "0x7BF35A0", VA = "0x187BF47A0")]
		[CompilerGenerated]
		private void DOLHHDFHHLO(MMNJOAJNCBN AFHICFOAOIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x7BF3600", Offset = "0x7BF2400", VA = "0x187BF3600")]
		[CompilerGenerated]
		private void BKJGNOMLKOL(MMNJOAJNCBN AFHICFOAOIL)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[ExecuteAlways]
	public class PlayerFacialAnimatorBase : MonoBehaviour, GCNHNEMJEGC
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		[CompilerGenerated]
		private struct AKBGJCKNDAN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000462")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000463")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000464")]
			public PALPOLFGBAG avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000465")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000466")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A1")]
			[Cpp2IlInjected.Address(RVA = "0x7C00CC0", Offset = "0x7BFFAC0", VA = "0x187C00CC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0x7C00F50", Offset = "0x7BFFD50", VA = "0x187C00F50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		[CompilerGenerated]
		private struct ONBGDOMHAOB : IAsyncStateMachine
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
			public JBJPAOBCEOK avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400046F")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0x7C08B40", Offset = "0x7C07940", VA = "0x187C08B40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x7C08D20", Offset = "0x7C07B20", VA = "0x187C08D20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		[CompilerGenerated]
		private struct GLBLJDNBAMO : IAsyncStateMachine
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
			public JBJPAOBCEOK avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000476")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x7C04760", Offset = "0x7C03560", VA = "0x187C04760", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x7C04900", Offset = "0x7C03700", VA = "0x187C04900", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private struct AJFFOMHPLIJ : IAsyncStateMachine
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
			public PALPOLFGBAG avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400047B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x7C00AB0", Offset = "0x7BFF8B0", VA = "0x187C00AB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x7C00C60", Offset = "0x7BFFA60", VA = "0x187C00C60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private struct OIAEIOBNAAD : IAsyncStateMachine
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
			public JBJPAOBCEOK avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000480")]
			private TaskAwaiter<MHCGNHKHJKM> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x7C085F0", Offset = "0x7C073F0", VA = "0x187C085F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x7C08A30", Offset = "0x7C07830", VA = "0x187C08A30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		[CompilerGenerated]
		private struct COPHBKGBHMI : IAsyncStateMachine
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
			public JBJPAOBCEOK avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000486")]
			private FaceStyleSet <styleSet>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000487")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x7C00FB0", Offset = "0x7BFFDB0", VA = "0x187C00FB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x7C013D0", Offset = "0x7C001D0", VA = "0x187C013D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		protected const float CBAMGJFCMKF = 0.5f;

		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		protected const int OKAIKEOGJFJ = 5;

		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		private static readonly int NBJNMFJNCEJ;

		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		private static readonly int CIAEKFKLLAA;

		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		private static readonly int MEOFKBGBFPH;

		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public static readonly int IdleID;

		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public static readonly int SmileID;

		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public static readonly int HugeSmileID;

		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public static readonly int ScoreID;

		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public static readonly int SadID;

		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public static readonly int DisgustID;

		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public static readonly int HitID;

		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public static readonly int ConcentrateID;

		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public static readonly int KissID;

		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public static readonly int TalkingID;

		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public static readonly int MuteID;

		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public static readonly int AFKID;

		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public static readonly int HappyID;

		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public static readonly int EmoteFlatID;

		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public static readonly int EmoteHappyID;

		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public static readonly int EmoteSadID;

		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public static readonly int EmoteLoveID;

		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public static readonly int EmoteAngryID;

		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public static readonly int EmoteLaughID;

		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public static readonly int EmoteTongueOutID;

		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public static readonly int EmoteGrimacingID;

		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public static readonly int EmoteWinkID;

		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public static readonly int EmoteShockedID;

		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public static readonly int EmoteNauseatedID;

		[Cpp2IlInjected.Token(Token = "0x4000405")]
		public static readonly int EmoteSmileSweatID;

		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public static readonly int EmoteSleepingID;

		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public static readonly int EmoteThinkingID;

		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public static readonly int EmoteSmirkID;

		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public static readonly int EmoteSmileID;

		[Cpp2IlInjected.Token(Token = "0x400040A")]
		protected static readonly Dictionary<ODPFCMHIEOK.AFGFABPMBPE, int> NJNFLALNIEK;

		[Cpp2IlInjected.Token(Token = "0x400040B")]
		[CanBeNull]
		protected static IEnumerable<FaceFeatureType> OIKLGIFGONB;

		[Cpp2IlInjected.Token(Token = "0x400040C")]
		protected static readonly int KGEBOGJCKAE;

		[Cpp2IlInjected.Token(Token = "0x400040D")]
		protected static readonly int ABNDOOFPMAN;

		[Cpp2IlInjected.Token(Token = "0x400040E")]
		protected static readonly int HCKDOEIKMLA;

		[Cpp2IlInjected.Token(Token = "0x400040F")]
		protected static readonly int NLIHBFONGBL;

		[Cpp2IlInjected.Token(Token = "0x4000410")]
		protected static readonly int CFBMKDBBKNM;

		[Cpp2IlInjected.Token(Token = "0x4000411")]
		protected static Vector2 PEIJICCIOPJ;

		[Cpp2IlInjected.Token(Token = "0x4000412")]
		protected static Vector2 OINNKGGPNJJ;

		[Cpp2IlInjected.Token(Token = "0x4000413")]
		protected static Vector2 DBGNMJPDDID;

		[Cpp2IlInjected.Token(Token = "0x4000414")]
		protected static Vector2 IPACHAMAJIF;

		[Cpp2IlInjected.Token(Token = "0x4000415")]
		protected static Vector2 POFPOOMLGEL;

		[Cpp2IlInjected.Token(Token = "0x4000416")]
		protected static Vector2 FNCGJKGLADC;

		[Cpp2IlInjected.Token(Token = "0x4000417")]
		protected static Vector2 HDIHGKNMCHP;

		[Cpp2IlInjected.Token(Token = "0x4000418")]
		protected static Vector2 KDENFPBDNLB;

		[Cpp2IlInjected.Token(Token = "0x4000419")]
		protected static Vector2 LMOFIPNBJEB;

		[Cpp2IlInjected.Token(Token = "0x400041A")]
		protected static Vector2 MNOCPLNMOHB;

		[Cpp2IlInjected.Token(Token = "0x400041B")]
		protected static Vector2 NGDDIIHKNFK;

		[Cpp2IlInjected.Token(Token = "0x400041C")]
		protected static Vector2 JLGFBJCKEEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		[DBPOJNFABNN(CBEHFHOOABN.Self, false, false, false)]
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
		private JBJPAOBCEOK CNFPOEAGGJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		private FaceStyleSet EPBPIBCLPGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		[SerializeField]
		protected bool debugEyeJitterInEditor;

		[Cpp2IlInjected.Token(Token = "0x4000426")]
		protected const int HALGBEKCIHL = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		protected int OELCKJOBOLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		protected int MOEENKPBMFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		protected int NDHLBIONFPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		protected int MBDPPCCJKNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		protected Vector2 JOHGJMOPJNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		protected float NHKCDKDEBAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		protected float JMIEDBHFOGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		protected float BOKCPNEKJJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		protected Vector2 MIDIMBNDFMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		protected float ENCNLMNIHLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		protected float AHBLOKFKMGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		protected float MKHHBKGPDMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		protected Vector2 KLOKFELMOCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		protected float KEPFPNGJNPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		protected float BPJKDJNGMBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		protected float HBBICBILABA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		protected Vector2 AOIFGMMNBGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		protected float EALGHFJPKHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		protected float FLDIMCKAMCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		protected float DNLAAHNMPCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		protected List<SelectableFaceOption> IEMJIPOECKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		protected List<SelectableFaceOption> KCCJGPFNPBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		protected List<SelectableFaceOption> DFDPGMBBLAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		protected List<SelectableFaceOption> OCDDINONABM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		protected Coroutine PBIDKAOGMGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		protected int? IOMIHJNIKPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		protected int EHMAIFLEHEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		protected int GNMFFMEGKJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		protected int CCMKPBPKPFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		protected int IPHPDMEPIFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		protected int HFCNDDADAHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		protected int BGIMAHJAPPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		protected Sprite OHLBELPNNEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		protected Sprite PDJPDOPMJHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		protected Sprite AMLHLKCAGHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		protected Sprite KLHJNIMFCAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		protected bool OLFLPKGPICH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		protected string IBDJKKLDCOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		protected string HIKMLNHMNMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		protected string CMLMMHFKOBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		protected string HDIKABEEOAG;

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
		protected AvatarConfiguration EBICCBNIJAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		protected MHCGNHKHJKM FIILNPBBKFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		private readonly List<Material> BCGFJHDJLIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		protected BNDNIILDNMC ECLONOEPOGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		protected Dictionary<string, int> HMMFKNGKFJF;

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public FaceStyleSet BPDKJBNJEMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x7C0F5F0", Offset = "0x7C0E3F0", VA = "0x187C0F5F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public bool BHAGMIIGHDH
		{
			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0xAEC9E0", Offset = "0xAEB7E0", VA = "0x180AEC9E0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x1279760", Offset = "0x1278560", VA = "0x181279760")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		protected virtual bool OHMEKELLCMI
		{
			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		protected virtual bool OLJJKAJICEL
		{
			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0xA24630", Offset = "0xA23430", VA = "0x180A24630", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		protected int KAEOGDPMHAI
		{
			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x7C09050", Offset = "0x7C07E50", VA = "0x187C09050")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public Renderer HJHCDDAIDMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0xA0EAC0", Offset = "0xA0D8C0", VA = "0x180A0EAC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public bool FGIHPAIPOCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0xAED210", Offset = "0xAEC010", VA = "0x180AED210")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x1E10750", Offset = "0x1E0F550", VA = "0x181E10750")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public Renderer[] EBEFPPNOEBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0xA0EAF0", Offset = "0xA0D8F0", VA = "0x180A0EAF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public bool NMPPPKKEDHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x7C0F640", Offset = "0x7C0E440", VA = "0x187C0F640")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x7C0F800", Offset = "0x7C0E600", VA = "0x187C0F800")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		protected int NELMKEJGLHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x7C09E50", Offset = "0x7C08C50", VA = "0x187C09E50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		protected int KHKDBMACCGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x7C0BA80", Offset = "0x7C0A880", VA = "0x187C0BA80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public float NPPDJIDMJIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x7C0F620", Offset = "0x7C0E420", VA = "0x187C0F620")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x7C0F7E0", Offset = "0x7C0E5E0", VA = "0x187C0F7E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public OCOBFHIIAOB HCLOIMANNPK
		{
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0xACD7B0", Offset = "0xACC5B0", VA = "0x180ACD7B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0xB10650", Offset = "0xB0F450", VA = "0x180B10650")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public MHCGNHKHJKM LBPPHPIPBNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000387")]
			[Cpp2IlInjected.Address(RVA = "0xAE1B70", Offset = "0xAE0970", VA = "0x180AE1B70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000388")]
			[Cpp2IlInjected.Address(RVA = "0x7C0F760", Offset = "0x7C0E560", VA = "0x187C0F760")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public NoseFaceOption DJECEAJJOMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000389")]
			[Cpp2IlInjected.Address(RVA = "0xAC7920", Offset = "0xAC6720", VA = "0x180AC7920")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600038A")]
			[Cpp2IlInjected.Address(RVA = "0xB5F7A0", Offset = "0xB5E5A0", VA = "0x180B5F7A0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		protected BNDNIILDNMC HMMIMEBCAIE
		{
			[Cpp2IlInjected.Token(Token = "0x600038B")]
			[Cpp2IlInjected.Address(RVA = "0x7C09EB0", Offset = "0x7C08CB0", VA = "0x187C09EB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action EMJIEFCABHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x7C0F540", Offset = "0x7C0E340", VA = "0x187C0F540")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x7C0F6B0", Offset = "0x7C0E4B0", VA = "0x187C0F6B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x7C0B980", Offset = "0x7C0A780", VA = "0x187C0B980")]
		public void LocalPlayEmote(ODPFCMHIEOK.AFGFABPMBPE DHKHDCBMOPC, float MHACCBBKFJF = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x7C0B5A0", Offset = "0x7C0A3A0", VA = "0x187C0B5A0")]
		public bool IsEmotePlaying(ODPFCMHIEOK.AFGFABPMBPE DHKHDCBMOPC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x7C0D430", Offset = "0x7C0C230", VA = "0x187C0D430")]
		public void SetIdleHappy(bool EPPINJLLBGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x7C0BAE0", Offset = "0x7C0A8E0", VA = "0x187C0BAE0")]
		protected void MNIBEIPDCCI(bool ELEELOPKHJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x7C0C9A0", Offset = "0x7C0B7A0", VA = "0x187C0C9A0")]
		protected void PKONJFMEGKA(bool MBHFCILGAJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x7C0B6C0", Offset = "0x7C0A4C0", VA = "0x187C0B6C0")]
		protected void JMPJPLMIONL(HHFLIOCEMDF PEADOPOCNJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A670", Offset = "0x7C09470", VA = "0x187C0A670")]
		protected void FLGLMPEDNMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x7C0CB00", Offset = "0x7C0B900", VA = "0x187C0CB00")]
		public void PlayExpression(int EFECEDLPMLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x7C0AFB0", Offset = "0x7C09DB0", VA = "0x187C0AFB0")]
		protected void IIEKCIHANOA(bool CMFMLKKOKHG, bool KNCNHFOHOIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x7C0ABE0", Offset = "0x7C099E0", VA = "0x187C0ABE0")]
		public List<SelectableFaceOption> GetAvailableFeatures(FaceFeatureType GMJFLIIKGFC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x7C0B070", Offset = "0x7C09E70", VA = "0x187C0B070")]
		public void InitializeFaceFeatureRanges(AvatarConfiguration EBICCBNIJAP, JBJPAOBCEOK EKOJNMDAFEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x7C0D200", Offset = "0x7C0C000", VA = "0x187C0D200")]
		[AsyncStateMachine(typeof(AKBGJCKNDAN))]
		public Task SetFaceSettings(PALPOLFGBAG IHBJMAABOGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x7C0D0D0", Offset = "0x7C0BED0", VA = "0x187C0D0D0")]
		[AsyncStateMachine(typeof(ONBGDOMHAOB))]
		public Task SetFaceSettings(int JLGJMFJIIPP, int ICEIMDOFGAK, int JECABFPMJKE, int MEMAEOIOIMD, JBJPAOBCEOK EKOJNMDAFEL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x7C0D4B0", Offset = "0x7C0C2B0", VA = "0x187C0D4B0")]
		[AsyncStateMachine(typeof(GLBLJDNBAMO))]
		public Task SetSelectedFaceFeatureAndBuildFaceStyle(FaceFeatureType GMJFLIIKGFC, int OFEDNKJKDNF, JBJPAOBCEOK EKOJNMDAFEL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A880", Offset = "0x7C09680", VA = "0x187C0A880")]
		protected void GOPNNAELDGP(FaceFeatureType GMJFLIIKGFC, ACMJCOIHLAN LFPNENPJJKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x7C09F30", Offset = "0x7C08D30", VA = "0x187C09F30")]
		protected void FKABINHJNHP(FaceFeatureType GMJFLIIKGFC, int OFEDNKJKDNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x7C0AA00", Offset = "0x7C09800", VA = "0x187C0AA00")]
		public static IEnumerable<FaceFeatureType> GetAllFaceFeatureTypes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x7C09410", Offset = "0x7C08210", VA = "0x187C09410")]
		[AsyncStateMachine(typeof(AJFFOMHPLIJ))]
		protected Task AOKPEMDMCIF(PALPOLFGBAG IHBJMAABOGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x7C0C6A0", Offset = "0x7C0B4A0", VA = "0x187C0C6A0")]
		protected void PFGBOGPNPPL(PALPOLFGBAG IHBJMAABOGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A6E0", Offset = "0x7C094E0", VA = "0x187C0A6E0")]
		protected static void GCMIEHMPKCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x7C09180", Offset = "0x7C07F80", VA = "0x187C09180")]
		private void AKBDMMHLCAG(bool JICONGKONGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x7C0AC20", Offset = "0x7C09A20", VA = "0x187C0AC20")]
		protected void HFDOGHDKEEL(FaceFeatureType GMJFLIIKGFC, Vector2 DECBDDCBGEP, JBJPAOBCEOK EKOJNMDAFEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x7C0CB20", Offset = "0x7C0B920", VA = "0x187C0CB20")]
		public void SetFaceFeatureNormalizedPositionOffset(FaceFeatureType GMJFLIIKGFC, Vector2 OPEFCAHCLNP, JBJPAOBCEOK EKOJNMDAFEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x7C0B800", Offset = "0x7C0A600", VA = "0x187C0B800")]
		protected void LKLLKNPKFIE(FaceFeatureType GMJFLIIKGFC, float IBEMLMFPHEH, JBJPAOBCEOK EKOJNMDAFEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x7C0BB60", Offset = "0x7C0A960", VA = "0x187C0BB60")]
		protected void NEJAJFLKAHN(FaceFeatureType GMJFLIIKGFC, float LJIHJJKHDDH, JBJPAOBCEOK EKOJNMDAFEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x7C0B730", Offset = "0x7C0A530", VA = "0x187C0B730")]
		protected void KFNAFFDGNAI(FaceFeatureType GMJFLIIKGFC, float ENNLGHBJALI, JBJPAOBCEOK EKOJNMDAFEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x7C0CEB0", Offset = "0x7C0BCB0", VA = "0x187C0CEB0")]
		public void SetFaceFeatureNormalizedScaleOffset(FaceFeatureType GMJFLIIKGFC, float FCBEKACKDOJ, JBJPAOBCEOK EKOJNMDAFEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x7C09D70", Offset = "0x7C08B70", VA = "0x187C09D70")]
		[AsyncStateMachine(typeof(OIAEIOBNAAD))]
		protected Task DKGADGKOMAJ(JBJPAOBCEOK EKOJNMDAFEL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x7C0B390", Offset = "0x7C0A190", VA = "0x187C0B390")]
		public void InitializeFaceFeatureStyleSet(JBJPAOBCEOK EKOJNMDAFEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x7C09BA0", Offset = "0x7C089A0", VA = "0x187C09BA0")]
		protected bool CNFJMNIPNBN(string KHFNGEDHGCN, [Out] int GLAOLHCPLLG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x7C09500", Offset = "0x7C08300", VA = "0x187C09500")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x168F690", Offset = "0x168E490", VA = "0x18168F690", Slot = "8")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x7C0C490", Offset = "0x7C0B290", VA = "0x187C0C490")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x7C0E5F0", Offset = "0x7C0D3F0", VA = "0x187C0E5F0")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x7C097F0", Offset = "0x7C085F0", VA = "0x187C097F0")]
		[AsyncStateMachine(typeof(COPHBKGBHMI))]
		public Task BuildFaceStyleAsyncIfChanged(JBJPAOBCEOK EKOJNMDAFEL, bool PFEIPOCMGFP = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x7C0DF00", Offset = "0x7C0CD00", VA = "0x187C0DF00")]
		public void UpdateFaceDisplays(bool NEFIIABADLP = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x7C0BCE0", Offset = "0x7C0AAE0", VA = "0x187C0BCE0")]
		protected bool OFNDCMBNEMJ(bool NEFIIABADLP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x7C0DC20", Offset = "0x7C0CA20", VA = "0x187C0DC20")]
		public void UpdateFaceDisplayFeatureTextures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x7C0D2F0", Offset = "0x7C0C0F0", VA = "0x187C0D2F0")]
		public void SetFaceSpriteIndices(string DODBBKONNKO, string EEHHENJMLLH, string CGBKGNIHCFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x7C0D5C0", Offset = "0x7C0C3C0", VA = "0x187C0D5C0")]
		public void UpdateFaceDisplayFeaturePositions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x7C0E120", Offset = "0x7C0CF20", VA = "0x187C0E120")]
		public void UpdateFaceJitterMultiplier()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x7C0E310", Offset = "0x7C0D110", VA = "0x187C0E310")]
		public bool UpdateLegacyFaceVectors()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x7C09C80", Offset = "0x7C08A80", VA = "0x187C09C80")]
		protected void DFFKENDCHOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x7C098F0", Offset = "0x7C086F0", VA = "0x187C098F0")]
		private void CDCPIECIMHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x7C09640", Offset = "0x7C08440", VA = "0x187C09640")]
		private void BANEIBBGBGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x7C0F2E0", Offset = "0x7C0E0E0", VA = "0x187C0F2E0")]
		public PlayerFacialAnimatorBase()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0xA36800", Offset = "0xA35600", VA = "0x180A36800", Slot = "4")]
		private bool IICCIPPFFJD()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct ONCGLENIPMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public string KHKODDKNOBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public int OCNPBLDHFMO;
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
		private struct JFDOBMKGPLN : IAsyncStateMachine
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

			[Cpp2IlInjected.Token(Token = "0x60003E0")]
			[Cpp2IlInjected.Address(RVA = "0x7C04A40", Offset = "0x7C03840", VA = "0x187C04A40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E1")]
			[Cpp2IlInjected.Address(RVA = "0xA5B8B0", Offset = "0xA5A6B0", VA = "0x180A5B8B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000077")]
		[CompilerGenerated]
		private struct JFPGLKEDINO : IAsyncStateMachine
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

			[Cpp2IlInjected.Token(Token = "0x60003E2")]
			[Cpp2IlInjected.Address(RVA = "0x7C04C40", Offset = "0x7C03A40", VA = "0x187C04C40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E3")]
			[Cpp2IlInjected.Address(RVA = "0x7C05140", Offset = "0x7C03F40", VA = "0x187C05140", Slot = "5")]
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
		public JBJPAOBCEOK avatarBodyType;

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
		public COINFHPMIAA useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public CAOCJKDHCLC hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public EJLEKMEMFEJ HatAnchorRestrictions;

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
		[DBPOJNFABNN(CBEHFHOOABN.Self, false, false, false)]
		public PlayerAvatarDisplayBase _avatarDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		private MAKMIFPFIDG AADBELPHCOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		[SerializeField]
		[DBPOJNFABNN(CBEHFHOOABN.Self, false, false, false)]
		public PlayerFacialAnimatorBase facialAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public AnimationClip animationClipToOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		private AnimatorOverrideController FCHDEHFNJEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		private List<KeyValuePair<AnimationClip, AnimationClip>> HGKCPGELKJP;

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
		public readonly ONCGLENIPMB[] FacialExpressions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public readonly string[] BodyPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public readonly (string, INDOKOCMJGN)[] HandPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public bool hideLeftWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x229")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public bool hideRightWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22A")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		protected bool HBOGFMBJOAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22C")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		protected Guid NLFODLHKDNO;

		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		protected static Guid BCCLFBCFECM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		private IGHDDCGAHHH OIOGFAIFPCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		private OCOBFHIIAOB NLANKFKJKFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		private PPBDPCLLEJH JMKECEGOFOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		private PPBDPCLLEJH GGJAJHDHAOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		private AdditionalHatData BEPCGPGOEPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		private readonly Dictionary<GameObject, FLJBCFIDHCI> DEJJANBPGII;

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public static Func<IHBLLANFAIP> EPECKDDCBDO
		{
			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0x7C148D0", Offset = "0x7C136D0", VA = "0x187C148D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x7C14F10", Offset = "0x7C13D10", VA = "0x187C14F10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		public bool GIKNHOEFNCB
		{
			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x7C14A30", Offset = "0x7C13830", VA = "0x187C14A30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public bool OFFBBPFEBMO
		{
			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x7C14920", Offset = "0x7C13720", VA = "0x187C14920")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public PlayerAvatarDisplayBase CLNNHINKCAH
		{
			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0xACE460", Offset = "0xACD260", VA = "0x180ACE460")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		protected static Guid GKEOBJMDJDH
		{
			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0x7C110C0", Offset = "0x7C0FEC0", VA = "0x187C110C0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		public (GameObject, HHFLIOCEMDF)[] DKFAKIGPCAE
		{
			[Cpp2IlInjected.Token(Token = "0x60003CA")]
			[Cpp2IlInjected.Address(RVA = "0x7C14B40", Offset = "0x7C13940", VA = "0x187C14B40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x7C125F0", Offset = "0x7C113F0", VA = "0x187C125F0")]
		[ContextMenu("Refresh Avatar")]
		private void RebuildTestAvatarContextMenu()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x7C120F0", Offset = "0x7C10EF0", VA = "0x187C120F0")]
		private IEnumerable<GameObject> JDBIBAKOINH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x7C12AE0", Offset = "0x7C118E0", VA = "0x187C12AE0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x7C108E0", Offset = "0x7C0F6E0", VA = "0x187C108E0")]
		private void DFOGPDNNINB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x12BB490", Offset = "0x12BA290", VA = "0x1812BB490")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x7C119F0", Offset = "0x7C107F0", VA = "0x187C119F0")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x7C12AF0", Offset = "0x7C118F0", VA = "0x187C12AF0")]
		public void Teardown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x7C128E0", Offset = "0x7C116E0", VA = "0x187C128E0")]
		public void ShowPose(AnimationClip OHIOAPJFAOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x7C12AB0", Offset = "0x7C118B0", VA = "0x187C12AB0")]
		public void ShowPose(string OGGNGMCNMPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x7C12740", Offset = "0x7C11540", VA = "0x187C12740")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x7C12600", Offset = "0x7C11400", VA = "0x187C12600")]
		public void ResetHandPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x7C135C0", Offset = "0x7C123C0", VA = "0x187C135C0")]
		public void UpdateHandAnimation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x7C13410", Offset = "0x7C12210", VA = "0x187C13410")]
		public void UpdateFaceAndBodyShapes(bool PFEIPOCMGFP = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x7C139C0", Offset = "0x7C127C0", VA = "0x187C139C0")]
		public void UpdateNoseShape(GEMMNCOLLPK IBNBMGEBGNE, bool PFEIPOCMGFP = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x7C13990", Offset = "0x7C12790", VA = "0x187C13990")]
		public void UpdateLODOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x7C111B0", Offset = "0x7C0FFB0", VA = "0x187C111B0", Slot = "4")]
		protected virtual void HKFGEAMCCJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x7C0F950", Offset = "0x7C0E750", VA = "0x187C0F950", Slot = "5")]
		protected virtual void AOKHDELABOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x7C0FD80", Offset = "0x7C0EB80", VA = "0x187C0FD80")]
		public void ApplyHatData(AdditionalHatData NHOPNOIJCGF, bool AOMKMMAAMOP = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x7C0FBC0", Offset = "0x7C0E9C0", VA = "0x187C0FBC0")]
		public void ApplyHatAdjustmentsToHatAnchorParams()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x7C100E0", Offset = "0x7C0EEE0", VA = "0x187C100E0")]
		public void ApplyHatUVOverride(Vector2 IJCHEOFMJMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x7C10000", Offset = "0x7C0EE00", VA = "0x187C10000")]
		public void ApplyHatPositionAdjustment(Vector3 MFEMDBNEBDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x7C10070", Offset = "0x7C0EE70", VA = "0x187C10070")]
		public void ApplyHatRotationAdjustment(Vector3 DMPLALLGFBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x7C10200", Offset = "0x7C0F000", VA = "0x187C10200")]
		public KIBCEDHJJBM BuildAvatarItemSelection(GameObject BAABNJOANLA, JBJPAOBCEOK NKMICFCAGBL, HHFLIOCEMDF AMFPIDDBNBC)
		{
			return default(KIBCEDHJJBM);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x7C102A0", Offset = "0x7C0F0A0", VA = "0x187C102A0")]
		public void BuildAvatar(bool PFEIPOCMGFP = false, bool AOMKMMAAMOP = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x7C12E50", Offset = "0x7C11C50", VA = "0x187C12E50")]
		public void UpdateColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x7C0FD00", Offset = "0x7C0EB00", VA = "0x187C0FD00")]
		public void ApplyHatAnchor()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x7C137E0", Offset = "0x7C125E0", VA = "0x187C137E0")]
		public void UpdateHatAnchor(bool AOMKMMAAMOP = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x7C13510", Offset = "0x7C12310", VA = "0x187C13510")]
		[AsyncStateMachine(typeof(JFDOBMKGPLN))]
		public void UpdateFaceFeatures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x7C10FF0", Offset = "0x7C0FDF0", VA = "0x187C10FF0")]
		[AsyncStateMachine(typeof(JFPGLKEDINO))]
		private Task HHGDEPHLBGM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x7C10D20", Offset = "0x7C0FB20", VA = "0x187C10D20")]
		private void GIKKODKALGI(FaceFeatureType GNCGGJIBPBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x7C12560", Offset = "0x7C11360", VA = "0x187C12560")]
		private void PENMGICDPFO(FaceFeatureType GNCGGJIBPBJ, [Out] float FNPAEBHIDKP, [Out] float KMOJOHHDCLJ, [Out] float JCGDFDLNFJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x7C132D0", Offset = "0x7C120D0", VA = "0x187C132D0")]
		public void UpdateEmote()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x7C13670", Offset = "0x7C12470", VA = "0x187C13670")]
		public void UpdateHandPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x7C114C0", Offset = "0x7C102C0", VA = "0x187C114C0")]
		private void IEMCDIOMMFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
		private void BJGKEHADIJM(FLJBCFIDHCI CACIHEEMLOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
		private void DAAAEDLKLLM(FLJBCFIDHCI CACIHEEMLOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x7C109C0", Offset = "0x7C0F7C0", VA = "0x187C109C0")]
		private void DMMLJFAIABJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x7C13A50", Offset = "0x7C12850", VA = "0x187C13A50")]
		public PlayerModernBodyEditorAvatarValidator()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x7C10150", Offset = "0x7C0EF50", VA = "0x187C10150")]
		[CompilerGenerated]
		private KIBCEDHJJBM BDEKCGJJPGB((GameObject, HHFLIOCEMDF) LCHOCLMOGHB)
		{
			return default(KIBCEDHJJBM);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class SkinnedMeshBonesInspector : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		[DBPOJNFABNN(CBEHFHOOABN.Self, false, false, false)]
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

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9B0", Offset = "0xA097B0", VA = "0x180A0A9B0")]
		public SkinnedMeshBonesInspector()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct KIBCEDHJJBM
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class GEIHACEEOAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public IEnumerable<OutfitType> otherOutfitTypes;

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public GEIHACEEOAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x7C046E0", Offset = "0x7C034E0", VA = "0x187C046E0")]
		internal bool EPFEBKECMLD(OutfitType outfitType)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	private FLJBCFIDHCI HFJCBNCNKLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	private HHFLIOCEMDF CMMCNNKABPB;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public FLJBCFIDHCI DJPCBFHBPPB
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public HHFLIOCEMDF HLMNABLPCCF
	{
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA10", Offset = "0xD5A810", VA = "0x180D5BA10")]
		get
		{
			return default(HHFLIOCEMDF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public string HLFNKPBADEA
	{
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x7C05410", Offset = "0x7C04210", VA = "0x187C05410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public bool CMFNJGCGGCP
	{
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x7C05500", Offset = "0x7C04300", VA = "0x187C05500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool JCGOKDAAOPF
	{
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x7C053C0", Offset = "0x7C041C0", VA = "0x187C053C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x1803FC0", Offset = "0x1802DC0", VA = "0x181803FC0")]
	public KIBCEDHJJBM(FLJBCFIDHCI CACIHEEMLOB, HHFLIOCEMDF PEADOPOCNJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x7C05550", Offset = "0x7C04350", VA = "0x187C05550")]
	public bool OBDDHIGHAIC(OutfitType MDNHGLCLNKN, HHFLIOCEMDF LABHINFIKHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x7C05620", Offset = "0x7C04420", VA = "0x187C05620")]
	public bool PDANKAPDKKB(OutfitType MDNHGLCLNKN, HHFLIOCEMDF LABHINFIKHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x7C051D0", Offset = "0x7C03FD0", VA = "0x187C051D0")]
	public bool LJFEJJAALFD(KIBCEDHJJBM FHAIGOFMBIK)
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
