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
		private struct PECKFFGFBPB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public string HJBLNLINMDO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public GDOLLDLAJJG DJLBDLLCOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public float? MGFHNJGAPGO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public float? GGFGABAFHIB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public IDisposable CNFLMGBFFKN;
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class AMMJFLPFFEP : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x50D610", Offset = "0x50BC10", VA = "0x18050D610", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x50D610", Offset = "0x50BC10", VA = "0x18050D610", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x532760", Offset = "0x530D60", VA = "0x180532760")]
			[DebuggerHidden]
			public AMMJFLPFFEP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x51A920", Offset = "0x518F20", VA = "0x18051A920", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x3233720", Offset = "0x3231D20", VA = "0x183233720", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x32338F0", Offset = "0x3231EF0", VA = "0x1832338F0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class LGHHIFJGLPP : IEnumerator<object>, IEnumerator, IDisposable
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
			public MNKIKGKHNHB promise;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x50D610", Offset = "0x50BC10", VA = "0x18050D610", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x50D610", Offset = "0x50BC10", VA = "0x18050D610", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x532760", Offset = "0x530D60", VA = "0x180532760")]
			[DebuggerHidden]
			public LGHHIFJGLPP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x51A920", Offset = "0x518F20", VA = "0x18051A920", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x3234410", Offset = "0x3232A10", VA = "0x183234410", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x3234470", Offset = "0x3232A70", VA = "0x183234470", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private List<PECKFFGFBPB> LOIBJMJBCFA;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool OHNJNPGAIOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x70A2A0", Offset = "0x7088A0", VA = "0x18070A2A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x70A2B0", Offset = "0x7088B0", VA = "0x18070A2B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x3233C20", Offset = "0x3232220", VA = "0x183233C20")]
		public static AsyncBatch Create(Transform IJHBOGOHCCC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x3233D40", Offset = "0x3232340", VA = "0x183233D40")]
		[IteratorStateMachine(typeof(AMMJFLPFFEP))]
		private IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3233B00", Offset = "0x3232100", VA = "0x183233B00")]
		public void Add(string EIBLJOLNOMI, GDOLLDLAJJG HMGDBPCOADP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3233940", Offset = "0x3231F40", VA = "0x183233940")]
		public void Add(string EIBLJOLNOMI, IEnumerator DDJINGCACCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3233CB0", Offset = "0x32322B0", VA = "0x183233CB0")]
		[IteratorStateMachine(typeof(LGHHIFJGLPP))]
		private IEnumerator NJAMABFBDFD(MNKIKGKHNHB HMGDBPCOADP, IEnumerator DDJINGCACCB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3233DB0", Offset = "0x32323B0", VA = "0x183233DB0")]
		public AsyncBatch()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class FFLLEFPKIHL<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class DHKLBMOADCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TKey EOAEJCJEKMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public GDOLLDLAJJG DJLBDLLCOKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public DateTime BHEHEBPNGIJ;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7B83E0", Offset = "0x7B69E0", VA = "0x1807B83E0")]
		public DHKLBMOADCB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class JABEEGMCMBH<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public global::FFLLEFPKIHL<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public TKey key;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7B83E0", Offset = "0x7B69E0", VA = "0x1807B83E0")]
		public JABEEGMCMBH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class DCAHNDKGMOL<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public DHKLBMOADCB cacheEntry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public JABEEGMCMBH<TValue> CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7B83E0", Offset = "0x7B69E0", VA = "0x1807B83E0")]
		public DCAHNDKGMOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x468C970", Offset = "0x468AF70", VA = "0x18468C970")]
		internal void <SetPromise>b__0(string e)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<TKey, DHKLBMOADCB> DKLFFHDHOPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private LinkedList<DHKLBMOADCB> HNEGKNMEFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private LinkedList<DHKLBMOADCB> EALNHBHKOFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int CBPFDDCGNIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool LOEELCDEOGB;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public ICollection<TKey> EBNFDHNEAOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x13CBA20", Offset = "0x13CA020", VA = "0x1813CBA20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4692E90", Offset = "0x4691490", VA = "0x184692E90")]
	public FFLLEFPKIHL([Optional] int? CBPFDDCGNIK, bool LOEELCDEOGB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x9D4DE0", Offset = "0x9D33E0", VA = "0x1809D4DE0")]
	public bool AIGGAJMBDEI(TKey CAOGILCCJKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0xB70150", Offset = "0xB6E750", VA = "0x180B70150")]
	public global::FPCEKCNKAAO<TValue> AMCPKHJHLML<TValue>(TKey CAOGILCCJKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x44BF310", Offset = "0x44BD910", VA = "0x1844BF310")]
	public void MCPNENBBKNE<TValue>(TKey CAOGILCCJKA, TValue JKOBKIEBPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x44BF250", Offset = "0x44BD850", VA = "0x1844BF250")]
	public void MCPNENBBKNE<TValue>(TKey CAOGILCCJKA, TValue JKOBKIEBPCF, TimeSpan KNLNOMFKCDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x44BF1A0", Offset = "0x44BD7A0", VA = "0x1844BF1A0")]
	public void BGFFKEBPOKN<TValue>(TKey CAOGILCCJKA, global::FPCEKCNKAAO<TValue> HMGDBPCOADP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x44BE770", Offset = "0x44BCD70", VA = "0x1844BE770")]
	public void BGFFKEBPOKN<TValue>(TKey CAOGILCCJKA, global::FPCEKCNKAAO<TValue> HMGDBPCOADP, TimeSpan KNLNOMFKCDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0xB70780", Offset = "0xB6ED80", VA = "0x180B70780")]
	public global::FPCEKCNKAAO<TValue> ONADGEAJJNL<TValue>(TKey CAOGILCCJKA, Func<global::FPCEKCNKAAO<TValue>> LEDJOGMAJPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0xB706E0", Offset = "0xB6ECE0", VA = "0x180B706E0")]
	public global::FPCEKCNKAAO<TValue> ONADGEAJJNL<TValue>(TKey CAOGILCCJKA, Func<global::FPCEKCNKAAO<TValue>> LEDJOGMAJPA, TimeSpan KNLNOMFKCDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4692A80", Offset = "0x4691080", VA = "0x184692A80")]
	public bool PFBLIKHMAGM(TKey CAOGILCCJKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4692330", Offset = "0x4690930", VA = "0x184692330")]
	public int OHBIPDLPOJI(Predicate<TKey> OPOFCPCELFA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4690FB0", Offset = "0x468F5B0", VA = "0x184690FB0")]
	public void EAPDGKCCOIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4691930", Offset = "0x468FF30", VA = "0x184691930")]
	private void FIIMJFBDEGE(DHKLBMOADCB FMPGJCKFCAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4692080", Offset = "0x4690680", VA = "0x184692080")]
	private void JIBNIHIHPPA(DHKLBMOADCB FMPGJCKFCAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4691040", Offset = "0x468F640", VA = "0x184691040")]
	private void FFIDGNFAJDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4692D60", Offset = "0x4691360", VA = "0x184692D60")]
	private bool PJGNKJMKFCM(DHKLBMOADCB FMPGJCKFCAL)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class ELLJCHCKLPK
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static byte[] HCFMLFPGGCP;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private static int NJDNHGIINNA;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static int NHIKDHEJBAF;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static BigInteger NKHCHBBJBBN;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	public ELLJCHCKLPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3233E20", Offset = "0x3232420", VA = "0x183233E20")]
	private static string FLCHPOEFEII(byte[] BFBDMMHDNGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3233F20", Offset = "0x3232520", VA = "0x183233F20")]
	public static string GHPGBPLJMGG(byte[] FBEAOBEALBD, bool NJHPJLGMMPP)
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
		[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
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
