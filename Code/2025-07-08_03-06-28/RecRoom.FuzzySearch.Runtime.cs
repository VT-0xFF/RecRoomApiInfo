using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.Logging.Attributes;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x80EC680", Offset = "0x80EB480", VA = "0x1880EC680")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA838A0", Offset = "0xA826A0", VA = "0x180A838A0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA838E0", Offset = "0xA826E0", VA = "0x180A838E0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _LogRegistration.RecRoom_FuzzySearch_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[Preserve]
	[CompilerGenerated]
	public class LogRegistrationIndex : LLMIPJJKGHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x80EBB30", Offset = "0x80EA930", VA = "0x1880EBB30", Slot = "4")]
		public override void HIMDKAKGPHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class PJKKJKNHFKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly PMBMDKIIOFO GBOEMEDAOKN;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x80EDA10", Offset = "0x80EC810", VA = "0x1880EDA10")]
	public PJKKJKNHFKC(IReadOnlyCollection<string> NKDJGEDPPKB, [In] PLKLPENELED LIKCCDGEANE, [Optional] PMBMDKIIOFO.HCJNFJFEBCM PDPELJDBNLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x80ED7D0", Offset = "0x80EC5D0", VA = "0x1880ED7D0")]
	public IReadOnlyList<JCEGADDGPNO> KKIFBPEBOOB(string GEDCJDANLCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x80ED630", Offset = "0x80EC430", VA = "0x1880ED630")]
	public void ANEJMPOMHDK(string GEDCJDANLCD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class PMBMDKIIOFO
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public delegate int HCJNFJFEBCM(IReadOnlyList<char> KGKKLMPBNNL, int ALMJIBBLHHL, string IEDJDOKODJB);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly PLKLPENELED FENOGJFFCFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly HCJNFJFEBCM GBPHKONBFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly char[] GNLEGFEHAHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly JCEGADDGPNO[] PCINKEMPDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly bool[] GODIICFIHFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly (int SearchStringIndex, int ConsecutiveCount, int Value)[] FGHINGONLOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly JCEGADDGPNO[] FEPBMJCJPOK;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xA58420", Offset = "0xA57220", VA = "0x180A58420")]
	public static int JBCENCHGDON(IReadOnlyList<char> KGKKLMPBNNL, int ALMJIBBLHHL, string IEDJDOKODJB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x80EE230", Offset = "0x80ED030", VA = "0x1880EE230")]
	public PMBMDKIIOFO(IReadOnlyCollection<string> NKDJGEDPPKB, [In] PLKLPENELED LIKCCDGEANE, [Optional] HCJNFJFEBCM PDPELJDBNLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x80EE190", Offset = "0x80ECF90", VA = "0x1880EE190")]
	public string FHGGNCGIOJK(string GEDCJDANLCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x80EE220", Offset = "0x80ED020", VA = "0x1880EE220")]
	public int GGOKLEPDDHN(int EIOECLFJFJD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x80EDB90", Offset = "0x80EC990", VA = "0x1880EDB90")]
	public int ANEJMPOMHDK(string GEDCJDANLCD, int AIOABMNKMLL, int EEGOBCCEEKK, int ALMJIBBLHHL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct PLKLPENELED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public readonly bool AJNBGPMDKBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly bool DOOPCCLDDKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly int FADJIDENBJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly int MHGFLLLEBAF;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly PLKLPENELED NAGGGBBEMAC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static PLKLPENELED CLGJEJAIGBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x80EDAC0", Offset = "0x80EC8C0", VA = "0x1880EDAC0")]
		get
		{
			return default(PLKLPENELED);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x80EDB70", Offset = "0x80EC970", VA = "0x1880EDB70")]
	public PLKLPENELED(bool LAAPKNLDNCP, bool EHGFAKDABIJ, int LJALJELCLDF, int CHHHODJIFGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct JCEGADDGPNO : IEquatable<JCEGADDGPNO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly int GBFKBOHPEJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly int ANEJMPOMHDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly int JNHACFNHEII;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xE4A080", Offset = "0xE48E80", VA = "0x180E4A080")]
	public JCEGADDGPNO(int CKFKPOAGPKN, int BMDBLBGILPC, int ILNCCKCCNPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x80EAFB0", Offset = "0x80E9DB0", VA = "0x1880EAFB0")]
	public static int FBOMJOFHFKF([In] JCEGADDGPNO PHLJLBDJNIE, [In] JCEGADDGPNO GEOHFJAPCHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x287E4B0", Offset = "0x287D2B0", VA = "0x18287E4B0", Slot = "4")]
	public bool Equals(JCEGADDGPNO LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x80EAF00", Offset = "0x80E9D00", VA = "0x1880EAF00", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x80EAFD0", Offset = "0x80E9DD0", VA = "0x1880EAFD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface BEMKHEONMPN
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DJFFIPFABLP(string GEDCJDANLCD, [Out][NotNullWhen(true)] IReadOnlyList<KLNOCLJFHKB>? NFMOHCFHBBO);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class CIPJOPPFFDL : BEMKHEONMPN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly int NAAAEOILGAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly List<(string searchString, IReadOnlyList<KLNOCLJFHKB> results)> HGDOOOHHPKA;

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x80EA420", Offset = "0x80E9220", VA = "0x1880EA420")]
	public CIPJOPPFFDL(int NAAAEOILGAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x80EA2A0", Offset = "0x80E90A0", VA = "0x1880EA2A0", Slot = "4")]
	public bool DJFFIPFABLP(string GEDCJDANLCD, [Out][NotNullWhen(true)] IReadOnlyList<KLNOCLJFHKB>? NFMOHCFHBBO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class PPNFBONOJEH
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate void EDNPGKPOKKI(IReadOnlyList<KLNOCLJFHKB> NFMOHCFHBBO);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class MMEPBEKKLAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public PPNFBONOJEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public CancellationTokenSource localCts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public string searchString;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public MMEPBEKKLAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x80EBBC0", Offset = "0x80EA9C0", VA = "0x1880EBBC0")]
		internal KLNOCLJFHKB[] PBOIBPKEEFK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct NAGLJGDGJDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public PPNFBONOJEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public string searchString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private MMEPBEKKLAJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public EDNPGKPOKKI onSearchComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private TaskAwaiter<KLNOCLJFHKB[]> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x80EC260", Offset = "0x80EB060", VA = "0x1880EC260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xAAD270", Offset = "0xAAC070", VA = "0x180AAD270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private static readonly PHLHEDGDBJO CFEMPAINFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly MEFMBCJBHHG POIMBCOJFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly GIMJHLMOJJF LDHLGGNFGCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly EJIFIOIIKDO.EOKFIHGKBMD? BDLJMNNCEKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private KLNOCLJFHKB[] KGOBNDHHKID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private CancellationTokenSource? EFFDKFEIDNL;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool HNHHLPMALBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x11DF290", Offset = "0x11DE090", VA = "0x1811DF290")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x80EF8A0", Offset = "0x80EE6A0", VA = "0x1880EF8A0")]
	public PPNFBONOJEH(MEFMBCJBHHG POIMBCOJFJM, GIMJHLMOJJF LDHLGGNFGCK, [Optional] EJIFIOIIKDO.EOKFIHGKBMD? BDLJMNNCEKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x80EF6E0", Offset = "0x80EE4E0", VA = "0x1880EF6E0")]
	[AsyncStateMachine(typeof(NAGLJGDGJDP))]
	public void KKIFBPEBOOB(string GEDCJDANLCD, EDNPGKPOKKI DINDNLKCMME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x80EF7D0", Offset = "0x80EE5D0", VA = "0x1880EF7D0")]
	public void PAEHAFKCBBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class EJIFIOIIKDO
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate int EOKFIHGKBMD(ReadOnlySpan<char> GEDCJDANLCD, ReadOnlySpan<char> PPLHFEGNMLO, int FHIIJAOHCNF);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x80EA550", Offset = "0x80E9350", VA = "0x1880EA550")]
	public static int IDBHLJMBDBN([In] KLNOCLJFHKB PHLJLBDJNIE, [In] KLNOCLJFHKB GEOHFJAPCHG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct KLNOCLJFHKB
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class KBHNCHAFNAF : IEnumerable<bool>, IEnumerable, IEnumerator<bool>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private bool <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public KLNOCLJFHKB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public KLNOCLJFHKB <>3__<>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool IEnumerator<bool>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x1272A30", Offset = "0x1271830", VA = "0x181272A30", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x80EB1F0", Offset = "0x80E9FF0", VA = "0x1880EB1F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x14884F0", Offset = "0x14872F0", VA = "0x1814884F0")]
		[DebuggerHidden]
		public KBHNCHAFNAF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x80EB040", Offset = "0x80E9E40", VA = "0x1880EB040", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x80EB1A0", Offset = "0x80E9FA0", VA = "0x1880EB1A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x80EB0E0", Offset = "0x80E9EE0", VA = "0x1880EB0E0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<bool> IEnumerable<bool>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x80EB0E0", Offset = "0x80E9EE0", VA = "0x1880EB0E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly float ANEJMPOMHDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly int GBFKBOHPEJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly ReadOnlyMemory<char> PMPCLCGKODC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly BitArray ALMJNCFCKDH;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public readonly IEnumerable<bool> CKNFPHLJEPO
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x80EB840", Offset = "0x80EA640", VA = "0x1880EB840")]
		[IteratorStateMachine(typeof(KBHNCHAFNAF))]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x80EB8D0", Offset = "0x80EA6D0", VA = "0x1880EB8D0")]
	public KLNOCLJFHKB(float BMDBLBGILPC, int CKFKPOAGPKN, ReadOnlyMemory<char> IMBAOPHEODM, IEnumerable<int> ALMJNCFCKDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct DECDIPFFOCN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly bool AJNBGPMDKBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly bool DOOPCCLDDKK;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4D7DA60", Offset = "0x4D7C860", VA = "0x184D7DA60")]
	public DECDIPFFOCN(bool GCKBOKLBIJK, bool IGJNBBCKDLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x80EA4C0", Offset = "0x80E92C0", VA = "0x1880EA4C0")]
	public string NNOEOJMMNCM(string JFJICNCOLKA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface GIMJHLMOJJF
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "0")]
	float ANEJMPOMHDK(ReadOnlySpan<char> GEDCJDANLCD, ReadOnlySpan<char> PPLHFEGNMLO, [Optional] List<int>? PFAACIBMNFM);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class POEOIEALPGD : GIMJHLMOJJF
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public readonly struct EGCLDBMCEEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public readonly float GEFGPCHJJFF;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2C0AC00", Offset = "0x2C09A00", VA = "0x182C0AC00")]
		public EGCLDBMCEEE(float GFOHIAGOMMM)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private int[] DHHCENNLLPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private int[] PKACFFEDAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private BitArray IBKBIECFJMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly EGCLDBMCEEE LIKCCDGEANE;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x80EF600", Offset = "0x80EE400", VA = "0x1880EF600")]
	public POEOIEALPGD([In] EGCLDBMCEEE LIKCCDGEANE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x80EED20", Offset = "0x80EDB20", VA = "0x1880EED20", Slot = "4")]
	public float ANEJMPOMHDK(ReadOnlySpan<char> GEDCJDANLCD, ReadOnlySpan<char> PPLHFEGNMLO, [Optional] List<int>? PFAACIBMNFM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x80EF460", Offset = "0x80EE260", VA = "0x1880EF460")]
	private void DKMLONINDKN(int DFCCCGNJINK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x80EF0A0", Offset = "0x80EDEA0", VA = "0x1880EF0A0")]
	private float BPMOJNOBEMO(ReadOnlySpan<char> GEDCJDANLCD, ReadOnlySpan<char> PPLHFEGNMLO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x80EF4F0", Offset = "0x80EE2F0", VA = "0x1880EF4F0")]
	private int OKEPPBFDLHI(ReadOnlySpan<char> NHFBKFEFOEN, ReadOnlySpan<char> IMBAOPHEODM, int CDMNFBDLHCM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class EMPJPNEOEIF : GIMJHLMOJJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly int LJALJELCLDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private BitArray? KBDPGOEEJJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private (int SearchStringIndex, int ConsecutiveCount, int Value)[] LBFGBLIKBMP;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x80EAC90", Offset = "0x80E9A90", VA = "0x1880EAC90")]
	public EMPJPNEOEIF(int LJALJELCLDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x80EA5E0", Offset = "0x80E93E0", VA = "0x1880EA5E0", Slot = "4")]
	public float ANEJMPOMHDK(ReadOnlySpan<char> GEDCJDANLCD, ReadOnlySpan<char> PPLHFEGNMLO, [Optional] List<int>? PFAACIBMNFM)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface MEFMBCJBHHG
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	IEnumerable<ReadOnlyMemory<char>> HLLDADAIDED
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class AGCNMDDMAME : MEFMBCJBHHG
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class FJDBOPBGJDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public DECDIPFFOCN settings;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public FJDBOPBGJDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x80EAE70", Offset = "0x80E9C70", VA = "0x1880EAE70")]
		internal string CABKDCOCKPB(string t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class KGPIABCHBCO : IEnumerable<ReadOnlyMemory<char>>, IEnumerable, IEnumerator<ReadOnlyMemory<char>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private ReadOnlyMemory<char> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public AGCNMDDMAME <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private ReadOnlyMemory<char> <targetsMemory>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private IEnumerator<GBPNBHEDCCM<char>> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private int <i>5__4;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		ReadOnlyMemory<char> IEnumerator<ReadOnlyMemory<char>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xD16990", Offset = "0xD15790", VA = "0x180D16990", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(ReadOnlyMemory<char>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x80EB760", Offset = "0x80EA560", VA = "0x1880EB760", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x286DA90", Offset = "0x286C890", VA = "0x18286DA90")]
		[DebuggerHidden]
		public KGPIABCHBCO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x80EB7B0", Offset = "0x80EA5B0", VA = "0x1880EB7B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x80EB290", Offset = "0x80EA090", VA = "0x1880EB290", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x80EB240", Offset = "0x80EA040", VA = "0x1880EB240")]
		private void KHMMOEFKMMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x80EB710", Offset = "0x80EA510", VA = "0x1880EB710", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x80EB660", Offset = "0x80EA460", VA = "0x1880EB660", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<ReadOnlyMemory<char>> IEnumerable<ReadOnlyMemory<char>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x80EB660", Offset = "0x80EA460", VA = "0x1880EB660", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly char[] JJAGEOLKLAE;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IEnumerable<ReadOnlyMemory<char>> HLLDADAIDED
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x80E9A70", Offset = "0x80E8870", VA = "0x1880E9A70", Slot = "4")]
		[IteratorStateMachine(typeof(KGPIABCHBCO))]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x80E9AF0", Offset = "0x80E88F0", VA = "0x1880E9AF0")]
	public AGCNMDDMAME(IEnumerable<string> POIMBCOJFJM, DECDIPFFOCN LIKCCDGEANE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class PBKBFIGLPCM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public delegate void DDGMLGBECNE(IReadOnlyList<JCEGADDGPNO> NFMOHCFHBBO, IReadOnlyList<bool> GLCFIKOOFFL);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly BEMKHEONMPN? HGDOOOHHPKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly PPNFBONOJEH NHFBKFEFOEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly DECDIPFFOCN IGKMLDKHLHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly PLKLPENELED LIKCCDGEANE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly DDGMLGBECNE JANACKLBBPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly EJIFIOIIKDO.EOKFIHGKBMD? BDLJMNNCEKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private IReadOnlyList<JCEGADDGPNO> NENPMMHGNPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private IReadOnlyList<bool> DOFNHKNNBAM;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyList<JCEGADDGPNO> DAJEAEAMCDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xA5C4F0", Offset = "0xA5B2F0", VA = "0x180A5C4F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyList<bool> FGHGJDLBODM
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA604A0", Offset = "0xA5F2A0", VA = "0x180A604A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool HNHHLPMALBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x80ED1C0", Offset = "0x80EBFC0", VA = "0x1880ED1C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x80ED1E0", Offset = "0x80EBFE0", VA = "0x1880ED1E0")]
	public PBKBFIGLPCM(IReadOnlyList<string> NKDJGEDPPKB, [In] PLKLPENELED LIKCCDGEANE, DDGMLGBECNE DINDNLKCMME, [Optional] EJIFIOIIKDO.EOKFIHGKBMD? BDLJMNNCEKM, [Optional] GIMJHLMOJJF? OIMKCKBPNAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x80EC700", Offset = "0x80EB500", VA = "0x1880EC700")]
	public void ACPPJMFDPPL(string GEDCJDANLCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x80ECAA0", Offset = "0x80EB8A0", VA = "0x1880ECAA0")]
	private void CKHCOGKEKHP(IReadOnlyList<KLNOCLJFHKB> NFMOHCFHBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x80ECFC0", Offset = "0x80EBDC0", VA = "0x1880ECFC0")]
	private int EAFGEMBNNPJ(ReadOnlySpan<char> PBOOMELBCNJ, ReadOnlySpan<char> IMBAOPHEODM, int JAGPEPKMNCP)
	{
		return default(int);
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
