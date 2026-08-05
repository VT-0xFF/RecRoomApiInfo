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
		private struct MBLDFNCKPFL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public string BILCIOOICBK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public EJLKCPFELBD PNJPFEEPODJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public float? FCHFJGOIJHE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public float? BNMJIPNJHDH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public IDisposable PPEEHNACFBM;
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class NCDFLBEBPCI : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x511050", Offset = "0x510050", VA = "0x180511050", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x511050", Offset = "0x510050", VA = "0x180511050", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x534960", Offset = "0x533960", VA = "0x180534960")]
			[DebuggerHidden]
			public NCDFLBEBPCI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x50DB30", Offset = "0x50CB30", VA = "0x18050DB30", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x49F1E00", Offset = "0x49F0E00", VA = "0x1849F1E00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x49F1FD0", Offset = "0x49F0FD0", VA = "0x1849F1FD0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class GDCOAAJKPDA : IEnumerator<object>, IEnumerator, IDisposable
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
			public MNDNBPKLGEA promise;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x511050", Offset = "0x510050", VA = "0x180511050", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x511050", Offset = "0x510050", VA = "0x180511050", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x534960", Offset = "0x533960", VA = "0x180534960")]
			[DebuggerHidden]
			public GDCOAAJKPDA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x50DB30", Offset = "0x50CB30", VA = "0x18050DB30", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x49F1D50", Offset = "0x49F0D50", VA = "0x1849F1D50", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x49F1DB0", Offset = "0x49F0DB0", VA = "0x1849F1DB0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private List<MBLDFNCKPFL> AJPEBACNCFM;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool IJMNMBHIIMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x534BC0", Offset = "0x533BC0", VA = "0x180534BC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x5D6C70", Offset = "0x5D5C70", VA = "0x1805D6C70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x49F1560", Offset = "0x49F0560", VA = "0x1849F1560")]
		public static AsyncBatch Create(Transform OACJHOOKBCN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x49F1680", Offset = "0x49F0680", VA = "0x1849F1680")]
		[IteratorStateMachine(typeof(NCDFLBEBPCI))]
		private IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x49F1280", Offset = "0x49F0280", VA = "0x1849F1280")]
		public void Add(string GDCCAEJAPNJ, EJLKCPFELBD BONEIOHHFOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x49F13A0", Offset = "0x49F03A0", VA = "0x1849F13A0")]
		public void Add(string GDCCAEJAPNJ, IEnumerator OALDELKNBJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x49F15F0", Offset = "0x49F05F0", VA = "0x1849F15F0")]
		[IteratorStateMachine(typeof(GDCOAAJKPDA))]
		private IEnumerator KBCFBBFGGDI(MNDNBPKLGEA BONEIOHHFOL, IEnumerator OALDELKNBJD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x49F16F0", Offset = "0x49F06F0", VA = "0x1849F16F0")]
		public AsyncBatch()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class GLGJPEIIGOE<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class CBMMDJIIAHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TKey ABFANLOKOBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public EJLKCPFELBD PNJPFEEPODJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public DateTime OAIEMGBOBNM;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2244BD0", Offset = "0x2243BD0", VA = "0x182244BD0")]
		public CBMMDJIIAHL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class EPICCEGADMH<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public global::GLGJPEIIGOE<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public TKey key;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2244BD0", Offset = "0x2243BD0", VA = "0x182244BD0")]
		public EPICCEGADMH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class GNOAADAKHDN<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public CBMMDJIIAHL cacheEntry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public EPICCEGADMH<TValue> CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2244BD0", Offset = "0x2243BD0", VA = "0x182244BD0")]
		public GNOAADAKHDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x32AFDE0", Offset = "0x32AEDE0", VA = "0x1832AFDE0")]
		internal void <SetPromise>b__0(string e)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<TKey, CBMMDJIIAHL> PNNPHNHGHCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private LinkedList<CBMMDJIIAHL> DECJEINDOEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private LinkedList<CBMMDJIIAHL> POIBFFKNHHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int NHJNIJACIPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool ENLMJBAKBME;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public ICollection<TKey> PFKPHBMLJCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x27D4B20", Offset = "0x27D3B20", VA = "0x1827D4B20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x32AF5D0", Offset = "0x32AE5D0", VA = "0x1832AF5D0")]
	public GLGJPEIIGOE([Optional] int? NHJNIJACIPO, bool ENLMJBAKBME = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2440410", Offset = "0x243F410", VA = "0x182440410")]
	public bool EPINABJBNBK(TKey MNGGKJHHPNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x295B290", Offset = "0x295A290", VA = "0x18295B290")]
	public global::HMPJDJAALAE<TValue> GOKMOCKLLPB<TValue>(TKey MNGGKJHHPNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x278F7F0", Offset = "0x278E7F0", VA = "0x18278F7F0")]
	public void JOBKHMBJALH<TValue>(TKey MNGGKJHHPNI, TValue DDDOLDGEMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x278F730", Offset = "0x278E730", VA = "0x18278F730")]
	public void JOBKHMBJALH<TValue>(TKey MNGGKJHHPNI, TValue DDDOLDGEMNC, TimeSpan KEDOILDINAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x278EFB0", Offset = "0x278DFB0", VA = "0x18278EFB0")]
	public void BDEOHFGPLEP<TValue>(TKey MNGGKJHHPNI, global::HMPJDJAALAE<TValue> BONEIOHHFOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x278EC50", Offset = "0x278DC50", VA = "0x18278EC50")]
	public void BDEOHFGPLEP<TValue>(TKey MNGGKJHHPNI, global::HMPJDJAALAE<TValue> BONEIOHHFOL, TimeSpan KEDOILDINAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x295B520", Offset = "0x295A520", VA = "0x18295B520")]
	public global::HMPJDJAALAE<TValue> NANNMDHJFIE<TValue>(TKey MNGGKJHHPNI, Func<global::HMPJDJAALAE<TValue>> JGKAKGOEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x295B480", Offset = "0x295A480", VA = "0x18295B480")]
	public global::HMPJDJAALAE<TValue> NANNMDHJFIE<TValue>(TKey MNGGKJHHPNI, Func<global::HMPJDJAALAE<TValue>> JGKAKGOEHPF, TimeSpan KEDOILDINAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x32AE3B0", Offset = "0x32AD3B0", VA = "0x1832AE3B0")]
	public bool KOAAEEDJIKB(TKey MNGGKJHHPNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x32ADBA0", Offset = "0x32ACBA0", VA = "0x1832ADBA0")]
	public int EALIBFGFMBO(Predicate<TKey> DHNKJAFMFGA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x32AE320", Offset = "0x32AD320", VA = "0x1832AE320")]
	public void FLOPBJIDDIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x32AEC40", Offset = "0x32ADC40", VA = "0x1832AEC40")]
	private void PPKGKFNAMFE(CBMMDJIIAHL NFHEHHDPCJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x32AE990", Offset = "0x32AD990", VA = "0x1832AE990")]
	private void LFBAIJDIILM(CBMMDJIIAHL NFHEHHDPCJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x32AE170", Offset = "0x32AD170", VA = "0x1832AE170")]
	private void FCFLPJANMPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x32AD330", Offset = "0x32AC330", VA = "0x1832AD330")]
	private bool APIOGFEPGPE(CBMMDJIIAHL NFHEHHDPCJI)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class DLAOCNHHHPI
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static byte[] HDGCOIJLNAH;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private static int OFJBPIBPJGA;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static int DJDAKEIMIDA;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static BigInteger JAEJMLKAHIB;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	public DLAOCNHHHPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x49F1A90", Offset = "0x49F0A90", VA = "0x1849F1A90")]
	private static string MKDMGNIMLKE(byte[] FFKAJGPOGIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x49F1760", Offset = "0x49F0760", VA = "0x1849F1760")]
	public static string KDCKFNHEIFO(byte[] CPFFKFOFBAE, bool FPKNOKKBPNA)
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
		[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
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
