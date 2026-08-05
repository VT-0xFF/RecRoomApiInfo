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
				[Cpp2IlInjected.Address(RVA = "0x3EEBD0", Offset = "0x3ED9D0", VA = "0x1803EEBD0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x3EEBD0", Offset = "0x3ED9D0", VA = "0x1803EEBD0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x439260", Offset = "0x438060", VA = "0x180439260")]
			[DebuggerHidden]
			public LLLKGHKAKAK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x3E6820", Offset = "0x3E5620", VA = "0x1803E6820", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x36652E0", Offset = "0x36640E0", VA = "0x1836652E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x3665470", Offset = "0x3664270", VA = "0x183665470", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0x3EEBD0", Offset = "0x3ED9D0", VA = "0x1803EEBD0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x3EEBD0", Offset = "0x3ED9D0", VA = "0x1803EEBD0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x439260", Offset = "0x438060", VA = "0x180439260")]
			[DebuggerHidden]
			public LEFCHIGGAAJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x3E6820", Offset = "0x3E5620", VA = "0x1803E6820", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x3665240", Offset = "0x3664040", VA = "0x183665240", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x3665290", Offset = "0x3664090", VA = "0x183665290", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x3FF480", Offset = "0x3FE280", VA = "0x1803FF480")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x426FC0", Offset = "0x425DC0", VA = "0x180426FC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x3664AA0", Offset = "0x36638A0", VA = "0x183664AA0")]
		public static AsyncBatch Create(Transform HICENEOPGOF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x3664BA0", Offset = "0x36639A0", VA = "0x183664BA0")]
		[IteratorStateMachine(typeof(LLLKGHKAKAK))]
		private IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3664870", Offset = "0x3663670", VA = "0x183664870")]
		public void Add(string MMBOKOLAJFH, DABKFAIHBBP NKLGAGCHGPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3664940", Offset = "0x3663740", VA = "0x183664940")]
		public void Add(string MMBOKOLAJFH, IEnumerator LOIIKGFHHAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3664B30", Offset = "0x3663930", VA = "0x183664B30")]
		[IteratorStateMachine(typeof(LEFCHIGGAAJ))]
		private IEnumerator OBEEEPKOOCO(JJEKJGALHKO NKLGAGCHGPM, IEnumerator LOIIKGFHHAA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3664C00", Offset = "0x3663A00", VA = "0x183664C00")]
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
		[Cpp2IlInjected.Address(RVA = "0x144BFB0", Offset = "0x144ADB0", VA = "0x18144BFB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x144BFB0", Offset = "0x144ADB0", VA = "0x18144BFB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x144BFB0", Offset = "0x144ADB0", VA = "0x18144BFB0")]
		public FALNGHDNLFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x152D730", Offset = "0x152C530", VA = "0x18152D730")]
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
		[Cpp2IlInjected.Address(RVA = "0x15286C0", Offset = "0x15274C0", VA = "0x1815286C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1528C90", Offset = "0x1527A90", VA = "0x181528C90")]
	public AKLAFDGACEM([Optional] int? GFAPCNMLFBN, bool CFBMJKBIBOA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1527AF0", Offset = "0x15268F0", VA = "0x181527AF0")]
	public bool HJDGIMJFFLI(TKey DNGKIAJLLHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1DD83E0", Offset = "0x1DD71E0", VA = "0x181DD83E0")]
	public global::PMGCJEPKFOF<TValue> PFFCBOBBLPC<TValue>(TKey DNGKIAJLLHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1B02BE0", Offset = "0x1B019E0", VA = "0x181B02BE0")]
	public void CPDEMFAEBMA<TValue>(TKey DNGKIAJLLHG, TValue ONGBFDACHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1B02CC0", Offset = "0x1B01AC0", VA = "0x181B02CC0")]
	public void CPDEMFAEBMA<TValue>(TKey DNGKIAJLLHG, TValue ONGBFDACHHG, TimeSpan PELFKCAHDFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x1B03710", Offset = "0x1B02510", VA = "0x181B03710")]
	public void OJFDLGABFPJ<TValue>(TKey DNGKIAJLLHG, global::PMGCJEPKFOF<TValue> NKLGAGCHGPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1B037C0", Offset = "0x1B025C0", VA = "0x181B037C0")]
	public void OJFDLGABFPJ<TValue>(TKey DNGKIAJLLHG, global::PMGCJEPKFOF<TValue> NKLGAGCHGPM, TimeSpan PELFKCAHDFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x1DD7E60", Offset = "0x1DD6C60", VA = "0x181DD7E60")]
	public global::PMGCJEPKFOF<TValue> EGKOPJHNGFN<TValue>(TKey DNGKIAJLLHG, Func<global::PMGCJEPKFOF<TValue>> LJDGKINKAKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x1DD7DC0", Offset = "0x1DD6BC0", VA = "0x181DD7DC0")]
	public global::PMGCJEPKFOF<TValue> EGKOPJHNGFN<TValue>(TKey DNGKIAJLLHG, Func<global::PMGCJEPKFOF<TValue>> LJDGKINKAKL, TimeSpan PELFKCAHDFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x1526D50", Offset = "0x1525B50", VA = "0x181526D50")]
	public bool BIHKNNPGGKP(TKey DNGKIAJLLHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x15272B0", Offset = "0x15260B0", VA = "0x1815272B0")]
	public int CEKJLHGHCDN(Predicate<TKey> PBPLOKIJLLN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x15286F0", Offset = "0x15274F0", VA = "0x1815286F0")]
	public void LKLKGDMFMCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1527710", Offset = "0x1526510", VA = "0x181527710")]
	private void DEMFMBEDHDD(HHOAAFPELDO KNAIJICNDHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1527DD0", Offset = "0x1526BD0", VA = "0x181527DD0")]
	private void IFEEDKKBJOB(HHOAAFPELDO KNAIJICNDHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1528780", Offset = "0x1527580", VA = "0x181528780")]
	private void OLDKGOHBFAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1528330", Offset = "0x1527130", VA = "0x181528330")]
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
	[Cpp2IlInjected.Address(RVA = "0x3E7C80", Offset = "0x3E6A80", VA = "0x1803E7C80")]
	public FFAFDAOBAHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3664C60", Offset = "0x3663A60", VA = "0x183664C60")]
	private static string IHFKDHGIIEJ(byte[] FOJLJNMAJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3664D60", Offset = "0x3663B60", VA = "0x183664D60")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E7C80", Offset = "0x3E6A80", VA = "0x1803E7C80")]
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
