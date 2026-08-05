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
		[Cpp2IlInjected.Address(RVA = "0x8AE160", Offset = "0x8ACB60", VA = "0x1808AE160")]
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
		[Cpp2IlInjected.Address(RVA = "0x72C49C0", Offset = "0x72C33C0", VA = "0x1872C49C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8AE5A0", Offset = "0x8ACFA0", VA = "0x1808AE5A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8AE5E0", Offset = "0x8ACFE0", VA = "0x1808AE5E0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface MKONEPBHDKA
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string BBLOJHGNHMB(ACPAMABFJKA AHBBCFFJCCJ);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ACPAMABFJKA MPIHBHFBPAP(string AHBBCFFJCCJ);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct ACPAMABFJKA : IEquatable<ACPAMABFJKA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly OILMEJJBBPK DMFBLAKKMMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly AOFHBLCBKAK GFLKHLNLMLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly Guid CBHBGBMGKKM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool GBBJKLEAHGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x72C3560", Offset = "0x72C1F60", VA = "0x1872C3560")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool JCAHODPBPFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x72C32F0", Offset = "0x72C1CF0", VA = "0x1872C32F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x72C38F0", Offset = "0x72C22F0", VA = "0x1872C38F0")]
	public ACPAMABFJKA(ACPAMABFJKA DEPMCFOGJGE, [Optional] Guid FKNGDEPOLMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4EBE7B0", Offset = "0x4EBD1B0", VA = "0x184EBE7B0")]
	public ACPAMABFJKA(OILMEJJBBPK LAPNIHDLAOI, AOFHBLCBKAK PDAGLHPFIDO, [Optional] Guid FKNGDEPOLMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x72C33E0", Offset = "0x72C1DE0", VA = "0x1872C33E0", Slot = "4")]
	public bool Equals(ACPAMABFJKA CGCLEIBHLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x72C3330", Offset = "0x72C1D30", VA = "0x1872C3330", Slot = "0")]
	public override bool Equals(object FHFDEAHMMBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x72C34A0", Offset = "0x72C1EA0", VA = "0x1872C34A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x72C3530", Offset = "0x72C1F30", VA = "0x1872C3530")]
	public static bool JGJOKBKMGBC(ACPAMABFJKA OMCEEKENOBB, ACPAMABFJKA MOBHGIAPGGL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x72C32B0", Offset = "0x72C1CB0", VA = "0x1872C32B0")]
	public static bool DCLBGLCHDNG(ACPAMABFJKA OMCEEKENOBB, ACPAMABFJKA MOBHGIAPGGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x72C35F0", Offset = "0x72C1FF0", VA = "0x1872C35F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct OILMEJJBBPK : IEquatable<OILMEJJBBPK>, IComparable<OILMEJJBBPK>, DJFLCPIMHBF
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly OILMEJJBBPK CKLKOBNMKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Guid OKMPNEEAGBI;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0xC382F0", Offset = "0xC36CF0", VA = "0x180C382F0")]
	public OILMEJJBBPK(Guid OKMPNEEAGBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0xC382E0", Offset = "0xC36CE0", VA = "0x180C382E0", Slot = "6")]
	public Guid MCPJDCOOMJK()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3EC13D0", Offset = "0x3EBFDD0", VA = "0x183EC13D0", Slot = "4")]
	public bool Equals(OILMEJJBBPK CGCLEIBHLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3EC1260", Offset = "0x3EBFC60", VA = "0x183EC1260", Slot = "5")]
	public int CompareTo(OILMEJJBBPK CGCLEIBHLHF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x72C4A40", Offset = "0x72C3440", VA = "0x1872C4A40", Slot = "0")]
	public override bool Equals(object FHFDEAHMMBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3EC1400", Offset = "0x3EBFE00", VA = "0x183EC1400", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3EC13D0", Offset = "0x3EBFDD0", VA = "0x183EC13D0")]
	public static bool JGJOKBKMGBC(OILMEJJBBPK OMCEEKENOBB, OILMEJJBBPK MOBHGIAPGGL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x72C3A20", Offset = "0x72C2420", VA = "0x1872C3A20")]
	public static bool DCLBGLCHDNG(OILMEJJBBPK OMCEEKENOBB, OILMEJJBBPK MOBHGIAPGGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x72C4AE0", Offset = "0x72C34E0", VA = "0x1872C4AE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct PIAPLLICGDA : IEquatable<PIAPLLICGDA>, IComparable<PIAPLLICGDA>, DJFLCPIMHBF
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static readonly PIAPLLICGDA CKLKOBNMKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Guid OKMPNEEAGBI;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xC382F0", Offset = "0xC36CF0", VA = "0x180C382F0")]
	public PIAPLLICGDA(Guid OKMPNEEAGBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0xC382E0", Offset = "0xC36CE0", VA = "0x180C382E0", Slot = "6")]
	public Guid MCPJDCOOMJK()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3EC13D0", Offset = "0x3EBFDD0", VA = "0x183EC13D0", Slot = "4")]
	public bool Equals(PIAPLLICGDA CGCLEIBHLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3EC1260", Offset = "0x3EBFC60", VA = "0x183EC1260", Slot = "5")]
	public int CompareTo(PIAPLLICGDA CGCLEIBHLHF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x72C4B50", Offset = "0x72C3550", VA = "0x1872C4B50", Slot = "0")]
	public override bool Equals(object FHFDEAHMMBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3EC1400", Offset = "0x3EBFE00", VA = "0x183EC1400", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3EC13D0", Offset = "0x3EBFDD0", VA = "0x183EC13D0")]
	public static bool JGJOKBKMGBC(PIAPLLICGDA OMCEEKENOBB, PIAPLLICGDA MOBHGIAPGGL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x72C3A20", Offset = "0x72C2420", VA = "0x1872C3A20")]
	public static bool DCLBGLCHDNG(PIAPLLICGDA OMCEEKENOBB, PIAPLLICGDA MOBHGIAPGGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x72C4BF0", Offset = "0x72C35F0", VA = "0x1872C4BF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct KOJLPHFPMHB : IEquatable<KOJLPHFPMHB>, IComparable<KOJLPHFPMHB>, DJFLCPIMHBF
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public static readonly KOJLPHFPMHB CKLKOBNMKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Guid OKMPNEEAGBI;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0xC382F0", Offset = "0xC36CF0", VA = "0x180C382F0")]
	public KOJLPHFPMHB(Guid OKMPNEEAGBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0xC382E0", Offset = "0xC36CE0", VA = "0x180C382E0", Slot = "6")]
	public Guid MCPJDCOOMJK()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3EC13D0", Offset = "0x3EBFDD0", VA = "0x183EC13D0", Slot = "4")]
	public bool Equals(KOJLPHFPMHB CGCLEIBHLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3EC1260", Offset = "0x3EBFC60", VA = "0x183EC1260", Slot = "5")]
	public int CompareTo(KOJLPHFPMHB CGCLEIBHLHF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x72C48B0", Offset = "0x72C32B0", VA = "0x1872C48B0", Slot = "0")]
	public override bool Equals(object FHFDEAHMMBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3EC1400", Offset = "0x3EBFE00", VA = "0x183EC1400", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3EC13D0", Offset = "0x3EBFDD0", VA = "0x183EC13D0")]
	public static bool JGJOKBKMGBC(KOJLPHFPMHB OMCEEKENOBB, KOJLPHFPMHB MOBHGIAPGGL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x72C3A20", Offset = "0x72C2420", VA = "0x1872C3A20")]
	public static bool DCLBGLCHDNG(KOJLPHFPMHB OMCEEKENOBB, KOJLPHFPMHB MOBHGIAPGGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x72C4950", Offset = "0x72C3350", VA = "0x1872C4950", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct AOFHBLCBKAK : IEquatable<AOFHBLCBKAK>, IComparable<AOFHBLCBKAK>, DJFLCPIMHBF
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly AOFHBLCBKAK CKLKOBNMKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Guid OKMPNEEAGBI;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0xC382F0", Offset = "0xC36CF0", VA = "0x180C382F0")]
	public AOFHBLCBKAK(Guid OKMPNEEAGBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0xC382E0", Offset = "0xC36CE0", VA = "0x180C382E0", Slot = "6")]
	public Guid MCPJDCOOMJK()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x72C3B90", Offset = "0x72C2590", VA = "0x1872C3B90", Slot = "4")]
	public bool Equals(AOFHBLCBKAK CGCLEIBHLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x72C3BC0", Offset = "0x72C25C0", VA = "0x1872C3BC0", Slot = "0")]
	public override bool Equals(object FHFDEAHMMBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3EC1400", Offset = "0x3EBFE00", VA = "0x183EC1400", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x72C3B90", Offset = "0x72C2590", VA = "0x1872C3B90")]
	public static bool JGJOKBKMGBC(AOFHBLCBKAK OMCEEKENOBB, AOFHBLCBKAK MOBHGIAPGGL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x72C3B60", Offset = "0x72C2560", VA = "0x1872C3B60")]
	public static bool DCLBGLCHDNG(AOFHBLCBKAK OMCEEKENOBB, AOFHBLCBKAK MOBHGIAPGGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3EC1260", Offset = "0x3EBFC60", VA = "0x183EC1260", Slot = "5")]
	public int CompareTo(AOFHBLCBKAK CGCLEIBHLHF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x72C3C60", Offset = "0x72C2660", VA = "0x1872C3C60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0xC382F0", Offset = "0xC36CF0", VA = "0x180C382F0")]
	public AOFHBLCBKAK(AHDECKGIPAM IJFBOFJDIDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct CGNBOJIKACE : IEquatable<CGNBOJIKACE>, IComparable<CGNBOJIKACE>, DJFLCPIMHBF
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly CGNBOJIKACE CKLKOBNMKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Guid OKMPNEEAGBI;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0xC382F0", Offset = "0xC36CF0", VA = "0x180C382F0")]
	public CGNBOJIKACE(Guid OKMPNEEAGBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0xC382E0", Offset = "0xC36CE0", VA = "0x180C382E0", Slot = "6")]
	public Guid MCPJDCOOMJK()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3EC13D0", Offset = "0x3EBFDD0", VA = "0x183EC13D0", Slot = "4")]
	public bool Equals(CGNBOJIKACE CGCLEIBHLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3EC1260", Offset = "0x3EBFC60", VA = "0x183EC1260", Slot = "5")]
	public int CompareTo(CGNBOJIKACE CGCLEIBHLHF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x72C3E30", Offset = "0x72C2830", VA = "0x1872C3E30", Slot = "0")]
	public override bool Equals(object FHFDEAHMMBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3EC1400", Offset = "0x3EBFE00", VA = "0x183EC1400", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3EC13D0", Offset = "0x3EBFDD0", VA = "0x183EC13D0")]
	public static bool JGJOKBKMGBC(CGNBOJIKACE OMCEEKENOBB, CGNBOJIKACE MOBHGIAPGGL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x72C3A20", Offset = "0x72C2420", VA = "0x1872C3A20")]
	public static bool DCLBGLCHDNG(CGNBOJIKACE OMCEEKENOBB, CGNBOJIKACE MOBHGIAPGGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x72C3ED0", Offset = "0x72C28D0", VA = "0x1872C3ED0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct ANINBIHMFJP : IEquatable<ANINBIHMFJP>, IComparable<ANINBIHMFJP>, DJFLCPIMHBF
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly ANINBIHMFJP CKLKOBNMKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Guid OKMPNEEAGBI;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xC382F0", Offset = "0xC36CF0", VA = "0x180C382F0")]
	public ANINBIHMFJP(Guid OKMPNEEAGBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0xC382E0", Offset = "0xC36CE0", VA = "0x180C382E0", Slot = "6")]
	public Guid MCPJDCOOMJK()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3EC13D0", Offset = "0x3EBFDD0", VA = "0x183EC13D0", Slot = "4")]
	public bool Equals(ANINBIHMFJP CGCLEIBHLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3EC1260", Offset = "0x3EBFC60", VA = "0x183EC1260", Slot = "5")]
	public int CompareTo(ANINBIHMFJP CGCLEIBHLHF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x72C3A50", Offset = "0x72C2450", VA = "0x1872C3A50", Slot = "0")]
	public override bool Equals(object FHFDEAHMMBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3EC1400", Offset = "0x3EBFE00", VA = "0x183EC1400", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3EC13D0", Offset = "0x3EBFDD0", VA = "0x183EC13D0")]
	public static bool JGJOKBKMGBC(ANINBIHMFJP OMCEEKENOBB, ANINBIHMFJP MOBHGIAPGGL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x72C3A20", Offset = "0x72C2420", VA = "0x1872C3A20")]
	public static bool DCLBGLCHDNG(ANINBIHMFJP OMCEEKENOBB, ANINBIHMFJP MOBHGIAPGGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x72C3AF0", Offset = "0x72C24F0", VA = "0x1872C3AF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct JMPGPJHNGAA : IEquatable<JMPGPJHNGAA>, IComparable<JMPGPJHNGAA>, DJFLCPIMHBF
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly JMPGPJHNGAA CKLKOBNMKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Guid OKMPNEEAGBI;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0xC382F0", Offset = "0xC36CF0", VA = "0x180C382F0")]
	public JMPGPJHNGAA(Guid OKMPNEEAGBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0xC382E0", Offset = "0xC36CE0", VA = "0x180C382E0", Slot = "6")]
	public Guid MCPJDCOOMJK()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3EC13D0", Offset = "0x3EBFDD0", VA = "0x183EC13D0", Slot = "4")]
	public bool Equals(JMPGPJHNGAA CGCLEIBHLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3EC1260", Offset = "0x3EBFC60", VA = "0x183EC1260", Slot = "5")]
	public int CompareTo(JMPGPJHNGAA CGCLEIBHLHF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x72C47A0", Offset = "0x72C31A0", VA = "0x1872C47A0", Slot = "0")]
	public override bool Equals(object FHFDEAHMMBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3EC1400", Offset = "0x3EBFE00", VA = "0x183EC1400", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3EC13D0", Offset = "0x3EBFDD0", VA = "0x183EC13D0")]
	public static bool JGJOKBKMGBC(JMPGPJHNGAA OMCEEKENOBB, JMPGPJHNGAA MOBHGIAPGGL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x72C3A20", Offset = "0x72C2420", VA = "0x1872C3A20")]
	public static bool DCLBGLCHDNG(JMPGPJHNGAA OMCEEKENOBB, JMPGPJHNGAA MOBHGIAPGGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x72C4840", Offset = "0x72C3240", VA = "0x1872C4840", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct DCOCEBIDGOP : IEquatable<DCOCEBIDGOP>, IComparable<DCOCEBIDGOP>, DJFLCPIMHBF
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly DCOCEBIDGOP CKLKOBNMKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Guid OKMPNEEAGBI;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0xC382F0", Offset = "0xC36CF0", VA = "0x180C382F0")]
	public DCOCEBIDGOP(Guid OKMPNEEAGBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0xC382E0", Offset = "0xC36CE0", VA = "0x180C382E0", Slot = "6")]
	public Guid MCPJDCOOMJK()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3EC13D0", Offset = "0x3EBFDD0", VA = "0x183EC13D0", Slot = "4")]
	public bool Equals(DCOCEBIDGOP CGCLEIBHLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3EC1260", Offset = "0x3EBFC60", VA = "0x183EC1260", Slot = "5")]
	public int CompareTo(DCOCEBIDGOP CGCLEIBHLHF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x72C3F40", Offset = "0x72C2940", VA = "0x1872C3F40", Slot = "0")]
	public override bool Equals(object FHFDEAHMMBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3EC1400", Offset = "0x3EBFE00", VA = "0x183EC1400", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3EC13D0", Offset = "0x3EBFDD0", VA = "0x183EC13D0")]
	public static bool JGJOKBKMGBC(DCOCEBIDGOP OMCEEKENOBB, DCOCEBIDGOP MOBHGIAPGGL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x72C3A20", Offset = "0x72C2420", VA = "0x1872C3A20")]
	public static bool DCLBGLCHDNG(DCOCEBIDGOP OMCEEKENOBB, DCOCEBIDGOP MOBHGIAPGGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x72C3FE0", Offset = "0x72C29E0", VA = "0x1872C3FE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct FAOJCMNAOGM : IEquatable<FAOJCMNAOGM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly string?[]? FGKKLDFPAMO;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool EMCJBNDMBFI
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x72C4520", Offset = "0x72C2F20", VA = "0x1872C4520")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int DKGIAGJENGK
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x4437A10", Offset = "0x4436410", VA = "0x184437A10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x72C4650", Offset = "0x72C3050", VA = "0x1872C4650")]
	public FAOJCMNAOGM(string? FDECENDMFFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x72C45D0", Offset = "0x72C2FD0", VA = "0x1872C45D0")]
	public FAOJCMNAOGM(string?[] NKDPGAHFHKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x72C4210", Offset = "0x72C2C10", VA = "0x1872C4210")]
	private static string?[]? GPJGENPAJHJ(string?[]? NKDPGAHFHKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x72C41B0", Offset = "0x72C2BB0", VA = "0x1872C41B0")]
	public string FEMFGCCOJKC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x72C40E0", Offset = "0x72C2AE0", VA = "0x1872C40E0", Slot = "4")]
	public bool Equals(FAOJCMNAOGM CGCLEIBHLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x72C4050", Offset = "0x72C2A50", VA = "0x1872C4050", Slot = "0")]
	public override bool Equals(object FHFDEAHMMBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x72C4440", Offset = "0x72C2E40", VA = "0x1872C4440", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x72C4540", Offset = "0x72C2F40", VA = "0x1872C4540", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct AHDECKGIPAM : IEquatable<AHDECKGIPAM>, IComparable<AHDECKGIPAM>, DJFLCPIMHBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Guid OKMPNEEAGBI;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xC382F0", Offset = "0xC36CF0", VA = "0x180C382F0")]
	public AHDECKGIPAM(Guid OKMPNEEAGBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xC382E0", Offset = "0xC36CE0", VA = "0x180C382E0", Slot = "6")]
	public Guid MCPJDCOOMJK()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x3EC13D0", Offset = "0x3EBFDD0", VA = "0x183EC13D0", Slot = "4")]
	public bool Equals(AHDECKGIPAM CGCLEIBHLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3EC1260", Offset = "0x3EBFC60", VA = "0x183EC1260", Slot = "5")]
	public int CompareTo(AHDECKGIPAM CGCLEIBHLHF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x72C3910", Offset = "0x72C2310", VA = "0x1872C3910", Slot = "0")]
	public override bool Equals(object FHFDEAHMMBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3EC1400", Offset = "0x3EBFE00", VA = "0x183EC1400", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x72C39B0", Offset = "0x72C23B0", VA = "0x1872C39B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface LJDDNBJAGCH<TModern> : FBIFJMHJDPK<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string CLOHIJJOAGB(TModern GCKACIBEBPF);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface DJFLCPIMHBF
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Guid MCPJDCOOMJK();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface FBIFJMHJDPK<out TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TModern KHDNCOAAIBJ(string GCKACIBEBPF);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface OELIFBKKNIM
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	LJDDNBJAGCH<OILMEJJBBPK> MJMGFCECOKF
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	LJDDNBJAGCH<CGNBOJIKACE> MIMFCGNNMPH
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	LJDDNBJAGCH<DCOCEBIDGOP> JLKHFEDAANP
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	LJDDNBJAGCH<AOFHBLCBKAK> DFIPJECFGKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	LJDDNBJAGCH<KOJLPHFPMHB> LBGOGBCDABB
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	LJDDNBJAGCH<JMPGPJHNGAA> DLJCCJHEEKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	LJDDNBJAGCH<PIAPLLICGDA> HFCPNGPFCJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	LJDDNBJAGCH<ANINBIHMFJP> GFNMMLEBDAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class BMEDJIPAIOH
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static readonly char[] GLEKCPLKGCN;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x72C3D00", Offset = "0x72C2700", VA = "0x1872C3D00")]
	public static string[] EBHNNMOBHEP(string? FDECENDMFFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x72C3CD0", Offset = "0x72C26D0", VA = "0x1872C3CD0")]
	public static string? ALOGKIAMIOL(string? LAPNIHDLAOI)
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
