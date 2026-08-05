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
		private struct EJCNMCLOLCM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public string IAPKIIHBPPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public EDDKJIPNMLB LFIAEJIFAJF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public float? CNOJKNOBFAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public float? MAFOEONIBPB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public IDisposable KOLCBIOCOLN;
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class KOLIBKLLPJP : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x51C1C0", Offset = "0x51AFC0", VA = "0x18051C1C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x51C1C0", Offset = "0x51AFC0", VA = "0x18051C1C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x62D7D0", Offset = "0x62C5D0", VA = "0x18062D7D0")]
			[DebuggerHidden]
			public KOLIBKLLPJP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x51CE80", Offset = "0x51BC80", VA = "0x18051CE80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x4AE0650", Offset = "0x4ADF450", VA = "0x184AE0650", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x4AE0820", Offset = "0x4ADF620", VA = "0x184AE0820", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class GIDPGKDDPHJ : IEnumerator<object>, IEnumerator, IDisposable
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
			public JMFCAGKBFOE promise;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x51C1C0", Offset = "0x51AFC0", VA = "0x18051C1C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x51C1C0", Offset = "0x51AFC0", VA = "0x18051C1C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x62D7D0", Offset = "0x62C5D0", VA = "0x18062D7D0")]
			[DebuggerHidden]
			public GIDPGKDDPHJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x51CE80", Offset = "0x51BC80", VA = "0x18051CE80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x4AE05A0", Offset = "0x4ADF3A0", VA = "0x184AE05A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x4AE0600", Offset = "0x4ADF400", VA = "0x184AE0600", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private List<EJCNMCLOLCM> ANFKKNFBHEP;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool EFGCFHIDIDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x51C190", Offset = "0x51AF90", VA = "0x18051C190")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x676E40", Offset = "0x675C40", VA = "0x180676E40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x4AE03A0", Offset = "0x4ADF1A0", VA = "0x184AE03A0")]
		public static AsyncBatch Create(Transform DEGLKKAFDCN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x4AE04C0", Offset = "0x4ADF2C0", VA = "0x184AE04C0")]
		[IteratorStateMachine(typeof(KOLIBKLLPJP))]
		private IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x4AE0280", Offset = "0x4ADF080", VA = "0x184AE0280")]
		public void Add(string HPAMGGFODJL, EDDKJIPNMLB GDJKJKEPKOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4AE00C0", Offset = "0x4ADEEC0", VA = "0x184AE00C0")]
		public void Add(string HPAMGGFODJL, IEnumerator LCLABOOPDIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4AE0430", Offset = "0x4ADF230", VA = "0x184AE0430")]
		[IteratorStateMachine(typeof(GIDPGKDDPHJ))]
		private IEnumerator LLLFGDDDEDC(JMFCAGKBFOE GDJKJKEPKOD, IEnumerator LCLABOOPDIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4AE0530", Offset = "0x4ADF330", VA = "0x184AE0530")]
		public AsyncBatch()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class LANHLHKIDOH<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class GIEJMKGHKJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TKey AEAEDHDPBGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public EDDKJIPNMLB LFIAEJIFAJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public DateTime ENMPGLFPEDI;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1B58430", Offset = "0x1B57230", VA = "0x181B58430")]
		public GIEJMKGHKJO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class EIBDOIJINGB<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public global::LANHLHKIDOH<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public TKey key;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x1B58430", Offset = "0x1B57230", VA = "0x181B58430")]
		public EIBDOIJINGB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class CFBCIEOIOEF<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public GIEJMKGHKJO cacheEntry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public EIBDOIJINGB<TValue> CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1B58430", Offset = "0x1B57230", VA = "0x181B58430")]
		public CFBCIEOIOEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3ED2250", Offset = "0x3ED1050", VA = "0x183ED2250")]
		internal void <SetPromise>b__0(string e)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<TKey, GIEJMKGHKJO> ENJCPECAECN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private LinkedList<GIEJMKGHKJO> CIIHFMPDAGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private LinkedList<GIEJMKGHKJO> ANFNBFKAIAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int FGCKLNCGBIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool ILPKPDLCEKI;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public ICollection<TKey> JOIAKEPJDIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2999E90", Offset = "0x2998C90", VA = "0x182999E90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3EDBE50", Offset = "0x3EDAC50", VA = "0x183EDBE50")]
	public LANHLHKIDOH([Optional] int? FGCKLNCGBIO, bool ILPKPDLCEKI = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x29999B0", Offset = "0x29987B0", VA = "0x1829999B0")]
	public bool PNOLIKCGLNL(TKey LHOJNLGGKDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2260A50", Offset = "0x225F850", VA = "0x182260A50")]
	public global::BKHPMHDEEIP<TValue> IOCLNDHCNMI<TValue>(TKey LHOJNLGGKDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x290BE00", Offset = "0x290AC00", VA = "0x18290BE00")]
	public void ENBHPLNDOIC<TValue>(TKey LHOJNLGGKDH, TValue KCFMHIDCDCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x290BD40", Offset = "0x290AB40", VA = "0x18290BD40")]
	public void ENBHPLNDOIC<TValue>(TKey LHOJNLGGKDH, TValue KCFMHIDCDCO, TimeSpan CBEGEEBHFOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x290BC90", Offset = "0x290AA90", VA = "0x18290BC90")]
	public void BEELGEAFFEB<TValue>(TKey LHOJNLGGKDH, global::BKHPMHDEEIP<TValue> GDJKJKEPKOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x290B930", Offset = "0x290A730", VA = "0x18290B930")]
	public void BEELGEAFFEB<TValue>(TKey LHOJNLGGKDH, global::BKHPMHDEEIP<TValue> GDJKJKEPKOD, TimeSpan CBEGEEBHFOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x22604F0", Offset = "0x225F2F0", VA = "0x1822604F0")]
	public global::BKHPMHDEEIP<TValue> FFECAGCPMPA<TValue>(TKey LHOJNLGGKDH, Func<global::BKHPMHDEEIP<TValue>> COAMDCNKKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2260450", Offset = "0x225F250", VA = "0x182260450")]
	public global::BKHPMHDEEIP<TValue> FFECAGCPMPA<TValue>(TKey LHOJNLGGKDH, Func<global::BKHPMHDEEIP<TValue>> COAMDCNKKFG, TimeSpan CBEGEEBHFOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3EDB200", Offset = "0x3EDA000", VA = "0x183EDB200")]
	public bool FKDIFICKHIH(TKey LHOJNLGGKDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3EDA270", Offset = "0x3ED9070", VA = "0x183EDA270")]
	public int BHJAPHPMKPF(Predicate<TKey> MHAJCDIKHBJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3EDB280", Offset = "0x3EDA080", VA = "0x183EDB280")]
	public void GGFJFJEKGGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3EDB6F0", Offset = "0x3EDA4F0", VA = "0x183EDB6F0")]
	private void HMPMGIHBNPM(GIEJMKGHKJO IEIKJKLEFHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3EDAA40", Offset = "0x3ED9840", VA = "0x183EDAA40")]
	private void CMEBKGAGECB(GIEJMKGHKJO IEIKJKLEFHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3EDACF0", Offset = "0x3ED9AF0", VA = "0x183EDACF0")]
	private void DOAIMPHNDDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3EDB8E0", Offset = "0x3EDA6E0", VA = "0x183EDB8E0")]
	private bool PFDILFHLALC(GIEJMKGHKJO IEIKJKLEFHJ)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class MLACDHJHDFG
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static byte[] PCFDJLIAIEK;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private static int CNEHBAAIPJM;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static int NEIKIABHABD;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static BigInteger NOAFCEFHHAN;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	public MLACDHJHDFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4AE0870", Offset = "0x4ADF670", VA = "0x184AE0870")]
	private static string JLOFJIHEBDA(byte[] KBBKPHEOPAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4AE0970", Offset = "0x4ADF770", VA = "0x184AE0970")]
	public static string NCFNLEDFEPP(byte[] NBHAFAAIDII, bool IGLBINIMLIE)
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
		[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
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
