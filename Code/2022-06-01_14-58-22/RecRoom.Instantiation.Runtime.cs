using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Photon.Pun;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class HEAHFCDCNLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid IAPGAKFEAOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string JCJIFILDBBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int FKENMGOBNGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid CDNDIFPHMEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly BGMHBOACANG POFJDBNEGNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 CPAEDDCMNCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion EPEBAEMCCEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public float DDDAANLCBKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool DNGMKIIKDKJ;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4E8B360", Offset = "0x4E89D60", VA = "0x184E8B360")]
	public HEAHFCDCNLA(string KJMAICHHGGP, Guid PDPDCPCIAIF, int FDBHLJDFFBO, Guid MKDGLLMOBMC, BGMHBOACANG MBGFNNCFCBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4E8B110", Offset = "0x4E89B10", VA = "0x184E8B110")]
	public HFIHNLKEIPO.KKDLLDEJABK HENEPMIBEIF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4E8B2B0", Offset = "0x4E89CB0", VA = "0x184E8B2B0")]
	public NAMOPKHHODN HPOOPHKBCKP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class BGMHBOACANG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, object> PGBBKDGHBPO;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x4E8B090", Offset = "0x4E89A90", VA = "0x184E8B090")]
	public BGMHBOACANG([Optional] Dictionary<string, object> PGBBKDGHBPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4E8AF10", Offset = "0x4E89910", VA = "0x184E8AF10")]
	[NotNull]
	public static BGMHBOACANG KJHLDGBMJAH(PhotonView DBBJEPNCCKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x32E11F0", Offset = "0x32DFBF0", VA = "0x1832E11F0")]
	public bool FIJKPMMFIIC<T>(string IPKOPOLJGIA, out T HPIAFNBPEPC) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2ED77A0", Offset = "0x2ED61A0", VA = "0x182ED77A0")]
	public void DDDJGAONDCK<T>(string IPKOPOLJGIA, T HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4E8AEB0", Offset = "0x4E898B0", VA = "0x184E8AEB0")]
	public void DFDJPGANONL(string IPKOPOLJGIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x564480", Offset = "0x562E80", VA = "0x180564480")]
	public Dictionary<string, object> HGCEJFOEDBP()
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
