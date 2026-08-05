using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface IGEFJPKAOOM
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x89D5A4A8025D0C5", Offset = "0x0", VA = "0x89D5A4C0025D0C5", Slot = "0")]
	void DEPKIJHIAAA(string PIFCPHPPMOP, string IIHNJADNLCI, bool NMGLBFBKBND);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x25D1708025D0D0", Offset = "0x0", VA = "0x25D1720025D0D0", Slot = "1")]
	void IIHFPCJEKNG();

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x25D17E889D6740", Offset = "0x0", VA = "0x25D180089D6740", Slot = "2")]
	void GFAEOCFAGJP();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x89E10C68025D2CA", Offset = "0x0", VA = "0x89E10C80025D2CA", Slot = "3")]
	void GHMPEOCIGHE();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x25D3D98025D2D0", Offset = "0x0", VA = "0x25D3DB0025D2D0", Slot = "4")]
	void PFJPICDDNIO(string JECLHHEOFCL, [Optional] string NFPMPHGKPNJ);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface NCGIMKKIFEJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool DENPAMHJMJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x25D3DE889D67C4", Offset = "0x0", VA = "0x25D3E0089D67C4", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x89D6AB28025D450", Offset = "0x0", VA = "0x89D6AB40025D450", Slot = "1")]
	Task AENKPEGAMPD();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x25D4A18025D450", Offset = "0x0", VA = "0x25D4A30025D450", Slot = "2")]
	void KINBCCGCMFP();
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
