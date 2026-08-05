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
		private struct EJBCCKPNEFN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public string KKHBICLGHOL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public APPFHLGLKJA LKNHLIONGOE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public float? JEJHBBKCGNN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public float? NEKLJDEAFNM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public IDisposable MKBANOCBMNH;
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class BOCGCLIKPKH : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6717D0", Offset = "0x66FDD0", VA = "0x1806717D0")]
			[DebuggerHidden]
			public BOCGCLIKPKH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x560E80", Offset = "0x55F480", VA = "0x180560E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x4E7EE20", Offset = "0x4E7D420", VA = "0x184E7EE20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x4E7EFF0", Offset = "0x4E7D5F0", VA = "0x184E7EFF0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class GJAEOCLEABA : IEnumerator<object>, IEnumerator, IDisposable
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
			public BNGELMJMADH promise;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6717D0", Offset = "0x66FDD0", VA = "0x1806717D0")]
			[DebuggerHidden]
			public GJAEOCLEABA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x560E80", Offset = "0x55F480", VA = "0x180560E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x4E7F040", Offset = "0x4E7D640", VA = "0x184E7F040", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x4E7F0A0", Offset = "0x4E7D6A0", VA = "0x184E7F0A0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private List<EJBCCKPNEFN> FFJGINGPCMG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool EHMINPKKADE
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x560190", Offset = "0x55E790", VA = "0x180560190")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x6C4AA0", Offset = "0x6C30A0", VA = "0x1806C4AA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x4E7EC20", Offset = "0x4E7D220", VA = "0x184E7EC20")]
		public static AsyncBatch Create(Transform COLFLONKFJK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x4E7ED40", Offset = "0x4E7D340", VA = "0x184E7ED40")]
		[IteratorStateMachine(typeof(BOCGCLIKPKH))]
		private IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x4E7EB00", Offset = "0x4E7D100", VA = "0x184E7EB00")]
		public void Add(string MONHCMBIJIP, APPFHLGLKJA PNEBNJNAOIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4E7E940", Offset = "0x4E7CF40", VA = "0x184E7E940")]
		public void Add(string MONHCMBIJIP, IEnumerator GBLEGCCOFFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4E7ECB0", Offset = "0x4E7D2B0", VA = "0x184E7ECB0")]
		[IteratorStateMachine(typeof(GJAEOCLEABA))]
		private IEnumerator DHACOHBELPP(BNGELMJMADH PNEBNJNAOIA, IEnumerator GBLEGCCOFFF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4E7EDB0", Offset = "0x4E7D3B0", VA = "0x184E7EDB0")]
		public AsyncBatch()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class JPACOHGNDAH<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class IPECGFAFGFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TKey FJPMPBHLOOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public APPFHLGLKJA LKNHLIONGOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public DateTime BCADGDIOLNF;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1C61870", Offset = "0x1C5FE70", VA = "0x181C61870")]
		public IPECGFAFGFD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class IKLKIIPADDJ<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public global::JPACOHGNDAH<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public TKey key;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1C61870", Offset = "0x1C5FE70", VA = "0x181C61870")]
		public IKLKIIPADDJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class APMGMEJAFGK<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public IPECGFAFGFD cacheEntry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public IKLKIIPADDJ<TValue> CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1C61870", Offset = "0x1C5FE70", VA = "0x181C61870")]
		public APMGMEJAFGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3F99AD0", Offset = "0x3F980D0", VA = "0x183F99AD0")]
		internal void <SetPromise>b__0(string e)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<TKey, IPECGFAFGFD> JFHJFCDGNCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private LinkedList<IPECGFAFGFD> GDBDPOPPDEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private LinkedList<IPECGFAFGFD> JCBCLGJLIMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int LAGEPCJCEFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool KGOEBKHDEFO;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public ICollection<TKey> GCFCKHBGHHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2881E80", Offset = "0x2880480", VA = "0x182881E80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3F9BDF0", Offset = "0x3F9A3F0", VA = "0x183F9BDF0")]
	public JPACOHGNDAH([Optional] int? LAGEPCJCEFF, bool KGOEBKHDEFO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x287E8E0", Offset = "0x287CEE0", VA = "0x18287E8E0")]
	public bool NHEDMKBNPEE(TKey MKDJIBNCKNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x259D750", Offset = "0x259BD50", VA = "0x18259D750")]
	public global::DBIKMJJJBLJ<TValue> AOGJMMJFOML<TValue>(TKey MKDJIBNCKNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2F26090", Offset = "0x2F24690", VA = "0x182F26090")]
	public void GOMBGNICLJL<TValue>(TKey MKDJIBNCKNC, TValue MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2F25660", Offset = "0x2F23C60", VA = "0x182F25660")]
	public void ALFIMEBOGOE<TValue>(TKey MKDJIBNCKNC, global::DBIKMJJJBLJ<TValue> PNEBNJNAOIA, TimeSpan EBBALBIFLHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x259DD80", Offset = "0x259C380", VA = "0x18259DD80")]
	public global::DBIKMJJJBLJ<TValue> FKFIFBANKHA<TValue>(TKey MKDJIBNCKNC, Func<global::DBIKMJJJBLJ<TValue>> FEHJHNDHJOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x259DCE0", Offset = "0x259C2E0", VA = "0x18259DCE0")]
	public global::DBIKMJJJBLJ<TValue> FKFIFBANKHA<TValue>(TKey MKDJIBNCKNC, Func<global::DBIKMJJJBLJ<TValue>> FEHJHNDHJOM, TimeSpan EBBALBIFLHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3F9BB90", Offset = "0x3F9A190", VA = "0x183F9BB90")]
	public bool MNHCGCIEOKP(TKey MKDJIBNCKNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3F9B440", Offset = "0x3F99A40", VA = "0x183F9B440")]
	public int JPDGOHOAFDO(Predicate<TKey> MOCGNKJBNOP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3F9B020", Offset = "0x3F99620", VA = "0x183F9B020")]
	public void CGFAFPCCKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3F99D30", Offset = "0x3F98330", VA = "0x183F99D30")]
	private void AIODOHOAODG(IPECGFAFGFD FHIFMCKLKIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3F9A5B0", Offset = "0x3F98BB0", VA = "0x183F9A5B0")]
	private void AOAHHCMHPNF(IPECGFAFGFD FHIFMCKLKIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3F9AB10", Offset = "0x3F99110", VA = "0x183F9AB10")]
	private void BIGELPPNIIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3F9B1E0", Offset = "0x3F997E0", VA = "0x183F9B1E0")]
	private bool GKKHCKECNDD(IPECGFAFGFD FHIFMCKLKIJ)
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
