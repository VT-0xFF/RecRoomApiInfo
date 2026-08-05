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
		[Cpp2IlInjected.Address(RVA = "0x9827A0", Offset = "0x9813A0", VA = "0x1809827A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x255B690", Offset = "0x255A290", VA = "0x18255B690")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9836D0", Offset = "0x9822D0", VA = "0x1809836D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x983710", Offset = "0x982310", VA = "0x180983710")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate IGLANCPFJMB<TActionKind, TPayload> PLOGPGEGIFJ<TActionKind, TSerializedAction, TPayload>(TSerializedAction AMFJOCEAPNK);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface FDMPAGEILMF<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PNJEPLMEKHI<object, GEJJJMKDLKA>> KPDHBIJEMPN(TDeps CJMMHNIMOJB, TRoot EBMDCHEPJIM, TSerializedAction AMFJOCEAPNK);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class LIDJKMEPAIP<TActionKind, TSerializedAction, TRoot, TDeps> : HJOMFIPJJDB where TDeps : PPMIOCPEKCK.INGEHKDCKHO<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps IHDBCEJNIED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction CJIDKFJIEMC;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4B36C00", Offset = "0x4B35800", VA = "0x184B36C00")]
	public LIDJKMEPAIP([In] TDeps CJMMHNIMOJB, [In] TSerializedAction AMFJOCEAPNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4B36AD0", Offset = "0x4B356D0", VA = "0x184B36AD0", Slot = "7")]
	public override string CNPDCBKGCII()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct IGLANCPFJMB<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind CIIODCACOOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload DGDELCNMLOA;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x46FCE30", Offset = "0x46FBA30", VA = "0x1846FCE30")]
	internal IGLANCPFJMB(TActionKind AJOKPBPGCDI, [In] TPayload BFDCDDMLJOF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class NCHCBEPEJON
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x34D7C40", Offset = "0x34D6840", VA = "0x1834D7C40")]
	public static IGLANCPFJMB<TActionKind, TPayload> JPHABLICNHB<TActionKind, TPayload>([In] TActionKind AJOKPBPGCDI, [In] TPayload BFDCDDMLJOF)
	{
		return default(IGLANCPFJMB<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<PNJEPLMEKHI<TOk, TErr>> HJEHJCMFCDI<TRoot, TPayload, TOk, TErr>(TRoot EBMDCHEPJIM, TPayload BFDCDDMLJOF);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate PNJEPLMEKHI<TOk, TErr> IAMNLDICHAM<TRoot, TPayload, TOk, TErr>(TRoot EBMDCHEPJIM, [In] TPayload BFDCDDMLJOF);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct AIHCJGIHFDN<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : PPMIOCPEKCK.INGEHKDCKHO<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct OEBIOHILMBH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<PNJEPLMEKHI<object?, GEJJJMKDLKA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public AIHCJGIHFDN<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<PNJEPLMEKHI<object, GEJJJMKDLKA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x4F73F80", Offset = "0x4F72B80", VA = "0x184F73F80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4F748D0", Offset = "0x4F734D0", VA = "0x184F748D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, FDMPAGEILMF<TSerializedAction, TRoot, TDeps>> IOLAKONPCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps IHDBCEJNIED;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x9DD890", Offset = "0x9DC490", VA = "0x1809DD890")]
	internal AIHCJGIHFDN(Dictionary<TActionKind, FDMPAGEILMF<TSerializedAction, TRoot, TDeps>> AHILEEOAFAO, TDeps CJMMHNIMOJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x466F240", Offset = "0x466DE40", VA = "0x18466F240")]
	[AsyncStateMachine(typeof(AIHCJGIHFDN<, , , >.OEBIOHILMBH))]
	public Task<PNJEPLMEKHI<object, GEJJJMKDLKA>> KPDHBIJEMPN(TRoot EBMDCHEPJIM, TSerializedAction AMFJOCEAPNK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class PPMIOCPEKCK
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface INGEHKDCKHO<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind IEEKIBFHEBF(TSerializedAction DKGDAEBOJKO);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void CDJCEHFNLCB(TRoot EBMDCHEPJIM, TSerializedAction OAGMINHECCA);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void AKGAPEJCOMO(TRoot EBMDCHEPJIM, TSerializedAction OAGMINHECCA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x316A2D0", Offset = "0x3168ED0", VA = "0x18316A2D0")]
	internal static AIHCJGIHFDN<TActionKind, TSerializedAction, TRoot, TDeps> JPHABLICNHB<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, FDMPAGEILMF<TSerializedAction, TRoot, TDeps>> AHILEEOAFAO, TDeps CJMMHNIMOJB) where TDeps : INGEHKDCKHO<TActionKind, TSerializedAction, TRoot>
	{
		return default(AIHCJGIHFDN<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class CDBACHNFOFA<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, FDMPAGEILMF<TSerializedAction, TRoot, TDeps>> PCIPOIFCPKF;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x95A080", Offset = "0x958C80", VA = "0x18095A080")]
	private CDBACHNFOFA(Dictionary<TActionKind, FDMPAGEILMF<TSerializedAction, TRoot, TDeps>> AHILEEOAFAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x59BA110", Offset = "0x59B8D10", VA = "0x1859BA110")]
	public static CDBACHNFOFA<TActionKind, TSerializedAction, TRoot, TDeps> JPHABLICNHB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct HLKPIDMGNGP<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, PPMIOCPEKCK.INGEHKDCKHO<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class GLOOBDMNPCJ<TPayload, TOk, TErr> : FDMPAGEILMF<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, GEJJJMKDLKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly PLOGPGEGIFJ<TActionKind, TSerializedAction, TPayload> POKOAHHEGMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly IAMNLDICHAM<TRoot, TPayload, TOk, TErr> DELODPMFMEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool MOJHHIFOGOO;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x44E2DC0", Offset = "0x44E19C0", VA = "0x1844E2DC0")]
		public GLOOBDMNPCJ(PLOGPGEGIFJ<TActionKind, TSerializedAction, TPayload> HCIBNGAFGCF, IAMNLDICHAM<TRoot, TPayload, TOk, TErr> FPBDIPDGPLL, bool CFPDMPHHIOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x44E2A30", Offset = "0x44E1630", VA = "0x1844E2A30", Slot = "4")]
		public Task<PNJEPLMEKHI<object, GEJJJMKDLKA>> KPDHBIJEMPN(TDeps CJMMHNIMOJB, TRoot EBMDCHEPJIM, TSerializedAction AMFJOCEAPNK)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class MGKEKDHFOJO<TPayload, TOk, TErr> : FDMPAGEILMF<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, GEJJJMKDLKA
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct NAAKNNEADPK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<PNJEPLMEKHI<object?, GEJJJMKDLKA>> <>t__builder;

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
			public MGKEKDHFOJO<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private PNJEPLMEKHI<object?, GEJJJMKDLKA> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<PNJEPLMEKHI<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x4DE3AC0", Offset = "0x4DE26C0", VA = "0x184DE3AC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x4DE49C0", Offset = "0x4DE35C0", VA = "0x184DE49C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly PLOGPGEGIFJ<TActionKind, TSerializedAction, TPayload> POKOAHHEGMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly HJEHJCMFCDI<TRoot, TPayload, TOk, TErr> DELODPMFMEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool MOJHHIFOGOO;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x44E2DC0", Offset = "0x44E19C0", VA = "0x1844E2DC0")]
		public MGKEKDHFOJO(PLOGPGEGIFJ<TActionKind, TSerializedAction, TPayload> HCIBNGAFGCF, HJEHJCMFCDI<TRoot, TPayload, TOk, TErr> FPBDIPDGPLL, bool CFPDMPHHIOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x4D453E0", Offset = "0x4D43FE0", VA = "0x184D453E0", Slot = "4")]
		[AsyncStateMachine(typeof(MGKEKDHFOJO<, , >.NAAKNNEADPK))]
		public Task<PNJEPLMEKHI<object, GEJJJMKDLKA>> KPDHBIJEMPN(TDeps CJMMHNIMOJB, TRoot EBMDCHEPJIM, TSerializedAction AMFJOCEAPNK)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly CDBACHNFOFA<TActionKind, TSerializedAction, TRoot, TDeps> GMAMOGJFOPF;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xBDB470", Offset = "0xBDA070", VA = "0x180BDB470")]
	private HLKPIDMGNGP(CDBACHNFOFA<TActionKind, TSerializedAction, TRoot, TDeps> LLDJIJICLJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4630CC0", Offset = "0x462F8C0", VA = "0x184630CC0")]
	public static HLKPIDMGNGP<TActionKind, TSerializedAction, TRoot, TDeps> JPHABLICNHB()
	{
		return default(HLKPIDMGNGP<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x33C9D90", Offset = "0x33C8990", VA = "0x1833C9D90")]
	public HLKPIDMGNGP<TActionKind, TSerializedAction, TRoot, TDeps> ABIOKOFHIDH<TPayload, TOk, TErr>(TActionKind AJOKPBPGCDI, PLOGPGEGIFJ<TActionKind, TSerializedAction, TPayload> HCIBNGAFGCF, IAMNLDICHAM<TRoot, TPayload, TOk, TErr> FPBDIPDGPLL, bool CFPDMPHHIOA = true) where TPayload : notnull where TOk : notnull where TErr : notnull, GEJJJMKDLKA
	{
		return default(HLKPIDMGNGP<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x33C9D90", Offset = "0x33C8990", VA = "0x1833C9D90")]
	public HLKPIDMGNGP<TActionKind, TSerializedAction, TRoot, TDeps> JICNBHMFBAE<TPayload, TOk, TErr>(TActionKind AJOKPBPGCDI, PLOGPGEGIFJ<TActionKind, TSerializedAction, TPayload> HCIBNGAFGCF, HJEHJCMFCDI<TRoot, TPayload, TOk, TErr> FPBDIPDGPLL, bool CFPDMPHHIOA = true) where TPayload : notnull where TOk : notnull where TErr : notnull, GEJJJMKDLKA
	{
		return default(HLKPIDMGNGP<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4630D60", Offset = "0x462F960", VA = "0x184630D60")]
	public AIHCJGIHFDN<TActionKind, TSerializedAction, TRoot, TDeps> NLIPOCPBNPJ(TDeps CJMMHNIMOJB)
	{
		return default(AIHCJGIHFDN<TActionKind, TSerializedAction, TRoot, TDeps>);
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
