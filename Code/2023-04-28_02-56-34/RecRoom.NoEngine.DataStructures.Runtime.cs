using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x69F0E20", Offset = "0x69EF820", VA = "0x1869F0E20")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x72C090", Offset = "0x72AA90", VA = "0x18072C090")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA36880", Offset = "0xA35280", VA = "0x180A36880")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct OJKKFFLDPME : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x72A820", Offset = "0x729220", VA = "0x18072A820")]
	public static OJKKFFLDPME AENBDOEOIOH(Type OGILDIMGIOH, [Optional] string? PHICDGIEFLG, [Optional] string? GJHAEFNLOCG, bool CPKFKLHCCHO = false)
	{
		return default(OJKKFFLDPME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x72A820", Offset = "0x729220", VA = "0x18072A820")]
	public static OJKKFFLDPME AENBDOEOIOH<T>([Optional] string? PHICDGIEFLG, [Optional] string? GJHAEFNLOCG, bool CPKFKLHCCHO = false)
	{
		return default(OJKKFFLDPME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct CPFMMOODPIE
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public delegate bool ACOOFFCIGGP(string ACNHNBLINPG, CPFMMOODPIE MGHHFPCAJLH);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public int LOCDANMFCCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public string DPBBLFJJIFG;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x69F0200", Offset = "0x69EEC00", VA = "0x1869F0200")]
	public static Dictionary<string, CPFMMOODPIE> IJFPLNHFGDG(Type ONAHEPMMCHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x69EFED0", Offset = "0x69EE8D0", VA = "0x1869EFED0")]
	public static Dictionary<string, CPFMMOODPIE> CDBPLKIBBLD(Type ONAHEPMMCHP, ACOOFFCIGGP MKDEDBNKLGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x69F04F0", Offset = "0x69EEEF0", VA = "0x1869F04F0")]
	public static Dictionary<int, string> PEENCEMNOBM(Dictionary<string, CPFMMOODPIE> KCGHNGOMAMI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public abstract class KFANFMGGLGP
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static bool NHDAEOKICEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly string? GAGGJBBCEJG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public virtual KFANFMGGLGP? HNKNAHALNAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x72B5A0", Offset = "0x729FA0", VA = "0x18072B5A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x69F0DB0", Offset = "0x69EF7B0", VA = "0x1869F0DB0")]
	protected KFANFMGGLGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract string GMMLNCMCCAJ();

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x69F08E0", Offset = "0x69EF2E0", VA = "0x1869F08E0", Slot = "6")]
	public virtual string BLBJLPOLPAM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x69F09C0", Offset = "0x69EF3C0", VA = "0x1869F09C0")]
	public void EDOHGNMMEBH(StringBuilder IHDOPDPCKJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x69F0960", Offset = "0x69EF360", VA = "0x1869F0960")]
	public void CAOIECPHFOO(StringBuilder IHDOPDPCKJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x69F0C90", Offset = "0x69EF690", VA = "0x1869F0C90")]
	public void PNDFOLPJBFN(StringBuilder IHDOPDPCKJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x69F07F0", Offset = "0x69EF1F0", VA = "0x1869F07F0")]
	public void AELEBNNIGOM(StringBuilder IHDOPDPCKJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x69F0BF0", Offset = "0x69EF5F0", VA = "0x1869F0BF0")]
	public static void NDJFKHGEHGP(StringBuilder IHDOPDPCKJA, string OECHCNGOMCE, string IDHHFABBFKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x9507B0", Offset = "0x94F1B0", VA = "0x1809507B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class JCJPHNCPMOC : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x69F0780", Offset = "0x69EF180", VA = "0x1869F0780")]
	public JCJPHNCPMOC(string BALNMHDNCIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class PIHBFGJOEBD<TErr> : JCJPHNCPMOC where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly TErr MPCELFDCBIE;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2606870", Offset = "0x2605270", VA = "0x182606870")]
	private PIHBFGJOEBD(in TErr LCPOHMIBKBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x26067A0", Offset = "0x26051A0", VA = "0x1826067A0")]
	public static global::PIHBFGJOEBD<TErr> GILBACJLDCL(in TErr LCPOHMIBKBM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface GBPBAFKAGPD<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	TOptions NDNOLKCBONM
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface NBANJOJNMDP
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	string PDOOHLLNOAP
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class HEPEDIGJPKD : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x69F0710", Offset = "0x69EF110", VA = "0x1869F0710")]
	public HEPEDIGJPKD(string BALNMHDNCIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class EEFNOAMMAJG<TOk> : HEPEDIGJPKD where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly TOk LLEMJKAJHEC;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x40551F0", Offset = "0x4053BF0", VA = "0x1840551F0")]
	private EEFNOAMMAJG(in TOk DAHFMBELKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x302A220", Offset = "0x3028C20", VA = "0x18302A220")]
	public static global::EEFNOAMMAJG<TOk> GILBACJLDCL(in TOk DAHFMBELKAJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct LFBADEDAHHF<TOk, TErr> : IEquatable<global::LFBADEDAHHF<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly EqualityComparer<TErr> AMJMOCOLEIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly TErr MPCELFDCBIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly TOk LLEMJKAJHEC;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool EDABOFCCCLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2A45C90", Offset = "0x2A44690", VA = "0x182A45C90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool GHGNCBEBBJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2A455D0", Offset = "0x2A43FD0", VA = "0x182A455D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2A46F50", Offset = "0x2A45950", VA = "0x182A46F50")]
	internal LFBADEDAHHF(in TErr LCPOHMIBKBM, in TOk DAHFMBELKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2A43E90", Offset = "0x2A42890", VA = "0x182A43E90")]
	public static global::LFBADEDAHHF<TOk, TErr> DNENEOPIPCO(in TErr LCPOHMIBKBM)
	{
		return default(global::LFBADEDAHHF<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2A45710", Offset = "0x2A44110", VA = "0x182A45710")]
	public static global::LFBADEDAHHF<TOk, TErr> LGLJIAKCIMO(in TOk DAHFMBELKAJ)
	{
		return default(global::LFBADEDAHHF<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x394D060", Offset = "0x394BA60", VA = "0x18394D060")]
	public global::LFBADEDAHHF<UOk?, TErr?> GFGACMODJPA<UOk>()
	{
		return default(global::LFBADEDAHHF<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x394D3D0", Offset = "0x394BDD0", VA = "0x18394D3D0")]
	public global::LFBADEDAHHF<UOk?, TErr?> OPPJDIEJDJO<UOk>()
	{
		return default(global::LFBADEDAHHF<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x394CD20", Offset = "0x394B720", VA = "0x18394CD20")]
	public global::LFBADEDAHHF<TOk?, UErr?> DCMPGOMBHAH<UErr>()
	{
		return default(global::LFBADEDAHHF<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2A42E00", Offset = "0x2A41800", VA = "0x182A42E00")]
	public global::LFBADEDAHHF<JAPIHNFIDBB, TErr> AAFADGNPBNE()
	{
		return default(global::LFBADEDAHHF<JAPIHNFIDBB, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2A43090", Offset = "0x2A41A90", VA = "0x182A43090")]
	public static bool BOBJELOEACN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DC140", Offset = "0x6DB540")] in global::LFBADEDAHHF<TOk, TErr> LJLKLAFAGNO, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DC1B0", Offset = "0x6DB5B0")] in global::LFBADEDAHHF<TOk, TErr> HFBAHIGFPIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2A43F60", Offset = "0x2A42960", VA = "0x182A43F60", Slot = "4")]
	public bool Equals([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DC220", Offset = "0x6DB620")] global::LFBADEDAHHF<TOk, TErr> MPHACEGLFIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2A44650", Offset = "0x2A43050", VA = "0x182A44650", Slot = "0")]
	public override bool Equals(object MPHACEGLFIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2A450C0", Offset = "0x2A43AC0", VA = "0x182A450C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2A46B90", Offset = "0x2A45590", VA = "0x182A46B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class OKNMMNECALM
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x328E6F0", Offset = "0x328D0F0", VA = "0x18328E6F0")]
	public static global::LFBADEDAHHF<TOk?, TErr?> LLEMJKAJHEC<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DC2C0", Offset = "0x6DB6C0")] this in global::LFBADEDAHHF<TOk?, TErr?> INHKNJBCCPD, in TOk DAHFMBELKAJ)
	{
		return default(global::LFBADEDAHHF<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x328E760", Offset = "0x328D160", VA = "0x18328E760")]
	public static global::LFBADEDAHHF<JAPIHNFIDBB, TErr?> LLEMJKAJHEC<TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DC360", Offset = "0x6DB760")] this in global::LFBADEDAHHF<JAPIHNFIDBB, TErr?> INHKNJBCCPD)
	{
		return default(global::LFBADEDAHHF<JAPIHNFIDBB, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x328E720", Offset = "0x328D120", VA = "0x18328E720")]
	public static global::LFBADEDAHHF<TOk?, TErr?> MPCELFDCBIE<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DC3D0", Offset = "0x6DB7D0")] this in global::LFBADEDAHHF<TOk?, TErr?> INHKNJBCCPD, in TErr LCPOHMIBKBM)
	{
		return default(global::LFBADEDAHHF<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x328E8A0", Offset = "0x328D2A0", VA = "0x18328E8A0")]
	public static TOk? MJHHCGBONLP<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DC470", Offset = "0x6DB870")] this in global::LFBADEDAHHF<TOk?, TErr?> INHKNJBCCPD)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x328DA80", Offset = "0x328C480", VA = "0x18328DA80")]
	public static TErr? DIHFOECBEFC<TErr, TOk>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DC4E0", Offset = "0x6DB8E0")] this in global::LFBADEDAHHF<TOk?, TErr?> INHKNJBCCPD)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x328F090", Offset = "0x328DA90", VA = "0x18328F090")]
	public static bool PJHIHKOLEHA<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DC550", Offset = "0x6DB950")] this in global::LFBADEDAHHF<TOk?, TErr?> INHKNJBCCPD, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DC5C0", Offset = "0x6DB9C0")] out global::LFBADEDAHHF<TOk?, TErr?> ODCDKLCLFMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x328DFA0", Offset = "0x328C9A0", VA = "0x18328DFA0")]
	public static bool GDKAAPPNNPL<TOk, TErr, UErr, UOk>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DC620", Offset = "0x6DBA20")] this in global::LFBADEDAHHF<TOk?, TErr?> INHKNJBCCPD, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DC690", Offset = "0x6DBA90")] out global::LFBADEDAHHF<UOk?, UErr?> ODCDKLCLFMF) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x328DD20", Offset = "0x328C720", VA = "0x18328DD20")]
	public static bool FKIGOGBGJOF<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DC6F0", Offset = "0x6DBAF0")] this in global::LFBADEDAHHF<TOk?, TErr?> INHKNJBCCPD, [MNKKOBAPPBG(true)] out TOk DAHFMBELKAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x328DA00", Offset = "0x328C400", VA = "0x18328DA00")]
	public static bool BNIGFFHLNNL<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DC7A0", Offset = "0x6DBBA0")] this in global::LFBADEDAHHF<TOk?, TErr?> INHKNJBCCPD, [MNKKOBAPPBG(true)] out TErr LCPOHMIBKBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x328DC80", Offset = "0x328C680", VA = "0x18328DC80")]
	public static bool FDCHGFGHFNJ<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DC850", Offset = "0x6DBC50")] this in global::LFBADEDAHHF<TOk, TErr> INHKNJBCCPD, [MNKKOBAPPBG(true)] out TOk DAHFMBELKAJ, [MNKKOBAPPBG(false)] out TErr LCPOHMIBKBM) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x328F0D0", Offset = "0x328DAD0", VA = "0x18328F0D0")]
	public static bool PJHIHKOLEHA<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DC8C0", Offset = "0x6DBCC0")] this in global::LFBADEDAHHF<TOk?, TErr?> INHKNJBCCPD, [MNKKOBAPPBG(true)] out TOk DAHFMBELKAJ, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DC930", Offset = "0x6DBD30")] out global::LFBADEDAHHF<TOk?, TErr?> ODCDKLCLFMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x328DD60", Offset = "0x328C760", VA = "0x18328DD60")]
	public static bool GDKAAPPNNPL<TOk, TErr, UErr, UOk>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DC990", Offset = "0x6DBD90")] this in global::LFBADEDAHHF<TOk?, TErr?> INHKNJBCCPD, [MNKKOBAPPBG(true)] out TOk DAHFMBELKAJ, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DCA00", Offset = "0x6DBE00")] out global::LFBADEDAHHF<UOk?, UErr?> ODCDKLCLFMF) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x328EDD0", Offset = "0x328D7D0", VA = "0x18328EDD0")]
	public static bool NLJKHNJBIPM<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DCA60", Offset = "0x6DBE60")] this in global::LFBADEDAHHF<TOk?, TErr?> INHKNJBCCPD, [MNKKOBAPPBG(true)] out TOk DAHFMBELKAJ, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DCAD0", Offset = "0x6DBED0")] out global::LFBADEDAHHF<JAPIHNFIDBB, TErr?> ODCDKLCLFMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x328F390", Offset = "0x328DD90", VA = "0x18328F390")]
	public static global::LFBADEDAHHF<UOk, UErr> PLHOHGHAJKG<UOk, UErr, TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DCB30", Offset = "0x6DBF30")] this in global::LFBADEDAHHF<TOk, TErr> INHKNJBCCPD, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DCBA0", Offset = "0x6DBFA0")] in global::LFBADEDAHHF<UOk, UErr> PJEHHDIBMKL) where TOk : UOk where TErr : UErr
	{
		return default(global::LFBADEDAHHF<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x328E910", Offset = "0x328D310", VA = "0x18328E910")]
	public static global::LFBADEDAHHF<TOk?[]?, TErr?> NFNCJFHGINO<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DCC10", Offset = "0x6DC010")] this IEnumerable<global::LFBADEDAHHF<TOk?, TErr?>>? INHKNJBCCPD)
	{
		return default(global::LFBADEDAHHF<TOk[], TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x1C789B0", Offset = "0x1C773B0", VA = "0x181C789B0")]
	[IteratorStateMachine(typeof(BKABNHENIBH))]
	public static IEnumerable<TOk?>? GEFMILAOMHN<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DCCE0", Offset = "0x6DC0E0")] this IEnumerable<global::LFBADEDAHHF<TOk?, TErr?>>? INHKNJBCCPD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class BLGOIPNLKAC<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x25EE470", Offset = "0x25ECE70", VA = "0x1825EE470")]
	public static global::LFBADEDAHHF<TOk, T> LLEMJKAJHEC<TOk>(in TOk DAHFMBELKAJ) where TOk : notnull
	{
		return default(global::LFBADEDAHHF<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x25A6B80", Offset = "0x25A5580", VA = "0x1825A6B80")]
	public static global::LFBADEDAHHF<JAPIHNFIDBB, T> LLEMJKAJHEC()
	{
		return default(global::LFBADEDAHHF<JAPIHNFIDBB, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x25EE530", Offset = "0x25ECF30", VA = "0x1825EE530")]
	public static global::LFBADEDAHHF<T, TErr> MPCELFDCBIE<TErr>(in TErr LCPOHMIBKBM) where TErr : notnull
	{
		return default(global::LFBADEDAHHF<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[DefaultMember("Item")]
public sealed class AJCGCEFGDHE<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private readonly struct GCEJHNAFDBM : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly global::AJCGCEFGDHE<T> OGFCGJHPMJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly int KGBJNHCAIPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool NLKHPENODEB;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x32E6A30", Offset = "0x32E5430", VA = "0x1832E6A30")]
		public GCEJHNAFDBM(global::AJCGCEFGDHE<T> NLKDOMNEDBE, int DOBBJOIAKFM, bool LHHCABEHHNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x32E6900", Offset = "0x32E5300", VA = "0x1832E6900")]
		public global::AJCGCEFGDHE<T>.OABBNCFGOBI OKFDNCHLPHK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x32E69F0", Offset = "0x32E53F0", VA = "0x1832E69F0", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x32E69F0", Offset = "0x32E53F0", VA = "0x1832E69F0", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public sealed class OABBNCFGOBI : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly global::AJCGCEFGDHE<T> OGFCGJHPMJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly int KEFCNKDFGOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int CMCKDKHKFAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly bool NLKHPENODEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private bool MCNADHLKJEG;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public T IFFLDLNKLFF
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x2D18750", Offset = "0x2D17150", VA = "0x182D18750")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x2D18920", Offset = "0x2D17320", VA = "0x182D18920", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x2D18AD0", Offset = "0x2D174D0", VA = "0x182D18AD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2D18BC0", Offset = "0x2D175C0", VA = "0x182D18BC0")]
		public OABBNCFGOBI(global::AJCGCEFGDHE<T> NLKDOMNEDBE, int DOBBJOIAKFM, bool LHHCABEHHNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2D187A0", Offset = "0x2D171A0", VA = "0x182D187A0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2D18820", Offset = "0x2D17220", VA = "0x182D18820", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class IANBJFGMNDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DCDF0", Offset = "0x6DC1F0")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x13760C0", Offset = "0x1374AC0", VA = "0x1813760C0")]
		public IANBJFGMNDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2FF49A0", Offset = "0x2FF33A0", VA = "0x182FF49A0")]
		internal T <.ctor>b__0(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly T[] LJLFICLCEDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private int CMCKDKHKFAE;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int ACBICPOGOIO
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x360FEA0", Offset = "0x360E8A0", VA = "0x18360FEA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public T IFFLDLNKLFF
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x29E10A0", Offset = "0x29DFAA0", VA = "0x1829E10A0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T BPAJEMADNLI
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x360FBF0", Offset = "0x360E5F0", VA = "0x18360FBF0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public T JNKMHBEEDBP
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x360FD40", Offset = "0x360E740", VA = "0x18360FD40")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int JJINKJIBOKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8CED20", Offset = "0x8CD720", VA = "0x1808CED20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x360FDD0", Offset = "0x360E7D0", VA = "0x18360FDD0")]
	private static int DJHLMKBGKHN(int EGNHJGKABLC, int OEMPOIHBNFL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x36100B0", Offset = "0x360EAB0", VA = "0x1836100B0")]
	public AJCGCEFGDHE(int GBNBGNMHGLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x360FF60", Offset = "0x360E960", VA = "0x18360FF60")]
	public AJCGCEFGDHE(int GBNBGNMHGLO, Func<T> DGKINJNHIJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x36102E0", Offset = "0x360ECE0", VA = "0x1836102E0")]
	public AJCGCEFGDHE(T[] AABKFFENABM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x360FDA0", Offset = "0x360E7A0", VA = "0x18360FDA0")]
	public void DFJNLNPIOKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x360FDF0", Offset = "0x360E7F0", VA = "0x18360FDF0")]
	public IEnumerable<T> EGGHGPAIJEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x360FEE0", Offset = "0x360E8E0", VA = "0x18360FEE0")]
	public global::AJCGCEFGDHE<T>.OABBNCFGOBI OKFDNCHLPHK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1AA7500", Offset = "0x1AA5F00", VA = "0x181AA7500", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1AA7500", Offset = "0x1AA5F00", VA = "0x181AA7500", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class LBPNKBLFEOA
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x24C1510", Offset = "0x24BFF10", VA = "0x1824C1510")]
	public static global::AJCGCEFGDHE<T> GILBACJLDCL<T>(int GBNBGNMHGLO, Func<T> DGKINJNHIJP) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public sealed class JLPHKECNIFM<TData> : KFANFMGGLGP where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string KKGDNEGJOJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly TData CNDFKFGJPCE;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "5")]
	public override string GMMLNCMCCAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3335310", Offset = "0x3333D10", VA = "0x183335310")]
	internal JLPHKECNIFM(string BALNMHDNCIN, in TData HIDEHJGLNHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class GDGDFDJMCLF
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x69F06A0", Offset = "0x69EF0A0", VA = "0x1869F06A0")]
	public static global::JLPHKECNIFM<JAPIHNFIDBB> GILBACJLDCL(string BALNMHDNCIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x10F6530", Offset = "0x10F4F30", VA = "0x1810F6530")]
	public static global::JLPHKECNIFM<TData> GILBACJLDCL<TData>(string BALNMHDNCIN, in TData HIDEHJGLNHO) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class PMNIAEBNKPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly Dictionary<object, float> GDCEFHMGFFB;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public float EEEEJNHDKDK
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xE61050", Offset = "0xE5FA50", VA = "0x180E61050")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xE60F10", Offset = "0xE5F910", VA = "0x180E60F10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x69F0F60", Offset = "0x69EF960", VA = "0x1869F0F60")]
	public void CJNLKFPNHDF(float LPJDDLMPNCG, object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x69F10F0", Offset = "0x69EFAF0", VA = "0x1869F10F0")]
	public void PBFPIEEMKFJ(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x69F0FD0", Offset = "0x69EF9D0", VA = "0x1869F0FD0")]
	private void CMKKCBILMJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x69F1160", Offset = "0x69EFB60", VA = "0x1869F1160")]
	public PMNIAEBNKPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public sealed class BHECNCBBLMC
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class OGJIAOHJIBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public OGJIAOHJIBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x69F0EB0", Offset = "0x69EF8B0", VA = "0x1869F0EB0")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DCE50", Offset = "0x6DC250")]
	private HashSet<object> EFOCNJAEIPA;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyCollection<object> OPBNFDMBOBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x69EFAC0", Offset = "0x69EE4C0", VA = "0x1869EFAC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool MJNHCKEGDDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x69EFC30", Offset = "0x69EE630", VA = "0x1869EFC30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int JAMIBFCLJNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x77AFB0", Offset = "0x7799B0", VA = "0x18077AFB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7B4F70", Offset = "0x7B3970", VA = "0x1807B4F70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x69EF9D0", Offset = "0x69EE3D0", VA = "0x1869EF9D0")]
	public bool AGMLDLCGDGN(object MIFCLBEAOPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x69EFB90", Offset = "0x69EE590", VA = "0x1869EFB90")]
	public bool FJEBMLODAAK(object MIFCLBEAOPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x69EFC40", Offset = "0x69EE640", VA = "0x1869EFC40")]
	public bool GMBMHDKFMPB(object MIFCLBEAOPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x69EFCA0", Offset = "0x69EE6A0", VA = "0x1869EFCA0")]
	public void OKDDGLLANON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x69EFD10", Offset = "0x69EE710", VA = "0x1869EFD10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public BHECNCBBLMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class NFFFIELCCID<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private struct FOBKEJBJPAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public float PKIGECIECGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public T NDNOLKCBONM;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DCEB0", Offset = "0x6DC2B0")]
	private readonly Dictionary<object, global::NFFFIELCCID<T>.FOBKEJBJPAG> GDCEFHMGFFB;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public virtual T GHFFBIHAFMI
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x11EC040", Offset = "0x11EAA40", VA = "0x1811EC040", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x16E5AF0", Offset = "0x16E44F0", VA = "0x1816E5AF0", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public object? FDCDOIPHEGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x727000", Offset = "0x725A00", VA = "0x180727000")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7A9630", Offset = "0x7A8030", VA = "0x1807A9630")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool HDDGJFGBFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x27B3A60", Offset = "0x27B2460", VA = "0x1827B3A60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x27B3630", Offset = "0x27B2030", VA = "0x1827B3630")]
	public bool CJNLKFPNHDF(T LPJDDLMPNCG, object MIFCLBEAOPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x2243640", Offset = "0x2242040", VA = "0x182243640")]
	public bool PBFPIEEMKFJ(object MIFCLBEAOPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1AAE2A0", Offset = "0x1AACCA0", VA = "0x181AAE2A0")]
	public void BONIBAPHNIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x27B3860", Offset = "0x27B2260", VA = "0x1827B3860")]
	public bool DJKANKJNGBD(object MIFCLBEAOPM, out T LPJDDLMPNCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x27B3AA0", Offset = "0x27B24A0", VA = "0x1827B3AA0")]
	private bool KBFDGGDEHPE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x22436A0", Offset = "0x22420A0", VA = "0x1822436A0")]
	public NFFFIELCCID()
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
