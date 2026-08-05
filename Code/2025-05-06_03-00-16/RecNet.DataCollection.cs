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
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7063FE0", Offset = "0x70627E0", VA = "0x187063FE0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA09330", Offset = "0xA07B30", VA = "0x180A09330")]
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
		[Cpp2IlInjected.Address(RVA = "0xA09370", Offset = "0xA07B70", VA = "0x180A09370")]
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
	public class LogRegistrationIndex : ONLGCKOFHPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7062CC0", Offset = "0x70614C0", VA = "0x187062CC0", Slot = "4")]
		public override void JNEAPGDNFGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x70676A0", Offset = "0x7065EA0", VA = "0x1870676A0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2612DF0", Offset = "0x26115F0", VA = "0x182612DF0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface GHBNLEKPNPK
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyDictionary<string, object> FEGCGCNJGJG();
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class AEMMCDBPAGJ
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x705DA50", Offset = "0x705C250", VA = "0x18705DA50")]
	public static void FPDIBONHKLE(this DFGMIMOMCJE.EKCOIOJPLKN PBCIOBAONLI, string IBILPKECMKH, string MMNCCGKPEGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x705DBC0", Offset = "0x705C3C0", VA = "0x18705DBC0")]
	public static void FPDIBONHKLE(this DFGMIMOMCJE.EKCOIOJPLKN PBCIOBAONLI, string IBILPKECMKH, bool MMNCCGKPEGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x705DAC0", Offset = "0x705C2C0", VA = "0x18705DAC0")]
	public static void FPDIBONHKLE(this DFGMIMOMCJE.EKCOIOJPLKN PBCIOBAONLI, string IBILPKECMKH, float OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x705DC50", Offset = "0x705C450", VA = "0x18705DC50")]
	public static void FPDIBONHKLE(this DFGMIMOMCJE.EKCOIOJPLKN PBCIOBAONLI, string IBILPKECMKH, NNHNFLMHDFD MMNCCGKPEGC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class DFGMIMOMCJE
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface IKFBNAOHKPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		EKCOIOJPLKN EBCAIJGEFAP(Guid BFGLGAEMILF, string NABMKEMKKNK, [Optional] string PMMPBDGCHLM, [Optional] long? PHNEMPKNGHL, [Optional] string GNFJAIOMBHP, [Optional] string EEDNLNMEBAD);
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class GJFPMELBOIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7061B00", Offset = "0x7060300", VA = "0x187061B00")]
		public static EKCOIOJPLKN HIIINFKNAGM(Guid BFGLGAEMILF, string NABMKEMKKNK, string PMMPBDGCHLM, [Optional] long? PHNEMPKNGHL, [Optional] string GNFJAIOMBHP, [Optional] string EEDNLNMEBAD)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class EKCOIOJPLKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		protected OLEBONKIIDN BKLKAFKNCOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly IDictionary<string, IDictionary<string, object>> BMOOOBCNPPI;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool PHJMCFBNBPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x70609A0", Offset = "0x705F1A0", VA = "0x1870609A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public string JGLGDHEHHIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x10BC830", Offset = "0x10BB030", VA = "0x1810BC830")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7060E10", Offset = "0x705F610", VA = "0x187060E10")]
		public EKCOIOJPLKN(OLEBONKIIDN BKLKAFKNCOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7060920", Offset = "0x705F120", VA = "0x187060920")]
		public EKCOIOJPLKN ECNIKCJJIJA(string KIIAJPLCJIE, string OPMIAMEJKDH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3E87D30", Offset = "0x3E86530", VA = "0x183E87D30")]
		public EKCOIOJPLKN ECNIKCJJIJA<T>(string KIIAJPLCJIE, T OPMIAMEJKDH) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7060D90", Offset = "0x705F590", VA = "0x187060D90")]
		public EKCOIOJPLKN PJFCHEGAFBD(string KIIAJPLCJIE, object OPMIAMEJKDH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3E88160", Offset = "0x3E86960", VA = "0x183E88160")]
		public EKCOIOJPLKN MPPIOACMDOH<T>(string KIIAJPLCJIE, T? OPMIAMEJKDH) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7060D00", Offset = "0x705F500", VA = "0x187060D00")]
		public EKCOIOJPLKN MPPIOACMDOH(string KIIAJPLCJIE, string OPMIAMEJKDH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7060BC0", Offset = "0x705F3C0", VA = "0x187060BC0")]
		public EKCOIOJPLKN KCCIMEICGGI(string EHDEEBPPLPI, string BELIEAFHDAH, object NFNBKNAJBPN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7060AE0", Offset = "0x705F2E0", VA = "0x187060AE0")]
		public EKCOIOJPLKN KCCIMEICGGI(string EHDEEBPPLPI, IDictionary<string, object> FBJFJEKNKKG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7060600", Offset = "0x705EE00", VA = "0x187060600")]
		private static IDictionary<string, object> AEGNKDGDIJE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7060660", Offset = "0x705EE60", VA = "0x187060660")]
		public void DJDCDAEBEON(bool AFELLPINFJD, string AEILOHCLHIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x70609E0", Offset = "0x705F1E0", VA = "0x1870609E0")]
		public Task INLBBKDHIND([Optional] CancellationToken DNHBNMHIDAC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2742380", Offset = "0x2740B80", VA = "0x182742380", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class OLEBONKIIDN
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private struct FLADCHMNNFF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public OLEBONKIIDN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7061090", Offset = "0x705F890", VA = "0x187061090", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7061500", Offset = "0x705FD00", VA = "0x187061500", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static Action<OLEBONKIIDN> NHEAKIOOMFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly string LPNCCAFPPMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly Dictionary<string, object> GMHMEIKLAOE;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string JGLGDHEHHIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7065580", Offset = "0x7063D80", VA = "0x187065580")]
		private OLEBONKIIDN(string LPNCCAFPPMJ, int DCILOEIKONN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x705F960", Offset = "0x705E160", VA = "0x18705F960")]
		public static EKCOIOJPLKN NKIHIDGHACP(string LPNCCAFPPMJ, int DCILOEIKONN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7065420", Offset = "0x7063C20", VA = "0x187065420")]
		[AsyncStateMachine(typeof(FLADCHMNNFF))]
		public Task INLBBKDHIND([Optional] CancellationToken DNHBNMHIDAC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7065510", Offset = "0x7063D10", VA = "0x187065510", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x358D310", Offset = "0x358BB10", VA = "0x18358D310")]
		internal void CGBCNNNALOP<T>(string KIIAJPLCJIE, T OPMIAMEJKDH) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x70653C0", Offset = "0x7063BC0", VA = "0x1870653C0")]
		internal void FCAKPNIIACK(string KIIAJPLCJIE, object OPMIAMEJKDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7065360", Offset = "0x7063B60", VA = "0x187065360")]
		internal void CGBCNNNALOP(string KIIAJPLCJIE, string OPMIAMEJKDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3E8D0F0", Offset = "0x3E8B8F0", VA = "0x183E8D0F0")]
		private void JIIOEBOAIEO<T>(string KIIAJPLCJIE, T OPMIAMEJKDH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct JGKKMHOJJDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly string PBMOIABMPMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly long? MPBMECOMGLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly short? IHEIFMFCJPP;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7062480", Offset = "0x7060C80", VA = "0x187062480")]
		public JGKKMHOJJDL(string GCPOCLGIEGG, [Optional] long? MDLDCACFGIB, [Optional] short? BGAHMMIKAOP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct MBFCNJGLAEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly int FDDPALNEKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public readonly string CONECMBDILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly short ANBCKLFODBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public readonly string MKHDGNGAIPK;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7062D50", Offset = "0x7061550", VA = "0x187062D50")]
		public MBFCNJGLAEO(int IAHPPNANHJK, string HJJPMCHLKGE, short NBEHPJGDDFM, string IHIFBJAOFEJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class DEKAIGPKDLK : AOJBLAJMKDC<MMJIDHMFHJL, MBFCNJGLAEO, JGKKMHOJJDL>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private string HJJPMCHLKGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private short NBEHPJGDDFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private string IHIFBJAOFEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private Dictionary<short, int> KGFLAIEOOAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private int CCOEGPJAPGM;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x705F7A0", Offset = "0x705DFA0", VA = "0x18705F7A0")]
		public DEKAIGPKDLK(string AGNFFHDHLHM, Guid AHOFJPCDMOB, long GGHJBHADPCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x705F120", Offset = "0x705D920", VA = "0x18705F120", Slot = "4")]
		public override void IPLCGEDHMLN(MBFCNJGLAEO HBIAHHBOOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x705F6C0", Offset = "0x705DEC0", VA = "0x18705F6C0")]
		public void PDEPLDAHAEO(short NBEHPJGDDFM, bool HBKBHAKMAJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4850C80", Offset = "0x484F480", VA = "0x184850C80")]
		public void FHELBCEKCCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1B0", Offset = "0x9DB9B0", VA = "0x1809DD1B0")]
		public void KOFCBCFILGC(string LKGNAGAPPDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x705E340", Offset = "0x705CB40", VA = "0x18705E340", Slot = "5")]
		public override void FMFCJGBJNGD(bool IGJNLGCMNIL, JGKKMHOJJDL PCNHCCFGEJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x705F410", Offset = "0x705DC10", VA = "0x18705F410", Slot = "6")]
		public override EGLEPMJJGPD LJEGJOMFMKG(MMJIDHMFHJL EIBKAOMPGLM, int FPEOONOJHML, string DGJBPKGLCOM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class IGLJMJNGGAE : EGLEPMJJGPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private string HJJPMCHLKGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly short NBEHPJGDDFM;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7062390", Offset = "0x7060B90", VA = "0x187062390")]
		public IGLJMJNGGAE(long PJFNCPIJCFE, int IAHPPNANHJK, string PMMPBDGCHLM, long GGHJBHADPCF, int BKJFKOOJLNM, string GNFJAIOMBHP, short NBEHPJGDDFM, string HJJPMCHLKGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7062310", Offset = "0x7060B10", VA = "0x187062310")]
		public void NKGJJEMJEHI(int IAHPPNANHJK, string HJJPMCHLKGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x70621E0", Offset = "0x70609E0", VA = "0x1870621E0", Slot = "5")]
		public override EKCOIOJPLKN EBCAIJGEFAP(Guid BFGLGAEMILF, string NABMKEMKKNK, [Optional] string PMMPBDGCHLM, [Optional] long? PHNEMPKNGHL, [Optional] string GNFJAIOMBHP, [Optional] string EEDNLNMEBAD)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class MHAAKKFECHN
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class KEDDMNIJBFJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public float nextEventSendTime;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public KEDDMNIJBFJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x7062BC0", Offset = "0x70613C0", VA = "0x187062BC0")]
			internal bool PLALBAJMHGN()
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private struct OHAGKCPACPA : IAsyncStateMachine
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
			private KEDDMNIJBFJ <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private TimeSpan <delayPollingInterval>5__2;

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x7064640", Offset = "0x7062E40", VA = "0x187064640", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x7065300", Offset = "0x7063B00", VA = "0x187065300", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private struct OCFILKJIHJJ : IAsyncStateMachine
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
			[Cpp2IlInjected.Address(RVA = "0x7064060", Offset = "0x7062860", VA = "0x187064060", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x70645E0", Offset = "0x7062DE0", VA = "0x1870645E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public static readonly float AFBCGKGCGJF;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static AGPOKEKNOGC HFMDFHLKMEB;

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static CancellationTokenSource FNBCHBAPDFK;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static bool PKEFNBKPFHI;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private static int NLDPMLDKENC;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static readonly LLDDHLANFDF<EKCOIOJPLKN, bool> EPNBOHDHIMF;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static FFOACGGAIDA<EKCOIOJPLKN, bool> DHOFPGIMOIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x7062DA0", Offset = "0x70615A0", VA = "0x187062DA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private static bool NHLEEJLGCKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x7063120", Offset = "0x7061920", VA = "0x187063120")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7063660", Offset = "0x7061E60", VA = "0x187063660")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private static bool CPNMHDIFFIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7062EC0", Offset = "0x70616C0", VA = "0x187062EC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7063170", Offset = "0x7061970", VA = "0x187063170")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private static float GFFAEIDKBEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7063B40", Offset = "0x7062340", VA = "0x187063B40")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x70630C0", Offset = "0x70618C0", VA = "0x1870630C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7063B90", Offset = "0x7062390", VA = "0x187063B90")]
		[KBINEFBNEHG.IPHNODGJKFI]
		internal static void NDCPKMHCMMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7063D10", Offset = "0x7062510", VA = "0x187063D10")]
		internal static void NPIOKLMMDIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7062F10", Offset = "0x7061710", VA = "0x187062F10")]
		internal static void IMAIJACFOFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7063CB0", Offset = "0x70624B0", VA = "0x187063CB0")]
		internal static void NODBBEFEAMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7063AF0", Offset = "0x70622F0", VA = "0x187063AF0")]
		public static void MABMNKDGAJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x70636C0", Offset = "0x7061EC0", VA = "0x1870636C0")]
		private static void LCNBLDMMJPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x70632A0", Offset = "0x7061AA0", VA = "0x1870632A0")]
		private static void JPGCIFNGJOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7062DF0", Offset = "0x70615F0", VA = "0x187062DF0")]
		[AsyncStateMachine(typeof(OHAGKCPACPA))]
		private static Task FHINKFMOIHL(CancellationToken DNHBNMHIDAC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x70631D0", Offset = "0x70619D0", VA = "0x1870631D0")]
		private static void JIMLOBCEAIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7063580", Offset = "0x7061D80", VA = "0x187063580")]
		[AsyncStateMachine(typeof(OCFILKJIHJJ))]
		private static Task KGAEPLEHDJI(bool DGCCFGDFIGA, [Optional] CancellationToken DNHBNMHIDAC)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class LPNDHDJLGNC<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class CCFMFJPDJIJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public LPNDHDJLGNC<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public CCFMFJPDJIJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x630B9E0", Offset = "0x630A1E0", VA = "0x18630B9E0")]
			internal object BHPPEPJKGCO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class JPBFDJNAAGJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public LPNDHDJLGNC<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public JPBFDJNAAGJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x4E2E8D0", Offset = "0x4E2D0D0", VA = "0x184E2E8D0")]
			internal object LKKIFKIBDBA()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class KKHHLGACBKA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public LPNDHDJLGNC<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public KKHHLGACBKA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x4F2BEE0", Offset = "0x4F2A6E0", VA = "0x184F2BEE0")]
			internal object DPNOOHNKCNK()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class LFBINBHEGOJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public LPNDHDJLGNC<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public LFBINBHEGOJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x4FDCAD0", Offset = "0x4FDB2D0", VA = "0x184FDCAD0")]
			internal object BNLDILAFAGC()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class FLAAECGMODG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public LPNDHDJLGNC<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public FLAAECGMODG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x48D2770", Offset = "0x48D0F70", VA = "0x1848D2770")]
			internal object PLACLGCJKBM()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class CCOLMBJOIFN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public LPNDHDJLGNC<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public CCOLMBJOIFN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x630BC60", Offset = "0x630A460", VA = "0x18630BC60")]
			internal object HBHOAMDOFEL()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class KACGBLANBJJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public LPNDHDJLGNC<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public KACGBLANBJJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x4EE93D0", Offset = "0x4EE7BD0", VA = "0x184EE93D0")]
			internal object BMNPFLNHKFP()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private const float GGOPABPBNDB = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly Guid BFGLGAEMILF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly string GNFJAIOMBHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly string GHONOEJLAOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private string DLKCBEMJKCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private string EEDNLNMEBAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private string JPADDLPPELE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private string INMLDOELJGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private string HCJCDOCPGIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private string OABPABOFNFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private string HGIGNEOOOHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private string EAOLGCJOBCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private string PPHOKCIGDJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Guid? MKALHCGOJKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private (int, int)? DECFBGMMOLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly HashSet<T> NMJLGLNLHDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly Dictionary<(T, int), string> MLAHKEAHHGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly Dictionary<(T, int), float> NFKOJMABFNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly Dictionary<T, string> LBBDPBNGELA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly Dictionary<T, string> ALLPFPCAMAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly Dictionary<T, string> MBIFDEMFGAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly Dictionary<T, string[]> BPJACBKJENF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private string FMHOGKBDFAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private bool CBFLDHIIEEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private Task EPHLCEBEHPI;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5026910", Offset = "0x5025110", VA = "0x185026910")]
		public LPNDHDJLGNC(Guid BFGLGAEMILF, string GHONOEJLAOP, string GNFJAIOMBHP, string DLKCBEMJKCN, [Optional] string EEDNLNMEBAD, [Optional] string JPADDLPPELE, [Optional] string INMLDOELJGM, [Optional] string HGIGNEOOOHC, [Optional] string FMHOGKBDFAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DC0", Offset = "0x9DF5C0", VA = "0x1809E0DC0")]
		public void KHGGJPOBMGD(string EEDNLNMEBAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9DF750", Offset = "0x9DDF50", VA = "0x1809DF750")]
		public void ELHJHCNJNPC(string DLKCBEMJKCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xA76EB0", Offset = "0xA756B0", VA = "0x180A76EB0")]
		public void DIJNMDNOOCK(string FMHOGKBDFAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9DD240", Offset = "0x9DBA40", VA = "0x1809DD240")]
		public void IBAPDDMCFEN(string HCJCDOCPGIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1B0", Offset = "0x9DB9B0", VA = "0x1809DD1B0")]
		public void ELNBEJPBPKA(string EAOLGCJOBCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1E0", Offset = "0x9DB9E0", VA = "0x1809DD1E0")]
		public void FHKFAELKEGE(string PPHOKCIGDJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x50237C0", Offset = "0x5021FC0", VA = "0x1850237C0")]
		public void JAKINKODEND(Guid? BFGLGAEMILF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x4F3B200", Offset = "0x4F39A00", VA = "0x184F3B200")]
		public void DBAEPJPHIMB((int, int)? DECFBGMMOLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1D0", Offset = "0x9DB9D0", VA = "0x1809DD1D0")]
		public void CHFOHIBOJCK(string OABPABOFNFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5026780", Offset = "0x5024F80", VA = "0x185026780")]
		public void PLCOPCILHEI(T PHNEMPKNGHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x5025DD0", Offset = "0x50245D0", VA = "0x185025DD0")]
		public void OFNLPJBCEMM(T PHNEMPKNGHL, int DPOOMFNDPKA, float DJFBMECKBEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x5024DB0", Offset = "0x50235B0", VA = "0x185024DB0")]
		public void NFCECCBHBPE(T PHNEMPKNGHL, int DPOOMFNDPKA, string LOFHCOFILBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x50203E0", Offset = "0x501EBE0", VA = "0x1850203E0")]
		public void IAOOBFPIKJP(T PHNEMPKNGHL, string IFBKEJGKJPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x501F760", Offset = "0x501DF60", VA = "0x18501F760")]
		public void ALNIOCFCLEN(T PHNEMPKNGHL, string JJPMAEPJGKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x5025550", Offset = "0x5023D50", VA = "0x185025550")]
		public void OABJLDLEDJO(T PHNEMPKNGHL, bool MLBMDOBHAGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x501FED0", Offset = "0x501E6D0", VA = "0x18501FED0")]
		public void EKFOOGDOKML(T PHNEMPKNGHL, string[] JHPMENLNBDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x5021760", Offset = "0x501FF60", VA = "0x185021760")]
		public Task INLBBKDHIND(bool IOHDICMKADP = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x50237E0", Offset = "0x5021FE0", VA = "0x1850237E0")]
		private (IEnumerable<T>, string) JLHHFPKDJKF()
		{
			return default((IEnumerable<T>, string));
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x501EC00", Offset = "0x501D400", VA = "0x18501EC00")]
		public static EKCOIOJPLKN AJEANFALDFK(Guid BFGLGAEMILF, string GHONOEJLAOP, T PHNEMPKNGHL, string GNFJAIOMBHP, string GJJBHOOMEIH, string EEDNLNMEBAD, int? FPEOONOJHML, [Optional] string HDMPLAEIFLC, [Optional] string IFBKEJGKJPA, [Optional] int? DGJMIPFEKEF, [Optional] Guid? MKALHCGOJKF, [Optional] string FMHOGKBDFAE, [Optional] string PMMPBDGCHLM, [Optional] (int, int)? DECFBGMMOLE, [Optional] string JMBJFFFCANB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x5024B70", Offset = "0x5023370", VA = "0x185024B70")]
		[CompilerGenerated]
		private string JPNDOBJFMFK(T MLBCMOLHELH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x5024C00", Offset = "0x5023400", VA = "0x185024C00")]
		[CompilerGenerated]
		private string KJDNIEAIDEB(T MLBCMOLHELH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x501F9E0", Offset = "0x501E1E0", VA = "0x18501F9E0")]
		[CompilerGenerated]
		private string CEFCPAOCFEE(T MLBCMOLHELH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x50201A0", Offset = "0x501E9A0", VA = "0x1850201A0")]
		[CompilerGenerated]
		private string HHCGLJDJLEL(T MLBCMOLHELH)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public abstract class AOJBLAJMKDC<TItem, TListSessionStartParams, TListSessionLogParams>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		protected readonly string AGNFFHDHLHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		protected readonly Guid AHOFJPCDMOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		protected readonly long GGHJBHADPCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		protected int IAHPPNANHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		protected int AFJFGMPCCJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		protected DateTime PNJBCNMPDMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		protected bool INAKONCEBFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		protected Dictionary<long, EGLEPMJJGPD> NJKOLNNPIBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		protected bool LDEPENBNEFC;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool DJIPACMCJML
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xBFD9F0", Offset = "0xBFC1F0", VA = "0x180BFD9F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool OCPPDMMLOGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xC52870", Offset = "0xC51070", VA = "0x180C52870")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x4AED790", Offset = "0x4AEBF90", VA = "0x184AED790")]
		public AOJBLAJMKDC(string AGNFFHDHLHM, Guid AHOFJPCDMOB, long GGHJBHADPCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void IPLCGEDHMLN(TListSessionStartParams HBIAHHBOOPM);

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x4AED3F0", Offset = "0x4AEBBF0", VA = "0x184AED3F0")]
		public void GIFPGMJKPHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void FMFCJGBJNGD(bool IGJNLGCMNIL, TListSessionLogParams PCNHCCFGEJD);

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x4AED3A0", Offset = "0x4AEBBA0", VA = "0x184AED3A0")]
		public void DMKKOAIMICM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x4AED520", Offset = "0x4AEBD20", VA = "0x184AED520")]
		public void PKGJJANJNBI(long PJFNCPIJCFE, int FPEOONOJHML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x4AED400", Offset = "0x4AEBC00", VA = "0x184AED400")]
		public void MIBKMKLDABI(long PJFNCPIJCFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract EGLEPMJJGPD LJEGJOMFMKG(TItem BLFLGKHLJNB, int FPEOONOJHML, string DGJBPKGLCOM);
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class EGLEPMJJGPD : IKFBNAOHKPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private int IAHPPNANHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private long PJFNCPIJCFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private long GGHJBHADPCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly string GGHPFJOKLPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly string DIPAIHCOFBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly int BKJFKOOJLNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private DateTime KOPDKLNENFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private double MDMNABGFOAF;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool OBDHAIGIPCO
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xDFC880", Offset = "0xDFB080", VA = "0x180DFC880")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xDFC280", Offset = "0xDFAA80", VA = "0x180DFC280")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7060530", Offset = "0x705ED30", VA = "0x187060530")]
		public EGLEPMJJGPD(long PJFNCPIJCFE, int IAHPPNANHJK, string PMMPBDGCHLM, long GGHJBHADPCF, int BKJFKOOJLNM, [Optional] string GNFJAIOMBHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7060360", Offset = "0x705EB60", VA = "0x187060360")]
		public void FNMIHJCOGJP(int IAHPPNANHJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x70603D0", Offset = "0x705EBD0", VA = "0x1870603D0")]
		public void LOLIDCBGCFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7060420", Offset = "0x705EC20", VA = "0x187060420")]
		public void MAPNPEPNMAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x705FE50", Offset = "0x705E650", VA = "0x18705FE50")]
		private void COOAOKLMACG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x705FEB0", Offset = "0x705E6B0", VA = "0x18705FEB0", Slot = "5")]
		public virtual EKCOIOJPLKN EBCAIJGEFAP(Guid BFGLGAEMILF, string NABMKEMKKNK, [Optional] string PMMPBDGCHLM, [Optional] long? PHNEMPKNGHL, [Optional] string GNFJAIOMBHP, [Optional] string EEDNLNMEBAD)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class ONIFMHNPOBL
	{
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private static Dictionary<string, Dictionary<string, object>> HHLEHAGPFNI;

		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private static string JPEDHIJAJDB;

		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private static int LPBJMJIJPFK;

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private static readonly Dictionary<string, GHBNLEKPNPK> PIINAIDOLKB;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static string IBKAMPBMCNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x7065D60", Offset = "0x7064560", VA = "0x187065D60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x7066FD0", Offset = "0x70657D0", VA = "0x187066FD0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static bool CFCAKCNFHMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x7066F40", Offset = "0x7065740", VA = "0x187066F40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static Dictionary<string, Dictionary<string, object>> FIFKJLNOIBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x7066010", Offset = "0x7064810", VA = "0x187066010")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static Guid? DAPOBEBKLNH
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x7066D10", Offset = "0x7065510", VA = "0x187066D10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x7065D00", Offset = "0x7064500", VA = "0x187065D00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static Guid? INFHIPPCJBL
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x7066E80", Offset = "0x7065680", VA = "0x187066E80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x7066EE0", Offset = "0x70656E0", VA = "0x187066EE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x70671E0", Offset = "0x70659E0", VA = "0x1870671E0")]
		public static void PGIIMGLKAFE(string ONGCKADLMJL, GHBNLEKPNPK HFNKFOIFBJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7067100", Offset = "0x7065900", VA = "0x187067100")]
		internal static void NPIOKLMMDIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x70665C0", Offset = "0x7064DC0", VA = "0x1870665C0")]
		internal static void IMAIJACFOFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7067080", Offset = "0x7065880", VA = "0x187067080")]
		internal static void NODBBEFEAMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x70666A0", Offset = "0x7064EA0", VA = "0x1870666A0")]
		public static Guid IPLCGEDHMLN(string ONGCKADLMJL, [Optional] string? AFJEFIMCONH, [Optional] Dictionary<string, object>? NCNOAABJDHE)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7066C70", Offset = "0x7065470", VA = "0x187066C70")]
		public static Guid IPLCGEDHMLN(string ONGCKADLMJL, long AFJEFIMCONH, [Optional] Dictionary<string, object>? NCNOAABJDHE)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7065DB0", Offset = "0x70645B0", VA = "0x187065DB0")]
		public static void GIFPGMJKPHL(string ONGCKADLMJL, [Optional] Guid? BGPPHEMBCAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7065AB0", Offset = "0x70642B0", VA = "0x187065AB0")]
		public static void BKDFNNHDEPM(string ONGCKADLMJL, string EHDEEBPPLPI, object AJCOCPJIAFF, bool PKEFNBKPFHI = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x70658C0", Offset = "0x70640C0", VA = "0x1870658C0")]
		public static bool ABAEOOPBHNN(string ONGCKADLMJL, [Optional] string? AFJEFIMCONH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7066060", Offset = "0x7064860", VA = "0x187066060")]
		private static void HGNLLLDDEFA(bool OALDINDDPPD = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7065CB0", Offset = "0x70644B0", VA = "0x187065CB0")]
		public static void ELHMMNOPPMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7066D70", Offset = "0x7065570", VA = "0x187066D70")]
		private static void JPGCIFNGJOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x70661D0", Offset = "0x70649D0", VA = "0x1870661D0")]
		private static void IFNLEFONMEJ(string ONGCKADLMJL, Guid BFGLGAEMILF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public static class GODPMELJJFA
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public struct FACDJKJECJJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public bool EJCCGIABFNE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public string EEELONGPGHO;

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xBFE400", Offset = "0xBFCC00", VA = "0x180BFE400")]
			public FACDJKJECJJ(bool EJCCGIABFNE, string EEELONGPGHO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7061D10", Offset = "0x7060510", VA = "0x187061D10")]
		public static FACDJKJECJJ BAOGIJBMDME(EKCOIOJPLKN PBCIOBAONLI)
		{
			return default(FACDJKJECJJ);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7062020", Offset = "0x7060820", VA = "0x187062020")]
		private static void CDMFNECMFBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7062120", Offset = "0x7060920", VA = "0x187062120")]
		private static void OOEDFLGJMOJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class KGOLCFLLKIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7062C60", Offset = "0x7061460", VA = "0x187062C60")]
		public static EKCOIOJPLKN HFEGHHGLGHJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class GGDOFDDHJPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x70616E0", Offset = "0x705FEE0", VA = "0x1870616E0")]
		public static EKCOIOJPLKN GEPAEHLNLHL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7061920", Offset = "0x7060120", VA = "0x187061920")]
		public static EKCOIOJPLKN JIKKJHGCMMO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7061AA0", Offset = "0x70602A0", VA = "0x187061AA0")]
		public static EKCOIOJPLKN POKDFFKHGEF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7061800", Offset = "0x7060000", VA = "0x187061800")]
		public static EKCOIOJPLKN GNCBOLEFKBF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x70618C0", Offset = "0x70600C0", VA = "0x1870618C0")]
		public static EKCOIOJPLKN IBPJHMCGPID()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7061620", Offset = "0x705FE20", VA = "0x187061620")]
		public static EKCOIOJPLKN FPLCEJFJGJH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7061740", Offset = "0x705FF40", VA = "0x187061740")]
		public static EKCOIOJPLKN GHEHPJKDKGK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x70617A0", Offset = "0x705FFA0", VA = "0x1870617A0")]
		public static EKCOIOJPLKN GHNDPPOBDPG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7061560", Offset = "0x705FD60", VA = "0x187061560")]
		public static EKCOIOJPLKN ABBGGNDHFHA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7061980", Offset = "0x7060180", VA = "0x187061980")]
		public static EKCOIOJPLKN LONODDPGEAF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7061680", Offset = "0x705FE80", VA = "0x187061680")]
		public static EKCOIOJPLKN GDAKNPMKABG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x70619E0", Offset = "0x70601E0", VA = "0x1870619E0")]
		public static EKCOIOJPLKN PFMBJOLONOM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x70615C0", Offset = "0x705FDC0", VA = "0x1870615C0")]
		public static EKCOIOJPLKN DKBGLBACAEH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7061A40", Offset = "0x7060240", VA = "0x187061A40")]
		public static EKCOIOJPLKN PMAAFDBANOJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7061860", Offset = "0x7060060", VA = "0x187061860")]
		public static EKCOIOJPLKN IBJLGFIIMCA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class FAHMKAGICOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7060EB0", Offset = "0x705F6B0", VA = "0x187060EB0")]
		public static EKCOIOJPLKN AKNPDPCHNMA(long MDLDCACFGIB, long ODGNDMLNOIH, bool JKLPCBPFCMF, string DBODBIIJNPP, string GKHDMFBMIFL)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class BCMAKNBOOAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x705DFA0", Offset = "0x705C7A0", VA = "0x18705DFA0")]
		public static EKCOIOJPLKN KFOLFNFIKNJ(string DLNMMMCBHHC, string MFHOKFPGJAD, bool BBIBCICOBEB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x705E110", Offset = "0x705C910", VA = "0x18705E110")]
		public static EKCOIOJPLKN NKFLGJDMPEP(string KLNHOILIBHH, string BLMABEPFNMK, string PCKHGCIFPNH, [Optional] int? NBAEEPOFKCC, [Optional] double[] GIKLMKEDLDB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class KDFIEBOBHCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7062A80", Offset = "0x7061280", VA = "0x187062A80")]
		public static EKCOIOJPLKN NEODELFGAGO(string FPOBAMJGJKD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x70625E0", Offset = "0x7060DE0", VA = "0x1870625E0")]
		public static EKCOIOJPLKN FJFPFFOJLFL(string PABCGCPKGGJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x70624C0", Offset = "0x7060CC0", VA = "0x1870624C0")]
		public static EKCOIOJPLKN CNLLFBLEDDJ(int DCILOEIKONN, string GLGOHIJMLFB, string MLBCMOLHELH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7062580", Offset = "0x7060D80", VA = "0x187062580")]
		public static EKCOIOJPLKN FEFMLAOCMHD(int DCILOEIKONN, string GLGOHIJMLFB, string MLBCMOLHELH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x7062520", Offset = "0x7060D20", VA = "0x187062520")]
		public static EKCOIOJPLKN EDGPJONGADD(int DCILOEIKONN, string GLGOHIJMLFB, string MLBCMOLHELH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7062B60", Offset = "0x7061360", VA = "0x187062B60")]
		public static EKCOIOJPLKN PNAPGIAMKGA(int DCILOEIKONN, string GLGOHIJMLFB, string MLBCMOLHELH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7062930", Offset = "0x7061130", VA = "0x187062930")]
		public static EKCOIOJPLKN KKKCLDNHGMF(string GLGOHIJMLFB, string MLBCMOLHELH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x70626C0", Offset = "0x7060EC0", VA = "0x1870626C0")]
		private static EKCOIOJPLKN HPGNCMBOKNE(string AGNFFHDHLHM, int DCILOEIKONN, string MPIJOLLBLJB, string BHOEOIDOCKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7062800", Offset = "0x7061000", VA = "0x187062800")]
		private static EKCOIOJPLKN HPGNCMBOKNE(string AGNFFHDHLHM, string MPIJOLLBLJB, string BHOEOIDOCKO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly LLPKKNNAIAE BAOGIJBMDME;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static CHLALMGBIDN DHEJOBGKIOA;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static KHLPMELLNOA GDDCJHBALOI;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static Queue<EKCOIOJPLKN> GFNJPBBNBHA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private static long MPAMLFPPLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x705FAE0", Offset = "0x705E2E0", VA = "0x18705FAE0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x705FBD0", Offset = "0x705E3D0", VA = "0x18705FBD0")]
	[KBINEFBNEHG.IPHNODGJKFI]
	internal static void NIENHLDEKFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x705F820", Offset = "0x705E020", VA = "0x18705F820")]
	private static void CMEEMILHOPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x705F8E0", Offset = "0x705E0E0", VA = "0x18705F8E0")]
	public static EKCOIOJPLKN EIBFNGCLILG(string LPNCCAFPPMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x705F960", Offset = "0x705E160", VA = "0x18705F960")]
	public static EKCOIOJPLKN EIBFNGCLILG(string LPNCCAFPPMJ, int DCILOEIKONN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x705FA70", Offset = "0x705E270", VA = "0x18705FA70")]
	public static bool FPPJMJLPBFM(this AGPOKEKNOGC MHJCEGOAONI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x705FCC0", Offset = "0x705E4C0", VA = "0x18705FCC0")]
	[KBINEFBNEHG.IPHNODGJKFI]
	internal static void OJJLOAHPFIK()
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
