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
		private struct DKDHNKEAJJG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public string DDBCGNNCNNM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public EBJFPPEJHJH PBDMDBCANNI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public float? OGAKIIGMNKJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public float? GAMGMCPLONF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public IDisposable PFMKFEFMCPB;
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class LMKGHFNHNKK : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x428190", Offset = "0x427190", VA = "0x180428190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x428190", Offset = "0x427190", VA = "0x180428190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x513CF0", Offset = "0x512CF0", VA = "0x180513CF0")]
			[DebuggerHidden]
			public LMKGHFNHNKK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x428E00", Offset = "0x427E00", VA = "0x180428E00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x3D97130", Offset = "0x3D96130", VA = "0x183D97130", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x3D97300", Offset = "0x3D96300", VA = "0x183D97300", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class HGMFEKBINFF : IEnumerator<object>, IEnumerator, IDisposable
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
			public CLCJEEPDPCK promise;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x428190", Offset = "0x427190", VA = "0x180428190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x428190", Offset = "0x427190", VA = "0x180428190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x513CF0", Offset = "0x512CF0", VA = "0x180513CF0")]
			[DebuggerHidden]
			public HGMFEKBINFF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x428E00", Offset = "0x427E00", VA = "0x180428E00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x3D96AB0", Offset = "0x3D95AB0", VA = "0x183D96AB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x3D96B00", Offset = "0x3D95B00", VA = "0x183D96B00", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private List<DKDHNKEAJJG> MHDHEPDIOPP;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool LBMOBJCNLCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x428160", Offset = "0x427160", VA = "0x180428160")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x539D10", Offset = "0x538D10", VA = "0x180539D10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x3D968F0", Offset = "0x3D958F0", VA = "0x183D968F0")]
		public static AsyncBatch Create(Transform IJIGCJIFIBA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x3D969F0", Offset = "0x3D959F0", VA = "0x183D969F0")]
		[IteratorStateMachine(typeof(LMKGHFNHNKK))]
		private IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3D96800", Offset = "0x3D95800", VA = "0x183D96800")]
		public void Add(string PNEIKPKKABO, EBJFPPEJHJH GIEFOJPBPGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3D96690", Offset = "0x3D95690", VA = "0x183D96690")]
		public void Add(string PNEIKPKKABO, IEnumerator KIOHDKHAJOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3D96980", Offset = "0x3D95980", VA = "0x183D96980")]
		[IteratorStateMachine(typeof(HGMFEKBINFF))]
		private IEnumerator EFMOMDPBBLP(CLCJEEPDPCK GIEFOJPBPGE, IEnumerator KIOHDKHAJOH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3D96A50", Offset = "0x3D95A50", VA = "0x183D96A50")]
		public AsyncBatch()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class DALPFEALMKN<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class DAENHPIJCKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TKey IMOMDNMFBED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public EBJFPPEJHJH PBDMDBCANNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public DateTime IOEEIAPKABE;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x17681B0", Offset = "0x17671B0", VA = "0x1817681B0")]
		public DAENHPIJCKG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class ICDLBLPLHNO<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public global::DALPFEALMKN<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public TKey key;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x17681B0", Offset = "0x17671B0", VA = "0x1817681B0")]
		public ICDLBLPLHNO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class PLOHIPPEMAI<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public DAENHPIJCKG cacheEntry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public ICDLBLPLHNO<TValue> CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x17681B0", Offset = "0x17671B0", VA = "0x1817681B0")]
		public PLOHIPPEMAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x31AB150", Offset = "0x31AA150", VA = "0x1831AB150")]
		internal void <SetPromise>b__0(string e)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<TKey, DAENHPIJCKG> CDBAJJCEPCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private LinkedList<DAENHPIJCKG> JJPJKPMBHBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private LinkedList<DAENHPIJCKG> LGKAANKIOOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int HGOKNEGJFMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool OIECCHFLEDP;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public ICollection<TKey> LMFPANKGGKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1C036E0", Offset = "0x1C026E0", VA = "0x181C036E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x319C6D0", Offset = "0x319B6D0", VA = "0x18319C6D0")]
	public DALPFEALMKN([Optional] int? HGOKNEGJFMM, bool OIECCHFLEDP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1C03470", Offset = "0x1C02470", VA = "0x181C03470")]
	public bool PFLHDDAOKMA(TKey FNHMPFHLGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x21FDF40", Offset = "0x21FCF40", VA = "0x1821FDF40")]
	public global::CFGAGIADBID<TValue> CHIHJIFCIAK<TValue>(TKey FNHMPFHLGJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2089C00", Offset = "0x2088C00", VA = "0x182089C00")]
	public void DKLBCKPLLMN<TValue>(TKey FNHMPFHLGJM, TValue DAPPHEJJLEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2089CE0", Offset = "0x2088CE0", VA = "0x182089CE0")]
	public void DKLBCKPLLMN<TValue>(TKey FNHMPFHLGJM, TValue DAPPHEJJLEB, TimeSpan OPAMLHGPLNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x208A400", Offset = "0x2089400", VA = "0x18208A400")]
	public void EEAMJDLFFDF<TValue>(TKey FNHMPFHLGJM, global::CFGAGIADBID<TValue> GIEFOJPBPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x208AB10", Offset = "0x2089B10", VA = "0x18208AB10")]
	public void EEAMJDLFFDF<TValue>(TKey FNHMPFHLGJM, global::CFGAGIADBID<TValue> GIEFOJPBPGE, TimeSpan OPAMLHGPLNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x21FDB50", Offset = "0x21FCB50", VA = "0x1821FDB50")]
	public global::CFGAGIADBID<TValue> ALHNGFONJAA<TValue>(TKey FNHMPFHLGJM, Func<global::CFGAGIADBID<TValue>> NMEPEFECIJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x21FD960", Offset = "0x21FC960", VA = "0x1821FD960")]
	public global::CFGAGIADBID<TValue> ALHNGFONJAA<TValue>(TKey FNHMPFHLGJM, Func<global::CFGAGIADBID<TValue>> NMEPEFECIJA, TimeSpan OPAMLHGPLNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x319AED0", Offset = "0x3199ED0", VA = "0x18319AED0")]
	public bool DFMMJKLLKMC(TKey FNHMPFHLGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x319AF50", Offset = "0x3199F50", VA = "0x18319AF50")]
	public int DKBEHNBONPE(Predicate<TKey> PCNPAEEPMJK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x319AE40", Offset = "0x3199E40", VA = "0x18319AE40")]
	public void CIIJOJFGHKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x319BA30", Offset = "0x319AA30", VA = "0x18319BA30")]
	private void GBMPCEPCLKB(DAENHPIJCKG PEIGBGEIBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x319A630", Offset = "0x3199630", VA = "0x18319A630")]
	private void BKJJAOEFCKH(DAENHPIJCKG PEIGBGEIBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x319C1B0", Offset = "0x319B1B0", VA = "0x18319C1B0")]
	private void NKMPNPPIDAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x319B6A0", Offset = "0x319A6A0", VA = "0x18319B6A0")]
	private bool FNJMHMCGAHD(DAENHPIJCKG PEIGBGEIBDO)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class LGDKMIAMCPL
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static byte[] LLKCDANIMKG;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private static int KMKLKIAMDMD;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static int BIIMDIBEBNB;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static BigInteger IFDENKAOIAA;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x42A9D0", Offset = "0x4299D0", VA = "0x18042A9D0")]
	public LGDKMIAMCPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3D96B50", Offset = "0x3D95B50", VA = "0x183D96B50")]
	private static string CIKBPDDNPOK(byte[] AFFHLKNKJIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3D96C50", Offset = "0x3D95C50", VA = "0x183D96C50")]
	public static string PKHKMHCALIH(byte[] CKHCBGBCFMM, bool INBKMGGNPMJ)
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
		[Cpp2IlInjected.Address(RVA = "0x42A9D0", Offset = "0x4299D0", VA = "0x18042A9D0")]
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
