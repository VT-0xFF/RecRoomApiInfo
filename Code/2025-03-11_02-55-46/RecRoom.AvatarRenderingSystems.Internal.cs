using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_AvatarRenderingSystems_Internal
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7425410", Offset = "0x7424810", VA = "0x187425410", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2491CF0", Offset = "0x24910F0", VA = "0x182491CF0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class MIHKAEAANHC : JEFBCMKPFCA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private NCECCEIGNON AEMMGFEFMOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private HDGOFKDDLOO AFMCHJKIMGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private IRecRoomQualityConfigProvider EOOMEPDHBLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private bool BGCFHENHHJD;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7424A90", Offset = "0x7423E90", VA = "0x187424A90")]
	[AEDFFNEEAKJ.AMNMLEGDOCC.LHJJLFEKIGK]
	internal static void CONODCJLAKA(LEPFMCICNAK EOMAFKDOFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x66952C0", Offset = "0x66946C0", VA = "0x1866952C0")]
	[UnityEngine.Scripting.Preserve]
	public MIHKAEAANHC([PNFCCJKFMBH(null)] HDGOFKDDLOO ADMPIJOGFNI, [PNFCCJKFMBH(null)] NCECCEIGNON HNDIHBMKFLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7425260", Offset = "0x7424660", VA = "0x187425260")]
	private void LLJLJALFEOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x74252F0", Offset = "0x74246F0", VA = "0x1874252F0", Slot = "4")]
	public void PBFOAMLBCKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7424CF0", Offset = "0x74240F0", VA = "0x187424CF0", Slot = "5")]
	public JCAOOGBCPCO<Texture2D> KALMHCOGLBC(HGLJPACMPOL OPBHNBPGOHL, [Optional] AIJALJOGGJG GAPCIOOOOMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7424B80", Offset = "0x7423F80", VA = "0x187424B80")]
	private uint EDDDIBMLIOL(HGLJPACMPOL OPBHNBPGOHL, AIJALJOGGJG GAPCIOOOOMF)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface JEFBCMKPFCA
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PBFOAMLBCKP();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JCAOOGBCPCO<Texture2D> KALMHCOGLBC(HGLJPACMPOL OPBHNBPGOHL, [Optional] AIJALJOGGJG GAPCIOOOOMF);
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
