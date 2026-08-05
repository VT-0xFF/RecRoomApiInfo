using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.NoEngine.DataStructures;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x78B4D0", Offset = "0x789CD0", VA = "0x18078B4D0")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x628C250", Offset = "0x628AA50", VA = "0x18628C250")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x78C320", Offset = "0x78AB20", VA = "0x18078C320")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x78C360", Offset = "0x78AB60", VA = "0x18078C360")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface KOBNJPMPAOE
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string NDMEHJLGNHG(LEBODCONKGF EJAHENBAJFL);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LEBODCONKGF GHFHHMFPNJI(string EJAHENBAJFL);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct LEBODCONKGF : IEquatable<LEBODCONKGF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly APNGBMOGDCM PPLCKHNDKGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly DCAOPGHJNHE DJKDBABOMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly Guid LNLEMCMMPDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly RRColor? IKCBOJLFMNG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool AJAAGDHIJIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x628BA60", Offset = "0x628A260", VA = "0x18628BA60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool JDAFLDEEGAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x628BC80", Offset = "0x628A480", VA = "0x18628BC80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x628C130", Offset = "0x628A930", VA = "0x18628C130")]
	public LEBODCONKGF(LEBODCONKGF BADGGOIPDCB, [Optional] Guid BCIEMHPBNPN, [Optional] RRColor? JFJPGCGPBNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x628C1C0", Offset = "0x628A9C0", VA = "0x18628C1C0")]
	public LEBODCONKGF(APNGBMOGDCM KLLDEIFEGHM, DCAOPGHJNHE GDFMOLMMGNK, [Optional] Guid BCIEMHPBNPN, [Optional] RRColor? JFJPGCGPBNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x628B870", Offset = "0x628A070", VA = "0x18628B870", Slot = "4")]
	public bool Equals(LEBODCONKGF GHNNCJBDHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x628B970", Offset = "0x628A170", VA = "0x18628B970", Slot = "0")]
	public override bool Equals(object ELOCHLKHPBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x628BB20", Offset = "0x628A320", VA = "0x18628BB20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x628BCC0", Offset = "0x628A4C0", VA = "0x18628BCC0")]
	public static bool PEFPHNLEPOM(LEBODCONKGF MANEBEMOKEE, LEBODCONKGF HOCFNIKGEJF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x628BC10", Offset = "0x628A410", VA = "0x18628BC10")]
	public static bool OONIEGCHHIB(LEBODCONKGF MANEBEMOKEE, LEBODCONKGF HOCFNIKGEJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x628BD30", Offset = "0x628A530", VA = "0x18628BD30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct APNGBMOGDCM : IEquatable<APNGBMOGDCM>, IComparable<APNGBMOGDCM>, MOHMBCOCGML
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly APNGBMOGDCM FNKJEGINCPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Guid ACBJLDAEBBN;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1C35600", Offset = "0x1C33E00", VA = "0x181C35600")]
	public APNGBMOGDCM(Guid ACBJLDAEBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0xA70080", Offset = "0xA6E880", VA = "0x180A70080", Slot = "6")]
	public Guid FOBIODEMAEL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3CBB090", Offset = "0x3CB9890", VA = "0x183CBB090", Slot = "4")]
	public bool Equals(APNGBMOGDCM GHNNCJBDHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3CBB0C0", Offset = "0x3CB98C0", VA = "0x183CBB0C0", Slot = "5")]
	public int CompareTo(APNGBMOGDCM GHNNCJBDHKF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x628A3F0", Offset = "0x6288BF0", VA = "0x18628A3F0", Slot = "0")]
	public override bool Equals(object ELOCHLKHPBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3CBB1C0", Offset = "0x3CB99C0", VA = "0x183CBB1C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3CBB090", Offset = "0x3CB9890", VA = "0x183CBB090")]
	public static bool PEFPHNLEPOM(APNGBMOGDCM MANEBEMOKEE, APNGBMOGDCM HOCFNIKGEJF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x628A490", Offset = "0x6288C90", VA = "0x18628A490")]
	public static bool OONIEGCHHIB(APNGBMOGDCM MANEBEMOKEE, APNGBMOGDCM HOCFNIKGEJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x628A4C0", Offset = "0x6288CC0", VA = "0x18628A4C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct BBLDIDBCHNK : IEquatable<BBLDIDBCHNK>, IComparable<BBLDIDBCHNK>, MOHMBCOCGML
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly BBLDIDBCHNK FNKJEGINCPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Guid ACBJLDAEBBN;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1C35600", Offset = "0x1C33E00", VA = "0x181C35600")]
	public BBLDIDBCHNK(Guid ACBJLDAEBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0xA70080", Offset = "0xA6E880", VA = "0x180A70080", Slot = "6")]
	public Guid FOBIODEMAEL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3CBB090", Offset = "0x3CB9890", VA = "0x183CBB090", Slot = "4")]
	public bool Equals(BBLDIDBCHNK GHNNCJBDHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3CBB0C0", Offset = "0x3CB98C0", VA = "0x183CBB0C0", Slot = "5")]
	public int CompareTo(BBLDIDBCHNK GHNNCJBDHKF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x628A530", Offset = "0x6288D30", VA = "0x18628A530", Slot = "0")]
	public override bool Equals(object ELOCHLKHPBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3CBB1C0", Offset = "0x3CB99C0", VA = "0x183CBB1C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3CBB090", Offset = "0x3CB9890", VA = "0x183CBB090")]
	public static bool PEFPHNLEPOM(BBLDIDBCHNK MANEBEMOKEE, BBLDIDBCHNK HOCFNIKGEJF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x628A490", Offset = "0x6288C90", VA = "0x18628A490")]
	public static bool OONIEGCHHIB(BBLDIDBCHNK MANEBEMOKEE, BBLDIDBCHNK HOCFNIKGEJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x628A5D0", Offset = "0x6288DD0", VA = "0x18628A5D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct GNGIIAMDNDI : IEquatable<GNGIIAMDNDI>, IComparable<GNGIIAMDNDI>, MOHMBCOCGML
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly GNGIIAMDNDI FNKJEGINCPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Guid ACBJLDAEBBN;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1C35600", Offset = "0x1C33E00", VA = "0x181C35600")]
	public GNGIIAMDNDI(Guid ACBJLDAEBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0xA70080", Offset = "0xA6E880", VA = "0x180A70080", Slot = "6")]
	public Guid FOBIODEMAEL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3CBB090", Offset = "0x3CB9890", VA = "0x183CBB090", Slot = "4")]
	public bool Equals(GNGIIAMDNDI GHNNCJBDHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3CBB0C0", Offset = "0x3CB98C0", VA = "0x183CBB0C0", Slot = "5")]
	public int CompareTo(GNGIIAMDNDI GHNNCJBDHKF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x628B560", Offset = "0x6289D60", VA = "0x18628B560", Slot = "0")]
	public override bool Equals(object ELOCHLKHPBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3CBB1C0", Offset = "0x3CB99C0", VA = "0x183CBB1C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3CBB090", Offset = "0x3CB9890", VA = "0x183CBB090")]
	public static bool PEFPHNLEPOM(GNGIIAMDNDI MANEBEMOKEE, GNGIIAMDNDI HOCFNIKGEJF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x628A490", Offset = "0x6288C90", VA = "0x18628A490")]
	public static bool OONIEGCHHIB(GNGIIAMDNDI MANEBEMOKEE, GNGIIAMDNDI HOCFNIKGEJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x628B600", Offset = "0x6289E00", VA = "0x18628B600", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct DCAOPGHJNHE : IEquatable<DCAOPGHJNHE>, IComparable<DCAOPGHJNHE>, MOHMBCOCGML
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly DCAOPGHJNHE FNKJEGINCPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Guid ACBJLDAEBBN;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public GIOOKNLAJHM FAIHPCFLLOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA70070", Offset = "0xA6E870", VA = "0x180A70070")]
		[CompilerGenerated]
		get
		{
			return default(GIOOKNLAJHM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public GIOOKNLAJHM IGBCDBKLEDO
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xD62CB0", Offset = "0xD614B0", VA = "0x180D62CB0")]
		[CompilerGenerated]
		get
		{
			return default(GIOOKNLAJHM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public GIOOKNLAJHM IOIBMPLONGA
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xD3C790", Offset = "0xD3AF90", VA = "0x180D3C790")]
		[CompilerGenerated]
		get
		{
			return default(GIOOKNLAJHM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0xA70080", Offset = "0xA6E880", VA = "0x180A70080", Slot = "6")]
	public Guid FOBIODEMAEL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x628AB70", Offset = "0x6289370", VA = "0x18628AB70")]
	public DCAOPGHJNHE(Guid ACBJLDAEBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x628ABB0", Offset = "0x62893B0", VA = "0x18628ABB0")]
	public DCAOPGHJNHE(GIOOKNLAJHM LOLAODFGJAL, GIOOKNLAJHM JELJKDPJFHM, GIOOKNLAJHM ONIFFGKLPDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x628A950", Offset = "0x6289150", VA = "0x18628A950")]
	private Guid KJKCFCGKGGO()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5D57BC0", Offset = "0x5D563C0", VA = "0x185D57BC0", Slot = "4")]
	public bool Equals(DCAOPGHJNHE GHNNCJBDHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x628A8A0", Offset = "0x62890A0", VA = "0x18628A8A0", Slot = "0")]
	public override bool Equals(object ELOCHLKHPBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3CBB1C0", Offset = "0x3CB99C0", VA = "0x183CBB1C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x628AAC0", Offset = "0x62892C0", VA = "0x18628AAC0")]
	public static bool PEFPHNLEPOM(DCAOPGHJNHE MANEBEMOKEE, DCAOPGHJNHE HOCFNIKGEJF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x628AA80", Offset = "0x6289280", VA = "0x18628AA80")]
	public static bool OONIEGCHHIB(DCAOPGHJNHE MANEBEMOKEE, DCAOPGHJNHE HOCFNIKGEJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x628A860", Offset = "0x6289060", VA = "0x18628A860", Slot = "5")]
	public int CompareTo(DCAOPGHJNHE GHNNCJBDHKF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x628AB00", Offset = "0x6289300", VA = "0x18628AB00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct COJNIMBKFBI : IEquatable<COJNIMBKFBI>, IComparable<COJNIMBKFBI>, MOHMBCOCGML
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly COJNIMBKFBI FNKJEGINCPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Guid ACBJLDAEBBN;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1C35600", Offset = "0x1C33E00", VA = "0x181C35600")]
	public COJNIMBKFBI(Guid ACBJLDAEBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0xA70080", Offset = "0xA6E880", VA = "0x180A70080", Slot = "6")]
	public Guid FOBIODEMAEL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3CBB090", Offset = "0x3CB9890", VA = "0x183CBB090", Slot = "4")]
	public bool Equals(COJNIMBKFBI GHNNCJBDHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3CBB0C0", Offset = "0x3CB98C0", VA = "0x183CBB0C0", Slot = "5")]
	public int CompareTo(COJNIMBKFBI GHNNCJBDHKF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x628A750", Offset = "0x6288F50", VA = "0x18628A750", Slot = "0")]
	public override bool Equals(object ELOCHLKHPBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3CBB1C0", Offset = "0x3CB99C0", VA = "0x183CBB1C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3CBB090", Offset = "0x3CB9890", VA = "0x183CBB090")]
	public static bool PEFPHNLEPOM(COJNIMBKFBI MANEBEMOKEE, COJNIMBKFBI HOCFNIKGEJF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x628A490", Offset = "0x6288C90", VA = "0x18628A490")]
	public static bool OONIEGCHHIB(COJNIMBKFBI MANEBEMOKEE, COJNIMBKFBI HOCFNIKGEJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x628A7F0", Offset = "0x6288FF0", VA = "0x18628A7F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct HOCHKCDFGDD : IEquatable<HOCHKCDFGDD>, IComparable<HOCHKCDFGDD>, MOHMBCOCGML
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly HOCHKCDFGDD FNKJEGINCPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Guid ACBJLDAEBBN;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1C35600", Offset = "0x1C33E00", VA = "0x181C35600")]
	public HOCHKCDFGDD(Guid ACBJLDAEBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0xA70080", Offset = "0xA6E880", VA = "0x180A70080", Slot = "6")]
	public Guid FOBIODEMAEL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3CBB090", Offset = "0x3CB9890", VA = "0x183CBB090", Slot = "4")]
	public bool Equals(HOCHKCDFGDD GHNNCJBDHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3CBB0C0", Offset = "0x3CB98C0", VA = "0x183CBB0C0", Slot = "5")]
	public int CompareTo(HOCHKCDFGDD GHNNCJBDHKF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x628B670", Offset = "0x6289E70", VA = "0x18628B670", Slot = "0")]
	public override bool Equals(object ELOCHLKHPBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3CBB1C0", Offset = "0x3CB99C0", VA = "0x183CBB1C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3CBB090", Offset = "0x3CB9890", VA = "0x183CBB090")]
	public static bool PEFPHNLEPOM(HOCHKCDFGDD MANEBEMOKEE, HOCHKCDFGDD HOCFNIKGEJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x628B710", Offset = "0x6289F10", VA = "0x18628B710", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct EMJPDEPCHIB : IEquatable<EMJPDEPCHIB>, IComparable<EMJPDEPCHIB>, MOHMBCOCGML
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static readonly EMJPDEPCHIB FNKJEGINCPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Guid ACBJLDAEBBN;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x1C35600", Offset = "0x1C33E00", VA = "0x181C35600")]
	public EMJPDEPCHIB(Guid ACBJLDAEBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0xA70080", Offset = "0xA6E880", VA = "0x180A70080", Slot = "6")]
	public Guid FOBIODEMAEL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3CBB090", Offset = "0x3CB9890", VA = "0x183CBB090", Slot = "4")]
	public bool Equals(EMJPDEPCHIB GHNNCJBDHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3CBB0C0", Offset = "0x3CB98C0", VA = "0x183CBB0C0", Slot = "5")]
	public int CompareTo(EMJPDEPCHIB GHNNCJBDHKF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x628B340", Offset = "0x6289B40", VA = "0x18628B340", Slot = "0")]
	public override bool Equals(object ELOCHLKHPBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3CBB1C0", Offset = "0x3CB99C0", VA = "0x183CBB1C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3CBB090", Offset = "0x3CB9890", VA = "0x183CBB090")]
	public static bool PEFPHNLEPOM(EMJPDEPCHIB MANEBEMOKEE, EMJPDEPCHIB HOCFNIKGEJF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x628A490", Offset = "0x6288C90", VA = "0x18628A490")]
	public static bool OONIEGCHHIB(EMJPDEPCHIB MANEBEMOKEE, EMJPDEPCHIB HOCFNIKGEJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x628B3E0", Offset = "0x6289BE0", VA = "0x18628B3E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct BJPEFKELMBF : IEquatable<BJPEFKELMBF>, IComparable<BJPEFKELMBF>, MOHMBCOCGML
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static readonly BJPEFKELMBF FNKJEGINCPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly Guid ACBJLDAEBBN;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1C35600", Offset = "0x1C33E00", VA = "0x181C35600")]
	public BJPEFKELMBF(Guid ACBJLDAEBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0xA70080", Offset = "0xA6E880", VA = "0x180A70080", Slot = "6")]
	public Guid FOBIODEMAEL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3CBB090", Offset = "0x3CB9890", VA = "0x183CBB090", Slot = "4")]
	public bool Equals(BJPEFKELMBF GHNNCJBDHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3CBB0C0", Offset = "0x3CB98C0", VA = "0x183CBB0C0", Slot = "5")]
	public int CompareTo(BJPEFKELMBF GHNNCJBDHKF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x628A640", Offset = "0x6288E40", VA = "0x18628A640", Slot = "0")]
	public override bool Equals(object ELOCHLKHPBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3CBB1C0", Offset = "0x3CB99C0", VA = "0x183CBB1C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3CBB090", Offset = "0x3CB9890", VA = "0x183CBB090")]
	public static bool PEFPHNLEPOM(BJPEFKELMBF MANEBEMOKEE, BJPEFKELMBF HOCFNIKGEJF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x628A490", Offset = "0x6288C90", VA = "0x18628A490")]
	public static bool OONIEGCHHIB(BJPEFKELMBF MANEBEMOKEE, BJPEFKELMBF HOCFNIKGEJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x628A6E0", Offset = "0x6288EE0", VA = "0x18628A6E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct DJKACJFEPOH : IEquatable<DJKACJFEPOH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly string?[]? CCEFDCJBDPE;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool LGKDCANGALE
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x628ADC0", Offset = "0x62895C0", VA = "0x18628ADC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int IGPJFKKFEDI
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x3A5ECC0", Offset = "0x3A5D4C0", VA = "0x183A5ECC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x628B180", Offset = "0x6289980", VA = "0x18628B180")]
	public DJKACJFEPOH(string? ILFBDKAIBNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x628B2C0", Offset = "0x6289AC0", VA = "0x18628B2C0")]
	public DJKACJFEPOH(string?[] BJKHJPIMOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x628AEC0", Offset = "0x62896C0", VA = "0x18628AEC0")]
	private static string?[]? HLOAGAOMNAH(string?[]? BJKHJPIMOCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x628AC00", Offset = "0x6289400", VA = "0x18628AC00")]
	public string CMOBIJEMELI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x628AC60", Offset = "0x6289460", VA = "0x18628AC60", Slot = "4")]
	public bool Equals(DJKACJFEPOH GHNNCJBDHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x628AD30", Offset = "0x6289530", VA = "0x18628AD30", Slot = "0")]
	public override bool Equals(object ELOCHLKHPBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x628ADE0", Offset = "0x62895E0", VA = "0x18628ADE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x628B0F0", Offset = "0x62898F0", VA = "0x18628B0F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct GIOOKNLAJHM : IEquatable<GIOOKNLAJHM>, IComparable<GIOOKNLAJHM>, MOHMBCOCGML
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly GIOOKNLAJHM FNKJEGINCPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Guid ACBJLDAEBBN;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1C35600", Offset = "0x1C33E00", VA = "0x181C35600")]
	public GIOOKNLAJHM(Guid ACBJLDAEBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0xA70080", Offset = "0xA6E880", VA = "0x180A70080", Slot = "6")]
	public Guid FOBIODEMAEL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3CBB090", Offset = "0x3CB9890", VA = "0x183CBB090", Slot = "4")]
	public bool Equals(GIOOKNLAJHM GHNNCJBDHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3CBB0C0", Offset = "0x3CB98C0", VA = "0x183CBB0C0", Slot = "5")]
	public int CompareTo(GIOOKNLAJHM GHNNCJBDHKF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x628B450", Offset = "0x6289C50", VA = "0x18628B450", Slot = "0")]
	public override bool Equals(object ELOCHLKHPBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3CBB1C0", Offset = "0x3CB99C0", VA = "0x183CBB1C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3CBB090", Offset = "0x3CB9890", VA = "0x183CBB090")]
	public static bool PEFPHNLEPOM(GIOOKNLAJHM MANEBEMOKEE, GIOOKNLAJHM HOCFNIKGEJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x628B4F0", Offset = "0x6289CF0", VA = "0x18628B4F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface JMAJGLHILJC<TModern> : EOBMIEBAPDI<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string CBKHDNIGJKM(TModern LDGDOKGHMLK);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface MOHMBCOCGML
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Guid FOBIODEMAEL();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface EOBMIEBAPDI<out TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TModern LIFDEJMLAPE(string LDGDOKGHMLK);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface LCHJMKMHKAP
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	JMAJGLHILJC<APNGBMOGDCM> IGGIMHHOLMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	JMAJGLHILJC<COJNIMBKFBI> LKHFMKCAOKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	JMAJGLHILJC<BJPEFKELMBF> CDNFDIPBEIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	JMAJGLHILJC<DCAOPGHJNHE> AHIBOGKLKIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	JMAJGLHILJC<GNGIIAMDNDI> HKHJGMIKENA
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	JMAJGLHILJC<EMJPDEPCHIB> CEPIFOKCNDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	JMAJGLHILJC<BBLDIDBCHNK> PLIBPMCINBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	JMAJGLHILJC<HOCHKCDFGDD> GDBJFIOFOPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class KMHPKOHNADF
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x628B7B0", Offset = "0x6289FB0", VA = "0x18628B7B0")]
	public static string[] JECGDHGFLGM(string? ILFBDKAIBNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x628B780", Offset = "0x6289F80", VA = "0x18628B780")]
	public static string? CLIDKKFOCEM(string? KLLDEIFEGHM)
	{
		return null;
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
