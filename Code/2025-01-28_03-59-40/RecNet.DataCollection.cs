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
		[Cpp2IlInjected.Address(RVA = "0x91D620", Offset = "0x91C820", VA = "0x18091D620")]
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
		[Cpp2IlInjected.Address(RVA = "0x686A8E0", Offset = "0x6869AE0", VA = "0x18686A8E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x91E490", Offset = "0x91D690", VA = "0x18091E490")]
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
		[Cpp2IlInjected.Address(RVA = "0x91E4D0", Offset = "0x91D6D0", VA = "0x18091E4D0")]
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
	public class LogRegistrationIndex : FOFAFNFGNAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x686A2F0", Offset = "0x68694F0", VA = "0x18686A2F0", Slot = "4")]
		public override void JMFBCAGPLCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x91D620", Offset = "0x91C820", VA = "0x18091D620")]
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
		[Cpp2IlInjected.Address(RVA = "0x686C2B0", Offset = "0x686B4B0", VA = "0x18686C2B0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x23EA930", Offset = "0x23E9B30", VA = "0x1823EA930")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface JGCBBBAMHMC
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyDictionary<string, object> CMJHGGDCFFA();
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class NGENCPFHDGE
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x686A770", Offset = "0x6869970", VA = "0x18686A770")]
	public static void EMPMJJIHNLC(this IMJGKDJGPIG.PEMFBPJEIIL ADHNLNENHHA, string ALCEPCLALFG, string JJMBPILDBPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x686A380", Offset = "0x6869580", VA = "0x18686A380")]
	public static void EMPMJJIHNLC(this IMJGKDJGPIG.PEMFBPJEIIL ADHNLNENHHA, string ALCEPCLALFG, bool JJMBPILDBPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x686A7E0", Offset = "0x68699E0", VA = "0x18686A7E0")]
	public static void EMPMJJIHNLC(this IMJGKDJGPIG.PEMFBPJEIIL ADHNLNENHHA, string ALCEPCLALFG, float OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x686A410", Offset = "0x6869610", VA = "0x18686A410")]
	public static void EMPMJJIHNLC(this IMJGKDJGPIG.PEMFBPJEIIL ADHNLNENHHA, string ALCEPCLALFG, PBBFIPFMJDG JJMBPILDBPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class IMJGKDJGPIG
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface KCFJDIKHIDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		PEMFBPJEIIL FNIMKEMLMPE(Guid LOOONPCIKDK, string PIIJHDCCIHD, [Optional] string HEICIAFEPOP, [Optional] long? MJEFOLNDPIB, [Optional] string OJCLNMHEOIJ, [Optional] string APKIPENOLND);
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class HBNCNPHIJNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6867B40", Offset = "0x6866D40", VA = "0x186867B40")]
		public static PEMFBPJEIIL PAAIKNOHDHO(Guid LOOONPCIKDK, string PIIJHDCCIHD, string HEICIAFEPOP, [Optional] long? MJEFOLNDPIB, [Optional] string OJCLNMHEOIJ, [Optional] string APKIPENOLND)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class PEMFBPJEIIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		protected ELJNLLMJGJF PKEBHPACJJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly IDictionary<string, IDictionary<string, object>> FIHFKJLLIIP;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool MAILGNJFACM
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x686AED0", Offset = "0x686A0D0", VA = "0x18686AED0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public string BBFLDKKHMAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xEF4580", Offset = "0xEF3780", VA = "0x180EF4580")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x686B1B0", Offset = "0x686A3B0", VA = "0x18686B1B0")]
		public PEMFBPJEIIL(ELJNLLMJGJF PKEBHPACJJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x686AE50", Offset = "0x686A050", VA = "0x18686AE50")]
		public PEMFBPJEIIL MGEHOHMJIJL(string FPOONLFOOIF, string OMEFCJCOLII)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x39A1840", Offset = "0x39A0A40", VA = "0x1839A1840")]
		public PEMFBPJEIIL MGEHOHMJIJL<T>(string FPOONLFOOIF, T OMEFCJCOLII) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x686AF10", Offset = "0x686A110", VA = "0x18686AF10")]
		public PEMFBPJEIIL PHNMHHKDFFC(string FPOONLFOOIF, object OMEFCJCOLII)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x39A17B0", Offset = "0x39A09B0", VA = "0x1839A17B0")]
		public PEMFBPJEIIL EFAGGJAFKME<T>(string FPOONLFOOIF, T? OMEFCJCOLII) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x686AAB0", Offset = "0x6869CB0", VA = "0x18686AAB0")]
		public PEMFBPJEIIL EFAGGJAFKME(string FPOONLFOOIF, string OMEFCJCOLII)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x686AF90", Offset = "0x686A190", VA = "0x18686AF90")]
		public PEMFBPJEIIL PHPKPOFIBGH(string LBINFIODLCG, string OFPBICPHALF, object LFDKFEEPNFP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x686B0D0", Offset = "0x686A2D0", VA = "0x18686B0D0")]
		public PEMFBPJEIIL PHPKPOFIBGH(string LBINFIODLCG, IDictionary<string, object> NLCINFOCCID)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x686ADF0", Offset = "0x6869FF0", VA = "0x18686ADF0")]
		private static IDictionary<string, object> MDHEBIECILL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x686AB40", Offset = "0x6869D40", VA = "0x18686AB40")]
		public void KHDIDAHPLKO(bool HMFCEBAJDJG, string DGDJLADEMFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x686A9B0", Offset = "0x6869BB0", VA = "0x18686A9B0")]
		public Task BLMJPBLKHEN([Optional] CancellationToken BGEKICMONBE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2502740", Offset = "0x2501940", VA = "0x182502740", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ELJNLLMJGJF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private struct CAONKAEGIOP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public ELJNLLMJGJF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6863F70", Offset = "0x6863170", VA = "0x186863F70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x68643C0", Offset = "0x68635C0", VA = "0x1868643C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static Action<ELJNLLMJGJF> PPCPJOHOJNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly string IKNPLMCACLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly Dictionary<string, object> EBNFLFLPJHC;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string BBFLDKKHMAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8F4D10", Offset = "0x8F3F10", VA = "0x1808F4D10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6866EC0", Offset = "0x68660C0", VA = "0x186866EC0")]
		private ELJNLLMJGJF(string IKNPLMCACLP, int GOLPFJHCONJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6866D40", Offset = "0x6865F40", VA = "0x186866D40")]
		public static PEMFBPJEIIL LHPCDDMHIBB(string IKNPLMCACLP, int GOLPFJHCONJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6866B90", Offset = "0x6865D90", VA = "0x186866B90")]
		[AsyncStateMachine(typeof(CAONKAEGIOP))]
		public Task BLMJPBLKHEN([Optional] CancellationToken BGEKICMONBE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6866E50", Offset = "0x6866050", VA = "0x186866E50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3053720", Offset = "0x3052920", VA = "0x183053720")]
		internal void LGGGEPPFGHN<T>(string FPOONLFOOIF, T OMEFCJCOLII) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6866C80", Offset = "0x6865E80", VA = "0x186866C80")]
		internal void KGLKMCCIEEO(string FPOONLFOOIF, object OMEFCJCOLII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6866CE0", Offset = "0x6865EE0", VA = "0x186866CE0")]
		internal void LGGGEPPFGHN(string FPOONLFOOIF, string OMEFCJCOLII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x399A0F0", Offset = "0x39992F0", VA = "0x18399A0F0")]
		private void AGFAPENKNGB<T>(string FPOONLFOOIF, T OMEFCJCOLII)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct HHKJMDHPLEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly string OOFMMAGHGOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly long? KLKOLHDJPGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly short? ANLFABLCGJN;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6867D50", Offset = "0x6866F50", VA = "0x186867D50")]
		public HHKJMDHPLEA(string FLLIMHBPIBN, [Optional] long? MOMKFNIIPAA, [Optional] short? GJBDENFAGGI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct OMKKMGCEBCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly int HCCNONKEGCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public readonly string PCBFFANAKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly short EIMHBJOPLJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public readonly string NHFEEADCNCB;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x686A960", Offset = "0x6869B60", VA = "0x18686A960")]
		public OMKKMGCEBCI(int PFBAPBOHHKJ, string HBEFJJDNCKK, short JDILFEIIICO, string FAGFBCDGFKK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class ALBJGNLAJGP : DPACJLLICDK<NAJAGPPINHO, OMKKMGCEBCI, HHKJMDHPLEA>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private string HBEFJJDNCKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private short JDILFEIIICO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private string FAGFBCDGFKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private Dictionary<short, int> DBGBNLKNAGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private int EAIJACDGKCF;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6863EF0", Offset = "0x68630F0", VA = "0x186863EF0")]
		public ALBJGNLAJGP(string EHIDFGOLHLB, Guid LHGOCDBJOGG, long ECCBIDHOHJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6863940", Offset = "0x6862B40", VA = "0x186863940", Slot = "4")]
		public override void GNGLIDLMHFJ(OMKKMGCEBCI LMNBIKDBHCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6862A80", Offset = "0x6861C80", VA = "0x186862A80")]
		public void GBDJALLOPHD(short JDILFEIIICO, bool JMAHJHKKEEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x42CA160", Offset = "0x42C9360", VA = "0x1842CA160")]
		public void MPACKJMKJGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8F2240", Offset = "0x8F1440", VA = "0x1808F2240")]
		public void COEPMHLCAFF(string MDGCCHEPKAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6862B60", Offset = "0x6861D60", VA = "0x186862B60", Slot = "5")]
		public override void GMPJJFGFCDG(bool HIAAMKILJBL, HHKJMDHPLEA JOGFEJNLHCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6863C30", Offset = "0x6862E30", VA = "0x186863C30", Slot = "6")]
		public override KMODDFMLMIK IJHPPDGLBIO(NAJAGPPINHO EIAEFIFNOKF, int CPLNODNGKGB, string KBEFBKPBFOO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class ECDCAIDNKMG : KMODDFMLMIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private string HBEFJJDNCKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly short JDILFEIIICO;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6866700", Offset = "0x6865900", VA = "0x186866700")]
		public ECDCAIDNKMG(long JLMMKKDGEHI, int PFBAPBOHHKJ, string HEICIAFEPOP, long ECCBIDHOHJB, int BJPLKJPDHIM, string OJCLNMHEOIJ, short JDILFEIIICO, string HBEFJJDNCKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6866670", Offset = "0x6865870", VA = "0x186866670")]
		public void LPGEHPOLMPB(int PFBAPBOHHKJ, string HBEFJJDNCKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6866540", Offset = "0x6865740", VA = "0x186866540", Slot = "5")]
		public override PEMFBPJEIIL FNIMKEMLMPE(Guid LOOONPCIKDK, string PIIJHDCCIHD, [Optional] string HEICIAFEPOP, [Optional] long? MJEFOLNDPIB, [Optional] string OJCLNMHEOIJ, [Optional] string APKIPENOLND)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class ILKEAIEFCMP
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class CFCAFBBOKAF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public float nextEventSendTime;

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public CFCAFBBOKAF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6865FC0", Offset = "0x68651C0", VA = "0x186865FC0")]
			internal bool JHDNNNAABPE()
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private struct PHNLHKMGNEI : IAsyncStateMachine
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
			private CFCAFBBOKAF <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private TimeSpan <delayPollingInterval>5__2;

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x686B250", Offset = "0x686A450", VA = "0x18686B250", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x686BF40", Offset = "0x686B140", VA = "0x18686BF40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private struct LANPGMGKHKM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public bool isForcedEvent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6869D00", Offset = "0x6868F00", VA = "0x186869D00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x686A290", Offset = "0x6869490", VA = "0x18686A290", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public static readonly float LAOBJONGKEE;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static AFJINEAEPKI APAGJACOOAN;

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static CancellationTokenSource JCMBEIHBHFP;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static bool IHPFJMGCOLC;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private static int LAGOILLCCIJ;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static readonly NJGCEGGLBKK<PEMFBPJEIIL, bool> MKHADNOPMCL;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static CDDBFCCOBCH<PEMFBPJEIIL, bool> DCMGDOLFDAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6867D90", Offset = "0x6866F90", VA = "0x186867D90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private static bool KOIJGAAOPLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6868AC0", Offset = "0x6867CC0", VA = "0x186868AC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x6868290", Offset = "0x6867490", VA = "0x186868290")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private static bool OKHFDOKKMJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6868A70", Offset = "0x6867C70", VA = "0x186868A70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6868A10", Offset = "0x6867C10", VA = "0x186868A10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private static float JAICDJFALHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6868B10", Offset = "0x6867D10", VA = "0x186868B10")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x68689B0", Offset = "0x6867BB0", VA = "0x1868689B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6868D10", Offset = "0x6867F10", VA = "0x186868D10")]
		[KPFPOENAMPL.IOLLOIHFCAP]
		internal static void LOCFPAKLIKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x68687B0", Offset = "0x68679B0", VA = "0x1868687B0")]
		internal static void GGPOBANFNOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6867DE0", Offset = "0x6866FE0", VA = "0x186867DE0")]
		internal static void BOFJLDDGHJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x68682F0", Offset = "0x68674F0", VA = "0x1868682F0")]
		internal static void EIADOJGFPIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6868E30", Offset = "0x6868030", VA = "0x186868E30")]
		public static void OGKPOLDBKOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6868360", Offset = "0x6867560", VA = "0x186868360")]
		private static void FBGKDCOEMAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6867FA0", Offset = "0x68671A0", VA = "0x186867FA0")]
		private static void DGGKBBMBMHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6868B60", Offset = "0x6867D60", VA = "0x186868B60")]
		[AsyncStateMachine(typeof(PHNLHKMGNEI))]
		private static Task JJIEACLECMN(CancellationToken BGEKICMONBE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6868E80", Offset = "0x6868080", VA = "0x186868E80")]
		private static void OIHFCLFBJLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6868C30", Offset = "0x6867E30", VA = "0x186868C30")]
		[AsyncStateMachine(typeof(LANPGMGKHKM))]
		private static Task KKCCMGAAKIG(bool BEGPDDFFEFD, [Optional] CancellationToken BGEKICMONBE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class DEJBONIOPMB<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class HMJBJMHDEJL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public DEJBONIOPMB<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public HMJBJMHDEJL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x44EABF0", Offset = "0x44E9DF0", VA = "0x1844EABF0")]
			internal object FCPEEJDADHB()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class EOALLLPGPFJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public DEJBONIOPMB<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public EOALLLPGPFJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x3F29300", Offset = "0x3F28500", VA = "0x183F29300")]
			internal object DPEBIFDOOPJ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class HCPEOGMHOMA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public DEJBONIOPMB<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public HCPEOGMHOMA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x44C1A50", Offset = "0x44C0C50", VA = "0x1844C1A50")]
			internal object LOBDDEICCAE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class JEFPKIDJLLP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public DEJBONIOPMB<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public JEFPKIDJLLP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x4820640", Offset = "0x481F840", VA = "0x184820640")]
			internal object CAGMEEJKFBI()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class ALNGNLKNJDE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public DEJBONIOPMB<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public ALNGNLKNJDE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x45348F0", Offset = "0x4533AF0", VA = "0x1845348F0")]
			internal object BNLAABIGENH()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private const float EAKJNHEDAGI = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly Guid LOOONPCIKDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly string OJCLNMHEOIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly string IBDKCCLJNNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private string BPKHPCJJLLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private string APKIPENOLND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private string LAABFOHEPBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private string AHDMBPFECPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private string PKGHFHFOHOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private string GAOAOABJLJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private string BNEGEMLHAJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private Guid? PADMLNJJIPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private (int, int)? GIOEPLNOIJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly HashSet<T> DFFGFIGMPCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly Dictionary<(T, int), string> FMFOGLLGFIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly Dictionary<(T, int), float> GLKFFIMBDKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly Dictionary<T, string> DPAOPNGGEGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly Dictionary<T, string[]> HINDEBGJLMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private string IHFPINANPBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private bool JKDCDMLNKJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private Task NHHLJEHPOOM;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6061590", Offset = "0x6060790", VA = "0x186061590")]
		public DEJBONIOPMB(Guid LOOONPCIKDK, string IBDKCCLJNNP, string OJCLNMHEOIJ, string BPKHPCJJLLK, [Optional] string APKIPENOLND, [Optional] string LAABFOHEPBE, [Optional] string AHDMBPFECPO, [Optional] string BNEGEMLHAJB, [Optional] string IHFPINANPBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8FB0C0", Offset = "0x8FA2C0", VA = "0x1808FB0C0")]
		public void IGNFHFJPMCB(string APKIPENOLND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8F4D40", Offset = "0x8F3F40", VA = "0x1808F4D40")]
		public void DMDHGMILNBJ(string BPKHPCJJLLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xCF3C60", Offset = "0xCF2E60", VA = "0x180CF3C60")]
		public void ADHLBJFHOIN(string IHFPINANPBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8F21B0", Offset = "0x8F13B0", VA = "0x1808F21B0")]
		public void JFOAOMJKEOD(string PKGHFHFOHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6061580", Offset = "0x6060780", VA = "0x186061580")]
		public void PIMGCELPFNP(Guid? LOOONPCIKDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x48568D0", Offset = "0x4855AD0", VA = "0x1848568D0")]
		public void BPBEOBNOJKI((int, int)? GIOEPLNOIJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8F2200", Offset = "0x8F1400", VA = "0x1808F2200")]
		public void NOJBLJILJFB(string GAOAOABJLJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x605EFA0", Offset = "0x605E1A0", VA = "0x18605EFA0")]
		public void GBBABLMMKCN(T MJEFOLNDPIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6061250", Offset = "0x6060450", VA = "0x186061250")]
		public void MLNIANPLKCD(T MJEFOLNDPIB, int DALHPDEHPOC, float NHFPPHNGOPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x60606C0", Offset = "0x605F8C0", VA = "0x1860606C0")]
		public void KNHLGIHBFJD(T MJEFOLNDPIB, int DALHPDEHPOC, string OMPEKPMIAJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x605EDF0", Offset = "0x605DFF0", VA = "0x18605EDF0")]
		public void EIIEKNHBHLL(T MJEFOLNDPIB, string COKGNHFKNEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x605B3A0", Offset = "0x605A5A0", VA = "0x18605B3A0")]
		public void AHEOHKLJIDO(T MJEFOLNDPIB, string[] LCGGIDDAELA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x605B550", Offset = "0x605A750", VA = "0x18605B550")]
		public Task BLMJPBLKHEN(bool DCOODACAFGM = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x605E480", Offset = "0x605D680", VA = "0x18605E480")]
		private (IEnumerable<T>, string) CJGPOFDPKMI()
		{
			return default((IEnumerable<T>, string));
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x605FC60", Offset = "0x605EE60", VA = "0x18605FC60")]
		public static PEMFBPJEIIL KMHCFIIMCBP(Guid LOOONPCIKDK, string IBDKCCLJNNP, T MJEFOLNDPIB, string OJCLNMHEOIJ, string HBKFOHCELKL, string APKIPENOLND, int? CPLNODNGKGB, [Optional] string LEKBKKLCGPC, [Optional] string COKGNHFKNEF, [Optional] int? GHAGBOFCOPO, [Optional] Guid? PADMLNJJIPN, [Optional] string IHFPINANPBH, [Optional] string HEICIAFEPOP, [Optional] (int, int)? GIOEPLNOIJM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x605F500", Offset = "0x605E700", VA = "0x18605F500")]
		[CompilerGenerated]
		private string JBPAKBKHDLD(T BEHEHKFONGA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x605F620", Offset = "0x605E820", VA = "0x18605F620")]
		[CompilerGenerated]
		private string KCLIMFFMAGA(T BEHEHKFONGA)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public abstract class DPACJLLICDK<TItem, TListSessionStartParams, TListSessionLogParams>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		protected readonly string EHIDFGOLHLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		protected readonly Guid LHGOCDBJOGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		protected readonly long ECCBIDHOHJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		protected int PFBAPBOHHKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		protected int APDIBPJENKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		protected DateTime CPFEPEIFMPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		protected bool DKLAPEPIOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		protected Dictionary<long, KMODDFMLMIK> EABEKJDCPIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		protected bool GACIIHDOJPK;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool CCBACAJLKLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xABD7A0", Offset = "0xABC9A0", VA = "0x180ABD7A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HALFMGAKNJN
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xB2C4F0", Offset = "0xB2B6F0", VA = "0x180B2C4F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x60881B0", Offset = "0x60873B0", VA = "0x1860881B0")]
		public DPACJLLICDK(string EHIDFGOLHLB, Guid LHGOCDBJOGG, long ECCBIDHOHJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void GNGLIDLMHFJ(TListSessionStartParams LMNBIKDBHCC);

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xF97DD0", Offset = "0xF96FD0", VA = "0x180F97DD0")]
		public void JHBEJFIHHDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void GMPJJFGFCDG(bool HIAAMKILJBL, TListSessionLogParams JOGFEJNLHCK);

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6087D80", Offset = "0x6086F80", VA = "0x186087D80")]
		public void CNKNLPHJGFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6087EF0", Offset = "0x60870F0", VA = "0x186087EF0")]
		public void GKLKAKCHFIB(long JLMMKKDGEHI, int CPLNODNGKGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6087FC0", Offset = "0x60871C0", VA = "0x186087FC0")]
		public void HLMJIMFJCLE(long JLMMKKDGEHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract KMODDFMLMIK IJHPPDGLBIO(TItem OCLIEIADJMI, int CPLNODNGKGB, string KBEFBKPBFOO);
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class KMODDFMLMIK : KCFJDIKHIDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private int PFBAPBOHHKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private long JLMMKKDGEHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private long ECCBIDHOHJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly string OKEKOIDIPEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly string MPKNHGJNOND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly int BJPLKJPDHIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private DateTime PGAJHLFPGMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private double INHBGPNDFLA;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool GIPPMPFEINP
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xCC4CD0", Offset = "0xCC3ED0", VA = "0x180CC4CD0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xCC4420", Offset = "0xCC3620", VA = "0x180CC4420")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6869C30", Offset = "0x6868E30", VA = "0x186869C30")]
		public KMODDFMLMIK(long JLMMKKDGEHI, int PFBAPBOHHKJ, string HEICIAFEPOP, long ECCBIDHOHJB, int BJPLKJPDHIM, [Optional] string OJCLNMHEOIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6869540", Offset = "0x6868740", VA = "0x186869540")]
		public void ACPLFAMLPDH(int PFBAPBOHHKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6869B70", Offset = "0x6868D70", VA = "0x186869B70")]
		public void HFMBAFGBPFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x68695B0", Offset = "0x68687B0", VA = "0x1868695B0")]
		public void CIMOAGJOPIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6869BC0", Offset = "0x6868DC0", VA = "0x186869BC0")]
		private void JKCIAKGEAGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x68696C0", Offset = "0x68688C0", VA = "0x1868696C0", Slot = "5")]
		public virtual PEMFBPJEIIL FNIMKEMLMPE(Guid LOOONPCIKDK, string PIIJHDCCIHD, [Optional] string HEICIAFEPOP, [Optional] long? MJEFOLNDPIB, [Optional] string OJCLNMHEOIJ, [Optional] string APKIPENOLND)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public static class CBLJKIDIDEE
	{
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static Dictionary<string, Dictionary<string, object>> IBOJKKNFAIN;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static string FHGECELDNOH;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static int FDNKEEBICIM;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static readonly Dictionary<string, JGCBBBAMHMC> JKBJIFJOIAB;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static string ABLAMAJHNCL
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x6864B80", Offset = "0x6863D80", VA = "0x186864B80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x6865970", Offset = "0x6864B70", VA = "0x186865970")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static bool GGMFEOEEFMC
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x6865680", Offset = "0x6864880", VA = "0x186865680")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static Dictionary<string, Dictionary<string, object>> NILMCNFKPIM
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x6865630", Offset = "0x6864830", VA = "0x186865630")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static Guid? PHAOOOGJHOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x6864500", Offset = "0x6863700", VA = "0x186864500")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x68655D0", Offset = "0x68647D0", VA = "0x1868655D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static Guid? OLCOHEIHFEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x6864B10", Offset = "0x6863D10", VA = "0x186864B10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x6865A30", Offset = "0x6864C30", VA = "0x186865A30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6864BD0", Offset = "0x6863DD0", VA = "0x186864BD0")]
		public static void FEGCMODBOIP(string LCGIJMEDFIE, JGCBBBAMHMC JFMDNHHJIJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6864E70", Offset = "0x6864070", VA = "0x186864E70")]
		internal static void GGPOBANFNOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6864420", Offset = "0x6863620", VA = "0x186864420")]
		internal static void BOFJLDDGHJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6864690", Offset = "0x6863890", VA = "0x186864690")]
		internal static void EIADOJGFPIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6864FF0", Offset = "0x68641F0", VA = "0x186864FF0")]
		public static Guid GNGLIDLMHFJ(string LCGIJMEDFIE, [Optional] string? KPEMKAKHODI, [Optional] Dictionary<string, object>? NOBLFFJGHNB)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6864F50", Offset = "0x6864150", VA = "0x186864F50")]
		public static Guid GNGLIDLMHFJ(string LCGIJMEDFIE, long KPEMKAKHODI, [Optional] Dictionary<string, object>? NOBLFFJGHNB)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6865710", Offset = "0x6864910", VA = "0x186865710")]
		public static void JHBEJFIHHDH(string LCGIJMEDFIE, [Optional] Guid? IBPGMNEANFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6864C60", Offset = "0x6863E60", VA = "0x186864C60")]
		public static void FNHIBHMKCEP(string LCGIJMEDFIE, string LBINFIODLCG, object INHMENGCOCC, bool IHPFJMGCOLC = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6865A90", Offset = "0x6864C90", VA = "0x186865A90")]
		public static bool MCLAFKPEAPF(string LCGIJMEDFIE, [Optional] string? KPEMKAKHODI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6865C80", Offset = "0x6864E80", VA = "0x186865C80")]
		private static void NAFELBDJEAC(bool HPBLPAJJAKC = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6865E00", Offset = "0x6865000", VA = "0x186865E00")]
		public static void OKNLFPKFCNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6864570", Offset = "0x6863770", VA = "0x186864570")]
		private static void DGGKBBMBMHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6864710", Offset = "0x6863910", VA = "0x186864710")]
		private static void EONLPLOGCAH(string LCGIJMEDFIE, Guid LOOONPCIKDK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class CLCLFHENFMB
	{
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public struct AAPMANJPPAF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public bool GMKDNLPGIGD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public string OOGMDAJCDJN;

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xABE930", Offset = "0xABDB30", VA = "0x180ABE930")]
			public AAPMANJPPAF(bool GMKDNLPGIGD, string OOGMDAJCDJN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6866220", Offset = "0x6865420", VA = "0x186866220")]
		public static AAPMANJPPAF IKHOJNLBJOK(PEMFBPJEIIL ADHNLNENHHA)
		{
			return default(AAPMANJPPAF);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6866060", Offset = "0x6865260", VA = "0x186866060")]
		private static void FAJAMPNDPMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6866160", Offset = "0x6865360", VA = "0x186866160")]
		private static void HKCIGOFIOKO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class FEAJANMPDEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6867200", Offset = "0x6866400", VA = "0x186867200")]
		public static PEMFBPJEIIL OONPNJIFLHA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class ACDFPDJABAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6862900", Offset = "0x6861B00", VA = "0x186862900")]
		public static PEMFBPJEIIL OPBCGKGAHGA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x68629C0", Offset = "0x6861BC0", VA = "0x1868629C0")]
		public static PEMFBPJEIIL POCJPHGNPKK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x68627E0", Offset = "0x68619E0", VA = "0x1868627E0")]
		public static PEMFBPJEIIL NPFMKMHGOAA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x68628A0", Offset = "0x6861AA0", VA = "0x1868628A0")]
		public static PEMFBPJEIIL OLIJHIMANCA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6862720", Offset = "0x6861920", VA = "0x186862720")]
		public static PEMFBPJEIIL MDFEGOIPNFL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6862840", Offset = "0x6861A40", VA = "0x186862840")]
		public static PEMFBPJEIIL OFACPDJAAFA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6862660", Offset = "0x6861860", VA = "0x186862660")]
		public static PEMFBPJEIIL KDGGJIEJAFF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x68625A0", Offset = "0x68617A0", VA = "0x1868625A0")]
		public static PEMFBPJEIIL FEFIOJFGLCO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x68626C0", Offset = "0x68618C0", VA = "0x1868626C0")]
		public static PEMFBPJEIIL KNFCHIEFINA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6862600", Offset = "0x6861800", VA = "0x186862600")]
		public static PEMFBPJEIIL FIAMCNNLLJM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6862780", Offset = "0x6861980", VA = "0x186862780")]
		public static PEMFBPJEIIL MNDOLAKGNBE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6862A20", Offset = "0x6861C20", VA = "0x186862A20")]
		public static PEMFBPJEIIL PPHEHNIDJDH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6862540", Offset = "0x6861740", VA = "0x186862540")]
		public static PEMFBPJEIIL BJAOGJOMPBN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6862960", Offset = "0x6861B60", VA = "0x186862960")]
		public static PEMFBPJEIIL PEIPIJCCFPA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class GMFNPAAJLMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6867960", Offset = "0x6866B60", VA = "0x186867960")]
		public static PEMFBPJEIIL LPNGBGPKDEA(long MOMKFNIIPAA, long NPLPICCKAOE, bool PGLMCJKJMJJ, string PGLJKLAALMC, string CKPCJKHBNMP)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class EGIEDHKBLPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6866A20", Offset = "0x6865C20", VA = "0x186866A20")]
		public static PEMFBPJEIIL PAFCOEIEMKK(string DLILNEPAIII, string BMHAJJDLGEA, bool GIJCDIBHHCD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x68667F0", Offset = "0x68659F0", VA = "0x1868667F0")]
		public static PEMFBPJEIIL LGMDKKIBMIN(string GCGNIOHLIKK, string AOGHBLLFJBE, string JMCDPEIKAGJ, [Optional] int? IMGAPDKPNNJ, [Optional] double[] NMDODOKINJD)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class FLDCIIJCOKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6867340", Offset = "0x6866540", VA = "0x186867340")]
		public static PEMFBPJEIIL BONKNNHCEGP(string DKJFCMNDICP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6867260", Offset = "0x6866460", VA = "0x186867260")]
		public static PEMFBPJEIIL ANDOLPOJLLP(string AMNCLIBJKOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6867570", Offset = "0x6866770", VA = "0x186867570")]
		public static PEMFBPJEIIL FPINJIDDCLD(int GOLPFJHCONJ, string LMOANCJLHKC, string BEHEHKFONGA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x68675D0", Offset = "0x68667D0", VA = "0x1868675D0")]
		public static PEMFBPJEIIL IAFOHCHDEHG(int GOLPFJHCONJ, string LMOANCJLHKC, string BEHEHKFONGA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6867690", Offset = "0x6866890", VA = "0x186867690")]
		public static PEMFBPJEIIL KPNHPAEDKJJ(int GOLPFJHCONJ, string LMOANCJLHKC, string BEHEHKFONGA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6867630", Offset = "0x6866830", VA = "0x186867630")]
		public static PEMFBPJEIIL JNJHGMEMCIE(int GOLPFJHCONJ, string LMOANCJLHKC, string BEHEHKFONGA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6867420", Offset = "0x6866620", VA = "0x186867420")]
		public static PEMFBPJEIIL COPNKEANBJJ(string LMOANCJLHKC, string BEHEHKFONGA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x68676F0", Offset = "0x68668F0", VA = "0x1868676F0")]
		private static PEMFBPJEIIL PMIIALNLCFH(string EHIDFGOLHLB, int GOLPFJHCONJ, string CDDFDPKAPGH, string ENFDOFGLDLF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6867830", Offset = "0x6866A30", VA = "0x186867830")]
		private static PEMFBPJEIIL PMIIALNLCFH(string EHIDFGOLHLB, string CDDFDPKAPGH, string ENFDOFGLDLF)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly KJMCEDJMPPA IKHOJNLBJOK;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static APNCMACBPPC NFFIDCIINOL;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static PNCMHJOGIEA HEBGDLIGJOG;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static Queue<PEMFBPJEIIL> EDMDCNKCOHG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private static long DKKIFJBBJBL
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6869170", Offset = "0x6868370", VA = "0x186869170")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6869070", Offset = "0x6868270", VA = "0x186869070")]
	[KPFPOENAMPL.IOLLOIHFCAP]
	internal static void DFKOGNHAJHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x68692E0", Offset = "0x68684E0", VA = "0x1868692E0")]
	private static void KFPFNJMKPPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6869260", Offset = "0x6868460", VA = "0x186869260")]
	public static PEMFBPJEIIL GNEPHHGBHFM(string IKNPLMCACLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6866D40", Offset = "0x6865F40", VA = "0x186866D40")]
	public static PEMFBPJEIIL GNEPHHGBHFM(string IKNPLMCACLP, int GOLPFJHCONJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x68693B0", Offset = "0x68685B0", VA = "0x1868693B0")]
	[KPFPOENAMPL.IOLLOIHFCAP]
	internal static void MPHIBPBHNAJ()
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
