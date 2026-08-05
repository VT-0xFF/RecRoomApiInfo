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
		[Cpp2IlInjected.Address(RVA = "0x7E3470", Offset = "0x7E2270", VA = "0x1807E3470")]
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
		[Cpp2IlInjected.Address(RVA = "0x1DBC990", Offset = "0x1DBB790", VA = "0x181DBC990")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7E43F0", Offset = "0x7E31F0", VA = "0x1807E43F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E4430", Offset = "0x7E3230", VA = "0x1807E4430")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate GLGKNKBPEGM<TActionKind, TPayload> OEBFBPBIDHJ<TActionKind, TSerializedAction, TPayload>(TSerializedAction AMPEEGBBPGK);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface GKNGDIGMKNM<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<BOHHCOEKANF<object, NOBEHEHNHMO>> BBJMGGGHFJJ(TDeps IKMKPNFBOIN, TRoot GOKLEGFJHEB, TSerializedAction AMPEEGBBPGK);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class IMBJOECLNDL<TActionKind, TSerializedAction, TRoot, TDeps> : FMIGMFBOJEI where TDeps : JFKMELOJMFD.KDKIMEGIMOI<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps OHEILJJDMBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction PLFBIACNAPF;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x389B790", Offset = "0x389A590", VA = "0x18389B790")]
	public IMBJOECLNDL([In] TDeps IKMKPNFBOIN, [In] TSerializedAction AMPEEGBBPGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x389B6C0", Offset = "0x389A4C0", VA = "0x18389B6C0", Slot = "7")]
	public override string LFKJGAHPPDN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct GLGKNKBPEGM<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind BHELKAGFIGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload LELJAPKHFGK;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x370E680", Offset = "0x370D480", VA = "0x18370E680")]
	internal GLGKNKBPEGM(TActionKind CACEKDHCHPO, [In] TPayload AOJMAAJAPBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class COHFJOBJEOC
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x25970A0", Offset = "0x2595EA0", VA = "0x1825970A0")]
	public static GLGKNKBPEGM<TActionKind, TPayload> IKCDCJJCDKO<TActionKind, TPayload>([In] TActionKind CACEKDHCHPO, [In] TPayload AOJMAAJAPBJ)
	{
		return default(GLGKNKBPEGM<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<BOHHCOEKANF<TOk, TErr>> IBEGPCLELJH<TRoot, TPayload, TOk, TErr>(TRoot GOKLEGFJHEB, TPayload AOJMAAJAPBJ);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate BOHHCOEKANF<TOk, TErr> CECBKBFFGHE<TRoot, TPayload, TOk, TErr>(TRoot GOKLEGFJHEB, [In] TPayload AOJMAAJAPBJ);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct BFLIKDDDMEO<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : JFKMELOJMFD.KDKIMEGIMOI<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct BAKDIAMAEFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<BOHHCOEKANF<object, NOBEHEHNHMO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public BFLIKDDDMEO<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<BOHHCOEKANF<object, NOBEHEHNHMO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x4749FE0", Offset = "0x4748DE0", VA = "0x184749FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x474A970", Offset = "0x4749770", VA = "0x18474A970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, GKNGDIGMKNM<TSerializedAction, TRoot, TDeps>> AKGMEBFGJCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps OHEILJJDMBM;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8F0EC0", Offset = "0x8EFCC0", VA = "0x1808F0EC0")]
	internal BFLIKDDDMEO(Dictionary<TActionKind, GKNGDIGMKNM<TSerializedAction, TRoot, TDeps>> DJFDLPBIBJN, TDeps IKMKPNFBOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4771B60", Offset = "0x4770960", VA = "0x184771B60")]
	[AsyncStateMachine(typeof(BFLIKDDDMEO<, , , >.BAKDIAMAEFN))]
	public Task<BOHHCOEKANF<object, NOBEHEHNHMO>> BBJMGGGHFJJ(TRoot GOKLEGFJHEB, TSerializedAction AMPEEGBBPGK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class JFKMELOJMFD
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface KDKIMEGIMOI<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind DGHJAALIPLO(TSerializedAction OELHNDCFEMO);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void HKAPDGCFEJL(TRoot GOKLEGFJHEB, TSerializedAction CJMBDOEJJJI);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void EBAPNIMHLPK(TRoot GOKLEGFJHEB, TSerializedAction CJMBDOEJJJI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x25C26C0", Offset = "0x25C14C0", VA = "0x1825C26C0")]
	internal static BFLIKDDDMEO<TActionKind, TSerializedAction, TRoot, TDeps> IKCDCJJCDKO<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, GKNGDIGMKNM<TSerializedAction, TRoot, TDeps>> DJFDLPBIBJN, TDeps IKMKPNFBOIN) where TDeps : KDKIMEGIMOI<TActionKind, TSerializedAction, TRoot>
	{
		return default(BFLIKDDDMEO<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class BMOLEOKNCPL<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, GKNGDIGMKNM<TSerializedAction, TRoot, TDeps>> NDBLELFFMDB;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7C8480", Offset = "0x7C7280", VA = "0x1807C8480")]
	private BMOLEOKNCPL(Dictionary<TActionKind, GKNGDIGMKNM<TSerializedAction, TRoot, TDeps>> DJFDLPBIBJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x48B1BD0", Offset = "0x48B09D0", VA = "0x1848B1BD0")]
	public static BMOLEOKNCPL<TActionKind, TSerializedAction, TRoot, TDeps> IKCDCJJCDKO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct IBBMNINNIDC<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, JFKMELOJMFD.KDKIMEGIMOI<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class AELEABJAJGO<TPayload, TOk, TErr> : GKNGDIGMKNM<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, NOBEHEHNHMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly OEBFBPBIDHJ<TActionKind, TSerializedAction, TPayload> ODDHKFCAFAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly CECBKBFFGHE<TRoot, TPayload, TOk, TErr> ABLDGHEJAMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool AMLNFMLIPHC;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3779FC0", Offset = "0x3778DC0", VA = "0x183779FC0")]
		public AELEABJAJGO(OEBFBPBIDHJ<TActionKind, TSerializedAction, TPayload> JAIADPHMGOC, CECBKBFFGHE<TRoot, TPayload, TOk, TErr> HBBHOLEBLCN, bool FGMPFPEEHDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x376FD90", Offset = "0x376EB90", VA = "0x18376FD90", Slot = "4")]
		public Task<BOHHCOEKANF<object, NOBEHEHNHMO>> BBJMGGGHFJJ(TDeps IKMKPNFBOIN, TRoot GOKLEGFJHEB, TSerializedAction AMPEEGBBPGK)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class JOMFMOGFBDO<TPayload, TOk, TErr> : GKNGDIGMKNM<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, NOBEHEHNHMO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct GHLFKCACGHB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<BOHHCOEKANF<object?, NOBEHEHNHMO>> <>t__builder;

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
			public JOMFMOGFBDO<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private BOHHCOEKANF<object?, NOBEHEHNHMO> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<BOHHCOEKANF<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x3703C40", Offset = "0x3702A40", VA = "0x183703C40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x37050B0", Offset = "0x3703EB0", VA = "0x1837050B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly OEBFBPBIDHJ<TActionKind, TSerializedAction, TPayload> ODDHKFCAFAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly IBEGPCLELJH<TRoot, TPayload, TOk, TErr> ABLDGHEJAMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool AMLNFMLIPHC;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3779FC0", Offset = "0x3778DC0", VA = "0x183779FC0")]
		public JOMFMOGFBDO(OEBFBPBIDHJ<TActionKind, TSerializedAction, TPayload> JAIADPHMGOC, IBEGPCLELJH<TRoot, TPayload, TOk, TErr> HBBHOLEBLCN, bool FGMPFPEEHDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3A82630", Offset = "0x3A81430", VA = "0x183A82630", Slot = "4")]
		[AsyncStateMachine(typeof(JOMFMOGFBDO<, , >.GHLFKCACGHB))]
		public Task<BOHHCOEKANF<object, NOBEHEHNHMO>> BBJMGGGHFJJ(TDeps IKMKPNFBOIN, TRoot GOKLEGFJHEB, TSerializedAction AMPEEGBBPGK)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly BMOLEOKNCPL<TActionKind, TSerializedAction, TRoot, TDeps> LDKGMPHCAJJ;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x9288D0", Offset = "0x9276D0", VA = "0x1809288D0")]
	private IBBMNINNIDC(BMOLEOKNCPL<TActionKind, TSerializedAction, TRoot, TDeps> EEDANCJJEPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x385C340", Offset = "0x385B140", VA = "0x18385C340")]
	public static IBBMNINNIDC<TActionKind, TSerializedAction, TRoot, TDeps> IKCDCJJCDKO()
	{
		return default(IBBMNINNIDC<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x22A6DB0", Offset = "0x22A5BB0", VA = "0x1822A6DB0")]
	public IBBMNINNIDC<TActionKind, TSerializedAction, TRoot, TDeps> EKBGMINCNAC<TPayload, TOk, TErr>(TActionKind CACEKDHCHPO, OEBFBPBIDHJ<TActionKind, TSerializedAction, TPayload> JAIADPHMGOC, CECBKBFFGHE<TRoot, TPayload, TOk, TErr> HBBHOLEBLCN, bool FGMPFPEEHDL = true) where TPayload : notnull where TOk : notnull where TErr : notnull, NOBEHEHNHMO
	{
		return default(IBBMNINNIDC<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x22A6DB0", Offset = "0x22A5BB0", VA = "0x1822A6DB0")]
	public IBBMNINNIDC<TActionKind, TSerializedAction, TRoot, TDeps> MOJBDFODMBC<TPayload, TOk, TErr>(TActionKind CACEKDHCHPO, OEBFBPBIDHJ<TActionKind, TSerializedAction, TPayload> JAIADPHMGOC, IBEGPCLELJH<TRoot, TPayload, TOk, TErr> HBBHOLEBLCN, bool FGMPFPEEHDL = true) where TPayload : notnull where TOk : notnull where TErr : notnull, NOBEHEHNHMO
	{
		return default(IBBMNINNIDC<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x385C3D0", Offset = "0x385B1D0", VA = "0x18385C3D0")]
	public BFLIKDDDMEO<TActionKind, TSerializedAction, TRoot, TDeps> OJGKBEINDOC(TDeps IKMKPNFBOIN)
	{
		return default(BFLIKDDDMEO<TActionKind, TSerializedAction, TRoot, TDeps>);
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
