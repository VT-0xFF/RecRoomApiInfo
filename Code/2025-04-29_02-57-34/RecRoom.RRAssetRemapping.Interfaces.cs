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
		[Cpp2IlInjected.Address(RVA = "0x9F4500", Offset = "0x9F3900", VA = "0x1809F4500")]
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
		[Cpp2IlInjected.Address(RVA = "0x834B310", Offset = "0x834A710", VA = "0x18834B310")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9F5340", Offset = "0x9F4740", VA = "0x1809F5340")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F5380", Offset = "0x9F4780", VA = "0x1809F5380")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface NCEJBDJKGCK
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string PEGKBLBFNLH(BBFALMJKFCO EOMFNMMGCEC);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BBFALMJKFCO ILOIKAMJPOD(string EOMFNMMGCEC);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct BBFALMJKFCO : IEquatable<BBFALMJKFCO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly BKGBLAEFKKI LJEOKMJLKJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly BCAJBMEKGPP EAALAEMBDFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly Guid NMFHCOEDCMP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool JHHPMKAAOIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x834A450", Offset = "0x8349850", VA = "0x18834A450")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool LNPCPMOECMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x834A360", Offset = "0x8349760", VA = "0x18834A360")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x834A7F0", Offset = "0x8349BF0", VA = "0x18834A7F0")]
	public BBFALMJKFCO(BBFALMJKFCO JHMCBIJODON, [Optional] Guid LHMBLLKGLHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5AB3670", Offset = "0x5AB2A70", VA = "0x185AB3670")]
	public BBFALMJKFCO(BKGBLAEFKKI KGGJIBECFPC, BCAJBMEKGPP PMOCGEJNFCG, [Optional] Guid LHMBLLKGLHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x834A1F0", Offset = "0x83495F0", VA = "0x18834A1F0", Slot = "4")]
	public bool Equals(BBFALMJKFCO DMMBOHMLHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x834A2B0", Offset = "0x83496B0", VA = "0x18834A2B0", Slot = "0")]
	public override bool Equals(object KLANNNFBLNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x834A390", Offset = "0x8349790", VA = "0x18834A390", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x834A420", Offset = "0x8349820", VA = "0x18834A420")]
	public static bool HGJBAFCOLON(BBFALMJKFCO BGDONNBGCJK, BBFALMJKFCO DKEKGDBAIOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x834A4E0", Offset = "0x83498E0", VA = "0x18834A4E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct BKGBLAEFKKI : IEquatable<BKGBLAEFKKI>, IComparable<BKGBLAEFKKI>, KGIFCIOKMHM
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly BKGBLAEFKKI HGNIBOKIJFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Guid FIAGFFPOAHP;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x11971F0", Offset = "0x11965F0", VA = "0x1811971F0")]
	public BKGBLAEFKKI(Guid FIAGFFPOAHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1197200", Offset = "0x1196600", VA = "0x181197200", Slot = "6")]
	public Guid ODNFDMKDAHN()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x48C3200", Offset = "0x48C2600", VA = "0x1848C3200", Slot = "4")]
	public bool Equals(BKGBLAEFKKI DMMBOHMLHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x48C31D0", Offset = "0x48C25D0", VA = "0x1848C31D0", Slot = "5")]
	public int CompareTo(BKGBLAEFKKI DMMBOHMLHLF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x834A990", Offset = "0x8349D90", VA = "0x18834A990", Slot = "0")]
	public override bool Equals(object KLANNNFBLNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x48C3460", Offset = "0x48C2860", VA = "0x1848C3460", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x48C3200", Offset = "0x48C2600", VA = "0x1848C3200")]
	public static bool HGJBAFCOLON(BKGBLAEFKKI BGDONNBGCJK, BKGBLAEFKKI DKEKGDBAIOE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x834AA40", Offset = "0x8349E40", VA = "0x18834AA40")]
	public static bool PBNEENGPCHJ(BKGBLAEFKKI BGDONNBGCJK, BKGBLAEFKKI DKEKGDBAIOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x834AA70", Offset = "0x8349E70", VA = "0x18834AA70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct KODNMIGJFEI : IEquatable<KODNMIGJFEI>, IComparable<KODNMIGJFEI>, KGIFCIOKMHM
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static readonly KODNMIGJFEI HGNIBOKIJFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Guid FIAGFFPOAHP;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x11971F0", Offset = "0x11965F0", VA = "0x1811971F0")]
	public KODNMIGJFEI(Guid FIAGFFPOAHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1197200", Offset = "0x1196600", VA = "0x181197200", Slot = "6")]
	public Guid ODNFDMKDAHN()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x48C3200", Offset = "0x48C2600", VA = "0x1848C3200", Slot = "4")]
	public bool Equals(KODNMIGJFEI DMMBOHMLHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x48C31D0", Offset = "0x48C25D0", VA = "0x1848C31D0", Slot = "5")]
	public int CompareTo(KODNMIGJFEI DMMBOHMLHLF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x834AFB0", Offset = "0x834A3B0", VA = "0x18834AFB0", Slot = "0")]
	public override bool Equals(object KLANNNFBLNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x48C3460", Offset = "0x48C2860", VA = "0x1848C3460", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x48C3200", Offset = "0x48C2600", VA = "0x1848C3200")]
	public static bool HGJBAFCOLON(KODNMIGJFEI BGDONNBGCJK, KODNMIGJFEI DKEKGDBAIOE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x834AA40", Offset = "0x8349E40", VA = "0x18834AA40")]
	public static bool PBNEENGPCHJ(KODNMIGJFEI BGDONNBGCJK, KODNMIGJFEI DKEKGDBAIOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x834B060", Offset = "0x834A460", VA = "0x18834B060", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct CJINAFCJHOI : IEquatable<CJINAFCJHOI>, IComparable<CJINAFCJHOI>, KGIFCIOKMHM
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public static readonly CJINAFCJHOI HGNIBOKIJFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Guid FIAGFFPOAHP;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x11971F0", Offset = "0x11965F0", VA = "0x1811971F0")]
	public CJINAFCJHOI(Guid FIAGFFPOAHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1197200", Offset = "0x1196600", VA = "0x181197200", Slot = "6")]
	public Guid ODNFDMKDAHN()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x48C3200", Offset = "0x48C2600", VA = "0x1848C3200", Slot = "4")]
	public bool Equals(CJINAFCJHOI DMMBOHMLHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x48C31D0", Offset = "0x48C25D0", VA = "0x1848C31D0", Slot = "5")]
	public int CompareTo(CJINAFCJHOI DMMBOHMLHLF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x834AC00", Offset = "0x834A000", VA = "0x18834AC00", Slot = "0")]
	public override bool Equals(object KLANNNFBLNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x48C3460", Offset = "0x48C2860", VA = "0x1848C3460", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x48C3200", Offset = "0x48C2600", VA = "0x1848C3200")]
	public static bool HGJBAFCOLON(CJINAFCJHOI BGDONNBGCJK, CJINAFCJHOI DKEKGDBAIOE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x834AA40", Offset = "0x8349E40", VA = "0x18834AA40")]
	public static bool PBNEENGPCHJ(CJINAFCJHOI BGDONNBGCJK, CJINAFCJHOI DKEKGDBAIOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x834ACB0", Offset = "0x834A0B0", VA = "0x18834ACB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct BCAJBMEKGPP : IEquatable<BCAJBMEKGPP>, IComparable<BCAJBMEKGPP>, KGIFCIOKMHM
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly BCAJBMEKGPP HGNIBOKIJFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Guid FIAGFFPOAHP;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x11971F0", Offset = "0x11965F0", VA = "0x1811971F0")]
	public BCAJBMEKGPP(Guid FIAGFFPOAHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1197200", Offset = "0x1196600", VA = "0x181197200", Slot = "6")]
	public Guid ODNFDMKDAHN()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x834A810", Offset = "0x8349C10", VA = "0x18834A810", Slot = "4")]
	public bool Equals(BCAJBMEKGPP DMMBOHMLHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x834A840", Offset = "0x8349C40", VA = "0x18834A840", Slot = "0")]
	public override bool Equals(object KLANNNFBLNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x48C3460", Offset = "0x48C2860", VA = "0x1848C3460", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x834A810", Offset = "0x8349C10", VA = "0x18834A810")]
	public static bool HGJBAFCOLON(BCAJBMEKGPP BGDONNBGCJK, BCAJBMEKGPP DKEKGDBAIOE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x834A8F0", Offset = "0x8349CF0", VA = "0x18834A8F0")]
	public static bool PBNEENGPCHJ(BCAJBMEKGPP BGDONNBGCJK, BCAJBMEKGPP DKEKGDBAIOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x48C31D0", Offset = "0x48C25D0", VA = "0x1848C31D0", Slot = "5")]
	public int CompareTo(BCAJBMEKGPP DMMBOHMLHLF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x834A920", Offset = "0x8349D20", VA = "0x18834A920", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x11971F0", Offset = "0x11965F0", VA = "0x1811971F0")]
	public BCAJBMEKGPP(NMLDFDLEOIG KIJMDMKIKKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct OOHHMEDGGOO : IEquatable<OOHHMEDGGOO>, IComparable<OOHHMEDGGOO>, KGIFCIOKMHM
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly OOHHMEDGGOO HGNIBOKIJFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Guid FIAGFFPOAHP;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x11971F0", Offset = "0x11965F0", VA = "0x1811971F0")]
	public OOHHMEDGGOO(Guid FIAGFFPOAHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1197200", Offset = "0x1196600", VA = "0x181197200", Slot = "6")]
	public Guid ODNFDMKDAHN()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x48C3200", Offset = "0x48C2600", VA = "0x1848C3200", Slot = "4")]
	public bool Equals(OOHHMEDGGOO DMMBOHMLHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x48C31D0", Offset = "0x48C25D0", VA = "0x1848C31D0", Slot = "5")]
	public int CompareTo(OOHHMEDGGOO DMMBOHMLHLF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x834BAE0", Offset = "0x834AEE0", VA = "0x18834BAE0", Slot = "0")]
	public override bool Equals(object KLANNNFBLNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x48C3460", Offset = "0x48C2860", VA = "0x1848C3460", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x48C3200", Offset = "0x48C2600", VA = "0x1848C3200")]
	public static bool HGJBAFCOLON(OOHHMEDGGOO BGDONNBGCJK, OOHHMEDGGOO DKEKGDBAIOE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x834AA40", Offset = "0x8349E40", VA = "0x18834AA40")]
	public static bool PBNEENGPCHJ(OOHHMEDGGOO BGDONNBGCJK, OOHHMEDGGOO DKEKGDBAIOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x834BB90", Offset = "0x834AF90", VA = "0x18834BB90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct CEIANKIDECD : IEquatable<CEIANKIDECD>, IComparable<CEIANKIDECD>, KGIFCIOKMHM
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly CEIANKIDECD HGNIBOKIJFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Guid FIAGFFPOAHP;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x11971F0", Offset = "0x11965F0", VA = "0x1811971F0")]
	public CEIANKIDECD(Guid FIAGFFPOAHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x1197200", Offset = "0x1196600", VA = "0x181197200", Slot = "6")]
	public Guid ODNFDMKDAHN()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x48C3200", Offset = "0x48C2600", VA = "0x1848C3200", Slot = "4")]
	public bool Equals(CEIANKIDECD DMMBOHMLHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x48C31D0", Offset = "0x48C25D0", VA = "0x1848C31D0", Slot = "5")]
	public int CompareTo(CEIANKIDECD DMMBOHMLHLF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x834AAE0", Offset = "0x8349EE0", VA = "0x18834AAE0", Slot = "0")]
	public override bool Equals(object KLANNNFBLNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x48C3460", Offset = "0x48C2860", VA = "0x1848C3460", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x48C3200", Offset = "0x48C2600", VA = "0x1848C3200")]
	public static bool HGJBAFCOLON(CEIANKIDECD BGDONNBGCJK, CEIANKIDECD DKEKGDBAIOE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x834AA40", Offset = "0x8349E40", VA = "0x18834AA40")]
	public static bool PBNEENGPCHJ(CEIANKIDECD BGDONNBGCJK, CEIANKIDECD DKEKGDBAIOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x834AB90", Offset = "0x8349F90", VA = "0x18834AB90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct HKFNMLCCPDK : IEquatable<HKFNMLCCPDK>, IComparable<HKFNMLCCPDK>, KGIFCIOKMHM
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly HKFNMLCCPDK HGNIBOKIJFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Guid FIAGFFPOAHP;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x11971F0", Offset = "0x11965F0", VA = "0x1811971F0")]
	public HKFNMLCCPDK(Guid FIAGFFPOAHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1197200", Offset = "0x1196600", VA = "0x181197200", Slot = "6")]
	public Guid ODNFDMKDAHN()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x48C3200", Offset = "0x48C2600", VA = "0x1848C3200", Slot = "4")]
	public bool Equals(HKFNMLCCPDK DMMBOHMLHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x48C31D0", Offset = "0x48C25D0", VA = "0x1848C31D0", Slot = "5")]
	public int CompareTo(HKFNMLCCPDK DMMBOHMLHLF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x834AD20", Offset = "0x834A120", VA = "0x18834AD20", Slot = "0")]
	public override bool Equals(object KLANNNFBLNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x48C3460", Offset = "0x48C2860", VA = "0x1848C3460", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x48C3200", Offset = "0x48C2600", VA = "0x1848C3200")]
	public static bool HGJBAFCOLON(HKFNMLCCPDK BGDONNBGCJK, HKFNMLCCPDK DKEKGDBAIOE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x834AA40", Offset = "0x8349E40", VA = "0x18834AA40")]
	public static bool PBNEENGPCHJ(HKFNMLCCPDK BGDONNBGCJK, HKFNMLCCPDK DKEKGDBAIOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x834ADD0", Offset = "0x834A1D0", VA = "0x18834ADD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct MBDBBLGDPFC : IEquatable<MBDBBLGDPFC>, IComparable<MBDBBLGDPFC>, KGIFCIOKMHM
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly MBDBBLGDPFC HGNIBOKIJFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Guid FIAGFFPOAHP;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x11971F0", Offset = "0x11965F0", VA = "0x1811971F0")]
	public MBDBBLGDPFC(Guid FIAGFFPOAHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x1197200", Offset = "0x1196600", VA = "0x181197200", Slot = "6")]
	public Guid ODNFDMKDAHN()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x48C3200", Offset = "0x48C2600", VA = "0x1848C3200", Slot = "4")]
	public bool Equals(MBDBBLGDPFC DMMBOHMLHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x48C31D0", Offset = "0x48C25D0", VA = "0x1848C31D0", Slot = "5")]
	public int CompareTo(MBDBBLGDPFC DMMBOHMLHLF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x834B0D0", Offset = "0x834A4D0", VA = "0x18834B0D0", Slot = "0")]
	public override bool Equals(object KLANNNFBLNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x48C3460", Offset = "0x48C2860", VA = "0x1848C3460", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x48C3200", Offset = "0x48C2600", VA = "0x1848C3200")]
	public static bool HGJBAFCOLON(MBDBBLGDPFC BGDONNBGCJK, MBDBBLGDPFC DKEKGDBAIOE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x834AA40", Offset = "0x8349E40", VA = "0x18834AA40")]
	public static bool PBNEENGPCHJ(MBDBBLGDPFC BGDONNBGCJK, MBDBBLGDPFC DKEKGDBAIOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x834B180", Offset = "0x834A580", VA = "0x18834B180", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct OHPFOIBFOHH : IEquatable<OHPFOIBFOHH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly string?[]? FLGEABCDHIG;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool GHONCNALJFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x834B390", Offset = "0x834A790", VA = "0x18834B390")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int FCBNPDCCHIG
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4F54E90", Offset = "0x4F54290", VA = "0x184F54E90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x834B990", Offset = "0x834AD90", VA = "0x18834B990")]
	public OHPFOIBFOHH(string? JAAECPHBFNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x834B910", Offset = "0x834AD10", VA = "0x18834B910")]
	public OHPFOIBFOHH(string?[] EPACINOLFFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x834B5F0", Offset = "0x834A9F0", VA = "0x18834B5F0")]
	private static string?[]? JDFMIIIMFAL(string?[]? EPACINOLFFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x834B820", Offset = "0x834AC20", VA = "0x18834B820")]
	public string KICHPELBMBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x834B3B0", Offset = "0x834A7B0", VA = "0x18834B3B0", Slot = "4")]
	public bool Equals(OHPFOIBFOHH DMMBOHMLHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x834B480", Offset = "0x834A880", VA = "0x18834B480", Slot = "0")]
	public override bool Equals(object KLANNNFBLNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x834B510", Offset = "0x834A910", VA = "0x18834B510", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x834B880", Offset = "0x834AC80", VA = "0x18834B880", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct NMLDFDLEOIG : IEquatable<NMLDFDLEOIG>, IComparable<NMLDFDLEOIG>, KGIFCIOKMHM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Guid FIAGFFPOAHP;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x11971F0", Offset = "0x11965F0", VA = "0x1811971F0")]
	public NMLDFDLEOIG(Guid FIAGFFPOAHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x1197200", Offset = "0x1196600", VA = "0x181197200", Slot = "6")]
	public Guid ODNFDMKDAHN()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x48C3200", Offset = "0x48C2600", VA = "0x1848C3200", Slot = "4")]
	public bool Equals(NMLDFDLEOIG DMMBOHMLHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x48C31D0", Offset = "0x48C25D0", VA = "0x1848C31D0", Slot = "5")]
	public int CompareTo(NMLDFDLEOIG DMMBOHMLHLF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x834B1F0", Offset = "0x834A5F0", VA = "0x18834B1F0", Slot = "0")]
	public override bool Equals(object KLANNNFBLNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x48C3460", Offset = "0x48C2860", VA = "0x1848C3460", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x834B2A0", Offset = "0x834A6A0", VA = "0x18834B2A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface NHOAKMKCFGJ<TModern> : ECOIMGDGOPJ<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string PNGEFPCJCHO(TModern LHNHPLACIOA);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface KGIFCIOKMHM
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Guid ODNFDMKDAHN();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface ECOIMGDGOPJ<out TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TModern MMFCPNBEKCO(string LHNHPLACIOA);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface MBKECGGBKFN
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	NHOAKMKCFGJ<BKGBLAEFKKI> ABJMAPDMIEB
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	NHOAKMKCFGJ<OOHHMEDGGOO> MHGPBOKLFDI
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	NHOAKMKCFGJ<MBDBBLGDPFC> JJMFPBBOJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	NHOAKMKCFGJ<BCAJBMEKGPP> EIFHDOLGINL
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	NHOAKMKCFGJ<CJINAFCJHOI> HCHHJCPCNDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	NHOAKMKCFGJ<HKFNMLCCPDK> HJLCPENMNLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	NHOAKMKCFGJ<KODNMIGJFEI> KIHDGLPPFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	NHOAKMKCFGJ<CEIANKIDECD> CKNALPNDGNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class IFAIDODMDJJ
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static readonly char[] NNECFCBOGOD;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x834AE70", Offset = "0x834A270", VA = "0x18834AE70")]
	public static string[] NFINJLIMGOP(string? JAAECPHBFNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x834AE40", Offset = "0x834A240", VA = "0x18834AE40")]
	public static string? DOBKELFKDEL(string? KGGJIBECFPC)
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
