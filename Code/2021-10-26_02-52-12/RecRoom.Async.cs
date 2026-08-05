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
		private struct DOCMLLMFIHO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public string DGNFNNLAFAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public NIIPAOBAIGP BCCDCGIEGFK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public float? AIIILKFBHCC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public float? GHGBICBPLGB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public IDisposable BCJLPLDGMEE;
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class HOGOFFHECMI : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x449190", Offset = "0x448390", VA = "0x180449190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x449190", Offset = "0x448390", VA = "0x180449190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x627DE0", Offset = "0x626FE0", VA = "0x180627DE0")]
			[DebuggerHidden]
			public HOGOFFHECMI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x449E00", Offset = "0x449000", VA = "0x180449E00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x40BEBB0", Offset = "0x40BDDB0", VA = "0x1840BEBB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x40BED80", Offset = "0x40BDF80", VA = "0x1840BED80", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class FBMCJBEHIIN : IEnumerator<object>, IEnumerator, IDisposable
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
			public DKPBLMEPKBG promise;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x449190", Offset = "0x448390", VA = "0x180449190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x449190", Offset = "0x448390", VA = "0x180449190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x627DE0", Offset = "0x626FE0", VA = "0x180627DE0")]
			[DebuggerHidden]
			public FBMCJBEHIIN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x449E00", Offset = "0x449000", VA = "0x180449E00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x40BEB10", Offset = "0x40BDD10", VA = "0x1840BEB10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x40BEB60", Offset = "0x40BDD60", VA = "0x1840BEB60", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private List<DOCMLLMFIHO> JCFPBJDHOBH;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool NPNEBPPOKHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x449160", Offset = "0x448360", VA = "0x180449160")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x58D280", Offset = "0x58C480", VA = "0x18058D280")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x40BE950", Offset = "0x40BDB50", VA = "0x1840BE950")]
		public static AsyncBatch Create(Transform KJKCKFBOOEM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x40BEA50", Offset = "0x40BDC50", VA = "0x1840BEA50")]
		[IteratorStateMachine(typeof(HOGOFFHECMI))]
		private IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x40BE860", Offset = "0x40BDA60", VA = "0x1840BE860")]
		public void Add(string ACPMACFHOGK, NIIPAOBAIGP DPPCDABONBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x40BE6F0", Offset = "0x40BD8F0", VA = "0x1840BE6F0")]
		public void Add(string ACPMACFHOGK, IEnumerator MIMKAKANKAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x40BE9E0", Offset = "0x40BDBE0", VA = "0x1840BE9E0")]
		[IteratorStateMachine(typeof(FBMCJBEHIIN))]
		private IEnumerator PGJACOEKNEE(DKPBLMEPKBG DPPCDABONBF, IEnumerator MIMKAKANKAI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x40BEAB0", Offset = "0x40BDCB0", VA = "0x1840BEAB0")]
		public AsyncBatch()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class FCIIBKLGKPK<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class FLEJOPAOJMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TKey KABLCJJGPDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public NIIPAOBAIGP BCCDCGIEGFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public DateTime PBBFKNDDOIN;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x19F4BE0", Offset = "0x19F3DE0", VA = "0x1819F4BE0")]
		public FLEJOPAOJMD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class CFAHJPHGFBI<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public global::FCIIBKLGKPK<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public TKey key;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x19F4BE0", Offset = "0x19F3DE0", VA = "0x1819F4BE0")]
		public CFAHJPHGFBI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class FHCFDCOFPDD<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public FLEJOPAOJMD cacheEntry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public CFAHJPHGFBI<TValue> CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x19F4BE0", Offset = "0x19F3DE0", VA = "0x1819F4BE0")]
		public FHCFDCOFPDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x329F8A0", Offset = "0x329EAA0", VA = "0x18329F8A0")]
		internal void <SetPromise>b__0(string e)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<TKey, FLEJOPAOJMD> IJKHLKJCCGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private LinkedList<FLEJOPAOJMD> GEKBPMAAJAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private LinkedList<FLEJOPAOJMD> MCJNNKADJBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int GNPJEAHCGAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool KNMDCGFDEDP;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public ICollection<TKey> CFBIAKHIFEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x329AB00", Offset = "0x3299D00", VA = "0x18329AB00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x329C3E0", Offset = "0x329B5E0", VA = "0x18329C3E0")]
	public FCIIBKLGKPK([Optional] int? GNPJEAHCGAA, bool KNMDCGFDEDP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x317EB10", Offset = "0x317DD10", VA = "0x18317EB10")]
	public bool COHHGFNBBIJ(TKey KPLFFOGJEBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x253B9D0", Offset = "0x253ABD0", VA = "0x18253B9D0")]
	public global::IJNOJIGJDDE<TValue> NJDHFBMNKFA<TValue>(TKey KPLFFOGJEBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2104310", Offset = "0x2103510", VA = "0x182104310")]
	public void OKIBAGHLIJI<TValue>(TKey KPLFFOGJEBN, TValue DIDEMEECIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x21043F0", Offset = "0x21035F0", VA = "0x1821043F0")]
	public void OKIBAGHLIJI<TValue>(TKey KPLFFOGJEBN, TValue DIDEMEECIEC, TimeSpan CBNOGMMKDMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x21038D0", Offset = "0x2102AD0", VA = "0x1821038D0")]
	public void GOGBAFBHPCJ<TValue>(TKey KPLFFOGJEBN, global::IJNOJIGJDDE<TValue> DPPCDABONBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2103980", Offset = "0x2102B80", VA = "0x182103980")]
	public void GOGBAFBHPCJ<TValue>(TKey KPLFFOGJEBN, global::IJNOJIGJDDE<TValue> DPPCDABONBF, TimeSpan CBNOGMMKDMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x253B390", Offset = "0x253A590", VA = "0x18253B390")]
	public global::IJNOJIGJDDE<TValue> APOLKCNEKCK<TValue>(TKey KPLFFOGJEBN, Func<global::IJNOJIGJDDE<TValue>> CPEAKBFNBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x253B250", Offset = "0x253A450", VA = "0x18253B250")]
	public global::IJNOJIGJDDE<TValue> APOLKCNEKCK<TValue>(TKey KPLFFOGJEBN, Func<global::IJNOJIGJDDE<TValue>> CPEAKBFNBNL, TimeSpan CBNOGMMKDMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x329A150", Offset = "0x3299350", VA = "0x18329A150")]
	public bool ANHDIGNDBJL(TKey KPLFFOGJEBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x329B5B0", Offset = "0x329A7B0", VA = "0x18329B5B0")]
	public int LHHKKGFLMCB(Predicate<TKey> GDFHKDNDPDN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x329AA70", Offset = "0x3299C70", VA = "0x18329AA70")]
	public void EGONGNAPLEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x329BC80", Offset = "0x329AE80", VA = "0x18329BC80")]
	private void NLIMMAGBEEG(FLEJOPAOJMD EPOKGOKEJLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x329ADE0", Offset = "0x3299FE0", VA = "0x18329ADE0")]
	private void LDNPGKAOKEM(FLEJOPAOJMD EPOKGOKEJLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x329A710", Offset = "0x3299910", VA = "0x18329A710")]
	private void DHINELLDJLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x329A300", Offset = "0x3299500", VA = "0x18329A300")]
	private bool BNPKFGPBBBK(FLEJOPAOJMD EPOKGOKEJLO)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class KIIENADHBAP
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static byte[] JHNDOHIGIOO;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private static int MADEGOKLHIN;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static int MONIHPJNDGC;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static BigInteger PDPNCLAKIEF;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x44B9D0", Offset = "0x44ABD0", VA = "0x18044B9D0")]
	public KIIENADHBAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x40BEDD0", Offset = "0x40BDFD0", VA = "0x1840BEDD0")]
	private static string BNMKEPLLJLH(byte[] PADLHGFNBLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x40BEED0", Offset = "0x40BE0D0", VA = "0x1840BEED0")]
	public static string GOGNAPBDLJC(byte[] POCBBJNICOK, bool NLKNEOPMNBJ)
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
		[Cpp2IlInjected.Address(RVA = "0x44B9D0", Offset = "0x44ABD0", VA = "0x18044B9D0")]
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
