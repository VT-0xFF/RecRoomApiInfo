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
		[Cpp2IlInjected.Address(RVA = "0x7D1B20", Offset = "0x7D0520", VA = "0x1807D1B20")]
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
		[Cpp2IlInjected.Address(RVA = "0x1D7CDA0", Offset = "0x1D7B7A0", VA = "0x181D7CDA0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7D2560", Offset = "0x7D0F60", VA = "0x1807D2560")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D25A0", Offset = "0x7D0FA0", VA = "0x1807D25A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x367B240", Offset = "0x3679C40", VA = "0x18367B240", Slot = "4")]
		get
		{
			return default(JLGMECJOLDI<TMNode>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x367B0E0", Offset = "0x3679AE0", VA = "0x18367B0E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x367B170", Offset = "0x3679B70", VA = "0x18367B170")]
	internal AGIEMGGIEJL([In] OAJAJPKGJPE<TMInput, TMOutput, TMNode> BBFFMANAHMH, [In] GHBOKBIPOAB<TMInput, TMOutput, TMNode> IFIAKHLIKJG, bool ENEKCMJJPCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x367AFA0", Offset = "0x36799A0", VA = "0x18367AFA0", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x367B060", Offset = "0x3679A60", VA = "0x18367B060", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x367AF20", Offset = "0x3679920", VA = "0x18367AF20", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class ICJCIKIGMFL
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x26AE650", Offset = "0x26AD050", VA = "0x1826AE650")]
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
		[Cpp2IlInjected.Address(RVA = "0x36B08A0", Offset = "0x36AF2A0", VA = "0x1836B08A0", Slot = "4")]
		get
		{
			return default(JLGMECJOLDI<TMInput>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x36B0770", Offset = "0x36AF170", VA = "0x1836B0770", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x36B0820", Offset = "0x36AF220", VA = "0x1836B0820")]
	internal GHBOKBIPOAB([In] FHOAFJPGJCO<JLGMECJOLDI<TMOutput>>.NEMNPNIGEFJ MNECMJNPCBH, [In] FHOAFJPGJCO<JLGMECJOLDI<TMInput>>.NEMNPNIGEFJ AIJAJGKOBGG, [In] CPBIINFKLNL<TMInput, TMOutput, TMNode> FFNCDJBPKGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x36B05A0", Offset = "0x36AEFA0", VA = "0x1836B05A0", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x36B0700", Offset = "0x36AF100", VA = "0x1836B0700", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x36B0530", Offset = "0x36AEF30", VA = "0x1836B0530", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class OHCALKGFPIE
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x27DC550", Offset = "0x27DAF50", VA = "0x1827DC550")]
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
		[Cpp2IlInjected.Address(RVA = "0x36B08A0", Offset = "0x36AF2A0", VA = "0x1836B08A0", Slot = "4")]
		get
		{
			return default(JLGMECJOLDI<TMOutput>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x36B0770", Offset = "0x36AF170", VA = "0x1836B0770", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x36B0820", Offset = "0x36AF220", VA = "0x1836B0820")]
	internal OAJAJPKGJPE([In] FHOAFJPGJCO<JLGMECJOLDI<TMInput>>.NEMNPNIGEFJ JDBJLLIAJCM, [In] FHOAFJPGJCO<JLGMECJOLDI<TMOutput>>.NEMNPNIGEFJ AAKJMMIAIGF, [In] PJHKAJOGCCE<TMInput, TMOutput, TMNode> DEIKIDPPMCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x36B05A0", Offset = "0x36AEFA0", VA = "0x1836B05A0", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x36B0700", Offset = "0x36AF100", VA = "0x1836B0700", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x36B0530", Offset = "0x36AEF30", VA = "0x1836B0530", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class DDOCBLCKDPK
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x25364A0", Offset = "0x2534EA0", VA = "0x1825364A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4F1F7F0", Offset = "0x4F1E1F0", VA = "0x184F1F7F0")]
	internal DMBPIPAOACD([In] PJHKAJOGCCE<TMInput, TMOutput, TMNode> DEIKIDPPMCI, [In] CPBIINFKLNL<TMInput, TMOutput, TMNode> FFNCDJBPKGH, [In] MHEAHEFMOFO<TMInput, TMOutput, TMNode> LOLIJNBFKGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4F1F540", Offset = "0x4F1DF40", VA = "0x184F1F540")]
	public static DMBPIPAOACD<TMInput?, TMOutput?, TMNode?> JKJFENIAMEL()
	{
		return default(DMBPIPAOACD<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class AJADGGMPDNC
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2C60FB0", Offset = "0x2C5F9B0", VA = "0x182C60FB0")]
	public static GMOJHAEDALM? LENOCDGJGPN<TMInput, TMOutput, TMNode>([In] this DMBPIPAOACD<TMInput, TMOutput, TMNode> NHHBAHIFHJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2C60260", Offset = "0x2C5EC60", VA = "0x182C60260")]
	public static DMBPIPAOACD<TMInput?, TMOutput?, TMNode?> AFFCBAMFOKP<TMInput, TMOutput, TMNode>(this GMOJHAEDALM NHHBAHIFHJK)
	{
		return default(DMBPIPAOACD<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2C612A0", Offset = "0x2C5FCA0", VA = "0x182C612A0")]
	public static void NNIMNMJHJOG<TMInput, TMOutput, TMNode>(this DMBPIPAOACD<TMInput, TMOutput, TMNode> NHHBAHIFHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2C60F50", Offset = "0x2C5F950", VA = "0x182C60F50")]
	public static void IDGNGOIABKB<TMInput, TMOutput, TMNode>(this DMBPIPAOACD<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMOutput> HKFAHDNCKFJ, JLGMECJOLDI<TMInput> FBFNOEBCCEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2C60EF0", Offset = "0x2C5F8F0", VA = "0x182C60EF0")]
	public static void HDBOGCHBNGP<TMInput, TMOutput, TMNode>(this DMBPIPAOACD<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMOutput> HKFAHDNCKFJ, JLGMECJOLDI<TMInput> FBFNOEBCCEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2C60800", Offset = "0x2C5F200", VA = "0x182C60800")]
	public static bool DJDHGADCKKP<TMInput, TMOutput, TMNode>([In] this DMBPIPAOACD<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMOutput> HKFAHDNCKFJ, JLGMECJOLDI<TMInput> FBFNOEBCCEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2C60B10", Offset = "0x2C5F510", VA = "0x182C60B10")]
	public static JLGMECJOLDI<TMNode?> ELMEHOANCIO<TMNode, TMInput, TMOutput>(this DMBPIPAOACD<TMInput, TMOutput, TMNode> NHHBAHIFHJK)
	{
		return default(JLGMECJOLDI<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2C60D00", Offset = "0x2C5F700", VA = "0x182C60D00")]
	public static void GGOKBCCMLKP<TMInput, TMOutput, TMNode>(this DMBPIPAOACD<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMNode> KOOMGHGCPCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2C60780", Offset = "0x2C5F180", VA = "0x182C60780")]
	public static JLGMECJOLDI<TMInput?> CGIHODMKHGP<TMInput, TMOutput, TMNode>(this DMBPIPAOACD<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMNode> KOOMGHGCPCM)
	{
		return default(JLGMECJOLDI<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2C60E80", Offset = "0x2C5F880", VA = "0x182C60E80")]
	public static JLGMECJOLDI<TMOutput?> HCFCFNAMNDI<TMOutput, TMInput, TMNode>(this DMBPIPAOACD<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMNode> KOOMGHGCPCM)
	{
		return default(JLGMECJOLDI<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2C60BA0", Offset = "0x2C5F5A0", VA = "0x182C60BA0")]
	public static JLGMECJOLDI<TMInput?> FEDICMOFOPA<TMInput, TMOutput, TMNode>(this DMBPIPAOACD<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMNode> KOOMGHGCPCM, int OJANCMLFDOJ)
	{
		return default(JLGMECJOLDI<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2C61090", Offset = "0x2C5FA90", VA = "0x182C61090")]
	public static JLGMECJOLDI<TMOutput?> LKHKNMILGPA<TMOutput, TMInput, TMNode>(this DMBPIPAOACD<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMNode> KOOMGHGCPCM, int OJANCMLFDOJ)
	{
		return default(JLGMECJOLDI<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2C605D0", Offset = "0x2C5EFD0", VA = "0x182C605D0")]
	public static void BPALLDEDLPN<TMInput, TMOutput, TMNode>(this DMBPIPAOACD<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMNode> KOOMGHGCPCM, int GECJLINKOGO, int BCIDMCPDBJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2C61200", Offset = "0x2C5FC00", VA = "0x182C61200")]
	public static void MKAKCGIEFFH<TMInput, TMOutput, TMNode>(this DMBPIPAOACD<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMNode> KOOMGHGCPCM, int GECJLINKOGO, int BCIDMCPDBJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2C61110", Offset = "0x2C5FB10", VA = "0x182C61110")]
	public static void MCLPLNPFPPP<TMInput, TMOutput, TMNode>(this DMBPIPAOACD<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMInput> FIPNEPOHCEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2C60C20", Offset = "0x2C5F620", VA = "0x182C60C20")]
	public static void GGAKEBAHIEF<TMInput, TMOutput, TMNode>(this DMBPIPAOACD<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMOutput> FLOGJHFICGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x877270", Offset = "0x875C70", VA = "0x180877270")]
	public static KLAHACLPKMA<TMInput?> CLIJGPJHJFE<TMInput, TMOutput, TMNode>([In] this DMBPIPAOACD<TMInput, TMOutput, TMNode> NHHBAHIFHJK)
	{
		return default(KLAHACLPKMA<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2C607F0", Offset = "0x2C5F1F0", VA = "0x182C607F0")]
	public static KLAHACLPKMA<TMOutput?> DCILCOPKEAK<TMOutput, TMInput, TMNode>([In] this DMBPIPAOACD<TMInput, TMOutput, TMNode> NHHBAHIFHJK)
	{
		return default(KLAHACLPKMA<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x219CB50", Offset = "0x219B550", VA = "0x18219CB50")]
	public static KLAHACLPKMA<TMNode?> OHGHJFLBBNM<TMNode, TMInput, TMOutput>([In] this DMBPIPAOACD<TMInput, TMOutput, TMNode> NHHBAHIFHJK)
	{
		return default(KLAHACLPKMA<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2C60E10", Offset = "0x2C5F810", VA = "0x182C60E10")]
	public static GHBOKBIPOAB<TMInput?, TMOutput?, TMNode?> GNEIGECLMDL<TMInput, TMOutput, TMNode>([In] this DMBPIPAOACD<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMNode> PDDHPPHOJPD)
	{
		return default(GHBOKBIPOAB<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2C60E10", Offset = "0x2C5F810", VA = "0x182C60E10")]
	public static OAJAJPKGJPE<TMInput?, TMOutput?, TMNode?> LKIAOFJHJHL<TMInput, TMOutput, TMNode>([In] this DMBPIPAOACD<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMNode> PDDHPPHOJPD)
	{
		return default(OAJAJPKGJPE<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2C60A60", Offset = "0x2C5F460", VA = "0x182C60A60")]
	public static AGIEMGGIEJL<TMInput?, TMOutput?, TMNode?> DOLIAJBDPGF<TMInput, TMOutput, TMNode>([In] this DMBPIPAOACD<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMNode> PDDHPPHOJPD)
	{
		return default(AGIEMGGIEJL<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2C60670", Offset = "0x2C5F070", VA = "0x182C60670")]
	public static LNLBHKJAOAK<JLGMECJOLDI<TMInput?>, GHBOKBIPOAB<TMInput?, TMOutput?, TMNode?>> CABNIILDFII<TMInput, TMOutput, TMNode>([In] this DMBPIPAOACD<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMNode> PDDHPPHOJPD)
	{
		return default(LNLBHKJAOAK<JLGMECJOLDI<TMInput>, GHBOKBIPOAB<TMInput, TMOutput, TMNode>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2C608D0", Offset = "0x2C5F2D0", VA = "0x182C608D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3731260", Offset = "0x372FC60", VA = "0x183731260")]
	internal PJHKAJOGCCE([In] KLAHACLPKMA<TMInput> OMNLBBGKGGE, [In] LBFBFNIPGIA<TMInput, JLGMECJOLDI<TMNode>> LOLIJNBFKGL, [In] LBFBFNIPGIA<TMInput, FHOAFJPGJCO<JLGMECJOLDI<TMOutput>>> FFNCDJBPKGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3730FF0", Offset = "0x372F9F0", VA = "0x183730FF0")]
	internal static PJHKAJOGCCE<TMInput, TMOutput, TMNode> JKJFENIAMEL()
	{
		return default(PJHKAJOGCCE<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class GCDHCDHHDFM
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x26724C0", Offset = "0x2670EC0", VA = "0x1826724C0")]
	internal static BKPOPNLHNBM LENOCDGJGPN<TMInput, TMOutput, TMNode>([In] this PJHKAJOGCCE<TMInput, TMOutput, TMNode> NHHBAHIFHJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2671A20", Offset = "0x2670420", VA = "0x182671A20")]
	internal static PJHKAJOGCCE<TMInput, TMOutput, TMNode> AFFCBAMFOKP<TMInput, TMOutput, TMNode>(this BKPOPNLHNBM NHHBAHIFHJK)
	{
		return default(PJHKAJOGCCE<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2671F30", Offset = "0x2670930", VA = "0x182671F30")]
	private static DPMFMFIIBOD AODPGGDNLAH<TMOutput>([In] this FHOAFJPGJCO<JLGMECJOLDI<TMOutput>> NHHBAHIFHJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2672200", Offset = "0x2670C00", VA = "0x182672200")]
	private static FHOAFJPGJCO<JLGMECJOLDI<TMOutput>> GAMHGCBIPPP<TMOutput>(this DPMFMFIIBOD NHHBAHIFHJK)
	{
		return default(FHOAFJPGJCO<JLGMECJOLDI<TMOutput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2672890", Offset = "0x2671290", VA = "0x182672890")]
	internal static void NNIMNMJHJOG<TMInput, TMOutput, TMNode>(this PJHKAJOGCCE<TMInput, TMOutput, TMNode> NHHBAHIFHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2672A20", Offset = "0x2671420", VA = "0x182672A20")]
	internal static JLGMECJOLDI<TMInput> PELGDLFAPCE<TMInput, TMOutput, TMNode>(this PJHKAJOGCCE<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMNode> JACJPEOECBN)
	{
		return default(JLGMECJOLDI<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2672120", Offset = "0x2670B20", VA = "0x182672120")]
	internal static void FLLAKBFBGHI<TMInput, TMOutput, TMNode>(this PJHKAJOGCCE<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMInput> PDDHPPHOJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x255A150", Offset = "0x2558B50", VA = "0x18255A150")]
	public static bool EHGNOLKCNDM<TMInput, TMOutput, TMNode>([In] this PJHKAJOGCCE<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMInput> PDDHPPHOJPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2240480", Offset = "0x223EE80", VA = "0x182240480")]
	public static int PJKAGMCAGEO<TMInput, TMOutput, TMNode>([In] this PJHKAJOGCCE<TMInput, TMOutput, TMNode> NHHBAHIFHJK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2672100", Offset = "0x2670B00", VA = "0x182672100")]
	public static JLGMECJOLDI<TMNode> CJDOPPMMLEH<TMNode, TMInput, TMOutput>([In] this PJHKAJOGCCE<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMInput> PDDHPPHOJPD)
	{
		return default(JLGMECJOLDI<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2672850", Offset = "0x2671250", VA = "0x182672850")]
	public static int NAPILMLPFOJ<TMInput, TMOutput, TMNode>([In] this PJHKAJOGCCE<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMInput> PDDHPPHOJPD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x26721B0", Offset = "0x2670BB0", VA = "0x1826721B0")]
	public static JLGMECJOLDI<TMOutput> FNFJOKDAGHE<TMOutput, TMInput, TMNode>([In] this PJHKAJOGCCE<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMInput> PDDHPPHOJPD, int OJANCMLFDOJ)
	{
		return default(JLGMECJOLDI<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2672480", Offset = "0x2670E80", VA = "0x182672480")]
	internal static void GLBEIEBBGFJ<TMInput, TMOutput, TMNode>(this PJHKAJOGCCE<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMInput> PDDHPPHOJPD, JLGMECJOLDI<TMOutput> FLOGJHFICGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2672480", Offset = "0x2670E80", VA = "0x182672480")]
	internal static void HGOFFECMHMF<TMInput, TMOutput, TMNode>(this PJHKAJOGCCE<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMInput> PDDHPPHOJPD, JLGMECJOLDI<TMOutput> FLOGJHFICGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x255ACC0", Offset = "0x25596C0", VA = "0x18255ACC0")]
	public static FHOAFJPGJCO<JLGMECJOLDI<TMOutput>>.NEMNPNIGEFJ OMPKNNOAMPL<TMOutput, TMInput, TMNode>([In] this PJHKAJOGCCE<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMInput> PDDHPPHOJPD)
	{
		return default(FHOAFJPGJCO<JLGMECJOLDI<TMOutput>>.NEMNPNIGEFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x255ACC0", Offset = "0x25596C0", VA = "0x18255ACC0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3731260", Offset = "0x372FC60", VA = "0x183731260")]
	internal MHEAHEFMOFO([In] KLAHACLPKMA<TMNode> OMNLBBGKGGE, [In] LBFBFNIPGIA<TMNode, FHOAFJPGJCO<JLGMECJOLDI<TMInput>>> DEIKIDPPMCI, [In] LBFBFNIPGIA<TMNode, FHOAFJPGJCO<JLGMECJOLDI<TMOutput>>> FFNCDJBPKGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3730FF0", Offset = "0x372F9F0", VA = "0x183730FF0")]
	internal static MHEAHEFMOFO<TMInput, TMOutput, TMNode> JKJFENIAMEL()
	{
		return default(MHEAHEFMOFO<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class PNGHCBCOFBL
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2800380", Offset = "0x27FED80", VA = "0x182800380")]
	internal static NLJBAIBDLHD LENOCDGJGPN<TMInput, TMOutput, TMNode>([In] this MHEAHEFMOFO<TMInput, TMOutput, TMNode> NHHBAHIFHJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x27FF6C0", Offset = "0x27FE0C0", VA = "0x1827FF6C0")]
	internal static MHEAHEFMOFO<TMInput, TMOutput, TMNode> AFFCBAMFOKP<TMInput, TMOutput, TMNode>(this NLJBAIBDLHD NHHBAHIFHJK)
	{
		return default(MHEAHEFMOFO<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x27FFC10", Offset = "0x27FE610", VA = "0x1827FFC10")]
	private static BJFBENIIKMD EIDEFELMBKI<TMInput>([In] this FHOAFJPGJCO<JLGMECJOLDI<TMInput>> NHHBAHIFHJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2800740", Offset = "0x27FF140", VA = "0x182800740")]
	private static FHOAFJPGJCO<JLGMECJOLDI<TMInput>> MFPCONIFMLK<TMInput>(this BJFBENIIKMD NHHBAHIFHJK)
	{
		return default(FHOAFJPGJCO<JLGMECJOLDI<TMInput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x27FFEA0", Offset = "0x27FE8A0", VA = "0x1827FFEA0")]
	private static GMGKANLHMPF GOHNAEIIGLO<TMOutput>([In] this FHOAFJPGJCO<JLGMECJOLDI<TMOutput>> NHHBAHIFHJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x28000C0", Offset = "0x27FEAC0", VA = "0x1828000C0")]
	private static FHOAFJPGJCO<JLGMECJOLDI<TMOutput>> KBEDEEFOLDI<TMOutput>(this GMGKANLHMPF NHHBAHIFHJK)
	{
		return default(FHOAFJPGJCO<JLGMECJOLDI<TMOutput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2800A70", Offset = "0x27FF470", VA = "0x182800A70")]
	internal static void NNIMNMJHJOG<TMInput, TMOutput, TMNode>(this MHEAHEFMOFO<TMInput, TMOutput, TMNode> NHHBAHIFHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2800D80", Offset = "0x27FF780", VA = "0x182800D80")]
	internal static JLGMECJOLDI<TMNode> PELGDLFAPCE<TMNode, TMInput, TMOutput>(this MHEAHEFMOFO<TMInput, TMOutput, TMNode> NHHBAHIFHJK, [In] FHOAFJPGJCO<JLGMECJOLDI<TMInput>> DEIKIDPPMCI, [In] FHOAFJPGJCO<JLGMECJOLDI<TMOutput>> FFNCDJBPKGH)
	{
		return default(JLGMECJOLDI<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x27FFDE0", Offset = "0x27FE7E0", VA = "0x1827FFDE0")]
	internal static void FLLAKBFBGHI<TMInput, TMOutput, TMNode>(this MHEAHEFMOFO<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMNode> PDDHPPHOJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x255A150", Offset = "0x2558B50", VA = "0x18255A150")]
	public static bool EHGNOLKCNDM<TMInput, TMOutput, TMNode>([In] this MHEAHEFMOFO<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMNode> PDDHPPHOJPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2240480", Offset = "0x223EE80", VA = "0x182240480")]
	public static int PJKAGMCAGEO<TMInput, TMOutput, TMNode>([In] this MHEAHEFMOFO<TMInput, TMOutput, TMNode> NHHBAHIFHJK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2800340", Offset = "0x27FED40", VA = "0x182800340")]
	public static int KEHFLCLIDPN<TMInput, TMOutput, TMNode>([In] this MHEAHEFMOFO<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMNode> PDDHPPHOJPD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2672850", Offset = "0x2671250", VA = "0x182672850")]
	public static int NAPILMLPFOJ<TMInput, TMOutput, TMNode>([In] this MHEAHEFMOFO<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMNode> PDDHPPHOJPD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2800A20", Offset = "0x27FF420", VA = "0x182800A20")]
	public static JLGMECJOLDI<TMInput> NLIFDLOABOA<TMInput, TMOutput, TMNode>([In] this MHEAHEFMOFO<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMNode> PDDHPPHOJPD, int OJANCMLFDOJ)
	{
		return default(JLGMECJOLDI<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x26721B0", Offset = "0x2670BB0", VA = "0x1826721B0")]
	public static JLGMECJOLDI<TMOutput> FNFJOKDAGHE<TMOutput, TMInput, TMNode>([In] this MHEAHEFMOFO<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMNode> PDDHPPHOJPD, int OJANCMLFDOJ)
	{
		return default(JLGMECJOLDI<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x27FFBD0", Offset = "0x27FE5D0", VA = "0x1827FFBD0")]
	internal static void DCLKOHADEMM<TMInput, TMOutput, TMNode>(this MHEAHEFMOFO<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMNode> PDDHPPHOJPD, JLGMECJOLDI<TMInput> FIPNEPOHCEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2672480", Offset = "0x2670E80", VA = "0x182672480")]
	internal static void GLBEIEBBGFJ<TMInput, TMOutput, TMNode>(this MHEAHEFMOFO<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMNode> PDDHPPHOJPD, JLGMECJOLDI<TMOutput> FLOGJHFICGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2800D30", Offset = "0x27FF730", VA = "0x182800D30")]
	internal static void PCACODLMPFH<TMInput, TMOutput, TMNode>(this MHEAHEFMOFO<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMNode> PDDHPPHOJPD, int OJANCMLFDOJ, JLGMECJOLDI<TMInput> FIPNEPOHCEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2800070", Offset = "0x27FEA70", VA = "0x182800070")]
	internal static void HFHGFPOICLB<TMInput, TMOutput, TMNode>(this MHEAHEFMOFO<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMNode> PDDHPPHOJPD, int OJANCMLFDOJ, JLGMECJOLDI<TMOutput> FLOGJHFICGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x27FFBD0", Offset = "0x27FE5D0", VA = "0x1827FFBD0")]
	internal static void LIJLEHIDPPO<TMInput, TMOutput, TMNode>(this MHEAHEFMOFO<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMNode> PDDHPPHOJPD, JLGMECJOLDI<TMInput> FIPNEPOHCEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2672480", Offset = "0x2670E80", VA = "0x182672480")]
	internal static void HGOFFECMHMF<TMInput, TMOutput, TMNode>(this MHEAHEFMOFO<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMNode> PDDHPPHOJPD, JLGMECJOLDI<TMOutput> FLOGJHFICGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x28009C0", Offset = "0x27FF3C0", VA = "0x1828009C0")]
	public static FHOAFJPGJCO<JLGMECJOLDI<TMInput>>.NEMNPNIGEFJ MNFGDKPBNBI<TMInput, TMOutput, TMNode>([In] this MHEAHEFMOFO<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMNode> PDDHPPHOJPD)
	{
		return default(FHOAFJPGJCO<JLGMECJOLDI<TMInput>>.NEMNPNIGEFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x255ACC0", Offset = "0x25596C0", VA = "0x18255ACC0")]
	public static FHOAFJPGJCO<JLGMECJOLDI<TMOutput>>.NEMNPNIGEFJ OMPKNNOAMPL<TMOutput, TMInput, TMNode>([In] this MHEAHEFMOFO<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMNode> PDDHPPHOJPD)
	{
		return default(FHOAFJPGJCO<JLGMECJOLDI<TMOutput>>.NEMNPNIGEFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x28009C0", Offset = "0x27FF3C0", VA = "0x1828009C0")]
	public static DFLOAPBJNDM<JLGMECJOLDI<TMInput>, FHOAFJPGJCO<JLGMECJOLDI<TMInput>>.NEMNPNIGEFJ> PJLDFAEBDCM<TMInput, TMOutput, TMNode>([In] this MHEAHEFMOFO<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMNode> PDDHPPHOJPD)
	{
		return default(DFLOAPBJNDM<JLGMECJOLDI<TMInput>, FHOAFJPGJCO<JLGMECJOLDI<TMInput>>.NEMNPNIGEFJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x255ACC0", Offset = "0x25596C0", VA = "0x18255ACC0")]
	public static DFLOAPBJNDM<JLGMECJOLDI<TMOutput>, FHOAFJPGJCO<JLGMECJOLDI<TMOutput>>.NEMNPNIGEFJ> PKDIKIMAOBI<TMOutput, TMInput, TMNode>([In] this MHEAHEFMOFO<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMNode> PDDHPPHOJPD)
	{
		return default(DFLOAPBJNDM<JLGMECJOLDI<TMOutput>, FHOAFJPGJCO<JLGMECJOLDI<TMOutput>>.NEMNPNIGEFJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x255A170", Offset = "0x2558B70", VA = "0x18255A170")]
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
	[Cpp2IlInjected.Address(RVA = "0x3731260", Offset = "0x372FC60", VA = "0x183731260")]
	internal CPBIINFKLNL([In] KLAHACLPKMA<TMOutput> OMNLBBGKGGE, [In] LBFBFNIPGIA<TMOutput, JLGMECJOLDI<TMNode>> LOLIJNBFKGL, [In] LBFBFNIPGIA<TMOutput, FHOAFJPGJCO<JLGMECJOLDI<TMInput>>> DEIKIDPPMCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3730FF0", Offset = "0x372F9F0", VA = "0x183730FF0")]
	internal static CPBIINFKLNL<TMInput, TMOutput, TMNode> JKJFENIAMEL()
	{
		return default(CPBIINFKLNL<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class JDEHNIFOPAC
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x26E3220", Offset = "0x26E1C20", VA = "0x1826E3220")]
	internal static MMOHHHPFJJA LENOCDGJGPN<TMInput, TMOutput, TMNode>([In] this CPBIINFKLNL<TMInput, TMOutput, TMNode> NHHBAHIFHJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x26E28C0", Offset = "0x26E12C0", VA = "0x1826E28C0")]
	internal static CPBIINFKLNL<TMInput, TMOutput, TMNode> AFFCBAMFOKP<TMInput, TMOutput, TMNode>(this MMOHHHPFJJA NHHBAHIFHJK)
	{
		return default(CPBIINFKLNL<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x26E2DD0", Offset = "0x26E17D0", VA = "0x1826E2DD0")]
	private static KOFOGHBFOFD HONJNFFPHLK<TMInput>([In] this FHOAFJPGJCO<JLGMECJOLDI<TMInput>> NHHBAHIFHJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x26E2FA0", Offset = "0x26E19A0", VA = "0x1826E2FA0")]
	private static FHOAFJPGJCO<JLGMECJOLDI<TMInput>> KGOFGONDAOM<TMInput>(this KOFOGHBFOFD NHHBAHIFHJK)
	{
		return default(FHOAFJPGJCO<JLGMECJOLDI<TMInput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2672890", Offset = "0x2671290", VA = "0x182672890")]
	internal static void NNIMNMJHJOG<TMInput, TMOutput, TMNode>(this CPBIINFKLNL<TMInput, TMOutput, TMNode> NHHBAHIFHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2672A20", Offset = "0x2671420", VA = "0x182672A20")]
	internal static JLGMECJOLDI<TMOutput> PELGDLFAPCE<TMOutput, TMInput, TMNode>(this CPBIINFKLNL<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMNode> JACJPEOECBN)
	{
		return default(JLGMECJOLDI<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2672120", Offset = "0x2670B20", VA = "0x182672120")]
	internal static void FLLAKBFBGHI<TMInput, TMOutput, TMNode>(this CPBIINFKLNL<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMOutput> PDDHPPHOJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x255A150", Offset = "0x2558B50", VA = "0x18255A150")]
	public static bool EHGNOLKCNDM<TMInput, TMOutput, TMNode>([In] this CPBIINFKLNL<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMOutput> PDDHPPHOJPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2240480", Offset = "0x223EE80", VA = "0x182240480")]
	public static int PJKAGMCAGEO<TMInput, TMOutput, TMNode>([In] this CPBIINFKLNL<TMInput, TMOutput, TMNode> NHHBAHIFHJK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2672100", Offset = "0x2670B00", VA = "0x182672100")]
	public static JLGMECJOLDI<TMNode> CJDOPPMMLEH<TMNode, TMInput, TMOutput>([In] this CPBIINFKLNL<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMOutput> PDDHPPHOJPD)
	{
		return default(JLGMECJOLDI<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2672850", Offset = "0x2671250", VA = "0x182672850")]
	public static int KEHFLCLIDPN<TMInput, TMOutput, TMNode>([In] this CPBIINFKLNL<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMOutput> PDDHPPHOJPD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x26721B0", Offset = "0x2670BB0", VA = "0x1826721B0")]
	public static JLGMECJOLDI<TMInput> NLIFDLOABOA<TMInput, TMOutput, TMNode>([In] this CPBIINFKLNL<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMOutput> PDDHPPHOJPD, int OJANCMLFDOJ)
	{
		return default(JLGMECJOLDI<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2672480", Offset = "0x2670E80", VA = "0x182672480")]
	internal static void DCLKOHADEMM<TMInput, TMOutput, TMNode>(this CPBIINFKLNL<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMOutput> PDDHPPHOJPD, JLGMECJOLDI<TMInput> FIPNEPOHCEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2672480", Offset = "0x2670E80", VA = "0x182672480")]
	internal static void LIJLEHIDPPO<TMInput, TMOutput, TMNode>(this CPBIINFKLNL<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMOutput> PDDHPPHOJPD, JLGMECJOLDI<TMInput> FIPNEPOHCEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x255ACC0", Offset = "0x25596C0", VA = "0x18255ACC0")]
	public static FHOAFJPGJCO<JLGMECJOLDI<TMInput>>.NEMNPNIGEFJ MNFGDKPBNBI<TMInput, TMOutput, TMNode>([In] this CPBIINFKLNL<TMInput, TMOutput, TMNode> NHHBAHIFHJK, JLGMECJOLDI<TMOutput> PDDHPPHOJPD)
	{
		return default(FHOAFJPGJCO<JLGMECJOLDI<TMInput>>.NEMNPNIGEFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x255ACC0", Offset = "0x25596C0", VA = "0x18255ACC0")]
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
