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
		private struct DAIPDKEOIDN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public string JBHHONFDCDB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public CKHAEIDHOPE HLIOBLIGJGO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public float? OLGAACFEFIG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public float? AEPJHFEOICI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public IDisposable OPBOLLOEIOA;
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class BDABMPIBKNA : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x737640", Offset = "0x736240", VA = "0x180737640")]
			[DebuggerHidden]
			public BDABMPIBKNA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x609AD00", Offset = "0x6099900", VA = "0x18609AD00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x609AF00", Offset = "0x6099B00", VA = "0x18609AF00", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class JOOJGBKMFHI : IEnumerator<object>, IEnumerator, IDisposable
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
			public OBDOOKDFCDE promise;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x737640", Offset = "0x736240", VA = "0x180737640")]
			[DebuggerHidden]
			public JOOJGBKMFHI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x609AF40", Offset = "0x6099B40", VA = "0x18609AF40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x609AFA0", Offset = "0x6099BA0", VA = "0x18609AFA0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private List<DAIPDKEOIDN> BLMNKDJEPHH;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool IGNLNPOLLFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x787DD0", Offset = "0x7869D0", VA = "0x180787DD0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x91E870", Offset = "0x91D470", VA = "0x18091E870")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x609AB60", Offset = "0x6099760", VA = "0x18609AB60")]
		public static AsyncBatch Create(Transform NIGFDFKEKGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x609AC10", Offset = "0x6099810", VA = "0x18609AC10")]
		[IteratorStateMachine(typeof(BDABMPIBKNA))]
		private IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x609A7D0", Offset = "0x60993D0", VA = "0x18609A7D0")]
		public void Add(string MKPDFAEIFFO, CKHAEIDHOPE HJIKPPAKAGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x609A900", Offset = "0x6099500", VA = "0x18609A900")]
		public void Add(string MKPDFAEIFFO, IEnumerator MGADLCLJIEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x609AAD0", Offset = "0x60996D0", VA = "0x18609AAD0")]
		[IteratorStateMachine(typeof(JOOJGBKMFHI))]
		private IEnumerator BBOEGOAPKEB(OBDOOKDFCDE HJIKPPAKAGC, IEnumerator MGADLCLJIEF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x609AC80", Offset = "0x6099880", VA = "0x18609AC80")]
		public AsyncBatch()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class LDJIEGIDCKH<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class IELGIJCAPDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TKey OAGIAGFOKAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public CKHAEIDHOPE HLIOBLIGJGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public DateTime EFJDANHGOCC;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1C2A480", Offset = "0x1C29080", VA = "0x181C2A480")]
		public IELGIJCAPDJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class NDEDCIKCDCK<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public global::LDJIEGIDCKH<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public IELGIJCAPDJ cacheEntry;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1C2A480", Offset = "0x1C29080", VA = "0x181C2A480")]
		public NDEDCIKCDCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2FE4240", Offset = "0x2FE2E40", VA = "0x182FE4240")]
		internal void <SetPromise>b__0(string e)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<TKey, IELGIJCAPDJ> OKMBJHAADLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private LinkedList<IELGIJCAPDJ> LBAAPINNAPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private LinkedList<IELGIJCAPDJ> OHDDEIAPJNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int CJHNPEFMOGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool FJHKKJGHBBO;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public ICollection<TKey> ECDFCCCLKDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2C3E7B0", Offset = "0x2C3D3B0", VA = "0x182C3E7B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2C40150", Offset = "0x2C3ED50", VA = "0x182C40150")]
	public LDJIEGIDCKH([Optional] int? CJHNPEFMOGJ, bool FJHKKJGHBBO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2C3DEE0", Offset = "0x2C3CAE0", VA = "0x182C3DEE0")]
	public bool BLBCENAIAJB(TKey NANBEBOOGPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2A4D3A0", Offset = "0x2A4BFA0", VA = "0x182A4D3A0")]
	public global::GANDAICPPHN<TValue> OPKKOBNJGEC<TValue>(TKey NANBEBOOGPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2A4B670", Offset = "0x2A4A270", VA = "0x182A4B670")]
	public void IALGHGAGPAB<TValue>(TKey NANBEBOOGPM, TValue NENFOEKGNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2A4C420", Offset = "0x2A4B020", VA = "0x182A4C420")]
	public void NEBDOIICKDL<TValue>(TKey NANBEBOOGPM, global::GANDAICPPHN<TValue> HJIKPPAKAGC, TimeSpan FOKJJKEGNLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2A4B520", Offset = "0x2A4A120", VA = "0x182A4B520")]
	public global::GANDAICPPHN<TValue> GJEIALFNKKF<TValue>(TKey NANBEBOOGPM, Func<global::GANDAICPPHN<TValue>> DCIDDDEJJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2A4B5D0", Offset = "0x2A4A1D0", VA = "0x182A4B5D0")]
	public global::GANDAICPPHN<TValue> GJEIALFNKKF<TValue>(TKey NANBEBOOGPM, Func<global::GANDAICPPHN<TValue>> DCIDDDEJJDL, TimeSpan FOKJJKEGNLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2C3E7E0", Offset = "0x2C3D3E0", VA = "0x182C3E7E0")]
	public bool KFPKFODPJHB(TKey NANBEBOOGPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2C3F030", Offset = "0x2C3DC30", VA = "0x182C3F030")]
	public int KMFBNIHKEHL(Predicate<TKey> FGOJNBAPFGI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2C3E720", Offset = "0x2C3D320", VA = "0x182C3E720")]
	public void GGNFLDPHLOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2C3F250", Offset = "0x2C3DE50", VA = "0x182C3F250")]
	private void PLANHPNAPGB(IELGIJCAPDJ BHBBEEAOJJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2C3E470", Offset = "0x2C3D070", VA = "0x182C3E470")]
	private void GFJOMPPOEBM(IELGIJCAPDJ BHBBEEAOJJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2C3FB80", Offset = "0x2C3E780", VA = "0x182C3FB80")]
	private void PLCKJOGHJGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2C3E860", Offset = "0x2C3D460", VA = "0x182C3E860")]
	private bool KHGPJDJFPEF(IELGIJCAPDJ BHBBEEAOJJN)
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
