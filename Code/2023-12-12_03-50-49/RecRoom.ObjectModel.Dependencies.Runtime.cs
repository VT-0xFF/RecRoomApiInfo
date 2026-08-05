using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using ExitGames.Client.Photon;
using RecRoom.CodeGen.Attributes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[GAMIKAOGCAJ(typeof(GKHENIBNOGI), new string[] { "Photon" })]
public class CIEFADHJBOD : MKBPNJOHGJA, GKHENIBNOGI, IDisposable, KFKNLJMNOGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	[MAEAEKFAHDI]
	private BFHMLLMLHKN EHNANOHAMAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[MAEAEKFAHDI]
	private AMDILEJFLEE NEMMMAFKEFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly Hashtable MJBJHGOBNAE;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5ED8D40", Offset = "0x5ED7540", VA = "0x185ED8D40", Slot = "4")]
	public void InitReferences(OFKKFGHIPBF EFCIJOEMPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5ED8940", Offset = "0x5ED7140", VA = "0x185ED8940", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5ED8BF0", Offset = "0x5ED73F0", VA = "0x185ED8BF0", Slot = "5")]
	public void IELKDNMCCHO(AKOOHFOHKCF EMBEECDJLJB, ReadOnlySpan<byte> IOHCLNMNKCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5ED8DE0", Offset = "0x5ED75E0", VA = "0x185ED8DE0", Slot = "9")]
	public void NOCMKFOEJIG(AKOOHFOHKCF DCCBHBIEIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5ED87D0", Offset = "0x5ED6FD0", VA = "0x185ED87D0", Slot = "6")]
	public void BOOMOPKJOPN(ReadOnlySpan<AKOOHFOHKCF> KPBMKEFFJHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5ED8990", Offset = "0x5ED7190", VA = "0x185ED8990")]
	private Hashtable EMBKJPNNIJF(Hashtable JPCFMJAAJOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5ED8300", Offset = "0x5ED6B00", VA = "0x185ED8300", Slot = "8")]
	private void AJLFPOJBOCC(EventData BKNFBMNNFJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5ED8EE0", Offset = "0x5ED76E0", VA = "0x185ED8EE0")]
	public CIEFADHJBOD()
	{
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Dependencies.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Preserve]
	internal class _RRAssemblyIndex : HHDBBJLHMIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x79C400", Offset = "0x79AC00", VA = "0x18079C400")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5ED8F60", Offset = "0x5ED7760", VA = "0x185ED8F60", Slot = "6")]
		public sealed override void EGCAFGLFJCE(AIFIIBGGMIK CGEKFPDGHCG)
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class ADJKIDCLGDK
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public ADJKIDCLGDK()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
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
