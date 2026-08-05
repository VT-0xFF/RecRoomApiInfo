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
		[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8518CB0", Offset = "0x8517EB0", VA = "0x188518CB0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA1B770", Offset = "0xA1A970", VA = "0x180A1B770")]
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
		[Cpp2IlInjected.Address(RVA = "0xA1B7B0", Offset = "0xA1A9B0", VA = "0x180A1B7B0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface IPAKPNEOHDP
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string CEBCPPBDNIB(PMLAJJBBALO EEEOGOJIPGB);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PMLAJJBBALO JKAINKAKBPB(string EEEOGOJIPGB);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct PMLAJJBBALO : IEquatable<PMLAJJBBALO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly KAKAKJKDPIO FHCPJEDPBDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly MKHDGODFEOG BHPDABEFPHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly Guid CHOEJPKBJGP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool DGGHHJGJAAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8519040", Offset = "0x8518240", VA = "0x188519040")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool JHILOGFJFOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x85190D0", Offset = "0x85182D0", VA = "0x1885190D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8519430", Offset = "0x8518630", VA = "0x188519430")]
	public PMLAJJBBALO(PMLAJJBBALO PNPJLLNIDHM, [Optional] Guid NFCMKJPGKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5C178A0", Offset = "0x5C16AA0", VA = "0x185C178A0")]
	public PMLAJJBBALO(KAKAKJKDPIO FCGPCABMNKH, MKHDGODFEOG GHMMDECGFML, [Optional] Guid NFCMKJPGKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8518EF0", Offset = "0x85180F0", VA = "0x188518EF0", Slot = "4")]
	public bool Equals(PMLAJJBBALO FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8518E40", Offset = "0x8518040", VA = "0x188518E40", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8518FB0", Offset = "0x85181B0", VA = "0x188518FB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8519100", Offset = "0x8518300", VA = "0x188519100")]
	public static bool NDBPPCEOMJH(PMLAJJBBALO MHEJPNNFCGC, PMLAJJBBALO BGMAPCGDHFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8519130", Offset = "0x8518330", VA = "0x188519130", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct KAKAKJKDPIO : IEquatable<KAKAKJKDPIO>, IComparable<KAKAKJKDPIO>, FDEINOGEHIH
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly KAKAKJKDPIO MLINAHCDIHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Guid DIHOLCNHIND;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1227CC0", Offset = "0x1226EC0", VA = "0x181227CC0")]
	public KAKAKJKDPIO(Guid DIHOLCNHIND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1227CB0", Offset = "0x1226EB0", VA = "0x181227CB0", Slot = "6")]
	public Guid KLJAHCEDMMF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5397460", Offset = "0x5396660", VA = "0x185397460", Slot = "4")]
	public bool Equals(KAKAKJKDPIO FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5396FD0", Offset = "0x53961D0", VA = "0x185396FD0", Slot = "5")]
	public int CompareTo(KAKAKJKDPIO FNJGMJGALLH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x85188D0", Offset = "0x8517AD0", VA = "0x1885188D0", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5397140", Offset = "0x5396340", VA = "0x185397140", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5397460", Offset = "0x5396660", VA = "0x185397460")]
	public static bool NDBPPCEOMJH(KAKAKJKDPIO MHEJPNNFCGC, KAKAKJKDPIO BGMAPCGDHFK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8517AF0", Offset = "0x8516CF0", VA = "0x188517AF0")]
	public static bool EFJOOJHLAGB(KAKAKJKDPIO MHEJPNNFCGC, KAKAKJKDPIO BGMAPCGDHFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8518970", Offset = "0x8517B70", VA = "0x188518970", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct PAPGPDMJLIC : IEquatable<PAPGPDMJLIC>, IComparable<PAPGPDMJLIC>, FDEINOGEHIH
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static readonly PAPGPDMJLIC MLINAHCDIHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Guid DIHOLCNHIND;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1227CC0", Offset = "0x1226EC0", VA = "0x181227CC0")]
	public PAPGPDMJLIC(Guid DIHOLCNHIND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1227CB0", Offset = "0x1226EB0", VA = "0x181227CB0", Slot = "6")]
	public Guid KLJAHCEDMMF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5397460", Offset = "0x5396660", VA = "0x185397460", Slot = "4")]
	public bool Equals(PAPGPDMJLIC FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5396FD0", Offset = "0x53961D0", VA = "0x185396FD0", Slot = "5")]
	public int CompareTo(PAPGPDMJLIC FNJGMJGALLH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8518D30", Offset = "0x8517F30", VA = "0x188518D30", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5397140", Offset = "0x5396340", VA = "0x185397140", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5397460", Offset = "0x5396660", VA = "0x185397460")]
	public static bool NDBPPCEOMJH(PAPGPDMJLIC MHEJPNNFCGC, PAPGPDMJLIC BGMAPCGDHFK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8517AF0", Offset = "0x8516CF0", VA = "0x188517AF0")]
	public static bool EFJOOJHLAGB(PAPGPDMJLIC MHEJPNNFCGC, PAPGPDMJLIC BGMAPCGDHFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8518DD0", Offset = "0x8517FD0", VA = "0x188518DD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct IKJJOJNJAPI : IEquatable<IKJJOJNJAPI>, IComparable<IKJJOJNJAPI>, FDEINOGEHIH
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public static readonly IKJJOJNJAPI MLINAHCDIHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Guid DIHOLCNHIND;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1227CC0", Offset = "0x1226EC0", VA = "0x181227CC0")]
	public IKJJOJNJAPI(Guid DIHOLCNHIND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1227CB0", Offset = "0x1226EB0", VA = "0x181227CB0", Slot = "6")]
	public Guid KLJAHCEDMMF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5397460", Offset = "0x5396660", VA = "0x185397460", Slot = "4")]
	public bool Equals(IKJJOJNJAPI FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5396FD0", Offset = "0x53961D0", VA = "0x185396FD0", Slot = "5")]
	public int CompareTo(IKJJOJNJAPI FNJGMJGALLH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x85187C0", Offset = "0x85179C0", VA = "0x1885187C0", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5397140", Offset = "0x5396340", VA = "0x185397140", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5397460", Offset = "0x5396660", VA = "0x185397460")]
	public static bool NDBPPCEOMJH(IKJJOJNJAPI MHEJPNNFCGC, IKJJOJNJAPI BGMAPCGDHFK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8517AF0", Offset = "0x8516CF0", VA = "0x188517AF0")]
	public static bool EFJOOJHLAGB(IKJJOJNJAPI MHEJPNNFCGC, IKJJOJNJAPI BGMAPCGDHFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8518860", Offset = "0x8517A60", VA = "0x188518860", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct MKHDGODFEOG : IEquatable<MKHDGODFEOG>, IComparable<MKHDGODFEOG>, FDEINOGEHIH
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly MKHDGODFEOG MLINAHCDIHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Guid DIHOLCNHIND;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x1227CC0", Offset = "0x1226EC0", VA = "0x181227CC0")]
	public MKHDGODFEOG(Guid DIHOLCNHIND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1227CB0", Offset = "0x1226EB0", VA = "0x181227CB0", Slot = "6")]
	public Guid KLJAHCEDMMF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8518C10", Offset = "0x8517E10", VA = "0x188518C10", Slot = "4")]
	public bool Equals(MKHDGODFEOG FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8518B70", Offset = "0x8517D70", VA = "0x188518B70", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5397140", Offset = "0x5396340", VA = "0x185397140", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8518C10", Offset = "0x8517E10", VA = "0x188518C10")]
	public static bool NDBPPCEOMJH(MKHDGODFEOG MHEJPNNFCGC, MKHDGODFEOG BGMAPCGDHFK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8518B40", Offset = "0x8517D40", VA = "0x188518B40")]
	public static bool EFJOOJHLAGB(MKHDGODFEOG MHEJPNNFCGC, MKHDGODFEOG BGMAPCGDHFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5396FD0", Offset = "0x53961D0", VA = "0x185396FD0", Slot = "5")]
	public int CompareTo(MKHDGODFEOG FNJGMJGALLH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8518C40", Offset = "0x8517E40", VA = "0x188518C40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1227CC0", Offset = "0x1226EC0", VA = "0x181227CC0")]
	public MKHDGODFEOG(DHHAOBCCFCA HMHMJJABGOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct FDOICMMGLJH : IEquatable<FDOICMMGLJH>, IComparable<FDOICMMGLJH>, FDEINOGEHIH
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly FDOICMMGLJH MLINAHCDIHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Guid DIHOLCNHIND;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1227CC0", Offset = "0x1226EC0", VA = "0x181227CC0")]
	public FDOICMMGLJH(Guid DIHOLCNHIND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1227CB0", Offset = "0x1226EB0", VA = "0x181227CB0", Slot = "6")]
	public Guid KLJAHCEDMMF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5397460", Offset = "0x5396660", VA = "0x185397460", Slot = "4")]
	public bool Equals(FDOICMMGLJH FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5396FD0", Offset = "0x53961D0", VA = "0x185396FD0", Slot = "5")]
	public int CompareTo(FDOICMMGLJH FNJGMJGALLH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x8518490", Offset = "0x8517690", VA = "0x188518490", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5397140", Offset = "0x5396340", VA = "0x185397140", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5397460", Offset = "0x5396660", VA = "0x185397460")]
	public static bool NDBPPCEOMJH(FDOICMMGLJH MHEJPNNFCGC, FDOICMMGLJH BGMAPCGDHFK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x8517AF0", Offset = "0x8516CF0", VA = "0x188517AF0")]
	public static bool EFJOOJHLAGB(FDOICMMGLJH MHEJPNNFCGC, FDOICMMGLJH BGMAPCGDHFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8518530", Offset = "0x8517730", VA = "0x188518530", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct FOJCDPOPCPL : IEquatable<FOJCDPOPCPL>, IComparable<FOJCDPOPCPL>, FDEINOGEHIH
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly FOJCDPOPCPL MLINAHCDIHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Guid DIHOLCNHIND;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1227CC0", Offset = "0x1226EC0", VA = "0x181227CC0")]
	public FOJCDPOPCPL(Guid DIHOLCNHIND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x1227CB0", Offset = "0x1226EB0", VA = "0x181227CB0", Slot = "6")]
	public Guid KLJAHCEDMMF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5397460", Offset = "0x5396660", VA = "0x185397460", Slot = "4")]
	public bool Equals(FOJCDPOPCPL FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5396FD0", Offset = "0x53961D0", VA = "0x185396FD0", Slot = "5")]
	public int CompareTo(FOJCDPOPCPL FNJGMJGALLH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x85185A0", Offset = "0x85177A0", VA = "0x1885185A0", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5397140", Offset = "0x5396340", VA = "0x185397140", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5397460", Offset = "0x5396660", VA = "0x185397460")]
	public static bool NDBPPCEOMJH(FOJCDPOPCPL MHEJPNNFCGC, FOJCDPOPCPL BGMAPCGDHFK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8517AF0", Offset = "0x8516CF0", VA = "0x188517AF0")]
	public static bool EFJOOJHLAGB(FOJCDPOPCPL MHEJPNNFCGC, FOJCDPOPCPL BGMAPCGDHFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8518640", Offset = "0x8517840", VA = "0x188518640", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct BBPDKPJNAIP : IEquatable<BBPDKPJNAIP>, IComparable<BBPDKPJNAIP>, FDEINOGEHIH
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly BBPDKPJNAIP MLINAHCDIHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Guid DIHOLCNHIND;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x1227CC0", Offset = "0x1226EC0", VA = "0x181227CC0")]
	public BBPDKPJNAIP(Guid DIHOLCNHIND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1227CB0", Offset = "0x1226EB0", VA = "0x181227CB0", Slot = "6")]
	public Guid KLJAHCEDMMF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5397460", Offset = "0x5396660", VA = "0x185397460", Slot = "4")]
	public bool Equals(BBPDKPJNAIP FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5396FD0", Offset = "0x53961D0", VA = "0x185396FD0", Slot = "5")]
	public int CompareTo(BBPDKPJNAIP FNJGMJGALLH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8517B20", Offset = "0x8516D20", VA = "0x188517B20", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5397140", Offset = "0x5396340", VA = "0x185397140", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5397460", Offset = "0x5396660", VA = "0x185397460")]
	public static bool NDBPPCEOMJH(BBPDKPJNAIP MHEJPNNFCGC, BBPDKPJNAIP BGMAPCGDHFK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x8517AF0", Offset = "0x8516CF0", VA = "0x188517AF0")]
	public static bool EFJOOJHLAGB(BBPDKPJNAIP MHEJPNNFCGC, BBPDKPJNAIP BGMAPCGDHFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x8517BC0", Offset = "0x8516DC0", VA = "0x188517BC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct GIGIBBKKLGE : IEquatable<GIGIBBKKLGE>, IComparable<GIGIBBKKLGE>, FDEINOGEHIH
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly GIGIBBKKLGE MLINAHCDIHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Guid DIHOLCNHIND;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x1227CC0", Offset = "0x1226EC0", VA = "0x181227CC0")]
	public GIGIBBKKLGE(Guid DIHOLCNHIND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x1227CB0", Offset = "0x1226EB0", VA = "0x181227CB0", Slot = "6")]
	public Guid KLJAHCEDMMF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5397460", Offset = "0x5396660", VA = "0x185397460", Slot = "4")]
	public bool Equals(GIGIBBKKLGE FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5396FD0", Offset = "0x53961D0", VA = "0x185396FD0", Slot = "5")]
	public int CompareTo(GIGIBBKKLGE FNJGMJGALLH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x85186B0", Offset = "0x85178B0", VA = "0x1885186B0", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5397140", Offset = "0x5396340", VA = "0x185397140", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5397460", Offset = "0x5396660", VA = "0x185397460")]
	public static bool NDBPPCEOMJH(GIGIBBKKLGE MHEJPNNFCGC, GIGIBBKKLGE BGMAPCGDHFK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x8517AF0", Offset = "0x8516CF0", VA = "0x188517AF0")]
	public static bool EFJOOJHLAGB(GIGIBBKKLGE MHEJPNNFCGC, GIGIBBKKLGE BGMAPCGDHFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x8518750", Offset = "0x8517950", VA = "0x188518750", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct DCEEHFLNMHP : IEquatable<DCEEHFLNMHP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly string?[]? EFFFFDNCANB;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool BFALGEPOBJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8517C30", Offset = "0x8516E30", VA = "0x188517C30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int GHCDGODOMIB
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x50451A0", Offset = "0x50443A0", VA = "0x1850451A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8518230", Offset = "0x8517430", VA = "0x188518230")]
	public DCEEHFLNMHP(string? EPCBIBNDHIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x85181B0", Offset = "0x85173B0", VA = "0x1885181B0")]
	public DCEEHFLNMHP(string?[] GFDOMBEAPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8517E90", Offset = "0x8517090", VA = "0x188517E90")]
	private static string?[]? IFJPNMKGDFP(string?[]? GFDOMBEAPIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x85180C0", Offset = "0x85172C0", VA = "0x1885180C0")]
	public string KPEDIOHHFOP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8517CE0", Offset = "0x8516EE0", VA = "0x188517CE0", Slot = "4")]
	public bool Equals(DCEEHFLNMHP FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8517C50", Offset = "0x8516E50", VA = "0x188517C50", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8517DB0", Offset = "0x8516FB0", VA = "0x188517DB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8518120", Offset = "0x8517320", VA = "0x188518120", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct DHHAOBCCFCA : IEquatable<DHHAOBCCFCA>, IComparable<DHHAOBCCFCA>, FDEINOGEHIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Guid DIHOLCNHIND;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x1227CC0", Offset = "0x1226EC0", VA = "0x181227CC0")]
	public DHHAOBCCFCA(Guid DIHOLCNHIND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x1227CB0", Offset = "0x1226EB0", VA = "0x181227CB0", Slot = "6")]
	public Guid KLJAHCEDMMF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5397460", Offset = "0x5396660", VA = "0x185397460", Slot = "4")]
	public bool Equals(DHHAOBCCFCA FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5396FD0", Offset = "0x53961D0", VA = "0x185396FD0", Slot = "5")]
	public int CompareTo(DHHAOBCCFCA FNJGMJGALLH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8518380", Offset = "0x8517580", VA = "0x188518380", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5397140", Offset = "0x5396340", VA = "0x185397140", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8518420", Offset = "0x8517620", VA = "0x188518420", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface NILCLPCBFCI<TModern> : AHMEIAFMAAE<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string DAFOLHGFINO(TModern HGAGGMCNOOK);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface FDEINOGEHIH
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Guid KLJAHCEDMMF();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface AHMEIAFMAAE<out TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TModern BNDNJGKOAHB(string HGAGGMCNOOK);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface FCFDCMAIFMA
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	NILCLPCBFCI<KAKAKJKDPIO> PLAEDDNMMCI
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	NILCLPCBFCI<FDOICMMGLJH> HLCOOOKHEAK
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	NILCLPCBFCI<GIGIBBKKLGE> PLGMPGNMLBF
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	NILCLPCBFCI<MKHDGODFEOG> JLEGMNAHIHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	NILCLPCBFCI<IKJJOJNJAPI> JIIMJLMHKDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	NILCLPCBFCI<BBPDKPJNAIP> EOOHAHAHLNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	NILCLPCBFCI<PAPGPDMJLIC> DLGAHHHBCPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	NILCLPCBFCI<FOJCDPOPCPL> FEAIJEPMAOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class LEDINOGMEAP
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static readonly char[] JOEBPPOHCGE;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8518A10", Offset = "0x8517C10", VA = "0x188518A10")]
	public static string[] MHHGIPKJIKB(string? EPCBIBNDHIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x85189E0", Offset = "0x8517BE0", VA = "0x1885189E0")]
	public static string? EDCOPNJHJJN(string? FCGPCABMNKH)
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
