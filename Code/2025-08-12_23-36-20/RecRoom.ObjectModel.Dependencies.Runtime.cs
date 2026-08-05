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
	public class LogRegistrationIndex : GDJKPKDCEIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8546CA0", Offset = "0x8545AA0", VA = "0x188546CA0", Slot = "4")]
		public override void FAIIODDINIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
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
			[Cpp2IlInjected.Address(RVA = "0xA98B10", Offset = "0xA97910", VA = "0x180A98B10", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x238F970", Offset = "0x238E770", VA = "0x18238F970", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8549710", Offset = "0x8548510", VA = "0x188549710")]
		private void EDICDPMMNIG(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x85493E0", Offset = "0x85481E0", VA = "0x1885493E0")]
		private void DGAAKECFDPD(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8549AE0", Offset = "0x85488E0", VA = "0x188549AE0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8549B90", Offset = "0x8548990", VA = "0x188549B90")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[RegisterService(typeof(POMCHMJONBJ), new string[] { "Photon" })]
public class NONPHNJCIKK : POMCHMJONBJ
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private class CKDMDIKGPMN : KKIENGDGBHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public HPHHANMLLNF PEKEABNFGOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public StatusCode HGHNOLNJHMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public MKNHEJBIPKC DLBCLOGAHNK;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public IFIOAPJLFKJ FOJLLEMFFFA
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x8544F90", Offset = "0x8543D90", VA = "0x188544F90", Slot = "4")]
			get
			{
				return default(IFIOAPJLFKJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public JCHCDPDFDDM PEDHJHMKLLK
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x8544940", Offset = "0x8543740", VA = "0x188544940", Slot = "5")]
			get
			{
				return default(JCHCDPDFDDM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool CCLECGDLNNB
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x8544990", Offset = "0x8543790", VA = "0x188544990", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private bool POIHMHDGOBA
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8544BC0", Offset = "0x85439C0", VA = "0x188544BC0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x85447C0", Offset = "0x85435C0", VA = "0x1885447C0", Slot = "8")]
		public object BGAKFAJMBBA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x85450D0", Offset = "0x8543ED0", VA = "0x1885450D0", Slot = "9")]
		private (JCHCDPDFDDM, object) OPDFPMFHGFE()
		{
			return default((JCHCDPDFDDM, object));
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8544FE0", Offset = "0x8543DE0", VA = "0x188544FE0", Slot = "10")]
		private (NEOKJNLGPDM, JCHCDPDFDDM) OKOLNBGKBPG()
		{
			return default((NEOKJNLGPDM, JCHCDPDFDDM));
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8544810", Offset = "0x8543610", VA = "0x188544810", Slot = "11")]
		private EKJAGHLACDO<(NEOKJNLGPDM, JCHCDPDFDDM)> FLKNICCIAJI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8544D80", Offset = "0x8543B80", VA = "0x188544D80", Slot = "12")]
		private (ADGKOLDKGHI, byte[]) ODNBJPKINAH()
		{
			return default((ADGKOLDKGHI, byte[]));
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x85449A0", Offset = "0x85437A0", VA = "0x1885449A0", Slot = "13")]
		private (DMKPPKIIPNE, byte[]) MAKHBIBJFED()
		{
			return default((DMKPPKIIPNE, byte[]));
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x4447D80", Offset = "0x4446B80", VA = "0x184447D80", Slot = "14")]
		public T OBPKDNDEBIK<T>()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8545260", Offset = "0x8544060", VA = "0x188545260", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public CKDMDIKGPMN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[DefaultMember("Item")]
	private class MKNHEJBIPKC : EKJAGHLACDO<(NEOKJNLGPDM, JCHCDPDFDDM)>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int[] JHGEKNGMFJA;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int PJDGOCCOECF
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8548BF0", Offset = "0x85479F0", VA = "0x188548BF0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public (NEOKJNLGPDM view, JCHCDPDFDDM newOwner) ABJADGGNFCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8548B50", Offset = "0x8547950", VA = "0x188548B50", Slot = "4")]
			get
			{
				return default((NEOKJNLGPDM, JCHCDPDFDDM));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public MKNHEJBIPKC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8548D10", Offset = "0x8547B10", VA = "0x188548D10", Slot = "4")]
	public bool PJKONFNNFCK(object KANAIIDGHCH, KKIENGDGBHL KCMCAMOABPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public NONPHNJCIKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal static class ILJBIFAHODI
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AlsoBindServiceAs(typeof(JHKLINNDEGJ))]
[RegisterService(typeof(KECKELNINDO), new string[] { "Photon" })]
public class JHKLINNDEGJ : CMKJLANCAGA, HNJMCIHMAGA, KECKELNINDO, IHLGGOCLGIA, BOIHHABJILH
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly ALMLLDBPKBM IPEKLICENHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[DependsOn]
	private DMAJLKBEGOM IHDHFEFDGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[DependsOn]
	private HIKBJKNLAPL BEDBCOPPGNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Hashtable EAHIEHKAAEI;

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8546430", Offset = "0x8545230", VA = "0x188546430", Slot = "4")]
	public void InitReferences(CKKEMANKHME GLBBEGAGJCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8546AF0", Offset = "0x85458F0", VA = "0x188546AF0", Slot = "5")]
	public void ShutdownReferences()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8546780", Offset = "0x8545580", VA = "0x188546780", Slot = "6")]
	public void KFBKCEBBELK(DMKPPKIIPNE OPGJHIOADCK, ReadOnlySpan<byte> OBBABGHFJAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8546310", Offset = "0x8545110", VA = "0x188546310", Slot = "10")]
	public void CEIKFCEONPE(DMKPPKIIPNE HMHONNGLEHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8546960", Offset = "0x8545760", VA = "0x188546960", Slot = "7")]
	public void LMMEEKFNEIE(ReadOnlySpan<DMKPPKIIPNE> IOIANNLAHMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8546520", Offset = "0x8545320", VA = "0x188546520")]
	private Hashtable JJJGJDBFPMI(Hashtable JKBGDGNIPPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x85462B0", Offset = "0x85450B0", VA = "0x1885462B0")]
	public void AOBCGIPOFAN(object HBOAEALHJLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x85468F0", Offset = "0x85456F0", VA = "0x1885468F0", Slot = "8")]
	private void LFGDJFPHPKJ(CKKEMANKHME GLBBEGAGJCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0xFFD440", Offset = "0xFFC240", VA = "0x180FFD440", Slot = "9")]
	private void HJBDBNLCEFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8546C20", Offset = "0x8545A20", VA = "0x188546C20")]
	public JHKLINNDEGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[RegisterService(typeof(global::EBELANIKABN), new string[] { })]
internal class MOGNDOJOIAB : DFHFBADMHCD, global::EBELANIKABN
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly ALMLLDBPKBM LNCBLGCJBKL;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	protected override ALMLLDBPKBM[] CIMOAONFCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8548C60", Offset = "0x8547A60", VA = "0x188548C60")]
	public MOGNDOJOIAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class OABADJMJKIC : DefaultContractResolver
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8548E90", Offset = "0x8547C90", VA = "0x188548E90", Slot = "19")]
	protected override IList<JsonProperty> CreateProperties(Type ADGMECOLKNH, MemberSerialization MJIGKKKBDPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8549090", Offset = "0x8547E90", VA = "0x188549090")]
	public OABADJMJKIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class BMCBDPJJOOE
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class DHLKCLCNHDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public JsonSerializerSettings serializationSettings;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public DHLKCLCNHDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8545B00", Offset = "0x8544900", VA = "0x188545B00")]
		internal string ODELBHMJBNJ(HPHHANMLLNF eventData)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x85445A0", Offset = "0x85433A0", VA = "0x1885445A0")]
	public static string NKLCENBEEDM(this HPHHANMLLNF PEKEABNFGOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8544240", Offset = "0x8543040", VA = "0x188544240")]
	public static IFIOAPJLFKJ HBPCGFIFDML(this HPHHANMLLNF PEKEABNFGOF)
	{
		return default(IFIOAPJLFKJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x85445C0", Offset = "0x85433C0", VA = "0x1885445C0")]
	public static ViewId OFOBGELMBJA(this HPHHANMLLNF PEKEABNFGOF)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8543E20", Offset = "0x8542C20", VA = "0x188543E20")]
	public static string APOMGNEIFDJ(this HPHHANMLLNF PEKEABNFGOF, JsonSerializerSettings MLCLCBOBGGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8544390", Offset = "0x8543190", VA = "0x188544390")]
	private static string KAAPBNNCPIO(HPHHANMLLNF PEKEABNFGOF, Func<HPHHANMLLNF, string> IJBAPONMLAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8543EF0", Offset = "0x8542CF0", VA = "0x188543EF0")]
	public static string CNNHCCKKGCB(this HPHHANMLLNF PEKEABNFGOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8544060", Offset = "0x8542E60", VA = "0x188544060")]
	public static ViewId DBCKBOJJJJM(this HPHHANMLLNF PEKEABNFGOF)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8544480", Offset = "0x8543280", VA = "0x188544480")]
	public static string MFDLNNEKPPC(this HPHHANMLLNF PEKEABNFGOF, JsonSerializerSettings MLCLCBOBGGI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class EGFECINACGC
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal static class GKELJGMLKAL
	{
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static string JDMOPPJJKDM;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8545C40", Offset = "0x8544A40", VA = "0x188545C40")]
	public static string JFMHJKPGFEM(IFIOAPJLFKJ CDMMDCMMPFA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[RegisterService(typeof(DEOBJLPIAIB), new string[] { })]
[ServiceLifetime(Lifetime.PhotonRoom)]
internal class DEOBJLPIAIB : DFHFBADMHCD
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private static readonly ALMLLDBPKBM KLHJGAJJHID;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static readonly ALMLLDBPKBM HJPCNGEOPAE;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static readonly ALMLLDBPKBM FMNNFHGPABG;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	protected override ALMLLDBPKBM[] CIMOAONFCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x85455C0", Offset = "0x85443C0", VA = "0x1885455C0", Slot = "9")]
	public override void MDBAGKDBGJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x8545380", Offset = "0x8544180", VA = "0x188545380", Slot = "10")]
	public override void GEOHBDNPMHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x8545500", Offset = "0x8544300", VA = "0x188545500")]
	private void LBIJBPBAKGA(HPHHANMLLNF PEKEABNFGOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8545350", Offset = "0x8544150", VA = "0x188545350")]
	private void FAMJCOBEFKK(HPHHANMLLNF PEKEABNFGOF, ACKMCIEAMDG OMCPCACMNHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8545740", Offset = "0x8544540", VA = "0x188545740")]
	public void NNGHPFPEPOK(HPHHANMLLNF PEKEABNFGOF, LKNHGPMBGDK ALKMPAJFIJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8545510", Offset = "0x8544310", VA = "0x188545510")]
	private static ALMLLDBPKBM MABCCAJNDHA(byte OIBEBELDBPO)
	{
		return default(ALMLLDBPKBM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8545A20", Offset = "0x8544820", VA = "0x188545A20")]
	public DEOBJLPIAIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class MCDKEIINODP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct LLGPECOFMDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public byte[] payload;
	}

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static readonly JsonSerializerSettings DHJLACNAINP;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8547010", Offset = "0x8545E10", VA = "0x188547010")]
	public static ECHGNBADPJO BOAEACNHOBJ([In] this ECHGNBADPJO IHIEAJGNFHC, HPHHANMLLNF PEKEABNFGOF, LKNHGPMBGDK ALKMPAJFIJI)
	{
		return default(ECHGNBADPJO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x8548440", Offset = "0x8547240", VA = "0x188548440")]
	public static ECHGNBADPJO MPKJMGGADJB([In] this ECHGNBADPJO IHIEAJGNFHC, HPHHANMLLNF PEKEABNFGOF)
	{
		return default(ECHGNBADPJO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8548260", Offset = "0x8547060", VA = "0x188548260")]
	public static string GIGFBLEHDDL(HPHHANMLLNF PEKEABNFGOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8546DB0", Offset = "0x8545BB0", VA = "0x188546DB0")]
	public static string AFCJPJCHFEA(HPHHANMLLNF PEKEABNFGOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x85480D0", Offset = "0x8546ED0", VA = "0x1885480D0")]
	public static string DNHKAIMKFOH(HPHHANMLLNF PEKEABNFGOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8548790", Offset = "0x8547590", VA = "0x188548790")]
	[CompilerGenerated]
	internal static bool NCEDKNHNAGE([Out] string MOBFLOHJOKJ, LLGPECOFMDJ P_1)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8548820", Offset = "0x8547620", VA = "0x188548820")]
	[CompilerGenerated]
	internal static bool PMDGAFMJNNP([Out] string MOBFLOHJOKJ, LLGPECOFMDJ P_1)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class EDFFLPDHNEN
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public EDFFLPDHNEN()
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
