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
		private struct EAEDMEIIHNI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public string HDFENLJJFDG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public EPHEJFPBCIA KNCNJHMLOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public float? JJMHCKMPDKH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public float? BIHCIOGKLKD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public IDisposable JKMICLCIDCK;
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class MJIGOODGMCE : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x576C50", Offset = "0x575850", VA = "0x180576C50")]
			[DebuggerHidden]
			public MJIGOODGMCE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E730", VA = "0x18054FB30", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x17DE920", Offset = "0x17DD520", VA = "0x1817DE920", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x17DEAF0", Offset = "0x17DD6F0", VA = "0x1817DEAF0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class JMEDMBELICM : IEnumerator<object>, IEnumerator, IDisposable
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
			public MCMONDMICNG promise;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x576C50", Offset = "0x575850", VA = "0x180576C50")]
			[DebuggerHidden]
			public JMEDMBELICM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E730", VA = "0x18054FB30", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x17DE870", Offset = "0x17DD470", VA = "0x1817DE870", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x17DE8D0", Offset = "0x17DD4D0", VA = "0x1817DE8D0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private List<EAEDMEIIHNI> BMJOMDAAHBG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool MONCEHKLPEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x576EB0", Offset = "0x575AB0", VA = "0x180576EB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x620AD0", Offset = "0x61F6D0", VA = "0x180620AD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x17DE080", Offset = "0x17DCC80", VA = "0x1817DE080")]
		public static AsyncBatch Create(Transform IDFFNMDMLBG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x17DE1A0", Offset = "0x17DCDA0", VA = "0x1817DE1A0")]
		[IteratorStateMachine(typeof(MJIGOODGMCE))]
		private IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x17DDF60", Offset = "0x17DCB60", VA = "0x1817DDF60")]
		public void Add(string FFOAIHIIDHB, EPHEJFPBCIA BBGFFDMJNNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x17DDDA0", Offset = "0x17DC9A0", VA = "0x1817DDDA0")]
		public void Add(string FFOAIHIIDHB, IEnumerator FNPAELAEPKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x17DE110", Offset = "0x17DCD10", VA = "0x1817DE110")]
		[IteratorStateMachine(typeof(JMEDMBELICM))]
		private IEnumerator MODGJCCEBBG(MCMONDMICNG BBGFFDMJNNM, IEnumerator FNPAELAEPKK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x17DE210", Offset = "0x17DCE10", VA = "0x1817DE210")]
		public AsyncBatch()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class EAINDNGGGJG<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class LNFKHCJADDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TKey CGBHHKNJCCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public EPHEJFPBCIA KNCNJHMLOKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public DateTime NBOCLEFGKNM;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760490", VA = "0x180761890")]
		public LNFKHCJADDF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class NIFLHECIFJB<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public global::EAINDNGGGJG<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public TKey key;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760490", VA = "0x180761890")]
		public NIFLHECIFJB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class BMMDNKNNGAE<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public LNFKHCJADDF cacheEntry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public NIFLHECIFJB<TValue> CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760490", VA = "0x180761890")]
		public BMMDNKNNGAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x32D4D70", Offset = "0x32D3970", VA = "0x1832D4D70")]
		internal void <SetPromise>b__0(string e)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<TKey, LNFKHCJADDF> PHIGJGFEFCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private LinkedList<LNFKHCJADDF> BNHGJEBGCPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private LinkedList<LNFKHCJADDF> FBMHAHHIBBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int LBCCFPLNDIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool PHFIEPDDBMB;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public ICollection<TKey> OEDAOHBDPEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1009F40", Offset = "0x1008B40", VA = "0x181009F40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x32DE2C0", Offset = "0x32DCEC0", VA = "0x1832DE2C0")]
	public EAINDNGGGJG([Optional] int? LBCCFPLNDIN, bool PHFIEPDDBMB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x11EDD40", Offset = "0x11EC940", VA = "0x1811EDD40")]
	public bool KMGMCJBOOIA(TKey GMCMHIFODNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2F16500", Offset = "0x2F15100", VA = "0x182F16500")]
	public global::NHGODCKFGMA<TValue> ODNOHJFCDJE<TValue>(TKey GMCMHIFODNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2CD9910", Offset = "0x2CD8510", VA = "0x182CD9910")]
	public void PBKLIEGIDKB<TValue>(TKey GMCMHIFODNN, TValue JHEBJPCMJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2CD9850", Offset = "0x2CD8450", VA = "0x182CD9850")]
	public void PBKLIEGIDKB<TValue>(TKey GMCMHIFODNN, TValue JHEBJPCMJGD, TimeSpan MHHBJINDBEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2CD90E0", Offset = "0x2CD7CE0", VA = "0x182CD90E0")]
	public void ENBDMNDFHOA<TValue>(TKey GMCMHIFODNN, global::NHGODCKFGMA<TValue> BBGFFDMJNNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2CD94F0", Offset = "0x2CD80F0", VA = "0x182CD94F0")]
	public void ENBDMNDFHOA<TValue>(TKey GMCMHIFODNN, global::NHGODCKFGMA<TValue> BBGFFDMJNNM, TimeSpan MHHBJINDBEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2F15C00", Offset = "0x2F14800", VA = "0x182F15C00")]
	public global::NHGODCKFGMA<TValue> OANHBMDBNFO<TValue>(TKey GMCMHIFODNN, Func<global::NHGODCKFGMA<TValue>> NMPDFBFNHLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2F15B60", Offset = "0x2F14760", VA = "0x182F15B60")]
	public global::NHGODCKFGMA<TValue> OANHBMDBNFO<TValue>(TKey GMCMHIFODNN, Func<global::NHGODCKFGMA<TValue>> NMPDFBFNHLJ, TimeSpan MHHBJINDBEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x32DC710", Offset = "0x32DB310", VA = "0x1832DC710")]
	public bool AFEKNPNIBII(TKey GMCMHIFODNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x32DCD00", Offset = "0x32DB900", VA = "0x1832DCD00")]
	public int KBAECKANOCB(Predicate<TKey> LJGPHPEILDI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x32DC790", Offset = "0x32DB390", VA = "0x1832DC790")]
	public void IJBCCCJHCJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x32DD970", Offset = "0x32DC570", VA = "0x1832DD970")]
	private void NPGKLFLMKEI(LNFKHCJADDF APKDEHBNDEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x32DD4D0", Offset = "0x32DC0D0", VA = "0x1832DD4D0")]
	private void MOHDOGEJIPE(LNFKHCJADDF APKDEHBNDEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x32DC3B0", Offset = "0x32DAFB0", VA = "0x1832DC3B0")]
	private void ABLOEPHAEMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x32DDD50", Offset = "0x32DC950", VA = "0x1832DDD50")]
	private bool PGFFBKCELNJ(LNFKHCJADDF APKDEHBNDEA)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class DFHLNHOECAE
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static byte[] BPCJOEHDNHL;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private static int JGOMGPKCOBP;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static int EJPBFKNOMCK;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static BigInteger DKHAKAEJLPK;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public DFHLNHOECAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x17DE280", Offset = "0x17DCE80", VA = "0x1817DE280")]
	private static string ALAJABKKJNA(byte[] JCHDICMDCKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x17DE380", Offset = "0x17DCF80", VA = "0x1817DE380")]
	public static string NBAPPGOEMPA(byte[] GLAICJAMEED, bool NFOOKAPIMMN)
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
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
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
