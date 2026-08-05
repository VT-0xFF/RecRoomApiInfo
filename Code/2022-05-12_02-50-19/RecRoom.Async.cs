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
		private struct JGLHKKCFJBH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public string MDLHDLKLAEE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public DCCNBCFBHAJ BNFIAGBGNLG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public float? ACFLDDAGPNP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public float? HLNEONHBOEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public IDisposable HGEBJKBBIKK;
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class EPLDHKMMJEI : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x5521C0", Offset = "0x5515C0", VA = "0x1805521C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x5521C0", Offset = "0x5515C0", VA = "0x1805521C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6637D0", Offset = "0x662BD0", VA = "0x1806637D0")]
			[DebuggerHidden]
			public EPLDHKMMJEI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x552E80", Offset = "0x552280", VA = "0x180552E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x4DB26B0", Offset = "0x4DB1AB0", VA = "0x184DB26B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x4DB2880", Offset = "0x4DB1C80", VA = "0x184DB2880", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class GBJCALJIIDH : IEnumerator<object>, IEnumerator, IDisposable
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
			public DDLKDBDLBFL promise;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x5521C0", Offset = "0x5515C0", VA = "0x1805521C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x5521C0", Offset = "0x5515C0", VA = "0x1805521C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6637D0", Offset = "0x662BD0", VA = "0x1806637D0")]
			[DebuggerHidden]
			public GBJCALJIIDH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x552E80", Offset = "0x552280", VA = "0x180552E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x4DB28D0", Offset = "0x4DB1CD0", VA = "0x184DB28D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x4DB2930", Offset = "0x4DB1D30", VA = "0x184DB2930", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private List<JGLHKKCFJBH> FNICACAAAPM;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool NLIAJPDLOIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x552190", Offset = "0x551590", VA = "0x180552190")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x6D9560", Offset = "0x6D8960", VA = "0x1806D9560")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x4DB24B0", Offset = "0x4DB18B0", VA = "0x184DB24B0")]
		public static AsyncBatch Create(Transform PDIGOPINEPN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x4DB25D0", Offset = "0x4DB19D0", VA = "0x184DB25D0")]
		[IteratorStateMachine(typeof(EPLDHKMMJEI))]
		private IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x4DB21D0", Offset = "0x4DB15D0", VA = "0x184DB21D0")]
		public void Add(string AFIDHHDMHNB, DCCNBCFBHAJ OJCDBLDFDBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4DB22F0", Offset = "0x4DB16F0", VA = "0x184DB22F0")]
		public void Add(string AFIDHHDMHNB, IEnumerator OHHJIFCGCPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4DB2540", Offset = "0x4DB1940", VA = "0x184DB2540")]
		[IteratorStateMachine(typeof(GBJCALJIIDH))]
		private IEnumerator NLNJBHHPAIL(DDLKDBDLBFL OJCDBLDFDBK, IEnumerator OHHJIFCGCPG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4DB2640", Offset = "0x4DB1A40", VA = "0x184DB2640")]
		public AsyncBatch()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class NMJDFGOBHGL<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class NGMKCNNHEIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TKey DCBIHGMJIKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public DCCNBCFBHAJ BNFIAGBGNLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public DateTime NIGEBNGEBFL;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1C1C3B0", Offset = "0x1C1B7B0", VA = "0x181C1C3B0")]
		public NGMKCNNHEIE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class DCJPJPDAHAJ<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public global::NMJDFGOBHGL<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public TKey key;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x1C1C3B0", Offset = "0x1C1B7B0", VA = "0x181C1C3B0")]
		public DCJPJPDAHAJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class HOGNAJJPPEC<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public NGMKCNNHEIE cacheEntry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public DCJPJPDAHAJ<TValue> CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1C1C3B0", Offset = "0x1C1B7B0", VA = "0x181C1C3B0")]
		public HOGNAJJPPEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x35B0000", Offset = "0x35AF400", VA = "0x1835B0000")]
		internal void <SetPromise>b__0(string e)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<TKey, NGMKCNNHEIE> AFKOFAEODLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private LinkedList<NGMKCNNHEIE> CHIEDEKGJJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private LinkedList<NGMKCNNHEIE> MIIGOABJHNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int ANAPFJIKHHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool LDDCCKCOLIB;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public ICollection<TKey> FKDBAAIAPFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1EF8040", Offset = "0x1EF7440", VA = "0x181EF8040")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x35C3BB0", Offset = "0x35C2FB0", VA = "0x1835C3BB0")]
	public NMJDFGOBHGL([Optional] int? ANAPFJIKHHJ, bool LDDCCKCOLIB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2924F20", Offset = "0x2924320", VA = "0x182924F20")]
	public bool NIGFKNBLCPA(TKey KACNOLACOBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2AE3920", Offset = "0x2AE2D20", VA = "0x182AE3920")]
	public global::OIKEDAHIDPO<TValue> ENEPLELFIND<TValue>(TKey KACNOLACOBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3B2B970", Offset = "0x3B2AD70", VA = "0x183B2B970")]
	public void DHOEGJJCPKM<TValue>(TKey KACNOLACOBJ, TValue MGNFAPLJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3B2BA50", Offset = "0x3B2AE50", VA = "0x183B2BA50")]
	public void DHOEGJJCPKM<TValue>(TKey KACNOLACOBJ, TValue MGNFAPLJAOB, TimeSpan KJEMPKAEGBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3B2C1F0", Offset = "0x3B2B5F0", VA = "0x183B2C1F0")]
	public void JDHHICMDAKL<TValue>(TKey KACNOLACOBJ, global::OIKEDAHIDPO<TValue> OJCDBLDFDBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3B2C610", Offset = "0x3B2BA10", VA = "0x183B2C610")]
	public void JDHHICMDAKL<TValue>(TKey KACNOLACOBJ, global::OIKEDAHIDPO<TValue> OJCDBLDFDBK, TimeSpan KJEMPKAEGBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2AE3EB0", Offset = "0x2AE32B0", VA = "0x182AE3EB0")]
	public global::OIKEDAHIDPO<TValue> KACBDLJMLJB<TValue>(TKey KACNOLACOBJ, Func<global::OIKEDAHIDPO<TValue>> HOJEMNPJOJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2AE3CC0", Offset = "0x2AE30C0", VA = "0x182AE3CC0")]
	public global::OIKEDAHIDPO<TValue> KACBDLJMLJB<TValue>(TKey KACNOLACOBJ, Func<global::OIKEDAHIDPO<TValue>> HOJEMNPJOJG, TimeSpan KJEMPKAEGBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x35C2750", Offset = "0x35C1B50", VA = "0x1835C2750")]
	public bool EPGMMIBEDJL(TKey KACNOLACOBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x35C2000", Offset = "0x35C1400", VA = "0x1835C2000")]
	public int EKBMAOKGGAN(Predicate<TKey> ECHCLPMDDAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x35C3940", Offset = "0x35C2D40", VA = "0x1835C3940")]
	public void PDAIKLBALNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x35C3750", Offset = "0x35C2B50", VA = "0x1835C3750")]
	private void OKMHFOMHPHE(NGMKCNNHEIE HOJECEOGPJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x35C2B60", Offset = "0x35C1F60", VA = "0x1835C2B60")]
	private void OBLPHAMELFN(NGMKCNNHEIE HOJECEOGPJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x35C1CA0", Offset = "0x35C10A0", VA = "0x1835C1CA0")]
	private void DIDANKKPJGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x35C2A30", Offset = "0x35C1E30", VA = "0x1835C2A30")]
	private bool NMEEEAHBECF(NGMKCNNHEIE HOJECEOGPJG)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class HAEMGHNAAMP
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static byte[] AOHONNKPCGG;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private static int JJMCEBLKFDI;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static int GDGIIBGHMLJ;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static BigInteger PODBKFNIFLC;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	public HAEMGHNAAMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4DB2980", Offset = "0x4DB1D80", VA = "0x184DB2980")]
	private static string BJIMPFHNNLK(byte[] FFOHEAHJJEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4DB2A80", Offset = "0x4DB1E80", VA = "0x184DB2A80")]
	public static string LFJGIPFBMOM(byte[] MFCIHENGNMD, bool MBOLNOOKBJO)
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
		[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
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
