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
	public class LogRegistrationIndex : LALFEIIPPKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7D88CA0", Offset = "0x7D87EA0", VA = "0x187D88CA0", Slot = "4")]
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
namespace _AssemblyRegistry.RecRoom_Networking_RRNetworkLayer
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
		[Cpp2IlInjected.Address(RVA = "0x7D997A0", Offset = "0x7D989A0", VA = "0x187D997A0")]
		private void AGIDAPFICKK(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7D99E00", Offset = "0x7D99000", VA = "0x187D99E00")]
		private void EKPABHIKONH(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7D9A080", Offset = "0x7D99280", VA = "0x187D9A080", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7D9A130", Offset = "0x7D99330", VA = "0x187D9A130")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class EBGHEMGHMBA
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly KEPOMIIOHBM IMLPAHMDDDJ;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static KEPOMIIOHBM CFDBJMGPNBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7D85770", Offset = "0x7D84970", VA = "0x187D85770")]
		get
		{
			return default(KEPOMIIOHBM);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface PFOMPEJKBAH
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	RRNetworkView LMONFAIDLHK
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	OOOJKOAJFHP DNJFHKGGNGE
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool Serialize(EIAJBMFFJJA FFNBCPHBHCC);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void Deserialize(IMHHILBGAEF ALLIBLOLGHD, EIAJBMFFJJA FFNBCPHBHCC);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface BNJFDLFMJBD
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool JFFHNLIPGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OPCLJGFNLLP(IMHHILBGAEF ALLIBLOLGHD);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BHIBMPPAILM(IMHHILBGAEF ALLIBLOLGHD, EIAJBMFFJJA FFNBCPHBHCC);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface ODLPOCCJHLA : INetworkUpdateSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ELDCOJNOKAJ(PFOMPEJKBAH DEGBKAPFBGL);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JNBGJFEBNND(PFOMPEJKBAH DEGBKAPFBGL);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IENMIHHEGBA(ANIIEAAHGMD.MCAFGJLKKHC MOPMPCHOJHA);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ADPBHLDNDIC();

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JGACCKNGGNC(object ODLIDIMANGE);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum OOOJKOAJFHP : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	NetworkTransform,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	PlayerAvatarData,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	FullBodyPuppetData,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	AvatarSkeletonData,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	ControlDeckData,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	RCCarData,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	GroundVehicleData,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	NetworkEnemyHeadRotationData,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	DesktopScreenSharing,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	RoomieAIAudio,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Invalid
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct IMHHILBGAEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public int LJGIJNKMNHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public uint KNJMHLHNKIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public double PJJOPOCDGIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public int POLPANCKGGB;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class HFAMPNNJONA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Dictionary<(ViewId, OOOJKOAJFHP), BNJFDLFMJBD> NLACMAKGKEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly List<PFOMPEJKBAH> FLAKAPOPAAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly HashSet<(ViewId, OOOJKOAJFHP)> KPFOOBIEOFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private int GCHEGNPGGOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public bool HPDDMCOBLGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private ANIIEAAHGMD.MCAFGJLKKHC MOPMPCHOJHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly MemoryStream ACHFEKOFFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly EIAJBMFFJJA HOBODAGOOKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly EIAJBMFFJJA DADNIHLFCLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private byte[] CFGBFOMGMAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private float LPDLMHKJIPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private int FMOEMPFIHII;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7D885F0", Offset = "0x7D877F0", VA = "0x187D885F0")]
	public HFAMPNNJONA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7D87790", Offset = "0x7D86990", VA = "0x187D87790")]
	public void IENMIHHEGBA(ANIIEAAHGMD.MCAFGJLKKHC MOPMPCHOJHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7D87140", Offset = "0x7D86340", VA = "0x187D87140")]
	public void ADPBHLDNDIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7D877B0", Offset = "0x7D869B0", VA = "0x187D877B0")]
	public void KJFMNLEBHBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7D87F90", Offset = "0x7D87190", VA = "0x187D87F90")]
	public bool LHOMNBOIMGH(PFOMPEJKBAH DEGBKAPFBGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7D884C0", Offset = "0x7D876C0", VA = "0x187D884C0")]
	public bool PKCJOLGDFLO(PFOMPEJKBAH DEGBKAPFBGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7D87550", Offset = "0x7D86750", VA = "0x187D87550")]
	private BNJFDLFMJBD EAEMGBHBMLA(ViewId LIOACKIDDBK, OOOJKOAJFHP OGCEONHNPKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7D884B0", Offset = "0x7D876B0", VA = "0x187D884B0")]
	public void OIPCCEPCIOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7D87F30", Offset = "0x7D87130", VA = "0x187D87F30")]
	private void LFHCDDBCDJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7D87770", Offset = "0x7D86970", VA = "0x187D87770")]
	private void EGAMALLEHKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7D87B90", Offset = "0x7D86D90", VA = "0x187D87B90")]
	public bool KPMPHHFHLKB(FastBufferWriter HLPFOKGJOHH, int LDDOFLFHAKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7D87190", Offset = "0x7D86390", VA = "0x187D87190")]
	public void BHIBMPPAILM(IMHHILBGAEF ALLIBLOLGHD, FastBufferReader GBOEOLHFKIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal class NBAFCGDPGGC : BNJFDLFMJBD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private PFOMPEJKBAH NAEHGOEFKMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private uint EBEIMOPNLIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private int PHHLBNNEDEK;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool JFFHNLIPGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0xA0F6B0", Offset = "0xA0E8B0", VA = "0x180A0F6B0")]
	public NBAFCGDPGGC(PFOMPEJKBAH NAEHGOEFKMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7D8CB10", Offset = "0x7D8BD10", VA = "0x187D8CB10", Slot = "5")]
	public bool OPCLJGFNLLP(IMHHILBGAEF ALLIBLOLGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7D8CA30", Offset = "0x7D8BC30", VA = "0x187D8CA30", Slot = "6")]
	public void BHIBMPPAILM(IMHHILBGAEF ALLIBLOLGHD, EIAJBMFFJJA FFNBCPHBHCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class MAHOEELFBGM : BNJFDLFMJBD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private ANIIEAAHGMD.MCAFGJLKKHC MOPMPCHOJHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly ViewId LIOACKIDDBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private int PHHLBNNEDEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private uint EBEIMOPNLIJ;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool JFFHNLIPGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA1C570", Offset = "0xA1B770", VA = "0x180A1C570", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x1A887B0", Offset = "0x1A879B0", VA = "0x181A887B0")]
	public MAHOEELFBGM(ViewId LIOACKIDDBK, ANIIEAAHGMD.MCAFGJLKKHC MOPMPCHOJHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7D890E0", Offset = "0x7D882E0", VA = "0x187D890E0", Slot = "5")]
	public bool OPCLJGFNLLP(IMHHILBGAEF ALLIBLOLGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7D88F00", Offset = "0x7D88100", VA = "0x187D88F00", Slot = "6")]
	public void BHIBMPPAILM(IMHHILBGAEF ALLIBLOLGHD, EIAJBMFFJJA FFNBCPHBHCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class DIEMIKLLKNJ
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7D84D00", Offset = "0x7D83F00", VA = "0x187D84D00")]
	public static void ELKKKBEIKKA(this DPGDOGEFGCI AHMENDMONGH, EIAJBMFFJJA NNJHNKLDPFP, ViewId BKDMJHGCDEA, bool GNCOKFPBFJO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7D85270", Offset = "0x7D84470", VA = "0x187D85270")]
	public static void GENDHBFKDME(this DPGDOGEFGCI AHMENDMONGH, EIAJBMFFJJA NNJHNKLDPFP, bool GNCOKFPBFJO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7D84B90", Offset = "0x7D83D90", VA = "0x187D84B90")]
	public static DPGDOGEFGCI BHIBMPPAILM(EIAJBMFFJJA NNJHNKLDPFP, ViewId BKDMJHGCDEA, bool GNCOKFPBFJO = true)
	{
		return default(DPGDOGEFGCI);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7D84EC0", Offset = "0x7D840C0", VA = "0x187D84EC0")]
	public static void FHGFKLDFHKI(this DPGDOGEFGCI AHMENDMONGH, EIAJBMFFJJA NNJHNKLDPFP, bool GNCOKFPBFJO = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[RegisterService(typeof(ODLPOCCJHLA), new string[] { })]
public class MDBFDDICGCO : ODLPOCCJHLA, INetworkUpdateSystem, PCJOCILCILM, EJADEOIPJPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly KEPOMIIOHBM POAFINPDCPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private HFAMPNNJONA GCJLABNGPDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private uint LAMENNGIHFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private float HBJFHGBAPLO;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7D89180", Offset = "0x7D88380", VA = "0x187D89180", Slot = "4")]
	public void ELDCOJNOKAJ(PFOMPEJKBAH DEGBKAPFBGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7D89A60", Offset = "0x7D88C60", VA = "0x187D89A60", Slot = "5")]
	public void JNBGJFEBNND(PFOMPEJKBAH DEGBKAPFBGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7D89870", Offset = "0x7D88A70", VA = "0x187D89870", Slot = "10")]
	public void HHNCJNPAAFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7D89FE0", Offset = "0x7D891E0", VA = "0x187D89FE0", Slot = "9")]
	public void NetworkUpdate(NetworkUpdateStage AGMKPALPMPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7D892A0", Offset = "0x7D884A0", VA = "0x187D892A0")]
	private void GBPIFHFGCPH(uint NDDMMKIFNEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7D899D0", Offset = "0x7D88BD0", VA = "0x187D899D0", Slot = "6")]
	public void IENMIHHEGBA(ANIIEAAHGMD.MCAFGJLKKHC MOPMPCHOJHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7D89120", Offset = "0x7D88320", VA = "0x187D89120", Slot = "7")]
	public void ADPBHLDNDIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7D89A00", Offset = "0x7D88C00", VA = "0x187D89A00", Slot = "8")]
	public void JGACCKNGGNC(object HEAHMHOMOPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7D89C60", Offset = "0x7D88E60", VA = "0x187D89C60")]
	private void KCKMPJKFIDL(HIPDGMOFECH HEAHMHOMOPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7D8A060", Offset = "0x7D89260", VA = "0x187D8A060", Slot = "11")]
	public void PNAGKOGGHJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7D8A180", Offset = "0x7D89380", VA = "0x187D8A180")]
	public MDBFDDICGCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class GAPDCDECAPA : BNJFDLFMJBD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private float IAKALKKKMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private int PHHLBNNEDEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private uint EBEIMOPNLIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly OOOJKOAJFHP NCCIGNFBDON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public IMHHILBGAEF OCNPJLEEIGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public int EPOKCFPJADJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public byte[] JBOBPHNIPOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private IMHHILBGAEF EKMEOPLMNKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private int IKCGDKOHEOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private byte[] FECCMDPBJKG;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool JFFHNLIPGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7D86D80", Offset = "0x7D85F80", VA = "0x187D86D80", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7D870D0", Offset = "0x7D862D0", VA = "0x187D870D0")]
	public GAPDCDECAPA(OOOJKOAJFHP NCCIGNFBDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7D87090", Offset = "0x7D86290", VA = "0x187D87090", Slot = "5")]
	public bool OPCLJGFNLLP(IMHHILBGAEF ALLIBLOLGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7D86BD0", Offset = "0x7D85DD0", VA = "0x187D86BD0", Slot = "6")]
	public void BHIBMPPAILM(IMHHILBGAEF ALLIBLOLGHD, EIAJBMFFJJA FFNBCPHBHCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7D86DB0", Offset = "0x7D85FB0", VA = "0x187D86DB0")]
	internal NBAFCGDPGGC OACKPCINPBL(PFOMPEJKBAH DEGBKAPFBGL, EIAJBMFFJJA NNJHNKLDPFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7D86EC0", Offset = "0x7D860C0", VA = "0x187D86EC0")]
	private static void OFHJEBLNMOM(NBAFCGDPGGC OEGLJMHPIIK, EIAJBMFFJJA NNJHNKLDPFP, IMHHILBGAEF KHKFEMAEOLP, byte[] DLBFFDJEFBK, int IKDAJGLNNEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[RegisterService(typeof(BDOGNHKAFGG), new string[] { })]
[ServiceLifetime(Lifetime.Application)]
public class BDOGNHKAFGG : FNMHNAJIPJE, PCJOCILCILM, EJADEOIPJPK
{
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static readonly Hashtable ODHKALADHEG;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private static readonly Hashtable CFIDCCBJPLB;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static readonly Hashtable DPHAHHNECAK;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static readonly FLEPBPAFMND CCGPCBFNIML;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly FLEPBPAFMND FKAEOOJCHJF;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private static readonly FLEPBPAFMND OOJMMHFBDDI;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static readonly FLEPBPAFMND OKPEDMEADGB;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static readonly FLEPBPAFMND KOOEMHAGCMO;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static int CHNEDENCJKO;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7D79470", Offset = "0x7D78670", VA = "0x187D79470", Slot = "4")]
	public bool JKFBIMNJILN(BGEDHHKJGFH AJLJPILGNIP, bool CODEHDNCFDI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7D78380", Offset = "0x7D77580", VA = "0x187D78380", Slot = "5")]
	public int CIGPBIELCFH(BGEDHHKJGFH[] LGLGPDLJDEE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7D78220", Offset = "0x7D77420", VA = "0x187D78220", Slot = "6")]
	public bool AIHDJKHONOK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7D79100", Offset = "0x7D78300", VA = "0x187D79100", Slot = "7")]
	public bool IFICGNGLLEE(int LIOACKIDDBK, int AMMEGBDPGDG, bool INIHEKNIGFL, GameObject LBBGHAOMHLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7D7A0A0", Offset = "0x7D792A0", VA = "0x187D7A0A0", Slot = "8")]
	public void OCLPLIEOAMG(int AMMEGBDPGDG, [Optional] int? NHFMGENJNHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7D789B0", Offset = "0x7D77BB0", VA = "0x187D789B0", Slot = "9")]
	public bool HJNHHEJPGME(HIPDGMOFECH ODLIDIMANGE, [Out] BGEDHHKJGFH NGKHBJHFIFH, bool CIFOMFBAMKL = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7D795A0", Offset = "0x7D787A0", VA = "0x187D795A0", Slot = "10")]
	public bool KGEJCMDCLFP(HIPDGMOFECH ODLIDIMANGE, [Out] int PGMOLICBNBD, [Out] BGEDHHKJGFH[] LGLGPDLJDEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7D787F0", Offset = "0x7D779F0", VA = "0x187D787F0", Slot = "11")]
	public bool ELHEPEMLJPO(HIPDGMOFECH ODLIDIMANGE, [Out] int AMMEGBDPGDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7D79290", Offset = "0x7D78490", VA = "0x187D79290", Slot = "12")]
	public void IPAPMGNJIBB(HIPDGMOFECH ODLIDIMANGE, [Out] int MMGJEOAGLED, [Out] int[] PFFHMIGKHMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7D799F0", Offset = "0x7D78BF0", VA = "0x187D799F0", Slot = "13")]
	public void LAPFIILBDIN(int PGMOLICBNBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7D79F80", Offset = "0x7D79180", VA = "0x187D79F80", Slot = "14")]
	public void NNADAODACGL(int PGMOLICBNBD, int[] PFFHMIGKHMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7D78740", Offset = "0x7D77940", VA = "0x187D78740", Slot = "15")]
	public void EIOGGGOFNNG(int[] PFFHMIGKHMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7D782B0", Offset = "0x7D774B0", VA = "0x187D782B0", Slot = "16")]
	public void BCGDMHIGKDC(int[] PFFHMIGKHMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7D79880", Offset = "0x7D78A80", VA = "0x187D79880", Slot = "17")]
	public void KGLCFBDMCBL(int PGMOLICBNBD, int AMMEGBDPGDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7D79B50", Offset = "0x7D78D50", VA = "0x187D79B50")]
	private static void NHLPCBKOFPG(BGEDHHKJGFH AJLJPILGNIP, Hashtable AMLNMADBOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7D78B20", Offset = "0x7D77D20", VA = "0x187D78B20")]
	private static bool HJNHHEJPGME(Hashtable AMLNMADBOHB, BNFABCHNBCL MCBHFLKONDI, [Out] BGEDHHKJGFH NGKHBJHFIFH, bool CIFOMFBAMKL = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7D7A290", Offset = "0x7D79490", VA = "0x187D7A290")]
	private static int OELHDAMGHIM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7D78910", Offset = "0x7D77B10", VA = "0x187D78910", Slot = "18")]
	public void HHNCJNPAAFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7D7A370", Offset = "0x7D79570", VA = "0x187D7A370", Slot = "19")]
	public void PNAGKOGGHJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public BDOGNHKAFGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[RegisterService(typeof(FMDALMBBFJP), new string[] { })]
[ServiceLifetime(Lifetime.Application)]
public class FMDALMBBFJP : AADFKPJIOLJ, PCJOCILCILM, EJADEOIPJPK
{
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static Hashtable NAEBDOGFNAO;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static Hashtable LPBAKAAEAMP;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static FLEPBPAFMND DCDMOKKEMPK;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static readonly FLEPBPAFMND PJLJHGJGMDI;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static KEPOMIIOHBM EBHKLAMEJCE;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7D86240", Offset = "0x7D85440", VA = "0x187D86240", Slot = "4")]
	public void DCNMGHMLAEM(ViewId LIOACKIDDBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7D85EE0", Offset = "0x7D850E0", VA = "0x187D85EE0", Slot = "5")]
	public bool ADHDJDDCJJI(HIPDGMOFECH ODLIDIMANGE, [Out] ViewId LIOACKIDDBK, [Out] string NDKKEIEAJEI, [Out] int DCLDCHKGEFO, [Out] object[] IGDEBNHMJLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7D86330", Offset = "0x7D85530", VA = "0x187D86330", Slot = "6")]
	public void DLKEOENKPGH(ViewId PEGCLJNJBJG, string NDKKEIEAJEI, EIDEGPMEPAM MDMEODJMNFF, BNFABCHNBCL NLIBDKKPKLB, DFOLGABGJMH HNHMCKDFDFI, object[] AJLJPILGNIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7D86980", Offset = "0x7D85B80", VA = "0x187D86980", Slot = "8")]
	public void PNAGKOGGHJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7D868E0", Offset = "0x7D85AE0", VA = "0x187D868E0", Slot = "7")]
	public void HHNCJNPAAFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public FMDALMBBFJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class AOLOJGLEPON
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7D77FF0", Offset = "0x7D771F0", VA = "0x187D77FF0")]
	public static BNFABCHNBCL CNBPAMBJKEK(this NPGIOFFINPJ LPGODJOFLMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7D78080", Offset = "0x7D77280", VA = "0x187D78080")]
	public static NPGIOFFINPJ LFKBBLILDCK(this BNFABCHNBCL NLIBDKKPKLB)
	{
		return default(NPGIOFFINPJ);
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class RRNetworkBehavior : MonoBehaviour, JODEDGLAHCD, AKANEHHEDBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private bool networkedViewInitialized;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private RRNetworkView networkedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private List<LHNFEEDCLAD> destroyHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private bool isForwarderRegistered;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public ViewId NEJDDDGOOEJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x7D92040", Offset = "0x7D91240", VA = "0x187D92040")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public ViewId NHACCBHKEJB
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x7D92040", Offset = "0x7D91240", VA = "0x187D92040", Slot = "4")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		[Obsolete("Use NetworkedView instead")]
		public RRNetworkView FKBPAPGLMOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x7D920C0", Offset = "0x7D912C0", VA = "0x187D920C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public RRNetworkView LMONFAIDLHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x7D920C0", Offset = "0x7D912C0", VA = "0x187D920C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public BNFABCHNBCL ICAAGAFBIPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x7D921C0", Offset = "0x7D913C0", VA = "0x187D921C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public BNFABCHNBCL IMMAKBDNFNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x7D92520", Offset = "0x7D91720", VA = "0x187D92520")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool CLLKENFLECJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x7D92320", Offset = "0x7D91520", VA = "0x187D92320")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool KANJLEMEBOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x7D92490", Offset = "0x7D91690", VA = "0x187D92490")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool FHMMPHNIHFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x7D91F70", Offset = "0x7D91170", VA = "0x187D91F70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool FGOCBCIOCBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x7D92250", Offset = "0x7D91450", VA = "0x187D92250")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool MNNOAIJDPFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x7D91F70", Offset = "0x7D91170", VA = "0x187D91F70", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool KCOODAFDHLA
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x7D91FF0", Offset = "0x7D911F0", VA = "0x187D91FF0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public string APBKLJGAFEL
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x7D92130", Offset = "0x7D91330", VA = "0x187D92130", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool NAPDJAMAEBH
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x7D91EF0", Offset = "0x7D910F0", VA = "0x187D91EF0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<BNFABCHNBCL> DPNIAIOEDOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x7D91DC0", Offset = "0x7D90FC0", VA = "0x187D91DC0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x7D925B0", Offset = "0x7D917B0", VA = "0x187D925B0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7D91D20", Offset = "0x7D90F20", VA = "0x187D91D20")]
		public bool WasSpawnedForPlayer(int KLFNALEGKPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x70F21B0", Offset = "0x70F13B0", VA = "0x1870F21B0")]
		private void NCBMDDALAKD(RRNetworkView LDINAKFKJDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7D91900", Offset = "0x7D90B00", VA = "0x187D91900", Slot = "9")]
		public void RegisterDestroyHandler(LHNFEEDCLAD LNODHBGPGBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7D91B50", Offset = "0x7D90D50", VA = "0x187D91B50", Slot = "10")]
		public void UnregisterDestroyHandler(LHNFEEDCLAD LNODHBGPGBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "11")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7D918E0", Offset = "0x7D90AE0", VA = "0x187D918E0", Slot = "12")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA02C50", Offset = "0xA01E50", VA = "0x180A02C50")]
		public RRNetworkBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class DGODENOOJMN
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate void MBLPJEEKDDJ([In] BGEDHHKJGFH AJLJPILGNIP, bool DJCFFDOBMFG, bool AMLNMADBOHB, bool HGNIMMIHAGM);

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public delegate void NMNMDEEBINF(GameObject DGGDMAPLALO);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public delegate void NCFGEMDOLBP(GameObject DGGDMAPLALO);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public delegate void APGJJMJLAGI(RRNetworkView PEGCLJNJBJG, string NDKKEIEAJEI, BNFABCHNBCL JHMOIHCLCDG, EIDEGPMEPAM? LBPEJPMBIKP, bool JAIBCLDLNKK, DFOLGABGJMH NNHBIDDPDEK, object[] AJLJPILGNIP, string EMELDIJAEBH);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public delegate void BKDPMHNGELC(RRNetworkView PEGCLJNJBJG, string NDKKEIEAJEI, BNFABCHNBCL JHMOIHCLCDG, EIDEGPMEPAM? LBPEJPMBIKP, bool JAIBCLDLNKK, DFOLGABGJMH NNHBIDDPDEK, object[] AJLJPILGNIP, string EMELDIJAEBH);

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate void OABGJOIKCEP(RRNetworkView PEGCLJNJBJG, string NDKKEIEAJEI, object[] IGDEBNHMJLC, string MDKJHBKMMAJ);

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public delegate void IEHNBKCKILD(RRNetworkView PEGCLJNJBJG, BNFABCHNBCL JHEGCJEKBDE);

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	[CompilerGenerated]
	private static NMNMDEEBINF OJJMIJALKFP;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public static event MBLPJEEKDDJ FPPJPGOHEIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7D83F80", Offset = "0x7D83180", VA = "0x187D83F80")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7D83780", Offset = "0x7D82980", VA = "0x187D83780")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public static event NMNMDEEBINF JHHOHIEHLBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7D84950", Offset = "0x7D83B50", VA = "0x187D84950")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7D83AE0", Offset = "0x7D82CE0", VA = "0x187D83AE0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public static event NCFGEMDOLBP OPFPDIADGKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7D845C0", Offset = "0x7D837C0", VA = "0x187D845C0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7D83D70", Offset = "0x7D82F70", VA = "0x187D83D70")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public static event NCFGEMDOLBP APNALIDELNG
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7D847D0", Offset = "0x7D839D0", VA = "0x187D847D0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7D84890", Offset = "0x7D83A90", VA = "0x187D84890")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public static event APGJJMJLAGI PBOHDACLOKH
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7D84100", Offset = "0x7D83300", VA = "0x187D84100")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7D84280", Offset = "0x7D83480", VA = "0x187D84280")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public static event BKDPMHNGELC BBCCCBCJMDB
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7D84AD0", Offset = "0x7D83CD0", VA = "0x187D84AD0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7D838D0", Offset = "0x7D82AD0", VA = "0x187D838D0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public static event OABGJOIKCEP CGNAPNOAHGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7D841C0", Offset = "0x7D833C0", VA = "0x187D841C0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7D84A10", Offset = "0x7D83C10", VA = "0x187D84A10")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public static event IEHNBKCKILD NEDIBFNMBEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7D84440", Offset = "0x7D83640", VA = "0x187D84440")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7D84500", Offset = "0x7D83700", VA = "0x187D84500")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public static event IEHNBKCKILD AHLIJDOGODE
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7D83990", Offset = "0x7D82B90", VA = "0x187D83990")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7D84040", Offset = "0x7D83240", VA = "0x187D84040")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7D83EC0", Offset = "0x7D830C0", VA = "0x187D83EC0")]
	public static void HODPMGNFDNL([In] BGEDHHKJGFH AJLJPILGNIP, bool DJCFFDOBMFG, bool AMLNMADBOHB, bool HGNIMMIHAGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7D83840", Offset = "0x7D82A40", VA = "0x187D83840")]
	public static void BCICOCEAIGI(GameObject DGGDMAPLALO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7D83A50", Offset = "0x7D82C50", VA = "0x187D83A50")]
	public static void BLAHLPODDHE(GameObject DGGDMAPLALO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7D83BA0", Offset = "0x7D82DA0", VA = "0x187D83BA0")]
	public static void EHEPLIGMOIO(GameObject DGGDMAPLALO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7D83E30", Offset = "0x7D83030", VA = "0x187D83E30")]
	public static void HCPIGGAKAAH(GameObject DGGDMAPLALO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7D84680", Offset = "0x7D83880", VA = "0x187D84680")]
	public static void MOBCJMCMEHD(RRNetworkView PEGCLJNJBJG, string NDKKEIEAJEI, BNFABCHNBCL JHMOIHCLCDG, EIDEGPMEPAM? LBPEJPMBIKP, bool JAIBCLDLNKK, DFOLGABGJMH NNHBIDDPDEK, object[] AJLJPILGNIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7D83C30", Offset = "0x7D82E30", VA = "0x187D83C30")]
	public static void FMDACKFHEFB(RRNetworkView PEGCLJNJBJG, string NDKKEIEAJEI, int PEMBDIJDGFM, object[] IGDEBNHMJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7D84340", Offset = "0x7D83540", VA = "0x187D84340")]
	public static void KPBLNIOEDDO(int LIOACKIDDBK, int LPGODJOFLMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class NHMLOENIKHF
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7D90B40", Offset = "0x7D8FD40", VA = "0x187D90B40")]
	[CanBeNull]
	private static bool OMIKFCLFDDC(ViewId APBCLGNDGBE, [Out] RRNetworkView PEGCLJNJBJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7D90A60", Offset = "0x7D8FC60", VA = "0x187D90A60")]
	[CanBeNull]
	public static Component KIFMFMBIAMD(this ViewId PEGCLJNJBJG, Type OKCFJIKJLLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3B5F4F0", Offset = "0x3B5E6F0", VA = "0x183B5F4F0")]
	[CanBeNull]
	public static T KIFMFMBIAMD<T>(this ViewId PEGCLJNJBJG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3B5F4F0", Offset = "0x3B5E6F0", VA = "0x183B5F4F0")]
	[CanBeNull]
	public static T JBNCACJIJFL<T>(this ViewId PEGCLJNJBJG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3B5F480", Offset = "0x3B5E680", VA = "0x183B5F480")]
	public static bool EKAIINPJPLH<T>(this ViewId PEGCLJNJBJG, [Out] T ACALKMLJJOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7D90990", Offset = "0x7D8FB90", VA = "0x187D90990")]
	[CanBeNull]
	public static RRNetworkView GKOILMFHFNI(this ViewId PEGCLJNJBJG)
	{
		return null;
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class RRNetworkHandler : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static RRNetworkHandler CAABJDKAONG;

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public static bool AppQuits;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		internal static RRNetworkHandler AIBLJDBPKAO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x7D926E0", Offset = "0x7D918E0", VA = "0x187D926E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7D92890", Offset = "0x7D91A90", VA = "0x187D92890")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void StaticReset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7D92850", Offset = "0x7D91A50", VA = "0x187D92850")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0xA02C50", Offset = "0xA01E50", VA = "0x180A02C50")]
		public RRNetworkHandler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[ServiceLifetime(Lifetime.PhotonRoom)]
[RegisterService(typeof(BHJNIPNLGOM), new string[] { "Photon" })]
public sealed class BHJNIPNLGOM : EKNEMDBICPC, PCJOCILCILM, EJADEOIPJPK, KMKODLCHFCF, APJFIENGAAE
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class IPCHFAOOPFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public int requestedViewId;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public IPCHFAOOPFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x7D88BE0", Offset = "0x7D87DE0", VA = "0x187D88BE0")]
		internal object ABOCNEGHMNO((int requestedViewId, int newOwnerId, int senderId) x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private static KEPOMIIOHBM BCKJPAKGDGN;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private static KEPOMIIOHBM MNCLPCBIFME;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private static Dictionary<int, HashSet<int>> BOIENLOABNP;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private static Dictionary<int, int> GAMNJPFIAPB;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private static readonly List<(GameObject GameObject, int ParentCount)> IELMMELKNJE;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static readonly List<GameObject> EIGFEMLIKCC;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static List<int> MAFLCKHOOFL;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static readonly List<RRNetworkView> MLFHPEALNMC;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly FLEPBPAFMND OKPEDMEADGB;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly FLEPBPAFMND KOOEMHAGCMO;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7D7D050", Offset = "0x7D7C250", VA = "0x187D7D050", Slot = "8")]
	public void HHNCJNPAAFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7D82D40", Offset = "0x7D81F40", VA = "0x187D82D40", Slot = "9")]
	public void PNAGKOGGHJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7D7EA00", Offset = "0x7D7DC00", VA = "0x187D7EA00", Slot = "10")]
	public void InitExternal(EENCHNOCEIL BNPCDJLAAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7D830A0", Offset = "0x7D822A0", VA = "0x187D830A0", Slot = "11")]
	public void PNCDLNJKAAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7D81A60", Offset = "0x7D80C60", VA = "0x187D81A60")]
	private void OKIACKHJHEC(NMJOPFNONGB HNNMKPMMDPG, NMJOPFNONGB CKCKEFFHJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7D7C230", Offset = "0x7D7B430", VA = "0x187D7C230")]
	private void DHLDHNHGDIM(BKDNIFFCBID KIIEIHMFPMK, BKDNIFFCBID EPLBECPHPHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7D7F7A0", Offset = "0x7D7E9A0", VA = "0x187D7F7A0")]
	public GameObject KOPCLFHOOEF(string GBOCGPJOEEK, Vector3 FICCENLPJEL, Quaternion NDOBKEDDJAJ, Vector3 GPOEDAABNAL, ViewId LIOACKIDDBK, DDJGKBBEDKH AJLJPILGNIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7D7C720", Offset = "0x7D7B920", VA = "0x187D7C720")]
	public GameObject GGDLOMHFPPN(string GBOCGPJOEEK, Vector3 FICCENLPJEL, Quaternion NDOBKEDDJAJ, float GPOEDAABNAL, object[] AJLJPILGNIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7D7CBE0", Offset = "0x7D7BDE0", VA = "0x187D7CBE0")]
	public GameObject HEKAKLDJPND(string GBOCGPJOEEK, Vector3 FICCENLPJEL, Quaternion NDOBKEDDJAJ, Vector3 GPOEDAABNAL, ViewId PEGCLJNJBJG, DDJGKBBEDKH AJLJPILGNIP, bool HGNIMMIHAGM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7D7ACD0", Offset = "0x7D79ED0", VA = "0x187D7ACD0")]
	public GameObject AEGIODJFFPC(BGEDHHKJGFH AJLJPILGNIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7D7C810", Offset = "0x7D7BA10", VA = "0x187D7C810", Slot = "6")]
	public void HBEDACFLOHM(GameObject DGGDMAPLALO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7D7D690", Offset = "0x7D7C890", VA = "0x187D7D690")]
	public void INBMMHAOHKH(GameObject LBBGHAOMHLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7D7AD00", Offset = "0x7D79F00", VA = "0x187D7AD00", Slot = "7")]
	public void AMDBGGCBEML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x7D7BBB0", Offset = "0x7D7ADB0", VA = "0x187D7BBB0", Slot = "4")]
	public GameObject[] CJBAIEFLNBM(IList<FCAIFKHJLCJ> FLJIMAANFGD, bool EODFBLEEGFK = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7D7C820", Offset = "0x7D7BA20", VA = "0x187D7C820", Slot = "5")]
	public void HCAHAPJKOCC(List<GameObject> EAFNNDGEDKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7D7CED0", Offset = "0x7D7C0D0", VA = "0x187D7CED0")]
	public void HFKAGAJMKKO(GameObject LBBGHAOMHLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7D7EDC0", Offset = "0x7D7DFC0", VA = "0x187D7EDC0")]
	private void KCKMPJKFIDL(HIPDGMOFECH ODLIDIMANGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7D81F80", Offset = "0x7D81180", VA = "0x187D81F80")]
	private void ONINJICPBJG(HIPDGMOFECH ODLIDIMANGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7D7C390", Offset = "0x7D7B590", VA = "0x187D7C390")]
	private void EBFPPPDHBCN(HIPDGMOFECH ODLIDIMANGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7D7D3B0", Offset = "0x7D7C5B0", VA = "0x187D7D3B0")]
	private void IDHGPGENNKO(HIPDGMOFECH ODLIDIMANGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7D82150", Offset = "0x7D81350", VA = "0x187D82150")]
	private void OOKADBONGDB(HIPDGMOFECH ODLIDIMANGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7D7B7B0", Offset = "0x7D7A9B0", VA = "0x187D7B7B0")]
	private void CIEHJPKNBKL(HIPDGMOFECH ODLIDIMANGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7D7AF20", Offset = "0x7D7A120", VA = "0x187D7AF20")]
	private void CCCLGAHNPDM(HIPDGMOFECH ODLIDIMANGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7D7EBD0", Offset = "0x7D7DDD0", VA = "0x187D7EBD0")]
	private GameObject JNGDJLLKAEJ(string FNBPEJBPIPG, Vector3 FICCENLPJEL, Quaternion NDOBKEDDJAJ, Vector3 GPOEDAABNAL, byte IMLPAHMDDDJ = 0, [Optional] object[] CAIGHLKIDBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7D7F0B0", Offset = "0x7D7E2B0", VA = "0x187D7F0B0")]
	private GameObject KEENOKMFCHL(BGEDHHKJGFH AJLJPILGNIP, bool DJCFFDOBMFG = false, bool AMLNMADBOHB = false, bool HGNIMMIHAGM = true, bool GCPNACDNMHC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7D7BEE0", Offset = "0x7D7B0E0", VA = "0x187D7BEE0")]
	private static GameObject CKHBCJEOJMI(string FNBPEJBPIPG, bool OKCMHDPEOPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7D825F0", Offset = "0x7D817F0", VA = "0x187D825F0")]
	private static GameObject PMIGJGPJJAJ(GameObject IJDBKPEJDOI, BGEDHHKJGFH AJLJPILGNIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7D7AE10", Offset = "0x7D7A010", VA = "0x187D7AE10")]
	private static void CAJPKGOPPDJ(GameObject DGGDMAPLALO, RRNetworkView PEGCLJNJBJG, [In] BGEDHHKJGFH AJLJPILGNIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7D81210", Offset = "0x7D80410", VA = "0x187D81210")]
	private GameObject[] OIBEOIIINCK(IList<FCAIFKHJLCJ> FLJIMAANFGD, bool EODFBLEEGFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7D80640", Offset = "0x7D7F840", VA = "0x187D80640")]
	private GameObject[] NINPKCDJPHG(BGEDHHKJGFH[] LGLGPDLJDEE, int PGMOLICBNBD, BNFABCHNBCL NLIBDKKPKLB, GameObject[] IAAJHMNJMOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7D7D700", Offset = "0x7D7C900", VA = "0x187D7D700")]
	private GameObject IPCLHAGEPKA([In] BGEDHHKJGFH AJLJPILGNIP, GameObject IJDBKPEJDOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x70CF200", Offset = "0x70CE400", VA = "0x1870CF200")]
	private static bool FFPGCACHKEG(bool DJCFFDOBMFG, bool HGNIMMIHAGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7D7F980", Offset = "0x7D7EB80", VA = "0x187D7F980")]
	private void LIHIMOCJMDD(IEnumerable<GameObject> EAFNNDGEDKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7D7DB10", Offset = "0x7D7CD10", VA = "0x187D7DB10")]
	private void IPJIPDNGEMD(GameObject DGGDMAPLALO, bool GCPNACDNMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7D81B80", Offset = "0x7D80D80", VA = "0x187D81B80")]
	private static void OMMBDMBDDCM(IEnumerable<GameObject> LGFFBKOOLNK, List<(GameObject GameObject, int ParentCount)> JCIPNHJPHFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7D808E0", Offset = "0x7D7FAE0", VA = "0x187D808E0")]
	private void ODADPGLBJCO(int AMMEGBDPGDG, int PGMOLICBNBD, bool GCPNACDNMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7D805A0", Offset = "0x7D7F7A0", VA = "0x187D805A0")]
	private static int NGAKNBMMBPI(int AMMEGBDPGDG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x7D7CE70", Offset = "0x7D7C070", VA = "0x187D7CE70")]
	private void HFAIEBCGALG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7D82800", Offset = "0x7D81A00", VA = "0x187D82800")]
	private void PMKPAGFPHFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7D7C330", Offset = "0x7D7B530", VA = "0x187D7C330")]
	private static int DJLFJOAIPEP(int GHFBKGEIFAF, bool HGNIMMIHAGM = true)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7D7C640", Offset = "0x7D7B840", VA = "0x187D7C640")]
	private static int[] GBLKMFGALEO(int IDGPDFFPHOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7D7AD10", Offset = "0x7D79F10", VA = "0x187D7AD10")]
	private static int[] BKFOABHIOEJ(int IMMAKBDNFNI, int IDGPDFFPHOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7D83270", Offset = "0x7D82470", VA = "0x187D83270")]
	private void PONJHEFHAJM(BNFABCHNBCL AHEOAPACCIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x7D80A40", Offset = "0x7D7FC40", VA = "0x187D80A40")]
	private void OGBGADGDLEC(BNFABCHNBCL NLIBDKKPKLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x7D7BF60", Offset = "0x7D7B160", VA = "0x187D7BF60")]
	private void DFDOLLMBGDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7D7B570", Offset = "0x7D7A770", VA = "0x187D7B570")]
	private void CEFDEILKLFM(BNFABCHNBCL NLIBDKKPKLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7D7CFB0", Offset = "0x7D7C1B0", VA = "0x187D7CFB0")]
	private static void HHGCMEEEHPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7D824F0", Offset = "0x7D816F0", VA = "0x187D824F0")]
	private void PLACIGIFGKD(int[] EMEFMAKHNGG, int AJPFPDLGMHJ = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public BHJNIPNLGOM()
	{
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class RRNetworkProfiler : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xA02C50", Offset = "0xA01E50", VA = "0x180A02C50")]
		public RRNetworkProfiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[ServiceLifetime(Lifetime.PhotonRoom)]
[RegisterService(typeof(NGIKEHGOHEB), new string[] { "Photon" })]
public class NGIKEHGOHEB : PCJOCILCILM, EJADEOIPJPK, ODBPINNLJME
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct KOPHOIDDCOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public readonly MethodInfo NLPHMHIOGHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly Func<MonoBehaviour, object> DGEFKHNNLCM;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xB268B0", Offset = "0xB25AB0", VA = "0x180B268B0")]
		public KOPHOIDDCOK(MethodInfo NLPHMHIOGHN, [Optional] Func<MonoBehaviour, object> DGEFKHNNLCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x70D8CB0", Offset = "0x70D7EB0", VA = "0x1870D8CB0")]
		public object FHDLELEPBAK(MonoBehaviour NAHLNCEPPJC)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class COBJKANDGKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public FieldInfo instanceAccessFromField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Func<MonoBehaviour, object> <>9__4;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public COBJKANDGKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7D836B0", Offset = "0x7D828B0", VA = "0x187D836B0")]
		internal KOPHOIDDCOK EEEGAFOINLF(MethodInfo methodInfo)
		{
			return default(KOPHOIDDCOK);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x4766570", Offset = "0x4765770", VA = "0x184766570")]
		internal object PKAIGJJLKKM(MonoBehaviour mb)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class FCAJDEMDMDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public Func<MonoBehaviour, object> accessor;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public FCAJDEMDMDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x70D92F0", Offset = "0x70D84F0", VA = "0x1870D92F0")]
		internal KOPHOIDDCOK ABNCJIAHLPI(MethodInfo methodInfo)
		{
			return default(KOPHOIDDCOK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class BKIKAEGHHBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public Type attributeType;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public BKIKAEGHHBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7D83670", Offset = "0x7D82870", VA = "0x187D83670")]
		internal bool KONGCGMEDEN(MethodInfo m)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly KEPOMIIOHBM EBHKLAMEJCE;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly Stopwatch MDMJGAHODNP;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static Dictionary<MethodInfo, ParameterInfo[]> OANENJAIDGI;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static readonly Dictionary<Type, List<KOPHOIDDCOK>> KIBENCCCPBD;

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7D8D3C0", Offset = "0x7D8C5C0", VA = "0x187D8D3C0", Slot = "4")]
	public void HHNCJNPAAFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x7D906C0", Offset = "0x7D8F8C0", VA = "0x187D906C0", Slot = "5")]
	public void PNAGKOGGHJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x7D8D510", Offset = "0x7D8C710", VA = "0x187D8D510")]
	private void KCKMPJKFIDL(HIPDGMOFECH ODLIDIMANGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x7D90690", Offset = "0x7D8F890", VA = "0x187D90690", Slot = "9")]
	public string PJGHMIMDAMN(HIPDGMOFECH ODLIDIMANGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7D8D1E0", Offset = "0x7D8C3E0", VA = "0x187D8D1E0", Slot = "8")]
	public void DCNMGHMLAEM(ViewId LIOACKIDDBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x7D8CC00", Offset = "0x7D8BE00", VA = "0x187D8CC00", Slot = "6")]
	public void BHDCMHCCFCG(ViewId PEGCLJNJBJG, string NDKKEIEAJEI, BNFABCHNBCL NLIBDKKPKLB, DFOLGABGJMH NNHBIDDPDEK, params object[] AJLJPILGNIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x7D8CCD0", Offset = "0x7D8BED0", VA = "0x187D8CCD0", Slot = "7")]
	public void BHDCMHCCFCG(ViewId PEGCLJNJBJG, string NDKKEIEAJEI, EIDEGPMEPAM LBPEJPMBIKP, DFOLGABGJMH NNHBIDDPDEK, params object[] AJLJPILGNIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x7D8CD00", Offset = "0x7D8BF00", VA = "0x187D8CD00")]
	private void BHDCMHCCFCG(ViewId PEGCLJNJBJG, string NDKKEIEAJEI, EIDEGPMEPAM LBPEJPMBIKP, BNFABCHNBCL NLIBDKKPKLB, DFOLGABGJMH NNHBIDDPDEK, params object[] AJLJPILGNIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x7D8D8D0", Offset = "0x7D8CAD0", VA = "0x187D8D8D0")]
	private void MHGHBKLBAEN(ViewId LIOACKIDDBK, string NDKKEIEAJEI, BNFABCHNBCL GCPKMNCMKPP, int DCLDCHKGEFO, object[] IGDEBNHMJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7D8F5E0", Offset = "0x7D8E7E0", VA = "0x187D8F5E0")]
	private static void NGFDAFBDAIG(KOPHOIDDCOK HHDOKFFBPDP, MonoBehaviour IBDHPIHNGGE, object[] CCEPNMMABPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x7D8FA70", Offset = "0x7D8EC70", VA = "0x187D8FA70")]
	private static bool OMBMKJOCHIN(ParameterInfo[] DEMBLIAJJLC, Type[] HCFOOCNIABF, [Out] bool ABBHFFAEFMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x7D8FCA0", Offset = "0x7D8EEA0", VA = "0x187D8FCA0")]
	private List<KOPHOIDDCOK> PGCHOADDPDO(MonoBehaviour IBDHPIHNGGE, Type DCJDKHGGDHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x7D8D2C0", Offset = "0x7D8C4C0", VA = "0x187D8D2C0")]
	private static IEnumerable<MethodInfo> FPKEBGGHIKH(Type GDHKDBJPDLG, Type MAMHOPOBMAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x7D8D7C0", Offset = "0x7D8C9C0", VA = "0x187D8D7C0")]
	public static ParameterInfo[] KIDDGGFEOFC(MethodInfo IODBEPPMLID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public NGIKEHGOHEB()
	{
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class RRNetworkView : MonoBehaviour, AMDJOLLNHGD, DIJGCPMDLBC, GNLFIEKGJKB, FCCLCKGFKHO, KGGENHHCLLF
	{
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public enum KEHMPFNGHFF
		{
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			False,
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			True_SetInSceneForRoom,
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			True_ManuallySetInPrefab
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private sealed class AEPLMGNFALE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			public int actorNumber;

			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
			public AEPLMGNFALE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x7D77F90", Offset = "0x7D77190", VA = "0x187D77F90")]
			internal bool OEPLNJKKNAA(RRNetworkView view)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static Dictionary<int, RRNetworkView> KFLDABIOHJN;

		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private static FLEPBPAFMND LHBAEHIOIJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[SerializeField]
		private int viewIdField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[SerializeField]
		private int instantiationIdField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private bool MEDMBCMDPAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		internal bool MILFPPDNAKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[Tooltip("By default, prefabs cannot contain hard coded values for viewIdField; singletons that need to have consistent viewIdField across clients may set this flag to disable automatic cleaning of the property viewIdField")]
		[SerializeField]
		public KEHMPFNGHFF hasExplicitViewId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private bool KIJLHNDHFMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private bool CEFILJEKJJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int DLBIJFGNGPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private bool DAPIPPNJDJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private int FBBNMJGLEAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private BNFABCHNBCL IMMAKBDNFNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private BNFABCHNBCL IBOHFAKIHAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private bool? GEDJCDKKHME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private bool OPKPCNFEGCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		internal bool ADPKOOGNLCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		internal MonoBehaviour[] HMPAGOKJAJB;

		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private static readonly KEPOMIIOHBM DIJOFNAGOFB;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public ViewId NHACCBHKEJB
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x7D97B20", Offset = "0x7D96D20", VA = "0x187D97B20")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public ViewId LMKPGOKNJNM
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x7D97B20", Offset = "0x7D96D20", VA = "0x187D97B20", Slot = "5")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public ViewId NEJDDDGOOEJ
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x7D97B20", Offset = "0x7D96D20", VA = "0x187D97B20")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public int CEEHKHFDHHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0xA09790", Offset = "0xA08990", VA = "0x180A09790")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0xA09780", Offset = "0xA08980", VA = "0x180A09780")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int KKCBKEFFNKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0xA29CC0", Offset = "0xA28EC0", VA = "0x180A29CC0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0xDCB700", Offset = "0xDCA900", VA = "0x180DCB700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public ViewId MPCOCEGGMHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x7D97990", Offset = "0x7D96B90", VA = "0x187D97990")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool INIHEKNIGFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0xA0D3F0", Offset = "0xA0C5F0", VA = "0x180A0D3F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xA0D640", Offset = "0xA0C840", VA = "0x180A0D640")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool BDGGNGLPBGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x7D979A0", Offset = "0x7D96BA0", VA = "0x187D979A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool HMJIMOPNBPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0xA674A0", Offset = "0xA666A0", VA = "0x180A674A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0xA671B0", Offset = "0xA663B0", VA = "0x180A671B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int ABNPNIOHIGC
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0xCB7D00", Offset = "0xCB6F00", VA = "0x180CB7D00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int ELHEHPPCKDM
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x7D97930", Offset = "0x7D96B30", VA = "0x187D97930")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public BNFABCHNBCL NCADABIPGMI
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x7D97B30", Offset = "0x7D96D30", VA = "0x187D97B30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public BNFABCHNBCL NPOLFLDAKCG
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x7D97900", Offset = "0x7D96B00", VA = "0x187D97900")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public BNFABCHNBCL ICAAGAFBIPM
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x7D97900", Offset = "0x7D96B00", VA = "0x187D97900")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public BNFABCHNBCL JGPIHEGNHPM
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x7D97900", Offset = "0x7D96B00", VA = "0x187D97900")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool MMALIOHFLAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x7D97A70", Offset = "0x7D96C70", VA = "0x187D97A70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public int KIPNPFKICKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x7D97960", Offset = "0x7D96B60", VA = "0x187D97960")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public object[] BLNBIMCDPLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xA0D650", Offset = "0xA0C850", VA = "0x180A0D650")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xA0D3D0", Offset = "0xA0C5D0", VA = "0x180A0D3D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool CLLKENFLECJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x7D97B60", Offset = "0x7D96D60", VA = "0x187D97B60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool GOHPHGLDPAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x7D97AF0", Offset = "0x7D96CF0", VA = "0x187D97AF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool PABGIEGOABI
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0xD93990", Offset = "0xD92B90", VA = "0x180D93990")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0xEE30D0", Offset = "0xEE22D0", VA = "0x180EE30D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool FNNFICHJMJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0xC503D0", Offset = "0xC4F5D0", VA = "0x180C503D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<RRNetworkView> FNLAPGEMGON
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x7D977A0", Offset = "0x7D969A0", VA = "0x187D977A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x7D97D20", Offset = "0x7D96F20", VA = "0x187D97D20")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		private event Action<BNFABCHNBCL> IGPJPMLCKMF
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x7D929D0", Offset = "0x7D91BD0", VA = "0x187D929D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x7D93AC0", Offset = "0x7D92CC0", VA = "0x187D93AC0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		public event Action<BNFABCHNBCL> OJGKFKJODIK
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x7D929D0", Offset = "0x7D91BD0", VA = "0x187D929D0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x7D93AC0", Offset = "0x7D92CC0", VA = "0x187D93AC0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		private event Action<int> AKOEAGJCACN
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x7D93FE0", Offset = "0x7D931E0", VA = "0x187D93FE0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x7D940A0", Offset = "0x7D932A0", VA = "0x187D940A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		public event Action<int> DDBNNBENFHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x7D93FE0", Offset = "0x7D931E0", VA = "0x187D93FE0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x7D940A0", Offset = "0x7D932A0", VA = "0x187D940A0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		public event Action<RRNetworkView> ICNPLLJNIPL
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x7D97850", Offset = "0x7D96A50", VA = "0x187D97850")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x7D97DD0", Offset = "0x7D96FD0", VA = "0x187D97DD0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		public event Action PCMFHGMCCEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x7D976F0", Offset = "0x7D968F0", VA = "0x187D976F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x7D97C70", Offset = "0x7D96E70", VA = "0x187D97C70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7D97530", Offset = "0x7D96730", VA = "0x187D97530")]
		public static bool TryGetNetworkView(int LIOACKIDDBK, [Out] RRNetworkView PEGCLJNJBJG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x7D93680", Offset = "0x7D92880", VA = "0x187D93680")]
		public static RRNetworkView Find(int LIOACKIDDBK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7D93840", Offset = "0x7D92A40", VA = "0x187D93840")]
		public static IEnumerable<RRNetworkView> GetCreatedAndOwnedNetworkViews(int CBKLGKPCDOO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7D937D0", Offset = "0x7D929D0", VA = "0x187D937D0")]
		public static IEnumerable<RRNetworkView> GetAllNetworkViews()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7D94CA0", Offset = "0x7D93EA0", VA = "0x187D94CA0")]
		public static bool RemoveNetworkView(RRNetworkView PEGCLJNJBJG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7D94A70", Offset = "0x7D93C70", VA = "0x187D94A70")]
		public static void RebuildControllCacheForAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7D94500", Offset = "0x7D93700", VA = "0x187D94500")]
		public static void OnPlayerJoinedRoom(BNFABCHNBCL HHIKBHALDAA, List<int> EMEFMAKHNGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7D93980", Offset = "0x7D92B80", VA = "0x187D93980")]
		public static RRNetworkView Get(Component JCAGDPHNPIB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7D939E0", Offset = "0x7D92BE0", VA = "0x187D939E0")]
		public static RRNetworkView Get(GameObject EFHMNLOJPHO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7D941C0", Offset = "0x7D933C0", VA = "0x187D941C0")]
		private void OMMGPMDDKOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x7D92E60", Offset = "0x7D92060", VA = "0x187D92E60")]
		public bool CreatedBy(BNFABCHNBCL NLIBDKKPKLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x7D97340", Offset = "0x7D96540", VA = "0x187D97340")]
		public void TransferOwnership(int NEKNAMBEGKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7D972E0", Offset = "0x7D964E0", VA = "0x187D972E0")]
		public void TransferOwnership(BNFABCHNBCL JHEGCJEKBDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7D93B70", Offset = "0x7D92D70", VA = "0x187D93B70", Slot = "4")]
		public void Initialize(ViewId NFNHBFGEPBF, ViewId LAGMIMGOKAI, Dictionary<int, object> MGGGOEHGEIK, NPGIOFFINPJ IMMAKBDNFNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7D93CF0", Offset = "0x7D92EF0", VA = "0x187D93CF0")]
		public void Initialize(ViewId NFNHBFGEPBF, ViewId LAGMIMGOKAI, object[] FHMMCGGPAAE, NPGIOFFINPJ IMMAKBDNFNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7D92970", Offset = "0x7D91B70", VA = "0x187D92970")]
		protected internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7D93DF0", Offset = "0x7D92FF0", VA = "0x187D93DF0")]
		private void KHBHEFHNFGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x1E6AD20", Offset = "0x1E69F20", VA = "0x181E6AD20")]
		internal void JBKADBCGGIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x7D942A0", Offset = "0x7D934A0", VA = "0x187D942A0", Slot = "6")]
		private void ONOKPOHOIGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x7D94150", Offset = "0x7D93350", VA = "0x187D94150")]
		internal bool OEBPHDDBJHP(RRNetworkView FEHBEFBEKKN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x7D94360", Offset = "0x7D93560", VA = "0x187D94360")]
		protected internal void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x7D92B90", Offset = "0x7D91D90", VA = "0x187D92B90")]
		internal void CLDGFEJKBCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7D94090", Offset = "0x7D93290", VA = "0x187D94090")]
		private void NDIJMGDCFJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7D93710", Offset = "0x7D92910", VA = "0x187D93710")]
		internal void GCEKBNPHFJG(BNFABCHNBCL JHEGCJEKBDE, int NEKNAMBEGKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x7D94C00", Offset = "0x7D93E00", VA = "0x187D94C00")]
		public void RebuildControllerCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x7D94D20", Offset = "0x7D93F20", VA = "0x187D94D20")]
		public void ResetOwnership()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x7D92AF0", Offset = "0x7D91CF0", VA = "0x187D92AF0")]
		private void CIMGBINHAEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x7D93590", Offset = "0x7D92790", VA = "0x187D93590")]
		private void FKKCIFFNKBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x7D94950", Offset = "0x7D93B50", VA = "0x187D94950")]
		public void RPC(string NDKKEIEAJEI, EIDEGPMEPAM LBPEJPMBIKP, params object[] AJLJPILGNIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x7D949E0", Offset = "0x7D93BE0", VA = "0x187D949E0")]
		public void RPC(string NDKKEIEAJEI, BNFABCHNBCL JHMOIHCLCDG, params object[] AJLJPILGNIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x7D94C50", Offset = "0x7D93E50", VA = "0x187D94C50")]
		public void RefreshRpcMonoBehaviourCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x7D92A80", Offset = "0x7D91C80", VA = "0x187D92A80", Slot = "8")]
		public void Bake(FDMFIFPHKJP BKDMJHGCDEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x7D93A40", Offset = "0x7D92C40", VA = "0x187D93A40")]
		private static void HJODPPNMOHO(BNFABCHNBCL NKEACAOKBCJ, [Out] BNFABCHNBCL MCHIEDFKOJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7D92EE0", Offset = "0x7D920E0", VA = "0x187D92EE0")]
		private static void DEAKBMELAJA(RRNetworkView FKBPAPGLMOF, Delegate HHDOKFFBPDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x7D93350", Offset = "0x7D92550", VA = "0x187D93350")]
		private static GIKIDEGCBCI ENCNACBOABF(RRNetworkView FKBPAPGLMOF)
		{
			return default(GIKIDEGCBCI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7D928D0", Offset = "0x7D91AD0", VA = "0x187D928D0")]
		private static NIHFGKDLNDI AIILGDBMGOE(RRNetworkView FKBPAPGLMOF)
		{
			return default(NIHFGKDLNDI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x7D933D0", Offset = "0x7D925D0", VA = "0x187D933D0")]
		private static void ENDKLCLEMPI(RRNetworkView FKBPAPGLMOF, Delegate HHDOKFFBPDP, BNFABCHNBCL GJFJKCMGAHM, params object[] AJLJPILGNIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x7D934B0", Offset = "0x7D926B0", VA = "0x187D934B0")]
		private static void ENDKLCLEMPI(RRNetworkView FKBPAPGLMOF, Delegate HHDOKFFBPDP, EIDEGPMEPAM GJFJKCMGAHM, params object[] AJLJPILGNIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x7D93200", Offset = "0x7D92400", VA = "0x187D93200")]
		private static void EJCHLPIFHLA(RRNetworkView FKBPAPGLMOF, Delegate HHDOKFFBPDP, EIDEGPMEPAM GJFJKCMGAHM, IDHPEHKKLEL DGCDMNEODKB, params object[] AJLJPILGNIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x7D94850", Offset = "0x7D93A50", VA = "0x187D94850")]
		public void RPCBuffered(string NDKKEIEAJEI, EIDEGPMEPAM LBPEJPMBIKP, IDHPEHKKLEL NNHBIDDPDEK, params object[] AJLJPILGNIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7D93D50", Offset = "0x7D92F50", VA = "0x187D93D50")]
		private static bool JJNJAFAOHJE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7D953A0", Offset = "0x7D945A0", VA = "0x187D953A0", Slot = "26")]
		public void RpcAll(PLFIBMEPEJL.KDJHBMICHHD HHDOKFFBPDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x3C72A60", Offset = "0x3C71C60", VA = "0x183C72A60", Slot = "9")]
		public void RpcAll<T1>(PLFIBMEPEJL.JAMCMLIMLGH<T1> HHDOKFFBPDP, T1 DGDONNHKDHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x3C722B0", Offset = "0x3C714B0", VA = "0x183C722B0", Slot = "10")]
		public void RpcAll<T1, T2>(PLFIBMEPEJL.JLHFHGLHKCK<T1, T2> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x3C73E50", Offset = "0x3C73050", VA = "0x183C73E50", Slot = "27")]
		public void RpcAll<T1, T2, T3>(PLFIBMEPEJL.IKNMOKALHEO<T1, T2, T3> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x3C724D0", Offset = "0x3C716D0", VA = "0x183C724D0", Slot = "28")]
		public void RpcAll<T1, T2, T3, T4>(PLFIBMEPEJL.LGFOENKEGMH<T1, T2, T3, T4> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x3C73800", Offset = "0x3C72A00", VA = "0x183C73800", Slot = "29")]
		public void RpcAll<T1, T2, T3, T4, T5>(PLFIBMEPEJL.HEEBAHHJIEC<T1, T2, T3, T4, T5> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x3C74350", Offset = "0x3C73550", VA = "0x183C74350", Slot = "30")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(PLFIBMEPEJL.KOMLIFDIAIL<T1, T2, T3, T4, T5, T6> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x3C74E40", Offset = "0x3C74040", VA = "0x183C74E40", Slot = "11")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(PLFIBMEPEJL.HIHGCKMDIGF<T1, T2, T3, T4, T5, T6, T7> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x3C79900", Offset = "0x3C78B00", VA = "0x183C79900", Slot = "12")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(PLFIBMEPEJL.NIIOGJFKOCA<T1, T2, T3, T4, T5, T6, T7, T8> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x3C74800", Offset = "0x3C73A00", VA = "0x183C74800", Slot = "31")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(PLFIBMEPEJL.IELFFLPENFG<T1, T2, T3, T4, T5, T6, T7, T8, T9> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x3C72BF0", Offset = "0x3C71DF0", VA = "0x183C72BF0", Slot = "13")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(JOJJLNNFJHI HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x3C9DBF0", Offset = "0x3C9CDF0", VA = "0x183C9DBF0", Slot = "32")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(FOKADDBHABI HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x3C9D660", Offset = "0x3C9C860", VA = "0x183C9D660", Slot = "33")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(DFAFKNHMIPJ HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x3C9BE80", Offset = "0x3C9B080", VA = "0x183C9BE80", Slot = "34")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(DOHBPOHOONN HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA, T13 JIPNGHJEIMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x3C99B80", Offset = "0x3C98D80", VA = "0x183C99B80", Slot = "35")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(GEBFKAKOJFA HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA, T13 JIPNGHJEIMA, T14 COFFOAJAMMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x7D95740", Offset = "0x7D94940", VA = "0x187D95740")]
		public void RpcAll(PLFIBMEPEJL.JAMCMLIMLGH<GIKIDEGCBCI> HHDOKFFBPDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x3C76EC0", Offset = "0x3C760C0", VA = "0x183C76EC0")]
		public void RpcAll<T1>(PLFIBMEPEJL.JLHFHGLHKCK<T1, GIKIDEGCBCI> HHDOKFFBPDP, T1 DGDONNHKDHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x3C77AF0", Offset = "0x3C76CF0", VA = "0x183C77AF0")]
		public void RpcAll<T1, T2>(PLFIBMEPEJL.IKNMOKALHEO<T1, T2, GIKIDEGCBCI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3C734E0", Offset = "0x3C726E0", VA = "0x183C734E0")]
		public void RpcAll<T1, T2, T3>(PLFIBMEPEJL.LGFOENKEGMH<T1, T2, T3, GIKIDEGCBCI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x3C820F0", Offset = "0x3C812F0", VA = "0x183C820F0")]
		public void RpcAll<T1, T2, T3, T4>(PLFIBMEPEJL.HEEBAHHJIEC<T1, T2, T3, T4, GIKIDEGCBCI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x3C818C0", Offset = "0x3C80AC0", VA = "0x183C818C0")]
		public void RpcAll<T1, T2, T3, T4, T5>(PLFIBMEPEJL.KOMLIFDIAIL<T1, T2, T3, T4, T5, GIKIDEGCBCI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x3C80C00", Offset = "0x3C7FE00", VA = "0x183C80C00")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(PLFIBMEPEJL.HIHGCKMDIGF<T1, T2, T3, T4, T5, T6, GIKIDEGCBCI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x3C80190", Offset = "0x3C7F390", VA = "0x183C80190")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(PLFIBMEPEJL.NIIOGJFKOCA<T1, T2, T3, T4, T5, T6, T7, GIKIDEGCBCI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x3C7F5B0", Offset = "0x3C7E7B0", VA = "0x183C7F5B0")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(PLFIBMEPEJL.IELFFLPENFG<T1, T2, T3, T4, T5, T6, T7, T8, GIKIDEGCBCI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x3C7E410", Offset = "0x3C7D610", VA = "0x183C7E410")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(JOJJLNNFJHI HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x3C7D550", Offset = "0x3C7C750", VA = "0x183C7D550")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(FOKADDBHABI HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x3C7CA90", Offset = "0x3C7BC90", VA = "0x183C7CA90")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(DFAFKNHMIPJ HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x3C9D090", Offset = "0x3C9C290", VA = "0x183C9D090")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(DOHBPOHOONN HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x3C9C480", Offset = "0x3C9B680", VA = "0x183C9C480")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(GEBFKAKOJFA HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA, T13 JIPNGHJEIMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x3C9A470", Offset = "0x3C99670", VA = "0x183C9A470")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ICNEIGCHPGL HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA, T13 JIPNGHJEIMA, T14 COFFOAJAMMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7D95510", Offset = "0x7D94710", VA = "0x187D95510", Slot = "36")]
		public void RpcAll(PLFIBMEPEJL.JAMCMLIMLGH<NIHFGKDLNDI> HHDOKFFBPDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x3C85E20", Offset = "0x3C85020", VA = "0x183C85E20", Slot = "37")]
		public void RpcAll<T1>(PLFIBMEPEJL.JLHFHGLHKCK<T1, NIHFGKDLNDI> HHDOKFFBPDP, T1 DGDONNHKDHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x3C84330", Offset = "0x3C83530", VA = "0x183C84330", Slot = "38")]
		public void RpcAll<T1, T2>(PLFIBMEPEJL.IKNMOKALHEO<T1, T2, NIHFGKDLNDI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x3C82E20", Offset = "0x3C82020", VA = "0x183C82E20", Slot = "39")]
		public void RpcAll<T1, T2, T3>(PLFIBMEPEJL.LGFOENKEGMH<T1, T2, T3, NIHFGKDLNDI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x3C81BD0", Offset = "0x3C80DD0", VA = "0x183C81BD0", Slot = "40")]
		public void RpcAll<T1, T2, T3, T4>(PLFIBMEPEJL.HEEBAHHJIEC<T1, T2, T3, T4, NIHFGKDLNDI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x3C812E0", Offset = "0x3C804E0", VA = "0x183C812E0", Slot = "41")]
		public void RpcAll<T1, T2, T3, T4, T5>(PLFIBMEPEJL.KOMLIFDIAIL<T1, T2, T3, T4, T5, NIHFGKDLNDI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x3C80F70", Offset = "0x3C80170", VA = "0x183C80F70", Slot = "42")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(PLFIBMEPEJL.HIHGCKMDIGF<T1, T2, T3, T4, T5, T6, NIHFGKDLNDI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x3C7FDD0", Offset = "0x3C7EFD0", VA = "0x183C7FDD0", Slot = "43")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(PLFIBMEPEJL.NIIOGJFKOCA<T1, T2, T3, T4, T5, T6, T7, NIHFGKDLNDI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x3C7F180", Offset = "0x3C7E380", VA = "0x183C7F180", Slot = "44")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(PLFIBMEPEJL.IELFFLPENFG<T1, T2, T3, T4, T5, T6, T7, T8, NIHFGKDLNDI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3C7E8A0", Offset = "0x3C7DAA0", VA = "0x183C7E8A0", Slot = "45")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(JOJJLNNFJHI HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3C7DF10", Offset = "0x3C7D110", VA = "0x183C7DF10", Slot = "46")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(FOKADDBHABI HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3C7CFF0", Offset = "0x3C7C1F0", VA = "0x183C7CFF0", Slot = "47")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(DFAFKNHMIPJ HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3C9CAC0", Offset = "0x3C9BCC0", VA = "0x183C9CAC0", Slot = "48")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(DOHBPOHOONN HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x3C9B840", Offset = "0x3C9AA40", VA = "0x183C9B840", Slot = "49")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(GEBFKAKOJFA HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA, T13 JIPNGHJEIMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x3C9AB20", Offset = "0x3C99D20", VA = "0x183C9AB20", Slot = "50")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ICNEIGCHPGL HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA, T13 JIPNGHJEIMA, T14 COFFOAJAMMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x7D95010", Offset = "0x7D94210", VA = "0x187D95010", Slot = "51")]
		public void RpcAllViaServer(PLFIBMEPEJL.KDJHBMICHHD HHDOKFFBPDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x3C99850", Offset = "0x3C98A50", VA = "0x183C99850", Slot = "52")]
		public void RpcAllViaServer<T1>(PLFIBMEPEJL.JAMCMLIMLGH<T1> HHDOKFFBPDP, T1 DGDONNHKDHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3C913B0", Offset = "0x3C905B0", VA = "0x183C913B0", Slot = "14")]
		public void RpcAllViaServer<T1, T2>(PLFIBMEPEJL.JLHFHGLHKCK<T1, T2> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x3C98F20", Offset = "0x3C98120", VA = "0x183C98F20", Slot = "53")]
		public void RpcAllViaServer<T1, T2, T3>(PLFIBMEPEJL.IKNMOKALHEO<T1, T2, T3> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x3C98D10", Offset = "0x3C97F10", VA = "0x183C98D10", Slot = "54")]
		public void RpcAllViaServer<T1, T2, T3, T4>(PLFIBMEPEJL.LGFOENKEGMH<T1, T2, T3, T4> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3C981D0", Offset = "0x3C973D0", VA = "0x183C981D0", Slot = "55")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(PLFIBMEPEJL.HEEBAHHJIEC<T1, T2, T3, T4, T5> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x3C97C70", Offset = "0x3C96E70", VA = "0x183C97C70", Slot = "56")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(PLFIBMEPEJL.KOMLIFDIAIL<T1, T2, T3, T4, T5, T6> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3C973C0", Offset = "0x3C965C0", VA = "0x183C973C0", Slot = "57")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(PLFIBMEPEJL.HIHGCKMDIGF<T1, T2, T3, T4, T5, T6, T7> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x3C96A20", Offset = "0x3C95C20", VA = "0x183C96A20", Slot = "58")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(PLFIBMEPEJL.NIIOGJFKOCA<T1, T2, T3, T4, T5, T6, T7, T8> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x3C96330", Offset = "0x3C95530", VA = "0x183C96330", Slot = "59")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(PLFIBMEPEJL.IELFFLPENFG<T1, T2, T3, T4, T5, T6, T7, T8, T9> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x3C95410", Offset = "0x3C94610", VA = "0x183C95410", Slot = "60")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(JOJJLNNFJHI HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x3C947A0", Offset = "0x3C939A0", VA = "0x183C947A0", Slot = "61")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(FOKADDBHABI HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3C935B0", Offset = "0x3C927B0", VA = "0x183C935B0", Slot = "62")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(DFAFKNHMIPJ HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3C926E0", Offset = "0x3C918E0", VA = "0x183C926E0", Slot = "63")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(DOHBPOHOONN HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA, T13 JIPNGHJEIMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x3C91720", Offset = "0x3C90920", VA = "0x183C91720", Slot = "64")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(GEBFKAKOJFA HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA, T13 JIPNGHJEIMA, T14 COFFOAJAMMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x7D95270", Offset = "0x7D94470", VA = "0x187D95270")]
		public void RpcAllViaServer(PLFIBMEPEJL.JAMCMLIMLGH<GIKIDEGCBCI> HHDOKFFBPDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x3C99A70", Offset = "0x3C98C70", VA = "0x183C99A70")]
		public void RpcAllViaServer<T1>(PLFIBMEPEJL.JLHFHGLHKCK<T1, GIKIDEGCBCI> HHDOKFFBPDP, T1 DGDONNHKDHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x3C996F0", Offset = "0x3C988F0", VA = "0x183C996F0")]
		public void RpcAllViaServer<T1, T2>(PLFIBMEPEJL.IKNMOKALHEO<T1, T2, GIKIDEGCBCI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x3C990D0", Offset = "0x3C982D0", VA = "0x183C990D0")]
		public void RpcAllViaServer<T1, T2, T3>(PLFIBMEPEJL.LGFOENKEGMH<T1, T2, T3, GIKIDEGCBCI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x3C98B00", Offset = "0x3C97D00", VA = "0x183C98B00")]
		public void RpcAllViaServer<T1, T2, T3, T4>(PLFIBMEPEJL.HEEBAHHJIEC<T1, T2, T3, T4, GIKIDEGCBCI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x3C98430", Offset = "0x3C97630", VA = "0x183C98430")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(PLFIBMEPEJL.KOMLIFDIAIL<T1, T2, T3, T4, T5, GIKIDEGCBCI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x3C97F20", Offset = "0x3C97120", VA = "0x183C97F20")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(PLFIBMEPEJL.HIHGCKMDIGF<T1, T2, T3, T4, T5, T6, GIKIDEGCBCI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x3C970C0", Offset = "0x3C962C0", VA = "0x183C970C0")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(PLFIBMEPEJL.NIIOGJFKOCA<T1, T2, T3, T4, T5, T6, T7, GIKIDEGCBCI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x3C96D70", Offset = "0x3C95F70", VA = "0x183C96D70")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(PLFIBMEPEJL.IELFFLPENFG<T1, T2, T3, T4, T5, T6, T7, T8, GIKIDEGCBCI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x3C95BF0", Offset = "0x3C94DF0", VA = "0x183C95BF0")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(JOJJLNNFJHI HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x3C95800", Offset = "0x3C94A00", VA = "0x183C95800")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(FOKADDBHABI HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x3C94BE0", Offset = "0x3C93DE0", VA = "0x183C94BE0")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(DFAFKNHMIPJ HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x3C93ED0", Offset = "0x3C930D0", VA = "0x183C93ED0")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(DOHBPOHOONN HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x3C92BD0", Offset = "0x3C91DD0", VA = "0x183C92BD0")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(GEBFKAKOJFA HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA, T13 JIPNGHJEIMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3C91C60", Offset = "0x3C90E60", VA = "0x183C91C60")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ICNEIGCHPGL HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA, T13 JIPNGHJEIMA, T14 COFFOAJAMMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x7D95140", Offset = "0x7D94340", VA = "0x187D95140", Slot = "65")]
		public void RpcAllViaServer(PLFIBMEPEJL.JAMCMLIMLGH<NIHFGKDLNDI> HHDOKFFBPDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x3C99960", Offset = "0x3C98B60", VA = "0x183C99960", Slot = "66")]
		public void RpcAllViaServer<T1>(PLFIBMEPEJL.JLHFHGLHKCK<T1, NIHFGKDLNDI> HHDOKFFBPDP, T1 DGDONNHKDHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x3C99590", Offset = "0x3C98790", VA = "0x183C99590", Slot = "67")]
		public void RpcAllViaServer<T1, T2>(PLFIBMEPEJL.IKNMOKALHEO<T1, T2, NIHFGKDLNDI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x3C99280", Offset = "0x3C98480", VA = "0x183C99280", Slot = "68")]
		public void RpcAllViaServer<T1, T2, T3>(PLFIBMEPEJL.LGFOENKEGMH<T1, T2, T3, NIHFGKDLNDI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3C988F0", Offset = "0x3C97AF0", VA = "0x183C988F0", Slot = "69")]
		public void RpcAllViaServer<T1, T2, T3, T4>(PLFIBMEPEJL.HEEBAHHJIEC<T1, T2, T3, T4, NIHFGKDLNDI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3C98690", Offset = "0x3C97890", VA = "0x183C98690", Slot = "70")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(PLFIBMEPEJL.KOMLIFDIAIL<T1, T2, T3, T4, T5, NIHFGKDLNDI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x3C979C0", Offset = "0x3C96BC0", VA = "0x183C979C0", Slot = "71")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(PLFIBMEPEJL.HIHGCKMDIGF<T1, T2, T3, T4, T5, T6, NIHFGKDLNDI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3C976C0", Offset = "0x3C968C0", VA = "0x183C976C0", Slot = "72")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(PLFIBMEPEJL.NIIOGJFKOCA<T1, T2, T3, T4, T5, T6, T7, NIHFGKDLNDI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x3C966D0", Offset = "0x3C958D0", VA = "0x183C966D0", Slot = "73")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(PLFIBMEPEJL.IELFFLPENFG<T1, T2, T3, T4, T5, T6, T7, T8, NIHFGKDLNDI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3C95F90", Offset = "0x3C95190", VA = "0x183C95F90", Slot = "74")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(JOJJLNNFJHI HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3C95020", Offset = "0x3C94220", VA = "0x183C95020", Slot = "75")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(FOKADDBHABI HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x3C94360", Offset = "0x3C93560", VA = "0x183C94360", Slot = "76")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(DFAFKNHMIPJ HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3C93A40", Offset = "0x3C92C40", VA = "0x183C93A40", Slot = "77")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(DOHBPOHOONN HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3C930C0", Offset = "0x3C922C0", VA = "0x183C930C0", Slot = "78")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(GEBFKAKOJFA HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA, T13 JIPNGHJEIMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x3C921A0", Offset = "0x3C913A0", VA = "0x183C921A0", Slot = "79")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ICNEIGCHPGL HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA, T13 JIPNGHJEIMA, T14 COFFOAJAMMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x7D96A20", Offset = "0x7D95C20", VA = "0x187D96A20", Slot = "80")]
		public void RpcOthers(PLFIBMEPEJL.KDJHBMICHHD HHDOKFFBPDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x3CCB6D0", Offset = "0x3CCA8D0", VA = "0x183CCB6D0", Slot = "15")]
		public void RpcOthers<T1>(PLFIBMEPEJL.JAMCMLIMLGH<T1> HHDOKFFBPDP, T1 DGDONNHKDHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x3CCBFD0", Offset = "0x3CCB1D0", VA = "0x183CCBFD0", Slot = "81")]
		public void RpcOthers<T1, T2>(PLFIBMEPEJL.JLHFHGLHKCK<T1, T2> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x3CCB450", Offset = "0x3CCA650", VA = "0x183CCB450", Slot = "82")]
		public void RpcOthers<T1, T2, T3>(PLFIBMEPEJL.IKNMOKALHEO<T1, T2, T3> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x3CD4AB0", Offset = "0x3CD3CB0", VA = "0x183CD4AB0", Slot = "83")]
		public void RpcOthers<T1, T2, T3, T4>(PLFIBMEPEJL.LGFOENKEGMH<T1, T2, T3, T4> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x3CCCD80", Offset = "0x3CCBF80", VA = "0x183CCCD80", Slot = "84")]
		public void RpcOthers<T1, T2, T3, T4, T5>(PLFIBMEPEJL.HEEBAHHJIEC<T1, T2, T3, T4, T5> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x3CD4060", Offset = "0x3CD3260", VA = "0x183CD4060", Slot = "85")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(PLFIBMEPEJL.KOMLIFDIAIL<T1, T2, T3, T4, T5, T6> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x3CD3160", Offset = "0x3CD2360", VA = "0x183CD3160", Slot = "86")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(PLFIBMEPEJL.HIHGCKMDIGF<T1, T2, T3, T4, T5, T6, T7> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x3CD2710", Offset = "0x3CD1910", VA = "0x183CD2710", Slot = "87")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(PLFIBMEPEJL.NIIOGJFKOCA<T1, T2, T3, T4, T5, T6, T7, T8> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x3CD1BD0", Offset = "0x3CD0DD0", VA = "0x183CD1BD0", Slot = "88")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(PLFIBMEPEJL.IELFFLPENFG<T1, T2, T3, T4, T5, T6, T7, T8, T9> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x3CD0FA0", Offset = "0x3CD01A0", VA = "0x183CD0FA0", Slot = "16")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(JOJJLNNFJHI HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x3CD0280", Offset = "0x3CCF480", VA = "0x183CD0280", Slot = "89")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(FOKADDBHABI HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x3CCF900", Offset = "0x3CCEB00", VA = "0x183CCF900", Slot = "90")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(DFAFKNHMIPJ HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x3CCEF30", Offset = "0x3CCE130", VA = "0x183CCEF30", Slot = "91")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(DOHBPOHOONN HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA, T13 JIPNGHJEIMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x3CCDFA0", Offset = "0x3CCD1A0", VA = "0x183CCDFA0", Slot = "92")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(GEBFKAKOJFA HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA, T13 JIPNGHJEIMA, T14 COFFOAJAMMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x7D96780", Offset = "0x7D95980", VA = "0x187D96780")]
		public void RpcOthers(PLFIBMEPEJL.JAMCMLIMLGH<GIKIDEGCBCI> HHDOKFFBPDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x3CCBD10", Offset = "0x3CCAF10", VA = "0x183CCBD10")]
		public void RpcOthers<T1>(PLFIBMEPEJL.JLHFHGLHKCK<T1, GIKIDEGCBCI> HHDOKFFBPDP, T1 DGDONNHKDHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x3CCBB20", Offset = "0x3CCAD20", VA = "0x183CCBB20")]
		public void RpcOthers<T1, T2>(PLFIBMEPEJL.IKNMOKALHEO<T1, T2, GIKIDEGCBCI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3CD5D00", Offset = "0x3CD4F00", VA = "0x183CD5D00")]
		public void RpcOthers<T1, T2, T3>(PLFIBMEPEJL.LGFOENKEGMH<T1, T2, T3, GIKIDEGCBCI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x3CCB830", Offset = "0x3CCAA30", VA = "0x183CCB830")]
		public void RpcOthers<T1, T2, T3, T4>(PLFIBMEPEJL.HEEBAHHJIEC<T1, T2, T3, T4, GIKIDEGCBCI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x3CCC4E0", Offset = "0x3CCB6E0", VA = "0x183CCC4E0")]
		public void RpcOthers<T1, T2, T3, T4, T5>(PLFIBMEPEJL.KOMLIFDIAIL<T1, T2, T3, T4, T5, GIKIDEGCBCI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x3CCC830", Offset = "0x3CCBA30", VA = "0x183CCC830")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(PLFIBMEPEJL.HIHGCKMDIGF<T1, T2, T3, T4, T5, T6, GIKIDEGCBCI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x3CD3480", Offset = "0x3CD2680", VA = "0x183CD3480")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(PLFIBMEPEJL.NIIOGJFKOCA<T1, T2, T3, T4, T5, T6, T7, GIKIDEGCBCI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x3CD2DF0", Offset = "0x3CD1FF0", VA = "0x183CD2DF0")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(PLFIBMEPEJL.IELFFLPENFG<T1, T2, T3, T4, T5, T6, T7, T8, GIKIDEGCBCI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x3CD1F90", Offset = "0x3CD1190", VA = "0x183CD1F90")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(JOJJLNNFJHI HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x3CD13B0", Offset = "0x3CD05B0", VA = "0x183CD13B0")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(FOKADDBHABI HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x3CD0B40", Offset = "0x3CCFD40", VA = "0x183CD0B40")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(DFAFKNHMIPJ HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x3CCF440", Offset = "0x3CCE640", VA = "0x183CCF440")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(DOHBPOHOONN HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x3CCEA20", Offset = "0x3CCDC20", VA = "0x183CCEA20")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(GEBFKAKOJFA HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA, T13 JIPNGHJEIMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x3CCDA30", Offset = "0x3CCCC30", VA = "0x183CCDA30")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ICNEIGCHPGL HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA, T13 JIPNGHJEIMA, T14 COFFOAJAMMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x7D968D0", Offset = "0x7D95AD0", VA = "0x187D968D0", Slot = "93")]
		public void RpcOthers(PLFIBMEPEJL.JAMCMLIMLGH<NIHFGKDLNDI> HHDOKFFBPDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x3CD6930", Offset = "0x3CD5B30", VA = "0x183CD6930", Slot = "94")]
		public void RpcOthers<T1>(PLFIBMEPEJL.JLHFHGLHKCK<T1, NIHFGKDLNDI> HHDOKFFBPDP, T1 DGDONNHKDHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x3CD62C0", Offset = "0x3CD54C0", VA = "0x183CD62C0", Slot = "95")]
		public void RpcOthers<T1, T2>(PLFIBMEPEJL.IKNMOKALHEO<T1, T2, NIHFGKDLNDI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x3CD5B20", Offset = "0x3CD4D20", VA = "0x183CD5B20", Slot = "96")]
		public void RpcOthers<T1, T2, T3>(PLFIBMEPEJL.LGFOENKEGMH<T1, T2, T3, NIHFGKDLNDI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x3CD4F10", Offset = "0x3CD4110", VA = "0x183CD4F10", Slot = "97")]
		public void RpcOthers<T1, T2, T3, T4>(PLFIBMEPEJL.HEEBAHHJIEC<T1, T2, T3, T4, NIHFGKDLNDI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x3CD45B0", Offset = "0x3CD37B0", VA = "0x183CD45B0", Slot = "98")]
		public void RpcOthers<T1, T2, T3, T4, T5>(PLFIBMEPEJL.KOMLIFDIAIL<T1, T2, T3, T4, T5, NIHFGKDLNDI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x3CD3D90", Offset = "0x3CD2F90", VA = "0x183CD3D90", Slot = "99")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(PLFIBMEPEJL.HIHGCKMDIGF<T1, T2, T3, T4, T5, T6, NIHFGKDLNDI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x3CD37A0", Offset = "0x3CD29A0", VA = "0x183CD37A0", Slot = "100")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(PLFIBMEPEJL.NIIOGJFKOCA<T1, T2, T3, T4, T5, T6, T7, NIHFGKDLNDI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x3CD2A80", Offset = "0x3CD1C80", VA = "0x183CD2A80", Slot = "101")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(PLFIBMEPEJL.IELFFLPENFG<T1, T2, T3, T4, T5, T6, T7, T8, NIHFGKDLNDI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x3CD2350", Offset = "0x3CD1550", VA = "0x183CD2350", Slot = "102")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(JOJJLNNFJHI HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x3CD17C0", Offset = "0x3CD09C0", VA = "0x183CD17C0", Slot = "103")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(FOKADDBHABI HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x3CD06E0", Offset = "0x3CCF8E0", VA = "0x183CD06E0", Slot = "104")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(DFAFKNHMIPJ HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x3CCFDC0", Offset = "0x3CCEFC0", VA = "0x183CCFDC0", Slot = "105")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(DOHBPOHOONN HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x3CCE510", Offset = "0x3CCD710", VA = "0x183CCE510", Slot = "106")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(GEBFKAKOJFA HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA, T13 JIPNGHJEIMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x3CCD4C0", Offset = "0x3CCC6C0", VA = "0x183CCD4C0", Slot = "107")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ICNEIGCHPGL HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA, T13 JIPNGHJEIMA, T14 COFFOAJAMMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x7D95FB0", Offset = "0x7D951B0", VA = "0x187D95FB0", Slot = "108")]
		public void RpcMaster(PLFIBMEPEJL.KDJHBMICHHD HHDOKFFBPDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x3CAF190", Offset = "0x3CAE390", VA = "0x183CAF190", Slot = "109")]
		public void RpcMaster<T1>(PLFIBMEPEJL.JAMCMLIMLGH<T1> HHDOKFFBPDP, T1 DGDONNHKDHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x3CAF540", Offset = "0x3CAE740", VA = "0x183CAF540", Slot = "17")]
		public void RpcMaster<T1, T2>(PLFIBMEPEJL.JLHFHGLHKCK<T1, T2> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x3CAEEC0", Offset = "0x3CAE0C0", VA = "0x183CAEEC0", Slot = "110")]
		public void RpcMaster<T1, T2, T3>(PLFIBMEPEJL.IKNMOKALHEO<T1, T2, T3> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x3CAEB60", Offset = "0x3CADD60", VA = "0x183CAEB60", Slot = "111")]
		public void RpcMaster<T1, T2, T3, T4>(PLFIBMEPEJL.LGFOENKEGMH<T1, T2, T3, T4> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x3CB2C20", Offset = "0x3CB1E20", VA = "0x183CB2C20", Slot = "112")]
		public void RpcMaster<T1, T2, T3, T4, T5>(PLFIBMEPEJL.HEEBAHHJIEC<T1, T2, T3, T4, T5> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x3CB50A0", Offset = "0x3CB42A0", VA = "0x183CB50A0", Slot = "113")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(PLFIBMEPEJL.KOMLIFDIAIL<T1, T2, T3, T4, T5, T6> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x3CBA150", Offset = "0x3CB9350", VA = "0x183CBA150", Slot = "114")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(PLFIBMEPEJL.HIHGCKMDIGF<T1, T2, T3, T4, T5, T6, T7> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x3CB9940", Offset = "0x3CB8B40", VA = "0x183CB9940", Slot = "115")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(PLFIBMEPEJL.NIIOGJFKOCA<T1, T2, T3, T4, T5, T6, T7, T8> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x3CB8250", Offset = "0x3CB7450", VA = "0x183CB8250", Slot = "116")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(PLFIBMEPEJL.IELFFLPENFG<T1, T2, T3, T4, T5, T6, T7, T8, T9> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x3CB23D0", Offset = "0x3CB15D0", VA = "0x183CB23D0", Slot = "117")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(JOJJLNNFJHI HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x3CB0FD0", Offset = "0x3CB01D0", VA = "0x183CB0FD0", Slot = "118")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(FOKADDBHABI HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x3CC2280", Offset = "0x3CC1480", VA = "0x183CC2280", Slot = "119")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(DFAFKNHMIPJ HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x3CC1040", Offset = "0x3CC0240", VA = "0x183CC1040", Slot = "120")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(DOHBPOHOONN HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA, T13 JIPNGHJEIMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x3CBF600", Offset = "0x3CBE800", VA = "0x183CBF600", Slot = "121")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(GEBFKAKOJFA HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA, T13 JIPNGHJEIMA, T14 COFFOAJAMMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x7D96140", Offset = "0x7D95340", VA = "0x187D96140")]
		public void RpcMaster(PLFIBMEPEJL.JAMCMLIMLGH<GIKIDEGCBCI> HHDOKFFBPDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x3CAF340", Offset = "0x3CAE540", VA = "0x183CAF340")]
		public void RpcMaster<T1>(PLFIBMEPEJL.JLHFHGLHKCK<T1, GIKIDEGCBCI> HHDOKFFBPDP, T1 DGDONNHKDHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x3CAFFE0", Offset = "0x3CAF1E0", VA = "0x183CAFFE0")]
		public void RpcMaster<T1, T2>(PLFIBMEPEJL.IKNMOKALHEO<T1, T2, GIKIDEGCBCI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x3CAF790", Offset = "0x3CAE990", VA = "0x183CAF790")]
		public void RpcMaster<T1, T2, T3>(PLFIBMEPEJL.LGFOENKEGMH<T1, T2, T3, GIKIDEGCBCI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x3CBBFE0", Offset = "0x3CBB1E0", VA = "0x183CBBFE0")]
		public void RpcMaster<T1, T2, T3, T4>(PLFIBMEPEJL.HEEBAHHJIEC<T1, T2, T3, T4, GIKIDEGCBCI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x3CB3660", Offset = "0x3CB2860", VA = "0x183CB3660")]
		public void RpcMaster<T1, T2, T3, T4, T5>(PLFIBMEPEJL.KOMLIFDIAIL<T1, T2, T3, T4, T5, GIKIDEGCBCI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x3CBACC0", Offset = "0x3CB9EC0", VA = "0x183CBACC0")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(PLFIBMEPEJL.HIHGCKMDIGF<T1, T2, T3, T4, T5, T6, GIKIDEGCBCI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x3CB9D50", Offset = "0x3CB8F50", VA = "0x183CB9D50")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(PLFIBMEPEJL.NIIOGJFKOCA<T1, T2, T3, T4, T5, T6, T7, GIKIDEGCBCI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x3CB94D0", Offset = "0x3CB86D0", VA = "0x183CB94D0")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(PLFIBMEPEJL.IELFFLPENFG<T1, T2, T3, T4, T5, T6, T7, T8, GIKIDEGCBCI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x3CB8B90", Offset = "0x3CB7D90", VA = "0x183CB8B90")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(JOJJLNNFJHI HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x3CB7D20", Offset = "0x3CB6F20", VA = "0x183CB7D20")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(FOKADDBHABI HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x3CB62C0", Offset = "0x3CB54C0", VA = "0x183CB62C0")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(DFAFKNHMIPJ HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x3CC1C90", Offset = "0x3CC0E90", VA = "0x183CC1C90")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(DOHBPOHOONN HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x3CC09F0", Offset = "0x3CBFBF0", VA = "0x183CC09F0")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(GEBFKAKOJFA HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA, T13 JIPNGHJEIMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x3CBFC70", Offset = "0x3CBEE70", VA = "0x183CBFC70")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ICNEIGCHPGL HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA, T13 JIPNGHJEIMA, T14 COFFOAJAMMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x7D96360", Offset = "0x7D95560", VA = "0x187D96360", Slot = "122")]
		public void RpcMaster(PLFIBMEPEJL.JAMCMLIMLGH<NIHFGKDLNDI> HHDOKFFBPDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x3CBEAB0", Offset = "0x3CBDCB0", VA = "0x183CBEAB0", Slot = "123")]
		public void RpcMaster<T1>(PLFIBMEPEJL.JLHFHGLHKCK<T1, NIHFGKDLNDI> HHDOKFFBPDP, T1 DGDONNHKDHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x3CBDB10", Offset = "0x3CBCD10", VA = "0x183CBDB10", Slot = "124")]
		public void RpcMaster<T1, T2>(PLFIBMEPEJL.IKNMOKALHEO<T1, T2, NIHFGKDLNDI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x3CBCA60", Offset = "0x3CBBC60", VA = "0x183CBCA60", Slot = "125")]
		public void RpcMaster<T1, T2, T3>(PLFIBMEPEJL.LGFOENKEGMH<T1, T2, T3, NIHFGKDLNDI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x3CBC2D0", Offset = "0x3CBB4D0", VA = "0x183CBC2D0", Slot = "126")]
		public void RpcMaster<T1, T2, T3, T4>(PLFIBMEPEJL.HEEBAHHJIEC<T1, T2, T3, T4, NIHFGKDLNDI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x3CBB6B0", Offset = "0x3CBA8B0", VA = "0x183CBB6B0", Slot = "127")]
		public void RpcMaster<T1, T2, T3, T4, T5>(PLFIBMEPEJL.KOMLIFDIAIL<T1, T2, T3, T4, T5, NIHFGKDLNDI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x3CBA910", Offset = "0x3CB9B10", VA = "0x183CBA910", Slot = "128")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(PLFIBMEPEJL.HIHGCKMDIGF<T1, T2, T3, T4, T5, T6, NIHFGKDLNDI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x3CBA510", Offset = "0x3CB9710", VA = "0x183CBA510", Slot = "129")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(PLFIBMEPEJL.NIIOGJFKOCA<T1, T2, T3, T4, T5, T6, T7, NIHFGKDLNDI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x3CB9060", Offset = "0x3CB8260", VA = "0x183CB9060", Slot = "130")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(PLFIBMEPEJL.IELFFLPENFG<T1, T2, T3, T4, T5, T6, T7, T8, NIHFGKDLNDI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x3CB86C0", Offset = "0x3CB78C0", VA = "0x183CB86C0", Slot = "131")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(JOJJLNNFJHI HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x3CB77F0", Offset = "0x3CB69F0", VA = "0x183CB77F0", Slot = "132")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(FOKADDBHABI HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x3CB6D90", Offset = "0x3CB5F90", VA = "0x183CB6D90", Slot = "133")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(DFAFKNHMIPJ HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x3CC2820", Offset = "0x3CC1A20", VA = "0x183CC2820", Slot = "134")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(DOHBPOHOONN HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x3CC1640", Offset = "0x3CC0840", VA = "0x183CC1640", Slot = "135")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(GEBFKAKOJFA HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA, T13 JIPNGHJEIMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x3CC0330", Offset = "0x3CBF530", VA = "0x183CC0330", Slot = "136")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ICNEIGCHPGL HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA, T13 JIPNGHJEIMA, T14 COFFOAJAMMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x7D95950", Offset = "0x7D94B50", VA = "0x187D95950", Slot = "137")]
		public void RpcAuthority(PLFIBMEPEJL.KDJHBMICHHD HHDOKFFBPDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x3C9EC00", Offset = "0x3C9DE00", VA = "0x183C9EC00", Slot = "138")]
		public void RpcAuthority<T1>(PLFIBMEPEJL.JAMCMLIMLGH<T1> HHDOKFFBPDP, T1 DGDONNHKDHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x3CA0510", Offset = "0x3C9F710", VA = "0x183CA0510", Slot = "139")]
		public void RpcAuthority<T1, T2>(PLFIBMEPEJL.JLHFHGLHKCK<T1, T2> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x3CA0CC0", Offset = "0x3C9FEC0", VA = "0x183CA0CC0", Slot = "140")]
		public void RpcAuthority<T1, T2, T3>(PLFIBMEPEJL.IKNMOKALHEO<T1, T2, T3> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x3CA01D0", Offset = "0x3C9F3D0", VA = "0x183CA01D0", Slot = "141")]
		public void RpcAuthority<T1, T2, T3, T4>(PLFIBMEPEJL.LGFOENKEGMH<T1, T2, T3, T4> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x3C9E7F0", Offset = "0x3C9D9F0", VA = "0x183C9E7F0", Slot = "142")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(PLFIBMEPEJL.HEEBAHHJIEC<T1, T2, T3, T4, T5> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x3CA9570", Offset = "0x3CA8770", VA = "0x183CA9570", Slot = "143")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(PLFIBMEPEJL.KOMLIFDIAIL<T1, T2, T3, T4, T5, T6> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x3CA8960", Offset = "0x3CA7B60", VA = "0x183CA8960", Slot = "144")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(PLFIBMEPEJL.HIHGCKMDIGF<T1, T2, T3, T4, T5, T6, T7> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x3CA80B0", Offset = "0x3CA72B0", VA = "0x183CA80B0", Slot = "145")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(PLFIBMEPEJL.NIIOGJFKOCA<T1, T2, T3, T4, T5, T6, T7, T8> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x3CA6DE0", Offset = "0x3CA5FE0", VA = "0x183CA6DE0", Slot = "146")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(PLFIBMEPEJL.IELFFLPENFG<T1, T2, T3, T4, T5, T6, T7, T8, T9> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x3CA63B0", Offset = "0x3CA55B0", VA = "0x183CA63B0", Slot = "147")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(JOJJLNNFJHI HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x3CA5920", Offset = "0x3CA4B20", VA = "0x183CA5920", Slot = "148")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(FOKADDBHABI HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x3C9EDC0", Offset = "0x3C9DFC0", VA = "0x183C9EDC0", Slot = "149")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(DFAFKNHMIPJ HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x3CA3610", Offset = "0x3CA2810", VA = "0x183CA3610", Slot = "150")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(DOHBPOHOONN HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA, T13 JIPNGHJEIMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x3CA22D0", Offset = "0x3CA14D0", VA = "0x183CA22D0", Slot = "151")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(GEBFKAKOJFA HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA, T13 JIPNGHJEIMA, T14 COFFOAJAMMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x7D95B00", Offset = "0x7D94D00", VA = "0x187D95B00")]
		public void RpcAuthority(PLFIBMEPEJL.JAMCMLIMLGH<GIKIDEGCBCI> HHDOKFFBPDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x3CACC20", Offset = "0x3CABE20", VA = "0x183CACC20")]
		public void RpcAuthority<T1>(PLFIBMEPEJL.JLHFHGLHKCK<T1, GIKIDEGCBCI> HHDOKFFBPDP, T1 DGDONNHKDHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x3CABED0", Offset = "0x3CAB0D0", VA = "0x183CABED0")]
		public void RpcAuthority<T1, T2>(PLFIBMEPEJL.IKNMOKALHEO<T1, T2, GIKIDEGCBCI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x3CAB790", Offset = "0x3CAA990", VA = "0x183CAB790")]
		public void RpcAuthority<T1, T2, T3>(PLFIBMEPEJL.LGFOENKEGMH<T1, T2, T3, GIKIDEGCBCI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x3CAAA20", Offset = "0x3CA9C20", VA = "0x183CAAA20")]
		public void RpcAuthority<T1, T2, T3, T4>(PLFIBMEPEJL.HEEBAHHJIEC<T1, T2, T3, T4, GIKIDEGCBCI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x3CAA050", Offset = "0x3CA9250", VA = "0x183CAA050")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(PLFIBMEPEJL.KOMLIFDIAIL<T1, T2, T3, T4, T5, GIKIDEGCBCI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x3CA9C90", Offset = "0x3CA8E90", VA = "0x183CA9C90")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(PLFIBMEPEJL.HIHGCKMDIGF<T1, T2, T3, T4, T5, T6, GIKIDEGCBCI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x3CA9150", Offset = "0x3CA8350", VA = "0x183CA9150")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(PLFIBMEPEJL.NIIOGJFKOCA<T1, T2, T3, T4, T5, T6, T7, GIKIDEGCBCI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x3CA7C30", Offset = "0x3CA6E30", VA = "0x183CA7C30")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(PLFIBMEPEJL.IELFFLPENFG<T1, T2, T3, T4, T5, T6, T7, T8, GIKIDEGCBCI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x3CA7270", Offset = "0x3CA6470", VA = "0x183CA7270")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(JOJJLNNFJHI HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x3CA5E70", Offset = "0x3CA5070", VA = "0x183CA5E70")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(FOKADDBHABI HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x3CA5380", Offset = "0x3CA4580", VA = "0x183CA5380")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(DFAFKNHMIPJ HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x3CA47E0", Offset = "0x3CA39E0", VA = "0x183CA47E0")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(DOHBPOHOONN HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x3CA2FB0", Offset = "0x3CA21B0", VA = "0x183CA2FB0")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(GEBFKAKOJFA HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA, T13 JIPNGHJEIMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x3CA1C00", Offset = "0x3CA0E00", VA = "0x183CA1C00")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ICNEIGCHPGL HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA, T13 JIPNGHJEIMA, T14 COFFOAJAMMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x7D95D50", Offset = "0x7D94F50", VA = "0x187D95D50", Slot = "152")]
		public void RpcAuthority(PLFIBMEPEJL.JAMCMLIMLGH<NIHFGKDLNDI> HHDOKFFBPDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x3CACDF0", Offset = "0x3CABFF0", VA = "0x183CACDF0", Slot = "153")]
		public void RpcAuthority<T1>(PLFIBMEPEJL.JLHFHGLHKCK<T1, NIHFGKDLNDI> HHDOKFFBPDP, T1 DGDONNHKDHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x3CABCA0", Offset = "0x3CAAEA0", VA = "0x183CABCA0", Slot = "154")]
		public void RpcAuthority<T1, T2>(PLFIBMEPEJL.IKNMOKALHEO<T1, T2, NIHFGKDLNDI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x3CAB2C0", Offset = "0x3CAA4C0", VA = "0x183CAB2C0", Slot = "155")]
		public void RpcAuthority<T1, T2, T3>(PLFIBMEPEJL.LGFOENKEGMH<T1, T2, T3, NIHFGKDLNDI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x3CAAFC0", Offset = "0x3CAA1C0", VA = "0x183CAAFC0", Slot = "156")]
		public void RpcAuthority<T1, T2, T3, T4>(PLFIBMEPEJL.HEEBAHHJIEC<T1, T2, T3, T4, NIHFGKDLNDI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x3CAA6C0", Offset = "0x3CA98C0", VA = "0x183CAA6C0", Slot = "157")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(PLFIBMEPEJL.KOMLIFDIAIL<T1, T2, T3, T4, T5, NIHFGKDLNDI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x3CA98D0", Offset = "0x3CA8AD0", VA = "0x183CA98D0", Slot = "158")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(PLFIBMEPEJL.HIHGCKMDIGF<T1, T2, T3, T4, T5, T6, NIHFGKDLNDI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x3CA8D30", Offset = "0x3CA7F30", VA = "0x183CA8D30", Slot = "159")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(PLFIBMEPEJL.NIIOGJFKOCA<T1, T2, T3, T4, T5, T6, T7, NIHFGKDLNDI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x3CA84E0", Offset = "0x3CA76E0", VA = "0x183CA84E0", Slot = "160")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(PLFIBMEPEJL.IELFFLPENFG<T1, T2, T3, T4, T5, T6, T7, T8, NIHFGKDLNDI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x3CA7750", Offset = "0x3CA6950", VA = "0x183CA7750", Slot = "161")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(JOJJLNNFJHI HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x3CA68A0", Offset = "0x3CA5AA0", VA = "0x183CA68A0", Slot = "162")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(FOKADDBHABI HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x3CA4DE0", Offset = "0x3CA3FE0", VA = "0x183CA4DE0", Slot = "163")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(DFAFKNHMIPJ HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x3CA3C30", Offset = "0x3CA2E30", VA = "0x183CA3C30", Slot = "164")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(DOHBPOHOONN HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x3CA2950", Offset = "0x3CA1B50", VA = "0x183CA2950", Slot = "165")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(GEBFKAKOJFA HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA, T13 JIPNGHJEIMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x3CA1530", Offset = "0x3CA0730", VA = "0x183CA1530", Slot = "166")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ICNEIGCHPGL HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA, T13 JIPNGHJEIMA, T14 COFFOAJAMMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x7D970E0", Offset = "0x7D962E0", VA = "0x187D970E0", Slot = "18")]
		public void RpcPlayer(BNFABCHNBCL NLIBDKKPKLB, PLFIBMEPEJL.KDJHBMICHHD HHDOKFFBPDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x3CD7290", Offset = "0x3CD6490", VA = "0x183CD7290", Slot = "19")]
		public void RpcPlayer<T1>(BNFABCHNBCL NLIBDKKPKLB, PLFIBMEPEJL.JAMCMLIMLGH<T1> HHDOKFFBPDP, T1 DGDONNHKDHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x3CD81F0", Offset = "0x3CD73F0", VA = "0x183CD81F0", Slot = "20")]
		public void RpcPlayer<T1, T2>(BNFABCHNBCL NLIBDKKPKLB, PLFIBMEPEJL.JLHFHGLHKCK<T1, T2> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x3CD7C00", Offset = "0x3CD6E00", VA = "0x183CD7C00", Slot = "21")]
		public void RpcPlayer<T1, T2, T3>(BNFABCHNBCL NLIBDKKPKLB, PLFIBMEPEJL.IKNMOKALHEO<T1, T2, T3> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x3CD7460", Offset = "0x3CD6660", VA = "0x183CD7460", Slot = "22")]
		public void RpcPlayer<T1, T2, T3, T4>(BNFABCHNBCL NLIBDKKPKLB, PLFIBMEPEJL.LGFOENKEGMH<T1, T2, T3, T4> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x3CDBF60", Offset = "0x3CDB160", VA = "0x183CDBF60", Slot = "167")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(BNFABCHNBCL NLIBDKKPKLB, PLFIBMEPEJL.HEEBAHHJIEC<T1, T2, T3, T4, T5> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x3CDBAF0", Offset = "0x3CDACF0", VA = "0x183CDBAF0", Slot = "168")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(BNFABCHNBCL NLIBDKKPKLB, PLFIBMEPEJL.KOMLIFDIAIL<T1, T2, T3, T4, T5, T6> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x3CDC350", Offset = "0x3CDB550", VA = "0x183CDC350", Slot = "169")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(BNFABCHNBCL NLIBDKKPKLB, PLFIBMEPEJL.HIHGCKMDIGF<T1, T2, T3, T4, T5, T6, T7> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x3CDC820", Offset = "0x3CDBA20", VA = "0x183CDC820", Slot = "170")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(BNFABCHNBCL NLIBDKKPKLB, PLFIBMEPEJL.NIIOGJFKOCA<T1, T2, T3, T4, T5, T6, T7, T8> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x3CE4880", Offset = "0x3CE3A80", VA = "0x183CE4880", Slot = "171")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BNFABCHNBCL NLIBDKKPKLB, PLFIBMEPEJL.IELFFLPENFG<T1, T2, T3, T4, T5, T6, T7, T8, T9> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x3CE4380", Offset = "0x3CE3580", VA = "0x183CE4380", Slot = "172")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BNFABCHNBCL NLIBDKKPKLB, JOJJLNNFJHI HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x3CD8AE0", Offset = "0x3CD7CE0", VA = "0x183CD8AE0", Slot = "23")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BNFABCHNBCL NLIBDKKPKLB, FOKADDBHABI HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x3CE1620", Offset = "0x3CE0820", VA = "0x183CE1620", Slot = "173")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BNFABCHNBCL NLIBDKKPKLB, DFAFKNHMIPJ HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x3CE0FF0", Offset = "0x3CE01F0", VA = "0x183CE0FF0", Slot = "174")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BNFABCHNBCL NLIBDKKPKLB, DOHBPOHOONN HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA, T13 JIPNGHJEIMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x3CDFC60", Offset = "0x3CDEE60", VA = "0x183CDFC60", Slot = "175")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BNFABCHNBCL NLIBDKKPKLB, GEBFKAKOJFA HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA, T13 JIPNGHJEIMA, T14 COFFOAJAMMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x7D96B70", Offset = "0x7D95D70", VA = "0x187D96B70")]
		public void RpcPlayer(BNFABCHNBCL NLIBDKKPKLB, PLFIBMEPEJL.JAMCMLIMLGH<GIKIDEGCBCI> HHDOKFFBPDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x3CD7800", Offset = "0x3CD6A00", VA = "0x183CD7800")]
		public void RpcPlayer<T1>(BNFABCHNBCL NLIBDKKPKLB, PLFIBMEPEJL.JLHFHGLHKCK<T1, GIKIDEGCBCI> HHDOKFFBPDP, T1 DGDONNHKDHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x3CDE380", Offset = "0x3CDD580", VA = "0x183CDE380")]
		public void RpcPlayer<T1, T2>(BNFABCHNBCL NLIBDKKPKLB, PLFIBMEPEJL.IKNMOKALHEO<T1, T2, GIKIDEGCBCI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x3CE9330", Offset = "0x3CE8530", VA = "0x183CE9330")]
		public void RpcPlayer<T1, T2, T3>(BNFABCHNBCL NLIBDKKPKLB, PLFIBMEPEJL.LGFOENKEGMH<T1, T2, T3, GIKIDEGCBCI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x3CE8580", Offset = "0x3CE7780", VA = "0x183CE8580")]
		public void RpcPlayer<T1, T2, T3, T4>(BNFABCHNBCL NLIBDKKPKLB, PLFIBMEPEJL.HEEBAHHJIEC<T1, T2, T3, T4, GIKIDEGCBCI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x3CE7B90", Offset = "0x3CE6D90", VA = "0x183CE7B90")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(BNFABCHNBCL NLIBDKKPKLB, PLFIBMEPEJL.KOMLIFDIAIL<T1, T2, T3, T4, T5, GIKIDEGCBCI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x3CE7080", Offset = "0x3CE6280", VA = "0x183CE7080")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(BNFABCHNBCL NLIBDKKPKLB, PLFIBMEPEJL.HIHGCKMDIGF<T1, T2, T3, T4, T5, T6, GIKIDEGCBCI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x3CE6C50", Offset = "0x3CE5E50", VA = "0x183CE6C50")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(BNFABCHNBCL NLIBDKKPKLB, PLFIBMEPEJL.NIIOGJFKOCA<T1, T2, T3, T4, T5, T6, T7, GIKIDEGCBCI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x3CE5FC0", Offset = "0x3CE51C0", VA = "0x183CE5FC0")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(BNFABCHNBCL NLIBDKKPKLB, PLFIBMEPEJL.IELFFLPENFG<T1, T2, T3, T4, T5, T6, T7, T8, GIKIDEGCBCI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x3CE4D20", Offset = "0x3CE3F20", VA = "0x183CE4D20")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BNFABCHNBCL NLIBDKKPKLB, JOJJLNNFJHI HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x3CE3E30", Offset = "0x3CE3030", VA = "0x183CE3E30")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BNFABCHNBCL NLIBDKKPKLB, FOKADDBHABI HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x3CE3330", Offset = "0x3CE2530", VA = "0x183CE3330")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BNFABCHNBCL NLIBDKKPKLB, DFAFKNHMIPJ HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x3CE2200", Offset = "0x3CE1400", VA = "0x183CE2200")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BNFABCHNBCL NLIBDKKPKLB, DOHBPOHOONN HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x3CE02F0", Offset = "0x3CDF4F0", VA = "0x183CE02F0")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BNFABCHNBCL NLIBDKKPKLB, GEBFKAKOJFA HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA, T13 JIPNGHJEIMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x3CDF580", Offset = "0x3CDE780", VA = "0x183CDF580")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BNFABCHNBCL NLIBDKKPKLB, ICNEIGCHPGL HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA, T13 JIPNGHJEIMA, T14 COFFOAJAMMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x7D96E20", Offset = "0x7D96020", VA = "0x187D96E20", Slot = "176")]
		public void RpcPlayer(BNFABCHNBCL NLIBDKKPKLB, PLFIBMEPEJL.JAMCMLIMLGH<NIHFGKDLNDI> HHDOKFFBPDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x3CDA8E0", Offset = "0x3CD9AE0", VA = "0x183CDA8E0", Slot = "177")]
		public void RpcPlayer<T1>(BNFABCHNBCL NLIBDKKPKLB, PLFIBMEPEJL.JLHFHGLHKCK<T1, NIHFGKDLNDI> HHDOKFFBPDP, T1 DGDONNHKDHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x3CD87F0", Offset = "0x3CD79F0", VA = "0x183CD87F0", Slot = "24")]
		public void RpcPlayer<T1, T2>(BNFABCHNBCL NLIBDKKPKLB, PLFIBMEPEJL.IKNMOKALHEO<T1, T2, NIHFGKDLNDI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x3CD8470", Offset = "0x3CD7670", VA = "0x183CD8470", Slot = "25")]
		public void RpcPlayer<T1, T2, T3>(BNFABCHNBCL NLIBDKKPKLB, PLFIBMEPEJL.LGFOENKEGMH<T1, T2, T3, NIHFGKDLNDI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x3CDA330", Offset = "0x3CD9530", VA = "0x183CDA330", Slot = "178")]
		public void RpcPlayer<T1, T2, T3, T4>(BNFABCHNBCL NLIBDKKPKLB, PLFIBMEPEJL.HEEBAHHJIEC<T1, T2, T3, T4, NIHFGKDLNDI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x3CE7F00", Offset = "0x3CE7100", VA = "0x183CE7F00", Slot = "179")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(BNFABCHNBCL NLIBDKKPKLB, PLFIBMEPEJL.KOMLIFDIAIL<T1, T2, T3, T4, T5, NIHFGKDLNDI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x3CE77C0", Offset = "0x3CE69C0", VA = "0x183CE77C0", Slot = "180")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(BNFABCHNBCL NLIBDKKPKLB, PLFIBMEPEJL.HIHGCKMDIGF<T1, T2, T3, T4, T5, T6, NIHFGKDLNDI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x3CE6820", Offset = "0x3CE5A20", VA = "0x183CE6820", Slot = "181")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(BNFABCHNBCL NLIBDKKPKLB, PLFIBMEPEJL.NIIOGJFKOCA<T1, T2, T3, T4, T5, T6, T7, NIHFGKDLNDI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x3CE5B30", Offset = "0x3CE4D30", VA = "0x183CE5B30", Slot = "182")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(BNFABCHNBCL NLIBDKKPKLB, PLFIBMEPEJL.IELFFLPENFG<T1, T2, T3, T4, T5, T6, T7, T8, NIHFGKDLNDI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x3CE5210", Offset = "0x3CE4410", VA = "0x183CE5210", Slot = "183")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BNFABCHNBCL NLIBDKKPKLB, JOJJLNNFJHI HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x3CE38E0", Offset = "0x3CE2AE0", VA = "0x183CE38E0", Slot = "184")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BNFABCHNBCL NLIBDKKPKLB, FOKADDBHABI HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x3CE2820", Offset = "0x3CE1A20", VA = "0x183CE2820", Slot = "185")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BNFABCHNBCL NLIBDKKPKLB, DFAFKNHMIPJ HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x3CE1BE0", Offset = "0x3CE0DE0", VA = "0x183CE1BE0", Slot = "186")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BNFABCHNBCL NLIBDKKPKLB, DOHBPOHOONN HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x3CE0970", Offset = "0x3CDFB70", VA = "0x183CE0970", Slot = "187")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BNFABCHNBCL NLIBDKKPKLB, GEBFKAKOJFA HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA, T13 JIPNGHJEIMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x3CDEEA0", Offset = "0x3CDE0A0", VA = "0x183CDEEA0", Slot = "188")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BNFABCHNBCL NLIBDKKPKLB, ICNEIGCHPGL HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA, T13 JIPNGHJEIMA, T14 COFFOAJAMMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x7D94F70", Offset = "0x7D94170", VA = "0x187D94F70", Slot = "189")]
		public void RpcAllBuffered(IDHPEHKKLEL NNHBIDDPDEK, PLFIBMEPEJL.KDJHBMICHHD HHDOKFFBPDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x3C91170", Offset = "0x3C90370", VA = "0x183C91170", Slot = "190")]
		public void RpcAllBuffered<T1>(IDHPEHKKLEL NNHBIDDPDEK, PLFIBMEPEJL.JAMCMLIMLGH<T1> HHDOKFFBPDP, T1 DGDONNHKDHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x3C90D70", Offset = "0x3C8FF70", VA = "0x183C90D70", Slot = "191")]
		public void RpcAllBuffered<T1, T2>(IDHPEHKKLEL NNHBIDDPDEK, PLFIBMEPEJL.JLHFHGLHKCK<T1, T2> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x3C906C0", Offset = "0x3C8F8C0", VA = "0x183C906C0", Slot = "192")]
		public void RpcAllBuffered<T1, T2, T3>(IDHPEHKKLEL NNHBIDDPDEK, PLFIBMEPEJL.IKNMOKALHEO<T1, T2, T3> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x3C90090", Offset = "0x3C8F290", VA = "0x183C90090", Slot = "193")]
		public void RpcAllBuffered<T1, T2, T3, T4>(IDHPEHKKLEL NNHBIDDPDEK, PLFIBMEPEJL.LGFOENKEGMH<T1, T2, T3, T4> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x3C8F970", Offset = "0x3C8EB70", VA = "0x183C8F970", Slot = "194")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(IDHPEHKKLEL NNHBIDDPDEK, PLFIBMEPEJL.HEEBAHHJIEC<T1, T2, T3, T4, T5> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x3C8F6C0", Offset = "0x3C8E8C0", VA = "0x183C8F6C0", Slot = "195")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(IDHPEHKKLEL NNHBIDDPDEK, PLFIBMEPEJL.KOMLIFDIAIL<T1, T2, T3, T4, T5, T6> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x3C8EE60", Offset = "0x3C8E060", VA = "0x183C8EE60", Slot = "196")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(IDHPEHKKLEL NNHBIDDPDEK, PLFIBMEPEJL.HIHGCKMDIGF<T1, T2, T3, T4, T5, T6, T7> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x3C8DE40", Offset = "0x3C8D040", VA = "0x183C8DE40", Slot = "197")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(IDHPEHKKLEL NNHBIDDPDEK, PLFIBMEPEJL.NIIOGJFKOCA<T1, T2, T3, T4, T5, T6, T7, T8> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x3C8D6E0", Offset = "0x3C8C8E0", VA = "0x183C8D6E0", Slot = "198")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(IDHPEHKKLEL NNHBIDDPDEK, PLFIBMEPEJL.IELFFLPENFG<T1, T2, T3, T4, T5, T6, T7, T8, T9> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x3C8C730", Offset = "0x3C8B930", VA = "0x183C8C730", Slot = "199")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(IDHPEHKKLEL NNHBIDDPDEK, JOJJLNNFJHI HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x3C8BA40", Offset = "0x3C8AC40", VA = "0x183C8BA40", Slot = "200")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(IDHPEHKKLEL NNHBIDDPDEK, FOKADDBHABI HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x3C8B5A0", Offset = "0x3C8A7A0", VA = "0x183C8B5A0", Slot = "201")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(IDHPEHKKLEL NNHBIDDPDEK, DFAFKNHMIPJ HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x3C89D60", Offset = "0x3C88F60", VA = "0x183C89D60", Slot = "202")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(IDHPEHKKLEL NNHBIDDPDEK, DOHBPOHOONN HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA, T13 JIPNGHJEIMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x3C89810", Offset = "0x3C88A10", VA = "0x183C89810", Slot = "203")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(IDHPEHKKLEL NNHBIDDPDEK, GEBFKAKOJFA HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA, T13 JIPNGHJEIMA, T14 COFFOAJAMMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x7D94E30", Offset = "0x7D94030", VA = "0x187D94E30")]
		public void RpcAllBuffered(IDHPEHKKLEL NNHBIDDPDEK, PLFIBMEPEJL.JAMCMLIMLGH<GIKIDEGCBCI> HHDOKFFBPDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x3C91290", Offset = "0x3C90490", VA = "0x183C91290")]
		public void RpcAllBuffered<T1>(IDHPEHKKLEL NNHBIDDPDEK, PLFIBMEPEJL.JLHFHGLHKCK<T1, GIKIDEGCBCI> HHDOKFFBPDP, T1 DGDONNHKDHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x3C90EE0", Offset = "0x3C900E0", VA = "0x183C90EE0")]
		public void RpcAllBuffered<T1, T2>(IDHPEHKKLEL NNHBIDDPDEK, PLFIBMEPEJL.IKNMOKALHEO<T1, T2, GIKIDEGCBCI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x3C90A40", Offset = "0x3C8FC40", VA = "0x183C90A40")]
		public void RpcAllBuffered<T1, T2, T3>(IDHPEHKKLEL NNHBIDDPDEK, PLFIBMEPEJL.LGFOENKEGMH<T1, T2, T3, GIKIDEGCBCI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x3C902A0", Offset = "0x3C8F4A0", VA = "0x183C902A0")]
		public void RpcAllBuffered<T1, T2, T3, T4>(IDHPEHKKLEL NNHBIDDPDEK, PLFIBMEPEJL.HEEBAHHJIEC<T1, T2, T3, T4, GIKIDEGCBCI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x3C8FE30", Offset = "0x3C8F030", VA = "0x183C8FE30")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(IDHPEHKKLEL NNHBIDDPDEK, PLFIBMEPEJL.KOMLIFDIAIL<T1, T2, T3, T4, T5, GIKIDEGCBCI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x3C8F410", Offset = "0x3C8E610", VA = "0x183C8F410")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(IDHPEHKKLEL NNHBIDDPDEK, PLFIBMEPEJL.HIHGCKMDIGF<T1, T2, T3, T4, T5, T6, GIKIDEGCBCI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x3C8E860", Offset = "0x3C8DA60", VA = "0x183C8E860")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(IDHPEHKKLEL NNHBIDDPDEK, PLFIBMEPEJL.NIIOGJFKOCA<T1, T2, T3, T4, T5, T6, T7, GIKIDEGCBCI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x3C8E1A0", Offset = "0x3C8D3A0", VA = "0x183C8E1A0")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(IDHPEHKKLEL NNHBIDDPDEK, PLFIBMEPEJL.IELFFLPENFG<T1, T2, T3, T4, T5, T6, T7, T8, GIKIDEGCBCI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x3C8D330", Offset = "0x3C8C530", VA = "0x183C8D330")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(IDHPEHKKLEL NNHBIDDPDEK, JOJJLNNFJHI HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x3C8CB30", Offset = "0x3C8BD30", VA = "0x183C8CB30")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(IDHPEHKKLEL NNHBIDDPDEK, FOKADDBHABI HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x3C8C2E0", Offset = "0x3C8B4E0", VA = "0x183C8C2E0")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(IDHPEHKKLEL NNHBIDDPDEK, DFAFKNHMIPJ HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x3C8AC60", Offset = "0x3C89E60", VA = "0x183C8AC60")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(IDHPEHKKLEL NNHBIDDPDEK, DOHBPOHOONN HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x3C8A260", Offset = "0x3C89460", VA = "0x183C8A260")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(IDHPEHKKLEL NNHBIDDPDEK, GEBFKAKOJFA HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA, T13 JIPNGHJEIMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x3C88D70", Offset = "0x3C87F70", VA = "0x183C88D70")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(IDHPEHKKLEL NNHBIDDPDEK, ICNEIGCHPGL HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA, T13 JIPNGHJEIMA, T14 COFFOAJAMMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x7D94ED0", Offset = "0x7D940D0", VA = "0x187D94ED0", Slot = "204")]
		public void RpcAllBuffered(IDHPEHKKLEL NNHBIDDPDEK, PLFIBMEPEJL.JAMCMLIMLGH<NIHFGKDLNDI> HHDOKFFBPDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x3C91050", Offset = "0x3C90250", VA = "0x183C91050", Slot = "205")]
		public void RpcAllBuffered<T1>(IDHPEHKKLEL NNHBIDDPDEK, PLFIBMEPEJL.JLHFHGLHKCK<T1, NIHFGKDLNDI> HHDOKFFBPDP, T1 DGDONNHKDHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x3C90C00", Offset = "0x3C8FE00", VA = "0x183C90C00", Slot = "206")]
		public void RpcAllBuffered<T1, T2>(IDHPEHKKLEL NNHBIDDPDEK, PLFIBMEPEJL.IKNMOKALHEO<T1, T2, NIHFGKDLNDI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x3C90880", Offset = "0x3C8FA80", VA = "0x183C90880", Slot = "207")]
		public void RpcAllBuffered<T1, T2, T3>(IDHPEHKKLEL NNHBIDDPDEK, PLFIBMEPEJL.LGFOENKEGMH<T1, T2, T3, NIHFGKDLNDI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x3C904B0", Offset = "0x3C8F6B0", VA = "0x183C904B0", Slot = "208")]
		public void RpcAllBuffered<T1, T2, T3, T4>(IDHPEHKKLEL NNHBIDDPDEK, PLFIBMEPEJL.HEEBAHHJIEC<T1, T2, T3, T4, NIHFGKDLNDI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x3C8FBD0", Offset = "0x3C8EDD0", VA = "0x183C8FBD0", Slot = "209")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(IDHPEHKKLEL NNHBIDDPDEK, PLFIBMEPEJL.KOMLIFDIAIL<T1, T2, T3, T4, T5, NIHFGKDLNDI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x3C8F160", Offset = "0x3C8E360", VA = "0x183C8F160", Slot = "210")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(IDHPEHKKLEL NNHBIDDPDEK, PLFIBMEPEJL.HIHGCKMDIGF<T1, T2, T3, T4, T5, T6, NIHFGKDLNDI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x3C8EB60", Offset = "0x3C8DD60", VA = "0x183C8EB60", Slot = "211")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(IDHPEHKKLEL NNHBIDDPDEK, PLFIBMEPEJL.NIIOGJFKOCA<T1, T2, T3, T4, T5, T6, T7, NIHFGKDLNDI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x3C8E500", Offset = "0x3C8D700", VA = "0x183C8E500", Slot = "212")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(IDHPEHKKLEL NNHBIDDPDEK, PLFIBMEPEJL.IELFFLPENFG<T1, T2, T3, T4, T5, T6, T7, T8, NIHFGKDLNDI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x3C8DA90", Offset = "0x3C8CC90", VA = "0x183C8DA90", Slot = "213")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(IDHPEHKKLEL NNHBIDDPDEK, JOJJLNNFJHI HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x3C8CF30", Offset = "0x3C8C130", VA = "0x183C8CF30", Slot = "214")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(IDHPEHKKLEL NNHBIDDPDEK, FOKADDBHABI HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x3C8BE90", Offset = "0x3C8B090", VA = "0x183C8BE90", Slot = "215")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(IDHPEHKKLEL NNHBIDDPDEK, DFAFKNHMIPJ HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x3C8B100", Offset = "0x3C8A300", VA = "0x183C8B100", Slot = "216")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(IDHPEHKKLEL NNHBIDDPDEK, DOHBPOHOONN HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x3C8A760", Offset = "0x3C89960", VA = "0x183C8A760", Slot = "217")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(IDHPEHKKLEL NNHBIDDPDEK, GEBFKAKOJFA HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA, T13 JIPNGHJEIMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x3C892C0", Offset = "0x3C884C0", VA = "0x183C892C0", Slot = "218")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(IDHPEHKKLEL NNHBIDDPDEK, ICNEIGCHPGL HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA, T13 JIPNGHJEIMA, T14 COFFOAJAMMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x7D965A0", Offset = "0x7D957A0", VA = "0x187D965A0", Slot = "219")]
		public void RpcOthersBuffered(IDHPEHKKLEL NNHBIDDPDEK, PLFIBMEPEJL.KDJHBMICHHD HHDOKFFBPDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x3CCB210", Offset = "0x3CCA410", VA = "0x183CCB210", Slot = "220")]
		public void RpcOthersBuffered<T1>(IDHPEHKKLEL NNHBIDDPDEK, PLFIBMEPEJL.JAMCMLIMLGH<T1> HHDOKFFBPDP, T1 DGDONNHKDHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x3CCAF80", Offset = "0x3CCA180", VA = "0x183CCAF80", Slot = "221")]
		public void RpcOthersBuffered<T1, T2>(IDHPEHKKLEL NNHBIDDPDEK, PLFIBMEPEJL.JLHFHGLHKCK<T1, T2> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x3CCA760", Offset = "0x3CC9960", VA = "0x183CCA760", Slot = "222")]
		public void RpcOthersBuffered<T1, T2, T3>(IDHPEHKKLEL NNHBIDDPDEK, PLFIBMEPEJL.IKNMOKALHEO<T1, T2, T3> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x3CCA130", Offset = "0x3CC9330", VA = "0x183CCA130", Slot = "223")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(IDHPEHKKLEL NNHBIDDPDEK, PLFIBMEPEJL.LGFOENKEGMH<T1, T2, T3, T4> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x3CC9C70", Offset = "0x3CC8E70", VA = "0x183CC9C70", Slot = "224")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(IDHPEHKKLEL NNHBIDDPDEK, PLFIBMEPEJL.HEEBAHHJIEC<T1, T2, T3, T4, T5> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x3CC94B0", Offset = "0x3CC86B0", VA = "0x183CC94B0", Slot = "225")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(IDHPEHKKLEL NNHBIDDPDEK, PLFIBMEPEJL.KOMLIFDIAIL<T1, T2, T3, T4, T5, T6> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x3CC8900", Offset = "0x3CC7B00", VA = "0x183CC8900", Slot = "226")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(IDHPEHKKLEL NNHBIDDPDEK, PLFIBMEPEJL.HIHGCKMDIGF<T1, T2, T3, T4, T5, T6, T7> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x3CC8240", Offset = "0x3CC7440", VA = "0x183CC8240", Slot = "227")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(IDHPEHKKLEL NNHBIDDPDEK, PLFIBMEPEJL.NIIOGJFKOCA<T1, T2, T3, T4, T5, T6, T7, T8> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x3CC7780", Offset = "0x3CC6980", VA = "0x183CC7780", Slot = "228")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(IDHPEHKKLEL NNHBIDDPDEK, PLFIBMEPEJL.IELFFLPENFG<T1, T2, T3, T4, T5, T6, T7, T8, T9> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x3CC67D0", Offset = "0x3CC59D0", VA = "0x183CC67D0", Slot = "229")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(IDHPEHKKLEL NNHBIDDPDEK, JOJJLNNFJHI HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x3CC6380", Offset = "0x3CC5580", VA = "0x183CC6380", Slot = "230")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(IDHPEHKKLEL NNHBIDDPDEK, FOKADDBHABI HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x3CC5640", Offset = "0x3CC4840", VA = "0x183CC5640", Slot = "231")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(IDHPEHKKLEL NNHBIDDPDEK, DFAFKNHMIPJ HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x3CC4800", Offset = "0x3CC3A00", VA = "0x183CC4800", Slot = "232")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(IDHPEHKKLEL NNHBIDDPDEK, DOHBPOHOONN HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA, T13 JIPNGHJEIMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x3CC2E10", Offset = "0x3CC2010", VA = "0x183CC2E10", Slot = "233")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(IDHPEHKKLEL NNHBIDDPDEK, GEBFKAKOJFA HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA, T13 JIPNGHJEIMA, T14 COFFOAJAMMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x7D966E0", Offset = "0x7D958E0", VA = "0x187D966E0")]
		public void RpcOthersBuffered(IDHPEHKKLEL NNHBIDDPDEK, PLFIBMEPEJL.JAMCMLIMLGH<GIKIDEGCBCI> HHDOKFFBPDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x3CCB330", Offset = "0x3CCA530", VA = "0x183CCB330")]
		public void RpcOthersBuffered<T1>(IDHPEHKKLEL NNHBIDDPDEK, PLFIBMEPEJL.JLHFHGLHKCK<T1, GIKIDEGCBCI> HHDOKFFBPDP, T1 DGDONNHKDHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x3CCACA0", Offset = "0x3CC9EA0", VA = "0x183CCACA0")]
		public void RpcOthersBuffered<T1, T2>(IDHPEHKKLEL NNHBIDDPDEK, PLFIBMEPEJL.IKNMOKALHEO<T1, T2, GIKIDEGCBCI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x3CCA920", Offset = "0x3CC9B20", VA = "0x183CCA920")]
		public void RpcOthersBuffered<T1, T2, T3>(IDHPEHKKLEL NNHBIDDPDEK, PLFIBMEPEJL.LGFOENKEGMH<T1, T2, T3, GIKIDEGCBCI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x3CCA550", Offset = "0x3CC9750", VA = "0x183CCA550")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(IDHPEHKKLEL NNHBIDDPDEK, PLFIBMEPEJL.HEEBAHHJIEC<T1, T2, T3, T4, GIKIDEGCBCI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x3CC9A10", Offset = "0x3CC8C10", VA = "0x183CC9A10")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(IDHPEHKKLEL NNHBIDDPDEK, PLFIBMEPEJL.KOMLIFDIAIL<T1, T2, T3, T4, T5, GIKIDEGCBCI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x3CC9760", Offset = "0x3CC8960", VA = "0x183CC9760")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(IDHPEHKKLEL NNHBIDDPDEK, PLFIBMEPEJL.HIHGCKMDIGF<T1, T2, T3, T4, T5, T6, GIKIDEGCBCI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x3CC8C00", Offset = "0x3CC7E00", VA = "0x183CC8C00")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(IDHPEHKKLEL NNHBIDDPDEK, PLFIBMEPEJL.NIIOGJFKOCA<T1, T2, T3, T4, T5, T6, T7, GIKIDEGCBCI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x3CC7EE0", Offset = "0x3CC70E0", VA = "0x183CC7EE0")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(IDHPEHKKLEL NNHBIDDPDEK, PLFIBMEPEJL.IELFFLPENFG<T1, T2, T3, T4, T5, T6, T7, T8, GIKIDEGCBCI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x3CC73D0", Offset = "0x3CC65D0", VA = "0x183CC73D0")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(IDHPEHKKLEL NNHBIDDPDEK, JOJJLNNFJHI HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x3CC6FD0", Offset = "0x3CC61D0", VA = "0x183CC6FD0")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(IDHPEHKKLEL NNHBIDDPDEK, FOKADDBHABI HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x3CC5F30", Offset = "0x3CC5130", VA = "0x183CC5F30")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(IDHPEHKKLEL NNHBIDDPDEK, DFAFKNHMIPJ HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x3CC4D00", Offset = "0x3CC3F00", VA = "0x183CC4D00")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(IDHPEHKKLEL NNHBIDDPDEK, DOHBPOHOONN HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x3CC3E00", Offset = "0x3CC3000", VA = "0x183CC3E00")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(IDHPEHKKLEL NNHBIDDPDEK, GEBFKAKOJFA HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA, T13 JIPNGHJEIMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x3CC3360", Offset = "0x3CC2560", VA = "0x183CC3360")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(IDHPEHKKLEL NNHBIDDPDEK, ICNEIGCHPGL HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA, T13 JIPNGHJEIMA, T14 COFFOAJAMMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x7D96640", Offset = "0x7D95840", VA = "0x187D96640", Slot = "234")]
		public void RpcOthersBuffered(IDHPEHKKLEL NNHBIDDPDEK, PLFIBMEPEJL.JAMCMLIMLGH<NIHFGKDLNDI> HHDOKFFBPDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x3CCB0F0", Offset = "0x3CCA2F0", VA = "0x183CCB0F0", Slot = "235")]
		public void RpcOthersBuffered<T1>(IDHPEHKKLEL NNHBIDDPDEK, PLFIBMEPEJL.JLHFHGLHKCK<T1, NIHFGKDLNDI> HHDOKFFBPDP, T1 DGDONNHKDHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x3CCAE10", Offset = "0x3CCA010", VA = "0x183CCAE10", Slot = "236")]
		public void RpcOthersBuffered<T1, T2>(IDHPEHKKLEL NNHBIDDPDEK, PLFIBMEPEJL.IKNMOKALHEO<T1, T2, NIHFGKDLNDI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x3CCAAE0", Offset = "0x3CC9CE0", VA = "0x183CCAAE0", Slot = "237")]
		public void RpcOthersBuffered<T1, T2, T3>(IDHPEHKKLEL NNHBIDDPDEK, PLFIBMEPEJL.LGFOENKEGMH<T1, T2, T3, NIHFGKDLNDI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x3CCA340", Offset = "0x3CC9540", VA = "0x183CCA340", Slot = "238")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(IDHPEHKKLEL NNHBIDDPDEK, PLFIBMEPEJL.HEEBAHHJIEC<T1, T2, T3, T4, NIHFGKDLNDI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x3CC9ED0", Offset = "0x3CC90D0", VA = "0x183CC9ED0", Slot = "239")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(IDHPEHKKLEL NNHBIDDPDEK, PLFIBMEPEJL.KOMLIFDIAIL<T1, T2, T3, T4, T5, NIHFGKDLNDI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x3CC9200", Offset = "0x3CC8400", VA = "0x183CC9200", Slot = "240")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(IDHPEHKKLEL NNHBIDDPDEK, PLFIBMEPEJL.HIHGCKMDIGF<T1, T2, T3, T4, T5, T6, NIHFGKDLNDI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x3CC8F00", Offset = "0x3CC8100", VA = "0x183CC8F00", Slot = "241")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(IDHPEHKKLEL NNHBIDDPDEK, PLFIBMEPEJL.NIIOGJFKOCA<T1, T2, T3, T4, T5, T6, T7, NIHFGKDLNDI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x3CC85A0", Offset = "0x3CC77A0", VA = "0x183CC85A0", Slot = "242")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(IDHPEHKKLEL NNHBIDDPDEK, PLFIBMEPEJL.IELFFLPENFG<T1, T2, T3, T4, T5, T6, T7, T8, NIHFGKDLNDI> HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x3CC7B30", Offset = "0x3CC6D30", VA = "0x183CC7B30", Slot = "243")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(IDHPEHKKLEL NNHBIDDPDEK, JOJJLNNFJHI HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x3CC6BD0", Offset = "0x3CC5DD0", VA = "0x183CC6BD0", Slot = "244")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(IDHPEHKKLEL NNHBIDDPDEK, FOKADDBHABI HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x3CC5AE0", Offset = "0x3CC4CE0", VA = "0x183CC5AE0", Slot = "245")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(IDHPEHKKLEL NNHBIDDPDEK, DFAFKNHMIPJ HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x3CC51A0", Offset = "0x3CC43A0", VA = "0x183CC51A0", Slot = "246")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(IDHPEHKKLEL NNHBIDDPDEK, DOHBPOHOONN HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x3CC4300", Offset = "0x3CC3500", VA = "0x183CC4300", Slot = "247")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(IDHPEHKKLEL NNHBIDDPDEK, GEBFKAKOJFA HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA, T13 JIPNGHJEIMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x3CC38B0", Offset = "0x3CC2AB0", VA = "0x183CC38B0", Slot = "248")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(IDHPEHKKLEL NNHBIDDPDEK, ICNEIGCHPGL HHDOKFFBPDP, T1 DGDONNHKDHE, T2 MKGDONKGCMI, T3 NAPDLAGHMPO, T4 PGPBGDKEOGO, T5 MCOMOEDPEKM, T6 ELLOAAIFEHE, T7 PMOPPLNICBD, T8 BBNFBMFKLGJ, T9 JNGDJOODFIK, T10 HJMKONJHKAL, T11 HAEAJFLEFMM, T12 FIKBMFIEPAA, T13 JIPNGHJEIMA, T14 COFFOAJAMMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x7D92BF0", Offset = "0x7D91DF0", VA = "0x187D92BF0", Slot = "249")]
		public void ClearBufferedRPCsIfMine()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x7D92E00", Offset = "0x7D92000", VA = "0x187D92E00", Slot = "250")]
		public void ClearBufferedRPCs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x1EBC110", Offset = "0x1EBB310", VA = "0x181EBC110")]
		public RRNetworkView()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class ENMBALEIJAF
{
	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x7D85820", Offset = "0x7D84A20", VA = "0x187D85820")]
	private static bool MHKJCLCNEHH(ViewId APBCLGNDGBE, [Out] RRNetworkView PEGCLJNJBJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x389AA40", Offset = "0x3899C40", VA = "0x18389AA40")]
	[CanBeNull]
	public static T PFILNIIBEMG<T>(this ViewId LIOACKIDDBK)
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
		private sealed class MPPNKFANPPP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public BNFABCHNBCL[] sorted;

			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
			public MPPNKFANPPP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x7D8A2E0", Offset = "0x7D894E0", VA = "0x187D8A2E0")]
			internal int MCDLFOLMBKB(int index)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x7D8A250", Offset = "0x7D89450", VA = "0x187D8A250")]
			internal void AHMHCOPCGEO(int index, int number)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private static readonly KEPOMIIOHBM EBHKLAMEJCE;

		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public static RRPlayerNumbering instance;

		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static BNFABCHNBCL[] SortedPlayers;

		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public const string RoomPlayerIndexedProp = "rrPnr";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		internal int ODBHNLOBBLC;

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x7D97FD0", Offset = "0x7D971D0", VA = "0x187D97FD0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x7D984F0", Offset = "0x7D976F0", VA = "0x187D984F0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x7D988A0", Offset = "0x7D97AA0", VA = "0x187D988A0")]
		private void OnJoinedRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x7D98910", Offset = "0x7D97B10", VA = "0x187D98910")]
		private void OnLeftRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x7D983F0", Offset = "0x7D975F0", VA = "0x187D983F0")]
		private void BPMJPGNGBLD(BNFABCHNBCL HHIKBHALDAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x7D983F0", Offset = "0x7D975F0", VA = "0x187D983F0")]
		private void OGBGADGDLEC(BNFABCHNBCL PPCBLDLJNIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x7D989B0", Offset = "0x7D97BB0", VA = "0x187D989B0")]
		private void PKNIOIGCLCM(BNFABCHNBCL JHMOIHCLCDG, IDictionary<object, object> MJACMKLJLLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x7D97E80", Offset = "0x7D97080", VA = "0x187D97E80")]
		public static void AssignPlayerNumbers(int MPLHFONAHOC, int BEDFGPOHHFE, Func<int, int> NFCDKJNMBBP, Action<int, int> JMBDJJKEBKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x7D98AA0", Offset = "0x7D97CA0", VA = "0x187D98AA0")]
		public void RefreshData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x7D98400", Offset = "0x7D97600", VA = "0x187D98400")]
		private void EMNFIFOFDOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0xA12940", Offset = "0xA11B40", VA = "0x180A12940")]
		public RRPlayerNumbering()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class BGNOEJBNGEP
{
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private static readonly KEPOMIIOHBM EBHKLAMEJCE;

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x7D7A6E0", Offset = "0x7D798E0", VA = "0x187D7A6E0")]
	public static int DDBDGGFABDM(this BNFABCHNBCL NLIBDKKPKLB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x7D7A880", Offset = "0x7D79A80", VA = "0x187D7A880")]
	public static void JCHDMPGPOHO(this BNFABCHNBCL NLIBDKKPKLB, int CABDJPANHPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class EPGLONOKKLN
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public delegate void MIGHJHOHNCI(Hashtable GFKOIMIAEOH);

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public delegate void MLCOLIFNOCC(BNFABCHNBCL NLIBDKKPKLB, Hashtable GFKOIMIAEOH);

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public static event MIGHJHOHNCI HFJABLBJIGB
	{
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x7D85D60", Offset = "0x7D84F60", VA = "0x187D85D60")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x7D85E20", Offset = "0x7D85020", VA = "0x187D85E20")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public static event MIGHJHOHNCI OKDEIIGJAOK
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x7D85B20", Offset = "0x7D84D20", VA = "0x187D85B20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x7D85CA0", Offset = "0x7D84EA0", VA = "0x187D85CA0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public static event MLCOLIFNOCC GGONNKLMKNO
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x7D859A0", Offset = "0x7D84BA0", VA = "0x187D859A0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x7D858E0", Offset = "0x7D84AE0", VA = "0x187D858E0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public static event MLCOLIFNOCC LDGBKJBOCJL
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x7D85BE0", Offset = "0x7D84DE0", VA = "0x187D85BE0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x7D85A60", Offset = "0x7D84C60", VA = "0x187D85A60")]
		[CompilerGenerated]
		remove
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal static class ILOIFGOEPEC
{
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private static int MHFLFHFIHMM;

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static int KNMHNLOGKJA;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static int FLPEABPGNBN;

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x7D88B90", Offset = "0x7D87D90", VA = "0x187D88B90")]
	public static void POFHLCKBKFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x7D88AB0", Offset = "0x7D87CB0", VA = "0x187D88AB0")]
	public static void JFLBLEPDLBO(int[] MBLOLFEEAAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x7D88810", Offset = "0x7D87A10", VA = "0x187D88810")]
	public static int DJLFJOAIPEP(int GHFBKGEIFAF, bool HGNIMMIHAGM = true)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[ServiceLifetime(Lifetime.Application)]
[RegisterService(typeof(NALGIKNAFEE), new string[] { })]
public class NALGIKNAFEE : FNMHNAJIPJE, PCJOCILCILM, EJADEOIPJPK
{
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static readonly Hashtable ODHKALADHEG;

	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private static readonly Hashtable CFIDCCBJPLB;

	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private static readonly Hashtable DPHAHHNECAK;

	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private static readonly FLEPBPAFMND CCGPCBFNIML;

	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private static readonly FLEPBPAFMND FKAEOOJCHJF;

	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private static readonly FLEPBPAFMND OOJMMHFBDDI;

	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private static readonly FLEPBPAFMND OKPEDMEADGB;

	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private static readonly FLEPBPAFMND KOOEMHAGCMO;

	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private static int CHNEDENCJKO;

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x7D8AB40", Offset = "0x7D89D40", VA = "0x187D8AB40", Slot = "18")]
	public void HHNCJNPAAFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x7D8C6C0", Offset = "0x7D8B8C0", VA = "0x187D8C6C0", Slot = "19")]
	public void PNAGKOGGHJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x7D8B7C0", Offset = "0x7D8A9C0", VA = "0x187D8B7C0", Slot = "4")]
	public bool JKFBIMNJILN(BGEDHHKJGFH AJLJPILGNIP, bool CODEHDNCFDI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x7D8A4C0", Offset = "0x7D896C0", VA = "0x187D8A4C0", Slot = "5")]
	public int CIGPBIELCFH(BGEDHHKJGFH[] LGLGPDLJDEE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x7D8A360", Offset = "0x7D89560", VA = "0x187D8A360", Slot = "6")]
	public bool AIHDJKHONOK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x7D8B450", Offset = "0x7D8A650", VA = "0x187D8B450", Slot = "7")]
	public bool IFICGNGLLEE(int LIOACKIDDBK, int AMMEGBDPGDG, bool INIHEKNIGFL, GameObject LBBGHAOMHLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x7D8C3F0", Offset = "0x7D8B5F0", VA = "0x187D8C3F0", Slot = "8")]
	public void OCLPLIEOAMG(int AMMEGBDPGDG, [Optional] int? NHFMGENJNHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x7D8B2E0", Offset = "0x7D8A4E0", VA = "0x187D8B2E0", Slot = "9")]
	public bool HJNHHEJPGME(HIPDGMOFECH ODLIDIMANGE, [Out] BGEDHHKJGFH NGKHBJHFIFH, bool CIFOMFBAMKL = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x7D8B8F0", Offset = "0x7D8AAF0", VA = "0x187D8B8F0", Slot = "10")]
	public bool KGEJCMDCLFP(HIPDGMOFECH ODLIDIMANGE, [Out] int PGMOLICBNBD, [Out] BGEDHHKJGFH[] LGLGPDLJDEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x7D8AA20", Offset = "0x7D89C20", VA = "0x187D8AA20", Slot = "11")]
	public bool ELHEPEMLJPO(HIPDGMOFECH ODLIDIMANGE, [Out] int AMMEGBDPGDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x7D8B5E0", Offset = "0x7D8A7E0", VA = "0x187D8B5E0", Slot = "12")]
	public void IPAPMGNJIBB(HIPDGMOFECH ODLIDIMANGE, [Out] int MMGJEOAGLED, [Out] int[] PFFHMIGKHMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x7D8BD40", Offset = "0x7D8AF40", VA = "0x187D8BD40", Slot = "13")]
	public void LAPFIILBDIN(int PGMOLICBNBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x7D8C2D0", Offset = "0x7D8B4D0", VA = "0x187D8C2D0", Slot = "14")]
	public void NNADAODACGL(int PGMOLICBNBD, int[] PFFHMIGKHMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x7D8A970", Offset = "0x7D89B70", VA = "0x187D8A970", Slot = "15")]
	public void EIOGGGOFNNG(int[] PFFHMIGKHMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x7D8A3F0", Offset = "0x7D895F0", VA = "0x187D8A3F0", Slot = "16")]
	public void BCGDMHIGKDC(int[] PFFHMIGKHMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x7D8BBD0", Offset = "0x7D8ADD0", VA = "0x187D8BBD0", Slot = "17")]
	public void KGLCFBDMCBL(int PGMOLICBNBD, int AMMEGBDPGDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x7D8BEA0", Offset = "0x7D8B0A0", VA = "0x187D8BEA0")]
	private static void NHLPCBKOFPG(BGEDHHKJGFH AJLJPILGNIP, Hashtable AMLNMADBOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x7D8ABE0", Offset = "0x7D89DE0", VA = "0x187D8ABE0")]
	private static bool HJNHHEJPGME(Hashtable AMLNMADBOHB, BNFABCHNBCL MCBHFLKONDI, [Out] BGEDHHKJGFH NGKHBJHFIFH, bool CIFOMFBAMKL = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x7D8A880", Offset = "0x7D89A80", VA = "0x187D8A880")]
	private static bool CPHCJCLMGMO(int AMMEGBDPGDG, BGEDHHKJGFH AMLNMADBOHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x7D8C5E0", Offset = "0x7D8B7E0", VA = "0x187D8C5E0")]
	private static int OELHDAMGHIM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public NALGIKNAFEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[ServiceLifetime(Lifetime.Application)]
[RegisterService(typeof(NMPPNIGNGBI), new string[] { })]
public class NMPPNIGNGBI : AADFKPJIOLJ, PCJOCILCILM, EJADEOIPJPK
{
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private static Hashtable NAEBDOGFNAO;

	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static Hashtable LPBAKAAEAMP;

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private static FLEPBPAFMND DCDMOKKEMPK;

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static readonly FLEPBPAFMND PJLJHGJGMDI;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static KEPOMIIOHBM EBHKLAMEJCE;

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x7D91690", Offset = "0x7D90890", VA = "0x187D91690", Slot = "8")]
	public void PNAGKOGGHJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x7D915F0", Offset = "0x7D907F0", VA = "0x187D915F0", Slot = "7")]
	public void HHNCJNPAAFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x7D90F50", Offset = "0x7D90150", VA = "0x187D90F50", Slot = "4")]
	public void DCNMGHMLAEM(ViewId LIOACKIDDBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x7D90BF0", Offset = "0x7D8FDF0", VA = "0x187D90BF0", Slot = "5")]
	public bool ADHDJDDCJJI(HIPDGMOFECH ODLIDIMANGE, [Out] ViewId LIOACKIDDBK, [Out] string NDKKEIEAJEI, [Out] int DCLDCHKGEFO, [Out] object[] IGDEBNHMJLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x7D91040", Offset = "0x7D90240", VA = "0x187D91040", Slot = "6")]
	public void DLKEOENKPGH(ViewId PEGCLJNJBJG, string NDKKEIEAJEI, EIDEGPMEPAM MDMEODJMNFF, BNFABCHNBCL NLIBDKKPKLB, DFOLGABGJMH HNHMCKDFDFI, object[] AJLJPILGNIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public NMPPNIGNGBI()
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
