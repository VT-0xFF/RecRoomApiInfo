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
		[Cpp2IlInjected.Address(RVA = "0x890970", Offset = "0x88EF70", VA = "0x180890970")]
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
		[Cpp2IlInjected.Address(RVA = "0x711B840", Offset = "0x7119E40", VA = "0x18711B840")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8917F0", Offset = "0x88FDF0", VA = "0x1808917F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x891830", Offset = "0x88FE30", VA = "0x180891830")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface JJOGMOCPBMC
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string PEGIGFCKLEH(IIGFKAAIIHK BNBKMKBLLLG);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IIGFKAAIIHK OJPHNAHFOOE(string BNBKMKBLLLG);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct IIGFKAAIIHK : IEquatable<IIGFKAAIIHK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly DIBKDMJIGJP PHGHCHFHGBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly NAJCLKBNHFG GPCPHICHMOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly Guid HMELGIIAOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly RRColor? CJINOBPNHLP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool NNFBONKILDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x711AAA0", Offset = "0x71190A0", VA = "0x18711AAA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool OBAJDBHOLGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x711ADD0", Offset = "0x71193D0", VA = "0x18711ADD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x711B2C0", Offset = "0x71198C0", VA = "0x18711B2C0")]
	public IIGFKAAIIHK(IIGFKAAIIHK KKMEGNOBBPE, [Optional] Guid OGDBLHEOKHP, [Optional] RRColor? PHHAMGLLFIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x711B230", Offset = "0x7119830", VA = "0x18711B230")]
	public IIGFKAAIIHK(DIBKDMJIGJP IJMBHINBANJ, NAJCLKBNHFG JPJACOBFIFL, [Optional] Guid OGDBLHEOKHP, [Optional] RRColor? PHHAMGLLFIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x711AB60", Offset = "0x7119160", VA = "0x18711AB60", Slot = "4")]
	public bool Equals(IIGFKAAIIHK BHFGHGMPKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x711AC10", Offset = "0x7119210", VA = "0x18711AC10", Slot = "0")]
	public override bool Equals(object NJKKPOFFNNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x711AD40", Offset = "0x7119340", VA = "0x18711AD40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x711AB60", Offset = "0x7119160", VA = "0x18711AB60")]
	public static bool FFOLOHFBIHN(IIGFKAAIIHK CLMMPLJCADB, IIGFKAAIIHK NIGNLACGOIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x711AE10", Offset = "0x7119410", VA = "0x18711AE10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct DIBKDMJIGJP : IEquatable<DIBKDMJIGJP>, IComparable<DIBKDMJIGJP>, PKCEIIEOBOB
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly DIBKDMJIGJP CHPFPNHMMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Guid IJNLNGBKEAC;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1FFBB40", Offset = "0x1FFA140", VA = "0x181FFBB40")]
	public DIBKDMJIGJP(Guid IJNLNGBKEAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x9FD0C0", Offset = "0x9FB6C0", VA = "0x1809FD0C0", Slot = "6")]
	public Guid AAIOOOLAJIF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3D8E260", Offset = "0x3D8C860", VA = "0x183D8E260", Slot = "4")]
	public bool Equals(DIBKDMJIGJP BHFGHGMPKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3D8E290", Offset = "0x3D8C890", VA = "0x183D8E290", Slot = "5")]
	public int CompareTo(DIBKDMJIGJP BHFGHGMPKOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7119E80", Offset = "0x7118480", VA = "0x187119E80", Slot = "0")]
	public override bool Equals(object NJKKPOFFNNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3D8E350", Offset = "0x3D8C950", VA = "0x183D8E350", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3D8E260", Offset = "0x3D8C860", VA = "0x183D8E260")]
	public static bool FFOLOHFBIHN(DIBKDMJIGJP CLMMPLJCADB, DIBKDMJIGJP NIGNLACGOIM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7119CC0", Offset = "0x71182C0", VA = "0x187119CC0")]
	public static bool NKEIKPOPFDO(DIBKDMJIGJP CLMMPLJCADB, DIBKDMJIGJP NIGNLACGOIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7119F30", Offset = "0x7118530", VA = "0x187119F30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct FHOKKHPPPEG : IEquatable<FHOKKHPPPEG>, IComparable<FHOKKHPPPEG>, PKCEIIEOBOB
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly FHOKKHPPPEG CHPFPNHMMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Guid IJNLNGBKEAC;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1FFBB40", Offset = "0x1FFA140", VA = "0x181FFBB40")]
	public FHOKKHPPPEG(Guid IJNLNGBKEAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x9FD0C0", Offset = "0x9FB6C0", VA = "0x1809FD0C0", Slot = "6")]
	public Guid AAIOOOLAJIF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3D8E260", Offset = "0x3D8C860", VA = "0x183D8E260", Slot = "4")]
	public bool Equals(FHOKKHPPPEG BHFGHGMPKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3D8E290", Offset = "0x3D8C890", VA = "0x183D8E290", Slot = "5")]
	public int CompareTo(FHOKKHPPPEG BHFGHGMPKOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x711A0C0", Offset = "0x71186C0", VA = "0x18711A0C0", Slot = "0")]
	public override bool Equals(object NJKKPOFFNNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3D8E350", Offset = "0x3D8C950", VA = "0x183D8E350", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3D8E260", Offset = "0x3D8C860", VA = "0x183D8E260")]
	public static bool FFOLOHFBIHN(FHOKKHPPPEG CLMMPLJCADB, FHOKKHPPPEG NIGNLACGOIM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7119CC0", Offset = "0x71182C0", VA = "0x187119CC0")]
	public static bool NKEIKPOPFDO(FHOKKHPPPEG CLMMPLJCADB, FHOKKHPPPEG NIGNLACGOIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x711A170", Offset = "0x7118770", VA = "0x18711A170", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct BGKFEPHCNAG : IEquatable<BGKFEPHCNAG>, IComparable<BGKFEPHCNAG>, PKCEIIEOBOB
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly BGKFEPHCNAG CHPFPNHMMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Guid IJNLNGBKEAC;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1FFBB40", Offset = "0x1FFA140", VA = "0x181FFBB40")]
	public BGKFEPHCNAG(Guid IJNLNGBKEAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x9FD0C0", Offset = "0x9FB6C0", VA = "0x1809FD0C0", Slot = "6")]
	public Guid AAIOOOLAJIF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3D8E260", Offset = "0x3D8C860", VA = "0x183D8E260", Slot = "4")]
	public bool Equals(BGKFEPHCNAG BHFGHGMPKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3D8E290", Offset = "0x3D8C890", VA = "0x183D8E290", Slot = "5")]
	public int CompareTo(BGKFEPHCNAG BHFGHGMPKOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7119C10", Offset = "0x7118210", VA = "0x187119C10", Slot = "0")]
	public override bool Equals(object NJKKPOFFNNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3D8E350", Offset = "0x3D8C950", VA = "0x183D8E350", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3D8E260", Offset = "0x3D8C860", VA = "0x183D8E260")]
	public static bool FFOLOHFBIHN(BGKFEPHCNAG CLMMPLJCADB, BGKFEPHCNAG NIGNLACGOIM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7119CC0", Offset = "0x71182C0", VA = "0x187119CC0")]
	public static bool NKEIKPOPFDO(BGKFEPHCNAG CLMMPLJCADB, BGKFEPHCNAG NIGNLACGOIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7119CF0", Offset = "0x71182F0", VA = "0x187119CF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct NAJCLKBNHFG : IEquatable<NAJCLKBNHFG>, IComparable<NAJCLKBNHFG>, PKCEIIEOBOB
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly NAJCLKBNHFG CHPFPNHMMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Guid IJNLNGBKEAC;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public PLPLILKLPID FKNCGKNIPBF
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8FBA60", Offset = "0x8FA060", VA = "0x1808FBA60")]
		[CompilerGenerated]
		get
		{
			return default(PLPLILKLPID);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public PLPLILKLPID AIEKMDEFILE
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8FBA70", Offset = "0x8FA070", VA = "0x1808FBA70")]
		[CompilerGenerated]
		get
		{
			return default(PLPLILKLPID);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public PLPLILKLPID ODPKMAAEBPH
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x90C1B0", Offset = "0x90A7B0", VA = "0x18090C1B0")]
		[CompilerGenerated]
		get
		{
			return default(PLPLILKLPID);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x9FD0C0", Offset = "0x9FB6C0", VA = "0x1809FD0C0", Slot = "6")]
	public Guid AAIOOOLAJIF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x711B7B0", Offset = "0x7119DB0", VA = "0x18711B7B0")]
	public NAJCLKBNHFG(Guid IJNLNGBKEAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x711B7F0", Offset = "0x7119DF0", VA = "0x18711B7F0")]
	public NAJCLKBNHFG(PLPLILKLPID DDMGOGNGGAH, PLPLILKLPID FMKKKEHLPPN, PLPLILKLPID HAJDMMNNCKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x711B4B0", Offset = "0x7119AB0", VA = "0x18711B4B0")]
	private Guid EDMDMCMLLDJ()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x711B5E0", Offset = "0x7119BE0", VA = "0x18711B5E0", Slot = "4")]
	public bool Equals(NAJCLKBNHFG BHFGHGMPKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x711B610", Offset = "0x7119C10", VA = "0x18711B610", Slot = "0")]
	public override bool Equals(object NJKKPOFFNNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3D8E350", Offset = "0x3D8C950", VA = "0x183D8E350", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x711B6C0", Offset = "0x7119CC0", VA = "0x18711B6C0")]
	public static bool FFOLOHFBIHN(NAJCLKBNHFG CLMMPLJCADB, NAJCLKBNHFG NIGNLACGOIM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x711B700", Offset = "0x7119D00", VA = "0x18711B700")]
	public static bool NKEIKPOPFDO(NAJCLKBNHFG CLMMPLJCADB, NAJCLKBNHFG NIGNLACGOIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x711B470", Offset = "0x7119A70", VA = "0x18711B470", Slot = "5")]
	public int CompareTo(NAJCLKBNHFG BHFGHGMPKOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x711B740", Offset = "0x7119D40", VA = "0x18711B740", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct JFOHGLPGOKN : IEquatable<JFOHGLPGOKN>, IComparable<JFOHGLPGOKN>, PKCEIIEOBOB
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly JFOHGLPGOKN CHPFPNHMMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Guid IJNLNGBKEAC;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x1FFBB40", Offset = "0x1FFA140", VA = "0x181FFBB40")]
	public JFOHGLPGOKN(Guid IJNLNGBKEAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x9FD0C0", Offset = "0x9FB6C0", VA = "0x1809FD0C0", Slot = "6")]
	public Guid AAIOOOLAJIF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3D8E260", Offset = "0x3D8C860", VA = "0x183D8E260", Slot = "4")]
	public bool Equals(JFOHGLPGOKN BHFGHGMPKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3D8E290", Offset = "0x3D8C890", VA = "0x183D8E290", Slot = "5")]
	public int CompareTo(JFOHGLPGOKN BHFGHGMPKOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x711B350", Offset = "0x7119950", VA = "0x18711B350", Slot = "0")]
	public override bool Equals(object NJKKPOFFNNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3D8E350", Offset = "0x3D8C950", VA = "0x183D8E350", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3D8E260", Offset = "0x3D8C860", VA = "0x183D8E260")]
	public static bool FFOLOHFBIHN(JFOHGLPGOKN CLMMPLJCADB, JFOHGLPGOKN NIGNLACGOIM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7119CC0", Offset = "0x71182C0", VA = "0x187119CC0")]
	public static bool NKEIKPOPFDO(JFOHGLPGOKN CLMMPLJCADB, JFOHGLPGOKN NIGNLACGOIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x711B400", Offset = "0x7119A00", VA = "0x18711B400", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct OMIIACJOJFJ : IEquatable<OMIIACJOJFJ>, IComparable<OMIIACJOJFJ>, PKCEIIEOBOB
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly OMIIACJOJFJ CHPFPNHMMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Guid IJNLNGBKEAC;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1FFBB40", Offset = "0x1FFA140", VA = "0x181FFBB40")]
	public OMIIACJOJFJ(Guid IJNLNGBKEAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x9FD0C0", Offset = "0x9FB6C0", VA = "0x1809FD0C0", Slot = "6")]
	public Guid AAIOOOLAJIF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3D8E260", Offset = "0x3D8C860", VA = "0x183D8E260", Slot = "4")]
	public bool Equals(OMIIACJOJFJ BHFGHGMPKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3D8E290", Offset = "0x3D8C890", VA = "0x183D8E290", Slot = "5")]
	public int CompareTo(OMIIACJOJFJ BHFGHGMPKOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x711B8C0", Offset = "0x7119EC0", VA = "0x18711B8C0", Slot = "0")]
	public override bool Equals(object NJKKPOFFNNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3D8E350", Offset = "0x3D8C950", VA = "0x183D8E350", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3D8E260", Offset = "0x3D8C860", VA = "0x183D8E260")]
	public static bool FFOLOHFBIHN(OMIIACJOJFJ CLMMPLJCADB, OMIIACJOJFJ NIGNLACGOIM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7119CC0", Offset = "0x71182C0", VA = "0x187119CC0")]
	public static bool NKEIKPOPFDO(OMIIACJOJFJ CLMMPLJCADB, OMIIACJOJFJ NIGNLACGOIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x711B970", Offset = "0x7119F70", VA = "0x18711B970", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct BPOGHOJNPIN : IEquatable<BPOGHOJNPIN>, IComparable<BPOGHOJNPIN>, PKCEIIEOBOB
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static readonly BPOGHOJNPIN CHPFPNHMMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Guid IJNLNGBKEAC;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x1FFBB40", Offset = "0x1FFA140", VA = "0x181FFBB40")]
	public BPOGHOJNPIN(Guid IJNLNGBKEAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x9FD0C0", Offset = "0x9FB6C0", VA = "0x1809FD0C0", Slot = "6")]
	public Guid AAIOOOLAJIF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3D8E260", Offset = "0x3D8C860", VA = "0x183D8E260", Slot = "4")]
	public bool Equals(BPOGHOJNPIN BHFGHGMPKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3D8E290", Offset = "0x3D8C890", VA = "0x183D8E290", Slot = "5")]
	public int CompareTo(BPOGHOJNPIN BHFGHGMPKOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7119D60", Offset = "0x7118360", VA = "0x187119D60", Slot = "0")]
	public override bool Equals(object NJKKPOFFNNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3D8E350", Offset = "0x3D8C950", VA = "0x183D8E350", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3D8E260", Offset = "0x3D8C860", VA = "0x183D8E260")]
	public static bool FFOLOHFBIHN(BPOGHOJNPIN CLMMPLJCADB, BPOGHOJNPIN NIGNLACGOIM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7119CC0", Offset = "0x71182C0", VA = "0x187119CC0")]
	public static bool NKEIKPOPFDO(BPOGHOJNPIN CLMMPLJCADB, BPOGHOJNPIN NIGNLACGOIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7119E10", Offset = "0x7118410", VA = "0x187119E10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct DKKCBBGFBGH : IEquatable<DKKCBBGFBGH>, IComparable<DKKCBBGFBGH>, PKCEIIEOBOB
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static readonly DKKCBBGFBGH CHPFPNHMMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly Guid IJNLNGBKEAC;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1FFBB40", Offset = "0x1FFA140", VA = "0x181FFBB40")]
	public DKKCBBGFBGH(Guid IJNLNGBKEAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x9FD0C0", Offset = "0x9FB6C0", VA = "0x1809FD0C0", Slot = "6")]
	public Guid AAIOOOLAJIF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3D8E260", Offset = "0x3D8C860", VA = "0x183D8E260", Slot = "4")]
	public bool Equals(DKKCBBGFBGH BHFGHGMPKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3D8E290", Offset = "0x3D8C890", VA = "0x183D8E290", Slot = "5")]
	public int CompareTo(DKKCBBGFBGH BHFGHGMPKOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7119FA0", Offset = "0x71185A0", VA = "0x187119FA0", Slot = "0")]
	public override bool Equals(object NJKKPOFFNNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3D8E350", Offset = "0x3D8C950", VA = "0x183D8E350", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3D8E260", Offset = "0x3D8C860", VA = "0x183D8E260")]
	public static bool FFOLOHFBIHN(DKKCBBGFBGH CLMMPLJCADB, DKKCBBGFBGH NIGNLACGOIM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7119CC0", Offset = "0x71182C0", VA = "0x187119CC0")]
	public static bool NKEIKPOPFDO(DKKCBBGFBGH CLMMPLJCADB, DKKCBBGFBGH NIGNLACGOIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x711A050", Offset = "0x7118650", VA = "0x18711A050", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct FPLOGOPHJCG : IEquatable<FPLOGOPHJCG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly string?[]? HLDPCLEICDC;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool HIFFGJEKBHK
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x711A350", Offset = "0x7118950", VA = "0x18711A350")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int FIGKJLMMHGK
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x426FB40", Offset = "0x426E140", VA = "0x18426FB40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x711A950", Offset = "0x7118F50", VA = "0x18711A950")]
	public FPLOGOPHJCG(string? OMFJIFLPHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x711A8D0", Offset = "0x7118ED0", VA = "0x18711A8D0")]
	public FPLOGOPHJCG(string?[] BMCCPJPDPKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x711A610", Offset = "0x7118C10", VA = "0x18711A610")]
	private static string?[]? HHDKDIFLJAI(string?[]? BMCCPJPDPKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x711A4D0", Offset = "0x7118AD0", VA = "0x18711A4D0")]
	public string GMFCMAINKCJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x711A400", Offset = "0x7118A00", VA = "0x18711A400", Slot = "4")]
	public bool Equals(FPLOGOPHJCG BHFGHGMPKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x711A370", Offset = "0x7118970", VA = "0x18711A370", Slot = "0")]
	public override bool Equals(object NJKKPOFFNNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x711A530", Offset = "0x7118B30", VA = "0x18711A530", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x711A840", Offset = "0x7118E40", VA = "0x18711A840", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct PLPLILKLPID : IEquatable<PLPLILKLPID>, IComparable<PLPLILKLPID>, PKCEIIEOBOB
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly PLPLILKLPID CHPFPNHMMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Guid IJNLNGBKEAC;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1FFBB40", Offset = "0x1FFA140", VA = "0x181FFBB40")]
	public PLPLILKLPID(Guid IJNLNGBKEAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x9FD0C0", Offset = "0x9FB6C0", VA = "0x1809FD0C0", Slot = "6")]
	public Guid AAIOOOLAJIF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3D8E260", Offset = "0x3D8C860", VA = "0x183D8E260", Slot = "4")]
	public bool Equals(PLPLILKLPID BHFGHGMPKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3D8E290", Offset = "0x3D8C890", VA = "0x183D8E290", Slot = "5")]
	public int CompareTo(PLPLILKLPID BHFGHGMPKOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x711B9E0", Offset = "0x7119FE0", VA = "0x18711B9E0", Slot = "0")]
	public override bool Equals(object NJKKPOFFNNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3D8E350", Offset = "0x3D8C950", VA = "0x183D8E350", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3D8E260", Offset = "0x3D8C860", VA = "0x183D8E260")]
	public static bool FFOLOHFBIHN(PLPLILKLPID CLMMPLJCADB, PLPLILKLPID NIGNLACGOIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x711BA90", Offset = "0x711A090", VA = "0x18711BA90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface NHEFIAGPNID<TModern> : EHLLKDDMBGF<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string MGPIDOEPBKN(TModern EANOCADKNNG);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface PKCEIIEOBOB
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Guid AAIOOOLAJIF();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface EHLLKDDMBGF<out TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TModern NMKBGAJJELG(string EANOCADKNNG);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface IIHHJNFJGAC
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	NHEFIAGPNID<DIBKDMJIGJP> EINHCDLCEFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	NHEFIAGPNID<JFOHGLPGOKN> MDNALMIOJEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	NHEFIAGPNID<DKKCBBGFBGH> LMKCBCEMGAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	NHEFIAGPNID<NAJCLKBNHFG> NIOMOCJELIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	NHEFIAGPNID<BGKFEPHCNAG> MJIDCEKFCBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	NHEFIAGPNID<BPOGHOJNPIN> KAHOMKACLJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	NHEFIAGPNID<FHOKKHPPPEG> LMKHEOFKMAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	NHEFIAGPNID<OMIIACJOJFJ> NIKJNEPFLKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class FKGNMNPAILJ
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static readonly char[] ALHNOCHCJJA;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x711A210", Offset = "0x7118810", VA = "0x18711A210")]
	public static string[] LBNJNEMOFGE(string? OMFJIFLPHED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x711A1E0", Offset = "0x71187E0", VA = "0x18711A1E0")]
	public static string? KLNDGOADHKN(string? IJMBHINBANJ)
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
