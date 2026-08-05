using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class DMPMIJEEMFH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum EHAFJKNGHFD
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void HJBGPBJDKNN(IntPtr EOEOAGFDHJP, int IANKEMBPHFD, int EGMDLBOEDPB);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int NMMCBMBFGMP
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x43EBBC0", Offset = "0x43EAFC0", VA = "0x1843EBBC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x43EBD20", Offset = "0x43EB120", VA = "0x1843EBD20")]
	private static extern void GGCHMIBFPEB(HJBGPBJDKNN KENEHOJCGJI);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x43EBE30", Offset = "0x43EB230", VA = "0x1843EBE30")]
	[MonoPInvokeCallback(typeof(HJBGPBJDKNN))]
	private static void OAJLKEIDIJG(IntPtr EOEOAGFDHJP, int IANKEMBPHFD, int EGMDLBOEDPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x43EBB50", Offset = "0x43EAF50", VA = "0x1843EBB50")]
	private static extern void ADKKKKDPMGD();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x43EBC30", Offset = "0x43EB030", VA = "0x1843EBC30")]
	private static extern void BCIFLFFGMCJ();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x43EBBC0", Offset = "0x43EAFC0", VA = "0x1843EBBC0")]
	private static extern int CHAJOIDCAOJ();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x43EBF50", Offset = "0x43EB350", VA = "0x1843EBF50")]
	private static extern int PCCBFIGIFBB(int KHLGBIBIKCB);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x43EBDB0", Offset = "0x43EB1B0", VA = "0x1843EBDB0")]
	private static extern int LFCNPCCOONA(int KHLGBIBIKCB);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x43EBAD0", Offset = "0x43EAED0", VA = "0x1843EBAD0")]
	private static extern int ADKDLLCLPHO(int KHLGBIBIKCB);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x43EBCA0", Offset = "0x43EB0A0", VA = "0x1843EBCA0")]
	private static extern int EDBPLLBDNGC(int KHLGBIBIKCB);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x43EC1C0", Offset = "0x43EB5C0", VA = "0x1843EC1C0")]
	public DMPMIJEEMFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x43EBC30", Offset = "0x43EB030", VA = "0x1843EBC30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x43EBFD0", Offset = "0x43EB3D0", VA = "0x1843EBFD0")]
	public Rect PMMIDFCJPFI(int CBKADAEFJAO)
	{
		return default(Rect);
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
