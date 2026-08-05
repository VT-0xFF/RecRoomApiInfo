using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7DC8BA0", Offset = "0x7DC73A0", VA = "0x187DC8BA0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA536D0", Offset = "0xA51ED0", VA = "0x180A536D0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA53710", Offset = "0xA51F10", VA = "0x180A53710")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.Async
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class AsyncBatch : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private struct LFOINPPFBAG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public string NCBGIDALPJM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public FKGMEHDMFDF JDJNKKPPELF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public float? JLAOLBCBCOG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public float? GOJDDCAGPAN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public IDisposable KOCFCMKCJDO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class GHOOOLLIFNJ : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public AsyncBatch <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xA2B740", Offset = "0xA29F40", VA = "0x180A2B740")]
			[DebuggerHidden]
			public GHOOOLLIFNJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x7DC8820", Offset = "0x7DC7020", VA = "0x187DC8820", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x7DC89F0", Offset = "0x7DC71F0", VA = "0x187DC89F0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class BDLIEKOBKIH : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public IEnumerator coroutine;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public JEFMKEBHJKM promise;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000016")]
				[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000018")]
				[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xA2B740", Offset = "0xA29F40", VA = "0x180A2B740")]
			[DebuggerHidden]
			public BDLIEKOBKIH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x7DC85E0", Offset = "0x7DC6DE0", VA = "0x187DC85E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x7DC8650", Offset = "0x7DC6E50", VA = "0x187DC8650", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private List<LFOINPPFBAG> BNBKFEMLAGI;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool KLEBMFMNBBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xA2D4D0", Offset = "0xA2BCD0", VA = "0x180A2D4D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA2D370", Offset = "0xA2BB70", VA = "0x180A2D370")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7DC8390", Offset = "0x7DC6B90", VA = "0x187DC8390")]
		public static AsyncBatch Create(Transform MJNLMOPPION)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7DC84D0", Offset = "0x7DC6CD0", VA = "0x187DC84D0")]
		[IteratorStateMachine(typeof(GHOOOLLIFNJ))]
		private IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7DC81E0", Offset = "0x7DC69E0", VA = "0x187DC81E0")]
		public void Add(string HPANEBBHGAC, FKGMEHDMFDF BHNDIAAKONA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7DC7F70", Offset = "0x7DC6770", VA = "0x187DC7F70")]
		public void Add(string HPANEBBHGAC, IEnumerator KMJPONBGMIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7DC8440", Offset = "0x7DC6C40", VA = "0x187DC8440")]
		[IteratorStateMachine(typeof(BDLIEKOBKIH))]
		private IEnumerator JNMOHBLLPLP(JEFMKEBHJKM BHNDIAAKONA, IEnumerator KMJPONBGMIA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7DC8550", Offset = "0x7DC6D50", VA = "0x187DC8550")]
		public AsyncBatch()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class BBKLFKKJJBI<TKey> where TKey : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private class DNLMKPIBMCE
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public TKey IIACIMCDNIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xA271A0", Offset = "0xA259A0", VA = "0x180A271A0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public FKGMEHDMFDF JDJNKKPPELF
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public DateTime BIHMMALJMGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1289780", Offset = "0x1287F80", VA = "0x181289780")]
		public DNLMKPIBMCE(TKey MNMCNOJCKAF, FKGMEHDMFDF BHNDIAAKONA, DateTime HPAEDNOGLNI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class BHFNLODJMPA<TValue> where TValue : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public BBKLFKKJJBI<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public DNLMKPIBMCE cacheEntry;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public BHFNLODJMPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x616F5E0", Offset = "0x616DDE0", VA = "0x18616F5E0")]
		internal void FKJHFOEHJIN(string e)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private Dictionary<TKey, DNLMKPIBMCE> LPHLJKPCIAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private LinkedList<DNLMKPIBMCE> EGCFBALMDCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private LinkedList<DNLMKPIBMCE> EBJEACBLHJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private int GLENNJLAHMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool JEJCANIOHHL;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x613E280", Offset = "0x613CA80", VA = "0x18613E280")]
	public BBKLFKKJJBI([Optional] int? GLENNJLAHMI, bool JEJCANIOHHL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3ADC3F0", Offset = "0x3ADABF0", VA = "0x183ADC3F0")]
	public BFIFKPBFBML<TValue> DLINPGLBMPI<TValue>(TKey MNMCNOJCKAF) where TValue : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3BD3960", Offset = "0x3BD2160", VA = "0x183BD3960")]
	public void OPPOCICHDNC<TValue>(TKey MNMCNOJCKAF, BFIFKPBFBML<TValue> BHNDIAAKONA, TimeSpan PNAHGGJAFLM) where TValue : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3BD3440", Offset = "0x3BD1C40", VA = "0x183BD3440")]
	public BFIFKPBFBML<TValue> NEFJHMHLBKO<TValue>(TKey MNMCNOJCKAF, Func<BFIFKPBFBML<TValue>> PLLGEFOEKGB) where TValue : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3ADC650", Offset = "0x3ADAE50", VA = "0x183ADC650")]
	public BFIFKPBFBML<TValue> NEFJHMHLBKO<TValue>(TKey MNMCNOJCKAF, Func<BFIFKPBFBML<TValue>> PLLGEFOEKGB, TimeSpan PNAHGGJAFLM) where TValue : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x613B710", Offset = "0x6139F10", VA = "0x18613B710")]
	public bool HKOLMKDGPPH(TKey MNMCNOJCKAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x613B610", Offset = "0x6139E10", VA = "0x18613B610")]
	public void CGGBONADGHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x613CE20", Offset = "0x613B620", VA = "0x18613CE20")]
	private void KGGBCBCEBNA(DNLMKPIBMCE ICBHJJOHJHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x613BC70", Offset = "0x613A470", VA = "0x18613BC70")]
	private void IIFDADAGHGO(DNLMKPIBMCE ICBHJJOHJHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x613C880", Offset = "0x613B080", VA = "0x18613C880")]
	private void KFFAFLBLJDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x613D9C0", Offset = "0x613C1C0", VA = "0x18613D9C0")]
	private bool OONCLGAMKCJ(DNLMKPIBMCE ICBHJJOHJHJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class NCIFKBOFBAM
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class CEKHKBHFMCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public string errorPrefix;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public LBMIHNICFPI? logFlags;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public CEKHKBHFMCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7DC86A0", Offset = "0x7DC6EA0", VA = "0x187DC86A0")]
		internal void MGKHHBMENKE(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class JPOFHCCPMLG<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public string errorPrefix;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public LBMIHNICFPI? logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public JPOFHCCPMLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x50DE5E0", Offset = "0x50DCDE0", VA = "0x1850DE5E0")]
		internal void MGKHHBMENKE(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7DC8A40", Offset = "0x7DC7240", VA = "0x187DC8A40")]
	public static FKGMEHDMFDF NOAIFLGCPNG(this FKGMEHDMFDF BHNDIAAKONA, string OJOEKJACJMB, [Optional] LBMIHNICFPI? LLHEGEEGDPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3B45790", Offset = "0x3B43F90", VA = "0x183B45790")]
	public static BFIFKPBFBML<T> NOAIFLGCPNG<T>(this BFIFKPBFBML<T> BHNDIAAKONA, string OJOEKJACJMB, [Optional] LBMIHNICFPI? LLHEGEEGDPP)
	{
		return null;
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
