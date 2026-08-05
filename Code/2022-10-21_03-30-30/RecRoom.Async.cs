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
				[Cpp2IlInjected.Address(RVA = "0x657030", Offset = "0x655E30", VA = "0x180657030", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x657030", Offset = "0x655E30", VA = "0x180657030", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6C8920", Offset = "0x6C7720", VA = "0x1806C8920")]
			[DebuggerHidden]
			public OGKAPEAOPOK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x5E98F10", Offset = "0x5E97D10", VA = "0x185E98F10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x5E99110", Offset = "0x5E97F10", VA = "0x185E99110", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0x657030", Offset = "0x655E30", VA = "0x180657030", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x657030", Offset = "0x655E30", VA = "0x180657030", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6C8920", Offset = "0x6C7720", VA = "0x1806C8920")]
			[DebuggerHidden]
			public BACGJBBBMKO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x5E98E70", Offset = "0x5E97C70", VA = "0x185E98E70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x5E98ED0", Offset = "0x5E97CD0", VA = "0x185E98ED0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x65BD70", Offset = "0x65AB70", VA = "0x18065BD70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x7B1470", Offset = "0x7B0270", VA = "0x1807B1470")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5E98C40", Offset = "0x5E97A40", VA = "0x185E98C40")]
		public static AsyncBatch Create(Transform ADECAOLBLPJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5E98D80", Offset = "0x5E97B80", VA = "0x185E98D80")]
		[IteratorStateMachine(typeof(OGKAPEAOPOK))]
		private IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5E98B10", Offset = "0x5E97910", VA = "0x185E98B10")]
		public void Add(string BEMAPDNKPAD, NPIGAOPELEF ENCJCIACFFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5E98940", Offset = "0x5E97740", VA = "0x185E98940")]
		public void Add(string BEMAPDNKPAD, IEnumerator MKIPBFOPDPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5E98CF0", Offset = "0x5E97AF0", VA = "0x185E98CF0")]
		[IteratorStateMachine(typeof(BACGJBBBMKO))]
		private IEnumerator DGAMLBLCGAO(ENDBBJEPCAJ ENCJCIACFFP, IEnumerator MKIPBFOPDPG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5E98DF0", Offset = "0x5E97BF0", VA = "0x185E98DF0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD5A370", Offset = "0xD59170", VA = "0x180D5A370")]
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
		[Cpp2IlInjected.Address(RVA = "0xD5A370", Offset = "0xD59170", VA = "0x180D5A370")]
		public HLAFDIJIGGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2BDAC10", Offset = "0x2BD9A10", VA = "0x182BDAC10")]
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
		[Cpp2IlInjected.Address(RVA = "0x1E85540", Offset = "0x1E84340", VA = "0x181E85540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3504770", Offset = "0x3503570", VA = "0x183504770")]
	public PLKOKNCFGBG([Optional] int? OJPKNKGHGPB, bool ONIEBMAMFPC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x252FB10", Offset = "0x252E910", VA = "0x18252FB10")]
	public bool GAOLFNHFINJ(TKey CCJNKBLKLDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x13D4980", Offset = "0x13D3780", VA = "0x1813D4980")]
	public global::DGCAEBAFOOK<TValue> PGLBMIDIGBP<TValue>(TKey CCJNKBLKLDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x13D4320", Offset = "0x13D3120", VA = "0x1813D4320")]
	public void OOGPKFNOLPA<TValue>(TKey CCJNKBLKLDJ, TValue IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x26BC790", Offset = "0x26BB590", VA = "0x1826BC790")]
	public void AEJENJMKOHD<TValue>(TKey CCJNKBLKLDJ, global::DGCAEBAFOOK<TValue> ENCJCIACFFP, TimeSpan EGJMEADJJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x13D4270", Offset = "0x13D3070", VA = "0x1813D4270")]
	public global::DGCAEBAFOOK<TValue> LJOACDNECPE<TValue>(TKey CCJNKBLKLDJ, Func<global::DGCAEBAFOOK<TValue>> DKCAHNIHIOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x13D41D0", Offset = "0x13D2FD0", VA = "0x1813D41D0")]
	public global::DGCAEBAFOOK<TValue> LJOACDNECPE<TValue>(TKey CCJNKBLKLDJ, Func<global::DGCAEBAFOOK<TValue>> DKCAHNIHIOB, TimeSpan EGJMEADJJFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3502560", Offset = "0x3501360", VA = "0x183502560")]
	public bool AKJLIPOIGHF(TKey CCJNKBLKLDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3503F10", Offset = "0x3502D10", VA = "0x183503F10")]
	public int PLJGJCHOOLO(Predicate<TKey> ADBPGLEFIDG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x35033C0", Offset = "0x35021C0", VA = "0x1835033C0")]
	public void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x35025E0", Offset = "0x35013E0", VA = "0x1835025E0")]
	private void BLDGAODAAIJ(MLAHNEBOBCN NJLMIMMKHOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3502BB0", Offset = "0x35019B0", VA = "0x183502BB0")]
	private void FPFHBLOMFNB(MLAHNEBOBCN NJLMIMMKHOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x35037B0", Offset = "0x35025B0", VA = "0x1835037B0")]
	private void MAHBOJGBLKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3503A90", Offset = "0x3502890", VA = "0x183503A90")]
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
