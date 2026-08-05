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
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x836D1C0", Offset = "0x836B9C0", VA = "0x18836D1C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA09330", Offset = "0xA07B30", VA = "0x180A09330")]
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
		[Cpp2IlInjected.Address(RVA = "0xA09370", Offset = "0xA07B70", VA = "0x180A09370")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface GJKCLLPHCAN
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string LIJGMGKAKKG(AJELBAFCNLN JEOEDPICHHI);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AJELBAFCNLN MPBEICGIKAG(string JEOEDPICHHI);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct AJELBAFCNLN : IEquatable<AJELBAFCNLN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly MFBAIOHMEOF FJJLDHGENBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly EGIKODNAABF KLGFMLNJHMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly Guid ACPBCEPFHAA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool JOEEFKDLHCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x836BD80", Offset = "0x836A580", VA = "0x18836BD80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool GNMHHCBPIGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x836BCC0", Offset = "0x836A4C0", VA = "0x18836BCC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x836C140", Offset = "0x836A940", VA = "0x18836C140")]
	public AJELBAFCNLN(AJELBAFCNLN JGGCDNFKPFH, [Optional] Guid KAAGPNJIINH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5B5DBF0", Offset = "0x5B5C3F0", VA = "0x185B5DBF0")]
	public AJELBAFCNLN(MFBAIOHMEOF IOFOJGFFCHA, EGIKODNAABF OKNONCCGJKA, [Optional] Guid KAAGPNJIINH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x836BB50", Offset = "0x836A350", VA = "0x18836BB50", Slot = "4")]
	public bool Equals(AJELBAFCNLN PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x836BC10", Offset = "0x836A410", VA = "0x18836BC10", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x836BCF0", Offset = "0x836A4F0", VA = "0x18836BCF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x836BE10", Offset = "0x836A610", VA = "0x18836BE10")]
	public static bool NIDGPKKMDPO(AJELBAFCNLN HKAFAMHBCLL, AJELBAFCNLN JAKFFJGMBEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x836BE40", Offset = "0x836A640", VA = "0x18836BE40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct MFBAIOHMEOF : IEquatable<MFBAIOHMEOF>, IComparable<MFBAIOHMEOF>, EHKBGADHGBA
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly MFBAIOHMEOF HMAILHHHNAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Guid BGPPHEMBCAA;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x11E6660", Offset = "0x11E4E60", VA = "0x1811E6660")]
	public MFBAIOHMEOF(Guid BGPPHEMBCAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x11E6670", Offset = "0x11E4E70", VA = "0x1811E6670", Slot = "6")]
	public Guid CIAECGMGKIC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x64D60C0", Offset = "0x64D48C0", VA = "0x1864D60C0", Slot = "4")]
	public bool Equals(MFBAIOHMEOF PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x64D5F70", Offset = "0x64D4770", VA = "0x1864D5F70", Slot = "5")]
	public int CompareTo(MFBAIOHMEOF PGPJMFPAKOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x836CFA0", Offset = "0x836B7A0", VA = "0x18836CFA0", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x64D60A0", Offset = "0x64D48A0", VA = "0x1864D60A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x64D60C0", Offset = "0x64D48C0", VA = "0x1864D60C0")]
	public static bool NIDGPKKMDPO(MFBAIOHMEOF HKAFAMHBCLL, MFBAIOHMEOF JAKFFJGMBEJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x836C310", Offset = "0x836AB10", VA = "0x18836C310")]
	public static bool ONONOJDPAAN(MFBAIOHMEOF HKAFAMHBCLL, MFBAIOHMEOF JAKFFJGMBEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x836D040", Offset = "0x836B840", VA = "0x18836D040", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct GIIEABJDIBB : IEquatable<GIIEABJDIBB>, IComparable<GIIEABJDIBB>, EHKBGADHGBA
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static readonly GIIEABJDIBB HMAILHHHNAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Guid BGPPHEMBCAA;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x11E6660", Offset = "0x11E4E60", VA = "0x1811E6660")]
	public GIIEABJDIBB(Guid BGPPHEMBCAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x11E6670", Offset = "0x11E4E70", VA = "0x1811E6670", Slot = "6")]
	public Guid CIAECGMGKIC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x64D60C0", Offset = "0x64D48C0", VA = "0x1864D60C0", Slot = "4")]
	public bool Equals(GIIEABJDIBB PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x64D5F70", Offset = "0x64D4770", VA = "0x1864D5F70", Slot = "5")]
	public int CompareTo(GIIEABJDIBB PGPJMFPAKOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x836C630", Offset = "0x836AE30", VA = "0x18836C630", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x64D60A0", Offset = "0x64D48A0", VA = "0x1864D60A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x64D60C0", Offset = "0x64D48C0", VA = "0x1864D60C0")]
	public static bool NIDGPKKMDPO(GIIEABJDIBB HKAFAMHBCLL, GIIEABJDIBB JAKFFJGMBEJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x836C310", Offset = "0x836AB10", VA = "0x18836C310")]
	public static bool ONONOJDPAAN(GIIEABJDIBB HKAFAMHBCLL, GIIEABJDIBB JAKFFJGMBEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x836C6D0", Offset = "0x836AED0", VA = "0x18836C6D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct HHIJJAHMBEN : IEquatable<HHIJJAHMBEN>, IComparable<HHIJJAHMBEN>, EHKBGADHGBA
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public static readonly HHIJJAHMBEN HMAILHHHNAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Guid BGPPHEMBCAA;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x11E6660", Offset = "0x11E4E60", VA = "0x1811E6660")]
	public HHIJJAHMBEN(Guid BGPPHEMBCAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x11E6670", Offset = "0x11E4E70", VA = "0x1811E6670", Slot = "6")]
	public Guid CIAECGMGKIC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x64D60C0", Offset = "0x64D48C0", VA = "0x1864D60C0", Slot = "4")]
	public bool Equals(HHIJJAHMBEN PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x64D5F70", Offset = "0x64D4770", VA = "0x1864D5F70", Slot = "5")]
	public int CompareTo(HHIJJAHMBEN PGPJMFPAKOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x836C740", Offset = "0x836AF40", VA = "0x18836C740", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x64D60A0", Offset = "0x64D48A0", VA = "0x1864D60A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x64D60C0", Offset = "0x64D48C0", VA = "0x1864D60C0")]
	public static bool NIDGPKKMDPO(HHIJJAHMBEN HKAFAMHBCLL, HHIJJAHMBEN JAKFFJGMBEJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x836C310", Offset = "0x836AB10", VA = "0x18836C310")]
	public static bool ONONOJDPAAN(HHIJJAHMBEN HKAFAMHBCLL, HHIJJAHMBEN JAKFFJGMBEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x836C7E0", Offset = "0x836AFE0", VA = "0x18836C7E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct EGIKODNAABF : IEquatable<EGIKODNAABF>, IComparable<EGIKODNAABF>, EHKBGADHGBA
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly EGIKODNAABF HMAILHHHNAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Guid BGPPHEMBCAA;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x11E6660", Offset = "0x11E4E60", VA = "0x1811E6660")]
	public EGIKODNAABF(Guid BGPPHEMBCAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x11E6670", Offset = "0x11E4E70", VA = "0x1811E6670", Slot = "6")]
	public Guid CIAECGMGKIC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x836C3B0", Offset = "0x836ABB0", VA = "0x18836C3B0", Slot = "4")]
	public bool Equals(EGIKODNAABF PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x836C3E0", Offset = "0x836ABE0", VA = "0x18836C3E0", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x64D60A0", Offset = "0x64D48A0", VA = "0x1864D60A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x836C3B0", Offset = "0x836ABB0", VA = "0x18836C3B0")]
	public static bool NIDGPKKMDPO(EGIKODNAABF HKAFAMHBCLL, EGIKODNAABF JAKFFJGMBEJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x836C480", Offset = "0x836AC80", VA = "0x18836C480")]
	public static bool ONONOJDPAAN(EGIKODNAABF HKAFAMHBCLL, EGIKODNAABF JAKFFJGMBEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x64D5F70", Offset = "0x64D4770", VA = "0x1864D5F70", Slot = "5")]
	public int CompareTo(EGIKODNAABF PGPJMFPAKOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x836C4B0", Offset = "0x836ACB0", VA = "0x18836C4B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x11E6660", Offset = "0x11E4E60", VA = "0x1811E6660")]
	public EGIKODNAABF(CKDOFMNFPNB MDPLGNFGFGG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct PLPAABLOIJF : IEquatable<PLPAABLOIJF>, IComparable<PLPAABLOIJF>, EHKBGADHGBA
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly PLPAABLOIJF HMAILHHHNAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Guid BGPPHEMBCAA;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x11E6660", Offset = "0x11E4E60", VA = "0x1811E6660")]
	public PLPAABLOIJF(Guid BGPPHEMBCAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x11E6670", Offset = "0x11E4E70", VA = "0x1811E6670", Slot = "6")]
	public Guid CIAECGMGKIC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x64D60C0", Offset = "0x64D48C0", VA = "0x1864D60C0", Slot = "4")]
	public bool Equals(PLPAABLOIJF PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x64D5F70", Offset = "0x64D4770", VA = "0x1864D5F70", Slot = "5")]
	public int CompareTo(PLPAABLOIJF PGPJMFPAKOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x836D3A0", Offset = "0x836BBA0", VA = "0x18836D3A0", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x64D60A0", Offset = "0x64D48A0", VA = "0x1864D60A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x64D60C0", Offset = "0x64D48C0", VA = "0x1864D60C0")]
	public static bool NIDGPKKMDPO(PLPAABLOIJF HKAFAMHBCLL, PLPAABLOIJF JAKFFJGMBEJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x836C310", Offset = "0x836AB10", VA = "0x18836C310")]
	public static bool ONONOJDPAAN(PLPAABLOIJF HKAFAMHBCLL, PLPAABLOIJF JAKFFJGMBEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x836D440", Offset = "0x836BC40", VA = "0x18836D440", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct MFGHHKBHMBD : IEquatable<MFGHHKBHMBD>, IComparable<MFGHHKBHMBD>, EHKBGADHGBA
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly MFGHHKBHMBD HMAILHHHNAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Guid BGPPHEMBCAA;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x11E6660", Offset = "0x11E4E60", VA = "0x1811E6660")]
	public MFGHHKBHMBD(Guid BGPPHEMBCAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x11E6670", Offset = "0x11E4E70", VA = "0x1811E6670", Slot = "6")]
	public Guid CIAECGMGKIC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x64D60C0", Offset = "0x64D48C0", VA = "0x1864D60C0", Slot = "4")]
	public bool Equals(MFGHHKBHMBD PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x64D5F70", Offset = "0x64D4770", VA = "0x1864D5F70", Slot = "5")]
	public int CompareTo(MFGHHKBHMBD PGPJMFPAKOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x836D0B0", Offset = "0x836B8B0", VA = "0x18836D0B0", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x64D60A0", Offset = "0x64D48A0", VA = "0x1864D60A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x64D60C0", Offset = "0x64D48C0", VA = "0x1864D60C0")]
	public static bool NIDGPKKMDPO(MFGHHKBHMBD HKAFAMHBCLL, MFGHHKBHMBD JAKFFJGMBEJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x836C310", Offset = "0x836AB10", VA = "0x18836C310")]
	public static bool ONONOJDPAAN(MFGHHKBHMBD HKAFAMHBCLL, MFGHHKBHMBD JAKFFJGMBEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x836D150", Offset = "0x836B950", VA = "0x18836D150", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct EGPFHAHNEED : IEquatable<EGPFHAHNEED>, IComparable<EGPFHAHNEED>, EHKBGADHGBA
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly EGPFHAHNEED HMAILHHHNAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Guid BGPPHEMBCAA;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x11E6660", Offset = "0x11E4E60", VA = "0x1811E6660")]
	public EGPFHAHNEED(Guid BGPPHEMBCAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x11E6670", Offset = "0x11E4E70", VA = "0x1811E6670", Slot = "6")]
	public Guid CIAECGMGKIC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x64D60C0", Offset = "0x64D48C0", VA = "0x1864D60C0", Slot = "4")]
	public bool Equals(EGPFHAHNEED PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x64D5F70", Offset = "0x64D4770", VA = "0x1864D5F70", Slot = "5")]
	public int CompareTo(EGPFHAHNEED PGPJMFPAKOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x836C520", Offset = "0x836AD20", VA = "0x18836C520", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x64D60A0", Offset = "0x64D48A0", VA = "0x1864D60A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x64D60C0", Offset = "0x64D48C0", VA = "0x1864D60C0")]
	public static bool NIDGPKKMDPO(EGPFHAHNEED HKAFAMHBCLL, EGPFHAHNEED JAKFFJGMBEJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x836C310", Offset = "0x836AB10", VA = "0x18836C310")]
	public static bool ONONOJDPAAN(EGPFHAHNEED HKAFAMHBCLL, EGPFHAHNEED JAKFFJGMBEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x836C5C0", Offset = "0x836ADC0", VA = "0x18836C5C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct DAMJGPCPPIE : IEquatable<DAMJGPCPPIE>, IComparable<DAMJGPCPPIE>, EHKBGADHGBA
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly DAMJGPCPPIE HMAILHHHNAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Guid BGPPHEMBCAA;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x11E6660", Offset = "0x11E4E60", VA = "0x1811E6660")]
	public DAMJGPCPPIE(Guid BGPPHEMBCAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x11E6670", Offset = "0x11E4E70", VA = "0x1811E6670", Slot = "6")]
	public Guid CIAECGMGKIC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x64D60C0", Offset = "0x64D48C0", VA = "0x1864D60C0", Slot = "4")]
	public bool Equals(DAMJGPCPPIE PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x64D5F70", Offset = "0x64D4770", VA = "0x1864D5F70", Slot = "5")]
	public int CompareTo(DAMJGPCPPIE PGPJMFPAKOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x836C270", Offset = "0x836AA70", VA = "0x18836C270", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x64D60A0", Offset = "0x64D48A0", VA = "0x1864D60A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x64D60C0", Offset = "0x64D48C0", VA = "0x1864D60C0")]
	public static bool NIDGPKKMDPO(DAMJGPCPPIE HKAFAMHBCLL, DAMJGPCPPIE JAKFFJGMBEJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x836C310", Offset = "0x836AB10", VA = "0x18836C310")]
	public static bool ONONOJDPAAN(DAMJGPCPPIE HKAFAMHBCLL, DAMJGPCPPIE JAKFFJGMBEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x836C340", Offset = "0x836AB40", VA = "0x18836C340", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct HICLAFCEFNC : IEquatable<HICLAFCEFNC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly string?[]? JNKPGDOEOFE;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool KBDBMNHHFOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x836CD20", Offset = "0x836B520", VA = "0x18836CD20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int DPBGNDGAIMM
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4EAA980", Offset = "0x4EA9180", VA = "0x184EAA980")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x836CE50", Offset = "0x836B650", VA = "0x18836CE50")]
	public HICLAFCEFNC(string? AMEDOFBMGEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x836CDD0", Offset = "0x836B5D0", VA = "0x18836CDD0")]
	public HICLAFCEFNC(string?[] FIJIAOGGNAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x836C850", Offset = "0x836B050", VA = "0x18836C850")]
	private static string?[]? AMENELHDECM(string?[]? FIJIAOGGNAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x836CA80", Offset = "0x836B280", VA = "0x18836CA80")]
	public string CJACHDEBJLP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x836CB70", Offset = "0x836B370", VA = "0x18836CB70", Slot = "4")]
	public bool Equals(HICLAFCEFNC PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x836CAE0", Offset = "0x836B2E0", VA = "0x18836CAE0", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x836CC40", Offset = "0x836B440", VA = "0x18836CC40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x836CD40", Offset = "0x836B540", VA = "0x18836CD40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct CKDOFMNFPNB : IEquatable<CKDOFMNFPNB>, IComparable<CKDOFMNFPNB>, EHKBGADHGBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Guid BGPPHEMBCAA;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x11E6660", Offset = "0x11E4E60", VA = "0x1811E6660")]
	public CKDOFMNFPNB(Guid BGPPHEMBCAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x11E6670", Offset = "0x11E4E70", VA = "0x1811E6670", Slot = "6")]
	public Guid CIAECGMGKIC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x64D60C0", Offset = "0x64D48C0", VA = "0x1864D60C0", Slot = "4")]
	public bool Equals(CKDOFMNFPNB PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x64D5F70", Offset = "0x64D4770", VA = "0x1864D5F70", Slot = "5")]
	public int CompareTo(CKDOFMNFPNB PGPJMFPAKOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x836C160", Offset = "0x836A960", VA = "0x18836C160", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x64D60A0", Offset = "0x64D48A0", VA = "0x1864D60A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x836C200", Offset = "0x836AA00", VA = "0x18836C200", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface DJAOJFIAGJB<TModern> : PIPOPGBHJAI<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string OEHPOIANCLJ(TModern AJACLEELPPF);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface EHKBGADHGBA
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Guid CIAECGMGKIC();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface PIPOPGBHJAI<out TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TModern AHPHKHMMKHH(string AJACLEELPPF);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface HABBFPCILCO
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	DJAOJFIAGJB<MFBAIOHMEOF> AKMCGMBOFCC
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	DJAOJFIAGJB<PLPAABLOIJF> PHLBFMBBMJE
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	DJAOJFIAGJB<DAMJGPCPPIE> LOEGPIFGHOK
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	DJAOJFIAGJB<EGIKODNAABF> LHIKPNNPHHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	DJAOJFIAGJB<HHIJJAHMBEN> LILMNDBJBAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	DJAOJFIAGJB<EGPFHAHNEED> HNCBCCCIMAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	DJAOJFIAGJB<GIIEABJDIBB> FIGIMCMOGLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	DJAOJFIAGJB<MFGHHKBHMBD> OKGEGGNJDCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class OFEIKOIEIOF
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static readonly char[] KFBOHFBEHFL;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x836D240", Offset = "0x836BA40", VA = "0x18836D240")]
	public static string[] MOMICAMDJLA(string? AMEDOFBMGEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x836D2E0", Offset = "0x836BAE0", VA = "0x18836D2E0")]
	public static string? OGKFMHCCDLB(string? IOFOJGFFCHA)
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
