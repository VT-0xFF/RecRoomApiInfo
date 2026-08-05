using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using Mono.Math;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Entities;
using Unity.Jobs;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6A5920", Offset = "0x6A4320", VA = "0x1806A5920")]
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
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6A5920", Offset = "0x6A4320", VA = "0x1806A5920")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class GLGLEMGLGHB
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct JJIGFEFOMIE<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private EntityManager KACBFFMHDCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private NativeArray<Entity> GBNPHFOKMOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private int NENMOOINMCH;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public T OLJIKHALPAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x2D98A30", Offset = "0x2D97430", VA = "0x182D98A30")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2D98AA0", Offset = "0x2D974A0", VA = "0x182D98AA0")]
		public JJIGFEFOMIE(NativeArray<Entity> GBNPHFOKMOH, EntityManager KACBFFMHDCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2D98A90", Offset = "0x2D97490", VA = "0x182D98A90")]
		public bool NPAOPILPJKP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1B65620", Offset = "0x1B64020", VA = "0x181B65620")]
		public JJIGFEFOMIE<T> ICBJEBDOHAE()
		{
			return default(JJIGFEFOMIE<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct OFCOKDAOEHM<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private EntityManager KACBFFMHDCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private NativeArray<Entity> GBNPHFOKMOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int NENMOOINMCH;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1DBE2B0", Offset = "0x1DBCCB0", VA = "0x181DBE2B0")]
	public static bool EJJLMPDOEGL<T>(this NativeArray<T> NKJMIDIDBOE) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1DBE4E0", Offset = "0x1DBCEE0", VA = "0x181DBE4E0")]
	public static string MNKNPPPCNHB<T>(this NativeList<T> AMMGMIDPNEP) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1DBE2E0", Offset = "0x1DBCCE0", VA = "0x181DBE2E0")]
	public static string MNKNPPPCNHB<T>(this NativeArray<T> EIOACKOCJCB) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1DBE270", Offset = "0x1DBCC70", VA = "0x181DBE270")]
	public static JJIGFEFOMIE<T> EGKPJJJLKEJ<T>(this NativeArray<Entity> PFFMOAIJKFC, EntityManager KACBFFMHDCF) where T : class
	{
		return default(JJIGFEFOMIE<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class MPAIKEIBIKB
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class GOBLLLODJEL
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[NativeContainerSupportsMinMaxWriteRestriction]
[NativeContainer]
public struct HLHDDOJAECP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly int JKPFBMEKPDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly uint DMAHNIAHPJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal readonly bool KMOECMLDDNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly bool POMAPOKNJFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly int GEMOMKHMPGC;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5F5C1A0", Offset = "0x5F5ABA0", VA = "0x185F5C1A0")]
	internal HLHDDOJAECP(int FEFFHDFABJK, bool FMOAHOIEJLP, uint MMFCAHDBGHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[NativeContainer]
[DefaultMember("Item")]
public struct LDAFGDLEPJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly Unity.Entities.EntityComponentStore* EMGPFCJGAKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly int JKPFBMEKPDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly int CFOMKOCGGMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly uint DMAHNIAHPJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private int FLILLMPAJBC;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Entity GMLDPDCPAEM
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5F5C930", Offset = "0x5F5B330", VA = "0x185F5C930")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5F5C9D0", Offset = "0x5F5B3D0", VA = "0x185F5C9D0")]
	internal unsafe LDAFGDLEPJJ(int FEFFHDFABJK, int KEMBPIGDPAP, Unity.Entities.EntityComponentStore* FLEAOLHDFHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1DFEEA0", Offset = "0x1DFD8A0", VA = "0x181DFEEA0")]
	public bool HHAMBKOEDIN(Entity EBOGCLNNJGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5F5C7F0", Offset = "0x5F5B1F0", VA = "0x185F5C7F0")]
	public void APHLMFLHBNP(Entity EBOGCLNNJGN, NativeArray<byte> IGKMLAGHNAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct LOBFHLEPAGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private MFBAGNIBMIJ GKLDKDMPMKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private List<int> EBFNKJJAGFC;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int PAKKNJKLENP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5F5CBC0", Offset = "0x5F5B5C0", VA = "0x185F5CBC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IEnumerable<ComponentType> LAHAJKLIEBC
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5F5D370", Offset = "0x5F5BD70", VA = "0x185F5D370")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5F5D4E0", Offset = "0x5F5BEE0", VA = "0x185F5D4E0")]
	public int PKHGFKNBCFG(int NENMOOINMCH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5F5CE60", Offset = "0x5F5B860", VA = "0x185F5CE60")]
	public ComponentType JEIKKHMCAKO(int NENMOOINMCH)
	{
		return default(ComponentType);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5F5E160", Offset = "0x5F5CB60", VA = "0x185F5E160")]
	public LOBFHLEPAGP(LOBFHLEPAGP LDIEPFCHCFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5F5DF80", Offset = "0x5F5C980", VA = "0x185F5DF80")]
	public LOBFHLEPAGP(ComponentType LDIEPFCHCFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5F5E380", Offset = "0x5F5CD80", VA = "0x185F5E380")]
	public LOBFHLEPAGP(ComponentType LDIEPFCHCFG, ComponentType KCHCODPDAGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5F5E050", Offset = "0x5F5CA50", VA = "0x185F5E050")]
	public LOBFHLEPAGP(ComponentType LDIEPFCHCFG, ComponentType KCHCODPDAGF, ComponentType DANKALDMBIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5F5E260", Offset = "0x5F5CC60", VA = "0x185F5E260")]
	public LOBFHLEPAGP(ComponentType LDIEPFCHCFG, ComponentType KCHCODPDAGF, ComponentType DANKALDMBIP, ComponentType GJJCEGJKENH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5F5DE60", Offset = "0x5F5C860", VA = "0x185F5DE60")]
	public LOBFHLEPAGP(ComponentType LDIEPFCHCFG, ComponentType KCHCODPDAGF, ComponentType DANKALDMBIP, ComponentType GJJCEGJKENH, ComponentType OIBINBJMLDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5F5DA70", Offset = "0x5F5C470", VA = "0x185F5DA70")]
	public LOBFHLEPAGP(params ComponentType[] EBFNKJJAGFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5F5D6C0", Offset = "0x5F5C0C0", VA = "0x185F5D6C0")]
	public LOBFHLEPAGP(IEnumerable<ComponentType> EBFNKJJAGFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5F5CC10", Offset = "0x5F5B610", VA = "0x185F5CC10")]
	public void EOCOLGAFPLP(ComponentType DKBELBDDPBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5F5CEE0", Offset = "0x5F5B8E0", VA = "0x185F5CEE0")]
	public void LKDJBHFCBAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5F5CF40", Offset = "0x5F5B940", VA = "0x185F5CF40")]
	public static LOBFHLEPAGP MJIKPLNABDE(in LOBFHLEPAGP LDIEPFCHCFG, in LOBFHLEPAGP KCHCODPDAGF)
	{
		return default(LOBFHLEPAGP);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5F5BF90", Offset = "0x5F5A990", VA = "0x185F5BF90")]
	public static LOBFHLEPAGP MJIKPLNABDE(in LOBFHLEPAGP DNHJJJCEBEN, params ComponentType[] DHGMEKFJIJH)
	{
		return default(LOBFHLEPAGP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5F5D250", Offset = "0x5F5BC50", VA = "0x185F5D250")]
	public static LOBFHLEPAGP MJIKPLNABDE(in LOBFHLEPAGP DNHJJJCEBEN, IEnumerable<ComponentType> DHGMEKFJIJH)
	{
		return default(LOBFHLEPAGP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5F5D560", Offset = "0x5F5BF60", VA = "0x185F5D560", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class GNGACKKNLOG
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x1DC0200", Offset = "0x1DBEC00", VA = "0x181DC0200")]
	public static LOBFHLEPAGP ODCHFOAKABM<T>(this LOBFHLEPAGP DNHJJJCEBEN)
	{
		return default(LOBFHLEPAGP);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5F5C110", Offset = "0x5F5AB10", VA = "0x185F5C110")]
	public static LOBFHLEPAGP ODCHFOAKABM(this LOBFHLEPAGP LDIEPFCHCFG, LOBFHLEPAGP KCHCODPDAGF)
	{
		return default(LOBFHLEPAGP);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5F5BF90", Offset = "0x5F5A990", VA = "0x185F5BF90")]
	public static LOBFHLEPAGP ODCHFOAKABM(this LOBFHLEPAGP LDIEPFCHCFG, params ComponentType[] DHGMEKFJIJH)
	{
		return default(LOBFHLEPAGP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct MFBAGNIBMIJ
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct AGAJCONAMNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public uint DJKFIINHFBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public uint CBJMKLCFBDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public uint OPAKLJCLJJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public uint EDGAAFJJENL;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private FixedListInt128 BOPHDNCMLDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public AGAJCONAMNC FFHDLIBCFEP;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int PAKKNJKLENP
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x1848690", Offset = "0x1847090", VA = "0x181848690")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public IEnumerable<ComponentType> LAHAJKLIEBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5F5E680", Offset = "0x5F5D080", VA = "0x185F5E680")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5F5E4B0", Offset = "0x5F5CEB0", VA = "0x185F5E4B0")]
	private void HDOKLHOFJKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5F5E7B0", Offset = "0x5F5D1B0", VA = "0x185F5E7B0")]
	public int PKHGFKNBCFG(int NENMOOINMCH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5F5E600", Offset = "0x5F5D000", VA = "0x185F5E600")]
	public ComponentType JEIKKHMCAKO(int NENMOOINMCH)
	{
		return default(ComponentType);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5F5EBF0", Offset = "0x5F5D5F0", VA = "0x185F5EBF0")]
	public MFBAGNIBMIJ(ComponentType LDIEPFCHCFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5F5ECF0", Offset = "0x5F5D6F0", VA = "0x185F5ECF0")]
	public MFBAGNIBMIJ(ComponentType LDIEPFCHCFG, ComponentType KCHCODPDAGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5F5EB60", Offset = "0x5F5D560", VA = "0x185F5EB60")]
	public MFBAGNIBMIJ(ComponentType LDIEPFCHCFG, ComponentType KCHCODPDAGF, ComponentType DANKALDMBIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5F5ED60", Offset = "0x5F5D760", VA = "0x185F5ED60")]
	public MFBAGNIBMIJ(ComponentType LDIEPFCHCFG, ComponentType KCHCODPDAGF, ComponentType DANKALDMBIP, ComponentType GJJCEGJKENH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5F5EC40", Offset = "0x5F5D640", VA = "0x185F5EC40")]
	public MFBAGNIBMIJ(ComponentType LDIEPFCHCFG, ComponentType KCHCODPDAGF, ComponentType DANKALDMBIP, ComponentType GJJCEGJKENH, ComponentType OIBINBJMLDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5F5EAB0", Offset = "0x5F5D4B0", VA = "0x185F5EAB0")]
	public MFBAGNIBMIJ(params ComponentType[] EBFNKJJAGFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5F5E920", Offset = "0x5F5D320", VA = "0x185F5E920")]
	public MFBAGNIBMIJ(IEnumerable<ComponentType> EBFNKJJAGFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5F5E4A0", Offset = "0x5F5CEA0", VA = "0x185F5E4A0")]
	public void EOCOLGAFPLP(ComponentType DKBELBDDPBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5F5E480", Offset = "0x5F5CE80", VA = "0x185F5E480")]
	public void DHBABNODNPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5F5E7C0", Offset = "0x5F5D1C0", VA = "0x185F5E7C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class AKDDCBGBPKF
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5F5AD20", Offset = "0x5F59720", VA = "0x185F5AD20")]
	public static EntityQuery OABDHMKMDPK(this EntityQueryDesc AHDLHCKHJBN, SystemBase JGOKKFDANJI)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5F5AE00", Offset = "0x5F59800", VA = "0x185F5AE00")]
	public static EntityQuery OABDHMKMDPK(this EntityQueryDesc AHDLHCKHJBN, EntityManager KACBFFMHDCF)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5F5ABF0", Offset = "0x5F595F0", VA = "0x185F5ABF0")]
	public static EntityQueryDesc KBHBINAGPEB(this EntityQueryDesc AHDLHCKHJBN, params ComponentType[] LMCKNIENCJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5F5AFB0", Offset = "0x5F599B0", VA = "0x185F5AFB0")]
	public static EntityQueryDesc PIEIMLLEKCF(this EntityQueryDesc AHDLHCKHJBN, params ComponentType[] LMCKNIENCJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5F5A940", Offset = "0x5F59340", VA = "0x185F5A940")]
	public static EntityQueryDesc DILPOIDDEIF(this EntityQueryDesc AHDLHCKHJBN, params ComponentType[] LMCKNIENCJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5F5ACE0", Offset = "0x5F596E0", VA = "0x185F5ACE0")]
	public static EntityQueryDesc LKHHLEMPALB(this EntityQueryDesc AHDLHCKHJBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5F5AA30", Offset = "0x5F59430", VA = "0x185F5AA30")]
	public static EntityQueryDesc IEJMKNENONI(this EntityQueryDesc AHDLHCKHJBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5F5AD00", Offset = "0x5F59700", VA = "0x185F5AD00")]
	public static EntityQueryDesc MNJNGCFNIDF(this EntityQueryDesc AHDLHCKHJBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5F5AA50", Offset = "0x5F59450", VA = "0x185F5AA50")]
	public static EntityQueryDesc JIIFMJMHMHI(this EntityQueryDesc AHDLHCKHJBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1707060", Offset = "0x1705A60", VA = "0x181707060")]
	public static EntityQueryDesc ODCHFOAKABM<T>(this EntityQueryDesc AHDLHCKHJBN, bool AGKANBGKHIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x1707030", Offset = "0x1705A30", VA = "0x181707030")]
	public static EntityQueryDesc KBHBINAGPEB<T1>(this EntityQueryDesc AHDLHCKHJBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x1707030", Offset = "0x1705A30", VA = "0x181707030")]
	public static EntityQueryDesc KBHBINAGPEB<T1, T2>(this EntityQueryDesc AHDLHCKHJBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x1707030", Offset = "0x1705A30", VA = "0x181707030")]
	public static EntityQueryDesc KBHBINAGPEB<T1, T2, T3>(this EntityQueryDesc AHDLHCKHJBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x1707030", Offset = "0x1705A30", VA = "0x181707030")]
	public static EntityQueryDesc KBHBINAGPEB<T1, T2, T3, T4>(this EntityQueryDesc AHDLHCKHJBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x1707000", Offset = "0x1705A00", VA = "0x181707000")]
	public static EntityQueryDesc DILPOIDDEIF<T1, T2>(this EntityQueryDesc AHDLHCKHJBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x1707080", Offset = "0x1705A80", VA = "0x181707080")]
	public static EntityQueryDesc PIEIMLLEKCF<T1>(this EntityQueryDesc AHDLHCKHJBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x1707080", Offset = "0x1705A80", VA = "0x181707080")]
	public static EntityQueryDesc PIEIMLLEKCF<T1, T2>(this EntityQueryDesc AHDLHCKHJBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x1702240", Offset = "0x1700C40", VA = "0x181702240")]
	private static ComponentType[] CHCHGNBJMDO<T1>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x1702190", Offset = "0x1700B90", VA = "0x181702190")]
	private static ComponentType[] CHCHGNBJMDO<T1, T2>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x1702B90", Offset = "0x1701590", VA = "0x181702B90")]
	private static ComponentType[] CHCHGNBJMDO<T1, T2, T3>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1702C60", Offset = "0x1701660", VA = "0x181702C60")]
	private static ComponentType[] CHCHGNBJMDO<T1, T2, T3, T4>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5F5AEE0", Offset = "0x5F598E0", VA = "0x185F5AEE0")]
	private static ComponentType[] OBAHDJDIAKE(ComponentType[] LDIEPFCHCFG, ComponentType[] KCHCODPDAGF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct OCFHAMCJHMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly Entity DOCCAFEJPOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly EntityManager AJHOIKIBFLI;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal static class JAMBAELIKJA
{
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class IEOJGKFNEFM
{
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class FAHKCJABMDJ
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1AA73F0", Offset = "0x1AA5DF0", VA = "0x181AA73F0")]
	public static void DJENEDPLKKM<T>(this DynamicBuffer<T> MFPFCCDPGDI, int NENMOOINMCH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1AA7470", Offset = "0x1AA5E70", VA = "0x181AA7470")]
	public static int FAPJKNPKKHA<T>(this DynamicBuffer<T> MFPFCCDPGDI, T NKJMIDIDBOE) where T : struct, IEquatable<T>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1AA7310", Offset = "0x1AA5D10", VA = "0x181AA7310")]
	public static bool BPPHKKBLNAD<T>(this DynamicBuffer<T> MFPFCCDPGDI, T NKJMIDIDBOE) where T : struct, IEquatable<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1AA7620", Offset = "0x1AA6020", VA = "0x181AA7620")]
	public static int FAPJKNPKKHA<T>(this DynamicBuffer<T> MFPFCCDPGDI, T NKJMIDIDBOE, IEqualityComparer<T> GLHBOBOKMHF) where T : struct
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1AA7380", Offset = "0x1AA5D80", VA = "0x181AA7380")]
	public static bool BPPHKKBLNAD<T>(this DynamicBuffer<T> MFPFCCDPGDI, T NKJMIDIDBOE, IEqualityComparer<T> GLHBOBOKMHF) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class AJCCJKMIDCO
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5F5A8C0", Offset = "0x5F592C0", VA = "0x185F5A8C0")]
	public static EntityArchetype IMDAMFNLBJK(this EntityManager KACBFFMHDCF, Span<ComponentType> GKLDKDMPMKM)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5F5A7D0", Offset = "0x5F591D0", VA = "0x185F5A7D0")]
	public static EntityArchetype BACLAEBHGNP(this EntityManager KACBFFMHDCF, Entity EBOGCLNNJGN)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x17011A0", Offset = "0x16FFBA0", VA = "0x1817011A0")]
	public static bool NEAPNDNINHA<T>(this EntityManager KACBFFMHDCF, Entity EBOGCLNNJGN, out DynamicBuffer<T> MFPFCCDPGDI) where T : struct, IBufferElementData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1701690", Offset = "0x1700090", VA = "0x181701690")]
	public static bool PBNGNMEFJPD<T>(this EntityManager KACBFFMHDCF, Entity EBOGCLNNJGN, out DynamicBuffer<T> MFPFCCDPGDI) where T : struct, IBufferElementData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1701220", Offset = "0x16FFC20", VA = "0x181701220")]
	public static DynamicBuffer<T> NFGJEGPIJJG<T>(this EntityManager KACBFFMHDCF, Entity EBOGCLNNJGN) where T : struct, IBufferElementData
	{
		return default(DynamicBuffer<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x16FFCF0", Offset = "0x16FE6F0", VA = "0x1816FFCF0")]
	public static DynamicBuffer<T> APGIHPLBMPD<T>(this EntityManager KACBFFMHDCF, Entity EBOGCLNNJGN) where T : struct, IBufferElementData
	{
		return default(DynamicBuffer<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1700420", Offset = "0x16FEE20", VA = "0x181700420")]
	public static bool KACBHKNANMG<T>(this EntityManager KACBFFMHDCF, Entity EBOGCLNNJGN, out T IOCCOEIFPDB) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1701340", Offset = "0x16FFD40", VA = "0x181701340")]
	public static bool OBJGHOILLMH<T>(this EntityManager KACBFFMHDCF, Entity EBOGCLNNJGN, out T IOCCOEIFPDB) where T : struct, ISharedComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5F5A800", Offset = "0x5F59200", VA = "0x185F5A800")]
	public static LDAFGDLEPJJ ENOPBIDCJAF(this EntityManager KACBFFMHDCF, int FEFFHDFABJK, bool FMOAHOIEJLP = false)
	{
		return default(LDAFGDLEPJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x17003D0", Offset = "0x16FEDD0", VA = "0x1817003D0")]
	public static void ILAMFHJAPCA<T>(this EntityManager KACBFFMHDCF, Entity EBOGCLNNJGN, T GABJDOGFOEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x17000C0", Offset = "0x16FEAC0", VA = "0x1817000C0")]
	public static bool DJCKFJGAEBP<T>(this EntityManager KACBFFMHDCF, Entity EBOGCLNNJGN, out T PAHLILOLPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1700140", Offset = "0x16FEB40", VA = "0x181700140")]
	public static void EKMGCGMJNJA<T>(this EntityManager KACBFFMHDCF, NativeArray<Entity> GBNPHFOKMOH, NativeArray<T> PJIINDGLAPJ) where T : struct, IComponentData
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class DKDIECIBKNL
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5F5B250", Offset = "0x5F59C50", VA = "0x185F5B250")]
	public static bool EJJLMPDOEGL(this EntityQuery KEOHDLCGCLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5F5B290", Offset = "0x5F59C90", VA = "0x185F5B290")]
	public static bool EJJLMPDOEGL(this EntityQuery KEOHDLCGCLB, out int OOJKDAEFAHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x286A280", Offset = "0x2868C80", VA = "0x18286A280")]
	public static EntityQuery IFEOAPMGDCC<T>(this EntityQuery KEOHDLCGCLB)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x286A2C0", Offset = "0x2868CC0", VA = "0x18286A2C0")]
	public static EntityQuery IFEOAPMGDCC<T1, T2>(this EntityQuery KEOHDLCGCLB)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5F5B4F0", Offset = "0x5F59EF0", VA = "0x185F5B4F0")]
	public static EntityQuery IFEOAPMGDCC(this EntityQuery KEOHDLCGCLB, ComponentType DKBELBDDPBK)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5F5B530", Offset = "0x5F59F30", VA = "0x185F5B530")]
	public static NativeArray<Entity> JPNLHBCBOCA(this EntityQuery KEOHDLCGCLB)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2869D40", Offset = "0x2868740", VA = "0x182869D40")]
	public static NativeArray<T> HMCHPMEPFOH<T>(this EntityQuery KEOHDLCGCLB) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2869C50", Offset = "0x2868650", VA = "0x182869C50")]
	public static NativeArray<T> HEGGJKABPGE<T>(this EntityQuery KEOHDLCGCLB, Allocator FAMNMGKAFPB) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5F5B2E0", Offset = "0x5F59CE0", VA = "0x185F5B2E0")]
	public static NativeArray<byte> HEGGJKABPGE(this EntityQuery KEOHDLCGCLB, Allocator FAMNMGKAFPB, int FEFFHDFABJK)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5F5B560", Offset = "0x5F59F60", VA = "0x185F5B560")]
	public static NativeArray<Entity> KJDMABFMLLB(this EntityQuery KEOHDLCGCLB, Allocator FAMNMGKAFPB)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5F5B0A0", Offset = "0x5F59AA0", VA = "0x185F5B0A0")]
	private static NativeArray<byte> CBENAHNOACA(Unity.Entities.UnsafeMatchingArchetypePtrList BHHDKNNKCCN, Allocator FAMNMGKAFPB, HLHDDOJAECP NFMPIOLJBMO, EntityQuery KEOHDLCGCLB, ref Unity.Entities.EntityQueryFilter DOFNLMHADCL)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2869AF0", Offset = "0x28684F0", VA = "0x182869AF0")]
	private static NativeArray<T> CBENAHNOACA<T>(Unity.Entities.UnsafeMatchingArchetypePtrList BHHDKNNKCCN, Allocator FAMNMGKAFPB, ArchetypeChunkComponentType<T> NFMPIOLJBMO, EntityQuery KEOHDLCGCLB, ref Unity.Entities.EntityQueryFilter DOFNLMHADCL) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5F5B6D0", Offset = "0x5F5A0D0", VA = "0x185F5B6D0")]
	private static NativeArray<Entity> OHEMCHIIDPF(Unity.Entities.UnsafeMatchingArchetypePtrList BHHDKNNKCCN, Allocator FAMNMGKAFPB, ArchetypeChunkEntityType NFMPIOLJBMO, EntityQuery KEOHDLCGCLB, ref Unity.Entities.EntityQueryFilter DOFNLMHADCL)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5F5B820", Offset = "0x5F5A220", VA = "0x185F5B820")]
	public static global::GBAIANKGCDO<Entity> OIMAFGMDFKH(this EntityQuery NBKDJEEFFOH, Allocator FAMNMGKAFPB = Allocator.TempJob)
	{
		return default(global::GBAIANKGCDO<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2869F40", Offset = "0x2868940", VA = "0x182869F40")]
	public static global::GBAIANKGCDO<T> IADGHEPDNIF<T>(this EntityQuery NBKDJEEFFOH, Allocator FAMNMGKAFPB = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(global::GBAIANKGCDO<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface BOHNNLBFCIM
{
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class NPACBCLJMNP
{
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class AJKKPMKPDDB
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1701A60", Offset = "0x1700460", VA = "0x181701A60")]
	public static Memory<T> ILBGEBFEDDF<T>(int OOJKDAEFAHE)
	{
		return default(Memory<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x17018A0", Offset = "0x17002A0", VA = "0x1817018A0")]
	public static void GHDPFFHPEOJ<T>(this Memory<T> OKJLGLEAIKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct GBAIANKGCDO<T> : IDisposable where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly NativeArray<T> EIOACKOCJCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly JobHandle LGNELGFKAEP;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool CIADPHNANDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x1CAD810", Offset = "0x1CAC210", VA = "0x181CAD810")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int PAKKNJKLENP
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x1CAD800", Offset = "0x1CAC200", VA = "0x181CAD800")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public JobHandle PBNGKBKEGCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x9C65F0", Offset = "0x9C4FF0", VA = "0x1809C65F0")]
		get
		{
			return default(JobHandle);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public NativeArray<T> CNLJLDPJGBM
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xB93020", Offset = "0xB91A20", VA = "0x180B93020")]
		get
		{
			return default(NativeArray<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x1CADB90", Offset = "0x1CAC590", VA = "0x181CADB90")]
	public GBAIANKGCDO(NativeArray<T> EIOACKOCJCB, JobHandle LGNELGFKAEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x1CADB50", Offset = "0x1CAC550", VA = "0x181CADB50")]
	public NativeArray<T> MHGOHAICKEB()
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x36A42A0", Offset = "0x36A2CA0", VA = "0x1836A42A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x36A3E20", Offset = "0x36A2820", VA = "0x1836A3E20")]
	public JobHandle DMDPJFLHNDF(JobHandle MDLEMMPHNCE)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class FOJGLNGHGIN
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5F5B930", Offset = "0x5F5A330", VA = "0x185F5B930")]
	public static JobHandle GNHMKNHFOGC(this JobHandle LDIEPFCHCFG, JobHandle KCHCODPDAGF)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1AB2200", Offset = "0x1AB0C00", VA = "0x181AB2200")]
	public static JobHandle GNHMKNHFOGC<T>(this JobHandle LDIEPFCHCFG, global::GBAIANKGCDO<T> KCHCODPDAGF) where T : struct
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1AB2200", Offset = "0x1AB0C00", VA = "0x181AB2200")]
	public static JobHandle GNHMKNHFOGC<T>(this JobHandle LDIEPFCHCFG, global::OIEIIGDBLKE<T> KCHCODPDAGF) where T : struct
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1AB2250", Offset = "0x1AB0C50", VA = "0x181AB2250")]
	public static JobHandle GNHMKNHFOGC<T>(this global::OIEIIGDBLKE<T> LDIEPFCHCFG, global::OIEIIGDBLKE<T> KCHCODPDAGF) where T : struct
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5F5B970", Offset = "0x5F5A370", VA = "0x185F5B970")]
	public static JobHandle OBAHDJDIAKE(this Span<JobHandle> CGCONEFBPBJ)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct OIEIIGDBLKE<T> : IDisposable where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly NativeList<T> AMMGMIDPNEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly JobHandle LGNELGFKAEP;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool CIADPHNANDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x1CAD810", Offset = "0x1CAC210", VA = "0x181CAD810")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public JobHandle PBNGKBKEGCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x9C65F0", Offset = "0x9C4FF0", VA = "0x1809C65F0")]
		get
		{
			return default(JobHandle);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x1CADB90", Offset = "0x1CAC590", VA = "0x181CADB90")]
	public OIEIIGDBLKE(NativeList<T> AMMGMIDPNEP, JobHandle LGNELGFKAEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x246DFA0", Offset = "0x246C9A0", VA = "0x18246DFA0")]
	public global::GBAIANKGCDO<T> JMBDBJFHMNK()
	{
		return default(global::GBAIANKGCDO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x1CADB50", Offset = "0x1CAC550", VA = "0x181CADB50")]
	public NativeList<T> MHGOHAICKEB()
	{
		return default(NativeList<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x246DEF0", Offset = "0x246C8F0", VA = "0x18246DEF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x246DC80", Offset = "0x246C680", VA = "0x18246DC80")]
	public JobHandle DMDPJFLHNDF(JobHandle MDLEMMPHNCE)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct HHIMHDIJOHN<T> : IDisposable where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly NativeArray<T> EIOACKOCJCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly JobHandle LGNELGFKAEP;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class FLDDJMEOCHA
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x1AB1220", Offset = "0x1AAFC20", VA = "0x181AB1220")]
	public static Span<T> DBMCDGGLOKG<T>(this NativeArray<T> EIOACKOCJCB) where T : struct
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x1AB10C0", Offset = "0x1AAFAC0", VA = "0x181AB10C0")]
	public static Span<T> DBMCDGGLOKG<T>(this NativeList<T> AMMGMIDPNEP) where T : struct
	{
		return default(Span<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class MMLPGGLBOJG
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2384BC0", Offset = "0x23835C0", VA = "0x182384BC0")]
	public static bool JEJFAEMEMPN<T>(T LDIEPFCHCFG, T KCHCODPDAGF) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class GMNFPAMBEOL
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public struct IBAODCDDKFG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private EntityQuery NBKDJEEFFOH;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static bool LPBGAIBIDGB;

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5F5C2C0", Offset = "0x5F5ACC0", VA = "0x185F5C2C0")]
		public IBAODCDDKFG(EntityQuery NBKDJEEFFOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x5F5C270", Offset = "0x5F5AC70", VA = "0x185F5C270", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5F5BD60", Offset = "0x5F5A760", VA = "0x185F5BD60")]
	public static global::GBAIANKGCDO<Entity> OIMAFGMDFKH(this EntityQuery NBKDJEEFFOH, SceneTag HJLNDBMKNHI, Allocator FAMNMGKAFPB = Allocator.TempJob)
	{
		return default(global::GBAIANKGCDO<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5F5BB50", Offset = "0x5F5A550", VA = "0x185F5BB50")]
	public static NativeArray<Entity> JPNLHBCBOCA(this EntityQuery NBKDJEEFFOH, SceneTag HJLNDBMKNHI, Allocator FAMNMGKAFPB = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5F5BCA0", Offset = "0x5F5A6A0", VA = "0x185F5BCA0")]
	public static IBAODCDDKFG LPAMFHHFMFM(this EntityQuery NBKDJEEFFOH, SceneTag HJLNDBMKNHI)
	{
		return default(IBAODCDDKFG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5F5BA20", Offset = "0x5F5A420", VA = "0x185F5BA20")]
	public static int IHADMFKMKCL(this EntityQuery NBKDJEEFFOH, SceneTag HJLNDBMKNHI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class JJJOBDOAPNC
{
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5F5C310", Offset = "0x5F5AD10", VA = "0x185F5C310")]
	public static bool ECPECCMKLDP(this in EntityManager KACBFFMHDCF, Entity HKPLBJGGAOB, out NativeArray<Entity> CJLOBGEDFCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5F5C540", Offset = "0x5F5AF40", VA = "0x185F5C540")]
	public static bool GNCDNBNGFAN(this in BufferFromEntity<LinkedEntityGroup> BIIKHDCNCIA, Entity HKPLBJGGAOB, out NativeArray<Entity> CJLOBGEDFCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5F5C410", Offset = "0x5F5AE10", VA = "0x185F5C410")]
	public static bool GNCDNBNGFAN(this in DynamicBuffer<LinkedEntityGroup> MFPFCCDPGDI, out NativeArray<Entity> CJLOBGEDFCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5F5C620", Offset = "0x5F5B020", VA = "0x185F5C620")]
	public static NativeArray<Entity> MCGGPFBCDIL(this EntityManager KACBFFMHDCF, Entity HKPLBJGGAOB)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5F5C710", Offset = "0x5F5B110", VA = "0x185F5C710")]
	public static NativeArray<Entity> MCGGPFBCDIL(this BufferFromEntity<LinkedEntityGroup> BIIKHDCNCIA, Entity HKPLBJGGAOB)
	{
		return default(NativeArray<Entity>);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class LHIPOBGMLKE
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static byte[] PNBNOGIJBMC;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static int DGEFGPNJFGJ;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static int GBGLKCBJBIA;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static BigInteger EPCGLFJDNLL;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public LHIPOBGMLKE()
	{
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
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
