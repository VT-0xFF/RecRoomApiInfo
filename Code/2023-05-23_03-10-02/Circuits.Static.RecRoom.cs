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
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80DE80", VA = "0x18080EA80")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x30D4A00", Offset = "0x30D3E00", VA = "0x1830D4A00")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x881BC0", Offset = "0x880FC0", VA = "0x180881BC0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD72FB0", Offset = "0xD723B0", VA = "0x180D72FB0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct MHNOJKKEDAD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct IOCJFDJCACL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public global::DKJMPNEPOKM<OEBIECDILIK> KBNKJBFBKBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public global::DKJMPNEPOKM<OEBIECDILIK> GCODCIHJOFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public global::DKJMPNEPOKM<OEBIECDILIK> ALKCNDHJNEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public global::DKJMPNEPOKM<OEBIECDILIK> JJCPLOKHGBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public global::DKJMPNEPOKM<OEBIECDILIK> BHDCHIHLGON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public global::DKJMPNEPOKM<OEBIECDILIK> OGPJDIMCCMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public global::DKJMPNEPOKM<OEBIECDILIK> CHOHAICBHLA;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x30C2730", Offset = "0x30C1B30", VA = "0x1830C2730")]
		public static IOCJFDJCACL FHHJOGLDILM(global::DBHMOOBNOBL<KAGFALJBAED> OIAILNCPEGI)
		{
			return default(IOCJFDJCACL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface KNJEMDIJBJO
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		AELPGPIBNFA KCMDHOIHBIB
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class NGBGAIMCJCB
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class DEBPHDAPBFG : IEnumerable<NDNLPFJBKCL>, IEnumerable, IEnumerator<NDNLPFJBKCL>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			private NDNLPFJBKCL <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			private bool includeBeta;

			[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public bool <>3__includeBeta;

			[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private bool includeStudio;

			[Cpp2IlInjected.FieldOffset(Offset = "0x27")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public bool <>3__includeStudio;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private bool isDeveloper;

			[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public bool <>3__isDeveloper;

			[Cpp2IlInjected.Token(Token = "0x17000049")]
			private NDNLPFJBKCL System.Collections.Generic.IEnumerator<Circuits.Static.Core.TypeSystem.CircuitType>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000063")]
				[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004A")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000065")]
				[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xB93C20", Offset = "0xB93020", VA = "0x180B93C20")]
			[DebuggerHidden]
			public DEBPHDAPBFG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x6F4A6D0", Offset = "0x6F49AD0", VA = "0x186F4A6D0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x6F4C7F0", Offset = "0x6F4BBF0", VA = "0x186F4C7F0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x6F4C740", Offset = "0x6F4BB40", VA = "0x186F4C740", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<NDNLPFJBKCL> System.Collections.Generic.IEnumerable<Circuits.Static.Core.TypeSystem.CircuitType>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x6F4C740", Offset = "0x6F4BB40", VA = "0x186F4C740", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class GFBBHNDBNOJ : IEnumerable<NDNLPFJBKCL>, IEnumerable, IEnumerator<NDNLPFJBKCL>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private NDNLPFJBKCL <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private bool includeBeta;

			[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public bool <>3__includeBeta;

			[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private bool includeStudio;

			[Cpp2IlInjected.FieldOffset(Offset = "0x27")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public bool <>3__includeStudio;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private bool isDeveloper;

			[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public bool <>3__isDeveloper;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private IEnumerator<NDNLPFJBKCL> <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private NDNLPFJBKCL <circuitType>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700004B")]
			private NDNLPFJBKCL System.Collections.Generic.IEnumerator<Circuits.Static.Core.TypeSystem.CircuitType>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600006C")]
				[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004C")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600006E")]
				[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xB93C20", Offset = "0xB93020", VA = "0x180B93C20")]
			[DebuggerHidden]
			public GFBBHNDBNOJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x6F4E3F0", Offset = "0x6F4D7F0", VA = "0x186F4E3F0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x6F4DF40", Offset = "0x6F4D340", VA = "0x186F4DF40", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x6F4DE80", Offset = "0x6F4D280", VA = "0x186F4DE80")]
			private void DJGMDMALOCK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x6F4E3B0", Offset = "0x6F4D7B0", VA = "0x186F4E3B0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x6F4E300", Offset = "0x6F4D700", VA = "0x186F4E300", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<NDNLPFJBKCL> System.Collections.Generic.IEnumerable<Circuits.Static.Core.TypeSystem.CircuitType>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x6F4E300", Offset = "0x6F4D700", VA = "0x186F4E300", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public static readonly MAFANCGBPNE DOKCPMOIBHI;

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public static readonly MAFANCGBPNE JGKBBAEEOCD;

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static readonly HashSet<NDNLPFJBKCL> GAIBJCNBOAF;

		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public static List<NDNLPFJBKCL> OMBIGJCABNE;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static IIFEGNIOMLI AINBKCAPJPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x90E300", Offset = "0x90D700", VA = "0x18090E300")]
			get
			{
				return default(IIFEGNIOMLI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static NDNLPFJBKCL DMHFMJCIKHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x30CCE00", Offset = "0x30CC200", VA = "0x1830CCE00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static NDNLPFJBKCL LILKINBNDBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x30CDB30", Offset = "0x30CCF30", VA = "0x1830CDB30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static NDNLPFJBKCL DOFEGPMFKAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x30CEB50", Offset = "0x30CDF50", VA = "0x1830CEB50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static NDNLPFJBKCL EBLJEPLIBHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x30CE270", Offset = "0x30CD670", VA = "0x1830CE270")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static NDNLPFJBKCL EEAEBDCHLMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x30CEF00", Offset = "0x30CE300", VA = "0x1830CEF00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static NDNLPFJBKCL GDGNGBCJIEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x30CE630", Offset = "0x30CDA30", VA = "0x1830CE630")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static NDNLPFJBKCL GFOFCDHCCPI
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x30CE490", Offset = "0x30CD890", VA = "0x1830CE490")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static NDNLPFJBKCL AONOEGFHMNG
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x30CCBB0", Offset = "0x30CBFB0", VA = "0x1830CCBB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static DADLAOKLBMN LNCLBEBKFLC
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x30CE970", Offset = "0x30CDD70", VA = "0x1830CE970")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static DADLAOKLBMN HCACKILAAMP
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x30CD740", Offset = "0x30CCB40", VA = "0x1830CD740")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static DADLAOKLBMN NHNOFOHFFBE
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x30CE6D0", Offset = "0x30CDAD0", VA = "0x1830CE6D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static DADLAOKLBMN DADPMICNDEO
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x30CE910", Offset = "0x30CDD10", VA = "0x1830CE910")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static DADLAOKLBMN DKANAODDODA
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x30CD860", Offset = "0x30CCC60", VA = "0x1830CD860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static DADLAOKLBMN DLBGKDKPJFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x30CD8C0", Offset = "0x30CCCC0", VA = "0x1830CD8C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static DADLAOKLBMN LLBBEECPHJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x30CEC50", Offset = "0x30CE050", VA = "0x1830CEC50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static DADLAOKLBMN HAOFLGLEDIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x30CEA30", Offset = "0x30CDE30", VA = "0x1830CEA30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static DADLAOKLBMN LCLFDHCOEDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x30CEA90", Offset = "0x30CDE90", VA = "0x1830CEA90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static DADLAOKLBMN DIODJEOKFOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x30CDF80", Offset = "0x30CD380", VA = "0x1830CDF80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static DADLAOKLBMN BFGFFODKKGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x30CD680", Offset = "0x30CCA80", VA = "0x1830CD680")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static DADLAOKLBMN DNMGKGADPLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x30CE370", Offset = "0x30CD770", VA = "0x1830CE370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static DADLAOKLBMN FBPGFPINMIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x30CD2C0", Offset = "0x30CC6C0", VA = "0x1830CD2C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static DADLAOKLBMN OEMCNLHPNIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x30CCF00", Offset = "0x30CC300", VA = "0x1830CCF00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static DADLAOKLBMN PFEDEAHOJBJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x30CEBF0", Offset = "0x30CDFF0", VA = "0x1830CEBF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static DADLAOKLBMN DAHMGEILAGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x30CD080", Offset = "0x30CC480", VA = "0x1830CD080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static DADLAOKLBMN LJGKNPPCIOC
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x30CCD40", Offset = "0x30CC140", VA = "0x1830CCD40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static DADLAOKLBMN ADBKAFLAFLM
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x30CEFA0", Offset = "0x30CE3A0", VA = "0x1830CEFA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static DADLAOKLBMN EIMMMEFKLDE
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x30CD200", Offset = "0x30CC600", VA = "0x1830CD200")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public static DADLAOKLBMN POGDMKFAACI
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x30CE9D0", Offset = "0x30CDDD0", VA = "0x1830CE9D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public static DADLAOKLBMN CKIEFJCEKPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x30CEAF0", Offset = "0x30CDEF0", VA = "0x1830CEAF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public static DADLAOKLBMN OMPMHIDGFLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x30CE7F0", Offset = "0x30CDBF0", VA = "0x1830CE7F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public static DADLAOKLBMN LOMOKFPCJJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x30CDFE0", Offset = "0x30CD3E0", VA = "0x1830CDFE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public static DADLAOKLBMN PLEFMODENKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x30CD1A0", Offset = "0x30CC5A0", VA = "0x1830CD1A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public static DADLAOKLBMN GEDKICDILAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x30CCDA0", Offset = "0x30CC1A0", VA = "0x1830CCDA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public static DADLAOKLBMN EEHIFPDBHDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x30CDBD0", Offset = "0x30CCFD0", VA = "0x1830CDBD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public static DADLAOKLBMN GOCEADLLHLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x30CD9B0", Offset = "0x30CCDB0", VA = "0x1830CD9B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public static DADLAOKLBMN LAHGECBBPGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x30CDCC0", Offset = "0x30CD0C0", VA = "0x1830CDCC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public static DADLAOKLBMN KIADDALJKIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x30CE310", Offset = "0x30CD710", VA = "0x1830CE310")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public static DADLAOKLBMN PJMMCCCGMDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x30CDEC0", Offset = "0x30CD2C0", VA = "0x1830CDEC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public static DADLAOKLBMN DJLOPFFDJID
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x30CE730", Offset = "0x30CDB30", VA = "0x1830CE730")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public static DADLAOKLBMN NLELJAKCNKE
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x30CCC50", Offset = "0x30CC050", VA = "0x1830CCC50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public static DADLAOKLBMN MDOKDKFNIMA
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x30CCEA0", Offset = "0x30CC2A0", VA = "0x1830CCEA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public static DADLAOKLBMN FJHFGFMNFDA
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x30CDA70", Offset = "0x30CCE70", VA = "0x1830CDA70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public static DADLAOKLBMN LPEPAOIGJLP
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x30CDE60", Offset = "0x30CD260", VA = "0x1830CDE60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public static DADLAOKLBMN FDGLEDFNELD
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x30CD0E0", Offset = "0x30CC4E0", VA = "0x1830CD0E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public static DADLAOKLBMN OPJIHKOFBND
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x30CE3D0", Offset = "0x30CD7D0", VA = "0x1830CE3D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public static DADLAOKLBMN CDCNICEGLIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x30CEEA0", Offset = "0x30CE2A0", VA = "0x1830CEEA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public static DADLAOKLBMN FBOCOICODOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x30CE8B0", Offset = "0x30CDCB0", VA = "0x1830CE8B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public static DADLAOKLBMN JDNEHEINCJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x30CD260", Offset = "0x30CC660", VA = "0x1830CD260")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public static DADLAOKLBMN DEEHLKKEIEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x30CD920", Offset = "0x30CCD20", VA = "0x1830CD920")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public static DADLAOKLBMN OJCCOLMJBOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x30CD5C0", Offset = "0x30CC9C0", VA = "0x1830CD5C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public static DADLAOKLBMN MBBLJHHPNMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x30CECB0", Offset = "0x30CE0B0", VA = "0x1830CECB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public static DADLAOKLBMN JLNGDMMILCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x30CD7A0", Offset = "0x30CCBA0", VA = "0x1830CD7A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public static DADLAOKLBMN GEDIEBAOILD
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x30CD560", Offset = "0x30CC960", VA = "0x1830CD560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public static DADLAOKLBMN JLNAGCNPIBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x30CDF20", Offset = "0x30CD320", VA = "0x1830CDF20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public static DADLAOKLBMN DFIOGFMOIOC
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x30CD320", Offset = "0x30CC720", VA = "0x1830CD320")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public static DADLAOKLBMN HHHAJMGPJJE
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x30CDC30", Offset = "0x30CD030", VA = "0x1830CDC30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public static DADLAOKLBMN GBOIOMLAMKA
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x30CEDB0", Offset = "0x30CE1B0", VA = "0x1830CEDB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public static DADLAOKLBMN LJICEIHPLPC
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x30CD140", Offset = "0x30CC540", VA = "0x1830CD140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public static DADLAOKLBMN EHFNMMNMNGG
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x30CD020", Offset = "0x30CC420", VA = "0x1830CD020")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public static DADLAOKLBMN CPGDMEEKBLH
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x30CDE00", Offset = "0x30CD200", VA = "0x1830CDE00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public static DADLAOKLBMN EDBOMEINCFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x30CD800", Offset = "0x30CCC00", VA = "0x1830CD800")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public static DADLAOKLBMN CEABNLDBOLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x30CD6E0", Offset = "0x30CCAE0", VA = "0x1830CD6E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public static DADLAOKLBMN PLEHKJMALFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x30CD620", Offset = "0x30CCA20", VA = "0x1830CD620")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public static DADLAOKLBMN NOJAJMMHLBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x30CE430", Offset = "0x30CD830", VA = "0x1830CE430")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public static DADLAOKLBMN GHMINAMKKDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x30CDAD0", Offset = "0x30CCED0", VA = "0x1830CDAD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public static DADLAOKLBMN FMKIOINNBMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x30CDA10", Offset = "0x30CCE10", VA = "0x1830CDA10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public static DADLAOKLBMN NLBNBKIEEJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x30CCFC0", Offset = "0x30CC3C0", VA = "0x1830CCFC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public static DADLAOKLBMN GJIBAEENHHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x30CCF60", Offset = "0x30CC360", VA = "0x1830CCF60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public static DADLAOKLBMN FELNHNBDKAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x30CE790", Offset = "0x30CDB90", VA = "0x1830CE790")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public static DADLAOKLBMN JONBNBJAPJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x30CE850", Offset = "0x30CDC50", VA = "0x1830CE850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x30CE530", Offset = "0x30CD930", VA = "0x1830CE530")]
		public static MAFANCGBPNE MOPPFEHFMHC(in NNACJHLGDJK LJGBEBBNHLC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x30CDD50", Offset = "0x30CD150", VA = "0x1830CDD50")]
		public static DDAPOKMCOLA KBOPNOOMBDB(string IDFOGLKIIHM, [Optional] string LMAOKJPAKEM)
		{
			return default(DDAPOKMCOLA);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x30CDD20", Offset = "0x30CD120", VA = "0x1830CDD20")]
		public static DDAPOKMCOLA KBOPNOOMBDB([Optional] in Guid? IDFOGLKIIHM, [Optional] string LMAOKJPAKEM)
		{
			return default(DDAPOKMCOLA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x30CDC90", Offset = "0x30CD090", VA = "0x1830CDC90")]
		public static MAFANCGBPNE JGILDAHEJLE(params NNACJHLGDJK[] FKOMPPKIBLI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x30CD980", Offset = "0x30CCD80", VA = "0x1830CD980")]
		public static MAFANCGBPNE IBADNEHCICF(params NNACJHLGDJK[] FKOMPPKIBLI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x30CD410", Offset = "0x30CC810", VA = "0x1830CD410")]
		public static MAFANCGBPNE FKFNLOJOKIN(in NNACJHLGDJK LJGBEBBNHLC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x30CF000", Offset = "0x30CE400", VA = "0x1830CF000")]
		static NGBGAIMCJCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x30CCCB0", Offset = "0x30CC0B0", VA = "0x1830CCCB0")]
		[IteratorStateMachine(typeof(DEBPHDAPBFG))]
		private static IEnumerable<NDNLPFJBKCL> AKIKIFCKEJB(bool OBMIOLKHLGB, bool JMJONEODMNH, bool GENOPCFAGEE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x30CEE10", Offset = "0x30CE210", VA = "0x1830CEE10")]
		[IteratorStateMachine(typeof(GFBBHNDBNOJ))]
		public static IEnumerable<NDNLPFJBKCL> PLFEFJPNDIK(bool OBMIOLKHLGB, bool JMJONEODMNH, bool GENOPCFAGEE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x30CE040", Offset = "0x30CD440", VA = "0x1830CE040")]
		public static AMPFOPBHEND LJJPDEAKPKC(NDNLPFJBKCL ONBHBHIHHNE)
		{
			return default(AMPFOPBHEND);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x30CED10", Offset = "0x30CE110", VA = "0x1830CED10")]
		public static AMPFOPBHEND PFALFMLEENP(NDNLPFJBKCL ONBHBHIHHNE)
		{
			return default(AMPFOPBHEND);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x30CD380", Offset = "0x30CC780", VA = "0x1830CD380")]
		public static bool FIMLDFMCDLJ(NDNLPFJBKCL ONBHBHIHHNE)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct FPKIIOJLLOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public global::DKJMPNEPOKM<FCHPMFCBLNP> FDOCOAJCACK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public global::DKJMPNEPOKM<FCHPMFCBLNP> BOIDKKAFBEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public global::DKJMPNEPOKM<FCHPMFCBLNP> KNINLEDKFKM;

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x30BE950", Offset = "0x30BDD50", VA = "0x1830BE950")]
		public static FPKIIOJLLOP FHHJOGLDILM(OHHPMNDEIND OIAILNCPEGI, AELPGPIBNFA DNINMLCHLPM)
		{
			return default(FPKIIOJLLOP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public readonly struct BJAPILFIPKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private readonly EMBBJIAKJBO DNKNCEJNBHM;

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xB8F880", Offset = "0xB8EC80", VA = "0x180B8F880")]
		public BJAPILFIPKP(EMBBJIAKJBO BHBNOIGCMCM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class BPGAPDENFJN
	{
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static Dictionary<global::DKJMPNEPOKM<JIELJAJALEO>, EHCEMGKDEHB> HLPJOJOBEGH;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public static readonly global::DKJMPNEPOKM<JIELJAJALEO> AMDFEIFOGIH;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public static readonly global::DKJMPNEPOKM<JIELJAJALEO> FFHLLJHAOEJ;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public static readonly global::DKJMPNEPOKM<JIELJAJALEO> IKPDPEACLOA;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public static readonly global::DKJMPNEPOKM<JIELJAJALEO> OCDJGAJPIIE;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public static readonly global::DKJMPNEPOKM<JIELJAJALEO> OCCOLIGBAKN;

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public static readonly global::DKJMPNEPOKM<JIELJAJALEO> HLOLMFEGAPC;

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static readonly global::DKJMPNEPOKM<JIELJAJALEO> OIOMMCNILGP;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public static readonly global::DKJMPNEPOKM<JIELJAJALEO> KNEPDPKPFBI;

		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public static readonly global::DKJMPNEPOKM<JIELJAJALEO> EIANAFJDGDN;

		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public static readonly global::DKJMPNEPOKM<JIELJAJALEO> LIHJODBIFFM;

		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public static readonly global::DKJMPNEPOKM<JIELJAJALEO> AAJEIFJFLIE;

		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public static readonly global::DKJMPNEPOKM<JIELJAJALEO> APDNMAOBOCD;

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public static readonly global::DKJMPNEPOKM<JIELJAJALEO> MMIDMILFHGC;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public static readonly global::DKJMPNEPOKM<JIELJAJALEO> CIFAJPIPHPL;

		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public static readonly global::DKJMPNEPOKM<JIELJAJALEO> HAKPKEBOMLI;

		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public static readonly global::DKJMPNEPOKM<JIELJAJALEO> DCODCDJELGC;

		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly global::DKJMPNEPOKM<JIELJAJALEO> FHIKKJLNDEN;

		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public static readonly global::DKJMPNEPOKM<JIELJAJALEO> DENFADDBJBK;

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public static readonly global::DKJMPNEPOKM<JIELJAJALEO> NBNDKFHHDNH;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public static readonly global::DKJMPNEPOKM<JIELJAJALEO> DNKHBJGOPFJ;

		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public static readonly global::DKJMPNEPOKM<JIELJAJALEO> LLFFMLMLOHM;

		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly global::DKJMPNEPOKM<JIELJAJALEO> FKMEHIBPFLB;

		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public static readonly global::DKJMPNEPOKM<JIELJAJALEO> MGKKINCCAKL;

		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public static readonly global::DKJMPNEPOKM<JIELJAJALEO> PHBAMGGNKCB;

		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public static readonly global::DKJMPNEPOKM<JIELJAJALEO> GJAAEMKNDGA;

		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public static readonly global::DKJMPNEPOKM<JIELJAJALEO> DFHBLHBJBKA;

		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public static readonly global::DKJMPNEPOKM<JIELJAJALEO> EKGCNIOJLKF;

		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public static readonly global::DKJMPNEPOKM<JIELJAJALEO> DDKOIDHHHOP;

		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public static readonly global::DKJMPNEPOKM<JIELJAJALEO> HMBDJEGDOJI;

		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public static readonly global::DKJMPNEPOKM<JIELJAJALEO> MOMACNONKOB;

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public static readonly global::DKJMPNEPOKM<JIELJAJALEO> DPKHHFEAKCC;

		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly global::DKJMPNEPOKM<JIELJAJALEO> BPNCHOGEFCF;

		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public static readonly global::DKJMPNEPOKM<JIELJAJALEO> EDDJPGDFOHH;

		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public static readonly global::DKJMPNEPOKM<JIELJAJALEO> KPHBKJDKFCK;

		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public static readonly global::DKJMPNEPOKM<JIELJAJALEO> OIHHODFEJGI;

		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public static readonly global::DKJMPNEPOKM<JIELJAJALEO> KFCCOHACKDP;

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly global::DKJMPNEPOKM<JIELJAJALEO> CBKNCNJFBNN;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public static readonly global::DKJMPNEPOKM<JIELJAJALEO> FOAEFMPEALO;

		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public static readonly global::DKJMPNEPOKM<JIELJAJALEO> OOGBNCGHPJK;

		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public static readonly global::DKJMPNEPOKM<JIELJAJALEO> OFJCNDKMMGN;

		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public static readonly global::DKJMPNEPOKM<JIELJAJALEO> GOCEEBMMIFF;

		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public static readonly global::DKJMPNEPOKM<JIELJAJALEO> JBIKIIDCDGN;

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public static readonly global::DKJMPNEPOKM<JIELJAJALEO> OBPHIBDCOCJ;

		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public static readonly global::DKJMPNEPOKM<JIELJAJALEO> KCOCJLFKFBN;

		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public static readonly global::DKJMPNEPOKM<JIELJAJALEO> ACFEMLMDIJJ;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x30B87D0", Offset = "0x30B7BD0", VA = "0x1830B87D0")]
		public static EHCEMGKDEHB IOCELHBBBOO(global::DKJMPNEPOKM<JIELJAJALEO> IDFOGLKIIHM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x30B8740", Offset = "0x30B7B40", VA = "0x1830B8740")]
		public static bool IJLNPFGJBLJ(global::DKJMPNEPOKM<JIELJAJALEO> IDFOGLKIIHM, out EHCEMGKDEHB HBEFGHIJJKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x30B8670", Offset = "0x30B7A70", VA = "0x1830B8670")]
		public static NDNLPFJBKCL ECGLMHGBKIH(global::DKJMPNEPOKM<JIELJAJALEO> IDFOGLKIIHM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x30B8850", Offset = "0x30B7C50", VA = "0x1830B8850")]
		private static global::DKJMPNEPOKM<JIELJAJALEO> KJCLACJNMFM(EHCEMGKDEHB HBEFGHIJJKK, global::DKJMPNEPOKM<JIELJAJALEO> IDFOGLKIIHM)
		{
			return default(global::DKJMPNEPOKM<JIELJAJALEO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct PPELJEEKLDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public global::DKJMPNEPOKM<DMFPICMKCKE> PIBKPFGNKMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public global::DKJMPNEPOKM<DMFPICMKCKE> NLMJIEGGEGH;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x30D6970", Offset = "0x30D5D70", VA = "0x1830D6970")]
		public static PPELJEEKLDB FHHJOGLDILM(global::CMBAPLHJMKN<KAGFALJBAED> OIAILNCPEGI)
		{
			return default(PPELJEEKLDB);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly IOCJFDJCACL DJGBPALDJLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly PPELJEEKLDB HCAKBNBFCNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly FPKIIOJLLOP MAKPHAFNMGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly global::GKKHFKOPIFH<OEBIECDILIK, global::APEEILNOENF<KAGFALJBAED>> JFIHEKKCBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly global::GKKHFKOPIFH<DMFPICMKCKE, global::HLGHDPCKOCA<KAGFALJBAED>> ILMOLCJFNJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly global::GKKHFKOPIFH<FCHPMFCBLNP, MHCEBELAHHC> NEBJOCBHDNI;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x30CBE30", Offset = "0x30CB230", VA = "0x1830CBE30")]
	private MHNOJKKEDAD(in IOCJFDJCACL EKAGFLBNHEK, in PPELJEEKLDB JAEBCBCBGKD, in FPKIIOJLLOP ECONCIOOHLL, global::GKKHFKOPIFH<OEBIECDILIK, global::APEEILNOENF<KAGFALJBAED>> NKLJIFCPJAP, global::GKKHFKOPIFH<DMFPICMKCKE, global::HLGHDPCKOCA<KAGFALJBAED>> DJFDPDIMLFL, global::GKKHFKOPIFH<FCHPMFCBLNP, MHCEBELAHHC> KOIBPGMFMJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x30CB910", Offset = "0x30CAD10", VA = "0x1830CB910")]
	public static MHNOJKKEDAD FHHJOGLDILM(KNJEMDIJBJO DNINMLCHLPM)
	{
		return default(MHNOJKKEDAD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x30CB600", Offset = "0x30CAA00", VA = "0x1830CB600")]
	public static void BEBNHAAGHMI(in MHNOJKKEDAD LGKAJJKAMAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x30CB900", Offset = "0x30CAD00", VA = "0x1830CB900", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x30CBD60", Offset = "0x30CB160", VA = "0x1830CBD60")]
	public static global::FEGAMGKJJBA<KAGFALJBAED> JMCFBHEFOOB(in MHNOJKKEDAD LGKAJJKAMAG, in IMHIAJECALG GGJGGEPNCLG, in NHNNCCICGMJ FHKMGNMOLKI)
	{
		return default(global::FEGAMGKJJBA<KAGFALJBAED>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x30C42F0", Offset = "0x30C36F0", VA = "0x1830C42F0")]
	public static KAGFALJBAED KCGMJHJBNII(in MHNOJKKEDAD LGKAJJKAMAG, in HLLCAGOLPED CKPFKOOOBHL, in global::FEGAMGKJJBA<KAGFALJBAED> PIOOALFEPLN, in CCILCKLDIPM BGHEEABHHLM, global::DKJMPNEPOKM<OCKONIONONG> MIFEGFCPBIJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class AOBMAOINDHI
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x30B7690", Offset = "0x30B6A90", VA = "0x1830B7690")]
	public static bool BKBKMENFKDJ(this NDNLPFJBKCL ONBHBHIHHNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x30B77C0", Offset = "0x30B6BC0", VA = "0x1830B77C0")]
	public static bool BKBKMENFKDJ(this MAFANCGBPNE FIMKBJBKKFC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class OICCMBNAHMG
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x32818A0", Offset = "0x3280CA0", VA = "0x1832818A0")]
	public static global::OPOCCGAEPPD<JAFJIJEKPPM, AEPBDBDMJFD, TRoot, GAJAJBDGAFG> LIMBOOOKNOD<TRoot>(this in global::OPOCCGAEPPD<JAFJIJEKPPM, AEPBDBDMJFD, TRoot, GAJAJBDGAFG> GHMIIFNFBGF) where TRoot : ELAHBOFNDJG
	{
		return default(global::OPOCCGAEPPD<JAFJIJEKPPM, AEPBDBDMJFD, TRoot, GAJAJBDGAFG>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface ELAHBOFNDJG
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	PDMAENCNLGP? HKDNGEAEOND
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal static class DDMNOPFPKCC
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x30BB1C0", Offset = "0x30BA5C0", VA = "0x1830BB1C0")]
	internal static KAGFALJBAED HKDNGEAEOND(this ELAHBOFNDJG LGKAJJKAMAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x30BB2B0", Offset = "0x30BA6B0", VA = "0x1830BB2B0")]
	internal static global::EJIEKPGJGCC<KAGFALJBAED, IMCMNBDPHDC> NEPLJAPNNNP(this ELAHBOFNDJG LGKAJJKAMAG)
	{
		return default(global::EJIEKPGJGCC<KAGFALJBAED, IMCMNBDPHDC>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public readonly struct PDMAENCNLGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	internal readonly KAGFALJBAED HKDNGEAEOND;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0xB8F880", Offset = "0xB8EC80", VA = "0x180B8F880")]
	public PDMAENCNLGP(KAGFALJBAED OJEHKNBOPJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class KAGFALJBAED : FJEICNHIMMO, global::LNPGBMLPKIM<KAGFALJBAED>, HDGMMLDJGID, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public readonly MHNOJKKEDAD LECAMOALBMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private HLLCAGOLPED JLAHNCNPBBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private global::FEGAMGKJJBA<KAGFALJBAED> KJKELEPAOPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private CCILCKLDIPM LOCLHALLONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly global::DKJMPNEPOKM<OCKONIONONG> HONONHDCOOC;

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x30C7210", Offset = "0x30C6610", VA = "0x1830C7210")]
	private KAGFALJBAED(in MHNOJKKEDAD JPHONJHNLOL, in HLLCAGOLPED OLOOEJNPPOG, in global::FEGAMGKJJBA<KAGFALJBAED> PIOOALFEPLN, in CCILCKLDIPM BGHEEABHHLM, global::DKJMPNEPOKM<OCKONIONONG> ABAKCNELOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x30C42F0", Offset = "0x30C36F0", VA = "0x1830C42F0")]
	public static KAGFALJBAED BLNNEJAOMLE(in MHNOJKKEDAD JPHONJHNLOL, in HLLCAGOLPED OLOOEJNPPOG, in global::FEGAMGKJJBA<KAGFALJBAED> PIOOALFEPLN, in CCILCKLDIPM BGHEEABHHLM, global::DKJMPNEPOKM<OCKONIONONG> ABAKCNELOKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x30C47D0", Offset = "0x30C3BD0", VA = "0x1830C47D0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x30C42E0", Offset = "0x30C36E0", VA = "0x1830C42E0", Slot = "8")]
	public global::FEGAMGKJJBA<KAGFALJBAED> BIAALNGHKEN()
	{
		return default(global::FEGAMGKJJBA<KAGFALJBAED>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x30C5E40", Offset = "0x30C5240", VA = "0x1830C5E40")]
	public HLLCAGOLPED KOFPMKKOJJH()
	{
		return default(HLLCAGOLPED);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2CF8570", Offset = "0x2CF7970", VA = "0x182CF8570")]
	public global::DKJMPNEPOKM<TMVirt> KDEMGFJFBBD<TMVirt>(global::DKJMPNEPOKM<OCKONIONONG> KCFOMBLHMHL) where TMVirt : LDAMCDBCAOD.IDCCOIHGNGD
	{
		return default(global::DKJMPNEPOKM<TMVirt>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2CF87B0", Offset = "0x2CF7BB0", VA = "0x182CF87B0")]
	public global::DKJMPNEPOKM<TMVirt> NPNDFBNKEEE<TMVirt>(global::DKJMPNEPOKM<OCKONIONONG> KCFOMBLHMHL, global::DKJMPNEPOKM<OKMKFAGHJMD> APJCGFNBKKN) where TMVirt : AHFKNOPHOCE.MGBBAKOIECA
	{
		return default(global::DKJMPNEPOKM<TMVirt>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x30C6860", Offset = "0x30C5C60", VA = "0x1830C6860")]
	internal IMHIAJECALG OGIBNKCJAGG()
	{
		return default(IMHIAJECALG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x30C6820", Offset = "0x30C5C20", VA = "0x1830C6820")]
	internal NHNNCCICGMJ ODEJICCKDED()
	{
		return default(NHNNCCICGMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x30C42E0", Offset = "0x30C36E0", VA = "0x1830C42E0")]
	internal global::FEGAMGKJJBA<KAGFALJBAED> DCIAIHFGJKO()
	{
		return default(global::FEGAMGKJJBA<KAGFALJBAED>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x30C5E40", Offset = "0x30C5240", VA = "0x1830C5E40")]
	internal HLLCAGOLPED PMDIJNCDCJI()
	{
		return default(HLLCAGOLPED);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x30C5C10", Offset = "0x30C5010", VA = "0x1830C5C10")]
	internal CCILCKLDIPM JOLHDOGPFBA()
	{
		return default(CCILCKLDIPM);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2CF8850", Offset = "0x2CF7C50", VA = "0x182CF8850")]
	public void ODCCCKNNJIC<TMVirt>(global::DKJMPNEPOKM<OCKONIONONG> KCFOMBLHMHL, global::DKJMPNEPOKM<TMVirt> HDOEOMAEKKB) where TMVirt : LDAMCDBCAOD.IDCCOIHGNGD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2CF8340", Offset = "0x2CF7740", VA = "0x182CF8340")]
	public void FJJEGPBEBMD<TMVirt>(global::DKJMPNEPOKM<OCKONIONONG> KCFOMBLHMHL, global::DKJMPNEPOKM<OKMKFAGHJMD> APJCGFNBKKN, global::DKJMPNEPOKM<TMVirt> HDOEOMAEKKB) where TMVirt : AHFKNOPHOCE.MGBBAKOIECA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x30C6970", Offset = "0x30C5D70", VA = "0x1830C6970", Slot = "9")]
	public LEBHPFKIBBD PCIDMFHKJKH()
	{
		return default(LEBHPFKIBBD);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x30C5DC0", Offset = "0x30C51C0", VA = "0x1830C5DC0", Slot = "10")]
	public AMPFOPBHEND KFDFDMCOCGA(NDNLPFJBKCL ONBHBHIHHNE)
	{
		return default(AMPFOPBHEND);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x30C5E50", Offset = "0x30C5250", VA = "0x1830C5E50", Slot = "11")]
	public bool LPLENILMCGN(NDNLPFJBKCL ONBHBHIHHNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x30C68A0", Offset = "0x30C5CA0", VA = "0x1830C68A0", Slot = "4")]
	private void OOFILIMJEBK(global::DKJMPNEPOKM<OCKONIONONG> KCFOMBLHMHL, global::DKJMPNEPOKM<OKMKFAGHJMD> APJCGFNBKKN, ref IPNMOJMODML GFNGCDOBHLO, global::DKJMPNEPOKM<FLNBNCMIPDD.AKEOEMFDKLF>? JJDHDIBCHME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x30C4850", Offset = "0x30C3C50", VA = "0x1830C4850", Slot = "5")]
	private void GDHPCPOGKMC(global::DKJMPNEPOKM<OCKONIONONG> KCFOMBLHMHL, global::DKJMPNEPOKM<OKMKFAGHJMD> APJCGFNBKKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x30C5AB0", Offset = "0x30C4EB0", VA = "0x1830C5AB0", Slot = "6")]
	private void ICLLIJLDCAP(global::DKJMPNEPOKM<OCKONIONONG> KCFOMBLHMHL, ref IPNMOJMODML GFNGCDOBHLO, global::DKJMPNEPOKM<FLNBNCMIPDD.AKEOEMFDKLF>? JJDHDIBCHME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x30C6730", Offset = "0x30C5B30", VA = "0x1830C6730", Slot = "7")]
	private void NNEDFIPDEAH(global::DKJMPNEPOKM<OCKONIONONG> KCFOMBLHMHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x30C5C20", Offset = "0x30C5020", VA = "0x1830C5C20")]
	internal global::EJIEKPGJGCC<global::DKJMPNEPOKM<OKMKFAGHJMD>, LCEIFOGDJKI> KBNKJBFBKBK(global::DKJMPNEPOKM<OCKONIONONG> KCFOMBLHMHL, global::DKJMPNEPOKM<OEBIECDILIK> ODKMKIEJBGL, in OBHBJAMPCFH NADLKJKLONK, in PGFGIJOBBDI OGPILFJIIKI, ref IPNMOJMODML GLGKCCLGLKL, global::DKJMPNEPOKM<FLNBNCMIPDD.AKEOEMFDKLF>? BMBJFIABMFL)
	{
		return default(global::EJIEKPGJGCC<global::DKJMPNEPOKM<OKMKFAGHJMD>, LCEIFOGDJKI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x30C59B0", Offset = "0x30C4DB0", VA = "0x1830C59B0")]
	internal global::DKJMPNEPOKM<OKMKFAGHJMD> HJAFDAKFGHO(global::DKJMPNEPOKM<OCKONIONONG> KCFOMBLHMHL, global::DKJMPNEPOKM<OEBIECDILIK> ODKMKIEJBGL, in OBHBJAMPCFH NADLKJKLONK, in PGFGIJOBBDI OGPILFJIIKI, ref IPNMOJMODML GLGKCCLGLKL, global::DKJMPNEPOKM<FLNBNCMIPDD.AKEOEMFDKLF>? BMBJFIABMFL)
	{
		return default(global::DKJMPNEPOKM<OKMKFAGHJMD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x30C4250", Offset = "0x30C3650", VA = "0x1830C4250")]
	internal global::EJIEKPGJGCC<CPKDLGGKAMN, LCEIFOGDJKI> AGOJNKHLODD(global::DKJMPNEPOKM<OCKONIONONG> KCFOMBLHMHL, global::DKJMPNEPOKM<OKMKFAGHJMD> APJCGFNBKKN)
	{
		return default(global::EJIEKPGJGCC<CPKDLGGKAMN, LCEIFOGDJKI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2CF83E0", Offset = "0x2CF77E0", VA = "0x182CF83E0")]
	public global::EJIEKPGJGCC<global::DKJMPNEPOKM<TM>, LCEIFOGDJKI> FOOJKBNBNJE<TM>(global::DKJMPNEPOKM<OCKONIONONG> KCFOMBLHMHL, global::DKJMPNEPOKM<DMFPICMKCKE> PEFGIPMFHBI) where TM : LDAMCDBCAOD.IDCCOIHGNGD
	{
		return default(global::EJIEKPGJGCC<global::DKJMPNEPOKM<TM>, LCEIFOGDJKI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2CF85E0", Offset = "0x2CF79E0", VA = "0x182CF85E0")]
	public global::EJIEKPGJGCC<global::DKJMPNEPOKM<TM>, LCEIFOGDJKI> LHDOCHCAINH<TM>(global::DKJMPNEPOKM<OCKONIONONG> KCFOMBLHMHL, global::DKJMPNEPOKM<OKMKFAGHJMD> APJCGFNBKKN, global::DKJMPNEPOKM<OEBIECDILIK> MLMJCODANBA) where TM : AHFKNOPHOCE.MGBBAKOIECA
	{
		return default(global::EJIEKPGJGCC<global::DKJMPNEPOKM<TM>, LCEIFOGDJKI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x30C4430", Offset = "0x30C3830", VA = "0x1830C4430")]
	private global::EJIEKPGJGCC<(global::DKJMPNEPOKM<OAIBBJBDILL.NGPDDOFJBHM>, global::DKJMPNEPOKM<NNBAOEOICPP.ECBFIFMBEAB>), LCEIFOGDJKI> DIIHBPIEGFK(global::DKJMPNEPOKM<OCKONIONONG> KCFOMBLHMHL, global::DKJMPNEPOKM<OKMKFAGHJMD> APJCGFNBKKN)
	{
		return default(global::EJIEKPGJGCC<(global::DKJMPNEPOKM<OAIBBJBDILL.NGPDDOFJBHM>, global::DKJMPNEPOKM<NNBAOEOICPP.ECBFIFMBEAB>), LCEIFOGDJKI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x30C69C0", Offset = "0x30C5DC0", VA = "0x1830C69C0")]
	internal global::EJIEKPGJGCC<(global::DKJMPNEPOKM<ABGNIJONLNA>, global::DKJMPNEPOKM<CALJIOIEBOF>), LCEIFOGDJKI> PKFDICONAIC(global::DKJMPNEPOKM<OCKONIONONG> KCFOMBLHMHL, global::DKJMPNEPOKM<OKMKFAGHJMD> APJCGFNBKKN, int HIJDMMCIJLI, in MPOJBPPFFEB ONBHBHIHHNE)
	{
		return default(global::EJIEKPGJGCC<(global::DKJMPNEPOKM<ABGNIJONLNA>, global::DKJMPNEPOKM<CALJIOIEBOF>), LCEIFOGDJKI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x30C5F20", Offset = "0x30C5320", VA = "0x1830C5F20")]
	internal global::EJIEKPGJGCC<CPKDLGGKAMN, LCEIFOGDJKI> MJDCHGKDILD(global::DKJMPNEPOKM<OCKONIONONG> KCFOMBLHMHL, global::DKJMPNEPOKM<OKMKFAGHJMD> APJCGFNBKKN, int HIJDMMCIJLI)
	{
		return default(global::EJIEKPGJGCC<CPKDLGGKAMN, LCEIFOGDJKI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x30C5120", Offset = "0x30C4520", VA = "0x1830C5120")]
	internal global::EJIEKPGJGCC<(global::DKJMPNEPOKM<CALJIOIEBOF>, global::DKJMPNEPOKM<ABGNIJONLNA>), LCEIFOGDJKI> GMPHMDKGHLG(global::DKJMPNEPOKM<OCKONIONONG> KCFOMBLHMHL, global::DKJMPNEPOKM<OKMKFAGHJMD> APJCGFNBKKN, int LMOJDDNMLLL, in MPOJBPPFFEB ONBHBHIHHNE)
	{
		return default(global::EJIEKPGJGCC<(global::DKJMPNEPOKM<CALJIOIEBOF>, global::DKJMPNEPOKM<ABGNIJONLNA>), LCEIFOGDJKI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x30C48E0", Offset = "0x30C3CE0", VA = "0x1830C48E0")]
	internal global::EJIEKPGJGCC<CPKDLGGKAMN, LCEIFOGDJKI> GMLPCIHMHLG(global::DKJMPNEPOKM<OCKONIONONG> KCFOMBLHMHL, global::DKJMPNEPOKM<OKMKFAGHJMD> APJCGFNBKKN, int LMOJDDNMLLL)
	{
		return default(global::EJIEKPGJGCC<CPKDLGGKAMN, LCEIFOGDJKI>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class IMCMNBDPHDC : BMACEMCAMKC
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x30C26F0", Offset = "0x30C1AF0", VA = "0x1830C26F0", Slot = "7")]
	public override string FGDMEHNLDAL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x30C2720", Offset = "0x30C1B20", VA = "0x1830C2720")]
	public IMCMNBDPHDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class BKPAABHPECG
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct MPOJBPPFFEB : IEquatable<MPOJBPPFFEB>, global::KDMGKNEFMID<MPOJBPPFFEB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly string EKGMLAPMPFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public readonly NDNLPFJBKCL KEFHMMCGAFE;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0xA1F0E0", Offset = "0xA1E4E0", VA = "0x180A1F0E0")]
	private MPOJBPPFFEB(string LMAOKJPAKEM, NDNLPFJBKCL ONBHBHIHHNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x30CC1E0", Offset = "0x30CB5E0", VA = "0x1830CC1E0")]
	public static MPOJBPPFFEB FHHJOGLDILM(string LMAOKJPAKEM, NDNLPFJBKCL ONBHBHIHHNE)
	{
		return default(MPOJBPPFFEB);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x30CC0E0", Offset = "0x30CB4E0", VA = "0x1830CC0E0")]
	public static bool MHCPIEGNOBB(in MPOJBPPFFEB JMFOJDPECFB, in MPOJBPPFFEB PHAPIDHPFME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x30CC0E0", Offset = "0x30CB4E0", VA = "0x1830CC0E0", Slot = "4")]
	public bool Equals(MPOJBPPFFEB CCJMBGJFGLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x30CC0E0", Offset = "0x30CB4E0", VA = "0x1830CC0E0")]
	public bool BINBLAKLHFD(in MPOJBPPFFEB CCJMBGJFGLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x30CC130", Offset = "0x30CB530", VA = "0x1830CC130", Slot = "0")]
	public override bool Equals(object GHHNOPFOGCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0xA1D0B0", Offset = "0xA1C4B0", VA = "0x180A1D0B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x30CC220", Offset = "0x30CB620", VA = "0x1830CC220", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x30CC0E0", Offset = "0x30CB4E0", VA = "0x1830CC0E0", Slot = "5")]
	private bool LHDMNCHOFJG(in MPOJBPPFFEB CCJMBGJFGLH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct HLLCAGOLPED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public global::JHICNGKGFGK<OCKONIONONG, ABNPAAPBGFD> IIPPCCFJDAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public global::EOGIJMPAPGK<NNBAOEOICPP.ECBFIFMBEAB> LFBMIIOHKOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public global::JHICNGKGFGK<NNBAOEOICPP.ECBFIFMBEAB, NNBAOEOICPP.KPGMHEBILDJ> APMMDCOKGEJ;

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x1C70470", Offset = "0x1C6F870", VA = "0x181C70470")]
	private HLLCAGOLPED(in global::JHICNGKGFGK<OCKONIONONG, ABNPAAPBGFD> OGHMIAGGFBJ, in global::EOGIJMPAPGK<NNBAOEOICPP.ECBFIFMBEAB> DGKALEDAEKG, in global::JHICNGKGFGK<NNBAOEOICPP.ECBFIFMBEAB, NNBAOEOICPP.KPGMHEBILDJ> HEOLMFLCPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x30B70F0", Offset = "0x30B64F0", VA = "0x1830B70F0")]
	public static HLLCAGOLPED BLNNEJAOMLE(in global::JHICNGKGFGK<OCKONIONONG, ABNPAAPBGFD> OGHMIAGGFBJ, in global::EOGIJMPAPGK<NNBAOEOICPP.ECBFIFMBEAB> DGKALEDAEKG, in global::JHICNGKGFGK<NNBAOEOICPP.ECBFIFMBEAB, NNBAOEOICPP.KPGMHEBILDJ> HEOLMFLCPOK)
	{
		return default(HLLCAGOLPED);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class IANDCKHHMKP
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x30C19E0", Offset = "0x30C0DE0", VA = "0x1830C19E0")]
	public static void BEBNHAAGHMI(this ref HLLCAGOLPED LGKAJJKAMAG, in IMHIAJECALG GGJGGEPNCLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x30C1D20", Offset = "0x30C1120", VA = "0x1830C1D20")]
	public static void MEKJPNGCECF(this ref HLLCAGOLPED LGKAJJKAMAG, global::DKJMPNEPOKM<OCKONIONONG> KCFOMBLHMHL, in ABNPAAPBGFD CMKLAOOLLGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x30C1860", Offset = "0x30C0C60", VA = "0x1830C1860")]
	public static void BBKGKHKOOHH(this ref HLLCAGOLPED LGKAJJKAMAG, global::DKJMPNEPOKM<OCKONIONONG> KCFOMBLHMHL, in IMHIAJECALG GGJGGEPNCLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x30C1CD0", Offset = "0x30C10D0", VA = "0x1830C1CD0")]
	public static ABNPAAPBGFD LLPKLFBKNII(this in HLLCAGOLPED LGKAJJKAMAG, global::DKJMPNEPOKM<OCKONIONONG> KCFOMBLHMHL)
	{
		return default(ABNPAAPBGFD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x30C1D80", Offset = "0x30C1180", VA = "0x1830C1D80")]
	public static ABNPAAPBGFD OIPOEOJEOJH(this ref HLLCAGOLPED LGKAJJKAMAG, global::DKJMPNEPOKM<OCKONIONONG> KCFOMBLHMHL)
	{
		return default(ABNPAAPBGFD);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public sealed class NNBAOEOICPP : ODNECKOCNBI
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public sealed class ECBFIFMBEAB : LDAMCDBCAOD.IDCCOIHGNGD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public struct KPGMHEBILDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public string EKGMLAPMPFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public global::IKICBJAFAOC<OKNKOAHGAAD, MPOJBPPFFEB> ACONHOEKHEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public global::IKICBJAFAOC<INJKENCKFDO, MPOJBPPFFEB> BMIBMEFKFHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public readonly global::DKJMPNEPOKM<OKMKFAGHJMD> JKNEJOHHMFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public readonly global::DKJMPNEPOKM<OKMKFAGHJMD> FEFPCPBPAJI;

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6F4FDB0", Offset = "0x6F4F1B0", VA = "0x186F4FDB0")]
		private KPGMHEBILDJ(string LMAOKJPAKEM, in global::IKICBJAFAOC<OKNKOAHGAAD, MPOJBPPFFEB> DOJKOMGLOKF, in global::IKICBJAFAOC<INJKENCKFDO, MPOJBPPFFEB> HOGOGDMJMIG, global::DKJMPNEPOKM<OKMKFAGHJMD> DCMPAAOMKIM, global::DKJMPNEPOKM<OKMKFAGHJMD> DCGOMAJGPGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6F4FCE0", Offset = "0x6F4F0E0", VA = "0x186F4FCE0")]
		public static KPGMHEBILDJ FHHJOGLDILM(global::DKJMPNEPOKM<OKMKFAGHJMD> DAMHMGANPAI, global::DKJMPNEPOKM<OKMKFAGHJMD> AGIMGANKMFN)
		{
			return default(KPGMHEBILDJ);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6F4FC60", Offset = "0x6F4F060", VA = "0x186F4FC60")]
		public static KPGMHEBILDJ BLNNEJAOMLE(string LMAOKJPAKEM, in global::IKICBJAFAOC<OKNKOAHGAAD, MPOJBPPFFEB> DOJKOMGLOKF, in global::IKICBJAFAOC<INJKENCKFDO, MPOJBPPFFEB> HOGOGDMJMIG, global::DKJMPNEPOKM<OKMKFAGHJMD> DAMHMGANPAI, global::DKJMPNEPOKM<OKMKFAGHJMD> AGIMGANKMFN)
		{
			return default(KPGMHEBILDJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x30D43B0", Offset = "0x30D37B0", VA = "0x1830D43B0", Slot = "8")]
	public override void MCDKCEHBHAE(KAGFALJBAED PIOOALFEPLN, global::DKJMPNEPOKM<OCKONIONONG> KCFOMBLHMHL, ref IPNMOJMODML GFNGCDOBHLO, global::DKJMPNEPOKM<FLNBNCMIPDD.AKEOEMFDKLF>? BMBJFIABMFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x30D4670", Offset = "0x30D3A70", VA = "0x1830D4670", Slot = "9")]
	public override void PELFLJOKLFE(KAGFALJBAED PIOOALFEPLN, global::DKJMPNEPOKM<OCKONIONONG> KCFOMBLHMHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x30B7650", Offset = "0x30B6A50", VA = "0x1830B7650")]
	public NNBAOEOICPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class GBCDFNNGHPA
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x30BEA50", Offset = "0x30BDE50", VA = "0x1830BEA50")]
	public static void BEBNHAAGHMI(this ref NNBAOEOICPP.KPGMHEBILDJ LGKAJJKAMAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct ABNPAAPBGFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public global::JHICNGKGFGK<OKMKFAGHJMD, AGOAPGGKIMM> PIAEBMBIHNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public global::EOGIJMPAPGK<OAIBBJBDILL.NGPDDOFJBHM> KKMEGJDDAKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public global::JHICNGKGFGK<OAIBBJBDILL.NGPDDOFJBHM, OAIBBJBDILL.CAOOCHGIIPE> KCGHBJACLIL;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x1C70470", Offset = "0x1C6F870", VA = "0x181C70470")]
	private ABNPAAPBGFD(in global::JHICNGKGFGK<OKMKFAGHJMD, AGOAPGGKIMM> FOPCAGDDMND, in global::EOGIJMPAPGK<OAIBBJBDILL.NGPDDOFJBHM> KCPIPNABNLL, in global::JHICNGKGFGK<OAIBBJBDILL.NGPDDOFJBHM, OAIBBJBDILL.CAOOCHGIIPE> GEHNINCOLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x30B7160", Offset = "0x30B6560", VA = "0x1830B7160")]
	public static ABNPAAPBGFD FHHJOGLDILM()
	{
		return default(ABNPAAPBGFD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x30B70F0", Offset = "0x30B64F0", VA = "0x1830B70F0")]
	public static ABNPAAPBGFD BLNNEJAOMLE(in global::JHICNGKGFGK<OKMKFAGHJMD, AGOAPGGKIMM> FOPCAGDDMND, in global::EOGIJMPAPGK<OAIBBJBDILL.NGPDDOFJBHM> KCPIPNABNLL, in global::JHICNGKGFGK<OAIBBJBDILL.NGPDDOFJBHM, OAIBBJBDILL.CAOOCHGIIPE> GEHNINCOLAD)
	{
		return default(ABNPAAPBGFD);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class CABMPPIAHPN
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x30B9810", Offset = "0x30B8C10", VA = "0x1830B9810")]
	public static void BEBNHAAGHMI(this ref ABNPAAPBGFD LGKAJJKAMAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public abstract class ODNECKOCNBI : global::MGKBHHIKNFF<KAGFALJBAED>
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x30B7650", Offset = "0x30B6A50", VA = "0x1830B7650")]
	protected ODNECKOCNBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class AMMNBKFMMKA : ODNECKOCNBI
{
	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "8")]
	public override void MCDKCEHBHAE(KAGFALJBAED PIOOALFEPLN, global::DKJMPNEPOKM<OCKONIONONG> KCFOMBLHMHL, ref IPNMOJMODML GFNGCDOBHLO, global::DKJMPNEPOKM<FLNBNCMIPDD.AKEOEMFDKLF>? BMBJFIABMFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "9")]
	public override void PELFLJOKLFE(KAGFALJBAED PIOOALFEPLN, global::DKJMPNEPOKM<OCKONIONONG> KCFOMBLHMHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x30B7650", Offset = "0x30B6A50", VA = "0x1830B7650")]
	public AMMNBKFMMKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface AELPGPIBNFA
{
	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MHCEBELAHHC MLNONHGNCMI();

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MHCEBELAHHC JKKPGOAJIEC();

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MHCEBELAHHC HCNHIGPBBKH();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface EMBBJIAKJBO
{
	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<global::EJIEKPGJGCC<object, EACFJIDFNJL>> JJOAAJDHPED(AEPBDBDMJFD ENOAFIICPMH, bool OEJHBOAIHDI);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class LHPJJHAHCCN : global::GPBBCKOOCCH<LHPJJHAHCCN, KAGFALJBAED>, OHHPMNDEIND
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private global::IKICBJAFAOC<FCHPMFCBLNP, MHCEBELAHHC> NEBJOCBHDNI;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x30C9C90", Offset = "0x30C9090", VA = "0x1830C9C90", Slot = "6")]
	public global::DKJMPNEPOKM<FCHPMFCBLNP> MLAFNIBKJLB(MHCEBELAHHC PIJLLKPJJEJ)
	{
		return default(global::DKJMPNEPOKM<FCHPMFCBLNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x30C9CE0", Offset = "0x30C90E0", VA = "0x1830C9CE0")]
	private LHPJJHAHCCN(in global::IKICBJAFAOC<OEBIECDILIK, global::APEEILNOENF<KAGFALJBAED>> NKLJIFCPJAP, in global::IKICBJAFAOC<DMFPICMKCKE, global::HLGHDPCKOCA<KAGFALJBAED>> DJFDPDIMLFL, in global::IKICBJAFAOC<FCHPMFCBLNP, MHCEBELAHHC> KOIBPGMFMJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x30C9AD0", Offset = "0x30C8ED0", VA = "0x1830C9AD0")]
	public static LHPJJHAHCCN FHHJOGLDILM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x30C9BC0", Offset = "0x30C8FC0", VA = "0x1830C9BC0")]
	public new (global::GKKHFKOPIFH<OEBIECDILIK, global::APEEILNOENF<KAGFALJBAED>>, global::GKKHFKOPIFH<DMFPICMKCKE, global::HLGHDPCKOCA<KAGFALJBAED>>, global::GKKHFKOPIFH<FCHPMFCBLNP, MHCEBELAHHC>) KDJPCPOKFGG()
	{
		return default((global::GKKHFKOPIFH<OEBIECDILIK, global::APEEILNOENF<KAGFALJBAED>>, global::GKKHFKOPIFH<DMFPICMKCKE, global::HLGHDPCKOCA<KAGFALJBAED>>, global::GKKHFKOPIFH<FCHPMFCBLNP, MHCEBELAHHC>));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface OHHPMNDEIND
{
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::DKJMPNEPOKM<FCHPMFCBLNP> MLAFNIBKJLB(MHCEBELAHHC PIJLLKPJJEJ);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct CCILCKLDIPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public global::JHICNGKGFGK<NNBAOEOICPP.ECBFIFMBEAB, global::MEJHDPIBDJF<ABGNIJONLNA, CALJIOIEBOF, OKMKFAGHJMD, OCKONIONONG>> MGGJHELPELE;

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x1C67400", Offset = "0x1C66800", VA = "0x181C67400")]
	private CCILCKLDIPM(in global::JHICNGKGFGK<NNBAOEOICPP.ECBFIFMBEAB, global::MEJHDPIBDJF<ABGNIJONLNA, CALJIOIEBOF, OKMKFAGHJMD, OCKONIONONG>> HKEICODGDFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x30B9B20", Offset = "0x30B8F20", VA = "0x1830B9B20")]
	public static CCILCKLDIPM FHHJOGLDILM()
	{
		return default(CCILCKLDIPM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class ECEGNCCOCBA
{
	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x30BC100", Offset = "0x30BB500", VA = "0x1830BC100")]
	public static void BEBNHAAGHMI(this ref CCILCKLDIPM LGKAJJKAMAG, in global::EOGIJMPAPGK<NNBAOEOICPP.ECBFIFMBEAB> DGKALEDAEKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class NLDGAGDPNCG
{
	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x30D4020", Offset = "0x30D3420", VA = "0x1830D4020")]
	public static MJOOEAKKPHB AKAHDAOKFEM(in IMHIAJECALG LGKAJJKAMAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x30D41C0", Offset = "0x30D35C0", VA = "0x1830D41C0")]
	public static IMHIAJECALG INEKOHCFCOE(MJOOEAKKPHB LGKAJJKAMAG)
	{
		return default(IMHIAJECALG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class PPEOCEACOGP
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x30D6A70", Offset = "0x30D5E70", VA = "0x1830D6A70")]
	public static AAFFMODFJKM AKAHDAOKFEM(KAGFALJBAED LGKAJJKAMAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x30D6B30", Offset = "0x30D5F30", VA = "0x1830D6B30")]
	public static KAGFALJBAED INEKOHCFCOE(AAFFMODFJKM LGKAJJKAMAG, in MHNOJKKEDAD JPHONJHNLOL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class ACMCGIPAEFI
{
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x30B7230", Offset = "0x30B6630", VA = "0x1830B7230")]
	public static FHGOHEGIIHO AKAHDAOKFEM(in OAIBBJBDILL.CAOOCHGIIPE LGKAJJKAMAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x30B72A0", Offset = "0x30B66A0", VA = "0x1830B72A0")]
	public static OAIBBJBDILL.CAOOCHGIIPE INEKOHCFCOE(FHGOHEGIIHO LGKAJJKAMAG)
	{
		return default(OAIBBJBDILL.CAOOCHGIIPE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class DGIGIKBHGHA
{
	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x285AE50", Offset = "0x285A250", VA = "0x18285AE50")]
	public static void IHEJIBGAFFD<TDeserialized, TSerialized>(this IReadOnlyCollection<TDeserialized> LGKAJJKAMAG, RepeatedField<TSerialized> MPNODGMHCDM, global::PJKMOJHEJMC<TDeserialized, TSerialized> EGHCHPKPDLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class LCAPNLAACBN
{
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x30C85D0", Offset = "0x30C79D0", VA = "0x1830C85D0")]
	public static FAEKALGHDEL AKAHDAOKFEM(in MPOJBPPFFEB LGKAJJKAMAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x30C8660", Offset = "0x30C7A60", VA = "0x1830C8660")]
	public static MPOJBPPFFEB INEKOHCFCOE(FAEKALGHDEL LGKAJJKAMAG)
	{
		return default(MPOJBPPFFEB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class MGFALPLGKBH
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x30CB000", Offset = "0x30CA400", VA = "0x1830CB000")]
	public static DFPOLIMMNJP AKAHDAOKFEM(in NHNNCCICGMJ LGKAJJKAMAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x30CB190", Offset = "0x30CA590", VA = "0x1830CB190")]
	public static NHNNCCICGMJ INEKOHCFCOE(DFPOLIMMNJP LGKAJJKAMAG)
	{
		return default(NHNNCCICGMJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class HLOLMEOONBA
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x30C0B10", Offset = "0x30BFF10", VA = "0x1830C0B10")]
	public static IKAOGGAMKKP AKAHDAOKFEM(in PFIIHCNAPFF LGKAJJKAMAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x30C0B80", Offset = "0x30BFF80", VA = "0x1830C0B80")]
	public static PFIIHCNAPFF INEKOHCFCOE(IKAOGGAMKKP LGKAJJKAMAG)
	{
		return default(PFIIHCNAPFF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class MHAPLIJNIPL
{
	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x30CB310", Offset = "0x30CA710", VA = "0x1830CB310")]
	public static HAOANGLABNM AKAHDAOKFEM(in global::EJIBMEKAKEE<global::DKJMPNEPOKM<CALJIOIEBOF>> LGKAJJKAMAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x30CB4A0", Offset = "0x30CA8A0", VA = "0x1830CB4A0")]
	public static global::EJIBMEKAKEE<global::DKJMPNEPOKM<CALJIOIEBOF>> INEKOHCFCOE(HAOANGLABNM LGKAJJKAMAG)
	{
		return default(global::EJIBMEKAKEE<global::DKJMPNEPOKM<CALJIOIEBOF>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class DPFKKIBLKOG
{
	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x30BBE10", Offset = "0x30BB210", VA = "0x1830BBE10")]
	public static JFPGLPOBCNA AKAHDAOKFEM(in global::EJIBMEKAKEE<global::DKJMPNEPOKM<OCKONIONONG>> LGKAJJKAMAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x30BBFA0", Offset = "0x30BB3A0", VA = "0x1830BBFA0")]
	public static global::EJIBMEKAKEE<global::DKJMPNEPOKM<OCKONIONONG>> INEKOHCFCOE(JFPGLPOBCNA LGKAJJKAMAG)
	{
		return default(global::EJIBMEKAKEE<global::DKJMPNEPOKM<OCKONIONONG>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class GIEAIAGKDME
{
	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x30BF200", Offset = "0x30BE600", VA = "0x1830BF200")]
	public static NIHCLKAICJB AKAHDAOKFEM(in global::FKEHIKDGDGP<ABGNIJONLNA, CALJIOIEBOF, OKMKFAGHJMD> LGKAJJKAMAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x30BF4B0", Offset = "0x30BE8B0", VA = "0x1830BF4B0")]
	public static global::FKEHIKDGDGP<ABGNIJONLNA, CALJIOIEBOF, OKMKFAGHJMD> INEKOHCFCOE(NIHCLKAICJB LGKAJJKAMAG)
	{
		return default(global::FKEHIKDGDGP<ABGNIJONLNA, CALJIOIEBOF, OKMKFAGHJMD>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class GEHEPLDKECE
{
	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x30BEDC0", Offset = "0x30BE1C0", VA = "0x1830BEDC0")]
	public static LCPLHPAOPMH AKAHDAOKFEM(in Guid LGKAJJKAMAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x30BEEF0", Offset = "0x30BE2F0", VA = "0x1830BEEF0")]
	public static Guid INEKOHCFCOE(LCPLHPAOPMH LGKAJJKAMAG)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class LGMKLFGAEFE
{
	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x30C8E00", Offset = "0x30C8200", VA = "0x1830C8E00")]
	public static KIGMMFBJPKJ AKAHDAOKFEM(in LDAMCDBCAOD LGKAJJKAMAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x30C93E0", Offset = "0x30C87E0", VA = "0x1830C93E0")]
	public static LDAMCDBCAOD INEKOHCFCOE(KIGMMFBJPKJ LGKAJJKAMAG)
	{
		return default(LDAMCDBCAOD);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class NCCHMPNNHKN
{
	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x30CC260", Offset = "0x30CB660", VA = "0x1830CC260")]
	public static MLHGCNFBPFD AKAHDAOKFEM(KAGFALJBAED PIOOALFEPLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x30CC380", Offset = "0x30CB780", VA = "0x1830CC380")]
	public static MLHGCNFBPFD CFGCAIFNIAD(global::DKJMPNEPOKM<DMFPICMKCKE> KOPGGLFBCNI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class PGBKHGFCLFH
{
	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x24D8370", Offset = "0x24D7770", VA = "0x1824D8370")]
	public static void IHEJIBGAFFD<TDeserialized, TSerialized>(in global::EJIBMEKAKEE<TDeserialized> LGKAJJKAMAG, RepeatedField<TSerialized> MPNODGMHCDM, Func<TDeserialized, TSerialized> EGHCHPKPDLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x24D86F0", Offset = "0x24D7AF0", VA = "0x1824D86F0")]
	public static global::EJIBMEKAKEE<TDeserialized> INEKOHCFCOE<TDeserialized, TSerialized>(RepeatedField<TSerialized> MPNODGMHCDM, Func<TSerialized, TDeserialized> NOKJNJKDCLG)
	{
		return default(global::EJIBMEKAKEE<TDeserialized>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class CLMEIABFCJD
{
	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x30BA1A0", Offset = "0x30B95A0", VA = "0x1830BA1A0")]
	public static LAEEEANGJCA AKAHDAOKFEM(in PBCGJOOMDIO LGKAJJKAMAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x30BA300", Offset = "0x30B9700", VA = "0x1830BA300")]
	public static PBCGJOOMDIO INEKOHCFCOE(LAEEEANGJCA LGKAJJKAMAG)
	{
		return default(PBCGJOOMDIO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class LFIBHDBLDBH
{
	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x30C8B40", Offset = "0x30C7F40", VA = "0x1830C8B40")]
	public static MDJOMMJKICH AKAHDAOKFEM(in MGNDEILEKHL LGKAJJKAMAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x30C8D30", Offset = "0x30C8130", VA = "0x1830C8D30")]
	public static MGNDEILEKHL INEKOHCFCOE(MDJOMMJKICH LGKAJJKAMAG)
	{
		return default(MGNDEILEKHL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class FNKKJDAOLCK
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x30BCBF0", Offset = "0x30BBFF0", VA = "0x1830BCBF0")]
	public static BLJMIGFIMPA AKAHDAOKFEM(in NDNLPFJBKCL ONBHBHIHHNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x30BDD10", Offset = "0x30BD110", VA = "0x1830BDD10")]
	public static NDNLPFJBKCL INEKOHCFCOE(in BLJMIGFIMPA ONBHBHIHHNE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class CPPJBOIFGDF
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x30BA8C0", Offset = "0x30B9CC0", VA = "0x1830BA8C0")]
	public static EDCJJPBABDO AKAHDAOKFEM(in HLLCAGOLPED LGKAJJKAMAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x30BAB70", Offset = "0x30B9F70", VA = "0x1830BAB70")]
	public static HLLCAGOLPED INEKOHCFCOE(EDCJJPBABDO LGKAJJKAMAG)
	{
		return default(HLLCAGOLPED);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class BGOBGCHGBOP
{
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x30B7E70", Offset = "0x30B7270", VA = "0x1830B7E70")]
	public static ENCMNOFGGPA AKAHDAOKFEM(in LNHAMOFMBBA LGKAJJKAMAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x30B7FD0", Offset = "0x30B73D0", VA = "0x1830B7FD0")]
	public static LNHAMOFMBBA INEKOHCFCOE(ENCMNOFGGPA LGKAJJKAMAG)
	{
		return default(LNHAMOFMBBA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class CJEOHFDOJFK
{
	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x258ED80", Offset = "0x258E180", VA = "0x18258ED80")]
	public static PGAHLBAFBIJ AKAHDAOKFEM<TRoot>(in global::FEGAMGKJJBA<TRoot> LGKAJJKAMAG) where TRoot : global::LNPGBMLPKIM<TRoot>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x30B9B80", Offset = "0x30B8F80", VA = "0x1830B9B80")]
	public static global::FEGAMGKJJBA<KAGFALJBAED> INEKOHCFCOE(in MHNOJKKEDAD JPHONJHNLOL, PGAHLBAFBIJ LGKAJJKAMAG)
	{
		return default(global::FEGAMGKJJBA<KAGFALJBAED>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class MCCAPOILKHE
{
	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x30CA3D0", Offset = "0x30C97D0", VA = "0x1830CA3D0")]
	public static OACIJMHMDIC AKAHDAOKFEM(in global::KPKNDCDPOAJ<ABGNIJONLNA, CALJIOIEBOF, OKMKFAGHJMD> LGKAJJKAMAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x30CA680", Offset = "0x30C9A80", VA = "0x1830CA680")]
	public static global::KPKNDCDPOAJ<ABGNIJONLNA, CALJIOIEBOF, OKMKFAGHJMD> INEKOHCFCOE(OACIJMHMDIC LGKAJJKAMAG)
	{
		return default(global::KPKNDCDPOAJ<ABGNIJONLNA, CALJIOIEBOF, OKMKFAGHJMD>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class GOJNOPKLICI
{
	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x2CE7420", Offset = "0x2CE6820", VA = "0x182CE7420")]
	public static JMGFEDJNBBO AKAHDAOKFEM<M>(in global::EOGIJMPAPGK<M> LGKAJJKAMAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x2CE7630", Offset = "0x2CE6A30", VA = "0x182CE7630")]
	public static global::EOGIJMPAPGK<M> INEKOHCFCOE<M>(JMGFEDJNBBO LGKAJJKAMAG)
	{
		return default(global::EOGIJMPAPGK<M>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class GLCDPLEEMCO
{
	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x30BF7D0", Offset = "0x30BEBD0", VA = "0x1830BF7D0")]
	public static FFKPDKJBMIK AKAHDAOKFEM(in global::MKMEAFJBDEM<ABGNIJONLNA, CALJIOIEBOF, OKMKFAGHJMD> LGKAJJKAMAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x30BF880", Offset = "0x30BEC80", VA = "0x1830BF880")]
	public static global::MKMEAFJBDEM<ABGNIJONLNA, CALJIOIEBOF, OKMKFAGHJMD> INEKOHCFCOE(FFKPDKJBMIK LGKAJJKAMAG)
	{
		return default(global::MKMEAFJBDEM<ABGNIJONLNA, CALJIOIEBOF, OKMKFAGHJMD>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class BIHFKMJAKIA
{
	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x30B81D0", Offset = "0x30B75D0", VA = "0x1830B81D0")]
	public static OJNFKJDFEPL AKAHDAOKFEM(in AHFKNOPHOCE LGKAJJKAMAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x30B8250", Offset = "0x30B7650", VA = "0x1830B8250")]
	public static AHFKNOPHOCE INEKOHCFCOE(OJNFKJDFEPL LGKAJJKAMAG)
	{
		return default(AHFKNOPHOCE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class JPJBPMPOHCD
{
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x30C3F60", Offset = "0x30C3360", VA = "0x1830C3F60")]
	public static MACFHDLCOCK AKAHDAOKFEM(in global::EJIBMEKAKEE<global::DKJMPNEPOKM<ABGNIJONLNA>> LGKAJJKAMAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x30C40F0", Offset = "0x30C34F0", VA = "0x1830C40F0")]
	public static global::EJIBMEKAKEE<global::DKJMPNEPOKM<ABGNIJONLNA>> INEKOHCFCOE(MACFHDLCOCK LGKAJJKAMAG)
	{
		return default(global::EJIBMEKAKEE<global::DKJMPNEPOKM<ABGNIJONLNA>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class CGAGKHNIHBA
{
	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x25885D0", Offset = "0x25879D0", VA = "0x1825885D0")]
	public static void IHEJIBGAFFD<M, TDeserialized, TSerialized>(in global::IKICBJAFAOC<M, TDeserialized> LGKAJJKAMAG, RepeatedField<TSerialized> MPNODGMHCDM, Func<TDeserialized, TSerialized> EGHCHPKPDLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x2589210", Offset = "0x2588610", VA = "0x182589210")]
	public static void IHEJIBGAFFD<M, TDeserialized, TSerialized>(in global::IKICBJAFAOC<M, TDeserialized> LGKAJJKAMAG, RepeatedField<TSerialized> MPNODGMHCDM, global::PJKMOJHEJMC<TDeserialized, TSerialized> EGHCHPKPDLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class KJGKOCDEFCD<M>
{
	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x398C750", Offset = "0x398BB50", VA = "0x18398C750")]
	public static global::IKICBJAFAOC<M, TDeserialized> INEKOHCFCOE<TDeserialized, TSerialized>(RepeatedField<TSerialized> MPNODGMHCDM, Func<TSerialized, TDeserialized> NOKJNJKDCLG)
	{
		return default(global::IKICBJAFAOC<M, TDeserialized>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class NIFHKCHENHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x30D3D30", Offset = "0x30D3130", VA = "0x1830D3D30")]
	public static ADDAEHALKGF AKAHDAOKFEM(in global::EJIBMEKAKEE<global::DKJMPNEPOKM<CALJIOIEBOF>> LGKAJJKAMAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x30D3EC0", Offset = "0x30D32C0", VA = "0x1830D3EC0")]
	public static global::EJIBMEKAKEE<global::DKJMPNEPOKM<CALJIOIEBOF>> INEKOHCFCOE(ADDAEHALKGF LGKAJJKAMAG)
	{
		return default(global::EJIBMEKAKEE<global::DKJMPNEPOKM<CALJIOIEBOF>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class PDNIGAPEJFO
{
	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x30D5DF0", Offset = "0x30D51F0", VA = "0x1830D5DF0")]
	public static CNCKMIDAOEM AKAHDAOKFEM(in NNBAOEOICPP.KPGMHEBILDJ LGKAJJKAMAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x30D6090", Offset = "0x30D5490", VA = "0x1830D6090")]
	public static NNBAOEOICPP.KPGMHEBILDJ INEKOHCFCOE(CNCKMIDAOEM LGKAJJKAMAG)
	{
		return default(NNBAOEOICPP.KPGMHEBILDJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class HMPPOAIHLBK
{
	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x30C11D0", Offset = "0x30C05D0", VA = "0x1830C11D0")]
	public static CNMMFMEODJP AKAHDAOKFEM(in AMPFOPBHEND LGKAJJKAMAG, NDNLPFJBKCL ONBHBHIHHNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x30C1390", Offset = "0x30C0790", VA = "0x1830C1390")]
	public static AMPFOPBHEND INEKOHCFCOE(CNMMFMEODJP LGKAJJKAMAG)
	{
		return default(AMPFOPBHEND);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class PNJKFMDLJLC
{
	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x30D63A0", Offset = "0x30D57A0", VA = "0x1830D63A0")]
	public static IFKHOBPPIEB AKAHDAOKFEM(in global::EPDGGELKDCB<OCKONIONONG> LGKAJJKAMAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x30D6650", Offset = "0x30D5A50", VA = "0x1830D6650")]
	public static global::EPDGGELKDCB<OCKONIONONG> INEKOHCFCOE(IFKHOBPPIEB LGKAJJKAMAG)
	{
		return default(global::EPDGGELKDCB<OCKONIONONG>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class AEGLFBLNIIJ
{
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x1A4BEF0", Offset = "0x1A4B2F0", VA = "0x181A4BEF0")]
	public static void IHEJIBGAFFD<M, TDeserialized, TSerialized>(in global::JHICNGKGFGK<M, TDeserialized> LGKAJJKAMAG, RepeatedField<TSerialized> MPNODGMHCDM, Func<TDeserialized, TSerialized> EGHCHPKPDLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x1A4BEF0", Offset = "0x1A4B2F0", VA = "0x181A4BEF0")]
	public static void IHEJIBGAFFD<M, TDeserialized, TSerialized>(in global::JHICNGKGFGK<M, TDeserialized> LGKAJJKAMAG, RepeatedField<TSerialized> MPNODGMHCDM, global::PJKMOJHEJMC<TDeserialized, TSerialized> EGHCHPKPDLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class NGGBKMPDHLA<M>
{
	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x2F8BD30", Offset = "0x2F8B130", VA = "0x182F8BD30")]
	public static global::JHICNGKGFGK<M, TDeserialized> DDFPFPNPJMK<TDeserialized, TSerialized>(RepeatedField<TSerialized> MPNODGMHCDM, Func<TSerialized, TDeserialized> NOKJNJKDCLG)
	{
		return default(global::JHICNGKGFGK<M, TDeserialized>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class JDEGJOKLDGL
{
	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x30C2E10", Offset = "0x30C2210", VA = "0x1830C2E10")]
	public static KJNIGBLJJMN AKAHDAOKFEM(in global::EJIBMEKAKEE<global::DKJMPNEPOKM<ABGNIJONLNA>> LGKAJJKAMAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x30C2FA0", Offset = "0x30C23A0", VA = "0x1830C2FA0")]
	public static global::EJIBMEKAKEE<global::DKJMPNEPOKM<ABGNIJONLNA>> INEKOHCFCOE(KJNIGBLJJMN LGKAJJKAMAG)
	{
		return default(global::EJIBMEKAKEE<global::DKJMPNEPOKM<ABGNIJONLNA>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class DJLCEKKFFAO
{
	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x3E0B600", Offset = "0x3E0AA00", VA = "0x183E0B600")]
	public static Dictionary<TDeserializedKey, TDeserializedValue> OLCMNDFJLJJ<TDeserializedKey, TDeserializedValue, TSerialized>(this RepeatedField<TSerialized> MPNODGMHCDM, Func<TSerialized, TDeserializedKey> JFHPNJMCGBI, Func<TSerialized, TDeserializedValue> MNAOBEJMDPF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class OJNJHNPNNGM
{
	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x30D5520", Offset = "0x30D4920", VA = "0x1830D5520")]
	public static NHLNJHOKGBE AKAHDAOKFEM(in AGOAPGGKIMM LGKAJJKAMAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x30D55B0", Offset = "0x30D49B0", VA = "0x1830D55B0")]
	public static AGOAPGGKIMM INEKOHCFCOE(NHLNJHOKGBE LGKAJJKAMAG)
	{
		return default(AGOAPGGKIMM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class BGCHCNICMAL
{
	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x30B78A0", Offset = "0x30B6CA0", VA = "0x1830B78A0")]
	public static DPCONPFIKAL AKAHDAOKFEM(in global::KOMKKMMICNH<ABGNIJONLNA, CALJIOIEBOF, OKMKFAGHJMD> LGKAJJKAMAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x30B7B50", Offset = "0x30B6F50", VA = "0x1830B7B50")]
	public static global::KOMKKMMICNH<ABGNIJONLNA, CALJIOIEBOF, OKMKFAGHJMD> INEKOHCFCOE(DPCONPFIKAL LGKAJJKAMAG)
	{
		return default(global::KOMKKMMICNH<ABGNIJONLNA, CALJIOIEBOF, OKMKFAGHJMD>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class HMHBLFAPJBO
{
	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x30C0C00", Offset = "0x30C0000", VA = "0x1830C0C00")]
	public static JFMCLDPJBPF AKAHDAOKFEM(in ABNPAAPBGFD LGKAJJKAMAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x30C0EB0", Offset = "0x30C02B0", VA = "0x1830C0EB0")]
	public static ABNPAAPBGFD INEKOHCFCOE(JFMCLDPJBPF LGKAJJKAMAG)
	{
		return default(ABNPAAPBGFD);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public readonly struct DECHFKBKFJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public readonly global::DKJMPNEPOKM<OCKONIONONG> BIIGCAMPPFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public readonly global::DKJMPNEPOKM<OKMKFAGHJMD> DHOAFNEEAOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public readonly int PMGFIJGOCJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public readonly MPOJBPPFFEB KEFHMMCGAFE;

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x30BB870", Offset = "0x30BAC70", VA = "0x1830BB870")]
	private DECHFKBKFJP(global::DKJMPNEPOKM<OCKONIONONG> KCFOMBLHMHL, global::DKJMPNEPOKM<OKMKFAGHJMD> APJCGFNBKKN, int LMOJDDNMLLL, MPOJBPPFFEB ONBHBHIHHNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x30BB680", Offset = "0x30BAA80", VA = "0x1830BB680")]
	public static global::MDINMLDMAPM<JAFJIJEKPPM, DECHFKBKFJP> DLOLHCCDOLB(AEPBDBDMJFD LLNEOAHADLL)
	{
		return default(global::MDINMLDMAPM<JAFJIJEKPPM, DECHFKBKFJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x285A180", Offset = "0x2859580", VA = "0x18285A180")]
	public static global::EJIEKPGJGCC<(global::DKJMPNEPOKM<ABGNIJONLNA>, global::DKJMPNEPOKM<CALJIOIEBOF>), LCEIFOGDJKI> EOEOEOFIOCB<TRoot>(TRoot PFMMNJCIGCA, in DECHFKBKFJP LGKAJJKAMAG) where TRoot : ELAHBOFNDJG
	{
		return default(global::EJIEKPGJGCC<(global::DKJMPNEPOKM<ABGNIJONLNA>, global::DKJMPNEPOKM<CALJIOIEBOF>), LCEIFOGDJKI>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public readonly struct NEEIKMKMDDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public readonly global::DKJMPNEPOKM<OCKONIONONG>? PBILOFPLGIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public readonly global::DKJMPNEPOKM<DMFPICMKCKE> DHPPBGLJDHN;

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0xE6AF00", Offset = "0xE6A300", VA = "0x180E6AF00")]
	private NEEIKMKMDDF(global::DKJMPNEPOKM<OCKONIONONG>? GCKDDDLEBEN, global::DKJMPNEPOKM<DMFPICMKCKE> PEFGIPMFHBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x30CCA80", Offset = "0x30CBE80", VA = "0x1830CCA80")]
	public static global::MDINMLDMAPM<JAFJIJEKPPM, NEEIKMKMDDF> DLOLHCCDOLB(AEPBDBDMJFD LLNEOAHADLL)
	{
		return default(global::MDINMLDMAPM<JAFJIJEKPPM, NEEIKMKMDDF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x29158D0", Offset = "0x2914CD0", VA = "0x1829158D0")]
	public static global::EJIEKPGJGCC<global::DKJMPNEPOKM<OCKONIONONG>, LCEIFOGDJKI> EOEOEOFIOCB<TRoot>(TRoot PFMMNJCIGCA, in NEEIKMKMDDF LGKAJJKAMAG) where TRoot : ELAHBOFNDJG
	{
		return default(global::EJIEKPGJGCC<global::DKJMPNEPOKM<OCKONIONONG>, LCEIFOGDJKI>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public readonly struct DCOBAICPDCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public readonly global::DKJMPNEPOKM<OCKONIONONG> BIIGCAMPPFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public readonly global::DKJMPNEPOKM<OKMKFAGHJMD> DHOAFNEEAOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public readonly int HFNIIKPNDOH;

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x122ECB0", Offset = "0x122E0B0", VA = "0x18122ECB0")]
	private DCOBAICPDCI(global::DKJMPNEPOKM<OCKONIONONG> KCFOMBLHMHL, global::DKJMPNEPOKM<OKMKFAGHJMD> APJCGFNBKKN, int HIJDMMCIJLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x30BB0B0", Offset = "0x30BA4B0", VA = "0x1830BB0B0")]
	public static global::MDINMLDMAPM<JAFJIJEKPPM, DCOBAICPDCI> DLOLHCCDOLB(AEPBDBDMJFD LLNEOAHADLL)
	{
		return default(global::MDINMLDMAPM<JAFJIJEKPPM, DCOBAICPDCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x28585F0", Offset = "0x28579F0", VA = "0x1828585F0")]
	public static global::EJIEKPGJGCC<CPKDLGGKAMN, LCEIFOGDJKI> EOEOEOFIOCB<TRoot>(TRoot PFMMNJCIGCA, in DCOBAICPDCI LGKAJJKAMAG) where TRoot : ELAHBOFNDJG
	{
		return default(global::EJIEKPGJGCC<CPKDLGGKAMN, LCEIFOGDJKI>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public readonly struct OMCMLIPGFJN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public readonly global::DKJMPNEPOKM<OCKONIONONG> BIIGCAMPPFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public readonly global::DKJMPNEPOKM<CALJIOIEBOF> KMMDNILDDDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public readonly global::DKJMPNEPOKM<ABGNIJONLNA> OACDFCKNFCJ;

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x122ECB0", Offset = "0x122E0B0", VA = "0x18122ECB0")]
	private OMCMLIPGFJN(global::DKJMPNEPOKM<OCKONIONONG> KCFOMBLHMHL, global::DKJMPNEPOKM<CALJIOIEBOF> IOIBHMPNOAJ, global::DKJMPNEPOKM<ABGNIJONLNA> OFIEEAIIOOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x30D5880", Offset = "0x30D4C80", VA = "0x1830D5880")]
	public static global::MDINMLDMAPM<JAFJIJEKPPM, OMCMLIPGFJN> DLOLHCCDOLB(AEPBDBDMJFD LLNEOAHADLL)
	{
		return default(global::MDINMLDMAPM<JAFJIJEKPPM, OMCMLIPGFJN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x24CF4F0", Offset = "0x24CE8F0", VA = "0x1824CF4F0")]
	public static global::EJIEKPGJGCC<CPKDLGGKAMN, LCEIFOGDJKI> EOEOEOFIOCB<TRoot>(TRoot PFMMNJCIGCA, in OMCMLIPGFJN LGKAJJKAMAG) where TRoot : ELAHBOFNDJG
	{
		return default(global::EJIEKPGJGCC<CPKDLGGKAMN, LCEIFOGDJKI>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public readonly struct FHKMEPEOHEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public readonly global::DKJMPNEPOKM<OCKONIONONG> BIIGCAMPPFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public readonly global::DKJMPNEPOKM<OKMKFAGHJMD> DHOAFNEEAOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public readonly int PMGFIJGOCJF;

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x122ECB0", Offset = "0x122E0B0", VA = "0x18122ECB0")]
	private FHKMEPEOHEF(global::DKJMPNEPOKM<OCKONIONONG> KCFOMBLHMHL, global::DKJMPNEPOKM<OKMKFAGHJMD> APJCGFNBKKN, int HIJDMMCIJLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x30BCAE0", Offset = "0x30BBEE0", VA = "0x1830BCAE0")]
	public static global::MDINMLDMAPM<JAFJIJEKPPM, FHKMEPEOHEF> DLOLHCCDOLB(AEPBDBDMJFD LLNEOAHADLL)
	{
		return default(global::MDINMLDMAPM<JAFJIJEKPPM, FHKMEPEOHEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x2FB8BF0", Offset = "0x2FB7FF0", VA = "0x182FB8BF0")]
	public static global::EJIEKPGJGCC<CPKDLGGKAMN, LCEIFOGDJKI> EOEOEOFIOCB<TRoot>(TRoot PFMMNJCIGCA, in FHKMEPEOHEF LGKAJJKAMAG) where TRoot : ELAHBOFNDJG
	{
		return default(global::EJIEKPGJGCC<CPKDLGGKAMN, LCEIFOGDJKI>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public readonly struct KLFNGGGEPGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public readonly global::DKJMPNEPOKM<OCKONIONONG> BIIGCAMPPFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public readonly global::DKJMPNEPOKM<OKMKFAGHJMD> DHOAFNEEAOL;

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x83CF20", Offset = "0x83C320", VA = "0x18083CF20")]
	private KLFNGGGEPGP(global::DKJMPNEPOKM<OCKONIONONG> KCFOMBLHMHL, global::DKJMPNEPOKM<OKMKFAGHJMD> APJCGFNBKKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x30C82E0", Offset = "0x30C76E0", VA = "0x1830C82E0")]
	public static global::MDINMLDMAPM<JAFJIJEKPPM, KLFNGGGEPGP> DLOLHCCDOLB(AEPBDBDMJFD LLNEOAHADLL)
	{
		return default(global::MDINMLDMAPM<JAFJIJEKPPM, KLFNGGGEPGP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x2D027D0", Offset = "0x2D01BD0", VA = "0x182D027D0")]
	public static global::EJIEKPGJGCC<CPKDLGGKAMN, LCEIFOGDJKI> EOEOEOFIOCB<TRoot>(TRoot PFMMNJCIGCA, in KLFNGGGEPGP LGKAJJKAMAG) where TRoot : ELAHBOFNDJG
	{
		return default(global::EJIEKPGJGCC<CPKDLGGKAMN, LCEIFOGDJKI>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public readonly struct AHOEELCPMOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public readonly global::DKJMPNEPOKM<OCKONIONONG> BIIGCAMPPFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public readonly global::DKJMPNEPOKM<ABGNIJONLNA> PKOGHIMHMNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public readonly AMPFOPBHEND CKHFCKAMPJM;

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x30B7500", Offset = "0x30B6900", VA = "0x1830B7500")]
	private AHOEELCPMOB(global::DKJMPNEPOKM<OCKONIONONG> KCFOMBLHMHL, global::DKJMPNEPOKM<ABGNIJONLNA> EPFEOJLONBN, in AMPFOPBHEND BICCJELLHLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x30B7370", Offset = "0x30B6770", VA = "0x1830B7370")]
	public static global::MDINMLDMAPM<JAFJIJEKPPM, AHOEELCPMOB> DLOLHCCDOLB(AEPBDBDMJFD LLNEOAHADLL)
	{
		return default(global::MDINMLDMAPM<JAFJIJEKPPM, AHOEELCPMOB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x1A4ED80", Offset = "0x1A4E180", VA = "0x181A4ED80")]
	public static global::EJIEKPGJGCC<CPKDLGGKAMN, LCEIFOGDJKI> EOEOEOFIOCB<TRoot>(TRoot PFMMNJCIGCA, in AHOEELCPMOB LGKAJJKAMAG) where TRoot : ELAHBOFNDJG
	{
		return default(global::EJIEKPGJGCC<CPKDLGGKAMN, LCEIFOGDJKI>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public readonly struct CBBGCMMNFNA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public readonly global::DKJMPNEPOKM<OCKONIONONG> BIIGCAMPPFF;

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0xA20460", Offset = "0xA1F860", VA = "0x180A20460")]
	private CBBGCMMNFNA(global::DKJMPNEPOKM<OCKONIONONG> KCFOMBLHMHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x30B9870", Offset = "0x30B8C70", VA = "0x1830B9870")]
	public static global::MDINMLDMAPM<JAFJIJEKPPM, CBBGCMMNFNA> DLOLHCCDOLB(AEPBDBDMJFD LLNEOAHADLL)
	{
		return default(global::MDINMLDMAPM<JAFJIJEKPPM, CBBGCMMNFNA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x2585E00", Offset = "0x2585200", VA = "0x182585E00")]
	public static global::EJIEKPGJGCC<CPKDLGGKAMN, LCEIFOGDJKI> EOEOEOFIOCB<TRoot>(TRoot PFMMNJCIGCA, in CBBGCMMNFNA LGKAJJKAMAG) where TRoot : ELAHBOFNDJG
	{
		return default(global::EJIEKPGJGCC<CPKDLGGKAMN, LCEIFOGDJKI>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public readonly struct BLBGGPFAAJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public readonly global::DKJMPNEPOKM<OCKONIONONG> BIIGCAMPPFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public readonly global::DKJMPNEPOKM<CALJIOIEBOF> KMMDNILDDDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public readonly global::DKJMPNEPOKM<ABGNIJONLNA> OACDFCKNFCJ;

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x122ECB0", Offset = "0x122E0B0", VA = "0x18122ECB0")]
	private BLBGGPFAAJC(global::DKJMPNEPOKM<OCKONIONONG> KCFOMBLHMHL, global::DKJMPNEPOKM<CALJIOIEBOF> IOIBHMPNOAJ, global::DKJMPNEPOKM<ABGNIJONLNA> OFIEEAIIOOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x30B82E0", Offset = "0x30B76E0", VA = "0x1830B82E0")]
	public static global::MDINMLDMAPM<JAFJIJEKPPM, BLBGGPFAAJC> DLOLHCCDOLB(AEPBDBDMJFD LLNEOAHADLL)
	{
		return default(global::MDINMLDMAPM<JAFJIJEKPPM, BLBGGPFAAJC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x5363720", Offset = "0x5362B20", VA = "0x185363720")]
	public static global::EJIEKPGJGCC<CPKDLGGKAMN, LCEIFOGDJKI> EOEOEOFIOCB<TRoot>(TRoot PFMMNJCIGCA, in BLBGGPFAAJC LGKAJJKAMAG) where TRoot : ELAHBOFNDJG
	{
		return default(global::EJIEKPGJGCC<CPKDLGGKAMN, LCEIFOGDJKI>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public readonly struct EOOECLAFOBC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public readonly global::DKJMPNEPOKM<OCKONIONONG> BIIGCAMPPFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public readonly global::DKJMPNEPOKM<OKMKFAGHJMD> DHOAFNEEAOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public readonly global::DKJMPNEPOKM<OKNKOAHGAAD> KGHHHBKFLPM;

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x122ECB0", Offset = "0x122E0B0", VA = "0x18122ECB0")]
	private EOOECLAFOBC(global::DKJMPNEPOKM<OCKONIONONG> KCFOMBLHMHL, global::DKJMPNEPOKM<OKMKFAGHJMD> APJCGFNBKKN, global::DKJMPNEPOKM<OKNKOAHGAAD> MOLGKKIDLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x30BC9B0", Offset = "0x30BBDB0", VA = "0x1830BC9B0")]
	public static global::MDINMLDMAPM<JAFJIJEKPPM, EOOECLAFOBC> DLOLHCCDOLB(AEPBDBDMJFD LLNEOAHADLL)
	{
		return default(global::MDINMLDMAPM<JAFJIJEKPPM, EOOECLAFOBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x32F48E0", Offset = "0x32F3CE0", VA = "0x1832F48E0")]
	public static global::EJIEKPGJGCC<global::DKJMPNEPOKM<ABGNIJONLNA>, LCEIFOGDJKI> EOEOEOFIOCB<TRoot>(TRoot PFMMNJCIGCA, in EOOECLAFOBC LGKAJJKAMAG) where TRoot : ELAHBOFNDJG
	{
		return default(global::EJIEKPGJGCC<global::DKJMPNEPOKM<ABGNIJONLNA>, LCEIFOGDJKI>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public readonly struct HBJCGMLKCJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public readonly global::DKJMPNEPOKM<OCKONIONONG> BIIGCAMPPFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public readonly global::DKJMPNEPOKM<OKMKFAGHJMD> DHOAFNEEAOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public readonly int HFNIIKPNDOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public readonly MPOJBPPFFEB KEFHMMCGAFE;

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x30BB870", Offset = "0x30BAC70", VA = "0x1830BB870")]
	private HBJCGMLKCJI(global::DKJMPNEPOKM<OCKONIONONG> KCFOMBLHMHL, global::DKJMPNEPOKM<OKMKFAGHJMD> APJCGFNBKKN, int LMOJDDNMLLL, MPOJBPPFFEB ONBHBHIHHNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x30C04E0", Offset = "0x30BF8E0", VA = "0x1830C04E0")]
	public static global::MDINMLDMAPM<JAFJIJEKPPM, HBJCGMLKCJI> DLOLHCCDOLB(AEPBDBDMJFD LLNEOAHADLL)
	{
		return default(global::MDINMLDMAPM<JAFJIJEKPPM, HBJCGMLKCJI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x2CEB200", Offset = "0x2CEA600", VA = "0x182CEB200")]
	public static global::EJIEKPGJGCC<(global::DKJMPNEPOKM<CALJIOIEBOF>, global::DKJMPNEPOKM<ABGNIJONLNA>), LCEIFOGDJKI> EOEOEOFIOCB<TRoot>(TRoot PFMMNJCIGCA, in HBJCGMLKCJI LGKAJJKAMAG) where TRoot : ELAHBOFNDJG
	{
		return default(global::EJIEKPGJGCC<(global::DKJMPNEPOKM<CALJIOIEBOF>, global::DKJMPNEPOKM<ABGNIJONLNA>), LCEIFOGDJKI>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public readonly struct IEMJIMEEOFP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public readonly global::DKJMPNEPOKM<OCKONIONONG> BIIGCAMPPFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public readonly global::DKJMPNEPOKM<OEBIECDILIK> ONENBIKMHPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public readonly OBHBJAMPCFH EFLKGNHAIEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public readonly PGFGIJOBBDI EPEMEPHGANB;

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x30C21B0", Offset = "0x30C15B0", VA = "0x1830C21B0")]
	private IEMJIMEEOFP(global::DKJMPNEPOKM<OCKONIONONG> KCFOMBLHMHL, global::DKJMPNEPOKM<OEBIECDILIK> MCAKKMALFFJ, in OBHBJAMPCFH NNBLDLKGAFO, in PGFGIJOBBDI NEHFKENDHBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x30C1FF0", Offset = "0x30C13F0", VA = "0x1830C1FF0")]
	public static global::MDINMLDMAPM<JAFJIJEKPPM, IEMJIMEEOFP> DLOLHCCDOLB(AEPBDBDMJFD LLNEOAHADLL)
	{
		return default(global::MDINMLDMAPM<JAFJIJEKPPM, IEMJIMEEOFP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x29BA510", Offset = "0x29B9910", VA = "0x1829BA510")]
	public static global::EJIEKPGJGCC<global::DKJMPNEPOKM<OKMKFAGHJMD>, LCEIFOGDJKI> EOEOEOFIOCB<TRoot>(TRoot PFMMNJCIGCA, in IEMJIMEEOFP LGKAJJKAMAG) where TRoot : ELAHBOFNDJG
	{
		return default(global::EJIEKPGJGCC<global::DKJMPNEPOKM<OKMKFAGHJMD>, LCEIFOGDJKI>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public sealed class LNMBFOLCKEH : LPMADMJNEAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public readonly global::DKJMPNEPOKM<OKNKOAHGAAD> LKDLHIMPNKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public readonly global::DKJMPNEPOKM<INJKENCKFDO> JNJOBIDBJHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public readonly global::DKJMPNEPOKM<INJKENCKFDO> KNDNEOIJJEL;

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x30C9D60", Offset = "0x30C9160", VA = "0x1830C9D60")]
	public LNMBFOLCKEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public sealed class LODLIKLDIMO : KGGFOLFDMDE
{
	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x30CA070", Offset = "0x30C9470", VA = "0x1830CA070")]
	public LODLIKLDIMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public sealed class IEMPNEJNODN : BODNFBLCKNB
{
	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "11")]
	public override void MCDKCEHBHAE(KAGFALJBAED PIOOALFEPLN, global::DKJMPNEPOKM<OCKONIONONG> KCFOMBLHMHL, global::DKJMPNEPOKM<OKMKFAGHJMD> APJCGFNBKKN, ref IPNMOJMODML GFNGCDOBHLO, global::DKJMPNEPOKM<FLNBNCMIPDD.AKEOEMFDKLF>? JJDHDIBCHME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "12")]
	public override void PELFLJOKLFE(KAGFALJBAED PIOOALFEPLN, global::DKJMPNEPOKM<OCKONIONONG> KCFOMBLHMHL, global::DKJMPNEPOKM<OKMKFAGHJMD> APJCGFNBKKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x30C21E0", Offset = "0x30C15E0", VA = "0x1830C21E0", Slot = "13")]
	public override IEnumerable<global::POIAGICJKGN<NDNLPFJBKCL>> BIGKGEGCOPC(KAGFALJBAED PIOOALFEPLN, global::DKJMPNEPOKM<OCKONIONONG> KCFOMBLHMHL, global::DKJMPNEPOKM<OKMKFAGHJMD> APJCGFNBKKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x30C2210", Offset = "0x30C1610", VA = "0x1830C2210", Slot = "14")]
	public override void GOIHDGKHGIC(KAGFALJBAED PIOOALFEPLN, global::DKJMPNEPOKM<OCKONIONONG> KCFOMBLHMHL, global::DKJMPNEPOKM<OKMKFAGHJMD> APJCGFNBKKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x30C23D0", Offset = "0x30C17D0", VA = "0x1830C23D0")]
	public static void NNBMMCAADJN(KAGFALJBAED PIOOALFEPLN, in NNBAOEOICPP.KPGMHEBILDJ KBDCOEIPIKP, global::DKJMPNEPOKM<OCKONIONONG> KCFOMBLHMHL, global::DKJMPNEPOKM<ABGNIJONLNA> EPFEOJLONBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x30C14F0", Offset = "0x30C08F0", VA = "0x1830C14F0", Slot = "15")]
	public override AMPFOPBHEND BBNFCFGBACN(KAGFALJBAED PIOOALFEPLN, global::DKJMPNEPOKM<OCKONIONONG> KCFOMBLHMHL, global::DKJMPNEPOKM<OKMKFAGHJMD> APJCGFNBKKN, global::DKJMPNEPOKM<OKNKOAHGAAD> MOLGKKIDLCP, NDNLPFJBKCL IEOAAOPIPBF)
	{
		return default(AMPFOPBHEND);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x30B8630", Offset = "0x30B7A30", VA = "0x1830B8630")]
	public IEMPNEJNODN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public struct AGOAPGGKIMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public OBHBJAMPCFH EFLKGNHAIEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public PGFGIJOBBDI EPEMEPHGANB;

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x30B7350", Offset = "0x30B6750", VA = "0x1830B7350")]
	internal AGOAPGGKIMM(in OBHBJAMPCFH NADLKJKLONK, in PGFGIJOBBDI OGPILFJIIKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x30B7320", Offset = "0x30B6720", VA = "0x1830B7320")]
	public static AGOAPGGKIMM FHHJOGLDILM()
	{
		return default(AGOAPGGKIMM);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x30B7300", Offset = "0x30B6700", VA = "0x1830B7300")]
	public static AGOAPGGKIMM BLNNEJAOMLE(in OBHBJAMPCFH NADLKJKLONK, in PGFGIJOBBDI OGPILFJIIKI)
	{
		return default(AGOAPGGKIMM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public abstract class BODNFBLCKNB : global::LHAIPNCGIPP<KAGFALJBAED>
{
	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x30B8630", Offset = "0x30B7A30", VA = "0x1830B8630")]
	protected BODNFBLCKNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public sealed class HNOGGKFEPMI : BODNFBLCKNB
{
	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "11")]
	public override void MCDKCEHBHAE(KAGFALJBAED PIOOALFEPLN, global::DKJMPNEPOKM<OCKONIONONG> KCFOMBLHMHL, global::DKJMPNEPOKM<OKMKFAGHJMD> APJCGFNBKKN, ref IPNMOJMODML GFNGCDOBHLO, global::DKJMPNEPOKM<FLNBNCMIPDD.AKEOEMFDKLF>? JJDHDIBCHME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "12")]
	public override void PELFLJOKLFE(KAGFALJBAED PIOOALFEPLN, global::DKJMPNEPOKM<OCKONIONONG> KCFOMBLHMHL, global::DKJMPNEPOKM<OKMKFAGHJMD> APJCGFNBKKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x30C1570", Offset = "0x30C0970", VA = "0x1830C1570", Slot = "13")]
	public override IEnumerable<global::POIAGICJKGN<NDNLPFJBKCL>> BIGKGEGCOPC(KAGFALJBAED PIOOALFEPLN, global::DKJMPNEPOKM<OCKONIONONG> KCFOMBLHMHL, global::DKJMPNEPOKM<OKMKFAGHJMD> APJCGFNBKKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x30C15A0", Offset = "0x30C09A0", VA = "0x1830C15A0", Slot = "14")]
	public override void GOIHDGKHGIC(KAGFALJBAED PIOOALFEPLN, global::DKJMPNEPOKM<OCKONIONONG> KCFOMBLHMHL, global::DKJMPNEPOKM<OKMKFAGHJMD> APJCGFNBKKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x30C1760", Offset = "0x30C0B60", VA = "0x1830C1760")]
	public static void MELIFFGJIAM(KAGFALJBAED PIOOALFEPLN, in NNBAOEOICPP.KPGMHEBILDJ KBDCOEIPIKP, global::DKJMPNEPOKM<OCKONIONONG> KCFOMBLHMHL, global::DKJMPNEPOKM<CALJIOIEBOF> GKCJDBECCFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x30C14F0", Offset = "0x30C08F0", VA = "0x1830C14F0", Slot = "15")]
	public override AMPFOPBHEND BBNFCFGBACN(KAGFALJBAED PIOOALFEPLN, global::DKJMPNEPOKM<OCKONIONONG> KCFOMBLHMHL, global::DKJMPNEPOKM<OKMKFAGHJMD> APJCGFNBKKN, global::DKJMPNEPOKM<OKNKOAHGAAD> MOLGKKIDLCP, NDNLPFJBKCL IEOAAOPIPBF)
	{
		return default(AMPFOPBHEND);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x30B8630", Offset = "0x30B7A30", VA = "0x1830B8630")]
	public HNOGGKFEPMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public sealed class COINMCBNNPG : DGAJDLJLENB
{
	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x30BA500", Offset = "0x30B9900", VA = "0x1830BA500")]
	public COINMCBNNPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public sealed class JPBMGFGKMMM : DGAJDLJLENB
{
	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x30C3BA0", Offset = "0x30C2FA0", VA = "0x1830C3BA0")]
	public JPBMGFGKMMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public sealed class OAIBBJBDILL : BODNFBLCKNB
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public sealed class NGPDDOFJBHM : AHFKNOPHOCE.MGBBAKOIECA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public struct CAOOCHGIIPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public readonly global::DKJMPNEPOKM<OCKONIONONG> FMCGGHIIDNM;

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0xA20460", Offset = "0xA1F860", VA = "0x180A20460")]
		private CAOOCHGIIPE(global::DKJMPNEPOKM<OCKONIONONG> PKBMEDGGFMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xB46270", Offset = "0xB45670", VA = "0x180B46270")]
		public static CAOOCHGIIPE FHHJOGLDILM(global::DKJMPNEPOKM<OCKONIONONG> MNENIKJPBKO)
		{
			return default(CAOOCHGIIPE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x30D4E90", Offset = "0x30D4290", VA = "0x1830D4E90", Slot = "11")]
	public override void MCDKCEHBHAE(KAGFALJBAED PIOOALFEPLN, global::DKJMPNEPOKM<OCKONIONONG> KCFOMBLHMHL, global::DKJMPNEPOKM<OKMKFAGHJMD> APJCGFNBKKN, ref IPNMOJMODML GFNGCDOBHLO, global::DKJMPNEPOKM<FLNBNCMIPDD.AKEOEMFDKLF>? JJDHDIBCHME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x30D51D0", Offset = "0x30D45D0", VA = "0x1830D51D0", Slot = "12")]
	public override void PELFLJOKLFE(KAGFALJBAED PIOOALFEPLN, global::DKJMPNEPOKM<OCKONIONONG> KCFOMBLHMHL, global::DKJMPNEPOKM<OKMKFAGHJMD> APJCGFNBKKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x30D4A90", Offset = "0x30D3E90", VA = "0x1830D4A90", Slot = "13")]
	public override IEnumerable<global::POIAGICJKGN<NDNLPFJBKCL>> BIGKGEGCOPC(KAGFALJBAED PIOOALFEPLN, global::DKJMPNEPOKM<OCKONIONONG> KCFOMBLHMHL, global::DKJMPNEPOKM<OKMKFAGHJMD> APJCGFNBKKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x30D4B50", Offset = "0x30D3F50", VA = "0x1830D4B50", Slot = "14")]
	public override void GOIHDGKHGIC(KAGFALJBAED PIOOALFEPLN, global::DKJMPNEPOKM<OCKONIONONG> KCFOMBLHMHL, global::DKJMPNEPOKM<OKMKFAGHJMD> APJCGFNBKKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x30D50F0", Offset = "0x30D44F0", VA = "0x1830D50F0")]
	public static void NNBMMCAADJN(KAGFALJBAED PIOOALFEPLN, in NNBAOEOICPP.KPGMHEBILDJ KBDCOEIPIKP, global::DKJMPNEPOKM<OCKONIONONG> KCFOMBLHMHL, global::DKJMPNEPOKM<ABGNIJONLNA> EPFEOJLONBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x30D5010", Offset = "0x30D4410", VA = "0x1830D5010")]
	public static void MELIFFGJIAM(KAGFALJBAED PIOOALFEPLN, in NNBAOEOICPP.KPGMHEBILDJ KBDCOEIPIKP, global::DKJMPNEPOKM<OCKONIONONG> KCFOMBLHMHL, global::DKJMPNEPOKM<CALJIOIEBOF> GKCJDBECCFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x30C14F0", Offset = "0x30C08F0", VA = "0x1830C14F0", Slot = "15")]
	public override AMPFOPBHEND BBNFCFGBACN(KAGFALJBAED PIOOALFEPLN, global::DKJMPNEPOKM<OCKONIONONG> KCFOMBLHMHL, global::DKJMPNEPOKM<OKMKFAGHJMD> APJCGFNBKKN, global::DKJMPNEPOKM<OKNKOAHGAAD> MOLGKKIDLCP, NDNLPFJBKCL IEOAAOPIPBF)
	{
		return default(AMPFOPBHEND);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x30B8630", Offset = "0x30B7A30", VA = "0x1830B8630")]
	public OAIBBJBDILL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public abstract class LPMADMJNEAD : global::PMJHALOHEPJ<KAGFALJBAED>
{
	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x30C7970", Offset = "0x30C6D70", VA = "0x1830C7970")]
	protected LPMADMJNEAD(in IPOJJJFNMDI PNKHBPLLHEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x30CA350", Offset = "0x30C9750", VA = "0x1830CA350", Slot = "11")]
	public override void MCDKCEHBHAE(KAGFALJBAED PFMMNJCIGCA, global::DKJMPNEPOKM<OCKONIONONG> KCFOMBLHMHL, global::DKJMPNEPOKM<OKMKFAGHJMD> APJCGFNBKKN, ref IPNMOJMODML GFNGCDOBHLO, global::DKJMPNEPOKM<FLNBNCMIPDD.AKEOEMFDKLF>? JJDHDIBCHME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x30CA2D0", Offset = "0x30C96D0", VA = "0x1830CA2D0", Slot = "14")]
	public override void GOIHDGKHGIC(KAGFALJBAED PFMMNJCIGCA, global::DKJMPNEPOKM<OCKONIONONG> KCFOMBLHMHL, global::DKJMPNEPOKM<OKMKFAGHJMD> APJCGFNBKKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public abstract class KGGFOLFDMDE : LPMADMJNEAD
{
	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x30C7970", Offset = "0x30C6D70", VA = "0x1830C7970")]
	public KGGFOLFDMDE(in IPOJJJFNMDI PNKHBPLLHEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public abstract class DGAJDLJLENB : global::EFELDPDFLKD<KAGFALJBAED>
{
	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x30BBBA0", Offset = "0x30BAFA0", VA = "0x1830BBBA0")]
	protected DGAJDLJLENB(in FJNDNFHBLLC PNKHBPLLHEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x30BBA60", Offset = "0x30BAE60", VA = "0x1830BBA60", Slot = "11")]
	public override void MCDKCEHBHAE(KAGFALJBAED PFMMNJCIGCA, global::DKJMPNEPOKM<OCKONIONONG> KCFOMBLHMHL, global::DKJMPNEPOKM<OKMKFAGHJMD> APJCGFNBKKN, ref IPNMOJMODML GFNGCDOBHLO, global::DKJMPNEPOKM<FLNBNCMIPDD.AKEOEMFDKLF>? JJDHDIBCHME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x30BBB10", Offset = "0x30BAF10", VA = "0x1830BBB10", Slot = "12")]
	public override void PELFLJOKLFE(KAGFALJBAED PFMMNJCIGCA, global::DKJMPNEPOKM<OCKONIONONG> KCFOMBLHMHL, global::DKJMPNEPOKM<OKMKFAGHJMD> APJCGFNBKKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x30BB9E0", Offset = "0x30BADE0", VA = "0x1830BB9E0", Slot = "14")]
	public override void GOIHDGKHGIC(KAGFALJBAED PFMMNJCIGCA, global::DKJMPNEPOKM<OCKONIONONG> KCFOMBLHMHL, global::DKJMPNEPOKM<OKMKFAGHJMD> APJCGFNBKKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x30BB890", Offset = "0x30BAC90", VA = "0x1830BB890", Slot = "17")]
	public override global::EJIEKPGJGCC<global::DKJMPNEPOKM<ABGNIJONLNA>, LCEIFOGDJKI> CGBJFNKBBID(KAGFALJBAED PFMMNJCIGCA, global::DKJMPNEPOKM<OCKONIONONG> KCFOMBLHMHL, global::DKJMPNEPOKM<OKMKFAGHJMD> APJCGFNBKKN, global::DKJMPNEPOKM<OKNKOAHGAAD> MOLGKKIDLCP)
	{
		return default(global::EJIEKPGJGCC<global::DKJMPNEPOKM<ABGNIJONLNA>, LCEIFOGDJKI>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public readonly struct GEDDPNMNCHM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly Guid KEMHDFCKPLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private readonly string ODEEAIJDPBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly bool MOAGADOHDNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private readonly bool LLEPFLPGHCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private readonly bool JPIALHHHOKJ;

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x30BED70", Offset = "0x30BE170", VA = "0x1830BED70")]
	public GEDDPNMNCHM(in Guid IDFOGLKIIHM, string LMAOKJPAKEM, bool EMIDGPLAJHB, bool GGALMODHAAB, bool NDOJGMMPFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x30BEAB0", Offset = "0x30BDEB0", VA = "0x1830BEAB0")]
	public LAGPFMDFEDN AAHLMDEPBNJ(string LMAOKJPAKEM, NDNLPFJBKCL ONBHBHIHHNE)
	{
		return default(LAGPFMDFEDN);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x30BEC80", Offset = "0x30BE080", VA = "0x1830BEC80")]
	public GNEJCPOKIPD HBCAHGJIHFL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public abstract class EHCEMGKDEHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public readonly NDNLPFJBKCL LGMHFKOMDCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private readonly List<GNEJCPOKIPD> DOOMEHCDOGE;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public IReadOnlyList<GNEJCPOKIPD> COBLCHJEHFD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x30BC8A0", Offset = "0x30BBCA0", VA = "0x1830BC8A0")]
	protected EHCEMGKDEHB(NDNLPFJBKCL FNCNPKJDNAD, params GNEJCPOKIPD[][] AKPKIFJKKIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class KCBEMFMGDFH : EHCEMGKDEHB
{
	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x30C7310", Offset = "0x30C6710", VA = "0x1830C7310")]
	internal KCBEMFMGDFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class BLHLBBBNMGF : EHCEMGKDEHB
{
	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x30B8410", Offset = "0x30B7810", VA = "0x1830B8410")]
	internal BLHLBBBNMGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class KEIFAOBGAFN : EHCEMGKDEHB
{
	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x30C7530", Offset = "0x30C6930", VA = "0x1830C7530")]
	internal KEIFAOBGAFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class DPFAIODJNDA : EHCEMGKDEHB
{
	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x30BBBF0", Offset = "0x30BAFF0", VA = "0x1830BBBF0")]
	internal DPFAIODJNDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public class ECFJPHEFHAB : EHCEMGKDEHB
{
	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x30BC240", Offset = "0x30BB640", VA = "0x1830BC240")]
	internal ECFJPHEFHAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class JAAKFKKBCEA : EHCEMGKDEHB
{
	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x30C2BF0", Offset = "0x30C1FF0", VA = "0x1830C2BF0")]
	internal JAAKFKKBCEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public class LCCBCMLKJIB : EHCEMGKDEHB
{
	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x30C8700", Offset = "0x30C7B00", VA = "0x1830C8700")]
	internal LCCBCMLKJIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public class IHJIJIBNCPP : EHCEMGKDEHB
{
	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x30C24D0", Offset = "0x30C18D0", VA = "0x1830C24D0")]
	internal IHJIJIBNCPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public class ODOCBLPGABJ : EHCEMGKDEHB
{
	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x30D5300", Offset = "0x30D4700", VA = "0x1830D5300")]
	internal ODOCBLPGABJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class AJGMGOOIFDI : EHCEMGKDEHB
{
	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x30B7530", Offset = "0x30B6930", VA = "0x1830B7530")]
	internal AJGMGOOIFDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class HBKPGLCGFAD : EHCEMGKDEHB
{
	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x30C06D0", Offset = "0x30BFAD0", VA = "0x1830C06D0")]
	internal HBKPGLCGFAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class MDIEJMGKGBM : EHCEMGKDEHB
{
	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x30CABC0", Offset = "0x30C9FC0", VA = "0x1830CABC0")]
	internal MDIEJMGKGBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class KELNBOLMMLI : EHCEMGKDEHB
{
	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x30C7750", Offset = "0x30C6B50", VA = "0x1830C7750")]
	internal KELNBOLMMLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class MJMAMIMALJI : EHCEMGKDEHB
{
	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x30CBEB0", Offset = "0x30CB2B0", VA = "0x1830CBEB0")]
	internal MJMAMIMALJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public class KHKFNCEPDDI : EHCEMGKDEHB
{
	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x30C7E00", Offset = "0x30C7200", VA = "0x1830C7E00")]
	internal KHKFNCEPDDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public class JHPOCEEKKDA : EHCEMGKDEHB
{
	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x30C3320", Offset = "0x30C2720", VA = "0x1830C3320")]
	internal JHPOCEEKKDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public class CKIHLMKIFLA : EHCEMGKDEHB
{
	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x30B9F80", Offset = "0x30B9380", VA = "0x1830B9F80")]
	internal CKIHLMKIFLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public class DBBGAEKOICA : EHCEMGKDEHB
{
	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x30BAE90", Offset = "0x30BA290", VA = "0x1830BAE90")]
	internal DBBGAEKOICA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public class LFGLMKMNPPA : EHCEMGKDEHB
{
	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x30C8920", Offset = "0x30C7D20", VA = "0x1830C8920")]
	internal LFGLMKMNPPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public class NPOPJOILCOA : EHCEMGKDEHB
{
	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x30D47E0", Offset = "0x30D3BE0", VA = "0x1830D47E0")]
	internal NPOPJOILCOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public class DEAEPFCFGHE : EHCEMGKDEHB
{
	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x30BB460", Offset = "0x30BA860", VA = "0x1830BB460")]
	internal DEAEPFCFGHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public class OLLCEBMMGHD : EHCEMGKDEHB
{
	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x30D5660", Offset = "0x30D4A60", VA = "0x1830D5660")]
	internal OLLCEBMMGHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public class MFNECKGMEAC : EHCEMGKDEHB
{
	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x30CADE0", Offset = "0x30CA1E0", VA = "0x1830CADE0")]
	internal MFNECKGMEAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public class PCLMMPELHML : EHCEMGKDEHB
{
	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x30D5BD0", Offset = "0x30D4FD0", VA = "0x1830D5BD0")]
	internal PCLMMPELHML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public class GMKCFGHFJBL : EHCEMGKDEHB
{
	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x30BF9F0", Offset = "0x30BEDF0", VA = "0x1830BF9F0")]
	internal GMKCFGHFJBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public class KICCHGPCFIE : EHCEMGKDEHB
{
	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x30C80C0", Offset = "0x30C74C0", VA = "0x1830C80C0")]
	internal KICCHGPCFIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public class JHFFGDOBIAH : EHCEMGKDEHB
{
	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x30C3100", Offset = "0x30C2500", VA = "0x1830C3100")]
	internal JHFFGDOBIAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public class CCFDBJMHMBP : EHCEMGKDEHB
{
	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x30B9900", Offset = "0x30B8D00", VA = "0x1830B9900")]
	internal CCFDBJMHMBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public class GGLNHKOBAFM : EHCEMGKDEHB
{
	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x30BEFE0", Offset = "0x30BE3E0", VA = "0x1830BEFE0")]
	internal GGLNHKOBAFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public class JNMMJONPKNE : EHCEMGKDEHB
{
	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x30C3980", Offset = "0x30C2D80", VA = "0x1830C3980")]
	internal JNMMJONPKNE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public class KHDKMAHFILM : EHCEMGKDEHB
{
	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x30C7BE0", Offset = "0x30C6FE0", VA = "0x1830C7BE0")]
	internal KHDKMAHFILM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public class MCCHHOFIDKF : EHCEMGKDEHB
{
	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x30CA9A0", Offset = "0x30C9DA0", VA = "0x1830CA9A0")]
	internal MCCHHOFIDKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public class IDEIJNHOOKC : EHCEMGKDEHB
{
	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x30C1DD0", Offset = "0x30C11D0", VA = "0x1830C1DD0")]
	internal IDEIJNHOOKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public class EDNEMFMHIAM : EHCEMGKDEHB
{
	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x30BC460", Offset = "0x30BB860", VA = "0x1830BC460")]
	internal EDNEMFMHIAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public class KGGPKHBPPKD : EHCEMGKDEHB
{
	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x30C79C0", Offset = "0x30C6DC0", VA = "0x1830C79C0")]
	internal KGGPKHBPPKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public class HCJMMNFBADM : EHCEMGKDEHB
{
	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x30C08F0", Offset = "0x30BFCF0", VA = "0x1830C08F0")]
	internal HCJMMNFBADM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public class JIHHAJBIJIL : EHCEMGKDEHB
{
	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x30C3540", Offset = "0x30C2940", VA = "0x1830C3540")]
	internal JIHHAJBIJIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public class EEPOIHEKOAL : EHCEMGKDEHB
{
	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x30BC680", Offset = "0x30BBA80", VA = "0x1830BC680")]
	internal EEPOIHEKOAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public class PACIEKECPJN : EHCEMGKDEHB
{
	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x30D59B0", Offset = "0x30D4DB0", VA = "0x1830D59B0")]
	internal PACIEKECPJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public class JILIJJCDLBJ : EHCEMGKDEHB
{
	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x30C3760", Offset = "0x30C2B60", VA = "0x1830C3760")]
	internal JILIJJCDLBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public class GNEJCPOKIPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private readonly Guid KEMHDFCKPLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public readonly bool MHGDMHDLONL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public readonly bool JGKCIBKOIHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public readonly bool BNKCGMLAOHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private readonly List<(string Name, NDNLPFJBKCL Type)> GOALCIJIEEJ;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public Guid JNDLCCECDFA
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x30C0030", Offset = "0x30BF430", VA = "0x1830C0030")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public string EKGMLAPMPFM
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x855AE0", Offset = "0x854EE0", VA = "0x180855AE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x855AF0", Offset = "0x854EF0", VA = "0x180855AF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public IReadOnlyList<(string Name, NDNLPFJBKCL Type)> KBJPHEBHIAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x7F1280", Offset = "0x7F0680", VA = "0x1807F1280")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action LOCIIDDNKNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x30BFE70", Offset = "0x30BF270", VA = "0x1830BFE70")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x30BFF10", Offset = "0x30BF310", VA = "0x1830BFF10")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<string, NDNLPFJBKCL> GDNKONNILOC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x30BFD30", Offset = "0x30BF130", VA = "0x1830BFD30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x30BFC90", Offset = "0x30BF090", VA = "0x1830BFC90")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<int> NAHEJGLBPJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x30C01A0", Offset = "0x30BF5A0", VA = "0x1830C01A0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x30C0240", Offset = "0x30BF640", VA = "0x1830C0240")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action NGBNHMLNOEI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x30C0100", Offset = "0x30BF500", VA = "0x1830C0100")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x30BFDD0", Offset = "0x30BF1D0", VA = "0x1830BFDD0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x16A7810", Offset = "0x16A6C10", VA = "0x1816A7810")]
	public void LDIACBBEBBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x30C0410", Offset = "0x30BF810", VA = "0x1830C0410")]
	internal GNEJCPOKIPD(in Guid IDFOGLKIIHM, string LMAOKJPAKEM, bool EMIDGPLAJHB, bool GGALMODHAAB, bool NDOJGMMPFFL, List<(string Name, NDNLPFJBKCL Type)> AGMGCGCFFFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x30BFC10", Offset = "0x30BF010", VA = "0x1830BFC10")]
	public static GEDDPNMNCHM CAOFKEAGCCG(string IDFOGLKIIHM, string LMAOKJPAKEM, bool EMIDGPLAJHB = false, bool GGALMODHAAB = false, bool NDOJGMMPFFL = false)
	{
		return default(GEDDPNMNCHM);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x30C0040", Offset = "0x30BF440", VA = "0x1830C0040")]
	public static GNEJCPOKIPD HNENCCENKCM(in Guid IDFOGLKIIHM, string LMAOKJPAKEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x30C03B0", Offset = "0x30BF7B0", VA = "0x1830C03B0")]
	public void NDCMPKLLPAI(string LMAOKJPAKEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x30C02E0", Offset = "0x30BF6E0", VA = "0x1830C02E0")]
	public void MHIMBJGLJNC(string LMAOKJPAKEM, NDNLPFJBKCL NHDKFKNFJNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x30BFFB0", Offset = "0x30BF3B0", VA = "0x1830BFFB0")]
	public void HIPDOHNOMOK(int CJOLACIBAJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public readonly struct LAGPFMDFEDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private readonly Guid KEMHDFCKPLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private readonly string ODEEAIJDPBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private readonly bool MOAGADOHDNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private readonly bool LLEPFLPGHCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private readonly bool JPIALHHHOKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private readonly List<(string Name, NDNLPFJBKCL Type)> GOALCIJIEEJ;

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x30C8570", Offset = "0x30C7970", VA = "0x1830C8570")]
	public LAGPFMDFEDN(in Guid IDFOGLKIIHM, string LMAOKJPAKEM, bool EMIDGPLAJHB, bool GGALMODHAAB, bool NDOJGMMPFFL, List<(string Name, NDNLPFJBKCL Type)> AGMGCGCFFFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x30C83E0", Offset = "0x30C77E0", VA = "0x1830C83E0")]
	public LAGPFMDFEDN AAHLMDEPBNJ(string LMAOKJPAKEM, NDNLPFJBKCL ONBHBHIHHNE)
	{
		return default(LAGPFMDFEDN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x30C84C0", Offset = "0x30C78C0", VA = "0x1830C84C0")]
	public GNEJCPOKIPD HBCAHGJIHFL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public static class OJEDHOBJBJH
{
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public static class NABMOKLHOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public static readonly GNEJCPOKIPD KDCHOLPNOCL;

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		internal static readonly GNEJCPOKIPD[] GADGMODMDMM;
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public static class NIKHIBLNHJE
	{
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static readonly GNEJCPOKIPD DJDHLNLAOEB;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public static readonly GNEJCPOKIPD NEIGNHDGCCN;

		[Cpp2IlInjected.Token(Token = "0x4000143")]
		internal static readonly GNEJCPOKIPD[] GADGMODMDMM;
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public static class JJLPLLJCMMH
	{
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public static readonly GNEJCPOKIPD NCLAHCFIDEO;

		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public static readonly GNEJCPOKIPD ANGKCJEPGNC;

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		internal static readonly GNEJCPOKIPD[] GADGMODMDMM;
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public static class FIAOGNHPHLH
	{
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public static readonly GNEJCPOKIPD HLKMGKJOIOG;

		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public static readonly GNEJCPOKIPD OAJHJBBODDJ;

		[Cpp2IlInjected.Token(Token = "0x4000149")]
		internal static readonly GNEJCPOKIPD[] GADGMODMDMM;
	}

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public static class GMOHHENFACI
	{
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public static readonly GNEJCPOKIPD DJDHLNLAOEB;

		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public static readonly GNEJCPOKIPD NEIGNHDGCCN;

		[Cpp2IlInjected.Token(Token = "0x400014C")]
		internal static readonly GNEJCPOKIPD[] GADGMODMDMM;
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public static class PENHNCAKCOK
	{
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public static readonly GNEJCPOKIPD OCADCLMFCIE;

		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public static readonly GNEJCPOKIPD KKDLDHJOEBK;

		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public static readonly GNEJCPOKIPD EFLHPEJHIMI;

		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public static readonly GNEJCPOKIPD KOAAMIDMLIA;

		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public static readonly GNEJCPOKIPD ELMEKICNIGB;

		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public static readonly GNEJCPOKIPD MOENJCNGBJD;

		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public static readonly GNEJCPOKIPD JEDGMCNBHBK;

		[Cpp2IlInjected.Token(Token = "0x4000154")]
		internal static readonly GNEJCPOKIPD[] GADGMODMDMM;
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public static class CPKKCHNPDOP
	{
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		internal static readonly GNEJCPOKIPD[] GADGMODMDMM;
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	public static class FDIDGNKCEPI
	{
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		internal static readonly GNEJCPOKIPD[] GADGMODMDMM;
	}

	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	public static class LJLJKLHGAAO
	{
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		internal static readonly GNEJCPOKIPD[] GADGMODMDMM;
	}

	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	public static class CNFOKNFGKKP
	{
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public static readonly GNEJCPOKIPD FBBFGKNELMK;

		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public static readonly GNEJCPOKIPD NPFOGNLPKEI;

		[Cpp2IlInjected.Token(Token = "0x400015A")]
		internal static readonly GNEJCPOKIPD[] GADGMODMDMM;
	}

	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	public static class PPGJJLEEPID
	{
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		internal static readonly GNEJCPOKIPD[] GADGMODMDMM;
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	public static class CKGADNBGLKF
	{
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		internal static readonly GNEJCPOKIPD[] GADGMODMDMM;
	}

	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	public static class OKEKAGJOHMA
	{
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public static readonly GNEJCPOKIPD BFECFAPCKCM;

		[Cpp2IlInjected.Token(Token = "0x400015E")]
		internal static readonly GNEJCPOKIPD[] GADGMODMDMM;
	}

	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	public static class CNDNLAOLDAH
	{
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public static readonly GNEJCPOKIPD POLBNICFNFL;

		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public static readonly GNEJCPOKIPD JJCAGEGMDHJ;

		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public static readonly GNEJCPOKIPD HLKMGKJOIOG;

		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public static readonly GNEJCPOKIPD KOEDCLCFDEG;

		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public static readonly GNEJCPOKIPD OEEKCAFNIEM;

		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public static readonly GNEJCPOKIPD GHODHEGDNML;

		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public static readonly GNEJCPOKIPD KCDGBAELFEK;

		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public static readonly GNEJCPOKIPD AGKLLIDCMEJ;

		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public static readonly GNEJCPOKIPD BAJHFIEIAEA;

		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public static readonly GNEJCPOKIPD INJAACGNAKC;

		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public static readonly GNEJCPOKIPD PKFKEHKIDGL;

		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public static readonly GNEJCPOKIPD JAAFEKBBNFK;

		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public static readonly GNEJCPOKIPD CENGPCCMONJ;

		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public static readonly GNEJCPOKIPD ELHIIAHJJAF;

		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public static readonly GNEJCPOKIPD DMMEPNOGEJE;

		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public static readonly GNEJCPOKIPD HNECGMAOONM;

		[Cpp2IlInjected.Token(Token = "0x400016F")]
		internal static readonly GNEJCPOKIPD[] GADGMODMDMM;
	}

	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	public static class DCOKAKKPDMG
	{
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		internal static readonly GNEJCPOKIPD[] GADGMODMDMM;
	}

	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	public static class DIOHMPFODJO
	{
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public static readonly GNEJCPOKIPD POLBNICFNFL;

		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public static readonly GNEJCPOKIPD FCGABAEKAGL;

		[Cpp2IlInjected.Token(Token = "0x4000173")]
		internal static readonly GNEJCPOKIPD[] GADGMODMDMM;
	}

	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public static class LMPEMECMAAP
	{
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public static readonly GNEJCPOKIPD ANAOMKHMJOE;

		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public static readonly GNEJCPOKIPD MDCKNOMECOH;

		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public static readonly GNEJCPOKIPD JJAPOJIOKIC;

		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public static readonly GNEJCPOKIPD DPLAOAECHPA;

		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public static readonly GNEJCPOKIPD HJIGMOLCLHO;

		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public static readonly GNEJCPOKIPD LEBCJLCANMC;

		[Cpp2IlInjected.Token(Token = "0x400017A")]
		internal static readonly GNEJCPOKIPD[] GADGMODMDMM;
	}

	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	public static class LIPAMBADEMI
	{
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		internal static readonly GNEJCPOKIPD[] GADGMODMDMM;
	}

	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	public static class FHNHKAPLGDK
	{
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public static readonly GNEJCPOKIPD ECLOLNENGFG;

		[Cpp2IlInjected.Token(Token = "0x400017D")]
		internal static readonly GNEJCPOKIPD[] GADGMODMDMM;
	}

	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public static class GPLLODHKHEH
	{
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public static readonly GNEJCPOKIPD BFECFAPCKCM;

		[Cpp2IlInjected.Token(Token = "0x400017F")]
		internal static readonly GNEJCPOKIPD[] GADGMODMDMM;
	}

	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	public static class EJADCKGHIKL
	{
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		internal static readonly GNEJCPOKIPD[] GADGMODMDMM;
	}

	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public static class NACNHJOGAKG
	{
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		internal static readonly GNEJCPOKIPD[] GADGMODMDMM;
	}

	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	public static class FEKNEIKJMHL
	{
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public static readonly GNEJCPOKIPD LLJNOBJNEDP;

		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public static readonly GNEJCPOKIPD DOINJHOKALJ;

		[Cpp2IlInjected.Token(Token = "0x4000184")]
		internal static readonly GNEJCPOKIPD[] GADGMODMDMM;
	}

	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	public static class MDJBNPICPPB
	{
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		internal static readonly GNEJCPOKIPD[] GADGMODMDMM;
	}

	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	public static class NANGGELCMMK
	{
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public static readonly GNEJCPOKIPD NENGCCJBCDC;

		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public static readonly GNEJCPOKIPD ELKIKOOKJOP;

		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public static readonly GNEJCPOKIPD GFFICLNKEGA;

		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public static readonly GNEJCPOKIPD DEDNJNMCLJP;

		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public static readonly GNEJCPOKIPD LDEEPFDPMKI;

		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public static readonly GNEJCPOKIPD GDGPGMNDDEM;

		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public static readonly GNEJCPOKIPD LINCNGPNNKK;

		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public static readonly GNEJCPOKIPD LANAIDIIGND;

		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public static readonly GNEJCPOKIPD CDPCNAFNAPN;

		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public static readonly GNEJCPOKIPD CEGEPLNNDCK;

		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public static readonly GNEJCPOKIPD GKDFCNFEBOC;

		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public static readonly GNEJCPOKIPD BBKGKHKOOHH;

		[Cpp2IlInjected.Token(Token = "0x4000192")]
		internal static readonly GNEJCPOKIPD[] GADGMODMDMM;
	}

	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	public static class OJGDDJDDJLI
	{
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		internal static readonly GNEJCPOKIPD[] GADGMODMDMM;
	}

	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	public static class ANOHOPKJHHE
	{
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		internal static readonly GNEJCPOKIPD[] GADGMODMDMM;
	}

	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	public static class MCBHEBMFBED
	{
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public static readonly GNEJCPOKIPD JLPOEDFJEMJ;

		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public static readonly GNEJCPOKIPD ILKCDMDAKPK;

		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public static readonly GNEJCPOKIPD GKDFCNFEBOC;

		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public static readonly GNEJCPOKIPD BBKGKHKOOHH;

		[Cpp2IlInjected.Token(Token = "0x4000199")]
		internal static readonly GNEJCPOKIPD[] GADGMODMDMM;
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public static class DIBJPFLHIJN
	{
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		internal static readonly GNEJCPOKIPD[] GADGMODMDMM;
	}

	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	public static class GBOHOJKNJAM
	{
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		internal static readonly GNEJCPOKIPD[] GADGMODMDMM;
	}

	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	public static class EEBJBICOLPP
	{
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		internal static readonly GNEJCPOKIPD[] GADGMODMDMM;
	}

	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public static class IAHKDKHNFNK
	{
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		internal static readonly GNEJCPOKIPD[] GADGMODMDMM;
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public static class HKHKDEFPDAI
	{
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public static readonly GNEJCPOKIPD FBBFGKNELMK;

		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public static readonly GNEJCPOKIPD NPFOGNLPKEI;

		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		internal static readonly GNEJCPOKIPD[] GADGMODMDMM;
	}

	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	public static class JMNJEMLDJGL
	{
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public static readonly GNEJCPOKIPD ONDEMEPECCO;

		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public static readonly GNEJCPOKIPD KHNKFNIFDOC;

		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public static readonly GNEJCPOKIPD EPEBEFCAEGH;

		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public static readonly GNEJCPOKIPD CAOMKMGAEMG;

		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		internal static readonly GNEJCPOKIPD[] GADGMODMDMM;
	}

	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	public static class IKHNKBJFOOD
	{
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public static readonly GNEJCPOKIPD ONDEMEPECCO;

		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public static readonly GNEJCPOKIPD KHNKFNIFDOC;

		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public static readonly GNEJCPOKIPD EPEBEFCAEGH;

		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public static readonly GNEJCPOKIPD CAOMKMGAEMG;

		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		internal static readonly GNEJCPOKIPD[] GADGMODMDMM;
	}

	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	public static class OAGIDKHNEKD
	{
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		internal static readonly GNEJCPOKIPD[] GADGMODMDMM;
	}

	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	public static class NPDMDLBIJBC
	{
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		internal static readonly GNEJCPOKIPD[] GADGMODMDMM;
	}

	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	public static class LAALBCCIEKC
	{
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public static readonly GNEJCPOKIPD EOAGKPBBOLO;

		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		internal static readonly GNEJCPOKIPD[] GADGMODMDMM;
	}

	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	public static class ABOCFKEILII
	{
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public static readonly GNEJCPOKIPD GGIFGKOAPOO;

		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public static readonly GNEJCPOKIPD JNMBAACLMKO;

		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public static readonly GNEJCPOKIPD PKHACPKFGEA;

		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		internal static readonly GNEJCPOKIPD[] GADGMODMDMM;
	}

	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	public static class DMMMLAKJMOG
	{
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		internal static readonly GNEJCPOKIPD[] GADGMODMDMM;
	}

	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	public static class FGICLANFDLK
	{
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		internal static readonly GNEJCPOKIPD[] GADGMODMDMM;
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
