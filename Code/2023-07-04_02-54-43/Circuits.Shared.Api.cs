using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
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
		[Cpp2IlInjected.Address(RVA = "0x956600", Offset = "0x954C00", VA = "0x180956600")]
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
		[Cpp2IlInjected.Address(RVA = "0x7258D60", Offset = "0x7257360", VA = "0x187258D60")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xBD9AB0", Offset = "0xBD80B0", VA = "0x180BD9AB0")]
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
		[Cpp2IlInjected.Address(RVA = "0xEA93B0", Offset = "0xEA79B0", VA = "0x180EA93B0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Circuits.Shared.Api
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public enum IOKind
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Input,
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		Output
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public readonly struct ODNOENCKPHK<M, T> where M : notnull where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly T[] AAOPLFDAILE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7490F0", Offset = "0x7484F0")]
	public JIONBOANMAG<M> OHMPHOIFEPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3699380", Offset = "0x3697980", VA = "0x183699380")]
		get
		{
			return default(JIONBOANMAG<M>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int DIDJDLOPKKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x218C780", Offset = "0x218AD80", VA = "0x18218C780")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public T KCHGKMPBAJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1226AB0", Offset = "0x12250B0", VA = "0x181226AB0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0xA7EC30", Offset = "0xA7D230", VA = "0x180A7EC30")]
	internal ODNOENCKPHK(T[] JHKFLJIAOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x36992F0", Offset = "0x36978F0", VA = "0x1836992F0")]
	public static ODNOENCKPHK<M, T> JBGFDEKBNPE(int CPHEGBCGAHF)
	{
		return default(ODNOENCKPHK<M, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x86D3F0", Offset = "0x86B9F0", VA = "0x18086D3F0")]
	public IEnumerable<T> GMJLEMCOHBK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3699280", Offset = "0x3697880", VA = "0x183699280")]
	public FMGPEJOACDM<M, T> BFMBOCEJBID()
	{
		return default(FMGPEJOACDM<M, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3699410", Offset = "0x3697A10", VA = "0x183699410")]
	public IEnumerator<T> PFBFKEIKCCB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3699490", Offset = "0x3697A90", VA = "0x183699490", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class PBBFLPAJLLB<M>
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x178DF20", Offset = "0x178C520", VA = "0x18178DF20")]
	public static ODNOENCKPHK<M, T> JNDAPEPKEAH<T>(params T[] JHKFLJIAOGC) where T : notnull
	{
		return default(ODNOENCKPHK<M, T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class IPEJDGKFCBN
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2169ED0", Offset = "0x21684D0", VA = "0x182169ED0")]
	public static T? HBPBGGLAJFB<T, M>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x749190", Offset = "0x748590")] this ref ODNOENCKPHK<M?, T?> PBJDHAKDMFG, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7491F0", Offset = "0x7485F0")] JIONBOANMAG<M?> JMCLMPHOKNG)
	{
		return (T?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2169F50", Offset = "0x2168550", VA = "0x182169F50")]
	public static void PCICHOODFHC<M, T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x749250", Offset = "0x748650")] this ref ODNOENCKPHK<M?, T?> PBJDHAKDMFG, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7492B0", Offset = "0x7486B0")] JIONBOANMAG<M?> JMCLMPHOKNG, in T FEBHELIDNED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface IKGONGCLBBI
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool PNJNBFIAKEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct IIPBFLKFCOP : IEquatable<IIPBFLKFCOP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly float IMCFEFBOFIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly float HBJLDKNCJEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly float HELFJCGOLKE;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public static readonly IIPBFLKFCOP EPFHIFCJHCD;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly IIPBFLKFCOP BGNNPAADIKM;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly IIPBFLKFCOP LBCFLCDKBDC;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly IIPBFLKFCOP HHLBIHHPPHL;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly IIPBFLKFCOP MBEEIICDNGC;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly IIPBFLKFCOP DPGECEODHOD;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly IIPBFLKFCOP DICPJBBLLOL;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public static readonly IIPBFLKFCOP CHFNOOJFHEP;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly IIPBFLKFCOP MCMOANPAOMP;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public static readonly IIPBFLKFCOP MCJJBONCDID;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly IIPBFLKFCOP GFJADNHHOJP;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public static readonly IIPBFLKFCOP OJCCGGHAJOB;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static readonly IIPBFLKFCOP IJAPKLKIELO;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static readonly IIPBFLKFCOP HFKKFPGKELC;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static readonly IIPBFLKFCOP NANDCDGFMNL;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static readonly IIPBFLKFCOP OGNDNLKGBAO;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly IIPBFLKFCOP GBPOFEOJIFO;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5CBCB80", Offset = "0x5CBB180", VA = "0x185CBCB80")]
	public IIPBFLKFCOP(float HMINFBNCMPL, float MPEHLADJKCP, float ACNOJPMJGJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7258240", Offset = "0x7256840", VA = "0x187258240")]
	public static IIPBFLKFCOP JBGFDEKBNPE(float HMINFBNCMPL, float MPEHLADJKCP, float ACNOJPMJGJM)
	{
		return default(IIPBFLKFCOP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x72582F0", Offset = "0x72568F0", VA = "0x1872582F0")]
	public static bool MOJFGPLDDKP(in IIPBFLKFCOP NNCBKOEDDGO, in IIPBFLKFCOP IHJFFGMGNME)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7258260", Offset = "0x7256860", VA = "0x187258260")]
	public static bool LFBHPMALHHK(in IIPBFLKFCOP NNCBKOEDDGO, in IIPBFLKFCOP IHJFFGMGNME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x72581D0", Offset = "0x72567D0", VA = "0x1872581D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7258060", Offset = "0x7256660", VA = "0x187258060", Slot = "0")]
	public override bool Equals(object IAMEECMGPIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7258320", Offset = "0x7256920", VA = "0x187258320", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7258140", Offset = "0x7256740", VA = "0x187258140", Slot = "4")]
	public bool Equals(IIPBFLKFCOP EJECOGCICOM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[Obsolete]
[DefaultMember("Item")]
public ref struct AAMANPEBAJK<M, T> where M : notnull where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7493D0", Offset = "0x7487D0")]
	private readonly ReadOnlySpan<T> BCKFEJFHGHM;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public readonly T KCHGKMPBAJO
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x26CAA10", Offset = "0x26C9010", VA = "0x1826CAA10")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1FF7970", Offset = "0x1FF5F70", VA = "0x181FF7970")]
	internal AAMANPEBAJK([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x749490", Offset = "0x748890")] in ReadOnlySpan<T> LIMDABELPHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x26CAA60", Offset = "0x26C9060", VA = "0x1826CAA60", Slot = "3")]
	public override readonly string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class IMKEHOPMNNH<M>
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x1998330", Offset = "0x1996930", VA = "0x181998330")]
	public static AAMANPEBAJK<M?, T?> NHJMAALFDDO<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x749540", Offset = "0x748940")] in ReadOnlySpan<T?> LIMDABELPHG)
	{
		return default(AAMANPEBAJK<M, T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct EHEPBCAELPC : IEquatable<EHEPBCAELPC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly EAKIHAGBMPE KGLMEMCFDJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly IIPBFLKFCOP KJOIPLLFLNL;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly EHEPBCAELPC DELPDCGKMAM;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7258040", Offset = "0x7256640", VA = "0x187258040")]
	public EHEPBCAELPC(in EAKIHAGBMPE HOHKOHLHECA, in IIPBFLKFCOP FADCMIMHMJH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7257DE0", Offset = "0x72563E0", VA = "0x187257DE0")]
	public static bool MOJFGPLDDKP(in EHEPBCAELPC NNCBKOEDDGO, in EHEPBCAELPC IHJFFGMGNME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7257D50", Offset = "0x7256350", VA = "0x187257D50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7257C10", Offset = "0x7256210", VA = "0x187257C10", Slot = "0")]
	public override bool Equals(object IAMEECMGPIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7257ED0", Offset = "0x72564D0", VA = "0x187257ED0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7257CE0", Offset = "0x72562E0", VA = "0x187257CE0", Slot = "4")]
	public bool Equals(EHEPBCAELPC EJECOGCICOM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct FCJOOHCAJGA<M, T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7495F0", Offset = "0x7489F0")]
	private readonly ReadOnlyMemory<T?> HHKFMNKOJDO;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x1FF7990", Offset = "0x1FF5F90", VA = "0x181FF7990")]
	internal FCJOOHCAJGA([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x749650", Offset = "0x748A50")] in ReadOnlyMemory<T?> IJGLPJMOMFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x21E5DB0", Offset = "0x21E43B0", VA = "0x1821E5DB0")]
	public AAMANPEBAJK<M?, T?> CPPEJHDCJOI()
	{
		return default(AAMANPEBAJK<M, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x21E5F70", Offset = "0x21E4570", VA = "0x1821E5F70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class EDLKEGJLIIG<M>
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x199A180", Offset = "0x1998780", VA = "0x18199A180")]
	public static FCJOOHCAJGA<M?, T?> FLIGFPNMNEH<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7496C0", Offset = "0x748AC0")] in ReadOnlyMemory<T?> IJGLPJMOMFO)
	{
		return default(FCJOOHCAJGA<M, T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct JIONBOANMAG<TMarker> : IEquatable<JIONBOANMAG<TMarker>>, IKGEBLJKMLJ<JIONBOANMAG<TMarker>>, IComparable<JIONBOANMAG<TMarker>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly int DIINHKKGHOP;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x749A50", Offset = "0x748E50")]
	public JIONBOANMAG<TMarker> LAKAHLBPAGP
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x372D7A0", Offset = "0x372BDA0", VA = "0x18372D7A0")]
		get
		{
			return default(JIONBOANMAG<TMarker>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x749AB0", Offset = "0x748EB0")]
	public JIONBOANMAG<TMarker> BFADOJOCBMK
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x372D6A0", Offset = "0x372BCA0", VA = "0x18372D6A0")]
		get
		{
			return default(JIONBOANMAG<TMarker>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0xA47570", Offset = "0xA45B70", VA = "0x180A47570")]
	public JIONBOANMAG(int FEBHELIDNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1999780", Offset = "0x1997D80", VA = "0x181999780")]
	public JIONBOANMAG<TOther> GMFCCGLEIJP<TOther>() where TOther : TMarker
	{
		return default(JIONBOANMAG<TOther>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x372D660", Offset = "0x372BC60", VA = "0x18372D660")]
	public bool FNAMDMFDIAO([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x749730", Offset = "0x748B30")] in JIONBOANMAG<TMarker> EJECOGCICOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x372D610", Offset = "0x372BC10", VA = "0x18372D610", Slot = "4")]
	public bool Equals([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7497A0", Offset = "0x748BA0")] JIONBOANMAG<TMarker> EJECOGCICOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2E77320", Offset = "0x2E75920", VA = "0x182E77320", Slot = "0")]
	public override bool Equals(object EJECOGCICOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x372D5F0", Offset = "0x372BBF0", VA = "0x18372D5F0", Slot = "6")]
	public int CompareTo([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x749800", Offset = "0x748C00")] JIONBOANMAG<TMarker> EJECOGCICOM)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x372D760", Offset = "0x372BD60", VA = "0x18372D760")]
	public static bool MOJFGPLDDKP([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x749860", Offset = "0x748C60")] JIONBOANMAG<TMarker> CNCLMHODMJG, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7498C0", Offset = "0x748CC0")] JIONBOANMAG<TMarker> ECNLMNDOGCG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x372D710", Offset = "0x372BD10", VA = "0x18372D710")]
	public static bool LFBHPMALHHK([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x749920", Offset = "0x748D20")] JIONBOANMAG<TMarker> CNCLMHODMJG, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x749980", Offset = "0x748D80")] JIONBOANMAG<TMarker> ECNLMNDOGCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x372D680", Offset = "0x372BC80", VA = "0x18372D680", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x372D810", Offset = "0x372BE10", VA = "0x18372D810", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x372D5A0", Offset = "0x372BBA0", VA = "0x18372D5A0", Slot = "5")]
	private bool ADKOAEFOFBF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7499E0", Offset = "0x748DE0")] in JIONBOANMAG<TMarker> EJECOGCICOM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class HGEEECFCPNA
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2AD4920", Offset = "0x2AD2F20", VA = "0x182AD4920")]
	public static JIONBOANMAG<TMarker?> ELKBLLNEFGD<TMarker>(this int PBJDHAKDMFG)
	{
		return default(JIONBOANMAG<TMarker>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2AD4920", Offset = "0x2AD2F20", VA = "0x182AD4920")]
	public static JIONBOANMAG<TMarker?> EBOKKHDIEAG<TMarker>(this int PBJDHAKDMFG)
	{
		return default(JIONBOANMAG<TMarker>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x16AA960", Offset = "0x16A8F60", VA = "0x1816AA960")]
	public static IMEGHFBKMIM<JIONBOANMAG<TMarker?>, BNDMABLAFLA<TMarker?>> MNIJKAIFGKE<TMarker>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x749B50", Offset = "0x748F50")] JIONBOANMAG<TMarker?> KPIAPMPLEFA, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x749BB0", Offset = "0x748FB0")] JIONBOANMAG<TMarker?> EOGHIGLGGDA)
	{
		return default(IMEGHFBKMIM<JIONBOANMAG<TMarker>, BNDMABLAFLA<TMarker>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2AD4950", Offset = "0x2AD2F50", VA = "0x182AD4950")]
	public static IMEGHFBKMIM<JIONBOANMAG<TMarker?>, BNDMABLAFLA<TMarker?>> KGJNMEDGMFL<TMarker>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x749C10", Offset = "0x749010")] JIONBOANMAG<TMarker?> EOGHIGLGGDA)
	{
		return default(IMEGHFBKMIM<JIONBOANMAG<TMarker>, BNDMABLAFLA<TMarker>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class BPGNKHDGFPG<TOther>
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2D30820", Offset = "0x2D2EE20", VA = "0x182D30820")]
	public static JIONBOANMAG<TOther> MDBAAICMCDM<TMarker>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x749C70", Offset = "0x749070")] JIONBOANMAG<TMarker> PBJDHAKDMFG) where TMarker : TOther
	{
		return default(JIONBOANMAG<TOther>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface BEEGKCCCFIM
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	IKGONGCLBBI EINLNAEHONJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class EPLGCFIELPI
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2933FE0", Offset = "0x29325E0", VA = "0x182933FE0")]
	public static bool IBOJDIHFBIF<TSelf>(this TSelf PBJDHAKDMFG) where TSelf : notnull, BEEGKCCCFIM
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct BNDMABLAFLA<M> : IEnumerator<JIONBOANMAG<M>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly int AOJINJHNJPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly int JPHKJBGCIDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private int KMBBOGLMMCP;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x749CD0", Offset = "0x7490D0")]
	public readonly JIONBOANMAG<M> PGNBHIOAFDF
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x212F3A0", Offset = "0x212D9A0", VA = "0x18212F3A0", Slot = "4")]
		get
		{
			return default(JIONBOANMAG<M>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x212F2C0", Offset = "0x212D8C0", VA = "0x18212F2C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x18427A0", Offset = "0x1840DA0", VA = "0x1818427A0")]
	internal BNDMABLAFLA(int ADJMNNDGLPN, int EOGHIGLGGDA, int OAECKONFJNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
	public readonly void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x212F2A0", Offset = "0x212D8A0", VA = "0x18212F2A0", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x212F2B0", Offset = "0x212D8B0", VA = "0x18212F2B0", Slot = "8")]
	public void Reset()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class KFKBEMNOOBB
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x529CBC0", Offset = "0x529B1C0", VA = "0x18529CBC0")]
	public static BNDMABLAFLA<M?> JBGFDEKBNPE<M>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x749D50", Offset = "0x749150")] JIONBOANMAG<M?> KPIAPMPLEFA, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x749DB0", Offset = "0x7491B0")] JIONBOANMAG<M?> EOGHIGLGGDA)
	{
		return default(BNDMABLAFLA<M>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x529CB40", Offset = "0x529B140", VA = "0x18529CB40")]
	public static IMEGHFBKMIM<JIONBOANMAG<M?>, BNDMABLAFLA<M?>> GIDCMAFKMOI<M>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x749E10", Offset = "0x749210")] JIONBOANMAG<M?> KPIAPMPLEFA, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x749E70", Offset = "0x749270")] JIONBOANMAG<M?> EOGHIGLGGDA)
	{
		return default(IMEGHFBKMIM<JIONBOANMAG<M>, BNDMABLAFLA<M>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct AGGHFJDFIID<M> : IEnumerator<JIONBOANMAG<M>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly int ICGIJGAKGGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private int KMBBOGLMMCP;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x749ED0", Offset = "0x7492D0")]
	public readonly JIONBOANMAG<M> PGNBHIOAFDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x28ED850", Offset = "0x28EBE50", VA = "0x1828ED850", Slot = "4")]
		get
		{
			return default(JIONBOANMAG<M>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x28ED7C0", Offset = "0x28EBDC0", VA = "0x1828ED7C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0xA2D850", Offset = "0xA2BE50", VA = "0x180A2D850")]
	private AGGHFJDFIID(int EGIKAKGFKPB, int OAECKONFJNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x28ED770", Offset = "0x28EBD70", VA = "0x1828ED770")]
	public static AGGHFJDFIID<M> GICKKPJEKAP(int EGIKAKGFKPB)
	{
		return default(AGGHFJDFIID<M>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x28ED7A0", Offset = "0x28EBDA0", VA = "0x1828ED7A0", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x28ED7B0", Offset = "0x28EBDB0", VA = "0x1828ED7B0", Slot = "8")]
	public void Reset()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class NEMGPOONLMN
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7258A30", Offset = "0x7257030", VA = "0x187258A30")]
	public static LOOJOBDLCOE DHDFEGACAHE(this in IIPBFLKFCOP PBJDHAKDMFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7258AC0", Offset = "0x72570C0", VA = "0x187258AC0")]
	public static IIPBFLKFCOP EMHFJGFFMPB(this LOOJOBDLCOE PBJDHAKDMFG)
	{
		return default(IIPBFLKFCOP);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7258C80", Offset = "0x7257280", VA = "0x187258C80")]
	public static LOOJOBDLCOE? IOANJBJHIJD(this in IIPBFLKFCOP? PBJDHAKDMFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7258B80", Offset = "0x7257180", VA = "0x187258B80")]
	public static IIPBFLKFCOP? ENBLGJCDAHO(this LOOJOBDLCOE? PBJDHAKDMFG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct JPOCEKCOFNM<TMarker> : IEquatable<JPOCEKCOFNM<TMarker>>, IKGEBLJKMLJ<JPOCEKCOFNM<TMarker>>, IComparable<JPOCEKCOFNM<TMarker>> where TMarker : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly Guid OKGCCGOJENK;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x74A310", Offset = "0x749710")]
	public static JPOCEKCOFNM<TMarker> JKPLIBNKDEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2E77450", Offset = "0x2E75A50", VA = "0x182E77450")]
		get
		{
			return default(JPOCEKCOFNM<TMarker>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x74A380", Offset = "0x749780")]
	public static JPOCEKCOFNM<TMarker>? OLFLDHDLDBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2E77060", Offset = "0x2E75660", VA = "0x182E77060")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1B3F6A0", Offset = "0x1B3DCA0", VA = "0x181B3F6A0")]
	public JPOCEKCOFNM(in Guid FEBHELIDNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2E771E0", Offset = "0x2E757E0", VA = "0x182E771E0")]
	public PDLFBEHNBOE? DHDFEGACAHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2E773A0", Offset = "0x2E759A0", VA = "0x182E773A0")]
	public bool FNAMDMFDIAO([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x749FB0", Offset = "0x7493B0")] in JPOCEKCOFNM<TMarker> EJECOGCICOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2E77160", Offset = "0x2E75760", VA = "0x182E77160", Slot = "4")]
	public bool Equals([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x74A020", Offset = "0x749420")] JPOCEKCOFNM<TMarker> EJECOGCICOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2E77320", Offset = "0x2E75920", VA = "0x182E77320", Slot = "0")]
	public override bool Equals(object EJECOGCICOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2E771B0", Offset = "0x2E757B0", VA = "0x182E771B0", Slot = "6")]
	public int CompareTo([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x74A080", Offset = "0x749480")] JPOCEKCOFNM<TMarker> EJECOGCICOM)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2E77160", Offset = "0x2E75760", VA = "0x182E77160")]
	public static bool MOJFGPLDDKP([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x74A0E0", Offset = "0x7494E0")] in JPOCEKCOFNM<TMarker> CNCLMHODMJG, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x74A150", Offset = "0x749550")] in JPOCEKCOFNM<TMarker> ECNLMNDOGCG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2E773F0", Offset = "0x2E759F0", VA = "0x182E773F0")]
	public static bool LFBHPMALHHK([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x74A1C0", Offset = "0x7495C0")] in JPOCEKCOFNM<TMarker> CNCLMHODMJG, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x74A230", Offset = "0x749630")] in JPOCEKCOFNM<TMarker> ECNLMNDOGCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2E773D0", Offset = "0x2E759D0", VA = "0x182E773D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2E77550", Offset = "0x2E75B50", VA = "0x182E77550", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2E77160", Offset = "0x2E75760", VA = "0x182E77160", Slot = "5")]
	private bool CNOHNJFADBM([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x74A2A0", Offset = "0x7496A0")] in JPOCEKCOFNM<TMarker> EJECOGCICOM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class GACIOPADIDA
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1B74C80", Offset = "0x1B73280", VA = "0x181B74C80")]
	public static JPOCEKCOFNM<TMarker?> EMHFJGFFMPB<TMarker>(this PDLFBEHNBOE? PBJDHAKDMFG)
	{
		return default(JPOCEKCOFNM<TMarker>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1B74C50", Offset = "0x1B73250", VA = "0x181B74C50")]
	public static JPOCEKCOFNM<TMarker?> ELKBLLNEFGD<TMarker>(this in Guid PBJDHAKDMFG)
	{
		return default(JPOCEKCOFNM<TMarker>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class FAMIADELBFE<TOther>
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x74A430", Offset = "0x749830")]
	internal static readonly JPOCEKCOFNM<TOther> JKPLIBNKDEM;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x74A490", Offset = "0x749890")]
	internal static readonly JPOCEKCOFNM<TOther>? OLFLDHDLDBM;
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[DefaultMember("Item")]
public readonly struct FMGPEJOACDM<M, T> where M : notnull where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x74A560", Offset = "0x749960")]
	private readonly BCFFEGHAMLG<T> AAOPLFDAILE;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x74A680", Offset = "0x749A80")]
	public JIONBOANMAG<M> OHMPHOIFEPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2B60520", Offset = "0x2B5EB20", VA = "0x182B60520")]
		get
		{
			return default(JIONBOANMAG<M>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int DIDJDLOPKKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2B604E0", Offset = "0x2B5EAE0", VA = "0x182B604E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public T KCHGKMPBAJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2B603F0", Offset = "0x2B5E9F0", VA = "0x182B603F0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2B60680", Offset = "0x2B5EC80", VA = "0x182B60680")]
	internal FMGPEJOACDM([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x74A620", Offset = "0x749A20")] BCFFEGHAMLG<T> JHKFLJIAOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1FF7920", Offset = "0x1FF5F20", VA = "0x181FF7920")]
	public IEnumerable<T> GMJLEMCOHBK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2B605E0", Offset = "0x2B5EBE0", VA = "0x182B605E0")]
	public IEnumerator<T> PFBFKEIKCCB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2B60620", Offset = "0x2B5EC20", VA = "0x182B60620", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class CIJFHBOPNBO<M>
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1A48E80", Offset = "0x1A47480", VA = "0x181A48E80")]
	public static FMGPEJOACDM<M, T> JNDAPEPKEAH<T>(params T[] JHKFLJIAOGC) where T : notnull
	{
		return default(FMGPEJOACDM<M, T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class MMIDPBIHHME
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7258660", Offset = "0x7256C60", VA = "0x187258660")]
	public static AELAONEHCOL DHDFEGACAHE(this in EAKIHAGBMPE PBJDHAKDMFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7258700", Offset = "0x7256D00", VA = "0x187258700")]
	public static EAKIHAGBMPE EMHFJGFFMPB(this AELAONEHCOL PBJDHAKDMFG)
	{
		return default(EAKIHAGBMPE);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7258940", Offset = "0x7256F40", VA = "0x187258940")]
	public static AELAONEHCOL? IOANJBJHIJD(this in EAKIHAGBMPE? PBJDHAKDMFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x72587F0", Offset = "0x7256DF0", VA = "0x1872587F0")]
	public static EAKIHAGBMPE? ENBLGJCDAHO(this AELAONEHCOL? PBJDHAKDMFG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public readonly struct EAKIHAGBMPE : IEquatable<EAKIHAGBMPE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly float IMCFEFBOFIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly float HBJLDKNCJEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly float HELFJCGOLKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly float LKFKOLEMMEB;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly EAKIHAGBMPE DELPDCGKMAM;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly EAKIHAGBMPE LBCFLCDKBDC;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public static readonly EAKIHAGBMPE HHLBIHHPPHL;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly EAKIHAGBMPE MBEEIICDNGC;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static readonly EAKIHAGBMPE DPGECEODHOD;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x209AEB0", Offset = "0x20994B0", VA = "0x18209AEB0")]
	public EAKIHAGBMPE(float HMINFBNCMPL, float MPEHLADJKCP, float ACNOJPMJGJM, float NPCNEKJOJLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7257850", Offset = "0x7255E50", VA = "0x187257850")]
	public static EAKIHAGBMPE JBGFDEKBNPE(float HMINFBNCMPL, float MPEHLADJKCP, float ACNOJPMJGJM, float NPCNEKJOJLD)
	{
		return default(EAKIHAGBMPE);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5CBE5D0", Offset = "0x5CBCBD0", VA = "0x185CBE5D0")]
	public static bool MOJFGPLDDKP(in EAKIHAGBMPE NNCBKOEDDGO, in EAKIHAGBMPE IHJFFGMGNME)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7257870", Offset = "0x7255E70", VA = "0x187257870")]
	public static bool LFBHPMALHHK(in EAKIHAGBMPE NNCBKOEDDGO, in EAKIHAGBMPE IHJFFGMGNME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x72577B0", Offset = "0x7255DB0", VA = "0x1872577B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7257630", Offset = "0x7255C30", VA = "0x187257630", Slot = "0")]
	public override bool Equals(object IAMEECMGPIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7257910", Offset = "0x7255F10", VA = "0x187257910", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7257710", Offset = "0x7255D10", VA = "0x187257710", Slot = "4")]
	public bool Equals(EAKIHAGBMPE EJECOGCICOM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct BOKDOGPLGPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly float BINDFMDKECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly float BPEBBEAOMCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly float CPEMHDHLPCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly float KEIEHKLODEJ;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly BOKDOGPLGPD HJBNFDEOPJE;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly BOKDOGPLGPD CKDOMBIECOB;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x209AEB0", Offset = "0x20994B0", VA = "0x18209AEB0")]
	public BOKDOGPLGPD(float MBLEGMGDGKI, float ONOKPFJGKAM, float LKIHFBEPDMH, float LLAFGJINMOA)
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
