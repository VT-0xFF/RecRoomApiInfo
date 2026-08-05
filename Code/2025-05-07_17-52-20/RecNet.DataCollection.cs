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
		[Cpp2IlInjected.Address(RVA = "0xA1A700", Offset = "0xA19700", VA = "0x180A1A700")]
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
		[Cpp2IlInjected.Address(RVA = "0x718BE00", Offset = "0x718AE00", VA = "0x18718BE00")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA1B220", Offset = "0xA1A220", VA = "0x180A1B220")]
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
		[Cpp2IlInjected.Address(RVA = "0xA1B260", Offset = "0xA1A260", VA = "0x180A1B260")]
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
	public class LogRegistrationIndex : BPLGCOBKJGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x71895E0", Offset = "0x71885E0", VA = "0x1871895E0", Slot = "4")]
		public override void AMBIAOGNIIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA1A700", Offset = "0xA19700", VA = "0x180A1A700")]
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
		[Cpp2IlInjected.Address(RVA = "0x718C190", Offset = "0x718B190", VA = "0x18718C190", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2643640", Offset = "0x2642640", VA = "0x182643640")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface KEDPLDMFOHA
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyDictionary<string, object> CLJMPPBMAMB();
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class NKKAMPCFIIO
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x718BD90", Offset = "0x718AD90", VA = "0x18718BD90")]
	public static void NFBPFAJJMBN(this NBPJJLNGOFA.HBCMGLBMNOC BCLLJEOCNAG, string BDJPEELILNM, string GHNKKPBGKOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x718BC00", Offset = "0x718AC00", VA = "0x18718BC00")]
	public static void NFBPFAJJMBN(this NBPJJLNGOFA.HBCMGLBMNOC BCLLJEOCNAG, string BDJPEELILNM, bool GHNKKPBGKOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x718BC90", Offset = "0x718AC90", VA = "0x18718BC90")]
	public static void NFBPFAJJMBN(this NBPJJLNGOFA.HBCMGLBMNOC BCLLJEOCNAG, string BDJPEELILNM, float OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x718B8B0", Offset = "0x718A8B0", VA = "0x18718B8B0")]
	public static void NFBPFAJJMBN(this NBPJJLNGOFA.HBCMGLBMNOC BCLLJEOCNAG, string BDJPEELILNM, JHOOMDLCLDA GHNKKPBGKOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class NBPJJLNGOFA
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface KIMAPJGMAHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		HBCMGLBMNOC DHDBOIIHPLO(Guid PNBLCEBBDDJ, string CGOFEFPLIIG, [Optional] string ECCMNPFGGHH, [Optional] long? HOLMDHKIDEL, [Optional] string FCFOPGKFBIG, [Optional] string CNMDBOEOLJA);
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MNHJNDHBKCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x718AB70", Offset = "0x7189B70", VA = "0x18718AB70")]
		public static HBCMGLBMNOC JOGGDGIFPIK(Guid PNBLCEBBDDJ, string CGOFEFPLIIG, string ECCMNPFGGHH, [Optional] long? HOLMDHKIDEL, [Optional] string FCFOPGKFBIG, [Optional] string CNMDBOEOLJA)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class HBCMGLBMNOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		protected BGFACPEPMJN NKBJHKLGFDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly IDictionary<string, IDictionary<string, object>> OGGJDHCCCMJ;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool PEAKIIMCCAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x71850B0", Offset = "0x71840B0", VA = "0x1871850B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public string IMHLPEOHJFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x10C9580", Offset = "0x10C8580", VA = "0x1810C9580")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7185860", Offset = "0x7184860", VA = "0x187185860")]
		public HBCMGLBMNOC(BGFACPEPMJN NKBJHKLGFDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x71850F0", Offset = "0x71840F0", VA = "0x1871850F0")]
		public HBCMGLBMNOC GHPDPAGFDDO(string LLPAKFGNDOB, string OHLIHBDBKCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3F07480", Offset = "0x3F06480", VA = "0x183F07480")]
		public HBCMGLBMNOC GHPDPAGFDDO<T>(string LLPAKFGNDOB, T OHLIHBDBKCE) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7185520", Offset = "0x7184520", VA = "0x187185520")]
		public HBCMGLBMNOC NDIMNKGOHDA(string LLPAKFGNDOB, object OHLIHBDBKCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3F078B0", Offset = "0x3F068B0", VA = "0x183F078B0")]
		public HBCMGLBMNOC KGFPFPHCOIH<T>(string LLPAKFGNDOB, T? OHLIHBDBKCE) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7185390", Offset = "0x7184390", VA = "0x187185390")]
		public HBCMGLBMNOC KGFPFPHCOIH(string LLPAKFGNDOB, string OHLIHBDBKCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7185170", Offset = "0x7184170", VA = "0x187185170")]
		public HBCMGLBMNOC HDJDONOHIME(string AHHGAKODFMI, string OEHHKNIGGMI, object APDBNIMCPID)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x71852B0", Offset = "0x71842B0", VA = "0x1871852B0")]
		public HBCMGLBMNOC HDJDONOHIME(string AHHGAKODFMI, IDictionary<string, object> PFOGKPFJJDP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7185050", Offset = "0x7184050", VA = "0x187185050")]
		private static IDictionary<string, object> CJHBODDPHMJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x71855A0", Offset = "0x71845A0", VA = "0x1871855A0")]
		public void PACMCPBDCCL(bool MGFPPIECFNK, string LDPLFLCJNKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7185420", Offset = "0x7184420", VA = "0x187185420")]
		public Task MJHBJEIBFGO([Optional] CancellationToken CBJPDIFOEKF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2778820", Offset = "0x2777820", VA = "0x182778820", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class BGFACPEPMJN
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private struct ICAANEAFBBF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public BGFACPEPMJN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x71874A0", Offset = "0x71864A0", VA = "0x1871874A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7187920", Offset = "0x7186920", VA = "0x187187920", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static Action<BGFACPEPMJN> ADOKPCNNIDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly string MJDGLECFFEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly Dictionary<string, object> GBAFJNKMEMH;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string IMHLPEOHJFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7182640", Offset = "0x7181640", VA = "0x187182640")]
		private BGFACPEPMJN(string MJDGLECFFEI, int BEKCOFDFFEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7182310", Offset = "0x7181310", VA = "0x187182310")]
		public static HBCMGLBMNOC FLLMCNLHKNL(string MJDGLECFFEI, int BEKCOFDFFEG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x71824E0", Offset = "0x71814E0", VA = "0x1871824E0")]
		[AsyncStateMachine(typeof(ICAANEAFBBF))]
		public Task MJHBJEIBFGO([Optional] CancellationToken CBJPDIFOEKF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x71825D0", Offset = "0x71815D0", VA = "0x1871825D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x38452F0", Offset = "0x38442F0", VA = "0x1838452F0")]
		internal void LCAGAJBPCNC<T>(string LLPAKFGNDOB, T OHLIHBDBKCE) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7182420", Offset = "0x7181420", VA = "0x187182420")]
		internal void JEGLKKJJHEO(string LLPAKFGNDOB, object OHLIHBDBKCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7182480", Offset = "0x7181480", VA = "0x187182480")]
		internal void LCAGAJBPCNC(string LLPAKFGNDOB, string OHLIHBDBKCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3F05970", Offset = "0x3F04970", VA = "0x183F05970")]
		private void FNFCOELJLBF<T>(string LLPAKFGNDOB, T OHLIHBDBKCE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct EIKLINDABAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly string HADHAGFHHHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly long? BJFFDFGEMMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly short? GKBGBGJOAII;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x71842C0", Offset = "0x71832C0", VA = "0x1871842C0")]
		public EIKLINDABAE(string BIHAOJMPOLE, [Optional] long? CINEDGEJAIA, [Optional] short? NADJAOLCKFN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct EMEJBFGCOIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly int CLJAGNADBHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public readonly string OFINDKAEPPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly short BMAKFGJEMLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public readonly string OMCEOBMAEBH;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7184A00", Offset = "0x7183A00", VA = "0x187184A00")]
		public EMEJBFGCOIK(int EJIAAGACFNJ, string KOHBLPNDNGM, short ODGLGDKJENI, string FNBFEPHILEG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class MELDGLKLIHM : MKPJHBCDNLL<DCBLOAAJLDM, EMEJBFGCOIK, EIKLINDABAE>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private string KOHBLPNDNGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private short ODGLGDKJENI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private string FNBFEPHILEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private Dictionary<short, int> OBIONCPEEKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private int HHDBPPPLEEG;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x718AAF0", Offset = "0x7189AF0", VA = "0x18718AAF0")]
		public MELDGLKLIHM(string AFDMOCAAEDI, Guid KNNPGFGHKBD, long HGNFJDEKKID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7189750", Offset = "0x7188750", VA = "0x187189750", Slot = "4")]
		public override void FEBPIFHOGNC(EMEJBFGCOIK CAFJEEJDCIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7189670", Offset = "0x7188670", VA = "0x187189670")]
		public void DBPNFBMAIGK(short ODGLGDKJENI, bool KAAFEKILFMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x49230D0", Offset = "0x49220D0", VA = "0x1849230D0")]
		public void IGLBEGEBCOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9F4CD0", Offset = "0x9F3CD0", VA = "0x1809F4CD0")]
		public void ENKONHMMGGH(string BDJILOJOCKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7189D00", Offset = "0x7188D00", VA = "0x187189D00", Slot = "5")]
		public override void LDLBODBAOPP(bool DCJDFHHHEHM, EIKLINDABAE EBHIEGHNIPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7189A40", Offset = "0x7188A40", VA = "0x187189A40", Slot = "6")]
		public override JOMIJLHDOOP HILKANPMIAO(DCBLOAAJLDM OBBHHGNJBLD, int OHHMJGCBCKD, string GIJNGCIEONA)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class CAADBMDNPNC : JOMIJLHDOOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private string KOHBLPNDNGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly short ODGLGDKJENI;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7182B50", Offset = "0x7181B50", VA = "0x187182B50")]
		public CAADBMDNPNC(long JPEKMHAKLEC, int EJIAAGACFNJ, string ECCMNPFGGHH, long HGNFJDEKKID, int EIPFLNHHDGF, string FCFOPGKFBIG, short ODGLGDKJENI, string KOHBLPNDNGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7182AC0", Offset = "0x7181AC0", VA = "0x187182AC0")]
		public void FIDOHFAGMKP(int EJIAAGACFNJ, string KOHBLPNDNGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7182990", Offset = "0x7181990", VA = "0x187182990", Slot = "5")]
		public override HBCMGLBMNOC DHDBOIIHPLO(Guid PNBLCEBBDDJ, string CGOFEFPLIIG, [Optional] string ECCMNPFGGHH, [Optional] long? HOLMDHKIDEL, [Optional] string FCFOPGKFBIG, [Optional] string CNMDBOEOLJA)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class EHBAFJBLCHD
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class KLCKDFCALKF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public float nextEventSendTime;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public KLCKDFCALKF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x7188620", Offset = "0x7187620", VA = "0x187188620")]
			internal bool NKJACBCICHA()
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private struct LNJBNNELDGI : IAsyncStateMachine
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
			private KLCKDFCALKF <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private TimeSpan <delayPollingInterval>5__2;

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x71888A0", Offset = "0x71878A0", VA = "0x1871888A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x7189580", Offset = "0x7188580", VA = "0x187189580", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private struct NDHLFLJLJBE : IAsyncStateMachine
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
			[Cpp2IlInjected.Address(RVA = "0x718B2C0", Offset = "0x718A2C0", VA = "0x18718B2C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x718B850", Offset = "0x718A850", VA = "0x18718B850", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public static readonly float OHIKADHBELE;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static JAHOCBPGMLL AJHJEIPEGEF;

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static CancellationTokenSource ILBJBAGMPKL;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static bool OFPCAPCHNEP;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private static int AACDMKIMOCD;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static readonly KICNHCAEGMA<HBCMGLBMNOC, bool> FPGJIEEEFHD;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static DAGLKFFOOFC<HBCMGLBMNOC, bool> OOGIHPNKIHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x71833F0", Offset = "0x71823F0", VA = "0x1871833F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private static bool NGBGAKOJIHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x7184160", Offset = "0x7183160", VA = "0x187184160")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7183520", Offset = "0x7182520", VA = "0x187183520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private static bool ENCFKGKEIPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7183720", Offset = "0x7182720", VA = "0x187183720")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7184100", Offset = "0x7183100", VA = "0x187184100")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private static float KOGEGPKJHNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7182FE0", Offset = "0x7181FE0", VA = "0x187182FE0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x7183580", Offset = "0x7182580", VA = "0x187183580")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7183F90", Offset = "0x7182F90", VA = "0x187183F90")]
		[FHOLJFNIKPC.CJBPAKNLBCK]
		internal static void NHGLDOFJBBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7183030", Offset = "0x7182030", VA = "0x187183030")]
		internal static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7183230", Offset = "0x7182230", VA = "0x187183230")]
		internal static void AOJNBLCPAHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x71835E0", Offset = "0x71825E0", VA = "0x1871835E0")]
		internal static void HEPPGPLHCBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x71840B0", Offset = "0x71830B0", VA = "0x1871840B0")]
		public static void OKKNKFBEHIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7183850", Offset = "0x7182850", VA = "0x187183850")]
		private static void KJCDEAJGEBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7183CA0", Offset = "0x7182CA0", VA = "0x187183CA0")]
		private static void MCEGJKOFHME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7183650", Offset = "0x7182650", VA = "0x187183650")]
		[AsyncStateMachine(typeof(LNJBNNELDGI))]
		private static Task IGMCHNDDIEO(CancellationToken CBJPDIFOEKF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7183770", Offset = "0x7182770", VA = "0x187183770")]
		private static void KGEEIBIJGMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7183440", Offset = "0x7182440", VA = "0x187183440")]
		[AsyncStateMachine(typeof(NDHLFLJLJBE))]
		private static Task DLOIKCCLOIC(bool HKMPIPHJEJE, [Optional] CancellationToken CBJPDIFOEKF)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class HGCIILPAOHO<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class ECBFDFFDCIH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public HGCIILPAOHO<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public ECBFDFFDCIH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x44B87D0", Offset = "0x44B77D0", VA = "0x1844B87D0")]
			internal object GPILHKCOAFP()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class NGHPMPIFMKC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public HGCIILPAOHO<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public NGHPMPIFMKC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x53BDD60", Offset = "0x53BCD60", VA = "0x1853BDD60")]
			internal object EKECKLFKJHJ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class MBDGGAGOAFA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public HGCIILPAOHO<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public MBDGGAGOAFA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x5305A60", Offset = "0x5304A60", VA = "0x185305A60")]
			internal object FKHBNCKAPGN()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class ICBDDNGKLPO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public HGCIILPAOHO<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public ICBDDNGKLPO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x4BED470", Offset = "0x4BEC470", VA = "0x184BED470")]
			internal object DKNMBEJIGPD()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class NPDKKLCAFIA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public HGCIILPAOHO<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public NPDKKLCAFIA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x5408370", Offset = "0x5407370", VA = "0x185408370")]
			internal object ADHLMIBOHNL()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class BEMBLCFDDNB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public HGCIILPAOHO<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public BEMBLCFDDNB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x61C00E0", Offset = "0x61BF0E0", VA = "0x1861C00E0")]
			internal object PECPEDBCAPB()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class AIPBINKCKNP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public HGCIILPAOHO<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public AIPBINKCKNP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x4C73180", Offset = "0x4C72180", VA = "0x184C73180")]
			internal object MFBEBCPAIIE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private const float FPDBIKLBKOL = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly Guid PNBLCEBBDDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly string FCFOPGKFBIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly string HGFPICLPGIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private string HEGEOEOBFLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private string CNMDBOEOLJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private string FICOAOJDBGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private string PAMBDHFHDKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private string KGKCNEHOGIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private string HOAPHMNCGOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private string PHLGJGDIMNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private string AEBOBCGKFDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private string FOAJDBHIJHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Guid? ECPKJHBKKOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private (int, int)? JLDCIIIAHPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly HashSet<T> HAHNGLAANDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly Dictionary<(T, int), string> NFIKHEIMAFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly Dictionary<(T, int), float> MOCEKJPBOJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly Dictionary<T, string> IIBOFCECEPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly Dictionary<T, string> NGGCPOHDIAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly Dictionary<T, string> OJOECLBMCFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly Dictionary<T, string[]> PNDOIKPNFDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private string IDELCHCLEGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private bool HBDJNHEECGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private Task FGKINJLEDDM;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x4ADBF80", Offset = "0x4ADAF80", VA = "0x184ADBF80")]
		public HGCIILPAOHO(Guid PNBLCEBBDDJ, string HGFPICLPGIE, string FCFOPGKFBIG, string HEGEOEOBFLC, [Optional] string CNMDBOEOLJA, [Optional] string FICOAOJDBGL, [Optional] string PAMBDHFHDKO, [Optional] string PHLGJGDIMNN, [Optional] string IDELCHCLEGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9F1770", Offset = "0x9F0770", VA = "0x1809F1770")]
		public void JCCOIBLEDJE(string CNMDBOEOLJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9F32B0", Offset = "0x9F22B0", VA = "0x1809F32B0")]
		public void HIKABHEIPJC(string HEGEOEOBFLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xA894A0", Offset = "0xA884A0", VA = "0x180A894A0")]
		public void IOFAKMIFOFB(string IDELCHCLEGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9F46E0", Offset = "0x9F36E0", VA = "0x1809F46E0")]
		public void OELGEBLDNNE(string KGKCNEHOGIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9F4CD0", Offset = "0x9F3CD0", VA = "0x1809F4CD0")]
		public void MOLBIGPGIFM(string AEBOBCGKFDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9F4CC0", Offset = "0x9F3CC0", VA = "0x1809F4CC0")]
		public void KOGLPMCAKHO(string FOAJDBHIJHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x4AD52D0", Offset = "0x4AD42D0", VA = "0x184AD52D0")]
		public void EJCCCFACJNI(Guid? PNBLCEBBDDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x4967C90", Offset = "0x4966C90", VA = "0x184967C90")]
		public void IHBIMMBLLPI((int, int)? JLDCIIIAHPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9F46D0", Offset = "0x9F36D0", VA = "0x1809F46D0")]
		public void NHDLOANMPKO(string HOAPHMNCGOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x4ADBDE0", Offset = "0x4ADADE0", VA = "0x184ADBDE0")]
		public void PNAPLNDOEEA(T HOLMDHKIDEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x4AD4550", Offset = "0x4AD3550", VA = "0x184AD4550")]
		public void CJLBPPMFAPN(T HOLMDHKIDEL, int KPNFBPHPIPO, float JHNMLGDIFJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x4ADB2E0", Offset = "0x4ADA2E0", VA = "0x184ADB2E0")]
		public void OFPCDBPGJFB(T HOLMDHKIDEL, int KPNFBPHPIPO, string JEEKMJOIBKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x4AD7A50", Offset = "0x4AD6A50", VA = "0x184AD7A50")]
		public void ILBAKEFNJNN(T HOLMDHKIDEL, string JMCGBABLDPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x4AD4F70", Offset = "0x4AD3F70", VA = "0x184AD4F70")]
		public void DDBPDKEAIDD(T HOLMDHKIDEL, string LCNJILFNLFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x4AD3E50", Offset = "0x4AD2E50", VA = "0x184AD3E50")]
		public void ANHGFEPBLNO(T HOLMDHKIDEL, bool KLJJMGLBPKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x4AD5F00", Offset = "0x4AD4F00", VA = "0x184AD5F00")]
		public void HBNNDJJHBBP(T HOLMDHKIDEL, string[] NLIEGDOFAIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x4AD8E90", Offset = "0x4AD7E90", VA = "0x184AD8E90")]
		public Task MJHBJEIBFGO(bool ECOALLGHBMI = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x4AD70A0", Offset = "0x4AD60A0", VA = "0x184AD70A0")]
		private (IEnumerable<T>, string) IJHILJIPOFJ()
		{
			return default((IEnumerable<T>, string));
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x4AD5B00", Offset = "0x4AD4B00", VA = "0x184AD5B00")]
		public static HBCMGLBMNOC FIMOIMHFLNP(Guid PNBLCEBBDDJ, string HGFPICLPGIE, T HOLMDHKIDEL, string FCFOPGKFBIG, string DADNIDHHJFI, string CNMDBOEOLJA, int? OHHMJGCBCKD, [Optional] string CFBGCDILEII, [Optional] string JMCGBABLDPI, [Optional] int? BODGDKDNIMG, [Optional] Guid? ECPKJHBKKOK, [Optional] string IDELCHCLEGF, [Optional] string ECCMNPFGGHH, [Optional] (int, int)? JLDCIIIAHPM, [Optional] string BEEIALENMOD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x4AD5120", Offset = "0x4AD4120", VA = "0x184AD5120")]
		[CompilerGenerated]
		private string DNMDGGGCDAN(T HJPLNJNIFLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x4AD7D20", Offset = "0x4AD6D20", VA = "0x184AD7D20")]
		[CompilerGenerated]
		private string INDMIJDBCJC(T HJPLNJNIFLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x4ADB840", Offset = "0x4ADA840", VA = "0x184ADB840")]
		[CompilerGenerated]
		private string OKEFACDMEHH(T HJPLNJNIFLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x4AD3B60", Offset = "0x4AD2B60", VA = "0x184AD3B60")]
		[CompilerGenerated]
		private string ABGJFOLJAAJ(T HJPLNJNIFLL)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public abstract class MKPJHBCDNLL<TItem, TListSessionStartParams, TListSessionLogParams>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		protected readonly string AFDMOCAAEDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		protected readonly Guid KNNPGFGHKBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		protected readonly long HGNFJDEKKID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		protected int EJIAAGACFNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		protected int GBCBOKHFLDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		protected DateTime KJAOKFBDMLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		protected bool FGDBGBPOEOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		protected Dictionary<long, JOMIJLHDOOP> AADLGFLJGCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		protected bool AMIGOMEBCPA;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool DJLLMFIFBBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xC11900", Offset = "0xC10900", VA = "0x180C11900")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool GKABPOMILGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xC58EB0", Offset = "0xC57EB0", VA = "0x180C58EB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x5344360", Offset = "0x5343360", VA = "0x185344360")]
		public MKPJHBCDNLL(string AFDMOCAAEDI, Guid KNNPGFGHKBD, long HGNFJDEKKID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void FEBPIFHOGNC(TListSessionStartParams CAFJEEJDCIE);

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x4AD1B40", Offset = "0x4AD0B40", VA = "0x184AD1B40")]
		public void OLGABCKEKMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void LDLBODBAOPP(bool DCJDFHHHEHM, TListSessionLogParams EBHIEGHNIPK);

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x53441F0", Offset = "0x53431F0", VA = "0x1853441F0")]
		public void EEFCFHNBIOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5344000", Offset = "0x5343000", VA = "0x185344000")]
		public void BJNEJCIHAAO(long JPEKMHAKLEC, int OHHMJGCBCKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x53440D0", Offset = "0x53430D0", VA = "0x1853440D0")]
		public void CHNMPCLGOOA(long JPEKMHAKLEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract JOMIJLHDOOP HILKANPMIAO(TItem HOJKNIMMINF, int OHHMJGCBCKD, string GIJNGCIEONA);
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class JOMIJLHDOOP : KIMAPJGMAHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private int EJIAAGACFNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private long JPEKMHAKLEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private long HGNFJDEKKID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly string IOJLBLJLGPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly string FCKMCCJCOHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly int EIPFLNHHDGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private DateTime PJDMHBLFPOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private double OHKDNAGNPOD;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool DKENDNGNMIL
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xE164A0", Offset = "0xE154A0", VA = "0x180E164A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xE16490", Offset = "0xE15490", VA = "0x180E16490")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7188070", Offset = "0x7187070", VA = "0x187188070")]
		public JOMIJLHDOOP(long JPEKMHAKLEC, int EJIAAGACFNJ, string ECCMNPFGGHH, long HGNFJDEKKID, int EIPFLNHHDGF, [Optional] string FCFOPGKFBIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7187E30", Offset = "0x7186E30", VA = "0x187187E30")]
		public void EMOKNODOEJE(int EJIAAGACFNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7187F10", Offset = "0x7186F10", VA = "0x187187F10")]
		public void MJMGPBCPDIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7187F60", Offset = "0x7186F60", VA = "0x187187F60")]
		public void OBJEGHFMCEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7187EA0", Offset = "0x7186EA0", VA = "0x187187EA0")]
		private void IAEKOEBLCHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7187980", Offset = "0x7186980", VA = "0x187187980", Slot = "5")]
		public virtual HBCMGLBMNOC DHDBOIIHPLO(Guid PNBLCEBBDDJ, string CGOFEFPLIIG, [Optional] string ECCMNPFGGHH, [Optional] long? HOLMDHKIDEL, [Optional] string FCFOPGKFBIG, [Optional] string CNMDBOEOLJA)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class HHIPJFOKMMN
	{
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private static Dictionary<string, Dictionary<string, object>> DCAOKHJJMHP;

		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private static string IEHOGNBPIHM;

		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private static int PMEEEFLMCNA;

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private static readonly Dictionary<string, KEDPLDMFOHA> OJNJNKJOKHN;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static string FKDMIHMJLCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x7185CD0", Offset = "0x7184CD0", VA = "0x187185CD0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x7186D30", Offset = "0x7185D30", VA = "0x187186D30")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static bool COBAKNAJCGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x7186FC0", Offset = "0x7185FC0", VA = "0x187186FC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static Dictionary<string, Dictionary<string, object>> PHBFFBCFJHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x7186F70", Offset = "0x7185F70", VA = "0x187186F70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static Guid? ENELNKECLJA
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x7186BE0", Offset = "0x7185BE0", VA = "0x187186BE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x7186600", Offset = "0x7185600", VA = "0x187186600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static Guid? CNEICICAPKM
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x7185F10", Offset = "0x7184F10", VA = "0x187185F10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x7186F10", Offset = "0x7185F10", VA = "0x187186F10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x71872B0", Offset = "0x71862B0", VA = "0x1871872B0")]
		public static void PNOILEOJELC(string HJPHNPOFGBP, KEDPLDMFOHA CPNLOKOEGMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7185900", Offset = "0x7184900", VA = "0x187185900")]
		internal static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x71859E0", Offset = "0x71849E0", VA = "0x1871859E0")]
		internal static void AOJNBLCPAHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7186C50", Offset = "0x7185C50", VA = "0x187186C50")]
		internal static void HEPPGPLHCBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7186020", Offset = "0x7185020", VA = "0x187186020")]
		public static Guid FEBPIFHOGNC(string HJPHNPOFGBP, [Optional] string? LFECHOALALL, [Optional] Dictionary<string, object>? JELNHHNDCKH)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7185F80", Offset = "0x7184F80", VA = "0x187185F80")]
		public static Guid FEBPIFHOGNC(string HJPHNPOFGBP, long LFECHOALALL, [Optional] Dictionary<string, object>? JELNHHNDCKH)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7187050", Offset = "0x7186050", VA = "0x187187050")]
		public static void OLGABCKEKMH(string HJPHNPOFGBP, [Optional] Guid? DGNNPFFMIEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7185AC0", Offset = "0x7184AC0", VA = "0x187185AC0")]
		public static void BDONEIKHOAH(string HJPHNPOFGBP, string AHHGAKODFMI, object JDJBOOAAJAF, bool OFPCAPCHNEP = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7185D20", Offset = "0x7184D20", VA = "0x187185D20")]
		public static bool CCKNJHPNELI(string HJPHNPOFGBP, [Optional] string? LFECHOALALL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7186660", Offset = "0x7185660", VA = "0x187186660")]
		private static void GIEIPDAFEGJ(bool DLPAEAMOOGJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7186CD0", Offset = "0x7185CD0", VA = "0x187186CD0")]
		public static void IBJCPOLCAEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7186DF0", Offset = "0x7185DF0", VA = "0x187186DF0")]
		private static void MCEGJKOFHME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x71867E0", Offset = "0x71857E0", VA = "0x1871867E0")]
		private static void GJLDBMCKHNC(string HJPHNPOFGBP, Guid PNBLCEBBDDJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public static class KFCNPJJOBLN
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public struct GOEBJDGGMAD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public bool AMLDIAHNCEJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public string NCGJCKHFLGN;

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xC17730", Offset = "0xC16730", VA = "0x180C17730")]
			public GOEBJDGGMAD(bool AMLDIAHNCEJ, string NCGJCKHFLGN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7188140", Offset = "0x7187140", VA = "0x187188140")]
		public static GOEBJDGGMAD AHIMDJPCPBN(HBCMGLBMNOC BCLLJEOCNAG)
		{
			return default(GOEBJDGGMAD);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7188520", Offset = "0x7187520", VA = "0x187188520")]
		private static void JPBACMIEBED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7188460", Offset = "0x7187460", VA = "0x187188460")]
		private static void DONGHMEENIE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class EOCHDCEDEKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7184A50", Offset = "0x7183A50", VA = "0x187184A50")]
		public static HBCMGLBMNOC FPECLNIBKLE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class FLMBEFLJPDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7184D50", Offset = "0x7183D50", VA = "0x187184D50")]
		public static HBCMGLBMNOC HGNBHBELBMF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7184AB0", Offset = "0x7183AB0", VA = "0x187184AB0")]
		public static HBCMGLBMNOC CKNOCNBHLBL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7184BD0", Offset = "0x7183BD0", VA = "0x187184BD0")]
		public static HBCMGLBMNOC COHJJJJIOFJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7184C30", Offset = "0x7183C30", VA = "0x187184C30")]
		public static HBCMGLBMNOC EFKMBHPMBDM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7184ED0", Offset = "0x7183ED0", VA = "0x187184ED0")]
		public static HBCMGLBMNOC MEMFJIEDBEK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7184F30", Offset = "0x7183F30", VA = "0x187184F30")]
		public static HBCMGLBMNOC ODLECIPOMOB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7184B10", Offset = "0x7183B10", VA = "0x187184B10")]
		public static HBCMGLBMNOC CNEIDCHPEKL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7184B70", Offset = "0x7183B70", VA = "0x187184B70")]
		public static HBCMGLBMNOC CNOFJNLCKFI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7184DB0", Offset = "0x7183DB0", VA = "0x187184DB0")]
		public static HBCMGLBMNOC JHDKMEKIAMB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7184F90", Offset = "0x7183F90", VA = "0x187184F90")]
		public static HBCMGLBMNOC OILJMNMIBDE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7184C90", Offset = "0x7183C90", VA = "0x187184C90")]
		public static HBCMGLBMNOC FDDBKPGCJIO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7184E70", Offset = "0x7183E70", VA = "0x187184E70")]
		public static HBCMGLBMNOC KEMFKEBPCPA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7184E10", Offset = "0x7183E10", VA = "0x187184E10")]
		public static HBCMGLBMNOC JPOHOIDKLMD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7184CF0", Offset = "0x7183CF0", VA = "0x187184CF0")]
		public static HBCMGLBMNOC FKAOHCGJEAA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7184FF0", Offset = "0x7183FF0", VA = "0x187184FF0")]
		public static HBCMGLBMNOC PJAPOPLLEBC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class LCHGBGNEDKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x71886C0", Offset = "0x71876C0", VA = "0x1871886C0")]
		public static HBCMGLBMNOC ICGECLNBEDC(long CINEDGEJAIA, long NBOIIPJHEBJ, bool BIIFEHBPEBG, string OADJIOJDABB, string NCPGPOHEAHG)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class ECOLBDMBMBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7182E70", Offset = "0x7181E70", VA = "0x187182E70")]
		public static HBCMGLBMNOC MIINDKCDFHN(string FKDLIFFMGIF, string DBNKKKNPDCP, bool ANMGGNKHMPB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7182C40", Offset = "0x7181C40", VA = "0x187182C40")]
		public static HBCMGLBMNOC BOPOHHLJBIH(string INLEBAAACKH, string FLPCIHGLALM, string FGIAGGDAFBG, [Optional] int? LJCDHGEAENE, [Optional] double[] NPGBMMCIIGH)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class EKHHMEFPBIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x71848C0", Offset = "0x71838C0", VA = "0x1871848C0")]
		public static HBCMGLBMNOC MGILMENICMC(string DIIEAGGKGAJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x71844B0", Offset = "0x71834B0", VA = "0x1871844B0")]
		public static HBCMGLBMNOC IIMHEDKMNCI(string MKAOFLLKCGA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x71849A0", Offset = "0x71839A0", VA = "0x1871849A0")]
		public static HBCMGLBMNOC OCGPEAECCKO(int BEKCOFDFFEG, string NFHOBPDKIPM, string HJPLNJNIFLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7184450", Offset = "0x7183450", VA = "0x187184450")]
		public static HBCMGLBMNOC DINCJAMCOGB(int BEKCOFDFFEG, string NFHOBPDKIPM, string HJPLNJNIFLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x7184860", Offset = "0x7183860", VA = "0x187184860")]
		public static HBCMGLBMNOC MGCMDPNICED(int BEKCOFDFFEG, string NFHOBPDKIPM, string HJPLNJNIFLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7184590", Offset = "0x7183590", VA = "0x187184590")]
		public static HBCMGLBMNOC KLEIEFEIAAI(int BEKCOFDFFEG, string NFHOBPDKIPM, string HJPLNJNIFLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7184300", Offset = "0x7183300", VA = "0x187184300")]
		public static HBCMGLBMNOC AICFNDCFAHJ(string NFHOBPDKIPM, string HJPLNJNIFLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x71845F0", Offset = "0x71835F0", VA = "0x1871845F0")]
		private static HBCMGLBMNOC KPGLDBLKJAC(string AFDMOCAAEDI, int BEKCOFDFFEG, string KKILDMKEMFA, string KMFMPKJENJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7184730", Offset = "0x7183730", VA = "0x187184730")]
		private static HBCMGLBMNOC KPGLDBLKJAC(string AFDMOCAAEDI, string KKILDMKEMFA, string KMFMPKJENJG)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly JBBHIJHGEPM AHIMDJPCPBN;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static HFGDIDMMDMC COMFAEJLJBL;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static DNNHALOGKMB DMMMOGJKCNI;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static Queue<HBCMGLBMNOC> JLEJKPAEFGA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private static long IJKKHADEHHG
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x718AD80", Offset = "0x7189D80", VA = "0x18718AD80")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x718B150", Offset = "0x718A150", VA = "0x18718B150")]
	[FHOLJFNIKPC.CJBPAKNLBCK]
	internal static void PPNIOEPNBEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x718AE70", Offset = "0x7189E70", VA = "0x18718AE70")]
	private static void CGHFNCCOJKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x718AF40", Offset = "0x7189F40", VA = "0x18718AF40")]
	public static HBCMGLBMNOC EOBLHNEHOKA(string MJDGLECFFEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7182310", Offset = "0x7181310", VA = "0x187182310")]
	public static HBCMGLBMNOC EOBLHNEHOKA(string MJDGLECFFEI, int BEKCOFDFFEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x718B0E0", Offset = "0x718A0E0", VA = "0x18718B0E0")]
	public static bool OMFKBCDABEN(this JAHOCBPGMLL MKIEJCFADMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x718AFC0", Offset = "0x7189FC0", VA = "0x18718AFC0")]
	[FHOLJFNIKPC.CJBPAKNLBCK]
	internal static void HMFPPAKOILH()
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
