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
		private struct OBHAOMHBMPE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public string AJBFJEGGMOH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public DCLDNCDAGBP HOIJJAMDKBK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public float? CEOFEPBNKFN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public float? MJPHLHLCOIF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public IDisposable HBPNFFAFJFE;
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class BEGJDJJMNAK : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x41F190", Offset = "0x41DF90", VA = "0x18041F190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x41F190", Offset = "0x41DF90", VA = "0x18041F190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x583720", Offset = "0x582520", VA = "0x180583720")]
			[DebuggerHidden]
			public BEGJDJJMNAK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x41FE00", Offset = "0x41EC00", VA = "0x18041FE00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x3CF3AE0", Offset = "0x3CF28E0", VA = "0x183CF3AE0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x3CF3CB0", Offset = "0x3CF2AB0", VA = "0x183CF3CB0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class HKPGBLMLAII : IEnumerator<object>, IEnumerator, IDisposable
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
			public KGMMIHKBHKP promise;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x41F190", Offset = "0x41DF90", VA = "0x18041F190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x41F190", Offset = "0x41DF90", VA = "0x18041F190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x583720", Offset = "0x582520", VA = "0x180583720")]
			[DebuggerHidden]
			public HKPGBLMLAII(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x41FE00", Offset = "0x41EC00", VA = "0x18041FE00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x3CF42E0", Offset = "0x3CF30E0", VA = "0x183CF42E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x3CF4330", Offset = "0x3CF3130", VA = "0x183CF4330", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private List<OBHAOMHBMPE> HMAEBJMJPKJ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool KDBFJGEPJAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x41F160", Offset = "0x41DF60", VA = "0x18041F160")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x4DC460", Offset = "0x4DB260", VA = "0x1804DC460")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x3CF3920", Offset = "0x3CF2720", VA = "0x183CF3920")]
		public static AsyncBatch Create(Transform EPKFCLLFPEH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x3CF3A20", Offset = "0x3CF2820", VA = "0x183CF3A20")]
		[IteratorStateMachine(typeof(BEGJDJJMNAK))]
		private IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3CF3830", Offset = "0x3CF2630", VA = "0x183CF3830")]
		public void Add(string LLDNAEBFKIG, DCLDNCDAGBP CDPKOIOFGNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3CF36C0", Offset = "0x3CF24C0", VA = "0x183CF36C0")]
		public void Add(string LLDNAEBFKIG, IEnumerator GJCACMGIICC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3CF39B0", Offset = "0x3CF27B0", VA = "0x183CF39B0")]
		[IteratorStateMachine(typeof(HKPGBLMLAII))]
		private IEnumerator DJIKACPADCA(KGMMIHKBHKP CDPKOIOFGNI, IEnumerator GJCACMGIICC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3CF3A80", Offset = "0x3CF2880", VA = "0x183CF3A80")]
		public AsyncBatch()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class EIBJOPBECMD<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class OGBCNDCJIKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TKey GBAAKJMCCDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public DCLDNCDAGBP HOIJJAMDKBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public DateTime LIPAFJBCBLH;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1690560", Offset = "0x168F360", VA = "0x181690560")]
		public OGBCNDCJIKL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class AOAIAKGDELE<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public global::EIBJOPBECMD<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public TKey key;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x1690560", Offset = "0x168F360", VA = "0x181690560")]
		public AOAIAKGDELE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class OFOFBFJOKHJ<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public OGBCNDCJIKL cacheEntry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AOAIAKGDELE<TValue> CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1690560", Offset = "0x168F360", VA = "0x181690560")]
		public OFOFBFJOKHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2BAE290", Offset = "0x2BAD090", VA = "0x182BAE290")]
		internal void <SetPromise>b__0(string e)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<TKey, OGBCNDCJIKL> DCHGPABLNJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private LinkedList<OGBCNDCJIKL> CHBPPGNHLNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private LinkedList<OGBCNDCJIKL> EMBJKBKIPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int LFLAANDBBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool BNCNLAAJPEK;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public ICollection<TKey> KFODCDMLPLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3080", Offset = "0x2BA1E80", VA = "0x182BA3080")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2BA3D90", Offset = "0x2BA2B90", VA = "0x182BA3D90")]
	public EIBJOPBECMD([Optional] int? LFLAANDBBPA, bool BNCNLAAJPEK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1D3C330", Offset = "0x1D3B130", VA = "0x181D3C330")]
	public bool CBILBCPHDOB(TKey JEAOBHPGMKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1EDA950", Offset = "0x1ED9750", VA = "0x181EDA950")]
	public global::BGNOPMFAGGO<TValue> CJEALIJMLEO<TValue>(TKey JEAOBHPGMKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1CCFD50", Offset = "0x1CCEB50", VA = "0x181CCFD50")]
	public void AOACAHMFPOC<TValue>(TKey JEAOBHPGMKJ, TValue NAHKACCDOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1CCFC90", Offset = "0x1CCEA90", VA = "0x181CCFC90")]
	public void AOACAHMFPOC<TValue>(TKey JEAOBHPGMKJ, TValue NAHKACCDOIA, TimeSpan JIHONPACDIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x1CD07C0", Offset = "0x1CCF5C0", VA = "0x181CD07C0")]
	public void NDCKIHIKNDB<TValue>(TKey JEAOBHPGMKJ, global::BGNOPMFAGGO<TValue> CDPKOIOFGNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1CD0870", Offset = "0x1CCF670", VA = "0x181CD0870")]
	public void NDCKIHIKNDB<TValue>(TKey JEAOBHPGMKJ, global::BGNOPMFAGGO<TValue> CDPKOIOFGNI, TimeSpan JIHONPACDIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x1EDA480", Offset = "0x1ED9280", VA = "0x181EDA480")]
	public global::BGNOPMFAGGO<TValue> BOMKAOKNBNG<TValue>(TKey JEAOBHPGMKJ, Func<global::BGNOPMFAGGO<TValue>> IJGKMEHDKNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x1EDA330", Offset = "0x1ED9130", VA = "0x181EDA330")]
	public global::BGNOPMFAGGO<TValue> BOMKAOKNBNG<TValue>(TKey JEAOBHPGMKJ, Func<global::BGNOPMFAGGO<TValue>> IJGKMEHDKNP, TimeSpan JIHONPACDIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2BA30B0", Offset = "0x2BA1EB0", VA = "0x182BA30B0")]
	public bool IPBNHGALMCN(TKey JEAOBHPGMKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2BA3640", Offset = "0x2BA2440", VA = "0x182BA3640")]
	public int PIGBGNALAFH(Predicate<TKey> AHFIFMBHKBJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2BA1E80", Offset = "0x2BA0C80", VA = "0x182BA1E80")]
	public void BANKNLGGGFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2BA2CA0", Offset = "0x2BA1AA0", VA = "0x182BA2CA0")]
	private void GAKAKCFHKHA(OGBCNDCJIKL ONHKFBDBOAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2BA2800", Offset = "0x2BA1600", VA = "0x182BA2800")]
	private void EHEIGBKCJJK(OGBCNDCJIKL ONHKFBDBOAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2BA3490", Offset = "0x2BA2290", VA = "0x182BA3490")]
	private void LIBFIJFNEHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2BA2040", Offset = "0x2BA0E40", VA = "0x182BA2040")]
	private bool CPHLOHHNDGE(OGBCNDCJIKL ONHKFBDBOAK)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class DLELAMAGEBO
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static byte[] GJIBIPFNGFK;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private static int DIHKALOCDCB;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static int LFHDFLOBKAF;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static BigInteger FNIOAIDKCMO;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4219D0", Offset = "0x4207D0", VA = "0x1804219D0")]
	public DLELAMAGEBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3CF4030", Offset = "0x3CF2E30", VA = "0x183CF4030")]
	private static string KGDDMKENHCD(byte[] DIHLDHDCJIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3CF3D00", Offset = "0x3CF2B00", VA = "0x183CF3D00")]
	public static string GAOFMFFNDED(byte[] PAJKEDJCHEF, bool GDFPKOHPJFN)
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
		[Cpp2IlInjected.Address(RVA = "0x4219D0", Offset = "0x4207D0", VA = "0x1804219D0")]
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
