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
		[Cpp2IlInjected.Address(RVA = "0x890220", Offset = "0x88EE20", VA = "0x180890220")]
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
		[Cpp2IlInjected.Address(RVA = "0x70DFED0", Offset = "0x70DEAD0", VA = "0x1870DFED0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x890890", Offset = "0x88F490", VA = "0x180890890")]
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
		[Cpp2IlInjected.Address(RVA = "0x8908D0", Offset = "0x88F4D0", VA = "0x1808908D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface PAMLCLNPKJL
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string CJJBNJOFCID(CMEPKGFHLPL NGMMAKENIFG);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CMEPKGFHLPL GCPIDJEBGBI(string NGMMAKENIFG);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct CMEPKGFHLPL : IEquatable<CMEPKGFHLPL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly FFKCOFENOPK KNPJKJILPAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly PJILGJPEDNH GNNLINBGDAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly Guid CBPEEDLHJDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly RRColor? ANILDHGOEPL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool IKNPCJDMICH
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x70DE580", Offset = "0x70DD180", VA = "0x1870DE580")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool CJHDNNHIIEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x70DE8B0", Offset = "0x70DD4B0", VA = "0x1870DE8B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x70DEDA0", Offset = "0x70DD9A0", VA = "0x1870DEDA0")]
	public CMEPKGFHLPL(CMEPKGFHLPL HKGCFFNBJIM, [Optional] Guid KOEGFHCKJHC, [Optional] RRColor? NMMFNOOBBFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x70DED10", Offset = "0x70DD910", VA = "0x1870DED10")]
	public CMEPKGFHLPL(FFKCOFENOPK FOAAMOPOOLI, PJILGJPEDNH KMGHHLICIGP, [Optional] Guid KOEGFHCKJHC, [Optional] RRColor? NMMFNOOBBFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x70DE640", Offset = "0x70DD240", VA = "0x1870DE640", Slot = "4")]
	public bool Equals(CMEPKGFHLPL HEIGABGMPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x70DE6F0", Offset = "0x70DD2F0", VA = "0x1870DE6F0", Slot = "0")]
	public override bool Equals(object APKAFMDACKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x70DE820", Offset = "0x70DD420", VA = "0x1870DE820", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x70DE640", Offset = "0x70DD240", VA = "0x1870DE640")]
	public static bool IGDKJEPDLHP(CMEPKGFHLPL HDIFBMODGOB, CMEPKGFHLPL ADFEKOHGOPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x70DE8F0", Offset = "0x70DD4F0", VA = "0x1870DE8F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct FFKCOFENOPK : IEquatable<FFKCOFENOPK>, IComparable<FFKCOFENOPK>, LNGABDMOONC
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly FFKCOFENOPK ECELLENMKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Guid GBCIBJHFOHP;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1FD0E50", Offset = "0x1FCFA50", VA = "0x181FD0E50")]
	public FFKCOFENOPK(Guid GBCIBJHFOHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x9D9BF0", Offset = "0x9D87F0", VA = "0x1809D9BF0", Slot = "6")]
	public Guid HDAFPMNDCAF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3CE5E00", Offset = "0x3CE4A00", VA = "0x183CE5E00", Slot = "4")]
	public bool Equals(FFKCOFENOPK HEIGABGMPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3CE5CD0", Offset = "0x3CE48D0", VA = "0x183CE5CD0", Slot = "5")]
	public int CompareTo(FFKCOFENOPK HEIGABGMPLJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x70DF1E0", Offset = "0x70DDDE0", VA = "0x1870DF1E0", Slot = "0")]
	public override bool Equals(object APKAFMDACKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3CE5DE0", Offset = "0x3CE49E0", VA = "0x183CE5DE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3CE5E00", Offset = "0x3CE4A00", VA = "0x183CE5E00")]
	public static bool IGDKJEPDLHP(FFKCOFENOPK HDIFBMODGOB, FFKCOFENOPK ADFEKOHGOPP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x70DE4E0", Offset = "0x70DD0E0", VA = "0x1870DE4E0")]
	public static bool OAODAFKFIOO(FFKCOFENOPK HDIFBMODGOB, FFKCOFENOPK ADFEKOHGOPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x70DF290", Offset = "0x70DDE90", VA = "0x1870DF290", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct HGHOKGOAIFO : IEquatable<HGHOKGOAIFO>, IComparable<HGHOKGOAIFO>, LNGABDMOONC
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly HGHOKGOAIFO ECELLENMKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Guid GBCIBJHFOHP;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1FD0E50", Offset = "0x1FCFA50", VA = "0x181FD0E50")]
	public HGHOKGOAIFO(Guid GBCIBJHFOHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x9D9BF0", Offset = "0x9D87F0", VA = "0x1809D9BF0", Slot = "6")]
	public Guid HDAFPMNDCAF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3CE5E00", Offset = "0x3CE4A00", VA = "0x183CE5E00", Slot = "4")]
	public bool Equals(HGHOKGOAIFO HEIGABGMPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3CE5CD0", Offset = "0x3CE48D0", VA = "0x183CE5CD0", Slot = "5")]
	public int CompareTo(HGHOKGOAIFO HEIGABGMPLJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x70DF300", Offset = "0x70DDF00", VA = "0x1870DF300", Slot = "0")]
	public override bool Equals(object APKAFMDACKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3CE5DE0", Offset = "0x3CE49E0", VA = "0x183CE5DE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3CE5E00", Offset = "0x3CE4A00", VA = "0x183CE5E00")]
	public static bool IGDKJEPDLHP(HGHOKGOAIFO HDIFBMODGOB, HGHOKGOAIFO ADFEKOHGOPP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x70DE4E0", Offset = "0x70DD0E0", VA = "0x1870DE4E0")]
	public static bool OAODAFKFIOO(HGHOKGOAIFO HDIFBMODGOB, HGHOKGOAIFO ADFEKOHGOPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x70DF3B0", Offset = "0x70DDFB0", VA = "0x1870DF3B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct HHBFBBPCPOI : IEquatable<HHBFBBPCPOI>, IComparable<HHBFBBPCPOI>, LNGABDMOONC
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly HHBFBBPCPOI ECELLENMKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Guid GBCIBJHFOHP;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1FD0E50", Offset = "0x1FCFA50", VA = "0x181FD0E50")]
	public HHBFBBPCPOI(Guid GBCIBJHFOHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x9D9BF0", Offset = "0x9D87F0", VA = "0x1809D9BF0", Slot = "6")]
	public Guid HDAFPMNDCAF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3CE5E00", Offset = "0x3CE4A00", VA = "0x183CE5E00", Slot = "4")]
	public bool Equals(HHBFBBPCPOI HEIGABGMPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3CE5CD0", Offset = "0x3CE48D0", VA = "0x183CE5CD0", Slot = "5")]
	public int CompareTo(HHBFBBPCPOI HEIGABGMPLJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x70DF420", Offset = "0x70DE020", VA = "0x1870DF420", Slot = "0")]
	public override bool Equals(object APKAFMDACKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3CE5DE0", Offset = "0x3CE49E0", VA = "0x183CE5DE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3CE5E00", Offset = "0x3CE4A00", VA = "0x183CE5E00")]
	public static bool IGDKJEPDLHP(HHBFBBPCPOI HDIFBMODGOB, HHBFBBPCPOI ADFEKOHGOPP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x70DE4E0", Offset = "0x70DD0E0", VA = "0x1870DE4E0")]
	public static bool OAODAFKFIOO(HHBFBBPCPOI HDIFBMODGOB, HHBFBBPCPOI ADFEKOHGOPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x70DF4D0", Offset = "0x70DE0D0", VA = "0x1870DF4D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct PJILGJPEDNH : IEquatable<PJILGJPEDNH>, IComparable<PJILGJPEDNH>, LNGABDMOONC
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly PJILGJPEDNH ECELLENMKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Guid GBCIBJHFOHP;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public CMGIONJOHJG AAIOAKKJLHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8DA100", Offset = "0x8D8D00", VA = "0x1808DA100")]
		[CompilerGenerated]
		get
		{
			return default(CMGIONJOHJG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public CMGIONJOHJG JNCNCGHJCAG
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8DA110", Offset = "0x8D8D10", VA = "0x1808DA110")]
		[CompilerGenerated]
		get
		{
			return default(CMGIONJOHJG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public CMGIONJOHJG GNDMBCFMLKO
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8EBA40", Offset = "0x8EA640", VA = "0x1808EBA40")]
		[CompilerGenerated]
		get
		{
			return default(CMGIONJOHJG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x9D9BF0", Offset = "0x9D87F0", VA = "0x1809D9BF0", Slot = "6")]
	public Guid HDAFPMNDCAF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x70E02E0", Offset = "0x70DEEE0", VA = "0x1870E02E0")]
	public PJILGJPEDNH(Guid GBCIBJHFOHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x70E0290", Offset = "0x70DEE90", VA = "0x1870E0290")]
	public PJILGJPEDNH(CMGIONJOHJG INOOPJFPDNO, CMGIONJOHJG MNJNLKGAKFB, CMGIONJOHJG LAIFEIIGFOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x70E00B0", Offset = "0x70DECB0", VA = "0x1870E00B0")]
	private Guid LECNFKAKKPB()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x70E0040", Offset = "0x70DEC40", VA = "0x1870E0040", Slot = "4")]
	public bool Equals(PJILGJPEDNH HEIGABGMPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x70DFF90", Offset = "0x70DEB90", VA = "0x1870DFF90", Slot = "0")]
	public override bool Equals(object APKAFMDACKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3CE5DE0", Offset = "0x3CE49E0", VA = "0x183CE5DE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x70E0070", Offset = "0x70DEC70", VA = "0x1870E0070")]
	public static bool IGDKJEPDLHP(PJILGJPEDNH HDIFBMODGOB, PJILGJPEDNH ADFEKOHGOPP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x70E01E0", Offset = "0x70DEDE0", VA = "0x1870E01E0")]
	public static bool OAODAFKFIOO(PJILGJPEDNH HDIFBMODGOB, PJILGJPEDNH ADFEKOHGOPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x70DFF50", Offset = "0x70DEB50", VA = "0x1870DFF50", Slot = "5")]
	public int CompareTo(PJILGJPEDNH HEIGABGMPLJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x70E0220", Offset = "0x70DEE20", VA = "0x1870E0220", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct LOPIGABIBGJ : IEquatable<LOPIGABIBGJ>, IComparable<LOPIGABIBGJ>, LNGABDMOONC
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly LOPIGABIBGJ ECELLENMKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Guid GBCIBJHFOHP;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x1FD0E50", Offset = "0x1FCFA50", VA = "0x181FD0E50")]
	public LOPIGABIBGJ(Guid GBCIBJHFOHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x9D9BF0", Offset = "0x9D87F0", VA = "0x1809D9BF0", Slot = "6")]
	public Guid HDAFPMNDCAF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3CE5E00", Offset = "0x3CE4A00", VA = "0x183CE5E00", Slot = "4")]
	public bool Equals(LOPIGABIBGJ HEIGABGMPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3CE5CD0", Offset = "0x3CE48D0", VA = "0x183CE5CD0", Slot = "5")]
	public int CompareTo(LOPIGABIBGJ HEIGABGMPLJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x70DFC90", Offset = "0x70DE890", VA = "0x1870DFC90", Slot = "0")]
	public override bool Equals(object APKAFMDACKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3CE5DE0", Offset = "0x3CE49E0", VA = "0x183CE5DE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3CE5E00", Offset = "0x3CE4A00", VA = "0x183CE5E00")]
	public static bool IGDKJEPDLHP(LOPIGABIBGJ HDIFBMODGOB, LOPIGABIBGJ ADFEKOHGOPP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x70DE4E0", Offset = "0x70DD0E0", VA = "0x1870DE4E0")]
	public static bool OAODAFKFIOO(LOPIGABIBGJ HDIFBMODGOB, LOPIGABIBGJ ADFEKOHGOPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x70DFD40", Offset = "0x70DE940", VA = "0x1870DFD40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct APOLGJPCPMJ : IEquatable<APOLGJPCPMJ>, IComparable<APOLGJPCPMJ>, LNGABDMOONC
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly APOLGJPCPMJ ECELLENMKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Guid GBCIBJHFOHP;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1FD0E50", Offset = "0x1FCFA50", VA = "0x181FD0E50")]
	public APOLGJPCPMJ(Guid GBCIBJHFOHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x9D9BF0", Offset = "0x9D87F0", VA = "0x1809D9BF0", Slot = "6")]
	public Guid HDAFPMNDCAF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3CE5E00", Offset = "0x3CE4A00", VA = "0x183CE5E00", Slot = "4")]
	public bool Equals(APOLGJPCPMJ HEIGABGMPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3CE5CD0", Offset = "0x3CE48D0", VA = "0x183CE5CD0", Slot = "5")]
	public int CompareTo(APOLGJPCPMJ HEIGABGMPLJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x70DE430", Offset = "0x70DD030", VA = "0x1870DE430", Slot = "0")]
	public override bool Equals(object APKAFMDACKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3CE5DE0", Offset = "0x3CE49E0", VA = "0x183CE5DE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3CE5E00", Offset = "0x3CE4A00", VA = "0x183CE5E00")]
	public static bool IGDKJEPDLHP(APOLGJPCPMJ HDIFBMODGOB, APOLGJPCPMJ ADFEKOHGOPP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x70DE4E0", Offset = "0x70DD0E0", VA = "0x1870DE4E0")]
	public static bool OAODAFKFIOO(APOLGJPCPMJ HDIFBMODGOB, APOLGJPCPMJ ADFEKOHGOPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x70DE510", Offset = "0x70DD110", VA = "0x1870DE510", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct DEIDGKDGHJK : IEquatable<DEIDGKDGHJK>, IComparable<DEIDGKDGHJK>, LNGABDMOONC
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static readonly DEIDGKDGHJK ECELLENMKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Guid GBCIBJHFOHP;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x1FD0E50", Offset = "0x1FCFA50", VA = "0x181FD0E50")]
	public DEIDGKDGHJK(Guid GBCIBJHFOHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x9D9BF0", Offset = "0x9D87F0", VA = "0x1809D9BF0", Slot = "6")]
	public Guid HDAFPMNDCAF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3CE5E00", Offset = "0x3CE4A00", VA = "0x183CE5E00", Slot = "4")]
	public bool Equals(DEIDGKDGHJK HEIGABGMPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3CE5CD0", Offset = "0x3CE48D0", VA = "0x183CE5CD0", Slot = "5")]
	public int CompareTo(DEIDGKDGHJK HEIGABGMPLJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x70DEF50", Offset = "0x70DDB50", VA = "0x1870DEF50", Slot = "0")]
	public override bool Equals(object APKAFMDACKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3CE5DE0", Offset = "0x3CE49E0", VA = "0x183CE5DE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3CE5E00", Offset = "0x3CE4A00", VA = "0x183CE5E00")]
	public static bool IGDKJEPDLHP(DEIDGKDGHJK HDIFBMODGOB, DEIDGKDGHJK ADFEKOHGOPP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x70DE4E0", Offset = "0x70DD0E0", VA = "0x1870DE4E0")]
	public static bool OAODAFKFIOO(DEIDGKDGHJK HDIFBMODGOB, DEIDGKDGHJK ADFEKOHGOPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x70DF000", Offset = "0x70DDC00", VA = "0x1870DF000", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct NMOAOFAHBEC : IEquatable<NMOAOFAHBEC>, IComparable<NMOAOFAHBEC>, LNGABDMOONC
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static readonly NMOAOFAHBEC ECELLENMKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly Guid GBCIBJHFOHP;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1FD0E50", Offset = "0x1FCFA50", VA = "0x181FD0E50")]
	public NMOAOFAHBEC(Guid GBCIBJHFOHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x9D9BF0", Offset = "0x9D87F0", VA = "0x1809D9BF0", Slot = "6")]
	public Guid HDAFPMNDCAF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3CE5E00", Offset = "0x3CE4A00", VA = "0x183CE5E00", Slot = "4")]
	public bool Equals(NMOAOFAHBEC HEIGABGMPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3CE5CD0", Offset = "0x3CE48D0", VA = "0x183CE5CD0", Slot = "5")]
	public int CompareTo(NMOAOFAHBEC HEIGABGMPLJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x70DFDB0", Offset = "0x70DE9B0", VA = "0x1870DFDB0", Slot = "0")]
	public override bool Equals(object APKAFMDACKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3CE5DE0", Offset = "0x3CE49E0", VA = "0x183CE5DE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3CE5E00", Offset = "0x3CE4A00", VA = "0x183CE5E00")]
	public static bool IGDKJEPDLHP(NMOAOFAHBEC HDIFBMODGOB, NMOAOFAHBEC ADFEKOHGOPP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x70DE4E0", Offset = "0x70DD0E0", VA = "0x1870DE4E0")]
	public static bool OAODAFKFIOO(NMOAOFAHBEC HDIFBMODGOB, NMOAOFAHBEC ADFEKOHGOPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x70DFE60", Offset = "0x70DEA60", VA = "0x1870DFE60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct IHENJGOPBKG : IEquatable<IHENJGOPBKG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly string?[]? KPNMFPLLOKN;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool IEKHLJNNNBD
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x70DF700", Offset = "0x70DE300", VA = "0x1870DF700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int FDPEOBMEMOB
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x41132D0", Offset = "0x4111ED0", VA = "0x1841132D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x70DFB40", Offset = "0x70DE740", VA = "0x1870DFB40")]
	public IHENJGOPBKG(string? POIOHEBNIIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x70DFAC0", Offset = "0x70DE6C0", VA = "0x1870DFAC0")]
	public IHENJGOPBKG(string?[] GJLAEGOCMHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x70DF720", Offset = "0x70DE320", VA = "0x1870DF720")]
	private static string?[]? FGLIDLELDFN(string?[]? GJLAEGOCMHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x70DF540", Offset = "0x70DE140", VA = "0x1870DF540")]
	public string DPDFLHIIHPE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x70DF630", Offset = "0x70DE230", VA = "0x1870DF630", Slot = "4")]
	public bool Equals(IHENJGOPBKG HEIGABGMPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x70DF5A0", Offset = "0x70DE1A0", VA = "0x1870DF5A0", Slot = "0")]
	public override bool Equals(object APKAFMDACKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x70DF950", Offset = "0x70DE550", VA = "0x1870DF950", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x70DFA30", Offset = "0x70DE630", VA = "0x1870DFA30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct CMGIONJOHJG : IEquatable<CMGIONJOHJG>, IComparable<CMGIONJOHJG>, LNGABDMOONC
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly CMGIONJOHJG ECELLENMKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Guid GBCIBJHFOHP;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1FD0E50", Offset = "0x1FCFA50", VA = "0x181FD0E50")]
	public CMGIONJOHJG(Guid GBCIBJHFOHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x9D9BF0", Offset = "0x9D87F0", VA = "0x1809D9BF0", Slot = "6")]
	public Guid HDAFPMNDCAF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3CE5E00", Offset = "0x3CE4A00", VA = "0x183CE5E00", Slot = "4")]
	public bool Equals(CMGIONJOHJG HEIGABGMPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3CE5CD0", Offset = "0x3CE48D0", VA = "0x183CE5CD0", Slot = "5")]
	public int CompareTo(CMGIONJOHJG HEIGABGMPLJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x70DEE30", Offset = "0x70DDA30", VA = "0x1870DEE30", Slot = "0")]
	public override bool Equals(object APKAFMDACKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3CE5DE0", Offset = "0x3CE49E0", VA = "0x183CE5DE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3CE5E00", Offset = "0x3CE4A00", VA = "0x183CE5E00")]
	public static bool IGDKJEPDLHP(CMGIONJOHJG HDIFBMODGOB, CMGIONJOHJG ADFEKOHGOPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x70DEEE0", Offset = "0x70DDAE0", VA = "0x1870DEEE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface AHDNMBAPFHG<TModern> : NNJIJCPBKCK<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string LFJNAOAFDOK(TModern PEFHJPGEJPH);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface LNGABDMOONC
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Guid HDAFPMNDCAF();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface NNJIJCPBKCK<out TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TModern MKLFNBMPJJC(string PEFHJPGEJPH);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface NJHFEHHDIKB
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	AHDNMBAPFHG<FFKCOFENOPK> NAOGNHKFOMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	AHDNMBAPFHG<LOPIGABIBGJ> JGEAIECNCHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	AHDNMBAPFHG<NMOAOFAHBEC> ODLBJPIBNPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	AHDNMBAPFHG<PJILGJPEDNH> NMFIKMGICDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	AHDNMBAPFHG<HHBFBBPCPOI> DGPENOCPEDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	AHDNMBAPFHG<DEIDGKDGHJK> JKGHDMGGNJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	AHDNMBAPFHG<HGHOKGOAIFO> KHPALKCBBAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	AHDNMBAPFHG<APOLGJPCPMJ> JHBINEMBNDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class DIJHEPLNKAO
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static readonly char[] FKJCDPBKBFO;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x70DF0A0", Offset = "0x70DDCA0", VA = "0x1870DF0A0")]
	public static string[] BNGPACJEOKK(string? POIOHEBNIIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x70DF070", Offset = "0x70DDC70", VA = "0x1870DF070")]
	public static string? ADJFMOPPNMJ(string? FOAAMOPOOLI)
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
