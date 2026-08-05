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
		[Cpp2IlInjected.Address(RVA = "0x7DEA50", Offset = "0x7DDC50", VA = "0x1807DEA50")]
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
		[Cpp2IlInjected.Address(RVA = "0x67B4740", Offset = "0x67B3940", VA = "0x1867B4740")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7DED90", Offset = "0x7DDF90", VA = "0x1807DED90")]
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
		[Cpp2IlInjected.Address(RVA = "0x7DEDD0", Offset = "0x7DDFD0", VA = "0x1807DEDD0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface JAADDLKDCOC
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string JCBMCDNAHJB(GHLPFCLOJMP BHCBEHDFPNA);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GHLPFCLOJMP MAOCPLNNJJM(string BHCBEHDFPNA);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct GHLPFCLOJMP : IEquatable<GHLPFCLOJMP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly LCMAKACPPLG JFAAMLBHADF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly FNCPBFIAFOK CCBAPFAPDFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly Guid EMOCBNOOBHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly RRColor? DBKGGJFCCMD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool LKMMGHOCCNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x67B33C0", Offset = "0x67B25C0", VA = "0x1867B33C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool DOMFGAHMBJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x67B32D0", Offset = "0x67B24D0", VA = "0x1867B32D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x67B3880", Offset = "0x67B2A80", VA = "0x1867B3880")]
	public GHLPFCLOJMP(GHLPFCLOJMP LLGOCLMNMPC, [Optional] Guid DLPMPAFJPIB, [Optional] RRColor? CMIODFEAKCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x67B3910", Offset = "0x67B2B10", VA = "0x1867B3910")]
	public GHLPFCLOJMP(LCMAKACPPLG IPFJBLEHLIE, FNCPBFIAFOK EKOPAIHNOKM, [Optional] Guid DLPMPAFJPIB, [Optional] RRColor? CMIODFEAKCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x67B3190", Offset = "0x67B2390", VA = "0x1867B3190", Slot = "4")]
	public bool Equals(GHLPFCLOJMP MEJMHKPOODP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x67B3060", Offset = "0x67B2260", VA = "0x1867B3060", Slot = "0")]
	public override bool Equals(object GLMGCMELGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x67B3240", Offset = "0x67B2440", VA = "0x1867B3240", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x67B3190", Offset = "0x67B2390", VA = "0x1867B3190")]
	public static bool FPIEKNKMEBM(GHLPFCLOJMP EAIBKNOIIGG, GHLPFCLOJMP PKGAILNKPEP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x67B3310", Offset = "0x67B2510", VA = "0x1867B3310")]
	public static bool LEBDJINPIPG(GHLPFCLOJMP EAIBKNOIIGG, GHLPFCLOJMP PKGAILNKPEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x67B3480", Offset = "0x67B2680", VA = "0x1867B3480", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct LCMAKACPPLG : IEquatable<LCMAKACPPLG>, IComparable<LCMAKACPPLG>, JGBEHCONICA
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly LCMAKACPPLG NONABGLHMDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Guid JJMGPACFMMB;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1E0B980", Offset = "0x1E0AB80", VA = "0x181E0B980")]
	public LCMAKACPPLG(Guid JJMGPACFMMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8869D0", Offset = "0x885BD0", VA = "0x1808869D0", Slot = "6")]
	public Guid DEMEEFPNFFI()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3428C80", Offset = "0x3427E80", VA = "0x183428C80", Slot = "4")]
	public bool Equals(LCMAKACPPLG MEJMHKPOODP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3428B60", Offset = "0x3427D60", VA = "0x183428B60", Slot = "5")]
	public int CompareTo(LCMAKACPPLG MEJMHKPOODP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x67B3BC0", Offset = "0x67B2DC0", VA = "0x1867B3BC0", Slot = "0")]
	public override bool Equals(object GLMGCMELGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3428C60", Offset = "0x3427E60", VA = "0x183428C60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3428C80", Offset = "0x3427E80", VA = "0x183428C80")]
	public static bool FPIEKNKMEBM(LCMAKACPPLG EAIBKNOIIGG, LCMAKACPPLG PKGAILNKPEP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x67B28E0", Offset = "0x67B1AE0", VA = "0x1867B28E0")]
	public static bool LEBDJINPIPG(LCMAKACPPLG EAIBKNOIIGG, LCMAKACPPLG PKGAILNKPEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x67B3C60", Offset = "0x67B2E60", VA = "0x1867B3C60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct MIEIJBMPPGI : IEquatable<MIEIJBMPPGI>, IComparable<MIEIJBMPPGI>, JGBEHCONICA
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly MIEIJBMPPGI NONABGLHMDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Guid JJMGPACFMMB;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1E0B980", Offset = "0x1E0AB80", VA = "0x181E0B980")]
	public MIEIJBMPPGI(Guid JJMGPACFMMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8869D0", Offset = "0x885BD0", VA = "0x1808869D0", Slot = "6")]
	public Guid DEMEEFPNFFI()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3428C80", Offset = "0x3427E80", VA = "0x183428C80", Slot = "4")]
	public bool Equals(MIEIJBMPPGI MEJMHKPOODP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3428B60", Offset = "0x3427D60", VA = "0x183428B60", Slot = "5")]
	public int CompareTo(MIEIJBMPPGI MEJMHKPOODP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x67B3DE0", Offset = "0x67B2FE0", VA = "0x1867B3DE0", Slot = "0")]
	public override bool Equals(object GLMGCMELGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3428C60", Offset = "0x3427E60", VA = "0x183428C60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3428C80", Offset = "0x3427E80", VA = "0x183428C80")]
	public static bool FPIEKNKMEBM(MIEIJBMPPGI EAIBKNOIIGG, MIEIJBMPPGI PKGAILNKPEP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x67B28E0", Offset = "0x67B1AE0", VA = "0x1867B28E0")]
	public static bool LEBDJINPIPG(MIEIJBMPPGI EAIBKNOIIGG, MIEIJBMPPGI PKGAILNKPEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x67B3E80", Offset = "0x67B3080", VA = "0x1867B3E80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct MHLCCJMBBJE : IEquatable<MHLCCJMBBJE>, IComparable<MHLCCJMBBJE>, JGBEHCONICA
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly MHLCCJMBBJE NONABGLHMDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Guid JJMGPACFMMB;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1E0B980", Offset = "0x1E0AB80", VA = "0x181E0B980")]
	public MHLCCJMBBJE(Guid JJMGPACFMMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8869D0", Offset = "0x885BD0", VA = "0x1808869D0", Slot = "6")]
	public Guid DEMEEFPNFFI()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3428C80", Offset = "0x3427E80", VA = "0x183428C80", Slot = "4")]
	public bool Equals(MHLCCJMBBJE MEJMHKPOODP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3428B60", Offset = "0x3427D60", VA = "0x183428B60", Slot = "5")]
	public int CompareTo(MHLCCJMBBJE MEJMHKPOODP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x67B3CD0", Offset = "0x67B2ED0", VA = "0x1867B3CD0", Slot = "0")]
	public override bool Equals(object GLMGCMELGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3428C60", Offset = "0x3427E60", VA = "0x183428C60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3428C80", Offset = "0x3427E80", VA = "0x183428C80")]
	public static bool FPIEKNKMEBM(MHLCCJMBBJE EAIBKNOIIGG, MHLCCJMBBJE PKGAILNKPEP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x67B28E0", Offset = "0x67B1AE0", VA = "0x1867B28E0")]
	public static bool LEBDJINPIPG(MHLCCJMBBJE EAIBKNOIIGG, MHLCCJMBBJE PKGAILNKPEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x67B3D70", Offset = "0x67B2F70", VA = "0x1867B3D70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct FNCPBFIAFOK : IEquatable<FNCPBFIAFOK>, IComparable<FNCPBFIAFOK>, JGBEHCONICA
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly FNCPBFIAFOK NONABGLHMDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Guid JJMGPACFMMB;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public FGKAKHJMBEH HLEEMDMAPPL
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x853EA0", Offset = "0x8530A0", VA = "0x180853EA0")]
		[CompilerGenerated]
		get
		{
			return default(FGKAKHJMBEH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public FGKAKHJMBEH LKANJAILJKI
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x1064390", Offset = "0x1063590", VA = "0x181064390")]
		[CompilerGenerated]
		get
		{
			return default(FGKAKHJMBEH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public FGKAKHJMBEH EDLDOMALIKB
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xEC9910", Offset = "0xEC8B10", VA = "0x180EC9910")]
		[CompilerGenerated]
		get
		{
			return default(FGKAKHJMBEH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8869D0", Offset = "0x885BD0", VA = "0x1808869D0", Slot = "6")]
	public Guid DEMEEFPNFFI()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x67B2FD0", Offset = "0x67B21D0", VA = "0x1867B2FD0")]
	public FNCPBFIAFOK(Guid JJMGPACFMMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x67B3010", Offset = "0x67B2210", VA = "0x1867B3010")]
	public FNCPBFIAFOK(FGKAKHJMBEH CCMFPIPGEEE, FGKAKHJMBEH FKILBAPPGHF, FGKAKHJMBEH KNIHNEPCIPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x67B2C90", Offset = "0x67B1E90", VA = "0x1867B2C90")]
	private Guid AGHFKOACAIL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x67B2EB0", Offset = "0x67B20B0", VA = "0x1867B2EB0", Slot = "4")]
	public bool Equals(FNCPBFIAFOK MEJMHKPOODP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x67B2E00", Offset = "0x67B2000", VA = "0x1867B2E00", Slot = "0")]
	public override bool Equals(object GLMGCMELGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3428C60", Offset = "0x3427E60", VA = "0x183428C60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x67B2EE0", Offset = "0x67B20E0", VA = "0x1867B2EE0")]
	public static bool FPIEKNKMEBM(FNCPBFIAFOK EAIBKNOIIGG, FNCPBFIAFOK PKGAILNKPEP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x67B2F20", Offset = "0x67B2120", VA = "0x1867B2F20")]
	public static bool LEBDJINPIPG(FNCPBFIAFOK EAIBKNOIIGG, FNCPBFIAFOK PKGAILNKPEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x67B2DC0", Offset = "0x67B1FC0", VA = "0x1867B2DC0", Slot = "5")]
	public int CompareTo(FNCPBFIAFOK MEJMHKPOODP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x67B2F60", Offset = "0x67B2160", VA = "0x1867B2F60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct AEOALLDMPKB : IEquatable<AEOALLDMPKB>, IComparable<AEOALLDMPKB>, JGBEHCONICA
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly AEOALLDMPKB NONABGLHMDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Guid JJMGPACFMMB;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1E0B980", Offset = "0x1E0AB80", VA = "0x181E0B980")]
	public AEOALLDMPKB(Guid JJMGPACFMMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8869D0", Offset = "0x885BD0", VA = "0x1808869D0", Slot = "6")]
	public Guid DEMEEFPNFFI()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3428C80", Offset = "0x3427E80", VA = "0x183428C80", Slot = "4")]
	public bool Equals(AEOALLDMPKB MEJMHKPOODP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3428B60", Offset = "0x3427D60", VA = "0x183428B60", Slot = "5")]
	public int CompareTo(AEOALLDMPKB MEJMHKPOODP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x67B2840", Offset = "0x67B1A40", VA = "0x1867B2840", Slot = "0")]
	public override bool Equals(object GLMGCMELGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3428C60", Offset = "0x3427E60", VA = "0x183428C60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3428C80", Offset = "0x3427E80", VA = "0x183428C80")]
	public static bool FPIEKNKMEBM(AEOALLDMPKB EAIBKNOIIGG, AEOALLDMPKB PKGAILNKPEP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x67B28E0", Offset = "0x67B1AE0", VA = "0x1867B28E0")]
	public static bool LEBDJINPIPG(AEOALLDMPKB EAIBKNOIIGG, AEOALLDMPKB PKGAILNKPEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x67B2910", Offset = "0x67B1B10", VA = "0x1867B2910", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct NFAAHILECNI : IEquatable<NFAAHILECNI>, IComparable<NFAAHILECNI>, JGBEHCONICA
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly NFAAHILECNI NONABGLHMDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Guid JJMGPACFMMB;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1E0B980", Offset = "0x1E0AB80", VA = "0x181E0B980")]
	public NFAAHILECNI(Guid JJMGPACFMMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8869D0", Offset = "0x885BD0", VA = "0x1808869D0", Slot = "6")]
	public Guid DEMEEFPNFFI()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3428C80", Offset = "0x3427E80", VA = "0x183428C80", Slot = "4")]
	public bool Equals(NFAAHILECNI MEJMHKPOODP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3428B60", Offset = "0x3427D60", VA = "0x183428B60", Slot = "5")]
	public int CompareTo(NFAAHILECNI MEJMHKPOODP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x67B3EF0", Offset = "0x67B30F0", VA = "0x1867B3EF0", Slot = "0")]
	public override bool Equals(object GLMGCMELGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3428C60", Offset = "0x3427E60", VA = "0x183428C60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3428C80", Offset = "0x3427E80", VA = "0x183428C80")]
	public static bool FPIEKNKMEBM(NFAAHILECNI EAIBKNOIIGG, NFAAHILECNI PKGAILNKPEP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x67B28E0", Offset = "0x67B1AE0", VA = "0x1867B28E0")]
	public static bool LEBDJINPIPG(NFAAHILECNI EAIBKNOIIGG, NFAAHILECNI PKGAILNKPEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x67B3F90", Offset = "0x67B3190", VA = "0x1867B3F90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct DGCLIPNNKEP : IEquatable<DGCLIPNNKEP>, IComparable<DGCLIPNNKEP>, JGBEHCONICA
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static readonly DGCLIPNNKEP NONABGLHMDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Guid JJMGPACFMMB;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x1E0B980", Offset = "0x1E0AB80", VA = "0x181E0B980")]
	public DGCLIPNNKEP(Guid JJMGPACFMMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8869D0", Offset = "0x885BD0", VA = "0x1808869D0", Slot = "6")]
	public Guid DEMEEFPNFFI()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3428C80", Offset = "0x3427E80", VA = "0x183428C80", Slot = "4")]
	public bool Equals(DGCLIPNNKEP MEJMHKPOODP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3428B60", Offset = "0x3427D60", VA = "0x183428B60", Slot = "5")]
	public int CompareTo(DGCLIPNNKEP MEJMHKPOODP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x67B2980", Offset = "0x67B1B80", VA = "0x1867B2980", Slot = "0")]
	public override bool Equals(object GLMGCMELGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3428C60", Offset = "0x3427E60", VA = "0x183428C60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3428C80", Offset = "0x3427E80", VA = "0x183428C80")]
	public static bool FPIEKNKMEBM(DGCLIPNNKEP EAIBKNOIIGG, DGCLIPNNKEP PKGAILNKPEP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x67B28E0", Offset = "0x67B1AE0", VA = "0x1867B28E0")]
	public static bool LEBDJINPIPG(DGCLIPNNKEP EAIBKNOIIGG, DGCLIPNNKEP PKGAILNKPEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x67B2A20", Offset = "0x67B1C20", VA = "0x1867B2A20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct KFBDCNHKDOH : IEquatable<KFBDCNHKDOH>, IComparable<KFBDCNHKDOH>, JGBEHCONICA
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static readonly KFBDCNHKDOH NONABGLHMDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly Guid JJMGPACFMMB;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1E0B980", Offset = "0x1E0AB80", VA = "0x181E0B980")]
	public KFBDCNHKDOH(Guid JJMGPACFMMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x8869D0", Offset = "0x885BD0", VA = "0x1808869D0", Slot = "6")]
	public Guid DEMEEFPNFFI()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3428C80", Offset = "0x3427E80", VA = "0x183428C80", Slot = "4")]
	public bool Equals(KFBDCNHKDOH MEJMHKPOODP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3428B60", Offset = "0x3427D60", VA = "0x183428B60", Slot = "5")]
	public int CompareTo(KFBDCNHKDOH MEJMHKPOODP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x67B3AB0", Offset = "0x67B2CB0", VA = "0x1867B3AB0", Slot = "0")]
	public override bool Equals(object GLMGCMELGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3428C60", Offset = "0x3427E60", VA = "0x183428C60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3428C80", Offset = "0x3427E80", VA = "0x183428C80")]
	public static bool FPIEKNKMEBM(KFBDCNHKDOH EAIBKNOIIGG, KFBDCNHKDOH PKGAILNKPEP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x67B28E0", Offset = "0x67B1AE0", VA = "0x1867B28E0")]
	public static bool LEBDJINPIPG(KFBDCNHKDOH EAIBKNOIIGG, KFBDCNHKDOH PKGAILNKPEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x67B3B50", Offset = "0x67B2D50", VA = "0x1867B3B50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct NMHOCJJDBGM : IEquatable<NMHOCJJDBGM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly string?[]? NPMMGFDLCFI;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool OBLLEJJIIHM
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x67B4000", Offset = "0x67B3200", VA = "0x1867B4000")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int AAAPACEPGGF
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x3C6FFE0", Offset = "0x3C6F1E0", VA = "0x183C6FFE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x67B4580", Offset = "0x67B3780", VA = "0x1867B4580")]
	public NMHOCJJDBGM(string? JFNOBKEMDLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x67B46C0", Offset = "0x67B38C0", VA = "0x1867B46C0")]
	public NMHOCJJDBGM(string?[] MIAOADIPMPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x67B4020", Offset = "0x67B3220", VA = "0x1867B4020")]
	private static string?[]? BODIEMJMONM(string?[]? MIAOADIPMPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x67B43B0", Offset = "0x67B35B0", VA = "0x1867B43B0")]
	public string GGJPHNJINHJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x67B42E0", Offset = "0x67B34E0", VA = "0x1867B42E0", Slot = "4")]
	public bool Equals(NMHOCJJDBGM MEJMHKPOODP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x67B4250", Offset = "0x67B3450", VA = "0x1867B4250", Slot = "0")]
	public override bool Equals(object GLMGCMELGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x67B4410", Offset = "0x67B3610", VA = "0x1867B4410", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x67B44F0", Offset = "0x67B36F0", VA = "0x1867B44F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct FGKAKHJMBEH : IEquatable<FGKAKHJMBEH>, IComparable<FGKAKHJMBEH>, JGBEHCONICA
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly FGKAKHJMBEH NONABGLHMDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Guid JJMGPACFMMB;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1E0B980", Offset = "0x1E0AB80", VA = "0x181E0B980")]
	public FGKAKHJMBEH(Guid JJMGPACFMMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8869D0", Offset = "0x885BD0", VA = "0x1808869D0", Slot = "6")]
	public Guid DEMEEFPNFFI()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3428C80", Offset = "0x3427E80", VA = "0x183428C80", Slot = "4")]
	public bool Equals(FGKAKHJMBEH MEJMHKPOODP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3428B60", Offset = "0x3427D60", VA = "0x183428B60", Slot = "5")]
	public int CompareTo(FGKAKHJMBEH MEJMHKPOODP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x67B2B80", Offset = "0x67B1D80", VA = "0x1867B2B80", Slot = "0")]
	public override bool Equals(object GLMGCMELGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3428C60", Offset = "0x3427E60", VA = "0x183428C60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3428C80", Offset = "0x3427E80", VA = "0x183428C80")]
	public static bool FPIEKNKMEBM(FGKAKHJMBEH EAIBKNOIIGG, FGKAKHJMBEH PKGAILNKPEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x67B2C20", Offset = "0x67B1E20", VA = "0x1867B2C20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct JMKOIEINPKI : IEquatable<JMKOIEINPKI>, IComparable<JMKOIEINPKI>, JGBEHCONICA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly Guid JJMGPACFMMB;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1E0B980", Offset = "0x1E0AB80", VA = "0x181E0B980")]
	public JMKOIEINPKI(Guid JJMGPACFMMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x8869D0", Offset = "0x885BD0", VA = "0x1808869D0", Slot = "6")]
	public Guid DEMEEFPNFFI()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3428C80", Offset = "0x3427E80", VA = "0x183428C80", Slot = "4")]
	public bool Equals(JMKOIEINPKI MEJMHKPOODP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3428B60", Offset = "0x3427D60", VA = "0x183428B60", Slot = "5")]
	public int CompareTo(JMKOIEINPKI MEJMHKPOODP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x67B39A0", Offset = "0x67B2BA0", VA = "0x1867B39A0", Slot = "0")]
	public override bool Equals(object GLMGCMELGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3428C60", Offset = "0x3427E60", VA = "0x183428C60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x67B3A40", Offset = "0x67B2C40", VA = "0x1867B3A40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface LDFOPLAHODB<TModern> : EAAOEPICDOC<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string KOMKFILPGCJ(TModern BFBGHLNGHBL);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface JGBEHCONICA
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Guid DEMEEFPNFFI();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface EAAOEPICDOC<out TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TModern DALLEIKECLH(string BFBGHLNGHBL);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface JLCOAONOJCD
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	LDFOPLAHODB<LCMAKACPPLG> AFHFONKHOHB
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	LDFOPLAHODB<AEOALLDMPKB> GOGDOKFCNON
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	LDFOPLAHODB<KFBDCNHKDOH> IKHMCLLKPKC
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	LDFOPLAHODB<FNCPBFIAFOK> LEOAHIPAADM
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	LDFOPLAHODB<MHLCCJMBBJE> LNPPMGNJJIC
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	LDFOPLAHODB<DGCLIPNNKEP> GKAGIKPPHNN
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	LDFOPLAHODB<MIEIJBMPPGI> OIAMNDPKBHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	LDFOPLAHODB<NFAAHILECNI> NFGEOOAHGFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class EHALAMMFPNI
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x67B2A90", Offset = "0x67B1C90", VA = "0x1867B2A90")]
	public static string[] HFKBFJDONLA(string? JFNOBKEMDLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x67B2B50", Offset = "0x67B1D50", VA = "0x1867B2B50")]
	public static string? NPBEJCJAMNN(string? IPFJBLEHLIE)
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
