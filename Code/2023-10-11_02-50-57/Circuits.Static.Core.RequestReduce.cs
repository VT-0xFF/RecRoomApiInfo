using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
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
		[Cpp2IlInjected.Address(RVA = "0x78C450", Offset = "0x78B250", VA = "0x18078C450")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x1C31D20", Offset = "0x1C30B20", VA = "0x181C31D20")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x78C910", Offset = "0x78B710", VA = "0x18078C910")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x78C950", Offset = "0x78B750", VA = "0x18078C950")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate EBOPKEMDLBJ<TActionKind, TPayload> IDINKMKPNIO<TActionKind, TSerializedAction, TPayload>(TSerializedAction MFEPEKHIPAI);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface DKEALICMHAJ<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IHFDHMKEEAA<object, BENEMAACKKC>> FJHDGHOFIPL(TDeps NIPJNEHNMFI, TRoot JKEBPOPHOPF, TSerializedAction MFEPEKHIPAI);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class KBGMJHJCAHN<TActionKind, TSerializedAction, TRoot, TDeps> : HJEACDGALLJ where TDeps : LLKAMLHBJKE.MJMCMIEDJDL<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps FCPNPAIPIMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction ALHCEOBIKEM;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x386D2F0", Offset = "0x386C0F0", VA = "0x18386D2F0")]
	public KBGMJHJCAHN([In] TDeps NIPJNEHNMFI, [In] TSerializedAction MFEPEKHIPAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x386D1C0", Offset = "0x386BFC0", VA = "0x18386D1C0", Slot = "7")]
	public override string FIDCKDNNLBM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct EBOPKEMDLBJ<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind GKJANBIDHBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload KHNOJELEJFI;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3020090", Offset = "0x301EE90", VA = "0x183020090")]
	internal EBOPKEMDLBJ(TActionKind NBKCGDICLEG, [In] TPayload JPGMJABDIAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class OFOMFHDIIFO
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x24F08F0", Offset = "0x24EF6F0", VA = "0x1824F08F0")]
	public static EBOPKEMDLBJ<TActionKind, TPayload> NPAOPBPEFCO<TActionKind, TPayload>([In] TActionKind NBKCGDICLEG, [In] TPayload JPGMJABDIAJ)
	{
		return default(EBOPKEMDLBJ<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<IHFDHMKEEAA<TOk, TErr>> HMODHKKLBMG<TRoot, TPayload, TOk, TErr>(TRoot JKEBPOPHOPF, TPayload JPGMJABDIAJ);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate IHFDHMKEEAA<TOk, TErr> FPDDEGAMBJJ<TRoot, TPayload, TOk, TErr>(TRoot JKEBPOPHOPF, [In] TPayload JPGMJABDIAJ);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct JCMIPFAMEPP<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : LLKAMLHBJKE.MJMCMIEDJDL<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct NCDOHNMEIBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<IHFDHMKEEAA<object, BENEMAACKKC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public JCMIPFAMEPP<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<IHFDHMKEEAA<object, BENEMAACKKC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3BBD180", Offset = "0x3BBBF80", VA = "0x183BBD180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3BBDAA0", Offset = "0x3BBC8A0", VA = "0x183BBDAA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, DKEALICMHAJ<TSerializedAction, TRoot, TDeps>> KBOOAFGDFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps FCPNPAIPIMN;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7F1EC0", Offset = "0x7F0CC0", VA = "0x1807F1EC0")]
	internal JCMIPFAMEPP(Dictionary<TActionKind, DKEALICMHAJ<TSerializedAction, TRoot, TDeps>> PJANMLHFAMN, TDeps NIPJNEHNMFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3818F00", Offset = "0x3817D00", VA = "0x183818F00")]
	[AsyncStateMachine(typeof(JCMIPFAMEPP<, , , >.NCDOHNMEIBA))]
	public Task<IHFDHMKEEAA<object, BENEMAACKKC>> FJHDGHOFIPL(TRoot JKEBPOPHOPF, TSerializedAction MFEPEKHIPAI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class LLKAMLHBJKE
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface MJMCMIEDJDL<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind CEDODGNEDOO(TSerializedAction LNKCIHFCLHG);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void LJCHIPJDEEG(TRoot JKEBPOPHOPF, TSerializedAction HMHDIIODGFG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x23BFF00", Offset = "0x23BED00", VA = "0x1823BFF00")]
	internal static JCMIPFAMEPP<TActionKind, TSerializedAction, TRoot, TDeps> NPAOPBPEFCO<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, DKEALICMHAJ<TSerializedAction, TRoot, TDeps>> PJANMLHFAMN, TDeps NIPJNEHNMFI) where TDeps : MJMCMIEDJDL<TActionKind, TSerializedAction, TRoot>
	{
		return default(JCMIPFAMEPP<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class IBLPNBAGBCF<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, DKEALICMHAJ<TSerializedAction, TRoot, TDeps>> MNKDLPINFLG;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x763A40", Offset = "0x762840", VA = "0x180763A40")]
	private IBLPNBAGBCF(Dictionary<TActionKind, DKEALICMHAJ<TSerializedAction, TRoot, TDeps>> PJANMLHFAMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3644FC0", Offset = "0x3643DC0", VA = "0x183644FC0")]
	public static IBLPNBAGBCF<TActionKind, TSerializedAction, TRoot, TDeps> NPAOPBPEFCO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct JNDOMGCEOCD<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, LLKAMLHBJKE.MJMCMIEDJDL<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class EIELHPFOMFM<TPayload, TOk, TErr> : DKEALICMHAJ<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, BENEMAACKKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly IDINKMKPNIO<TActionKind, TSerializedAction, TPayload> CADMFBCEPNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly FPDDEGAMBJJ<TRoot, TPayload, TOk, TErr> JPEAHNFPELC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool BLCMAMOJCCH;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x304CCB0", Offset = "0x304BAB0", VA = "0x18304CCB0")]
		public EIELHPFOMFM(IDINKMKPNIO<TActionKind, TSerializedAction, TPayload> NDAFKHBIEJL, FPDDEGAMBJJ<TRoot, TPayload, TOk, TErr> EOBEEEGBMID, bool DNIPOKCIPPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x304A260", Offset = "0x3049060", VA = "0x18304A260", Slot = "4")]
		public Task<IHFDHMKEEAA<object, BENEMAACKKC>> FJHDGHOFIPL(TDeps NIPJNEHNMFI, TRoot JKEBPOPHOPF, TSerializedAction MFEPEKHIPAI)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class GOOPDHAKMAF<TPayload, TOk, TErr> : DKEALICMHAJ<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, BENEMAACKKC
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct JNCFFGMJENB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<IHFDHMKEEAA<object?, BENEMAACKKC>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public GOOPDHAKMAF<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public TDeps deps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public TRoot root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public TSerializedAction serializedAction;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private IHFDHMKEEAA<object?, BENEMAACKKC> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<IHFDHMKEEAA<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x3829AE0", Offset = "0x38288E0", VA = "0x183829AE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x382AD30", Offset = "0x3829B30", VA = "0x18382AD30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly IDINKMKPNIO<TActionKind, TSerializedAction, TPayload> CADMFBCEPNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly HMODHKKLBMG<TRoot, TPayload, TOk, TErr> JPEAHNFPELC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool BLCMAMOJCCH;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x304CCB0", Offset = "0x304BAB0", VA = "0x18304CCB0")]
		public GOOPDHAKMAF(IDINKMKPNIO<TActionKind, TSerializedAction, TPayload> NDAFKHBIEJL, HMODHKKLBMG<TRoot, TPayload, TOk, TErr> EOBEEEGBMID, bool DNIPOKCIPPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x34E1ED0", Offset = "0x34E0CD0", VA = "0x1834E1ED0", Slot = "4")]
		[AsyncStateMachine(typeof(GOOPDHAKMAF<, , >.JNCFFGMJENB))]
		public Task<IHFDHMKEEAA<object, BENEMAACKKC>> FJHDGHOFIPL(TDeps NIPJNEHNMFI, TRoot JKEBPOPHOPF, TSerializedAction MFEPEKHIPAI)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly IBLPNBAGBCF<TActionKind, TSerializedAction, TRoot, TDeps> JMGGLFLPLKE;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7F19C0", Offset = "0x7F07C0", VA = "0x1807F19C0")]
	private JNDOMGCEOCD(IBLPNBAGBCF<TActionKind, TSerializedAction, TRoot, TDeps> PFDMLBFKIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x382B960", Offset = "0x382A760", VA = "0x18382B960")]
	public static JNDOMGCEOCD<TActionKind, TSerializedAction, TRoot, TDeps> NPAOPBPEFCO()
	{
		return default(JNDOMGCEOCD<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2285E00", Offset = "0x2284C00", VA = "0x182285E00")]
	public JNDOMGCEOCD<TActionKind, TSerializedAction, TRoot, TDeps> PKGCFOOGPOE<TPayload, TOk, TErr>(TActionKind NBKCGDICLEG, IDINKMKPNIO<TActionKind, TSerializedAction, TPayload> NDAFKHBIEJL, FPDDEGAMBJJ<TRoot, TPayload, TOk, TErr> EOBEEEGBMID, bool DNIPOKCIPPB = true) where TPayload : notnull where TOk : notnull where TErr : notnull, BENEMAACKKC
	{
		return default(JNDOMGCEOCD<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2285E00", Offset = "0x2284C00", VA = "0x182285E00")]
	public JNDOMGCEOCD<TActionKind, TSerializedAction, TRoot, TDeps> MCOFKKKNHPG<TPayload, TOk, TErr>(TActionKind NBKCGDICLEG, IDINKMKPNIO<TActionKind, TSerializedAction, TPayload> NDAFKHBIEJL, HMODHKKLBMG<TRoot, TPayload, TOk, TErr> EOBEEEGBMID, bool DNIPOKCIPPB = true) where TPayload : notnull where TOk : notnull where TErr : notnull, BENEMAACKKC
	{
		return default(JNDOMGCEOCD<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x382B8B0", Offset = "0x382A6B0", VA = "0x18382B8B0")]
	public JCMIPFAMEPP<TActionKind, TSerializedAction, TRoot, TDeps> NADIGMMCAIB(TDeps NIPJNEHNMFI)
	{
		return default(JCMIPFAMEPP<TActionKind, TSerializedAction, TRoot, TDeps>);
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
