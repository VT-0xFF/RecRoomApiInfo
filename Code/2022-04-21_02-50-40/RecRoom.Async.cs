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
		private struct JPOONBKCNBB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public string FIMOCMKAMPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public FPHLJBABNHP EAHLFLFHLAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public float? NGFLEBCJJIB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public float? GPAGMEPMCAE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public IDisposable PIJEJPOMHKB;
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class ADNEFOACEOG : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x5231C0", Offset = "0x5221C0", VA = "0x1805231C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x5231C0", Offset = "0x5221C0", VA = "0x1805231C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6347D0", Offset = "0x6337D0", VA = "0x1806347D0")]
			[DebuggerHidden]
			public ADNEFOACEOG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x523E80", Offset = "0x522E80", VA = "0x180523E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x4BF7170", Offset = "0x4BF6170", VA = "0x184BF7170", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x4BF7340", Offset = "0x4BF6340", VA = "0x184BF7340", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class ALBPANOKBLI : IEnumerator<object>, IEnumerator, IDisposable
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
			public OGFJMEAGPLD promise;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x5231C0", Offset = "0x5221C0", VA = "0x1805231C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x5231C0", Offset = "0x5221C0", VA = "0x1805231C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6347D0", Offset = "0x6337D0", VA = "0x1806347D0")]
			[DebuggerHidden]
			public ALBPANOKBLI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x523E80", Offset = "0x522E80", VA = "0x180523E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x4BF7390", Offset = "0x4BF6390", VA = "0x184BF7390", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x4BF73F0", Offset = "0x4BF63F0", VA = "0x184BF73F0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private List<JPOONBKCNBB> LIJKJKKBOEB;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool FGOBIOLNBAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x523190", Offset = "0x522190", VA = "0x180523190")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x6AA560", Offset = "0x6A9560", VA = "0x1806AA560")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x4BF7720", Offset = "0x4BF6720", VA = "0x184BF7720")]
		public static AsyncBatch Create(Transform BMCODBFOLMP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x4BF7840", Offset = "0x4BF6840", VA = "0x184BF7840")]
		[IteratorStateMachine(typeof(ADNEFOACEOG))]
		private IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x4BF7440", Offset = "0x4BF6440", VA = "0x184BF7440")]
		public void Add(string PABPMLLKDBG, FPHLJBABNHP OEPJIAOCMFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4BF7560", Offset = "0x4BF6560", VA = "0x184BF7560")]
		public void Add(string PABPMLLKDBG, IEnumerator ILNPLKMPOAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4BF77B0", Offset = "0x4BF67B0", VA = "0x184BF77B0")]
		[IteratorStateMachine(typeof(ALBPANOKBLI))]
		private IEnumerator MNLGNAALFDM(OGFJMEAGPLD OEPJIAOCMFO, IEnumerator ILNPLKMPOAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4BF78B0", Offset = "0x4BF68B0", VA = "0x184BF78B0")]
		public AsyncBatch()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class JBDPGNGCGCH<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class HCNLKOOMHMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TKey IDCDHNMBHAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public FPHLJBABNHP EAHLFLFHLAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public DateTime NGPHALAEGLJ;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1C193A0", Offset = "0x1C183A0", VA = "0x181C193A0")]
		public HCNLKOOMHMM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class BAEPDPAIMFI<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public global::JBDPGNGCGCH<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public TKey key;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x1C193A0", Offset = "0x1C183A0", VA = "0x181C193A0")]
		public BAEPDPAIMFI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class ABLLJCBCABB<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public HCNLKOOMHMM cacheEntry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public BAEPDPAIMFI<TValue> CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1C193A0", Offset = "0x1C183A0", VA = "0x181C193A0")]
		public ABLLJCBCABB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3B3BFC0", Offset = "0x3B3AFC0", VA = "0x183B3BFC0")]
		internal void <SetPromise>b__0(string e)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<TKey, HCNLKOOMHMM> KGLJCEABLEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private LinkedList<HCNLKOOMHMM> MCENHLLCAAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private LinkedList<HCNLKOOMHMM> CJIIJHEBDOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int NEDLCOKHPNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool DFPEPKGMOEE;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public ICollection<TKey> KENJAHLACBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x229A260", Offset = "0x2299260", VA = "0x18229A260")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3B46FF0", Offset = "0x3B45FF0", VA = "0x183B46FF0")]
	public JBDPGNGCGCH([Optional] int? NEDLCOKHPNB, bool DFPEPKGMOEE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x229A8D0", Offset = "0x22998D0", VA = "0x18229A8D0")]
	public bool LHHPBHACMFE(TKey ACPAGAEJCEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x26A03F0", Offset = "0x269F3F0", VA = "0x1826A03F0")]
	public global::GIFPPDKJJDK<TValue> EPDEACLKCNH<TValue>(TKey ACPAGAEJCEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2CD5EC0", Offset = "0x2CD4EC0", VA = "0x182CD5EC0")]
	public void MFBLJJEHMJM<TValue>(TKey ACPAGAEJCEC, TValue PLIDGBGAHIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2CD5E00", Offset = "0x2CD4E00", VA = "0x182CD5E00")]
	public void MFBLJJEHMJM<TValue>(TKey ACPAGAEJCEC, TValue PLIDGBGAHIA, TimeSpan NMAACDKDPEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2CD5320", Offset = "0x2CD4320", VA = "0x182CD5320")]
	public void KIJAADKKKGF<TValue>(TKey ACPAGAEJCEC, global::GIFPPDKJJDK<TValue> OEPJIAOCMFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2CD5AA0", Offset = "0x2CD4AA0", VA = "0x182CD5AA0")]
	public void KIJAADKKKGF<TValue>(TKey ACPAGAEJCEC, global::GIFPPDKJJDK<TValue> OEPJIAOCMFO, TimeSpan NMAACDKDPEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x26A0830", Offset = "0x269F830", VA = "0x1826A0830")]
	public global::GIFPPDKJJDK<TValue> LAIJHLHFBAJ<TValue>(TKey ACPAGAEJCEC, Func<global::GIFPPDKJJDK<TValue>> DDBMAGMKCIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x26A0790", Offset = "0x269F790", VA = "0x1826A0790")]
	public global::GIFPPDKJJDK<TValue> LAIJHLHFBAJ<TValue>(TKey ACPAGAEJCEC, Func<global::GIFPPDKJJDK<TValue>> DDBMAGMKCIO, TimeSpan NMAACDKDPEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3B45A40", Offset = "0x3B44A40", VA = "0x183B45A40")]
	public bool JBOIIODGKNN(TKey ACPAGAEJCEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3B45560", Offset = "0x3B44560", VA = "0x183B45560")]
	public int HHLBDLHECIP(Predicate<TKey> IEGIDGHNODJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3B45260", Offset = "0x3B44260", VA = "0x183B45260")]
	public void EMKEODJBGFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3B45CB0", Offset = "0x3B44CB0", VA = "0x183B45CB0")]
	private void JEEFEBDPFJK(HCNLKOOMHMM GFOBCOJDDDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3B466D0", Offset = "0x3B456D0", VA = "0x183B466D0")]
	private void MNOEKJMLEKC(HCNLKOOMHMM GFOBCOJDDDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3B44F00", Offset = "0x3B43F00", VA = "0x183B44F00")]
	private void DKNNMDAPCDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3B461C0", Offset = "0x3B451C0", VA = "0x183B461C0")]
	private bool KHCIBGJEEJA(HCNLKOOMHMM GFOBCOJDDDN)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class EMILBIDIJON
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static byte[] MHCBODEMNDA;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private static int DAIOMNBGJFA;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static int DDGCDEKJNBF;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static BigInteger CONMBDBFJHL;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x525AB0", Offset = "0x524AB0", VA = "0x180525AB0")]
	public EMILBIDIJON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4BF7C50", Offset = "0x4BF6C50", VA = "0x184BF7C50")]
	private static string PDOGHHMIGDK(byte[] EJCAMPCKMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4BF7920", Offset = "0x4BF6920", VA = "0x184BF7920")]
	public static string KPIGCAGDHMH(byte[] BGILCKNBLBG, bool LCPNKOKDLIC)
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
		[Cpp2IlInjected.Address(RVA = "0x525AB0", Offset = "0x524AB0", VA = "0x180525AB0")]
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
