using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using ExitGames.Client.Photon;
using JetBrains.Annotations;
using RecRoom;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Foundation;
using RecRoom.Logging.Attributes;
using RecRoom.Networking;
using RecRoom.ObjectModel;
using Unity.Netcode;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Networking_RRNetworkLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : EJFLMJDOOOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8595BD0", Offset = "0x85941D0", VA = "0x188595BD0", Slot = "4")]
		public override void CBPAAEAGBMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Networking_RRNetworkLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
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

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xA95060", Offset = "0xA93660", VA = "0x180A95060", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x23A8580", Offset = "0x23A6B80", VA = "0x1823A8580", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x85A9800", Offset = "0x85A7E00", VA = "0x1885A9800")]
		private void DHALDHDBNEP(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x85A9E50", Offset = "0x85A8450", VA = "0x1885A9E50")]
		private void FAEKOOMPDOO(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x85AA0D0", Offset = "0x85A86D0", VA = "0x1885AA0D0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x85AA180", Offset = "0x85A8780", VA = "0x1885AA180")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class NAFJCPMAKNI
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly IDGHEFJHGEI IJNDEDMJCID;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IDGHEFJHGEI KGJPDBJAFPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8595E30", Offset = "0x8594430", VA = "0x188595E30")]
		get
		{
			return default(IDGHEFJHGEI);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface DDDICMCNABK
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	RRNetworkView NDAFNMIAPOF
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	ICEAPJCMCDK PPODLIODLAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool CGEEBMBCGFN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0", Slot = "2")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool Serialize(MPMCDJEAJMN MEEHIMFCOIJ);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void Deserialize(LIAPHNEOGHK AFDLHEFMFJN, MPMCDJEAJMN MEEHIMFCOIJ);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface EHNNBNEMCBK
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool FKEHHOCHBMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HCAOPIJCJDC(LIAPHNEOGHK AFDLHEFMFJN);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KJBCLIOBDIC(LIAPHNEOGHK AFDLHEFMFJN, MPMCDJEAJMN MEEHIMFCOIJ);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface NECKCGMOIGB : INetworkUpdateSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CBPAAEAGBMC(DDDICMCNABK MIBDFFKEGHP);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EEAAOMNILHP(DDDICMCNABK MIBDFFKEGHP);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PCEOJEMCNIE(PGKPGCJEIJN.PAKNBGDFILP EKGFEIFBJGK);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BFGGJLOPFOC();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IGPICAOBBGO(object KJOIOABMAMH);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct LIAPHNEOGHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int ANEPFBIMBAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public uint NGEODBOPKGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public double DEDHBGFKLNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public int BONEFEFCDNL;
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class ILEAEFHOEPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Dictionary<(ViewId, ICEAPJCMCDK), EHNNBNEMCBK> NGNEIOGENGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly List<DDDICMCNABK> BPFOGEJEJEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly HashSet<(ViewId, ICEAPJCMCDK)> LAKLPHMKEBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private int PHHMMCBCBFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public bool KBANPHBGLCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private PGKPGCJEIJN.PAKNBGDFILP EKGFEIFBJGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly MemoryStream PDBDAFAJFOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly MPMCDJEAJMN APAMKFJKIDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly MPMCDJEAJMN KMHNFDCFHAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private byte[] CBGLFGOOBEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private float LDDOONFPICB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int JAAJIOACOEL;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8591180", Offset = "0x858F780", VA = "0x188591180")]
	public ILEAEFHOEPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8591160", Offset = "0x858F760", VA = "0x188591160")]
	public void PCEOJEMCNIE(PGKPGCJEIJN.PAKNBGDFILP EKGFEIFBJGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x858FCB0", Offset = "0x858E2B0", VA = "0x18858FCB0")]
	public void BFGGJLOPFOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x85900D0", Offset = "0x858E6D0", VA = "0x1885900D0")]
	public void FLHPFKIPOFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8590BD0", Offset = "0x858F1D0", VA = "0x188590BD0")]
	public bool KMLBEHGKDFG(DDDICMCNABK MIBDFFKEGHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x85904C0", Offset = "0x858EAC0", VA = "0x1885904C0")]
	public bool HCDNAOEAAEJ(DDDICMCNABK MIBDFFKEGHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x85905F0", Offset = "0x858EBF0", VA = "0x1885905F0")]
	private EHNNBNEMCBK HNCAKKGKKHP(ViewId KBEDHBMNMBE, ICEAPJCMCDK EOPFJLJEMLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x85904B0", Offset = "0x858EAB0", VA = "0x1885904B0")]
	public void FOAEILDIGLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8591100", Offset = "0x858F700", VA = "0x188591100")]
	private void LNJLFBDDMJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x85900B0", Offset = "0x858E6B0", VA = "0x1885900B0")]
	private void EHPDEELHFDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x858FD00", Offset = "0x858E300", VA = "0x18858FD00")]
	public bool DDPLEANPIHK(FastBufferWriter ENKMBIEHHDM, int GMEHBMKJPAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8590810", Offset = "0x858EE10", VA = "0x188590810")]
	public void KJBCLIOBDIC(LIAPHNEOGHK AFDLHEFMFJN, FastBufferReader EMPLJNKCONI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal class AOALPNIILEP : EHNNBNEMCBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private DDDICMCNABK JGPCIBINGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private uint DFHGKBCOJPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private int CLLFEPMLBBG;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool FKEHHOCHBMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0xA9AB40", Offset = "0xA99140", VA = "0x180A9AB40")]
	public AOALPNIILEP(DDDICMCNABK JGPCIBINGEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8587BC0", Offset = "0x85861C0", VA = "0x188587BC0", Slot = "5")]
	public bool HCAOPIJCJDC(LIAPHNEOGHK AFDLHEFMFJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8587CD0", Offset = "0x85862D0", VA = "0x188587CD0", Slot = "6")]
	public void KJBCLIOBDIC(LIAPHNEOGHK AFDLHEFMFJN, MPMCDJEAJMN MEEHIMFCOIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ALKBNIFILIE : EHNNBNEMCBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private PGKPGCJEIJN.PAKNBGDFILP EKGFEIFBJGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly ViewId KBEDHBMNMBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private int CLLFEPMLBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private uint DFHGKBCOJPL;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool FKEHHOCHBMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xAB05C0", Offset = "0xAAEBC0", VA = "0x180AB05C0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1C832F0", Offset = "0x1C818F0", VA = "0x181C832F0")]
	public ALKBNIFILIE(ViewId KBEDHBMNMBE, PGKPGCJEIJN.PAKNBGDFILP EKGFEIFBJGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x85879A0", Offset = "0x8585FA0", VA = "0x1885879A0", Slot = "5")]
	public bool HCAOPIJCJDC(LIAPHNEOGHK AFDLHEFMFJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x85879E0", Offset = "0x8585FE0", VA = "0x1885879E0", Slot = "6")]
	public void KJBCLIOBDIC(LIAPHNEOGHK AFDLHEFMFJN, MPMCDJEAJMN MEEHIMFCOIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class FMOCLMHFLOI
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x858A0E0", Offset = "0x85886E0", VA = "0x18858A0E0")]
	public static void CAELEDFILEL(this HINBANPDLCM HFOPCCIGBNM, MPMCDJEAJMN GLDNAIKNJJG, ViewId HHPFOCCGJIF, bool AFEOOKLFIGJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x858A2A0", Offset = "0x85888A0", VA = "0x18858A2A0")]
	public static void CHLELFMMHNP(this HINBANPDLCM HFOPCCIGBNM, MPMCDJEAJMN GLDNAIKNJJG, bool AFEOOKLFIGJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x858A7A0", Offset = "0x8588DA0", VA = "0x18858A7A0")]
	public static HINBANPDLCM KJBCLIOBDIC(MPMCDJEAJMN GLDNAIKNJJG, ViewId HHPFOCCGJIF, bool AFEOOKLFIGJ = true)
	{
		return default(HINBANPDLCM);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x858A910", Offset = "0x8588F10", VA = "0x18858A910")]
	public static void PCECDLFKOEF(this HINBANPDLCM HFOPCCIGBNM, MPMCDJEAJMN GLDNAIKNJJG, bool AFEOOKLFIGJ = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[RegisterService(typeof(NECKCGMOIGB), new string[] { })]
public class NLEHEDAKNPI : NECKCGMOIGB, INetworkUpdateSystem, KDLLCPKJBMN, LKJPKMELKMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly IDGHEFJHGEI HGPEAPHGMGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private ILEAEFHOEPI CFNDENLNLCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private uint GHKMEIMAHGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private float IMKAHMFHJNE;

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x85962D0", Offset = "0x85948D0", VA = "0x1885962D0", Slot = "4")]
	public void CBPAAEAGBMC(DDDICMCNABK MIBDFFKEGHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x85963F0", Offset = "0x85949F0", VA = "0x1885963F0", Slot = "5")]
	public void EEAAOMNILHP(DDDICMCNABK MIBDFFKEGHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x85965F0", Offset = "0x8594BF0", VA = "0x1885965F0", Slot = "10")]
	public void EPMGJNHIDNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8596DA0", Offset = "0x85953A0", VA = "0x188596DA0", Slot = "9")]
	public void NetworkUpdate(NetworkUpdateStage KODKOJKNGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x85967B0", Offset = "0x8594DB0", VA = "0x1885967B0")]
	private void NGHOBIFPPKG(uint ABDEGILHBDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8596E20", Offset = "0x8595420", VA = "0x188596E20", Slot = "6")]
	public void PCEOJEMCNIE(PGKPGCJEIJN.PAKNBGDFILP EKGFEIFBJGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x8596270", Offset = "0x8594870", VA = "0x188596270", Slot = "7")]
	public void BFGGJLOPFOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x8596750", Offset = "0x8594D50", VA = "0x188596750", Slot = "8")]
	public void IGPICAOBBGO(object KMDFLMLKEEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x8595EF0", Offset = "0x85944F0", VA = "0x188595EF0")]
	private void ALGHCKOECHC(CHPJIJKJKGB KMDFLMLKEEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x8596E50", Offset = "0x8595450", VA = "0x188596E50", Slot = "11")]
	public void PILPLNBAOCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8596F70", Offset = "0x8595570", VA = "0x188596F70")]
	public NLEHEDAKNPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class CPCMKJCFKCC : EHNNBNEMCBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private float HHBAKFIHCMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private int CLLFEPMLBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private uint DFHGKBCOJPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly ICEAPJCMCDK HIPBNCPKNJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public LIAPHNEOGHK DDJDLHFGDDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public int IAMKAFLLLMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public byte[] FGPHKKNGLLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private LIAPHNEOGHK PONCMGBJCEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int KPJAJKOJOGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private byte[] IKALMPGMDCJ;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool FKEHHOCHBMO
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8589A90", Offset = "0x8588090", VA = "0x188589A90", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x8589BD0", Offset = "0x85881D0", VA = "0x188589BD0")]
	public CPCMKJCFKCC(ICEAPJCMCDK HIPBNCPKNJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x85898A0", Offset = "0x8587EA0", VA = "0x1885898A0", Slot = "5")]
	public bool HCAOPIJCJDC(LIAPHNEOGHK AFDLHEFMFJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x85898E0", Offset = "0x8587EE0", VA = "0x1885898E0", Slot = "6")]
	public void KJBCLIOBDIC(LIAPHNEOGHK AFDLHEFMFJN, MPMCDJEAJMN MEEHIMFCOIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x8589AC0", Offset = "0x85880C0", VA = "0x188589AC0")]
	internal AOALPNIILEP LMDKNPCEOBL(DDDICMCNABK MIBDFFKEGHP, MPMCDJEAJMN GLDNAIKNJJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x85896D0", Offset = "0x8587CD0", VA = "0x1885896D0")]
	private static void BAHLDHGDBEM(AOALPNIILEP JJNJIDOPKFC, MPMCDJEAJMN GLDNAIKNJJG, LIAPHNEOGHK DBKMINAPKAE, byte[] COEFMBJKIKA, int NMBDPLPODMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[RegisterService(typeof(PGADACOPNOC), new string[] { })]
[ServiceLifetime(Lifetime.Application)]
public class PGADACOPNOC : IGIBKNHNEBP, KDLLCPKJBMN, LKJPKMELKMK
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly Hashtable EBCIHKPFKGD;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly Hashtable HPLEPJHAHOM;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static readonly Hashtable EFPABCFEPIP;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static readonly CHACOCKEPKK HAGNICOHOCB;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly CHACOCKEPKK NCLKNNGMHAP;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static readonly CHACOCKEPKK FCAJKMPKILD;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static readonly CHACOCKEPKK FOBEAEJPJDD;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static readonly CHACOCKEPKK KMJFGPHOGBF;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static int DIPFPIBLDEA;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8597500", Offset = "0x8595B00", VA = "0x188597500", Slot = "4")]
	public bool FFOKLBENAMF(NEIKMBGDPOI MHCCEBNBPPI, bool NNIGHJGEHLI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8597A60", Offset = "0x8596060", VA = "0x188597A60", Slot = "5")]
	public int IEILOHJCFOA(NEIKMBGDPOI[] HJEHIGNFBAG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8598F50", Offset = "0x8597550", VA = "0x188598F50", Slot = "6")]
	public bool OKAAMDAIJDH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8597760", Offset = "0x8595D60", VA = "0x188597760", Slot = "7")]
	public bool GKOLKEDLFIH(int KBEDHBMNMBE, int IKKJDEFHNPG, bool IBPIAPBNIAJ, GameObject EGMHLHLEIMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8597100", Offset = "0x8595700", VA = "0x188597100", Slot = "8")]
	public void BNCAANECNNF(int IKKJDEFHNPG, [Optional] int? NPNKAOIDCOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x85986B0", Offset = "0x8596CB0", VA = "0x1885986B0", Slot = "9")]
	public bool LKGLENCEHFP(CHPJIJKJKGB KJOIOABMAMH, [Out] NEIKMBGDPOI NMLIHNPKKOC, bool CADLGBPCAME = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x8598820", Offset = "0x8596E20", VA = "0x188598820", Slot = "10")]
	public bool NCOLMIKDCIJ(CHPJIJKJKGB KJOIOABMAMH, [Out] int MNAFGCEMEEM, [Out] NEIKMBGDPOI[] HJEHIGNFBAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8597640", Offset = "0x8595C40", VA = "0x188597640", Slot = "11")]
	public bool GHJAEOMKJMN(CHPJIJKJKGB KJOIOABMAMH, [Out] int IKKJDEFHNPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8597EF0", Offset = "0x85964F0", VA = "0x188597EF0", Slot = "12")]
	public void JHLFHLIJEBA(CHPJIJKJKGB KJOIOABMAMH, [Out] int ALINLKPMGAH, [Out] int[] EEIGGAFCBHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8597900", Offset = "0x8595F00", VA = "0x188597900", Slot = "13")]
	public void GPANPIHEBMP(int MNAFGCEMEEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x85990C0", Offset = "0x85976C0", VA = "0x1885990C0", Slot = "14")]
	public void ONLMPLKECMN(int MNAFGCEMEEM, int[] EEIGGAFCBHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8597050", Offset = "0x8595650", VA = "0x188597050", Slot = "15")]
	public void BEDJCHCNMNL(int[] EEIGGAFCBHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8597E20", Offset = "0x8596420", VA = "0x188597E20", Slot = "16")]
	public void JEGBAHLGNDI(int[] EEIGGAFCBHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x85972F0", Offset = "0x85958F0", VA = "0x1885972F0", Slot = "17")]
	public void DEOOJKPBMCF(int MNAFGCEMEEM, int IKKJDEFHNPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x8598B10", Offset = "0x8597110", VA = "0x188598B10")]
	private static void NPDPEFAEFMB(NEIKMBGDPOI MHCCEBNBPPI, Hashtable FPAJFFFMBBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x85980D0", Offset = "0x85966D0", VA = "0x1885980D0")]
	private static bool LKGLENCEHFP(Hashtable FPAJFFFMBBG, NGPBJJLAELK NAOLNBDNHEN, [Out] NEIKMBGDPOI NMLIHNPKKOC, bool CADLGBPCAME = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x8598FE0", Offset = "0x85975E0", VA = "0x188598FE0")]
	private static int OLPABBBJFIA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x8597460", Offset = "0x8595A60", VA = "0x188597460", Slot = "18")]
	public void EPMGJNHIDNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x85991E0", Offset = "0x85977E0", VA = "0x1885991E0", Slot = "19")]
	public void PILPLNBAOCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public PGADACOPNOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[RegisterService(typeof(IKFLGJHHBAL), new string[] { })]
[ServiceLifetime(Lifetime.Application)]
public class IKFLGJHHBAL : GCFHAFGKHAO, KDLLCPKJBMN, LKJPKMELKMK
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static Hashtable ECJLOPFAHJJ;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static Hashtable KCFGPDFIOEP;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static CHACOCKEPKK NMHDAJMLIHC;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static readonly CHACOCKEPKK PJBOEHMNJHO;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private static IDGHEFJHGEI FEFALLLFAGB;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x858FA00", Offset = "0x858E000", VA = "0x18858FA00", Slot = "4")]
	public void PMBAFDFMGBJ(ViewId KBEDHBMNMBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x858F560", Offset = "0x858DB60", VA = "0x18858F560", Slot = "5")]
	public bool CAFENLOFKEH(CHPJIJKJKGB KJOIOABMAMH, [Out] ViewId KBEDHBMNMBE, [Out] string BKCBMFPHNNL, [Out] int EPEOJKACHKK, [Out] object[] ILLMINLDJKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x858EF10", Offset = "0x858D510", VA = "0x18858EF10", Slot = "6")]
	public void AGEDGCODPIB(ViewId MLCJICFBOOE, string BKCBMFPHNNL, MACNHJCIMEN DPONGBBHBGJ, NGPBJJLAELK LIOICDJHFAF, DIFLOFIPONG PDONCLMEOCB, object[] MHCCEBNBPPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x858F960", Offset = "0x858DF60", VA = "0x18858F960", Slot = "8")]
	public void PILPLNBAOCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x858F8C0", Offset = "0x858DEC0", VA = "0x18858F8C0", Slot = "7")]
	public void EPMGJNHIDNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public IKFLGJHHBAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class PJLJJALKACN
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8599580", Offset = "0x8597B80", VA = "0x188599580")]
	public static NGPBJJLAELK LNPAICEDIOH(this NAPCGDBANAF PDIOIHNCAEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8599610", Offset = "0x8597C10", VA = "0x188599610")]
	public static NAPCGDBANAF NGOFHLAIAAN(this NGPBJJLAELK LIOICDJHFAF)
	{
		return default(NAPCGDBANAF);
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class RRNetworkBehavior : MonoBehaviour, EDCAAAFBPIH, FLBLBACKMJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool networkedViewInitialized;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private RRNetworkView networkedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private List<KFGKOJJMBIF> destroyHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private bool isForwarderRegistered;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public ViewId NOCMABOLNHK
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x85A2B00", Offset = "0x85A1100", VA = "0x1885A2B00")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public ViewId JOGMBHAAFMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x85A2B00", Offset = "0x85A1100", VA = "0x1885A2B00", Slot = "4")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		[Obsolete("Use NetworkedView instead")]
		public RRNetworkView HPPGNKNPKJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x85A2B80", Offset = "0x85A1180", VA = "0x1885A2B80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public RRNetworkView NDAFNMIAPOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x85A2B80", Offset = "0x85A1180", VA = "0x1885A2B80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public NGPBJJLAELK GOEGFMADCPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x85A2C80", Offset = "0x85A1280", VA = "0x1885A2C80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public NGPBJJLAELK DBPGJLKPCJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x85A2FE0", Offset = "0x85A15E0", VA = "0x1885A2FE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool DFPHIIDDLOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x85A2DE0", Offset = "0x85A13E0", VA = "0x1885A2DE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool ENPEMJKANPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x85A2F50", Offset = "0x85A1550", VA = "0x1885A2F50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool FHMLDIPCEMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x85A2A30", Offset = "0x85A1030", VA = "0x1885A2A30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool FBDFIENECFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x85A2D10", Offset = "0x85A1310", VA = "0x1885A2D10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool COEELAHHOIC
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x85A2A30", Offset = "0x85A1030", VA = "0x1885A2A30", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool FHAAPHDOBFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x85A2AB0", Offset = "0x85A10B0", VA = "0x1885A2AB0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public string IDMHMGADINJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x85A2BF0", Offset = "0x85A11F0", VA = "0x1885A2BF0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool NPDBKCPJHJG
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x85A29B0", Offset = "0x85A0FB0", VA = "0x1885A29B0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<NGPBJJLAELK> PBOEMIIBHFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x85A2880", Offset = "0x85A0E80", VA = "0x1885A2880")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x85A3070", Offset = "0x85A1670", VA = "0x1885A3070")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x85A27E0", Offset = "0x85A0DE0", VA = "0x1885A27E0")]
		public bool WasSpawnedForPlayer(int PHHDDMDHFFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7879650", Offset = "0x7877C50", VA = "0x187879650")]
		private void BNMNFKJKAAM(RRNetworkView CGLIDCMIAEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x85A2410", Offset = "0x85A0A10", VA = "0x1885A2410", Slot = "9")]
		public void RegisterDestroyHandler(KFGKOJJMBIF CACEFGPINFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x85A2610", Offset = "0x85A0C10", VA = "0x1885A2610", Slot = "10")]
		public void UnregisterDestroyHandler(KFGKOJJMBIF CACEFGPINFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "11")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x85A23F0", Offset = "0x85A09F0", VA = "0x1885A23F0", Slot = "12")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA97AB0", Offset = "0xA960B0", VA = "0x180A97AB0")]
		public RRNetworkBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class KKDKHLDBLBN
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate void GNMNMPPNEHJ([In] NEIKMBGDPOI MHCCEBNBPPI, bool JAKGGEGIGNK, bool FPAJFFFMBBG, bool GMJFEJNPLBI);

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate void NDEOPGDDPEF(GameObject KDNOBMEOLJE);

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public delegate void HMOKBMNJKCO(GameObject KDNOBMEOLJE);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public delegate void FMLANEPKJOD(RRNetworkView MLCJICFBOOE, string BKCBMFPHNNL, NGPBJJLAELK OFMAIOJLPIF, MACNHJCIMEN? LKEAKCADNOO, bool COLCAOLICNJ, DIFLOFIPONG LLAMMDFPKFC, object[] MHCCEBNBPPI, string CDCFFJMHLDI);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public delegate void BCHGFPDJEEF(RRNetworkView MLCJICFBOOE, string BKCBMFPHNNL, NGPBJJLAELK OFMAIOJLPIF, MACNHJCIMEN? LKEAKCADNOO, bool COLCAOLICNJ, DIFLOFIPONG LLAMMDFPKFC, object[] MHCCEBNBPPI, string CDCFFJMHLDI);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public delegate void FBOJLHDDNMA(RRNetworkView MLCJICFBOOE, string BKCBMFPHNNL, object[] ILLMINLDJKA, string DGHEMFLDNBL);

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate void FKALBGHKDLK(RRNetworkView MLCJICFBOOE, NGPBJJLAELK BAHHEJHMPGL);

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[CompilerGenerated]
	private static NDEOPGDDPEF JLNKBHIGLIA;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public static event GNMNMPPNEHJ HBECIOOMJIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8595460", Offset = "0x8593A60", VA = "0x188595460")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x85941B0", Offset = "0x85927B0", VA = "0x1885941B0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public static event NDEOPGDDPEF LJCHDOAHHEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8594C80", Offset = "0x8593280", VA = "0x188594C80")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x85948F0", Offset = "0x8592EF0", VA = "0x1885948F0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public static event HMOKBMNJKCO ONEIACPEIHP
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8594D40", Offset = "0x8593340", VA = "0x188594D40")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8594450", Offset = "0x8592A50", VA = "0x188594450")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public static event HMOKBMNJKCO LAGJADBGFCB
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8594BC0", Offset = "0x85931C0", VA = "0x188594BC0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8594F80", Offset = "0x8593580", VA = "0x188594F80")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public static event FMLANEPKJOD BMIOPLIOKFI
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8594E00", Offset = "0x8593400", VA = "0x188594E00")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8594EC0", Offset = "0x85934C0", VA = "0x188594EC0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public static event BCHGFPDJEEF CNLCNAMNOCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x85953A0", Offset = "0x85939A0", VA = "0x1885953A0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8594B00", Offset = "0x8593100", VA = "0x188594B00")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public static event FBOJLHDDNMA OAGGGBNBPEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8595040", Offset = "0x8593640", VA = "0x188595040")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8594830", Offset = "0x8592E30", VA = "0x188594830")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public static event FKALBGHKDLK JNEAHNIODBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x85946B0", Offset = "0x8592CB0", VA = "0x1885946B0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8594770", Offset = "0x8592D70", VA = "0x188594770")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public static event FKALBGHKDLK CGNOOAAJNOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8594390", Offset = "0x8592990", VA = "0x188594390")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8595520", Offset = "0x8593B20", VA = "0x188595520")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x8595190", Offset = "0x8593790", VA = "0x188595190")]
	public static void OACGKLKJBPE([In] NEIKMBGDPOI MHCCEBNBPPI, bool JAKGGEGIGNK, bool FPAJFFFMBBG, bool GMJFEJNPLBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x8594510", Offset = "0x8592B10", VA = "0x188594510")]
	public static void EOBKLLHBFOK(GameObject KDNOBMEOLJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8594300", Offset = "0x8592900", VA = "0x188594300")]
	public static void BPJIJFIGCAE(GameObject KDNOBMEOLJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x8595100", Offset = "0x8593700", VA = "0x188595100")]
	public static void MALGEGAEGPP(GameObject KDNOBMEOLJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x8594270", Offset = "0x8592870", VA = "0x188594270")]
	public static void BIMLPFMBCMI(GameObject KDNOBMEOLJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x8595250", Offset = "0x8593850", VA = "0x188595250")]
	public static void OFBHNNOAKII(RRNetworkView MLCJICFBOOE, string BKCBMFPHNNL, NGPBJJLAELK OFMAIOJLPIF, MACNHJCIMEN? LKEAKCADNOO, bool COLCAOLICNJ, DIFLOFIPONG LLAMMDFPKFC, object[] MHCCEBNBPPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x85949B0", Offset = "0x8592FB0", VA = "0x1885949B0")]
	public static void HIBNKMJKCFE(RRNetworkView MLCJICFBOOE, string BKCBMFPHNNL, int LDIFBBGPKHO, object[] ILLMINLDJKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x85945A0", Offset = "0x8592BA0", VA = "0x1885945A0")]
	public static void EPBBBJDOEEP(int KBEDHBMNMBE, int PDIOIHNCAEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class BOIGPJKBIOC
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x85880F0", Offset = "0x85866F0", VA = "0x1885880F0")]
	[CanBeNull]
	private static bool MMCGNPEDIBL(ViewId JIEJOKBHEMF, [Out] RRNetworkView MLCJICFBOOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x8588010", Offset = "0x8586610", VA = "0x188588010")]
	[CanBeNull]
	public static Component KIFFJIIIGBF(this ViewId MLCJICFBOOE, Type HJKDALACOPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3B299F0", Offset = "0x3B27FF0", VA = "0x183B299F0")]
	[CanBeNull]
	public static T KIFFJIIIGBF<T>(this ViewId MLCJICFBOOE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3B299F0", Offset = "0x3B27FF0", VA = "0x183B299F0")]
	[CanBeNull]
	public static T GAFFCNOEHHB<T>(this ViewId MLCJICFBOOE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3B29A40", Offset = "0x3B28040", VA = "0x183B29A40")]
	public static bool PKDKEHCDAMK<T>(this ViewId MLCJICFBOOE, [Out] T CENCPMGPALN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8587F40", Offset = "0x8586540", VA = "0x188587F40")]
	[CanBeNull]
	public static RRNetworkView DFLOMOGOAFF(this ViewId MLCJICFBOOE)
	{
		return null;
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class RRNetworkHandler : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static RRNetworkHandler PLKOLLOCKHK;

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public static bool AppQuits;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		internal static RRNetworkHandler DOBPPELCKJD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x85A31A0", Offset = "0x85A17A0", VA = "0x1885A31A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x85A3370", Offset = "0x85A1970", VA = "0x1885A3370")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void StaticReset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x85A3330", Offset = "0x85A1930", VA = "0x1885A3330")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xA97AB0", Offset = "0xA960B0", VA = "0x180A97AB0")]
		public RRNetworkHandler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[RegisterService(typeof(PNODBHBMKOI), new string[] { "Photon" })]
[ServiceLifetime(Lifetime.PhotonRoom)]
public sealed class PNODBHBMKOI : JKBJLIJPEIG, KDLLCPKJBMN, LKJPKMELKMK, BEEMKDJGJGG, HJJHIIDNFCE
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class BPAJCHCHLPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public int requestedViewId;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public BPAJCHCHLPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x85881A0", Offset = "0x85867A0", VA = "0x1885881A0")]
		internal object ECGHPHLKGNA((int requestedViewId, int newOwnerId, int senderId) x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static IDGHEFJHGEI LAJBLNDNGLK;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private static IDGHEFJHGEI JJHNBGCGHHK;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static Dictionary<int, HashSet<int>> MPBPLHEBHGH;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private static Dictionary<int, int> KPNAJFHFLCC;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private static readonly List<(GameObject GameObject, int ParentCount)> GNACLJMKIIM;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private static readonly List<GameObject> DEMOIIFFANN;

	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private static List<int> EENKMBDPDLH;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private static readonly List<RRNetworkView> HKPNIANANHN;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private static readonly CHACOCKEPKK FOBEAEJPJDD;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private static readonly CHACOCKEPKK KMJFGPHOGBF;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x859BDC0", Offset = "0x859A3C0", VA = "0x18859BDC0", Slot = "8")]
	public void EPMGJNHIDNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x85A1B60", Offset = "0x85A0160", VA = "0x1885A1B60", Slot = "9")]
	public void PILPLNBAOCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x859FCD0", Offset = "0x859E2D0", VA = "0x18859FCD0", Slot = "10")]
	public void InitExternal(MKDGNELEFKI MMELACBKGMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x859A150", Offset = "0x8598750", VA = "0x18859A150", Slot = "11")]
	public void BMODMMCKAOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x85A1EE0", Offset = "0x85A04E0", VA = "0x1885A1EE0")]
	private void POLAEAENIKF(NBOLPBCNBAN OBGEGNLIKAM, NBOLPBCNBAN BJGEPEKIJPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x859BA80", Offset = "0x859A080", VA = "0x18859BA80")]
	private void DJNODCHOJJE(MMKDKBFCKLN LOBLEEIEILH, MMKDKBFCKLN FCNLPJMKEPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x859BBE0", Offset = "0x859A1E0", VA = "0x18859BBE0")]
	public GameObject EBCCOLAOCDG(string DJFMCHMDHGK, Vector3 AANGPKCDGHO, Quaternion NEOIPHFFLHF, Vector3 ILFCOODFNFF, ViewId KBEDHBMNMBE, DDNEFPADLOB MHCCEBNBPPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x859C130", Offset = "0x859A730", VA = "0x18859C130")]
	public GameObject FBAPNPFBJJG(string DJFMCHMDHGK, Vector3 AANGPKCDGHO, Quaternion NEOIPHFFLHF, float ILFCOODFNFF, object[] MHCCEBNBPPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x859C230", Offset = "0x859A830", VA = "0x18859C230")]
	public GameObject FGBLMNJMLBF(string DJFMCHMDHGK, Vector3 AANGPKCDGHO, Quaternion NEOIPHFFLHF, Vector3 ILFCOODFNFF, ViewId MLCJICFBOOE, DDNEFPADLOB MHCCEBNBPPI, bool GMJFEJNPLBI = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x859D2C0", Offset = "0x859B8C0", VA = "0x18859D2C0")]
	public GameObject GCKBPOBLBCI(NEIKMBGDPOI MHCCEBNBPPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x859FEA0", Offset = "0x859E4A0", VA = "0x18859FEA0", Slot = "6")]
	public void JANGEIJBJHD(GameObject KDNOBMEOLJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x859DD70", Offset = "0x859C370", VA = "0x18859DD70")]
	public void GIDNJBJNPNK(GameObject EGMHLHLEIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x85A0250", Offset = "0x859E850", VA = "0x1885A0250", Slot = "7")]
	public void JJLIJEPDADF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x8599660", Offset = "0x8597C60", VA = "0x188599660", Slot = "4")]
	public GameObject[] AKENICBHOIM(IList<CIOENMFOBPH> FAJNOCIIJMC, bool HMFKBPJIAEN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x8599C90", Offset = "0x8598290", VA = "0x188599C90", Slot = "5")]
	public void BAGODIJPNOD(List<GameObject> PMKNAOIONBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x859D1E0", Offset = "0x859B7E0", VA = "0x18859D1E0")]
	public void FPEECCPMMCP(GameObject EGMHLHLEIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x8599990", Offset = "0x8597F90", VA = "0x188599990")]
	private void ALGHCKOECHC(CHPJIJKJKGB KJOIOABMAMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x859E4E0", Offset = "0x859CAE0", VA = "0x18859E4E0")]
	private void HHFEACFAAJO(CHPJIJKJKGB KJOIOABMAMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x859B250", Offset = "0x8599850", VA = "0x18859B250")]
	private void CAGBANGEEMG(CHPJIJKJKGB KJOIOABMAMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x85A1870", Offset = "0x859FE70", VA = "0x1885A1870")]
	private void OODMMNABFDG(CHPJIJKJKGB KJOIOABMAMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x85A0540", Offset = "0x859EB40", VA = "0x1885A0540")]
	private void KNMNNOBPNKL(CHPJIJKJKGB KJOIOABMAMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x85A0D10", Offset = "0x859F310", VA = "0x1885A0D10")]
	private void KPODFFPKPDO(CHPJIJKJKGB KJOIOABMAMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x859F1B0", Offset = "0x859D7B0", VA = "0x18859F1B0")]
	private void IMIMDNGHKFC(CHPJIJKJKGB KJOIOABMAMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x859F830", Offset = "0x859DE30", VA = "0x18859F830")]
	private GameObject IOPCDCIODKJ(string MAIHBFHEECO, Vector3 AANGPKCDGHO, Quaternion NEOIPHFFLHF, Vector3 ILFCOODFNFF, byte IJNDEDMJCID = 0, [Optional] object[] DAJAOHIJHHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x859DDE0", Offset = "0x859C3E0", VA = "0x18859DDE0")]
	private GameObject HCKELFNFLFL(NEIKMBGDPOI MHCCEBNBPPI, bool JAKGGEGIGNK = false, bool FPAJFFFMBBG = false, bool GMJFEJNPLBI = true, bool OEHBJHOPAKL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x859FEB0", Offset = "0x859E4B0", VA = "0x18859FEB0")]
	private static GameObject JBHEFKPFHBG(string MAIHBFHEECO, bool FALNJPINGNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x85A0040", Offset = "0x859E640", VA = "0x1885A0040")]
	private static GameObject JJIOKJIAEAH(GameObject EEGMKGNBEOE, NEIKMBGDPOI MHCCEBNBPPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x859FF30", Offset = "0x859E530", VA = "0x18859FF30")]
	private static void JFNBFNGEECC(GameObject KDNOBMEOLJE, RRNetworkView MLCJICFBOOE, [In] NEIKMBGDPOI MHCCEBNBPPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x859E6A0", Offset = "0x859CCA0", VA = "0x18859E6A0")]
	private GameObject[] HKGFELOLFCP(IList<CIOENMFOBPH> FAJNOCIIJMC, bool HMFKBPJIAEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x859FA20", Offset = "0x859E020", VA = "0x18859FA20")]
	private GameObject[] IPIOPBLMBNK(NEIKMBGDPOI[] HJEHIGNFBAG, int MNAFGCEMEEM, NGPBJJLAELK LIOICDJHFAF, GameObject[] CIKEHEPDPKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x85A0900", Offset = "0x859EF00", VA = "0x1885A0900")]
	private GameObject KPADJBJFIIE([In] NEIKMBGDPOI MHCCEBNBPPI, GameObject EEGMKGNBEOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x784AA80", Offset = "0x7849080", VA = "0x18784AA80")]
	private static bool HFMPANFKCIO(bool JAKGGEGIGNK, bool GMJFEJNPLBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x859C4C0", Offset = "0x859AAC0", VA = "0x18859C4C0")]
	private void FGHAGKFDOLB(IEnumerable<GameObject> PMKNAOIONBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x859A320", Offset = "0x8598920", VA = "0x18859A320")]
	private void BPHOHEGKBDK(GameObject KDNOBMEOLJE, bool OEHBJHOPAKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x859B670", Offset = "0x8599C70", VA = "0x18859B670")]
	private static void DFDGDGDLIFB(IEnumerable<GameObject> NHFOKDHHPCK, List<(GameObject GameObject, int ParentCount)> IPHMMKFHCGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x859B510", Offset = "0x8599B10", VA = "0x18859B510")]
	private void DCABIECIECB(int IKKJDEFHNPG, int MNAFGCEMEEM, bool OEHBJHOPAKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x85A1120", Offset = "0x859F720", VA = "0x1885A1120")]
	private static int LLMLGCLDBIE(int IKKJDEFHNPG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x859BB80", Offset = "0x859A180", VA = "0x18859BB80")]
	private void DKOGLHPPPHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x85A11C0", Offset = "0x859F7C0", VA = "0x1885A11C0")]
	private void NAAOLGHLAOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x85A1710", Offset = "0x859FD10", VA = "0x1885A1710")]
	private static int ODEKDHICDNF(int CIFKNCFNHEN, bool GMJFEJNPLBI = true)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x859A070", Offset = "0x8598670", VA = "0x18859A070")]
	private static int[] BLJINLIJJEC(int DCLCJPDJFPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x859D0E0", Offset = "0x859B6E0", VA = "0x18859D0E0")]
	private static int[] FKGMDCGMIOC(int DBPGJLKPCJJ, int DCLCJPDJFPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x859F0D0", Offset = "0x859D6D0", VA = "0x18859F0D0")]
	private void IGFDBOAGOKE(NGPBJJLAELK IDACCMFAENP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x859D2F0", Offset = "0x859B8F0", VA = "0x18859D2F0")]
	private void GDJDNFEOJIJ(NGPBJJLAELK LIOICDJHFAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x85A0260", Offset = "0x859E860", VA = "0x1885A0260")]
	private void KECJJLOPBGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x859EE90", Offset = "0x859D490", VA = "0x18859EE90")]
	private void IAFJEIMGCHG(NGPBJJLAELK LIOICDJHFAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x859F110", Offset = "0x859D710", VA = "0x18859F110")]
	private static void IHBJDBAPNIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x85A1770", Offset = "0x859FD70", VA = "0x1885A1770")]
	private void OFMDOFIEIEB(int[] EFDPBLIMLOL, int BPOKAACINFL = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public PNODBHBMKOI()
	{
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class RRNetworkProfiler : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xA97AB0", Offset = "0xA960B0", VA = "0x180A97AB0")]
		public RRNetworkProfiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[ServiceLifetime(Lifetime.PhotonRoom)]
[RegisterService(typeof(IHCENCCGGAP), new string[] { "Photon" })]
public class IHCENCCGGAP : KDLLCPKJBMN, LKJPKMELKMK, JCMFLFDIOKH
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct GKOLPFNKNKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public readonly MethodInfo LOIBDPHKPOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly Func<MonoBehaviour, object> NBKFGHFMHJC;

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xC41130", Offset = "0xC3F730", VA = "0x180C41130")]
		public GKOLPFNKNKG(MethodInfo LOIBDPHKPOO, [Optional] Func<MonoBehaviour, object> NBKFGHFMHJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x78634E0", Offset = "0x7861AE0", VA = "0x1878634E0")]
		public object BNPCIHBKMHC(MonoBehaviour MILFHBCBJKE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class CEBCLPEGFMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public FieldInfo instanceAccessFromField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Func<MonoBehaviour, object> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public CEBCLPEGFMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x8588860", Offset = "0x8586E60", VA = "0x188588860")]
		internal GKOLPFNKNKG BHAMODPEGNO(MethodInfo methodInfo)
		{
			return default(GKOLPFNKNKG);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x4B22570", Offset = "0x4B20B70", VA = "0x184B22570")]
		internal object PAFHHCBIMEI(MonoBehaviour mb)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class COLAGGPDKCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Func<MonoBehaviour, object> accessor;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public COLAGGPDKCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7863FF0", Offset = "0x78625F0", VA = "0x187863FF0")]
		internal GKOLPFNKNKG OBKIPALDNCA(MethodInfo methodInfo)
		{
			return default(GKOLPFNKNKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class APKDADEMLNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Type attributeType;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public APKDADEMLNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x8587DB0", Offset = "0x85863B0", VA = "0x188587DB0")]
		internal bool FCCHCAGJDCG(MethodInfo m)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static readonly IDGHEFJHGEI FEFALLLFAGB;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static Dictionary<string, int> HCFGIKFBABG;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static List<string> KEFBFDDGMBC;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static int ANKDIMMLLND;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static readonly Stopwatch BLFENHANKFL;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static Dictionary<MethodInfo, ParameterInfo[]> KIDLEEONFFG;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly Dictionary<Type, List<GKOLPFNKNKG>> DBNCFNCIICO;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x858CC60", Offset = "0x858B260", VA = "0x18858CC60", Slot = "4")]
	public void EPMGJNHIDNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x858E590", Offset = "0x858CB90", VA = "0x18858E590", Slot = "5")]
	public void PILPLNBAOCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x858D890", Offset = "0x858BE90", VA = "0x18858D890")]
	public static bool GABHADBNBPJ(string BKCBMFPHNNL, [Out] int MDCLGEMKPPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x858CB70", Offset = "0x858B170", VA = "0x18858CB70")]
	public static bool BKKDJPHCNEK(int MDCLGEMKPPP, [Out] string BKCBMFPHNNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x858AE40", Offset = "0x8589440", VA = "0x18858AE40")]
	private void ALGHCKOECHC(CHPJIJKJKGB KJOIOABMAMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x858E220", Offset = "0x858C820", VA = "0x18858E220", Slot = "9")]
	public string JKBCBDJHCFG(CHPJIJKJKGB KJOIOABMAMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x858E6E0", Offset = "0x858CCE0", VA = "0x18858E6E0", Slot = "8")]
	public void PMBAFDFMGBJ(ViewId KBEDHBMNMBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x858D6C0", Offset = "0x858BCC0", VA = "0x18858D6C0", Slot = "6")]
	public void FFJNEAONDGD(ViewId MLCJICFBOOE, string BKCBMFPHNNL, NGPBJJLAELK LIOICDJHFAF, DIFLOFIPONG LLAMMDFPKFC, params object[] MHCCEBNBPPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x858D1B0", Offset = "0x858B7B0", VA = "0x18858D1B0", Slot = "7")]
	public void FFJNEAONDGD(ViewId MLCJICFBOOE, string BKCBMFPHNNL, MACNHJCIMEN LKEAKCADNOO, DIFLOFIPONG LLAMMDFPKFC, params object[] MHCCEBNBPPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x858D1E0", Offset = "0x858B7E0", VA = "0x18858D1E0")]
	private void FFJNEAONDGD(ViewId MLCJICFBOOE, string BKCBMFPHNNL, MACNHJCIMEN LKEAKCADNOO, NGPBJJLAELK LIOICDJHFAF, DIFLOFIPONG LLAMMDFPKFC, params object[] MHCCEBNBPPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x858B0F0", Offset = "0x85896F0", VA = "0x18858B0F0")]
	private void BHENGBIDCGF(ViewId KBEDHBMNMBE, string BKCBMFPHNNL, NGPBJJLAELK MFKMLFFHCFD, int EPEOJKACHKK, object[] ILLMINLDJKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x858E7C0", Offset = "0x858CDC0", VA = "0x18858E7C0")]
	private static void PNDMGNPILLJ(GKOLPFNKNKG GMJJMMCAFFM, MonoBehaviour FMKDLOFMKCI, object[] KGIPMLMDBBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x858E250", Offset = "0x858C850", VA = "0x18858E250")]
	private static bool NKHCGEJONGP(ParameterInfo[] ECHPMJFHOPL, Type[] LLEOLENCEAN, [Out] bool BPGHNHLECFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x858D920", Offset = "0x858BF20", VA = "0x18858D920")]
	private List<GKOLPFNKNKG> IGCNLAJIKGJ(MonoBehaviour FMKDLOFMKCI, Type OJPFKKGELGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x858D790", Offset = "0x858BD90", VA = "0x18858D790")]
	private static IEnumerable<MethodInfo> FLPIHNJLHFK(Type EHLAHNIAPLD, Type HDIPEEFBEEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x858E480", Offset = "0x858CA80", VA = "0x18858E480")]
	public static ParameterInfo[] OGODIENHNGH(MethodInfo FELFGKMAJCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public IHCENCCGGAP()
	{
	}
}
namespace RecRoom.Networking
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class RRNetworkSettings : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public const string RRNetworkSettingsFileName = "RRNetworkSettings";

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static RRNetworkSettings instance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[Tooltip("RPC name list.\nUsed as shortcut when sending calls.")]
		public List<string> RpcList;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static RRNetworkSettings Instance
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x85A3440", Offset = "0x85A1A40", VA = "0x1885A3440")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x85A33B0", Offset = "0x85A19B0", VA = "0x1885A33B0")]
		public RRNetworkSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class RRNetworkView : MonoBehaviour, FPKEBICGPLH, LIIPLKPCKPC, JMOJKNOIDJM, NFDMFLCLDKG, GKPILLDFPFO
	{
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public enum LFGOKJNPMLA
		{
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			False,
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			True_SetInSceneForRoom,
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			True_ManuallySetInPrefab
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private sealed class ICEIILOFMAL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			public int actorNumber;

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
			public ICEIILOFMAL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x858ADE0", Offset = "0x85893E0", VA = "0x18858ADE0")]
			internal bool FHCKNGGMCJG(RRNetworkView view)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static Dictionary<int, RRNetworkView> DKFFCENDPHJ;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static CHACOCKEPKK DHMNDOEAFGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[SerializeField]
		private int viewIdField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[SerializeField]
		private int instantiationIdField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private bool FNJNNHAAPOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		internal bool JPMMFCALCFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[Tooltip("By default, prefabs cannot contain hard coded values for viewIdField; singletons that need to have consistent viewIdField across clients may set this flag to disable automatic cleaning of the property viewIdField")]
		[SerializeField]
		public LFGOKJNPMLA hasExplicitViewId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private bool AGEFNKBNJEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private bool HMOPIJNNKJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int FMFHAICMKIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private bool PDCKCAILMHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int CFDFANCAFBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private NGPBJJLAELK DBPGJLKPCJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private NGPBJJLAELK GDEEEJGFGHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private bool? KFFGINCIMAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private bool GIPEECMCBAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		internal bool AFBNOPIFDEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		internal MonoBehaviour[] EKDHFKMDOAD;

		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private static readonly IDGHEFJHGEI IKDKOEJDGEA;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public ViewId JOGMBHAAFMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x85A7AC0", Offset = "0x85A60C0", VA = "0x1885A7AC0")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ViewId IEEDJAJKAAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x85A7AC0", Offset = "0x85A60C0", VA = "0x1885A7AC0", Slot = "5")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public ViewId NOCMABOLNHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x85A7AC0", Offset = "0x85A60C0", VA = "0x1885A7AC0")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int IONLHDKNMEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0xA9D650", Offset = "0xA9BC50", VA = "0x180A9D650")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0xAA1220", Offset = "0xA9F820", VA = "0x180AA1220")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int ALHFPDJJLMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xABDCC0", Offset = "0xABC2C0", VA = "0x180ABDCC0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0xEDCE80", Offset = "0xEDB480", VA = "0x180EDCE80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public ViewId LPHCIGFDKDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x85A7930", Offset = "0x85A5F30", VA = "0x1885A7930")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool IBPIAPBNIAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0xA95030", Offset = "0xA93630", VA = "0x180A95030")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0xA94FC0", Offset = "0xA935C0", VA = "0x180A94FC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool JGBCFJOKIDM
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x85A7940", Offset = "0x85A5F40", VA = "0x1885A7940")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool HLEGAHOIANM
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0xC3A790", Offset = "0xC38D90", VA = "0x180C3A790")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xC00D60", Offset = "0xBFF360", VA = "0x180C00D60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public int BEAGHPKLKJI
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0xAE5560", Offset = "0xAE3B60", VA = "0x180AE5560")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public int MMHLDDMOCJC
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x85A78D0", Offset = "0x85A5ED0", VA = "0x1885A78D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public NGPBJJLAELK DJJPDGAJAKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x85A7AD0", Offset = "0x85A60D0", VA = "0x1885A7AD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public NGPBJJLAELK DJHBFFDNIEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x85A78A0", Offset = "0x85A5EA0", VA = "0x1885A78A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public NGPBJJLAELK GOEGFMADCPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x85A78A0", Offset = "0x85A5EA0", VA = "0x1885A78A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public NGPBJJLAELK JGAIDBCPBHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x85A78A0", Offset = "0x85A5EA0", VA = "0x1885A78A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool IAMMJNIAFCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x85A7A10", Offset = "0x85A6010", VA = "0x1885A7A10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public int HEAIMEGHLDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x85A7900", Offset = "0x85A5F00", VA = "0x1885A7900")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public object[] AIAJLEOJGEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0xA95000", Offset = "0xA93600", VA = "0x180A95000")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0xA95050", Offset = "0xA93650", VA = "0x180A95050")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool DFPHIIDDLOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x85A7B00", Offset = "0x85A6100", VA = "0x1885A7B00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool GGHGAIFNPFO
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x85A7A90", Offset = "0x85A6090", VA = "0x1885A7A90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool HEKMOFNACBN
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0xEAD260", Offset = "0xEAB860", VA = "0x180EAD260")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x1010CD0", Offset = "0x100F2D0", VA = "0x181010CD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool BNBDFJENCAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0xD41F90", Offset = "0xD40590", VA = "0x180D41F90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<RRNetworkView> CNOLDNDOLFO
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x85A7740", Offset = "0x85A5D40", VA = "0x1885A7740")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x85A7CC0", Offset = "0x85A62C0", VA = "0x1885A7CC0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		private event Action<NGPBJJLAELK> IKAALECFAGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x85A40D0", Offset = "0x85A26D0", VA = "0x1885A40D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x85A4190", Offset = "0x85A2790", VA = "0x1885A4190")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		public event Action<NGPBJJLAELK> LEEMKIDGLPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x85A40D0", Offset = "0x85A26D0", VA = "0x1885A40D0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x85A4190", Offset = "0x85A2790", VA = "0x1885A4190")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		private event Action<int> IIEDOHIDCMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x85A36C0", Offset = "0x85A1CC0", VA = "0x1885A36C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x85A3770", Offset = "0x85A1D70", VA = "0x1885A3770")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		public event Action<int> OCGGLLKHECM
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x85A36C0", Offset = "0x85A1CC0", VA = "0x1885A36C0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x85A3770", Offset = "0x85A1D70", VA = "0x1885A3770")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		public event Action<RRNetworkView> PHHGHGCIGLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x85A77F0", Offset = "0x85A5DF0", VA = "0x1885A77F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x85A7D70", Offset = "0x85A6370", VA = "0x1885A7D70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		public event Action CNCIEJAIAEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x85A7690", Offset = "0x85A5C90", VA = "0x1885A7690")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x85A7C10", Offset = "0x85A6210", VA = "0x1885A7C10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x85A74C0", Offset = "0x85A5AC0", VA = "0x1885A74C0")]
		public static bool TryGetNetworkView(int KBEDHBMNMBE, [Out] RRNetworkView MLCJICFBOOE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x85A3C10", Offset = "0x85A2210", VA = "0x1885A3C10")]
		public static RRNetworkView Find(int KBEDHBMNMBE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x85A3E60", Offset = "0x85A2460", VA = "0x1885A3E60")]
		public static IEnumerable<RRNetworkView> GetCreatedAndOwnedNetworkViews(int IDKCKOGGANG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x85A3DF0", Offset = "0x85A23F0", VA = "0x1885A3DF0")]
		public static IEnumerable<RRNetworkView> GetAllNetworkViews()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x85A5920", Offset = "0x85A3F20", VA = "0x1885A5920")]
		public static bool RemoveNetworkView(RRNetworkView MLCJICFBOOE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x85A56F0", Offset = "0x85A3CF0", VA = "0x1885A56F0")]
		public static void RebuildControllCacheForAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x85A5130", Offset = "0x85A3730", VA = "0x1885A5130")]
		public static void OnPlayerJoinedRoom(NGPBJJLAELK HDOIACKLNCO, List<int> EFDPBLIMLOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x85A3FA0", Offset = "0x85A25A0", VA = "0x1885A3FA0")]
		public static RRNetworkView Get(Component OFJDOOOKCLI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x85A4000", Offset = "0x85A2600", VA = "0x1885A4000")]
		public static RRNetworkView Get(GameObject OBCFGCDDCEH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x85A4EB0", Offset = "0x85A34B0", VA = "0x1885A4EB0")]
		private void OJJPLGDEFMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x85A3B90", Offset = "0x85A2190", VA = "0x1885A3B90")]
		public bool CreatedBy(NGPBJJLAELK LIOICDJHFAF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x85A72D0", Offset = "0x85A58D0", VA = "0x1885A72D0")]
		public void TransferOwnership(int PFAJJGJJEKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x85A7270", Offset = "0x85A5870", VA = "0x1885A7270")]
		public void TransferOwnership(NGPBJJLAELK BAHHEJHMPGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x85A42A0", Offset = "0x85A28A0", VA = "0x1885A42A0", Slot = "4")]
		public void Initialize(ViewId PPKONDOIPBI, ViewId EBOELBLDJNC, Dictionary<int, object> KMJJPAEMNAD, NAPCGDBANAF DBPGJLKPCJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x85A4240", Offset = "0x85A2840", VA = "0x1885A4240")]
		public void Initialize(ViewId PPKONDOIPBI, ViewId EBOELBLDJNC, object[] BEINANJGNNJ, NAPCGDBANAF DBPGJLKPCJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x85A3660", Offset = "0x85A1C60", VA = "0x1885A3660")]
		protected internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x85A4740", Offset = "0x85A2D40", VA = "0x1885A4740")]
		private void MBIFPHPDIOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x20987B0", Offset = "0x2096DB0", VA = "0x1820987B0")]
		internal void MPCIAJBEEAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x85A4C60", Offset = "0x85A3260", VA = "0x1885A4C60", Slot = "6")]
		private void MLGGBFGKCAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x85A4060", Offset = "0x85A2660", VA = "0x1885A4060")]
		internal bool HFJPLAPGKHA(RRNetworkView HNMOMAOJDMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x85A4F90", Offset = "0x85A3590", VA = "0x1885A4F90")]
		protected internal void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x85A5470", Offset = "0x85A3A70", VA = "0x1885A5470")]
		internal void PPBECKIMNEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x85A4180", Offset = "0x85A2780", VA = "0x1885A4180")]
		private void IBFDKLOLOBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x85A4680", Offset = "0x85A2C80", VA = "0x1885A4680")]
		internal void LKGCPABGOLI(NGPBJJLAELK BAHHEJHMPGL, int PFAJJGJJEKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x85A5880", Offset = "0x85A3E80", VA = "0x1885A5880")]
		public void RebuildControllerCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x85A59A0", Offset = "0x85A3FA0", VA = "0x1885A59A0")]
		public void ResetOwnership()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x85A4420", Offset = "0x85A2A20", VA = "0x1885A4420")]
		private void JJJENDIGLGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x85A4D20", Offset = "0x85A3320", VA = "0x1885A4D20")]
		private void OEKEPAPLMML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x85A55D0", Offset = "0x85A3BD0", VA = "0x1885A55D0")]
		public void RPC(string BKCBMFPHNNL, MACNHJCIMEN LKEAKCADNOO, params object[] MHCCEBNBPPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x85A5660", Offset = "0x85A3C60", VA = "0x1885A5660")]
		public void RPC(string BKCBMFPHNNL, NGPBJJLAELK OFMAIOJLPIF, params object[] MHCCEBNBPPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x85A58D0", Offset = "0x85A3ED0", VA = "0x1885A58D0")]
		public void RefreshRpcMonoBehaviourCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x85A3820", Offset = "0x85A1E20", VA = "0x1885A3820", Slot = "8")]
		public void Bake(BECEKGEMHAB HHPFOCCGJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x85A3890", Offset = "0x85A1E90", VA = "0x1885A3890")]
		private static void CIHMKFKIPPO(NGPBJJLAELK NCBFFONBEHD, [Out] NGPBJJLAELK APPCGLLKPPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x85A4940", Offset = "0x85A2F40", VA = "0x1885A4940")]
		private static void MHMOFDHFEOC(RRNetworkView HPPGNKNPKJJ, Delegate GMJJMMCAFFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x85A4E10", Offset = "0x85A3410", VA = "0x1885A4E10")]
		private static HGNFDBOJKMF OJFEMHODDPD(RRNetworkView HPPGNKNPKJJ)
		{
			return default(HGNFDBOJKMF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x85A44C0", Offset = "0x85A2AC0", VA = "0x1885A44C0")]
		private static void LBDNDBDDIGD(RRNetworkView HPPGNKNPKJJ, Delegate GMJJMMCAFFM, NGPBJJLAELK FGGLNKHJCHE, params object[] MHCCEBNBPPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x85A45A0", Offset = "0x85A2BA0", VA = "0x1885A45A0")]
		private static void LBDNDBDDIGD(RRNetworkView HPPGNKNPKJJ, Delegate GMJJMMCAFFM, MACNHJCIMEN FGGLNKHJCHE, params object[] MHCCEBNBPPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x85A3CA0", Offset = "0x85A22A0", VA = "0x1885A3CA0")]
		private static void GGFDHPFLDBL(RRNetworkView HPPGNKNPKJJ, Delegate GMJJMMCAFFM, MACNHJCIMEN FGGLNKHJCHE, PJPFMLIMKLJ FLDNGEOMCII, params object[] MHCCEBNBPPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x85A54D0", Offset = "0x85A3AD0", VA = "0x1885A54D0")]
		public void RPCBuffered(string BKCBMFPHNNL, MACNHJCIMEN LKEAKCADNOO, PJPFMLIMKLJ LLAMMDFPKFC, params object[] MHCCEBNBPPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x85A35C0", Offset = "0x85A1BC0", VA = "0x1885A35C0")]
		private static bool ANIAFKPOKBA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x85A6080", Offset = "0x85A4680", VA = "0x1885A6080", Slot = "26")]
		public void RpcAll(NNKAGKEEMCE.DLGBMDJCHGO GMJJMMCAFFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x4010D60", Offset = "0x400F360", VA = "0x184010D60", Slot = "9")]
		public void RpcAll<T1>(NNKAGKEEMCE.NCLMJINMPEN<T1> GMJJMMCAFFM, T1 DIOAIFIFBLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x40105B0", Offset = "0x400EBB0", VA = "0x1840105B0", Slot = "10")]
		public void RpcAll<T1, T2>(NNKAGKEEMCE.IBHFHFIGKJE<T1, T2> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x4012420", Offset = "0x4010A20", VA = "0x184012420", Slot = "27")]
		public void RpcAll<T1, T2, T3>(NNKAGKEEMCE.IICPJCBCMBK<T1, T2, T3> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x40107D0", Offset = "0x400EDD0", VA = "0x1840107D0", Slot = "28")]
		public void RpcAll<T1, T2, T3, T4>(NNKAGKEEMCE.JIMABFKNHPN<T1, T2, T3, T4> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x4011440", Offset = "0x400FA40", VA = "0x184011440", Slot = "29")]
		public void RpcAll<T1, T2, T3, T4, T5>(NNKAGKEEMCE.KDPDDJEGCJK<T1, T2, T3, T4, T5> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x4012920", Offset = "0x4010F20", VA = "0x184012920", Slot = "30")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(NNKAGKEEMCE.ODDJMLCIGIP<T1, T2, T3, T4, T5, T6> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x4010EF0", Offset = "0x400F4F0", VA = "0x184010EF0", Slot = "11")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(NNKAGKEEMCE.PMDHAFIBPFB<T1, T2, T3, T4, T5, T6, T7> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x4016F00", Offset = "0x4015500", VA = "0x184016F00", Slot = "12")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(NNKAGKEEMCE.IBINCFJGDLA<T1, T2, T3, T4, T5, T6, T7, T8> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x4012DD0", Offset = "0x40113D0", VA = "0x184012DD0", Slot = "31")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(NNKAGKEEMCE.CCMFADAJMBF<T1, T2, T3, T4, T5, T6, T7, T8, T9> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x402DDF0", Offset = "0x402C3F0", VA = "0x18402DDF0", Slot = "13")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(PHOMKNDGLGI GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x4030FB0", Offset = "0x402F5B0", VA = "0x184030FB0", Slot = "32")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(CBCLHJIIFEN GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL, T11 MJACEOOCDOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x4030450", Offset = "0x402EA50", VA = "0x184030450", Slot = "33")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(ILCKMLFIJAP GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL, T11 MJACEOOCDOH, T12 MDJMDAKMAFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x402F810", Offset = "0x402DE10", VA = "0x18402F810", Slot = "34")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(ICKJBDGICPO GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL, T11 MJACEOOCDOH, T12 MDJMDAKMAFA, T13 GLKADJBODOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x402D500", Offset = "0x402BB00", VA = "0x18402D500", Slot = "35")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(CPHLKHGEELE GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL, T11 MJACEOOCDOH, T12 MDJMDAKMAFA, T13 GLKADJBODOD, T14 ACFEIDEILLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x85A5E50", Offset = "0x85A4450", VA = "0x1885A5E50", Slot = "36")]
		public void RpcAll(NNKAGKEEMCE.NCLMJINMPEN<HGNFDBOJKMF> GMJJMMCAFFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x4014FF0", Offset = "0x40135F0", VA = "0x184014FF0", Slot = "37")]
		public void RpcAll<T1>(NNKAGKEEMCE.IBHFHFIGKJE<T1, HGNFDBOJKMF> GMJJMMCAFFM, T1 DIOAIFIFBLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x40158B0", Offset = "0x4013EB0", VA = "0x1840158B0", Slot = "38")]
		public void RpcAll<T1, T2>(NNKAGKEEMCE.IICPJCBCMBK<T1, T2, HGNFDBOJKMF> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x4011AB0", Offset = "0x40100B0", VA = "0x184011AB0", Slot = "39")]
		public void RpcAll<T1, T2, T3>(NNKAGKEEMCE.JIMABFKNHPN<T1, T2, T3, HGNFDBOJKMF> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x401C260", Offset = "0x401A860", VA = "0x18401C260", Slot = "40")]
		public void RpcAll<T1, T2, T3, T4>(NNKAGKEEMCE.KDPDDJEGCJK<T1, T2, T3, T4, HGNFDBOJKMF> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x401BCF0", Offset = "0x401A2F0", VA = "0x18401BCF0", Slot = "41")]
		public void RpcAll<T1, T2, T3, T4, T5>(NNKAGKEEMCE.ODDJMLCIGIP<T1, T2, T3, T4, T5, HGNFDBOJKMF> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x401B6B0", Offset = "0x4019CB0", VA = "0x18401B6B0", Slot = "42")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(NNKAGKEEMCE.PMDHAFIBPFB<T1, T2, T3, T4, T5, T6, HGNFDBOJKMF> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x401AFC0", Offset = "0x40195C0", VA = "0x18401AFC0", Slot = "43")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(NNKAGKEEMCE.IBINCFJGDLA<T1, T2, T3, T4, T5, T6, T7, HGNFDBOJKMF> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x401A810", Offset = "0x4018E10", VA = "0x18401A810", Slot = "44")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(NNKAGKEEMCE.CCMFADAJMBF<T1, T2, T3, T4, T5, T6, T7, T8, HGNFDBOJKMF> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x4032830", Offset = "0x4030E30", VA = "0x184032830", Slot = "45")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(PHOMKNDGLGI GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x4031EE0", Offset = "0x40304E0", VA = "0x184031EE0", Slot = "46")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(CBCLHJIIFEN GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x40314C0", Offset = "0x402FAC0", VA = "0x1840314C0", Slot = "47")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ILCKMLFIJAP GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL, T11 MJACEOOCDOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x40309E0", Offset = "0x402EFE0", VA = "0x1840309E0", Slot = "48")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(ICKJBDGICPO GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL, T11 MJACEOOCDOH, T12 MDJMDAKMAFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x402FE10", Offset = "0x402E410", VA = "0x18402FE10", Slot = "49")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(CPHLKHGEELE GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL, T11 MJACEOOCDOH, T12 MDJMDAKMAFA, T13 GLKADJBODOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x402F160", Offset = "0x402D760", VA = "0x18402F160", Slot = "50")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(PPMPOGPDMFO GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL, T11 MJACEOOCDOH, T12 MDJMDAKMAFA, T13 GLKADJBODOD, T14 ACFEIDEILLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x85A5D20", Offset = "0x85A4320", VA = "0x1885A5D20", Slot = "51")]
		public void RpcAllViaServer(NNKAGKEEMCE.DLGBMDJCHGO GMJJMMCAFFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x402D3F0", Offset = "0x402B9F0", VA = "0x18402D3F0", Slot = "52")]
		public void RpcAllViaServer<T1>(NNKAGKEEMCE.NCLMJINMPEN<T1> GMJJMMCAFFM, T1 DIOAIFIFBLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x4027950", Offset = "0x4025F50", VA = "0x184027950", Slot = "14")]
		public void RpcAllViaServer<T1, T2>(NNKAGKEEMCE.IBHFHFIGKJE<T1, T2> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x402CE70", Offset = "0x402B470", VA = "0x18402CE70", Slot = "53")]
		public void RpcAllViaServer<T1, T2, T3>(NNKAGKEEMCE.IICPJCBCMBK<T1, T2, T3> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x402CAB0", Offset = "0x402B0B0", VA = "0x18402CAB0", Slot = "54")]
		public void RpcAllViaServer<T1, T2, T3, T4>(NNKAGKEEMCE.JIMABFKNHPN<T1, T2, T3, T4> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x402C640", Offset = "0x402AC40", VA = "0x18402C640", Slot = "55")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(NNKAGKEEMCE.KDPDDJEGCJK<T1, T2, T3, T4, T5> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x402BE80", Offset = "0x402A480", VA = "0x18402BE80", Slot = "56")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(NNKAGKEEMCE.ODDJMLCIGIP<T1, T2, T3, T4, T5, T6> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x402BB80", Offset = "0x402A180", VA = "0x18402BB80", Slot = "57")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(NNKAGKEEMCE.PMDHAFIBPFB<T1, T2, T3, T4, T5, T6, T7> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x402B530", Offset = "0x4029B30", VA = "0x18402B530", Slot = "58")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(NNKAGKEEMCE.IBINCFJGDLA<T1, T2, T3, T4, T5, T6, T7, T8> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x402AE40", Offset = "0x4029440", VA = "0x18402AE40", Slot = "59")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(NNKAGKEEMCE.CCMFADAJMBF<T1, T2, T3, T4, T5, T6, T7, T8, T9> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x402A6B0", Offset = "0x4028CB0", VA = "0x18402A6B0", Slot = "60")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(PHOMKNDGLGI GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x4029E80", Offset = "0x4028480", VA = "0x184029E80", Slot = "61")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(CBCLHJIIFEN GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL, T11 MJACEOOCDOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x40295B0", Offset = "0x4027BB0", VA = "0x1840295B0", Slot = "62")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(ILCKMLFIJAP GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL, T11 MJACEOOCDOH, T12 MDJMDAKMAFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x4028C30", Offset = "0x4027230", VA = "0x184028C30", Slot = "63")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(ICKJBDGICPO GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL, T11 MJACEOOCDOH, T12 MDJMDAKMAFA, T13 GLKADJBODOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x4028200", Offset = "0x4026800", VA = "0x184028200", Slot = "64")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(CPHLKHGEELE GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL, T11 MJACEOOCDOH, T12 MDJMDAKMAFA, T13 GLKADJBODOD, T14 ACFEIDEILLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x85A5BF0", Offset = "0x85A41F0", VA = "0x1885A5BF0", Slot = "65")]
		public void RpcAllViaServer(NNKAGKEEMCE.NCLMJINMPEN<HGNFDBOJKMF> GMJJMMCAFFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x402D2E0", Offset = "0x402B8E0", VA = "0x18402D2E0", Slot = "66")]
		public void RpcAllViaServer<T1>(NNKAGKEEMCE.IBHFHFIGKJE<T1, HGNFDBOJKMF> GMJJMMCAFFM, T1 DIOAIFIFBLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x402D020", Offset = "0x402B620", VA = "0x18402D020", Slot = "67")]
		public void RpcAllViaServer<T1, T2>(NNKAGKEEMCE.IICPJCBCMBK<T1, T2, HGNFDBOJKMF> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x402CCC0", Offset = "0x402B2C0", VA = "0x18402CCC0", Slot = "68")]
		public void RpcAllViaServer<T1, T2, T3>(NNKAGKEEMCE.JIMABFKNHPN<T1, T2, T3, HGNFDBOJKMF> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x402C8A0", Offset = "0x402AEA0", VA = "0x18402C8A0", Slot = "69")]
		public void RpcAllViaServer<T1, T2, T3, T4>(NNKAGKEEMCE.KDPDDJEGCJK<T1, T2, T3, T4, HGNFDBOJKMF> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x402C3E0", Offset = "0x402A9E0", VA = "0x18402C3E0", Slot = "70")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(NNKAGKEEMCE.ODDJMLCIGIP<T1, T2, T3, T4, T5, HGNFDBOJKMF> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x402C130", Offset = "0x402A730", VA = "0x18402C130", Slot = "71")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(NNKAGKEEMCE.PMDHAFIBPFB<T1, T2, T3, T4, T5, T6, HGNFDBOJKMF> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x402B880", Offset = "0x4029E80", VA = "0x18402B880", Slot = "72")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(NNKAGKEEMCE.IBINCFJGDLA<T1, T2, T3, T4, T5, T6, T7, HGNFDBOJKMF> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x402B1E0", Offset = "0x40297E0", VA = "0x18402B1E0", Slot = "73")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(NNKAGKEEMCE.CCMFADAJMBF<T1, T2, T3, T4, T5, T6, T7, T8, HGNFDBOJKMF> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x402AAA0", Offset = "0x40290A0", VA = "0x18402AAA0", Slot = "74")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(PHOMKNDGLGI GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x402A2C0", Offset = "0x40288C0", VA = "0x18402A2C0", Slot = "75")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(CBCLHJIIFEN GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x4029A40", Offset = "0x4028040", VA = "0x184029A40", Slot = "76")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ILCKMLFIJAP GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL, T11 MJACEOOCDOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x4029120", Offset = "0x4027720", VA = "0x184029120", Slot = "77")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(ICKJBDGICPO GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL, T11 MJACEOOCDOH, T12 MDJMDAKMAFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x4028740", Offset = "0x4026D40", VA = "0x184028740", Slot = "78")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(CPHLKHGEELE GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL, T11 MJACEOOCDOH, T12 MDJMDAKMAFA, T13 GLKADJBODOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x4027CC0", Offset = "0x40262C0", VA = "0x184027CC0", Slot = "79")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(PPMPOGPDMFO GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL, T11 MJACEOOCDOH, T12 MDJMDAKMAFA, T13 GLKADJBODOD, T14 ACFEIDEILLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x85A6B10", Offset = "0x85A5110", VA = "0x1885A6B10", Slot = "80")]
		public void RpcOthers(NNKAGKEEMCE.DLGBMDJCHGO GMJJMMCAFFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x40510E0", Offset = "0x404F6E0", VA = "0x1840510E0", Slot = "15")]
		public void RpcOthers<T1>(NNKAGKEEMCE.NCLMJINMPEN<T1> GMJJMMCAFFM, T1 DIOAIFIFBLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x40519E0", Offset = "0x404FFE0", VA = "0x1840519E0", Slot = "81")]
		public void RpcOthers<T1, T2>(NNKAGKEEMCE.IBHFHFIGKJE<T1, T2> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x4050E60", Offset = "0x404F460", VA = "0x184050E60", Slot = "82")]
		public void RpcOthers<T1, T2, T3>(NNKAGKEEMCE.IICPJCBCMBK<T1, T2, T3> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x4057540", Offset = "0x4055B40", VA = "0x184057540", Slot = "83")]
		public void RpcOthers<T1, T2, T3, T4>(NNKAGKEEMCE.JIMABFKNHPN<T1, T2, T3, T4> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x4057090", Offset = "0x4055690", VA = "0x184057090", Slot = "84")]
		public void RpcOthers<T1, T2, T3, T4, T5>(NNKAGKEEMCE.KDPDDJEGCJK<T1, T2, T3, T4, T5> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x4052790", Offset = "0x4050D90", VA = "0x184052790", Slot = "85")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(NNKAGKEEMCE.ODDJMLCIGIP<T1, T2, T3, T4, T5, T6> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x4056550", Offset = "0x4054B50", VA = "0x184056550", Slot = "86")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(NNKAGKEEMCE.PMDHAFIBPFB<T1, T2, T3, T4, T5, T6, T7> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x4055B50", Offset = "0x4054150", VA = "0x184055B50", Slot = "87")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(NNKAGKEEMCE.IBINCFJGDLA<T1, T2, T3, T4, T5, T6, T7, T8> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x40553D0", Offset = "0x40539D0", VA = "0x1840553D0", Slot = "88")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(NNKAGKEEMCE.CCMFADAJMBF<T1, T2, T3, T4, T5, T6, T7, T8, T9> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x4054FC0", Offset = "0x40535C0", VA = "0x184054FC0", Slot = "16")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(PHOMKNDGLGI GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x4054750", Offset = "0x4052D50", VA = "0x184054750", Slot = "89")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(CBCLHJIIFEN GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL, T11 MJACEOOCDOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x4053970", Offset = "0x4051F70", VA = "0x184053970", Slot = "90")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(ILCKMLFIJAP GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL, T11 MJACEOOCDOH, T12 MDJMDAKMAFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x4053460", Offset = "0x4051A60", VA = "0x184053460", Slot = "91")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(ICKJBDGICPO GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL, T11 MJACEOOCDOH, T12 MDJMDAKMAFA, T13 GLKADJBODOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x405EFB0", Offset = "0x405D5B0", VA = "0x18405EFB0", Slot = "92")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(CPHLKHGEELE GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL, T11 MJACEOOCDOH, T12 MDJMDAKMAFA, T13 GLKADJBODOD, T14 ACFEIDEILLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x85A6C60", Offset = "0x85A5260", VA = "0x1885A6C60", Slot = "93")]
		public void RpcOthers(NNKAGKEEMCE.NCLMJINMPEN<HGNFDBOJKMF> GMJJMMCAFFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x4051720", Offset = "0x404FD20", VA = "0x184051720", Slot = "94")]
		public void RpcOthers<T1>(NNKAGKEEMCE.IBHFHFIGKJE<T1, HGNFDBOJKMF> GMJJMMCAFFM, T1 DIOAIFIFBLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x4051530", Offset = "0x404FB30", VA = "0x184051530", Slot = "95")]
		public void RpcOthers<T1, T2>(NNKAGKEEMCE.IICPJCBCMBK<T1, T2, HGNFDBOJKMF> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x4058150", Offset = "0x4056750", VA = "0x184058150", Slot = "96")]
		public void RpcOthers<T1, T2, T3>(NNKAGKEEMCE.JIMABFKNHPN<T1, T2, T3, HGNFDBOJKMF> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x4051240", Offset = "0x404F840", VA = "0x184051240", Slot = "97")]
		public void RpcOthers<T1, T2, T3, T4>(NNKAGKEEMCE.KDPDDJEGCJK<T1, T2, T3, T4, HGNFDBOJKMF> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x4051EF0", Offset = "0x40504F0", VA = "0x184051EF0", Slot = "98")]
		public void RpcOthers<T1, T2, T3, T4, T5>(NNKAGKEEMCE.ODDJMLCIGIP<T1, T2, T3, T4, T5, HGNFDBOJKMF> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x4052240", Offset = "0x4050840", VA = "0x184052240", Slot = "99")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(NNKAGKEEMCE.PMDHAFIBPFB<T1, T2, T3, T4, T5, T6, HGNFDBOJKMF> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x4056230", Offset = "0x4054830", VA = "0x184056230", Slot = "100")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(NNKAGKEEMCE.IBINCFJGDLA<T1, T2, T3, T4, T5, T6, T7, HGNFDBOJKMF> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x4055EC0", Offset = "0x40544C0", VA = "0x184055EC0", Slot = "101")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(NNKAGKEEMCE.CCMFADAJMBF<T1, T2, T3, T4, T5, T6, T7, T8, HGNFDBOJKMF> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x4055790", Offset = "0x4053D90", VA = "0x184055790", Slot = "102")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(PHOMKNDGLGI GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x4054BB0", Offset = "0x40531B0", VA = "0x184054BB0", Slot = "103")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(CBCLHJIIFEN GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x40542F0", Offset = "0x40528F0", VA = "0x1840542F0", Slot = "104")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ILCKMLFIJAP GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL, T11 MJACEOOCDOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x4053E30", Offset = "0x4052430", VA = "0x184053E30", Slot = "105")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(ICKJBDGICPO GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL, T11 MJACEOOCDOH, T12 MDJMDAKMAFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x4052F50", Offset = "0x4051550", VA = "0x184052F50", Slot = "106")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(CPHLKHGEELE GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL, T11 MJACEOOCDOH, T12 MDJMDAKMAFA, T13 GLKADJBODOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x405F520", Offset = "0x405DB20", VA = "0x18405F520", Slot = "107")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(PPMPOGPDMFO GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL, T11 MJACEOOCDOH, T12 MDJMDAKMAFA, T13 GLKADJBODOD, T14 ACFEIDEILLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x85A6840", Offset = "0x85A4E40", VA = "0x1885A6840", Slot = "108")]
		public void RpcMaster(NNKAGKEEMCE.DLGBMDJCHGO GMJJMMCAFFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x4040F20", Offset = "0x403F520", VA = "0x184040F20", Slot = "109")]
		public void RpcMaster<T1>(NNKAGKEEMCE.NCLMJINMPEN<T1> GMJJMMCAFFM, T1 DIOAIFIFBLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x40410D0", Offset = "0x403F6D0", VA = "0x1840410D0", Slot = "17")]
		public void RpcMaster<T1, T2>(NNKAGKEEMCE.IBHFHFIGKJE<T1, T2> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x4040A50", Offset = "0x403F050", VA = "0x184040A50", Slot = "110")]
		public void RpcMaster<T1, T2, T3>(NNKAGKEEMCE.IICPJCBCMBK<T1, T2, T3> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x40406F0", Offset = "0x403ECF0", VA = "0x1840406F0", Slot = "111")]
		public void RpcMaster<T1, T2, T3, T4>(NNKAGKEEMCE.JIMABFKNHPN<T1, T2, T3, T4> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x40447B0", Offset = "0x4042DB0", VA = "0x1840447B0", Slot = "112")]
		public void RpcMaster<T1, T2, T3, T4, T5>(NNKAGKEEMCE.KDPDDJEGCJK<T1, T2, T3, T4, T5> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x4046C30", Offset = "0x4045230", VA = "0x184046C30", Slot = "113")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(NNKAGKEEMCE.ODDJMLCIGIP<T1, T2, T3, T4, T5, T6> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x404C9F0", Offset = "0x404AFF0", VA = "0x18404C9F0", Slot = "114")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(NNKAGKEEMCE.PMDHAFIBPFB<T1, T2, T3, T4, T5, T6, T7> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x404C5E0", Offset = "0x404ABE0", VA = "0x18404C5E0", Slot = "115")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(NNKAGKEEMCE.IBINCFJGDLA<T1, T2, T3, T4, T5, T6, T7, T8> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x404B830", Offset = "0x4049E30", VA = "0x18404B830", Slot = "116")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(NNKAGKEEMCE.CCMFADAJMBF<T1, T2, T3, T4, T5, T6, T7, T8, T9> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x4043F60", Offset = "0x4042560", VA = "0x184043F60", Slot = "117")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(PHOMKNDGLGI GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x4042B60", Offset = "0x4041160", VA = "0x184042B60", Slot = "118")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(CBCLHJIIFEN GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL, T11 MJACEOOCDOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x4049DC0", Offset = "0x40483C0", VA = "0x184049DC0", Slot = "119")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(ILCKMLFIJAP GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL, T11 MJACEOOCDOH, T12 MDJMDAKMAFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x40491D0", Offset = "0x40477D0", VA = "0x1840491D0", Slot = "120")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(ICKJBDGICPO GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL, T11 MJACEOOCDOH, T12 MDJMDAKMAFA, T13 GLKADJBODOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x4048510", Offset = "0x4046B10", VA = "0x184048510", Slot = "121")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(CPHLKHGEELE GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL, T11 MJACEOOCDOH, T12 MDJMDAKMAFA, T13 GLKADJBODOD, T14 ACFEIDEILLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x85A6600", Offset = "0x85A4C00", VA = "0x1885A6600", Slot = "122")]
		public void RpcMaster(NNKAGKEEMCE.NCLMJINMPEN<HGNFDBOJKMF> GMJJMMCAFFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x4040D20", Offset = "0x403F320", VA = "0x184040D20", Slot = "123")]
		public void RpcMaster<T1>(NNKAGKEEMCE.IBHFHFIGKJE<T1, HGNFDBOJKMF> GMJJMMCAFFM, T1 DIOAIFIFBLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x4041D70", Offset = "0x4040370", VA = "0x184041D70", Slot = "124")]
		public void RpcMaster<T1, T2>(NNKAGKEEMCE.IICPJCBCMBK<T1, T2, HGNFDBOJKMF> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x4041320", Offset = "0x403F920", VA = "0x184041320", Slot = "125")]
		public void RpcMaster<T1, T2, T3>(NNKAGKEEMCE.JIMABFKNHPN<T1, T2, T3, HGNFDBOJKMF> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x404DEF0", Offset = "0x404C4F0", VA = "0x18404DEF0", Slot = "126")]
		public void RpcMaster<T1, T2, T3, T4>(NNKAGKEEMCE.KDPDDJEGCJK<T1, T2, T3, T4, HGNFDBOJKMF> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x40451F0", Offset = "0x40437F0", VA = "0x1840451F0", Slot = "127")]
		public void RpcMaster<T1, T2, T3, T4, T5>(NNKAGKEEMCE.ODDJMLCIGIP<T1, T2, T3, T4, T5, HGNFDBOJKMF> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x404D1B0", Offset = "0x404B7B0", VA = "0x18404D1B0", Slot = "128")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(NNKAGKEEMCE.PMDHAFIBPFB<T1, T2, T3, T4, T5, T6, HGNFDBOJKMF> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x404CDB0", Offset = "0x404B3B0", VA = "0x18404CDB0", Slot = "129")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(NNKAGKEEMCE.IBINCFJGDLA<T1, T2, T3, T4, T5, T6, T7, HGNFDBOJKMF> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x404C170", Offset = "0x404A770", VA = "0x18404C170", Slot = "130")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(NNKAGKEEMCE.CCMFADAJMBF<T1, T2, T3, T4, T5, T6, T7, T8, HGNFDBOJKMF> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x404BCA0", Offset = "0x404A2A0", VA = "0x18404BCA0", Slot = "131")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(PHOMKNDGLGI GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x404B300", Offset = "0x4049900", VA = "0x18404B300", Slot = "132")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(CBCLHJIIFEN GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x404A8A0", Offset = "0x4048EA0", VA = "0x18404A8A0", Slot = "133")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ILCKMLFIJAP GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL, T11 MJACEOOCDOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x40497D0", Offset = "0x4047DD0", VA = "0x1840497D0", Slot = "134")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(ICKJBDGICPO GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL, T11 MJACEOOCDOH, T12 MDJMDAKMAFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x4048B80", Offset = "0x4047180", VA = "0x184048B80", Slot = "135")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(CPHLKHGEELE GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL, T11 MJACEOOCDOH, T12 MDJMDAKMAFA, T13 GLKADJBODOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x4047E50", Offset = "0x4046450", VA = "0x184047E50", Slot = "136")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(PPMPOGPDMFO GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL, T11 MJACEOOCDOH, T12 MDJMDAKMAFA, T13 GLKADJBODOD, T14 ACFEIDEILLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x85A61F0", Offset = "0x85A47F0", VA = "0x1885A61F0", Slot = "137")]
		public void RpcAuthority(NNKAGKEEMCE.DLGBMDJCHGO GMJJMMCAFFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x40343D0", Offset = "0x40329D0", VA = "0x1840343D0", Slot = "138")]
		public void RpcAuthority<T1>(NNKAGKEEMCE.NCLMJINMPEN<T1> GMJJMMCAFFM, T1 DIOAIFIFBLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x4035CE0", Offset = "0x40342E0", VA = "0x184035CE0", Slot = "139")]
		public void RpcAuthority<T1, T2>(NNKAGKEEMCE.IBHFHFIGKJE<T1, T2> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x4036490", Offset = "0x4034A90", VA = "0x184036490", Slot = "140")]
		public void RpcAuthority<T1, T2, T3>(NNKAGKEEMCE.IICPJCBCMBK<T1, T2, T3> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x40359A0", Offset = "0x4033FA0", VA = "0x1840359A0", Slot = "141")]
		public void RpcAuthority<T1, T2, T3, T4>(NNKAGKEEMCE.JIMABFKNHPN<T1, T2, T3, T4> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x4033FC0", Offset = "0x40325C0", VA = "0x184033FC0", Slot = "142")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(NNKAGKEEMCE.KDPDDJEGCJK<T1, T2, T3, T4, T5> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x403C570", Offset = "0x403AB70", VA = "0x18403C570", Slot = "143")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(NNKAGKEEMCE.ODDJMLCIGIP<T1, T2, T3, T4, T5, T6> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x403BDE0", Offset = "0x403A3E0", VA = "0x18403BDE0", Slot = "144")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(NNKAGKEEMCE.PMDHAFIBPFB<T1, T2, T3, T4, T5, T6, T7> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x403B590", Offset = "0x4039B90", VA = "0x18403B590", Slot = "145")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(NNKAGKEEMCE.IBINCFJGDLA<T1, T2, T3, T4, T5, T6, T7, T8> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x403AC80", Offset = "0x4039280", VA = "0x18403AC80", Slot = "146")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(NNKAGKEEMCE.CCMFADAJMBF<T1, T2, T3, T4, T5, T6, T7, T8, T9> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x4039D70", Offset = "0x4038370", VA = "0x184039D70", Slot = "147")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(PHOMKNDGLGI GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x4039280", Offset = "0x4037880", VA = "0x184039280", Slot = "148")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(CBCLHJIIFEN GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL, T11 MJACEOOCDOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x4034590", Offset = "0x4032B90", VA = "0x184034590", Slot = "149")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(ILCKMLFIJAP GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL, T11 MJACEOOCDOH, T12 MDJMDAKMAFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x4037A50", Offset = "0x4036050", VA = "0x184037A50", Slot = "150")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(ICKJBDGICPO GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL, T11 MJACEOOCDOH, T12 MDJMDAKMAFA, T13 GLKADJBODOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x4036D00", Offset = "0x4035300", VA = "0x184036D00", Slot = "151")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(CPHLKHGEELE GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL, T11 MJACEOOCDOH, T12 MDJMDAKMAFA, T13 GLKADJBODOD, T14 ACFEIDEILLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x85A63A0", Offset = "0x85A49A0", VA = "0x1885A63A0", Slot = "152")]
		public void RpcAuthority(NNKAGKEEMCE.NCLMJINMPEN<HGNFDBOJKMF> GMJJMMCAFFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x403E980", Offset = "0x403CF80", VA = "0x18403E980", Slot = "153")]
		public void RpcAuthority<T1>(NNKAGKEEMCE.IBHFHFIGKJE<T1, HGNFDBOJKMF> GMJJMMCAFFM, T1 DIOAIFIFBLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x403DC30", Offset = "0x403C230", VA = "0x18403DC30", Slot = "154")]
		public void RpcAuthority<T1, T2>(NNKAGKEEMCE.IICPJCBCMBK<T1, T2, HGNFDBOJKMF> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x403D4E0", Offset = "0x403BAE0", VA = "0x18403D4E0", Slot = "155")]
		public void RpcAuthority<T1, T2, T3>(NNKAGKEEMCE.JIMABFKNHPN<T1, T2, T3, HGNFDBOJKMF> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x403CF40", Offset = "0x403B540", VA = "0x18403CF40", Slot = "156")]
		public void RpcAuthority<T1, T2, T3, T4>(NNKAGKEEMCE.KDPDDJEGCJK<T1, T2, T3, T4, HGNFDBOJKMF> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x403CBE0", Offset = "0x403B1E0", VA = "0x18403CBE0", Slot = "157")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(NNKAGKEEMCE.ODDJMLCIGIP<T1, T2, T3, T4, T5, HGNFDBOJKMF> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x403C1B0", Offset = "0x403A7B0", VA = "0x18403C1B0", Slot = "158")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(NNKAGKEEMCE.PMDHAFIBPFB<T1, T2, T3, T4, T5, T6, HGNFDBOJKMF> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x403B9C0", Offset = "0x4039FC0", VA = "0x18403B9C0", Slot = "159")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(NNKAGKEEMCE.IBINCFJGDLA<T1, T2, T3, T4, T5, T6, T7, HGNFDBOJKMF> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x403B110", Offset = "0x4039710", VA = "0x18403B110", Slot = "160")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(NNKAGKEEMCE.CCMFADAJMBF<T1, T2, T3, T4, T5, T6, T7, T8, HGNFDBOJKMF> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x403A7A0", Offset = "0x4038DA0", VA = "0x18403A7A0", Slot = "161")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(PHOMKNDGLGI GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x403A260", Offset = "0x4038860", VA = "0x18403A260", Slot = "162")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(CBCLHJIIFEN GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x40397D0", Offset = "0x4037DD0", VA = "0x1840397D0", Slot = "163")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ILCKMLFIJAP GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL, T11 MJACEOOCDOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x40386D0", Offset = "0x4036CD0", VA = "0x1840386D0", Slot = "164")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(ICKJBDGICPO GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL, T11 MJACEOOCDOH, T12 MDJMDAKMAFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x4038070", Offset = "0x4036670", VA = "0x184038070", Slot = "165")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(CPHLKHGEELE GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL, T11 MJACEOOCDOH, T12 MDJMDAKMAFA, T13 GLKADJBODOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x4037380", Offset = "0x4035980", VA = "0x184037380", Slot = "166")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(PPMPOGPDMFO GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL, T11 MJACEOOCDOH, T12 MDJMDAKMAFA, T13 GLKADJBODOD, T14 ACFEIDEILLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x85A6DB0", Offset = "0x85A53B0", VA = "0x1885A6DB0", Slot = "18")]
		public void RpcPlayer(NGPBJJLAELK LIOICDJHFAF, NNKAGKEEMCE.DLGBMDJCHGO GMJJMMCAFFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x405FA90", Offset = "0x405E090", VA = "0x18405FA90", Slot = "19")]
		public void RpcPlayer<T1>(NGPBJJLAELK LIOICDJHFAF, NNKAGKEEMCE.NCLMJINMPEN<T1> GMJJMMCAFFM, T1 DIOAIFIFBLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x40609F0", Offset = "0x405EFF0", VA = "0x1840609F0", Slot = "20")]
		public void RpcPlayer<T1, T2>(NGPBJJLAELK LIOICDJHFAF, NNKAGKEEMCE.IBHFHFIGKJE<T1, T2> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x4060400", Offset = "0x405EA00", VA = "0x184060400", Slot = "21")]
		public void RpcPlayer<T1, T2, T3>(NGPBJJLAELK LIOICDJHFAF, NNKAGKEEMCE.IICPJCBCMBK<T1, T2, T3> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x405FC60", Offset = "0x405E260", VA = "0x18405FC60", Slot = "22")]
		public void RpcPlayer<T1, T2, T3, T4>(NGPBJJLAELK LIOICDJHFAF, NNKAGKEEMCE.JIMABFKNHPN<T1, T2, T3, T4> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x4064530", Offset = "0x4062B30", VA = "0x184064530", Slot = "167")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(NGPBJJLAELK LIOICDJHFAF, NNKAGKEEMCE.KDPDDJEGCJK<T1, T2, T3, T4, T5> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x40640C0", Offset = "0x40626C0", VA = "0x1840640C0", Slot = "168")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(NGPBJJLAELK LIOICDJHFAF, NNKAGKEEMCE.ODDJMLCIGIP<T1, T2, T3, T4, T5, T6> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x4064920", Offset = "0x4062F20", VA = "0x184064920", Slot = "169")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(NGPBJJLAELK LIOICDJHFAF, NNKAGKEEMCE.PMDHAFIBPFB<T1, T2, T3, T4, T5, T6, T7> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x4064DF0", Offset = "0x40633F0", VA = "0x184064DF0", Slot = "170")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(NGPBJJLAELK LIOICDJHFAF, NNKAGKEEMCE.IBINCFJGDLA<T1, T2, T3, T4, T5, T6, T7, T8> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x406B4C0", Offset = "0x4069AC0", VA = "0x18406B4C0", Slot = "171")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(NGPBJJLAELK LIOICDJHFAF, NNKAGKEEMCE.CCMFADAJMBF<T1, T2, T3, T4, T5, T6, T7, T8, T9> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x406A580", Offset = "0x4068B80", VA = "0x18406A580", Slot = "172")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(NGPBJJLAELK LIOICDJHFAF, PHOMKNDGLGI GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x40612E0", Offset = "0x405F8E0", VA = "0x1840612E0", Slot = "23")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(NGPBJJLAELK LIOICDJHFAF, CBCLHJIIFEN GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL, T11 MJACEOOCDOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x40694B0", Offset = "0x4067AB0", VA = "0x1840694B0", Slot = "173")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(NGPBJJLAELK LIOICDJHFAF, ILCKMLFIJAP GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL, T11 MJACEOOCDOH, T12 MDJMDAKMAFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x40681E0", Offset = "0x40667E0", VA = "0x1840681E0", Slot = "174")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(NGPBJJLAELK LIOICDJHFAF, ICKJBDGICPO GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL, T11 MJACEOOCDOH, T12 MDJMDAKMAFA, T13 GLKADJBODOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x4067B50", Offset = "0x4066150", VA = "0x184067B50", Slot = "175")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(NGPBJJLAELK LIOICDJHFAF, CPHLKHGEELE GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL, T11 MJACEOOCDOH, T12 MDJMDAKMAFA, T13 GLKADJBODOD, T14 ACFEIDEILLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x85A6FB0", Offset = "0x85A55B0", VA = "0x1885A6FB0", Slot = "176")]
		public void RpcPlayer(NGPBJJLAELK LIOICDJHFAF, NNKAGKEEMCE.NCLMJINMPEN<HGNFDBOJKMF> GMJJMMCAFFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x4060000", Offset = "0x405E600", VA = "0x184060000", Slot = "177")]
		public void RpcPlayer<T1>(NGPBJJLAELK LIOICDJHFAF, NNKAGKEEMCE.IBHFHFIGKJE<T1, HGNFDBOJKMF> GMJJMMCAFFM, T1 DIOAIFIFBLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x4060FF0", Offset = "0x405F5F0", VA = "0x184060FF0", Slot = "24")]
		public void RpcPlayer<T1, T2>(NGPBJJLAELK LIOICDJHFAF, NNKAGKEEMCE.IICPJCBCMBK<T1, T2, HGNFDBOJKMF> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x4060C70", Offset = "0x405F270", VA = "0x184060C70", Slot = "25")]
		public void RpcPlayer<T1, T2, T3>(NGPBJJLAELK LIOICDJHFAF, NNKAGKEEMCE.JIMABFKNHPN<T1, T2, T3, HGNFDBOJKMF> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x4062B30", Offset = "0x4061130", VA = "0x184062B30", Slot = "178")]
		public void RpcPlayer<T1, T2, T3, T4>(NGPBJJLAELK LIOICDJHFAF, NNKAGKEEMCE.KDPDDJEGCJK<T1, T2, T3, T4, HGNFDBOJKMF> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x406D470", Offset = "0x406BA70", VA = "0x18406D470", Slot = "179")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(NGPBJJLAELK LIOICDJHFAF, NNKAGKEEMCE.ODDJMLCIGIP<T1, T2, T3, T4, T5, HGNFDBOJKMF> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x406CD90", Offset = "0x406B390", VA = "0x18406CD90", Slot = "180")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(NGPBJJLAELK LIOICDJHFAF, NNKAGKEEMCE.PMDHAFIBPFB<T1, T2, T3, T4, T5, T6, HGNFDBOJKMF> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x406C5F0", Offset = "0x406ABF0", VA = "0x18406C5F0", Slot = "181")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(NGPBJJLAELK LIOICDJHFAF, NNKAGKEEMCE.IBINCFJGDLA<T1, T2, T3, T4, T5, T6, T7, HGNFDBOJKMF> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x406B960", Offset = "0x4069F60", VA = "0x18406B960", Slot = "182")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(NGPBJJLAELK LIOICDJHFAF, NNKAGKEEMCE.CCMFADAJMBF<T1, T2, T3, T4, T5, T6, T7, T8, HGNFDBOJKMF> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x406AFD0", Offset = "0x40695D0", VA = "0x18406AFD0", Slot = "183")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(NGPBJJLAELK LIOICDJHFAF, PHOMKNDGLGI GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x406AA80", Offset = "0x4069080", VA = "0x18406AA80", Slot = "184")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(NGPBJJLAELK LIOICDJHFAF, CBCLHJIIFEN GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x4069FD0", Offset = "0x40685D0", VA = "0x184069FD0", Slot = "185")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(NGPBJJLAELK LIOICDJHFAF, ILCKMLFIJAP GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL, T11 MJACEOOCDOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x4068E90", Offset = "0x4067490", VA = "0x184068E90", Slot = "186")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(NGPBJJLAELK LIOICDJHFAF, ICKJBDGICPO GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL, T11 MJACEOOCDOH, T12 MDJMDAKMAFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x4068810", Offset = "0x4066E10", VA = "0x184068810", Slot = "187")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(NGPBJJLAELK LIOICDJHFAF, CPHLKHGEELE GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL, T11 MJACEOOCDOH, T12 MDJMDAKMAFA, T13 GLKADJBODOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x4067470", Offset = "0x4065A70", VA = "0x184067470", Slot = "188")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(NGPBJJLAELK LIOICDJHFAF, PPMPOGPDMFO GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL, T11 MJACEOOCDOH, T12 MDJMDAKMAFA, T13 GLKADJBODOD, T14 ACFEIDEILLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x85A5B50", Offset = "0x85A4150", VA = "0x1885A5B50", Slot = "189")]
		public void RpcAllBuffered(PJPFMLIMKLJ LLAMMDFPKFC, NNKAGKEEMCE.DLGBMDJCHGO GMJJMMCAFFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x4027830", Offset = "0x4025E30", VA = "0x184027830", Slot = "190")]
		public void RpcAllBuffered<T1>(PJPFMLIMKLJ LLAMMDFPKFC, NNKAGKEEMCE.NCLMJINMPEN<T1> GMJJMMCAFFM, T1 DIOAIFIFBLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x40275A0", Offset = "0x4025BA0", VA = "0x1840275A0", Slot = "191")]
		public void RpcAllBuffered<T1, T2>(PJPFMLIMKLJ LLAMMDFPKFC, NNKAGKEEMCE.IBHFHFIGKJE<T1, T2> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x40270B0", Offset = "0x40256B0", VA = "0x1840270B0", Slot = "192")]
		public void RpcAllBuffered<T1, T2, T3>(PJPFMLIMKLJ LLAMMDFPKFC, NNKAGKEEMCE.IICPJCBCMBK<T1, T2, T3> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x4026C90", Offset = "0x4025290", VA = "0x184026C90", Slot = "193")]
		public void RpcAllBuffered<T1, T2, T3, T4>(PJPFMLIMKLJ LLAMMDFPKFC, NNKAGKEEMCE.JIMABFKNHPN<T1, T2, T3, T4> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x40267D0", Offset = "0x4024DD0", VA = "0x1840267D0", Slot = "194")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(PJPFMLIMKLJ LLAMMDFPKFC, NNKAGKEEMCE.KDPDDJEGCJK<T1, T2, T3, T4, T5> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x4026270", Offset = "0x4024870", VA = "0x184026270", Slot = "195")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(PJPFMLIMKLJ LLAMMDFPKFC, NNKAGKEEMCE.ODDJMLCIGIP<T1, T2, T3, T4, T5, T6> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x4025F70", Offset = "0x4024570", VA = "0x184025F70", Slot = "196")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(PJPFMLIMKLJ LLAMMDFPKFC, NNKAGKEEMCE.PMDHAFIBPFB<T1, T2, T3, T4, T5, T6, T7> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x4025910", Offset = "0x4023F10", VA = "0x184025910", Slot = "197")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(PJPFMLIMKLJ LLAMMDFPKFC, NNKAGKEEMCE.IBINCFJGDLA<T1, T2, T3, T4, T5, T6, T7, T8> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x4025200", Offset = "0x4023800", VA = "0x184025200", Slot = "198")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(PJPFMLIMKLJ LLAMMDFPKFC, NNKAGKEEMCE.CCMFADAJMBF<T1, T2, T3, T4, T5, T6, T7, T8, T9> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x4024A50", Offset = "0x4023050", VA = "0x184024A50", Slot = "199")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(PJPFMLIMKLJ LLAMMDFPKFC, PHOMKNDGLGI GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x4024200", Offset = "0x4022800", VA = "0x184024200", Slot = "200")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(PJPFMLIMKLJ LLAMMDFPKFC, CBCLHJIIFEN GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL, T11 MJACEOOCDOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x4023470", Offset = "0x4021A70", VA = "0x184023470", Slot = "201")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(PJPFMLIMKLJ LLAMMDFPKFC, ILCKMLFIJAP GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL, T11 MJACEOOCDOH, T12 MDJMDAKMAFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x4022F70", Offset = "0x4021570", VA = "0x184022F70", Slot = "202")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(PJPFMLIMKLJ LLAMMDFPKFC, ICKJBDGICPO GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL, T11 MJACEOOCDOH, T12 MDJMDAKMAFA, T13 GLKADJBODOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x4021FD0", Offset = "0x40205D0", VA = "0x184021FD0", Slot = "203")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(PJPFMLIMKLJ LLAMMDFPKFC, CPHLKHGEELE GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL, T11 MJACEOOCDOH, T12 MDJMDAKMAFA, T13 GLKADJBODOD, T14 ACFEIDEILLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x85A5AB0", Offset = "0x85A40B0", VA = "0x1885A5AB0", Slot = "204")]
		public void RpcAllBuffered(PJPFMLIMKLJ LLAMMDFPKFC, NNKAGKEEMCE.NCLMJINMPEN<HGNFDBOJKMF> GMJJMMCAFFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x4027710", Offset = "0x4025D10", VA = "0x184027710", Slot = "205")]
		public void RpcAllBuffered<T1>(PJPFMLIMKLJ LLAMMDFPKFC, NNKAGKEEMCE.IBHFHFIGKJE<T1, HGNFDBOJKMF> GMJJMMCAFFM, T1 DIOAIFIFBLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x4027430", Offset = "0x4025A30", VA = "0x184027430", Slot = "206")]
		public void RpcAllBuffered<T1, T2>(PJPFMLIMKLJ LLAMMDFPKFC, NNKAGKEEMCE.IICPJCBCMBK<T1, T2, HGNFDBOJKMF> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x4027270", Offset = "0x4025870", VA = "0x184027270", Slot = "207")]
		public void RpcAllBuffered<T1, T2, T3>(PJPFMLIMKLJ LLAMMDFPKFC, NNKAGKEEMCE.JIMABFKNHPN<T1, T2, T3, HGNFDBOJKMF> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x4026EA0", Offset = "0x40254A0", VA = "0x184026EA0", Slot = "208")]
		public void RpcAllBuffered<T1, T2, T3, T4>(PJPFMLIMKLJ LLAMMDFPKFC, NNKAGKEEMCE.KDPDDJEGCJK<T1, T2, T3, T4, HGNFDBOJKMF> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x4026A30", Offset = "0x4025030", VA = "0x184026A30", Slot = "209")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(PJPFMLIMKLJ LLAMMDFPKFC, NNKAGKEEMCE.ODDJMLCIGIP<T1, T2, T3, T4, T5, HGNFDBOJKMF> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x4026520", Offset = "0x4024B20", VA = "0x184026520", Slot = "210")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(PJPFMLIMKLJ LLAMMDFPKFC, NNKAGKEEMCE.PMDHAFIBPFB<T1, T2, T3, T4, T5, T6, HGNFDBOJKMF> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x4025C70", Offset = "0x4024270", VA = "0x184025C70", Slot = "211")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(PJPFMLIMKLJ LLAMMDFPKFC, NNKAGKEEMCE.IBINCFJGDLA<T1, T2, T3, T4, T5, T6, T7, HGNFDBOJKMF> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x40255B0", Offset = "0x4023BB0", VA = "0x1840255B0", Slot = "212")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(PJPFMLIMKLJ LLAMMDFPKFC, NNKAGKEEMCE.CCMFADAJMBF<T1, T2, T3, T4, T5, T6, T7, T8, HGNFDBOJKMF> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x4024E50", Offset = "0x4023450", VA = "0x184024E50", Slot = "213")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(PJPFMLIMKLJ LLAMMDFPKFC, PHOMKNDGLGI GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x4024650", Offset = "0x4022C50", VA = "0x184024650", Slot = "214")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(PJPFMLIMKLJ LLAMMDFPKFC, CBCLHJIIFEN GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x4023DB0", Offset = "0x40223B0", VA = "0x184023DB0", Slot = "215")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(PJPFMLIMKLJ LLAMMDFPKFC, ILCKMLFIJAP GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL, T11 MJACEOOCDOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x4023910", Offset = "0x4021F10", VA = "0x184023910", Slot = "216")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(PJPFMLIMKLJ LLAMMDFPKFC, ICKJBDGICPO GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL, T11 MJACEOOCDOH, T12 MDJMDAKMAFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x4022A70", Offset = "0x4021070", VA = "0x184022A70", Slot = "217")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(PJPFMLIMKLJ LLAMMDFPKFC, CPHLKHGEELE GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL, T11 MJACEOOCDOH, T12 MDJMDAKMAFA, T13 GLKADJBODOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x4022520", Offset = "0x4020B20", VA = "0x184022520", Slot = "218")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(PJPFMLIMKLJ LLAMMDFPKFC, PPMPOGPDMFO GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL, T11 MJACEOOCDOH, T12 MDJMDAKMAFA, T13 GLKADJBODOD, T14 ACFEIDEILLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x85A69D0", Offset = "0x85A4FD0", VA = "0x1885A69D0", Slot = "219")]
		public void RpcOthersBuffered(PJPFMLIMKLJ LLAMMDFPKFC, NNKAGKEEMCE.DLGBMDJCHGO GMJJMMCAFFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x405ED70", Offset = "0x405D370", VA = "0x18405ED70", Slot = "220")]
		public void RpcOthersBuffered<T1>(PJPFMLIMKLJ LLAMMDFPKFC, NNKAGKEEMCE.NCLMJINMPEN<T1> GMJJMMCAFFM, T1 DIOAIFIFBLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x405EA90", Offset = "0x405D090", VA = "0x18405EA90", Slot = "221")]
		public void RpcOthersBuffered<T1, T2>(PJPFMLIMKLJ LLAMMDFPKFC, NNKAGKEEMCE.IBHFHFIGKJE<T1, T2> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x405E710", Offset = "0x405CD10", VA = "0x18405E710", Slot = "222")]
		public void RpcOthersBuffered<T1, T2, T3>(PJPFMLIMKLJ LLAMMDFPKFC, NNKAGKEEMCE.IICPJCBCMBK<T1, T2, T3> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x405E2F0", Offset = "0x405C8F0", VA = "0x18405E2F0", Slot = "223")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(PJPFMLIMKLJ LLAMMDFPKFC, NNKAGKEEMCE.JIMABFKNHPN<T1, T2, T3, T4> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x405DE30", Offset = "0x405C430", VA = "0x18405DE30", Slot = "224")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(PJPFMLIMKLJ LLAMMDFPKFC, NNKAGKEEMCE.KDPDDJEGCJK<T1, T2, T3, T4, T5> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x405D8D0", Offset = "0x405BED0", VA = "0x18405D8D0", Slot = "225")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(PJPFMLIMKLJ LLAMMDFPKFC, NNKAGKEEMCE.ODDJMLCIGIP<T1, T2, T3, T4, T5, T6> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x405D2D0", Offset = "0x405B8D0", VA = "0x18405D2D0", Slot = "226")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(PJPFMLIMKLJ LLAMMDFPKFC, NNKAGKEEMCE.PMDHAFIBPFB<T1, T2, T3, T4, T5, T6, T7> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x405CC10", Offset = "0x405B210", VA = "0x18405CC10", Slot = "227")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(PJPFMLIMKLJ LLAMMDFPKFC, NNKAGKEEMCE.IBINCFJGDLA<T1, T2, T3, T4, T5, T6, T7, T8> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x405C4B0", Offset = "0x405AAB0", VA = "0x18405C4B0", Slot = "228")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(PJPFMLIMKLJ LLAMMDFPKFC, NNKAGKEEMCE.CCMFADAJMBF<T1, T2, T3, T4, T5, T6, T7, T8, T9> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x405BCB0", Offset = "0x405A2B0", VA = "0x18405BCB0", Slot = "229")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(PJPFMLIMKLJ LLAMMDFPKFC, PHOMKNDGLGI GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x405B860", Offset = "0x4059E60", VA = "0x18405B860", Slot = "230")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(PJPFMLIMKLJ LLAMMDFPKFC, CBCLHJIIFEN GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL, T11 MJACEOOCDOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x405AAD0", Offset = "0x40590D0", VA = "0x18405AAD0", Slot = "231")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(PJPFMLIMKLJ LLAMMDFPKFC, ILCKMLFIJAP GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL, T11 MJACEOOCDOH, T12 MDJMDAKMAFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x405A0D0", Offset = "0x40586D0", VA = "0x18405A0D0", Slot = "232")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(PJPFMLIMKLJ LLAMMDFPKFC, ICKJBDGICPO GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL, T11 MJACEOOCDOH, T12 MDJMDAKMAFA, T13 GLKADJBODOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x4059B80", Offset = "0x4058180", VA = "0x184059B80", Slot = "233")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(PJPFMLIMKLJ LLAMMDFPKFC, CPHLKHGEELE GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL, T11 MJACEOOCDOH, T12 MDJMDAKMAFA, T13 GLKADJBODOD, T14 ACFEIDEILLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x85A6A70", Offset = "0x85A5070", VA = "0x1885A6A70", Slot = "234")]
		public void RpcOthersBuffered(PJPFMLIMKLJ LLAMMDFPKFC, NNKAGKEEMCE.NCLMJINMPEN<HGNFDBOJKMF> GMJJMMCAFFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x405EE90", Offset = "0x405D490", VA = "0x18405EE90", Slot = "235")]
		public void RpcOthersBuffered<T1>(PJPFMLIMKLJ LLAMMDFPKFC, NNKAGKEEMCE.IBHFHFIGKJE<T1, HGNFDBOJKMF> GMJJMMCAFFM, T1 DIOAIFIFBLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x405EC00", Offset = "0x405D200", VA = "0x18405EC00", Slot = "236")]
		public void RpcOthersBuffered<T1, T2>(PJPFMLIMKLJ LLAMMDFPKFC, NNKAGKEEMCE.IICPJCBCMBK<T1, T2, HGNFDBOJKMF> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x405E8D0", Offset = "0x405CED0", VA = "0x18405E8D0", Slot = "237")]
		public void RpcOthersBuffered<T1, T2, T3>(PJPFMLIMKLJ LLAMMDFPKFC, NNKAGKEEMCE.JIMABFKNHPN<T1, T2, T3, HGNFDBOJKMF> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x405E500", Offset = "0x405CB00", VA = "0x18405E500", Slot = "238")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(PJPFMLIMKLJ LLAMMDFPKFC, NNKAGKEEMCE.KDPDDJEGCJK<T1, T2, T3, T4, HGNFDBOJKMF> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x405E090", Offset = "0x405C690", VA = "0x18405E090", Slot = "239")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(PJPFMLIMKLJ LLAMMDFPKFC, NNKAGKEEMCE.ODDJMLCIGIP<T1, T2, T3, T4, T5, HGNFDBOJKMF> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x405DB80", Offset = "0x405C180", VA = "0x18405DB80", Slot = "240")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(PJPFMLIMKLJ LLAMMDFPKFC, NNKAGKEEMCE.PMDHAFIBPFB<T1, T2, T3, T4, T5, T6, HGNFDBOJKMF> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x405D5D0", Offset = "0x405BBD0", VA = "0x18405D5D0", Slot = "241")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(PJPFMLIMKLJ LLAMMDFPKFC, NNKAGKEEMCE.IBINCFJGDLA<T1, T2, T3, T4, T5, T6, T7, HGNFDBOJKMF> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x405CF70", Offset = "0x405B570", VA = "0x18405CF70", Slot = "242")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(PJPFMLIMKLJ LLAMMDFPKFC, NNKAGKEEMCE.CCMFADAJMBF<T1, T2, T3, T4, T5, T6, T7, T8, HGNFDBOJKMF> GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x405C860", Offset = "0x405AE60", VA = "0x18405C860", Slot = "243")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(PJPFMLIMKLJ LLAMMDFPKFC, PHOMKNDGLGI GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x405C0B0", Offset = "0x405A6B0", VA = "0x18405C0B0", Slot = "244")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(PJPFMLIMKLJ LLAMMDFPKFC, CBCLHJIIFEN GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x405B410", Offset = "0x4059A10", VA = "0x18405B410", Slot = "245")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(PJPFMLIMKLJ LLAMMDFPKFC, ILCKMLFIJAP GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL, T11 MJACEOOCDOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x405AF70", Offset = "0x4059570", VA = "0x18405AF70", Slot = "246")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(PJPFMLIMKLJ LLAMMDFPKFC, ICKJBDGICPO GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL, T11 MJACEOOCDOH, T12 MDJMDAKMAFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x405A5D0", Offset = "0x4058BD0", VA = "0x18405A5D0", Slot = "247")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(PJPFMLIMKLJ LLAMMDFPKFC, CPHLKHGEELE GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL, T11 MJACEOOCDOH, T12 MDJMDAKMAFA, T13 GLKADJBODOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x4059630", Offset = "0x4057C30", VA = "0x184059630", Slot = "248")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(PJPFMLIMKLJ LLAMMDFPKFC, PPMPOGPDMFO GMJJMMCAFFM, T1 DIOAIFIFBLB, T2 EOFPKOLENGO, T3 JGLHCGJMAIA, T4 POJDFJECOMH, T5 JJLHIEFIDLC, T6 KANDNPNCGKE, T7 DCFPOCBHGAJ, T8 LLBGMDCPPMD, T9 AOIFAFNLDJC, T10 PEPIBCFBJOL, T11 MJACEOOCDOH, T12 MDJMDAKMAFA, T13 GLKADJBODOD, T14 ACFEIDEILLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x85A3910", Offset = "0x85A1F10", VA = "0x1885A3910", Slot = "249")]
		public void ClearBufferedRPCsIfMine()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x85A3B30", Offset = "0x85A2130", VA = "0x1885A3B30", Slot = "250")]
		public void ClearBufferedRPCs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x20EA4B0", Offset = "0x20E8AB0", VA = "0x1820EA4B0")]
		public RRNetworkView()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class DFGGHFBJAHD
{
	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x8589C40", Offset = "0x8588240", VA = "0x188589C40")]
	private static bool NEBDDLFAHMB(ViewId JIEJOKBHEMF, [Out] RRNetworkView MLCJICFBOOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x3BD1EB0", Offset = "0x3BD04B0", VA = "0x183BD1EB0")]
	[CanBeNull]
	public static T CAKACLPCNKF<T>(this ViewId KBEDHBMNMBE)
	{
		return (T)null;
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class RRPlayerNumbering : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class GAJNNONMFFP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public NGPBJJLAELK[] sorted;

			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
			public GAJNNONMFFP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0x858AD60", Offset = "0x8589360", VA = "0x18858AD60")]
			internal int GLEADHDOEMC(int index)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x858ACD0", Offset = "0x85892D0", VA = "0x18858ACD0")]
			internal void EBKKKNLFLOH(int index, int number)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private static readonly IDGHEFJHGEI FEFALLLFAGB;

		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public static RRPlayerNumbering instance;

		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public static NGPBJJLAELK[] SortedPlayers;

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public const string RoomPlayerIndexedProp = "rrPnr";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		internal int CHBBHOCGPMM;

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x85A7F70", Offset = "0x85A6570", VA = "0x1885A7F70")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x85A85A0", Offset = "0x85A6BA0", VA = "0x1885A85A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x85A8970", Offset = "0x85A6F70", VA = "0x1885A8970")]
		private void OnJoinedRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x85A89F0", Offset = "0x85A6FF0", VA = "0x1885A89F0")]
		private void OnLeftRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x85A83B0", Offset = "0x85A69B0", VA = "0x1885A83B0")]
		private void MDJFHAICPKC(NGPBJJLAELK HDOIACKLNCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x85A83B0", Offset = "0x85A69B0", VA = "0x1885A83B0")]
		private void GDJDNFEOJIJ(NGPBJJLAELK HELPKNNPDDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x85A84B0", Offset = "0x85A6AB0", VA = "0x1885A84B0")]
		private void NJNPNNCIPLM(NGPBJJLAELK OFMAIOJLPIF, IDictionary<object, object> LOHIEJPHPAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x85A7E20", Offset = "0x85A6420", VA = "0x1885A7E20")]
		public static void AssignPlayerNumbers(int EEIHKEHGDGD, int MJLHIPEGEGL, Func<int, int> GLKDJKALBDK, Action<int, int> KLDEEHFKEOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x85A8AA0", Offset = "0x85A70A0", VA = "0x1885A8AA0")]
		public void RefreshData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x85A83C0", Offset = "0x85A69C0", VA = "0x1885A83C0")]
		private void KMOEHEDJIIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A70", Offset = "0xAA5070", VA = "0x180AA6A70")]
		public RRPlayerNumbering()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class KLKNFPDANIC
{
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private static readonly IDGHEFJHGEI FEFALLLFAGB;

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x85959B0", Offset = "0x8593FB0", VA = "0x1885959B0")]
	public static int OPIENOELGFH(this NGPBJJLAELK LIOICDJHFAF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x85955E0", Offset = "0x8593BE0", VA = "0x1885955E0")]
	public static void KLGBKELLKMP(this NGPBJJLAELK LIOICDJHFAF, int BNLGKEPJACJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class CCGLCDAJKLI
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public delegate void CDFNFMNGGIP(Hashtable MKBODFCJGPA);

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public delegate void PJBKICMANNM(NGPBJJLAELK LIOICDJHFAF, Hashtable MKBODFCJGPA);

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public static event CDFNFMNGGIP NOHLIPOMDEA
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x8588260", Offset = "0x8586860", VA = "0x188588260")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x85884A0", Offset = "0x8586AA0", VA = "0x1885884A0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public static event CDFNFMNGGIP GEGIKGEBOIF
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x8588620", Offset = "0x8586C20", VA = "0x188588620")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x8588320", Offset = "0x8586920", VA = "0x188588320")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public static event PJBKICMANNM LLBAGAEIDFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x85886E0", Offset = "0x8586CE0", VA = "0x1885886E0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x8588560", Offset = "0x8586B60", VA = "0x188588560")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public static event PJBKICMANNM EDGOCGKAABB
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x85887A0", Offset = "0x8586DA0", VA = "0x1885887A0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x85883E0", Offset = "0x85869E0", VA = "0x1885883E0")]
		[CompilerGenerated]
		remove
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal static class FEAOKIHNDAK
{
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static int GMDBDFPFEFI;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static int BPAJDCOGHIK;

	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private static int JFNKFOCIHEE;

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x8589DE0", Offset = "0x85883E0", VA = "0x188589DE0")]
	public static void IFNKIGMHBHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x8589D00", Offset = "0x8588300", VA = "0x188589D00")]
	public static void FCDJLEGLPBK(int[] JPJLAEAAEIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x8589E30", Offset = "0x8588430", VA = "0x188589E30")]
	public static int ODEKDHICDNF(int CIFKNCFNHEN, bool GMJFEJNPLBI = true)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[RegisterService(typeof(KAHNHAEIBBE), new string[] { })]
[ServiceLifetime(Lifetime.Application)]
public class KAHNHAEIBBE : IGIBKNHNEBP, KDLLCPKJBMN, LKJPKMELKMK
{
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static readonly Dictionary<object, object> EBCIHKPFKGD;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static readonly Dictionary<object, object> HPLEPJHAHOM;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static readonly Dictionary<object, object> EFPABCFEPIP;

	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private static readonly CHACOCKEPKK HAGNICOHOCB;

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private static readonly CHACOCKEPKK NCLKNNGMHAP;

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static readonly CHACOCKEPKK FCAJKMPKILD;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static readonly CHACOCKEPKK FOBEAEJPJDD;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static readonly CHACOCKEPKK KMJFGPHOGBF;

	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private static int DIPFPIBLDEA;

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x8591980", Offset = "0x858FF80", VA = "0x188591980", Slot = "18")]
	public void EPMGJNHIDNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x8593DF0", Offset = "0x85923F0", VA = "0x188593DF0", Slot = "19")]
	public void PILPLNBAOCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x8591A20", Offset = "0x8590020", VA = "0x188591A20", Slot = "4")]
	public bool FFOKLBENAMF(NEIKMBGDPOI MHCCEBNBPPI, bool NNIGHJGEHLI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x8592070", Offset = "0x8590670", VA = "0x188592070", Slot = "5")]
	public int IEILOHJCFOA(NEIKMBGDPOI[] HJEHIGNFBAG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x8593B00", Offset = "0x8592100", VA = "0x188593B00", Slot = "6")]
	public bool OKAAMDAIJDH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x8591CC0", Offset = "0x85902C0", VA = "0x188591CC0", Slot = "7")]
	public bool GKOLKEDLFIH(int KBEDHBMNMBE, int IKKJDEFHNPG, bool IBPIAPBNIAJ, GameObject EGMHLHLEIMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x8591580", Offset = "0x858FB80", VA = "0x188591580", Slot = "8")]
	public void BNCAANECNNF(int IKKJDEFHNPG, [Optional] int? NPNKAOIDCOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x85930D0", Offset = "0x85916D0", VA = "0x1885930D0", Slot = "9")]
	public bool LKGLENCEHFP(CHPJIJKJKGB KJOIOABMAMH, [Out] NEIKMBGDPOI NMLIHNPKKOC, bool CADLGBPCAME = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x8593240", Offset = "0x8591840", VA = "0x188593240", Slot = "10")]
	public bool NCOLMIKDCIJ(CHPJIJKJKGB KJOIOABMAMH, [Out] int MNAFGCEMEEM, [Out] NEIKMBGDPOI[] HJEHIGNFBAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x8591B60", Offset = "0x8590160", VA = "0x188591B60", Slot = "11")]
	public bool GHJAEOMKJMN(CHPJIJKJKGB KJOIOABMAMH, [Out] int IKKJDEFHNPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x85925C0", Offset = "0x8590BC0", VA = "0x1885925C0", Slot = "12")]
	public void JHLFHLIJEBA(CHPJIJKJKGB KJOIOABMAMH, [Out] int ALINLKPMGAH, [Out] int[] EEIGGAFCBHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x8591E90", Offset = "0x8590490", VA = "0x188591E90", Slot = "13")]
	public void GPANPIHEBMP(int MNAFGCEMEEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x8593C70", Offset = "0x8592270", VA = "0x188593C70", Slot = "14")]
	public void ONLMPLKECMN(int MNAFGCEMEEM, int[] EEIGGAFCBHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x85913A0", Offset = "0x858F9A0", VA = "0x1885913A0", Slot = "15")]
	public void BEDJCHCNMNL(int[] EEIGGAFCBHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x85924A0", Offset = "0x8590AA0", VA = "0x1885924A0", Slot = "16")]
	public void JEGBAHLGNDI(int[] EEIGGAFCBHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x85917B0", Offset = "0x858FDB0", VA = "0x1885917B0", Slot = "17")]
	public void DEOOJKPBMCF(int MNAFGCEMEEM, int IKKJDEFHNPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x8593590", Offset = "0x8591B90", VA = "0x188593590")]
	private static void NPDPEFAEFMB(NEIKMBGDPOI MHCCEBNBPPI, Dictionary<object, object> FPAJFFFMBBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x8592820", Offset = "0x8590E20", VA = "0x188592820")]
	private static bool LKGLENCEHFP(Dictionary<object, object> FPAJFFFMBBG, NGPBJJLAELK NAOLNBDNHEN, [Out] NEIKMBGDPOI NMLIHNPKKOC, bool CADLGBPCAME = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x8591490", Offset = "0x858FA90", VA = "0x188591490")]
	private static bool BHICPBDEENO(int IKKJDEFHNPG, NEIKMBGDPOI FPAJFFFMBBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x8593B90", Offset = "0x8592190", VA = "0x188593B90")]
	private static int OLPABBBJFIA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public KAHNHAEIBBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[ServiceLifetime(Lifetime.Application)]
[RegisterService(typeof(CFCKKNNCGOF), new string[] { })]
public class CFCKKNNCGOF : GCFHAFGKHAO, KDLLCPKJBMN, LKJPKMELKMK
{
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private static Hashtable ECJLOPFAHJJ;

	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private static Hashtable KCFGPDFIOEP;

	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private static CHACOCKEPKK NMHDAJMLIHC;

	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private static readonly CHACOCKEPKK PJBOEHMNJHO;

	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private static IDGHEFJHGEI FEFALLLFAGB;

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x8589380", Offset = "0x8587980", VA = "0x188589380", Slot = "8")]
	public void PILPLNBAOCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x85892E0", Offset = "0x85878E0", VA = "0x1885892E0", Slot = "7")]
	public void EPMGJNHIDNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x8589420", Offset = "0x8587A20", VA = "0x188589420", Slot = "4")]
	public void PMBAFDFMGBJ(ViewId KBEDHBMNMBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x8588F80", Offset = "0x8587580", VA = "0x188588F80", Slot = "5")]
	public bool CAFENLOFKEH(CHPJIJKJKGB KJOIOABMAMH, [Out] ViewId KBEDHBMNMBE, [Out] string BKCBMFPHNNL, [Out] int EPEOJKACHKK, [Out] object[] ILLMINLDJKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x8588930", Offset = "0x8586F30", VA = "0x188588930", Slot = "6")]
	public void AGEDGCODPIB(ViewId MLCJICFBOOE, string BKCBMFPHNNL, MACNHJCIMEN DPONGBBHBGJ, NGPBJJLAELK LIOICDJHFAF, DIFLOFIPONG PDONCLMEOCB, object[] MHCCEBNBPPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public CFCKKNNCGOF()
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
