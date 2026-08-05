using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Google.Protobuf.Collections;
using Microsoft.CodeAnalysis;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8CB040", Offset = "0x8CA440", VA = "0x1808CB040")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x23B0DC0", Offset = "0x23B01C0", VA = "0x1823B0DC0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA6EF70", Offset = "0xA6E370", VA = "0x180A6EF70")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA6EFA0", Offset = "0xA6E3A0", VA = "0x180A6EFA0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct GEPGMKKIPBH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct LBOEDIGJKLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public NAHKHOEBAGF<GBFHMLMFMIH> MLJIHPKCDPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public NAHKHOEBAGF<GBFHMLMFMIH> DKBEEMJKJPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public NAHKHOEBAGF<GBFHMLMFMIH> PKAEKGDIILL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public NAHKHOEBAGF<GBFHMLMFMIH> OPBEFFHKOAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public NAHKHOEBAGF<GBFHMLMFMIH> BJMGLKOHGGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public NAHKHOEBAGF<GBFHMLMFMIH> MOOFJCKHKMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public NAHKHOEBAGF<GBFHMLMFMIH> KBHPACMEPNI;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x23AE3E0", Offset = "0x23AD7E0", VA = "0x1823AE3E0")]
		public static LBOEDIGJKLD NAILOIKCJEC(CPFDDGNHJPH<IHFMLBABICM> KIMAHGPPKMB)
		{
			return default(LBOEDIGJKLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface HOONOPJMFAG
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		KDJJPBEBPDE IBBHCGHKEGH
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class GOGCNCJDDJC
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class ICBHHIJLJHN : IEnumerable<LHHDIPPKMNM>, IEnumerable, IEnumerator<LHHDIPPKMNM>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private LHHDIPPKMNM <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private bool includeBeta;

			[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public bool <>3__includeBeta;

			[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private bool includeStudio;

			[Cpp2IlInjected.FieldOffset(Offset = "0x27")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public bool <>3__includeStudio;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private bool isDeveloper;

			[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public bool <>3__isDeveloper;

			[Cpp2IlInjected.Token(Token = "0x17000056")]
			private LHHDIPPKMNM System.Collections.Generic.IEnumerator<Circuits.Static.Core.TypeSystem.CircuitType>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000057")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000072")]
				[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x9C1680", Offset = "0x9C0A80", VA = "0x1809C1680")]
			[DebuggerHidden]
			public ICBHHIJLJHN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x70FB930", Offset = "0x70FAD30", VA = "0x1870FB930", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x70FE180", Offset = "0x70FD580", VA = "0x1870FE180", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x70FE0D0", Offset = "0x70FD4D0", VA = "0x1870FE0D0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<LHHDIPPKMNM> System.Collections.Generic.IEnumerable<Circuits.Static.Core.TypeSystem.CircuitType>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x70FE0D0", Offset = "0x70FD4D0", VA = "0x1870FE0D0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class MCDFDPDDKGD : IEnumerable<LHHDIPPKMNM>, IEnumerable, IEnumerator<LHHDIPPKMNM>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private LHHDIPPKMNM <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			private bool includeExec;

			[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public bool <>3__includeExec;

			[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private bool includeBeta;

			[Cpp2IlInjected.FieldOffset(Offset = "0x27")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public bool <>3__includeBeta;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private bool includeStudio;

			[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public bool <>3__includeStudio;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			private bool isDeveloper;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public bool <>3__isDeveloper;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private IEnumerator<LHHDIPPKMNM> <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private LHHDIPPKMNM <circuitType>5__2;

			[Cpp2IlInjected.Token(Token = "0x17000058")]
			private LHHDIPPKMNM System.Collections.Generic.IEnumerator<Circuits.Static.Core.TypeSystem.CircuitType>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000059")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x9C1680", Offset = "0x9C0A80", VA = "0x1809C1680")]
			[DebuggerHidden]
			public MCDFDPDDKGD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x7101FE0", Offset = "0x71013E0", VA = "0x187101FE0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x7101A20", Offset = "0x7100E20", VA = "0x187101A20", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x7101E30", Offset = "0x7101230", VA = "0x187101E30")]
			private void PPOPDODPNIH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x7101FA0", Offset = "0x71013A0", VA = "0x187101FA0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x7101EF0", Offset = "0x71012F0", VA = "0x187101EF0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<LHHDIPPKMNM> System.Collections.Generic.IEnumerable<Circuits.Static.Core.TypeSystem.CircuitType>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x7101EF0", Offset = "0x71012F0", VA = "0x187101EF0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public static readonly LBBKKHBEGMA KMDFJDLFJKC;

		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public static readonly LBBKKHBEGMA BNLIDBLCFKG;

		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private static readonly HashSet<LHHDIPPKMNM> BEIADMODLJL;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public static List<LHHDIPPKMNM> HHODFHDFJMI;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static MJAKODMEDME CHMOKAHMNPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x98AE40", Offset = "0x98A240", VA = "0x18098AE40")]
			get
			{
				return default(MJAKODMEDME);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static LHHDIPPKMNM MFMJBAJAHHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x239EAD0", Offset = "0x239DED0", VA = "0x18239EAD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static LHHDIPPKMNM ICFELDMPEGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x239E370", Offset = "0x239D770", VA = "0x18239E370")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static LHHDIPPKMNM GMCEKKDPHGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x239DA50", Offset = "0x239CE50", VA = "0x18239DA50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static LHHDIPPKMNM JLMHFKHBFKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x239CA80", Offset = "0x239BE80", VA = "0x18239CA80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static LHHDIPPKMNM OLCJKMCHJAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x239EC90", Offset = "0x239E090", VA = "0x18239EC90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static LHHDIPPKMNM JCIMICFOMCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x239E530", Offset = "0x239D930", VA = "0x18239E530")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static LHHDIPPKMNM BHMHKAMEICL
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x239DE80", Offset = "0x239D280", VA = "0x18239DE80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static LHHDIPPKMNM DCNBJDAGNAC
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x239EE50", Offset = "0x239E250", VA = "0x18239EE50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static LODKAOOFADA NJPPAHKPHDO
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x239E7B0", Offset = "0x239DBB0", VA = "0x18239E7B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static LODKAOOFADA MKICCGMGECB
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x239CDA0", Offset = "0x239C1A0", VA = "0x18239CDA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static LODKAOOFADA DNLLOPJGJNN
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x239CD40", Offset = "0x239C140", VA = "0x18239CD40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static LODKAOOFADA MNGDBLIAMLJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x239DF80", Offset = "0x239D380", VA = "0x18239DF80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static LODKAOOFADA FNIJAEMPEOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x239E280", Offset = "0x239D680", VA = "0x18239E280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static LODKAOOFADA DFBPCALLHEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x239D140", Offset = "0x239C540", VA = "0x18239D140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static LODKAOOFADA PHADCMCKEKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x239E040", Offset = "0x239D440", VA = "0x18239E040")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static LODKAOOFADA ANEJGPECAML
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x239E310", Offset = "0x239D710", VA = "0x18239E310")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static LODKAOOFADA PBHDGOCAEIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x239D200", Offset = "0x239C600", VA = "0x18239D200")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static LODKAOOFADA KIICJNJCLOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x239E990", Offset = "0x239DD90", VA = "0x18239E990")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static LODKAOOFADA FCPIJPDFGMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x239D0E0", Offset = "0x239C4E0", VA = "0x18239D0E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static LODKAOOFADA HCLHNPHDFNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x239E0A0", Offset = "0x239D4A0", VA = "0x18239E0A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static LODKAOOFADA CAJJMMEPGOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x239D320", Offset = "0x239C720", VA = "0x18239D320")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static LODKAOOFADA OKMECIKHCNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x239D1A0", Offset = "0x239C5A0", VA = "0x18239D1A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static LODKAOOFADA BMCOJODNMLD
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x239E410", Offset = "0x239D810", VA = "0x18239E410")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static LODKAOOFADA GMKJBJDJFHK
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x239E4D0", Offset = "0x239D8D0", VA = "0x18239E4D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static LODKAOOFADA GIKHJJLACDK
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x239CEC0", Offset = "0x239C2C0", VA = "0x18239CEC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static LODKAOOFADA CFGMJMMPJLE
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x239E690", Offset = "0x239DA90", VA = "0x18239E690")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static LODKAOOFADA ELHIDIGALHO
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x239D750", Offset = "0x239CB50", VA = "0x18239D750")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public static LODKAOOFADA OPDLPOOPDPN
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x239C930", Offset = "0x239BD30", VA = "0x18239C930")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public static LODKAOOFADA OCDJDGGAHAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x239E5D0", Offset = "0x239D9D0", VA = "0x18239E5D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public static LODKAOOFADA JJILOGLEMNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x239DCD0", Offset = "0x239D0D0", VA = "0x18239DCD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public static LODKAOOFADA CJEOLNABDDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x239E810", Offset = "0x239DC10", VA = "0x18239E810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public static LODKAOOFADA PBEGDLJMFDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x239E930", Offset = "0x239DD30", VA = "0x18239E930")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public static LODKAOOFADA PPDANHEOEII
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x239D630", Offset = "0x239CA30", VA = "0x18239D630")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public static LODKAOOFADA NMLMBGENCHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x239ED30", Offset = "0x239E130", VA = "0x18239ED30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public static LODKAOOFADA NCKNMCNFHNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x239E160", Offset = "0x239D560", VA = "0x18239E160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public static LODKAOOFADA OAJKLKAPNBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x239E8D0", Offset = "0x239DCD0", VA = "0x18239E8D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public static LODKAOOFADA JKDGLLCJKAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x239D2C0", Offset = "0x239C6C0", VA = "0x18239D2C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public static LODKAOOFADA NCHAMGCCLHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x239DFE0", Offset = "0x239D3E0", VA = "0x18239DFE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public static LODKAOOFADA NIKKILMNONO
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x239EDF0", Offset = "0x239E1F0", VA = "0x18239EDF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public static LODKAOOFADA EADKHFNKDFM
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x239DC10", Offset = "0x239D010", VA = "0x18239DC10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public static LODKAOOFADA DPGGKHGHDML
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x239D080", Offset = "0x239C480", VA = "0x18239D080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public static LODKAOOFADA BGMELGOIPPE
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x239DBB0", Offset = "0x239CFB0", VA = "0x18239DBB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public static LODKAOOFADA JOAGOHGKPKC
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x239DC70", Offset = "0x239D070", VA = "0x18239DC70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public static LODKAOOFADA ICMNJKEGPJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x239C870", Offset = "0x239BC70", VA = "0x18239C870")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public static LODKAOOFADA NIDGFKKFLPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x239E220", Offset = "0x239D620", VA = "0x18239E220")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public static LODKAOOFADA FCAKLAGEGLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x239DD90", Offset = "0x239D190", VA = "0x18239DD90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public static LODKAOOFADA PKGLBDFJKON
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x239D690", Offset = "0x239CA90", VA = "0x18239D690")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public static LODKAOOFADA IHPMPPKKKIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x239ED90", Offset = "0x239E190", VA = "0x18239ED90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public static LODKAOOFADA HONDMJAGFCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x239CFC0", Offset = "0x239C3C0", VA = "0x18239CFC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public static LODKAOOFADA CNHOAPPOFIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x239DF20", Offset = "0x239D320", VA = "0x18239DF20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public static LODKAOOFADA AAPHOGMCCNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x239C7B0", Offset = "0x239BBB0", VA = "0x18239C7B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public static LODKAOOFADA CKECMHEJKNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x239EF50", Offset = "0x239E350", VA = "0x18239EF50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public static LODKAOOFADA LOPDGAMAFGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x239C810", Offset = "0x239BC10", VA = "0x18239C810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public static LODKAOOFADA CGEDLNNAEMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x239D4D0", Offset = "0x239C8D0", VA = "0x18239D4D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public static LODKAOOFADA CLHOOCJHLNN
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x239D840", Offset = "0x239CC40", VA = "0x18239D840")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public static LODKAOOFADA NBEJEBFOOCC
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x239E630", Offset = "0x239DA30", VA = "0x18239E630")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public static LODKAOOFADA BJKPEFAJLMC
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x239EB70", Offset = "0x239DF70", VA = "0x18239EB70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public static LODKAOOFADA OOLOHPLGGDM
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x239CB20", Offset = "0x239BF20", VA = "0x18239CB20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public static LODKAOOFADA GBLCPPBAGMM
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x239D6F0", Offset = "0x239CAF0", VA = "0x18239D6F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public static LODKAOOFADA FNKMKCAOOJC
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x239E750", Offset = "0x239DB50", VA = "0x18239E750")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public static LODKAOOFADA PIPEIGOHOMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x239C8D0", Offset = "0x239BCD0", VA = "0x18239C8D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public static LODKAOOFADA PIBIDONMNLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x239D020", Offset = "0x239C420", VA = "0x18239D020")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public static LODKAOOFADA ENHLPKPEJBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x239DD30", Offset = "0x239D130", VA = "0x18239DD30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public static LODKAOOFADA NKEIBHBHGHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x239CB80", Offset = "0x239BF80", VA = "0x18239CB80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public static LODKAOOFADA BKBNNNBIBFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x239E100", Offset = "0x239D500", VA = "0x18239E100")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public static LODKAOOFADA ECMEEBLBAAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x239EC30", Offset = "0x239E030", VA = "0x18239EC30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public static LODKAOOFADA CCNCHNOHKGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x239CE00", Offset = "0x239C200", VA = "0x18239CE00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public static LODKAOOFADA DAIKBCIGIOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x239DAF0", Offset = "0x239CEF0", VA = "0x18239DAF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public static LODKAOOFADA CNFENDMMNMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x239EBD0", Offset = "0x239DFD0", VA = "0x18239EBD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public static LODKAOOFADA AMIEHPOCMGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x239E6F0", Offset = "0x239DAF0", VA = "0x18239E6F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public static LODKAOOFADA BPNLGHLAIGD
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x239EEF0", Offset = "0x239E2F0", VA = "0x18239EEF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public static LODKAOOFADA MCJDDIJMPCI
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x239E470", Offset = "0x239D870", VA = "0x18239E470")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public static LODKAOOFADA CFILFGMNFIG
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x239F010", Offset = "0x239E410", VA = "0x18239F010")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public static LODKAOOFADA AIDLFMAMAOM
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x239DDF0", Offset = "0x239D1F0", VA = "0x18239DDF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public static LODKAOOFADA BCFDJCNLJOE
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x239E870", Offset = "0x239DC70", VA = "0x18239E870")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public static LODKAOOFADA AGIABHCAAIC
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x239DB50", Offset = "0x239CF50", VA = "0x18239DB50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public static LODKAOOFADA CIPBGODONMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x239D9F0", Offset = "0x239CDF0", VA = "0x18239D9F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public static LODKAOOFADA HFNMFPKJFDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x239F070", Offset = "0x239E470", VA = "0x18239F070")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public static LODKAOOFADA PPEFIBNFLLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x239EFB0", Offset = "0x239E3B0", VA = "0x18239EFB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public static LODKAOOFADA DGBLCEHBENP
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x239E1C0", Offset = "0x239D5C0", VA = "0x18239E1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public static LODKAOOFADA GMNCAHBDCDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x239CE60", Offset = "0x239C260", VA = "0x18239CE60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public static LODKAOOFADA OIPDEFPNPAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x239D260", Offset = "0x239C660", VA = "0x18239D260")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public static LODKAOOFADA JIGCFDEHBKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x239C990", Offset = "0x239BD90", VA = "0x18239C990")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x239D530", Offset = "0x239C930", VA = "0x18239D530")]
		public static LBBKKHBEGMA FCCOLNKONDJ(in EOCDCMJMJCP KAPCHHNKPJD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x239EA20", Offset = "0x239DE20", VA = "0x18239EA20")]
		public static CAKHKLCGPPB MHBBNEIAPOI(string JNHCLKAAKHA, [Optional] string GDKOBCHHFLB)
		{
			return default(CAKHKLCGPPB);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x239E9F0", Offset = "0x239DDF0", VA = "0x18239E9F0")]
		public static CAKHKLCGPPB MHBBNEIAPOI([Optional] in Guid? JNHCLKAAKHA, [Optional] string GDKOBCHHFLB)
		{
			return default(CAKHKLCGPPB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x239DE50", Offset = "0x239D250", VA = "0x18239DE50")]
		public static LBBKKHBEGMA HODEJLPDICO(params EOCDCMJMJCP[] BNBKGNJLLBK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x239E2E0", Offset = "0x239D6E0", VA = "0x18239E2E0")]
		public static LBBKKHBEGMA JPDNIHLJNGJ(params EOCDCMJMJCP[] BNBKGNJLLBK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x239D380", Offset = "0x239C780", VA = "0x18239D380")]
		public static LBBKKHBEGMA EPEPEGFBHAG(in EOCDCMJMJCP KAPCHHNKPJD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x239F0D0", Offset = "0x239E4D0", VA = "0x18239F0D0")]
		static GOGCNCJDDJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x239D7B0", Offset = "0x239CBB0", VA = "0x18239D7B0")]
		[IteratorStateMachine(typeof(ICBHHIJLJHN))]
		private static IEnumerable<LHHDIPPKMNM> FKPAGNNBLDD(bool ODJADCDJKEO, bool PDCKOCGNILL, bool JCKNPGDIJBG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x239CF20", Offset = "0x239C320", VA = "0x18239CF20")]
		[IteratorStateMachine(typeof(MCDFDPDDKGD))]
		public static IEnumerable<LHHDIPPKMNM> DBJHDBGBIIL(bool ELGBNFPGHEO, bool ODJADCDJKEO, bool PDCKOCGNILL, bool JCKNPGDIJBG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x239CBE0", Offset = "0x239BFE0", VA = "0x18239CBE0")]
		public static GDPKPBAOOCF CCAMACADPGI(LHHDIPPKMNM GANFKPHKNKH)
		{
			return default(GDPKPBAOOCF);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x239D8A0", Offset = "0x239CCA0", VA = "0x18239D8A0")]
		public static GDPKPBAOOCF FNGHJJJDFOK(LHHDIPPKMNM GANFKPHKNKH)
		{
			return default(GDPKPBAOOCF);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x239C9F0", Offset = "0x239BDF0", VA = "0x18239C9F0")]
		public static bool BIIFFLJDNOK(LHHDIPPKMNM GANFKPHKNKH)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct IPAKIPPGHAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public NAHKHOEBAGF<INPCDOMJKDJ> AJNPEAOMNKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public NAHKHOEBAGF<INPCDOMJKDJ> GPONIBFFMEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public NAHKHOEBAGF<INPCDOMJKDJ> PGPJBBDBCNK;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x23AC560", Offset = "0x23AB960", VA = "0x1823AC560")]
		public static IPAKIPPGHAD NAILOIKCJEC(GKAMKCKNDEH KIMAHGPPKMB, KDJJPBEBPDE AEPKLFBJEML)
		{
			return default(IPAKIPPGHAD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public readonly struct KNNIJKPKCPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private readonly MJEKODPBOFK KFALEGLEGLG;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8BE820", Offset = "0x8BDC20", VA = "0x1808BE820")]
		public KNNIJKPKCPE(MJEKODPBOFK NNJMHKLGMCM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class ILNAPGHCIDK
	{
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private static Dictionary<NAHKHOEBAGF<AMCLCAHIAIB>, ODNFECNHFOH> MECIHADFFBI;

		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public static readonly NAHKHOEBAGF<AMCLCAHIAIB> ENEHFIHPPLN;

		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly NAHKHOEBAGF<AMCLCAHIAIB> JPDAFPBHEIJ;

		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public static readonly NAHKHOEBAGF<AMCLCAHIAIB> POAJPODPAHJ;

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public static readonly NAHKHOEBAGF<AMCLCAHIAIB> MFPPCOCIAKK;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public static readonly NAHKHOEBAGF<AMCLCAHIAIB> BKAENDNJCIC;

		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public static readonly NAHKHOEBAGF<AMCLCAHIAIB> LFNGODMANDP;

		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly NAHKHOEBAGF<AMCLCAHIAIB> LBICHGGCHEC;

		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public static readonly NAHKHOEBAGF<AMCLCAHIAIB> FGPPGILLBIM;

		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public static readonly NAHKHOEBAGF<AMCLCAHIAIB> HFOMOGJAALO;

		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public static readonly NAHKHOEBAGF<AMCLCAHIAIB> JOBOGBCAGKI;

		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public static readonly NAHKHOEBAGF<AMCLCAHIAIB> OAEEMILKBBP;

		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public static readonly NAHKHOEBAGF<AMCLCAHIAIB> LLJPNBCJGHH;

		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public static readonly NAHKHOEBAGF<AMCLCAHIAIB> PDLJKIHKPIN;

		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public static readonly NAHKHOEBAGF<AMCLCAHIAIB> IKLELPGLKNO;

		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public static readonly NAHKHOEBAGF<AMCLCAHIAIB> MMPCECOIOAO;

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public static readonly NAHKHOEBAGF<AMCLCAHIAIB> CPAJKAIGIAH;

		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly NAHKHOEBAGF<AMCLCAHIAIB> PFDJNBNFGMD;

		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public static readonly NAHKHOEBAGF<AMCLCAHIAIB> FJOMKKHKLLL;

		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public static readonly NAHKHOEBAGF<AMCLCAHIAIB> OIMKANGPFHI;

		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public static readonly NAHKHOEBAGF<AMCLCAHIAIB> KJLKNKGKMKF;

		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public static readonly NAHKHOEBAGF<AMCLCAHIAIB> PONNPOJLCIC;

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly NAHKHOEBAGF<AMCLCAHIAIB> MHFMEBJALIO;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public static readonly NAHKHOEBAGF<AMCLCAHIAIB> OPCDKDEPOIG;

		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public static readonly NAHKHOEBAGF<AMCLCAHIAIB> MGEOPKAJJDI;

		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public static readonly NAHKHOEBAGF<AMCLCAHIAIB> GEKLAJAKJME;

		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public static readonly NAHKHOEBAGF<AMCLCAHIAIB> BAJAIBCOHIN;

		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public static readonly NAHKHOEBAGF<AMCLCAHIAIB> PCPDLHDFMED;

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public static readonly NAHKHOEBAGF<AMCLCAHIAIB> GFGBBJGJLFP;

		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public static readonly NAHKHOEBAGF<AMCLCAHIAIB> LBHOHFOADEM;

		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public static readonly NAHKHOEBAGF<AMCLCAHIAIB> FHMIOLCJOBA;

		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public static readonly NAHKHOEBAGF<AMCLCAHIAIB> CJILKIJEJII;

		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public static readonly NAHKHOEBAGF<AMCLCAHIAIB> JIJANJOHCOP;

		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public static readonly NAHKHOEBAGF<AMCLCAHIAIB> JCJBLJJAGEJ;

		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly NAHKHOEBAGF<AMCLCAHIAIB> MLCEHEKEMKI;

		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public static readonly NAHKHOEBAGF<AMCLCAHIAIB> FEEOLJHGACD;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public static readonly NAHKHOEBAGF<AMCLCAHIAIB> BIELNPLFNJO;

		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public static readonly NAHKHOEBAGF<AMCLCAHIAIB> KGAMFINJBMD;

		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly NAHKHOEBAGF<AMCLCAHIAIB> BLNDJINCBKB;

		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public static readonly NAHKHOEBAGF<AMCLCAHIAIB> IJCNDLICKDF;

		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public static readonly NAHKHOEBAGF<AMCLCAHIAIB> OEHECDJECAB;

		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public static readonly NAHKHOEBAGF<AMCLCAHIAIB> PFLFOFIHPDF;

		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public static readonly NAHKHOEBAGF<AMCLCAHIAIB> JLLJNEAFCDI;

		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public static readonly NAHKHOEBAGF<AMCLCAHIAIB> KCBIBDNAHGM;

		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public static readonly NAHKHOEBAGF<AMCLCAHIAIB> PDFJAOMAHMD;

		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public static readonly NAHKHOEBAGF<AMCLCAHIAIB> DOKFENEPKHI;

		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly NAHKHOEBAGF<AMCLCAHIAIB> EDDBMECHLGD;

		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public static readonly NAHKHOEBAGF<AMCLCAHIAIB> HAIOOFMBDNE;

		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public static readonly NAHKHOEBAGF<AMCLCAHIAIB> GOHEDFONKCC;

		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public static readonly NAHKHOEBAGF<AMCLCAHIAIB> HGCKIPMCMPL;

		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public static readonly NAHKHOEBAGF<AMCLCAHIAIB> HBIJPBOHPHO;

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x23AAE70", Offset = "0x23AA270", VA = "0x1823AAE70")]
		public static ODNFECNHFOH IOCLKNMINHI(NAHKHOEBAGF<AMCLCAHIAIB> JNHCLKAAKHA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x23AAC70", Offset = "0x23AA070", VA = "0x1823AAC70")]
		public static bool DFEFAGJOMHD(NAHKHOEBAGF<AMCLCAHIAIB> JNHCLKAAKHA, out ODNFECNHFOH HKCMOHPPBIL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x23AADA0", Offset = "0x23AA1A0", VA = "0x1823AADA0")]
		public static LHHDIPPKMNM GKAHAAAFMIP(NAHKHOEBAGF<AMCLCAHIAIB> JNHCLKAAKHA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x23AAD00", Offset = "0x23AA100", VA = "0x1823AAD00")]
		private static NAHKHOEBAGF<AMCLCAHIAIB> EHBDNPLCIKI(ODNFECNHFOH HKCMOHPPBIL, NAHKHOEBAGF<AMCLCAHIAIB> JNHCLKAAKHA)
		{
			return default(NAHKHOEBAGF<AMCLCAHIAIB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct HMCIGAHOIAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public NAHKHOEBAGF<ABFPENOIEDD> HOMOHEINDMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public NAHKHOEBAGF<ABFPENOIEDD> BIMPOANKMOL;

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x23A6A60", Offset = "0x23A5E60", VA = "0x1823A6A60")]
		public static HMCIGAHOIAN NAILOIKCJEC(PJKBFBBLHJB<IHFMLBABICM> KIMAHGPPKMB)
		{
			return default(HMCIGAHOIAN);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly LBOEDIGJKLD EOKKNHHNIFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly HMCIGAHOIAN EAFKPBCAIJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly IPAKIPPGHAD MAGKDFFIACE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly GLALEDCCPMM<GBFHMLMFMIH, BBMOELINLDO<IHFMLBABICM>> DOCGCJGNLBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly GLALEDCCPMM<ABFPENOIEDD, OBMHGGFANCO<IHFMLBABICM>> BOBFLCIAMAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly GLALEDCCPMM<INPCDOMJKDJ, GJKIOLGPCAN> DBLGKKKEHLC;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x239BFA0", Offset = "0x239B3A0", VA = "0x18239BFA0")]
	private GEPGMKKIPBH(in LBOEDIGJKLD BLIFBKIBLCN, in HMCIGAHOIAN FJDHLJMPIBF, in IPAKIPPGHAD HJBFJBOPIOB, GLALEDCCPMM<GBFHMLMFMIH, BBMOELINLDO<IHFMLBABICM>> PKOPJGOECOJ, GLALEDCCPMM<ABFPENOIEDD, OBMHGGFANCO<IHFMLBABICM>> KNCIHLBNNMF, GLALEDCCPMM<INPCDOMJKDJ, GJKIOLGPCAN> BHINCEFGCCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x239BB40", Offset = "0x239AF40", VA = "0x18239BB40")]
	public static GEPGMKKIPBH NAILOIKCJEC(HOONOPJMFAG AEPKLFBJEML)
	{
		return default(GEPGMKKIPBH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x239B550", Offset = "0x239A950", VA = "0x18239B550")]
	public static void EHKLIGBABLK(in GEPGMKKIPBH ODBHDBFBMOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x239B540", Offset = "0x239A940", VA = "0x18239B540", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x239B910", Offset = "0x239AD10", VA = "0x18239B910")]
	public static KDPNPBPJFKA<IHFMLBABICM> JFMOEHJACLE(in GEPGMKKIPBH ODBHDBFBMOB, in ODLOHOMNPED LNNPKMHGNEH, in HALCKEOJHIJ KAHJPAHAMHJ)
	{
		return default(KDPNPBPJFKA<IHFMLBABICM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x239B9F0", Offset = "0x239ADF0", VA = "0x18239B9F0")]
	public static IHFMLBABICM LBKIABBLFOG(in GEPGMKKIPBH ODBHDBFBMOB, in ODAJLMHCBBN OHPKIKDEDKH, in KDPNPBPJFKA<IHFMLBABICM> HIIAJDHICEM, in EEOGEOBJECA PKJEDILLMFM, NAHKHOEBAGF<NMNEKCGKICM> EGNNAEKCBLO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class HHMBKEIDGMC
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x23A5730", Offset = "0x23A4B30", VA = "0x1823A5730")]
	public static bool JFBBNDDJMGL(this LHHDIPPKMNM GANFKPHKNKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x23A5650", Offset = "0x23A4A50", VA = "0x1823A5650")]
	public static bool JFBBNDDJMGL(this LBBKKHBEGMA NPABLLLAIJL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class NFIBFEHBBMK
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x24027D0", Offset = "0x2401BD0", VA = "0x1824027D0")]
	public static MBLBMPEFCJM<NBKNELADKPJ, BADMIJBBENP, TRoot, GFLCBAAKLHD.AECNIKIALHF<NBKNELADKPJ, BADMIJBBENP, TRoot>> IDKPLFLJOFD<TRoot>(this in MBLBMPEFCJM<NBKNELADKPJ, BADMIJBBENP, TRoot, GFLCBAAKLHD.AECNIKIALHF<NBKNELADKPJ, BADMIJBBENP, TRoot>> MJFMBBJPOHL) where TRoot : HIEIBOMFGIG
	{
		return default(MBLBMPEFCJM<NBKNELADKPJ, BADMIJBBENP, TRoot, GFLCBAAKLHD.AECNIKIALHF<NBKNELADKPJ, BADMIJBBENP, TRoot>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface HIEIBOMFGIG
{
	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	JKHEECIMHKB? JFKNELILGPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal static class DOBMOBLGCHN
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2398470", Offset = "0x2397870", VA = "0x182398470")]
	internal static IHFMLBABICM JFKNELILGPP(this HIEIBOMFGIG ODBHDBFBMOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2398550", Offset = "0x2397950", VA = "0x182398550")]
	internal static ADOGIEMPLPD<IHFMLBABICM, OOMENIGDKFB> MNFOGJEJOLJ(this HIEIBOMFGIG ODBHDBFBMOB)
	{
		return default(ADOGIEMPLPD<IHFMLBABICM, OOMENIGDKFB>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public readonly struct JKHEECIMHKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	internal readonly IHFMLBABICM JFKNELILGPP;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x8BE820", Offset = "0x8BDC20", VA = "0x1808BE820")]
	public JKHEECIMHKB(IHFMLBABICM IDKMMAFIJLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class IHFMLBABICM : ADHCGFGAPPB, IMEMCMOHKOB<IHFMLBABICM>, PLPPDEMFAMK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly GEPGMKKIPBH PODKHPCCKLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private ODAJLMHCBBN HNKIOLGGJPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private KDPNPBPJFKA<IHFMLBABICM> FPHMLCOOAAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private EEOGEOBJECA OALDLEBJHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly NAHKHOEBAGF<NMNEKCGKICM> JANENACMNOF;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x23AA290", Offset = "0x23A9690", VA = "0x1823AA290")]
	private IHFMLBABICM(in GEPGMKKIPBH DFLHLPHDCDC, in ODAJLMHCBBN OPPNCILHIGB, in KDPNPBPJFKA<IHFMLBABICM> HIIAJDHICEM, in EEOGEOBJECA PKJEDILLMFM, NAHKHOEBAGF<NMNEKCGKICM> MJDMCIMOJNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x239B9F0", Offset = "0x239ADF0", VA = "0x18239B9F0")]
	public static IHFMLBABICM JHJNCDAFJPH(in GEPGMKKIPBH DFLHLPHDCDC, in ODAJLMHCBBN OPPNCILHIGB, in KDPNPBPJFKA<IHFMLBABICM> HIIAJDHICEM, in EEOGEOBJECA PKJEDILLMFM, NAHKHOEBAGF<NMNEKCGKICM> MJDMCIMOJNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x23A83D0", Offset = "0x23A77D0", VA = "0x1823A83D0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x23A9D30", Offset = "0x23A9130", VA = "0x1823A9D30", Slot = "8")]
	public KDPNPBPJFKA<IHFMLBABICM> NEBAEEAEDFB()
	{
		return default(KDPNPBPJFKA<IHFMLBABICM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x23A71E0", Offset = "0x23A65E0", VA = "0x1823A71E0")]
	public ODAJLMHCBBN PELBDICGDBB()
	{
		return default(ODAJLMHCBBN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x22814D0", Offset = "0x22808D0", VA = "0x1822814D0")]
	public NAHKHOEBAGF<TMVirt> GJKMKBLODNG<TMVirt>(NAHKHOEBAGF<NMNEKCGKICM> AANELEBBHAJ) where TMVirt : KLOPAHBBBHP.LJJJHFHEEAF
	{
		return default(NAHKHOEBAGF<TMVirt>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x22816D0", Offset = "0x2280AD0", VA = "0x1822816D0")]
	public NAHKHOEBAGF<TMVirt> IKBNFIALOKP<TMVirt>(NAHKHOEBAGF<NMNEKCGKICM> AANELEBBHAJ, NAHKHOEBAGF<NCMNDELHLHG> MNLPDHHHFIF) where TMVirt : HGECIKEBNJG.PHONDPFLBFO
	{
		return default(NAHKHOEBAGF<TMVirt>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x23A9870", Offset = "0x23A8C70", VA = "0x1823A9870")]
	internal ODLOHOMNPED HDCDBCJFKJL()
	{
		return default(ODLOHOMNPED);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x23A71A0", Offset = "0x23A65A0", VA = "0x1823A71A0")]
	internal HALCKEOJHIJ BOJDDEOEAKE()
	{
		return default(HALCKEOJHIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x23A9D30", Offset = "0x23A9130", VA = "0x1823A9D30")]
	internal KDPNPBPJFKA<IHFMLBABICM> JHDDKFMPOPC()
	{
		return default(KDPNPBPJFKA<IHFMLBABICM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x23A71E0", Offset = "0x23A65E0", VA = "0x1823A71E0")]
	internal ODAJLMHCBBN CEOIAAFMIJL()
	{
		return default(ODAJLMHCBBN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x23A9C70", Offset = "0x23A9070", VA = "0x1823A9C70")]
	internal EEOGEOBJECA IEFFDJMJMBK()
	{
		return default(EEOGEOBJECA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2281470", Offset = "0x2280870", VA = "0x182281470")]
	public void ELFBLANEAEI<TMVirt>(NAHKHOEBAGF<NMNEKCGKICM> AANELEBBHAJ, NAHKHOEBAGF<TMVirt> DHAFDLKNNDO) where TMVirt : KLOPAHBBBHP.LJJJHFHEEAF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x22811F0", Offset = "0x22805F0", VA = "0x1822811F0")]
	public void BDONOOJMDEB<TMVirt>(NAHKHOEBAGF<NMNEKCGKICM> AANELEBBHAJ, NAHKHOEBAGF<NCMNDELHLHG> MNLPDHHHFIF, NAHKHOEBAGF<TMVirt> DHAFDLKNNDO) where TMVirt : HGECIKEBNJG.PHONDPFLBFO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x23A9D40", Offset = "0x23A9140", VA = "0x1823A9D40", Slot = "9")]
	public FANLNBOBJFD LIKPIGNOMAD()
	{
		return default(FANLNBOBJFD);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x23A84E0", Offset = "0x23A78E0", VA = "0x1823A84E0", Slot = "10")]
	public GDPKPBAOOCF FKHAOFOBGKJ(LHHDIPPKMNM GANFKPHKNKH)
	{
		return default(GDPKPBAOOCF);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x23AA1C0", Offset = "0x23A95C0", VA = "0x1823AA1C0", Slot = "11")]
	public bool OCNENKPINNK(LHHDIPPKMNM GANFKPHKNKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x23A9F40", Offset = "0x23A9340", VA = "0x1823A9F40", Slot = "4")]
	private void MENMNKBKBHC(NAHKHOEBAGF<NMNEKCGKICM> AANELEBBHAJ, NAHKHOEBAGF<NCMNDELHLHG> MNLPDHHHFIF, ref DCFAGOHJHDL DFKILLABCAM, NAHKHOEBAGF<HNHINANIHLF.IFOILDJOOJI>? DHIEDPBNEAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x23A9C80", Offset = "0x23A9080", VA = "0x1823A9C80", Slot = "5")]
	private void JGDBOBLPBKM(NAHKHOEBAGF<NMNEKCGKICM> AANELEBBHAJ, NAHKHOEBAGF<NCMNDELHLHG> MNLPDHHHFIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x23A9D90", Offset = "0x23A9190", VA = "0x1823A9D90", Slot = "6")]
	private void MCMMHOMOGDI(NAHKHOEBAGF<NMNEKCGKICM> AANELEBBHAJ, ref DCFAGOHJHDL DFKILLABCAM, NAHKHOEBAGF<HNHINANIHLF.IFOILDJOOJI>? DHIEDPBNEAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x23A8330", Offset = "0x23A7730", VA = "0x1823A8330", Slot = "7")]
	private void DKHNJBKGLMN(NAHKHOEBAGF<NMNEKCGKICM> AANELEBBHAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x23AA010", Offset = "0x23A9410", VA = "0x1823AA010")]
	internal ADOGIEMPLPD<NAHKHOEBAGF<NCMNDELHLHG>, HCGGKOEMGBM> MLJIHPKCDPE(NAHKHOEBAGF<NMNEKCGKICM> AANELEBBHAJ, NAHKHOEBAGF<GBFHMLMFMIH> EPMJENFCADK, in COJODKLKBHB IEGBDEAOAGE, in MLIFGPEKEEI IKMDCPAAKBK, ref DCFAGOHJHDL CGAFDNDNNOP, NAHKHOEBAGF<HNHINANIHLF.IFOILDJOOJI>? NLFCJLDNBAN)
	{
		return default(ADOGIEMPLPD<NAHKHOEBAGF<NCMNDELHLHG>, HCGGKOEMGBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x23A7090", Offset = "0x23A6490", VA = "0x1823A7090")]
	internal NAHKHOEBAGF<NCMNDELHLHG> BFMGCOFBOBM(NAHKHOEBAGF<NMNEKCGKICM> AANELEBBHAJ, NAHKHOEBAGF<GBFHMLMFMIH> EPMJENFCADK, in COJODKLKBHB IEGBDEAOAGE, in MLIFGPEKEEI IKMDCPAAKBK, ref DCFAGOHJHDL CGAFDNDNNOP, NAHKHOEBAGF<HNHINANIHLF.IFOILDJOOJI>? NLFCJLDNBAN)
	{
		return default(NAHKHOEBAGF<NCMNDELHLHG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x23A8450", Offset = "0x23A7850", VA = "0x1823A8450")]
	internal ADOGIEMPLPD<PNGLJAGHHDL, HCGGKOEMGBM> EBOCODNKGEJ(NAHKHOEBAGF<NMNEKCGKICM> AANELEBBHAJ, NAHKHOEBAGF<NCMNDELHLHG> MNLPDHHHFIF)
	{
		return default(ADOGIEMPLPD<PNGLJAGHHDL, HCGGKOEMGBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x2281540", Offset = "0x2280940", VA = "0x182281540")]
	public ADOGIEMPLPD<NAHKHOEBAGF<TM>, HCGGKOEMGBM> GNPJDKKNGLO<TM>(NAHKHOEBAGF<NMNEKCGKICM> AANELEBBHAJ, NAHKHOEBAGF<ABFPENOIEDD> PJJEOAHHDEJ) where TM : KLOPAHBBBHP.LJJJHFHEEAF
	{
		return default(ADOGIEMPLPD<NAHKHOEBAGF<TM>, HCGGKOEMGBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x22812A0", Offset = "0x22806A0", VA = "0x1822812A0")]
	public ADOGIEMPLPD<NAHKHOEBAGF<TM>, HCGGKOEMGBM> CPAKCPHDLLL<TM>(NAHKHOEBAGF<NMNEKCGKICM> AANELEBBHAJ, NAHKHOEBAGF<NCMNDELHLHG> MNLPDHHHFIF, NAHKHOEBAGF<GBFHMLMFMIH> CGNMMAHHGCD) where TM : HGECIKEBNJG.PHONDPFLBFO
	{
		return default(ADOGIEMPLPD<NAHKHOEBAGF<TM>, HCGGKOEMGBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x23A98B0", Offset = "0x23A8CB0", VA = "0x1823A98B0")]
	private ADOGIEMPLPD<(NAHKHOEBAGF<KBPKJNBAFHJ.NKGDOLNOGLL>, NAHKHOEBAGF<BFDJBGBEDEL.JEGEFGBKOLN>), HCGGKOEMGBM> HGOPFNGLFCB(NAHKHOEBAGF<NMNEKCGKICM> AANELEBBHAJ, NAHKHOEBAGF<NCMNDELHLHG> MNLPDHHHFIF)
	{
		return default(ADOGIEMPLPD<(NAHKHOEBAGF<KBPKJNBAFHJ.NKGDOLNOGLL>, NAHKHOEBAGF<BFDJBGBEDEL.JEGEFGBKOLN>), HCGGKOEMGBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x23A8680", Offset = "0x23A7A80", VA = "0x1823A8680")]
	internal ADOGIEMPLPD<(NAHKHOEBAGF<DPGHGBONKOF>, NAHKHOEBAGF<OJGIEILNKGG>), HCGGKOEMGBM> GCGOHCCGEDA(NAHKHOEBAGF<NMNEKCGKICM> AANELEBBHAJ, NAHKHOEBAGF<NCMNDELHLHG> MNLPDHHHFIF, int GEMPKDIGMHC, in AGPCOAPDEMK GANFKPHKNKH)
	{
		return default(ADOGIEMPLPD<(NAHKHOEBAGF<DPGHGBONKOF>, NAHKHOEBAGF<OJGIEILNKGG>), HCGGKOEMGBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x23A7AB0", Offset = "0x23A6EB0", VA = "0x1823A7AB0")]
	internal ADOGIEMPLPD<PNGLJAGHHDL, HCGGKOEMGBM> DKBEKFJCPOB(NAHKHOEBAGF<NMNEKCGKICM> AANELEBBHAJ, NAHKHOEBAGF<NCMNDELHLHG> MNLPDHHHFIF, int GEMPKDIGMHC)
	{
		return default(ADOGIEMPLPD<PNGLJAGHHDL, HCGGKOEMGBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x23A8F50", Offset = "0x23A8350", VA = "0x1823A8F50")]
	internal ADOGIEMPLPD<(NAHKHOEBAGF<OJGIEILNKGG>, NAHKHOEBAGF<DPGHGBONKOF>), HCGGKOEMGBM> GMJDKOGFFNM(NAHKHOEBAGF<NMNEKCGKICM> AANELEBBHAJ, NAHKHOEBAGF<NCMNDELHLHG> MNLPDHHHFIF, int ELGEOJHOOIF, in AGPCOAPDEMK GANFKPHKNKH)
	{
		return default(ADOGIEMPLPD<(NAHKHOEBAGF<OJGIEILNKGG>, NAHKHOEBAGF<DPGHGBONKOF>), HCGGKOEMGBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x23A71F0", Offset = "0x23A65F0", VA = "0x1823A71F0")]
	internal ADOGIEMPLPD<PNGLJAGHHDL, HCGGKOEMGBM> COCFPFEIECP(NAHKHOEBAGF<NMNEKCGKICM> AANELEBBHAJ, NAHKHOEBAGF<NCMNDELHLHG> MNLPDHHHFIF, int ELGEOJHOOIF)
	{
		return default(ADOGIEMPLPD<PNGLJAGHHDL, HCGGKOEMGBM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class OOMENIGDKFB : KLIHCOPGPGF
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x23B21B0", Offset = "0x23B15B0", VA = "0x1823B21B0", Slot = "7")]
	public override string NBKNGDNHDKI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x23B21E0", Offset = "0x23B15E0", VA = "0x1823B21E0")]
	public OOMENIGDKFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class NHPHHIAKMFK
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct AGPCOAPDEMK : IEquatable<AGPCOAPDEMK>, GMDIBMAAGEJ<AGPCOAPDEMK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly string ANHHJLAHIFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public readonly LHHDIPPKMNM OILIJCDIDLD;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0xD06A00", Offset = "0xD05E00", VA = "0x180D06A00")]
	private AGPCOAPDEMK(string GDKOBCHHFLB, LHHDIPPKMNM GANFKPHKNKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x238FC30", Offset = "0x238F030", VA = "0x18238FC30")]
	public static AGPCOAPDEMK NAILOIKCJEC(string GDKOBCHHFLB, LHHDIPPKMNM GANFKPHKNKH)
	{
		return default(AGPCOAPDEMK);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x238FBE0", Offset = "0x238EFE0", VA = "0x18238FBE0")]
	public static bool PHJEMBLBEDF(in AGPCOAPDEMK CAOIKBDHEDK, in AGPCOAPDEMK ELHFHDBGEMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x238FBE0", Offset = "0x238EFE0", VA = "0x18238FBE0", Slot = "4")]
	public bool Equals(AGPCOAPDEMK ICELKIGIKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x238FBE0", Offset = "0x238EFE0", VA = "0x18238FBE0")]
	public bool FCBBFOADOJJ(in AGPCOAPDEMK ICELKIGIKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x238FB30", Offset = "0x238EF30", VA = "0x18238FB30", Slot = "0")]
	public override bool Equals(object HFAGBIOODHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x22FB890", Offset = "0x22FAC90", VA = "0x1822FB890", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x238FC70", Offset = "0x238F070", VA = "0x18238FC70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x238FBE0", Offset = "0x238EFE0", VA = "0x18238FBE0", Slot = "5")]
	private bool MGGOAEMILGF(in AGPCOAPDEMK ICELKIGIKKP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct ODAJLMHCBBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public DHCIPKLFLPL<NMNEKCGKICM, GDPPMFCDOFD> HAFDOMMEOGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public ENLCANCKPAO<BFDJBGBEDEL.JEGEFGBKOLN> FAMPIEPLOEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public DHCIPKLFLPL<BFDJBGBEDEL.JEGEFGBKOLN, BFDJBGBEDEL.FIGLLJOEGCH> CEEIGLEMNHJ;

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x239B1C0", Offset = "0x239A5C0", VA = "0x18239B1C0")]
	private ODAJLMHCBBN(in DHCIPKLFLPL<NMNEKCGKICM, GDPPMFCDOFD> LEJDAGMDLDH, in ENLCANCKPAO<BFDJBGBEDEL.JEGEFGBKOLN> MLFFMIPNGMP, in DHCIPKLFLPL<BFDJBGBEDEL.JEGEFGBKOLN, BFDJBGBEDEL.FIGLLJOEGCH> CJGIPBEIABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x239B040", Offset = "0x239A440", VA = "0x18239B040")]
	public static ODAJLMHCBBN JHJNCDAFJPH(in DHCIPKLFLPL<NMNEKCGKICM, GDPPMFCDOFD> LEJDAGMDLDH, in ENLCANCKPAO<BFDJBGBEDEL.JEGEFGBKOLN> MLFFMIPNGMP, in DHCIPKLFLPL<BFDJBGBEDEL.JEGEFGBKOLN, BFDJBGBEDEL.FIGLLJOEGCH> CJGIPBEIABJ)
	{
		return default(ODAJLMHCBBN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class BMNIKLENIML
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x2392530", Offset = "0x2391930", VA = "0x182392530")]
	public static void EHKLIGBABLK(this ref ODAJLMHCBBN ODBHDBFBMOB, in ODLOHOMNPED LNNPKMHGNEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x23928D0", Offset = "0x2391CD0", VA = "0x1823928D0")]
	public static void GGMLKODJFHM(this ref ODAJLMHCBBN ODBHDBFBMOB, NAHKHOEBAGF<NMNEKCGKICM> AANELEBBHAJ, in GDPPMFCDOFD AOHOJLPKPNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2392340", Offset = "0x2391740", VA = "0x182392340")]
	public static void DODJNFMPKBN(this ref ODAJLMHCBBN ODBHDBFBMOB, NAHKHOEBAGF<NMNEKCGKICM> AANELEBBHAJ, in ODLOHOMNPED LNNPKMHGNEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x2392930", Offset = "0x2391D30", VA = "0x182392930")]
	public static GDPPMFCDOFD PHGLOPEHIMO(this in ODAJLMHCBBN ODBHDBFBMOB, NAHKHOEBAGF<NMNEKCGKICM> AANELEBBHAJ)
	{
		return default(GDPPMFCDOFD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x23922F0", Offset = "0x23916F0", VA = "0x1823922F0")]
	public static GDPPMFCDOFD CKGLFOOKOMF(this ref ODAJLMHCBBN ODBHDBFBMOB, NAHKHOEBAGF<NMNEKCGKICM> AANELEBBHAJ)
	{
		return default(GDPPMFCDOFD);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public sealed class BFDJBGBEDEL : OEALFMJHGOL
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public sealed class JEGEFGBKOLN : KLOPAHBBBHP.LJJJHFHEEAF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public struct FIGLLJOEGCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public string ANHHJLAHIFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public KGCLLCPMFNJ<EKJLBDBLLBL, AGPCOAPDEMK> AHGCIIGAPOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public KGCLLCPMFNJ<GJLAOGMDHNK, AGPCOAPDEMK> GNMOLDCJCJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public readonly NAHKHOEBAGF<NCMNDELHLHG> OMMMMFBCDKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public readonly NAHKHOEBAGF<NCMNDELHLHG> IINNMHPGIHL;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x239A980", Offset = "0x2399D80", VA = "0x18239A980")]
		private FIGLLJOEGCH(string GDKOBCHHFLB, in KGCLLCPMFNJ<EKJLBDBLLBL, AGPCOAPDEMK> LMDNLMHPDFC, in KGCLLCPMFNJ<GJLAOGMDHNK, AGPCOAPDEMK> HNHIDKGLBAM, NAHKHOEBAGF<NCMNDELHLHG> LNHDFNOLHNL, NAHKHOEBAGF<NCMNDELHLHG> JHMDNJIDNHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x239A8B0", Offset = "0x2399CB0", VA = "0x18239A8B0")]
		public static FIGLLJOEGCH NAILOIKCJEC(NAHKHOEBAGF<NCMNDELHLHG> AEKHDPPABEC, NAHKHOEBAGF<NCMNDELHLHG> FOKLBFLBIPI)
		{
			return default(FIGLLJOEGCH);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x239A830", Offset = "0x2399C30", VA = "0x18239A830")]
		public static FIGLLJOEGCH JHJNCDAFJPH(string GDKOBCHHFLB, in KGCLLCPMFNJ<EKJLBDBLLBL, AGPCOAPDEMK> LMDNLMHPDFC, in KGCLLCPMFNJ<GJLAOGMDHNK, AGPCOAPDEMK> HNHIDKGLBAM, NAHKHOEBAGF<NCMNDELHLHG> AEKHDPPABEC, NAHKHOEBAGF<NCMNDELHLHG> FOKLBFLBIPI)
		{
			return default(FIGLLJOEGCH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x2390EB0", Offset = "0x23902B0", VA = "0x182390EB0", Slot = "8")]
	public override void NBDEHIOCBPF(IHFMLBABICM HIIAJDHICEM, NAHKHOEBAGF<NMNEKCGKICM> AANELEBBHAJ, ref DCFAGOHJHDL DFKILLABCAM, NAHKHOEBAGF<HNHINANIHLF.IFOILDJOOJI>? NLFCJLDNBAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x2390CD0", Offset = "0x23900D0", VA = "0x182390CD0", Slot = "9")]
	public override void IPENKCMIODK(IHFMLBABICM HIIAJDHICEM, NAHKHOEBAGF<NMNEKCGKICM> AANELEBBHAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2391250", Offset = "0x2390650", VA = "0x182391250")]
	public BFDJBGBEDEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class OIDGIJCLDBC
{
	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x23B1450", Offset = "0x23B0850", VA = "0x1823B1450")]
	public static void EHKLIGBABLK(this ref BFDJBGBEDEL.FIGLLJOEGCH ODBHDBFBMOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct GDPPMFCDOFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public DHCIPKLFLPL<NCMNDELHLHG, IDCLFPHMBMP> MLEBNHHCJDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public ENLCANCKPAO<KBPKJNBAFHJ.NKGDOLNOGLL> BFBFCBFJGEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public DHCIPKLFLPL<KBPKJNBAFHJ.NKGDOLNOGLL, KBPKJNBAFHJ.IOFCCMKAOAK> JPNMANMOLGJ;

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x239B1C0", Offset = "0x239A5C0", VA = "0x18239B1C0")]
	private GDPPMFCDOFD(in DHCIPKLFLPL<NCMNDELHLHG, IDCLFPHMBMP> CMDCDPDJJLL, in ENLCANCKPAO<KBPKJNBAFHJ.NKGDOLNOGLL> JDIDDPHAMHG, in DHCIPKLFLPL<KBPKJNBAFHJ.NKGDOLNOGLL, KBPKJNBAFHJ.IOFCCMKAOAK> BGNEAOBNIIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x239B0D0", Offset = "0x239A4D0", VA = "0x18239B0D0")]
	public static GDPPMFCDOFD NAILOIKCJEC()
	{
		return default(GDPPMFCDOFD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x239B040", Offset = "0x239A440", VA = "0x18239B040")]
	public static GDPPMFCDOFD JHJNCDAFJPH(in DHCIPKLFLPL<NCMNDELHLHG, IDCLFPHMBMP> CMDCDPDJJLL, in ENLCANCKPAO<KBPKJNBAFHJ.NKGDOLNOGLL> JDIDDPHAMHG, in DHCIPKLFLPL<KBPKJNBAFHJ.NKGDOLNOGLL, KBPKJNBAFHJ.IOFCCMKAOAK> BGNEAOBNIIA)
	{
		return default(GDPPMFCDOFD);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class IBPEJGHFJLO
{
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x23A6B60", Offset = "0x23A5F60", VA = "0x1823A6B60")]
	public static void EHKLIGBABLK(this ref GDPPMFCDOFD ODBHDBFBMOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public abstract class OEALFMJHGOL : NPKNNGKIMBP<IHFMLBABICM>
{
	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x2391250", Offset = "0x2390650", VA = "0x182391250")]
	protected OEALFMJHGOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class MCHKJEJCPMG : OEALFMJHGOL
{
	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "8")]
	public override void NBDEHIOCBPF(IHFMLBABICM HIIAJDHICEM, NAHKHOEBAGF<NMNEKCGKICM> AANELEBBHAJ, ref DCFAGOHJHDL DFKILLABCAM, NAHKHOEBAGF<HNHINANIHLF.IFOILDJOOJI>? NLFCJLDNBAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "9")]
	public override void IPENKCMIODK(IHFMLBABICM HIIAJDHICEM, NAHKHOEBAGF<NMNEKCGKICM> AANELEBBHAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x2391250", Offset = "0x2390650", VA = "0x182391250")]
	public MCHKJEJCPMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface KDJJPBEBPDE
{
	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GJKIOLGPCAN LOIGKAOBJAE();

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GJKIOLGPCAN PJHCBAFOGBI();

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GJKIOLGPCAN KEHEKCHDKKG();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface MJEKODPBOFK
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<ADOGIEMPLPD<object, NADLJLPONBH>> NNNHCGKJDCL(BADMIJBBENP NDPBOAHDPLI, bool KGDIDIFEBMH);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class NMEJCIJJLHC : PGGMJAFNOKG<NMEJCIJJLHC, IHFMLBABICM>, GKAMKCKNDEH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private KGCLLCPMFNJ<INPCDOMJKDJ, GJKIOLGPCAN> DBLGKKKEHLC;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x23B08A0", Offset = "0x23AFCA0", VA = "0x1823B08A0", Slot = "6")]
	public NAHKHOEBAGF<INPCDOMJKDJ> JCFDFBLABEP(GJKIOLGPCAN CPJBMNDDECL)
	{
		return default(NAHKHOEBAGF<INPCDOMJKDJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x23B09E0", Offset = "0x23AFDE0", VA = "0x1823B09E0")]
	private NMEJCIJJLHC(in KGCLLCPMFNJ<GBFHMLMFMIH, BBMOELINLDO<IHFMLBABICM>> PKOPJGOECOJ, in KGCLLCPMFNJ<ABFPENOIEDD, OBMHGGFANCO<IHFMLBABICM>> KNCIHLBNNMF, in KGCLLCPMFNJ<INPCDOMJKDJ, GJKIOLGPCAN> BHINCEFGCCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x23B08F0", Offset = "0x23AFCF0", VA = "0x1823B08F0")]
	public static NMEJCIJJLHC NAILOIKCJEC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x23B07D0", Offset = "0x23AFBD0", VA = "0x1823B07D0")]
	public new (GLALEDCCPMM<GBFHMLMFMIH, BBMOELINLDO<IHFMLBABICM>>, GLALEDCCPMM<ABFPENOIEDD, OBMHGGFANCO<IHFMLBABICM>>, GLALEDCCPMM<INPCDOMJKDJ, GJKIOLGPCAN>) BDFBMDIFKMK()
	{
		return default((GLALEDCCPMM<GBFHMLMFMIH, BBMOELINLDO<IHFMLBABICM>>, GLALEDCCPMM<ABFPENOIEDD, OBMHGGFANCO<IHFMLBABICM>>, GLALEDCCPMM<INPCDOMJKDJ, GJKIOLGPCAN>));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface GKAMKCKNDEH
{
	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NAHKHOEBAGF<INPCDOMJKDJ> JCFDFBLABEP(GJKIOLGPCAN CPJBMNDDECL);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct EEOGEOBJECA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public DHCIPKLFLPL<BFDJBGBEDEL.JEGEFGBKOLN, JLIEGEGILBM<DPGHGBONKOF, OJGIEILNKGG, NCMNDELHLHG, NMNEKCGKICM>> PMELMAIIDJD;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x1FDA9C0", Offset = "0x1FD9DC0", VA = "0x181FDA9C0")]
	private EEOGEOBJECA(in DHCIPKLFLPL<BFDJBGBEDEL.JEGEFGBKOLN, JLIEGEGILBM<DPGHGBONKOF, OJGIEILNKGG, NCMNDELHLHG, NMNEKCGKICM>> AAJGKOIDLDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x23994A0", Offset = "0x23988A0", VA = "0x1823994A0")]
	public static EEOGEOBJECA NAILOIKCJEC()
	{
		return default(EEOGEOBJECA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class AEJFCCCJIDE
{
	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x238F9E0", Offset = "0x238EDE0", VA = "0x18238F9E0")]
	public static void EHKLIGBABLK(this ref EEOGEOBJECA ODBHDBFBMOB, in ENLCANCKPAO<BFDJBGBEDEL.JEGEFGBKOLN> MLFFMIPNGMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class KMKBEECLNDK
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x23ADFC0", Offset = "0x23AD3C0", VA = "0x1823ADFC0")]
	public static ICFKHFMJJMM CJMDONJKOCN(this in ODLOHOMNPED ODBHDBFBMOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x23AE170", Offset = "0x23AD570", VA = "0x1823AE170")]
	public static ODLOHOMNPED EFFJDOFDOEN(this ICFKHFMJJMM ODBHDBFBMOB)
	{
		return default(ODLOHOMNPED);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class CBIPKIHMPDB
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x2392BB0", Offset = "0x2391FB0", VA = "0x182392BB0")]
	public static CFNHBKOEADD CJMDONJKOCN(this IHFMLBABICM ODBHDBFBMOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2392C80", Offset = "0x2392080", VA = "0x182392C80")]
	public static IHFMLBABICM EFFJDOFDOEN(this CFNHBKOEADD ODBHDBFBMOB, in GEPGMKKIPBH DFLHLPHDCDC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class NMBAECNEDEE
{
	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x23B0700", Offset = "0x23AFB00", VA = "0x1823B0700")]
	public static HCKLINLGAEN CJMDONJKOCN(this in KBPKJNBAFHJ.IOFCCMKAOAK ODBHDBFBMOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x23B0780", Offset = "0x23AFB80", VA = "0x1823B0780")]
	public static KBPKJNBAFHJ.IOFCCMKAOAK EFFJDOFDOEN(this HCKLINLGAEN ODBHDBFBMOB)
	{
		return default(KBPKJNBAFHJ.IOFCCMKAOAK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class JLMHJCBPBAB
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x1649410", Offset = "0x1648810", VA = "0x181649410")]
	public static void DIMJNOFKGDK<TDeserialized, TSerialized>(this IReadOnlyCollection<TDeserialized> ODBHDBFBMOB, RepeatedField<TSerialized> DCBJJADOEJL, IEIGBGICOAC<TDeserialized, TSerialized> HKMOIPMNIJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class EAAMJCBCJHH
{
	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x2399260", Offset = "0x2398660", VA = "0x182399260")]
	public static NPFEFPBDBBL CJMDONJKOCN(this in AGPCOAPDEMK ODBHDBFBMOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x23992F0", Offset = "0x23986F0", VA = "0x1823992F0")]
	public static AGPCOAPDEMK EFFJDOFDOEN(this NPFEFPBDBBL ODBHDBFBMOB)
	{
		return default(AGPCOAPDEMK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class DAAMIMNPBLO
{
	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2397350", Offset = "0x2396750", VA = "0x182397350")]
	public static IJOFKFJHGIF CJMDONJKOCN(this in HALCKEOJHIJ ODBHDBFBMOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x23974E0", Offset = "0x23968E0", VA = "0x1823974E0")]
	public static HALCKEOJHIJ EFFJDOFDOEN(this IJOFKFJHGIF ODBHDBFBMOB)
	{
		return default(HALCKEOJHIJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class FBHABLHJOLK
{
	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x2399F50", Offset = "0x2399350", VA = "0x182399F50")]
	public static KBNFHKBINLL CJMDONJKOCN(this in ILONIPAEDDJ ODBHDBFBMOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x2399FD0", Offset = "0x23993D0", VA = "0x182399FD0")]
	public static ILONIPAEDDJ EFFJDOFDOEN(this KBNFHKBINLL ODBHDBFBMOB)
	{
		return default(ILONIPAEDDJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class BONHBLGBPOB
{
	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2392980", Offset = "0x2391D80", VA = "0x182392980")]
	public static BNGEEOAJAFI CJMDONJKOCN(in Guid ODBHDBFBMOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x2392AC0", Offset = "0x2391EC0", VA = "0x182392AC0")]
	public static Guid EFFJDOFDOEN(BNGEEOAJAFI ODBHDBFBMOB)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class CHOINGFDJGK
{
	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x23961F0", Offset = "0x23955F0", VA = "0x1823961F0")]
	public static GIGLDCGANAK CJMDONJKOCN(this in KLOPAHBBBHP ODBHDBFBMOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x2396800", Offset = "0x2395C00", VA = "0x182396800")]
	public static KLOPAHBBBHP EFFJDOFDOEN(this GIGLDCGANAK ODBHDBFBMOB)
	{
		return default(KLOPAHBBBHP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class IINHLNHLJGH
{
	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x23AA3B0", Offset = "0x23A97B0", VA = "0x1823AA3B0")]
	public static NDCIODPAKEL CJMDONJKOCN(IHFMLBABICM HIIAJDHICEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x23AA4E0", Offset = "0x23A98E0", VA = "0x1823AA4E0")]
	public static NDCIODPAKEL OLCEIJAOGBE(NAHKHOEBAGF<ABFPENOIEDD> NLGHNGKAAJF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class NBOONGHDBGB
{
	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x23AFF60", Offset = "0x23AF360", VA = "0x1823AFF60")]
	public static NELOEKDBOPK CJMDONJKOCN(this in FDGPILLEADB ODBHDBFBMOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x23AFFF0", Offset = "0x23AF3F0", VA = "0x1823AFFF0")]
	public static FDGPILLEADB EFFJDOFDOEN(this NELOEKDBOPK ODBHDBFBMOB)
	{
		return default(FDGPILLEADB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class HLJANGICCDF
{
	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x23A67B0", Offset = "0x23A5BB0", VA = "0x1823A67B0")]
	public static HFDMELJMNDH CJMDONJKOCN(this in COINOLINJHK ODBHDBFBMOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x23A69A0", Offset = "0x23A5DA0", VA = "0x1823A69A0")]
	public static COINOLINJHK EFFJDOFDOEN(this HFDMELJMNDH ODBHDBFBMOB)
	{
		return default(COINOLINJHK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class CFCOJEDDBFF
{
	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x23936B0", Offset = "0x2392AB0", VA = "0x1823936B0")]
	public static GOMFFGKJACL CJMDONJKOCN(this LHHDIPPKMNM GANFKPHKNKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x23947A0", Offset = "0x2393BA0", VA = "0x1823947A0")]
	public static LHHDIPPKMNM EFFJDOFDOEN(this GOMFFGKJACL GANFKPHKNKH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class HIIGCOBONIP
{
	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x23A5A80", Offset = "0x23A4E80", VA = "0x1823A5A80")]
	public static PCPFHKJLNDC CJMDONJKOCN(this in ODAJLMHCBBN ODBHDBFBMOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x23A5D30", Offset = "0x23A5130", VA = "0x1823A5D30")]
	public static ODAJLMHCBBN EFFJDOFDOEN(this PCPFHKJLNDC ODBHDBFBMOB)
	{
		return default(ODAJLMHCBBN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class OPAKEHCFAJK
{
	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x23B21F0", Offset = "0x23B15F0", VA = "0x1823B21F0")]
	public static BDLMAFDGICP CJMDONJKOCN(this in BIGKHCODBMH ODBHDBFBMOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x23B2280", Offset = "0x23B1680", VA = "0x1823B2280")]
	public static BIGKHCODBMH EFFJDOFDOEN(this BDLMAFDGICP ODBHDBFBMOB)
	{
		return default(BIGKHCODBMH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class HIKOGKIADPE
{
	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x2446480", Offset = "0x2445880", VA = "0x182446480")]
	public static GPNMGMAIGKL CJMDONJKOCN<TRoot>(this in KDPNPBPJFKA<TRoot> ODBHDBFBMOB) where TRoot : IMEMCMOHKOB<TRoot>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x23A60C0", Offset = "0x23A54C0", VA = "0x1823A60C0")]
	public static KDPNPBPJFKA<IHFMLBABICM> EFFJDOFDOEN(this GPNMGMAIGKL ODBHDBFBMOB, in GEPGMKKIPBH DFLHLPHDCDC)
	{
		return default(KDPNPBPJFKA<IHFMLBABICM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class DFGGGKCNBKH
{
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x2397D40", Offset = "0x2397140", VA = "0x182397D40")]
	public static CDGJEMLCNJL CJMDONJKOCN(this in HGECIKEBNJG ODBHDBFBMOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x2397DD0", Offset = "0x23971D0", VA = "0x182397DD0")]
	public static HGECIKEBNJG EFFJDOFDOEN(this CDGJEMLCNJL ODBHDBFBMOB)
	{
		return default(HGECIKEBNJG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class EKJMCPNLPEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x2399700", Offset = "0x2398B00", VA = "0x182399700")]
	public static OHFBIKIODCN CJMDONJKOCN(this in BFDJBGBEDEL.FIGLLJOEGCH ODBHDBFBMOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x23999B0", Offset = "0x2398DB0", VA = "0x1823999B0")]
	public static BFDJBGBEDEL.FIGLLJOEGCH EFFJDOFDOEN(this OHFBIKIODCN ODBHDBFBMOB)
	{
		return default(BFDJBGBEDEL.FIGLLJOEGCH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class OFMKFCBONEE
{
	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x23B0F60", Offset = "0x23B0360", VA = "0x1823B0F60")]
	public static IDECMAKKFDI CJMDONJKOCN(this in GDPKPBAOOCF ODBHDBFBMOB, LHHDIPPKMNM GANFKPHKNKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x23B1120", Offset = "0x23B0520", VA = "0x1823B1120")]
	public static GDPKPBAOOCF EFFJDOFDOEN(this IDECMAKKFDI ODBHDBFBMOB)
	{
		return default(GDPKPBAOOCF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class FNKMLMBJIGI
{
	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x17B43B0", Offset = "0x17B37B0", VA = "0x1817B43B0")]
	public static Dictionary<TDeserializedKey, TDeserializedValue> NGGPHGJMNKH<TDeserializedKey, TDeserializedValue, TSerialized>(this RepeatedField<TSerialized> DCBJJADOEJL, Func<TSerialized, TDeserializedKey> JLGGNKNDHHI, Func<TSerialized, TDeserializedValue> HEMFPPAMHBP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class JMOEKEAEPMM
{
	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x23AD260", Offset = "0x23AC660", VA = "0x1823AD260")]
	public static DAMDICGJBJJ CJMDONJKOCN(this in IDCLFPHMBMP ODBHDBFBMOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x23AD2F0", Offset = "0x23AC6F0", VA = "0x1823AD2F0")]
	public static IDCLFPHMBMP EFFJDOFDOEN(this DAMDICGJBJJ ODBHDBFBMOB)
	{
		return default(IDCLFPHMBMP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class BFGEKLDCBOO
{
	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x2391290", Offset = "0x2390690", VA = "0x182391290")]
	public static MEAPBFENMCF CJMDONJKOCN(this in GDPPMFCDOFD ODBHDBFBMOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x2391540", Offset = "0x2390940", VA = "0x182391540")]
	public static GDPPMFCDOFD EFFJDOFDOEN(this MEAPBFENMCF ODBHDBFBMOB)
	{
		return default(GDPPMFCDOFD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public readonly struct EFEHKHDCOOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public readonly NAHKHOEBAGF<NMNEKCGKICM> INBHDLKLECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public readonly NAHKHOEBAGF<NCMNDELHLHG> GLMAJHDOAKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public readonly int OCKADBMGHIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public readonly AGPCOAPDEMK OILIJCDIDLD;

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x23996E0", Offset = "0x2398AE0", VA = "0x1823996E0")]
	private EFEHKHDCOOP(NAHKHOEBAGF<NMNEKCGKICM> AANELEBBHAJ, NAHKHOEBAGF<NCMNDELHLHG> MNLPDHHHFIF, int ELGEOJHOOIF, AGPCOAPDEMK GANFKPHKNKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x2399500", Offset = "0x2398900", VA = "0x182399500")]
	public static BHAFDKNFICO<NBKNELADKPJ, EFEHKHDCOOP> HHLMDHJDKBK(BADMIJBBENP HMHINIHCKCD)
	{
		return default(BHAFDKNFICO<NBKNELADKPJ, EFEHKHDCOOP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x223BD80", Offset = "0x223B180", VA = "0x18223BD80")]
	public static ADOGIEMPLPD<(NAHKHOEBAGF<DPGHGBONKOF>, NAHKHOEBAGF<OJGIEILNKGG>), HCGGKOEMGBM> AMDCEGFLCBN<TRoot>(TRoot AOCBEEBNJPK, in EFEHKHDCOOP ODBHDBFBMOB) where TRoot : HIEIBOMFGIG
	{
		return default(ADOGIEMPLPD<(NAHKHOEBAGF<DPGHGBONKOF>, NAHKHOEBAGF<OJGIEILNKGG>), HCGGKOEMGBM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public readonly struct NPBLPLJIOLB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public readonly NAHKHOEBAGF<NMNEKCGKICM>? NDNDJEJDEEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public readonly NAHKHOEBAGF<ABFPENOIEDD> OFIEFNEDEMG;

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x176AB30", Offset = "0x1769F30", VA = "0x18176AB30")]
	private NPBLPLJIOLB(NAHKHOEBAGF<NMNEKCGKICM>? GHOIIDJKKFE, NAHKHOEBAGF<ABFPENOIEDD> PJJEOAHHDEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x23B0C80", Offset = "0x23B0080", VA = "0x1823B0C80")]
	public static BHAFDKNFICO<NBKNELADKPJ, NPBLPLJIOLB> HHLMDHJDKBK(BADMIJBBENP HMHINIHCKCD)
	{
		return default(BHAFDKNFICO<NBKNELADKPJ, NPBLPLJIOLB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x2406D70", Offset = "0x2406170", VA = "0x182406D70")]
	public static ADOGIEMPLPD<NAHKHOEBAGF<NMNEKCGKICM>, HCGGKOEMGBM> AMDCEGFLCBN<TRoot>(TRoot AOCBEEBNJPK, in NPBLPLJIOLB ODBHDBFBMOB) where TRoot : HIEIBOMFGIG
	{
		return default(ADOGIEMPLPD<NAHKHOEBAGF<NMNEKCGKICM>, HCGGKOEMGBM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public readonly struct GMICJPADMKO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public readonly NAHKHOEBAGF<NMNEKCGKICM> INBHDLKLECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public readonly NAHKHOEBAGF<NCMNDELHLHG> GLMAJHDOAKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public readonly int AIJJCMBJCFF;

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0xB91F00", Offset = "0xB91300", VA = "0x180B91F00")]
	private GMICJPADMKO(NAHKHOEBAGF<NMNEKCGKICM> AANELEBBHAJ, NAHKHOEBAGF<NCMNDELHLHG> MNLPDHHHFIF, int GEMPKDIGMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x239C600", Offset = "0x239BA00", VA = "0x18239C600")]
	public static BHAFDKNFICO<NBKNELADKPJ, GMICJPADMKO> HHLMDHJDKBK(BADMIJBBENP HMHINIHCKCD)
	{
		return default(BHAFDKNFICO<NBKNELADKPJ, GMICJPADMKO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x16E0340", Offset = "0x16DF740", VA = "0x1816E0340")]
	public static ADOGIEMPLPD<PNGLJAGHHDL, HCGGKOEMGBM> AMDCEGFLCBN<TRoot>(TRoot AOCBEEBNJPK, in GMICJPADMKO ODBHDBFBMOB) where TRoot : HIEIBOMFGIG
	{
		return default(ADOGIEMPLPD<PNGLJAGHHDL, HCGGKOEMGBM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public readonly struct KIJENBAPAHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public readonly NAHKHOEBAGF<NMNEKCGKICM> INBHDLKLECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public readonly NAHKHOEBAGF<OJGIEILNKGG> EMPLONFAILH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public readonly NAHKHOEBAGF<DPGHGBONKOF> EFOCONCIOOM;

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0xB91F00", Offset = "0xB91300", VA = "0x180B91F00")]
	private KIJENBAPAHC(NAHKHOEBAGF<NMNEKCGKICM> AANELEBBHAJ, NAHKHOEBAGF<OJGIEILNKGG> EGCGPFJBEDF, NAHKHOEBAGF<DPGHGBONKOF> ACIFIJJJFJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x23ADE80", Offset = "0x23AD280", VA = "0x1823ADE80")]
	public static BHAFDKNFICO<NBKNELADKPJ, KIJENBAPAHC> HHLMDHJDKBK(BADMIJBBENP HMHINIHCKCD)
	{
		return default(BHAFDKNFICO<NBKNELADKPJ, KIJENBAPAHC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x1D93780", Offset = "0x1D92B80", VA = "0x181D93780")]
	public static ADOGIEMPLPD<PNGLJAGHHDL, HCGGKOEMGBM> AMDCEGFLCBN<TRoot>(TRoot AOCBEEBNJPK, in KIJENBAPAHC ODBHDBFBMOB) where TRoot : HIEIBOMFGIG
	{
		return default(ADOGIEMPLPD<PNGLJAGHHDL, HCGGKOEMGBM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public readonly struct PNCPHAALAMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public readonly NAHKHOEBAGF<NMNEKCGKICM> INBHDLKLECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public readonly NAHKHOEBAGF<NCMNDELHLHG> GLMAJHDOAKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public readonly int OCKADBMGHIM;

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0xB91F00", Offset = "0xB91300", VA = "0x180B91F00")]
	private PNCPHAALAMB(NAHKHOEBAGF<NMNEKCGKICM> AANELEBBHAJ, NAHKHOEBAGF<NCMNDELHLHG> MNLPDHHHFIF, int GEMPKDIGMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x23B2770", Offset = "0x23B1B70", VA = "0x1823B2770")]
	public static BHAFDKNFICO<NBKNELADKPJ, PNCPHAALAMB> HHLMDHJDKBK(BADMIJBBENP HMHINIHCKCD)
	{
		return default(BHAFDKNFICO<NBKNELADKPJ, PNCPHAALAMB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x323A0B0", Offset = "0x32394B0", VA = "0x18323A0B0")]
	public static ADOGIEMPLPD<PNGLJAGHHDL, HCGGKOEMGBM> AMDCEGFLCBN<TRoot>(TRoot AOCBEEBNJPK, in PNCPHAALAMB ODBHDBFBMOB) where TRoot : HIEIBOMFGIG
	{
		return default(ADOGIEMPLPD<PNGLJAGHHDL, HCGGKOEMGBM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public readonly struct HDCJDGJPJOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public readonly NAHKHOEBAGF<NMNEKCGKICM> INBHDLKLECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public readonly NAHKHOEBAGF<NCMNDELHLHG> GLMAJHDOAKL;

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0xAEEC80", Offset = "0xAEE080", VA = "0x180AEEC80")]
	private HDCJDGJPJOJ(NAHKHOEBAGF<NMNEKCGKICM> AANELEBBHAJ, NAHKHOEBAGF<NCMNDELHLHG> MNLPDHHHFIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x23A52D0", Offset = "0x23A46D0", VA = "0x1823A52D0")]
	public static BHAFDKNFICO<NBKNELADKPJ, HDCJDGJPJOJ> HHLMDHJDKBK(BADMIJBBENP HMHINIHCKCD)
	{
		return default(BHAFDKNFICO<NBKNELADKPJ, HDCJDGJPJOJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x2438F40", Offset = "0x2438340", VA = "0x182438F40")]
	public static ADOGIEMPLPD<PNGLJAGHHDL, HCGGKOEMGBM> AMDCEGFLCBN<TRoot>(TRoot AOCBEEBNJPK, in HDCJDGJPJOJ ODBHDBFBMOB) where TRoot : HIEIBOMFGIG
	{
		return default(ADOGIEMPLPD<PNGLJAGHHDL, HCGGKOEMGBM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public readonly struct JJAKDBDAOBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public readonly NAHKHOEBAGF<NMNEKCGKICM> INBHDLKLECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public readonly NAHKHOEBAGF<DPGHGBONKOF> LBJOKLJLAID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public readonly GDPKPBAOOCF HKHCIOMHKGN;

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x23AC9C0", Offset = "0x23ABDC0", VA = "0x1823AC9C0")]
	private JJAKDBDAOBM(NAHKHOEBAGF<NMNEKCGKICM> AANELEBBHAJ, NAHKHOEBAGF<DPGHGBONKOF> PGDMBOOGMIG, in GDPKPBAOOCF CHKFHALGEFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x23AC850", Offset = "0x23ABC50", VA = "0x1823AC850")]
	public static BHAFDKNFICO<NBKNELADKPJ, JJAKDBDAOBM> HHLMDHJDKBK(BADMIJBBENP HMHINIHCKCD)
	{
		return default(BHAFDKNFICO<NBKNELADKPJ, JJAKDBDAOBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x1640890", Offset = "0x163FC90", VA = "0x181640890")]
	public static ADOGIEMPLPD<PNGLJAGHHDL, HCGGKOEMGBM> AMDCEGFLCBN<TRoot>(TRoot AOCBEEBNJPK, in JJAKDBDAOBM ODBHDBFBMOB) where TRoot : HIEIBOMFGIG
	{
		return default(ADOGIEMPLPD<PNGLJAGHHDL, HCGGKOEMGBM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public readonly struct GNJOMHOHACH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public readonly NAHKHOEBAGF<NMNEKCGKICM> INBHDLKLECA;

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0xA23350", Offset = "0xA22750", VA = "0x180A23350")]
	private GNJOMHOHACH(NAHKHOEBAGF<NMNEKCGKICM> AANELEBBHAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x239C710", Offset = "0x239BB10", VA = "0x18239C710")]
	public static BHAFDKNFICO<NBKNELADKPJ, GNJOMHOHACH> HHLMDHJDKBK(BADMIJBBENP HMHINIHCKCD)
	{
		return default(BHAFDKNFICO<NBKNELADKPJ, GNJOMHOHACH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x16E2710", Offset = "0x16E1B10", VA = "0x1816E2710")]
	public static ADOGIEMPLPD<PNGLJAGHHDL, HCGGKOEMGBM> AMDCEGFLCBN<TRoot>(TRoot AOCBEEBNJPK, in GNJOMHOHACH ODBHDBFBMOB) where TRoot : HIEIBOMFGIG
	{
		return default(ADOGIEMPLPD<PNGLJAGHHDL, HCGGKOEMGBM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public readonly struct IMNKEEEBNID
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public readonly NAHKHOEBAGF<NMNEKCGKICM> INBHDLKLECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public readonly NAHKHOEBAGF<OJGIEILNKGG> EMPLONFAILH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public readonly NAHKHOEBAGF<DPGHGBONKOF> EFOCONCIOOM;

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0xB91F00", Offset = "0xB91300", VA = "0x180B91F00")]
	private IMNKEEEBNID(NAHKHOEBAGF<NMNEKCGKICM> AANELEBBHAJ, NAHKHOEBAGF<OJGIEILNKGG> EGCGPFJBEDF, NAHKHOEBAGF<DPGHGBONKOF> ACIFIJJJFJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x23AC420", Offset = "0x23AB820", VA = "0x1823AC420")]
	public static BHAFDKNFICO<NBKNELADKPJ, IMNKEEEBNID> HHLMDHJDKBK(BADMIJBBENP HMHINIHCKCD)
	{
		return default(BHAFDKNFICO<NBKNELADKPJ, IMNKEEEBNID>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x1029560", Offset = "0x1028960", VA = "0x181029560")]
	public static ADOGIEMPLPD<PNGLJAGHHDL, HCGGKOEMGBM> AMDCEGFLCBN<TRoot>(TRoot AOCBEEBNJPK, in IMNKEEEBNID ODBHDBFBMOB) where TRoot : HIEIBOMFGIG
	{
		return default(ADOGIEMPLPD<PNGLJAGHHDL, HCGGKOEMGBM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public readonly struct NBMPCFOFKMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public readonly NAHKHOEBAGF<NMNEKCGKICM> INBHDLKLECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public readonly NAHKHOEBAGF<NCMNDELHLHG> GLMAJHDOAKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public readonly NAHKHOEBAGF<EKJLBDBLLBL> ENPIEJDEIJJ;

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0xB91F00", Offset = "0xB91300", VA = "0x180B91F00")]
	private NBMPCFOFKMP(NAHKHOEBAGF<NMNEKCGKICM> AANELEBBHAJ, NAHKHOEBAGF<NCMNDELHLHG> MNLPDHHHFIF, NAHKHOEBAGF<EKJLBDBLLBL> AFNBLFHJFCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x23AFE20", Offset = "0x23AF220", VA = "0x1823AFE20")]
	public static BHAFDKNFICO<NBKNELADKPJ, NBMPCFOFKMP> HHLMDHJDKBK(BADMIJBBENP HMHINIHCKCD)
	{
		return default(BHAFDKNFICO<NBKNELADKPJ, NBMPCFOFKMP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x24012B0", Offset = "0x24006B0", VA = "0x1824012B0")]
	public static ADOGIEMPLPD<NAHKHOEBAGF<DPGHGBONKOF>, HCGGKOEMGBM> AMDCEGFLCBN<TRoot>(TRoot AOCBEEBNJPK, in NBMPCFOFKMP ODBHDBFBMOB) where TRoot : HIEIBOMFGIG
	{
		return default(ADOGIEMPLPD<NAHKHOEBAGF<DPGHGBONKOF>, HCGGKOEMGBM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public readonly struct GPMMKEFJAMH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public readonly NAHKHOEBAGF<NMNEKCGKICM> INBHDLKLECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public readonly NAHKHOEBAGF<NCMNDELHLHG> GLMAJHDOAKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public readonly int AIJJCMBJCFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public readonly AGPCOAPDEMK OILIJCDIDLD;

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x23996E0", Offset = "0x2398AE0", VA = "0x1823996E0")]
	private GPMMKEFJAMH(NAHKHOEBAGF<NMNEKCGKICM> AANELEBBHAJ, NAHKHOEBAGF<NCMNDELHLHG> MNLPDHHHFIF, int ELGEOJHOOIF, AGPCOAPDEMK GANFKPHKNKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x23A50F0", Offset = "0x23A44F0", VA = "0x1823A50F0")]
	public static BHAFDKNFICO<NBKNELADKPJ, GPMMKEFJAMH> HHLMDHJDKBK(BADMIJBBENP HMHINIHCKCD)
	{
		return default(BHAFDKNFICO<NBKNELADKPJ, GPMMKEFJAMH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x16E2D00", Offset = "0x16E2100", VA = "0x1816E2D00")]
	public static ADOGIEMPLPD<(NAHKHOEBAGF<OJGIEILNKGG>, NAHKHOEBAGF<DPGHGBONKOF>), HCGGKOEMGBM> AMDCEGFLCBN<TRoot>(TRoot AOCBEEBNJPK, in GPMMKEFJAMH ODBHDBFBMOB) where TRoot : HIEIBOMFGIG
	{
		return default(ADOGIEMPLPD<(NAHKHOEBAGF<OJGIEILNKGG>, NAHKHOEBAGF<DPGHGBONKOF>), HCGGKOEMGBM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public readonly struct DGBENNPBEPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public readonly NAHKHOEBAGF<NMNEKCGKICM> INBHDLKLECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public readonly NAHKHOEBAGF<GBFHMLMFMIH> LKKOLIJHDGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public readonly COJODKLKBHB NEGNDNNABPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public readonly MLIFGPEKEEI DOIAKOGFGJO;

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x2398220", Offset = "0x2397620", VA = "0x182398220")]
	private DGBENNPBEPA(NAHKHOEBAGF<NMNEKCGKICM> AANELEBBHAJ, NAHKHOEBAGF<GBFHMLMFMIH> MECMLDCHDHE, in COJODKLKBHB BEDNKJGEIMN, in MLIFGPEKEEI FGJBEFNBLMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x2398080", Offset = "0x2397480", VA = "0x182398080")]
	public static BHAFDKNFICO<NBKNELADKPJ, DGBENNPBEPA> HHLMDHJDKBK(BADMIJBBENP HMHINIHCKCD)
	{
		return default(BHAFDKNFICO<NBKNELADKPJ, DGBENNPBEPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x2C7E410", Offset = "0x2C7D810", VA = "0x182C7E410")]
	public static ADOGIEMPLPD<NAHKHOEBAGF<NCMNDELHLHG>, HCGGKOEMGBM> AMDCEGFLCBN<TRoot>(TRoot AOCBEEBNJPK, in DGBENNPBEPA ODBHDBFBMOB) where TRoot : HIEIBOMFGIG
	{
		return default(ADOGIEMPLPD<NAHKHOEBAGF<NCMNDELHLHG>, HCGGKOEMGBM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public sealed class GEIODKCGMFJ : LHHJDNKJKHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public readonly NAHKHOEBAGF<EKJLBDBLLBL> MMNGDALGGKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public readonly NAHKHOEBAGF<GJLAOGMDHNK> ADPNGDJCGJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public readonly NAHKHOEBAGF<GJLAOGMDHNK> CPBJHPBPIEF;

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x239B230", Offset = "0x239A630", VA = "0x18239B230")]
	public GEIODKCGMFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public sealed class HHJJJJIKFDJ : DCPDGMEHADI
{
	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x23A53F0", Offset = "0x23A47F0", VA = "0x1823A53F0")]
	public HHJJJJIKFDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public sealed class FHLANKOBKAM : NALAKIIMLPD
{
	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "11")]
	public override void NBDEHIOCBPF(IHFMLBABICM HIIAJDHICEM, NAHKHOEBAGF<NMNEKCGKICM> AANELEBBHAJ, NAHKHOEBAGF<NCMNDELHLHG> MNLPDHHHFIF, ref DCFAGOHJHDL DFKILLABCAM, NAHKHOEBAGF<HNHINANIHLF.IFOILDJOOJI>? DHIEDPBNEAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "12")]
	public override void IPENKCMIODK(IHFMLBABICM HIIAJDHICEM, NAHKHOEBAGF<NMNEKCGKICM> AANELEBBHAJ, NAHKHOEBAGF<NCMNDELHLHG> MNLPDHHHFIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x239A490", Offset = "0x2399890", VA = "0x18239A490", Slot = "13")]
	public override IEnumerable<IPHGKEIMNBE<LHHDIPPKMNM>> GIHEHBEJHFI(IHFMLBABICM HIIAJDHICEM, NAHKHOEBAGF<NMNEKCGKICM> AANELEBBHAJ, NAHKHOEBAGF<NCMNDELHLHG> MNLPDHHHFIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x239A4C0", Offset = "0x23998C0", VA = "0x18239A4C0", Slot = "14")]
	public override void JPCPFPLFLIC(IHFMLBABICM HIIAJDHICEM, NAHKHOEBAGF<NMNEKCGKICM> AANELEBBHAJ, NAHKHOEBAGF<NCMNDELHLHG> MNLPDHHHFIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x239A6D0", Offset = "0x2399AD0", VA = "0x18239A6D0")]
	public static void PDPPNNOEJMM(IHFMLBABICM HIIAJDHICEM, in BFDJBGBEDEL.FIGLLJOEGCH DJDEHGBIIPP, NAHKHOEBAGF<NMNEKCGKICM> AANELEBBHAJ, NAHKHOEBAGF<DPGHGBONKOF> PGDMBOOGMIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x239A690", Offset = "0x2399A90", VA = "0x18239A690", Slot = "15")]
	public override GDPKPBAOOCF PBOGPNDHEOB(IHFMLBABICM HIIAJDHICEM, NAHKHOEBAGF<NMNEKCGKICM> AANELEBBHAJ, NAHKHOEBAGF<NCMNDELHLHG> MNLPDHHHFIF, NAHKHOEBAGF<EKJLBDBLLBL> AFNBLFHJFCB, LHHDIPPKMNM ACPGFAEOHIF)
	{
		return default(GDPKPBAOOCF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x239A7F0", Offset = "0x2399BF0", VA = "0x18239A7F0")]
	public FHLANKOBKAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public struct IDCLFPHMBMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public COJODKLKBHB NEGNDNNABPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public MLIFGPEKEEI DOIAKOGFGJO;

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x23A6E50", Offset = "0x23A6250", VA = "0x1823A6E50")]
	internal IDCLFPHMBMP(in COJODKLKBHB IEGBDEAOAGE, in MLIFGPEKEEI IKMDCPAAKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x23A6E20", Offset = "0x23A6220", VA = "0x1823A6E20")]
	public static IDCLFPHMBMP NAILOIKCJEC()
	{
		return default(IDCLFPHMBMP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x23A6E00", Offset = "0x23A6200", VA = "0x1823A6E00")]
	public static IDCLFPHMBMP JHJNCDAFJPH(in COJODKLKBHB IEGBDEAOAGE, in MLIFGPEKEEI IKMDCPAAKBK)
	{
		return default(IDCLFPHMBMP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public abstract class NALAKIIMLPD : ECHEGFIJIPD<IHFMLBABICM>
{
	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x239A7F0", Offset = "0x2399BF0", VA = "0x18239A7F0")]
	protected NALAKIIMLPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public sealed class IMMDPBJIBAA : NALAKIIMLPD
{
	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "11")]
	public override void NBDEHIOCBPF(IHFMLBABICM HIIAJDHICEM, NAHKHOEBAGF<NMNEKCGKICM> AANELEBBHAJ, NAHKHOEBAGF<NCMNDELHLHG> MNLPDHHHFIF, ref DCFAGOHJHDL DFKILLABCAM, NAHKHOEBAGF<HNHINANIHLF.IFOILDJOOJI>? DHIEDPBNEAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "12")]
	public override void IPENKCMIODK(IHFMLBABICM HIIAJDHICEM, NAHKHOEBAGF<NMNEKCGKICM> AANELEBBHAJ, NAHKHOEBAGF<NCMNDELHLHG> MNLPDHHHFIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x23AC100", Offset = "0x23AB500", VA = "0x1823AC100", Slot = "13")]
	public override IEnumerable<IPHGKEIMNBE<LHHDIPPKMNM>> GIHEHBEJHFI(IHFMLBABICM HIIAJDHICEM, NAHKHOEBAGF<NMNEKCGKICM> AANELEBBHAJ, NAHKHOEBAGF<NCMNDELHLHG> MNLPDHHHFIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x23AC250", Offset = "0x23AB650", VA = "0x1823AC250", Slot = "14")]
	public override void JPCPFPLFLIC(IHFMLBABICM HIIAJDHICEM, NAHKHOEBAGF<NMNEKCGKICM> AANELEBBHAJ, NAHKHOEBAGF<NCMNDELHLHG> MNLPDHHHFIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x23AC130", Offset = "0x23AB530", VA = "0x1823AC130")]
	public static void ICJAAICIHPO(IHFMLBABICM HIIAJDHICEM, in BFDJBGBEDEL.FIGLLJOEGCH DJDEHGBIIPP, NAHKHOEBAGF<NMNEKCGKICM> AANELEBBHAJ, NAHKHOEBAGF<OJGIEILNKGG> EPKINADMKOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x239A690", Offset = "0x2399A90", VA = "0x18239A690", Slot = "15")]
	public override GDPKPBAOOCF PBOGPNDHEOB(IHFMLBABICM HIIAJDHICEM, NAHKHOEBAGF<NMNEKCGKICM> AANELEBBHAJ, NAHKHOEBAGF<NCMNDELHLHG> MNLPDHHHFIF, NAHKHOEBAGF<EKJLBDBLLBL> AFNBLFHJFCB, LHHDIPPKMNM ACPGFAEOHIF)
	{
		return default(GDPKPBAOOCF);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x239A7F0", Offset = "0x2399BF0", VA = "0x18239A7F0")]
	public IMMDPBJIBAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public sealed class GLNOMOMIHPN : LCFKMCIMKBF
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x239C240", Offset = "0x239B640", VA = "0x18239C240")]
	public GLNOMOMIHPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public sealed class MIPAEGFBHEP : LCFKMCIMKBF
{
	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x23AF840", Offset = "0x23AEC40", VA = "0x1823AF840")]
	public MIPAEGFBHEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public sealed class KBPKJNBAFHJ : NALAKIIMLPD
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public sealed class NKGDOLNOGLL : HGECIKEBNJG.PHONDPFLBFO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public struct IOFCCMKAOAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public readonly NAHKHOEBAGF<NMNEKCGKICM> DKMKBOOLBGO;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xA23350", Offset = "0xA22750", VA = "0x180A23350")]
		private IOFCCMKAOAK(NAHKHOEBAGF<NMNEKCGKICM> JHMPMNGAEHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x1FACE80", Offset = "0x1FAC280", VA = "0x181FACE80")]
		public static IOFCCMKAOAK NAILOIKCJEC(NAHKHOEBAGF<NMNEKCGKICM> ICLLENGLFPK)
		{
			return default(IOFCCMKAOAK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x23AD9F0", Offset = "0x23ACDF0", VA = "0x1823AD9F0", Slot = "11")]
	public override void NBDEHIOCBPF(IHFMLBABICM HIIAJDHICEM, NAHKHOEBAGF<NMNEKCGKICM> AANELEBBHAJ, NAHKHOEBAGF<NCMNDELHLHG> MNLPDHHHFIF, ref DCFAGOHJHDL DFKILLABCAM, NAHKHOEBAGF<HNHINANIHLF.IFOILDJOOJI>? DHIEDPBNEAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x23AD550", Offset = "0x23AC950", VA = "0x1823AD550", Slot = "12")]
	public override void IPENKCMIODK(IHFMLBABICM HIIAJDHICEM, NAHKHOEBAGF<NMNEKCGKICM> AANELEBBHAJ, NAHKHOEBAGF<NCMNDELHLHG> MNLPDHHHFIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x23AD3A0", Offset = "0x23AC7A0", VA = "0x1823AD3A0", Slot = "13")]
	public override IEnumerable<IPHGKEIMNBE<LHHDIPPKMNM>> GIHEHBEJHFI(IHFMLBABICM HIIAJDHICEM, NAHKHOEBAGF<NMNEKCGKICM> AANELEBBHAJ, NAHKHOEBAGF<NCMNDELHLHG> MNLPDHHHFIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x23AD6A0", Offset = "0x23ACAA0", VA = "0x1823AD6A0", Slot = "14")]
	public override void JPCPFPLFLIC(IHFMLBABICM HIIAJDHICEM, NAHKHOEBAGF<NMNEKCGKICM> AANELEBBHAJ, NAHKHOEBAGF<NCMNDELHLHG> MNLPDHHHFIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x23ADB70", Offset = "0x23ACF70", VA = "0x1823ADB70")]
	public static void PDPPNNOEJMM(IHFMLBABICM HIIAJDHICEM, in BFDJBGBEDEL.FIGLLJOEGCH DJDEHGBIIPP, NAHKHOEBAGF<NMNEKCGKICM> AANELEBBHAJ, NAHKHOEBAGF<DPGHGBONKOF> PGDMBOOGMIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x23AD460", Offset = "0x23AC860", VA = "0x1823AD460")]
	public static void ICJAAICIHPO(IHFMLBABICM HIIAJDHICEM, in BFDJBGBEDEL.FIGLLJOEGCH DJDEHGBIIPP, NAHKHOEBAGF<NMNEKCGKICM> AANELEBBHAJ, NAHKHOEBAGF<OJGIEILNKGG> EPKINADMKOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x239A690", Offset = "0x2399A90", VA = "0x18239A690", Slot = "15")]
	public override GDPKPBAOOCF PBOGPNDHEOB(IHFMLBABICM HIIAJDHICEM, NAHKHOEBAGF<NMNEKCGKICM> AANELEBBHAJ, NAHKHOEBAGF<NCMNDELHLHG> MNLPDHHHFIF, NAHKHOEBAGF<EKJLBDBLLBL> AFNBLFHJFCB, LHHDIPPKMNM ACPGFAEOHIF)
	{
		return default(GDPKPBAOOCF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x239A7F0", Offset = "0x2399BF0", VA = "0x18239A7F0")]
	public KBPKJNBAFHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public abstract class LHHJDNKJKHG : OECBDENJLMP<IHFMLBABICM>
{
	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x2397CF0", Offset = "0x23970F0", VA = "0x182397CF0")]
	protected LHHJDNKJKHG(in BKJHKNHLLHL GIBDJEMOLOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x23AF0C0", Offset = "0x23AE4C0", VA = "0x1823AF0C0", Slot = "11")]
	public override void NBDEHIOCBPF(IHFMLBABICM AOCBEEBNJPK, NAHKHOEBAGF<NMNEKCGKICM> AANELEBBHAJ, NAHKHOEBAGF<NCMNDELHLHG> MNLPDHHHFIF, ref DCFAGOHJHDL DFKILLABCAM, NAHKHOEBAGF<HNHINANIHLF.IFOILDJOOJI>? DHIEDPBNEAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x23AF040", Offset = "0x23AE440", VA = "0x1823AF040", Slot = "14")]
	public override void JPCPFPLFLIC(IHFMLBABICM AOCBEEBNJPK, NAHKHOEBAGF<NMNEKCGKICM> AANELEBBHAJ, NAHKHOEBAGF<NCMNDELHLHG> MNLPDHHHFIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public abstract class DCPDGMEHADI : LHHJDNKJKHG
{
	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x2397CF0", Offset = "0x23970F0", VA = "0x182397CF0")]
	public DCPDGMEHADI(in BKJHKNHLLHL GIBDJEMOLOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public abstract class LCFKMCIMKBF : FJOHFNLFIIO<IHFMLBABICM>
{
	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x23AEDD0", Offset = "0x23AE1D0", VA = "0x1823AEDD0")]
	protected LCFKMCIMKBF(in ECCMIFBJBKL GIBDJEMOLOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x23AED20", Offset = "0x23AE120", VA = "0x1823AED20", Slot = "11")]
	public override void NBDEHIOCBPF(IHFMLBABICM AOCBEEBNJPK, NAHKHOEBAGF<NMNEKCGKICM> AANELEBBHAJ, NAHKHOEBAGF<NCMNDELHLHG> MNLPDHHHFIF, ref DCFAGOHJHDL DFKILLABCAM, NAHKHOEBAGF<HNHINANIHLF.IFOILDJOOJI>? DHIEDPBNEAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x23AEAC0", Offset = "0x23ADEC0", VA = "0x1823AEAC0", Slot = "12")]
	public override void IPENKCMIODK(IHFMLBABICM AOCBEEBNJPK, NAHKHOEBAGF<NMNEKCGKICM> AANELEBBHAJ, NAHKHOEBAGF<NCMNDELHLHG> MNLPDHHHFIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x23AECA0", Offset = "0x23AE0A0", VA = "0x1823AECA0", Slot = "14")]
	public override void JPCPFPLFLIC(IHFMLBABICM AOCBEEBNJPK, NAHKHOEBAGF<NMNEKCGKICM> AANELEBBHAJ, NAHKHOEBAGF<NCMNDELHLHG> MNLPDHHHFIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x23AEB50", Offset = "0x23ADF50", VA = "0x1823AEB50", Slot = "17")]
	public override ADOGIEMPLPD<NAHKHOEBAGF<DPGHGBONKOF>, HCGGKOEMGBM> JDHKEBAPDPB(IHFMLBABICM AOCBEEBNJPK, NAHKHOEBAGF<NMNEKCGKICM> AANELEBBHAJ, NAHKHOEBAGF<NCMNDELHLHG> MNLPDHHHFIF, NAHKHOEBAGF<EKJLBDBLLBL> AFNBLFHJFCB)
	{
		return default(ADOGIEMPLPD<NAHKHOEBAGF<DPGHGBONKOF>, HCGGKOEMGBM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public readonly struct CHGLFDMCNHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly Guid DCALPGDDJHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly string PDDGBIPPDAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly bool PHIPHNPPKPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private readonly bool FKEKOAELHCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly bool KILFJFMBJHM;

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x2395900", Offset = "0x2394D00", VA = "0x182395900")]
	public CHGLFDMCNHC(in Guid JNHCLKAAKHA, string GDKOBCHHFLB, bool LEOHGBOKHHM, bool OPNJHDELLPO, bool LFKAIOMHOBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x2395640", Offset = "0x2394A40", VA = "0x182395640")]
	public JHICBIFNHLJ MGKCFBFDGBG(string GDKOBCHHFLB, LHHDIPPKMNM GANFKPHKNKH)
	{
		return default(JHICBIFNHLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x2395810", Offset = "0x2394C10", VA = "0x182395810")]
	public OOKFAJNJHBK NPJNKCPHLIJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public abstract class ODNFECNHFOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public readonly LHHDIPPKMNM LNGLLEADEBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private readonly List<OOKFAJNJHBK> HMMHJHFPBFG;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public IReadOnlyList<OOKFAJNJHBK> KNLONDGNPMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x23B0E50", Offset = "0x23B0250", VA = "0x1823B0E50")]
	protected ODNFECNHFOH(LHHDIPPKMNM GIKJIHGCIKE, params OOKFAJNJHBK[][] PBBOHGPNEEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class DCDGKLHMFKP : ODNFECNHFOH
{
	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x2397AD0", Offset = "0x2396ED0", VA = "0x182397AD0")]
	internal DCDGKLHMFKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class JLGPIHCLOOE : ODNFECNHFOH
{
	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x23AD040", Offset = "0x23AC440", VA = "0x1823AD040")]
	internal JLGPIHCLOOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class OGLLBPNKHLL : ODNFECNHFOH
{
	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x23B1230", Offset = "0x23B0630", VA = "0x1823B1230")]
	internal OGLLBPNKHLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class JLGHPAJPGJP : ODNFECNHFOH
{
	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x23ACE20", Offset = "0x23AC220", VA = "0x1823ACE20")]
	internal JLGHPAJPGJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class EPCPMIKKKBB : ODNFECNHFOH
{
	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x2399D30", Offset = "0x2399130", VA = "0x182399D30")]
	internal EPCPMIKKKBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class NCEOFCJNHFO : ODNFECNHFOH
{
	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x23B00A0", Offset = "0x23AF4A0", VA = "0x1823B00A0")]
	internal NCEOFCJNHFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public class ACKILPMPKFE : ODNFECNHFOH
{
	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x238F760", Offset = "0x238EB60", VA = "0x18238F760")]
	internal ACKILPMPKFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class PBDCCEHGJCI : ODNFECNHFOH
{
	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x23B2330", Offset = "0x23B1730", VA = "0x1823B2330")]
	internal PBDCCEHGJCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class FOKFNMEKPLN : ODNFECNHFOH
{
	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x239AC00", Offset = "0x239A000", VA = "0x18239AC00")]
	internal FOKFNMEKPLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class LELNFJBOCDI : ODNFECNHFOH
{
	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x23AEE20", Offset = "0x23AE220", VA = "0x1823AEE20")]
	internal LELNFJBOCDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class EDPIDEIEGEJ : ODNFECNHFOH
{
	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x2399380", Offset = "0x2398780", VA = "0x182399380")]
	internal EDPIDEIEGEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class CGKCLJIMILF : ODNFECNHFOH
{
	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x2395420", Offset = "0x2394820", VA = "0x182395420")]
	internal CGKCLJIMILF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class JKLCJILPIJN : ODNFECNHFOH
{
	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x23ACC00", Offset = "0x23AC000", VA = "0x1823ACC00")]
	internal JKLCJILPIJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class MIJCMDFMBID : ODNFECNHFOH
{
	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x23AF620", Offset = "0x23AEA20", VA = "0x1823AF620")]
	internal MIJCMDFMBID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class AOPPGJDDOMJ : ODNFECNHFOH
{
	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x238FED0", Offset = "0x238F2D0", VA = "0x18238FED0")]
	internal AOPPGJDDOMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class LPCJEOENMAG : ODNFECNHFOH
{
	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x23AF140", Offset = "0x23AE540", VA = "0x1823AF140")]
	internal LPCJEOENMAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class DFJLEEKHFJO : ODNFECNHFOH
{
	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x2397E60", Offset = "0x2397260", VA = "0x182397E60")]
	internal DFJLEEKHFJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class NGEADMODDJG : ODNFECNHFOH
{
	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x23B02C0", Offset = "0x23AF6C0", VA = "0x1823B02C0")]
	internal NGEADMODDJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class GJBDBHMJFJG : ODNFECNHFOH
{
	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x239C020", Offset = "0x239B420", VA = "0x18239C020")]
	internal GJBDBHMJFJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class ICHJFLHOACP : ODNFECNHFOH
{
	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x23A6BE0", Offset = "0x23A5FE0", VA = "0x1823A6BE0")]
	internal ICHJFLHOACP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class JJJJBGKAHPP : ODNFECNHFOH
{
	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x23AC9E0", Offset = "0x23ABDE0", VA = "0x1823AC9E0")]
	internal JJJJBGKAHPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class FFDIEFJBBIF : ODNFECNHFOH
{
	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x239A050", Offset = "0x2399450", VA = "0x18239A050")]
	internal FFDIEFJBBIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public class FHFJDLBJPMG : ODNFECNHFOH
{
	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x239A270", Offset = "0x2399670", VA = "0x18239A270")]
	internal FHFJDLBJPMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class MFKLADICJGG : ODNFECNHFOH
{
	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x23AF400", Offset = "0x23AE800", VA = "0x1823AF400")]
	internal MFKLADICJGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class BEOAEHMPJJG : ODNFECNHFOH
{
	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x2390AB0", Offset = "0x238FEB0", VA = "0x182390AB0")]
	internal BEOAEHMPJJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class DAOBPEJHIHO : ODNFECNHFOH
{
	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x2397690", Offset = "0x2396A90", VA = "0x182397690")]
	internal DAOBPEJHIHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class PLOMMJAMIJE : ODNFECNHFOH
{
	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x23B2550", Offset = "0x23B1950", VA = "0x1823B2550")]
	internal PLOMMJAMIJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class IEBOPOEFCFN : ODNFECNHFOH
{
	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x23A6E70", Offset = "0x23A6270", VA = "0x1823A6E70")]
	internal IEBOPOEFCFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class NMHMMDPKGPN : ODNFECNHFOH
{
	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x23B0A60", Offset = "0x23AFE60", VA = "0x1823B0A60")]
	internal NMHMMDPKGPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public class DNCJCMCAFFC : ODNFECNHFOH
{
	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x2398250", Offset = "0x2397650", VA = "0x182398250")]
	internal DNCJCMCAFFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class DAOIMANFHOP : ODNFECNHFOH
{
	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x23978B0", Offset = "0x2396CB0", VA = "0x1823978B0")]
	internal DAOIMANFHOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public class GPHAKGOFPLD : ODNFECNHFOH
{
	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x23A4ED0", Offset = "0x23A42D0", VA = "0x1823A4ED0")]
	internal GPHAKGOFPLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public class LCCDJPHMMPO : ODNFECNHFOH
{
	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x23AE8A0", Offset = "0x23ADCA0", VA = "0x1823AE8A0")]
	internal LCCDJPHMMPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public class GOLAIGJFLPI : ODNFECNHFOH
{
	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x23A4CB0", Offset = "0x23A40B0", VA = "0x1823A4CB0")]
	internal GOLAIGJFLPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class MLFENEIPCFN : ODNFECNHFOH
{
	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x23AFC00", Offset = "0x23AF000", VA = "0x1823AFC00")]
	internal MLFENEIPCFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class HJGPGDLMJNL : ODNFECNHFOH
{
	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x23A6590", Offset = "0x23A5990", VA = "0x1823A6590")]
	internal HJGPGDLMJNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class FMEEBCENPEP : ODNFECNHFOH
{
	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x239A9E0", Offset = "0x2399DE0", VA = "0x18239A9E0")]
	internal FMEEBCENPEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class CKPOOLPOAGE : ODNFECNHFOH
{
	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x23970D0", Offset = "0x23964D0", VA = "0x1823970D0")]
	internal CKPOOLPOAGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class AKIOKHMCDBC : ODNFECNHFOH
{
	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x238FCB0", Offset = "0x238F0B0", VA = "0x18238FCB0")]
	internal AKIOKHMCDBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public class OKKNKPBIBNP : ODNFECNHFOH
{
	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x23B16D0", Offset = "0x23B0AD0", VA = "0x1823B16D0")]
	internal OKKNKPBIBNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public class OIHIEBNNJFM : ODNFECNHFOH
{
	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x23B14B0", Offset = "0x23B08B0", VA = "0x1823B14B0")]
	internal OIHIEBNNJFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public class HIEKICLNBII : ODNFECNHFOH
{
	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x23A5860", Offset = "0x23A4C60", VA = "0x1823A5860")]
	internal HIEKICLNBII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public class NHFKCCECCKB : ODNFECNHFOH
{
	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x23B04E0", Offset = "0x23AF8E0", VA = "0x1823B04E0")]
	internal NHFKCCECCKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public class GAPPPGAOEPA : ODNFECNHFOH
{
	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x239AE20", Offset = "0x239A220", VA = "0x18239AE20")]
	internal GAPPPGAOEPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public class KFLLHPGGBCK : ODNFECNHFOH
{
	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x23ADC60", Offset = "0x23AD060", VA = "0x1823ADC60")]
	internal KFLLHPGGBCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public class OOKFAJNJHBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private readonly Guid DCALPGDDJHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public readonly bool PMEFMCKBJKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public readonly bool IAIFCGIPAGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public readonly bool GCDOAIEPKDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private readonly List<(string Name, LHHDIPPKMNM Type)> ANDCBLHMEGI;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public Guid MCOMIPJPJOC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x21CC370", Offset = "0x21CB770", VA = "0x1821CC370")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public string ANHHJLAHIFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x823C10", Offset = "0x823010", VA = "0x180823C10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD60", Offset = "0x8BB160", VA = "0x1808BBD60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public IReadOnlyList<(string Name, LHHDIPPKMNM Type)> BDJLDDENBMC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x823B60", Offset = "0x822F60", VA = "0x180823B60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action MNKFJCICIJH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x23B1A30", Offset = "0x23B0E30", VA = "0x1823B1A30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x23B1E80", Offset = "0x23B1280", VA = "0x1823B1E80")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<string, LHHDIPPKMNM> FFLIDGHNDNG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x23B1F20", Offset = "0x23B1320", VA = "0x1823B1F20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x23B1990", Offset = "0x23B0D90", VA = "0x1823B1990")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<int> OHLDFHHJGJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x23B1AD0", Offset = "0x23B0ED0", VA = "0x1823B1AD0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x23B18F0", Offset = "0x23B0CF0", VA = "0x1823B18F0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action BKELLHANMDF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x23B1FC0", Offset = "0x23B13C0", VA = "0x1823B1FC0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x23B1BF0", Offset = "0x23B0FF0", VA = "0x1823B1BF0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x974A10", Offset = "0x973E10", VA = "0x180974A10")]
	public void PBCFIGOCOOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x23B20E0", Offset = "0x23B14E0", VA = "0x1823B20E0")]
	internal OOKFAJNJHBK(in Guid JNHCLKAAKHA, string GDKOBCHHFLB, bool LEOHGBOKHHM, bool OPNJHDELLPO, bool LFKAIOMHOBI, List<(string Name, LHHDIPPKMNM Type)> JMABDBFEBIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x23B1B70", Offset = "0x23B0F70", VA = "0x1823B1B70")]
	public static CHGLFDMCNHC DFBHDMGEPHB(string JNHCLKAAKHA, string GDKOBCHHFLB, bool LEOHGBOKHHM = false, bool OPNJHDELLPO = false, bool LFKAIOMHOBI = false)
	{
		return default(CHGLFDMCNHC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x23B1CF0", Offset = "0x23B10F0", VA = "0x1823B1CF0")]
	public static OOKFAJNJHBK JKBPDGNBBJF(in Guid JNHCLKAAKHA, string GDKOBCHHFLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x23B1C90", Offset = "0x23B1090", VA = "0x1823B1C90")]
	public void JEFABHMFFBE(string GDKOBCHHFLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x23B1DB0", Offset = "0x23B11B0", VA = "0x1823B1DB0")]
	public void KNLLHIHINBO(string GDKOBCHHFLB, LHHDIPPKMNM ADHABMPLAIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x23B2060", Offset = "0x23B1460", VA = "0x1823B2060")]
	public void NNAFAMKIKJB(int BNOAGGNAMKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public readonly struct JHICBIFNHLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly Guid DCALPGDDJHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private readonly string PDDGBIPPDAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private readonly bool PHIPHNPPKPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private readonly bool FKEKOAELHCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private readonly bool KILFJFMBJHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private readonly List<(string Name, LHHDIPPKMNM Type)> ANDCBLHMEGI;

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x23AC7F0", Offset = "0x23ABBF0", VA = "0x1823AC7F0")]
	public JHICBIFNHLJ(in Guid JNHCLKAAKHA, string GDKOBCHHFLB, bool LEOHGBOKHHM, bool OPNJHDELLPO, bool LFKAIOMHOBI, List<(string Name, LHHDIPPKMNM Type)> JMABDBFEBIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x23AC660", Offset = "0x23ABA60", VA = "0x1823AC660")]
	public JHICBIFNHLJ MGKCFBFDGBG(string GDKOBCHHFLB, LHHDIPPKMNM GANFKPHKNKH)
	{
		return default(JHICBIFNHLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x23AC740", Offset = "0x23ABB40", VA = "0x1823AC740")]
	public OOKFAJNJHBK NPJNKCPHLIJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public static class PDHGCFCDCIF
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public static class GMDCAPAMMGB
	{
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public static readonly OOKFAJNJHBK JBHACPBBOJP;

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public static readonly OOKFAJNJHBK GPOEGJKELFN;

		[Cpp2IlInjected.Token(Token = "0x4000132")]
		internal static readonly OOKFAJNJHBK[] IKOLLGJPEEK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public static class BABBEEGHHKK
	{
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public static readonly OOKFAJNJHBK OAGMCMCIJHJ;

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		internal static readonly OOKFAJNJHBK[] IKOLLGJPEEK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public static class FEPCEBPENGA
	{
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public static readonly OOKFAJNJHBK NPMGPCEFOBF;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public static readonly OOKFAJNJHBK KGKFOGNHHCO;

		[Cpp2IlInjected.Token(Token = "0x4000137")]
		internal static readonly OOKFAJNJHBK[] IKOLLGJPEEK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public static class NOMNADGLMFC
	{
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public static readonly OOKFAJNJHBK OCPKABOFAIJ;

		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public static readonly OOKFAJNJHBK ICEAEOFLFAH;

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		internal static readonly OOKFAJNJHBK[] IKOLLGJPEEK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public static class BHMHFCMBCNK
	{
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public static readonly OOKFAJNJHBK OMJFNMNPDMD;

		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public static readonly OOKFAJNJHBK IHPLLPAAIOB;

		[Cpp2IlInjected.Token(Token = "0x400013D")]
		internal static readonly OOKFAJNJHBK[] IKOLLGJPEEK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public static class IHGDIKGCHGO
	{
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public static readonly OOKFAJNJHBK NPMGPCEFOBF;

		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public static readonly OOKFAJNJHBK KGKFOGNHHCO;

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		internal static readonly OOKFAJNJHBK[] IKOLLGJPEEK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public static class CHKCJHKMIEM
	{
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static readonly OOKFAJNJHBK FFKCGKDCGBJ;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public static readonly OOKFAJNJHBK KJMINBLCEEF;

		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public static readonly OOKFAJNJHBK HKKFHJPFIOF;

		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public static readonly OOKFAJNJHBK DJDMPMBLIFA;

		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public static readonly OOKFAJNJHBK ECHOGJNBBKC;

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly OOKFAJNJHBK IDBFNNHCLOM;

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public static readonly OOKFAJNJHBK PNFOMOAFGCH;

		[Cpp2IlInjected.Token(Token = "0x4000148")]
		internal static readonly OOKFAJNJHBK[] IKOLLGJPEEK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public static class KIJNBFDPGPL
	{
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		internal static readonly OOKFAJNJHBK[] IKOLLGJPEEK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public static class CFMLMNJAJJO
	{
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		internal static readonly OOKFAJNJHBK[] IKOLLGJPEEK;
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public static class ILKBGFHKMPL
	{
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		internal static readonly OOKFAJNJHBK[] IKOLLGJPEEK;
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public static class HKCGACHNMCH
	{
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public static readonly OOKFAJNJHBK FMHCCPLFNJK;

		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public static readonly OOKFAJNJHBK COGFLFPFNFH;

		[Cpp2IlInjected.Token(Token = "0x400014E")]
		internal static readonly OOKFAJNJHBK[] IKOLLGJPEEK;
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public static class NICHOKCPHLK
	{
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		internal static readonly OOKFAJNJHBK[] IKOLLGJPEEK;
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public static class EFPBAJMCDPE
	{
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		internal static readonly OOKFAJNJHBK[] IKOLLGJPEEK;
	}

	[Cpp2IlInjected.Token(Token = "0x200009E")]
	public static class GHPGJFLAGFH
	{
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public static readonly OOKFAJNJHBK JACAMPPCEJF;

		[Cpp2IlInjected.Token(Token = "0x4000152")]
		internal static readonly OOKFAJNJHBK[] IKOLLGJPEEK;
	}

	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public static class ICMGBAKEANG
	{
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public static readonly OOKFAJNJHBK EIFMKCGGCOI;

		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public static readonly OOKFAJNJHBK HBDOLGNOEMP;

		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public static readonly OOKFAJNJHBK OMJFNMNPDMD;

		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public static readonly OOKFAJNJHBK FJABIJPLCDG;

		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public static readonly OOKFAJNJHBK BIBFLDKBFIN;

		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public static readonly OOKFAJNJHBK NBEFJDLBCMN;

		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public static readonly OOKFAJNJHBK CHDFJEFLPNN;

		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public static readonly OOKFAJNJHBK DNKBEDBMMIE;

		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public static readonly OOKFAJNJHBK GOFFIKPHOFA;

		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public static readonly OOKFAJNJHBK MDAPHIMGJDA;

		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public static readonly OOKFAJNJHBK FCIKEONHHNB;

		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public static readonly OOKFAJNJHBK CIPNOCJANIP;

		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public static readonly OOKFAJNJHBK FINKMDCAIHL;

		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public static readonly OOKFAJNJHBK JLGLBMNELEB;

		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public static readonly OOKFAJNJHBK IGLJEMNPINF;

		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public static readonly OOKFAJNJHBK IJMEOALHBEI;

		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public static readonly OOKFAJNJHBK OIGCADHNFEI;

		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public static readonly OOKFAJNJHBK PBLOAEKBKGO;

		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public static readonly OOKFAJNJHBK BKFCGHMLJJE;

		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public static readonly OOKFAJNJHBK JFFCCIMFNDI;

		[Cpp2IlInjected.Token(Token = "0x4000167")]
		internal static readonly OOKFAJNJHBK[] IKOLLGJPEEK;
	}

	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	public static class MOABKDKDIOM
	{
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		internal static readonly OOKFAJNJHBK[] IKOLLGJPEEK;
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public static class DPLKOPNDMLO
	{
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public static readonly OOKFAJNJHBK EIFMKCGGCOI;

		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public static readonly OOKFAJNJHBK NIBIBGBMOBP;

		[Cpp2IlInjected.Token(Token = "0x400016B")]
		internal static readonly OOKFAJNJHBK[] IKOLLGJPEEK;
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public static class ELODKOPGPDA
	{
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public static readonly OOKFAJNJHBK JJMOLNDAINH;

		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public static readonly OOKFAJNJHBK FIBGPCLFLMG;

		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public static readonly OOKFAJNJHBK JEGACICADPD;

		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public static readonly OOKFAJNJHBK IPABIFKIBFF;

		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public static readonly OOKFAJNJHBK NFGFONDNMBF;

		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public static readonly OOKFAJNJHBK IODJIFCMMJG;

		[Cpp2IlInjected.Token(Token = "0x4000172")]
		internal static readonly OOKFAJNJHBK[] IKOLLGJPEEK;
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public static class CJGBOLJNNNF
	{
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		internal static readonly OOKFAJNJHBK[] IKOLLGJPEEK;
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public static class MEAHELMAOFJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public static readonly OOKFAJNJHBK MIJEHPLGFCH;

		[Cpp2IlInjected.Token(Token = "0x4000175")]
		internal static readonly OOKFAJNJHBK[] IKOLLGJPEEK;
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public static class EEGJJKCNKJG
	{
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public static readonly OOKFAJNJHBK JACAMPPCEJF;

		[Cpp2IlInjected.Token(Token = "0x4000177")]
		internal static readonly OOKFAJNJHBK[] IKOLLGJPEEK;
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public static class CJKIJIOJBJJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		internal static readonly OOKFAJNJHBK[] IKOLLGJPEEK;
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public static class BMJJKEAJHGC
	{
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		internal static readonly OOKFAJNJHBK[] IKOLLGJPEEK;
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public static class MCNPFKPOFJO
	{
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public static readonly OOKFAJNJHBK IBPHEHJJDBM;

		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public static readonly OOKFAJNJHBK OPFHPPHNCCE;

		[Cpp2IlInjected.Token(Token = "0x400017C")]
		internal static readonly OOKFAJNJHBK[] IKOLLGJPEEK;
	}

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public static class ADIOHCDBNCC
	{
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		internal static readonly OOKFAJNJHBK[] IKOLLGJPEEK;
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public static class NBECHDHPILC
	{
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public static readonly OOKFAJNJHBK COAMICFPPIF;

		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public static readonly OOKFAJNJHBK BKKIOBPFAKG;

		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public static readonly OOKFAJNJHBK ILMKLODOKAH;

		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public static readonly OOKFAJNJHBK GJLLMLFCCKK;

		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public static readonly OOKFAJNJHBK LOBCKGMKKAP;

		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public static readonly OOKFAJNJHBK LDIJLMIKGAM;

		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public static readonly OOKFAJNJHBK PJCGEPLOGNK;

		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public static readonly OOKFAJNJHBK ILENILHKDEJ;

		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public static readonly OOKFAJNJHBK BFHLCBNGAND;

		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public static readonly OOKFAJNJHBK EBBAAMIBJKJ;

		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public static readonly OOKFAJNJHBK MDPPKFIOBMO;

		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public static readonly OOKFAJNJHBK DODJNFMPKBN;

		[Cpp2IlInjected.Token(Token = "0x400018A")]
		internal static readonly OOKFAJNJHBK[] IKOLLGJPEEK;
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public static class PFMOKLILNEF
	{
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		internal static readonly OOKFAJNJHBK[] IKOLLGJPEEK;
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	public static class GCPBEOOHNIA
	{
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public static readonly OOKFAJNJHBK JILCIBHHOGH;

		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public static readonly OOKFAJNJHBK LGPHLGICBOC;

		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public static readonly OOKFAJNJHBK EMBNOLEBMNH;

		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public static readonly OOKFAJNJHBK PAAFPLDHOGA;

		[Cpp2IlInjected.Token(Token = "0x4000190")]
		internal static readonly OOKFAJNJHBK[] IKOLLGJPEEK;
	}

	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	public static class FAOINEBNEAH
	{
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public static readonly OOKFAJNJHBK MDPPKFIOBMO;

		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public static readonly OOKFAJNJHBK DODJNFMPKBN;

		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public static readonly OOKFAJNJHBK MFIFBMMIEEN;

		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public static readonly OOKFAJNJHBK OLHIDMJECDL;

		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public static readonly OOKFAJNJHBK JBNNEKGPOGN;

		[Cpp2IlInjected.Token(Token = "0x4000196")]
		internal static readonly OOKFAJNJHBK[] IKOLLGJPEEK;
	}

	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	public static class CMBAIBKFDIF
	{
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		internal static readonly OOKFAJNJHBK[] IKOLLGJPEEK;
	}

	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	public static class LALJFOAILLM
	{
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public static readonly OOKFAJNJHBK FJMCGEENCGO;

		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public static readonly OOKFAJNJHBK LGNFOLCKBAP;

		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public static readonly OOKFAJNJHBK MDPPKFIOBMO;

		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public static readonly OOKFAJNJHBK DODJNFMPKBN;

		[Cpp2IlInjected.Token(Token = "0x400019C")]
		internal static readonly OOKFAJNJHBK[] IKOLLGJPEEK;
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	public static class OHLEDPLLFIA
	{
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		internal static readonly OOKFAJNJHBK[] IKOLLGJPEEK;
	}

	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	public static class JDILCGCBLPD
	{
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		internal static readonly OOKFAJNJHBK[] IKOLLGJPEEK;
	}

	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	public static class LEAEDLGOFDP
	{
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		internal static readonly OOKFAJNJHBK[] IKOLLGJPEEK;
	}

	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	public static class IKCPIBBIIHB
	{
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		internal static readonly OOKFAJNJHBK[] IKOLLGJPEEK;
	}

	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	public static class HBBLNCAJPFF
	{
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public static readonly OOKFAJNJHBK FMHCCPLFNJK;

		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public static readonly OOKFAJNJHBK COGFLFPFNFH;

		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		internal static readonly OOKFAJNJHBK[] IKOLLGJPEEK;
	}

	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public static class BDFILDDAPON
	{
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public static readonly OOKFAJNJHBK NDACKKJFOGB;

		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public static readonly OOKFAJNJHBK FIIPLNBGBFD;

		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public static readonly OOKFAJNJHBK FJLECMBEKMK;

		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public static readonly OOKFAJNJHBK NBHNMHAHLMO;

		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		internal static readonly OOKFAJNJHBK[] IKOLLGJPEEK;
	}

	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	public static class OMIAMHEFDNH
	{
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public static readonly OOKFAJNJHBK NDACKKJFOGB;

		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public static readonly OOKFAJNJHBK FIIPLNBGBFD;

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public static readonly OOKFAJNJHBK FJLECMBEKMK;

		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public static readonly OOKFAJNJHBK NBHNMHAHLMO;

		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		internal static readonly OOKFAJNJHBK[] IKOLLGJPEEK;
	}

	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	public static class KCMBAHCHNDL
	{
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		internal static readonly OOKFAJNJHBK[] IKOLLGJPEEK;
	}

	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public static class CDEAEBPEADE
	{
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public static readonly OOKFAJNJHBK HFMOGPJJBPL;

		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public static readonly OOKFAJNJHBK EBGHPOPMNLE;

		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public static readonly OOKFAJNJHBK HGGMHGBDDIB;

		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		internal static readonly OOKFAJNJHBK[] IKOLLGJPEEK;
	}

	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	public static class ILOCFEFFEPD
	{
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		internal static readonly OOKFAJNJHBK[] IKOLLGJPEEK;
	}

	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public static class KOBFPMHNCJF
	{
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public static readonly OOKFAJNJHBK CAGMKMKOOCL;

		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public static readonly OOKFAJNJHBK ECIONBHOIHI;

		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public static readonly OOKFAJNJHBK PPPJIFAAEDH;

		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		internal static readonly OOKFAJNJHBK[] IKOLLGJPEEK;
	}

	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	public static class PCOMKBPHFIC
	{
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public static readonly OOKFAJNJHBK EPKIIHNPOND;

		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		internal static readonly OOKFAJNJHBK[] IKOLLGJPEEK;
	}

	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	public static class EMCAIKNEBBL
	{
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public static readonly OOKFAJNJHBK DPMLODJMHBL;

		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public static readonly OOKFAJNJHBK JKHBPIFJNLF;

		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public static readonly OOKFAJNJHBK MCEGLIDHGLO;

		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		internal static readonly OOKFAJNJHBK[] IKOLLGJPEEK;
	}

	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	public static class EHPPOLHDFBH
	{
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		internal static readonly OOKFAJNJHBK[] IKOLLGJPEEK;
	}

	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	public static class ABMIOLIBOGN
	{
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		internal static readonly OOKFAJNJHBK[] IKOLLGJPEEK;
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
