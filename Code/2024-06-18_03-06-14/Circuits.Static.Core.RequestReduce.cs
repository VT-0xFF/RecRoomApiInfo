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
		[Cpp2IlInjected.Address(RVA = "0x876AF0", Offset = "0x8754F0", VA = "0x180876AF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FBF6E0", Offset = "0x1FBE0E0", VA = "0x181FBF6E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8775C0", Offset = "0x875FC0", VA = "0x1808775C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x877600", Offset = "0x876000", VA = "0x180877600")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate LHHPDMNBHBE<TActionKind, TPayload> CBPDPDBOBPB<TActionKind, TSerializedAction, TPayload>(TSerializedAction JCBJPJGFKLP);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface FMGIDPLAPIC<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FNBKHJCMJJM<object, AEFDHDNANIN>> JIBJAANJGPB(TDeps GMLBPALEECE, TRoot GPKGNPPAAHE, TSerializedAction JCBJPJGFKLP);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class MLPFAMJCDKB<TActionKind, TSerializedAction, TRoot, TDeps> : GACFHBDKGHN where TDeps : JEBDINHGMFM.PACEHAHFELP<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps OHOKKIEJNJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction AHFICPDOFKO;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x447CF70", Offset = "0x447B970", VA = "0x18447CF70")]
	public MLPFAMJCDKB([In] TDeps GMLBPALEECE, [In] TSerializedAction JCBJPJGFKLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x447CE50", Offset = "0x447B850", VA = "0x18447CE50", Slot = "7")]
	public override string BMFLCAMIMMJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct LHHPDMNBHBE<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind OLCBMLOHLDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload LGMMADNEJEI;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4286AD0", Offset = "0x42854D0", VA = "0x184286AD0")]
	internal LHHPDMNBHBE(TActionKind LPPOGGCPKLJ, [In] TPayload NBBCEJPPPCO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class PINAFHKEILM
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2CF3B00", Offset = "0x2CF2500", VA = "0x182CF3B00")]
	public static LHHPDMNBHBE<TActionKind, TPayload> KHKANEAPNIK<TActionKind, TPayload>([In] TActionKind LPPOGGCPKLJ, [In] TPayload NBBCEJPPPCO)
	{
		return default(LHHPDMNBHBE<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<FNBKHJCMJJM<TOk, TErr>> CKOHIPCHMLG<TRoot, TPayload, TOk, TErr>(TRoot GPKGNPPAAHE, TPayload NBBCEJPPPCO);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate FNBKHJCMJJM<TOk, TErr> IMHJOLHCFBE<TRoot, TPayload, TOk, TErr>(TRoot GPKGNPPAAHE, [In] TPayload NBBCEJPPPCO);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct MHEIPCCIOBH<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : JEBDINHGMFM.PACEHAHFELP<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct LPDLALJDAHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<FNBKHJCMJJM<object, AEFDHDNANIN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public MHEIPCCIOBH<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<FNBKHJCMJJM<object, AEFDHDNANIN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x42A8100", Offset = "0x42A6B00", VA = "0x1842A8100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x42A8570", Offset = "0x42A6F70", VA = "0x1842A8570", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, FMGIDPLAPIC<TSerializedAction, TRoot, TDeps>> IHGCKOACEMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps OHOKKIEJNJH;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xAA6F80", Offset = "0xAA5980", VA = "0x180AA6F80")]
	internal MHEIPCCIOBH(Dictionary<TActionKind, FMGIDPLAPIC<TSerializedAction, TRoot, TDeps>> DHKHNDAGEAH, TDeps GMLBPALEECE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x44715D0", Offset = "0x446FFD0", VA = "0x1844715D0")]
	[AsyncStateMachine(typeof(MHEIPCCIOBH<, , , >.LPDLALJDAHG))]
	public Task<FNBKHJCMJJM<object, AEFDHDNANIN>> JIBJAANJGPB(TRoot GPKGNPPAAHE, TSerializedAction JCBJPJGFKLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class JEBDINHGMFM
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface PACEHAHFELP<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind MOIJEEHIHBB(TSerializedAction BBCPNLGGBMJ);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void DHKOGJENKEH(TRoot GPKGNPPAAHE, TSerializedAction GKKKLNHPKBN);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void KLCEBGHPPNL(TRoot GPKGNPPAAHE, TSerializedAction GKKKLNHPKBN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2B79C40", Offset = "0x2B78640", VA = "0x182B79C40")]
	internal static MHEIPCCIOBH<TActionKind, TSerializedAction, TRoot, TDeps> KHKANEAPNIK<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, FMGIDPLAPIC<TSerializedAction, TRoot, TDeps>> DHKHNDAGEAH, TDeps GMLBPALEECE) where TDeps : PACEHAHFELP<TActionKind, TSerializedAction, TRoot>
	{
		return default(MHEIPCCIOBH<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class JLMPAEOIDGL<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, FMGIDPLAPIC<TSerializedAction, TRoot, TDeps>> BBIDNHMDLNI;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x852830", Offset = "0x851230", VA = "0x180852830")]
	private JLMPAEOIDGL(Dictionary<TActionKind, FMGIDPLAPIC<TSerializedAction, TRoot, TDeps>> DHKHNDAGEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x40F9DC0", Offset = "0x40F87C0", VA = "0x1840F9DC0")]
	public static JLMPAEOIDGL<TActionKind, TSerializedAction, TRoot, TDeps> KHKANEAPNIK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct HLFDPJKFPOO<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, JEBDINHGMFM.PACEHAHFELP<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class OALJOIIDOPB<TPayload, TOk, TErr> : FMGIDPLAPIC<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, AEFDHDNANIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly CBPDPDBOBPB<TActionKind, TSerializedAction, TPayload> PNLLGJIOMGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly IMHJOLHCFBE<TRoot, TPayload, TOk, TErr> GIEKPOGOHJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool DAAJAFIBANI;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x45DE720", Offset = "0x45DD120", VA = "0x1845DE720")]
		public OALJOIIDOPB(CBPDPDBOBPB<TActionKind, TSerializedAction, TPayload> OGHHKIHGLFD, IMHJOLHCFBE<TRoot, TPayload, TOk, TErr> IPDIBLIJEKO, bool KLACFIPDEEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x45CB180", Offset = "0x45C9B80", VA = "0x1845CB180", Slot = "4")]
		public Task<FNBKHJCMJJM<object, AEFDHDNANIN>> JIBJAANJGPB(TDeps GMLBPALEECE, TRoot GPKGNPPAAHE, TSerializedAction JCBJPJGFKLP)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class BDCEPEGJHMK<TPayload, TOk, TErr> : FMGIDPLAPIC<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, AEFDHDNANIN
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct JGCGKCOIBMB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<FNBKHJCMJJM<object?, AEFDHDNANIN>> <>t__builder;

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
			public BDCEPEGJHMK<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private FNBKHJCMJJM<object?, AEFDHDNANIN> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<FNBKHJCMJJM<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x405F090", Offset = "0x405DA90", VA = "0x18405F090", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x405F760", Offset = "0x405E160", VA = "0x18405F760", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly CBPDPDBOBPB<TActionKind, TSerializedAction, TPayload> PNLLGJIOMGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly CKOHIPCHMLG<TRoot, TPayload, TOk, TErr> GIEKPOGOHJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool DAAJAFIBANI;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x45DE720", Offset = "0x45DD120", VA = "0x1845DE720")]
		public BDCEPEGJHMK(CBPDPDBOBPB<TActionKind, TSerializedAction, TPayload> OGHHKIHGLFD, CKOHIPCHMLG<TRoot, TPayload, TOk, TErr> IPDIBLIJEKO, bool KLACFIPDEEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x4DD63B0", Offset = "0x4DD4DB0", VA = "0x184DD63B0", Slot = "4")]
		[AsyncStateMachine(typeof(BDCEPEGJHMK<, , >.JGCGKCOIBMB))]
		public Task<FNBKHJCMJJM<object, AEFDHDNANIN>> JIBJAANJGPB(TDeps GMLBPALEECE, TRoot GPKGNPPAAHE, TSerializedAction JCBJPJGFKLP)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly JLMPAEOIDGL<TActionKind, TSerializedAction, TRoot, TDeps> JFGMNOKNMKK;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x921B20", Offset = "0x920520", VA = "0x180921B20")]
	private HLFDPJKFPOO(JLMPAEOIDGL<TActionKind, TSerializedAction, TRoot, TDeps> EEOBDBMOHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3DE1130", Offset = "0x3DDFB30", VA = "0x183DE1130")]
	public static HLFDPJKFPOO<TActionKind, TSerializedAction, TRoot, TDeps> KHKANEAPNIK()
	{
		return default(HLFDPJKFPOO<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2A69D80", Offset = "0x2A68780", VA = "0x182A69D80")]
	public HLFDPJKFPOO<TActionKind, TSerializedAction, TRoot, TDeps> FCNHMGFOFKJ<TPayload, TOk, TErr>(TActionKind LPPOGGCPKLJ, CBPDPDBOBPB<TActionKind, TSerializedAction, TPayload> OGHHKIHGLFD, IMHJOLHCFBE<TRoot, TPayload, TOk, TErr> IPDIBLIJEKO, bool KLACFIPDEEO = true) where TPayload : notnull where TOk : notnull where TErr : notnull, AEFDHDNANIN
	{
		return default(HLFDPJKFPOO<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2A69D80", Offset = "0x2A68780", VA = "0x182A69D80")]
	public HLFDPJKFPOO<TActionKind, TSerializedAction, TRoot, TDeps> KPJHHKMDFEM<TPayload, TOk, TErr>(TActionKind LPPOGGCPKLJ, CBPDPDBOBPB<TActionKind, TSerializedAction, TPayload> OGHHKIHGLFD, CKOHIPCHMLG<TRoot, TPayload, TOk, TErr> IPDIBLIJEKO, bool KLACFIPDEEO = true) where TPayload : notnull where TOk : notnull where TErr : notnull, AEFDHDNANIN
	{
		return default(HLFDPJKFPOO<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3DE11D0", Offset = "0x3DDFBD0", VA = "0x183DE11D0")]
	public MHEIPCCIOBH<TActionKind, TSerializedAction, TRoot, TDeps> PFONOCNHHEJ(TDeps GMLBPALEECE)
	{
		return default(MHEIPCCIOBH<TActionKind, TSerializedAction, TRoot, TDeps>);
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
