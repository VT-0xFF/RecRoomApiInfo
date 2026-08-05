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
		[Cpp2IlInjected.Address(RVA = "0x91D620", Offset = "0x91C820", VA = "0x18091D620")]
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
		[Cpp2IlInjected.Address(RVA = "0x25395D0", Offset = "0x25387D0", VA = "0x1825395D0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x91E490", Offset = "0x91D690", VA = "0x18091E490")]
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
		[Cpp2IlInjected.Address(RVA = "0x91E4D0", Offset = "0x91D6D0", VA = "0x18091E4D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate EHOGFMPDNAM<TActionKind, TPayload> DEEBEHBNMLH<TActionKind, TSerializedAction, TPayload>(TSerializedAction FCECABNPIMI);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface EPBMKBKPKAN<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<EBOICGKKPAM<object, LKEBDJCDIFL>> EKFOLBMLNHA(TDeps KHICLIFOGCP, TRoot DONMCNODAED, TSerializedAction FCECABNPIMI);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class FFDEGGJNANB<TActionKind, TSerializedAction, TRoot, TDeps> : ODKGPKGHBED where TDeps : PICIEGNBDJL.EEIAMFPGFEG<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps PHOHCHAEDED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction BNAMDKMCGEF;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x42E2A20", Offset = "0x42E1C20", VA = "0x1842E2A20")]
	public FFDEGGJNANB([In] TDeps KHICLIFOGCP, [In] TSerializedAction FCECABNPIMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x42E2900", Offset = "0x42E1B00", VA = "0x1842E2900", Slot = "7")]
	public override string OEJBHPKDIJD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct EHOGFMPDNAM<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind LHDKINLKODA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload DBAABDGHMBI;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3F16700", Offset = "0x3F15900", VA = "0x183F16700")]
	internal EHOGFMPDNAM(TActionKind JOODFGEGOCC, [In] TPayload OCPJHHIMKFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class HKEGCGLCJIB
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3290FF0", Offset = "0x32901F0", VA = "0x183290FF0")]
	public static EHOGFMPDNAM<TActionKind, TPayload> PAJOIGLPBMN<TActionKind, TPayload>([In] TActionKind JOODFGEGOCC, [In] TPayload OCPJHHIMKFB)
	{
		return default(EHOGFMPDNAM<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<EBOICGKKPAM<TOk, TErr>> GJOLPAPOGGL<TRoot, TPayload, TOk, TErr>(TRoot DONMCNODAED, TPayload OCPJHHIMKFB);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate EBOICGKKPAM<TOk, TErr> PABGILMOJFN<TRoot, TPayload, TOk, TErr>(TRoot DONMCNODAED, [In] TPayload OCPJHHIMKFB);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct FPMCEKNKPNH<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : PICIEGNBDJL.EEIAMFPGFEG<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct KALFNCDGKGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<EBOICGKKPAM<object?, LKEBDJCDIFL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public FPMCEKNKPNH<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<EBOICGKKPAM<object, LKEBDJCDIFL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x4915FE0", Offset = "0x49151E0", VA = "0x184915FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4916460", Offset = "0x4915660", VA = "0x184916460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, EPBMKBKPKAN<TSerializedAction, TRoot, TDeps>> AHEAFEJCIHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps PHOHCHAEDED;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x982390", Offset = "0x981590", VA = "0x180982390")]
	internal FPMCEKNKPNH(Dictionary<TActionKind, EPBMKBKPKAN<TSerializedAction, TRoot, TDeps>> JNMGGLBFPLG, TDeps KHICLIFOGCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4304840", Offset = "0x4303A40", VA = "0x184304840")]
	[AsyncStateMachine(typeof(FPMCEKNKPNH<, , , >.KALFNCDGKGE))]
	public Task<EBOICGKKPAM<object, LKEBDJCDIFL>> EKFOLBMLNHA(TRoot DONMCNODAED, TSerializedAction FCECABNPIMI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class PICIEGNBDJL
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface EEIAMFPGFEG<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind EGBNBHDFPKI(TSerializedAction MLNFAKCEGNM);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void HGGHFLPIMLB(TRoot DONMCNODAED, TSerializedAction KOMGLJOLBFC);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void JGNIOJOFFDK(TRoot DONMCNODAED, TSerializedAction KOMGLJOLBFC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x32B8710", Offset = "0x32B7910", VA = "0x1832B8710")]
	internal static FPMCEKNKPNH<TActionKind, TSerializedAction, TRoot, TDeps> PAJOIGLPBMN<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, EPBMKBKPKAN<TSerializedAction, TRoot, TDeps>> JNMGGLBFPLG, TDeps KHICLIFOGCP) where TDeps : EEIAMFPGFEG<TActionKind, TSerializedAction, TRoot>
	{
		return default(FPMCEKNKPNH<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class OMHPCCCGJGD<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, EPBMKBKPKAN<TSerializedAction, TRoot, TDeps>> LKCDJAPKOID;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x902B20", Offset = "0x901D20", VA = "0x180902B20")]
	private OMHPCCCGJGD(Dictionary<TActionKind, EPBMKBKPKAN<TSerializedAction, TRoot, TDeps>> JNMGGLBFPLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4E3DCE0", Offset = "0x4E3CEE0", VA = "0x184E3DCE0")]
	public static OMHPCCCGJGD<TActionKind, TSerializedAction, TRoot, TDeps> PAJOIGLPBMN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct IHLMHPIPNGI<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, PICIEGNBDJL.EEIAMFPGFEG<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class HBPKKNALAAB<TPayload, TOk, TErr> : EPBMKBKPKAN<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, LKEBDJCDIFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly DEEBEHBNMLH<TActionKind, TSerializedAction, TPayload> NHFPEIHHMDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly PABGILMOJFN<TRoot, TPayload, TOk, TErr> IJILBGEKCIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool ONMHFLINPPJ;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x449C5E0", Offset = "0x449B7E0", VA = "0x18449C5E0")]
		public HBPKKNALAAB(DEEBEHBNMLH<TActionKind, TSerializedAction, TPayload> MMCLAPFANCC, PABGILMOJFN<TRoot, TPayload, TOk, TErr> EAFFIONCPOP, bool HAGOHBOELCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x448ECB0", Offset = "0x448DEB0", VA = "0x18448ECB0", Slot = "4")]
		public Task<EBOICGKKPAM<object, LKEBDJCDIFL>> EKFOLBMLNHA(TDeps KHICLIFOGCP, TRoot DONMCNODAED, TSerializedAction FCECABNPIMI)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class CLJLBLGPMDJ<TPayload, TOk, TErr> : EPBMKBKPKAN<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, LKEBDJCDIFL
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct JCFNGLDOOLI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<EBOICGKKPAM<object?, LKEBDJCDIFL>> <>t__builder;

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
			public CLJLBLGPMDJ<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private EBOICGKKPAM<object?, LKEBDJCDIFL> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<EBOICGKKPAM<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x481B590", Offset = "0x481A790", VA = "0x18481B590", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x481C550", Offset = "0x481B750", VA = "0x18481C550", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly DEEBEHBNMLH<TActionKind, TSerializedAction, TPayload> NHFPEIHHMDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly GJOLPAPOGGL<TRoot, TPayload, TOk, TErr> IJILBGEKCIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool ONMHFLINPPJ;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x449C5E0", Offset = "0x449B7E0", VA = "0x18449C5E0")]
		public CLJLBLGPMDJ(DEEBEHBNMLH<TActionKind, TSerializedAction, TPayload> MMCLAPFANCC, GJOLPAPOGGL<TRoot, TPayload, TOk, TErr> EAFFIONCPOP, bool HAGOHBOELCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5881300", Offset = "0x5880500", VA = "0x185881300", Slot = "4")]
		[AsyncStateMachine(typeof(CLJLBLGPMDJ<, , >.JCFNGLDOOLI))]
		public Task<EBOICGKKPAM<object, LKEBDJCDIFL>> EKFOLBMLNHA(TDeps KHICLIFOGCP, TRoot DONMCNODAED, TSerializedAction FCECABNPIMI)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly OMHPCCCGJGD<TActionKind, TSerializedAction, TRoot, TDeps> KJHLEFLCCKE;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xBC2740", Offset = "0xBC1940", VA = "0x180BC2740")]
	private IHLMHPIPNGI(OMHPCCCGJGD<TActionKind, TSerializedAction, TRoot, TDeps> LFDKFEEPNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4645020", Offset = "0x4644220", VA = "0x184645020")]
	public static IHLMHPIPNGI<TActionKind, TSerializedAction, TRoot, TDeps> PAJOIGLPBMN()
	{
		return default(IHLMHPIPNGI<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3410E80", Offset = "0x3410080", VA = "0x183410E80")]
	public IHLMHPIPNGI<TActionKind, TSerializedAction, TRoot, TDeps> NLKBJENKEKD<TPayload, TOk, TErr>(TActionKind JOODFGEGOCC, DEEBEHBNMLH<TActionKind, TSerializedAction, TPayload> MMCLAPFANCC, PABGILMOJFN<TRoot, TPayload, TOk, TErr> EAFFIONCPOP, bool HAGOHBOELCL = true) where TPayload : notnull where TOk : notnull where TErr : notnull, LKEBDJCDIFL
	{
		return default(IHLMHPIPNGI<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3410E80", Offset = "0x3410080", VA = "0x183410E80")]
	public IHLMHPIPNGI<TActionKind, TSerializedAction, TRoot, TDeps> ANFNFLCPLLP<TPayload, TOk, TErr>(TActionKind JOODFGEGOCC, DEEBEHBNMLH<TActionKind, TSerializedAction, TPayload> MMCLAPFANCC, GJOLPAPOGGL<TRoot, TPayload, TOk, TErr> EAFFIONCPOP, bool HAGOHBOELCL = true) where TPayload : notnull where TOk : notnull where TErr : notnull, LKEBDJCDIFL
	{
		return default(IHLMHPIPNGI<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4644F60", Offset = "0x4644160", VA = "0x184644F60")]
	public FPMCEKNKPNH<TActionKind, TSerializedAction, TRoot, TDeps> MEHOHBKCKNL(TDeps KHICLIFOGCP)
	{
		return default(FPMCEKNKPNH<TActionKind, TSerializedAction, TRoot, TDeps>);
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
