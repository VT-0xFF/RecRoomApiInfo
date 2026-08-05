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
		[Cpp2IlInjected.Address(RVA = "0x7DAB80", Offset = "0x7D9780", VA = "0x1807DAB80")]
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
		[Cpp2IlInjected.Address(RVA = "0x678AD00", Offset = "0x6789900", VA = "0x18678AD00")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7DB530", Offset = "0x7DA130", VA = "0x1807DB530")]
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
		[Cpp2IlInjected.Address(RVA = "0x7DB570", Offset = "0x7DA170", VA = "0x1807DB570")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface ECAKOJEBJHN
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string GAPNIKJAJOO(BNHOPJAHCPN KMJAEAGEOPB);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BNHOPJAHCPN DPCADENMEMJ(string KMJAEAGEOPB);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct BNHOPJAHCPN : IEquatable<BNHOPJAHCPN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly EGAIINJFLJA OAKBDLNDFIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly FHGFDPIGBOM JLKDOLGLNPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly Guid OFJHJHLGPFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly RRColor? FNOGNOHFLFL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool PGICGOMIPJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x67897D0", Offset = "0x67883D0", VA = "0x1867897D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool GBHLBGKGKAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6789C50", Offset = "0x6788850", VA = "0x186789C50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x678A090", Offset = "0x6788C90", VA = "0x18678A090")]
	public BNHOPJAHCPN(BNHOPJAHCPN HAHCGCDDBKO, [Optional] Guid NHHLNJKMCIK, [Optional] RRColor? IFKECNAKMLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x678A120", Offset = "0x6788D20", VA = "0x18678A120")]
	public BNHOPJAHCPN(EGAIINJFLJA FKFEMFNIMKI, FHGFDPIGBOM GHBNECJOBDA, [Optional] Guid NHHLNJKMCIK, [Optional] RRColor? IFKECNAKMLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6789890", Offset = "0x6788490", VA = "0x186789890", Slot = "4")]
	public bool Equals(BNHOPJAHCPN NAFFCAIMPLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6789990", Offset = "0x6788590", VA = "0x186789990", Slot = "0")]
	public override bool Equals(object OGGNGHKHHGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6789AF0", Offset = "0x67886F0", VA = "0x186789AF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6789A80", Offset = "0x6788680", VA = "0x186789A80")]
	public static bool FKDJFADGJBA(BNHOPJAHCPN GDDMOGHGPAF, BNHOPJAHCPN GHPICIIHMOJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6789BE0", Offset = "0x67887E0", VA = "0x186789BE0")]
	public static bool MGCOHCIMIFH(BNHOPJAHCPN GDDMOGHGPAF, BNHOPJAHCPN GHPICIIHMOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6789C90", Offset = "0x6788890", VA = "0x186789C90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct EGAIINJFLJA : IEquatable<EGAIINJFLJA>, IComparable<EGAIINJFLJA>, NJHELBBHEDC
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly EGAIINJFLJA ONLHDLNPPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Guid AGEGEBLOPIL;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1DF8020", Offset = "0x1DF6C20", VA = "0x181DF8020")]
	public EGAIINJFLJA(Guid AGEGEBLOPIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x87FA00", Offset = "0x87E600", VA = "0x18087FA00", Slot = "6")]
	public Guid CLFIPINJLNF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3B66160", Offset = "0x3B64D60", VA = "0x183B66160", Slot = "4")]
	public bool Equals(EGAIINJFLJA NAFFCAIMPLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3B66010", Offset = "0x3B64C10", VA = "0x183B66010", Slot = "5")]
	public int CompareTo(EGAIINJFLJA NAFFCAIMPLI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x678A1B0", Offset = "0x6788DB0", VA = "0x18678A1B0", Slot = "0")]
	public override bool Equals(object OGGNGHKHHGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3B662E0", Offset = "0x3B64EE0", VA = "0x183B662E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3B66160", Offset = "0x3B64D60", VA = "0x183B66160")]
	public static bool FKDJFADGJBA(EGAIINJFLJA GDDMOGHGPAF, EGAIINJFLJA GHPICIIHMOJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x678A250", Offset = "0x6788E50", VA = "0x18678A250")]
	public static bool MGCOHCIMIFH(EGAIINJFLJA GDDMOGHGPAF, EGAIINJFLJA GHPICIIHMOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x678A280", Offset = "0x6788E80", VA = "0x18678A280", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct OHPFBIJPHHC : IEquatable<OHPFBIJPHHC>, IComparable<OHPFBIJPHHC>, NJHELBBHEDC
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly OHPFBIJPHHC ONLHDLNPPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Guid AGEGEBLOPIL;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1DF8020", Offset = "0x1DF6C20", VA = "0x181DF8020")]
	public OHPFBIJPHHC(Guid AGEGEBLOPIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x87FA00", Offset = "0x87E600", VA = "0x18087FA00", Slot = "6")]
	public Guid CLFIPINJLNF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3B66160", Offset = "0x3B64D60", VA = "0x183B66160", Slot = "4")]
	public bool Equals(OHPFBIJPHHC NAFFCAIMPLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3B66010", Offset = "0x3B64C10", VA = "0x183B66010", Slot = "5")]
	public int CompareTo(OHPFBIJPHHC NAFFCAIMPLI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x678AE90", Offset = "0x6789A90", VA = "0x18678AE90", Slot = "0")]
	public override bool Equals(object OGGNGHKHHGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3B662E0", Offset = "0x3B64EE0", VA = "0x183B662E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3B66160", Offset = "0x3B64D60", VA = "0x183B66160")]
	public static bool FKDJFADGJBA(OHPFBIJPHHC GDDMOGHGPAF, OHPFBIJPHHC GHPICIIHMOJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x678A250", Offset = "0x6788E50", VA = "0x18678A250")]
	public static bool MGCOHCIMIFH(OHPFBIJPHHC GDDMOGHGPAF, OHPFBIJPHHC GHPICIIHMOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x678AF30", Offset = "0x6789B30", VA = "0x18678AF30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct GFLJBEKNMMH : IEquatable<GFLJBEKNMMH>, IComparable<GFLJBEKNMMH>, NJHELBBHEDC
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly GFLJBEKNMMH ONLHDLNPPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Guid AGEGEBLOPIL;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1DF8020", Offset = "0x1DF6C20", VA = "0x181DF8020")]
	public GFLJBEKNMMH(Guid AGEGEBLOPIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x87FA00", Offset = "0x87E600", VA = "0x18087FA00", Slot = "6")]
	public Guid CLFIPINJLNF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3B66160", Offset = "0x3B64D60", VA = "0x183B66160", Slot = "4")]
	public bool Equals(GFLJBEKNMMH NAFFCAIMPLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3B66010", Offset = "0x3B64C10", VA = "0x183B66010", Slot = "5")]
	public int CompareTo(GFLJBEKNMMH NAFFCAIMPLI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x678A6C0", Offset = "0x67892C0", VA = "0x18678A6C0", Slot = "0")]
	public override bool Equals(object OGGNGHKHHGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3B662E0", Offset = "0x3B64EE0", VA = "0x183B662E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3B66160", Offset = "0x3B64D60", VA = "0x183B66160")]
	public static bool FKDJFADGJBA(GFLJBEKNMMH GDDMOGHGPAF, GFLJBEKNMMH GHPICIIHMOJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x678A250", Offset = "0x6788E50", VA = "0x18678A250")]
	public static bool MGCOHCIMIFH(GFLJBEKNMMH GDDMOGHGPAF, GFLJBEKNMMH GHPICIIHMOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x678A760", Offset = "0x6789360", VA = "0x18678A760", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct FHGFDPIGBOM : IEquatable<FHGFDPIGBOM>, IComparable<FHGFDPIGBOM>, NJHELBBHEDC
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly FHGFDPIGBOM ONLHDLNPPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Guid AGEGEBLOPIL;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public OGPPMGCGAKH FDKAIHHCDHK
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x84DD40", Offset = "0x84C940", VA = "0x18084DD40")]
		[CompilerGenerated]
		get
		{
			return default(OGPPMGCGAKH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public OGPPMGCGAKH NNEOBDJMCIK
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x107D790", Offset = "0x107C390", VA = "0x18107D790")]
		[CompilerGenerated]
		get
		{
			return default(OGPPMGCGAKH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public OGPPMGCGAKH GJEPAEPMFMB
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xEE3B90", Offset = "0xEE2790", VA = "0x180EE3B90")]
		[CompilerGenerated]
		get
		{
			return default(OGPPMGCGAKH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x87FA00", Offset = "0x87E600", VA = "0x18087FA00", Slot = "6")]
	public Guid CLFIPINJLNF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x678A680", Offset = "0x6789280", VA = "0x18678A680")]
	public FHGFDPIGBOM(Guid AGEGEBLOPIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x678A630", Offset = "0x6789230", VA = "0x18678A630")]
	public FHGFDPIGBOM(OGPPMGCGAKH PCKDDMIHNOO, OGPPMGCGAKH BAEFJEHFBEH, OGPPMGCGAKH FGAOPIELKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x678A450", Offset = "0x6789050", VA = "0x18678A450")]
	private Guid LFNGHMCHAEG()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x678A330", Offset = "0x6788F30", VA = "0x18678A330", Slot = "4")]
	public bool Equals(FHGFDPIGBOM NAFFCAIMPLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x678A360", Offset = "0x6788F60", VA = "0x18678A360", Slot = "0")]
	public override bool Equals(object OGGNGHKHHGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3B662E0", Offset = "0x3B64EE0", VA = "0x183B662E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x678A410", Offset = "0x6789010", VA = "0x18678A410")]
	public static bool FKDJFADGJBA(FHGFDPIGBOM GDDMOGHGPAF, FHGFDPIGBOM GHPICIIHMOJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x678A580", Offset = "0x6789180", VA = "0x18678A580")]
	public static bool MGCOHCIMIFH(FHGFDPIGBOM GDDMOGHGPAF, FHGFDPIGBOM GHPICIIHMOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x678A2F0", Offset = "0x6788EF0", VA = "0x18678A2F0", Slot = "5")]
	public int CompareTo(FHGFDPIGBOM NAFFCAIMPLI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x678A5C0", Offset = "0x67891C0", VA = "0x18678A5C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct NIHGKONIHFA : IEquatable<NIHGKONIHFA>, IComparable<NIHGKONIHFA>, NJHELBBHEDC
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly NIHGKONIHFA ONLHDLNPPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Guid AGEGEBLOPIL;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1DF8020", Offset = "0x1DF6C20", VA = "0x181DF8020")]
	public NIHGKONIHFA(Guid AGEGEBLOPIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x87FA00", Offset = "0x87E600", VA = "0x18087FA00", Slot = "6")]
	public Guid CLFIPINJLNF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3B66160", Offset = "0x3B64D60", VA = "0x183B66160", Slot = "4")]
	public bool Equals(NIHGKONIHFA NAFFCAIMPLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3B66010", Offset = "0x3B64C10", VA = "0x183B66010", Slot = "5")]
	public int CompareTo(NIHGKONIHFA NAFFCAIMPLI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x678ABF0", Offset = "0x67897F0", VA = "0x18678ABF0", Slot = "0")]
	public override bool Equals(object OGGNGHKHHGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3B662E0", Offset = "0x3B64EE0", VA = "0x183B662E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3B66160", Offset = "0x3B64D60", VA = "0x183B66160")]
	public static bool FKDJFADGJBA(NIHGKONIHFA GDDMOGHGPAF, NIHGKONIHFA GHPICIIHMOJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x678A250", Offset = "0x6788E50", VA = "0x18678A250")]
	public static bool MGCOHCIMIFH(NIHGKONIHFA GDDMOGHGPAF, NIHGKONIHFA GHPICIIHMOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x678AC90", Offset = "0x6789890", VA = "0x18678AC90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct MLCCCBINKOI : IEquatable<MLCCCBINKOI>, IComparable<MLCCCBINKOI>, NJHELBBHEDC
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly MLCCCBINKOI ONLHDLNPPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Guid AGEGEBLOPIL;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1DF8020", Offset = "0x1DF6C20", VA = "0x181DF8020")]
	public MLCCCBINKOI(Guid AGEGEBLOPIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x87FA00", Offset = "0x87E600", VA = "0x18087FA00", Slot = "6")]
	public Guid CLFIPINJLNF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3B66160", Offset = "0x3B64D60", VA = "0x183B66160", Slot = "4")]
	public bool Equals(MLCCCBINKOI NAFFCAIMPLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3B66010", Offset = "0x3B64C10", VA = "0x183B66010", Slot = "5")]
	public int CompareTo(MLCCCBINKOI NAFFCAIMPLI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x678A9D0", Offset = "0x67895D0", VA = "0x18678A9D0", Slot = "0")]
	public override bool Equals(object OGGNGHKHHGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3B662E0", Offset = "0x3B64EE0", VA = "0x183B662E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3B66160", Offset = "0x3B64D60", VA = "0x183B66160")]
	public static bool FKDJFADGJBA(MLCCCBINKOI GDDMOGHGPAF, MLCCCBINKOI GHPICIIHMOJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x678A250", Offset = "0x6788E50", VA = "0x18678A250")]
	public static bool MGCOHCIMIFH(MLCCCBINKOI GDDMOGHGPAF, MLCCCBINKOI GHPICIIHMOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x678AA70", Offset = "0x6789670", VA = "0x18678AA70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct JDNGMCAHIDI : IEquatable<JDNGMCAHIDI>, IComparable<JDNGMCAHIDI>, NJHELBBHEDC
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static readonly JDNGMCAHIDI ONLHDLNPPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Guid AGEGEBLOPIL;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x1DF8020", Offset = "0x1DF6C20", VA = "0x181DF8020")]
	public JDNGMCAHIDI(Guid AGEGEBLOPIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x87FA00", Offset = "0x87E600", VA = "0x18087FA00", Slot = "6")]
	public Guid CLFIPINJLNF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3B66160", Offset = "0x3B64D60", VA = "0x183B66160", Slot = "4")]
	public bool Equals(JDNGMCAHIDI NAFFCAIMPLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3B66010", Offset = "0x3B64C10", VA = "0x183B66010", Slot = "5")]
	public int CompareTo(JDNGMCAHIDI NAFFCAIMPLI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x678A7D0", Offset = "0x67893D0", VA = "0x18678A7D0", Slot = "0")]
	public override bool Equals(object OGGNGHKHHGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3B662E0", Offset = "0x3B64EE0", VA = "0x183B662E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3B66160", Offset = "0x3B64D60", VA = "0x183B66160")]
	public static bool FKDJFADGJBA(JDNGMCAHIDI GDDMOGHGPAF, JDNGMCAHIDI GHPICIIHMOJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x678A250", Offset = "0x6788E50", VA = "0x18678A250")]
	public static bool MGCOHCIMIFH(JDNGMCAHIDI GDDMOGHGPAF, JDNGMCAHIDI GHPICIIHMOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x678A870", Offset = "0x6789470", VA = "0x18678A870", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct MNCKBBFKGJI : IEquatable<MNCKBBFKGJI>, IComparable<MNCKBBFKGJI>, NJHELBBHEDC
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static readonly MNCKBBFKGJI ONLHDLNPPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly Guid AGEGEBLOPIL;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1DF8020", Offset = "0x1DF6C20", VA = "0x181DF8020")]
	public MNCKBBFKGJI(Guid AGEGEBLOPIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x87FA00", Offset = "0x87E600", VA = "0x18087FA00", Slot = "6")]
	public Guid CLFIPINJLNF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3B66160", Offset = "0x3B64D60", VA = "0x183B66160", Slot = "4")]
	public bool Equals(MNCKBBFKGJI NAFFCAIMPLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3B66010", Offset = "0x3B64C10", VA = "0x183B66010", Slot = "5")]
	public int CompareTo(MNCKBBFKGJI NAFFCAIMPLI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x678AAE0", Offset = "0x67896E0", VA = "0x18678AAE0", Slot = "0")]
	public override bool Equals(object OGGNGHKHHGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3B662E0", Offset = "0x3B64EE0", VA = "0x183B662E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3B66160", Offset = "0x3B64D60", VA = "0x183B66160")]
	public static bool FKDJFADGJBA(MNCKBBFKGJI GDDMOGHGPAF, MNCKBBFKGJI GHPICIIHMOJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x678A250", Offset = "0x6788E50", VA = "0x18678A250")]
	public static bool MGCOHCIMIFH(MNCKBBFKGJI GDDMOGHGPAF, MNCKBBFKGJI GHPICIIHMOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x678AB80", Offset = "0x6789780", VA = "0x18678AB80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct PAFKBIKEDAI : IEquatable<PAFKBIKEDAI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly string?[]? OGMBDIIAFKH;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool PGNAFHIBNIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x678B350", Offset = "0x6789F50", VA = "0x18678B350")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int PDBPFLKHCOA
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x3C53DB0", Offset = "0x3C529B0", VA = "0x183C53DB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x678B6B0", Offset = "0x678A2B0", VA = "0x18678B6B0")]
	public PAFKBIKEDAI(string? CAEMLLPIBDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x678B630", Offset = "0x678A230", VA = "0x18678B630")]
	public PAFKBIKEDAI(string?[] IPOBMEMGFDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x678B370", Offset = "0x6789F70", VA = "0x18678B370")]
	private static string?[]? OCPHHIPAJGC(string?[]? IPOBMEMGFDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x678B2F0", Offset = "0x6789EF0", VA = "0x18678B2F0")]
	public string LBAPBJHDAKM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x678B0B0", Offset = "0x6789CB0", VA = "0x18678B0B0", Slot = "4")]
	public bool Equals(PAFKBIKEDAI NAFFCAIMPLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x678B180", Offset = "0x6789D80", VA = "0x18678B180", Slot = "0")]
	public override bool Equals(object OGGNGHKHHGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x678B210", Offset = "0x6789E10", VA = "0x18678B210", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x678B5A0", Offset = "0x678A1A0", VA = "0x18678B5A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct OGPPMGCGAKH : IEquatable<OGPPMGCGAKH>, IComparable<OGPPMGCGAKH>, NJHELBBHEDC
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly OGPPMGCGAKH ONLHDLNPPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Guid AGEGEBLOPIL;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1DF8020", Offset = "0x1DF6C20", VA = "0x181DF8020")]
	public OGPPMGCGAKH(Guid AGEGEBLOPIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x87FA00", Offset = "0x87E600", VA = "0x18087FA00", Slot = "6")]
	public Guid CLFIPINJLNF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3B66160", Offset = "0x3B64D60", VA = "0x183B66160", Slot = "4")]
	public bool Equals(OGPPMGCGAKH NAFFCAIMPLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3B66010", Offset = "0x3B64C10", VA = "0x183B66010", Slot = "5")]
	public int CompareTo(OGPPMGCGAKH NAFFCAIMPLI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x678AD80", Offset = "0x6789980", VA = "0x18678AD80", Slot = "0")]
	public override bool Equals(object OGGNGHKHHGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3B662E0", Offset = "0x3B64EE0", VA = "0x183B662E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3B66160", Offset = "0x3B64D60", VA = "0x183B66160")]
	public static bool FKDJFADGJBA(OGPPMGCGAKH GDDMOGHGPAF, OGPPMGCGAKH GHPICIIHMOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x678AE20", Offset = "0x6789A20", VA = "0x18678AE20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct OIECKEOAKPH : IEquatable<OIECKEOAKPH>, IComparable<OIECKEOAKPH>, NJHELBBHEDC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly Guid AGEGEBLOPIL;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1DF8020", Offset = "0x1DF6C20", VA = "0x181DF8020")]
	public OIECKEOAKPH(Guid AGEGEBLOPIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x87FA00", Offset = "0x87E600", VA = "0x18087FA00", Slot = "6")]
	public Guid CLFIPINJLNF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3B66160", Offset = "0x3B64D60", VA = "0x183B66160", Slot = "4")]
	public bool Equals(OIECKEOAKPH NAFFCAIMPLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3B66010", Offset = "0x3B64C10", VA = "0x183B66010", Slot = "5")]
	public int CompareTo(OIECKEOAKPH NAFFCAIMPLI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x678AFA0", Offset = "0x6789BA0", VA = "0x18678AFA0", Slot = "0")]
	public override bool Equals(object OGGNGHKHHGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3B662E0", Offset = "0x3B64EE0", VA = "0x183B662E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x678B040", Offset = "0x6789C40", VA = "0x18678B040", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface HHKBIFBBMNF<TModern> : JOKGCEJKNIH<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string JMBMJPOIHIL(TModern MBKLJGOBJAP);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface NJHELBBHEDC
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Guid CLFIPINJLNF();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface JOKGCEJKNIH<out TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TModern KKNJOPGMNCG(string MBKLJGOBJAP);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface OAJACJJJIDI
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	HHKBIFBBMNF<EGAIINJFLJA> GFGHHKDMHEF
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	HHKBIFBBMNF<NIHGKONIHFA> BGJDGAIMJFC
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	HHKBIFBBMNF<MNCKBBFKGJI> DGBPMAPPMPN
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	HHKBIFBBMNF<FHGFDPIGBOM> BAFHIAEIMJD
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	HHKBIFBBMNF<GFLJBEKNMMH> MPGIEHHHCGL
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	HHKBIFBBMNF<JDNGMCAHIDI> AADAFEGEAGM
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	HHKBIFBBMNF<OHPFBIJPHHC> DAJFALLHAGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	HHKBIFBBMNF<MLCCCBINKOI> MEBENGBJLPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class JLLFBMDLDGA
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x678A910", Offset = "0x6789510", VA = "0x18678A910")]
	public static string[] HCMMHLMCKMG(string? CAEMLLPIBDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x678A8E0", Offset = "0x67894E0", VA = "0x18678A8E0")]
	public static string? CLBBHBNEBCO(string? FKFEMFNIMKI)
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
