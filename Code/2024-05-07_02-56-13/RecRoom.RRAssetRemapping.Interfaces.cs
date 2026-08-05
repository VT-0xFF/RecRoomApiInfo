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
		[Cpp2IlInjected.Address(RVA = "0x7DEB30", Offset = "0x7DDD30", VA = "0x1807DEB30")]
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
		[Cpp2IlInjected.Address(RVA = "0x6875AF0", Offset = "0x6874CF0", VA = "0x186875AF0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7DF880", Offset = "0x7DEA80", VA = "0x1807DF880")]
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
		[Cpp2IlInjected.Address(RVA = "0x7DF8C0", Offset = "0x7DEAC0", VA = "0x1807DF8C0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface JHHOAOJAKLB
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string OHDBDPJBHPM(KJPHDDIDNHP CCAOJBHBKKC);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KJPHDDIDNHP LKMADFBDLGL(string CCAOJBHBKKC);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct KJPHDDIDNHP : IEquatable<KJPHDDIDNHP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly JEAGJPCCODB DJBDICOEHCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly HNNJKOJEHLP HKOEPEIAKKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly Guid CPKAEKFGOIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly RRColor? JOOKLKJABGB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool IPAEGOOFLPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6875200", Offset = "0x6874400", VA = "0x186875200")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool FFFLOKOELOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6875370", Offset = "0x6874570", VA = "0x186875370")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x68757B0", Offset = "0x68749B0", VA = "0x1868757B0")]
	public KJPHDDIDNHP(KJPHDDIDNHP DAAKOIILBBM, [Optional] Guid CDMGLKIMINO, [Optional] RRColor? NHDAKDKKMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6875840", Offset = "0x6874A40", VA = "0x186875840")]
	public KJPHDDIDNHP(JEAGJPCCODB HFCAFJFHAKA, HNNJKOJEHLP KLDFNCBGOLA, [Optional] Guid CDMGLKIMINO, [Optional] RRColor? NHDAKDKKMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6874F90", Offset = "0x6874190", VA = "0x186874F90", Slot = "4")]
	public bool Equals(KJPHDDIDNHP NOBJAPGNDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6875040", Offset = "0x6874240", VA = "0x186875040", Slot = "0")]
	public override bool Equals(object JFJMICPDNDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6875170", Offset = "0x6874370", VA = "0x186875170", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6874F90", Offset = "0x6874190", VA = "0x186874F90")]
	public static bool AIPCENMEJFE(KJPHDDIDNHP EBKLEGBLPGD, KJPHDDIDNHP JCPNHMOLDGI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x68752C0", Offset = "0x68744C0", VA = "0x1868752C0")]
	public static bool KEIKIALHENC(KJPHDDIDNHP EBKLEGBLPGD, KJPHDDIDNHP JCPNHMOLDGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x68753B0", Offset = "0x68745B0", VA = "0x1868753B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct JEAGJPCCODB : IEquatable<JEAGJPCCODB>, IComparable<JEAGJPCCODB>, CMCGFHCJJCJ
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly JEAGJPCCODB CLJCIKPCCEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Guid IKOKEKHMFKH;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1E4A460", Offset = "0x1E49660", VA = "0x181E4A460")]
	public JEAGJPCCODB(Guid IKOKEKHMFKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x87DF70", Offset = "0x87D170", VA = "0x18087DF70", Slot = "6")]
	public Guid FCDJDDEIANC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4891C90", Offset = "0x4890E90", VA = "0x184891C90", Slot = "4")]
	public bool Equals(JEAGJPCCODB NOBJAPGNDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4891A90", Offset = "0x4890C90", VA = "0x184891A90", Slot = "5")]
	public int CompareTo(JEAGJPCCODB NOBJAPGNDAK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6874D70", Offset = "0x6873F70", VA = "0x186874D70", Slot = "0")]
	public override bool Equals(object JFJMICPDNDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4891C70", Offset = "0x4890E70", VA = "0x184891C70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4891C90", Offset = "0x4890E90", VA = "0x184891C90")]
	public static bool AIPCENMEJFE(JEAGJPCCODB EBKLEGBLPGD, JEAGJPCCODB JCPNHMOLDGI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x68744E0", Offset = "0x68736E0", VA = "0x1868744E0")]
	public static bool KEIKIALHENC(JEAGJPCCODB EBKLEGBLPGD, JEAGJPCCODB JCPNHMOLDGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6874E10", Offset = "0x6874010", VA = "0x186874E10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct CPLNGBDKCMH : IEquatable<CPLNGBDKCMH>, IComparable<CPLNGBDKCMH>, CMCGFHCJJCJ
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly CPLNGBDKCMH CLJCIKPCCEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Guid IKOKEKHMFKH;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1E4A460", Offset = "0x1E49660", VA = "0x181E4A460")]
	public CPLNGBDKCMH(Guid IKOKEKHMFKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x87DF70", Offset = "0x87D170", VA = "0x18087DF70", Slot = "6")]
	public Guid FCDJDDEIANC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4891C90", Offset = "0x4890E90", VA = "0x184891C90", Slot = "4")]
	public bool Equals(CPLNGBDKCMH NOBJAPGNDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4891A90", Offset = "0x4890C90", VA = "0x184891A90", Slot = "5")]
	public int CompareTo(CPLNGBDKCMH NOBJAPGNDAK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6874690", Offset = "0x6873890", VA = "0x186874690", Slot = "0")]
	public override bool Equals(object JFJMICPDNDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4891C70", Offset = "0x4890E70", VA = "0x184891C70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4891C90", Offset = "0x4890E90", VA = "0x184891C90")]
	public static bool AIPCENMEJFE(CPLNGBDKCMH EBKLEGBLPGD, CPLNGBDKCMH JCPNHMOLDGI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x68744E0", Offset = "0x68736E0", VA = "0x1868744E0")]
	public static bool KEIKIALHENC(CPLNGBDKCMH EBKLEGBLPGD, CPLNGBDKCMH JCPNHMOLDGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6874730", Offset = "0x6873930", VA = "0x186874730", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct BIIGIEBHNIJ : IEquatable<BIIGIEBHNIJ>, IComparable<BIIGIEBHNIJ>, CMCGFHCJJCJ
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly BIIGIEBHNIJ CLJCIKPCCEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Guid IKOKEKHMFKH;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1E4A460", Offset = "0x1E49660", VA = "0x181E4A460")]
	public BIIGIEBHNIJ(Guid IKOKEKHMFKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x87DF70", Offset = "0x87D170", VA = "0x18087DF70", Slot = "6")]
	public Guid FCDJDDEIANC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4891C90", Offset = "0x4890E90", VA = "0x184891C90", Slot = "4")]
	public bool Equals(BIIGIEBHNIJ NOBJAPGNDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4891A90", Offset = "0x4890C90", VA = "0x184891A90", Slot = "5")]
	public int CompareTo(BIIGIEBHNIJ NOBJAPGNDAK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6874440", Offset = "0x6873640", VA = "0x186874440", Slot = "0")]
	public override bool Equals(object JFJMICPDNDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4891C70", Offset = "0x4890E70", VA = "0x184891C70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4891C90", Offset = "0x4890E90", VA = "0x184891C90")]
	public static bool AIPCENMEJFE(BIIGIEBHNIJ EBKLEGBLPGD, BIIGIEBHNIJ JCPNHMOLDGI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x68744E0", Offset = "0x68736E0", VA = "0x1868744E0")]
	public static bool KEIKIALHENC(BIIGIEBHNIJ EBKLEGBLPGD, BIIGIEBHNIJ JCPNHMOLDGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6874510", Offset = "0x6873710", VA = "0x186874510", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct HNNJKOJEHLP : IEquatable<HNNJKOJEHLP>, IComparable<HNNJKOJEHLP>, CMCGFHCJJCJ
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly HNNJKOJEHLP CLJCIKPCCEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Guid IKOKEKHMFKH;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public OKFEMKEKNOO JLBGBMLEGMH
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x843A80", Offset = "0x842C80", VA = "0x180843A80")]
		[CompilerGenerated]
		get
		{
			return default(OKFEMKEKNOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public OKFEMKEKNOO IBAPOOKPMKG
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x103B500", Offset = "0x103A700", VA = "0x18103B500")]
		[CompilerGenerated]
		get
		{
			return default(OKFEMKEKNOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public OKFEMKEKNOO GOAIDAHFHGC
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xF26240", Offset = "0xF25440", VA = "0x180F26240")]
		[CompilerGenerated]
		get
		{
			return default(OKFEMKEKNOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x87DF70", Offset = "0x87D170", VA = "0x18087DF70", Slot = "6")]
	public Guid FCDJDDEIANC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6874CE0", Offset = "0x6873EE0", VA = "0x186874CE0")]
	public HNNJKOJEHLP(Guid IKOKEKHMFKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6874D20", Offset = "0x6873F20", VA = "0x186874D20")]
	public HNNJKOJEHLP(OKFEMKEKNOO FKOIDBIAKOK, OKFEMKEKNOO KOMEGECBNDB, OKFEMKEKNOO LDBLEMPAONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6874B00", Offset = "0x6873D00", VA = "0x186874B00")]
	private Guid GPPGLGLMGIB()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6874AD0", Offset = "0x6873CD0", VA = "0x186874AD0", Slot = "4")]
	public bool Equals(HNNJKOJEHLP NOBJAPGNDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6874A20", Offset = "0x6873C20", VA = "0x186874A20", Slot = "0")]
	public override bool Equals(object JFJMICPDNDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4891C70", Offset = "0x4890E70", VA = "0x184891C70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x68749A0", Offset = "0x6873BA0", VA = "0x1868749A0")]
	public static bool AIPCENMEJFE(HNNJKOJEHLP EBKLEGBLPGD, HNNJKOJEHLP JCPNHMOLDGI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6874C30", Offset = "0x6873E30", VA = "0x186874C30")]
	public static bool KEIKIALHENC(HNNJKOJEHLP EBKLEGBLPGD, HNNJKOJEHLP JCPNHMOLDGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x68749E0", Offset = "0x6873BE0", VA = "0x1868749E0", Slot = "5")]
	public int CompareTo(HNNJKOJEHLP NOBJAPGNDAK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6874C70", Offset = "0x6873E70", VA = "0x186874C70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct LCOFMHLCHJJ : IEquatable<LCOFMHLCHJJ>, IComparable<LCOFMHLCHJJ>, CMCGFHCJJCJ
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly LCOFMHLCHJJ CLJCIKPCCEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Guid IKOKEKHMFKH;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1E4A460", Offset = "0x1E49660", VA = "0x181E4A460")]
	public LCOFMHLCHJJ(Guid IKOKEKHMFKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x87DF70", Offset = "0x87D170", VA = "0x18087DF70", Slot = "6")]
	public Guid FCDJDDEIANC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4891C90", Offset = "0x4890E90", VA = "0x184891C90", Slot = "4")]
	public bool Equals(LCOFMHLCHJJ NOBJAPGNDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4891A90", Offset = "0x4890C90", VA = "0x184891A90", Slot = "5")]
	public int CompareTo(LCOFMHLCHJJ NOBJAPGNDAK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x68758D0", Offset = "0x6874AD0", VA = "0x1868758D0", Slot = "0")]
	public override bool Equals(object JFJMICPDNDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4891C70", Offset = "0x4890E70", VA = "0x184891C70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4891C90", Offset = "0x4890E90", VA = "0x184891C90")]
	public static bool AIPCENMEJFE(LCOFMHLCHJJ EBKLEGBLPGD, LCOFMHLCHJJ JCPNHMOLDGI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x68744E0", Offset = "0x68736E0", VA = "0x1868744E0")]
	public static bool KEIKIALHENC(LCOFMHLCHJJ EBKLEGBLPGD, LCOFMHLCHJJ JCPNHMOLDGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6875970", Offset = "0x6874B70", VA = "0x186875970", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct LDNHAIONBAK : IEquatable<LDNHAIONBAK>, IComparable<LDNHAIONBAK>, CMCGFHCJJCJ
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly LDNHAIONBAK CLJCIKPCCEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Guid IKOKEKHMFKH;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1E4A460", Offset = "0x1E49660", VA = "0x181E4A460")]
	public LDNHAIONBAK(Guid IKOKEKHMFKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x87DF70", Offset = "0x87D170", VA = "0x18087DF70", Slot = "6")]
	public Guid FCDJDDEIANC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4891C90", Offset = "0x4890E90", VA = "0x184891C90", Slot = "4")]
	public bool Equals(LDNHAIONBAK NOBJAPGNDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4891A90", Offset = "0x4890C90", VA = "0x184891A90", Slot = "5")]
	public int CompareTo(LDNHAIONBAK NOBJAPGNDAK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x68759E0", Offset = "0x6874BE0", VA = "0x1868759E0", Slot = "0")]
	public override bool Equals(object JFJMICPDNDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4891C70", Offset = "0x4890E70", VA = "0x184891C70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4891C90", Offset = "0x4890E90", VA = "0x184891C90")]
	public static bool AIPCENMEJFE(LDNHAIONBAK EBKLEGBLPGD, LDNHAIONBAK JCPNHMOLDGI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x68744E0", Offset = "0x68736E0", VA = "0x1868744E0")]
	public static bool KEIKIALHENC(LDNHAIONBAK EBKLEGBLPGD, LDNHAIONBAK JCPNHMOLDGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6875A80", Offset = "0x6874C80", VA = "0x186875A80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct KBMOELFNJEP : IEquatable<KBMOELFNJEP>, IComparable<KBMOELFNJEP>, CMCGFHCJJCJ
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static readonly KBMOELFNJEP CLJCIKPCCEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Guid IKOKEKHMFKH;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x1E4A460", Offset = "0x1E49660", VA = "0x181E4A460")]
	public KBMOELFNJEP(Guid IKOKEKHMFKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x87DF70", Offset = "0x87D170", VA = "0x18087DF70", Slot = "6")]
	public Guid FCDJDDEIANC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4891C90", Offset = "0x4890E90", VA = "0x184891C90", Slot = "4")]
	public bool Equals(KBMOELFNJEP NOBJAPGNDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4891A90", Offset = "0x4890C90", VA = "0x184891A90", Slot = "5")]
	public int CompareTo(KBMOELFNJEP NOBJAPGNDAK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6874E80", Offset = "0x6874080", VA = "0x186874E80", Slot = "0")]
	public override bool Equals(object JFJMICPDNDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x4891C70", Offset = "0x4890E70", VA = "0x184891C70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x4891C90", Offset = "0x4890E90", VA = "0x184891C90")]
	public static bool AIPCENMEJFE(KBMOELFNJEP EBKLEGBLPGD, KBMOELFNJEP JCPNHMOLDGI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x68744E0", Offset = "0x68736E0", VA = "0x1868744E0")]
	public static bool KEIKIALHENC(KBMOELFNJEP EBKLEGBLPGD, KBMOELFNJEP JCPNHMOLDGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6874F20", Offset = "0x6874120", VA = "0x186874F20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct CBAFNFNJIBK : IEquatable<CBAFNFNJIBK>, IComparable<CBAFNFNJIBK>, CMCGFHCJJCJ
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static readonly CBAFNFNJIBK CLJCIKPCCEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly Guid IKOKEKHMFKH;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1E4A460", Offset = "0x1E49660", VA = "0x181E4A460")]
	public CBAFNFNJIBK(Guid IKOKEKHMFKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x87DF70", Offset = "0x87D170", VA = "0x18087DF70", Slot = "6")]
	public Guid FCDJDDEIANC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4891C90", Offset = "0x4890E90", VA = "0x184891C90", Slot = "4")]
	public bool Equals(CBAFNFNJIBK NOBJAPGNDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4891A90", Offset = "0x4890C90", VA = "0x184891A90", Slot = "5")]
	public int CompareTo(CBAFNFNJIBK NOBJAPGNDAK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6874580", Offset = "0x6873780", VA = "0x186874580", Slot = "0")]
	public override bool Equals(object JFJMICPDNDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x4891C70", Offset = "0x4890E70", VA = "0x184891C70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4891C90", Offset = "0x4890E90", VA = "0x184891C90")]
	public static bool AIPCENMEJFE(CBAFNFNJIBK EBKLEGBLPGD, CBAFNFNJIBK JCPNHMOLDGI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x68744E0", Offset = "0x68736E0", VA = "0x1868744E0")]
	public static bool KEIKIALHENC(CBAFNFNJIBK EBKLEGBLPGD, CBAFNFNJIBK JCPNHMOLDGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6874620", Offset = "0x6873820", VA = "0x186874620", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct PMMOMIOFJDG : IEquatable<PMMOMIOFJDG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly string?[]? LPJKAPFOAIF;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool PPFMDOGEELH
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6875DE0", Offset = "0x6874FE0", VA = "0x186875DE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int HGJJKOBHNFA
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x3DDE5F0", Offset = "0x3DDD7F0", VA = "0x183DDE5F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6876200", Offset = "0x6875400", VA = "0x186876200")]
	public PMMOMIOFJDG(string? JCJOPGJHKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6876340", Offset = "0x6875540", VA = "0x186876340")]
	public PMMOMIOFJDG(string?[] DCPJIAOEPKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6875F40", Offset = "0x6875140", VA = "0x186875F40")]
	private static string?[]? NLKLEOCDBNE(string?[]? DCPJIAOEPKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6875EE0", Offset = "0x68750E0", VA = "0x186875EE0")]
	public string NDHCBAHFBGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6875C80", Offset = "0x6874E80", VA = "0x186875C80", Slot = "4")]
	public bool Equals(PMMOMIOFJDG NOBJAPGNDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6875D50", Offset = "0x6874F50", VA = "0x186875D50", Slot = "0")]
	public override bool Equals(object JFJMICPDNDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6875E00", Offset = "0x6875000", VA = "0x186875E00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6876170", Offset = "0x6875370", VA = "0x186876170", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct OKFEMKEKNOO : IEquatable<OKFEMKEKNOO>, IComparable<OKFEMKEKNOO>, CMCGFHCJJCJ
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly OKFEMKEKNOO CLJCIKPCCEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Guid IKOKEKHMFKH;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1E4A460", Offset = "0x1E49660", VA = "0x181E4A460")]
	public OKFEMKEKNOO(Guid IKOKEKHMFKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x87DF70", Offset = "0x87D170", VA = "0x18087DF70", Slot = "6")]
	public Guid FCDJDDEIANC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4891C90", Offset = "0x4890E90", VA = "0x184891C90", Slot = "4")]
	public bool Equals(OKFEMKEKNOO NOBJAPGNDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x4891A90", Offset = "0x4890C90", VA = "0x184891A90", Slot = "5")]
	public int CompareTo(OKFEMKEKNOO NOBJAPGNDAK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6875B70", Offset = "0x6874D70", VA = "0x186875B70", Slot = "0")]
	public override bool Equals(object JFJMICPDNDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4891C70", Offset = "0x4890E70", VA = "0x184891C70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4891C90", Offset = "0x4890E90", VA = "0x184891C90")]
	public static bool AIPCENMEJFE(OKFEMKEKNOO EBKLEGBLPGD, OKFEMKEKNOO JCPNHMOLDGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6875C10", Offset = "0x6874E10", VA = "0x186875C10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct GHHFIDGENCO : IEquatable<GHHFIDGENCO>, IComparable<GHHFIDGENCO>, CMCGFHCJJCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly Guid IKOKEKHMFKH;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1E4A460", Offset = "0x1E49660", VA = "0x181E4A460")]
	public GHHFIDGENCO(Guid IKOKEKHMFKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x87DF70", Offset = "0x87D170", VA = "0x18087DF70", Slot = "6")]
	public Guid FCDJDDEIANC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4891C90", Offset = "0x4890E90", VA = "0x184891C90", Slot = "4")]
	public bool Equals(GHHFIDGENCO NOBJAPGNDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4891A90", Offset = "0x4890C90", VA = "0x184891A90", Slot = "5")]
	public int CompareTo(GHHFIDGENCO NOBJAPGNDAK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6874890", Offset = "0x6873A90", VA = "0x186874890", Slot = "0")]
	public override bool Equals(object JFJMICPDNDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x4891C70", Offset = "0x4890E70", VA = "0x184891C70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6874930", Offset = "0x6873B30", VA = "0x186874930", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface LIAFPDFNCIE<TModern> : ANCKFOKNMGP<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string KBPJPEFBEHA(TModern OPEMFPOCFNH);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface CMCGFHCJJCJ
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Guid FCDJDDEIANC();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface ANCKFOKNMGP<out TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TModern IEBCFEBKCFG(string OPEMFPOCFNH);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface GPOLAKEALAF
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	LIAFPDFNCIE<JEAGJPCCODB> IIICBPHCMJI
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	LIAFPDFNCIE<LCOFMHLCHJJ> NJOJJDCJGFM
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	LIAFPDFNCIE<CBAFNFNJIBK> IHICHJLHGNM
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	LIAFPDFNCIE<HNNJKOJEHLP> ABDHAKMKIOD
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	LIAFPDFNCIE<BIIGIEBHNIJ> JGPOIBHBBPI
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	LIAFPDFNCIE<KBMOELFNJEP> AONLEBNIFKM
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	LIAFPDFNCIE<CPLNGBDKCMH> BOABNKBAHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	LIAFPDFNCIE<LDNHAIONBAK> CBJOAFBBLBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class DCMFIOPNDMA
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x68747D0", Offset = "0x68739D0", VA = "0x1868747D0")]
	public static string[] OEGIMLECJLF(string? JCJOPGJHKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x68747A0", Offset = "0x68739A0", VA = "0x1868747A0")]
	public static string? ANJBDEAEKKM(string? HFCAFJFHAKA)
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
