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
		private struct ABKDFCFDCHD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public string AKILJOLADBH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public EEBBFEJKFOP PIDNIIEOHDL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public float? GNKFNCJGECL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public float? JIIAAJAMJPP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public IDisposable ICJLNPACIIK;
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class OAKCKNLFMIC : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x66D0C0", Offset = "0x66C4C0", VA = "0x18066D0C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x66D0C0", Offset = "0x66C4C0", VA = "0x18066D0C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x671200", Offset = "0x670600", VA = "0x180671200")]
			[DebuggerHidden]
			public OAKCKNLFMIC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x600D990", Offset = "0x600CD90", VA = "0x18600D990", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x600DB90", Offset = "0x600CF90", VA = "0x18600DB90", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class FJLNMJALCIJ : IEnumerator<object>, IEnumerator, IDisposable
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
			public ONOPCBLOPNP promise;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x66D0C0", Offset = "0x66C4C0", VA = "0x18066D0C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x66D0C0", Offset = "0x66C4C0", VA = "0x18066D0C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x671200", Offset = "0x670600", VA = "0x180671200")]
			[DebuggerHidden]
			public FJLNMJALCIJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x600D8F0", Offset = "0x600CCF0", VA = "0x18600D8F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x600D950", Offset = "0x600CD50", VA = "0x18600D950", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private List<ABKDFCFDCHD> GGPDIMBDMMH;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool ENFHMMFAACB
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x6883D0", Offset = "0x6877D0", VA = "0x1806883D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x779640", Offset = "0x778A40", VA = "0x180779640")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x600D6C0", Offset = "0x600CAC0", VA = "0x18600D6C0")]
		public static AsyncBatch Create(Transform BLENCGKHIJI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x600D800", Offset = "0x600CC00", VA = "0x18600D800")]
		[IteratorStateMachine(typeof(OAKCKNLFMIC))]
		private IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x600D590", Offset = "0x600C990", VA = "0x18600D590")]
		public void Add(string JODEBEIHAPC, EEBBFEJKFOP BCHMFIOFJEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x600D3C0", Offset = "0x600C7C0", VA = "0x18600D3C0")]
		public void Add(string JODEBEIHAPC, IEnumerator BNIMJKHGBGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x600D770", Offset = "0x600CB70", VA = "0x18600D770")]
		[IteratorStateMachine(typeof(FJLNMJALCIJ))]
		private IEnumerator HANAGDHJAGC(ONOPCBLOPNP BCHMFIOFJEC, IEnumerator BNIMJKHGBGF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x600D870", Offset = "0x600CC70", VA = "0x18600D870")]
		public AsyncBatch()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class ICLCBMEAAAG<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class PNHLAHGKHEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TKey CPJKOGHACEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public EEBBFEJKFOP PIDNIIEOHDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public DateTime IIEMGCLIMBK;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x111EA00", Offset = "0x111DE00", VA = "0x18111EA00")]
		public PNHLAHGKHEG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class KJNEHMJFGCH<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public global::ICLCBMEAAAG<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public PNHLAHGKHEG cacheEntry;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x111EA00", Offset = "0x111DE00", VA = "0x18111EA00")]
		public KJNEHMJFGCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3738520", Offset = "0x3737920", VA = "0x183738520")]
		internal void <SetPromise>b__0(string e)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<TKey, PNHLAHGKHEG> PELJFJMLMGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private LinkedList<PNHLAHGKHEG> JEGCINDJIBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private LinkedList<PNHLAHGKHEG> BBPHGOOOFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int OCOIHDKBHOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool KINCDNJEFKD;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public ICollection<TKey> JIGODMPOCBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1410320", Offset = "0x140F720", VA = "0x181410320")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5174F20", Offset = "0x5174320", VA = "0x185174F20")]
	public ICLCBMEAAAG([Optional] int? OCOIHDKBHOK, bool KINCDNJEFKD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1410AE0", Offset = "0x140FEE0", VA = "0x181410AE0")]
	public bool KMDCFNOHDOO(TKey MPIADBGKNBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3B68E60", Offset = "0x3B68260", VA = "0x183B68E60")]
	public global::BHPNOFOGFAO<TValue> OLGAOJAEPBO<TValue>(TKey MPIADBGKNBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3B67E30", Offset = "0x3B67230", VA = "0x183B67E30")]
	public void BBOCDHNDFJI<TValue>(TKey MPIADBGKNBD, TValue PKODKJLGOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3B68B40", Offset = "0x3B67F40", VA = "0x183B68B40")]
	public void KPKGDKOICAO<TValue>(TKey MPIADBGKNBD, global::BHPNOFOGFAO<TValue> BCHMFIOFJEC, TimeSpan ADOAFKJMAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3B67FC0", Offset = "0x3B673C0", VA = "0x183B67FC0")]
	public global::BHPNOFOGFAO<TValue> JHDNCBGHBNG<TValue>(TKey MPIADBGKNBD, Func<global::BHPNOFOGFAO<TValue>> GGBEJDKPFMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3B68070", Offset = "0x3B67470", VA = "0x183B68070")]
	public global::BHPNOFOGFAO<TValue> JHDNCBGHBNG<TValue>(TKey MPIADBGKNBD, Func<global::BHPNOFOGFAO<TValue>> GGBEJDKPFMO, TimeSpan ADOAFKJMAOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x14109D0", Offset = "0x140FDD0", VA = "0x1814109D0")]
	public bool GMLJNDAKNDK(TKey MPIADBGKNBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5173DB0", Offset = "0x51731B0", VA = "0x185173DB0")]
	public int AEMHLDLFBJN(Predicate<TKey> PEABICLHBDB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x1410A50", Offset = "0x140FE50", VA = "0x181410A50")]
	public void HLOEIBCGJID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5173BC0", Offset = "0x5172FC0", VA = "0x185173BC0")]
	private void AAMDFJJPMNO(PNHLAHGKHEG CMAEAIILIMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5174550", Offset = "0x5173950", VA = "0x185174550")]
	private void FFOGFEMNEBL(PNHLAHGKHEG CMAEAIILIMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x51741F0", Offset = "0x51735F0", VA = "0x1851741F0")]
	private void EMBDFCCGDFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5174BE0", Offset = "0x5173FE0", VA = "0x185174BE0")]
	private bool MBOFMNGIGDO(PNHLAHGKHEG CMAEAIILIMD)
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
