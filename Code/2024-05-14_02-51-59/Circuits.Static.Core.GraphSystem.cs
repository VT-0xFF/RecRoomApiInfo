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
		[Cpp2IlInjected.Address(RVA = "0x7EC840", Offset = "0x7EB240", VA = "0x1807EC840")]
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
		[Cpp2IlInjected.Address(RVA = "0x1E89D70", Offset = "0x1E88770", VA = "0x181E89D70")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7ED890", Offset = "0x7EC290", VA = "0x1807ED890")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7ED8D0", Offset = "0x7EC2D0", VA = "0x1807ED8D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct KGEMOAPDHJG<TMInput, TMOutput, TMNode> : IEnumerator<BOLDNJBHEHG<TMNode>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private ECKOOBKOBMB<TMInput, TMOutput, TMNode> BGBBAFPJHOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NLLAAOGPNAB<TMInput, TMOutput, TMNode> PJHKLABANGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private bool EFLCHMOFBCO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public readonly BOLDNJBHEHG<TMNode> EIIOCLGDIGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3D66570", Offset = "0x3D64F70", VA = "0x183D66570", Slot = "4")]
		get
		{
			return default(BOLDNJBHEHG<TMNode>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3D66420", Offset = "0x3D64E20", VA = "0x183D66420", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3D664A0", Offset = "0x3D64EA0", VA = "0x183D664A0")]
	internal KGEMOAPDHJG([In] ECKOOBKOBMB<TMInput, TMOutput, TMNode> AIKCMNCNCGJ, [In] NLLAAOGPNAB<TMInput, TMOutput, TMNode> NBJDADLKNJM, bool CMBBPAHHAPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3D662E0", Offset = "0x3D64CE0", VA = "0x183D662E0", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3D663A0", Offset = "0x3D64DA0", VA = "0x183D663A0", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3D66270", Offset = "0x3D64C70", VA = "0x183D66270", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class EECPLPBLILD
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2803670", Offset = "0x2802070", VA = "0x182803670")]
	public static KGEMOAPDHJG<TMInput, TMOutput, TMNode> OLCPJHCMOKI<TMInput, TMOutput, TMNode>([In] LHCNCCGNPLL<TMInput, TMOutput, TMNode> LAPKMHLIDBN, BOLDNJBHEHG<TMNode> BKJEPPHMINA)
	{
		return default(KGEMOAPDHJG<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct NLLAAOGPNAB<TMInput, TMOutput, TMNode> : IEnumerator<BOLDNJBHEHG<TMInput>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private IBNIMOLHAKB<BOLDNJBHEHG<TMOutput>>.BNEHJDGMJED DHPOOPHLMDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private IBNIMOLHAKB<BOLDNJBHEHG<TMInput>>.BNEHJDGMJED GAMEOCHKCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly GEAGLNBIIMK<TMInput, TMOutput, TMNode> DIDELCKIMNB;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public BOLDNJBHEHG<TMInput> EIIOCLGDIGI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x34D4290", Offset = "0x34D2C90", VA = "0x1834D4290", Slot = "4")]
		get
		{
			return default(BOLDNJBHEHG<TMInput>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x34D4170", Offset = "0x34D2B70", VA = "0x1834D4170", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x34D4210", Offset = "0x34D2C10", VA = "0x1834D4210")]
	internal NLLAAOGPNAB([In] IBNIMOLHAKB<BOLDNJBHEHG<TMOutput>>.BNEHJDGMJED AMILAIGONBG, [In] IBNIMOLHAKB<BOLDNJBHEHG<TMInput>>.BNEHJDGMJED HINGJIBHAGH, [In] GEAGLNBIIMK<TMInput, TMOutput, TMNode> LBGLMGPKEFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x34D3FB0", Offset = "0x34D29B0", VA = "0x1834D3FB0", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x34D4100", Offset = "0x34D2B00", VA = "0x1834D4100", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x34D3F40", Offset = "0x34D2940", VA = "0x1834D3F40", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class KIJIJNGCBMG
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x29C7F40", Offset = "0x29C6940", VA = "0x1829C7F40")]
	public static NLLAAOGPNAB<TMInput, TMOutput, TMNode> OLCPJHCMOKI<TMInput, TMOutput, TMNode>([In] LHCNCCGNPLL<TMInput, TMOutput, TMNode> LAPKMHLIDBN, BOLDNJBHEHG<TMNode> BKJEPPHMINA)
	{
		return default(NLLAAOGPNAB<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct ECKOOBKOBMB<TMInput, TMOutput, TMNode> : IEnumerator<BOLDNJBHEHG<TMOutput>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private IBNIMOLHAKB<BOLDNJBHEHG<TMInput>>.BNEHJDGMJED JGDMLELALLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private IBNIMOLHAKB<BOLDNJBHEHG<TMOutput>>.BNEHJDGMJED LJPMOJGCMEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly HDOJFPGJAJK<TMInput, TMOutput, TMNode> MAPCOCJAFAF;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public BOLDNJBHEHG<TMOutput> EIIOCLGDIGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x34D4290", Offset = "0x34D2C90", VA = "0x1834D4290", Slot = "4")]
		get
		{
			return default(BOLDNJBHEHG<TMOutput>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x34D4170", Offset = "0x34D2B70", VA = "0x1834D4170", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x34D4210", Offset = "0x34D2C10", VA = "0x1834D4210")]
	internal ECKOOBKOBMB([In] IBNIMOLHAKB<BOLDNJBHEHG<TMInput>>.BNEHJDGMJED FMDCOHPKKEI, [In] IBNIMOLHAKB<BOLDNJBHEHG<TMOutput>>.BNEHJDGMJED LMBMMPBDHGO, [In] HDOJFPGJAJK<TMInput, TMOutput, TMNode> IPKJGKJIJFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x34D3FB0", Offset = "0x34D29B0", VA = "0x1834D3FB0", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x34D4100", Offset = "0x34D2B00", VA = "0x1834D4100", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x34D3F40", Offset = "0x34D2940", VA = "0x1834D3F40", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class NCJJLMNBOPA
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2A7CA10", Offset = "0x2A7B410", VA = "0x182A7CA10")]
	public static ECKOOBKOBMB<TMInput, TMOutput, TMNode> OLCPJHCMOKI<TMInput, TMOutput, TMNode>([In] LHCNCCGNPLL<TMInput, TMOutput, TMNode> LAPKMHLIDBN, BOLDNJBHEHG<TMNode> BKJEPPHMINA)
	{
		return default(ECKOOBKOBMB<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct LHCNCCGNPLL<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public HDOJFPGJAJK<TMInput, TMOutput, TMNode> CNDGPAMNPOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public GEAGLNBIIMK<TMInput, TMOutput, TMNode> IEAEIKICIPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public PDCAPJEJLLP<TMInput, TMOutput, TMNode> ABHOMLHBHPE;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3E40170", Offset = "0x3E3EB70", VA = "0x183E40170")]
	internal LHCNCCGNPLL([In] HDOJFPGJAJK<TMInput, TMOutput, TMNode> IPKJGKJIJFL, [In] GEAGLNBIIMK<TMInput, TMOutput, TMNode> LBGLMGPKEFM, [In] PDCAPJEJLLP<TMInput, TMOutput, TMNode> LIEEJLODPGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3E3FED0", Offset = "0x3E3E8D0", VA = "0x183E3FED0")]
	public static LHCNCCGNPLL<TMInput?, TMOutput?, TMNode?> OLCPJHCMOKI()
	{
		return default(LHCNCCGNPLL<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class JKJMOGEGCJA
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x29A27C0", Offset = "0x29A11C0", VA = "0x1829A27C0")]
	public static NAJPFBCDOPF? BOALAEMEPIG<TMInput, TMOutput, TMNode>([In] this LHCNCCGNPLL<TMInput, TMOutput, TMNode> CMJEIEIDHIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x29A2FF0", Offset = "0x29A19F0", VA = "0x1829A2FF0")]
	public static LHCNCCGNPLL<TMInput?, TMOutput?, TMNode?> HIBHLHEFCGJ<TMInput, TMOutput, TMNode>(this NAJPFBCDOPF CMJEIEIDHIK)
	{
		return default(LHCNCCGNPLL<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x29A3580", Offset = "0x29A1F80", VA = "0x1829A3580")]
	public static void KDNFCEDEOOI<TMInput, TMOutput, TMNode>(this LHCNCCGNPLL<TMInput, TMOutput, TMNode> CMJEIEIDHIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x29A3830", Offset = "0x29A2230", VA = "0x1829A3830")]
	public static void NIPJACBEFNB<TMInput, TMOutput, TMNode>(this LHCNCCGNPLL<TMInput, TMOutput, TMNode> CMJEIEIDHIK, BOLDNJBHEHG<TMOutput> DIMCALCGNNN, BOLDNJBHEHG<TMInput> NONNOOALJOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x29A3890", Offset = "0x29A2290", VA = "0x1829A3890")]
	public static void PHOOIMIAHCE<TMInput, TMOutput, TMNode>(this LHCNCCGNPLL<TMInput, TMOutput, TMNode> CMJEIEIDHIK, BOLDNJBHEHG<TMOutput> DIMCALCGNNN, BOLDNJBHEHG<TMInput> NONNOOALJOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x29A2EC0", Offset = "0x29A18C0", VA = "0x1829A2EC0")]
	public static int HFMJFJABNDF<TMInput, TMOutput, TMNode>([In] this LHCNCCGNPLL<TMInput, TMOutput, TMNode> CMJEIEIDHIK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x29A2AA0", Offset = "0x29A14A0", VA = "0x1829A2AA0")]
	public static bool DAIGOPOGKMM<TMInput, TMOutput, TMNode>([In] this LHCNCCGNPLL<TMInput, TMOutput, TMNode> CMJEIEIDHIK, BOLDNJBHEHG<TMOutput> DIMCALCGNNN, BOLDNJBHEHG<TMInput> NONNOOALJOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x29A34E0", Offset = "0x29A1EE0", VA = "0x1829A34E0")]
	public static bool IHBEFHPHPBJ<TMInput, TMOutput, TMNode>([In] this LHCNCCGNPLL<TMInput, TMOutput, TMNode> CMJEIEIDHIK, BOLDNJBHEHG<TMOutput> APBJDOEDEDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x29A3810", Offset = "0x29A2210", VA = "0x1829A3810")]
	public static bool NBOPMMLDJIK<TMInput, TMOutput, TMNode>([In] this LHCNCCGNPLL<TMInput, TMOutput, TMNode> CMJEIEIDHIK, BOLDNJBHEHG<TMInput> APBJDOEDEDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x29A3450", Offset = "0x29A1E50", VA = "0x1829A3450")]
	public static BOLDNJBHEHG<TMNode?> IBPKIONIDJK<TMNode, TMInput, TMOutput>(this LHCNCCGNPLL<TMInput, TMOutput, TMNode> CMJEIEIDHIK)
	{
		return default(BOLDNJBHEHG<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x29A3700", Offset = "0x29A2100", VA = "0x1829A3700")]
	public static void NBCEEOBLHPM<TMInput, TMOutput, TMNode>(this LHCNCCGNPLL<TMInput, TMOutput, TMNode> CMJEIEIDHIK, BOLDNJBHEHG<TMNode> BKJEPPHMINA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x29A3510", Offset = "0x29A1F10", VA = "0x1829A3510")]
	public static BOLDNJBHEHG<TMInput?> JKFFIFGDNBK<TMInput, TMOutput, TMNode>(this LHCNCCGNPLL<TMInput, TMOutput, TMNode> CMJEIEIDHIK, BOLDNJBHEHG<TMNode> BKJEPPHMINA)
	{
		return default(BOLDNJBHEHG<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x29A2C20", Offset = "0x29A1620", VA = "0x1829A2C20")]
	public static BOLDNJBHEHG<TMOutput?> EFCAMKJPIPI<TMOutput, TMInput, TMNode>(this LHCNCCGNPLL<TMInput, TMOutput, TMNode> CMJEIEIDHIK, BOLDNJBHEHG<TMNode> BKJEPPHMINA)
	{
		return default(BOLDNJBHEHG<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x29A2E40", Offset = "0x29A1840", VA = "0x1829A2E40")]
	public static BOLDNJBHEHG<TMInput?> HFCFBAJKDPL<TMInput, TMOutput, TMNode>(this LHCNCCGNPLL<TMInput, TMOutput, TMNode> CMJEIEIDHIK, BOLDNJBHEHG<TMNode> BKJEPPHMINA, int ABBNIPHGMGH)
	{
		return default(BOLDNJBHEHG<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x29A35E0", Offset = "0x29A1FE0", VA = "0x1829A35E0")]
	public static BOLDNJBHEHG<TMOutput?> KEEAMAKDEHG<TMOutput, TMInput, TMNode>(this LHCNCCGNPLL<TMInput, TMOutput, TMNode> CMJEIEIDHIK, BOLDNJBHEHG<TMNode> BKJEPPHMINA, int ABBNIPHGMGH)
	{
		return default(BOLDNJBHEHG<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x29A2DA0", Offset = "0x29A17A0", VA = "0x1829A2DA0")]
	public static void GAGDBFBFAKM<TMInput, TMOutput, TMNode>(this LHCNCCGNPLL<TMInput, TMOutput, TMNode> CMJEIEIDHIK, BOLDNJBHEHG<TMNode> BKJEPPHMINA, int LJAJINEOPOC, int LMDNAEDNFOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x29A3660", Offset = "0x29A2060", VA = "0x1829A3660")]
	public static void MNPBONFPPOE<TMInput, TMOutput, TMNode>(this LHCNCCGNPLL<TMInput, TMOutput, TMNode> CMJEIEIDHIK, BOLDNJBHEHG<TMNode> BKJEPPHMINA, int LJAJINEOPOC, int LMDNAEDNFOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x29A3360", Offset = "0x29A1D60", VA = "0x1829A3360")]
	public static void IBLNJJNOFLI<TMInput, TMOutput, TMNode>(this LHCNCCGNPLL<TMInput, TMOutput, TMNode> CMJEIEIDHIK, BOLDNJBHEHG<TMInput> AALGEDLKPBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x29A26E0", Offset = "0x29A10E0", VA = "0x1829A26E0")]
	public static void AJNFIMIMAKF<TMInput, TMOutput, TMNode>(this LHCNCCGNPLL<TMInput, TMOutput, TMNode> CMJEIEIDHIK, BOLDNJBHEHG<TMOutput> PPBIEIMLFDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x830920", Offset = "0x82F320", VA = "0x180830920")]
	public static AEENLOLBCAP<TMInput?> OKKJOLFBMPO<TMInput, TMOutput, TMNode>([In] this LHCNCCGNPLL<TMInput, TMOutput, TMNode> CMJEIEIDHIK)
	{
		return default(AEENLOLBCAP<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x1EBD130", Offset = "0x1EBBB30", VA = "0x181EBD130")]
	public static AEENLOLBCAP<TMOutput?> PBJGNLKEDEB<TMOutput, TMInput, TMNode>([In] this LHCNCCGNPLL<TMInput, TMOutput, TMNode> CMJEIEIDHIK)
	{
		return default(AEENLOLBCAP<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1EBC310", Offset = "0x1EBAD10", VA = "0x181EBC310")]
	public static AEENLOLBCAP<TMNode?> HBDNEOKBBPB<TMNode, TMInput, TMOutput>([In] this LHCNCCGNPLL<TMInput, TMOutput, TMNode> CMJEIEIDHIK)
	{
		return default(AEENLOLBCAP<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x29A28A0", Offset = "0x29A12A0", VA = "0x1829A28A0")]
	public static NLLAAOGPNAB<TMInput?, TMOutput?, TMNode?> CGPABLJEEHP<TMInput, TMOutput, TMNode>([In] this LHCNCCGNPLL<TMInput, TMOutput, TMNode> CMJEIEIDHIK, BOLDNJBHEHG<TMNode> MCGNHGLIJDN)
	{
		return default(NLLAAOGPNAB<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x29A28A0", Offset = "0x29A12A0", VA = "0x1829A28A0")]
	public static ECKOOBKOBMB<TMInput?, TMOutput?, TMNode?> LHDCGBDPDMN<TMInput, TMOutput, TMNode>([In] this LHCNCCGNPLL<TMInput, TMOutput, TMNode> CMJEIEIDHIK, BOLDNJBHEHG<TMNode> MCGNHGLIJDN)
	{
		return default(ECKOOBKOBMB<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x29A2B70", Offset = "0x29A1570", VA = "0x1829A2B70")]
	public static KGEMOAPDHJG<TMInput?, TMOutput?, TMNode?> DJNFPPMGGII<TMInput, TMOutput, TMNode>([In] this LHCNCCGNPLL<TMInput, TMOutput, TMNode> CMJEIEIDHIK, BOLDNJBHEHG<TMNode> MCGNHGLIJDN)
	{
		return default(KGEMOAPDHJG<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x29A2C90", Offset = "0x29A1690", VA = "0x1829A2C90")]
	public static KCAPEONJHAG<BOLDNJBHEHG<TMInput?>, NLLAAOGPNAB<TMInput?, TMOutput?, TMNode?>> FNGHHFKJLKB<TMInput, TMOutput, TMNode>([In] this LHCNCCGNPLL<TMInput, TMOutput, TMNode> CMJEIEIDHIK, BOLDNJBHEHG<TMNode> MCGNHGLIJDN)
	{
		return default(KCAPEONJHAG<BOLDNJBHEHG<TMInput>, NLLAAOGPNAB<TMInput, TMOutput, TMNode>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x29A2910", Offset = "0x29A1310", VA = "0x1829A2910")]
	public static KCAPEONJHAG<BOLDNJBHEHG<TMNode?>, KGEMOAPDHJG<TMInput?, TMOutput?, TMNode?>> CMJNAHGMGPJ<TMNode, TMInput, TMOutput>([In] this LHCNCCGNPLL<TMInput, TMOutput, TMNode> CMJEIEIDHIK, BOLDNJBHEHG<TMNode> MCGNHGLIJDN)
	{
		return default(KCAPEONJHAG<BOLDNJBHEHG<TMNode>, KGEMOAPDHJG<TMInput, TMOutput, TMNode>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct HDOJFPGJAJK<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal AEENLOLBCAP<TMInput> AAEGGJNKBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	internal OFAEMLPJBAC<TMInput, BOLDNJBHEHG<TMNode>> KCPNNMEKIFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal OFAEMLPJBAC<TMInput, IBNIMOLHAKB<BOLDNJBHEHG<TMOutput>>> DIDELCKIMNB;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3960880", Offset = "0x395F280", VA = "0x183960880")]
	internal HDOJFPGJAJK([In] AEENLOLBCAP<TMInput> GEKMOPKEHNH, [In] OFAEMLPJBAC<TMInput, BOLDNJBHEHG<TMNode>> LIEEJLODPGN, [In] OFAEMLPJBAC<TMInput, IBNIMOLHAKB<BOLDNJBHEHG<TMOutput>>> LBGLMGPKEFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x39606D0", Offset = "0x395F0D0", VA = "0x1839606D0")]
	internal static HDOJFPGJAJK<TMInput, TMOutput, TMNode> OLCPJHCMOKI()
	{
		return default(HDOJFPGJAJK<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class BDNHLMJGBCC
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x27165E0", Offset = "0x2714FE0", VA = "0x1827165E0")]
	internal static EJNAFHPFEGB BOALAEMEPIG<TMInput, TMOutput, TMNode>([In] this HDOJFPGJAJK<TMInput, TMOutput, TMNode> CMJEIEIDHIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2716AC0", Offset = "0x27154C0", VA = "0x182716AC0")]
	internal static HDOJFPGJAJK<TMInput, TMOutput, TMNode> HIBHLHEFCGJ<TMInput, TMOutput, TMNode>(this EJNAFHPFEGB CMJEIEIDHIK)
	{
		return default(HDOJFPGJAJK<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2717510", Offset = "0x2715F10", VA = "0x182717510")]
	private static GAFCFHLMMGE MLHBMOLHCKB<TMOutput>([In] this IBNIMOLHAKB<BOLDNJBHEHG<TMOutput>> CMJEIEIDHIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2716FD0", Offset = "0x27159D0", VA = "0x182716FD0")]
	private static IBNIMOLHAKB<BOLDNJBHEHG<TMOutput>> IPEFMFLNCDP<TMOutput>(this GAFCFHLMMGE CMJEIEIDHIK)
	{
		return default(IBNIMOLHAKB<BOLDNJBHEHG<TMOutput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2717250", Offset = "0x2715C50", VA = "0x182717250")]
	internal static void KDNFCEDEOOI<TMInput, TMOutput, TMNode>(this HDOJFPGJAJK<TMInput, TMOutput, TMNode> CMJEIEIDHIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2717430", Offset = "0x2715E30", VA = "0x182717430")]
	internal static BOLDNJBHEHG<TMInput> LCEGNCFNECM<TMInput, TMOutput, TMNode>(this HDOJFPGJAJK<TMInput, TMOutput, TMNode> CMJEIEIDHIK, BOLDNJBHEHG<TMNode> KDIAAEPKAII)
	{
		return default(BOLDNJBHEHG<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2716A10", Offset = "0x2715410", VA = "0x182716A10")]
	internal static void DMFHFELNIKK<TMInput, TMOutput, TMNode>(this HDOJFPGJAJK<TMInput, TMOutput, TMNode> CMJEIEIDHIK, BOLDNJBHEHG<TMInput> MCGNHGLIJDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2716AA0", Offset = "0x27154A0", VA = "0x182716AA0")]
	public static bool FPGLOIPLKJL<TMInput, TMOutput, TMNode>([In] this HDOJFPGJAJK<TMInput, TMOutput, TMNode> CMJEIEIDHIK, BOLDNJBHEHG<TMInput> MCGNHGLIJDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2715B40", Offset = "0x2714540", VA = "0x182715B40")]
	public static int LABFIHOGEOB<TMInput, TMOutput, TMNode>([In] this HDOJFPGJAJK<TMInput, TMOutput, TMNode> CMJEIEIDHIK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2716970", Offset = "0x2715370", VA = "0x182716970")]
	public static BOLDNJBHEHG<TMNode> CDGKDNIBGHB<TMNode, TMInput, TMOutput>([In] this HDOJFPGJAJK<TMInput, TMOutput, TMNode> CMJEIEIDHIK, BOLDNJBHEHG<TMInput> MCGNHGLIJDN)
	{
		return default(BOLDNJBHEHG<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x27174D0", Offset = "0x2715ED0", VA = "0x1827174D0")]
	public static int LOACMBECJLC<TMInput, TMOutput, TMNode>([In] this HDOJFPGJAJK<TMInput, TMOutput, TMNode> CMJEIEIDHIK, BOLDNJBHEHG<TMInput> MCGNHGLIJDN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x27173E0", Offset = "0x2715DE0", VA = "0x1827173E0")]
	public static BOLDNJBHEHG<TMOutput> KEPNHBDPFBP<TMOutput, TMInput, TMNode>([In] this HDOJFPGJAJK<TMInput, TMOutput, TMNode> CMJEIEIDHIK, BOLDNJBHEHG<TMInput> MCGNHGLIJDN, int ABBNIPHGMGH)
	{
		return default(BOLDNJBHEHG<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x27169D0", Offset = "0x27153D0", VA = "0x1827169D0")]
	internal static void HCBFIJIJJPK<TMInput, TMOutput, TMNode>(this HDOJFPGJAJK<TMInput, TMOutput, TMNode> CMJEIEIDHIK, BOLDNJBHEHG<TMInput> MCGNHGLIJDN, BOLDNJBHEHG<TMOutput> PPBIEIMLFDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x27169D0", Offset = "0x27153D0", VA = "0x1827169D0")]
	internal static void DLNCLKEAHOA<TMInput, TMOutput, TMNode>(this HDOJFPGJAJK<TMInput, TMOutput, TMNode> CMJEIEIDHIK, BOLDNJBHEHG<TMInput> MCGNHGLIJDN, BOLDNJBHEHG<TMOutput> PPBIEIMLFDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2716580", Offset = "0x2714F80", VA = "0x182716580")]
	public static IBNIMOLHAKB<BOLDNJBHEHG<TMOutput>>.BNEHJDGMJED ONJKGMMODAG<TMOutput, TMInput, TMNode>([In] this HDOJFPGJAJK<TMInput, TMOutput, TMNode> CMJEIEIDHIK, BOLDNJBHEHG<TMInput> MCGNHGLIJDN)
	{
		return default(IBNIMOLHAKB<BOLDNJBHEHG<TMOutput>>.BNEHJDGMJED);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2716580", Offset = "0x2714F80", VA = "0x182716580")]
	public static BEJAEPGKCAL<BOLDNJBHEHG<TMOutput>, IBNIMOLHAKB<BOLDNJBHEHG<TMOutput>>.BNEHJDGMJED> BILBMDJJKHP<TMOutput, TMInput, TMNode>([In] this HDOJFPGJAJK<TMInput, TMOutput, TMNode> CMJEIEIDHIK, BOLDNJBHEHG<TMInput> MCGNHGLIJDN)
	{
		return default(BEJAEPGKCAL<BOLDNJBHEHG<TMOutput>, IBNIMOLHAKB<BOLDNJBHEHG<TMOutput>>.BNEHJDGMJED>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2716990", Offset = "0x2715390", VA = "0x182716990")]
	public static KCAPEONJHAG<BOLDNJBHEHG<TMInput>, AEENLOLBCAP<TMInput>.MLOCICOAGFL> CIFPILBGCKN<TMInput, TMOutput, TMNode>([In] this HDOJFPGJAJK<TMInput, TMOutput, TMNode> CMJEIEIDHIK)
	{
		return default(KCAPEONJHAG<BOLDNJBHEHG<TMInput>, AEENLOLBCAP<TMInput>.MLOCICOAGFL>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct PDCAPJEJLLP<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal AEENLOLBCAP<TMNode> AAEGGJNKBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal OFAEMLPJBAC<TMNode, IBNIMOLHAKB<BOLDNJBHEHG<TMInput>>> MAPCOCJAFAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal OFAEMLPJBAC<TMNode, IBNIMOLHAKB<BOLDNJBHEHG<TMOutput>>> DIDELCKIMNB;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3960880", Offset = "0x395F280", VA = "0x183960880")]
	internal PDCAPJEJLLP([In] AEENLOLBCAP<TMNode> GEKMOPKEHNH, [In] OFAEMLPJBAC<TMNode, IBNIMOLHAKB<BOLDNJBHEHG<TMInput>>> IPKJGKJIJFL, [In] OFAEMLPJBAC<TMNode, IBNIMOLHAKB<BOLDNJBHEHG<TMOutput>>> LBGLMGPKEFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x39606D0", Offset = "0x395F0D0", VA = "0x1839606D0")]
	internal static PDCAPJEJLLP<TMInput, TMOutput, TMNode> OLCPJHCMOKI()
	{
		return default(PDCAPJEJLLP<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class ININOLEMMJO
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2985D40", Offset = "0x2984740", VA = "0x182985D40")]
	internal static BNKAEABGAHA BOALAEMEPIG<TMInput, TMOutput, TMNode>([In] this PDCAPJEJLLP<TMInput, TMOutput, TMNode> CMJEIEIDHIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x29862B0", Offset = "0x2984CB0", VA = "0x1829862B0")]
	internal static PDCAPJEJLLP<TMInput, TMOutput, TMNode> HIBHLHEFCGJ<TMInput, TMOutput, TMNode>(this BNKAEABGAHA CMJEIEIDHIK)
	{
		return default(PDCAPJEJLLP<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2986AD0", Offset = "0x29854D0", VA = "0x182986AD0")]
	private static CFBACAHOCLG KAEIGINEMAC<TMInput>([In] this IBNIMOLHAKB<BOLDNJBHEHG<TMInput>> CMJEIEIDHIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2986FF0", Offset = "0x29859F0", VA = "0x182986FF0")]
	private static IBNIMOLHAKB<BOLDNJBHEHG<TMInput>> LJJPKFCIFFK<TMInput>(this CFBACAHOCLG CMJEIEIDHIK)
	{
		return default(IBNIMOLHAKB<BOLDNJBHEHG<TMInput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x29872C0", Offset = "0x2985CC0", VA = "0x1829872C0")]
	private static JIENKKJALHF MOHHHBCOMFE<TMOutput>([In] this IBNIMOLHAKB<BOLDNJBHEHG<TMOutput>> CMJEIEIDHIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2986800", Offset = "0x2985200", VA = "0x182986800")]
	private static IBNIMOLHAKB<BOLDNJBHEHG<TMOutput>> ILFAGINDEFO<TMOutput>(this JIENKKJALHF CMJEIEIDHIK)
	{
		return default(IBNIMOLHAKB<BOLDNJBHEHG<TMOutput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2986CA0", Offset = "0x29856A0", VA = "0x182986CA0")]
	internal static void KDNFCEDEOOI<TMInput, TMOutput, TMNode>(this PDCAPJEJLLP<TMInput, TMOutput, TMNode> CMJEIEIDHIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2986F60", Offset = "0x2985960", VA = "0x182986F60")]
	internal static BOLDNJBHEHG<TMNode> LCEGNCFNECM<TMNode, TMInput, TMOutput>(this PDCAPJEJLLP<TMInput, TMOutput, TMNode> CMJEIEIDHIK, [In] IBNIMOLHAKB<BOLDNJBHEHG<TMInput>> IPKJGKJIJFL, [In] IBNIMOLHAKB<BOLDNJBHEHG<TMOutput>> LBGLMGPKEFM)
	{
		return default(BOLDNJBHEHG<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x29861B0", Offset = "0x2984BB0", VA = "0x1829861B0")]
	internal static void DMFHFELNIKK<TMInput, TMOutput, TMNode>(this PDCAPJEJLLP<TMInput, TMOutput, TMNode> CMJEIEIDHIK, BOLDNJBHEHG<TMNode> MCGNHGLIJDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2716AA0", Offset = "0x27154A0", VA = "0x182716AA0")]
	public static bool FPGLOIPLKJL<TMInput, TMOutput, TMNode>([In] this PDCAPJEJLLP<TMInput, TMOutput, TMNode> CMJEIEIDHIK, BOLDNJBHEHG<TMNode> MCGNHGLIJDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2715B40", Offset = "0x2714540", VA = "0x182715B40")]
	public static int LABFIHOGEOB<TMInput, TMOutput, TMNode>([In] this PDCAPJEJLLP<TMInput, TMOutput, TMNode> CMJEIEIDHIK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2986270", Offset = "0x2984C70", VA = "0x182986270")]
	public static int HBLAAMLKLLI<TMInput, TMOutput, TMNode>([In] this PDCAPJEJLLP<TMInput, TMOutput, TMNode> CMJEIEIDHIK, BOLDNJBHEHG<TMNode> MCGNHGLIJDN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x27174D0", Offset = "0x2715ED0", VA = "0x1827174D0")]
	public static int LOACMBECJLC<TMInput, TMOutput, TMNode>([In] this PDCAPJEJLLP<TMInput, TMOutput, TMNode> CMJEIEIDHIK, BOLDNJBHEHG<TMNode> MCGNHGLIJDN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2986A80", Offset = "0x2985480", VA = "0x182986A80")]
	public static BOLDNJBHEHG<TMInput> JEFAIHJBLHB<TMInput, TMOutput, TMNode>([In] this PDCAPJEJLLP<TMInput, TMOutput, TMNode> CMJEIEIDHIK, BOLDNJBHEHG<TMNode> MCGNHGLIJDN, int ABBNIPHGMGH)
	{
		return default(BOLDNJBHEHG<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x27173E0", Offset = "0x2715DE0", VA = "0x1827173E0")]
	public static BOLDNJBHEHG<TMOutput> KEPNHBDPFBP<TMOutput, TMInput, TMNode>([In] this PDCAPJEJLLP<TMInput, TMOutput, TMNode> CMJEIEIDHIK, BOLDNJBHEHG<TMNode> MCGNHGLIJDN, int ABBNIPHGMGH)
	{
		return default(BOLDNJBHEHG<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x29867C0", Offset = "0x29851C0", VA = "0x1829867C0")]
	internal static void HLMBMLGEAOF<TMInput, TMOutput, TMNode>(this PDCAPJEJLLP<TMInput, TMOutput, TMNode> CMJEIEIDHIK, BOLDNJBHEHG<TMNode> MCGNHGLIJDN, BOLDNJBHEHG<TMInput> AALGEDLKPBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x27169D0", Offset = "0x27153D0", VA = "0x1827169D0")]
	internal static void HCBFIJIJJPK<TMInput, TMOutput, TMNode>(this PDCAPJEJLLP<TMInput, TMOutput, TMNode> CMJEIEIDHIK, BOLDNJBHEHG<TMNode> MCGNHGLIJDN, BOLDNJBHEHG<TMOutput> PPBIEIMLFDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2986160", Offset = "0x2984B60", VA = "0x182986160")]
	internal static void DKGDFECAPIE<TMInput, TMOutput, TMNode>(this PDCAPJEJLLP<TMInput, TMOutput, TMNode> CMJEIEIDHIK, BOLDNJBHEHG<TMNode> MCGNHGLIJDN, int ABBNIPHGMGH, BOLDNJBHEHG<TMInput> AALGEDLKPBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2987270", Offset = "0x2985C70", VA = "0x182987270")]
	internal static void MHDANCBGIAH<TMInput, TMOutput, TMNode>(this PDCAPJEJLLP<TMInput, TMOutput, TMNode> CMJEIEIDHIK, BOLDNJBHEHG<TMNode> MCGNHGLIJDN, int ABBNIPHGMGH, BOLDNJBHEHG<TMOutput> PPBIEIMLFDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x29867C0", Offset = "0x29851C0", VA = "0x1829867C0")]
	internal static void PDJFJKEMLPG<TMInput, TMOutput, TMNode>(this PDCAPJEJLLP<TMInput, TMOutput, TMNode> CMJEIEIDHIK, BOLDNJBHEHG<TMNode> MCGNHGLIJDN, BOLDNJBHEHG<TMInput> AALGEDLKPBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x27169D0", Offset = "0x27153D0", VA = "0x1827169D0")]
	internal static void DLNCLKEAHOA<TMInput, TMOutput, TMNode>(this PDCAPJEJLLP<TMInput, TMOutput, TMNode> CMJEIEIDHIK, BOLDNJBHEHG<TMNode> MCGNHGLIJDN, BOLDNJBHEHG<TMOutput> PPBIEIMLFDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2986100", Offset = "0x2984B00", VA = "0x182986100")]
	public static IBNIMOLHAKB<BOLDNJBHEHG<TMInput>>.BNEHJDGMJED OEOAHAOHFNC<TMInput, TMOutput, TMNode>([In] this PDCAPJEJLLP<TMInput, TMOutput, TMNode> CMJEIEIDHIK, BOLDNJBHEHG<TMNode> MCGNHGLIJDN)
	{
		return default(IBNIMOLHAKB<BOLDNJBHEHG<TMInput>>.BNEHJDGMJED);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2716580", Offset = "0x2714F80", VA = "0x182716580")]
	public static IBNIMOLHAKB<BOLDNJBHEHG<TMOutput>>.BNEHJDGMJED ONJKGMMODAG<TMOutput, TMInput, TMNode>([In] this PDCAPJEJLLP<TMInput, TMOutput, TMNode> CMJEIEIDHIK, BOLDNJBHEHG<TMNode> MCGNHGLIJDN)
	{
		return default(IBNIMOLHAKB<BOLDNJBHEHG<TMOutput>>.BNEHJDGMJED);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2986100", Offset = "0x2984B00", VA = "0x182986100")]
	public static BEJAEPGKCAL<BOLDNJBHEHG<TMInput>, IBNIMOLHAKB<BOLDNJBHEHG<TMInput>>.BNEHJDGMJED> DFFOJKLPCIK<TMInput, TMOutput, TMNode>([In] this PDCAPJEJLLP<TMInput, TMOutput, TMNode> CMJEIEIDHIK, BOLDNJBHEHG<TMNode> MCGNHGLIJDN)
	{
		return default(BEJAEPGKCAL<BOLDNJBHEHG<TMInput>, IBNIMOLHAKB<BOLDNJBHEHG<TMInput>>.BNEHJDGMJED>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2716580", Offset = "0x2714F80", VA = "0x182716580")]
	public static BEJAEPGKCAL<BOLDNJBHEHG<TMOutput>, IBNIMOLHAKB<BOLDNJBHEHG<TMOutput>>.BNEHJDGMJED> BILBMDJJKHP<TMOutput, TMInput, TMNode>([In] this PDCAPJEJLLP<TMInput, TMOutput, TMNode> CMJEIEIDHIK, BOLDNJBHEHG<TMNode> MCGNHGLIJDN)
	{
		return default(BEJAEPGKCAL<BOLDNJBHEHG<TMOutput>, IBNIMOLHAKB<BOLDNJBHEHG<TMOutput>>.BNEHJDGMJED>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2716990", Offset = "0x2715390", VA = "0x182716990")]
	public static KCAPEONJHAG<BOLDNJBHEHG<TMNode>, AEENLOLBCAP<TMNode>.MLOCICOAGFL> CIFPILBGCKN<TMNode, TMInput, TMOutput>([In] this PDCAPJEJLLP<TMInput, TMOutput, TMNode> CMJEIEIDHIK)
	{
		return default(KCAPEONJHAG<BOLDNJBHEHG<TMNode>, AEENLOLBCAP<TMNode>.MLOCICOAGFL>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct GEAGLNBIIMK<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal AEENLOLBCAP<TMOutput> AAEGGJNKBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal OFAEMLPJBAC<TMOutput, BOLDNJBHEHG<TMNode>> KCPNNMEKIFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal OFAEMLPJBAC<TMOutput, IBNIMOLHAKB<BOLDNJBHEHG<TMInput>>> MAPCOCJAFAF;

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3960880", Offset = "0x395F280", VA = "0x183960880")]
	internal GEAGLNBIIMK([In] AEENLOLBCAP<TMOutput> GEKMOPKEHNH, [In] OFAEMLPJBAC<TMOutput, BOLDNJBHEHG<TMNode>> LIEEJLODPGN, [In] OFAEMLPJBAC<TMOutput, IBNIMOLHAKB<BOLDNJBHEHG<TMInput>>> IPKJGKJIJFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x39606D0", Offset = "0x395F0D0", VA = "0x1839606D0")]
	internal static GEAGLNBIIMK<TMInput, TMOutput, TMNode> OLCPJHCMOKI()
	{
		return default(GEAGLNBIIMK<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class GAIEKDLNDHI
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2949810", Offset = "0x2948210", VA = "0x182949810")]
	internal static JBCGNBGMNNL BOALAEMEPIG<TMInput, TMOutput, TMNode>([In] this GEAGLNBIIMK<TMInput, TMOutput, TMNode> CMJEIEIDHIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2949D70", Offset = "0x2948770", VA = "0x182949D70")]
	internal static GEAGLNBIIMK<TMInput, TMOutput, TMNode> HIBHLHEFCGJ<TMInput, TMOutput, TMNode>(this JBCGNBGMNNL CMJEIEIDHIK)
	{
		return default(GEAGLNBIIMK<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2949BA0", Offset = "0x29485A0", VA = "0x182949BA0")]
	private static OCIHPGAMMCN FAHEFKLEFBG<TMInput>([In] this IBNIMOLHAKB<BOLDNJBHEHG<TMInput>> CMJEIEIDHIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x294A280", Offset = "0x2948C80", VA = "0x18294A280")]
	private static IBNIMOLHAKB<BOLDNJBHEHG<TMInput>> KACENFFBDIM<TMInput>(this OCIHPGAMMCN CMJEIEIDHIK)
	{
		return default(IBNIMOLHAKB<BOLDNJBHEHG<TMInput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2717250", Offset = "0x2715C50", VA = "0x182717250")]
	internal static void KDNFCEDEOOI<TMInput, TMOutput, TMNode>(this GEAGLNBIIMK<TMInput, TMOutput, TMNode> CMJEIEIDHIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2717430", Offset = "0x2715E30", VA = "0x182717430")]
	internal static BOLDNJBHEHG<TMOutput> LCEGNCFNECM<TMOutput, TMInput, TMNode>(this GEAGLNBIIMK<TMInput, TMOutput, TMNode> CMJEIEIDHIK, BOLDNJBHEHG<TMNode> KDIAAEPKAII)
	{
		return default(BOLDNJBHEHG<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2716A10", Offset = "0x2715410", VA = "0x182716A10")]
	internal static void DMFHFELNIKK<TMInput, TMOutput, TMNode>(this GEAGLNBIIMK<TMInput, TMOutput, TMNode> CMJEIEIDHIK, BOLDNJBHEHG<TMOutput> MCGNHGLIJDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2716AA0", Offset = "0x27154A0", VA = "0x182716AA0")]
	public static bool FPGLOIPLKJL<TMInput, TMOutput, TMNode>([In] this GEAGLNBIIMK<TMInput, TMOutput, TMNode> CMJEIEIDHIK, BOLDNJBHEHG<TMOutput> MCGNHGLIJDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2715B40", Offset = "0x2714540", VA = "0x182715B40")]
	public static int LABFIHOGEOB<TMInput, TMOutput, TMNode>([In] this GEAGLNBIIMK<TMInput, TMOutput, TMNode> CMJEIEIDHIK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2716970", Offset = "0x2715370", VA = "0x182716970")]
	public static BOLDNJBHEHG<TMNode> CDGKDNIBGHB<TMNode, TMInput, TMOutput>([In] this GEAGLNBIIMK<TMInput, TMOutput, TMNode> CMJEIEIDHIK, BOLDNJBHEHG<TMOutput> MCGNHGLIJDN)
	{
		return default(BOLDNJBHEHG<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x27174D0", Offset = "0x2715ED0", VA = "0x1827174D0")]
	public static int HBLAAMLKLLI<TMInput, TMOutput, TMNode>([In] this GEAGLNBIIMK<TMInput, TMOutput, TMNode> CMJEIEIDHIK, BOLDNJBHEHG<TMOutput> MCGNHGLIJDN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x27173E0", Offset = "0x2715DE0", VA = "0x1827173E0")]
	public static BOLDNJBHEHG<TMInput> JEFAIHJBLHB<TMInput, TMOutput, TMNode>([In] this GEAGLNBIIMK<TMInput, TMOutput, TMNode> CMJEIEIDHIK, BOLDNJBHEHG<TMOutput> MCGNHGLIJDN, int ABBNIPHGMGH)
	{
		return default(BOLDNJBHEHG<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x27169D0", Offset = "0x27153D0", VA = "0x1827169D0")]
	internal static void HLMBMLGEAOF<TMInput, TMOutput, TMNode>(this GEAGLNBIIMK<TMInput, TMOutput, TMNode> CMJEIEIDHIK, BOLDNJBHEHG<TMOutput> MCGNHGLIJDN, BOLDNJBHEHG<TMInput> AALGEDLKPBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x27169D0", Offset = "0x27153D0", VA = "0x1827169D0")]
	internal static void PDJFJKEMLPG<TMInput, TMOutput, TMNode>(this GEAGLNBIIMK<TMInput, TMOutput, TMNode> CMJEIEIDHIK, BOLDNJBHEHG<TMOutput> MCGNHGLIJDN, BOLDNJBHEHG<TMInput> AALGEDLKPBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2716580", Offset = "0x2714F80", VA = "0x182716580")]
	public static IBNIMOLHAKB<BOLDNJBHEHG<TMInput>>.BNEHJDGMJED OEOAHAOHFNC<TMInput, TMOutput, TMNode>([In] this GEAGLNBIIMK<TMInput, TMOutput, TMNode> CMJEIEIDHIK, BOLDNJBHEHG<TMOutput> MCGNHGLIJDN)
	{
		return default(IBNIMOLHAKB<BOLDNJBHEHG<TMInput>>.BNEHJDGMJED);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2716580", Offset = "0x2714F80", VA = "0x182716580")]
	public static BEJAEPGKCAL<BOLDNJBHEHG<TMInput>, IBNIMOLHAKB<BOLDNJBHEHG<TMInput>>.BNEHJDGMJED> DFFOJKLPCIK<TMInput, TMOutput, TMNode>([In] this GEAGLNBIIMK<TMInput, TMOutput, TMNode> CMJEIEIDHIK, BOLDNJBHEHG<TMOutput> MCGNHGLIJDN)
	{
		return default(BEJAEPGKCAL<BOLDNJBHEHG<TMInput>, IBNIMOLHAKB<BOLDNJBHEHG<TMInput>>.BNEHJDGMJED>);
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
