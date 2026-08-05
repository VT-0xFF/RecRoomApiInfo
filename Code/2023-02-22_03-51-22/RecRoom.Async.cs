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
		private struct EHCOKGHFGDJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public string COEOOBLBHBM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public PMOAFBNPLHC EBODDHNLHKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public float? PLALFNPOPFE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public float? GCGFIDJJNHP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public IDisposable JCMEIOBJFLL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class FIBPAGBPJNM : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6CB200", Offset = "0x6CA400", VA = "0x1806CB200")]
			[DebuggerHidden]
			public FIBPAGBPJNM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x64A3850", Offset = "0x64A2A50", VA = "0x1864A3850", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x64A3A50", Offset = "0x64A2C50", VA = "0x1864A3A50", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class LDCOBPACGHL : IEnumerator<object>, IEnumerator, IDisposable
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
			public AEOJOFIFGIK promise;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6CB200", Offset = "0x6CA400", VA = "0x1806CB200")]
			[DebuggerHidden]
			public LDCOBPACGHL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x64A3A90", Offset = "0x64A2C90", VA = "0x1864A3A90", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x64A3AF0", Offset = "0x64A2CF0", VA = "0x1864A3AF0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private List<EHCOKGHFGDJ> KLJAGIDOMCO;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool DGCFKLDJJEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x6E23D0", Offset = "0x6E15D0", VA = "0x1806E23D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x7F4AF0", Offset = "0x7F3CF0", VA = "0x1807F4AF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x64A3620", Offset = "0x64A2820", VA = "0x1864A3620")]
		public static AsyncBatch Create(Transform GPFONCECPBK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x64A3760", Offset = "0x64A2960", VA = "0x1864A3760")]
		[IteratorStateMachine(typeof(FIBPAGBPJNM))]
		private IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x64A34F0", Offset = "0x64A26F0", VA = "0x1864A34F0")]
		public void Add(string IGHJIHNAPBA, PMOAFBNPLHC MNPLPCBLMHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x64A3320", Offset = "0x64A2520", VA = "0x1864A3320")]
		public void Add(string IGHJIHNAPBA, IEnumerator OOKECDLOLBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x64A36D0", Offset = "0x64A28D0", VA = "0x1864A36D0")]
		[IteratorStateMachine(typeof(LDCOBPACGHL))]
		private IEnumerator GLNJCHOFFCL(AEOJOFIFGIK MNPLPCBLMHP, IEnumerator OOKECDLOLBJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x64A37D0", Offset = "0x64A29D0", VA = "0x1864A37D0")]
		public AsyncBatch()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class JIKIGCPDDDL<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class NFDDKLCMBPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TKey EGNKEKCMBBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public PMOAFBNPLHC EBODDHNLHKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public DateTime DJALMHGAKOP;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x14F6ED0", Offset = "0x14F60D0", VA = "0x1814F6ED0")]
		public NFDDKLCMBPI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class AMOJNHPGLJD<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public global::JIKIGCPDDDL<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public NFDDKLCMBPI cacheEntry;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x14F6ED0", Offset = "0x14F60D0", VA = "0x1814F6ED0")]
		public AMOJNHPGLJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x338EBB0", Offset = "0x338DDB0", VA = "0x18338EBB0")]
		internal void <SetPromise>b__0(string e)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<TKey, NFDDKLCMBPI> LDNMOPPGONB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private LinkedList<NFDDKLCMBPI> JMGCNDJNJML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private LinkedList<NFDDKLCMBPI> DEHNBNCIOCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int INAOLAJNNGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool JNHOGCBKGGB;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x364F040", Offset = "0x364E240", VA = "0x18364F040")]
	public JIKIGCPDDDL([Optional] int? INAOLAJNNGM, bool JNHOGCBKGGB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x364E4A0", Offset = "0x364D6A0", VA = "0x18364E4A0")]
	public bool GOBLPAEKFAO(TKey EBOEHIFNNLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1CE97E0", Offset = "0x1CE89E0", VA = "0x181CE97E0")]
	public global::HCPIAAEIKCB<TValue> OPCMFJKNHHD<TValue>(TKey EBOEHIFNNLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1CE8D80", Offset = "0x1CE7F80", VA = "0x181CE8D80")]
	public void IPPIKBINFON<TValue>(TKey EBOEHIFNNLM, TValue JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1CE91A0", Offset = "0x1CE83A0", VA = "0x181CE91A0")]
	public void JGNPKKOCBBL<TValue>(TKey EBOEHIFNNLM, global::HCPIAAEIKCB<TValue> MNPLPCBLMHP, TimeSpan MEBEAKCEPDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1CE8CD0", Offset = "0x1CE7ED0", VA = "0x181CE8CD0")]
	public global::HCPIAAEIKCB<TValue> BGIFMHJCCEE<TValue>(TKey EBOEHIFNNLM, Func<global::HCPIAAEIKCB<TValue>> LDFMAJLMAEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x1CE8B80", Offset = "0x1CE7D80", VA = "0x181CE8B80")]
	public global::HCPIAAEIKCB<TValue> BGIFMHJCCEE<TValue>(TKey EBOEHIFNNLM, Func<global::HCPIAAEIKCB<TValue>> LDFMAJLMAEA, TimeSpan MEBEAKCEPDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x364D680", Offset = "0x364C880", VA = "0x18364D680")]
	public bool BCBAFCFKBLF(TKey EBOEHIFNNLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x364E420", Offset = "0x364D620", VA = "0x18364E420")]
	public void FPNLAFLJCKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x364EA50", Offset = "0x364DC50", VA = "0x18364EA50")]
	private void LIOEBOHIBDH(NFDDKLCMBPI CEPDMCOICON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x364DEC0", Offset = "0x364D0C0", VA = "0x18364DEC0")]
	private void DFEMKGEBBNE(NFDDKLCMBPI CEPDMCOICON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x364D8B0", Offset = "0x364CAB0", VA = "0x18364D8B0")]
	private void BJDCGIFEOEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x364E730", Offset = "0x364D930", VA = "0x18364E730")]
	private bool JEEGLMJKFKE(NFDDKLCMBPI CEPDMCOICON)
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
