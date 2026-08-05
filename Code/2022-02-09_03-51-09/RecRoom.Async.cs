using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mono.Math;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Async
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class AsyncBatch : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private struct LMLKDIAKJGD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public string EPJAPACKECE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public CFGFLPOGNPH IFJLINHCBPD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public float? KBDMOIPGONO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public float? JNOPDLHNIOB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public IDisposable IJCABFINHOF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class FMGPHBFNAKC : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x4E91C0", Offset = "0x4E7FC0", VA = "0x1804E91C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x4E91C0", Offset = "0x4E7FC0", VA = "0x1804E91C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6086A0", Offset = "0x6074A0", VA = "0x1806086A0")]
			[DebuggerHidden]
			public FMGPHBFNAKC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x4E9E80", Offset = "0x4E8C80", VA = "0x1804E9E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x470C870", Offset = "0x470B670", VA = "0x18470C870", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x470CA40", Offset = "0x470B840", VA = "0x18470CA40", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class JGMANADOPCG : IEnumerator<object>, IEnumerator, IDisposable
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
			public CMJIAFMNIEL promise;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x4E91C0", Offset = "0x4E7FC0", VA = "0x1804E91C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x4E91C0", Offset = "0x4E7FC0", VA = "0x1804E91C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6086A0", Offset = "0x6074A0", VA = "0x1806086A0")]
			[DebuggerHidden]
			public JGMANADOPCG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x4E9E80", Offset = "0x4E8C80", VA = "0x1804E9E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x470CA90", Offset = "0x470B890", VA = "0x18470CA90", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x470CAF0", Offset = "0x470B8F0", VA = "0x18470CAF0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private List<LMLKDIAKJGD> JAKBDDLPJMD;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool IEDCFCACBJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x4E9190", Offset = "0x4E7F90", VA = "0x1804E9190")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x5D1010", Offset = "0x5CFE10", VA = "0x1805D1010")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x470C700", Offset = "0x470B500", VA = "0x18470C700")]
		public static AsyncBatch Create(Transform EBLJNNNHKDK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x470C790", Offset = "0x470B590", VA = "0x18470C790")]
		[IteratorStateMachine(typeof(FMGPHBFNAKC))]
		private IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x470C550", Offset = "0x470B350", VA = "0x18470C550")]
		public void Add(string PEFIPPNHHCC, CFGFLPOGNPH JHMDHJLPMED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x470C390", Offset = "0x470B190", VA = "0x18470C390")]
		public void Add(string PEFIPPNHHCC, IEnumerator PPKEAFKGODK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x470C670", Offset = "0x470B470", VA = "0x18470C670")]
		[IteratorStateMachine(typeof(JGMANADOPCG))]
		private IEnumerator CJGBOPKLFFO(CMJIAFMNIEL JHMDHJLPMED, IEnumerator PPKEAFKGODK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x470C800", Offset = "0x470B600", VA = "0x18470C800")]
		public AsyncBatch()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class EMFBLPGAKMI<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class MAOEEAMIJHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TKey FCPKEJOIGFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public CFGFLPOGNPH IFJLINHCBPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public DateTime BDBBFMKPDEL;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1819380", Offset = "0x1818180", VA = "0x181819380")]
		public MAOEEAMIJHD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class IKHPJDDBDOG<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public global::EMFBLPGAKMI<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public TKey key;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x1819380", Offset = "0x1818180", VA = "0x181819380")]
		public IKHPJDDBDOG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class NKJHGKOHIPG<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public MAOEEAMIJHD cacheEntry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public IKHPJDDBDOG<TValue> CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1819380", Offset = "0x1818180", VA = "0x181819380")]
		public NKJHGKOHIPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x38F75F0", Offset = "0x38F63F0", VA = "0x1838F75F0")]
		internal void <SetPromise>b__0(string e)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<TKey, MAOEEAMIJHD> DJHFGKBBFEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private LinkedList<MAOEEAMIJHD> PFPOEHPPAME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private LinkedList<MAOEEAMIJHD> DJBHNEHBCIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int EOPHCDJKJDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool LAPGNCKNPNO;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public ICollection<TKey> LBOCEFMJIHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1FA3D70", Offset = "0x1FA2B70", VA = "0x181FA3D70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x38E7FB0", Offset = "0x38E6DB0", VA = "0x1838E7FB0")]
	public EMFBLPGAKMI([Optional] int? EOPHCDJKJDP, bool LAPGNCKNPNO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1FA3DD0", Offset = "0x1FA2BD0", VA = "0x181FA3DD0")]
	public bool BEPPNCEDBEC(TKey MLBLCDKAFED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2271450", Offset = "0x2270250", VA = "0x182271450")]
	public global::DIPKCKEGDMM<TValue> DECNJHFBLJH<TValue>(TKey MLBLCDKAFED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x35943F0", Offset = "0x35931F0", VA = "0x1835943F0")]
	public void HCCCOANOFLH<TValue>(TKey MLBLCDKAFED, TValue LNPFAODMJGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x35944D0", Offset = "0x35932D0", VA = "0x1835944D0")]
	public void HCCCOANOFLH<TValue>(TKey MLBLCDKAFED, TValue LNPFAODMJGO, TimeSpan FKNLNKJKMJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3594FE0", Offset = "0x3593DE0", VA = "0x183594FE0")]
	public void JANLLFHIFHP<TValue>(TKey MLBLCDKAFED, global::DIPKCKEGDMM<TValue> JHMDHJLPMED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x35953F0", Offset = "0x35941F0", VA = "0x1835953F0")]
	public void JANLLFHIFHP<TValue>(TKey MLBLCDKAFED, global::DIPKCKEGDMM<TValue> JHMDHJLPMED, TimeSpan FKNLNKJKMJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2271A80", Offset = "0x2270880", VA = "0x182271A80")]
	public global::DIPKCKEGDMM<TValue> EOLHKCKKAPH<TValue>(TKey MLBLCDKAFED, Func<global::DIPKCKEGDMM<TValue>> MFHCCCDFJCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x22719E0", Offset = "0x22707E0", VA = "0x1822719E0")]
	public global::DIPKCKEGDMM<TValue> EOLHKCKKAPH<TValue>(TKey MLBLCDKAFED, Func<global::DIPKCKEGDMM<TValue>> MFHCCCDFJCN, TimeSpan FKNLNKJKMJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x38E75D0", Offset = "0x38E63D0", VA = "0x1838E75D0")]
	public bool KGKIHAGANBK(TKey MLBLCDKAFED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x38E6B50", Offset = "0x38E5950", VA = "0x1838E6B50")]
	public int DNOKEGEFHGI(Predicate<TKey> PLECNGBCGEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x38E7B60", Offset = "0x38E6960", VA = "0x1838E7B60")]
	public void NDPIBEPLAFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x38E5F00", Offset = "0x38E4D00", VA = "0x1838E5F00")]
	private void BELPEGGCCNE(MAOEEAMIJHD PJCEHLLAJAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x38E6DC0", Offset = "0x38E5BC0", VA = "0x1838E6DC0")]
	private void HPCCLILLONN(MAOEEAMIJHD PJCEHLLAJAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x38E79B0", Offset = "0x38E67B0", VA = "0x1838E79B0")]
	private void KGOOMNGIDHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x38E6410", Offset = "0x38E5210", VA = "0x1838E6410")]
	private bool DNMDAEIOIJL(MAOEEAMIJHD PJCEHLLAJAM)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class KBKCNEEIGLD
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static byte[] HKOBKFJLJAG;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private static int ADAIBBEDLAL;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static int PDJAKEHAIFF;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static BigInteger NCCPNIBEFHO;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4EBAB0", Offset = "0x4EA8B0", VA = "0x1804EBAB0")]
	public KBKCNEEIGLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x470CE70", Offset = "0x470BC70", VA = "0x18470CE70")]
	private static string PLNBGBJHHON(byte[] DPEJHFONKCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x470CB40", Offset = "0x470B940", VA = "0x18470CB40")]
	public static string GFPOJAMMFIA(byte[] EMAHDMOPMEP, bool FCMNFAHODMM)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x4EBAB0", Offset = "0x4EA8B0", VA = "0x1804EBAB0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
	{
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
