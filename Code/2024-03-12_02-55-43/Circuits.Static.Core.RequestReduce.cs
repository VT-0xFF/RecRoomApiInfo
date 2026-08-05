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
		[Cpp2IlInjected.Address(RVA = "0x7E57E0", Offset = "0x7E49E0", VA = "0x1807E57E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1DD0730", Offset = "0x1DCF930", VA = "0x181DD0730")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7E5C40", Offset = "0x7E4E40", VA = "0x1807E5C40")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E5C80", Offset = "0x7E4E80", VA = "0x1807E5C80")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate NHNCPMGLFBJ<TActionKind, TPayload> HEICIFGGMOF<TActionKind, TSerializedAction, TPayload>(TSerializedAction LBFCIELLHKK);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface KAAFGDDGHIO<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<BLNBDNPDEEM<object, NGDCAOKOLMO>> CIBAIPAFHOL(TDeps ECDJFINNJIE, TRoot EAMCHADGEIB, TSerializedAction LBFCIELLHKK);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class HLINBIJKAEO<TActionKind, TSerializedAction, TRoot, TDeps> : DLKKNPCBHBE where TDeps : CMJGBBOLMCF.MPBGOOCJJMA<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps CCPNGOJFLHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction FHEJLCCBBGD;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x37F9A50", Offset = "0x37F8C50", VA = "0x1837F9A50")]
	public HLINBIJKAEO([In] TDeps ECDJFINNJIE, [In] TSerializedAction LBFCIELLHKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x37F9920", Offset = "0x37F8B20", VA = "0x1837F9920", Slot = "7")]
	public override string OKCJCMAJCGL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct NHNCPMGLFBJ<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind DFDEKPLPJOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload IFPKJDHOLEA;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3F23410", Offset = "0x3F22610", VA = "0x183F23410")]
	internal NHNCPMGLFBJ(TActionKind AMAMIEEGDIA, [In] TPayload ECJANKACADL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class BGNBHJAFEKK
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2573390", Offset = "0x2572590", VA = "0x182573390")]
	public static NHNCPMGLFBJ<TActionKind, TPayload> GOMGEEBODDD<TActionKind, TPayload>([In] TActionKind AMAMIEEGDIA, [In] TPayload ECJANKACADL)
	{
		return default(NHNCPMGLFBJ<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<BLNBDNPDEEM<TOk, TErr>> GGLJEOFKGID<TRoot, TPayload, TOk, TErr>(TRoot EAMCHADGEIB, TPayload ECJANKACADL);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate BLNBDNPDEEM<TOk, TErr> LPMEPHFIAIL<TRoot, TPayload, TOk, TErr>(TRoot EAMCHADGEIB, [In] TPayload ECJANKACADL);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct KFOBLBCKJEC<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : CMJGBBOLMCF.MPBGOOCJJMA<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct GOBEIDEAKFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<BLNBDNPDEEM<object, NGDCAOKOLMO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public KFOBLBCKJEC<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<BLNBDNPDEEM<object, NGDCAOKOLMO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x37646D0", Offset = "0x37638D0", VA = "0x1837646D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3764BD0", Offset = "0x3763DD0", VA = "0x183764BD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, KAAFGDDGHIO<TSerializedAction, TRoot, TDeps>> JFBGKPACCIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps CCPNGOJFLHJ;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x90CFA0", Offset = "0x90C1A0", VA = "0x18090CFA0")]
	internal KFOBLBCKJEC(Dictionary<TActionKind, KAAFGDDGHIO<TSerializedAction, TRoot, TDeps>> MPPPLMFEFAL, TDeps ECDJFINNJIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3B5C110", Offset = "0x3B5B310", VA = "0x183B5C110")]
	[AsyncStateMachine(typeof(KFOBLBCKJEC<, , , >.GOBEIDEAKFP))]
	public Task<BLNBDNPDEEM<object, NGDCAOKOLMO>> CIBAIPAFHOL(TRoot EAMCHADGEIB, TSerializedAction LBFCIELLHKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class CMJGBBOLMCF
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface MPBGOOCJJMA<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind GICCMFOGOAN(TSerializedAction KPBGCHDNDLM);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void AMHFHAFGDMM(TRoot EAMCHADGEIB, TSerializedAction CEBHNDLCHED);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void LALOHGOKMGI(TRoot EAMCHADGEIB, TSerializedAction CEBHNDLCHED);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2564860", Offset = "0x2563A60", VA = "0x182564860")]
	internal static KFOBLBCKJEC<TActionKind, TSerializedAction, TRoot, TDeps> GOMGEEBODDD<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, KAAFGDDGHIO<TSerializedAction, TRoot, TDeps>> MPPPLMFEFAL, TDeps ECDJFINNJIE) where TDeps : MPBGOOCJJMA<TActionKind, TSerializedAction, TRoot>
	{
		return default(KFOBLBCKJEC<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class CEIJOMFECNH<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, KAAFGDDGHIO<TSerializedAction, TRoot, TDeps>> OBFFKDOKPKE;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7C5FB0", Offset = "0x7C51B0", VA = "0x1807C5FB0")]
	private CEIJOMFECNH(Dictionary<TActionKind, KAAFGDDGHIO<TSerializedAction, TRoot, TDeps>> MPPPLMFEFAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x49CECE0", Offset = "0x49CDEE0", VA = "0x1849CECE0")]
	public static CEIJOMFECNH<TActionKind, TSerializedAction, TRoot, TDeps> GOMGEEBODDD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct KPFNCFLBNFC<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, CMJGBBOLMCF.MPBGOOCJJMA<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class OBIAACCNMKN<TPayload, TOk, TErr> : KAAFGDDGHIO<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, NGDCAOKOLMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly HEICIFGGMOF<TActionKind, TSerializedAction, TPayload> DOGGNEOCGDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly LPMEPHFIAIL<TRoot, TPayload, TOk, TErr> OFANEKNPEMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool FKPDEALABKF;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3F5F6F0", Offset = "0x3F5E8F0", VA = "0x183F5F6F0")]
		public OBIAACCNMKN(HEICIFGGMOF<TActionKind, TSerializedAction, TPayload> KLDIFLJCPMA, LPMEPHFIAIL<TRoot, TPayload, TOk, TErr> HLPOCIKAKDC, bool HKOFAJOHBGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x4042A80", Offset = "0x4041C80", VA = "0x184042A80", Slot = "4")]
		public Task<BLNBDNPDEEM<object, NGDCAOKOLMO>> CIBAIPAFHOL(TDeps ECDJFINNJIE, TRoot EAMCHADGEIB, TSerializedAction LBFCIELLHKK)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class NLBFAMKNKFO<TPayload, TOk, TErr> : KAAFGDDGHIO<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, NGDCAOKOLMO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct DKHPLKJLJOL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<BLNBDNPDEEM<object?, NGDCAOKOLMO>> <>t__builder;

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
			public NLBFAMKNKFO<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private BLNBDNPDEEM<object?, NGDCAOKOLMO> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<BLNBDNPDEEM<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x507E5B0", Offset = "0x507D7B0", VA = "0x18507E5B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x507EF60", Offset = "0x507E160", VA = "0x18507EF60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly HEICIFGGMOF<TActionKind, TSerializedAction, TPayload> DOGGNEOCGDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly GGLJEOFKGID<TRoot, TPayload, TOk, TErr> OFANEKNPEMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool FKPDEALABKF;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3F5F6F0", Offset = "0x3F5E8F0", VA = "0x183F5F6F0")]
		public NLBFAMKNKFO(HEICIFGGMOF<TActionKind, TSerializedAction, TPayload> KLDIFLJCPMA, GGLJEOFKGID<TRoot, TPayload, TOk, TErr> HLPOCIKAKDC, bool HKOFAJOHBGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3F5F170", Offset = "0x3F5E370", VA = "0x183F5F170", Slot = "4")]
		[AsyncStateMachine(typeof(NLBFAMKNKFO<, , >.DKHPLKJLJOL))]
		public Task<BLNBDNPDEEM<object, NGDCAOKOLMO>> CIBAIPAFHOL(TDeps ECDJFINNJIE, TRoot EAMCHADGEIB, TSerializedAction LBFCIELLHKK)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly CEIJOMFECNH<TActionKind, TSerializedAction, TRoot, TDeps> EHOFGNEHMAA;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x947980", Offset = "0x946B80", VA = "0x180947980")]
	private KPFNCFLBNFC(CEIJOMFECNH<TActionKind, TSerializedAction, TRoot, TDeps> GKNJGNIHLDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3BA0150", Offset = "0x3B9F350", VA = "0x183BA0150")]
	public static KPFNCFLBNFC<TActionKind, TSerializedAction, TRoot, TDeps> GOMGEEBODDD()
	{
		return default(KPFNCFLBNFC<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x26A7820", Offset = "0x26A6A20", VA = "0x1826A7820")]
	public KPFNCFLBNFC<TActionKind, TSerializedAction, TRoot, TDeps> BFAFIDIFFEP<TPayload, TOk, TErr>(TActionKind AMAMIEEGDIA, HEICIFGGMOF<TActionKind, TSerializedAction, TPayload> KLDIFLJCPMA, LPMEPHFIAIL<TRoot, TPayload, TOk, TErr> HLPOCIKAKDC, bool HKOFAJOHBGP = true) where TPayload : notnull where TOk : notnull where TErr : notnull, NGDCAOKOLMO
	{
		return default(KPFNCFLBNFC<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x26A7820", Offset = "0x26A6A20", VA = "0x1826A7820")]
	public KPFNCFLBNFC<TActionKind, TSerializedAction, TRoot, TDeps> IANAMDBGGHN<TPayload, TOk, TErr>(TActionKind AMAMIEEGDIA, HEICIFGGMOF<TActionKind, TSerializedAction, TPayload> KLDIFLJCPMA, GGLJEOFKGID<TRoot, TPayload, TOk, TErr> HLPOCIKAKDC, bool HKOFAJOHBGP = true) where TPayload : notnull where TOk : notnull where TErr : notnull, NGDCAOKOLMO
	{
		return default(KPFNCFLBNFC<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3BA01E0", Offset = "0x3B9F3E0", VA = "0x183BA01E0")]
	public KFOBLBCKJEC<TActionKind, TSerializedAction, TRoot, TDeps> HIGLEHLPIPD(TDeps ECDJFINNJIE)
	{
		return default(KFOBLBCKJEC<TActionKind, TSerializedAction, TRoot, TDeps>);
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
