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
		[Cpp2IlInjected.Address(RVA = "0xAF57C0", Offset = "0xAF47C0", VA = "0x180AF57C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x84D7CA0", Offset = "0x84D6CA0", VA = "0x1884D7CA0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAF5A10", Offset = "0xAF4A10", VA = "0x180AF5A10")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF5A50", Offset = "0xAF4A50", VA = "0x180AF5A50")]
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
		[Cpp2IlInjected.Address(RVA = "0x84D6B00", Offset = "0x84D5B00", VA = "0x1884D6B00", Slot = "4")]
		public override void BPSMAKIBARY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xAF57C0", Offset = "0xAF47C0", VA = "0x180AF57C0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.FuzzySearch
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class CGCXUMPDSIY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly LNXJXXXJTWA OMBJDAIUITS;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x84D4EC0", Offset = "0x84D3EC0", VA = "0x1884D4EC0")]
		public CGCXUMPDSIY(IReadOnlyCollection<string> a, [In] FuzzySearchSettings settings, [Optional] LNXJXXXJTWA.AdditionalScoreHeuristicDelegate b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x84D4C80", Offset = "0x84D3C80", VA = "0x1884D4C80")]
		public IReadOnlyList<FuzzySearchStringScored> Search(string searchString)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x84D4AE0", Offset = "0x84D3AE0", VA = "0x1884D4AE0")]
		public void Score(string searchString)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class LNXJXXXJTWA
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public delegate int AdditionalScoreHeuristicDelegate(IReadOnlyList<char> searchableStringsPreprocessed, int searchableStringIndex, string preprocessedSearchString);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly FuzzySearchSettings QMAJNRNZNXI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly AdditionalScoreHeuristicDelegate EREHIASPNJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly char[] SBTCIORJSJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly FuzzySearchStringScored[] TRWXYLRCTHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly bool[] QIEOIPGBOYM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public readonly (int SearchStringIndex, int ConsecutiveCount, int Value)[] ZGAIXVADFYM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly FuzzySearchStringScored[] EGHLSGEITQG;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xACBA90", Offset = "0xACAA90", VA = "0x180ACBA90")]
		public static int XMORLACOAXB(IReadOnlyList<char> a, int b, string c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x84D6080", Offset = "0x84D5080", VA = "0x1884D6080")]
		public LNXJXXXJTWA(IReadOnlyCollection<string> a, [In] FuzzySearchSettings settings, [Optional] AdditionalScoreHeuristicDelegate b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x84D59E0", Offset = "0x84D49E0", VA = "0x1884D59E0")]
		public string BJOIPUFZKTO(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x84D5A70", Offset = "0x84D4A70", VA = "0x1884D5A70")]
		public int NMPEKTVVRHW(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x84D5A80", Offset = "0x84D4A80", VA = "0x1884D5A80")]
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
		public static FuzzySearchSettings GOGYEQDLKEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x84D4F60", Offset = "0x84D3F60", VA = "0x1884D4F60")]
			get
			{
				return default(FuzzySearchSettings);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x84D5010", Offset = "0x84D4010", VA = "0x1884D5010")]
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
		[Cpp2IlInjected.Address(RVA = "0xC32F30", Offset = "0xC31F30", VA = "0x180C32F30")]
		public FuzzySearchStringScored(int index, int score, int matchesIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x84D5130", Offset = "0x84D4130", VA = "0x1884D5130")]
		public static int WVMULOOQXMX([In] FuzzySearchStringScored lhs, [In] FuzzySearchStringScored rhs)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x27AB550", Offset = "0x27AA550", VA = "0x1827AB550", Slot = "4")]
		public bool Equals(FuzzySearchStringScored other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x84D5030", Offset = "0x84D4030", VA = "0x1884D5030", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x84D50E0", Offset = "0x84D40E0", VA = "0x1884D50E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface LZHFKWCOPNM
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool IRLRQIHGTYO(string a, [Out][NotNullWhen(true)] IReadOnlyList<SearchResult>? results);
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ASOTKQQQUKP : LZHFKWCOPNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly int AFPIPOHFJLY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly List<(string searchString, IReadOnlyList<SearchResult> results)> EGJFKCSLCED;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x84D4700", Offset = "0x84D3700", VA = "0x1884D4700")]
		public ASOTKQQQUKP(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x84D4580", Offset = "0x84D3580", VA = "0x1884D4580", Slot = "4")]
		public bool IRLRQIHGTYO(string a, [Out][NotNullWhen(true)] IReadOnlyList<SearchResult>? results)
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
		private sealed class ORMYCPIHDTW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public AsyncFuzzySearch SULNKEFFSGR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public CancellationTokenSource QFEZAIKDVJA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public string INHSHEQZOVA;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public ORMYCPIHDTW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x84D9380", Offset = "0x84D8380", VA = "0x1884D9380")]
			internal SearchResult[] VQWGDQVCDOV()
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
			private ORMYCPIHDTW <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public OnSearchComplete onSearchComplete;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private TaskAwaiter<SearchResult[]> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x84D9DC0", Offset = "0x84D8DC0", VA = "0x1884D9DC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xB2F8E0", Offset = "0xB2E8E0", VA = "0x180B2F8E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static readonly Log HRODLTCIOIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly AEMNNNXDJLN AMIPJTXNTIX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly LUFHFXEQZVS QMTEVXMEXUQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly UVBGWWAHCLT.AdditionalScoringHeuristic? UDTHSIEKKGR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private SearchResult[] JRETXHLTSIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private CancellationTokenSource? GRXZHLRDZOZ;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool IPEYEHLWCZY
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x103C470", Offset = "0x103B470", VA = "0x18103C470")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x84D4A30", Offset = "0x84D3A30", VA = "0x1884D4A30")]
		public AsyncFuzzySearch(AEMNNNXDJLN targets, LUFHFXEQZVS algorithm, [Optional] UVBGWWAHCLT.AdditionalScoringHeuristic? additionalScoringHeuristic)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x84D48C0", Offset = "0x84D38C0", VA = "0x1884D48C0")]
		[AsyncStateMachine(typeof(<Search>d__10))]
		public void Search(string searchString, OnSearchComplete onSearchComplete)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x84D4880", Offset = "0x84D3880", VA = "0x1884D4880")]
		public void Cancel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class UVBGWWAHCLT
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public delegate int AdditionalScoringHeuristic(ReadOnlySpan<char> searchString, ReadOnlySpan<char> targetString, int targetStringIndex);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x84DA2F0", Offset = "0x84D92F0", VA = "0x1884DA2F0")]
		public static int HTETETERNYJ([In] SearchResult lhs, [In] SearchResult rhs)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct SearchResult
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class OAEINRARKYE : IEnumerable<bool>, IEnumerable, IEnumerator<bool>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private int NNYUMBTASKT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private bool GLROCXYMSEU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private int CYUNKNWTKTU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public SearchResult SULNKEFFSGR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public SearchResult IUDCZXABBBK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private int RRJFDMGHLWT;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			private bool YSEJQEVGJLH
			{
				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x10BD270", Offset = "0x10BC270", VA = "0x1810BD270", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private object OPJHDGDZAVH
			{
				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x789F980", Offset = "0x789E980", VA = "0x18789F980", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x13438E0", Offset = "0x13428E0", VA = "0x1813438E0")]
			[DebuggerHidden]
			public OAEINRARKYE(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "7")]
			[DebuggerHidden]
			private void FQZHCUDIKGC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x84D7DE0", Offset = "0x84D6DE0", VA = "0x1884D7DE0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x84D7E80", Offset = "0x84D6E80", VA = "0x1884D7E80", Slot = "10")]
			[DebuggerHidden]
			private void SEWTXRYPVUP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x84D7D20", Offset = "0x84D6D20", VA = "0x1884D7D20", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<bool> GZONGRRJTIO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x84D7D20", Offset = "0x84D6D20", VA = "0x1884D7D20", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator HKYUJZELIWO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public readonly double Score;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public readonly int Index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public readonly ReadOnlyMemory<char> Target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly BitArray highlightedChars;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public readonly IEnumerable<bool> SHGUWNGVBLW
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x84D9A50", Offset = "0x84D8A50", VA = "0x1884D9A50")]
			[IteratorStateMachine(typeof(OAEINRARKYE))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x84D9AE0", Offset = "0x84D8AE0", VA = "0x1884D9AE0")]
		public SearchResult(double score, int index, ReadOnlyMemory<char> target, IEnumerable<int> highlightedChars)
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
		[Cpp2IlInjected.Address(RVA = "0x41739C0", Offset = "0x41729C0", VA = "0x1841739C0")]
		public StringFormatSettings(bool ignoreCase, bool ignoreSpaces)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x84D9D30", Offset = "0x84D8D30", VA = "0x1884D9D30")]
		public string Format(string str)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface LUFHFXEQZVS
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "0")]
		float Score(ReadOnlySpan<char> searchString, ReadOnlySpan<char> targetString, [Optional] List<int>? matchingCharacters);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class NIQIRFUTQSM : LUFHFXEQZVS
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public readonly struct Settings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public readonly float ConsecutiveCharacterMultiplier;

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x15EAB50", Offset = "0x15E9B50", VA = "0x1815EAB50")]
			public Settings(float consecutiveCharacterMultiplier)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private int[] JHWLOHSKPDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private int[] QHCAGGGWLLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private BitArray TPGFOXBSOVC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly Settings LVEWGNXDUDE;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x84D7BD0", Offset = "0x84D6BD0", VA = "0x1884D7BD0")]
		public NIQIRFUTQSM([In] Settings settings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x84D7850", Offset = "0x84D6850", VA = "0x1884D7850", Slot = "4")]
		public float Score(ReadOnlySpan<char> searchString, ReadOnlySpan<char> targetString, [Optional] List<int>? matchingCharacters)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x84D72F0", Offset = "0x84D62F0", VA = "0x1884D72F0")]
		private void CUYIBCQMBHT(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x84D7380", Offset = "0x84D6380", VA = "0x1884D7380")]
		private float OMKKJAGDAGQ(ReadOnlySpan<char> a, ReadOnlySpan<char> b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x84D7740", Offset = "0x84D6740", VA = "0x1884D7740")]
		private int SOVSXBMJEYH(ReadOnlySpan<char> a, ReadOnlySpan<char> b, int c)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class NDGZJWCDJMG : LUFHFXEQZVS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly int NBVDENDGIZO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private BitArray? KCNZRAGCWDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private (int SearchStringIndex, int ConsecutiveCount, int Value)[] IRPKWNNQASW;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x84D7230", Offset = "0x84D6230", VA = "0x1884D7230")]
		public NDGZJWCDJMG(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x84D6B80", Offset = "0x84D5B80", VA = "0x1884D6B80", Slot = "4")]
		public float Score(ReadOnlySpan<char> searchString, ReadOnlySpan<char> targetString, [Optional] List<int>? matchingCharacters)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface AEMNNNXDJLN
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		IEnumerable<ReadOnlyMemory<char>> LIHDHEWADIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class HFUGYYYPYYU : AEMNNNXDJLN
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class HQENANIBZDY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public StringFormatSettings LVEWGNXDUDE;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public HQENANIBZDY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x84D5950", Offset = "0x84D4950", VA = "0x1884D5950")]
			internal string AVFLGHWIDEH(string a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class OKUTLQPYOOC : IEnumerable<ReadOnlyMemory<char>>, IEnumerable, IEnumerator<ReadOnlyMemory<char>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			private int NNYUMBTASKT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			private ReadOnlyMemory<char> GLROCXYMSEU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			private int CYUNKNWTKTU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public HFUGYYYPYYU SULNKEFFSGR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			private ReadOnlyMemory<char> SEQYEOXJPRP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			private IEnumerator<IndexValuePair<char>> NWDDORFGLFY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			private int RSOUNAVRQMV;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private ReadOnlyMemory<char> NPAHJGADWNN
			{
				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0xCE16B0", Offset = "0xCE06B0", VA = "0x180CE16B0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(ReadOnlyMemory<char>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private object OPJHDGDZAVH
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x84D7EC0", Offset = "0x84D6EC0", VA = "0x1884D7EC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x1A8A0D0", Offset = "0x1A890D0", VA = "0x181A8A0D0")]
			[DebuggerHidden]
			public OKUTLQPYOOC(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x84D7F10", Offset = "0x84D6F10", VA = "0x1884D7F10", Slot = "7")]
			[DebuggerHidden]
			private void FQZHCUDIKGC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x84D8040", Offset = "0x84D7040", VA = "0x1884D8040", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x84D8410", Offset = "0x84D7410", VA = "0x1884D8410")]
			private void QJEWXGNEXZS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x84D8460", Offset = "0x84D7460", VA = "0x1884D8460", Slot = "10")]
			[DebuggerHidden]
			private void SEWTXRYPVUP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x84D7FA0", Offset = "0x84D6FA0", VA = "0x1884D7FA0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<ReadOnlyMemory<char>> YYOFNMJCBRG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x84D7FA0", Offset = "0x84D6FA0", VA = "0x1884D7FA0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator HKYUJZELIWO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly char[] ADMKOSGFQAX;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IEnumerable<ReadOnlyMemory<char>> LIHDHEWADIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x84D5150", Offset = "0x84D4150", VA = "0x1884D5150", Slot = "4")]
			[IteratorStateMachine(typeof(OKUTLQPYOOC))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x84D51D0", Offset = "0x84D41D0", VA = "0x1884D51D0")]
		public HFUGYYYPYYU(IEnumerable<string> a, StringFormatSettings b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public sealed class OLVUPORYFKD : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public delegate void SearchCompleteDelegate(IReadOnlyList<FuzzySearchStringScored> results, IReadOnlyList<bool> charMatches);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly LZHFKWCOPNM? EGJFKCSLCED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly AsyncFuzzySearch YYVAIOPWGMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly StringFormatSettings FNLGWAJPFGV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly FuzzySearchSettings LVEWGNXDUDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly SearchCompleteDelegate ZQNBVOOTALU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly UVBGWWAHCLT.AdditionalScoringHeuristic? UDTHSIEKKGR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private IReadOnlyList<FuzzySearchStringScored> ZSYLNYUCABS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private IReadOnlyList<bool> FAWILRPVPYH;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public IReadOnlyList<FuzzySearchStringScored> CWKNRACQQHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xAD5DE0", Offset = "0xAD4DE0", VA = "0x180AD5DE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public IReadOnlyList<bool> UVVDGEOILDS
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xAD2F50", Offset = "0xAD1F50", VA = "0x180AD2F50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool IPEYEHLWCZY
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x84D8D80", Offset = "0x84D7D80", VA = "0x1884D8D80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x84D8F90", Offset = "0x84D7F90", VA = "0x1884D8F90")]
		public OLVUPORYFKD(IReadOnlyList<string> a, [In] FuzzySearchSettings settings, SearchCompleteDelegate b, [Optional] UVBGWWAHCLT.AdditionalScoringHeuristic? additionalScoringHeuristic, [Optional] LUFHFXEQZVS? scoringAlgorithm)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x84D84A0", Offset = "0x84D74A0", VA = "0x1884D84A0")]
		public void BMKMOPVLZZF(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x84D8830", Offset = "0x84D7830", VA = "0x1884D8830", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x84D8870", Offset = "0x84D7870", VA = "0x1884D8870")]
		private void FGWAURKDAHD(IReadOnlyList<SearchResult> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x84D8DA0", Offset = "0x84D7DA0", VA = "0x1884D8DA0")]
		private int SYCOTEBUQND(ReadOnlySpan<char> a, ReadOnlySpan<char> b, int c)
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
