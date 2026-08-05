using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.Foundation;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface PBLBDCIMJBJ
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	object JEDJKJJPPBK(NDBHNEPADKO OJPIEODNKAI);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject ADKIFOELCOE(string GLGOHIJMLFB, Vector3 NCGKJMOKFAF, Quaternion PMHMEKBKJJA, Vector3 EGLHBCAIJLF, ViewId NFFPHNILNCJ, FIGGFBFOHNG KIAKHLGFPAF);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GameObject HCABNPMPOOA(string GLGOHIJMLFB, Vector3 NCGKJMOKFAF, Quaternion PMHMEKBKJJA, float EGLHBCAIJLF, object[] KIAKHLGFPAF);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GameObject GEEHELDGEMG(string GLGOHIJMLFB, Vector3 NCGKJMOKFAF, Quaternion PMHMEKBKJJA, Vector3 EGLHBCAIJLF, ViewId JNLFCOMKBMA, FIGGFBFOHNG KIAKHLGFPAF, bool INJHMDEOCOI = true);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GameObject BMLBAGJPGJG(HAMINJIIEJP KIAKHLGFPAF);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KECGFJGDNLA(GameObject KJMBGAPFJAM);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OJIDALGGOFA(GameObject KJMBGAPFJAM);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public struct HAMINJIIEJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public int[] POJMKNFPEOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public byte EAMIPNLMBHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public object[] NFNBKNAJBPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public byte DIKHGKFCIGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public Vector3 EGLHBCAIJLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Quaternion PMHMEKBKJJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Vector3 NCGKJMOKFAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public string OLMKGDACLDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public GFEBJDBBDID IJBDMIGIKHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public int MAFMFCGFAKE;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7C12360", Offset = "0x7C10B60", VA = "0x187C12360")]
	public HAMINJIIEJP(string OLMKGDACLDI, Vector3 NCGKJMOKFAF, Quaternion PMHMEKBKJJA, float EGLHBCAIJLF, byte DIKHGKFCIGP, object[] NFNBKNAJBPN, byte EAMIPNLMBHE, int[] POJMKNFPEOO, AHMCPLGEOJF IJBDMIGIKHG, int MAFMFCGFAKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7C122B0", Offset = "0x7C10AB0", VA = "0x187C122B0")]
	public HAMINJIIEJP(string OLMKGDACLDI, Vector3 NCGKJMOKFAF, Quaternion PMHMEKBKJJA, Vector3 EGLHBCAIJLF, byte DIKHGKFCIGP, object[] NFNBKNAJBPN, byte EAMIPNLMBHE, int[] POJMKNFPEOO, AHMCPLGEOJF IJBDMIGIKHG, int MAFMFCGFAKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7C120E0", Offset = "0x7C108E0", VA = "0x187C120E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7C11AE0", Offset = "0x7C102E0", VA = "0x187C11AE0")]
	public string BCJGNJNFJHP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class EHACLFCIFGE
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct FKLFGDNMJAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly PBLBDCIMJBJ CNGDGEJFJJG;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE50", Offset = "0xCEC650", VA = "0x180CEDE50")]
		internal FKLFGDNMJAK(PBLBDCIMJBJ CNGDGEJFJJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7C119E0", Offset = "0x7C101E0", VA = "0x187C119E0")]
		public void BKONKILIHNG(NDBHNEPADKO OJPIEODNKAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7C11A60", Offset = "0x7C10260", VA = "0x187C11A60")]
		public void CHPOLFOBKGK(NDBHNEPADKO OJPIEODNKAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
		private void HNJACEMFADH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static HOPADDCECBJ<NDBHNEPADKO> GMOKIGNPHMA;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static HOPADDCECBJ<NDBHNEPADKO> LEGJLGBNPNC;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static PBLBDCIMJBJ CNGDGEJFJJG;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static FKLFGDNMJAK FEFAOJMHOGN;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7C11460", Offset = "0x7C0FC60", VA = "0x187C11460")]
	public static FKLFGDNMJAK LMHOANNGINJ(PBLBDCIMJBJ CNGDGEJFJJG)
	{
		return default(FKLFGDNMJAK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7C11300", Offset = "0x7C0FB00", VA = "0x187C11300")]
	public static object JEDJKJJPPBK(NDBHNEPADKO OJPIEODNKAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7C10990", Offset = "0x7C0F190", VA = "0x187C10990")]
	public static GameObject ADKIFOELCOE(string GLGOHIJMLFB, Vector3 NCGKJMOKFAF, Quaternion PMHMEKBKJJA, Vector3 EGLHBCAIJLF, ViewId NFFPHNILNCJ, FIGGFBFOHNG KIAKHLGFPAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7C10B10", Offset = "0x7C0F310", VA = "0x187C10B10")]
	public static GameObject ADKIFOELCOE(string GLGOHIJMLFB, Vector3 NCGKJMOKFAF, Quaternion PMHMEKBKJJA, float EGLHBCAIJLF = 1f)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7C10890", Offset = "0x7C0F090", VA = "0x187C10890")]
	public static GameObject ADKIFOELCOE(string GLGOHIJMLFB, Vector3 NCGKJMOKFAF, Quaternion PMHMEKBKJJA, ViewId NFFPHNILNCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7C10C60", Offset = "0x7C0F460", VA = "0x187C10C60")]
	public static GameObject ADKIFOELCOE(string GLGOHIJMLFB, Vector3 NCGKJMOKFAF, Quaternion PMHMEKBKJJA, float EGLHBCAIJLF, ViewId NFFPHNILNCJ, FIGGFBFOHNG KIAKHLGFPAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7C111B0", Offset = "0x7C0F9B0", VA = "0x187C111B0")]
	public static GameObject HCABNPMPOOA(string GLGOHIJMLFB, Vector3 NCGKJMOKFAF, Quaternion PMHMEKBKJJA, float EGLHBCAIJLF, object[] KIAKHLGFPAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7C11030", Offset = "0x7C0F830", VA = "0x187C11030")]
	public static GameObject HCABNPMPOOA(string GLGOHIJMLFB, Vector3 NCGKJMOKFAF, Quaternion PMHMEKBKJJA, [Optional] object[] KIAKHLGFPAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7C10E90", Offset = "0x7C0F690", VA = "0x187C10E90")]
	public static GameObject GEEHELDGEMG(string GLGOHIJMLFB, Vector3 NCGKJMOKFAF, Quaternion PMHMEKBKJJA, Vector3 EGLHBCAIJLF, ViewId JNLFCOMKBMA, FIGGFBFOHNG KIAKHLGFPAF, bool INJHMDEOCOI = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7C10DA0", Offset = "0x7C0F5A0", VA = "0x187C10DA0")]
	public static GameObject BMLBAGJPGJG(HAMINJIIEJP KIAKHLGFPAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7C113E0", Offset = "0x7C0FBE0", VA = "0x187C113E0")]
	public static void KECGFJGDNLA(GameObject KJMBGAPFJAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7C11860", Offset = "0x7C10060", VA = "0x187C11860")]
	public static void OJIDALGGOFA(GameObject KJMBGAPFJAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7C117C0", Offset = "0x7C0FFC0", VA = "0x187C117C0")]
	public static GameObject NJKDNLBMLDO(string GLGOHIJMLFB, Vector3 NCGKJMOKFAF, Quaternion PMHMEKBKJJA, bool INJHMDEOCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7C114E0", Offset = "0x7C0FCE0", VA = "0x187C114E0")]
	public static GameObject NJKDNLBMLDO(string GLGOHIJMLFB, Vector3 NCGKJMOKFAF, Quaternion PMHMEKBKJJA, float EGLHBCAIJLF = 1f)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7C11580", Offset = "0x7C0FD80", VA = "0x187C11580")]
	public static GameObject NJKDNLBMLDO(string GLGOHIJMLFB, Vector3 NCGKJMOKFAF, Quaternion PMHMEKBKJJA, float EGLHBCAIJLF, bool INJHMDEOCOI)
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
