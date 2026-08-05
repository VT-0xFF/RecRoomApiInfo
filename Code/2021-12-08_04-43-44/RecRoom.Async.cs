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
		private struct CDJBKJPBOAE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public string OPMLDJHPFMG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public IDJKGJMBBAG FPFCCFPNOHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public float? LGFAEFNELOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public float? NEMBLFBDNNP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public IDisposable ADDMELOMEBE;
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class HLBCJNOLMLH : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BF590", VA = "0x1804C0190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BF590", VA = "0x1804C0190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6A4230", Offset = "0x6A3630", VA = "0x1806A4230")]
			[DebuggerHidden]
			public HLBCJNOLMLH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x4C0E00", Offset = "0x4C0200", VA = "0x1804C0E00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x43E3B70", Offset = "0x43E2F70", VA = "0x1843E3B70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x43E3D40", Offset = "0x43E3140", VA = "0x1843E3D40", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class CHOLFBCANNF : IEnumerator<object>, IEnumerator, IDisposable
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
			public HHHMAENMOAP promise;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BF590", VA = "0x1804C0190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BF590", VA = "0x1804C0190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6A4230", Offset = "0x6A3630", VA = "0x1806A4230")]
			[DebuggerHidden]
			public CHOLFBCANNF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x4C0E00", Offset = "0x4C0200", VA = "0x1804C0E00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x43E3AD0", Offset = "0x43E2ED0", VA = "0x1843E3AD0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x43E3B20", Offset = "0x43E2F20", VA = "0x1843E3B20", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private List<CDJBKJPBOAE> GHGEKKMPIMM;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool MBIGLFKIBAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x4C0160", Offset = "0x4BF560", VA = "0x1804C0160")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x5C1940", Offset = "0x5C0D40", VA = "0x1805C1940")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x43E3910", Offset = "0x43E2D10", VA = "0x1843E3910")]
		public static AsyncBatch Create(Transform CFLNPJDNDAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x43E3A10", Offset = "0x43E2E10", VA = "0x1843E3A10")]
		[IteratorStateMachine(typeof(HLBCJNOLMLH))]
		private IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x43E3820", Offset = "0x43E2C20", VA = "0x1843E3820")]
		public void Add(string LADOLLMJDDF, IDJKGJMBBAG JDMAEGNPLGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x43E36B0", Offset = "0x43E2AB0", VA = "0x1843E36B0")]
		public void Add(string LADOLLMJDDF, IEnumerator NNHFANOCNOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x43E39A0", Offset = "0x43E2DA0", VA = "0x1843E39A0")]
		[IteratorStateMachine(typeof(CHOLFBCANNF))]
		private IEnumerator POEMMHCFMCB(HHHMAENMOAP JDMAEGNPLGI, IEnumerator NNHFANOCNOO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x43E3A70", Offset = "0x43E2E70", VA = "0x1843E3A70")]
		public AsyncBatch()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class FJLDFPKJFIJ<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class JDMOMPCMNGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TKey BIOOMABDFDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public IDJKGJMBBAG FPFCCFPNOHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public DateTime LGHKANHJIIH;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1612F10", Offset = "0x1612310", VA = "0x181612F10")]
		public JDMOMPCMNGJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class LOLJMCEKJOJ<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public global::FJLDFPKJFIJ<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public TKey key;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x1612F10", Offset = "0x1612310", VA = "0x181612F10")]
		public LOLJMCEKJOJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class DGNNJEJHDFC<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public JDMOMPCMNGJ cacheEntry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public LOLJMCEKJOJ<TValue> CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1612F10", Offset = "0x1612310", VA = "0x181612F10")]
		public DGNNJEJHDFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3533E90", Offset = "0x3533290", VA = "0x183533E90")]
		internal void <SetPromise>b__0(string e)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<TKey, JDMOMPCMNGJ> OENDHLMDJIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private LinkedList<JDMOMPCMNGJ> KEADIEGALHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private LinkedList<JDMOMPCMNGJ> ICCPHAOEKJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int BPGPMHDIHCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool DAEDHJKHDIE;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public ICollection<TKey> GEOELHJOFPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1A586C0", Offset = "0x1A57AC0", VA = "0x181A586C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3538120", Offset = "0x3537520", VA = "0x183538120")]
	public FJLDFPKJFIJ([Optional] int? BPGPMHDIHCG, bool DAEDHJKHDIE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1A587A0", Offset = "0x1A57BA0", VA = "0x181A587A0")]
	public bool NLINLGFDKHI(TKey NDLDFCGGHEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x25797C0", Offset = "0x2578BC0", VA = "0x1825797C0")]
	public global::PMGAAIBIJNM<TValue> OBEGCGOHFBH<TValue>(TKey NDLDFCGGHEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x202E680", Offset = "0x202DA80", VA = "0x18202E680")]
	public void LJJDCFHNDCJ<TValue>(TKey NDLDFCGGHEC, TValue IFBOOLFAOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x202E5C0", Offset = "0x202D9C0", VA = "0x18202E5C0")]
	public void LJJDCFHNDCJ<TValue>(TKey NDLDFCGGHEC, TValue IFBOOLFAOLF, TimeSpan HDBOACHDEFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x202DEB0", Offset = "0x202D2B0", VA = "0x18202DEB0")]
	public void JBBENNJIOPH<TValue>(TKey NDLDFCGGHEC, global::PMGAAIBIJNM<TValue> JDMAEGNPLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x202DB80", Offset = "0x202CF80", VA = "0x18202DB80")]
	public void JBBENNJIOPH<TValue>(TKey NDLDFCGGHEC, global::PMGAAIBIJNM<TValue> JDMAEGNPLGI, TimeSpan HDBOACHDEFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2578FA0", Offset = "0x25783A0", VA = "0x182578FA0")]
	public global::PMGAAIBIJNM<TValue> DLLIDMKGPBP<TValue>(TKey NDLDFCGGHEC, Func<global::PMGAAIBIJNM<TValue>> PDMHFCNBCJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2578E60", Offset = "0x2578260", VA = "0x182578E60")]
	public global::PMGAAIBIJNM<TValue> DLLIDMKGPBP<TValue>(TKey NDLDFCGGHEC, Func<global::PMGAAIBIJNM<TValue>> PDMHFCNBCJO, TimeSpan HDBOACHDEFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3536080", Offset = "0x3535480", VA = "0x183536080")]
	public bool AOJGMCBPBFH(TKey NDLDFCGGHEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3536C40", Offset = "0x3536040", VA = "0x183536C40")]
	public int GEFPIKLCKAM(Predicate<TKey> HBCKAIFFEOP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x35366D0", Offset = "0x3535AD0", VA = "0x1835366D0")]
	public void ELLPAGIADBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x35362F0", Offset = "0x35356F0", VA = "0x1835362F0")]
	private void CKFJGJCKCCO(JDMOMPCMNGJ IFKDNNOGGKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3537CB0", Offset = "0x35370B0", VA = "0x183537CB0")]
	private void ODIFDNCAILO(JDMOMPCMNGJ IFKDNNOGGKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x35373F0", Offset = "0x35367F0", VA = "0x1835373F0")]
	private void KAHKAAJODFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3537110", Offset = "0x3536510", VA = "0x183537110")]
	private bool IDLHKJDJLMP(JDMOMPCMNGJ IFKDNNOGGKK)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class LFKMCGFPHOI
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static byte[] OOHBEGEHNOI;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private static int BNIOKLHNMMG;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static int CGJHMHBADGI;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static BigInteger ADAGEDNPLLD;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4C29D0", Offset = "0x4C1DD0", VA = "0x1804C29D0")]
	public LFKMCGFPHOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x43E40C0", Offset = "0x43E34C0", VA = "0x1843E40C0")]
	private static string KKMKMKDJDIC(byte[] IHCAKNPGPJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x43E3D90", Offset = "0x43E3190", VA = "0x1843E3D90")]
	public static string CIJBPMJKAHN(byte[] CBCDDOHAMCB, bool PPCELFHNGKH)
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
		[Cpp2IlInjected.Address(RVA = "0x4C29D0", Offset = "0x4C1DD0", VA = "0x1804C29D0")]
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
