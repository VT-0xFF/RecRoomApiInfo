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
		private struct JHHMECOHHJJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public string KMPNNCBDBPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public CDJPJKPGHKC KCELLIAEHKB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public float? JEEMPMNBGHB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public float? BMBNNEOBBAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public IDisposable MHNHJBBDDNI;
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class LONJEGBOHIE : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x5211C0", Offset = "0x51F9C0", VA = "0x1805211C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x5211C0", Offset = "0x51F9C0", VA = "0x1805211C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6327D0", Offset = "0x630FD0", VA = "0x1806327D0")]
			[DebuggerHidden]
			public LONJEGBOHIE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x521E80", Offset = "0x520680", VA = "0x180521E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x4B15B30", Offset = "0x4B14330", VA = "0x184B15B30", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x4B15D00", Offset = "0x4B14500", VA = "0x184B15D00", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class AIMDGLIGEBG : IEnumerator<object>, IEnumerator, IDisposable
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
			public EMAJIFEKEMH promise;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x5211C0", Offset = "0x51F9C0", VA = "0x1805211C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x5211C0", Offset = "0x51F9C0", VA = "0x1805211C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6327D0", Offset = "0x630FD0", VA = "0x1806327D0")]
			[DebuggerHidden]
			public AIMDGLIGEBG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x521E80", Offset = "0x520680", VA = "0x180521E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x4B155A0", Offset = "0x4B13DA0", VA = "0x184B155A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x4B15600", Offset = "0x4B13E00", VA = "0x184B15600", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private List<JHHMECOHHJJ> NPKIAEEJJEM;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool DOFIHGIMLDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x521190", Offset = "0x51F990", VA = "0x180521190")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x67BE40", Offset = "0x67A640", VA = "0x18067BE40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x4B15930", Offset = "0x4B14130", VA = "0x184B15930")]
		public static AsyncBatch Create(Transform AIECLMDDNDL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x4B15A50", Offset = "0x4B14250", VA = "0x184B15A50")]
		[IteratorStateMachine(typeof(LONJEGBOHIE))]
		private IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x4B15810", Offset = "0x4B14010", VA = "0x184B15810")]
		public void Add(string CBFODBDAPIM, CDJPJKPGHKC LAPKAMHCPGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4B15650", Offset = "0x4B13E50", VA = "0x184B15650")]
		public void Add(string CBFODBDAPIM, IEnumerator NBLBEJBMEPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4B159C0", Offset = "0x4B141C0", VA = "0x184B159C0")]
		[IteratorStateMachine(typeof(AIMDGLIGEBG))]
		private IEnumerator FNIOEPIBLCB(EMAJIFEKEMH LAPKAMHCPGL, IEnumerator NBLBEJBMEPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4B15AC0", Offset = "0x4B142C0", VA = "0x184B15AC0")]
		public AsyncBatch()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class CBEBHPBEDAP<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class BDMPKMGPBCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TKey BNGGPGAGIBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public CDJPJKPGHKC KCELLIAEHKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public DateTime FFECHIONNCG;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1AF7C10", Offset = "0x1AF6410", VA = "0x181AF7C10")]
		public BDMPKMGPBCP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class HKIDOAOKCEG<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public global::CBEBHPBEDAP<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public TKey key;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x1AF7C10", Offset = "0x1AF6410", VA = "0x181AF7C10")]
		public HKIDOAOKCEG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class LEOGJMOEEJA<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public BDMPKMGPBCP cacheEntry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public HKIDOAOKCEG<TValue> CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1AF7C10", Offset = "0x1AF6410", VA = "0x181AF7C10")]
		public LEOGJMOEEJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x35AD8A0", Offset = "0x35AC0A0", VA = "0x1835AD8A0")]
		internal void <SetPromise>b__0(string e)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<TKey, BDMPKMGPBCP> GMGIAPHDHLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private LinkedList<BDMPKMGPBCP> KJNHHBJCONP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private LinkedList<BDMPKMGPBCP> NFFMJNNKIGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int MHCMINAEAFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool IAIGNKDFMBD;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public ICollection<TKey> NEBCCOFIBMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2117C70", Offset = "0x2116470", VA = "0x182117C70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x35A5070", Offset = "0x35A3870", VA = "0x1835A5070")]
	public CBEBHPBEDAP([Optional] int? MHCMINAEAFF, bool IAIGNKDFMBD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x21181C0", Offset = "0x21169C0", VA = "0x1821181C0")]
	public bool FFIBFKMNELM(TKey MHAAPGJKGCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x250DF10", Offset = "0x250C710", VA = "0x18250DF10")]
	public global::HBEENCCJBCB<TValue> GMOPHBLJJLO<TValue>(TKey MHAAPGJKGCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2999460", Offset = "0x2997C60", VA = "0x182999460")]
	public void CPFMDOLCCGC<TValue>(TKey MHAAPGJKGCK, TValue DOBKOKNNFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2999540", Offset = "0x2997D40", VA = "0x182999540")]
	public void CPFMDOLCCGC<TValue>(TKey MHAAPGJKGCK, TValue DOBKOKNNFGA, TimeSpan MEPLBEJBHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2999CE0", Offset = "0x29984E0", VA = "0x182999CE0")]
	public void FCBEAEHALLL<TValue>(TKey MHAAPGJKGCK, global::HBEENCCJBCB<TValue> LAPKAMHCPGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x299A460", Offset = "0x2998C60", VA = "0x18299A460")]
	public void FCBEAEHALLL<TValue>(TKey MHAAPGJKGCK, global::HBEENCCJBCB<TValue> LAPKAMHCPGL, TimeSpan MEPLBEJBHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x250E540", Offset = "0x250CD40", VA = "0x18250E540")]
	public global::HBEENCCJBCB<TValue> JEOPJFNJIED<TValue>(TKey MHAAPGJKGCK, Func<global::HBEENCCJBCB<TValue>> KNBKBKENAKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x250E4A0", Offset = "0x250CCA0", VA = "0x18250E4A0")]
	public global::HBEENCCJBCB<TValue> JEOPJFNJIED<TValue>(TKey MHAAPGJKGCK, Func<global::HBEENCCJBCB<TValue>> KNBKBKENAKB, TimeSpan MEPLBEJBHJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x35A4090", Offset = "0x35A2890", VA = "0x1835A4090")]
	public bool HICPDAONBIK(TKey MHAAPGJKGCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x35A4E00", Offset = "0x35A3600", VA = "0x1835A4E00")]
	public int OKHMNHIMJHH(Predicate<TKey> FECEJNMFDJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x35A3AF0", Offset = "0x35A22F0", VA = "0x1835A3AF0")]
	public void DKOADGNIPCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x35A3570", Offset = "0x35A1D70", VA = "0x1835A3570")]
	private void AGHEPCDOOPP(BDMPKMGPBCP JFKKECACDCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x35A43C0", Offset = "0x35A2BC0", VA = "0x1835A43C0")]
	private void MBOEHDDMNAC(BDMPKMGPBCP JFKKECACDCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x35A3B80", Offset = "0x35A2380", VA = "0x1835A3B80")]
	private void GJBMKJOLNGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x35A3760", Offset = "0x35A1F60", VA = "0x1835A3760")]
	private bool BBGMOEPOMPN(BDMPKMGPBCP JFKKECACDCJ)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class LPHGEELGLMB
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static byte[] GPJANLJHPME;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private static int PPCKGPBBLCP;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static int JEFPLDJMJDE;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static BigInteger ABCMBKBOAFJ;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	public LPHGEELGLMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4B15D50", Offset = "0x4B14550", VA = "0x184B15D50")]
	private static string EOENAFMMDNF(byte[] DOMNMKJGGGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4B15E50", Offset = "0x4B14650", VA = "0x184B15E50")]
	public static string OPCCKPNHHLB(byte[] MIIBCOAJABM, bool NJCHAECDCAB)
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
		[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
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
