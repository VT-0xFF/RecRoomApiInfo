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
		private struct AHADGOEDJDL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public string GHPHAKNHGNN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public FDFGBMEHONB DFOHOMMNCNI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public float? HAGCGCFMAEJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public float? CJMHDKDNEKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public IDisposable PINLEPGDEDL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class DFBNANBDDHO : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x5131A0", Offset = "0x5117A0", VA = "0x1805131A0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x5131A0", Offset = "0x5117A0", VA = "0x1805131A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x513210", Offset = "0x511810", VA = "0x180513210")]
			[DebuggerHidden]
			public DFBNANBDDHO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x513200", Offset = "0x511800", VA = "0x180513200", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x2075EE0", Offset = "0x20744E0", VA = "0x182075EE0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x20760B0", Offset = "0x20746B0", VA = "0x1820760B0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class OICFOPHKBPJ : IEnumerator<object>, IEnumerator, IDisposable
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
			public IABAIOOKIMF promise;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x5131A0", Offset = "0x5117A0", VA = "0x1805131A0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x5131A0", Offset = "0x5117A0", VA = "0x1805131A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x513210", Offset = "0x511810", VA = "0x180513210")]
			[DebuggerHidden]
			public OICFOPHKBPJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x513200", Offset = "0x511800", VA = "0x180513200", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x20766F0", Offset = "0x2074CF0", VA = "0x1820766F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2076750", Offset = "0x2074D50", VA = "0x182076750", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private List<AHADGOEDJDL> MAICFPBLIMB;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool KEIHJMFNJKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x624140", Offset = "0x622740", VA = "0x180624140")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x6B3920", Offset = "0x6B1F20", VA = "0x1806B3920")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x2075CE0", Offset = "0x20742E0", VA = "0x182075CE0")]
		public static AsyncBatch Create(Transform EPJKFCLNEED)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2075E00", Offset = "0x2074400", VA = "0x182075E00")]
		[IteratorStateMachine(typeof(DFBNANBDDHO))]
		private IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2075BC0", Offset = "0x20741C0", VA = "0x182075BC0")]
		public void Add(string BCICIJMKKJI, FDFGBMEHONB OOLNGCNGGEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2075A00", Offset = "0x2074000", VA = "0x182075A00")]
		public void Add(string BCICIJMKKJI, IEnumerator FAMLNKIKMGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2075D70", Offset = "0x2074370", VA = "0x182075D70")]
		[IteratorStateMachine(typeof(OICFOPHKBPJ))]
		private IEnumerator LFMNKJBMKIM(IABAIOOKIMF OOLNGCNGGEE, IEnumerator FAMLNKIKMGG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2075E70", Offset = "0x2074470", VA = "0x182075E70")]
		public AsyncBatch()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class HLJBADINJNP<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class GBMFNCOAMKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TKey FGHCCNDFKNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public FDFGBMEHONB DFOHOMMNCNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public DateTime FECOGJLDJNE;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9587B0", Offset = "0x956DB0", VA = "0x1809587B0")]
		public GBMFNCOAMKO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class IPDGFFNPPPP<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public global::HLJBADINJNP<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public TKey key;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9587B0", Offset = "0x956DB0", VA = "0x1809587B0")]
		public IPDGFFNPPPP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class NCEIOOEAIBP<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public GBMFNCOAMKO cacheEntry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public IPDGFFNPPPP<TValue> CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9587B0", Offset = "0x956DB0", VA = "0x1809587B0")]
		public NCEIOOEAIBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3F40A20", Offset = "0x3F3F020", VA = "0x183F40A20")]
		internal void <SetPromise>b__0(string e)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<TKey, GBMFNCOAMKO> OIPPJOHJGLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private LinkedList<GBMFNCOAMKO> CFDOPAPJJGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private LinkedList<GBMFNCOAMKO> IHFBJABPOFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int ALGIFJOPJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool ADLMGCOAAAL;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public ICollection<TKey> MHLNPIMILBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1CC4B00", Offset = "0x1CC3100", VA = "0x181CC4B00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3F3ACD0", Offset = "0x3F392D0", VA = "0x183F3ACD0")]
	public HLJBADINJNP([Optional] int? ALGIFJOPJHO, bool ADLMGCOAAAL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1CBDE50", Offset = "0x1CBC450", VA = "0x181CBDE50")]
	public bool FHLBMHLNIGN(TKey DOICKNFOJNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0xDED9C0", Offset = "0xDEBFC0", VA = "0x180DED9C0")]
	public global::ANHHADAADKH<TValue> KODEOBPLBIN<TValue>(TKey DOICKNFOJNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3601470", Offset = "0x35FFA70", VA = "0x183601470")]
	public void EJJLLDPADIH<TValue>(TKey DOICKNFOJNK, TValue BEOHMGPJCII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3601550", Offset = "0x35FFB50", VA = "0x183601550")]
	public void EJJLLDPADIH<TValue>(TKey DOICKNFOJNK, TValue BEOHMGPJCII, TimeSpan PLEKGLKJPMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3602720", Offset = "0x3600D20", VA = "0x183602720")]
	public void EMNMELJJMIL<TValue>(TKey DOICKNFOJNK, global::ANHHADAADKH<TValue> OOLNGCNGGEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3601CF0", Offset = "0x36002F0", VA = "0x183601CF0")]
	public void EMNMELJJMIL<TValue>(TKey DOICKNFOJNK, global::ANHHADAADKH<TValue> OOLNGCNGGEE, TimeSpan PLEKGLKJPMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0xDED2B0", Offset = "0xDEB8B0", VA = "0x180DED2B0")]
	public global::ANHHADAADKH<TValue> FMNGPAEFKHA<TValue>(TKey DOICKNFOJNK, Func<global::ANHHADAADKH<TValue>> HHOIOAPEKLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0xDED210", Offset = "0xDEB810", VA = "0x180DED210")]
	public global::ANHHADAADKH<TValue> FMNGPAEFKHA<TValue>(TKey DOICKNFOJNK, Func<global::ANHHADAADKH<TValue>> HHOIOAPEKLG, TimeSpan PLEKGLKJPMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3F39930", Offset = "0x3F37F30", VA = "0x183F39930")]
	public bool FJHOKKOHPIB(TKey DOICKNFOJNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3F3A4F0", Offset = "0x3F38AF0", VA = "0x183F3A4F0")]
	public int LPFCNHDGDBJ(Predicate<TKey> HHCNJNDHAND)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3F399B0", Offset = "0x3F37FB0", VA = "0x183F399B0")]
	public void GMBCIADOMKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3F39C30", Offset = "0x3F38230", VA = "0x183F39C30")]
	private void KILNEJLAFMB(GBMFNCOAMKO KGNGAPELBDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3F39120", Offset = "0x3F37720", VA = "0x183F39120")]
	private void BHEILFFMGKF(GBMFNCOAMKO KGNGAPELBDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3F38DC0", Offset = "0x3F373C0", VA = "0x183F38DC0")]
	private void AFAPIELMCHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3F3A890", Offset = "0x3F38E90", VA = "0x183F3A890")]
	private bool NOAMDNMKIEK(GBMFNCOAMKO KGNGAPELBDE)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class KKINEKHOKMG
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static byte[] DOJNIBDEPHD;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private static int KFPMCEOFNHF;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static int FPHJGLDCBHD;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static BigInteger HMCNEAFPECA;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x513010", Offset = "0x511610", VA = "0x180513010")]
	public KKINEKHOKMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2076430", Offset = "0x2074A30", VA = "0x182076430")]
	private static string IOLHAJOLOLL(byte[] CGENIFKMPBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2076100", Offset = "0x2074700", VA = "0x182076100")]
	public static string FFHDEGOGLMA(byte[] LDGCJAPEANM, bool ONIHJAEONNB)
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
		[Cpp2IlInjected.Address(RVA = "0x513010", Offset = "0x511610", VA = "0x180513010")]
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
