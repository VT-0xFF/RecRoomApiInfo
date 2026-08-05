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
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
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
		[Cpp2IlInjected.Address(RVA = "0x85321F0", Offset = "0x85307F0", VA = "0x1885321F0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD1900", Offset = "0xACFF00", VA = "0x180AD1900")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD1940", Offset = "0xACFF40", VA = "0x180AD1940")]
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
	public class LogRegistrationIndex : DHBOPDJGFAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x85320D0", Offset = "0x85306D0", VA = "0x1885320D0", Slot = "4")]
		public override void NCEHDCEOICJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class GEBLNBFNIAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly IAFKANIBPPA NAGACDOJNOK;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x852F110", Offset = "0x852D710", VA = "0x18852F110")]
	public GEBLNBFNIAM(IReadOnlyCollection<string> ACNEHNJLAGN, [In] KHGIJIJPKMD CJEINKGIPEA, [Optional] IAFKANIBPPA.MIKCEANMKFO CCFEGPLOACE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x852ED30", Offset = "0x852D330", VA = "0x18852ED30")]
	public IReadOnlyList<PAIFOJAKDGM> AGLAADFCPKO(string DKIGKNAJOEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x852EF70", Offset = "0x852D570", VA = "0x18852EF70")]
	public void PAEBLMNHPEM(string DKIGKNAJOEE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class IAFKANIBPPA
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public delegate int MIKCEANMKFO(IReadOnlyList<char> CFGIEDPDKFP, int BGHFEKJGFFM, string HPKGHGMIDNG);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly KHGIJIJPKMD ANFDENLGPIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly MIKCEANMKFO JNPIAKDPLEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly char[] BOFMMEFKICF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly PAIFOJAKDGM[] KPNDEMDNCDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly bool[] PFMPNAHDICI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly (int SearchStringIndex, int ConsecutiveCount, int Value)[] JCFEPLMICLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly PAIFOJAKDGM[] PHNNJBNGGDI;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990")]
	public static int NFDILHFJNFJ(IReadOnlyList<char> CFGIEDPDKFP, int BGHFEKJGFFM, string HPKGHGMIDNG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8530120", Offset = "0x852E720", VA = "0x188530120")]
	public IAFKANIBPPA(IReadOnlyCollection<string> ACNEHNJLAGN, [In] KHGIJIJPKMD CJEINKGIPEA, [Optional] MIKCEANMKFO CCFEGPLOACE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x852FA80", Offset = "0x852E080", VA = "0x18852FA80")]
	public string AKHJLKPCKND(string DKIGKNAJOEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x852FB10", Offset = "0x852E110", VA = "0x18852FB10")]
	public int OFNDBAGIKEA(int DKMJEFDNGPD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x852FB20", Offset = "0x852E120", VA = "0x18852FB20")]
	public int PAEBLMNHPEM(string DKIGKNAJOEE, int BBIIAHLDKLG, int IBCFBJPFCBD, int BGHFEKJGFFM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct KHGIJIJPKMD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public readonly bool HCBNOHBECBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly bool OJCLJOICJBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly int AAAGNNEJFHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly int LJKGPLCHGEE;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly KHGIJIJPKMD EJHILEHCAHF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static KHGIJIJPKMD DKABDBMACEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8531BE0", Offset = "0x85301E0", VA = "0x188531BE0")]
		get
		{
			return default(KHGIJIJPKMD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8531C90", Offset = "0x8530290", VA = "0x188531C90")]
	public KHGIJIJPKMD(bool GJGHBDHDHBE, bool JGICLGHJDGL, int CLANAPKKEOB, int NEIFIAKMALL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct PAIFOJAKDGM : IEquatable<PAIFOJAKDGM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly int GKFLGCDAIDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly int PAEBLMNHPEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly int DJJNCONOLEH;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xEC73E0", Offset = "0xEC59E0", VA = "0x180EC73E0")]
	public PAIFOJAKDGM(int PMIGBJGNLLP, int EJPOHPCGFGJ, int LAMFJEMEPHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8532270", Offset = "0x8530870", VA = "0x188532270")]
	public static int CILBCGJEFAO([In] PAIFOJAKDGM BNPLNGPMIIG, [In] PAIFOJAKDGM DIIGMDFDOAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x29DA190", Offset = "0x29D8790", VA = "0x1829DA190", Slot = "4")]
	public bool Equals(PAIFOJAKDGM AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8532290", Offset = "0x8530890", VA = "0x188532290", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8532340", Offset = "0x8530940", VA = "0x188532340", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface FHOFACELBFE
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KBOJFECPONG(string DKIGKNAJOEE, [Out][NotNullWhen(true)] IReadOnlyList<EMHJPNOKNFA>? NDPLDEAJBHH);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class GFBBCFMDFNB : FHOFACELBFE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly int LFLFGGPKOMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly List<(string searchString, IReadOnlyList<EMHJPNOKNFA> results)> CFAIGLCJBOA;

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x852F340", Offset = "0x852D940", VA = "0x18852F340")]
	public GFBBCFMDFNB(int LFLFGGPKOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x852F1C0", Offset = "0x852D7C0", VA = "0x18852F1C0", Slot = "4")]
	public bool KBOJFECPONG(string DKIGKNAJOEE, [Out][NotNullWhen(true)] IReadOnlyList<EMHJPNOKNFA>? NDPLDEAJBHH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class CMBKLKPOKAB
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate void GPLGHDIBFMJ(IReadOnlyList<EMHJPNOKNFA> NDPLDEAJBHH);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class HGPNAIFBEFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public CMBKLKPOKAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public CancellationTokenSource localCts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public string searchString;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public HGPNAIFBEFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x852F3E0", Offset = "0x852D9E0", VA = "0x18852F3E0")]
		internal EMHJPNOKNFA[] BPDKBIJNIAO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct LNCFMJOBCMB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public CMBKLKPOKAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public string searchString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private HGPNAIFBEFL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public GPLGHDIBFMJ onSearchComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private TaskAwaiter<EMHJPNOKNFA[]> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8531CB0", Offset = "0x85302B0", VA = "0x188531CB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xB035A0", Offset = "0xB01BA0", VA = "0x180B035A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private static readonly IPHNFELODMJ AMCHCCAPJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly FBHKAFOGMCN OAOCMEKPNDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly FHBGKMBFDOF MIPGPKCIFAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly MAHINHJJAGG.DCCLKNEDLEF? JCFOOGLHMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private EMHJPNOKNFA[] NOJMFFKBLCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private CancellationTokenSource? COAFJLBNMKC;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool GLELAOKEOCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x129E8A0", Offset = "0x129CEA0", VA = "0x18129E8A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x852CEF0", Offset = "0x852B4F0", VA = "0x18852CEF0")]
	public CMBKLKPOKAB(FBHKAFOGMCN OAOCMEKPNDE, FHBGKMBFDOF MIPGPKCIFAN, [Optional] MAHINHJJAGG.DCCLKNEDLEF? JCFOOGLHMPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x852CD30", Offset = "0x852B330", VA = "0x18852CD30")]
	[AsyncStateMachine(typeof(LNCFMJOBCMB))]
	public void AGLAADFCPKO(string DKIGKNAJOEE, GPLGHDIBFMJ LIBFEPKKINN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x852CE20", Offset = "0x852B420", VA = "0x18852CE20")]
	public void ICBGPFPDLLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class MAHINHJJAGG
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate int DCCLKNEDLEF(ReadOnlySpan<char> DKIGKNAJOEE, ReadOnlySpan<char> KCCCKNOMPHA, int NIOMDAEKDJH);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8532160", Offset = "0x8530760", VA = "0x188532160")]
	public static int ACBPCBNEMKD([In] EMHJPNOKNFA BNPLNGPMIIG, [In] EMHJPNOKNFA DIIGMDFDOAL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct EMHJPNOKNFA
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class DDICIGFHAIO : IEnumerable<bool>, IEnumerable, IEnumerator<bool>, IEnumerator, IDisposable
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
		public EMHJPNOKNFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public EMHJPNOKNFA <>3__<>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool IEnumerator<bool>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x1342CD0", Offset = "0x13412D0", VA = "0x181342CD0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x852D280", Offset = "0x852B880", VA = "0x18852D280", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x15BD540", Offset = "0x15BBB40", VA = "0x1815BD540")]
		[DebuggerHidden]
		public DDICIGFHAIO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x852D0D0", Offset = "0x852B6D0", VA = "0x18852D0D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x852D230", Offset = "0x852B830", VA = "0x18852D230", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x852D170", Offset = "0x852B770", VA = "0x18852D170", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<bool> IEnumerable<bool>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x852D170", Offset = "0x852B770", VA = "0x18852D170", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly float PAEBLMNHPEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly int GKFLGCDAIDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly ReadOnlyMemory<char> KNAGOCPIAEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly BitArray IHPDIMLLPIF;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public readonly IEnumerable<bool> IFCABDLAANA
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x852D2D0", Offset = "0x852B8D0", VA = "0x18852D2D0")]
		[IteratorStateMachine(typeof(DDICIGFHAIO))]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x852D360", Offset = "0x852B960", VA = "0x18852D360")]
	public EMHJPNOKNFA(float EJPOHPCGFGJ, int PMIGBJGNLLP, ReadOnlyMemory<char> AMMKGILEHBG, IEnumerable<int> IHPDIMLLPIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct EMKDGCOKKJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly bool HCBNOHBECBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly bool OJCLJOICJBO;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x466E150", Offset = "0x466C750", VA = "0x18466E150")]
	public EMKDGCOKKJA(bool MCJLGAFILLK, bool JBHOIKAAPEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x852D5D0", Offset = "0x852BBD0", VA = "0x18852D5D0")]
	public string ENMJPKHIOPK(string DPCMOBNBPGE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface FHBGKMBFDOF
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "0")]
	float PAEBLMNHPEM(ReadOnlySpan<char> DKIGKNAJOEE, ReadOnlySpan<char> KCCCKNOMPHA, [Optional] List<int>? NCANAPAKLNH);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class KAKGFEABEKF : FHBGKMBFDOF
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public readonly struct PFPNAOOMPJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public readonly float PDAJGKCBDGP;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2DB7900", Offset = "0x2DB5F00", VA = "0x182DB7900")]
		public PFPNAOOMPJJ(float DIJDIABPMJH)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private int[] LIAAIOEGNAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private int[] ELFKNLPLLNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private BitArray KHDLOGNEGBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly PFPNAOOMPJJ CJEINKGIPEA;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8531B00", Offset = "0x8530100", VA = "0x188531B00")]
	public KAKGFEABEKF([In] PFPNAOOMPJJ CJEINKGIPEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8531780", Offset = "0x852FD80", VA = "0x188531780", Slot = "4")]
	public float PAEBLMNHPEM(ReadOnlySpan<char> DKIGKNAJOEE, ReadOnlySpan<char> KCCCKNOMPHA, [Optional] List<int>? NCANAPAKLNH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x8531220", Offset = "0x852F820", VA = "0x188531220")]
	private void FBHKJBGHJMA(int KCJLCGFEBMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x85312B0", Offset = "0x852F8B0", VA = "0x1885312B0")]
	private float GKLCJMENCHI(ReadOnlySpan<char> DKIGKNAJOEE, ReadOnlySpan<char> KCCCKNOMPHA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x8531670", Offset = "0x852FC70", VA = "0x188531670")]
	private int JMNIACONADP(ReadOnlySpan<char> HLAGGBMMKAP, ReadOnlySpan<char> AMMKGILEHBG, int GNALGMGIGDH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class GABNMIONBKG : FHBGKMBFDOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly int CLANAPKKEOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private BitArray? ENAIFIFGFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private (int SearchStringIndex, int ConsecutiveCount, int Value)[] KLPKEGHIAAI;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x852EC80", Offset = "0x852D280", VA = "0x18852EC80")]
	public GABNMIONBKG(int CLANAPKKEOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x852E5D0", Offset = "0x852CBD0", VA = "0x18852E5D0", Slot = "4")]
	public float PAEBLMNHPEM(ReadOnlySpan<char> DKIGKNAJOEE, ReadOnlySpan<char> KCCCKNOMPHA, [Optional] List<int>? NCANAPAKLNH)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface FBHKAFOGMCN
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	IEnumerable<ReadOnlyMemory<char>> HCLNOBEBHCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class AKDJHMPFMFN : FBHKAFOGMCN
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class AHBKADOIKAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public EMKDGCOKKJA settings;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public AHBKADOIKAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x852C460", Offset = "0x852AA60", VA = "0x18852C460")]
		internal string KJLMOGFJHPI(string t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class JCKNGICDIHO : IEnumerable<ReadOnlyMemory<char>>, IEnumerable, IEnumerator<ReadOnlyMemory<char>>, IEnumerator, IDisposable
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
		public AKDJHMPFMFN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private ReadOnlyMemory<char> <targetsMemory>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private IEnumerator<OAJLGEIIFFE<char>> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private int <i>5__4;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		ReadOnlyMemory<char> IEnumerator<ReadOnlyMemory<char>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xBF19C0", Offset = "0xBEFFC0", VA = "0x180BF19C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x8531140", Offset = "0x852F740", VA = "0x188531140", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xBF1B00", Offset = "0xBF0100", VA = "0x180BF1B00")]
		[DebuggerHidden]
		public JCKNGICDIHO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8531190", Offset = "0x852F790", VA = "0x188531190", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8530C70", Offset = "0x852F270", VA = "0x188530C70", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8530C20", Offset = "0x852F220", VA = "0x188530C20")]
		private void MPMIGDGBFBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x85310F0", Offset = "0x852F6F0", VA = "0x1885310F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8531040", Offset = "0x852F640", VA = "0x188531040", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<ReadOnlyMemory<char>> IEnumerable<ReadOnlyMemory<char>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8531040", Offset = "0x852F640", VA = "0x188531040", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly char[] IKIOFJPELIO;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IEnumerable<ReadOnlyMemory<char>> HCLNOBEBHCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x852C4F0", Offset = "0x852AAF0", VA = "0x18852C4F0", Slot = "4")]
		[IteratorStateMachine(typeof(JCKNGICDIHO))]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x852C570", Offset = "0x852AB70", VA = "0x18852C570")]
	public AKDJHMPFMFN(IEnumerable<string> OAOCMEKPNDE, EMKDGCOKKJA CJEINKGIPEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class FPDFJCOKKMH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public delegate void ABICMOAKAKF(IReadOnlyList<PAIFOJAKDGM> NDPLDEAJBHH, IReadOnlyList<bool> HPKGCJIAJNC);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly FHOFACELBFE? CFAIGLCJBOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly CMBKLKPOKAB HLAGGBMMKAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly EMKDGCOKKJA EDBFLABBBEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly KHGIJIJPKMD CJEINKGIPEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly ABICMOAKAKF KMJCEAMAEOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly MAHINHJJAGG.DCCLKNEDLEF? JCFOOGLHMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private IReadOnlyList<PAIFOJAKDGM> FLCOCEFDGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private IReadOnlyList<bool> AHINCIEFGFA;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyList<PAIFOJAKDGM> HHNHDILIMEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xAA5620", Offset = "0xAA3C20", VA = "0x180AA5620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyList<bool> FFAKCFCCMBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xAA55B0", Offset = "0xAA3BB0", VA = "0x180AA55B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool GLELAOKEOCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x852D8A0", Offset = "0x852BEA0", VA = "0x18852D8A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x852E180", Offset = "0x852C780", VA = "0x18852E180")]
	public FPDFJCOKKMH(IReadOnlyList<string> ACNEHNJLAGN, [In] KHGIJIJPKMD CJEINKGIPEA, ABICMOAKAKF LIBFEPKKINN, [Optional] MAHINHJJAGG.DCCLKNEDLEF? JCFOOGLHMPA, [Optional] FHBGKMBFDOF? FNFFAJCOFOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x852D8C0", Offset = "0x852BEC0", VA = "0x18852D8C0")]
	public void HNILBCCPJME(string DKIGKNAJOEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x852D860", Offset = "0x852BE60", VA = "0x18852D860", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x852DC60", Offset = "0x852C260", VA = "0x18852DC60")]
	private void IJBBNPENOOD(IReadOnlyList<EMHJPNOKNFA> NDPLDEAJBHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x852D660", Offset = "0x852BC60", VA = "0x18852D660")]
	private int APAOLJNENJA(ReadOnlySpan<char> NGOJMGCIOHB, ReadOnlySpan<char> AMMKGILEHBG, int CDNADLIMHFG)
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
