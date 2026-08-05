using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
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
		[Cpp2IlInjected.Address(RVA = "0x86EBE0", Offset = "0x86DBE0", VA = "0x18086EBE0")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x72F3640", Offset = "0x72F2640", VA = "0x1872F3640")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA3FB40", Offset = "0xA3EB40", VA = "0x180A3FB40")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xCF9C40", Offset = "0xCF8C40", VA = "0x180CF9C40")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Circuits.Shared.Api
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public enum IOKind
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Input,
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		Output
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public readonly struct ODEEFJBEJIP<M, T> where M : notnull where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly T[] MCAELBCBPAG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x766540", Offset = "0x765940")]
	public KNIEPEGFJMC<M> ILIAJIKNDAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x326D540", Offset = "0x326C540", VA = "0x18326D540")]
		get
		{
			return default(KNIEPEGFJMC<M>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int NKLAFIEKONA
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x326D5D0", Offset = "0x326C5D0", VA = "0x18326D5D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public T CLDBOBAGHND
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2477710", Offset = "0x2476710", VA = "0x182477710")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0xA2BF10", Offset = "0xA2AF10", VA = "0x180A2BF10")]
	internal ODEEFJBEJIP(T[] GJAKHOONFBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x326D430", Offset = "0x326C430", VA = "0x18326D430")]
	public static ODEEFJBEJIP<M, T> DAABCIFNKOF(int PKGBKHCIKEH)
	{
		return default(ODEEFJBEJIP<M, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x85E000", Offset = "0x85D000", VA = "0x18085E000")]
	public IEnumerable<T> MPNIPFEAALI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x326D3C0", Offset = "0x326C3C0", VA = "0x18326D3C0")]
	public NIIMLJEIDCA<M, T> CEHFLLDFNOE()
	{
		return default(NIIMLJEIDCA<M, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x326D4C0", Offset = "0x326C4C0", VA = "0x18326D4C0")]
	public IEnumerator<T> EFCEFGGNIIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x326D5F0", Offset = "0x326C5F0", VA = "0x18326D5F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class KPFOHPNOBDO<M>
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1076A60", Offset = "0x1075A60", VA = "0x181076A60")]
	public static ODEEFJBEJIP<M, T> EJOJEPHIGMJ<T>(params T[] GJAKHOONFBO) where T : notnull
	{
		return default(ODEEFJBEJIP<M, T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class JHHNMOMCKCM
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2477690", Offset = "0x2476690", VA = "0x182477690")]
	public static T? GAIMOCMLJNG<T, M>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7665E0", Offset = "0x7659E0")] this ref ODEEFJBEJIP<M?, T?> FKGCCPKFEDE, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x766640", Offset = "0x765A40")] KNIEPEGFJMC<M?> KJPGMJFNNHE)
	{
		return (T?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2477640", Offset = "0x2476640", VA = "0x182477640")]
	public static void DGLJBNFHKAF<M, T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7666A0", Offset = "0x765AA0")] this ref ODEEFJBEJIP<M?, T?> FKGCCPKFEDE, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x766700", Offset = "0x765B00")] KNIEPEGFJMC<M?> KJPGMJFNNHE, in T CKDFGEALFAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface FCODMCIGONC
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool DJFMIFCAJFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct AICFOEHJNOF : IEquatable<AICFOEHJNOF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly float EPJLHCNBMAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly float BDPMFEBJKME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly float OMDKDBHMGEO;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public static readonly AICFOEHJNOF FLILKHBEGHK;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly AICFOEHJNOF JIBDBLNJAML;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly AICFOEHJNOF BAMMJJDFDBO;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly AICFOEHJNOF GGABJDJCOBO;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly AICFOEHJNOF ANIKCGMDPGJ;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly AICFOEHJNOF IKEBBNCJAMD;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly AICFOEHJNOF MLBPPMNOOKG;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public static readonly AICFOEHJNOF AKDHDGLBLLB;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly AICFOEHJNOF NCMHJLIFDNJ;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public static readonly AICFOEHJNOF NNFMDIFOFLK;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly AICFOEHJNOF PGPCJBKIBAJ;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public static readonly AICFOEHJNOF FPLEHCOLLBJ;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static readonly AICFOEHJNOF HCKOJFECEOP;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static readonly AICFOEHJNOF FNJAJIDCOME;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static readonly AICFOEHJNOF NNFGNCJLIIO;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static readonly AICFOEHJNOF OBOPNAGONPN;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly AICFOEHJNOF MEPMPEGLIJP;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5D07DE0", Offset = "0x5D06DE0", VA = "0x185D07DE0")]
	public AICFOEHJNOF(float FKPADFHIFHA, float NAFGCLHKJEH, float GAOHFHENACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x72F2280", Offset = "0x72F1280", VA = "0x1872F2280")]
	public static AICFOEHJNOF DAABCIFNKOF(float FKPADFHIFHA, float NAFGCLHKJEH, float GAOHFHENACG)
	{
		return default(AICFOEHJNOF);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x72F2510", Offset = "0x72F1510", VA = "0x1872F2510")]
	public static bool LFCPNLBCIDE(in AICFOEHJNOF JMKFPOOBMEL, in AICFOEHJNOF OIMIHNAHPGP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x72F2480", Offset = "0x72F1480", VA = "0x1872F2480")]
	public static bool JIPCNIGMDBL(in AICFOEHJNOF JMKFPOOBMEL, in AICFOEHJNOF OIMIHNAHPGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x72F2410", Offset = "0x72F1410", VA = "0x1872F2410", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x72F22A0", Offset = "0x72F12A0", VA = "0x1872F22A0", Slot = "0")]
	public override bool Equals(object EOHGDDIECBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x72F2540", Offset = "0x72F1540", VA = "0x1872F2540", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x72F2380", Offset = "0x72F1380", VA = "0x1872F2380", Slot = "4")]
	public bool Equals(AICFOEHJNOF BKLMLPFOMCO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[Obsolete]
[DefaultMember("Item")]
public ref struct FHFPLJHPDPK<M, T> where M : notnull where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x766820", Offset = "0x765C20")]
	private readonly ReadOnlySpan<T> EEPFECAPONL;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public readonly T CLDBOBAGHND
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2FB10C0", Offset = "0x2FB00C0", VA = "0x182FB10C0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2501D00", Offset = "0x2500D00", VA = "0x182501D00")]
	internal FHFPLJHPDPK([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7668E0", Offset = "0x765CE0")] in ReadOnlySpan<T> NHDNBPIKIHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2FB1110", Offset = "0x2FB0110", VA = "0x182FB1110", Slot = "3")]
	public override readonly string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class ANLDEPAGPDG<M>
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x1FC70E0", Offset = "0x1FC60E0", VA = "0x181FC70E0")]
	public static FHFPLJHPDPK<M?, T?> CDONABIMEGJ<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x766990", Offset = "0x765D90")] in ReadOnlySpan<T?> NHDNBPIKIHH)
	{
		return default(FHFPLJHPDPK<M, T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct EFNJGHMADBN : IEquatable<EFNJGHMADBN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly FDGGAFLCIEB AOEKNCDMNHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly AICFOEHJNOF JILJAGCFLPO;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly EFNJGHMADBN AGDEGJHKFIB;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x72F2CB0", Offset = "0x72F1CB0", VA = "0x1872F2CB0")]
	public EFNJGHMADBN(in FDGGAFLCIEB NMKLOHCPMNL, in AICFOEHJNOF NKMKMKDMOMJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x72F2A50", Offset = "0x72F1A50", VA = "0x1872F2A50")]
	public static bool LFCPNLBCIDE(in EFNJGHMADBN JMKFPOOBMEL, in EFNJGHMADBN OIMIHNAHPGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x72F29C0", Offset = "0x72F19C0", VA = "0x1872F29C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x72F2880", Offset = "0x72F1880", VA = "0x1872F2880", Slot = "0")]
	public override bool Equals(object EOHGDDIECBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x72F2B40", Offset = "0x72F1B40", VA = "0x1872F2B40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x72F2950", Offset = "0x72F1950", VA = "0x1872F2950", Slot = "4")]
	public bool Equals(EFNJGHMADBN BKLMLPFOMCO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct PCNOHOEINMM<M, T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x766A40", Offset = "0x765E40")]
	private readonly ReadOnlyMemory<T?> GGFPFFFGACA;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0xBFDC30", Offset = "0xBFCC30", VA = "0x180BFDC30")]
	internal PCNOHOEINMM([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x766AA0", Offset = "0x765EA0")] in ReadOnlyMemory<T?> NNMDPPCNEEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2A8DBA0", Offset = "0x2A8CBA0", VA = "0x182A8DBA0")]
	public FHFPLJHPDPK<M?, T?> GKAACFHJKCI()
	{
		return default(FHFPLJHPDPK<M, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2A8DD60", Offset = "0x2A8CD60", VA = "0x182A8DD60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class PEPODMKADAA<M>
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1FC7070", Offset = "0x1FC6070", VA = "0x181FC7070")]
	public static PCNOHOEINMM<M?, T?> DLMHCAENKAO<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x766B10", Offset = "0x765F10")] in ReadOnlyMemory<T?> NNMDPPCNEEM)
	{
		return default(PCNOHOEINMM<M, T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct KNIEPEGFJMC<TMarker> : IEquatable<KNIEPEGFJMC<TMarker>>, EIDOCAAFNMH<KNIEPEGFJMC<TMarker>>, IComparable<KNIEPEGFJMC<TMarker>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly int POPDFJBFJOL;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x766EA0", Offset = "0x7662A0")]
	public KNIEPEGFJMC<TMarker> MIOMIFPCBNB
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x30E2480", Offset = "0x30E1480", VA = "0x1830E2480")]
		get
		{
			return default(KNIEPEGFJMC<TMarker>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x766F00", Offset = "0x766300")]
	public KNIEPEGFJMC<TMarker> CLHGIAHNMGI
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x30E2510", Offset = "0x30E1510", VA = "0x1830E2510")]
		get
		{
			return default(KNIEPEGFJMC<TMarker>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x86DD20", Offset = "0x86CD20", VA = "0x18086DD20")]
	public KNIEPEGFJMC(int CKDFGEALFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x22A6F80", Offset = "0x22A5F80", VA = "0x1822A6F80")]
	public KNIEPEGFJMC<TOther> OCBJJCPFKPP<TOther>() where TOther : TMarker
	{
		return default(KNIEPEGFJMC<TOther>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x30E23F0", Offset = "0x30E13F0", VA = "0x1830E23F0")]
	public bool CEKJJDKOFID([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x766B80", Offset = "0x765F80")] in KNIEPEGFJMC<TMarker> BKLMLPFOMCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x30E2430", Offset = "0x30E1430", VA = "0x1830E2430", Slot = "4")]
	public bool Equals([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x766BF0", Offset = "0x765FF0")] KNIEPEGFJMC<TMarker> BKLMLPFOMCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2A79260", Offset = "0x2A78260", VA = "0x182A79260", Slot = "0")]
	public override bool Equals(object BKLMLPFOMCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x30E2410", Offset = "0x30E1410", VA = "0x1830E2410", Slot = "6")]
	public int CompareTo([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x766C50", Offset = "0x766050")] KNIEPEGFJMC<TMarker> BKLMLPFOMCO)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x30E25D0", Offset = "0x30E15D0", VA = "0x1830E25D0")]
	public static bool LFCPNLBCIDE([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x766CB0", Offset = "0x7660B0")] KNIEPEGFJMC<TMarker> EEDCFNGAAFO, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x766D10", Offset = "0x766110")] KNIEPEGFJMC<TMarker> OFBPOJFNNIJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x30E2580", Offset = "0x30E1580", VA = "0x1830E2580")]
	public static bool JIPCNIGMDBL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x766D70", Offset = "0x766170")] KNIEPEGFJMC<TMarker> EEDCFNGAAFO, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x766DD0", Offset = "0x7661D0")] KNIEPEGFJMC<TMarker> OFBPOJFNNIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x30E24F0", Offset = "0x30E14F0", VA = "0x1830E24F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x30E2660", Offset = "0x30E1660", VA = "0x1830E2660", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x30E2610", Offset = "0x30E1610", VA = "0x1830E2610", Slot = "5")]
	private bool MOHDEDMDANA([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x766E30", Offset = "0x766230")] in KNIEPEGFJMC<TMarker> BKLMLPFOMCO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class BFBIMEGLMDL
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x24EB220", Offset = "0x24EA220", VA = "0x1824EB220")]
	public static KNIEPEGFJMC<TMarker?> JKNLIAAAHMG<TMarker>(this int FKGCCPKFEDE)
	{
		return default(KNIEPEGFJMC<TMarker>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x24EB220", Offset = "0x24EA220", VA = "0x1824EB220")]
	public static KNIEPEGFJMC<TMarker?> FMGJHGEEAAG<TMarker>(this int FKGCCPKFEDE)
	{
		return default(KNIEPEGFJMC<TMarker>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x24EB2C0", Offset = "0x24EA2C0", VA = "0x1824EB2C0")]
	public static LIKCBFIDFEB<KNIEPEGFJMC<TMarker?>, BADADAGJPBB<TMarker?>> KDMNGCJDBLB<TMarker>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x766FA0", Offset = "0x7663A0")] KNIEPEGFJMC<TMarker?> PLJEJHDKEOE, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x767000", Offset = "0x766400")] KNIEPEGFJMC<TMarker?> JGNCOJEDJAP)
	{
		return default(LIKCBFIDFEB<KNIEPEGFJMC<TMarker>, BADADAGJPBB<TMarker>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x24EB250", Offset = "0x24EA250", VA = "0x1824EB250")]
	public static LIKCBFIDFEB<KNIEPEGFJMC<TMarker?>, BADADAGJPBB<TMarker?>> JEPDNGFHAED<TMarker>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x767060", Offset = "0x766460")] KNIEPEGFJMC<TMarker?> JGNCOJEDJAP)
	{
		return default(LIKCBFIDFEB<KNIEPEGFJMC<TMarker>, BADADAGJPBB<TMarker>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class IFOGEGHCNAK<TOther>
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x22A53E0", Offset = "0x22A43E0", VA = "0x1822A53E0")]
	public static KNIEPEGFJMC<TOther> FOELLOGNLBN<TMarker>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7670C0", Offset = "0x7664C0")] KNIEPEGFJMC<TMarker> FKGCCPKFEDE) where TMarker : TOther
	{
		return default(KNIEPEGFJMC<TOther>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface PCBHEGKADAG
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	FCODMCIGONC CCNOJKBMCDE
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class BFGFMAFPGJB
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x24EB300", Offset = "0x24EA300", VA = "0x1824EB300")]
	public static bool IOENBCGADCK<TSelf>(this TSelf FKGCCPKFEDE) where TSelf : notnull, PCBHEGKADAG
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct BADADAGJPBB<M> : IEnumerator<KNIEPEGFJMC<M>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly int NEPEPLNDMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly int BLPNBLOFJAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private int ADGPPEIJCAE;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x767120", Offset = "0x766520")]
	public readonly KNIEPEGFJMC<M> LMEBIHANEPB
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6593800", Offset = "0x6592800", VA = "0x186593800", Slot = "4")]
		get
		{
			return default(KNIEPEGFJMC<M>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6593720", Offset = "0x6592720", VA = "0x186593720", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1663840", Offset = "0x1662840", VA = "0x181663840")]
	internal BADADAGJPBB(int IEKPJMHLDPD, int JGNCOJEDJAP, int BPEGACONGKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
	public readonly void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6593700", Offset = "0x6592700", VA = "0x186593700", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6593710", Offset = "0x6592710", VA = "0x186593710", Slot = "8")]
	public void Reset()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class HDFANCOFDJN
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x26E4370", Offset = "0x26E3370", VA = "0x1826E4370")]
	public static BADADAGJPBB<M?> DAABCIFNKOF<M>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7671A0", Offset = "0x7665A0")] KNIEPEGFJMC<M?> PLJEJHDKEOE, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x767200", Offset = "0x766600")] KNIEPEGFJMC<M?> JGNCOJEDJAP)
	{
		return default(BADADAGJPBB<M>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x26E43B0", Offset = "0x26E33B0", VA = "0x1826E43B0")]
	public static LIKCBFIDFEB<KNIEPEGFJMC<M?>, BADADAGJPBB<M?>> DNOHKOFHHDP<M>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x767260", Offset = "0x766660")] KNIEPEGFJMC<M?> PLJEJHDKEOE, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7672C0", Offset = "0x7666C0")] KNIEPEGFJMC<M?> JGNCOJEDJAP)
	{
		return default(LIKCBFIDFEB<KNIEPEGFJMC<M>, BADADAGJPBB<M>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct OEHILLACODD<M> : IEnumerator<KNIEPEGFJMC<M>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly int PPIOMJAHBKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private int ADGPPEIJCAE;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x767320", Offset = "0x766720")]
	public readonly KNIEPEGFJMC<M> LMEBIHANEPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x3277060", Offset = "0x3276060", VA = "0x183277060", Slot = "4")]
		get
		{
			return default(KNIEPEGFJMC<M>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3276FD0", Offset = "0x3275FD0", VA = "0x183276FD0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0xB93FA0", Offset = "0xB92FA0", VA = "0x180B93FA0")]
	private OEHILLACODD(int LEOAEOJMCHD, int BPEGACONGKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3276F90", Offset = "0x3275F90", VA = "0x183276F90")]
	public static OEHILLACODD<M> PDFDKBNLMOP(int LEOAEOJMCHD)
	{
		return default(OEHILLACODD<M>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3276F80", Offset = "0x3275F80", VA = "0x183276F80", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3276FC0", Offset = "0x3275FC0", VA = "0x183276FC0", Slot = "8")]
	public void Reset()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class GBMFMOBOMDE
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x72F34B0", Offset = "0x72F24B0", VA = "0x1872F34B0")]
	public static KFFAHHKFAGP IKBIGFALLCH(this in AICFOEHJNOF FKGCCPKFEDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x72F33F0", Offset = "0x72F23F0", VA = "0x1872F33F0")]
	public static AICFOEHJNOF EILKNJCKJNI(this KFFAHHKFAGP FKGCCPKFEDE)
	{
		return default(AICFOEHJNOF);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x72F3310", Offset = "0x72F2310", VA = "0x1872F3310")]
	public static KFFAHHKFAGP? CGHNOPONNJL(this in AICFOEHJNOF? FKGCCPKFEDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x72F3540", Offset = "0x72F2540", VA = "0x1872F3540")]
	public static AICFOEHJNOF? JJGLKEDOHDG(this KFFAHHKFAGP? FKGCCPKFEDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct NODALFOGOFI<TMarker> : IEquatable<NODALFOGOFI<TMarker>>, EIDOCAAFNMH<NODALFOGOFI<TMarker>>, IComparable<NODALFOGOFI<TMarker>> where TMarker : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly Guid MFBFBBPHOGG;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x767760", Offset = "0x766B60")]
	public static NODALFOGOFI<TMarker> OINHJLGKBEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2A792E0", Offset = "0x2A782E0", VA = "0x182A792E0")]
		get
		{
			return default(NODALFOGOFI<TMarker>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7677D0", Offset = "0x766BD0")]
	public static NODALFOGOFI<TMarker>? CLLNJPDPMPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2A790E0", Offset = "0x2A780E0", VA = "0x182A790E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0xBE2EF0", Offset = "0xBE1EF0", VA = "0x180BE2EF0")]
	public NODALFOGOFI(in Guid CKDFGEALFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2A79400", Offset = "0x2A78400", VA = "0x182A79400")]
	public CCOGGIBDMBG? IKBIGFALLCH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2A790B0", Offset = "0x2A780B0", VA = "0x182A790B0")]
	public bool CEKJJDKOFID([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x767400", Offset = "0x766800")] in NODALFOGOFI<TMarker> BKLMLPFOMCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2A79210", Offset = "0x2A78210", VA = "0x182A79210", Slot = "4")]
	public bool Equals([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x767470", Offset = "0x766870")] NODALFOGOFI<TMarker> BKLMLPFOMCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2A79260", Offset = "0x2A78260", VA = "0x182A79260", Slot = "0")]
	public override bool Equals(object BKLMLPFOMCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2A791E0", Offset = "0x2A781E0", VA = "0x182A791E0", Slot = "6")]
	public int CompareTo([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7674D0", Offset = "0x7668D0")] NODALFOGOFI<TMarker> BKLMLPFOMCO)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2A79210", Offset = "0x2A78210", VA = "0x182A79210")]
	public static bool LFCPNLBCIDE([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x767530", Offset = "0x766930")] in NODALFOGOFI<TMarker> EEDCFNGAAFO, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7675A0", Offset = "0x7669A0")] in NODALFOGOFI<TMarker> OFBPOJFNNIJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2A79540", Offset = "0x2A78540", VA = "0x182A79540")]
	public static bool JIPCNIGMDBL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x767610", Offset = "0x766A10")] in NODALFOGOFI<TMarker> EEDCFNGAAFO, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x767680", Offset = "0x766A80")] in NODALFOGOFI<TMarker> OFBPOJFNNIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2A793E0", Offset = "0x2A783E0", VA = "0x182A793E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2A795A0", Offset = "0x2A785A0", VA = "0x182A795A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2A79210", Offset = "0x2A78210", VA = "0x182A79210", Slot = "5")]
	private bool KOMJMFEHONA([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7676F0", Offset = "0x766AF0")] in NODALFOGOFI<TMarker> BKLMLPFOMCO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class GMFOPDMKADN
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1B7E9D0", Offset = "0x1B7D9D0", VA = "0x181B7E9D0")]
	public static NODALFOGOFI<TMarker?> EILKNJCKJNI<TMarker>(this CCOGGIBDMBG? FKGCCPKFEDE)
	{
		return default(NODALFOGOFI<TMarker>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1B7EAB0", Offset = "0x1B7DAB0", VA = "0x181B7EAB0")]
	public static NODALFOGOFI<TMarker?> JKNLIAAAHMG<TMarker>(this in Guid FKGCCPKFEDE)
	{
		return default(NODALFOGOFI<TMarker>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class GGFEJEFHGEL<TOther>
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x767880", Offset = "0x766C80")]
	internal static readonly NODALFOGOFI<TOther> OINHJLGKBEA;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7678E0", Offset = "0x766CE0")]
	internal static readonly NODALFOGOFI<TOther>? CLLNJPDPMPA;
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[DefaultMember("Item")]
public readonly struct NIIMLJEIDCA<M, T> where M : notnull where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7679B0", Offset = "0x766DB0")]
	private readonly FOJMHCPEJAO<T> MCAELBCBPAG;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x767AD0", Offset = "0x766ED0")]
	public KNIEPEGFJMC<M> ILIAJIKNDAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2436E70", Offset = "0x2435E70", VA = "0x182436E70")]
		get
		{
			return default(KNIEPEGFJMC<M>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int NKLAFIEKONA
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2436F30", Offset = "0x2435F30", VA = "0x182436F30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public T CLDBOBAGHND
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2436D80", Offset = "0x2435D80", VA = "0x182436D80")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x22C0DA0", Offset = "0x22BFDA0", VA = "0x1822C0DA0")]
	internal NIIMLJEIDCA([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x767A70", Offset = "0x766E70")] FOJMHCPEJAO<T> GJAKHOONFBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2063A70", Offset = "0x2062A70", VA = "0x182063A70")]
	public IEnumerable<T> MPNIPFEAALI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2436D40", Offset = "0x2435D40", VA = "0x182436D40")]
	public IEnumerator<T> EFCEFGGNIIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2436F70", Offset = "0x2435F70", VA = "0x182436F70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class JPJPCLNFEGH<M>
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x22A6D50", Offset = "0x22A5D50", VA = "0x1822A6D50")]
	public static NIIMLJEIDCA<M, T> EJOJEPHIGMJ<T>(params T[] GJAKHOONFBO) where T : notnull
	{
		return default(NIIMLJEIDCA<M, T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class PNHHDFIJFOB
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x72F38B0", Offset = "0x72F28B0", VA = "0x1872F38B0")]
	public static DPHPCCJAOAD IKBIGFALLCH(this in FDGGAFLCIEB FKGCCPKFEDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x72F37C0", Offset = "0x72F27C0", VA = "0x1872F37C0")]
	public static FDGGAFLCIEB EILKNJCKJNI(this DPHPCCJAOAD FKGCCPKFEDE)
	{
		return default(FDGGAFLCIEB);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x72F36D0", Offset = "0x72F26D0", VA = "0x1872F36D0")]
	public static DPHPCCJAOAD? CGHNOPONNJL(this in FDGGAFLCIEB? FKGCCPKFEDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x72F3950", Offset = "0x72F2950", VA = "0x1872F3950")]
	public static FDGGAFLCIEB? JJGLKEDOHDG(this DPHPCCJAOAD? FKGCCPKFEDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public readonly struct FDGGAFLCIEB : IEquatable<FDGGAFLCIEB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly float EPJLHCNBMAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly float BDPMFEBJKME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly float OMDKDBHMGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly float GEJANMIPGON;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly FDGGAFLCIEB AGDEGJHKFIB;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly FDGGAFLCIEB BAMMJJDFDBO;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public static readonly FDGGAFLCIEB GGABJDJCOBO;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly FDGGAFLCIEB ANIKCGMDPGJ;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static readonly FDGGAFLCIEB IKEBBNCJAMD;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x20BDE10", Offset = "0x20BCE10", VA = "0x1820BDE10")]
	public FDGGAFLCIEB(float FKPADFHIFHA, float NAFGCLHKJEH, float GAOHFHENACG, float IPDEMIKFKME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x72F2D30", Offset = "0x72F1D30", VA = "0x1872F2D30")]
	public static FDGGAFLCIEB DAABCIFNKOF(float FKPADFHIFHA, float NAFGCLHKJEH, float GAOHFHENACG, float IPDEMIKFKME)
	{
		return default(FDGGAFLCIEB);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5D09870", Offset = "0x5D08870", VA = "0x185D09870")]
	public static bool LFCPNLBCIDE(in FDGGAFLCIEB JMKFPOOBMEL, in FDGGAFLCIEB OIMIHNAHPGP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x72F2F70", Offset = "0x72F1F70", VA = "0x1872F2F70")]
	public static bool JIPCNIGMDBL(in FDGGAFLCIEB JMKFPOOBMEL, in FDGGAFLCIEB OIMIHNAHPGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x72F2ED0", Offset = "0x72F1ED0", VA = "0x1872F2ED0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x72F2D50", Offset = "0x72F1D50", VA = "0x1872F2D50", Slot = "0")]
	public override bool Equals(object EOHGDDIECBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x72F3010", Offset = "0x72F2010", VA = "0x1872F3010", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x72F2E30", Offset = "0x72F1E30", VA = "0x1872F2E30", Slot = "4")]
	public bool Equals(FDGGAFLCIEB BKLMLPFOMCO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct FDABEGOCPMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly float HAFHMMMHDCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly float OHCCADLDNNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly float GPLNNLJGFBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly float PMJGGJHHAEP;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly FDABEGOCPMK DIALEPLBPDO;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly FDABEGOCPMK LCJGBFDPKJJ;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x20BDE10", Offset = "0x20BCE10", VA = "0x1820BDE10")]
	public FDABEGOCPMK(float AOPJFEBAIKC, float LMCNEJKNLEB, float CNOAFMMFDKH, float LFEMLKHNBHE)
	{
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
