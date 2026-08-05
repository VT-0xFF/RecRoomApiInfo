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
		[Cpp2IlInjected.Address(RVA = "0x7E5080", Offset = "0x7E4280", VA = "0x1807E5080")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6F75ED0", Offset = "0x6F750D0", VA = "0x186F75ED0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7E3190", Offset = "0x7E2390", VA = "0x1807E3190")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x17C7540", Offset = "0x17C6740", VA = "0x1817C7540")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class NGFDKIEAACC<TKey> where TKey : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private class AFLKPPDFEEG
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public TKey GJDAAKMEFBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x7E2180", Offset = "0x7E1380", VA = "0x1807E2180")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public GIOBGNHJLID CHJHKAOFFND
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public DateTime NJGEIKJGAED
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x7EBAE0", Offset = "0x7EACE0", VA = "0x1807EBAE0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x28EB1A0", Offset = "0x28EA3A0", VA = "0x1828EB1A0")]
		public AFLKPPDFEEG(TKey JCEGKCPOPDM, GIOBGNHJLID HBNJPDHFEKF, DateTime OLFJKJPCIOO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class HDLFFONLGFN<TValue> where TValue : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public NGFDKIEAACC<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TKey key;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
		public HDLFFONLGFN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class OLKJGLFNPKE<TValue> where TValue : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public AFLKPPDFEEG cacheEntry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public HDLFFONLGFN<TValue> CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
		public OLKJGLFNPKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x202D120", Offset = "0x202C320", VA = "0x18202D120")]
		internal void BIOGIPEKICG(string e)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x72AF60", Offset = "0x72A360")]
	private Dictionary<TKey, NGFDKIEAACC<TKey>.AFLKPPDFEEG> LAJNGMGNGED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x72AFC0", Offset = "0x72A3C0")]
	private LinkedList<NGFDKIEAACC<TKey>.AFLKPPDFEEG> MOJPGJHMEJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x72B020", Offset = "0x72A420")]
	private LinkedList<NGFDKIEAACC<TKey>.AFLKPPDFEEG> DDOCDPFMJLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private int CGHPPEJDFON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private bool DGDCMMFDEOM;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2C9AC10", Offset = "0x2C99E10", VA = "0x182C9AC10")]
	public NGFDKIEAACC([Optional] int? CGHPPEJDFON, bool DGDCMMFDEOM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2C99770", Offset = "0x2C98970", VA = "0x182C99770")]
	public bool HEOJACEGBJG(TKey JCEGKCPOPDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2371D40", Offset = "0x2370F40", VA = "0x182371D40")]
	public OOMFLHAHLDK<TValue> CPPJIAIBMNC<TValue>(TKey JCEGKCPOPDM) where TValue : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2372340", Offset = "0x2371540", VA = "0x182372340")]
	public void HJFEACFKPKA<TValue>(TKey JCEGKCPOPDM, TValue NABCGCEIEGG) where TValue : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2371640", Offset = "0x2370840", VA = "0x182371640")]
	public void CMIMIKCPDDK<TValue>(TKey JCEGKCPOPDM, OOMFLHAHLDK<TValue> HBNJPDHFEKF, TimeSpan KGHBIMEEICB) where TValue : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2372620", Offset = "0x2371820", VA = "0x182372620")]
	public OOMFLHAHLDK<TValue> LNBMBIMDHAP<TValue>(TKey JCEGKCPOPDM, Func<OOMFLHAHLDK<TValue>> JBJDGHADNHP) where TValue : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2372430", Offset = "0x2371630", VA = "0x182372430")]
	public OOMFLHAHLDK<TValue> LNBMBIMDHAP<TValue>(TKey JCEGKCPOPDM, Func<OOMFLHAHLDK<TValue>> JBJDGHADNHP, TimeSpan KGHBIMEEICB) where TValue : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2C996F0", Offset = "0x2C988F0", VA = "0x182C996F0")]
	public bool HCICIMHFKFM(TKey JCEGKCPOPDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2C997A0", Offset = "0x2C989A0", VA = "0x182C997A0")]
	public void HNOBOGMOMNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2C9A3B0", Offset = "0x2C995B0", VA = "0x182C9A3B0")]
	private void LOAGDFAODGH([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x72B080", Offset = "0x72A480")] NGFDKIEAACC<TKey>.AFLKPPDFEEG PFPDDIBMOFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2C99E70", Offset = "0x2C99070", VA = "0x182C99E70")]
	private void LFOCKLKADHA([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x72B0E0", Offset = "0x72A4E0")] NGFDKIEAACC<TKey>.AFLKPPDFEEG PFPDDIBMOFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2C99310", Offset = "0x2C98510", VA = "0x182C99310")]
	private void BEPHHNAKJJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2C98FC0", Offset = "0x2C981C0", VA = "0x182C98FC0")]
	private bool AMNMAGNADMF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x72B140", Offset = "0x72A540")] NGFDKIEAACC<TKey>.AFLKPPDFEEG PFPDDIBMOFD)
	{
		return default(bool);
	}
}
namespace RecRoom.Async
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class AsyncBatch : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private struct BLJLIBHJDPD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public string GCLEOCLMMPM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public GIOBGNHJLID CHJHKAOFFND;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public float? LNJDOFABEHJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public float? FMLJAEBIAMK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public IDisposable HNDLIIOPPDH;
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class PCHOKGNOLBE : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncBatch <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private bool <allCompleted>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private int <i>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private BLJLIBHJDPD <operation>5__3;

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000026")]
				[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xA0AFF0", Offset = "0xA0A1F0", VA = "0x180A0AFF0")]
			[DebuggerHidden]
			public PCHOKGNOLBE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6F75F60", Offset = "0x6F75160", VA = "0x186F75F60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6F76170", Offset = "0x6F75370", VA = "0x186F76170", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class AJEOBOCIPDO : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public MGJKNPFOJOG promise;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public IEnumerator coroutine;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public AsyncBatch <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xA0AFF0", Offset = "0xA0A1F0", VA = "0x180A0AFF0")]
			[DebuggerHidden]
			public AJEOBOCIPDO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6F758E0", Offset = "0x6F74AE0", VA = "0x186F758E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6F75940", Offset = "0x6F74B40", VA = "0x186F75940", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private List<BLJLIBHJDPD> OCMLJFPDDNB;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool JAPNBMCGLHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x94E3A0", Offset = "0x94D5A0", VA = "0x18094E3A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8D38A0", Offset = "0x8D2AA0", VA = "0x1808D38A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6F75C90", Offset = "0x6F74E90", VA = "0x186F75C90")]
		public static AsyncBatch Create(Transform OJEMCPHOKBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6F75DE0", Offset = "0x6F74FE0", VA = "0x186F75DE0")]
		[IteratorStateMachine(typeof(PCHOKGNOLBE))]
		private IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6F75B60", Offset = "0x6F74D60", VA = "0x186F75B60")]
		public void Add(string JPKENOAMLIN, GIOBGNHJLID HBNJPDHFEKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6F75980", Offset = "0x6F74B80", VA = "0x186F75980")]
		public void Add(string JPKENOAMLIN, IEnumerator PBOBEIBCONO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6F75D40", Offset = "0x6F74F40", VA = "0x186F75D40")]
		[IteratorStateMachine(typeof(AJEOBOCIPDO))]
		private IEnumerator GOAPCMANOIP(MGJKNPFOJOG HBNJPDHFEKF, IEnumerator PBOBEIBCONO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6F75E50", Offset = "0x6F75050", VA = "0x186F75E50")]
		public AsyncBatch()
		{
		}
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
