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
		[Cpp2IlInjected.Address(RVA = "0x9BE830", Offset = "0x9BDC30", VA = "0x1809BE830")]
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
		[Cpp2IlInjected.Address(RVA = "0x6DF35C0", Offset = "0x6DF29C0", VA = "0x186DF35C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9BF4A0", Offset = "0x9BE8A0", VA = "0x1809BF4A0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9BF4E0", Offset = "0x9BE8E0", VA = "0x1809BF4E0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _LogRegistration.RecNet_DataCollection
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : BDONJGGEMII
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6DF1FF0", Offset = "0x6DF13F0", VA = "0x186DF1FF0", Slot = "4")]
		public override void GEAMIGHEOPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9BE830", Offset = "0x9BDC30", VA = "0x1809BE830")]
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
		[Cpp2IlInjected.Address(RVA = "0x6DF49A0", Offset = "0x6DF3DA0", VA = "0x186DF49A0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x254E750", Offset = "0x254DB50", VA = "0x18254E750")]
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
	[Cpp2IlInjected.Address(RVA = "0x6DF0120", Offset = "0x6DEF520", VA = "0x186DF0120")]
	public static void IEINFAINHFD(this PDAMANONGLK.FLGCOMKPPOL EFJCDOLBLCP, string GJJNBHFDPLP, string DGJMFLFPOGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6DF0090", Offset = "0x6DEF490", VA = "0x186DF0090")]
	public static void IEINFAINHFD(this PDAMANONGLK.FLGCOMKPPOL EFJCDOLBLCP, string GJJNBHFDPLP, bool DGJMFLFPOGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6DEFF90", Offset = "0x6DEF390", VA = "0x186DEFF90")]
	public static void IEINFAINHFD(this PDAMANONGLK.FLGCOMKPPOL EFJCDOLBLCP, string GJJNBHFDPLP, float FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6DF0190", Offset = "0x6DEF590", VA = "0x186DF0190")]
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
		[Cpp2IlInjected.Address(RVA = "0x6DEBDF0", Offset = "0x6DEB1F0", VA = "0x186DEBDF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6DEF760", Offset = "0x6DEEB60", VA = "0x186DEF760")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public string EOOGEPNJKOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xFF9210", Offset = "0xFF8610", VA = "0x180FF9210")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6DEFEF0", Offset = "0x6DEF2F0", VA = "0x186DEFEF0")]
		public FLGCOMKPPOL(PNOIEJNBDFJ JOKKIDPHPDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6DEFCF0", Offset = "0x6DEF0F0", VA = "0x186DEFCF0")]
		public FLGCOMKPPOL GIHLOONBFMD(string MHALMOGKEGG, string FFOEEMKIKJO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3D152E0", Offset = "0x3D146E0", VA = "0x183D152E0")]
		public FLGCOMKPPOL GIHLOONBFMD<T>(string MHALMOGKEGG, T FFOEEMKIKJO) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6DEFE70", Offset = "0x6DEF270", VA = "0x186DEFE70")]
		public FLGCOMKPPOL ODCJNBAEIHF(string MHALMOGKEGG, object FFOEEMKIKJO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3D15250", Offset = "0x3D14650", VA = "0x183D15250")]
		public FLGCOMKPPOL ADIEKOACJOA<T>(string MHALMOGKEGG, T? FFOEEMKIKJO) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6DEF6D0", Offset = "0x6DEEAD0", VA = "0x186DEF6D0")]
		public FLGCOMKPPOL ADIEKOACJOA(string MHALMOGKEGG, string FFOEEMKIKJO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6DEFBA0", Offset = "0x6DEEFA0", VA = "0x186DEFBA0")]
		public FLGCOMKPPOL EKHHHLGKHKN(string AFBBPENAHOE, string DJBLFBEBKGO, object HPMNBNLACCC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6DEFAC0", Offset = "0x6DEEEC0", VA = "0x186DEFAC0")]
		public FLGCOMKPPOL EKHHHLGKHKN(string AFBBPENAHOE, IDictionary<string, object> KLIMJMOCIDN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6DEF7A0", Offset = "0x6DEEBA0", VA = "0x186DEF7A0")]
		private static IDictionary<string, object> DBBMGDIKCMO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6DEF800", Offset = "0x6DEEC00", VA = "0x186DEF800")]
		public void EGMHIKFBPMK(bool PLPPFHCEAEH, string GBAKOMEKGHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6DEFD70", Offset = "0x6DEF170", VA = "0x186DEFD70")]
		public Task ILKOGDNGDHF([Optional] CancellationToken LMNHDKIFBOH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2665700", Offset = "0x2664B00", VA = "0x182665700", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x6DF09D0", Offset = "0x6DEFDD0", VA = "0x186DF09D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6DF0E50", Offset = "0x6DF0250", VA = "0x186DF0E50", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x9943E0", Offset = "0x9937E0", VA = "0x1809943E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6DF4340", Offset = "0x6DF3740", VA = "0x186DF4340")]
		private PNOIEJNBDFJ(string DEPLFLMGIOJ, int CBHDFIGALJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6DF39E0", Offset = "0x6DF2DE0", VA = "0x186DF39E0")]
		public static FLGCOMKPPOL GNHEPACBJCH(string DEPLFLMGIOJ, int CBHDFIGALJM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6DF4180", Offset = "0x6DF3580", VA = "0x186DF4180")]
		[AsyncStateMachine(typeof(GNBFBKLGNDK))]
		public Task ILKOGDNGDHF([Optional] CancellationToken LMNHDKIFBOH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6DF42D0", Offset = "0x6DF36D0", VA = "0x186DF42D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x33ED280", Offset = "0x33EC680", VA = "0x1833ED280")]
		internal void EEEMKBPNGMO<T>(string MHALMOGKEGG, T FFOEEMKIKJO) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6DF4270", Offset = "0x6DF3670", VA = "0x186DF4270")]
		internal void MFEMLIJOIED(string MHALMOGKEGG, object FFOEEMKIKJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6DF4120", Offset = "0x6DF3520", VA = "0x186DF4120")]
		internal void EEEMKBPNGMO(string MHALMOGKEGG, string FFOEEMKIKJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3D19DB0", Offset = "0x3D191B0", VA = "0x183D19DB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6DF2F90", Offset = "0x6DF2390", VA = "0x186DF2F90")]
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
		[Cpp2IlInjected.Address(RVA = "0x6DF2080", Offset = "0x6DF1480", VA = "0x186DF2080")]
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
		[Cpp2IlInjected.Address(RVA = "0x6DED470", Offset = "0x6DEC870", VA = "0x186DED470")]
		public BHNECDKLLLD(string OEFKCJGCGLP, Guid AEHCDHOPEIJ, long MOEFOOADDIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6DEC000", Offset = "0x6DEB400", VA = "0x186DEC000", Slot = "4")]
		public override void ADEBFJCPPCC(MBCNBKNDGJL CKIMLOEAHOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6DED390", Offset = "0x6DEC790", VA = "0x186DED390")]
		public void OJGAADHDDHI(short NMIOLBNOHGJ, bool DNDNDHFDLIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x46E22C0", Offset = "0x46E16C0", VA = "0x1846E22C0")]
		public void MHODLCFIBBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x993A60", Offset = "0x992E60", VA = "0x180993A60")]
		public void PHMOEOADMHP(string MBCLBIFELGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6DEC5B0", Offset = "0x6DEB9B0", VA = "0x186DEC5B0", Slot = "5")]
		public override void KPCFHFJPEKD(bool BHPHILLJABD, NCMOJDJJAAL KDDNDEANFAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6DEC2F0", Offset = "0x6DEB6F0", VA = "0x186DEC2F0", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x6DF3800", Offset = "0x6DF2C00", VA = "0x186DF3800")]
		public PAAGDKJDJLI(long NGNKEIBNEND, int IIJAFKKMMMN, string FENHOJHGFOB, long MOEFOOADDIC, int PKKFAHKKHII, string NOMLDKJCODG, short NMIOLBNOHGJ, string ANGFPEDLOLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6DF3640", Offset = "0x6DF2A40", VA = "0x186DF3640")]
		public void NEMFOHBKAMA(int IIJAFKKMMMN, string ANGFPEDLOLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6DF36D0", Offset = "0x6DF2AD0", VA = "0x186DF36D0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
			public FBCFHHDNPMM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6DEF090", Offset = "0x6DEE490", VA = "0x186DEF090")]
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
			[Cpp2IlInjected.Address(RVA = "0x6DF1250", Offset = "0x6DF0650", VA = "0x186DF1250", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6DF1F30", Offset = "0x6DF1330", VA = "0x186DF1F30", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x6DF2FD0", Offset = "0x6DF23D0", VA = "0x186DF2FD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6DF3560", Offset = "0x6DF2960", VA = "0x186DF3560", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x6DEBA00", Offset = "0x6DEAE00", VA = "0x186DEBA00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private static bool ANGFLBHFGJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x6DEB020", Offset = "0x6DEA420", VA = "0x186DEB020")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6DEB2D0", Offset = "0x6DEA6D0", VA = "0x186DEB2D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private static bool GHHGNBPFLBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6DEBC90", Offset = "0x6DEB090", VA = "0x186DEBC90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6DEB7E0", Offset = "0x6DEABE0", VA = "0x186DEB7E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private static float KCELAJMCKAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6DEBA50", Offset = "0x6DEAE50", VA = "0x186DEBA50")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6DEB070", Offset = "0x6DEA470", VA = "0x186DEB070")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6DEBB70", Offset = "0x6DEAF70", VA = "0x186DEBB70")]
		[FHKEPBLDBGP.MANFMCGMCFL]
		internal static void PGPIHOOHKBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6DEB0D0", Offset = "0x6DEA4D0", VA = "0x186DEB0D0")]
		internal static void GDCNGOALEGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6DEB840", Offset = "0x6DEAC40", VA = "0x186DEB840")]
		internal static void MIPAEFEDIJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6DEAB00", Offset = "0x6DE9F00", VA = "0x186DEAB00")]
		internal static void BAEFDCJFDHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6DEAB70", Offset = "0x6DE9F70", VA = "0x186DEAB70")]
		public static void BFIDELGLGEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6DEABC0", Offset = "0x6DE9FC0", VA = "0x186DEABC0")]
		private static void CBBEIIEODFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6DEB330", Offset = "0x6DEA730", VA = "0x186DEB330")]
		private static void HCBAGEFLKDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6DEBAA0", Offset = "0x6DEAEA0", VA = "0x186DEBAA0")]
		[AsyncStateMachine(typeof(KNIGNEEKFGO))]
		private static Task PGIHJGNFBBM(CancellationToken LMNHDKIFBOH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6DEB700", Offset = "0x6DEAB00", VA = "0x186DEB700")]
		private static void LDBCDILEGGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6DEB620", Offset = "0x6DEAA20", VA = "0x186DEB620")]
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
		private sealed class JDLFHAGKJOE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public LGPNNNBBMEN<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
			public JDLFHAGKJOE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x4BE03F0", Offset = "0x4BDF7F0", VA = "0x184BE03F0")]
			internal object NFOHMBMHHCL()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class OEGCKCOEOKO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public LGPNNNBBMEN<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
			public OEGCKCOEOKO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x51E13C0", Offset = "0x51E07C0", VA = "0x1851E13C0")]
			internal object ICMGDJCIIIG()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class FKDGLOPNOIJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public LGPNNNBBMEN<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
			public FKDGLOPNOIJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x4747880", Offset = "0x4746C80", VA = "0x184747880")]
			internal object IBNGMGKGNND()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class JJKCALMOFAJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public LGPNNNBBMEN<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
			public JJKCALMOFAJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x4BEE1E0", Offset = "0x4BED5E0", VA = "0x184BEE1E0")]
			internal object AGCHKLPAAAL()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class MIFILLLGINE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public LGPNNNBBMEN<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
			public MIFILLLGINE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x5040C90", Offset = "0x5040090", VA = "0x185040C90")]
			internal object PFANKMBAONO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class MKOOBHFLBPE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public LGPNNNBBMEN<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
			public MKOOBHFLBPE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x504B570", Offset = "0x504A970", VA = "0x18504B570")]
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
		private readonly Dictionary<T, string[]> KBEHBJOHDPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private string GOHINGHGDKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private bool KHGFHBLNDOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private Task HIEJNLLLMJN;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x4E40440", Offset = "0x4E3F840", VA = "0x184E40440")]
		public LGPNNNBBMEN(Guid HFGKEOIDFDA, string EAPMAEBMDOL, string NOMLDKJCODG, string FEAKAHCFMLE, [Optional] string KGJJFDHPDEM, [Optional] string LHOBLOPMBGJ, [Optional] string ININGBKACJG, [Optional] string OALMNODDCGJ, [Optional] string GOHINGHGDKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x994400", Offset = "0x993800", VA = "0x180994400")]
		public void OMBDCHDMPOB(string KGJJFDHPDEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x99E210", Offset = "0x99D610", VA = "0x18099E210")]
		public void MEKEEGLKPHI(string FEAKAHCFMLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xCD2600", Offset = "0xCD1A00", VA = "0x180CD2600")]
		public void EGNCJIJFDIA(string GOHINGHGDKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x993AD0", Offset = "0x992ED0", VA = "0x180993AD0")]
		public void LHCHIPPJFJN(string IKFCMBNJHFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x993A60", Offset = "0x992E60", VA = "0x180993A60")]
		public void EPIFJCENEMO(string CHHIMIDMPFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x993AC0", Offset = "0x992EC0", VA = "0x180993AC0")]
		public void IJFFIIFFGNM(string DLIBGJPNJCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x4E3FC80", Offset = "0x4E3F080", VA = "0x184E3FC80")]
		public void OMDGOEDPJLK(Guid? HFGKEOIDFDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x485A120", Offset = "0x4859520", VA = "0x18485A120")]
		public void HPGKCNEGOLI((int, int)? AFFLGGJINKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x993A90", Offset = "0x992E90", VA = "0x180993A90")]
		public void MLIGNBBFPJN(string LCOBKOFCMBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x4E3F2A0", Offset = "0x4E3E6A0", VA = "0x184E3F2A0")]
		public void IMIGMOEHLPI(T KKPLNEGHAEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x4E3C6C0", Offset = "0x4E3BAC0", VA = "0x184E3C6C0")]
		public void HMDAGHNMGAI(T KKPLNEGHAEJ, int MGJKHGIOGBA, float HLOBKBPABIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x4E3FCA0", Offset = "0x4E3F0A0", VA = "0x184E3FCA0")]
		public void PPHNLANBAGP(T KKPLNEGHAEJ, int MGJKHGIOGBA, string GOLPONGHJGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x4E3BB60", Offset = "0x4E3AF60", VA = "0x184E3BB60")]
		public void FDFIOJBEHAI(T KKPLNEGHAEJ, string MFANEJFBEMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x4E3A7D0", Offset = "0x4E39BD0", VA = "0x184E3A7D0")]
		public void CJCPNKOLNKP(T KKPLNEGHAEJ, string FFIAEICHPDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x4E3F780", Offset = "0x4E3EB80", VA = "0x184E3F780")]
		public void LNCAKIHELOK(T KKPLNEGHAEJ, string[] ODLNJODKJEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x4E3D720", Offset = "0x4E3CB20", VA = "0x184E3D720")]
		public Task ILKOGDNGDHF(bool HLPBIKLHEBD = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x4E399E0", Offset = "0x4E38DE0", VA = "0x184E399E0")]
		private (IEnumerable<T>, string) ANOBLHIMJMK()
		{
			return default((IEnumerable<T>, string));
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x4E3B5A0", Offset = "0x4E3A9A0", VA = "0x184E3B5A0")]
		public static FLGCOMKPPOL EMIMOIBPAHH(Guid HFGKEOIDFDA, string EAPMAEBMDOL, T KKPLNEGHAEJ, string NOMLDKJCODG, string BEHODDLGDFE, string KGJJFDHPDEM, int? CJFNAFNJJLB, [Optional] string MDOFIJAEFBE, [Optional] string MFANEJFBEMD, [Optional] int? CGOIBEDPACB, [Optional] Guid? LAMNAHMGJFN, [Optional] string GOHINGHGDKI, [Optional] string FENHOJHGFOB, [Optional] (int, int)? AFFLGGJINKB, [Optional] string BFADAKPFOCB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x4E3F6F0", Offset = "0x4E3EAF0", VA = "0x184E3F6F0")]
		[CompilerGenerated]
		private string JPEEFNIGCBP(T NCJKGMLAKGH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x4E3BF40", Offset = "0x4E3B340", VA = "0x184E3BF40")]
		[CompilerGenerated]
		private string FMPOLLFPCAO(T NCJKGMLAKGH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x4E3AB30", Offset = "0x4E39F30", VA = "0x184E3AB30")]
		[CompilerGenerated]
		private string EBGLHECOAFK(T NCJKGMLAKGH)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public abstract class EPABBHAIMLE<TItem, TListSessionStartParams, TListSessionLogParams>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		protected readonly string OEFKCJGCGLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		protected readonly Guid AEHCDHOPEIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		protected readonly long MOEFOOADDIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		protected int IIJAFKKMMMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		protected int GHLDNFELGDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		protected DateTime MDMPOIKMEDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		protected bool KHPCCBPLGGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		protected Dictionary<long, NCHJOOIBKKD> HBAGOGFOMKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		protected bool KPHHMLIJDOJ;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool ECMLJIKMDCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xB583E0", Offset = "0xB577E0", VA = "0x180B583E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool DFMDHMFOCGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xBBC590", Offset = "0xBBB990", VA = "0x180BBC590")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x42EB510", Offset = "0x42EA910", VA = "0x1842EB510")]
		public EPABBHAIMLE(string OEFKCJGCGLP, Guid AEHCDHOPEIJ, long MOEFOOADDIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void ADEBFJCPPCC(TListSessionStartParams CKIMLOEAHOK);

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x42DB6D0", Offset = "0x42DAAD0", VA = "0x1842DB6D0")]
		public void NCONGPIMOOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void KPCFHFJPEKD(bool BHPHILLJABD, TListSessionLogParams KDDNDEANFAB);

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x42EB2D0", Offset = "0x42EA6D0", VA = "0x1842EB2D0")]
		public void GCABLJHNBNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x42EB1B0", Offset = "0x42EA5B0", VA = "0x1842EB1B0")]
		public void BBCLAPNBLFF(long NGNKEIBNEND, int CJFNAFNJJLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x42EB320", Offset = "0x42EA720", VA = "0x1842EB320")]
		public void HGNBBBEGPKH(long NGNKEIBNEND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract NCHJOOIBKKD IIJOAJMBPGL(TItem MGCEJOCCONP, int CJFNAFNJJLB, string OEOPIEBOEBM);
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class NCHJOOIBKKD : HGDCBAGGPBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private int IIJAFKKMMMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private long NGNKEIBNEND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private long MOEFOOADDIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private readonly string FMGJDKGOACK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly string GPDLHAIKKBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly int PKKFAHKKHII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private DateTime AEKHPPFJCAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private double GEIPADBBEDO;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool MIDPHKNGKPI
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xD7CFA0", Offset = "0xD7C3A0", VA = "0x180D7CFA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xD7CAA0", Offset = "0xD7BEA0", VA = "0x180D7CAA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6DF2EC0", Offset = "0x6DF22C0", VA = "0x186DF2EC0")]
		public NCHJOOIBKKD(long NGNKEIBNEND, int IIJAFKKMMMN, string FENHOJHGFOB, long MOEFOOADDIC, int PKKFAHKKHII, [Optional] string NOMLDKJCODG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6DF27D0", Offset = "0x6DF1BD0", VA = "0x186DF27D0")]
		public void ECCKGKDJOJM(int IIJAFKKMMMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6DF28B0", Offset = "0x6DF1CB0", VA = "0x186DF28B0")]
		public void LEALILMKDEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6DF2900", Offset = "0x6DF1D00", VA = "0x186DF2900")]
		public void OPBFHAMJFBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6DF2840", Offset = "0x6DF1C40", VA = "0x186DF2840")]
		private void IGAHPGHFGIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6DF2A10", Offset = "0x6DF1E10", VA = "0x186DF2A10", Slot = "5")]
		public virtual FLGCOMKPPOL PHKKOJKCGHE(Guid HFGKEOIDFDA, string AIMHGJBNJON, [Optional] string FENHOJHGFOB, [Optional] long? KKPLNEGHAEJ, [Optional] string NOMLDKJCODG, [Optional] string KGJJFDHPDEM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class EBDNLDBAKDK
	{
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static Dictionary<string, Dictionary<string, object>> NDHPIKKJPJP;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static string FGIAOECMDKH;

		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private static int HBOABMIMIOK;

		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private static readonly Dictionary<string, EBNONHEMBKN> MGCPHNMDHMB;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static string DNBKCKHMJNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x6DEE650", Offset = "0x6DEDA50", VA = "0x186DEE650")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x6DEEE70", Offset = "0x6DEE270", VA = "0x186DEEE70")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static bool KBOEPCKGGGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x6DEE710", Offset = "0x6DEDB10", VA = "0x186DEE710")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static Dictionary<string, Dictionary<string, object>> CEHIOIMJIJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x6DEEDC0", Offset = "0x6DEE1C0", VA = "0x186DEEDC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static Guid? HEDEFCIFILJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x6DEE200", Offset = "0x6DED600", VA = "0x186DEE200")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x6DEEE10", Offset = "0x6DEE210", VA = "0x186DEEE10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static Guid? FKBNHIJLAAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x6DEE6A0", Offset = "0x6DEDAA0", VA = "0x186DEE6A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x6DEED60", Offset = "0x6DEE160", VA = "0x186DEED60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6DEE990", Offset = "0x6DEDD90", VA = "0x186DEE990")]
		public static void MHBBBCOFEDF(string OJMDGNNBLDJ, EBNONHEMBKN OEBIOLCHBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6DEE270", Offset = "0x6DED670", VA = "0x186DEE270")]
		internal static void GDCNGOALEGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6DEEA20", Offset = "0x6DEDE20", VA = "0x186DEEA20")]
		internal static void MIPAEFEDIJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6DEDB70", Offset = "0x6DECF70", VA = "0x186DEDB70")]
		internal static void BAEFDCJFDHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6DED590", Offset = "0x6DEC990", VA = "0x186DED590")]
		public static Guid ADEBFJCPPCC(string OJMDGNNBLDJ, [Optional] string? GJOOCNMAEBG, [Optional] Dictionary<string, object>? FMHCHJFMBBF)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6DED4F0", Offset = "0x6DEC8F0", VA = "0x186DED4F0")]
		public static Guid ADEBFJCPPCC(string OJMDGNNBLDJ, long GJOOCNMAEBG, [Optional] Dictionary<string, object>? FMHCHJFMBBF)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6DEEB00", Offset = "0x6DEDF00", VA = "0x186DEEB00")]
		public static void NCONGPIMOOE(string OJMDGNNBLDJ, [Optional] Guid? KDBHLLEACIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6DEDFF0", Offset = "0x6DED3F0", VA = "0x186DEDFF0")]
		public static void DIBNIJLLPDL(string OJMDGNNBLDJ, string AFBBPENAHOE, object FAAAGMNPMBA, bool JMMMCBGFHAG = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6DEE7A0", Offset = "0x6DEDBA0", VA = "0x186DEE7A0")]
		public static bool JPDFJNGLICI(string OJMDGNNBLDJ, [Optional] string? GJOOCNMAEBG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6DEE3B0", Offset = "0x6DED7B0", VA = "0x186DEE3B0")]
		private static void GLLBEGJFFKC(bool AFCDIPMDOIB = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6DEE350", Offset = "0x6DED750", VA = "0x186DEE350")]
		public static void GHHFOPOLGFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6DEE530", Offset = "0x6DED930", VA = "0x186DEE530")]
		private static void HCBAGEFLKDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6DEDBF0", Offset = "0x6DECFF0", VA = "0x186DEDBF0")]
		private static void BFCCJGCNCLM(string OJMDGNNBLDJ, Guid HFGKEOIDFDA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public static class FPNEKLKOFCH
	{
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public struct PBGGEGCGGJB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public bool JKLFEMENKBM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public string EGKFIDEDPCL;

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xB70900", Offset = "0xB6FD00", VA = "0x180B70900")]
			public PBGGEGCGGJB(bool JKLFEMENKBM, string EGKFIDEDPCL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6DF05B0", Offset = "0x6DEF9B0", VA = "0x186DF05B0")]
		public static PBGGEGCGGJB GFDFDHMHGGA(FLGCOMKPPOL EFJCDOLBLCP)
		{
			return default(PBGGEGCGGJB);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6DF08D0", Offset = "0x6DEFCD0", VA = "0x186DF08D0")]
		private static void KLLKFEICNNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6DF04F0", Offset = "0x6DEF8F0", VA = "0x186DF04F0")]
		private static void BGEOBMAEDDH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class KOIAGFDHCGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6DF1F90", Offset = "0x6DF1390", VA = "0x186DF1F90")]
		public static FLGCOMKPPOL GNPGADAGJCJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class FJGKILHJPNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6DEF1F0", Offset = "0x6DEE5F0", VA = "0x186DEF1F0")]
		public static FLGCOMKPPOL BIJAMAIJODO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6DEF4F0", Offset = "0x6DEE8F0", VA = "0x186DEF4F0")]
		public static FLGCOMKPPOL IHDECPCEOPF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6DEF2B0", Offset = "0x6DEE6B0", VA = "0x186DEF2B0")]
		public static FLGCOMKPPOL CKIPPJBFMPI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6DEF370", Offset = "0x6DEE770", VA = "0x186DEF370")]
		public static FLGCOMKPPOL FGFDAAPANDF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6DEF310", Offset = "0x6DEE710", VA = "0x186DEF310")]
		public static FLGCOMKPPOL FFNFILFHHLJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6DEF490", Offset = "0x6DEE890", VA = "0x186DEF490")]
		public static FLGCOMKPPOL HFBBAGDGIJE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6DEF5B0", Offset = "0x6DEE9B0", VA = "0x186DEF5B0")]
		public static FLGCOMKPPOL JMIEJCPCKLB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6DEF670", Offset = "0x6DEEA70", VA = "0x186DEF670")]
		public static FLGCOMKPPOL PEDLJDELOHM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6DEF190", Offset = "0x6DEE590", VA = "0x186DEF190")]
		public static FLGCOMKPPOL BHDOKOHOHOD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6DEF430", Offset = "0x6DEE830", VA = "0x186DEF430")]
		public static FLGCOMKPPOL GJAFCFKBHDL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6DEF3D0", Offset = "0x6DEE7D0", VA = "0x186DEF3D0")]
		public static FLGCOMKPPOL GHLMKFAGCHK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6DEF130", Offset = "0x6DEE530", VA = "0x186DEF130")]
		public static FLGCOMKPPOL AMJFCJLJMDO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6DEF610", Offset = "0x6DEEA10", VA = "0x186DEF610")]
		public static FLGCOMKPPOL LJJHCGNFAIG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6DEF550", Offset = "0x6DEE950", VA = "0x186DEF550")]
		public static FLGCOMKPPOL JCABDFEOKIM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6DEF250", Offset = "0x6DEE650", VA = "0x186DEF250")]
		public static FLGCOMKPPOL BKFPMLLNGKE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class PNLGIOAALEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6DF3F40", Offset = "0x6DF3340", VA = "0x186DF3F40")]
		public static FLGCOMKPPOL HJMGCMFJBPM(long MIFADOBCMAC, long JCNNPHFBOMP, bool EHDMCOLJNFJ, string IKCHPENKGOI, string JOLAMBIJHCI)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class IKAOFDHBCHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6DF0EB0", Offset = "0x6DF02B0", VA = "0x186DF0EB0")]
		public static FLGCOMKPPOL NNLHPNFIINM(string BABBIPKFFLI, string COADNPMEKFL, bool NGGCIJBEPBH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6DF1020", Offset = "0x6DF0420", VA = "0x186DF1020")]
		public static FLGCOMKPPOL OILBALOGNEP(string PCJJKLDOJMD, string NADHILHOIBL, string OGPEAJMIILP, [Optional] int? EFBIIFKIJGK, [Optional] double[] CKLKNJHOJKJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class MFHKLBFKIOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6DF26F0", Offset = "0x6DF1AF0", VA = "0x186DF26F0")]
		public static FLGCOMKPPOL OCMHKOEBCBA(string LOCMJNMJHBC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6DF2130", Offset = "0x6DF1530", VA = "0x186DF2130")]
		public static FLGCOMKPPOL GLGMCGHGLPM(string OPICNDKBMLI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6DF20D0", Offset = "0x6DF14D0", VA = "0x186DF20D0")]
		public static FLGCOMKPPOL BACBHAGHJLN(int CBHDFIGALJM, string IGEPDAOOLBO, string NCJKGMLAKGH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6DF2420", Offset = "0x6DF1820", VA = "0x186DF2420")]
		public static FLGCOMKPPOL KOBFFNPKFML(int CBHDFIGALJM, string IGEPDAOOLBO, string NCJKGMLAKGH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x6DF2360", Offset = "0x6DF1760", VA = "0x186DF2360")]
		public static FLGCOMKPPOL JKIAOFFAFCG(int CBHDFIGALJM, string IGEPDAOOLBO, string NCJKGMLAKGH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6DF23C0", Offset = "0x6DF17C0", VA = "0x186DF23C0")]
		public static FLGCOMKPPOL KLLCKICMGAM(int CBHDFIGALJM, string IGEPDAOOLBO, string NCJKGMLAKGH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6DF2210", Offset = "0x6DF1610", VA = "0x186DF2210")]
		public static FLGCOMKPPOL IOIGIANMANL(string IGEPDAOOLBO, string NCJKGMLAKGH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6DF25B0", Offset = "0x6DF19B0", VA = "0x186DF25B0")]
		private static FLGCOMKPPOL NMHAOFEPMFF(string OEFKCJGCGLP, int CBHDFIGALJM, string CPCLCGPKBAL, string IAICLKLPDLA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x6DF2480", Offset = "0x6DF1880", VA = "0x186DF2480")]
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
		[Cpp2IlInjected.Address(RVA = "0x6DF38F0", Offset = "0x6DF2CF0", VA = "0x186DF38F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6DF3B70", Offset = "0x6DF2F70", VA = "0x186DF3B70")]
	[FHKEPBLDBGP.MANFMCGMCFL]
	internal static void LGJOAGMPKDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6DF3C70", Offset = "0x6DF3070", VA = "0x186DF3C70")]
	private static void MAKONFNGNML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6DF3AF0", Offset = "0x6DF2EF0", VA = "0x186DF3AF0")]
	public static FLGCOMKPPOL EINOPMGEIOK(string DEPLFLMGIOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6DF39E0", Offset = "0x6DF2DE0", VA = "0x186DF39E0")]
	public static FLGCOMKPPOL EINOPMGEIOK(string DEPLFLMGIOJ, int CBHDFIGALJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6DF3D40", Offset = "0x6DF3140", VA = "0x186DF3D40")]
	public static bool NBMCGELHGBK(this NNOOHIAHMIG NABFLDFFLBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6DF3DB0", Offset = "0x6DF31B0", VA = "0x186DF3DB0")]
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
