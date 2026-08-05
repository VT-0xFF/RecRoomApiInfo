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
		[Cpp2IlInjected.Address(RVA = "0x8878E0", Offset = "0x885EE0", VA = "0x1808878E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x70B39C0", Offset = "0x70B1FC0", VA = "0x1870B39C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x888570", Offset = "0x886B70", VA = "0x180888570")]
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
		[Cpp2IlInjected.Address(RVA = "0x8885B0", Offset = "0x886BB0", VA = "0x1808885B0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface CEAAANGKCJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string ALGEABNCNAB(DFMKIAJNCLI NGALCNCLJMG);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DFMKIAJNCLI DIPBOAAMMJI(string NGALCNCLJMG);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct DFMKIAJNCLI : IEquatable<DFMKIAJNCLI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly CDMPNOCHBKH HELHCDKMKHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly NHDGGCIBEGO OIIICGIEALL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly Guid AHLFIOOHKKM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool OJOMLEDAFNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x70B2F00", Offset = "0x70B1500", VA = "0x1870B2F00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool PHHMNAEFBLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x70B2E90", Offset = "0x70B1490", VA = "0x1870B2E90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x70B3290", Offset = "0x70B1890", VA = "0x1870B3290")]
	public DFMKIAJNCLI(DFMKIAJNCLI HILENBCIBPE, [Optional] Guid KPIIDNLEAEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4D804D0", Offset = "0x4D7EAD0", VA = "0x184D804D0")]
	public DFMKIAJNCLI(CDMPNOCHBKH PHPAFJPIJDN, NHDGGCIBEGO PLAKDCIKCKK, [Optional] Guid KPIIDNLEAEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x70B2D40", Offset = "0x70B1340", VA = "0x1870B2D40", Slot = "4")]
	public bool Equals(DFMKIAJNCLI OGEIJLCLBIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x70B2C90", Offset = "0x70B1290", VA = "0x1870B2C90", Slot = "0")]
	public override bool Equals(object CDBNFNMIHPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x70B2E00", Offset = "0x70B1400", VA = "0x1870B2E00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x70B2ED0", Offset = "0x70B14D0", VA = "0x1870B2ED0")]
	public static bool MLHBCNDBLOI(DFMKIAJNCLI GKFLJIIICHM, DFMKIAJNCLI GCLENKIGLBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x70B2F90", Offset = "0x70B1590", VA = "0x1870B2F90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct CDMPNOCHBKH : IEquatable<CDMPNOCHBKH>, IComparable<CDMPNOCHBKH>, DPDJOGKPPAG
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly CDMPNOCHBKH IJMGMBPJJCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Guid DHEKBCJKGBC;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xAC7B30", Offset = "0xAC6130", VA = "0x180AC7B30")]
	public CDMPNOCHBKH(Guid DHEKBCJKGBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0xAC7A80", Offset = "0xAC6080", VA = "0x180AC7A80", Slot = "6")]
	public Guid JHOEONAIKKL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5861E40", Offset = "0x5860440", VA = "0x185861E40", Slot = "4")]
	public bool Equals(CDMPNOCHBKH OGEIJLCLBIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5861E10", Offset = "0x5860410", VA = "0x185861E10", Slot = "5")]
	public int CompareTo(CDMPNOCHBKH OGEIJLCLBIC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x70B2A70", Offset = "0x70B1070", VA = "0x1870B2A70", Slot = "0")]
	public override bool Equals(object CDBNFNMIHPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5861E70", Offset = "0x5860470", VA = "0x185861E70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5861E40", Offset = "0x5860440", VA = "0x185861E40")]
	public static bool MLHBCNDBLOI(CDMPNOCHBKH GKFLJIIICHM, CDMPNOCHBKH GCLENKIGLBM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x70B29D0", Offset = "0x70B0FD0", VA = "0x1870B29D0")]
	public static bool LOCHGFJDMHC(CDMPNOCHBKH GKFLJIIICHM, CDMPNOCHBKH GCLENKIGLBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x70B2B10", Offset = "0x70B1110", VA = "0x1870B2B10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct OGGKFBHPMHE : IEquatable<OGGKFBHPMHE>, IComparable<OGGKFBHPMHE>, DPDJOGKPPAG
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static readonly OGGKFBHPMHE IJMGMBPJJCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Guid DHEKBCJKGBC;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0xAC7B30", Offset = "0xAC6130", VA = "0x180AC7B30")]
	public OGGKFBHPMHE(Guid DHEKBCJKGBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xAC7A80", Offset = "0xAC6080", VA = "0x180AC7A80", Slot = "6")]
	public Guid JHOEONAIKKL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5861E40", Offset = "0x5860440", VA = "0x185861E40", Slot = "4")]
	public bool Equals(OGGKFBHPMHE OGEIJLCLBIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5861E10", Offset = "0x5860410", VA = "0x185861E10", Slot = "5")]
	public int CompareTo(OGGKFBHPMHE OGEIJLCLBIC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x70B3A40", Offset = "0x70B2040", VA = "0x1870B3A40", Slot = "0")]
	public override bool Equals(object CDBNFNMIHPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5861E70", Offset = "0x5860470", VA = "0x185861E70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5861E40", Offset = "0x5860440", VA = "0x185861E40")]
	public static bool MLHBCNDBLOI(OGGKFBHPMHE GKFLJIIICHM, OGGKFBHPMHE GCLENKIGLBM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x70B29D0", Offset = "0x70B0FD0", VA = "0x1870B29D0")]
	public static bool LOCHGFJDMHC(OGGKFBHPMHE GKFLJIIICHM, OGGKFBHPMHE GCLENKIGLBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x70B3AE0", Offset = "0x70B20E0", VA = "0x1870B3AE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct GCJCGHEDGPM : IEquatable<GCJCGHEDGPM>, IComparable<GCJCGHEDGPM>, DPDJOGKPPAG
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public static readonly GCJCGHEDGPM IJMGMBPJJCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Guid DHEKBCJKGBC;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0xAC7B30", Offset = "0xAC6130", VA = "0x180AC7B30")]
	public GCJCGHEDGPM(Guid DHEKBCJKGBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0xAC7A80", Offset = "0xAC6080", VA = "0x180AC7A80", Slot = "6")]
	public Guid JHOEONAIKKL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5861E40", Offset = "0x5860440", VA = "0x185861E40", Slot = "4")]
	public bool Equals(GCJCGHEDGPM OGEIJLCLBIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5861E10", Offset = "0x5860410", VA = "0x185861E10", Slot = "5")]
	public int CompareTo(GCJCGHEDGPM OGEIJLCLBIC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x70B33C0", Offset = "0x70B19C0", VA = "0x1870B33C0", Slot = "0")]
	public override bool Equals(object CDBNFNMIHPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5861E70", Offset = "0x5860470", VA = "0x185861E70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5861E40", Offset = "0x5860440", VA = "0x185861E40")]
	public static bool MLHBCNDBLOI(GCJCGHEDGPM GKFLJIIICHM, GCJCGHEDGPM GCLENKIGLBM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x70B29D0", Offset = "0x70B0FD0", VA = "0x1870B29D0")]
	public static bool LOCHGFJDMHC(GCJCGHEDGPM GKFLJIIICHM, GCJCGHEDGPM GCLENKIGLBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x70B3460", Offset = "0x70B1A60", VA = "0x1870B3460", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct NHDGGCIBEGO : IEquatable<NHDGGCIBEGO>, IComparable<NHDGGCIBEGO>, DPDJOGKPPAG
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly NHDGGCIBEGO IJMGMBPJJCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Guid DHEKBCJKGBC;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xAC7B30", Offset = "0xAC6130", VA = "0x180AC7B30")]
	public NHDGGCIBEGO(Guid DHEKBCJKGBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0xAC7A80", Offset = "0xAC6080", VA = "0x180AC7A80", Slot = "6")]
	public Guid JHOEONAIKKL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x70B37E0", Offset = "0x70B1DE0", VA = "0x1870B37E0", Slot = "4")]
	public bool Equals(NHDGGCIBEGO OGEIJLCLBIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x70B3740", Offset = "0x70B1D40", VA = "0x1870B3740", Slot = "0")]
	public override bool Equals(object CDBNFNMIHPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5861E70", Offset = "0x5860470", VA = "0x185861E70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x70B37E0", Offset = "0x70B1DE0", VA = "0x1870B37E0")]
	public static bool MLHBCNDBLOI(NHDGGCIBEGO GKFLJIIICHM, NHDGGCIBEGO GCLENKIGLBM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x70B3810", Offset = "0x70B1E10", VA = "0x1870B3810")]
	public static bool LOCHGFJDMHC(NHDGGCIBEGO GKFLJIIICHM, NHDGGCIBEGO GCLENKIGLBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5861E10", Offset = "0x5860410", VA = "0x185861E10", Slot = "5")]
	public int CompareTo(NHDGGCIBEGO OGEIJLCLBIC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x70B3840", Offset = "0x70B1E40", VA = "0x1870B3840", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0xAC7B30", Offset = "0xAC6130", VA = "0x180AC7B30")]
	public NHDGGCIBEGO(NIAOHDCALJL BOGHGPFGAJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct BJCALNENODB : IEquatable<BJCALNENODB>, IComparable<BJCALNENODB>, DPDJOGKPPAG
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly BJCALNENODB IJMGMBPJJCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Guid DHEKBCJKGBC;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0xAC7B30", Offset = "0xAC6130", VA = "0x180AC7B30")]
	public BJCALNENODB(Guid DHEKBCJKGBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0xAC7A80", Offset = "0xAC6080", VA = "0x180AC7A80", Slot = "6")]
	public Guid JHOEONAIKKL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5861E40", Offset = "0x5860440", VA = "0x185861E40", Slot = "4")]
	public bool Equals(BJCALNENODB OGEIJLCLBIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5861E10", Offset = "0x5860410", VA = "0x185861E10", Slot = "5")]
	public int CompareTo(BJCALNENODB OGEIJLCLBIC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x70B2930", Offset = "0x70B0F30", VA = "0x1870B2930", Slot = "0")]
	public override bool Equals(object CDBNFNMIHPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5861E70", Offset = "0x5860470", VA = "0x185861E70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5861E40", Offset = "0x5860440", VA = "0x185861E40")]
	public static bool MLHBCNDBLOI(BJCALNENODB GKFLJIIICHM, BJCALNENODB GCLENKIGLBM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x70B29D0", Offset = "0x70B0FD0", VA = "0x1870B29D0")]
	public static bool LOCHGFJDMHC(BJCALNENODB GKFLJIIICHM, BJCALNENODB GCLENKIGLBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x70B2A00", Offset = "0x70B1000", VA = "0x1870B2A00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct CIFJPJIKLJC : IEquatable<CIFJPJIKLJC>, IComparable<CIFJPJIKLJC>, DPDJOGKPPAG
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly CIFJPJIKLJC IJMGMBPJJCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Guid DHEKBCJKGBC;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0xAC7B30", Offset = "0xAC6130", VA = "0x180AC7B30")]
	public CIFJPJIKLJC(Guid DHEKBCJKGBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xAC7A80", Offset = "0xAC6080", VA = "0x180AC7A80", Slot = "6")]
	public Guid JHOEONAIKKL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5861E40", Offset = "0x5860440", VA = "0x185861E40", Slot = "4")]
	public bool Equals(CIFJPJIKLJC OGEIJLCLBIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5861E10", Offset = "0x5860410", VA = "0x185861E10", Slot = "5")]
	public int CompareTo(CIFJPJIKLJC OGEIJLCLBIC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x70B2B80", Offset = "0x70B1180", VA = "0x1870B2B80", Slot = "0")]
	public override bool Equals(object CDBNFNMIHPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5861E70", Offset = "0x5860470", VA = "0x185861E70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5861E40", Offset = "0x5860440", VA = "0x185861E40")]
	public static bool MLHBCNDBLOI(CIFJPJIKLJC GKFLJIIICHM, CIFJPJIKLJC GCLENKIGLBM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x70B29D0", Offset = "0x70B0FD0", VA = "0x1870B29D0")]
	public static bool LOCHGFJDMHC(CIFJPJIKLJC GKFLJIIICHM, CIFJPJIKLJC GCLENKIGLBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x70B2C20", Offset = "0x70B1220", VA = "0x1870B2C20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct GHJNEJAMJEH : IEquatable<GHJNEJAMJEH>, IComparable<GHJNEJAMJEH>, DPDJOGKPPAG
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly GHJNEJAMJEH IJMGMBPJJCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Guid DHEKBCJKGBC;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0xAC7B30", Offset = "0xAC6130", VA = "0x180AC7B30")]
	public GHJNEJAMJEH(Guid DHEKBCJKGBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0xAC7A80", Offset = "0xAC6080", VA = "0x180AC7A80", Slot = "6")]
	public Guid JHOEONAIKKL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5861E40", Offset = "0x5860440", VA = "0x185861E40", Slot = "4")]
	public bool Equals(GHJNEJAMJEH OGEIJLCLBIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5861E10", Offset = "0x5860410", VA = "0x185861E10", Slot = "5")]
	public int CompareTo(GHJNEJAMJEH OGEIJLCLBIC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x70B34D0", Offset = "0x70B1AD0", VA = "0x1870B34D0", Slot = "0")]
	public override bool Equals(object CDBNFNMIHPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5861E70", Offset = "0x5860470", VA = "0x185861E70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5861E40", Offset = "0x5860440", VA = "0x185861E40")]
	public static bool MLHBCNDBLOI(GHJNEJAMJEH GKFLJIIICHM, GHJNEJAMJEH GCLENKIGLBM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x70B29D0", Offset = "0x70B0FD0", VA = "0x1870B29D0")]
	public static bool LOCHGFJDMHC(GHJNEJAMJEH GKFLJIIICHM, GHJNEJAMJEH GCLENKIGLBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x70B3570", Offset = "0x70B1B70", VA = "0x1870B3570", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct FPELILCNBPE : IEquatable<FPELILCNBPE>, IComparable<FPELILCNBPE>, DPDJOGKPPAG
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly FPELILCNBPE IJMGMBPJJCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Guid DHEKBCJKGBC;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xAC7B30", Offset = "0xAC6130", VA = "0x180AC7B30")]
	public FPELILCNBPE(Guid DHEKBCJKGBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0xAC7A80", Offset = "0xAC6080", VA = "0x180AC7A80", Slot = "6")]
	public Guid JHOEONAIKKL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5861E40", Offset = "0x5860440", VA = "0x185861E40", Slot = "4")]
	public bool Equals(FPELILCNBPE OGEIJLCLBIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5861E10", Offset = "0x5860410", VA = "0x185861E10", Slot = "5")]
	public int CompareTo(FPELILCNBPE OGEIJLCLBIC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x70B32B0", Offset = "0x70B18B0", VA = "0x1870B32B0", Slot = "0")]
	public override bool Equals(object CDBNFNMIHPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5861E70", Offset = "0x5860470", VA = "0x185861E70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5861E40", Offset = "0x5860440", VA = "0x185861E40")]
	public static bool MLHBCNDBLOI(FPELILCNBPE GKFLJIIICHM, FPELILCNBPE GCLENKIGLBM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x70B29D0", Offset = "0x70B0FD0", VA = "0x1870B29D0")]
	public static bool LOCHGFJDMHC(FPELILCNBPE GKFLJIIICHM, FPELILCNBPE GCLENKIGLBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x70B3350", Offset = "0x70B1950", VA = "0x1870B3350", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct PDKNDOAIJGM : IEquatable<PDKNDOAIJGM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly string?[]? PIJACKAFGFM;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool BNJOFFCHEKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x70B4020", Offset = "0x70B2620", VA = "0x1870B4020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int NGCACLGEPGF
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x40914B0", Offset = "0x408FAB0", VA = "0x1840914B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x70B40D0", Offset = "0x70B26D0", VA = "0x1870B40D0")]
	public PDKNDOAIJGM(string? MMFCCCJFJDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x70B4220", Offset = "0x70B2820", VA = "0x1870B4220")]
	public PDKNDOAIJGM(string?[] MEMOKDJFEBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x70B3DF0", Offset = "0x70B23F0", VA = "0x1870B3DF0")]
	private static string?[]? KNCCEGELHLC(string?[]? MEMOKDJFEBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x70B3D90", Offset = "0x70B2390", VA = "0x1870B3D90")]
	public string JGCBEOJABAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x70B3BE0", Offset = "0x70B21E0", VA = "0x1870B3BE0", Slot = "4")]
	public bool Equals(PDKNDOAIJGM OGEIJLCLBIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x70B3B50", Offset = "0x70B2150", VA = "0x1870B3B50", Slot = "0")]
	public override bool Equals(object CDBNFNMIHPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x70B3CB0", Offset = "0x70B22B0", VA = "0x1870B3CB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x70B4040", Offset = "0x70B2640", VA = "0x1870B4040", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct NIAOHDCALJL : IEquatable<NIAOHDCALJL>, IComparable<NIAOHDCALJL>, DPDJOGKPPAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Guid DHEKBCJKGBC;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0xAC7B30", Offset = "0xAC6130", VA = "0x180AC7B30")]
	public NIAOHDCALJL(Guid DHEKBCJKGBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xAC7A80", Offset = "0xAC6080", VA = "0x180AC7A80", Slot = "6")]
	public Guid JHOEONAIKKL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5861E40", Offset = "0x5860440", VA = "0x185861E40", Slot = "4")]
	public bool Equals(NIAOHDCALJL OGEIJLCLBIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5861E10", Offset = "0x5860410", VA = "0x185861E10", Slot = "5")]
	public int CompareTo(NIAOHDCALJL OGEIJLCLBIC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x70B38B0", Offset = "0x70B1EB0", VA = "0x1870B38B0", Slot = "0")]
	public override bool Equals(object CDBNFNMIHPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5861E70", Offset = "0x5860470", VA = "0x185861E70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x70B3950", Offset = "0x70B1F50", VA = "0x1870B3950", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface JHBIJAIELGJ<TModern> : KNEPGJJBCKC<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string LNPBOIDFKGE(TModern KCDEJHMGGGC);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface DPDJOGKPPAG
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Guid JHOEONAIKKL();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface KNEPGJJBCKC<out TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TModern GOGMIPMHNCN(string KCDEJHMGGGC);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface DFCDEDIBLNN
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	JHBIJAIELGJ<CDMPNOCHBKH> OKIPKFBHKFK
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	JHBIJAIELGJ<BJCALNENODB> FDJEGCNKEPK
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	JHBIJAIELGJ<FPELILCNBPE> JBKPGGCBMNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	JHBIJAIELGJ<NHDGGCIBEGO> NCFLMAFOIEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	JHBIJAIELGJ<GCJCGHEDGPM> GHAEHKGHJIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	JHBIJAIELGJ<GHJNEJAMJEH> CNKDCJGOOJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	JHBIJAIELGJ<OGGKFBHPMHE> GDEMOAOPLOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	JHBIJAIELGJ<CIFJPJIKLJC> DMPPHJGJDFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class MDMMDBGAJOF
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static readonly char[] GLHFOJIJMLM;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x70B35E0", Offset = "0x70B1BE0", VA = "0x1870B35E0")]
	public static string[] BCGJPIMOIFE(string? MMFCCCJFJDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x70B3680", Offset = "0x70B1C80", VA = "0x1870B3680")]
	public static string? KJDDENJKHEJ(string? PHPAFJPIJDN)
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
