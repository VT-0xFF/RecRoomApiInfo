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
		[Cpp2IlInjected.Address(RVA = "0x7BA380", Offset = "0x7B8D80", VA = "0x1807BA380")]
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
		[Cpp2IlInjected.Address(RVA = "0x6639430", Offset = "0x6637E30", VA = "0x186639430")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7BA560", Offset = "0x7B8F60", VA = "0x1807BA560")]
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
		[Cpp2IlInjected.Address(RVA = "0x7BA5A0", Offset = "0x7B8FA0", VA = "0x1807BA5A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface FLKKBKBNNPM
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string JLKDILEIJOC(ACAMCBLFLNF KIEPLBLJKOI);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ACAMCBLFLNF DCJJDHFPDEL(string KIEPLBLJKOI);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct ACAMCBLFLNF : IEquatable<ACAMCBLFLNF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly KFFIPGPICBA FBMCHGGOBKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly PMEHEMKJJKD ECPKNENLDHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly Guid LKKGLEIKAIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly RRColor? LEGCCCHMDDN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool ICBNKOEBLPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6637A80", Offset = "0x6636480", VA = "0x186637A80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool ADHGOEFIFAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6637B40", Offset = "0x6636540", VA = "0x186637B40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x66383D0", Offset = "0x6636DD0", VA = "0x1866383D0")]
	public ACAMCBLFLNF(ACAMCBLFLNF OGIHJPBGOND, [Optional] Guid GDLJICNGCJI, [Optional] RRColor? GJNHDHNOICC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6638340", Offset = "0x6636D40", VA = "0x186638340")]
	public ACAMCBLFLNF(KFFIPGPICBA KGALHPOKBNM, PMEHEMKJJKD FEIDOPAMLBC, [Optional] Guid GDLJICNGCJI, [Optional] RRColor? GJNHDHNOICC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6637B80", Offset = "0x6636580", VA = "0x186637B80", Slot = "4")]
	public bool Equals(ACAMCBLFLNF CGDFJMJIABO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6637C80", Offset = "0x6636680", VA = "0x186637C80", Slot = "0")]
	public override bool Equals(object GKNPKJAGNGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6637DE0", Offset = "0x66367E0", VA = "0x186637DE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6637ED0", Offset = "0x66368D0", VA = "0x186637ED0")]
	public static bool JGKBBKJJNFA(ACAMCBLFLNF GHGBJDGFDKJ, ACAMCBLFLNF PHPPILHFFME)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6637D70", Offset = "0x6636770", VA = "0x186637D70")]
	public static bool GOKPCPODMCO(ACAMCBLFLNF GHGBJDGFDKJ, ACAMCBLFLNF PHPPILHFFME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6637F40", Offset = "0x6636940", VA = "0x186637F40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct KFFIPGPICBA : IEquatable<KFFIPGPICBA>, IComparable<KFFIPGPICBA>, LBKHMHDHHFA
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly KFFIPGPICBA DPEMCFFPABG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Guid DMMBGEACBPP;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1D18170", Offset = "0x1D16B70", VA = "0x181D18170")]
	public KFFIPGPICBA(Guid DMMBGEACBPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7F92D0", Offset = "0x7F7CD0", VA = "0x1807F92D0", Slot = "6")]
	public Guid PLCAAILKEAB()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3DD7D00", Offset = "0x3DD6700", VA = "0x183DD7D00", Slot = "4")]
	public bool Equals(KFFIPGPICBA CGDFJMJIABO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3DD78B0", Offset = "0x3DD62B0", VA = "0x183DD78B0", Slot = "5")]
	public int CompareTo(KFFIPGPICBA CGDFJMJIABO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x66387C0", Offset = "0x66371C0", VA = "0x1866387C0", Slot = "0")]
	public override bool Equals(object GKNPKJAGNGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3DD7990", Offset = "0x3DD6390", VA = "0x183DD7990", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3DD7D00", Offset = "0x3DD6700", VA = "0x183DD7D00")]
	public static bool JGKBBKJJNFA(KFFIPGPICBA GHGBJDGFDKJ, KFFIPGPICBA PHPPILHFFME)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6638500", Offset = "0x6636F00", VA = "0x186638500")]
	public static bool GOKPCPODMCO(KFFIPGPICBA GHGBJDGFDKJ, KFFIPGPICBA PHPPILHFFME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6638860", Offset = "0x6637260", VA = "0x186638860", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct KFCBMNELBDJ : IEquatable<KFCBMNELBDJ>, IComparable<KFCBMNELBDJ>, LBKHMHDHHFA
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly KFCBMNELBDJ DPEMCFFPABG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Guid DMMBGEACBPP;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1D18170", Offset = "0x1D16B70", VA = "0x181D18170")]
	public KFCBMNELBDJ(Guid DMMBGEACBPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7F92D0", Offset = "0x7F7CD0", VA = "0x1807F92D0", Slot = "6")]
	public Guid PLCAAILKEAB()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3DD7D00", Offset = "0x3DD6700", VA = "0x183DD7D00", Slot = "4")]
	public bool Equals(KFCBMNELBDJ CGDFJMJIABO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3DD78B0", Offset = "0x3DD62B0", VA = "0x183DD78B0", Slot = "5")]
	public int CompareTo(KFCBMNELBDJ CGDFJMJIABO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x66386B0", Offset = "0x66370B0", VA = "0x1866386B0", Slot = "0")]
	public override bool Equals(object GKNPKJAGNGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3DD7990", Offset = "0x3DD6390", VA = "0x183DD7990", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3DD7D00", Offset = "0x3DD6700", VA = "0x183DD7D00")]
	public static bool JGKBBKJJNFA(KFCBMNELBDJ GHGBJDGFDKJ, KFCBMNELBDJ PHPPILHFFME)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6638500", Offset = "0x6636F00", VA = "0x186638500")]
	public static bool GOKPCPODMCO(KFCBMNELBDJ GHGBJDGFDKJ, KFCBMNELBDJ PHPPILHFFME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6638750", Offset = "0x6637150", VA = "0x186638750", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct LDDIEGIGADA : IEquatable<LDDIEGIGADA>, IComparable<LDDIEGIGADA>, LBKHMHDHHFA
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly LDDIEGIGADA DPEMCFFPABG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Guid DMMBGEACBPP;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1D18170", Offset = "0x1D16B70", VA = "0x181D18170")]
	public LDDIEGIGADA(Guid DMMBGEACBPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7F92D0", Offset = "0x7F7CD0", VA = "0x1807F92D0", Slot = "6")]
	public Guid PLCAAILKEAB()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3DD7D00", Offset = "0x3DD6700", VA = "0x183DD7D00", Slot = "4")]
	public bool Equals(LDDIEGIGADA CGDFJMJIABO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3DD78B0", Offset = "0x3DD62B0", VA = "0x183DD78B0", Slot = "5")]
	public int CompareTo(LDDIEGIGADA CGDFJMJIABO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x66389C0", Offset = "0x66373C0", VA = "0x1866389C0", Slot = "0")]
	public override bool Equals(object GKNPKJAGNGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3DD7990", Offset = "0x3DD6390", VA = "0x183DD7990", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3DD7D00", Offset = "0x3DD6700", VA = "0x183DD7D00")]
	public static bool JGKBBKJJNFA(LDDIEGIGADA GHGBJDGFDKJ, LDDIEGIGADA PHPPILHFFME)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6638500", Offset = "0x6636F00", VA = "0x186638500")]
	public static bool GOKPCPODMCO(LDDIEGIGADA GHGBJDGFDKJ, LDDIEGIGADA PHPPILHFFME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6638A60", Offset = "0x6637460", VA = "0x186638A60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct PMEHEMKJJKD : IEquatable<PMEHEMKJJKD>, IComparable<PMEHEMKJJKD>, LBKHMHDHHFA
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly PMEHEMKJJKD DPEMCFFPABG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Guid DMMBGEACBPP;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public ABKJACHDCEH PIKBEGEGNCI
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xB51900", Offset = "0xB50300", VA = "0x180B51900")]
		[CompilerGenerated]
		get
		{
			return default(ABKJACHDCEH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public ABKJACHDCEH FHFGNDIFMNH
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xF022E0", Offset = "0xF00CE0", VA = "0x180F022E0")]
		[CompilerGenerated]
		get
		{
			return default(ABKJACHDCEH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ABKJACHDCEH JGPHMCCHGMC
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xE36490", Offset = "0xE34E90", VA = "0x180E36490")]
		[CompilerGenerated]
		get
		{
			return default(ABKJACHDCEH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7F92D0", Offset = "0x7F7CD0", VA = "0x1807F92D0", Slot = "6")]
	public Guid PLCAAILKEAB()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x66398D0", Offset = "0x66382D0", VA = "0x1866398D0")]
	public PMEHEMKJJKD(Guid DMMBGEACBPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6639910", Offset = "0x6638310", VA = "0x186639910")]
	public PMEHEMKJJKD(ABKJACHDCEH NHKLBKFOALC, ABKJACHDCEH FDNAFFCJCPN, ABKJACHDCEH HMGDMKEHLFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6639730", Offset = "0x6638130", VA = "0x186639730")]
	private Guid PIBJEMFCACK()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x609A860", Offset = "0x6099260", VA = "0x18609A860", Slot = "4")]
	public bool Equals(PMEHEMKJJKD CGDFJMJIABO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6639600", Offset = "0x6638000", VA = "0x186639600", Slot = "0")]
	public override bool Equals(object GKNPKJAGNGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3DD7990", Offset = "0x3DD6390", VA = "0x183DD7990", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x66396F0", Offset = "0x66380F0", VA = "0x1866396F0")]
	public static bool JGKBBKJJNFA(PMEHEMKJJKD GHGBJDGFDKJ, PMEHEMKJJKD PHPPILHFFME)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x66396B0", Offset = "0x66380B0", VA = "0x1866396B0")]
	public static bool GOKPCPODMCO(PMEHEMKJJKD GHGBJDGFDKJ, PMEHEMKJJKD PHPPILHFFME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x66395C0", Offset = "0x6637FC0", VA = "0x1866395C0", Slot = "5")]
	public int CompareTo(PMEHEMKJJKD CGDFJMJIABO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6639860", Offset = "0x6638260", VA = "0x186639860", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct DHLFHOCNJLN : IEquatable<DHLFHOCNJLN>, IComparable<DHLFHOCNJLN>, LBKHMHDHHFA
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly DHLFHOCNJLN DPEMCFFPABG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Guid DMMBGEACBPP;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1D18170", Offset = "0x1D16B70", VA = "0x181D18170")]
	public DHLFHOCNJLN(Guid DMMBGEACBPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7F92D0", Offset = "0x7F7CD0", VA = "0x1807F92D0", Slot = "6")]
	public Guid PLCAAILKEAB()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3DD7D00", Offset = "0x3DD6700", VA = "0x183DD7D00", Slot = "4")]
	public bool Equals(DHLFHOCNJLN CGDFJMJIABO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3DD78B0", Offset = "0x3DD62B0", VA = "0x183DD78B0", Slot = "5")]
	public int CompareTo(DHLFHOCNJLN CGDFJMJIABO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x66385A0", Offset = "0x6636FA0", VA = "0x1866385A0", Slot = "0")]
	public override bool Equals(object GKNPKJAGNGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3DD7990", Offset = "0x3DD6390", VA = "0x183DD7990", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3DD7D00", Offset = "0x3DD6700", VA = "0x183DD7D00")]
	public static bool JGKBBKJJNFA(DHLFHOCNJLN GHGBJDGFDKJ, DHLFHOCNJLN PHPPILHFFME)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6638500", Offset = "0x6636F00", VA = "0x186638500")]
	public static bool GOKPCPODMCO(DHLFHOCNJLN GHGBJDGFDKJ, DHLFHOCNJLN PHPPILHFFME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6638640", Offset = "0x6637040", VA = "0x186638640", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct PAHDNPHKCJJ : IEquatable<PAHDNPHKCJJ>, IComparable<PAHDNPHKCJJ>, LBKHMHDHHFA
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly PAHDNPHKCJJ DPEMCFFPABG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Guid DMMBGEACBPP;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1D18170", Offset = "0x1D16B70", VA = "0x181D18170")]
	public PAHDNPHKCJJ(Guid DMMBGEACBPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7F92D0", Offset = "0x7F7CD0", VA = "0x1807F92D0", Slot = "6")]
	public Guid PLCAAILKEAB()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3DD7D00", Offset = "0x3DD6700", VA = "0x183DD7D00", Slot = "4")]
	public bool Equals(PAHDNPHKCJJ CGDFJMJIABO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3DD78B0", Offset = "0x3DD62B0", VA = "0x183DD78B0", Slot = "5")]
	public int CompareTo(PAHDNPHKCJJ CGDFJMJIABO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x66394B0", Offset = "0x6637EB0", VA = "0x1866394B0", Slot = "0")]
	public override bool Equals(object GKNPKJAGNGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3DD7990", Offset = "0x3DD6390", VA = "0x183DD7990", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3DD7D00", Offset = "0x3DD6700", VA = "0x183DD7D00")]
	public static bool JGKBBKJJNFA(PAHDNPHKCJJ GHGBJDGFDKJ, PAHDNPHKCJJ PHPPILHFFME)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6638500", Offset = "0x6636F00", VA = "0x186638500")]
	public static bool GOKPCPODMCO(PAHDNPHKCJJ GHGBJDGFDKJ, PAHDNPHKCJJ PHPPILHFFME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6639550", Offset = "0x6637F50", VA = "0x186639550", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct NCENGMDHCAF : IEquatable<NCENGMDHCAF>, IComparable<NCENGMDHCAF>, LBKHMHDHHFA
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static readonly NCENGMDHCAF DPEMCFFPABG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Guid DMMBGEACBPP;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x1D18170", Offset = "0x1D16B70", VA = "0x181D18170")]
	public NCENGMDHCAF(Guid DMMBGEACBPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7F92D0", Offset = "0x7F7CD0", VA = "0x1807F92D0", Slot = "6")]
	public Guid PLCAAILKEAB()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3DD7D00", Offset = "0x3DD6700", VA = "0x183DD7D00", Slot = "4")]
	public bool Equals(NCENGMDHCAF CGDFJMJIABO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3DD78B0", Offset = "0x3DD62B0", VA = "0x183DD78B0", Slot = "5")]
	public int CompareTo(NCENGMDHCAF CGDFJMJIABO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6639210", Offset = "0x6637C10", VA = "0x186639210", Slot = "0")]
	public override bool Equals(object GKNPKJAGNGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3DD7990", Offset = "0x3DD6390", VA = "0x183DD7990", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3DD7D00", Offset = "0x3DD6700", VA = "0x183DD7D00")]
	public static bool JGKBBKJJNFA(NCENGMDHCAF GHGBJDGFDKJ, NCENGMDHCAF PHPPILHFFME)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6638500", Offset = "0x6636F00", VA = "0x186638500")]
	public static bool GOKPCPODMCO(NCENGMDHCAF GHGBJDGFDKJ, NCENGMDHCAF PHPPILHFFME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x66392B0", Offset = "0x6637CB0", VA = "0x1866392B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct NOOHJJBPINN : IEquatable<NOOHJJBPINN>, IComparable<NOOHJJBPINN>, LBKHMHDHHFA
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static readonly NOOHJJBPINN DPEMCFFPABG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly Guid DMMBGEACBPP;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1D18170", Offset = "0x1D16B70", VA = "0x181D18170")]
	public NOOHJJBPINN(Guid DMMBGEACBPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7F92D0", Offset = "0x7F7CD0", VA = "0x1807F92D0", Slot = "6")]
	public Guid PLCAAILKEAB()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3DD7D00", Offset = "0x3DD6700", VA = "0x183DD7D00", Slot = "4")]
	public bool Equals(NOOHJJBPINN CGDFJMJIABO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3DD78B0", Offset = "0x3DD62B0", VA = "0x183DD78B0", Slot = "5")]
	public int CompareTo(NOOHJJBPINN CGDFJMJIABO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6639320", Offset = "0x6637D20", VA = "0x186639320", Slot = "0")]
	public override bool Equals(object GKNPKJAGNGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3DD7990", Offset = "0x3DD6390", VA = "0x183DD7990", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3DD7D00", Offset = "0x3DD6700", VA = "0x183DD7D00")]
	public static bool JGKBBKJJNFA(NOOHJJBPINN GHGBJDGFDKJ, NOOHJJBPINN PHPPILHFFME)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6638500", Offset = "0x6636F00", VA = "0x186638500")]
	public static bool GOKPCPODMCO(NOOHJJBPINN GHGBJDGFDKJ, NOOHJJBPINN PHPPILHFFME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x66393C0", Offset = "0x6637DC0", VA = "0x1866393C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct MFFBCFFFMIJ : IEquatable<MFFBCFFFMIJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly string?[]? JFFFPIGLOLN;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool KBMKICIKMEP
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6638AD0", Offset = "0x66374D0", VA = "0x186638AD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int CJIBFHKNEKF
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x3C24DF0", Offset = "0x3C237F0", VA = "0x183C24DF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6639050", Offset = "0x6637A50", VA = "0x186639050")]
	public MFFBCFFFMIJ(string? AHFEGELIBOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6639190", Offset = "0x6637B90", VA = "0x186639190")]
	public MFFBCFFFMIJ(string?[] KHAMDGGAHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6638D30", Offset = "0x6637730", VA = "0x186638D30")]
	private static string?[]? IBKFLBGDPED(string?[]? KHAMDGGAHKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6638F60", Offset = "0x6637960", VA = "0x186638F60")]
	public string OOONBIHKAOM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6638AF0", Offset = "0x66374F0", VA = "0x186638AF0", Slot = "4")]
	public bool Equals(MFFBCFFFMIJ CGDFJMJIABO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6638BC0", Offset = "0x66375C0", VA = "0x186638BC0", Slot = "0")]
	public override bool Equals(object GKNPKJAGNGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6638C50", Offset = "0x6637650", VA = "0x186638C50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6638FC0", Offset = "0x66379C0", VA = "0x186638FC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct ABKJACHDCEH : IEquatable<ABKJACHDCEH>, IComparable<ABKJACHDCEH>, LBKHMHDHHFA
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly ABKJACHDCEH DPEMCFFPABG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Guid DMMBGEACBPP;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1D18170", Offset = "0x1D16B70", VA = "0x181D18170")]
	public ABKJACHDCEH(Guid DMMBGEACBPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7F92D0", Offset = "0x7F7CD0", VA = "0x1807F92D0", Slot = "6")]
	public Guid PLCAAILKEAB()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3DD7D00", Offset = "0x3DD6700", VA = "0x183DD7D00", Slot = "4")]
	public bool Equals(ABKJACHDCEH CGDFJMJIABO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3DD78B0", Offset = "0x3DD62B0", VA = "0x183DD78B0", Slot = "5")]
	public int CompareTo(ABKJACHDCEH CGDFJMJIABO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6637970", Offset = "0x6636370", VA = "0x186637970", Slot = "0")]
	public override bool Equals(object GKNPKJAGNGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3DD7990", Offset = "0x3DD6390", VA = "0x183DD7990", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3DD7D00", Offset = "0x3DD6700", VA = "0x183DD7D00")]
	public static bool JGKBBKJJNFA(ABKJACHDCEH GHGBJDGFDKJ, ABKJACHDCEH PHPPILHFFME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6637A10", Offset = "0x6636410", VA = "0x186637A10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct DGENLFMDAHN : IEquatable<DGENLFMDAHN>, IComparable<DGENLFMDAHN>, LBKHMHDHHFA
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly DGENLFMDAHN DPEMCFFPABG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly Guid DMMBGEACBPP;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1D18170", Offset = "0x1D16B70", VA = "0x181D18170")]
	public DGENLFMDAHN(Guid DMMBGEACBPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7F92D0", Offset = "0x7F7CD0", VA = "0x1807F92D0", Slot = "6")]
	public Guid PLCAAILKEAB()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3DD7D00", Offset = "0x3DD6700", VA = "0x183DD7D00", Slot = "4")]
	public bool Equals(DGENLFMDAHN CGDFJMJIABO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3DD78B0", Offset = "0x3DD62B0", VA = "0x183DD78B0", Slot = "5")]
	public int CompareTo(DGENLFMDAHN CGDFJMJIABO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6638460", Offset = "0x6636E60", VA = "0x186638460", Slot = "0")]
	public override bool Equals(object GKNPKJAGNGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3DD7990", Offset = "0x3DD6390", VA = "0x183DD7990", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6638500", Offset = "0x6636F00", VA = "0x186638500")]
	public static bool GOKPCPODMCO(DGENLFMDAHN GHGBJDGFDKJ, DGENLFMDAHN PHPPILHFFME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6638530", Offset = "0x6636F30", VA = "0x186638530", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface DHGPPPAEMPD<TModern> : JGNDAEGANEL<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string IAHFHKHIJIH(TModern IGGHIBIPKNP);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface LBKHMHDHHFA
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Guid PLCAAILKEAB();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface JGNDAEGANEL<out TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TModern NCIAIPDIHCG(string IGGHIBIPKNP);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface GOBHNINCLDO
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	DHGPPPAEMPD<KFFIPGPICBA> FJCCLJPDLBP
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	DHGPPPAEMPD<DHLFHOCNJLN> EHLBNFBEKFM
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	DHGPPPAEMPD<NOOHJJBPINN> NOKMNKAPMEP
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	DHGPPPAEMPD<PMEHEMKJJKD> GHCCGFBAIKH
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	DHGPPPAEMPD<LDDIEGIGADA> JHOBFAPJJPI
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	DHGPPPAEMPD<NCENGMDHCAF> GCHLIPLAEJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	DHGPPPAEMPD<KFCBMNELBDJ> NPCMGIGEOJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	DHGPPPAEMPD<PAHDNPHKCJJ> JPGJCMFOEIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class KOCPEMAEDDM
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6638900", Offset = "0x6637300", VA = "0x186638900")]
	public static string[] HEIJPAKDKMH(string? AHFEGELIBOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x66388D0", Offset = "0x66372D0", VA = "0x1866388D0")]
	public static string? DBICOLMOFAO(string? KGALHPOKBNM)
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
