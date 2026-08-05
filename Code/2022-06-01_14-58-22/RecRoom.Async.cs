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
		private struct FKPAJIECEOI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public string ABDPDPAGECL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public LCANMJCMFMC KJHMDIECKAE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public float? JONKJAGFBFD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public float? OPEDEBCGFFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public IDisposable KCBKAGPNEIE;
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class HIPFPABLLLF : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x587C50", Offset = "0x586650", VA = "0x180587C50")]
			[DebuggerHidden]
			public HIPFPABLLLF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x560B30", Offset = "0x55F530", VA = "0x180560B30", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x4E8B950", Offset = "0x4E8A350", VA = "0x184E8B950", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x4E8BB20", Offset = "0x4E8A520", VA = "0x184E8BB20", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class PFPBAEPJBMD : IEnumerator<object>, IEnumerator, IDisposable
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
			public FLCLHLLPKNN promise;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x587C50", Offset = "0x586650", VA = "0x180587C50")]
			[DebuggerHidden]
			public PFPBAEPJBMD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x560B30", Offset = "0x55F530", VA = "0x180560B30", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x4E8BB70", Offset = "0x4E8A570", VA = "0x184E8BB70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x4E8BBD0", Offset = "0x4E8A5D0", VA = "0x184E8BBD0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private List<FKPAJIECEOI> EFNJDPNMAJK;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool LBBAFOKHDHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x587EB0", Offset = "0x5868B0", VA = "0x180587EB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x6462A0", Offset = "0x644CA0", VA = "0x1806462A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x4E8B7E0", Offset = "0x4E8A1E0", VA = "0x184E8B7E0")]
		public static AsyncBatch Create(Transform MMEAACHMALE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x4E8B870", Offset = "0x4E8A270", VA = "0x184E8B870")]
		[IteratorStateMachine(typeof(HIPFPABLLLF))]
		private IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x4E8B470", Offset = "0x4E89E70", VA = "0x184E8B470")]
		public void Add(string JMIBJFINBJD, LCANMJCMFMC NFMNDONCHFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4E8B590", Offset = "0x4E89F90", VA = "0x184E8B590")]
		public void Add(string JMIBJFINBJD, IEnumerator CGKBPDEICKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4E8B750", Offset = "0x4E8A150", VA = "0x184E8B750")]
		[IteratorStateMachine(typeof(PFPBAEPJBMD))]
		private IEnumerator CKCBAKIIFKO(FLCLHLLPKNN NFMNDONCHFK, IEnumerator CGKBPDEICKH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4E8B8E0", Offset = "0x4E8A2E0", VA = "0x184E8B8E0")]
		public AsyncBatch()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class NNECKLFOIPF<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class PKFPLBPPFLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TKey OBDCJIABNIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public LCANMJCMFMC KJHMDIECKAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public DateTime LLDCMBJIMHK;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x17067C0", Offset = "0x17051C0", VA = "0x1817067C0")]
		public PKFPLBPPFLM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class HKJHJNODKMC<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public global::NNECKLFOIPF<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public TKey key;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x17067C0", Offset = "0x17051C0", VA = "0x1817067C0")]
		public HKJHJNODKMC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class OCMNNCLPLFC<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public PKFPLBPPFLM cacheEntry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public HKJHJNODKMC<TValue> CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x17067C0", Offset = "0x17051C0", VA = "0x1817067C0")]
		public OCMNNCLPLFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2E0D960", Offset = "0x2E0C360", VA = "0x182E0D960")]
		internal void <SetPromise>b__0(string e)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<TKey, PKFPLBPPFLM> GIJBCGBNLPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private LinkedList<PKFPLBPPFLM> ONILCJCMEHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private LinkedList<PKFPLBPPFLM> EIBAPDCKGBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int JEBNEKKAILL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool GGBCJAGJDJD;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public ICollection<TKey> FIMGPPJIOLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2E0C3C0", Offset = "0x2E0ADC0", VA = "0x182E0C3C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2E0D6E0", Offset = "0x2E0C0E0", VA = "0x182E0D6E0")]
	public NNECKLFOIPF([Optional] int? JEBNEKKAILL, bool GGBCJAGJDJD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2E0C030", Offset = "0x2E0AA30", VA = "0x182E0C030")]
	public bool DHHOKDEFFJG(TKey IPKOPOLJGIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x29A8990", Offset = "0x29A7390", VA = "0x1829A8990")]
	public global::HJGFLNHHJHD<TValue> JNINIHNGAKC<TValue>(TKey IPKOPOLJGIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3A3C9C0", Offset = "0x3A3B3C0", VA = "0x183A3C9C0")]
	public void LGLLPEPAAFA<TValue>(TKey IPKOPOLJGIA, TValue HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3A3D180", Offset = "0x3A3BB80", VA = "0x183A3D180")]
	public void MFCJOLPEHNI<TValue>(TKey IPKOPOLJGIA, global::HJGFLNHHJHD<TValue> NFMNDONCHFK, TimeSpan JBBIFCKCMAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x29A9060", Offset = "0x29A7A60", VA = "0x1829A9060")]
	public global::HJGFLNHHJHD<TValue> NNMDHKCPCEM<TValue>(TKey IPKOPOLJGIA, Func<global::HJGFLNHHJHD<TValue>> MADHDHJLENP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x29A8F20", Offset = "0x29A7920", VA = "0x1829A8F20")]
	public global::HJGFLNHHJHD<TValue> NNMDHKCPCEM<TValue>(TKey IPKOPOLJGIA, Func<global::HJGFLNHHJHD<TValue>> MADHDHJLENP, TimeSpan JBBIFCKCMAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2E0BFB0", Offset = "0x2E0A9B0", VA = "0x182E0BFB0")]
	public bool DFDJPGANONL(TKey IPKOPOLJGIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2E0C3F0", Offset = "0x2E0ADF0", VA = "0x182E0C3F0")]
	public int FFEHNBFGLLA(Predicate<TKey> CGPELKGLDPM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2E0C8D0", Offset = "0x2E0B2D0", VA = "0x182E0C8D0")]
	public void KOBBDDIILEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2E0CDB0", Offset = "0x2E0B7B0", VA = "0x182E0CDB0")]
	private void NCNJLNEIMGA(PKFPLBPPFLM HLAAHLMNEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2E0D250", Offset = "0x2E0BC50", VA = "0x182E0D250")]
	private void NGDKIDPIGKI(PKFPLBPPFLM HLAAHLMNEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2E0C060", Offset = "0x2E0AA60", VA = "0x182E0C060")]
	private void EAHMOBGIMAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2E0CA90", Offset = "0x2E0B490", VA = "0x182E0CA90")]
	private bool MCLBINMADNH(PKFPLBPPFLM HLAAHLMNEHK)
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
