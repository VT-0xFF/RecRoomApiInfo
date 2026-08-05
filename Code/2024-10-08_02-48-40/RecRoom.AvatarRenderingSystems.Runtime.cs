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
using RecRoom.AssetIds;
using RecRoom.Avatars;
using RecRoom.Avatars.Data.Shared;
using RecRoom.Core.Studio;
using RecRoom.DataLayer.Attributes;
using RecRoom.Logging.Attributes;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Rendering.Universal;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_AvatarRenderingSystems_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : MPFOBEHAELD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6AEF6D0", Offset = "0x6AEE8D0", VA = "0x186AEF6D0", Slot = "4")]
		public override void ALGAFMBJNNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8BF5C0", Offset = "0x8BE7C0", VA = "0x1808BF5C0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_AvatarRenderingSystems_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : JFBHLNBAFAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6AF2C30", Offset = "0x6AF1E30", VA = "0x186AF2C30", Slot = "8")]
		public override void KGHJDOOILCG(KCABLKMBKAN registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x63262B0", Offset = "0x63254B0", VA = "0x1863262B0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class RecNetCDNAssetReference : AssetReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private RecNetCDNKey key;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override object RuntimeKey
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x8942E0", Offset = "0x8934E0", VA = "0x1808942E0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override string AssetGUID
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x6AF2370", Offset = "0x6AF1570", VA = "0x186AF2370", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6AF2290", Offset = "0x6AF1490", VA = "0x186AF2290", Slot = "17")]
		public override bool RuntimeKeyIsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6AF2330", Offset = "0x6AF1530", VA = "0x186AF2330")]
		public RecNetCDNAssetReference(RecNetCDNKey CPBLLDDDHEE)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class RecNetCDNKey
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public string bundleUrl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public string itemPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public List<RecNetCDNKey> Dependencies;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public string UniqueItemIdentifier
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x897B70", Offset = "0x896D70", VA = "0x180897B70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x897BB0", Offset = "0x896DB0", VA = "0x180897BB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string CacheHash
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x894500", Offset = "0x893700", VA = "0x180894500")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x89F8C0", Offset = "0x89EAC0", VA = "0x18089F8C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6AF23B0", Offset = "0x6AF15B0", VA = "0x186AF23B0")]
		public static RecNetCDNKey NHDPFNJINFE(string HCMEMGNIFJO, string IBFOIPIGKBI = "")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x62D5FA0", Offset = "0x62D51A0", VA = "0x1862D5FA0")]
		public void OFLCHFHFCKP(string JHHPAAPIHGL, string LAJLGEDGOJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6AF24B0", Offset = "0x6AF16B0", VA = "0x186AF24B0")]
		public RecNetCDNKey()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[HAAHLEBGOKA]
public class PJKLEHEDCHO : MCLHHEEPEHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	protected readonly List<Mesh> KMOHGMADLKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	protected readonly List<byte[]> CBGDPDBLBGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	protected readonly List<Matrix4x4> AOHHCEAPKFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	protected readonly List<bool> DNFBJNHKMPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	protected readonly List<int> KAEJKNKKAAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	protected readonly List<bool> NJODLLGENBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	protected readonly List<int> GBBIKIEOCOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	protected Allocator EEGFOBAJBAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	protected COOHDJCDIBL IDOIOGMONDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	protected byte ALEMOFNMHBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	protected IList<int> BLPGBBGOCFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	protected IList<int> BEOJJBKGGBB;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6AF1BC0", Offset = "0x6AF0DC0", VA = "0x186AF1BC0", Slot = "4")]
	public void BGCIHOCIMCJ(Mesh PGLODJCEFNN, Matrix4x4 EIPHBLKBFJK, byte[] PBFIHOKAFEN, bool LJJCDNGHKOA = false, BNHBDMOEGLN.PAEIABBACMD PDMKNNGOKLC = (BNHBDMOEGLN.PAEIABBACMD)0, int OLBBIKIFLNA = -1, bool ANFNFJKILIL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6AF2020", Offset = "0x6AF1220", VA = "0x186AF2020", Slot = "5")]
	public void NPGBCMFFHHG(Allocator PKPCACFEGCG, COOHDJCDIBL NMDEMAAABHL, byte OJKCCIINDHI, [Optional] IList<int> BEGMFMHFLMP, [Optional] IList<int> MNMPHHDILJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6AF1DD0", Offset = "0x6AF0FD0", VA = "0x186AF1DD0")]
	private static void GICLOAJILEF(Mesh PGLODJCEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6AF2060", Offset = "0x6AF1260", VA = "0x186AF2060")]
	public PJKLEHEDCHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[HAAHLEBGOKA]
public struct MPLCEIFCPJL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[ReadOnly]
	public FGOMEHGEGKP JELBJKOGGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[ReadOnly]
	public int KDJHJJHFLJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public GHPCJPJIBIO KAIOEECIECL;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6AEFEA0", Offset = "0x6AEF0A0", VA = "0x186AEFEA0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[NativeContainer]
[HAAHLEBGOKA]
public struct GHPCJPJIBIO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct ILFAHENKCNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Vector3 NMEOEFPHCMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public Vector3 DJCLDHHAKMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public Vector4 ANKNPCHEJPN;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct COMLNJMNCFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public float KMCFMBGKFID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public float NAKMDLDPGCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public float AMNACGCBIGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public float AFDCJBMDPCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public byte JFKNOCIGADL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public byte LBLIJHLKOEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public byte PMKGCLIEHEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public byte LOCJPPEPDNB;
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct OPPKHPMIJOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public half KMCFMBGKFID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public half NAKMDLDPGCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public half AMNACGCBIGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public half AFDCJBMDPCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public byte JFKNOCIGADL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public byte LBLIJHLKOEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public byte PMKGCLIEHEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public byte LOCJPPEPDNB;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct HCJHBIMMLGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public half4 CIHDHJMCJNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public half2 HMGIAOODGNC;
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct IJLOOGJLDJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public half4 CIHDHJMCJNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public half2 HMGIAOODGNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public half2 AHOBBNHJHPP;
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct JODDIGBCIJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public half4 CIHDHJMCJNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public half2 HMGIAOODGNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public half2 AHOBBNHJHPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public half2 HEJKEKELDPG;
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct DNAOJKEGFFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public half4 CIHDHJMCJNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public half2 HMGIAOODGNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public half2 AHOBBNHJHPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public half2 HEJKEKELDPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public half2 BEDLGMJGOJD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct ACBBNAFAIOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public float KMCFMBGKFID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public float NAKMDLDPGCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float AMNACGCBIGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public float AFDCJBMDPCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int JFKNOCIGADL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int LBLIJHLKOEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int PMKGCLIEHEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int LOCJPPEPDNB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct NDMKNHLKCAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Color CIHDHJMCJNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public Vector2 HMGIAOODGNC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct HKLJAJAOOLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public Color CIHDHJMCJNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Vector2 HMGIAOODGNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public Vector2 AHOBBNHJHPP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct PIOGENJNCDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Color CIHDHJMCJNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Vector2 HMGIAOODGNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Vector2 AHOBBNHJHPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Vector2 HEJKEKELDPG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct JLFMOBFDAAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Color CIHDHJMCJNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Vector2 HMGIAOODGNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Vector2 AHOBBNHJHPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Vector2 HEJKEKELDPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Vector2 BEDLGMJGOJD;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool JLABCMNLDPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public NativeArray<ILFAHENKCNG> BHOPCBJPDFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public NativeArray<HCJHBIMMLGL> ALHANIINOFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public NativeArray<IJLOOGJLDJB> BLDANNFJKFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public NativeArray<JODDIGBCIJL> IOMBLENPKNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public NativeArray<DNAOJKEGFFO> CBIMGDMAKEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<OPPKHPMIJOO> BBBKNIMGFGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<COMLNJMNCFD> CJKBPJPBJAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<NDMKNHLKCAP> CEIIEEGLMEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<HKLJAJAOOLI> MPPFLDIKOAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<PIOGENJNCDD> LPEFKEBGCJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<JLFMOBFDAAP> GNMLCLKKLHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<ACBBNAFAIOA> GNJKGAOOHEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NativeArray<int> JICAFBMONNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NativeArray<int> EABLMFJEGFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private NativeArray<int> HJLHCOEPIMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private NativeArray<int> FHEPIPNKOGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public NativeArray<int> AEPIKHIPHHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public NativeArray<int> LBANPDLEMLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public NativeArray<int> PNFIPAFCFNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public NativeArray<BoneWeight> JJEHJCIPFPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NativeArray<int> JGJLGBDNBOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private bool KBJEOHDFCJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x159")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private bool OIIAMEACPJM;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int IELGAMFAMGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6ADCDA0", Offset = "0x6ADBFA0", VA = "0x186ADCDA0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6ADE100", Offset = "0x6ADD300", VA = "0x186ADE100")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int JNNAAOKMACI
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6ADF0E0", Offset = "0x6ADE2E0", VA = "0x186ADF0E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6ADD160", Offset = "0x6ADC360", VA = "0x186ADD160")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int MGIHELNBHBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6ADDDC0", Offset = "0x6ADCFC0", VA = "0x186ADDDC0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6ADDC80", Offset = "0x6ADCE80", VA = "0x186ADDC80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int HGMFPGEPJLD
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6ADD580", Offset = "0x6ADC780", VA = "0x186ADD580")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6ADF0F0", Offset = "0x6ADE2F0", VA = "0x186ADF0F0")]
	public GHPCJPJIBIO(int COJADFKGAOG, int NPIHLIGIPBA, int MFBMGKGNJIM, int FGGDNHHDFEA, Allocator PKPCACFEGCG, int GLLBKPKEICM, JGOAOKLIBCL FMJCMLPEIKF, bool KBJEOHDFCJB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6ADF050", Offset = "0x6ADE250", VA = "0x186ADF050")]
	public void PBMMILHGOJK(int KINMHNEMPOD, Vector3 IGDCKHODAOC, Vector3 PICIPNDFLHH, Vector4 EBCBPNKDEPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6ADD850", Offset = "0x6ADCA50", VA = "0x186ADD850")]
	public void FDNAINJMCBE(int KINMHNEMPOD, BoneWeight FNPOFDECHAG, NativeSlice<byte> PBFIHOKAFEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6ADDDD0", Offset = "0x6ADCFD0", VA = "0x186ADDDD0")]
	public Color NKDELEBHLDE(int KINMHNEMPOD)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6ADD180", Offset = "0x6ADC380", VA = "0x186ADD180")]
	public void BPEEEPEODBG(int KINMHNEMPOD, Color GPOLJDKBMJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6ADCDB0", Offset = "0x6ADBFB0", VA = "0x186ADCDB0")]
	public void ADDLNDGLLKI(byte PGKCHLAPNMI, int KINMHNEMPOD, Vector2 CBCLJAGNBJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6ADD170", Offset = "0x6ADC370", VA = "0x186ADD170")]
	public void AELNCBHAEDP(int KINMHNEMPOD, int AIEHIECDPPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6ADDD60", Offset = "0x6ADCF60", VA = "0x186ADDD60")]
	public bool LDAPAFPJGLM(int PGKCHLAPNMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6ADDC90", Offset = "0x6ADCE90", VA = "0x186ADDC90")]
	public void GGGHDBFHEFA(int GJLNFGNOHLI, int ECDKJELMFBH, int KOHJFMFCHKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6ADD5F0", Offset = "0x6ADC7F0", VA = "0x186ADD5F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6ADE110", Offset = "0x6ADD310", VA = "0x186ADE110")]
	public Mesh OJNPIFOGFGN([Optional] string LJHIDEINODA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[NativeContainer]
[HAAHLEBGOKA]
[DefaultMember("Item")]
public struct FGOMEHGEGKP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public Mesh.MeshDataArray PAALAPBDAJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public NativeArray<int> NLFGMLKBHEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public NativeArray<int> MGJPMJEJNLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public NativeArray<BoneWeight> JJEHJCIPFPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private NativeArray<Matrix4x4> MIFJEBNHLPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private NativeArray<int> KLDBPIKLJEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private NativeArray<byte> EMFOBKACAEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private NativeArray<int> AKFODIPAPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private NativeArray<int> HCGGGGHBPKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public NativeArray<sbyte> DLPOICFMEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public NativeArray<byte> CONGIPHLFFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public NativeArray<bool> ANFNFJKILIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public NativeArray<int> OLBBIKIFLNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private bool KBJEOHDFCJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeArray<int> BFEPBHACPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private bool OIIAMEACPJM;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int JBNIPEBPDLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6ADB7A0", Offset = "0x6ADA9A0", VA = "0x186ADB7A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int BMPLBANLEAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6ADB5F0", Offset = "0x6ADA7F0", VA = "0x186ADB5F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int PKHEFNEOPFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6ADB7C0", Offset = "0x6ADA9C0", VA = "0x186ADB7C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int APBGOPDNIBD
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6ADBBE0", Offset = "0x6ADADE0", VA = "0x186ADBBE0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6ADB600", Offset = "0x6ADA800", VA = "0x186ADB600")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int IELGAMFAMGP
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6ADB5D0", Offset = "0x6ADA7D0", VA = "0x186ADB5D0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6ADBBD0", Offset = "0x6ADADD0", VA = "0x186ADBBD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int DMJEHJLDJKC
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6ADB5E0", Offset = "0x6ADA7E0", VA = "0x186ADB5E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6ADB790", Offset = "0x6ADA990", VA = "0x186ADB790")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public COOHDJCDIBL IKBDLGGGGCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6ADB610", Offset = "0x6ADA810", VA = "0x186ADB610")]
		get
		{
			return default(COOHDJCDIBL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6ADB7B0", Offset = "0x6ADA9B0", VA = "0x186ADB7B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public byte PPPFEKKEINK
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6ADB960", Offset = "0x6ADAB60", VA = "0x186ADB960")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6ADB970", Offset = "0x6ADAB70", VA = "0x186ADB970")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public NIGBKDALJNB MEOINHFNJFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6ADB980", Offset = "0x6ADAB80", VA = "0x186ADB980")]
		get
		{
			return default(NIGBKDALJNB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6ADBBF0", Offset = "0x6ADADF0", VA = "0x186ADBBF0")]
	public FGOMEHGEGKP(IList<Mesh> NGFNMDDJNHJ, IList<Matrix4x4> PLCHFKLFMJM, IList<bool> ANFNFJKILIL, byte OJKCCIINDHI, IList<byte[]> PCPNHIEJLCP, IList<int> FBPLNLNGHID, IList<bool> MPIENMKPMPC, IList<int> OLBBIKIFLNA, IList<int> BEGMFMHFLMP, IList<int> HFABNIFKIPL, Allocator PKPCACFEGCG, COOHDJCDIBL NMDEMAAABHL, bool KBJEOHDFCJB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6ADB890", Offset = "0x6ADAA90", VA = "0x186ADB890")]
	public GHPCJPJIBIO KBKCJGABEHJ(Allocator PKPCACFEGCG, JGOAOKLIBCL FMJCMLPEIKF)
	{
		return default(GHPCJPJIBIO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6ADB620", Offset = "0x6ADA820", VA = "0x186ADB620", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[HAAHLEBGOKA]
public class CAGAPNPJMFL : PJKLEHEDCHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public bool OPEKLAGBHDP;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly ProfilerMarker AFAGALNFOIM;

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6ADAC00", Offset = "0x6AD9E00", VA = "0x186ADAC00")]
	public FGOMEHGEGKP DEHKIOLCKGO()
	{
		return default(FGOMEHGEGKP);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6ADAF00", Offset = "0x6ADA100", VA = "0x186ADAF00")]
	public CAGAPNPJMFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct NIGBKDALJNB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public Mesh.MeshData FHKDJOAOLBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public NativeSlice<BoneWeight> JJEHJCIPFPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public NativeSlice<byte> BDKAJFACCBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public int OKMPOAJAKOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public Matrix4x4 MCIKBJJOGGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public int CEBNJKFDMAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public NativeSlice<byte> PBFIHOKAFEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public bool NMELANFDEBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public int EINFHKNFNAN;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class LAEJGEBPIDC : PAMDDCADMGC
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private abstract class KBGCKIEAIDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public readonly IPFKHDEMKPH BOCBOOOOKOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		protected bool LGPOFOIMJCB;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public virtual bool HFPIGFNBKJJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x8DEA80", Offset = "0x8DDC80", VA = "0x1808DEA80", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public virtual bool NENNEOHGNHJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x8DEA80", Offset = "0x8DDC80", VA = "0x1808DEA80", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public virtual BNHBDMOEGLN.PAEIABBACMD CEBNJKFDMAO
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x8966C0", Offset = "0x8958C0", VA = "0x1808966C0", Slot = "6")]
			get
			{
				return default(BNHBDMOEGLN.PAEIABBACMD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool JJBGBKHPEGD
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xBCB400", Offset = "0xBCA600", VA = "0x180BCB400")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool KEIKEHNCCGI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x19484F0", Offset = "0x19476F0", VA = "0x1819484F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool HLFLEHHHLGB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x6AE0E80", Offset = "0x6AE0080", VA = "0x186AE0E80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool OPNCDBGGAMA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x6AE0E90", Offset = "0x6AE0090", VA = "0x186AE0E90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x897B40", Offset = "0x896D40", VA = "0x180897B40")]
		protected KBGCKIEAIDM(IPFKHDEMKPH PMNOEKODMLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract KAHDNIHNJDF JMOIAPKJACK(int[] APGDLGKHLLJ, List<JHFIGENECJN> CJBNONMAFOA, List<JHFIGENECJN> JAGNNMLKBPJ);

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract FHKEKGFPFBJ BKDNPFJIMDJ(uint PMKKOINIJGG, AvatarSkinnedMeshBoneOrderRemapsData LEMGCDHNPIO);
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private class MFNKBMBOMAO : KBGCKIEAIDM
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class GNJBAEMMJGL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			public NMANDIAIDGE<GameObject> skinAvatarItemPrefabHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			public MFNKBMBOMAO <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
			public GNJBAEMMJGL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x6ADFB20", Offset = "0x6ADED20", VA = "0x186ADFB20")]
			internal void FLIPJMFGPJB(GameObject result)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private readonly AvatarSkinAssetItem.LGCIMJIEOOA HKDLLDCEICM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private readonly AssetReference LBAAFDIJJCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private readonly BNHBDMOEGLN.PAEIABBACMD EEGMEKDCEJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private readonly DIAKMFLOOAA? AONAMMEHDFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly Material[] NFMFILOGACG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private SkinnedMeshRenderer[] ALHEAGCJOBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private AvatarSkinAssetItem BNAGPJBKKEJ;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override BNHBDMOEGLN.PAEIABBACMD CEBNJKFDMAO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x897BF0", Offset = "0x896DF0", VA = "0x180897BF0", Slot = "6")]
			get
			{
				return default(BNHBDMOEGLN.PAEIABBACMD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6AEFD90", Offset = "0x6AEEF90", VA = "0x186AEFD90")]
		public MFNKBMBOMAO(AvatarSkinAssetItem.LGCIMJIEOOA IKJFGIECAFG, AssetReference BDAHBNLBKKG, Material JKCJIEDINLM, IPFKHDEMKPH KEDCKJDPMFP, BNHBDMOEGLN.PAEIABBACMD LCPAHJCCLEN = (BNHBDMOEGLN.PAEIABBACMD)0, [Optional] DIAKMFLOOAA? MKDHNHBBFFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6AEFC80", Offset = "0x6AEEE80", VA = "0x186AEFC80")]
		public MFNKBMBOMAO(AvatarSkinAssetItem.LGCIMJIEOOA IKJFGIECAFG, AssetReference BDAHBNLBKKG, Material JKCJIEDINLM, BNHBDMOEGLN.PAEIABBACMD LCPAHJCCLEN = (BNHBDMOEGLN.PAEIABBACMD)0, [Optional] DIAKMFLOOAA? MKDHNHBBFFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6AEFA40", Offset = "0x6AEEC40", VA = "0x186AEFA40", Slot = "7")]
		public override KAHDNIHNJDF JMOIAPKJACK(int[] APGDLGKHLLJ, List<JHFIGENECJN> CJBNONMAFOA, List<JHFIGENECJN> JAGNNMLKBPJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6AEF760", Offset = "0x6AEE960", VA = "0x186AEF760", Slot = "8")]
		public override FHKEKGFPFBJ BKDNPFJIMDJ(uint PMKKOINIJGG, AvatarSkinnedMeshBoneOrderRemapsData LEMGCDHNPIO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6AEFC10", Offset = "0x6AEEE10", VA = "0x186AEFC10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private class JIBNANALLDK : KBGCKIEAIDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public readonly FBADGLPECBH JIMAHKBFDPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private NMANDIAIDGE<ENGBALPNNIA> JCBOKDHCLKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public ENGBALPNNIA HANLHCDCCKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private NMANDIAIDGE<Material[]> BMKMJPPALKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public Material[] LLCCGLHPPBJ;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override bool HFPIGFNBKJJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x8B0490", Offset = "0x8AF690", VA = "0x1808B0490", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool NENNEOHGNHJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x6AE0CF0", Offset = "0x6ADFEF0", VA = "0x186AE0CF0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6AE0DA0", Offset = "0x6ADFFA0", VA = "0x186AE0DA0")]
		public JIBNANALLDK(IPFKHDEMKPH PMNOEKODMLM, FBADGLPECBH BMFLICKGKAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6AE0860", Offset = "0x6ADFA60", VA = "0x186AE0860", Slot = "7")]
		public override KAHDNIHNJDF JMOIAPKJACK(int[] APGDLGKHLLJ, List<JHFIGENECJN> CJBNONMAFOA, List<JHFIGENECJN> JAGNNMLKBPJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6AE0100", Offset = "0x6ADF300", VA = "0x186AE0100", Slot = "8")]
		public override FHKEKGFPFBJ BKDNPFJIMDJ(uint PMKKOINIJGG, AvatarSkinnedMeshBoneOrderRemapsData LEMGCDHNPIO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6AE0230", Offset = "0x6ADF430", VA = "0x186AE0230")]
		public FHKEKGFPFBJ FMIGLFNBAAG(GameObject DNOCCPEHMDM, uint PMKKOINIJGG, bool LJGJEHONNEJ, bool GOBLILAGBLN, AvatarSkinnedMeshBoneOrderRemapsData LEMGCDHNPIO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6AE0500", Offset = "0x6ADF700", VA = "0x186AE0500")]
		public static bool HMAMAPKEHKP(Renderer[] NDIAJNKEHMG, string IBLECFCONLI, [Out] Renderer EJMNLNHFBKF, [Out] Renderer EGPIMNFJOLA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6AE0D50", Offset = "0x6ADFF50", VA = "0x186AE0D50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6AE0440", Offset = "0x6ADF640", VA = "0x186AE0440")]
		private (NMANDIAIDGE<ENGBALPNNIA>, NMANDIAIDGE<Material[]>) GDHBJAHJBAM()
		{
			return default((NMANDIAIDGE<ENGBALPNNIA>, NMANDIAIDGE<Material[]>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x457B760", Offset = "0x457A960", VA = "0x18457B760")]
		[CompilerGenerated]
		private void PDPNCKCIFOJ(ENGBALPNNIA KHPJAGHLNBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8941E0", Offset = "0x8933E0", VA = "0x1808941E0")]
		[CompilerGenerated]
		private void MDLDNDLDCIB(Material[] KHPJAGHLNBM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class CELDPDPPDOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public MFGBFJJJGGK avatarBuildParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public LAEJGEBPIDC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public FKNJNNPDPCK buildMeshPromise;

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public CELDPDPPDOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6ADAF80", Offset = "0x6ADA180", VA = "0x186ADAF80")]
		internal bool DGBNKKLCDDJ(FBADGLPECBH item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6ADB060", Offset = "0x6ADA260", VA = "0x186ADB060")]
		internal void FJODEOECMIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6ADAF60", Offset = "0x6ADA160", VA = "0x186ADAF60")]
		internal void BAABEJJAOLH(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6ADAFD0", Offset = "0x6ADA1D0", VA = "0x186ADAFD0")]
		internal void ENLDMGDLGOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6ADB080", Offset = "0x6ADA280", VA = "0x186ADB080")]
		internal void MHOOOOCJIJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x897B70", Offset = "0x896D70", VA = "0x180897B70")]
		internal KAHDNIHNJDF GGLOBEGJHKG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class IDGPHGFAKPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public int lowestPossibleLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public CELDPDPPDOA CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public IDGPHGFAKPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6AE0040", Offset = "0x6ADF240", VA = "0x186AE0040")]
		internal FGAIJAEJBCB MAFBNJEELOJ(int lod)
		{
			return default(FGAIJAEJBCB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class ICKCEBNAJPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public List<FKNJNNPDPCK> innerPromises;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public ICKCEBNAJPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6ADFF10", Offset = "0x6ADF110", VA = "0x186ADFF10")]
		internal void HOMKIABEIKO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class AEDPLMOLHDF : IEnumerator<CKLDDHMAHNL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private CKLDDHMAHNL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public LAEJGEBPIDC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public List<KBGCKIEAIDM> parts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public List<FKNJNNPDPCK> innerPromises;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public bool isFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public Func<int, FGAIJAEJBCB> getLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public ENABKJENPDJ materialPropertyBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public Material materialInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private int <lodIndex>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private CKLDDHMAHNL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x897B40", Offset = "0x896D40", VA = "0x180897B40")]
		[DebuggerHidden]
		public AEDPLMOLHDF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6ADA9B0", Offset = "0x6AD9BB0", VA = "0x186ADA9B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6ADABB0", Offset = "0x6AD9DB0", VA = "0x186ADABB0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class DHLMCAEHFNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public LAEJGEBPIDC <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public DHLMCAEHFNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6ADB110", Offset = "0x6ADA310", VA = "0x186ADB110")]
		internal KAHDNIHNJDF NPBEADECBGA(KBGCKIEAIDM p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class IJHCAPOJEHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public KIHNKMONKNK cancelable;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public IJHCAPOJEHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xA45FD0", Offset = "0xA451D0", VA = "0x180A45FD0")]
		internal void HFBBNICHDDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xCE9470", Offset = "0xCE8670", VA = "0x180CE9470")]
		internal void EFPAKGHKBLP(string err)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class DNNFHKBAFNF
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
		public LAEJGEBPIDC <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public DNNFHKBAFNF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class NBPLHKMEGID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public GHPCJPJIBIO defaultMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public FGOMEHGEGKP defaultAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public DNNFHKBAFNF CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public NBPLHKMEGID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6AF1980", Offset = "0x6AF0B80", VA = "0x186AF1980")]
		internal void ALABNNHOHLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xCEA680", Offset = "0xCE9880", VA = "0x180CEA680")]
		internal void HAHEALGJOFO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class KGABDAHMBLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public GBOEDOFPINK legacyMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public AMEHBIBNHGE legacyAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public DNNFHKBAFNF CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public KGABDAHMBLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6AE0EB0", Offset = "0x6AE00B0", VA = "0x186AE0EB0")]
		internal void NJHCNKIALPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xCE1530", Offset = "0xCE0730", VA = "0x180CE1530")]
		internal void GBOLJPJJAKO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class EKMNPLEFHOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public KeyValuePair<string, FBADGLPECBH> entry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public KIHNKMONKNK cancelablePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public FBADGLPECBH avatarItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public LAEJGEBPIDC <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public EKMNPLEFHOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6ADB1A0", Offset = "0x6ADA3A0", VA = "0x186ADB1A0")]
		internal KAHDNIHNJDF NHJHPMJJCBD(ADIPFKJJNGC item)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6ADB160", Offset = "0x6ADA360", VA = "0x186ADB160")]
		internal void CNJMMPCJKKP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class CAIEDDDKDCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public NMANDIAIDGE<Texture2D> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public CAIEDDDKDCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6ADAF10", Offset = "0x6ADA110", VA = "0x186ADAF10")]
		internal void PGIHNANHNMF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class KADMBOIMDNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public string overrideItemIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public IPFKHDEMKPH overrideBodyPart;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public KADMBOIMDNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6AE0E00", Offset = "0x6AE0000", VA = "0x186AE0E00")]
		internal bool PPHLFKANGEA(KeyValuePair<string, FBADGLPECBH> entry)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private AvatarConfiguration EPOCJKPABGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private Transform FAMPNAHIMLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private AssetReference LBAAFDIJJCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private GameObject JOBPJOBPMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private GameObject ADLGCIEEGKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private SkinnedMeshRenderer ODJMNODOCBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private AvatarSkinnedMeshBoneOrderRemapsData FMDMBHMGLKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Transform[] BOFFGGNBDLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private Matrix4x4[] BLLNBNJAAAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Material HLACHNKBIPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Material PCNNHCEGMNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Material KNEOPNLNMPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Shader JBOOLOFJAOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private Shader LLHLEPIJJOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private Animator EHNHMPHACAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private Renderer[] GOBDBBLPPEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private BNHBDMOEGLN.PAEIABBACMD FCCAIAKAJMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private AvatarBodyPartShapesManager DIEEBAMPKFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private IReadOnlyDictionary<string, Transform> DGBHOGLONOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private AvatarFaceShapeData.DBILKBMIFPK KAAAILLNNBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private AvatarBodyShapeData.DBMFHCIALAL FEPOJHPDKBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private bool NHOIEBLJAMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB1")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private bool CMNGIJHHMEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private Color HGFFHHHIOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private Color OLFOBEHEMKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private Color BAKJIJEJIOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private Color? JHDKEILEAKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private Color? OBPHLHNDEMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private Color? MHIKKIPIOEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private Color? ODOBABGGCKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private Texture2D KJPOLFLECFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private Texture2D GCFMINAICDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	[CanBeNull]
	private FBADGLPECBH GMBPCAKAOKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private Texture PJALGIADHDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private Color HCIHJIPIJJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public Dictionary<Renderer, ENABKJENPDJ> LDACHCEPCPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Dictionary<Renderer, ENABKJENPDJ> IEEGHBKLNDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private Dictionary<string, List<KGMELMLAMAO>> FOBCDHFEBJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private Dictionary<string, List<KGMELMLAMAO>> DECFMLKEBJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly List<JHFIGENECJN> JGFEGGKPGCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly List<JHFIGENECJN> EELIMDOLNHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly List<JHFIGENECJN> BBOEOJHMFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly List<JHFIGENECJN> AFBMDJIJHAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private Dictionary<KGMELMLAMAO, Material> HPMHNPKDMKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private Dictionary<KGMELMLAMAO, Material> HIKNNCFHLMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private SkinnedMeshRenderer[] LBNLINGPAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private SkinnedMeshRenderer[] AFEDFDJLEOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private SkinnedMeshRenderer[] HDLJNHKFPPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private SkinnedMeshRenderer[] AEOCDGPPBKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly Dictionary<string, NMANDIAIDGE<Texture2D>> NEMMIOJDINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private readonly Dictionary<string, NMANDIAIDGE<Texture2D>> JKOJIAKOAAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private AdditionalHatData HINBKLMLODA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private AdditionalHatData BHLJOHHPJNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private HairData BEAKKMHMNMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private HairData JKKNCGAAJFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private HMMONNFLLEB ADMJGFMFCGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private bool? DIIOMEFOAOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x214")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private PositionAndRotation HHLEJGEPNLD;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private Material AIKCKPGIDJE;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private Material OAMFCHHHBBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private Dictionary<string, FBADGLPECBH> NEEEPELPOLF;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static readonly int HFAPACIAFLA;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly int ODMBIEPEIBI;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly int GJKKMNMNGKK;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly int LNBGECNPIOB;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static readonly int CMOGJNBEAHD;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly int PAKBLNMHAMB;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly int LFODCMDPLPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private readonly OAACCCGABIO FMJPHMFIHHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly OAACCCGABIO PCOIKBIJBNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private bool MMENIPNIELH;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static Lazy<ILGPNHEOFNI> BPNGGOHGOND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private Lazy<BCGHBIIJIGC> OJNNFDMNJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private Lazy<EEEDFHHCABF> HGPEFKGMBBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private AKBDHMBAAAA BLMLAGCDFCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private List<Action> EHMPCFMPGOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private HLJMNDLAJIK IBHOJLDHOHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private SkinnedMeshRenderer[] BODNCLCFJFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private int DEPOHDGIDPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x294")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private bool LBPBMNKCENL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private int GDKOLFJJJPJ;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private static bool FLEHCHIJNNA;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool PCIGKOPJMKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xC67FB0", Offset = "0xC671B0", VA = "0x180C67FB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xC67F80", Offset = "0xC67180", VA = "0x180C67F80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private Material DKHHFFKHMAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6AE1C90", Offset = "0x6AE0E90", VA = "0x186AE1C90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private Material NGGEDJAGIIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6AEC230", Offset = "0x6AEB430", VA = "0x186AEC230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private bool PGOMILEPFNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8B0490", Offset = "0x8AF690", VA = "0x1808B0490")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public DANEJOKJCGO DKIODJNNACP
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x922500", Offset = "0x921700", VA = "0x180922500", Slot = "21")]
		get
		{
			return default(DANEJOKJCGO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	private static ILGPNHEOFNI KLIMJCHPKFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6AEB000", Offset = "0x6AEA200", VA = "0x186AEB000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private BCGHBIIJIGC CGEIPEAFJMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6AE1E50", Offset = "0x6AE1050", VA = "0x186AE1E50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private EEEDFHHCABF HBDDFACPDJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6AE1EA0", Offset = "0x6AE10A0", VA = "0x186AE1EA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private AKBDHMBAAAA FCEHBNFJJLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6AEB440", Offset = "0x6AEA640", VA = "0x186AEB440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public OAACCCGABIO EHGHHJGHLEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x90B2E0", Offset = "0x90A4E0", VA = "0x18090B2E0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public OAACCCGABIO PAFHKDDFGFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x90B2B0", Offset = "0x90A4B0", VA = "0x18090B2B0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public SkinnedMeshRenderer[] NBFEJGPEIHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xDCB300", Offset = "0xDCA500", VA = "0x180DCB300", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public Renderer[] CBIIPLINAPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8A24C0", Offset = "0x8A16C0", VA = "0x1808A24C0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool GPJNAGAOOJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6AE2990", Offset = "0x6AE1B90", VA = "0x186AE2990", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public PositionAndRotation CBAHCMEAHBE
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6AE2210", Offset = "0x6AE1410", VA = "0x186AE2210", Slot = "27")]
		get
		{
			return default(PositionAndRotation);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public BNHBDMOEGLN.PAEIABBACMD FMKGDLFOPIL
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8A2560", Offset = "0x8A1760", VA = "0x1808A2560", Slot = "18")]
		get
		{
			return default(BNHBDMOEGLN.PAEIABBACMD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int DLDODKILAEL
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x1B5C8F0", Offset = "0x1B5BAF0", VA = "0x181B5C8F0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6AE2B60", Offset = "0x6AE1D60", VA = "0x186AE2B60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	private bool PMBJDJEECPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6AE55F0", Offset = "0x6AE47F0", VA = "0x186AE55F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private static bool NOFPBCANIFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6AE18A0", Offset = "0x6AE0AA0", VA = "0x186AE18A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6AECCF0", Offset = "0x6AEBEF0", VA = "0x186AECCF0")]
	public LAEJGEBPIDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6AE2240", Offset = "0x6AE1440", VA = "0x186AE2240", Slot = "28")]
	public void DDNLIMMJHCH(MMHACACOCJN DNFBKNJGPFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6AE6550", Offset = "0x6AE5750", VA = "0x186AE6550", Slot = "29")]
	public void FPAEFDFBCCH(BFELLOJLFHE CCBMDBIAGOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6AE2B60", Offset = "0x6AE1D60", VA = "0x186AE2B60", Slot = "4")]
	public void IOKJDKLONEI(int PMKKOINIJGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6AE13E0", Offset = "0x6AE05E0", VA = "0x186AE13E0", Slot = "9")]
	public void AFMDNKILLFL(GPAIALFICLE HPBHAHGJFPA, Texture2D AIEGELCMLNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6AE96E0", Offset = "0x6AE88E0", VA = "0x186AE96E0", Slot = "10")]
	public void JNALJCFBINP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6AE85F0", Offset = "0x6AE77F0", VA = "0x186AE85F0", Slot = "11")]
	public bool HKAKKKJJEAD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6AE51F0", Offset = "0x6AE43F0", VA = "0x186AE51F0", Slot = "8")]
	public void FAKMKKCJAEG(ALNPFCIDLNP AKJJGDHGPIL, Color? CIHDHJMCJNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6AE9040", Offset = "0x6AE8240", VA = "0x186AE9040")]
	private void INNDJCDLEGE(Action PJLHPDNPLLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6AEB070", Offset = "0x6AEA270", VA = "0x186AEB070", Slot = "5")]
	public void MBKKOAMBLCJ(FBADGLPECBH HGIMNGGPJBO, Texture JKJBFEFLLEA, Color PEMGOKOJCIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0xC67F80", Offset = "0xC67180", VA = "0x180C67F80", Slot = "6")]
	public void LHABLFKOCMC(bool CGJFMIFIBBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1A918E0", Offset = "0x1A90AE0", VA = "0x181A918E0", Slot = "7")]
	public void LKMJACDJBCO(HLJMNDLAJIK JGJLGBDNBOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6AE65D0", Offset = "0x6AE57D0", VA = "0x186AE65D0", Slot = "14")]
	public FKNJNNPDPCK FPCGCDJHEJM(MFGBFJJJGGK LMAKJCBOGPJ, bool MPMBHPDIJNE, int[] NLGKAGMEMGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6AE9C60", Offset = "0x6AE8E60", VA = "0x186AE9C60", Slot = "15")]
	public void KFOKHHPOFOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6AEA050", Offset = "0x6AE9250", VA = "0x186AEA050", Slot = "26")]
	public void LBCEOEJPOIG([Optional] HMMONNFLLEB DHMIEIAKEPB, [Optional] bool? CLCJHAOMHOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6AE1A40", Offset = "0x6AE0C40", VA = "0x186AE1A40")]
	private bool BKBLCLJOEOK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6AEAB00", Offset = "0x6AE9D00", VA = "0x186AEAB00", Slot = "19")]
	public bool LHNFEHKOJBL(BNHBDMOEGLN.PAEIABBACMD BNFIBMMODMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6AE1EF0", Offset = "0x6AE10F0", VA = "0x186AE1EF0")]
	private bool CLNBAOBOMNK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6AE5DA0", Offset = "0x6AE4FA0", VA = "0x186AE5DA0")]
	private FKNJNNPDPCK FGKFKJEMNBG(bool MPMBHPDIJNE, List<KBGCKIEAIDM> DPNELJODLLB, int[] NLGKAGMEMGP, Func<int, FGAIJAEJBCB> IHKIHOABBPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6AE6370", Offset = "0x6AE5570", VA = "0x186AE6370")]
	[IteratorStateMachine(typeof(AEDPLMOLHDF))]
	private IEnumerator<CKLDDHMAHNL> FIFOANBGILE(bool MPMBHPDIJNE, List<KBGCKIEAIDM> DPNELJODLLB, int[] NLGKAGMEMGP, Func<int, FGAIJAEJBCB> IHKIHOABBPA, ENABKJENPDJ MPPJICCOCFP, Material EFOMDECCBNK, List<FKNJNNPDPCK> BHNBDPEMJAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6AE2640", Offset = "0x6AE1840", VA = "0x186AE2640")]
	private FKNJNNPDPCK DMMOJHAGIJC(List<KBGCKIEAIDM> DPNELJODLLB, int[] NLGKAGMEMGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6AE2B80", Offset = "0x6AE1D80", VA = "0x186AE2B80")]
	private GMLIOGMHHKE EJDPLMONINP(List<KBGCKIEAIDM> DPNELJODLLB, int PMKKOINIJGG, bool MPMBHPDIJNE, FGAIJAEJBCB FKKDMNGBFLM, bool MIAIALJABKM, ENABKJENPDJ MPPJICCOCFP, Material EFOMDECCBNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6AEC320", Offset = "0x6AEB520", VA = "0x186AEC320", Slot = "22")]
	public void OEBBKECNMCJ(AvatarFaceShape LEGNGDKFCDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6AE8F80", Offset = "0x6AE8180", VA = "0x186AE8F80", Slot = "23")]
	public void INHIPDBNJHI(AvatarBodyShape HAKPBNKPCAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6AE8090", Offset = "0x6AE7290", VA = "0x186AE8090", Slot = "25")]
	public void GOMPJPNIANL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6AEB9F0", Offset = "0x6AEABF0", VA = "0x186AEB9F0", Slot = "24")]
	public void NFNOPHIJDIL(bool MOHCPLKHLHD, bool KAPIOEAMOEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6AE8CC0", Offset = "0x6AE7EC0", VA = "0x186AE8CC0")]
	private void IJEFNKFPHEG(SkinnedMeshRenderer IBIPBCMOPNG, int PMKKOINIJGG, Mesh PGLODJCEFNN, List<Material> PEJDDPMCJKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6AEC4B0", Offset = "0x6AEB6B0", VA = "0x186AEC4B0")]
	private static Material PLJMKBBPBGA(Dictionary<KGMELMLAMAO, Material> EIJEELGMPIC, Material AJBBDDOGCCA, BLNFDDFHEFB MNDFKONIDLG, HGIIHJMGFCE LALMFAFBJGL, IPFKHDEMKPH KEDCKJDPMFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6AE12B0", Offset = "0x6AE04B0", VA = "0x186AE12B0")]
	private static BLNFDDFHEFB ABLIABKGINP(KBGCKIEAIDM GGMMAHMMMFE, int MJEOIJMGFBL)
	{
		return default(BLNFDDFHEFB);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6AE5990", Offset = "0x6AE4B90", VA = "0x186AE5990")]
	private void FFGFALIFFFG(int CBENCBEBNLN, Material JEDKLDMCCCG, KBGCKIEAIDM GGMMAHMMMFE, [Out] Texture2D EMDDJMOIAOP, [Out] Vector4 DAJNMBBOFAE, [Out] Texture2D BGKGHGGJMNG, [Out] Texture2D JGEDKIFOLNH, [Out] Texture2D ABANJFDBGGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6AEB510", Offset = "0x6AEA710", VA = "0x186AEB510")]
	private void NELLNPDPOPB(int CBENCBEBNLN, Material JEDKLDMCCCG, KBGCKIEAIDM GGMMAHMMMFE, [Out] Color IMHANMGIKGA, [Out] Color NBMPOHPBJHA, [Out] Color JCABDCGPDHI, [Out] Color MOMDNPNGCBO, [Out] Color GICJCEAAJDM, [Out] Color FLONCDFNMAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6AEC610", Offset = "0x6AEB810", VA = "0x186AEC610")]
	private bool PMNNGKHFOLN(Material JEDKLDMCCCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6AE9490", Offset = "0x6AE8690", VA = "0x186AE9490")]
	private static Material JBFOENGOBOA(int CBENCBEBNLN, JIBNANALLDK GGMMAHMMMFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6AE7CB0", Offset = "0x6AE6EB0", VA = "0x186AE7CB0")]
	private static HGIIHJMGFCE GJLHGNHAPPC(KBGCKIEAIDM GGMMAHMMMFE, int MJEOIJMGFBL)
	{
		return default(HGIIHJMGFCE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6AE7DB0", Offset = "0x6AE6FB0", VA = "0x186AE7DB0")]
	private static void GNENFKDECMD(Dictionary<string, List<KGMELMLAMAO>> PBMGPHBCJCB, KBGCKIEAIDM GOFHOOAEHDI, Material AJBBDDOGCCA, BLNFDDFHEFB AKJJGDHGPIL, HGIIHJMGFCE HPBHAHGJFPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6AE4CD0", Offset = "0x6AE3ED0", VA = "0x186AE4CD0")]
	private static SkinnedMeshRenderer ENKFNCBFGCL(Transform GFJIAOAGGKB, Transform PKFOPEOEEPM, SkinnedMeshRenderer[] NDIAJNKEHMG, int PMKKOINIJGG, FGAIJAEJBCB FKKDMNGBFLM, bool MPMBHPDIJNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6AE10F0", Offset = "0x6AE02F0", VA = "0x186AE10F0")]
	private void ABCJOKHGHFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6AE1890", Offset = "0x6AE0A90", VA = "0x186AE1890")]
	private void BHBFBOFDHCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6AE4F00", Offset = "0x6AE4100", VA = "0x186AE4F00")]
	private static void ENLBHLMBKPD(Dictionary<KGMELMLAMAO, Material> EIJEELGMPIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6AE9B00", Offset = "0x6AE8D00", VA = "0x186AE9B00")]
	private static void KDOEKGNDLHK(Dictionary<Renderer, ENABKJENPDJ> ONEPNBHOCIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6AE99E0", Offset = "0x6AE8BE0", VA = "0x186AE99E0")]
	private void KCKECANIGIL(SkinnedMeshRenderer[] NDIAJNKEHMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6AE98B0", Offset = "0x6AE8AB0", VA = "0x186AE98B0")]
	private void KADMBAFILCJ(SkinnedMeshRenderer BFHLPJJAFMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6AE8AF0", Offset = "0x6AE7CF0", VA = "0x186AE8AF0")]
	private void HNGHEOAGGJI(List<JHFIGENECJN> BHLJPCDJJAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6AE9E60", Offset = "0x6AE9060", VA = "0x186AE9E60")]
	private void KGNLCBPKAOA(Dictionary<string, NMANDIAIDGE<Texture2D>> PBMGPHBCJCB, bool OOCOJDOEKMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6AE9FE0", Offset = "0x6AE91E0", VA = "0x186AE9FE0")]
	private void KPCNGFBECKG(Dictionary<string, List<KGMELMLAMAO>> PBMGPHBCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6AEB2E0", Offset = "0x6AEA4E0", VA = "0x186AEB2E0")]
	private void MLNLFKBFHDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6AE5060", Offset = "0x6AE4260", VA = "0x186AE5060")]
	private void EPCKDPMIKBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6AEBA00", Offset = "0x6AEAC00", VA = "0x186AEBA00")]
	private void NJEGGBODHCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6AEC3E0", Offset = "0x6AEB5E0", VA = "0x186AEC3E0")]
	private void ONJFPGDPPOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6AE2500", Offset = "0x6AE1700", VA = "0x186AE2500")]
	private void DJEMBEECMMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6AE8E00", Offset = "0x6AE8000", VA = "0x186AE8E00")]
	private void IJPCDOAHDBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6AE8520", Offset = "0x6AE7720", VA = "0x186AE8520")]
	private void HDONHDJBPMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6AE6480", Offset = "0x6AE5680", VA = "0x186AE6480")]
	private void FKCGGDNNHBO(bool FHHLLBMEMHJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6AE7BE0", Offset = "0x6AE6DE0", VA = "0x186AE7BE0")]
	private void GELIKNJCIFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6AE1FB0", Offset = "0x6AE11B0", VA = "0x186AE1FB0")]
	private void CNMAEAOCMPM(bool FHHLLBMEMHJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6AE5670", Offset = "0x6AE4870", VA = "0x186AE5670")]
	private void FEDGAHIHIAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6AEAB20", Offset = "0x6AE9D20", VA = "0x186AEAB20")]
	private void LIFDCHALHBF(Material EFOMDECCBNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6AEB170", Offset = "0x6AEA370", VA = "0x186AEB170")]
	private void MLLBEMLGDHH(Material EFOMDECCBNK, Color JGOFFJILFEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6AEC870", Offset = "0x6AEBA70", VA = "0x186AEC870")]
	private void POGMDHNCHKD(Material EFOMDECCBNK, Color JGOFFJILFEN, Color CPDNCDGHIKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6AE9760", Offset = "0x6AE8960", VA = "0x186AE9760")]
	private void KABNMFADKAH(Material EFOMDECCBNK, Color IMHANMGIKGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6AE94E0", Offset = "0x6AE86E0", VA = "0x186AE94E0")]
	private void JGFKKNGFPOA(Material EFOMDECCBNK, Texture2D AIEGELCMLNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6AEC0D0", Offset = "0x6AEB2D0", VA = "0x186AEC0D0")]
	private void OBBPGJEBLOM(Material EFOMDECCBNK, Texture KMDEMJJICBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6AE2050", Offset = "0x6AE1250", VA = "0x186AE2050")]
	private void COOPEHPEBLC(Action<ENABKJENPDJ> MNCAGOHLCBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6AE1710", Offset = "0x6AE0910", VA = "0x186AE1710")]
	private void BDMIECIAEIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6AE81C0", Offset = "0x6AE73C0", VA = "0x186AE81C0")]
	private void HDEEBDNAGHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6AE4700", Offset = "0x6AE3900", VA = "0x186AE4700")]
	private FKNJNNPDPCK EKHPKDCOEMG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6AE90C0", Offset = "0x6AE82C0", VA = "0x186AE90C0")]
	private void IPANEDBAGED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6AE8760", Offset = "0x6AE7960", VA = "0x186AE8760")]
	public void HKHDIOMHEJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6AE1B80", Offset = "0x6AE0D80", VA = "0x186AE1B80")]
	[CompilerGenerated]
	private void BLHLPBPOCFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6AE2B00", Offset = "0x6AE1D00", VA = "0x186AE2B00")]
	[CompilerGenerated]
	private void DPKPECIFPDC(ENABKJENPDJ LDHPIHKMGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6AEBFB0", Offset = "0x6AEB1B0", VA = "0x186AEBFB0")]
	[CompilerGenerated]
	private void NPMDMIINLJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6AE2620", Offset = "0x6AE1820", VA = "0x186AE2620")]
	[CompilerGenerated]
	private void DKAHEPOENLK(ENABKJENPDJ LDHPIHKMGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6AE9950", Offset = "0x6AE8B50", VA = "0x186AE9950")]
	[CompilerGenerated]
	private void KBALCDJAJJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6AEA030", Offset = "0x6AE9230", VA = "0x186AEA030")]
	[CompilerGenerated]
	private void KPJAIJPIGHJ(ENABKJENPDJ LDHPIHKMGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6AE2590", Offset = "0x6AE1790", VA = "0x186AE2590")]
	[CompilerGenerated]
	private void DJLCOCEONAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6AE1E20", Offset = "0x6AE1020", VA = "0x186AE1E20")]
	[CompilerGenerated]
	private void CDPMIEAGCNI(ENABKJENPDJ LDHPIHKMGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6AEB0E0", Offset = "0x6AEA2E0", VA = "0x186AEB0E0")]
	[CompilerGenerated]
	private void MHGNMBKCNPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6AEB4E0", Offset = "0x6AEA6E0", VA = "0x186AEB4E0")]
	[CompilerGenerated]
	private void NAHLPIGCPHD(ENABKJENPDJ LDHPIHKMGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6AEC040", Offset = "0x6AEB240", VA = "0x186AEC040")]
	[CompilerGenerated]
	private void NPPPLHHHPFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6AE8F50", Offset = "0x6AE8150", VA = "0x186AE8F50")]
	[CompilerGenerated]
	private void IMJAIAPLJCD(ENABKJENPDJ LDHPIHKMGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6AE2900", Offset = "0x6AE1B00", VA = "0x186AE2900")]
	[CompilerGenerated]
	private void DNEAKKIPNJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6AE6520", Offset = "0x6AE5720", VA = "0x186AE6520")]
	[CompilerGenerated]
	private void FLFILGPLHIL(ENABKJENPDJ LDHPIHKMGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6AE1C10", Offset = "0x6AE0E10", VA = "0x186AE1C10")]
	[CompilerGenerated]
	private void BMKHJFIAIIE(KeyValuePair<string, NMANDIAIDGE<Texture2D>> LKFNGPILILD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6AE1680", Offset = "0x6AE0880", VA = "0x186AE1680")]
	[CompilerGenerated]
	private void AMOIIJJCJII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6AE8190", Offset = "0x6AE7390", VA = "0x186AE8190")]
	[CompilerGenerated]
	private void GPGMKIPEGAH(ENABKJENPDJ LDHPIHKMGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6AE15F0", Offset = "0x6AE07F0", VA = "0x186AE15F0")]
	[CompilerGenerated]
	private void AICEBPPKGAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6AE2B30", Offset = "0x6AE1D30", VA = "0x186AE2B30")]
	[CompilerGenerated]
	private void EDHOANKJLLL(ENABKJENPDJ LDHPIHKMGJD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class LGLABONODFG : OPIFINMLCLO
{
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private static readonly int ODCKJHDLIJA;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private static readonly int GADDCEECFDO;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private static readonly int FIBNPODFIJD;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private static readonly int NEIEDEKAIOB;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private static readonly int APEPOKPJCJK;

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private static readonly int KJGHNIAINCF;

	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private static readonly int GFLIFIEOPLC;

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private static readonly int BFKPDFNMLAM;

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private static readonly int COGKFANLHAK;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private static readonly int PJPJNLDDCMP;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private static readonly int MMBKCOJPAOA;

	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private static readonly int BLIAIDHHCAL;

	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private static readonly int MFEEMLMNAMJ;

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private static readonly int KNLMAGKKOJB;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private static readonly int BAFLDAGMBHH;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private static readonly int ALMLDGCIGII;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static readonly int PBBDGLKDMGM;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private static readonly int EEJONPKKDDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private Transform BJMCFIKOCHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private Transform DMGLEFMHOKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private Transform FNEIDJAAHJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private Transform PLKDKCDPMCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private Transform NBMNIAKEHPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private Transform ELCLCHDNFAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private Transform BKOAGCJGDML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private ICONOBCDNKF CBMCPDAPKFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private MaterialPropertyBlock LBJOMDFKIAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private SkinnedMeshRenderer[] AIPLNCIKJJD;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private MaterialPropertyBlock ICMPDBIONJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6AEF2F0", Offset = "0x6AEE4F0", VA = "0x186AEF2F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool LDONACDLNEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6AEE8F0", Offset = "0x6AEDAF0", VA = "0x186AEE8F0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6AED4D0", Offset = "0x6AEC6D0", VA = "0x186AED4D0", Slot = "7")]
	public void DDNLIMMJHCH(ICONOBCDNKF GMPDEAOANEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6AED4A0", Offset = "0x6AEC6A0", VA = "0x186AED4A0", Slot = "8")]
	public void CHLJKGBGHBG(GFNIKGLNNEI HKMPKNHGPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6AEEDF0", Offset = "0x6AEDFF0", VA = "0x186AEEDF0", Slot = "5")]
	public void MOEILGNDFBD(KEOHOAOFCFA CGCJBEOOPIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6AED5A0", Offset = "0x6AEC7A0", VA = "0x186AED5A0")]
	private Vector2 DNIDNNECLEA(Vector2 MFANFMOEEFK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6AED770", Offset = "0x6AEC970", VA = "0x186AED770", Slot = "6")]
	public void FCJEECFLFLE(BEBEJFPBALF HKMPKNHGPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6AEEAB0", Offset = "0x6AEDCB0", VA = "0x186AEEAB0")]
	private void JJLGPDLNOFL(BEBEJFPBALF KACAHGNKOAI, DMGEMBLIOCG GNOKGMABJMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6AED690", Offset = "0x6AEC890", VA = "0x186AED690")]
	private void EPOGPKKINIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6AEF670", Offset = "0x6AEE870", VA = "0x186AEF670")]
	public LGLABONODFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6AED600", Offset = "0x6AEC800", VA = "0x186AED600")]
	[CompilerGenerated]
	internal static (float, float) EEGFGHAIKLL(float PCPJLMECMML)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6AEEA70", Offset = "0x6AEDC70", VA = "0x186AEEA70")]
	[CompilerGenerated]
	internal static Vector4 HFPIEFKIGOC(Vector2 FJFKFIAGEPM, Vector2 DKGNMCFDBJD)
	{
		return default(Vector4);
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class AvatarItemMaterial : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		[SerializeField]
		[Obsolete("Use CombinationId instead!")]
		private string Guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		[SerializeField]
		private SerializedCombinationId combinationId;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private OOBMPNMLJGF? cachedMaterialCombinationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		[SerializeField]
		private Material material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		[SerializeField]
		private Material[] additionalMaterials;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public FPAFDHKJIGP CombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x6AF6AE0", Offset = "0x6AF5CE0", VA = "0x186AF6AE0")]
			get
			{
				return default(FPAFDHKJIGP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public OOBMPNMLJGF MaterialCombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x6AF6B10", Offset = "0x6AF5D10", VA = "0x186AF6B10")]
			get
			{
				return default(OOBMPNMLJGF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Material Material
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x894480", Offset = "0x893680", VA = "0x180894480")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Material[] AdditionalMaterials
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x894310", Offset = "0x893510", VA = "0x180894310")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6AF65A0", Offset = "0x6AF57A0", VA = "0x186AF65A0")]
		public Material[] GAPDAKCJAJN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x6AF6830", Offset = "0x6AF5A30", VA = "0x186AF6830")]
		public static void KCHFBBAFPHM(AvatarItemMaterial EAOEMHHKBKN, Material JEDKLDMCCCG, int CBENCBEBNLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x6AF6680", Offset = "0x6AF5880", VA = "0x186AF6680")]
		private static bool IANGCOIPHOC(AvatarItemMaterial EAOEMHHKBKN, int CBENCBEBNLN, [Out] Material CBLJKGBCBMG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6AF6A20", Offset = "0x6AF5C20", VA = "0x186AF6A20")]
		public AvatarItemMaterial()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[HAAHLEBGOKA]
public struct AJFDLPECDEA : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	[ReadOnly]
	public AMEHBIBNHGE JELBJKOGGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	[ReadOnly]
	public int KDJHJJHFLJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public GBOEDOFPINK KAIOEECIECL;

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6AF2E00", Offset = "0x6AF2000", VA = "0x186AF2E00", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[NativeContainer]
[HAAHLEBGOKA]
public struct GBOEDOFPINK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	public NativeArray<Vector3> PJGCHGKHKEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public NativeArray<Vector3> CLFKJKOBKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public NativeArray<Vector4> EIFDCOABAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public NativeArray<Vector2> LIFBPCGFCAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	public NativeArray<Vector2> HEJKEKELDPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	public NativeArray<Vector2> BEDLGMJGOJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	public NativeArray<Vector2> HLPKCDGPKNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	public NativeArray<Color> MJCDCPLNELD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	public NativeArray<int> JICAFBMONNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public NativeArray<int> EABLMFJEGFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private NativeArray<int> HJLHCOEPIMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private NativeArray<int> FHEPIPNKOGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public NativeArray<int> AEPIKHIPHHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	public NativeArray<int> LBANPDLEMLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	public NativeArray<int> PNFIPAFCFNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	public NativeArray<BoneWeight> CBFGLPFICBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private NativeArray<int> JGJLGBDNBOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private bool OIIAMEACPJM;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int IELGAMFAMGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x6AFA830", Offset = "0x6AF9A30", VA = "0x186AFA830")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6AFAE10", Offset = "0x6AFA010", VA = "0x186AFAE10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int JNNAAOKMACI
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x6AFB270", Offset = "0x6AFA470", VA = "0x186AFB270")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6AFA890", Offset = "0x6AF9A90", VA = "0x186AFA890")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int MGIHELNBHBK
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6AFADE0", Offset = "0x6AF9FE0", VA = "0x186AFADE0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x6AFAC20", Offset = "0x6AF9E20", VA = "0x186AFAC20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6AFB280", Offset = "0x6AFA480", VA = "0x186AFB280")]
	public GBOEDOFPINK(int COJADFKGAOG, int NPIHLIGIPBA, int MFBMGKGNJIM, int FGGDNHHDFEA, Allocator PKPCACFEGCG, int GLLBKPKEICM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6AFB200", Offset = "0x6AFA400", VA = "0x186AFB200")]
	public void PBMMILHGOJK(int KINMHNEMPOD, Vector3 IGDCKHODAOC, Vector3 PICIPNDFLHH, Vector4 EBCBPNKDEPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6AFAA80", Offset = "0x6AF9C80", VA = "0x186AFAA80")]
	public void FDNAINJMCBE(int KINMHNEMPOD, BoneWeight FNPOFDECHAG, NativeSlice<byte> PBFIHOKAFEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6AFADF0", Offset = "0x6AF9FF0", VA = "0x186AFADF0")]
	public Color NKDELEBHLDE(int KINMHNEMPOD)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6AFA8B0", Offset = "0x6AF9AB0", VA = "0x186AFA8B0")]
	public void BPEEEPEODBG(int KINMHNEMPOD, Color GPOLJDKBMJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6AFA840", Offset = "0x6AF9A40", VA = "0x186AFA840")]
	public void ADDLNDGLLKI(byte PGKCHLAPNMI, int KINMHNEMPOD, Vector2 CBCLJAGNBJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6AFA8A0", Offset = "0x6AF9AA0", VA = "0x186AFA8A0")]
	public void AELNCBHAEDP(int KINMHNEMPOD, int AIEHIECDPPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6AFADB0", Offset = "0x6AF9FB0", VA = "0x186AFADB0")]
	public bool LDAPAFPJGLM(int PGKCHLAPNMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6AFAC30", Offset = "0x6AF9E30", VA = "0x186AFAC30")]
	public void GGGHDBFHEFA(int GJLNFGNOHLI, int ECDKJELMFBH, int KOHJFMFCHKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6AFAD00", Offset = "0x6AF9F00", VA = "0x186AFAD00")]
	public int[] GONBNNJGFGL(int GJLNFGNOHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6AFB170", Offset = "0x6AFA370", VA = "0x186AFB170")]
	private NativeSlice<int> OKAJBANIEHC(int GJLNFGNOHLI)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6AFA8D0", Offset = "0x6AF9AD0", VA = "0x186AFA8D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6AFAE20", Offset = "0x6AFA020", VA = "0x186AFAE20")]
	public Mesh OJNPIFOGFGN([Optional] string LJHIDEINODA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[DefaultMember("Item")]
[HAAHLEBGOKA]
[NativeContainer]
public struct AMEHBIBNHGE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	public NativeArray<Vector3> PJGCHGKHKEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	public NativeArray<Vector3> CLFKJKOBKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	public NativeArray<Vector4> EIFDCOABAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	public NativeArray<Vector2> LIFBPCGFCAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public NativeArray<Vector2> HEJKEKELDPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public NativeArray<Vector2> BEDLGMJGOJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	public NativeArray<Vector2> HLPKCDGPKNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	public NativeArray<Color> MJCDCPLNELD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	public NativeArray<int> MMHJAPLJFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public NativeArray<int> IOHJPPGBMIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public NativeArray<int> EODNHBFMEIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public NativeArray<int> IEFHAMEFGKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	public NativeArray<bool> ANFNFJKILIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	public NativeArray<int> OLBBIKIFLNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	public NativeArray<int> MGJPMJEJNLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	public NativeArray<BoneWeight> JJEHJCIPFPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private NativeArray<Matrix4x4> MIFJEBNHLPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private NativeArray<int> KLDBPIKLJEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private NativeArray<byte> EMFOBKACAEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private NativeArray<int> AKFODIPAPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private NativeArray<int> HCGGGGHBPKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	public NativeArray<sbyte> DLPOICFMEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	public NativeArray<byte> CONGIPHLFFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private NativeArray<int> BFEPBHACPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private bool OIIAMEACPJM;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public int JBNIPEBPDLK
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x21F92F0", Offset = "0x21F84F0", VA = "0x1821F92F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int BMPLBANLEAN
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x12E4580", Offset = "0x12E3780", VA = "0x1812E4580")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int PKHEFNEOPFN
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x6AF4710", Offset = "0x6AF3910", VA = "0x186AF4710")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int APBGOPDNIBD
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6AF4D60", Offset = "0x6AF3F60", VA = "0x186AF4D60")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6AF4470", Offset = "0x6AF3670", VA = "0x186AF4470")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public int IELGAMFAMGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x6AF4450", Offset = "0x6AF3650", VA = "0x186AF4450")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x6AF4D50", Offset = "0x6AF3F50", VA = "0x186AF4D50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int DMJEHJLDJKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x6AF4460", Offset = "0x6AF3660", VA = "0x186AF4460")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x6AF46F0", Offset = "0x6AF38F0", VA = "0x186AF46F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public COOHDJCDIBL IKBDLGGGGCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x6AF4480", Offset = "0x6AF3680", VA = "0x186AF4480")]
		get
		{
			return default(COOHDJCDIBL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x6AF4700", Offset = "0x6AF3900", VA = "0x186AF4700")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public byte PPPFEKKEINK
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6AF4810", Offset = "0x6AF3A10", VA = "0x186AF4810")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6AF4820", Offset = "0x6AF3A20", VA = "0x186AF4820")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public CCFCPHFHBBD MEOINHFNJFI
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x6AF4830", Offset = "0x6AF3A30", VA = "0x186AF4830")]
		get
		{
			return default(CCFCPHFHBBD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x6AF4D70", Offset = "0x6AF3F70", VA = "0x186AF4D70")]
	public AMEHBIBNHGE(IList<Mesh> NGFNMDDJNHJ, IList<Matrix4x4> PLCHFKLFMJM, IList<bool> ANFNFJKILIL, byte OJKCCIINDHI, IList<byte[]> PCPNHIEJLCP, IList<int> FBPLNLNGHID, IList<bool> MPIENMKPMPC, IList<int> OLBBIKIFLNA, IList<int> BEGMFMHFLMP, IList<int> HFABNIFKIPL, Allocator PKPCACFEGCG, COOHDJCDIBL NMDEMAAABHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x6AF4740", Offset = "0x6AF3940", VA = "0x186AF4740")]
	public GBOEDOFPINK KBKCJGABEHJ(Allocator PKPCACFEGCG)
	{
		return default(GBOEDOFPINK);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x6AF4490", Offset = "0x6AF3690", VA = "0x186AF4490", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[HAAHLEBGOKA]
public class NGINIAFOLNP : PJKLEHEDCHO
{
	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x6AFD3F0", Offset = "0x6AFC5F0", VA = "0x186AFD3F0")]
	public AMEHBIBNHGE DEHKIOLCKGO()
	{
		return default(AMEHBIBNHGE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x6ADAF00", Offset = "0x6ADA100", VA = "0x186ADAF00")]
	public NGINIAFOLNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct CCFCPHFHBBD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public NativeSlice<Vector3> PJGCHGKHKEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	public NativeSlice<Vector3> CLFKJKOBKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public NativeSlice<Vector4> EIFDCOABAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public NativeSlice<Vector2> LIFBPCGFCAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public NativeSlice<Vector2> HEJKEKELDPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public NativeSlice<Vector2> BEDLGMJGOJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public NativeSlice<Vector2> HLPKCDGPKNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public NativeSlice<Color> MJCDCPLNELD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public NativeSlice<int> CEGHKHMOLDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public NativeSlice<int> IEFHAMEFGKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public NativeSlice<BoneWeight> JJEHJCIPFPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	public NativeSlice<byte> BDKAJFACCBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	public int OKMPOAJAKOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	public Matrix4x4 MCIKBJJOGGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	public int CEBNJKFDMAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	public NativeSlice<byte> PBFIHOKAFEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	public bool NMELANFDEBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	public int EINFHKNFNAN;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal readonly struct KGMELMLAMAO : IEquatable<KGMELMLAMAO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	internal readonly Material FJOLPIAIAOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	internal readonly BLNFDDFHEFB CEDJOPNKKOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	internal readonly HGIIHJMGFCE KLPCGJKJCPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	internal readonly IPFKHDEMKPH HGMGJNODKEO;

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0xCE6D70", Offset = "0xCE5F70", VA = "0x180CE6D70")]
	public KGMELMLAMAO(Material JEDKLDMCCCG, BLNFDDFHEFB MNDFKONIDLG, HGIIHJMGFCE LALMFAFBJGL, IPFKHDEMKPH KEDCKJDPMFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x6AFBFD0", Offset = "0x6AFB1D0", VA = "0x186AFBFD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0xCE6AD0", Offset = "0xCE5CD0", VA = "0x180CE6AD0", Slot = "4")]
	public bool Equals(KGMELMLAMAO KDHPJMADEAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x6AFBE50", Offset = "0x6AFB050", VA = "0x186AFBE50", Slot = "0")]
	public override bool Equals(object JMJAOKJJFGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x6AFBF30", Offset = "0x6AFB130", VA = "0x186AFBF30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class ENABKJENPDJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private MaterialPropertyBlock NOBMMJOPKIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public Color? MAGGBNPNBLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	public Color? CABJBFNLFEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	public Color? OHLOLNJCBIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	public Color? HKKOICKBLKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	public Color GNFPGDDLJPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	public Color KNBEPKLJLGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	public Color NJPDFLFHBED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	public Texture2D IJHMMKAFNIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	public Texture2D INALCJHMHCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private Dictionary<KGMELMLAMAO, int> ENEMCHKAMAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private BLNFDDFHEFB[] GOJJPFFIDNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private HGIIHJMGFCE[] GHCLMIGABMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public Vector4[] JJBJCLEFJLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	public Vector4[] FFADCAMINLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	public Vector4[] IGIHHIHOMPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	public Vector4[] HHIJGANAKIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public Vector4[] NJOAHFGJLPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public Vector4[] BLEEGBNLGLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private List<Texture2D> HKFDJIIDFHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private Vector4[] INIPMHDEAGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private List<Texture2D> FOAEDOCPNPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private float[] PPNLPPFIHDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private Vector4[] NHGMOOCPOJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private float[] IBDFJMOHAKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public float[] DMBJBAFFOEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private List<Texture2D> IBCCKAEIEFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private float[] LLMHBNECCEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private List<Texture2D> EABGJOOCNLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private Vector4[] LLOEKOLCOPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private float[] GHMIPLABBJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private Vector4[] PIDFGECDBOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public float[] PFNKGIDNKFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public Texture2DArray KOBGIGAINAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public Texture2DArray EJEEJGPFEMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public Texture2DArray IFHICHLMCFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public Texture2DArray GGJPEMDIHBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private bool LCMHHLJCFDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private int BOFMIGHBALC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private Vector2? LMOBOOLMBMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private TextureFormat FABCACMGKAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private Vector2? INBJJDCIPPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private TextureFormat JEFPOEAKEDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private Vector2? CNEKLOJJFLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private TextureFormat GDOILCKNIOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private Vector2? FIFILLLPDBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private TextureFormat FPBLIKOFKLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private bool JBMLAGGIALE;

	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private static int MAGMJMILAMB;

	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private static int AODHAFPHPPM;

	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private static int CCOOACMMPAH;

	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	private static int LFIHBIEKGFL;

	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private static int ENHEGHDFGMB;

	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private static int ANEHBIHMEMI;

	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private static int GGKNNNAIKEP;

	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private static int AKPKGPMKJCE;

	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	private static int HHEJCLBAHKD;

	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private static int EAPBEIANBEC;

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private static int MKBHBIPIAEG;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static int LDFIPAGKDDO;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static int LLIPCCJPELF;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private static int JBHLBJKODFF;

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private static int OBBCGJPBPHB;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private static int OCEDCEIKNOH;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static int BFIBOMMFMNL;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static int FCLGFFDJILI;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static int OPDLJNBLNAF;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private static int CFFAHLJHCJE;

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x6AF9630", Offset = "0x6AF8830", VA = "0x186AF9630")]
	private ENABKJENPDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x6AF9570", Offset = "0x6AF8770", VA = "0x186AF9570")]
	public ENABKJENPDJ(Color GKHGPELBOOL, Color HIFIPIOEJOH, Color EGMAILOGJNO, Color? EIHBLLCFHAF, Color? IDDDIMJCHBG, Color? ALBAODDDHNP, Texture2D IKKCAAOMDBH, Texture2D AJOGIPOJFJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6AF8F70", Offset = "0x6AF8170", VA = "0x186AF8F70")]
	internal int ONBKCIIKDLP(Material LJACEDJAODP, BLNFDDFHEFB MNDFKONIDLG, HGIIHJMGFCE LALMFAFBJGL, IPFKHDEMKPH KEDCKJDPMFP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6AF8EE0", Offset = "0x6AF80E0", VA = "0x186AF8EE0")]
	private int ONBKCIIKDLP(KGMELMLAMAO CPBLLDDDHEE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6AF7FC0", Offset = "0x6AF71C0", VA = "0x186AF7FC0")]
	internal int HAOIFKAEHAK(Material LJACEDJAODP, Color IMHANMGIKGA, Color NBMPOHPBJHA, Color JCABDCGPDHI, Color MOMDNPNGCBO, Color GICJCEAAJDM, Texture2D HCHPKDHKPLB, Vector4 NOGCDCLCGAH, Texture2D MIJPACNNCBE, Vector4 GELAEHAELOJ, float BFLCHJFBEAA, float EFMMKFNNKGM, Texture2D MHPOJPANELN, Vector4 INNFIHDADIA, float EKBIJFPEJOP, Texture2D ALEDLEFMKOP, Color FLONCDFNMAN, Vector4 EOILHOBIJJH, BLNFDDFHEFB MNDFKONIDLG, HGIIHJMGFCE LALMFAFBJGL, IPFKHDEMKPH KEDCKJDPMFP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x6AF9060", Offset = "0x6AF8260", VA = "0x186AF9060")]
	private void PMGIOMHCAMP(List<Texture2D> HKFDJIIDFHH, [Out] Texture2DArray BAMCAACLKLA, [Out] Texture2DArray MPAKDEMBJIH, [Out] Texture2DArray GCPIPHHBGCG, [Out] Texture2DArray FJOKMAGCAHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6AF8B90", Offset = "0x6AF7D90", VA = "0x186AF8B90")]
	public void KADFKIMCGPE(Shader IMMHJONIIAH, Renderer IDGAFEEHOAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6AF7360", Offset = "0x6AF6560", VA = "0x186AF7360")]
	private void GLHMPGHIDCM(Shader IMMHJONIIAH, Renderer IDGAFEEHOAC, int PENKOLGMPNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6AF8CE0", Offset = "0x6AF7EE0", VA = "0x186AF8CE0")]
	private Color LNOPOEEMEGG(Color PPBAMEOOCKC, BLNFDDFHEFB AKJJGDHGPIL)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6AF7020", Offset = "0x6AF6220", VA = "0x186AF7020")]
	private Color DCIBGBBEMJG(Color IMHCMFELCLF, BLNFDDFHEFB AKJJGDHGPIL)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6AF7260", Offset = "0x6AF6460", VA = "0x186AF7260")]
	private bool GGJHOBEFOMI(Texture2D MNGMHDNFIJE, HGIIHJMGFCE HPBHAHGJFPA, [Out] Texture2D GBJFKHFCJPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6AF71B0", Offset = "0x6AF63B0", VA = "0x186AF71B0")]
	private void FEOGNHNADLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x6AF7170", Offset = "0x6AF6370", VA = "0x186AF7170", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class FGPGJALFFPA
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class NMBDKBJGHAG : IEnumerator<CKLDDHMAHNL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private CKLDDHMAHNL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		public JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		private CKLDDHMAHNL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x897B40", Offset = "0x896D40", VA = "0x180897B40")]
		[DebuggerHidden]
		public NMBDKBJGHAG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0xCE7CD0", Offset = "0xCE6ED0", VA = "0x180CE7CD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x6AFD4E0", Offset = "0x6AFC6E0", VA = "0x186AFD4E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0")]
	public static void BADEKOAEIKH(string MHMAFIBKDFF, int PMKKOINIJGG, long EHHLAPIDAAD, long GBJAPJDGIFA, long DPKNDLLENNB, long KCBMAEJNGDL, long LGJIOOCMOIJ, long GHAMDNHBDPM, long ENBJOCONJBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6AF9DC0", Offset = "0x6AF8FC0", VA = "0x186AF9DC0")]
	public static GMLIOGMHHKE GKHEKPKEFOM(JobHandle BOGIMKFDAFN, bool JNCEMJIKNMI, bool PGOMILEPFNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6AF9D50", Offset = "0x6AF8F50", VA = "0x186AF9D50")]
	[IteratorStateMachine(typeof(NMBDKBJGHAG))]
	private static IEnumerator<CKLDDHMAHNL> DIAHDPALFJG(JobHandle OLMIMHPMKPE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class NNNFNAGKCPH
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public enum KKDMEDMALJH
	{
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		General,
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		ColoredHair
	}

	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	public static readonly int FAALGCINNMC;

	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public static readonly int KHLMFLBFPFC;

	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public static readonly int PHMEOPEPENI;

	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public static readonly int OHJNFNAIHGA;

	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	public static readonly int NANCJGMCMGE;

	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public static readonly int MJBNOCOMOLD;

	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public static readonly int NOGPBCIMHOH;

	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public static readonly int GAKPGMPNEBB;

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6AFD5F0", Offset = "0x6AFC7F0", VA = "0x186AFD5F0")]
	public static bool ODOGLMHOHKO(Material JEDKLDMCCCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x6AFD530", Offset = "0x6AFC730", VA = "0x186AFD530")]
	public static bool IJGLMNKDKAN(Material JEDKLDMCCCG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class NCDAAHOIOGL : EEEDFHHCABF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private AAPILCBCGDF GIEGGLEABBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private FBDKKNGIJOJ HNOIEDEHLFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	private IRecRoomQualityConfigProvider DAECONDODFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	private bool OIIAMEACPJM;

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6AFD150", Offset = "0x6AFC350", VA = "0x186AFD150")]
	[NPIOOMADHDK.JLDADBHPDAA.GOAAFNNCHDN]
	internal static void FIPBMMBBEEF(KHAIBIPGEJP DDIEINIMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x5E08AC0", Offset = "0x5E07CC0", VA = "0x185E08AC0")]
	[UnityEngine.Scripting.Preserve]
	public NCDAAHOIOGL([GEFLINBOFNF(null)] FBDKKNGIJOJ PPLEABEAABL, [GEFLINBOFNF(null)] AAPILCBCGDF HAGAHIBHIPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6AFCC00", Offset = "0x6AFBE00", VA = "0x186AFCC00")]
	private void AEFCJJKOLBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x6AFD370", Offset = "0x6AFC570", VA = "0x186AFD370", Slot = "4")]
	public void JNALJCFBINP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6AFCC90", Offset = "0x6AFBE90", VA = "0x186AFCC90", Slot = "5")]
	public NMANDIAIDGE<Texture2D> DDIODFCFJPG(ADIPFKJJNGC JAEJPMKJPEM, [Optional] HLJMNDLAJIK JGJLGBDNBOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6AFD240", Offset = "0x6AFC440", VA = "0x186AFD240")]
	private uint GACCAAHECOO(ADIPFKJJNGC JAEJPMKJPEM, HLJMNDLAJIK JGJLGBDNBOB)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface MCLHHEEPEHF
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BGCIHOCIMCJ(Mesh PGLODJCEFNN, Matrix4x4 EIPHBLKBFJK, byte[] PBFIHOKAFEN, bool LJJCDNGHKOA = false, BNHBDMOEGLN.PAEIABBACMD PDMKNNGOKLC = (BNHBDMOEGLN.PAEIABBACMD)0, int OLBBIKIFLNA = -1, bool ANFNFJKILIL = false);

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NPGBCMFFHHG(Allocator PKPCACFEGCG, COOHDJCDIBL NMDEMAAABHL, byte OJKCCIINDHI, [Optional] IList<int> BEGMFMHFLMP, [Optional] IList<int> MNMPHHDILJA);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public readonly struct ENGBALPNNIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public readonly GameObject DNOCCPEHMDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	private readonly AvatarItemMaterial GLMGPGCFEMF;

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0xD62DE0", Offset = "0xD61FE0", VA = "0x180D62DE0")]
	public ENGBALPNNIA(GameObject DNOCCPEHMDM, AvatarItemMaterial GLMGPGCFEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x6AF9B20", Offset = "0x6AF8D20", VA = "0x186AF9B20")]
	public void DANKMIDGFOF(Material JEDKLDMCCCG, int CBENCBEBNLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class AJFHDAIAMLC : HDNLHEFEKAA<Task<(GameObject, AvatarItemMaterial)>, ENGBALPNNIA>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct GGCNCNHJMIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public AsyncTaskMethodBuilder<(GameObject, AvatarItemMaterial)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public Task<GameObject> goTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public Task<AvatarItemMaterial> materialTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private GameObject <go>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private TaskAwaiter<GameObject> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private TaskAwaiter<AvatarItemMaterial> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x6AFB6E0", Offset = "0x6AFA8E0", VA = "0x186AFB6E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x6AFBBE0", Offset = "0x6AFADE0", VA = "0x186AFBBE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	private NMANDIAIDGE<GameObject> PNPNBMIPIAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	private NMANDIAIDGE<AvatarItemMaterial> LAEIBHHFFGO;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6AF43C0", Offset = "0x6AF35C0", VA = "0x186AF43C0")]
	private AJFHDAIAMLC(Task<(GameObject, AvatarItemMaterial)> HMHJFGCCEGP, NMANDIAIDGE<GameObject> KJBNHNLEOML, NMANDIAIDGE<AvatarItemMaterial> CKCPIKBABMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6AF3FB0", Offset = "0x6AF31B0", VA = "0x186AF3FB0")]
	public static AJFHDAIAMLC LGJIMIKIEOH(AssetReference CMPCHLPFINI, [Optional] AssetReference PJKIDAEEEIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6AF3F10", Offset = "0x6AF3110", VA = "0x186AF3F10", Slot = "11")]
	protected override ENGBALPNNIA BPBAHHLOKJA(Task<(GameObject, AvatarItemMaterial)> GIGCOPIBLKF)
	{
		return default(ENGBALPNNIA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6AF3E90", Offset = "0x6AF3090", VA = "0x186AF3E90", Slot = "12")]
	protected override void BKBGOKOLGFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x6AF3D60", Offset = "0x6AF2F60", VA = "0x186AF3D60")]
	[AsyncStateMachine(typeof(GGCNCNHJMIN))]
	private static Task<(GameObject, AvatarItemMaterial)> AJLKGAEBBDO(Task<GameObject> HFAHBAHHANF, Task<AvatarItemMaterial> ANMCFOCEKBN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class MLIGPOAPJHE
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	private class MPEHCGOAGGK : HDNLHEFEKAA<Task<MaterialMapAsset>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		private NMANDIAIDGE<MaterialMapAsset> OLMIMHPMKPE;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x6AFCB20", Offset = "0x6AFBD20", VA = "0x186AFCB20")]
		public MPEHCGOAGGK(NMANDIAIDGE<MaterialMapAsset> OLMIMHPMKPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x6AFC700", Offset = "0x6AFB900", VA = "0x186AFC700", Slot = "11")]
		protected override Material[] BPBAHHLOKJA(Task<MaterialMapAsset> HMHJFGCCEGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x6AFC6A0", Offset = "0x6AFB8A0", VA = "0x186AFC6A0", Slot = "12")]
		protected override void BKBGOKOLGFD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private class IGJFOPIBOML : HDNLHEFEKAA<Task<Material[]>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private List<NMANDIAIDGE<Material>> DKHHIJDHDFG;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x6AFBDE0", Offset = "0x6AFAFE0", VA = "0x186AFBDE0")]
		public IGJFOPIBOML(Task<Material[]> HMHJFGCCEGP, List<NMANDIAIDGE<Material>> DKHHIJDHDFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x6AFBD90", Offset = "0x6AFAF90", VA = "0x186AFBD90", Slot = "11")]
		protected override Material[] BPBAHHLOKJA(Task<Material[]> GIGCOPIBLKF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x6AFBC50", Offset = "0x6AFAE50", VA = "0x186AFBC50", Slot = "12")]
		protected override void BKBGOKOLGFD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private static readonly GAFGFHIJEHD ACKGBNDHEHM;

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x6AFC1F0", Offset = "0x6AFB3F0", VA = "0x186AFC1F0")]
	public static NMANDIAIDGE<Material[]> CPILIBGJJGM(AssetReference[] HDMHCCMMJNP)
	{
		return null;
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public class SkinnedMeshBonesInspector : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		[FICFPGOHBIA(IKBOIBNEMID.Self, false, false, false)]
		[SerializeField]
		private SkinnedMeshRenderer skinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		[SerializeField]
		private int BoneWeightsDisplayStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		[SerializeField]
		private int BoneWeightsDisplayAmount;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x6AFD7D0", Offset = "0x6AFC9D0", VA = "0x186AFD7D0")]
		public SkinnedMeshBonesInspector()
		{
		}
	}
}
namespace RecRoom.Avatars.Face
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public sealed class FaceStyleSet : ScriptableObject
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private struct BJIPCIKLBAD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000210")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000211")]
			public AsyncTaskMethodBuilder<HBFKEPBAMCF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000212")]
			public FaceStyleSet <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000213")]
			public int? eyeBrows;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000214")]
			public int eye;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000215")]
			public int mouth;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000216")]
			private TaskAwaiter<HBFKEPBAMCF> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x6AF6BD0", Offset = "0x6AF5DD0", VA = "0x186AF6BD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x6AF6FB0", Offset = "0x6AF61B0", VA = "0x186AF6FB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		public SymmetricalFaceFeature[] EyeBrows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public EyesFaceFeature[] Eyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		public NoseFaceOption[] Noses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		public FaceFeature[] Mouths;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		[Header("Default Values")]
		public SymmetricalFaceFeature DefaultEyeBrowsFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public EyesFaceFeature DefaultEyesFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public FaceFeature DefaultMouthFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private Dictionary<DIAKMFLOOAA, SymmetricalFaceFeature> eyeBrowFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private Dictionary<DIAKMFLOOAA, EyesFaceFeature> eyeFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private Dictionary<DIAKMFLOOAA, NoseFaceOption> noseOptionsDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private Dictionary<DIAKMFLOOAA, FaceFeature> mouthFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private readonly Dictionary<DIAKMFLOOAA, int> featureToIndexMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private HBFKEPBAMCF _defaultFaceStyleLegacyBean;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private HBFKEPBAMCF _defaultFaceStyleModernBody;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		private bool dictionariesInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x6AFA800", Offset = "0x6AF9A00", VA = "0x186AFA800")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x6AFA490", Offset = "0x6AF9690", VA = "0x186AFA490")]
		public HBFKEPBAMCF HFNAPOICLHC(DANEJOKJCGO HAELGLMEIMP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x6AFA5C0", Offset = "0x6AF97C0", VA = "0x186AFA5C0")]
		[AsyncStateMachine(typeof(BJIPCIKLBAD))]
		public Task<HBFKEPBAMCF> LLOCJGPHHPK(int? PFFGMGBDHBA, int MJLANDDAFKB, int OAKOEENAKOO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x6AFA520", Offset = "0x6AF9720", VA = "0x186AFA520")]
		public NoseFaceOption JIJPEAHEBEP(int MFHFGAMBNHP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x6AF9F10", Offset = "0x6AF9110", VA = "0x186AF9F10")]
		public SelectableFaceOption BCKNOEANNPP(FaceFeatureType JGLOFNNAFGG, DIAKMFLOOAA OPIFCNEBLBB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x6AFA6F0", Offset = "0x6AF98F0", VA = "0x186AFA6F0")]
		public int NDAGFBIOHHK(DIAKMFLOOAA OPIFCNEBLBB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x6AFA260", Offset = "0x6AF9460", VA = "0x186AFA260")]
		private void HDONJDKAPNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x2E005B0", Offset = "0x2DFF7B0", VA = "0x182E005B0")]
		private void PCKBINIDPPC<T>(IDictionary<DIAKMFLOOAA, T> HEPGHFONHMI, IReadOnlyList<T> ADDIGEAJAKF) where T : SelectableFaceOption
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x6AFA1B0", Offset = "0x6AF93B0", VA = "0x186AFA1B0")]
		public DIAKMFLOOAA GJNNGEKDCLG(FaceFeatureType JGLOFNNAFGG)
		{
			return default(DIAKMFLOOAA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x6AFA090", Offset = "0x6AF9290", VA = "0x186AFA090")]
		public DIAKMFLOOAA FBLEPBOLNOG(FaceFeatureType JGLOFNNAFGG)
		{
			return default(DIAKMFLOOAA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x6AFA770", Offset = "0x6AF9970", VA = "0x186AFA770")]
		public FaceStyleSet()
		{
		}
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
