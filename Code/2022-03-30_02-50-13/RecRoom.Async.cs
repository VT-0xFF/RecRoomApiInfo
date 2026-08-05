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
		private struct LHJLBGHCAEB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public string DHAKHKDENDC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public HAMIGNOLDMC IDNLEEMOIOH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public float? GAHGCBLAPCG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public float? NEHBEPHCGHG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public IDisposable GILODLAKKOI;
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class IJKBKFEBCGJ : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x5201C0", Offset = "0x51E7C0", VA = "0x1805201C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x5201C0", Offset = "0x51E7C0", VA = "0x1805201C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x5DC2D0", Offset = "0x5DA8D0", VA = "0x1805DC2D0")]
			[DebuggerHidden]
			public IJKBKFEBCGJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x520E80", Offset = "0x51F480", VA = "0x180520E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x4B3EA20", Offset = "0x4B3D020", VA = "0x184B3EA20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x4B3EBF0", Offset = "0x4B3D1F0", VA = "0x184B3EBF0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class GFPEFKBDKOF : IEnumerator<object>, IEnumerator, IDisposable
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
			public CANEJGJNLDJ promise;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x5201C0", Offset = "0x51E7C0", VA = "0x1805201C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x5201C0", Offset = "0x51E7C0", VA = "0x1805201C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x5DC2D0", Offset = "0x5DA8D0", VA = "0x1805DC2D0")]
			[DebuggerHidden]
			public GFPEFKBDKOF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x520E80", Offset = "0x51F480", VA = "0x180520E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x4B3E970", Offset = "0x4B3CF70", VA = "0x184B3E970", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x4B3E9D0", Offset = "0x4B3CFD0", VA = "0x184B3E9D0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private List<LHJLBGHCAEB> CONKKDABFAE;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool IAIOGGPIMFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x520190", Offset = "0x51E790", VA = "0x180520190")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x602FE0", Offset = "0x6015E0", VA = "0x180602FE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x4B3E210", Offset = "0x4B3C810", VA = "0x184B3E210")]
		public static AsyncBatch Create(Transform ODFEOHMNKLG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x4B3E2A0", Offset = "0x4B3C8A0", VA = "0x184B3E2A0")]
		[IteratorStateMachine(typeof(IJKBKFEBCGJ))]
		private IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x4B3E0F0", Offset = "0x4B3C6F0", VA = "0x184B3E0F0")]
		public void Add(string LEOGCMFBAME, HAMIGNOLDMC IKPCHBIFCLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4B3DF30", Offset = "0x4B3C530", VA = "0x184B3DF30")]
		public void Add(string LEOGCMFBAME, IEnumerator BMJCNMPCDFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4B3DEA0", Offset = "0x4B3C4A0", VA = "0x184B3DEA0")]
		[IteratorStateMachine(typeof(GFPEFKBDKOF))]
		private IEnumerator AAOEHIOINEA(CANEJGJNLDJ IKPCHBIFCLH, IEnumerator BMJCNMPCDFF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4B3E310", Offset = "0x4B3C910", VA = "0x184B3E310")]
		public AsyncBatch()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class MDKOAKCDGOL<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class OKBCFJIFMDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TKey PMLMNECINLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public HAMIGNOLDMC IDNLEEMOIOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public DateTime FNIBLKACFOB;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x184D800", Offset = "0x184BE00", VA = "0x18184D800")]
		public OKBCFJIFMDC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class PFGJOIIHJEP<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public global::MDKOAKCDGOL<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public TKey key;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x184D800", Offset = "0x184BE00", VA = "0x18184D800")]
		public PFGJOIIHJEP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class OONMCDNCLDI<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public OKBCFJIFMDC cacheEntry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public PFGJOIIHJEP<TValue> CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x184D800", Offset = "0x184BE00", VA = "0x18184D800")]
		public OONMCDNCLDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3513160", Offset = "0x3511760", VA = "0x183513160")]
		internal void <SetPromise>b__0(string e)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<TKey, OKBCFJIFMDC> GMGDAEPIILD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private LinkedList<OKBCFJIFMDC> DDOELPFJEAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private LinkedList<OKBCFJIFMDC> IMALBJBPCMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int AHNDAKNMCNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool ADKIAACGCGC;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public ICollection<TKey> MHAPOGPMABB
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x26A9520", Offset = "0x26A7B20", VA = "0x1826A9520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x350FFE0", Offset = "0x350E5E0", VA = "0x18350FFE0")]
	public MDKOAKCDGOL([Optional] int? AHNDAKNMCNE, bool ADKIAACGCGC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x26A95C0", Offset = "0x26A7BC0", VA = "0x1826A95C0")]
	public bool NGLKCAMFCPE(TKey DHLOMKIAOHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x25187F0", Offset = "0x2516DF0", VA = "0x1825187F0")]
	public global::OGKKIDEDJHF<TValue> HDGDFPMMFGI<TValue>(TKey DHLOMKIAOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x21F1130", Offset = "0x21EF730", VA = "0x1821F1130")]
	public void HLBMEMHCANB<TValue>(TKey DHLOMKIAOHC, TValue BABHCNCDDFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x21F1070", Offset = "0x21EF670", VA = "0x1821F1070")]
	public void HLBMEMHCANB<TValue>(TKey DHLOMKIAOHC, TValue BABHCNCDDFB, TimeSpan COHPFHLLENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x21F1C60", Offset = "0x21F0260", VA = "0x1821F1C60")]
	public void IGFAAIPKCKC<TValue>(TKey DHLOMKIAOHC, global::OGKKIDEDJHF<TValue> IKPCHBIFCLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x21F2070", Offset = "0x21F0670", VA = "0x1821F2070")]
	public void IGFAAIPKCKC<TValue>(TKey DHLOMKIAOHC, global::OGKKIDEDJHF<TValue> IKPCHBIFCLH, TimeSpan COHPFHLLENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2518E20", Offset = "0x2517420", VA = "0x182518E20")]
	public global::OGKKIDEDJHF<TValue> OFLMPJLLJKB<TValue>(TKey DHLOMKIAOHC, Func<global::OGKKIDEDJHF<TValue>> NPACMEEMDFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2518D80", Offset = "0x2517380", VA = "0x182518D80")]
	public global::OGKKIDEDJHF<TValue> OFLMPJLLJKB<TValue>(TKey DHLOMKIAOHC, Func<global::OGKKIDEDJHF<TValue>> NPACMEEMDFI, TimeSpan COHPFHLLENG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x350F7B0", Offset = "0x350DDB0", VA = "0x18350F7B0")]
	public bool OKJFIGBMPNL(TKey DHLOMKIAOHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x350F060", Offset = "0x350D660", VA = "0x18350F060")]
	public int OIEHCLDCGBB(Predicate<TKey> INOFMADHJMH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x350EFD0", Offset = "0x350D5D0", VA = "0x18350EFD0")]
	public void HPEBFGMNFBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x350F830", Offset = "0x350DE30", VA = "0x18350F830")]
	private void PIAACOBEEBP(OKBCFJIFMDC BDINEIBBFIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x350EA70", Offset = "0x350D070", VA = "0x18350EA70")]
	private void GPDPPIOJNPH(OKBCFJIFMDC BDINEIBBFIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x350E0D0", Offset = "0x350C6D0", VA = "0x18350E0D0")]
	private void CLAMNEEEOPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x350E560", Offset = "0x350CB60", VA = "0x18350E560")]
	private bool FKHDPGAOKJM(OKBCFJIFMDC BDINEIBBFIF)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class EEDIADJHOAL
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static byte[] GGHPKOFMNIO;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private static int KCKCMMJGOCO;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static int BOFMOMDGGBC;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static BigInteger PJEPEPBBIPN;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x522AB0", Offset = "0x5210B0", VA = "0x180522AB0")]
	public EEDIADJHOAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4B3E6B0", Offset = "0x4B3CCB0", VA = "0x184B3E6B0")]
	private static string IAEECNCONGN(byte[] KFLJJIMMFKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4B3E380", Offset = "0x4B3C980", VA = "0x184B3E380")]
	public static string AGDFJGHALKO(byte[] MOPADMGKCOG, bool CNBJECBCBOC)
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
		[Cpp2IlInjected.Address(RVA = "0x522AB0", Offset = "0x5210B0", VA = "0x180522AB0")]
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
