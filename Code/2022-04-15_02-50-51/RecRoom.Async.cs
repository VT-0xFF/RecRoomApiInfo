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
		private struct KNNLKPBFEIH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public string EHPHADKLFCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public GGJFLBABPCA INJCGPOLAOI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public float? GOHEOMAAELI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public float? PDOFPBOFKCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public IDisposable HCDGBCNMOFM;
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class DIEAJHPNMPH : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x527080", Offset = "0x525E80", VA = "0x180527080", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x527080", Offset = "0x525E80", VA = "0x180527080", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x54AC50", Offset = "0x549A50", VA = "0x18054AC50")]
			[DebuggerHidden]
			public DIEAJHPNMPH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x523B30", Offset = "0x522930", VA = "0x180523B30", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x1AB93E0", Offset = "0x1AB81E0", VA = "0x181AB93E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x1AB95B0", Offset = "0x1AB83B0", VA = "0x181AB95B0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class GLIJFCOKODA : IEnumerator<object>, IEnumerator, IDisposable
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
			public LBEDEENLGHL promise;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x527080", Offset = "0x525E80", VA = "0x180527080", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x527080", Offset = "0x525E80", VA = "0x180527080", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x54AC50", Offset = "0x549A50", VA = "0x18054AC50")]
			[DebuggerHidden]
			public GLIJFCOKODA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x523B30", Offset = "0x522930", VA = "0x180523B30", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x1AB9600", Offset = "0x1AB8400", VA = "0x181AB9600", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x1AB9660", Offset = "0x1AB8460", VA = "0x181AB9660", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private List<KNNLKPBFEIH> KIOJLEHHCAC;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool AJNHNOEMLGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x56A5D0", Offset = "0x5693D0", VA = "0x18056A5D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x56A720", Offset = "0x569520", VA = "0x18056A720")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x1AB8BF0", Offset = "0x1AB79F0", VA = "0x181AB8BF0")]
		public static AsyncBatch Create(Transform MGDGFFLAOJF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1AB8D10", Offset = "0x1AB7B10", VA = "0x181AB8D10")]
		[IteratorStateMachine(typeof(DIEAJHPNMPH))]
		private IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1AB8AD0", Offset = "0x1AB78D0", VA = "0x181AB8AD0")]
		public void Add(string OPBNEOMPEGH, GGJFLBABPCA EKLJEEAJMIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1AB8910", Offset = "0x1AB7710", VA = "0x181AB8910")]
		public void Add(string OPBNEOMPEGH, IEnumerator CJPCGLOCIJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1AB8C80", Offset = "0x1AB7A80", VA = "0x181AB8C80")]
		[IteratorStateMachine(typeof(GLIJFCOKODA))]
		private IEnumerator OBCALFNBBKA(LBEDEENLGHL EKLJEEAJMIC, IEnumerator CJPCGLOCIJD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1AB8D80", Offset = "0x1AB7B80", VA = "0x181AB8D80")]
		public AsyncBatch()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class MLJEPFIAHGA<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class JNHPOKCIDPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TKey CMHEHIDHKAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public GGJFLBABPCA INJCGPOLAOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public DateTime PEAPHLENJJH;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x28DB5C0", Offset = "0x28DA3C0", VA = "0x1828DB5C0")]
		public JNHPOKCIDPN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class FHHLMMLCCIN<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public global::MLJEPFIAHGA<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public TKey key;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x28DB5C0", Offset = "0x28DA3C0", VA = "0x1828DB5C0")]
		public FHHLMMLCCIN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class HJMEJPILBHM<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public JNHPOKCIDPN cacheEntry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public FHHLMMLCCIN<TValue> CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x28DB5C0", Offset = "0x28DA3C0", VA = "0x1828DB5C0")]
		public HJMEJPILBHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3A7BD00", Offset = "0x3A7AB00", VA = "0x183A7BD00")]
		internal void <SetPromise>b__0(string e)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<TKey, JNHPOKCIDPN> IKIBNKJFGCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private LinkedList<JNHPOKCIDPN> ILMFMIFHEDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private LinkedList<JNHPOKCIDPN> DKNKHAPJGHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int NPFKJNANKIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool JNMEALIJDOP;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public ICollection<TKey> BOOLDBCADMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3896A10", Offset = "0x3895810", VA = "0x183896A10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3A875B0", Offset = "0x3A863B0", VA = "0x183A875B0")]
	public MLJEPFIAHGA([Optional] int? NPFKJNANKIA, bool JNMEALIJDOP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x37C6020", Offset = "0x37C4E20", VA = "0x1837C6020")]
	public bool HOELKKMDGJI(TKey IIIMPJEHMOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2B38560", Offset = "0x2B37360", VA = "0x182B38560")]
	public global::JDJCJHOOLJN<TValue> ACFGJPDKKMH<TValue>(TKey IIIMPJEHMOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x37394A0", Offset = "0x37382A0", VA = "0x1837394A0")]
	public void JCODMBJCOJN<TValue>(TKey IIIMPJEHMOP, TValue FCGCDNFBIMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3739580", Offset = "0x3738380", VA = "0x183739580")]
	public void JCODMBJCOJN<TValue>(TKey IIIMPJEHMOP, TValue FCGCDNFBIMM, TimeSpan GBLDLKOADON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3739D20", Offset = "0x3738B20", VA = "0x183739D20")]
	public void NLPOOCMJNJC<TValue>(TKey IIIMPJEHMOP, global::JDJCJHOOLJN<TValue> EKLJEEAJMIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x373A4A0", Offset = "0x37392A0", VA = "0x18373A4A0")]
	public void NLPOOCMJNJC<TValue>(TKey IIIMPJEHMOP, global::JDJCJHOOLJN<TValue> EKLJEEAJMIC, TimeSpan GBLDLKOADON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2B38C30", Offset = "0x2B37A30", VA = "0x182B38C30")]
	public global::JDJCJHOOLJN<TValue> FMNDHOIKMAN<TValue>(TKey IIIMPJEHMOP, Func<global::JDJCJHOOLJN<TValue>> JNCJMFMBLJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2B38AF0", Offset = "0x2B378F0", VA = "0x182B38AF0")]
	public global::JDJCJHOOLJN<TValue> FMNDHOIKMAN<TValue>(TKey IIIMPJEHMOP, Func<global::JDJCJHOOLJN<TValue>> JNCJMFMBLJC, TimeSpan GBLDLKOADON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3A87170", Offset = "0x3A85F70", VA = "0x183A87170")]
	public bool MDMFJHECCDC(TKey IIIMPJEHMOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3A859A0", Offset = "0x3A847A0", VA = "0x183A859A0")]
	public int CFENJOFMEGE(Predicate<TKey> OBKLEBMGJFO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3A856A0", Offset = "0x3A844A0", VA = "0x183A856A0")]
	public void CBNDPJOBHAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3A86F80", Offset = "0x3A85D80", VA = "0x183A86F80")]
	private void KIONBDNMFAM(JNHPOKCIDPN CFPNDIKCILA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3A863E0", Offset = "0x3A851E0", VA = "0x183A863E0")]
	private void CNJCOCKLLNP(JNHPOKCIDPN CFPNDIKCILA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3A86840", Offset = "0x3A85640", VA = "0x183A86840")]
	private void JHANAHEBOEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3A85440", Offset = "0x3A84240", VA = "0x183A85440")]
	private bool AJBMPGENJPB(JNHPOKCIDPN CFPNDIKCILA)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class DFPNJGLKJCK
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static byte[] BHKGCCOPMJC;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private static int GBDAOKLIGMK;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static int OHPBAKOKAFL;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static BigInteger DGIAGADGPEN;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	public DFPNJGLKJCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1AB9120", Offset = "0x1AB7F20", VA = "0x181AB9120")]
	private static string JPCMDGFJHKL(byte[] JLGJJNEIJFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1AB8DF0", Offset = "0x1AB7BF0", VA = "0x181AB8DF0")]
	public static string FNPNBMDGJBN(byte[] LPHHCMJDKLK, bool DODMIEKCDBF)
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
		[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
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
