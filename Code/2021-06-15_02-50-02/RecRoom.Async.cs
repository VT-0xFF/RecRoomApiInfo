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
				[Cpp2IlInjected.Address(RVA = "0x3EDBD0", Offset = "0x3ECDD0", VA = "0x1803EDBD0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x3EDBD0", Offset = "0x3ECDD0", VA = "0x1803EDBD0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x438260", Offset = "0x437460", VA = "0x180438260")]
			[DebuggerHidden]
			public LLLKGHKAKAK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x3E5820", Offset = "0x3E4A20", VA = "0x1803E5820", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x3683AD0", Offset = "0x3682CD0", VA = "0x183683AD0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x3683C60", Offset = "0x3682E60", VA = "0x183683C60", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0x3EDBD0", Offset = "0x3ECDD0", VA = "0x1803EDBD0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x3EDBD0", Offset = "0x3ECDD0", VA = "0x1803EDBD0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x438260", Offset = "0x437460", VA = "0x180438260")]
			[DebuggerHidden]
			public LEFCHIGGAAJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x3E5820", Offset = "0x3E4A20", VA = "0x1803E5820", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x3683A30", Offset = "0x3682C30", VA = "0x183683A30", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x3683A80", Offset = "0x3682C80", VA = "0x183683A80", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x3FE480", Offset = "0x3FD680", VA = "0x1803FE480")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x425FC0", Offset = "0x4251C0", VA = "0x180425FC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x3683290", Offset = "0x3682490", VA = "0x183683290")]
		public static AsyncBatch Create(Transform HICENEOPGOF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x3683390", Offset = "0x3682590", VA = "0x183683390")]
		[IteratorStateMachine(typeof(LLLKGHKAKAK))]
		private IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3683060", Offset = "0x3682260", VA = "0x183683060")]
		public void Add(string MMBOKOLAJFH, DABKFAIHBBP NKLGAGCHGPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3683130", Offset = "0x3682330", VA = "0x183683130")]
		public void Add(string MMBOKOLAJFH, IEnumerator LOIIKGFHHAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3683320", Offset = "0x3682520", VA = "0x183683320")]
		[IteratorStateMachine(typeof(LEFCHIGGAAJ))]
		private IEnumerator OBEEEPKOOCO(JJEKJGALHKO NKLGAGCHGPM, IEnumerator LOIIKGFHHAA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x36833F0", Offset = "0x36825F0", VA = "0x1836833F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x152ABA0", Offset = "0x1529DA0", VA = "0x18152ABA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x152ABA0", Offset = "0x1529DA0", VA = "0x18152ABA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x152ABA0", Offset = "0x1529DA0", VA = "0x18152ABA0")]
		public FALNGHDNLFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x152D030", Offset = "0x152C230", VA = "0x18152D030")]
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
		[Cpp2IlInjected.Address(RVA = "0x1527F70", Offset = "0x1527170", VA = "0x181527F70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1528540", Offset = "0x1527740", VA = "0x181528540")]
	public AKLAFDGACEM([Optional] int? GFAPCNMLFBN, bool CFBMJKBIBOA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x15273A0", Offset = "0x15265A0", VA = "0x1815273A0")]
	public bool HJDGIMJFFLI(TKey DNGKIAJLLHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1BAC830", Offset = "0x1BABA30", VA = "0x181BAC830")]
	public global::PMGCJEPKFOF<TValue> PFFCBOBBLPC<TValue>(TKey DNGKIAJLLHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x18AF560", Offset = "0x18AE760", VA = "0x1818AF560")]
	public void CPDEMFAEBMA<TValue>(TKey DNGKIAJLLHG, TValue ONGBFDACHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x18AF640", Offset = "0x18AE840", VA = "0x1818AF640")]
	public void CPDEMFAEBMA<TValue>(TKey DNGKIAJLLHG, TValue ONGBFDACHHG, TimeSpan PELFKCAHDFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x18B0090", Offset = "0x18AF290", VA = "0x1818B0090")]
	public void OJFDLGABFPJ<TValue>(TKey DNGKIAJLLHG, global::PMGCJEPKFOF<TValue> NKLGAGCHGPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x18B0140", Offset = "0x18AF340", VA = "0x1818B0140")]
	public void OJFDLGABFPJ<TValue>(TKey DNGKIAJLLHG, global::PMGCJEPKFOF<TValue> NKLGAGCHGPM, TimeSpan PELFKCAHDFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x1BAC2B0", Offset = "0x1BAB4B0", VA = "0x181BAC2B0")]
	public global::PMGCJEPKFOF<TValue> EGKOPJHNGFN<TValue>(TKey DNGKIAJLLHG, Func<global::PMGCJEPKFOF<TValue>> LJDGKINKAKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x1BAC210", Offset = "0x1BAB410", VA = "0x181BAC210")]
	public global::PMGCJEPKFOF<TValue> EGKOPJHNGFN<TValue>(TKey DNGKIAJLLHG, Func<global::PMGCJEPKFOF<TValue>> LJDGKINKAKL, TimeSpan PELFKCAHDFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x1526600", Offset = "0x1525800", VA = "0x181526600")]
	public bool BIHKNNPGGKP(TKey DNGKIAJLLHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x1526B60", Offset = "0x1525D60", VA = "0x181526B60")]
	public int CEKJLHGHCDN(Predicate<TKey> PBPLOKIJLLN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1527FA0", Offset = "0x15271A0", VA = "0x181527FA0")]
	public void LKLKGDMFMCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1526FC0", Offset = "0x15261C0", VA = "0x181526FC0")]
	private void DEMFMBEDHDD(HHOAAFPELDO KNAIJICNDHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1527680", Offset = "0x1526880", VA = "0x181527680")]
	private void IFEEDKKBJOB(HHOAAFPELDO KNAIJICNDHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1528030", Offset = "0x1527230", VA = "0x181528030")]
	private void OLDKGOHBFAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1527BE0", Offset = "0x1526DE0", VA = "0x181527BE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3E6C80", Offset = "0x3E5E80", VA = "0x1803E6C80")]
	public FFAFDAOBAHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3683450", Offset = "0x3682650", VA = "0x183683450")]
	private static string IHFKDHGIIEJ(byte[] FOJLJNMAJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3683550", Offset = "0x3682750", VA = "0x183683550")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E6C80", Offset = "0x3E5E80", VA = "0x1803E6C80")]
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
