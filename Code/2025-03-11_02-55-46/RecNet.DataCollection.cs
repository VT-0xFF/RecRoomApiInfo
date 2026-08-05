using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Logging.Attributes;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x98FE40", Offset = "0x98F240", VA = "0x18098FE40")]
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
		[Cpp2IlInjected.Address(RVA = "0x6BB8DC0", Offset = "0x6BB81C0", VA = "0x186BB8DC0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x990590", Offset = "0x98F990", VA = "0x180990590")]
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
		[Cpp2IlInjected.Address(RVA = "0x9905D0", Offset = "0x98F9D0", VA = "0x1809905D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _LogRegistration.RecNet_DataCollection
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[RecRoom.Logging.Attributes.Preserve]
	[CompilerGenerated]
	public class LogRegistrationIndex : KENHJELJHDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6BB7A50", Offset = "0x6BB6E50", VA = "0x186BB7A50", Slot = "4")]
		public override void ICLMLJMBJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x98FE40", Offset = "0x98F240", VA = "0x18098FE40")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecNet_DataCollection
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6BBAFD0", Offset = "0x6BBA3D0", VA = "0x186BBAFD0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2491CF0", Offset = "0x24910F0", VA = "0x182491CF0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface ANMMKGGJGKI
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyDictionary<string, object> AJMGCLEGPPB();
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class OGCLBMIEBAK
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6BB91A0", Offset = "0x6BB85A0", VA = "0x186BB91A0")]
	public static void DHOFELPHFKA(this ADADAAKFLFK.LNFKJLAPIOC PGGGKPFJHJB, string LNHOMJNFFOK, string CMBIACICJIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6BB9310", Offset = "0x6BB8710", VA = "0x186BB9310")]
	public static void DHOFELPHFKA(this ADADAAKFLFK.LNFKJLAPIOC PGGGKPFJHJB, string LNHOMJNFFOK, bool CMBIACICJIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6BB9210", Offset = "0x6BB8610", VA = "0x186BB9210")]
	public static void DHOFELPHFKA(this ADADAAKFLFK.LNFKJLAPIOC PGGGKPFJHJB, string LNHOMJNFFOK, float PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6BB8E40", Offset = "0x6BB8240", VA = "0x186BB8E40")]
	public static void DHOFELPHFKA(this ADADAAKFLFK.LNFKJLAPIOC PGGGKPFJHJB, string LNHOMJNFFOK, CMHKGLEPGLE CMBIACICJIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class ADADAAKFLFK
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface MBJMNCFNNPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		LNFKJLAPIOC OPILNEGBPCG(Guid AKOHGADPNOK, string MKFNLLBNHAE, [Optional] string GMMHAKBAPEN, [Optional] long? LGIOKNFAAIG, [Optional] string FLNEHJGCAIC, [Optional] string OOPBCMFJLDA);
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class AHMHEHFNKMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6BB19C0", Offset = "0x6BB0DC0", VA = "0x186BB19C0")]
		public static LNFKJLAPIOC NEHKLHKPJBL(Guid AKOHGADPNOK, string MKFNLLBNHAE, string GMMHAKBAPEN, [Optional] long? LGIOKNFAAIG, [Optional] string FLNEHJGCAIC, [Optional] string OOPBCMFJLDA)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class LNFKJLAPIOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		protected NNHJOKBDLFL CDDCIHICHEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly IDictionary<string, IDictionary<string, object>> PJMFMJCBKBE;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool MOKPNHIOPDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6BB7670", Offset = "0x6BB6A70", VA = "0x186BB7670")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public string NAFELINPKFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xF6CBB0", Offset = "0xF6BFB0", VA = "0x180F6CBB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6BB79B0", Offset = "0x6BB6DB0", VA = "0x186BB79B0")]
		public LNFKJLAPIOC(NNHJOKBDLFL CDDCIHICHEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6BB78D0", Offset = "0x6BB6CD0", VA = "0x186BB78D0")]
		public LNFKJLAPIOC LCPEPFIDDBK(string MFGHKKFEKII, string PEBNJNGMMHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3B566F0", Offset = "0x3B55AF0", VA = "0x183B566F0")]
		public LNFKJLAPIOC LCPEPFIDDBK<T>(string MFGHKKFEKII, T PEBNJNGMMHE) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6BB75F0", Offset = "0x6BB69F0", VA = "0x186BB75F0")]
		public LNFKJLAPIOC GJPEOGNDHCP(string MFGHKKFEKII, object PEBNJNGMMHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3B56660", Offset = "0x3B55A60", VA = "0x183B56660")]
		public LNFKJLAPIOC GJBFEJOGPHI<T>(string MFGHKKFEKII, T? PEBNJNGMMHE) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6BB7560", Offset = "0x6BB6960", VA = "0x186BB7560")]
		public LNFKJLAPIOC GJBFEJOGPHI(string MFGHKKFEKII, string PEBNJNGMMHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6BB7790", Offset = "0x6BB6B90", VA = "0x186BB7790")]
		public LNFKJLAPIOC JCMHBHIMCFM(string HLNLOHKFOCD, string MCNLCGLNHHO, object MJFOKKFMONL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6BB76B0", Offset = "0x6BB6AB0", VA = "0x186BB76B0")]
		public LNFKJLAPIOC JCMHBHIMCFM(string HLNLOHKFOCD, IDictionary<string, object> HEAMOKBMKHO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6BB7950", Offset = "0x6BB6D50", VA = "0x186BB7950")]
		private static IDictionary<string, object> NMONDOICJMJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6BB72B0", Offset = "0x6BB66B0", VA = "0x186BB72B0")]
		public void FAIHCABLFPF(bool PNBBFCECEDJ, string CBBGJLECLCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6BB71B0", Offset = "0x6BB65B0", VA = "0x186BB71B0")]
		public Task DOAKJBGDPNJ([Optional] CancellationToken MLAPMBKLAOF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x25A6410", Offset = "0x25A5810", VA = "0x1825A6410", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class NNHJOKBDLFL
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private struct KLFKHBKHLPF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public NNHJOKBDLFL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6BB4E10", Offset = "0x6BB4210", VA = "0x186BB4E10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6BB5260", Offset = "0x6BB4660", VA = "0x186BB5260", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static Action<NNHJOKBDLFL> LIFJKKNNJAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly string KKABDGGFDJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly Dictionary<string, object> JINAACGDPMA;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string NAFELINPKFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6BB8A80", Offset = "0x6BB7E80", VA = "0x186BB8A80")]
		private NNHJOKBDLFL(string KKABDGGFDJF, int CFMOAKJJMGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6BB15B0", Offset = "0x6BB09B0", VA = "0x186BB15B0")]
		public static LNFKJLAPIOC GEEFBNOOFMP(string KKABDGGFDJF, int CFMOAKJJMGO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6BB8860", Offset = "0x6BB7C60", VA = "0x186BB8860")]
		[AsyncStateMachine(typeof(KLFKHBKHLPF))]
		public Task DOAKJBGDPNJ([Optional] CancellationToken MLAPMBKLAOF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6BB8A10", Offset = "0x6BB7E10", VA = "0x186BB8A10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3275220", Offset = "0x3274620", VA = "0x183275220")]
		internal void KLKOOCEHENM<T>(string MFGHKKFEKII, T PEBNJNGMMHE) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6BB8950", Offset = "0x6BB7D50", VA = "0x186BB8950")]
		internal void HLGBINBMEEF(string MFGHKKFEKII, object PEBNJNGMMHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6BB89B0", Offset = "0x6BB7DB0", VA = "0x186BB89B0")]
		internal void KLKOOCEHENM(string MFGHKKFEKII, string PEBNJNGMMHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3B592C0", Offset = "0x3B586C0", VA = "0x183B592C0")]
		private void DABLPJHJFOJ<T>(string MFGHKKFEKII, T PEBNJNGMMHE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct EIHNBJCGMBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly string LPOPPLEJPHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly long? CIKKOOKDCFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly short? APGHMDLHJNL;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6BB2A90", Offset = "0x6BB1E90", VA = "0x186BB2A90")]
		public EIHNBJCGMBD(string BDHBPHFGJCI, [Optional] long? LFNEDMLHPHM, [Optional] short? KPCPNIOPDDK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct LBNHLLOKOJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly int MIIMHBCNCDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public readonly string PBFINIDMLHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly short FBGFNJAJMOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public readonly string BPKGLAOGEOH;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6BB52C0", Offset = "0x6BB46C0", VA = "0x186BB52C0")]
		public LBNHLLOKOJP(int IINLDADFIIP, string KCCPNEKJKDJ, short PEPJAKFBMLD, string DPKMCDLEHNC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class FCELAHOHKPB : HPAMPJFDNOD<HPGJEHMOEJO, LBNHLLOKOJP, EIHNBJCGMBD>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private string KCCPNEKJKDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private short PEPJAKFBMLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private string DPKMCDLEHNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private Dictionary<short, int> ANKAMMMICMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private int IBPHJCLCBDP;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6BB46E0", Offset = "0x6BB3AE0", VA = "0x186BB46E0")]
		public FCELAHOHKPB(string HNGGGMNMMNN, Guid HAGKKJFPLEG, long KBMKGCENPKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6BB43F0", Offset = "0x6BB37F0", VA = "0x186BB43F0", Slot = "4")]
		public override void MPJHJLJNGBO(LBNHLLOKOJP CGHEOJHGFBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6BB4310", Offset = "0x6BB3710", VA = "0x186BB4310")]
		public void EEGILFBCKDN(short PEPJAKFBMLD, bool NCMDIAHMPLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x44D91F0", Offset = "0x44D85F0", VA = "0x1844D91F0")]
		public void POGNMBMNCAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9650C0", Offset = "0x9644C0", VA = "0x1809650C0")]
		public void GGCJEMFADIL(string KEMELCAGINH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6BB3280", Offset = "0x6BB2680", VA = "0x186BB3280", Slot = "5")]
		public override void AHNIOPOBEPJ(bool EAEMIAHLGKH, EIHNBJCGMBD MBANCKLBCMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6BB4060", Offset = "0x6BB3460", VA = "0x186BB4060", Slot = "6")]
		public override EKGEHFAKAGC BMGFNLEPODK(HPGJEHMOEJO MCENIAGGCGP, int FFCBHHABFJN, string DNLMCMLJLID)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class BFDMKEDCNIC : EKGEHFAKAGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private string KCCPNEKJKDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly short PEPJAKFBMLD;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6BB1D80", Offset = "0x6BB1180", VA = "0x186BB1D80")]
		public BFDMKEDCNIC(long KIBDOOPIGIB, int IINLDADFIIP, string GMMHAKBAPEN, long KBMKGCENPKE, int BGJGJNPCBOO, string FLNEHJGCAIC, short PEPJAKFBMLD, string KCCPNEKJKDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6BB1BD0", Offset = "0x6BB0FD0", VA = "0x186BB1BD0")]
		public void NENDODEGDKG(int IINLDADFIIP, string KCCPNEKJKDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6BB1C50", Offset = "0x6BB1050", VA = "0x186BB1C50", Slot = "5")]
		public override LNFKJLAPIOC OPILNEGBPCG(Guid AKOHGADPNOK, string MKFNLLBNHAE, [Optional] string GMMHAKBAPEN, [Optional] long? LGIOKNFAAIG, [Optional] string FLNEHJGCAIC, [Optional] string OOPBCMFJLDA)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class PALMDDCHNOL
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class DFNAAECLCNB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public float nextEventSendTime;

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
			public DFNAAECLCNB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6BB1E70", Offset = "0x6BB1270", VA = "0x186BB1E70")]
			internal bool KINFFHLALJJ()
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private struct MELDIGDNJEH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			private DFNAAECLCNB <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private TimeSpan <delayPollingInterval>5__2;

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6BB7AE0", Offset = "0x6BB6EE0", VA = "0x186BB7AE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6BB87A0", Offset = "0x6BB7BA0", VA = "0x186BB87A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private struct DPOOFAOPKEB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public bool isForcedEvent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6BB24B0", Offset = "0x6BB18B0", VA = "0x186BB24B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6BB2A30", Offset = "0x6BB1E30", VA = "0x186BB2A30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public static readonly float NGLFEADDHOF;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static PAJFLGMBLIE OFOFLKGFIFD;

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static CancellationTokenSource BEDFDLIFDHM;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static bool IPCNJCBBFEE;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private static int HCEPCPBKOAM;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static readonly EIILHECILIH<LNFKJLAPIOC, bool> KCBHPDDMGCF;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static NAHBIEFBNLK<LNFKJLAPIOC, bool> KPNHGKOCEOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6BB9E90", Offset = "0x6BB9290", VA = "0x186BB9E90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private static bool PBHLDDHJPGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6BB94D0", Offset = "0x6BB88D0", VA = "0x186BB94D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x6BB99A0", Offset = "0x6BB8DA0", VA = "0x186BB99A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private static bool MBFJDDIKAJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6BBA4A0", Offset = "0x6BB98A0", VA = "0x186BBA4A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6BB93A0", Offset = "0x6BB87A0", VA = "0x186BB93A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private static float DOGIMEJAKLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6BB9520", Offset = "0x6BB8920", VA = "0x186BB9520")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6BBA0E0", Offset = "0x6BB94E0", VA = "0x186BBA0E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6BBA380", Offset = "0x6BB9780", VA = "0x186BBA380")]
		[BOHPIAAADDL.CCCKKBFCOMP]
		internal static void OPOBACAKBOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6BBA140", Offset = "0x6BB9540", VA = "0x186BBA140")]
		internal static void OBBALIPJEND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6BB9A00", Offset = "0x6BB8E00", VA = "0x186BB9A00")]
		internal static void FIKJJGGPENN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6BBA320", Offset = "0x6BB9720", VA = "0x186BBA320")]
		internal static void OJBBGKPKHDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6BB9FC0", Offset = "0x6BB93C0", VA = "0x186BB9FC0")]
		public static void ICHACFADMPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6BB9570", Offset = "0x6BB8970", VA = "0x186BB9570")]
		private static void DNIIDDLDOMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6BB9BB0", Offset = "0x6BB8FB0", VA = "0x186BB9BB0")]
		private static void FOFGMMNLHDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6BB9400", Offset = "0x6BB8800", VA = "0x186BB9400")]
		[AsyncStateMachine(typeof(MELDIGDNJEH))]
		private static Task BDMHHJEJBFI(CancellationToken MLAPMBKLAOF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6BBA010", Offset = "0x6BB9410", VA = "0x186BBA010")]
		private static void KLKKLIAPNLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6BB9EE0", Offset = "0x6BB92E0", VA = "0x186BB9EE0")]
		[AsyncStateMachine(typeof(DPOOFAOPKEB))]
		private static Task IBHIHAOCGNP(bool FCEBNGFCLME, [Optional] CancellationToken MLAPMBKLAOF)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class AKBHMEOBCOO<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class PGLOBLFLDDN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public AKBHMEOBCOO<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
			public PGLOBLFLDDN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x5096FB0", Offset = "0x50963B0", VA = "0x185096FB0")]
			internal object PGCPNOBAMEA()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class MLEOGEMPLNJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public AKBHMEOBCOO<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
			public MLEOGEMPLNJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x4E0B700", Offset = "0x4E0AB00", VA = "0x184E0B700")]
			internal object ANNMLBCHGFP()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class GMGOGCMDGMA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public AKBHMEOBCOO<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
			public GMGOGCMDGMA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x4679610", Offset = "0x4678A10", VA = "0x184679610")]
			internal object GPIANPGGHNB()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class JBFMODNAMAM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public AKBHMEOBCOO<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
			public JBFMODNAMAM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x49F55B0", Offset = "0x49F49B0", VA = "0x1849F55B0")]
			internal object KJIBHONDIEH()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class CAHLIKIJADE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public AKBHMEOBCOO<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
			public CAHLIKIJADE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x6064770", Offset = "0x6063B70", VA = "0x186064770")]
			internal object CPPNPADJADK()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class NEEAOBJIDDG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public AKBHMEOBCOO<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
			public NEEAOBJIDDG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x4E76B20", Offset = "0x4E75F20", VA = "0x184E76B20")]
			internal object OMLFGOHOJEA()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private const float EMOHBDIKDAF = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly Guid AKOHGADPNOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly string FLNEHJGCAIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly string KEEMLJDEDKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private string DCFBCMAEIJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private string OOPBCMFJLDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private string DAOMMDAGNJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private string OCNFPIIBCGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private string EPEJAIMDEMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private string IMGPPIPEAKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private string COEMJEEFEJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private string KAFIFCHGCBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private string MCPFIHMIDPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Guid? OOHEMBIMBEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private (int, int)? FCEBFHMONFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly HashSet<T> IHBGJIDBAOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly Dictionary<(T, int), string> DKEBACHNKMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly Dictionary<(T, int), float> AHPMHKPDBIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly Dictionary<T, string> ABHIILBKCKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly Dictionary<T, string> IDLFKIEFEGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly Dictionary<T, string[]> PDOIPOHHFEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private string IBNAHIBBENA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private bool LGLEPDOJKEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private Task AEKHKELDNJG;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x47362F0", Offset = "0x47356F0", VA = "0x1847362F0")]
		public AKBHMEOBCOO(Guid AKOHGADPNOK, string KEEMLJDEDKI, string FLNEHJGCAIC, string DCFBCMAEIJM, [Optional] string OOPBCMFJLDA, [Optional] string DAOMMDAGNJD, [Optional] string OCNFPIIBCGH, [Optional] string COEMJEEFEJM, [Optional] string IBNAHIBBENA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x96A710", Offset = "0x969B10", VA = "0x18096A710")]
		public void NMNEEBGDOEG(string OOPBCMFJLDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x969460", Offset = "0x968860", VA = "0x180969460")]
		public void ALDDKFOHFBP(string DCFBCMAEIJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xC62300", Offset = "0xC61700", VA = "0x180C62300")]
		public void PLLLPHGEDKK(string IBNAHIBBENA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x9642D0", Offset = "0x9636D0", VA = "0x1809642D0")]
		public void PDFEDBPKFDN(string EPEJAIMDEMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9650C0", Offset = "0x9644C0", VA = "0x1809650C0")]
		public void DEKGAGFOLPD(string KAFIFCHGCBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9650E0", Offset = "0x9644E0", VA = "0x1809650E0")]
		public void HHGNGCBECHF(string MCPFIHMIDPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x4733650", Offset = "0x4732A50", VA = "0x184733650")]
		public void GLKFPNNBOAM(Guid? AKOHGADPNOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x4734020", Offset = "0x4733420", VA = "0x184734020")]
		public void IJJOBOGJDOJ((int, int)? FCEBFHMONFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9642E0", Offset = "0x9636E0", VA = "0x1809642E0")]
		public void LEJHPJFMJEM(string IMGPPIPEAKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x4733E90", Offset = "0x4733290", VA = "0x184733E90")]
		public void IDJGILHBAMG(T LGIOKNFAAIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x4734370", Offset = "0x4733770", VA = "0x184734370")]
		public void IJPIMELKOGA(T LGIOKNFAAIG, int MPMCGBCKOIE, float NGAJLIGHCDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x47303E0", Offset = "0x472F7E0", VA = "0x1847303E0")]
		public void DCJJEMCIPEF(T LGIOKNFAAIG, int MPMCGBCKOIE, string JMKLMMECDDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x4735FA0", Offset = "0x47353A0", VA = "0x184735FA0")]
		public void OHBLNLMBFON(T LGIOKNFAAIG, string KJIKGJFNOOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x4733820", Offset = "0x4732C20", VA = "0x184733820")]
		public void ICCENLHHPAA(T LGIOKNFAAIG, string MFPOLAHPLMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x4733140", Offset = "0x4732540", VA = "0x184733140")]
		public void FCPMDEHBKHG(T LGIOKNFAAIG, string[] AIDFAEIFPBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x4732050", Offset = "0x4731450", VA = "0x184732050")]
		public Task DOAKJBGDPNJ(bool JLJMBNIAGMB = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x4734BA0", Offset = "0x4733FA0", VA = "0x184734BA0")]
		private (IEnumerable<T>, string) NENJKHCJAPG()
		{
			return default((IEnumerable<T>, string));
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x472F2E0", Offset = "0x472E6E0", VA = "0x18472F2E0")]
		public static LNFKJLAPIOC APBFEEHJIHH(Guid AKOHGADPNOK, string KEEMLJDEDKI, T LGIOKNFAAIG, string FLNEHJGCAIC, string BNOBOCBIGAK, string OOPBCMFJLDA, int? FFCBHHABFJN, [Optional] string MMICGDNIGHM, [Optional] string KJIKGJFNOOK, [Optional] int? FLFHMKNNKGC, [Optional] Guid? OOHEMBIMBEL, [Optional] string IBNAHIBBENA, [Optional] string GMMHAKBAPEN, [Optional] (int, int)? FCEBFHMONFK, [Optional] string LEOCBFHJGAH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x47334A0", Offset = "0x47328A0", VA = "0x1847334A0")]
		[CompilerGenerated]
		private string GIGMEOIIPDN(T NNKBGKICBEC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x4734B10", Offset = "0x4733F10", VA = "0x184734B10")]
		[CompilerGenerated]
		private string JIAMAIEOEPF(T NNKBGKICBEC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x4732D30", Offset = "0x4732130", VA = "0x184732D30")]
		[CompilerGenerated]
		private string EGMKKLKAKAG(T NNKBGKICBEC)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public abstract class HPAMPJFDNOD<TItem, TListSessionStartParams, TListSessionLogParams>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		protected readonly string HNGGGMNMMNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		protected readonly Guid HAGKKJFPLEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		protected readonly long KBMKGCENPKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		protected int IINLDADFIIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		protected int EPAMPJJEAOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		protected DateTime FCGGCKICAEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		protected bool NIIFJFBJCOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		protected Dictionary<long, EKGEHFAKAGC> AAHBHCFGGGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		protected bool CEECFLIFOKJ;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool IAOPLPEJDKP
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xB07F10", Offset = "0xB07310", VA = "0x180B07F10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool OKKMPCGCNLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xB6A800", Offset = "0xB69C00", VA = "0x180B6A800")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x475C810", Offset = "0x475BC10", VA = "0x18475C810")]
		public HPAMPJFDNOD(string HNGGGMNMMNN, Guid HAGKKJFPLEG, long KBMKGCENPKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void MPJHJLJNGBO(TListSessionStartParams CGHEOJHGFBO);

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x475C660", Offset = "0x475BA60", VA = "0x18475C660")]
		public void MECKDJJDDMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void AHNIOPOBEPJ(bool EAEMIAHLGKH, TListSessionLogParams MBANCKLBCMM);

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x475C5C0", Offset = "0x475B9C0", VA = "0x18475C5C0")]
		public void ICOGNJNPHOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x475C740", Offset = "0x475BB40", VA = "0x18475C740")]
		public void PONKICODLHK(long KIBDOOPIGIB, int FFCBHHABFJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x475C4A0", Offset = "0x475B8A0", VA = "0x18475C4A0")]
		public void APPPBGFPPHH(long KIBDOOPIGIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract EKGEHFAKAGC BMGFNLEPODK(TItem BBKCHLGPMMO, int FFCBHHABFJN, string DNLMCMLJLID);
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class EKGEHFAKAGC : MBJMNCFNNPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private int IINLDADFIIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private long KIBDOOPIGIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private long KBMKGCENPKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private readonly string NCIKNLNLELJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly string MDJIHKJKCKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly int BGJGJNPCBOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private DateTime DBNDHDOFEBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private double CPHOMLEOLMG;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool CIKJPHDDLOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xD324F0", Offset = "0xD318F0", VA = "0x180D324F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xD32980", Offset = "0xD31D80", VA = "0x180D32980")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6BB31B0", Offset = "0x6BB25B0", VA = "0x186BB31B0")]
		public EKGEHFAKAGC(long KIBDOOPIGIB, int IINLDADFIIP, string GMMHAKBAPEN, long KBMKGCENPKE, int BGJGJNPCBOO, [Optional] string FLNEHJGCAIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6BB2AD0", Offset = "0x6BB1ED0", VA = "0x186BB2AD0")]
		public void GKINLOCIAEC(int IINLDADFIIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6BB2CB0", Offset = "0x6BB20B0", VA = "0x186BB2CB0")]
		public void NKBCEJIBELG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6BB2BA0", Offset = "0x6BB1FA0", VA = "0x186BB2BA0")]
		public void MFOJCLFJMHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6BB2B40", Offset = "0x6BB1F40", VA = "0x186BB2B40")]
		private void IJGNGIOIHBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6BB2D00", Offset = "0x6BB2100", VA = "0x186BB2D00", Slot = "5")]
		public virtual LNFKJLAPIOC OPILNEGBPCG(Guid AKOHGADPNOK, string MKFNLLBNHAE, [Optional] string GMMHAKBAPEN, [Optional] long? LGIOKNFAAIG, [Optional] string FLNEHJGCAIC, [Optional] string OOPBCMFJLDA)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class LCMPJAPKEGM
	{
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static Dictionary<string, Dictionary<string, object>> BLJEAMIKPNO;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static string KENMGBPNAPE;

		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private static int FKLKAKAMCDB;

		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private static readonly Dictionary<string, ANMMKGGJGKI> OCFFMMPFHAH;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static string FEKFJPNDHLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x6BB5550", Offset = "0x6BB4950", VA = "0x186BB5550")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x6BB5B70", Offset = "0x6BB4F70", VA = "0x186BB5B70")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static bool JLNGMPMHANB
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x6BB5C20", Offset = "0x6BB5020", VA = "0x186BB5C20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static Dictionary<string, Dictionary<string, object>> DCDGPBJMHEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x6BB5500", Offset = "0x6BB4900", VA = "0x186BB5500")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static Guid? PAMFHKJGAFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x6BB6640", Offset = "0x6BB5A40", VA = "0x186BB6640")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x6BB5D10", Offset = "0x6BB5110", VA = "0x186BB5D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static Guid? DEMGDOLIOBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x6BB57B0", Offset = "0x6BB4BB0", VA = "0x186BB57B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x6BB5CB0", Offset = "0x6BB50B0", VA = "0x186BB5CB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6BB6850", Offset = "0x6BB5C50", VA = "0x186BB6850")]
		public static void PAGIFMDBDNM(string GJPBCAGBMMF, ANMMKGGJGKI MBJCNAKMEHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6BB66A0", Offset = "0x6BB5AA0", VA = "0x186BB66A0")]
		internal static void OBBALIPJEND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6BB5980", Offset = "0x6BB4D80", VA = "0x186BB5980")]
		internal static void FIKJJGGPENN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6BB67D0", Offset = "0x6BB5BD0", VA = "0x186BB67D0")]
		internal static void OJBBGKPKHDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6BB6070", Offset = "0x6BB5470", VA = "0x186BB6070")]
		public static Guid MPJHJLJNGBO(string GJPBCAGBMMF, [Optional] string? HAAFODOLGHM, [Optional] Dictionary<string, object>? HPMKOEAFGHL)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6BB5FD0", Offset = "0x6BB53D0", VA = "0x186BB5FD0")]
		public static Guid MPJHJLJNGBO(string GJPBCAGBMMF, long HAAFODOLGHM, [Optional] Dictionary<string, object>? HPMKOEAFGHL)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6BB5D70", Offset = "0x6BB5170", VA = "0x186BB5D70")]
		public static void MECKDJJDDMK(string GJPBCAGBMMF, [Optional] Guid? BCIHOIBCNMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6BB55A0", Offset = "0x6BB49A0", VA = "0x186BB55A0")]
		public static void DCLAPIKBLMG(string GJPBCAGBMMF, string HLNLOHKFOCD, object MNFIBLCGILD, bool IPCNJCBBFEE = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6BB5310", Offset = "0x6BB4710", VA = "0x186BB5310")]
		public static bool ANLGILDJLFN(string GJPBCAGBMMF, [Optional] string? HAAFODOLGHM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6BB5810", Offset = "0x6BB4C10", VA = "0x186BB5810")]
		private static void FBDGKLOJIAA(bool FGOHMAPOJEG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6BB6780", Offset = "0x6BB5B80", VA = "0x186BB6780")]
		public static void OFLCOJCFFBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6BB5A60", Offset = "0x6BB4E60", VA = "0x186BB5A60")]
		private static void FOFGMMNLHDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6BB68E0", Offset = "0x6BB5CE0", VA = "0x186BB68E0")]
		private static void PMJJFDJAIML(string GJPBCAGBMMF, Guid AKOHGADPNOK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public static class FECOMKIFFAG
	{
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public struct CCFIOAEFFBP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public bool LAKNLJKLEMJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public string IFKPMNDGIBE;

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xB08A60", Offset = "0xB07E60", VA = "0x180B08A60")]
			public CCFIOAEFFBP(bool LAKNLJKLEMJ, string IFKPMNDGIBE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6BB4820", Offset = "0x6BB3C20", VA = "0x186BB4820")]
		public static CCFIOAEFFBP COHAOGFFGHO(LNFKJLAPIOC PGGGKPFJHJB)
		{
			return default(CCFIOAEFFBP);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6BB4B30", Offset = "0x6BB3F30", VA = "0x186BB4B30")]
		private static void FFNECMPGAKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6BB4760", Offset = "0x6BB3B60", VA = "0x186BB4760")]
		private static void AIEIAFFCHNC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class NBPPJGEFFNO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6BB8800", Offset = "0x6BB7C00", VA = "0x186BB8800")]
		public static LNFKJLAPIOC NEAAOCBKNON()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class DPHIOGCNAAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6BB2330", Offset = "0x6BB1730", VA = "0x186BB2330")]
		public static LNFKJLAPIOC NBEMCIJFNFD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6BB21B0", Offset = "0x6BB15B0", VA = "0x186BB21B0")]
		public static LNFKJLAPIOC LDEABBBJKEK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6BB23F0", Offset = "0x6BB17F0", VA = "0x186BB23F0")]
		public static LNFKJLAPIOC PDFBIMOEMPF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6BB2090", Offset = "0x6BB1490", VA = "0x186BB2090")]
		public static LNFKJLAPIOC FNKOOFCEFOG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6BB22D0", Offset = "0x6BB16D0", VA = "0x186BB22D0")]
		public static LNFKJLAPIOC MPBEEFKHJNK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6BB2210", Offset = "0x6BB1610", VA = "0x186BB2210")]
		public static LNFKJLAPIOC LMECMBHJNOP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6BB1F70", Offset = "0x6BB1370", VA = "0x186BB1F70")]
		public static LNFKJLAPIOC DEMDHOALACD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6BB2450", Offset = "0x6BB1850", VA = "0x186BB2450")]
		public static LNFKJLAPIOC PFMDNCBPGED()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6BB2030", Offset = "0x6BB1430", VA = "0x186BB2030")]
		public static LNFKJLAPIOC FCIILNJCLMN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6BB2390", Offset = "0x6BB1790", VA = "0x186BB2390")]
		public static LNFKJLAPIOC NKPNFPLBFJL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6BB1F10", Offset = "0x6BB1310", VA = "0x186BB1F10")]
		public static LNFKJLAPIOC CJJMNIFJAME()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6BB1FD0", Offset = "0x6BB13D0", VA = "0x186BB1FD0")]
		public static LNFKJLAPIOC EDKNHDIFLJK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6BB2150", Offset = "0x6BB1550", VA = "0x186BB2150")]
		public static LNFKJLAPIOC JFAPJCLKPCB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6BB2270", Offset = "0x6BB1670", VA = "0x186BB2270")]
		public static LNFKJLAPIOC MKMCDKCDEBC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6BB20F0", Offset = "0x6BB14F0", VA = "0x186BB20F0")]
		public static LNFKJLAPIOC HINJDGEPNNB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class JGCIBLPJIDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6BB4C30", Offset = "0x6BB4030", VA = "0x186BB4C30")]
		public static LNFKJLAPIOC LJLPONFDLNN(long LFNEDMLHPHM, long FHAJBLMHDGD, bool ECKEJOFCIHD, string NPOIJNHCAPG, string DBFGFCPJHBM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class LLFCFPNJKHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6BB7040", Offset = "0x6BB6440", VA = "0x186BB7040")]
		public static LNFKJLAPIOC LJNBAMNEADC(string KBJMHNEPHJG, string MKFAFOJKGIH, bool FCDMPEDCBKL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6BB6E10", Offset = "0x6BB6210", VA = "0x186BB6E10")]
		public static LNFKJLAPIOC DJBBAOFNGLE(string MEBLJIBNLCL, string MGBDMDPNBHD, string NLIOOFNJPJI, [Optional] int? HHOFNBAMPHP, [Optional] double[] NLJFEGDKCGL)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class POCNDIEGDGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6BBAC00", Offset = "0x6BBA000", VA = "0x186BBAC00")]
		public static LNFKJLAPIOC PHGBOICNGIA(string DNMAKBDOMMF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6BBAA60", Offset = "0x6BB9E60", VA = "0x186BBAA60")]
		public static LNFKJLAPIOC GAOJOHKFLOB(string CBEKHELGDIP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6BBABA0", Offset = "0x6BB9FA0", VA = "0x186BBABA0")]
		public static LNFKJLAPIOC KMJMACOBCGI(int CFMOAKJJMGO, string OGOCCCFKJPG, string NNKBGKICBEC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6BBAA00", Offset = "0x6BB9E00", VA = "0x186BBAA00")]
		public static LNFKJLAPIOC FFPNOFODKNI(int CFMOAKJJMGO, string OGOCCCFKJPG, string NNKBGKICBEC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6BBA850", Offset = "0x6BB9C50", VA = "0x186BBA850")]
		public static LNFKJLAPIOC AOMHGPHHDHP(int CFMOAKJJMGO, string OGOCCCFKJPG, string NNKBGKICBEC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x6BBAB40", Offset = "0x6BB9F40", VA = "0x186BBAB40")]
		public static LNFKJLAPIOC JMPMJHDIKGH(int CFMOAKJJMGO, string OGOCCCFKJPG, string NNKBGKICBEC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6BBA8B0", Offset = "0x6BB9CB0", VA = "0x186BBA8B0")]
		public static LNFKJLAPIOC BNNMANFLIEC(string OGOCCCFKJPG, string NNKBGKICBEC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6BBA5E0", Offset = "0x6BB99E0", VA = "0x186BBA5E0")]
		private static LNFKJLAPIOC AEDJDJOGGNP(string HNGGGMNMMNN, int CFMOAKJJMGO, string KPDHKBLNJDF, string OKKJAIEHOFI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6BBA720", Offset = "0x6BB9B20", VA = "0x186BBA720")]
		private static LNFKJLAPIOC AEDJDJOGGNP(string HNGGGMNMMNN, string KPDHKBLNJDF, string OKKJAIEHOFI)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly HLBHMADGLFA COHAOGFFGHO;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static PHBCPCHNMPE MEGFEENFKLO;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static JKIKAGKJNDP FCNIJBJEJOA;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static Queue<LNFKJLAPIOC> OJDCIIEOOHN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private static long DNOJKFACNBI
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6BB1860", Offset = "0x6BB0C60", VA = "0x186BB1860")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6BB1400", Offset = "0x6BB0800", VA = "0x186BB1400")]
	[BOHPIAAADDL.CCCKKBFCOMP]
	internal static void EMNIKBIIBFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6BB14F0", Offset = "0x6BB08F0", VA = "0x186BB14F0")]
	private static void FMAJJBACIKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6BB16C0", Offset = "0x6BB0AC0", VA = "0x186BB16C0")]
	public static LNFKJLAPIOC HJFLOBPOCMJ(string KKABDGGFDJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6BB15B0", Offset = "0x6BB09B0", VA = "0x186BB15B0")]
	public static LNFKJLAPIOC HJFLOBPOCMJ(string KKABDGGFDJF, int CFMOAKJJMGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6BB1740", Offset = "0x6BB0B40", VA = "0x186BB1740")]
	[BOHPIAAADDL.CCCKKBFCOMP]
	internal static void KEKIFDKNBAK()
	{
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
