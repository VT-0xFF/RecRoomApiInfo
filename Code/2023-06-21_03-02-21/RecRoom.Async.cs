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
		[Cpp2IlInjected.Address(RVA = "0x841A80", Offset = "0x840C80", VA = "0x180841A80")]
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
		[Cpp2IlInjected.Address(RVA = "0x15A4030", Offset = "0x15A3230", VA = "0x1815A4030")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8F3350", Offset = "0x8F2550", VA = "0x1808F3350")]
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
		[Cpp2IlInjected.Address(RVA = "0xE73C20", Offset = "0xE72E20", VA = "0x180E73C20")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class CNAEBGAOLBD<TKey> where TKey : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private class OPCBDBFFKMK
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public TKey EGHHJNNLLPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x841A60", Offset = "0x840C60", VA = "0x180841A60")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public OOPPNGPPPLE AIJCKJJIIGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public DateTime LGJGNPBFPFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8D7C00", Offset = "0x8D6E00", VA = "0x1808D7C00")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x324FA20", Offset = "0x324EC20", VA = "0x18324FA20")]
		public OPCBDBFFKMK(TKey PPNIGBBPGOI, OOPPNGPPPLE IPHCMLMIPHN, DateTime FDPKNFGOCKD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class LMEJAEIHOFI<TValue> where TValue : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public CNAEBGAOLBD<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TKey key;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
		public LMEJAEIHOFI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class HKNGNBBJIAO<TValue> where TValue : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public OPCBDBFFKMK cacheEntry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public LMEJAEIHOFI<TValue> CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
		public HKNGNBBJIAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2DCFE30", Offset = "0x2DCF030", VA = "0x182DCFE30")]
		internal void FCKEONCNJDC(string e)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xC5820", Offset = "0xC4C20")]
	private Dictionary<TKey, CNAEBGAOLBD<TKey>.OPCBDBFFKMK> NJDJIKKDMOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xC5880", Offset = "0xC4C80")]
	private LinkedList<CNAEBGAOLBD<TKey>.OPCBDBFFKMK> LDHDBIFECCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xC58E0", Offset = "0xC4CE0")]
	private LinkedList<CNAEBGAOLBD<TKey>.OPCBDBFFKMK> HPDKOIAEJAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private int NFPIJLDFIHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private bool DALLNGOLJEA;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4A4BBC0", Offset = "0x4A4ADC0", VA = "0x184A4BBC0")]
	public CNAEBGAOLBD([Optional] int? NFPIJLDFIHF, bool DALLNGOLJEA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4A4AFA0", Offset = "0x4A4A1A0", VA = "0x184A4AFA0")]
	public bool KIBDODDKDKH(TKey PPNIGBBPGOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x26252B0", Offset = "0x26244B0", VA = "0x1826252B0")]
	public NHJDNADPIAN<TValue> DHFDECODAFG<TValue>(TKey PPNIGBBPGOI) where TValue : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x26254C0", Offset = "0x26246C0", VA = "0x1826254C0")]
	public void FAEEFOMAPPM<TValue>(TKey PPNIGBBPGOI, TValue ACKOJNNBEBO) where TValue : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2624430", Offset = "0x2623630", VA = "0x182624430")]
	public void AIPKNEBGEOE<TValue>(TKey PPNIGBBPGOI, NHJDNADPIAN<TValue> IPHCMLMIPHN, TimeSpan CDFCPMKHPAN) where TValue : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x26257A0", Offset = "0x26249A0", VA = "0x1826257A0")]
	public NHJDNADPIAN<TValue> INEADNPCEAF<TValue>(TKey PPNIGBBPGOI, Func<NHJDNADPIAN<TValue>> NBJGAKMFDEP) where TValue : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x26255B0", Offset = "0x26247B0", VA = "0x1826255B0")]
	public NHJDNADPIAN<TValue> INEADNPCEAF<TValue>(TKey PPNIGBBPGOI, Func<NHJDNADPIAN<TValue>> NBJGAKMFDEP, TimeSpan CDFCPMKHPAN) where TValue : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4A4B930", Offset = "0x4A4AB30", VA = "0x184A4B930")]
	public bool PLKCAALIKKA(TKey PPNIGBBPGOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4A4A520", Offset = "0x4A49720", VA = "0x184A4A520")]
	public void DAFFCKIEONE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4A4A300", Offset = "0x4A49500", VA = "0x184A4A300")]
	private void COBDDHHPNHN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xC5940", Offset = "0xC4D40")] CNAEBGAOLBD<TKey>.OPCBDBFFKMK KLODMPGEKBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4A4B610", Offset = "0x4A4A810", VA = "0x184A4B610")]
	private void OONFNJNEOIP([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xC59A0", Offset = "0xC4DA0")] CNAEBGAOLBD<TKey>.OPCBDBFFKMK KLODMPGEKBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4A4ABC0", Offset = "0x4A49DC0", VA = "0x184A4ABC0")]
	private void JHHMFELJHJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4A4A870", Offset = "0x4A49A70", VA = "0x184A4A870")]
	private bool DGGDEEMDHPI([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xC5A00", Offset = "0xC4E00")] CNAEBGAOLBD<TKey>.OPCBDBFFKMK KLODMPGEKBG)
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
		private struct AMIPFGNJGKJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public string AOPINHAKJMP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public OOPPNGPPPLE AIJCKJJIIGI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public float? GKEENKGPCCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public float? ONNDMPPDPIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public IDisposable JNDLHKKPAPE;
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class EOBDABHLDEG : IEnumerator<object>, IEnumerator, IDisposable
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
			private AMIPFGNJGKJ <operation>5__3;

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x8DC2E0", Offset = "0x8DB4E0", VA = "0x1808DC2E0")]
			[DebuggerHidden]
			public EOBDABHLDEG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x15A3D40", Offset = "0x15A2F40", VA = "0x1815A3D40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x15A3F50", Offset = "0x15A3150", VA = "0x1815A3F50", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class LEKMLHNIJAN : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public DAFGDOMLDFF promise;

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
				[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x8DC2E0", Offset = "0x8DB4E0", VA = "0x1808DC2E0")]
			[DebuggerHidden]
			public LEKMLHNIJAN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x15A3F90", Offset = "0x15A3190", VA = "0x1815A3F90", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x15A3FF0", Offset = "0x15A31F0", VA = "0x1815A3FF0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private List<AMIPFGNJGKJ> OECFDFNHGLN;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool NBCMKFJCLKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8F3030", Offset = "0x8F2230", VA = "0x1808F3030")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x971F20", Offset = "0x971120", VA = "0x180971F20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x15A3B00", Offset = "0x15A2D00", VA = "0x1815A3B00")]
		public static AsyncBatch Create(Transform BLFIAOLNAKG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x15A3C50", Offset = "0x15A2E50", VA = "0x1815A3C50")]
		[IteratorStateMachine(typeof(EOBDABHLDEG))]
		private IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x15A39D0", Offset = "0x15A2BD0", VA = "0x1815A39D0")]
		public void Add(string PCKMHBLNCII, OOPPNGPPPLE IPHCMLMIPHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x15A37F0", Offset = "0x15A29F0", VA = "0x1815A37F0")]
		public void Add(string PCKMHBLNCII, IEnumerator CGDGEFKFGKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x15A3BB0", Offset = "0x15A2DB0", VA = "0x1815A3BB0")]
		[IteratorStateMachine(typeof(LEKMLHNIJAN))]
		private IEnumerator DFMFBPGHFLL(DAFGDOMLDFF IPHCMLMIPHN, IEnumerator CGDGEFKFGKE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x15A3CC0", Offset = "0x15A2EC0", VA = "0x1815A3CC0")]
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
