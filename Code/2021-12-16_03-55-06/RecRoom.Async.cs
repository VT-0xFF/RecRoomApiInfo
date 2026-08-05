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
		private struct ILFODAKDNFO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public string BJPLMHBJMFB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public BJPFHFGNMKO OEICOCMFFME;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public float? MAHKMNDBDNC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public float? ONPPHDJAFEH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public IDisposable OKCHDEDAFLL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class DFEIPHMJDLA : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x4BF190", Offset = "0x4BE590", VA = "0x1804BF190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x4BF190", Offset = "0x4BE590", VA = "0x1804BF190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x5AACF0", Offset = "0x5AA0F0", VA = "0x1805AACF0")]
			[DebuggerHidden]
			public DFEIPHMJDLA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x4BFE00", Offset = "0x4BF200", VA = "0x1804BFE00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x43E6DF0", Offset = "0x43E61F0", VA = "0x1843E6DF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x43E6FC0", Offset = "0x43E63C0", VA = "0x1843E6FC0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class FMJBGJDGOFN : IEnumerator<object>, IEnumerator, IDisposable
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
			public LCJLLILPNOL promise;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x4BF190", Offset = "0x4BE590", VA = "0x1804BF190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x4BF190", Offset = "0x4BE590", VA = "0x1804BF190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x5AACF0", Offset = "0x5AA0F0", VA = "0x1805AACF0")]
			[DebuggerHidden]
			public FMJBGJDGOFN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x4BFE00", Offset = "0x4BF200", VA = "0x1804BFE00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x43E7010", Offset = "0x43E6410", VA = "0x1843E7010", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x43E7060", Offset = "0x43E6460", VA = "0x1843E7060", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private List<ILFODAKDNFO> JGGLMPHBPPB;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool CCGHBICFFNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x4BF160", Offset = "0x4BE560", VA = "0x1804BF160")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x5D0D00", Offset = "0x5D0100", VA = "0x1805D0D00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x43E6C30", Offset = "0x43E6030", VA = "0x1843E6C30")]
		public static AsyncBatch Create(Transform JFPEDHFGIID)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x43E6D30", Offset = "0x43E6130", VA = "0x1843E6D30")]
		[IteratorStateMachine(typeof(DFEIPHMJDLA))]
		private IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x43E69D0", Offset = "0x43E5DD0", VA = "0x1843E69D0")]
		public void Add(string AAODJFHPDJC, BJPFHFGNMKO DNJEDGDMLBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x43E6AC0", Offset = "0x43E5EC0", VA = "0x1843E6AC0")]
		public void Add(string AAODJFHPDJC, IEnumerator GMKGACFAFBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x43E6CC0", Offset = "0x43E60C0", VA = "0x1843E6CC0")]
		[IteratorStateMachine(typeof(FMJBGJDGOFN))]
		private IEnumerator IEMECCFFAME(LCJLLILPNOL DNJEDGDMLBC, IEnumerator GMKGACFAFBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x43E6D90", Offset = "0x43E6190", VA = "0x1843E6D90")]
		public AsyncBatch()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class ACGENDOBEFP<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class KPDABEDFHCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TKey EENGHLBINJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public BJPFHFGNMKO OEICOCMFFME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public DateTime DPDIKOPPEBA;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x18717E0", Offset = "0x1870BE0", VA = "0x1818717E0")]
		public KPDABEDFHCH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class GIIALGNDLAO<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public global::ACGENDOBEFP<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public TKey key;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x18717E0", Offset = "0x1870BE0", VA = "0x1818717E0")]
		public GIIALGNDLAO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class LGJCEEEEOKE<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public KPDABEDFHCH cacheEntry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public GIIALGNDLAO<TValue> CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x18717E0", Offset = "0x1870BE0", VA = "0x1818717E0")]
		public LGJCEEEEOKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1F138F0", Offset = "0x1F12CF0", VA = "0x181F138F0")]
		internal void <SetPromise>b__0(string e)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<TKey, KPDABEDFHCH> BIOGNACILLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private LinkedList<KPDABEDFHCH> HMHBMOBCHPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private LinkedList<KPDABEDFHCH> BFLILEMEICJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int HJPHNHHKFCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool GFGABDAANMH;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public ICollection<TKey> ODKIBGPDEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1F0DA50", Offset = "0x1F0CE50", VA = "0x181F0DA50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1F0EBB0", Offset = "0x1F0DFB0", VA = "0x181F0EBB0")]
	public ACGENDOBEFP([Optional] int? HJPHNHHKFCD, bool GFGABDAANMH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1EBC4F0", Offset = "0x1EBB8F0", VA = "0x181EBC4F0")]
	public bool ACJPBPDDBCK(TKey KFLAFLPOCPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1B51CB0", Offset = "0x1B510B0", VA = "0x181B51CB0")]
	public global::GMNMGKEAFFO<TValue> JILLHKNFMEL<TValue>(TKey KFLAFLPOCPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1BD4AF0", Offset = "0x1BD3EF0", VA = "0x181BD4AF0")]
	public void LCIBEMOONMF<TValue>(TKey KFLAFLPOCPA, TValue DOLIKBJJDJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1BD4A30", Offset = "0x1BD3E30", VA = "0x181BD4A30")]
	public void LCIBEMOONMF<TValue>(TKey KFLAFLPOCPA, TValue DOLIKBJJDJE, TimeSpan BNMFMOIHBGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x1BD5230", Offset = "0x1BD4630", VA = "0x181BD5230")]
	public void NCIGKNMJAPI<TValue>(TKey KFLAFLPOCPA, global::GMNMGKEAFFO<TValue> DNJEDGDMLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1BD52E0", Offset = "0x1BD46E0", VA = "0x181BD52E0")]
	public void NCIGKNMJAPI<TValue>(TKey KFLAFLPOCPA, global::GMNMGKEAFFO<TValue> DNJEDGDMLBC, TimeSpan BNMFMOIHBGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x1B51540", Offset = "0x1B50940", VA = "0x181B51540")]
	public global::GMNMGKEAFFO<TValue> AHLGJMODOFK<TValue>(TKey KFLAFLPOCPA, Func<global::GMNMGKEAFFO<TValue>> EJLAKAAILDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x1B51350", Offset = "0x1B50750", VA = "0x181B51350")]
	public global::GMNMGKEAFFO<TValue> AHLGJMODOFK<TValue>(TKey KFLAFLPOCPA, Func<global::GMNMGKEAFFO<TValue>> EJLAKAAILDG, TimeSpan BNMFMOIHBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x1F0D9D0", Offset = "0x1F0CDD0", VA = "0x181F0D9D0")]
	public bool IBJELHEEHJF(TKey KFLAFLPOCPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x1F0D160", Offset = "0x1F0C560", VA = "0x181F0D160")]
	public int AKMNAOLLBKJ(Predicate<TKey> NMLEBGDGIBH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1F0DF90", Offset = "0x1F0D390", VA = "0x181F0DF90")]
	public void MEHOAGGHOJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1F0CB10", Offset = "0x1F0BF10", VA = "0x181F0CB10")]
	private void ACLAMIBKAPL(KPDABEDFHCH MCIPAAGGBKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1F0E2D0", Offset = "0x1F0D6D0", VA = "0x181F0E2D0")]
	private void NLNNNNODNCE(KPDABEDFHCH MCIPAAGGBKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1F0DC30", Offset = "0x1F0D030", VA = "0x181F0DC30")]
	private void KLBFBIEBILK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1F0D8A0", Offset = "0x1F0CCA0", VA = "0x181F0D8A0")]
	private bool FLHOBLAAEBD(KPDABEDFHCH MCIPAAGGBKH)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class LFOOCLJBDKO
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static byte[] MMIGALFGEBH;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private static int KKBDIGGLOKN;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static int BKPLPABKLDE;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static BigInteger NPDKPCMPDOD;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4C19D0", Offset = "0x4C0DD0", VA = "0x1804C19D0")]
	public LFOOCLJBDKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x43E70B0", Offset = "0x43E64B0", VA = "0x1843E70B0")]
	private static string ELDABPJJLIE(byte[] DOIHHFGBAEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x43E71B0", Offset = "0x43E65B0", VA = "0x1843E71B0")]
	public static string OCONCCINMFA(byte[] KLJMCJLFPAA, bool NGPDKIFLJKL)
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
		[Cpp2IlInjected.Address(RVA = "0x4C19D0", Offset = "0x4C0DD0", VA = "0x1804C19D0")]
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
