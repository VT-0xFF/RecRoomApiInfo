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
		private struct BHEBNEJGAHF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public string FACJFEGFGOO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public IGOPHNBFNOE FMCFGPOMGOF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public float? OFFONMCBGKI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public float? CACGBPGGIJN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public IDisposable JADAEAMKLDF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class KMLLKBADGGH : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x67B200", Offset = "0x679C00", VA = "0x18067B200")]
			[DebuggerHidden]
			public KMLLKBADGGH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x609D7B0", Offset = "0x609C1B0", VA = "0x18609D7B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x609D9B0", Offset = "0x609C3B0", VA = "0x18609D9B0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class FKIEHGDDJPI : IEnumerator<object>, IEnumerator, IDisposable
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
			public EONHFJBEBFJ promise;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x67B200", Offset = "0x679C00", VA = "0x18067B200")]
			[DebuggerHidden]
			public FKIEHGDDJPI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x609D710", Offset = "0x609C110", VA = "0x18609D710", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x609D770", Offset = "0x609C170", VA = "0x18609D770", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private List<BHEBNEJGAHF> HPCEMNDPCAD;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool DIIJOOGAEKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x6923D0", Offset = "0x690DD0", VA = "0x1806923D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x783640", Offset = "0x782040", VA = "0x180783640")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x609D4E0", Offset = "0x609BEE0", VA = "0x18609D4E0")]
		public static AsyncBatch Create(Transform LFAIGCEGCPL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x609D620", Offset = "0x609C020", VA = "0x18609D620")]
		[IteratorStateMachine(typeof(KMLLKBADGGH))]
		private IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x609D3B0", Offset = "0x609BDB0", VA = "0x18609D3B0")]
		public void Add(string NBODBMLPNJA, IGOPHNBFNOE KABGCAHOLIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x609D1E0", Offset = "0x609BBE0", VA = "0x18609D1E0")]
		public void Add(string NBODBMLPNJA, IEnumerator FHAENLMAGBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x609D590", Offset = "0x609BF90", VA = "0x18609D590")]
		[IteratorStateMachine(typeof(FKIEHGDDJPI))]
		private IEnumerator JEKANAMJKNH(EONHFJBEBFJ KABGCAHOLIL, IEnumerator FHAENLMAGBC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x609D690", Offset = "0x609C090", VA = "0x18609D690")]
		public AsyncBatch()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class PBLPIPPDNCP<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class HCANBBKLKML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TKey LLHJHGGBGGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public IGOPHNBFNOE FMCFGPOMGOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public DateTime PAEMMHOMCKG;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x14A8F00", Offset = "0x14A7900", VA = "0x1814A8F00")]
		public HCANBBKLKML()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class AIGHACDLDHF<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public global::PBLPIPPDNCP<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public HCANBBKLKML cacheEntry;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x14A8F00", Offset = "0x14A7900", VA = "0x1814A8F00")]
		public AIGHACDLDHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3235860", Offset = "0x3234260", VA = "0x183235860")]
		internal void <SetPromise>b__0(string e)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<TKey, HCANBBKLKML> ODMPDKFLOEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private LinkedList<HCANBBKLKML> LNMJIMLKLHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private LinkedList<HCANBBKLKML> FOJDGNAMIBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int NBDLKKAMIJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool IDMDOBIMDJI;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public ICollection<TKey> IBCHNDKEOEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2596A10", Offset = "0x2595410", VA = "0x182596A10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x40E8960", Offset = "0x40E7360", VA = "0x1840E8960")]
	public PBLPIPPDNCP([Optional] int? NBDLKKAMIJF, bool IDMDOBIMDJI = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2585B50", Offset = "0x2584550", VA = "0x182585B50")]
	public bool OMNCCBLJMKA(TKey AIGAKEKDKHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2412D30", Offset = "0x2411730", VA = "0x182412D30")]
	public global::DIHJKCFGFNO<TValue> LJIOMCNAKJB<TValue>(TKey AIGAKEKDKHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2410F30", Offset = "0x240F930", VA = "0x182410F30")]
	public void CKBOMKNNBHG<TValue>(TKey AIGAKEKDKHM, TValue MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x24119B0", Offset = "0x24103B0", VA = "0x1824119B0")]
	public void GJBGKAIAOHC<TValue>(TKey AIGAKEKDKHM, global::DIHJKCFGFNO<TValue> KABGCAHOLIL, TimeSpan IPBGEHLMGCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2412470", Offset = "0x2410E70", VA = "0x182412470")]
	public global::DIHJKCFGFNO<TValue> LHPGAGGEMHC<TValue>(TKey AIGAKEKDKHM, Func<global::DIHJKCFGFNO<TValue>> CDHGMHPAHLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2412520", Offset = "0x2410F20", VA = "0x182412520")]
	public global::DIHJKCFGFNO<TValue> LHPGAGGEMHC<TValue>(TKey AIGAKEKDKHM, Func<global::DIHJKCFGFNO<TValue>> CDHGMHPAHLE, TimeSpan IPBGEHLMGCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x40E7C20", Offset = "0x40E6620", VA = "0x1840E7C20")]
	public bool EMIFMEAGDDE(TKey AIGAKEKDKHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x40E8270", Offset = "0x40E6C70", VA = "0x1840E8270")]
	public int KCBMKPEBDJF(Predicate<TKey> KIEFNBLKNLB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x40E88D0", Offset = "0x40E72D0", VA = "0x1840E88D0")]
	public void PGHHBKOCHPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x40E8080", Offset = "0x40E6A80", VA = "0x1840E8080")]
	private void EPGAJDPPIHK(HCANBBKLKML DCAFEJFFOOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x40E6E20", Offset = "0x40E5820", VA = "0x1840E6E20")]
	private void APDCKDLABEG(HCANBBKLKML DCAFEJFFOOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x40E7530", Offset = "0x40E5F30", VA = "0x1840E7530")]
	private void EBHPKEIICHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x40E7890", Offset = "0x40E6290", VA = "0x1840E7890")]
	private bool EBIOKLHDBKD(HCANBBKLKML DCAFEJFFOOI)
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
