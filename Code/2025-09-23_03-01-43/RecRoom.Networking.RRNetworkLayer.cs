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
	public class LogRegistrationIndex : DHBOPDJGFAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x863A1A0", Offset = "0x86387A0", VA = "0x18863A1A0", Slot = "4")]
		public override void NCEHDCEOICJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA54B0", Offset = "0xAA3AB0", VA = "0x180AA54B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x23FEEA0", Offset = "0x23FD4A0", VA = "0x1823FEEA0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8648B80", Offset = "0x8647180", VA = "0x188648B80")]
		private void BFHOJBJGDPP(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8649300", Offset = "0x8647900", VA = "0x188649300")]
		private void KNNDHOHFANH(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8649580", Offset = "0x8647B80", VA = "0x188649580", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8649630", Offset = "0x8647C30", VA = "0x188649630")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class JEBHDFOPCMJ
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly IPHNFELODMJ DIHEIGLHFII;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IPHNFELODMJ POKNFGNFDNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x86356C0", Offset = "0x8633CC0", VA = "0x1886356C0")]
		get
		{
			return default(IPHNFELODMJ);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface NLCJHBPEBAL
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	RRNetworkView CMHJKEMAFJL
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	NHOKMCPMOJE LHDBGKKBDJM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool EEGJCLDHDOP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "2")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool Serialize(JPPAJOOKGBI GKFHOIJAPBD);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void Deserialize(FPBNHBHHGKF PCLIBIJEFPO, JPPAJOOKGBI GKFHOIJAPBD);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface PCIBGBEGNLE
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool POPMPJLKBIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BHIIIFMDOMD(FPBNHBHHGKF PCLIBIJEFPO);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LPNJIHLFELG(FPBNHBHHGKF PCLIBIJEFPO, JPPAJOOKGBI GKFHOIJAPBD);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface EPJMDIKMHDN : INetworkUpdateSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NCEHDCEOICJ(NLCJHBPEBAL MKMMDKIJOHA);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HKHOCFFLDMG(NLCJHBPEBAL MKMMDKIJOHA);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EEEOMJDOMAD(PJJOOLFIIKH.MCDJKHBMANL IELIAKJFJCK);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LAPMHDFNCAF();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LIGBOOLONEE(object CBIMJBOHKKP);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct FPBNHBHHGKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int KLCPNOJDGDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public uint HGPBLPJKMKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public double AAFMDKEKCOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public int PHBENBFDMEJ;
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class ECDJFINDAME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Dictionary<(ViewId, NHOKMCPMOJE), PCIBGBEGNLE> KGAKHKIPHHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly List<NLCJHBPEBAL> NEOHDECBOJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly HashSet<(ViewId, NHOKMCPMOJE)> HJKNEPGIILK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private int GOLCICLHKJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public bool KBFGPLLMDFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private PJJOOLFIIKH.MCDJKHBMANL IELIAKJFJCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly MemoryStream BCBKIMLAFOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly JPPAJOOKGBI LFBJIEINDOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly JPPAJOOKGBI DOPIJCAMACE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private byte[] LFHFGIINMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private float ABCKNDEMDMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int KEHEPGBHMIE;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x86296C0", Offset = "0x8627CC0", VA = "0x1886296C0")]
	public ECDJFINDAME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8628340", Offset = "0x8626940", VA = "0x188628340")]
	public void EEEOMJDOMAD(PJJOOLFIIKH.MCDJKHBMANL IELIAKJFJCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8628D70", Offset = "0x8627370", VA = "0x188628D70")]
	public void LAPMHDFNCAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8628770", Offset = "0x8626D70", VA = "0x188628770")]
	public void FPGILMIKMIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8629180", Offset = "0x8627780", VA = "0x188629180")]
	public bool MEFAAGOGBHI(NLCJHBPEBAL MKMMDKIJOHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x86281F0", Offset = "0x86267F0", VA = "0x1886281F0")]
	public bool CBELOMAGFLH(NLCJHBPEBAL MKMMDKIJOHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8628B50", Offset = "0x8627150", VA = "0x188628B50")]
	private PCIBGBEGNLE KPFIDCBCDPG(ViewId JCBIELMJFID, NHOKMCPMOJE BAFBBPPECCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x86296B0", Offset = "0x8627CB0", VA = "0x1886296B0")]
	public void NCHBNNDGNBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8628710", Offset = "0x8626D10", VA = "0x188628710")]
	private void EMMJABIGDNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8628320", Offset = "0x8626920", VA = "0x188628320")]
	private void EDLNIFDBLPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8628360", Offset = "0x8626960", VA = "0x188628360")]
	public bool EMGOPMKNAFC(FastBufferWriter CKPHLHCIFLA, int PPHLNFDEKMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8628DC0", Offset = "0x86273C0", VA = "0x188628DC0")]
	public void LPNJIHLFELG(FPBNHBHHGKF PCLIBIJEFPO, FastBufferReader KLIAOPJFDOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal class GHDHDANGEDP : PCIBGBEGNLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private NLCJHBPEBAL LEKHIBPHJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private uint HKFPLFFLMOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private int NEPMADNJGAF;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool POPMPJLKBIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0xAB22B0", Offset = "0xAB08B0", VA = "0x180AB22B0")]
	public GHDHDANGEDP(NLCJHBPEBAL LEKHIBPHJFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8629DA0", Offset = "0x86283A0", VA = "0x188629DA0", Slot = "5")]
	public bool BHIIIFMDOMD(FPBNHBHHGKF PCLIBIJEFPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8629EB0", Offset = "0x86284B0", VA = "0x188629EB0", Slot = "6")]
	public void LPNJIHLFELG(FPBNHBHHGKF PCLIBIJEFPO, JPPAJOOKGBI GKFHOIJAPBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class IAJAPKGKNBJ : PCIBGBEGNLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private PJJOOLFIIKH.MCDJKHBMANL IELIAKJFJCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly ViewId JCBIELMJFID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private int NEPMADNJGAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private uint HKFPLFFLMOD;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool POPMPJLKBIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0450", VA = "0x180AC1E50", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1CCC060", Offset = "0x1CCA660", VA = "0x181CCC060")]
	public IAJAPKGKNBJ(ViewId JCBIELMJFID, PJJOOLFIIKH.MCDJKHBMANL IELIAKJFJCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8634340", Offset = "0x8632940", VA = "0x188634340", Slot = "5")]
	public bool BHIIIFMDOMD(FPBNHBHHGKF PCLIBIJEFPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8634380", Offset = "0x8632980", VA = "0x188634380", Slot = "6")]
	public void LPNJIHLFELG(FPBNHBHHGKF PCLIBIJEFPO, JPPAJOOKGBI GKFHOIJAPBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class NMLKLMIOIBB
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x863A5C0", Offset = "0x8638BC0", VA = "0x18863A5C0")]
	public static void ANHNANMIGBP(this MDLDCBLBAPK EOECDEICEMH, JPPAJOOKGBI AJNGGLPDPIB, ViewId JIFPJFGEAIK, bool LIPDLBFMALJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x863A780", Offset = "0x8638D80", VA = "0x18863A780")]
	public static void JPHCBFLJCKM(this MDLDCBLBAPK EOECDEICEMH, JPPAJOOKGBI AJNGGLPDPIB, bool LIPDLBFMALJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x863AC80", Offset = "0x8639280", VA = "0x18863AC80")]
	public static MDLDCBLBAPK LPNJIHLFELG(JPPAJOOKGBI AJNGGLPDPIB, ViewId JIFPJFGEAIK, bool LIPDLBFMALJ = true)
	{
		return default(MDLDCBLBAPK);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x863ADF0", Offset = "0x86393F0", VA = "0x18863ADF0")]
	public static void NBAMKGJCKBA(this MDLDCBLBAPK EOECDEICEMH, JPPAJOOKGBI AJNGGLPDPIB, bool LIPDLBFMALJ = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[RegisterService(typeof(EPJMDIKMHDN), new string[] { })]
public class IOHLNCNAIFB : EPJMDIKMHDN, INetworkUpdateSystem, HDOAJHPMAEO, DCEPPCNEFDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly IPHNFELODMJ IKLIKOHCPJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private ECDJFINDAME ILDDKGBFEIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private uint KLGOAIJCCOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private float NHALKNEKEBK;

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8635440", Offset = "0x8633A40", VA = "0x188635440", Slot = "4")]
	public void NCEHDCEOICJ(NLCJHBPEBAL MKMMDKIJOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8635180", Offset = "0x8633780", VA = "0x188635180", Slot = "5")]
	public void HKHOCFFLDMG(NLCJHBPEBAL MKMMDKIJOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8634ED0", Offset = "0x86334D0", VA = "0x188634ED0", Slot = "10")]
	public void ECFEIOPKLDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8635560", Offset = "0x8633B60", VA = "0x188635560", Slot = "9")]
	public void NetworkUpdate(NetworkUpdateStage BJDFPPJLINF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8634560", Offset = "0x8632B60", VA = "0x188634560")]
	private void AJELPNEMHHE(uint ICDKFKFAMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8635030", Offset = "0x8633630", VA = "0x188635030", Slot = "6")]
	public void EEEOMJDOMAD(PJJOOLFIIKH.MCDJKHBMANL IELIAKJFJCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x8635380", Offset = "0x8633980", VA = "0x188635380", Slot = "7")]
	public void LAPMHDFNCAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x86353E0", Offset = "0x86339E0", VA = "0x1886353E0", Slot = "8")]
	public void LIGBOOLONEE(object DONNKKDINIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x8634B50", Offset = "0x8633150", VA = "0x188634B50")]
	private void DAOHPHKPIFM(NDDAOAIJPDM DONNKKDINIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x8635060", Offset = "0x8633660", VA = "0x188635060", Slot = "11")]
	public void HDAIJOIMLPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x86355E0", Offset = "0x8633BE0", VA = "0x1886355E0")]
	public IOHLNCNAIFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class KEPBDHCKPBF : PCIBGBEGNLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private float ECOHNEFNOIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private int NEPMADNJGAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private uint HKFPLFFLMOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly NHOKMCPMOJE MBMLFMAOGHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public FPBNHBHHGKF BMMNCCLPHNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public int DIKHIHLEJEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public byte[] JMOKLIGIKNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private FPBNHBHHGKF BCOJLGHHKCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int BADCEIFLEND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private byte[] OEPENNNLJIM;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool POPMPJLKBIB
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x86395A0", Offset = "0x8637BA0", VA = "0x1886395A0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x8639950", Offset = "0x8637F50", VA = "0x188639950")]
	public KEPBDHCKPBF(NHOKMCPMOJE MBMLFMAOGHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8639450", Offset = "0x8637A50", VA = "0x188639450", Slot = "5")]
	public bool BHIIIFMDOMD(FPBNHBHHGKF PCLIBIJEFPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x86395D0", Offset = "0x8637BD0", VA = "0x1886395D0", Slot = "6")]
	public void LPNJIHLFELG(FPBNHBHHGKF PCLIBIJEFPO, JPPAJOOKGBI GKFHOIJAPBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x8639490", Offset = "0x8637A90", VA = "0x188639490")]
	internal GHDHDANGEDP DKFLBHGJABH(NLCJHBPEBAL MKMMDKIJOHA, JPPAJOOKGBI AJNGGLPDPIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x8639780", Offset = "0x8637D80", VA = "0x188639780")]
	private static void PHPBKBGJHIA(GHDHDANGEDP JMMKCOBOAFB, JPPAJOOKGBI AJNGGLPDPIB, FPBNHBHHGKF HPNNBFIKOHO, byte[] DNGAEEFBGGO, int EEEHJIFCOKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[RegisterService(typeof(PGLNHHCDPKO), new string[] { })]
[ServiceLifetime(Lifetime.Application)]
public class PGLNHHCDPKO : HCKBIEPELFM, HDOAJHPMAEO, DCEPPCNEFDI
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly Hashtable CGEKGIGMODK;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly Hashtable JEBHOBBDCHG;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static readonly Hashtable ICDHMHOFEFC;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static readonly CIJKFJMOGHC BOEABHHHHEP;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly CIJKFJMOGHC BMFJGBDNNKN;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static readonly CIJKFJMOGHC BMMEDAIFANB;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static readonly CIJKFJMOGHC BEMHOCMDDMO;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static readonly CIJKFJMOGHC HBGNAKIOIGB;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static int NOBIDBKNDJG;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x863B8E0", Offset = "0x8639EE0", VA = "0x18863B8E0", Slot = "4")]
	public bool CLCHBCGBAPI(OBHLIKKGGFI ENMBHGMENHL, bool OIMEEMPLNHI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x863BFB0", Offset = "0x863A5B0", VA = "0x18863BFB0", Slot = "5")]
	public int FPGCCIOPGHJ(OBHLIKKGGFI[] GKALKDCGDJC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x863CA10", Offset = "0x863B010", VA = "0x18863CA10", Slot = "6")]
	public bool LADGNPLFONN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x863CD30", Offset = "0x863B330", VA = "0x18863CD30", Slot = "7")]
	public bool MPEKMCNJBHJ(int JCBIELMJFID, int MGKEEIKKKDN, bool BGNPJGNBDDP, GameObject JJEACKINPOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x863C820", Offset = "0x863AE20", VA = "0x18863C820", Slot = "8")]
	public void KJJGPKEKEOB(int MGKEEIKKKDN, [Optional] int? BMJHIECPJIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x863B770", Offset = "0x8639D70", VA = "0x18863B770", Slot = "9")]
	public bool ANCNGJBMCNC(NDDAOAIJPDM CBIMJBOHKKP, [Out] OBHLIKKGGFI MDNGLGKBAIP, bool ELFGFOHDJMI = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x863CFB0", Offset = "0x863B5B0", VA = "0x18863CFB0", Slot = "10")]
	public bool OFAJKCPBFMJ(NDDAOAIJPDM CBIMJBOHKKP, [Out] int HPBNEHBIONP, [Out] OBHLIKKGGFI[] GKALKDCGDJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x863D290", Offset = "0x863B890", VA = "0x18863D290", Slot = "11")]
	public bool PMIHPMHPLCP(NDDAOAIJPDM CBIMJBOHKKP, [Out] int MGKEEIKKKDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x863C640", Offset = "0x863AC40", VA = "0x18863C640", Slot = "12")]
	public void HDFBCANOJON(NDDAOAIJPDM CBIMJBOHKKP, [Out] int PCAHNNIBKBK, [Out] int[] LMECGFFCALK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x863C440", Offset = "0x863AA40", VA = "0x18863C440", Slot = "13")]
	public void HCOIPDCHCKC(int HPBNEHBIONP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x863CC10", Offset = "0x863B210", VA = "0x18863CC10", Slot = "14")]
	public void MFFBPJONGFJ(int HPBNEHBIONP, int[] LMECGFFCALK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x863BF00", Offset = "0x863A500", VA = "0x18863BF00", Slot = "15")]
	public void EOCFBMMIPIA(int[] LMECGFFCALK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x863C370", Offset = "0x863A970", VA = "0x18863C370", Slot = "16")]
	public void HCANELHLEKC(int[] LMECGFFCALK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x863CAA0", Offset = "0x863B0A0", VA = "0x18863CAA0", Slot = "17")]
	public void LNIIEMFMEPL(int HPBNEHBIONP, int MGKEEIKKKDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x863BA20", Offset = "0x863A020", VA = "0x18863BA20")]
	private static void DIBMKENNJMO(OBHLIKKGGFI ENMBHGMENHL, Hashtable IGEFCKPMPKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x863B1B0", Offset = "0x86397B0", VA = "0x18863B1B0")]
	private static bool ANCNGJBMCNC(Hashtable IGEFCKPMPKJ, MEINMPIOLGA NAKGGLJDOEN, [Out] OBHLIKKGGFI MDNGLGKBAIP, bool ELFGFOHDJMI = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x863CED0", Offset = "0x863B4D0", VA = "0x18863CED0")]
	private static int NJKABCEDHHL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x863BE60", Offset = "0x863A460", VA = "0x18863BE60", Slot = "18")]
	public void ECFEIOPKLDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x863C5A0", Offset = "0x863ABA0", VA = "0x18863C5A0", Slot = "19")]
	public void HDAIJOIMLPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public PGLNHHCDPKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[RegisterService(typeof(JOHPMNEFCIG), new string[] { })]
[ServiceLifetime(Lifetime.Application)]
public class JOHPMNEFCIG : GANEPLMJMLL, HDOAJHPMAEO, DCEPPCNEFDI
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static Hashtable ICNLILJJOOP;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static Hashtable NJBIFBOHHKH;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static CIJKFJMOGHC PEIBFJGCPAH;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static readonly CIJKFJMOGHC KGOCNLOJIEI;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private static IPHNFELODMJ AMCHCCAPJNG;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x86362A0", Offset = "0x86348A0", VA = "0x1886362A0", Slot = "4")]
	public void NADEFEMGAND(ViewId JCBIELMJFID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x8635EB0", Offset = "0x86344B0", VA = "0x188635EB0", Slot = "5")]
	public bool FPFOLHHNHIM(NDDAOAIJPDM CBIMJBOHKKP, [Out] ViewId JCBIELMJFID, [Out] string HFFKJPDLDPD, [Out] int MEIHIEPFMPH, [Out] object[] MGPPHEGFGJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x8635820", Offset = "0x8633E20", VA = "0x188635820", Slot = "6")]
	public void FGHINPDPDBM(ViewId EPNGEANGHIF, string HFFKJPDLDPD, JCJIPGJBFOG GKHJONMBNCD, MEINMPIOLGA AGIMJJDFEAF, DIAEAGCMBLG OIPFPGJBCLL, object[] ENMBHGMENHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x8636200", Offset = "0x8634800", VA = "0x188636200", Slot = "8")]
	public void HDAIJOIMLPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8635780", Offset = "0x8633D80", VA = "0x188635780", Slot = "7")]
	public void ECFEIOPKLDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public JOHPMNEFCIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class GFNBMDKAKML
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8629CC0", Offset = "0x86282C0", VA = "0x188629CC0")]
	public static MEINMPIOLGA AHIPIFLJEOL(this NOCCEEEBCMN JPKKOPNBEKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8629D50", Offset = "0x8628350", VA = "0x188629D50")]
	public static NOCCEEEBCMN GANEGIGCIGG(this MEINMPIOLGA AGIMJJDFEAF)
	{
		return default(NOCCEEEBCMN);
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class RRNetworkBehavior : MonoBehaviour, DPJMADELKMI, KELOMEIMGPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool networkedViewInitialized;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private RRNetworkView networkedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private List<OJFPEMCACLN> destroyHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private bool isForwarderRegistered;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public ViewId MDNGHJINCAI
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x8641DF0", Offset = "0x86403F0", VA = "0x188641DF0")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public ViewId HBBDDMLJOPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x8641DF0", Offset = "0x86403F0", VA = "0x188641DF0", Slot = "4")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		[Obsolete("Use NetworkedView instead")]
		public RRNetworkView DOJBOEGBBGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x8641E70", Offset = "0x8640470", VA = "0x188641E70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public RRNetworkView CMHJKEMAFJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x8641E70", Offset = "0x8640470", VA = "0x188641E70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public MEINMPIOLGA CLGINMNKMEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8641F70", Offset = "0x8640570", VA = "0x188641F70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public MEINMPIOLGA PCLFJGMAHBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x86422D0", Offset = "0x86408D0", VA = "0x1886422D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool FLHNEAKLKFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x86420D0", Offset = "0x86406D0", VA = "0x1886420D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool OJHCMNOJFGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8642240", Offset = "0x8640840", VA = "0x188642240")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool JMJDDHOLAFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8641D20", Offset = "0x8640320", VA = "0x188641D20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool EJAICKDNCCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8642000", Offset = "0x8640600", VA = "0x188642000")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool PBGHMKDGHAD
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x8641D20", Offset = "0x8640320", VA = "0x188641D20", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool FGDKNMIJDMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x8641DA0", Offset = "0x86403A0", VA = "0x188641DA0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public string KMKNODOCBFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x8641EE0", Offset = "0x86404E0", VA = "0x188641EE0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool DDGHNCPAJIN
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x8641CA0", Offset = "0x86402A0", VA = "0x188641CA0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<MEINMPIOLGA> HBJBKLCPABB
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x8641B70", Offset = "0x8640170", VA = "0x188641B70")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x8642360", Offset = "0x8640960", VA = "0x188642360")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8641AD0", Offset = "0x86400D0", VA = "0x188641AD0")]
		public bool WasSpawnedForPlayer(int MDDIPGGGJCO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x78F5CB0", Offset = "0x78F42B0", VA = "0x1878F5CB0")]
		private void BHBJONFOLBM(RRNetworkView APAPCLFINDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8641700", Offset = "0x863FD00", VA = "0x188641700", Slot = "9")]
		public void RegisterDestroyHandler(OJFPEMCACLN KMEJDHBNOCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8641900", Offset = "0x863FF00", VA = "0x188641900", Slot = "10")]
		public void UnregisterDestroyHandler(OJFPEMCACLN KMEJDHBNOCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "11")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x86416E0", Offset = "0x863FCE0", VA = "0x1886416E0", Slot = "12")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xAA8970", Offset = "0xAA6F70", VA = "0x180AA8970")]
		public RRNetworkBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class HFGIKHKEMKH
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate void GAPFGIMHBGK([In] OBHLIKKGGFI ENMBHGMENHL, bool DKDHLDHNOOF, bool IGEFCKPMPKJ, bool DAFNAOMLAGF);

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate void AAABNIOGBAA(GameObject BHDNOHGBIBI);

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public delegate void AHIHANPJJMI(GameObject BHDNOHGBIBI);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public delegate void NDGEDNAHCFF(RRNetworkView EPNGEANGHIF, string HFFKJPDLDPD, MEINMPIOLGA LNJCEAKILKK, JCJIPGJBFOG? AMMKGILEHBG, bool CDDLNLBMGDC, DIAEAGCMBLG GFFMDEHNHBE, object[] ENMBHGMENHL, string CMAHEFODMOD);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public delegate void DBGOHCCLOJK(RRNetworkView EPNGEANGHIF, string HFFKJPDLDPD, MEINMPIOLGA LNJCEAKILKK, JCJIPGJBFOG? AMMKGILEHBG, bool CDDLNLBMGDC, DIAEAGCMBLG GFFMDEHNHBE, object[] ENMBHGMENHL, string CMAHEFODMOD);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public delegate void LNCHHGAIOLB(RRNetworkView EPNGEANGHIF, string HFFKJPDLDPD, object[] MGPPHEGFGJP, string HHJGHIFJHGA);

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate void NJGOIFDIJPM(RRNetworkView EPNGEANGHIF, MEINMPIOLGA HKAAHJDINLD);

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[CompilerGenerated]
	private static AAABNIOGBAA IBNHNCJPNAE;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public static event GAPFGIMHBGK LBFCEKHPPKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x86338C0", Offset = "0x8631EC0", VA = "0x1886338C0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x86333B0", Offset = "0x86319B0", VA = "0x1886333B0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public static event AAABNIOGBAA JCFFDNOIIAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8633470", Offset = "0x8631A70", VA = "0x188633470")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8634040", Offset = "0x8632640", VA = "0x188634040")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public static event AHIHANPJJMI EACNHNDFKPF
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x86341C0", Offset = "0x86327C0", VA = "0x1886341C0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8633060", Offset = "0x8631660", VA = "0x188633060")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public static event AHIHANPJJMI CMIAIFMGJLE
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8633F80", Offset = "0x8632580", VA = "0x188633F80")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8633C20", Offset = "0x8632220", VA = "0x188633C20")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public static event NDGEDNAHCFF JLGLCJCIEFN
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8633B60", Offset = "0x8632160", VA = "0x188633B60")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8634100", Offset = "0x8632700", VA = "0x188634100")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public static event DBGOHCCLOJK ODDFHHMMDPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x86336B0", Offset = "0x8631CB0", VA = "0x1886336B0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8633EC0", Offset = "0x86324C0", VA = "0x188633EC0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public static event LNCHHGAIOLB JPBLDJEKNHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8633530", Offset = "0x8631B30", VA = "0x188633530")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8633230", Offset = "0x8631830", VA = "0x188633230")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public static event NJGOIFDIJPM FDCKLEPIGGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8634280", Offset = "0x8632880", VA = "0x188634280")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8633CE0", Offset = "0x86322E0", VA = "0x188633CE0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public static event NJGOIFDIJPM BHAGNNIMAEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8632FA0", Offset = "0x86315A0", VA = "0x188632FA0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x86335F0", Offset = "0x8631BF0", VA = "0x1886335F0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x86332F0", Offset = "0x86318F0", VA = "0x1886332F0")]
	public static void CEHNAKBBBGO([In] OBHLIKKGGFI ENMBHGMENHL, bool DKDHLDHNOOF, bool IGEFCKPMPKJ, bool DAFNAOMLAGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x8633DA0", Offset = "0x86323A0", VA = "0x188633DA0")]
	public static void LMNFKEIOKPE(GameObject BHDNOHGBIBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8633AD0", Offset = "0x86320D0", VA = "0x188633AD0")]
	public static void IKLCEKPCEIK(GameObject BHDNOHGBIBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x8632F10", Offset = "0x8631510", VA = "0x188632F10")]
	public static void ADGKAMEOKNK(GameObject BHDNOHGBIBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x8633E30", Offset = "0x8632430", VA = "0x188633E30")]
	public static void MBPCLMGLOGB(GameObject BHDNOHGBIBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x8633980", Offset = "0x8631F80", VA = "0x188633980")]
	public static void ICOAKKJMCKM(RRNetworkView EPNGEANGHIF, string HFFKJPDLDPD, MEINMPIOLGA LNJCEAKILKK, JCJIPGJBFOG? AMMKGILEHBG, bool CDDLNLBMGDC, DIAEAGCMBLG GFFMDEHNHBE, object[] ENMBHGMENHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x8633770", Offset = "0x8631D70", VA = "0x188633770")]
	public static void GCKCIPKBGON(RRNetworkView EPNGEANGHIF, string HFFKJPDLDPD, int AFCPBMHDAIH, object[] MGPPHEGFGJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x8633120", Offset = "0x8631720", VA = "0x188633120")]
	public static void CBCONMPMJNJ(int JCBIELMJFID, int JPKKOPNBEKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class JPBCLKECMCF
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x86366A0", Offset = "0x8634CA0", VA = "0x1886366A0")]
	[CanBeNull]
	private static bool PHLNBIECMLP(ViewId NMILEMOAODL, [Out] RRNetworkView EPNGEANGHIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x86365C0", Offset = "0x8634BC0", VA = "0x1886365C0")]
	[CanBeNull]
	public static Component KHHIMPIFCDE(this ViewId EPNGEANGHIF, Type PMNAAAFILCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3E75790", Offset = "0x3E73D90", VA = "0x183E75790")]
	[CanBeNull]
	public static T KHHIMPIFCDE<T>(this ViewId EPNGEANGHIF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3E75790", Offset = "0x3E73D90", VA = "0x183E75790")]
	[CanBeNull]
	public static T OEMLEHLPEJF<T>(this ViewId EPNGEANGHIF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3E75720", Offset = "0x3E73D20", VA = "0x183E75720")]
	public static bool BMGHJLAEGFL<T>(this ViewId EPNGEANGHIF, [Out] T FAKHJBCPGHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8636550", Offset = "0x8634B50", VA = "0x188636550")]
	[CanBeNull]
	public static RRNetworkView ENMABBPKPAC(this ViewId EPNGEANGHIF)
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
		private static RRNetworkHandler MHKMPBAHOMB;

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public static bool AppQuits;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		internal static RRNetworkHandler EHBCEBDHHPE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x8642490", Offset = "0x8640A90", VA = "0x188642490")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8642660", Offset = "0x8640C60", VA = "0x188642660")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void StaticReset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8642620", Offset = "0x8640C20", VA = "0x188642620")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xAA8970", Offset = "0xAA6F70", VA = "0x180AA8970")]
		public RRNetworkHandler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[RegisterService(typeof(GLGIHGIGDIA), new string[] { "Photon" })]
[ServiceLifetime(Lifetime.PhotonRoom)]
public sealed class GLGIHGIGDIA : HMNPMNEDADI, HDOAJHPMAEO, DCEPPCNEFDI, HDIEJMEDAEI, GDKFLICGOLD, HKPOOEHKBFO, PFDHPBBBFAF
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class MLADLGLKLDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public int requestedViewId;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public MLADLGLKLDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x863A400", Offset = "0x8638A00", VA = "0x18863A400")]
		internal object BAEECFGGJPH((int requestedViewId, int newOwnerId, int senderId) x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static IPHNFELODMJ NFHIDPOKOFN;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private static IPHNFELODMJ DIFHJIBNIAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	[DependsOn]
	private GAFHMJCDDMG EGPGJAKNPOE;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private static Dictionary<int, HashSet<int>> KMFDOBAHEEN;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private static Dictionary<int, int> BHNOFLLBMCE;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private static readonly List<(GameObject GameObject, int ParentCount)> DFBJOADEBEK;

	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private static readonly List<GameObject> DNOILEAHMDB;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private static List<int> LICKBAGKGDD;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private static readonly List<RRNetworkView> JMCMADMEDOJ;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private static readonly CIJKFJMOGHC BEMHOCMDDMO;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private static readonly CIJKFJMOGHC HBGNAKIOIGB;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x862C590", Offset = "0x862AB90", VA = "0x18862C590", Slot = "8")]
	public void ECFEIOPKLDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x862E920", Offset = "0x862CF20", VA = "0x18862E920", Slot = "9")]
	public void HDAIJOIMLPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x862F640", Offset = "0x862DC40", VA = "0x18862F640", Slot = "10")]
	public void InitExternal(CNPFBIMHGJN KADNKCJPKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x8630320", Offset = "0x862E920", VA = "0x188630320", Slot = "11")]
	public void NFMEFBHMJAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x862F310", Offset = "0x862D910", VA = "0x18862F310")]
	private void IABIBGILPEH(DILFOBKEADN IIMCOJMFMCA, DILFOBKEADN HFPFCKAPBFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x862F430", Offset = "0x862DA30", VA = "0x18862F430")]
	private void IFLIIFDICMM(OHBJKFKAMJM EEABELMIPJI, OHBJKFKAMJM NIAFOLJGPFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x86315A0", Offset = "0x862FBA0", VA = "0x1886315A0")]
	public GameObject OMNJGGLCKGE(string NDIENANOGEK, Vector3 APHHGJIDDCM, Quaternion LDAEEKEKDJC, Vector3 EAHAEIJNIMH, ViewId JCBIELMJFID, ANOCIKLGHAF ENMBHGMENHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x862FEE0", Offset = "0x862E4E0", VA = "0x18862FEE0")]
	public GameObject KPCPAIIIKDD(string NDIENANOGEK, Vector3 APHHGJIDDCM, Quaternion LDAEEKEKDJC, float EAHAEIJNIMH, object[] ENMBHGMENHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x862B3E0", Offset = "0x86299E0", VA = "0x18862B3E0")]
	public GameObject DDFPJOLMFPB(string NDIENANOGEK, Vector3 APHHGJIDDCM, Quaternion LDAEEKEKDJC, Vector3 EAHAEIJNIMH, ViewId EPNGEANGHIF, ANOCIKLGHAF ENMBHGMENHL, bool DAFNAOMLAGF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x862CAD0", Offset = "0x862B0D0", VA = "0x18862CAD0")]
	public GameObject EKDPMCKNJBH(OBHLIKKGGFI ENMBHGMENHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x862F630", Offset = "0x862DC30", VA = "0x18862F630", Slot = "6")]
	public void IHGANBHAMNL(GameObject BHDNOHGBIBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x862FFE0", Offset = "0x862E5E0", VA = "0x18862FFE0")]
	public void LIMFKMCGEJP(GameObject JJEACKINPOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x8630FB0", Offset = "0x862F5B0", VA = "0x188630FB0", Slot = "7")]
	public void NHLIFMBMHDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x8632320", Offset = "0x8630920", VA = "0x188632320", Slot = "4")]
	public GameObject[] PKECHOOGCBF(IList<KDDDPMKMLAO> IMIEBDIIGMK, bool BDHFKJHNNOK = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x862ECA0", Offset = "0x862D2A0", VA = "0x18862ECA0", Slot = "5")]
	public void HEHJLFLAONC(List<GameObject> LMCBJOABKMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x862D120", Offset = "0x862B720", VA = "0x18862D120")]
	public void FGEGCNINADE(GameObject JJEACKINPOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x862B0D0", Offset = "0x86296D0", VA = "0x18862B0D0")]
	private void DAOHPHKPIFM(NDDAOAIJPDM CBIMJBOHKKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x862C900", Offset = "0x862AF00", VA = "0x18862C900")]
	private void EHGEDBANHJM(NDDAOAIJPDM CBIMJBOHKKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x862F810", Offset = "0x862DE10", VA = "0x18862F810")]
	private void JEGFDBFPKOM(NDDAOAIJPDM CBIMJBOHKKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x862F080", Offset = "0x862D680", VA = "0x18862F080")]
	private void HHJIDBOFHAG(NDDAOAIJPDM CBIMJBOHKKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x862A250", Offset = "0x8628850", VA = "0x18862A250")]
	private void BJEFNEKEFHP(NDDAOAIJPDM CBIMJBOHKKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x8630050", Offset = "0x862E650", VA = "0x188630050")]
	private void LNDADEDJMBO(NDDAOAIJPDM CBIMJBOHKKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x8631770", Offset = "0x862FD70", VA = "0x188631770")]
	private void OPFJOMJCLEE(NDDAOAIJPDM CBIMJBOHKKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x8630FC0", Offset = "0x862F5C0", VA = "0x188630FC0")]
	private GameObject NOOOPOHBCME(string CDCAHPOCPKO, Vector3 APHHGJIDDCM, Quaternion LDAEEKEKDJC, Vector3 EAHAEIJNIMH, byte DIHEIGLHFII = 0, [Optional] object[] CDDIADBJAOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x862A740", Offset = "0x8628D40", VA = "0x18862A740")]
	private GameObject CKFIIILAGCN(OBHLIKKGGFI ENMBHGMENHL, bool DKDHLDHNOOF = false, bool IGEFCKPMPKJ = false, bool DAFNAOMLAGF = true, bool BOPEKBOBDFN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x8629F90", Offset = "0x8628590", VA = "0x188629F90")]
	private static GameObject AOEIJMAPHEF(string CDCAHPOCPKO, bool JDCPDIKJPMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x862CB00", Offset = "0x862B100", VA = "0x18862CB00")]
	private static GameObject FCAANMBFHPC(GameObject IKHBLDCGHAN, OBHLIKKGGFI ENMBHGMENHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x86311B0", Offset = "0x862F7B0", VA = "0x1886311B0")]
	private static void OKMAIOIIBHK(GameObject BHDNOHGBIBI, RRNetworkView EPNGEANGHIF, [In] OBHLIKKGGFI ENMBHGMENHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x862D4F0", Offset = "0x862BAF0", VA = "0x18862D4F0")]
	private GameObject[] GMFLMCIBMDE(IList<KDDDPMKMLAO> IMIEBDIIGMK, bool BDHFKJHNNOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x862D200", Offset = "0x862B800", VA = "0x18862D200")]
	private GameObject[] GGBHKMJADPI(OBHLIKKGGFI[] GKALKDCGDJC, int HPBNEHBIONP, MEINMPIOLGA AGIMJJDFEAF, GameObject[] HOKCJLJJPOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x862CD10", Offset = "0x862B310", VA = "0x18862CD10")]
	private GameObject FDAHHGAMBNL([In] OBHLIKKGGFI ENMBHGMENHL, GameObject IKHBLDCGHAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x78D7520", Offset = "0x78D5B20", VA = "0x1878D7520")]
	private static bool EGJEONPHAIP(bool DKDHLDHNOOF, bool DAFNAOMLAGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x862DCF0", Offset = "0x862C2F0", VA = "0x18862DCF0")]
	private void GPMAJBOJKHB(IEnumerable<GameObject> LMCBJOABKMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x862B670", Offset = "0x8629C70", VA = "0x18862B670")]
	private void DEGCLDGNIEJ(GameObject BHDNOHGBIBI, bool BOPEKBOBDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x862FAD0", Offset = "0x862E0D0", VA = "0x18862FAD0")]
	private static void KJLPBKFLEDH(IEnumerable<GameObject> BIBMDEKDNIN, List<(GameObject GameObject, int ParentCount)> NLMNKCOCOLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x862AF70", Offset = "0x8629570", VA = "0x18862AF70")]
	private void CPNEGIIPGDO(int MGKEEIKKKDN, int HPBNEHBIONP, bool BOPEKBOBDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x8630240", Offset = "0x862E840", VA = "0x188630240")]
	private static int MCIFADJMMFA(int MGKEEIKKKDN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x862FA70", Offset = "0x862E070", VA = "0x18862FA70")]
	private void KFIMMPICJNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x8631DA0", Offset = "0x86303A0", VA = "0x188631DA0")]
	private void PBAMHOKAODK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x862A6E0", Offset = "0x8628CE0", VA = "0x18862A6E0")]
	private static int BOOKBMJAIBM(int KJGEGOKIDFK, bool DAFNAOMLAGF = true)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x862AE90", Offset = "0x8629490", VA = "0x18862AE90")]
	private static int[] COIOPPFFEGI(int NPAFEBIPCNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x8632650", Offset = "0x8630C50", VA = "0x188632650")]
	private static int[] PPHNBJFHDLP(int PCLFJGMAHBI, int NPAFEBIPCNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x86302E0", Offset = "0x862E8E0", VA = "0x1886302E0")]
	private void MCIFEABBMOH(MEINMPIOLGA KEDGBKADGEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x86304F0", Offset = "0x862EAF0", VA = "0x1886304F0")]
	private void NHGHMJBFCFP(MEINMPIOLGA AGIMJJDFEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x86312C0", Offset = "0x862F8C0", VA = "0x1886312C0")]
	private void OLAOCHEFCFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x862A010", Offset = "0x8628610", VA = "0x18862A010")]
	private void BHMMJHGEAGP(MEINMPIOLGA AGIMJJDFEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x862A640", Offset = "0x8628C40", VA = "0x18862A640")]
	private static void BMKOIGHKCKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x862F530", Offset = "0x862DB30", VA = "0x18862F530")]
	private void IHCLLFLLLFD(int[] DEEMKEJBHPG, int APNCGHKAOHB = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x862AE40", Offset = "0x8629440", VA = "0x18862AE40", Slot = "12")]
	private void CMMNFFLCJOL(CNPFBIMHGJN KADNKCJPKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x135CED0", Offset = "0x135B4D0", VA = "0x18135CED0", Slot = "13")]
	private void GCOCFFJOAJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public GLGIHGIGDIA()
	{
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class RRNetworkProfiler : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xAA8970", Offset = "0xAA6F70", VA = "0x180AA8970")]
		public RRNetworkProfiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[RegisterService(typeof(PONCNABAFPG), new string[] { "Photon" })]
[ServiceLifetime(Lifetime.PhotonRoom)]
public class PONCNABAFPG : HDOAJHPMAEO, DCEPPCNEFDI, OJDKKCNOJHF
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct IGHONMLIEIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public readonly MethodInfo OBOOPHFDAPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly Func<MonoBehaviour, object> JFEJDFEEGND;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xC5DA70", Offset = "0xC5C070", VA = "0x180C5DA70")]
		public IGHONMLIEIF(MethodInfo OBOOPHFDAPC, [Optional] Func<MonoBehaviour, object> JFEJDFEEGND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x78E1890", Offset = "0x78DFE90", VA = "0x1878E1890")]
		public object FLKCMLFLHGK(MonoBehaviour DCIGKGCKCAB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class KFICOFLJFOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public FieldInfo instanceAccessFromField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Func<MonoBehaviour, object> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public KFICOFLJFOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x86399C0", Offset = "0x8637FC0", VA = "0x1886399C0")]
		internal IGHONMLIEIF NCIDHAONNNN(MethodInfo methodInfo)
		{
			return default(IGHONMLIEIF);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x4BDCFD0", Offset = "0x4BDB5D0", VA = "0x184BDCFD0")]
		internal object OIMIKHBDMAE(MonoBehaviour mb)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class GOEHOIABCLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Func<MonoBehaviour, object> accessor;

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public GOEHOIABCLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x78C6660", Offset = "0x78C4C60", VA = "0x1878C6660")]
		internal IGHONMLIEIF CAPGLLBIAEE(MethodInfo methodInfo)
		{
			return default(IGHONMLIEIF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class MMCJKDEOLND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Type attributeType;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public MMCJKDEOLND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x863A4C0", Offset = "0x8638AC0", VA = "0x18863A4C0")]
		internal bool FBNAHKOAPID(MethodInfo m)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly IPHNFELODMJ AMCHCCAPJNG;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static Dictionary<string, int> OMKIOPADJOO;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static List<string> MFDFMMDILFA;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static int NAHGEMOONHP;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly Stopwatch KCOOMLJHPAG;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static Dictionary<MethodInfo, ParameterInfo[]> KALJIFMGFGG;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static readonly Dictionary<Type, List<IGHONMLIEIF>> DJOOHNHGIAN;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x863E3A0", Offset = "0x863C9A0", VA = "0x18863E3A0", Slot = "4")]
	public void ECFEIOPKLDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x863EE40", Offset = "0x863D440", VA = "0x18863EE40", Slot = "5")]
	public void HDAIJOIMLPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x863E8F0", Offset = "0x863CEF0", VA = "0x18863E8F0")]
	public static bool EOEDMOKDPFI(string HFFKJPDLDPD, [Out] int HLFHKHHACDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x863D6E0", Offset = "0x863BCE0", VA = "0x18863D6E0")]
	public static bool ALEOHGPEDFC(int HLFHKHHACDD, [Out] string HFFKJPDLDPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x863E0E0", Offset = "0x863C6E0", VA = "0x18863E0E0")]
	private void DAOHPHKPIFM(NDDAOAIJPDM CBIMJBOHKKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x863D6B0", Offset = "0x863BCB0", VA = "0x18863D6B0", Slot = "9")]
	public string AGELBEKABMN(NDDAOAIJPDM CBIMJBOHKKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x8641260", Offset = "0x863F860", VA = "0x188641260", Slot = "8")]
	public void NADEFEMGAND(ViewId JCBIELMJFID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x863D7D0", Offset = "0x863BDD0", VA = "0x18863D7D0", Slot = "6")]
	public void APDPAEEACDA(ViewId EPNGEANGHIF, string HFFKJPDLDPD, MEINMPIOLGA AGIMJJDFEAF, DIAEAGCMBLG GFFMDEHNHBE, params object[] ENMBHGMENHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x863D8A0", Offset = "0x863BEA0", VA = "0x18863D8A0", Slot = "7")]
	public void APDPAEEACDA(ViewId EPNGEANGHIF, string HFFKJPDLDPD, JCJIPGJBFOG AMMKGILEHBG, DIAEAGCMBLG GFFMDEHNHBE, params object[] ENMBHGMENHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x863D8D0", Offset = "0x863BED0", VA = "0x18863D8D0")]
	private void APDPAEEACDA(ViewId EPNGEANGHIF, string HFFKJPDLDPD, JCJIPGJBFOG AMMKGILEHBG, MEINMPIOLGA AGIMJJDFEAF, DIAEAGCMBLG GFFMDEHNHBE, params object[] ENMBHGMENHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x863EFA0", Offset = "0x863D5A0", VA = "0x18863EFA0")]
	private void HNMPLANIFOC(ViewId JCBIELMJFID, string HFFKJPDLDPD, MEINMPIOLGA OBAFOAGLIMM, int MEIHIEPFMPH, object[] MGPPHEGFGJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x863E980", Offset = "0x863CF80", VA = "0x18863E980")]
	private static void HBIMGINCHLL(IGHONMLIEIF HEPPOGGJMKL, MonoBehaviour OCPEHMNJLAG, object[] PNGANGECEEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x863DEB0", Offset = "0x863C4B0", VA = "0x18863DEB0")]
	private static bool BMMNOIACAAG(ParameterInfo[] APHONKBMAOO, Type[] JLEEKPFMOIF, [Out] bool MCDLHFNPLEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x8640960", Offset = "0x863EF60", VA = "0x188640960")]
	private List<IGHONMLIEIF> JHAAPPACJCA(MonoBehaviour OCPEHMNJLAG, Type HELNELEHIDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x863DDB0", Offset = "0x863C3B0", VA = "0x18863DDB0")]
	private static IEnumerable<MethodInfo> BGKPHGMBOFM(Type GPEIAHGICNA, Type AHIBKFNIJIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x8641340", Offset = "0x863F940", VA = "0x188641340")]
	public static ParameterInfo[] PMHGKLPGBLO(MethodInfo AHPNFBECPNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public PONCNABAFPG()
	{
	}
}
namespace RecRoom.Networking
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class RRNetworkSettings : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public const string RRNetworkSettingsFileName = "RRNetworkSettings";

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private static RRNetworkSettings instance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[Tooltip("RPC name list.\nUsed as shortcut when sending calls.")]
		public List<string> RpcList;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static RRNetworkSettings Instance
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x8642730", Offset = "0x8640D30", VA = "0x188642730")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x86426A0", Offset = "0x8640CA0", VA = "0x1886426A0")]
		public RRNetworkSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class RRNetworkView : MonoBehaviour, GDGJFLEDIKD, PPLJNHCODAF, CLILPJPAIGG, LAHJHLNIINP, NKNGDLOHPMN
	{
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		[RegisterService(typeof(GAFHMJCDDMG), new string[] { })]
		internal class GPAPPPFJOJH : HDOAJHPMAEO, DCEPPCNEFDI, GAFHMJCDDMG
		{
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public static readonly Dictionary<int, RRNetworkView> CPAJGGOIFDH;

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x8632B40", Offset = "0x8631140", VA = "0x188632B40", Slot = "4")]
			public void ECFEIOPKLDN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x8632B40", Offset = "0x8631140", VA = "0x188632B40", Slot = "5")]
			public void HDAIJOIMLPA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x8632B50", Offset = "0x8631150", VA = "0x188632B50", Slot = "6")]
			public void JKHALIHPCMD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
			public GPAPPPFJOJH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public enum BNJINBDNCCI
		{
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			False,
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			True_SetInSceneForRoom,
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			True_ManuallySetInPrefab
		}

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		[CompilerGenerated]
		private sealed class DDFJANEIAOC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public int actorNumber;

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
			public DDFJANEIAOC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x8626DD0", Offset = "0x86253D0", VA = "0x188626DD0")]
			internal bool BHLBGDEMDIG(RRNetworkView view)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static CIJKFJMOGHC AAGAHIFGADM;

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
		private bool KOGBJLEJLEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		internal bool CDHLPLFJJAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[SerializeField]
		[Tooltip("By default, prefabs cannot contain hard coded values for viewIdField; singletons that need to have consistent viewIdField across clients may set this flag to disable automatic cleaning of the property viewIdField")]
		public BNJINBDNCCI hasExplicitViewId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private bool CCLEGCEMJFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private bool MBJAMHINCMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int GGIINHIJFFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private bool OGBMBAMMAKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int FKDIBDEPANP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private MEINMPIOLGA PCLFJGMAHBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private MEINMPIOLGA EJKPGKGAOAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private bool? OMHKFDABICF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private bool AGDIMJNPONG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		internal bool OJOLNMHIABG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		internal MonoBehaviour[] BBJJGAKCJNB;

		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private static readonly IPHNFELODMJ MHLPAMMJOLB;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private static Dictionary<int, RRNetworkView> CPAJGGOIFDH
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x8643720", Offset = "0x8641D20", VA = "0x188643720")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ViewId HBBDDMLJOPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x8646EA0", Offset = "0x86454A0", VA = "0x188646EA0")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public ViewId LPNFKADLLIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x8646EA0", Offset = "0x86454A0", VA = "0x188646EA0", Slot = "5")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public ViewId MDNGHJINCAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x8646EA0", Offset = "0x86454A0", VA = "0x188646EA0")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int ELNBECEDJMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0xAB04F0", Offset = "0xAAEAF0", VA = "0x180AB04F0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0xAB2A20", Offset = "0xAB1020", VA = "0x180AB2A20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int BHEJPKHBLCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0xACF420", Offset = "0xACDA20", VA = "0x180ACF420")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0xEF9A80", Offset = "0xEF8080", VA = "0x180EF9A80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public ViewId LALNLAKNPOI
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x8646D10", Offset = "0x8645310", VA = "0x188646D10")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool BGNPJGNBDDP
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0xAA5700", Offset = "0xAA3D00", VA = "0x180AA5700")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xAA54D0", Offset = "0xAA3AD0", VA = "0x180AA54D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool EJODGGFOONP
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x8646D20", Offset = "0x8645320", VA = "0x188646D20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool KCDEPMAOBIC
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0xC58290", Offset = "0xC56890", VA = "0x180C58290")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xC18890", Offset = "0xC16E90", VA = "0x180C18890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public int KKDMOANMAMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xAF64A0", Offset = "0xAF4AA0", VA = "0x180AF64A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public int GIDLJNOLHLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x8646CB0", Offset = "0x86452B0", VA = "0x188646CB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public MEINMPIOLGA NNKCBHNLPFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x8646EB0", Offset = "0x86454B0", VA = "0x188646EB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public MEINMPIOLGA LDFIBBCILAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x8646C80", Offset = "0x8645280", VA = "0x188646C80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public MEINMPIOLGA CLGINMNKMEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x8646C80", Offset = "0x8645280", VA = "0x188646C80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public MEINMPIOLGA EFDEEGDAKDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x8646C80", Offset = "0x8645280", VA = "0x188646C80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool IGGEJLKFNDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x8646DF0", Offset = "0x86453F0", VA = "0x188646DF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public int IBHKMHEGILO
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x8646CE0", Offset = "0x86452E0", VA = "0x188646CE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public object[] LDFNDDNKOHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0xAA55B0", Offset = "0xAA3BB0", VA = "0x180AA55B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0xAA57F0", Offset = "0xAA3DF0", VA = "0x180AA57F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool FLHNEAKLKFM
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x8646EE0", Offset = "0x86454E0", VA = "0x188646EE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool DFEEFNHBKIN
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x8646E70", Offset = "0x8645470", VA = "0x188646E70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool CJKCNKHINOB
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0xEC0AF0", Offset = "0xEBF0F0", VA = "0x180EC0AF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x1048D30", Offset = "0x1047330", VA = "0x181048D30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool HMDJDGHDCBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0xD67C30", Offset = "0xD66230", VA = "0x180D67C30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<RRNetworkView> HEHAIFOIKCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x8646B20", Offset = "0x8645120", VA = "0x188646B20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x86470A0", Offset = "0x86456A0", VA = "0x1886470A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		private event Action<MEINMPIOLGA> OFJFCCOGKHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x8643FA0", Offset = "0x86425A0", VA = "0x188643FA0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x8643670", Offset = "0x8641C70", VA = "0x188643670")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		public event Action<MEINMPIOLGA> DJNNOHMICNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x8643FA0", Offset = "0x86425A0", VA = "0x188643FA0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x8643670", Offset = "0x8641C70", VA = "0x188643670")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		private event Action<int> EDJJCGNLEIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x8643AE0", Offset = "0x86420E0", VA = "0x188643AE0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x86428B0", Offset = "0x8640EB0", VA = "0x1886428B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		public event Action<int> PGHJFIEPONB
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x8643AE0", Offset = "0x86420E0", VA = "0x188643AE0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x86428B0", Offset = "0x8640EB0", VA = "0x1886428B0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		public event Action<RRNetworkView> FBBPJIIAHJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x8646BD0", Offset = "0x86451D0", VA = "0x188646BD0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x8647150", Offset = "0x8645750", VA = "0x188647150")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		public event Action OADCDNBMACC
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x8646A70", Offset = "0x8645070", VA = "0x188646A70")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x8646FF0", Offset = "0x86455F0", VA = "0x188646FF0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x86468E0", Offset = "0x8644EE0", VA = "0x1886468E0")]
		public static bool TryGetNetworkView(int JCBIELMJFID, [Out] RRNetworkView EPNGEANGHIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8643060", Offset = "0x8641660", VA = "0x188643060")]
		public static RRNetworkView Find(int JCBIELMJFID)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x8643440", Offset = "0x8641A40", VA = "0x188643440")]
		public static IEnumerable<RRNetworkView> GetCreatedAndOwnedNetworkViews(int NMBBIDCMGIO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8643390", Offset = "0x8641990", VA = "0x188643390")]
		public static IEnumerable<RRNetworkView> GetAllNetworkViews()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x8644D10", Offset = "0x8643310", VA = "0x188644D10")]
		public static bool RemoveNetworkView(RRNetworkView EPNGEANGHIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x8644AB0", Offset = "0x86430B0", VA = "0x188644AB0")]
		public static void RebuildControllCacheForAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x86444B0", Offset = "0x8642AB0", VA = "0x1886444B0")]
		public static void OnPlayerJoinedRoom(MEINMPIOLGA CLDOOJMJMLP, List<int> DEEMKEJBHPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x86435B0", Offset = "0x8641BB0", VA = "0x1886435B0")]
		public static RRNetworkView Get(Component IDFKPPKNONO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x8643610", Offset = "0x8641C10", VA = "0x188643610")]
		public static RRNetworkView Get(GameObject EEPDIDPAHMM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x8643EC0", Offset = "0x86424C0", VA = "0x188643EC0")]
		private void MEJPBDLJFKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x8642D30", Offset = "0x8641330", VA = "0x188642D30")]
		public bool CreatedBy(MEINMPIOLGA AGIMJJDFEAF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x86466F0", Offset = "0x8644CF0", VA = "0x1886466F0")]
		public void TransferOwnership(int CHLOPHEOHOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8646690", Offset = "0x8644C90", VA = "0x188646690")]
		public void TransferOwnership(MEINMPIOLGA HKAAHJDINLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x8643810", Offset = "0x8641E10", VA = "0x188643810", Slot = "4")]
		public void Initialize(ViewId BMCFFHIPJEI, ViewId AINPJJPGMCG, Dictionary<int, object> LLNAAJAADDM, NOCCEEEBCMN PCLFJGMAHBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x8643990", Offset = "0x8641F90", VA = "0x188643990")]
		public void Initialize(ViewId BMCFFHIPJEI, ViewId AINPJJPGMCG, object[] EPGAFNDAAHF, NOCCEEEBCMN PCLFJGMAHBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x8642960", Offset = "0x8640F60", VA = "0x188642960")]
		protected internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x8643120", Offset = "0x8641720", VA = "0x188643120")]
		private void GLCJJLLMBEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x20EF560", Offset = "0x20EDB60", VA = "0x1820EF560")]
		internal void CICPDPEIKIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x8642F00", Offset = "0x8641500", VA = "0x188642F00", Slot = "6")]
		private void EADONBODBIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x8644820", Offset = "0x8642E20", VA = "0x188644820")]
		internal bool PNFGIAHCNJA(RRNetworkView KGJJOLIFHND)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x8644370", Offset = "0x8642970", VA = "0x188644370")]
		protected internal void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x8643000", Offset = "0x8641600", VA = "0x188643000")]
		internal void FJPKOMJJPEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x8643EB0", Offset = "0x86424B0", VA = "0x188643EB0")]
		private void MEFMOMABGGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x8643B90", Offset = "0x8642190", VA = "0x188643B90")]
		internal void LCADCKAEBPP(MEINMPIOLGA HKAAHJDINLD, int CHLOPHEOHOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x8644C70", Offset = "0x8643270", VA = "0x188644C70")]
		public void RebuildControllerCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x8644DC0", Offset = "0x86433C0", VA = "0x188644DC0")]
		public void ResetOwnership()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x8643C50", Offset = "0x8642250", VA = "0x188643C50")]
		private void LCKIHHNADLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x86439F0", Offset = "0x8641FF0", VA = "0x1886439F0")]
		private void JMDDBCEPMIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x8644990", Offset = "0x8642F90", VA = "0x188644990")]
		public void RPC(string HFFKJPDLDPD, JCJIPGJBFOG AMMKGILEHBG, params object[] ENMBHGMENHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x8644A20", Offset = "0x8643020", VA = "0x188644A20")]
		public void RPC(string HFFKJPDLDPD, MEINMPIOLGA LNJCEAKILKK, params object[] ENMBHGMENHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8644CC0", Offset = "0x86432C0", VA = "0x188644CC0")]
		public void RefreshRpcMonoBehaviourCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x86429C0", Offset = "0x8640FC0", VA = "0x1886429C0", Slot = "8")]
		public void Bake(AIJJICHNHLM JIFPJFGEAIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8642A30", Offset = "0x8641030", VA = "0x188642A30")]
		private static void CKJPKEBENBJ(MEINMPIOLGA GMPDLOKBGJB, [Out] MEINMPIOLGA PIJLLICHOJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x8644050", Offset = "0x8642650", VA = "0x188644050")]
		private static void NPEHJGJGPOF(RRNetworkView DOJBOEGBBGG, Delegate HEPPOGGJMKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8643770", Offset = "0x8641D70", VA = "0x188643770")]
		private static KFPLHECPDME IJKDMNJAHLO(RRNetworkView DOJBOEGBBGG)
		{
			return default(KFPLHECPDME);
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8643CF0", Offset = "0x86422F0", VA = "0x188643CF0")]
		private static void MALDLCKAENN(RRNetworkView DOJBOEGBBGG, Delegate HEPPOGGJMKL, MEINMPIOLGA CPHAJCPEFCH, params object[] ENMBHGMENHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8643DD0", Offset = "0x86423D0", VA = "0x188643DD0")]
		private static void MALDLCKAENN(RRNetworkView DOJBOEGBBGG, Delegate HEPPOGGJMKL, JCJIPGJBFOG CPHAJCPEFCH, params object[] ENMBHGMENHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8642DB0", Offset = "0x86413B0", VA = "0x188642DB0")]
		private static void DEKHHHJBJLP(RRNetworkView DOJBOEGBBGG, Delegate HEPPOGGJMKL, JCJIPGJBFOG CPHAJCPEFCH, JPMIBEBBNEJ FKGCEOGLFEM, params object[] ENMBHGMENHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8644890", Offset = "0x8642E90", VA = "0x188644890")]
		public void RPCBuffered(string HFFKJPDLDPD, JCJIPGJBFOG AMMKGILEHBG, JPMIBEBBNEJ GFFMDEHNHBE, params object[] ENMBHGMENHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x8642F60", Offset = "0x8641560", VA = "0x188642F60")]
		private static bool EIHHMACMHNA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x86454A0", Offset = "0x8643AA0", VA = "0x1886454A0", Slot = "26")]
		public void RpcAll(GGHLJLKEFEL.GCDLJGLLLFE HEPPOGGJMKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x403D270", Offset = "0x403B870", VA = "0x18403D270", Slot = "9")]
		public void RpcAll<T1>(GGHLJLKEFEL.EFOFIPPGKNL<T1> HEPPOGGJMKL, T1 LMANKJPDGIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x403CAF0", Offset = "0x403B0F0", VA = "0x18403CAF0", Slot = "10")]
		public void RpcAll<T1, T2>(GGHLJLKEFEL.JNBHLPMDPKA<T1, T2> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x403DB50", Offset = "0x403C150", VA = "0x18403DB50", Slot = "27")]
		public void RpcAll<T1, T2, T3>(GGHLJLKEFEL.KPAAMMMKJOC<T1, T2, T3> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x403CD00", Offset = "0x403B300", VA = "0x18403CD00", Slot = "28")]
		public void RpcAll<T1, T2, T3, T4>(GGHLJLKEFEL.CLOCENELBFM<T1, T2, T3, T4> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x4077C30", Offset = "0x4076230", VA = "0x184077C30", Slot = "29")]
		public void RpcAll<T1, T2, T3, T4, T5>(GGHLJLKEFEL.JODGEDHHKBJ<T1, T2, T3, T4, T5> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x4079410", Offset = "0x4077A10", VA = "0x184079410", Slot = "30")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(GGHLJLKEFEL.ONBHLILFLJA<T1, T2, T3, T4, T5, T6> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x4077700", Offset = "0x4075D00", VA = "0x184077700", Slot = "11")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(GGHLJLKEFEL.CMEEMNFELJP<T1, T2, T3, T4, T5, T6, T7> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x407B1C0", Offset = "0x40797C0", VA = "0x18407B1C0", Slot = "12")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(GGHLJLKEFEL.MIGJDFFBJLL<T1, T2, T3, T4, T5, T6, T7, T8> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x40798B0", Offset = "0x4077EB0", VA = "0x1840798B0", Slot = "31")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(GGHLJLKEFEL.HPDJJEHMLLC<T1, T2, T3, T4, T5, T6, T7, T8, T9> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x4078940", Offset = "0x4076F40", VA = "0x184078940", Slot = "13")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(NHPBLGMFGLH HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x407EEF0", Offset = "0x407D4F0", VA = "0x18407EEF0", Slot = "32")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(DDBPFNMMCAA HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB, T11 KMLOFCOIBFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x407E440", Offset = "0x407CA40", VA = "0x18407E440", Slot = "33")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(DPLODLFNDDN HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB, T11 KMLOFCOIBFC, T12 OIILEKLFCKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x407D290", Offset = "0x407B890", VA = "0x18407D290", Slot = "34")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(LHEMOAEHDMP HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB, T11 KMLOFCOIBFC, T12 OIILEKLFCKI, T13 NJGIIMMGHEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x4078070", Offset = "0x4076670", VA = "0x184078070", Slot = "35")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BLBLFCOABBE HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB, T11 KMLOFCOIBFC, T12 OIILEKLFCKI, T13 NJGIIMMGHEG, T14 MDPIEPACCGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x8645270", Offset = "0x8643870", VA = "0x188645270", Slot = "36")]
		public void RpcAll(GGHLJLKEFEL.EFOFIPPGKNL<KFPLHECPDME> HEPPOGGJMKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x403F560", Offset = "0x403DB60", VA = "0x18403F560", Slot = "37")]
		public void RpcAll<T1>(GGHLJLKEFEL.JNBHLPMDPKA<T1, KFPLHECPDME> HEPPOGGJMKL, T1 LMANKJPDGIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x403FB70", Offset = "0x403E170", VA = "0x18403FB70", Slot = "38")]
		public void RpcAll<T1, T2>(GGHLJLKEFEL.KPAAMMMKJOC<T1, T2, KFPLHECPDME> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x403D620", Offset = "0x403BC20", VA = "0x18403D620", Slot = "39")]
		public void RpcAll<T1, T2, T3>(GGHLJLKEFEL.CLOCENELBFM<T1, T2, T3, KFPLHECPDME> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x4042E00", Offset = "0x4041400", VA = "0x184042E00", Slot = "40")]
		public void RpcAll<T1, T2, T3, T4>(GGHLJLKEFEL.JODGEDHHKBJ<T1, T2, T3, T4, KFPLHECPDME> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x4081E50", Offset = "0x4080450", VA = "0x184081E50", Slot = "41")]
		public void RpcAll<T1, T2, T3, T4, T5>(GGHLJLKEFEL.ONBHLILFLJA<T1, T2, T3, T4, T5, KFPLHECPDME> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x4081520", Offset = "0x407FB20", VA = "0x184081520", Slot = "42")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(GGHLJLKEFEL.CMEEMNFELJP<T1, T2, T3, T4, T5, T6, KFPLHECPDME> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x4080E00", Offset = "0x407F400", VA = "0x184080E00", Slot = "43")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(GGHLJLKEFEL.MIGJDFFBJLL<T1, T2, T3, T4, T5, T6, T7, KFPLHECPDME> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x4080620", Offset = "0x407EC20", VA = "0x184080620", Slot = "44")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(GGHLJLKEFEL.HPDJJEHMLLC<T1, T2, T3, T4, T5, T6, T7, T8, KFPLHECPDME> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x407FD60", Offset = "0x407E360", VA = "0x18407FD60", Slot = "45")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(NHPBLGMFGLH HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x407F880", Offset = "0x407DE80", VA = "0x18407F880", Slot = "46")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(DDBPFNMMCAA HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x407E9B0", Offset = "0x407CFB0", VA = "0x18407E9B0", Slot = "47")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(DPLODLFNDDN HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB, T11 KMLOFCOIBFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x407DE90", Offset = "0x407C490", VA = "0x18407DE90", Slot = "48")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(LHEMOAEHDMP HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB, T11 KMLOFCOIBFC, T12 OIILEKLFCKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x407D870", Offset = "0x407BE70", VA = "0x18407D870", Slot = "49")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BLBLFCOABBE HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB, T11 KMLOFCOIBFC, T12 OIILEKLFCKI, T13 NJGIIMMGHEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x407C5D0", Offset = "0x407ABD0", VA = "0x18407C5D0", Slot = "50")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(PLBMPGOKEFB HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB, T11 KMLOFCOIBFC, T12 OIILEKLFCKI, T13 NJGIIMMGHEG, T14 MDPIEPACCGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x8645010", Offset = "0x8643610", VA = "0x188645010", Slot = "51")]
		public void RpcAllViaServer(GGHLJLKEFEL.GCDLJGLLLFE HEPPOGGJMKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x4077600", Offset = "0x4075C00", VA = "0x184077600", Slot = "52")]
		public void RpcAllViaServer<T1>(GGHLJLKEFEL.EFOFIPPGKNL<T1> HEPPOGGJMKL, T1 LMANKJPDGIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x4071E10", Offset = "0x4070410", VA = "0x184071E10", Slot = "14")]
		public void RpcAllViaServer<T1, T2>(GGHLJLKEFEL.JNBHLPMDPKA<T1, T2> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x4077090", Offset = "0x4075690", VA = "0x184077090", Slot = "53")]
		public void RpcAllViaServer<T1, T2, T3>(GGHLJLKEFEL.KPAAMMMKJOC<T1, T2, T3> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x4076CE0", Offset = "0x40752E0", VA = "0x184076CE0", Slot = "54")]
		public void RpcAllViaServer<T1, T2, T3, T4>(GGHLJLKEFEL.CLOCENELBFM<T1, T2, T3, T4> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x4076640", Offset = "0x4074C40", VA = "0x184076640", Slot = "55")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(GGHLJLKEFEL.JODGEDHHKBJ<T1, T2, T3, T4, T5> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x40763B0", Offset = "0x40749B0", VA = "0x1840763B0", Slot = "56")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(GGHLJLKEFEL.ONBHLILFLJA<T1, T2, T3, T4, T5, T6> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x4075B60", Offset = "0x4074160", VA = "0x184075B60", Slot = "57")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(GGHLJLKEFEL.CMEEMNFELJP<T1, T2, T3, T4, T5, T6, T7> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x4075500", Offset = "0x4073B00", VA = "0x184075500", Slot = "58")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(GGHLJLKEFEL.MIGJDFFBJLL<T1, T2, T3, T4, T5, T6, T7, T8> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x4074E00", Offset = "0x4073400", VA = "0x184074E00", Slot = "59")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(GGHLJLKEFEL.HPDJJEHMLLC<T1, T2, T3, T4, T5, T6, T7, T8, T9> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x4074660", Offset = "0x4072C60", VA = "0x184074660", Slot = "60")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(NHPBLGMFGLH HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x4074240", Offset = "0x4072840", VA = "0x184074240", Slot = "61")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(DDBPFNMMCAA HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB, T11 KMLOFCOIBFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x4073540", Offset = "0x4071B40", VA = "0x184073540", Slot = "62")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(DPLODLFNDDN HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB, T11 KMLOFCOIBFC, T12 OIILEKLFCKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x4073080", Offset = "0x4071680", VA = "0x184073080", Slot = "63")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(LHEMOAEHDMP HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB, T11 KMLOFCOIBFC, T12 OIILEKLFCKI, T13 NJGIIMMGHEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x4072180", Offset = "0x4070780", VA = "0x184072180", Slot = "64")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BLBLFCOABBE HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB, T11 KMLOFCOIBFC, T12 OIILEKLFCKI, T13 NJGIIMMGHEG, T14 MDPIEPACCGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x8645140", Offset = "0x8643740", VA = "0x188645140", Slot = "65")]
		public void RpcAllViaServer(GGHLJLKEFEL.EFOFIPPGKNL<KFPLHECPDME> HEPPOGGJMKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x4077500", Offset = "0x4075B00", VA = "0x184077500", Slot = "66")]
		public void RpcAllViaServer<T1>(GGHLJLKEFEL.JNBHLPMDPKA<T1, KFPLHECPDME> HEPPOGGJMKL, T1 LMANKJPDGIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x40773A0", Offset = "0x40759A0", VA = "0x1840773A0", Slot = "67")]
		public void RpcAllViaServer<T1, T2>(GGHLJLKEFEL.KPAAMMMKJOC<T1, T2, KFPLHECPDME> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x4076EE0", Offset = "0x40754E0", VA = "0x184076EE0", Slot = "68")]
		public void RpcAllViaServer<T1, T2, T3>(GGHLJLKEFEL.CLOCENELBFM<T1, T2, T3, KFPLHECPDME> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x4076AE0", Offset = "0x40750E0", VA = "0x184076AE0", Slot = "69")]
		public void RpcAllViaServer<T1, T2, T3, T4>(GGHLJLKEFEL.JODGEDHHKBJ<T1, T2, T3, T4, KFPLHECPDME> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x4076890", Offset = "0x4074E90", VA = "0x184076890", Slot = "70")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(GGHLJLKEFEL.ONBHLILFLJA<T1, T2, T3, T4, T5, KFPLHECPDME> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x4076120", Offset = "0x4074720", VA = "0x184076120", Slot = "71")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(GGHLJLKEFEL.CMEEMNFELJP<T1, T2, T3, T4, T5, T6, KFPLHECPDME> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x4075E40", Offset = "0x4074440", VA = "0x184075E40", Slot = "72")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(GGHLJLKEFEL.MIGJDFFBJLL<T1, T2, T3, T4, T5, T6, T7, KFPLHECPDME> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x4075830", Offset = "0x4073E30", VA = "0x184075830", Slot = "73")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(GGHLJLKEFEL.HPDJJEHMLLC<T1, T2, T3, T4, T5, T6, T7, T8, KFPLHECPDME> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x4075180", Offset = "0x4073780", VA = "0x184075180", Slot = "74")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(NHPBLGMFGLH HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x4074A30", Offset = "0x4073030", VA = "0x184074A30", Slot = "75")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(DDBPFNMMCAA HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x4073E20", Offset = "0x4072420", VA = "0x184073E20", Slot = "76")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(DPLODLFNDDN HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB, T11 KMLOFCOIBFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x40739B0", Offset = "0x4071FB0", VA = "0x1840739B0", Slot = "77")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(LHEMOAEHDMP HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB, T11 KMLOFCOIBFC, T12 OIILEKLFCKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x4072BC0", Offset = "0x40711C0", VA = "0x184072BC0", Slot = "78")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BLBLFCOABBE HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB, T11 KMLOFCOIBFC, T12 OIILEKLFCKI, T13 NJGIIMMGHEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x40726A0", Offset = "0x4070CA0", VA = "0x1840726A0", Slot = "79")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(PLBMPGOKEFB HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB, T11 KMLOFCOIBFC, T12 OIILEKLFCKI, T13 NJGIIMMGHEG, T14 MDPIEPACCGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x8645F30", Offset = "0x8644530", VA = "0x188645F30", Slot = "80")]
		public void RpcOthers(GGHLJLKEFEL.GCDLJGLLLFE HEPPOGGJMKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x40A1E50", Offset = "0x40A0450", VA = "0x1840A1E50", Slot = "15")]
		public void RpcOthers<T1>(GGHLJLKEFEL.EFOFIPPGKNL<T1> HEPPOGGJMKL, T1 LMANKJPDGIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x40A2420", Offset = "0x40A0A20", VA = "0x1840A2420", Slot = "81")]
		public void RpcOthers<T1, T2>(GGHLJLKEFEL.JNBHLPMDPKA<T1, T2> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x40A1BD0", Offset = "0x40A01D0", VA = "0x1840A1BD0", Slot = "82")]
		public void RpcOthers<T1, T2, T3>(GGHLJLKEFEL.KPAAMMMKJOC<T1, T2, T3> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x40AECC0", Offset = "0x40AD2C0", VA = "0x1840AECC0", Slot = "83")]
		public void RpcOthers<T1, T2, T3, T4>(GGHLJLKEFEL.CLOCENELBFM<T1, T2, T3, T4> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x40AE5C0", Offset = "0x40ACBC0", VA = "0x1840AE5C0", Slot = "84")]
		public void RpcOthers<T1, T2, T3, T4, T5>(GGHLJLKEFEL.JODGEDHHKBJ<T1, T2, T3, T4, T5> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x40A9A80", Offset = "0x40A8080", VA = "0x1840A9A80", Slot = "85")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(GGHLJLKEFEL.ONBHLILFLJA<T1, T2, T3, T4, T5, T6> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x40ADA20", Offset = "0x40AC020", VA = "0x1840ADA20", Slot = "86")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(GGHLJLKEFEL.CMEEMNFELJP<T1, T2, T3, T4, T5, T6, T7> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x40AD360", Offset = "0x40AB960", VA = "0x1840AD360", Slot = "87")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(GGHLJLKEFEL.MIGJDFFBJLL<T1, T2, T3, T4, T5, T6, T7, T8> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x40ACC00", Offset = "0x40AB200", VA = "0x1840ACC00", Slot = "88")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(GGHLJLKEFEL.HPDJJEHMLLC<T1, T2, T3, T4, T5, T6, T7, T8, T9> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x40AC810", Offset = "0x40AAE10", VA = "0x1840AC810", Slot = "16")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(NHPBLGMFGLH HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x40ABFE0", Offset = "0x40AA5E0", VA = "0x1840ABFE0", Slot = "89")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(DDBPFNMMCAA HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB, T11 KMLOFCOIBFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x40AB280", Offset = "0x40A9880", VA = "0x1840AB280", Slot = "90")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(DPLODLFNDDN HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB, T11 KMLOFCOIBFC, T12 OIILEKLFCKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x40AA8A0", Offset = "0x40A8EA0", VA = "0x1840AA8A0", Slot = "91")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(LHEMOAEHDMP HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB, T11 KMLOFCOIBFC, T12 OIILEKLFCKI, T13 NJGIIMMGHEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x40AA360", Offset = "0x40A8960", VA = "0x1840AA360", Slot = "92")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BLBLFCOABBE HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB, T11 KMLOFCOIBFC, T12 OIILEKLFCKI, T13 NJGIIMMGHEG, T14 MDPIEPACCGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x8646080", Offset = "0x8644680", VA = "0x188646080", Slot = "93")]
		public void RpcOthers(GGHLJLKEFEL.EFOFIPPGKNL<KFPLHECPDME> HEPPOGGJMKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x40A2180", Offset = "0x40A0780", VA = "0x1840A2180", Slot = "94")]
		public void RpcOthers<T1>(GGHLJLKEFEL.JNBHLPMDPKA<T1, KFPLHECPDME> HEPPOGGJMKL, T1 LMANKJPDGIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x40A1FA0", Offset = "0x40A05A0", VA = "0x1840A1FA0", Slot = "95")]
		public void RpcOthers<T1, T2>(GGHLJLKEFEL.KPAAMMMKJOC<T1, T2, KFPLHECPDME> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x40A2EB0", Offset = "0x40A14B0", VA = "0x1840A2EB0", Slot = "96")]
		public void RpcOthers<T1, T2, T3>(GGHLJLKEFEL.CLOCENELBFM<T1, T2, T3, KFPLHECPDME> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x40A90D0", Offset = "0x40A76D0", VA = "0x1840A90D0", Slot = "97")]
		public void RpcOthers<T1, T2, T3, T4>(GGHLJLKEFEL.JODGEDHHKBJ<T1, T2, T3, T4, KFPLHECPDME> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x40A93B0", Offset = "0x40A79B0", VA = "0x1840A93B0", Slot = "98")]
		public void RpcOthers<T1, T2, T3, T4, T5>(GGHLJLKEFEL.ONBHLILFLJA<T1, T2, T3, T4, T5, KFPLHECPDME> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x40A96F0", Offset = "0x40A7CF0", VA = "0x1840A96F0", Slot = "99")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(GGHLJLKEFEL.CMEEMNFELJP<T1, T2, T3, T4, T5, T6, KFPLHECPDME> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x40ADD30", Offset = "0x40AC330", VA = "0x1840ADD30", Slot = "100")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(GGHLJLKEFEL.MIGJDFFBJLL<T1, T2, T3, T4, T5, T6, T7, KFPLHECPDME> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x40AD6C0", Offset = "0x40ABCC0", VA = "0x1840AD6C0", Slot = "101")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(GGHLJLKEFEL.HPDJJEHMLLC<T1, T2, T3, T4, T5, T6, T7, T8, KFPLHECPDME> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x40ACFB0", Offset = "0x40AB5B0", VA = "0x1840ACFB0", Slot = "102")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(NHPBLGMFGLH HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x40AC420", Offset = "0x40AAA20", VA = "0x1840AC420", Slot = "103")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(DDBPFNMMCAA HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x40ABBA0", Offset = "0x40AA1A0", VA = "0x1840ABBA0", Slot = "104")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(DPLODLFNDDN HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB, T11 KMLOFCOIBFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x40AB710", Offset = "0x40A9D10", VA = "0x1840AB710", Slot = "105")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(LHEMOAEHDMP HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB, T11 KMLOFCOIBFC, T12 OIILEKLFCKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x40AAD90", Offset = "0x40A9390", VA = "0x1840AAD90", Slot = "106")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BLBLFCOABBE HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB, T11 KMLOFCOIBFC, T12 OIILEKLFCKI, T13 NJGIIMMGHEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x40A9E20", Offset = "0x40A8420", VA = "0x1840A9E20", Slot = "107")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(PLBMPGOKEFB HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB, T11 KMLOFCOIBFC, T12 OIILEKLFCKI, T13 NJGIIMMGHEG, T14 MDPIEPACCGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x8645A20", Offset = "0x8644020", VA = "0x188645A20", Slot = "108")]
		public void RpcMaster(GGHLJLKEFEL.GCDLJGLLLFE HEPPOGGJMKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x4091EF0", Offset = "0x40904F0", VA = "0x184091EF0", Slot = "109")]
		public void RpcMaster<T1>(GGHLJLKEFEL.EFOFIPPGKNL<T1> HEPPOGGJMKL, T1 LMANKJPDGIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x4092280", Offset = "0x4090880", VA = "0x184092280", Slot = "17")]
		public void RpcMaster<T1, T2>(GGHLJLKEFEL.JNBHLPMDPKA<T1, T2> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x4091640", Offset = "0x408FC40", VA = "0x184091640", Slot = "110")]
		public void RpcMaster<T1, T2, T3>(GGHLJLKEFEL.KPAAMMMKJOC<T1, T2, T3> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x40918E0", Offset = "0x408FEE0", VA = "0x1840918E0", Slot = "111")]
		public void RpcMaster<T1, T2, T3, T4>(GGHLJLKEFEL.CLOCENELBFM<T1, T2, T3, T4> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x4095900", Offset = "0x4093F00", VA = "0x184095900", Slot = "112")]
		public void RpcMaster<T1, T2, T3, T4, T5>(GGHLJLKEFEL.JODGEDHHKBJ<T1, T2, T3, T4, T5> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x4097CD0", Offset = "0x40962D0", VA = "0x184097CD0", Slot = "113")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(GGHLJLKEFEL.ONBHLILFLJA<T1, T2, T3, T4, T5, T6> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x409D880", Offset = "0x409BE80", VA = "0x18409D880", Slot = "114")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(GGHLJLKEFEL.CMEEMNFELJP<T1, T2, T3, T4, T5, T6, T7> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x409D030", Offset = "0x409B630", VA = "0x18409D030", Slot = "115")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(GGHLJLKEFEL.MIGJDFFBJLL<T1, T2, T3, T4, T5, T6, T7, T8> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x409C720", Offset = "0x409AD20", VA = "0x18409C720", Slot = "116")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(GGHLJLKEFEL.HPDJJEHMLLC<T1, T2, T3, T4, T5, T6, T7, T8, T9> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x40950D0", Offset = "0x40936D0", VA = "0x1840950D0", Slot = "117")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(NHPBLGMFGLH HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x4093D00", Offset = "0x4092300", VA = "0x184093D00", Slot = "118")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(DDBPFNMMCAA HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB, T11 KMLOFCOIBFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x409A780", Offset = "0x4098D80", VA = "0x18409A780", Slot = "119")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(DPLODLFNDDN HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB, T11 KMLOFCOIBFC, T12 OIILEKLFCKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x409A1A0", Offset = "0x40987A0", VA = "0x18409A1A0", Slot = "120")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(LHEMOAEHDMP HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB, T11 KMLOFCOIBFC, T12 OIILEKLFCKI, T13 NJGIIMMGHEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x4099530", Offset = "0x4097B30", VA = "0x184099530", Slot = "121")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BLBLFCOABBE HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB, T11 KMLOFCOIBFC, T12 OIILEKLFCKI, T13 NJGIIMMGHEG, T14 MDPIEPACCGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x8645BB0", Offset = "0x86441B0", VA = "0x188645BB0", Slot = "122")]
		public void RpcMaster(GGHLJLKEFEL.EFOFIPPGKNL<KFPLHECPDME> HEPPOGGJMKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x4092090", Offset = "0x4090690", VA = "0x184092090", Slot = "123")]
		public void RpcMaster<T1>(GGHLJLKEFEL.JNBHLPMDPKA<T1, KFPLHECPDME> HEPPOGGJMKL, T1 LMANKJPDGIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x4092F20", Offset = "0x4091520", VA = "0x184092F20", Slot = "124")]
		public void RpcMaster<T1, T2>(GGHLJLKEFEL.KPAAMMMKJOC<T1, T2, KFPLHECPDME> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x40924D0", Offset = "0x4090AD0", VA = "0x1840924D0", Slot = "125")]
		public void RpcMaster<T1, T2, T3>(GGHLJLKEFEL.CLOCENELBFM<T1, T2, T3, KFPLHECPDME> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x409ECF0", Offset = "0x409D2F0", VA = "0x18409ECF0", Slot = "126")]
		public void RpcMaster<T1, T2, T3, T4>(GGHLJLKEFEL.JODGEDHHKBJ<T1, T2, T3, T4, KFPLHECPDME> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x4096320", Offset = "0x4094920", VA = "0x184096320", Slot = "127")]
		public void RpcMaster<T1, T2, T3, T4, T5>(GGHLJLKEFEL.ONBHLILFLJA<T1, T2, T3, T4, T5, KFPLHECPDME> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x409E340", Offset = "0x409C940", VA = "0x18409E340", Slot = "128")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(GGHLJLKEFEL.CMEEMNFELJP<T1, T2, T3, T4, T5, T6, KFPLHECPDME> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x409DC20", Offset = "0x409C220", VA = "0x18409DC20", Slot = "129")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(GGHLJLKEFEL.MIGJDFFBJLL<T1, T2, T3, T4, T5, T6, T7, KFPLHECPDME> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x409D430", Offset = "0x409BA30", VA = "0x18409D430", Slot = "130")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(GGHLJLKEFEL.HPDJJEHMLLC<T1, T2, T3, T4, T5, T6, T7, T8, KFPLHECPDME> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x409CB80", Offset = "0x409B180", VA = "0x18409CB80", Slot = "131")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(NHPBLGMFGLH HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x409C210", Offset = "0x409A810", VA = "0x18409C210", Slot = "132")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(DDBPFNMMCAA HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x409B2C0", Offset = "0x40998C0", VA = "0x18409B2C0", Slot = "133")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(DPLODLFNDDN HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB, T11 KMLOFCOIBFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x409ACF0", Offset = "0x40992F0", VA = "0x18409ACF0", Slot = "134")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(LHEMOAEHDMP HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB, T11 KMLOFCOIBFC, T12 OIILEKLFCKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x4099B70", Offset = "0x4098170", VA = "0x184099B70", Slot = "135")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BLBLFCOABBE HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB, T11 KMLOFCOIBFC, T12 OIILEKLFCKI, T13 NJGIIMMGHEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x4098EA0", Offset = "0x40974A0", VA = "0x184098EA0", Slot = "136")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(PLBMPGOKEFB HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB, T11 KMLOFCOIBFC, T12 OIILEKLFCKI, T13 NJGIIMMGHEG, T14 MDPIEPACCGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x8645610", Offset = "0x8643C10", VA = "0x188645610", Slot = "137")]
		public void RpcAuthority(GGHLJLKEFEL.GCDLJGLLLFE HEPPOGGJMKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x40856C0", Offset = "0x4083CC0", VA = "0x1840856C0", Slot = "138")]
		public void RpcAuthority<T1>(GGHLJLKEFEL.EFOFIPPGKNL<T1> HEPPOGGJMKL, T1 LMANKJPDGIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x4086F70", Offset = "0x4085570", VA = "0x184086F70", Slot = "139")]
		public void RpcAuthority<T1, T2>(GGHLJLKEFEL.JNBHLPMDPKA<T1, T2> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x4087720", Offset = "0x4085D20", VA = "0x184087720", Slot = "140")]
		public void RpcAuthority<T1, T2, T3>(GGHLJLKEFEL.KPAAMMMKJOC<T1, T2, T3> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x4086C40", Offset = "0x4085240", VA = "0x184086C40", Slot = "141")]
		public void RpcAuthority<T1, T2, T3, T4>(GGHLJLKEFEL.CLOCENELBFM<T1, T2, T3, T4> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x40852C0", Offset = "0x40838C0", VA = "0x1840852C0", Slot = "142")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(GGHLJLKEFEL.JODGEDHHKBJ<T1, T2, T3, T4, T5> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x408D5A0", Offset = "0x408BBA0", VA = "0x18408D5A0", Slot = "143")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(GGHLJLKEFEL.ONBHLILFLJA<T1, T2, T3, T4, T5, T6> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x408CE30", Offset = "0x408B430", VA = "0x18408CE30", Slot = "144")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(GGHLJLKEFEL.CMEEMNFELJP<T1, T2, T3, T4, T5, T6, T7> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x408C1C0", Offset = "0x408A7C0", VA = "0x18408C1C0", Slot = "145")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(GGHLJLKEFEL.MIGJDFFBJLL<T1, T2, T3, T4, T5, T6, T7, T8> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x408B890", Offset = "0x4089E90", VA = "0x18408B890", Slot = "146")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(GGHLJLKEFEL.HPDJJEHMLLC<T1, T2, T3, T4, T5, T6, T7, T8, T9> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x408AEA0", Offset = "0x40894A0", VA = "0x18408AEA0", Slot = "147")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(NHPBLGMFGLH HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x408A970", Offset = "0x4088F70", VA = "0x18408A970", Slot = "148")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(DDBPFNMMCAA HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB, T11 KMLOFCOIBFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x4085880", Offset = "0x4083E80", VA = "0x184085880", Slot = "149")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(DPLODLFNDDN HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB, T11 KMLOFCOIBFC, T12 OIILEKLFCKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x4089290", Offset = "0x4087890", VA = "0x184089290", Slot = "150")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(LHEMOAEHDMP HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB, T11 KMLOFCOIBFC, T12 OIILEKLFCKI, T13 NJGIIMMGHEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x4088600", Offset = "0x4086C00", VA = "0x184088600", Slot = "151")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BLBLFCOABBE HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB, T11 KMLOFCOIBFC, T12 OIILEKLFCKI, T13 NJGIIMMGHEG, T14 MDPIEPACCGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x86457C0", Offset = "0x8643DC0", VA = "0x1886457C0", Slot = "152")]
		public void RpcAuthority(GGHLJLKEFEL.EFOFIPPGKNL<KFPLHECPDME> HEPPOGGJMKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x408FAA0", Offset = "0x408E0A0", VA = "0x18408FAA0", Slot = "153")]
		public void RpcAuthority<T1>(GGHLJLKEFEL.JNBHLPMDPKA<T1, KFPLHECPDME> HEPPOGGJMKL, T1 LMANKJPDGIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x408EBE0", Offset = "0x408D1E0", VA = "0x18408EBE0", Slot = "154")]
		public void RpcAuthority<T1, T2>(GGHLJLKEFEL.KPAAMMMKJOC<T1, T2, KFPLHECPDME> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x408E6F0", Offset = "0x408CCF0", VA = "0x18408E6F0", Slot = "155")]
		public void RpcAuthority<T1, T2, T3>(GGHLJLKEFEL.CLOCENELBFM<T1, T2, T3, KFPLHECPDME> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x408DF40", Offset = "0x408C540", VA = "0x18408DF40", Slot = "156")]
		public void RpcAuthority<T1, T2, T3, T4>(GGHLJLKEFEL.JODGEDHHKBJ<T1, T2, T3, T4, KFPLHECPDME> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x408DBF0", Offset = "0x408C1F0", VA = "0x18408DBF0", Slot = "157")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(GGHLJLKEFEL.ONBHLILFLJA<T1, T2, T3, T4, T5, KFPLHECPDME> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x408D1F0", Offset = "0x408B7F0", VA = "0x18408D1F0", Slot = "158")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(GGHLJLKEFEL.CMEEMNFELJP<T1, T2, T3, T4, T5, T6, KFPLHECPDME> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x408CA30", Offset = "0x408B030", VA = "0x18408CA30", Slot = "159")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(GGHLJLKEFEL.MIGJDFFBJLL<T1, T2, T3, T4, T5, T6, T7, KFPLHECPDME> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x408C5D0", Offset = "0x408ABD0", VA = "0x18408C5D0", Slot = "160")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(GGHLJLKEFEL.HPDJJEHMLLC<T1, T2, T3, T4, T5, T6, T7, T8, KFPLHECPDME> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x408BD00", Offset = "0x408A300", VA = "0x18408BD00", Slot = "161")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(NHPBLGMFGLH HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x408B370", Offset = "0x4089970", VA = "0x18408B370", Slot = "162")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(DDBPFNMMCAA HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x408A3F0", Offset = "0x40889F0", VA = "0x18408A3F0", Slot = "163")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(DPLODLFNDDN HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB, T11 KMLOFCOIBFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x4089880", Offset = "0x4087E80", VA = "0x184089880", Slot = "164")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(LHEMOAEHDMP HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB, T11 KMLOFCOIBFC, T12 OIILEKLFCKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x4088C50", Offset = "0x4087250", VA = "0x184088C50", Slot = "165")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BLBLFCOABBE HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB, T11 KMLOFCOIBFC, T12 OIILEKLFCKI, T13 NJGIIMMGHEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x4087F60", Offset = "0x4086560", VA = "0x184087F60", Slot = "166")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(PLBMPGOKEFB HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB, T11 KMLOFCOIBFC, T12 OIILEKLFCKI, T13 NJGIIMMGHEG, T14 MDPIEPACCGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x86461D0", Offset = "0x86447D0", VA = "0x1886461D0", Slot = "18")]
		public void RpcPlayer(MEINMPIOLGA AGIMJJDFEAF, GGHLJLKEFEL.GCDLJGLLLFE HEPPOGGJMKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x40B0200", Offset = "0x40AE800", VA = "0x1840B0200", Slot = "19")]
		public void RpcPlayer<T1>(MEINMPIOLGA AGIMJJDFEAF, GGHLJLKEFEL.EFOFIPPGKNL<T1> HEPPOGGJMKL, T1 LMANKJPDGIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x40B0F70", Offset = "0x40AF570", VA = "0x1840B0F70", Slot = "20")]
		public void RpcPlayer<T1, T2>(MEINMPIOLGA AGIMJJDFEAF, GGHLJLKEFEL.JNBHLPMDPKA<T1, T2> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x40B0990", Offset = "0x40AEF90", VA = "0x1840B0990", Slot = "21")]
		public void RpcPlayer<T1, T2, T3>(MEINMPIOLGA AGIMJJDFEAF, GGHLJLKEFEL.KPAAMMMKJOC<T1, T2, T3> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x40B03D0", Offset = "0x40AE9D0", VA = "0x1840B03D0", Slot = "22")]
		public void RpcPlayer<T1, T2, T3, T4>(MEINMPIOLGA AGIMJJDFEAF, GGHLJLKEFEL.CLOCENELBFM<T1, T2, T3, T4> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x40B47B0", Offset = "0x40B2DB0", VA = "0x1840B47B0", Slot = "167")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(MEINMPIOLGA AGIMJJDFEAF, GGHLJLKEFEL.JODGEDHHKBJ<T1, T2, T3, T4, T5> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x40B4350", Offset = "0x40B2950", VA = "0x1840B4350", Slot = "168")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(MEINMPIOLGA AGIMJJDFEAF, GGHLJLKEFEL.ONBHLILFLJA<T1, T2, T3, T4, T5, T6> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x40B4B90", Offset = "0x40B3190", VA = "0x1840B4B90", Slot = "169")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(MEINMPIOLGA AGIMJJDFEAF, GGHLJLKEFEL.CMEEMNFELJP<T1, T2, T3, T4, T5, T6, T7> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x40B5050", Offset = "0x40B3650", VA = "0x1840B5050", Slot = "170")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(MEINMPIOLGA AGIMJJDFEAF, GGHLJLKEFEL.MIGJDFFBJLL<T1, T2, T3, T4, T5, T6, T7, T8> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x40BB710", Offset = "0x40B9D10", VA = "0x1840BB710", Slot = "171")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(MEINMPIOLGA AGIMJJDFEAF, GGHLJLKEFEL.HPDJJEHMLLC<T1, T2, T3, T4, T5, T6, T7, T8, T9> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x40BA820", Offset = "0x40B8E20", VA = "0x1840BA820", Slot = "172")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(MEINMPIOLGA AGIMJJDFEAF, NHPBLGMFGLH HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x40B1830", Offset = "0x40AFE30", VA = "0x1840B1830", Slot = "23")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(MEINMPIOLGA AGIMJJDFEAF, DDBPFNMMCAA HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB, T11 KMLOFCOIBFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x40B91C0", Offset = "0x40B77C0", VA = "0x1840B91C0", Slot = "173")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(MEINMPIOLGA AGIMJJDFEAF, DPLODLFNDDN HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB, T11 KMLOFCOIBFC, T12 OIILEKLFCKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x40B8560", Offset = "0x40B6B60", VA = "0x1840B8560", Slot = "174")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(MEINMPIOLGA AGIMJJDFEAF, LHEMOAEHDMP HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB, T11 KMLOFCOIBFC, T12 OIILEKLFCKI, T13 NJGIIMMGHEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x40B7EF0", Offset = "0x40B64F0", VA = "0x1840B7EF0", Slot = "175")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(MEINMPIOLGA AGIMJJDFEAF, BLBLFCOABBE HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB, T11 KMLOFCOIBFC, T12 OIILEKLFCKI, T13 NJGIIMMGHEG, T14 MDPIEPACCGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x86463D0", Offset = "0x86449D0", VA = "0x1886463D0", Slot = "176")]
		public void RpcPlayer(MEINMPIOLGA AGIMJJDFEAF, GGHLJLKEFEL.EFOFIPPGKNL<KFPLHECPDME> HEPPOGGJMKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x40B0760", Offset = "0x40AED60", VA = "0x1840B0760", Slot = "177")]
		public void RpcPlayer<T1>(MEINMPIOLGA AGIMJJDFEAF, GGHLJLKEFEL.JNBHLPMDPKA<T1, KFPLHECPDME> HEPPOGGJMKL, T1 LMANKJPDGIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x40B1550", Offset = "0x40AFB50", VA = "0x1840B1550", Slot = "24")]
		public void RpcPlayer<T1, T2>(MEINMPIOLGA AGIMJJDFEAF, GGHLJLKEFEL.KPAAMMMKJOC<T1, T2, KFPLHECPDME> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x40B11E0", Offset = "0x40AF7E0", VA = "0x1840B11E0", Slot = "25")]
		public void RpcPlayer<T1, T2, T3>(MEINMPIOLGA AGIMJJDFEAF, GGHLJLKEFEL.CLOCENELBFM<T1, T2, T3, KFPLHECPDME> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x40B3010", Offset = "0x40B1610", VA = "0x1840B3010", Slot = "178")]
		public void RpcPlayer<T1, T2, T3, T4>(MEINMPIOLGA AGIMJJDFEAF, GGHLJLKEFEL.JODGEDHHKBJ<T1, T2, T3, T4, KFPLHECPDME> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x40BD340", Offset = "0x40BB940", VA = "0x1840BD340", Slot = "179")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(MEINMPIOLGA AGIMJJDFEAF, GGHLJLKEFEL.ONBHLILFLJA<T1, T2, T3, T4, T5, KFPLHECPDME> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x40BCC20", Offset = "0x40BB220", VA = "0x1840BCC20", Slot = "180")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(MEINMPIOLGA AGIMJJDFEAF, GGHLJLKEFEL.CMEEMNFELJP<T1, T2, T3, T4, T5, T6, KFPLHECPDME> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x40BC440", Offset = "0x40BAA40", VA = "0x1840BC440", Slot = "181")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(MEINMPIOLGA AGIMJJDFEAF, GGHLJLKEFEL.MIGJDFFBJLL<T1, T2, T3, T4, T5, T6, T7, KFPLHECPDME> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x40BBFC0", Offset = "0x40BA5C0", VA = "0x1840BBFC0", Slot = "182")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(MEINMPIOLGA AGIMJJDFEAF, GGHLJLKEFEL.HPDJJEHMLLC<T1, T2, T3, T4, T5, T6, T7, T8, KFPLHECPDME> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x40BB240", Offset = "0x40B9840", VA = "0x1840BB240", Slot = "183")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(MEINMPIOLGA AGIMJJDFEAF, NHPBLGMFGLH HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x40BAD10", Offset = "0x40B9310", VA = "0x1840BAD10", Slot = "184")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(MEINMPIOLGA AGIMJJDFEAF, DDBPFNMMCAA HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x40B9D50", Offset = "0x40B8350", VA = "0x1840B9D50", Slot = "185")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(MEINMPIOLGA AGIMJJDFEAF, DPLODLFNDDN HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB, T11 KMLOFCOIBFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x40B9760", Offset = "0x40B7D60", VA = "0x1840B9760", Slot = "186")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(MEINMPIOLGA AGIMJJDFEAF, LHEMOAEHDMP HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB, T11 KMLOFCOIBFC, T12 OIILEKLFCKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x40B8B70", Offset = "0x40B7170", VA = "0x1840B8B70", Slot = "187")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(MEINMPIOLGA AGIMJJDFEAF, BLBLFCOABBE HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB, T11 KMLOFCOIBFC, T12 OIILEKLFCKI, T13 NJGIIMMGHEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x40B7830", Offset = "0x40B5E30", VA = "0x1840B7830", Slot = "188")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(MEINMPIOLGA AGIMJJDFEAF, PLBMPGOKEFB HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB, T11 KMLOFCOIBFC, T12 OIILEKLFCKI, T13 NJGIIMMGHEG, T14 MDPIEPACCGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x8644F70", Offset = "0x8643570", VA = "0x188644F70", Slot = "189")]
		public void RpcAllBuffered(JPMIBEBBNEJ GFFMDEHNHBE, GGHLJLKEFEL.GCDLJGLLLFE HEPPOGGJMKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x4071CF0", Offset = "0x40702F0", VA = "0x184071CF0", Slot = "190")]
		public void RpcAllBuffered<T1>(JPMIBEBBNEJ GFFMDEHNHBE, GGHLJLKEFEL.EFOFIPPGKNL<T1> HEPPOGGJMKL, T1 LMANKJPDGIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x4071A60", Offset = "0x4070060", VA = "0x184071A60", Slot = "191")]
		public void RpcAllBuffered<T1, T2>(JPMIBEBBNEJ GFFMDEHNHBE, GGHLJLKEFEL.JNBHLPMDPKA<T1, T2> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x4071730", Offset = "0x406FD30", VA = "0x184071730", Slot = "192")]
		public void RpcAllBuffered<T1, T2, T3>(JPMIBEBBNEJ GFFMDEHNHBE, GGHLJLKEFEL.KPAAMMMKJOC<T1, T2, T3> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x4071150", Offset = "0x406F750", VA = "0x184071150", Slot = "193")]
		public void RpcAllBuffered<T1, T2, T3, T4>(JPMIBEBBNEJ GFFMDEHNHBE, GGHLJLKEFEL.CLOCENELBFM<T1, T2, T3, T4> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x4070CB0", Offset = "0x406F2B0", VA = "0x184070CB0", Slot = "194")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(JPMIBEBBNEJ GFFMDEHNHBE, GGHLJLKEFEL.JODGEDHHKBJ<T1, T2, T3, T4, T5> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x4070A10", Offset = "0x406F010", VA = "0x184070A10", Slot = "195")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(JPMIBEBBNEJ GFFMDEHNHBE, GGHLJLKEFEL.ONBHLILFLJA<T1, T2, T3, T4, T5, T6> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x4070190", Offset = "0x406E790", VA = "0x184070190", Slot = "196")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(JPMIBEBBNEJ GFFMDEHNHBE, GGHLJLKEFEL.CMEEMNFELJP<T1, T2, T3, T4, T5, T6, T7> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x406FB10", Offset = "0x406E110", VA = "0x18406FB10", Slot = "197")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(JPMIBEBBNEJ GFFMDEHNHBE, GGHLJLKEFEL.MIGJDFFBJLL<T1, T2, T3, T4, T5, T6, T7, T8> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x406F3F0", Offset = "0x406D9F0", VA = "0x18406F3F0", Slot = "198")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(JPMIBEBBNEJ GFFMDEHNHBE, GGHLJLKEFEL.HPDJJEHMLLC<T1, T2, T3, T4, T5, T6, T7, T8, T9> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x406F010", Offset = "0x406D610", VA = "0x18406F010", Slot = "199")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(JPMIBEBBNEJ GFFMDEHNHBE, NHPBLGMFGLH HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x406E800", Offset = "0x406CE00", VA = "0x18406E800", Slot = "200")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(JPMIBEBBNEJ GFFMDEHNHBE, DDBPFNMMCAA HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB, T11 KMLOFCOIBFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x406DF50", Offset = "0x406C550", VA = "0x18406DF50", Slot = "201")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(JPMIBEBBNEJ GFFMDEHNHBE, DPLODLFNDDN HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB, T11 KMLOFCOIBFC, T12 OIILEKLFCKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x406D130", Offset = "0x406B730", VA = "0x18406D130", Slot = "202")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(JPMIBEBBNEJ GFFMDEHNHBE, LHEMOAEHDMP HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB, T11 KMLOFCOIBFC, T12 OIILEKLFCKI, T13 NJGIIMMGHEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x406C6F0", Offset = "0x406ACF0", VA = "0x18406C6F0", Slot = "203")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(JPMIBEBBNEJ GFFMDEHNHBE, BLBLFCOABBE HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB, T11 KMLOFCOIBFC, T12 OIILEKLFCKI, T13 NJGIIMMGHEG, T14 MDPIEPACCGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x8644ED0", Offset = "0x86434D0", VA = "0x188644ED0", Slot = "204")]
		public void RpcAllBuffered(JPMIBEBBNEJ GFFMDEHNHBE, GGHLJLKEFEL.EFOFIPPGKNL<KFPLHECPDME> HEPPOGGJMKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x4071BD0", Offset = "0x40701D0", VA = "0x184071BD0", Slot = "205")]
		public void RpcAllBuffered<T1>(JPMIBEBBNEJ GFFMDEHNHBE, GGHLJLKEFEL.JNBHLPMDPKA<T1, KFPLHECPDME> HEPPOGGJMKL, T1 LMANKJPDGIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x40718F0", Offset = "0x406FEF0", VA = "0x1840718F0", Slot = "206")]
		public void RpcAllBuffered<T1, T2>(JPMIBEBBNEJ GFFMDEHNHBE, GGHLJLKEFEL.KPAAMMMKJOC<T1, T2, KFPLHECPDME> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x4071570", Offset = "0x406FB70", VA = "0x184071570", Slot = "207")]
		public void RpcAllBuffered<T1, T2, T3>(JPMIBEBBNEJ GFFMDEHNHBE, GGHLJLKEFEL.CLOCENELBFM<T1, T2, T3, KFPLHECPDME> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x4071360", Offset = "0x406F960", VA = "0x184071360", Slot = "208")]
		public void RpcAllBuffered<T1, T2, T3, T4>(JPMIBEBBNEJ GFFMDEHNHBE, GGHLJLKEFEL.JODGEDHHKBJ<T1, T2, T3, T4, KFPLHECPDME> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x4070F00", Offset = "0x406F500", VA = "0x184070F00", Slot = "209")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(JPMIBEBBNEJ GFFMDEHNHBE, GGHLJLKEFEL.ONBHLILFLJA<T1, T2, T3, T4, T5, KFPLHECPDME> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x4070770", Offset = "0x406ED70", VA = "0x184070770", Slot = "210")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(JPMIBEBBNEJ GFFMDEHNHBE, GGHLJLKEFEL.CMEEMNFELJP<T1, T2, T3, T4, T5, T6, KFPLHECPDME> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x4070480", Offset = "0x406EA80", VA = "0x184070480", Slot = "211")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(JPMIBEBBNEJ GFFMDEHNHBE, GGHLJLKEFEL.MIGJDFFBJLL<T1, T2, T3, T4, T5, T6, T7, KFPLHECPDME> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x406FE50", Offset = "0x406E450", VA = "0x18406FE50", Slot = "212")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(JPMIBEBBNEJ GFFMDEHNHBE, GGHLJLKEFEL.HPDJJEHMLLC<T1, T2, T3, T4, T5, T6, T7, T8, KFPLHECPDME> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x406F780", Offset = "0x406DD80", VA = "0x18406F780", Slot = "213")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(JPMIBEBBNEJ GFFMDEHNHBE, NHPBLGMFGLH HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x406EC30", Offset = "0x406D230", VA = "0x18406EC30", Slot = "214")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(JPMIBEBBNEJ GFFMDEHNHBE, DDBPFNMMCAA HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x406E3D0", Offset = "0x406C9D0", VA = "0x18406E3D0", Slot = "215")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(JPMIBEBBNEJ GFFMDEHNHBE, DPLODLFNDDN HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB, T11 KMLOFCOIBFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x406DAD0", Offset = "0x406C0D0", VA = "0x18406DAD0", Slot = "216")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(JPMIBEBBNEJ GFFMDEHNHBE, LHEMOAEHDMP HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB, T11 KMLOFCOIBFC, T12 OIILEKLFCKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x406D600", Offset = "0x406BC00", VA = "0x18406D600", Slot = "217")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(JPMIBEBBNEJ GFFMDEHNHBE, BLBLFCOABBE HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB, T11 KMLOFCOIBFC, T12 OIILEKLFCKI, T13 NJGIIMMGHEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x406CC10", Offset = "0x406B210", VA = "0x18406CC10", Slot = "218")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(JPMIBEBBNEJ GFFMDEHNHBE, PLBMPGOKEFB HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB, T11 KMLOFCOIBFC, T12 OIILEKLFCKI, T13 NJGIIMMGHEG, T14 MDPIEPACCGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x8645DF0", Offset = "0x86443F0", VA = "0x188645DF0", Slot = "219")]
		public void RpcOthersBuffered(JPMIBEBBNEJ GFFMDEHNHBE, GGHLJLKEFEL.GCDLJGLLLFE HEPPOGGJMKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x40A8FB0", Offset = "0x40A75B0", VA = "0x1840A8FB0", Slot = "220")]
		public void RpcOthersBuffered<T1>(JPMIBEBBNEJ GFFMDEHNHBE, GGHLJLKEFEL.EFOFIPPGKNL<T1> HEPPOGGJMKL, T1 LMANKJPDGIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x40A8BB0", Offset = "0x40A71B0", VA = "0x1840A8BB0", Slot = "221")]
		public void RpcOthersBuffered<T1, T2>(JPMIBEBBNEJ GFFMDEHNHBE, GGHLJLKEFEL.JNBHLPMDPKA<T1, T2> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x40A89F0", Offset = "0x40A6FF0", VA = "0x1840A89F0", Slot = "222")]
		public void RpcOthersBuffered<T1, T2, T3>(JPMIBEBBNEJ GFFMDEHNHBE, GGHLJLKEFEL.KPAAMMMKJOC<T1, T2, T3> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x40A8620", Offset = "0x40A6C20", VA = "0x1840A8620", Slot = "223")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(JPMIBEBBNEJ GFFMDEHNHBE, GGHLJLKEFEL.CLOCENELBFM<T1, T2, T3, T4> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x40A81C0", Offset = "0x40A67C0", VA = "0x1840A81C0", Slot = "224")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(JPMIBEBBNEJ GFFMDEHNHBE, GGHLJLKEFEL.JODGEDHHKBJ<T1, T2, T3, T4, T5> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x40A7CD0", Offset = "0x40A62D0", VA = "0x1840A7CD0", Slot = "225")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(JPMIBEBBNEJ GFFMDEHNHBE, GGHLJLKEFEL.ONBHLILFLJA<T1, T2, T3, T4, T5, T6> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x40A7450", Offset = "0x40A5A50", VA = "0x1840A7450", Slot = "226")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(JPMIBEBBNEJ GFFMDEHNHBE, GGHLJLKEFEL.CMEEMNFELJP<T1, T2, T3, T4, T5, T6, T7> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x40A6DD0", Offset = "0x40A53D0", VA = "0x1840A6DD0", Slot = "227")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(JPMIBEBBNEJ GFFMDEHNHBE, GGHLJLKEFEL.MIGJDFFBJLL<T1, T2, T3, T4, T5, T6, T7, T8> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x40A6A40", Offset = "0x40A5040", VA = "0x1840A6A40", Slot = "228")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(JPMIBEBBNEJ GFFMDEHNHBE, GGHLJLKEFEL.HPDJJEHMLLC<T1, T2, T3, T4, T5, T6, T7, T8, T9> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x40A5EF0", Offset = "0x40A44F0", VA = "0x1840A5EF0", Slot = "229")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(JPMIBEBBNEJ GFFMDEHNHBE, NHPBLGMFGLH HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x40A5AC0", Offset = "0x40A40C0", VA = "0x1840A5AC0", Slot = "230")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(JPMIBEBBNEJ GFFMDEHNHBE, DDBPFNMMCAA HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB, T11 KMLOFCOIBFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x40A5210", Offset = "0x40A3810", VA = "0x1840A5210", Slot = "231")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(JPMIBEBBNEJ GFFMDEHNHBE, DPLODLFNDDN HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB, T11 KMLOFCOIBFC, T12 OIILEKLFCKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x40A43F0", Offset = "0x40A29F0", VA = "0x1840A43F0", Slot = "232")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(JPMIBEBBNEJ GFFMDEHNHBE, LHEMOAEHDMP HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB, T11 KMLOFCOIBFC, T12 OIILEKLFCKI, T13 NJGIIMMGHEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x40A39B0", Offset = "0x40A1FB0", VA = "0x1840A39B0", Slot = "233")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(JPMIBEBBNEJ GFFMDEHNHBE, BLBLFCOABBE HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB, T11 KMLOFCOIBFC, T12 OIILEKLFCKI, T13 NJGIIMMGHEG, T14 MDPIEPACCGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x8645E90", Offset = "0x8644490", VA = "0x188645E90", Slot = "234")]
		public void RpcOthersBuffered(JPMIBEBBNEJ GFFMDEHNHBE, GGHLJLKEFEL.EFOFIPPGKNL<KFPLHECPDME> HEPPOGGJMKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x40A8E90", Offset = "0x40A7490", VA = "0x1840A8E90", Slot = "235")]
		public void RpcOthersBuffered<T1>(JPMIBEBBNEJ GFFMDEHNHBE, GGHLJLKEFEL.JNBHLPMDPKA<T1, KFPLHECPDME> HEPPOGGJMKL, T1 LMANKJPDGIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x40A8D20", Offset = "0x40A7320", VA = "0x1840A8D20", Slot = "236")]
		public void RpcOthersBuffered<T1, T2>(JPMIBEBBNEJ GFFMDEHNHBE, GGHLJLKEFEL.KPAAMMMKJOC<T1, T2, KFPLHECPDME> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x40A8830", Offset = "0x40A6E30", VA = "0x1840A8830", Slot = "237")]
		public void RpcOthersBuffered<T1, T2, T3>(JPMIBEBBNEJ GFFMDEHNHBE, GGHLJLKEFEL.CLOCENELBFM<T1, T2, T3, KFPLHECPDME> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x40A8410", Offset = "0x40A6A10", VA = "0x1840A8410", Slot = "238")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(JPMIBEBBNEJ GFFMDEHNHBE, GGHLJLKEFEL.JODGEDHHKBJ<T1, T2, T3, T4, KFPLHECPDME> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x40A7F70", Offset = "0x40A6570", VA = "0x1840A7F70", Slot = "239")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(JPMIBEBBNEJ GFFMDEHNHBE, GGHLJLKEFEL.ONBHLILFLJA<T1, T2, T3, T4, T5, KFPLHECPDME> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x40A7A30", Offset = "0x40A6030", VA = "0x1840A7A30", Slot = "240")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(JPMIBEBBNEJ GFFMDEHNHBE, GGHLJLKEFEL.CMEEMNFELJP<T1, T2, T3, T4, T5, T6, KFPLHECPDME> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x40A7740", Offset = "0x40A5D40", VA = "0x1840A7740", Slot = "241")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(JPMIBEBBNEJ GFFMDEHNHBE, GGHLJLKEFEL.MIGJDFFBJLL<T1, T2, T3, T4, T5, T6, T7, KFPLHECPDME> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x40A7110", Offset = "0x40A5710", VA = "0x1840A7110", Slot = "242")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(JPMIBEBBNEJ GFFMDEHNHBE, GGHLJLKEFEL.HPDJJEHMLLC<T1, T2, T3, T4, T5, T6, T7, T8, KFPLHECPDME> HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x40A66B0", Offset = "0x40A4CB0", VA = "0x1840A66B0", Slot = "243")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(JPMIBEBBNEJ GFFMDEHNHBE, NHPBLGMFGLH HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x40A62D0", Offset = "0x40A48D0", VA = "0x1840A62D0", Slot = "244")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(JPMIBEBBNEJ GFFMDEHNHBE, DDBPFNMMCAA HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x40A5690", Offset = "0x40A3C90", VA = "0x1840A5690", Slot = "245")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(JPMIBEBBNEJ GFFMDEHNHBE, DPLODLFNDDN HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB, T11 KMLOFCOIBFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x40A4D90", Offset = "0x40A3390", VA = "0x1840A4D90", Slot = "246")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(JPMIBEBBNEJ GFFMDEHNHBE, LHEMOAEHDMP HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB, T11 KMLOFCOIBFC, T12 OIILEKLFCKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x40A48C0", Offset = "0x40A2EC0", VA = "0x1840A48C0", Slot = "247")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(JPMIBEBBNEJ GFFMDEHNHBE, BLBLFCOABBE HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB, T11 KMLOFCOIBFC, T12 OIILEKLFCKI, T13 NJGIIMMGHEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x40A3ED0", Offset = "0x40A24D0", VA = "0x1840A3ED0", Slot = "248")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(JPMIBEBBNEJ GFFMDEHNHBE, PLBMPGOKEFB HEPPOGGJMKL, T1 LMANKJPDGIF, T2 PDGABOAGCEL, T3 LEFFGKFLJLC, T4 IOPNIJIBMJI, T5 AAGMCAFFEKM, T6 PFBOJLBHMIG, T7 OBGNDPPCEHB, T8 HIEIAAIPKIG, T9 BAFKJGLEIKP, T10 GIMCALLJPMB, T11 KMLOFCOIBFC, T12 OIILEKLFCKI, T13 NJGIIMMGHEG, T14 MDPIEPACCGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x8642AB0", Offset = "0x86410B0", VA = "0x188642AB0", Slot = "249")]
		public void ClearBufferedRPCsIfMine()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x8642CD0", Offset = "0x86412D0", VA = "0x188642CD0", Slot = "250")]
		public void ClearBufferedRPCs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x2140990", Offset = "0x213EF90", VA = "0x182140990")]
		public RRNetworkView()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class NLDEKJLOHME
{
	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x863A500", Offset = "0x8638B00", VA = "0x18863A500")]
	private static bool COHPCEAMGNP(ViewId NMILEMOAODL, [Out] RRNetworkView EPNGEANGHIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x3F50280", Offset = "0x3F4E880", VA = "0x183F50280")]
	[CanBeNull]
	public static T BEKDDJNJKGN<T>(this ViewId JCBIELMJFID)
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
		private sealed class KNPMCIFDBPJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public MEINMPIOLGA[] sorted;

			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
			public KNPMCIFDBPJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x8639B20", Offset = "0x8638120", VA = "0x188639B20")]
			internal int GFBFCOLDAII(int index)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x8639A90", Offset = "0x8638090", VA = "0x188639A90")]
			internal void DIKNIFFDOAB(int index, int number)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private static readonly IPHNFELODMJ AMCHCCAPJNG;

		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public static RRPlayerNumbering instance;

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public static MEINMPIOLGA[] SortedPlayers;

		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public const string RoomPlayerIndexedProp = "rrPnr";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		internal int DMKECJKGGEJ;

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x8647350", Offset = "0x8645950", VA = "0x188647350")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x8647980", Offset = "0x8645F80", VA = "0x188647980")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x8647D50", Offset = "0x8646350", VA = "0x188647D50")]
		private void OnJoinedRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x8647DD0", Offset = "0x86463D0", VA = "0x188647DD0")]
		private void OnLeftRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x8647970", Offset = "0x8645F70", VA = "0x188647970")]
		private void KIBBKMFIEJL(MEINMPIOLGA CLDOOJMJMLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x8647970", Offset = "0x8645F70", VA = "0x188647970")]
		private void NHGHMJBFCFP(MEINMPIOLGA OCPEJEEFOOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x8647790", Offset = "0x8645D90", VA = "0x188647790")]
		private void DEALHDLGGFK(MEINMPIOLGA LNJCEAKILKK, IDictionary<object, object> GGNLIDCIJFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x8647200", Offset = "0x8645800", VA = "0x188647200")]
		public static void AssignPlayerNumbers(int GCMFJELCOEP, int FBHHMFFOIFE, Func<int, int> AFMBEMMBFEO, Action<int, int> BCECDHNCIIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x8647E80", Offset = "0x8646480", VA = "0x188647E80")]
		public void RefreshData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x8647880", Offset = "0x8645E80", VA = "0x188647880")]
		private void JGBCPPCFFGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0xAB80A0", Offset = "0xAB66A0", VA = "0x180AB80A0")]
		public RRPlayerNumbering()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class DDKHODIMDFN
{
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static readonly IPHNFELODMJ AMCHCCAPJNG;

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x8627200", Offset = "0x8625800", VA = "0x188627200")]
	public static int MBOKFEIICJF(this MEINMPIOLGA AGIMJJDFEAF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x8626E30", Offset = "0x8625430", VA = "0x188626E30")]
	public static void GELLKKJHNKK(this MEINMPIOLGA AGIMJJDFEAF, int NAOAHBKEFFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class LLDEPELKKBF
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public delegate void FBGMOHMPDIG(Hashtable MGIBLGJBEDG);

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public delegate void MJAEEBCOBII(MEINMPIOLGA AGIMJJDFEAF, Hashtable MGIBLGJBEDG);

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public static event FBGMOHMPDIG NBFNPKFGPCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x8639F60", Offset = "0x8638560", VA = "0x188639F60")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x8639EA0", Offset = "0x86384A0", VA = "0x188639EA0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public static event FBGMOHMPDIG LABCGINMABJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x863A0E0", Offset = "0x86386E0", VA = "0x18863A0E0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x8639D20", Offset = "0x8638320", VA = "0x188639D20")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public static event MJAEEBCOBII BGIMCLCGJCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x8639DE0", Offset = "0x86383E0", VA = "0x188639DE0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x863A020", Offset = "0x8638620", VA = "0x18863A020")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public static event MJAEEBCOBII CMEFNJNLNIA
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x8639C60", Offset = "0x8638260", VA = "0x188639C60")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x8639BA0", Offset = "0x86381A0", VA = "0x188639BA0")]
		[CompilerGenerated]
		remove
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal static class EEBNMMEFHFC
{
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static int ANBKKBIAHJI;

	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private static int BCPKFBNJLIO;

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static int KNEGBFLDDKI;

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x8629B90", Offset = "0x8628190", VA = "0x188629B90")]
	public static void MMHGNOOPOPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x8629BE0", Offset = "0x86281E0", VA = "0x188629BE0")]
	public static void POKJLGFNIMP(int[] FMKJNGJGICL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x86298E0", Offset = "0x8627EE0", VA = "0x1886298E0")]
	public static int BOOKBMJAIBM(int KJGEGOKIDFK, bool DAFNAOMLAGF = true)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[RegisterService(typeof(KAFMOAACLJJ), new string[] { })]
[ServiceLifetime(Lifetime.Application)]
public class KAFMOAACLJJ : HCKBIEPELFM, HDOAJHPMAEO, DCEPPCNEFDI
{
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static readonly Dictionary<object, object> CGEKGIGMODK;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static readonly Dictionary<object, object> JEBHOBBDCHG;

	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private static readonly Dictionary<object, object> ICDHMHOFEFC;

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private static readonly CIJKFJMOGHC BOEABHHHHEP;

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static readonly CIJKFJMOGHC BMFJGBDNNKN;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static readonly CIJKFJMOGHC BMMEDAIFANB;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static readonly CIJKFJMOGHC BEMHOCMDDMO;

	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private static readonly CIJKFJMOGHC HBGNAKIOIGB;

	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private static int NOBIDBKNDJG;

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x8637790", Offset = "0x8635D90", VA = "0x188637790", Slot = "18")]
	public void ECFEIOPKLDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x8638040", Offset = "0x8636640", VA = "0x188638040", Slot = "19")]
	public void HDAIJOIMLPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x86370E0", Offset = "0x86356E0", VA = "0x1886370E0", Slot = "4")]
	public bool CLCHBCGBAPI(OBHLIKKGGFI ENMBHGMENHL, bool OIMEEMPLNHI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x8637920", Offset = "0x8635F20", VA = "0x188637920", Slot = "5")]
	public int FPGCCIOPGHJ(OBHLIKKGGFI[] GKALKDCGDJC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x8638570", Offset = "0x8636B70", VA = "0x188638570", Slot = "6")]
	public bool LADGNPLFONN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x8638950", Offset = "0x8636F50", VA = "0x188638950", Slot = "7")]
	public bool MPEKMCNJBHJ(int JCBIELMJFID, int MGKEEIKKKDN, bool BGNPJGNBDDP, GameObject JJEACKINPOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x8638340", Offset = "0x8636940", VA = "0x188638340", Slot = "8")]
	public void KJJGPKEKEOB(int MGKEEIKKKDN, [Optional] int? BMJHIECPJIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x8636F70", Offset = "0x8635570", VA = "0x188636F70", Slot = "9")]
	public bool ANCNGJBMCNC(NDDAOAIJPDM CBIMJBOHKKP, [Out] OBHLIKKGGFI MDNGLGKBAIP, bool ELFGFOHDJMI = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x8638C00", Offset = "0x8637200", VA = "0x188638C00", Slot = "10")]
	public bool OFAJKCPBFMJ(NDDAOAIJPDM CBIMJBOHKKP, [Out] int HPBNEHBIONP, [Out] OBHLIKKGGFI[] GKALKDCGDJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x8638FE0", Offset = "0x86375E0", VA = "0x188638FE0", Slot = "11")]
	public bool PMIHPMHPLCP(NDDAOAIJPDM CBIMJBOHKKP, [Out] int MGKEEIKKKDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x86380E0", Offset = "0x86366E0", VA = "0x1886380E0", Slot = "12")]
	public void HDFBCANOJON(NDDAOAIJPDM CBIMJBOHKKP, [Out] int PCAHNNIBKBK, [Out] int[] LMECGFFCALK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x8637E60", Offset = "0x8636460", VA = "0x188637E60", Slot = "13")]
	public void HCOIPDCHCKC(int HPBNEHBIONP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x86387D0", Offset = "0x8636DD0", VA = "0x1886387D0", Slot = "14")]
	public void MFFBPJONGFJ(int HPBNEHBIONP, int[] LMECGFFCALK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x8637830", Offset = "0x8635E30", VA = "0x188637830", Slot = "15")]
	public void EOCFBMMIPIA(int[] LMECGFFCALK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x8637D40", Offset = "0x8636340", VA = "0x188637D40", Slot = "16")]
	public void HCANELHLEKC(int[] LMECGFFCALK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x8638600", Offset = "0x8636C00", VA = "0x188638600", Slot = "17")]
	public void LNIIEMFMEPL(int HPBNEHBIONP, int MGKEEIKKKDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x8637220", Offset = "0x8635820", VA = "0x188637220")]
	private static void DIBMKENNJMO(OBHLIKKGGFI ENMBHGMENHL, Dictionary<object, object> IGEFCKPMPKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x8636750", Offset = "0x8634D50", VA = "0x188636750")]
	private static bool ANCNGJBMCNC(Dictionary<object, object> IGEFCKPMPKJ, MEINMPIOLGA NAKGGLJDOEN, [Out] OBHLIKKGGFI MDNGLGKBAIP, bool ELFGFOHDJMI = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x8638F40", Offset = "0x8637540", VA = "0x188638F40")]
	private static bool PLAJHDPJEFB(int MGKEEIKKKDN, OBHLIKKGGFI IGEFCKPMPKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x8638B20", Offset = "0x8637120", VA = "0x188638B20")]
	private static int NJKABCEDHHL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public KAFMOAACLJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[ServiceLifetime(Lifetime.Application)]
[RegisterService(typeof(DMLKGIIBEMO), new string[] { })]
public class DMLKGIIBEMO : GANEPLMJMLL, HDOAJHPMAEO, DCEPPCNEFDI
{
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private static Hashtable ICNLILJJOOP;

	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private static Hashtable NJBIFBOHHKH;

	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private static CIJKFJMOGHC PEIBFJGCPAH;

	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private static readonly CIJKFJMOGHC KGOCNLOJIEI;

	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private static IPHNFELODMJ AMCHCCAPJNG;

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x8627EA0", Offset = "0x86264A0", VA = "0x188627EA0", Slot = "8")]
	public void HDAIJOIMLPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x8627420", Offset = "0x8625A20", VA = "0x188627420", Slot = "7")]
	public void ECFEIOPKLDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x8627F40", Offset = "0x8626540", VA = "0x188627F40", Slot = "4")]
	public void NADEFEMGAND(ViewId JCBIELMJFID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x8627B50", Offset = "0x8626150", VA = "0x188627B50", Slot = "5")]
	public bool FPFOLHHNHIM(NDDAOAIJPDM CBIMJBOHKKP, [Out] ViewId JCBIELMJFID, [Out] string HFFKJPDLDPD, [Out] int MEIHIEPFMPH, [Out] object[] MGPPHEGFGJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x86274C0", Offset = "0x8625AC0", VA = "0x1886274C0", Slot = "6")]
	public void FGHINPDPDBM(ViewId EPNGEANGHIF, string HFFKJPDLDPD, JCJIPGJBFOG GKHJONMBNCD, MEINMPIOLGA AGIMJJDFEAF, DIAEAGCMBLG OIPFPGJBCLL, object[] ENMBHGMENHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public DMLKGIIBEMO()
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
