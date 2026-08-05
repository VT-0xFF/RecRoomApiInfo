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
		private struct OGDDCGCGAFL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public string NKAGADDFNIH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public KJNBDKOEMOC EBOLFNGJDHO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public float? JHPGAFIBNGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public float? DKACNCIGCHN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public IDisposable ILOMBCGCINL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class KGMBCDIHAAO : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x69B7D0", Offset = "0x69A9D0", VA = "0x18069B7D0")]
			[DebuggerHidden]
			public KGMBCDIHAAO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x58AE80", Offset = "0x58A080", VA = "0x18058AE80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x51F14B0", Offset = "0x51F06B0", VA = "0x1851F14B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x51F1680", Offset = "0x51F0880", VA = "0x1851F1680", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class CBOAFAOKMGM : IEnumerator<object>, IEnumerator, IDisposable
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
			public JLGLDFIOJOP promise;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x69B7D0", Offset = "0x69A9D0", VA = "0x18069B7D0")]
			[DebuggerHidden]
			public CBOAFAOKMGM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x58AE80", Offset = "0x58A080", VA = "0x18058AE80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x51F1400", Offset = "0x51F0600", VA = "0x1851F1400", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x51F1460", Offset = "0x51F0660", VA = "0x1851F1460", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private List<OGDDCGCGAFL> OPMIGNELNDL;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool NBGHDFPIFAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x58A190", Offset = "0x589390", VA = "0x18058A190")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x6E4E80", Offset = "0x6E4080", VA = "0x1806E4E80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x51F1200", Offset = "0x51F0400", VA = "0x1851F1200")]
		public static AsyncBatch Create(Transform DBICPFPGAAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x51F1320", Offset = "0x51F0520", VA = "0x1851F1320")]
		[IteratorStateMachine(typeof(KGMBCDIHAAO))]
		private IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x51F0F20", Offset = "0x51F0120", VA = "0x1851F0F20")]
		public void Add(string KFCJDHCECCC, KJNBDKOEMOC DBBNLJKOLFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x51F1040", Offset = "0x51F0240", VA = "0x1851F1040")]
		public void Add(string KFCJDHCECCC, IEnumerator BIIJFNDJGOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x51F1290", Offset = "0x51F0490", VA = "0x1851F1290")]
		[IteratorStateMachine(typeof(CBOAFAOKMGM))]
		private IEnumerator GIFLBIFLFAG(JLGLDFIOJOP DBBNLJKOLFO, IEnumerator BIIJFNDJGOF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x51F1390", Offset = "0x51F0590", VA = "0x1851F1390")]
		public AsyncBatch()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class PAMKDDFKFEO<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class DLOFPFFIBCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TKey CHPMOLLJLMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public KJNBDKOEMOC EBOLFNGJDHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public DateTime HLFIEEMMOMK;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1D6C580", Offset = "0x1D6B780", VA = "0x181D6C580")]
		public DLOFPFFIBCP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class FIMFLLNHNGP<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public global::PAMKDDFKFEO<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public TKey key;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1D6C580", Offset = "0x1D6B780", VA = "0x181D6C580")]
		public FIMFLLNHNGP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class PNMDGJAPMHK<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public DLOFPFFIBCP cacheEntry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public FIMFLLNHNGP<TValue> CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1D6C580", Offset = "0x1D6B780", VA = "0x181D6C580")]
		public PNMDGJAPMHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x31FBD30", Offset = "0x31FAF30", VA = "0x1831FBD30")]
		internal void <SetPromise>b__0(string e)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<TKey, DLOFPFFIBCP> PHICLPBHDPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private LinkedList<DLOFPFFIBCP> ACEPFILEOFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private LinkedList<DLOFPFFIBCP> DKLOIAGIJKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int PMCELGFHKPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool KPPJGFCCNAP;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public ICollection<TKey> ICJDAAGJBDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1E4FC00", Offset = "0x1E4EE00", VA = "0x181E4FC00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x31EEBB0", Offset = "0x31EDDB0", VA = "0x1831EEBB0")]
	public PAMKDDFKFEO([Optional] int? PMCELGFHKPK, bool KPPJGFCCNAP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2A61D80", Offset = "0x2A60F80", VA = "0x182A61D80")]
	public bool GJHAJBFNDCI(TKey ICIBGJCBOAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2B8E7D0", Offset = "0x2B8D9D0", VA = "0x182B8E7D0")]
	public global::FJLAHCBCPIJ<TValue> IKNBAHOIMBC<TValue>(TKey ICIBGJCBOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x260F280", Offset = "0x260E480", VA = "0x18260F280")]
	public void IFHIFCHCLLO<TValue>(TKey ICIBGJCBOAM, TValue LDPMPDNIHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x260E850", Offset = "0x260DA50", VA = "0x18260E850")]
	public void BHLEEOMAALO<TValue>(TKey ICIBGJCBOAM, global::FJLAHCBCPIJ<TValue> DBBNLJKOLFO, TimeSpan HKLMLCLOCOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2B8ED60", Offset = "0x2B8DF60", VA = "0x182B8ED60")]
	public global::FJLAHCBCPIJ<TValue> OOOOIDBOCAI<TValue>(TKey ICIBGJCBOAM, Func<global::FJLAHCBCPIJ<TValue>> LJLMHCKNALO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x209B080", Offset = "0x209A280", VA = "0x18209B080")]
	public global::FJLAHCBCPIJ<TValue> OOOOIDBOCAI<TValue>(TKey ICIBGJCBOAM, Func<global::FJLAHCBCPIJ<TValue>> LJLMHCKNALO, TimeSpan HKLMLCLOCOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x31ECCD0", Offset = "0x31EBED0", VA = "0x1831ECCD0")]
	public bool CDCPBPNLMGM(TKey ICIBGJCBOAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x31ED830", Offset = "0x31ECA30", VA = "0x1831ED830")]
	public int JAJDCGJIKMC(Predicate<TKey> BLAOOANMOMC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x31EE790", Offset = "0x31ED990", VA = "0x1831EE790")]
	public void OAHGKPPJHGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x31ED640", Offset = "0x31EC840", VA = "0x1831ED640")]
	private void IDOGJLCCJPJ(DLOFPFFIBCP OKNHECADDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x31EE230", Offset = "0x31ED430", VA = "0x1831EE230")]
	private void JDHBKOFEEOI(DLOFPFFIBCP OKNHECADDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x31ECF00", Offset = "0x31EC100", VA = "0x1831ECF00")]
	private void DNJLLHKJNFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x31EE950", Offset = "0x31EDB50", VA = "0x1831EE950")]
	private bool OHDFEPEGFEG(DLOFPFFIBCP OKNHECADDHE)
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
