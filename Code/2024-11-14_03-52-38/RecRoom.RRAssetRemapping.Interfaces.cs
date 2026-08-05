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
		[Cpp2IlInjected.Address(RVA = "0x8C5550", Offset = "0x8C4950", VA = "0x1808C5550")]
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
		[Cpp2IlInjected.Address(RVA = "0x74A5EB0", Offset = "0x74A52B0", VA = "0x1874A5EB0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8C5B80", Offset = "0x8C4F80", VA = "0x1808C5B80")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C5BC0", Offset = "0x8C4FC0", VA = "0x1808C5BC0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface HCFCMHHHCHA
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string IJIPNHCCMND(MMGKCPFJLPI CMILLOOAKEN);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MMGKCPFJLPI LIJBJHOEHGL(string CMILLOOAKEN);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct MMGKCPFJLPI : IEquatable<MMGKCPFJLPI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly DGMNJDBAMFC NKECLEABJDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly HLKLPNJACJF BJGLCDJPPBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly Guid GEDOHMBPDJJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool PPODMDPCEDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x74A5920", Offset = "0x74A4D20", VA = "0x1874A5920")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool FHDPCMPJAEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x74A5860", Offset = "0x74A4C60", VA = "0x1874A5860")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x74A5D20", Offset = "0x74A5120", VA = "0x1874A5D20")]
	public MMGKCPFJLPI(MMGKCPFJLPI GOAGAOKBBIK, [Optional] Guid NMPFPMNJMLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x505E220", Offset = "0x505D620", VA = "0x18505E220")]
	public MMGKCPFJLPI(DGMNJDBAMFC NACKNPKJLNN, HLKLPNJACJF PDGHBMKIDAB, [Optional] Guid NMPFPMNJMLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x74A57A0", Offset = "0x74A4BA0", VA = "0x1874A57A0", Slot = "4")]
	public bool Equals(MMGKCPFJLPI OGKFFDCECEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x74A56F0", Offset = "0x74A4AF0", VA = "0x1874A56F0", Slot = "0")]
	public override bool Equals(object FAKGLFFOLFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x74A5890", Offset = "0x74A4C90", VA = "0x1874A5890", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x74A59B0", Offset = "0x74A4DB0", VA = "0x1874A59B0")]
	public static bool LIIBJCIOAJF(MMGKCPFJLPI CGCHNDGEIJH, MMGKCPFJLPI LEGMFFDGEGA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x74A59E0", Offset = "0x74A4DE0", VA = "0x1874A59E0")]
	public static bool MGKNLGFCPBK(MMGKCPFJLPI CGCHNDGEIJH, MMGKCPFJLPI LEGMFFDGEGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x74A5A20", Offset = "0x74A4E20", VA = "0x1874A5A20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct DGMNJDBAMFC : IEquatable<DGMNJDBAMFC>, IComparable<DGMNJDBAMFC>, MBFEJGKNDJG
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly DGMNJDBAMFC HABKGKOFNKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Guid MDOJFEIEAFI;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0xD068A0", Offset = "0xD05CA0", VA = "0x180D068A0")]
	public DGMNJDBAMFC(Guid MDOJFEIEAFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0xD068B0", Offset = "0xD05CB0", VA = "0x180D068B0", Slot = "6")]
	public Guid IJFDEGDMNBA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3BA86F0", Offset = "0x3BA7AF0", VA = "0x183BA86F0", Slot = "4")]
	public bool Equals(DGMNJDBAMFC OGKFFDCECEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3BA81F0", Offset = "0x3BA75F0", VA = "0x183BA81F0", Slot = "5")]
	public int CompareTo(DGMNJDBAMFC OGKFFDCECEL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x74A4DE0", Offset = "0x74A41E0", VA = "0x1874A4DE0", Slot = "0")]
	public override bool Equals(object FAKGLFFOLFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3BA8300", Offset = "0x3BA7700", VA = "0x183BA8300", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3BA86F0", Offset = "0x3BA7AF0", VA = "0x183BA86F0")]
	public static bool LIIBJCIOAJF(DGMNJDBAMFC CGCHNDGEIJH, DGMNJDBAMFC LEGMFFDGEGA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x74A4E80", Offset = "0x74A4280", VA = "0x1874A4E80")]
	public static bool MGKNLGFCPBK(DGMNJDBAMFC CGCHNDGEIJH, DGMNJDBAMFC LEGMFFDGEGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x74A4EB0", Offset = "0x74A42B0", VA = "0x1874A4EB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct HAFPIFMFCGN : IEquatable<HAFPIFMFCGN>, IComparable<HAFPIFMFCGN>, MBFEJGKNDJG
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static readonly HAFPIFMFCGN HABKGKOFNKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Guid MDOJFEIEAFI;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xD068A0", Offset = "0xD05CA0", VA = "0x180D068A0")]
	public HAFPIFMFCGN(Guid MDOJFEIEAFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0xD068B0", Offset = "0xD05CB0", VA = "0x180D068B0", Slot = "6")]
	public Guid IJFDEGDMNBA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3BA86F0", Offset = "0x3BA7AF0", VA = "0x183BA86F0", Slot = "4")]
	public bool Equals(HAFPIFMFCGN OGKFFDCECEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3BA81F0", Offset = "0x3BA75F0", VA = "0x183BA81F0", Slot = "5")]
	public int CompareTo(HAFPIFMFCGN OGKFFDCECEL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x74A5250", Offset = "0x74A4650", VA = "0x1874A5250", Slot = "0")]
	public override bool Equals(object FAKGLFFOLFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3BA8300", Offset = "0x3BA7700", VA = "0x183BA8300", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3BA86F0", Offset = "0x3BA7AF0", VA = "0x183BA86F0")]
	public static bool LIIBJCIOAJF(HAFPIFMFCGN CGCHNDGEIJH, HAFPIFMFCGN LEGMFFDGEGA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x74A4E80", Offset = "0x74A4280", VA = "0x1874A4E80")]
	public static bool MGKNLGFCPBK(HAFPIFMFCGN CGCHNDGEIJH, HAFPIFMFCGN LEGMFFDGEGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x74A52F0", Offset = "0x74A46F0", VA = "0x1874A52F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct PJINIDKILAA : IEquatable<PJINIDKILAA>, IComparable<PJINIDKILAA>, MBFEJGKNDJG
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public static readonly PJINIDKILAA HABKGKOFNKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Guid MDOJFEIEAFI;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0xD068A0", Offset = "0xD05CA0", VA = "0x180D068A0")]
	public PJINIDKILAA(Guid MDOJFEIEAFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0xD068B0", Offset = "0xD05CB0", VA = "0x180D068B0", Slot = "6")]
	public Guid IJFDEGDMNBA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3BA86F0", Offset = "0x3BA7AF0", VA = "0x183BA86F0", Slot = "4")]
	public bool Equals(PJINIDKILAA OGKFFDCECEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3BA81F0", Offset = "0x3BA75F0", VA = "0x183BA81F0", Slot = "5")]
	public int CompareTo(PJINIDKILAA OGKFFDCECEL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x74A6680", Offset = "0x74A5A80", VA = "0x1874A6680", Slot = "0")]
	public override bool Equals(object FAKGLFFOLFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3BA8300", Offset = "0x3BA7700", VA = "0x183BA8300", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3BA86F0", Offset = "0x3BA7AF0", VA = "0x183BA86F0")]
	public static bool LIIBJCIOAJF(PJINIDKILAA CGCHNDGEIJH, PJINIDKILAA LEGMFFDGEGA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x74A4E80", Offset = "0x74A4280", VA = "0x1874A4E80")]
	public static bool MGKNLGFCPBK(PJINIDKILAA CGCHNDGEIJH, PJINIDKILAA LEGMFFDGEGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x74A6720", Offset = "0x74A5B20", VA = "0x1874A6720", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct HLKLPNJACJF : IEquatable<HLKLPNJACJF>, IComparable<HLKLPNJACJF>, MBFEJGKNDJG
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly HLKLPNJACJF HABKGKOFNKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Guid MDOJFEIEAFI;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0xD068A0", Offset = "0xD05CA0", VA = "0x180D068A0")]
	public HLKLPNJACJF(Guid MDOJFEIEAFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0xD068B0", Offset = "0xD05CB0", VA = "0x180D068B0", Slot = "6")]
	public Guid IJFDEGDMNBA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x74A5360", Offset = "0x74A4760", VA = "0x1874A5360", Slot = "4")]
	public bool Equals(HLKLPNJACJF OGKFFDCECEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x74A5390", Offset = "0x74A4790", VA = "0x1874A5390", Slot = "0")]
	public override bool Equals(object FAKGLFFOLFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3BA8300", Offset = "0x3BA7700", VA = "0x183BA8300", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x74A5360", Offset = "0x74A4760", VA = "0x1874A5360")]
	public static bool LIIBJCIOAJF(HLKLPNJACJF CGCHNDGEIJH, HLKLPNJACJF LEGMFFDGEGA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x74A5430", Offset = "0x74A4830", VA = "0x1874A5430")]
	public static bool MGKNLGFCPBK(HLKLPNJACJF CGCHNDGEIJH, HLKLPNJACJF LEGMFFDGEGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3BA81F0", Offset = "0x3BA75F0", VA = "0x183BA81F0", Slot = "5")]
	public int CompareTo(HLKLPNJACJF OGKFFDCECEL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x74A5460", Offset = "0x74A4860", VA = "0x1874A5460", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0xD068A0", Offset = "0xD05CA0", VA = "0x180D068A0")]
	public HLKLPNJACJF(FILLGFDGBDC LFCBPOPIDPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct LCPEJHNINJI : IEquatable<LCPEJHNINJI>, IComparable<LCPEJHNINJI>, MBFEJGKNDJG
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly LCPEJHNINJI HABKGKOFNKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Guid MDOJFEIEAFI;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0xD068A0", Offset = "0xD05CA0", VA = "0x180D068A0")]
	public LCPEJHNINJI(Guid MDOJFEIEAFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0xD068B0", Offset = "0xD05CB0", VA = "0x180D068B0", Slot = "6")]
	public Guid IJFDEGDMNBA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3BA86F0", Offset = "0x3BA7AF0", VA = "0x183BA86F0", Slot = "4")]
	public bool Equals(LCPEJHNINJI OGKFFDCECEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3BA81F0", Offset = "0x3BA75F0", VA = "0x183BA81F0", Slot = "5")]
	public int CompareTo(LCPEJHNINJI OGKFFDCECEL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x74A55E0", Offset = "0x74A49E0", VA = "0x1874A55E0", Slot = "0")]
	public override bool Equals(object FAKGLFFOLFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3BA8300", Offset = "0x3BA7700", VA = "0x183BA8300", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3BA86F0", Offset = "0x3BA7AF0", VA = "0x183BA86F0")]
	public static bool LIIBJCIOAJF(LCPEJHNINJI CGCHNDGEIJH, LCPEJHNINJI LEGMFFDGEGA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x74A4E80", Offset = "0x74A4280", VA = "0x1874A4E80")]
	public static bool MGKNLGFCPBK(LCPEJHNINJI CGCHNDGEIJH, LCPEJHNINJI LEGMFFDGEGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x74A5680", Offset = "0x74A4A80", VA = "0x1874A5680", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct JHKPFMPLNBA : IEquatable<JHKPFMPLNBA>, IComparable<JHKPFMPLNBA>, MBFEJGKNDJG
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly JHKPFMPLNBA HABKGKOFNKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Guid MDOJFEIEAFI;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xD068A0", Offset = "0xD05CA0", VA = "0x180D068A0")]
	public JHKPFMPLNBA(Guid MDOJFEIEAFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0xD068B0", Offset = "0xD05CB0", VA = "0x180D068B0", Slot = "6")]
	public Guid IJFDEGDMNBA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3BA86F0", Offset = "0x3BA7AF0", VA = "0x183BA86F0", Slot = "4")]
	public bool Equals(JHKPFMPLNBA OGKFFDCECEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3BA81F0", Offset = "0x3BA75F0", VA = "0x183BA81F0", Slot = "5")]
	public int CompareTo(JHKPFMPLNBA OGKFFDCECEL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x74A54D0", Offset = "0x74A48D0", VA = "0x1874A54D0", Slot = "0")]
	public override bool Equals(object FAKGLFFOLFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3BA8300", Offset = "0x3BA7700", VA = "0x183BA8300", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3BA86F0", Offset = "0x3BA7AF0", VA = "0x183BA86F0")]
	public static bool LIIBJCIOAJF(JHKPFMPLNBA CGCHNDGEIJH, JHKPFMPLNBA LEGMFFDGEGA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x74A4E80", Offset = "0x74A4280", VA = "0x1874A4E80")]
	public static bool MGKNLGFCPBK(JHKPFMPLNBA CGCHNDGEIJH, JHKPFMPLNBA LEGMFFDGEGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x74A5570", Offset = "0x74A4970", VA = "0x1874A5570", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct EBPOPODBICM : IEquatable<EBPOPODBICM>, IComparable<EBPOPODBICM>, MBFEJGKNDJG
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly EBPOPODBICM HABKGKOFNKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Guid MDOJFEIEAFI;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0xD068A0", Offset = "0xD05CA0", VA = "0x180D068A0")]
	public EBPOPODBICM(Guid MDOJFEIEAFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0xD068B0", Offset = "0xD05CB0", VA = "0x180D068B0", Slot = "6")]
	public Guid IJFDEGDMNBA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3BA86F0", Offset = "0x3BA7AF0", VA = "0x183BA86F0", Slot = "4")]
	public bool Equals(EBPOPODBICM OGKFFDCECEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3BA81F0", Offset = "0x3BA75F0", VA = "0x183BA81F0", Slot = "5")]
	public int CompareTo(EBPOPODBICM OGKFFDCECEL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x74A4F20", Offset = "0x74A4320", VA = "0x1874A4F20", Slot = "0")]
	public override bool Equals(object FAKGLFFOLFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3BA8300", Offset = "0x3BA7700", VA = "0x183BA8300", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3BA86F0", Offset = "0x3BA7AF0", VA = "0x183BA86F0")]
	public static bool LIIBJCIOAJF(EBPOPODBICM CGCHNDGEIJH, EBPOPODBICM LEGMFFDGEGA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x74A4E80", Offset = "0x74A4280", VA = "0x1874A4E80")]
	public static bool MGKNLGFCPBK(EBPOPODBICM CGCHNDGEIJH, EBPOPODBICM LEGMFFDGEGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x74A4FC0", Offset = "0x74A43C0", VA = "0x1874A4FC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct GLMFFLOLMCM : IEquatable<GLMFFLOLMCM>, IComparable<GLMFFLOLMCM>, MBFEJGKNDJG
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly GLMFFLOLMCM HABKGKOFNKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Guid MDOJFEIEAFI;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0xD068A0", Offset = "0xD05CA0", VA = "0x180D068A0")]
	public GLMFFLOLMCM(Guid MDOJFEIEAFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0xD068B0", Offset = "0xD05CB0", VA = "0x180D068B0", Slot = "6")]
	public Guid IJFDEGDMNBA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3BA86F0", Offset = "0x3BA7AF0", VA = "0x183BA86F0", Slot = "4")]
	public bool Equals(GLMFFLOLMCM OGKFFDCECEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3BA81F0", Offset = "0x3BA75F0", VA = "0x183BA81F0", Slot = "5")]
	public int CompareTo(GLMFFLOLMCM OGKFFDCECEL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x74A5140", Offset = "0x74A4540", VA = "0x1874A5140", Slot = "0")]
	public override bool Equals(object FAKGLFFOLFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3BA8300", Offset = "0x3BA7700", VA = "0x183BA8300", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3BA86F0", Offset = "0x3BA7AF0", VA = "0x183BA86F0")]
	public static bool LIIBJCIOAJF(GLMFFLOLMCM CGCHNDGEIJH, GLMFFLOLMCM LEGMFFDGEGA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x74A4E80", Offset = "0x74A4280", VA = "0x1874A4E80")]
	public static bool MGKNLGFCPBK(GLMFFLOLMCM CGCHNDGEIJH, GLMFFLOLMCM LEGMFFDGEGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x74A51E0", Offset = "0x74A45E0", VA = "0x1874A51E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct PFOMBIPKCAJ : IEquatable<PFOMBIPKCAJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly string?[]? MDLGNADOLLE;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool FKFNLLHBIGN
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x74A6400", Offset = "0x74A5800", VA = "0x1874A6400")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int CBNAKLJGDHF
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x45A2C40", Offset = "0x45A2040", VA = "0x1845A2C40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x74A64B0", Offset = "0x74A58B0", VA = "0x1874A64B0")]
	public PFOMBIPKCAJ(string? FJGALFOHAJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x74A6600", Offset = "0x74A5A00", VA = "0x1874A6600")]
	public PFOMBIPKCAJ(string?[] DMIJPGLIAND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x74A5F30", Offset = "0x74A5330", VA = "0x1874A5F30")]
	private static string?[]? AMEOOJGNIBB(string?[]? DMIJPGLIAND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x74A63A0", Offset = "0x74A57A0", VA = "0x1874A63A0")]
	public string LNKAMEBIJGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x74A61F0", Offset = "0x74A55F0", VA = "0x1874A61F0", Slot = "4")]
	public bool Equals(PFOMBIPKCAJ OGKFFDCECEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x74A6160", Offset = "0x74A5560", VA = "0x1874A6160", Slot = "0")]
	public override bool Equals(object FAKGLFFOLFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x74A62C0", Offset = "0x74A56C0", VA = "0x1874A62C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x74A6420", Offset = "0x74A5820", VA = "0x1874A6420", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct FILLGFDGBDC : IEquatable<FILLGFDGBDC>, IComparable<FILLGFDGBDC>, MBFEJGKNDJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Guid MDOJFEIEAFI;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xD068A0", Offset = "0xD05CA0", VA = "0x180D068A0")]
	public FILLGFDGBDC(Guid MDOJFEIEAFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xD068B0", Offset = "0xD05CB0", VA = "0x180D068B0", Slot = "6")]
	public Guid IJFDEGDMNBA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x3BA86F0", Offset = "0x3BA7AF0", VA = "0x183BA86F0", Slot = "4")]
	public bool Equals(FILLGFDGBDC OGKFFDCECEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3BA81F0", Offset = "0x3BA75F0", VA = "0x183BA81F0", Slot = "5")]
	public int CompareTo(FILLGFDGBDC OGKFFDCECEL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x74A5030", Offset = "0x74A4430", VA = "0x1874A5030", Slot = "0")]
	public override bool Equals(object FAKGLFFOLFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3BA8300", Offset = "0x3BA7700", VA = "0x183BA8300", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x74A50D0", Offset = "0x74A44D0", VA = "0x1874A50D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface POOCNPDLGKI<TModern> : KOMBNKFLGBG<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string NBJANDKBPOK(TModern ACBKNNEMOKM);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface MBFEJGKNDJG
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Guid IJFDEGDMNBA();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface KOMBNKFLGBG<out TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TModern MCKPHFIGIFA(string ACBKNNEMOKM);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface LDBPMFKPPIO
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	POOCNPDLGKI<DGMNJDBAMFC> PLOMPPDNBBG
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	POOCNPDLGKI<LCPEJHNINJI> HBFGILLMPPD
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	POOCNPDLGKI<GLMFFLOLMCM> IODKLOBAJGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	POOCNPDLGKI<HLKLPNJACJF> OIJEKKLIKDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	POOCNPDLGKI<PJINIDKILAA> MBMAHIKOONN
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	POOCNPDLGKI<EBPOPODBICM> ACIFJLIDOEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	POOCNPDLGKI<HAFPIFMFCGN> AJNMJFECDOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	POOCNPDLGKI<JHKPFMPLNBA> PLJFKKIOBJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class NAPJHCDIKIE
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static readonly char[] ONDEBEJPENO;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x74A5D70", Offset = "0x74A5170", VA = "0x1874A5D70")]
	public static string[] PHABKJAJBGN(string? FJGALFOHAJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x74A5D40", Offset = "0x74A5140", VA = "0x1874A5D40")]
	public static string? EEDCHLIPNGK(string? NACKNPKJLNN)
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
