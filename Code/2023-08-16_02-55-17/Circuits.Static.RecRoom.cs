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
		[Cpp2IlInjected.Address(RVA = "0x7E5080", Offset = "0x7E4280", VA = "0x1807E5080")]
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
		[Cpp2IlInjected.Address(RVA = "0x22C4E10", Offset = "0x22C4010", VA = "0x1822C4E10")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7E3190", Offset = "0x7E2390", VA = "0x1807E3190")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x17C7540", Offset = "0x17C6740", VA = "0x1817C7540")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct DFIKBEOPGKC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct OFHEJOOKKMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public HOGMOCHAFIO<GHMFAIJCADA> JACBNPAHKEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public HOGMOCHAFIO<GHMFAIJCADA> LFABDNENNGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public HOGMOCHAFIO<GHMFAIJCADA> NNIIOEOKFNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public HOGMOCHAFIO<GHMFAIJCADA> FODJCHAFIBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public HOGMOCHAFIO<GHMFAIJCADA> IGAELABENPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public HOGMOCHAFIO<GHMFAIJCADA> IPFGCJOJDKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public HOGMOCHAFIO<GHMFAIJCADA> NDHAIHNLBPI;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x22C5200", Offset = "0x22C4400", VA = "0x1822C5200")]
		public static OFHEJOOKKMK HBHNAKPOBBF(EJHGAEBODLP<CCOHKDMNIBE> MFFDAOAAOBC)
		{
			return default(OFHEJOOKKMK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface EMKIGOOGJFE
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		BDPICEDJANI DFOGAIJPMIA
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class LHGIGOEGEDC
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class JIJPAIOEPKB : IEnumerable<DOHCCNMLPPO>, IEnumerable, IEnumerator<DOHCCNMLPPO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private DOHCCNMLPPO <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private bool includeBeta;

			[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public bool <>3__includeBeta;

			[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private bool includeStudio;

			[Cpp2IlInjected.FieldOffset(Offset = "0x27")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public bool <>3__includeStudio;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private bool isDeveloper;

			[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public bool <>3__isDeveloper;

			[Cpp2IlInjected.Token(Token = "0x17000054")]
			private DOHCCNMLPPO System.Collections.Generic.IEnumerator<Circuits.Static.Core.TypeSystem.CircuitType>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600006E")]
				[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000055")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xA122A0", Offset = "0xA114A0", VA = "0x180A122A0")]
			[DebuggerHidden]
			public JIJPAIOEPKB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x6DAA210", Offset = "0x6DA9410", VA = "0x186DAA210", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x6DAC9C0", Offset = "0x6DABBC0", VA = "0x186DAC9C0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x6DAC910", Offset = "0x6DABB10", VA = "0x186DAC910", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<DOHCCNMLPPO> System.Collections.Generic.IEnumerable<Circuits.Static.Core.TypeSystem.CircuitType>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x6DAC910", Offset = "0x6DABB10", VA = "0x186DAC910", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class IFFHEAEPABO : IEnumerable<DOHCCNMLPPO>, IEnumerable, IEnumerator<DOHCCNMLPPO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private DOHCCNMLPPO <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private bool includeExec;

			[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public bool <>3__includeExec;

			[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			private bool includeBeta;

			[Cpp2IlInjected.FieldOffset(Offset = "0x27")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public bool <>3__includeBeta;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private bool includeStudio;

			[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public bool <>3__includeStudio;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private bool isDeveloper;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public bool <>3__isDeveloper;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			private IEnumerator<DOHCCNMLPPO> <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private DOHCCNMLPPO <circuitType>5__2;

			[Cpp2IlInjected.Token(Token = "0x17000056")]
			private DOHCCNMLPPO System.Collections.Generic.IEnumerator<Circuits.Static.Core.TypeSystem.CircuitType>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000057")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xA122A0", Offset = "0xA114A0", VA = "0x180A122A0")]
			[DebuggerHidden]
			public IFFHEAEPABO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x6DA99D0", Offset = "0x6DA8BD0", VA = "0x186DA99D0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x6DA94D0", Offset = "0x6DA86D0", VA = "0x186DA94D0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x6DA9410", Offset = "0x6DA8610", VA = "0x186DA9410")]
			private void DNBEPMOBGPK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x6DA9990", Offset = "0x6DA8B90", VA = "0x186DA9990", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x6DA98E0", Offset = "0x6DA8AE0", VA = "0x186DA98E0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<DOHCCNMLPPO> System.Collections.Generic.IEnumerable<Circuits.Static.Core.TypeSystem.CircuitType>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x6DA98E0", Offset = "0x6DA8AE0", VA = "0x186DA98E0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public static readonly IOBALFFLAAK FONHENDMFLP;

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public static readonly IOBALFFLAAK KKOEJAJJHMA;

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private static readonly HashSet<DOHCCNMLPPO> BMACMCPDNHA;

		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public static List<DOHCCNMLPPO> AFFDJMFNKPF;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static JNHMDKJCHNA NCMJCNJGKGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x9A0830", Offset = "0x99FA30", VA = "0x1809A0830")]
			get
			{
				return default(JNHMDKJCHNA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static DOHCCNMLPPO PFPCGHFOCHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x22BB6E0", Offset = "0x22BA8E0", VA = "0x1822BB6E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static DOHCCNMLPPO HAMBFKJDMEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x22B95F0", Offset = "0x22B87F0", VA = "0x1822B95F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static DOHCCNMLPPO HKADMKJLMFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x22B9C10", Offset = "0x22B8E10", VA = "0x1822B9C10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static DOHCCNMLPPO JMMAKICPHNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x22BBBD0", Offset = "0x22BADD0", VA = "0x1822BBBD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static DOHCCNMLPPO NCFHGJJHCOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x22B9B70", Offset = "0x22B8D70", VA = "0x1822B9B70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static DOHCCNMLPPO DCLGGKOPGFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x22BB1F0", Offset = "0x22BA3F0", VA = "0x1822BB1F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static DOHCCNMLPPO HKDJHIHLFEF
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x22B9690", Offset = "0x22B8890", VA = "0x1822B9690")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static DOHCCNMLPPO JGEHOKNFMPA
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x22B9F80", Offset = "0x22B9180", VA = "0x1822B9F80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static DDBJBBOCCDM KNIGPKFCIAK
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x22B9A30", Offset = "0x22B8C30", VA = "0x1822B9A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static DDBJBBOCCDM ICECKEKIHBL
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x22BAB20", Offset = "0x22B9D20", VA = "0x1822BAB20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static DDBJBBOCCDM APMIINOANIO
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x22BA7E0", Offset = "0x22B99E0", VA = "0x1822BA7E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static DDBJBBOCCDM IDKNONHPFLF
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x22BAB80", Offset = "0x22B9D80", VA = "0x1822BAB80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static DDBJBBOCCDM NJMALHCIHLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x22B98B0", Offset = "0x22B8AB0", VA = "0x1822B98B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static DDBJBBOCCDM CKLDKHFLFKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x22BB010", Offset = "0x22BA210", VA = "0x1822BB010")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static DDBJBBOCCDM BEMHOCJDNLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x22BB9C0", Offset = "0x22BABC0", VA = "0x1822BB9C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static DDBJBBOCCDM EFJCKOFIPBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x22B9EC0", Offset = "0x22B90C0", VA = "0x1822B9EC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static DDBJBBOCCDM MIKECOLHEMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x22BAD40", Offset = "0x22B9F40", VA = "0x1822BAD40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static DDBJBBOCCDM KGOPGBCAICD
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x22BA200", Offset = "0x22B9400", VA = "0x1822BA200")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static DDBJBBOCCDM GCGDFCIKFIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x22BB0D0", Offset = "0x22BA2D0", VA = "0x1822BB0D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static DDBJBBOCCDM EMJAOLKNEDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x22B9CB0", Offset = "0x22B8EB0", VA = "0x1822B9CB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static DDBJBBOCCDM PDDPKABNBBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x22BA020", Offset = "0x22B9220", VA = "0x1822BA020")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static DDBJBBOCCDM BGOPDCCLKDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x22BAAC0", Offset = "0x22B9CC0", VA = "0x1822BAAC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static DDBJBBOCCDM IJKBGIDOKEH
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x22BB8A0", Offset = "0x22BAAA0", VA = "0x1822BB8A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static DDBJBBOCCDM BOBINEMIELO
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x22BA470", Offset = "0x22B9670", VA = "0x1822BA470")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static DDBJBBOCCDM EDKGEADFAHK
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x22B9910", Offset = "0x22B8B10", VA = "0x1822B9910")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static DDBJBBOCCDM CJOOPNAEHGF
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x22BB7E0", Offset = "0x22BA9E0", VA = "0x1822BB7E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static DDBJBBOCCDM GFKEKBLOBHE
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x22B97F0", Offset = "0x22B89F0", VA = "0x1822B97F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public static DDBJBBOCCDM NNMBHDKFHIM
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x22BA3B0", Offset = "0x22B95B0", VA = "0x1822BA3B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public static DDBJBBOCCDM JCLINGFEIMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x22BB410", Offset = "0x22BA610", VA = "0x1822BB410")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public static DDBJBBOCCDM GDFLECBILDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x22B9850", Offset = "0x22B8A50", VA = "0x1822B9850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public static DDBJBBOCCDM DGKEJNBJNPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x22BB620", Offset = "0x22BA820", VA = "0x1822BB620")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public static DDBJBBOCCDM OMDDMNJLHDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x22B9D10", Offset = "0x22B8F10", VA = "0x1822B9D10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public static DDBJBBOCCDM EFMLJCGPCKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x22BAFB0", Offset = "0x22BA1B0", VA = "0x1822BAFB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public static DDBJBBOCCDM OGNGJDKKDOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x22BA6C0", Offset = "0x22B98C0", VA = "0x1822BA6C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public static DDBJBBOCCDM EMJGAAOCPAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x22BA840", Offset = "0x22B9A40", VA = "0x1822BA840")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public static DDBJBBOCCDM IBNNAKPONAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x22BBC70", Offset = "0x22BAE70", VA = "0x1822BBC70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public static DDBJBBOCCDM BIKINOIEMFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x22BB840", Offset = "0x22BAA40", VA = "0x1822BB840")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public static DDBJBBOCCDM KIIGJLLCMHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x22B9F20", Offset = "0x22B9120", VA = "0x1822B9F20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public static DDBJBBOCCDM PAFLNNCBHFI
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x22B9DA0", Offset = "0x22B8FA0", VA = "0x1822B9DA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public static DDBJBBOCCDM IIBBDJJKDDM
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x22BACE0", Offset = "0x22B9EE0", VA = "0x1822BACE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public static DDBJBBOCCDM CAEDFGGJMLI
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x22B9730", Offset = "0x22B8930", VA = "0x1822B9730")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public static DDBJBBOCCDM FBEJCDFBECF
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x22B9E60", Offset = "0x22B9060", VA = "0x1822B9E60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public static DDBJBBOCCDM GMOOCJLMNCP
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x22BB070", Offset = "0x22BA270", VA = "0x1822BB070")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public static DDBJBBOCCDM AOMIMNNKNEL
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x22BB900", Offset = "0x22BAB00", VA = "0x1822BB900")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public static DDBJBBOCCDM IANOJPJKOKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x22BA720", Offset = "0x22B9920", VA = "0x1822BA720")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public static DDBJBBOCCDM GCMIEGEOJKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x22B9E00", Offset = "0x22B9000", VA = "0x1822B9E00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public static DDBJBBOCCDM PJOKMMFMFOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x22BA2C0", Offset = "0x22B94C0", VA = "0x1822BA2C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public static DDBJBBOCCDM NLGMGNJIHCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x22BA080", Offset = "0x22B9280", VA = "0x1822BA080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public static DDBJBBOCCDM EKNJAPBKDLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x22BB3B0", Offset = "0x22BA5B0", VA = "0x1822BB3B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public static DDBJBBOCCDM NKEMHDACEDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x22BA4D0", Offset = "0x22B96D0", VA = "0x1822BA4D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public static DDBJBBOCCDM IHDBIHACIBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x22BAEF0", Offset = "0x22BA0F0", VA = "0x1822BAEF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public static DDBJBBOCCDM DHMOLIBFBOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x22BB780", Offset = "0x22BA980", VA = "0x1822BB780")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public static DDBJBBOCCDM KPAGMCKNNIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x22BB130", Offset = "0x22BA330", VA = "0x1822BB130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public static DDBJBBOCCDM JAEMGNOAKGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x22BA5C0", Offset = "0x22B97C0", VA = "0x1822BA5C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public static DDBJBBOCCDM CLGNAJALKBB
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x22BBD30", Offset = "0x22BAF30", VA = "0x1822BBD30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public static DDBJBBOCCDM BBNMADLAEHM
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x22BAA00", Offset = "0x22B9C00", VA = "0x1822BAA00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public static DDBJBBOCCDM JOGNPLPILEE
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x22BB290", Offset = "0x22BA490", VA = "0x1822BB290")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public static DDBJBBOCCDM LJNFGELFEFH
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x22BB5C0", Offset = "0x22BA7C0", VA = "0x1822BB5C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public static DDBJBBOCCDM HHGODEMIHIO
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x22BAF50", Offset = "0x22BA150", VA = "0x1822BAF50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public static DDBJBBOCCDM IOEDJAFLGDE
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x22BB2F0", Offset = "0x22BA4F0", VA = "0x1822BB2F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public static DDBJBBOCCDM PIMPFOGLCFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x22BA260", Offset = "0x22B9460", VA = "0x1822BA260")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public static DDBJBBOCCDM DMMAHJLMDBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x22BA410", Offset = "0x22B9610", VA = "0x1822BA410")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public static DDBJBBOCCDM KLPBHIPEAHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x22BB190", Offset = "0x22BA390", VA = "0x1822BB190")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public static DDBJBBOCCDM IFGBEFGHBAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x22BBB70", Offset = "0x22BAD70", VA = "0x1822BBB70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public static DDBJBBOCCDM CLCNLCFAFJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x22BB960", Offset = "0x22BAB60", VA = "0x1822BB960")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public static DDBJBBOCCDM HGBOHJDKHCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x22BBDF0", Offset = "0x22BAFF0", VA = "0x1822BBDF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public static DDBJBBOCCDM OJLBHMGLHFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x22B99D0", Offset = "0x22B8BD0", VA = "0x1822B99D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public static DDBJBBOCCDM KPJBGFNNHPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x22BA1A0", Offset = "0x22B93A0", VA = "0x1822BA1A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public static DDBJBBOCCDM OMAPJNMMLDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x22B9970", Offset = "0x22B8B70", VA = "0x1822B9970")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public static DDBJBBOCCDM FNINNOJOIHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x22BB350", Offset = "0x22BA550", VA = "0x1822BB350")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public static DDBJBBOCCDM BNLMHLNCHPH
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x22BA780", Offset = "0x22B9980", VA = "0x1822BA780")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public static DDBJBBOCCDM HHPFFHPLEBC
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x22BA530", Offset = "0x22B9730", VA = "0x1822BA530")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public static DDBJBBOCCDM CDBDDAAGFDJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x22BBA20", Offset = "0x22BAC20", VA = "0x1822BBA20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public static DDBJBBOCCDM JEEJLPMLMLI
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x22BA0E0", Offset = "0x22B92E0", VA = "0x1822BA0E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public static DDBJBBOCCDM NMLBMKMPFAF
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x22BAA60", Offset = "0x22B9C60", VA = "0x1822BAA60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public static DDBJBBOCCDM DIHHMMPMPAI
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x22BBD90", Offset = "0x22BAF90", VA = "0x1822BBD90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public static DDBJBBOCCDM AMDHIPDMDPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x22BBCD0", Offset = "0x22BAED0", VA = "0x1822BBCD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public static DDBJBBOCCDM EPCBNPEEKLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x22BBA80", Offset = "0x22BAC80", VA = "0x1822BBA80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public static DDBJBBOCCDM EBHAONJJACF
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x22B9790", Offset = "0x22B8990", VA = "0x1822B9790")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public static DDBJBBOCCDM FNGFAEBBCFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x22BB680", Offset = "0x22BA880", VA = "0x1822BB680")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public static DDBJBBOCCDM PHJMLPPPNME
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x22BA140", Offset = "0x22B9340", VA = "0x1822BA140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x22BABE0", Offset = "0x22B9DE0", VA = "0x1822BABE0")]
		public static IOBALFFLAAK HLOHDCPFAMB(in CHCHCPJCBLP LFHFCNLIECH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x22B9AC0", Offset = "0x22B8CC0", VA = "0x1822B9AC0")]
		public static APMDKMBGHCA BMNOGECDEEO(string CJNGPAPKKID, [Optional] string JPKENOAMLIN)
		{
			return default(APMDKMBGHCA);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x22B9A90", Offset = "0x22B8C90", VA = "0x1822B9A90")]
		public static APMDKMBGHCA BMNOGECDEEO([Optional] in Guid? CJNGPAPKKID, [Optional] string JPKENOAMLIN)
		{
			return default(APMDKMBGHCA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x22B9D70", Offset = "0x22B8F70", VA = "0x1822B9D70")]
		public static IOBALFFLAAK CFJLMLKDBOK(params CHCHCPJCBLP[] ALHLHNGBEBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x22BA590", Offset = "0x22B9790", VA = "0x1822BA590")]
		public static IOBALFFLAAK FBCICNHOLMH(params CHCHCPJCBLP[] ALHLHNGBEBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x22BADA0", Offset = "0x22B9FA0", VA = "0x1822BADA0")]
		public static IOBALFFLAAK IGBCKNIOCHA(in CHCHCPJCBLP LFHFCNLIECH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x22BBE50", Offset = "0x22BB050", VA = "0x1822BBE50")]
		static LHGIGOEGEDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x22BBAE0", Offset = "0x22BACE0", VA = "0x1822BBAE0")]
		[IteratorStateMachine(typeof(JIJPAIOEPKB))]
		private static IEnumerable<DOHCCNMLPPO> NPOKBAIOGOC(bool HGOGCHJDFPC, bool PCOENCNBCGL, bool NJADFOIALMB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x22BA620", Offset = "0x22B9820", VA = "0x1822BA620")]
		[IteratorStateMachine(typeof(IFFHEAEPABO))]
		public static IEnumerable<DOHCCNMLPPO> FFGHCCLLCCN(bool FMHEEKPAILC, bool HGOGCHJDFPC, bool PCOENCNBCGL, bool NJADFOIALMB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x22BA8A0", Offset = "0x22B9AA0", VA = "0x1822BA8A0")]
		public static JPGILOLJKGD GDBIBFPBPCL(DOHCCNMLPPO FBNKHAJKFLM)
		{
			return default(JPGILOLJKGD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x22BB470", Offset = "0x22BA670", VA = "0x1822BB470")]
		public static JPGILOLJKGD LJBOMCLEIJF(DOHCCNMLPPO FBNKHAJKFLM)
		{
			return default(JPGILOLJKGD);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x22BA320", Offset = "0x22B9520", VA = "0x1822BA320")]
		public static bool EDFGPLDJGKJ(DOHCCNMLPPO FBNKHAJKFLM)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct EPNCGHEMKCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public HOGMOCHAFIO<OIFIAGANGCE> BCMLKNDKKNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public HOGMOCHAFIO<OIFIAGANGCE> LINGFNEOIIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public HOGMOCHAFIO<OIFIAGANGCE> JJIDCNCJKHA;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x22B2620", Offset = "0x22B1820", VA = "0x1822B2620")]
		public static EPNCGHEMKCA HBHNAKPOBBF(DLJKDKMADAK MFFDAOAAOBC, BDPICEDJANI NKPJOKLGAHM)
		{
			return default(EPNCGHEMKCA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public readonly struct FHJBKGALENJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private readonly KPDEPJCEJAK DMGDKEHBMMF;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8BADB0", Offset = "0x8B9FB0", VA = "0x1808BADB0")]
		public FHJBKGALENJ(KPDEPJCEJAK BFEBKHPPGCK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class LKLIOBPDCAP
	{
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private static Dictionary<HOGMOCHAFIO<NGEDKGFAAGE>, LMDALGICMAD> JLMHEPEODJI;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public static readonly HOGMOCHAFIO<NGEDKGFAAGE> MOBOMNFBKHP;

		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public static readonly HOGMOCHAFIO<NGEDKGFAAGE> OOBGCEJKOGP;

		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public static readonly HOGMOCHAFIO<NGEDKGFAAGE> DNLOMGIHHNF;

		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly HOGMOCHAFIO<NGEDKGFAAGE> PBCOBGKPJAI;

		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public static readonly HOGMOCHAFIO<NGEDKGFAAGE> FCPOJNPNCLM;

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public static readonly HOGMOCHAFIO<NGEDKGFAAGE> GFJGMKJJGGC;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public static readonly HOGMOCHAFIO<NGEDKGFAAGE> HBPICJEOKGH;

		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public static readonly HOGMOCHAFIO<NGEDKGFAAGE> CPOBKBDGGDE;

		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly HOGMOCHAFIO<NGEDKGFAAGE> KJKDBMFHKMI;

		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public static readonly HOGMOCHAFIO<NGEDKGFAAGE> BDPFKIDAHJO;

		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public static readonly HOGMOCHAFIO<NGEDKGFAAGE> KFPDGHCCCFG;

		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public static readonly HOGMOCHAFIO<NGEDKGFAAGE> OAEBPGONCDP;

		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public static readonly HOGMOCHAFIO<NGEDKGFAAGE> MIOEMMHNHNJ;

		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public static readonly HOGMOCHAFIO<NGEDKGFAAGE> JKNOODNNKHK;

		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public static readonly HOGMOCHAFIO<NGEDKGFAAGE> JMCJBGKPHPB;

		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public static readonly HOGMOCHAFIO<NGEDKGFAAGE> GAOIFFFKEOI;

		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public static readonly HOGMOCHAFIO<NGEDKGFAAGE> IGLFGPFFEFJ;

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public static readonly HOGMOCHAFIO<NGEDKGFAAGE> DIKCDBEDFJM;

		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly HOGMOCHAFIO<NGEDKGFAAGE> NMEGNMPJOFN;

		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public static readonly HOGMOCHAFIO<NGEDKGFAAGE> OKMNLJGCHBA;

		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public static readonly HOGMOCHAFIO<NGEDKGFAAGE> DKGLNEFNGNF;

		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public static readonly HOGMOCHAFIO<NGEDKGFAAGE> LMPBBKMJECI;

		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public static readonly HOGMOCHAFIO<NGEDKGFAAGE> BLBNJOFFADF;

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly HOGMOCHAFIO<NGEDKGFAAGE> CFAFBBHPKOO;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public static readonly HOGMOCHAFIO<NGEDKGFAAGE> KLFLJLCMCOG;

		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public static readonly HOGMOCHAFIO<NGEDKGFAAGE> POGPIMKHKOB;

		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public static readonly HOGMOCHAFIO<NGEDKGFAAGE> PMEDPDGBLGL;

		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public static readonly HOGMOCHAFIO<NGEDKGFAAGE> ABOGCPLLBKC;

		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public static readonly HOGMOCHAFIO<NGEDKGFAAGE> EKHKABGGJGI;

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public static readonly HOGMOCHAFIO<NGEDKGFAAGE> BGFLEIFACNL;

		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public static readonly HOGMOCHAFIO<NGEDKGFAAGE> NEDPBCGKHDD;

		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public static readonly HOGMOCHAFIO<NGEDKGFAAGE> FDKCFHJCJLL;

		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public static readonly HOGMOCHAFIO<NGEDKGFAAGE> CEIFOEEJGNL;

		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public static readonly HOGMOCHAFIO<NGEDKGFAAGE> KOLCEFPHMJF;

		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public static readonly HOGMOCHAFIO<NGEDKGFAAGE> OBBHDBDEKHE;

		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly HOGMOCHAFIO<NGEDKGFAAGE> JCOGCJGNHLO;

		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public static readonly HOGMOCHAFIO<NGEDKGFAAGE> OMONDCHDLMK;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public static readonly HOGMOCHAFIO<NGEDKGFAAGE> PFGCDGODBHM;

		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public static readonly HOGMOCHAFIO<NGEDKGFAAGE> NOPDCCIELKG;

		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly HOGMOCHAFIO<NGEDKGFAAGE> LLCIFOAFEEI;

		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public static readonly HOGMOCHAFIO<NGEDKGFAAGE> JDAGHOBEHPA;

		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public static readonly HOGMOCHAFIO<NGEDKGFAAGE> EMOKMLGKEDK;

		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public static readonly HOGMOCHAFIO<NGEDKGFAAGE> NNELEAABKGC;

		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public static readonly HOGMOCHAFIO<NGEDKGFAAGE> JMPOHOOLAAL;

		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public static readonly HOGMOCHAFIO<NGEDKGFAAGE> AOEAFFPPIPH;

		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public static readonly HOGMOCHAFIO<NGEDKGFAAGE> JICNMNGFBOA;

		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public static readonly HOGMOCHAFIO<NGEDKGFAAGE> INJIAJLHEEM;

		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly HOGMOCHAFIO<NGEDKGFAAGE> HMMLONFBEEK;

		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public static readonly HOGMOCHAFIO<NGEDKGFAAGE> OCBAMGFDGKM;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x22C1A70", Offset = "0x22C0C70", VA = "0x1822C1A70")]
		public static LMDALGICMAD ODODKCBNBPK(HOGMOCHAFIO<NGEDKGFAAGE> CJNGPAPKKID)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x22C1940", Offset = "0x22C0B40", VA = "0x1822C1940")]
		public static bool AFEKNNBJLKP(HOGMOCHAFIO<NGEDKGFAAGE> CJNGPAPKKID, out LMDALGICMAD CJMNCJDNJOA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x22C1870", Offset = "0x22C0A70", VA = "0x1822C1870")]
		public static DOHCCNMLPPO AFDHEMLDDFB(HOGMOCHAFIO<NGEDKGFAAGE> CJNGPAPKKID)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x22C19D0", Offset = "0x22C0BD0", VA = "0x1822C19D0")]
		private static HOGMOCHAFIO<NGEDKGFAAGE> JJOABFDKIHC(LMDALGICMAD CJMNCJDNJOA, HOGMOCHAFIO<NGEDKGFAAGE> CJNGPAPKKID)
		{
			return default(HOGMOCHAFIO<NGEDKGFAAGE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct DAKJODEMKDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public HOGMOCHAFIO<JEPEPFIODEH> CEOBFALPNMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public HOGMOCHAFIO<JEPEPFIODEH> NJIFNCMGFKG;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x22AF900", Offset = "0x22AEB00", VA = "0x1822AF900")]
		public static DAKJODEMKDK HBHNAKPOBBF(GCNEJCPKCDH<CCOHKDMNIBE> MFFDAOAAOBC)
		{
			return default(DAKJODEMKDK);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly OFHEJOOKKMK EJMKPOBEOHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly DAKJODEMKDK GHOADHCDEKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly EPNCGHEMKCA PMCOANIFAID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly NJCGNMPMJKC<GHMFAIJCADA, EDBIHHKHLOP<CCOHKDMNIBE>> NKEBPLIGANG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly NJCGNMPMJKC<JEPEPFIODEH, HHMKNCPLHJO<CCOHKDMNIBE>> AMKLGEAPEMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly NJCGNMPMJKC<OIFIAGANGCE, GIOEEBGKLLM> GDLHAGOEDCO;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x22B0D50", Offset = "0x22AFF50", VA = "0x1822B0D50")]
	private DFIKBEOPGKC(in OFHEJOOKKMK POGDFFOPHGG, in DAKJODEMKDK CEOAACACAEL, in EPNCGHEMKCA JPAPNLEMBOG, NJCGNMPMJKC<GHMFAIJCADA, EDBIHHKHLOP<CCOHKDMNIBE>> KJLHCDJKKNO, NJCGNMPMJKC<JEPEPFIODEH, HHMKNCPLHJO<CCOHKDMNIBE>> KCBPIJPAIOF, NJCGNMPMJKC<OIFIAGANGCE, GIOEEBGKLLM> LCEMLFGIAAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x22B0530", Offset = "0x22AF730", VA = "0x1822B0530")]
	public static DFIKBEOPGKC HBHNAKPOBBF(EMKIGOOGJFE NKPJOKLGAHM)
	{
		return default(DFIKBEOPGKC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x22B0990", Offset = "0x22AFB90", VA = "0x1822B0990")]
	public static void NDBCAEEMEJN(in DFIKBEOPGKC KPIHKJNPOFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x22B0440", Offset = "0x22AF640", VA = "0x1822B0440", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x22B0450", Offset = "0x22AF650", VA = "0x1822B0450")]
	public static GONFJAJBDCL<CCOHKDMNIBE> FDCMJGFDOEI(in DFIKBEOPGKC KPIHKJNPOFH, in GFJKCDJOGFM PGMDBCKGCCO, in MEDHPBJFJOL KMCEAFCMDLG)
	{
		return default(GONFJAJBDCL<CCOHKDMNIBE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x22AC1E0", Offset = "0x22AB3E0", VA = "0x1822AC1E0")]
	public static CCOHKDMNIBE NFGKMHAHEEK(in DFIKBEOPGKC KPIHKJNPOFH, in LHOPLKIJFAJ KKJMCFGDOFG, in GONFJAJBDCL<CCOHKDMNIBE> DJPMGOGNGEK, in GHMEPLNGGIJ FHOHOGDNPCA, HOGMOCHAFIO<ICMDIGALLLM> HCPMLCKILJA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class EKAGMEDCGGE
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x22B2260", Offset = "0x22B1460", VA = "0x1822B2260")]
	public static bool EDFNKNNCEAA(this DOHCCNMLPPO FBNKHAJKFLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x22B2180", Offset = "0x22B1380", VA = "0x1822B2180")]
	public static bool EDFNKNNCEAA(this IOBALFFLAAK HPNBLHJOEIK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class CHPKBDDKENH
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2235D80", Offset = "0x2234F80", VA = "0x182235D80")]
	public static GANOHBDLJJM<IFHFCBJLIGK, AKEADGDIFCI, TRoot, PMLHBCKFJGO.DFBLKPGNGBD<IFHFCBJLIGK, AKEADGDIFCI, TRoot>> EJNJADHACLH<TRoot>(this in GANOHBDLJJM<IFHFCBJLIGK, AKEADGDIFCI, TRoot, PMLHBCKFJGO.DFBLKPGNGBD<IFHFCBJLIGK, AKEADGDIFCI, TRoot>> IIGKBFLJPFC) where TRoot : OIGBHDHBPIE
	{
		return default(GANOHBDLJJM<IFHFCBJLIGK, AKEADGDIFCI, TRoot, PMLHBCKFJGO.DFBLKPGNGBD<IFHFCBJLIGK, AKEADGDIFCI, TRoot>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface OIGBHDHBPIE
{
	[Cpp2IlInjected.Token(Token = "0x17000058")]
	OJAPJBMMFFA? EPAKECLNDGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal static class IBHMJPEMMNL
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x22B4F50", Offset = "0x22B4150", VA = "0x1822B4F50")]
	internal static CCOHKDMNIBE EPAKECLNDGH(this OIGBHDHBPIE KPIHKJNPOFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x22B4DA0", Offset = "0x22B3FA0", VA = "0x1822B4DA0")]
	internal static PINPMIPFEPJ<CCOHKDMNIBE, DLMGOKPFHAD> BAMDBGDODME(this OIGBHDHBPIE KPIHKJNPOFH)
	{
		return default(PINPMIPFEPJ<CCOHKDMNIBE, DLMGOKPFHAD>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public readonly struct OJAPJBMMFFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	internal readonly CCOHKDMNIBE EPAKECLNDGH;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8BADB0", Offset = "0x8B9FB0", VA = "0x1808BADB0")]
	public OJAPJBMMFFA(CCOHKDMNIBE JAIFGIBBKBM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class CCOHKDMNIBE : BIMMHONMPDP, AMEBNBHMCAB<CCOHKDMNIBE>, KJGMEMDIGMA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public readonly DFIKBEOPGKC LJGADJDEBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private LHOPLKIJFAJ AJALDBMFJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private GONFJAJBDCL<CCOHKDMNIBE> NFDFLCEAIHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private GHMEPLNGGIJ HNOLFMKOBNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly HOGMOCHAFIO<ICMDIGALLLM> MFNJPJGLKOA;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x22AE520", Offset = "0x22AD720", VA = "0x1822AE520")]
	private CCOHKDMNIBE(in DFIKBEOPGKC GGOJAFBHOED, in LHOPLKIJFAJ MGMDDFLIBGK, in GONFJAJBDCL<CCOHKDMNIBE> DJPMGOGNGEK, in GHMEPLNGGIJ FHOHOGDNPCA, HOGMOCHAFIO<ICMDIGALLLM> JAJOMKFJEHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x22AC1E0", Offset = "0x22AB3E0", VA = "0x1822AC1E0")]
	public static CCOHKDMNIBE HKMLEDGAFIJ(in DFIKBEOPGKC GGOJAFBHOED, in LHOPLKIJFAJ MGMDDFLIBGK, in GONFJAJBDCL<CCOHKDMNIBE> DJPMGOGNGEK, in GHMEPLNGGIJ FHOHOGDNPCA, HOGMOCHAFIO<ICMDIGALLLM> JAJOMKFJEHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x22ABB40", Offset = "0x22AAD40", VA = "0x1822ABB40", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x22AB270", Offset = "0x22AA470", VA = "0x1822AB270", Slot = "8")]
	public GONFJAJBDCL<CCOHKDMNIBE> CDKADAKLKIB()
	{
		return default(GONFJAJBDCL<CCOHKDMNIBE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x22ABBC0", Offset = "0x22AADC0", VA = "0x1822ABBC0")]
	public LHOPLKIJFAJ LECKAPJCCKN()
	{
		return default(LHOPLKIJFAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x222D5B0", Offset = "0x222C7B0", VA = "0x18222D5B0")]
	public HOGMOCHAFIO<TMVirt> JKKNPKHMLME<TMVirt>(HOGMOCHAFIO<ICMDIGALLLM> MKJGAIOAKMJ) where TMVirt : GFICJMGLIDC.LKEOPGCFCOF
	{
		return default(HOGMOCHAFIO<TMVirt>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x222D6D0", Offset = "0x222C8D0", VA = "0x18222D6D0")]
	public HOGMOCHAFIO<TMVirt> NGJIKJJLDDG<TMVirt>(HOGMOCHAFIO<ICMDIGALLLM> MKJGAIOAKMJ, HOGMOCHAFIO<JDAAGGKKBIF> ICCMHBOIOOM) where TMVirt : KPPFBPGGFHN.FLCGICOCEGK
	{
		return default(HOGMOCHAFIO<TMVirt>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x22AB230", Offset = "0x22AA430", VA = "0x1822AB230")]
	internal GFJKCDJOGFM CDGLLAMFPEA()
	{
		return default(GFJKCDJOGFM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x22AE380", Offset = "0x22AD580", VA = "0x1822AE380")]
	internal MEDHPBJFJOL PJAAJJLCGDD()
	{
		return default(MEDHPBJFJOL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x22AB270", Offset = "0x22AA470", VA = "0x1822AB270")]
	internal GONFJAJBDCL<CCOHKDMNIBE> INIOBFLPEBB()
	{
		return default(GONFJAJBDCL<CCOHKDMNIBE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x22ABBC0", Offset = "0x22AADC0", VA = "0x1822ABBC0")]
	internal LHOPLKIJFAJ EFEPOHJLMFG()
	{
		return default(LHOPLKIJFAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x22AB220", Offset = "0x22AA420", VA = "0x1822AB220")]
	internal GHMEPLNGGIJ AILCPBCEFNE()
	{
		return default(GHMEPLNGGIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x222D1F0", Offset = "0x222C3F0", VA = "0x18222D1F0")]
	public void BGNJMAJPBLE<TMVirt>(HOGMOCHAFIO<ICMDIGALLLM> MKJGAIOAKMJ, HOGMOCHAFIO<TMVirt> OPOCHEKBMJP) where TMVirt : GFICJMGLIDC.LKEOPGCFCOF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x222D620", Offset = "0x222C820", VA = "0x18222D620")]
	public void MMCOAIOLDNE<TMVirt>(HOGMOCHAFIO<ICMDIGALLLM> MKJGAIOAKMJ, HOGMOCHAFIO<JDAAGGKKBIF> ICCMHBOIOOM, HOGMOCHAFIO<TMVirt> OPOCHEKBMJP) where TMVirt : KPPFBPGGFHN.FLCGICOCEGK
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x22AB1D0", Offset = "0x22AA3D0", VA = "0x1822AB1D0", Slot = "9")]
	public LHLCMIDIHNF AIALCJAGHGI()
	{
		return default(LHLCMIDIHNF);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x22ABF90", Offset = "0x22AB190", VA = "0x1822ABF90", Slot = "10")]
	public JPGILOLJKGD FFLDCBEDMGI(DOHCCNMLPPO FBNKHAJKFLM)
	{
		return default(JPGILOLJKGD);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x22AE450", Offset = "0x22AD650", VA = "0x1822AE450", Slot = "11")]
	public bool PLKLOCHBBGL(DOHCCNMLPPO FBNKHAJKFLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x22AE2B0", Offset = "0x22AD4B0", VA = "0x1822AE2B0", Slot = "4")]
	private void OFIKPAOOMKF(HOGMOCHAFIO<ICMDIGALLLM> MKJGAIOAKMJ, HOGMOCHAFIO<JDAAGGKKBIF> ICCMHBOIOOM, ref CDFBBMKPBAJ EAMFJKAPHDI, HOGMOCHAFIO<PAKIHOAJDHN.EBGDPIKPOKJ>? GILPHBNEOBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x22AC130", Offset = "0x22AB330", VA = "0x1822AC130", Slot = "5")]
	private void FMDBJLEIKML(HOGMOCHAFIO<ICMDIGALLLM> MKJGAIOAKMJ, HOGMOCHAFIO<JDAAGGKKBIF> ICCMHBOIOOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x22AD830", Offset = "0x22ACA30", VA = "0x1822AD830", Slot = "6")]
	private void LPKIFNCDPMH(HOGMOCHAFIO<ICMDIGALLLM> MKJGAIOAKMJ, ref CDFBBMKPBAJ EAMFJKAPHDI, HOGMOCHAFIO<PAKIHOAJDHN.EBGDPIKPOKJ>? GILPHBNEOBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x22AD790", Offset = "0x22AC990", VA = "0x1822AD790", Slot = "7")]
	private void LKNPAKINPLF(HOGMOCHAFIO<ICMDIGALLLM> MKJGAIOAKMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x22AC330", Offset = "0x22AB530", VA = "0x1822AC330")]
	internal PINPMIPFEPJ<HOGMOCHAFIO<JDAAGGKKBIF>, IFCPLEGMLKF> JACBNPAHKEK(HOGMOCHAFIO<ICMDIGALLLM> MKJGAIOAKMJ, HOGMOCHAFIO<GHMFAIJCADA> NPMODPJKIFP, in DDAEIDDGCJK DGDMDKFMBBA, in HBNLMECNNNL KGFPECIFPNA, ref CDFBBMKPBAJ KKHDMMCODGH, HOGMOCHAFIO<PAKIHOAJDHN.EBGDPIKPOKJ>? KIJIGPENPBJ)
	{
		return default(PINPMIPFEPJ<HOGMOCHAFIO<JDAAGGKKBIF>, IFCPLEGMLKF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x22AD680", Offset = "0x22AC880", VA = "0x1822AD680")]
	internal HOGMOCHAFIO<JDAAGGKKBIF> LDGMBNLCOOL(HOGMOCHAFIO<ICMDIGALLLM> MKJGAIOAKMJ, HOGMOCHAFIO<GHMFAIJCADA> NPMODPJKIFP, in DDAEIDDGCJK DGDMDKFMBBA, in HBNLMECNNNL KGFPECIFPNA, ref CDFBBMKPBAJ KKHDMMCODGH, HOGMOCHAFIO<PAKIHOAJDHN.EBGDPIKPOKJ>? KIJIGPENPBJ)
	{
		return default(HOGMOCHAFIO<JDAAGGKKBIF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x22AE3C0", Offset = "0x22AD5C0", VA = "0x1822AE3C0")]
	internal PINPMIPFEPJ<CKDLGNFJNCJ, IFCPLEGMLKF> PKMIOPFDJGO(HOGMOCHAFIO<ICMDIGALLLM> MKJGAIOAKMJ, HOGMOCHAFIO<JDAAGGKKBIF> ICCMHBOIOOM)
	{
		return default(PINPMIPFEPJ<CKDLGNFJNCJ, IFCPLEGMLKF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x222D250", Offset = "0x222C450", VA = "0x18222D250")]
	public PINPMIPFEPJ<HOGMOCHAFIO<TM>, IFCPLEGMLKF> DDJIOFIFMCM<TM>(HOGMOCHAFIO<ICMDIGALLLM> MKJGAIOAKMJ, HOGMOCHAFIO<JEPEPFIODEH> OHHJFFCEJLD) where TM : GFICJMGLIDC.LKEOPGCFCOF
	{
		return default(PINPMIPFEPJ<HOGMOCHAFIO<TM>, IFCPLEGMLKF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x222D3E0", Offset = "0x222C5E0", VA = "0x18222D3E0")]
	public PINPMIPFEPJ<HOGMOCHAFIO<TM>, IFCPLEGMLKF> FAFDBNFKKKL<TM>(HOGMOCHAFIO<ICMDIGALLLM> MKJGAIOAKMJ, HOGMOCHAFIO<JDAAGGKKBIF> ICCMHBOIOOM, HOGMOCHAFIO<GHMFAIJCADA> MPNMCJGFLBE) where TM : KPPFBPGGFHN.FLCGICOCEGK
	{
		return default(PINPMIPFEPJ<HOGMOCHAFIO<TM>, IFCPLEGMLKF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x22ABBD0", Offset = "0x22AADD0", VA = "0x1822ABBD0")]
	private PINPMIPFEPJ<(HOGMOCHAFIO<CBOJFLAOHKE.CDLIOBMNMPD>, HOGMOCHAFIO<CNFPBDKMBAG.LOFDEBNCBJE>), IFCPLEGMLKF> ELNFKGKMOPM(HOGMOCHAFIO<ICMDIGALLLM> MKJGAIOAKMJ, HOGMOCHAFIO<JDAAGGKKBIF> ICCMHBOIOOM)
	{
		return default(PINPMIPFEPJ<(HOGMOCHAFIO<CBOJFLAOHKE.CDLIOBMNMPD>, HOGMOCHAFIO<CNFPBDKMBAG.LOFDEBNCBJE>), IFCPLEGMLKF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x22AD9E0", Offset = "0x22ACBE0", VA = "0x1822AD9E0")]
	internal PINPMIPFEPJ<(HOGMOCHAFIO<GKDGBEBJKOB>, HOGMOCHAFIO<LMGKNPKGIBN>), IFCPLEGMLKF> MMNPEFMLBAM(HOGMOCHAFIO<ICMDIGALLLM> MKJGAIOAKMJ, HOGMOCHAFIO<JDAAGGKKBIF> ICCMHBOIOOM, int HJAPCGDAJBI, in KBEKINGHEED FBNKHAJKFLM)
	{
		return default(PINPMIPFEPJ<(HOGMOCHAFIO<GKDGBEBJKOB>, HOGMOCHAFIO<LMGKNPKGIBN>), IFCPLEGMLKF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x22AC4E0", Offset = "0x22AB6E0", VA = "0x1822AC4E0")]
	internal PINPMIPFEPJ<CKDLGNFJNCJ, IFCPLEGMLKF> KAKGADDLEPH(HOGMOCHAFIO<ICMDIGALLLM> MKJGAIOAKMJ, HOGMOCHAFIO<JDAAGGKKBIF> ICCMHBOIOOM, int HJAPCGDAJBI)
	{
		return default(PINPMIPFEPJ<CKDLGNFJNCJ, IFCPLEGMLKF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x22ACD60", Offset = "0x22ABF60", VA = "0x1822ACD60")]
	internal PINPMIPFEPJ<(HOGMOCHAFIO<LMGKNPKGIBN>, HOGMOCHAFIO<GKDGBEBJKOB>), IFCPLEGMLKF> LBOMAFNCGOC(HOGMOCHAFIO<ICMDIGALLLM> MKJGAIOAKMJ, HOGMOCHAFIO<JDAAGGKKBIF> ICCMHBOIOOM, int HBOHKIHEFEM, in KBEKINGHEED FBNKHAJKFLM)
	{
		return default(PINPMIPFEPJ<(HOGMOCHAFIO<LMGKNPKGIBN>, HOGMOCHAFIO<GKDGBEBJKOB>), IFCPLEGMLKF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x22AB280", Offset = "0x22AA480", VA = "0x1822AB280")]
	internal PINPMIPFEPJ<CKDLGNFJNCJ, IFCPLEGMLKF> DOAPBKOHBMM(HOGMOCHAFIO<ICMDIGALLLM> MKJGAIOAKMJ, HOGMOCHAFIO<JDAAGGKKBIF> ICCMHBOIOOM, int HBOHKIHEFEM)
	{
		return default(PINPMIPFEPJ<CKDLGNFJNCJ, IFCPLEGMLKF>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class DLMGOKPFHAD : KGHFJOOAHPJ
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x22B13A0", Offset = "0x22B05A0", VA = "0x1822B13A0", Slot = "7")]
	public override string MJGKCLCNGHP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x22B13D0", Offset = "0x22B05D0", VA = "0x1822B13D0")]
	public DLMGOKPFHAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class BKEAJCNEAOA
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct KBEKINGHEED : IEquatable<KBEKINGHEED>, JGMIOPFGKLF<KBEKINGHEED>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly string GCLEOCLMMPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly DOHCCNMLPPO GLGPHBABLMM;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x949BA0", Offset = "0x948DA0", VA = "0x180949BA0")]
	private KBEKINGHEED(string JPKENOAMLIN, DOHCCNMLPPO FBNKHAJKFLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x22B6970", Offset = "0x22B5B70", VA = "0x1822B6970")]
	public static KBEKINGHEED HBHNAKPOBBF(string JPKENOAMLIN, DOHCCNMLPPO FBNKHAJKFLM)
	{
		return default(KBEKINGHEED);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x22B6810", Offset = "0x22B5A10", VA = "0x1822B6810")]
	public static bool IJMFMDJGAHN(in KBEKINGHEED MHFLHKLCNGM, in KBEKINGHEED NKPGENLIMOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x22B6810", Offset = "0x22B5A10", VA = "0x1822B6810", Slot = "4")]
	public bool Equals(KBEKINGHEED JMNBIHILIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x22B6810", Offset = "0x22B5A10", VA = "0x1822B6810")]
	public bool AGDAPBIFCOO(in KBEKINGHEED JMNBIHILIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x22B6860", Offset = "0x22B5A60", VA = "0x1822B6860", Slot = "0")]
	public override bool Equals(object PPNJOAJJOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x22B6910", Offset = "0x22B5B10", VA = "0x1822B6910", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x22B69B0", Offset = "0x22B5BB0", VA = "0x1822B69B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x22B6810", Offset = "0x22B5A10", VA = "0x1822B6810", Slot = "5")]
	private bool CDGEJFMPNEF(in KBEKINGHEED JMNBIHILIIC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct LHOPLKIJFAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public HAGNLDOMAID<ICMDIGALLLM, GCHOILLPJFD> LBCHFHLIJCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public MHKIBPDLNGI<CNFPBDKMBAG.LOFDEBNCBJE> AJHIBOOBFHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public HAGNLDOMAID<CNFPBDKMBAG.LOFDEBNCBJE, CNFPBDKMBAG.NCCGPJPNMPO> IMGOFMFDPJJ;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x22B3600", Offset = "0x22B2800", VA = "0x1822B3600")]
	private LHOPLKIJFAJ(in HAGNLDOMAID<ICMDIGALLLM, GCHOILLPJFD> JLPNEGMFCHO, in MHKIBPDLNGI<CNFPBDKMBAG.LOFDEBNCBJE> NILBHHEIAFE, in HAGNLDOMAID<CNFPBDKMBAG.LOFDEBNCBJE, CNFPBDKMBAG.NCCGPJPNMPO> LGLKDEILKCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x22B3570", Offset = "0x22B2770", VA = "0x1822B3570")]
	public static LHOPLKIJFAJ HKMLEDGAFIJ(in HAGNLDOMAID<ICMDIGALLLM, GCHOILLPJFD> JLPNEGMFCHO, in MHKIBPDLNGI<CNFPBDKMBAG.LOFDEBNCBJE> NILBHHEIAFE, in HAGNLDOMAID<CNFPBDKMBAG.LOFDEBNCBJE, CNFPBDKMBAG.NCCGPJPNMPO> LGLKDEILKCI)
	{
		return default(LHOPLKIJFAJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class KOHABBINDGN
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x22B8CF0", Offset = "0x22B7EF0", VA = "0x1822B8CF0")]
	public static void NDBCAEEMEJN(this ref LHOPLKIJFAJ KPIHKJNPOFH, in GFJKCDJOGFM PGMDBCKGCCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x22B8A00", Offset = "0x22B7C00", VA = "0x1822B8A00")]
	public static void IGKEMKJBFLJ(this ref LHOPLKIJFAJ KPIHKJNPOFH, HOGMOCHAFIO<ICMDIGALLLM> MKJGAIOAKMJ, in GCHOILLPJFD HEMDALANHJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x22B8A60", Offset = "0x22B7C60", VA = "0x1822B8A60")]
	public static void KOGPOOGFLGD(this ref LHOPLKIJFAJ KPIHKJNPOFH, HOGMOCHAFIO<ICMDIGALLLM> MKJGAIOAKMJ, in GFJKCDJOGFM PGMDBCKGCCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x22B8CA0", Offset = "0x22B7EA0", VA = "0x1822B8CA0")]
	public static GCHOILLPJFD MCKGCJAFOEM(this in LHOPLKIJFAJ KPIHKJNPOFH, HOGMOCHAFIO<ICMDIGALLLM> MKJGAIOAKMJ)
	{
		return default(GCHOILLPJFD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x22B8C50", Offset = "0x22B7E50", VA = "0x1822B8C50")]
	public static GCHOILLPJFD MBAEFAJFFMJ(this ref LHOPLKIJFAJ KPIHKJNPOFH, HOGMOCHAFIO<ICMDIGALLLM> MKJGAIOAKMJ)
	{
		return default(GCHOILLPJFD);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public sealed class CNFPBDKMBAG : EEMKNFALIJA
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public sealed class LOFDEBNCBJE : GFICJMGLIDC.LKEOPGCFCOF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public struct NCCGPJPNMPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public string GCLEOCLMMPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public EDHOBJDEJNE<ALBFEPNKGJA, KBEKINGHEED> HDGBOMMAILG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public EDHOBJDEJNE<GOHONMAKFBH, KBEKINGHEED> FPBPMIPLKKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public readonly HOGMOCHAFIO<JDAAGGKKBIF> BCAAHCMGJDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public readonly HOGMOCHAFIO<JDAAGGKKBIF> FOJNCNFICBK;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x22C4530", Offset = "0x22C3730", VA = "0x1822C4530")]
		private NCCGPJPNMPO(string JPKENOAMLIN, in EDHOBJDEJNE<ALBFEPNKGJA, KBEKINGHEED> NBHHMNMEHIO, in EDHOBJDEJNE<GOHONMAKFBH, KBEKINGHEED> NCGKJLNBIDN, HOGMOCHAFIO<JDAAGGKKBIF> MDKDFAGECGE, HOGMOCHAFIO<JDAAGGKKBIF> LPLEDPFEGKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x22C43E0", Offset = "0x22C35E0", VA = "0x1822C43E0")]
		public static NCCGPJPNMPO HBHNAKPOBBF(HOGMOCHAFIO<JDAAGGKKBIF> ELLEBIDKKPN, HOGMOCHAFIO<JDAAGGKKBIF> KJFIFJPLKAF)
		{
			return default(NCCGPJPNMPO);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x22C44B0", Offset = "0x22C36B0", VA = "0x1822C44B0")]
		public static NCCGPJPNMPO HKMLEDGAFIJ(string JPKENOAMLIN, in EDHOBJDEJNE<ALBFEPNKGJA, KBEKINGHEED> NBHHMNMEHIO, in EDHOBJDEJNE<GOHONMAKFBH, KBEKINGHEED> NCGKJLNBIDN, HOGMOCHAFIO<JDAAGGKKBIF> ELLEBIDKKPN, HOGMOCHAFIO<JDAAGGKKBIF> KJFIFJPLKAF)
		{
			return default(NCCGPJPNMPO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x22AF340", Offset = "0x22AE540", VA = "0x1822AF340", Slot = "8")]
	public override void DGOEPLKKMBK(CCOHKDMNIBE DJPMGOGNGEK, HOGMOCHAFIO<ICMDIGALLLM> MKJGAIOAKMJ, ref CDFBBMKPBAJ EAMFJKAPHDI, HOGMOCHAFIO<PAKIHOAJDHN.EBGDPIKPOKJ>? KIJIGPENPBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x22AF6E0", Offset = "0x22AE8E0", VA = "0x1822AF6E0", Slot = "9")]
	public override void JAOIDMDEJFG(CCOHKDMNIBE DJPMGOGNGEK, HOGMOCHAFIO<ICMDIGALLLM> MKJGAIOAKMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x22AF8C0", Offset = "0x22AEAC0", VA = "0x1822AF8C0")]
	public CNFPBDKMBAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class LFLADKIMMDI
{
	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x22B9280", Offset = "0x22B8480", VA = "0x1822B9280")]
	public static void NDBCAEEMEJN(this ref CNFPBDKMBAG.NCCGPJPNMPO KPIHKJNPOFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct GCHOILLPJFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public HAGNLDOMAID<JDAAGGKKBIF, EMDNBGDJJLK> DBADKOKHJBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public MHKIBPDLNGI<CBOJFLAOHKE.CDLIOBMNMPD> CJFILAMHCBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public HAGNLDOMAID<CBOJFLAOHKE.CDLIOBMNMPD, CBOJFLAOHKE.LDLHMPEEEJN> DNOEJMNLDGN;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x22B3600", Offset = "0x22B2800", VA = "0x1822B3600")]
	private GCHOILLPJFD(in HAGNLDOMAID<JDAAGGKKBIF, EMDNBGDJJLK> LDMMFDNJBNG, in MHKIBPDLNGI<CBOJFLAOHKE.CDLIOBMNMPD> PILGIMBLAAI, in HAGNLDOMAID<CBOJFLAOHKE.CDLIOBMNMPD, CBOJFLAOHKE.LDLHMPEEEJN> EMCNGCDGAGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x22B3480", Offset = "0x22B2680", VA = "0x1822B3480")]
	public static GCHOILLPJFD HBHNAKPOBBF()
	{
		return default(GCHOILLPJFD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x22B3570", Offset = "0x22B2770", VA = "0x1822B3570")]
	public static GCHOILLPJFD HKMLEDGAFIJ(in HAGNLDOMAID<JDAAGGKKBIF, EMDNBGDJJLK> LDMMFDNJBNG, in MHKIBPDLNGI<CBOJFLAOHKE.CDLIOBMNMPD> PILGIMBLAAI, in HAGNLDOMAID<CBOJFLAOHKE.CDLIOBMNMPD, CBOJFLAOHKE.LDLHMPEEEJN> EMCNGCDGAGA)
	{
		return default(GCHOILLPJFD);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class HEAJANGCNCE
{
	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x22B4480", Offset = "0x22B3680", VA = "0x1822B4480")]
	public static void NDBCAEEMEJN(this ref GCHOILLPJFD KPIHKJNPOFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public abstract class EEMKNFALIJA : ACAMBBEFPGH<CCOHKDMNIBE>
{
	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x22AF8C0", Offset = "0x22AEAC0", VA = "0x1822AF8C0")]
	protected EEMKNFALIJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class KMIKPMJFOCH : EEMKNFALIJA
{
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "8")]
	public override void DGOEPLKKMBK(CCOHKDMNIBE DJPMGOGNGEK, HOGMOCHAFIO<ICMDIGALLLM> MKJGAIOAKMJ, ref CDFBBMKPBAJ EAMFJKAPHDI, HOGMOCHAFIO<PAKIHOAJDHN.EBGDPIKPOKJ>? KIJIGPENPBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "9")]
	public override void JAOIDMDEJFG(CCOHKDMNIBE DJPMGOGNGEK, HOGMOCHAFIO<ICMDIGALLLM> MKJGAIOAKMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x22AF8C0", Offset = "0x22AEAC0", VA = "0x1822AF8C0")]
	public KMIKPMJFOCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface BDPICEDJANI
{
	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GIOEEBGKLLM HMLBDIHBHJK();

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GIOEEBGKLLM OANLBOLOFIO();

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GIOEEBGKLLM DKAOHLKFEKJ();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface KPDEPJCEJAK
{
	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PINPMIPFEPJ<object, OKKDIBLBODL>> CLFHMPFGGGJ(AKEADGDIFCI AMEKOPCKNIK, bool OOMDCBCHGMH);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class BBGFONAIMPH : BPJBDCPPODI<BBGFONAIMPH, CCOHKDMNIBE>, DLJKDKMADAK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private EDHOBJDEJNE<OIFIAGANGCE, GIOEEBGKLLM> GDLHAGOEDCO;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x22A67B0", Offset = "0x22A59B0", VA = "0x1822A67B0", Slot = "6")]
	public HOGMOCHAFIO<OIFIAGANGCE> NMFJKDGLINL(GIOEEBGKLLM PNHPPFNGIKC)
	{
		return default(HOGMOCHAFIO<OIFIAGANGCE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x22A6800", Offset = "0x22A5A00", VA = "0x1822A6800")]
	private BBGFONAIMPH(in EDHOBJDEJNE<GHMFAIJCADA, EDBIHHKHLOP<CCOHKDMNIBE>> KJLHCDJKKNO, in EDHOBJDEJNE<JEPEPFIODEH, HHMKNCPLHJO<CCOHKDMNIBE>> KCBPIJPAIOF, in EDHOBJDEJNE<OIFIAGANGCE, GIOEEBGKLLM> LCEMLFGIAAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x22A66C0", Offset = "0x22A58C0", VA = "0x1822A66C0")]
	public static BBGFONAIMPH HBHNAKPOBBF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x22A65F0", Offset = "0x22A57F0", VA = "0x1822A65F0")]
	public new (NJCGNMPMJKC<GHMFAIJCADA, EDBIHHKHLOP<CCOHKDMNIBE>>, NJCGNMPMJKC<JEPEPFIODEH, HHMKNCPLHJO<CCOHKDMNIBE>>, NJCGNMPMJKC<OIFIAGANGCE, GIOEEBGKLLM>) CGDJIOIJABH()
	{
		return default((NJCGNMPMJKC<GHMFAIJCADA, EDBIHHKHLOP<CCOHKDMNIBE>>, NJCGNMPMJKC<JEPEPFIODEH, HHMKNCPLHJO<CCOHKDMNIBE>>, NJCGNMPMJKC<OIFIAGANGCE, GIOEEBGKLLM>));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface DLJKDKMADAK
{
	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HOGMOCHAFIO<OIFIAGANGCE> NMFJKDGLINL(GIOEEBGKLLM PNHPPFNGIKC);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct GHMEPLNGGIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public HAGNLDOMAID<CNFPBDKMBAG.LOFDEBNCBJE, EKEBAPEHFHG<GKDGBEBJKOB, LMGKNPKGIBN, JDAAGGKKBIF, ICMDIGALLLM>> DFDECMGIJFF;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x2115A60", Offset = "0x2114C60", VA = "0x182115A60")]
	private GHMEPLNGGIJ(in HAGNLDOMAID<CNFPBDKMBAG.LOFDEBNCBJE, EKEBAPEHFHG<GKDGBEBJKOB, LMGKNPKGIBN, JDAAGGKKBIF, ICMDIGALLLM>> IMKBFKPACOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x22B39A0", Offset = "0x22B2BA0", VA = "0x1822B39A0")]
	public static GHMEPLNGGIJ HBHNAKPOBBF()
	{
		return default(GHMEPLNGGIJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class OJDDGLOKBPC
{
	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x22C5B00", Offset = "0x22C4D00", VA = "0x1822C5B00")]
	public static void NDBCAEEMEJN(this ref GHMEPLNGGIJ KPIHKJNPOFH, in MHKIBPDLNGI<CNFPBDKMBAG.LOFDEBNCBJE> NILBHHEIAFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class KEGACDFJCMB
{
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x22B7CA0", Offset = "0x22B6EA0", VA = "0x1822B7CA0")]
	public static CDLAANPALIG IOAMGHHAJNN(this in GFJKCDJOGFM KPIHKJNPOFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x22B7E50", Offset = "0x22B7050", VA = "0x1822B7E50")]
	public static GFJKCDJOGFM JHIOLOAEPHF(this CDLAANPALIG KPIHKJNPOFH)
	{
		return default(GFJKCDJOGFM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class ABCDNLCDFON
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x22A2CD0", Offset = "0x22A1ED0", VA = "0x1822A2CD0")]
	public static ECKOHOOCNKG IOAMGHHAJNN(this CCOHKDMNIBE KPIHKJNPOFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x22A2DA0", Offset = "0x22A1FA0", VA = "0x1822A2DA0")]
	public static CCOHKDMNIBE JHIOLOAEPHF(this ECKOHOOCNKG KPIHKJNPOFH, in DFIKBEOPGKC GGOJAFBHOED)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class NIJDANJOGEA
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x22C49E0", Offset = "0x22C3BE0", VA = "0x1822C49E0")]
	public static LEOLPCIHJHK IOAMGHHAJNN(this in CBOJFLAOHKE.LDLHMPEEEJN KPIHKJNPOFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x22C4A60", Offset = "0x22C3C60", VA = "0x1822C4A60")]
	public static CBOJFLAOHKE.LDLHMPEEEJN JHIOLOAEPHF(this LEOLPCIHJHK KPIHKJNPOFH)
	{
		return default(CBOJFLAOHKE.LDLHMPEEEJN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class LGHHFLBJLFH
{
	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x19F0060", Offset = "0x19EF260", VA = "0x1819F0060")]
	public static void JCGDDCKDKMA<TDeserialized, TSerialized>(this IReadOnlyCollection<TDeserialized> KPIHKJNPOFH, RepeatedField<TSerialized> CCBKAEHNCPH, DABCLNLOMAJ<TDeserialized, TSerialized> MDEJPJFEGEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class FLBNJCNBBFB
{
	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x22B2D50", Offset = "0x22B1F50", VA = "0x1822B2D50")]
	public static DJIPCDBAGGG IOAMGHHAJNN(this in KBEKINGHEED KPIHKJNPOFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x22B2DE0", Offset = "0x22B1FE0", VA = "0x1822B2DE0")]
	public static KBEKINGHEED JHIOLOAEPHF(this DJIPCDBAGGG KPIHKJNPOFH)
	{
		return default(KBEKINGHEED);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class DCFDMPFODFG
{
	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x22AFD40", Offset = "0x22AEF40", VA = "0x1822AFD40")]
	public static GKJMCHHICBL IOAMGHHAJNN(this in MEDHPBJFJOL KPIHKJNPOFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x22AFED0", Offset = "0x22AF0D0", VA = "0x1822AFED0")]
	public static MEDHPBJFJOL JHIOLOAEPHF(this GKJMCHHICBL KPIHKJNPOFH)
	{
		return default(MEDHPBJFJOL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class HPOCMGJPILM
{
	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x22B4CA0", Offset = "0x22B3EA0", VA = "0x1822B4CA0")]
	public static IJANJEHEIEB IOAMGHHAJNN(this in EAJCOPLCBMM KPIHKJNPOFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x22B4D20", Offset = "0x22B3F20", VA = "0x1822B4D20")]
	public static EAJCOPLCBMM JHIOLOAEPHF(this IJANJEHEIEB KPIHKJNPOFH)
	{
		return default(EAJCOPLCBMM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class EIPNNNAAAHA
{
	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x22B1F50", Offset = "0x22B1150", VA = "0x1822B1F50")]
	public static FHAODLHAKIJ IOAMGHHAJNN(in Guid KPIHKJNPOFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x22B2090", Offset = "0x22B1290", VA = "0x1822B2090")]
	public static Guid JHIOLOAEPHF(FHAODLHAKIJ KPIHKJNPOFH)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class KDONADKNEOO
{
	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x22B6E80", Offset = "0x22B6080", VA = "0x1822B6E80")]
	public static NPKLKBMIBCD IOAMGHHAJNN(this in GFICJMGLIDC KPIHKJNPOFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x22B7490", Offset = "0x22B6690", VA = "0x1822B7490")]
	public static GFICJMGLIDC JHIOLOAEPHF(this NPKLKBMIBCD KPIHKJNPOFH)
	{
		return default(GFICJMGLIDC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class AOBOBOPJPDP
{
	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x22A5EA0", Offset = "0x22A50A0", VA = "0x1822A5EA0")]
	public static IHOBKJMFEMC IOAMGHHAJNN(CCOHKDMNIBE DJPMGOGNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x22A5710", Offset = "0x22A4910", VA = "0x1822A5710")]
	public static IHOBKJMFEMC IHECDAFHAKB(HOGMOCHAFIO<JEPEPFIODEH> NLENCBFHDKJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class KIFOCAAIBHM
{
	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x22B82E0", Offset = "0x22B74E0", VA = "0x1822B82E0")]
	public static FKJJNGDFKJG IOAMGHHAJNN(this in MDBKKBPNKAC KPIHKJNPOFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x22B8370", Offset = "0x22B7570", VA = "0x1822B8370")]
	public static MDBKKBPNKAC JHIOLOAEPHF(this FKJJNGDFKJG KPIHKJNPOFH)
	{
		return default(MDBKKBPNKAC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class FNFPKEOFDFN
{
	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x22B31D0", Offset = "0x22B23D0", VA = "0x1822B31D0")]
	public static PFNAELHKEMB IOAMGHHAJNN(this in CKOIKBHPIGM KPIHKJNPOFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x22B33C0", Offset = "0x22B25C0", VA = "0x1822B33C0")]
	public static CKOIKBHPIGM JHIOLOAEPHF(this PFNAELHKEMB KPIHKJNPOFH)
	{
		return default(CKOIKBHPIGM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class ANOIAIPFMCA
{
	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x22A39A0", Offset = "0x22A2BA0", VA = "0x1822A39A0")]
	public static JLDNAHKHDDL IOAMGHHAJNN(this DOHCCNMLPPO FBNKHAJKFLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x22A4A90", Offset = "0x22A3C90", VA = "0x1822A4A90")]
	public static DOHCCNMLPPO JHIOLOAEPHF(this JLDNAHKHDDL FBNKHAJKFLM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class GMFNDNABMHO
{
	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x22B3A00", Offset = "0x22B2C00", VA = "0x1822B3A00")]
	public static BLPCMLFMNPB IOAMGHHAJNN(this in LHOPLKIJFAJ KPIHKJNPOFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x22B3CB0", Offset = "0x22B2EB0", VA = "0x1822B3CB0")]
	public static LHOPLKIJFAJ JHIOLOAEPHF(this BLPCMLFMNPB KPIHKJNPOFH)
	{
		return default(LHOPLKIJFAJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class ODCBIPJHILO
{
	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x22C4EA0", Offset = "0x22C40A0", VA = "0x1822C4EA0")]
	public static DPGBICOCBPD IOAMGHHAJNN(this in BCLNDCIJMJJ KPIHKJNPOFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x22C4F30", Offset = "0x22C4130", VA = "0x1822C4F30")]
	public static BCLNDCIJMJJ JHIOLOAEPHF(this DPGBICOCBPD KPIHKJNPOFH)
	{
		return default(BCLNDCIJMJJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class IKHEIOOJJPJ
{
	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x1D13EA0", Offset = "0x1D130A0", VA = "0x181D13EA0")]
	public static FLBHHGAPGJK IOAMGHHAJNN<TRoot>(this in GONFJAJBDCL<TRoot> KPIHKJNPOFH) where TRoot : AMEBNBHMCAB<TRoot>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x22B5540", Offset = "0x22B4740", VA = "0x1822B5540")]
	public static GONFJAJBDCL<CCOHKDMNIBE> JHIOLOAEPHF(this FLBHHGAPGJK KPIHKJNPOFH, in DFIKBEOPGKC GGOJAFBHOED)
	{
		return default(GONFJAJBDCL<CCOHKDMNIBE>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class MGBOBDNMEPK
{
	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x22C3820", Offset = "0x22C2A20", VA = "0x1822C3820")]
	public static OHIDHDDJFAI IOAMGHHAJNN(this in KPPFBPGGFHN KPIHKJNPOFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x22C38B0", Offset = "0x22C2AB0", VA = "0x1822C38B0")]
	public static KPPFBPGGFHN JHIOLOAEPHF(this OHIDHDDJFAI KPIHKJNPOFH)
	{
		return default(KPPFBPGGFHN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class BGHPDAPCDJL
{
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x22AA0A0", Offset = "0x22A92A0", VA = "0x1822AA0A0")]
	public static ALGILHJNMLK IOAMGHHAJNN(this in CNFPBDKMBAG.NCCGPJPNMPO KPIHKJNPOFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x22AA350", Offset = "0x22A9550", VA = "0x1822AA350")]
	public static CNFPBDKMBAG.NCCGPJPNMPO JHIOLOAEPHF(this ALGILHJNMLK KPIHKJNPOFH)
	{
		return default(CNFPBDKMBAG.NCCGPJPNMPO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class FFLFOKILMHD
{
	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x22B2940", Offset = "0x22B1B40", VA = "0x1822B2940")]
	public static GHDPNCEOOFB IOAMGHHAJNN(this in JPGILOLJKGD KPIHKJNPOFH, DOHCCNMLPPO FBNKHAJKFLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x22B2B00", Offset = "0x22B1D00", VA = "0x1822B2B00")]
	public static JPGILOLJKGD JHIOLOAEPHF(this GHDPNCEOOFB KPIHKJNPOFH)
	{
		return default(JPGILOLJKGD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class CCIJKIIOILI
{
	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x222CD80", Offset = "0x222BF80", VA = "0x18222CD80")]
	public static Dictionary<TDeserializedKey, TDeserializedValue> LGLJAPGEHMH<TDeserializedKey, TDeserializedValue, TSerialized>(this RepeatedField<TSerialized> CCBKAEHNCPH, Func<TSerialized, TDeserializedKey> DJEFKPKALPP, Func<TSerialized, TDeserializedValue> IECEALLOEGN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class NNEMPHOHFGD
{
	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x22C4CD0", Offset = "0x22C3ED0", VA = "0x1822C4CD0")]
	public static CMPOPDCCFIJ IOAMGHHAJNN(this in EMDNBGDJJLK KPIHKJNPOFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x22C4D60", Offset = "0x22C3F60", VA = "0x1822C4D60")]
	public static EMDNBGDJJLK JHIOLOAEPHF(this CMPOPDCCFIJ KPIHKJNPOFH)
	{
		return default(EMDNBGDJJLK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class POGEAIJMBFG
{
	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x22C64D0", Offset = "0x22C56D0", VA = "0x1822C64D0")]
	public static LPDJFKOHFFO IOAMGHHAJNN(this in GCHOILLPJFD KPIHKJNPOFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x22C6780", Offset = "0x22C5980", VA = "0x1822C6780")]
	public static GCHOILLPJFD JHIOLOAEPHF(this LPDJFKOHFFO KPIHKJNPOFH)
	{
		return default(GCHOILLPJFD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public readonly struct EAEJNFGLNJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public readonly HOGMOCHAFIO<ICMDIGALLLM> NAHPHGJADGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public readonly HOGMOCHAFIO<JDAAGGKKBIF> EKMCEGABMAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public readonly int OAEEDGKJHNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public readonly KBEKINGHEED GLGPHBABLMM;

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x22B17E0", Offset = "0x22B09E0", VA = "0x1822B17E0")]
	private EAEJNFGLNJC(HOGMOCHAFIO<ICMDIGALLLM> MKJGAIOAKMJ, HOGMOCHAFIO<JDAAGGKKBIF> ICCMHBOIOOM, int HBOHKIHEFEM, KBEKINGHEED FBNKHAJKFLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x22B1600", Offset = "0x22B0800", VA = "0x1822B1600")]
	public static KDDOJAECMMJ<IFHFCBJLIGK, EAEJNFGLNJC> JGGKNCMPFBF(AKEADGDIFCI IDBBHLFECOA)
	{
		return default(KDDOJAECMMJ<IFHFCBJLIGK, EAEJNFGLNJC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0xF0F560", Offset = "0xF0E760", VA = "0x180F0F560")]
	public static PINPMIPFEPJ<(HOGMOCHAFIO<GKDGBEBJKOB>, HOGMOCHAFIO<LMGKNPKGIBN>), IFCPLEGMLKF> BCNLOPJLHFI<TRoot>(TRoot MKADPIPCNMO, in EAEJNFGLNJC KPIHKJNPOFH) where TRoot : OIGBHDHBPIE
	{
		return default(PINPMIPFEPJ<(HOGMOCHAFIO<GKDGBEBJKOB>, HOGMOCHAFIO<LMGKNPKGIBN>), IFCPLEGMLKF>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public readonly struct FLPFMAMHLEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public readonly HOGMOCHAFIO<ICMDIGALLLM>? BNOGJIMILFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public readonly HOGMOCHAFIO<JEPEPFIODEH> JJPIKKPPDBL;

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x15BD090", Offset = "0x15BC290", VA = "0x1815BD090")]
	private FLPFMAMHLEF(HOGMOCHAFIO<ICMDIGALLLM>? CLIFPPHNEDA, HOGMOCHAFIO<JEPEPFIODEH> OHHJFFCEJLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x22B2E70", Offset = "0x22B2070", VA = "0x1822B2E70")]
	public static KDDOJAECMMJ<IFHFCBJLIGK, FLPFMAMHLEF> JGGKNCMPFBF(AKEADGDIFCI IDBBHLFECOA)
	{
		return default(KDDOJAECMMJ<IFHFCBJLIGK, FLPFMAMHLEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x1E23210", Offset = "0x1E22410", VA = "0x181E23210")]
	public static PINPMIPFEPJ<HOGMOCHAFIO<ICMDIGALLLM>, IFCPLEGMLKF> BCNLOPJLHFI<TRoot>(TRoot MKADPIPCNMO, in FLPFMAMHLEF KPIHKJNPOFH) where TRoot : OIGBHDHBPIE
	{
		return default(PINPMIPFEPJ<HOGMOCHAFIO<ICMDIGALLLM>, IFCPLEGMLKF>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public readonly struct GDIHKFGEEHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public readonly HOGMOCHAFIO<ICMDIGALLLM> NAHPHGJADGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public readonly HOGMOCHAFIO<JDAAGGKKBIF> EKMCEGABMAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public readonly int JNFIAIMHHBA;

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x1843600", Offset = "0x1842800", VA = "0x181843600")]
	private GDIHKFGEEHC(HOGMOCHAFIO<ICMDIGALLLM> MKJGAIOAKMJ, HOGMOCHAFIO<JDAAGGKKBIF> ICCMHBOIOOM, int HJAPCGDAJBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x22B3670", Offset = "0x22B2870", VA = "0x1822B3670")]
	public static KDDOJAECMMJ<IFHFCBJLIGK, GDIHKFGEEHC> JGGKNCMPFBF(AKEADGDIFCI IDBBHLFECOA)
	{
		return default(KDDOJAECMMJ<IFHFCBJLIGK, GDIHKFGEEHC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x1E276A0", Offset = "0x1E268A0", VA = "0x181E276A0")]
	public static PINPMIPFEPJ<CKDLGNFJNCJ, IFCPLEGMLKF> BCNLOPJLHFI<TRoot>(TRoot MKADPIPCNMO, in GDIHKFGEEHC KPIHKJNPOFH) where TRoot : OIGBHDHBPIE
	{
		return default(PINPMIPFEPJ<CKDLGNFJNCJ, IFCPLEGMLKF>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public readonly struct JJIFAENGKCL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public readonly HOGMOCHAFIO<ICMDIGALLLM> NAHPHGJADGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public readonly HOGMOCHAFIO<LMGKNPKGIBN> AICLDIMMEIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public readonly HOGMOCHAFIO<GKDGBEBJKOB> IIHLIKLINPK;

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x1843600", Offset = "0x1842800", VA = "0x181843600")]
	private JJIFAENGKCL(HOGMOCHAFIO<ICMDIGALLLM> MKJGAIOAKMJ, HOGMOCHAFIO<LMGKNPKGIBN> NCCJMIAEPCN, HOGMOCHAFIO<GKDGBEBJKOB> IHJIAJKANJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x22B6190", Offset = "0x22B5390", VA = "0x1822B6190")]
	public static KDDOJAECMMJ<IFHFCBJLIGK, JJIFAENGKCL> JGGKNCMPFBF(AKEADGDIFCI IDBBHLFECOA)
	{
		return default(KDDOJAECMMJ<IFHFCBJLIGK, JJIFAENGKCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x1B36BA0", Offset = "0x1B35DA0", VA = "0x181B36BA0")]
	public static PINPMIPFEPJ<CKDLGNFJNCJ, IFCPLEGMLKF> BCNLOPJLHFI<TRoot>(TRoot MKADPIPCNMO, in JJIFAENGKCL KPIHKJNPOFH) where TRoot : OIGBHDHBPIE
	{
		return default(PINPMIPFEPJ<CKDLGNFJNCJ, IFCPLEGMLKF>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public readonly struct IHGGNEMJKAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public readonly HOGMOCHAFIO<ICMDIGALLLM> NAHPHGJADGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public readonly HOGMOCHAFIO<JDAAGGKKBIF> EKMCEGABMAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public readonly int OAEEDGKJHNC;

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x1843600", Offset = "0x1842800", VA = "0x181843600")]
	private IHGGNEMJKAI(HOGMOCHAFIO<ICMDIGALLLM> MKJGAIOAKMJ, HOGMOCHAFIO<JDAAGGKKBIF> ICCMHBOIOOM, int HJAPCGDAJBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x22B5430", Offset = "0x22B4630", VA = "0x1822B5430")]
	public static KDDOJAECMMJ<IFHFCBJLIGK, IHGGNEMJKAI> JGGKNCMPFBF(AKEADGDIFCI IDBBHLFECOA)
	{
		return default(KDDOJAECMMJ<IFHFCBJLIGK, IHGGNEMJKAI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x21874B0", Offset = "0x21866B0", VA = "0x1821874B0")]
	public static PINPMIPFEPJ<CKDLGNFJNCJ, IFCPLEGMLKF> BCNLOPJLHFI<TRoot>(TRoot MKADPIPCNMO, in IHGGNEMJKAI KPIHKJNPOFH) where TRoot : OIGBHDHBPIE
	{
		return default(PINPMIPFEPJ<CKDLGNFJNCJ, IFCPLEGMLKF>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public readonly struct DCAFPBPKKNL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public readonly HOGMOCHAFIO<ICMDIGALLLM> NAHPHGJADGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public readonly HOGMOCHAFIO<JDAAGGKKBIF> EKMCEGABMAO;

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x8B6A50", Offset = "0x8B5C50", VA = "0x1808B6A50")]
	private DCAFPBPKKNL(HOGMOCHAFIO<ICMDIGALLLM> MKJGAIOAKMJ, HOGMOCHAFIO<JDAAGGKKBIF> ICCMHBOIOOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x22AFC20", Offset = "0x22AEE20", VA = "0x1822AFC20")]
	public static KDDOJAECMMJ<IFHFCBJLIGK, DCAFPBPKKNL> JGGKNCMPFBF(AKEADGDIFCI IDBBHLFECOA)
	{
		return default(KDDOJAECMMJ<IFHFCBJLIGK, DCAFPBPKKNL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x1CC66F0", Offset = "0x1CC58F0", VA = "0x181CC66F0")]
	public static PINPMIPFEPJ<CKDLGNFJNCJ, IFCPLEGMLKF> BCNLOPJLHFI<TRoot>(TRoot MKADPIPCNMO, in DCAFPBPKKNL KPIHKJNPOFH) where TRoot : OIGBHDHBPIE
	{
		return default(PINPMIPFEPJ<CKDLGNFJNCJ, IFCPLEGMLKF>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public readonly struct DGEEBODENGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public readonly HOGMOCHAFIO<ICMDIGALLLM> NAHPHGJADGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public readonly HOGMOCHAFIO<GKDGBEBJKOB> DAHJHNMCBJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public readonly JPGILOLJKGD LJPKJOAENPD;

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x22B1160", Offset = "0x22B0360", VA = "0x1822B1160")]
	private DGEEBODENGC(HOGMOCHAFIO<ICMDIGALLLM> MKJGAIOAKMJ, HOGMOCHAFIO<GKDGBEBJKOB> FOIFMMOKJPC, in JPGILOLJKGD HMGHIIACOGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x22B0FF0", Offset = "0x22B01F0", VA = "0x1822B0FF0")]
	public static KDDOJAECMMJ<IFHFCBJLIGK, DGEEBODENGC> JGGKNCMPFBF(AKEADGDIFCI IDBBHLFECOA)
	{
		return default(KDDOJAECMMJ<IFHFCBJLIGK, DGEEBODENGC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x1CC9C90", Offset = "0x1CC8E90", VA = "0x181CC9C90")]
	public static PINPMIPFEPJ<CKDLGNFJNCJ, IFCPLEGMLKF> BCNLOPJLHFI<TRoot>(TRoot MKADPIPCNMO, in DGEEBODENGC KPIHKJNPOFH) where TRoot : OIGBHDHBPIE
	{
		return default(PINPMIPFEPJ<CKDLGNFJNCJ, IFCPLEGMLKF>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public readonly struct KDGCECCOGHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public readonly HOGMOCHAFIO<ICMDIGALLLM> NAHPHGJADGH;

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x892940", Offset = "0x891B40", VA = "0x180892940")]
	private KDGCECCOGHF(HOGMOCHAFIO<ICMDIGALLLM> MKJGAIOAKMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x22B6DE0", Offset = "0x22B5FE0", VA = "0x1822B6DE0")]
	public static KDDOJAECMMJ<IFHFCBJLIGK, KDGCECCOGHF> JGGKNCMPFBF(AKEADGDIFCI IDBBHLFECOA)
	{
		return default(KDDOJAECMMJ<IFHFCBJLIGK, KDGCECCOGHF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x1CCDD90", Offset = "0x1CCCF90", VA = "0x181CCDD90")]
	public static PINPMIPFEPJ<CKDLGNFJNCJ, IFCPLEGMLKF> BCNLOPJLHFI<TRoot>(TRoot MKADPIPCNMO, in KDGCECCOGHF KPIHKJNPOFH) where TRoot : OIGBHDHBPIE
	{
		return default(PINPMIPFEPJ<CKDLGNFJNCJ, IFCPLEGMLKF>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public readonly struct ACENCJNBOOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public readonly HOGMOCHAFIO<ICMDIGALLLM> NAHPHGJADGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public readonly HOGMOCHAFIO<LMGKNPKGIBN> AICLDIMMEIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public readonly HOGMOCHAFIO<GKDGBEBJKOB> IIHLIKLINPK;

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x1843600", Offset = "0x1842800", VA = "0x181843600")]
	private ACENCJNBOOO(HOGMOCHAFIO<ICMDIGALLLM> MKJGAIOAKMJ, HOGMOCHAFIO<LMGKNPKGIBN> NCCJMIAEPCN, HOGMOCHAFIO<GKDGBEBJKOB> IHJIAJKANJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x22A3240", Offset = "0x22A2440", VA = "0x1822A3240")]
	public static KDDOJAECMMJ<IFHFCBJLIGK, ACENCJNBOOO> JGGKNCMPFBF(AKEADGDIFCI IDBBHLFECOA)
	{
		return default(KDDOJAECMMJ<IFHFCBJLIGK, ACENCJNBOOO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x1FCC330", Offset = "0x1FCB530", VA = "0x181FCC330")]
	public static PINPMIPFEPJ<CKDLGNFJNCJ, IFCPLEGMLKF> BCNLOPJLHFI<TRoot>(TRoot MKADPIPCNMO, in ACENCJNBOOO KPIHKJNPOFH) where TRoot : OIGBHDHBPIE
	{
		return default(PINPMIPFEPJ<CKDLGNFJNCJ, IFCPLEGMLKF>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public readonly struct FFMAAHGLCCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public readonly HOGMOCHAFIO<ICMDIGALLLM> NAHPHGJADGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public readonly HOGMOCHAFIO<JDAAGGKKBIF> EKMCEGABMAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public readonly HOGMOCHAFIO<ALBFEPNKGJA> PPDPELFAJOP;

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x1843600", Offset = "0x1842800", VA = "0x181843600")]
	private FFMAAHGLCCE(HOGMOCHAFIO<ICMDIGALLLM> MKJGAIOAKMJ, HOGMOCHAFIO<JDAAGGKKBIF> ICCMHBOIOOM, HOGMOCHAFIO<ALBFEPNKGJA> IAEFNJNFKHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x22B2C10", Offset = "0x22B1E10", VA = "0x1822B2C10")]
	public static KDDOJAECMMJ<IFHFCBJLIGK, FFMAAHGLCCE> JGGKNCMPFBF(AKEADGDIFCI IDBBHLFECOA)
	{
		return default(KDDOJAECMMJ<IFHFCBJLIGK, FFMAAHGLCCE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x1E205D0", Offset = "0x1E1F7D0", VA = "0x181E205D0")]
	public static PINPMIPFEPJ<HOGMOCHAFIO<GKDGBEBJKOB>, IFCPLEGMLKF> BCNLOPJLHFI<TRoot>(TRoot MKADPIPCNMO, in FFMAAHGLCCE KPIHKJNPOFH) where TRoot : OIGBHDHBPIE
	{
		return default(PINPMIPFEPJ<HOGMOCHAFIO<GKDGBEBJKOB>, IFCPLEGMLKF>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public readonly struct IDLOPPMDIIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public readonly HOGMOCHAFIO<ICMDIGALLLM> NAHPHGJADGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public readonly HOGMOCHAFIO<JDAAGGKKBIF> EKMCEGABMAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public readonly int JNFIAIMHHBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public readonly KBEKINGHEED GLGPHBABLMM;

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x22B17E0", Offset = "0x22B09E0", VA = "0x1822B17E0")]
	private IDLOPPMDIIO(HOGMOCHAFIO<ICMDIGALLLM> MKJGAIOAKMJ, HOGMOCHAFIO<JDAAGGKKBIF> ICCMHBOIOOM, int HBOHKIHEFEM, KBEKINGHEED FBNKHAJKFLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x22B5250", Offset = "0x22B4450", VA = "0x1822B5250")]
	public static KDDOJAECMMJ<IFHFCBJLIGK, IDLOPPMDIIO> JGGKNCMPFBF(AKEADGDIFCI IDBBHLFECOA)
	{
		return default(KDDOJAECMMJ<IFHFCBJLIGK, IDLOPPMDIIO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x2185310", Offset = "0x2184510", VA = "0x182185310")]
	public static PINPMIPFEPJ<(HOGMOCHAFIO<LMGKNPKGIBN>, HOGMOCHAFIO<GKDGBEBJKOB>), IFCPLEGMLKF> BCNLOPJLHFI<TRoot>(TRoot MKADPIPCNMO, in IDLOPPMDIIO KPIHKJNPOFH) where TRoot : OIGBHDHBPIE
	{
		return default(PINPMIPFEPJ<(HOGMOCHAFIO<LMGKNPKGIBN>, HOGMOCHAFIO<GKDGBEBJKOB>), IFCPLEGMLKF>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public readonly struct KCPFEKKDBMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public readonly HOGMOCHAFIO<ICMDIGALLLM> NAHPHGJADGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public readonly HOGMOCHAFIO<GHMFAIJCADA> ODOALINIFNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public readonly DDAEIDDGCJK IEOOHOKMJDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public readonly HBNLMECNNNL NDNFEPKHJBP;

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x22B6DB0", Offset = "0x22B5FB0", VA = "0x1822B6DB0")]
	private KCPFEKKDBMC(HOGMOCHAFIO<ICMDIGALLLM> MKJGAIOAKMJ, HOGMOCHAFIO<GHMFAIJCADA> PJBEHNFNPHJ, in DDAEIDDGCJK DIOAPAAKLIC, in HBNLMECNNNL BLEGHJKCIHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x22B6C10", Offset = "0x22B5E10", VA = "0x1822B6C10")]
	public static KDDOJAECMMJ<IFHFCBJLIGK, KCPFEKKDBMC> JGGKNCMPFBF(AKEADGDIFCI IDBBHLFECOA)
	{
		return default(KDDOJAECMMJ<IFHFCBJLIGK, KCPFEKKDBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x1CCDB00", Offset = "0x1CCCD00", VA = "0x181CCDB00")]
	public static PINPMIPFEPJ<HOGMOCHAFIO<JDAAGGKKBIF>, IFCPLEGMLKF> BCNLOPJLHFI<TRoot>(TRoot MKADPIPCNMO, in KCPFEKKDBMC KPIHKJNPOFH) where TRoot : OIGBHDHBPIE
	{
		return default(PINPMIPFEPJ<HOGMOCHAFIO<JDAAGGKKBIF>, IFCPLEGMLKF>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public sealed class ECMOOHKNPPJ : JMNANGFJPJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public readonly HOGMOCHAFIO<ALBFEPNKGJA> BIBBGFDOMAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public readonly HOGMOCHAFIO<GOHONMAKFBH> ILMGHOMPJAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public readonly HOGMOCHAFIO<GOHONMAKFBH> EFHFOAEALHP;

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x22B1800", Offset = "0x22B0A00", VA = "0x1822B1800")]
	public ECMOOHKNPPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public sealed class MBBJBDANAHH : BPFDCABLFKP
{
	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x22C3200", Offset = "0x22C2400", VA = "0x1822C3200")]
	public MBBJBDANAHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public sealed class KLOINKGAIDH : GKEHNPJGKLE
{
	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "11")]
	public override void DGOEPLKKMBK(CCOHKDMNIBE DJPMGOGNGEK, HOGMOCHAFIO<ICMDIGALLLM> MKJGAIOAKMJ, HOGMOCHAFIO<JDAAGGKKBIF> ICCMHBOIOOM, ref CDFBBMKPBAJ EAMFJKAPHDI, HOGMOCHAFIO<PAKIHOAJDHN.EBGDPIKPOKJ>? GILPHBNEOBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "12")]
	public override void JAOIDMDEJFG(CCOHKDMNIBE DJPMGOGNGEK, HOGMOCHAFIO<ICMDIGALLLM> MKJGAIOAKMJ, HOGMOCHAFIO<JDAAGGKKBIF> ICCMHBOIOOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x22B8540", Offset = "0x22B7740", VA = "0x1822B8540", Slot = "13")]
	public override IEnumerable<EIOPCJCEFMB<DOHCCNMLPPO>> IOKGPDKHOME(CCOHKDMNIBE DJPMGOGNGEK, HOGMOCHAFIO<ICMDIGALLLM> MKJGAIOAKMJ, HOGMOCHAFIO<JDAAGGKKBIF> ICCMHBOIOOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x22B8570", Offset = "0x22B7770", VA = "0x1822B8570", Slot = "14")]
	public override void KIHBHHNNMIA(CCOHKDMNIBE DJPMGOGNGEK, HOGMOCHAFIO<ICMDIGALLLM> MKJGAIOAKMJ, HOGMOCHAFIO<JDAAGGKKBIF> ICCMHBOIOOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x22B8420", Offset = "0x22B7620", VA = "0x1822B8420")]
	public static void HOGLJMBHFKK(CCOHKDMNIBE DJPMGOGNGEK, in CNFPBDKMBAG.NCCGPJPNMPO LBFANMPPDEH, HOGMOCHAFIO<ICMDIGALLLM> MKJGAIOAKMJ, HOGMOCHAFIO<GKDGBEBJKOB> FOIFMMOKJPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x22A38C0", Offset = "0x22A2AC0", VA = "0x1822A38C0", Slot = "15")]
	public override JPGILOLJKGD PCNCMBNMFLF(CCOHKDMNIBE DJPMGOGNGEK, HOGMOCHAFIO<ICMDIGALLLM> MKJGAIOAKMJ, HOGMOCHAFIO<JDAAGGKKBIF> ICCMHBOIOOM, HOGMOCHAFIO<ALBFEPNKGJA> IAEFNJNFKHM, DOHCCNMLPPO BKGDKBLDMEG)
	{
		return default(JPGILOLJKGD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x22A3900", Offset = "0x22A2B00", VA = "0x1822A3900")]
	public KLOINKGAIDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public struct EMDNBGDJJLK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public DDAEIDDGCJK IEOOHOKMJDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public HBNLMECNNNL NDNFEPKHJBP;

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x22B23E0", Offset = "0x22B15E0", VA = "0x1822B23E0")]
	internal EMDNBGDJJLK(in DDAEIDDGCJK DGDMDKFMBBA, in HBNLMECNNNL KGFPECIFPNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x22B2390", Offset = "0x22B1590", VA = "0x1822B2390")]
	public static EMDNBGDJJLK HBHNAKPOBBF()
	{
		return default(EMDNBGDJJLK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x22B23C0", Offset = "0x22B15C0", VA = "0x1822B23C0")]
	public static EMDNBGDJJLK HKMLEDGAFIJ(in DDAEIDDGCJK DGDMDKFMBBA, in HBNLMECNNNL KGFPECIFPNA)
	{
		return default(EMDNBGDJJLK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public abstract class GKEHNPJGKLE : HPGIPEFIABK<CCOHKDMNIBE>
{
	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x22A3900", Offset = "0x22A2B00", VA = "0x1822A3900")]
	protected GKEHNPJGKLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public sealed class AGIPLIMHIOH : GKEHNPJGKLE
{
	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "11")]
	public override void DGOEPLKKMBK(CCOHKDMNIBE DJPMGOGNGEK, HOGMOCHAFIO<ICMDIGALLLM> MKJGAIOAKMJ, HOGMOCHAFIO<JDAAGGKKBIF> ICCMHBOIOOM, ref CDFBBMKPBAJ EAMFJKAPHDI, HOGMOCHAFIO<PAKIHOAJDHN.EBGDPIKPOKJ>? GILPHBNEOBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "12")]
	public override void JAOIDMDEJFG(CCOHKDMNIBE DJPMGOGNGEK, HOGMOCHAFIO<ICMDIGALLLM> MKJGAIOAKMJ, HOGMOCHAFIO<JDAAGGKKBIF> ICCMHBOIOOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x22A36C0", Offset = "0x22A28C0", VA = "0x1822A36C0", Slot = "13")]
	public override IEnumerable<EIOPCJCEFMB<DOHCCNMLPPO>> IOKGPDKHOME(CCOHKDMNIBE DJPMGOGNGEK, HOGMOCHAFIO<ICMDIGALLLM> MKJGAIOAKMJ, HOGMOCHAFIO<JDAAGGKKBIF> ICCMHBOIOOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x22A36F0", Offset = "0x22A28F0", VA = "0x1822A36F0", Slot = "14")]
	public override void KIHBHHNNMIA(CCOHKDMNIBE DJPMGOGNGEK, HOGMOCHAFIO<ICMDIGALLLM> MKJGAIOAKMJ, HOGMOCHAFIO<JDAAGGKKBIF> ICCMHBOIOOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x22A35A0", Offset = "0x22A27A0", VA = "0x1822A35A0")]
	public static void DJIIFJCCHHE(CCOHKDMNIBE DJPMGOGNGEK, in CNFPBDKMBAG.NCCGPJPNMPO LBFANMPPDEH, HOGMOCHAFIO<ICMDIGALLLM> MKJGAIOAKMJ, HOGMOCHAFIO<LMGKNPKGIBN> OJFIKOGMAOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x22A38C0", Offset = "0x22A2AC0", VA = "0x1822A38C0", Slot = "15")]
	public override JPGILOLJKGD PCNCMBNMFLF(CCOHKDMNIBE DJPMGOGNGEK, HOGMOCHAFIO<ICMDIGALLLM> MKJGAIOAKMJ, HOGMOCHAFIO<JDAAGGKKBIF> ICCMHBOIOOM, HOGMOCHAFIO<ALBFEPNKGJA> IAEFNJNFKHM, DOHCCNMLPPO BKGDKBLDMEG)
	{
		return default(JPGILOLJKGD);
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x22A3900", Offset = "0x22A2B00", VA = "0x1822A3900")]
	public AGIPLIMHIOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public sealed class DENNEJJINFF : HKDDMDLJJCP
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x22B0080", Offset = "0x22AF280", VA = "0x1822B0080")]
	public DENNEJJINFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public sealed class MGAMELBMODM : HKDDMDLJJCP
{
	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x22C3460", Offset = "0x22C2660", VA = "0x1822C3460")]
	public MGAMELBMODM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public sealed class CBOJFLAOHKE : GKEHNPJGKLE
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public sealed class CDLIOBMNMPD : KPPFBPGGFHN.FLCGICOCEGK
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public struct LDLHMPEEEJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public readonly HOGMOCHAFIO<ICMDIGALLLM> JENEMHGKIHJ;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x892940", Offset = "0x891B40", VA = "0x180892940")]
		private LDLHMPEEEJN(HOGMOCHAFIO<ICMDIGALLLM> HCENIOOPPFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x146B210", Offset = "0x146A410", VA = "0x18146B210")]
		public static LDLHMPEEEJN HBHNAKPOBBF(HOGMOCHAFIO<ICMDIGALLLM> PJIKPKIGHGJ)
		{
			return default(LDLHMPEEEJN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x22AA910", Offset = "0x22A9B10", VA = "0x1822AA910", Slot = "11")]
	public override void DGOEPLKKMBK(CCOHKDMNIBE DJPMGOGNGEK, HOGMOCHAFIO<ICMDIGALLLM> MKJGAIOAKMJ, HOGMOCHAFIO<JDAAGGKKBIF> ICCMHBOIOOM, ref CDFBBMKPBAJ EAMFJKAPHDI, HOGMOCHAFIO<PAKIHOAJDHN.EBGDPIKPOKJ>? GILPHBNEOBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x22AAD30", Offset = "0x22A9F30", VA = "0x1822AAD30", Slot = "12")]
	public override void JAOIDMDEJFG(CCOHKDMNIBE DJPMGOGNGEK, HOGMOCHAFIO<ICMDIGALLLM> MKJGAIOAKMJ, HOGMOCHAFIO<JDAAGGKKBIF> ICCMHBOIOOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x22AAC70", Offset = "0x22A9E70", VA = "0x1822AAC70", Slot = "13")]
	public override IEnumerable<EIOPCJCEFMB<DOHCCNMLPPO>> IOKGPDKHOME(CCOHKDMNIBE DJPMGOGNGEK, HOGMOCHAFIO<ICMDIGALLLM> MKJGAIOAKMJ, HOGMOCHAFIO<JDAAGGKKBIF> ICCMHBOIOOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x22AAE80", Offset = "0x22AA080", VA = "0x1822AAE80", Slot = "14")]
	public override void KIHBHHNNMIA(CCOHKDMNIBE DJPMGOGNGEK, HOGMOCHAFIO<ICMDIGALLLM> MKJGAIOAKMJ, HOGMOCHAFIO<JDAAGGKKBIF> ICCMHBOIOOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x22AAB80", Offset = "0x22A9D80", VA = "0x1822AAB80")]
	public static void HOGLJMBHFKK(CCOHKDMNIBE DJPMGOGNGEK, in CNFPBDKMBAG.NCCGPJPNMPO LBFANMPPDEH, HOGMOCHAFIO<ICMDIGALLLM> MKJGAIOAKMJ, HOGMOCHAFIO<GKDGBEBJKOB> FOIFMMOKJPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x22AAA90", Offset = "0x22A9C90", VA = "0x1822AAA90")]
	public static void DJIIFJCCHHE(CCOHKDMNIBE DJPMGOGNGEK, in CNFPBDKMBAG.NCCGPJPNMPO LBFANMPPDEH, HOGMOCHAFIO<ICMDIGALLLM> MKJGAIOAKMJ, HOGMOCHAFIO<LMGKNPKGIBN> OJFIKOGMAOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x22A38C0", Offset = "0x22A2AC0", VA = "0x1822A38C0", Slot = "15")]
	public override JPGILOLJKGD PCNCMBNMFLF(CCOHKDMNIBE DJPMGOGNGEK, HOGMOCHAFIO<ICMDIGALLLM> MKJGAIOAKMJ, HOGMOCHAFIO<JDAAGGKKBIF> ICCMHBOIOOM, HOGMOCHAFIO<ALBFEPNKGJA> IAEFNJNFKHM, DOHCCNMLPPO BKGDKBLDMEG)
	{
		return default(JPGILOLJKGD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x22A3900", Offset = "0x22A2B00", VA = "0x1822A3900")]
	public CBOJFLAOHKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public abstract class JMNANGFJPJI : JNMBHALIOGK<CCOHKDMNIBE>
{
	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x22AA8C0", Offset = "0x22A9AC0", VA = "0x1822AA8C0")]
	protected JMNANGFJPJI(in HFGOKOFIOCE HMKPFMLALPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x22B62D0", Offset = "0x22B54D0", VA = "0x1822B62D0", Slot = "11")]
	public override void DGOEPLKKMBK(CCOHKDMNIBE MKADPIPCNMO, HOGMOCHAFIO<ICMDIGALLLM> MKJGAIOAKMJ, HOGMOCHAFIO<JDAAGGKKBIF> ICCMHBOIOOM, ref CDFBBMKPBAJ EAMFJKAPHDI, HOGMOCHAFIO<PAKIHOAJDHN.EBGDPIKPOKJ>? GILPHBNEOBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x22B6350", Offset = "0x22B5550", VA = "0x1822B6350", Slot = "14")]
	public override void KIHBHHNNMIA(CCOHKDMNIBE MKADPIPCNMO, HOGMOCHAFIO<ICMDIGALLLM> MKJGAIOAKMJ, HOGMOCHAFIO<JDAAGGKKBIF> ICCMHBOIOOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public abstract class BPFDCABLFKP : JMNANGFJPJI
{
	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x22AA8C0", Offset = "0x22A9AC0", VA = "0x1822AA8C0")]
	public BPFDCABLFKP(in HFGOKOFIOCE HMKPFMLALPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public abstract class HKDDMDLJJCP : FPDDOAOGDDJ<CCOHKDMNIBE>
{
	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x22B4A30", Offset = "0x22B3C30", VA = "0x1822B4A30")]
	protected HKDDMDLJJCP(in OMGGIABMIOO HMKPFMLALPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x22B4870", Offset = "0x22B3A70", VA = "0x1822B4870", Slot = "11")]
	public override void DGOEPLKKMBK(CCOHKDMNIBE MKADPIPCNMO, HOGMOCHAFIO<ICMDIGALLLM> MKJGAIOAKMJ, HOGMOCHAFIO<JDAAGGKKBIF> ICCMHBOIOOM, ref CDFBBMKPBAJ EAMFJKAPHDI, HOGMOCHAFIO<PAKIHOAJDHN.EBGDPIKPOKJ>? GILPHBNEOBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x22B4920", Offset = "0x22B3B20", VA = "0x1822B4920", Slot = "12")]
	public override void JAOIDMDEJFG(CCOHKDMNIBE MKADPIPCNMO, HOGMOCHAFIO<ICMDIGALLLM> MKJGAIOAKMJ, HOGMOCHAFIO<JDAAGGKKBIF> ICCMHBOIOOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x22B49B0", Offset = "0x22B3BB0", VA = "0x1822B49B0", Slot = "14")]
	public override void KIHBHHNNMIA(CCOHKDMNIBE MKADPIPCNMO, HOGMOCHAFIO<ICMDIGALLLM> MKJGAIOAKMJ, HOGMOCHAFIO<JDAAGGKKBIF> ICCMHBOIOOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x22B4720", Offset = "0x22B3920", VA = "0x1822B4720", Slot = "17")]
	public override PINPMIPFEPJ<HOGMOCHAFIO<GKDGBEBJKOB>, IFCPLEGMLKF> AKNGMNJALMF(CCOHKDMNIBE MKADPIPCNMO, HOGMOCHAFIO<ICMDIGALLLM> MKJGAIOAKMJ, HOGMOCHAFIO<JDAAGGKKBIF> ICCMHBOIOOM, HOGMOCHAFIO<ALBFEPNKGJA> IAEFNJNFKHM)
	{
		return default(PINPMIPFEPJ<HOGMOCHAFIO<GKDGBEBJKOB>, IFCPLEGMLKF>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public readonly struct LGEPEGEPCJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly Guid GIIBBLDHGMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly string IPHJOIJOMJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly bool LGFNNOMDHMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly bool NHAELOKHGDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly bool OFPKMCNGKIC;

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x22B95A0", Offset = "0x22B87A0", VA = "0x1822B95A0")]
	public LGEPEGEPCJP(in Guid CJNGPAPKKID, string JPKENOAMLIN, bool PMNEMODDKHC, bool HGDHMGJBFKB, bool NNFLOEKKCBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x22B92E0", Offset = "0x22B84E0", VA = "0x1822B92E0")]
	public BIOPDCKJBKC CONNPPJFIGI(string JPKENOAMLIN, DOHCCNMLPPO FBNKHAJKFLM)
	{
		return default(BIOPDCKJBKC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x22B94B0", Offset = "0x22B86B0", VA = "0x1822B94B0")]
	public CGGGBGKAGDM IBBPKBDNAAG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public abstract class LMDALGICMAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public readonly DOHCCNMLPPO JKIMAFAGCOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private readonly List<CGGGBGKAGDM> PHNHKDKKJNF;

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public IReadOnlyList<CGGGBGKAGDM> BGBLIBEGMLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x22C2ED0", Offset = "0x22C20D0", VA = "0x1822C2ED0")]
	protected LMDALGICMAD(DOHCCNMLPPO AEMDKFOPMAM, params CGGGBGKAGDM[][] GMLEHOPIEEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class DBLFMMNMPKF : LMDALGICMAD
{
	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x22AFA00", Offset = "0x22AEC00", VA = "0x1822AFA00")]
	internal DBLFMMNMPKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class CKFMGJOLNBL : LMDALGICMAD
{
	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x22AF120", Offset = "0x22AE320", VA = "0x1822AF120")]
	internal CKFMGJOLNBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class KHIKFBFPDLP : LMDALGICMAD
{
	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x22B80C0", Offset = "0x22B72C0", VA = "0x1822B80C0")]
	internal KHIKFBFPDLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class DFMMKJMAILF : LMDALGICMAD
{
	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x22B0DD0", Offset = "0x22AFFD0", VA = "0x1822B0DD0")]
	internal DFMMKJMAILF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class GFKPAAHKFCM : LMDALGICMAD
{
	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x22B3780", Offset = "0x22B2980", VA = "0x1822B3780")]
	internal GFKPAAHKFCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class NGGKELBGBAI : LMDALGICMAD
{
	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x22C47C0", Offset = "0x22C39C0", VA = "0x1822C47C0")]
	internal NGGKELBGBAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public class LNNDNJMEIPP : LMDALGICMAD
{
	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x22C2FE0", Offset = "0x22C21E0", VA = "0x1822C2FE0")]
	internal LNNDNJMEIPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class MOHDAOFEJFJ : LMDALGICMAD
{
	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x22C3D80", Offset = "0x22C2F80", VA = "0x1822C3D80")]
	internal MOHDAOFEJFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class EEDDNAGLOCA : LMDALGICMAD
{
	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x22B1D30", Offset = "0x22B0F30", VA = "0x1822B1D30")]
	internal EEDDNAGLOCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class NBNGOPBMBEF : LMDALGICMAD
{
	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x22C41C0", Offset = "0x22C33C0", VA = "0x1822C41C0")]
	internal NBNGOPBMBEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class IMDIIIGOOFG : LMDALGICMAD
{
	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x22B5A10", Offset = "0x22B4C10", VA = "0x1822B5A10")]
	internal IMDIIIGOOFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class DLGGBKENAPN : LMDALGICMAD
{
	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x22B1180", Offset = "0x22B0380", VA = "0x1822B1180")]
	internal DLGGBKENAPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class LLDJAOHNLNF : LMDALGICMAD
{
	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x22C2CB0", Offset = "0x22C1EB0", VA = "0x1822C2CB0")]
	internal LLDJAOHNLNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class OMBKLDPJLHH : LMDALGICMAD
{
	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x22C5E70", Offset = "0x22C5070", VA = "0x1822C5E70")]
	internal OMBKLDPJLHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class NFMOFENBBEL : LMDALGICMAD
{
	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x22C4590", Offset = "0x22C3790", VA = "0x1822C4590")]
	internal NFMOFENBBEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class KNBIOOJBALE : LMDALGICMAD
{
	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x22B8740", Offset = "0x22B7940", VA = "0x1822B8740")]
	internal KNBIOOJBALE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class OFGDGHFALAF : LMDALGICMAD
{
	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x22C4FE0", Offset = "0x22C41E0", VA = "0x1822C4FE0")]
	internal OFGDGHFALAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class ONLIMCKHLJE : LMDALGICMAD
{
	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x22C6090", Offset = "0x22C5290", VA = "0x1822C6090")]
	internal ONLIMCKHLJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class JOGPGNGLCAK : LMDALGICMAD
{
	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x22B63D0", Offset = "0x22B55D0", VA = "0x1822B63D0")]
	internal JOGPGNGLCAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class OGNNJBMFFNK : LMDALGICMAD
{
	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x22C56C0", Offset = "0x22C48C0", VA = "0x1822C56C0")]
	internal OGNNJBMFFNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class FNFDNFDEEIE : LMDALGICMAD
{
	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x22B2FB0", Offset = "0x22B21B0", VA = "0x1822B2FB0")]
	internal FNFDNFDEEIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class MLFCJLGNMCC : LMDALGICMAD
{
	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x22C3B60", Offset = "0x22C2D60", VA = "0x1822C3B60")]
	internal MLFCJLGNMCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public class AGIDKDFMNJI : LMDALGICMAD
{
	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x22A3380", Offset = "0x22A2580", VA = "0x1822A3380")]
	internal AGIDKDFMNJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class PNMHIINGBOF : LMDALGICMAD
{
	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x22C62B0", Offset = "0x22C54B0", VA = "0x1822C62B0")]
	internal PNMHIINGBOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class OLDPOFGOKOP : LMDALGICMAD
{
	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x22C5C50", Offset = "0x22C4E50", VA = "0x1822C5C50")]
	internal OLDPOFGOKOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class CJGCHHPHLPG : LMDALGICMAD
{
	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x22AEF00", Offset = "0x22AE100", VA = "0x1822AEF00")]
	internal CJGCHHPHLPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class JOIIJKADNOB : LMDALGICMAD
{
	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x22B65F0", Offset = "0x22B57F0", VA = "0x1822B65F0")]
	internal JOIIJKADNOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class ECNFGICCMNH : LMDALGICMAD
{
	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x22B1B10", Offset = "0x22B0D10", VA = "0x1822B1B10")]
	internal ECNFGICCMNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class OHHEHGMBNMO : LMDALGICMAD
{
	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x22C58E0", Offset = "0x22C4AE0", VA = "0x1822C58E0")]
	internal OHHEHGMBNMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public class NKKFFFCJPGD : LMDALGICMAD
{
	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x22C4AB0", Offset = "0x22C3CB0", VA = "0x1822C4AB0")]
	internal NKKFFFCJPGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class IPNCODEBLOJ : LMDALGICMAD
{
	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x22B5B30", Offset = "0x22B4D30", VA = "0x1822B5B30")]
	internal IPNCODEBLOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public class IDBFLBMCECO : LMDALGICMAD
{
	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x22B5030", Offset = "0x22B4230", VA = "0x1822B5030")]
	internal IDBFLBMCECO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public class NBJINKJFDMA : LMDALGICMAD
{
	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x22C3FA0", Offset = "0x22C31A0", VA = "0x1822C3FA0")]
	internal NBJINKJFDMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public class JCNCFPAKECP : LMDALGICMAD
{
	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x22B5D50", Offset = "0x22B4F50", VA = "0x1822B5D50")]
	internal JCNCFPAKECP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class GPEOCJPKDNK : LMDALGICMAD
{
	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x22B4260", Offset = "0x22B3460", VA = "0x1822B4260")]
	internal GPEOCJPKDNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class JELGEEEIOKG : LMDALGICMAD
{
	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x22B5F70", Offset = "0x22B5170", VA = "0x1822B5F70")]
	internal JELGEEEIOKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class EPGOIIHHFLE : LMDALGICMAD
{
	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x22B2400", Offset = "0x22B1600", VA = "0x1822B2400")]
	internal EPGOIIHHFLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class GNMNJLGHKMN : LMDALGICMAD
{
	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x22B4040", Offset = "0x22B3240", VA = "0x1822B4040")]
	internal GNMNJLGHKMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class LANODOPFGLA : LMDALGICMAD
{
	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x22B9060", Offset = "0x22B8260", VA = "0x1822B9060")]
	internal LANODOPFGLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public class HGCBOGNDPOH : LMDALGICMAD
{
	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x22B4500", Offset = "0x22B3700", VA = "0x1822B4500")]
	internal HGCBOGNDPOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public class MICOKMMKHHF : LMDALGICMAD
{
	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x22C3940", Offset = "0x22C2B40", VA = "0x1822C3940")]
	internal MICOKMMKHHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public class FAGMNKJILNF : LMDALGICMAD
{
	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x22B2720", Offset = "0x22B1920", VA = "0x1822B2720")]
	internal FAGMNKJILNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public class DOIIDAOINFG : LMDALGICMAD
{
	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x22B13E0", Offset = "0x22B05E0", VA = "0x1822B13E0")]
	internal DOIIDAOINFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public class KCMPCIIPFBI : LMDALGICMAD
{
	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x22B69F0", Offset = "0x22B5BF0", VA = "0x1822B69F0")]
	internal KCMPCIIPFBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public class HOCICPCNIPG : LMDALGICMAD
{
	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x22B4A80", Offset = "0x22B3C80", VA = "0x1822B4A80")]
	internal HOCICPCNIPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public class CGGGBGKAGDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly Guid GIIBBLDHGMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public readonly bool KDECFCPICDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public readonly bool GPNLFHMJGAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public readonly bool APKPGCECEEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private readonly List<(string Name, DOHCCNMLPPO Type)> GBNEPBCCEHO;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public Guid BGDCEHONODN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x19E41C0", Offset = "0x19E33C0", VA = "0x1819E41C0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public string GCLEOCLMMPM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x7EBAE0", Offset = "0x7EACE0", VA = "0x1807EBAE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x94C6C0", Offset = "0x94B8C0", VA = "0x18094C6C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public IReadOnlyList<(string Name, DOHCCNMLPPO Type)> APGMMEHADME
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x890860", Offset = "0x88FA60", VA = "0x180890860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action AGBPHLNKKEL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x22AEA00", Offset = "0x22ADC00", VA = "0x1822AEA00")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x22AEB00", Offset = "0x22ADD00", VA = "0x1822AEB00")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<string, DOHCCNMLPPO> FOEIGEPEBFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x22AEBA0", Offset = "0x22ADDA0", VA = "0x1822AEBA0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x22AED90", Offset = "0x22ADF90", VA = "0x1822AED90")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<int> OAPJHADJLKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x22AE8C0", Offset = "0x22ADAC0", VA = "0x1822AE8C0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x22AE640", Offset = "0x22AD840", VA = "0x1822AE640")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action BLALPMEKGLP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x22AE6E0", Offset = "0x22AD8E0", VA = "0x1822AE6E0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x22AE960", Offset = "0x22ADB60", VA = "0x1822AE960")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x98ADE0", Offset = "0x989FE0", VA = "0x18098ADE0")]
	public void CMANDEGPJID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x22AEE30", Offset = "0x22AE030", VA = "0x1822AEE30")]
	internal CGGGBGKAGDM(in Guid CJNGPAPKKID, string JPKENOAMLIN, bool PMNEMODDKHC, bool HGDHMGJBFKB, bool NNFLOEKKCBL, List<(string Name, DOHCCNMLPPO Type)> INAMDHPNPKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x22AEC40", Offset = "0x22ADE40", VA = "0x1822AEC40")]
	public static LGEPEGEPCJP LJMDFBLFDFN(string CJNGPAPKKID, string JPKENOAMLIN, bool PMNEMODDKHC = false, bool HGDHMGJBFKB = false, bool NNFLOEKKCBL = false)
	{
		return default(LGEPEGEPCJP);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x22AE800", Offset = "0x22ADA00", VA = "0x1822AE800")]
	public static CGGGBGKAGDM DNALDNGBDOM(in Guid CJNGPAPKKID, string JPKENOAMLIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x22AEAA0", Offset = "0x22ADCA0", VA = "0x1822AEAA0")]
	public void FJILBHJBMIK(string JPKENOAMLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x22AECC0", Offset = "0x22ADEC0", VA = "0x1822AECC0")]
	public void MLMDMDEJCPK(string JPKENOAMLIN, DOHCCNMLPPO MPEFDPOKCNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x22AE780", Offset = "0x22AD980", VA = "0x1822AE780")]
	public void CIOPMOIJBAN(int NNAODBDJDNJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public readonly struct BIOPDCKJBKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly Guid GIIBBLDHGMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly string IPHJOIJOMJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private readonly bool LGFNNOMDHMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly bool NHAELOKHGDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private readonly bool OFPKMCNGKIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private readonly List<(string Name, DOHCCNMLPPO Type)> GBNEPBCCEHO;

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x22AA860", Offset = "0x22A9A60", VA = "0x1822AA860")]
	public BIOPDCKJBKC(in Guid CJNGPAPKKID, string JPKENOAMLIN, bool PMNEMODDKHC, bool HGDHMGJBFKB, bool NNFLOEKKCBL, List<(string Name, DOHCCNMLPPO Type)> INAMDHPNPKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x22AA6D0", Offset = "0x22A98D0", VA = "0x1822AA6D0")]
	public BIOPDCKJBKC CONNPPJFIGI(string JPKENOAMLIN, DOHCCNMLPPO FBNKHAJKFLM)
	{
		return default(BIOPDCKJBKC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x22AA7B0", Offset = "0x22A99B0", VA = "0x1822AA7B0")]
	public CGGGBGKAGDM IBBPKBDNAAG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public static class GGFFPHAJEAL
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public static class NNGIPNKDCHK
	{
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public static readonly CGGGBGKAGDM KKLOEDEJODK;

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly CGGGBGKAGDM HKMDCNDBOAM;

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		internal static readonly CGGGBGKAGDM[] JJHHBMFDCMI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public static class AOGHDJHIFNI
	{
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public static readonly CGGGBGKAGDM OEGCELBFJLD;

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		internal static readonly CGGGBGKAGDM[] JJHHBMFDCMI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public static class OPJJDLBKIMB
	{
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public static readonly CGGGBGKAGDM APFFDPOFPCL;

		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public static readonly CGGGBGKAGDM OEKEOINNCGJ;

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		internal static readonly CGGGBGKAGDM[] JJHHBMFDCMI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public static class NDNODBKBICB
	{
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public static readonly CGGGBGKAGDM BILOFKKNBBK;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public static readonly CGGGBGKAGDM GBIADFAOCOE;

		[Cpp2IlInjected.Token(Token = "0x4000137")]
		internal static readonly CGGGBGKAGDM[] JJHHBMFDCMI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public static class CPHOOHPFGCN
	{
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public static readonly CGGGBGKAGDM JFIDCEJNGPL;

		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public static readonly CGGGBGKAGDM KIEAGIONBKC;

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		internal static readonly CGGGBGKAGDM[] JJHHBMFDCMI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public static class KMJCLKDDFEH
	{
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public static readonly CGGGBGKAGDM APFFDPOFPCL;

		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public static readonly CGGGBGKAGDM OEKEOINNCGJ;

		[Cpp2IlInjected.Token(Token = "0x400013D")]
		internal static readonly CGGGBGKAGDM[] JJHHBMFDCMI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public static class IHNPFCCBNPI
	{
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public static readonly CGGGBGKAGDM MCANNOBKGDK;

		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public static readonly CGGGBGKAGDM AMJHLOCNGHN;

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly CGGGBGKAGDM JNJBGJELBGN;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static readonly CGGGBGKAGDM KCDKLGFKECH;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public static readonly CGGGBGKAGDM CHBIBFOFPEH;

		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public static readonly CGGGBGKAGDM LCIMDMHABPI;

		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public static readonly CGGGBGKAGDM KIBPNFAAPKF;

		[Cpp2IlInjected.Token(Token = "0x4000145")]
		internal static readonly CGGGBGKAGDM[] JJHHBMFDCMI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public static class KGEFCBJEKGB
	{
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		internal static readonly CGGGBGKAGDM[] JJHHBMFDCMI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public static class JEACICMDGIJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		internal static readonly CGGGBGKAGDM[] JJHHBMFDCMI;
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public static class EKBCHJELAHE
	{
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		internal static readonly CGGGBGKAGDM[] JJHHBMFDCMI;
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public static class EJJOEFOBBPI
	{
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public static readonly CGGGBGKAGDM ALGOLANONLM;

		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public static readonly CGGGBGKAGDM NEGKGGGJGEF;

		[Cpp2IlInjected.Token(Token = "0x400014B")]
		internal static readonly CGGGBGKAGDM[] JJHHBMFDCMI;
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public static class CBHMJDPCMFN
	{
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		internal static readonly CGGGBGKAGDM[] JJHHBMFDCMI;
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public static class MNGMCGALJJO
	{
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		internal static readonly CGGGBGKAGDM[] JJHHBMFDCMI;
	}

	[Cpp2IlInjected.Token(Token = "0x200009E")]
	public static class ECJAPIIGJKM
	{
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public static readonly CGGGBGKAGDM JGCFJJDMPJP;

		[Cpp2IlInjected.Token(Token = "0x400014F")]
		internal static readonly CGGGBGKAGDM[] JJHHBMFDCMI;
	}

	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public static class BDCHHHMEONI
	{
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public static readonly CGGGBGKAGDM HDMOJLBHDND;

		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public static readonly CGGGBGKAGDM BMNJCIGBPHF;

		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public static readonly CGGGBGKAGDM JFIDCEJNGPL;

		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public static readonly CGGGBGKAGDM HFHDGOICBNJ;

		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public static readonly CGGGBGKAGDM KCCDEJEIAKI;

		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public static readonly CGGGBGKAGDM ILAHLPDMFDB;

		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public static readonly CGGGBGKAGDM NBDKCDHBKPM;

		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public static readonly CGGGBGKAGDM JBJHPKMIHEA;

		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public static readonly CGGGBGKAGDM GBGBBLBGMOL;

		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public static readonly CGGGBGKAGDM IIEMMKECHAL;

		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public static readonly CGGGBGKAGDM BKCFONIABCD;

		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public static readonly CGGGBGKAGDM KEAJHOPEODM;

		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public static readonly CGGGBGKAGDM DIHMLIAECCO;

		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public static readonly CGGGBGKAGDM JADCGNNEJHJ;

		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public static readonly CGGGBGKAGDM MEFGBJBODBD;

		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public static readonly CGGGBGKAGDM OPIKPAGBEAL;

		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public static readonly CGGGBGKAGDM LIEGHPIDPGJ;

		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public static readonly CGGGBGKAGDM NPDCPAENGOL;

		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public static readonly CGGGBGKAGDM OHMKPEIKIJI;

		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public static readonly CGGGBGKAGDM IINPHFNNKMN;

		[Cpp2IlInjected.Token(Token = "0x4000164")]
		internal static readonly CGGGBGKAGDM[] JJHHBMFDCMI;
	}

	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	public static class EFDPGHMJNIL
	{
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		internal static readonly CGGGBGKAGDM[] JJHHBMFDCMI;
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public static class GKANKDKLGPJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public static readonly CGGGBGKAGDM HDMOJLBHDND;

		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public static readonly CGGGBGKAGDM HDBABCJCMFF;

		[Cpp2IlInjected.Token(Token = "0x4000168")]
		internal static readonly CGGGBGKAGDM[] JJHHBMFDCMI;
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public static class EAFNONFAPKG
	{
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public static readonly CGGGBGKAGDM HHCLFDDKFNG;

		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public static readonly CGGGBGKAGDM OBGGOABPGED;

		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public static readonly CGGGBGKAGDM AJCAFFDOHBF;

		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public static readonly CGGGBGKAGDM BNPOOFHEAKA;

		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public static readonly CGGGBGKAGDM ILGEIFLPOJA;

		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public static readonly CGGGBGKAGDM GGOECJOIDMD;

		[Cpp2IlInjected.Token(Token = "0x400016F")]
		internal static readonly CGGGBGKAGDM[] JJHHBMFDCMI;
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public static class DDBMHOFCJAM
	{
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		internal static readonly CGGGBGKAGDM[] JJHHBMFDCMI;
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public static class NEMGMJHGAND
	{
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public static readonly CGGGBGKAGDM IIFKAOJFBGD;

		[Cpp2IlInjected.Token(Token = "0x4000172")]
		internal static readonly CGGGBGKAGDM[] JJHHBMFDCMI;
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public static class DONIECMFHGD
	{
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public static readonly CGGGBGKAGDM JGCFJJDMPJP;

		[Cpp2IlInjected.Token(Token = "0x4000174")]
		internal static readonly CGGGBGKAGDM[] JJHHBMFDCMI;
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public static class OBCJNFENKHK
	{
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		internal static readonly CGGGBGKAGDM[] JJHHBMFDCMI;
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public static class CJJJONLPOKB
	{
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		internal static readonly CGGGBGKAGDM[] JJHHBMFDCMI;
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public static class PMCFMOEKFAA
	{
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public static readonly CGGGBGKAGDM JLECCMJKABN;

		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public static readonly CGGGBGKAGDM FMGJECFLPHN;

		[Cpp2IlInjected.Token(Token = "0x4000179")]
		internal static readonly CGGGBGKAGDM[] JJHHBMFDCMI;
	}

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public static class ANKEJNHHCAB
	{
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		internal static readonly CGGGBGKAGDM[] JJHHBMFDCMI;
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public static class OEEJGOCABII
	{
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public static readonly CGGGBGKAGDM DECAMKGPBAO;

		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public static readonly CGGGBGKAGDM HBMDKAFFIFP;

		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public static readonly CGGGBGKAGDM CCLFBPJEMDL;

		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public static readonly CGGGBGKAGDM PONDDLGFKCE;

		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public static readonly CGGGBGKAGDM CBLIKOMJNDD;

		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public static readonly CGGGBGKAGDM JLNIDJAFHIA;

		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public static readonly CGGGBGKAGDM MNGJBGEEFDJ;

		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public static readonly CGGGBGKAGDM DGGANMMPNEK;

		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public static readonly CGGGBGKAGDM NNFIPEMIDCK;

		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public static readonly CGGGBGKAGDM KAEMFGMINKB;

		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public static readonly CGGGBGKAGDM KKHDLCGLKBF;

		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public static readonly CGGGBGKAGDM KOGPOOGFLGD;

		[Cpp2IlInjected.Token(Token = "0x4000187")]
		internal static readonly CGGGBGKAGDM[] JJHHBMFDCMI;
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public static class EBPHCDNALOC
	{
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		internal static readonly CGGGBGKAGDM[] JJHHBMFDCMI;
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	public static class HDKNOMELMFI
	{
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public static readonly CGGGBGKAGDM JDEHLIALFPK;

		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public static readonly CGGGBGKAGDM PNLBNPLJKCA;

		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public static readonly CGGGBGKAGDM OBNAKLODABK;

		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public static readonly CGGGBGKAGDM OGNCPEFHLHH;

		[Cpp2IlInjected.Token(Token = "0x400018D")]
		internal static readonly CGGGBGKAGDM[] JJHHBMFDCMI;
	}

	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	public static class CJHOJGEKLJC
	{
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public static readonly CGGGBGKAGDM KKHDLCGLKBF;

		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public static readonly CGGGBGKAGDM KOGPOOGFLGD;

		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public static readonly CGGGBGKAGDM MCLEEKBLBEN;

		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public static readonly CGGGBGKAGDM KEHHLFNMBLI;

		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public static readonly CGGGBGKAGDM GHDFGDGBDAM;

		[Cpp2IlInjected.Token(Token = "0x4000193")]
		internal static readonly CGGGBGKAGDM[] JJHHBMFDCMI;
	}

	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	public static class LHHHHLAHFHG
	{
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		internal static readonly CGGGBGKAGDM[] JJHHBMFDCMI;
	}

	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	public static class NOGKJKKKMBG
	{
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public static readonly CGGGBGKAGDM NKCCENHNOGK;

		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public static readonly CGGGBGKAGDM HDLGNOADGGO;

		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public static readonly CGGGBGKAGDM KKHDLCGLKBF;

		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public static readonly CGGGBGKAGDM KOGPOOGFLGD;

		[Cpp2IlInjected.Token(Token = "0x4000199")]
		internal static readonly CGGGBGKAGDM[] JJHHBMFDCMI;
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	public static class LDOBIODKPAD
	{
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		internal static readonly CGGGBGKAGDM[] JJHHBMFDCMI;
	}

	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	public static class ANPJOIJMICL
	{
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		internal static readonly CGGGBGKAGDM[] JJHHBMFDCMI;
	}

	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	public static class NKLGIKAHKKD
	{
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		internal static readonly CGGGBGKAGDM[] JJHHBMFDCMI;
	}

	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	public static class GBOJADDKDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		internal static readonly CGGGBGKAGDM[] JJHHBMFDCMI;
	}

	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	public static class ELLGDHJFNJC
	{
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public static readonly CGGGBGKAGDM ALGOLANONLM;

		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public static readonly CGGGBGKAGDM NEGKGGGJGEF;

		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		internal static readonly CGGGBGKAGDM[] JJHHBMFDCMI;
	}

	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public static class PCPJACLJPJC
	{
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public static readonly CGGGBGKAGDM HBIHJEBBPJD;

		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public static readonly CGGGBGKAGDM PNFANDJGIBM;

		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public static readonly CGGGBGKAGDM MGGOKDHALME;

		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public static readonly CGGGBGKAGDM KLJGDNNBLDF;

		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		internal static readonly CGGGBGKAGDM[] JJHHBMFDCMI;
	}

	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	public static class IDBNNAELPKA
	{
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public static readonly CGGGBGKAGDM HBIHJEBBPJD;

		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public static readonly CGGGBGKAGDM PNFANDJGIBM;

		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public static readonly CGGGBGKAGDM MGGOKDHALME;

		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public static readonly CGGGBGKAGDM KLJGDNNBLDF;

		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		internal static readonly CGGGBGKAGDM[] JJHHBMFDCMI;
	}

	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	public static class GNOPHFFBABH
	{
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		internal static readonly CGGGBGKAGDM[] JJHHBMFDCMI;
	}

	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public static class GCFJPKHNCDB
	{
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public static readonly CGGGBGKAGDM AKOLACCNAHL;

		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public static readonly CGGGBGKAGDM AIMFPCAPPBH;

		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public static readonly CGGGBGKAGDM LBFOEIMCFEA;

		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public static readonly CGGGBGKAGDM ILOKPCNCGHM;

		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		internal static readonly CGGGBGKAGDM[] JJHHBMFDCMI;
	}

	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	public static class GEOBENAOGGK
	{
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		internal static readonly CGGGBGKAGDM[] JJHHBMFDCMI;
	}

	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public static class MGMHOACDAJA
	{
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public static readonly CGGGBGKAGDM CNKICFCJLFA;

		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public static readonly CGGGBGKAGDM IKNFMHNMDLL;

		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public static readonly CGGGBGKAGDM EBECEIEHJFN;

		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		internal static readonly CGGGBGKAGDM[] JJHHBMFDCMI;
	}

	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	public static class HMFBOIJGEJM
	{
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public static readonly CGGGBGKAGDM MPJCPIPDALM;

		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		internal static readonly CGGGBGKAGDM[] JJHHBMFDCMI;
	}

	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	public static class BAGPODHLAPA
	{
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public static readonly CGGGBGKAGDM IFNEPEFPKAB;

		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public static readonly CGGGBGKAGDM OJPBCGIEBDF;

		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public static readonly CGGGBGKAGDM BECBEPCNPJC;

		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		internal static readonly CGGGBGKAGDM[] JJHHBMFDCMI;
	}

	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	public static class BEOKDIFBMBP
	{
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		internal static readonly CGGGBGKAGDM[] JJHHBMFDCMI;
	}

	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	public static class EBMGCOPHKBK
	{
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		internal static readonly CGGGBGKAGDM[] JJHHBMFDCMI;
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
