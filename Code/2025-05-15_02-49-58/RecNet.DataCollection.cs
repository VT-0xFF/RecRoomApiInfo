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
		[Cpp2IlInjected.Address(RVA = "0xA149D0", Offset = "0xA12FD0", VA = "0x180A149D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7159BE0", Offset = "0x71581E0", VA = "0x187159BE0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA154F0", Offset = "0xA13AF0", VA = "0x180A154F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA15530", Offset = "0xA13B30", VA = "0x180A15530")]
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
		[Cpp2IlInjected.Address(RVA = "0x7157400", Offset = "0x7155A00", VA = "0x187157400", Slot = "4")]
		public override void AMBIAOGNIIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA149D0", Offset = "0xA12FD0", VA = "0x180A149D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7159F50", Offset = "0x7158550", VA = "0x187159F50", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2645EC0", Offset = "0x26444C0", VA = "0x182645EC0")]
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
	[Cpp2IlInjected.Address(RVA = "0x7159B70", Offset = "0x7158170", VA = "0x187159B70")]
	public static void NFBPFAJJMBN(this NBPJJLNGOFA.HBCMGLBMNOC BCLLJEOCNAG, string BDJPEELILNM, string GHNKKPBGKOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x71599E0", Offset = "0x7157FE0", VA = "0x1871599E0")]
	public static void NFBPFAJJMBN(this NBPJJLNGOFA.HBCMGLBMNOC BCLLJEOCNAG, string BDJPEELILNM, bool GHNKKPBGKOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7159A70", Offset = "0x7158070", VA = "0x187159A70")]
	public static void NFBPFAJJMBN(this NBPJJLNGOFA.HBCMGLBMNOC BCLLJEOCNAG, string BDJPEELILNM, float OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7159680", Offset = "0x7157C80", VA = "0x187159680")]
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
		[Cpp2IlInjected.Address(RVA = "0x7158970", Offset = "0x7156F70", VA = "0x187158970")]
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
			[Cpp2IlInjected.Address(RVA = "0x7152FB0", Offset = "0x71515B0", VA = "0x187152FB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public string IMHLPEOHJFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x10DD020", Offset = "0x10DB620", VA = "0x1810DD020")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7153760", Offset = "0x7151D60", VA = "0x187153760")]
		public HBCMGLBMNOC(BGFACPEPMJN NKBJHKLGFDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7152FF0", Offset = "0x71515F0", VA = "0x187152FF0")]
		public HBCMGLBMNOC GHPDPAGFDDO(string LLPAKFGNDOB, string OHLIHBDBKCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3F5C380", Offset = "0x3F5A980", VA = "0x183F5C380")]
		public HBCMGLBMNOC GHPDPAGFDDO<T>(string LLPAKFGNDOB, T OHLIHBDBKCE) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7153420", Offset = "0x7151A20", VA = "0x187153420")]
		public HBCMGLBMNOC NDIMNKGOHDA(string LLPAKFGNDOB, object OHLIHBDBKCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3F5C7B0", Offset = "0x3F5ADB0", VA = "0x183F5C7B0")]
		public HBCMGLBMNOC KGFPFPHCOIH<T>(string LLPAKFGNDOB, T? OHLIHBDBKCE) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7153290", Offset = "0x7151890", VA = "0x187153290")]
		public HBCMGLBMNOC KGFPFPHCOIH(string LLPAKFGNDOB, string OHLIHBDBKCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7153070", Offset = "0x7151670", VA = "0x187153070")]
		public HBCMGLBMNOC HDJDONOHIME(string AHHGAKODFMI, string OEHHKNIGGMI, object APDBNIMCPID)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x71531B0", Offset = "0x71517B0", VA = "0x1871531B0")]
		public HBCMGLBMNOC HDJDONOHIME(string AHHGAKODFMI, IDictionary<string, object> PFOGKPFJJDP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7152F50", Offset = "0x7151550", VA = "0x187152F50")]
		private static IDictionary<string, object> CJHBODDPHMJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x71534A0", Offset = "0x7151AA0", VA = "0x1871534A0")]
		public void PACMCPBDCCL(bool MGFPPIECFNK, string LDPLFLCJNKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7153320", Offset = "0x7151920", VA = "0x187153320")]
		public Task MJHBJEIBFGO([Optional] CancellationToken CBJPDIFOEKF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x27798B0", Offset = "0x2777EB0", VA = "0x1827798B0", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x7155300", Offset = "0x7153900", VA = "0x187155300", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7155780", Offset = "0x7153D80", VA = "0x187155780", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7150600", Offset = "0x714EC00", VA = "0x187150600")]
		private BGFACPEPMJN(string MJDGLECFFEI, int BEKCOFDFFEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x71502D0", Offset = "0x714E8D0", VA = "0x1871502D0")]
		public static HBCMGLBMNOC FLLMCNLHKNL(string MJDGLECFFEI, int BEKCOFDFFEG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x71504A0", Offset = "0x714EAA0", VA = "0x1871504A0")]
		[AsyncStateMachine(typeof(ICAANEAFBBF))]
		public Task MJHBJEIBFGO([Optional] CancellationToken CBJPDIFOEKF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7150590", Offset = "0x714EB90", VA = "0x187150590", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3863C00", Offset = "0x3862200", VA = "0x183863C00")]
		internal void LCAGAJBPCNC<T>(string LLPAKFGNDOB, T OHLIHBDBKCE) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x71503E0", Offset = "0x714E9E0", VA = "0x1871503E0")]
		internal void JEGLKKJJHEO(string LLPAKFGNDOB, object OHLIHBDBKCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7150440", Offset = "0x714EA40", VA = "0x187150440")]
		internal void LCAGAJBPCNC(string LLPAKFGNDOB, string OHLIHBDBKCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3F5A870", Offset = "0x3F58E70", VA = "0x183F5A870")]
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
		[Cpp2IlInjected.Address(RVA = "0x71521C0", Offset = "0x71507C0", VA = "0x1871521C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7152900", Offset = "0x7150F00", VA = "0x187152900")]
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
		[Cpp2IlInjected.Address(RVA = "0x71588F0", Offset = "0x7156EF0", VA = "0x1871588F0")]
		public MELDGLKLIHM(string AFDMOCAAEDI, Guid KNNPGFGHKBD, long HGNFJDEKKID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7157570", Offset = "0x7155B70", VA = "0x187157570", Slot = "4")]
		public override void FEBPIFHOGNC(EMEJBFGCOIK CAFJEEJDCIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7157490", Offset = "0x7155A90", VA = "0x187157490")]
		public void DBPNFBMAIGK(short ODGLGDKJENI, bool KAAFEKILFMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4963060", Offset = "0x4961660", VA = "0x184963060")]
		public void IGLBEGEBCOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9EECD0", Offset = "0x9ED2D0", VA = "0x1809EECD0")]
		public void ENKONHMMGGH(string BDJILOJOCKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7157B10", Offset = "0x7156110", VA = "0x187157B10", Slot = "5")]
		public override void LDLBODBAOPP(bool DCJDFHHHEHM, EIKLINDABAE EBHIEGHNIPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7157860", Offset = "0x7155E60", VA = "0x187157860", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x7150AF0", Offset = "0x714F0F0", VA = "0x187150AF0")]
		public CAADBMDNPNC(long JPEKMHAKLEC, int EJIAAGACFNJ, string ECCMNPFGGHH, long HGNFJDEKKID, int EIPFLNHHDGF, string FCFOPGKFBIG, short ODGLGDKJENI, string KOHBLPNDNGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7150A70", Offset = "0x714F070", VA = "0x187150A70")]
		public void FIDOHFAGMKP(int EJIAAGACFNJ, string KOHBLPNDNGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7150940", Offset = "0x714EF40", VA = "0x187150940", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public KLCKDFCALKF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x7156460", Offset = "0x7154A60", VA = "0x187156460")]
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
			[Cpp2IlInjected.Address(RVA = "0x71566E0", Offset = "0x7154CE0", VA = "0x1871566E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x71573A0", Offset = "0x71559A0", VA = "0x1871573A0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x71590A0", Offset = "0x71576A0", VA = "0x1871590A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x7159620", Offset = "0x7157C20", VA = "0x187159620", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x7151360", Offset = "0x714F960", VA = "0x187151360")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private static bool NGBGAKOJIHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x7152080", Offset = "0x7150680", VA = "0x187152080")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7151490", Offset = "0x714FA90", VA = "0x187151490")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private static bool ENCFKGKEIPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7151680", Offset = "0x714FC80", VA = "0x187151680")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7152020", Offset = "0x7150620", VA = "0x187152020")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private static float KOGEGPKJHNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7150F80", Offset = "0x714F580", VA = "0x187150F80")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x71514F0", Offset = "0x714FAF0", VA = "0x1871514F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7151EB0", Offset = "0x71504B0", VA = "0x187151EB0")]
		[FHOLJFNIKPC.CJBPAKNLBCK]
		internal static void NHGLDOFJBBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7150FD0", Offset = "0x714F5D0", VA = "0x187150FD0")]
		internal static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x71511B0", Offset = "0x714F7B0", VA = "0x1871511B0")]
		internal static void AOJNBLCPAHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7151550", Offset = "0x714FB50", VA = "0x187151550")]
		internal static void HEPPGPLHCBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7151FD0", Offset = "0x71505D0", VA = "0x187151FD0")]
		public static void OKKNKFBEHIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x71517A0", Offset = "0x714FDA0", VA = "0x1871517A0")]
		private static void KJCDEAJGEBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7151BD0", Offset = "0x71501D0", VA = "0x187151BD0")]
		private static void MCEGJKOFHME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x71515B0", Offset = "0x714FBB0", VA = "0x1871515B0")]
		[AsyncStateMachine(typeof(LNJBNNELDGI))]
		private static Task IGMCHNDDIEO(CancellationToken CBJPDIFOEKF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x71516D0", Offset = "0x714FCD0", VA = "0x1871516D0")]
		private static void KGEEIBIJGMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x71513B0", Offset = "0x714F9B0", VA = "0x1871513B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public ECBFDFFDCIH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x44F6610", Offset = "0x44F4C10", VA = "0x1844F6610")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public NGHPMPIFMKC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x53ECA20", Offset = "0x53EB020", VA = "0x1853ECA20")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public MBDGGAGOAFA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x532D440", Offset = "0x532BA40", VA = "0x18532D440")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public ICBDDNGKLPO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x4C23720", Offset = "0x4C21D20", VA = "0x184C23720")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public NPDKKLCAFIA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x5426210", Offset = "0x5424810", VA = "0x185426210")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public BEMBLCFDDNB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x6236BC0", Offset = "0x62351C0", VA = "0x186236BC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public AIPBINKCKNP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x4C7B060", Offset = "0x4C79660", VA = "0x184C7B060")]
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
		[Cpp2IlInjected.Address(RVA = "0x4B11CE0", Offset = "0x4B102E0", VA = "0x184B11CE0")]
		public HGCIILPAOHO(Guid PNBLCEBBDDJ, string HGFPICLPGIE, string FCFOPGKFBIG, string HEGEOEOBFLC, [Optional] string CNMDBOEOLJA, [Optional] string FICOAOJDBGL, [Optional] string PAMBDHFHDKO, [Optional] string PHLGJGDIMNN, [Optional] string IDELCHCLEGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9EB770", Offset = "0x9E9D70", VA = "0x1809EB770")]
		public void JCCOIBLEDJE(string CNMDBOEOLJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9ED2B0", Offset = "0x9EB8B0", VA = "0x1809ED2B0")]
		public void HIKABHEIPJC(string HEGEOEOBFLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xA9D460", Offset = "0xA9BA60", VA = "0x180A9D460")]
		public void IOFAKMIFOFB(string IDELCHCLEGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9EE6D0", Offset = "0x9ECCD0", VA = "0x1809EE6D0")]
		public void OELGEBLDNNE(string KGKCNEHOGIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9EECD0", Offset = "0x9ED2D0", VA = "0x1809EECD0")]
		public void MOLBIGPGIFM(string AEBOBCGKFDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9EECC0", Offset = "0x9ED2C0", VA = "0x1809EECC0")]
		public void KOGLPMCAKHO(string FOAJDBHIJHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x4B0D630", Offset = "0x4B0BC30", VA = "0x184B0D630")]
		public void EJCCCFACJNI(Guid? PNBLCEBBDDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x49A7180", Offset = "0x49A5780", VA = "0x1849A7180")]
		public void IHBIMMBLLPI((int, int)? JLDCIIIAHPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9EE6C0", Offset = "0x9ECCC0", VA = "0x1809EE6C0")]
		public void NHDLOANMPKO(string HOAPHMNCGOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x4B11B50", Offset = "0x4B10150", VA = "0x184B11B50")]
		public void PNAPLNDOEEA(T HOLMDHKIDEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x4B0CB30", Offset = "0x4B0B130", VA = "0x184B0CB30")]
		public void CJLBPPMFAPN(T HOLMDHKIDEL, int KPNFBPHPIPO, float JHNMLGDIFJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x4B112F0", Offset = "0x4B0F8F0", VA = "0x184B112F0")]
		public void OFPCDBPGJFB(T HOLMDHKIDEL, int KPNFBPHPIPO, string JEEKMJOIBKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x4B0EFC0", Offset = "0x4B0D5C0", VA = "0x184B0EFC0")]
		public void ILBAKEFNJNN(T HOLMDHKIDEL, string JMCGBABLDPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x4B0D360", Offset = "0x4B0B960", VA = "0x184B0D360")]
		public void DDBPDKEAIDD(T HOLMDHKIDEL, string LCNJILFNLFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x4B0C790", Offset = "0x4B0AD90", VA = "0x184B0C790")]
		public void ANHGFEPBLNO(T HOLMDHKIDEL, bool KLJJMGLBPKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x4B0DE60", Offset = "0x4B0C460", VA = "0x184B0DE60")]
		public void HBNNDJJHBBP(T HOLMDHKIDEL, string[] NLIEGDOFAIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x4B102C0", Offset = "0x4B0E8C0", VA = "0x184B102C0")]
		public Task MJHBJEIBFGO(bool ECOALLGHBMI = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x4B0E7F0", Offset = "0x4B0CDF0", VA = "0x184B0E7F0")]
		private (IEnumerable<T>, string) IJHILJIPOFJ()
		{
			return default((IEnumerable<T>, string));
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x4B0DA60", Offset = "0x4B0C060", VA = "0x184B0DA60")]
		public static HBCMGLBMNOC FIMOIMHFLNP(Guid PNBLCEBBDDJ, string HGFPICLPGIE, T HOLMDHKIDEL, string FCFOPGKFBIG, string DADNIDHHJFI, string CNMDBOEOLJA, int? OHHMJGCBCKD, [Optional] string CFBGCDILEII, [Optional] string JMCGBABLDPI, [Optional] int? BODGDKDNIMG, [Optional] Guid? ECPKJHBKKOK, [Optional] string IDELCHCLEGF, [Optional] string ECCMNPFGGHH, [Optional] (int, int)? JLDCIIIAHPM, [Optional] string BEEIALENMOD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x4B0D510", Offset = "0x4B0BB10", VA = "0x184B0D510")]
		[CompilerGenerated]
		private string DNMDGGGCDAN(T HJPLNJNIFLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x4B0F200", Offset = "0x4B0D800", VA = "0x184B0F200")]
		[CompilerGenerated]
		private string INDMIJDBCJC(T HJPLNJNIFLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x4B11820", Offset = "0x4B0FE20", VA = "0x184B11820")]
		[CompilerGenerated]
		private string OKEFACDMEHH(T HJPLNJNIFLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x4B0C670", Offset = "0x4B0AC70", VA = "0x184B0C670")]
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
			[Cpp2IlInjected.Address(RVA = "0xC17800", Offset = "0xC15E00", VA = "0x180C17800")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool GKABPOMILGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xC59930", Offset = "0xC57F30", VA = "0x180C59930")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x5367CB0", Offset = "0x53662B0", VA = "0x185367CB0")]
		public MKPJHBCDNLL(string AFDMOCAAEDI, Guid KNNPGFGHKBD, long HGNFJDEKKID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void FEBPIFHOGNC(TListSessionStartParams CAFJEEJDCIE);

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x4B0A760", Offset = "0x4B08D60", VA = "0x184B0A760")]
		public void OLGABCKEKMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void LDLBODBAOPP(bool DCJDFHHHEHM, TListSessionLogParams EBHIEGHNIPK);

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5367B40", Offset = "0x5366140", VA = "0x185367B40")]
		public void EEFCFHNBIOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5367950", Offset = "0x5365F50", VA = "0x185367950")]
		public void BJNEJCIHAAO(long JPEKMHAKLEC, int OHHMJGCBCKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5367A20", Offset = "0x5366020", VA = "0x185367A20")]
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
			[Cpp2IlInjected.Address(RVA = "0xE28200", Offset = "0xE26800", VA = "0x180E28200")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xE281F0", Offset = "0xE267F0", VA = "0x180E281F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7155EC0", Offset = "0x71544C0", VA = "0x187155EC0")]
		public JOMIJLHDOOP(long JPEKMHAKLEC, int EJIAAGACFNJ, string ECCMNPFGGHH, long HGNFJDEKKID, int EIPFLNHHDGF, [Optional] string FCFOPGKFBIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7155C90", Offset = "0x7154290", VA = "0x187155C90")]
		public void EMOKNODOEJE(int EJIAAGACFNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7155D60", Offset = "0x7154360", VA = "0x187155D60")]
		public void MJMGPBCPDIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7155DB0", Offset = "0x71543B0", VA = "0x187155DB0")]
		public void OBJEGHFMCEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7155D00", Offset = "0x7154300", VA = "0x187155D00")]
		private void IAEKOEBLCHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x71557E0", Offset = "0x7153DE0", VA = "0x1871557E0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x7153BD0", Offset = "0x71521D0", VA = "0x187153BD0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x7154BD0", Offset = "0x71531D0", VA = "0x187154BD0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static bool COBAKNAJCGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x7154E40", Offset = "0x7153440", VA = "0x187154E40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static Dictionary<string, Dictionary<string, object>> PHBFFBCFJHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x7154DF0", Offset = "0x71533F0", VA = "0x187154DF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static Guid? ENELNKECLJA
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x7154AA0", Offset = "0x71530A0", VA = "0x187154AA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x71544E0", Offset = "0x7152AE0", VA = "0x1871544E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static Guid? CNEICICAPKM
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x7153E10", Offset = "0x7152410", VA = "0x187153E10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x7154D90", Offset = "0x7153390", VA = "0x187154D90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7155130", Offset = "0x7153730", VA = "0x187155130")]
		public static void PNOILEOJELC(string HJPHNPOFGBP, KEDPLDMFOHA CPNLOKOEGMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7153800", Offset = "0x7151E00", VA = "0x187153800")]
		internal static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x71538E0", Offset = "0x7151EE0", VA = "0x1871538E0")]
		internal static void AOJNBLCPAHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7154B00", Offset = "0x7153100", VA = "0x187154B00")]
		internal static void HEPPGPLHCBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7153F10", Offset = "0x7152510", VA = "0x187153F10")]
		public static Guid FEBPIFHOGNC(string HJPHNPOFGBP, [Optional] string? LFECHOALALL, [Optional] Dictionary<string, object>? JELNHHNDCKH)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7153E70", Offset = "0x7152470", VA = "0x187153E70")]
		public static Guid FEBPIFHOGNC(string HJPHNPOFGBP, long LFECHOALALL, [Optional] Dictionary<string, object>? JELNHHNDCKH)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7154ED0", Offset = "0x71534D0", VA = "0x187154ED0")]
		public static void OLGABCKEKMH(string HJPHNPOFGBP, [Optional] Guid? DGNNPFFMIEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x71539C0", Offset = "0x7151FC0", VA = "0x1871539C0")]
		public static void BDONEIKHOAH(string HJPHNPOFGBP, string AHHGAKODFMI, object JDJBOOAAJAF, bool OFPCAPCHNEP = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7153C20", Offset = "0x7152220", VA = "0x187153C20")]
		public static bool CCKNJHPNELI(string HJPHNPOFGBP, [Optional] string? LFECHOALALL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7154540", Offset = "0x7152B40", VA = "0x187154540")]
		private static void GIEIPDAFEGJ(bool DLPAEAMOOGJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7154B80", Offset = "0x7153180", VA = "0x187154B80")]
		public static void IBJCPOLCAEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7154C80", Offset = "0x7153280", VA = "0x187154C80")]
		private static void MCEGJKOFHME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x71546B0", Offset = "0x7152CB0", VA = "0x1871546B0")]
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
			[Cpp2IlInjected.Address(RVA = "0xC19490", Offset = "0xC17A90", VA = "0x180C19490")]
			public GOEBJDGGMAD(bool AMLDIAHNCEJ, string NCGJCKHFLGN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7155F90", Offset = "0x7154590", VA = "0x187155F90")]
		public static GOEBJDGGMAD AHIMDJPCPBN(HBCMGLBMNOC BCLLJEOCNAG)
		{
			return default(GOEBJDGGMAD);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7156360", Offset = "0x7154960", VA = "0x187156360")]
		private static void JPBACMIEBED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x71562A0", Offset = "0x71548A0", VA = "0x1871562A0")]
		private static void DONGHMEENIE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class EOCHDCEDEKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7152950", Offset = "0x7150F50", VA = "0x187152950")]
		public static HBCMGLBMNOC FPECLNIBKLE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class FLMBEFLJPDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7152C50", Offset = "0x7151250", VA = "0x187152C50")]
		public static HBCMGLBMNOC HGNBHBELBMF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x71529B0", Offset = "0x7150FB0", VA = "0x1871529B0")]
		public static HBCMGLBMNOC CKNOCNBHLBL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7152AD0", Offset = "0x71510D0", VA = "0x187152AD0")]
		public static HBCMGLBMNOC COHJJJJIOFJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7152B30", Offset = "0x7151130", VA = "0x187152B30")]
		public static HBCMGLBMNOC EFKMBHPMBDM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7152DD0", Offset = "0x71513D0", VA = "0x187152DD0")]
		public static HBCMGLBMNOC MEMFJIEDBEK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7152E30", Offset = "0x7151430", VA = "0x187152E30")]
		public static HBCMGLBMNOC ODLECIPOMOB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7152A10", Offset = "0x7151010", VA = "0x187152A10")]
		public static HBCMGLBMNOC CNEIDCHPEKL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7152A70", Offset = "0x7151070", VA = "0x187152A70")]
		public static HBCMGLBMNOC CNOFJNLCKFI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7152CB0", Offset = "0x71512B0", VA = "0x187152CB0")]
		public static HBCMGLBMNOC JHDKMEKIAMB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7152E90", Offset = "0x7151490", VA = "0x187152E90")]
		public static HBCMGLBMNOC OILJMNMIBDE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7152B90", Offset = "0x7151190", VA = "0x187152B90")]
		public static HBCMGLBMNOC FDDBKPGCJIO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7152D70", Offset = "0x7151370", VA = "0x187152D70")]
		public static HBCMGLBMNOC KEMFKEBPCPA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7152D10", Offset = "0x7151310", VA = "0x187152D10")]
		public static HBCMGLBMNOC JPOHOIDKLMD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7152BF0", Offset = "0x71511F0", VA = "0x187152BF0")]
		public static HBCMGLBMNOC FKAOHCGJEAA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7152EF0", Offset = "0x71514F0", VA = "0x187152EF0")]
		public static HBCMGLBMNOC PJAPOPLLEBC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class LCHGBGNEDKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7156500", Offset = "0x7154B00", VA = "0x187156500")]
		public static HBCMGLBMNOC ICGECLNBEDC(long CINEDGEJAIA, long NBOIIPJHEBJ, bool BIIFEHBPEBG, string OADJIOJDABB, string NCPGPOHEAHG)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class ECOLBDMBMBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7150E10", Offset = "0x714F410", VA = "0x187150E10")]
		public static HBCMGLBMNOC MIINDKCDFHN(string FKDLIFFMGIF, string DBNKKKNPDCP, bool ANMGGNKHMPB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7150BE0", Offset = "0x714F1E0", VA = "0x187150BE0")]
		public static HBCMGLBMNOC BOPOHHLJBIH(string INLEBAAACKH, string FLPCIHGLALM, string FGIAGGDAFBG, [Optional] int? LJCDHGEAENE, [Optional] double[] NPGBMMCIIGH)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class EKHHMEFPBIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x71527C0", Offset = "0x7150DC0", VA = "0x1871527C0")]
		public static HBCMGLBMNOC MGILMENICMC(string DIIEAGGKGAJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x71523B0", Offset = "0x71509B0", VA = "0x1871523B0")]
		public static HBCMGLBMNOC IIMHEDKMNCI(string MKAOFLLKCGA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x71528A0", Offset = "0x7150EA0", VA = "0x1871528A0")]
		public static HBCMGLBMNOC OCGPEAECCKO(int BEKCOFDFFEG, string NFHOBPDKIPM, string HJPLNJNIFLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7152350", Offset = "0x7150950", VA = "0x187152350")]
		public static HBCMGLBMNOC DINCJAMCOGB(int BEKCOFDFFEG, string NFHOBPDKIPM, string HJPLNJNIFLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x7152760", Offset = "0x7150D60", VA = "0x187152760")]
		public static HBCMGLBMNOC MGCMDPNICED(int BEKCOFDFFEG, string NFHOBPDKIPM, string HJPLNJNIFLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7152490", Offset = "0x7150A90", VA = "0x187152490")]
		public static HBCMGLBMNOC KLEIEFEIAAI(int BEKCOFDFFEG, string NFHOBPDKIPM, string HJPLNJNIFLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7152200", Offset = "0x7150800", VA = "0x187152200")]
		public static HBCMGLBMNOC AICFNDCFAHJ(string NFHOBPDKIPM, string HJPLNJNIFLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x71524F0", Offset = "0x7150AF0", VA = "0x1871524F0")]
		private static HBCMGLBMNOC KPGLDBLKJAC(string AFDMOCAAEDI, int BEKCOFDFFEG, string KKILDMKEMFA, string KMFMPKJENJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7152630", Offset = "0x7150C30", VA = "0x187152630")]
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
		[Cpp2IlInjected.Address(RVA = "0x7158B80", Offset = "0x7157180", VA = "0x187158B80")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7158F40", Offset = "0x7157540", VA = "0x187158F40")]
	[FHOLJFNIKPC.CJBPAKNLBCK]
	internal static void PPNIOEPNBEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7158C70", Offset = "0x7157270", VA = "0x187158C70")]
	private static void CGHFNCCOJKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7158D30", Offset = "0x7157330", VA = "0x187158D30")]
	public static HBCMGLBMNOC EOBLHNEHOKA(string MJDGLECFFEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x71502D0", Offset = "0x714E8D0", VA = "0x1871502D0")]
	public static HBCMGLBMNOC EOBLHNEHOKA(string MJDGLECFFEI, int BEKCOFDFFEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7158ED0", Offset = "0x71574D0", VA = "0x187158ED0")]
	public static bool OMFKBCDABEN(this JAHOCBPGMLL MKIEJCFADMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7158DB0", Offset = "0x71573B0", VA = "0x187158DB0")]
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
