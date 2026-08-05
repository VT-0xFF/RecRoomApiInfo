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
		[Cpp2IlInjected.Address(RVA = "0x91C600", Offset = "0x91AC00", VA = "0x18091C600")]
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
		[Cpp2IlInjected.Address(RVA = "0x6FF08C0", Offset = "0x6FEEEC0", VA = "0x186FF08C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x986BA0", Offset = "0x9851A0", VA = "0x180986BA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x11F2200", Offset = "0x11F0800", VA = "0x1811F2200")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class GBGAALHEENI<TKey> where TKey : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private class DMGAMHDADFI
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public TKey GGPPGDHBOOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x7EA1A0", Offset = "0x7E87A0", VA = "0x1807EA1A0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public HHGLIBCDIDA MNBOPLENPCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public DateTime PGIIFCCJPEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8BD370", Offset = "0x8BB970", VA = "0x1808BD370")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x226FBC0", Offset = "0x226E1C0", VA = "0x18226FBC0")]
		public DMGAMHDADFI(TKey BOMEFJIOGGM, HHGLIBCDIDA MOLFCCHMICC, DateTime PFHIEGGFOGB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class MNNCLKKELFE<TValue> where TValue : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public GBGAALHEENI<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TKey key;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
		public MNNCLKKELFE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class EMCDIIJNNLO<TValue> where TValue : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public DMGAMHDADFI cacheEntry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public MNNCLKKELFE<TValue> CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
		public EMCDIIJNNLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x18C6F30", Offset = "0x18C5530", VA = "0x1818C6F30")]
		internal void IMEHPHGDKAL(string e)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x732F40", Offset = "0x732340")]
	private Dictionary<TKey, GBGAALHEENI<TKey>.DMGAMHDADFI> IFBIMPBNLEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x732FA0", Offset = "0x7323A0")]
	private LinkedList<GBGAALHEENI<TKey>.DMGAMHDADFI> FAHBNAJAKHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x733000", Offset = "0x732400")]
	private LinkedList<GBGAALHEENI<TKey>.DMGAMHDADFI> BIEHMEPGNLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private int AJBGCGFHONM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private bool DOCCPMKOCAC;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x24DBE30", Offset = "0x24DA430", VA = "0x1824DBE30")]
	public GBGAALHEENI([Optional] int? AJBGCGFHONM, bool DOCCPMKOCAC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x24DB9E0", Offset = "0x24D9FE0", VA = "0x1824DB9E0")]
	public bool OBFIPCPLDAH(TKey BOMEFJIOGGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1CB0A70", Offset = "0x1CAF070", VA = "0x181CB0A70")]
	public MFBKDKPGMNP<TValue> NCJBNCNAODB<TValue>(TKey BOMEFJIOGGM) where TValue : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1CAF860", Offset = "0x1CADE60", VA = "0x181CAF860")]
	public void ALGMGODHEFB<TValue>(TKey BOMEFJIOGGM, TValue MOLEJFDINLH) where TValue : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1CAFF80", Offset = "0x1CAE580", VA = "0x181CAFF80")]
	public void LCNICHCCAFC<TValue>(TKey BOMEFJIOGGM, MFBKDKPGMNP<TValue> MOLFCCHMICC, TimeSpan JJJFAELONIP) where TValue : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1CAFB40", Offset = "0x1CAE140", VA = "0x181CAFB40")]
	public MFBKDKPGMNP<TValue> HLGMOIHMEIK<TValue>(TKey BOMEFJIOGGM, Func<MFBKDKPGMNP<TValue>> OJDBFLGFKLB) where TValue : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1CAFAA0", Offset = "0x1CAE0A0", VA = "0x181CAFAA0")]
	public MFBKDKPGMNP<TValue> HLGMOIHMEIK<TValue>(TKey BOMEFJIOGGM, Func<MFBKDKPGMNP<TValue>> OJDBFLGFKLB, TimeSpan JJJFAELONIP) where TValue : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x24DA340", Offset = "0x24D8940", VA = "0x1824DA340")]
	public bool EIILGGCBFDG(TKey BOMEFJIOGGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x24DAA20", Offset = "0x24D9020", VA = "0x1824DAA20")]
	public void FBJOPIHCMHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x24DA3C0", Offset = "0x24D89C0", VA = "0x1824DA3C0")]
	private void EJBMAHOKJAC([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x733060", Offset = "0x732460")] GBGAALHEENI<TKey>.DMGAMHDADFI PLFALDDAIKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x24DAAB0", Offset = "0x24D90B0", VA = "0x1824DAAB0")]
	private void FCCCEJJHKIF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7330C0", Offset = "0x7324C0")] GBGAALHEENI<TKey>.DMGAMHDADFI PLFALDDAIKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x24DB7F0", Offset = "0x24D9DF0", VA = "0x1824DB7F0")]
	private void LMOKENGEENI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x24DBB70", Offset = "0x24DA170", VA = "0x1824DBB70")]
	private bool PAFNADCBFFM([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x733120", Offset = "0x732520")] GBGAALHEENI<TKey>.DMGAMHDADFI PLFALDDAIKD)
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
		private struct JIEIHKOMCGP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public string OMBLKOFJABM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public HHGLIBCDIDA MNBOPLENPCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public float? PJHNDHNFMID;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public float? DGOKOEKFNBO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public IDisposable OFCDFGNBKIB;
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class JGOKGAHMKNG : IEnumerator<object>, IEnumerator, IDisposable
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
			private JIEIHKOMCGP <operation>5__3;

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x975A90", Offset = "0x974090", VA = "0x180975A90")]
			[DebuggerHidden]
			public JGOKGAHMKNG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6FF0670", Offset = "0x6FEEC70", VA = "0x186FF0670", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6FF0880", Offset = "0x6FEEE80", VA = "0x186FF0880", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class PNECBEKODBH : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public NOKBHGDKGNF promise;

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
				[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x975A90", Offset = "0x974090", VA = "0x180975A90")]
			[DebuggerHidden]
			public PNECBEKODBH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6FF0950", Offset = "0x6FEEF50", VA = "0x186FF0950", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6FF09B0", Offset = "0x6FEEFB0", VA = "0x186FF09B0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private List<JIEIHKOMCGP> NEKLFJGFHOC;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool PDNJDHBDFON
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x9B4500", Offset = "0x9B2B00", VA = "0x1809B4500")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x9B5480", Offset = "0x9B3A80", VA = "0x1809B5480")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6FF04D0", Offset = "0x6FEEAD0", VA = "0x186FF04D0")]
		public static AsyncBatch Create(Transform HDBBNLFBJKG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6FF0580", Offset = "0x6FEEB80", VA = "0x186FF0580")]
		[IteratorStateMachine(typeof(JGOKGAHMKNG))]
		private IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6FF0300", Offset = "0x6FEE900", VA = "0x186FF0300")]
		public void Add(string ECMAPGHKHFB, HHGLIBCDIDA MOLFCCHMICC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6FF0120", Offset = "0x6FEE720", VA = "0x186FF0120")]
		public void Add(string ECMAPGHKHFB, IEnumerator LODNPFDCPHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6FF0430", Offset = "0x6FEEA30", VA = "0x186FF0430")]
		[IteratorStateMachine(typeof(PNECBEKODBH))]
		private IEnumerator CKEFLEGODHJ(NOKBHGDKGNF MOLFCCHMICC, IEnumerator LODNPFDCPHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6FF05F0", Offset = "0x6FEEBF0", VA = "0x186FF05F0")]
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
