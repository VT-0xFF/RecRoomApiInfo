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
		private struct ABOKEOMCEFB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public string JMBPOHFOGFE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public JFMFFKHCJLK KNOKDKJNIIH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public float? HECHOGINLNE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public float? LMEKPFEEDAM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public IDisposable PDIJAAJFFMH;
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class KNDNFJMNPGN : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x60FBA0", Offset = "0x60E3A0", VA = "0x18060FBA0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x60FBA0", Offset = "0x60E3A0", VA = "0x18060FBA0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x60FD00", Offset = "0x60E500", VA = "0x18060FD00")]
			[DebuggerHidden]
			public KNDNFJMNPGN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x4214660", Offset = "0x4212E60", VA = "0x184214660", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x4214830", Offset = "0x4213030", VA = "0x184214830", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class IJIAMEMFHDP : IEnumerator<object>, IEnumerator, IDisposable
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
			public CBHCDHNKCAP promise;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x60FBA0", Offset = "0x60E3A0", VA = "0x18060FBA0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x60FBA0", Offset = "0x60E3A0", VA = "0x18060FBA0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x60FD00", Offset = "0x60E500", VA = "0x18060FD00")]
			[DebuggerHidden]
			public IJIAMEMFHDP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x42145B0", Offset = "0x4212DB0", VA = "0x1842145B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x4214610", Offset = "0x4212E10", VA = "0x184214610", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private List<ABOKEOMCEFB> OGKBALFBKNM;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool NAEFKJMGHME
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x5F6F80", Offset = "0x5F5780", VA = "0x1805F6F80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x5F6F70", Offset = "0x5F5770", VA = "0x1805F6F70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x42143B0", Offset = "0x4212BB0", VA = "0x1842143B0")]
		public static AsyncBatch Create(Transform CELKNCFBAOE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x42144D0", Offset = "0x4212CD0", VA = "0x1842144D0")]
		[IteratorStateMachine(typeof(KNDNFJMNPGN))]
		private IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x42140D0", Offset = "0x42128D0", VA = "0x1842140D0")]
		public void Add(string JNAACNJBHOF, JFMFFKHCJLK BBCOFFFEBJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x42141F0", Offset = "0x42129F0", VA = "0x1842141F0")]
		public void Add(string JNAACNJBHOF, IEnumerator FNJEFCAEDBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4214440", Offset = "0x4212C40", VA = "0x184214440")]
		[IteratorStateMachine(typeof(IJIAMEMFHDP))]
		private IEnumerator HLPHGPPIFHA(CBHCDHNKCAP BBCOFFFEBJD, IEnumerator FNJEFCAEDBK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4214540", Offset = "0x4212D40", VA = "0x184214540")]
		public AsyncBatch()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class JCNEHCBBKDF<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class CMFIDIHPEJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TKey HMKHOIFGHNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public JFMFFKHCJLK KNOKDKJNIIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public DateTime DOFHCEBKEHK;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xB6A800", Offset = "0xB69000", VA = "0x180B6A800")]
		public CMFIDIHPEJO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class IBJHGMBCLOB<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public global::JCNEHCBBKDF<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public TKey key;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xB6A800", Offset = "0xB69000", VA = "0x180B6A800")]
		public IBJHGMBCLOB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class EOGJOBNMMHA<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public CMFIDIHPEJO cacheEntry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public IBJHGMBCLOB<TValue> CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xB6A800", Offset = "0xB69000", VA = "0x180B6A800")]
		public EOGJOBNMMHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x50FB1F0", Offset = "0x50F99F0", VA = "0x1850FB1F0")]
		internal void <SetPromise>b__0(string e)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<TKey, CMFIDIHPEJO> ABKIIIEHBJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private LinkedList<CMFIDIHPEJO> GCNKJGIAJLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private LinkedList<CMFIDIHPEJO> DCNDFLKJGEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int FHHMACKPMJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool NNJLOALKHAL;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public ICollection<TKey> CFIPAICBBJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xE2A9E0", Offset = "0xE291E0", VA = "0x180E2A9E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x51083D0", Offset = "0x5106BD0", VA = "0x1851083D0")]
	public JCNEHCBBKDF([Optional] int? FHHMACKPMJJ, bool NNJLOALKHAL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x30531C0", Offset = "0x30519C0", VA = "0x1830531C0")]
	public bool LDBAKCLKFMM(TKey BAGMDNPKAJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1196C80", Offset = "0x1195480", VA = "0x181196C80")]
	public global::DCBCPMGHAFG<TValue> CBHACJMHMNJ<TValue>(TKey BAGMDNPKAJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0xC54AA0", Offset = "0xC532A0", VA = "0x180C54AA0")]
	public void AHEEJAHFBBB<TValue>(TKey BAGMDNPKAJL, TValue CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xC55CA0", Offset = "0xC544A0", VA = "0x180C55CA0")]
	public void NIAHMBOMMFM<TValue>(TKey BAGMDNPKAJL, global::DCBCPMGHAFG<TValue> BBCOFFFEBJD, TimeSpan ELGIPOEILFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x1197360", Offset = "0x1195B60", VA = "0x181197360")]
	public global::DCBCPMGHAFG<TValue> JDNPHAEPOCC<TValue>(TKey BAGMDNPKAJL, Func<global::DCBCPMGHAFG<TValue>> GAPEPJCNNBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1197210", Offset = "0x1195A10", VA = "0x181197210")]
	public global::DCBCPMGHAFG<TValue> JDNPHAEPOCC<TValue>(TKey BAGMDNPKAJL, Func<global::DCBCPMGHAFG<TValue>> GAPEPJCNNBF, TimeSpan ELGIPOEILFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5108170", Offset = "0x5106970", VA = "0x185108170")]
	public bool NHIAFFMKOAF(TKey BAGMDNPKAJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5107780", Offset = "0x5105F80", VA = "0x185107780")]
	public int LLAJDDJPKOB(Predicate<TKey> KCGBAGCENOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5106B20", Offset = "0x5105320", VA = "0x185106B20")]
	public void IDPJIGKEBOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5107320", Offset = "0x5105B20", VA = "0x185107320")]
	private void KILDMNHIOPP(CMFIDIHPEJO EFDICCMNFOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5106870", Offset = "0x5105070", VA = "0x185106870")]
	private void EKAJCAKNLCF(CMFIDIHPEJO EFDICCMNFOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5107C60", Offset = "0x5106460", VA = "0x185107C60")]
	private void LLPKICBBOCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5106CE0", Offset = "0x51054E0", VA = "0x185106CE0")]
	private bool IFIGEHPFONL(CMFIDIHPEJO EFDICCMNFOI)
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
