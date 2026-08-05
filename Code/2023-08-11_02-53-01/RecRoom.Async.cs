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
		[Cpp2IlInjected.Address(RVA = "0x7E01F0", Offset = "0x7DE9F0", VA = "0x1807E01F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F23E10", Offset = "0x6F22610", VA = "0x186F23E10")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7EEC40", Offset = "0x7ED440", VA = "0x1807EEC40")]
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
		[Cpp2IlInjected.Address(RVA = "0xA14660", Offset = "0xA12E60", VA = "0x180A14660")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class NEMFAFDIKPL<TKey> where TKey : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private class PKJEHBKONOJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public TKey ADLHPEIHCMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x7DF240", Offset = "0x7DDA40", VA = "0x1807DF240")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public GHJKEMFHLHG JKKHPKEDPHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public DateTime AEHACKBGHHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x7EC6C0", Offset = "0x7EAEC0", VA = "0x1807EC6C0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x21B4800", Offset = "0x21B3000", VA = "0x1821B4800")]
		public PKJEHBKONOJ(TKey EECINICJCLK, GHJKEMFHLHG IAHNODEPOMP, DateTime JLINPLLDJCO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class OBFJHMFMMMF<TValue> where TValue : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public NEMFAFDIKPL<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TKey key;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
		public OBFJHMFMMMF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class FNNKEKMDICN<TValue> where TValue : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public PKJEHBKONOJ cacheEntry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public OBFJHMFMMMF<TValue> CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
		public FNNKEKMDICN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2240610", Offset = "0x223EE10", VA = "0x182240610")]
		internal void OJLAPPNGLGE(string e)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x727830", Offset = "0x726C30")]
	private Dictionary<TKey, NEMFAFDIKPL<TKey>.PKJEHBKONOJ> LOEBLGMOKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x727890", Offset = "0x726C90")]
	private LinkedList<NEMFAFDIKPL<TKey>.PKJEHBKONOJ> GGGNOJFOEIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7278F0", Offset = "0x726CF0")]
	private LinkedList<NEMFAFDIKPL<TKey>.PKJEHBKONOJ> ILANNBMMDKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private int HCGLJKONGOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private bool DGLPJIEIFBP;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4032400", Offset = "0x4030C00", VA = "0x184032400")]
	public NEMFAFDIKPL([Optional] int? HCGLJKONGOI, bool DGLPJIEIFBP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4030910", Offset = "0x402F110", VA = "0x184030910")]
	public bool BMMDLBHEFHE(TKey EECINICJCLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x12A4880", Offset = "0x12A3080", VA = "0x1812A4880")]
	public JJMNNLLBAJO<TValue> OBNIGFPMCKD<TValue>(TKey EECINICJCLK) where TValue : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x12A3A60", Offset = "0x12A2260", VA = "0x1812A3A60")]
	public void DCLIJHBOMFC<TValue>(TKey EECINICJCLK, TValue MENBIMCLIOI) where TValue : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x12A4260", Offset = "0x12A2A60", VA = "0x1812A4260")]
	public void NHHMNBLNCFE<TValue>(TKey EECINICJCLK, JJMNNLLBAJO<TValue> IAHNODEPOMP, TimeSpan LFNMEDNBMAP) where TValue : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x12A4730", Offset = "0x12A2F30", VA = "0x1812A4730")]
	public JJMNNLLBAJO<TValue> NMENIHNLHFA<TValue>(TKey EECINICJCLK, Func<JJMNNLLBAJO<TValue>> EOKEOJAGCCN) where TValue : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x12A47E0", Offset = "0x12A2FE0", VA = "0x1812A47E0")]
	public JJMNNLLBAJO<TValue> NMENIHNLHFA<TValue>(TKey EECINICJCLK, Func<JJMNNLLBAJO<TValue>> EOKEOJAGCCN, TimeSpan LFNMEDNBMAP) where TValue : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4031600", Offset = "0x402FE00", VA = "0x184031600")]
	public bool FNJGHMKCCPI(TKey EECINICJCLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4030FA0", Offset = "0x402F7A0", VA = "0x184030FA0")]
	public void EEMEPIGIECC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4030940", Offset = "0x402F140", VA = "0x184030940")]
	private void DPLMBHHKBDB([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x727950", Offset = "0x726D50")] NEMFAFDIKPL<TKey>.PKJEHBKONOJ PNHJHBPJJKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4031DC0", Offset = "0x40305C0", VA = "0x184031DC0")]
	private void KHAIBBCJLFK([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7279B0", Offset = "0x726DB0")] NEMFAFDIKPL<TKey>.PKJEHBKONOJ PNHJHBPJJKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4031030", Offset = "0x402F830", VA = "0x184031030")]
	private void FDOCOJGCOJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4031680", Offset = "0x402FE80", VA = "0x184031680")]
	private bool JFDGMJCBEEP([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x727A10", Offset = "0x726E10")] NEMFAFDIKPL<TKey>.PKJEHBKONOJ PNHJHBPJJKM)
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
		private struct PLBKLEFJEJP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public string EHNKIECOKGD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public GHJKEMFHLHG JKKHPKEDPHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public float? LIAKKFFHBGK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public float? DLKAHEGPEKG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public IDisposable KGLIDEMMGHG;
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class MBLFAJIAOEC : IEnumerator<object>, IEnumerator, IDisposable
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
			private PLBKLEFJEJP <operation>5__3;

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xA2B190", Offset = "0xA29990", VA = "0x180A2B190")]
			[DebuggerHidden]
			public MBLFAJIAOEC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6F23BC0", Offset = "0x6F223C0", VA = "0x186F23BC0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6F23DD0", Offset = "0x6F225D0", VA = "0x186F23DD0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class KKEGHPKGFDM : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public ACOJIJEEGAO promise;

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
				[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xA2B190", Offset = "0xA29990", VA = "0x180A2B190")]
			[DebuggerHidden]
			public KKEGHPKGFDM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6F23B20", Offset = "0x6F22320", VA = "0x186F23B20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6F23B80", Offset = "0x6F22380", VA = "0x186F23B80", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private List<PLBKLEFJEJP> LBLHCMPDOCF;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool FJOACOHAPGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA976F0", VA = "0x180A98EF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xA991D0", Offset = "0xA979D0", VA = "0x180A991D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6F238E0", Offset = "0x6F220E0", VA = "0x186F238E0")]
		public static AsyncBatch Create(Transform GJPBCFJDGCH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6F23A30", Offset = "0x6F22230", VA = "0x186F23A30")]
		[IteratorStateMachine(typeof(MBLFAJIAOEC))]
		private IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6F237B0", Offset = "0x6F21FB0", VA = "0x186F237B0")]
		public void Add(string MDOAADHDBMA, GHJKEMFHLHG IAHNODEPOMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6F235D0", Offset = "0x6F21DD0", VA = "0x186F235D0")]
		public void Add(string MDOAADHDBMA, IEnumerator NGLFNBCIGHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6F23990", Offset = "0x6F22190", VA = "0x186F23990")]
		[IteratorStateMachine(typeof(KKEGHPKGFDM))]
		private IEnumerator INLMONCECMJ(ACOJIJEEGAO IAHNODEPOMP, IEnumerator NGLFNBCIGHL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6F23AA0", Offset = "0x6F222A0", VA = "0x186F23AA0")]
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
