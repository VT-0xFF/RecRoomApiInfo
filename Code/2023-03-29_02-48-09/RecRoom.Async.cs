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
		private struct KMIALNEBJOL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public string LMPHGOGJNDD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public LMAPELGHNPL PHLPFKDGNNA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public float? LIEFNMFMCMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public float? MLFABMGEJNO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public IDisposable IEMDIAJLPJK;
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class HPDKHDCMFNL : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8A7890", Offset = "0x8A6690", VA = "0x1808A7890")]
			[DebuggerHidden]
			public HPDKHDCMFNL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x663D720", Offset = "0x663C520", VA = "0x18663D720", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x663D920", Offset = "0x663C720", VA = "0x18663D920", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class JJIAOJKBKFA : IEnumerator<object>, IEnumerator, IDisposable
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
			public NGNPLNHEGFI promise;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8A7890", Offset = "0x8A6690", VA = "0x1808A7890")]
			[DebuggerHidden]
			public JJIAOJKBKFA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x663D960", Offset = "0x663C760", VA = "0x18663D960", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x663D9C0", Offset = "0x663C7C0", VA = "0x18663D9C0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private List<KMIALNEBJOL> GEMGLAOCCCI;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool BOOHAEHGJAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x7F1340", Offset = "0x7F0140", VA = "0x1807F1340")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x934750", Offset = "0x933550", VA = "0x180934750")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x663D580", Offset = "0x663C380", VA = "0x18663D580")]
		public static AsyncBatch Create(Transform AABHIBJPKOH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x663D630", Offset = "0x663C430", VA = "0x18663D630")]
		[IteratorStateMachine(typeof(HPDKHDCMFNL))]
		private IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x663D450", Offset = "0x663C250", VA = "0x18663D450")]
		public void Add(string EOPECGOILOC, LMAPELGHNPL DFJCJFEOFBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x663D280", Offset = "0x663C080", VA = "0x18663D280")]
		public void Add(string EOPECGOILOC, IEnumerator LEAEKLAOLEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x663D1F0", Offset = "0x663BFF0", VA = "0x18663D1F0")]
		[IteratorStateMachine(typeof(JJIAOJKBKFA))]
		private IEnumerator ACEOPKLGODE(NGNPLNHEGFI DFJCJFEOFBE, IEnumerator LEAEKLAOLEL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x663D6A0", Offset = "0x663C4A0", VA = "0x18663D6A0")]
		public AsyncBatch()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class APBGBLGDKGB<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class CNOPEAKCLEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TKey EGGKJKOHLOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public LMAPELGHNPL PHLPFKDGNNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public DateTime BNEANOICGHA;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x18DAC40", Offset = "0x18D9A40", VA = "0x1818DAC40")]
		public CNOPEAKCLEN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class MJOOLOOEFMB<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public global::APBGBLGDKGB<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public CNOPEAKCLEN cacheEntry;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x18DAC40", Offset = "0x18D9A40", VA = "0x1818DAC40")]
		public MJOOLOOEFMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x395FB20", Offset = "0x395E920", VA = "0x18395FB20")]
		internal void <SetPromise>b__0(string e)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<TKey, CNOPEAKCLEN> IMBDKJJAFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private LinkedList<CNOPEAKCLEN> HIDNIICAKLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private LinkedList<CNOPEAKCLEN> EMMPMHMFLPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int BCCIKCOCOMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool EFLAMACGDBA;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3B7FBC0", Offset = "0x3B7E9C0", VA = "0x183B7FBC0")]
	public APBGBLGDKGB([Optional] int? BCCIKCOCOMJ, bool EFLAMACGDBA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3B7F270", Offset = "0x3B7E070", VA = "0x183B7F270")]
	public bool HOKNCBODOOP(TKey ANFHHLAHMJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2B87E40", Offset = "0x2B86C40", VA = "0x182B87E40")]
	public global::ONJEHKCKOLK<TValue> KJDGMLLJHKH<TValue>(TKey ANFHHLAHMJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2B87B80", Offset = "0x2B86980", VA = "0x182B87B80")]
	public void DJFHMHBCIBN<TValue>(TKey ANFHHLAHMJD, TValue NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2B88240", Offset = "0x2B87040", VA = "0x182B88240")]
	public void MGFPPBJIMGB<TValue>(TKey ANFHHLAHMJD, global::ONJEHKCKOLK<TValue> DFJCJFEOFBE, TimeSpan IOBLPDMHHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2B87A20", Offset = "0x2B86820", VA = "0x182B87A20")]
	public global::ONJEHKCKOLK<TValue> ANOGKNKCCFG<TValue>(TKey ANFHHLAHMJD, Func<global::ONJEHKCKOLK<TValue>> FBILGMBJJCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2B878E0", Offset = "0x2B866E0", VA = "0x182B878E0")]
	public global::ONJEHKCKOLK<TValue> ANOGKNKCCFG<TValue>(TKey ANFHHLAHMJD, Func<global::ONJEHKCKOLK<TValue>> FBILGMBJJCJ, TimeSpan IOBLPDMHHID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3B7F2A0", Offset = "0x3B7E0A0", VA = "0x183B7F2A0")]
	public bool IHKCCNMHHEB(TKey ANFHHLAHMJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3B7F1F0", Offset = "0x3B7DFF0", VA = "0x183B7F1F0")]
	public void FDAOBHPPNLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3B7EC20", Offset = "0x3B7DA20", VA = "0x183B7EC20")]
	private void BAFJJBCGNIC(CNOPEAKCLEN JPBMJBLPABN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3B7E410", Offset = "0x3B7D210", VA = "0x183B7E410")]
	private void ADHLOCIPKPL(CNOPEAKCLEN JPBMJBLPABN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3B7F4D0", Offset = "0x3B7E2D0", VA = "0x183B7F4D0")]
	private void OKKLDFMGIFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3B7FA90", Offset = "0x3B7E890", VA = "0x183B7FA90")]
	private bool PBBBIFCMFBO(CNOPEAKCLEN JPBMJBLPABN)
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
