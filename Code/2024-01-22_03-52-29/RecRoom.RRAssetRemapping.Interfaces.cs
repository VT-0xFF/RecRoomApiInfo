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
		[Cpp2IlInjected.Address(RVA = "0x7BAB50", Offset = "0x7B9F50", VA = "0x1807BAB50")]
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
		[Cpp2IlInjected.Address(RVA = "0x6678DA0", Offset = "0x66781A0", VA = "0x186678DA0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7BB450", Offset = "0x7BA850", VA = "0x1807BB450")]
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
		[Cpp2IlInjected.Address(RVA = "0x7BB490", Offset = "0x7BA890", VA = "0x1807BB490")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface DGGCEILBKKE
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string GOGJDIDOEDD(GBKHDJKABHC KJOOLMAMLNL);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GBKHDJKABHC BOEOGBDBLGM(string KJOOLMAMLNL);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct GBKHDJKABHC : IEquatable<GBKHDJKABHC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly PDFJEDAJCCF ECBLILDLBOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly MKBBGPPCDJC NOHIFDPEOGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly Guid AKLPHIOGPOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly RRColor? GACIHDMNOLB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool EMIPBJEFNFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x66775F0", Offset = "0x66769F0", VA = "0x1866775F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool KHBNEGOAGAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x66777A0", Offset = "0x6676BA0", VA = "0x1866777A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6677CE0", Offset = "0x66770E0", VA = "0x186677CE0")]
	public GBKHDJKABHC(GBKHDJKABHC DKMMHKMBBFH, [Optional] Guid JLCDJHJNDIL, [Optional] RRColor? JKOGDMNIBNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6677C50", Offset = "0x6677050", VA = "0x186677C50")]
	public GBKHDJKABHC(PDFJEDAJCCF GKOBCJMPEOC, MKBBGPPCDJC CJNMDEGBCGP, [Optional] Guid JLCDJHJNDIL, [Optional] RRColor? JKOGDMNIBNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x66774F0", Offset = "0x66768F0", VA = "0x1866774F0", Slot = "4")]
	public bool Equals(GBKHDJKABHC JLCJEDAFKJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6677400", Offset = "0x6676800", VA = "0x186677400", Slot = "0")]
	public override bool Equals(object DFFBALIDCLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x66776B0", Offset = "0x6676AB0", VA = "0x1866776B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6677390", Offset = "0x6676790", VA = "0x186677390")]
	public static bool AODPLFIFGHC(GBKHDJKABHC NAJACJFDALM, GBKHDJKABHC AKBGGCAJIBJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x66777E0", Offset = "0x6676BE0", VA = "0x1866777E0")]
	public static bool OFGNAAAHKLD(GBKHDJKABHC NAJACJFDALM, GBKHDJKABHC AKBGGCAJIBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6677850", Offset = "0x6676C50", VA = "0x186677850", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct PDFJEDAJCCF : IEquatable<PDFJEDAJCCF>, IComparable<PDFJEDAJCCF>, JKEPBCKJEID
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly PDFJEDAJCCF HNPOJGAPKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Guid EFNPBHMDENF;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1D1BD60", Offset = "0x1D1B160", VA = "0x181D1BD60")]
	public PDFJEDAJCCF(Guid EFNPBHMDENF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7FA350", Offset = "0x7F9750", VA = "0x1807FA350", Slot = "6")]
	public Guid OCOGBOFBKGP()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3FA20E0", Offset = "0x3FA14E0", VA = "0x183FA20E0", Slot = "4")]
	public bool Equals(PDFJEDAJCCF JLCJEDAFKJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3FA2110", Offset = "0x3FA1510", VA = "0x183FA2110", Slot = "5")]
	public int CompareTo(PDFJEDAJCCF JLCJEDAFKJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6678E20", Offset = "0x6678220", VA = "0x186678E20", Slot = "0")]
	public override bool Equals(object DFFBALIDCLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3FA22D0", Offset = "0x3FA16D0", VA = "0x183FA22D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3FA20E0", Offset = "0x3FA14E0", VA = "0x183FA20E0")]
	public static bool AODPLFIFGHC(PDFJEDAJCCF NAJACJFDALM, PDFJEDAJCCF AKBGGCAJIBJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x66770F0", Offset = "0x66764F0", VA = "0x1866770F0")]
	public static bool OFGNAAAHKLD(PDFJEDAJCCF NAJACJFDALM, PDFJEDAJCCF AKBGGCAJIBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6678EC0", Offset = "0x66782C0", VA = "0x186678EC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct EHFLMHMPKCM : IEquatable<EHFLMHMPKCM>, IComparable<EHFLMHMPKCM>, JKEPBCKJEID
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly EHFLMHMPKCM HNPOJGAPKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Guid EFNPBHMDENF;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1D1BD60", Offset = "0x1D1B160", VA = "0x181D1BD60")]
	public EHFLMHMPKCM(Guid EFNPBHMDENF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7FA350", Offset = "0x7F9750", VA = "0x1807FA350", Slot = "6")]
	public Guid OCOGBOFBKGP()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3FA20E0", Offset = "0x3FA14E0", VA = "0x183FA20E0", Slot = "4")]
	public bool Equals(EHFLMHMPKCM JLCJEDAFKJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3FA2110", Offset = "0x3FA1510", VA = "0x183FA2110", Slot = "5")]
	public int CompareTo(EHFLMHMPKCM JLCJEDAFKJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6677190", Offset = "0x6676590", VA = "0x186677190", Slot = "0")]
	public override bool Equals(object DFFBALIDCLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3FA22D0", Offset = "0x3FA16D0", VA = "0x183FA22D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3FA20E0", Offset = "0x3FA14E0", VA = "0x183FA20E0")]
	public static bool AODPLFIFGHC(EHFLMHMPKCM NAJACJFDALM, EHFLMHMPKCM AKBGGCAJIBJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x66770F0", Offset = "0x66764F0", VA = "0x1866770F0")]
	public static bool OFGNAAAHKLD(EHFLMHMPKCM NAJACJFDALM, EHFLMHMPKCM AKBGGCAJIBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6677230", Offset = "0x6676630", VA = "0x186677230", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct NMDCOALHPIM : IEquatable<NMDCOALHPIM>, IComparable<NMDCOALHPIM>, JKEPBCKJEID
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly NMDCOALHPIM HNPOJGAPKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Guid EFNPBHMDENF;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1D1BD60", Offset = "0x1D1B160", VA = "0x181D1BD60")]
	public NMDCOALHPIM(Guid EFNPBHMDENF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7FA350", Offset = "0x7F9750", VA = "0x1807FA350", Slot = "6")]
	public Guid OCOGBOFBKGP()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3FA20E0", Offset = "0x3FA14E0", VA = "0x183FA20E0", Slot = "4")]
	public bool Equals(NMDCOALHPIM JLCJEDAFKJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3FA2110", Offset = "0x3FA1510", VA = "0x183FA2110", Slot = "5")]
	public int CompareTo(NMDCOALHPIM JLCJEDAFKJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6678B80", Offset = "0x6677F80", VA = "0x186678B80", Slot = "0")]
	public override bool Equals(object DFFBALIDCLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3FA22D0", Offset = "0x3FA16D0", VA = "0x183FA22D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3FA20E0", Offset = "0x3FA14E0", VA = "0x183FA20E0")]
	public static bool AODPLFIFGHC(NMDCOALHPIM NAJACJFDALM, NMDCOALHPIM AKBGGCAJIBJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x66770F0", Offset = "0x66764F0", VA = "0x1866770F0")]
	public static bool OFGNAAAHKLD(NMDCOALHPIM NAJACJFDALM, NMDCOALHPIM AKBGGCAJIBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6678C20", Offset = "0x6678020", VA = "0x186678C20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct MKBBGPPCDJC : IEquatable<MKBBGPPCDJC>, IComparable<MKBBGPPCDJC>, JKEPBCKJEID
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly MKBBGPPCDJC HNPOJGAPKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Guid EFNPBHMDENF;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public HOBAHGNCJCC MBOAGJINJAI
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xB5FAF0", Offset = "0xB5EEF0", VA = "0x180B5FAF0")]
		[CompilerGenerated]
		get
		{
			return default(HOBAHGNCJCC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public HOBAHGNCJCC MMNPIJEIFIC
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xF028F0", Offset = "0xF01CF0", VA = "0x180F028F0")]
		[CompilerGenerated]
		get
		{
			return default(HOBAHGNCJCC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public HOBAHGNCJCC NDELNGFBDDB
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xE38C90", Offset = "0xE38090", VA = "0x180E38C90")]
		[CompilerGenerated]
		get
		{
			return default(HOBAHGNCJCC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7FA350", Offset = "0x7F9750", VA = "0x1807FA350", Slot = "6")]
	public Guid OCOGBOFBKGP()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6678B40", Offset = "0x6677F40", VA = "0x186678B40")]
	public MKBBGPPCDJC(Guid EFNPBHMDENF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6678AF0", Offset = "0x6677EF0", VA = "0x186678AF0")]
	public MKBBGPPCDJC(HOBAHGNCJCC NBFDFJKBIPB, HOBAHGNCJCC EPGNEMDNDJA, HOBAHGNCJCC LMFEIALHCJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6678820", Offset = "0x6677C20", VA = "0x186678820")]
	private Guid CKHMJBCNFDJ()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x60D9770", Offset = "0x60D8B70", VA = "0x1860D9770", Slot = "4")]
	public bool Equals(MKBBGPPCDJC JLCJEDAFKJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6678990", Offset = "0x6677D90", VA = "0x186678990", Slot = "0")]
	public override bool Equals(object DFFBALIDCLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3FA22D0", Offset = "0x3FA16D0", VA = "0x183FA22D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x66787E0", Offset = "0x6677BE0", VA = "0x1866787E0")]
	public static bool AODPLFIFGHC(MKBBGPPCDJC NAJACJFDALM, MKBBGPPCDJC AKBGGCAJIBJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6678A40", Offset = "0x6677E40", VA = "0x186678A40")]
	public static bool OFGNAAAHKLD(MKBBGPPCDJC NAJACJFDALM, MKBBGPPCDJC AKBGGCAJIBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6678950", Offset = "0x6677D50", VA = "0x186678950", Slot = "5")]
	public int CompareTo(MKBBGPPCDJC JLCJEDAFKJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6678A80", Offset = "0x6677E80", VA = "0x186678A80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct LLMLHBCOHNA : IEquatable<LLMLHBCOHNA>, IComparable<LLMLHBCOHNA>, JKEPBCKJEID
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly LLMLHBCOHNA HNPOJGAPKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Guid EFNPBHMDENF;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1D1BD60", Offset = "0x1D1B160", VA = "0x181D1BD60")]
	public LLMLHBCOHNA(Guid EFNPBHMDENF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7FA350", Offset = "0x7F9750", VA = "0x1807FA350", Slot = "6")]
	public Guid OCOGBOFBKGP()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3FA20E0", Offset = "0x3FA14E0", VA = "0x183FA20E0", Slot = "4")]
	public bool Equals(LLMLHBCOHNA JLCJEDAFKJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3FA2110", Offset = "0x3FA1510", VA = "0x183FA2110", Slot = "5")]
	public int CompareTo(LLMLHBCOHNA JLCJEDAFKJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x66786D0", Offset = "0x6677AD0", VA = "0x1866786D0", Slot = "0")]
	public override bool Equals(object DFFBALIDCLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3FA22D0", Offset = "0x3FA16D0", VA = "0x183FA22D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3FA20E0", Offset = "0x3FA14E0", VA = "0x183FA20E0")]
	public static bool AODPLFIFGHC(LLMLHBCOHNA NAJACJFDALM, LLMLHBCOHNA AKBGGCAJIBJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x66770F0", Offset = "0x66764F0", VA = "0x1866770F0")]
	public static bool OFGNAAAHKLD(LLMLHBCOHNA NAJACJFDALM, LLMLHBCOHNA AKBGGCAJIBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6678770", Offset = "0x6677B70", VA = "0x186678770", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct NNPNPEIPKPE : IEquatable<NNPNPEIPKPE>, IComparable<NNPNPEIPKPE>, JKEPBCKJEID
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly NNPNPEIPKPE HNPOJGAPKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Guid EFNPBHMDENF;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1D1BD60", Offset = "0x1D1B160", VA = "0x181D1BD60")]
	public NNPNPEIPKPE(Guid EFNPBHMDENF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7FA350", Offset = "0x7F9750", VA = "0x1807FA350", Slot = "6")]
	public Guid OCOGBOFBKGP()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3FA20E0", Offset = "0x3FA14E0", VA = "0x183FA20E0", Slot = "4")]
	public bool Equals(NNPNPEIPKPE JLCJEDAFKJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3FA2110", Offset = "0x3FA1510", VA = "0x183FA2110", Slot = "5")]
	public int CompareTo(NNPNPEIPKPE JLCJEDAFKJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6678C90", Offset = "0x6678090", VA = "0x186678C90", Slot = "0")]
	public override bool Equals(object DFFBALIDCLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3FA22D0", Offset = "0x3FA16D0", VA = "0x183FA22D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3FA20E0", Offset = "0x3FA14E0", VA = "0x183FA20E0")]
	public static bool AODPLFIFGHC(NNPNPEIPKPE NAJACJFDALM, NNPNPEIPKPE AKBGGCAJIBJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x66770F0", Offset = "0x66764F0", VA = "0x1866770F0")]
	public static bool OFGNAAAHKLD(NNPNPEIPKPE NAJACJFDALM, NNPNPEIPKPE AKBGGCAJIBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6678D30", Offset = "0x6678130", VA = "0x186678D30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct PKNABDINANF : IEquatable<PKNABDINANF>, IComparable<PKNABDINANF>, JKEPBCKJEID
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static readonly PKNABDINANF HNPOJGAPKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Guid EFNPBHMDENF;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x1D1BD60", Offset = "0x1D1B160", VA = "0x181D1BD60")]
	public PKNABDINANF(Guid EFNPBHMDENF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7FA350", Offset = "0x7F9750", VA = "0x1807FA350", Slot = "6")]
	public Guid OCOGBOFBKGP()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3FA20E0", Offset = "0x3FA14E0", VA = "0x183FA20E0", Slot = "4")]
	public bool Equals(PKNABDINANF JLCJEDAFKJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3FA2110", Offset = "0x3FA1510", VA = "0x183FA2110", Slot = "5")]
	public int CompareTo(PKNABDINANF JLCJEDAFKJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6678F30", Offset = "0x6678330", VA = "0x186678F30", Slot = "0")]
	public override bool Equals(object DFFBALIDCLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3FA22D0", Offset = "0x3FA16D0", VA = "0x183FA22D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3FA20E0", Offset = "0x3FA14E0", VA = "0x183FA20E0")]
	public static bool AODPLFIFGHC(PKNABDINANF NAJACJFDALM, PKNABDINANF AKBGGCAJIBJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x66770F0", Offset = "0x66764F0", VA = "0x1866770F0")]
	public static bool OFGNAAAHKLD(PKNABDINANF NAJACJFDALM, PKNABDINANF AKBGGCAJIBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6678FD0", Offset = "0x66783D0", VA = "0x186678FD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct ACKDJDPAEAJ : IEquatable<ACKDJDPAEAJ>, IComparable<ACKDJDPAEAJ>, JKEPBCKJEID
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static readonly ACKDJDPAEAJ HNPOJGAPKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly Guid EFNPBHMDENF;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1D1BD60", Offset = "0x1D1B160", VA = "0x181D1BD60")]
	public ACKDJDPAEAJ(Guid EFNPBHMDENF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7FA350", Offset = "0x7F9750", VA = "0x1807FA350", Slot = "6")]
	public Guid OCOGBOFBKGP()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3FA20E0", Offset = "0x3FA14E0", VA = "0x183FA20E0", Slot = "4")]
	public bool Equals(ACKDJDPAEAJ JLCJEDAFKJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3FA2110", Offset = "0x3FA1510", VA = "0x183FA2110", Slot = "5")]
	public int CompareTo(ACKDJDPAEAJ JLCJEDAFKJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6677050", Offset = "0x6676450", VA = "0x186677050", Slot = "0")]
	public override bool Equals(object DFFBALIDCLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3FA22D0", Offset = "0x3FA16D0", VA = "0x183FA22D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3FA20E0", Offset = "0x3FA14E0", VA = "0x183FA20E0")]
	public static bool AODPLFIFGHC(ACKDJDPAEAJ NAJACJFDALM, ACKDJDPAEAJ AKBGGCAJIBJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x66770F0", Offset = "0x66764F0", VA = "0x1866770F0")]
	public static bool OFGNAAAHKLD(ACKDJDPAEAJ NAJACJFDALM, ACKDJDPAEAJ AKBGGCAJIBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6677120", Offset = "0x6676520", VA = "0x186677120", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct GNJLGPKKIDD : IEquatable<GNJLGPKKIDD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly string?[]? GDLKDHPAPBB;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool DCKNEPLMKNC
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6678240", Offset = "0x6677640", VA = "0x186678240")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int NFFFJKCDDFE
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x3B8D000", Offset = "0x3B8C400", VA = "0x183B8D000")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x66782F0", Offset = "0x66776F0", VA = "0x1866782F0")]
	public GNJLGPKKIDD(string? EMBKAGDILEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6678430", Offset = "0x6677830", VA = "0x186678430")]
	public GNJLGPKKIDD(string?[] BHOBKKMHHPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6678010", Offset = "0x6677410", VA = "0x186678010")]
	private static string?[]? PCAEHFHBOFP(string?[]? BHOBKKMHHPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6677FB0", Offset = "0x66773B0", VA = "0x186677FB0")]
	public string LNNOLNBHMHB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6677D70", Offset = "0x6677170", VA = "0x186677D70", Slot = "4")]
	public bool Equals(GNJLGPKKIDD JLCJEDAFKJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6677E40", Offset = "0x6677240", VA = "0x186677E40", Slot = "0")]
	public override bool Equals(object DFFBALIDCLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6677ED0", Offset = "0x66772D0", VA = "0x186677ED0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6678260", Offset = "0x6677660", VA = "0x186678260", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct HOBAHGNCJCC : IEquatable<HOBAHGNCJCC>, IComparable<HOBAHGNCJCC>, JKEPBCKJEID
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly HOBAHGNCJCC HNPOJGAPKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Guid EFNPBHMDENF;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1D1BD60", Offset = "0x1D1B160", VA = "0x181D1BD60")]
	public HOBAHGNCJCC(Guid EFNPBHMDENF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7FA350", Offset = "0x7F9750", VA = "0x1807FA350", Slot = "6")]
	public Guid OCOGBOFBKGP()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3FA20E0", Offset = "0x3FA14E0", VA = "0x183FA20E0", Slot = "4")]
	public bool Equals(HOBAHGNCJCC JLCJEDAFKJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3FA2110", Offset = "0x3FA1510", VA = "0x183FA2110", Slot = "5")]
	public int CompareTo(HOBAHGNCJCC JLCJEDAFKJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x66784B0", Offset = "0x66778B0", VA = "0x1866784B0", Slot = "0")]
	public override bool Equals(object DFFBALIDCLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3FA22D0", Offset = "0x3FA16D0", VA = "0x183FA22D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3FA20E0", Offset = "0x3FA14E0", VA = "0x183FA20E0")]
	public static bool AODPLFIFGHC(HOBAHGNCJCC NAJACJFDALM, HOBAHGNCJCC AKBGGCAJIBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6678550", Offset = "0x6677950", VA = "0x186678550", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct KIFNIKCIILC : IEquatable<KIFNIKCIILC>, IComparable<KIFNIKCIILC>, JKEPBCKJEID
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly KIFNIKCIILC HNPOJGAPKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly Guid EFNPBHMDENF;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1D1BD60", Offset = "0x1D1B160", VA = "0x181D1BD60")]
	public KIFNIKCIILC(Guid EFNPBHMDENF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7FA350", Offset = "0x7F9750", VA = "0x1807FA350", Slot = "6")]
	public Guid OCOGBOFBKGP()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3FA20E0", Offset = "0x3FA14E0", VA = "0x183FA20E0", Slot = "4")]
	public bool Equals(KIFNIKCIILC JLCJEDAFKJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3FA2110", Offset = "0x3FA1510", VA = "0x183FA2110", Slot = "5")]
	public int CompareTo(KIFNIKCIILC JLCJEDAFKJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x66785C0", Offset = "0x66779C0", VA = "0x1866785C0", Slot = "0")]
	public override bool Equals(object DFFBALIDCLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3FA22D0", Offset = "0x3FA16D0", VA = "0x183FA22D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x66770F0", Offset = "0x66764F0", VA = "0x1866770F0")]
	public static bool OFGNAAAHKLD(KIFNIKCIILC NAJACJFDALM, KIFNIKCIILC AKBGGCAJIBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6678660", Offset = "0x6677A60", VA = "0x186678660", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface HMLEKAJPHMH<TModern> : JMGAOHNKLHE<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string ACMAMDDFBIN(TModern GKEPMBNOIPF);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface JKEPBCKJEID
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Guid OCOGBOFBKGP();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface JMGAOHNKLHE<out TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TModern JGAEHMLMPAC(string GKEPMBNOIPF);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface FPDINHFCLNE
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	HMLEKAJPHMH<PDFJEDAJCCF> KJNOIHDHGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	HMLEKAJPHMH<LLMLHBCOHNA> DICJNIHCLBD
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	HMLEKAJPHMH<ACKDJDPAEAJ> MJOIEGPHLBC
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	HMLEKAJPHMH<MKBBGPPCDJC> FHJHGINHGNI
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	HMLEKAJPHMH<NMDCOALHPIM> JIDPMLDKBPP
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	HMLEKAJPHMH<PKNABDINANF> HFIFGDCNPJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	HMLEKAJPHMH<EHFLMHMPKCM> HGLOMPENBKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	HMLEKAJPHMH<NNPNPEIPKPE> LDEGJJHIBBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class GABCIOBCKNL
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x66772A0", Offset = "0x66766A0", VA = "0x1866772A0")]
	public static string[] EJODILAIGCP(string? EMBKAGDILEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6677360", Offset = "0x6676760", VA = "0x186677360")]
	public static string? LKENOLILJMN(string? GKOBCJMPEOC)
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
