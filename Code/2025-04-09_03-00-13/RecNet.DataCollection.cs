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
		[Cpp2IlInjected.Address(RVA = "0x9D4820", Offset = "0x9D3C20", VA = "0x1809D4820")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E49A90", Offset = "0x6E48E90", VA = "0x186E49A90")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9D5490", Offset = "0x9D4890", VA = "0x1809D5490")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9D54D0", Offset = "0x9D48D0", VA = "0x1809D54D0")]
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
	public class LogRegistrationIndex : BDONJGGEMII
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6E484E0", Offset = "0x6E478E0", VA = "0x186E484E0", Slot = "4")]
		public override void GEAMIGHEOPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9D4820", Offset = "0x9D3C20", VA = "0x1809D4820")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecNet_DataCollection
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6E4AE10", Offset = "0x6E4A210", VA = "0x186E4AE10", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2553680", Offset = "0x2552A80", VA = "0x182553680")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface EBNONHEMBKN
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyDictionary<string, object> JPANAMCBEDD();
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class FMDGOJHMFHN
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6E46660", Offset = "0x6E45A60", VA = "0x186E46660")]
	public static void IEINFAINHFD(this PDAMANONGLK.FLGCOMKPPOL EFJCDOLBLCP, string GJJNBHFDPLP, string DGJMFLFPOGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6E465D0", Offset = "0x6E459D0", VA = "0x186E465D0")]
	public static void IEINFAINHFD(this PDAMANONGLK.FLGCOMKPPOL EFJCDOLBLCP, string GJJNBHFDPLP, bool DGJMFLFPOGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6E464D0", Offset = "0x6E458D0", VA = "0x186E464D0")]
	public static void IEINFAINHFD(this PDAMANONGLK.FLGCOMKPPOL EFJCDOLBLCP, string GJJNBHFDPLP, float FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6E466D0", Offset = "0x6E45AD0", VA = "0x186E466D0")]
	public static void IEINFAINHFD(this PDAMANONGLK.FLGCOMKPPOL EFJCDOLBLCP, string GJJNBHFDPLP, IBGLLIKHBND DGJMFLFPOGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class PDAMANONGLK
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface HGDCBAGGPBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		FLGCOMKPPOL PHKKOJKCGHE(Guid HFGKEOIDFDA, string AIMHGJBNJON, [Optional] string FENHOJHGFOB, [Optional] long? KKPLNEGHAEJ, [Optional] string NOMLDKJCODG, [Optional] string KGJJFDHPDEM);
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class ALNJDDCEKHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6E42410", Offset = "0x6E41810", VA = "0x186E42410")]
		public static FLGCOMKPPOL DKNPEHALMDA(Guid HFGKEOIDFDA, string AIMHGJBNJON, string FENHOJHGFOB, [Optional] long? KKPLNEGHAEJ, [Optional] string NOMLDKJCODG, [Optional] string KGJJFDHPDEM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class FLGCOMKPPOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		protected PNOIEJNBDFJ JOKKIDPHPDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly IDictionary<string, IDictionary<string, object>> INGBLAMBABH;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool FFIPMMNAMKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6E45CC0", Offset = "0x6E450C0", VA = "0x186E45CC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public string EOOGEPNJKOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x1039E90", Offset = "0x1039290", VA = "0x181039E90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6E46430", Offset = "0x6E45830", VA = "0x186E46430")]
		public FLGCOMKPPOL(PNOIEJNBDFJ JOKKIDPHPDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6E46230", Offset = "0x6E45630", VA = "0x186E46230")]
		public FLGCOMKPPOL GIHLOONBFMD(string MHALMOGKEGG, string FFOEEMKIKJO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3D286A0", Offset = "0x3D27AA0", VA = "0x183D286A0")]
		public FLGCOMKPPOL GIHLOONBFMD<T>(string MHALMOGKEGG, T FFOEEMKIKJO) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6E463B0", Offset = "0x6E457B0", VA = "0x186E463B0")]
		public FLGCOMKPPOL ODCJNBAEIHF(string MHALMOGKEGG, object FFOEEMKIKJO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3D28610", Offset = "0x3D27A10", VA = "0x183D28610")]
		public FLGCOMKPPOL ADIEKOACJOA<T>(string MHALMOGKEGG, T? FFOEEMKIKJO) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6E45C30", Offset = "0x6E45030", VA = "0x186E45C30")]
		public FLGCOMKPPOL ADIEKOACJOA(string MHALMOGKEGG, string FFOEEMKIKJO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6E460F0", Offset = "0x6E454F0", VA = "0x186E460F0")]
		public FLGCOMKPPOL EKHHHLGKHKN(string AFBBPENAHOE, string DJBLFBEBKGO, object HPMNBNLACCC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6E46010", Offset = "0x6E45410", VA = "0x186E46010")]
		public FLGCOMKPPOL EKHHHLGKHKN(string AFBBPENAHOE, IDictionary<string, object> KLIMJMOCIDN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6E45D00", Offset = "0x6E45100", VA = "0x186E45D00")]
		private static IDictionary<string, object> DBBMGDIKCMO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6E45D60", Offset = "0x6E45160", VA = "0x186E45D60")]
		public void EGMHIKFBPMK(bool PLPPFHCEAEH, string GBAKOMEKGHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6E462B0", Offset = "0x6E456B0", VA = "0x186E462B0")]
		public Task ILKOGDNGDHF([Optional] CancellationToken LMNHDKIFBOH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2669100", Offset = "0x2668500", VA = "0x182669100", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class PNOIEJNBDFJ
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private struct GNBFBKLGNDK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public PNOIEJNBDFJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6E46EF0", Offset = "0x6E462F0", VA = "0x186E46EF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6E47360", Offset = "0x6E46760", VA = "0x186E47360", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static Action<PNOIEJNBDFJ> EMPONAFEEBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly string DEPLFLMGIOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly Dictionary<string, object> LMKBANAEPPO;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string EOOGEPNJKOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x9AA3B0", Offset = "0x9A97B0", VA = "0x1809AA3B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6E4A7E0", Offset = "0x6E49BE0", VA = "0x186E4A7E0")]
		private PNOIEJNBDFJ(string DEPLFLMGIOJ, int CBHDFIGALJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6E49EA0", Offset = "0x6E492A0", VA = "0x186E49EA0")]
		public static FLGCOMKPPOL GNHEPACBJCH(string DEPLFLMGIOJ, int CBHDFIGALJM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6E4A620", Offset = "0x6E49A20", VA = "0x186E4A620")]
		[AsyncStateMachine(typeof(GNBFBKLGNDK))]
		public Task ILKOGDNGDHF([Optional] CancellationToken LMNHDKIFBOH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6E4A770", Offset = "0x6E49B70", VA = "0x186E4A770", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3401480", Offset = "0x3400880", VA = "0x183401480")]
		internal void EEEMKBPNGMO<T>(string MHALMOGKEGG, T FFOEEMKIKJO) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6E4A710", Offset = "0x6E49B10", VA = "0x186E4A710")]
		internal void MFEMLIJOIED(string MHALMOGKEGG, object FFOEEMKIKJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6E4A5C0", Offset = "0x6E499C0", VA = "0x186E4A5C0")]
		internal void EEEMKBPNGMO(string MHALMOGKEGG, string FFOEEMKIKJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3D2FA10", Offset = "0x3D2EE10", VA = "0x183D2FA10")]
		private void GLCLIPBPCEL<T>(string MHALMOGKEGG, T FFOEEMKIKJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct NCMOJDJJAAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly string OKCIAGJDGBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly long? GGHGNFHHKKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly short? IHAHLOBEMOP;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6E49470", Offset = "0x6E48870", VA = "0x186E49470")]
		public NCMOJDJJAAL(string MGAHOIGENKH, [Optional] long? MIFADOBCMAC, [Optional] short? HKEIHJPMDNE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct MBCNBKNDGJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly int CMKCNFHKAAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public readonly string FHGBHGHDEKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly short HNBLFBDBFNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public readonly string CALJEMNEMOH;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6E48570", Offset = "0x6E47970", VA = "0x186E48570")]
		public MBCNBKNDGJL(int IIJAFKKMMMN, string ANGFPEDLOLC, short NMIOLBNOHGJ, string KHFHBMLBCBN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class BHNECDKLLLD : EPABBHAIMLE<GMEFPOGEIML, MBCNBKNDGJL, NCMOJDJJAAL>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private string ANGFPEDLOLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private short NMIOLBNOHGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private string KHFHBMLBCBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private Dictionary<short, int> GMOCLLPEECA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private int MKDNKMNGEEM;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6E43A80", Offset = "0x6E42E80", VA = "0x186E43A80")]
		public BHNECDKLLLD(string OEFKCJGCGLP, Guid AEHCDHOPEIJ, long MOEFOOADDIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6E42620", Offset = "0x6E41A20", VA = "0x186E42620", Slot = "4")]
		public override void ADEBFJCPPCC(MBCNBKNDGJL CKIMLOEAHOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6E439A0", Offset = "0x6E42DA0", VA = "0x186E439A0")]
		public void OJGAADHDDHI(short NMIOLBNOHGJ, bool DNDNDHFDLIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x46FB700", Offset = "0x46FAB00", VA = "0x1846FB700")]
		public void MHODLCFIBBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9A9A50", Offset = "0x9A8E50", VA = "0x1809A9A50")]
		public void PHMOEOADMHP(string MBCLBIFELGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6E42BC0", Offset = "0x6E41FC0", VA = "0x186E42BC0", Slot = "5")]
		public override void KPCFHFJPEKD(bool BHPHILLJABD, NCMOJDJJAAL KDDNDEANFAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6E42910", Offset = "0x6E41D10", VA = "0x186E42910", Slot = "6")]
		public override NCHJOOIBKKD IIJOAJMBPGL(GMEFPOGEIML BHBELMNDMGD, int CJFNAFNJJLB, string OEOPIEBOEBM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class PAAGDKJDJLI : NCHJOOIBKKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private string ANGFPEDLOLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly short NMIOLBNOHGJ;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6E49CC0", Offset = "0x6E490C0", VA = "0x186E49CC0")]
		public PAAGDKJDJLI(long NGNKEIBNEND, int IIJAFKKMMMN, string FENHOJHGFOB, long MOEFOOADDIC, int PKKFAHKKHII, string NOMLDKJCODG, short NMIOLBNOHGJ, string ANGFPEDLOLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6E49B10", Offset = "0x6E48F10", VA = "0x186E49B10")]
		public void NEMFOHBKAMA(int IIJAFKKMMMN, string ANGFPEDLOLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6E49B90", Offset = "0x6E48F90", VA = "0x186E49B90", Slot = "5")]
		public override FLGCOMKPPOL PHKKOJKCGHE(Guid HFGKEOIDFDA, string AIMHGJBNJON, [Optional] string FENHOJHGFOB, [Optional] long? KKPLNEGHAEJ, [Optional] string NOMLDKJCODG, [Optional] string KGJJFDHPDEM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class AHFPKGJIKDB
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class FBCFHHDNPMM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public float nextEventSendTime;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
			public FBCFHHDNPMM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6E455F0", Offset = "0x6E449F0", VA = "0x186E455F0")]
			internal bool IOOEPIOEIBF()
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private struct KNIGNEEKFGO : IAsyncStateMachine
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
			private FBCFHHDNPMM <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private TimeSpan <delayPollingInterval>5__2;

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6E47760", Offset = "0x6E46B60", VA = "0x186E47760", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6E48420", Offset = "0x6E47820", VA = "0x186E48420", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private struct NPPMIAGCJBF : IAsyncStateMachine
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

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6E494B0", Offset = "0x6E488B0", VA = "0x186E494B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6E49A30", Offset = "0x6E48E30", VA = "0x186E49A30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public static readonly float JBOJMBCLEKK;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static NNOOHIAHMIG ENFLKMBLIJN;

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static CancellationTokenSource FMDLIIKGLIE;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static bool JMMMCBGFHAG;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private static int FALIJGBKEDM;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static readonly APHAPGEAMFF<FLGCOMKPPOL, bool> ACMGIMHFEAG;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static FOFIHLCPBFF<FLGCOMKPPOL, bool> GNHCJFEAEMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6E42040", Offset = "0x6E41440", VA = "0x186E42040")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private static bool ANGFLBHFGJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x6E416B0", Offset = "0x6E40AB0", VA = "0x186E416B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6E41940", Offset = "0x6E40D40", VA = "0x186E41940")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private static bool GHHGNBPFLBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6E422D0", Offset = "0x6E416D0", VA = "0x186E422D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6E41E30", Offset = "0x6E41230", VA = "0x186E41E30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private static float KCELAJMCKAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6E42090", Offset = "0x6E41490", VA = "0x186E42090")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6E41700", Offset = "0x6E40B00", VA = "0x186E41700")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6E421B0", Offset = "0x6E415B0", VA = "0x186E421B0")]
		[FHKEPBLDBGP.MANFMCGMCFL]
		internal static void PGPIHOOHKBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6E41760", Offset = "0x6E40B60", VA = "0x186E41760")]
		internal static void GDCNGOALEGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6E41E90", Offset = "0x6E41290", VA = "0x186E41E90")]
		internal static void MIPAEFEDIJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6E411D0", Offset = "0x6E405D0", VA = "0x186E411D0")]
		internal static void BAEFDCJFDHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6E41230", Offset = "0x6E40630", VA = "0x186E41230")]
		public static void BFIDELGLGEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6E41280", Offset = "0x6E40680", VA = "0x186E41280")]
		private static void CBBEIIEODFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6E419A0", Offset = "0x6E40DA0", VA = "0x186E419A0")]
		private static void HCBAGEFLKDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6E420E0", Offset = "0x6E414E0", VA = "0x186E420E0")]
		[AsyncStateMachine(typeof(KNIGNEEKFGO))]
		private static Task PGIHJGNFBBM(CancellationToken LMNHDKIFBOH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6E41D60", Offset = "0x6E41160", VA = "0x186E41D60")]
		private static void LDBCDILEGGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6E41C80", Offset = "0x6E41080", VA = "0x186E41C80")]
		[AsyncStateMachine(typeof(NPPMIAGCJBF))]
		private static Task HGCLECFKOCO(bool KDDNCIEGIPE, [Optional] CancellationToken LMNHDKIFBOH)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class LGPNNNBBMEN<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class OEGCKCOEOKO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public LGPNNNBBMEN<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
			public OEGCKCOEOKO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x5212D90", Offset = "0x5212190", VA = "0x185212D90")]
			internal object NFOHMBMHHCL()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class FKDGLOPNOIJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public LGPNNNBBMEN<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
			public FKDGLOPNOIJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x47601B0", Offset = "0x475F5B0", VA = "0x1847601B0")]
			internal object ICMGDJCIIIG()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class JJKCALMOFAJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public LGPNNNBBMEN<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
			public JJKCALMOFAJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x4C0E620", Offset = "0x4C0DA20", VA = "0x184C0E620")]
			internal object IBNGMGKGNND()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class MIFILLLGINE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public LGPNNNBBMEN<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
			public MIFILLLGINE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x5060580", Offset = "0x505F980", VA = "0x185060580")]
			internal object AGCHKLPAAAL()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class MKOOBHFLBPE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public LGPNNNBBMEN<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
			public MKOOBHFLBPE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x506AB60", Offset = "0x5069F60", VA = "0x18506AB60")]
			internal object PFANKMBAONO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class EGCMEPGDMJH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public LGPNNNBBMEN<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
			public EGCMEPGDMJH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x42DFD80", Offset = "0x42DF180", VA = "0x1842DFD80")]
			internal object KHCKLEMHNOA()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class NNNOFDNKJEK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public LGPNNNBBMEN<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
			public NNNOFDNKJEK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x51096F0", Offset = "0x5108AF0", VA = "0x1851096F0")]
			internal object DLHGIHMDGBN()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private const float KLEIKPJMIMO = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly Guid HFGKEOIDFDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly string NOMLDKJCODG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly string EAPMAEBMDOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private string FEAKAHCFMLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private string KGJJFDHPDEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private string LHOBLOPMBGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private string ININGBKACJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private string IKFCMBNJHFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private string LCOBKOFCMBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private string OALMNODDCGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private string CHHIMIDMPFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private string DLIBGJPNJCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Guid? LAMNAHMGJFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private (int, int)? AFFLGGJINKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly HashSet<T> AGBABLNMNGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly Dictionary<(T, int), string> EKGDJLEKNDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly Dictionary<(T, int), float> PPJGLHJIAJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly Dictionary<T, string> LKEBJELDIID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly Dictionary<T, string> OLBFBDCELLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly Dictionary<T, string> EEJBGFCCJFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly Dictionary<T, string[]> KBEHBJOHDPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private string GOHINGHGDKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private bool KHGFHBLNDOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private Task HIEJNLLLMJN;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x4E66FD0", Offset = "0x4E663D0", VA = "0x184E66FD0")]
		public LGPNNNBBMEN(Guid HFGKEOIDFDA, string EAPMAEBMDOL, string NOMLDKJCODG, string FEAKAHCFMLE, [Optional] string KGJJFDHPDEM, [Optional] string LHOBLOPMBGJ, [Optional] string ININGBKACJG, [Optional] string OALMNODDCGJ, [Optional] string GOHINGHGDKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9AA3D0", Offset = "0x9A97D0", VA = "0x1809AA3D0")]
		public void OMBDCHDMPOB(string KGJJFDHPDEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9B40A0", Offset = "0x9B34A0", VA = "0x1809B40A0")]
		public void MEKEEGLKPHI(string FEAKAHCFMLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xAF1080", Offset = "0xAF0480", VA = "0x180AF1080")]
		public void EGNCJIJFDIA(string GOHINGHGDKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9A9AC0", Offset = "0x9A8EC0", VA = "0x1809A9AC0")]
		public void LHCHIPPJFJN(string IKFCMBNJHFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9A9A50", Offset = "0x9A8E50", VA = "0x1809A9A50")]
		public void EPIFJCENEMO(string CHHIMIDMPFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9A9AB0", Offset = "0x9A8EB0", VA = "0x1809A9AB0")]
		public void IJFFIIFFGNM(string DLIBGJPNJCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x4E66810", Offset = "0x4E65C10", VA = "0x184E66810")]
		public void OMDGOEDPJLK(Guid? HFGKEOIDFDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x48736E0", Offset = "0x4872AE0", VA = "0x1848736E0")]
		public void HPGKCNEGOLI((int, int)? AFFLGGJINKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9A9A80", Offset = "0x9A8E80", VA = "0x1809A9A80")]
		public void MLIGNBBFPJN(string LCOBKOFCMBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x4E65AE0", Offset = "0x4E64EE0", VA = "0x184E65AE0")]
		public void IMIGMOEHLPI(T KKPLNEGHAEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x4E62000", Offset = "0x4E61400", VA = "0x184E62000")]
		public void HMDAGHNMGAI(T KKPLNEGHAEJ, int MGJKHGIOGBA, float HLOBKBPABIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x4E66830", Offset = "0x4E65C30", VA = "0x184E66830")]
		public void PPHNLANBAGP(T KKPLNEGHAEJ, int MGJKHGIOGBA, string GOLPONGHJGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x4E61660", Offset = "0x4E60A60", VA = "0x184E61660")]
		public void FDFIOJBEHAI(T KKPLNEGHAEJ, string MFANEJFBEMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x4E602D0", Offset = "0x4E5F6D0", VA = "0x184E602D0")]
		public void CJCPNKOLNKP(T KKPLNEGHAEJ, string FFIAEICHPDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x4E62360", Offset = "0x4E61760", VA = "0x184E62360")]
		public void IGGOLBOFPKE(T KKPLNEGHAEJ, bool GJIKCGMFAEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x4E66160", Offset = "0x4E65560", VA = "0x184E66160")]
		public void LNCAKIHELOK(T KKPLNEGHAEJ, string[] ODLNJODKJEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x4E638F0", Offset = "0x4E62CF0", VA = "0x184E638F0")]
		public Task ILKOGDNGDHF(bool HLPBIKLHEBD = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x4E5F4F0", Offset = "0x4E5E8F0", VA = "0x184E5F4F0")]
		private (IEnumerable<T>, string) ANOBLHIMJMK()
		{
			return default((IEnumerable<T>, string));
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x4E610A0", Offset = "0x4E604A0", VA = "0x184E610A0")]
		public static FLGCOMKPPOL EMIMOIBPAHH(Guid HFGKEOIDFDA, string EAPMAEBMDOL, T KKPLNEGHAEJ, string NOMLDKJCODG, string BEHODDLGDFE, string KGJJFDHPDEM, int? CJFNAFNJJLB, [Optional] string MDOFIJAEFBE, [Optional] string MFANEJFBEMD, [Optional] int? CGOIBEDPACB, [Optional] Guid? LAMNAHMGJFN, [Optional] string GOHINGHGDKI, [Optional] string FENHOJHGFOB, [Optional] (int, int)? AFFLGGJINKB, [Optional] string BFADAKPFOCB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x4E660D0", Offset = "0x4E654D0", VA = "0x184E660D0")]
		[CompilerGenerated]
		private string KMNGCFJGGMC(T NCJKGMLAKGH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x4E66660", Offset = "0x4E65A60", VA = "0x184E66660")]
		[CompilerGenerated]
		private string OEOBDALBKMJ(T NCJKGMLAKGH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x4E60630", Offset = "0x4E5FA30", VA = "0x184E60630")]
		[CompilerGenerated]
		private string DKHAHOHFCOG(T NCJKGMLAKGH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x4E65E00", Offset = "0x4E65200", VA = "0x184E65E00")]
		[CompilerGenerated]
		private string JGEBIJOBFCD(T NCJKGMLAKGH)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public abstract class EPABBHAIMLE<TItem, TListSessionStartParams, TListSessionLogParams>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		protected readonly string OEFKCJGCGLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		protected readonly Guid AEHCDHOPEIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		protected readonly long MOEFOOADDIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		protected int IIJAFKKMMMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		protected int GHLDNFELGDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		protected DateTime MDMPOIKMEDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		protected bool KHPCCBPLGGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		protected Dictionary<long, NCHJOOIBKKD> HBAGOGFOMKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		protected bool KPHHMLIJDOJ;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool ECMLJIKMDCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xB5F800", Offset = "0xB5EC00", VA = "0x180B5F800")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool DFMDHMFOCGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xBC38E0", Offset = "0xBC2CE0", VA = "0x180BC38E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x430A0D0", Offset = "0x43094D0", VA = "0x18430A0D0")]
		public EPABBHAIMLE(string OEFKCJGCGLP, Guid AEHCDHOPEIJ, long MOEFOOADDIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void ADEBFJCPPCC(TListSessionStartParams CKIMLOEAHOK);

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x42FA2D0", Offset = "0x42F96D0", VA = "0x1842FA2D0")]
		public void NCONGPIMOOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void KPCFHFJPEKD(bool BHPHILLJABD, TListSessionLogParams KDDNDEANFAB);

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x4309E90", Offset = "0x4309290", VA = "0x184309E90")]
		public void GCABLJHNBNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x4309D70", Offset = "0x4309170", VA = "0x184309D70")]
		public void BBCLAPNBLFF(long NGNKEIBNEND, int CJFNAFNJJLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x4309EE0", Offset = "0x43092E0", VA = "0x184309EE0")]
		public void HGNBBBEGPKH(long NGNKEIBNEND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract NCHJOOIBKKD IIJOAJMBPGL(TItem MGCEJOCCONP, int CJFNAFNJJLB, string OEOPIEBOEBM);
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class NCHJOOIBKKD : HGDCBAGGPBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private int IIJAFKKMMMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private long NGNKEIBNEND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private long MOEFOOADDIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly string FMGJDKGOACK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly string GPDLHAIKKBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly int PKKFAHKKHII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private DateTime AEKHPPFJCAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private double GEIPADBBEDO;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool MIDPHKNGKPI
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xD81720", Offset = "0xD80B20", VA = "0x180D81720")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xD81220", Offset = "0xD80620", VA = "0x180D81220")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6E493A0", Offset = "0x6E487A0", VA = "0x186E493A0")]
		public NCHJOOIBKKD(long NGNKEIBNEND, int IIJAFKKMMMN, string FENHOJHGFOB, long MOEFOOADDIC, int PKKFAHKKHII, [Optional] string NOMLDKJCODG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6E48CC0", Offset = "0x6E480C0", VA = "0x186E48CC0")]
		public void ECCKGKDJOJM(int IIJAFKKMMMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6E48D90", Offset = "0x6E48190", VA = "0x186E48D90")]
		public void LEALILMKDEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6E48DE0", Offset = "0x6E481E0", VA = "0x186E48DE0")]
		public void OPBFHAMJFBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6E48D30", Offset = "0x6E48130", VA = "0x186E48D30")]
		private void IGAHPGHFGIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6E48EF0", Offset = "0x6E482F0", VA = "0x186E48EF0", Slot = "5")]
		public virtual FLGCOMKPPOL PHKKOJKCGHE(Guid HFGKEOIDFDA, string AIMHGJBNJON, [Optional] string FENHOJHGFOB, [Optional] long? KKPLNEGHAEJ, [Optional] string NOMLDKJCODG, [Optional] string KGJJFDHPDEM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class EBDNLDBAKDK
	{
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private static Dictionary<string, Dictionary<string, object>> NDHPIKKJPJP;

		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private static string FGIAOECMDKH;

		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private static int HBOABMIMIOK;

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private static readonly Dictionary<string, EBNONHEMBKN> MGCPHNMDHMB;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static string DNBKCKHMJNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x6E44BF0", Offset = "0x6E43FF0", VA = "0x186E44BF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x6E45400", Offset = "0x6E44800", VA = "0x186E45400")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static bool KBOEPCKGGGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x6E44CA0", Offset = "0x6E440A0", VA = "0x186E44CA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static Dictionary<string, Dictionary<string, object>> CEHIOIMJIJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x6E45350", Offset = "0x6E44750", VA = "0x186E45350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static Guid? HEDEFCIFILJ
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x6E447E0", Offset = "0x6E43BE0", VA = "0x186E447E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x6E453A0", Offset = "0x6E447A0", VA = "0x186E453A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static Guid? FKBNHIJLAAN
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x6E44C40", Offset = "0x6E44040", VA = "0x186E44C40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x6E452F0", Offset = "0x6E446F0", VA = "0x186E452F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6E44F20", Offset = "0x6E44320", VA = "0x186E44F20")]
		public static void MHBBBCOFEDF(string OJMDGNNBLDJ, EBNONHEMBKN OEBIOLCHBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6E44840", Offset = "0x6E43C40", VA = "0x186E44840")]
		internal static void GDCNGOALEGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6E44FB0", Offset = "0x6E443B0", VA = "0x186E44FB0")]
		internal static void MIPAEFEDIJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6E44170", Offset = "0x6E43570", VA = "0x186E44170")]
		internal static void BAEFDCJFDHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6E43BA0", Offset = "0x6E42FA0", VA = "0x186E43BA0")]
		public static Guid ADEBFJCPPCC(string OJMDGNNBLDJ, [Optional] string? GJOOCNMAEBG, [Optional] Dictionary<string, object>? FMHCHJFMBBF)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6E43B00", Offset = "0x6E42F00", VA = "0x186E43B00")]
		public static Guid ADEBFJCPPCC(string OJMDGNNBLDJ, long GJOOCNMAEBG, [Optional] Dictionary<string, object>? FMHCHJFMBBF)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6E45090", Offset = "0x6E44490", VA = "0x186E45090")]
		public static void NCONGPIMOOE(string OJMDGNNBLDJ, [Optional] Guid? KDBHLLEACIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6E445E0", Offset = "0x6E439E0", VA = "0x186E445E0")]
		public static void DIBNIJLLPDL(string OJMDGNNBLDJ, string AFBBPENAHOE, object FAAAGMNPMBA, bool JMMMCBGFHAG = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6E44D30", Offset = "0x6E44130", VA = "0x186E44D30")]
		public static bool JPDFJNGLICI(string OJMDGNNBLDJ, [Optional] string? GJOOCNMAEBG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6E44970", Offset = "0x6E43D70", VA = "0x186E44970")]
		private static void GLLBEGJFFKC(bool AFCDIPMDOIB = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6E44920", Offset = "0x6E43D20", VA = "0x186E44920")]
		public static void GHHFOPOLGFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6E44AE0", Offset = "0x6E43EE0", VA = "0x186E44AE0")]
		private static void HCBAGEFLKDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6E441F0", Offset = "0x6E435F0", VA = "0x186E441F0")]
		private static void BFCCJGCNCLM(string OJMDGNNBLDJ, Guid HFGKEOIDFDA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public static class FPNEKLKOFCH
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public struct PBGGEGCGGJB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public bool JKLFEMENKBM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public string EGKFIDEDPCL;

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xB606A0", Offset = "0xB5FAA0", VA = "0x180B606A0")]
			public PBGGEGCGGJB(bool JKLFEMENKBM, string EGKFIDEDPCL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6E46AE0", Offset = "0x6E45EE0", VA = "0x186E46AE0")]
		public static PBGGEGCGGJB GFDFDHMHGGA(FLGCOMKPPOL EFJCDOLBLCP)
		{
			return default(PBGGEGCGGJB);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6E46DF0", Offset = "0x6E461F0", VA = "0x186E46DF0")]
		private static void KLLKFEICNNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6E46A20", Offset = "0x6E45E20", VA = "0x186E46A20")]
		private static void BGEOBMAEDDH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class KOIAGFDHCGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6E48480", Offset = "0x6E47880", VA = "0x186E48480")]
		public static FLGCOMKPPOL GNPGADAGJCJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class FJGKILHJPNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6E45750", Offset = "0x6E44B50", VA = "0x186E45750")]
		public static FLGCOMKPPOL BIJAMAIJODO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6E45A50", Offset = "0x6E44E50", VA = "0x186E45A50")]
		public static FLGCOMKPPOL IHDECPCEOPF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6E45810", Offset = "0x6E44C10", VA = "0x186E45810")]
		public static FLGCOMKPPOL CKIPPJBFMPI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6E458D0", Offset = "0x6E44CD0", VA = "0x186E458D0")]
		public static FLGCOMKPPOL FGFDAAPANDF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6E45870", Offset = "0x6E44C70", VA = "0x186E45870")]
		public static FLGCOMKPPOL FFNFILFHHLJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6E459F0", Offset = "0x6E44DF0", VA = "0x186E459F0")]
		public static FLGCOMKPPOL HFBBAGDGIJE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6E45B10", Offset = "0x6E44F10", VA = "0x186E45B10")]
		public static FLGCOMKPPOL JMIEJCPCKLB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6E45BD0", Offset = "0x6E44FD0", VA = "0x186E45BD0")]
		public static FLGCOMKPPOL PEDLJDELOHM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6E456F0", Offset = "0x6E44AF0", VA = "0x186E456F0")]
		public static FLGCOMKPPOL BHDOKOHOHOD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6E45990", Offset = "0x6E44D90", VA = "0x186E45990")]
		public static FLGCOMKPPOL GJAFCFKBHDL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6E45930", Offset = "0x6E44D30", VA = "0x186E45930")]
		public static FLGCOMKPPOL GHLMKFAGCHK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6E45690", Offset = "0x6E44A90", VA = "0x186E45690")]
		public static FLGCOMKPPOL AMJFCJLJMDO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6E45B70", Offset = "0x6E44F70", VA = "0x186E45B70")]
		public static FLGCOMKPPOL LJJHCGNFAIG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6E45AB0", Offset = "0x6E44EB0", VA = "0x186E45AB0")]
		public static FLGCOMKPPOL JCABDFEOKIM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6E457B0", Offset = "0x6E44BB0", VA = "0x186E457B0")]
		public static FLGCOMKPPOL BKFPMLLNGKE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class PNLGIOAALEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6E4A3E0", Offset = "0x6E497E0", VA = "0x186E4A3E0")]
		public static FLGCOMKPPOL HJMGCMFJBPM(long MIFADOBCMAC, long JCNNPHFBOMP, bool EHDMCOLJNFJ, string IKCHPENKGOI, string JOLAMBIJHCI)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class IKAOFDHBCHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6E473C0", Offset = "0x6E467C0", VA = "0x186E473C0")]
		public static FLGCOMKPPOL NNLHPNFIINM(string BABBIPKFFLI, string COADNPMEKFL, bool NGGCIJBEPBH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6E47530", Offset = "0x6E46930", VA = "0x186E47530")]
		public static FLGCOMKPPOL OILBALOGNEP(string PCJJKLDOJMD, string NADHILHOIBL, string OGPEAJMIILP, [Optional] int? EFBIIFKIJGK, [Optional] double[] CKLKNJHOJKJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class MFHKLBFKIOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x6E48BE0", Offset = "0x6E47FE0", VA = "0x186E48BE0")]
		public static FLGCOMKPPOL OCMHKOEBCBA(string LOCMJNMJHBC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6E48620", Offset = "0x6E47A20", VA = "0x186E48620")]
		public static FLGCOMKPPOL GLGMCGHGLPM(string OPICNDKBMLI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6E485C0", Offset = "0x6E479C0", VA = "0x186E485C0")]
		public static FLGCOMKPPOL BACBHAGHJLN(int CBHDFIGALJM, string IGEPDAOOLBO, string NCJKGMLAKGH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6E48910", Offset = "0x6E47D10", VA = "0x186E48910")]
		public static FLGCOMKPPOL KOBFFNPKFML(int CBHDFIGALJM, string IGEPDAOOLBO, string NCJKGMLAKGH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x6E48850", Offset = "0x6E47C50", VA = "0x186E48850")]
		public static FLGCOMKPPOL JKIAOFFAFCG(int CBHDFIGALJM, string IGEPDAOOLBO, string NCJKGMLAKGH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6E488B0", Offset = "0x6E47CB0", VA = "0x186E488B0")]
		public static FLGCOMKPPOL KLLCKICMGAM(int CBHDFIGALJM, string IGEPDAOOLBO, string NCJKGMLAKGH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x6E48700", Offset = "0x6E47B00", VA = "0x186E48700")]
		public static FLGCOMKPPOL IOIGIANMANL(string IGEPDAOOLBO, string NCJKGMLAKGH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x6E48AA0", Offset = "0x6E47EA0", VA = "0x186E48AA0")]
		private static FLGCOMKPPOL NMHAOFEPMFF(string OEFKCJGCGLP, int CBHDFIGALJM, string CPCLCGPKBAL, string IAICLKLPDLA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x6E48970", Offset = "0x6E47D70", VA = "0x186E48970")]
		private static FLGCOMKPPOL NMHAOFEPMFF(string OEFKCJGCGLP, string CPCLCGPKBAL, string IAICLKLPDLA)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly GBHBOJAPDOA GFDFDHMHGGA;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static LCEBKHHFGNL IKCMILIPJHC;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static DJEHKBEDOAJ BLJEJEHKGAP;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static Queue<FLGCOMKPPOL> HINGLACLFGA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private static long GGEFJPCECPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6E49DB0", Offset = "0x6E491B0", VA = "0x186E49DB0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6E4A030", Offset = "0x6E49430", VA = "0x186E4A030")]
	[FHKEPBLDBGP.MANFMCGMCFL]
	internal static void LGJOAGMPKDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6E4A120", Offset = "0x6E49520", VA = "0x186E4A120")]
	private static void MAKONFNGNML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6E49FB0", Offset = "0x6E493B0", VA = "0x186E49FB0")]
	public static FLGCOMKPPOL EINOPMGEIOK(string DEPLFLMGIOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6E49EA0", Offset = "0x6E492A0", VA = "0x186E49EA0")]
	public static FLGCOMKPPOL EINOPMGEIOK(string DEPLFLMGIOJ, int CBHDFIGALJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6E4A1E0", Offset = "0x6E495E0", VA = "0x186E4A1E0")]
	public static bool NBMCGELHGBK(this NNOOHIAHMIG NABFLDFFLBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6E4A250", Offset = "0x6E49650", VA = "0x186E4A250")]
	[FHKEPBLDBGP.MANFMCGMCFL]
	internal static void NDBBOLEKGOF()
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
