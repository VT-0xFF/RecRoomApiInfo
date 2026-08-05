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

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public IDisposable CLBECIFGPMJ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class LLLKGHKAKAK : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x3F97B0", Offset = "0x3F85B0", VA = "0x1803F97B0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x3F97B0", Offset = "0x3F85B0", VA = "0x1803F97B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x433040", Offset = "0x431E40", VA = "0x180433040")]
			[DebuggerHidden]
			public LLLKGHKAKAK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x4082D0", Offset = "0x4070D0", VA = "0x1804082D0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x1287890", Offset = "0x1286690", VA = "0x181287890", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x1287A60", Offset = "0x1286860", VA = "0x181287A60", Slot = "8")]
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
			public JJEKJGALHKO promise;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x3F97B0", Offset = "0x3F85B0", VA = "0x1803F97B0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x3F97B0", Offset = "0x3F85B0", VA = "0x1803F97B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x433040", Offset = "0x431E40", VA = "0x180433040")]
			[DebuggerHidden]
			public LEFCHIGGAAJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x4082D0", Offset = "0x4070D0", VA = "0x1804082D0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x12877F0", Offset = "0x12865F0", VA = "0x1812877F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x1287840", Offset = "0x1286640", VA = "0x181287840", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x5E5070", Offset = "0x5E3E70", VA = "0x1805E5070")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x5E5080", Offset = "0x5E3E80", VA = "0x1805E5080")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x1287050", Offset = "0x1285E50", VA = "0x181287050")]
		public static AsyncBatch Create(Transform HICENEOPGOF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1287150", Offset = "0x1285F50", VA = "0x181287150")]
		[IteratorStateMachine(typeof(LLLKGHKAKAK))]
		private IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1286DF0", Offset = "0x1285BF0", VA = "0x181286DF0")]
		public void Add(string MMBOKOLAJFH, DABKFAIHBBP NKLGAGCHGPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1286EE0", Offset = "0x1285CE0", VA = "0x181286EE0")]
		public void Add(string MMBOKOLAJFH, IEnumerator LOIIKGFHHAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x12870E0", Offset = "0x1285EE0", VA = "0x1812870E0")]
		[IteratorStateMachine(typeof(LEFCHIGGAAJ))]
		private IEnumerator OBEEEPKOOCO(JJEKJGALHKO NKLGAGCHGPM, IEnumerator LOIIKGFHHAA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x12871B0", Offset = "0x1285FB0", VA = "0x1812871B0")]
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
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TKey AKFDMGLACLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public DABKFAIHBBP BAINEAGHDEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public DateTime DBDKMFAEAGJ;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5240F0", Offset = "0x522EF0", VA = "0x1805240F0")]
		public HHOAAFPELDO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class MAOCFFPOONA<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public global::AKLAFDGACEM<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public TKey key;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5240F0", Offset = "0x522EF0", VA = "0x1805240F0")]
		public MAOCFFPOONA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class FALNGHDNLFO<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public HHOAAFPELDO cacheEntry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public MAOCFFPOONA<TValue> CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5240F0", Offset = "0x522EF0", VA = "0x1805240F0")]
		public FALNGHDNLFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1F297F0", Offset = "0x1F285F0", VA = "0x181F297F0")]
		internal void <SetPromise>b__0(string e)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<TKey, HHOAAFPELDO> ONOBMHNFCHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private LinkedList<HHOAAFPELDO> BEGNGFNEACK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private LinkedList<HHOAAFPELDO> MMLCKKIBDHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int GFAPCNMLFBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool CFBMJKBIBOA;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public ICollection<TKey> MNHJJLIEMBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1F24780", Offset = "0x1F23580", VA = "0x181F24780")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1F24D50", Offset = "0x1F23B50", VA = "0x181F24D50")]
	public AKLAFDGACEM([Optional] int? GFAPCNMLFBN, bool CFBMJKBIBOA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1F23BB0", Offset = "0x1F229B0", VA = "0x181F23BB0")]
	public bool HJDGIMJFFLI(TKey DNGKIAJLLHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2750250", Offset = "0x274F050", VA = "0x182750250")]
	public global::PMGCJEPKFOF<TValue> PFFCBOBBLPC<TValue>(TKey DNGKIAJLLHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x22D1EC0", Offset = "0x22D0CC0", VA = "0x1822D1EC0")]
	public void CPDEMFAEBMA<TValue>(TKey DNGKIAJLLHG, TValue ONGBFDACHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x22D1FA0", Offset = "0x22D0DA0", VA = "0x1822D1FA0")]
	public void CPDEMFAEBMA<TValue>(TKey DNGKIAJLLHG, TValue ONGBFDACHHG, TimeSpan PELFKCAHDFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x22D29F0", Offset = "0x22D17F0", VA = "0x1822D29F0")]
	public void OJFDLGABFPJ<TValue>(TKey DNGKIAJLLHG, global::PMGCJEPKFOF<TValue> NKLGAGCHGPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x22D2AA0", Offset = "0x22D18A0", VA = "0x1822D2AA0")]
	public void OJFDLGABFPJ<TValue>(TKey DNGKIAJLLHG, global::PMGCJEPKFOF<TValue> NKLGAGCHGPM, TimeSpan PELFKCAHDFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x274FCD0", Offset = "0x274EAD0", VA = "0x18274FCD0")]
	public global::PMGCJEPKFOF<TValue> EGKOPJHNGFN<TValue>(TKey DNGKIAJLLHG, Func<global::PMGCJEPKFOF<TValue>> LJDGKINKAKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x274FC30", Offset = "0x274EA30", VA = "0x18274FC30")]
	public global::PMGCJEPKFOF<TValue> EGKOPJHNGFN<TValue>(TKey DNGKIAJLLHG, Func<global::PMGCJEPKFOF<TValue>> LJDGKINKAKL, TimeSpan PELFKCAHDFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x1F22E10", Offset = "0x1F21C10", VA = "0x181F22E10")]
	public bool BIHKNNPGGKP(TKey DNGKIAJLLHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x1F23370", Offset = "0x1F22170", VA = "0x181F23370")]
	public int CEKJLHGHCDN(Predicate<TKey> PBPLOKIJLLN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1F247B0", Offset = "0x1F235B0", VA = "0x181F247B0")]
	public void LKLKGDMFMCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1F237D0", Offset = "0x1F225D0", VA = "0x181F237D0")]
	private void DEMFMBEDHDD(HHOAAFPELDO KNAIJICNDHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1F23E90", Offset = "0x1F22C90", VA = "0x181F23E90")]
	private void IFEEDKKBJOB(HHOAAFPELDO KNAIJICNDHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1F24840", Offset = "0x1F23640", VA = "0x181F24840")]
	private void OLDKGOHBFAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1F243F0", Offset = "0x1F231F0", VA = "0x181F243F0")]
	private bool JFDDPNFPDBG(HHOAAFPELDO KNAIJICNDHB)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class FFAFDAOBAHN
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static byte[] OHCLMBBDJLC;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private static int NJPHPOMKGAO;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static int NCHLFMFMLBC;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static BigInteger AEEDJIDCNEO;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3F6370", Offset = "0x3F5170", VA = "0x1803F6370")]
	public FFAFDAOBAHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1287210", Offset = "0x1286010", VA = "0x181287210")]
	private static string IHFKDHGIIEJ(byte[] FOJLJNMAJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1287310", Offset = "0x1286110", VA = "0x181287310")]
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

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3F6370", Offset = "0x3F5170", VA = "0x1803F6370")]
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
