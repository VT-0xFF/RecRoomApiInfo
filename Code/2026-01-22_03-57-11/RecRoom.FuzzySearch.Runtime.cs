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
		[Cpp2IlInjected.Address(RVA = "0xAD7680", Offset = "0xAD5E80", VA = "0x180AD7680")]
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
		[Cpp2IlInjected.Address(RVA = "0x833BA10", Offset = "0x833A210", VA = "0x18833BA10")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD7810", Offset = "0xAD6010", VA = "0x180AD7810")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD7850", Offset = "0xAD6050", VA = "0x180AD7850")]
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
		[Cpp2IlInjected.Address(RVA = "0x833B990", Offset = "0x833A190", VA = "0x18833B990", Slot = "4")]
		public override void JPLRKQDWIBU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xAD7680", Offset = "0xAD5E80", VA = "0x180AD7680")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.FuzzySearch
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class ZLZZEJHSFHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly AEXTDRHEPQI AFCNXRPGEGY;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x833DFA0", Offset = "0x833C7A0", VA = "0x18833DFA0")]
		public ZLZZEJHSFHC(IReadOnlyCollection<string> a, [In] FuzzySearchSettings settings, [Optional] AEXTDRHEPQI.AdditionalScoreHeuristicDelegate b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x833DD60", Offset = "0x833C560", VA = "0x18833DD60")]
		public IReadOnlyList<FuzzySearchStringScored> Search(string searchString)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x833DBC0", Offset = "0x833C3C0", VA = "0x18833DBC0")]
		public void Score(string searchString)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class AEXTDRHEPQI
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public delegate int AdditionalScoreHeuristicDelegate(IReadOnlyList<char> searchableStringsPreprocessed, int searchableStringIndex, string preprocessedSearchString);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly FuzzySearchSettings CERZTARXJRQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly AdditionalScoreHeuristicDelegate RVLGJPCXCUA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly char[] WQIUFIHGXVS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly FuzzySearchStringScored[] XUALJKXXDTA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly bool[] XPOZAALPRYU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public readonly (int SearchStringIndex, int ConsecutiveCount, int Value)[] ZWLHVWLZPPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly FuzzySearchStringScored[] CDEIBMBHFRA;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0")]
		public static int GHEMWPXDNZN(IReadOnlyList<char> a, int b, string c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x83388F0", Offset = "0x83370F0", VA = "0x1883388F0")]
		public AEXTDRHEPQI(IReadOnlyCollection<string> a, [In] FuzzySearchSettings settings, [Optional] AdditionalScoreHeuristicDelegate b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8338250", Offset = "0x8336A50", VA = "0x188338250")]
		public string HSMLZHPGTWQ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x83382E0", Offset = "0x8336AE0", VA = "0x1883382E0")]
		public int JKWDQWNRIWI(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x83382F0", Offset = "0x8336AF0", VA = "0x1883382F0")]
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
		public static FuzzySearchSettings BIGUOPIZRYA
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8339970", Offset = "0x8338170", VA = "0x188339970")]
			get
			{
				return default(FuzzySearchSettings);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8339A20", Offset = "0x8338220", VA = "0x188339A20")]
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
		[Cpp2IlInjected.Address(RVA = "0xC13AE0", Offset = "0xC122E0", VA = "0x180C13AE0")]
		public FuzzySearchStringScored(int index, int score, int matchesIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8339B40", Offset = "0x8338340", VA = "0x188339B40")]
		public static int ONGIFHBIEAX([In] FuzzySearchStringScored lhs, [In] FuzzySearchStringScored rhs)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x276BD30", Offset = "0x276A530", VA = "0x18276BD30", Slot = "4")]
		public bool Equals(FuzzySearchStringScored other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8339A40", Offset = "0x8338240", VA = "0x188339A40", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8339AF0", Offset = "0x83382F0", VA = "0x188339AF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface OMDYXIHPZOW
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool OIHZBPXGHNY(string a, [Out][NotNullWhen(true)] IReadOnlyList<SearchResult>? results);
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class EPPWHVEDPSX : OMDYXIHPZOW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly int EJRRAEWVEUO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly List<(string searchString, IReadOnlyList<SearchResult> results)> FIOKNKFNOPJ;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x83398E0", Offset = "0x83380E0", VA = "0x1883398E0")]
		public EPPWHVEDPSX(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8339760", Offset = "0x8337F60", VA = "0x188339760", Slot = "4")]
		public bool OIHZBPXGHNY(string a, [Out][NotNullWhen(true)] IReadOnlyList<SearchResult>? results)
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
		private sealed class JHXZLDGKHPS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public AsyncFuzzySearch BDLWXAGXLOZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public CancellationTokenSource TWNMYOLNNOS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public string MGTXVTAWGGS;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public JHXZLDGKHPS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x833AAF0", Offset = "0x83392F0", VA = "0x18833AAF0")]
			internal SearchResult[] QQAXDZNIBTH()
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
			private JHXZLDGKHPS <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public OnSearchComplete onSearchComplete;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private TaskAwaiter<SearchResult[]> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x833D690", Offset = "0x833BE90", VA = "0x18833D690", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xB0EA50", Offset = "0xB0D250", VA = "0x180B0EA50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static readonly Log WKLAFLLOLVN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly EAJBFJKMYFB DUDHLSIPDTV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly UVJGIDXFMPW DZTZUBWFJTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly SUKTYTBMFAR.AdditionalScoringHeuristic? JKWRVRWIYVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private SearchResult[] VKWKWRAWRDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private CancellationTokenSource? URTDOUBRDDD;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool ANJTJWSMAHY
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x101CF70", Offset = "0x101B770", VA = "0x18101CF70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8339620", Offset = "0x8337E20", VA = "0x188339620")]
		public AsyncFuzzySearch(EAJBFJKMYFB targets, UVJGIDXFMPW algorithm, [Optional] SUKTYTBMFAR.AdditionalScoringHeuristic? additionalScoringHeuristic)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x83394B0", Offset = "0x8337CB0", VA = "0x1883394B0")]
		[AsyncStateMachine(typeof(<Search>d__10))]
		public void Search(string searchString, OnSearchComplete onSearchComplete)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8339470", Offset = "0x8337C70", VA = "0x188339470")]
		public void Cancel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class SUKTYTBMFAR
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public delegate int AdditionalScoringHeuristic(ReadOnlySpan<char> searchString, ReadOnlySpan<char> targetString, int targetStringIndex);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x833D310", Offset = "0x833BB10", VA = "0x18833D310")]
		public static int VXNLFZZGQGF([In] SearchResult lhs, [In] SearchResult rhs)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct SearchResult
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class QTMRFVIWIQQ : IEnumerable<bool>, IEnumerable, IEnumerator<bool>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private int RXIHLDXPFTB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private bool VMXRQLYYOUI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private int AWPKGSEYDWO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public SearchResult BDLWXAGXLOZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public SearchResult LUHQKPWTGKA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private int BWHCZIMPJCX;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			private bool JKDWTBNETDT
			{
				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x10A36B0", Offset = "0x10A1EB0", VA = "0x1810A36B0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private object BXTOFOKJAZT
			{
				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x7724370", Offset = "0x7722B70", VA = "0x187724370", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x1326640", Offset = "0x1324E40", VA = "0x181326640")]
			[DebuggerHidden]
			public QTMRFVIWIQQ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "7")]
			[DebuggerHidden]
			private void QMTXDIUIKRI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x833CA60", Offset = "0x833B260", VA = "0x18833CA60", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x833CA20", Offset = "0x833B220", VA = "0x18833CA20", Slot = "10")]
			[DebuggerHidden]
			private void FKDUCXAGPJJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x833C960", Offset = "0x833B160", VA = "0x18833C960", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<bool> EAQRIBRODMS()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x833C960", Offset = "0x833B160", VA = "0x18833C960", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator LRASTPXJBWO()
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
		public readonly IEnumerable<bool> DKSMAYXUSOI
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x833D320", Offset = "0x833BB20", VA = "0x18833D320")]
			[IteratorStateMachine(typeof(QTMRFVIWIQQ))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x833D3B0", Offset = "0x833BBB0", VA = "0x18833D3B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x410A6D0", Offset = "0x4108ED0", VA = "0x18410A6D0")]
		public StringFormatSettings(bool ignoreCase, bool ignoreSpaces)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x833D600", Offset = "0x833BE00", VA = "0x18833D600")]
		public string Format(string str)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface UVJGIDXFMPW
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "0")]
		float Score(ReadOnlySpan<char> searchString, ReadOnlySpan<char> targetString, [Optional] List<int>? matchingCharacters);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class ILUARAYTAUE : UVJGIDXFMPW
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public readonly struct Settings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public readonly float ConsecutiveCharacterMultiplier;

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x15BF9C0", Offset = "0x15BE1C0", VA = "0x1815BF9C0")]
			public Settings(float consecutiveCharacterMultiplier)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private int[] QXJBUGJTCYV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private int[] NQCKZNPDZIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private BitArray XMSGDCCPHTG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly Settings HMBJGLXVRBA;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x833AA20", Offset = "0x8339220", VA = "0x18833AA20")]
		public ILUARAYTAUE([In] Settings settings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x833A590", Offset = "0x8338D90", VA = "0x18833A590", Slot = "4")]
		public float Score(ReadOnlySpan<char> searchString, ReadOnlySpan<char> targetString, [Optional] List<int>? matchingCharacters)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x833A500", Offset = "0x8338D00", VA = "0x18833A500")]
		private void QSKJKWLFJJT(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x833A140", Offset = "0x8338940", VA = "0x18833A140")]
		private float BLELZMQRLRS(ReadOnlySpan<char> a, ReadOnlySpan<char> b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x833A910", Offset = "0x8339110", VA = "0x18833A910")]
		private int XSBRNRPSHPZ(ReadOnlySpan<char> a, ReadOnlySpan<char> b, int c)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class KSVGJANDOSC : UVJGIDXFMPW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly int MLNMOEEWFGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private BitArray? WCBGMSJIUUC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private (int SearchStringIndex, int ConsecutiveCount, int Value)[] LGXAYCEZVIC;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x833B8D0", Offset = "0x833A0D0", VA = "0x18833B8D0")]
		public KSVGJANDOSC(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x833B220", Offset = "0x8339A20", VA = "0x18833B220", Slot = "4")]
		public float Score(ReadOnlySpan<char> searchString, ReadOnlySpan<char> targetString, [Optional] List<int>? matchingCharacters)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface EAJBFJKMYFB
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		IEnumerable<ReadOnlyMemory<char>> YPKVVPZDSAU
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class REEIPOTPVKA : EAJBFJKMYFB
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class CYJUGVKDLRI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public StringFormatSettings HMBJGLXVRBA;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public CYJUGVKDLRI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x83396D0", Offset = "0x8337ED0", VA = "0x1883396D0")]
			internal string MOXBJULNNJZ(string a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class GGMBFUNXMQK : IEnumerable<ReadOnlyMemory<char>>, IEnumerable, IEnumerator<ReadOnlyMemory<char>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			private int RXIHLDXPFTB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			private ReadOnlyMemory<char> VMXRQLYYOUI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			private int AWPKGSEYDWO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public REEIPOTPVKA BDLWXAGXLOZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			private ReadOnlyMemory<char> VBAHJSWBJFD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			private IEnumerator<IndexValuePair<char>> YLNEDRBNMVQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			private int BVWPEUYUQGF;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private ReadOnlyMemory<char> BIZHZDUBMVZ
			{
				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0xCD79C0", Offset = "0xCD61C0", VA = "0x180CD79C0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(ReadOnlyMemory<char>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private object BXTOFOKJAZT
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x833A010", Offset = "0x8338810", VA = "0x18833A010", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x1A4F060", Offset = "0x1A4D860", VA = "0x181A4F060")]
			[DebuggerHidden]
			public GGMBFUNXMQK(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x833A060", Offset = "0x8338860", VA = "0x18833A060", Slot = "7")]
			[DebuggerHidden]
			private void QMTXDIUIKRI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8339C40", Offset = "0x8338440", VA = "0x188339C40", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x833A0F0", Offset = "0x83388F0", VA = "0x18833A0F0")]
			private void YQEVNPXUUBC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8339B60", Offset = "0x8338360", VA = "0x188339B60", Slot = "10")]
			[DebuggerHidden]
			private void FKDUCXAGPJJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8339BA0", Offset = "0x83383A0", VA = "0x188339BA0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<ReadOnlyMemory<char>> TISSEKMJELC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8339BA0", Offset = "0x83383A0", VA = "0x188339BA0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator LRASTPXJBWO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly char[] QAXKRIHYSAT;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IEnumerable<ReadOnlyMemory<char>> YPKVVPZDSAU
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x833CB00", Offset = "0x833B300", VA = "0x18833CB00", Slot = "4")]
			[IteratorStateMachine(typeof(GGMBFUNXMQK))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x833CB80", Offset = "0x833B380", VA = "0x18833CB80")]
		public REEIPOTPVKA(IEnumerable<string> a, StringFormatSettings b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public sealed class OARQJPUUIRF : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public delegate void SearchCompleteDelegate(IReadOnlyList<FuzzySearchStringScored> results, IReadOnlyList<bool> charMatches);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly OMDYXIHPZOW? FIOKNKFNOPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly AsyncFuzzySearch YUYCJNBHFSD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly StringFormatSettings WNGQYGCWCSN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly FuzzySearchSettings HMBJGLXVRBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly SearchCompleteDelegate OSOKQQYWMPQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly SUKTYTBMFAR.AdditionalScoringHeuristic? JKWRVRWIYVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private IReadOnlyList<FuzzySearchStringScored> WDBPDTWCEDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private IReadOnlyList<bool> LWRMDGQVSDB;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public IReadOnlyList<FuzzySearchStringScored> GXIBEEPLTXI
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xAB39E0", Offset = "0xAB21E0", VA = "0x180AB39E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public IReadOnlyList<bool> XMOIUFBONPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xAAD0E0", Offset = "0xAAB8E0", VA = "0x180AAD0E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool ANJTJWSMAHY
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x833C550", Offset = "0x833AD50", VA = "0x18833C550")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x833C570", Offset = "0x833AD70", VA = "0x18833C570")]
		public OARQJPUUIRF(IReadOnlyList<string> a, [In] FuzzySearchSettings settings, SearchCompleteDelegate b, [Optional] SUKTYTBMFAR.AdditionalScoringHeuristic? additionalScoringHeuristic, [Optional] UVJGIDXFMPW? scoringAlgorithm)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x833BCC0", Offset = "0x833A4C0", VA = "0x18833BCC0")]
		public void MACXYLPOYWL(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x833BC80", Offset = "0x833A480", VA = "0x18833BC80", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x833C040", Offset = "0x833A840", VA = "0x18833C040")]
		private void UDUCBMGRTYZ(IReadOnlyList<SearchResult> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x833BA90", Offset = "0x833A290", VA = "0x18833BA90")]
		private int AEYGPIZCPGR(ReadOnlySpan<char> a, ReadOnlySpan<char> b, int c)
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
