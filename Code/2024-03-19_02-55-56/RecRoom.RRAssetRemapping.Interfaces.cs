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
		[Cpp2IlInjected.Address(RVA = "0x7E5660", Offset = "0x7E4660", VA = "0x1807E5660")]
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
		[Cpp2IlInjected.Address(RVA = "0x67EB8D0", Offset = "0x67EA8D0", VA = "0x1867EB8D0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7E62B0", Offset = "0x7E52B0", VA = "0x1807E62B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E62F0", Offset = "0x7E52F0", VA = "0x1807E62F0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface CMJBMEAAACL
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string PAKOMNGHIKD(PNOBAHGGIKH IIBDJBFNFJM);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PNOBAHGGIKH MPIEPNPHGIA(string IIBDJBFNFJM);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct PNOBAHGGIKH : IEquatable<PNOBAHGGIKH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly BMCDNIEHLLL PFABNMIHOFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly DFCKPJMGFPE EIMMIFKJNAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly Guid PIDCJDHKEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly RRColor? GFIEFHGIMKF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool GEMFICNKLMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x67EBA40", Offset = "0x67EAA40", VA = "0x1867EBA40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool LKEHFAHEJLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x67EBCF0", Offset = "0x67EACF0", VA = "0x1867EBCF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x67EC300", Offset = "0x67EB300", VA = "0x1867EC300")]
	public PNOBAHGGIKH(PNOBAHGGIKH CMHKKNEHBFB, [Optional] Guid PGFADHCGMLM, [Optional] RRColor? DDCPEHLFHPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x67EC390", Offset = "0x67EB390", VA = "0x1867EC390")]
	public PNOBAHGGIKH(BMCDNIEHLLL LIFNBHDCCLP, DFCKPJMGFPE PAJMKFNJLED, [Optional] Guid PGFADHCGMLM, [Optional] RRColor? DDCPEHLFHPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x67EBB00", Offset = "0x67EAB00", VA = "0x1867EBB00", Slot = "4")]
	public bool Equals(PNOBAHGGIKH PJNBIAFGNNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x67EBC00", Offset = "0x67EAC00", VA = "0x1867EBC00", Slot = "0")]
	public override bool Equals(object FGOCJODIEMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x67EBD30", Offset = "0x67EAD30", VA = "0x1867EBD30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x67EBE90", Offset = "0x67EAE90", VA = "0x1867EBE90")]
	public static bool INAKJEGDKIC(PNOBAHGGIKH FKOPFOECIGH, PNOBAHGGIKH DGKDEKELGHC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x67EBE20", Offset = "0x67EAE20", VA = "0x1867EBE20")]
	public static bool HNKADOHNPFO(PNOBAHGGIKH FKOPFOECIGH, PNOBAHGGIKH DGKDEKELGHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x67EBF00", Offset = "0x67EAF00", VA = "0x1867EBF00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct BMCDNIEHLLL : IEquatable<BMCDNIEHLLL>, IComparable<BMCDNIEHLLL>, JCPNAKGPHKI
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly BMCDNIEHLLL ECAIHANDNCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Guid IECJFMHCKJI;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1DD7F00", Offset = "0x1DD6F00", VA = "0x181DD7F00")]
	public BMCDNIEHLLL(Guid IECJFMHCKJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x889F00", Offset = "0x888F00", VA = "0x180889F00", Slot = "6")]
	public Guid KHCJKBBDNPJ()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3314700", Offset = "0x3313700", VA = "0x183314700", Slot = "4")]
	public bool Equals(BMCDNIEHLLL PJNBIAFGNNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x33146D0", Offset = "0x33136D0", VA = "0x1833146D0", Slot = "5")]
	public int CompareTo(BMCDNIEHLLL PJNBIAFGNNN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x67EAC50", Offset = "0x67E9C50", VA = "0x1867EAC50", Slot = "0")]
	public override bool Equals(object FGOCJODIEMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x33148D0", Offset = "0x33138D0", VA = "0x1833148D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3314700", Offset = "0x3313700", VA = "0x183314700")]
	public static bool INAKJEGDKIC(BMCDNIEHLLL FKOPFOECIGH, BMCDNIEHLLL DGKDEKELGHC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x67EACF0", Offset = "0x67E9CF0", VA = "0x1867EACF0")]
	public static bool HNKADOHNPFO(BMCDNIEHLLL FKOPFOECIGH, BMCDNIEHLLL DGKDEKELGHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x67EAD20", Offset = "0x67E9D20", VA = "0x1867EAD20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct POMGCDGENIC : IEquatable<POMGCDGENIC>, IComparable<POMGCDGENIC>, JCPNAKGPHKI
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly POMGCDGENIC ECAIHANDNCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Guid IECJFMHCKJI;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1DD7F00", Offset = "0x1DD6F00", VA = "0x181DD7F00")]
	public POMGCDGENIC(Guid IECJFMHCKJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x889F00", Offset = "0x888F00", VA = "0x180889F00", Slot = "6")]
	public Guid KHCJKBBDNPJ()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3314700", Offset = "0x3313700", VA = "0x183314700", Slot = "4")]
	public bool Equals(POMGCDGENIC PJNBIAFGNNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x33146D0", Offset = "0x33136D0", VA = "0x1833146D0", Slot = "5")]
	public int CompareTo(POMGCDGENIC PJNBIAFGNNN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x67EC420", Offset = "0x67EB420", VA = "0x1867EC420", Slot = "0")]
	public override bool Equals(object FGOCJODIEMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x33148D0", Offset = "0x33138D0", VA = "0x1833148D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3314700", Offset = "0x3313700", VA = "0x183314700")]
	public static bool INAKJEGDKIC(POMGCDGENIC FKOPFOECIGH, POMGCDGENIC DGKDEKELGHC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x67EACF0", Offset = "0x67E9CF0", VA = "0x1867EACF0")]
	public static bool HNKADOHNPFO(POMGCDGENIC FKOPFOECIGH, POMGCDGENIC DGKDEKELGHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x67EC4C0", Offset = "0x67EB4C0", VA = "0x1867EC4C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct KOAKCMMIHOG : IEquatable<KOAKCMMIHOG>, IComparable<KOAKCMMIHOG>, JCPNAKGPHKI
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly KOAKCMMIHOG ECAIHANDNCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Guid IECJFMHCKJI;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1DD7F00", Offset = "0x1DD6F00", VA = "0x181DD7F00")]
	public KOAKCMMIHOG(Guid IECJFMHCKJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x889F00", Offset = "0x888F00", VA = "0x180889F00", Slot = "6")]
	public Guid KHCJKBBDNPJ()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3314700", Offset = "0x3313700", VA = "0x183314700", Slot = "4")]
	public bool Equals(KOAKCMMIHOG PJNBIAFGNNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x33146D0", Offset = "0x33136D0", VA = "0x1833146D0", Slot = "5")]
	public int CompareTo(KOAKCMMIHOG PJNBIAFGNNN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x67EB5A0", Offset = "0x67EA5A0", VA = "0x1867EB5A0", Slot = "0")]
	public override bool Equals(object FGOCJODIEMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x33148D0", Offset = "0x33138D0", VA = "0x1833148D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3314700", Offset = "0x3313700", VA = "0x183314700")]
	public static bool INAKJEGDKIC(KOAKCMMIHOG FKOPFOECIGH, KOAKCMMIHOG DGKDEKELGHC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x67EACF0", Offset = "0x67E9CF0", VA = "0x1867EACF0")]
	public static bool HNKADOHNPFO(KOAKCMMIHOG FKOPFOECIGH, KOAKCMMIHOG DGKDEKELGHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x67EB640", Offset = "0x67EA640", VA = "0x1867EB640", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct DFCKPJMGFPE : IEquatable<DFCKPJMGFPE>, IComparable<DFCKPJMGFPE>, JCPNAKGPHKI
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly DFCKPJMGFPE ECAIHANDNCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Guid IECJFMHCKJI;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public EONDHDFGBIA HNFNNMMMPCH
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x844EC0", Offset = "0x843EC0", VA = "0x180844EC0")]
		[CompilerGenerated]
		get
		{
			return default(EONDHDFGBIA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public EONDHDFGBIA HMJHGANDGMG
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x1074BF0", Offset = "0x1073BF0", VA = "0x181074BF0")]
		[CompilerGenerated]
		get
		{
			return default(EONDHDFGBIA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public EONDHDFGBIA PCKFOJDJHBH
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xEDBD40", Offset = "0xEDAD40", VA = "0x180EDBD40")]
		[CompilerGenerated]
		get
		{
			return default(EONDHDFGBIA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x889F00", Offset = "0x888F00", VA = "0x180889F00", Slot = "6")]
	public Guid KHCJKBBDNPJ()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x67EB0D0", Offset = "0x67EA0D0", VA = "0x1867EB0D0")]
	public DFCKPJMGFPE(Guid IECJFMHCKJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x67EB110", Offset = "0x67EA110", VA = "0x1867EB110")]
	public DFCKPJMGFPE(EONDHDFGBIA BPJKBBLDEEO, EONDHDFGBIA DHGDEDEHFKM, EONDHDFGBIA PEPDJLBDCFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x67EAD90", Offset = "0x67E9D90", VA = "0x1867EAD90")]
	private Guid CLEHLEHJMFM()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x67EAFB0", Offset = "0x67E9FB0", VA = "0x1867EAFB0", Slot = "4")]
	public bool Equals(DFCKPJMGFPE PJNBIAFGNNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x67EAF00", Offset = "0x67E9F00", VA = "0x1867EAF00", Slot = "0")]
	public override bool Equals(object FGOCJODIEMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x33148D0", Offset = "0x33138D0", VA = "0x1833148D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x67EB020", Offset = "0x67EA020", VA = "0x1867EB020")]
	public static bool INAKJEGDKIC(DFCKPJMGFPE FKOPFOECIGH, DFCKPJMGFPE DGKDEKELGHC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x67EAFE0", Offset = "0x67E9FE0", VA = "0x1867EAFE0")]
	public static bool HNKADOHNPFO(DFCKPJMGFPE FKOPFOECIGH, DFCKPJMGFPE DGKDEKELGHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x67EAEC0", Offset = "0x67E9EC0", VA = "0x1867EAEC0", Slot = "5")]
	public int CompareTo(DFCKPJMGFPE PJNBIAFGNNN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x67EB060", Offset = "0x67EA060", VA = "0x1867EB060", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct DOGDMMADMNK : IEquatable<DOGDMMADMNK>, IComparable<DOGDMMADMNK>, JCPNAKGPHKI
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly DOGDMMADMNK ECAIHANDNCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Guid IECJFMHCKJI;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1DD7F00", Offset = "0x1DD6F00", VA = "0x181DD7F00")]
	public DOGDMMADMNK(Guid IECJFMHCKJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x889F00", Offset = "0x888F00", VA = "0x180889F00", Slot = "6")]
	public Guid KHCJKBBDNPJ()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3314700", Offset = "0x3313700", VA = "0x183314700", Slot = "4")]
	public bool Equals(DOGDMMADMNK PJNBIAFGNNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x33146D0", Offset = "0x33136D0", VA = "0x1833146D0", Slot = "5")]
	public int CompareTo(DOGDMMADMNK PJNBIAFGNNN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x67EB160", Offset = "0x67EA160", VA = "0x1867EB160", Slot = "0")]
	public override bool Equals(object FGOCJODIEMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x33148D0", Offset = "0x33138D0", VA = "0x1833148D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3314700", Offset = "0x3313700", VA = "0x183314700")]
	public static bool INAKJEGDKIC(DOGDMMADMNK FKOPFOECIGH, DOGDMMADMNK DGKDEKELGHC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x67EACF0", Offset = "0x67E9CF0", VA = "0x1867EACF0")]
	public static bool HNKADOHNPFO(DOGDMMADMNK FKOPFOECIGH, DOGDMMADMNK DGKDEKELGHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x67EB200", Offset = "0x67EA200", VA = "0x1867EB200", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct NOGNCKDKHOJ : IEquatable<NOGNCKDKHOJ>, IComparable<NOGNCKDKHOJ>, JCPNAKGPHKI
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly NOGNCKDKHOJ ECAIHANDNCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Guid IECJFMHCKJI;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1DD7F00", Offset = "0x1DD6F00", VA = "0x181DD7F00")]
	public NOGNCKDKHOJ(Guid IECJFMHCKJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x889F00", Offset = "0x888F00", VA = "0x180889F00", Slot = "6")]
	public Guid KHCJKBBDNPJ()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3314700", Offset = "0x3313700", VA = "0x183314700", Slot = "4")]
	public bool Equals(NOGNCKDKHOJ PJNBIAFGNNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x33146D0", Offset = "0x33136D0", VA = "0x1833146D0", Slot = "5")]
	public int CompareTo(NOGNCKDKHOJ PJNBIAFGNNN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x67EB7C0", Offset = "0x67EA7C0", VA = "0x1867EB7C0", Slot = "0")]
	public override bool Equals(object FGOCJODIEMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x33148D0", Offset = "0x33138D0", VA = "0x1833148D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3314700", Offset = "0x3313700", VA = "0x183314700")]
	public static bool INAKJEGDKIC(NOGNCKDKHOJ FKOPFOECIGH, NOGNCKDKHOJ DGKDEKELGHC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x67EACF0", Offset = "0x67E9CF0", VA = "0x1867EACF0")]
	public static bool HNKADOHNPFO(NOGNCKDKHOJ FKOPFOECIGH, NOGNCKDKHOJ DGKDEKELGHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x67EB860", Offset = "0x67EA860", VA = "0x1867EB860", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct NCOHCPHIJPB : IEquatable<NCOHCPHIJPB>, IComparable<NCOHCPHIJPB>, JCPNAKGPHKI
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static readonly NCOHCPHIJPB ECAIHANDNCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Guid IECJFMHCKJI;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x1DD7F00", Offset = "0x1DD6F00", VA = "0x181DD7F00")]
	public NCOHCPHIJPB(Guid IECJFMHCKJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x889F00", Offset = "0x888F00", VA = "0x180889F00", Slot = "6")]
	public Guid KHCJKBBDNPJ()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3314700", Offset = "0x3313700", VA = "0x183314700", Slot = "4")]
	public bool Equals(NCOHCPHIJPB PJNBIAFGNNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x33146D0", Offset = "0x33136D0", VA = "0x1833146D0", Slot = "5")]
	public int CompareTo(NCOHCPHIJPB PJNBIAFGNNN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x67EB6B0", Offset = "0x67EA6B0", VA = "0x1867EB6B0", Slot = "0")]
	public override bool Equals(object FGOCJODIEMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x33148D0", Offset = "0x33138D0", VA = "0x1833148D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3314700", Offset = "0x3313700", VA = "0x183314700")]
	public static bool INAKJEGDKIC(NCOHCPHIJPB FKOPFOECIGH, NCOHCPHIJPB DGKDEKELGHC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x67EACF0", Offset = "0x67E9CF0", VA = "0x1867EACF0")]
	public static bool HNKADOHNPFO(NCOHCPHIJPB FKOPFOECIGH, NCOHCPHIJPB DGKDEKELGHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x67EB750", Offset = "0x67EA750", VA = "0x1867EB750", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct EJBBCGEHEDF : IEquatable<EJBBCGEHEDF>, IComparable<EJBBCGEHEDF>, JCPNAKGPHKI
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static readonly EJBBCGEHEDF ECAIHANDNCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly Guid IECJFMHCKJI;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1DD7F00", Offset = "0x1DD6F00", VA = "0x181DD7F00")]
	public EJBBCGEHEDF(Guid IECJFMHCKJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x889F00", Offset = "0x888F00", VA = "0x180889F00", Slot = "6")]
	public Guid KHCJKBBDNPJ()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3314700", Offset = "0x3313700", VA = "0x183314700", Slot = "4")]
	public bool Equals(EJBBCGEHEDF PJNBIAFGNNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x33146D0", Offset = "0x33136D0", VA = "0x1833146D0", Slot = "5")]
	public int CompareTo(EJBBCGEHEDF PJNBIAFGNNN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x67EB270", Offset = "0x67EA270", VA = "0x1867EB270", Slot = "0")]
	public override bool Equals(object FGOCJODIEMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x33148D0", Offset = "0x33138D0", VA = "0x1833148D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3314700", Offset = "0x3313700", VA = "0x183314700")]
	public static bool INAKJEGDKIC(EJBBCGEHEDF FKOPFOECIGH, EJBBCGEHEDF DGKDEKELGHC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x67EACF0", Offset = "0x67E9CF0", VA = "0x1867EACF0")]
	public static bool HNKADOHNPFO(EJBBCGEHEDF FKOPFOECIGH, EJBBCGEHEDF DGKDEKELGHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x67EB310", Offset = "0x67EA310", VA = "0x1867EB310", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct AGBHMEHPHAE : IEquatable<AGBHMEHPHAE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly string?[]? LEANKODIOJN;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool EKAOBJEABNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x67EA750", Offset = "0x67E9750", VA = "0x1867EA750")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int KHGJPLFLECJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x3C8BB00", Offset = "0x3C8AB00", VA = "0x183C8BB00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x67EAB10", Offset = "0x67E9B10", VA = "0x1867EAB10")]
	public AGBHMEHPHAE(string? CCJKHIHCCMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x67EAA90", Offset = "0x67E9A90", VA = "0x1867EAA90")]
	public AGBHMEHPHAE(string?[] FDFANGGDLPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x67EA770", Offset = "0x67E9770", VA = "0x1867EA770")]
	private static string?[]? JGIJOJKEPEO(string?[]? FDFANGGDLPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x67EA9A0", Offset = "0x67E99A0", VA = "0x1867EA9A0")]
	public string KMDIJEDKJIN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x67EA5A0", Offset = "0x67E95A0", VA = "0x1867EA5A0", Slot = "4")]
	public bool Equals(AGBHMEHPHAE PJNBIAFGNNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x67EA510", Offset = "0x67E9510", VA = "0x1867EA510", Slot = "0")]
	public override bool Equals(object FGOCJODIEMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x67EA670", Offset = "0x67E9670", VA = "0x1867EA670", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x67EAA00", Offset = "0x67E9A00", VA = "0x1867EAA00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct EONDHDFGBIA : IEquatable<EONDHDFGBIA>, IComparable<EONDHDFGBIA>, JCPNAKGPHKI
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly EONDHDFGBIA ECAIHANDNCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Guid IECJFMHCKJI;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1DD7F00", Offset = "0x1DD6F00", VA = "0x181DD7F00")]
	public EONDHDFGBIA(Guid IECJFMHCKJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x889F00", Offset = "0x888F00", VA = "0x180889F00", Slot = "6")]
	public Guid KHCJKBBDNPJ()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3314700", Offset = "0x3313700", VA = "0x183314700", Slot = "4")]
	public bool Equals(EONDHDFGBIA PJNBIAFGNNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x33146D0", Offset = "0x33136D0", VA = "0x1833146D0", Slot = "5")]
	public int CompareTo(EONDHDFGBIA PJNBIAFGNNN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x67EB380", Offset = "0x67EA380", VA = "0x1867EB380", Slot = "0")]
	public override bool Equals(object FGOCJODIEMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x33148D0", Offset = "0x33138D0", VA = "0x1833148D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3314700", Offset = "0x3313700", VA = "0x183314700")]
	public static bool INAKJEGDKIC(EONDHDFGBIA FKOPFOECIGH, EONDHDFGBIA DGKDEKELGHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x67EB420", Offset = "0x67EA420", VA = "0x1867EB420", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct GOGFFPMHIAH : IEquatable<GOGFFPMHIAH>, IComparable<GOGFFPMHIAH>, JCPNAKGPHKI
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly GOGFFPMHIAH ECAIHANDNCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly Guid IECJFMHCKJI;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1DD7F00", Offset = "0x1DD6F00", VA = "0x181DD7F00")]
	public GOGFFPMHIAH(Guid IECJFMHCKJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x889F00", Offset = "0x888F00", VA = "0x180889F00", Slot = "6")]
	public Guid KHCJKBBDNPJ()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3314700", Offset = "0x3313700", VA = "0x183314700", Slot = "4")]
	public bool Equals(GOGFFPMHIAH PJNBIAFGNNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x33146D0", Offset = "0x33136D0", VA = "0x1833146D0", Slot = "5")]
	public int CompareTo(GOGFFPMHIAH PJNBIAFGNNN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x67EB490", Offset = "0x67EA490", VA = "0x1867EB490", Slot = "0")]
	public override bool Equals(object FGOCJODIEMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x33148D0", Offset = "0x33138D0", VA = "0x1833148D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x67EACF0", Offset = "0x67E9CF0", VA = "0x1867EACF0")]
	public static bool HNKADOHNPFO(GOGFFPMHIAH FKOPFOECIGH, GOGFFPMHIAH DGKDEKELGHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x67EB530", Offset = "0x67EA530", VA = "0x1867EB530", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface FBAJEBNGMGA<TModern> : NBDCKCEFHBO<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string NIPHGMGMLHO(TModern OIGONPCEMOJ);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface JCPNAKGPHKI
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Guid KHCJKBBDNPJ();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface NBDCKCEFHBO<out TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TModern HKAGMGPHPFE(string OIGONPCEMOJ);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface FMFOKPBOBIM
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	FBAJEBNGMGA<BMCDNIEHLLL> CAIBBPFLHJF
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	FBAJEBNGMGA<DOGDMMADMNK> NPNHMCGNGIM
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	FBAJEBNGMGA<EJBBCGEHEDF> AEHPAFJOHBD
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	FBAJEBNGMGA<DFCKPJMGFPE> NKOKOBNELOI
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	FBAJEBNGMGA<KOAKCMMIHOG> ALOBMJBEIOH
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	FBAJEBNGMGA<NCOHCPHIJPB> CAKGGOLJMDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	FBAJEBNGMGA<POMGCDGENIC> NKLEHCKBFCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	FBAJEBNGMGA<NOGNCKDKHOJ> LDJKHKKPEHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class OOPFKOMHPAN
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x67EB980", Offset = "0x67EA980", VA = "0x1867EB980")]
	public static string[] PDIIHGBPDBD(string? CCJKHIHCCMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x67EB950", Offset = "0x67EA950", VA = "0x1867EB950")]
	public static string? OBKGGCNBDJO(string? LIFNBHDCCLP)
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
