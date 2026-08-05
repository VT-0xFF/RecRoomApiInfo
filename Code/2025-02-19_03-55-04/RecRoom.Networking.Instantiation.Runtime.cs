using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.Foundation;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface CEMEPKDAOME
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	object PMEJJBMAOCG(GEDEGCEHLJI GMOJJMIJPJF);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject DKHDBGIBNNB(string BGKKCEGMOKH, Vector3 FCININPMBGJ, Quaternion APLHHNGOEFP, Vector3 PCNANBOKIPD, ViewId KFPFLKNFFBC, JLHPGPMALFI KNNHCEBFGKJ);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GameObject MDBMLNPMIKO(string BGKKCEGMOKH, Vector3 FCININPMBGJ, Quaternion APLHHNGOEFP, float PCNANBOKIPD, object[] KNNHCEBFGKJ);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GameObject DILLAPKIIEI(string BGKKCEGMOKH, Vector3 FCININPMBGJ, Quaternion APLHHNGOEFP, Vector3 PCNANBOKIPD, ViewId DPCLJPBHKAL, JLHPGPMALFI KNNHCEBFGKJ, bool CMHHKACCLBK = true);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GameObject OJFEMHNFPAI(POBDEPMCPMI KNNHCEBFGKJ);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MPAAAINIDAJ(GameObject PHPLOOLODCB);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CDFCBFANNAN(GameObject PHPLOOLODCB);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public struct POBDEPMCPMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public int[] AHHJKKFFCKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public byte PDNMLAACFGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public object[] LLDJIJICLJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public byte EFKBGLNDIKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public Vector3 PCNANBOKIPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Quaternion APLHHNGOEFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Vector3 FCININPMBGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public string IMLADFAALMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public GDNMNFALBCN LNIKHLPMKCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public int BHJPJPLFFEO;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7585E60", Offset = "0x7584A60", VA = "0x187585E60")]
	public POBDEPMCPMI(string IMLADFAALMK, Vector3 FCININPMBGJ, Quaternion APLHHNGOEFP, float PCNANBOKIPD, byte EFKBGLNDIKB, object[] LLDJIJICLJF, byte PDNMLAACFGF, int[] AHHJKKFFCKA, NIHEANECFCA LNIKHLPMKCN, int BHJPJPLFFEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7585FA0", Offset = "0x7584BA0", VA = "0x187585FA0")]
	public POBDEPMCPMI(string IMLADFAALMK, Vector3 FCININPMBGJ, Quaternion APLHHNGOEFP, Vector3 PCNANBOKIPD, byte EFKBGLNDIKB, object[] LLDJIJICLJF, byte PDNMLAACFGF, int[] AHHJKKFFCKA, NIHEANECFCA LNIKHLPMKCN, int BHJPJPLFFEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7585C90", Offset = "0x7584890", VA = "0x187585C90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class CPPNALGKKFM
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct MCHLMHAIJBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly CEMEPKDAOME APIKOMKCMFO;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xBDB470", Offset = "0xBDA070", VA = "0x180BDB470")]
		internal MCHLMHAIJBH(CEMEPKDAOME APIKOMKCMFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7585B90", Offset = "0x7584790", VA = "0x187585B90")]
		public void EMBOBGCAJMH(GEDEGCEHLJI GMOJJMIJPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7585C10", Offset = "0x7584810", VA = "0x187585C10")]
		public void MDMNJDIKGLA(GEDEGCEHLJI GMOJJMIJPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0")]
		private void DKLLMMOIELH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static ONIGKBMFFEH<GEDEGCEHLJI> LAAAEKAMDMM;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static ONIGKBMFFEH<GEDEGCEHLJI> IKELOICPOCG;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private static CEMEPKDAOME APIKOMKCMFO;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static MCHLMHAIJBH FDCLEEBDFHC;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x75854F0", Offset = "0x75840F0", VA = "0x1875854F0")]
	public static MCHLMHAIJBH LMKEFAFIIOB(CEMEPKDAOME APIKOMKCMFO)
	{
		return default(MCHLMHAIJBH);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x75859B0", Offset = "0x75845B0", VA = "0x1875859B0")]
	public static object PMEJJBMAOCG(GEDEGCEHLJI GMOJJMIJPJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x75850E0", Offset = "0x7583CE0", VA = "0x1875850E0")]
	public static GameObject DKHDBGIBNNB(string BGKKCEGMOKH, Vector3 FCININPMBGJ, Quaternion APLHHNGOEFP, Vector3 PCNANBOKIPD, ViewId KFPFLKNFFBC, JLHPGPMALFI KNNHCEBFGKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7585260", Offset = "0x7583E60", VA = "0x187585260")]
	public static GameObject DKHDBGIBNNB(string BGKKCEGMOKH, Vector3 FCININPMBGJ, Quaternion APLHHNGOEFP, float PCNANBOKIPD = 1f)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7584FE0", Offset = "0x7583BE0", VA = "0x187584FE0")]
	public static GameObject DKHDBGIBNNB(string BGKKCEGMOKH, Vector3 FCININPMBGJ, Quaternion APLHHNGOEFP, ViewId KFPFLKNFFBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x75853B0", Offset = "0x7583FB0", VA = "0x1875853B0")]
	public static GameObject DKHDBGIBNNB(string BGKKCEGMOKH, Vector3 FCININPMBGJ, Quaternion APLHHNGOEFP, float PCNANBOKIPD, ViewId KFPFLKNFFBC, JLHPGPMALFI KNNHCEBFGKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x75856F0", Offset = "0x75842F0", VA = "0x1875856F0")]
	public static GameObject MDBMLNPMIKO(string BGKKCEGMOKH, Vector3 FCININPMBGJ, Quaternion APLHHNGOEFP, float PCNANBOKIPD, object[] KNNHCEBFGKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7585570", Offset = "0x7584170", VA = "0x187585570")]
	public static GameObject MDBMLNPMIKO(string BGKKCEGMOKH, Vector3 FCININPMBGJ, Quaternion APLHHNGOEFP, [Optional] object[] KNNHCEBFGKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7584E40", Offset = "0x7583A40", VA = "0x187584E40")]
	public static GameObject DILLAPKIIEI(string BGKKCEGMOKH, Vector3 FCININPMBGJ, Quaternion APLHHNGOEFP, Vector3 PCNANBOKIPD, ViewId DPCLJPBHKAL, JLHPGPMALFI KNNHCEBFGKJ, bool CMHHKACCLBK = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x75858C0", Offset = "0x75844C0", VA = "0x1875858C0")]
	public static GameObject OJFEMHNFPAI(POBDEPMCPMI KNNHCEBFGKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7585840", Offset = "0x7584440", VA = "0x187585840")]
	public static void MPAAAINIDAJ(GameObject PHPLOOLODCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7584A40", Offset = "0x7583640", VA = "0x187584A40")]
	public static void CDFCBFANNAN(GameObject PHPLOOLODCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7584DA0", Offset = "0x75839A0", VA = "0x187584DA0")]
	public static GameObject CMCCFIEAJOD(string BGKKCEGMOKH, Vector3 FCININPMBGJ, Quaternion APLHHNGOEFP, bool CMHHKACCLBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7584AC0", Offset = "0x75836C0", VA = "0x187584AC0")]
	public static GameObject CMCCFIEAJOD(string BGKKCEGMOKH, Vector3 FCININPMBGJ, Quaternion APLHHNGOEFP, float PCNANBOKIPD = 1f)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7584B60", Offset = "0x7583760", VA = "0x187584B60")]
	public static GameObject CMCCFIEAJOD(string BGKKCEGMOKH, Vector3 FCININPMBGJ, Quaternion APLHHNGOEFP, float PCNANBOKIPD, bool CMHHKACCLBK)
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
