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
		[Cpp2IlInjected.Address(RVA = "0x7BA380", Offset = "0x7B8D80", VA = "0x1807BA380")]
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
		[Cpp2IlInjected.Address(RVA = "0x1D1A970", Offset = "0x1D19370", VA = "0x181D1A970")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7BA560", Offset = "0x7B8F60", VA = "0x1807BA560")]
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
		[Cpp2IlInjected.Address(RVA = "0x7BA5A0", Offset = "0x7B8FA0", VA = "0x1807BA5A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate CKDLCIIHGNB<TActionKind, TPayload> EAOBKEILEBA<TActionKind, TSerializedAction, TPayload>(TSerializedAction HDONONFMJAH);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface FKLDLCMCOCJ<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GAFDMEJHKLE<object, HJEDPJFAAAL>> EMCCCLINDED(TDeps APDKDADOJDA, TRoot AJBLHMMPNNM, TSerializedAction HDONONFMJAH);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class EFCLLNJLGLA<TActionKind, TSerializedAction, TRoot, TDeps> : IKLHIPCKMCK where TDeps : JGIHKNEKPLE.KKEKBEEONEO<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps DBPLOBJIGNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction HHJFPLDOJHO;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3244FA0", Offset = "0x32439A0", VA = "0x183244FA0")]
	public EFCLLNJLGLA([In] TDeps APDKDADOJDA, [In] TSerializedAction HDONONFMJAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3244D70", Offset = "0x3243770", VA = "0x183244D70", Slot = "7")]
	public override string IIILAEFIJID()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct CKDLCIIHGNB<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind PFCDCICNNMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload OEOJEJPDDPJ;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4CB0C30", Offset = "0x4CAF630", VA = "0x184CB0C30")]
	internal CKDLCIIHGNB(TActionKind BCAHIBJADCE, [In] TPayload DNNAMOOCONL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class FDMOFBHKJKI
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x25DEDB0", Offset = "0x25DD7B0", VA = "0x1825DEDB0")]
	public static CKDLCIIHGNB<TActionKind, TPayload> KBFODEGLBLG<TActionKind, TPayload>([In] TActionKind BCAHIBJADCE, [In] TPayload DNNAMOOCONL)
	{
		return default(CKDLCIIHGNB<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<GAFDMEJHKLE<TOk, TErr>> CLIKNOJEDHM<TRoot, TPayload, TOk, TErr>(TRoot AJBLHMMPNNM, TPayload DNNAMOOCONL);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate GAFDMEJHKLE<TOk, TErr> MONOADNLDGC<TRoot, TPayload, TOk, TErr>(TRoot AJBLHMMPNNM, [In] TPayload DNNAMOOCONL);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct KKBFCLENIMH<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : JGIHKNEKPLE.KKEKBEEONEO<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct BMKACIPCNAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<GAFDMEJHKLE<object, HJEDPJFAAAL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public KKBFCLENIMH<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<GAFDMEJHKLE<object, HJEDPJFAAAL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x4814F60", Offset = "0x4813960", VA = "0x184814F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x48153F0", Offset = "0x4813DF0", VA = "0x1848153F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, FKLDLCMCOCJ<TSerializedAction, TRoot, TDeps>> NHIDGJIBPHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps DBPLOBJIGNL;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x85EBA0", Offset = "0x85D5A0", VA = "0x18085EBA0")]
	internal KKBFCLENIMH(Dictionary<TActionKind, FKLDLCMCOCJ<TSerializedAction, TRoot, TDeps>> NOIBDHIGPMF, TDeps APDKDADOJDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3AE9B40", Offset = "0x3AE8540", VA = "0x183AE9B40")]
	[AsyncStateMachine(typeof(KKBFCLENIMH<, , , >.BMKACIPCNAA))]
	public Task<GAFDMEJHKLE<object, HJEDPJFAAAL>> EMCCCLINDED(TRoot AJBLHMMPNNM, TSerializedAction HDONONFMJAH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class JGIHKNEKPLE
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface KKEKBEEONEO<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind DGGMJBHMBGO(TSerializedAction JFFAAHPEFOB);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void IIIIPBCEEOB(TRoot AJBLHMMPNNM, TSerializedAction GMHPLHJININ);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void MJJCPFCLLGM(TRoot AJBLHMMPNNM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x23AC9D0", Offset = "0x23AB3D0", VA = "0x1823AC9D0")]
	internal static KKBFCLENIMH<TActionKind, TSerializedAction, TRoot, TDeps> KBFODEGLBLG<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, FKLDLCMCOCJ<TSerializedAction, TRoot, TDeps>> NOIBDHIGPMF, TDeps APDKDADOJDA) where TDeps : KKEKBEEONEO<TActionKind, TSerializedAction, TRoot>
	{
		return default(KKBFCLENIMH<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class NGHFFHHOELN<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, FKLDLCMCOCJ<TSerializedAction, TRoot, TDeps>> OIFDHKKNAOK;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7904D0", Offset = "0x78EED0", VA = "0x1807904D0")]
	private NGHFFHHOELN(Dictionary<TActionKind, FKLDLCMCOCJ<TSerializedAction, TRoot, TDeps>> NOIBDHIGPMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3E593A0", Offset = "0x3E57DA0", VA = "0x183E593A0")]
	public static NGHFFHHOELN<TActionKind, TSerializedAction, TRoot, TDeps> KBFODEGLBLG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct MHLGHHMGDFF<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, JGIHKNEKPLE.KKEKBEEONEO<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class NHLABFOGMIF<TPayload, TOk, TErr> : FKLDLCMCOCJ<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, HJEDPJFAAAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly EAOBKEILEBA<TActionKind, TSerializedAction, TPayload> IAKKIIBAMPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly MONOADNLDGC<TRoot, TPayload, TOk, TErr> CJLKIDDDFMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool OEPGLMBLMJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly bool EJIAOOBCPBK;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x37385A0", Offset = "0x3736FA0", VA = "0x1837385A0")]
		public NHLABFOGMIF(EAOBKEILEBA<TActionKind, TSerializedAction, TPayload> BPJKFGICFLA, MONOADNLDGC<TRoot, TPayload, TOk, TErr> PEGAGKOCADA, bool BKAFOGDGIMH, bool BEMOIDMNFLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3E5ADB0", Offset = "0x3E597B0", VA = "0x183E5ADB0", Slot = "4")]
		public Task<GAFDMEJHKLE<object, HJEDPJFAAAL>> EMCCCLINDED(TDeps APDKDADOJDA, TRoot AJBLHMMPNNM, TSerializedAction HDONONFMJAH)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class HIBFJHMLBLB<TPayload, TOk, TErr> : FKLDLCMCOCJ<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, HJEDPJFAAAL
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct JJAMEHOHPKO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public AsyncTaskMethodBuilder<GAFDMEJHKLE<object?, HJEDPJFAAAL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public HIBFJHMLBLB<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public TDeps deps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public TRoot root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public TSerializedAction serializedAction;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private GAFDMEJHKLE<object?, HJEDPJFAAAL> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private TaskAwaiter<GAFDMEJHKLE<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x3A30780", Offset = "0x3A2F180", VA = "0x183A30780", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x3A30D30", Offset = "0x3A2F730", VA = "0x183A30D30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly EAOBKEILEBA<TActionKind, TSerializedAction, TPayload> IAKKIIBAMPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly CLIKNOJEDHM<TRoot, TPayload, TOk, TErr> CJLKIDDDFMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly bool OEPGLMBLMJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly bool EJIAOOBCPBK;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x37385A0", Offset = "0x3736FA0", VA = "0x1837385A0")]
		public HIBFJHMLBLB(EAOBKEILEBA<TActionKind, TSerializedAction, TPayload> BPJKFGICFLA, CLIKNOJEDHM<TRoot, TPayload, TOk, TErr> PEGAGKOCADA, bool BKAFOGDGIMH, bool BEMOIDMNFLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3738440", Offset = "0x3736E40", VA = "0x183738440", Slot = "4")]
		[AsyncStateMachine(typeof(HIBFJHMLBLB<, , >.JJAMEHOHPKO))]
		public Task<GAFDMEJHKLE<object, HJEDPJFAAAL>> EMCCCLINDED(TDeps APDKDADOJDA, TRoot AJBLHMMPNNM, TSerializedAction HDONONFMJAH)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly NGHFFHHOELN<TActionKind, TSerializedAction, TRoot, TDeps> GJLKFMHOHOI;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8C16C0", Offset = "0x8C00C0", VA = "0x1808C16C0")]
	private MHLGHHMGDFF(NGHFFHHOELN<TActionKind, TSerializedAction, TRoot, TDeps> OBAHLGOPPIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3DD96A0", Offset = "0x3DD80A0", VA = "0x183DD96A0")]
	public static MHLGHHMGDFF<TActionKind, TSerializedAction, TRoot, TDeps> KBFODEGLBLG()
	{
		return default(MHLGHHMGDFF<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x21C86E0", Offset = "0x21C70E0", VA = "0x1821C86E0")]
	public MHLGHHMGDFF<TActionKind, TSerializedAction, TRoot, TDeps> OLJNJKEHGNL<TPayload, TOk, TErr>(TActionKind BCAHIBJADCE, EAOBKEILEBA<TActionKind, TSerializedAction, TPayload> BPJKFGICFLA, MONOADNLDGC<TRoot, TPayload, TOk, TErr> PEGAGKOCADA, bool BKAFOGDGIMH = true, bool BEMOIDMNFLP = true) where TPayload : notnull where TOk : notnull where TErr : notnull, HJEDPJFAAAL
	{
		return default(MHLGHHMGDFF<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x21C86E0", Offset = "0x21C70E0", VA = "0x1821C86E0")]
	public MHLGHHMGDFF<TActionKind, TSerializedAction, TRoot, TDeps> KKIJONCBJGG<TPayload, TOk, TErr>(TActionKind BCAHIBJADCE, EAOBKEILEBA<TActionKind, TSerializedAction, TPayload> BPJKFGICFLA, CLIKNOJEDHM<TRoot, TPayload, TOk, TErr> PEGAGKOCADA, bool BKAFOGDGIMH = true, bool BEMOIDMNFLP = true) where TPayload : notnull where TOk : notnull where TErr : notnull, HJEDPJFAAAL
	{
		return default(MHLGHHMGDFF<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3DD95F0", Offset = "0x3DD7FF0", VA = "0x183DD95F0")]
	public KKBFCLENIMH<TActionKind, TSerializedAction, TRoot, TDeps> JJJCOCMBCDM(TDeps APDKDADOJDA)
	{
		return default(KKBFCLENIMH<TActionKind, TSerializedAction, TRoot, TDeps>);
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
