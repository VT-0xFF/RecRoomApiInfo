using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
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
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80DE80", VA = "0x18080EA80")]
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
		[Cpp2IlInjected.Address(RVA = "0x1714AA0", Offset = "0x1713EA0", VA = "0x181714AA0")]
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
public readonly struct MDINMLDMAPM<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly TActionKind DKFDHJOJNCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TPayload IPDOFHMMNGM;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2F948B0", Offset = "0x2F93CB0", VA = "0x182F948B0")]
	internal MDINMLDMAPM(TActionKind DBNINHBEHNJ, in TPayload PCDLJHELPEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class NNCLMHNANPN
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x291E130", Offset = "0x291D530", VA = "0x18291E130")]
	public static global::MDINMLDMAPM<TActionKind, TPayload> FHHJOGLDILM<TActionKind, TPayload>(in TActionKind DBNINHBEHNJ, in TPayload PCDLJHELPEC)
	{
		return default(global::MDINMLDMAPM<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal interface LNMPMCCIEHE<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<global::EJIEKPGJGCC<object, EACFJIDFNJL>> EOEOEOFIOCB(TDeps DNINMLCHLPM, TRoot PFMMNJCIGCA, TSerializedAction JECOGCFIGOP);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct DPMIIECJACG<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : FBALPBIILAB.GAJAJBDGAFG<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class HOAFPEDIEOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public AsyncTaskMethodBuilder<global::EJIEKPGJGCC<object, EACFJIDFNJL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public global::DPMIIECJACG<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private global::EJIEKPGJGCC<object, EACFJIDFNJL> <r>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TActionKind <kind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private global::LNMPMCCIEHE<TSerializedAction, TRoot, TDeps> <reducer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private global::EJIEKPGJGCC<object, EACFJIDFNJL> <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private TaskAwaiter<global::EJIEKPGJGCC<object, EACFJIDFNJL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1939780", Offset = "0x1938B80", VA = "0x181939780")]
		public HOAFPEDIEOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3237AA0", Offset = "0x3236EA0", VA = "0x183237AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<TActionKind, global::LNMPMCCIEHE<TSerializedAction, TRoot, TDeps>> OMHDBECFDGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly TDeps OOFPAEDANFO;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0xA1F0E0", Offset = "0xA1E4E0", VA = "0x180A1F0E0")]
	internal DPMIIECJACG(Dictionary<TActionKind, global::LNMPMCCIEHE<TSerializedAction, TRoot, TDeps>> BNJIDHONNJK, TDeps DNINMLCHLPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3C164D0", Offset = "0x3C158D0", VA = "0x183C164D0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(global::DPMIIECJACG<, , , >.HOAFPEDIEOI))]
	public Task<global::EJIEKPGJGCC<object, EACFJIDFNJL>> EOEOEOFIOCB(TRoot PFMMNJCIGCA, TSerializedAction JECOGCFIGOP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class FBALPBIILAB
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface GAJAJBDGAFG<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind GGFFKIGGHNE(TSerializedAction LGKAJJKAMAG);

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void JPCNFOLMFJA(TRoot PFMMNJCIGCA, TSerializedAction ENOAFIICPMH);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x29F7F70", Offset = "0x29F7370", VA = "0x1829F7F70")]
	internal static global::DPMIIECJACG<TActionKind, TSerializedAction, TRoot, TDeps> FHHJOGLDILM<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, global::LNMPMCCIEHE<TSerializedAction, TRoot, TDeps>> BNJIDHONNJK, TDeps DNINMLCHLPM) where TDeps : GAJAJBDGAFG<TActionKind, TSerializedAction, TRoot>
	{
		return default(global::DPMIIECJACG<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate global::EJIEKPGJGCC<TOk, TErr> FFLBGMMMKJP<TRoot, TPayload, TOk, TErr>(TRoot PFMMNJCIGCA, in TPayload PCDLJHELPEC);
[Cpp2IlInjected.Token(Token = "0x200000D")]
internal sealed class JGELMLHEALP<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public Dictionary<TActionKind, global::LNMPMCCIEHE<TSerializedAction, TRoot, TDeps>> DGEDKKICNEB;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x25DFEC0", Offset = "0x25DF2C0", VA = "0x1825DFEC0")]
	private JGELMLHEALP(Dictionary<TActionKind, global::LNMPMCCIEHE<TSerializedAction, TRoot, TDeps>> BNJIDHONNJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x33A6B60", Offset = "0x33A5F60", VA = "0x1833A6B60")]
	public static global::JGELMLHEALP<TActionKind, TSerializedAction, TRoot, TDeps> FHHJOGLDILM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public delegate Task<global::EJIEKPGJGCC<TOk, TErr>> ELFIJEAGCJK<TRoot, TPayload, TOk, TErr>(TRoot PFMMNJCIGCA, TPayload PCDLJHELPEC);
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class DLCFBIMIMMJ<TActionKind, TSerializedAction, TRoot, TDeps> : LCEIFOGDJKI where TDeps : FBALPBIILAB.GAJAJBDGAFG<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly TDeps OOFPAEDANFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly TSerializedAction OEINJEPAOMM;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3C0C360", Offset = "0x3C0B760", VA = "0x183C0C360")]
	public DLCFBIMIMMJ(in TDeps DNINMLCHLPM, in TSerializedAction JECOGCFIGOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3C0C130", Offset = "0x3C0B530", VA = "0x183C0C130", Slot = "7")]
	public override string FGDMEHNLDAL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public delegate global::MDINMLDMAPM<TActionKind, TPayload> FDLBCGCMJLA<TActionKind, TSerializedAction, TPayload>(TSerializedAction JECOGCFIGOP);
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct OPOCCGAEPPD<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, FBALPBIILAB.GAJAJBDGAFG<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class DPNJFCNKACK<TPayload, TOk, TErr> : global::LNMPMCCIEHE<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, EACFJIDFNJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly global::FDLBCGCMJLA<TActionKind, TSerializedAction, TPayload> CHDDKOACAJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly global::FFLBGMMMKJP<TRoot, TPayload, TOk, TErr> KJHOBIJDGFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly bool KIIGECBOHJI;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x338FF00", Offset = "0x338F300", VA = "0x18338FF00")]
		public DPNJFCNKACK(global::FDLBCGCMJLA<TActionKind, TSerializedAction, TPayload> DNONHHBBHLH, global::FFLBGMMMKJP<TRoot, TPayload, TOk, TErr> EILDOAGKIHJ, bool INKLIPHMMCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3C1A850", Offset = "0x3C19C50", VA = "0x183C1A850", Slot = "4")]
		public Task<global::EJIEKPGJGCC<object, EACFJIDFNJL>> EOEOEOFIOCB(TDeps DNINMLCHLPM, TRoot PFMMNJCIGCA, TSerializedAction JECOGCFIGOP)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class JBHKHMHFLJI<TPayload, TOk, TErr> : global::LNMPMCCIEHE<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, EACFJIDFNJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly global::FDLBCGCMJLA<TActionKind, TSerializedAction, TPayload> CHDDKOACAJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly global::ELFIJEAGCJK<TRoot, TPayload, TOk, TErr> KJHOBIJDGFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly bool KIIGECBOHJI;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x338FF00", Offset = "0x338F300", VA = "0x18338FF00")]
		public JBHKHMHFLJI(global::FDLBCGCMJLA<TActionKind, TSerializedAction, TPayload> DNONHHBBHLH, global::ELFIJEAGCJK<TRoot, TPayload, TOk, TErr> EILDOAGKIHJ, bool INKLIPHMMCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x338F5A0", Offset = "0x338E9A0", VA = "0x18338F5A0", Slot = "4")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(IMBLNNMPFAA))]
		public Task<global::EJIEKPGJGCC<object, EACFJIDFNJL>> EOEOEOFIOCB(TDeps DNINMLCHLPM, TRoot PFMMNJCIGCA, TSerializedAction JECOGCFIGOP)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly global::JGELMLHEALP<TActionKind, TSerializedAction, TRoot, TDeps> BNJABGPIAGO;

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0xB8F880", Offset = "0xB8EC80", VA = "0x180B8F880")]
	private OPOCCGAEPPD(global::JGELMLHEALP<TActionKind, TSerializedAction, TRoot, TDeps> KOCKBILIHNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4293A80", Offset = "0x4292E80", VA = "0x184293A80")]
	public static global::OPOCCGAEPPD<TActionKind, TSerializedAction, TRoot, TDeps> FHHJOGLDILM()
	{
		return default(global::OPOCCGAEPPD<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2D93880", Offset = "0x2D92C80", VA = "0x182D93880")]
	public global::OPOCCGAEPPD<TActionKind, TSerializedAction, TRoot, TDeps> JJBNHGPECCM<TPayload, TOk, TErr>(TActionKind DBNINHBEHNJ, global::FDLBCGCMJLA<TActionKind, TSerializedAction, TPayload> DNONHHBBHLH, global::FFLBGMMMKJP<TRoot, TPayload, TOk, TErr> EILDOAGKIHJ, bool INKLIPHMMCP = true) where TPayload : notnull where TOk : notnull where TErr : notnull, EACFJIDFNJL
	{
		return default(global::OPOCCGAEPPD<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2D93880", Offset = "0x2D92C80", VA = "0x182D93880")]
	public global::OPOCCGAEPPD<TActionKind, TSerializedAction, TRoot, TDeps> MEDAMMCCCKO<TPayload, TOk, TErr>(TActionKind DBNINHBEHNJ, global::FDLBCGCMJLA<TActionKind, TSerializedAction, TPayload> DNONHHBBHLH, global::ELFIJEAGCJK<TRoot, TPayload, TOk, TErr> EILDOAGKIHJ, bool INKLIPHMMCP = true) where TPayload : notnull where TOk : notnull where TErr : notnull, EACFJIDFNJL
	{
		return default(global::OPOCCGAEPPD<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4293B20", Offset = "0x4292F20", VA = "0x184293B20")]
	public global::DPMIIECJACG<TActionKind, TSerializedAction, TRoot, TDeps> HBCAHGJIHFL(TDeps DNINMLCHLPM)
	{
		return default(global::DPMIIECJACG<TActionKind, TSerializedAction, TRoot, TDeps>);
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
