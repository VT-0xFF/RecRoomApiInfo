using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_Preferences_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x72E8950", Offset = "0x72E7D50", VA = "0x1872E8950", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2200990", Offset = "0x21FFD90", VA = "0x182200990")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum NCDPJOMIGGC : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	CLOUD,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	DISK
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal static class LBPPLJIKEGC
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	internal delegate void DBACGAMPEGO(LLLJEAILJMD DEAHBHHJGCK);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x72E5BF0", Offset = "0x72E4FF0", VA = "0x1872E5BF0")]
	private static void KCPKKGKJPBL(LLLJEAILJMD DEAHBHHJGCK, DBACGAMPEGO OHNDFOBAGDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x72E5B00", Offset = "0x72E4F00", VA = "0x1872E5B00")]
	public static bool JGPDFGGDPKJ(this LLLJEAILJMD DEAHBHHJGCK, string NHHEMHBDHEB, [Optional] DBACGAMPEGO OHNDFOBAGDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x72E5730", Offset = "0x72E4B30", VA = "0x1872E5730")]
	public static IKGGMIOGKDK GGIJEBBKINN(this LLLJEAILJMD DEAHBHHJGCK, string NHHEMHBDHEB, string HCPAOILCJCB, [Optional] DBACGAMPEGO OHNDFOBAGDM)
	{
		return default(IKGGMIOGKDK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x72E5C70", Offset = "0x72E5070", VA = "0x1872E5C70")]
	public static IKGGMIOGKDK LMENEGJEIOO(this LLLJEAILJMD DEAHBHHJGCK, string NHHEMHBDHEB, int HCPAOILCJCB, [Optional] DBACGAMPEGO OHNDFOBAGDM)
	{
		return default(IKGGMIOGKDK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x72E59C0", Offset = "0x72E4DC0", VA = "0x1872E59C0")]
	public static IKGGMIOGKDK IHGGGGCBFPC(this LLLJEAILJMD DEAHBHHJGCK, string NHHEMHBDHEB, bool HCPAOILCJCB, [Optional] DBACGAMPEGO OHNDFOBAGDM)
	{
		return default(IKGGMIOGKDK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x72E5F20", Offset = "0x72E5320", VA = "0x1872E5F20")]
	public static IKGGMIOGKDK ODKCJCJHBJA(this LLLJEAILJMD DEAHBHHJGCK, string NHHEMHBDHEB, float HCPAOILCJCB, [Optional] DBACGAMPEGO OHNDFOBAGDM)
	{
		return default(IKGGMIOGKDK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x72E5DB0", Offset = "0x72E51B0", VA = "0x1872E5DB0")]
	public static IKGGMIOGKDK OBBOCFGJANI(this LLLJEAILJMD DEAHBHHJGCK, string NHHEMHBDHEB, DateTime HCPAOILCJCB, [Optional] DBACGAMPEGO OHNDFOBAGDM)
	{
		return default(IKGGMIOGKDK);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x72E5880", Offset = "0x72E4C80", VA = "0x1872E5880")]
	public static IKGGMIOGKDK HKLOPPDPHGL(this LLLJEAILJMD DEAHBHHJGCK, string NHHEMHBDHEB, long HCPAOILCJCB, [Optional] DBACGAMPEGO OHNDFOBAGDM)
	{
		return default(IKGGMIOGKDK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class NAKAOABCBLP : CNIALIKCHHK, LLLJEAILJMD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly LNLBDCJBOFM CAJODGKBLFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<string, byte> HJEAGEOPKAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private Dictionary<string, string> ONNHFDIPJPN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool MAIEPNIBMOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8E1B40", Offset = "0x8E0F40", VA = "0x1808E1B40", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Dictionary<string, string> JNDPFHLLFJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x72E6AE0", Offset = "0x72E5EE0", VA = "0x1872E6AE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action LOCEKBPOPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x72E7E60", Offset = "0x72E7260", VA = "0x1872E7E60")]
	[UnityEngine.Scripting.Preserve]
	public NAKAOABCBLP([CNGCCDLPGOD(null)] LNLBDCJBOFM CAJODGKBLFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "8")]
	public void DJEPNGKOMIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x72E69E0", Offset = "0x72E5DE0", VA = "0x1872E69E0")]
	private DirectoryInfo CFEDAAKMDIF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x72E7DD0", Offset = "0x72E71D0", VA = "0x1872E7DD0", Slot = "6")]
	public Task PIINEIBJOOA(long JNAJMHABOGO, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x72E72C0", Offset = "0x72E66C0", VA = "0x1872E72C0", Slot = "14")]
	public float KEBNFLGMHBM(string LDCKBFKFIKC, float EKFBHIJFHMA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x72E6820", Offset = "0x72E5C20", VA = "0x1872E6820", Slot = "13")]
	public void BFBNBEGAGDH(string LDCKBFKFIKC, bool HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x72E7C60", Offset = "0x72E7060", VA = "0x1872E7C60", Slot = "12")]
	public bool PEKDIBBBOKI(string LDCKBFKFIKC, bool EKFBHIJFHMA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x72E6890", Offset = "0x72E5C90", VA = "0x1872E6890", Slot = "10")]
	public int BHKCGDDIEFD(string LDCKBFKFIKC, int EKFBHIJFHMA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x72E6970", Offset = "0x72E5D70", VA = "0x1872E6970", Slot = "18")]
	public DateTime BPNFOAMJENG(string NHHEMHBDHEB, [Optional] DateTime EKFBHIJFHMA)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x72E6BB0", Offset = "0x72E5FB0", VA = "0x1872E6BB0", Slot = "19")]
	public void DLBFMKGDGJH(string LDCKBFKFIKC, DateTime HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x72E7250", Offset = "0x72E6650", VA = "0x1872E7250", Slot = "15")]
	public void IDPEIHCKFDM(string LDCKBFKFIKC, float HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x72E6900", Offset = "0x72E5D00", VA = "0x1872E6900", Slot = "11")]
	public void BMKPMJPGKMA(string LDCKBFKFIKC, int HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x72E73F0", Offset = "0x72E67F0", VA = "0x1872E73F0", Slot = "20")]
	public long NHBKLJHOJLO(string NHHEMHBDHEB, long EKFBHIJFHMA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x72E63B0", Offset = "0x72E57B0", VA = "0x1872E63B0", Slot = "21")]
	public void ACJEFIBNOMC(string NHHEMHBDHEB, long HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2DDF310", Offset = "0x2DDE710", VA = "0x182DDF310", Slot = "22")]
	public T IOOBDGOALCI<T>(string NHHEMHBDHEB, T EKFBHIJFHMA, MDJPMBFJJHE<T> PADHOKCDABG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2DDF310", Offset = "0x2DDE710", VA = "0x182DDF310", Slot = "23")]
	public void JHBCGEGKOIM<T>(string NHHEMHBDHEB, T HCPAOILCJCB, MDJPMBFJJHE<T> PADHOKCDABG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x72E7D20", Offset = "0x72E7120", VA = "0x1872E7D20", Slot = "16")]
	public string PHALFBDHBII(string LDCKBFKFIKC, string EKFBHIJFHMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x72E6420", Offset = "0x72E5820", VA = "0x1872E6420", Slot = "17")]
	public void AHCHDLPLGLL(string LDCKBFKFIKC, string HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x72E7330", Offset = "0x72E6730", VA = "0x1872E7330", Slot = "24")]
	public void MMJFHKMMDGH(string LDCKBFKFIKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x72E6B20", Offset = "0x72E5F20", VA = "0x1872E6B20", Slot = "9")]
	public bool DBBDDFMPAFF(string LDCKBFKFIKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x72E6F20", Offset = "0x72E6320", VA = "0x1872E6F20", Slot = "25")]
	public Task IDDCJOHEPLD(CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x72E6490", Offset = "0x72E5890", VA = "0x1872E6490")]
	private void BCGMJBPLALG(DirectoryInfo CIMBLDDAEMJ, string ONAMNJFCOMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x72E6C20", Offset = "0x72E6020", VA = "0x1872E6C20")]
	private static string HABOJAFOMBE(string LDCKBFKFIKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x72E6E20", Offset = "0x72E6220", VA = "0x1872E6E20")]
	private static string HFNAIFPNJDB(byte[] MDABPMPEKPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x31C65A0", Offset = "0x31C59A0", VA = "0x1831C65A0")]
	private T AFFELPLAAIM<T>(string NHHEMHBDHEB, T EKFBHIJFHMA, [Optional] MDJPMBFJJHE<T> AFKFJBCGION)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x31C7820", Offset = "0x31C6C20", VA = "0x1831C7820")]
	private void KJLAKIGFJAC<T>(string NHHEMHBDHEB, T HCPAOILCJCB, [Optional] MDJPMBFJJHE<T> AFKFJBCGION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x72E7460", Offset = "0x72E6860", VA = "0x1872E7460")]
	private Dictionary<string, string> OGKFGLEKJLF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal static class NKGICOKBCNP
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x72E7F00", Offset = "0x72E7300", VA = "0x1872E7F00")]
	[AGCFNMIICNN.OGAOPBBDHOG]
	internal static void OHHPJPBCCIE(CGJHFFGEHKC CLDCJHAFFHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class FIONGGGDCBJ : FFEILLOJOCC
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x72E3DE0", Offset = "0x72E31E0", VA = "0x1872E3DE0")]
	[UnityEngine.Scripting.Preserve]
	public FIONGGGDCBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class FFEILLOJOCC : CNIALIKCHHK, LLLJEAILJMD, IOGLODIPNLK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<string, object> PEDIPIJCGOK;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool MAIEPNIBMOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8E1B40", Offset = "0x8E0F40", VA = "0x1808E1B40", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action LOCEKBPOPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "8")]
	public void DJEPNGKOMIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x72E3D50", Offset = "0x72E3150", VA = "0x1872E3D50", Slot = "6")]
	public Task PIINEIBJOOA(long JNAJMHABOGO, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x72E39C0", Offset = "0x72E2DC0", VA = "0x1872E39C0", Slot = "9")]
	public bool DBBDDFMPAFF(string NHHEMHBDHEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x72E38A0", Offset = "0x72E2CA0", VA = "0x1872E38A0", Slot = "10")]
	public int BHKCGDDIEFD(string NHHEMHBDHEB, int EKFBHIJFHMA = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x72E3900", Offset = "0x72E2D00", VA = "0x1872E3900", Slot = "11")]
	public void BMKPMJPGKMA(string NHHEMHBDHEB, int HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x72E3C90", Offset = "0x72E3090", VA = "0x1872E3C90", Slot = "12")]
	public bool PEKDIBBBOKI(string NHHEMHBDHEB, bool EKFBHIJFHMA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x72E3840", Offset = "0x72E2C40", VA = "0x1872E3840", Slot = "13")]
	public void BFBNBEGAGDH(string NHHEMHBDHEB, bool HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x72E3B70", Offset = "0x72E2F70", VA = "0x1872E3B70", Slot = "14")]
	public float KEBNFLGMHBM(string NHHEMHBDHEB, float EKFBHIJFHMA = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x72E3B10", Offset = "0x72E2F10", VA = "0x1872E3B10", Slot = "15")]
	public void IDPEIHCKFDM(string NHHEMHBDHEB, float HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x72E3CF0", Offset = "0x72E30F0", VA = "0x1872E3CF0", Slot = "16")]
	public string PHALFBDHBII(string NHHEMHBDHEB, [Optional] string EKFBHIJFHMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x72E37E0", Offset = "0x72E2BE0", VA = "0x1872E37E0", Slot = "17")]
	public void AHCHDLPLGLL(string NHHEMHBDHEB, string HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x72E3960", Offset = "0x72E2D60", VA = "0x1872E3960", Slot = "18")]
	public DateTime BPNFOAMJENG(string NHHEMHBDHEB, [Optional] DateTime EKFBHIJFHMA)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x72E3A20", Offset = "0x72E2E20", VA = "0x1872E3A20", Slot = "19")]
	public void DLBFMKGDGJH(string NHHEMHBDHEB, DateTime HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x72E3C30", Offset = "0x72E3030", VA = "0x1872E3C30", Slot = "20")]
	public long NHBKLJHOJLO(string NHHEMHBDHEB, long EKFBHIJFHMA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x72E3780", Offset = "0x72E2B80", VA = "0x1872E3780", Slot = "21")]
	public void ACJEFIBNOMC(string NHHEMHBDHEB, long HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x301FFB0", Offset = "0x301F3B0", VA = "0x18301FFB0", Slot = "22")]
	public T IOOBDGOALCI<T>(string NHHEMHBDHEB, T EKFBHIJFHMA, MDJPMBFJJHE<T> PADHOKCDABG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x30200D0", Offset = "0x301F4D0", VA = "0x1830200D0", Slot = "23")]
	public void JHBCGEGKOIM<T>(string NHHEMHBDHEB, T HCPAOILCJCB, MDJPMBFJJHE<T> PADHOKCDABG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x301F770", Offset = "0x301EB70", VA = "0x18301F770")]
	public T AFFELPLAAIM<T>(string NHHEMHBDHEB, T EKFBHIJFHMA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x30201B0", Offset = "0x301F5B0", VA = "0x1830201B0")]
	public void KJLAKIGFJAC<T>(string NHHEMHBDHEB, T HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x72E3BD0", Offset = "0x72E2FD0", VA = "0x1872E3BD0", Slot = "24")]
	public void MMJFHKMMDGH(string NHHEMHBDHEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x72E3A80", Offset = "0x72E2E80", VA = "0x1872E3A80", Slot = "25")]
	public Task IDDCJOHEPLD(CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x72E3DE0", Offset = "0x72E31E0", VA = "0x1872E3DE0")]
	public FFEILLOJOCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class PBNGJBIKBHK<TParent> where TParent : LLLJEAILJMD
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly HashSet<PBNGJBIKBHK<TParent>> JCNCPALKBMA;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4C4A010", Offset = "0x4C49410", VA = "0x184C4A010")]
	protected PBNGJBIKBHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract void CDMKLDGEKPL();

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void OHFIEEAGBFG(string LDCKBFKFIKC);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4C49A40", Offset = "0x4C48E40", VA = "0x184C49A40")]
	public static void FDHLBEBMPBA(string LDCKBFKFIKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4C49C90", Offset = "0x4C49090", VA = "0x184C49C90")]
	public static void MLBLEPOGDGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class IMPGGHDMJOG<TParent, TValue> : PBNGJBIKBHK<TParent> where TParent : LLLJEAILJMD
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly IMPGGHDMJOG<TParent, TValue> LNPPLFIHDAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, TValue> NJBGAHCAIHM;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x435CA10", Offset = "0x435BE10", VA = "0x18435CA10")]
	public bool LINPJOCPLAE(string LKMCKCKNIPH, [Out] TValue NFLJFBPCDLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x435C8E0", Offset = "0x435BCE0", VA = "0x18435C8E0")]
	public void JKCGJLJBGAE(string LKMCKCKNIPH, TValue HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3CCAD60", Offset = "0x3CCA160", VA = "0x183CCAD60", Slot = "4")]
	protected override void CDMKLDGEKPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3C7C220", Offset = "0x3C7B620", VA = "0x183C7C220", Slot = "5")]
	protected override void OHFIEEAGBFG(string LKMCKCKNIPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x435CBB0", Offset = "0x435BFB0", VA = "0x18435CBB0")]
	public IMPGGHDMJOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface LLLJEAILJMD
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool MAIEPNIBMOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DJEPNGKOMIE();

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DBBDDFMPAFF(string NHHEMHBDHEB);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int BHKCGDDIEFD(string NHHEMHBDHEB, int EKFBHIJFHMA = 0);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BMKPMJPGKMA(string NHHEMHBDHEB, int HCPAOILCJCB);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool PEKDIBBBOKI(string NHHEMHBDHEB, bool EKFBHIJFHMA = false);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BFBNBEGAGDH(string NHHEMHBDHEB, bool HCPAOILCJCB);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	float KEBNFLGMHBM(string NHHEMHBDHEB, float EKFBHIJFHMA = 0f);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IDPEIHCKFDM(string NHHEMHBDHEB, float HCPAOILCJCB);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	string PHALFBDHBII(string NHHEMHBDHEB, [Optional] string EKFBHIJFHMA);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void AHCHDLPLGLL(string NHHEMHBDHEB, string HCPAOILCJCB);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	DateTime BPNFOAMJENG(string NHHEMHBDHEB, [Optional] DateTime MKMNAFLLFPB);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void DLBFMKGDGJH(string NHHEMHBDHEB, DateTime MKMNAFLLFPB);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "13")]
	long NHBKLJHOJLO(string NHHEMHBDHEB, long EKFBHIJFHMA);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ACJEFIBNOMC(string NHHEMHBDHEB, long HCPAOILCJCB);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "15")]
	T IOOBDGOALCI<T>(string NHHEMHBDHEB, T EKFBHIJFHMA, MDJPMBFJJHE<T> PADHOKCDABG);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void JHBCGEGKOIM<T>(string NHHEMHBDHEB, T HCPAOILCJCB, MDJPMBFJJHE<T> PADHOKCDABG);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void MMJFHKMMDGH(string NHHEMHBDHEB);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task IDDCJOHEPLD([Optional] CancellationToken FHGIOBPPFHG);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface CNIALIKCHHK : LLLJEAILJMD
{
	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action LOCEKBPOPAJ;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task PIINEIBJOOA(long JNAJMHABOGO, CancellationToken FHGIOBPPFHG);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface IOGLODIPNLK : LLLJEAILJMD
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class BICDKIIOANA : CNIALIKCHHK, LLLJEAILJMD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct NMMHFDEIJPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public BICDKIIOANA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x72E8050", Offset = "0x72E7450", VA = "0x1872E8050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x72E81E0", Offset = "0x72E75E0", VA = "0x1872E81E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct DLLCJFCDNEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public BICDKIIOANA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public long playerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x72E0240", Offset = "0x72DF640", VA = "0x1872E0240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x72E0530", Offset = "0x72DF930", VA = "0x1872E0530", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly CNIALIKCHHK LCFNBHJAJNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public readonly NAKAOABCBLP IGDGKMFHPKA;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool MAIEPNIBMOG
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x72DEEF0", Offset = "0x72DE2F0", VA = "0x1872DEEF0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action LOCEKBPOPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x72DF600", Offset = "0x72DEA00", VA = "0x1872DF600", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x72DED20", Offset = "0x72DE120", VA = "0x1872DED20", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x72DF660", Offset = "0x72DEA60", VA = "0x1872DF660")]
	[UnityEngine.Scripting.Preserve]
	public BICDKIIOANA([CNGCCDLPGOD(null)] LNLBDCJBOFM CAJODGKBLFF, [CNGCCDLPGOD("Disk_Unity")] CNIALIKCHHK LCFNBHJAJNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x72DEAF0", Offset = "0x72DDEF0", VA = "0x1872DEAF0", Slot = "8")]
	public void DJEPNGKOMIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x72DEA60", Offset = "0x72DDE60", VA = "0x1872DEA60", Slot = "9")]
	public bool DBBDDFMPAFF(string NHHEMHBDHEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x72DE740", Offset = "0x72DDB40", VA = "0x1872DE740", Slot = "10")]
	public int BHKCGDDIEFD(string NHHEMHBDHEB, int EKFBHIJFHMA = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x72DE890", Offset = "0x72DDC90", VA = "0x1872DE890", Slot = "11")]
	public void BMKPMJPGKMA(string NHHEMHBDHEB, int HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x72DF1C0", Offset = "0x72DE5C0", VA = "0x1872DF1C0", Slot = "12")]
	public bool PEKDIBBBOKI(string NHHEMHBDHEB, bool EKFBHIJFHMA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x72DE6D0", Offset = "0x72DDAD0", VA = "0x1872DE6D0", Slot = "13")]
	public void BFBNBEGAGDH(string NHHEMHBDHEB, bool HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x72DED90", Offset = "0x72DE190", VA = "0x1872DED90", Slot = "14")]
	public float KEBNFLGMHBM(string NHHEMHBDHEB, float EKFBHIJFHMA = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x72DECB0", Offset = "0x72DE0B0", VA = "0x1872DECB0", Slot = "15")]
	public void IDPEIHCKFDM(string NHHEMHBDHEB, float HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x72DF350", Offset = "0x72DE750", VA = "0x1872DF350", Slot = "16")]
	public string PHALFBDHBII(string NHHEMHBDHEB, [Optional] string EKFBHIJFHMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x72DE660", Offset = "0x72DDA60", VA = "0x1872DE660", Slot = "17")]
	public void AHCHDLPLGLL(string NHHEMHBDHEB, string HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x72DE900", Offset = "0x72DDD00", VA = "0x1872DE900", Slot = "18")]
	public DateTime BPNFOAMJENG(string NHHEMHBDHEB, [Optional] DateTime EKFBHIJFHMA)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x72DEB50", Offset = "0x72DDF50", VA = "0x1872DEB50", Slot = "19")]
	public void DLBFMKGDGJH(string NHHEMHBDHEB, DateTime MKMNAFLLFPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x72DF060", Offset = "0x72DE460", VA = "0x1872DF060", Slot = "20")]
	public long NHBKLJHOJLO(string NHHEMHBDHEB, long EKFBHIJFHMA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x72DE5F0", Offset = "0x72DD9F0", VA = "0x1872DE5F0", Slot = "21")]
	public void ACJEFIBNOMC(string NHHEMHBDHEB, long HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2DDB790", Offset = "0x2DDAB90", VA = "0x182DDB790", Slot = "22")]
	public T IOOBDGOALCI<T>(string NHHEMHBDHEB, T EKFBHIJFHMA, MDJPMBFJJHE<T> PADHOKCDABG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x2DDBEF0", Offset = "0x2DDB2F0", VA = "0x182DDBEF0", Slot = "23")]
	public void JHBCGEGKOIM<T>(string NHHEMHBDHEB, T HCPAOILCJCB, MDJPMBFJJHE<T> PADHOKCDABG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x72DEF50", Offset = "0x72DE350", VA = "0x1872DEF50", Slot = "24")]
	public void MMJFHKMMDGH(string NHHEMHBDHEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x72DEBC0", Offset = "0x72DDFC0", VA = "0x1872DEBC0", Slot = "25")]
	[AsyncStateMachine(typeof(NMMHFDEIJPL))]
	public Task IDDCJOHEPLD([Optional] CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x72DF4F0", Offset = "0x72DE8F0", VA = "0x1872DF4F0", Slot = "6")]
	[AsyncStateMachine(typeof(DLLCJFCDNEN))]
	public Task PIINEIBJOOA(long JNAJMHABOGO, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class COFFNOGLLKH : CNIALIKCHHK, LLLJEAILJMD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct IPEDDOEAGGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public COFFNOGLLKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x72E4C40", Offset = "0x72E4040", VA = "0x1872E4C40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x72E5010", Offset = "0x72E4410", VA = "0x1872E5010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class PPNOFKMPEFP : IEnumerator<ONHNFKGBFKG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private ONHNFKGBFKG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public COFFNOGLLKH <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private ONHNFKGBFKG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8CAD70", Offset = "0x8CA170", VA = "0x1808CAD70")]
		[DebuggerHidden]
		public PPNOFKMPEFP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x72E87B0", Offset = "0x72E7BB0", VA = "0x1872E87B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x72E8820", Offset = "0x72E7C20", VA = "0x1872E8820", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly LNLBDCJBOFM CAJODGKBLFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool ODCPLMJJJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private bool KDPNLGGPDJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private OKKMFOFDAFG PGOFEEGHHLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private GLHJGEGNDCM JEDCKJKFOIL;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool MAIEPNIBMOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8E1B40", Offset = "0x8E0F40", VA = "0x1808E1B40", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action LOCEKBPOPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x72E0150", Offset = "0x72DF550", VA = "0x1872E0150")]
	[UnityEngine.Scripting.Preserve]
	public COFFNOGLLKH([CNGCCDLPGOD(null)] LNLBDCJBOFM CAJODGKBLFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "8")]
	public void DJEPNGKOMIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x72E00C0", Offset = "0x72DF4C0", VA = "0x1872E00C0", Slot = "6")]
	public Task PIINEIBJOOA(long JNAJMHABOGO, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x15F8E60", Offset = "0x15F8260", VA = "0x1815F8E60")]
	private static int IMNOKGMAHPE(bool HCPAOILCJCB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x72DFAE0", Offset = "0x72DEEE0", VA = "0x1872DFAE0", Slot = "9")]
	public bool DBBDDFMPAFF(string NHHEMHBDHEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x72DFA10", Offset = "0x72DEE10", VA = "0x1872DFA10", Slot = "10")]
	public int BHKCGDDIEFD(string NHHEMHBDHEB, int EKFBHIJFHMA = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x72DFA40", Offset = "0x72DEE40", VA = "0x1872DFA40", Slot = "11")]
	public void BMKPMJPGKMA(string NHHEMHBDHEB, int HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x72E0040", Offset = "0x72DF440", VA = "0x1872E0040", Slot = "12")]
	public bool PEKDIBBBOKI(string NHHEMHBDHEB, bool EKFBHIJFHMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x72DF9E0", Offset = "0x72DEDE0", VA = "0x1872DF9E0", Slot = "13")]
	public void BFBNBEGAGDH(string NHHEMHBDHEB, bool HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x72DFE90", Offset = "0x72DF290", VA = "0x1872DFE90", Slot = "14")]
	public float KEBNFLGMHBM(string NHHEMHBDHEB, float EKFBHIJFHMA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x72DFE60", Offset = "0x72DF260", VA = "0x1872DFE60", Slot = "15")]
	public void IDPEIHCKFDM(string NHHEMHBDHEB, float HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x72DFA70", Offset = "0x72DEE70", VA = "0x1872DFA70", Slot = "18")]
	public DateTime BPNFOAMJENG(string NHHEMHBDHEB, [Optional] DateTime EKFBHIJFHMA)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x72DFB00", Offset = "0x72DEF00", VA = "0x1872DFB00", Slot = "19")]
	public void DLBFMKGDGJH(string NHHEMHBDHEB, DateTime MKMNAFLLFPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x72DFFB0", Offset = "0x72DF3B0", VA = "0x1872DFFB0", Slot = "20")]
	public long NHBKLJHOJLO(string NHHEMHBDHEB, long EKFBHIJFHMA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x72DF940", Offset = "0x72DED40", VA = "0x1872DF940", Slot = "21")]
	public void ACJEFIBNOMC(string NHHEMHBDHEB, long HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2E66390", Offset = "0x2E65790", VA = "0x182E66390", Slot = "22")]
	public T IOOBDGOALCI<T>(string NHHEMHBDHEB, T EKFBHIJFHMA, MDJPMBFJJHE<T> PADHOKCDABG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2E66390", Offset = "0x2E65790", VA = "0x182E66390", Slot = "23")]
	public void JHBCGEGKOIM<T>(string NHHEMHBDHEB, T HCPAOILCJCB, MDJPMBFJJHE<T> PADHOKCDABG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2E66690", Offset = "0x2E65A90", VA = "0x182E66690")]
	private T MGHPPICHION<T>(string NHHEMHBDHEB, T EKFBHIJFHMA, [Optional] MDJPMBFJJHE<T> AFKFJBCGION)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2E65C50", Offset = "0x2E65050", VA = "0x182E65C50")]
	private void HBCFPOFEMNE<T>(string NHHEMHBDHEB, T HCPAOILCJCB, [Optional] MDJPMBFJJHE<T> AFKFJBCGION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x72E0090", Offset = "0x72DF490", VA = "0x1872E0090", Slot = "16")]
	public string PHALFBDHBII(string NHHEMHBDHEB, string EKFBHIJFHMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x72DF9B0", Offset = "0x72DEDB0", VA = "0x1872DF9B0", Slot = "17")]
	public void AHCHDLPLGLL(string NHHEMHBDHEB, string HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x72E0070", Offset = "0x72DF470", VA = "0x1872E0070")]
	private void PENNOGJEFEG(string NHHEMHBDHEB, string HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x72E0020", Offset = "0x72DF420", VA = "0x1872E0020")]
	private string PAEDEICJCKM(string NHHEMHBDHEB, string EKFBHIJFHMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x72DFF20", Offset = "0x72DF320", VA = "0x1872DFF20", Slot = "24")]
	public void MMJFHKMMDGH(string NHHEMHBDHEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x72DFCD0", Offset = "0x72DF0D0", VA = "0x1872DFCD0")]
	private string IAMLOLILMDP(string LDCKBFKFIKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x72DFD70", Offset = "0x72DF170", VA = "0x1872DFD70", Slot = "25")]
	[AsyncStateMachine(typeof(IPEDDOEAGGP))]
	public Task IDDCJOHEPLD(CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x72DFB70", Offset = "0x72DEF70", VA = "0x1872DFB70")]
	[IteratorStateMachine(typeof(PPNOFKMPEFP))]
	private IEnumerator<ONHNFKGBFKG> EPKHMLKLKDN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x72DFEC0", Offset = "0x72DF2C0", VA = "0x1872DFEC0")]
	private void MAJDGAGMMPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x72DFBF0", Offset = "0x72DEFF0", VA = "0x1872DFBF0")]
	private void HJMOKHAEMEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x72DFC60", Offset = "0x72DF060", VA = "0x1872DFC60")]
	private void HLKAPOEMLIE(bool IIOALDBDCHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class GOPEMCEPECA : CNIALIKCHHK, LLLJEAILJMD
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct KVP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public string k;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public string v;
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private struct KVPs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public KVP[] kvps;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private Dictionary<string, string> ONNHFDIPJPN;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool MAIEPNIBMOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8E1B40", Offset = "0x8E0F40", VA = "0x1808E1B40", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private string OEGKDGOPJJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x72E4550", Offset = "0x72E3950", VA = "0x1872E4550")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private Dictionary<string, string> JNDPFHLLFJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x72E4140", Offset = "0x72E3540", VA = "0x1872E4140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action LOCEKBPOPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	[UnityEngine.Scripting.Preserve]
	public GOPEMCEPECA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "8")]
	public void DJEPNGKOMIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x72E4BB0", Offset = "0x72E3FB0", VA = "0x1872E4BB0", Slot = "6")]
	public Task PIINEIBJOOA(long JNAJMHABOGO, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x72E45C0", Offset = "0x72E39C0", VA = "0x1872E45C0", Slot = "14")]
	public float KEBNFLGMHBM(string LDCKBFKFIKC, float EKFBHIJFHMA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x72E3F80", Offset = "0x72E3380", VA = "0x1872E3F80", Slot = "13")]
	public void BFBNBEGAGDH(string LDCKBFKFIKC, bool HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x72E4A40", Offset = "0x72E3E40", VA = "0x1872E4A40", Slot = "12")]
	public bool PEKDIBBBOKI(string LDCKBFKFIKC, bool EKFBHIJFHMA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x72E3FF0", Offset = "0x72E33F0", VA = "0x1872E3FF0", Slot = "10")]
	public int BHKCGDDIEFD(string LDCKBFKFIKC, int EKFBHIJFHMA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x72E40D0", Offset = "0x72E34D0", VA = "0x1872E40D0", Slot = "18")]
	public DateTime BPNFOAMJENG(string NHHEMHBDHEB, [Optional] DateTime EKFBHIJFHMA)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x72E4210", Offset = "0x72E3610", VA = "0x1872E4210", Slot = "19")]
	public void DLBFMKGDGJH(string LDCKBFKFIKC, DateTime HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x72E44E0", Offset = "0x72E38E0", VA = "0x1872E44E0", Slot = "15")]
	public void IDPEIHCKFDM(string LDCKBFKFIKC, float HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x72E4060", Offset = "0x72E3460", VA = "0x1872E4060", Slot = "11")]
	public void BMKPMJPGKMA(string LDCKBFKFIKC, int HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x72E46F0", Offset = "0x72E3AF0", VA = "0x1872E46F0", Slot = "20")]
	public long NHBKLJHOJLO(string NHHEMHBDHEB, long EKFBHIJFHMA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x72E3E70", Offset = "0x72E3270", VA = "0x1872E3E70", Slot = "21")]
	public void ACJEFIBNOMC(string NHHEMHBDHEB, long HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x2DDF310", Offset = "0x2DDE710", VA = "0x182DDF310", Slot = "22")]
	public T IOOBDGOALCI<T>(string NHHEMHBDHEB, T EKFBHIJFHMA, MDJPMBFJJHE<T> PADHOKCDABG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2DDF310", Offset = "0x2DDE710", VA = "0x182DDF310", Slot = "23")]
	public void JHBCGEGKOIM<T>(string NHHEMHBDHEB, T HCPAOILCJCB, MDJPMBFJJHE<T> PADHOKCDABG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x72E4B00", Offset = "0x72E3F00", VA = "0x1872E4B00", Slot = "16")]
	public string PHALFBDHBII(string LDCKBFKFIKC, string EKFBHIJFHMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x72E3EE0", Offset = "0x72E32E0", VA = "0x1872E3EE0", Slot = "17")]
	public void AHCHDLPLGLL(string LDCKBFKFIKC, string HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x72E4630", Offset = "0x72E3A30", VA = "0x1872E4630", Slot = "24")]
	public void MMJFHKMMDGH(string LDCKBFKFIKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x72E4180", Offset = "0x72E3580", VA = "0x1872E4180", Slot = "9")]
	public bool DBBDDFMPAFF(string LDCKBFKFIKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x72E4280", Offset = "0x72E3680", VA = "0x1872E4280", Slot = "25")]
	public Task IDDCJOHEPLD(CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x3070470", Offset = "0x306F870", VA = "0x183070470")]
	private T AFFELPLAAIM<T>(string NHHEMHBDHEB, T EKFBHIJFHMA, [Optional] MDJPMBFJJHE<T> AFKFJBCGION)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x30716F0", Offset = "0x3070AF0", VA = "0x1830716F0")]
	private void KJLAKIGFJAC<T>(string NHHEMHBDHEB, T HCPAOILCJCB, [Optional] MDJPMBFJJHE<T> AFKFJBCGION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x72E4760", Offset = "0x72E3B60", VA = "0x1872E4760")]
	private Dictionary<string, string> OGKFGLEKJLF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface GMAGBLHDHPN
{
	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action LOCEKBPOPAJ;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DJEPNGKOMIE();

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task KEGOEMOKMDP(long JNAJMHABOGO);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool ELDGBHMLOAA(NCDPJOMIGGC PLNONKCNMPK = NCDPJOMIGGC.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool AMCKEAHNLKI(string NHHEMHBDHEB, NCDPJOMIGGC IMCNAFHMOON = NCDPJOMIGGC.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool OAOJHFNAIKG(string NHHEMHBDHEB, NCDPJOMIGGC IMCNAFHMOON = NCDPJOMIGGC.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	string LDBCPILMJBF(string NHHEMHBDHEB, [Optional] string EKFBHIJFHMA, NCDPJOMIGGC IMCNAFHMOON = NCDPJOMIGGC.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IKGGMIOGKDK HEOCEGOMEGN(string NHHEMHBDHEB, string HCPAOILCJCB, NCDPJOMIGGC IMCNAFHMOON = NCDPJOMIGGC.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	int MENDHODFING(string NHHEMHBDHEB, int EKFBHIJFHMA = 0, NCDPJOMIGGC IMCNAFHMOON = NCDPJOMIGGC.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IKGGMIOGKDK PGAPBDLAOOL(string NHHEMHBDHEB, int HCPAOILCJCB, NCDPJOMIGGC IMCNAFHMOON = NCDPJOMIGGC.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CLJJNBIGGOO(string NHHEMHBDHEB, bool EKFBHIJFHMA, NCDPJOMIGGC IMCNAFHMOON = NCDPJOMIGGC.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "12")]
	IKGGMIOGKDK BOCMAONIPNN(string NHHEMHBDHEB, bool HCPAOILCJCB, NCDPJOMIGGC IMCNAFHMOON = NCDPJOMIGGC.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float ODHBLODEFNK(string NHHEMHBDHEB, float EKFBHIJFHMA = 0f, NCDPJOMIGGC IMCNAFHMOON = NCDPJOMIGGC.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "14")]
	IKGGMIOGKDK EKHEDGCGBGJ(string NHHEMHBDHEB, float HCPAOILCJCB, NCDPJOMIGGC IMCNAFHMOON = NCDPJOMIGGC.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "15")]
	DateTime EJCEKDIPIDH(string NHHEMHBDHEB, [Optional] DateTime EKFBHIJFHMA, NCDPJOMIGGC IMCNAFHMOON = NCDPJOMIGGC.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IKGGMIOGKDK ACKAHAKJKPG(string NHHEMHBDHEB, DateTime HCPAOILCJCB, NCDPJOMIGGC IMCNAFHMOON = NCDPJOMIGGC.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "17")]
	long MIOLCOMHFBA(string NHHEMHBDHEB, long EKFBHIJFHMA = 0L, NCDPJOMIGGC IMCNAFHMOON = NCDPJOMIGGC.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "18")]
	IKGGMIOGKDK EGLLHBCLNAA(string NHHEMHBDHEB, long HCPAOILCJCB, NCDPJOMIGGC IMCNAFHMOON = NCDPJOMIGGC.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "19")]
	T NMKNIFBPKIF<T>(string NHHEMHBDHEB, [Optional] T EKFBHIJFHMA, NCDPJOMIGGC IMCNAFHMOON = NCDPJOMIGGC.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "20")]
	IKGGMIOGKDK MJABFLMEBJJ<T>(string NHHEMHBDHEB, T HCPAOILCJCB, NCDPJOMIGGC IMCNAFHMOON = NCDPJOMIGGC.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool OCPJNAFAKJL(string NHHEMHBDHEB);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool GLIJEAEKBDI(string NHHEMHBDHEB);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "23")]
	string IBGPNHCDOOG(string NHHEMHBDHEB, [Optional] string EKFBHIJFHMA);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "24")]
	IKGGMIOGKDK DBFCNPKFFOI(string NHHEMHBDHEB, string HCPAOILCJCB);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "25")]
	int MJFGNCFAJMH(string NHHEMHBDHEB, int EKFBHIJFHMA = 0);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "26")]
	IKGGMIOGKDK MJFFHMOOKPO(string NHHEMHBDHEB, int HCPAOILCJCB);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool BCENAEAGBAF(string NHHEMHBDHEB, bool EKFBHIJFHMA);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "28")]
	IKGGMIOGKDK ACKDEEGNGHH(string NHHEMHBDHEB, bool HCPAOILCJCB);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "29")]
	float EAGGCFKPCOM(string NHHEMHBDHEB, float EKFBHIJFHMA = 0f);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "30")]
	IKGGMIOGKDK FFIEGKMDMGP(string NHHEMHBDHEB, float HCPAOILCJCB);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "31")]
	DateTime HPMPDGJBOPD(string NHHEMHBDHEB, [Optional] DateTime EKFBHIJFHMA);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "32")]
	IKGGMIOGKDK PJEIAGMIMAH(string NHHEMHBDHEB, DateTime HCPAOILCJCB);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "33")]
	long AIOEGBDDOCI(string NHHEMHBDHEB, long EKFBHIJFHMA = 0L);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "34")]
	IKGGMIOGKDK GEJFCDHABKL(string NHHEMHBDHEB, long HCPAOILCJCB);

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void JABJODOALKF<T>(MDJPMBFJJHE<T> PADHOKCDABG, [Optional] IEqualityComparer<T> GNOIOLAMEKG);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void DOFDMKJFIAJ<T>();

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "37")]
	IDisposable HGJLOEGMAOE();

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void ALBLGKFGPID(float CHFBMMDLDCL);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task MAJDGAGMMPO([Optional] CancellationToken FHGIOBPPFHG);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum IKGGMIOGKDK : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Unchanged,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	New,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	Changed
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class EOGMAPPNHPD : GMAGBLHDHPN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private abstract class CINCCMOGNBF
	{
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		protected static readonly HashSet<CINCCMOGNBF> DILABIKMCDK;

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x72DF770", Offset = "0x72DEB70", VA = "0x1872DF770")]
		public static void MLBLEPOGDGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void CDMKLDGEKPL();

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		protected CINCCMOGNBF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private class KOKINHJFCHM<T> : CINCCMOGNBF
	{
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public static readonly KOKINHJFCHM<T> ELEBKANKHDF;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public MDJPMBFJJHE<T> OENBHKABPDH
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x8C7B90", Offset = "0x8C6F90", VA = "0x1808C7B90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x8C7DB0", Offset = "0x8C71B0", VA = "0x1808C7DB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public IEqualityComparer<T> DCOEGJIFCIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x8C7DC0", Offset = "0x8C71C0", VA = "0x1808C7DC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool AMNIFDIPNFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x3C786B0", Offset = "0x3C77AB0", VA = "0x183C786B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x47361A0", Offset = "0x47355A0", VA = "0x1847361A0")]
		private KOKINHJFCHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x4735BE0", Offset = "0x4734FE0", VA = "0x184735BE0")]
		public void EMOBGIHOLPD(MDJPMBFJJHE<T> AFKFJBCGION, [Optional] IEqualityComparer<T> GNOIOLAMEKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x4735990", Offset = "0x4734D90", VA = "0x184735990", Slot = "4")]
		public override void CDMKLDGEKPL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class EBGKDJBLLPM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly EOGMAPPNHPD AIJIHINIFPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly object NNFKOEODJCN;

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x72E05C0", Offset = "0x72DF9C0", VA = "0x1872E05C0")]
		public EBGKDJBLLPM(EOGMAPPNHPD AIJIHINIFPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x72E0590", Offset = "0x72DF990", VA = "0x1872E0590", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct MDLKBPJHHKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public EOGMAPPNHPD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public long playerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x72E6070", Offset = "0x72E5470", VA = "0x1872E6070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x72E6350", Offset = "0x72E5750", VA = "0x1872E6350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private struct KMAFNBEEKHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public EOGMAPPNHPD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public LLLJEAILJMD backingStoreToSave;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x72E55A0", Offset = "0x72E49A0", VA = "0x1872E55A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x926A70", Offset = "0x925E70", VA = "0x180926A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct JICFFHBBONH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public EOGMAPPNHPD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x72E5070", Offset = "0x72E4470", VA = "0x1872E5070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x72E5540", Offset = "0x72E4940", VA = "0x1872E5540", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class ODCNPPBMHGC : IEnumerator<ONHNFKGBFKG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private ONHNFKGBFKG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public EOGMAPPNHPD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public float seconds;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private ONHNFKGBFKG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x8CAD70", Offset = "0x8CA170", VA = "0x1808CAD70")]
		[DebuggerHidden]
		public ODCNPPBMHGC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x72E8240", Offset = "0x72E7640", VA = "0x1872E8240", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x72E82D0", Offset = "0x72E76D0", VA = "0x1872E82D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly CNIALIKCHHK JBOIJEJJDMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly CNIALIKCHHK JILALCHIIOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly IOGLODIPNLK NDDAHKLJKBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly OKKMFOFDAFG PGOFEEGHHLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly LBPPLJIKEGC.DBACGAMPEGO OHNDFOBAGDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly MFGPGCPLCOD MCHMDEPAJMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly HashSet<LLLJEAILJMD> PCMOEJEMKOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private Task GMELOJNCCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private Dictionary<string, string> EBBMNHAGICE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private GLHJGEGNDCM EBPIECIDANE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly object CFPEJNCOBFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly object JKKCFLOPAGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private long KBLBOFGEJBB;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private bool PCKKKIHBEPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x72E22B0", Offset = "0x72E16B0", VA = "0x1872E22B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private CancellationTokenSource KDAMEGAKBLN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x8CAEF0", Offset = "0x8CA2F0", VA = "0x1808CAEF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x8CAEB0", Offset = "0x8CA2B0", VA = "0x1808CAEB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action LOCEKBPOPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x72E3310", Offset = "0x72E2710", VA = "0x1872E3310", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x72E1EC0", Offset = "0x72E12C0", VA = "0x1872E1EC0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x72E26E0", Offset = "0x72E1AE0", VA = "0x1872E26E0")]
	[AGCFNMIICNN.OGAOPBBDHOG]
	internal static void MHHLPLPPGCP(CGJHFFGEHKC CLDCJHAFFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x72E33B0", Offset = "0x72E27B0", VA = "0x1872E33B0")]
	[UnityEngine.Scripting.Preserve]
	public EOGMAPPNHPD([CNGCCDLPGOD("Disk")] CNIALIKCHHK JBOIJEJJDMB, [CNGCCDLPGOD("Cloud")] CNIALIKCHHK JILALCHIIOK, [CNGCCDLPGOD(null)] IOGLODIPNLK NDDAHKLJKBK, [CNGCCDLPGOD(null)] OKKMFOFDAFG PGOFEEGHHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x72E0F30", Offset = "0x72E0330", VA = "0x1872E0F30", Slot = "44")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x72E0840", Offset = "0x72DFC40", VA = "0x1872E0840")]
	private void AGCKEOMOIBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x72E0EC0", Offset = "0x72E02C0", VA = "0x1872E0EC0", Slot = "6")]
	public void DJEPNGKOMIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x72E1F60", Offset = "0x72E1360", VA = "0x1872E1F60", Slot = "7")]
	public Task KEGOEMOKMDP(long JNAJMHABOGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x72E0A50", Offset = "0x72DFE50", VA = "0x1872E0A50")]
	[AsyncStateMachine(typeof(MDLKBPJHHKD))]
	private Task ALEFOLMADHK(long JNAJMHABOGO, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x72E2130", Offset = "0x72E1530", VA = "0x1872E2130")]
	private void KKJNEJNFEMD(object CMNJCPJBHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x72E1E40", Offset = "0x72E1240", VA = "0x1872E1E40")]
	private void JMHBCMDKCGG(object CMNJCPJBHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x72E2250", Offset = "0x72E1650", VA = "0x1872E2250")]
	private string LLGLPGKFFME(string DCOBFIHOILE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x72E2FD0", Offset = "0x72E23D0", VA = "0x1872E2FD0")]
	private void PDNHLPBCBNM(NCDPJOMIGGC PLNONKCNMPK, string LDCKBFKFIKC, [Out] CNIALIKCHHK DEAHBHHJGCK, [Out] string CBINMBIJMFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x72E2A00", Offset = "0x72E1E00", VA = "0x1872E2A00")]
	private CNIALIKCHHK NPBADLGCJJG(NCDPJOMIGGC PLNONKCNMPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x72E14B0", Offset = "0x72E08B0", VA = "0x1872E14B0", Slot = "8")]
	public bool ELDGBHMLOAA(NCDPJOMIGGC PLNONKCNMPK = NCDPJOMIGGC.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x72E0B60", Offset = "0x72DFF60", VA = "0x1872E0B60", Slot = "9")]
	public bool AMCKEAHNLKI(string NHHEMHBDHEB, NCDPJOMIGGC IMCNAFHMOON = NCDPJOMIGGC.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x72E2A80", Offset = "0x72E1E80", VA = "0x1872E2A80", Slot = "10")]
	public bool OAOJHFNAIKG(string NHHEMHBDHEB, NCDPJOMIGGC IMCNAFHMOON = NCDPJOMIGGC.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x72E2150", Offset = "0x72E1550", VA = "0x1872E2150", Slot = "11")]
	public string LDBCPILMJBF(string NHHEMHBDHEB, [Optional] string EKFBHIJFHMA, NCDPJOMIGGC IMCNAFHMOON = NCDPJOMIGGC.CLOUD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x72E17F0", Offset = "0x72E0BF0", VA = "0x1872E17F0", Slot = "12")]
	public IKGGMIOGKDK HEOCEGOMEGN(string NHHEMHBDHEB, string HCPAOILCJCB, NCDPJOMIGGC IMCNAFHMOON = NCDPJOMIGGC.CLOUD)
	{
		return default(IKGGMIOGKDK);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x72E23C0", Offset = "0x72E17C0", VA = "0x1872E23C0", Slot = "13")]
	public int MENDHODFING(string NHHEMHBDHEB, int EKFBHIJFHMA = 0, NCDPJOMIGGC IMCNAFHMOON = NCDPJOMIGGC.CLOUD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x72E3170", Offset = "0x72E2570", VA = "0x1872E3170", Slot = "14")]
	public IKGGMIOGKDK PGAPBDLAOOL(string NHHEMHBDHEB, int HCPAOILCJCB, NCDPJOMIGGC IMCNAFHMOON = NCDPJOMIGGC.CLOUD)
	{
		return default(IKGGMIOGKDK);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x72E0DE0", Offset = "0x72E01E0", VA = "0x1872E0DE0", Slot = "15")]
	public bool CLJJNBIGGOO(string NHHEMHBDHEB, bool EKFBHIJFHMA, NCDPJOMIGGC IMCNAFHMOON = NCDPJOMIGGC.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x72E0C70", Offset = "0x72E0070", VA = "0x1872E0C70", Slot = "16")]
	public IKGGMIOGKDK BOCMAONIPNN(string NHHEMHBDHEB, bool HCPAOILCJCB, NCDPJOMIGGC IMCNAFHMOON = NCDPJOMIGGC.CLOUD)
	{
		return default(IKGGMIOGKDK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x72E2CA0", Offset = "0x72E20A0", VA = "0x1872E2CA0", Slot = "17")]
	public float ODHBLODEFNK(string NHHEMHBDHEB, float EKFBHIJFHMA = 0f, NCDPJOMIGGC IMCNAFHMOON = NCDPJOMIGGC.CLOUD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x72E1330", Offset = "0x72E0730", VA = "0x1872E1330", Slot = "18")]
	public IKGGMIOGKDK EKHEDGCGBGJ(string NHHEMHBDHEB, float HCPAOILCJCB, NCDPJOMIGGC IMCNAFHMOON = NCDPJOMIGGC.CLOUD)
	{
		return default(IKGGMIOGKDK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x72E1290", Offset = "0x72E0690", VA = "0x1872E1290", Slot = "19")]
	public DateTime EJCEKDIPIDH(string NHHEMHBDHEB, [Optional] DateTime EKFBHIJFHMA, NCDPJOMIGGC IMCNAFHMOON = NCDPJOMIGGC.CLOUD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x72E0670", Offset = "0x72DFA70", VA = "0x1872E0670", Slot = "20")]
	public IKGGMIOGKDK ACKAHAKJKPG(string NHHEMHBDHEB, DateTime HCPAOILCJCB, NCDPJOMIGGC IMCNAFHMOON = NCDPJOMIGGC.CLOUD)
	{
		return default(IKGGMIOGKDK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x72E2750", Offset = "0x72E1B50", VA = "0x1872E2750", Slot = "21")]
	public long MIOLCOMHFBA(string NHHEMHBDHEB, long EKFBHIJFHMA = 0L, NCDPJOMIGGC IMCNAFHMOON = NCDPJOMIGGC.CLOUD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x72E1120", Offset = "0x72E0520", VA = "0x1872E1120", Slot = "22")]
	public IKGGMIOGKDK EGLLHBCLNAA(string NHHEMHBDHEB, long HCPAOILCJCB, NCDPJOMIGGC IMCNAFHMOON = NCDPJOMIGGC.CLOUD)
	{
		return default(IKGGMIOGKDK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x2EBD9E0", Offset = "0x2EBCDE0", VA = "0x182EBD9E0", Slot = "23")]
	public T NMKNIFBPKIF<T>(string NHHEMHBDHEB, [Optional] T EKFBHIJFHMA, NCDPJOMIGGC IMCNAFHMOON = NCDPJOMIGGC.CLOUD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x2EBD9E0", Offset = "0x2EBCDE0", VA = "0x182EBD9E0", Slot = "24")]
	public IKGGMIOGKDK MJABFLMEBJJ<T>(string NHHEMHBDHEB, T HCPAOILCJCB, NCDPJOMIGGC IMCNAFHMOON = NCDPJOMIGGC.CLOUD)
	{
		return default(IKGGMIOGKDK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x72E2C40", Offset = "0x72E2040", VA = "0x1872E2C40", Slot = "25")]
	public bool OCPJNAFAKJL(string NHHEMHBDHEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x72E17E0", Offset = "0x72E0BE0", VA = "0x1872E17E0", Slot = "26")]
	public bool GLIJEAEKBDI(string NHHEMHBDHEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x72E1AC0", Offset = "0x72E0EC0", VA = "0x1872E1AC0", Slot = "27")]
	public string IBGPNHCDOOG(string NHHEMHBDHEB, [Optional] string EKFBHIJFHMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x72E0E90", Offset = "0x72E0290", VA = "0x1872E0E90", Slot = "28")]
	public IKGGMIOGKDK DBFCNPKFFOI(string NHHEMHBDHEB, string HCPAOILCJCB)
	{
		return default(IKGGMIOGKDK);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x72E2820", Offset = "0x72E1C20", VA = "0x1872E2820", Slot = "29")]
	public int MJFGNCFAJMH(string NHHEMHBDHEB, int EKFBHIJFHMA = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x72E27F0", Offset = "0x72E1BF0", VA = "0x1872E27F0", Slot = "30")]
	public IKGGMIOGKDK MJFFHMOOKPO(string NHHEMHBDHEB, int HCPAOILCJCB)
	{
		return default(IKGGMIOGKDK);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x72E0C00", Offset = "0x72E0000", VA = "0x1872E0C00", Slot = "31")]
	public bool BCENAEAGBAF(string NHHEMHBDHEB, bool EKFBHIJFHMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x72E0810", Offset = "0x72DFC10", VA = "0x1872E0810", Slot = "32")]
	public IKGGMIOGKDK ACKDEEGNGHH(string NHHEMHBDHEB, bool HCPAOILCJCB)
	{
		return default(IKGGMIOGKDK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x72E0F70", Offset = "0x72E0370", VA = "0x1872E0F70", Slot = "33")]
	public float EAGGCFKPCOM(string NHHEMHBDHEB, float EKFBHIJFHMA = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x72E1750", Offset = "0x72E0B50", VA = "0x1872E1750", Slot = "34")]
	public IKGGMIOGKDK FFIEGKMDMGP(string NHHEMHBDHEB, float HCPAOILCJCB)
	{
		return default(IKGGMIOGKDK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x72E1A50", Offset = "0x72E0E50", VA = "0x1872E1A50", Slot = "35")]
	public DateTime HPMPDGJBOPD(string NHHEMHBDHEB, [Optional] DateTime EKFBHIJFHMA)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x72E32E0", Offset = "0x72E26E0", VA = "0x1872E32E0", Slot = "36")]
	public IKGGMIOGKDK PJEIAGMIMAH(string NHHEMHBDHEB, DateTime HCPAOILCJCB)
	{
		return default(IKGGMIOGKDK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x72E0890", Offset = "0x72DFC90", VA = "0x1872E0890", Slot = "37")]
	public long AIOEGBDDOCI(string NHHEMHBDHEB, long EKFBHIJFHMA = 0L)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x72E17B0", Offset = "0x72E0BB0", VA = "0x1872E17B0", Slot = "38")]
	public IKGGMIOGKDK GEJFCDHABKL(string NHHEMHBDHEB, long HCPAOILCJCB)
	{
		return default(IKGGMIOGKDK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x72E21F0", Offset = "0x72E15F0", VA = "0x1872E21F0")]
	private bool LKPGJDLHPHH(LLLJEAILJMD DEAHBHHJGCK, string NHHEMHBDHEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x72E1C00", Offset = "0x72E1000", VA = "0x1872E1C00")]
	private bool IMGIAPBFKLI(LLLJEAILJMD DEAHBHHJGCK, string NHHEMHBDHEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x72E1CF0", Offset = "0x72E10F0", VA = "0x1872E1CF0")]
	private IKGGMIOGKDK IPONFKPAGDC(LLLJEAILJMD DEAHBHHJGCK, string NHHEMHBDHEB, string HCPAOILCJCB)
	{
		return default(IKGGMIOGKDK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x72E2D50", Offset = "0x72E2150", VA = "0x1872E2D50")]
	private IKGGMIOGKDK OHDJIAPCLEG(LLLJEAILJMD DEAHBHHJGCK, string NHHEMHBDHEB, int HCPAOILCJCB)
	{
		return default(IKGGMIOGKDK);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x72E2E90", Offset = "0x72E2290", VA = "0x1872E2E90")]
	private IKGGMIOGKDK OKHPLAHBCED(LLLJEAILJMD DEAHBHHJGCK, string NHHEMHBDHEB, bool HCPAOILCJCB)
	{
		return default(IKGGMIOGKDK);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x72E0900", Offset = "0x72DFD00", VA = "0x1872E0900")]
	private IKGGMIOGKDK AKABCMLGFJP(LLLJEAILJMD DEAHBHHJGCK, string NHHEMHBDHEB, float HCPAOILCJCB)
	{
		return default(IKGGMIOGKDK);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x72E2890", Offset = "0x72E1C90", VA = "0x1872E2890")]
	private IKGGMIOGKDK NGCJKGFBHOM(LLLJEAILJMD DEAHBHHJGCK, string NHHEMHBDHEB, DateTime HCPAOILCJCB)
	{
		return default(IKGGMIOGKDK);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x72E0FE0", Offset = "0x72E03E0", VA = "0x1872E0FE0")]
	private IKGGMIOGKDK EEHEMOAPJKD(LLLJEAILJMD DEAHBHHJGCK, string NHHEMHBDHEB, long HCPAOILCJCB)
	{
		return default(IKGGMIOGKDK);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x2EBDD30", Offset = "0x2EBD130", VA = "0x182EBDD30")]
	private T OJEOIPHMELG<T>(LLLJEAILJMD DEAHBHHJGCK, string NHHEMHBDHEB, T EKFBHIJFHMA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x2EBCD50", Offset = "0x2EBC150", VA = "0x182EBCD50")]
	private IKGGMIOGKDK GDPKNHJHHAO<T>(LLLJEAILJMD DEAHBHHJGCK, string NHHEMHBDHEB, T HCPAOILCJCB)
	{
		return default(IKGGMIOGKDK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x2EBD930", Offset = "0x2EBCD30", VA = "0x182EBD930", Slot = "39")]
	public void JABJODOALKF<T>(MDJPMBFJJHE<T> PADHOKCDABG, [Optional] IEqualityComparer<T> GNOIOLAMEKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x2EBCCE0", Offset = "0x2EBC0E0", VA = "0x182EBCCE0", Slot = "40")]
	public void DOFDMKJFIAJ<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x72E1B30", Offset = "0x72E0F30", VA = "0x1872E1B30")]
	[AsyncStateMachine(typeof(KMAFNBEEKHB))]
	private void IDDCJOHEPLD(LLLJEAILJMD IPGGCHBABJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x72E22D0", Offset = "0x72E16D0", VA = "0x1872E22D0", Slot = "43")]
	[AsyncStateMachine(typeof(JICFFHBBONH))]
	public Task MAJDGAGMMPO([Optional] CancellationToken CMNJCPJBHGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x72E1570", Offset = "0x72E0970", VA = "0x1872E1570")]
	private void ELFOPJNGNHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x72E1970", Offset = "0x72E0D70", VA = "0x1872E1970", Slot = "41")]
	public IDisposable HGJLOEGMAOE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x72E0A40", Offset = "0x72DFE40", VA = "0x1872E0A40", Slot = "42")]
	public void ALBLGKFGPID(float CHFBMMDLDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x72E2470", Offset = "0x72E1870", VA = "0x1872E2470")]
	private void MGIPEAKDLPO(float MKOKLPMIJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x72E2BB0", Offset = "0x72E1FB0", VA = "0x1872E2BB0")]
	[IteratorStateMachine(typeof(ODCNPPBMHGC))]
	private IEnumerator<ONHNFKGBFKG> OBELLMJKICB(float CHFBMMDLDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x72E1780", Offset = "0x72E0B80", VA = "0x1872E1780")]
	[CompilerGenerated]
	private void GAMLJPNMBNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class OOFFHPMMNNE : DEELPEPLFAM<bool>
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static OOFFHPMMNNE ELEBKANKHDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x72E8690", Offset = "0x72E7A90", VA = "0x1872E8690")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x72E85A0", Offset = "0x72E79A0", VA = "0x1872E85A0", Slot = "9")]
	public override string GKPJGNLGAKF(bool AOOGNGKJLKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x72E8320", Offset = "0x72E7720", VA = "0x1872E8320", Slot = "10")]
	protected override bool GGPJAKMCGOF(string AOOGNGKJLKL, [Out] bool HCPAOILCJCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x72E8770", Offset = "0x72E7B70", VA = "0x1872E8770")]
	public OOFFHPMMNNE()
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
