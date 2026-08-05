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
		[Cpp2IlInjected.Address(RVA = "0xA2B980", Offset = "0xA2AB80", VA = "0x180A2B980")]
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
		[Cpp2IlInjected.Address(RVA = "0x714FE20", Offset = "0x714F020", VA = "0x18714FE20")]
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
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
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
namespace _LogRegistration.RecNet_DataCollection
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[RecRoom.Logging.Attributes.Preserve]
	[CompilerGenerated]
	public class LogRegistrationIndex : LALFEIIPPKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x714E5E0", Offset = "0x714D7E0", VA = "0x18714E5E0", Slot = "4")]
		public override void ELDCOJNOKAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA2B980", Offset = "0xA2AB80", VA = "0x180A2B980")]
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
		[Cpp2IlInjected.Address(RVA = "0x7151DC0", Offset = "0x7150FC0", VA = "0x187151DC0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x274B560", Offset = "0x274A760", VA = "0x18274B560")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface HODNALGAPHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyDictionary<string, object> MJOAKBKCNAK();
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class LKPDFNMPHEF
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x714E120", Offset = "0x714D320", VA = "0x18714E120")]
	public static void EKBJLCBDLHB(this AGFKJILNONN.ODAGPDLKELB CJJLIINELJG, string AMPNIGJJCBA, string JJOOBDKGFAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x714E090", Offset = "0x714D290", VA = "0x18714E090")]
	public static void EKBJLCBDLHB(this AGFKJILNONN.ODAGPDLKELB CJJLIINELJG, string AMPNIGJJCBA, bool JJOOBDKGFAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x714E190", Offset = "0x714D390", VA = "0x18714E190")]
	public static void EKBJLCBDLHB(this AGFKJILNONN.ODAGPDLKELB CJJLIINELJG, string AMPNIGJJCBA, float KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x714E290", Offset = "0x714D490", VA = "0x18714E290")]
	public static void EKBJLCBDLHB(this AGFKJILNONN.ODAGPDLKELB CJJLIINELJG, string AMPNIGJJCBA, CIMAGHFAFFK JJOOBDKGFAC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class AGFKJILNONN
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface PKNIKMBMPKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		ODAGPDLKELB EMLBNAHGPNM(Guid PEPHKMFLCAN, string JLIPOEPHNNA, [Optional] string GFGBDBGOLDM, [Optional] long? JPDHOFJOMJJ, [Optional] string PBOMDHONPGE, [Optional] string LKFGMGDIPPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class IBJPLFNNLDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x714D040", Offset = "0x714C240", VA = "0x18714D040")]
		public static ODAGPDLKELB PCAKDNMLEJI(Guid PEPHKMFLCAN, string JLIPOEPHNNA, string GFGBDBGOLDM, [Optional] long? JPDHOFJOMJJ, [Optional] string PBOMDHONPGE, [Optional] string LKFGMGDIPPJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class ODAGPDLKELB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		protected OIJDJDOHCPO ODLIDIMANGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly IDictionary<string, IDictionary<string, object>> MFPDEIGBCFB;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool DHGDHKKLBLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x7150CE0", Offset = "0x714FEE0", VA = "0x187150CE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public string JOKCOIOMPLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x111D2D0", Offset = "0x111C4D0", VA = "0x18111D2D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7150D20", Offset = "0x714FF20", VA = "0x187150D20")]
		public ODAGPDLKELB(OIJDJDOHCPO ODLIDIMANGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7150630", Offset = "0x714F830", VA = "0x187150630")]
		public ODAGPDLKELB BFKDEEEMOJN(string MEGAJPAELNI, string KJIOHKMJAPE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x71509E0", Offset = "0x714FBE0", VA = "0x1871509E0")]
		public ODAGPDLKELB KMGDMIEMLFL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x4116680", Offset = "0x4115880", VA = "0x184116680")]
		public ODAGPDLKELB BFKDEEEMOJN<T>(string MEGAJPAELNI, T KJIOHKMJAPE) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7150C00", Offset = "0x714FE00", VA = "0x187150C00")]
		public ODAGPDLKELB NAKGBAIENFI(string MEGAJPAELNI, object KJIOHKMJAPE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4116A20", Offset = "0x4115C20", VA = "0x184116A20")]
		public ODAGPDLKELB MFBCPFFJKIM<T>(string MEGAJPAELNI, T? KJIOHKMJAPE) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7150B70", Offset = "0x714FD70", VA = "0x187150B70")]
		public ODAGPDLKELB MFBCPFFJKIM(string MEGAJPAELNI, string KJIOHKMJAPE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x71507B0", Offset = "0x714F9B0", VA = "0x1871507B0")]
		public ODAGPDLKELB GMMCJEKHJBH(string CHNEMJEDMNF, string MHDODBCCAJB, object CAIGHLKIDBF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7150900", Offset = "0x714FB00", VA = "0x187150900")]
		public ODAGPDLKELB GMMCJEKHJBH(string CHNEMJEDMNF, IDictionary<string, object> DOMKGFFHOEC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7150C80", Offset = "0x714FE80", VA = "0x187150C80")]
		private static IDictionary<string, object> NCIOABJFKGE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7150370", Offset = "0x714F570", VA = "0x187150370")]
		public void ABKMPLGLINN(bool HJBBCOPKKHC, string IKOMGGLDPEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x71506B0", Offset = "0x714F8B0", VA = "0x1871506B0")]
		public Task EIEPMDGDAOH([Optional] CancellationToken FHBCOAHILMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x28853E0", Offset = "0x28845E0", VA = "0x1828853E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class OIJDJDOHCPO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private struct OCNBJKDCODK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public OIJDJDOHCPO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x714FEA0", Offset = "0x714F0A0", VA = "0x18714FEA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x7150310", Offset = "0x714F510", VA = "0x187150310", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static Action<OIJDJDOHCPO> EKENBJNLGAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly string PIAMLJCKNEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly Dictionary<string, object> FDLHPJMLEFG;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string JOKCOIOMPLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xA011A0", Offset = "0xA003A0", VA = "0x180A011A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7150FE0", Offset = "0x71501E0", VA = "0x187150FE0")]
		private OIJDJDOHCPO(string PIAMLJCKNEI, int LJKLNEIKJAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7148250", Offset = "0x7147450", VA = "0x187148250")]
		public static ODAGPDLKELB DBJJOAFKEPP(string PIAMLJCKNEI, int LJKLNEIKJAJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7150DC0", Offset = "0x714FFC0", VA = "0x187150DC0")]
		[AsyncStateMachine(typeof(OCNBJKDCODK))]
		public Task EIEPMDGDAOH([Optional] CancellationToken FHBCOAHILMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7150F70", Offset = "0x7150170", VA = "0x187150F70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3788D30", Offset = "0x3787F30", VA = "0x183788D30")]
		internal void OCMJHEGJAFB<T>(string MEGAJPAELNI, T KJIOHKMJAPE) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7150EB0", Offset = "0x71500B0", VA = "0x187150EB0")]
		internal void GJOHMPJDNBN(string MEGAJPAELNI, object KJIOHKMJAPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7150F10", Offset = "0x7150110", VA = "0x187150F10")]
		internal void OCMJHEGJAFB(string MEGAJPAELNI, string KJIOHKMJAPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x4117A50", Offset = "0x4116C50", VA = "0x184117A50")]
		private void BOOAPFGMDED<T>(string MEGAJPAELNI, T KJIOHKMJAPE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct BKKHOMOFFPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly string DEMGOIJOCKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly long? NICOLNMBAJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly short? IKHMLLJMNGH;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7149160", Offset = "0x7148360", VA = "0x187149160")]
		public BKKHOMOFFPG(string BAKGKGJHMFB, [Optional] long? LADMAADOIBG, [Optional] short? OBLGAMDCODI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct KMFCMKBKLDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly int IFEEBNHBKOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public readonly string FALBMNEMMKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly short FMIFDJPDGAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public readonly string JDJGDACNADB;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x714D7A0", Offset = "0x714C9A0", VA = "0x18714D7A0")]
		public KMFCMKBKLDC(int HAJAMBMBHIE, string GBACPFKFILE, short MPJHPOHPFLB, string JMFGPFHIJNH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class CEKIODPBMAL : EOMEHEDEDEM<HJKOAGNHABJ, KMFCMKBKLDC, BKKHOMOFFPG>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private string GBACPFKFILE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private short MPJHPOHPFLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private string JMFGPFHIJNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private Dictionary<short, int> DEPKNFANFMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private int GGGAEJAIHJD;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x714A610", Offset = "0x7149810", VA = "0x18714A610")]
		public CEKIODPBMAL(string JGNMPDKDBKP, Guid EHBIKNOGDCD, long OHHBJDMHEFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7149280", Offset = "0x7148480", VA = "0x187149280", Slot = "4")]
		public override void LJFAACNMDID(KMFCMKBKLDC GLIJJCFCEPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x71491A0", Offset = "0x71483A0", VA = "0x1871491A0")]
		public void BPBLPNKDEFL(short MPJHPOHPFLB, bool MJEGNOCACGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x4B19F30", Offset = "0x4B19130", VA = "0x184B19F30")]
		public void POFLOMLGJNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA00380", Offset = "0x9FF580", VA = "0x180A00380")]
		public void NDOPPDBJJGA(string DFMGALHPPCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7149570", Offset = "0x7148770", VA = "0x187149570", Slot = "5")]
		public override void PCJAOMHNKKI(bool CJLKIDPDKFH, BKKHOMOFFPG OABCCHEMMDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x714A360", Offset = "0x7149560", VA = "0x18714A360", Slot = "6")]
		public override OLJOLFFDHKE PPEKOGFKDAM(HJKOAGNHABJ GBDOIHMHKCJ, int CMDFFDAPDIB, string LCIIKPIOJGB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class LHIAOAAHPLG : OLJOLFFDHKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private string GBACPFKFILE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly short MPJHPOHPFLB;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x714DFA0", Offset = "0x714D1A0", VA = "0x18714DFA0")]
		public LHIAOAAHPLG(long LNHCNANPEGB, int HAJAMBMBHIE, string GFGBDBGOLDM, long OHHBJDMHEFG, int AJLOEEOFHEG, string PBOMDHONPGE, short MPJHPOHPFLB, string GBACPFKFILE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x714DF20", Offset = "0x714D120", VA = "0x18714DF20")]
		public void NAGHEGAJPIH(int HAJAMBMBHIE, string GBACPFKFILE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x714DDF0", Offset = "0x714CFF0", VA = "0x18714DDF0", Slot = "5")]
		public override ODAGPDLKELB EMLBNAHGPNM(Guid PEPHKMFLCAN, string JLIPOEPHNNA, [Optional] string GFGBDBGOLDM, [Optional] long? JPDHOFJOMJJ, [Optional] string PBOMDHONPGE, [Optional] string LKFGMGDIPPJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class NLNBNEAJBDI
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class NJONJEOHBGD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public float nextEventSendTime;

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
			public NJONJEOHBGD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x714EB40", Offset = "0x714DD40", VA = "0x18714EB40")]
			internal bool JAKHADBLKLH()
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private struct APDHMKFICCP : IAsyncStateMachine
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
			private NJONJEOHBGD <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private TimeSpan <delayPollingInterval>5__2;

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x7148440", Offset = "0x7147640", VA = "0x187148440", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x7149100", Offset = "0x7148300", VA = "0x187149100", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private struct GKAJDDNLFEE : IAsyncStateMachine
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

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x714AD90", Offset = "0x7149F90", VA = "0x18714AD90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x714B310", Offset = "0x714A510", VA = "0x18714B310", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public static readonly float AOPIBKCPFPC;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static IIOGDLIHHEO GKOIAJLIOIJ;

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static CancellationTokenSource MPAEAMJDHJP;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static bool EBIDMDLFJLO;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private static int DPOOKEHFPKB;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static readonly LDFPLGIGGEB<ODAGPDLKELB, bool> NOOOPLCLHMP;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static PHPJIGGIEBC<ODAGPDLKELB, bool> PEDPDCIBDMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x714F500", Offset = "0x714E700", VA = "0x18714F500")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private static bool DANEBGCNPDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x714FC30", Offset = "0x714EE30", VA = "0x18714FC30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x714F3D0", Offset = "0x714E5D0", VA = "0x18714F3D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private static bool IAJLAMBBOOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x714FC80", Offset = "0x714EE80", VA = "0x18714FC80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x714FCD0", Offset = "0x714EED0", VA = "0x18714FCD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private static float FEPBDDPEFOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x714EDC0", Offset = "0x714DFC0", VA = "0x18714EDC0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x714F9D0", Offset = "0x714EBD0", VA = "0x18714F9D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x714FA30", Offset = "0x714EC30", VA = "0x18714FA30")]
		[AMFDJJKGJPA.LNNANOGDNGN]
		internal static void MBDJMLJLJOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x714EBE0", Offset = "0x714DDE0", VA = "0x18714EBE0")]
		internal static void AFLILFPIJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x714F220", Offset = "0x714E420", VA = "0x18714F220")]
		internal static void FKEDJLMBNMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x714EEE0", Offset = "0x714E0E0", VA = "0x18714EEE0")]
		internal static void ECOKHJGLEAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x714F980", Offset = "0x714EB80", VA = "0x18714F980")]
		public static void KHJGCDFLFCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x714F550", Offset = "0x714E750", VA = "0x18714F550")]
		private static void IMJPDICAFBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x714EF40", Offset = "0x714E140", VA = "0x18714EF40")]
		private static void ENOGLCAEEMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x714EE10", Offset = "0x714E010", VA = "0x18714EE10")]
		[AsyncStateMachine(typeof(APDHMKFICCP))]
		private static Task DIGILOHKMHD(CancellationToken FHBCOAHILMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x714F430", Offset = "0x714E630", VA = "0x18714F430")]
		private static void HONBKECIOLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x714FB50", Offset = "0x714ED50", VA = "0x18714FB50")]
		[AsyncStateMachine(typeof(GKAJDDNLFEE))]
		private static Task MNKABCJBIAC(bool AIENDODBDGI, [Optional] CancellationToken FHBCOAHILMJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class IOBEDFBGJPH<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class ONCLLNOCHCL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public IOBEDFBGJPH<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
			public ONCLLNOCHCL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x5633690", Offset = "0x5632890", VA = "0x185633690")]
			internal object NFCJGPLHFAM()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class AGAHICJJMCF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public IOBEDFBGJPH<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
			public AGAHICJJMCF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x4E4CE50", Offset = "0x4E4C050", VA = "0x184E4CE50")]
			internal object BLBLEAPDGNH()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class DDONFMKLGLC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public IOBEDFBGJPH<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
			public DDONFMKLGLC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x42062F0", Offset = "0x42054F0", VA = "0x1842062F0")]
			internal object KJOHHCDHMPL()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class FBKDOCBINDO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public IOBEDFBGJPH<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
			public FBKDOCBINDO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x4B222F0", Offset = "0x4B214F0", VA = "0x184B222F0")]
			internal object MGHNOLLFGIL()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class GBKALAKHAKE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public IOBEDFBGJPH<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
			public GBKALAKHAKE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x4BD5500", Offset = "0x4BD4700", VA = "0x184BD5500")]
			internal object BGHNFEGNEAM()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class CPPCEILIHBG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public IOBEDFBGJPH<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
			public CPPCEILIHBG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x687D470", Offset = "0x687C670", VA = "0x18687D470")]
			internal object AGJMBJIJONJ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class DOEBOBHLKFB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public IOBEDFBGJPH<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
			public DOEBOBHLKFB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x4235D60", Offset = "0x4234F60", VA = "0x184235D60")]
			internal object NIBKCLFHFOE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private const float KKJFEEGDJID = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly Guid PEPHKMFLCAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly Guid OJKIHBNEMFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly string PBOMDHONPGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly string BEKELPEFOFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private string POIJJCHKDHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private string LKFGMGDIPPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private string JDLONHFAEOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private string HMEDFGPKHDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private string BJGMJINOKOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private string MNLIJNBFKJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private string CPBPBPPDFBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private string FEKAGJBPEDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private string LMAIAEPBIGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private Guid? AFKLMDEJFKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private (int, int)? IIPBBDLLGEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly HashSet<T> MHIKGGKLGCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly Dictionary<(T, int), string> FJOPGKADOBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly Dictionary<(T, int), float> PCONCMELJKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly Dictionary<T, string> IIEOOCOBBCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly Dictionary<T, string> KBDGNALGHMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly Dictionary<T, string> OOIBIALLOFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly Dictionary<T, string[]> BFKAEOGMIKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private string NOHODPGDGBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private bool KHPADCMIJJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private Task PBBFBNDMPIA;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4E09B80", Offset = "0x4E08D80", VA = "0x184E09B80")]
		public IOBEDFBGJPH(Guid PEPHKMFLCAN, Guid OJKIHBNEMFG, string BEKELPEFOFA, string PBOMDHONPGE, string POIJJCHKDHP, [Optional] string LKFGMGDIPPJ, [Optional] string JDLONHFAEOC, [Optional] string HMEDFGPKHDM, [Optional] string CPBPBPPDFBI, [Optional] string NOHODPGDGBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA0D3D0", Offset = "0xA0C5D0", VA = "0x180A0D3D0")]
		public void LCAFIOKOCHD(string LKFGMGDIPPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xA00BC0", Offset = "0x9FFDC0", VA = "0x180A00BC0")]
		public void KHHLABLEMIF(string POIJJCHKDHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xA85DA0", Offset = "0xA84FA0", VA = "0x180A85DA0")]
		public void LGOKCKDMBPO(string NOHODPGDGBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA003A0", Offset = "0x9FF5A0", VA = "0x180A003A0")]
		public void KDDJPBCABBJ(string BJGMJINOKOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA0E4E0", Offset = "0xA0D6E0", VA = "0x180A0E4E0")]
		public void FKNANDLGFLO(string FEKAGJBPEDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA0E3C0", Offset = "0xA0D5C0", VA = "0x180A0E3C0")]
		public void OEPOBCGOBEP(string LMAIAEPBIGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x4E08EB0", Offset = "0x4E080B0", VA = "0x184E08EB0")]
		public void OEFHONGPDKA(Guid? PEPHKMFLCAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x17AD4E0", Offset = "0x17AC6E0", VA = "0x1817AD4E0")]
		public void IDLIKMGOOFO((int, int)? IIPBBDLLGEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA00380", Offset = "0x9FF580", VA = "0x180A00380")]
		public void PPKOBLNDBKO(string MNLIJNBFKJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x4E09A20", Offset = "0x4E08C20", VA = "0x184E09A20")]
		public void PBDJHDDKEGP(T JPDHOFJOMJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x4E02C90", Offset = "0x4E01E90", VA = "0x184E02C90")]
		public void BPLPPJJHIFH(T JPDHOFJOMJJ, int KCFFIAKGPDM, float PFMGKMLLMHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x4E08AC0", Offset = "0x4E07CC0", VA = "0x184E08AC0")]
		public void MIPPAGOMJPI(T JPDHOFJOMJJ, int KCFFIAKGPDM, string DACHNILPMOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x4E09040", Offset = "0x4E08240", VA = "0x184E09040")]
		public void OJOJJHDDNHN(T JPDHOFJOMJJ, string PHHMOIGGBAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x4E09320", Offset = "0x4E08520", VA = "0x184E09320")]
		public void PAFKEOMEFAC(T JPDHOFJOMJJ, string JEGCDPABFPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x4E05BC0", Offset = "0x4E04DC0", VA = "0x184E05BC0")]
		public void EJMDGDOLNAJ(T JPDHOFJOMJJ, bool HONKGHJFHKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x4E07390", Offset = "0x4E06590", VA = "0x184E07390")]
		public void JFBDJHHKCMB(T JPDHOFJOMJJ, string[] IPIOONIKEJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x4E04D00", Offset = "0x4E03F00", VA = "0x184E04D00")]
		public Task EIEPMDGDAOH(bool IKLDNLEDLAC = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x4E06C40", Offset = "0x4E05E40", VA = "0x184E06C40")]
		private (IEnumerable<T>, string) FMIDLLGJLHP()
		{
			return default((IEnumerable<T>, string));
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x4E081D0", Offset = "0x4E073D0", VA = "0x184E081D0")]
		public static ODAGPDLKELB LHBPHLMBCDB(Guid PEPHKMFLCAN, Guid OJKIHBNEMFG, string BEKELPEFOFA, T JPDHOFJOMJJ, string PBOMDHONPGE, string ICGNMHKDKFI, string LKFGMGDIPPJ, int? CMDFFDAPDIB, [Optional] string NMPIKHBBLLA, [Optional] string PHHMOIGGBAE, [Optional] int? HPDFANCEAMJ, [Optional] Guid? AFKLMDEJFKH, [Optional] string NOHODPGDGBK, [Optional] string GFGBDBGOLDM, [Optional] (int, int)? IIPBBDLLGEE, [Optional] string KHOAKEAOPKF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x4E026A0", Offset = "0x4E018A0", VA = "0x184E026A0")]
		[CompilerGenerated]
		private string AKIHNEMNMCF(T APBCLGNDGBE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x4E08E30", Offset = "0x4E08030", VA = "0x184E08E30")]
		[CompilerGenerated]
		private string NOBKAHAJBBC(T APBCLGNDGBE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x4E07670", Offset = "0x4E06870", VA = "0x184E07670")]
		[CompilerGenerated]
		private string KJBPKBMJEGK(T APBCLGNDGBE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x4E024A0", Offset = "0x4E016A0", VA = "0x184E024A0")]
		[CompilerGenerated]
		private string AFFAGNADPAI(T APBCLGNDGBE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public abstract class EOMEHEDEDEM<TItem, TListSessionStartParams, TListSessionLogParams>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		protected readonly string JGNMPDKDBKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		protected readonly Guid EHBIKNOGDCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		protected readonly long OHHBJDMHEFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		protected int HAJAMBMBHIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		protected int CECPNLAHPEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		protected DateTime OICKBACCCEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		protected bool PFPKHNENDBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		protected Dictionary<long, OLJOLFFDHKE> DFBMJBHFOHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		protected bool FDIBJOLFNND;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool GDGBNFIFMKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xC777C0", Offset = "0xC769C0", VA = "0x180C777C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool LBFFINLKELC
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xCCB610", Offset = "0xCCA810", VA = "0x180CCB610")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x46EBF10", Offset = "0x46EB110", VA = "0x1846EBF10")]
		public EOMEHEDEDEM(string JGNMPDKDBKP, Guid EHBIKNOGDCD, long OHHBJDMHEFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void LJFAACNMDID(TListSessionStartParams GLIJJCFCEPN);

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x46EBF00", Offset = "0x46EB100", VA = "0x1846EBF00")]
		public void FMCNHFIPFON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void PCJAOMHNKKI(bool CJLKIDPDKFH, TListSessionLogParams OABCCHEMMDL);

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x46EBCC0", Offset = "0x46EAEC0", VA = "0x1846EBCC0")]
		public void FICKGCKPHCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x46EBD60", Offset = "0x46EAF60", VA = "0x1846EBD60")]
		public void FJOEGMAFLDK(long LNHCNANPEGB, int CMDFFDAPDIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x46EBBA0", Offset = "0x46EADA0", VA = "0x1846EBBA0")]
		public void DIIPCFCMICO(long LNHCNANPEGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract OLJOLFFDHKE PPEKOGFKDAM(TItem LHNFJLFIPMG, int CMDFFDAPDIB, string LCIIKPIOJGB);
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class OLJOLFFDHKE : PKNIKMBMPKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private int HAJAMBMBHIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private long LNHCNANPEGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private long OHHBJDMHEFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly string FFIACBLJHEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly string KKEMFONADFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly int AJLOEEOFHEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private DateTime CFPLIJNFHLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private double NMCMFBIAIEM;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool BKJPEHIDHPD
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xE9F650", Offset = "0xE9E850", VA = "0x180E9F650")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xE9F660", Offset = "0xE9E860", VA = "0x180E9F660")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7151A00", Offset = "0x7150C00", VA = "0x187151A00")]
		public OLJOLFFDHKE(long LNHCNANPEGB, int HAJAMBMBHIE, string GFGBDBGOLDM, long OHHBJDMHEFG, int AJLOEEOFHEG, [Optional] string PBOMDHONPGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7151880", Offset = "0x7150A80", VA = "0x187151880")]
		public void NAKCHCNPDFP(int HAJAMBMBHIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7151830", Offset = "0x7150A30", VA = "0x187151830")]
		public void MJJJIOFGCAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x71518F0", Offset = "0x7150AF0", VA = "0x1871518F0")]
		public void PMLMEKFCBLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x71517D0", Offset = "0x71509D0", VA = "0x1871517D0")]
		private void MABEOGBNFPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7151320", Offset = "0x7150520", VA = "0x187151320", Slot = "5")]
		public virtual ODAGPDLKELB EMLBNAHGPNM(Guid PEPHKMFLCAN, string JLIPOEPHNNA, [Optional] string GFGBDBGOLDM, [Optional] long? JPDHOFJOMJJ, [Optional] string PBOMDHONPGE, [Optional] string LKFGMGDIPPJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class HAIJADDNEIH
	{
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private static Dictionary<string, Dictionary<string, object>> GAMMHGKHHLO;

		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private static string IKOADHENJDO;

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private static int HLCMFDMILKG;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly Dictionary<string, HODNALGAPHJ> NOACAAEAIBC;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static string EILPMCFHJIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x714B510", Offset = "0x714A710", VA = "0x18714B510")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x714C070", Offset = "0x714B270", VA = "0x18714C070")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static bool PGJACIFLFPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x714CC90", Offset = "0x714BE90", VA = "0x18714CC90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static Dictionary<string, Dictionary<string, object>> DBFHBDCNKPM
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x714C1D0", Offset = "0x714B3D0", VA = "0x18714C1D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static Guid? CBLDHKABOKH
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x714C010", Offset = "0x714B210", VA = "0x18714C010")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x714C120", Offset = "0x714B320", VA = "0x18714C120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static Guid? ELAHILKOKFK
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x714B370", Offset = "0x714A570", VA = "0x18714B370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x714B4B0", Offset = "0x714A6B0", VA = "0x18714B4B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x714CA00", Offset = "0x714BC00", VA = "0x18714CA00")]
		public static void PAHOFOJKOMN(string OGLEBEEFJFG, HODNALGAPHJ MADGFINMMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x714B3D0", Offset = "0x714A5D0", VA = "0x18714B3D0")]
		internal static void AFLILFPIJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x714BCD0", Offset = "0x714AED0", VA = "0x18714BCD0")]
		internal static void FKEDJLMBNMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x714B750", Offset = "0x714A950", VA = "0x18714B750")]
		internal static void ECOKHJGLEAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x714C2C0", Offset = "0x714B4C0", VA = "0x18714C2C0")]
		public static Guid LJFAACNMDID(string OGLEBEEFJFG, [Optional] string? KDPIFPAADEH, [Optional] Dictionary<string, object>? FNCAEOBGBKH)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x714C220", Offset = "0x714B420", VA = "0x18714C220")]
		public static Guid LJFAACNMDID(string OGLEBEEFJFG, long KDPIFPAADEH, [Optional] Dictionary<string, object>? FNCAEOBGBKH)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x714BDB0", Offset = "0x714AFB0", VA = "0x18714BDB0")]
		public static void FMCNHFIPFON(string OGLEBEEFJFG, [Optional] Guid? DJOIAEMCFDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x714CA90", Offset = "0x714BC90", VA = "0x18714CA90")]
		public static void PCPBJHPBGHI(string OGLEBEEFJFG, string CHNEMJEDMNF, object KAEGCEFPOGF, bool EBIDMDLFJLO = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x714B560", Offset = "0x714A760", VA = "0x18714B560")]
		public static bool ECBCHHJDHKI(string OGLEBEEFJFG, [Optional] string? KDPIFPAADEH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x714C890", Offset = "0x714BA90", VA = "0x18714C890")]
		private static void NNAPFMJKEPG(bool HFGBHGJMMLJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x714C180", Offset = "0x714B380", VA = "0x18714C180")]
		public static void LACGHKPIBPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x714BBC0", Offset = "0x714ADC0", VA = "0x18714BBC0")]
		private static void ENOGLCAEEMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x714B7D0", Offset = "0x714A9D0", VA = "0x18714B7D0")]
		private static void EHEMIGLPCHA(string OGLEBEEFJFG, Guid PEPHKMFLCAN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public static class MOCGAIMGIJK
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public struct GNOLFOPINHI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public bool LPBBIEGNCEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public string GNLDHDANFJL;

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xC790D0", Offset = "0xC782D0", VA = "0x180C790D0")]
			public GNOLFOPINHI(bool LPBBIEGNCEB, string GNLDHDANFJL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x714E670", Offset = "0x714D870", VA = "0x18714E670")]
		public static GNOLFOPINHI AODHEIHGBPN(ODAGPDLKELB CJJLIINELJG)
		{
			return default(GNOLFOPINHI);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x714EA40", Offset = "0x714DC40", VA = "0x18714EA40")]
		private static void ELOLLHHKAFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x714E980", Offset = "0x714DB80", VA = "0x18714E980")]
		private static void EHBEPPEPOEI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class LFOKPECKIMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x714DD90", Offset = "0x714CF90", VA = "0x18714DD90")]
		public static ODAGPDLKELB MLLGFHCJLLE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class LBPIBBOELCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x714D9D0", Offset = "0x714CBD0", VA = "0x18714D9D0")]
		public static ODAGPDLKELB IKFHHKAOKHI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x714DBB0", Offset = "0x714CDB0", VA = "0x18714DBB0")]
		public static ODAGPDLKELB LCNHPKDLDME()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x714D970", Offset = "0x714CB70", VA = "0x18714D970")]
		public static ODAGPDLKELB HGLBLCGADIB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x714DA90", Offset = "0x714CC90", VA = "0x18714DA90")]
		public static ODAGPDLKELB JFGAEJFFGOI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x714DA30", Offset = "0x714CC30", VA = "0x18714DA30")]
		public static ODAGPDLKELB JBKOMICNAJE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x714D7F0", Offset = "0x714C9F0", VA = "0x18714D7F0")]
		public static ODAGPDLKELB AFHHEMKMKJE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x714D850", Offset = "0x714CA50", VA = "0x18714D850")]
		public static ODAGPDLKELB BPKEKOJJHAB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x714D8B0", Offset = "0x714CAB0", VA = "0x18714D8B0")]
		public static ODAGPDLKELB EANFLJPLOCM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x714D910", Offset = "0x714CB10", VA = "0x18714D910")]
		public static ODAGPDLKELB EFMINOJCHMA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x714DD30", Offset = "0x714CF30", VA = "0x18714DD30")]
		public static ODAGPDLKELB PPBPDPJPKKH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x714DC70", Offset = "0x714CE70", VA = "0x18714DC70")]
		public static ODAGPDLKELB MPEEPFNMPIM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x714DAF0", Offset = "0x714CCF0", VA = "0x18714DAF0")]
		public static ODAGPDLKELB JGPGBOPGFPN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x714DCD0", Offset = "0x714CED0", VA = "0x18714DCD0")]
		public static ODAGPDLKELB OIKBIOCOBPA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x714DB50", Offset = "0x714CD50", VA = "0x18714DB50")]
		public static ODAGPDLKELB KGNLKLDLLNP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x714DC10", Offset = "0x714CE10", VA = "0x18714DC10")]
		public static ODAGPDLKELB MHICEPDDOFG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class HLMFJHNJCMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x714CE60", Offset = "0x714C060", VA = "0x18714CE60")]
		public static ODAGPDLKELB ADCOLLEGHDI(long LADMAADOIBG, long OPILFBADOKA, bool JOKAJBEOPPI, string EHDILAPKGOD, string PFJODPDLNEG)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class KFJOGDIHJND
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x714D380", Offset = "0x714C580", VA = "0x18714D380")]
		public static ODAGPDLKELB EGHBCMHCFPK(string PFLGFCGFPJB, string DOGALEMBNAN, bool IDJCGHJPOEE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x714D4F0", Offset = "0x714C6F0", VA = "0x18714D4F0")]
		public static ODAGPDLKELB NOCGHOKEKBD(Guid OJKIHBNEMFG, string BKDMJHGCDEA, string NFAKBNCEHDF, string PBEOEGOIFNP, [Optional] int? JCPCFEFOCPP, [Optional] double[] HJNKBJIAEJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x714D250", Offset = "0x714C450", VA = "0x18714D250")]
		public static ODAGPDLKELB DLOFNNFFCIA(Guid OJKIHBNEMFG, Guid BKLMFPAFBLA, bool ADAEABEGCPE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class CIADNKHMFNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x714A890", Offset = "0x7149A90", VA = "0x18714A890")]
		public static ODAGPDLKELB KCAIBDMCIKB(string CBEGBACGGCB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x714A750", Offset = "0x7149950", VA = "0x18714A750")]
		public static ODAGPDLKELB DOOEGKDPING(string POLOEIGGIEP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x714A690", Offset = "0x7149890", VA = "0x18714A690")]
		public static ODAGPDLKELB BOOBONLIIEI(int LJKLNEIKJAJ, string GBOCGPJOEEK, string APBCLGNDGBE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x714A830", Offset = "0x7149A30", VA = "0x18714A830")]
		public static ODAGPDLKELB HGNBGDAGLOC(int LJKLNEIKJAJ, string GBOCGPJOEEK, string APBCLGNDGBE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x714A6F0", Offset = "0x71498F0", VA = "0x18714A6F0")]
		public static ODAGPDLKELB CMPHLIIGECG(int LJKLNEIKJAJ, string GBOCGPJOEEK, string APBCLGNDGBE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x714AAC0", Offset = "0x7149CC0", VA = "0x18714AAC0")]
		public static ODAGPDLKELB LKEKJFDMFFH(int LJKLNEIKJAJ, string GBOCGPJOEEK, string APBCLGNDGBE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x714A970", Offset = "0x7149B70", VA = "0x18714A970")]
		public static ODAGPDLKELB KFHADJEOIME(string GBOCGPJOEEK, string APBCLGNDGBE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x714AC50", Offset = "0x7149E50", VA = "0x18714AC50")]
		private static ODAGPDLKELB PFOODAKBBEO(string JGNMPDKDBKP, int LJKLNEIKJAJ, string OGEDFONDAKK, string EIHPGCACMKK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x714AB20", Offset = "0x7149D20", VA = "0x18714AB20")]
		private static ODAGPDLKELB PFOODAKBBEO(string JGNMPDKDBKP, string OGEDFONDAKK, string EIHPGCACMKK)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly KEPOMIIOHBM AODHEIHGBPN;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static MIEBDDKAAJD CDBBPIFCDMB;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static EBICJFLGMAG ELJIIOLDAJE;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static Queue<ODAGPDLKELB> KKKJLHHBCME;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private static long GECIJDAKHHM
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7147E10", Offset = "0x7147010", VA = "0x187147E10")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x71480E0", Offset = "0x71472E0", VA = "0x1871480E0")]
	[AMFDJJKGJPA.LNNANOGDNGN]
	internal static void LFEAAEEPEBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7148020", Offset = "0x7147220", VA = "0x187148020")]
	private static void JFNBNGDCHOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x71481D0", Offset = "0x71473D0", VA = "0x1871481D0")]
	public static ODAGPDLKELB OIGHELGHCBE(string PIAMLJCKNEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7148250", Offset = "0x7147450", VA = "0x187148250")]
	public static ODAGPDLKELB OIGHELGHCBE(string PIAMLJCKNEI, int LJKLNEIKJAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7148360", Offset = "0x7147560", VA = "0x187148360")]
	public static bool OOILCDKDOFK(this IIOGDLIHHEO KIIPLBILILO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7147F00", Offset = "0x7147100", VA = "0x187147F00")]
	[AMFDJJKGJPA.LNNANOGDNGN]
	internal static void GKFDDNPDAHC()
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
