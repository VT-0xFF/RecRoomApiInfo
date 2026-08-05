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
		[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A824C0", Offset = "0x8A814C0", VA = "0x188A824C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA8B7C0", Offset = "0xA8A7C0", VA = "0x180A8B7C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA8B800", Offset = "0xA8A800", VA = "0x180A8B800")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface CLNKPHMDENM
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string FBGBLPHHDGN(NPHONPGHNPF JMJJABEKOFI);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NPHONPGHNPF LABNBGADOBH(string JMJJABEKOFI);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct NPHONPGHNPF : IEquatable<NPHONPGHNPF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly ENEJMMGDILI NJPDBAHKIKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly GLNFCDOGKEH MILLADPGFHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly Guid ELCENCJKGLD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool NHEAKGPEACA
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8A820D0", Offset = "0x8A810D0", VA = "0x188A820D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool ABHPDDLPKMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8A81EA0", Offset = "0x8A80EA0", VA = "0x188A81EA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8A824A0", Offset = "0x8A814A0", VA = "0x188A824A0")]
	public NPHONPGHNPF(NPHONPGHNPF JGNPOLOCLNN, [Optional] Guid GKOPHJCJIFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x60740D0", Offset = "0x60730D0", VA = "0x1860740D0")]
	public NPHONPGHNPF(ENEJMMGDILI LBCLDJLEFBH, GLNFCDOGKEH CHIAGPGHDOI, [Optional] Guid GKOPHJCJIFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8A81ED0", Offset = "0x8A80ED0", VA = "0x188A81ED0", Slot = "4")]
	public bool Equals(NPHONPGHNPF EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8A81F90", Offset = "0x8A80F90", VA = "0x188A81F90", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8A82040", Offset = "0x8A81040", VA = "0x188A82040", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8A82160", Offset = "0x8A81160", VA = "0x188A82160")]
	public static bool PHGIAKEDBEK(NPHONPGHNPF AKPAAKDLPCB, NPHONPGHNPF AIKJCCNDBKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8A82190", Offset = "0x8A81190", VA = "0x188A82190", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct ENEJMMGDILI : IEquatable<ENEJMMGDILI>, IComparable<ENEJMMGDILI>, HLNHJFLKOLN
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly ENEJMMGDILI JBLEAIPIMOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Guid JFLBGDIIGHK;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x14395A0", Offset = "0x14385A0", VA = "0x1814395A0")]
	public ENEJMMGDILI(Guid JFLBGDIIGHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x11FD630", Offset = "0x11FC630", VA = "0x1811FD630", Slot = "6")]
	public Guid DPMLIPCCHBC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x53DA9B0", Offset = "0x53D99B0", VA = "0x1853DA9B0", Slot = "4")]
	public bool Equals(ENEJMMGDILI EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x53DA6D0", Offset = "0x53D96D0", VA = "0x1853DA6D0", Slot = "5")]
	public int CompareTo(ENEJMMGDILI EDJHHGMLKFA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8A81030", Offset = "0x8A80030", VA = "0x188A81030", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x53DA900", Offset = "0x53D9900", VA = "0x1853DA900", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x53DA9B0", Offset = "0x53D99B0", VA = "0x1853DA9B0")]
	public static bool PHGIAKEDBEK(ENEJMMGDILI AKPAAKDLPCB, ENEJMMGDILI AIKJCCNDBKF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8A80C50", Offset = "0x8A7FC50", VA = "0x188A80C50")]
	public static bool BDCEBPMLGHE(ENEJMMGDILI AKPAAKDLPCB, ENEJMMGDILI AIKJCCNDBKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8A810E0", Offset = "0x8A800E0", VA = "0x188A810E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct KIGEPKPKPOM : IEquatable<KIGEPKPKPOM>, IComparable<KIGEPKPKPOM>, HLNHJFLKOLN
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static readonly KIGEPKPKPOM JBLEAIPIMOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Guid JFLBGDIIGHK;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x14395A0", Offset = "0x14385A0", VA = "0x1814395A0")]
	public KIGEPKPKPOM(Guid JFLBGDIIGHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x11FD630", Offset = "0x11FC630", VA = "0x1811FD630", Slot = "6")]
	public Guid DPMLIPCCHBC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x53DA9B0", Offset = "0x53D99B0", VA = "0x1853DA9B0", Slot = "4")]
	public bool Equals(KIGEPKPKPOM EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x53DA6D0", Offset = "0x53D96D0", VA = "0x1853DA6D0", Slot = "5")]
	public int CompareTo(KIGEPKPKPOM EDJHHGMLKFA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8A813F0", Offset = "0x8A803F0", VA = "0x188A813F0", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x53DA900", Offset = "0x53D9900", VA = "0x1853DA900", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x53DA9B0", Offset = "0x53D99B0", VA = "0x1853DA9B0")]
	public static bool PHGIAKEDBEK(KIGEPKPKPOM AKPAAKDLPCB, KIGEPKPKPOM AIKJCCNDBKF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8A80C50", Offset = "0x8A7FC50", VA = "0x188A80C50")]
	public static bool BDCEBPMLGHE(KIGEPKPKPOM AKPAAKDLPCB, KIGEPKPKPOM AIKJCCNDBKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8A814A0", Offset = "0x8A804A0", VA = "0x188A814A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct IJBOOMIFELF : IEquatable<IJBOOMIFELF>, IComparable<IJBOOMIFELF>, HLNHJFLKOLN
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public static readonly IJBOOMIFELF JBLEAIPIMOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Guid JFLBGDIIGHK;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x14395A0", Offset = "0x14385A0", VA = "0x1814395A0")]
	public IJBOOMIFELF(Guid JFLBGDIIGHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x11FD630", Offset = "0x11FC630", VA = "0x1811FD630", Slot = "6")]
	public Guid DPMLIPCCHBC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x53DA9B0", Offset = "0x53D99B0", VA = "0x1853DA9B0", Slot = "4")]
	public bool Equals(IJBOOMIFELF EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x53DA6D0", Offset = "0x53D96D0", VA = "0x1853DA6D0", Slot = "5")]
	public int CompareTo(IJBOOMIFELF EDJHHGMLKFA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8A812D0", Offset = "0x8A802D0", VA = "0x188A812D0", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x53DA900", Offset = "0x53D9900", VA = "0x1853DA900", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x53DA9B0", Offset = "0x53D99B0", VA = "0x1853DA9B0")]
	public static bool PHGIAKEDBEK(IJBOOMIFELF AKPAAKDLPCB, IJBOOMIFELF AIKJCCNDBKF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8A80C50", Offset = "0x8A7FC50", VA = "0x188A80C50")]
	public static bool BDCEBPMLGHE(IJBOOMIFELF AKPAAKDLPCB, IJBOOMIFELF AIKJCCNDBKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8A81380", Offset = "0x8A80380", VA = "0x188A81380", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct GLNFCDOGKEH : IEquatable<GLNFCDOGKEH>, IComparable<GLNFCDOGKEH>, HLNHJFLKOLN
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly GLNFCDOGKEH JBLEAIPIMOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Guid JFLBGDIIGHK;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x14395A0", Offset = "0x14385A0", VA = "0x1814395A0")]
	public GLNFCDOGKEH(Guid JFLBGDIIGHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x11FD630", Offset = "0x11FC630", VA = "0x1811FD630", Slot = "6")]
	public Guid DPMLIPCCHBC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8A81180", Offset = "0x8A80180", VA = "0x188A81180", Slot = "4")]
	public bool Equals(GLNFCDOGKEH EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8A811B0", Offset = "0x8A801B0", VA = "0x188A811B0", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x53DA900", Offset = "0x53D9900", VA = "0x1853DA900", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8A81180", Offset = "0x8A80180", VA = "0x188A81180")]
	public static bool PHGIAKEDBEK(GLNFCDOGKEH AKPAAKDLPCB, GLNFCDOGKEH AIKJCCNDBKF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8A81150", Offset = "0x8A80150", VA = "0x188A81150")]
	public static bool BDCEBPMLGHE(GLNFCDOGKEH AKPAAKDLPCB, GLNFCDOGKEH AIKJCCNDBKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x53DA6D0", Offset = "0x53D96D0", VA = "0x1853DA6D0", Slot = "5")]
	public int CompareTo(GLNFCDOGKEH EDJHHGMLKFA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8A81260", Offset = "0x8A80260", VA = "0x188A81260", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x14395A0", Offset = "0x14385A0", VA = "0x1814395A0")]
	public GLNFCDOGKEH(ANDDDIIPGEC BMMEGBGADMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct PDGOAELHCJG : IEquatable<PDGOAELHCJG>, IComparable<PDGOAELHCJG>, HLNHJFLKOLN
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly PDGOAELHCJG JBLEAIPIMOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Guid JFLBGDIIGHK;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x14395A0", Offset = "0x14385A0", VA = "0x1814395A0")]
	public PDGOAELHCJG(Guid JFLBGDIIGHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x11FD630", Offset = "0x11FC630", VA = "0x1811FD630", Slot = "6")]
	public Guid DPMLIPCCHBC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x53DA9B0", Offset = "0x53D99B0", VA = "0x1853DA9B0", Slot = "4")]
	public bool Equals(PDGOAELHCJG EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x53DA6D0", Offset = "0x53D96D0", VA = "0x1853DA6D0", Slot = "5")]
	public int CompareTo(PDGOAELHCJG EDJHHGMLKFA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x8A82540", Offset = "0x8A81540", VA = "0x188A82540", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x53DA900", Offset = "0x53D9900", VA = "0x1853DA900", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x53DA9B0", Offset = "0x53D99B0", VA = "0x1853DA9B0")]
	public static bool PHGIAKEDBEK(PDGOAELHCJG AKPAAKDLPCB, PDGOAELHCJG AIKJCCNDBKF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x8A80C50", Offset = "0x8A7FC50", VA = "0x188A80C50")]
	public static bool BDCEBPMLGHE(PDGOAELHCJG AKPAAKDLPCB, PDGOAELHCJG AIKJCCNDBKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8A825F0", Offset = "0x8A815F0", VA = "0x188A825F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct AHAMFIMFGBH : IEquatable<AHAMFIMFGBH>, IComparable<AHAMFIMFGBH>, HLNHJFLKOLN
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly AHAMFIMFGBH JBLEAIPIMOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Guid JFLBGDIIGHK;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x14395A0", Offset = "0x14385A0", VA = "0x1814395A0")]
	public AHAMFIMFGBH(Guid JFLBGDIIGHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x11FD630", Offset = "0x11FC630", VA = "0x1811FD630", Slot = "6")]
	public Guid DPMLIPCCHBC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x53DA9B0", Offset = "0x53D99B0", VA = "0x1853DA9B0", Slot = "4")]
	public bool Equals(AHAMFIMFGBH EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x53DA6D0", Offset = "0x53D96D0", VA = "0x1853DA6D0", Slot = "5")]
	public int CompareTo(AHAMFIMFGBH EDJHHGMLKFA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8A80C80", Offset = "0x8A7FC80", VA = "0x188A80C80", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x53DA900", Offset = "0x53D9900", VA = "0x1853DA900", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x53DA9B0", Offset = "0x53D99B0", VA = "0x1853DA9B0")]
	public static bool PHGIAKEDBEK(AHAMFIMFGBH AKPAAKDLPCB, AHAMFIMFGBH AIKJCCNDBKF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8A80C50", Offset = "0x8A7FC50", VA = "0x188A80C50")]
	public static bool BDCEBPMLGHE(AHAMFIMFGBH AKPAAKDLPCB, AHAMFIMFGBH AIKJCCNDBKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8A80D30", Offset = "0x8A7FD30", VA = "0x188A80D30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct LKCHCONINKK : IEquatable<LKCHCONINKK>, IComparable<LKCHCONINKK>, HLNHJFLKOLN
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly LKCHCONINKK JBLEAIPIMOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Guid JFLBGDIIGHK;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x14395A0", Offset = "0x14385A0", VA = "0x1814395A0")]
	public LKCHCONINKK(Guid JFLBGDIIGHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x11FD630", Offset = "0x11FC630", VA = "0x1811FD630", Slot = "6")]
	public Guid DPMLIPCCHBC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x53DA9B0", Offset = "0x53D99B0", VA = "0x1853DA9B0", Slot = "4")]
	public bool Equals(LKCHCONINKK EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x53DA6D0", Offset = "0x53D96D0", VA = "0x1853DA6D0", Slot = "5")]
	public int CompareTo(LKCHCONINKK EDJHHGMLKFA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8A81C60", Offset = "0x8A80C60", VA = "0x188A81C60", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x53DA900", Offset = "0x53D9900", VA = "0x1853DA900", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x53DA9B0", Offset = "0x53D99B0", VA = "0x1853DA9B0")]
	public static bool PHGIAKEDBEK(LKCHCONINKK AKPAAKDLPCB, LKCHCONINKK AIKJCCNDBKF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x8A80C50", Offset = "0x8A7FC50", VA = "0x188A80C50")]
	public static bool BDCEBPMLGHE(LKCHCONINKK AKPAAKDLPCB, LKCHCONINKK AIKJCCNDBKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x8A81D10", Offset = "0x8A80D10", VA = "0x188A81D10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct MKCPMMMEAMC : IEquatable<MKCPMMMEAMC>, IComparable<MKCPMMMEAMC>, HLNHJFLKOLN
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly MKCPMMMEAMC JBLEAIPIMOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Guid JFLBGDIIGHK;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x14395A0", Offset = "0x14385A0", VA = "0x1814395A0")]
	public MKCPMMMEAMC(Guid JFLBGDIIGHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x11FD630", Offset = "0x11FC630", VA = "0x1811FD630", Slot = "6")]
	public Guid DPMLIPCCHBC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x53DA9B0", Offset = "0x53D99B0", VA = "0x1853DA9B0", Slot = "4")]
	public bool Equals(MKCPMMMEAMC EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x53DA6D0", Offset = "0x53D96D0", VA = "0x1853DA6D0", Slot = "5")]
	public int CompareTo(MKCPMMMEAMC EDJHHGMLKFA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x8A81D80", Offset = "0x8A80D80", VA = "0x188A81D80", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x53DA900", Offset = "0x53D9900", VA = "0x1853DA900", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x53DA9B0", Offset = "0x53D99B0", VA = "0x1853DA9B0")]
	public static bool PHGIAKEDBEK(MKCPMMMEAMC AKPAAKDLPCB, MKCPMMMEAMC AIKJCCNDBKF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x8A80C50", Offset = "0x8A7FC50", VA = "0x188A80C50")]
	public static bool BDCEBPMLGHE(MKCPMMMEAMC AKPAAKDLPCB, MKCPMMMEAMC AIKJCCNDBKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x8A81E30", Offset = "0x8A80E30", VA = "0x188A81E30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct LFGOFIAPGPE : IEquatable<LFGOFIAPGPE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly string?[]? PFJJPJMFNCF;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool BMKKEHNACIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8A81510", Offset = "0x8A80510", VA = "0x188A81510")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int FNBNNIDCHHD
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5561680", Offset = "0x5560680", VA = "0x185561680")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8A81B10", Offset = "0x8A80B10", VA = "0x188A81B10")]
	public LFGOFIAPGPE(string? PALCHHOGKML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8A81A90", Offset = "0x8A80A90", VA = "0x188A81A90")]
	public LFGOFIAPGPE(string?[] JLOLFNPLNEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8A817D0", Offset = "0x8A807D0", VA = "0x188A817D0")]
	private static string?[]? PPGHMGEKOOG(string?[]? JLOLFNPLNEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8A81770", Offset = "0x8A80770", VA = "0x188A81770")]
	public string OPHDEPMCKCO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8A81530", Offset = "0x8A80530", VA = "0x188A81530", Slot = "4")]
	public bool Equals(LFGOFIAPGPE EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8A81600", Offset = "0x8A80600", VA = "0x188A81600", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8A81690", Offset = "0x8A80690", VA = "0x188A81690", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8A81A00", Offset = "0x8A80A00", VA = "0x188A81A00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct ANDDDIIPGEC : IEquatable<ANDDDIIPGEC>, IComparable<ANDDDIIPGEC>, HLNHJFLKOLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Guid JFLBGDIIGHK;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x14395A0", Offset = "0x14385A0", VA = "0x1814395A0")]
	public ANDDDIIPGEC(Guid JFLBGDIIGHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x11FD630", Offset = "0x11FC630", VA = "0x1811FD630", Slot = "6")]
	public Guid DPMLIPCCHBC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x53DA9B0", Offset = "0x53D99B0", VA = "0x1853DA9B0", Slot = "4")]
	public bool Equals(ANDDDIIPGEC EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x53DA6D0", Offset = "0x53D96D0", VA = "0x1853DA6D0", Slot = "5")]
	public int CompareTo(ANDDDIIPGEC EDJHHGMLKFA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8A80DA0", Offset = "0x8A7FDA0", VA = "0x188A80DA0", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x53DA900", Offset = "0x53D9900", VA = "0x1853DA900", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8A80E50", Offset = "0x8A7FE50", VA = "0x188A80E50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface JOLMNCGABLL<TModern> : CNHDLIMPJGG<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string OHBFJJIPGKH(TModern PODNMEGMEOA);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface HLNHJFLKOLN
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Guid DPMLIPCCHBC();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface CNHDLIMPJGG<out TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TModern HIKCOPPDAPE(string PODNMEGMEOA);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface CAOGJAKDFBC
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	JOLMNCGABLL<ENEJMMGDILI> NCBMPIKKGJB
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	JOLMNCGABLL<PDGOAELHCJG> ECDFDJHLANH
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	JOLMNCGABLL<MKCPMMMEAMC> PALGDOHFGGG
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	JOLMNCGABLL<GLNFCDOGKEH> CDHJHEDCHGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	JOLMNCGABLL<IJBOOMIFELF> HJOOCEEKJDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	JOLMNCGABLL<LKCHCONINKK> GLCNNLMMDFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	JOLMNCGABLL<KIGEPKPKPOM> LMOBECBGMKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	JOLMNCGABLL<AHAMFIMFGBH> DKKKFBNKDHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class EMKCFPPHPPH
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static readonly char[] EFBCMOOCFHE;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8A80EC0", Offset = "0x8A7FEC0", VA = "0x188A80EC0")]
	public static string[] KGFOIILKJMC(string? PALCHHOGKML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x8A80F60", Offset = "0x8A7FF60", VA = "0x188A80F60")]
	public static string? MDPKNIEKKBO(string? LBCLDJLEFBH)
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
