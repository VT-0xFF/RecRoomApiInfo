using System;
using System.Collections;
using System.Collections.Generic;
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
		[Cpp2IlInjected.Address(RVA = "0x7C7B20", Offset = "0x7C6F20", VA = "0x1807C7B20")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x1D61660", Offset = "0x1D60A60", VA = "0x181D61660")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7C8560", Offset = "0x7C7960", VA = "0x1807C8560")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C85A0", Offset = "0x7C79A0", VA = "0x1807C85A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct AGIEMGGIEJL<TMInput, TMOutput, TMNode> : IEnumerator<JLGMECJOLDI<TMNode>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private OAJAJPKGJPE<TMInput, TMOutput, TMNode> PCLPHJMDHCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private GHBOKBIPOAB<TMInput, TMOutput, TMNode> PGLIAFIACNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private bool OHPEOAEAAEG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public readonly JLGMECJOLDI<TMNode> FPOHGHGPMEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3636400", Offset = "0x3635800", VA = "0x183636400", Slot = "4")]
		get
		{
			return default(JLGMECJOLDI<TMNode>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x36362A0", Offset = "0x36356A0", VA = "0x1836362A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3636330", Offset = "0x3635730", VA = "0x183636330")]
	internal AGIEMGGIEJL([In] OAJAJPKGJPE<TMInput, TMOutput, TMNode> BBFFMANAHMH, [In] GHBOKBIPOAB<TMInput, TMOutput, TMNode> IFIAKHLIKJG, bool ENEKCMJJPCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3636160", Offset = "0x3635560", VA = "0x183636160", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3636220", Offset = "0x3635620", VA = "0x183636220", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x36360E0", Offset = "0x36354E0", VA = "0x1836360E0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class ICJCIKIGMFL
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x26593C0", Offset = "0x26587C0", VA = "0x1826593C0")]
	public static AGIEMGGIEJL<TMInput, TMOutput, TMNode> JKJFENIAMEL<TMInput, TMOutput, TMNode>([In] DMBPIPAOACD<TMInput, TMOutput, TMNode> KFJHNIEDCLG, JLGMECJOLDI<TMNode> KOOMGHGCPCM)
	{
		return default(AGIEMGGIEJL<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct GHBOKBIPOAB<TMInput, TMOutput, TMNode> : IEnumerator<JLGMECJOLDI<TMInput>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private FHOAFJPGJCO<JLGMECJOLDI<TMOutput>>.NEMNPNIGEFJ BAKONLCODAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private FHOAFJPGJCO<JLGMECJOLDI<TMInput>>.NEMNPNIGEFJ EAICEKHHJDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly CPBIINFKLNL<TMInput, TMOutput, TMNode> JLABDEACJAC;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public JLGMECJOLDI<TMInput> FPOHGHGPMEE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3692950", Offset = "0x3691D50", VA = "0x183692950", Slot = "4")]
		get
		{
			return default(JLGMECJOLDI<TMInput>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3692820", Offset = "0x3691C20", VA = "0x183692820", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x36928D0", Offset = "0x3691CD0", VA = "0x1836928D0")]
	internal GHBOKBIPOAB([In] FHOAFJPGJCO<JLGMECJOLDI<TMOutput>>.NEMNPNIGEFJ MNECMJNPCBH, [In] FHOAFJPGJCO<JLGMECJOLDI<TMInput>>.NEMNPNIGEFJ AIJAJGKOBGG, [In] CPBIINFKLNL<TMInput, TMOutput, TMNode> FFNCDJBPKGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3692650", Offset = "0x3691A50", VA = "0x183692650", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x36927B0", Offset = "0x3691BB0", VA = "0x1836927B0", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x36925E0", Offset = "0x36919E0", VA = "0x1836925E0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class OHCALKGFPIE
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2786550", Offset = "0x2785950", VA = "0x182786550")]
	public static GHBOKBIPOAB<TMInput, TMOutput, TMNode> JKJFENIAMEL<TMInput, TMOutput, TMNode>([In] DMBPIPAOACD<TMInput, TMOutput, TMNode> KFJHNIEDCLG, JLGMECJOLDI<TMNode> KOOMGHGCPCM)
	{
		return default(GHBOKBIPOAB<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct OAJAJPKGJPE<TMInput, TMOutput, TMNode> : IEnumerator<JLGMECJOLDI<TMOutput>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private FHOAFJPGJCO<JLGMECJOLDI<TMInput>>.NEMNPNIGEFJ HPGAMDAIMME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private FHOAFJPGJCO<JLGMECJOLDI<TMOutput>>.NEMNPNIGEFJ LBNLHMODJHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly PJHKAJOGCCE<TMInput, TMOutput, TMNode> LJGHFABDIPI;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public JLGMECJOLDI<TMOutput> FPOHGHGPMEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3692950", Offset = "0x3691D50", VA = "0x183692950", Slot = "4")]
		get
		{
			return default(JLGMECJOLDI<TMOutput>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3692820", Offset = "0x3691C20", VA = "0x183692820", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x36928D0", Offset = "0x3691CD0", VA = "0x1836928D0")]
	internal OAJAJPKGJPE([In] FHOAFJPGJCO<JLGMECJOLDI<TMInput>>.NEMNPNIGEFJ JDBJLLIAJCM, [In] FHOAFJPGJCO<JLGMECJOLDI<TMOutput>>.NEMNPNIGEFJ AAKJMMIAIGF, [In] PJHKAJOGCCE<TMInput, TMOutput, TMNode> DEIKIDPPMCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3692650", Offset = "0x3691A50", VA = "0x183692650", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x36927B0", Offset = "0x3691BB0", VA = "0x1836927B0", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x36925E0", Offset = "0x36919E0", VA = "0x1836925E0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class DDOCBLCKDPK
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x24E4520", Offset = "0x24E3920", VA = "0x1824E4520")]
	public static OAJAJPKGJPE<TMInput, TMOutput, TMNode> JKJFENIAMEL<TMInput, TMOutput, TMNode>([In] DMBPIPAOACD<TMInput, TMOutput, TMNode> KFJHNIEDCLG, JLGMECJOLDI<TMNode> KOOMGHGCPCM)
	{
		return default(OAJAJPKGJPE<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct DMBPIPAOACD<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public PJHKAJOGCCE<TMInput, TMOutput, TMNode> NNIPPIPAOAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public CPBIINFKLNL<TMInput, TMOutput, TMNode> HFNDEPPAKNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public MHEAHEFMOFO<TMInput, TMOutput, TMNode> LLNGHMKIGJM;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4EB5740", Offset = "0x4EB4B40", VA = "0x184EB5740")]
	internal DMBPIPAOACD([In] PJHKAJOGCCE<TMInput, TMOutput, TMNode> DEIKIDPPMCI, [In] CPBIINFKLNL<TMInput, TMOutput, TMNode> FFNCDJBPKGH, [In] MHEAHEFMOFO<TMInput, TMOutput, TMNode> LOLIJNBFKGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4EB5490", Offset = "0x4EB4890", VA = "0x184EB5490")]
	public static DMBPIPAOACD<TMInput?, TMOutput?, TMNode?> JKJFENIAMEL()
	{
		return default(DMBPIPAOACD<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class AJADGGMPDNC
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2C090D0", Offset = "0x2C084D0", VA = "0x182C090D0")]
	public static GMOJHAEDALM? LENOCDGJGPN<TMInput, TMOutput, TMNode>([In] this DMBPIPAOACD<TMInput, TMOutput, TMNode> NHHBAHIFHJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2C08380", Offset = "0x2C07780", VA = "0x182C08380")]
	public static DMBPIPAOACD<TMInput?, TMOutput?, TMNode?> AFFCBAMFOKP<TMInput, TMOutput, TMNode>(this GMOJHAEDALM NHHBAHIFHJK)
	{
		return default(DMBPIPAOACD<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2C093C0", Offset = "0x2C087C0", VA = "0x182C093C0")]
	public static void NNIMNMJHJOG<TMInput, TMOutput, TMNode>(this DMBPIPAOACD<TMInput, TMOutput, TMNode> NHHBAHIFHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2C09070", Offset = "0x2C08470", VA = "0x182C09070")]
	public static void IDGNGOIABKB<TMInput, TMOutput, TMNode>(this DMBPIPAOACD<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMOutput> HKFAHDNCKFJ, JLGMECJOLDI<TMInput> FBFNOEBCCEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2C09010", Offset = "0x2C08410", VA = "0x182C09010")]
	public static void HDBOGCHBNGP<TMInput, TMOutput, TMNode>(this DMBPIPAOACD<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMOutput> HKFAHDNCKFJ, JLGMECJOLDI<TMInput> FBFNOEBCCEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2C08920", Offset = "0x2C07D20", VA = "0x182C08920")]
	public static bool DJDHGADCKKP<TMInput, TMOutput, TMNode>([In] this DMBPIPAOACD<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMOutput> HKFAHDNCKFJ, JLGMECJOLDI<TMInput> FBFNOEBCCEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2C08C30", Offset = "0x2C08030", VA = "0x182C08C30")]
	public static JLGMECJOLDI<TMNode?> ELMEHOANCIO<TMNode, TMInput, TMOutput>(this DMBPIPAOACD<TMInput, TMOutput, TMNode> NHHBAHIFHJK)
	{
		return default(JLGMECJOLDI<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2C08E20", Offset = "0x2C08220", VA = "0x182C08E20")]
	public static void GGOKBCCMLKP<TMInput, TMOutput, TMNode>(this DMBPIPAOACD<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMNode> KOOMGHGCPCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2C088A0", Offset = "0x2C07CA0", VA = "0x182C088A0")]
	public static JLGMECJOLDI<TMInput?> CGIHODMKHGP<TMInput, TMOutput, TMNode>(this DMBPIPAOACD<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMNode> KOOMGHGCPCM)
	{
		return default(JLGMECJOLDI<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2C08FA0", Offset = "0x2C083A0", VA = "0x182C08FA0")]
	public static JLGMECJOLDI<TMOutput?> HCFCFNAMNDI<TMOutput, TMInput, TMNode>(this DMBPIPAOACD<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMNode> KOOMGHGCPCM)
	{
		return default(JLGMECJOLDI<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2C08CC0", Offset = "0x2C080C0", VA = "0x182C08CC0")]
	public static JLGMECJOLDI<TMInput?> FEDICMOFOPA<TMInput, TMOutput, TMNode>(this DMBPIPAOACD<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMNode> KOOMGHGCPCM, int OJANCMLFDOJ)
	{
		return default(JLGMECJOLDI<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2C091B0", Offset = "0x2C085B0", VA = "0x182C091B0")]
	public static JLGMECJOLDI<TMOutput?> LKHKNMILGPA<TMOutput, TMInput, TMNode>(this DMBPIPAOACD<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMNode> KOOMGHGCPCM, int OJANCMLFDOJ)
	{
		return default(JLGMECJOLDI<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2C086F0", Offset = "0x2C07AF0", VA = "0x182C086F0")]
	public static void BPALLDEDLPN<TMInput, TMOutput, TMNode>(this DMBPIPAOACD<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMNode> KOOMGHGCPCM, int GECJLINKOGO, int BCIDMCPDBJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2C09320", Offset = "0x2C08720", VA = "0x182C09320")]
	public static void MKAKCGIEFFH<TMInput, TMOutput, TMNode>(this DMBPIPAOACD<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMNode> KOOMGHGCPCM, int GECJLINKOGO, int BCIDMCPDBJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2C09230", Offset = "0x2C08630", VA = "0x182C09230")]
	public static void MCLPLNPFPPP<TMInput, TMOutput, TMNode>(this DMBPIPAOACD<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMInput> FIPNEPOHCEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2C08D40", Offset = "0x2C08140", VA = "0x182C08D40")]
	public static void GGAKEBAHIEF<TMInput, TMOutput, TMNode>(this DMBPIPAOACD<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMOutput> FLOGJHFICGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x86D430", Offset = "0x86C830", VA = "0x18086D430")]
	public static KLAHACLPKMA<TMInput?> CLIJGPJHJFE<TMInput, TMOutput, TMNode>([In] this DMBPIPAOACD<TMInput, TMOutput, TMNode> NHHBAHIFHJK)
	{
		return default(KLAHACLPKMA<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2C08910", Offset = "0x2C07D10", VA = "0x182C08910")]
	public static KLAHACLPKMA<TMOutput?> DCILCOPKEAK<TMOutput, TMInput, TMNode>([In] this DMBPIPAOACD<TMInput, TMOutput, TMNode> NHHBAHIFHJK)
	{
		return default(KLAHACLPKMA<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2C09420", Offset = "0x2C08820", VA = "0x182C09420")]
	public static KLAHACLPKMA<TMNode?> OHGHJFLBBNM<TMNode, TMInput, TMOutput>([In] this DMBPIPAOACD<TMInput, TMOutput, TMNode> NHHBAHIFHJK)
	{
		return default(KLAHACLPKMA<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2C08F30", Offset = "0x2C08330", VA = "0x182C08F30")]
	public static GHBOKBIPOAB<TMInput?, TMOutput?, TMNode?> GNEIGECLMDL<TMInput, TMOutput, TMNode>([In] this DMBPIPAOACD<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMNode> PDDHPPHOJPD)
	{
		return default(GHBOKBIPOAB<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2C08F30", Offset = "0x2C08330", VA = "0x182C08F30")]
	public static OAJAJPKGJPE<TMInput?, TMOutput?, TMNode?> LKIAOFJHJHL<TMInput, TMOutput, TMNode>([In] this DMBPIPAOACD<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMNode> PDDHPPHOJPD)
	{
		return default(OAJAJPKGJPE<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2C08B80", Offset = "0x2C07F80", VA = "0x182C08B80")]
	public static AGIEMGGIEJL<TMInput?, TMOutput?, TMNode?> DOLIAJBDPGF<TMInput, TMOutput, TMNode>([In] this DMBPIPAOACD<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMNode> PDDHPPHOJPD)
	{
		return default(AGIEMGGIEJL<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2C08790", Offset = "0x2C07B90", VA = "0x182C08790")]
	public static LNLBHKJAOAK<JLGMECJOLDI<TMInput?>, GHBOKBIPOAB<TMInput?, TMOutput?, TMNode?>> CABNIILDFII<TMInput, TMOutput, TMNode>([In] this DMBPIPAOACD<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMNode> PDDHPPHOJPD)
	{
		return default(LNLBHKJAOAK<JLGMECJOLDI<TMInput>, GHBOKBIPOAB<TMInput, TMOutput, TMNode>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2C089F0", Offset = "0x2C07DF0", VA = "0x182C089F0")]
	public static LNLBHKJAOAK<JLGMECJOLDI<TMNode?>, AGIEMGGIEJL<TMInput?, TMOutput?, TMNode?>> DJIAJGMMGOM<TMNode, TMInput, TMOutput>([In] this DMBPIPAOACD<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMNode> PDDHPPHOJPD)
	{
		return default(LNLBHKJAOAK<JLGMECJOLDI<TMNode>, AGIEMGGIEJL<TMInput, TMOutput, TMNode>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct PJHKAJOGCCE<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal KLAHACLPKMA<TMInput> BPFIAGCJGLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	internal LBFBFNIPGIA<TMInput, JLGMECJOLDI<TMNode>> KAALKKIOJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal LBFBFNIPGIA<TMInput, FHOAFJPGJCO<JLGMECJOLDI<TMOutput>>> JLABDEACJAC;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x36F1D90", Offset = "0x36F1190", VA = "0x1836F1D90")]
	internal PJHKAJOGCCE([In] KLAHACLPKMA<TMInput> OMNLBBGKGGE, [In] LBFBFNIPGIA<TMInput, JLGMECJOLDI<TMNode>> LOLIJNBFKGL, [In] LBFBFNIPGIA<TMInput, FHOAFJPGJCO<JLGMECJOLDI<TMOutput>>> FFNCDJBPKGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x36F1B20", Offset = "0x36F0F20", VA = "0x1836F1B20")]
	internal static PJHKAJOGCCE<TMInput, TMOutput, TMNode> JKJFENIAMEL()
	{
		return default(PJHKAJOGCCE<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class GCDHCDHHDFM
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x261D3B0", Offset = "0x261C7B0", VA = "0x18261D3B0")]
	internal static BKPOPNLHNBM LENOCDGJGPN<TMInput, TMOutput, TMNode>([In] this PJHKAJOGCCE<TMInput, TMOutput, TMNode> NHHBAHIFHJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x261C910", Offset = "0x261BD10", VA = "0x18261C910")]
	internal static PJHKAJOGCCE<TMInput, TMOutput, TMNode> AFFCBAMFOKP<TMInput, TMOutput, TMNode>(this BKPOPNLHNBM NHHBAHIFHJK)
	{
		return default(PJHKAJOGCCE<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x261CE20", Offset = "0x261C220", VA = "0x18261CE20")]
	private static DPMFMFIIBOD AODPGGDNLAH<TMOutput>([In] this FHOAFJPGJCO<JLGMECJOLDI<TMOutput>> NHHBAHIFHJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x261D0F0", Offset = "0x261C4F0", VA = "0x18261D0F0")]
	private static FHOAFJPGJCO<JLGMECJOLDI<TMOutput>> GAMHGCBIPPP<TMOutput>(this DPMFMFIIBOD NHHBAHIFHJK)
	{
		return default(FHOAFJPGJCO<JLGMECJOLDI<TMOutput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x261D780", Offset = "0x261CB80", VA = "0x18261D780")]
	internal static void NNIMNMJHJOG<TMInput, TMOutput, TMNode>(this PJHKAJOGCCE<TMInput, TMOutput, TMNode> NHHBAHIFHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x261D910", Offset = "0x261CD10", VA = "0x18261D910")]
	internal static JLGMECJOLDI<TMInput> PELGDLFAPCE<TMInput, TMOutput, TMNode>(this PJHKAJOGCCE<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMNode> JACJPEOECBN)
	{
		return default(JLGMECJOLDI<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x261D010", Offset = "0x261C410", VA = "0x18261D010")]
	internal static void FLLAKBFBGHI<TMInput, TMOutput, TMNode>(this PJHKAJOGCCE<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMInput> PDDHPPHOJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2507FF0", Offset = "0x25073F0", VA = "0x182507FF0")]
	public static bool EHGNOLKCNDM<TMInput, TMOutput, TMNode>([In] this PJHKAJOGCCE<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMInput> PDDHPPHOJPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x221CE20", Offset = "0x221C220", VA = "0x18221CE20")]
	public static int PJKAGMCAGEO<TMInput, TMOutput, TMNode>([In] this PJHKAJOGCCE<TMInput, TMOutput, TMNode> NHHBAHIFHJK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x261CFF0", Offset = "0x261C3F0", VA = "0x18261CFF0")]
	public static JLGMECJOLDI<TMNode> CJDOPPMMLEH<TMNode, TMInput, TMOutput>([In] this PJHKAJOGCCE<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMInput> PDDHPPHOJPD)
	{
		return default(JLGMECJOLDI<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x261D740", Offset = "0x261CB40", VA = "0x18261D740")]
	public static int NAPILMLPFOJ<TMInput, TMOutput, TMNode>([In] this PJHKAJOGCCE<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMInput> PDDHPPHOJPD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x261D0A0", Offset = "0x261C4A0", VA = "0x18261D0A0")]
	public static JLGMECJOLDI<TMOutput> FNFJOKDAGHE<TMOutput, TMInput, TMNode>([In] this PJHKAJOGCCE<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMInput> PDDHPPHOJPD, int OJANCMLFDOJ)
	{
		return default(JLGMECJOLDI<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x261D370", Offset = "0x261C770", VA = "0x18261D370")]
	internal static void GLBEIEBBGFJ<TMInput, TMOutput, TMNode>(this PJHKAJOGCCE<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMInput> PDDHPPHOJPD, JLGMECJOLDI<TMOutput> FLOGJHFICGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x261D370", Offset = "0x261C770", VA = "0x18261D370")]
	internal static void HGOFFECMHMF<TMInput, TMOutput, TMNode>(this PJHKAJOGCCE<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMInput> PDDHPPHOJPD, JLGMECJOLDI<TMOutput> FLOGJHFICGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2508B60", Offset = "0x2507F60", VA = "0x182508B60")]
	public static FHOAFJPGJCO<JLGMECJOLDI<TMOutput>>.NEMNPNIGEFJ OMPKNNOAMPL<TMOutput, TMInput, TMNode>([In] this PJHKAJOGCCE<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMInput> PDDHPPHOJPD)
	{
		return default(FHOAFJPGJCO<JLGMECJOLDI<TMOutput>>.NEMNPNIGEFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2508B60", Offset = "0x2507F60", VA = "0x182508B60")]
	public static DFLOAPBJNDM<JLGMECJOLDI<TMOutput>, FHOAFJPGJCO<JLGMECJOLDI<TMOutput>>.NEMNPNIGEFJ> PKDIKIMAOBI<TMOutput, TMInput, TMNode>([In] this PJHKAJOGCCE<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMInput> PDDHPPHOJPD)
	{
		return default(DFLOAPBJNDM<JLGMECJOLDI<TMOutput>, FHOAFJPGJCO<JLGMECJOLDI<TMOutput>>.NEMNPNIGEFJ>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct MHEAHEFMOFO<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal KLAHACLPKMA<TMNode> BPFIAGCJGLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal LBFBFNIPGIA<TMNode, FHOAFJPGJCO<JLGMECJOLDI<TMInput>>> LJGHFABDIPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal LBFBFNIPGIA<TMNode, FHOAFJPGJCO<JLGMECJOLDI<TMOutput>>> JLABDEACJAC;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x36F1D90", Offset = "0x36F1190", VA = "0x1836F1D90")]
	internal MHEAHEFMOFO([In] KLAHACLPKMA<TMNode> OMNLBBGKGGE, [In] LBFBFNIPGIA<TMNode, FHOAFJPGJCO<JLGMECJOLDI<TMInput>>> DEIKIDPPMCI, [In] LBFBFNIPGIA<TMNode, FHOAFJPGJCO<JLGMECJOLDI<TMOutput>>> FFNCDJBPKGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x36F1B20", Offset = "0x36F0F20", VA = "0x1836F1B20")]
	internal static MHEAHEFMOFO<TMInput, TMOutput, TMNode> JKJFENIAMEL()
	{
		return default(MHEAHEFMOFO<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class PNGHCBCOFBL
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x27AAAF0", Offset = "0x27A9EF0", VA = "0x1827AAAF0")]
	internal static NLJBAIBDLHD LENOCDGJGPN<TMInput, TMOutput, TMNode>([In] this MHEAHEFMOFO<TMInput, TMOutput, TMNode> NHHBAHIFHJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x27A9E30", Offset = "0x27A9230", VA = "0x1827A9E30")]
	internal static MHEAHEFMOFO<TMInput, TMOutput, TMNode> AFFCBAMFOKP<TMInput, TMOutput, TMNode>(this NLJBAIBDLHD NHHBAHIFHJK)
	{
		return default(MHEAHEFMOFO<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x27AA380", Offset = "0x27A9780", VA = "0x1827AA380")]
	private static BJFBENIIKMD EIDEFELMBKI<TMInput>([In] this FHOAFJPGJCO<JLGMECJOLDI<TMInput>> NHHBAHIFHJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x27AAEB0", Offset = "0x27AA2B0", VA = "0x1827AAEB0")]
	private static FHOAFJPGJCO<JLGMECJOLDI<TMInput>> MFPCONIFMLK<TMInput>(this BJFBENIIKMD NHHBAHIFHJK)
	{
		return default(FHOAFJPGJCO<JLGMECJOLDI<TMInput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x27AA610", Offset = "0x27A9A10", VA = "0x1827AA610")]
	private static GMGKANLHMPF GOHNAEIIGLO<TMOutput>([In] this FHOAFJPGJCO<JLGMECJOLDI<TMOutput>> NHHBAHIFHJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x27AA830", Offset = "0x27A9C30", VA = "0x1827AA830")]
	private static FHOAFJPGJCO<JLGMECJOLDI<TMOutput>> KBEDEEFOLDI<TMOutput>(this GMGKANLHMPF NHHBAHIFHJK)
	{
		return default(FHOAFJPGJCO<JLGMECJOLDI<TMOutput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x27AB1E0", Offset = "0x27AA5E0", VA = "0x1827AB1E0")]
	internal static void NNIMNMJHJOG<TMInput, TMOutput, TMNode>(this MHEAHEFMOFO<TMInput, TMOutput, TMNode> NHHBAHIFHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x27AB4F0", Offset = "0x27AA8F0", VA = "0x1827AB4F0")]
	internal static JLGMECJOLDI<TMNode> PELGDLFAPCE<TMNode, TMInput, TMOutput>(this MHEAHEFMOFO<TMInput, TMOutput, TMNode> NHHBAHIFHJK, [In] FHOAFJPGJCO<JLGMECJOLDI<TMInput>> DEIKIDPPMCI, [In] FHOAFJPGJCO<JLGMECJOLDI<TMOutput>> FFNCDJBPKGH)
	{
		return default(JLGMECJOLDI<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x27AA550", Offset = "0x27A9950", VA = "0x1827AA550")]
	internal static void FLLAKBFBGHI<TMInput, TMOutput, TMNode>(this MHEAHEFMOFO<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMNode> PDDHPPHOJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2507FF0", Offset = "0x25073F0", VA = "0x182507FF0")]
	public static bool EHGNOLKCNDM<TMInput, TMOutput, TMNode>([In] this MHEAHEFMOFO<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMNode> PDDHPPHOJPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x221CE20", Offset = "0x221C220", VA = "0x18221CE20")]
	public static int PJKAGMCAGEO<TMInput, TMOutput, TMNode>([In] this MHEAHEFMOFO<TMInput, TMOutput, TMNode> NHHBAHIFHJK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x27AAAB0", Offset = "0x27A9EB0", VA = "0x1827AAAB0")]
	public static int KEHFLCLIDPN<TMInput, TMOutput, TMNode>([In] this MHEAHEFMOFO<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMNode> PDDHPPHOJPD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x261D740", Offset = "0x261CB40", VA = "0x18261D740")]
	public static int NAPILMLPFOJ<TMInput, TMOutput, TMNode>([In] this MHEAHEFMOFO<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMNode> PDDHPPHOJPD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x27AB190", Offset = "0x27AA590", VA = "0x1827AB190")]
	public static JLGMECJOLDI<TMInput> NLIFDLOABOA<TMInput, TMOutput, TMNode>([In] this MHEAHEFMOFO<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMNode> PDDHPPHOJPD, int OJANCMLFDOJ)
	{
		return default(JLGMECJOLDI<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x261D0A0", Offset = "0x261C4A0", VA = "0x18261D0A0")]
	public static JLGMECJOLDI<TMOutput> FNFJOKDAGHE<TMOutput, TMInput, TMNode>([In] this MHEAHEFMOFO<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMNode> PDDHPPHOJPD, int OJANCMLFDOJ)
	{
		return default(JLGMECJOLDI<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x27AA340", Offset = "0x27A9740", VA = "0x1827AA340")]
	internal static void DCLKOHADEMM<TMInput, TMOutput, TMNode>(this MHEAHEFMOFO<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMNode> PDDHPPHOJPD, JLGMECJOLDI<TMInput> FIPNEPOHCEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x261D370", Offset = "0x261C770", VA = "0x18261D370")]
	internal static void GLBEIEBBGFJ<TMInput, TMOutput, TMNode>(this MHEAHEFMOFO<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMNode> PDDHPPHOJPD, JLGMECJOLDI<TMOutput> FLOGJHFICGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x27AB4A0", Offset = "0x27AA8A0", VA = "0x1827AB4A0")]
	internal static void PCACODLMPFH<TMInput, TMOutput, TMNode>(this MHEAHEFMOFO<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMNode> PDDHPPHOJPD, int OJANCMLFDOJ, JLGMECJOLDI<TMInput> FIPNEPOHCEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x27AA7E0", Offset = "0x27A9BE0", VA = "0x1827AA7E0")]
	internal static void HFHGFPOICLB<TMInput, TMOutput, TMNode>(this MHEAHEFMOFO<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMNode> PDDHPPHOJPD, int OJANCMLFDOJ, JLGMECJOLDI<TMOutput> FLOGJHFICGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x27AA340", Offset = "0x27A9740", VA = "0x1827AA340")]
	internal static void LIJLEHIDPPO<TMInput, TMOutput, TMNode>(this MHEAHEFMOFO<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMNode> PDDHPPHOJPD, JLGMECJOLDI<TMInput> FIPNEPOHCEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x261D370", Offset = "0x261C770", VA = "0x18261D370")]
	internal static void HGOFFECMHMF<TMInput, TMOutput, TMNode>(this MHEAHEFMOFO<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMNode> PDDHPPHOJPD, JLGMECJOLDI<TMOutput> FLOGJHFICGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x27AB130", Offset = "0x27AA530", VA = "0x1827AB130")]
	public static FHOAFJPGJCO<JLGMECJOLDI<TMInput>>.NEMNPNIGEFJ MNFGDKPBNBI<TMInput, TMOutput, TMNode>([In] this MHEAHEFMOFO<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMNode> PDDHPPHOJPD)
	{
		return default(FHOAFJPGJCO<JLGMECJOLDI<TMInput>>.NEMNPNIGEFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2508B60", Offset = "0x2507F60", VA = "0x182508B60")]
	public static FHOAFJPGJCO<JLGMECJOLDI<TMOutput>>.NEMNPNIGEFJ OMPKNNOAMPL<TMOutput, TMInput, TMNode>([In] this MHEAHEFMOFO<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMNode> PDDHPPHOJPD)
	{
		return default(FHOAFJPGJCO<JLGMECJOLDI<TMOutput>>.NEMNPNIGEFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x27AB130", Offset = "0x27AA530", VA = "0x1827AB130")]
	public static DFLOAPBJNDM<JLGMECJOLDI<TMInput>, FHOAFJPGJCO<JLGMECJOLDI<TMInput>>.NEMNPNIGEFJ> PJLDFAEBDCM<TMInput, TMOutput, TMNode>([In] this MHEAHEFMOFO<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMNode> PDDHPPHOJPD)
	{
		return default(DFLOAPBJNDM<JLGMECJOLDI<TMInput>, FHOAFJPGJCO<JLGMECJOLDI<TMInput>>.NEMNPNIGEFJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2508B60", Offset = "0x2507F60", VA = "0x182508B60")]
	public static DFLOAPBJNDM<JLGMECJOLDI<TMOutput>, FHOAFJPGJCO<JLGMECJOLDI<TMOutput>>.NEMNPNIGEFJ> PKDIKIMAOBI<TMOutput, TMInput, TMNode>([In] this MHEAHEFMOFO<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMNode> PDDHPPHOJPD)
	{
		return default(DFLOAPBJNDM<JLGMECJOLDI<TMOutput>, FHOAFJPGJCO<JLGMECJOLDI<TMOutput>>.NEMNPNIGEFJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2508010", Offset = "0x2507410", VA = "0x182508010")]
	public static LNLBHKJAOAK<JLGMECJOLDI<TMNode>, KLAHACLPKMA<TMNode>.EFADKHAIMCH> EJEOAPIEEGP<TMNode, TMInput, TMOutput>([In] this MHEAHEFMOFO<TMInput, TMOutput, TMNode> NHHBAHIFHJK)
	{
		return default(LNLBHKJAOAK<JLGMECJOLDI<TMNode>, KLAHACLPKMA<TMNode>.EFADKHAIMCH>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct CPBIINFKLNL<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal KLAHACLPKMA<TMOutput> BPFIAGCJGLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal LBFBFNIPGIA<TMOutput, JLGMECJOLDI<TMNode>> KAALKKIOJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal LBFBFNIPGIA<TMOutput, FHOAFJPGJCO<JLGMECJOLDI<TMInput>>> LJGHFABDIPI;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x36F1D90", Offset = "0x36F1190", VA = "0x1836F1D90")]
	internal CPBIINFKLNL([In] KLAHACLPKMA<TMOutput> OMNLBBGKGGE, [In] LBFBFNIPGIA<TMOutput, JLGMECJOLDI<TMNode>> LOLIJNBFKGL, [In] LBFBFNIPGIA<TMOutput, FHOAFJPGJCO<JLGMECJOLDI<TMInput>>> DEIKIDPPMCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x36F1B20", Offset = "0x36F0F20", VA = "0x1836F1B20")]
	internal static CPBIINFKLNL<TMInput, TMOutput, TMNode> JKJFENIAMEL()
	{
		return default(CPBIINFKLNL<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class JDEHNIFOPAC
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x268E920", Offset = "0x268DD20", VA = "0x18268E920")]
	internal static MMOHHHPFJJA LENOCDGJGPN<TMInput, TMOutput, TMNode>([In] this CPBIINFKLNL<TMInput, TMOutput, TMNode> NHHBAHIFHJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x268DFC0", Offset = "0x268D3C0", VA = "0x18268DFC0")]
	internal static CPBIINFKLNL<TMInput, TMOutput, TMNode> AFFCBAMFOKP<TMInput, TMOutput, TMNode>(this MMOHHHPFJJA NHHBAHIFHJK)
	{
		return default(CPBIINFKLNL<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x268E4D0", Offset = "0x268D8D0", VA = "0x18268E4D0")]
	private static KOFOGHBFOFD HONJNFFPHLK<TMInput>([In] this FHOAFJPGJCO<JLGMECJOLDI<TMInput>> NHHBAHIFHJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x268E6A0", Offset = "0x268DAA0", VA = "0x18268E6A0")]
	private static FHOAFJPGJCO<JLGMECJOLDI<TMInput>> KGOFGONDAOM<TMInput>(this KOFOGHBFOFD NHHBAHIFHJK)
	{
		return default(FHOAFJPGJCO<JLGMECJOLDI<TMInput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x261D780", Offset = "0x261CB80", VA = "0x18261D780")]
	internal static void NNIMNMJHJOG<TMInput, TMOutput, TMNode>(this CPBIINFKLNL<TMInput, TMOutput, TMNode> NHHBAHIFHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x261D910", Offset = "0x261CD10", VA = "0x18261D910")]
	internal static JLGMECJOLDI<TMOutput> PELGDLFAPCE<TMOutput, TMInput, TMNode>(this CPBIINFKLNL<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMNode> JACJPEOECBN)
	{
		return default(JLGMECJOLDI<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x261D010", Offset = "0x261C410", VA = "0x18261D010")]
	internal static void FLLAKBFBGHI<TMInput, TMOutput, TMNode>(this CPBIINFKLNL<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMOutput> PDDHPPHOJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2507FF0", Offset = "0x25073F0", VA = "0x182507FF0")]
	public static bool EHGNOLKCNDM<TMInput, TMOutput, TMNode>([In] this CPBIINFKLNL<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMOutput> PDDHPPHOJPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x221CE20", Offset = "0x221C220", VA = "0x18221CE20")]
	public static int PJKAGMCAGEO<TMInput, TMOutput, TMNode>([In] this CPBIINFKLNL<TMInput, TMOutput, TMNode> NHHBAHIFHJK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x261CFF0", Offset = "0x261C3F0", VA = "0x18261CFF0")]
	public static JLGMECJOLDI<TMNode> CJDOPPMMLEH<TMNode, TMInput, TMOutput>([In] this CPBIINFKLNL<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMOutput> PDDHPPHOJPD)
	{
		return default(JLGMECJOLDI<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x261D740", Offset = "0x261CB40", VA = "0x18261D740")]
	public static int KEHFLCLIDPN<TMInput, TMOutput, TMNode>([In] this CPBIINFKLNL<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMOutput> PDDHPPHOJPD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x261D0A0", Offset = "0x261C4A0", VA = "0x18261D0A0")]
	public static JLGMECJOLDI<TMInput> NLIFDLOABOA<TMInput, TMOutput, TMNode>([In] this CPBIINFKLNL<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMOutput> PDDHPPHOJPD, int OJANCMLFDOJ)
	{
		return default(JLGMECJOLDI<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x261D370", Offset = "0x261C770", VA = "0x18261D370")]
	internal static void DCLKOHADEMM<TMInput, TMOutput, TMNode>(this CPBIINFKLNL<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMOutput> PDDHPPHOJPD, JLGMECJOLDI<TMInput> FIPNEPOHCEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x261D370", Offset = "0x261C770", VA = "0x18261D370")]
	internal static void LIJLEHIDPPO<TMInput, TMOutput, TMNode>(this CPBIINFKLNL<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMOutput> PDDHPPHOJPD, JLGMECJOLDI<TMInput> FIPNEPOHCEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2508B60", Offset = "0x2507F60", VA = "0x182508B60")]
	public static FHOAFJPGJCO<JLGMECJOLDI<TMInput>>.NEMNPNIGEFJ MNFGDKPBNBI<TMInput, TMOutput, TMNode>([In] this CPBIINFKLNL<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMOutput> PDDHPPHOJPD)
	{
		return default(FHOAFJPGJCO<JLGMECJOLDI<TMInput>>.NEMNPNIGEFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2508B60", Offset = "0x2507F60", VA = "0x182508B60")]
	public static DFLOAPBJNDM<JLGMECJOLDI<TMInput>, FHOAFJPGJCO<JLGMECJOLDI<TMInput>>.NEMNPNIGEFJ> PJLDFAEBDCM<TMInput, TMOutput, TMNode>([In] this CPBIINFKLNL<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMOutput> PDDHPPHOJPD)
	{
		return default(DFLOAPBJNDM<JLGMECJOLDI<TMInput>, FHOAFJPGJCO<JLGMECJOLDI<TMInput>>.NEMNPNIGEFJ>);
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
