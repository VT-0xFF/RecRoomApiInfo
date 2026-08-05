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
		[Cpp2IlInjected.Address(RVA = "0xD1F100", Offset = "0xD1E100", VA = "0x180D1F100")]
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
		[Cpp2IlInjected.Address(RVA = "0x99F4C10", Offset = "0x99F3C10", VA = "0x1899F4C10")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD1F350", Offset = "0xD1E350", VA = "0x180D1F350")]
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
		[Cpp2IlInjected.Address(RVA = "0xD1F390", Offset = "0xD1E390", VA = "0x180D1F390")]
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
		[Cpp2IlInjected.Address(RVA = "0x99F3CB0", Offset = "0x99F2CB0", VA = "0x1899F3CB0", Slot = "4")]
		public override void OTSRDIPIITJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xD1F100", Offset = "0xD1E100", VA = "0x180D1F100")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.FuzzySearch
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class DAMLJDSHKLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly VYDNYSPIGQF QYIBHQWZMUL;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x99F3190", Offset = "0x99F2190", VA = "0x1899F3190")]
		public DAMLJDSHKLP(IReadOnlyCollection<string> a, [In] FuzzySearchSettings settings, [Optional] VYDNYSPIGQF.AdditionalScoreHeuristicDelegate b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x99F2F50", Offset = "0x99F1F50", VA = "0x1899F2F50")]
		public IReadOnlyList<FuzzySearchStringScored> Search(string searchString)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x99F2DB0", Offset = "0x99F1DB0", VA = "0x1899F2DB0")]
		public void Score(string searchString)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class VYDNYSPIGQF
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public delegate int AdditionalScoreHeuristicDelegate(IReadOnlyList<char> searchableStringsPreprocessed, int searchableStringIndex, string preprocessedSearchString);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly FuzzySearchSettings FOUTXBNQRXR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly AdditionalScoreHeuristicDelegate CUVWMUNXKPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly char[] IESXHHAQAGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly FuzzySearchStringScored[] EQMIYNLIKMX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly bool[] FIPIAJILDHZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public readonly (int SearchStringIndex, int ConsecutiveCount, int Value)[] ROLDVJNWPUZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly FuzzySearchStringScored[] ZLYTVRKCHWT;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210")]
		public static int UQAHDPQUVJS(IReadOnlyList<char> a, int b, string c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x99F7650", Offset = "0x99F6650", VA = "0x1899F7650")]
		public VYDNYSPIGQF(IReadOnlyCollection<string> a, [In] FuzzySearchSettings settings, [Optional] AdditionalScoreHeuristicDelegate b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x99F6FB0", Offset = "0x99F5FB0", VA = "0x1899F6FB0")]
		public string DCZYSOVXIQJ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x99F7040", Offset = "0x99F6040", VA = "0x1899F7040")]
		public int IPCLJIJFRQX(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x99F7050", Offset = "0x99F6050", VA = "0x1899F7050")]
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
		public static FuzzySearchSettings HPUTZVWRNHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x99F3230", Offset = "0x99F2230", VA = "0x1899F3230")]
			get
			{
				return default(FuzzySearchSettings);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x99F32E0", Offset = "0x99F22E0", VA = "0x1899F32E0")]
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
		[Cpp2IlInjected.Address(RVA = "0xEBF470", Offset = "0xEBE470", VA = "0x180EBF470")]
		public FuzzySearchStringScored(int index, int score, int matchesIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x99F33B0", Offset = "0x99F23B0", VA = "0x1899F33B0")]
		public static int FZPVACBWIIQ([In] FuzzySearchStringScored lhs, [In] FuzzySearchStringScored rhs)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2A07310", Offset = "0x2A06310", VA = "0x182A07310", Slot = "4")]
		public bool Equals(FuzzySearchStringScored other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x99F3300", Offset = "0x99F2300", VA = "0x1899F3300", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x99F33D0", Offset = "0x99F23D0", VA = "0x1899F33D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface RNERMGDGMQF
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool FHJNFNPTGFX(string a, [Out][NotNullWhen(true)] IReadOnlyList<SearchResult>? results);
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class RRZCXSAEGQS : RNERMGDGMQF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly int NCRARPPNJFV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly List<(string searchString, IReadOnlyList<SearchResult> results)> NAVPJWUEZNW;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x99F6090", Offset = "0x99F5090", VA = "0x1899F6090")]
		public RRZCXSAEGQS(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x99F5F10", Offset = "0x99F4F10", VA = "0x1899F5F10", Slot = "4")]
		public bool FHJNFNPTGFX(string a, [Out][NotNullWhen(true)] IReadOnlyList<SearchResult>? results)
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
		private sealed class PUKJSNNOUVN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public AsyncFuzzySearch NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public CancellationTokenSource LSQCDEVZUVZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public string YXMOAUXNNWH;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public PUKJSNNOUVN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x99F4E30", Offset = "0x99F3E30", VA = "0x1899F4E30")]
			internal SearchResult[] CYJUQDBQZAY()
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
			private PUKJSNNOUVN <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public OnSearchComplete onSearchComplete;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private TaskAwaiter<SearchResult[]> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x99F6A70", Offset = "0x99F5A70", VA = "0x1899F6A70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xD58E90", Offset = "0xD57E90", VA = "0x180D58E90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static readonly Log NSTUKEGGGWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly SMQUAXKFKDI EDHJHSCVLDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly WLGFISHTGRB KFCLDBAINYX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly RJBQVIGVKGW.AdditionalScoringHeuristic? HKVJGVXWHOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private SearchResult[] NMHKTDSENQK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private CancellationTokenSource? MRNEZMPWRXE;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool LSLWRJGGCIZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x12AA670", Offset = "0x12A9670", VA = "0x1812AA670")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x99F2D00", Offset = "0x99F1D00", VA = "0x1899F2D00")]
		public AsyncFuzzySearch(SMQUAXKFKDI targets, WLGFISHTGRB algorithm, [Optional] RJBQVIGVKGW.AdditionalScoringHeuristic? additionalScoringHeuristic)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x99F2B80", Offset = "0x99F1B80", VA = "0x1899F2B80")]
		[AsyncStateMachine(typeof(<Search>d__10))]
		public void Search(string searchString, OnSearchComplete onSearchComplete)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x99F2B40", Offset = "0x99F1B40", VA = "0x1899F2B40")]
		public void Cancel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class RJBQVIGVKGW
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public delegate int AdditionalScoringHeuristic(ReadOnlySpan<char> searchString, ReadOnlySpan<char> targetString, int targetStringIndex);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x99F5550", Offset = "0x99F4550", VA = "0x1899F5550")]
		public static int ROLARNCJVJA([In] SearchResult lhs, [In] SearchResult rhs)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct SearchResult
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class OLWPYNNWLCP : IEnumerable<bool>, IEnumerable, IEnumerator<bool>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private int KVXTPCCUFNU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private bool NNNUNWANACF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private int LNNEGLEATET;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public SearchResult NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public SearchResult LIPWBOOVOJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private int AVRZTXKIQLK;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			private bool SXSPZFRDXOY
			{
				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x132CAF0", Offset = "0x132BAF0", VA = "0x18132CAF0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private object BVCEDTADISM
			{
				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x8D6FAF0", Offset = "0x8D6EAF0", VA = "0x188D6FAF0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x15B89F0", Offset = "0x15B79F0", VA = "0x1815B89F0")]
			[DebuggerHidden]
			public OLWPYNNWLCP(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "7")]
			[DebuggerHidden]
			private void OHWWSGWCEEL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x99F4D50", Offset = "0x99F3D50", VA = "0x1899F4D50", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x99F4DF0", Offset = "0x99F3DF0", VA = "0x1899F4DF0", Slot = "10")]
			[DebuggerHidden]
			private void UCVOSCIFQDQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x99F4C90", Offset = "0x99F3C90", VA = "0x1899F4C90", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<bool> MDZRKGGNXHN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x99F4C90", Offset = "0x99F3C90", VA = "0x1899F4C90", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator YIRXJWVWWXR()
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
		public readonly IEnumerable<bool> OCEKRLIBWDV
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x99F6700", Offset = "0x99F5700", VA = "0x1899F6700")]
			[IteratorStateMachine(typeof(OLWPYNNWLCP))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x99F6790", Offset = "0x99F5790", VA = "0x1899F6790")]
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
		[Cpp2IlInjected.Address(RVA = "0x537F120", Offset = "0x537E120", VA = "0x18537F120")]
		public StringFormatSettings(bool ignoreCase, bool ignoreSpaces)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x99F69E0", Offset = "0x99F59E0", VA = "0x1899F69E0")]
		public string Format(string str)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface WLGFISHTGRB
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "0")]
		float Score(ReadOnlySpan<char> searchString, ReadOnlySpan<char> targetString, [Optional] List<int>? matchingCharacters);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class RPLWTRFHOCD : WLGFISHTGRB
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public readonly struct Settings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public readonly float ConsecutiveCharacterMultiplier;

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x1862330", Offset = "0x1861330", VA = "0x181862330")]
			public Settings(float consecutiveCharacterMultiplier)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private int[] WPBKNESEDXA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private int[] CSPIMWPFFML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private BitArray MNBUKYUZHFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly Settings TNKHNEKCWUL;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x99F5E40", Offset = "0x99F4E40", VA = "0x1899F5E40")]
		public RPLWTRFHOCD([In] Settings settings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x99F5AC0", Offset = "0x99F4AC0", VA = "0x1899F5AC0", Slot = "4")]
		public float Score(ReadOnlySpan<char> searchString, ReadOnlySpan<char> targetString, [Optional] List<int>? matchingCharacters)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x99F5920", Offset = "0x99F4920", VA = "0x1899F5920")]
		private void CONBJSWFBPY(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x99F5560", Offset = "0x99F4560", VA = "0x1899F5560")]
		private float AWUYOHNEYSB(ReadOnlySpan<char> a, ReadOnlySpan<char> b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x99F59B0", Offset = "0x99F49B0", VA = "0x1899F59B0")]
		private int MFEAWSHLIAQ(ReadOnlySpan<char> a, ReadOnlySpan<char> b, int c)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class WJECYMXWRQB : WLGFISHTGRB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly int HAQFKQECPWN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private BitArray? KIUQDSJIVNX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private (int SearchStringIndex, int ConsecutiveCount, int Value)[] TCFXKYZQIMT;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x99F8790", Offset = "0x99F7790", VA = "0x1899F8790")]
		public WJECYMXWRQB(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x99F80E0", Offset = "0x99F70E0", VA = "0x1899F80E0", Slot = "4")]
		public float Score(ReadOnlySpan<char> searchString, ReadOnlySpan<char> targetString, [Optional] List<int>? matchingCharacters)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface SMQUAXKFKDI
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		IEnumerable<ReadOnlyMemory<char>> VYZLPZFIRTZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class JVNNGBGKHRN : SMQUAXKFKDI
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class GZTFKPJKAMH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public StringFormatSettings TNKHNEKCWUL;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public GZTFKPJKAMH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x99F3420", Offset = "0x99F2420", VA = "0x1899F3420")]
			internal string HJGUBTNFJMI(string a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class SGVGCVBPGGN : IEnumerable<ReadOnlyMemory<char>>, IEnumerable, IEnumerator<ReadOnlyMemory<char>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			private int KVXTPCCUFNU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			private ReadOnlyMemory<char> NNNUNWANACF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			private int LNNEGLEATET;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public JVNNGBGKHRN NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			private ReadOnlyMemory<char> DKWBVACNOHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			private IEnumerator<IndexValuePair<char>> PPVYVNDTKED;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			private int AWXPDLZSVBM;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private ReadOnlyMemory<char> MSFRRXIENLI
			{
				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0xD8EE10", Offset = "0xD8DE10", VA = "0x180D8EE10", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(ReadOnlyMemory<char>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private object BVCEDTADISM
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x99F61C0", Offset = "0x99F51C0", VA = "0x1899F61C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x1D167A0", Offset = "0x1D157A0", VA = "0x181D167A0")]
			[DebuggerHidden]
			public SGVGCVBPGGN(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x99F6630", Offset = "0x99F5630", VA = "0x1899F6630", Slot = "7")]
			[DebuggerHidden]
			private void OHWWSGWCEEL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x99F6260", Offset = "0x99F5260", VA = "0x1899F6260", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x99F6210", Offset = "0x99F5210", VA = "0x1899F6210")]
			private void LZWZIAQZAET()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x99F66C0", Offset = "0x99F56C0", VA = "0x1899F66C0", Slot = "10")]
			[DebuggerHidden]
			private void UCVOSCIFQDQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x99F6120", Offset = "0x99F5120", VA = "0x1899F6120", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<ReadOnlyMemory<char>> CAKOVETMIRD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x99F6120", Offset = "0x99F5120", VA = "0x1899F6120", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator YIRXJWVWWXR()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly char[] DDOSFTMFPUQ;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IEnumerable<ReadOnlyMemory<char>> VYZLPZFIRTZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x99F34B0", Offset = "0x99F24B0", VA = "0x1899F34B0", Slot = "4")]
			[IteratorStateMachine(typeof(SGVGCVBPGGN))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x99F3530", Offset = "0x99F2530", VA = "0x1899F3530")]
		public JVNNGBGKHRN(IEnumerable<string> a, StringFormatSettings b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public sealed class MAGUBLINJYC : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public delegate void SearchCompleteDelegate(IReadOnlyList<FuzzySearchStringScored> results, IReadOnlyList<bool> charMatches);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly RNERMGDGMQF? NAVPJWUEZNW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly AsyncFuzzySearch HUBXAWPGPIS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly StringFormatSettings BZLLQHZECVG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly FuzzySearchSettings TNKHNEKCWUL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly SearchCompleteDelegate KLGIAVXFVGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly RJBQVIGVKGW.AdditionalScoringHeuristic? HKVJGVXWHOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private IReadOnlyList<FuzzySearchStringScored> ZLYSHBRPZJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private IReadOnlyList<bool> MGFLFMGKHMI;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public IReadOnlyList<FuzzySearchStringScored> BDZQWHUYPHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF3350", VA = "0x180CF4350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public IReadOnlyList<bool> AOJTFNHBRWP
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xCFC340", Offset = "0xCFB340", VA = "0x180CFC340")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool LSLWRJGGCIZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x99F3F60", Offset = "0x99F2F60", VA = "0x1899F3F60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x99F4820", Offset = "0x99F3820", VA = "0x1899F4820")]
		public MAGUBLINJYC(IReadOnlyList<string> a, [In] FuzzySearchSettings settings, SearchCompleteDelegate b, [Optional] RJBQVIGVKGW.AdditionalScoringHeuristic? additionalScoringHeuristic, [Optional] WLGFISHTGRB? scoringAlgorithm)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x99F3F80", Offset = "0x99F2F80", VA = "0x1899F3F80")]
		public void SXHEHUZIBPG(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x99F3D30", Offset = "0x99F2D30", VA = "0x1899F3D30", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x99F4300", Offset = "0x99F3300", VA = "0x1899F4300")]
		private void VDFCIJSLCTW(IReadOnlyList<SearchResult> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x99F3D70", Offset = "0x99F2D70", VA = "0x1899F3D70")]
		private int NEPBTTNFCPK(ReadOnlySpan<char> a, ReadOnlySpan<char> b, int c)
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
