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
		[Cpp2IlInjected.Address(RVA = "0x7997A0", Offset = "0x7985A0", VA = "0x1807997A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1CBC500", Offset = "0x1CBB300", VA = "0x181CBC500")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x799B60", Offset = "0x798960", VA = "0x180799B60")]
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
		[Cpp2IlInjected.Address(RVA = "0x799BA0", Offset = "0x7989A0", VA = "0x180799BA0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct GAKCPMHPEKK<TMInput, TMOutput, TMNode> : IEnumerator<MLOCHKHLPON<TMNode>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private FIFEOLNCIJM<TMInput, TMOutput, TMNode> NMDJDAGNBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private IENFDLMMAKC<TMInput, TMOutput, TMNode> KJMDIINPNAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private bool MJGJALGEALH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public readonly MLOCHKHLPON<TMNode> POOLCAAKLKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x351AF40", Offset = "0x3519D40", VA = "0x18351AF40", Slot = "4")]
		get
		{
			return default(MLOCHKHLPON<TMNode>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x351ADE0", Offset = "0x3519BE0", VA = "0x18351ADE0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x351AE70", Offset = "0x3519C70", VA = "0x18351AE70")]
	internal GAKCPMHPEKK([In] FIFEOLNCIJM<TMInput, TMOutput, TMNode> HMEBPPAAMHF, [In] IENFDLMMAKC<TMInput, TMOutput, TMNode> HDHINOADCGO, bool KEAHJBBLJEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x351ACA0", Offset = "0x3519AA0", VA = "0x18351ACA0", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x351AD60", Offset = "0x3519B60", VA = "0x18351AD60", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x351AC20", Offset = "0x3519A20", VA = "0x18351AC20", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class ELJBJKIONNH
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x23AA300", Offset = "0x23A9100", VA = "0x1823AA300")]
	public static GAKCPMHPEKK<TMInput, TMOutput, TMNode> FMIHPEHEFKO<TMInput, TMOutput, TMNode>([In] GFDIDGCOKOG<TMInput, TMOutput, TMNode> PLGEEDLKIMP, MLOCHKHLPON<TMNode> CNNNLFIFOJC)
	{
		return default(GAKCPMHPEKK<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct IENFDLMMAKC<TMInput, TMOutput, TMNode> : IEnumerator<MLOCHKHLPON<TMInput>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private CCOECDIADIF<MLOCHKHLPON<TMOutput>>.IOEOBCPKJIE FIICMPPFMJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private CCOECDIADIF<MLOCHKHLPON<TMInput>>.IOEOBCPKJIE BFBLKBFPNBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly OANNKHCKBPE<TMInput, TMOutput, TMNode> AAGGDNEEEKC;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public MLOCHKHLPON<TMInput> POOLCAAKLKE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3453540", Offset = "0x3452340", VA = "0x183453540", Slot = "4")]
		get
		{
			return default(MLOCHKHLPON<TMInput>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3453410", Offset = "0x3452210", VA = "0x183453410", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x34534C0", Offset = "0x34522C0", VA = "0x1834534C0")]
	internal IENFDLMMAKC([In] CCOECDIADIF<MLOCHKHLPON<TMOutput>>.IOEOBCPKJIE NADBFADIBJO, [In] CCOECDIADIF<MLOCHKHLPON<TMInput>>.IOEOBCPKJIE DKBPPGMJOEL, [In] OANNKHCKBPE<TMInput, TMOutput, TMNode> ANLOCKABCAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3453240", Offset = "0x3452040", VA = "0x183453240", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x34533A0", Offset = "0x34521A0", VA = "0x1834533A0", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x34531D0", Offset = "0x3451FD0", VA = "0x1834531D0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class ICJBLIOCPOC
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x251BE20", Offset = "0x251AC20", VA = "0x18251BE20")]
	public static IENFDLMMAKC<TMInput, TMOutput, TMNode> FMIHPEHEFKO<TMInput, TMOutput, TMNode>([In] GFDIDGCOKOG<TMInput, TMOutput, TMNode> PLGEEDLKIMP, MLOCHKHLPON<TMNode> CNNNLFIFOJC)
	{
		return default(IENFDLMMAKC<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct FIFEOLNCIJM<TMInput, TMOutput, TMNode> : IEnumerator<MLOCHKHLPON<TMOutput>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private CCOECDIADIF<MLOCHKHLPON<TMInput>>.IOEOBCPKJIE ALPKIPKPELJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private CCOECDIADIF<MLOCHKHLPON<TMOutput>>.IOEOBCPKJIE MGCKJIAKIOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly CGFDICGHFPH<TMInput, TMOutput, TMNode> MOHOCAHIDLF;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public MLOCHKHLPON<TMOutput> POOLCAAKLKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3453540", Offset = "0x3452340", VA = "0x183453540", Slot = "4")]
		get
		{
			return default(MLOCHKHLPON<TMOutput>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3453410", Offset = "0x3452210", VA = "0x183453410", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x34534C0", Offset = "0x34522C0", VA = "0x1834534C0")]
	internal FIFEOLNCIJM([In] CCOECDIADIF<MLOCHKHLPON<TMInput>>.IOEOBCPKJIE MGCALEMLBFP, [In] CCOECDIADIF<MLOCHKHLPON<TMOutput>>.IOEOBCPKJIE HLFMFCPAJCD, [In] CGFDICGHFPH<TMInput, TMOutput, TMNode> IPPPJIKJIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3453240", Offset = "0x3452040", VA = "0x183453240", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x34533A0", Offset = "0x34521A0", VA = "0x1834533A0", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x34531D0", Offset = "0x3451FD0", VA = "0x1834531D0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class BKNLAHBKCHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x22A2E30", Offset = "0x22A1C30", VA = "0x1822A2E30")]
	public static FIFEOLNCIJM<TMInput, TMOutput, TMNode> FMIHPEHEFKO<TMInput, TMOutput, TMNode>([In] GFDIDGCOKOG<TMInput, TMOutput, TMNode> PLGEEDLKIMP, MLOCHKHLPON<TMNode> CNNNLFIFOJC)
	{
		return default(FIFEOLNCIJM<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct GFDIDGCOKOG<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public CGFDICGHFPH<TMInput, TMOutput, TMNode> ELKKKACNHPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public OANNKHCKBPE<TMInput, TMOutput, TMNode> KOKPAKJGFOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public LMFHPFLEDNO<TMInput, TMOutput, TMNode> EFCDFGILNPL;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x35BAAA0", Offset = "0x35B98A0", VA = "0x1835BAAA0")]
	internal GFDIDGCOKOG([In] CGFDICGHFPH<TMInput, TMOutput, TMNode> IPPPJIKJIOK, [In] OANNKHCKBPE<TMInput, TMOutput, TMNode> ANLOCKABCAM, [In] LMFHPFLEDNO<TMInput, TMOutput, TMNode> GLMPGJPDLNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x35BA7F0", Offset = "0x35B95F0", VA = "0x1835BA7F0")]
	public static GFDIDGCOKOG<TMInput?, TMOutput?, TMNode?> FMIHPEHEFKO()
	{
		return default(GFDIDGCOKOG<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class OFEKPGELDKD
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x261EFF0", Offset = "0x261DDF0", VA = "0x18261EFF0")]
	public static IEDMCLENIFG? OJBJHHLKILJ<TMInput, TMOutput, TMNode>([In] this GFDIDGCOKOG<TMInput, TMOutput, TMNode> HLCOOGAGOEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x261EA50", Offset = "0x261D850", VA = "0x18261EA50")]
	public static GFDIDGCOKOG<TMInput?, TMOutput?, TMNode?> LKNPCKIALBL<TMInput, TMOutput, TMNode>(this IEDMCLENIFG HLCOOGAGOEK)
	{
		return default(GFDIDGCOKOG<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x261E900", Offset = "0x261D700", VA = "0x18261E900")]
	public static void IFMJALEKMOK<TMInput, TMOutput, TMNode>(this GFDIDGCOKOG<TMInput, TMOutput, TMNode> HLCOOGAGOEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x261E9F0", Offset = "0x261D7F0", VA = "0x18261E9F0")]
	public static void LFIJMAEKAFE<TMInput, TMOutput, TMNode>(this GFDIDGCOKOG<TMInput, TMOutput, TMNode> HLCOOGAGOEK, MLOCHKHLPON<TMOutput> BJJAFFNMJKF, MLOCHKHLPON<TMInput> FHHDPKLNIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x261E110", Offset = "0x261CF10", VA = "0x18261E110")]
	public static void AIOMGOLPHPA<TMInput, TMOutput, TMNode>(this GFDIDGCOKOG<TMInput, TMOutput, TMNode> HLCOOGAGOEK, MLOCHKHLPON<TMOutput> BJJAFFNMJKF, MLOCHKHLPON<TMInput> FHHDPKLNIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x261E3A0", Offset = "0x261D1A0", VA = "0x18261E3A0")]
	public static bool COGBBDABKGD<TMInput, TMOutput, TMNode>([In] this GFDIDGCOKOG<TMInput, TMOutput, TMNode> HLCOOGAGOEK, MLOCHKHLPON<TMOutput> BJJAFFNMJKF, MLOCHKHLPON<TMInput> FHHDPKLNIAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x261E960", Offset = "0x261D760", VA = "0x18261E960")]
	public static MLOCHKHLPON<TMNode?> IGMMKNHHEFP<TMNode, TMInput, TMOutput>(this GFDIDGCOKOG<TMInput, TMOutput, TMNode> HLCOOGAGOEK)
	{
		return default(MLOCHKHLPON<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x261E470", Offset = "0x261D270", VA = "0x18261E470")]
	public static void DBNPBGPLLFE<TMInput, TMOutput, TMNode>(this GFDIDGCOKOG<TMInput, TMOutput, TMNode> HLCOOGAGOEK, MLOCHKHLPON<TMNode> CNNNLFIFOJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x261E680", Offset = "0x261D480", VA = "0x18261E680")]
	public static MLOCHKHLPON<TMInput?> GCBDIKAIOKN<TMInput, TMOutput, TMNode>(this GFDIDGCOKOG<TMInput, TMOutput, TMNode> HLCOOGAGOEK, MLOCHKHLPON<TMNode> CNNNLFIFOJC)
	{
		return default(MLOCHKHLPON<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x261E170", Offset = "0x261CF70", VA = "0x18261E170")]
	public static MLOCHKHLPON<TMOutput?> AKIJDFJIODF<TMOutput, TMInput, TMNode>(this GFDIDGCOKOG<TMInput, TMOutput, TMNode> HLCOOGAGOEK, MLOCHKHLPON<TMNode> CNNNLFIFOJC)
	{
		return default(MLOCHKHLPON<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x261EED0", Offset = "0x261DCD0", VA = "0x18261EED0")]
	public static MLOCHKHLPON<TMInput?> NIBGIOJCCCD<TMInput, TMOutput, TMNode>(this GFDIDGCOKOG<TMInput, TMOutput, TMNode> HLCOOGAGOEK, MLOCHKHLPON<TMNode> CNNNLFIFOJC, int NGIPPLLBEKC)
	{
		return default(MLOCHKHLPON<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x261E880", Offset = "0x261D680", VA = "0x18261E880")]
	public static MLOCHKHLPON<TMOutput?> HKCNKKEDJHN<TMOutput, TMInput, TMNode>(this GFDIDGCOKOG<TMInput, TMOutput, TMNode> HLCOOGAGOEK, MLOCHKHLPON<TMNode> CNNNLFIFOJC, int NGIPPLLBEKC)
	{
		return default(MLOCHKHLPON<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x261EE30", Offset = "0x261DC30", VA = "0x18261EE30")]
	public static void NDEIIDIPBIL<TMInput, TMOutput, TMNode>(this GFDIDGCOKOG<TMInput, TMOutput, TMNode> HLCOOGAGOEK, MLOCHKHLPON<TMNode> CNNNLFIFOJC, int DDOIJANEBHA, int LMCHPECNCCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x261EF50", Offset = "0x261DD50", VA = "0x18261EF50")]
	public static void NMHALPICIHB<TMInput, TMOutput, TMNode>(this GFDIDGCOKOG<TMInput, TMOutput, TMNode> HLCOOGAGOEK, MLOCHKHLPON<TMNode> CNNNLFIFOJC, int DDOIJANEBHA, int LMCHPECNCCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x261E020", Offset = "0x261CE20", VA = "0x18261E020")]
	public static void AFFIBCPIBPP<TMInput, TMOutput, TMNode>(this GFDIDGCOKOG<TMInput, TMOutput, TMNode> HLCOOGAGOEK, MLOCHKHLPON<TMInput> DLNMELFOEGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x261E580", Offset = "0x261D380", VA = "0x18261E580")]
	public static void DFIINBIFGNE<TMInput, TMOutput, TMNode>(this GFDIDGCOKOG<TMInput, TMOutput, TMNode> HLCOOGAGOEK, MLOCHKHLPON<TMOutput> IEHMFIJKAOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8146C0", Offset = "0x8134C0", VA = "0x1808146C0")]
	public static GCIMOGLIMHK<TMInput?> KLHNIBJCOKL<TMInput, TMOutput, TMNode>([In] this GFDIDGCOKOG<TMInput, TMOutput, TMNode> HLCOOGAGOEK)
	{
		return default(GCIMOGLIMHK<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x261E670", Offset = "0x261D470", VA = "0x18261E670")]
	public static GCIMOGLIMHK<TMOutput?> EOJBNCGIIGP<TMOutput, TMInput, TMNode>([In] this GFDIDGCOKOG<TMInput, TMOutput, TMNode> HLCOOGAGOEK)
	{
		return default(GCIMOGLIMHK<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x261E660", Offset = "0x261D460", VA = "0x18261E660")]
	public static GCIMOGLIMHK<TMNode?> DGOFDJFKDMF<TMNode, TMInput, TMOutput>([In] this GFDIDGCOKOG<TMInput, TMOutput, TMNode> HLCOOGAGOEK)
	{
		return default(GCIMOGLIMHK<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x261EDC0", Offset = "0x261DBC0", VA = "0x18261EDC0")]
	public static IENFDLMMAKC<TMInput?, TMOutput?, TMNode?> MKABEODKKNB<TMInput, TMOutput, TMNode>([In] this GFDIDGCOKOG<TMInput, TMOutput, TMNode> HLCOOGAGOEK, MLOCHKHLPON<TMNode> JPODHBJFPKM)
	{
		return default(IENFDLMMAKC<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x261EDC0", Offset = "0x261DBC0", VA = "0x18261EDC0")]
	public static FIFEOLNCIJM<TMInput?, TMOutput?, TMNode?> OIEFEGCCNBL<TMInput, TMOutput, TMNode>([In] this GFDIDGCOKOG<TMInput, TMOutput, TMNode> HLCOOGAGOEK, MLOCHKHLPON<TMNode> JPODHBJFPKM)
	{
		return default(FIFEOLNCIJM<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x261E1E0", Offset = "0x261CFE0", VA = "0x18261E1E0")]
	public static GAKCPMHPEKK<TMInput?, TMOutput?, TMNode?> BCEDMMCLIEJ<TMInput, TMOutput, TMNode>([In] this GFDIDGCOKOG<TMInput, TMOutput, TMNode> HLCOOGAGOEK, MLOCHKHLPON<TMNode> JPODHBJFPKM)
	{
		return default(GAKCPMHPEKK<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x261E290", Offset = "0x261D090", VA = "0x18261E290")]
	public static FLEJINJKMKH<MLOCHKHLPON<TMInput?>, IENFDLMMAKC<TMInput?, TMOutput?, TMNode?>> CNBLHDNOFKC<TMInput, TMOutput, TMNode>([In] this GFDIDGCOKOG<TMInput, TMOutput, TMNode> HLCOOGAGOEK, MLOCHKHLPON<TMNode> JPODHBJFPKM)
	{
		return default(FLEJINJKMKH<MLOCHKHLPON<TMInput>, IENFDLMMAKC<TMInput, TMOutput, TMNode>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x261E6F0", Offset = "0x261D4F0", VA = "0x18261E6F0")]
	public static FLEJINJKMKH<MLOCHKHLPON<TMNode?>, GAKCPMHPEKK<TMInput?, TMOutput?, TMNode?>> GNNKNCEMLLI<TMNode, TMInput, TMOutput>([In] this GFDIDGCOKOG<TMInput, TMOutput, TMNode> HLCOOGAGOEK, MLOCHKHLPON<TMNode> JPODHBJFPKM)
	{
		return default(FLEJINJKMKH<MLOCHKHLPON<TMNode>, GAKCPMHPEKK<TMInput, TMOutput, TMNode>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct CGFDICGHFPH<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal GCIMOGLIMHK<TMInput> IHDAKDIDPLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	internal EBPMFLLAEFM<TMInput, MLOCHKHLPON<TMNode>> IKOILCHEKJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal EBPMFLLAEFM<TMInput, CCOECDIADIF<MLOCHKHLPON<TMOutput>>> AAGGDNEEEKC;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x35FFB90", Offset = "0x35FE990", VA = "0x1835FFB90")]
	internal CGFDICGHFPH([In] GCIMOGLIMHK<TMInput> PEKGLIGJILL, [In] EBPMFLLAEFM<TMInput, MLOCHKHLPON<TMNode>> GLMPGJPDLNF, [In] EBPMFLLAEFM<TMInput, CCOECDIADIF<MLOCHKHLPON<TMOutput>>> ANLOCKABCAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x35FF920", Offset = "0x35FE720", VA = "0x1835FF920")]
	internal static CGFDICGHFPH<TMInput, TMOutput, TMNode> FMIHPEHEFKO()
	{
		return default(CGFDICGHFPH<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class DIAAFFPENAK
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x235CD80", Offset = "0x235BB80", VA = "0x18235CD80")]
	internal static HCJDMBPJDOB OJBJHHLKILJ<TMInput, TMOutput, TMNode>([In] this CGFDICGHFPH<TMInput, TMOutput, TMNode> HLCOOGAGOEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x235C810", Offset = "0x235B610", VA = "0x18235C810")]
	internal static CGFDICGHFPH<TMInput, TMOutput, TMNode> LKNPCKIALBL<TMInput, TMOutput, TMNode>(this HCJDMBPJDOB HLCOOGAGOEK)
	{
		return default(CGFDICGHFPH<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x235C150", Offset = "0x235AF50", VA = "0x18235C150")]
	private static KOBCAGBONOE GFEGOKIDAKH<TMOutput>([In] this CCOECDIADIF<MLOCHKHLPON<TMOutput>> HLCOOGAGOEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x235C590", Offset = "0x235B390", VA = "0x18235C590")]
	private static CCOECDIADIF<MLOCHKHLPON<TMOutput>> KNINHOODHPB<TMOutput>(this KOBCAGBONOE HLCOOGAGOEK)
	{
		return default(CCOECDIADIF<MLOCHKHLPON<TMOutput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x235C3B0", Offset = "0x235B1B0", VA = "0x18235C3B0")]
	internal static void IFMJALEKMOK<TMInput, TMOutput, TMNode>(this CGFDICGHFPH<TMInput, TMOutput, TMNode> HLCOOGAGOEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x235C050", Offset = "0x235AE50", VA = "0x18235C050")]
	internal static MLOCHKHLPON<TMInput> AJFPOFBBGPG<TMInput, TMOutput, TMNode>(this CGFDICGHFPH<TMInput, TMOutput, TMNode> HLCOOGAGOEK, MLOCHKHLPON<TMNode> JAHOBDMOOOJ)
	{
		return default(MLOCHKHLPON<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x235C320", Offset = "0x235B120", VA = "0x18235C320")]
	internal static void HCFLFLFMJJD<TMInput, TMOutput, TMNode>(this CGFDICGHFPH<TMInput, TMOutput, TMNode> HLCOOGAGOEK, MLOCHKHLPON<TMInput> JPODHBJFPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x232DCA0", Offset = "0x232CAA0", VA = "0x18232DCA0")]
	public static bool ELLDGLBOGGN<TMInput, TMOutput, TMNode>([In] this CGFDICGHFPH<TMInput, TMOutput, TMNode> HLCOOGAGOEK, MLOCHKHLPON<TMInput> JPODHBJFPKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x235CD60", Offset = "0x235BB60", VA = "0x18235CD60")]
	public static MLOCHKHLPON<TMNode> LOHANKDFOLL<TMNode, TMInput, TMOutput>([In] this CGFDICGHFPH<TMInput, TMOutput, TMNode> HLCOOGAGOEK, MLOCHKHLPON<TMInput> JPODHBJFPKM)
	{
		return default(MLOCHKHLPON<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x235CD20", Offset = "0x235BB20", VA = "0x18235CD20")]
	public static int LMGGAJOBHJF<TMInput, TMOutput, TMNode>([In] this CGFDICGHFPH<TMInput, TMOutput, TMNode> HLCOOGAGOEK, MLOCHKHLPON<TMInput> JPODHBJFPKM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x235C540", Offset = "0x235B340", VA = "0x18235C540")]
	public static MLOCHKHLPON<TMOutput> KHPNPLFAOMN<TMOutput, TMInput, TMNode>([In] this CGFDICGHFPH<TMInput, TMOutput, TMNode> HLCOOGAGOEK, MLOCHKHLPON<TMInput> JPODHBJFPKM, int NGIPPLLBEKC)
	{
		return default(MLOCHKHLPON<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x235C010", Offset = "0x235AE10", VA = "0x18235C010")]
	internal static void ACHOBNKIINF<TMInput, TMOutput, TMNode>(this CGFDICGHFPH<TMInput, TMOutput, TMNode> HLCOOGAGOEK, MLOCHKHLPON<TMInput> JPODHBJFPKM, MLOCHKHLPON<TMOutput> IEHMFIJKAOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x235C010", Offset = "0x235AE10", VA = "0x18235C010")]
	internal static void BDGFFALOIIH<TMInput, TMOutput, TMNode>(this CGFDICGHFPH<TMInput, TMOutput, TMNode> HLCOOGAGOEK, MLOCHKHLPON<TMInput> JPODHBJFPKM, MLOCHKHLPON<TMOutput> IEHMFIJKAOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x235C0F0", Offset = "0x235AEF0", VA = "0x18235C0F0")]
	public static CCOECDIADIF<MLOCHKHLPON<TMOutput>>.IOEOBCPKJIE GICOJCIPJKC<TMOutput, TMInput, TMNode>([In] this CGFDICGHFPH<TMInput, TMOutput, TMNode> HLCOOGAGOEK, MLOCHKHLPON<TMInput> JPODHBJFPKM)
	{
		return default(CCOECDIADIF<MLOCHKHLPON<TMOutput>>.IOEOBCPKJIE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x235C0F0", Offset = "0x235AEF0", VA = "0x18235C0F0")]
	public static ADFNMKADCAO<MLOCHKHLPON<TMOutput>, CCOECDIADIF<MLOCHKHLPON<TMOutput>>.IOEOBCPKJIE> CGJDEDKMPKE<TMOutput, TMInput, TMNode>([In] this CGFDICGHFPH<TMInput, TMOutput, TMNode> HLCOOGAGOEK, MLOCHKHLPON<TMInput> JPODHBJFPKM)
	{
		return default(ADFNMKADCAO<MLOCHKHLPON<TMOutput>, CCOECDIADIF<MLOCHKHLPON<TMOutput>>.IOEOBCPKJIE>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct LMFHPFLEDNO<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal GCIMOGLIMHK<TMNode> IHDAKDIDPLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal EBPMFLLAEFM<TMNode, CCOECDIADIF<MLOCHKHLPON<TMInput>>> MOHOCAHIDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal EBPMFLLAEFM<TMNode, CCOECDIADIF<MLOCHKHLPON<TMOutput>>> AAGGDNEEEKC;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x35FFB90", Offset = "0x35FE990", VA = "0x1835FFB90")]
	internal LMFHPFLEDNO([In] GCIMOGLIMHK<TMNode> PEKGLIGJILL, [In] EBPMFLLAEFM<TMNode, CCOECDIADIF<MLOCHKHLPON<TMInput>>> IPPPJIKJIOK, [In] EBPMFLLAEFM<TMNode, CCOECDIADIF<MLOCHKHLPON<TMOutput>>> ANLOCKABCAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x35FF920", Offset = "0x35FE720", VA = "0x1835FF920")]
	internal static LMFHPFLEDNO<TMInput, TMOutput, TMNode> FMIHPEHEFKO()
	{
		return default(LMFHPFLEDNO<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class HCEGDFPJDEN
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2506AA0", Offset = "0x25058A0", VA = "0x182506AA0")]
	internal static AIEPEKGGKPA OJBJHHLKILJ<TMInput, TMOutput, TMNode>([In] this LMFHPFLEDNO<TMInput, TMOutput, TMNode> HLCOOGAGOEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x25063C0", Offset = "0x25051C0", VA = "0x1825063C0")]
	internal static LMFHPFLEDNO<TMInput, TMOutput, TMNode> LKNPCKIALBL<TMInput, TMOutput, TMNode>(this AIEPEKGGKPA HLCOOGAGOEK)
	{
		return default(LMFHPFLEDNO<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x25059E0", Offset = "0x25047E0", VA = "0x1825059E0")]
	private static FBEOJFNDAOP BCDABNJNHEH<TMInput>([In] this CCOECDIADIF<MLOCHKHLPON<TMInput>> HLCOOGAGOEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2506E60", Offset = "0x2505C60", VA = "0x182506E60")]
	private static CCOECDIADIF<MLOCHKHLPON<TMInput>> PFHHDBFNEOE<TMInput>(this FBEOJFNDAOP HLCOOGAGOEK)
	{
		return default(CCOECDIADIF<MLOCHKHLPON<TMInput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x25068D0", Offset = "0x25056D0", VA = "0x1825068D0")]
	private static MOHNOKMAMOJ MKNEOGMFGOI<TMOutput>([In] this CCOECDIADIF<MLOCHKHLPON<TMOutput>> HLCOOGAGOEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2505C50", Offset = "0x2504A50", VA = "0x182505C50")]
	private static CCOECDIADIF<MLOCHKHLPON<TMOutput>> GCBPAEKFIMC<TMOutput>(this MOHNOKMAMOJ HLCOOGAGOEK)
	{
		return default(CCOECDIADIF<MLOCHKHLPON<TMOutput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2505FE0", Offset = "0x2504DE0", VA = "0x182505FE0")]
	internal static void IFMJALEKMOK<TMInput, TMOutput, TMNode>(this LMFHPFLEDNO<TMInput, TMOutput, TMNode> HLCOOGAGOEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2505950", Offset = "0x2504750", VA = "0x182505950")]
	internal static MLOCHKHLPON<TMNode> AJFPOFBBGPG<TMNode, TMInput, TMOutput>(this LMFHPFLEDNO<TMInput, TMOutput, TMNode> HLCOOGAGOEK, [In] CCOECDIADIF<MLOCHKHLPON<TMInput>> IPPPJIKJIOK, [In] CCOECDIADIF<MLOCHKHLPON<TMOutput>> ANLOCKABCAM)
	{
		return default(MLOCHKHLPON<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2505F20", Offset = "0x2504D20", VA = "0x182505F20")]
	internal static void HCFLFLFMJJD<TMInput, TMOutput, TMNode>(this LMFHPFLEDNO<TMInput, TMOutput, TMNode> HLCOOGAGOEK, MLOCHKHLPON<TMNode> JPODHBJFPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x232DCA0", Offset = "0x232CAA0", VA = "0x18232DCA0")]
	public static bool ELLDGLBOGGN<TMInput, TMOutput, TMNode>([In] this LMFHPFLEDNO<TMInput, TMOutput, TMNode> HLCOOGAGOEK, MLOCHKHLPON<TMNode> JPODHBJFPKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x25062A0", Offset = "0x25050A0", VA = "0x1825062A0")]
	public static int JNFNKJAOEHA<TMInput, TMOutput, TMNode>([In] this LMFHPFLEDNO<TMInput, TMOutput, TMNode> HLCOOGAGOEK, MLOCHKHLPON<TMNode> JPODHBJFPKM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x235CD20", Offset = "0x235BB20", VA = "0x18235CD20")]
	public static int LMGGAJOBHJF<TMInput, TMOutput, TMNode>([In] this LMFHPFLEDNO<TMInput, TMOutput, TMNode> HLCOOGAGOEK, MLOCHKHLPON<TMNode> JPODHBJFPKM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2505ED0", Offset = "0x2504CD0", VA = "0x182505ED0")]
	public static MLOCHKHLPON<TMInput> HBGLHMMJLLF<TMInput, TMOutput, TMNode>([In] this LMFHPFLEDNO<TMInput, TMOutput, TMNode> HLCOOGAGOEK, MLOCHKHLPON<TMNode> JPODHBJFPKM, int NGIPPLLBEKC)
	{
		return default(MLOCHKHLPON<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x235C540", Offset = "0x235B340", VA = "0x18235C540")]
	public static MLOCHKHLPON<TMOutput> KHPNPLFAOMN<TMOutput, TMInput, TMNode>([In] this LMFHPFLEDNO<TMInput, TMOutput, TMNode> HLCOOGAGOEK, MLOCHKHLPON<TMNode> JPODHBJFPKM, int NGIPPLLBEKC)
	{
		return default(MLOCHKHLPON<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2506380", Offset = "0x2505180", VA = "0x182506380")]
	internal static void KIKMLOKIAPK<TMInput, TMOutput, TMNode>(this LMFHPFLEDNO<TMInput, TMOutput, TMNode> HLCOOGAGOEK, MLOCHKHLPON<TMNode> JPODHBJFPKM, MLOCHKHLPON<TMInput> DLNMELFOEGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x235C010", Offset = "0x235AE10", VA = "0x18235C010")]
	internal static void ACHOBNKIINF<TMInput, TMOutput, TMNode>(this LMFHPFLEDNO<TMInput, TMOutput, TMNode> HLCOOGAGOEK, MLOCHKHLPON<TMNode> JPODHBJFPKM, MLOCHKHLPON<TMOutput> IEHMFIJKAOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2505BB0", Offset = "0x25049B0", VA = "0x182505BB0")]
	internal static void EGABBGMKJLB<TMInput, TMOutput, TMNode>(this LMFHPFLEDNO<TMInput, TMOutput, TMNode> HLCOOGAGOEK, MLOCHKHLPON<TMNode> JPODHBJFPKM, int NGIPPLLBEKC, MLOCHKHLPON<TMInput> DLNMELFOEGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2505C00", Offset = "0x2504A00", VA = "0x182505C00")]
	internal static void FAOIFLJFAHD<TMInput, TMOutput, TMNode>(this LMFHPFLEDNO<TMInput, TMOutput, TMNode> HLCOOGAGOEK, MLOCHKHLPON<TMNode> JPODHBJFPKM, int NGIPPLLBEKC, MLOCHKHLPON<TMOutput> IEHMFIJKAOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2506380", Offset = "0x2505180", VA = "0x182506380")]
	internal static void LEKELMPHCHL<TMInput, TMOutput, TMNode>(this LMFHPFLEDNO<TMInput, TMOutput, TMNode> HLCOOGAGOEK, MLOCHKHLPON<TMNode> JPODHBJFPKM, MLOCHKHLPON<TMInput> DLNMELFOEGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x235C010", Offset = "0x235AE10", VA = "0x18235C010")]
	internal static void BDGFFALOIIH<TMInput, TMOutput, TMNode>(this LMFHPFLEDNO<TMInput, TMOutput, TMNode> HLCOOGAGOEK, MLOCHKHLPON<TMNode> JPODHBJFPKM, MLOCHKHLPON<TMOutput> IEHMFIJKAOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x25062E0", Offset = "0x25050E0", VA = "0x1825062E0")]
	public static CCOECDIADIF<MLOCHKHLPON<TMInput>>.IOEOBCPKJIE JNJCIFEIKGG<TMInput, TMOutput, TMNode>([In] this LMFHPFLEDNO<TMInput, TMOutput, TMNode> HLCOOGAGOEK, MLOCHKHLPON<TMNode> JPODHBJFPKM)
	{
		return default(CCOECDIADIF<MLOCHKHLPON<TMInput>>.IOEOBCPKJIE);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x235C0F0", Offset = "0x235AEF0", VA = "0x18235C0F0")]
	public static CCOECDIADIF<MLOCHKHLPON<TMOutput>>.IOEOBCPKJIE GICOJCIPJKC<TMOutput, TMInput, TMNode>([In] this LMFHPFLEDNO<TMInput, TMOutput, TMNode> HLCOOGAGOEK, MLOCHKHLPON<TMNode> JPODHBJFPKM)
	{
		return default(CCOECDIADIF<MLOCHKHLPON<TMOutput>>.IOEOBCPKJIE);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x25062E0", Offset = "0x25050E0", VA = "0x1825062E0")]
	public static ADFNMKADCAO<MLOCHKHLPON<TMInput>, CCOECDIADIF<MLOCHKHLPON<TMInput>>.IOEOBCPKJIE> LCHHJMAOALB<TMInput, TMOutput, TMNode>([In] this LMFHPFLEDNO<TMInput, TMOutput, TMNode> HLCOOGAGOEK, MLOCHKHLPON<TMNode> JPODHBJFPKM)
	{
		return default(ADFNMKADCAO<MLOCHKHLPON<TMInput>, CCOECDIADIF<MLOCHKHLPON<TMInput>>.IOEOBCPKJIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x235C0F0", Offset = "0x235AEF0", VA = "0x18235C0F0")]
	public static ADFNMKADCAO<MLOCHKHLPON<TMOutput>, CCOECDIADIF<MLOCHKHLPON<TMOutput>>.IOEOBCPKJIE> CGJDEDKMPKE<TMOutput, TMInput, TMNode>([In] this LMFHPFLEDNO<TMInput, TMOutput, TMNode> HLCOOGAGOEK, MLOCHKHLPON<TMNode> JPODHBJFPKM)
	{
		return default(ADFNMKADCAO<MLOCHKHLPON<TMOutput>, CCOECDIADIF<MLOCHKHLPON<TMOutput>>.IOEOBCPKJIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2506340", Offset = "0x2505140", VA = "0x182506340")]
	public static FLEJINJKMKH<MLOCHKHLPON<TMNode>, GCIMOGLIMHK<TMNode>.LNLLIBFCBJK> KFPKPCCOAJH<TMNode, TMInput, TMOutput>([In] this LMFHPFLEDNO<TMInput, TMOutput, TMNode> HLCOOGAGOEK)
	{
		return default(FLEJINJKMKH<MLOCHKHLPON<TMNode>, GCIMOGLIMHK<TMNode>.LNLLIBFCBJK>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct OANNKHCKBPE<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal GCIMOGLIMHK<TMOutput> IHDAKDIDPLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal EBPMFLLAEFM<TMOutput, MLOCHKHLPON<TMNode>> IKOILCHEKJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal EBPMFLLAEFM<TMOutput, CCOECDIADIF<MLOCHKHLPON<TMInput>>> MOHOCAHIDLF;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x35FFB90", Offset = "0x35FE990", VA = "0x1835FFB90")]
	internal OANNKHCKBPE([In] GCIMOGLIMHK<TMOutput> PEKGLIGJILL, [In] EBPMFLLAEFM<TMOutput, MLOCHKHLPON<TMNode>> GLMPGJPDLNF, [In] EBPMFLLAEFM<TMOutput, CCOECDIADIF<MLOCHKHLPON<TMInput>>> IPPPJIKJIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x35FF920", Offset = "0x35FE720", VA = "0x1835FF920")]
	internal static OANNKHCKBPE<TMInput, TMOutput, TMNode> FMIHPEHEFKO()
	{
		return default(OANNKHCKBPE<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class GFPLDJFGKAP
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x24F4CD0", Offset = "0x24F3AD0", VA = "0x1824F4CD0")]
	internal static FPCGCJEIPGM OJBJHHLKILJ<TMInput, TMOutput, TMNode>([In] this OANNKHCKBPE<TMInput, TMOutput, TMNode> HLCOOGAGOEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x24F47C0", Offset = "0x24F35C0", VA = "0x1824F47C0")]
	internal static OANNKHCKBPE<TMInput, TMOutput, TMNode> LKNPCKIALBL<TMInput, TMOutput, TMNode>(this FPCGCJEIPGM HLCOOGAGOEK)
	{
		return default(OANNKHCKBPE<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x24F45F0", Offset = "0x24F33F0", VA = "0x1824F45F0")]
	private static NIBGPHAENOG KEJLCKCGFJI<TMInput>([In] this CCOECDIADIF<MLOCHKHLPON<TMInput>> HLCOOGAGOEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x24F4370", Offset = "0x24F3170", VA = "0x1824F4370")]
	private static CCOECDIADIF<MLOCHKHLPON<TMInput>> GMCJAEMAJKO<TMInput>(this NIBGPHAENOG HLCOOGAGOEK)
	{
		return default(CCOECDIADIF<MLOCHKHLPON<TMInput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x235C3B0", Offset = "0x235B1B0", VA = "0x18235C3B0")]
	internal static void IFMJALEKMOK<TMInput, TMOutput, TMNode>(this OANNKHCKBPE<TMInput, TMOutput, TMNode> HLCOOGAGOEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x235C050", Offset = "0x235AE50", VA = "0x18235C050")]
	internal static MLOCHKHLPON<TMOutput> AJFPOFBBGPG<TMOutput, TMInput, TMNode>(this OANNKHCKBPE<TMInput, TMOutput, TMNode> HLCOOGAGOEK, MLOCHKHLPON<TMNode> JAHOBDMOOOJ)
	{
		return default(MLOCHKHLPON<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x235C320", Offset = "0x235B120", VA = "0x18235C320")]
	internal static void HCFLFLFMJJD<TMInput, TMOutput, TMNode>(this OANNKHCKBPE<TMInput, TMOutput, TMNode> HLCOOGAGOEK, MLOCHKHLPON<TMOutput> JPODHBJFPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x232DCA0", Offset = "0x232CAA0", VA = "0x18232DCA0")]
	public static bool ELLDGLBOGGN<TMInput, TMOutput, TMNode>([In] this OANNKHCKBPE<TMInput, TMOutput, TMNode> HLCOOGAGOEK, MLOCHKHLPON<TMOutput> JPODHBJFPKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x235CD60", Offset = "0x235BB60", VA = "0x18235CD60")]
	public static MLOCHKHLPON<TMNode> LOHANKDFOLL<TMNode, TMInput, TMOutput>([In] this OANNKHCKBPE<TMInput, TMOutput, TMNode> HLCOOGAGOEK, MLOCHKHLPON<TMOutput> JPODHBJFPKM)
	{
		return default(MLOCHKHLPON<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x235CD20", Offset = "0x235BB20", VA = "0x18235CD20")]
	public static int JNFNKJAOEHA<TMInput, TMOutput, TMNode>([In] this OANNKHCKBPE<TMInput, TMOutput, TMNode> HLCOOGAGOEK, MLOCHKHLPON<TMOutput> JPODHBJFPKM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x235C540", Offset = "0x235B340", VA = "0x18235C540")]
	public static MLOCHKHLPON<TMInput> HBGLHMMJLLF<TMInput, TMOutput, TMNode>([In] this OANNKHCKBPE<TMInput, TMOutput, TMNode> HLCOOGAGOEK, MLOCHKHLPON<TMOutput> JPODHBJFPKM, int NGIPPLLBEKC)
	{
		return default(MLOCHKHLPON<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x235C010", Offset = "0x235AE10", VA = "0x18235C010")]
	internal static void KIKMLOKIAPK<TMInput, TMOutput, TMNode>(this OANNKHCKBPE<TMInput, TMOutput, TMNode> HLCOOGAGOEK, MLOCHKHLPON<TMOutput> JPODHBJFPKM, MLOCHKHLPON<TMInput> DLNMELFOEGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x235C010", Offset = "0x235AE10", VA = "0x18235C010")]
	internal static void LEKELMPHCHL<TMInput, TMOutput, TMNode>(this OANNKHCKBPE<TMInput, TMOutput, TMNode> HLCOOGAGOEK, MLOCHKHLPON<TMOutput> JPODHBJFPKM, MLOCHKHLPON<TMInput> DLNMELFOEGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x235C0F0", Offset = "0x235AEF0", VA = "0x18235C0F0")]
	public static CCOECDIADIF<MLOCHKHLPON<TMInput>>.IOEOBCPKJIE JNJCIFEIKGG<TMInput, TMOutput, TMNode>([In] this OANNKHCKBPE<TMInput, TMOutput, TMNode> HLCOOGAGOEK, MLOCHKHLPON<TMOutput> JPODHBJFPKM)
	{
		return default(CCOECDIADIF<MLOCHKHLPON<TMInput>>.IOEOBCPKJIE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x235C0F0", Offset = "0x235AEF0", VA = "0x18235C0F0")]
	public static ADFNMKADCAO<MLOCHKHLPON<TMInput>, CCOECDIADIF<MLOCHKHLPON<TMInput>>.IOEOBCPKJIE> LCHHJMAOALB<TMInput, TMOutput, TMNode>([In] this OANNKHCKBPE<TMInput, TMOutput, TMNode> HLCOOGAGOEK, MLOCHKHLPON<TMOutput> JPODHBJFPKM)
	{
		return default(ADFNMKADCAO<MLOCHKHLPON<TMInput>, CCOECDIADIF<MLOCHKHLPON<TMInput>>.IOEOBCPKJIE>);
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
