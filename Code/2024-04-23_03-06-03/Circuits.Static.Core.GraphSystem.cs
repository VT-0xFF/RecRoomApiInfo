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
		[Cpp2IlInjected.Address(RVA = "0x7EACF0", Offset = "0x7E9CF0", VA = "0x1807EACF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1E53200", Offset = "0x1E52200", VA = "0x181E53200")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7EB340", Offset = "0x7EA340", VA = "0x1807EB340")]
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
		[Cpp2IlInjected.Address(RVA = "0x7EB380", Offset = "0x7EA380", VA = "0x1807EB380")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct LGKCHFAOKJF<TMInput, TMOutput, TMNode> : IEnumerator<JLADLGKIDDG<TMNode>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private GKJAIKEGLMF<TMInput, TMOutput, TMNode> LFNHFELNNOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private OFNNJNKCMNC<TMInput, TMOutput, TMNode> FKEAEDLMDKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private bool OLJNABALHLI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public readonly JLADLGKIDDG<TMNode> DGGBFKFKJBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3E30E60", Offset = "0x3E2FE60", VA = "0x183E30E60", Slot = "4")]
		get
		{
			return default(JLADLGKIDDG<TMNode>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3E30D00", Offset = "0x3E2FD00", VA = "0x183E30D00", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3E30D90", Offset = "0x3E2FD90", VA = "0x183E30D90")]
	internal LGKCHFAOKJF([In] GKJAIKEGLMF<TMInput, TMOutput, TMNode> NIDNIABJBKF, [In] OFNNJNKCMNC<TMInput, TMOutput, TMNode> FLFGLIAAOJB, bool EDOHBNBPIMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3E30BC0", Offset = "0x3E2FBC0", VA = "0x183E30BC0", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3E30C80", Offset = "0x3E2FC80", VA = "0x183E30C80", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3E30B40", Offset = "0x3E2FB40", VA = "0x183E30B40", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class ABPFIDGNFMI
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2F0AEB0", Offset = "0x2F09EB0", VA = "0x182F0AEB0")]
	public static LGKCHFAOKJF<TMInput, TMOutput, TMNode> MGIIAIMPALM<TMInput, TMOutput, TMNode>([In] IEBOMDFGNJL<TMInput, TMOutput, TMNode> DFDNJNMACOF, JLADLGKIDDG<TMNode> KBFBOOCDDFE)
	{
		return default(LGKCHFAOKJF<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct OFNNJNKCMNC<TMInput, TMOutput, TMNode> : IEnumerator<JLADLGKIDDG<TMInput>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private EJCNFOOPALK<JLADLGKIDDG<TMOutput>>.HAEHDKOOGKM GECFNKIADFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private EJCNFOOPALK<JLADLGKIDDG<TMInput>>.HAEHDKOOGKM GNBGLACIKBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly COHOKLGFFJH<TMInput, TMOutput, TMNode> NBNAFOJBJBG;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public JLADLGKIDDG<TMInput> DGGBFKFKJBG
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x39BB8E0", Offset = "0x39BA8E0", VA = "0x1839BB8E0", Slot = "4")]
		get
		{
			return default(JLADLGKIDDG<TMInput>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x39BB7B0", Offset = "0x39BA7B0", VA = "0x1839BB7B0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x39BB860", Offset = "0x39BA860", VA = "0x1839BB860")]
	internal OFNNJNKCMNC([In] EJCNFOOPALK<JLADLGKIDDG<TMOutput>>.HAEHDKOOGKM OINDKAKDDOI, [In] EJCNFOOPALK<JLADLGKIDDG<TMInput>>.HAEHDKOOGKM NMEFACNDKHO, [In] COHOKLGFFJH<TMInput, TMOutput, TMNode> KMPJBFEDOBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x39BB5E0", Offset = "0x39BA5E0", VA = "0x1839BB5E0", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x39BB740", Offset = "0x39BA740", VA = "0x1839BB740", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x39BB570", Offset = "0x39BA570", VA = "0x1839BB570", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class BKOJNBAFHOG
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x26BCBC0", Offset = "0x26BBBC0", VA = "0x1826BCBC0")]
	public static OFNNJNKCMNC<TMInput, TMOutput, TMNode> MGIIAIMPALM<TMInput, TMOutput, TMNode>([In] IEBOMDFGNJL<TMInput, TMOutput, TMNode> DFDNJNMACOF, JLADLGKIDDG<TMNode> KBFBOOCDDFE)
	{
		return default(OFNNJNKCMNC<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct GKJAIKEGLMF<TMInput, TMOutput, TMNode> : IEnumerator<JLADLGKIDDG<TMOutput>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private EJCNFOOPALK<JLADLGKIDDG<TMInput>>.HAEHDKOOGKM LACCBCLEFIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private EJCNFOOPALK<JLADLGKIDDG<TMOutput>>.HAEHDKOOGKM CDBHEHDHDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly BMDKLIAGKFK<TMInput, TMOutput, TMNode> PDIFJCIADPP;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public JLADLGKIDDG<TMOutput> DGGBFKFKJBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x39BB8E0", Offset = "0x39BA8E0", VA = "0x1839BB8E0", Slot = "4")]
		get
		{
			return default(JLADLGKIDDG<TMOutput>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x39BB7B0", Offset = "0x39BA7B0", VA = "0x1839BB7B0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x39BB860", Offset = "0x39BA860", VA = "0x1839BB860")]
	internal GKJAIKEGLMF([In] EJCNFOOPALK<JLADLGKIDDG<TMInput>>.HAEHDKOOGKM GPOCFNCBIAI, [In] EJCNFOOPALK<JLADLGKIDDG<TMOutput>>.HAEHDKOOGKM DDJOHOJDBOF, [In] BMDKLIAGKFK<TMInput, TMOutput, TMNode> FFGHDCGLCBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x39BB5E0", Offset = "0x39BA5E0", VA = "0x1839BB5E0", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x39BB740", Offset = "0x39BA740", VA = "0x1839BB740", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x39BB570", Offset = "0x39BA570", VA = "0x1839BB570", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class NOGOGABAMAO
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2A25E10", Offset = "0x2A24E10", VA = "0x182A25E10")]
	public static GKJAIKEGLMF<TMInput, TMOutput, TMNode> MGIIAIMPALM<TMInput, TMOutput, TMNode>([In] IEBOMDFGNJL<TMInput, TMOutput, TMNode> DFDNJNMACOF, JLADLGKIDDG<TMNode> KBFBOOCDDFE)
	{
		return default(GKJAIKEGLMF<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct IEBOMDFGNJL<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public BMDKLIAGKFK<TMInput, TMOutput, TMNode> FLICCPLOCCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public COHOKLGFFJH<TMInput, TMOutput, TMNode> JGMEAFOGHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public BECBHGEKAPA<TMInput, TMOutput, TMNode> MKCEAHKHICN;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3AED590", Offset = "0x3AEC590", VA = "0x183AED590")]
	internal IEBOMDFGNJL([In] BMDKLIAGKFK<TMInput, TMOutput, TMNode> FFGHDCGLCBL, [In] COHOKLGFFJH<TMInput, TMOutput, TMNode> KMPJBFEDOBI, [In] BECBHGEKAPA<TMInput, TMOutput, TMNode> HKBHLCKANLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3AED2E0", Offset = "0x3AEC2E0", VA = "0x183AED2E0")]
	public static IEBOMDFGNJL<TMInput?, TMOutput?, TMNode?> MGIIAIMPALM()
	{
		return default(IEBOMDFGNJL<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class MCEPFHOJCIA
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2974110", Offset = "0x2973110", VA = "0x182974110")]
	public static ILAAHNFPFAJ? AFIENNPCBKD<TMInput, TMOutput, TMNode>([In] this IEBOMDFGNJL<TMInput, TMOutput, TMNode> HFLBADIEKAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2974E30", Offset = "0x2973E30", VA = "0x182974E30")]
	public static IEBOMDFGNJL<TMInput?, TMOutput?, TMNode?> OMCMMHECHCJ<TMInput, TMOutput, TMNode>(this ILAAHNFPFAJ HFLBADIEKAM)
	{
		return default(IEBOMDFGNJL<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x29745B0", Offset = "0x29735B0", VA = "0x1829745B0")]
	public static void FAAFJENLCBJ<TMInput, TMOutput, TMNode>(this IEBOMDFGNJL<TMInput, TMOutput, TMNode> HFLBADIEKAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x29742D0", Offset = "0x29732D0", VA = "0x1829742D0")]
	public static void CBBNAMBKNPI<TMInput, TMOutput, TMNode>(this IEBOMDFGNJL<TMInput, TMOutput, TMNode> HFLBADIEKAM, JLADLGKIDDG<TMOutput> BHBMKHOEJBP, JLADLGKIDDG<TMInput> DDOKNHIGBLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x29747F0", Offset = "0x29737F0", VA = "0x1829747F0")]
	public static void INJJJJGNAJC<TMInput, TMOutput, TMNode>(this IEBOMDFGNJL<TMInput, TMOutput, TMNode> HFLBADIEKAM, JLADLGKIDDG<TMOutput> BHBMKHOEJBP, JLADLGKIDDG<TMInput> DDOKNHIGBLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2974C80", Offset = "0x2973C80", VA = "0x182974C80")]
	public static bool NKPNOPKEMLK<TMInput, TMOutput, TMNode>([In] this IEBOMDFGNJL<TMInput, TMOutput, TMNode> HFLBADIEKAM, JLADLGKIDDG<TMOutput> BHBMKHOEJBP, JLADLGKIDDG<TMInput> DDOKNHIGBLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2974610", Offset = "0x2973610", VA = "0x182974610")]
	public static JLADLGKIDDG<TMNode?> FLCIIOFPMJI<TMNode, TMInput, TMOutput>(this IEBOMDFGNJL<TMInput, TMOutput, TMNode> HFLBADIEKAM)
	{
		return default(JLADLGKIDDG<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2974850", Offset = "0x2973850", VA = "0x182974850")]
	public static void JKKFLJOHPEJ<TMInput, TMOutput, TMNode>(this IEBOMDFGNJL<TMInput, TMOutput, TMNode> HFLBADIEKAM, JLADLGKIDDG<TMNode> KBFBOOCDDFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2974D50", Offset = "0x2973D50", VA = "0x182974D50")]
	public static JLADLGKIDDG<TMInput?> OBILEJEGGAC<TMInput, TMOutput, TMNode>(this IEBOMDFGNJL<TMInput, TMOutput, TMNode> HFLBADIEKAM, JLADLGKIDDG<TMNode> KBFBOOCDDFE)
	{
		return default(JLADLGKIDDG<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2974DC0", Offset = "0x2973DC0", VA = "0x182974DC0")]
	public static JLADLGKIDDG<TMOutput?> OGDFHADEMJL<TMOutput, TMInput, TMNode>(this IEBOMDFGNJL<TMInput, TMOutput, TMNode> HFLBADIEKAM, JLADLGKIDDG<TMNode> KBFBOOCDDFE)
	{
		return default(JLADLGKIDDG<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2974B90", Offset = "0x2973B90", VA = "0x182974B90")]
	public static JLADLGKIDDG<TMInput?> LFNDPMIGJBM<TMInput, TMOutput, TMNode>(this IEBOMDFGNJL<TMInput, TMOutput, TMNode> HFLBADIEKAM, JLADLGKIDDG<TMNode> KBFBOOCDDFE, int GPEHCABDGEJ)
	{
		return default(JLADLGKIDDG<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2974960", Offset = "0x2973960", VA = "0x182974960")]
	public static JLADLGKIDDG<TMOutput?> JLDIIEOKKJC<TMOutput, TMInput, TMNode>(this IEBOMDFGNJL<TMInput, TMOutput, TMNode> HFLBADIEKAM, JLADLGKIDDG<TMNode> KBFBOOCDDFE, int GPEHCABDGEJ)
	{
		return default(JLADLGKIDDG<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x29746A0", Offset = "0x29736A0", VA = "0x1829746A0")]
	public static void GNDECOELFKN<TMInput, TMOutput, TMNode>(this IEBOMDFGNJL<TMInput, TMOutput, TMNode> HFLBADIEKAM, JLADLGKIDDG<TMNode> KBFBOOCDDFE, int AHMOBOOLPBC, int JADAGFAJOND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2974AF0", Offset = "0x2973AF0", VA = "0x182974AF0")]
	public static void KINDJIEGODH<TMInput, TMOutput, TMNode>(this IEBOMDFGNJL<TMInput, TMOutput, TMNode> HFLBADIEKAM, JLADLGKIDDG<TMNode> KBFBOOCDDFE, int AHMOBOOLPBC, int JADAGFAJOND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x29744C0", Offset = "0x29734C0", VA = "0x1829744C0")]
	public static void DNAJHMMKALJ<TMInput, TMOutput, TMNode>(this IEBOMDFGNJL<TMInput, TMOutput, TMNode> HFLBADIEKAM, JLADLGKIDDG<TMInput> PGPGHAGDOFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x29741F0", Offset = "0x29731F0", VA = "0x1829741F0")]
	public static void BABOEFIHIIH<TMInput, TMOutput, TMNode>(this IEBOMDFGNJL<TMInput, TMOutput, TMNode> HFLBADIEKAM, JLADLGKIDDG<TMOutput> IDIHOPKDBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x882610", Offset = "0x881610", VA = "0x180882610")]
	public static FELMAPACAEE<TMInput?> OKOKPABHNMA<TMInput, TMOutput, TMNode>([In] this IEBOMDFGNJL<TMInput, TMOutput, TMNode> HFLBADIEKAM)
	{
		return default(FELMAPACAEE<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1E83F00", Offset = "0x1E82F00", VA = "0x181E83F00")]
	public static FELMAPACAEE<TMOutput?> KELIBFBONEG<TMOutput, TMInput, TMNode>([In] this IEBOMDFGNJL<TMInput, TMOutput, TMNode> HFLBADIEKAM)
	{
		return default(FELMAPACAEE<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1E833F0", Offset = "0x1E823F0", VA = "0x181E833F0")]
	public static FELMAPACAEE<TMNode?> KBEOMIDPBDI<TMNode, TMInput, TMOutput>([In] this IEBOMDFGNJL<TMInput, TMOutput, TMNode> HFLBADIEKAM)
	{
		return default(FELMAPACAEE<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2974C10", Offset = "0x2973C10", VA = "0x182974C10")]
	public static OFNNJNKCMNC<TMInput?, TMOutput?, TMNode?> LKFOOPOPKIB<TMInput, TMOutput, TMNode>([In] this IEBOMDFGNJL<TMInput, TMOutput, TMNode> HFLBADIEKAM, JLADLGKIDDG<TMNode> JKEKANKKCCC)
	{
		return default(OFNNJNKCMNC<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2974C10", Offset = "0x2973C10", VA = "0x182974C10")]
	public static GKJAIKEGLMF<TMInput?, TMOutput?, TMNode?> LIBBJBBPDGO<TMInput, TMOutput, TMNode>([In] this IEBOMDFGNJL<TMInput, TMOutput, TMNode> HFLBADIEKAM, JLADLGKIDDG<TMNode> JKEKANKKCCC)
	{
		return default(GKJAIKEGLMF<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2974740", Offset = "0x2973740", VA = "0x182974740")]
	public static LGKCHFAOKJF<TMInput?, TMOutput?, TMNode?> HHEHHJLJNCP<TMInput, TMOutput, TMNode>([In] this IEBOMDFGNJL<TMInput, TMOutput, TMNode> HFLBADIEKAM, JLADLGKIDDG<TMNode> JKEKANKKCCC)
	{
		return default(LGKCHFAOKJF<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x29749E0", Offset = "0x29739E0", VA = "0x1829749E0")]
	public static FJDNLJOKGKJ<JLADLGKIDDG<TMInput?>, OFNNJNKCMNC<TMInput?, TMOutput?, TMNode?>> JMIGDPDEABL<TMInput, TMOutput, TMNode>([In] this IEBOMDFGNJL<TMInput, TMOutput, TMNode> HFLBADIEKAM, JLADLGKIDDG<TMNode> JKEKANKKCCC)
	{
		return default(FJDNLJOKGKJ<JLADLGKIDDG<TMInput>, OFNNJNKCMNC<TMInput, TMOutput, TMNode>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2974330", Offset = "0x2973330", VA = "0x182974330")]
	public static FJDNLJOKGKJ<JLADLGKIDDG<TMNode?>, LGKCHFAOKJF<TMInput?, TMOutput?, TMNode?>> DDJLPCNOHPM<TMNode, TMInput, TMOutput>([In] this IEBOMDFGNJL<TMInput, TMOutput, TMNode> HFLBADIEKAM, JLADLGKIDDG<TMNode> JKEKANKKCCC)
	{
		return default(FJDNLJOKGKJ<JLADLGKIDDG<TMNode>, LGKCHFAOKJF<TMInput, TMOutput, TMNode>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct BMDKLIAGKFK<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal FELMAPACAEE<TMInput> HCILAHOOFLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	internal LAFNIHFOMLK<TMInput, JLADLGKIDDG<TMNode>> CCCNGBLKJEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal LAFNIHFOMLK<TMInput, EJCNFOOPALK<JLADLGKIDDG<TMOutput>>> NBNAFOJBJBG;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3CC5910", Offset = "0x3CC4910", VA = "0x183CC5910")]
	internal BMDKLIAGKFK([In] FELMAPACAEE<TMInput> EBEJAFBHBKE, [In] LAFNIHFOMLK<TMInput, JLADLGKIDDG<TMNode>> HKBHLCKANLN, [In] LAFNIHFOMLK<TMInput, EJCNFOOPALK<JLADLGKIDDG<TMOutput>>> KMPJBFEDOBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3CC56A0", Offset = "0x3CC46A0", VA = "0x183CC56A0")]
	internal static BMDKLIAGKFK<TMInput, TMOutput, TMNode> MGIIAIMPALM()
	{
		return default(BMDKLIAGKFK<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class PJLEDILBNEE
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2A537F0", Offset = "0x2A527F0", VA = "0x182A537F0")]
	internal static FECBMEJFDNO AFIENNPCBKD<TMInput, TMOutput, TMNode>([In] this BMDKLIAGKFK<TMInput, TMOutput, TMNode> HFLBADIEKAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2A53FD0", Offset = "0x2A52FD0", VA = "0x182A53FD0")]
	internal static BMDKLIAGKFK<TMInput, TMOutput, TMNode> OMCMMHECHCJ<TMInput, TMOutput, TMNode>(this FECBMEJFDNO HFLBADIEKAM)
	{
		return default(BMDKLIAGKFK<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2A53E00", Offset = "0x2A52E00", VA = "0x182A53E00")]
	private static FKFBPOKOHGA MCDHEELKHGA<TMOutput>([In] this EJCNFOOPALK<JLADLGKIDDG<TMOutput>> HFLBADIEKAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2A53B80", Offset = "0x2A52B80", VA = "0x182A53B80")]
	private static EJCNFOOPALK<JLADLGKIDDG<TMOutput>> KAPJELDEIMA<TMOutput>(this FKFBPOKOHGA HFLBADIEKAM)
	{
		return default(EJCNFOOPALK<JLADLGKIDDG<TMOutput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2912C30", Offset = "0x2911C30", VA = "0x182912C30")]
	internal static void FAAFJENLCBJ<TMInput, TMOutput, TMNode>(this BMDKLIAGKFK<TMInput, TMOutput, TMNode> HFLBADIEKAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2912DC0", Offset = "0x2911DC0", VA = "0x182912DC0")]
	internal static JLADLGKIDDG<TMInput> FPBCCOICMED<TMInput, TMOutput, TMNode>(this BMDKLIAGKFK<TMInput, TMOutput, TMNode> HFLBADIEKAM, JLADLGKIDDG<TMNode> CDMAFKOHEPF)
	{
		return default(JLADLGKIDDG<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x29137E0", Offset = "0x29127E0", VA = "0x1829137E0")]
	internal static void OMHEABKHJKG<TMInput, TMOutput, TMNode>(this BMDKLIAGKFK<TMInput, TMOutput, TMNode> HFLBADIEKAM, JLADLGKIDDG<TMInput> JKEKANKKCCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2719EE0", Offset = "0x2718EE0", VA = "0x182719EE0")]
	public static bool AGICPGAMDKF<TMInput, TMOutput, TMNode>([In] this BMDKLIAGKFK<TMInput, TMOutput, TMNode> HFLBADIEKAM, JLADLGKIDDG<TMInput> JKEKANKKCCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x26AB9C0", Offset = "0x26AA9C0", VA = "0x1826AB9C0")]
	public static int PFPIMPJHDDH<TMInput, TMOutput, TMNode>([In] this BMDKLIAGKFK<TMInput, TMOutput, TMNode> HFLBADIEKAM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2912E60", Offset = "0x2911E60", VA = "0x182912E60")]
	public static JLADLGKIDDG<TMNode> KEKMCFAGPBD<TMNode, TMInput, TMOutput>([In] this BMDKLIAGKFK<TMInput, TMOutput, TMNode> HFLBADIEKAM, JLADLGKIDDG<TMInput> JKEKANKKCCC)
	{
		return default(JLADLGKIDDG<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x28EEED0", Offset = "0x28EDED0", VA = "0x1828EEED0")]
	public static int HMAHICAJNJL<TMInput, TMOutput, TMNode>([In] this BMDKLIAGKFK<TMInput, TMOutput, TMNode> HFLBADIEKAM, JLADLGKIDDG<TMInput> JKEKANKKCCC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x28EEB30", Offset = "0x28EDB30", VA = "0x1828EEB30")]
	public static JLADLGKIDDG<TMOutput> DPEMPMHAHKG<TMOutput, TMInput, TMNode>([In] this BMDKLIAGKFK<TMInput, TMOutput, TMNode> HFLBADIEKAM, JLADLGKIDDG<TMInput> JKEKANKKCCC, int GPEHCABDGEJ)
	{
		return default(JLADLGKIDDG<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x28EE500", Offset = "0x28ED500", VA = "0x1828EE500")]
	internal static void EJNMAPNPILJ<TMInput, TMOutput, TMNode>(this BMDKLIAGKFK<TMInput, TMOutput, TMNode> HFLBADIEKAM, JLADLGKIDDG<TMInput> JKEKANKKCCC, JLADLGKIDDG<TMOutput> IDIHOPKDBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x28EE500", Offset = "0x28ED500", VA = "0x1828EE500")]
	internal static void BJPHHOLFLBO<TMInput, TMOutput, TMNode>(this BMDKLIAGKFK<TMInput, TMOutput, TMNode> HFLBADIEKAM, JLADLGKIDDG<TMInput> JKEKANKKCCC, JLADLGKIDDG<TMOutput> IDIHOPKDBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x28A9360", Offset = "0x28A8360", VA = "0x1828A9360")]
	public static EJCNFOOPALK<JLADLGKIDDG<TMOutput>>.HAEHDKOOGKM AEEDLOBFGKI<TMOutput, TMInput, TMNode>([In] this BMDKLIAGKFK<TMInput, TMOutput, TMNode> HFLBADIEKAM, JLADLGKIDDG<TMInput> JKEKANKKCCC)
	{
		return default(EJCNFOOPALK<JLADLGKIDDG<TMOutput>>.HAEHDKOOGKM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x28A9360", Offset = "0x28A8360", VA = "0x1828A9360")]
	public static HOACKFAJJBE<JLADLGKIDDG<TMOutput>, EJCNFOOPALK<JLADLGKIDDG<TMOutput>>.HAEHDKOOGKM> JNFELNBKGJC<TMOutput, TMInput, TMNode>([In] this BMDKLIAGKFK<TMInput, TMOutput, TMNode> HFLBADIEKAM, JLADLGKIDDG<TMInput> JKEKANKKCCC)
	{
		return default(HOACKFAJJBE<JLADLGKIDDG<TMOutput>, EJCNFOOPALK<JLADLGKIDDG<TMOutput>>.HAEHDKOOGKM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct BECBHGEKAPA<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal FELMAPACAEE<TMNode> HCILAHOOFLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal LAFNIHFOMLK<TMNode, EJCNFOOPALK<JLADLGKIDDG<TMInput>>> PDIFJCIADPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal LAFNIHFOMLK<TMNode, EJCNFOOPALK<JLADLGKIDDG<TMOutput>>> NBNAFOJBJBG;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3CC5910", Offset = "0x3CC4910", VA = "0x183CC5910")]
	internal BECBHGEKAPA([In] FELMAPACAEE<TMNode> EBEJAFBHBKE, [In] LAFNIHFOMLK<TMNode, EJCNFOOPALK<JLADLGKIDDG<TMInput>>> FFGHDCGLCBL, [In] LAFNIHFOMLK<TMNode, EJCNFOOPALK<JLADLGKIDDG<TMOutput>>> KMPJBFEDOBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3CC56A0", Offset = "0x3CC46A0", VA = "0x183CC56A0")]
	internal static BECBHGEKAPA<TMInput, TMOutput, TMNode> MGIIAIMPALM()
	{
		return default(BECBHGEKAPA<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class HPAHNJPCAGO
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x28EE100", Offset = "0x28ED100", VA = "0x1828EE100")]
	internal static NEEEMOPHJDC AFIENNPCBKD<TMInput, TMOutput, TMNode>([In] this BECBHGEKAPA<TMInput, TMOutput, TMNode> HFLBADIEKAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x28EF300", Offset = "0x28EE300", VA = "0x1828EF300")]
	internal static BECBHGEKAPA<TMInput, TMOutput, TMNode> OMCMMHECHCJ<TMInput, TMOutput, TMNode>(this NEEEMOPHJDC HFLBADIEKAM)
	{
		return default(BECBHGEKAPA<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x28EEF60", Offset = "0x28EDF60", VA = "0x1828EEF60")]
	private static CKGPIMJHHPD KEPBNJADJMF<TMInput>([In] this EJCNFOOPALK<JLADLGKIDDG<TMInput>> HFLBADIEKAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x28EE540", Offset = "0x28ED540", VA = "0x1828EE540")]
	private static EJCNFOOPALK<JLADLGKIDDG<TMInput>> CIIBFDBFKPG<TMInput>(this CKGPIMJHHPD HFLBADIEKAM)
	{
		return default(EJCNFOOPALK<JLADLGKIDDG<TMInput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x28EF130", Offset = "0x28EE130", VA = "0x1828EF130")]
	private static NDPDGJNENHM MPLFOBAIEKJ<TMOutput>([In] this EJCNFOOPALK<JLADLGKIDDG<TMOutput>> HFLBADIEKAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x28EE820", Offset = "0x28ED820", VA = "0x1828EE820")]
	private static EJCNFOOPALK<JLADLGKIDDG<TMOutput>> CMIOFDKJNDC<TMOutput>(this NDPDGJNENHM HFLBADIEKAM)
	{
		return default(EJCNFOOPALK<JLADLGKIDDG<TMOutput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x28EEB80", Offset = "0x28EDB80", VA = "0x1828EEB80")]
	internal static void FAAFJENLCBJ<TMInput, TMOutput, TMNode>(this BECBHGEKAPA<TMInput, TMOutput, TMNode> HFLBADIEKAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x28EEE40", Offset = "0x28EDE40", VA = "0x1828EEE40")]
	internal static JLADLGKIDDG<TMNode> FPBCCOICMED<TMNode, TMInput, TMOutput>(this BECBHGEKAPA<TMInput, TMOutput, TMNode> HFLBADIEKAM, [In] EJCNFOOPALK<JLADLGKIDDG<TMInput>> FFGHDCGLCBL, [In] EJCNFOOPALK<JLADLGKIDDG<TMOutput>> KMPJBFEDOBI)
	{
		return default(JLADLGKIDDG<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x28EF810", Offset = "0x28EE810", VA = "0x1828EF810")]
	internal static void OMHEABKHJKG<TMInput, TMOutput, TMNode>(this BECBHGEKAPA<TMInput, TMOutput, TMNode> HFLBADIEKAM, JLADLGKIDDG<TMNode> JKEKANKKCCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2719EE0", Offset = "0x2718EE0", VA = "0x182719EE0")]
	public static bool AGICPGAMDKF<TMInput, TMOutput, TMNode>([In] this BECBHGEKAPA<TMInput, TMOutput, TMNode> HFLBADIEKAM, JLADLGKIDDG<TMNode> JKEKANKKCCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x26AB9C0", Offset = "0x26AA9C0", VA = "0x1826AB9C0")]
	public static int PFPIMPJHDDH<TMInput, TMOutput, TMNode>([In] this BECBHGEKAPA<TMInput, TMOutput, TMNode> HFLBADIEKAM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x28EE4C0", Offset = "0x28ED4C0", VA = "0x1828EE4C0")]
	public static int AHOIFANMDDC<TMInput, TMOutput, TMNode>([In] this BECBHGEKAPA<TMInput, TMOutput, TMNode> HFLBADIEKAM, JLADLGKIDDG<TMNode> JKEKANKKCCC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x28EEED0", Offset = "0x28EDED0", VA = "0x1828EEED0")]
	public static int HMAHICAJNJL<TMInput, TMOutput, TMNode>([In] this BECBHGEKAPA<TMInput, TMOutput, TMNode> HFLBADIEKAM, JLADLGKIDDG<TMNode> JKEKANKKCCC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x28EEF10", Offset = "0x28EDF10", VA = "0x1828EEF10")]
	public static JLADLGKIDDG<TMInput> IDJICGFENFI<TMInput, TMOutput, TMNode>([In] this BECBHGEKAPA<TMInput, TMOutput, TMNode> HFLBADIEKAM, JLADLGKIDDG<TMNode> JKEKANKKCCC, int GPEHCABDGEJ)
	{
		return default(JLADLGKIDDG<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x28EEB30", Offset = "0x28EDB30", VA = "0x1828EEB30")]
	public static JLADLGKIDDG<TMOutput> DPEMPMHAHKG<TMOutput, TMInput, TMNode>([In] this BECBHGEKAPA<TMInput, TMOutput, TMNode> HFLBADIEKAM, JLADLGKIDDG<TMNode> JKEKANKKCCC, int GPEHCABDGEJ)
	{
		return default(JLADLGKIDDG<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x28EEAF0", Offset = "0x28EDAF0", VA = "0x1828EEAF0")]
	internal static void KBCEGPDLHKN<TMInput, TMOutput, TMNode>(this BECBHGEKAPA<TMInput, TMOutput, TMNode> HFLBADIEKAM, JLADLGKIDDG<TMNode> JKEKANKKCCC, JLADLGKIDDG<TMInput> PGPGHAGDOFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x28EE500", Offset = "0x28ED500", VA = "0x1828EE500")]
	internal static void EJNMAPNPILJ<TMInput, TMOutput, TMNode>(this BECBHGEKAPA<TMInput, TMOutput, TMNode> HFLBADIEKAM, JLADLGKIDDG<TMNode> JKEKANKKCCC, JLADLGKIDDG<TMOutput> IDIHOPKDBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x28EF8D0", Offset = "0x28EE8D0", VA = "0x1828EF8D0")]
	internal static void POEFAKPNKBA<TMInput, TMOutput, TMNode>(this BECBHGEKAPA<TMInput, TMOutput, TMNode> HFLBADIEKAM, JLADLGKIDDG<TMNode> JKEKANKKCCC, int GPEHCABDGEJ, JLADLGKIDDG<TMInput> PGPGHAGDOFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x28EEAA0", Offset = "0x28EDAA0", VA = "0x1828EEAA0")]
	internal static void DBFANCMOFNN<TMInput, TMOutput, TMNode>(this BECBHGEKAPA<TMInput, TMOutput, TMNode> HFLBADIEKAM, JLADLGKIDDG<TMNode> JKEKANKKCCC, int GPEHCABDGEJ, JLADLGKIDDG<TMOutput> IDIHOPKDBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x28EEAF0", Offset = "0x28EDAF0", VA = "0x1828EEAF0")]
	internal static void DEAMIICFEPE<TMInput, TMOutput, TMNode>(this BECBHGEKAPA<TMInput, TMOutput, TMNode> HFLBADIEKAM, JLADLGKIDDG<TMNode> JKEKANKKCCC, JLADLGKIDDG<TMInput> PGPGHAGDOFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x28EE500", Offset = "0x28ED500", VA = "0x1828EE500")]
	internal static void BJPHHOLFLBO<TMInput, TMOutput, TMNode>(this BECBHGEKAPA<TMInput, TMOutput, TMNode> HFLBADIEKAM, JLADLGKIDDG<TMNode> JKEKANKKCCC, JLADLGKIDDG<TMOutput> IDIHOPKDBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x28EE7C0", Offset = "0x28ED7C0", VA = "0x1828EE7C0")]
	public static EJCNFOOPALK<JLADLGKIDDG<TMInput>>.HAEHDKOOGKM PCKNOGDFAEI<TMInput, TMOutput, TMNode>([In] this BECBHGEKAPA<TMInput, TMOutput, TMNode> HFLBADIEKAM, JLADLGKIDDG<TMNode> JKEKANKKCCC)
	{
		return default(EJCNFOOPALK<JLADLGKIDDG<TMInput>>.HAEHDKOOGKM);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x28A9360", Offset = "0x28A8360", VA = "0x1828A9360")]
	public static EJCNFOOPALK<JLADLGKIDDG<TMOutput>>.HAEHDKOOGKM AEEDLOBFGKI<TMOutput, TMInput, TMNode>([In] this BECBHGEKAPA<TMInput, TMOutput, TMNode> HFLBADIEKAM, JLADLGKIDDG<TMNode> JKEKANKKCCC)
	{
		return default(EJCNFOOPALK<JLADLGKIDDG<TMOutput>>.HAEHDKOOGKM);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x28EE7C0", Offset = "0x28ED7C0", VA = "0x1828EE7C0")]
	public static HOACKFAJJBE<JLADLGKIDDG<TMInput>, EJCNFOOPALK<JLADLGKIDDG<TMInput>>.HAEHDKOOGKM> CKMOONBPLIO<TMInput, TMOutput, TMNode>([In] this BECBHGEKAPA<TMInput, TMOutput, TMNode> HFLBADIEKAM, JLADLGKIDDG<TMNode> JKEKANKKCCC)
	{
		return default(HOACKFAJJBE<JLADLGKIDDG<TMInput>, EJCNFOOPALK<JLADLGKIDDG<TMInput>>.HAEHDKOOGKM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x28A9360", Offset = "0x28A8360", VA = "0x1828A9360")]
	public static HOACKFAJJBE<JLADLGKIDDG<TMOutput>, EJCNFOOPALK<JLADLGKIDDG<TMOutput>>.HAEHDKOOGKM> JNFELNBKGJC<TMOutput, TMInput, TMNode>([In] this BECBHGEKAPA<TMInput, TMOutput, TMNode> HFLBADIEKAM, JLADLGKIDDG<TMNode> JKEKANKKCCC)
	{
		return default(HOACKFAJJBE<JLADLGKIDDG<TMOutput>, EJCNFOOPALK<JLADLGKIDDG<TMOutput>>.HAEHDKOOGKM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x28A9250", Offset = "0x28A8250", VA = "0x1828A9250")]
	public static FJDNLJOKGKJ<JLADLGKIDDG<TMNode>, FELMAPACAEE<TMNode>.AEOEKKJJFMK> DLFLEHEBAOH<TMNode, TMInput, TMOutput>([In] this BECBHGEKAPA<TMInput, TMOutput, TMNode> HFLBADIEKAM)
	{
		return default(FJDNLJOKGKJ<JLADLGKIDDG<TMNode>, FELMAPACAEE<TMNode>.AEOEKKJJFMK>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct COHOKLGFFJH<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal FELMAPACAEE<TMOutput> HCILAHOOFLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal LAFNIHFOMLK<TMOutput, JLADLGKIDDG<TMNode>> CCCNGBLKJEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal LAFNIHFOMLK<TMOutput, EJCNFOOPALK<JLADLGKIDDG<TMInput>>> PDIFJCIADPP;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3CC5910", Offset = "0x3CC4910", VA = "0x183CC5910")]
	internal COHOKLGFFJH([In] FELMAPACAEE<TMOutput> EBEJAFBHBKE, [In] LAFNIHFOMLK<TMOutput, JLADLGKIDDG<TMNode>> HKBHLCKANLN, [In] LAFNIHFOMLK<TMOutput, EJCNFOOPALK<JLADLGKIDDG<TMInput>>> FFGHDCGLCBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3CC56A0", Offset = "0x3CC46A0", VA = "0x183CC56A0")]
	internal static COHOKLGFFJH<TMInput, TMOutput, TMNode> MGIIAIMPALM()
	{
		return default(COHOKLGFFJH<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class INFBADKCHFK
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x29128A0", Offset = "0x29118A0", VA = "0x1829128A0")]
	internal static BNEOKKLMMJP AFIENNPCBKD<TMInput, TMOutput, TMNode>([In] this COHOKLGFFJH<TMInput, TMOutput, TMNode> HFLBADIEKAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x29132D0", Offset = "0x29122D0", VA = "0x1829132D0")]
	internal static COHOKLGFFJH<TMInput, TMOutput, TMNode> OMCMMHECHCJ<TMInput, TMOutput, TMNode>(this BNEOKKLMMJP HFLBADIEKAM)
	{
		return default(COHOKLGFFJH<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2913100", Offset = "0x2912100", VA = "0x182913100")]
	private static HAICFIBAMMJ MCOLFFCEBHM<TMInput>([In] this EJCNFOOPALK<JLADLGKIDDG<TMInput>> HFLBADIEKAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2912E80", Offset = "0x2911E80", VA = "0x182912E80")]
	private static EJCNFOOPALK<JLADLGKIDDG<TMInput>> LFMJOGFALHB<TMInput>(this HAICFIBAMMJ HFLBADIEKAM)
	{
		return default(EJCNFOOPALK<JLADLGKIDDG<TMInput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2912C30", Offset = "0x2911C30", VA = "0x182912C30")]
	internal static void FAAFJENLCBJ<TMInput, TMOutput, TMNode>(this COHOKLGFFJH<TMInput, TMOutput, TMNode> HFLBADIEKAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2912DC0", Offset = "0x2911DC0", VA = "0x182912DC0")]
	internal static JLADLGKIDDG<TMOutput> FPBCCOICMED<TMOutput, TMInput, TMNode>(this COHOKLGFFJH<TMInput, TMOutput, TMNode> HFLBADIEKAM, JLADLGKIDDG<TMNode> CDMAFKOHEPF)
	{
		return default(JLADLGKIDDG<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x29137E0", Offset = "0x29127E0", VA = "0x1829137E0")]
	internal static void OMHEABKHJKG<TMInput, TMOutput, TMNode>(this COHOKLGFFJH<TMInput, TMOutput, TMNode> HFLBADIEKAM, JLADLGKIDDG<TMOutput> JKEKANKKCCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2719EE0", Offset = "0x2718EE0", VA = "0x182719EE0")]
	public static bool AGICPGAMDKF<TMInput, TMOutput, TMNode>([In] this COHOKLGFFJH<TMInput, TMOutput, TMNode> HFLBADIEKAM, JLADLGKIDDG<TMOutput> JKEKANKKCCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x26AB9C0", Offset = "0x26AA9C0", VA = "0x1826AB9C0")]
	public static int PFPIMPJHDDH<TMInput, TMOutput, TMNode>([In] this COHOKLGFFJH<TMInput, TMOutput, TMNode> HFLBADIEKAM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2912E60", Offset = "0x2911E60", VA = "0x182912E60")]
	public static JLADLGKIDDG<TMNode> KEKMCFAGPBD<TMNode, TMInput, TMOutput>([In] this COHOKLGFFJH<TMInput, TMOutput, TMNode> HFLBADIEKAM, JLADLGKIDDG<TMOutput> JKEKANKKCCC)
	{
		return default(JLADLGKIDDG<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x28EEED0", Offset = "0x28EDED0", VA = "0x1828EEED0")]
	public static int AHOIFANMDDC<TMInput, TMOutput, TMNode>([In] this COHOKLGFFJH<TMInput, TMOutput, TMNode> HFLBADIEKAM, JLADLGKIDDG<TMOutput> JKEKANKKCCC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x28EEB30", Offset = "0x28EDB30", VA = "0x1828EEB30")]
	public static JLADLGKIDDG<TMInput> IDJICGFENFI<TMInput, TMOutput, TMNode>([In] this COHOKLGFFJH<TMInput, TMOutput, TMNode> HFLBADIEKAM, JLADLGKIDDG<TMOutput> JKEKANKKCCC, int GPEHCABDGEJ)
	{
		return default(JLADLGKIDDG<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x28EE500", Offset = "0x28ED500", VA = "0x1828EE500")]
	internal static void KBCEGPDLHKN<TMInput, TMOutput, TMNode>(this COHOKLGFFJH<TMInput, TMOutput, TMNode> HFLBADIEKAM, JLADLGKIDDG<TMOutput> JKEKANKKCCC, JLADLGKIDDG<TMInput> PGPGHAGDOFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x28EE500", Offset = "0x28ED500", VA = "0x1828EE500")]
	internal static void DEAMIICFEPE<TMInput, TMOutput, TMNode>(this COHOKLGFFJH<TMInput, TMOutput, TMNode> HFLBADIEKAM, JLADLGKIDDG<TMOutput> JKEKANKKCCC, JLADLGKIDDG<TMInput> PGPGHAGDOFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x28A9360", Offset = "0x28A8360", VA = "0x1828A9360")]
	public static EJCNFOOPALK<JLADLGKIDDG<TMInput>>.HAEHDKOOGKM PCKNOGDFAEI<TMInput, TMOutput, TMNode>([In] this COHOKLGFFJH<TMInput, TMOutput, TMNode> HFLBADIEKAM, JLADLGKIDDG<TMOutput> JKEKANKKCCC)
	{
		return default(EJCNFOOPALK<JLADLGKIDDG<TMInput>>.HAEHDKOOGKM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x28A9360", Offset = "0x28A8360", VA = "0x1828A9360")]
	public static HOACKFAJJBE<JLADLGKIDDG<TMInput>, EJCNFOOPALK<JLADLGKIDDG<TMInput>>.HAEHDKOOGKM> CKMOONBPLIO<TMInput, TMOutput, TMNode>([In] this COHOKLGFFJH<TMInput, TMOutput, TMNode> HFLBADIEKAM, JLADLGKIDDG<TMOutput> JKEKANKKCCC)
	{
		return default(HOACKFAJJBE<JLADLGKIDDG<TMInput>, EJCNFOOPALK<JLADLGKIDDG<TMInput>>.HAEHDKOOGKM>);
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
