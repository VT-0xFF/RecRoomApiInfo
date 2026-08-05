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
		private struct NNCLAKNDBPH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public string ODPLKINLCEK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public HAKBKGDIMMA HBBJKGPMEEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public float? LEBAFGLKHDK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public float? LCBDIJHCIMG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public IDisposable LHLICOOKONJ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class FPIGMGIKLAP : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x5271C0", Offset = "0x5263C0", VA = "0x1805271C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x5271C0", Offset = "0x5263C0", VA = "0x1805271C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6387D0", Offset = "0x6379D0", VA = "0x1806387D0")]
			[DebuggerHidden]
			public FPIGMGIKLAP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x527E80", Offset = "0x527080", VA = "0x180527E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x4C24560", Offset = "0x4C23760", VA = "0x184C24560", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x4C24730", Offset = "0x4C23930", VA = "0x184C24730", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class ICCKDGKAADG : IEnumerator<object>, IEnumerator, IDisposable
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
			public FLLJLIAPHLF promise;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x5271C0", Offset = "0x5263C0", VA = "0x1805271C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x5271C0", Offset = "0x5263C0", VA = "0x1805271C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6387D0", Offset = "0x6379D0", VA = "0x1806387D0")]
			[DebuggerHidden]
			public ICCKDGKAADG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x527E80", Offset = "0x527080", VA = "0x180527E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x4C24780", Offset = "0x4C23980", VA = "0x184C24780", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x4C247E0", Offset = "0x4C239E0", VA = "0x184C247E0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private List<NNCLAKNDBPH> LCFIICBNHCJ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool PEFJEEBPCFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x527190", Offset = "0x526390", VA = "0x180527190")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x6AE560", Offset = "0x6AD760", VA = "0x1806AE560")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x4C24360", Offset = "0x4C23560", VA = "0x184C24360")]
		public static AsyncBatch Create(Transform KJAPOBPIAAM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x4C24480", Offset = "0x4C23680", VA = "0x184C24480")]
		[IteratorStateMachine(typeof(FPIGMGIKLAP))]
		private IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x4C24240", Offset = "0x4C23440", VA = "0x184C24240")]
		public void Add(string OJIMLEPHDJI, HAKBKGDIMMA FKBBEAOAIAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4C24080", Offset = "0x4C23280", VA = "0x184C24080")]
		public void Add(string OJIMLEPHDJI, IEnumerator GDEJOMOOBBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4C243F0", Offset = "0x4C235F0", VA = "0x184C243F0")]
		[IteratorStateMachine(typeof(ICCKDGKAADG))]
		private IEnumerator HOKMFNNFOPL(FLLJLIAPHLF FKBBEAOAIAA, IEnumerator GDEJOMOOBBF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4C244F0", Offset = "0x4C236F0", VA = "0x184C244F0")]
		public AsyncBatch()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class GDPDGEHJJIO<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class FPKPNCEPEHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TKey MHHPHCDMEDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public HAKBKGDIMMA HBBJKGPMEEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public DateTime LBMGGCFEHOG;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1BB4F60", Offset = "0x1BB4160", VA = "0x181BB4F60")]
		public FPKPNCEPEHG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class NCHMMIDJEEN<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public global::GDPDGEHJJIO<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public TKey key;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x1BB4F60", Offset = "0x1BB4160", VA = "0x181BB4F60")]
		public NCHMMIDJEEN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class DONKIJPALLN<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public FPKPNCEPEHG cacheEntry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public NCHMMIDJEEN<TValue> CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1BB4F60", Offset = "0x1BB4160", VA = "0x181BB4F60")]
		public DONKIJPALLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2243A40", Offset = "0x2242C40", VA = "0x182243A40")]
		internal void <SetPromise>b__0(string e)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<TKey, FPKPNCEPEHG> EIGKFKBICKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private LinkedList<FPKPNCEPEHG> PLAGBIHJHLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private LinkedList<FPKPNCEPEHG> JJPAONBKFFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int HLGBIHKJDPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool MGKADKOEBEB;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public ICollection<TKey> AJLNLKIBAJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2247CC0", Offset = "0x2246EC0", VA = "0x182247CC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2248440", Offset = "0x2247640", VA = "0x182248440")]
	public GDPDGEHJJIO([Optional] int? HLGBIHKJDPH, bool MGKADKOEBEB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2247780", Offset = "0x2246980", VA = "0x182247780")]
	public bool HDNMHHKPHPF(TKey FOOEPPOEAPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2057220", Offset = "0x2056420", VA = "0x182057220")]
	public global::HEDCDMAPDEO<TValue> LGJHKCMJDOC<TValue>(TKey FOOEPPOEAPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2593B90", Offset = "0x2592D90", VA = "0x182593B90")]
	public void EDJCKHEKELA<TValue>(TKey FOOEPPOEAPA, TValue EOEMKDLOAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2593AD0", Offset = "0x2592CD0", VA = "0x182593AD0")]
	public void EDJCKHEKELA<TValue>(TKey FOOEPPOEAPA, TValue EOEMKDLOAGI, TimeSpan PDLHPPEAOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x25946B0", Offset = "0x25938B0", VA = "0x1825946B0")]
	public void GCMOLNIIDPM<TValue>(TKey FOOEPPOEAPA, global::HEDCDMAPDEO<TValue> FKBBEAOAIAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2594760", Offset = "0x2593960", VA = "0x182594760")]
	public void GCMOLNIIDPM<TValue>(TKey FOOEPPOEAPA, global::HEDCDMAPDEO<TValue> FKBBEAOAIAA, TimeSpan PDLHPPEAOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2056C20", Offset = "0x2055E20", VA = "0x182056C20")]
	public global::HEDCDMAPDEO<TValue> ABAFGFDJANF<TValue>(TKey FOOEPPOEAPA, Func<global::HEDCDMAPDEO<TValue>> MENFLKGEHGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2056A30", Offset = "0x2055C30", VA = "0x182056A30")]
	public global::HEDCDMAPDEO<TValue> ABAFGFDJANF<TValue>(TKey FOOEPPOEAPA, Func<global::HEDCDMAPDEO<TValue>> MENFLKGEHGG, TimeSpan PDLHPPEAOMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2247700", Offset = "0x2246900", VA = "0x182247700")]
	public bool FPHPJLPLMOJ(TKey FOOEPPOEAPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2246950", Offset = "0x2245B50", VA = "0x182246950")]
	public int BNPAEJBNLPK(Predicate<TKey> OKAPCBMDLGK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x22470A0", Offset = "0x22462A0", VA = "0x1822470A0")]
	public void FGLHFGIEJKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2247130", Offset = "0x2246330", VA = "0x182247130")]
	private void FHHIKFCPBIB(FPKPNCEPEHG LMCLFBNJJMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x22466A0", Offset = "0x22458A0", VA = "0x1822466A0")]
	private void BJONNEHIPBC(FPKPNCEPEHG LMCLFBNJJMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2247960", Offset = "0x2246B60", VA = "0x182247960")]
	private void HEKLCAAADBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2247E20", Offset = "0x2247020", VA = "0x182247E20")]
	private bool LJKNHICFLCD(FPKPNCEPEHG LMCLFBNJJMO)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class PEGOPLHHMHI
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static byte[] HIBFFCCJJHD;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private static int BICBCGELOBK;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static int ILHMFLHJGFF;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static BigInteger OJJMNJJEBED;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	public PEGOPLHHMHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4C24B60", Offset = "0x4C23D60", VA = "0x184C24B60")]
	private static string MCCHLMPJJNK(byte[] DCOPGELFIOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4C24830", Offset = "0x4C23A30", VA = "0x184C24830")]
	public static string ACFPKMGBPMA(byte[] GMBNEFEOHLO, bool EDLKFPFOADI)
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
		[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
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
