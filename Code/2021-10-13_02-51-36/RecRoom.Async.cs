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
		private struct GMPNAHALHFG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public string MNDPCPBJDAJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public GMANCKGDIIA DGFJNOMLNMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public float? BPCBNBNFGNK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public float? NBPCNFPIDIB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public IDisposable HNBDJCBMALG;
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class OFOHNLMNLHF : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x4480B0", Offset = "0x4474B0", VA = "0x1804480B0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x4480B0", Offset = "0x4474B0", VA = "0x1804480B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x448120", Offset = "0x447520", VA = "0x180448120")]
			[DebuggerHidden]
			public OFOHNLMNLHF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x448110", Offset = "0x447510", VA = "0x180448110", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x4085DA0", Offset = "0x40851A0", VA = "0x184085DA0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x4085F70", Offset = "0x4085370", VA = "0x184085F70", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class DJJCDLJIDBE : IEnumerator<object>, IEnumerator, IDisposable
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
			public INJMAONFMNO promise;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x4480B0", Offset = "0x4474B0", VA = "0x1804480B0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x4480B0", Offset = "0x4474B0", VA = "0x1804480B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x448120", Offset = "0x447520", VA = "0x180448120")]
			[DebuggerHidden]
			public DJJCDLJIDBE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x448110", Offset = "0x447510", VA = "0x180448110", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x4085720", Offset = "0x4084B20", VA = "0x184085720", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x4085770", Offset = "0x4084B70", VA = "0x184085770", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private List<GMPNAHALHFG> MKJFADMABIJ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool BOFFHMLGFIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x4F71D0", Offset = "0x4F65D0", VA = "0x1804F71D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x4F71E0", Offset = "0x4F65E0", VA = "0x1804F71E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x4085560", Offset = "0x4084960", VA = "0x184085560")]
		public static AsyncBatch Create(Transform GOLJDAHPMAF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x4085660", Offset = "0x4084A60", VA = "0x184085660")]
		[IteratorStateMachine(typeof(OFOHNLMNLHF))]
		private IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x4085470", Offset = "0x4084870", VA = "0x184085470")]
		public void Add(string OOIIJHJCCLA, GMANCKGDIIA ENNBMFPKHDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4085300", Offset = "0x4084700", VA = "0x184085300")]
		public void Add(string OOIIJHJCCLA, IEnumerator DFAODKMMINK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x40855F0", Offset = "0x40849F0", VA = "0x1840855F0")]
		[IteratorStateMachine(typeof(DJJCDLJIDBE))]
		private IEnumerator INEIHNCIHKH(INJMAONFMNO ENNBMFPKHDM, IEnumerator DFAODKMMINK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x40856C0", Offset = "0x4084AC0", VA = "0x1840856C0")]
		public AsyncBatch()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class JGMBIDHMDCP<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class MGFEDDACKIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TKey ADIOLHMGEME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public GMANCKGDIIA DGFJNOMLNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public DateTime KAIHBKOEHID;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1131E10", Offset = "0x1131210", VA = "0x181131E10")]
		public MGFEDDACKIG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class ALJBBFNBMDM<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public global::JGMBIDHMDCP<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public TKey key;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x1131E10", Offset = "0x1131210", VA = "0x181131E10")]
		public ALJBBFNBMDM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class AAIADFADIFK<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public MGFEDDACKIG cacheEntry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public ALJBBFNBMDM<TValue> CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1131E10", Offset = "0x1131210", VA = "0x181131E10")]
		public AAIADFADIFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1CCBA20", Offset = "0x1CCAE20", VA = "0x181CCBA20")]
		internal void <SetPromise>b__0(string e)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<TKey, MGFEDDACKIG> DOJJKLHJOPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private LinkedList<MGFEDDACKIG> ODHGJENHPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private LinkedList<MGFEDDACKIG> GOPJPNLELJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int HDLGKKBDIHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool OKOIMEHKJNG;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public ICollection<TKey> HLBAHELFDGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1CE0990", Offset = "0x1CDFD90", VA = "0x181CE0990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1CE0F90", Offset = "0x1CE0390", VA = "0x181CE0F90")]
	public JGMBIDHMDCP([Optional] int? HDLGKKBDIHB, bool OKOIMEHKJNG = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x16EF4F0", Offset = "0x16EE8F0", VA = "0x1816EF4F0")]
	public bool DIFAAKGHEBL(TKey IDFIPMLKMCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1545C00", Offset = "0x1545000", VA = "0x181545C00")]
	public global::KCBHFPPLLKO<TValue> PAFANFDAKIC<TValue>(TKey IDFIPMLKMCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x17CA250", Offset = "0x17C9650", VA = "0x1817CA250")]
	public void GEOPKJHFLGK<TValue>(TKey IDFIPMLKMCO, TValue ELCLILAGMPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x17CA330", Offset = "0x17C9730", VA = "0x1817CA330")]
	public void GEOPKJHFLGK<TValue>(TKey IDFIPMLKMCO, TValue ELCLILAGMPD, TimeSpan JEIFEHLGCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x17CA720", Offset = "0x17C9B20", VA = "0x1817CA720")]
	public void IDOHBCBNJIN<TValue>(TKey IDFIPMLKMCO, global::KCBHFPPLLKO<TValue> ENNBMFPKHDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x17CA7D0", Offset = "0x17C9BD0", VA = "0x1817CA7D0")]
	public void IDOHBCBNJIN<TValue>(TKey IDFIPMLKMCO, global::KCBHFPPLLKO<TValue> ENNBMFPKHDM, TimeSpan JEIFEHLGCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x1545760", Offset = "0x1544B60", VA = "0x181545760")]
	public global::KCBHFPPLLKO<TValue> GKMBHMINCDI<TValue>(TKey IDFIPMLKMCO, Func<global::KCBHFPPLLKO<TValue>> ODKOJGPEGIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x1545620", Offset = "0x1544A20", VA = "0x181545620")]
	public global::KCBHFPPLLKO<TValue> GKMBHMINCDI<TValue>(TKey IDFIPMLKMCO, Func<global::KCBHFPPLLKO<TValue>> ODKOJGPEGIK, TimeSpan JEIFEHLGCHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x1CE0910", Offset = "0x1CDFD10", VA = "0x181CE0910")]
	public bool KCCDFDIBBBL(TKey IDFIPMLKMCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x1CE0610", Offset = "0x1CDFA10", VA = "0x181CE0610")]
	public int EJHOKJCFGPM(Predicate<TKey> NAKMMHICJEP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1CE0880", Offset = "0x1CDFC80", VA = "0x181CE0880")]
	public void HFPHLCGNKJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1CE0AF0", Offset = "0x1CDFEF0", VA = "0x181CE0AF0")]
	private void LOPBDKDHCCB(MGFEDDACKIG LFGEODKKJPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1CE0CE0", Offset = "0x1CE00E0", VA = "0x181CE0CE0")]
	private void OJJNKLNBPHF(MGFEDDACKIG LFGEODKKJPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1CE0460", Offset = "0x1CDF860", VA = "0x181CE0460")]
	private void AKCNDHJBLMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1CE09C0", Offset = "0x1CDFDC0", VA = "0x181CE09C0")]
	private bool KPFGGBHOCKN(MGFEDDACKIG LFGEODKKJPA)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class EEINDPOJDJJ
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static byte[] OCLOOGINPMJ;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private static int CFJLDOHEGKM;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static int PFIGBFOAIKM;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static BigInteger HJNCOPCDJHG;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x448150", Offset = "0x447550", VA = "0x180448150")]
	public EEINDPOJDJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4085AF0", Offset = "0x4084EF0", VA = "0x184085AF0")]
	private static string KPINMDKLMNN(byte[] LPAMLJLFLDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x40857C0", Offset = "0x4084BC0", VA = "0x1840857C0")]
	public static string FEMGPJIFPGG(byte[] OOOKMGPDPAC, bool KLBFBHHGCEE)
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
		[Cpp2IlInjected.Address(RVA = "0x448150", Offset = "0x447550", VA = "0x180448150")]
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
