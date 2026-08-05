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
	public class LogRegistrationIndex : BPLGCOBKJGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7D54AE0", Offset = "0x7D530E0", VA = "0x187D54AE0", Slot = "4")]
		public override void AMBIAOGNIIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA149D0", Offset = "0xA12FD0", VA = "0x180A149D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EB780", Offset = "0x9E9D80", VA = "0x1809EB780", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7B64240", Offset = "0x7B62840", VA = "0x187B64240", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7D5EB80", Offset = "0x7D5D180", VA = "0x187D5EB80")]
		private void MEMPKEBCMCB(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7D5E910", Offset = "0x7D5CF10", VA = "0x187D5E910")]
		private void KMFPJCIAGGA(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7D5EFC0", Offset = "0x7D5D5C0", VA = "0x187D5EFC0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7D5F070", Offset = "0x7D5D670", VA = "0x187D5F070")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class GBFIKFEMAPH
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly JBBHIJHGEPM FEHDPLGKCJJ;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static JBBHIJHGEPM HDAIKICIGAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7D47E60", Offset = "0x7D46460", VA = "0x187D47E60")]
		get
		{
			return default(JBBHIJHGEPM);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface FOMLMEOLOLE
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	RRNetworkView EAKOCIPMAEA
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	KHAEAFFLCKB IKODOBJGCJP
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool Serialize(NJNFLNOHPLJ NNMPEAJMEBO);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void Deserialize(ODPBCGDEEFD LBGDJDBPBBD, NJNFLNOHPLJ NNMPEAJMEBO);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface GFJGIAJEGPO
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool APLFCBMMPAA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AICIBGOGIJO(ODPBCGDEEFD LBGDJDBPBBD);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AKDPGDCBDMI(ODPBCGDEEFD LBGDJDBPBBD, NJNFLNOHPLJ NNMPEAJMEBO);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface LNPKOEKPFOA : INetworkUpdateSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AMBIAOGNIIF(FOMLMEOLOLE ACCHAHFFKGF);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OMFPKPKPLOB(FOMLMEOLOLE ACCHAHFFKGF);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AFDGONJKHDP(MAEGKODGPCB.LNPDCBELAAF AEFKIHAGPLO);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BHELIOMMIPO();

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HLMCIJOMPJF(object NKBJHKLGFDP);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum KHAEAFFLCKB : byte
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
	Invalid
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct ODPBCGDEEFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public int IJAHNOHAHPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public uint PMCKJAGPGEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public double OAHJIPKLLIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public int IAMKPBLCJJI;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class KDJAAGFADBD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly Dictionary<(ViewId, KHAEAFFLCKB), GFJGIAJEGPO> LDCCEMBBGFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly List<FOMLMEOLOLE> JCPHKEIFMOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly HashSet<(ViewId, KHAEAFFLCKB)> AMAHABMFJCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private int LEILGIDAMBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public bool OCMLCOPEGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private MAEGKODGPCB.LNPDCBELAAF AEFKIHAGPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly MemoryStream EJLBHIBDBHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly NJNFLNOHPLJ COGODBIODGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly NJNFLNOHPLJ NMFLBENDENE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private byte[] GFDMDJJHGOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private float HKBKHJHPKHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private int AOPHGEOLEDI;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7D4BB50", Offset = "0x7D4A150", VA = "0x187D4BB50")]
	public KDJAAGFADBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7D4A540", Offset = "0x7D48B40", VA = "0x187D4A540")]
	public void AFDGONJKHDP(MAEGKODGPCB.LNPDCBELAAF AEFKIHAGPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7D4A910", Offset = "0x7D48F10", VA = "0x187D4A910")]
	public void BHELIOMMIPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7D4AD20", Offset = "0x7D49320", VA = "0x187D4AD20")]
	public void IEKHBJGOAKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7D4B100", Offset = "0x7D49700", VA = "0x187D4B100")]
	public bool IIGLPCDPOEE(FOMLMEOLOLE ACCHAHFFKGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7D4ABF0", Offset = "0x7D491F0", VA = "0x187D4ABF0")]
	public bool GNAALOCCJEL(FOMLMEOLOLE ACCHAHFFKGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7D4A970", Offset = "0x7D48F70", VA = "0x187D4A970")]
	private GFJGIAJEGPO EMJPBBEPCIF(ViewId HMGHCPIBIBG, KHAEAFFLCKB MGNKGDPDNBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7D4A960", Offset = "0x7D48F60", VA = "0x187D4A960")]
	public void CDCHPKBBPIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7D4AB90", Offset = "0x7D49190", VA = "0x187D4AB90")]
	private void GEELGMHMNLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7D4BB30", Offset = "0x7D4A130", VA = "0x187D4BB30")]
	private void PGOGPJCHHAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7D4B790", Offset = "0x7D49D90", VA = "0x187D4B790")]
	public bool MENCHBCMFPN(FastBufferWriter NFOCFJIIPHM, int PNEDIJBNLHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7D4A560", Offset = "0x7D48B60", VA = "0x187D4A560")]
	public void AKDPGDCBDMI(ODPBCGDEEFD LBGDJDBPBBD, FastBufferReader HBMFONPEIJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal class LAENFCLEEHB : GFJGIAJEGPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private FOMLMEOLOLE OKECMONOJBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private uint JNKKBGPGMEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private int EDJLCEMIIOE;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool APLFCBMMPAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x9F86D0", Offset = "0x9F6CD0", VA = "0x1809F86D0")]
	public LAENFCLEEHB(FOMLMEOLOLE OKECMONOJBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7D4BFD0", Offset = "0x7D4A5D0", VA = "0x187D4BFD0", Slot = "5")]
	public bool AICIBGOGIJO(ODPBCGDEEFD LBGDJDBPBBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7D4C0C0", Offset = "0x7D4A6C0", VA = "0x187D4C0C0", Slot = "6")]
	public void AKDPGDCBDMI(ODPBCGDEEFD LBGDJDBPBBD, NJNFLNOHPLJ NNMPEAJMEBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class PCIBFHMOHID : GFJGIAJEGPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private MAEGKODGPCB.LNPDCBELAAF AEFKIHAGPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly ViewId HMGHCPIBIBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private int EDJLCEMIIOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private uint JNKKBGPGMEL;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool APLFCBMMPAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA05830", Offset = "0xA03E30", VA = "0x180A05830", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x1988630", Offset = "0x1986C30", VA = "0x181988630")]
	public PCIBFHMOHID(ViewId HMGHCPIBIBG, MAEGKODGPCB.LNPDCBELAAF AEFKIHAGPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7D56810", Offset = "0x7D54E10", VA = "0x187D56810", Slot = "5")]
	public bool AICIBGOGIJO(ODPBCGDEEFD LBGDJDBPBBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7D56850", Offset = "0x7D54E50", VA = "0x187D56850", Slot = "6")]
	public void AKDPGDCBDMI(ODPBCGDEEFD LBGDJDBPBBD, NJNFLNOHPLJ NNMPEAJMEBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class KBEBLEHJODH
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7D49A40", Offset = "0x7D48040", VA = "0x187D49A40")]
	public static void DFNAEDFOBIJ(this ABBHPHKIIPL MBIKDPPKIJB, NJNFLNOHPLJ FIGOKEKFLLN, ViewId INLEBAAACKH, bool DLLADKGCKMC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7D49C00", Offset = "0x7D48200", VA = "0x187D49C00")]
	public static void HDPOOLPCCPF(this ABBHPHKIIPL MBIKDPPKIJB, NJNFLNOHPLJ FIGOKEKFLLN, bool DLLADKGCKMC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7D498D0", Offset = "0x7D47ED0", VA = "0x187D498D0")]
	public static ABBHPHKIIPL AKDPGDCBDMI(NJNFLNOHPLJ FIGOKEKFLLN, ViewId INLEBAAACKH, bool DLLADKGCKMC = true)
	{
		return default(ABBHPHKIIPL);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7D4A100", Offset = "0x7D48700", VA = "0x187D4A100")]
	public static void JMEDOGOAOME(this ABBHPHKIIPL MBIKDPPKIJB, NJNFLNOHPLJ FIGOKEKFLLN, bool DLLADKGCKMC = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[RegisterService(typeof(LNPKOEKPFOA), new string[] { })]
public class GIPGPNGNNPG : LNPKOEKPFOA, INetworkUpdateSystem, IJFNBDMABCN, MMMIGLKPHHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly JBBHIJHGEPM DDLBOCLMDJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private KDJAAGFADBD PDOCFGAOPIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private uint MFEKODDLFJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private float HDMOKFEJFBE;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7D47F40", Offset = "0x7D46540", VA = "0x187D47F40", Slot = "4")]
	public void AMBIAOGNIIF(FOMLMEOLOLE ACCHAHFFKGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7D48C10", Offset = "0x7D47210", VA = "0x187D48C10", Slot = "5")]
	public void OMFPKPKPLOB(FOMLMEOLOLE ACCHAHFFKGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7D48E10", Offset = "0x7D47410", VA = "0x187D48E10", Slot = "10")]
	public void OPNHMMPAKCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7D48B90", Offset = "0x7D47190", VA = "0x187D48B90", Slot = "9")]
	public void NetworkUpdate(NetworkUpdateStage HDPJDCEFCCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7D480C0", Offset = "0x7D466C0", VA = "0x187D480C0")]
	private void CJNIBNEAGIO(uint DCJDFIMNBAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7D47F10", Offset = "0x7D46510", VA = "0x187D47F10", Slot = "6")]
	public void AFDGONJKHDP(MAEGKODGPCB.LNPDCBELAAF AEFKIHAGPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7D48060", Offset = "0x7D46660", VA = "0x187D48060", Slot = "7")]
	public void BHELIOMMIPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7D48690", Offset = "0x7D46C90", VA = "0x187D48690", Slot = "8")]
	public void HLMCIJOMPJF(object KGFBFINKAKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7D486F0", Offset = "0x7D46CF0", VA = "0x187D486F0")]
	private void JINGFBINPHA(OJOPFCHDHDL KGFBFINKAKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7D48A70", Offset = "0x7D47070", VA = "0x187D48A70", Slot = "11")]
	public void NHMAMKPPBPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7D48F70", Offset = "0x7D47570", VA = "0x187D48F70")]
	public GIPGPNGNNPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class JNBMMKNDNNA : GFJGIAJEGPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private float KFPLEIBPNOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private int EDJLCEMIIOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private uint JNKKBGPGMEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public ODPBCGDEEFD FGLBDNAPLKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public int EFNMDGPPFCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public byte[] OEMOJAAHAJJ;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool APLFCBMMPAA
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7D49700", Offset = "0x7D47D00", VA = "0x187D49700", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7D49730", Offset = "0x7D47D30", VA = "0x187D49730", Slot = "5")]
	public bool AICIBGOGIJO(ODPBCGDEEFD LBGDJDBPBBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7D49770", Offset = "0x7D47D70", VA = "0x187D49770", Slot = "6")]
	public void AKDPGDCBDMI(ODPBCGDEEFD LBGDJDBPBBD, NJNFLNOHPLJ NNMPEAJMEBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7D49640", Offset = "0x7D47C40", VA = "0x187D49640")]
	internal LAENFCLEEHB ACHDHDCLJJG(FOMLMEOLOLE ACCHAHFFKGF, [Out] ODPBCGDEEFD JPJKOAICAJH, [Out] byte[] IIGKBHIENFB, [Out] int EDGAKHBBNHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7D49870", Offset = "0x7D47E70", VA = "0x187D49870")]
	public JNBMMKNDNNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[ServiceLifetime(Lifetime.PhotonRoom)]
[RegisterService(typeof(FPLJNHNENDP), new string[] { })]
public class FPLJNHNENDP
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static readonly Hashtable AAIODIBCJCB;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static readonly Hashtable CFCMEGNHNJL;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static readonly Hashtable LPLGHOGEOOD;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static readonly FIHNAFNBAOM FMCHLHODPCO;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static readonly FIHNAFNBAOM KDENFHHICPJ;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static readonly FIHNAFNBAOM NCIIKLAPKDG;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private static readonly FIHNAFNBAOM FBJGHIFAJJJ;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static readonly FIHNAFNBAOM CKNNGIKCADO;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static int MNOFBPNJAFA;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7D46480", Offset = "0x7D44A80", VA = "0x187D46480")]
	public bool GLFLKHNNOLM(PAICJHNMKLD PMLCGCAHNGK, bool PGNDPBMLBMN = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7D471F0", Offset = "0x7D457F0", VA = "0x187D471F0")]
	public int KHJJEEEAAOA(PAICJHNMKLD[] COFIFIGPPPN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7D475B0", Offset = "0x7D45BB0", VA = "0x187D475B0")]
	public bool LFPHLGNDPKP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7D462E0", Offset = "0x7D448E0", VA = "0x187D462E0")]
	public bool FPGPIAKAMDH(RRNetworkView KNDMDBLHCEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7D46010", Offset = "0x7D44610", VA = "0x187D46010")]
	public void DNAECILKNEI(int OIKNOKIBHBL, [Optional] int? JHFPMLACIFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7D46A00", Offset = "0x7D45000", VA = "0x187D46A00")]
	public static bool JGEHNPEJJLL(OJOPFCHDHDL NKBJHKLGFDP, [Out] PAICJHNMKLD KFFCAKKDEAK, bool KHFGNIAGKCD = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7D46720", Offset = "0x7D44D20", VA = "0x187D46720")]
	public bool GPDLNEOGLMP(OJOPFCHDHDL NKBJHKLGFDP, [Out] int DINJJFOAJIH, [Out] PAICJHNMKLD[] COFIFIGPPPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7D47900", Offset = "0x7D45F00", VA = "0x187D47900")]
	public bool NCFMLHEAHCD(OJOPFCHDHDL NKBJHKLGFDP, [Out] int OIKNOKIBHBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7D47640", Offset = "0x7D45C40", VA = "0x187D47640")]
	public void LKHPBJIKNAG(OJOPFCHDHDL NKBJHKLGFDP, [Out] int NBPKNJPFEHF, [Out] int[] IFHLKOENADO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7D47A20", Offset = "0x7D46020", VA = "0x187D47A20")]
	public void NDNJLOHIFEF(int DINJJFOAJIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7D45EF0", Offset = "0x7D444F0", VA = "0x187D45EF0")]
	public void DCDICLNOPFI(int DINJJFOAJIH, int[] IFHLKOENADO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7D47140", Offset = "0x7D45740", VA = "0x187D47140")]
	public void KDDBPMPLCAD(int[] IFHLKOENADO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7D47820", Offset = "0x7D45E20", VA = "0x187D47820")]
	public void MJBIBCFCIDM(int[] IFHLKOENADO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7D465B0", Offset = "0x7D44BB0", VA = "0x187D465B0")]
	public void GLPEBFFCALP(int DINJJFOAJIH, int OIKNOKIBHBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7D45DF0", Offset = "0x7D443F0", VA = "0x187D45DF0")]
	public void CIOELLFMNNG(int[] AHAPNENDNGM, int EAPNIMDCDLA = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7D459C0", Offset = "0x7D43FC0", VA = "0x187D459C0")]
	private static void BMPCKNOBNIA(PAICJHNMKLD PMLCGCAHNGK, Hashtable DMFKJGNJFDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7D46B70", Offset = "0x7D45170", VA = "0x187D46B70")]
	private static bool JGEHNPEJJLL(Hashtable DMFKJGNJFDD, AIPAHMNCJKP MCPGCAOOHIL, [Out] PAICJHNMKLD KFFCAKKDEAK, bool KHFGNIAGKCD = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7D46200", Offset = "0x7D44800", VA = "0x187D46200")]
	private static int ENJFACCJGJL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public FPLJNHNENDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[ServiceLifetime(Lifetime.PhotonRoom)]
[RegisterService(typeof(AMEDJJJMDOA), new string[] { })]
public class AMEDJJJMDOA
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static Hashtable COEMJHAJHFB;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private static Hashtable OMKDFACNEEL;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static FIHNAFNBAOM NHOHHHOGPKF;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static readonly FIHNAFNBAOM KPPKPNLHLLG;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7D41380", Offset = "0x7D3F980", VA = "0x187D41380")]
	public void FHBNKHIABHP(ViewId HMGHCPIBIBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7D41470", Offset = "0x7D3FA70", VA = "0x187D41470")]
	public static bool IJMOAHGECCI(OJOPFCHDHDL NKBJHKLGFDP, [Out] ViewId HMGHCPIBIBG, [Out] string MNNPFFMKDDK, [Out] int OFCIEGJOLJI, [Out] object[] DLHJDCJDKHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7D40DE0", Offset = "0x7D3F3E0", VA = "0x187D40DE0")]
	public void COAMJDEDPPH(ViewId NNAEIGBDCOK, string MNNPFFMKDDK, KJGIOBLOLOL CEKPLNPPELB, AIPAHMNCJKP EKEPPODJHCN, LMIOHHKDMIA JKKFOKPAOPG, object[] PMLCGCAHNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public AMEDJJJMDOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class KCGNGJCBDKF
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7D4A4B0", Offset = "0x7D48AB0", VA = "0x187D4A4B0")]
	public static AIPAHMNCJKP CMHKPNCGFOI(this AEMMHEJJEHA LFJPHGCMAAL)
	{
		return null;
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class RRNetworkBehavior : MonoBehaviour, IBPDNAPKFDP, NDOBDGPMEBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private bool networkedViewInitialized;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private RRNetworkView networkedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private List<NHDGLIOEPBE> destroyHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private bool isForwarderRegistered;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public ViewId DJFLGABMOBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x7D57180", Offset = "0x7D55780", VA = "0x187D57180")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public ViewId IHIKCBIHDHG
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x7D57180", Offset = "0x7D55780", VA = "0x187D57180", Slot = "4")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		[Obsolete("Use NetworkedView instead")]
		public RRNetworkView EGLHICHHNHO
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x7D57200", Offset = "0x7D55800", VA = "0x187D57200")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public RRNetworkView EAKOCIPMAEA
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x7D57200", Offset = "0x7D55800", VA = "0x187D57200")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public AIPAHMNCJKP FDILDJGCAAM
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x7D57300", Offset = "0x7D55900", VA = "0x187D57300")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public AIPAHMNCJKP AMICCGMJHBK
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x7D57660", Offset = "0x7D55C60", VA = "0x187D57660")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool JKOBLADOGFI
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x7D57460", Offset = "0x7D55A60", VA = "0x187D57460")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool IHNJOEFDEMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x7D575D0", Offset = "0x7D55BD0", VA = "0x187D575D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool NNJMLKAKGFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x7D570B0", Offset = "0x7D556B0", VA = "0x187D570B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool BFEBPNLNNDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x7D57390", Offset = "0x7D55990", VA = "0x187D57390")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool KMMJMFIFKBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x7D570B0", Offset = "0x7D556B0", VA = "0x187D570B0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool LMMPJBEEFDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x7D57130", Offset = "0x7D55730", VA = "0x187D57130", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public string PKMJHOLCEFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x7D57270", Offset = "0x7D55870", VA = "0x187D57270", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool ADDBNODMKKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x7D57030", Offset = "0x7D55630", VA = "0x187D57030", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<AIPAHMNCJKP> ELGKAKHLDNI
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x7D56F00", Offset = "0x7D55500", VA = "0x187D56F00")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x7D576F0", Offset = "0x7D55CF0", VA = "0x187D576F0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7D56E60", Offset = "0x7D55460", VA = "0x187D56E60")]
		public bool WasSpawnedForPlayer(int DOFJJAMIEBI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x70FC370", Offset = "0x70FA970", VA = "0x1870FC370")]
		private void PCDLFFFEKFO(RRNetworkView COFBNOFIHKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7D56A90", Offset = "0x7D55090", VA = "0x187D56A90", Slot = "9")]
		public void RegisterDestroyHandler(NHDGLIOEPBE DLNPOEEPFML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7D56C90", Offset = "0x7D55290", VA = "0x187D56C90", Slot = "10")]
		public void UnregisterDestroyHandler(NHDGLIOEPBE DLNPOEEPFML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "11")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7D56A70", Offset = "0x7D55070", VA = "0x187D56A70", Slot = "12")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x9EA210", Offset = "0x9E8810", VA = "0x1809EA210")]
		public RRNetworkBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class NNNLKBLAEKG
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate void APAGNDLIEIK([In] PAICJHNMKLD PMLCGCAHNGK, bool OGNHJNJBMEJ, bool DMFKJGNJFDD, bool HMLEGGMLFHB);

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public delegate void OKEICOJIMEF(GameObject NHAAFJKFJLE);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public delegate void GLGPMOIPMLK(GameObject NHAAFJKFJLE);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public delegate void BCAFIEODOGD(RRNetworkView NNAEIGBDCOK, string MNNPFFMKDDK, AIPAHMNCJKP HDJKAKBEEHP, KJGIOBLOLOL? FCPOJLOEIEO, bool NOFDLBMPANO, LMIOHHKDMIA LKKOOEFOJEP, object[] PMLCGCAHNGK, string JKLGNOMBFCH);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public delegate void NJLACDIHBLD(RRNetworkView NNAEIGBDCOK, string MNNPFFMKDDK, AIPAHMNCJKP HDJKAKBEEHP, KJGIOBLOLOL? FCPOJLOEIEO, bool NOFDLBMPANO, LMIOHHKDMIA LKKOOEFOJEP, object[] PMLCGCAHNGK, string JKLGNOMBFCH);

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate void NELCALAEGBJ(RRNetworkView NNAEIGBDCOK, string MNNPFFMKDDK, object[] DLHJDCJDKHC, string OFIKPBHJKAH);

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public delegate void EEJMJFNCHEG(RRNetworkView NNAEIGBDCOK, AIPAHMNCJKP CCMFOKHGMEC);

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	[CompilerGenerated]
	private static OKEICOJIMEF KFJMACOMDAE;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public static event APAGNDLIEIK NAGMEJBJKPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7D55C50", Offset = "0x7D54250", VA = "0x187D55C50")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7D550B0", Offset = "0x7D536B0", VA = "0x187D550B0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public static event OKEICOJIMEF MEEGHDNGLLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7D55950", Offset = "0x7D53F50", VA = "0x187D55950")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7D55230", Offset = "0x7D53830", VA = "0x187D55230")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public static event GLGPMOIPMLK BHDDEBCHJKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7D55890", Offset = "0x7D53E90", VA = "0x187D55890")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7D560A0", Offset = "0x7D546A0", VA = "0x187D560A0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public static event GLGPMOIPMLK DAGDJNMKHPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7D55A10", Offset = "0x7D54010", VA = "0x187D55A10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7D552F0", Offset = "0x7D538F0", VA = "0x187D552F0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public static event BCAFIEODOGD CKDCHOBMPCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7D55AD0", Offset = "0x7D540D0", VA = "0x187D55AD0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7D55D10", Offset = "0x7D54310", VA = "0x187D55D10")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public static event NJLACDIHBLD BFOOGMFBNOE
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7D54EA0", Offset = "0x7D534A0", VA = "0x187D54EA0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7D55DD0", Offset = "0x7D543D0", VA = "0x187D55DD0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public static event NELCALAEGBJ MKKCKHGLMCB
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7D55B90", Offset = "0x7D54190", VA = "0x187D55B90")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7D55540", Offset = "0x7D53B40", VA = "0x187D55540")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public static event EEJMJFNCHEG KNGEBBKBJKH
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7D54F60", Offset = "0x7D53560", VA = "0x187D54F60")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7D56160", Offset = "0x7D54760", VA = "0x187D56160")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public static event EEJMJFNCHEG LBMHDIBJKGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7D55170", Offset = "0x7D53770", VA = "0x187D55170")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7D55690", Offset = "0x7D53C90", VA = "0x187D55690")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7D55FE0", Offset = "0x7D545E0", VA = "0x187D55FE0")]
	public static void NPCFJADLHOF([In] PAICJHNMKLD PMLCGCAHNGK, bool OGNHJNJBMEJ, bool DMFKJGNJFDD, bool HMLEGGMLFHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7D55020", Offset = "0x7D53620", VA = "0x187D55020")]
	public static void BCIMOFKIMKK(GameObject NHAAFJKFJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7D55600", Offset = "0x7D53C00", VA = "0x187D55600")]
	public static void HHABBLKLNFA(GameObject NHAAFJKFJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7D54E10", Offset = "0x7D53410", VA = "0x187D54E10")]
	public static void AGDADBMGDFO(GameObject NHAAFJKFJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7D553B0", Offset = "0x7D539B0", VA = "0x187D553B0")]
	public static void DKONCBOCOMC(GameObject NHAAFJKFJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7D55E90", Offset = "0x7D54490", VA = "0x187D55E90")]
	public static void MPMEIEBFNAK(RRNetworkView NNAEIGBDCOK, string MNNPFFMKDDK, AIPAHMNCJKP HDJKAKBEEHP, KJGIOBLOLOL? FCPOJLOEIEO, bool NOFDLBMPANO, LMIOHHKDMIA LKKOOEFOJEP, object[] PMLCGCAHNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7D55750", Offset = "0x7D53D50", VA = "0x187D55750")]
	public static void HLIIHPHFECG(RRNetworkView NNAEIGBDCOK, string MNNPFFMKDDK, int NANDJHMKFFE, object[] DLHJDCJDKHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7D55440", Offset = "0x7D53A40", VA = "0x187D55440")]
	public static void DMJFEOCNGEM(int HMGHCPIBIBG, int LFJPHGCMAAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class KEDIICBFDDJ
{
	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7D4BF20", Offset = "0x7D4A520", VA = "0x187D4BF20")]
	[CanBeNull]
	private static bool ECIAEDGPNKF(ViewId HJPLNJNIFLL, [Out] RRNetworkView NNAEIGBDCOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7D4BD70", Offset = "0x7D4A370", VA = "0x187D4BD70")]
	[CanBeNull]
	public static Component BIOBNAOIFFK(this ViewId NNAEIGBDCOK, Type HIOBPDDMMMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x38F5870", Offset = "0x38F3E70", VA = "0x1838F5870")]
	[CanBeNull]
	public static T BIOBNAOIFFK<T>(this ViewId NNAEIGBDCOK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x38F5870", Offset = "0x38F3E70", VA = "0x1838F5870")]
	[CanBeNull]
	public static T EFLABOIJMLH<T>(this ViewId NNAEIGBDCOK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x38F58E0", Offset = "0x38F3EE0", VA = "0x1838F58E0")]
	public static bool ELPONLMJPED<T>(this ViewId NNAEIGBDCOK, [Out] T OBOOAPELMPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7D4BE50", Offset = "0x7D4A450", VA = "0x187D4BE50")]
	[CanBeNull]
	public static RRNetworkView DJJMMHMBAIK(this ViewId NNAEIGBDCOK)
	{
		return null;
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class RRNetworkHandler : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static RRNetworkHandler ELJDCHFNJGK;

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public static bool AppQuits;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		internal static RRNetworkHandler MLIJHBGBMKP
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x7D57820", Offset = "0x7D55E20", VA = "0x187D57820")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7D579D0", Offset = "0x7D55FD0", VA = "0x187D579D0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void StaticReset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7D57990", Offset = "0x7D55F90", VA = "0x187D57990")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x9EA210", Offset = "0x9E8810", VA = "0x1809EA210")]
		public RRNetworkHandler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[ServiceLifetime(Lifetime.PhotonRoom)]
[RegisterService(typeof(LHPGFBLNMLG), new string[] { "Photon" })]
public sealed class LHPGFBLNMLG : LKOCKHMKIML, IJFNBDMABCN, MMMIGLKPHHG, ILPONKCDKJP, NCBKAJEOCJJ
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class DJOIMOGHCNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int requestedViewId;

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public DJOIMOGHCNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x7D41B90", Offset = "0x7D40190", VA = "0x187D41B90")]
		internal object ELJDMAOGGHP((int requestedViewId, int newOwnerId, int senderId) x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private static JBBHIJHGEPM KOPPJKNGKOI;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private static JBBHIJHGEPM AAOFOJFJNHA;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private static Dictionary<int, HashSet<int>> LHOEDDGGPDC;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private static Dictionary<int, int> JEGMNHMMOIH;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private static readonly List<(GameObject GameObject, int ParentCount)> EKMCHDDDOIO;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private static readonly List<GameObject> JAPJCDLFFHI;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private static List<int> MJJMCFHAGDO;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private static readonly List<RRNetworkView> MCMNBAKEEII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private FPLJNHNENDP IDCFFMFMBMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private LDMAAALPMPJ NODDAHEDIAD;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7D54430", Offset = "0x7D52A30", VA = "0x187D54430", Slot = "8")]
	public void OPNHMMPAKCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7D533F0", Offset = "0x7D519F0", VA = "0x187D533F0", Slot = "9")]
	public void NHMAMKPPBPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7D4F1B0", Offset = "0x7D4D7B0", VA = "0x187D4F1B0", Slot = "10")]
	public void GJKEBEKMMLO(APJCDBKKFBB IDEMOBALCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7D4F660", Offset = "0x7D4DC60", VA = "0x187D4F660", Slot = "11")]
	public void HGMPKJGBHFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7D4FBC0", Offset = "0x7D4E1C0", VA = "0x187D4FBC0")]
	private void HIBGEPMOANF(JOLENCIDFIJ GAABGHOKEAD, JOLENCIDFIJ IDAKFFICKHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7D53010", Offset = "0x7D51610", VA = "0x187D53010")]
	private void MHLOPJOOKOD(AOPBJCMNIBD MEJLCFJDANK, AOPBJCMNIBD EIJFHGMONEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7D4C570", Offset = "0x7D4AB70", VA = "0x187D4C570")]
	public GameObject AJIGOHJBLKN(string NFHOBPDKIPM, Vector3 EPCLGOKLIPO, Quaternion OOBEGCNALKF, Vector3 HDLKNIPAJGK, ViewId HMGHCPIBIBG, NEEICKGOONJ PMLCGCAHNGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7D53750", Offset = "0x7D51D50", VA = "0x187D53750")]
	public GameObject NIFOMKBENKP(string NFHOBPDKIPM, Vector3 EPCLGOKLIPO, Quaternion OOBEGCNALKF, float HDLKNIPAJGK, object[] PMLCGCAHNGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7D52B10", Offset = "0x7D51110", VA = "0x187D52B10")]
	public GameObject KKNOPKIJCNJ(string NFHOBPDKIPM, Vector3 EPCLGOKLIPO, Quaternion OOBEGCNALKF, Vector3 HDLKNIPAJGK, ViewId NNAEIGBDCOK, NEEICKGOONJ PMLCGCAHNGK, bool HMLEGGMLFHB = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7D4F630", Offset = "0x7D4DC30", VA = "0x187D4F630")]
	public GameObject HAPEGCJDDGM(PAICJHNMKLD PMLCGCAHNGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7D4E1D0", Offset = "0x7D4C7D0", VA = "0x187D4E1D0", Slot = "6")]
	public void FNJFKJCCBHM(GameObject NHAAFJKFJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7D4CBE0", Offset = "0x7D4B1E0", VA = "0x187D4CBE0")]
	public void CFBNFBNJKLK(GameObject CEKGANCAJPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7D52B00", Offset = "0x7D51100", VA = "0x187D52B00", Slot = "7")]
	public void KJACOAAJFMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7D500E0", Offset = "0x7D4E6E0", VA = "0x187D500E0", Slot = "4")]
	public GameObject[] IBBLDJGBCDD(IList<NKMCEMELPEA> NNFECOKKCKG, bool BIBJGLMBAOI = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7D4C740", Offset = "0x7D4AD40", VA = "0x187D4C740", Slot = "5")]
	public void APKGAIHBIIE(List<GameObject> PICKKAJKGOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7D50000", Offset = "0x7D4E600", VA = "0x187D50000")]
	public void IABGODELEJD(GameObject CEKGANCAJPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7D51CC0", Offset = "0x7D502C0", VA = "0x187D51CC0")]
	private void JINGFBINPHA(OJOPFCHDHDL NKBJHKLGFDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7D51900", Offset = "0x7D4FF00", VA = "0x187D51900")]
	private void IKMNKHOOFKM(OJOPFCHDHDL NKBJHKLGFDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x7D54110", Offset = "0x7D52710", VA = "0x187D54110")]
	private void OHPCGMEELFL(OJOPFCHDHDL NKBJHKLGFDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7D53110", Offset = "0x7D51710", VA = "0x187D53110")]
	private void MOEBFCFJABG(OJOPFCHDHDL NKBJHKLGFDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7D53D70", Offset = "0x7D52370", VA = "0x187D53D70")]
	private void NOEMAJNKELO(OJOPFCHDHDL NKBJHKLGFDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7D4FCB0", Offset = "0x7D4E2B0", VA = "0x187D4FCB0")]
	private void HPJDJHBCJOD(OJOPFCHDHDL NKBJHKLGFDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7D51360", Offset = "0x7D4F960", VA = "0x187D51360")]
	private void IDADBEJOOJK(OJOPFCHDHDL NKBJHKLGFDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7D52E20", Offset = "0x7D51420", VA = "0x187D52E20")]
	private GameObject LAGPPDEBHFL(string NJBHNMHIDFO, Vector3 EPCLGOKLIPO, Quaternion OOBEGCNALKF, Vector3 HDLKNIPAJGK, byte FEHDPLGKCJJ = 0, [Optional] object[] APDBNIMCPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7D50400", Offset = "0x7D4EA00", VA = "0x187D50400")]
	private GameObject IBGHAPNAMPI(PAICJHNMKLD PMLCGCAHNGK, bool OGNHJNJBMEJ = false, bool DMFKJGNJFDD = false, bool HMLEGGMLFHB = true, bool FPFFFDFMEFJ = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7D52DA0", Offset = "0x7D513A0", VA = "0x187D52DA0")]
	private static GameObject KPLNLNBHDFL(string NJBHNMHIDFO, bool KFBCFDAHLBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7D528F0", Offset = "0x7D50EF0", VA = "0x187D528F0")]
	private static GameObject KBACBJDDEPB(GameObject OMOOALIODHP, PAICJHNMKLD PMLCGCAHNGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7D4CC50", Offset = "0x7D4B250", VA = "0x187D4CC50")]
	private static void COOCFDJNPMD(GameObject NHAAFJKFJLE, RRNetworkView NNAEIGBDCOK, [In] PAICJHNMKLD PMLCGCAHNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7D51F20", Offset = "0x7D50520", VA = "0x187D51F20")]
	private GameObject[] JPEOEHLPANO(IList<NKMCEMELPEA> NNFECOKKCKG, bool BIBJGLMBAOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7D4D9F0", Offset = "0x7D4BFF0", VA = "0x187D4D9F0")]
	private GameObject[] DFGDEJLHHKK(PAICJHNMKLD[] COFIFIGPPPN, int DINJJFOAJIH, AIPAHMNCJKP EKEPPODJHCN, GameObject[] FKCNLKECIEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7D4DC90", Offset = "0x7D4C290", VA = "0x187D4DC90")]
	private GameObject DPLENMMAJOC([In] PAICJHNMKLD PMLCGCAHNGK, GameObject OMOOALIODHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x70D4F10", Offset = "0x70D3510", VA = "0x1870D4F10")]
	private static bool OHOMBKLOMIM(bool OGNHJNJBMEJ, bool HMLEGGMLFHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7D4CD60", Offset = "0x7D4B360", VA = "0x187D4CD60")]
	private void DEPLDOGNDNE(IEnumerable<GameObject> PICKKAJKGOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7D4E1E0", Offset = "0x7D4C7E0", VA = "0x187D4E1E0")]
	private void GGJLPECGJBG(GameObject NHAAFJKFJLE, bool FPFFFDFMEFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7D4F7C0", Offset = "0x7D4DDC0", VA = "0x187D4F7C0")]
	private static void HIACICLJKAL(IEnumerable<GameObject> KGBAFMIEGJF, List<(GameObject GameObject, int ParentCount)> JLILFKNENLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7D4E0A0", Offset = "0x7D4C6A0", VA = "0x187D4E0A0")]
	private void EHCPJHMIAGO(int OIKNOKIBHBL, int DINJJFOAJIH, bool FPFFFDFMEFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7D51B20", Offset = "0x7D50120", VA = "0x187D51B20")]
	private static int JGAIGIBOFDL(int OIKNOKIBHBL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7D543D0", Offset = "0x7D529D0", VA = "0x187D543D0")]
	private void OIDMAAGKNDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7D53840", Offset = "0x7D51E40", VA = "0x187D53840")]
	private void NJHIBKMGAEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7D54790", Offset = "0x7D52D90", VA = "0x187D54790")]
	private static int PANADKMFNDK(int BDMCCGBDHPH, bool HMLEGGMLFHB = true)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7D51E40", Offset = "0x7D50440", VA = "0x187D51E40")]
	private static int[] JKPHFLIMBKL(int DJMECIFFDJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7D51BC0", Offset = "0x7D501C0", VA = "0x187D51BC0")]
	private static int[] JHNPAELOJCM(int AMICCGMJHBK, int DJMECIFFDJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x7D4CB00", Offset = "0x7D4B100", VA = "0x187D4CB00")]
	private void BOFMJJJDNII(AIPAHMNCJKP FCIPMBBCBBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7D50B40", Offset = "0x7D4F140", VA = "0x187D50B40")]
	private void ICOPJJOFJDO(AIPAHMNCJKP EKEPPODJHCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7D4F350", Offset = "0x7D4D950", VA = "0x187D4F350")]
	private void GKGOJDOEOPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7D526B0", Offset = "0x7D50CB0", VA = "0x187D526B0")]
	private void JPGKIGDFEHB(AIPAHMNCJKP EKEPPODJHCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7D4CB40", Offset = "0x7D4B140", VA = "0x187D4CB40")]
	private static void CAAIKNAEDGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public LHPGFBLNMLG()
	{
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class RRNetworkProfiler : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x9EA210", Offset = "0x9E8810", VA = "0x1809EA210")]
		public RRNetworkProfiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[ServiceLifetime(Lifetime.PhotonRoom)]
[RegisterService(typeof(DKJLIEKCOIF), new string[] { "Photon" })]
public class DKJLIEKCOIF : IJFNBDMABCN, MMMIGLKPHHG, PNPJOMLIBJD, APFCFLPNHFO
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct NLLFCCGOANP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public readonly MethodInfo NCHFMFOGLNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private readonly Func<MonoBehaviour, object> PEOFDHLLPNB;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xABB7D0", Offset = "0xAB9DD0", VA = "0x180ABB7D0")]
		public NLLFCCGOANP(MethodInfo NCHFMFOGLNM, [Optional] Func<MonoBehaviour, object> PEOFDHLLPNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x70CA420", Offset = "0x70C8A20", VA = "0x1870CA420")]
		public object DOAAPMDBJIA(MonoBehaviour IKCFICLGIJM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class ELEMBEFICCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public FieldInfo instanceAccessFromField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Func<MonoBehaviour, object> <>9__4;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public ELEMBEFICCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x7D458F0", Offset = "0x7D43EF0", VA = "0x187D458F0")]
		internal NLLFCCGOANP JFPPBGEIMGM(MethodInfo methodInfo)
		{
			return default(NLLFCCGOANP);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x40952B0", Offset = "0x40938B0", VA = "0x1840952B0")]
		internal object JHLLEOLAONP(MonoBehaviour mb)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class HDBBHABINKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Func<MonoBehaviour, object> accessor;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public HDBBHABINKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x70E5D80", Offset = "0x70E4380", VA = "0x1870E5D80")]
		internal NLLFCCGOANP PBHADBGMPEK(MethodInfo methodInfo)
		{
			return default(NLLFCCGOANP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class PIODGODKKKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public Type attributeType;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public PIODGODKKKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7D56A30", Offset = "0x7D55030", VA = "0x187D56A30")]
		internal bool DEBLPIJDLBK(MethodInfo m)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private AMEDJJJMDOA INNHHCAIFEL;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static readonly Stopwatch OLLCPMNCLLB;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static Dictionary<MethodInfo, ParameterInfo[]> KFHPGCLFJBB;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static readonly Dictionary<Type, List<NLLFCCGOANP>> HFLNHCBBEAE;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7D455C0", Offset = "0x7D43BC0", VA = "0x187D455C0", Slot = "4")]
	public void OPNHMMPAKCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7D41E80", Offset = "0x7D40480", VA = "0x187D41E80", Slot = "6")]
	public void InitReferences(APJCDBKKFBB IDEMOBALCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7D437C0", Offset = "0x7D41DC0", VA = "0x187D437C0", Slot = "5")]
	public void NHMAMKPPBPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7D41ED0", Offset = "0x7D404D0", VA = "0x187D41ED0")]
	private void JINGFBINPHA(OJOPFCHDHDL NKBJHKLGFDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x7D41E50", Offset = "0x7D40450", VA = "0x187D41E50", Slot = "10")]
	public string HJIPCKIOIDI(OJOPFCHDHDL NKBJHKLGFDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7D41D50", Offset = "0x7D40350", VA = "0x187D41D50", Slot = "9")]
	public void FHBNKHIABHP(ViewId HMGHCPIBIBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7D436F0", Offset = "0x7D41CF0", VA = "0x187D436F0", Slot = "7")]
	public void MFHIAMJFGCB(ViewId NNAEIGBDCOK, string MNNPFFMKDDK, AIPAHMNCJKP EKEPPODJHCN, LMIOHHKDMIA LKKOOEFOJEP, params object[] PMLCGCAHNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x7D436C0", Offset = "0x7D41CC0", VA = "0x187D436C0", Slot = "8")]
	public void MFHIAMJFGCB(ViewId NNAEIGBDCOK, string MNNPFFMKDDK, KJGIOBLOLOL FCPOJLOEIEO, LMIOHHKDMIA LKKOOEFOJEP, params object[] PMLCGCAHNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x7D43290", Offset = "0x7D41890", VA = "0x187D43290")]
	private void MFHIAMJFGCB(ViewId NNAEIGBDCOK, string MNNPFFMKDDK, KJGIOBLOLOL FCPOJLOEIEO, AIPAHMNCJKP EKEPPODJHCN, LMIOHHKDMIA LKKOOEFOJEP, params object[] PMLCGCAHNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x7D43910", Offset = "0x7D41F10", VA = "0x187D43910")]
	private void OEAHHLOHHEC(ViewId HMGHCPIBIBG, string MNNPFFMKDDK, AIPAHMNCJKP OHEIAKHGGAM, int OFCIEGJOLJI, object[] DLHJDCJDKHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7D42BD0", Offset = "0x7D411D0", VA = "0x187D42BD0")]
	private static void LMKKGBBBLAJ(NLLFCCGOANP OAKFMPLKGOM, MonoBehaviour PCIKBBAHNDK, object[] ODJGLJIHJOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x7D43060", Offset = "0x7D41660", VA = "0x187D43060")]
	private static bool LOHGHEDDPOL(ParameterInfo[] KNMPJCNGDCE, Type[] DAAKCJLHAEA, [Out] bool HDLALNCIPJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x7D420D0", Offset = "0x7D406D0", VA = "0x187D420D0")]
	private List<NLLFCCGOANP> KKFDHAMLPCN(MonoBehaviour PCIKBBAHNDK, Type LKKKPPBGLKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x7D41C50", Offset = "0x7D40250", VA = "0x187D41C50")]
	private static IEnumerable<MethodInfo> EMCFKMCLKCF(Type MLCOGCMJLBB, Type CMKGOIBIHLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x7D42AC0", Offset = "0x7D410C0", VA = "0x187D42AC0")]
	public static ParameterInfo[] KNKPFGDNADH(MethodInfo DACLIFCINFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public DKJLIEKCOIF()
	{
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class RRNetworkView : MonoBehaviour, KGHDONEDALP, ELDKDFIOIIJ, NAEKJIPALAD, MECOHKFOCBB, DFIANIHLECG
	{
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public enum GFIMADFOAEG
		{
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			False,
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			True_SetInSceneForRoom,
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			True_ManuallySetInPrefab
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private sealed class EJFAOAIILKF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public int actorNumber;

			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public EJFAOAIILKF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0x7D45890", Offset = "0x7D43E90", VA = "0x187D45890")]
			internal bool BJINNMANOFB(RRNetworkView view)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private static Dictionary<int, RRNetworkView> IDBMIFMPECE;

		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private static FIHNAFNBAOM DHDCCLLHGGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[SerializeField]
		private int viewIdField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[SerializeField]
		private int instantiationIdField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private bool GMPFOEKPMHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		internal bool NAPHJJBMIFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[Tooltip("By default, prefabs cannot contain hard coded values for viewIdField; singletons that need to have consistent viewIdField across clients may set this flag to disable automatic cleaning of the property viewIdField")]
		[SerializeField]
		public GFIMADFOAEG hasExplicitViewId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private bool BDLGCLPBDFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private bool FFFFOEAFBFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int AHCCPENMLCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private bool MFBCIFOMEIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int KIOMGCFPBNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private AIPAHMNCJKP AMICCGMJHBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private AIPAHMNCJKP OEEDKOCKHDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private bool? DKDEMBNCGEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private bool DEKPBBBFJOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		internal bool NJPDKLAJEIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		internal MonoBehaviour[] PANOBMBINIC;

		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private static readonly JBBHIJHGEPM EGIKMJDKJEA;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public ViewId IHIKCBIHDHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x7D5CCA0", Offset = "0x7D5B2A0", VA = "0x187D5CCA0")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public ViewId GNGBPIMGLMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x7D5CCA0", Offset = "0x7D5B2A0", VA = "0x187D5CCA0", Slot = "5")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public ViewId DJFLGABMOBP
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x7D5CCA0", Offset = "0x7D5B2A0", VA = "0x187D5CCA0")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public int JJFJOKEEGHG
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x9ED2A0", Offset = "0x9EB8A0", VA = "0x1809ED2A0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x9ED290", Offset = "0x9EB890", VA = "0x1809ED290")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int ACIDAPBFPPE
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0xA12D10", Offset = "0xA11310", VA = "0x180A12D10")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0xD67020", Offset = "0xD65620", VA = "0x180D67020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public ViewId FCOCCKCDLGL
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x7D5CB10", Offset = "0x7D5B110", VA = "0x187D5CB10")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool KFPHPGEAPBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x9EB560", Offset = "0x9E9B60", VA = "0x1809EB560")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x9EB530", Offset = "0x9E9B30", VA = "0x1809EB530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool JHLHPMKGCFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x7D5CB20", Offset = "0x7D5B120", VA = "0x187D5CB20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool JHLHDEHFLPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0xDBBFE0", Offset = "0xDBA5E0", VA = "0x180DBBFE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0xAA4630", Offset = "0xAA2C30", VA = "0x180AA4630")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int EBNLBDEAIJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0xC642E0", Offset = "0xC628E0", VA = "0x180C642E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int KACEEHPIAIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x7D5CAB0", Offset = "0x7D5B0B0", VA = "0x187D5CAB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public AIPAHMNCJKP LIFEMEGPEKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x7D5CCB0", Offset = "0x7D5B2B0", VA = "0x187D5CCB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public AIPAHMNCJKP FKILKCLMCFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x7D5CA80", Offset = "0x7D5B080", VA = "0x187D5CA80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public AIPAHMNCJKP FDILDJGCAAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x7D5CA80", Offset = "0x7D5B080", VA = "0x187D5CA80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public AIPAHMNCJKP MMJEBHPLNIH
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x7D5CA80", Offset = "0x7D5B080", VA = "0x187D5CA80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool JPAAEDPKBHB
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x7D5CBF0", Offset = "0x7D5B1F0", VA = "0x187D5CBF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public int NJCKKDDBCBO
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x7D5CAE0", Offset = "0x7D5B0E0", VA = "0x187D5CAE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public object[] BJJHPLKBEGA
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x9EB7A0", Offset = "0x9E9DA0", VA = "0x1809EB7A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x9EB500", Offset = "0x9E9B00", VA = "0x1809EB500")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool JKOBLADOGFI
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x7D5CCE0", Offset = "0x7D5B2E0", VA = "0x187D5CCE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool PBOGJNHEMEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x7D5CC70", Offset = "0x7D5B270", VA = "0x187D5CC70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool BNFOGIBLEGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0xD31720", Offset = "0xD2FD20", VA = "0x180D31720")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0xE8A7F0", Offset = "0xE88DF0", VA = "0x180E8A7F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool LMGPENNCPHI
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0xBEE050", Offset = "0xBEC650", VA = "0x180BEE050")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<RRNetworkView> ABCPMIJPAED
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x7D5C920", Offset = "0x7D5AF20", VA = "0x187D5C920")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x7D5CEA0", Offset = "0x7D5B4A0", VA = "0x187D5CEA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		private event Action<AIPAHMNCJKP> NGLKLIMBLIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x7D58310", Offset = "0x7D56910", VA = "0x187D58310")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x7D57C50", Offset = "0x7D56250", VA = "0x187D57C50")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		public event Action<AIPAHMNCJKP> HEANCPHMAKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x7D58310", Offset = "0x7D56910", VA = "0x187D58310")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x7D57C50", Offset = "0x7D56250", VA = "0x187D57C50")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		private event Action<int> KAMGKJJBOJK
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x7D592C0", Offset = "0x7D578C0", VA = "0x187D592C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x7D59940", Offset = "0x7D57F40", VA = "0x187D59940")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		public event Action<int> IGGCJIIJACN
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x7D592C0", Offset = "0x7D578C0", VA = "0x187D592C0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x7D59940", Offset = "0x7D57F40", VA = "0x187D59940")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		public event Action<RRNetworkView> GLOJPNPMABH
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x7D5C9D0", Offset = "0x7D5AFD0", VA = "0x187D5C9D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x7D5CF50", Offset = "0x7D5B550", VA = "0x187D5CF50")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		public event Action KPDKNHOPMJH
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x7D5C870", Offset = "0x7D5AE70", VA = "0x187D5C870")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x7D5CDF0", Offset = "0x7D5B3F0", VA = "0x187D5CDF0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7D5C6B0", Offset = "0x7D5ACB0", VA = "0x187D5C6B0")]
		public static bool TryGetNetworkView(int HMGHCPIBIBG, [Out] RRNetworkView NNAEIGBDCOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x7D583C0", Offset = "0x7D569C0", VA = "0x187D583C0")]
		public static RRNetworkView Find(int HMGHCPIBIBG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7D58590", Offset = "0x7D56B90", VA = "0x187D58590")]
		public static IEnumerable<RRNetworkView> GetCreatedAndOwnedNetworkViews(int NDLKGDLDBGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7D58520", Offset = "0x7D56B20", VA = "0x187D58520")]
		public static IEnumerable<RRNetworkView> GetAllNetworkViews()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7D59F20", Offset = "0x7D58520", VA = "0x187D59F20")]
		public static bool RemoveNetworkView(RRNetworkView NNAEIGBDCOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7D59CF0", Offset = "0x7D582F0", VA = "0x187D59CF0")]
		public static void RebuildControllCacheForAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x7D595F0", Offset = "0x7D57BF0", VA = "0x187D595F0")]
		public static void OnPlayerJoinedRoom(AIPAHMNCJKP MGDCBAKNPNC, List<int> AHAPNENDNGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7D586D0", Offset = "0x7D56CD0", VA = "0x187D586D0")]
		public static RRNetworkView Get(Component HABFEKNHDFB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7D58730", Offset = "0x7D56D30", VA = "0x187D58730")]
		public static RRNetworkView Get(GameObject LLKCDHPIHPF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x7D58220", Offset = "0x7D56820", VA = "0x187D58220")]
		private void FGNLBGBANMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7D580E0", Offset = "0x7D566E0", VA = "0x187D580E0")]
		public bool CreatedBy(AIPAHMNCJKP EKEPPODJHCN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7D5C4C0", Offset = "0x7D5AAC0", VA = "0x187D5C4C0")]
		public void TransferOwnership(int JJHMNOEAAEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7D5C460", Offset = "0x7D5AA60", VA = "0x187D5C460")]
		public void TransferOwnership(AIPAHMNCJKP CCMFOKHGMEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7D58CF0", Offset = "0x7D572F0", VA = "0x187D58CF0", Slot = "4")]
		public void Initialize(ViewId LEMBFAMPAIL, ViewId GIGCJFBFOMC, Dictionary<int, object> BCFIBNCLPAG, AEMMHEJJEHA AMICCGMJHBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7D58C90", Offset = "0x7D57290", VA = "0x187D58C90")]
		public void Initialize(ViewId LEMBFAMPAIL, ViewId GIGCJFBFOMC, object[] IBEKDIGPJMO, AEMMHEJJEHA AMICCGMJHBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x7D57D00", Offset = "0x7D56300", VA = "0x187D57D00")]
		protected internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7D58E70", Offset = "0x7D57470", VA = "0x187D58E70")]
		private void JGHOGPACJOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x1D6DF90", Offset = "0x1D6C590", VA = "0x181D6DF90")]
		internal void LNPEGKKPILP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7D58160", Offset = "0x7D56760", VA = "0x187D58160", Slot = "6")]
		private void EHAONPMJKOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7D59250", Offset = "0x7D57850", VA = "0x187D59250")]
		internal bool NLNOOMGBCHI(RRNetworkView GMLBOIDLICI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x7D59450", Offset = "0x7D57A50", VA = "0x187D59450")]
		protected internal void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x7D591F0", Offset = "0x7D577F0", VA = "0x187D591F0")]
		internal void NLLLHOEPOIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x7D58300", Offset = "0x7D56900", VA = "0x187D58300")]
		private void FLJKHEDGPEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x7D599F0", Offset = "0x7D57FF0", VA = "0x187D599F0")]
		internal void PIDLAAPKALH(AIPAHMNCJKP CCMFOKHGMEC, int JJHMNOEAAEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x7D59E80", Offset = "0x7D58480", VA = "0x187D59E80")]
		public void RebuildControllerCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x7D59FA0", Offset = "0x7D585A0", VA = "0x187D59FA0")]
		public void ResetOwnership()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x7D57DD0", Offset = "0x7D563D0", VA = "0x187D57DD0")]
		private void CAKMKMLBCDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7D59100", Offset = "0x7D57700", VA = "0x187D59100")]
		private void LJHHKJJOGLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7D59BB0", Offset = "0x7D581B0", VA = "0x187D59BB0")]
		public void RPC(string MNNPFFMKDDK, KJGIOBLOLOL FCPOJLOEIEO, params object[] PMLCGCAHNGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x7D59C50", Offset = "0x7D58250", VA = "0x187D59C50")]
		public void RPC(string MNNPFFMKDDK, AIPAHMNCJKP HDJKAKBEEHP, params object[] PMLCGCAHNGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x7D59ED0", Offset = "0x7D584D0", VA = "0x187D59ED0")]
		public void RefreshRpcMonoBehaviourCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x7D57D60", Offset = "0x7D56360", VA = "0x187D57D60", Slot = "7")]
		public void Bake(IDHOFIHAGPL INLEBAAACKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x7D59370", Offset = "0x7D57970", VA = "0x187D59370")]
		private static void OKKKFOBNPNG(AIPAHMNCJKP MCADOGGHICO, [Out] NLDJFEFKCOP HIHGMFDAMLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x7D58830", Offset = "0x7D56E30", VA = "0x187D58830")]
		private static void IHCDPPDGAIP(RRNetworkView EGLHICHHNHO, Delegate OAKFMPLKGOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x7D58450", Offset = "0x7D56A50", VA = "0x187D58450")]
		private static ADKOONPNFKJ GDNDKKIGNCL(RRNetworkView EGLHICHHNHO)
		{
			return default(ADKOONPNFKJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x7D58790", Offset = "0x7D56D90", VA = "0x187D58790")]
		private static OHMCHEMAHNO IHAPCBAKLAB(RRNetworkView EGLHICHHNHO)
		{
			return default(OHMCHEMAHNO);
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x7D57AF0", Offset = "0x7D560F0", VA = "0x187D57AF0")]
		private static void AOABJDPJLOH(RRNetworkView EGLHICHHNHO, Delegate OAKFMPLKGOM, AIPAHMNCJKP HICDMGMONDF, params object[] PMLCGCAHNGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x7D57A10", Offset = "0x7D56010", VA = "0x187D57A10")]
		private static void AOABJDPJLOH(RRNetworkView EGLHICHHNHO, Delegate OAKFMPLKGOM, KJGIOBLOLOL HICDMGMONDF, params object[] PMLCGCAHNGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7D57BD0", Offset = "0x7D561D0", VA = "0x187D57BD0")]
		private static void AOABJDPJLOH(RRNetworkView EGLHICHHNHO, Delegate OAKFMPLKGOM, NLDJFEFKCOP HICDMGMONDF, params object[] PMLCGCAHNGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x7D58B50", Offset = "0x7D57150", VA = "0x187D58B50")]
		private static void IOPOFIBALBF(RRNetworkView EGLHICHHNHO, Delegate OAKFMPLKGOM, KJGIOBLOLOL HICDMGMONDF, EMNJAEJFHEA NODBEPIGONB, params object[] PMLCGCAHNGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7D59AB0", Offset = "0x7D580B0", VA = "0x187D59AB0")]
		public void RPCBuffered(string MNNPFFMKDDK, KJGIOBLOLOL FCPOJLOEIEO, EMNJAEJFHEA LKKOOEFOJEP, params object[] PMLCGCAHNGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x7D59060", Offset = "0x7D57660", VA = "0x187D59060")]
		private static bool JMOBHBHCPNO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x7D5AA10", Offset = "0x7D59010", VA = "0x187D5AA10", Slot = "22")]
		public void RpcAll(LNIEFAPAFBD.HLHNOLMDHLA OAKFMPLKGOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x3AB6080", Offset = "0x3AB4680", VA = "0x183AB6080", Slot = "8")]
		public void RpcAll<T1>(LNIEFAPAFBD.MGNJCNCKKGJ<T1> OAKFMPLKGOM, T1 DNCLAIANHEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x3AB58B0", Offset = "0x3AB3EB0", VA = "0x183AB58B0", Slot = "9")]
		public void RpcAll<T1, T2>(LNIEFAPAFBD.PDLNFFIGAKK<T1, T2> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x3AB7D90", Offset = "0x3AB6390", VA = "0x183AB7D90", Slot = "23")]
		public void RpcAll<T1, T2, T3>(LNIEFAPAFBD.DCKMEMCFKIO<T1, T2, T3> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x3AB5AE0", Offset = "0x3AB40E0", VA = "0x183AB5AE0", Slot = "24")]
		public void RpcAll<T1, T2, T3, T4>(LNIEFAPAFBD.BECFGHCOCBP<T1, T2, T3, T4> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x3AB7730", Offset = "0x3AB5D30", VA = "0x183AB7730", Slot = "25")]
		public void RpcAll<T1, T2, T3, T4, T5>(LNIEFAPAFBD.AGMELPKKIEG<T1, T2, T3, T4, T5> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x3AB82A0", Offset = "0x3AB68A0", VA = "0x183AB82A0", Slot = "26")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(LNIEFAPAFBD.CFJDOKPAGBO<T1, T2, T3, T4, T5, T6> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x3ABC290", Offset = "0x3ABA890", VA = "0x183ABC290", Slot = "27")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(LNIEFAPAFBD.HEKGAFAKBLP<T1, T2, T3, T4, T5, T6, T7> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x3AC68C0", Offset = "0x3AC4EC0", VA = "0x183AC68C0", Slot = "28")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(LNIEFAPAFBD.MIMBKBFLAMO<T1, T2, T3, T4, T5, T6, T7, T8> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x3AB8750", Offset = "0x3AB6D50", VA = "0x183AB8750", Slot = "29")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(LNIEFAPAFBD.NLHAOCFHJGB<T1, T2, T3, T4, T5, T6, T7, T8, T9> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x3AB6B00", Offset = "0x3AB5100", VA = "0x183AB6B00", Slot = "10")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(EHKEABCBCIL OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x3AC4310", Offset = "0x3AC2910", VA = "0x183AC4310", Slot = "30")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(KFLKPPDEHDB OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x3AC32B0", Offset = "0x3AC18B0", VA = "0x183AC32B0", Slot = "31")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(CKOBGIOLMKJ OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x3AC14A0", Offset = "0x3ABFAA0", VA = "0x183AC14A0", Slot = "32")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(MKBCOIOOOMJ OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE, T13 FJOAEBMLFMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x3AB6220", Offset = "0x3AB4820", VA = "0x183AB6220", Slot = "33")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OOMHNJCNJJF OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE, T13 FJOAEBMLFMA, T14 AECGFNNIGJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x7D5A620", Offset = "0x7D58C20", VA = "0x187D5A620")]
		public void RpcAll(LNIEFAPAFBD.MGNJCNCKKGJ<ADKOONPNFKJ> OAKFMPLKGOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x3ABA960", Offset = "0x3AB8F60", VA = "0x183ABA960")]
		public void RpcAll<T1>(LNIEFAPAFBD.PDLNFFIGAKK<T1, ADKOONPNFKJ> OAKFMPLKGOM, T1 DNCLAIANHEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x3ABB3B0", Offset = "0x3AB99B0", VA = "0x183ABB3B0")]
		public void RpcAll<T1, T2>(LNIEFAPAFBD.DCKMEMCFKIO<T1, T2, ADKOONPNFKJ> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x3AB7400", Offset = "0x3AB5A00", VA = "0x183AB7400")]
		public void RpcAll<T1, T2, T3>(LNIEFAPAFBD.BECFGHCOCBP<T1, T2, T3, ADKOONPNFKJ> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x3AC94C0", Offset = "0x3AC7AC0", VA = "0x183AC94C0")]
		public void RpcAll<T1, T2, T3, T4>(LNIEFAPAFBD.AGMELPKKIEG<T1, T2, T3, T4, ADKOONPNFKJ> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x3AC8C60", Offset = "0x3AC7260", VA = "0x183AC8C60")]
		public void RpcAll<T1, T2, T3, T4, T5>(LNIEFAPAFBD.CFJDOKPAGBO<T1, T2, T3, T4, T5, ADKOONPNFKJ> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x3AC82F0", Offset = "0x3AC68F0", VA = "0x183AC82F0")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(LNIEFAPAFBD.HEKGAFAKBLP<T1, T2, T3, T4, T5, T6, ADKOONPNFKJ> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3AC70F0", Offset = "0x3AC56F0", VA = "0x183AC70F0")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(LNIEFAPAFBD.MIMBKBFLAMO<T1, T2, T3, T4, T5, T6, T7, ADKOONPNFKJ> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x3AC6CB0", Offset = "0x3AC52B0", VA = "0x183AC6CB0")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(LNIEFAPAFBD.NLHAOCFHJGB<T1, T2, T3, T4, T5, T6, T7, T8, ADKOONPNFKJ> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x3AC56F0", Offset = "0x3AC3CF0", VA = "0x183AC56F0")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(EHKEABCBCIL OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x3AC4830", Offset = "0x3AC2E30", VA = "0x183AC4830")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(KFLKPPDEHDB OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x3AC3830", Offset = "0x3AC1E30", VA = "0x183AC3830")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(CKOBGIOLMKJ OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x3AC2CE0", Offset = "0x3AC12E0", VA = "0x183AC2CE0")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(MKBCOIOOOMJ OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x3AC1A90", Offset = "0x3AC0090", VA = "0x183AC1A90")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OOMHNJCNJJF OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE, T13 FJOAEBMLFMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x3AC0DF0", Offset = "0x3ABF3F0", VA = "0x183AC0DF0")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ICGECMHFHGO OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE, T13 FJOAEBMLFMA, T14 AECGFNNIGJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x7D5A7E0", Offset = "0x7D58DE0", VA = "0x187D5A7E0", Slot = "34")]
		public void RpcAll(LNIEFAPAFBD.MGNJCNCKKGJ<OHMCHEMAHNO> OAKFMPLKGOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x3ACD890", Offset = "0x3ACBE90", VA = "0x183ACD890", Slot = "35")]
		public void RpcAll<T1>(LNIEFAPAFBD.PDLNFFIGAKK<T1, OHMCHEMAHNO> OAKFMPLKGOM, T1 DNCLAIANHEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x3ACB9B0", Offset = "0x3AC9FB0", VA = "0x183ACB9B0", Slot = "36")]
		public void RpcAll<T1, T2>(LNIEFAPAFBD.DCKMEMCFKIO<T1, T2, OHMCHEMAHNO> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x3AC9FC0", Offset = "0x3AC85C0", VA = "0x183AC9FC0", Slot = "37")]
		public void RpcAll<T1, T2, T3>(LNIEFAPAFBD.BECFGHCOCBP<T1, T2, T3, OHMCHEMAHNO> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x3AC91F0", Offset = "0x3AC77F0", VA = "0x183AC91F0", Slot = "38")]
		public void RpcAll<T1, T2, T3, T4>(LNIEFAPAFBD.AGMELPKKIEG<T1, T2, T3, T4, OHMCHEMAHNO> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x3AC8670", Offset = "0x3AC6C70", VA = "0x183AC8670", Slot = "39")]
		public void RpcAll<T1, T2, T3, T4, T5>(LNIEFAPAFBD.CFJDOKPAGBO<T1, T2, T3, T4, T5, OHMCHEMAHNO> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x3AC7C40", Offset = "0x3AC6240", VA = "0x183AC7C40", Slot = "40")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(LNIEFAPAFBD.HEKGAFAKBLP<T1, T2, T3, T4, T5, T6, OHMCHEMAHNO> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x3AC7860", Offset = "0x3AC5E60", VA = "0x183AC7860", Slot = "41")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(LNIEFAPAFBD.MIMBKBFLAMO<T1, T2, T3, T4, T5, T6, T7, OHMCHEMAHNO> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x3AC6480", Offset = "0x3AC4A80", VA = "0x183AC6480", Slot = "42")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(LNIEFAPAFBD.NLHAOCFHJGB<T1, T2, T3, T4, T5, T6, T7, T8, OHMCHEMAHNO> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x3AC5FE0", Offset = "0x3AC45E0", VA = "0x183AC5FE0", Slot = "43")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(EHKEABCBCIL OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x3AC51F0", Offset = "0x3AC37F0", VA = "0x183AC51F0", Slot = "44")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(KFLKPPDEHDB OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x3AC3DA0", Offset = "0x3AC23A0", VA = "0x183AC3DA0", Slot = "45")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(CKOBGIOLMKJ OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x3AC2710", Offset = "0x3AC0D10", VA = "0x183AC2710", Slot = "46")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(MKBCOIOOOMJ OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3AC20D0", Offset = "0x3AC06D0", VA = "0x183AC20D0", Slot = "47")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OOMHNJCNJJF OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE, T13 FJOAEBMLFMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3AC00E0", Offset = "0x3ABE6E0", VA = "0x183AC00E0", Slot = "48")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ICGECMHFHGO OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE, T13 FJOAEBMLFMA, T14 AECGFNNIGJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x7D5A4F0", Offset = "0x7D58AF0", VA = "0x187D5A4F0", Slot = "49")]
		public void RpcAllViaServer(LNIEFAPAFBD.HLHNOLMDHLA OAKFMPLKGOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3ADD420", Offset = "0x3ADBA20", VA = "0x183ADD420", Slot = "50")]
		public void RpcAllViaServer<T1>(LNIEFAPAFBD.MGNJCNCKKGJ<T1> OAKFMPLKGOM, T1 DNCLAIANHEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x3AD5170", Offset = "0x3AD3770", VA = "0x183AD5170", Slot = "11")]
		public void RpcAllViaServer<T1, T2>(LNIEFAPAFBD.PDLNFFIGAKK<T1, T2> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x3ADC8F0", Offset = "0x3ADAEF0", VA = "0x183ADC8F0", Slot = "51")]
		public void RpcAllViaServer<T1, T2, T3>(LNIEFAPAFBD.DCKMEMCFKIO<T1, T2, T3> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x3ADC6F0", Offset = "0x3ADACF0", VA = "0x183ADC6F0", Slot = "52")]
		public void RpcAllViaServer<T1, T2, T3, T4>(LNIEFAPAFBD.BECFGHCOCBP<T1, T2, T3, T4> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x3ADBC00", Offset = "0x3ADA200", VA = "0x183ADBC00", Slot = "53")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(LNIEFAPAFBD.AGMELPKKIEG<T1, T2, T3, T4, T5> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3ADB450", Offset = "0x3AD9A50", VA = "0x183ADB450", Slot = "54")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(LNIEFAPAFBD.CFJDOKPAGBO<T1, T2, T3, T4, T5, T6> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x3ADB170", Offset = "0x3AD9770", VA = "0x183ADB170", Slot = "55")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(LNIEFAPAFBD.HEKGAFAKBLP<T1, T2, T3, T4, T5, T6, T7> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x3ADA220", Offset = "0x3AD8820", VA = "0x183ADA220", Slot = "56")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(LNIEFAPAFBD.MIMBKBFLAMO<T1, T2, T3, T4, T5, T6, T7, T8> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3AD9EA0", Offset = "0x3AD84A0", VA = "0x183AD9EA0", Slot = "57")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(LNIEFAPAFBD.NLHAOCFHJGB<T1, T2, T3, T4, T5, T6, T7, T8, T9> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x3AD8C30", Offset = "0x3AD7230", VA = "0x183AD8C30", Slot = "58")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(EHKEABCBCIL OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3AD7FD0", Offset = "0x3AD65D0", VA = "0x183AD7FD0", Slot = "59")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(KFLKPPDEHDB OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x3AD7280", Offset = "0x3AD5880", VA = "0x183AD7280", Slot = "60")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(CKOBGIOLMKJ OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x3AD6DC0", Offset = "0x3AD53C0", VA = "0x183AD6DC0", Slot = "61")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(MKBCOIOOOMJ OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE, T13 FJOAEBMLFMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x3AD5A00", Offset = "0x3AD4000", VA = "0x183AD5A00", Slot = "62")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OOMHNJCNJJF OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE, T13 FJOAEBMLFMA, T14 AECGFNNIGJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7D5A3C0", Offset = "0x7D589C0", VA = "0x187D5A3C0")]
		public void RpcAllViaServer(LNIEFAPAFBD.MGNJCNCKKGJ<ADKOONPNFKJ> OAKFMPLKGOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3ADD320", Offset = "0x3ADB920", VA = "0x183ADD320")]
		public void RpcAllViaServer<T1>(LNIEFAPAFBD.PDLNFFIGAKK<T1, ADKOONPNFKJ> OAKFMPLKGOM, T1 DNCLAIANHEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3ADCE00", Offset = "0x3ADB400", VA = "0x183ADCE00")]
		public void RpcAllViaServer<T1, T2>(LNIEFAPAFBD.DCKMEMCFKIO<T1, T2, ADKOONPNFKJ> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x3ADCAA0", Offset = "0x3ADB0A0", VA = "0x183ADCAA0")]
		public void RpcAllViaServer<T1, T2, T3>(LNIEFAPAFBD.BECFGHCOCBP<T1, T2, T3, ADKOONPNFKJ> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3ADC4F0", Offset = "0x3ADAAF0", VA = "0x183ADC4F0")]
		public void RpcAllViaServer<T1, T2, T3, T4>(LNIEFAPAFBD.AGMELPKKIEG<T1, T2, T3, T4, ADKOONPNFKJ> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x3ADBE50", Offset = "0x3ADA450", VA = "0x183ADBE50")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(LNIEFAPAFBD.CFJDOKPAGBO<T1, T2, T3, T4, T5, ADKOONPNFKJ> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x3ADB970", Offset = "0x3AD9F70", VA = "0x183ADB970")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(LNIEFAPAFBD.HEKGAFAKBLP<T1, T2, T3, T4, T5, T6, ADKOONPNFKJ> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x3ADAE90", Offset = "0x3AD9490", VA = "0x183ADAE90")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(LNIEFAPAFBD.MIMBKBFLAMO<T1, T2, T3, T4, T5, T6, T7, ADKOONPNFKJ> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x3ADA880", Offset = "0x3AD8E80", VA = "0x183ADA880")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(LNIEFAPAFBD.NLHAOCFHJGB<T1, T2, T3, T4, T5, T6, T7, T8, ADKOONPNFKJ> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x3AD9B20", Offset = "0x3AD8120", VA = "0x183AD9B20")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(EHKEABCBCIL OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x3AD93D0", Offset = "0x3AD79D0", VA = "0x183AD93D0")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(KFLKPPDEHDB OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x3AD83F0", Offset = "0x3AD69F0", VA = "0x183AD83F0")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(CKOBGIOLMKJ OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x3AD7B60", Offset = "0x3AD6160", VA = "0x183AD7B60")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(MKBCOIOOOMJ OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x3AD6900", Offset = "0x3AD4F00", VA = "0x183AD6900")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OOMHNJCNJJF OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE, T13 FJOAEBMLFMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x3AD5F20", Offset = "0x3AD4520", VA = "0x183AD5F20")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ICGECMHFHGO OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE, T13 FJOAEBMLFMA, T14 AECGFNNIGJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x7D5A290", Offset = "0x7D58890", VA = "0x187D5A290", Slot = "63")]
		public void RpcAllViaServer(LNIEFAPAFBD.MGNJCNCKKGJ<OHMCHEMAHNO> OAKFMPLKGOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x3ADD220", Offset = "0x3ADB820", VA = "0x183ADD220", Slot = "64")]
		public void RpcAllViaServer<T1>(LNIEFAPAFBD.PDLNFFIGAKK<T1, OHMCHEMAHNO> OAKFMPLKGOM, T1 DNCLAIANHEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x3ADD0C0", Offset = "0x3ADB6C0", VA = "0x183ADD0C0", Slot = "65")]
		public void RpcAllViaServer<T1, T2>(LNIEFAPAFBD.DCKMEMCFKIO<T1, T2, OHMCHEMAHNO> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3ADCC50", Offset = "0x3ADB250", VA = "0x183ADCC50", Slot = "66")]
		public void RpcAllViaServer<T1, T2, T3>(LNIEFAPAFBD.BECFGHCOCBP<T1, T2, T3, OHMCHEMAHNO> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3ADC2F0", Offset = "0x3ADA8F0", VA = "0x183ADC2F0", Slot = "67")]
		public void RpcAllViaServer<T1, T2, T3, T4>(LNIEFAPAFBD.AGMELPKKIEG<T1, T2, T3, T4, OHMCHEMAHNO> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x3ADC0A0", Offset = "0x3ADA6A0", VA = "0x183ADC0A0", Slot = "68")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(LNIEFAPAFBD.CFJDOKPAGBO<T1, T2, T3, T4, T5, OHMCHEMAHNO> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x3ADB6E0", Offset = "0x3AD9CE0", VA = "0x183ADB6E0", Slot = "69")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(LNIEFAPAFBD.HEKGAFAKBLP<T1, T2, T3, T4, T5, T6, OHMCHEMAHNO> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x3ADABB0", Offset = "0x3AD91B0", VA = "0x183ADABB0", Slot = "70")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(LNIEFAPAFBD.MIMBKBFLAMO<T1, T2, T3, T4, T5, T6, T7, OHMCHEMAHNO> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3ADA550", Offset = "0x3AD8B50", VA = "0x183ADA550", Slot = "71")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(LNIEFAPAFBD.NLHAOCFHJGB<T1, T2, T3, T4, T5, T6, T7, T8, OHMCHEMAHNO> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3AD97A0", Offset = "0x3AD7DA0", VA = "0x183AD97A0", Slot = "72")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(EHKEABCBCIL OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x3AD9000", Offset = "0x3AD7600", VA = "0x183AD9000", Slot = "73")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(KFLKPPDEHDB OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3AD8810", Offset = "0x3AD6E10", VA = "0x183AD8810", Slot = "74")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(CKOBGIOLMKJ OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x3AD76F0", Offset = "0x3AD5CF0", VA = "0x183AD76F0", Slot = "75")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(MKBCOIOOOMJ OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3AD6440", Offset = "0x3AD4A40", VA = "0x183AD6440", Slot = "76")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OOMHNJCNJJF OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE, T13 FJOAEBMLFMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3AD54E0", Offset = "0x3AD3AE0", VA = "0x183AD54E0", Slot = "77")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ICGECMHFHGO OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE, T13 FJOAEBMLFMA, T14 AECGFNNIGJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x7D5BBC0", Offset = "0x7D5A1C0", VA = "0x187D5BBC0", Slot = "78")]
		public void RpcOthers(LNIEFAPAFBD.HLHNOLMDHLA OAKFMPLKGOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3B02130", Offset = "0x3B00730", VA = "0x183B02130", Slot = "12")]
		public void RpcOthers<T1>(LNIEFAPAFBD.MGNJCNCKKGJ<T1> OAKFMPLKGOM, T1 DNCLAIANHEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3B029E0", Offset = "0x3B00FE0", VA = "0x183B029E0", Slot = "79")]
		public void RpcOthers<T1, T2>(LNIEFAPAFBD.PDLNFFIGAKK<T1, T2> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x3B01EB0", Offset = "0x3B004B0", VA = "0x183B01EB0", Slot = "80")]
		public void RpcOthers<T1, T2, T3>(LNIEFAPAFBD.DCKMEMCFKIO<T1, T2, T3> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x3B05420", Offset = "0x3B03A20", VA = "0x183B05420", Slot = "81")]
		public void RpcOthers<T1, T2, T3, T4>(LNIEFAPAFBD.BECFGHCOCBP<T1, T2, T3, T4> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x3B03740", Offset = "0x3B01D40", VA = "0x183B03740", Slot = "82")]
		public void RpcOthers<T1, T2, T3, T4, T5>(LNIEFAPAFBD.AGMELPKKIEG<T1, T2, T3, T4, T5> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x3B04490", Offset = "0x3B02A90", VA = "0x183B04490", Slot = "83")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(LNIEFAPAFBD.CFJDOKPAGBO<T1, T2, T3, T4, T5, T6> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x3B04180", Offset = "0x3B02780", VA = "0x183B04180", Slot = "84")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(LNIEFAPAFBD.HEKGAFAKBLP<T1, T2, T3, T4, T5, T6, T7> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x3B14400", Offset = "0x3B12A00", VA = "0x183B14400", Slot = "85")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(LNIEFAPAFBD.MIMBKBFLAMO<T1, T2, T3, T4, T5, T6, T7, T8> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x3B14050", Offset = "0x3B12650", VA = "0x183B14050", Slot = "86")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(LNIEFAPAFBD.NLHAOCFHJGB<T1, T2, T3, T4, T5, T6, T7, T8, T9> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x3B13110", Offset = "0x3B11710", VA = "0x183B13110", Slot = "87")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(EHKEABCBCIL OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x3B124A0", Offset = "0x3B10AA0", VA = "0x183B124A0", Slot = "88")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(KFLKPPDEHDB OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x3B11740", Offset = "0x3B0FD40", VA = "0x183B11740", Slot = "89")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(CKOBGIOLMKJ OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x3B108D0", Offset = "0x3B0EED0", VA = "0x183B108D0", Slot = "90")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(MKBCOIOOOMJ OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE, T13 FJOAEBMLFMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x3B0F420", Offset = "0x3B0DA20", VA = "0x183B0F420", Slot = "91")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OOMHNJCNJJF OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE, T13 FJOAEBMLFMA, T14 AECGFNNIGJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x7D5BA70", Offset = "0x7D5A070", VA = "0x187D5BA70")]
		public void RpcOthers(LNIEFAPAFBD.MGNJCNCKKGJ<ADKOONPNFKJ> OAKFMPLKGOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x3B02740", Offset = "0x3B00D40", VA = "0x183B02740")]
		public void RpcOthers<T1>(LNIEFAPAFBD.PDLNFFIGAKK<T1, ADKOONPNFKJ> OAKFMPLKGOM, T1 DNCLAIANHEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x3B02560", Offset = "0x3B00B60", VA = "0x183B02560")]
		public void RpcOthers<T1, T2>(LNIEFAPAFBD.DCKMEMCFKIO<T1, T2, ADKOONPNFKJ> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x3B05C50", Offset = "0x3B04250", VA = "0x183B05C50")]
		public void RpcOthers<T1, T2, T3>(LNIEFAPAFBD.BECFGHCOCBP<T1, T2, T3, ADKOONPNFKJ> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x3B02280", Offset = "0x3B00880", VA = "0x183B02280")]
		public void RpcOthers<T1, T2, T3, T4>(LNIEFAPAFBD.AGMELPKKIEG<T1, T2, T3, T4, ADKOONPNFKJ> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x3B02ED0", Offset = "0x3B014D0", VA = "0x183B02ED0")]
		public void RpcOthers<T1, T2, T3, T4, T5>(LNIEFAPAFBD.CFJDOKPAGBO<T1, T2, T3, T4, T5, ADKOONPNFKJ> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x3B03210", Offset = "0x3B01810", VA = "0x183B03210")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(LNIEFAPAFBD.HEKGAFAKBLP<T1, T2, T3, T4, T5, T6, ADKOONPNFKJ> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3B03E70", Offset = "0x3B02470", VA = "0x183B03E70")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(LNIEFAPAFBD.MIMBKBFLAMO<T1, T2, T3, T4, T5, T6, T7, ADKOONPNFKJ> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x3B14760", Offset = "0x3B12D60", VA = "0x183B14760")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(LNIEFAPAFBD.NLHAOCFHJGB<T1, T2, T3, T4, T5, T6, T7, T8, ADKOONPNFKJ> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x3B13CA0", Offset = "0x3B122A0", VA = "0x183B13CA0")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(EHKEABCBCIL OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x3B13500", Offset = "0x3B11B00", VA = "0x183B13500")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(KFLKPPDEHDB OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x3B12060", Offset = "0x3B10660", VA = "0x183B12060")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(CKOBGIOLMKJ OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x3B11BD0", Offset = "0x3B101D0", VA = "0x183B11BD0")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(MKBCOIOOOMJ OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x3B10DC0", Offset = "0x3B0F3C0", VA = "0x183B10DC0")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OOMHNJCNJJF OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE, T13 FJOAEBMLFMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x3B0F960", Offset = "0x3B0DF60", VA = "0x183B0F960")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ICGECMHFHGO OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE, T13 FJOAEBMLFMA, T14 AECGFNNIGJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x7D5B920", Offset = "0x7D59F20", VA = "0x187D5B920", Slot = "92")]
		public void RpcOthers(LNIEFAPAFBD.MGNJCNCKKGJ<OHMCHEMAHNO> OAKFMPLKGOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x3B06830", Offset = "0x3B04E30", VA = "0x183B06830", Slot = "93")]
		public void RpcOthers<T1>(LNIEFAPAFBD.PDLNFFIGAKK<T1, OHMCHEMAHNO> OAKFMPLKGOM, T1 DNCLAIANHEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x3B061F0", Offset = "0x3B047F0", VA = "0x183B061F0", Slot = "94")]
		public void RpcOthers<T1, T2>(LNIEFAPAFBD.DCKMEMCFKIO<T1, T2, OHMCHEMAHNO> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x3B05E20", Offset = "0x3B04420", VA = "0x183B05E20", Slot = "95")]
		public void RpcOthers<T1, T2, T3>(LNIEFAPAFBD.BECFGHCOCBP<T1, T2, T3, OHMCHEMAHNO> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x3B05640", Offset = "0x3B03C40", VA = "0x183B05640", Slot = "96")]
		public void RpcOthers<T1, T2, T3, T4>(LNIEFAPAFBD.AGMELPKKIEG<T1, T2, T3, T4, OHMCHEMAHNO> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x3B051B0", Offset = "0x3B037B0", VA = "0x183B051B0", Slot = "97")]
		public void RpcOthers<T1, T2, T3, T4, T5>(LNIEFAPAFBD.CFJDOKPAGBO<T1, T2, T3, T4, T5, OHMCHEMAHNO> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x3B04A10", Offset = "0x3B03010", VA = "0x183B04A10", Slot = "98")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(LNIEFAPAFBD.HEKGAFAKBLP<T1, T2, T3, T4, T5, T6, OHMCHEMAHNO> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x3B14E20", Offset = "0x3B13420", VA = "0x183B14E20", Slot = "99")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(LNIEFAPAFBD.MIMBKBFLAMO<T1, T2, T3, T4, T5, T6, T7, OHMCHEMAHNO> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x3B14AC0", Offset = "0x3B130C0", VA = "0x183B14AC0", Slot = "100")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(LNIEFAPAFBD.NLHAOCFHJGB<T1, T2, T3, T4, T5, T6, T7, T8, OHMCHEMAHNO> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x3B138F0", Offset = "0x3B11EF0", VA = "0x183B138F0", Slot = "101")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(EHKEABCBCIL OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x3B12D20", Offset = "0x3B11320", VA = "0x183B12D20", Slot = "102")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(KFLKPPDEHDB OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x3B128E0", Offset = "0x3B10EE0", VA = "0x183B128E0", Slot = "103")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(CKOBGIOLMKJ OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x3B112B0", Offset = "0x3B0F8B0", VA = "0x183B112B0", Slot = "104")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(MKBCOIOOOMJ OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x3B103E0", Offset = "0x3B0E9E0", VA = "0x183B103E0", Slot = "105")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OOMHNJCNJJF OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE, T13 FJOAEBMLFMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x3B0FEA0", Offset = "0x3B0E4A0", VA = "0x183B0FEA0", Slot = "106")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ICGECMHFHGO OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE, T13 FJOAEBMLFMA, T14 AECGFNNIGJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x7D5B5B0", Offset = "0x7D59BB0", VA = "0x187D5B5B0", Slot = "107")]
		public void RpcMaster(LNIEFAPAFBD.HLHNOLMDHLA OAKFMPLKGOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x3AEE090", Offset = "0x3AEC690", VA = "0x183AEE090", Slot = "108")]
		public void RpcMaster<T1>(LNIEFAPAFBD.MGNJCNCKKGJ<T1> OAKFMPLKGOM, T1 DNCLAIANHEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x3AEE250", Offset = "0x3AEC850", VA = "0x183AEE250", Slot = "13")]
		public void RpcMaster<T1, T2>(LNIEFAPAFBD.PDLNFFIGAKK<T1, T2> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x3AEDBA0", Offset = "0x3AEC1A0", VA = "0x183AEDBA0", Slot = "109")]
		public void RpcMaster<T1, T2, T3>(LNIEFAPAFBD.DCKMEMCFKIO<T1, T2, T3> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x3AED830", Offset = "0x3AEBE30", VA = "0x183AED830", Slot = "110")]
		public void RpcMaster<T1, T2, T3, T4>(LNIEFAPAFBD.BECFGHCOCBP<T1, T2, T3, T4> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x3AF1AA0", Offset = "0x3AF00A0", VA = "0x183AF1AA0", Slot = "111")]
		public void RpcMaster<T1, T2, T3, T4, T5>(LNIEFAPAFBD.AGMELPKKIEG<T1, T2, T3, T4, T5> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x3AF3FE0", Offset = "0x3AF25E0", VA = "0x183AF3FE0", Slot = "112")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(LNIEFAPAFBD.CFJDOKPAGBO<T1, T2, T3, T4, T5, T6> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x3AFC470", Offset = "0x3AFAA70", VA = "0x183AFC470", Slot = "113")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(LNIEFAPAFBD.HEKGAFAKBLP<T1, T2, T3, T4, T5, T6, T7> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x3AFB770", Offset = "0x3AF9D70", VA = "0x183AFB770", Slot = "114")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(LNIEFAPAFBD.MIMBKBFLAMO<T1, T2, T3, T4, T5, T6, T7, T8> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x3AFAE30", Offset = "0x3AF9430", VA = "0x183AFAE30", Slot = "115")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(LNIEFAPAFBD.NLHAOCFHJGB<T1, T2, T3, T4, T5, T6, T7, T8, T9> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x3AF1240", Offset = "0x3AEF840", VA = "0x183AF1240", Slot = "116")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(EHKEABCBCIL OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x3AEFDF0", Offset = "0x3AEE3F0", VA = "0x183AEFDF0", Slot = "117")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(KFLKPPDEHDB OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x3AF78B0", Offset = "0x3AF5EB0", VA = "0x183AF78B0", Slot = "118")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(CKOBGIOLMKJ OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x3AF72C0", Offset = "0x3AF58C0", VA = "0x183AF72C0", Slot = "119")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(MKBCOIOOOMJ OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE, T13 FJOAEBMLFMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x3AF5910", Offset = "0x3AF3F10", VA = "0x183AF5910", Slot = "120")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OOMHNJCNJJF OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE, T13 FJOAEBMLFMA, T14 AECGFNNIGJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x7D5B3D0", Offset = "0x7D599D0", VA = "0x187D5B3D0")]
		public void RpcMaster(LNIEFAPAFBD.MGNJCNCKKGJ<ADKOONPNFKJ> OAKFMPLKGOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x3AEDE80", Offset = "0x3AEC480", VA = "0x183AEDE80")]
		public void RpcMaster<T1>(LNIEFAPAFBD.PDLNFFIGAKK<T1, ADKOONPNFKJ> OAKFMPLKGOM, T1 DNCLAIANHEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x3AEEF60", Offset = "0x3AED560", VA = "0x183AEEF60")]
		public void RpcMaster<T1, T2>(LNIEFAPAFBD.DCKMEMCFKIO<T1, T2, ADKOONPNFKJ> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x3AEE4B0", Offset = "0x3AECAB0", VA = "0x183AEE4B0")]
		public void RpcMaster<T1, T2, T3>(LNIEFAPAFBD.BECFGHCOCBP<T1, T2, T3, ADKOONPNFKJ> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x3AFEA20", Offset = "0x3AFD020", VA = "0x183AFEA20")]
		public void RpcMaster<T1, T2, T3, T4>(LNIEFAPAFBD.AGMELPKKIEG<T1, T2, T3, T4, ADKOONPNFKJ> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x3AF2550", Offset = "0x3AF0B50", VA = "0x183AF2550")]
		public void RpcMaster<T1, T2, T3, T4, T5>(LNIEFAPAFBD.CFJDOKPAGBO<T1, T2, T3, T4, T5, ADKOONPNFKJ> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x3AFD3A0", Offset = "0x3AFB9A0", VA = "0x183AFD3A0")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(LNIEFAPAFBD.HEKGAFAKBLP<T1, T2, T3, T4, T5, T6, ADKOONPNFKJ> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x3AFCC40", Offset = "0x3AFB240", VA = "0x183AFCC40")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(LNIEFAPAFBD.MIMBKBFLAMO<T1, T2, T3, T4, T5, T6, T7, ADKOONPNFKJ> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x3AFC000", Offset = "0x3AFA600", VA = "0x183AFC000")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(LNIEFAPAFBD.NLHAOCFHJGB<T1, T2, T3, T4, T5, T6, T7, T8, ADKOONPNFKJ> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x3AFA960", Offset = "0x3AF8F60", VA = "0x183AFA960")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(EHKEABCBCIL OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x3AF9A30", Offset = "0x3AF8030", VA = "0x183AF9A30")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(KFLKPPDEHDB OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x3AF8A00", Offset = "0x3AF7000", VA = "0x183AF8A00")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(CKOBGIOLMKJ OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x3AF7E40", Offset = "0x3AF6440", VA = "0x183AF7E40")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(MKBCOIOOOMJ OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x3AF6620", Offset = "0x3AF4C20", VA = "0x183AF6620")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OOMHNJCNJJF OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE, T13 FJOAEBMLFMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x3AF5260", Offset = "0x3AF3860", VA = "0x183AF5260")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ICGECMHFHGO OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE, T13 FJOAEBMLFMA, T14 AECGFNNIGJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x7D5B190", Offset = "0x7D59790", VA = "0x187D5B190", Slot = "121")]
		public void RpcMaster(LNIEFAPAFBD.MGNJCNCKKGJ<OHMCHEMAHNO> OAKFMPLKGOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x3B014B0", Offset = "0x3AFFAB0", VA = "0x183B014B0", Slot = "122")]
		public void RpcMaster<T1>(LNIEFAPAFBD.PDLNFFIGAKK<T1, OHMCHEMAHNO> OAKFMPLKGOM, T1 DNCLAIANHEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x3B00510", Offset = "0x3AFEB10", VA = "0x183B00510", Slot = "123")]
		public void RpcMaster<T1, T2>(LNIEFAPAFBD.DCKMEMCFKIO<T1, T2, OHMCHEMAHNO> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x3AFEF50", Offset = "0x3AFD550", VA = "0x183AFEF50", Slot = "124")]
		public void RpcMaster<T1, T2, T3>(LNIEFAPAFBD.BECFGHCOCBP<T1, T2, T3, OHMCHEMAHNO> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x3AFE720", Offset = "0x3AFCD20", VA = "0x183AFE720", Slot = "125")]
		public void RpcMaster<T1, T2, T3, T4>(LNIEFAPAFBD.AGMELPKKIEG<T1, T2, T3, T4, OHMCHEMAHNO> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x3AFE140", Offset = "0x3AFC740", VA = "0x183AFE140", Slot = "126")]
		public void RpcMaster<T1, T2, T3, T4, T5>(LNIEFAPAFBD.CFJDOKPAGBO<T1, T2, T3, T4, T5, OHMCHEMAHNO> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x3AFD750", Offset = "0x3AFBD50", VA = "0x183AFD750", Slot = "127")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(LNIEFAPAFBD.HEKGAFAKBLP<T1, T2, T3, T4, T5, T6, OHMCHEMAHNO> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x3AFC830", Offset = "0x3AFAE30", VA = "0x183AFC830", Slot = "128")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(LNIEFAPAFBD.MIMBKBFLAMO<T1, T2, T3, T4, T5, T6, T7, OHMCHEMAHNO> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x3AFBB90", Offset = "0x3AFA190", VA = "0x183AFBB90", Slot = "129")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(LNIEFAPAFBD.NLHAOCFHJGB<T1, T2, T3, T4, T5, T6, T7, T8, OHMCHEMAHNO> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x3AFB2A0", Offset = "0x3AF98A0", VA = "0x183AFB2A0", Slot = "130")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(EHKEABCBCIL OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x3AF9F60", Offset = "0x3AF8560", VA = "0x183AF9F60", Slot = "131")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(KFLKPPDEHDB OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x3AF94B0", Offset = "0x3AF7AB0", VA = "0x183AF94B0", Slot = "132")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(CKOBGIOLMKJ OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x3AF8420", Offset = "0x3AF6A20", VA = "0x183AF8420", Slot = "133")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(MKBCOIOOOMJ OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x3AF6C70", Offset = "0x3AF5270", VA = "0x183AF6C70", Slot = "134")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OOMHNJCNJJF OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE, T13 FJOAEBMLFMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x3AF5F70", Offset = "0x3AF4570", VA = "0x183AF5F70", Slot = "135")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ICGECMHFHGO OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE, T13 FJOAEBMLFMA, T14 AECGFNNIGJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x7D5AFE0", Offset = "0x7D595E0", VA = "0x187D5AFE0", Slot = "136")]
		public void RpcAuthority(LNIEFAPAFBD.HLHNOLMDHLA OAKFMPLKGOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x3ADE060", Offset = "0x3ADC660", VA = "0x183ADE060", Slot = "137")]
		public void RpcAuthority<T1>(LNIEFAPAFBD.MGNJCNCKKGJ<T1> OAKFMPLKGOM, T1 DNCLAIANHEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x3ADF0D0", Offset = "0x3ADD6D0", VA = "0x183ADF0D0", Slot = "138")]
		public void RpcAuthority<T1, T2>(LNIEFAPAFBD.PDLNFFIGAKK<T1, T2> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x3ADF530", Offset = "0x3ADDB30", VA = "0x183ADF530", Slot = "139")]
		public void RpcAuthority<T1, T2, T3>(LNIEFAPAFBD.DCKMEMCFKIO<T1, T2, T3> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x3ADED80", Offset = "0x3ADD380", VA = "0x183ADED80", Slot = "140")]
		public void RpcAuthority<T1, T2, T3, T4>(LNIEFAPAFBD.BECFGHCOCBP<T1, T2, T3, T4> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x3ADD520", Offset = "0x3ADBB20", VA = "0x183ADD520", Slot = "141")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(LNIEFAPAFBD.AGMELPKKIEG<T1, T2, T3, T4, T5> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x3AE7D90", Offset = "0x3AE6390", VA = "0x183AE7D90", Slot = "142")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(LNIEFAPAFBD.CFJDOKPAGBO<T1, T2, T3, T4, T5, T6> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x3AE75A0", Offset = "0x3AE5BA0", VA = "0x183AE75A0", Slot = "143")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(LNIEFAPAFBD.HEKGAFAKBLP<T1, T2, T3, T4, T5, T6, T7> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x3AE6450", Offset = "0x3AE4A50", VA = "0x183AE6450", Slot = "144")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(LNIEFAPAFBD.MIMBKBFLAMO<T1, T2, T3, T4, T5, T6, T7, T8> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x3AE5600", Offset = "0x3AE3C00", VA = "0x183AE5600", Slot = "145")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(LNIEFAPAFBD.NLHAOCFHJGB<T1, T2, T3, T4, T5, T6, T7, T8, T9> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x3AE4690", Offset = "0x3AE2C90", VA = "0x183AE4690", Slot = "146")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(EHKEABCBCIL OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x3AE3BC0", Offset = "0x3AE21C0", VA = "0x183AE3BC0", Slot = "147")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(KFLKPPDEHDB OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x3ADD940", Offset = "0x3ADBF40", VA = "0x183ADD940", Slot = "148")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(CKOBGIOLMKJ OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x3AE11C0", Offset = "0x3ADF7C0", VA = "0x183AE11C0", Slot = "149")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(MKBCOIOOOMJ OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE, T13 FJOAEBMLFMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x3AE0B50", Offset = "0x3ADF150", VA = "0x183AE0B50", Slot = "150")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OOMHNJCNJJF OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE, T13 FJOAEBMLFMA, T14 AECGFNNIGJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x7D5AB80", Offset = "0x7D59180", VA = "0x187D5AB80")]
		public void RpcAuthority(LNIEFAPAFBD.MGNJCNCKKGJ<ADKOONPNFKJ> OAKFMPLKGOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x3AEBA00", Offset = "0x3AEA000", VA = "0x183AEBA00")]
		public void RpcAuthority<T1>(LNIEFAPAFBD.PDLNFFIGAKK<T1, ADKOONPNFKJ> OAKFMPLKGOM, T1 DNCLAIANHEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x3AEA750", Offset = "0x3AE8D50", VA = "0x183AEA750")]
		public void RpcAuthority<T1, T2>(LNIEFAPAFBD.DCKMEMCFKIO<T1, T2, ADKOONPNFKJ> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x3AEA030", Offset = "0x3AE8630", VA = "0x183AEA030")]
		public void RpcAuthority<T1, T2, T3>(LNIEFAPAFBD.BECFGHCOCBP<T1, T2, T3, ADKOONPNFKJ> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x3AE9830", Offset = "0x3AE7E30", VA = "0x183AE9830")]
		public void RpcAuthority<T1, T2, T3, T4>(LNIEFAPAFBD.AGMELPKKIEG<T1, T2, T3, T4, ADKOONPNFKJ> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x3AE8880", Offset = "0x3AE6E80", VA = "0x183AE8880")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(LNIEFAPAFBD.CFJDOKPAGBO<T1, T2, T3, T4, T5, ADKOONPNFKJ> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x3AE8100", Offset = "0x3AE6700", VA = "0x183AE8100")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(LNIEFAPAFBD.HEKGAFAKBLP<T1, T2, T3, T4, T5, T6, ADKOONPNFKJ> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x3AE7970", Offset = "0x3AE5F70", VA = "0x183AE7970")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(LNIEFAPAFBD.MIMBKBFLAMO<T1, T2, T3, T4, T5, T6, T7, ADKOONPNFKJ> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x3AE6880", Offset = "0x3AE4E80", VA = "0x183AE6880")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(LNIEFAPAFBD.NLHAOCFHJGB<T1, T2, T3, T4, T5, T6, T7, T8, ADKOONPNFKJ> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x3AE5F70", Offset = "0x3AE4570", VA = "0x183AE5F70")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(EHKEABCBCIL OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x3AE4B80", Offset = "0x3AE3180", VA = "0x183AE4B80")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(KFLKPPDEHDB OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x3AE3630", Offset = "0x3AE1C30", VA = "0x183AE3630")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(CKOBGIOLMKJ OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x3AE2A30", Offset = "0x3AE1030", VA = "0x183AE2A30")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(MKBCOIOOOMJ OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x3AE17D0", Offset = "0x3ADFDD0", VA = "0x183AE17D0")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OOMHNJCNJJF OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE, T13 FJOAEBMLFMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x3ADFDD0", Offset = "0x3ADE3D0", VA = "0x183ADFDD0")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ICGECMHFHGO OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE, T13 FJOAEBMLFMA, T14 AECGFNNIGJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x7D5AD80", Offset = "0x7D59380", VA = "0x187D5AD80", Slot = "151")]
		public void RpcAuthority(LNIEFAPAFBD.MGNJCNCKKGJ<OHMCHEMAHNO> OAKFMPLKGOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x3AEB820", Offset = "0x3AE9E20", VA = "0x183AEB820", Slot = "152")]
		public void RpcAuthority<T1>(LNIEFAPAFBD.PDLNFFIGAKK<T1, OHMCHEMAHNO> OAKFMPLKGOM, T1 DNCLAIANHEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x3AEA990", Offset = "0x3AE8F90", VA = "0x183AEA990", Slot = "153")]
		public void RpcAuthority<T1, T2>(LNIEFAPAFBD.DCKMEMCFKIO<T1, T2, OHMCHEMAHNO> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x3AE9B40", Offset = "0x3AE8140", VA = "0x183AE9B40", Slot = "154")]
		public void RpcAuthority<T1, T2, T3>(LNIEFAPAFBD.BECFGHCOCBP<T1, T2, T3, OHMCHEMAHNO> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x3AE9270", Offset = "0x3AE7870", VA = "0x183AE9270", Slot = "155")]
		public void RpcAuthority<T1, T2, T3, T4>(LNIEFAPAFBD.AGMELPKKIEG<T1, T2, T3, T4, OHMCHEMAHNO> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x3AE8BF0", Offset = "0x3AE71F0", VA = "0x183AE8BF0", Slot = "156")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(LNIEFAPAFBD.CFJDOKPAGBO<T1, T2, T3, T4, T5, OHMCHEMAHNO> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x3AE84C0", Offset = "0x3AE6AC0", VA = "0x183AE84C0", Slot = "157")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(LNIEFAPAFBD.HEKGAFAKBLP<T1, T2, T3, T4, T5, T6, OHMCHEMAHNO> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x3AE7180", Offset = "0x3AE5780", VA = "0x183AE7180", Slot = "158")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(LNIEFAPAFBD.MIMBKBFLAMO<T1, T2, T3, T4, T5, T6, T7, OHMCHEMAHNO> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x3AE6D00", Offset = "0x3AE5300", VA = "0x183AE6D00", Slot = "159")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(LNIEFAPAFBD.NLHAOCFHJGB<T1, T2, T3, T4, T5, T6, T7, T8, OHMCHEMAHNO> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x3AE5A90", Offset = "0x3AE4090", VA = "0x183AE5A90", Slot = "160")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(EHKEABCBCIL OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x3AE50C0", Offset = "0x3AE36C0", VA = "0x183AE50C0", Slot = "161")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(KFLKPPDEHDB OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x3AE4100", Offset = "0x3AE2700", VA = "0x183AE4100", Slot = "162")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(CKOBGIOLMKJ OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x3AE3030", Offset = "0x3AE1630", VA = "0x183AE3030", Slot = "163")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(MKBCOIOOOMJ OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x3AE1E30", Offset = "0x3AE0430", VA = "0x183AE1E30", Slot = "164")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OOMHNJCNJJF OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE, T13 FJOAEBMLFMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x3AE0490", Offset = "0x3ADEA90", VA = "0x183AE0490", Slot = "165")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ICGECMHFHGO OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE, T13 FJOAEBMLFMA, T14 AECGFNNIGJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x7D5C250", Offset = "0x7D5A850", VA = "0x187D5C250", Slot = "14")]
		public void RpcPlayer(AIPAHMNCJKP EKEPPODJHCN, LNIEFAPAFBD.HLHNOLMDHLA OAKFMPLKGOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x3B15590", Offset = "0x3B13B90", VA = "0x183B15590", Slot = "15")]
		public void RpcPlayer<T1>(AIPAHMNCJKP EKEPPODJHCN, LNIEFAPAFBD.MGNJCNCKKGJ<T1> OAKFMPLKGOM, T1 DNCLAIANHEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x3B16330", Offset = "0x3B14930", VA = "0x183B16330", Slot = "16")]
		public void RpcPlayer<T1, T2>(AIPAHMNCJKP EKEPPODJHCN, LNIEFAPAFBD.PDLNFFIGAKK<T1, T2> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x3B15D40", Offset = "0x3B14340", VA = "0x183B15D40", Slot = "17")]
		public void RpcPlayer<T1, T2, T3>(AIPAHMNCJKP EKEPPODJHCN, LNIEFAPAFBD.DCKMEMCFKIO<T1, T2, T3> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x3B15760", Offset = "0x3B13D60", VA = "0x183B15760", Slot = "18")]
		public void RpcPlayer<T1, T2, T3, T4>(AIPAHMNCJKP EKEPPODJHCN, LNIEFAPAFBD.BECFGHCOCBP<T1, T2, T3, T4> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x3B1A0F0", Offset = "0x3B186F0", VA = "0x183B1A0F0", Slot = "166")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(AIPAHMNCJKP EKEPPODJHCN, LNIEFAPAFBD.AGMELPKKIEG<T1, T2, T3, T4, T5> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x3B19C80", Offset = "0x3B18280", VA = "0x183B19C80", Slot = "167")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(AIPAHMNCJKP EKEPPODJHCN, LNIEFAPAFBD.CFJDOKPAGBO<T1, T2, T3, T4, T5, T6> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x3B1A4E0", Offset = "0x3B18AE0", VA = "0x183B1A4E0", Slot = "168")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(AIPAHMNCJKP EKEPPODJHCN, LNIEFAPAFBD.HEKGAFAKBLP<T1, T2, T3, T4, T5, T6, T7> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x3B1A9B0", Offset = "0x3B18FB0", VA = "0x183B1A9B0", Slot = "169")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(AIPAHMNCJKP EKEPPODJHCN, LNIEFAPAFBD.MIMBKBFLAMO<T1, T2, T3, T4, T5, T6, T7, T8> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x3B22B70", Offset = "0x3B21170", VA = "0x183B22B70", Slot = "170")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(AIPAHMNCJKP EKEPPODJHCN, LNIEFAPAFBD.NLHAOCFHJGB<T1, T2, T3, T4, T5, T6, T7, T8, T9> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x3B22670", Offset = "0x3B20C70", VA = "0x183B22670", Slot = "171")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(AIPAHMNCJKP EKEPPODJHCN, EHKEABCBCIL OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x3B16C20", Offset = "0x3B15220", VA = "0x183B16C20", Slot = "19")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(AIPAHMNCJKP EKEPPODJHCN, KFLKPPDEHDB OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x3B20570", Offset = "0x3B1EB70", VA = "0x183B20570", Slot = "172")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(AIPAHMNCJKP EKEPPODJHCN, CKOBGIOLMKJ OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x3B1F330", Offset = "0x3B1D930", VA = "0x183B1F330", Slot = "173")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(AIPAHMNCJKP EKEPPODJHCN, MKBCOIOOOMJ OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE, T13 FJOAEBMLFMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x3B1D900", Offset = "0x3B1BF00", VA = "0x183B1D900", Slot = "174")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(AIPAHMNCJKP EKEPPODJHCN, OOMHNJCNJJF OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE, T13 FJOAEBMLFMA, T14 AECGFNNIGJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x7D5BFE0", Offset = "0x7D5A5E0", VA = "0x187D5BFE0")]
		public void RpcPlayer(AIPAHMNCJKP EKEPPODJHCN, LNIEFAPAFBD.MGNJCNCKKGJ<ADKOONPNFKJ> OAKFMPLKGOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x3B15B10", Offset = "0x3B14110", VA = "0x183B15B10")]
		public void RpcPlayer<T1>(AIPAHMNCJKP EKEPPODJHCN, LNIEFAPAFBD.PDLNFFIGAKK<T1, ADKOONPNFKJ> OAKFMPLKGOM, T1 DNCLAIANHEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x3B1C710", Offset = "0x3B1AD10", VA = "0x183B1C710")]
		public void RpcPlayer<T1, T2>(AIPAHMNCJKP EKEPPODJHCN, LNIEFAPAFBD.DCKMEMCFKIO<T1, T2, ADKOONPNFKJ> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x3B27450", Offset = "0x3B25A50", VA = "0x183B27450")]
		public void RpcPlayer<T1, T2, T3>(AIPAHMNCJKP EKEPPODJHCN, LNIEFAPAFBD.BECFGHCOCBP<T1, T2, T3, ADKOONPNFKJ> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x3B26E80", Offset = "0x3B25480", VA = "0x183B26E80")]
		public void RpcPlayer<T1, T2, T3, T4>(AIPAHMNCJKP EKEPPODJHCN, LNIEFAPAFBD.AGMELPKKIEG<T1, T2, T3, T4, ADKOONPNFKJ> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x3B261B0", Offset = "0x3B247B0", VA = "0x183B261B0")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(AIPAHMNCJKP EKEPPODJHCN, LNIEFAPAFBD.CFJDOKPAGBO<T1, T2, T3, T4, T5, ADKOONPNFKJ> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x3B25AC0", Offset = "0x3B240C0", VA = "0x183B25AC0")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(AIPAHMNCJKP EKEPPODJHCN, LNIEFAPAFBD.HEKGAFAKBLP<T1, T2, T3, T4, T5, T6, ADKOONPNFKJ> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x3B24B10", Offset = "0x3B23110", VA = "0x183B24B10")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(AIPAHMNCJKP EKEPPODJHCN, LNIEFAPAFBD.MIMBKBFLAMO<T1, T2, T3, T4, T5, T6, T7, ADKOONPNFKJ> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x3B239F0", Offset = "0x3B21FF0", VA = "0x183B239F0")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(AIPAHMNCJKP EKEPPODJHCN, LNIEFAPAFBD.NLHAOCFHJGB<T1, T2, T3, T4, T5, T6, T7, T8, ADKOONPNFKJ> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x3B23500", Offset = "0x3B21B00", VA = "0x183B23500")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(AIPAHMNCJKP EKEPPODJHCN, EHKEABCBCIL OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x3B22120", Offset = "0x3B20720", VA = "0x183B22120")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(AIPAHMNCJKP EKEPPODJHCN, KFLKPPDEHDB OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x3B210D0", Offset = "0x3B1F6D0", VA = "0x183B210D0")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(AIPAHMNCJKP EKEPPODJHCN, CKOBGIOLMKJ OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x3B1FF60", Offset = "0x3B1E560", VA = "0x183B1FF60")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(AIPAHMNCJKP EKEPPODJHCN, MKBCOIOOOMJ OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x3B1E650", Offset = "0x3B1CC50", VA = "0x183B1E650")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(AIPAHMNCJKP EKEPPODJHCN, OOMHNJCNJJF OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE, T13 FJOAEBMLFMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x3B1D230", Offset = "0x3B1B830", VA = "0x183B1D230")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(AIPAHMNCJKP EKEPPODJHCN, ICGECMHFHGO OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE, T13 FJOAEBMLFMA, T14 AECGFNNIGJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x7D5BD10", Offset = "0x7D5A310", VA = "0x187D5BD10", Slot = "175")]
		public void RpcPlayer(AIPAHMNCJKP EKEPPODJHCN, LNIEFAPAFBD.MGNJCNCKKGJ<OHMCHEMAHNO> OAKFMPLKGOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x3B18830", Offset = "0x3B16E30", VA = "0x183B18830", Slot = "176")]
		public void RpcPlayer<T1>(AIPAHMNCJKP EKEPPODJHCN, LNIEFAPAFBD.PDLNFFIGAKK<T1, OHMCHEMAHNO> OAKFMPLKGOM, T1 DNCLAIANHEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x3B16930", Offset = "0x3B14F30", VA = "0x183B16930", Slot = "20")]
		public void RpcPlayer<T1, T2>(AIPAHMNCJKP EKEPPODJHCN, LNIEFAPAFBD.DCKMEMCFKIO<T1, T2, OHMCHEMAHNO> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x3B165B0", Offset = "0x3B14BB0", VA = "0x183B165B0", Slot = "21")]
		public void RpcPlayer<T1, T2, T3>(AIPAHMNCJKP EKEPPODJHCN, LNIEFAPAFBD.BECFGHCOCBP<T1, T2, T3, OHMCHEMAHNO> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x3B18460", Offset = "0x3B16A60", VA = "0x183B18460", Slot = "177")]
		public void RpcPlayer<T1, T2, T3, T4>(AIPAHMNCJKP EKEPPODJHCN, LNIEFAPAFBD.AGMELPKKIEG<T1, T2, T3, T4, OHMCHEMAHNO> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x3B26530", Offset = "0x3B24B30", VA = "0x183B26530", Slot = "178")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(AIPAHMNCJKP EKEPPODJHCN, LNIEFAPAFBD.CFJDOKPAGBO<T1, T2, T3, T4, T5, OHMCHEMAHNO> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x3B256E0", Offset = "0x3B23CE0", VA = "0x183B256E0", Slot = "179")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(AIPAHMNCJKP EKEPPODJHCN, LNIEFAPAFBD.HEKGAFAKBLP<T1, T2, T3, T4, T5, T6, OHMCHEMAHNO> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x3B24F40", Offset = "0x3B23540", VA = "0x183B24F40", Slot = "180")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(AIPAHMNCJKP EKEPPODJHCN, LNIEFAPAFBD.MIMBKBFLAMO<T1, T2, T3, T4, T5, T6, T7, OHMCHEMAHNO> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x3B23E80", Offset = "0x3B22480", VA = "0x183B23E80", Slot = "181")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(AIPAHMNCJKP EKEPPODJHCN, LNIEFAPAFBD.NLHAOCFHJGB<T1, T2, T3, T4, T5, T6, T7, T8, OHMCHEMAHNO> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x3B23010", Offset = "0x3B21610", VA = "0x183B23010", Slot = "182")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(AIPAHMNCJKP EKEPPODJHCN, EHKEABCBCIL OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x3B21BD0", Offset = "0x3B201D0", VA = "0x183B21BD0", Slot = "183")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(AIPAHMNCJKP EKEPPODJHCN, KFLKPPDEHDB OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x3B20B20", Offset = "0x3B1F120", VA = "0x183B20B20", Slot = "184")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(AIPAHMNCJKP EKEPPODJHCN, CKOBGIOLMKJ OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x3B1F950", Offset = "0x3B1DF50", VA = "0x183B1F950", Slot = "185")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(AIPAHMNCJKP EKEPPODJHCN, MKBCOIOOOMJ OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x3B1ECC0", Offset = "0x3B1D2C0", VA = "0x183B1ECC0", Slot = "186")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(AIPAHMNCJKP EKEPPODJHCN, OOMHNJCNJJF OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE, T13 FJOAEBMLFMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x3B1DF80", Offset = "0x3B1C580", VA = "0x183B1DF80", Slot = "187")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(AIPAHMNCJKP EKEPPODJHCN, ICGECMHFHGO OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE, T13 FJOAEBMLFMA, T14 AECGFNNIGJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x7D5A0B0", Offset = "0x7D586B0", VA = "0x187D5A0B0", Slot = "188")]
		public void RpcAllBuffered(EMNJAEJFHEA LKKOOEFOJEP, LNIEFAPAFBD.HLHNOLMDHLA OAKFMPLKGOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x3AB5550", Offset = "0x3AB3B50", VA = "0x183AB5550", Slot = "189")]
		public void RpcAllBuffered<T1>(EMNJAEJFHEA LKKOOEFOJEP, LNIEFAPAFBD.MGNJCNCKKGJ<T1> OAKFMPLKGOM, T1 DNCLAIANHEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x3AB5100", Offset = "0x3AB3700", VA = "0x183AB5100", Slot = "190")]
		public void RpcAllBuffered<T1, T2>(EMNJAEJFHEA LKKOOEFOJEP, LNIEFAPAFBD.PDLNFFIGAKK<T1, T2> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x3AB4D80", Offset = "0x3AB3380", VA = "0x183AB4D80", Slot = "191")]
		public void RpcAllBuffered<T1, T2, T3>(EMNJAEJFHEA LKKOOEFOJEP, LNIEFAPAFBD.DCKMEMCFKIO<T1, T2, T3> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x3AB49B0", Offset = "0x3AB2FB0", VA = "0x183AB49B0", Slot = "192")]
		public void RpcAllBuffered<T1, T2, T3, T4>(EMNJAEJFHEA LKKOOEFOJEP, LNIEFAPAFBD.BECFGHCOCBP<T1, T2, T3, T4> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x3AB3EA0", Offset = "0x3AB24A0", VA = "0x183AB3EA0", Slot = "193")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(EMNJAEJFHEA LKKOOEFOJEP, LNIEFAPAFBD.AGMELPKKIEG<T1, T2, T3, T4, T5> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x3AB3C00", Offset = "0x3AB2200", VA = "0x183AB3C00", Slot = "194")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(EMNJAEJFHEA LKKOOEFOJEP, LNIEFAPAFBD.CFJDOKPAGBO<T1, T2, T3, T4, T5, T6> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x3AB33D0", Offset = "0x3AB19D0", VA = "0x183AB33D0", Slot = "195")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(EMNJAEJFHEA LKKOOEFOJEP, LNIEFAPAFBD.HEKGAFAKBLP<T1, T2, T3, T4, T5, T6, T7> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x3AB2AB0", Offset = "0x3AB10B0", VA = "0x183AB2AB0", Slot = "196")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(EMNJAEJFHEA LKKOOEFOJEP, LNIEFAPAFBD.MIMBKBFLAMO<T1, T2, T3, T4, T5, T6, T7, T8> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x3AD4DE0", Offset = "0x3AD33E0", VA = "0x183AD4DE0", Slot = "197")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(EMNJAEJFHEA LKKOOEFOJEP, LNIEFAPAFBD.NLHAOCFHJGB<T1, T2, T3, T4, T5, T6, T7, T8, T9> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x3AD4240", Offset = "0x3AD2840", VA = "0x183AD4240", Slot = "198")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(EMNJAEJFHEA LKKOOEFOJEP, EHKEABCBCIL OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x3AD3E10", Offset = "0x3AD2410", VA = "0x183AD3E10", Slot = "199")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(EMNJAEJFHEA LKKOOEFOJEP, KFLKPPDEHDB OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x3AD3130", Offset = "0x3AD1730", VA = "0x183AD3130", Slot = "200")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(EMNJAEJFHEA LKKOOEFOJEP, CKOBGIOLMKJ OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x3AD1E90", Offset = "0x3AD0490", VA = "0x183AD1E90", Slot = "201")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(EMNJAEJFHEA LKKOOEFOJEP, MKBCOIOOOMJ OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE, T13 FJOAEBMLFMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x3AD0F80", Offset = "0x3ACF580", VA = "0x183AD0F80", Slot = "202")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(EMNJAEJFHEA LKKOOEFOJEP, OOMHNJCNJJF OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE, T13 FJOAEBMLFMA, T14 AECGFNNIGJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x7D5A1F0", Offset = "0x7D587F0", VA = "0x187D5A1F0")]
		public void RpcAllBuffered(EMNJAEJFHEA LKKOOEFOJEP, LNIEFAPAFBD.MGNJCNCKKGJ<ADKOONPNFKJ> OAKFMPLKGOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x3AB5670", Offset = "0x3AB3C70", VA = "0x183AB5670")]
		public void RpcAllBuffered<T1>(EMNJAEJFHEA LKKOOEFOJEP, LNIEFAPAFBD.PDLNFFIGAKK<T1, ADKOONPNFKJ> OAKFMPLKGOM, T1 DNCLAIANHEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x3AB5270", Offset = "0x3AB3870", VA = "0x183AB5270")]
		public void RpcAllBuffered<T1, T2>(EMNJAEJFHEA LKKOOEFOJEP, LNIEFAPAFBD.DCKMEMCFKIO<T1, T2, ADKOONPNFKJ> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x3AB4F40", Offset = "0x3AB3540", VA = "0x183AB4F40")]
		public void RpcAllBuffered<T1, T2, T3>(EMNJAEJFHEA LKKOOEFOJEP, LNIEFAPAFBD.BECFGHCOCBP<T1, T2, T3, ADKOONPNFKJ> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x3AB4590", Offset = "0x3AB2B90", VA = "0x183AB4590")]
		public void RpcAllBuffered<T1, T2, T3, T4>(EMNJAEJFHEA LKKOOEFOJEP, LNIEFAPAFBD.AGMELPKKIEG<T1, T2, T3, T4, ADKOONPNFKJ> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x3AB40F0", Offset = "0x3AB26F0", VA = "0x183AB40F0")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(EMNJAEJFHEA LKKOOEFOJEP, LNIEFAPAFBD.CFJDOKPAGBO<T1, T2, T3, T4, T5, ADKOONPNFKJ> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x3AB36C0", Offset = "0x3AB1CC0", VA = "0x183AB36C0")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(EMNJAEJFHEA LKKOOEFOJEP, LNIEFAPAFBD.HEKGAFAKBLP<T1, T2, T3, T4, T5, T6, ADKOONPNFKJ> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x3AB30E0", Offset = "0x3AB16E0", VA = "0x183AB30E0")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(EMNJAEJFHEA LKKOOEFOJEP, LNIEFAPAFBD.MIMBKBFLAMO<T1, T2, T3, T4, T5, T6, T7, ADKOONPNFKJ> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x3AB2770", Offset = "0x3AB0D70", VA = "0x183AB2770")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(EMNJAEJFHEA LKKOOEFOJEP, LNIEFAPAFBD.NLHAOCFHJGB<T1, T2, T3, T4, T5, T6, T7, T8, ADKOONPNFKJ> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x3AB20A0", Offset = "0x3AB06A0", VA = "0x183AB20A0")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(EMNJAEJFHEA LKKOOEFOJEP, EHKEABCBCIL OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x3AD4A00", Offset = "0x3AD3000", VA = "0x183AD4A00")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(EMNJAEJFHEA LKKOOEFOJEP, KFLKPPDEHDB OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x3AD39E0", Offset = "0x3AD1FE0", VA = "0x183AD39E0")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(EMNJAEJFHEA LKKOOEFOJEP, CKOBGIOLMKJ OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x3AD2CB0", Offset = "0x3AD12B0", VA = "0x183AD2CB0")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(EMNJAEJFHEA LKKOOEFOJEP, MKBCOIOOOMJ OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x3AD2360", Offset = "0x3AD0960", VA = "0x183AD2360")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(EMNJAEJFHEA LKKOOEFOJEP, OOMHNJCNJJF OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE, T13 FJOAEBMLFMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x3AD0A60", Offset = "0x3ACF060", VA = "0x183AD0A60")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(EMNJAEJFHEA LKKOOEFOJEP, ICGECMHFHGO OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE, T13 FJOAEBMLFMA, T14 AECGFNNIGJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x7D5A150", Offset = "0x7D58750", VA = "0x187D5A150", Slot = "203")]
		public void RpcAllBuffered(EMNJAEJFHEA LKKOOEFOJEP, LNIEFAPAFBD.MGNJCNCKKGJ<OHMCHEMAHNO> OAKFMPLKGOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x3AB5790", Offset = "0x3AB3D90", VA = "0x183AB5790", Slot = "204")]
		public void RpcAllBuffered<T1>(EMNJAEJFHEA LKKOOEFOJEP, LNIEFAPAFBD.PDLNFFIGAKK<T1, OHMCHEMAHNO> OAKFMPLKGOM, T1 DNCLAIANHEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x3AB53E0", Offset = "0x3AB39E0", VA = "0x183AB53E0", Slot = "205")]
		public void RpcAllBuffered<T1, T2>(EMNJAEJFHEA LKKOOEFOJEP, LNIEFAPAFBD.DCKMEMCFKIO<T1, T2, OHMCHEMAHNO> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x3AB4BC0", Offset = "0x3AB31C0", VA = "0x183AB4BC0", Slot = "206")]
		public void RpcAllBuffered<T1, T2, T3>(EMNJAEJFHEA LKKOOEFOJEP, LNIEFAPAFBD.BECFGHCOCBP<T1, T2, T3, OHMCHEMAHNO> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x3AB47A0", Offset = "0x3AB2DA0", VA = "0x183AB47A0", Slot = "207")]
		public void RpcAllBuffered<T1, T2, T3, T4>(EMNJAEJFHEA LKKOOEFOJEP, LNIEFAPAFBD.AGMELPKKIEG<T1, T2, T3, T4, OHMCHEMAHNO> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x3AB4340", Offset = "0x3AB2940", VA = "0x183AB4340", Slot = "208")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(EMNJAEJFHEA LKKOOEFOJEP, LNIEFAPAFBD.CFJDOKPAGBO<T1, T2, T3, T4, T5, OHMCHEMAHNO> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x3AB3960", Offset = "0x3AB1F60", VA = "0x183AB3960", Slot = "209")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(EMNJAEJFHEA LKKOOEFOJEP, LNIEFAPAFBD.HEKGAFAKBLP<T1, T2, T3, T4, T5, T6, OHMCHEMAHNO> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x3AB2DF0", Offset = "0x3AB13F0", VA = "0x183AB2DF0", Slot = "210")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(EMNJAEJFHEA LKKOOEFOJEP, LNIEFAPAFBD.MIMBKBFLAMO<T1, T2, T3, T4, T5, T6, T7, OHMCHEMAHNO> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x3AB2430", Offset = "0x3AB0A30", VA = "0x183AB2430", Slot = "211")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(EMNJAEJFHEA LKKOOEFOJEP, LNIEFAPAFBD.NLHAOCFHJGB<T1, T2, T3, T4, T5, T6, T7, T8, OHMCHEMAHNO> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x3AB1D10", Offset = "0x3AB0310", VA = "0x183AB1D10", Slot = "212")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(EMNJAEJFHEA LKKOOEFOJEP, EHKEABCBCIL OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x3AD4620", Offset = "0x3AD2C20", VA = "0x183AD4620", Slot = "213")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(EMNJAEJFHEA LKKOOEFOJEP, KFLKPPDEHDB OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x3AD35B0", Offset = "0x3AD1BB0", VA = "0x183AD35B0", Slot = "214")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(EMNJAEJFHEA LKKOOEFOJEP, CKOBGIOLMKJ OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x3AD2830", Offset = "0x3AD0E30", VA = "0x183AD2830", Slot = "215")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(EMNJAEJFHEA LKKOOEFOJEP, MKBCOIOOOMJ OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x3AD19C0", Offset = "0x3ACFFC0", VA = "0x183AD19C0", Slot = "216")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(EMNJAEJFHEA LKKOOEFOJEP, OOMHNJCNJJF OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE, T13 FJOAEBMLFMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x3AD14A0", Offset = "0x3ACFAA0", VA = "0x183AD14A0", Slot = "217")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(EMNJAEJFHEA LKKOOEFOJEP, ICGECMHFHGO OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE, T13 FJOAEBMLFMA, T14 AECGFNNIGJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x7D5B740", Offset = "0x7D59D40", VA = "0x187D5B740", Slot = "218")]
		public void RpcOthersBuffered(EMNJAEJFHEA LKKOOEFOJEP, LNIEFAPAFBD.HLHNOLMDHLA OAKFMPLKGOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x3B0F300", Offset = "0x3B0D900", VA = "0x183B0F300", Slot = "219")]
		public void RpcOthersBuffered<T1>(EMNJAEJFHEA LKKOOEFOJEP, LNIEFAPAFBD.MGNJCNCKKGJ<T1> OAKFMPLKGOM, T1 DNCLAIANHEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x3B0EC70", Offset = "0x3B0D270", VA = "0x183B0EC70", Slot = "220")]
		public void RpcOthersBuffered<T1, T2>(EMNJAEJFHEA LKKOOEFOJEP, LNIEFAPAFBD.PDLNFFIGAKK<T1, T2> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x3B0E730", Offset = "0x3B0CD30", VA = "0x183B0E730", Slot = "221")]
		public void RpcOthersBuffered<T1, T2, T3>(EMNJAEJFHEA LKKOOEFOJEP, LNIEFAPAFBD.DCKMEMCFKIO<T1, T2, T3> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x3B0E520", Offset = "0x3B0CB20", VA = "0x183B0E520", Slot = "222")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(EMNJAEJFHEA LKKOOEFOJEP, LNIEFAPAFBD.BECFGHCOCBP<T1, T2, T3, T4> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x3B0DEB0", Offset = "0x3B0C4B0", VA = "0x183B0DEB0", Slot = "223")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(EMNJAEJFHEA LKKOOEFOJEP, LNIEFAPAFBD.AGMELPKKIEG<T1, T2, T3, T4, T5> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x3B0D4D0", Offset = "0x3B0BAD0", VA = "0x183B0D4D0", Slot = "224")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(EMNJAEJFHEA LKKOOEFOJEP, LNIEFAPAFBD.CFJDOKPAGBO<T1, T2, T3, T4, T5, T6> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x3B0C960", Offset = "0x3B0AF60", VA = "0x183B0C960", Slot = "225")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(EMNJAEJFHEA LKKOOEFOJEP, LNIEFAPAFBD.HEKGAFAKBLP<T1, T2, T3, T4, T5, T6, T7> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x3B0BFA0", Offset = "0x3B0A5A0", VA = "0x183B0BFA0", Slot = "226")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(EMNJAEJFHEA LKKOOEFOJEP, LNIEFAPAFBD.MIMBKBFLAMO<T1, T2, T3, T4, T5, T6, T7, T8> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x3B0B880", Offset = "0x3B09E80", VA = "0x183B0B880", Slot = "227")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(EMNJAEJFHEA LKKOOEFOJEP, LNIEFAPAFBD.NLHAOCFHJGB<T1, T2, T3, T4, T5, T6, T7, T8, T9> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x3B0AD30", Offset = "0x3B09330", VA = "0x183B0AD30", Slot = "228")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(EMNJAEJFHEA LKKOOEFOJEP, EHKEABCBCIL OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x3B0A520", Offset = "0x3B08B20", VA = "0x183B0A520", Slot = "229")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(EMNJAEJFHEA LKKOOEFOJEP, KFLKPPDEHDB OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x3B09840", Offset = "0x3B07E40", VA = "0x183B09840", Slot = "230")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(EMNJAEJFHEA LKKOOEFOJEP, CKOBGIOLMKJ OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x3B080D0", Offset = "0x3B066D0", VA = "0x183B080D0", Slot = "231")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(EMNJAEJFHEA LKKOOEFOJEP, MKBCOIOOOMJ OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE, T13 FJOAEBMLFMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x3B07690", Offset = "0x3B05C90", VA = "0x183B07690", Slot = "232")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(EMNJAEJFHEA LKKOOEFOJEP, OOMHNJCNJJF OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE, T13 FJOAEBMLFMA, T14 AECGFNNIGJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x7D5B7E0", Offset = "0x7D59DE0", VA = "0x187D5B7E0")]
		public void RpcOthersBuffered(EMNJAEJFHEA LKKOOEFOJEP, LNIEFAPAFBD.MGNJCNCKKGJ<ADKOONPNFKJ> OAKFMPLKGOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x3B0F1E0", Offset = "0x3B0D7E0", VA = "0x183B0F1E0")]
		public void RpcOthersBuffered<T1>(EMNJAEJFHEA LKKOOEFOJEP, LNIEFAPAFBD.PDLNFFIGAKK<T1, ADKOONPNFKJ> OAKFMPLKGOM, T1 DNCLAIANHEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x3B0EF50", Offset = "0x3B0D550", VA = "0x183B0EF50")]
		public void RpcOthersBuffered<T1, T2>(EMNJAEJFHEA LKKOOEFOJEP, LNIEFAPAFBD.DCKMEMCFKIO<T1, T2, ADKOONPNFKJ> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x3B0EAB0", Offset = "0x3B0D0B0", VA = "0x183B0EAB0")]
		public void RpcOthersBuffered<T1, T2, T3>(EMNJAEJFHEA LKKOOEFOJEP, LNIEFAPAFBD.BECFGHCOCBP<T1, T2, T3, ADKOONPNFKJ> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x3B0E100", Offset = "0x3B0C700", VA = "0x183B0E100")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(EMNJAEJFHEA LKKOOEFOJEP, LNIEFAPAFBD.AGMELPKKIEG<T1, T2, T3, T4, ADKOONPNFKJ> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x3B0DA10", Offset = "0x3B0C010", VA = "0x183B0DA10")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(EMNJAEJFHEA LKKOOEFOJEP, LNIEFAPAFBD.CFJDOKPAGBO<T1, T2, T3, T4, T5, ADKOONPNFKJ> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x3B0D770", Offset = "0x3B0BD70", VA = "0x183B0D770")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(EMNJAEJFHEA LKKOOEFOJEP, LNIEFAPAFBD.HEKGAFAKBLP<T1, T2, T3, T4, T5, T6, ADKOONPNFKJ> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x3B0CC50", Offset = "0x3B0B250", VA = "0x183B0CC50")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(EMNJAEJFHEA LKKOOEFOJEP, LNIEFAPAFBD.MIMBKBFLAMO<T1, T2, T3, T4, T5, T6, T7, ADKOONPNFKJ> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x3B0C2E0", Offset = "0x3B0A8E0", VA = "0x183B0C2E0")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(EMNJAEJFHEA LKKOOEFOJEP, LNIEFAPAFBD.NLHAOCFHJGB<T1, T2, T3, T4, T5, T6, T7, T8, ADKOONPNFKJ> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x3B0B4F0", Offset = "0x3B09AF0", VA = "0x183B0B4F0")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(EMNJAEJFHEA LKKOOEFOJEP, EHKEABCBCIL OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x3B0A950", Offset = "0x3B08F50", VA = "0x183B0A950")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(EMNJAEJFHEA LKKOOEFOJEP, KFLKPPDEHDB OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x3B0A0F0", Offset = "0x3B086F0", VA = "0x183B0A0F0")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(EMNJAEJFHEA LKKOOEFOJEP, CKOBGIOLMKJ OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x3B093C0", Offset = "0x3B079C0", VA = "0x183B093C0")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(EMNJAEJFHEA LKKOOEFOJEP, MKBCOIOOOMJ OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x3B085A0", Offset = "0x3B06BA0", VA = "0x183B085A0")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(EMNJAEJFHEA LKKOOEFOJEP, OOMHNJCNJJF OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE, T13 FJOAEBMLFMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x3B07170", Offset = "0x3B05770", VA = "0x183B07170")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(EMNJAEJFHEA LKKOOEFOJEP, ICGECMHFHGO OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE, T13 FJOAEBMLFMA, T14 AECGFNNIGJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x7D5B880", Offset = "0x7D59E80", VA = "0x187D5B880", Slot = "233")]
		public void RpcOthersBuffered(EMNJAEJFHEA LKKOOEFOJEP, LNIEFAPAFBD.MGNJCNCKKGJ<OHMCHEMAHNO> OAKFMPLKGOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x3B0F0C0", Offset = "0x3B0D6C0", VA = "0x183B0F0C0", Slot = "234")]
		public void RpcOthersBuffered<T1>(EMNJAEJFHEA LKKOOEFOJEP, LNIEFAPAFBD.PDLNFFIGAKK<T1, OHMCHEMAHNO> OAKFMPLKGOM, T1 DNCLAIANHEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x3B0EDE0", Offset = "0x3B0D3E0", VA = "0x183B0EDE0", Slot = "235")]
		public void RpcOthersBuffered<T1, T2>(EMNJAEJFHEA LKKOOEFOJEP, LNIEFAPAFBD.DCKMEMCFKIO<T1, T2, OHMCHEMAHNO> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x3B0E8F0", Offset = "0x3B0CEF0", VA = "0x183B0E8F0", Slot = "236")]
		public void RpcOthersBuffered<T1, T2, T3>(EMNJAEJFHEA LKKOOEFOJEP, LNIEFAPAFBD.BECFGHCOCBP<T1, T2, T3, OHMCHEMAHNO> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x3B0E310", Offset = "0x3B0C910", VA = "0x183B0E310", Slot = "237")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(EMNJAEJFHEA LKKOOEFOJEP, LNIEFAPAFBD.AGMELPKKIEG<T1, T2, T3, T4, OHMCHEMAHNO> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x3B0DC60", Offset = "0x3B0C260", VA = "0x183B0DC60", Slot = "238")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(EMNJAEJFHEA LKKOOEFOJEP, LNIEFAPAFBD.CFJDOKPAGBO<T1, T2, T3, T4, T5, OHMCHEMAHNO> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x3B0D230", Offset = "0x3B0B830", VA = "0x183B0D230", Slot = "239")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(EMNJAEJFHEA LKKOOEFOJEP, LNIEFAPAFBD.HEKGAFAKBLP<T1, T2, T3, T4, T5, T6, OHMCHEMAHNO> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x3B0CF40", Offset = "0x3B0B540", VA = "0x183B0CF40", Slot = "240")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(EMNJAEJFHEA LKKOOEFOJEP, LNIEFAPAFBD.MIMBKBFLAMO<T1, T2, T3, T4, T5, T6, T7, OHMCHEMAHNO> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x3B0C620", Offset = "0x3B0AC20", VA = "0x183B0C620", Slot = "241")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(EMNJAEJFHEA LKKOOEFOJEP, LNIEFAPAFBD.NLHAOCFHJGB<T1, T2, T3, T4, T5, T6, T7, T8, OHMCHEMAHNO> OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x3B0BC10", Offset = "0x3B0A210", VA = "0x183B0BC10", Slot = "242")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(EMNJAEJFHEA LKKOOEFOJEP, EHKEABCBCIL OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x3B0B110", Offset = "0x3B09710", VA = "0x183B0B110", Slot = "243")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(EMNJAEJFHEA LKKOOEFOJEP, KFLKPPDEHDB OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x3B09CC0", Offset = "0x3B082C0", VA = "0x183B09CC0", Slot = "244")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(EMNJAEJFHEA LKKOOEFOJEP, CKOBGIOLMKJ OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x3B08F40", Offset = "0x3B07540", VA = "0x183B08F40", Slot = "245")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(EMNJAEJFHEA LKKOOEFOJEP, MKBCOIOOOMJ OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x3B08A70", Offset = "0x3B07070", VA = "0x183B08A70", Slot = "246")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(EMNJAEJFHEA LKKOOEFOJEP, OOMHNJCNJJF OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE, T13 FJOAEBMLFMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x3B07BB0", Offset = "0x3B061B0", VA = "0x183B07BB0", Slot = "247")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(EMNJAEJFHEA LKKOOEFOJEP, ICGECMHFHGO OAKFMPLKGOM, T1 DNCLAIANHEP, T2 OOKCENEFHIM, T3 GNBDMCHEDLJ, T4 LJFOFNBOCGH, T5 DGJDBPGJOME, T6 CHGODDGAEGC, T7 PHANKMPOCEJ, T8 EBEHGHNOHGP, T9 AMLKGJELPJJ, T10 HGLABEHIEMK, T11 KOKCAKHOHBI, T12 GJPENDMDMLE, T13 FJOAEBMLFMA, T14 AECGFNNIGJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x7D57E70", Offset = "0x7D56470", VA = "0x187D57E70", Slot = "248")]
		public void ClearBufferedRPCsIfMine()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x7D58080", Offset = "0x7D56680", VA = "0x187D58080", Slot = "249")]
		public void ClearBufferedRPCs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x1DC2370", Offset = "0x1DC0970", VA = "0x181DC2370")]
		public RRNetworkView()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class CCNFIFOAEEL
{
	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x7D41AD0", Offset = "0x7D400D0", VA = "0x187D41AD0")]
	private static bool KNJCMDJFCFJ(ViewId HJPLNJNIFLL, [Out] RRNetworkView NNAEIGBDCOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x364EAF0", Offset = "0x364D0F0", VA = "0x18364EAF0")]
	[CanBeNull]
	public static T AGKIBJBCGMP<T>(this ViewId HMGHCPIBIBG)
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
		private sealed class MKDDGNHJJKF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public AIPAHMNCJKP[] sorted;

			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public MKDDGNHJJKF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0x7D54D90", Offset = "0x7D53390", VA = "0x187D54D90")]
			internal int KNJIBFJLAGG(int index)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002D4")]
			[Cpp2IlInjected.Address(RVA = "0x7D54D00", Offset = "0x7D53300", VA = "0x187D54D00")]
			internal void IMHODPANNLD(int index, int number)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private static readonly JBBHIJHGEPM PAJIGEJCNAP;

		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public static RRPlayerNumbering instance;

		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public static AIPAHMNCJKP[] SortedPlayers;

		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public const string RoomPlayerIndexedProp = "rrPnr";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		internal int NGMJHABGDNH;

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x7D5D160", Offset = "0x7D5B760", VA = "0x187D5D160")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x7D5D750", Offset = "0x7D5BD50", VA = "0x187D5D750")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x7D5DB00", Offset = "0x7D5C100", VA = "0x187D5DB00")]
		private void OnJoinedRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x7D5DB70", Offset = "0x7D5C170", VA = "0x187D5DB70")]
		private void OnLeftRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x7D5D000", Offset = "0x7D5B600", VA = "0x187D5D000")]
		private void AAJBHAMIKAP(AIPAHMNCJKP MGDCBAKNPNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x7D5D000", Offset = "0x7D5B600", VA = "0x187D5D000")]
		private void ICOPJJOFJDO(AIPAHMNCJKP BMGPKONLJPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x7D5D670", Offset = "0x7D5BC70", VA = "0x187D5D670")]
		private void IFKLJDGNBFE(AIPAHMNCJKP HDJKAKBEEHP, IDictionary<object, object> BHNMJFDCDOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x7D5D010", Offset = "0x7D5B610", VA = "0x187D5D010")]
		public static void AssignPlayerNumbers(int LLMKJDCMPAH, int OCFOINLMODF, Func<int, int> FHGMBNEDJMC, Action<int, int> JLMAEBHGLKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x7D5DC10", Offset = "0x7D5C210", VA = "0x187D5DC10")]
		public void RefreshData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x7D5D580", Offset = "0x7D5BB80", VA = "0x187D5D580")]
		private void CJPHGEJNBGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x9FB910", Offset = "0x9F9F10", VA = "0x1809FB910")]
		public RRPlayerNumbering()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class NOBMEABBBLD
{
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x7D56220", Offset = "0x7D54820", VA = "0x187D56220")]
	public static int KJONLEBOMLJ(this AIPAHMNCJKP EKEPPODJHCN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x7D563C0", Offset = "0x7D549C0", VA = "0x187D563C0")]
	public static void PFFMNCKOLPN(this AIPAHMNCJKP EKEPPODJHCN, int MOLJEEOEBLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class GPOGMJJINLL
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public delegate void GEMNOCPEFJJ(Hashtable FBEFHOGBKOJ);

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public delegate void HIGEODKJGDJ(AIPAHMNCJKP EKEPPODJHCN, Hashtable FBEFHOGBKOJ);

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public static event GEMNOCPEFJJ MACDEFAAGKG
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x7D49340", Offset = "0x7D47940", VA = "0x187D49340")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x7D491C0", Offset = "0x7D477C0", VA = "0x187D491C0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public static event GEMNOCPEFJJ ICDEJFJJFCK
	{
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x7D49280", Offset = "0x7D47880", VA = "0x187D49280")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x7D49040", Offset = "0x7D47640", VA = "0x187D49040")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public static event HIGEODKJGDJ DBDHEGLAMJC
	{
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x7D49580", Offset = "0x7D47B80", VA = "0x187D49580")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x7D49400", Offset = "0x7D47A00", VA = "0x187D49400")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public static event HIGEODKJGDJ FOHBENAACKC
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x7D49100", Offset = "0x7D47700", VA = "0x187D49100")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x7D494C0", Offset = "0x7D47AC0", VA = "0x187D494C0")]
		[CompilerGenerated]
		remove
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal static class LHJMOCKEAHF
{
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static int JDJOECNCIKJ;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static int HMIAEOJFMDD;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static int KFELKCGGHOF;

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x7D4C1A0", Offset = "0x7D4A7A0", VA = "0x187D4C1A0")]
	public static void ABIMCJPOHDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x7D4C1F0", Offset = "0x7D4A7F0", VA = "0x187D4C1F0")]
	public static void EHJJONEAADN(int[] JOMODBIALHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x7D4C2D0", Offset = "0x7D4A8D0", VA = "0x187D4C2D0")]
	public static int PANADKMFNDK(int BDMCCGBDHPH, bool HMLEGGMLFHB = true)
	{
		return default(int);
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
