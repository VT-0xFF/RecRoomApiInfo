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
		[Cpp2IlInjected.Address(RVA = "0x86D6A0", Offset = "0x86C2A0", VA = "0x18086D6A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FA5F50", Offset = "0x1FA4B50", VA = "0x181FA5F50")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x86E660", Offset = "0x86D260", VA = "0x18086E660")]
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
		[Cpp2IlInjected.Address(RVA = "0x86E6A0", Offset = "0x86D2A0", VA = "0x18086E6A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct FFKJGJOLJLP<TMInput, TMOutput, TMNode> : IEnumerator<DCECDLKENED<TMNode>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private HLOMJMKMAAA<TMInput, TMOutput, TMNode> PLPMODINGEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private GOEFKLKMKII<TMInput, TMOutput, TMNode> MLIFMGGHHIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private bool NIBIANAPKFK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public readonly DCECDLKENED<TMNode> KDHPDJIABMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3B98A80", Offset = "0x3B97680", VA = "0x183B98A80", Slot = "4")]
		get
		{
			return default(DCECDLKENED<TMNode>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3B98930", Offset = "0x3B97530", VA = "0x183B98930", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3B989B0", Offset = "0x3B975B0", VA = "0x183B989B0")]
	internal FFKJGJOLJLP([In] HLOMJMKMAAA<TMInput, TMOutput, TMNode> MJCMOLHPJGI, [In] GOEFKLKMKII<TMInput, TMOutput, TMNode> PBJAAJMFDBC, bool MAKHAIFPIKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3B987F0", Offset = "0x3B973F0", VA = "0x183B987F0", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3B988B0", Offset = "0x3B974B0", VA = "0x183B988B0", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3B98780", Offset = "0x3B97380", VA = "0x183B98780", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class JHHNDDJGJJM
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2B96A10", Offset = "0x2B95610", VA = "0x182B96A10")]
	public static FFKJGJOLJLP<TMInput, TMOutput, TMNode> PPOPBMPFEOP<TMInput, TMOutput, TMNode>([In] FMJOEOFCAGC<TMInput, TMOutput, TMNode> KLBBFPDKBOA, DCECDLKENED<TMNode> KJPMBCBOCOO)
	{
		return default(FFKJGJOLJLP<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct GOEFKLKMKII<TMInput, TMOutput, TMNode> : IEnumerator<DCECDLKENED<TMInput>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private BDDFKGHGNDI<DCECDLKENED<TMOutput>>.PIFJCEFJMLD DNNFAPNCLHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private BDDFKGHGNDI<DCECDLKENED<TMInput>>.PIFJCEFJMLD HNPLKLEPFCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly OHPKJNPNHAG<TMInput, TMOutput, TMNode> PLKBIEBEOBG;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public DCECDLKENED<TMInput> KDHPDJIABMO
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3CE5E90", Offset = "0x3CE4A90", VA = "0x183CE5E90", Slot = "4")]
		get
		{
			return default(DCECDLKENED<TMInput>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3CE5D70", Offset = "0x3CE4970", VA = "0x183CE5D70", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3CE5E10", Offset = "0x3CE4A10", VA = "0x183CE5E10")]
	internal GOEFKLKMKII([In] BDDFKGHGNDI<DCECDLKENED<TMOutput>>.PIFJCEFJMLD LDNPEDBJAIE, [In] BDDFKGHGNDI<DCECDLKENED<TMInput>>.PIFJCEFJMLD PLPGEGCKPEN, [In] OHPKJNPNHAG<TMInput, TMOutput, TMNode> NNNNICCNMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3CE5BA0", Offset = "0x3CE47A0", VA = "0x183CE5BA0", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3CE5D00", Offset = "0x3CE4900", VA = "0x183CE5D00", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3CE5B30", Offset = "0x3CE4730", VA = "0x183CE5B30", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class PFOAABPOEGE
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2CE9AD0", Offset = "0x2CE86D0", VA = "0x182CE9AD0")]
	public static GOEFKLKMKII<TMInput, TMOutput, TMNode> PPOPBMPFEOP<TMInput, TMOutput, TMNode>([In] FMJOEOFCAGC<TMInput, TMOutput, TMNode> KLBBFPDKBOA, DCECDLKENED<TMNode> KJPMBCBOCOO)
	{
		return default(GOEFKLKMKII<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct HLOMJMKMAAA<TMInput, TMOutput, TMNode> : IEnumerator<DCECDLKENED<TMOutput>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private BDDFKGHGNDI<DCECDLKENED<TMInput>>.PIFJCEFJMLD ABNABOKPEJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private BDDFKGHGNDI<DCECDLKENED<TMOutput>>.PIFJCEFJMLD NHJNLHPCECP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly MHLFHCFOJED<TMInput, TMOutput, TMNode> KAPDPDDAEMG;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public DCECDLKENED<TMOutput> KDHPDJIABMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3CE5E90", Offset = "0x3CE4A90", VA = "0x183CE5E90", Slot = "4")]
		get
		{
			return default(DCECDLKENED<TMOutput>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3CE5D70", Offset = "0x3CE4970", VA = "0x183CE5D70", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3CE5E10", Offset = "0x3CE4A10", VA = "0x183CE5E10")]
	internal HLOMJMKMAAA([In] BDDFKGHGNDI<DCECDLKENED<TMInput>>.PIFJCEFJMLD GLICKCLKHFE, [In] BDDFKGHGNDI<DCECDLKENED<TMOutput>>.PIFJCEFJMLD EBHLDMDEAMF, [In] MHLFHCFOJED<TMInput, TMOutput, TMNode> GLDEEBPEGBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3CE5BA0", Offset = "0x3CE47A0", VA = "0x183CE5BA0", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3CE5D00", Offset = "0x3CE4900", VA = "0x183CE5D00", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3CE5B30", Offset = "0x3CE4730", VA = "0x183CE5B30", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class FPFELLBIDGG
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2AFD850", Offset = "0x2AFC450", VA = "0x182AFD850")]
	public static HLOMJMKMAAA<TMInput, TMOutput, TMNode> PPOPBMPFEOP<TMInput, TMOutput, TMNode>([In] FMJOEOFCAGC<TMInput, TMOutput, TMNode> KLBBFPDKBOA, DCECDLKENED<TMNode> KJPMBCBOCOO)
	{
		return default(HLOMJMKMAAA<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct FMJOEOFCAGC<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public MHLFHCFOJED<TMInput, TMOutput, TMNode> DBEJIPPFMJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public OHPKJNPNHAG<TMInput, TMOutput, TMNode> GHNJLCOCEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public NDDDLCMHLHP<TMInput, TMOutput, TMNode> DCJNLEIAKMO;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3BD2030", Offset = "0x3BD0C30", VA = "0x183BD2030")]
	internal FMJOEOFCAGC([In] MHLFHCFOJED<TMInput, TMOutput, TMNode> GLDEEBPEGBP, [In] OHPKJNPNHAG<TMInput, TMOutput, TMNode> NNNNICCNMLA, [In] NDDDLCMHLHP<TMInput, TMOutput, TMNode> FHFJPMCHFND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3BD1D50", Offset = "0x3BD0950", VA = "0x183BD1D50")]
	public static FMJOEOFCAGC<TMInput?, TMOutput?, TMNode?> PPOPBMPFEOP()
	{
		return default(FMJOEOFCAGC<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class LJAILGFHCIA
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2BF3120", Offset = "0x2BF1D20", VA = "0x182BF3120")]
	public static BECHIKCGGCE? PLFEAILJDFE<TMInput, TMOutput, TMNode>([In] this FMJOEOFCAGC<TMInput, TMOutput, TMNode> HNFMOHFACKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2BF1EA0", Offset = "0x2BF0AA0", VA = "0x182BF1EA0")]
	public static FMJOEOFCAGC<TMInput?, TMOutput?, TMNode?> EGCBEAACMHC<TMInput, TMOutput, TMNode>(this BECHIKCGGCE HNFMOHFACKF)
	{
		return default(FMJOEOFCAGC<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2BF27C0", Offset = "0x2BF13C0", VA = "0x182BF27C0")]
	public static void IICIADDLCDE<TMInput, TMOutput, TMNode>(this FMJOEOFCAGC<TMInput, TMOutput, TMNode> HNFMOHFACKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2BF2270", Offset = "0x2BF0E70", VA = "0x182BF2270")]
	public static void ELKNDFKGPLN<TMInput, TMOutput, TMNode>(this FMJOEOFCAGC<TMInput, TMOutput, TMNode> HNFMOHFACKF, DCECDLKENED<TMOutput> BAFNJFKBIEH, DCECDLKENED<TMInput> LEFFDECMKGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2BF2950", Offset = "0x2BF1550", VA = "0x182BF2950")]
	public static void JMFMPGMJFBO<TMInput, TMOutput, TMNode>(this FMJOEOFCAGC<TMInput, TMOutput, TMNode> HNFMOHFACKF, DCECDLKENED<TMOutput> BAFNJFKBIEH, DCECDLKENED<TMInput> LEFFDECMKGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2BF1D10", Offset = "0x2BF0910", VA = "0x182BF1D10")]
	public static int DGNJPMFAPPP<TMInput, TMOutput, TMNode>([In] this FMJOEOFCAGC<TMInput, TMOutput, TMNode> HNFMOHFACKF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2BF2620", Offset = "0x2BF1220", VA = "0x182BF2620")]
	public static bool HOLGFNNPIMK<TMInput, TMOutput, TMNode>([In] this FMJOEOFCAGC<TMInput, TMOutput, TMNode> HNFMOHFACKF, DCECDLKENED<TMOutput> BAFNJFKBIEH, DCECDLKENED<TMInput> LEFFDECMKGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2BF29F0", Offset = "0x2BF15F0", VA = "0x182BF29F0")]
	public static bool LBBNFJNEIAJ<TMInput, TMOutput, TMNode>([In] this FMJOEOFCAGC<TMInput, TMOutput, TMNode> HNFMOHFACKF, DCECDLKENED<TMOutput> DJPILIKDMHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2BF1E60", Offset = "0x2BF0A60", VA = "0x182BF1E60")]
	public static bool DILLHALOGDH<TMInput, TMOutput, TMNode>([In] this FMJOEOFCAGC<TMInput, TMOutput, TMNode> HNFMOHFACKF, DCECDLKENED<TMInput> DJPILIKDMHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2BF2DF0", Offset = "0x2BF19F0", VA = "0x182BF2DF0")]
	public static DCECDLKENED<TMNode?> NEDDNJCDGIN<TMNode, TMInput, TMOutput>(this FMJOEOFCAGC<TMInput, TMOutput, TMNode> HNFMOHFACKF)
	{
		return default(DCECDLKENED<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2BF1B70", Offset = "0x2BF0770", VA = "0x182BF1B70")]
	public static void BPKPDEHPCFN<TMInput, TMOutput, TMNode>(this FMJOEOFCAGC<TMInput, TMOutput, TMNode> HNFMOHFACKF, DCECDLKENED<TMNode> KJPMBCBOCOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2BF2EC0", Offset = "0x2BF1AC0", VA = "0x182BF2EC0")]
	public static DCECDLKENED<TMInput?> NFNMELDCMLD<TMInput, TMOutput, TMNode>(this FMJOEOFCAGC<TMInput, TMOutput, TMNode> HNFMOHFACKF, DCECDLKENED<TMNode> KJPMBCBOCOO)
	{
		return default(DCECDLKENED<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2BF23D0", Offset = "0x2BF0FD0", VA = "0x182BF23D0")]
	public static DCECDLKENED<TMOutput?> HBJADKHCOJM<TMOutput, TMInput, TMNode>(this FMJOEOFCAGC<TMInput, TMOutput, TMNode> HNFMOHFACKF, DCECDLKENED<TMNode> KJPMBCBOCOO)
	{
		return default(DCECDLKENED<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2BF1AD0", Offset = "0x2BF06D0", VA = "0x182BF1AD0")]
	public static DCECDLKENED<TMInput?> BIDDFLMOBFJ<TMInput, TMOutput, TMNode>(this FMJOEOFCAGC<TMInput, TMOutput, TMNode> HNFMOHFACKF, DCECDLKENED<TMNode> KJPMBCBOCOO, int OPDMGNJCACB)
	{
		return default(DCECDLKENED<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2BF3080", Offset = "0x2BF1C80", VA = "0x182BF3080")]
	public static DCECDLKENED<TMOutput?> OGMDEDCDIGJ<TMOutput, TMInput, TMNode>(this FMJOEOFCAGC<TMInput, TMOutput, TMNode> HNFMOHFACKF, DCECDLKENED<TMNode> KJPMBCBOCOO, int OPDMGNJCACB)
	{
		return default(DCECDLKENED<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2BF2860", Offset = "0x2BF1460", VA = "0x182BF2860")]
	public static void IMOLIIAHLFL<TMInput, TMOutput, TMNode>(this FMJOEOFCAGC<TMInput, TMOutput, TMNode> HNFMOHFACKF, DCECDLKENED<TMNode> KJPMBCBOCOO, int GLELMANKJOI, int DNEFKAKBJGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2BF2BA0", Offset = "0x2BF17A0", VA = "0x182BF2BA0")]
	public static void MAADIAPHHCB<TMInput, TMOutput, TMNode>(this FMJOEOFCAGC<TMInput, TMOutput, TMNode> HNFMOHFACKF, DCECDLKENED<TMNode> KJPMBCBOCOO, int GLELMANKJOI, int DNEFKAKBJGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2BF2C90", Offset = "0x2BF1890", VA = "0x182BF2C90")]
	public static void MAEOILPECAO<TMInput, TMOutput, TMNode>(this FMJOEOFCAGC<TMInput, TMOutput, TMNode> HNFMOHFACKF, DCECDLKENED<TMInput> ALMJBMBCMPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2BF2A40", Offset = "0x2BF1640", VA = "0x182BF2A40")]
	public static void LLGGPNBPJCO<TMInput, TMOutput, TMNode>(this FMJOEOFCAGC<TMInput, TMOutput, TMNode> HNFMOHFACKF, DCECDLKENED<TMOutput> LKMOAAHJAKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x90B600", Offset = "0x90A200", VA = "0x18090B600")]
	public static DKNCLLBBDMF<TMInput?> FNEJAHFHNHO<TMInput, TMOutput, TMNode>([In] this FMJOEOFCAGC<TMInput, TMOutput, TMNode> HNFMOHFACKF)
	{
		return default(DKNCLLBBDMF<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x1FCB120", Offset = "0x1FC9D20", VA = "0x181FCB120")]
	public static DKNCLLBBDMF<TMOutput?> LPFHNGFIOOI<TMOutput, TMInput, TMNode>([In] this FMJOEOFCAGC<TMInput, TMOutput, TMNode> HNFMOHFACKF)
	{
		return default(DKNCLLBBDMF<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1FCC5D0", Offset = "0x1FCB1D0", VA = "0x181FCC5D0")]
	public static DKNCLLBBDMF<TMNode?> BCHEJDBGCHK<TMNode, TMInput, TMOutput>([In] this FMJOEOFCAGC<TMInput, TMOutput, TMNode> HNFMOHFACKF)
	{
		return default(DKNCLLBBDMF<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2BF2740", Offset = "0x2BF1340", VA = "0x182BF2740")]
	public static GOEFKLKMKII<TMInput?, TMOutput?, TMNode?> NGDMAMKOJEC<TMInput, TMOutput, TMNode>([In] this FMJOEOFCAGC<TMInput, TMOutput, TMNode> HNFMOHFACKF, DCECDLKENED<TMNode> EPKGPGILADI)
	{
		return default(GOEFKLKMKII<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2BF2740", Offset = "0x2BF1340", VA = "0x182BF2740")]
	public static HLOMJMKMAAA<TMInput?, TMOutput?, TMNode?> IFHABJEOEGL<TMInput, TMOutput, TMNode>([In] this FMJOEOFCAGC<TMInput, TMOutput, TMNode> HNFMOHFACKF, DCECDLKENED<TMNode> EPKGPGILADI)
	{
		return default(HLOMJMKMAAA<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2BF2310", Offset = "0x2BF0F10", VA = "0x182BF2310")]
	public static FFKJGJOLJLP<TMInput?, TMOutput?, TMNode?> GBCGPCABGHE<TMInput, TMOutput, TMNode>([In] this FMJOEOFCAGC<TMInput, TMOutput, TMNode> HNFMOHFACKF, DCECDLKENED<TMNode> EPKGPGILADI)
	{
		return default(FFKJGJOLJLP<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2BF2F50", Offset = "0x2BF1B50", VA = "0x182BF2F50")]
	public static NBJLPHMBNMH<DCECDLKENED<TMInput?>, GOEFKLKMKII<TMInput?, TMOutput?, TMNode?>> NNHGOIPOPCO<TMInput, TMOutput, TMNode>([In] this FMJOEOFCAGC<TMInput, TMOutput, TMNode> HNFMOHFACKF, DCECDLKENED<TMNode> EPKGPGILADI)
	{
		return default(NBJLPHMBNMH<DCECDLKENED<TMInput>, GOEFKLKMKII<TMInput, TMOutput, TMNode>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2BF2470", Offset = "0x2BF1070", VA = "0x182BF2470")]
	public static NBJLPHMBNMH<DCECDLKENED<TMNode?>, FFKJGJOLJLP<TMInput?, TMOutput?, TMNode?>> HDIEKFPAGNL<TMNode, TMInput, TMOutput>([In] this FMJOEOFCAGC<TMInput, TMOutput, TMNode> HNFMOHFACKF, DCECDLKENED<TMNode> EPKGPGILADI)
	{
		return default(NBJLPHMBNMH<DCECDLKENED<TMNode>, FFKJGJOLJLP<TMInput, TMOutput, TMNode>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct MHLFHCFOJED<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal DKNCLLBBDMF<TMInput> NFFHBMNNLIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	internal GFJNJNMLLEF<TMInput, DCECDLKENED<TMNode>> AEJOBFIAFON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal GFJNJNMLLEF<TMInput, BDDFKGHGNDI<DCECDLKENED<TMOutput>>> PLKBIEBEOBG;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x43F9690", Offset = "0x43F8290", VA = "0x1843F9690")]
	internal MHLFHCFOJED([In] DKNCLLBBDMF<TMInput> LAJEGKNFMCP, [In] GFJNJNMLLEF<TMInput, DCECDLKENED<TMNode>> FHFJPMCHFND, [In] GFJNJNMLLEF<TMInput, BDDFKGHGNDI<DCECDLKENED<TMOutput>>> NNNNICCNMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x43F94A0", Offset = "0x43F80A0", VA = "0x1843F94A0")]
	internal static MHLFHCFOJED<TMInput, TMOutput, TMNode> PPOPBMPFEOP()
	{
		return default(MHLFHCFOJED<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class AGEDHCJAIGN
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x31DA290", Offset = "0x31D8E90", VA = "0x1831DA290")]
	internal static MLCEGOIHODE PLFEAILJDFE<TMInput, TMOutput, TMNode>([In] this MHLFHCFOJED<TMInput, TMOutput, TMNode> HNFMOHFACKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x31D9AF0", Offset = "0x31D86F0", VA = "0x1831D9AF0")]
	internal static MHLFHCFOJED<TMInput, TMOutput, TMNode> EGCBEAACMHC<TMInput, TMOutput, TMNode>(this MLCEGOIHODE HNFMOHFACKF)
	{
		return default(MHLFHCFOJED<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x31DA090", Offset = "0x31D8C90", VA = "0x1831DA090")]
	private static ODNENMAOFLI NMLOKFHCFOO<TMOutput>([In] this BDDFKGHGNDI<DCECDLKENED<TMOutput>> HNFMOHFACKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x31D9810", Offset = "0x31D8410", VA = "0x1831D9810")]
	private static BDDFKGHGNDI<DCECDLKENED<TMOutput>> BBNJNFBGDML<TMOutput>(this ODNENMAOFLI HNFMOHFACKF)
	{
		return default(BDDFKGHGNDI<DCECDLKENED<TMOutput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2B988D0", Offset = "0x2B974D0", VA = "0x182B988D0")]
	internal static void IICIADDLCDE<TMInput, TMOutput, TMNode>(this MHLFHCFOJED<TMInput, TMOutput, TMNode> HNFMOHFACKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2B98DA0", Offset = "0x2B979A0", VA = "0x182B98DA0")]
	internal static DCECDLKENED<TMInput> OHGEFADEKDJ<TMInput, TMOutput, TMNode>(this MHLFHCFOJED<TMInput, TMOutput, TMNode> HNFMOHFACKF, DCECDLKENED<TMNode> LNFMEAPGAAK)
	{
		return default(DCECDLKENED<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2B985C0", Offset = "0x2B971C0", VA = "0x182B985C0")]
	internal static void FDHMEOLOKLG<TMInput, TMOutput, TMNode>(this MHLFHCFOJED<TMInput, TMOutput, TMNode> HNFMOHFACKF, DCECDLKENED<TMInput> EPKGPGILADI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x28852E0", Offset = "0x2883EE0", VA = "0x1828852E0")]
	public static bool OKKJPEEAMCN<TMInput, TMOutput, TMNode>([In] this MHLFHCFOJED<TMInput, TMOutput, TMNode> HNFMOHFACKF, DCECDLKENED<TMInput> EPKGPGILADI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2570260", Offset = "0x256EE60", VA = "0x182570260")]
	public static int BHCLCDOCMNH<TMInput, TMOutput, TMNode>([In] this MHLFHCFOJED<TMInput, TMOutput, TMNode> HNFMOHFACKF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2B97FE0", Offset = "0x2B96BE0", VA = "0x182B97FE0")]
	public static DCECDLKENED<TMNode> BJMEAKPDOAC<TMNode, TMInput, TMOutput>([In] this MHLFHCFOJED<TMInput, TMOutput, TMNode> HNFMOHFACKF, DCECDLKENED<TMInput> EPKGPGILADI)
	{
		return default(DCECDLKENED<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x28E5620", Offset = "0x28E4220", VA = "0x1828E5620")]
	public static int DMIJODDIILK<TMInput, TMOutput, TMNode>([In] this MHLFHCFOJED<TMInput, TMOutput, TMNode> HNFMOHFACKF, DCECDLKENED<TMInput> EPKGPGILADI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x28E54B0", Offset = "0x28E40B0", VA = "0x1828E54B0")]
	public static DCECDLKENED<TMOutput> BHHMGCKHDHG<TMOutput, TMInput, TMNode>([In] this MHLFHCFOJED<TMInput, TMOutput, TMNode> HNFMOHFACKF, DCECDLKENED<TMInput> EPKGPGILADI, int OPDMGNJCACB)
	{
		return default(DCECDLKENED<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x28E6020", Offset = "0x28E4C20", VA = "0x1828E6020")]
	internal static void GCBKDAJPOGM<TMInput, TMOutput, TMNode>(this MHLFHCFOJED<TMInput, TMOutput, TMNode> HNFMOHFACKF, DCECDLKENED<TMInput> EPKGPGILADI, DCECDLKENED<TMOutput> LKMOAAHJAKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x28E6020", Offset = "0x28E4C20", VA = "0x1828E6020")]
	internal static void IFDLKMIHBBE<TMInput, TMOutput, TMNode>(this MHLFHCFOJED<TMInput, TMOutput, TMNode> HNFMOHFACKF, DCECDLKENED<TMInput> EPKGPGILADI, DCECDLKENED<TMOutput> LKMOAAHJAKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2885100", Offset = "0x2883D00", VA = "0x182885100")]
	public static BDDFKGHGNDI<DCECDLKENED<TMOutput>>.PIFJCEFJMLD NHPLKDJABNP<TMOutput, TMInput, TMNode>([In] this MHLFHCFOJED<TMInput, TMOutput, TMNode> HNFMOHFACKF, DCECDLKENED<TMInput> EPKGPGILADI)
	{
		return default(BDDFKGHGNDI<DCECDLKENED<TMOutput>>.PIFJCEFJMLD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2885100", Offset = "0x2883D00", VA = "0x182885100")]
	public static BOAGKJKJNBH<DCECDLKENED<TMOutput>, BDDFKGHGNDI<DCECDLKENED<TMOutput>>.PIFJCEFJMLD> DCDLBALOGOD<TMOutput, TMInput, TMNode>([In] this MHLFHCFOJED<TMInput, TMOutput, TMNode> HNFMOHFACKF, DCECDLKENED<TMInput> EPKGPGILADI)
	{
		return default(BOAGKJKJNBH<DCECDLKENED<TMOutput>, BDDFKGHGNDI<DCECDLKENED<TMOutput>>.PIFJCEFJMLD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2883E00", Offset = "0x2882A00", VA = "0x182883E00")]
	public static NBJLPHMBNMH<DCECDLKENED<TMInput>, DKNCLLBBDMF<TMInput>.PEOKFDKDIDG> EAFKCJKMECH<TMInput, TMOutput, TMNode>([In] this MHLFHCFOJED<TMInput, TMOutput, TMNode> HNFMOHFACKF)
	{
		return default(NBJLPHMBNMH<DCECDLKENED<TMInput>, DKNCLLBBDMF<TMInput>.PEOKFDKDIDG>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct NDDDLCMHLHP<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal DKNCLLBBDMF<TMNode> NFFHBMNNLIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal GFJNJNMLLEF<TMNode, BDDFKGHGNDI<DCECDLKENED<TMInput>>> KAPDPDDAEMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal GFJNJNMLLEF<TMNode, BDDFKGHGNDI<DCECDLKENED<TMOutput>>> PLKBIEBEOBG;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x43F9690", Offset = "0x43F8290", VA = "0x1843F9690")]
	internal NDDDLCMHLHP([In] DKNCLLBBDMF<TMNode> LAJEGKNFMCP, [In] GFJNJNMLLEF<TMNode, BDDFKGHGNDI<DCECDLKENED<TMInput>>> GLDEEBPEGBP, [In] GFJNJNMLLEF<TMNode, BDDFKGHGNDI<DCECDLKENED<TMOutput>>> NNNNICCNMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x43F94A0", Offset = "0x43F80A0", VA = "0x1843F94A0")]
	internal static NDDDLCMHLHP<TMInput, TMOutput, TMNode> PPOPBMPFEOP()
	{
		return default(NDDDLCMHLHP<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class CFIJGAKMECF
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x28E6CE0", Offset = "0x28E58E0", VA = "0x1828E6CE0")]
	internal static DIHEELBJPGE PLFEAILJDFE<TMInput, TMOutput, TMNode>([In] this NDDDLCMHLHP<TMInput, TMOutput, TMNode> HNFMOHFACKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x28E5690", Offset = "0x28E4290", VA = "0x1828E5690")]
	internal static NDDDLCMHLHP<TMInput, TMOutput, TMNode> EGCBEAACMHC<TMInput, TMOutput, TMNode>(this DIHEELBJPGE HNFMOHFACKF)
	{
		return default(NDDDLCMHLHP<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x28E6740", Offset = "0x28E5340", VA = "0x1828E6740")]
	private static KBACCMEDLHF MEIJOALIAAP<TMInput>([In] this BDDFKGHGNDI<DCECDLKENED<TMInput>> HNFMOHFACKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x28E6090", Offset = "0x28E4C90", VA = "0x1828E6090")]
	private static BDDFKGHGNDI<DCECDLKENED<TMInput>> HALLOIPCJFP<TMInput>(this KBACCMEDLHF HNFMOHFACKF)
	{
		return default(BDDFKGHGNDI<DCECDLKENED<TMInput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x28E5E20", Offset = "0x28E4A20", VA = "0x1828E5E20")]
	private static NAKNGPJGAMC FKHIBJLBDIK<TMOutput>([In] this BDDFKGHGNDI<DCECDLKENED<TMOutput>> HNFMOHFACKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x28E6A00", Offset = "0x28E5600", VA = "0x1828E6A00")]
	private static BDDFKGHGNDI<DCECDLKENED<TMOutput>> PHJKBILGFNG<TMOutput>(this NAKNGPJGAMC HNFMOHFACKF)
	{
		return default(BDDFKGHGNDI<DCECDLKENED<TMOutput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x28E6370", Offset = "0x28E4F70", VA = "0x1828E6370")]
	internal static void IICIADDLCDE<TMInput, TMOutput, TMNode>(this NDDDLCMHLHP<TMInput, TMOutput, TMNode> HNFMOHFACKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x28E6940", Offset = "0x28E5540", VA = "0x1828E6940")]
	internal static DCECDLKENED<TMNode> OHGEFADEKDJ<TMNode, TMInput, TMOutput>(this NDDDLCMHLHP<TMInput, TMOutput, TMNode> HNFMOHFACKF, [In] BDDFKGHGNDI<DCECDLKENED<TMInput>> GLDEEBPEGBP, [In] BDDFKGHGNDI<DCECDLKENED<TMOutput>> NNNNICCNMLA)
	{
		return default(DCECDLKENED<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x28E5C30", Offset = "0x28E4830", VA = "0x1828E5C30")]
	internal static void FDHMEOLOKLG<TMInput, TMOutput, TMNode>(this NDDDLCMHLHP<TMInput, TMOutput, TMNode> HNFMOHFACKF, DCECDLKENED<TMNode> EPKGPGILADI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x28852E0", Offset = "0x2883EE0", VA = "0x1828852E0")]
	public static bool OKKJPEEAMCN<TMInput, TMOutput, TMNode>([In] this NDDDLCMHLHP<TMInput, TMOutput, TMNode> HNFMOHFACKF, DCECDLKENED<TMNode> EPKGPGILADI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2570260", Offset = "0x256EE60", VA = "0x182570260")]
	public static int BHCLCDOCMNH<TMInput, TMOutput, TMNode>([In] this NDDDLCMHLHP<TMInput, TMOutput, TMNode> HNFMOHFACKF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x28E66D0", Offset = "0x28E52D0", VA = "0x1828E66D0")]
	public static int MEDOBANHDFO<TMInput, TMOutput, TMNode>([In] this NDDDLCMHLHP<TMInput, TMOutput, TMNode> HNFMOHFACKF, DCECDLKENED<TMNode> EPKGPGILADI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x28E5620", Offset = "0x28E4220", VA = "0x1828E5620")]
	public static int DMIJODDIILK<TMInput, TMOutput, TMNode>([In] this NDDDLCMHLHP<TMInput, TMOutput, TMNode> HNFMOHFACKF, DCECDLKENED<TMNode> EPKGPGILADI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x28E55A0", Offset = "0x28E41A0", VA = "0x1828E55A0")]
	public static DCECDLKENED<TMInput> DAPDCHGCAHJ<TMInput, TMOutput, TMNode>([In] this NDDDLCMHLHP<TMInput, TMOutput, TMNode> HNFMOHFACKF, DCECDLKENED<TMNode> EPKGPGILADI, int OPDMGNJCACB)
	{
		return default(DCECDLKENED<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x28E54B0", Offset = "0x28E40B0", VA = "0x1828E54B0")]
	public static DCECDLKENED<TMOutput> BHHMGCKHDHG<TMOutput, TMInput, TMNode>([In] this NDDDLCMHLHP<TMInput, TMOutput, TMNode> HNFMOHFACKF, DCECDLKENED<TMNode> EPKGPGILADI, int OPDMGNJCACB)
	{
		return default(DCECDLKENED<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x28E5530", Offset = "0x28E4130", VA = "0x1828E5530")]
	internal static void EHMELGOHMAM<TMInput, TMOutput, TMNode>(this NDDDLCMHLHP<TMInput, TMOutput, TMNode> HNFMOHFACKF, DCECDLKENED<TMNode> EPKGPGILADI, DCECDLKENED<TMInput> ALMJBMBCMPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x28E6020", Offset = "0x28E4C20", VA = "0x1828E6020")]
	internal static void GCBKDAJPOGM<TMInput, TMOutput, TMNode>(this NDDDLCMHLHP<TMInput, TMOutput, TMNode> HNFMOHFACKF, DCECDLKENED<TMNode> EPKGPGILADI, DCECDLKENED<TMOutput> LKMOAAHJAKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x28E53B0", Offset = "0x28E3FB0", VA = "0x1828E53B0")]
	internal static void AFKHOPFCPEB<TMInput, TMOutput, TMNode>(this NDDDLCMHLHP<TMInput, TMOutput, TMNode> HNFMOHFACKF, DCECDLKENED<TMNode> EPKGPGILADI, int OPDMGNJCACB, DCECDLKENED<TMInput> ALMJBMBCMPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x28E5430", Offset = "0x28E4030", VA = "0x1828E5430")]
	internal static void BCLOHFBNFCA<TMInput, TMOutput, TMNode>(this NDDDLCMHLHP<TMInput, TMOutput, TMNode> HNFMOHFACKF, DCECDLKENED<TMNode> EPKGPGILADI, int OPDMGNJCACB, DCECDLKENED<TMOutput> LKMOAAHJAKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x28E5530", Offset = "0x28E4130", VA = "0x1828E5530")]
	internal static void CHGCFMJAANA<TMInput, TMOutput, TMNode>(this NDDDLCMHLHP<TMInput, TMOutput, TMNode> HNFMOHFACKF, DCECDLKENED<TMNode> EPKGPGILADI, DCECDLKENED<TMInput> ALMJBMBCMPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x28E6020", Offset = "0x28E4C20", VA = "0x1828E6020")]
	internal static void IFDLKMIHBBE<TMInput, TMOutput, TMNode>(this NDDDLCMHLHP<TMInput, TMOutput, TMNode> HNFMOHFACKF, DCECDLKENED<TMNode> EPKGPGILADI, DCECDLKENED<TMOutput> LKMOAAHJAKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x28E5D90", Offset = "0x28E4990", VA = "0x1828E5D90")]
	public static BDDFKGHGNDI<DCECDLKENED<TMInput>>.PIFJCEFJMLD IENCDNNDKMK<TMInput, TMOutput, TMNode>([In] this NDDDLCMHLHP<TMInput, TMOutput, TMNode> HNFMOHFACKF, DCECDLKENED<TMNode> EPKGPGILADI)
	{
		return default(BDDFKGHGNDI<DCECDLKENED<TMInput>>.PIFJCEFJMLD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2885100", Offset = "0x2883D00", VA = "0x182885100")]
	public static BDDFKGHGNDI<DCECDLKENED<TMOutput>>.PIFJCEFJMLD NHPLKDJABNP<TMOutput, TMInput, TMNode>([In] this NDDDLCMHLHP<TMInput, TMOutput, TMNode> HNFMOHFACKF, DCECDLKENED<TMNode> EPKGPGILADI)
	{
		return default(BDDFKGHGNDI<DCECDLKENED<TMOutput>>.PIFJCEFJMLD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x28E5D90", Offset = "0x28E4990", VA = "0x1828E5D90")]
	public static BOAGKJKJNBH<DCECDLKENED<TMInput>, BDDFKGHGNDI<DCECDLKENED<TMInput>>.PIFJCEFJMLD> FEPCNDMMLFG<TMInput, TMOutput, TMNode>([In] this NDDDLCMHLHP<TMInput, TMOutput, TMNode> HNFMOHFACKF, DCECDLKENED<TMNode> EPKGPGILADI)
	{
		return default(BOAGKJKJNBH<DCECDLKENED<TMInput>, BDDFKGHGNDI<DCECDLKENED<TMInput>>.PIFJCEFJMLD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2885100", Offset = "0x2883D00", VA = "0x182885100")]
	public static BOAGKJKJNBH<DCECDLKENED<TMOutput>, BDDFKGHGNDI<DCECDLKENED<TMOutput>>.PIFJCEFJMLD> DCDLBALOGOD<TMOutput, TMInput, TMNode>([In] this NDDDLCMHLHP<TMInput, TMOutput, TMNode> HNFMOHFACKF, DCECDLKENED<TMNode> EPKGPGILADI)
	{
		return default(BOAGKJKJNBH<DCECDLKENED<TMOutput>, BDDFKGHGNDI<DCECDLKENED<TMOutput>>.PIFJCEFJMLD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2883E00", Offset = "0x2882A00", VA = "0x182883E00")]
	public static NBJLPHMBNMH<DCECDLKENED<TMNode>, DKNCLLBBDMF<TMNode>.PEOKFDKDIDG> EAFKCJKMECH<TMNode, TMInput, TMOutput>([In] this NDDDLCMHLHP<TMInput, TMOutput, TMNode> HNFMOHFACKF)
	{
		return default(NBJLPHMBNMH<DCECDLKENED<TMNode>, DKNCLLBBDMF<TMNode>.PEOKFDKDIDG>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct OHPKJNPNHAG<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal DKNCLLBBDMF<TMOutput> NFFHBMNNLIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal GFJNJNMLLEF<TMOutput, DCECDLKENED<TMNode>> AEJOBFIAFON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal GFJNJNMLLEF<TMOutput, BDDFKGHGNDI<DCECDLKENED<TMInput>>> KAPDPDDAEMG;

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x43F9690", Offset = "0x43F8290", VA = "0x1843F9690")]
	internal OHPKJNPNHAG([In] DKNCLLBBDMF<TMOutput> LAJEGKNFMCP, [In] GFJNJNMLLEF<TMOutput, DCECDLKENED<TMNode>> FHFJPMCHFND, [In] GFJNJNMLLEF<TMOutput, BDDFKGHGNDI<DCECDLKENED<TMInput>>> GLDEEBPEGBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x43F94A0", Offset = "0x43F80A0", VA = "0x1843F94A0")]
	internal static OHPKJNPNHAG<TMInput, TMOutput, TMNode> PPOPBMPFEOP()
	{
		return default(OHPKJNPNHAG<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class JKFLEPABLCI
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2B98EA0", Offset = "0x2B97AA0", VA = "0x182B98EA0")]
	internal static BOLKAKOLMJM PLFEAILJDFE<TMInput, TMOutput, TMNode>([In] this OHPKJNPNHAG<TMInput, TMOutput, TMNode> HNFMOHFACKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2B98020", Offset = "0x2B96C20", VA = "0x182B98020")]
	internal static OHPKJNPNHAG<TMInput, TMOutput, TMNode> EGCBEAACMHC<TMInput, TMOutput, TMNode>(this BOLKAKOLMJM HNFMOHFACKF)
	{
		return default(OHPKJNPNHAG<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2B986D0", Offset = "0x2B972D0", VA = "0x182B986D0")]
	private static FFKOLEOLKHN IAHJMIHJKKA<TMInput>([In] this BDDFKGHGNDI<DCECDLKENED<TMInput>> HNFMOHFACKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2B98AC0", Offset = "0x2B976C0", VA = "0x182B98AC0")]
	private static BDDFKGHGNDI<DCECDLKENED<TMInput>> MBBNIFFBNDN<TMInput>(this FFKOLEOLKHN HNFMOHFACKF)
	{
		return default(BDDFKGHGNDI<DCECDLKENED<TMInput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2B988D0", Offset = "0x2B974D0", VA = "0x182B988D0")]
	internal static void IICIADDLCDE<TMInput, TMOutput, TMNode>(this OHPKJNPNHAG<TMInput, TMOutput, TMNode> HNFMOHFACKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2B98DA0", Offset = "0x2B979A0", VA = "0x182B98DA0")]
	internal static DCECDLKENED<TMOutput> OHGEFADEKDJ<TMOutput, TMInput, TMNode>(this OHPKJNPNHAG<TMInput, TMOutput, TMNode> HNFMOHFACKF, DCECDLKENED<TMNode> LNFMEAPGAAK)
	{
		return default(DCECDLKENED<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2B985C0", Offset = "0x2B971C0", VA = "0x182B985C0")]
	internal static void FDHMEOLOKLG<TMInput, TMOutput, TMNode>(this OHPKJNPNHAG<TMInput, TMOutput, TMNode> HNFMOHFACKF, DCECDLKENED<TMOutput> EPKGPGILADI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x28852E0", Offset = "0x2883EE0", VA = "0x1828852E0")]
	public static bool OKKJPEEAMCN<TMInput, TMOutput, TMNode>([In] this OHPKJNPNHAG<TMInput, TMOutput, TMNode> HNFMOHFACKF, DCECDLKENED<TMOutput> EPKGPGILADI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2570260", Offset = "0x256EE60", VA = "0x182570260")]
	public static int BHCLCDOCMNH<TMInput, TMOutput, TMNode>([In] this OHPKJNPNHAG<TMInput, TMOutput, TMNode> HNFMOHFACKF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2B97FE0", Offset = "0x2B96BE0", VA = "0x182B97FE0")]
	public static DCECDLKENED<TMNode> BJMEAKPDOAC<TMNode, TMInput, TMOutput>([In] this OHPKJNPNHAG<TMInput, TMOutput, TMNode> HNFMOHFACKF, DCECDLKENED<TMOutput> EPKGPGILADI)
	{
		return default(DCECDLKENED<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x28E5620", Offset = "0x28E4220", VA = "0x1828E5620")]
	public static int MEDOBANHDFO<TMInput, TMOutput, TMNode>([In] this OHPKJNPNHAG<TMInput, TMOutput, TMNode> HNFMOHFACKF, DCECDLKENED<TMOutput> EPKGPGILADI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x28E54B0", Offset = "0x28E40B0", VA = "0x1828E54B0")]
	public static DCECDLKENED<TMInput> DAPDCHGCAHJ<TMInput, TMOutput, TMNode>([In] this OHPKJNPNHAG<TMInput, TMOutput, TMNode> HNFMOHFACKF, DCECDLKENED<TMOutput> EPKGPGILADI, int OPDMGNJCACB)
	{
		return default(DCECDLKENED<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x28E6020", Offset = "0x28E4C20", VA = "0x1828E6020")]
	internal static void EHMELGOHMAM<TMInput, TMOutput, TMNode>(this OHPKJNPNHAG<TMInput, TMOutput, TMNode> HNFMOHFACKF, DCECDLKENED<TMOutput> EPKGPGILADI, DCECDLKENED<TMInput> ALMJBMBCMPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x28E6020", Offset = "0x28E4C20", VA = "0x1828E6020")]
	internal static void CHGCFMJAANA<TMInput, TMOutput, TMNode>(this OHPKJNPNHAG<TMInput, TMOutput, TMNode> HNFMOHFACKF, DCECDLKENED<TMOutput> EPKGPGILADI, DCECDLKENED<TMInput> ALMJBMBCMPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2885100", Offset = "0x2883D00", VA = "0x182885100")]
	public static BDDFKGHGNDI<DCECDLKENED<TMInput>>.PIFJCEFJMLD IENCDNNDKMK<TMInput, TMOutput, TMNode>([In] this OHPKJNPNHAG<TMInput, TMOutput, TMNode> HNFMOHFACKF, DCECDLKENED<TMOutput> EPKGPGILADI)
	{
		return default(BDDFKGHGNDI<DCECDLKENED<TMInput>>.PIFJCEFJMLD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2885100", Offset = "0x2883D00", VA = "0x182885100")]
	public static BOAGKJKJNBH<DCECDLKENED<TMInput>, BDDFKGHGNDI<DCECDLKENED<TMInput>>.PIFJCEFJMLD> FEPCNDMMLFG<TMInput, TMOutput, TMNode>([In] this OHPKJNPNHAG<TMInput, TMOutput, TMNode> HNFMOHFACKF, DCECDLKENED<TMOutput> EPKGPGILADI)
	{
		return default(BOAGKJKJNBH<DCECDLKENED<TMInput>, BDDFKGHGNDI<DCECDLKENED<TMInput>>.PIFJCEFJMLD>);
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
