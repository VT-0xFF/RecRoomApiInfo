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
		[Cpp2IlInjected.Address(RVA = "0xA2B980", Offset = "0xA2AB80", VA = "0x180A2B980")]
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
		[Cpp2IlInjected.Address(RVA = "0x28C25F0", Offset = "0x28C17F0", VA = "0x1828C25F0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA2C560", Offset = "0xA2B760", VA = "0x180A2C560")]
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
		[Cpp2IlInjected.Address(RVA = "0xA2C5A0", Offset = "0xA2B7A0", VA = "0x180A2C5A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate HOGKNFAOCHC<TActionKind, TPayload> NLFONDOBPEE<TActionKind, TSerializedAction, TPayload>(TSerializedAction PLGMGPOBGFN);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface AHOCMOEBNBP<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<DJNAMIFBMIO<object, FMHHFFBAGLO>> PLNHJBMALJO(TDeps AHPCPGHNHGP, TRoot OLEJNEHCCLF, TSerializedAction PLGMGPOBGFN);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class FEAMFIACFGO<TActionKind, TSerializedAction, TRoot, TDeps> : DMCEODOALNN where TDeps : GJODNBMOBPH.HGDHLKBMDHF<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps EMPPIJCDCNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction AKEPKLJDOLG;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4B2F4D0", Offset = "0x4B2E6D0", VA = "0x184B2F4D0")]
	public FEAMFIACFGO([In] TDeps AHPCPGHNHGP, [In] TSerializedAction PLGMGPOBGFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4B2F2B0", Offset = "0x4B2E4B0", VA = "0x184B2F2B0", Slot = "7")]
	public override string AHCNILBBCDH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct HOGKNFAOCHC<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind FHPLAGBICCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload OCJJPAKBLMD;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4CEAFB0", Offset = "0x4CEA1B0", VA = "0x184CEAFB0")]
	internal HOGKNFAOCHC(TActionKind GIGFADIBOCJ, [In] TPayload EKFBEBELGHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class ADAFODCNDJN
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2F93B40", Offset = "0x2F92D40", VA = "0x182F93B40")]
	public static HOGKNFAOCHC<TActionKind, TPayload> FAHGDJGLLGD<TActionKind, TPayload>([In] TActionKind GIGFADIBOCJ, [In] TPayload EKFBEBELGHJ)
	{
		return default(HOGKNFAOCHC<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<DJNAMIFBMIO<TOk, TErr>> BJIGFIMKDAF<TRoot, TPayload, TOk, TErr>(TRoot OLEJNEHCCLF, TPayload EKFBEBELGHJ);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate DJNAMIFBMIO<TOk, TErr> MINFGKOGIEB<TRoot, TPayload, TOk, TErr>(TRoot OLEJNEHCCLF, [In] TPayload EKFBEBELGHJ);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct MEJOLCIBPFO<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : GJODNBMOBPH.HGDHLKBMDHF<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct AFLDIAFJPJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<DJNAMIFBMIO<object?, FMHHFFBAGLO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public MEJOLCIBPFO<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<DJNAMIFBMIO<object, FMHHFFBAGLO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x4E4BB90", Offset = "0x4E4AD90", VA = "0x184E4BB90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4E4C070", Offset = "0x4E4B270", VA = "0x184E4C070", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, AHOCMOEBNBP<TSerializedAction, TRoot, TDeps>> HNDFODHKNGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps EMPPIJCDCNI;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xB268B0", Offset = "0xB25AB0", VA = "0x180B268B0")]
	internal MEJOLCIBPFO(Dictionary<TActionKind, AHOCMOEBNBP<TSerializedAction, TRoot, TDeps>> LKKEKKLOJMD, TDeps AHPCPGHNHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x53FF800", Offset = "0x53FEA00", VA = "0x1853FF800")]
	[AsyncStateMachine(typeof(MEJOLCIBPFO<, , , >.AFLDIAFJPJN))]
	public Task<DJNAMIFBMIO<object, FMHHFFBAGLO>> PLNHJBMALJO(TRoot OLEJNEHCCLF, TSerializedAction PLGMGPOBGFN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class GJODNBMOBPH
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface HGDHLKBMDHF<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind CPHMIJANEGJ(TSerializedAction IPOCHJJJBCM);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void EGJEFEEPDJM(TRoot OLEJNEHCCLF, TSerializedAction CJLPDLONOLK);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void BHONGCDMFIC(TRoot OLEJNEHCCLF, TSerializedAction CJLPDLONOLK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3789CA0", Offset = "0x3788EA0", VA = "0x183789CA0")]
	internal static MEJOLCIBPFO<TActionKind, TSerializedAction, TRoot, TDeps> FAHGDJGLLGD<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, AHOCMOEBNBP<TSerializedAction, TRoot, TDeps>> LKKEKKLOJMD, TDeps AHPCPGHNHGP) where TDeps : HGDHLKBMDHF<TActionKind, TSerializedAction, TRoot>
	{
		return default(MEJOLCIBPFO<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class PAMHBLEPHLE<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, AHOCMOEBNBP<TSerializedAction, TRoot, TDeps>> CFPLGICNHME;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0xA0F6B0", Offset = "0xA0E8B0", VA = "0x180A0F6B0")]
	private PAMHBLEPHLE(Dictionary<TActionKind, AHOCMOEBNBP<TSerializedAction, TRoot, TDeps>> LKKEKKLOJMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x56DF980", Offset = "0x56DEB80", VA = "0x1856DF980")]
	public static PAMHBLEPHLE<TActionKind, TSerializedAction, TRoot, TDeps> FAHGDJGLLGD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct DECNLGPMLNC<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, GJODNBMOBPH.HGDHLKBMDHF<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class HNMPNIDENEE<TPayload, TOk, TErr> : AHOCMOEBNBP<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, FMHHFFBAGLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly NLFONDOBPEE<TActionKind, TSerializedAction, TPayload> MAPPGMKBAMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly MINFGKOGIEB<TRoot, TPayload, TOk, TErr> OEEMJECFCMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool CPLHAEOJMIK;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1AA05C0", Offset = "0x1A9F7C0", VA = "0x181AA05C0")]
		public HNMPNIDENEE(NLFONDOBPEE<TActionKind, TSerializedAction, TPayload> NCJNBCJBPCE, MINFGKOGIEB<TRoot, TPayload, TOk, TErr> ECPGFJGJAIE, bool MGCPOBBADJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x4CD3760", Offset = "0x4CD2960", VA = "0x184CD3760", Slot = "4")]
		public Task<DJNAMIFBMIO<object, FMHHFFBAGLO>> PLNHJBMALJO(TDeps AHPCPGHNHGP, TRoot OLEJNEHCCLF, TSerializedAction PLGMGPOBGFN)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class HJPMNAAGKCN<TPayload, TOk, TErr> : AHOCMOEBNBP<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, FMHHFFBAGLO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct PBLINNFIOEJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<DJNAMIFBMIO<object?, FMHHFFBAGLO>> <>t__builder;

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
			public HJPMNAAGKCN<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private DJNAMIFBMIO<object?, FMHHFFBAGLO> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<DJNAMIFBMIO<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x56E13C0", Offset = "0x56E05C0", VA = "0x1856E13C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x56E2FB0", Offset = "0x56E21B0", VA = "0x1856E2FB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly NLFONDOBPEE<TActionKind, TSerializedAction, TPayload> MAPPGMKBAMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly BJIGFIMKDAF<TRoot, TPayload, TOk, TErr> OEEMJECFCMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool CPLHAEOJMIK;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1AA05C0", Offset = "0x1A9F7C0", VA = "0x181AA05C0")]
		public HJPMNAAGKCN(NLFONDOBPEE<TActionKind, TSerializedAction, TPayload> NCJNBCJBPCE, BJIGFIMKDAF<TRoot, TPayload, TOk, TErr> ECPGFJGJAIE, bool MGCPOBBADJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x4CADC90", Offset = "0x4CACE90", VA = "0x184CADC90", Slot = "4")]
		[AsyncStateMachine(typeof(HJPMNAAGKCN<, , >.PBLINNFIOEJ))]
		public Task<DJNAMIFBMIO<object, FMHHFFBAGLO>> PLNHJBMALJO(TDeps AHPCPGHNHGP, TRoot OLEJNEHCCLF, TSerializedAction PLGMGPOBGFN)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly PAMHBLEPHLE<TActionKind, TSerializedAction, TRoot, TDeps> FCHBBBIIPEP;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xD91890", Offset = "0xD90A90", VA = "0x180D91890")]
	private DECNLGPMLNC(PAMHBLEPHLE<TActionKind, TSerializedAction, TRoot, TDeps> CAIGHLKIDBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4206480", Offset = "0x4205680", VA = "0x184206480")]
	public static DECNLGPMLNC<TActionKind, TSerializedAction, TRoot, TDeps> FAHGDJGLLGD()
	{
		return default(DECNLGPMLNC<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3B912E0", Offset = "0x3B904E0", VA = "0x183B912E0")]
	public DECNLGPMLNC<TActionKind, TSerializedAction, TRoot, TDeps> BLGMMJJJMGG<TPayload, TOk, TErr>(TActionKind GIGFADIBOCJ, NLFONDOBPEE<TActionKind, TSerializedAction, TPayload> NCJNBCJBPCE, MINFGKOGIEB<TRoot, TPayload, TOk, TErr> ECPGFJGJAIE, bool MGCPOBBADJN = true) where TPayload : notnull where TOk : notnull where TErr : notnull, FMHHFFBAGLO
	{
		return default(DECNLGPMLNC<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3B912E0", Offset = "0x3B904E0", VA = "0x183B912E0")]
	public DECNLGPMLNC<TActionKind, TSerializedAction, TRoot, TDeps> GGFLJMHCIGO<TPayload, TOk, TErr>(TActionKind GIGFADIBOCJ, NLFONDOBPEE<TActionKind, TSerializedAction, TPayload> NCJNBCJBPCE, BJIGFIMKDAF<TRoot, TPayload, TOk, TErr> ECPGFJGJAIE, bool MGCPOBBADJN = true) where TPayload : notnull where TOk : notnull where TErr : notnull, FMHHFFBAGLO
	{
		return default(DECNLGPMLNC<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4206510", Offset = "0x4205710", VA = "0x184206510")]
	public MEJOLCIBPFO<TActionKind, TSerializedAction, TRoot, TDeps> PFMOJGOAPGL(TDeps AHPCPGHNHGP)
	{
		return default(MEJOLCIBPFO<TActionKind, TSerializedAction, TRoot, TDeps>);
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
