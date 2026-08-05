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
		private struct AJNCBPHPLLI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public string NJMEBCJJJMB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public DPJKDCDGPPB DKEGFLFIAAH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public float? OFCCNPOLOIN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public float? BONBCJKNGCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public IDisposable AOEEMCKFANG;
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class FEAJHFIOFAD : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BED90", VA = "0x1804C0190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BED90", VA = "0x1804C0190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6A4230", Offset = "0x6A2E30", VA = "0x1806A4230")]
			[DebuggerHidden]
			public FEAJHFIOFAD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x4C0E00", Offset = "0x4BFA00", VA = "0x1804C0E00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x43EBDA0", Offset = "0x43EA9A0", VA = "0x1843EBDA0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x43EBF70", Offset = "0x43EAB70", VA = "0x1843EBF70", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class KLIDLPAPFIO : IEnumerator<object>, IEnumerator, IDisposable
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
			public PPHLALBGLJF promise;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BED90", VA = "0x1804C0190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BED90", VA = "0x1804C0190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6A4230", Offset = "0x6A2E30", VA = "0x1806A4230")]
			[DebuggerHidden]
			public KLIDLPAPFIO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x4C0E00", Offset = "0x4BFA00", VA = "0x1804C0E00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x43EBFC0", Offset = "0x43EABC0", VA = "0x1843EBFC0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x43EC010", Offset = "0x43EAC10", VA = "0x1843EC010", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private List<AJNCBPHPLLI> OIEPKKPEBIJ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool GLKNGLKGIJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x4C0160", Offset = "0x4BED60", VA = "0x1804C0160")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x5C1940", Offset = "0x5C0540", VA = "0x1805C1940")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x43EB600", Offset = "0x43EA200", VA = "0x1843EB600")]
		public static AsyncBatch Create(Transform DHGONCCILCM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x43EB700", Offset = "0x43EA300", VA = "0x1843EB700")]
		[IteratorStateMachine(typeof(FEAJHFIOFAD))]
		private IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x43EB510", Offset = "0x43EA110", VA = "0x1843EB510")]
		public void Add(string LFMIGONHLDF, DPJKDCDGPPB MCNCEECLNLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x43EB3A0", Offset = "0x43E9FA0", VA = "0x1843EB3A0")]
		public void Add(string LFMIGONHLDF, IEnumerator OOCHEHIIPLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x43EB690", Offset = "0x43EA290", VA = "0x1843EB690")]
		[IteratorStateMachine(typeof(KLIDLPAPFIO))]
		private IEnumerator FCHEFHJOKFK(PPHLALBGLJF MCNCEECLNLB, IEnumerator OOCHEHIIPLG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x43EB760", Offset = "0x43EA360", VA = "0x1843EB760")]
		public AsyncBatch()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class IMHGJHFBKFN<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class BNNOLLCJHCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TKey NOPHMIOAHBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public DPJKDCDGPPB DKEGFLFIAAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public DateTime NHHLMEACOLK;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x185CA00", Offset = "0x185B600", VA = "0x18185CA00")]
		public BNNOLLCJHCG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class LOALEEJPPBD<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public global::IMHGJHFBKFN<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public TKey key;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x185CA00", Offset = "0x185B600", VA = "0x18185CA00")]
		public LOALEEJPPBD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class GMIHAGNMJGM<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public BNNOLLCJHCG cacheEntry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public LOALEEJPPBD<TValue> CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x185CA00", Offset = "0x185B600", VA = "0x18185CA00")]
		public GMIHAGNMJGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3A2BE10", Offset = "0x3A2AA10", VA = "0x183A2BE10")]
		internal void <SetPromise>b__0(string e)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<TKey, BNNOLLCJHCG> AGCNLOJJADD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private LinkedList<BNNOLLCJHCG> AMMMHHIGFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private LinkedList<BNNOLLCJHCG> EDBCEHCOCNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int FPBHBKBBLAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool JHDPBOMFMIN;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public ICollection<TKey> LALPKOOBGBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2DBA1E0", Offset = "0x2DB8DE0", VA = "0x182DBA1E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3A2E480", Offset = "0x3A2D080", VA = "0x183A2E480")]
	public IMHGJHFBKFN([Optional] int? FPBHBKBBLAN, bool JHDPBOMFMIN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2BA6E30", Offset = "0x2BA5A30", VA = "0x182BA6E30")]
	public bool MIEKCGIMBGK(TKey FHJAGMPOINB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1B8AA20", Offset = "0x1B89620", VA = "0x181B8AA20")]
	public global::JLPBMLKOEIK<TValue> LDPJIFKFMIP<TValue>(TKey FHJAGMPOINB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x214EBA0", Offset = "0x214D7A0", VA = "0x18214EBA0")]
	public void MDFLNAJAJDN<TValue>(TKey FHJAGMPOINB, TValue CKGFDBLPDNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x214EAE0", Offset = "0x214D6E0", VA = "0x18214EAE0")]
	public void MDFLNAJAJDN<TValue>(TKey FHJAGMPOINB, TValue CKGFDBLPDNJ, TimeSpan MPAOJKDIFHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x214EA30", Offset = "0x214D630", VA = "0x18214EA30")]
	public void BGBMDOOOHLD<TValue>(TKey FHJAGMPOINB, global::JLPBMLKOEIK<TValue> MCNCEECLNLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x214E0A0", Offset = "0x214CCA0", VA = "0x18214E0A0")]
	public void BGBMDOOOHLD<TValue>(TKey FHJAGMPOINB, global::JLPBMLKOEIK<TValue> MCNCEECLNLB, TimeSpan MPAOJKDIFHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x1B8A300", Offset = "0x1B88F00", VA = "0x181B8A300")]
	public global::JLPBMLKOEIK<TValue> FPJBJPIILJF<TValue>(TKey FHJAGMPOINB, Func<global::JLPBMLKOEIK<TValue>> JHPPONEJGOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x1B8A260", Offset = "0x1B88E60", VA = "0x181B8A260")]
	public global::JLPBMLKOEIK<TValue> FPJBJPIILJF<TValue>(TKey FHJAGMPOINB, Func<global::JLPBMLKOEIK<TValue>> JHPPONEJGOH, TimeSpan MPAOJKDIFHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2DBA160", Offset = "0x2DB8D60", VA = "0x182DBA160")]
	public bool NGAMBELFHAP(TKey FHJAGMPOINB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3A2DDB0", Offset = "0x3A2C9B0", VA = "0x183A2DDB0")]
	public int BELBDOCPGAE(Predicate<TKey> KFPJMLPFFJC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2DB9B70", Offset = "0x2DB8770", VA = "0x182DB9B70")]
	public void DJMOCJEOBAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3A2DBC0", Offset = "0x3A2C7C0", VA = "0x183A2DBC0")]
	private void ALFCIKKNGOB(BNNOLLCJHCG JPHFFEMCENF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3A2E1D0", Offset = "0x3A2CDD0", VA = "0x183A2E1D0")]
	private void JLMHNPHCFGH(BNNOLLCJHCG JPHFFEMCENF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3A2E020", Offset = "0x3A2CC20", VA = "0x183A2E020")]
	private void CJDMBGBHMMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3A2DA90", Offset = "0x3A2C690", VA = "0x183A2DA90")]
	private bool ALEMPJAEAGL(BNNOLLCJHCG JPHFFEMCENF)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class DNLKDMBGAII
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static byte[] LPPEPCLGPFA;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private static int ALNIJEPLOPN;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static int BOCMDGEBMMF;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static BigInteger AOEPCALDGLN;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4C29D0", Offset = "0x4C15D0", VA = "0x1804C29D0")]
	public DNLKDMBGAII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x43EB7C0", Offset = "0x43EA3C0", VA = "0x1843EB7C0")]
	private static string ENAHEOFOPLE(byte[] HDBDBNKFPIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x43EB8C0", Offset = "0x43EA4C0", VA = "0x1843EB8C0")]
	public static string JNOEGFCEOHO(byte[] LGMOCOBILLJ, bool NNFMBLOFMHM)
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
		[Cpp2IlInjected.Address(RVA = "0x4C29D0", Offset = "0x4C15D0", VA = "0x1804C29D0")]
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
