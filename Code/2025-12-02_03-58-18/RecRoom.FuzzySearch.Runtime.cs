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
		[Cpp2IlInjected.Address(RVA = "0xABFE50", Offset = "0xABEA50", VA = "0x180ABFE50")]
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
		[Cpp2IlInjected.Address(RVA = "0x8209640", Offset = "0x8208240", VA = "0x188209640")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAC01D0", Offset = "0xABEDD0", VA = "0x180AC01D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC0210", Offset = "0xABEE10", VA = "0x180AC0210")]
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
		[Cpp2IlInjected.Address(RVA = "0x82089B0", Offset = "0x82075B0", VA = "0x1882089B0", Slot = "4")]
		public override void OGBNJYRINGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xABFE50", Offset = "0xABEA50", VA = "0x180ABFE50")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.FuzzySearch
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class MGMKJTZVNJS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly CHRHAHOXOBG CSGZSXXVHSI;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8208E10", Offset = "0x8207A10", VA = "0x188208E10")]
		public MGMKJTZVNJS(IReadOnlyCollection<string> a, [In] FuzzySearchSettings settings, [Optional] CHRHAHOXOBG.AdditionalScoreHeuristicDelegate b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8208BD0", Offset = "0x82077D0", VA = "0x188208BD0")]
		public IReadOnlyList<FuzzySearchStringScored> Search(string searchString)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8208A30", Offset = "0x8207630", VA = "0x188208A30")]
		public void Score(string searchString)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class CHRHAHOXOBG
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public delegate int AdditionalScoreHeuristicDelegate(IReadOnlyList<char> searchableStringsPreprocessed, int searchableStringIndex, string preprocessedSearchString);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly FuzzySearchSettings NERFWKHMVDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly AdditionalScoreHeuristicDelegate NWNWJZTEPNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly char[] CGHQPCIUSOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly FuzzySearchStringScored[] OEUNAGKSFUS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly bool[] BRAECGHISEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public readonly (int SearchStringIndex, int ConsecutiveCount, int Value)[] MMETTMVBIZW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly FuzzySearchStringScored[] DNOEIBGBNXQ;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA96160", Offset = "0xA94D60", VA = "0x180A96160")]
		public static int BCEFWPJIJXN(IReadOnlyList<char> a, int b, string c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8207980", Offset = "0x8206580", VA = "0x188207980")]
		public CHRHAHOXOBG(IReadOnlyCollection<string> a, [In] FuzzySearchSettings settings, [Optional] AdditionalScoreHeuristicDelegate b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x82072E0", Offset = "0x8205EE0", VA = "0x1882072E0")]
		public string AYUBMWZUONS(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8207970", Offset = "0x8206570", VA = "0x188207970")]
		public int WOEFXNXEIUA(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8207370", Offset = "0x8205F70", VA = "0x188207370")]
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
		public static FuzzySearchSettings YNAVUHJMGMQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8208420", Offset = "0x8207020", VA = "0x188208420")]
			get
			{
				return default(FuzzySearchSettings);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x82084D0", Offset = "0x82070D0", VA = "0x1882084D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xBABA90", Offset = "0xBAA690", VA = "0x180BABA90")]
		public FuzzySearchStringScored(int index, int score, int matchesIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x82084F0", Offset = "0x82070F0", VA = "0x1882084F0")]
		public static int BURLAGRMKAD([In] FuzzySearchStringScored lhs, [In] FuzzySearchStringScored rhs)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x27309E0", Offset = "0x272F5E0", VA = "0x1827309E0", Slot = "4")]
		public bool Equals(FuzzySearchStringScored other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8208510", Offset = "0x8207110", VA = "0x188208510", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x82085C0", Offset = "0x82071C0", VA = "0x1882085C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface VCZKDDMAZTI
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool LEQHMZSIAUS(string a, [Out][NotNullWhen(true)] IReadOnlyList<SearchResult>? results);
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ISUDPNANSGH : VCZKDDMAZTI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly int SXDRPTHLIJQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly List<(string searchString, IReadOnlyList<SearchResult> results)> UIJVCMPQJAH;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8208790", Offset = "0x8207390", VA = "0x188208790")]
		public ISUDPNANSGH(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8208610", Offset = "0x8207210", VA = "0x188208610", Slot = "4")]
		public bool LEQHMZSIAUS(string a, [Out][NotNullWhen(true)] IReadOnlyList<SearchResult>? results)
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
		private sealed class NIBWJFEAYEQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public AsyncFuzzySearch BIVSZSMQJUR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public CancellationTokenSource TNGUXUNNTFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public string VTFOHQOHWDU;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public NIBWJFEAYEQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x8208F40", Offset = "0x8207B40", VA = "0x188208F40")]
			internal SearchResult[] OUDDETOABPT()
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
			private NIBWJFEAYEQ <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public OnSearchComplete onSearchComplete;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private TaskAwaiter<SearchResult[]> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x820A810", Offset = "0x8209410", VA = "0x18820A810", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xAF5C80", Offset = "0xAF4880", VA = "0x180AF5C80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static readonly Log JVTVAZRWBFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly JAYANKGHUNN PJNVNEQTTHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly QONTYISYPKI DTCAHTQAJIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly VLTKTXZKUBX.AdditionalScoringHeuristic? LODBSOXOJGV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private SearchResult[] KRMXOMFIEJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private CancellationTokenSource? TZBYEYPXIHD;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool FWOCZGJSQUS
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xFAB670", Offset = "0xFAA270", VA = "0x180FAB670")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8207230", Offset = "0x8205E30", VA = "0x188207230")]
		public AsyncFuzzySearch(JAYANKGHUNN targets, QONTYISYPKI algorithm, [Optional] VLTKTXZKUBX.AdditionalScoringHeuristic? additionalScoringHeuristic)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x82070B0", Offset = "0x8205CB0", VA = "0x1882070B0")]
		[AsyncStateMachine(typeof(<Search>d__10))]
		public void Search(string searchString, OnSearchComplete onSearchComplete)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8207070", Offset = "0x8205C70", VA = "0x188207070")]
		public void Cancel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class VLTKTXZKUBX
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public delegate int AdditionalScoringHeuristic(ReadOnlySpan<char> searchString, ReadOnlySpan<char> targetString, int targetStringIndex);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x820AD50", Offset = "0x8209950", VA = "0x18820AD50")]
		public static int YBRJVYPNJKF([In] SearchResult lhs, [In] SearchResult rhs)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct SearchResult
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class KMAURLJQASQ : IEnumerable<bool>, IEnumerable, IEnumerator<bool>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private int VIUVMRSCWZN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private bool VWMVUJJYLQY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private int FTPEWITHWYC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public SearchResult BIVSZSMQJUR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public SearchResult DYOJXPRBMNG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private int DHBHAJRDLPJ;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			private bool HQFZEEMIXGB
			{
				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x102CA00", Offset = "0x102B600", VA = "0x18102CA00", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private object JGIILLOFTSJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x761D7A0", Offset = "0x761C3A0", VA = "0x18761D7A0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x12AE9F0", Offset = "0x12AD5F0", VA = "0x1812AE9F0")]
			[DebuggerHidden]
			public KMAURLJQASQ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "7")]
			[DebuggerHidden]
			private void YZDXQKWRCHA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x8208820", Offset = "0x8207420", VA = "0x188208820", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x8208970", Offset = "0x8207570", VA = "0x188208970", Slot = "10")]
			[DebuggerHidden]
			private void XHCIYLVFRPR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x82088C0", Offset = "0x82074C0", VA = "0x1882088C0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<bool> WNBKJICUFOS()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x82088C0", Offset = "0x82074C0", VA = "0x1882088C0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator VDVERRYCFPI()
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
		public readonly IEnumerable<bool> GIAYSTAWABG
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x820A4B0", Offset = "0x82090B0", VA = "0x18820A4B0")]
			[IteratorStateMachine(typeof(KMAURLJQASQ))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x820A530", Offset = "0x8209130", VA = "0x18820A530")]
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
		[Cpp2IlInjected.Address(RVA = "0x3FFF010", Offset = "0x3FFDC10", VA = "0x183FFF010")]
		public StringFormatSettings(bool ignoreCase, bool ignoreSpaces)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x820A780", Offset = "0x8209380", VA = "0x18820A780")]
		public string Format(string str)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface QONTYISYPKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "0")]
		float Score(ReadOnlySpan<char> searchString, ReadOnlySpan<char> targetString, [Optional] List<int>? matchingCharacters);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class AWGDBIRSZGI : QONTYISYPKI
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public readonly struct Settings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public readonly float ConsecutiveCharacterMultiplier;

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x1558EE0", Offset = "0x1557AE0", VA = "0x181558EE0")]
			public Settings(float consecutiveCharacterMultiplier)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private int[] NENVQUIWRSR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private int[] EAYYQFXNZXC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private BitArray KVGQYBXEQBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly Settings CFAUHHSRCRQ;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8206EB0", Offset = "0x8205AB0", VA = "0x188206EB0")]
		public AWGDBIRSZGI([In] Settings settings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8206660", Offset = "0x8205260", VA = "0x188206660", Slot = "4")]
		public float Score(ReadOnlySpan<char> searchString, ReadOnlySpan<char> targetString, [Optional] List<int>? matchingCharacters)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x82065D0", Offset = "0x82051D0", VA = "0x1882065D0")]
		private void DIYNLKAWUYN(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8206AF0", Offset = "0x82056F0", VA = "0x188206AF0")]
		private float VUEJWZPPQLO(ReadOnlySpan<char> a, ReadOnlySpan<char> b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x82069E0", Offset = "0x82055E0", VA = "0x1882069E0")]
		private int VJQHNKZKKVV(ReadOnlySpan<char> a, ReadOnlySpan<char> b, int c)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ABJNQGPTKES : QONTYISYPKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly int RZHODCITJPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private BitArray? GJIKJABTJNQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private (int SearchStringIndex, int ConsecutiveCount, int Value)[] TEFUONGRERY;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8206510", Offset = "0x8205110", VA = "0x188206510")]
		public ABJNQGPTKES(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8205E60", Offset = "0x8204A60", VA = "0x188205E60", Slot = "4")]
		public float Score(ReadOnlySpan<char> searchString, ReadOnlySpan<char> targetString, [Optional] List<int>? matchingCharacters)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface JAYANKGHUNN
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		IEnumerable<ReadOnlyMemory<char>> ZQNPQEXEGMQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class QWXRBBSRDFW : JAYANKGHUNN
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class MIPFINYMDPQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public StringFormatSettings CFAUHHSRCRQ;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public MIPFINYMDPQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8208EB0", Offset = "0x8207AB0", VA = "0x188208EB0")]
			internal string CHEWMOGSMRR(string a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class SYKDUVGLREC : IEnumerable<ReadOnlyMemory<char>>, IEnumerable, IEnumerator<ReadOnlyMemory<char>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			private int VIUVMRSCWZN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			private ReadOnlyMemory<char> VWMVUJJYLQY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			private int FTPEWITHWYC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public QWXRBBSRDFW BIVSZSMQJUR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			private ReadOnlyMemory<char> SDFJNIPVTCV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			private IEnumerator<IndexValuePair<char>> KYGXQXCJPLU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			private int DIGWJYGNQFL;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private ReadOnlyMemory<char> MOZGQDVCCCD
			{
				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0xC666D0", Offset = "0xC652D0", VA = "0x180C666D0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(ReadOnlyMemory<char>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private object JGIILLOFTSJ
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x8209ED0", Offset = "0x8208AD0", VA = "0x188209ED0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x19F4860", Offset = "0x19F3460", VA = "0x1819F4860")]
			[DebuggerHidden]
			public SYKDUVGLREC(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x820A420", Offset = "0x8209020", VA = "0x18820A420", Slot = "7")]
			[DebuggerHidden]
			private void YZDXQKWRCHA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x820A010", Offset = "0x8208C10", VA = "0x18820A010", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x8209FC0", Offset = "0x8208BC0", VA = "0x188209FC0")]
			private void LSRJDRRKPDO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x820A3E0", Offset = "0x8208FE0", VA = "0x18820A3E0", Slot = "10")]
			[DebuggerHidden]
			private void XHCIYLVFRPR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8209F20", Offset = "0x8208B20", VA = "0x188209F20", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<ReadOnlyMemory<char>> KNQFRUPQPIY()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8209F20", Offset = "0x8208B20", VA = "0x188209F20", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator VDVERRYCFPI()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly char[] MXDTMUFPQDZ;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IEnumerable<ReadOnlyMemory<char>> ZQNPQEXEGMQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x82096C0", Offset = "0x82082C0", VA = "0x1882096C0", Slot = "4")]
			[IteratorStateMachine(typeof(SYKDUVGLREC))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8209740", Offset = "0x8208340", VA = "0x188209740")]
		public QWXRBBSRDFW(IEnumerable<string> a, StringFormatSettings b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public sealed class YQPRQEGDXIX : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public delegate void SearchCompleteDelegate(IReadOnlyList<FuzzySearchStringScored> results, IReadOnlyList<bool> charMatches);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly VCZKDDMAZTI? UIJVCMPQJAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly AsyncFuzzySearch JCTVYDMJBSH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly StringFormatSettings NFANVZXFYSR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly FuzzySearchSettings CFAUHHSRCRQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly SearchCompleteDelegate UFCSLJHAXUG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly VLTKTXZKUBX.AdditionalScoringHeuristic? LODBSOXOJGV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private IReadOnlyList<FuzzySearchStringScored> ESIWIYKECSQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private IReadOnlyList<bool> TGCJMTRPYLV;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public IReadOnlyList<FuzzySearchStringScored> PLDVBAFWMYO
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xAA0C00", Offset = "0xA9F800", VA = "0x180AA0C00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public IReadOnlyList<bool> PXRAKRVMAFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xA988D0", Offset = "0xA974D0", VA = "0x180A988D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool FWOCZGJSQUS
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x820B890", Offset = "0x820A490", VA = "0x18820B890")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x820B8B0", Offset = "0x820A4B0", VA = "0x18820B8B0")]
		public YQPRQEGDXIX(IReadOnlyList<string> a, [In] FuzzySearchSettings settings, SearchCompleteDelegate b, [Optional] VLTKTXZKUBX.AdditionalScoringHeuristic? additionalScoringHeuristic, [Optional] QONTYISYPKI? scoringAlgorithm)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x820B510", Offset = "0x820A110", VA = "0x18820B510")]
		public void OBKZXYSHUQD(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x820AFD0", Offset = "0x8209BD0", VA = "0x18820AFD0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x820B010", Offset = "0x8209C10", VA = "0x18820B010")]
		private void KRHADWMYYUZ(IReadOnlyList<SearchResult> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x820ADE0", Offset = "0x82099E0", VA = "0x18820ADE0")]
		private int CGUYUGMWZMJ(ReadOnlySpan<char> a, ReadOnlySpan<char> b, int c)
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
