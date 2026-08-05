using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using ExitGames.Client.Photon;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RecRoom;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Foundation;
using RecRoom.Logging.Attributes;
using RecRoom.ObjectModel;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_ObjectModel_Dependencies_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : LALFEIIPPKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7E0CF40", Offset = "0x7E0C140", VA = "0x187E0CF40", Slot = "4")]
		public override void ELDCOJNOKAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA2B980", Offset = "0xA2AB80", VA = "0x180A2B980")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_ObjectModel_Dependencies_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] localIndices1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ServiceBitset bitset0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private ServiceBitset bitset1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Type[] bindTypeSet3;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xA00F50", Offset = "0xA00150", VA = "0x180A00F50", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x216AEA0", Offset = "0x216A0A0", VA = "0x18216AEA0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7E0E4F0", Offset = "0x7E0D6F0", VA = "0x187E0E4F0")]
		private void AGIDAPFICKK(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7E0E8C0", Offset = "0x7E0DAC0", VA = "0x187E0E8C0")]
		private void EKPABHIKONH(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7E0EBF0", Offset = "0x7E0DDF0", VA = "0x187E0EBF0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7E0ECA0", Offset = "0x7E0DEA0", VA = "0x187E0ECA0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[RegisterService(typeof(IAHBNPJKIPC), new string[] { "Photon" })]
public class ICIONHPJPLA : IAHBNPJKIPC
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private class FAMPMODLMBL : NDKAIJEIFHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public HIPDGMOFECH ODLIDIMANGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public StatusCode MIKGPFGLNOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public GPHAPLDHFCC IEELNDIFJGL;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public BBMDKGLDILO BGLOFMKFAEA
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x7E09890", Offset = "0x7E08A90", VA = "0x187E09890", Slot = "4")]
			get
			{
				return default(BBMDKGLDILO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public NPGIOFFINPJ MJAAKMGHDNM
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x7E09C00", Offset = "0x7E08E00", VA = "0x187E09C00", Slot = "5")]
			get
			{
				return default(NPGIOFFINPJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool DALEPDCEKBL
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x7E09010", Offset = "0x7E08210", VA = "0x187E09010", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private bool CGCJIAAJKIK
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x7E096D0", Offset = "0x7E088D0", VA = "0x187E096D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7E09680", Offset = "0x7E08880", VA = "0x187E09680", Slot = "8")]
		public object JFCAPMACHDA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7E09370", Offset = "0x7E08570", VA = "0x187E09370", Slot = "9")]
		private (NPGIOFFINPJ, Dictionary<object, object>) IPCHLIBBAPP()
		{
			return default((NPGIOFFINPJ, Dictionary<object, object>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7E09B10", Offset = "0x7E08D10", VA = "0x187E09B10", Slot = "10")]
		private (DLILJGCOAIF, NPGIOFFINPJ) PFMDLGLPJGF()
		{
			return default((DLILJGCOAIF, NPGIOFFINPJ));
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7E09240", Offset = "0x7E08440", VA = "0x187E09240", Slot = "11")]
		private DJOPNIMGMHK<(DLILJGCOAIF, NPGIOFFINPJ)> FGPMMIGDCIC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7E09020", Offset = "0x7E08220", VA = "0x187E09020", Slot = "12")]
		private (GGJDLMJHNMI, byte[]) CPFLOBLIEOC()
		{
			return default((GGJDLMJHNMI, byte[]));
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7E098E0", Offset = "0x7E08AE0", VA = "0x187E098E0", Slot = "13")]
		private (NJEOJBANFID, byte[]) LLKOMKHBIMC()
		{
			return default((NJEOJBANFID, byte[]));
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x4139340", Offset = "0x4138540", VA = "0x184139340", Slot = "14")]
		public T FNOJKDEGIOC<T>()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7E09C50", Offset = "0x7E08E50", VA = "0x187E09C50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public FAMPMODLMBL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[DefaultMember("Item")]
	private class GPHAPLDHFCC : DJOPNIMGMHK<(DLILJGCOAIF, NPGIOFFINPJ)>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int[] OILBAELIDBG;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int PODALOIGPLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x7E09E40", Offset = "0x7E09040", VA = "0x187E09E40", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public (DLILJGCOAIF view, NPGIOFFINPJ newOwner) HAHLLCOCBCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x7E09DA0", Offset = "0x7E08FA0", VA = "0x187E09DA0", Slot = "4")]
			get
			{
				return default((DLILJGCOAIF, NPGIOFFINPJ));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public GPHAPLDHFCC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7E0A470", Offset = "0x7E09670", VA = "0x187E0A470", Slot = "4")]
	public bool GHMCGLNMJHJ(object CAIGHLKIDBF, NDKAIJEIFHC IKDCGGBMFBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public ICIONHPJPLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal static class KOEMLHOGCBE
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AlsoBindServiceAs(typeof(MECCADDFKLD))]
[RegisterService(typeof(CFHLMCFDONL), new string[] { "Photon" })]
public class MECCADDFKLD : HGIOMKPLONA, GDMDHKNHDMK, CFHLMCFDONL, LNIDKKDBPDJ, OBFJDPCMLDN
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly KEPOMIIOHBM EBHKLAMEJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[DependsOn]
	private DEAGIDCNAJM KOHBDHDNGIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[DependsOn]
	private ANPMBCBECMN KHBMDPMKOAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Hashtable GFKOIMIAEOH;

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7E0D740", Offset = "0x7E0C940", VA = "0x187E0D740", Slot = "4")]
	public void InitReferences(EENCHNOCEIL BNPCDJLAAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7E0D890", Offset = "0x7E0CA90", VA = "0x187E0D890", Slot = "5")]
	public void ShutdownReferences()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7E0D5D0", Offset = "0x7E0C7D0", VA = "0x187E0D5D0", Slot = "6")]
	public void IMEHBFDLFEG(NJEOJBANFID MHDODBCCAJB, ReadOnlySpan<byte> EKFBEBELGHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7E0D4B0", Offset = "0x7E0C6B0", VA = "0x187E0D4B0", Slot = "10")]
	public void GNNBDKCIPPA(NJEOJBANFID BBEPEIOLDOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7E0D2B0", Offset = "0x7E0C4B0", VA = "0x187E0D2B0", Slot = "7")]
	public void BHBPCOIFKBG(ReadOnlySpan<NJEOJBANFID> CDEBEBBKNGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7E0D050", Offset = "0x7E0C250", VA = "0x187E0D050")]
	private Hashtable AFHNJOIOHNK(Hashtable IHJCIMGNHDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7E0D830", Offset = "0x7E0CA30", VA = "0x187E0D830")]
	public void KCKMPJKFIDL(object HEAHMHOMOPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7E0D440", Offset = "0x7E0C640", VA = "0x187E0D440", Slot = "8")]
	private void DDIHEPEDMIL(EENCHNOCEIL BNPCDJLAAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x11D7350", Offset = "0x11D6550", VA = "0x1811D7350", Slot = "9")]
	private void OEBCMEIKBOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7E0D9C0", Offset = "0x7E0CBC0", VA = "0x187E0D9C0")]
	public MECCADDFKLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[RegisterService(typeof(global::OAEDCBDEEPN), new string[] { })]
internal class KGCGMFCKJAI : BNCJEPLIHEM, global::OAEDCBDEEPN
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly KEPOMIIOHBM OJIKLDMECAE;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	protected override KEPOMIIOHBM[] IGOOIBMCBBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA00FB0", Offset = "0xA001B0", VA = "0x180A00FB0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7E0C4F0", Offset = "0x7E0B6F0", VA = "0x187E0C4F0")]
	public KGCGMFCKJAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class DLLKLBBEJOE : DefaultContractResolver
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7E08DC0", Offset = "0x7E07FC0", VA = "0x187E08DC0", Slot = "19")]
	protected override IList<JsonProperty> CreateProperties(Type GDHKDBJPDLG, MemberSerialization FDHECLJFLJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7E08FC0", Offset = "0x7E081C0", VA = "0x187E08FC0")]
	public DLLKLBBEJOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class KJLIPGLECGM
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class KACCHCDNIBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public JsonSerializerSettings serializationSettings;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public KACCHCDNIBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7E0C360", Offset = "0x7E0B560", VA = "0x187E0C360")]
		internal string LINLNNIHINA(HIPDGMOFECH eventData)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7E0C780", Offset = "0x7E0B980", VA = "0x187E0C780")]
	public static string EIFCPCFPHAC(this HIPDGMOFECH ODLIDIMANGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7E0CC00", Offset = "0x7E0BE00", VA = "0x187E0CC00")]
	public static BBMDKGLDILO LOPHFGBHALJ(this HIPDGMOFECH ODLIDIMANGE)
	{
		return default(BBMDKGLDILO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7E0CA00", Offset = "0x7E0BC00", VA = "0x187E0CA00")]
	public static ViewId IFKDGDJKBMC(this HIPDGMOFECH ODLIDIMANGE)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7E0CD50", Offset = "0x7E0BF50", VA = "0x187E0CD50")]
	public static string ONDCOJCPPPP(this HIPDGMOFECH ODLIDIMANGE, JsonSerializerSettings DKDMNIFKIAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7E0C7A0", Offset = "0x7E0B9A0", VA = "0x187E0C7A0")]
	private static string EJCCAMIFBCI(HIPDGMOFECH ODLIDIMANGE, Func<HIPDGMOFECH, string> CJLPDLONOLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7E0C890", Offset = "0x7E0BA90", VA = "0x187E0C890")]
	public static string FKJGNPFFKKO(this HIPDGMOFECH ODLIDIMANGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7E0C5A0", Offset = "0x7E0B7A0", VA = "0x187E0C5A0")]
	public static ViewId BDLPJJMIMPA(this HIPDGMOFECH ODLIDIMANGE)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7E0CE20", Offset = "0x7E0C020", VA = "0x187E0CE20")]
	public static string PBBJKNIFMPA(this HIPDGMOFECH ODLIDIMANGE, JsonSerializerSettings DKDMNIFKIAO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class HEGBAGHHEDO
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal static class FDLDGLGJEON
	{
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static string ADBONFADNHH;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7E09E60", Offset = "0x7E09060", VA = "0x187E09E60")]
	public static string KIEOMPJFIAI(BBMDKGLDILO HADNLMBOMNH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[RegisterService(typeof(PNDLHOFPMMB), new string[] { })]
[ServiceLifetime(Lifetime.PhotonRoom)]
internal class PNDLHOFPMMB : BNCJEPLIHEM
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private static readonly KEPOMIIOHBM BPMHGMPIIMI;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static readonly KEPOMIIOHBM AOHOHOOHFDD;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static readonly KEPOMIIOHBM HDMFIECIKAF;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	protected override KEPOMIIOHBM[] IGOOIBMCBBC
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xA00FB0", Offset = "0xA001B0", VA = "0x180A00FB0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7E0DBD0", Offset = "0x7E0CDD0", VA = "0x187E0DBD0", Slot = "9")]
	public override void IEHFFCCKIOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7E0DA50", Offset = "0x7E0CC50", VA = "0x187E0DA50", Slot = "10")]
	public override void GCBJAJLNEAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7E0DA40", Offset = "0x7E0CC40", VA = "0x187E0DA40")]
	private void DOJIKDFEIAH(HIPDGMOFECH ODLIDIMANGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7E0E040", Offset = "0x7E0D240", VA = "0x187E0E040")]
	private void NEMEGEDPGIM(HIPDGMOFECH ODLIDIMANGE, FLEPBPAFMND GMFBDIONGGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7E0DD50", Offset = "0x7E0CF50", VA = "0x187E0DD50")]
	public void LKEDPBIMAIL(HIPDGMOFECH ODLIDIMANGE, EEODNOBFJGJ GIHOJPFFMFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7E0DF90", Offset = "0x7E0D190", VA = "0x187E0DF90")]
	private static KEPOMIIOHBM MABOPMOEPDO(byte IEGHFABKDKJ)
	{
		return default(KEPOMIIOHBM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7E0E110", Offset = "0x7E0D310", VA = "0x187E0E110")]
	public PNDLHOFPMMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class JMOJFGEMDIO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct GDPEBDEKJCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public byte[] payload;
	}

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static readonly JsonSerializerSettings ACIEPPGEKIG;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7E0A860", Offset = "0x7E09A60", VA = "0x187E0A860")]
	public static CNOCNLPFEAP HBCFJGHOLNK([In] this CNOCNLPFEAP INMBPJOALLG, HIPDGMOFECH ODLIDIMANGE, EEODNOBFJGJ GIHOJPFFMFF)
	{
		return default(CNOCNLPFEAP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7E0B8C0", Offset = "0x7E0AAC0", VA = "0x187E0B8C0")]
	public static CNOCNLPFEAP IAPOFKHGIBI([In] this CNOCNLPFEAP INMBPJOALLG, HIPDGMOFECH ODLIDIMANGE)
	{
		return default(CNOCNLPFEAP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7E0BC20", Offset = "0x7E0AE20", VA = "0x187E0BC20")]
	public static string JBGIHOCPPOC(HIPDGMOFECH ODLIDIMANGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7E0A600", Offset = "0x7E09800", VA = "0x187E0A600")]
	public static string DHEOEEFNDLD(HIPDGMOFECH ODLIDIMANGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7E0C010", Offset = "0x7E0B210", VA = "0x187E0C010")]
	public static string PAGLEDPKCLE(HIPDGMOFECH ODLIDIMANGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7E0BE10", Offset = "0x7E0B010", VA = "0x187E0BE10")]
	[CompilerGenerated]
	internal static bool MEOOCDEOGBK([Out] string ACALKMLJJOL, GDPEBDEKJCE P_1)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7E0BEA0", Offset = "0x7E0B0A0", VA = "0x187E0BEA0")]
	[CompilerGenerated]
	internal static bool MPMKNFLAAED([Out] string ACALKMLJJOL, GDPEBDEKJCE P_1)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class JIMOOFOMAIG
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public JIMOOFOMAIG()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
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
