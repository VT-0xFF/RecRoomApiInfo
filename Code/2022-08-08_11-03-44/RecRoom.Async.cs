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
		private struct KPODIBMCGNP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public string CNNFDLMHGBL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public HIOJNGOAMAG LNFKFGPPLNH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public float? FFBEKJGDCNC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public float? IIHKLOLMBLK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public IDisposable ILNIMOHGPKM;
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class PFPDNNPGMPK : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x5E51C0", Offset = "0x5E41C0", VA = "0x1805E51C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x5E51C0", Offset = "0x5E41C0", VA = "0x1805E51C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6F67D0", Offset = "0x6F57D0", VA = "0x1806F67D0")]
			[DebuggerHidden]
			public PFPDNNPGMPK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x5857870", Offset = "0x5856870", VA = "0x185857870", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x5857A40", Offset = "0x5856A40", VA = "0x185857A40", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class EKHPJDDMMIL : IEnumerator<object>, IEnumerator, IDisposable
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
			public IHDMPJIPDML promise;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x5E51C0", Offset = "0x5E41C0", VA = "0x1805E51C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x5E51C0", Offset = "0x5E41C0", VA = "0x1805E51C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6F67D0", Offset = "0x6F57D0", VA = "0x1806F67D0")]
			[DebuggerHidden]
			public EKHPJDDMMIL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x58577C0", Offset = "0x58567C0", VA = "0x1858577C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x5857820", Offset = "0x5856820", VA = "0x185857820", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private List<KPODIBMCGNP> APFDBCGPCEK;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool JKKKBJOODFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x5E5190", Offset = "0x5E4190", VA = "0x1805E5190")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x740180", Offset = "0x73F180", VA = "0x180740180")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5857650", Offset = "0x5856650", VA = "0x185857650")]
		public static AsyncBatch Create(Transform ACNNFDIAAFM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x58576E0", Offset = "0x58566E0", VA = "0x1858576E0")]
		[IteratorStateMachine(typeof(PFPDNNPGMPK))]
		private IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5857530", Offset = "0x5856530", VA = "0x185857530")]
		public void Add(string MBHNCPMPIFB, HIOJNGOAMAG FNNLBDHIJGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5857370", Offset = "0x5856370", VA = "0x185857370")]
		public void Add(string MBHNCPMPIFB, IEnumerator ILBECFBCNIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x58572E0", Offset = "0x58562E0", VA = "0x1858572E0")]
		[IteratorStateMachine(typeof(EKHPJDDMMIL))]
		private IEnumerator AJJOGMCEOML(IHDMPJIPDML FNNLBDHIJGE, IEnumerator ILBECFBCNIP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5857750", Offset = "0x5856750", VA = "0x185857750")]
		public AsyncBatch()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class DOHPAHDHMLG<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class NPAMKLBBOKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TKey CLPKDAIHDOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public HIOJNGOAMAG LNFKFGPPLNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public DateTime GDACMJOKFGP;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1CB3C80", Offset = "0x1CB2C80", VA = "0x181CB3C80")]
		public NPAMKLBBOKH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class FOPHECFEFCM<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public global::DOHPAHDHMLG<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public TKey key;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1CB3C80", Offset = "0x1CB2C80", VA = "0x181CB3C80")]
		public FOPHECFEFCM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class KBILIJKAMAO<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public NPAMKLBBOKH cacheEntry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public FOPHECFEFCM<TValue> CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1CB3C80", Offset = "0x1CB2C80", VA = "0x181CB3C80")]
		public KBILIJKAMAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x42A6B20", Offset = "0x42A5B20", VA = "0x1842A6B20")]
		internal void <SetPromise>b__0(string e)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<TKey, NPAMKLBBOKH> JNALAKHGIMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private LinkedList<NPAMKLBBOKH> CDCBLCOPINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private LinkedList<NPAMKLBBOKH> OJNIKMPKDPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int GCMFHEJFMMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool CBBHNEPHHOM;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public ICollection<TKey> NCNFHHNPBNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x27C1E00", Offset = "0x27C0E00", VA = "0x1827C1E00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x429AB90", Offset = "0x4299B90", VA = "0x18429AB90")]
	public DOHPAHDHMLG([Optional] int? GCMFHEJFMMO, bool CBBHNEPHHOM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x26D6BF0", Offset = "0x26D5BF0", VA = "0x1826D6BF0")]
	public bool LEADJOBBELM(TKey GGLJFLNJABJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x26092B0", Offset = "0x26082B0", VA = "0x1826092B0")]
	public global::LBHHDEJJNHM<TValue> KAPHIBCMLAO<TValue>(TKey GGLJFLNJABJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2F57110", Offset = "0x2F56110", VA = "0x182F57110")]
	public void HBHHAINOFBE<TValue>(TKey GGLJFLNJABJ, TValue JNLOLNFALGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x22840E0", Offset = "0x22830E0", VA = "0x1822840E0")]
	public void BCDCNCHNJKC<TValue>(TKey GGLJFLNJABJ, global::LBHHDEJJNHM<TValue> FNNLBDHIJGE, TimeSpan AIEDDKDLIGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x26098E0", Offset = "0x26088E0", VA = "0x1826098E0")]
	public global::LBHHDEJJNHM<TValue> MMOMEMJAFMI<TValue>(TKey GGLJFLNJABJ, Func<global::LBHHDEJJNHM<TValue>> PGJNGOLMMPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2609840", Offset = "0x2608840", VA = "0x182609840")]
	public global::LBHHDEJJNHM<TValue> MMOMEMJAFMI<TValue>(TKey GGLJFLNJABJ, Func<global::LBHHDEJJNHM<TValue>> PGJNGOLMMPB, TimeSpan AIEDDKDLIGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x42999D0", Offset = "0x42989D0", VA = "0x1842999D0")]
	public bool DKCILJPFPEA(TKey GGLJFLNJABJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4299280", Offset = "0x4298280", VA = "0x184299280")]
	public int CKHKLOGCFOI(Predicate<TKey> GMPPIODFDDM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x429A260", Offset = "0x4299260", VA = "0x18429A260")]
	public void MCOHOPDDOPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4299090", Offset = "0x4298090", VA = "0x184299090")]
	private void BPJCCCJFPLD(NPAMKLBBOKH LGDAHEIIHPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4299D00", Offset = "0x4298D00", VA = "0x184299D00")]
	private void IGGNHMBBOGO(NPAMKLBBOKH LGDAHEIIHPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x429A4A0", Offset = "0x42994A0", VA = "0x18429A4A0")]
	private void NEIKFMKCCNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x429A800", Offset = "0x4299800", VA = "0x18429A800")]
	private bool NHILPOKNDGO(NPAMKLBBOKH LGDAHEIIHPC)
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
