using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Microsoft.CodeAnalysis;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x60F9D50", Offset = "0x60F8B50", VA = "0x1860F9D50")]
		public NullableAttribute(byte P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x106BC90", Offset = "0x106AA90", VA = "0x18106BC90")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class FKPGKCDHKAM
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x60F5B30", Offset = "0x60F4930", VA = "0x1860F5B30")]
	public static bool LEOCEDLHLFJ(CFJOJKHOCNL PMGCLDLMDOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x60F5B70", Offset = "0x60F4970", VA = "0x1860F5B70")]
	private static bool LEOCEDLHLFJ(ELJAMJOJJJC CEGABFIPLEP, ref CFJOJKHOCNL PMGCLDLMDOP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct JCEBMBDJFOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public List<BLJGHKPENAO> HLGFBCNBABH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public IEnumerable<GGGMNOOPOGD> KOEOMDFGDCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public ENNKAKMJEJB AIFOGBJKIDC;
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface GGJLCGMPKFI
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(MFPEKMGEHFI CPLKBCGCHAN, out Dictionary<int, int> DGBAMIONCAK);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(AAGDMEHBPKB BLMNMFEBOKD, JANDNEHEMLP JIMPHDIHPOO);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface JPIALPNCJML
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<ByteString> GetValidRoomKeyReplicationIds();

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<ByteString> GetValidRoomCurrencies();

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<ByteString> GetValidRoomConsumables();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class GDJCBGBCGNA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly Dictionary<Guid, Guid> FNGFJCIAEKD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Dictionary<Guid, Guid> FNFPGMAOIKK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6E6F10", Offset = "0x6E5D10", VA = "0x1806E6F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8AFA10", Offset = "0x8AE810", VA = "0x1808AFA10")]
	public GDJCBGBCGNA(Dictionary<Guid, Guid> FNGFJCIAEKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x60F7FE0", Offset = "0x60F6DE0", VA = "0x1860F7FE0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class BINKJHDDOAN
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private class EPNGABPKOML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly HashSet<GGGMNOOPOGD> PMLICEJLKGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly HashSet<ABCPANBOCLN> NAAIDLAGIKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public readonly List<AMBABIBNHAL> OHNFLKFEEGK;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x60F5960", Offset = "0x60F4760", VA = "0x1860F5960")]
		public EPNGABPKOML()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class LLPHPLNCOIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public ABCPANBOCLN destinationGraph;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
		public LLPHPLNCOIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x60F98F0", Offset = "0x60F86F0", VA = "0x1860F98F0")]
		internal bool <InitializeCircuitsV2Remapping>b__0(LABOIJOIPKG n)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class NEOJAAOFODH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public int mpif;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
		public NEOJAAOFODH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x60F9940", Offset = "0x60F8740", VA = "0x1860F9940")]
		internal void <InitializeCircuitsV2Remapping>b__1(LABOIJOIPKG n)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x60F33B0", Offset = "0x60F21B0", VA = "0x1860F33B0")]
	public static DHKKBKOBIML KPBEKHDOEBP(JCEBMBDJFOP FEONMAHDMGB, out JFMPCCBMGFD HFHMPGEBDHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x60F5690", Offset = "0x60F4490", VA = "0x1860F5690")]
	private static void PGEPILNHCIB(DHKKBKOBIML BCPKFIFMIME, EPNGABPKOML JAIAFMLAPNI, out JFMPCCBMGFD HFHMPGEBDHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x60F3B00", Offset = "0x60F2900", VA = "0x1860F3B00")]
	private static void MEPAJKFOHJK(BLJGHKPENAO CJEMJFCDEPP, EPNGABPKOML JAIAFMLAPNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x60F1520", Offset = "0x60F0320", VA = "0x1860F1520")]
	private static void AOOBJGHDKBB(DHKKBKOBIML BCPKFIFMIME, EPNGABPKOML JAIAFMLAPNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x60F1260", Offset = "0x60F0060", VA = "0x1860F1260")]
	private static void ALCCAJHNKLC(ref JCEBMBDJFOP CHNBHCLKLEL, EPNGABPKOML JAIAFMLAPNI, BLJGHKPENAO CJEMJFCDEPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x60F2670", Offset = "0x60F1470", VA = "0x1860F2670")]
	public static bool FPMBKLAFGAL(DHKKBKOBIML BCPKFIFMIME, AHEOPDDDGAA FDEEKFGDBNA, out GDJCBGBCGNA? GHGONHGCECH, out string? KDIFPAMDOPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x60F39E0", Offset = "0x60F27E0", VA = "0x1860F39E0")]
	private static void MCIJJODMNAF(DHKKBKOBIML BCPKFIFMIME, ref AHEOPDDDGAA FDEEKFGDBNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x60F5370", Offset = "0x60F4170", VA = "0x1860F5370")]
	public static Dictionary<Guid, Guid> OKDOODDLMJJ(IEnumerable<BLJGHKPENAO> DLLPHDHFAOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x60F5650", Offset = "0x60F4450", VA = "0x1860F5650")]
	private static void PDJPENDGHBC(DHKKBKOBIML BCPKFIFMIME, ref AHEOPDDDGAA FDEEKFGDBNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x60F4710", Offset = "0x60F3510", VA = "0x1860F4710")]
	private static bool NBKBJJGNKCD(DHKKBKOBIML BCPKFIFMIME, AAGDMEHBPKB BLMNMFEBOKD, ref AHEOPDDDGAA FDEEKFGDBNA, out string KDIFPAMDOPI, out Dictionary<int, int> DGBAMIONCAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x60F3140", Offset = "0x60F1F40", VA = "0x1860F3140")]
	private static Dictionary<Guid, ELJAMJOJJJC> IOOKPLCHMJH(DHKKBKOBIML BCPKFIFMIME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x60F1C80", Offset = "0x60F0A80", VA = "0x1860F1C80")]
	private static bool FEOOMBBFGPN(DHKKBKOBIML BCPKFIFMIME, ref AHEOPDDDGAA FDEEKFGDBNA, out string? KDIFPAMDOPI, out LGBCDPCLHPF? KCCDLKFNNPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x60F1BF0", Offset = "0x60F09F0", VA = "0x1860F1BF0")]
	private static void CEOJFPOFHFL(bool DCPLJFLKDAO, BLJGHKPENAO BOOMENJGLGB, Dictionary<Guid, Guid> DHALOMAAGAA, LGBCDPCLHPF BAACFBONBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x60F17C0", Offset = "0x60F05C0", VA = "0x1860F17C0")]
	private static void BDCOHGPEOIO(bool DCPLJFLKDAO, BLJGHKPENAO BOOMENJGLGB, LGBCDPCLHPF KCCDLKFNNPB, Guid CNPLFGLFDBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x60F2EA0", Offset = "0x60F1CA0", VA = "0x1860F2EA0")]
	private static void ICDGFKKCKCB(BLJGHKPENAO BOOMENJGLGB, Guid KAAHPOLNKAC, LLAGACJFJKN? AINJHDOFCHE, Dictionary<Guid, ELJAMJOJJJC> HHFAPGBMIFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x60F2DB0", Offset = "0x60F1BB0", VA = "0x1860F2DB0")]
	private static void GBLGGOJBGJM(BLJGHKPENAO BOOMENJGLGB, Dictionary<Guid, Guid> DHALOMAAGAA, Dictionary<int, int> IMAIONMKEKP, AAGDMEHBPKB NGINDPJEAPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x60F4D30", Offset = "0x60F3B30", VA = "0x1860F4D30")]
	public static void OJBIDCMGGNP(RepeatedField<BLJGHKPENAO> HGDAJABKPIA, EGKHNGJPMBG BJKOAJCLIMG, IEnumerable<ByteString> DECOHJPPMFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x60F3C20", Offset = "0x60F2A20", VA = "0x1860F3C20")]
	private static void MOMNFPHFJBI(RepeatedField<BLJGHKPENAO> HGDAJABKPIA, GDNPJFBMIIP EPJDLAMGKOM, JPIALPNCJML FLHDFFKMDON)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct AHEOPDDDGAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public bool DCPLJFLKDAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public bool FHPPHKMHKHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public LLAGACJFJKN? AINJHDOFCHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public LLAGACJFJKN? ECLFHAKKMGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public CBJGDDJLIPG JPFKODLGPAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public JPIALPNCJML FLHDFFKMDON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public GGJLCGMPKFI HBOENFCDEIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public Guid CNPLFGLFDBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public ENNKAKMJEJB AIFOGBJKIDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public List<BLJGHKPENAO> BFEMCDGMIND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public Dictionary<string, object> LGALBMFPLLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public LEAKMAKKLLO BECEAHKBMFD;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct LLAGACJFJKN
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private const float AIJGLMKPNCM = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public Vector3 PGEIGNJBBKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public Quaternion BHCPPAMLLMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public float FMNLLENGGHE;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Matrix4x4 BGFPMNDONJG
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x60F9390", Offset = "0x60F8190", VA = "0x1860F9390")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2552770", Offset = "0x2551570", VA = "0x182552770")]
	public LLAGACJFJKN(Vector3 PGEIGNJBBKG, Quaternion BHCPPAMLLMB, float FMNLLENGGHE = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x60F9770", Offset = "0x60F8570", VA = "0x1860F9770")]
	public LLAGACJFJKN(EFOHJPIOGLH PCJBLKLLNJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x60F9890", Offset = "0x60F8690", VA = "0x1860F9890")]
	private LLAGACJFJKN(BICFLJHBCCA MDOKJLAEAEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x60F9040", Offset = "0x60F7E40", VA = "0x1860F9040")]
	public static LLAGACJFJKN DDLBEKCNNHC(GGGMNOOPOGD JCPKHBGBGCO)
	{
		return default(LLAGACJFJKN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x60F9240", Offset = "0x60F8040", VA = "0x1860F9240")]
	public static LLAGACJFJKN IGCNOCAHCJM(LLAGACJFJKN KICGHGEEADG, LLAGACJFJKN MPGIACPJMCO)
	{
		return default(LLAGACJFJKN);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x60F9490", Offset = "0x60F8290", VA = "0x1860F9490")]
	public static LLAGACJFJKN LJJFBFNEMCH((Vector3, Quaternion, float) CPLKBCGCHAN)
	{
		return default(LLAGACJFJKN);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x60F94E0", Offset = "0x60F82E0", VA = "0x1860F94E0")]
	public static LLAGACJFJKN LJJFBFNEMCH(Matrix4x4 GCAAGBCKJAL)
	{
		return default(LLAGACJFJKN);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x60F95E0", Offset = "0x60F83E0", VA = "0x1860F95E0")]
	public LLAGACJFJKN MBEGEALCPCP(Matrix4x4 HAFNICDKMAH)
	{
		return default(LLAGACJFJKN);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x60F8FF0", Offset = "0x60F7DF0", VA = "0x1860F8FF0")]
	public static LLAGACJFJKN CODLFBGEKFL(Vector3 PGEIGNJBBKG)
	{
		return default(LLAGACJFJKN);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x60F9070", Offset = "0x60F7E70", VA = "0x1860F9070")]
	[CompilerGenerated]
	internal static LLAGACJFJKN GAAFAJNIACI(GGGMNOOPOGD EGEEDBJEODH)
	{
		return default(LLAGACJFJKN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class IFFJLAPPLOH : OAGEDDPLKID
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x60F8AA0", Offset = "0x60F78A0", VA = "0x1860F8AA0", Slot = "4")]
	public void FPPLCFIENLI(FEEHGFCAKAJ MBKJLGBKOCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x60F8320", Offset = "0x60F7120", VA = "0x1860F8320")]
	private void FFPNNACOCIL(Dictionary<Guid, Guid> BEIBDCNJFFI, ENMGMJJBHMM ECDFFBHHDCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x60F82C0", Offset = "0x60F70C0", VA = "0x1860F82C0")]
	private void FFPNNACOCIL(Dictionary<Guid, Guid> BEIBDCNJFFI, FLIGBEGJPLD DELALBABGKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x60F8850", Offset = "0x60F7650", VA = "0x1860F8850")]
	private void FFPNNACOCIL(Dictionary<Guid, Guid> BEIBDCNJFFI, MPNEFFFKOFP JKDMDJKLBPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public IFFJLAPPLOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class IEACHFFDAIA : OAGEDDPLKID
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x60F8030", Offset = "0x60F6E30", VA = "0x1860F8030", Slot = "4")]
	public void FPPLCFIENLI(FEEHGFCAKAJ MBKJLGBKOCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public IEACHFFDAIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class KGGIDJAPACP : OAGEDDPLKID
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x60F8E80", Offset = "0x60F7C80", VA = "0x1860F8E80", Slot = "4")]
	public void FPPLCFIENLI(FEEHGFCAKAJ MBKJLGBKOCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public KGGIDJAPACP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class NGHDBNEHOBF : OAGEDDPLKID
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x60F9960", Offset = "0x60F8760", VA = "0x1860F9960", Slot = "4")]
	public void FPPLCFIENLI(FEEHGFCAKAJ MBKJLGBKOCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public NGHDBNEHOBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class KANGDJKKKHN : OAGEDDPLKID
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x60F8C70", Offset = "0x60F7A70", VA = "0x1860F8C70", Slot = "4")]
	public void FPPLCFIENLI(FEEHGFCAKAJ MBKJLGBKOCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public KANGDJKKKHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class NJOLHDGEAKM : OAGEDDPLKID
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x60F9AB0", Offset = "0x60F88B0", VA = "0x1860F9AB0", Slot = "4")]
	public void FPPLCFIENLI(FEEHGFCAKAJ MBKJLGBKOCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public NJOLHDGEAKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class PCIMBLIBCPE : OAGEDDPLKID
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x60F9DE0", Offset = "0x60F8BE0", VA = "0x1860F9DE0", Slot = "4")]
	public void FPPLCFIENLI(FEEHGFCAKAJ MBKJLGBKOCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public PCIMBLIBCPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public sealed class IJCNDKJLKLN : OAGEDDPLKID
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x60F8B50", Offset = "0x60F7950", VA = "0x1860F8B50", Slot = "4")]
	public void FPPLCFIENLI(FEEHGFCAKAJ MBKJLGBKOCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public IJCNDKJLKLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public sealed class EJEAPFGBGEA : OAGEDDPLKID
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x60F5790", Offset = "0x60F4590", VA = "0x1860F5790", Slot = "4")]
	public void FPPLCFIENLI(FEEHGFCAKAJ MBKJLGBKOCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public EJEAPFGBGEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public sealed class IEFGNBEEIFF : OAGEDDPLKID
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x60F80F0", Offset = "0x60F6EF0", VA = "0x1860F80F0", Slot = "4")]
	public void FPPLCFIENLI(FEEHGFCAKAJ MBKJLGBKOCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public IEFGNBEEIFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public sealed class NKGGOJDOMAC : OAGEDDPLKID
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x60F9C30", Offset = "0x60F8A30", VA = "0x1860F9C30", Slot = "4")]
	public void FPPLCFIENLI(FEEHGFCAKAJ MBKJLGBKOCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public NKGGOJDOMAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public sealed class PNCFAEPAJAB : OAGEDDPLKID
{
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly System.Random MJJGEKHBECP;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x60F9FD0", Offset = "0x60F8DD0", VA = "0x1860F9FD0", Slot = "4")]
	public void FPPLCFIENLI(FEEHGFCAKAJ MBKJLGBKOCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public PNCFAEPAJAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct CFJOJKHOCNL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public AAGDMEHBPKB LLNMOPOJDNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NOJNCGDPFEL PAJFGOGIEBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public Dictionary<int, int> IMAIONMKEKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public Dictionary<Guid, Guid> PCLAIBEMBCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public LEAKMAKKLLO BECEAHKBMFD;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface OAGEDDPLKID
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FPPLCFIENLI(FEEHGFCAKAJ MBKJLGBKOCL);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class GAMAKGMNMGG
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static readonly OAGEDDPLKID[] DDMHJNBMENH;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x60F7240", Offset = "0x60F6040", VA = "0x1860F7240")]
	public static void EIFEMKDFPIF(BLJGHKPENAO CPLKBCGCHAN, Dictionary<Guid, Guid> IIKFLGHJIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x60F7450", Offset = "0x60F6250", VA = "0x1860F7450")]
	public static void JMKOOLEHFMG(BLJGHKPENAO? CPLKBCGCHAN, LGBCDPCLHPF BAACFBONBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x60F7640", Offset = "0x60F6440", VA = "0x1860F7640")]
	public static void LEOCEDLHLFJ(FEEHGFCAKAJ MBKJLGBKOCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct FEEHGFCAKAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public AAGDMEHBPKB NGKJLOHJLOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public BLJGHKPENAO BOOMENJGLGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Dictionary<int, int> IMAIONMKEKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Dictionary<Guid, Guid> PCLAIBEMBCK;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x60F5A60", Offset = "0x60F4860", VA = "0x1860F5A60")]
	public Guid MGBEBFKCAGJ(Guid KFIPLDEPOPC)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface LEAKMAKKLLO
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int BPFCBPPDCGL, out Guid IOGCEIDKDBP);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class GAEBBIIJODM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly HashSet<string> GADOKOFJKJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly Dictionary<long, int> PPNNPCJNDMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly HashSet<Guid> OHOJFCADOJO;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyCollection<string> EANPEOBFACG
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6E6F10", Offset = "0x6E5D10", VA = "0x1806E6F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<long, int> NMIIMCGBDHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x60F6130", Offset = "0x60F4F30", VA = "0x1860F6130")]
	public static GAEBBIIJODM BOELGJEBGEB(DAOKIJHMDIJ HOHNOADIOEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x60F5EF0", Offset = "0x60F4CF0", VA = "0x1860F5EF0")]
	public static GAEBBIIJODM AFMLKBNHILG(DHKKBKOBIML IPMMIDLGFIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x60F61A0", Offset = "0x60F4FA0", VA = "0x1860F61A0")]
	public static GAEBBIIJODM DNMOECIFLHM(IEnumerable<string> GADOKOFJKJD, IDictionary<long, int> GLNGAJHGGFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x60F7020", Offset = "0x60F5E20", VA = "0x1860F7020")]
	private GAEBBIIJODM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x60F7120", Offset = "0x60F5F20", VA = "0x1860F7120")]
	private GAEBBIIJODM(IEnumerable<string> GADOKOFJKJD, IDictionary<long, int> GLNGAJHGGFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x60F68D0", Offset = "0x60F56D0", VA = "0x1860F68D0")]
	private void OMMGDBMJBAA(DAOKIJHMDIJ HOHNOADIOEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x60F6360", Offset = "0x60F5160", VA = "0x1860F6360")]
	private void OMMGDBMJBAA(DHKKBKOBIML IPMMIDLGFIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x60F6C00", Offset = "0x60F5A00", VA = "0x1860F6C00")]
	private void OMMGDBMJBAA(EGKHNGJPMBG? OJIIPOMCHKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x60F6A90", Offset = "0x60F5890", VA = "0x1860F6A90")]
	private void OMMGDBMJBAA(LABOIJOIPKG? EGEEDBJEODH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x60F6520", Offset = "0x60F5320", VA = "0x1860F6520")]
	private void OMMGDBMJBAA(BLJGHKPENAO? BOOMENJGLGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x60F62F0", Offset = "0x60F50F0", VA = "0x1860F62F0")]
	private void HAKAHELOEEN(string? GFOOPBAPGFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x60F6050", Offset = "0x60F4E50", VA = "0x1860F6050")]
	private void AIPJFFIODJB(GHFGIOFNFGI? PFMBEFOKIHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x60F5F60", Offset = "0x60F4D60", VA = "0x1860F5F60")]
	private void AIPJFFIODJB(DEHGHAEEMNJ? PFMBEFOKIHF)
	{
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
