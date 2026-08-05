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
		private struct JPPOELBGMFL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public string CKOMIBKPPBC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public NPIGAOPELEF NHIMCFLACOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public float? KKNCKAMNHMA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public float? LBNNDJMGBEO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public IDisposable HEIENDHFHLA;
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class OGKAPEAOPOK : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x655EC0", VA = "0x1806570C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x655EC0", VA = "0x1806570C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x65B200", Offset = "0x65A000", VA = "0x18065B200")]
			[DebuggerHidden]
			public OGKAPEAOPOK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x5E99970", Offset = "0x5E98770", VA = "0x185E99970", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x5E99B70", Offset = "0x5E98970", VA = "0x185E99B70", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class BACGJBBBMKO : IEnumerator<object>, IEnumerator, IDisposable
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
			public ENDBBJEPCAJ promise;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x655EC0", VA = "0x1806570C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x655EC0", VA = "0x1806570C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x65B200", Offset = "0x65A000", VA = "0x18065B200")]
			[DebuggerHidden]
			public BACGJBBBMKO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x5E998D0", Offset = "0x5E986D0", VA = "0x185E998D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x5E99930", Offset = "0x5E98730", VA = "0x185E99930", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private List<JPPOELBGMFL> DFPPHBILMLA;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool MAFLJCDFJLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x6723D0", Offset = "0x6711D0", VA = "0x1806723D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x8DC1D0", Offset = "0x8DAFD0", VA = "0x1808DC1D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5E996A0", Offset = "0x5E984A0", VA = "0x185E996A0")]
		public static AsyncBatch Create(Transform ADECAOLBLPJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5E997E0", Offset = "0x5E985E0", VA = "0x185E997E0")]
		[IteratorStateMachine(typeof(OGKAPEAOPOK))]
		private IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5E99570", Offset = "0x5E98370", VA = "0x185E99570")]
		public void Add(string BEMAPDNKPAD, NPIGAOPELEF ENCJCIACFFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5E993A0", Offset = "0x5E981A0", VA = "0x185E993A0")]
		public void Add(string BEMAPDNKPAD, IEnumerator MKIPBFOPDPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5E99750", Offset = "0x5E98550", VA = "0x185E99750")]
		[IteratorStateMachine(typeof(BACGJBBBMKO))]
		private IEnumerator DGAMLBLCGAO(ENDBBJEPCAJ ENCJCIACFFP, IEnumerator MKIPBFOPDPG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5E99850", Offset = "0x5E98650", VA = "0x185E99850")]
		public AsyncBatch()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class PLKOKNCFGBG<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class MLAHNEBOBCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TKey HJHOJEFKDAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public NPIGAOPELEF NHIMCFLACOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public DateTime BGFIAHCEOGG;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xE9C870", Offset = "0xE9B670", VA = "0x180E9C870")]
		public MLAHNEBOBCN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class HLAFDIJIGGG<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public global::PLKOKNCFGBG<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public MLAHNEBOBCN cacheEntry;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xE9C870", Offset = "0xE9B670", VA = "0x180E9C870")]
		public HLAFDIJIGGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2D1C7E0", Offset = "0x2D1B5E0", VA = "0x182D1C7E0")]
		internal void <SetPromise>b__0(string e)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<TKey, MLAHNEBOBCN> BGMEKLANEFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private LinkedList<MLAHNEBOBCN> ODFBGGPCABO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private LinkedList<MLAHNEBOBCN> BJBCOKILAML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int OJPKNKGHGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool ONIEBMAMFPC;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public ICollection<TKey> GNHOOAGJOGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1FC5ED0", Offset = "0x1FC4CD0", VA = "0x181FC5ED0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x35EAF20", Offset = "0x35E9D20", VA = "0x1835EAF20")]
	public PLKOKNCFGBG([Optional] int? OJPKNKGHGPB, bool ONIEBMAMFPC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2670EE0", Offset = "0x266FCE0", VA = "0x182670EE0")]
	public bool GAOLFNHFINJ(TKey CCJNKBLKLDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1515D20", Offset = "0x1514B20", VA = "0x181515D20")]
	public global::DGCAEBAFOOK<TValue> PGLBMIDIGBP<TValue>(TKey CCJNKBLKLDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x15156C0", Offset = "0x15144C0", VA = "0x1815156C0")]
	public void OOGPKFNOLPA<TValue>(TKey CCJNKBLKLDJ, TValue IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x27FDB70", Offset = "0x27FC970", VA = "0x1827FDB70")]
	public void AEJENJMKOHD<TValue>(TKey CCJNKBLKLDJ, global::DGCAEBAFOOK<TValue> ENCJCIACFFP, TimeSpan EGJMEADJJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x1515610", Offset = "0x1514410", VA = "0x181515610")]
	public global::DGCAEBAFOOK<TValue> LJOACDNECPE<TValue>(TKey CCJNKBLKLDJ, Func<global::DGCAEBAFOOK<TValue>> DKCAHNIHIOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1515570", Offset = "0x1514370", VA = "0x181515570")]
	public global::DGCAEBAFOOK<TValue> LJOACDNECPE<TValue>(TKey CCJNKBLKLDJ, Func<global::DGCAEBAFOOK<TValue>> DKCAHNIHIOB, TimeSpan EGJMEADJJFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x35E8D10", Offset = "0x35E7B10", VA = "0x1835E8D10")]
	public bool AKJLIPOIGHF(TKey CCJNKBLKLDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x35EA6C0", Offset = "0x35E94C0", VA = "0x1835EA6C0")]
	public int PLJGJCHOOLO(Predicate<TKey> ADBPGLEFIDG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x35E9B70", Offset = "0x35E8970", VA = "0x1835E9B70")]
	public void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x35E8D90", Offset = "0x35E7B90", VA = "0x1835E8D90")]
	private void BLDGAODAAIJ(MLAHNEBOBCN NJLMIMMKHOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x35E9360", Offset = "0x35E8160", VA = "0x1835E9360")]
	private void FPFHBLOMFNB(MLAHNEBOBCN NJLMIMMKHOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x35E9F60", Offset = "0x35E8D60", VA = "0x1835E9F60")]
	private void MAHBOJGBLKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x35EA240", Offset = "0x35E9040", VA = "0x1835EA240")]
	private bool MFBMFBNDKKA(MLAHNEBOBCN NJLMIMMKHOC)
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
