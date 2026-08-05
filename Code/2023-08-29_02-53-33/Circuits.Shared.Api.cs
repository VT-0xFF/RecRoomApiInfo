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
		[Cpp2IlInjected.Address(RVA = "0x7F1AF0", Offset = "0x7F0EF0", VA = "0x1807F1AF0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6F95950", Offset = "0x6F94D50", VA = "0x186F95950")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8D1B70", Offset = "0x8D0F70", VA = "0x1808D1B70")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9D7910", Offset = "0x9D6D10", VA = "0x1809D7910")]
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
public readonly struct NMDAEKDHHIG<M, T> where M : notnull where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly T[] CPCKIFIGLBC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FADF0", Offset = "0x6FA1F0")]
	public ALPPKKPIFBE<M> NALFHPNKMGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2A9CCA0", Offset = "0x2A9C0A0", VA = "0x182A9CCA0")]
		get
		{
			return default(ALPPKKPIFBE<M>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int KPHJAIPOAJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x194C1E0", Offset = "0x194B5E0", VA = "0x18194C1E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public T OFCFHOOOGOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x24B48C0", Offset = "0x24B3CC0", VA = "0x1824B48C0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x9EA8F0", Offset = "0x9E9CF0", VA = "0x1809EA8F0")]
	internal NMDAEKDHHIG(T[] KGHLGBOMEFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2A9CD30", Offset = "0x2A9C130", VA = "0x182A9CD30")]
	public static NMDAEKDHHIG<M, T> OHIOHLNJBHE(int PGBALNGGNPG)
	{
		return default(NMDAEKDHHIG<M, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7E80A0", Offset = "0x7E74A0", VA = "0x1807E80A0")]
	public IEnumerable<T> PFLKBIEMNPD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2A9CB30", Offset = "0x2A9BF30", VA = "0x182A9CB30")]
	public PBGOLDFLKNF<M, T> ANINKGLMPCH()
	{
		return default(PBGOLDFLKNF<M, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2A9CC20", Offset = "0x2A9C020", VA = "0x182A9CC20")]
	public IEnumerator<T> FNKOJPGNHJL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2A9CDC0", Offset = "0x2A9C1C0", VA = "0x182A9CDC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class FNFMEIOHGDD<M>
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2138DA0", Offset = "0x21381A0", VA = "0x182138DA0")]
	public static NMDAEKDHHIG<M, T> PGCJPAGAACD<T>(params T[] KGHLGBOMEFA) where T : notnull
	{
		return default(NMDAEKDHHIG<M, T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class DPKIHPNPBMG
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x24B4C30", Offset = "0x24B4030", VA = "0x1824B4C30")]
	public static T? FFIMABMBDKP<T, M>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FAE90", Offset = "0x6FA290")] this ref NMDAEKDHHIG<M?, T?> JCOLBAAGCGE, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FAEF0", Offset = "0x6FA2F0")] ALPPKKPIFBE<M?> GNPGECNAJNK)
	{
		return (T?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x24B20B0", Offset = "0x24B14B0", VA = "0x1824B20B0")]
	public static void DADPJLGDIHI<M, T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FAF50", Offset = "0x6FA350")] this ref NMDAEKDHHIG<M?, T?> JCOLBAAGCGE, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FAFB0", Offset = "0x6FA3B0")] ALPPKKPIFBE<M?> GNPGECNAJNK, in T KKIAKNLLHIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface NJCLDDOOOCE
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool AAEKMCJHPPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct LIILOKBHDEP : IEquatable<LIILOKBHDEP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly float BFKCDGHEBEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly float LGCLHCNDMKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly float NJEBLFDLJGJ;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public static readonly LIILOKBHDEP HCEBJBPNHKF;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly LIILOKBHDEP KGGCKEOAHEC;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly LIILOKBHDEP DCFOJGBEHIG;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly LIILOKBHDEP FFLELBIAAMO;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly LIILOKBHDEP JKLGOKICOEE;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly LIILOKBHDEP PEKIDLCOLFJ;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly LIILOKBHDEP FGCIKGFNKDM;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public static readonly LIILOKBHDEP ACENDMMFGDO;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly LIILOKBHDEP HEIIMEEGFEL;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public static readonly LIILOKBHDEP MBFCBBACEGB;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly LIILOKBHDEP MMCHNMMBENN;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public static readonly LIILOKBHDEP ICOPFJHIKAH;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static readonly LIILOKBHDEP BJBLLBILFGC;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static readonly LIILOKBHDEP IDEFCLFOBPB;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static readonly LIILOKBHDEP LGPEKLIHFAA;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static readonly LIILOKBHDEP OJHENBGJHPD;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly LIILOKBHDEP EIFPPECHPMI;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x45FEFD0", Offset = "0x45FE3D0", VA = "0x1845FEFD0")]
	public LIILOKBHDEP(float GEAEMIOLNKK, float KFMHCNGHPHP, float PAAGFGCMLHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6F955F0", Offset = "0x6F949F0", VA = "0x186F955F0")]
	public static LIILOKBHDEP OHIOHLNJBHE(float GEAEMIOLNKK, float KFMHCNGHPHP, float PAAGFGCMLHM)
	{
		return default(LIILOKBHDEP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6F955C0", Offset = "0x6F949C0", VA = "0x186F955C0")]
	public static bool MCJHDEKAHDI(in LIILOKBHDEP LLKHFJFGFIB, in LIILOKBHDEP LDJLPHFLLEO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6F95530", Offset = "0x6F94930", VA = "0x186F95530")]
	public static bool JJOPDHABKNF(in LIILOKBHDEP LLKHFJFGFIB, in LIILOKBHDEP LDJLPHFLLEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6F954C0", Offset = "0x6F948C0", VA = "0x186F954C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6F953E0", Offset = "0x6F947E0", VA = "0x186F953E0", Slot = "0")]
	public override bool Equals(object ICNDEPGFBMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6F95610", Offset = "0x6F94A10", VA = "0x186F95610", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6F95350", Offset = "0x6F94750", VA = "0x186F95350", Slot = "4")]
	public bool Equals(LIILOKBHDEP LNOOAJJNCAE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct ENGEKKGFJKO : IEquatable<ENGEKKGFJKO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly KCBBOPBCMLG DLMCOOJLNGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly LIILOKBHDEP COBAGHJPFMB;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly ENGEKKGFJKO OEEHOLCBKMP;

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6F949C0", Offset = "0x6F93DC0", VA = "0x186F949C0")]
	public ENGEKKGFJKO(in KCBBOPBCMLG PFHPGOOLCFP, in LIILOKBHDEP OMFIFBMFGMG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6F94760", Offset = "0x6F93B60", VA = "0x186F94760")]
	public static bool MCJHDEKAHDI(in ENGEKKGFJKO LLKHFJFGFIB, in ENGEKKGFJKO LDJLPHFLLEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6F946D0", Offset = "0x6F93AD0", VA = "0x186F946D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6F94600", Offset = "0x6F93A00", VA = "0x186F94600", Slot = "0")]
	public override bool Equals(object ICNDEPGFBMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6F94850", Offset = "0x6F93C50", VA = "0x186F94850", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6F94590", Offset = "0x6F93990", VA = "0x186F94590", Slot = "4")]
	public bool Equals(ENGEKKGFJKO LNOOAJJNCAE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct ALPPKKPIFBE<TMarker> : IEquatable<ALPPKKPIFBE<TMarker>>, EIMBCPMDPDA<ALPPKKPIFBE<TMarker>>, IComparable<ALPPKKPIFBE<TMarker>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly int JINNHIGKMEA;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FB360", Offset = "0x6FA760")]
	public ALPPKKPIFBE<TMarker> GJEEICJJLDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x30F34A0", Offset = "0x30F28A0", VA = "0x1830F34A0")]
		get
		{
			return default(ALPPKKPIFBE<TMarker>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FB3C0", Offset = "0x6FA7C0")]
	public ALPPKKPIFBE<TMarker> KFCFGPOFHLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x30F3410", Offset = "0x30F2810", VA = "0x1830F3410")]
		get
		{
			return default(ALPPKKPIFBE<TMarker>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8D4800", Offset = "0x8D3C00", VA = "0x1808D4800")]
	public ALPPKKPIFBE(int KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2430D70", Offset = "0x2430170", VA = "0x182430D70")]
	public ALPPKKPIFBE<TOther> CFLDFKCGHAD<TOther>() where TOther : TMarker
	{
		return default(ALPPKKPIFBE<TOther>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0xBDECE0", Offset = "0xBDE0E0", VA = "0x180BDECE0")]
	public int IBKPGJDIIJI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x30F3480", Offset = "0x30F2880", VA = "0x1830F3480")]
	public bool PCEGJADMELK([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FB040", Offset = "0x6FA440")] in ALPPKKPIFBE<TMarker> LNOOAJJNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x30F32C0", Offset = "0x30F26C0", VA = "0x1830F32C0", Slot = "4")]
	public bool Equals([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FB0B0", Offset = "0x6FA4B0")] ALPPKKPIFBE<TMarker> LNOOAJJNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2CEB880", Offset = "0x2CEAC80", VA = "0x182CEB880", Slot = "0")]
	public override bool Equals(object LNOOAJJNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x30F32A0", Offset = "0x30F26A0", VA = "0x1830F32A0", Slot = "6")]
	public int CompareTo([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FB110", Offset = "0x6FA510")] ALPPKKPIFBE<TMarker> LNOOAJJNCAE)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x30F33D0", Offset = "0x30F27D0", VA = "0x1830F33D0")]
	public static bool MCJHDEKAHDI([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FB170", Offset = "0x6FA570")] ALPPKKPIFBE<TMarker> OEMIPMEJOAJ, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FB1D0", Offset = "0x6FA5D0")] ALPPKKPIFBE<TMarker> NJNCIEAMKKF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x30F3380", Offset = "0x30F2780", VA = "0x1830F3380")]
	public static bool JJOPDHABKNF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FB230", Offset = "0x6FA630")] ALPPKKPIFBE<TMarker> OEMIPMEJOAJ, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FB290", Offset = "0x6FA690")] ALPPKKPIFBE<TMarker> NJNCIEAMKKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x30F3360", Offset = "0x30F2760", VA = "0x1830F3360", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x30F3510", Offset = "0x30F2910", VA = "0x1830F3510", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x30F3310", Offset = "0x30F2710", VA = "0x1830F3310", Slot = "5")]
	private bool GHLJCPGBDEE([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FB2F0", Offset = "0x6FA6F0")] in ALPPKKPIFBE<TMarker> LNOOAJJNCAE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class LLEELPADJBK
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2429CC0", Offset = "0x24290C0", VA = "0x182429CC0")]
	public static ALPPKKPIFBE<TMarker?> IEMGLOJEELL<TMarker>(this int JCOLBAAGCGE)
	{
		return default(ALPPKKPIFBE<TMarker>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2429CC0", Offset = "0x24290C0", VA = "0x182429CC0")]
	public static ALPPKKPIFBE<TMarker?> EECCKJCNBOB<TMarker>(this int JCOLBAAGCGE)
	{
		return default(ALPPKKPIFBE<TMarker>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0xBC72A0", Offset = "0xBC66A0", VA = "0x180BC72A0")]
	public static LHIEBHBOHGD<ALPPKKPIFBE<TMarker?>, GEDMNKEEEMA<TMarker?>> KJJLEAAOCEE<TMarker>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FB460", Offset = "0x6FA860")] ALPPKKPIFBE<TMarker?> OMPEJKOIBJK, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FB4C0", Offset = "0x6FA8C0")] ALPPKKPIFBE<TMarker?> ODLAKMAKJKG)
	{
		return default(LHIEBHBOHGD<ALPPKKPIFBE<TMarker>, GEDMNKEEEMA<TMarker>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2429CF0", Offset = "0x24290F0", VA = "0x182429CF0")]
	public static LHIEBHBOHGD<ALPPKKPIFBE<TMarker?>, GEDMNKEEEMA<TMarker?>> IBFLNFAMLOL<TMarker>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FB520", Offset = "0x6FA920")] ALPPKKPIFBE<TMarker?> ODLAKMAKJKG)
	{
		return default(LHIEBHBOHGD<ALPPKKPIFBE<TMarker>, GEDMNKEEEMA<TMarker>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class MLCPFCCGNBH<TOther>
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x139DF80", Offset = "0x139D380", VA = "0x18139DF80")]
	public static ALPPKKPIFBE<TOther> AFEHLNPONOD<TMarker>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FB580", Offset = "0x6FA980")] ALPPKKPIFBE<TMarker> JCOLBAAGCGE) where TMarker : TOther
	{
		return default(ALPPKKPIFBE<TOther>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface OJEJIGIMNLE
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	NJCLDDOOOCE JNJELMMNKIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class ONINCAHICLK
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x12CAEB0", Offset = "0x12CA2B0", VA = "0x1812CAEB0")]
	public static bool AMCOLMMGNKL<TSelf>(this TSelf JCOLBAAGCGE) where TSelf : notnull, OJEJIGIMNLE
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct GEDMNKEEEMA<M> : IEnumerator<ALPPKKPIFBE<M>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly int IIOOOEJHENN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly int HCGCFCIAAMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private int AKEAOCACEOM;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FB5E0", Offset = "0x6FA9E0")]
	public readonly ALPPKKPIFBE<M> NEGPJPJCKFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x2122330", Offset = "0x2121730", VA = "0x182122330", Slot = "4")]
		get
		{
			return default(ALPPKKPIFBE<M>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2122250", Offset = "0x2121650", VA = "0x182122250", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0xC1EC50", Offset = "0xC1E050", VA = "0x180C1EC50")]
	internal GEDMNKEEEMA(int EDPLHHMEBDL, int ODLAKMAKJKG, int JHBNKDKKBDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "5")]
	public readonly void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2122230", Offset = "0x2121630", VA = "0x182122230", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2122240", Offset = "0x2121640", VA = "0x182122240", Slot = "8")]
	public void Reset()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class OPJINCDIABE
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x12CC310", Offset = "0x12CB710", VA = "0x1812CC310")]
	public static GEDMNKEEEMA<M?> OHIOHLNJBHE<M>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FB6A0", Offset = "0x6FAAA0")] ALPPKKPIFBE<M?> OMPEJKOIBJK, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FB700", Offset = "0x6FAB00")] ALPPKKPIFBE<M?> ODLAKMAKJKG)
	{
		return default(GEDMNKEEEMA<M>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x12CC290", Offset = "0x12CB690", VA = "0x1812CC290")]
	public static LHIEBHBOHGD<ALPPKKPIFBE<M?>, GEDMNKEEEMA<M?>> EIGFCNENOJP<M>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FB760", Offset = "0x6FAB60")] ALPPKKPIFBE<M?> OMPEJKOIBJK, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FB7C0", Offset = "0x6FABC0")] ALPPKKPIFBE<M?> ODLAKMAKJKG)
	{
		return default(LHIEBHBOHGD<ALPPKKPIFBE<M>, GEDMNKEEEMA<M>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct NPMCLIGCPHM<M> : IEnumerator<ALPPKKPIFBE<M>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly int IDMDPPENDAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private int AKEAOCACEOM;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FB820", Offset = "0x6FAC20")]
	public readonly ALPPKKPIFBE<M> NEGPJPJCKFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x2AAAFE0", Offset = "0x2AAA3E0", VA = "0x182AAAFE0", Slot = "4")]
		get
		{
			return default(ALPPKKPIFBE<M>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2AAAF50", Offset = "0x2AAA350", VA = "0x182AAAF50", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xA28DB0", Offset = "0xA281B0", VA = "0x180A28DB0")]
	private NPMCLIGCPHM(int ECOAGJBCGAI, int JHBNKDKKBDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2AAAF00", Offset = "0x2AAA300", VA = "0x182AAAF00")]
	public static NPMCLIGCPHM<M> CPNOGBADHMH(int ECOAGJBCGAI)
	{
		return default(NPMCLIGCPHM<M>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2AAAF30", Offset = "0x2AAA330", VA = "0x182AAAF30", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2AAAF40", Offset = "0x2AAA340", VA = "0x182AAAF40", Slot = "8")]
	public void Reset()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class IDFJPHLLOCI
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6F94BC0", Offset = "0x6F93FC0", VA = "0x186F94BC0")]
	public static BCFINGMOBKJ IBKPGJDIIJI(this in LIILOKBHDEP JCOLBAAGCGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6F94C50", Offset = "0x6F94050", VA = "0x186F94C50")]
	public static LIILOKBHDEP LFPLIBEJFBF(this BCFINGMOBKJ JCOLBAAGCGE)
	{
		return default(LIILOKBHDEP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6F94AE0", Offset = "0x6F93EE0", VA = "0x186F94AE0")]
	public static BCFINGMOBKJ? HJNLHMOPEAC(this in LIILOKBHDEP? JCOLBAAGCGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6F949E0", Offset = "0x6F93DE0", VA = "0x186F949E0")]
	public static LIILOKBHDEP? HBFOCBFNBPO(this BCFINGMOBKJ? JCOLBAAGCGE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public readonly struct PFGLDNGDJGP<TMarker> : IEquatable<PFGLDNGDJGP<TMarker>>, EIMBCPMDPDA<PFGLDNGDJGP<TMarker>>, IComparable<PFGLDNGDJGP<TMarker>> where TMarker : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly Guid GPADECEPDCE;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FBC60", Offset = "0x6FB060")]
	public static PFGLDNGDJGP<TMarker> OJIJINABCLB
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x2CEB900", Offset = "0x2CEAD00", VA = "0x182CEB900")]
		get
		{
			return default(PFGLDNGDJGP<TMarker>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FBCD0", Offset = "0x6FB0D0")]
	public static PFGLDNGDJGP<TMarker>? IBAHPDAAEOC
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2CEB750", Offset = "0x2CEAB50", VA = "0x182CEB750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0xAA5220", Offset = "0xAA4620", VA = "0x180AA5220")]
	public PFGLDNGDJGP(in Guid KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2CEBA20", Offset = "0x2CEAE20", VA = "0x182CEBA20")]
	public OFMEFNODOID? IBKPGJDIIJI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2CEBBC0", Offset = "0x2CEAFC0", VA = "0x182CEBBC0")]
	public bool PCEGJADMELK([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FB900", Offset = "0x6FAD00")] in PFGLDNGDJGP<TMarker> LNOOAJJNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2CEB700", Offset = "0x2CEAB00", VA = "0x182CEB700", Slot = "4")]
	public bool Equals([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FB970", Offset = "0x6FAD70")] PFGLDNGDJGP<TMarker> LNOOAJJNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2CEB880", Offset = "0x2CEAC80", VA = "0x182CEB880", Slot = "0")]
	public override bool Equals(object LNOOAJJNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2CEB850", Offset = "0x2CEAC50", VA = "0x182CEB850", Slot = "6")]
	public int CompareTo([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FB9D0", Offset = "0x6FADD0")] PFGLDNGDJGP<TMarker> LNOOAJJNCAE)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2CEB700", Offset = "0x2CEAB00", VA = "0x182CEB700")]
	public static bool MCJHDEKAHDI([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FBA30", Offset = "0x6FAE30")] in PFGLDNGDJGP<TMarker> OEMIPMEJOAJ, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FBAA0", Offset = "0x6FAEA0")] in PFGLDNGDJGP<TMarker> NJNCIEAMKKF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2CEBB60", Offset = "0x2CEAF60", VA = "0x182CEBB60")]
	public static bool JJOPDHABKNF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FBB10", Offset = "0x6FAF10")] in PFGLDNGDJGP<TMarker> OEMIPMEJOAJ, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FBB80", Offset = "0x6FAF80")] in PFGLDNGDJGP<TMarker> NJNCIEAMKKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2CEBA00", Offset = "0x2CEAE00", VA = "0x182CEBA00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2CEBBF0", Offset = "0x2CEAFF0", VA = "0x182CEBBF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2CEB700", Offset = "0x2CEAB00", VA = "0x182CEB700", Slot = "5")]
	private bool BBNCJKHJNIA([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FBBF0", Offset = "0x6FAFF0")] in PFGLDNGDJGP<TMarker> LNOOAJJNCAE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class EMCEPBFMIJD
{
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1F92940", Offset = "0x1F91D40", VA = "0x181F92940")]
	public static PFGLDNGDJGP<TMarker?> LFPLIBEJFBF<TMarker>(this OFMEFNODOID? JCOLBAAGCGE)
	{
		return default(PFGLDNGDJGP<TMarker>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1F92910", Offset = "0x1F91D10", VA = "0x181F92910")]
	public static PFGLDNGDJGP<TMarker?> IEMGLOJEELL<TMarker>(this in Guid JCOLBAAGCGE)
	{
		return default(PFGLDNGDJGP<TMarker>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class PJGHKBDLHOE<TOther>
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FBD80", Offset = "0x6FB180")]
	internal static readonly PFGLDNGDJGP<TOther> OJIJINABCLB;

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FBDE0", Offset = "0x6FB1E0")]
	internal static readonly PFGLDNGDJGP<TOther>? IBAHPDAAEOC;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DefaultMember("Item")]
public readonly struct PBGOLDFLKNF<M, T> where M : notnull where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FBEB0", Offset = "0x6FB2B0")]
	private readonly ONLPENJAHGA<T> CPCKIFIGLBC;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FBFD0", Offset = "0x6FB3D0")]
	public ALPPKKPIFBE<M> NALFHPNKMGH
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2CE25D0", Offset = "0x2CE19D0", VA = "0x182CE25D0")]
		get
		{
			return default(ALPPKKPIFBE<M>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int KPHJAIPOAJP
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2CE2590", Offset = "0x2CE1990", VA = "0x182CE2590")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public T OFCFHOOOGOP
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2CE2500", Offset = "0x2CE1900", VA = "0x182CE2500")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x214AA60", Offset = "0x2149E60", VA = "0x18214AA60")]
	internal PBGOLDFLKNF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FBF70", Offset = "0x6FB370")] ONLPENJAHGA<T> KGHLGBOMEFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2045E90", Offset = "0x2045290", VA = "0x182045E90")]
	public IEnumerable<T> PFLKBIEMNPD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2CE2550", Offset = "0x2CE1950", VA = "0x182CE2550")]
	public IEnumerator<T> FNKOJPGNHJL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2CE2690", Offset = "0x2CE1A90", VA = "0x182CE2690", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class JPIHAFHALMA<M>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x21DE6E0", Offset = "0x21DDAE0", VA = "0x1821DE6E0")]
	public static PBGOLDFLKNF<M, T> PGCJPAGAACD<T>(params T[] KGHLGBOMEFA) where T : notnull
	{
		return default(PBGOLDFLKNF<M, T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class EMBHKGJOBME
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6F94400", Offset = "0x6F93800", VA = "0x186F94400")]
	public static LMDIPPGCKEC IBKPGJDIIJI(this in KCBBOPBCMLG JCOLBAAGCGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6F944A0", Offset = "0x6F938A0", VA = "0x186F944A0")]
	public static KCBBOPBCMLG LFPLIBEJFBF(this LMDIPPGCKEC JCOLBAAGCGE)
	{
		return default(KCBBOPBCMLG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6F94310", Offset = "0x6F93710", VA = "0x186F94310")]
	public static LMDIPPGCKEC? HJNLHMOPEAC(this in KCBBOPBCMLG? JCOLBAAGCGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6F941C0", Offset = "0x6F935C0", VA = "0x186F941C0")]
	public static KCBBOPBCMLG? HBFOCBFNBPO(this LMDIPPGCKEC? JCOLBAAGCGE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public readonly struct KCBBOPBCMLG : IEquatable<KCBBOPBCMLG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly float BFKCDGHEBEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly float LGCLHCNDMKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly float NJEBLFDLJGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly float EBOIMBOHCCH;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly KCBBOPBCMLG OEEHOLCBKMP;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly KCBBOPBCMLG DCFOJGBEHIG;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly KCBBOPBCMLG FFLELBIAAMO;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly KCBBOPBCMLG JKLGOKICOEE;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public static readonly KCBBOPBCMLG PEKIDLCOLFJ;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1FCB0B0", Offset = "0x1FCA4B0", VA = "0x181FCB0B0")]
	public KCBBOPBCMLG(float GEAEMIOLNKK, float KFMHCNGHPHP, float PAAGFGCMLHM, float EFCIMGFJGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6F94FD0", Offset = "0x6F943D0", VA = "0x186F94FD0")]
	public static KCBBOPBCMLG OHIOHLNJBHE(float GEAEMIOLNKK, float KFMHCNGHPHP, float PAAGFGCMLHM, float EFCIMGFJGNL)
	{
		return default(KCBBOPBCMLG);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5E2FC30", Offset = "0x5E2F030", VA = "0x185E2FC30")]
	public static bool MCJHDEKAHDI(in KCBBOPBCMLG LLKHFJFGFIB, in KCBBOPBCMLG LDJLPHFLLEO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6F94F30", Offset = "0x6F94330", VA = "0x186F94F30")]
	public static bool JJOPDHABKNF(in KCBBOPBCMLG LLKHFJFGFIB, in KCBBOPBCMLG LDJLPHFLLEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6F94E90", Offset = "0x6F94290", VA = "0x186F94E90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6F94D10", Offset = "0x6F94110", VA = "0x186F94D10", Slot = "0")]
	public override bool Equals(object ICNDEPGFBMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6F94FF0", Offset = "0x6F943F0", VA = "0x186F94FF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6F94DF0", Offset = "0x6F941F0", VA = "0x186F94DF0", Slot = "4")]
	public bool Equals(KCBBOPBCMLG LNOOAJJNCAE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct LFMGDJKMDGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly float JPBHFACHJOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly float GDMKOEFEDDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly float EAGIPFNEHPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly float NNEOIOLLNDB;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly LFMGDJKMDGL JKKDLPMEKOP;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly LFMGDJKMDGL BOILNDPHGIH;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1FCB0B0", Offset = "0x1FCA4B0", VA = "0x181FCB0B0")]
	public LFMGDJKMDGL(float OBNCFODAOCD, float FPOHPGCOAGN, float CMACFBOCONA, float EJOFMGLMADH)
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
