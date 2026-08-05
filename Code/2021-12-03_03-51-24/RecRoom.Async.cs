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
		private struct MKHMOPANNHB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public string KMBGCHDFCPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public MLALFLMLHEI KAOMNEPPLOC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public float? CDCGPJHJFOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public float? BABLGHDDGED;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public IDisposable AJHJOEDAHEJ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class CBNNCGBGKDO : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x46F190", Offset = "0x46E390", VA = "0x18046F190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x46F190", Offset = "0x46E390", VA = "0x18046F190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6000D0", Offset = "0x5FF2D0", VA = "0x1806000D0")]
			[DebuggerHidden]
			public CBNNCGBGKDO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x46FE00", Offset = "0x46F000", VA = "0x18046FE00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x3F97140", Offset = "0x3F96340", VA = "0x183F97140", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x3F97310", Offset = "0x3F96510", VA = "0x183F97310", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class CKCBJLEHJGM : IEnumerator<object>, IEnumerator, IDisposable
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
			public LMLIEBFGMMN promise;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x46F190", Offset = "0x46E390", VA = "0x18046F190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x46F190", Offset = "0x46E390", VA = "0x18046F190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6000D0", Offset = "0x5FF2D0", VA = "0x1806000D0")]
			[DebuggerHidden]
			public CKCBJLEHJGM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x46FE00", Offset = "0x46F000", VA = "0x18046FE00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x3F97360", Offset = "0x3F96560", VA = "0x183F97360", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x3F973B0", Offset = "0x3F965B0", VA = "0x183F973B0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private List<MKHMOPANNHB> KFIONIGHIFM;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool AAPAGKPHKME
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x46F160", Offset = "0x46E360", VA = "0x18046F160")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x551600", Offset = "0x550800", VA = "0x180551600")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x3F96FF0", Offset = "0x3F961F0", VA = "0x183F96FF0")]
		public static AsyncBatch Create(Transform AJIKAKHMHEA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x3F97080", Offset = "0x3F96280", VA = "0x183F97080")]
		[IteratorStateMachine(typeof(CBNNCGBGKDO))]
		private IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3F96F00", Offset = "0x3F96100", VA = "0x183F96F00")]
		public void Add(string OMNGGFHPHNL, MLALFLMLHEI BAEPNLBPEOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3F96D90", Offset = "0x3F95F90", VA = "0x183F96D90")]
		public void Add(string OMNGGFHPHNL, IEnumerator EMOEBNMDKJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3F96D20", Offset = "0x3F95F20", VA = "0x183F96D20")]
		[IteratorStateMachine(typeof(CKCBJLEHJGM))]
		private IEnumerator AIBHKPAEMDD(LMLIEBFGMMN BAEPNLBPEOA, IEnumerator EMOEBNMDKJF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3F970E0", Offset = "0x3F962E0", VA = "0x183F970E0")]
		public AsyncBatch()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class OILBJJIJJNJ<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class MFEHPGCEJDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TKey BODKPPKNCIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public MLALFLMLHEI KAOMNEPPLOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public DateTime LJJODLKFJND;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x16A1F20", Offset = "0x16A1120", VA = "0x1816A1F20")]
		public MFEHPGCEJDP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class EEDMEAEEONE<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public global::OILBJJIJJNJ<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public TKey key;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x16A1F20", Offset = "0x16A1120", VA = "0x1816A1F20")]
		public EEDMEAEEONE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class MFCMLDCNOHJ<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public MFEHPGCEJDP cacheEntry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public EEDMEAEEONE<TValue> CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x16A1F20", Offset = "0x16A1120", VA = "0x1816A1F20")]
		public MFCMLDCNOHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2C70AC0", Offset = "0x2C6FCC0", VA = "0x182C70AC0")]
		internal void <SetPromise>b__0(string e)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<TKey, MFEHPGCEJDP> ECBEMAPBCHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private LinkedList<MFEHPGCEJDP> PIGLHKCJNLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private LinkedList<MFEHPGCEJDP> CADAJJOELLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int KBEELDDOOGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool JIAEHKJHJPC;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public ICollection<TKey> HEPLEIHKNFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x206B740", Offset = "0x206A940", VA = "0x18206B740")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2C73E10", Offset = "0x2C73010", VA = "0x182C73E10")]
	public OILBJJIJJNJ([Optional] int? KBEELDDOOGM, bool JIAEHKJHJPC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x206B6E0", Offset = "0x206A8E0", VA = "0x18206B6E0")]
	public bool LPNCNLAEOGF(TKey FIIDMDOOCIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1B1EC90", Offset = "0x1B1DE90", VA = "0x181B1EC90")]
	public global::GFAADABKIAG<TValue> MGIPGAPHILG<TValue>(TKey FIIDMDOOCIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1C0F100", Offset = "0x1C0E300", VA = "0x181C0F100")]
	public void EHIDOAEMAAH<TValue>(TKey FIIDMDOOCIB, TValue LNFKIKOILLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1C0F040", Offset = "0x1C0E240", VA = "0x181C0F040")]
	public void EHIDOAEMAAH<TValue>(TKey FIIDMDOOCIB, TValue LNFKIKOILLL, TimeSpan OFPPADKHAKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x1C0E930", Offset = "0x1C0DB30", VA = "0x181C0E930")]
	public void CPELLBNDAAB<TValue>(TKey FIIDMDOOCIB, global::GFAADABKIAG<TValue> BAEPNLBPEOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1C0E9E0", Offset = "0x1C0DBE0", VA = "0x181C0E9E0")]
	public void CPELLBNDAAB<TValue>(TKey FIIDMDOOCIB, global::GFAADABKIAG<TValue> BAEPNLBPEOA, TimeSpan OFPPADKHAKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x1B1E480", Offset = "0x1B1D680", VA = "0x181B1E480")]
	public global::GFAADABKIAG<TValue> COPGOILOLIF<TValue>(TKey FIIDMDOOCIB, Func<global::GFAADABKIAG<TValue>> AJLBBNGAODB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x1B1E330", Offset = "0x1B1D530", VA = "0x181B1E330")]
	public global::GFAADABKIAG<TValue> COPGOILOLIF<TValue>(TKey FIIDMDOOCIB, Func<global::GFAADABKIAG<TValue>> AJLBBNGAODB, TimeSpan OFPPADKHAKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2C73500", Offset = "0x2C72700", VA = "0x182C73500")]
	public bool KKEHNCMNHLE(TKey FIIDMDOOCIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2C72090", Offset = "0x2C71290", VA = "0x182C72090")]
	public int BIFJIAKOEJI(Predicate<TKey> HMCAODFFIIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2C728D0", Offset = "0x2C71AD0", VA = "0x182C728D0")]
	public void FDPJNEGBNGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2C72300", Offset = "0x2C71500", VA = "0x182C72300")]
	private void DCFIEAEAICI(MFEHPGCEJDP PDMGBNIOPMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2C72C10", Offset = "0x2C71E10", VA = "0x182C72C10")]
	private void IDNGKFNFIDJ(MFEHPGCEJDP PDMGBNIOPMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2C738E0", Offset = "0x2C72AE0", VA = "0x182C738E0")]
	private void POBEPABIAGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2C732A0", Offset = "0x2C724A0", VA = "0x182C732A0")]
	private bool JGAOGPKLJPI(MFEHPGCEJDP PDMGBNIOPMD)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class PCNMAEEHMFA
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static byte[] JCMJECHILOC;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private static int BNIACGCEGJA;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static int BOLEHDFPPKM;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static BigInteger IJJDCIAOLCD;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4719D0", Offset = "0x470BD0", VA = "0x1804719D0")]
	public PCNMAEEHMFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3F97400", Offset = "0x3F96600", VA = "0x183F97400")]
	private static string MFCANKEIEIP(byte[] BECJLMJILAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3F97500", Offset = "0x3F96700", VA = "0x183F97500")]
	public static string MMKAAAJKMHB(byte[] MNCFCOKJIPF, bool EGIHCEJJLCP)
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
		[Cpp2IlInjected.Address(RVA = "0x4719D0", Offset = "0x470BD0", VA = "0x1804719D0")]
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
