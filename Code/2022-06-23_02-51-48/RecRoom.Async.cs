using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Async
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class AsyncBatch : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private struct LKNNJOLHJDC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public string MMPCHPMLKBM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public IMECNLPEGGD KDLMOPBIKOO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public float? KJOJMHNDFLF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public float? OHEICALCFGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public IDisposable FIJGNNMCKLA;
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class IIJGDMGIMKI : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public AsyncBatch <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600000C")]
				[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x574120", VA = "0x180574F20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600000E")]
				[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x574120", VA = "0x180574F20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x604130", Offset = "0x603330", VA = "0x180604130")]
			[DebuggerHidden]
			public IIJGDMGIMKI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573B10", VA = "0x180574910", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x4FF0D30", Offset = "0x4FEFF30", VA = "0x184FF0D30", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x4FF0F00", Offset = "0x4FF0100", VA = "0x184FF0F00", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class KPCPFEKKKCP : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public IEnumerator coroutine;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public FOIHHBNLNAM promise;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x574120", VA = "0x180574F20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x574120", VA = "0x180574F20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x604130", Offset = "0x603330", VA = "0x180604130")]
			[DebuggerHidden]
			public KPCPFEKKKCP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573B10", VA = "0x180574910", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x4FF0F50", Offset = "0x4FF0150", VA = "0x184FF0F50", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x4FF0FB0", Offset = "0x4FF01B0", VA = "0x184FF0FB0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private List<LKNNJOLHJDC> CJDIOKNIMEG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool KKJDEHIOIKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x5CC100", Offset = "0x5CB300", VA = "0x1805CC100")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x5CC190", Offset = "0x5CB390", VA = "0x1805CC190")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x4FF0B30", Offset = "0x4FEFD30", VA = "0x184FF0B30")]
		public static AsyncBatch Create(Transform KJHHLEFOCFM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x4FF0C50", Offset = "0x4FEFE50", VA = "0x184FF0C50")]
		[IteratorStateMachine(typeof(IIJGDMGIMKI))]
		private IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x4FF0A10", Offset = "0x4FEFC10", VA = "0x184FF0A10")]
		public void Add(string HKLPIGDOLHA, IMECNLPEGGD BOLGHLAFKJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4FF0850", Offset = "0x4FEFA50", VA = "0x184FF0850")]
		public void Add(string HKLPIGDOLHA, IEnumerator OHAGLCOFPKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4FF0BC0", Offset = "0x4FEFDC0", VA = "0x184FF0BC0")]
		[IteratorStateMachine(typeof(KPCPFEKKKCP))]
		private IEnumerator GLCEAOPBDFE(FOIHHBNLNAM BOLGHLAFKJM, IEnumerator OHAGLCOFPKJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4FF0CC0", Offset = "0x4FEFEC0", VA = "0x184FF0CC0")]
		public AsyncBatch()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class PMINIICLJGG<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class NMDKIGDLKJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TKey PKFENIANCPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public IMECNLPEGGD KDLMOPBIKOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public DateTime GNFFEAMCFCD;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x17B4810", Offset = "0x17B3A10", VA = "0x1817B4810")]
		public NMDKIGDLKJE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class EGGMKEEAMHG<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public global::PMINIICLJGG<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public TKey key;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x17B4810", Offset = "0x17B3A10", VA = "0x1817B4810")]
		public EGGMKEEAMHG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class FKMKOFBGBPF<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public NMDKIGDLKJE cacheEntry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public EGGMKEEAMHG<TValue> CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x17B4810", Offset = "0x17B3A10", VA = "0x1817B4810")]
		public FKMKOFBGBPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3BB3E80", Offset = "0x3BB3080", VA = "0x183BB3E80")]
		internal void <SetPromise>b__0(string e)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<TKey, NMDKIGDLKJE> IAIJIEKIHGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private LinkedList<NMDKIGDLKJE> AGHMPBGDOMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private LinkedList<NMDKIGDLKJE> KEENIKHEGIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int OMFKEGKPHLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool NOPJKDDNOOD;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public ICollection<TKey> LBPFCCEONND
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1E3A610", Offset = "0x1E39810", VA = "0x181E3A610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3BB9840", Offset = "0x3BB8A40", VA = "0x183BB9840")]
	public PMINIICLJGG([Optional] int? OMFKEGKPHLC, bool NOPJKDDNOOD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2200A50", Offset = "0x21FFC50", VA = "0x182200A50")]
	public bool KKGMAEPOEJA(TKey DHDAEDILENC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1930630", Offset = "0x192F830", VA = "0x181930630")]
	public global::IAGOKENNLHI<TValue> KCLLDDJMAFI<TValue>(TKey DHDAEDILENC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2DF2A10", Offset = "0x2DF1C10", VA = "0x182DF2A10")]
	public void HIDJLFDDMID<TValue>(TKey DHDAEDILENC, TValue PNLMJAPAHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2DF3530", Offset = "0x2DF2730", VA = "0x182DF3530")]
	public void JIBAJOFOEMJ<TValue>(TKey DHDAEDILENC, global::IAGOKENNLHI<TValue> BOLGHLAFKJM, TimeSpan MCMGOMGJHDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x1930170", Offset = "0x192F370", VA = "0x181930170")]
	public global::IAGOKENNLHI<TValue> FBBOFPHOGPD<TValue>(TKey DHDAEDILENC, Func<global::IAGOKENNLHI<TValue>> GJEOMDBIHKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1930030", Offset = "0x192F230", VA = "0x181930030")]
	public global::IAGOKENNLHI<TValue> FBBOFPHOGPD<TValue>(TKey DHDAEDILENC, Func<global::IAGOKENNLHI<TValue>> GJEOMDBIHKN, TimeSpan MCMGOMGJHDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3BB9070", Offset = "0x3BB8270", VA = "0x183BB9070")]
	public bool MNIDDOJOCKH(TKey DHDAEDILENC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3BB9360", Offset = "0x3BB8560", VA = "0x183BB9360")]
	public int MPBDEDPNACP(Predicate<TKey> LHOELMCHLIN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3BB7CF0", Offset = "0x3BB6EF0", VA = "0x183BB7CF0")]
	public void DHEPINIAIJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3BB8970", Offset = "0x3BB7B70", VA = "0x183BB8970")]
	private void KOLFBPDOJFJ(NMDKIGDLKJE GOHLBANHDJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3BB8030", Offset = "0x3BB7230", VA = "0x183BB8030")]
	private void FGHPGLANNJG(NMDKIGDLKJE GOHLBANHDJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3BB8EC0", Offset = "0x3BB80C0", VA = "0x183BB8EC0")]
	private void LEKHOLLDFNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3BB7960", Offset = "0x3BB6B60", VA = "0x183BB7960")]
	private bool AJHLMFLNLAA(NMDKIGDLKJE GOHLBANHDJB)
	{
		return default(bool);
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
