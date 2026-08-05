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
		private struct HKDKJAHJDOL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public string BIEMFEFJPLE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public CFBFBBBFDFL AKBDDHENEAN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public float? JOOMPBLGNFM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public float? KEHOONDGICK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public IDisposable LNCKIKKEIIO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class OALDGBBMHBD : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x58C1C0", Offset = "0x58B1C0", VA = "0x18058C1C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x58C1C0", Offset = "0x58B1C0", VA = "0x18058C1C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x69D7D0", Offset = "0x69C7D0", VA = "0x18069D7D0")]
			[DebuggerHidden]
			public OALDGBBMHBD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x58CE80", Offset = "0x58BE80", VA = "0x18058CE80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x5211F40", Offset = "0x5210F40", VA = "0x185211F40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x5212110", Offset = "0x5211110", VA = "0x185212110", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class EAHMMPIMEEC : IEnumerator<object>, IEnumerator, IDisposable
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
			public FKDIGOMJOEO promise;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x58C1C0", Offset = "0x58B1C0", VA = "0x18058C1C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x58C1C0", Offset = "0x58B1C0", VA = "0x18058C1C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x69D7D0", Offset = "0x69C7D0", VA = "0x18069D7D0")]
			[DebuggerHidden]
			public EAHMMPIMEEC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x58CE80", Offset = "0x58BE80", VA = "0x18058CE80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x5211E90", Offset = "0x5210E90", VA = "0x185211E90", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x5211EF0", Offset = "0x5210EF0", VA = "0x185211EF0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private List<HKDKJAHJDOL> DGFBHCOJJGI;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool LHGMFEODBEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x58C190", Offset = "0x58B190", VA = "0x18058C190")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x6E6E80", Offset = "0x6E5E80", VA = "0x1806E6E80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5211C90", Offset = "0x5210C90", VA = "0x185211C90")]
		public static AsyncBatch Create(Transform ACJKMIDAEJL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5211DB0", Offset = "0x5210DB0", VA = "0x185211DB0")]
		[IteratorStateMachine(typeof(OALDGBBMHBD))]
		private IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5211B70", Offset = "0x5210B70", VA = "0x185211B70")]
		public void Add(string LDKPDNBIJND, CFBFBBBFDFL OINEJGIHCPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x52119B0", Offset = "0x52109B0", VA = "0x1852119B0")]
		public void Add(string LDKPDNBIJND, IEnumerator AEDBMKKDHFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5211D20", Offset = "0x5210D20", VA = "0x185211D20")]
		[IteratorStateMachine(typeof(EAHMMPIMEEC))]
		private IEnumerator KAADKJAJDHO(FKDIGOMJOEO OINEJGIHCPE, IEnumerator AEDBMKKDHFE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5211E20", Offset = "0x5210E20", VA = "0x185211E20")]
		public AsyncBatch()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class BDKBCPIJAAG<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class JJELBHEBMGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TKey LEAFJIBNHBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public CFBFBBBFDFL AKBDDHENEAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public DateTime KAKIDILBHOA;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1E42690", Offset = "0x1E41690", VA = "0x181E42690")]
		public JJELBHEBMGD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class FJFBLOFBGAA<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public global::BDKBCPIJAAG<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public TKey key;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1E42690", Offset = "0x1E41690", VA = "0x181E42690")]
		public FJFBLOFBGAA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class IFPFGPAGJOL<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public JJELBHEBMGD cacheEntry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public FJFBLOFBGAA<TValue> CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1E42690", Offset = "0x1E41690", VA = "0x181E42690")]
		public IFPFGPAGJOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2EDA680", Offset = "0x2ED9680", VA = "0x182EDA680")]
		internal void <SetPromise>b__0(string e)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<TKey, JJELBHEBMGD> MNKBFBGJLOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private LinkedList<JJELBHEBMGD> NEIOGCGJDDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private LinkedList<JJELBHEBMGD> NJEHKLKGLBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int OINNKFFOEFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool PDDHKBCOBDH;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public ICollection<TKey> BCLGOBIPCIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2ED7C00", Offset = "0x2ED6C00", VA = "0x182ED7C00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2ED9000", Offset = "0x2ED8000", VA = "0x182ED9000")]
	public BDKBCPIJAAG([Optional] int? OINNKFFOEFP, bool PDDHKBCOBDH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x27F6250", Offset = "0x27F5250", VA = "0x1827F6250")]
	public bool DBGJLGFLGIE(TKey DDFHJDPPNBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2521090", Offset = "0x2520090", VA = "0x182521090")]
	public global::IHDAFNHGAJF<TValue> JMACJJMOLBI<TValue>(TKey DDFHJDPPNBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2BB2770", Offset = "0x2BB1770", VA = "0x182BB2770")]
	public void CHAOBMPPLCP<TValue>(TKey DDFHJDPPNBF, TValue BMNJAHFFOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2BB32A0", Offset = "0x2BB22A0", VA = "0x182BB32A0")]
	public void KNJMIMOLJNM<TValue>(TKey DDFHJDPPNBF, global::IHDAFNHGAJF<TValue> OINEJGIHCPE, TimeSpan CKDEICEABPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x25205E0", Offset = "0x251F5E0", VA = "0x1825205E0")]
	public global::IHDAFNHGAJF<TValue> APCCALJDKFH<TValue>(TKey DDFHJDPPNBF, Func<global::IHDAFNHGAJF<TValue>> BEBAGAEPOKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2520540", Offset = "0x251F540", VA = "0x182520540")]
	public global::IHDAFNHGAJF<TValue> APCCALJDKFH<TValue>(TKey DDFHJDPPNBF, Func<global::IHDAFNHGAJF<TValue>> BEBAGAEPOKM, TimeSpan CKDEICEABPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2ED8440", Offset = "0x2ED7440", VA = "0x182ED8440")]
	public bool INAIIIEHGLD(TKey DDFHJDPPNBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2ED7720", Offset = "0x2ED6720", VA = "0x182ED7720")]
	public int EHLNFFCEBEA(Predicate<TKey> MDMGEIKDFBG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2ED6F10", Offset = "0x2ED5F10", VA = "0x182ED6F10")]
	public void BFHLNDADIAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2ED84C0", Offset = "0x2ED74C0", VA = "0x182ED84C0")]
	private void LNIOLPCHNPN(JJELBHEBMGD KCKMIGNLMHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2ED7EE0", Offset = "0x2ED6EE0", VA = "0x182ED7EE0")]
	private void HIJLOGBIBHG(JJELBHEBMGD KCKMIGNLMHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2ED7150", Offset = "0x2ED6150", VA = "0x182ED7150")]
	private void DEIIHNFALEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2ED8CF0", Offset = "0x2ED7CF0", VA = "0x182ED8CF0")]
	private bool OBMKFBHOEGD(JJELBHEBMGD KCKMIGNLMHP)
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
