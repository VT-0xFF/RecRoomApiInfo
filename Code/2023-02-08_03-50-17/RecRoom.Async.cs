using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Async
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class AsyncBatch : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private struct GBLCKHIFDHI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public string JBOBPFKLKJA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public FFFHIGBANBM EEIIEAAHNBL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public float? JJKJDLDGOGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public float? INFMDAMBEBO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public IDisposable OPPCIDHMKLO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class AHIHAGFBHID : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8CCB00", Offset = "0x8CB900", VA = "0x1808CCB00")]
			[DebuggerHidden]
			public AHIHAGFBHID(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x21DBD40", Offset = "0x21DAB40", VA = "0x1821DBD40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x21DBF40", Offset = "0x21DAD40", VA = "0x1821DBF40", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class HPIFBJPJHJH : IEnumerator<object>, IEnumerator, IDisposable
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
			public HNONHEFEGPD promise;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8CCB00", Offset = "0x8CB900", VA = "0x1808CCB00")]
			[DebuggerHidden]
			public HPIFBJPJHJH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x21DC4B0", Offset = "0x21DB2B0", VA = "0x1821DC4B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x21DC510", Offset = "0x21DB310", VA = "0x1821DC510", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private List<GBLCKHIFDHI> BCKCPDAKLNF;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool OKLOEDGBEMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x88A3B0", Offset = "0x8891B0", VA = "0x18088A3B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x888770", Offset = "0x887570", VA = "0x180888770")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x21DC280", Offset = "0x21DB080", VA = "0x1821DC280")]
		public static AsyncBatch Create(Transform KICGHGEEADG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x21DC3C0", Offset = "0x21DB1C0", VA = "0x1821DC3C0")]
		[IteratorStateMachine(typeof(AHIHAGFBHID))]
		private IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x21DBF80", Offset = "0x21DAD80", VA = "0x1821DBF80")]
		public void Add(string CCEKFDNIAPD, FFFHIGBANBM HOJMPPKDDNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x21DC0B0", Offset = "0x21DAEB0", VA = "0x1821DC0B0")]
		public void Add(string CCEKFDNIAPD, IEnumerator MAFKDKHHJKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x21DC330", Offset = "0x21DB130", VA = "0x1821DC330")]
		[IteratorStateMachine(typeof(HPIFBJPJHJH))]
		private IEnumerator EGJNFMOEMBC(HNONHEFEGPD HOJMPPKDDNK, IEnumerator MAFKDKHHJKH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x21DC430", Offset = "0x21DB230", VA = "0x1821DC430")]
		public AsyncBatch()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class BAKBKLCPPJF<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class ENGEBKHKGCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TKey GKKFJKNNDIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public FFFHIGBANBM EEIIEAAHNBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public DateTime NFCJJCGPMAI;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x22E6440", Offset = "0x22E5240", VA = "0x1822E6440")]
		public ENGEBKHKGCN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class LGMKHKOMEOM<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public global::BAKBKLCPPJF<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public ENGEBKHKGCN cacheEntry;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x22E6440", Offset = "0x22E5240", VA = "0x1822E6440")]
		public LGMKHKOMEOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x38F92D0", Offset = "0x38F80D0", VA = "0x1838F92D0")]
		internal void <SetPromise>b__0(string e)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<TKey, ENGEBKHKGCN> NEELKCPMANJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private LinkedList<ENGEBKHKGCN> AKCBEIFMHCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private LinkedList<ENGEBKHKGCN> NIAFDIKNFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int ECFLHHEFNPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool ONMOAGFEOGG;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5159960", Offset = "0x5158760", VA = "0x185159960")]
	public BAKBKLCPPJF([Optional] int? ECFLHHEFNPD, bool ONMOAGFEOGG = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5157930", Offset = "0x5156730", VA = "0x185157930")]
	public bool AFNPGADPHIJ(TKey CKMEBFKEHMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2F035C0", Offset = "0x2F023C0", VA = "0x182F035C0")]
	public global::KOILDJEEFJD<TValue> FPDJLJELEFB<TValue>(TKey CKMEBFKEHMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2F037C0", Offset = "0x2F025C0", VA = "0x182F037C0")]
	public void HKGFAOHKACC<TValue>(TKey CKMEBFKEHMO, TValue DPJGMDFEIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2F02BB0", Offset = "0x2F019B0", VA = "0x182F02BB0")]
	public void BLBHJHKMOEI<TValue>(TKey CKMEBFKEHMO, global::KOILDJEEFJD<TValue> HOJMPPKDDNK, TimeSpan PAIHMBKIOHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2F039F0", Offset = "0x2F027F0", VA = "0x182F039F0")]
	public global::KOILDJEEFJD<TValue> KNMLDLCDNBL<TValue>(TKey CKMEBFKEHMO, Func<global::KOILDJEEFJD<TValue>> PHFHAFDGEFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2F038B0", Offset = "0x2F026B0", VA = "0x182F038B0")]
	public global::KOILDJEEFJD<TValue> KNMLDLCDNBL<TValue>(TKey CKMEBFKEHMO, Func<global::KOILDJEEFJD<TValue>> PHFHAFDGEFP, TimeSpan PAIHMBKIOHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x51596D0", Offset = "0x51584D0", VA = "0x1851596D0")]
	public bool PPEAGPDBOCM(TKey CKMEBFKEHMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5159070", Offset = "0x5157E70", VA = "0x185159070")]
	public int PHIHBDOJPBF(Predicate<TKey> HBLEHCKGEIC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5158FE0", Offset = "0x5157DE0", VA = "0x185158FE0")]
	public void KJHAHNAAJMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5157D40", Offset = "0x5156B40", VA = "0x185157D40")]
	private void AKKMOJDLJDB(ENGEBKHKGCN BMABJKEGBFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x51581E0", Offset = "0x5156FE0", VA = "0x1851581E0")]
	private void CGBHDMBIELI(ENGEBKHKGCN BMABJKEGBFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5158AA0", Offset = "0x51578A0", VA = "0x185158AA0")]
	private void GDGLNGAHJGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5158C50", Offset = "0x5157A50", VA = "0x185158C50")]
	private bool GPMHMANJOHL(ENGEBKHKGCN BMABJKEGBFB)
	{
		return default(bool);
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
