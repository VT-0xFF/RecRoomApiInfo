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
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xAD08C0", Offset = "0xACEEC0", VA = "0x180AD08C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8541760", Offset = "0x853FD60", VA = "0x188541760")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD0950", Offset = "0xACEF50", VA = "0x180AD0950")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD0990", Offset = "0xACEF90", VA = "0x180AD0990")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _LogRegistration.RecRoom_FuzzySearch_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8541650", Offset = "0x853FC50", VA = "0x188541650", Slot = "4")]
		public override void KQPXXDZDTRT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xAD08C0", Offset = "0xACEEC0", VA = "0x180AD08C0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.FuzzySearch
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class XNYPMQTCDSD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly UYFDASGPYBZ WKRMYUPJBSF;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8545A80", Offset = "0x8544080", VA = "0x188545A80")]
		public XNYPMQTCDSD(IReadOnlyCollection<string> a, [In] FuzzySearchSettings settings, [Optional] UYFDASGPYBZ.AdditionalScoreHeuristicDelegate b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8545840", Offset = "0x8543E40", VA = "0x188545840")]
		public IReadOnlyList<FuzzySearchStringScored> Search(string searchString)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x85456A0", Offset = "0x8543CA0", VA = "0x1885456A0")]
		public void Score(string searchString)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class UYFDASGPYBZ
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public delegate int AdditionalScoreHeuristicDelegate(IReadOnlyList<char> searchableStringsPreprocessed, int searchableStringIndex, string preprocessedSearchString);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly FuzzySearchSettings IGDRKOLTAWR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly AdditionalScoreHeuristicDelegate HNBOXSIRRNV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly char[] KGLUOCFPPCR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly FuzzySearchStringScored[] JXQUNSAPXOR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly bool[] GTMWDLTPWGV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public readonly (int SearchStringIndex, int ConsecutiveCount, int Value)[] GLZOZUAMGLV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly FuzzySearchStringScored[] XIAOAEULOKZ;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860")]
		public static int UYKHPPWYOHE(IReadOnlyList<char> a, int b, string c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8544420", Offset = "0x8542A20", VA = "0x188544420")]
		public UYFDASGPYBZ(IReadOnlyCollection<string> a, [In] FuzzySearchSettings settings, [Optional] AdditionalScoreHeuristicDelegate b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8543D80", Offset = "0x8542380", VA = "0x188543D80")]
		public string IUAPAFLTCEH(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8543E10", Offset = "0x8542410", VA = "0x188543E10")]
		public int POKFNMSJSLL(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8543E20", Offset = "0x8542420", VA = "0x188543E20")]
		public int Score(string searchString, int stringsSoFar, int perfectScore, int searchableStringIndex)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct FuzzySearchSettings
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public readonly bool ShouldIgnoreCase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public readonly bool ShouldIgnoreSpaces;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public readonly int WordStartBonus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public readonly int PerfectMatchBonus;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static readonly FuzzySearchSettings _default;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static FuzzySearchSettings AMLVLGFTEOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x85408A0", Offset = "0x853EEA0", VA = "0x1885408A0")]
			get
			{
				return default(FuzzySearchSettings);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8540950", Offset = "0x853EF50", VA = "0x188540950")]
		public FuzzySearchSettings(bool shouldIgnoreCase, bool shouldIgnoreSpaces, int wordStartBonus, int perfectMatchBonus)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct FuzzySearchStringScored : IEquatable<FuzzySearchStringScored>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly int Index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly int Score;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly int MatchesIndex;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xF2F310", Offset = "0xF2D910", VA = "0x180F2F310")]
		public FuzzySearchStringScored(int index, int score, int matchesIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8540970", Offset = "0x853EF70", VA = "0x188540970")]
		public static int DKBAQVVDOPQ([In] FuzzySearchStringScored lhs, [In] FuzzySearchStringScored rhs)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x298F6A0", Offset = "0x298DCA0", VA = "0x18298F6A0", Slot = "4")]
		public bool Equals(FuzzySearchStringScored other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8540990", Offset = "0x853EF90", VA = "0x188540990", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8540A40", Offset = "0x853F040", VA = "0x188540A40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface VWMSQZXITSP
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool DFWDBCGOKRJ(string a, [Out][NotNullWhen(true)] IReadOnlyList<SearchResult>? results);
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class IWUHTHCKVBO : VWMSQZXITSP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly int GNFDYRRDTCV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly List<(string searchString, IReadOnlyList<SearchResult> results)> EGMRVGKGYOG;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x85415C0", Offset = "0x853FBC0", VA = "0x1885415C0")]
		public IWUHTHCKVBO(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8541440", Offset = "0x853FA40", VA = "0x188541440", Slot = "4")]
		public bool DFWDBCGOKRJ(string a, [Out][NotNullWhen(true)] IReadOnlyList<SearchResult>? results)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class AsyncFuzzySearch
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public delegate void OnSearchComplete(IReadOnlyList<SearchResult> results);

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class TBDIAOPJOEZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public AsyncFuzzySearch CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public CancellationTokenSource GSAXKBWVMXP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public string TXRQAMMHFYZ;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public TBDIAOPJOEZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x8543160", Offset = "0x8541760", VA = "0x188543160")]
			internal SearchResult[] LMJQGPUNXBM()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private struct <Search>d__10 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public AsyncFuzzySearch <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public string searchString;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private TBDIAOPJOEZ <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public OnSearchComplete onSearchComplete;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private TaskAwaiter<SearchResult[]> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x8543850", Offset = "0x8541E50", VA = "0x188543850", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xB06220", Offset = "0xB04820", VA = "0x180B06220", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static readonly Log WOAZIZZDVRE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly NELDZJJEQZC FOXZSQGPTAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly AKRZIOHUBCN GUKZDWITZPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly DBJZEFJWNIM.AdditionalScoringHeuristic? KVOGUGOBOQO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private SearchResult[] MLXZGQHZIFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private CancellationTokenSource? EYQGTLUBPSM;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool JTZCOCTIYXZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x12F1310", Offset = "0x12EF910", VA = "0x1812F1310")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x85405D0", Offset = "0x853EBD0", VA = "0x1885405D0")]
		public AsyncFuzzySearch(NELDZJJEQZC targets, AKRZIOHUBCN algorithm, [Optional] DBJZEFJWNIM.AdditionalScoringHeuristic? additionalScoringHeuristic)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8540460", Offset = "0x853EA60", VA = "0x188540460")]
		[AsyncStateMachine(typeof(<Search>d__10))]
		public void Search(string searchString, OnSearchComplete onSearchComplete)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8540420", Offset = "0x853EA20", VA = "0x188540420")]
		public void Cancel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class DBJZEFJWNIM
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public delegate int AdditionalScoringHeuristic(ReadOnlySpan<char> searchString, ReadOnlySpan<char> targetString, int targetStringIndex);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8540680", Offset = "0x853EC80", VA = "0x188540680")]
		public static int POPCCVEPWZS([In] SearchResult lhs, [In] SearchResult rhs)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct SearchResult
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class EXRMQKDZJRX : IEnumerable<bool>, IEnumerable, IEnumerator<bool>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private int AEMBTWPORMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private bool MVWPOXUKILF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private int NVRLJVISCMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public SearchResult CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public SearchResult ASRQRNSDJHF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private int HAOYDNHAFWO;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			private bool GTYZWCJFLGS
			{
				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x138D000", Offset = "0x138B600", VA = "0x18138D000", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private object HLWKSVCMTHU
			{
				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x78D4D90", Offset = "0x78D3390", VA = "0x1878D4D90", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x15FB710", Offset = "0x15F9D10", VA = "0x1815FB710")]
			[DebuggerHidden]
			public EXRMQKDZJRX(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "7")]
			[DebuggerHidden]
			private void CJOOGEZDZDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x85407C0", Offset = "0x853EDC0", VA = "0x1885407C0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x8540860", Offset = "0x853EE60", VA = "0x188540860", Slot = "10")]
			[DebuggerHidden]
			private void VIZWRAVZEQM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x8540710", Offset = "0x853ED10", VA = "0x188540710", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<bool> ISABOGEZTQV()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8540710", Offset = "0x853ED10", VA = "0x188540710", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator MZPFIUHPQEF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public readonly float Score;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public readonly int Index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public readonly ReadOnlyMemory<char> Target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly BitArray highlightedChars;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public readonly IEnumerable<bool> OTFRRHPDLSV
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x8542E00", Offset = "0x8541400", VA = "0x188542E00")]
			[IteratorStateMachine(typeof(EXRMQKDZJRX))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8542E80", Offset = "0x8541480", VA = "0x188542E80")]
		public SearchResult(float score, int index, ReadOnlyMemory<char> target, IEnumerable<int> highlightedChars)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public readonly struct StringFormatSettings
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public readonly bool ShouldIgnoreCase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public readonly bool ShouldIgnoreSpaces;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x43059B0", Offset = "0x4303FB0", VA = "0x1843059B0")]
		public StringFormatSettings(bool ignoreCase, bool ignoreSpaces)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x85430D0", Offset = "0x85416D0", VA = "0x1885430D0")]
		public string Format(string str)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface AKRZIOHUBCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "0")]
		float Score(ReadOnlySpan<char> searchString, ReadOnlySpan<char> targetString, [Optional] List<int>? matchingCharacters);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class HDICSIDUFMN : AKRZIOHUBCN
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public readonly struct Settings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public readonly float ConsecutiveCharacterMultiplier;

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x2D563B0", Offset = "0x2D549B0", VA = "0x182D563B0")]
			public Settings(float consecutiveCharacterMultiplier)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private int[] HLTWQJYZHUQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private int[] PCLVWZLUHVT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private BitArray OLWDGNMXMGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly Settings QVFBSGRPICZ;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8541370", Offset = "0x853F970", VA = "0x188541370")]
		public HDICSIDUFMN([In] Settings settings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8540B20", Offset = "0x853F120", VA = "0x188540B20", Slot = "4")]
		public float Score(ReadOnlySpan<char> searchString, ReadOnlySpan<char> targetString, [Optional] List<int>? matchingCharacters)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8540A90", Offset = "0x853F090", VA = "0x188540A90")]
		private void IJJBMWAAGDC(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8540EA0", Offset = "0x853F4A0", VA = "0x188540EA0")]
		private float TJZIUSKEQNB(ReadOnlySpan<char> a, ReadOnlySpan<char> b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8541260", Offset = "0x853F860", VA = "0x188541260")]
		private int ZYKRJZHXCYG(ReadOnlySpan<char> a, ReadOnlySpan<char> b, int c)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class QFYPNVKWCOP : AKRZIOHUBCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly int YNQUISIBKFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private BitArray? QJOHNAIXNKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private (int SearchStringIndex, int ConsecutiveCount, int Value)[] QYKSONTUWSV;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8542D40", Offset = "0x8541340", VA = "0x188542D40")]
		public QFYPNVKWCOP(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8542690", Offset = "0x8540C90", VA = "0x188542690", Slot = "4")]
		public float Score(ReadOnlySpan<char> searchString, ReadOnlySpan<char> targetString, [Optional] List<int>? matchingCharacters)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface NELDZJJEQZC
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		IEnumerable<ReadOnlyMemory<char>> QOSROSEYFSF
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class WBHQPGNQYVD : NELDZJJEQZC
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class MVZLYDKGBFP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public StringFormatSettings QVFBSGRPICZ;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public MVZLYDKGBFP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x85416D0", Offset = "0x853FCD0", VA = "0x1885416D0")]
			internal string LZNYXWZVGYS(string a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class YYEBUJFTFWD : IEnumerable<ReadOnlyMemory<char>>, IEnumerable, IEnumerator<ReadOnlyMemory<char>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			private int AEMBTWPORMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			private ReadOnlyMemory<char> MVWPOXUKILF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			private int NVRLJVISCMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public WBHQPGNQYVD CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			private ReadOnlyMemory<char> UTVSXJDBOII;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			private IEnumerator<IndexValuePair<char>> TPVJFPGHNKB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			private int HAZLYAUUYTG;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private ReadOnlyMemory<char> ZLODYIDXDCY
			{
				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0xC5F3C0", Offset = "0xC5D9C0", VA = "0x180C5F3C0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(ReadOnlyMemory<char>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private object HLWKSVCMTHU
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x8545BB0", Offset = "0x85441B0", VA = "0x188545BB0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xC5F770", Offset = "0xC5DD70", VA = "0x180C5F770")]
			[DebuggerHidden]
			public YYEBUJFTFWD(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8545B20", Offset = "0x8544120", VA = "0x188545B20", Slot = "7")]
			[DebuggerHidden]
			private void CJOOGEZDZDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8545CF0", Offset = "0x85442F0", VA = "0x188545CF0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x8545C00", Offset = "0x8544200", VA = "0x188545C00")]
			private void KPIRURCCWVL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x85460C0", Offset = "0x85446C0", VA = "0x1885460C0", Slot = "10")]
			[DebuggerHidden]
			private void VIZWRAVZEQM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8545C50", Offset = "0x8544250", VA = "0x188545C50", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<ReadOnlyMemory<char>> WYFWOIIHUET()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8545C50", Offset = "0x8544250", VA = "0x188545C50", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator MZPFIUHPQEF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly char[] JFWINWHYYRE;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IEnumerable<ReadOnlyMemory<char>> QOSROSEYFSF
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8544EA0", Offset = "0x85434A0", VA = "0x188544EA0", Slot = "4")]
			[IteratorStateMachine(typeof(YYEBUJFTFWD))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8544F20", Offset = "0x8543520", VA = "0x188544F20")]
		public WBHQPGNQYVD(IEnumerable<string> a, StringFormatSettings b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public sealed class OAKFGVOZSVC : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public delegate void SearchCompleteDelegate(IReadOnlyList<FuzzySearchStringScored> results, IReadOnlyList<bool> charMatches);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly VWMSQZXITSP? EGMRVGKGYOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly AsyncFuzzySearch ESLYIYQATSU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly StringFormatSettings QGTNGNVCNZY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly FuzzySearchSettings QVFBSGRPICZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly SearchCompleteDelegate GXPQKOYUEXN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly DBJZEFJWNIM.AdditionalScoringHeuristic? KVOGUGOBOQO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private IReadOnlyList<FuzzySearchStringScored> ZUFAKKGTFYZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private IReadOnlyList<bool> USFJYSUFIRY;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public IReadOnlyList<FuzzySearchStringScored> FQZIKJECXHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xAAFEE0", Offset = "0xAAE4E0", VA = "0x180AAFEE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public IReadOnlyList<bool> QIBYQUHDXGR
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xAB0EE0", Offset = "0xAAF4E0", VA = "0x180AB0EE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool JTZCOCTIYXZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x8541BA0", Offset = "0x85401A0", VA = "0x188541BA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x85422A0", Offset = "0x85408A0", VA = "0x1885422A0")]
		public OAKFGVOZSVC(IReadOnlyList<string> a, [In] FuzzySearchSettings settings, SearchCompleteDelegate b, [Optional] DBJZEFJWNIM.AdditionalScoringHeuristic? additionalScoringHeuristic, [Optional] AKRZIOHUBCN? scoringAlgorithm)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x85417E0", Offset = "0x853FDE0", VA = "0x1885417E0")]
		public void DZHGDTYKPOO(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8541B60", Offset = "0x8540160", VA = "0x188541B60", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8541BC0", Offset = "0x85401C0", VA = "0x188541BC0")]
		private void IRXSQTFBRNM(IReadOnlyList<SearchResult> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x85420B0", Offset = "0x85406B0", VA = "0x1885420B0")]
		private int VNEQYZVPGJE(ReadOnlySpan<char> a, ReadOnlySpan<char> b, int c)
		{
			return default(int);
		}
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
