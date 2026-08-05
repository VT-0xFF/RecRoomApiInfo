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
		private struct BMBGJFDGCMC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public string GCPJLMHALKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public BNIMEGFNNGI JMHICGAIOLM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public float? BIHNOBFOPDJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public float? KJJLHCNPCOH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public IDisposable OLCJHAAFGLF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class KDCLEEDJNMO : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x422E70", Offset = "0x421E70", VA = "0x180422E70", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x422E70", Offset = "0x421E70", VA = "0x180422E70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x446090", Offset = "0x445090", VA = "0x180446090")]
			[DebuggerHidden]
			public KDCLEEDJNMO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x41FB10", Offset = "0x41EB10", VA = "0x18041FB10", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x3D07D70", Offset = "0x3D06D70", VA = "0x183D07D70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x3D07F40", Offset = "0x3D06F40", VA = "0x183D07F40", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class DJHAGLLOCKL : IEnumerator<object>, IEnumerator, IDisposable
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
			public PNALDAGDAPL promise;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x422E70", Offset = "0x421E70", VA = "0x180422E70", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x422E70", Offset = "0x421E70", VA = "0x180422E70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x446090", Offset = "0x445090", VA = "0x180446090")]
			[DebuggerHidden]
			public DJHAGLLOCKL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x41FB10", Offset = "0x41EB10", VA = "0x18041FB10", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x3D07CD0", Offset = "0x3D06CD0", VA = "0x183D07CD0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x3D07D20", Offset = "0x3D06D20", VA = "0x183D07D20", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private List<BMBGJFDGCMC> COLPKGDCJDK;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool ABCGMPOGKJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x4462C0", Offset = "0x4452C0", VA = "0x1804462C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x5E51E0", Offset = "0x5E41E0", VA = "0x1805E51E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x3D07B80", Offset = "0x3D06B80", VA = "0x183D07B80")]
		public static AsyncBatch Create(Transform MLOCIIICABC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x3D07C10", Offset = "0x3D06C10", VA = "0x183D07C10")]
		[IteratorStateMachine(typeof(KDCLEEDJNMO))]
		private IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3D07A90", Offset = "0x3D06A90", VA = "0x183D07A90")]
		public void Add(string OGBKDPALJLL, BNIMEGFNNGI EPPKDKKODGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3D07920", Offset = "0x3D06920", VA = "0x183D07920")]
		public void Add(string OGBKDPALJLL, IEnumerator AHHPLMFMNKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3D078B0", Offset = "0x3D068B0", VA = "0x183D078B0")]
		[IteratorStateMachine(typeof(DJHAGLLOCKL))]
		private IEnumerator ALPJPMOMANC(PNALDAGDAPL EPPKDKKODGE, IEnumerator AHHPLMFMNKD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3D07C70", Offset = "0x3D06C70", VA = "0x183D07C70")]
		public AsyncBatch()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class GJBCAGJKDBK<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class HJJEFGGPFBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TKey NGAHLDIBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public BNIMEGFNNGI JMHICGAIOLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public DateTime JEOIDKIIAFL;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x10D8140", Offset = "0x10D7140", VA = "0x1810D8140")]
		public HJJEFGGPFBD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class IBOEDGLJDPN<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public global::GJBCAGJKDBK<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public TKey key;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x10D8140", Offset = "0x10D7140", VA = "0x1810D8140")]
		public IBOEDGLJDPN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class AOGAHGMLGIN<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public HJJEFGGPFBD cacheEntry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public IBOEDGLJDPN<TValue> CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x10D8140", Offset = "0x10D7140", VA = "0x1810D8140")]
		public AOGAHGMLGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x32A8CF0", Offset = "0x32A7CF0", VA = "0x1832A8CF0")]
		internal void <SetPromise>b__0(string e)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<TKey, HJJEFGGPFBD> IPLIKAEFICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private LinkedList<HJJEFGGPFBD> PIEIFJBJACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private LinkedList<HJJEFGGPFBD> DPHOJLPNNIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int PFLCODMDHMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool BMIMMGMFMCG;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public ICollection<TKey> NFEEBAEKBFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2E88610", Offset = "0x2E87610", VA = "0x182E88610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x32B19E0", Offset = "0x32B09E0", VA = "0x1832B19E0")]
	public GJBCAGJKDBK([Optional] int? PFLCODMDHMG, bool BMIMMGMFMCG = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1F29600", Offset = "0x1F28600", VA = "0x181F29600")]
	public bool DAPNJJDBBHE(TKey PFPLGCLHCBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x24A7B00", Offset = "0x24A6B00", VA = "0x1824A7B00")]
	public global::GBEKKLLKIMD<TValue> IBNICPPDKLD<TValue>(TKey PFPLGCLHCBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x28BC800", Offset = "0x28BB800", VA = "0x1828BC800")]
	public void NNIOLMMJEIP<TValue>(TKey PFPLGCLHCBM, TValue MNEBKBGCGHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x28BC8E0", Offset = "0x28BB8E0", VA = "0x1828BC8E0")]
	public void NNIOLMMJEIP<TValue>(TKey PFPLGCLHCBM, TValue MNEBKBGCGHD, TimeSpan JNPKGBIENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x28BC420", Offset = "0x28BB420", VA = "0x1828BC420")]
	public void NFACLHHCCLG<TValue>(TKey PFPLGCLHCBM, global::GBEKKLLKIMD<TValue> EPPKDKKODGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x28BBDC0", Offset = "0x28BADC0", VA = "0x1828BBDC0")]
	public void NFACLHHCCLG<TValue>(TKey PFPLGCLHCBM, global::GBEKKLLKIMD<TValue> EPPKDKKODGE, TimeSpan JNPKGBIENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x24A78B0", Offset = "0x24A68B0", VA = "0x1824A78B0")]
	public global::GBEKKLLKIMD<TValue> CGJJDBJMGNA<TValue>(TKey PFPLGCLHCBM, Func<global::GBEKKLLKIMD<TValue>> PLLAIEMPAFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x24A76C0", Offset = "0x24A66C0", VA = "0x1824A76C0")]
	public global::GBEKKLLKIMD<TValue> CGJJDBJMGNA<TValue>(TKey PFPLGCLHCBM, Func<global::GBEKKLLKIMD<TValue>> PLLAIEMPAFG, TimeSpan JNPKGBIENPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x32B1210", Offset = "0x32B0210", VA = "0x1832B1210")]
	public bool OLMCAFOCELO(TKey PFPLGCLHCBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x32B1770", Offset = "0x32B0770", VA = "0x1832B1770")]
	public int PPIGBOININK(Predicate<TKey> CBNNHPNAGOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x32AFE90", Offset = "0x32AEE90", VA = "0x1832AFE90")]
	public void FMCAHCCFHCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x32B0730", Offset = "0x32AF730", VA = "0x1832B0730")]
	private void ODGMPDEGCKI(HJJEFGGPFBD CLOMJODBLPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x32B01D0", Offset = "0x32AF1D0", VA = "0x1832B01D0")]
	private void MOGBGEBHAFA(HJJEFGGPFBD CLOMJODBLPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x32B1060", Offset = "0x32B0060", VA = "0x1832B1060")]
	private void OEPJOFBNCGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x32AFC30", Offset = "0x32AEC30", VA = "0x1832AFC30")]
	private bool FAJILMDHEAI(HJJEFGGPFBD CLOMJODBLPN)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class MPHOBGJJMAN
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static byte[] MDECFDIPDIM;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private static int KDCNKENIGEG;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static int ONHHOGLLEIJ;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static BigInteger FFNLGEIGHMD;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x41F000", Offset = "0x41E000", VA = "0x18041F000")]
	public MPHOBGJJMAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3D082C0", Offset = "0x3D072C0", VA = "0x183D082C0")]
	private static string MGHDHGHNMMA(byte[] FLPHBPIKJBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3D07F90", Offset = "0x3D06F90", VA = "0x183D07F90")]
	public static string EPCEKCOHIKG(byte[] FGABAFACHHN, bool IKFHCLDOPDI)
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
		[Cpp2IlInjected.Address(RVA = "0x41F000", Offset = "0x41E000", VA = "0x18041F000")]
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
