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
		[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40")]
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
		[Cpp2IlInjected.Address(RVA = "0xEA0650", Offset = "0xE9F650", VA = "0x180EA0650")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6FA6F0", Offset = "0x6F96F0", VA = "0x1806FA6F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x929620", Offset = "0x928620", VA = "0x180929620")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate global::ABOBKDHIIDF<TActionKind, TPayload> OCBNPHODHIA<TActionKind, TSerializedAction, TPayload>(TSerializedAction IEFADENHBDL);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface GKPJAHMDLBH<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<global::APICMLLNCKG<object, AFKOMGPKGOP>> PDHODNEMIHA(TDeps EFNLEFOGALP, TRoot IGJDJDNFANI, TSerializedAction IEFADENHBDL);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class DKNJNLAOKJC<TActionKind, TSerializedAction, TRoot, TDeps> : AFKOMGPKGOP where TDeps : GNJLBGECPOA.LMEGINICNOF<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps JGNODFDDAJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction GEHNOMAJNMC;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3699ED0", Offset = "0x3698ED0", VA = "0x183699ED0")]
	public DKNJNLAOKJC(in TDeps EFNLEFOGALP, in TSerializedAction IEFADENHBDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3699DA0", Offset = "0x3698DA0", VA = "0x183699DA0", Slot = "5")]
	public override string IGONAKBOEBA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct ABOBKDHIIDF<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind EDDDJLFFNAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload NDPPPPIFPGJ;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x350F7F0", Offset = "0x350E7F0", VA = "0x18350F7F0")]
	internal ABOBKDHIIDF(TActionKind HIDJLAJPHCO, in TPayload OBBOCNIOLOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class JLPAHLOBPAC
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x21C9020", Offset = "0x21C8020", VA = "0x1821C9020")]
	public static global::ABOBKDHIIDF<TActionKind, TPayload> CCFMECMIHDM<TActionKind, TPayload>(in TActionKind HIDJLAJPHCO, in TPayload OBBOCNIOLOI)
	{
		return default(global::ABOBKDHIIDF<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<global::APICMLLNCKG<TOk, TErr>> ELENMADBPBK<TRoot, TPayload, TOk, TErr>(TRoot IGJDJDNFANI, TPayload OBBOCNIOLOI);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate global::APICMLLNCKG<TOk, TErr> BAGACDOAGGE<TRoot, TPayload, TOk, TErr>(TRoot IGJDJDNFANI, in TPayload OBBOCNIOLOI);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct BLCHKFMDODG<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : GNJLBGECPOA.LMEGINICNOF<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct HONLKJPEPMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<global::APICMLLNCKG<object, AFKOMGPKGOP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public global::BLCHKFMDODG<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<global::APICMLLNCKG<object, AFKOMGPKGOP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x38E8A50", Offset = "0x38E7A50", VA = "0x1838E8A50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x38E8EB0", Offset = "0x38E7EB0", VA = "0x1838E8EB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, global::GKPJAHMDLBH<TSerializedAction, TRoot, TDeps>> BEBHKJMPKAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps JGNODFDDAJE;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x78FA30", Offset = "0x78EA30", VA = "0x18078FA30")]
	internal BLCHKFMDODG(Dictionary<TActionKind, global::GKPJAHMDLBH<TSerializedAction, TRoot, TDeps>> LFNIFNPAGFG, TDeps EFNLEFOGALP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3A29F80", Offset = "0x3A28F80", VA = "0x183A29F80")]
	[AsyncStateMachine(typeof(global::BLCHKFMDODG<, , , >.HONLKJPEPMJ))]
	public Task<global::APICMLLNCKG<object, AFKOMGPKGOP>> PDHODNEMIHA(TRoot IGJDJDNFANI, TSerializedAction IEFADENHBDL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class GNJLBGECPOA
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface LMEGINICNOF<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind OJPOGONAPIN(TSerializedAction AOFCPKBHFEM);

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void EALBPHGBOFD(TRoot IGJDJDNFANI, TSerializedAction FFBLFKDINEA);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2328350", Offset = "0x2327350", VA = "0x182328350")]
	internal static global::BLCHKFMDODG<TActionKind, TSerializedAction, TRoot, TDeps> CCFMECMIHDM<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, global::GKPJAHMDLBH<TSerializedAction, TRoot, TDeps>> LFNIFNPAGFG, TDeps EFNLEFOGALP) where TDeps : LMEGINICNOF<TActionKind, TSerializedAction, TRoot>
	{
		return default(global::BLCHKFMDODG<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class POKIOMFIDFH<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, global::GKPJAHMDLBH<TSerializedAction, TRoot, TDeps>> NGAJIKBBFPK;

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x20293C0", Offset = "0x20283C0", VA = "0x1820293C0")]
	private POKIOMFIDFH(Dictionary<TActionKind, global::GKPJAHMDLBH<TSerializedAction, TRoot, TDeps>> LFNIFNPAGFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x347FBD0", Offset = "0x347EBD0", VA = "0x18347FBD0")]
	public static global::POKIOMFIDFH<TActionKind, TSerializedAction, TRoot, TDeps> CCFMECMIHDM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct ANJLOLAFNBO<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, GNJLBGECPOA.LMEGINICNOF<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class LHJOLKEAPCG<TPayload, TOk, TErr> : global::GKPJAHMDLBH<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, AFKOMGPKGOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly global::OCBNPHODHIA<TActionKind, TSerializedAction, TPayload> NHBHJALHICK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly global::BAGACDOAGGE<TRoot, TPayload, TOk, TErr> ABGCHOHDDDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool ENBPODBJFMC;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x20B8DD0", Offset = "0x20B7DD0", VA = "0x1820B8DD0")]
		public LHJOLKEAPCG(global::OCBNPHODHIA<TActionKind, TSerializedAction, TPayload> DLGHGDJLCMF, global::BAGACDOAGGE<TRoot, TPayload, TOk, TErr> LHDOIPIKPDC, bool JKGPGONDAGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2602130", Offset = "0x2601130", VA = "0x182602130", Slot = "4")]
		public Task<global::APICMLLNCKG<object, AFKOMGPKGOP>> PDHODNEMIHA(TDeps EFNLEFOGALP, TRoot IGJDJDNFANI, TSerializedAction IEFADENHBDL)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class LDHEKPOPOPF<TPayload, TOk, TErr> : global::GKPJAHMDLBH<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, AFKOMGPKGOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly global::OCBNPHODHIA<TActionKind, TSerializedAction, TPayload> NHBHJALHICK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly global::ELENMADBPBK<TRoot, TPayload, TOk, TErr> ABGCHOHDDDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool ENBPODBJFMC;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x20B8DD0", Offset = "0x20B7DD0", VA = "0x1820B8DD0")]
		public LDHEKPOPOPF(global::OCBNPHODHIA<TActionKind, TSerializedAction, TPayload> DLGHGDJLCMF, global::ELENMADBPBK<TRoot, TPayload, TOk, TErr> LHDOIPIKPDC, bool JKGPGONDAGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x20B8C60", Offset = "0x20B7C60", VA = "0x1820B8C60", Slot = "4")]
		[AsyncStateMachine(typeof(CAJJCHLIHKM))]
		public Task<global::APICMLLNCKG<object, AFKOMGPKGOP>> PDHODNEMIHA(TDeps EFNLEFOGALP, TRoot IGJDJDNFANI, TSerializedAction IEFADENHBDL)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly global::POKIOMFIDFH<TActionKind, TSerializedAction, TRoot, TDeps> ELMDOCMPKBK;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8B5D70", Offset = "0x8B4D70", VA = "0x1808B5D70")]
	private ANJLOLAFNBO(global::POKIOMFIDFH<TActionKind, TSerializedAction, TRoot, TDeps> FNIHENPLJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3E25400", Offset = "0x3E24400", VA = "0x183E25400")]
	public static global::ANJLOLAFNBO<TActionKind, TSerializedAction, TRoot, TDeps> CCFMECMIHDM()
	{
		return default(global::ANJLOLAFNBO<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1E34CF0", Offset = "0x1E33CF0", VA = "0x181E34CF0")]
	public global::ANJLOLAFNBO<TActionKind, TSerializedAction, TRoot, TDeps> AJJKDIEIJBL<TPayload, TOk, TErr>(TActionKind HIDJLAJPHCO, global::OCBNPHODHIA<TActionKind, TSerializedAction, TPayload> DLGHGDJLCMF, global::BAGACDOAGGE<TRoot, TPayload, TOk, TErr> LHDOIPIKPDC, bool JKGPGONDAGI = true) where TPayload : notnull where TOk : notnull where TErr : notnull, AFKOMGPKGOP
	{
		return default(global::ANJLOLAFNBO<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1E34CF0", Offset = "0x1E33CF0", VA = "0x181E34CF0")]
	public global::ANJLOLAFNBO<TActionKind, TSerializedAction, TRoot, TDeps> DCBOKEHCMIG<TPayload, TOk, TErr>(TActionKind HIDJLAJPHCO, global::OCBNPHODHIA<TActionKind, TSerializedAction, TPayload> DLGHGDJLCMF, global::ELENMADBPBK<TRoot, TPayload, TOk, TErr> LHDOIPIKPDC, bool JKGPGONDAGI = true) where TPayload : notnull where TOk : notnull where TErr : notnull, AFKOMGPKGOP
	{
		return default(global::ANJLOLAFNBO<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3E254A0", Offset = "0x3E244A0", VA = "0x183E254A0")]
	public global::BLCHKFMDODG<TActionKind, TSerializedAction, TRoot, TDeps> FDBCEIOJCMA(TDeps EFNLEFOGALP)
	{
		return default(global::BLCHKFMDODG<TActionKind, TSerializedAction, TRoot, TDeps>);
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
