using System;
using System.Reflection;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface FNLFGFPFCLM
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public enum Reason
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Invalid,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Unknown,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		TestCase,
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		ServerDisconnect_ClientTimeout,
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		ServerDisconnect_ServerTimeout,
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		ServerDisconnect_ByServer,
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		ServerDisconnect_ByClient,
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		ServerDisconnect_Other,
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		PresenceUpdate_SentToInvalidInstance,
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		UnhandledExceptionDuringInitialRoomLoad,
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		UnhandledExceptionDuringNonInitialLoad,
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		PreloadScenesCanceled,
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		FallbackFailure_UnhandledException,
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		FallbackFailure_NoInternetConnection,
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		FallbackFailure_Timeout,
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		FallbackFailure_Cancelled,
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		FallbackFailure_EndedInInvalidInstance,
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		FallbackFailure_EndedInIncorrectInstance,
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		FallbackFailure_EndedInIncorrectScene,
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		FallbackFailure_AlreadyInTargetInstance,
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		FallbackFailure_MatchmakingError
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task MOKPKDEHJAC(Reason CIOGCOOPLBM = Reason.Unknown);
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
