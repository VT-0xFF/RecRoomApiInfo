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
		[Cpp2IlInjected.Address(RVA = "0x8DF890", Offset = "0x8DE890", VA = "0x1808DF890")]
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
		[Cpp2IlInjected.Address(RVA = "0x75F0470", Offset = "0x75EF470", VA = "0x1875F0470")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8E0550", Offset = "0x8DF550", VA = "0x1808E0550")]
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
		[Cpp2IlInjected.Address(RVA = "0x8E0590", Offset = "0x8DF590", VA = "0x1808E0590")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface IFDPIODEBNC
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string EKFEJLFJOKC(MMDGIABAHDI EDAMLOGMMEK);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MMDGIABAHDI OGCNNFLPKKP(string EDAMLOGMMEK);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct MMDGIABAHDI : IEquatable<MMDGIABAHDI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly IOFOCLGJBKE ILCNBPPNFLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly BEFENALLNEP LCIOFABMGPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly Guid LDILKCMHIOE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool FKFLOEAKHCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x75EFF10", Offset = "0x75EEF10", VA = "0x1875EFF10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool CCLJAIENBPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x75EFFA0", Offset = "0x75EEFA0", VA = "0x1875EFFA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x75F0340", Offset = "0x75EF340", VA = "0x1875F0340")]
	public MMDGIABAHDI(MMDGIABAHDI MDJGCPBOHKF, [Optional] Guid OPIHNJMKJBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5113390", Offset = "0x5112390", VA = "0x185113390")]
	public MMDGIABAHDI(IOFOCLGJBKE OLPKPFAKBOD, BEFENALLNEP AKENLIPJGPF, [Optional] Guid OPIHNJMKJBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x75EFD10", Offset = "0x75EED10", VA = "0x1875EFD10", Slot = "4")]
	public bool Equals(MMDGIABAHDI DFABCHNPEEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x75EFDD0", Offset = "0x75EEDD0", VA = "0x1875EFDD0", Slot = "0")]
	public override bool Equals(object IFPBFCLBBDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x75EFE80", Offset = "0x75EEE80", VA = "0x1875EFE80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x75EFFD0", Offset = "0x75EEFD0", VA = "0x1875EFFD0")]
	public static bool LJMKDDBNEAO(MMDGIABAHDI GGEOEEJGPGH, MMDGIABAHDI OLIPOMNIFIH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x75F0000", Offset = "0x75EF000", VA = "0x1875F0000")]
	public static bool MCPOKKIFBCL(MMDGIABAHDI GGEOEEJGPGH, MMDGIABAHDI OLIPOMNIFIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x75F0040", Offset = "0x75EF040", VA = "0x1875F0040", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct IOFOCLGJBKE : IEquatable<IOFOCLGJBKE>, IComparable<IOFOCLGJBKE>, PACINHNAFHD
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly IOFOCLGJBKE BOAMOHHEBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Guid EEKOILIMLBO;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0xDC76F0", Offset = "0xDC66F0", VA = "0x180DC76F0")]
	public IOFOCLGJBKE(Guid EEKOILIMLBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0xDC7700", Offset = "0xDC6700", VA = "0x180DC7700", Slot = "6")]
	public Guid IACKPLLKMIL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x416A1C0", Offset = "0x41691C0", VA = "0x18416A1C0", Slot = "4")]
	public bool Equals(IOFOCLGJBKE DFABCHNPEEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4169CC0", Offset = "0x4168CC0", VA = "0x184169CC0", Slot = "5")]
	public int CompareTo(IOFOCLGJBKE DFABCHNPEEM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x75EF770", Offset = "0x75EE770", VA = "0x1875EF770", Slot = "0")]
	public override bool Equals(object IFPBFCLBBDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x416A0B0", Offset = "0x41690B0", VA = "0x18416A0B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x416A1C0", Offset = "0x41691C0", VA = "0x18416A1C0")]
	public static bool LJMKDDBNEAO(IOFOCLGJBKE GGEOEEJGPGH, IOFOCLGJBKE OLIPOMNIFIH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x75EED60", Offset = "0x75EDD60", VA = "0x1875EED60")]
	public static bool MCPOKKIFBCL(IOFOCLGJBKE GGEOEEJGPGH, IOFOCLGJBKE OLIPOMNIFIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x75EF810", Offset = "0x75EE810", VA = "0x1875EF810", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct LAAGBDBIFCE : IEquatable<LAAGBDBIFCE>, IComparable<LAAGBDBIFCE>, PACINHNAFHD
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static readonly LAAGBDBIFCE BOAMOHHEBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Guid EEKOILIMLBO;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xDC76F0", Offset = "0xDC66F0", VA = "0x180DC76F0")]
	public LAAGBDBIFCE(Guid EEKOILIMLBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0xDC7700", Offset = "0xDC6700", VA = "0x180DC7700", Slot = "6")]
	public Guid IACKPLLKMIL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x416A1C0", Offset = "0x41691C0", VA = "0x18416A1C0", Slot = "4")]
	public bool Equals(LAAGBDBIFCE DFABCHNPEEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4169CC0", Offset = "0x4168CC0", VA = "0x184169CC0", Slot = "5")]
	public int CompareTo(LAAGBDBIFCE DFABCHNPEEM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x75EF9E0", Offset = "0x75EE9E0", VA = "0x1875EF9E0", Slot = "0")]
	public override bool Equals(object IFPBFCLBBDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x416A0B0", Offset = "0x41690B0", VA = "0x18416A0B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x416A1C0", Offset = "0x41691C0", VA = "0x18416A1C0")]
	public static bool LJMKDDBNEAO(LAAGBDBIFCE GGEOEEJGPGH, LAAGBDBIFCE OLIPOMNIFIH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x75EED60", Offset = "0x75EDD60", VA = "0x1875EED60")]
	public static bool MCPOKKIFBCL(LAAGBDBIFCE GGEOEEJGPGH, LAAGBDBIFCE OLIPOMNIFIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x75EFA80", Offset = "0x75EEA80", VA = "0x1875EFA80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct LHADLCKBALK : IEquatable<LHADLCKBALK>, IComparable<LHADLCKBALK>, PACINHNAFHD
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public static readonly LHADLCKBALK BOAMOHHEBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Guid EEKOILIMLBO;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0xDC76F0", Offset = "0xDC66F0", VA = "0x180DC76F0")]
	public LHADLCKBALK(Guid EEKOILIMLBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0xDC7700", Offset = "0xDC6700", VA = "0x180DC7700", Slot = "6")]
	public Guid IACKPLLKMIL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x416A1C0", Offset = "0x41691C0", VA = "0x18416A1C0", Slot = "4")]
	public bool Equals(LHADLCKBALK DFABCHNPEEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4169CC0", Offset = "0x4168CC0", VA = "0x184169CC0", Slot = "5")]
	public int CompareTo(LHADLCKBALK DFABCHNPEEM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x75EFAF0", Offset = "0x75EEAF0", VA = "0x1875EFAF0", Slot = "0")]
	public override bool Equals(object IFPBFCLBBDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x416A0B0", Offset = "0x41690B0", VA = "0x18416A0B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x416A1C0", Offset = "0x41691C0", VA = "0x18416A1C0")]
	public static bool LJMKDDBNEAO(LHADLCKBALK GGEOEEJGPGH, LHADLCKBALK OLIPOMNIFIH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x75EED60", Offset = "0x75EDD60", VA = "0x1875EED60")]
	public static bool MCPOKKIFBCL(LHADLCKBALK GGEOEEJGPGH, LHADLCKBALK OLIPOMNIFIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x75EFB90", Offset = "0x75EEB90", VA = "0x1875EFB90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct BEFENALLNEP : IEquatable<BEFENALLNEP>, IComparable<BEFENALLNEP>, PACINHNAFHD
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly BEFENALLNEP BOAMOHHEBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Guid EEKOILIMLBO;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0xDC76F0", Offset = "0xDC66F0", VA = "0x180DC76F0")]
	public BEFENALLNEP(Guid EEKOILIMLBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0xDC7700", Offset = "0xDC6700", VA = "0x180DC7700", Slot = "6")]
	public Guid IACKPLLKMIL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x75EEB50", Offset = "0x75EDB50", VA = "0x1875EEB50", Slot = "4")]
	public bool Equals(BEFENALLNEP DFABCHNPEEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x75EEB80", Offset = "0x75EDB80", VA = "0x1875EEB80", Slot = "0")]
	public override bool Equals(object IFPBFCLBBDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x416A0B0", Offset = "0x41690B0", VA = "0x18416A0B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x75EEB50", Offset = "0x75EDB50", VA = "0x1875EEB50")]
	public static bool LJMKDDBNEAO(BEFENALLNEP GGEOEEJGPGH, BEFENALLNEP OLIPOMNIFIH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x75EEC20", Offset = "0x75EDC20", VA = "0x1875EEC20")]
	public static bool MCPOKKIFBCL(BEFENALLNEP GGEOEEJGPGH, BEFENALLNEP OLIPOMNIFIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4169CC0", Offset = "0x4168CC0", VA = "0x184169CC0", Slot = "5")]
	public int CompareTo(BEFENALLNEP DFABCHNPEEM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x75EEC50", Offset = "0x75EDC50", VA = "0x1875EEC50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0xDC76F0", Offset = "0xDC66F0", VA = "0x180DC76F0")]
	public BEFENALLNEP(ICCKNJPMFGP NNENPACPBCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct LOEDIDEPMAK : IEquatable<LOEDIDEPMAK>, IComparable<LOEDIDEPMAK>, PACINHNAFHD
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly LOEDIDEPMAK BOAMOHHEBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Guid EEKOILIMLBO;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0xDC76F0", Offset = "0xDC66F0", VA = "0x180DC76F0")]
	public LOEDIDEPMAK(Guid EEKOILIMLBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0xDC7700", Offset = "0xDC6700", VA = "0x180DC7700", Slot = "6")]
	public Guid IACKPLLKMIL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x416A1C0", Offset = "0x41691C0", VA = "0x18416A1C0", Slot = "4")]
	public bool Equals(LOEDIDEPMAK DFABCHNPEEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4169CC0", Offset = "0x4168CC0", VA = "0x184169CC0", Slot = "5")]
	public int CompareTo(LOEDIDEPMAK DFABCHNPEEM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x75EFC00", Offset = "0x75EEC00", VA = "0x1875EFC00", Slot = "0")]
	public override bool Equals(object IFPBFCLBBDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x416A0B0", Offset = "0x41690B0", VA = "0x18416A0B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x416A1C0", Offset = "0x41691C0", VA = "0x18416A1C0")]
	public static bool LJMKDDBNEAO(LOEDIDEPMAK GGEOEEJGPGH, LOEDIDEPMAK OLIPOMNIFIH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x75EED60", Offset = "0x75EDD60", VA = "0x1875EED60")]
	public static bool MCPOKKIFBCL(LOEDIDEPMAK GGEOEEJGPGH, LOEDIDEPMAK OLIPOMNIFIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x75EFCA0", Offset = "0x75EECA0", VA = "0x1875EFCA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct CEHCJOLGKJG : IEquatable<CEHCJOLGKJG>, IComparable<CEHCJOLGKJG>, PACINHNAFHD
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly CEHCJOLGKJG BOAMOHHEBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Guid EEKOILIMLBO;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xDC76F0", Offset = "0xDC66F0", VA = "0x180DC76F0")]
	public CEHCJOLGKJG(Guid EEKOILIMLBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0xDC7700", Offset = "0xDC6700", VA = "0x180DC7700", Slot = "6")]
	public Guid IACKPLLKMIL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x416A1C0", Offset = "0x41691C0", VA = "0x18416A1C0", Slot = "4")]
	public bool Equals(CEHCJOLGKJG DFABCHNPEEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4169CC0", Offset = "0x4168CC0", VA = "0x184169CC0", Slot = "5")]
	public int CompareTo(CEHCJOLGKJG DFABCHNPEEM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x75EECC0", Offset = "0x75EDCC0", VA = "0x1875EECC0", Slot = "0")]
	public override bool Equals(object IFPBFCLBBDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x416A0B0", Offset = "0x41690B0", VA = "0x18416A0B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x416A1C0", Offset = "0x41691C0", VA = "0x18416A1C0")]
	public static bool LJMKDDBNEAO(CEHCJOLGKJG GGEOEEJGPGH, CEHCJOLGKJG OLIPOMNIFIH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x75EED60", Offset = "0x75EDD60", VA = "0x1875EED60")]
	public static bool MCPOKKIFBCL(CEHCJOLGKJG GGEOEEJGPGH, CEHCJOLGKJG OLIPOMNIFIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x75EED90", Offset = "0x75EDD90", VA = "0x1875EED90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct NEANNCABPBL : IEquatable<NEANNCABPBL>, IComparable<NEANNCABPBL>, PACINHNAFHD
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly NEANNCABPBL BOAMOHHEBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Guid EEKOILIMLBO;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0xDC76F0", Offset = "0xDC66F0", VA = "0x180DC76F0")]
	public NEANNCABPBL(Guid EEKOILIMLBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0xDC7700", Offset = "0xDC6700", VA = "0x180DC7700", Slot = "6")]
	public Guid IACKPLLKMIL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x416A1C0", Offset = "0x41691C0", VA = "0x18416A1C0", Slot = "4")]
	public bool Equals(NEANNCABPBL DFABCHNPEEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4169CC0", Offset = "0x4168CC0", VA = "0x184169CC0", Slot = "5")]
	public int CompareTo(NEANNCABPBL DFABCHNPEEM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x75F0360", Offset = "0x75EF360", VA = "0x1875F0360", Slot = "0")]
	public override bool Equals(object IFPBFCLBBDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x416A0B0", Offset = "0x41690B0", VA = "0x18416A0B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x416A1C0", Offset = "0x41691C0", VA = "0x18416A1C0")]
	public static bool LJMKDDBNEAO(NEANNCABPBL GGEOEEJGPGH, NEANNCABPBL OLIPOMNIFIH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x75EED60", Offset = "0x75EDD60", VA = "0x1875EED60")]
	public static bool MCPOKKIFBCL(NEANNCABPBL GGEOEEJGPGH, NEANNCABPBL OLIPOMNIFIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x75F0400", Offset = "0x75EF400", VA = "0x1875F0400", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct GGBIONBNLAB : IEquatable<GGBIONBNLAB>, IComparable<GGBIONBNLAB>, PACINHNAFHD
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly GGBIONBNLAB BOAMOHHEBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Guid EEKOILIMLBO;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0xDC76F0", Offset = "0xDC66F0", VA = "0x180DC76F0")]
	public GGBIONBNLAB(Guid EEKOILIMLBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0xDC7700", Offset = "0xDC6700", VA = "0x180DC7700", Slot = "6")]
	public Guid IACKPLLKMIL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x416A1C0", Offset = "0x41691C0", VA = "0x18416A1C0", Slot = "4")]
	public bool Equals(GGBIONBNLAB DFABCHNPEEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x4169CC0", Offset = "0x4168CC0", VA = "0x184169CC0", Slot = "5")]
	public int CompareTo(GGBIONBNLAB DFABCHNPEEM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x75EF550", Offset = "0x75EE550", VA = "0x1875EF550", Slot = "0")]
	public override bool Equals(object IFPBFCLBBDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x416A0B0", Offset = "0x41690B0", VA = "0x18416A0B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x416A1C0", Offset = "0x41691C0", VA = "0x18416A1C0")]
	public static bool LJMKDDBNEAO(GGBIONBNLAB GGEOEEJGPGH, GGBIONBNLAB OLIPOMNIFIH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x75EED60", Offset = "0x75EDD60", VA = "0x1875EED60")]
	public static bool MCPOKKIFBCL(GGBIONBNLAB GGEOEEJGPGH, GGBIONBNLAB OLIPOMNIFIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x75EF5F0", Offset = "0x75EE5F0", VA = "0x1875EF5F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct FKLOMFJFNCB : IEquatable<FKLOMFJFNCB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly string?[]? LDOJGPLDFJK;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool DCLLIFLPMLP
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x75EEE00", Offset = "0x75EDE00", VA = "0x1875EEE00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int AMCILKBGAEN
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x472DA00", Offset = "0x472CA00", VA = "0x18472DA00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x75EF380", Offset = "0x75EE380", VA = "0x1875EF380")]
	public FKLOMFJFNCB(string? MOPMLPMHKFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x75EF4D0", Offset = "0x75EE4D0", VA = "0x1875EF4D0")]
	public FKLOMFJFNCB(string?[] COLFCEBPMMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x75EF0C0", Offset = "0x75EE0C0", VA = "0x1875EF0C0")]
	private static string?[]? LAOCGDKJBON(string?[]? COLFCEBPMMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x75EEE20", Offset = "0x75EDE20", VA = "0x1875EEE20")]
	public string DDLNGAJDNKE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x75EEE80", Offset = "0x75EDE80", VA = "0x1875EEE80", Slot = "4")]
	public bool Equals(FKLOMFJFNCB DFABCHNPEEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x75EEF50", Offset = "0x75EDF50", VA = "0x1875EEF50", Slot = "0")]
	public override bool Equals(object IFPBFCLBBDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x75EEFE0", Offset = "0x75EDFE0", VA = "0x1875EEFE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x75EF2F0", Offset = "0x75EE2F0", VA = "0x1875EF2F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct ICCKNJPMFGP : IEquatable<ICCKNJPMFGP>, IComparable<ICCKNJPMFGP>, PACINHNAFHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Guid EEKOILIMLBO;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xDC76F0", Offset = "0xDC66F0", VA = "0x180DC76F0")]
	public ICCKNJPMFGP(Guid EEKOILIMLBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xDC7700", Offset = "0xDC6700", VA = "0x180DC7700", Slot = "6")]
	public Guid IACKPLLKMIL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x416A1C0", Offset = "0x41691C0", VA = "0x18416A1C0", Slot = "4")]
	public bool Equals(ICCKNJPMFGP DFABCHNPEEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x4169CC0", Offset = "0x4168CC0", VA = "0x184169CC0", Slot = "5")]
	public int CompareTo(ICCKNJPMFGP DFABCHNPEEM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x75EF660", Offset = "0x75EE660", VA = "0x1875EF660", Slot = "0")]
	public override bool Equals(object IFPBFCLBBDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x416A0B0", Offset = "0x41690B0", VA = "0x18416A0B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x75EF700", Offset = "0x75EE700", VA = "0x1875EF700", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface JMKEPDKLDNL<TModern> : EBHOHPLBABB<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string JJIJNDGFGHD(TModern NBMPOJFDLGC);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface PACINHNAFHD
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Guid IACKPLLKMIL();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface EBHOHPLBABB<out TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TModern APENNHHLPFO(string NBMPOJFDLGC);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface KDABCBFBNHH
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	JMKEPDKLDNL<IOFOCLGJBKE> MBHLMDHIFOP
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	JMKEPDKLDNL<LOEDIDEPMAK> BPHDMFJJHJH
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	JMKEPDKLDNL<GGBIONBNLAB> NEHHGLADJGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	JMKEPDKLDNL<BEFENALLNEP> GNOBODCAICA
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	JMKEPDKLDNL<LHADLCKBALK> EDBFHMJGOFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	JMKEPDKLDNL<NEANNCABPBL> DIENBDDNNNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	JMKEPDKLDNL<LAAGBDBIFCE> OIPFABHKMDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	JMKEPDKLDNL<CEHCJOLGKJG> MEDLCDAJCLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class KGMOLKNBAAI
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static readonly char[] MBAOJFOPNGE;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x75EF8B0", Offset = "0x75EE8B0", VA = "0x1875EF8B0")]
	public static string[] PIIBJNBJKHE(string? MOPMLPMHKFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x75EF880", Offset = "0x75EE880", VA = "0x1875EF880")]
	public static string? EBDOBABLMFM(string? OLPKPFAKBOD)
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
