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
		[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x29E9020", Offset = "0x29E7E20", VA = "0x1829E9020")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA838A0", Offset = "0xA826A0", VA = "0x180A838A0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA838E0", Offset = "0xA826E0", VA = "0x180A838E0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate BFNMAKMBKBP<TActionKind, TPayload> JICEAAMJBBO<TActionKind, TSerializedAction, TPayload>(TSerializedAction JHLAGKMLLED);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface JCAPHNHFOOG<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CKPFCFEHEPP<object, FCJOMJLBDOM>> KPBAABMIMML(TDeps FEBHHEFFJMB, TRoot EGPDFGOHLFM, TSerializedAction JHLAGKMLLED);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class LMGECBHGLPK<TActionKind, TSerializedAction, TRoot, TDeps> : CIPPKAIIPLL where TDeps : HMIAMFLANOO.EGDKFHBJHPB<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps IHILFMGFJPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction LNGJLAPHCDF;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x548D380", Offset = "0x548C180", VA = "0x18548D380")]
	public LMGECBHGLPK([In] TDeps FEBHHEFFJMB, [In] TSerializedAction JHLAGKMLLED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x548D250", Offset = "0x548C050", VA = "0x18548D250", Slot = "7")]
	public override string KMHKNGKODJN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct BFNMAKMBKBP<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind BBNBPCADIHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload NGGDEAHAABC;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x62535B0", Offset = "0x62523B0", VA = "0x1862535B0")]
	internal BFNMAKMBKBP(TActionKind OCAGDGBHKJO, [In] TPayload OFCPJKNFOPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class GMEEFJHFLJF
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3B8AB60", Offset = "0x3B89960", VA = "0x183B8AB60")]
	public static BFNMAKMBKBP<TActionKind, TPayload> OGAKBGHEIKK<TActionKind, TPayload>([In] TActionKind OCAGDGBHKJO, [In] TPayload OFCPJKNFOPJ)
	{
		return default(BFNMAKMBKBP<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<CKPFCFEHEPP<TOk, TErr>> OJGKAPGKPNO<TRoot, TPayload, TOk, TErr>(TRoot EGPDFGOHLFM, TPayload OFCPJKNFOPJ);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate CKPFCFEHEPP<TOk, TErr> JBGOGAEDNOK<TRoot, TPayload, TOk, TErr>(TRoot EGPDFGOHLFM, [In] TPayload OFCPJKNFOPJ);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct OHDBJEIEIFL<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : HMIAMFLANOO.EGDKFHBJHPB<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct DIDCIDNOMDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<CKPFCFEHEPP<object?, FCJOMJLBDOM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public OHDBJEIEIFL<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<CKPFCFEHEPP<object, FCJOMJLBDOM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6DE7BC0", Offset = "0x6DE69C0", VA = "0x186DE7BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6DE84C0", Offset = "0x6DE72C0", VA = "0x186DE84C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, JCAPHNHFOOG<TSerializedAction, TRoot, TDeps>> BIECFDMAPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps IHILFMGFJPA;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xBC8270", Offset = "0xBC7070", VA = "0x180BC8270")]
	internal OHDBJEIEIFL(Dictionary<TActionKind, JCAPHNHFOOG<TSerializedAction, TRoot, TDeps>> EPPLKPPPIAA, TDeps FEBHHEFFJMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5857E10", Offset = "0x5856C10", VA = "0x185857E10")]
	[AsyncStateMachine(typeof(OHDBJEIEIFL<, , , >.DIDCIDNOMDJ))]
	public Task<CKPFCFEHEPP<object, FCJOMJLBDOM>> KPBAABMIMML(TRoot EGPDFGOHLFM, TSerializedAction JHLAGKMLLED)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class HMIAMFLANOO
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface EGDKFHBJHPB<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind BGPHJHNGJMM(TSerializedAction FEOFEEGOGIO);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void LMCHJBLCCPP(TRoot EGPDFGOHLFM, TSerializedAction LJIGAFKJJAI);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void KNLIJFJFHOH(TRoot EGPDFGOHLFM, TSerializedAction LJIGAFKJJAI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x39DBC90", Offset = "0x39DAA90", VA = "0x1839DBC90")]
	internal static OHDBJEIEIFL<TActionKind, TSerializedAction, TRoot, TDeps> OGAKBGHEIKK<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, JCAPHNHFOOG<TSerializedAction, TRoot, TDeps>> EPPLKPPPIAA, TDeps FEBHHEFFJMB) where TDeps : EGDKFHBJHPB<TActionKind, TSerializedAction, TRoot>
	{
		return default(OHDBJEIEIFL<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class NPPOIJAPFKP<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, JCAPHNHFOOG<TSerializedAction, TRoot, TDeps>> LJCEJIEFGEF;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0xA665B0", Offset = "0xA653B0", VA = "0x180A665B0")]
	private NPPOIJAPFKP(Dictionary<TActionKind, JCAPHNHFOOG<TSerializedAction, TRoot, TDeps>> EPPLKPPPIAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x573EF80", Offset = "0x573DD80", VA = "0x18573EF80")]
	public static NPPOIJAPFKP<TActionKind, TSerializedAction, TRoot, TDeps> OGAKBGHEIKK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct OCEFNEKIJKG<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, HMIAMFLANOO.EGDKFHBJHPB<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class ILGCKACMBFF<TPayload, TOk, TErr> : JCAPHNHFOOG<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, FCJOMJLBDOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly JICEAAMJBBO<TActionKind, TSerializedAction, TPayload> IFBFBDLLNBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly JBGOGAEDNOK<TRoot, TPayload, TOk, TErr> GOOIHAJPIKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool JPKOIJCNBIL;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1BC9170", Offset = "0x1BC7F70", VA = "0x181BC9170")]
		public ILGCKACMBFF(JICEAAMJBBO<TActionKind, TSerializedAction, TPayload> PPAJNBMCIPH, JBGOGAEDNOK<TRoot, TPayload, TOk, TErr> HEAEDFJIAAC, bool KABOLPPJGGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x4F32930", Offset = "0x4F31730", VA = "0x184F32930", Slot = "4")]
		public Task<CKPFCFEHEPP<object, FCJOMJLBDOM>> KPBAABMIMML(TDeps FEBHHEFFJMB, TRoot EGPDFGOHLFM, TSerializedAction JHLAGKMLLED)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class ECPNAPLGKOG<TPayload, TOk, TErr> : JCAPHNHFOOG<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, FCJOMJLBDOM
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct FGJEPHIIGJA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<CKPFCFEHEPP<object?, FCJOMJLBDOM>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public TDeps deps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public TRoot root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public TSerializedAction serializedAction;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public ECPNAPLGKOG<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private CKPFCFEHEPP<object?, FCJOMJLBDOM> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<CKPFCFEHEPP<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x4CA8CD0", Offset = "0x4CA7AD0", VA = "0x184CA8CD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x4CAAA40", Offset = "0x4CA9840", VA = "0x184CAAA40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly JICEAAMJBBO<TActionKind, TSerializedAction, TPayload> IFBFBDLLNBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly OJGKAPGKPNO<TRoot, TPayload, TOk, TErr> GOOIHAJPIKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool JPKOIJCNBIL;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1BC9170", Offset = "0x1BC7F70", VA = "0x181BC9170")]
		public ECPNAPLGKOG(JICEAAMJBBO<TActionKind, TSerializedAction, TPayload> PPAJNBMCIPH, OJGKAPGKPNO<TRoot, TPayload, TOk, TErr> HEAEDFJIAAC, bool KABOLPPJGGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x480BC50", Offset = "0x480AA50", VA = "0x18480BC50", Slot = "4")]
		[AsyncStateMachine(typeof(ECPNAPLGKOG<, , >.FGJEPHIIGJA))]
		public Task<CKPFCFEHEPP<object, FCJOMJLBDOM>> KPBAABMIMML(TDeps FEBHHEFFJMB, TRoot EGPDFGOHLFM, TSerializedAction JHLAGKMLLED)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly NPPOIJAPFKP<TActionKind, TSerializedAction, TRoot, TDeps> GBOEMEDAOKN;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xE3B7E0", Offset = "0xE3A5E0", VA = "0x180E3B7E0")]
	private OCEFNEKIJKG(NPPOIJAPFKP<TActionKind, TSerializedAction, TRoot, TDeps> BOIPFNOKGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5845F60", Offset = "0x5844D60", VA = "0x185845F60")]
	public static OCEFNEKIJKG<TActionKind, TSerializedAction, TRoot, TDeps> OGAKBGHEIKK()
	{
		return default(OCEFNEKIJKG<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x42BAB60", Offset = "0x42B9960", VA = "0x1842BAB60")]
	public OCEFNEKIJKG<TActionKind, TSerializedAction, TRoot, TDeps> FFALJHOGCKI<TPayload, TOk, TErr>(TActionKind OCAGDGBHKJO, JICEAAMJBBO<TActionKind, TSerializedAction, TPayload> PPAJNBMCIPH, JBGOGAEDNOK<TRoot, TPayload, TOk, TErr> HEAEDFJIAAC, bool KABOLPPJGGF = true) where TPayload : notnull where TOk : notnull where TErr : notnull, FCJOMJLBDOM
	{
		return default(OCEFNEKIJKG<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x42BAB60", Offset = "0x42B9960", VA = "0x1842BAB60")]
	public OCEFNEKIJKG<TActionKind, TSerializedAction, TRoot, TDeps> DBADIFGIFPM<TPayload, TOk, TErr>(TActionKind OCAGDGBHKJO, JICEAAMJBBO<TActionKind, TSerializedAction, TPayload> PPAJNBMCIPH, OJGKAPGKPNO<TRoot, TPayload, TOk, TErr> HEAEDFJIAAC, bool KABOLPPJGGF = true) where TPayload : notnull where TOk : notnull where TErr : notnull, FCJOMJLBDOM
	{
		return default(OCEFNEKIJKG<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5845FF0", Offset = "0x5844DF0", VA = "0x185845FF0")]
	public OHDBJEIEIFL<TActionKind, TSerializedAction, TRoot, TDeps> OJELBMAMOAO(TDeps FEBHHEFFJMB)
	{
		return default(OHDBJEIEIFL<TActionKind, TSerializedAction, TRoot, TDeps>);
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
