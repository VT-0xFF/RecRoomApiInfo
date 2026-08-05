using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[Flags]
public enum BBKDDPGNAMP : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Moderation = 2,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Platform = 4,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	RecNetJunior = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Settings = 0x20
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[Flags]
public enum MIBKHGFACCP : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Party = 0x12,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	FavoriteFriend = 0x1C,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Friend = 0x18,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Any = 0x10
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface KIIIEFGAAIL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DGDMIHNGMPM([Out] BBKDDPGNAMP DOMPPLFDODN);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FDLIDHGKNAO([Out] BBKDDPGNAMP DOMPPLFDODN);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LEGCNGNGOGD([Out] BBKDDPGNAMP DOMPPLFDODN);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MOBOEBOBADN(MIBKHGFACCP MDBMIANLKJL, [Out] BBKDDPGNAMP DOMPPLFDODN);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool EBNMNJCGIJE([Out] BBKDDPGNAMP DOMPPLFDODN);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool HEJJLHPKLJN([Out] BBKDDPGNAMP DOMPPLFDODN);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool NPFLJPDKAMF([Out] BBKDDPGNAMP DOMPPLFDODN);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool IFKGKJLBJJE([Out] BBKDDPGNAMP DOMPPLFDODN);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool MBCLNPDCOHM([Out] BBKDDPGNAMP DOMPPLFDODN);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool GMJFNMOHHFH([Out] BBKDDPGNAMP DOMPPLFDODN);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool PLKCBJFFPIG([Out] BBKDDPGNAMP DOMPPLFDODN);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool ODNBHEGBHNB([Out] BBKDDPGNAMP DOMPPLFDODN);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool GLCECCIKKOP([Out] BBKDDPGNAMP DOMPPLFDODN);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool MDDHMAKIDKM([Out] BBKDDPGNAMP DOMPPLFDODN);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool KJFDPJNGKLC(PGLGCDILEIF OHFKKBBPIMM, [Out] BBKDDPGNAMP DOMPPLFDODN);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool PEOGMBJPMBO(EAPGABEIHFJ OHFKKBBPIMM, [Out] BBKDDPGNAMP DOMPPLFDODN);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool AGPGNHKJIGN([Out] BBKDDPGNAMP DOMPPLFDODN);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool JANONHPCIFP([Out] BBKDDPGNAMP DOMPPLFDODN);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool LFLINDOMOKB([Out] BBKDDPGNAMP DOMPPLFDODN);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool LAMNOONMJHK([Out] BBKDDPGNAMP DOMPPLFDODN);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "20")]
	bool FEOEEKOIIHM([Out] BBKDDPGNAMP DOMPPLFDODN);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool PJJABDEOCCA([Out] BBKDDPGNAMP DOMPPLFDODN);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool JNCDEPFPBED(ONBFJGJMALO HKKFANGDDDO, [Out] BBKDDPGNAMP DOMPPLFDODN);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "23")]
	bool OLCHAFOAMBJ([Out] BBKDDPGNAMP DOMPPLFDODN);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "24")]
	bool MEPBNKFLCPP([Out] BBKDDPGNAMP DOMPPLFDODN);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "25")]
	bool LHPFLKLKGII([Out] BBKDDPGNAMP DOMPPLFDODN);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "26")]
	bool AOLOHBKFCKE([Out] BBKDDPGNAMP DOMPPLFDODN);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool JEANNALPLDJ(AJGNGODENEC EINEGMFIPMP, [Out] BBKDDPGNAMP DOMPPLFDODN);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "28")]
	bool PJGCEAPCDBB([Out] BBKDDPGNAMP DOMPPLFDODN);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool LLLBIDBEIDI([Out] BBKDDPGNAMP DOMPPLFDODN);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool KLIKOENIKCP([Out] BBKDDPGNAMP DOMPPLFDODN);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "31")]
	bool IKJFBOPLECG([Out] BBKDDPGNAMP DOMPPLFDODN);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "32")]
	bool MIKPFFBMNJH([Out] BBKDDPGNAMP DOMPPLFDODN);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "33")]
	string EJFHBOHFMAL(BBKDDPGNAMP GDOFJBNLBFB);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class IGLDIOFCHKG
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6B44780", Offset = "0x6B43180", VA = "0x186B44780")]
	public static bool JGHDHAIHFEN(this KIIIEFGAAIL HNBLGIKEBNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6B44550", Offset = "0x6B42F50", VA = "0x186B44550")]
	public static bool JEABCGGNEPO(this KIIIEFGAAIL HNBLGIKEBNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6B43E70", Offset = "0x6B42870", VA = "0x186B43E70")]
	public static bool DGDMIHNGMPM(this KIIIEFGAAIL HNBLGIKEBNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6B43FD0", Offset = "0x6B429D0", VA = "0x186B43FD0")]
	public static bool FDLIDHGKNAO(this KIIIEFGAAIL HNBLGIKEBNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6B44BF0", Offset = "0x6B435F0", VA = "0x186B44BF0")]
	public static bool LEGCNGNGOGD(this KIIIEFGAAIL HNBLGIKEBNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6B45170", Offset = "0x6B43B70", VA = "0x186B45170")]
	public static bool MOBOEBOBADN(this KIIIEFGAAIL HNBLGIKEBNI, MIBKHGFACCP MDBMIANLKJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6B43F20", Offset = "0x6B42920", VA = "0x186B43F20")]
	public static bool EBNMNJCGIJE(this KIIIEFGAAIL HNBLGIKEBNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6B44290", Offset = "0x6B42C90", VA = "0x186B44290")]
	public static bool HEJJLHPKLJN(this KIIIEFGAAIL HNBLGIKEBNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6B45240", Offset = "0x6B43C40", VA = "0x186B45240")]
	public static bool NPFLJPDKAMF(this KIIIEFGAAIL HNBLGIKEBNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6B44340", Offset = "0x6B42D40", VA = "0x186B44340")]
	public static bool IFKGKJLBJJE(this KIIIEFGAAIL HNBLGIKEBNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6B44EB0", Offset = "0x6B438B0", VA = "0x186B44EB0")]
	public static bool MBCLNPDCOHM(this KIIIEFGAAIL HNBLGIKEBNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6B441E0", Offset = "0x6B42BE0", VA = "0x186B441E0")]
	public static bool GMJFNMOHHFH(this KIIIEFGAAIL HNBLGIKEBNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6B45680", Offset = "0x6B44080", VA = "0x186B45680")]
	public static bool PLKCBJFFPIG(this KIIIEFGAAIL HNBLGIKEBNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6B452F0", Offset = "0x6B43CF0", VA = "0x186B452F0")]
	public static bool ODNBHEGBHNB(this KIIIEFGAAIL HNBLGIKEBNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6B44130", Offset = "0x6B42B30", VA = "0x186B44130")]
	public static bool GLCECCIKKOP(this KIIIEFGAAIL HNBLGIKEBNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6B44F60", Offset = "0x6B43960", VA = "0x186B44F60")]
	public static bool MDDHMAKIDKM(this KIIIEFGAAIL HNBLGIKEBNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6B449C0", Offset = "0x6B433C0", VA = "0x186B449C0")]
	public static bool KJFDPJNGKLC(this KIIIEFGAAIL HNBLGIKEBNI, PGLGCDILEIF OHFKKBBPIMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6B45450", Offset = "0x6B43E50", VA = "0x186B45450")]
	public static bool PEOGMBJPMBO(this KIIIEFGAAIL HNBLGIKEBNI, EAPGABEIHFJ OHFKKBBPIMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6B43D10", Offset = "0x6B42710", VA = "0x186B43D10")]
	public static bool AGPGNHKJIGN(this KIIIEFGAAIL HNBLGIKEBNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6B444A0", Offset = "0x6B42EA0", VA = "0x186B444A0")]
	public static bool JANONHPCIFP(this KIIIEFGAAIL HNBLGIKEBNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6B44CA0", Offset = "0x6B436A0", VA = "0x186B44CA0")]
	public static bool LFLINDOMOKB(this KIIIEFGAAIL HNBLGIKEBNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6B44B40", Offset = "0x6B43540", VA = "0x186B44B40")]
	public static bool LAMNOONMJHK(this KIIIEFGAAIL HNBLGIKEBNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6B44080", Offset = "0x6B42A80", VA = "0x186B44080")]
	public static bool FEOEEKOIIHM(this KIIIEFGAAIL HNBLGIKEBNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6B455D0", Offset = "0x6B43FD0", VA = "0x186B455D0")]
	public static bool PJJABDEOCCA(this KIIIEFGAAIL HNBLGIKEBNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6B448F0", Offset = "0x6B432F0", VA = "0x186B448F0")]
	public static bool JNCDEPFPBED(this KIIIEFGAAIL HNBLGIKEBNI, ONBFJGJMALO HKKFANGDDDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6B453A0", Offset = "0x6B43DA0", VA = "0x186B453A0")]
	public static bool OLCHAFOAMBJ(this KIIIEFGAAIL HNBLGIKEBNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6B45010", Offset = "0x6B43A10", VA = "0x186B45010")]
	public static bool MEPBNKFLCPP(this KIIIEFGAAIL HNBLGIKEBNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6B44D50", Offset = "0x6B43750", VA = "0x186B44D50")]
	public static bool LHPFLKLKGII(this KIIIEFGAAIL HNBLGIKEBNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6B43DC0", Offset = "0x6B427C0", VA = "0x186B43DC0")]
	public static bool AOLOHBKFCKE(this KIIIEFGAAIL HNBLGIKEBNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6B446C0", Offset = "0x6B430C0", VA = "0x186B446C0")]
	public static bool JEANNALPLDJ(this KIIIEFGAAIL HNBLGIKEBNI, AJGNGODENEC EINEGMFIPMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6B45520", Offset = "0x6B43F20", VA = "0x186B45520")]
	public static bool PJGCEAPCDBB(this KIIIEFGAAIL HNBLGIKEBNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6B44E00", Offset = "0x6B43800", VA = "0x186B44E00")]
	public static bool LLLBIDBEIDI(this KIIIEFGAAIL HNBLGIKEBNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6B44A90", Offset = "0x6B43490", VA = "0x186B44A90")]
	public static bool KLIKOENIKCP(this KIIIEFGAAIL HNBLGIKEBNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6B443F0", Offset = "0x6B42DF0", VA = "0x186B443F0")]
	public static bool IKJFBOPLECG(this KIIIEFGAAIL HNBLGIKEBNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6B450C0", Offset = "0x6B43AC0", VA = "0x186B450C0")]
	public static bool MIKPFFBMNJH(this KIIIEFGAAIL HNBLGIKEBNI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[Flags]
public enum DIHIFFEPKJJ : byte
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	Party = 2,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	FavoriteFriend = 4,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	Friend = 8,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	Any = 0x10
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[Flags]
public enum ECPBKKNIJPC : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	Party = 2,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	FavoriteFriends = 4,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	Friends = 0xC,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	PartyAndFavoriteFriends = 6,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	PartyAndFriends = 0xE,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	All = 0x1E
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[Flags]
public enum PGLGCDILEIF : byte
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	Dorm = 2,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	All = 0xA
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[Flags]
public enum EAPGABEIHFJ : byte
{
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	TransientDormOnly = 2,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	SavedDorm = 4,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	All = 0xC
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[Flags]
public enum ONBFJGJMALO : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	RegularObjects = 2,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	ConditionallyRestrictedObjects = 6
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[Flags]
public enum AJGNGODENEC
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	UnblockedCreators = 2,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	All = 6
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface NEDBLDKFICL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	BBKDDPGNAMP KMAKAKJPENG
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool DGDMIHNGMPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool FDLIDHGKNAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	ECPBKKNIJPC OFNFHDAGFEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool EBNMNJCGIJE
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool HEJJLHPKLJN
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool NPFLJPDKAMF
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool IFKGKJLBJJE
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool MBCLNPDCOHM
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool GMJFNMOHHFH
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool PLKCBJFFPIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool ODNBHEGBHNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool GLCECCIKKOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool MDDHMAKIDKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	PGLGCDILEIF DGEDEHAHGKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	EAPGABEIHFJ LDPDFANNLKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool AGPGNHKJIGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool JANONHPCIFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool LFLINDOMOKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool LAMNOONMJHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool FEOEEKOIIHM
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool PJJABDEOCCA
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	ONBFJGJMALO IJGANDJOKPO
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool OLCHAFOAMBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool MEPBNKFLCPP
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool LHPFLKLKGII
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool AOLOHBKFCKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	AJGNGODENEC NOKODOADHKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool PJGCEAPCDBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool LLLBIDBEIDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool KLIKOENIKCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool IKJFBOPLECG
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool MIKPFFBMNJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class DLABJGGCDDI
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6B43CA0", Offset = "0x6B426A0", VA = "0x186B43CA0")]
	public static string FCMBCGBBNFJ(BBKDDPGNAMP LBIKMBJEOGO)
	{
		return null;
	}
}
namespace Cpp2IlInjected;

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
