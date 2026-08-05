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
		private struct EJBCCKPNEFN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public string KKHBICLGHOL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public APPFHLGLKJA LKNHLIONGOE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public float? JEJHBBKCGNN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public float? NEKLJDEAFNM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public IDisposable MKBANOCBMNH;
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class BOCGCLIKPKH : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x5AB350", Offset = "0x5AA350", VA = "0x1805AB350", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x5AB350", Offset = "0x5AA350", VA = "0x1805AB350", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x5EF540", Offset = "0x5EE540", VA = "0x1805EF540")]
			[DebuggerHidden]
			public BOCGCLIKPKH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x5AA220", Offset = "0x5A9220", VA = "0x1805AA220", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x1E2B4D0", Offset = "0x1E2A4D0", VA = "0x181E2B4D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x1E2B6A0", Offset = "0x1E2A6A0", VA = "0x181E2B6A0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class GJAEOCLEABA : IEnumerator<object>, IEnumerator, IDisposable
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
			public BNGELMJMADH promise;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x5AB350", Offset = "0x5AA350", VA = "0x1805AB350", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x5AB350", Offset = "0x5AA350", VA = "0x1805AB350", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x5EF540", Offset = "0x5EE540", VA = "0x1805EF540")]
			[DebuggerHidden]
			public GJAEOCLEABA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x5AA220", Offset = "0x5A9220", VA = "0x1805AA220", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x1E2B6F0", Offset = "0x1E2A6F0", VA = "0x181E2B6F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x1E2B750", Offset = "0x1E2A750", VA = "0x181E2B750", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private List<EJBCCKPNEFN> FFJGINGPCMG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool EHMINPKKADE
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x5EF7A0", Offset = "0x5EE7A0", VA = "0x1805EF7A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x6ADE70", Offset = "0x6ACE70", VA = "0x1806ADE70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x1E2B2D0", Offset = "0x1E2A2D0", VA = "0x181E2B2D0")]
		public static AsyncBatch Create(Transform COLFLONKFJK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1E2B3F0", Offset = "0x1E2A3F0", VA = "0x181E2B3F0")]
		[IteratorStateMachine(typeof(BOCGCLIKPKH))]
		private IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1E2B1B0", Offset = "0x1E2A1B0", VA = "0x181E2B1B0")]
		public void Add(string MONHCMBIJIP, APPFHLGLKJA PNEBNJNAOIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1E2AFF0", Offset = "0x1E29FF0", VA = "0x181E2AFF0")]
		public void Add(string MONHCMBIJIP, IEnumerator GBLEGCCOFFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1E2B360", Offset = "0x1E2A360", VA = "0x181E2B360")]
		[IteratorStateMachine(typeof(GJAEOCLEABA))]
		private IEnumerator DHACOHBELPP(BNGELMJMADH PNEBNJNAOIA, IEnumerator GBLEGCCOFFF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1E2B460", Offset = "0x1E2A460", VA = "0x181E2B460")]
		public AsyncBatch()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class JPACOHGNDAH<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class IPECGFAFGFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TKey FJPMPBHLOOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public APPFHLGLKJA LKNHLIONGOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public DateTime BCADGDIOLNF;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8B5B90", Offset = "0x8B4B90", VA = "0x1808B5B90")]
		public IPECGFAFGFD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class IKLKIIPADDJ<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public global::JPACOHGNDAH<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public TKey key;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8B5B90", Offset = "0x8B4B90", VA = "0x1808B5B90")]
		public IKLKIIPADDJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class APMGMEJAFGK<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public IPECGFAFGFD cacheEntry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public IKLKIIPADDJ<TValue> CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8B5B90", Offset = "0x8B4B90", VA = "0x1808B5B90")]
		public APMGMEJAFGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x47C5C90", Offset = "0x47C4C90", VA = "0x1847C5C90")]
		internal void <SetPromise>b__0(string e)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<TKey, IPECGFAFGFD> JFHJFCDGNCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private LinkedList<IPECGFAFGFD> GDBDPOPPDEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private LinkedList<IPECGFAFGFD> JCBCLGJLIMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int LAGEPCJCEFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool KGOEBKHDEFO;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public ICollection<TKey> GCFCKHBGHHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x14032C0", Offset = "0x14022C0", VA = "0x1814032C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x47D5780", Offset = "0x47D4780", VA = "0x1847D5780")]
	public JPACOHGNDAH([Optional] int? LAGEPCJCEFF, bool KGOEBKHDEFO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x39235F0", Offset = "0x39225F0", VA = "0x1839235F0")]
	public bool NHEDMKBNPEE(TKey MKDJIBNCKNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x32B49B0", Offset = "0x32B39B0", VA = "0x1832B49B0")]
	public global::DBIKMJJJBLJ<TValue> AOGJMMJFOML<TValue>(TKey MKDJIBNCKNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x38DFC90", Offset = "0x38DEC90", VA = "0x1838DFC90")]
	public void GOMBGNICLJL<TValue>(TKey MKDJIBNCKNC, TValue MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x38DFBD0", Offset = "0x38DEBD0", VA = "0x1838DFBD0")]
	public void GOMBGNICLJL<TValue>(TKey MKDJIBNCKNC, TValue MPHFKGJNMOK, TimeSpan EBBALBIFLHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x38DF7C0", Offset = "0x38DE7C0", VA = "0x1838DF7C0")]
	public void ALFIMEBOGOE<TValue>(TKey MKDJIBNCKNC, global::DBIKMJJJBLJ<TValue> PNEBNJNAOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x38DF0F0", Offset = "0x38DE0F0", VA = "0x1838DF0F0")]
	public void ALFIMEBOGOE<TValue>(TKey MKDJIBNCKNC, global::DBIKMJJJBLJ<TValue> PNEBNJNAOIA, TimeSpan EBBALBIFLHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x32B4FE0", Offset = "0x32B3FE0", VA = "0x1832B4FE0")]
	public global::DBIKMJJJBLJ<TValue> FKFIFBANKHA<TValue>(TKey MKDJIBNCKNC, Func<global::DBIKMJJJBLJ<TValue>> FEHJHNDHJOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x32B4F40", Offset = "0x32B3F40", VA = "0x1832B4F40")]
	public global::DBIKMJJJBLJ<TValue> FKFIFBANKHA<TValue>(TKey MKDJIBNCKNC, Func<global::DBIKMJJJBLJ<TValue>> FEHJHNDHJOM, TimeSpan EBBALBIFLHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x47D5520", Offset = "0x47D4520", VA = "0x1847D5520")]
	public bool MNHCGCIEOKP(TKey MKDJIBNCKNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x47D4DD0", Offset = "0x47D3DD0", VA = "0x1847D4DD0")]
	public int JPDGOHOAFDO(Predicate<TKey> MOCGNKJBNOP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x47D49B0", Offset = "0x47D39B0", VA = "0x1847D49B0")]
	public void CGFAFPCCKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x47D36C0", Offset = "0x47D26C0", VA = "0x1847D36C0")]
	private void AIODOHOAODG(IPECGFAFGFD FHIFMCKLKIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x47D3F40", Offset = "0x47D2F40", VA = "0x1847D3F40")]
	private void AOAHHCMHPNF(IPECGFAFGFD FHIFMCKLKIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x47D44A0", Offset = "0x47D34A0", VA = "0x1847D44A0")]
	private void BIGELPPNIIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x47D4B70", Offset = "0x47D3B70", VA = "0x1847D4B70")]
	private bool GKKHCKECNDD(IPECGFAFGFD FHIFMCKLKIJ)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class HGPPKMCDCLL
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static byte[] PIDGMPFPDGI;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private static int CONMIAOECKG;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static int PDHBFKNINGO;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static BigInteger EDLLKHJPMCN;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
	public HGPPKMCDCLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1E2B7A0", Offset = "0x1E2A7A0", VA = "0x181E2B7A0")]
	private static string CKGLFMJKOPM(byte[] IIFMPDAMAIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1E2B8A0", Offset = "0x1E2A8A0", VA = "0x181E2B8A0")]
	public static string IOHOBOIOFIG(byte[] KFCJKMJDFKE, bool OLNJLDMOIJP)
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
		[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
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
