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
		private struct ELGOHHPFOIM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public string PDFFKONPKMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public PCDEFPAPNCL EBJFBJOEHEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public float? KJEKKGPGPEJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public float? BKEKECHIPFG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public IDisposable AIKGJONFKAA;
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class FPIHFOBPOIH : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x5221C0", Offset = "0x520FC0", VA = "0x1805221C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x5221C0", Offset = "0x520FC0", VA = "0x1805221C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x58EB40", Offset = "0x58D940", VA = "0x18058EB40")]
			[DebuggerHidden]
			public FPIHFOBPOIH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x522E80", Offset = "0x521C80", VA = "0x180522E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x4BBDC30", Offset = "0x4BBCA30", VA = "0x184BBDC30", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x4BBDE00", Offset = "0x4BBCC00", VA = "0x184BBDE00", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class FGPCNFBLDHP : IEnumerator<object>, IEnumerator, IDisposable
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
			public NLHJDENEFGK promise;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x5221C0", Offset = "0x520FC0", VA = "0x1805221C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x5221C0", Offset = "0x520FC0", VA = "0x1805221C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x58EB40", Offset = "0x58D940", VA = "0x18058EB40")]
			[DebuggerHidden]
			public FGPCNFBLDHP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x522E80", Offset = "0x521C80", VA = "0x180522E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x4BBDB80", Offset = "0x4BBC980", VA = "0x184BBDB80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x4BBDBE0", Offset = "0x4BBC9E0", VA = "0x184BBDBE0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private List<ELGOHHPFOIM> ILLBPJENCAN;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool OMCHJFIANBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x522190", Offset = "0x520F90", VA = "0x180522190")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x5DB4A0", Offset = "0x5DA2A0", VA = "0x1805DB4A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x4BBDA10", Offset = "0x4BBC810", VA = "0x184BBDA10")]
		public static AsyncBatch Create(Transform ABHIDEANEGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x4BBDAA0", Offset = "0x4BBC8A0", VA = "0x184BBDAA0")]
		[IteratorStateMachine(typeof(FPIHFOBPOIH))]
		private IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x4BBD730", Offset = "0x4BBC530", VA = "0x184BBD730")]
		public void Add(string CLDEJGBBMEF, PCDEFPAPNCL ONDLHLPELBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4BBD850", Offset = "0x4BBC650", VA = "0x184BBD850")]
		public void Add(string CLDEJGBBMEF, IEnumerator BBPJMMENHNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4BBD6A0", Offset = "0x4BBC4A0", VA = "0x184BBD6A0")]
		[IteratorStateMachine(typeof(FGPCNFBLDHP))]
		private IEnumerator AHMHOGMNKDH(NLHJDENEFGK ONDLHLPELBB, IEnumerator BBPJMMENHNH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4BBDB10", Offset = "0x4BBC910", VA = "0x184BBDB10")]
		public AsyncBatch()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class HPFFJGFANAK<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class GGKAGJPDMME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TKey EKMCGMDHAGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public PCDEFPAPNCL EBJFBJOEHEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public DateTime BNDKFKNMKGC;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x25FD1B0", Offset = "0x25FBFB0", VA = "0x1825FD1B0")]
		public GGKAGJPDMME()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class EBEPHODLKKP<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public global::HPFFJGFANAK<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public TKey key;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x25FD1B0", Offset = "0x25FBFB0", VA = "0x1825FD1B0")]
		public EBEPHODLKKP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class KMLGBEIMPNJ<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public GGKAGJPDMME cacheEntry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public EBEPHODLKKP<TValue> CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x25FD1B0", Offset = "0x25FBFB0", VA = "0x1825FD1B0")]
		public KMLGBEIMPNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3DD7F10", Offset = "0x3DD6D10", VA = "0x183DD7F10")]
		internal void <SetPromise>b__0(string e)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<TKey, GGKAGJPDMME> BBEJNPHIANB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private LinkedList<GGKAGJPDMME> PNNMNMFDGIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private LinkedList<GGKAGJPDMME> AAGDKCHHHFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int ICNIBNEMMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool DCMEBNGEBHB;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public ICollection<TKey> GCKOBJPDJFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3483800", Offset = "0x3482600", VA = "0x183483800")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3DCC030", Offset = "0x3DCAE30", VA = "0x183DCC030")]
	public HPFFJGFANAK([Optional] int? ICNIBNEMMGF, bool DCMEBNGEBHB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3483A80", Offset = "0x3482880", VA = "0x183483A80")]
	public bool DAAGNBINBBN(TKey IFKOMGEEEMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2EFED00", Offset = "0x2EFDB00", VA = "0x182EFED00")]
	public global::CBNPJNGNOBA<TValue> FENLLMNMOEI<TValue>(TKey IFKOMGEEEMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3413430", Offset = "0x3412230", VA = "0x183413430")]
	public void PCNJDBECILG<TValue>(TKey IFKOMGEEEMC, TValue PEPOHKCFAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3413510", Offset = "0x3412310", VA = "0x183413510")]
	public void PCNJDBECILG<TValue>(TKey IFKOMGEEEMC, TValue PEPOHKCFAOG, TimeSpan HPFFMMIBJKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3412CB0", Offset = "0x3411AB0", VA = "0x183412CB0")]
	public void PBKLIMIACBC<TValue>(TKey IFKOMGEEEMC, global::CBNPJNGNOBA<TValue> ONDLHLPELBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3412D60", Offset = "0x3411B60", VA = "0x183412D60")]
	public void PBKLIMIACBC<TValue>(TKey IFKOMGEEEMC, global::CBNPJNGNOBA<TValue> ONDLHLPELBB, TimeSpan HPFFMMIBJKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2EFF480", Offset = "0x2EFE280", VA = "0x182EFF480")]
	public global::CBNPJNGNOBA<TValue> MEBKNGENFEA<TValue>(TKey IFKOMGEEEMC, Func<global::CBNPJNGNOBA<TValue>> KNHAGMGHMKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2EFF290", Offset = "0x2EFE090", VA = "0x182EFF290")]
	public global::CBNPJNGNOBA<TValue> MEBKNGENFEA<TValue>(TKey IFKOMGEEEMC, Func<global::CBNPJNGNOBA<TValue>> KNHAGMGHMKF, TimeSpan HPFFMMIBJKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3DCBDD0", Offset = "0x3DCABD0", VA = "0x183DCBDD0")]
	public bool OGCMIFMLPGF(TKey IFKOMGEEEMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3DCABA0", Offset = "0x3DC99A0", VA = "0x183DCABA0")]
	public int LEHOAJGPLFC(Predicate<TKey> LFHECFFPPJG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3DC9F70", Offset = "0x3DC8D70", VA = "0x183DC9F70")]
	public void GJNEFCAFABC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3DCB9F0", Offset = "0x3DCA7F0", VA = "0x183DCB9F0")]
	private void OCKIEJDEBLJ(GGKAGJPDMME OAOOHEOOPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3DCA640", Offset = "0x3DC9440", VA = "0x183DCA640")]
	private void KKGCLCJADDK(GGKAGJPDMME OAOOHEOOPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3DCB2F0", Offset = "0x3DCA0F0", VA = "0x183DCB2F0")]
	private void MOBCACNJGOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3DCA260", Offset = "0x3DC9060", VA = "0x183DCA260")]
	private bool IOPKHEJLLOA(GGKAGJPDMME OAOOHEOOPGM)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class PNNMOCCLFDL
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static byte[] MBBLNMFMFMG;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private static int MGBCGAMEIAA;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static int GGINOEAOLGL;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static BigInteger FIINFAJLNBA;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	public PNNMOCCLFDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4BBDE50", Offset = "0x4BBCC50", VA = "0x184BBDE50")]
	private static string NFPHDFCNCGP(byte[] BAHCPBFJIGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4BBDF50", Offset = "0x4BBCD50", VA = "0x184BBDF50")]
	public static string NLBDLCJIPCH(byte[] IEDOMBJDKEO, bool HAFBALPHMDI)
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
		[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
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
