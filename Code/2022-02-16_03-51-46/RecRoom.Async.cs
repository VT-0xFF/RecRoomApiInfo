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
		private struct ADHIKNOOCHL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public string PNDBGHBJEKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public LFPFPAAINHE EDPNMDDPFLP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public float? AMPOGADAPIE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public float? ONOKGHBBHML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public IDisposable HDKFIIBCBAI;
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class EHEFOIGGIDI : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x50B050", Offset = "0x509850", VA = "0x18050B050", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x50B050", Offset = "0x509850", VA = "0x18050B050", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x52E960", Offset = "0x52D160", VA = "0x18052E960")]
			[DebuggerHidden]
			public EHEFOIGGIDI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x507B30", Offset = "0x506330", VA = "0x180507B30", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x1BBA980", Offset = "0x1BB9180", VA = "0x181BBA980", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x1BBAB50", Offset = "0x1BB9350", VA = "0x181BBAB50", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class BPGMLCKDOEK : IEnumerator<object>, IEnumerator, IDisposable
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
			public NNILOECJPKH promise;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x50B050", Offset = "0x509850", VA = "0x18050B050", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x50B050", Offset = "0x509850", VA = "0x18050B050", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x52E960", Offset = "0x52D160", VA = "0x18052E960")]
			[DebuggerHidden]
			public BPGMLCKDOEK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x507B30", Offset = "0x506330", VA = "0x180507B30", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x1BBA8D0", Offset = "0x1BB90D0", VA = "0x181BBA8D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x1BBA930", Offset = "0x1BB9130", VA = "0x181BBA930", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private List<ADHIKNOOCHL> FAJNDKCLOEB;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool EKBFMLMDEEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x52EBC0", Offset = "0x52D3C0", VA = "0x18052EBC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x5D0C90", Offset = "0x5CF490", VA = "0x1805D0C90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x1BBA6D0", Offset = "0x1BB8ED0", VA = "0x181BBA6D0")]
		public static AsyncBatch Create(Transform ECKBOFJGCOL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1BBA7F0", Offset = "0x1BB8FF0", VA = "0x181BBA7F0")]
		[IteratorStateMachine(typeof(EHEFOIGGIDI))]
		private IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1BBA5B0", Offset = "0x1BB8DB0", VA = "0x181BBA5B0")]
		public void Add(string CEAFHMOKOGD, LFPFPAAINHE CDJCNKAFMIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1BBA3F0", Offset = "0x1BB8BF0", VA = "0x181BBA3F0")]
		public void Add(string CEAFHMOKOGD, IEnumerator FLKAKOGKABG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1BBA760", Offset = "0x1BB8F60", VA = "0x181BBA760")]
		[IteratorStateMachine(typeof(BPGMLCKDOEK))]
		private IEnumerator EBKJHPPAABJ(NNILOECJPKH CDJCNKAFMIO, IEnumerator FLKAKOGKABG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1BBA860", Offset = "0x1BB9060", VA = "0x181BBA860")]
		public AsyncBatch()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class KJHEOBFGJFA<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class FHLKCHLENLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TKey IICELGCNCMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public LFPFPAAINHE EDPNMDDPFLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public DateTime OGMELODBGBJ;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2720C80", Offset = "0x271F480", VA = "0x182720C80")]
		public FHLKCHLENLG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class OLBOPAOOMGH<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public global::KJHEOBFGJFA<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public TKey key;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2720C80", Offset = "0x271F480", VA = "0x182720C80")]
		public OLBOPAOOMGH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class IAFDFFCPFJN<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public FHLKCHLENLG cacheEntry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public OLBOPAOOMGH<TValue> CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2720C80", Offset = "0x271F480", VA = "0x182720C80")]
		public IAFDFFCPFJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3AD2460", Offset = "0x3AD0C60", VA = "0x183AD2460")]
		internal void <SetPromise>b__0(string e)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<TKey, FHLKCHLENLG> FNJKKFHKNGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private LinkedList<FHLKCHLENLG> BMONGLBPCED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private LinkedList<FHLKCHLENLG> NPPFHOKFHLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int NPENHAENMIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool FNCOMPOHJPC;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public ICollection<TKey> DKPGBFMPBHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x352B1B0", Offset = "0x35299B0", VA = "0x18352B1B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3ADD1F0", Offset = "0x3ADB9F0", VA = "0x183ADD1F0")]
	public KJHEOBFGJFA([Optional] int? NPENHAENMIF, bool FNCOMPOHJPC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x352BB70", Offset = "0x352A370", VA = "0x18352BB70")]
	public bool AJKNELFOKLC(TKey DOMICNELCFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2E93730", Offset = "0x2E91F30", VA = "0x182E93730")]
	public global::KGPLAJBADNH<TValue> NLJLPKFKFPA<TValue>(TKey DOMICNELCFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3830690", Offset = "0x382EE90", VA = "0x183830690")]
	public void AICBFKCKJNC<TValue>(TKey DOMICNELCFM, TValue HNCFAALBJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3830770", Offset = "0x382EF70", VA = "0x183830770")]
	public void AICBFKCKJNC<TValue>(TKey DOMICNELCFM, TValue HNCFAALBJCG, TimeSpan DFGOOBCIEFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3831270", Offset = "0x382FA70", VA = "0x183831270")]
	public void HJLCCMAIJBD<TValue>(TKey DOMICNELCFM, global::KGPLAJBADNH<TValue> CDJCNKAFMIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3830F10", Offset = "0x382F710", VA = "0x183830F10")]
	public void HJLCCMAIJBD<TValue>(TKey DOMICNELCFM, global::KGPLAJBADNH<TValue> CDJCNKAFMIO, TimeSpan DFGOOBCIEFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2E92ED0", Offset = "0x2E916D0", VA = "0x182E92ED0")]
	public global::KGPLAJBADNH<TValue> ICOMIGBHOGH<TValue>(TKey DOMICNELCFM, Func<global::KGPLAJBADNH<TValue>> LLNIHPIBILB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2E92D90", Offset = "0x2E91590", VA = "0x182E92D90")]
	public global::KGPLAJBADNH<TValue> ICOMIGBHOGH<TValue>(TKey DOMICNELCFM, Func<global::KGPLAJBADNH<TValue>> LLNIHPIBILB, TimeSpan DFGOOBCIEFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3ADBB20", Offset = "0x3ADA320", VA = "0x183ADBB20")]
	public bool EHAJBJDJBJH(TKey DOMICNELCFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3ADCAA0", Offset = "0x3ADB2A0", VA = "0x183ADCAA0")]
	public int OPDFJPAGOJL(Predicate<TKey> BOMBANNNNJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3ADBBA0", Offset = "0x3ADA3A0", VA = "0x183ADBBA0")]
	public void FMAHHIGMIBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3ADC8B0", Offset = "0x3ADB0B0", VA = "0x183ADC8B0")]
	private void OIFMDOHNHGB(FHLKCHLENLG ECMNIOLEFFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3ADB310", Offset = "0x3AD9B10", VA = "0x183ADB310")]
	private void BHOOAOJGABB(FHLKCHLENLG ECMNIOLEFFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3ADC170", Offset = "0x3ADA970", VA = "0x183ADC170")]
	private void JPCDMIFCOFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3ADBE90", Offset = "0x3ADA690", VA = "0x183ADBE90")]
	private bool IAENOJBEGID(FHLKCHLENLG ECMNIOLEFFM)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class IAGGKLCNKGJ
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static byte[] LHMKKNGADDJ;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private static int MGOKGGCOJHO;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static int FHPCKBOKGPL;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static BigInteger KMAGGJIIKDL;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	public IAGGKLCNKGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1BBAED0", Offset = "0x1BB96D0", VA = "0x181BBAED0")]
	private static string POIGIBFCCMB(byte[] LANKPNEAHJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1BBABA0", Offset = "0x1BB93A0", VA = "0x181BBABA0")]
	public static string MHKKELLNKIL(byte[] OCICGABDCEM, bool MDIDJMNJINP)
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
		[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
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
