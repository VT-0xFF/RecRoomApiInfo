using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
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
		[Cpp2IlInjected.Address(RVA = "0x98C9C0", Offset = "0x98BBC0", VA = "0x18098C9C0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7E1DEC0", Offset = "0x7E1D0C0", VA = "0x187E1DEC0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x98D6C0", Offset = "0x98C8C0", VA = "0x18098D6C0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x98D700", Offset = "0x98C900", VA = "0x18098D700")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface FINHHFNAKCJ
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string JEAAONFOJJH(BGAANIHBCHM GEDAGNGPIPL);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BGAANIHBCHM ANADGBKPLNB(string GEDAGNGPIPL);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct BGAANIHBCHM : IEquatable<BGAANIHBCHM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly DBNNFNBKLPB EKKAALFKEPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly KFKBHGMMOEG DAPCMPKCMBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly Guid GIFMIPLPHKP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool DCNHHFELJKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7E1CB40", Offset = "0x7E1BD40", VA = "0x187E1CB40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool NLBDLDAIHFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7E1CB10", Offset = "0x7E1BD10", VA = "0x187E1CB10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7E1CEE0", Offset = "0x7E1C0E0", VA = "0x187E1CEE0")]
	public BGAANIHBCHM(BGAANIHBCHM CAFOKDBKLHN, [Optional] Guid DLBJLJBGNMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5691890", Offset = "0x5690A90", VA = "0x185691890")]
	public BGAANIHBCHM(DBNNFNBKLPB HOHKDEHCGNG, KFKBHGMMOEG KFEOMDBGHAA, [Optional] Guid DLBJLJBGNMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7E1C8E0", Offset = "0x7E1BAE0", VA = "0x187E1C8E0", Slot = "4")]
	public bool Equals(BGAANIHBCHM LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7E1C9A0", Offset = "0x7E1BBA0", VA = "0x187E1C9A0", Slot = "0")]
	public override bool Equals(object ONELFPFEALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7E1CA80", Offset = "0x7E1BC80", VA = "0x187E1CA80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7E1CA50", Offset = "0x7E1BC50", VA = "0x187E1CA50")]
	public static bool GJNOMHNHJKL(BGAANIHBCHM MGBGOAGHGOJ, BGAANIHBCHM FCFMBBJABHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7E1CBD0", Offset = "0x7E1BDD0", VA = "0x187E1CBD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct DBNNFNBKLPB : IEquatable<DBNNFNBKLPB>, IComparable<DBNNFNBKLPB>, AEJFKFOGKPI
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly DBNNFNBKLPB CENLOHBLGNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Guid FGPNICIMMFP;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x10A0120", Offset = "0x109F320", VA = "0x1810A0120")]
	public DBNNFNBKLPB(Guid FGPNICIMMFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x10A0110", Offset = "0x109F310", VA = "0x1810A0110", Slot = "6")]
	public Guid JDEHCEJHEGD()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4FB0160", Offset = "0x4FAF360", VA = "0x184FB0160", Slot = "4")]
	public bool Equals(DBNNFNBKLPB LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4FB0130", Offset = "0x4FAF330", VA = "0x184FB0130", Slot = "5")]
	public int CompareTo(DBNNFNBKLPB LDKNLBHIGFL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7E1D050", Offset = "0x7E1C250", VA = "0x187E1D050", Slot = "0")]
	public override bool Equals(object ONELFPFEALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4FB0490", Offset = "0x4FAF690", VA = "0x184FB0490", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4FB0160", Offset = "0x4FAF360", VA = "0x184FB0160")]
	public static bool GJNOMHNHJKL(DBNNFNBKLPB MGBGOAGHGOJ, DBNNFNBKLPB FCFMBBJABHD)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7E1CFB0", Offset = "0x7E1C1B0", VA = "0x187E1CFB0")]
	public static bool GHFFJAPPGNB(DBNNFNBKLPB MGBGOAGHGOJ, DBNNFNBKLPB FCFMBBJABHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7E1D100", Offset = "0x7E1C300", VA = "0x187E1D100", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct OICBNHEMJNF : IEquatable<OICBNHEMJNF>, IComparable<OICBNHEMJNF>, AEJFKFOGKPI
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static readonly OICBNHEMJNF CENLOHBLGNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Guid FGPNICIMMFP;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x10A0120", Offset = "0x109F320", VA = "0x1810A0120")]
	public OICBNHEMJNF(Guid FGPNICIMMFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x10A0110", Offset = "0x109F310", VA = "0x1810A0110", Slot = "6")]
	public Guid JDEHCEJHEGD()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4FB0160", Offset = "0x4FAF360", VA = "0x184FB0160", Slot = "4")]
	public bool Equals(OICBNHEMJNF LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4FB0130", Offset = "0x4FAF330", VA = "0x184FB0130", Slot = "5")]
	public int CompareTo(OICBNHEMJNF LDKNLBHIGFL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7E1E1C0", Offset = "0x7E1D3C0", VA = "0x187E1E1C0", Slot = "0")]
	public override bool Equals(object ONELFPFEALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4FB0490", Offset = "0x4FAF690", VA = "0x184FB0490", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4FB0160", Offset = "0x4FAF360", VA = "0x184FB0160")]
	public static bool GJNOMHNHJKL(OICBNHEMJNF MGBGOAGHGOJ, OICBNHEMJNF FCFMBBJABHD)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7E1CFB0", Offset = "0x7E1C1B0", VA = "0x187E1CFB0")]
	public static bool GHFFJAPPGNB(OICBNHEMJNF MGBGOAGHGOJ, OICBNHEMJNF FCFMBBJABHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7E1E270", Offset = "0x7E1D470", VA = "0x187E1E270", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct GMOJNJFKNAH : IEquatable<GMOJNJFKNAH>, IComparable<GMOJNJFKNAH>, AEJFKFOGKPI
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public static readonly GMOJNJFKNAH CENLOHBLGNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Guid FGPNICIMMFP;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x10A0120", Offset = "0x109F320", VA = "0x1810A0120")]
	public GMOJNJFKNAH(Guid FGPNICIMMFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x10A0110", Offset = "0x109F310", VA = "0x1810A0110", Slot = "6")]
	public Guid JDEHCEJHEGD()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4FB0160", Offset = "0x4FAF360", VA = "0x184FB0160", Slot = "4")]
	public bool Equals(GMOJNJFKNAH LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4FB0130", Offset = "0x4FAF330", VA = "0x184FB0130", Slot = "5")]
	public int CompareTo(GMOJNJFKNAH LDKNLBHIGFL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7E1DB00", Offset = "0x7E1CD00", VA = "0x187E1DB00", Slot = "0")]
	public override bool Equals(object ONELFPFEALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4FB0490", Offset = "0x4FAF690", VA = "0x184FB0490", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4FB0160", Offset = "0x4FAF360", VA = "0x184FB0160")]
	public static bool GJNOMHNHJKL(GMOJNJFKNAH MGBGOAGHGOJ, GMOJNJFKNAH FCFMBBJABHD)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7E1CFB0", Offset = "0x7E1C1B0", VA = "0x187E1CFB0")]
	public static bool GHFFJAPPGNB(GMOJNJFKNAH MGBGOAGHGOJ, GMOJNJFKNAH FCFMBBJABHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7E1DBB0", Offset = "0x7E1CDB0", VA = "0x187E1DBB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct KFKBHGMMOEG : IEquatable<KFKBHGMMOEG>, IComparable<KFKBHGMMOEG>, AEJFKFOGKPI
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly KFKBHGMMOEG CENLOHBLGNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Guid FGPNICIMMFP;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x10A0120", Offset = "0x109F320", VA = "0x1810A0120")]
	public KFKBHGMMOEG(Guid FGPNICIMMFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x10A0110", Offset = "0x109F310", VA = "0x1810A0110", Slot = "6")]
	public Guid JDEHCEJHEGD()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7E1DD40", Offset = "0x7E1CF40", VA = "0x187E1DD40", Slot = "4")]
	public bool Equals(KFKBHGMMOEG LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7E1DD70", Offset = "0x7E1CF70", VA = "0x187E1DD70", Slot = "0")]
	public override bool Equals(object ONELFPFEALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4FB0490", Offset = "0x4FAF690", VA = "0x184FB0490", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7E1DD40", Offset = "0x7E1CF40", VA = "0x187E1DD40")]
	public static bool GJNOMHNHJKL(KFKBHGMMOEG MGBGOAGHGOJ, KFKBHGMMOEG FCFMBBJABHD)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7E1DE20", Offset = "0x7E1D020", VA = "0x187E1DE20")]
	public static bool GHFFJAPPGNB(KFKBHGMMOEG MGBGOAGHGOJ, KFKBHGMMOEG FCFMBBJABHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4FB0130", Offset = "0x4FAF330", VA = "0x184FB0130", Slot = "5")]
	public int CompareTo(KFKBHGMMOEG LDKNLBHIGFL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7E1DE50", Offset = "0x7E1D050", VA = "0x187E1DE50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x10A0120", Offset = "0x109F320", VA = "0x1810A0120")]
	public KFKBHGMMOEG(IAFBNDMAPDH CPLLOLGLILC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct OAHMAPNALPM : IEquatable<OAHMAPNALPM>, IComparable<OAHMAPNALPM>, AEJFKFOGKPI
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly OAHMAPNALPM CENLOHBLGNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Guid FGPNICIMMFP;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x10A0120", Offset = "0x109F320", VA = "0x1810A0120")]
	public OAHMAPNALPM(Guid FGPNICIMMFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x10A0110", Offset = "0x109F310", VA = "0x1810A0110", Slot = "6")]
	public Guid JDEHCEJHEGD()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4FB0160", Offset = "0x4FAF360", VA = "0x184FB0160", Slot = "4")]
	public bool Equals(OAHMAPNALPM LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4FB0130", Offset = "0x4FAF330", VA = "0x184FB0130", Slot = "5")]
	public int CompareTo(OAHMAPNALPM LDKNLBHIGFL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7E1DF40", Offset = "0x7E1D140", VA = "0x187E1DF40", Slot = "0")]
	public override bool Equals(object ONELFPFEALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4FB0490", Offset = "0x4FAF690", VA = "0x184FB0490", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4FB0160", Offset = "0x4FAF360", VA = "0x184FB0160")]
	public static bool GJNOMHNHJKL(OAHMAPNALPM MGBGOAGHGOJ, OAHMAPNALPM FCFMBBJABHD)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7E1CFB0", Offset = "0x7E1C1B0", VA = "0x187E1CFB0")]
	public static bool GHFFJAPPGNB(OAHMAPNALPM MGBGOAGHGOJ, OAHMAPNALPM FCFMBBJABHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7E1DFF0", Offset = "0x7E1D1F0", VA = "0x187E1DFF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct FKCADKOIAIJ : IEquatable<FKCADKOIAIJ>, IComparable<FKCADKOIAIJ>, AEJFKFOGKPI
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly FKCADKOIAIJ CENLOHBLGNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Guid FGPNICIMMFP;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x10A0120", Offset = "0x109F320", VA = "0x1810A0120")]
	public FKCADKOIAIJ(Guid FGPNICIMMFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x10A0110", Offset = "0x109F310", VA = "0x1810A0110", Slot = "6")]
	public Guid JDEHCEJHEGD()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4FB0160", Offset = "0x4FAF360", VA = "0x184FB0160", Slot = "4")]
	public bool Equals(FKCADKOIAIJ LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x4FB0130", Offset = "0x4FAF330", VA = "0x184FB0130", Slot = "5")]
	public int CompareTo(FKCADKOIAIJ LDKNLBHIGFL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7E1D9E0", Offset = "0x7E1CBE0", VA = "0x187E1D9E0", Slot = "0")]
	public override bool Equals(object ONELFPFEALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4FB0490", Offset = "0x4FAF690", VA = "0x184FB0490", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4FB0160", Offset = "0x4FAF360", VA = "0x184FB0160")]
	public static bool GJNOMHNHJKL(FKCADKOIAIJ MGBGOAGHGOJ, FKCADKOIAIJ FCFMBBJABHD)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7E1CFB0", Offset = "0x7E1C1B0", VA = "0x187E1CFB0")]
	public static bool GHFFJAPPGNB(FKCADKOIAIJ MGBGOAGHGOJ, FKCADKOIAIJ FCFMBBJABHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7E1DA90", Offset = "0x7E1CC90", VA = "0x187E1DA90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct COALEIABEBD : IEquatable<COALEIABEBD>, IComparable<COALEIABEBD>, AEJFKFOGKPI
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly COALEIABEBD CENLOHBLGNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Guid FGPNICIMMFP;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x10A0120", Offset = "0x109F320", VA = "0x1810A0120")]
	public COALEIABEBD(Guid FGPNICIMMFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x10A0110", Offset = "0x109F310", VA = "0x1810A0110", Slot = "6")]
	public Guid JDEHCEJHEGD()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4FB0160", Offset = "0x4FAF360", VA = "0x184FB0160", Slot = "4")]
	public bool Equals(COALEIABEBD LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4FB0130", Offset = "0x4FAF330", VA = "0x184FB0130", Slot = "5")]
	public int CompareTo(COALEIABEBD LDKNLBHIGFL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7E1CF00", Offset = "0x7E1C100", VA = "0x187E1CF00", Slot = "0")]
	public override bool Equals(object ONELFPFEALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4FB0490", Offset = "0x4FAF690", VA = "0x184FB0490", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4FB0160", Offset = "0x4FAF360", VA = "0x184FB0160")]
	public static bool GJNOMHNHJKL(COALEIABEBD MGBGOAGHGOJ, COALEIABEBD FCFMBBJABHD)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7E1CFB0", Offset = "0x7E1C1B0", VA = "0x187E1CFB0")]
	public static bool GHFFJAPPGNB(COALEIABEBD MGBGOAGHGOJ, COALEIABEBD FCFMBBJABHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7E1CFE0", Offset = "0x7E1C1E0", VA = "0x187E1CFE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct EHPJCGLIJLP : IEquatable<EHPJCGLIJLP>, IComparable<EHPJCGLIJLP>, AEJFKFOGKPI
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly EHPJCGLIJLP CENLOHBLGNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Guid FGPNICIMMFP;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x10A0120", Offset = "0x109F320", VA = "0x1810A0120")]
	public EHPJCGLIJLP(Guid FGPNICIMMFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x10A0110", Offset = "0x109F310", VA = "0x1810A0110", Slot = "6")]
	public Guid JDEHCEJHEGD()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x4FB0160", Offset = "0x4FAF360", VA = "0x184FB0160", Slot = "4")]
	public bool Equals(EHPJCGLIJLP LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x4FB0130", Offset = "0x4FAF330", VA = "0x184FB0130", Slot = "5")]
	public int CompareTo(EHPJCGLIJLP LDKNLBHIGFL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7E1D170", Offset = "0x7E1C370", VA = "0x187E1D170", Slot = "0")]
	public override bool Equals(object ONELFPFEALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x4FB0490", Offset = "0x4FAF690", VA = "0x184FB0490", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x4FB0160", Offset = "0x4FAF360", VA = "0x184FB0160")]
	public static bool GJNOMHNHJKL(EHPJCGLIJLP MGBGOAGHGOJ, EHPJCGLIJLP FCFMBBJABHD)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7E1CFB0", Offset = "0x7E1C1B0", VA = "0x187E1CFB0")]
	public static bool GHFFJAPPGNB(EHPJCGLIJLP MGBGOAGHGOJ, EHPJCGLIJLP FCFMBBJABHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7E1D220", Offset = "0x7E1C420", VA = "0x187E1D220", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct FAFHJKJKKAE : IEquatable<FAFHJKJKKAE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly string?[]? PPDGFDMNGNO;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool KHBFGBFEAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7E1D700", Offset = "0x7E1C900", VA = "0x187E1D700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int EBPDBAJOHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4BC78D0", Offset = "0x4BC6AD0", VA = "0x184BC78D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7E1D810", Offset = "0x7E1CA10", VA = "0x187E1D810")]
	public FAFHJKJKKAE(string? MFKKEFJIIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7E1D960", Offset = "0x7E1CB60", VA = "0x187E1D960")]
	public FAFHJKJKKAE(string?[] NLLEGKHPKCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7E1D290", Offset = "0x7E1C490", VA = "0x187E1D290")]
	private static string?[]? ELINGCKJHGL(string?[]? NLLEGKHPKCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7E1D720", Offset = "0x7E1C920", VA = "0x187E1D720")]
	public string NAFMBCHEBIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7E1D4C0", Offset = "0x7E1C6C0", VA = "0x187E1D4C0", Slot = "4")]
	public bool Equals(FAFHJKJKKAE LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7E1D590", Offset = "0x7E1C790", VA = "0x187E1D590", Slot = "0")]
	public override bool Equals(object ONELFPFEALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7E1D620", Offset = "0x7E1C820", VA = "0x187E1D620", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7E1D780", Offset = "0x7E1C980", VA = "0x187E1D780", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct IAFBNDMAPDH : IEquatable<IAFBNDMAPDH>, IComparable<IAFBNDMAPDH>, AEJFKFOGKPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Guid FGPNICIMMFP;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x10A0120", Offset = "0x109F320", VA = "0x1810A0120")]
	public IAFBNDMAPDH(Guid FGPNICIMMFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x10A0110", Offset = "0x109F310", VA = "0x1810A0110", Slot = "6")]
	public Guid JDEHCEJHEGD()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x4FB0160", Offset = "0x4FAF360", VA = "0x184FB0160", Slot = "4")]
	public bool Equals(IAFBNDMAPDH LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x4FB0130", Offset = "0x4FAF330", VA = "0x184FB0130", Slot = "5")]
	public int CompareTo(IAFBNDMAPDH LDKNLBHIGFL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7E1DC20", Offset = "0x7E1CE20", VA = "0x187E1DC20", Slot = "0")]
	public override bool Equals(object ONELFPFEALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x4FB0490", Offset = "0x4FAF690", VA = "0x184FB0490", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7E1DCD0", Offset = "0x7E1CED0", VA = "0x187E1DCD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface AHJHCCMBMGO<TModern> : DIJBIKLMCFK<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string IKENOJMGOIG(TModern DKEIFIJICHJ);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface AEJFKFOGKPI
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Guid JDEHCEJHEGD();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface DIJBIKLMCFK<out TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TModern GEGCDLMGOLM(string DKEIFIJICHJ);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface OPMMEONFMCI
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	AHJHCCMBMGO<DBNNFNBKLPB> FOLEAGDJEDM
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	AHJHCCMBMGO<OAHMAPNALPM> AEIEPGPKHOH
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	AHJHCCMBMGO<EHPJCGLIJLP> DBPCHLMAGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	AHJHCCMBMGO<KFKBHGMMOEG> HMPMBLIJCHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	AHJHCCMBMGO<GMOJNJFKNAH> MHIMIOHIPCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	AHJHCCMBMGO<COALEIABEBD> PHGPHBBKOJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	AHJHCCMBMGO<OICBNHEMJNF> NCKGKDEBCHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	AHJHCCMBMGO<FKCADKOIAIJ> NMGOHIIPDGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class OGFBEMKGKBE
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static readonly char[] FBAMDKMKMIF;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7E1E090", Offset = "0x7E1D290", VA = "0x187E1E090")]
	public static string[] JIJLBHBPANL(string? MFKKEFJIIFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7E1E060", Offset = "0x7E1D260", VA = "0x187E1E060")]
	public static string? DJCFBFKEDFG(string? HOHKDEHCGNG)
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
