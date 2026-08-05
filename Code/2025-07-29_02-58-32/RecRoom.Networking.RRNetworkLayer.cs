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
	public class LogRegistrationIndex : CCHAKOMCHCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8441840", Offset = "0x8440240", VA = "0x188441840", Slot = "4")]
		public override void MAJNBNPDEEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
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
			[Cpp2IlInjected.Address(RVA = "0xA88330", Offset = "0xA86D30", VA = "0x180A88330", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2349C00", Offset = "0x2348600", VA = "0x182349C00", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x844CC10", Offset = "0x844B610", VA = "0x18844CC10")]
		private void JKAPILFGJLE(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x844C9A0", Offset = "0x844B3A0", VA = "0x18844C9A0")]
		private void BEAEGHPCFKG(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x844D270", Offset = "0x844BC70", VA = "0x18844D270", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x844D320", Offset = "0x844BD20", VA = "0x18844D320")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class HFNGNJINGMG
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly MEBJEIOEDLD KIJPAPAKCDB;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static MEBJEIOEDLD CMKKFMFNHFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x843A800", Offset = "0x8439200", VA = "0x18843A800")]
		get
		{
			return default(MEBJEIOEDLD);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface NDANCDPBNLG
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	RRNetworkView FGAIALOPAOO
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	MAKEJFCDHAO KMBNLAAJNPO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool FBIEKBJACOC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480", Slot = "2")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool Serialize(CBAGBFMLEOE NNHMEPIPPDC);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void Deserialize(MCHEKKCDLFI LJOFOOFMAON, CBAGBFMLEOE NNHMEPIPPDC);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface CBNEMKHBGGD
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool IFEHAMDIBOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CPAPGLKHBIG(MCHEKKCDLFI LJOFOOFMAON);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JBBKNKCPLNK(MCHEKKCDLFI LJOFOOFMAON, CBAGBFMLEOE NNHMEPIPPDC);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface DOIBLICLNPE : INetworkUpdateSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MAJNBNPDEEJ(NDANCDPBNLG ELNOFPAPPDN);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CPOFHABEGHF(NDANCDPBNLG ELNOFPAPPDN);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KPNEKIDNMCH(KFDKBJHIMLN.HGDDALHLNJJ OEHCKOCGMAD);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JCFFDCAAEEI();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KFPOIEMACNG(object EOOLELFGEAP);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum MAKEJFCDHAO : byte
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
	GameAIAudio,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	Invalid
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct MCHEKKCDLFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public int JKFIKKHIHEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public uint ALPFCFKNCOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public double MAPFCINJPIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public int DKMFFKCAMJJ;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class ANLNNFOGNAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly Dictionary<(ViewId, MAKEJFCDHAO), CBNEMKHBGGD> FNPJNLAAFMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly List<NDANCDPBNLG> ILIBPJEDLOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly HashSet<(ViewId, MAKEJFCDHAO)> PFHILDIFOIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private int EAMKJAFPKME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public bool BNIIJGIOPCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private KFDKBJHIMLN.HGDDALHLNJJ OEHCKOCGMAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly MemoryStream ANMLGEAOGED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly CBAGBFMLEOE JMCCKGCDKHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly CBAGBFMLEOE IAHDMNIBJEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private byte[] FBCJCLOOOFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private float DDJOILIOONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private int MLGDFENIBMG;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x842F060", Offset = "0x842DA60", VA = "0x18842F060")]
	public ANLNNFOGNAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x842E700", Offset = "0x842D100", VA = "0x18842E700")]
	public void KPNEKIDNMCH(KFDKBJHIMLN.HGDDALHLNJJ OEHCKOCGMAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x842E6B0", Offset = "0x842D0B0", VA = "0x18842E6B0")]
	public void JCFFDCAAEEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x842DBA0", Offset = "0x842C5A0", VA = "0x18842DBA0")]
	public void AIICKBIOPNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x842E720", Offset = "0x842D120", VA = "0x18842E720")]
	public bool MJGPLOFFIKO(NDANCDPBNLG ELNOFPAPPDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x842DF90", Offset = "0x842C990", VA = "0x18842DF90")]
	public bool BBOPECIHIDA(NDANCDPBNLG ELNOFPAPPDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x842E0E0", Offset = "0x842CAE0", VA = "0x18842E0E0")]
	private CBNEMKHBGGD IEGGLACOEIF(ViewId JBPOBPLEADM, MAKEJFCDHAO AHJOMFIICKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x842DF80", Offset = "0x842C980", VA = "0x18842DF80")]
	public void ALFGJMHIMCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x842EC50", Offset = "0x842D650", VA = "0x18842EC50")]
	private void OLCKEMDMMLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x842E0C0", Offset = "0x842CAC0", VA = "0x18842E0C0")]
	private void DPHFGEIDJCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x842ECB0", Offset = "0x842D6B0", VA = "0x18842ECB0")]
	public bool PGCAOBPLDKH(FastBufferWriter ADMHNJGGGLG, int NFILGAKDGPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x842E300", Offset = "0x842CD00", VA = "0x18842E300")]
	public void JBBKNKCPLNK(MCHEKKCDLFI LJOFOOFMAON, FastBufferReader IOMONBOBJAC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal class CNEGKPBJJLF : CBNEMKHBGGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private NDANCDPBNLG NMIHEONPBKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private uint AGMKJGKCALP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private int BCPPKMGPNNP;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool IFEHAMDIBOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0xA93860", Offset = "0xA92260", VA = "0x180A93860")]
	public CNEGKPBJJLF(NDANCDPBNLG NMIHEONPBKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x842F280", Offset = "0x842DC80", VA = "0x18842F280", Slot = "5")]
	public bool CPAPGLKHBIG(MCHEKKCDLFI LJOFOOFMAON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x842F390", Offset = "0x842DD90", VA = "0x18842F390", Slot = "6")]
	public void JBBKNKCPLNK(MCHEKKCDLFI LJOFOOFMAON, CBAGBFMLEOE NNHMEPIPPDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class IOGBDLELBLM : CBNEMKHBGGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private KFDKBJHIMLN.HGDDALHLNJJ OEHCKOCGMAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly ViewId JBPOBPLEADM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private int BCPPKMGPNNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private uint AGMKJGKCALP;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool IFEHAMDIBOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xAA0980", Offset = "0xA9F380", VA = "0x180AA0980", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1C1BF30", Offset = "0x1C1A930", VA = "0x181C1BF30")]
	public IOGBDLELBLM(ViewId JBPOBPLEADM, KFDKBJHIMLN.HGDDALHLNJJ OEHCKOCGMAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x843C8C0", Offset = "0x843B2C0", VA = "0x18843C8C0", Slot = "5")]
	public bool CPAPGLKHBIG(MCHEKKCDLFI LJOFOOFMAON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x843C900", Offset = "0x843B300", VA = "0x18843C900", Slot = "6")]
	public void JBBKNKCPLNK(MCHEKKCDLFI LJOFOOFMAON, CBAGBFMLEOE NNHMEPIPPDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class IOCNANKNLGJ
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x843BCD0", Offset = "0x843A6D0", VA = "0x18843BCD0")]
	public static void AGNKEKDJGCC(this LINIDGPLNHA FHCIMGPBDNP, CBAGBFMLEOE GDJEPNPHONK, ViewId HCLPHJDKMCA, bool CGIHBMNGFEJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x843BE90", Offset = "0x843A890", VA = "0x18843BE90")]
	public static void BHKHCPPFGIH(this LINIDGPLNHA FHCIMGPBDNP, CBAGBFMLEOE GDJEPNPHONK, bool CGIHBMNGFEJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x843C390", Offset = "0x843AD90", VA = "0x18843C390")]
	public static LINIDGPLNHA JBBKNKCPLNK(CBAGBFMLEOE GDJEPNPHONK, ViewId HCLPHJDKMCA, bool CGIHBMNGFEJ = true)
	{
		return default(LINIDGPLNHA);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x843C500", Offset = "0x843AF00", VA = "0x18843C500")]
	public static void OGAHHKDPENM(this LINIDGPLNHA FHCIMGPBDNP, CBAGBFMLEOE GDJEPNPHONK, bool CGIHBMNGFEJ = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[RegisterService(typeof(DOIBLICLNPE), new string[] { })]
public class HEODMFAFHPK : DOIBLICLNPE, INetworkUpdateSystem, PGHMJJNBADC, NAGAKFIOPNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly MEBJEIOEDLD CMCCPPADHFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private ANLNNFOGNAN ENGIMCMALIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private uint EOEMDEPFAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private float NIADLLKCPOM;

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x843A0E0", Offset = "0x8438AE0", VA = "0x18843A0E0", Slot = "4")]
	public void MAJNBNPDEEJ(NDANCDPBNLG ELNOFPAPPDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8439C90", Offset = "0x8438690", VA = "0x188439C90", Slot = "5")]
	public void CPOFHABEGHF(NDANCDPBNLG ELNOFPAPPDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8439EF0", Offset = "0x84388F0", VA = "0x188439EF0", Slot = "10")]
	public void KEMLKJMHOGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x843A6A0", Offset = "0x84390A0", VA = "0x18843A6A0", Slot = "9")]
	public void NetworkUpdate(NetworkUpdateStage HMKLIAOOKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x84396C0", Offset = "0x84380C0", VA = "0x1884396C0")]
	private void BLDEHLAJPIC(uint HDGMOHIIDIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x843A0B0", Offset = "0x8438AB0", VA = "0x18843A0B0", Slot = "6")]
	public void KPNEKIDNMCH(KFDKBJHIMLN.HGDDALHLNJJ OEHCKOCGMAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x8439E90", Offset = "0x8438890", VA = "0x188439E90", Slot = "7")]
	public void JCFFDCAAEEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x843A050", Offset = "0x8438A50", VA = "0x18843A050", Slot = "8")]
	public void KFPOIEMACNG(object GFNNIJMCMJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x843A200", Offset = "0x8438C00", VA = "0x18843A200")]
	private void MNHMAIGAJPG(NDGFICGAFID GFNNIJMCMJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x843A580", Offset = "0x8438F80", VA = "0x18843A580", Slot = "11")]
	public void NOAMAPCJEBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x843A720", Offset = "0x8439120", VA = "0x18843A720")]
	public HEODMFAFHPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class HPKGEHLNOBI : CBNEMKHBGGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private float JJOCAHKFFMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int BCPPKMGPNNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private uint AGMKJGKCALP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly MAKEJFCDHAO BDFLFGFNFOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public MCHEKKCDLFI KJEJGEBKFFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public int OADGMMJFPOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public byte[] MFNFONHGHGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private MCHEKKCDLFI FHOAFJLPOHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private int DMHCJNMDNKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private byte[] KLPONEJMGMC;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool IFEHAMDIBOC
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x843B7A0", Offset = "0x843A1A0", VA = "0x18843B7A0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x843BB50", Offset = "0x843A550", VA = "0x18843BB50")]
	public HPKGEHLNOBI(MAKEJFCDHAO BDFLFGFNFOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x843B650", Offset = "0x843A050", VA = "0x18843B650", Slot = "5")]
	public bool CPAPGLKHBIG(MCHEKKCDLFI LJOFOOFMAON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x843B7D0", Offset = "0x843A1D0", VA = "0x18843B7D0", Slot = "6")]
	public void JBBKNKCPLNK(MCHEKKCDLFI LJOFOOFMAON, CBAGBFMLEOE NNHMEPIPPDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x843B690", Offset = "0x843A090", VA = "0x18843B690")]
	internal CNEGKPBJJLF DBJLMMKOCEK(NDANCDPBNLG ELNOFPAPPDN, CBAGBFMLEOE GDJEPNPHONK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x843B980", Offset = "0x843A380", VA = "0x18843B980")]
	private static void MDFBGOHCHBO(CNEGKPBJJLF EJIBOGKFGHG, CBAGBFMLEOE GDJEPNPHONK, MCHEKKCDLFI MLPOEDCOOLC, byte[] AEJOONCILAD, int NKHAJBHICHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[RegisterService(typeof(AIEKAOMIBMG), new string[] { })]
[ServiceLifetime(Lifetime.Application)]
public class AIEKAOMIBMG : HLPJLMMAGGP, PGHMJJNBADC, NAGAKFIOPNO
{
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private static readonly Hashtable GKLLEMGGKBJ;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static readonly Hashtable LPENHGOLOHL;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static readonly Hashtable IFOMNAIFKBA;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly LFCPHBACBIP HKKHOIEGBAA;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private static readonly LFCPHBACBIP BBDGMFBNAGN;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static readonly LFCPHBACBIP NIHPEFBHHMK;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static readonly LFCPHBACBIP IPCIJBELOLG;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static readonly LFCPHBACBIP BDPHEDKBHMA;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static int CAPGOJPJEOH;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x842CF00", Offset = "0x842B900", VA = "0x18842CF00", Slot = "4")]
	public bool IOPJPGCEDLG(JDKEBFGKIJA HKENEGGNMIM, bool LLBJGFCIHFN = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x842C010", Offset = "0x842AA10", VA = "0x18842C010", Slot = "5")]
	public int HDHAPEBALJH(JDKEBFGKIJA[] MOKJNKCPGLG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x842BAD0", Offset = "0x842A4D0", VA = "0x18842BAD0", Slot = "6")]
	public bool EFONOCCNOBI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x842B740", Offset = "0x842A140", VA = "0x18842B740", Slot = "7")]
	public bool DJKEOLJDOCA(int JBPOBPLEADM, int KCLPPIIGHEI, bool FOKCDOIFODO, GameObject CEENMGBCJEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x842B8E0", Offset = "0x842A2E0", VA = "0x18842B8E0", Slot = "8")]
	public void DPBDGPBHEMO(int KCLPPIIGHEI, [Optional] int? IPLMLJAGFDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x842CC70", Offset = "0x842B670", VA = "0x18842CC70", Slot = "9")]
	public bool IMMLAODHPMA(NDGFICGAFID EOOLELFGEAP, [Out] JDKEBFGKIJA NAIOKMIACEM, bool FGMLFNKPMIP = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x842C3D0", Offset = "0x842ADD0", VA = "0x18842C3D0", Slot = "10")]
	public bool IEBAOKNNPNO(NDGFICGAFID EOOLELFGEAP, [Out] int HCEGOEHNOJO, [Out] JDKEBFGKIJA[] MOKJNKCPGLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x842CDE0", Offset = "0x842B7E0", VA = "0x18842CDE0", Slot = "11")]
	public bool IOABLEJNGMM(NDGFICGAFID EOOLELFGEAP, [Out] int KCLPPIIGHEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x842BD60", Offset = "0x842A760", VA = "0x18842BD60", Slot = "12")]
	public void GFODHLNAAAO(NDGFICGAFID EOOLELFGEAP, [Out] int EMEFGFKMEAP, [Out] int[] FJHCMGDAJNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x842B5E0", Offset = "0x8429FE0", VA = "0x18842B5E0", Slot = "13")]
	public void CNJPGBBKLJE(int HCEGOEHNOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x842BB60", Offset = "0x842A560", VA = "0x18842BB60", Slot = "14")]
	public void EGGBBOLKEID(int HCEGOEHNOJO, int[] FJHCMGDAJNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x842D690", Offset = "0x842C090", VA = "0x18842D690", Slot = "15")]
	public void MCBJNIBODDL(int[] FJHCMGDAJNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x842BF40", Offset = "0x842A940", VA = "0x18842BF40", Slot = "16")]
	public void GKCEICFNEKO(int[] FJHCMGDAJNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x842D0E0", Offset = "0x842BAE0", VA = "0x18842D0E0", Slot = "17")]
	public void KMCPMNOJOLN(int HCEGOEHNOJO, int KCLPPIIGHEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x842D250", Offset = "0x842BC50", VA = "0x18842D250")]
	private static void LINPEPEKCAD(JDKEBFGKIJA HKENEGGNMIM, Hashtable PBBEIDLIBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x842C6B0", Offset = "0x842B0B0", VA = "0x18842C6B0")]
	private static bool IMMLAODHPMA(Hashtable PBBEIDLIBOE, POIAKMBAMML CBCHDGOOHNE, [Out] JDKEBFGKIJA NAIOKMIACEM, bool FGMLFNKPMIP = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x842BC80", Offset = "0x842A680", VA = "0x18842BC80")]
	private static int GBKMLEEKPJJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x842D040", Offset = "0x842BA40", VA = "0x18842D040", Slot = "18")]
	public void KEMLKJMHOGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x842D740", Offset = "0x842C140", VA = "0x18842D740", Slot = "19")]
	public void NOAMAPCJEBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public AIEKAOMIBMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[RegisterService(typeof(HJBKJMJKEKM), new string[] { })]
[ServiceLifetime(Lifetime.Application)]
public class HJBKJMJKEKM : JFCHLEHHFMN, PGHMJJNBADC, NAGAKFIOPNO
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static Hashtable HCCCIMPJEOA;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static Hashtable IFIFNEOEDIJ;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static LFCPHBACBIP MOMMJDLHKLD;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static readonly LFCPHBACBIP MFAACIFEIFH;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static MEBJEIOEDLD HJHMNJLNNBM;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x843A8C0", Offset = "0x84392C0", VA = "0x18843A8C0", Slot = "4")]
	public void HAJAOCEKHFB(ViewId JBPOBPLEADM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x843B0A0", Offset = "0x8439AA0", VA = "0x18843B0A0", Slot = "5")]
	public bool LGBEIMOLEAJ(NDGFICGAFID EOOLELFGEAP, [Out] ViewId JBPOBPLEADM, [Out] string BDEEHABLNHA, [Out] int AGFKAKMCAIK, [Out] object[] JEAMHIFDMBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x843A9B0", Offset = "0x84393B0", VA = "0x18843A9B0", Slot = "6")]
	public void JLFPEMJMPIA(ViewId EGPPKOBFLID, string BDEEHABLNHA, BDPLGJMNIOG NFMFMHJJOJM, POIAKMBAMML JGGGINODJOB, IMKFKJGKAJH IDMMGNEKDMI, object[] HKENEGGNMIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x843B3F0", Offset = "0x8439DF0", VA = "0x18843B3F0", Slot = "8")]
	public void NOAMAPCJEBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x843B000", Offset = "0x8439A00", VA = "0x18843B000", Slot = "7")]
	public void KEMLKJMHOGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public HJBKJMJKEKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class EJJMHNAEHCN
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x84393C0", Offset = "0x8437DC0", VA = "0x1884393C0")]
	public static POIAKMBAMML DODAFLDCBNK(this IOMKCHPPNFJ PCJBPIKLFBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8439450", Offset = "0x8437E50", VA = "0x188439450")]
	public static IOMKCHPPNFJ LDGNGDDINHF(this POIAKMBAMML JGGGINODJOB)
	{
		return default(IOMKCHPPNFJ);
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class RRNetworkBehavior : MonoBehaviour, DKKGOBNBOFA, AENFEPMOKIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private bool networkedViewInitialized;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private RRNetworkView networkedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private List<GIHNKJKBONE> destroyHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private bool isForwarderRegistered;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public ViewId FCIELONJCKA
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x8445CA0", Offset = "0x84446A0", VA = "0x188445CA0")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public ViewId FCFEJFPMJOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x8445CA0", Offset = "0x84446A0", VA = "0x188445CA0", Slot = "4")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		[Obsolete("Use NetworkedView instead")]
		public RRNetworkView FFIKJGPFGEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x8445D20", Offset = "0x8444720", VA = "0x188445D20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public RRNetworkView FGAIALOPAOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x8445D20", Offset = "0x8444720", VA = "0x188445D20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public POIAKMBAMML BFCAENILDMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8445E20", Offset = "0x8444820", VA = "0x188445E20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public POIAKMBAMML ICBGFNPAHKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x8446180", Offset = "0x8444B80", VA = "0x188446180")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool JDNHMLMHGGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8445F80", Offset = "0x8444980", VA = "0x188445F80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool ADFCGJAOKCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x84460F0", Offset = "0x8444AF0", VA = "0x1884460F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool HGHFONLJKCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8445BD0", Offset = "0x84445D0", VA = "0x188445BD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool EDNEGNOAGKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8445EB0", Offset = "0x84448B0", VA = "0x188445EB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool JEGMNJHGAAK
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x8445BD0", Offset = "0x84445D0", VA = "0x188445BD0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool GGINOGKOBFB
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x8445C50", Offset = "0x8444650", VA = "0x188445C50", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public string NHNEBHGCOGD
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x8445D90", Offset = "0x8444790", VA = "0x188445D90", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool MLCDCBFMEHP
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x8445B50", Offset = "0x8444550", VA = "0x188445B50", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<POIAKMBAMML> MAPFAANJFCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x8445A20", Offset = "0x8444420", VA = "0x188445A20")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x8446210", Offset = "0x8444C10", VA = "0x188446210")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8445980", Offset = "0x8444380", VA = "0x188445980")]
		public bool WasSpawnedForPlayer(int ILKNGKCAKEL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x773EDC0", Offset = "0x773D7C0", VA = "0x18773EDC0")]
		private void DCHCDJBKKPO(RRNetworkView GIGDEGEMDAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x84455B0", Offset = "0x8443FB0", VA = "0x1884455B0", Slot = "9")]
		public void RegisterDestroyHandler(GIHNKJKBONE LCJFNEJNIDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x84457B0", Offset = "0x84441B0", VA = "0x1884457B0", Slot = "10")]
		public void UnregisterDestroyHandler(GIHNKJKBONE LCJFNEJNIDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "11")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8445590", Offset = "0x8443F90", VA = "0x188445590", Slot = "12")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA85A30", Offset = "0xA84430", VA = "0x180A85A30")]
		public RRNetworkBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class EGPFAHCKLAF
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate void EJDEPEPJHDP([In] JDKEBFGKIJA HKENEGGNMIM, bool OPPPNBNEPEI, bool PBBEIDLIBOE, bool NLCAGPHNNBC);

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public delegate void PDBGCIKDLPK(GameObject EJLPJBJLNAK);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public delegate void DBHMJDFDKJH(GameObject EJLPJBJLNAK);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public delegate void ILMBNODCGDB(RRNetworkView EGPPKOBFLID, string BDEEHABLNHA, POIAKMBAMML GPFCEEMMIIK, BDPLGJMNIOG? IMFCAPGBDGB, bool KLGAMNCOAEI, IMKFKJGKAJH BOFFBLEJGEM, object[] HKENEGGNMIM, string PLNPJAKJNHH);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public delegate void FMJIGPDBOKD(RRNetworkView EGPPKOBFLID, string BDEEHABLNHA, POIAKMBAMML GPFCEEMMIIK, BDPLGJMNIOG? IMFCAPGBDGB, bool KLGAMNCOAEI, IMKFKJGKAJH BOFFBLEJGEM, object[] HKENEGGNMIM, string PLNPJAKJNHH);

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate void EGBJBHGIPBJ(RRNetworkView EGPPKOBFLID, string BDEEHABLNHA, object[] JEAMHIFDMBF, string HGOPJIILLAB);

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public delegate void ICMLCFPBDKG(RRNetworkView EGPPKOBFLID, POIAKMBAMML LHPBEGHPIMF);

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	[CompilerGenerated]
	private static PDBGCIKDLPK DMJNHPPBLAP;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public static event EJDEPEPJHDP FPLMKJLHJCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8438670", Offset = "0x8437070", VA = "0x188438670")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x84385B0", Offset = "0x8436FB0", VA = "0x1884385B0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public static event PDBGCIKDLPK DDNIBDPEAML
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8438C30", Offset = "0x8437630", VA = "0x188438C30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8438B70", Offset = "0x8437570", VA = "0x188438B70")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public static event DBHMJDFDKJH OAIKAODHHBC
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8438220", Offset = "0x8436C20", VA = "0x188438220")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8438E70", Offset = "0x8437870", VA = "0x188438E70")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public static event DBHMJDFDKJH GDHHALMBLIG
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8438AB0", Offset = "0x84374B0", VA = "0x188438AB0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8438CF0", Offset = "0x84376F0", VA = "0x188438CF0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public static event ILMBNODCGDB OJNCENPPGPL
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x84389F0", Offset = "0x84373F0", VA = "0x1884389F0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8438870", Offset = "0x8437270", VA = "0x188438870")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public static event FMJIGPDBOKD DGOGEGIPKKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8438930", Offset = "0x8437330", VA = "0x188438930")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8438F30", Offset = "0x8437930", VA = "0x188438F30")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public static event EGBJBHGIPBJ KAOPBOOHNKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8438DB0", Offset = "0x84377B0", VA = "0x188438DB0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x84380D0", Offset = "0x8436AD0", VA = "0x1884380D0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public static event ICMLCFPBDKG DGJBAEAJELC
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x84384F0", Offset = "0x8436EF0", VA = "0x1884384F0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8438FF0", Offset = "0x84379F0", VA = "0x188438FF0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public static event ICMLCFPBDKG PPOFOCPNLEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8438430", Offset = "0x8436E30", VA = "0x188438430")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x84391B0", Offset = "0x8437BB0", VA = "0x1884391B0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x84382E0", Offset = "0x8436CE0", VA = "0x1884382E0")]
	public static void CJPEHHHKFPP([In] JDKEBFGKIJA HKENEGGNMIM, bool OPPPNBNEPEI, bool PBBEIDLIBOE, bool NLCAGPHNNBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x84383A0", Offset = "0x8436DA0", VA = "0x1884383A0")]
	public static void DJPJPFJAINL(GameObject EJLPJBJLNAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8438190", Offset = "0x8436B90", VA = "0x188438190")]
	public static void ALFGBGJOFOG(GameObject EJLPJBJLNAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x8437FB0", Offset = "0x84369B0", VA = "0x188437FB0")]
	public static void AENJPEFIMHI(GameObject EJLPJBJLNAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x8438040", Offset = "0x8436A40", VA = "0x188438040")]
	public static void AIOPHDJFDBP(GameObject EJLPJBJLNAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x8439270", Offset = "0x8437C70", VA = "0x188439270")]
	public static void PBOLPLKOBHP(RRNetworkView EGPPKOBFLID, string BDEEHABLNHA, POIAKMBAMML GPFCEEMMIIK, BDPLGJMNIOG? IMFCAPGBDGB, bool KLGAMNCOAEI, IMKFKJGKAJH BOFFBLEJGEM, object[] HKENEGGNMIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x8438730", Offset = "0x8437130", VA = "0x188438730")]
	public static void ICMEEMOOPDD(RRNetworkView EGPPKOBFLID, string BDEEHABLNHA, int NPDOMIFAKFI, object[] JEAMHIFDMBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x84390B0", Offset = "0x8437AB0", VA = "0x1884390B0")]
	public static void ODGFDHBLGEI(int JBPOBPLEADM, int PCJBPIKLFBM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class LNNFIDLNEKH
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x8441200", Offset = "0x843FC00", VA = "0x188441200")]
	[CanBeNull]
	private static bool BLMGCKILOAN(ViewId EGJGKBPPPFG, [Out] RRNetworkView EGPPKOBFLID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x84412B0", Offset = "0x843FCB0", VA = "0x1884412B0")]
	[CanBeNull]
	public static Component DDIBIBABCDO(this ViewId EGPPKOBFLID, Type KOHJNJOONHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3D7F6B0", Offset = "0x3D7E0B0", VA = "0x183D7F6B0")]
	[CanBeNull]
	public static T DDIBIBABCDO<T>(this ViewId EGPPKOBFLID)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3D7F6B0", Offset = "0x3D7E0B0", VA = "0x183D7F6B0")]
	[CanBeNull]
	public static T MAAKCHBAJOL<T>(this ViewId EGPPKOBFLID)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3D7F640", Offset = "0x3D7E040", VA = "0x183D7F640")]
	public static bool BOLNHGPBEHF<T>(this ViewId EGPPKOBFLID, [Out] T AEAMJGPOBKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8441390", Offset = "0x843FD90", VA = "0x188441390")]
	[CanBeNull]
	public static RRNetworkView NJMNLPPHEMI(this ViewId EGPPKOBFLID)
	{
		return null;
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class RRNetworkHandler : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private static RRNetworkHandler PKGDNOOHCCN;

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public static bool AppQuits;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		internal static RRNetworkHandler NDAIDGNOFDA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x8446340", Offset = "0x8444D40", VA = "0x188446340")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8446510", Offset = "0x8444F10", VA = "0x188446510")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void StaticReset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x84464D0", Offset = "0x8444ED0", VA = "0x1884464D0")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xA85A30", Offset = "0xA84430", VA = "0x180A85A30")]
		public RRNetworkHandler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[ServiceLifetime(Lifetime.PhotonRoom)]
[RegisterService(typeof(DBJFENCLHGG), new string[] { "Photon" })]
public sealed class DBJFENCLHGG : LLNKGFHMHIB, PGHMJJNBADC, NAGAKFIOPNO, KDEKANPNNED, HBINHIAJEHP
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class ANHJOBDFPGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public int requestedViewId;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public ANHJOBDFPGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x842DAE0", Offset = "0x842C4E0", VA = "0x18842DAE0")]
		internal object OOJDDBIIFJM((int requestedViewId, int newOwnerId, int senderId) x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private static MEBJEIOEDLD MJGBNCMCLKP;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private static MEBJEIOEDLD EAMIIKBGCAA;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private static Dictionary<int, HashSet<int>> BEMNECLEEFO;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private static Dictionary<int, int> FDLPDIAJNAC;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static readonly List<(GameObject GameObject, int ParentCount)> DBECADOCADD;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static readonly List<GameObject> DLKGICLPCOH;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static List<int> PLPEANPCGEB;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly List<RRNetworkView> HKEBPAPICKH;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly LFCPHBACBIP IPCIJBELOLG;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static readonly LFCPHBACBIP BDPHEDKBHMA;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x8433D30", Offset = "0x8432730", VA = "0x188433D30", Slot = "8")]
	public void KEMLKJMHOGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x8437220", Offset = "0x8435C20", VA = "0x188437220", Slot = "9")]
	public void NOAMAPCJEBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x8432C30", Offset = "0x8431630", VA = "0x188432C30", Slot = "10")]
	public void InitExternal(JFKAHIBHGGP INBLNPFFLJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x8430790", Offset = "0x842F190", VA = "0x188430790", Slot = "11")]
	public void DNCCOHBMEFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x84351A0", Offset = "0x8433BA0", VA = "0x1884351A0")]
	private void MCHLPDPCKPP(EFMILOODCJD EMDLCHLCOLE, EFMILOODCJD BLKFHFCBEDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x8431220", Offset = "0x842FC20", VA = "0x188431220")]
	private void EKHFIKFABIL(ABOLDNGEPMH PABDGLMAMFO, ABOLDNGEPMH NIGHBDGLDCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x8433B60", Offset = "0x8432560", VA = "0x188433B60")]
	public GameObject KDFNLFHNEED(string FLBFBHGDBLM, Vector3 DDIHIBMHCDH, Quaternion JCDLBIBEGAF, Vector3 DILGPPEHCGK, ViewId JBPOBPLEADM, PJGPPIKLFJC HKENEGGNMIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x842F470", Offset = "0x842DE70", VA = "0x18842F470")]
	public GameObject AAFLMPFJAAM(string FLBFBHGDBLM, Vector3 DDIHIBMHCDH, Quaternion JCDLBIBEGAF, float DILGPPEHCGK, object[] HKENEGGNMIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x84338D0", Offset = "0x84322D0", VA = "0x1884338D0")]
	public GameObject KDCBEJBCFFI(string FLBFBHGDBLM, Vector3 DDIHIBMHCDH, Quaternion JCDLBIBEGAF, Vector3 DILGPPEHCGK, ViewId EGPPKOBFLID, PJGPPIKLFJC HKENEGGNMIM, bool NLCAGPHNNBC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x84348A0", Offset = "0x84332A0", VA = "0x1884348A0")]
	public GameObject KLANDOFPLGJ(JDKEBFGKIJA HKENEGGNMIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x842FC70", Offset = "0x842E670", VA = "0x18842FC70", Slot = "6")]
	public void BGBDNFKBDHB(GameObject EJLPJBJLNAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x8431860", Offset = "0x8430260", VA = "0x188431860")]
	public void FKPJAHELENF(GameObject CEENMGBCJEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x84348D0", Offset = "0x84332D0", VA = "0x1884348D0", Slot = "7")]
	public void KLOMAAENEON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x8430460", Offset = "0x842EE60", VA = "0x188430460", Slot = "4")]
	public GameObject[] DJNJAGEHLCB(IList<CNKABLHOHBG> AMKMJDEHLNE, bool KDAANOAHJNI = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x8431320", Offset = "0x842FD20", VA = "0x188431320", Slot = "5")]
	public void ELHCGHJDLNI(List<GameObject> CGJLLHBNOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x84350C0", Offset = "0x8433AC0", VA = "0x1884350C0")]
	public void LKNEENPHOLE(GameObject CEENMGBCJEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x84361E0", Offset = "0x8434BE0", VA = "0x1884361E0")]
	private void MNHMAIGAJPG(NDGFICGAFID EOOLELFGEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x8433700", Offset = "0x8432100", VA = "0x188433700")]
	private void JPEFFKEOCEC(NDGFICGAFID EOOLELFGEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x8430F60", Offset = "0x842F960", VA = "0x188430F60")]
	private void EIAGAPKEJGI(NDGFICGAFID EOOLELFGEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x84327F0", Offset = "0x84311F0", VA = "0x1884327F0")]
	private void IJDLDIOJGKL(NDGFICGAFID EOOLELFGEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x84318D0", Offset = "0x84302D0", VA = "0x1884318D0")]
	private void FMGAAJKELLM(NDGFICGAFID EOOLELFGEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x8430060", Offset = "0x842EA60", VA = "0x188430060")]
	private void DCDKHLBKMIM(NDGFICGAFID EOOLELFGEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x8433010", Offset = "0x8431A10", VA = "0x188433010")]
	private void JLBDAMNFOKB(NDGFICGAFID EOOLELFGEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x8430960", Offset = "0x842F360", VA = "0x188430960")]
	private GameObject EEGGLDLIHMI(string JOPFFGOACPD, Vector3 DDIHIBMHCDH, Quaternion JCDLBIBEGAF, Vector3 DILGPPEHCGK, byte KIJPAPAKCDB = 0, [Optional] object[] GPCDCFCPGFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x842F570", Offset = "0x842DF70", VA = "0x18842F570")]
	private GameObject ALHCNEPJFCP(JDKEBFGKIJA HKENEGGNMIM, bool OPPPNBNEPEI = false, bool PBBEIDLIBOE = false, bool NLCAGPHNNBC = true, bool CNOLDNKNGIP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x84317E0", Offset = "0x84301E0", VA = "0x1884317E0")]
	private static GameObject FKKFHEGGKDM(string JOPFFGOACPD, bool FNECCBGCBIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x8432E00", Offset = "0x8431800", VA = "0x188432E00")]
	private static GameObject JENHFDBLFKB(GameObject IJAFMJKMLAD, JDKEBFGKIJA HKENEGGNMIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x84364E0", Offset = "0x8434EE0", VA = "0x1884364E0")]
	private static void NFABPPBLNEK(GameObject EJLPJBJLNAK, RRNetworkView EGPPKOBFLID, [In] JDKEBFGKIJA HKENEGGNMIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x84340A0", Offset = "0x8432AA0", VA = "0x1884340A0")]
	private GameObject[] KJGBFMMNPMN(IList<CNKABLHOHBG> AMKMJDEHLNE, bool KDAANOAHJNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x84375A0", Offset = "0x8435FA0", VA = "0x1884375A0")]
	private GameObject[] OJBGIKPOGOK(JDKEBFGKIJA[] MOKJNKCPGLG, int HCEGOEHNOJO, POIAKMBAMML JGGGINODJOB, GameObject[] OPOELGPEHOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x8431DF0", Offset = "0x84307F0", VA = "0x188431DF0")]
	private GameObject FPIOHHFPDPP([In] JDKEBFGKIJA HKENEGGNMIM, GameObject IJAFMJKMLAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7721790", Offset = "0x7720190", VA = "0x187721790")]
	private static bool BFMPPBGGDHD(bool OPPPNBNEPEI, bool NLCAGPHNNBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x84365F0", Offset = "0x8434FF0", VA = "0x1884365F0")]
	private void NGBNGILDCDD(IEnumerable<GameObject> CGJLLHBNOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x84352C0", Offset = "0x8433CC0", VA = "0x1884352C0")]
	private void MIHMBKOELFD(GameObject EJLPJBJLNAK, bool CNOLDNKNGIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x8430B50", Offset = "0x842F550", VA = "0x188430B50")]
	private static void EHBMGIHFAFF(IEnumerable<GameObject> FEBFAFGPIHI, List<(GameObject GameObject, int ParentCount)> LABIOJHIJPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x8431C90", Offset = "0x8430690", VA = "0x188431C90")]
	private void FPEFEEGPBAL(int KCLPPIIGHEI, int HCEGOEHNOJO, bool CNOLDNKNGIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x8432200", Offset = "0x8430C00", VA = "0x188432200")]
	private static int HGJOFGEDJJN(int KCLPPIIGHEI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x8432AD0", Offset = "0x84314D0", VA = "0x188432AD0")]
	private void ILIFLENOJBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x84322A0", Offset = "0x8430CA0", VA = "0x1884322A0")]
	private void HLPFNOLBIJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x84336A0", Offset = "0x84320A0", VA = "0x1884336A0")]
	private static int JMCJMPHHKNP(int NELGKAMEKKK, bool NLCAGPHNNBC = true)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x8431700", Offset = "0x8430100", VA = "0x188431700")]
	private static int[] FCPECJFDNOB(int KACGHJAFJFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x8432B30", Offset = "0x8431530", VA = "0x188432B30")]
	private static int[] IMOMMPKNEJO(int ICBGFNPAHKN, int KACGHJAFJFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x8437840", Offset = "0x8436240", VA = "0x188437840")]
	private void PLJMNGGJIOE(POIAKMBAMML GHEODBLCLFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x84348E0", Offset = "0x84332E0", VA = "0x1884348E0")]
	private void LJAKHKBBPBP(POIAKMBAMML JGGGINODJOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x8437880", Offset = "0x8436280", VA = "0x188437880")]
	private void PPGFHNEDJMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x842FD80", Offset = "0x842E780", VA = "0x18842FD80")]
	private void BOIBEBOHDOB(POIAKMBAMML JGGGINODJOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x842FFC0", Offset = "0x842E9C0", VA = "0x18842FFC0")]
	private static void CNPIHEMINAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x842FC80", Offset = "0x842E680", VA = "0x18842FC80")]
	private void BNHKOIEFHOH(int[] FGLGJIGJFCB, int PEOPDDBONMF = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public DBJFENCLHGG()
	{
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class RRNetworkProfiler : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xA85A30", Offset = "0xA84430", VA = "0x180A85A30")]
		public RRNetworkProfiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[ServiceLifetime(Lifetime.PhotonRoom)]
[RegisterService(typeof(KLNFAFOJINJ), new string[] { "Photon" })]
public class KLNFAFOJINJ : PGHMJJNBADC, NAGAKFIOPNO, CMGPHJKIDGA
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct LAJEFAGEAKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public readonly MethodInfo FIHOKFJILBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly Func<MonoBehaviour, object> NCFIPDLNHFH;

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xC12020", Offset = "0xC10A20", VA = "0x180C12020")]
		public LAJEFAGEAKM(MethodInfo FIHOKFJILBN, [Optional] Func<MonoBehaviour, object> NCFIPDLNHFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7708BE0", Offset = "0x77075E0", VA = "0x187708BE0")]
		public object GKIFHMKFHCJ(MonoBehaviour MLBOMEEGFPM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class GFONEPGCCFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public FieldInfo instanceAccessFromField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public Func<MonoBehaviour, object> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public GFONEPGCCFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x84395F0", Offset = "0x8437FF0", VA = "0x1884395F0")]
		internal LAJEFAGEAKM DOBFNAFBIAK(MethodInfo methodInfo)
		{
			return default(LAJEFAGEAKM);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x49FD090", Offset = "0x49FBA90", VA = "0x1849FD090")]
		internal object BHDAJCMOEIA(MonoBehaviour mb)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class LLDFMDEMJCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public Func<MonoBehaviour, object> accessor;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public LLDFMDEMJCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7725E10", Offset = "0x7724810", VA = "0x187725E10")]
		internal LAJEFAGEAKM NDFBHDCMEOM(MethodInfo methodInfo)
		{
			return default(LAJEFAGEAKM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class PLEHMENOHJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public Type attributeType;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public PLEHMENOHJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x8445550", Offset = "0x8443F50", VA = "0x188445550")]
		internal bool EEMKMLCNCNJ(MethodInfo m)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly MEBJEIOEDLD HJHMNJLNNBM;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static Dictionary<string, int> LIPMCHMBHLI;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static List<string> LCOMMLHBDAB;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static int EALBDOBOICA;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly Stopwatch GAPAPABJBHJ;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static Dictionary<MethodInfo, ParameterInfo[]> BBJKMPMJDME;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static readonly Dictionary<Type, List<LAJEFAGEAKM>> KBKMKIBDEIC;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x843DE20", Offset = "0x843C820", VA = "0x18843DE20", Slot = "4")]
	public void KEMLKJMHOGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x8440730", Offset = "0x843F130", VA = "0x188440730", Slot = "5")]
	public void NOAMAPCJEBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x843DD90", Offset = "0x843C790", VA = "0x18843DD90")]
	public static bool KBKNJGDNOHJ(string BDEEHABLNHA, [Out] int JEPMLLHAJNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x843DCA0", Offset = "0x843C6A0", VA = "0x18843DCA0")]
	public static bool HNDMBBKEMCC(int JEPMLLHAJNJ, [Out] string BDEEHABLNHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x843E950", Offset = "0x843D350", VA = "0x18843E950")]
	private void MNHMAIGAJPG(NDGFICGAFID EOOLELFGEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x843CBA0", Offset = "0x843B5A0", VA = "0x18843CBA0", Slot = "9")]
	public string CILILBIAKLP(NDGFICGAFID EOOLELFGEAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x843D2C0", Offset = "0x843BCC0", VA = "0x18843D2C0", Slot = "8")]
	public void HAJAOCEKHFB(ViewId JBPOBPLEADM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x843E880", Offset = "0x843D280", VA = "0x18843E880", Slot = "6")]
	public void KMKKNBHFPLN(ViewId EGPPKOBFLID, string BDEEHABLNHA, POIAKMBAMML JGGGINODJOB, IMKFKJGKAJH BOFFBLEJGEM, params object[] HKENEGGNMIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x843E370", Offset = "0x843CD70", VA = "0x18843E370", Slot = "7")]
	public void KMKKNBHFPLN(ViewId EGPPKOBFLID, string BDEEHABLNHA, BDPLGJMNIOG IMFCAPGBDGB, IMKFKJGKAJH BOFFBLEJGEM, params object[] HKENEGGNMIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x843E3A0", Offset = "0x843CDA0", VA = "0x18843E3A0")]
	private void KMKKNBHFPLN(ViewId EGPPKOBFLID, string BDEEHABLNHA, BDPLGJMNIOG IMFCAPGBDGB, POIAKMBAMML JGGGINODJOB, IMKFKJGKAJH BOFFBLEJGEM, params object[] HKENEGGNMIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x843EC00", Offset = "0x843D600", VA = "0x18843EC00")]
	private void MOLMLCKINOJ(ViewId JBPOBPLEADM, string BDEEHABLNHA, POIAKMBAMML AANOAFILNFN, int AGFKAKMCAIK, object[] JEAMHIFDMBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x843CE00", Offset = "0x843B800", VA = "0x18843CE00")]
	private static void GOPMIAKHLEO(LAJEFAGEAKM LOHNFJJANPK, MonoBehaviour FGJIHLEGLMP, object[] GACFFBLMJOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x843CBD0", Offset = "0x843B5D0", VA = "0x18843CBD0")]
	private static bool EGKAJFNFFDH(ParameterInfo[] KOADGAFDJEH, Type[] NNIOEHFCNAL, [Out] bool FJHIPBPKOLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x843D3A0", Offset = "0x843BDA0", VA = "0x18843D3A0")]
	private List<LAJEFAGEAKM> HFCDLAIPFGO(MonoBehaviour FGJIHLEGLMP, Type PABMCLHKBNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x8440880", Offset = "0x843F280", VA = "0x188440880")]
	private static IEnumerable<MethodInfo> PFLOIALLLKA(Type AEOGKDPPBBE, Type BLKENLEOIDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x8440620", Offset = "0x843F020", VA = "0x188440620")]
	public static ParameterInfo[] NJBPMHBBFKA(MethodInfo KPKJNIDNPCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public KLNFAFOJINJ()
	{
	}
}
namespace RecRoom.Networking
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class RRNetworkSettings : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public const string RRNetworkSettingsFileName = "RRNetworkSettings";

		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private static RRNetworkSettings instance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[Tooltip("RPC name list.\nUsed as shortcut when sending calls.")]
		public List<string> RpcList;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static RRNetworkSettings Instance
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x84465E0", Offset = "0x8444FE0", VA = "0x1884465E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8446550", Offset = "0x8444F50", VA = "0x188446550")]
		public RRNetworkSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class RRNetworkView : MonoBehaviour, BAPEBGBNCLI, BCCABNMCHIG, MJBLICDGFEI, PFKAIMLHHGG, IGAEHEBIPKL
	{
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public enum NDOCEPOEDID
		{
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			False,
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			True_SetInSceneForRoom,
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			True_ManuallySetInPrefab
		}

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		[CompilerGenerated]
		private sealed class DEBHDJOJOND
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public int actorNumber;

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
			public DEBHDJOJOND()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x8437F50", Offset = "0x8436950", VA = "0x188437F50")]
			internal bool PNGCCFJHOBN(RRNetworkView view)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private static Dictionary<int, RRNetworkView> CICADINCHFH;

		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private static LFCPHBACBIP KNEKMNACMNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[SerializeField]
		private int viewIdField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[SerializeField]
		private int instantiationIdField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private bool JFJGMBFFEKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		internal bool JGICDAEACEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[SerializeField]
		[Tooltip("By default, prefabs cannot contain hard coded values for viewIdField; singletons that need to have consistent viewIdField across clients may set this flag to disable automatic cleaning of the property viewIdField")]
		public NDOCEPOEDID hasExplicitViewId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private bool NMGIJJCLNKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private bool DJGLMNAKDAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private int PFAOJFAMMJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private bool AIMAPPJCHKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private int PMLIKBOKLLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private POIAKMBAMML ICBGFNPAHKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private POIAKMBAMML AODFPHAIDCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private bool? HFBNNNGDBEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private bool EPGEMJPKFNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		internal bool DGGDHDJNEKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		internal MonoBehaviour[] CFLKOHDODIG;

		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private static readonly MEBJEIOEDLD DJMDMPAELDO;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public ViewId FCFEJFPMJOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x844AC70", Offset = "0x8449670", VA = "0x18844AC70")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ViewId HGPAKPALNHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x844AC70", Offset = "0x8449670", VA = "0x18844AC70", Slot = "5")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public ViewId FCIELONJCKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x844AC70", Offset = "0x8449670", VA = "0x18844AC70")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int HAPHLIKJMEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0xA8E5C0", Offset = "0xA8CFC0", VA = "0x180A8E5C0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0xA8E5D0", Offset = "0xA8CFD0", VA = "0x180A8E5D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int NKEOCHAPEAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xAADF50", Offset = "0xAAC950", VA = "0x180AADF50")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0xEB0C60", Offset = "0xEAF660", VA = "0x180EB0C60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public ViewId JANOKAFFIIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x844AAE0", Offset = "0x84494E0", VA = "0x18844AAE0")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool FOKCDOIFODO
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0xA88540", Offset = "0xA86F40", VA = "0x180A88540")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0xA88520", Offset = "0xA86F20", VA = "0x180A88520")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool AOADFAMIPOI
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x844AAF0", Offset = "0x84494F0", VA = "0x18844AAF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool CKGMAHBEGFE
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0xC33050", Offset = "0xC31A50", VA = "0x180C33050")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xBDAFA0", Offset = "0xBD99A0", VA = "0x180BDAFA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public int CFHDILIFCND
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0xAD60D0", Offset = "0xAD4AD0", VA = "0x180AD60D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public int MMODNOCLONL
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x844AA80", Offset = "0x8449480", VA = "0x18844AA80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public POIAKMBAMML IIMGDAGJIOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x844AC80", Offset = "0x8449680", VA = "0x18844AC80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public POIAKMBAMML AOFFKOMCGLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x844AA50", Offset = "0x8449450", VA = "0x18844AA50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public POIAKMBAMML BFCAENILDMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x844AA50", Offset = "0x8449450", VA = "0x18844AA50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public POIAKMBAMML HBDODLAMMLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x844AA50", Offset = "0x8449450", VA = "0x18844AA50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool NMDHDNAMGLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x844ABC0", Offset = "0x84495C0", VA = "0x18844ABC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public int AFPOOHBFFHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x844AAB0", Offset = "0x84494B0", VA = "0x18844AAB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public object[] OECNFGOHKMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0xA88320", Offset = "0xA86D20", VA = "0x180A88320")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0xA88300", Offset = "0xA86D00", VA = "0x180A88300")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool JDNHMLMHGGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x844ACB0", Offset = "0x84496B0", VA = "0x18844ACB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool NINBKNGHPAN
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x844AC40", Offset = "0x8449640", VA = "0x18844AC40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool ADGOFAPFAGI
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0xE7AD50", Offset = "0xE79750", VA = "0x180E7AD50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0xFE67A0", Offset = "0xFE51A0", VA = "0x180FE67A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool DOBFHAMEJEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0xD0CE50", Offset = "0xD0B850", VA = "0x180D0CE50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<RRNetworkView> FPBIEPGBJCN
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x844A8F0", Offset = "0x84492F0", VA = "0x18844A8F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x844AE70", Offset = "0x8449870", VA = "0x18844AE70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		private event Action<POIAKMBAMML> FHKNNCGBBJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x8448480", Offset = "0x8446E80", VA = "0x188448480")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x8447010", Offset = "0x8445A10", VA = "0x188447010")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		public event Action<POIAKMBAMML> IOIDKCHNECL
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x8448480", Offset = "0x8446E80", VA = "0x188448480")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x8447010", Offset = "0x8445A10", VA = "0x188447010")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		private event Action<int> OBFCAECCMOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x84483D0", Offset = "0x8446DD0", VA = "0x1884483D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x8447E30", Offset = "0x8446830", VA = "0x188447E30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		public event Action<int> NNBCFLJODGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x84483D0", Offset = "0x8446DD0", VA = "0x1884483D0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x8447E30", Offset = "0x8446830", VA = "0x188447E30")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		public event Action<RRNetworkView> OCGDFIEDCJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x844A9A0", Offset = "0x84493A0", VA = "0x18844A9A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x844AF20", Offset = "0x8449920", VA = "0x18844AF20")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		public event Action CMCPJADDGCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x844A840", Offset = "0x8449240", VA = "0x18844A840")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x844ADC0", Offset = "0x84497C0", VA = "0x18844ADC0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x844A670", Offset = "0x8449070", VA = "0x18844A670")]
		public static bool TryGetNetworkView(int JBPOBPLEADM, [Out] RRNetworkView EGPPKOBFLID)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x84470C0", Offset = "0x8445AC0", VA = "0x1884470C0")]
		public static RRNetworkView Find(int JBPOBPLEADM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x8447280", Offset = "0x8445C80", VA = "0x188447280")]
		public static IEnumerable<RRNetworkView> GetCreatedAndOwnedNetworkViews(int OGACJNJBOMN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x8447210", Offset = "0x8445C10", VA = "0x188447210")]
		public static IEnumerable<RRNetworkView> GetAllNetworkViews()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8448AD0", Offset = "0x84474D0", VA = "0x188448AD0")]
		public static bool RemoveNetworkView(RRNetworkView EGPPKOBFLID)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x84488A0", Offset = "0x84472A0", VA = "0x1884488A0")]
		public static void RebuildControllCacheForAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8448080", Offset = "0x8446A80", VA = "0x188448080")]
		public static void OnPlayerJoinedRoom(POIAKMBAMML IFFLFLAJAIA, List<int> FGLGJIGJFCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x84473C0", Offset = "0x8445DC0", VA = "0x1884473C0")]
		public static RRNetworkView Get(Component BIMLKJFNDFP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x8447420", Offset = "0x8445E20", VA = "0x188447420")]
		public static RRNetworkView Get(GameObject OPJAIPIFDGJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x8447A70", Offset = "0x8446470", VA = "0x188447A70")]
		private void KJCJGBIJDFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x8446E70", Offset = "0x8445870", VA = "0x188446E70")]
		public bool CreatedBy(POIAKMBAMML JGGGINODJOB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x844A480", Offset = "0x8448E80", VA = "0x18844A480")]
		public void TransferOwnership(int AGOOHFGOLJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x844A420", Offset = "0x8448E20", VA = "0x18844A420")]
		public void TransferOwnership(POIAKMBAMML LHPBEGHPIMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8447650", Offset = "0x8446050", VA = "0x188447650", Slot = "4")]
		public void Initialize(ViewId OGJFKJLOOEC, ViewId LAGEOBGBCNO, Dictionary<int, object> JAGEKIFCALJ, IOMKCHPPNFJ ICBGFNPAHKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x84475F0", Offset = "0x8445FF0", VA = "0x1884475F0")]
		public void Initialize(ViewId OGJFKJLOOEC, ViewId LAGEOBGBCNO, object[] DAINCINHAFB, IOMKCHPPNFJ ICBGFNPAHKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x8446800", Offset = "0x8445200", VA = "0x188446800")]
		protected internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x8447870", Offset = "0x8446270", VA = "0x188447870")]
		private void JIECIDGHBJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x2039E20", Offset = "0x2038820", VA = "0x182039E20")]
		internal void GMGKJIBFAAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x8447BB0", Offset = "0x84465B0", VA = "0x188447BB0", Slot = "6")]
		private void LCJHEHJMHMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x8447490", Offset = "0x8445E90", VA = "0x188447490")]
		internal bool IHJEPGHECIF(RRNetworkView KEDKOJMJHMD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x8447EE0", Offset = "0x84468E0", VA = "0x188447EE0")]
		protected internal void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x8447B50", Offset = "0x8446550", VA = "0x188447B50")]
		internal void KNMKKNADHEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x8447480", Offset = "0x8445E80", VA = "0x188447480")]
		private void IBEKCCGDBCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x8447150", Offset = "0x8445B50", VA = "0x188447150")]
		internal void GMJCLLODIAP(POIAKMBAMML LHPBEGHPIMF, int AGOOHFGOLJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x8448A30", Offset = "0x8447430", VA = "0x188448A30")]
		public void RebuildControllerCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x8448B50", Offset = "0x8447550", VA = "0x188448B50")]
		public void ResetOwnership()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x8446760", Offset = "0x8445160", VA = "0x188446760")]
		private void AKNIEFGABKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x8447500", Offset = "0x8445F00", VA = "0x188447500")]
		private void IIHBLFNHDIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x8448780", Offset = "0x8447180", VA = "0x188448780")]
		public void RPC(string BDEEHABLNHA, BDPLGJMNIOG IMFCAPGBDGB, params object[] HKENEGGNMIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x8448810", Offset = "0x8447210", VA = "0x188448810")]
		public void RPC(string BDEEHABLNHA, POIAKMBAMML GPFCEEMMIIK, params object[] HKENEGGNMIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x8448A80", Offset = "0x8447480", VA = "0x188448A80")]
		public void RefreshRpcMonoBehaviourCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x8446B80", Offset = "0x8445580", VA = "0x188446B80", Slot = "8")]
		public void Bake(BIHHMEGLCGA HCLPHJDKMCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x8446EF0", Offset = "0x84458F0", VA = "0x188446EF0")]
		private static void FCNECHIEPCL(POIAKMBAMML PIAAPOBLMOF, [Out] POIAKMBAMML PFEPHHMCGMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8446860", Offset = "0x8445260", VA = "0x188446860")]
		private static void BGNFNNDNOOE(RRNetworkView FFIKJGPFGEO, Delegate LOHNFJJANPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x84477D0", Offset = "0x84461D0", VA = "0x1884477D0")]
		private static IIMDHKOLHCE JHFOFGJPBHF(RRNetworkView FFIKJGPFGEO)
		{
			return default(IIMDHKOLHCE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8447C70", Offset = "0x8446670", VA = "0x188447C70")]
		private static void MPHBJJMMJJM(RRNetworkView FFIKJGPFGEO, Delegate LOHNFJJANPK, POIAKMBAMML HLINIPHJNLL, params object[] HKENEGGNMIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x8447D50", Offset = "0x8446750", VA = "0x188447D50")]
		private static void MPHBJJMMJJM(RRNetworkView FFIKJGPFGEO, Delegate LOHNFJJANPK, BDPLGJMNIOG HLINIPHJNLL, params object[] HKENEGGNMIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8448530", Offset = "0x8446F30", VA = "0x188448530")]
		private static void PNMLPIBAHPA(RRNetworkView FFIKJGPFGEO, Delegate LOHNFJJANPK, BDPLGJMNIOG HLINIPHJNLL, KEHGKCEOMAC HBMJOFMOOLF, params object[] HKENEGGNMIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8448680", Offset = "0x8447080", VA = "0x188448680")]
		public void RPCBuffered(string BDEEHABLNHA, BDPLGJMNIOG IMFCAPGBDGB, KEHGKCEOMAC BOFFBLEJGEM, params object[] HKENEGGNMIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8446F70", Offset = "0x8445970", VA = "0x188446F70")]
		private static bool FFEMGHPMJPG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8449000", Offset = "0x8447A00", VA = "0x188449000", Slot = "26")]
		public void RpcAll(MLDPNLLLMPJ.OFDGEJJGICH LOHNFJJANPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x3F3E920", Offset = "0x3F3D320", VA = "0x183F3E920", Slot = "9")]
		public void RpcAll<T1>(MLDPNLLLMPJ.JGJFPFFCKBE<T1> LOHNFJJANPK, T1 KMDCDIFFCDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x3F3E1A0", Offset = "0x3F3CBA0", VA = "0x183F3E1A0", Slot = "10")]
		public void RpcAll<T1, T2>(MLDPNLLLMPJ.FDGGKNKBGGG<T1, T2> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x3F3F620", Offset = "0x3F3E020", VA = "0x183F3F620", Slot = "27")]
		public void RpcAll<T1, T2, T3>(MLDPNLLLMPJ.IJNDDBLFMKG<T1, T2, T3> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x3F3E3B0", Offset = "0x3F3CDB0", VA = "0x183F3E3B0", Slot = "28")]
		public void RpcAll<T1, T2, T3, T4>(MLDPNLLLMPJ.BLHPLEPCOAL<T1, T2, T3, T4> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x3F3EFE0", Offset = "0x3F3D9E0", VA = "0x183F3EFE0", Slot = "29")]
		public void RpcAll<T1, T2, T3, T4, T5>(MLDPNLLLMPJ.ONEAFFFPAJH<T1, T2, T3, T4, T5> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x3F3FB20", Offset = "0x3F3E520", VA = "0x183F3FB20", Slot = "30")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(MLDPNLLLMPJ.JEJLLHPFOGC<T1, T2, T3, T4, T5, T6> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x3F405E0", Offset = "0x3F3EFE0", VA = "0x183F405E0", Slot = "11")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(MLDPNLLLMPJ.BFOJDIIKCKH<T1, T2, T3, T4, T5, T6, T7> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x3F449A0", Offset = "0x3F433A0", VA = "0x183F449A0", Slot = "12")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(MLDPNLLLMPJ.ICCGMHOGBPG<T1, T2, T3, T4, T5, T6, T7, T8> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x3F3FFC0", Offset = "0x3F3E9C0", VA = "0x183F3FFC0", Slot = "31")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(MLDPNLLLMPJ.HJEKLDKLIKM<T1, T2, T3, T4, T5, T6, T7, T8, T9> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x3F5B950", Offset = "0x3F5A350", VA = "0x183F5B950", Slot = "13")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BFJDAEOAMDN LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x3F5EF30", Offset = "0x3F5D930", VA = "0x183F5EF30", Slot = "32")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(IKOBEDEIMBA LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL, T11 CAPFCCBKHBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x3F5DED0", Offset = "0x3F5C8D0", VA = "0x183F5DED0", Slot = "33")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BMKNNEGOFCN LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL, T11 CAPFCCBKHBP, T12 NOJKKNFMBFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x3F5D2D0", Offset = "0x3F5BCD0", VA = "0x183F5D2D0", Slot = "34")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(ILMJGNLJOIJ LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL, T11 CAPFCCBKHBP, T12 NOJKKNFMBFC, T13 PNCONLJKFNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x3F5B080", Offset = "0x3F59A80", VA = "0x183F5B080", Slot = "35")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(EPDNFHCEAIM LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL, T11 CAPFCCBKHBP, T12 NOJKKNFMBFC, T13 PNCONLJKFNO, T14 FKACDDCIKCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x8449170", Offset = "0x8447B70", VA = "0x188449170", Slot = "36")]
		public void RpcAll(MLDPNLLLMPJ.JGJFPFFCKBE<IIMDHKOLHCE> LOHNFJJANPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x3F42180", Offset = "0x3F40B80", VA = "0x183F42180", Slot = "37")]
		public void RpcAll<T1>(MLDPNLLLMPJ.FDGGKNKBGGG<T1, IIMDHKOLHCE> LOHNFJJANPK, T1 KMDCDIFFCDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x3F42A10", Offset = "0x3F41410", VA = "0x183F42A10", Slot = "38")]
		public void RpcAll<T1, T2>(MLDPNLLLMPJ.IJNDDBLFMKG<T1, T2, IIMDHKOLHCE> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x3F3ECD0", Offset = "0x3F3D6D0", VA = "0x183F3ECD0", Slot = "39")]
		public void RpcAll<T1, T2, T3>(MLDPNLLLMPJ.BLHPLEPCOAL<T1, T2, T3, IIMDHKOLHCE> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x3F4A1E0", Offset = "0x3F48BE0", VA = "0x183F4A1E0", Slot = "40")]
		public void RpcAll<T1, T2, T3, T4>(MLDPNLLLMPJ.ONEAFFFPAJH<T1, T2, T3, T4, IIMDHKOLHCE> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x3F49C20", Offset = "0x3F48620", VA = "0x183F49C20", Slot = "41")]
		public void RpcAll<T1, T2, T3, T4, T5>(MLDPNLLLMPJ.JEJLLHPFOGC<T1, T2, T3, T4, T5, IIMDHKOLHCE> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x3F495B0", Offset = "0x3F47FB0", VA = "0x183F495B0", Slot = "42")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(MLDPNLLLMPJ.BFOJDIIKCKH<T1, T2, T3, T4, T5, T6, IIMDHKOLHCE> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x3F48E90", Offset = "0x3F47890", VA = "0x183F48E90", Slot = "43")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(MLDPNLLLMPJ.ICCGMHOGBPG<T1, T2, T3, T4, T5, T6, T7, IIMDHKOLHCE> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x3F486B0", Offset = "0x3F470B0", VA = "0x183F486B0", Slot = "44")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(MLDPNLLLMPJ.HJEKLDKLIKM<T1, T2, T3, T4, T5, T6, T7, T8, IIMDHKOLHCE> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x3F47DF0", Offset = "0x3F467F0", VA = "0x183F47DF0", Slot = "45")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BFJDAEOAMDN LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x3F5F420", Offset = "0x3F5DE20", VA = "0x183F5F420", Slot = "46")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(IKOBEDEIMBA LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x3F5E9F0", Offset = "0x3F5D3F0", VA = "0x183F5E9F0", Slot = "47")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BMKNNEGOFCN LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL, T11 CAPFCCBKHBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x3F5E440", Offset = "0x3F5CE40", VA = "0x183F5E440", Slot = "48")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(ILMJGNLJOIJ LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL, T11 CAPFCCBKHBP, T12 NOJKKNFMBFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x3F5D8B0", Offset = "0x3F5C2B0", VA = "0x183F5D8B0", Slot = "49")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(EPDNFHCEAIM LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL, T11 CAPFCCBKHBP, T12 NOJKKNFMBFC, T13 PNCONLJKFNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x3F5C610", Offset = "0x3F5B010", VA = "0x183F5C610", Slot = "50")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(GCJOBJHICDK LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL, T11 CAPFCCBKHBP, T12 NOJKKNFMBFC, T13 PNCONLJKFNO, T14 FKACDDCIKCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8448DA0", Offset = "0x84477A0", VA = "0x188448DA0", Slot = "51")]
		public void RpcAllViaServer(MLDPNLLLMPJ.OFDGEJJGICH LOHNFJJANPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x3F5AF80", Offset = "0x3F59980", VA = "0x183F5AF80", Slot = "52")]
		public void RpcAllViaServer<T1>(MLDPNLLLMPJ.JGJFPFFCKBE<T1> LOHNFJJANPK, T1 KMDCDIFFCDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x3F55790", Offset = "0x3F54190", VA = "0x183F55790", Slot = "14")]
		public void RpcAllViaServer<T1, T2>(MLDPNLLLMPJ.FDGGKNKBGGG<T1, T2> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x3F5A860", Offset = "0x3F59260", VA = "0x183F5A860", Slot = "53")]
		public void RpcAllViaServer<T1, T2, T3>(MLDPNLLLMPJ.IJNDDBLFMKG<T1, T2, T3> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x3F5A660", Offset = "0x3F59060", VA = "0x183F5A660", Slot = "54")]
		public void RpcAllViaServer<T1, T2, T3, T4>(MLDPNLLLMPJ.BLHPLEPCOAL<T1, T2, T3, T4> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x3F59FC0", Offset = "0x3F589C0", VA = "0x183F59FC0", Slot = "55")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(MLDPNLLLMPJ.ONEAFFFPAJH<T1, T2, T3, T4, T5> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3F59D30", Offset = "0x3F58730", VA = "0x183F59D30", Slot = "56")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(MLDPNLLLMPJ.JEJLLHPFOGC<T1, T2, T3, T4, T5, T6> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3F597C0", Offset = "0x3F581C0", VA = "0x183F597C0", Slot = "57")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(MLDPNLLLMPJ.BFOJDIIKCKH<T1, T2, T3, T4, T5, T6, T7> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3F591B0", Offset = "0x3F57BB0", VA = "0x183F591B0", Slot = "58")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(MLDPNLLLMPJ.ICCGMHOGBPG<T1, T2, T3, T4, T5, T6, T7, T8> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3F58B00", Offset = "0x3F57500", VA = "0x183F58B00", Slot = "59")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(MLDPNLLLMPJ.HJEKLDKLIKM<T1, T2, T3, T4, T5, T6, T7, T8, T9> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x3F57FE0", Offset = "0x3F569E0", VA = "0x183F57FE0", Slot = "60")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BFJDAEOAMDN LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x3F577A0", Offset = "0x3F561A0", VA = "0x183F577A0", Slot = "61")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(IKOBEDEIMBA LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL, T11 CAPFCCBKHBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x3F57330", Offset = "0x3F55D30", VA = "0x183F57330", Slot = "62")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BMKNNEGOFCN LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL, T11 CAPFCCBKHBP, T12 NOJKKNFMBFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x3F56540", Offset = "0x3F54F40", VA = "0x183F56540", Slot = "63")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(ILMJGNLJOIJ LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL, T11 CAPFCCBKHBP, T12 NOJKKNFMBFC, T13 PNCONLJKFNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3F55B00", Offset = "0x3F54500", VA = "0x183F55B00", Slot = "64")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(EPDNFHCEAIM LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL, T11 CAPFCCBKHBP, T12 NOJKKNFMBFC, T13 PNCONLJKFNO, T14 FKACDDCIKCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x8448ED0", Offset = "0x84478D0", VA = "0x188448ED0", Slot = "65")]
		public void RpcAllViaServer(MLDPNLLLMPJ.JGJFPFFCKBE<IIMDHKOLHCE> LOHNFJJANPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x3F5AE80", Offset = "0x3F59880", VA = "0x183F5AE80", Slot = "66")]
		public void RpcAllViaServer<T1>(MLDPNLLLMPJ.FDGGKNKBGGG<T1, IIMDHKOLHCE> LOHNFJJANPK, T1 KMDCDIFFCDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3F5AD20", Offset = "0x3F59720", VA = "0x183F5AD20", Slot = "67")]
		public void RpcAllViaServer<T1, T2>(MLDPNLLLMPJ.IJNDDBLFMKG<T1, T2, IIMDHKOLHCE> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x3F5AA10", Offset = "0x3F59410", VA = "0x183F5AA10", Slot = "68")]
		public void RpcAllViaServer<T1, T2, T3>(MLDPNLLLMPJ.BLHPLEPCOAL<T1, T2, T3, IIMDHKOLHCE> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3F5A460", Offset = "0x3F58E60", VA = "0x183F5A460", Slot = "69")]
		public void RpcAllViaServer<T1, T2, T3, T4>(MLDPNLLLMPJ.ONEAFFFPAJH<T1, T2, T3, T4, IIMDHKOLHCE> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x3F5A210", Offset = "0x3F58C10", VA = "0x183F5A210", Slot = "70")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(MLDPNLLLMPJ.JEJLLHPFOGC<T1, T2, T3, T4, T5, IIMDHKOLHCE> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x3F59AA0", Offset = "0x3F584A0", VA = "0x183F59AA0", Slot = "71")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(MLDPNLLLMPJ.BFOJDIIKCKH<T1, T2, T3, T4, T5, T6, IIMDHKOLHCE> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x3F594E0", Offset = "0x3F57EE0", VA = "0x183F594E0", Slot = "72")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(MLDPNLLLMPJ.ICCGMHOGBPG<T1, T2, T3, T4, T5, T6, T7, IIMDHKOLHCE> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x3F58E80", Offset = "0x3F57880", VA = "0x183F58E80", Slot = "73")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(MLDPNLLLMPJ.HJEKLDKLIKM<T1, T2, T3, T4, T5, T6, T7, T8, IIMDHKOLHCE> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3F58780", Offset = "0x3F57180", VA = "0x183F58780", Slot = "74")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BFJDAEOAMDN LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3F583B0", Offset = "0x3F56DB0", VA = "0x183F583B0", Slot = "75")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(IKOBEDEIMBA LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x3F57BC0", Offset = "0x3F565C0", VA = "0x183F57BC0", Slot = "76")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BMKNNEGOFCN LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL, T11 CAPFCCBKHBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3F56EC0", Offset = "0x3F558C0", VA = "0x183F56EC0", Slot = "77")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(ILMJGNLJOIJ LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL, T11 CAPFCCBKHBP, T12 NOJKKNFMBFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x3F56A00", Offset = "0x3F55400", VA = "0x183F56A00", Slot = "78")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(EPDNFHCEAIM LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL, T11 CAPFCCBKHBP, T12 NOJKKNFMBFC, T13 PNCONLJKFNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x3F56020", Offset = "0x3F54A20", VA = "0x183F56020", Slot = "79")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(GCJOBJHICDK LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL, T11 CAPFCCBKHBP, T12 NOJKKNFMBFC, T13 PNCONLJKFNO, T14 FKACDDCIKCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x8449CC0", Offset = "0x84486C0", VA = "0x188449CC0", Slot = "80")]
		public void RpcOthers(MLDPNLLLMPJ.OFDGEJJGICH LOHNFJJANPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x3F7D360", Offset = "0x3F7BD60", VA = "0x183F7D360", Slot = "15")]
		public void RpcOthers<T1>(MLDPNLLLMPJ.JGJFPFFCKBE<T1> LOHNFJJANPK, T1 KMDCDIFFCDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x3F7DC10", Offset = "0x3F7C610", VA = "0x183F7DC10", Slot = "81")]
		public void RpcOthers<T1, T2>(MLDPNLLLMPJ.FDGGKNKBGGG<T1, T2> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x3F7D0E0", Offset = "0x3F7BAE0", VA = "0x183F7D0E0", Slot = "82")]
		public void RpcOthers<T1, T2, T3>(MLDPNLLLMPJ.IJNDDBLFMKG<T1, T2, T3> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x3F83FB0", Offset = "0x3F829B0", VA = "0x183F83FB0", Slot = "83")]
		public void RpcOthers<T1, T2, T3, T4>(MLDPNLLLMPJ.BLHPLEPCOAL<T1, T2, T3, T4> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x3F83B20", Offset = "0x3F82520", VA = "0x183F83B20", Slot = "84")]
		public void RpcOthers<T1, T2, T3, T4, T5>(MLDPNLLLMPJ.ONEAFFFPAJH<T1, T2, T3, T4, T5> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x3F7E970", Offset = "0x3F7D370", VA = "0x183F7E970", Slot = "85")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(MLDPNLLLMPJ.JEJLLHPFOGC<T1, T2, T3, T4, T5, T6> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x3F82D10", Offset = "0x3F81710", VA = "0x183F82D10", Slot = "86")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(MLDPNLLLMPJ.BFOJDIIKCKH<T1, T2, T3, T4, T5, T6, T7> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x3F82650", Offset = "0x3F81050", VA = "0x183F82650", Slot = "87")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(MLDPNLLLMPJ.ICCGMHOGBPG<T1, T2, T3, T4, T5, T6, T7, T8> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x3F822A0", Offset = "0x3F80CA0", VA = "0x183F822A0", Slot = "88")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(MLDPNLLLMPJ.HJEKLDKLIKM<T1, T2, T3, T4, T5, T6, T7, T8, T9> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x3F81B00", Offset = "0x3F80500", VA = "0x183F81B00", Slot = "16")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BFJDAEOAMDN LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3F80E90", Offset = "0x3F7F890", VA = "0x183F80E90", Slot = "89")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(IKOBEDEIMBA LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL, T11 CAPFCCBKHBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3F80A00", Offset = "0x3F7F400", VA = "0x183F80A00", Slot = "90")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BMKNNEGOFCN LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL, T11 CAPFCCBKHBP, T12 NOJKKNFMBFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x3F7FB90", Offset = "0x3F7E590", VA = "0x183F7FB90", Slot = "91")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(ILMJGNLJOIJ LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL, T11 CAPFCCBKHBP, T12 NOJKKNFMBFC, T13 PNCONLJKFNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x3F7F110", Offset = "0x3F7DB10", VA = "0x183F7F110", Slot = "92")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(EPDNFHCEAIM LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL, T11 CAPFCCBKHBP, T12 NOJKKNFMBFC, T13 PNCONLJKFNO, T14 FKACDDCIKCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x8449E10", Offset = "0x8448810", VA = "0x188449E10", Slot = "93")]
		public void RpcOthers(MLDPNLLLMPJ.JGJFPFFCKBE<IIMDHKOLHCE> LOHNFJJANPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3F7D970", Offset = "0x3F7C370", VA = "0x183F7D970", Slot = "94")]
		public void RpcOthers<T1>(MLDPNLLLMPJ.FDGGKNKBGGG<T1, IIMDHKOLHCE> LOHNFJJANPK, T1 KMDCDIFFCDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3F7D790", Offset = "0x3F7C190", VA = "0x183F7D790", Slot = "95")]
		public void RpcOthers<T1, T2>(MLDPNLLLMPJ.IJNDDBLFMKG<T1, T2, IIMDHKOLHCE> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x3F84D40", Offset = "0x3F83740", VA = "0x183F84D40", Slot = "96")]
		public void RpcOthers<T1, T2, T3>(MLDPNLLLMPJ.BLHPLEPCOAL<T1, T2, T3, IIMDHKOLHCE> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3F7D4B0", Offset = "0x3F7BEB0", VA = "0x183F7D4B0", Slot = "97")]
		public void RpcOthers<T1, T2, T3, T4>(MLDPNLLLMPJ.ONEAFFFPAJH<T1, T2, T3, T4, IIMDHKOLHCE> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x3F7E100", Offset = "0x3F7CB00", VA = "0x183F7E100", Slot = "98")]
		public void RpcOthers<T1, T2, T3, T4, T5>(MLDPNLLLMPJ.JEJLLHPFOGC<T1, T2, T3, T4, T5, IIMDHKOLHCE> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3F7E440", Offset = "0x3F7CE40", VA = "0x183F7E440", Slot = "99")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(MLDPNLLLMPJ.BFOJDIIKCKH<T1, T2, T3, T4, T5, T6, IIMDHKOLHCE> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3F83020", Offset = "0x3F81A20", VA = "0x183F83020", Slot = "100")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(MLDPNLLLMPJ.ICCGMHOGBPG<T1, T2, T3, T4, T5, T6, T7, IIMDHKOLHCE> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x3F829B0", Offset = "0x3F813B0", VA = "0x183F829B0", Slot = "101")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(MLDPNLLLMPJ.HJEKLDKLIKM<T1, T2, T3, T4, T5, T6, T7, T8, IIMDHKOLHCE> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3F81EF0", Offset = "0x3F808F0", VA = "0x183F81EF0", Slot = "102")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BFJDAEOAMDN LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3F81710", Offset = "0x3F80110", VA = "0x183F81710", Slot = "103")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(IKOBEDEIMBA LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x3F812D0", Offset = "0x3F7FCD0", VA = "0x183F812D0", Slot = "104")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BMKNNEGOFCN LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL, T11 CAPFCCBKHBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x3F80570", Offset = "0x3F7EF70", VA = "0x183F80570", Slot = "105")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(ILMJGNLJOIJ LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL, T11 CAPFCCBKHBP, T12 NOJKKNFMBFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x3F80080", Offset = "0x3F7EA80", VA = "0x183F80080", Slot = "106")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(EPDNFHCEAIM LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL, T11 CAPFCCBKHBP, T12 NOJKKNFMBFC, T13 PNCONLJKFNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x3F7F650", Offset = "0x3F7E050", VA = "0x183F7F650", Slot = "107")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(GCJOBJHICDK LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL, T11 CAPFCCBKHBP, T12 NOJKKNFMBFC, T13 PNCONLJKFNO, T14 FKACDDCIKCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x84499F0", Offset = "0x84483F0", VA = "0x1884499F0", Slot = "108")]
		public void RpcMaster(MLDPNLLLMPJ.OFDGEJJGICH LOHNFJJANPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x3F6D400", Offset = "0x3F6BE00", VA = "0x183F6D400", Slot = "109")]
		public void RpcMaster<T1>(MLDPNLLLMPJ.JGJFPFFCKBE<T1> LOHNFJJANPK, T1 KMDCDIFFCDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x3F6D790", Offset = "0x3F6C190", VA = "0x183F6D790", Slot = "17")]
		public void RpcMaster<T1, T2>(MLDPNLLLMPJ.FDGGKNKBGGG<T1, T2> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x3F6D140", Offset = "0x3F6BB40", VA = "0x183F6D140", Slot = "110")]
		public void RpcMaster<T1, T2, T3>(MLDPNLLLMPJ.IJNDDBLFMKG<T1, T2, T3> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x3F6CDF0", Offset = "0x3F6B7F0", VA = "0x183F6CDF0", Slot = "111")]
		public void RpcMaster<T1, T2, T3, T4>(MLDPNLLLMPJ.BLHPLEPCOAL<T1, T2, T3, T4> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x3F70E10", Offset = "0x3F6F810", VA = "0x183F70E10", Slot = "112")]
		public void RpcMaster<T1, T2, T3, T4, T5>(MLDPNLLLMPJ.ONEAFFFPAJH<T1, T2, T3, T4, T5> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x3F731E0", Offset = "0x3F71BE0", VA = "0x183F731E0", Slot = "113")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(MLDPNLLLMPJ.JEJLLHPFOGC<T1, T2, T3, T4, T5, T6> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x3F79180", Offset = "0x3F77B80", VA = "0x183F79180", Slot = "114")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(MLDPNLLLMPJ.BFOJDIIKCKH<T1, T2, T3, T4, T5, T6, T7> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x3F78540", Offset = "0x3F76F40", VA = "0x183F78540", Slot = "115")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(MLDPNLLLMPJ.ICCGMHOGBPG<T1, T2, T3, T4, T5, T6, T7, T8> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x3F77C30", Offset = "0x3F76630", VA = "0x183F77C30", Slot = "116")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(MLDPNLLLMPJ.HJEKLDKLIKM<T1, T2, T3, T4, T5, T6, T7, T8, T9> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x3F705E0", Offset = "0x3F6EFE0", VA = "0x183F705E0", Slot = "117")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BFJDAEOAMDN LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x3F6F210", Offset = "0x3F6DC10", VA = "0x183F6F210", Slot = "118")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(IKOBEDEIMBA LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL, T11 CAPFCCBKHBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x3F75C90", Offset = "0x3F74690", VA = "0x183F75C90", Slot = "119")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BMKNNEGOFCN LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL, T11 CAPFCCBKHBP, T12 NOJKKNFMBFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x3F756B0", Offset = "0x3F740B0", VA = "0x183F756B0", Slot = "120")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(ILMJGNLJOIJ LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL, T11 CAPFCCBKHBP, T12 NOJKKNFMBFC, T13 PNCONLJKFNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x3F743B0", Offset = "0x3F72DB0", VA = "0x183F743B0", Slot = "121")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(EPDNFHCEAIM LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL, T11 CAPFCCBKHBP, T12 NOJKKNFMBFC, T13 PNCONLJKFNO, T14 FKACDDCIKCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x84497B0", Offset = "0x84481B0", VA = "0x1884497B0", Slot = "122")]
		public void RpcMaster(MLDPNLLLMPJ.JGJFPFFCKBE<IIMDHKOLHCE> LOHNFJJANPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x3F6D5A0", Offset = "0x3F6BFA0", VA = "0x183F6D5A0", Slot = "123")]
		public void RpcMaster<T1>(MLDPNLLLMPJ.FDGGKNKBGGG<T1, IIMDHKOLHCE> LOHNFJJANPK, T1 KMDCDIFFCDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x3F6E430", Offset = "0x3F6CE30", VA = "0x183F6E430", Slot = "124")]
		public void RpcMaster<T1, T2>(MLDPNLLLMPJ.IJNDDBLFMKG<T1, T2, IIMDHKOLHCE> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x3F6D9E0", Offset = "0x3F6C3E0", VA = "0x183F6D9E0", Slot = "125")]
		public void RpcMaster<T1, T2, T3>(MLDPNLLLMPJ.BLHPLEPCOAL<T1, T2, T3, IIMDHKOLHCE> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x3F7A200", Offset = "0x3F78C00", VA = "0x183F7A200", Slot = "126")]
		public void RpcMaster<T1, T2, T3, T4>(MLDPNLLLMPJ.ONEAFFFPAJH<T1, T2, T3, T4, IIMDHKOLHCE> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x3F71830", Offset = "0x3F70230", VA = "0x183F71830", Slot = "127")]
		public void RpcMaster<T1, T2, T3, T4, T5>(MLDPNLLLMPJ.JEJLLHPFOGC<T1, T2, T3, T4, T5, IIMDHKOLHCE> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x3F79850", Offset = "0x3F78250", VA = "0x183F79850", Slot = "128")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(MLDPNLLLMPJ.BFOJDIIKCKH<T1, T2, T3, T4, T5, T6, IIMDHKOLHCE> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x3F78D90", Offset = "0x3F77790", VA = "0x183F78D90", Slot = "129")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(MLDPNLLLMPJ.ICCGMHOGBPG<T1, T2, T3, T4, T5, T6, T7, IIMDHKOLHCE> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x3F78940", Offset = "0x3F77340", VA = "0x183F78940", Slot = "130")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(MLDPNLLLMPJ.HJEKLDKLIKM<T1, T2, T3, T4, T5, T6, T7, T8, IIMDHKOLHCE> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x3F78090", Offset = "0x3F76A90", VA = "0x183F78090", Slot = "131")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BFJDAEOAMDN LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x3F77260", Offset = "0x3F75C60", VA = "0x183F77260", Slot = "132")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(IKOBEDEIMBA LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x3F767D0", Offset = "0x3F751D0", VA = "0x183F767D0", Slot = "133")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BMKNNEGOFCN LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL, T11 CAPFCCBKHBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x3F76200", Offset = "0x3F74C00", VA = "0x183F76200", Slot = "134")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(ILMJGNLJOIJ LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL, T11 CAPFCCBKHBP, T12 NOJKKNFMBFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x3F75080", Offset = "0x3F73A80", VA = "0x183F75080", Slot = "135")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(EPDNFHCEAIM LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL, T11 CAPFCCBKHBP, T12 NOJKKNFMBFC, T13 PNCONLJKFNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x3F749F0", Offset = "0x3F733F0", VA = "0x183F749F0", Slot = "136")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(GCJOBJHICDK LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL, T11 CAPFCCBKHBP, T12 NOJKKNFMBFC, T13 PNCONLJKFNO, T14 FKACDDCIKCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x84493A0", Offset = "0x8447DA0", VA = "0x1884493A0", Slot = "137")]
		public void RpcAuthority(MLDPNLLLMPJ.OFDGEJJGICH LOHNFJJANPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x3F60E70", Offset = "0x3F5F870", VA = "0x183F60E70", Slot = "138")]
		public void RpcAuthority<T1>(MLDPNLLLMPJ.JGJFPFFCKBE<T1> LOHNFJJANPK, T1 KMDCDIFFCDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x3F62720", Offset = "0x3F61120", VA = "0x183F62720", Slot = "139")]
		public void RpcAuthority<T1, T2>(MLDPNLLLMPJ.FDGGKNKBGGG<T1, T2> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x3F62ED0", Offset = "0x3F618D0", VA = "0x183F62ED0", Slot = "140")]
		public void RpcAuthority<T1, T2, T3>(MLDPNLLLMPJ.IJNDDBLFMKG<T1, T2, T3> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x3F623F0", Offset = "0x3F60DF0", VA = "0x183F623F0", Slot = "141")]
		public void RpcAuthority<T1, T2, T3, T4>(MLDPNLLLMPJ.BLHPLEPCOAL<T1, T2, T3, T4> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x3F60A70", Offset = "0x3F5F470", VA = "0x183F60A70", Slot = "142")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(MLDPNLLLMPJ.ONEAFFFPAJH<T1, T2, T3, T4, T5> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x3F689A0", Offset = "0x3F673A0", VA = "0x183F689A0", Slot = "143")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(MLDPNLLLMPJ.JEJLLHPFOGC<T1, T2, T3, T4, T5, T6> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x3F681E0", Offset = "0x3F66BE0", VA = "0x183F681E0", Slot = "144")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(MLDPNLLLMPJ.BFOJDIIKCKH<T1, T2, T3, T4, T5, T6, T7> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x3F67970", Offset = "0x3F66370", VA = "0x183F67970", Slot = "145")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(MLDPNLLLMPJ.ICCGMHOGBPG<T1, T2, T3, T4, T5, T6, T7, T8> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x3F67040", Offset = "0x3F65A40", VA = "0x183F67040", Slot = "146")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(MLDPNLLLMPJ.HJEKLDKLIKM<T1, T2, T3, T4, T5, T6, T7, T8, T9> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x3F66B70", Offset = "0x3F65570", VA = "0x183F66B70", Slot = "147")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BFJDAEOAMDN LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x3F66120", Offset = "0x3F64B20", VA = "0x183F66120", Slot = "148")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(IKOBEDEIMBA LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL, T11 CAPFCCBKHBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x3F61030", Offset = "0x3F5FA30", VA = "0x183F61030", Slot = "149")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BMKNNEGOFCN LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL, T11 CAPFCCBKHBP, T12 NOJKKNFMBFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x3F64400", Offset = "0x3F62E00", VA = "0x183F64400", Slot = "150")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(ILMJGNLJOIJ LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL, T11 CAPFCCBKHBP, T12 NOJKKNFMBFC, T13 PNCONLJKFNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x3F63DB0", Offset = "0x3F627B0", VA = "0x183F63DB0", Slot = "151")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(EPDNFHCEAIM LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL, T11 CAPFCCBKHBP, T12 NOJKKNFMBFC, T13 PNCONLJKFNO, T14 FKACDDCIKCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x8449550", Offset = "0x8447F50", VA = "0x188449550", Slot = "152")]
		public void RpcAuthority(MLDPNLLLMPJ.JGJFPFFCKBE<IIMDHKOLHCE> LOHNFJJANPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x3F6B250", Offset = "0x3F69C50", VA = "0x183F6B250", Slot = "153")]
		public void RpcAuthority<T1>(MLDPNLLLMPJ.FDGGKNKBGGG<T1, IIMDHKOLHCE> LOHNFJJANPK, T1 KMDCDIFFCDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x3F6A390", Offset = "0x3F68D90", VA = "0x183F6A390", Slot = "154")]
		public void RpcAuthority<T1, T2>(MLDPNLLLMPJ.IJNDDBLFMKG<T1, T2, IIMDHKOLHCE> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x3F69EA0", Offset = "0x3F688A0", VA = "0x183F69EA0", Slot = "155")]
		public void RpcAuthority<T1, T2, T3>(MLDPNLLLMPJ.BLHPLEPCOAL<T1, T2, T3, IIMDHKOLHCE> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x3F696F0", Offset = "0x3F680F0", VA = "0x183F696F0", Slot = "156")]
		public void RpcAuthority<T1, T2, T3, T4>(MLDPNLLLMPJ.ONEAFFFPAJH<T1, T2, T3, T4, IIMDHKOLHCE> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x3F690A0", Offset = "0x3F67AA0", VA = "0x183F690A0", Slot = "157")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(MLDPNLLLMPJ.JEJLLHPFOGC<T1, T2, T3, T4, T5, IIMDHKOLHCE> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x3F68CF0", Offset = "0x3F676F0", VA = "0x183F68CF0", Slot = "158")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(MLDPNLLLMPJ.BFOJDIIKCKH<T1, T2, T3, T4, T5, T6, IIMDHKOLHCE> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x3F685A0", Offset = "0x3F66FA0", VA = "0x183F685A0", Slot = "159")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(MLDPNLLLMPJ.ICCGMHOGBPG<T1, T2, T3, T4, T5, T6, T7, IIMDHKOLHCE> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x3F67D80", Offset = "0x3F66780", VA = "0x183F67D80", Slot = "160")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(MLDPNLLLMPJ.HJEKLDKLIKM<T1, T2, T3, T4, T5, T6, T7, T8, IIMDHKOLHCE> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x3F674B0", Offset = "0x3F65EB0", VA = "0x183F674B0", Slot = "161")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BFJDAEOAMDN LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x3F66650", Offset = "0x3F65050", VA = "0x183F66650", Slot = "162")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(IKOBEDEIMBA LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x3F65BA0", Offset = "0x3F645A0", VA = "0x183F65BA0", Slot = "163")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BMKNNEGOFCN LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL, T11 CAPFCCBKHBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x3F65030", Offset = "0x3F63A30", VA = "0x183F65030", Slot = "164")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(ILMJGNLJOIJ LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL, T11 CAPFCCBKHBP, T12 NOJKKNFMBFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x3F649F0", Offset = "0x3F633F0", VA = "0x183F649F0", Slot = "165")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(EPDNFHCEAIM LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL, T11 CAPFCCBKHBP, T12 NOJKKNFMBFC, T13 PNCONLJKFNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x3F63710", Offset = "0x3F62110", VA = "0x183F63710", Slot = "166")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(GCJOBJHICDK LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL, T11 CAPFCCBKHBP, T12 NOJKKNFMBFC, T13 PNCONLJKFNO, T14 FKACDDCIKCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x8449F60", Offset = "0x8448960", VA = "0x188449F60", Slot = "18")]
		public void RpcPlayer(POIAKMBAMML JGGGINODJOB, MLDPNLLLMPJ.OFDGEJJGICH LOHNFJJANPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x3F8B710", Offset = "0x3F8A110", VA = "0x183F8B710", Slot = "19")]
		public void RpcPlayer<T1>(POIAKMBAMML JGGGINODJOB, MLDPNLLLMPJ.JGJFPFFCKBE<T1> LOHNFJJANPK, T1 KMDCDIFFCDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x3F8C650", Offset = "0x3F8B050", VA = "0x183F8C650", Slot = "20")]
		public void RpcPlayer<T1, T2>(POIAKMBAMML JGGGINODJOB, MLDPNLLLMPJ.FDGGKNKBGGG<T1, T2> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x3F8C070", Offset = "0x3F8AA70", VA = "0x183F8C070", Slot = "21")]
		public void RpcPlayer<T1, T2, T3>(POIAKMBAMML JGGGINODJOB, MLDPNLLLMPJ.IJNDDBLFMKG<T1, T2, T3> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x3F8B8E0", Offset = "0x3F8A2E0", VA = "0x183F8B8E0", Slot = "22")]
		public void RpcPlayer<T1, T2, T3, T4>(POIAKMBAMML JGGGINODJOB, MLDPNLLLMPJ.BLHPLEPCOAL<T1, T2, T3, T4> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x3F900B0", Offset = "0x3F8EAB0", VA = "0x183F900B0", Slot = "167")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(POIAKMBAMML JGGGINODJOB, MLDPNLLLMPJ.ONEAFFFPAJH<T1, T2, T3, T4, T5> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x3F8FC50", Offset = "0x3F8E650", VA = "0x183F8FC50", Slot = "168")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(POIAKMBAMML JGGGINODJOB, MLDPNLLLMPJ.JEJLLHPFOGC<T1, T2, T3, T4, T5, T6> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x3F90490", Offset = "0x3F8EE90", VA = "0x183F90490", Slot = "169")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(POIAKMBAMML JGGGINODJOB, MLDPNLLLMPJ.BFOJDIIKCKH<T1, T2, T3, T4, T5, T6, T7> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x3F90950", Offset = "0x3F8F350", VA = "0x183F90950", Slot = "170")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(POIAKMBAMML JGGGINODJOB, MLDPNLLLMPJ.ICCGMHOGBPG<T1, T2, T3, T4, T5, T6, T7, T8> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x3F96E40", Offset = "0x3F95840", VA = "0x183F96E40", Slot = "171")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(POIAKMBAMML JGGGINODJOB, MLDPNLLLMPJ.HJEKLDKLIKM<T1, T2, T3, T4, T5, T6, T7, T8, T9> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x3F95F50", Offset = "0x3F94950", VA = "0x183F95F50", Slot = "172")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(POIAKMBAMML JGGGINODJOB, BFJDAEOAMDN LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x3F8CF10", Offset = "0x3F8B910", VA = "0x183F8CF10", Slot = "23")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(POIAKMBAMML JGGGINODJOB, IKOBEDEIMBA LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL, T11 CAPFCCBKHBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x3F94EE0", Offset = "0x3F938E0", VA = "0x183F94EE0", Slot = "173")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(POIAKMBAMML JGGGINODJOB, BMKNNEGOFCN LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL, T11 CAPFCCBKHBP, T12 NOJKKNFMBFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x3F942E0", Offset = "0x3F92CE0", VA = "0x183F942E0", Slot = "174")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(POIAKMBAMML JGGGINODJOB, ILMJGNLJOIJ LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL, T11 CAPFCCBKHBP, T12 NOJKKNFMBFC, T13 PNCONLJKFNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x3F92F60", Offset = "0x3F91960", VA = "0x183F92F60", Slot = "175")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(POIAKMBAMML JGGGINODJOB, EPDNFHCEAIM LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL, T11 CAPFCCBKHBP, T12 NOJKKNFMBFC, T13 PNCONLJKFNO, T14 FKACDDCIKCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x844A160", Offset = "0x8448B60", VA = "0x18844A160", Slot = "176")]
		public void RpcPlayer(POIAKMBAMML JGGGINODJOB, MLDPNLLLMPJ.JGJFPFFCKBE<IIMDHKOLHCE> LOHNFJJANPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x3F8BC70", Offset = "0x3F8A670", VA = "0x183F8BC70", Slot = "177")]
		public void RpcPlayer<T1>(POIAKMBAMML JGGGINODJOB, MLDPNLLLMPJ.FDGGKNKBGGG<T1, IIMDHKOLHCE> LOHNFJJANPK, T1 KMDCDIFFCDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x3F8CC30", Offset = "0x3F8B630", VA = "0x183F8CC30", Slot = "24")]
		public void RpcPlayer<T1, T2>(POIAKMBAMML JGGGINODJOB, MLDPNLLLMPJ.IJNDDBLFMKG<T1, T2, IIMDHKOLHCE> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x3F8C8C0", Offset = "0x3F8B2C0", VA = "0x183F8C8C0", Slot = "25")]
		public void RpcPlayer<T1, T2, T3>(POIAKMBAMML JGGGINODJOB, MLDPNLLLMPJ.BLHPLEPCOAL<T1, T2, T3, IIMDHKOLHCE> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x3F8E6F0", Offset = "0x3F8D0F0", VA = "0x183F8E6F0", Slot = "178")]
		public void RpcPlayer<T1, T2, T3, T4>(POIAKMBAMML JGGGINODJOB, MLDPNLLLMPJ.ONEAFFFPAJH<T1, T2, T3, T4, IIMDHKOLHCE> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x3F98A70", Offset = "0x3F97470", VA = "0x183F98A70", Slot = "179")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(POIAKMBAMML JGGGINODJOB, MLDPNLLLMPJ.JEJLLHPFOGC<T1, T2, T3, T4, T5, IIMDHKOLHCE> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x3F98350", Offset = "0x3F96D50", VA = "0x183F98350", Slot = "180")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(POIAKMBAMML JGGGINODJOB, MLDPNLLLMPJ.BFOJDIIKCKH<T1, T2, T3, T4, T5, T6, IIMDHKOLHCE> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x3F97F30", Offset = "0x3F96930", VA = "0x183F97F30", Slot = "181")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(POIAKMBAMML JGGGINODJOB, MLDPNLLLMPJ.ICCGMHOGBPG<T1, T2, T3, T4, T5, T6, T7, IIMDHKOLHCE> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x3F976F0", Offset = "0x3F960F0", VA = "0x183F976F0", Slot = "182")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(POIAKMBAMML JGGGINODJOB, MLDPNLLLMPJ.HJEKLDKLIKM<T1, T2, T3, T4, T5, T6, T7, T8, IIMDHKOLHCE> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x3F96970", Offset = "0x3F95370", VA = "0x183F96970", Slot = "183")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(POIAKMBAMML JGGGINODJOB, BFJDAEOAMDN LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x3F96440", Offset = "0x3F94E40", VA = "0x183F96440", Slot = "184")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(POIAKMBAMML JGGGINODJOB, IKOBEDEIMBA LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x3F959C0", Offset = "0x3F943C0", VA = "0x183F959C0", Slot = "185")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(POIAKMBAMML JGGGINODJOB, BMKNNEGOFCN LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL, T11 CAPFCCBKHBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x3F948F0", Offset = "0x3F932F0", VA = "0x183F948F0", Slot = "186")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(POIAKMBAMML JGGGINODJOB, ILMJGNLJOIJ LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL, T11 CAPFCCBKHBP, T12 NOJKKNFMBFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x3F93C90", Offset = "0x3F92690", VA = "0x183F93C90", Slot = "187")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(POIAKMBAMML JGGGINODJOB, EPDNFHCEAIM LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL, T11 CAPFCCBKHBP, T12 NOJKKNFMBFC, T13 PNCONLJKFNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x3F935D0", Offset = "0x3F91FD0", VA = "0x183F935D0", Slot = "188")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(POIAKMBAMML JGGGINODJOB, GCJOBJHICDK LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL, T11 CAPFCCBKHBP, T12 NOJKKNFMBFC, T13 PNCONLJKFNO, T14 FKACDDCIKCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x8448D00", Offset = "0x8447700", VA = "0x188448D00", Slot = "189")]
		public void RpcAllBuffered(KEHGKCEOMAC BOFFBLEJGEM, MLDPNLLLMPJ.OFDGEJJGICH LOHNFJJANPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x3F55670", Offset = "0x3F54070", VA = "0x183F55670", Slot = "190")]
		public void RpcAllBuffered<T1>(KEHGKCEOMAC BOFFBLEJGEM, MLDPNLLLMPJ.JGJFPFFCKBE<T1> LOHNFJJANPK, T1 KMDCDIFFCDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x3F553E0", Offset = "0x3F53DE0", VA = "0x183F553E0", Slot = "191")]
		public void RpcAllBuffered<T1, T2>(KEHGKCEOMAC BOFFBLEJGEM, MLDPNLLLMPJ.FDGGKNKBGGG<T1, T2> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x3F550B0", Offset = "0x3F53AB0", VA = "0x183F550B0", Slot = "192")]
		public void RpcAllBuffered<T1, T2, T3>(KEHGKCEOMAC BOFFBLEJGEM, MLDPNLLLMPJ.IJNDDBLFMKG<T1, T2, T3> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x3F54AD0", Offset = "0x3F534D0", VA = "0x183F54AD0", Slot = "193")]
		public void RpcAllBuffered<T1, T2, T3, T4>(KEHGKCEOMAC BOFFBLEJGEM, MLDPNLLLMPJ.BLHPLEPCOAL<T1, T2, T3, T4> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x3F54630", Offset = "0x3F53030", VA = "0x183F54630", Slot = "194")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(KEHGKCEOMAC BOFFBLEJGEM, MLDPNLLLMPJ.ONEAFFFPAJH<T1, T2, T3, T4, T5> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x3F540F0", Offset = "0x3F52AF0", VA = "0x183F540F0", Slot = "195")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(KEHGKCEOMAC BOFFBLEJGEM, MLDPNLLLMPJ.JEJLLHPFOGC<T1, T2, T3, T4, T5, T6> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x3F53B10", Offset = "0x3F52510", VA = "0x183F53B10", Slot = "196")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(KEHGKCEOMAC BOFFBLEJGEM, MLDPNLLLMPJ.BFOJDIIKCKH<T1, T2, T3, T4, T5, T6, T7> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x3F537D0", Offset = "0x3F521D0", VA = "0x183F537D0", Slot = "197")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(KEHGKCEOMAC BOFFBLEJGEM, MLDPNLLLMPJ.ICCGMHOGBPG<T1, T2, T3, T4, T5, T6, T7, T8> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x3F53100", Offset = "0x3F51B00", VA = "0x183F53100", Slot = "198")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(KEHGKCEOMAC BOFFBLEJGEM, MLDPNLLLMPJ.HJEKLDKLIKM<T1, T2, T3, T4, T5, T6, T7, T8, T9> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x3F525B0", Offset = "0x3F50FB0", VA = "0x183F525B0", Slot = "199")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(KEHGKCEOMAC BOFFBLEJGEM, BFJDAEOAMDN LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x3F51D50", Offset = "0x3F50750", VA = "0x183F51D50", Slot = "200")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(KEHGKCEOMAC BOFFBLEJGEM, IKOBEDEIMBA LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL, T11 CAPFCCBKHBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x3F51450", Offset = "0x3F4FE50", VA = "0x183F51450", Slot = "201")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(KEHGKCEOMAC BOFFBLEJGEM, BMKNNEGOFCN LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL, T11 CAPFCCBKHBP, T12 NOJKKNFMBFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x3F50AB0", Offset = "0x3F4F4B0", VA = "0x183F50AB0", Slot = "202")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(KEHGKCEOMAC BOFFBLEJGEM, ILMJGNLJOIJ LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL, T11 CAPFCCBKHBP, T12 NOJKKNFMBFC, T13 PNCONLJKFNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x3F50070", Offset = "0x3F4EA70", VA = "0x183F50070", Slot = "203")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(KEHGKCEOMAC BOFFBLEJGEM, EPDNFHCEAIM LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL, T11 CAPFCCBKHBP, T12 NOJKKNFMBFC, T13 PNCONLJKFNO, T14 FKACDDCIKCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x8448C60", Offset = "0x8447660", VA = "0x188448C60", Slot = "204")]
		public void RpcAllBuffered(KEHGKCEOMAC BOFFBLEJGEM, MLDPNLLLMPJ.JGJFPFFCKBE<IIMDHKOLHCE> LOHNFJJANPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x3F55550", Offset = "0x3F53F50", VA = "0x183F55550", Slot = "205")]
		public void RpcAllBuffered<T1>(KEHGKCEOMAC BOFFBLEJGEM, MLDPNLLLMPJ.FDGGKNKBGGG<T1, IIMDHKOLHCE> LOHNFJJANPK, T1 KMDCDIFFCDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x3F55270", Offset = "0x3F53C70", VA = "0x183F55270", Slot = "206")]
		public void RpcAllBuffered<T1, T2>(KEHGKCEOMAC BOFFBLEJGEM, MLDPNLLLMPJ.IJNDDBLFMKG<T1, T2, IIMDHKOLHCE> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x3F54EF0", Offset = "0x3F538F0", VA = "0x183F54EF0", Slot = "207")]
		public void RpcAllBuffered<T1, T2, T3>(KEHGKCEOMAC BOFFBLEJGEM, MLDPNLLLMPJ.BLHPLEPCOAL<T1, T2, T3, IIMDHKOLHCE> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x3F54CE0", Offset = "0x3F536E0", VA = "0x183F54CE0", Slot = "208")]
		public void RpcAllBuffered<T1, T2, T3, T4>(KEHGKCEOMAC BOFFBLEJGEM, MLDPNLLLMPJ.ONEAFFFPAJH<T1, T2, T3, T4, IIMDHKOLHCE> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x3F54880", Offset = "0x3F53280", VA = "0x183F54880", Slot = "209")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(KEHGKCEOMAC BOFFBLEJGEM, MLDPNLLLMPJ.JEJLLHPFOGC<T1, T2, T3, T4, T5, IIMDHKOLHCE> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x3F54390", Offset = "0x3F52D90", VA = "0x183F54390", Slot = "210")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(KEHGKCEOMAC BOFFBLEJGEM, MLDPNLLLMPJ.BFOJDIIKCKH<T1, T2, T3, T4, T5, T6, IIMDHKOLHCE> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x3F53E00", Offset = "0x3F52800", VA = "0x183F53E00", Slot = "211")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(KEHGKCEOMAC BOFFBLEJGEM, MLDPNLLLMPJ.ICCGMHOGBPG<T1, T2, T3, T4, T5, T6, T7, IIMDHKOLHCE> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x3F53490", Offset = "0x3F51E90", VA = "0x183F53490", Slot = "212")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(KEHGKCEOMAC BOFFBLEJGEM, MLDPNLLLMPJ.HJEKLDKLIKM<T1, T2, T3, T4, T5, T6, T7, T8, IIMDHKOLHCE> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x3F52D70", Offset = "0x3F51770", VA = "0x183F52D70", Slot = "213")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(KEHGKCEOMAC BOFFBLEJGEM, BFJDAEOAMDN LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x3F52990", Offset = "0x3F51390", VA = "0x183F52990", Slot = "214")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(KEHGKCEOMAC BOFFBLEJGEM, IKOBEDEIMBA LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x3F52180", Offset = "0x3F50B80", VA = "0x183F52180", Slot = "215")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(KEHGKCEOMAC BOFFBLEJGEM, BMKNNEGOFCN LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL, T11 CAPFCCBKHBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x3F518D0", Offset = "0x3F502D0", VA = "0x183F518D0", Slot = "216")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(KEHGKCEOMAC BOFFBLEJGEM, ILMJGNLJOIJ LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL, T11 CAPFCCBKHBP, T12 NOJKKNFMBFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x3F50F80", Offset = "0x3F4F980", VA = "0x183F50F80", Slot = "217")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(KEHGKCEOMAC BOFFBLEJGEM, EPDNFHCEAIM LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL, T11 CAPFCCBKHBP, T12 NOJKKNFMBFC, T13 PNCONLJKFNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x3F50590", Offset = "0x3F4EF90", VA = "0x183F50590", Slot = "218")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(KEHGKCEOMAC BOFFBLEJGEM, GCJOBJHICDK LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL, T11 CAPFCCBKHBP, T12 NOJKKNFMBFC, T13 PNCONLJKFNO, T14 FKACDDCIKCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x8449C20", Offset = "0x8448620", VA = "0x188449C20", Slot = "219")]
		public void RpcOthersBuffered(KEHGKCEOMAC BOFFBLEJGEM, MLDPNLLLMPJ.OFDGEJJGICH LOHNFJJANPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x3F8B4D0", Offset = "0x3F89ED0", VA = "0x183F8B4D0", Slot = "220")]
		public void RpcOthersBuffered<T1>(KEHGKCEOMAC BOFFBLEJGEM, MLDPNLLLMPJ.JGJFPFFCKBE<T1> LOHNFJJANPK, T1 KMDCDIFFCDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x3F8B1F0", Offset = "0x3F89BF0", VA = "0x183F8B1F0", Slot = "221")]
		public void RpcOthersBuffered<T1, T2>(KEHGKCEOMAC BOFFBLEJGEM, MLDPNLLLMPJ.FDGGKNKBGGG<T1, T2> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x3F8B030", Offset = "0x3F89A30", VA = "0x183F8B030", Slot = "222")]
		public void RpcOthersBuffered<T1, T2, T3>(KEHGKCEOMAC BOFFBLEJGEM, MLDPNLLLMPJ.IJNDDBLFMKG<T1, T2, T3> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x3F8AA50", Offset = "0x3F89450", VA = "0x183F8AA50", Slot = "223")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(KEHGKCEOMAC BOFFBLEJGEM, MLDPNLLLMPJ.BLHPLEPCOAL<T1, T2, T3, T4> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x3F8A800", Offset = "0x3F89200", VA = "0x183F8A800", Slot = "224")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(KEHGKCEOMAC BOFFBLEJGEM, MLDPNLLLMPJ.ONEAFFFPAJH<T1, T2, T3, T4, T5> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x3F8A070", Offset = "0x3F88A70", VA = "0x183F8A070", Slot = "225")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(KEHGKCEOMAC BOFFBLEJGEM, MLDPNLLLMPJ.JEJLLHPFOGC<T1, T2, T3, T4, T5, T6> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x3F89A90", Offset = "0x3F88490", VA = "0x183F89A90", Slot = "226")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(KEHGKCEOMAC BOFFBLEJGEM, MLDPNLLLMPJ.BFOJDIIKCKH<T1, T2, T3, T4, T5, T6, T7> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x3F89750", Offset = "0x3F88150", VA = "0x183F89750", Slot = "227")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(KEHGKCEOMAC BOFFBLEJGEM, MLDPNLLLMPJ.ICCGMHOGBPG<T1, T2, T3, T4, T5, T6, T7, T8> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x3F89080", Offset = "0x3F87A80", VA = "0x183F89080", Slot = "228")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(KEHGKCEOMAC BOFFBLEJGEM, MLDPNLLLMPJ.HJEKLDKLIKM<T1, T2, T3, T4, T5, T6, T7, T8, T9> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x3F88530", Offset = "0x3F86F30", VA = "0x183F88530", Slot = "229")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(KEHGKCEOMAC BOFFBLEJGEM, BFJDAEOAMDN LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x3F87CD0", Offset = "0x3F866D0", VA = "0x183F87CD0", Slot = "230")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(KEHGKCEOMAC BOFFBLEJGEM, IKOBEDEIMBA LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL, T11 CAPFCCBKHBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x3F873D0", Offset = "0x3F85DD0", VA = "0x183F873D0", Slot = "231")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(KEHGKCEOMAC BOFFBLEJGEM, BMKNNEGOFCN LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL, T11 CAPFCCBKHBP, T12 NOJKKNFMBFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x3F86F00", Offset = "0x3F85900", VA = "0x183F86F00", Slot = "232")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(KEHGKCEOMAC BOFFBLEJGEM, ILMJGNLJOIJ LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL, T11 CAPFCCBKHBP, T12 NOJKKNFMBFC, T13 PNCONLJKFNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x3F86510", Offset = "0x3F84F10", VA = "0x183F86510", Slot = "233")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(KEHGKCEOMAC BOFFBLEJGEM, EPDNFHCEAIM LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL, T11 CAPFCCBKHBP, T12 NOJKKNFMBFC, T13 PNCONLJKFNO, T14 FKACDDCIKCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x8449B80", Offset = "0x8448580", VA = "0x188449B80", Slot = "234")]
		public void RpcOthersBuffered(KEHGKCEOMAC BOFFBLEJGEM, MLDPNLLLMPJ.JGJFPFFCKBE<IIMDHKOLHCE> LOHNFJJANPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x3F8B5F0", Offset = "0x3F89FF0", VA = "0x183F8B5F0", Slot = "235")]
		public void RpcOthersBuffered<T1>(KEHGKCEOMAC BOFFBLEJGEM, MLDPNLLLMPJ.FDGGKNKBGGG<T1, IIMDHKOLHCE> LOHNFJJANPK, T1 KMDCDIFFCDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x3F8B360", Offset = "0x3F89D60", VA = "0x183F8B360", Slot = "236")]
		public void RpcOthersBuffered<T1, T2>(KEHGKCEOMAC BOFFBLEJGEM, MLDPNLLLMPJ.IJNDDBLFMKG<T1, T2, IIMDHKOLHCE> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x3F8AE70", Offset = "0x3F89870", VA = "0x183F8AE70", Slot = "237")]
		public void RpcOthersBuffered<T1, T2, T3>(KEHGKCEOMAC BOFFBLEJGEM, MLDPNLLLMPJ.BLHPLEPCOAL<T1, T2, T3, IIMDHKOLHCE> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x3F8AC60", Offset = "0x3F89660", VA = "0x183F8AC60", Slot = "238")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(KEHGKCEOMAC BOFFBLEJGEM, MLDPNLLLMPJ.ONEAFFFPAJH<T1, T2, T3, T4, IIMDHKOLHCE> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x3F8A5B0", Offset = "0x3F88FB0", VA = "0x183F8A5B0", Slot = "239")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(KEHGKCEOMAC BOFFBLEJGEM, MLDPNLLLMPJ.JEJLLHPFOGC<T1, T2, T3, T4, T5, IIMDHKOLHCE> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x3F8A310", Offset = "0x3F88D10", VA = "0x183F8A310", Slot = "240")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(KEHGKCEOMAC BOFFBLEJGEM, MLDPNLLLMPJ.BFOJDIIKCKH<T1, T2, T3, T4, T5, T6, IIMDHKOLHCE> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x3F89D80", Offset = "0x3F88780", VA = "0x183F89D80", Slot = "241")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(KEHGKCEOMAC BOFFBLEJGEM, MLDPNLLLMPJ.ICCGMHOGBPG<T1, T2, T3, T4, T5, T6, T7, IIMDHKOLHCE> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x3F89410", Offset = "0x3F87E10", VA = "0x183F89410", Slot = "242")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(KEHGKCEOMAC BOFFBLEJGEM, MLDPNLLLMPJ.HJEKLDKLIKM<T1, T2, T3, T4, T5, T6, T7, T8, IIMDHKOLHCE> LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x3F88CF0", Offset = "0x3F876F0", VA = "0x183F88CF0", Slot = "243")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(KEHGKCEOMAC BOFFBLEJGEM, BFJDAEOAMDN LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x3F88910", Offset = "0x3F87310", VA = "0x183F88910", Slot = "244")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(KEHGKCEOMAC BOFFBLEJGEM, IKOBEDEIMBA LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x3F88100", Offset = "0x3F86B00", VA = "0x183F88100", Slot = "245")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(KEHGKCEOMAC BOFFBLEJGEM, BMKNNEGOFCN LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL, T11 CAPFCCBKHBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x3F87850", Offset = "0x3F86250", VA = "0x183F87850", Slot = "246")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(KEHGKCEOMAC BOFFBLEJGEM, ILMJGNLJOIJ LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL, T11 CAPFCCBKHBP, T12 NOJKKNFMBFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x3F86A30", Offset = "0x3F85430", VA = "0x183F86A30", Slot = "247")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(KEHGKCEOMAC BOFFBLEJGEM, EPDNFHCEAIM LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL, T11 CAPFCCBKHBP, T12 NOJKKNFMBFC, T13 PNCONLJKFNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x3F85FF0", Offset = "0x3F849F0", VA = "0x183F85FF0", Slot = "248")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(KEHGKCEOMAC BOFFBLEJGEM, GCJOBJHICDK LOHNFJJANPK, T1 KMDCDIFFCDI, T2 BHONDBMHCBI, T3 GCHCPLOKLBD, T4 DDGDDCGBPGA, T5 LGBDGJBMPIH, T6 NJPGOJOOAIA, T7 KCDELHJMEKE, T8 OLLOCPHNFMB, T9 CEBIGKPNBGL, T10 HDKJAONIIIL, T11 CAPFCCBKHBP, T12 NOJKKNFMBFC, T13 PNCONLJKFNO, T14 FKACDDCIKCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x8446BF0", Offset = "0x84455F0", VA = "0x188446BF0", Slot = "249")]
		public void ClearBufferedRPCsIfMine()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x8446E10", Offset = "0x8445810", VA = "0x188446E10", Slot = "250")]
		public void ClearBufferedRPCs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x208A1A0", Offset = "0x2088BA0", VA = "0x18208A1A0")]
		public RRNetworkView()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class KIJMHAKBCPB
{
	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x843CAE0", Offset = "0x843B4E0", VA = "0x18843CAE0")]
	private static bool NFKLINDFOHG(ViewId EGJGKBPPPFG, [Out] RRNetworkView EGPPKOBFLID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x3D2B530", Offset = "0x3D29F30", VA = "0x183D2B530")]
	[CanBeNull]
	public static T MIPIMEFEGCO<T>(this ViewId JBPOBPLEADM)
	{
		return (T)null;
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class RRPlayerNumbering : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class IIBPOIAKPGE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public POIAKMBAMML[] sorted;

			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
			public IIBPOIAKPGE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0x843BBC0", Offset = "0x843A5C0", VA = "0x18843BBC0")]
			internal int AIGCLHKJDLE(int index)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x843BC40", Offset = "0x843A640", VA = "0x18843BC40")]
			internal void OGGOBONAKEO(int index, int number)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private static readonly MEBJEIOEDLD HJHMNJLNNBM;

		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public static RRPlayerNumbering instance;

		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public static POIAKMBAMML[] SortedPlayers;

		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public const string RoomPlayerIndexedProp = "rrPnr";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		internal int NHLJHAEBDPK;

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x844B120", Offset = "0x8449B20", VA = "0x18844B120")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x844B740", Offset = "0x844A140", VA = "0x18844B740")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x844BB10", Offset = "0x844A510", VA = "0x18844BB10")]
		private void OnJoinedRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x844BB90", Offset = "0x844A590", VA = "0x18844BB90")]
		private void OnLeftRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x844B560", Offset = "0x8449F60", VA = "0x18844B560")]
		private void CPKAPFMIMPK(POIAKMBAMML IFFLFLAJAIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x844B560", Offset = "0x8449F60", VA = "0x18844B560")]
		private void LJAKHKBBPBP(POIAKMBAMML IMKEHGKDPCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x844B570", Offset = "0x8449F70", VA = "0x18844B570")]
		private void FPHJEHMEICP(POIAKMBAMML GPFCEEMMIIK, IDictionary<object, object> OOLOAEDCNED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x844AFD0", Offset = "0x84499D0", VA = "0x18844AFD0")]
		public static void AssignPlayerNumbers(int DKCCDLMLJCH, int NKCJKBAMGGJ, Func<int, int> PPDCDHIBIHB, Action<int, int> APFENDONFFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x844BC40", Offset = "0x844A640", VA = "0x18844BC40")]
		public void RefreshData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x844B650", Offset = "0x844A050", VA = "0x18844B650")]
		private void HGKHJOCDLHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0xA96B10", Offset = "0xA95510", VA = "0x180A96B10")]
		public RRPlayerNumbering()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class KMMKKNEIGDP
{
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static readonly MEBJEIOEDLD HJHMNJLNNBM;

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x8440FE0", Offset = "0x843F9E0", VA = "0x188440FE0")]
	public static int NGDGKOHDECM(this POIAKMBAMML JGGGINODJOB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x8440C10", Offset = "0x843F610", VA = "0x188440C10")]
	public static void GEBGOELIJDP(this POIAKMBAMML JGGGINODJOB, int EDFBAFDIGFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class NOIHIOKNEJK
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public delegate void BEMGOIANEDM(Hashtable FNPCEKCMMCN);

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public delegate void CFIIODPFHNO(POIAKMBAMML JGGGINODJOB, Hashtable FNPCEKCMMCN);

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public static event BEMGOIANEDM EDJJFKLAAEI
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x8444280", Offset = "0x8442C80", VA = "0x188444280")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x84441C0", Offset = "0x8442BC0", VA = "0x1884441C0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public static event BEMGOIANEDM ENGJJLEHGGM
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x8444640", Offset = "0x8443040", VA = "0x188444640")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x8444700", Offset = "0x8443100", VA = "0x188444700")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public static event CFIIODPFHNO FAABMAJMACH
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x8444400", Offset = "0x8442E00", VA = "0x188444400")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x8444340", Offset = "0x8442D40", VA = "0x188444340")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public static event CFIIODPFHNO EOMBAEGPGAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x8444580", Offset = "0x8442F80", VA = "0x188444580")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x84444C0", Offset = "0x8442EC0", VA = "0x1884444C0")]
		[CompilerGenerated]
		remove
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal static class LOENLAABPCJ
{
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private static int DOAMBENKPNE;

	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private static int IGLNEEJLEBO;

	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private static int IADCDMJHAGF;

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x8441710", Offset = "0x8440110", VA = "0x188441710")]
	public static void KCAFDMEHHOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x8441760", Offset = "0x8440160", VA = "0x188441760")]
	public static void KDEFNGMFFDK(int[] IKAAAAPHAMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x8441460", Offset = "0x843FE60", VA = "0x188441460")]
	public static int JMCJMPHHKNP(int NELGKAMEKKK, bool NLCAGPHNNBC = true)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[ServiceLifetime(Lifetime.Application)]
[RegisterService(typeof(NFMDDEHLNGH), new string[] { })]
public class NFMDDEHLNGH : HLPJLMMAGGP, PGHMJJNBADC, NAGAKFIOPNO
{
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private static readonly Hashtable GKLLEMGGKBJ;

	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private static readonly Hashtable LPENHGOLOHL;

	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private static readonly Hashtable IFOMNAIFKBA;

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private static readonly LFCPHBACBIP HKKHOIEGBAA;

	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static readonly LFCPHBACBIP BBDGMFBNAGN;

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private static readonly LFCPHBACBIP NIHPEFBHHMK;

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static readonly LFCPHBACBIP IPCIJBELOLG;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static readonly LFCPHBACBIP BDPHEDKBHMA;

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private static int CAPGOJPJEOH;

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x8443720", Offset = "0x8442120", VA = "0x188443720", Slot = "18")]
	public void KEMLKJMHOGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x8443E20", Offset = "0x8442820", VA = "0x188443E20", Slot = "19")]
	public void NOAMAPCJEBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x84435E0", Offset = "0x8441FE0", VA = "0x1884435E0", Slot = "4")]
	public bool IOPJPGCEDLG(JDKEBFGKIJA HKENEGGNMIM, bool LLBJGFCIHFN = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x84424D0", Offset = "0x8440ED0", VA = "0x1884424D0", Slot = "5")]
	public int HDHAPEBALJH(JDKEBFGKIJA[] MOKJNKCPGLG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x8441F90", Offset = "0x8440990", VA = "0x188441F90", Slot = "6")]
	public bool EFONOCCNOBI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x8441C00", Offset = "0x8440600", VA = "0x188441C00", Slot = "7")]
	public bool DJKEOLJDOCA(int JBPOBPLEADM, int KCLPPIIGHEI, bool FOKCDOIFODO, GameObject CEENMGBCJEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x8441DA0", Offset = "0x84407A0", VA = "0x188441DA0", Slot = "8")]
	public void DPBDGPBHEMO(int KCLPPIIGHEI, [Optional] int? IPLMLJAGFDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x8442C60", Offset = "0x8441660", VA = "0x188442C60", Slot = "9")]
	public bool IMMLAODHPMA(NDGFICGAFID EOOLELFGEAP, [Out] JDKEBFGKIJA NAIOKMIACEM, bool FGMLFNKPMIP = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x8442980", Offset = "0x8441380", VA = "0x188442980", Slot = "10")]
	public bool IEBAOKNNPNO(NDGFICGAFID EOOLELFGEAP, [Out] int HCEGOEHNOJO, [Out] JDKEBFGKIJA[] MOKJNKCPGLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x84434C0", Offset = "0x8441EC0", VA = "0x1884434C0", Slot = "11")]
	public bool IOABLEJNGMM(NDGFICGAFID EOOLELFGEAP, [Out] int KCLPPIIGHEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x8442220", Offset = "0x8440C20", VA = "0x188442220", Slot = "12")]
	public void GFODHLNAAAO(NDGFICGAFID EOOLELFGEAP, [Out] int EMEFGFKMEAP, [Out] int[] FJHCMGDAJNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x8441AA0", Offset = "0x84404A0", VA = "0x188441AA0", Slot = "13")]
	public void CNJPGBBKLJE(int HCEGOEHNOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x8442020", Offset = "0x8440A20", VA = "0x188442020", Slot = "14")]
	public void EGGBBOLKEID(int HCEGOEHNOJO, int[] FJHCMGDAJNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x8443D70", Offset = "0x8442770", VA = "0x188443D70", Slot = "15")]
	public void MCBJNIBODDL(int[] FJHCMGDAJNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x8442400", Offset = "0x8440E00", VA = "0x188442400", Slot = "16")]
	public void GKCEICFNEKO(int[] FJHCMGDAJNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x84437C0", Offset = "0x84421C0", VA = "0x1884437C0", Slot = "17")]
	public void KMCPMNOJOLN(int HCEGOEHNOJO, int KCLPPIIGHEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x8443930", Offset = "0x8442330", VA = "0x188443930")]
	private static void LINPEPEKCAD(JDKEBFGKIJA HKENEGGNMIM, Hashtable PBBEIDLIBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x8442DD0", Offset = "0x84417D0", VA = "0x188442DD0")]
	private static bool IMMLAODHPMA(Hashtable PBBEIDLIBOE, POIAKMBAMML CBCHDGOOHNE, [Out] JDKEBFGKIJA NAIOKMIACEM, bool FGMLFNKPMIP = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x8442890", Offset = "0x8441290", VA = "0x188442890")]
	private static bool HOLJBPNALCO(int KCLPPIIGHEI, JDKEBFGKIJA PBBEIDLIBOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x8442140", Offset = "0x8440B40", VA = "0x188442140")]
	private static int GBKMLEEKPJJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public NFMDDEHLNGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[RegisterService(typeof(OCDIOHOFAGJ), new string[] { })]
[ServiceLifetime(Lifetime.Application)]
public class OCDIOHOFAGJ : JFCHLEHHFMN, PGHMJJNBADC, NAGAKFIOPNO
{
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private static Hashtable HCCCIMPJEOA;

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private static Hashtable IFIFNEOEDIJ;

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private static LFCPHBACBIP MOMMJDLHKLD;

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static readonly LFCPHBACBIP MFAACIFEIFH;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static MEBJEIOEDLD HJHMNJLNNBM;

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x84452F0", Offset = "0x8443CF0", VA = "0x1884452F0", Slot = "8")]
	public void NOAMAPCJEBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x8444F00", Offset = "0x8443900", VA = "0x188444F00", Slot = "7")]
	public void KEMLKJMHOGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x84447C0", Offset = "0x84431C0", VA = "0x1884447C0", Slot = "4")]
	public void HAJAOCEKHFB(ViewId JBPOBPLEADM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x8444FA0", Offset = "0x84439A0", VA = "0x188444FA0", Slot = "5")]
	public bool LGBEIMOLEAJ(NDGFICGAFID EOOLELFGEAP, [Out] ViewId JBPOBPLEADM, [Out] string BDEEHABLNHA, [Out] int AGFKAKMCAIK, [Out] object[] JEAMHIFDMBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x84448B0", Offset = "0x84432B0", VA = "0x1884448B0", Slot = "6")]
	public void JLFPEMJMPIA(ViewId EGPPKOBFLID, string BDEEHABLNHA, BDPLGJMNIOG NFMFMHJJOJM, POIAKMBAMML JGGGINODJOB, IMKFKJGKAJH IDMMGNEKDMI, object[] HKENEGGNMIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public OCDIOHOFAGJ()
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
