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
		private struct KMAEJJHHOME
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public string POGAANJDOAP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public OHCOLEGJNAC LGNJJLILBNP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public float? AKECICNPBOC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public float? JMMCILAFJAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public IDisposable FBEFANCJDOB;
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class CPHPKAOKJDJ : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x573720", VA = "0x180574F20", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x573720", VA = "0x180574F20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x5B8590", Offset = "0x5B6D90", VA = "0x1805B8590")]
			[DebuggerHidden]
			public CPHPKAOKJDJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573110", VA = "0x180574910", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x12500E0", Offset = "0x124E8E0", VA = "0x1812500E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x12502B0", Offset = "0x124EAB0", VA = "0x1812502B0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class PPDMKBLELFD : IEnumerator<object>, IEnumerator, IDisposable
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
			public FLHPGANJIHL promise;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x573720", VA = "0x180574F20", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x573720", VA = "0x180574F20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x5B8590", Offset = "0x5B6D90", VA = "0x1805B8590")]
			[DebuggerHidden]
			public PPDMKBLELFD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573110", VA = "0x180574910", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x1250300", Offset = "0x124EB00", VA = "0x181250300", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x1250360", Offset = "0x124EB60", VA = "0x181250360", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private List<KMAEJJHHOME> KDOOPOIDODB;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool OCNHIAHCIND
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x5D5130", Offset = "0x5D3930", VA = "0x1805D5130")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x5D5120", Offset = "0x5D3920", VA = "0x1805D5120")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x124FEE0", Offset = "0x124E6E0", VA = "0x18124FEE0")]
		public static AsyncBatch Create(Transform BNOBPGHCIOL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1250000", Offset = "0x124E800", VA = "0x181250000")]
		[IteratorStateMachine(typeof(CPHPKAOKJDJ))]
		private IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x124FDC0", Offset = "0x124E5C0", VA = "0x18124FDC0")]
		public void Add(string CGCECGHBEEN, OHCOLEGJNAC LIODJCGLONF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x124FC00", Offset = "0x124E400", VA = "0x18124FC00")]
		public void Add(string CGCECGHBEEN, IEnumerator GKPDLKKEPKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x124FF70", Offset = "0x124E770", VA = "0x18124FF70")]
		[IteratorStateMachine(typeof(PPDMKBLELFD))]
		private IEnumerator KDPEAPEECCB(FLHPGANJIHL LIODJCGLONF, IEnumerator GKPDLKKEPKN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1250070", Offset = "0x124E870", VA = "0x181250070")]
		public AsyncBatch()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class FEHIDHNNBNE<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class ADONNENBAHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TKey CNJCNJLJNLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public OHCOLEGJNAC LGNJJLILBNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public DateTime NLNCKAEIOLH;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xF360A0", Offset = "0xF348A0", VA = "0x180F360A0")]
		public ADONNENBAHD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class KOLMKBOLGGP<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public global::FEHIDHNNBNE<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public TKey key;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xF360A0", Offset = "0xF348A0", VA = "0x180F360A0")]
		public KOLMKBOLGGP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class NABELKNLGLD<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public ADONNENBAHD cacheEntry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public KOLMKBOLGGP<TValue> CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xF360A0", Offset = "0xF348A0", VA = "0x180F360A0")]
		public NABELKNLGLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3910730", Offset = "0x390EF30", VA = "0x183910730")]
		internal void <SetPromise>b__0(string e)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<TKey, ADONNENBAHD> CFJAHBNPDIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private LinkedList<ADONNENBAHD> GOFMDOILCGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private LinkedList<ADONNENBAHD> CMKNABKJNIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int BPHPLBGCNJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool FGFDKEGHIGP;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public ICollection<TKey> OAHNPONBHIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x230EE50", Offset = "0x230D650", VA = "0x18230EE50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x390F140", Offset = "0x390D940", VA = "0x18390F140")]
	public FEHIDHNNBNE([Optional] int? BPHPLBGCNJP, bool FGFDKEGHIGP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2BE7A30", Offset = "0x2BE6230", VA = "0x182BE7A30")]
	public bool MDPNLHCBEFJ(TKey HJCJKDOGPGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2499090", Offset = "0x2497890", VA = "0x182499090")]
	public global::MJKMFAPMHBB<TValue> IKANGINNPCN<TValue>(TKey HJCJKDOGPGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x30873E0", Offset = "0x3085BE0", VA = "0x1830873E0")]
	public void JDDJOILGGOI<TValue>(TKey HJCJKDOGPGK, TValue HKJMLEKHILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3087080", Offset = "0x3085880", VA = "0x183087080")]
	public void HFAAKCCBBND<TValue>(TKey HJCJKDOGPGK, global::MJKMFAPMHBB<TValue> LIODJCGLONF, TimeSpan KKDOCPKDCBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2499320", Offset = "0x2497B20", VA = "0x182499320")]
	public global::MJKMFAPMHBB<TValue> LEELCNFHFNH<TValue>(TKey HJCJKDOGPGK, Func<global::MJKMFAPMHBB<TValue>> JABOMCGNLOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2499280", Offset = "0x2497A80", VA = "0x182499280")]
	public global::MJKMFAPMHBB<TValue> LEELCNFHFNH<TValue>(TKey HJCJKDOGPGK, Func<global::MJKMFAPMHBB<TValue>> JABOMCGNLOP, TimeSpan KKDOCPKDCBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x390EBB0", Offset = "0x390D3B0", VA = "0x18390EBB0")]
	public bool IIDOOJBFPNM(TKey HJCJKDOGPGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x390DE90", Offset = "0x390C690", VA = "0x18390DE90")]
	public int EEKFKMFHFCE(Predicate<TKey> KNGLLBDNLCB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x390DE00", Offset = "0x390C600", VA = "0x18390DE00")]
	public void CPGPLJLMCBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x390E9C0", Offset = "0x390D1C0", VA = "0x18390E9C0")]
	private void FGGGCDDNGBD(ADONNENBAHD KBKNKBPHHPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x390D5F0", Offset = "0x390BDF0", VA = "0x18390D5F0")]
	private void BELKJIOEIBP(ADONNENBAHD KBKNKBPHHPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x390EDE0", Offset = "0x390D5E0", VA = "0x18390EDE0")]
	private void OJFHBOOHOKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x390D390", Offset = "0x390BB90", VA = "0x18390D390")]
	private bool AEHDPCJGGLK(ADONNENBAHD KBKNKBPHHPA)
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
