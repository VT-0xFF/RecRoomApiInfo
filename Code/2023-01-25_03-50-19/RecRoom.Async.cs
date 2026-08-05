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
		private struct MDOIEHHGKDD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public string ADMEEJPABPA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public CCBLCAIHLNA NOFEKBFPLGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public float? OOPDFHHMLDD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public float? ILEHMPJFCIO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public IDisposable PDDFPLHMHND;
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class MPDIJODDIBC : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x67E0C0", Offset = "0x67D0C0", VA = "0x18067E0C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x67E0C0", Offset = "0x67D0C0", VA = "0x18067E0C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x682200", Offset = "0x681200", VA = "0x180682200")]
			[DebuggerHidden]
			public MPDIJODDIBC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x611EB20", Offset = "0x611DB20", VA = "0x18611EB20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x611ED20", Offset = "0x611DD20", VA = "0x18611ED20", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class DEBBFJPGJCM : IEnumerator<object>, IEnumerator, IDisposable
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
			public HGIFEALIPIB promise;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x67E0C0", Offset = "0x67D0C0", VA = "0x18067E0C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x67E0C0", Offset = "0x67D0C0", VA = "0x18067E0C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x682200", Offset = "0x681200", VA = "0x180682200")]
			[DebuggerHidden]
			public DEBBFJPGJCM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x611EA80", Offset = "0x611DA80", VA = "0x18611EA80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x611EAE0", Offset = "0x611DAE0", VA = "0x18611EAE0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private List<MDOIEHHGKDD> EDFINDDLADN;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool MIHBCEKGEFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x6993D0", Offset = "0x6983D0", VA = "0x1806993D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x78A640", Offset = "0x789640", VA = "0x18078A640")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x611E850", Offset = "0x611D850", VA = "0x18611E850")]
		public static AsyncBatch Create(Transform ICMEPOIJCJO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x611E990", Offset = "0x611D990", VA = "0x18611E990")]
		[IteratorStateMachine(typeof(MPDIJODDIBC))]
		private IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x611E720", Offset = "0x611D720", VA = "0x18611E720")]
		public void Add(string IADPDEAGFAB, CCBLCAIHLNA HNFKIAKOCJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x611E550", Offset = "0x611D550", VA = "0x18611E550")]
		public void Add(string IADPDEAGFAB, IEnumerator PLJNLNLCNGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x611E900", Offset = "0x611D900", VA = "0x18611E900")]
		[IteratorStateMachine(typeof(DEBBFJPGJCM))]
		private IEnumerator IEIJAIFDIEB(HGIFEALIPIB HNFKIAKOCJI, IEnumerator PLJNLNLCNGA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x611EA00", Offset = "0x611DA00", VA = "0x18611EA00")]
		public AsyncBatch()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class DPHFBKDANNK<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class CAPADGNHGLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TKey GDJDAALKGJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public CCBLCAIHLNA NOFEKBFPLGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public DateTime GPFLNEBOIIG;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x13D8310", Offset = "0x13D7310", VA = "0x1813D8310")]
		public CAPADGNHGLG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class PLICFHBODMN<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public global::DPHFBKDANNK<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public CAPADGNHGLG cacheEntry;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x13D8310", Offset = "0x13D7310", VA = "0x1813D8310")]
		public PLICFHBODMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2D94B70", Offset = "0x2D93B70", VA = "0x182D94B70")]
		internal void <SetPromise>b__0(string e)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<TKey, CAPADGNHGLG> KEJPIFGMADN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private LinkedList<CAPADGNHGLG> AKLGPDIOMFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private LinkedList<CAPADGNHGLG> FKDEOPDEBDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int JODJAAAMHAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool DFFCOPBOCJP;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public ICollection<TKey> GLAEFLDOOIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x28E6410", Offset = "0x28E5410", VA = "0x1828E6410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x28E74C0", Offset = "0x28E64C0", VA = "0x1828E74C0")]
	public DPHFBKDANNK([Optional] int? JODJAAAMHAA, bool DFFCOPBOCJP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x265C4C0", Offset = "0x265B4C0", VA = "0x18265C4C0")]
	public bool KJCNBHBPKIJ(TKey PIIJMEAKDGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1E6FD10", Offset = "0x1E6ED10", VA = "0x181E6FD10")]
	public global::MMBCCHGMCHN<TValue> ABFGLAKBBOP<TValue>(TKey PIIJMEAKDGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1E71880", Offset = "0x1E70880", VA = "0x181E71880")]
	public void OMLKCIMPBMO<TValue>(TKey PIIJMEAKDGO, TValue DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1E70C70", Offset = "0x1E6FC70", VA = "0x181E70C70")]
	public void GCABMMKNOIE<TValue>(TKey PIIJMEAKDGO, global::MMBCCHGMCHN<TValue> HNFKIAKOCJI, TimeSpan ALFEBCGDANK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x1E717D0", Offset = "0x1E707D0", VA = "0x181E717D0")]
	public global::MMBCCHGMCHN<TValue> JMECEIKKOFH<TValue>(TKey PIIJMEAKDGO, Func<global::MMBCCHGMCHN<TValue>> ILCJPNNCHKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1E71680", Offset = "0x1E70680", VA = "0x181E71680")]
	public global::MMBCCHGMCHN<TValue> JMECEIKKOFH<TValue>(TKey PIIJMEAKDGO, Func<global::MMBCCHGMCHN<TValue>> ILCJPNNCHKB, TimeSpan ALFEBCGDANK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x28E6390", Offset = "0x28E5390", VA = "0x1828E6390")]
	public bool FAHLDBEBGON(TKey PIIJMEAKDGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x28E5EC0", Offset = "0x28E4EC0", VA = "0x1828E5EC0")]
	public int DDCLDBCGDHO(Predicate<TKey> ELHCNCOMOGO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x28E6300", Offset = "0x28E5300", VA = "0x1828E6300")]
	public void EMOCNNJJBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x28E6B40", Offset = "0x28E5B40", VA = "0x1828E6B40")]
	private void MMNNPIOILAF(CAPADGNHGLG FFBOGLDBEDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x28E5490", Offset = "0x28E4490", VA = "0x1828E5490")]
	private void CAPAPPIBOKB(CAPADGNHGLG FFBOGLDBEDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x28E65F0", Offset = "0x28E55F0", VA = "0x1828E65F0")]
	private void MHOADKDLLPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x28E7050", Offset = "0x28E6050", VA = "0x1828E7050")]
	private bool ODDOBNPACEF(CAPADGNHGLG FFBOGLDBEDF)
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
