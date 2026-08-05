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
		private struct HDIHOMNKAPB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public string FIKEBGGCDFN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public DABKFAIHBBP BAINEAGHDEH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public float? LIPFBIGFEBG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public float? MAFEFHEPIKI;
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class LLLKGHKAKAK : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public AsyncBatch <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600000C")]
				[Cpp2IlInjected.Address(RVA = "0x3E6170", Offset = "0x3E5170", VA = "0x1803E6170", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x3E6170", Offset = "0x3E5170", VA = "0x1803E6170", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x40B080", Offset = "0x40A080", VA = "0x18040B080")]
			[DebuggerHidden]
			public LLLKGHKAKAK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x3EFCA0", Offset = "0x3EECA0", VA = "0x1803EFCA0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x1D760B0", Offset = "0x1D750B0", VA = "0x181D760B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x1D76240", Offset = "0x1D75240", VA = "0x181D76240", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class LEFCHIGGAAJ : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public IEnumerator coroutine;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public JJEKJGALHKO promise;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x3E6170", Offset = "0x3E5170", VA = "0x1803E6170", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x3E6170", Offset = "0x3E5170", VA = "0x1803E6170", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x40B080", Offset = "0x40A080", VA = "0x18040B080")]
			[DebuggerHidden]
			public LEFCHIGGAAJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x3EFCA0", Offset = "0x3EECA0", VA = "0x1803EFCA0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x1D76010", Offset = "0x1D75010", VA = "0x181D76010", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x1D76060", Offset = "0x1D75060", VA = "0x181D76060", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private List<HDIHOMNKAPB> CIJEPKJLNKK;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool OAPDALMAPME
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x495760", Offset = "0x494760", VA = "0x180495760")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x50E680", Offset = "0x50D680", VA = "0x18050E680")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x1D75870", Offset = "0x1D74870", VA = "0x181D75870")]
		public static AsyncBatch Create(Transform HICENEOPGOF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1D75970", Offset = "0x1D74970", VA = "0x181D75970")]
		[IteratorStateMachine(typeof(LLLKGHKAKAK))]
		private IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1D75640", Offset = "0x1D74640", VA = "0x181D75640")]
		public void Add(string MMBOKOLAJFH, DABKFAIHBBP NKLGAGCHGPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1D75710", Offset = "0x1D74710", VA = "0x181D75710")]
		public void Add(string MMBOKOLAJFH, IEnumerator LOIIKGFHHAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1D75900", Offset = "0x1D74900", VA = "0x181D75900")]
		[IteratorStateMachine(typeof(LEFCHIGGAAJ))]
		private IEnumerator OBEEEPKOOCO(JJEKJGALHKO NKLGAGCHGPM, IEnumerator LOIIKGFHHAA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1D759D0", Offset = "0x1D749D0", VA = "0x181D759D0")]
		public AsyncBatch()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class AKLAFDGACEM<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class HHOAAFPELDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public TKey AKFDMGLACLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public DABKFAIHBBP BAINEAGHDEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public DateTime DBDKMFAEAGJ;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x61E2F0", Offset = "0x61D2F0", VA = "0x18061E2F0")]
		public HHOAAFPELDO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class MAOCFFPOONA<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public global::AKLAFDGACEM<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public TKey key;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x61E2F0", Offset = "0x61D2F0", VA = "0x18061E2F0")]
		public MAOCFFPOONA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class FALNGHDNLFO<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public HHOAAFPELDO cacheEntry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public MAOCFFPOONA<TValue> CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x61E2F0", Offset = "0x61D2F0", VA = "0x18061E2F0")]
		public FALNGHDNLFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x298EF10", Offset = "0x298DF10", VA = "0x18298EF10")]
		internal void <SetPromise>b__0(string e)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private Dictionary<TKey, HHOAAFPELDO> ONOBMHNFCHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private LinkedList<HHOAAFPELDO> BEGNGFNEACK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private LinkedList<HHOAAFPELDO> MMLCKKIBDHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private int GFAPCNMLFBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private bool CFBMJKBIBOA;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public ICollection<TKey> MNHJJLIEMBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xAD4C50", Offset = "0xAD3C50", VA = "0x180AD4C50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x29898A0", Offset = "0x29888A0", VA = "0x1829898A0")]
	public AKLAFDGACEM([Optional] int? GFAPCNMLFBN, bool CFBMJKBIBOA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xAD4C20", Offset = "0xAD3C20", VA = "0x180AD4C20")]
	public bool HJDGIMJFFLI(TKey DNGKIAJLLHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2F8B070", Offset = "0x2F8A070", VA = "0x182F8B070")]
	public global::PMGCJEPKFOF<TValue> PFFCBOBBLPC<TValue>(TKey DNGKIAJLLHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2D1E000", Offset = "0x2D1D000", VA = "0x182D1E000")]
	public void CPDEMFAEBMA<TValue>(TKey DNGKIAJLLHG, TValue ONGBFDACHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2D1E0E0", Offset = "0x2D1D0E0", VA = "0x182D1E0E0")]
	public void CPDEMFAEBMA<TValue>(TKey DNGKIAJLLHG, TValue ONGBFDACHHG, TimeSpan PELFKCAHDFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2D1EB30", Offset = "0x2D1DB30", VA = "0x182D1EB30")]
	public void OJFDLGABFPJ<TValue>(TKey DNGKIAJLLHG, global::PMGCJEPKFOF<TValue> NKLGAGCHGPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2D1EBE0", Offset = "0x2D1DBE0", VA = "0x182D1EBE0")]
	public void OJFDLGABFPJ<TValue>(TKey DNGKIAJLLHG, global::PMGCJEPKFOF<TValue> NKLGAGCHGPM, TimeSpan PELFKCAHDFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2F8AAF0", Offset = "0x2F89AF0", VA = "0x182F8AAF0")]
	public global::PMGCJEPKFOF<TValue> EGKOPJHNGFN<TValue>(TKey DNGKIAJLLHG, Func<global::PMGCJEPKFOF<TValue>> LJDGKINKAKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2F8AA50", Offset = "0x2F89A50", VA = "0x182F8AA50")]
	public global::PMGCJEPKFOF<TValue> EGKOPJHNGFN<TValue>(TKey DNGKIAJLLHG, Func<global::PMGCJEPKFOF<TValue>> LJDGKINKAKL, TimeSpan PELFKCAHDFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x29879C0", Offset = "0x29869C0", VA = "0x1829879C0")]
	public bool BIHKNNPGGKP(TKey DNGKIAJLLHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2987F20", Offset = "0x2986F20", VA = "0x182987F20")]
	public int CEKJLHGHCDN(Predicate<TKey> PBPLOKIJLLN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2989300", Offset = "0x2988300", VA = "0x182989300")]
	public void LKLKGDMFMCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2988380", Offset = "0x2987380", VA = "0x182988380")]
	private void DEMFMBEDHDD(HHOAAFPELDO KNAIJICNDHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2988A10", Offset = "0x2987A10", VA = "0x182988A10")]
	private void IFEEDKKBJOB(HHOAAFPELDO KNAIJICNDHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2989390", Offset = "0x2988390", VA = "0x182989390")]
	private void OLDKGOHBFAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2988F70", Offset = "0x2987F70", VA = "0x182988F70")]
	private bool JFDDPNFPDBG(HHOAAFPELDO KNAIJICNDHB)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class FFAFDAOBAHN
{
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private static byte[] OHCLMBBDJLC;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static int NJPHPOMKGAO;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private static int NCHLFMFMLBC;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static BigInteger AEEDJIDCNEO;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3E5020", Offset = "0x3E4020", VA = "0x1803E5020")]
	public FFAFDAOBAHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1D75A30", Offset = "0x1D74A30", VA = "0x181D75A30")]
	private static string IHFKDHGIIEJ(byte[] FOJLJNMAJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1D75B30", Offset = "0x1D74B30", VA = "0x181D75B30")]
	public static string PAMIGJPGHHB(byte[] MGPDDEMABPB, bool KOILKPGDKMG)
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

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3E5020", Offset = "0x3E4020", VA = "0x1803E5020")]
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
