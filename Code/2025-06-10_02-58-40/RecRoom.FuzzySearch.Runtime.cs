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
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA2B980", Offset = "0xA2AB80", VA = "0x180A2B980")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7C88430", Offset = "0x7C87630", VA = "0x187C88430")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA2C560", Offset = "0xA2B760", VA = "0x180A2C560")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA2C5A0", Offset = "0xA2B7A0", VA = "0x180A2C5A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _LogRegistration.RecRoom_FuzzySearch_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : LALFEIIPPKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7C88300", Offset = "0x7C87500", VA = "0x187C88300", Slot = "4")]
		public override void ELDCOJNOKAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA2B980", Offset = "0xA2AB80", VA = "0x180A2B980")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class JGHGGJMLELB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly EDDNBHIABCG FCHBBBIIPEP;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7C87930", Offset = "0x7C86B30", VA = "0x187C87930")]
	public JGHGGJMLELB(IReadOnlyCollection<string> KKCEODPHEMF, [In] ILPADKHNEHJ JMMIIAOFEBJ, [Optional] EDDNBHIABCG.AACMGMHNPFA CCHPMJICALB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7C87550", Offset = "0x7C86750", VA = "0x187C87550")]
	public IReadOnlyList<EDOCEFMFNKC> EFMINOJCHMA(string IDEBKIHFFKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7C87790", Offset = "0x7C86990", VA = "0x187C87790")]
	public void NCFILEPAGDC(string IDEBKIHFFKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class EDDNBHIABCG
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public delegate int AACMGMHNPFA(IReadOnlyList<char> GMMAPNCHOJK, int NJMDDNLANJJ, string KGEHHNFELOC);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly ILPADKHNEHJ MKPDPOJHDHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly AACMGMHNPFA FFJBFOCGHAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly char[] DIGDKKCPKOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly EDOCEFMFNKC[] FAFJLKPDBHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly bool[] BFILKKHMELG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly (int SearchStringIndex, int ConsecutiveCount, int Value)[] KPFFEOMOFHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly EDOCEFMFNKC[] ILMONMGIIEI;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xA02C70", Offset = "0xA01E70", VA = "0x180A02C70")]
	public static int AONGFPCGNHO(IReadOnlyList<char> GMMAPNCHOJK, int NJMDDNLANJJ, string KGEHHNFELOC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7C85BF0", Offset = "0x7C84DF0", VA = "0x187C85BF0")]
	public EDDNBHIABCG(IReadOnlyCollection<string> KKCEODPHEMF, [In] ILPADKHNEHJ JMMIIAOFEBJ, [Optional] AACMGMHNPFA CCHPMJICALB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7C85560", Offset = "0x7C84760", VA = "0x187C85560")]
	public string LEPJAMECEDN(string IDEBKIHFFKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7C85550", Offset = "0x7C84750", VA = "0x187C85550")]
	public int DPFCCAEGNNJ(int PNECGKPBNCO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7C855F0", Offset = "0x7C847F0", VA = "0x187C855F0")]
	public int NCFILEPAGDC(string IDEBKIHFFKJ, int KLLHDEOOHKD, int ECJNHLKNOLA, int NJMDDNLANJJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct ILPADKHNEHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public readonly bool FNCBJMHOBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly bool IGJDJMOFOAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly int GGLGIJECJJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly int FNNOIPNMPDA;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly ILPADKHNEHJ KGGHPPJLGLO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static ILPADKHNEHJ LGHIFDBIJOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7C871F0", Offset = "0x7C863F0", VA = "0x187C871F0")]
		get
		{
			return default(ILPADKHNEHJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7C872A0", Offset = "0x7C864A0", VA = "0x187C872A0")]
	public ILPADKHNEHJ(bool BPPKAHDKMIA, bool LLHHBHBPDPF, int HOOLKFGLGOA, int OJJLJJDPJAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct EDOCEFMFNKC : IEquatable<EDOCEFMFNKC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly int IJCKDBACFFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly int NCFILEPAGDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly int CKNIJKBDHME;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xD94DA0", Offset = "0xD93FA0", VA = "0x180D94DA0")]
	public EDOCEFMFNKC(int CMDFFDAPDIB, int BBLNLENFHJP, int PCIFPBFLJFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7C86800", Offset = "0x7C85A00", VA = "0x187C86800")]
	public static int JAAFONABMEC([In] EDOCEFMFNKC LNELGBOPHHN, [In] EDOCEFMFNKC CKNMBJOIDBN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x275A540", Offset = "0x2759740", VA = "0x18275A540", Slot = "4")]
	public bool Equals(EDOCEFMFNKC CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7C866E0", Offset = "0x7C858E0", VA = "0x187C866E0", Slot = "0")]
	public override bool Equals(object KFMNDOMPAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7C86790", Offset = "0x7C85990", VA = "0x187C86790", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface IMLPGDACKLL
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CMGLIKEJJOI(string IDEBKIHFFKJ, [Out][NotNullWhen(true)] IReadOnlyList<DBJCOALBJKG>? MGKDBALIGKJ);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class ENGKPDALHJB : IMLPGDACKLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly int JMHOCOCDAKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly List<(string searchString, IReadOnlyList<DBJCOALBJKG> results)> CIJAONNPDBG;

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7C869A0", Offset = "0x7C85BA0", VA = "0x187C869A0")]
	public ENGKPDALHJB(int JMHOCOCDAKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7C86820", Offset = "0x7C85A20", VA = "0x187C86820", Slot = "4")]
	public bool CMGLIKEJJOI(string IDEBKIHFFKJ, [Out][NotNullWhen(true)] IReadOnlyList<DBJCOALBJKG>? MGKDBALIGKJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class FADBHHJKFJK
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate void NLCGDBEPJKG(IReadOnlyList<DBJCOALBJKG> MGKDBALIGKJ);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class MJBABKNNOFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public FADBHHJKFJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public string searchString;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public MJBABKNNOFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7C88400", Offset = "0x7C87600", VA = "0x187C88400")]
		internal DBJCOALBJKG[] LMDCJGGDLMK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct AKCGEAMNGMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public FADBHHJKFJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public string searchString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public NLCGDBEPJKG onSearchComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private CancellationTokenSource <localCts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter<DBJCOALBJKG[]> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7C83D10", Offset = "0x7C82F10", VA = "0x187C83D10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xA508E0", Offset = "0xA4FAE0", VA = "0x180A508E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private static readonly KEPOMIIOHBM EBHKLAMEJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private CancellationTokenSource? JBKLDOEMDAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly OEIGCHLIPHB HLOIBANPLML;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool FPAOJODCBHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA517C0", Offset = "0xA509C0", VA = "0x180A517C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0xD7C100", Offset = "0xD7B300", VA = "0x180D7C100")]
	public FADBHHJKFJK(OEIGCHLIPHB HLOIBANPLML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7C86A80", Offset = "0x7C85C80", VA = "0x187C86A80")]
	[AsyncStateMachine(typeof(AKCGEAMNGMA))]
	public void EFMINOJCHMA(string IDEBKIHFFKJ, NLCGDBEPJKG NEEHHHCEFDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7C86A40", Offset = "0x7C85C40", VA = "0x187C86A40")]
	public void BHDHLEMKOHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class MANHJGCHCAG
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7C88390", Offset = "0x7C87590", VA = "0x187C88390")]
	public static FADBHHJKFJK MOMANLCIFNL(this OEIGCHLIPHB HLOIBANPLML)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class OEIGCHLIPHB
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate int KAHNCBBKNFI(ReadOnlySpan<char> IDEBKIHFFKJ, ReadOnlySpan<char> IBPEACCKEOM, int ENLFEDHAFPI);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly EBOLPFEMGIF FBNDONAGNIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly IIBACJEKILI JGOAMKIEOBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly KAHNCBBKNFI? IBFKGGDGOHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private DBJCOALBJKG[] PPOGEEBPJDE;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7C88BB0", Offset = "0x7C87DB0", VA = "0x187C88BB0")]
	public OEIGCHLIPHB(EBOLPFEMGIF FBNDONAGNIN, IIBACJEKILI JGOAMKIEOBC, [Optional] KAHNCBBKNFI? IBFKGGDGOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7C884B0", Offset = "0x7C876B0", VA = "0x187C884B0")]
	public DBJCOALBJKG[] EFMINOJCHMA(string IDEBKIHFFKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7C88B20", Offset = "0x7C87D20", VA = "0x187C88B20")]
	private static int IKAHIGAJOPI([In] DBJCOALBJKG LNELGBOPHHN, [In] DBJCOALBJKG CKNMBJOIDBN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct DBJCOALBJKG
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class IPEKPJBMPCE : IEnumerable<bool>, IEnumerable, IEnumerator<bool>, IEnumerator, IDisposable
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
		public DBJCOALBJKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public DBJCOALBJKG <>3__<>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool IEnumerator<bool>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x11891F0", Offset = "0x11883F0", VA = "0x1811891F0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x7C87470", Offset = "0x7C86670", VA = "0x187C87470", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x137E0F0", Offset = "0x137D2F0", VA = "0x18137E0F0")]
		[DebuggerHidden]
		public IPEKPJBMPCE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7C872C0", Offset = "0x7C864C0", VA = "0x187C872C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7C87420", Offset = "0x7C86620", VA = "0x187C87420", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7C87360", Offset = "0x7C86560", VA = "0x187C87360", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<bool> IEnumerable<bool>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7C87360", Offset = "0x7C86560", VA = "0x187C87360", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly float NCFILEPAGDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly int IJCKDBACFFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly ReadOnlyMemory<char> LKGCIHHLLAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly BitArray BFANCGMIEMK;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public readonly IEnumerable<bool> OMKBFPNFODD
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7C84A10", Offset = "0x7C83C10", VA = "0x187C84A10")]
		[IteratorStateMachine(typeof(IPEKPJBMPCE))]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7C84AA0", Offset = "0x7C83CA0", VA = "0x187C84AA0")]
	public DBJCOALBJKG(float BBLNLENFHJP, int CMDFFDAPDIB, ReadOnlyMemory<char> LBPEJPMBIKP, IEnumerable<int> BFANCGMIEMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct LCDPHCNJMIF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly bool FNCBJMHOBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly bool IGJDJMOFOAB;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4F33EB0", Offset = "0x4F330B0", VA = "0x184F33EB0")]
	public LCDPHCNJMIF(bool FCHCHKEMPEG, bool CMNAHFOPLIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7C87B10", Offset = "0x7C86D10", VA = "0x187C87B10")]
	public string GIEHMPHGEFA(string EBPGPJLLHDI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface IIBACJEKILI
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	float NCFILEPAGDC(ReadOnlySpan<char> IDEBKIHFFKJ, ReadOnlySpan<char> IBPEACCKEOM, [Optional] List<int>? DFKGOEHPKIA);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class BBDGBLKOJGE : IIBACJEKILI
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public readonly struct HGGPDHAIOLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public readonly float DODMMGEJGHK;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2ACD610", Offset = "0x2ACC810", VA = "0x182ACD610")]
		public HGGPDHAIOLP(float MDCNKPIIKHA)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private int[] DHLNGAGPPML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private int[] AEKJHBCIFEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private BitArray HGMPCPFEFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly HGGPDHAIOLP JMMIIAOFEBJ;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7C84930", Offset = "0x7C83B30", VA = "0x187C84930")]
	public BBDGBLKOJGE([In] HGGPDHAIOLP JMMIIAOFEBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7C844A0", Offset = "0x7C836A0", VA = "0x187C844A0", Slot = "4")]
	public float NCFILEPAGDC(ReadOnlySpan<char> IDEBKIHFFKJ, ReadOnlySpan<char> IBPEACCKEOM, [Optional] List<int>? DFKGOEHPKIA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7C84410", Offset = "0x7C83610", VA = "0x187C84410")]
	private void JEFHDHACKLF(int GCFCAGDGDIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7C840A0", Offset = "0x7C832A0", VA = "0x187C840A0")]
	private float JDECJLJJPDI(ReadOnlySpan<char> IDEBKIHFFKJ, ReadOnlySpan<char> IBPEACCKEOM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7C84820", Offset = "0x7C83A20", VA = "0x187C84820")]
	private int PHAKFDAEHIC(ReadOnlySpan<char> HLOIBANPLML, ReadOnlySpan<char> LBPEJPMBIKP, int KJLHNNMPIDP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class LPPFINFGFAM : IIBACJEKILI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly int HOOLKFGLGOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private BitArray? ODFNFIPHJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private (int SearchStringIndex, int ConsecutiveCount, int Value)[] MAHCNPPKHPP;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7C88250", Offset = "0x7C87450", VA = "0x187C88250")]
	public LPPFINFGFAM(int HOOLKFGLGOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7C87BA0", Offset = "0x7C86DA0", VA = "0x187C87BA0", Slot = "4")]
	public float NCFILEPAGDC(ReadOnlySpan<char> IDEBKIHFFKJ, ReadOnlySpan<char> IBPEACCKEOM, [Optional] List<int>? DFKGOEHPKIA)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface EBOLPFEMGIF
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	IEnumerable<ReadOnlyMemory<char>> PJDPOECFDGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class DNGEFJKNEDI : EBOLPFEMGIF
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class JEFCLFPLNPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public LCDPHCNJMIF settings;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public JEFCLFPLNPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7C874C0", Offset = "0x7C866C0", VA = "0x187C874C0")]
		internal string GDFIBKODBPE(string t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class GGNFNMBFBAA : IEnumerable<ReadOnlyMemory<char>>, IEnumerable, IEnumerator<ReadOnlyMemory<char>>, IEnumerator, IDisposable
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
		public DNGEFJKNEDI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private ReadOnlyMemory<char> <targetsMemory>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private IEnumerator<JHCDFNNIJMI<char>> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private int <i>5__4;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		ReadOnlyMemory<char> IEnumerator<ReadOnlyMemory<char>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xC6A9E0", Offset = "0xC69BE0", VA = "0x180C6A9E0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(ReadOnlyMemory<char>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x7C87110", Offset = "0x7C86310", VA = "0x187C87110", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x2749C30", Offset = "0x2748E30", VA = "0x182749C30")]
		[DebuggerHidden]
		public GGNFNMBFBAA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7C87160", Offset = "0x7C86360", VA = "0x187C87160", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7C86C40", Offset = "0x7C85E40", VA = "0x187C86C40", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7C86BF0", Offset = "0x7C85DF0", VA = "0x187C86BF0")]
		private void DOCBGIOIEEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7C870C0", Offset = "0x7C862C0", VA = "0x187C870C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7C87010", Offset = "0x7C86210", VA = "0x187C87010", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<ReadOnlyMemory<char>> IEnumerable<ReadOnlyMemory<char>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7C87010", Offset = "0x7C86210", VA = "0x187C87010", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly char[] LLFHEKOBCKK;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IEnumerable<ReadOnlyMemory<char>> PJDPOECFDGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7C84D10", Offset = "0x7C83F10", VA = "0x187C84D10", Slot = "4")]
		[IteratorStateMachine(typeof(GGNFNMBFBAA))]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7C84D90", Offset = "0x7C83F90", VA = "0x187C84D90")]
	public DNGEFJKNEDI(IEnumerable<string> FBNDONAGNIN, LCDPHCNJMIF JMMIIAOFEBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class OLJHPJMNBEL<TSchedulerContext> : IDisposable where TSchedulerContext : notnull, MonoBehaviour, DJNFGEJICJL
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public delegate void EDJDKCKADNN(IReadOnlyList<EDOCEFMFNKC> MGKDBALIGKJ, IReadOnlyList<bool> DINBJOOMAIH);

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private const string COBGDMOFPGP = "r2adoption_2025q2_better_palette_search";

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private const string MMKKNDNAJAF = "algorithm";

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static ABCAKKCKJPM? BFEDBNCCFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly IMLPGDACKLL? CIJAONNPDBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly FADBHHJKFJK HLOIBANPLML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly LCDPHCNJMIF CGJGMIEBJFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly ILPADKHNEHJ JMMIIAOFEBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly EDJDKCKADNN DDMJHOGDMKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly OEIGCHLIPHB.KAHNCBBKNFI? IBFKGGDGOHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private IReadOnlyList<EDOCEFMFNKC> IPJHIDCBJCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private IReadOnlyList<bool> HIGKBOBFIAD;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyList<EDOCEFMFNKC> DBOALMPFBCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xA00F70", Offset = "0xA00170", VA = "0x180A00F70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyList<bool> HJMIMIAJEJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA0D650", Offset = "0xA0C850", VA = "0x180A0D650")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool FPAOJODCBHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x562BDF0", Offset = "0x562AFF0", VA = "0x18562BDF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x562C010", Offset = "0x562B210", VA = "0x18562C010")]
	public OLJHPJMNBEL(IReadOnlyList<string> KKCEODPHEMF, [In] ILPADKHNEHJ JMMIIAOFEBJ, EDJDKCKADNN NEEHHHCEFDB, [Optional] OEIGCHLIPHB.KAHNCBBKNFI? IBFKGGDGOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x562B380", Offset = "0x562A580", VA = "0x18562B380")]
	public void BGDEIBFOBAB(string IDEBKIHFFKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x562B890", Offset = "0x562AA90", VA = "0x18562B890")]
	private void HLNMOODPDLP(IReadOnlyList<DBJCOALBJKG> MGKDBALIGKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x562BE10", Offset = "0x562B010", VA = "0x18562BE10")]
	private int PGLMFLMEKLN(ReadOnlySpan<char> MLMPPNLIAEF, ReadOnlySpan<char> LBPEJPMBIKP, int PJHDFEIMDPC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x562B500", Offset = "0x562A700", VA = "0x18562B500")]
	private IIBACJEKILI CIGIEGFAAAI()
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
