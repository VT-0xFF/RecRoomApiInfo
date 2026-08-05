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
		[Cpp2IlInjected.Address(RVA = "0x7E57E0", Offset = "0x7E49E0", VA = "0x1807E57E0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6008400", Offset = "0x6007600", VA = "0x186008400")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7E5C40", Offset = "0x7E4E40", VA = "0x1807E5C40")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E5C80", Offset = "0x7E4E80", VA = "0x1807E5C80")]
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
		private struct CMNNJJJGNBO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public string IHKMJLPGIHG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public GGFPJCKLNCF FLMDHKGGHAH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public float? PICEEMNMJAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public float? MPFOPNFHKKC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public IDisposable EHIAJIDEPPG;
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class HMFCEPHLBCC : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x7BA3B0", Offset = "0x7B95B0", VA = "0x1807BA3B0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7BA3B0", Offset = "0x7B95B0", VA = "0x1807BA3B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x7BD570", Offset = "0x7BC770", VA = "0x1807BD570")]
			[DebuggerHidden]
			public HMFCEPHLBCC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x60081E0", Offset = "0x60073E0", VA = "0x1860081E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x60083B0", Offset = "0x60075B0", VA = "0x1860083B0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class GMOGNGAGHOC : IEnumerator<object>, IEnumerator, IDisposable
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
			public DBNOMPAFFGP promise;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000016")]
				[Cpp2IlInjected.Address(RVA = "0x7BA3B0", Offset = "0x7B95B0", VA = "0x1807BA3B0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7BA3B0", Offset = "0x7B95B0", VA = "0x1807BA3B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x7BD570", Offset = "0x7BC770", VA = "0x1807BD570")]
			[DebuggerHidden]
			public GMOGNGAGHOC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6008120", Offset = "0x6007320", VA = "0x186008120", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6008190", Offset = "0x6007390", VA = "0x186008190", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private List<CMNNJJJGNBO> ECBBAONDGBG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool MJPGAACCKIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7C1E50", Offset = "0x7C1050", VA = "0x1807C1E50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x7C1CD0", Offset = "0x7C0ED0", VA = "0x1807C1CD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6007D40", Offset = "0x6006F40", VA = "0x186007D40")]
		public static AsyncBatch Create(Transform DMKJLMNBOME)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6007E80", Offset = "0x6007080", VA = "0x186007E80")]
		[IteratorStateMachine(typeof(HMFCEPHLBCC))]
		private IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6007BB0", Offset = "0x6006DB0", VA = "0x186007BB0")]
		public void Add(string NLBAJPAADNH, GGFPJCKLNCF MNFHLJCNMPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6007960", Offset = "0x6006B60", VA = "0x186007960")]
		public void Add(string NLBAJPAADNH, IEnumerator EJIJOBHHPKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6007DF0", Offset = "0x6006FF0", VA = "0x186007DF0")]
		[IteratorStateMachine(typeof(GMOGNGAGHOC))]
		private IEnumerator GGEOPJBOMHA(DBNOMPAFFGP MNFHLJCNMPJ, IEnumerator EJIJOBHHPKN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6007F00", Offset = "0x6007100", VA = "0x186007F00")]
		public AsyncBatch()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class OPMCEIPHDGE<TKey> where TKey : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private class AIMBJLHGPOM
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public TKey OMEPDDHLMOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x7BA180", Offset = "0x7B9380", VA = "0x1807BA180")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public GGFPJCKLNCF FLMDHKGGHAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x7BA3B0", Offset = "0x7B95B0", VA = "0x1807BA3B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public DateTime FFFEMFHHBOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x7BA390", Offset = "0x7B9590", VA = "0x1807BA390")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x37A56E0", Offset = "0x37A48E0", VA = "0x1837A56E0")]
		public AIMBJLHGPOM(TKey HKNPGHOCJDO, GGFPJCKLNCF MNFHLJCNMPJ, DateTime HEKKEAHPPLE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class IEADJJIKEJJ<TValue> where TValue : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public OPMCEIPHDGE<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AIMBJLHGPOM cacheEntry;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		public IEADJJIKEJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3891C20", Offset = "0x3890E20", VA = "0x183891C20")]
		internal void OONKFAILLAG(string e)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private Dictionary<TKey, AIMBJLHGPOM> KKEPCNIADKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private LinkedList<AIMBJLHGPOM> DAMAEKCHEBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private LinkedList<AIMBJLHGPOM> AOELNBNBKLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private int BCNIGPMEBIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool ILHAJFGBKGP;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4097DF0", Offset = "0x4096FF0", VA = "0x184097DF0")]
	public OPMCEIPHDGE([Optional] int? BCNIGPMEBIA, bool ILHAJFGBKGP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x32B1480", Offset = "0x32B0680", VA = "0x1832B1480")]
	public bool IICDBFDNPBK(TKey HKNPGHOCJDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x26B1E20", Offset = "0x26B1020", VA = "0x1826B1E20")]
	public NNPPFIMPNGB<TValue> JJLMKFPAFJD<TValue>(TKey HKNPGHOCJDO) where TValue : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x26B1960", Offset = "0x26B0B60", VA = "0x1826B1960")]
	public void EMIGLMHDFJK<TValue>(TKey HKNPGHOCJDO, TValue AFCGKMGKPEF) where TValue : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x26B28B0", Offset = "0x26B1AB0", VA = "0x1826B28B0")]
	public void MEKABOOEJJN<TValue>(TKey HKNPGHOCJDO, NNPPFIMPNGB<TValue> MNFHLJCNMPJ, TimeSpan IEENOFIOOGK) where TValue : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x26B2030", Offset = "0x26B1230", VA = "0x1826B2030")]
	public NNPPFIMPNGB<TValue> KGEPHNEHMBL<TValue>(TKey HKNPGHOCJDO, Func<NNPPFIMPNGB<TValue>> KPNBCHIKIPJ) where TValue : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x26B2210", Offset = "0x26B1410", VA = "0x1826B2210")]
	public NNPPFIMPNGB<TValue> KGEPHNEHMBL<TValue>(TKey HKNPGHOCJDO, Func<NNPPFIMPNGB<TValue>> KPNBCHIKIPJ, TimeSpan IEENOFIOOGK) where TValue : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4097B20", Offset = "0x4096D20", VA = "0x184097B20")]
	public bool PADFOOPDKDB(TKey HKNPGHOCJDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x40975B0", Offset = "0x40967B0", VA = "0x1840975B0")]
	public void IICCKONGNNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4097330", Offset = "0x4096530", VA = "0x184097330")]
	private void DAGHICBKFDP(AIMBJLHGPOM EICENFFELAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4095B70", Offset = "0x4094D70", VA = "0x184095B70")]
	private void AHHHOGNEFCD(AIMBJLHGPOM EICENFFELAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4096BE0", Offset = "0x4095DE0", VA = "0x184096BE0")]
	private void CJLKMGGIKLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4097980", Offset = "0x4096B80", VA = "0x184097980")]
	private bool OMJKADNKHNF(AIMBJLHGPOM EICENFFELAJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class AAOCJBLGFOA
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class EPEFLKDAONN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public string errorPrefix;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public PNAMPHHGBEO? logFlags;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		public EPEFLKDAONN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6007F90", Offset = "0x6007190", VA = "0x186007F90")]
		internal void KCGKMMFAKKH(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class GCNLPNPCCCP<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public string errorPrefix;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public PNAMPHHGBEO? logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		public GCNLPNPCCCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x372F2B0", Offset = "0x372E4B0", VA = "0x18372F2B0")]
		internal void KCGKMMFAKKH(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6007800", Offset = "0x6006A00", VA = "0x186007800")]
	public static GGFPJCKLNCF KHEIGNJBMMB(this GGFPJCKLNCF MNFHLJCNMPJ, string GKNJKNGMJPJ, [Optional] PNAMPHHGBEO? EPNIELENNJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2D4A880", Offset = "0x2D49A80", VA = "0x182D4A880")]
	public static NNPPFIMPNGB<T> KHEIGNJBMMB<T>(this NNPPFIMPNGB<T> MNFHLJCNMPJ, string GKNJKNGMJPJ, [Optional] PNAMPHHGBEO? EPNIELENNJB)
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
