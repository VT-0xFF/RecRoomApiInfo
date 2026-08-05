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
		private struct LCJBMAFFAEC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public string MPKICLFKBCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public BKMNEANDFIL CKMBGACJOCN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public float? IPIMALOHJKD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public float? BAALPKBIAFC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public IDisposable KBEANJJJKIP;
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class BEOPCOOKJHM : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x4E31C0", Offset = "0x4E21C0", VA = "0x1804E31C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x4E31C0", Offset = "0x4E21C0", VA = "0x1804E31C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6D3770", Offset = "0x6D2770", VA = "0x1806D3770")]
			[DebuggerHidden]
			public BEOPCOOKJHM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x4E3E80", Offset = "0x4E2E80", VA = "0x1804E3E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x46C2700", Offset = "0x46C1700", VA = "0x1846C2700", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x46C28D0", Offset = "0x46C18D0", VA = "0x1846C28D0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class NOLOJAIIINA : IEnumerator<object>, IEnumerator, IDisposable
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
			public GMDJOGAHHIL promise;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x4E31C0", Offset = "0x4E21C0", VA = "0x1804E31C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x4E31C0", Offset = "0x4E21C0", VA = "0x1804E31C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6D3770", Offset = "0x6D2770", VA = "0x1806D3770")]
			[DebuggerHidden]
			public NOLOJAIIINA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x4E3E80", Offset = "0x4E2E80", VA = "0x1804E3E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x46C2F10", Offset = "0x46C1F10", VA = "0x1846C2F10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x46C2F70", Offset = "0x46C1F70", VA = "0x1846C2F70", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private List<LCJBMAFFAEC> HMBEBDILOOJ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool CCGNLFKDAJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x4E3190", Offset = "0x4E2190", VA = "0x1804E3190")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x5EAF50", Offset = "0x5E9F50", VA = "0x1805EAF50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x46C2590", Offset = "0x46C1590", VA = "0x1846C2590")]
		public static AsyncBatch Create(Transform DOGKMHLECMH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x46C2620", Offset = "0x46C1620", VA = "0x1846C2620")]
		[IteratorStateMachine(typeof(BEOPCOOKJHM))]
		private IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x46C23E0", Offset = "0x46C13E0", VA = "0x1846C23E0")]
		public void Add(string GKOIMGFECPK, BKMNEANDFIL HGCBPPKJKJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x46C2220", Offset = "0x46C1220", VA = "0x1846C2220")]
		public void Add(string GKOIMGFECPK, IEnumerator LCMJPIGEKKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x46C2500", Offset = "0x46C1500", VA = "0x1846C2500")]
		[IteratorStateMachine(typeof(NOLOJAIIINA))]
		private IEnumerator BJBIGFJDJLM(GMDJOGAHHIL HGCBPPKJKJF, IEnumerator LCMJPIGEKKA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x46C2690", Offset = "0x46C1690", VA = "0x1846C2690")]
		public AsyncBatch()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class BKMKOOJIJGE<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class NJEIBAHPGCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TKey OPCJIONGLGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public BKMNEANDFIL CKMBGACJOCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public DateTime OJFPGANHGJK;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1A526F0", Offset = "0x1A516F0", VA = "0x181A526F0")]
		public NJEIBAHPGCE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class JDEAENDHGGP<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public global::BKMKOOJIJGE<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public TKey key;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x1A526F0", Offset = "0x1A516F0", VA = "0x181A526F0")]
		public JDEAENDHGGP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class IKINOKCDGGK<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public NJEIBAHPGCE cacheEntry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public JDEAENDHGGP<TValue> CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1A526F0", Offset = "0x1A516F0", VA = "0x181A526F0")]
		public IKINOKCDGGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1B7F4A0", Offset = "0x1B7E4A0", VA = "0x181B7F4A0")]
		internal void <SetPromise>b__0(string e)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<TKey, NJEIBAHPGCE> MPGDAHEICII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private LinkedList<NJEIBAHPGCE> JKHGEAKPIMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private LinkedList<NJEIBAHPGCE> CLLINEFGGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int IDMIKHIMKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool HKEPGFKOHJH;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public ICollection<TKey> AMGIMEIEEAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1B70C30", Offset = "0x1B6FC30", VA = "0x181B70C30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1B710A0", Offset = "0x1B700A0", VA = "0x181B710A0")]
	public BKMKOOJIJGE([Optional] int? IDMIKHIMKKJ, bool HKEPGFKOHJH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1B6F130", Offset = "0x1B6E130", VA = "0x181B6F130")]
	public bool DGLDNBOHPEE(TKey GOLKIAIKMMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1C8C330", Offset = "0x1C8B330", VA = "0x181C8C330")]
	public global::IDCJFNACHEM<TValue> FJOCGGIJMGK<TValue>(TKey GOLKIAIKMMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2E7B9B0", Offset = "0x2E7A9B0", VA = "0x182E7B9B0")]
	public void IECDDLMMIHC<TValue>(TKey GOLKIAIKMMJ, TValue NBFFDDDBNPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2E7BA90", Offset = "0x2E7AA90", VA = "0x182E7BA90")]
	public void IECDDLMMIHC<TValue>(TKey GOLKIAIKMMJ, TValue NBFFDDDBNPN, TimeSpan FOALCJPOMGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2E7C8F0", Offset = "0x2E7B8F0", VA = "0x182E7C8F0")]
	public void JGNHMJELFFJ<TValue>(TKey GOLKIAIKMMJ, global::IDCJFNACHEM<TValue> HGCBPPKJKJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2E7C590", Offset = "0x2E7B590", VA = "0x182E7C590")]
	public void JGNHMJELFFJ<TValue>(TKey GOLKIAIKMMJ, global::IDCJFNACHEM<TValue> HGCBPPKJKJF, TimeSpan FOALCJPOMGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x1C8BBE0", Offset = "0x1C8ABE0", VA = "0x181C8BBE0")]
	public global::IDCJFNACHEM<TValue> ADMAJLOFIIC<TValue>(TKey GOLKIAIKMMJ, Func<global::IDCJFNACHEM<TValue>> JKEOPJPFDMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x1C8BB40", Offset = "0x1C8AB40", VA = "0x181C8BB40")]
	public global::IDCJFNACHEM<TValue> ADMAJLOFIIC<TValue>(TKey GOLKIAIKMMJ, Func<global::IDCJFNACHEM<TValue>> JKEOPJPFDMP, TimeSpan FOALCJPOMGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x1B70C60", Offset = "0x1B6FC60", VA = "0x181B70C60")]
	public bool PMCHHOBKDIO(TKey GOLKIAIKMMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x1B70420", Offset = "0x1B6F420", VA = "0x181B70420")]
	public int GBONOLOKNOL(Predicate<TKey> OCFGENAGHHM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1B70690", Offset = "0x1B6F690", VA = "0x181B70690")]
	public void JFKIAFPDGGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1B6FD50", Offset = "0x1B6ED50", VA = "0x181B6FD50")]
	private void FLEDHNBCADL(NJEIBAHPGCE BCGPIMNKDDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1B6F160", Offset = "0x1B6E160", VA = "0x181B6F160")]
	private void FECAAFKMEIA(NJEIBAHPGCE BCGPIMNKDDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1B708D0", Offset = "0x1B6F8D0", VA = "0x181B708D0")]
	private void KJEIOKEDKGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1B6EDA0", Offset = "0x1B6DDA0", VA = "0x181B6EDA0")]
	private bool BGHFDICMAHP(NJEIBAHPGCE BCGPIMNKDDN)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class DFIKEAFJCGD
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static byte[] FPMGPNDCJGI;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private static int HLAPLPHEDOF;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static int DIHDAAMIHIE;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static BigInteger CBFIPIFMBJA;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4E5AB0", Offset = "0x4E4AB0", VA = "0x1804E5AB0")]
	public DFIKEAFJCGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x46C2920", Offset = "0x46C1920", VA = "0x1846C2920")]
	private static string FCGBJJFHIPJ(byte[] DJHKGFLFIEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x46C2A20", Offset = "0x46C1A20", VA = "0x1846C2A20")]
	public static string JDIAMALCPMN(byte[] ONAFAFJGCAI, bool NMLDFLAABOD)
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
		[Cpp2IlInjected.Address(RVA = "0x4E5AB0", Offset = "0x4E4AB0", VA = "0x1804E5AB0")]
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
