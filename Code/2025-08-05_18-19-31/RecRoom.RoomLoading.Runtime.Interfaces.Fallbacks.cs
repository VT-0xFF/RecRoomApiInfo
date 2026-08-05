using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface PEKCJHOIPJA
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public struct PIIDCPGODEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public Reason HBHJOPNAJMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public string MDIIOAIEJHA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public enum Reason
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Invalid,
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		Unknown,
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		TestCase,
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		ServerDisconnect_ClientTimeout,
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		ServerDisconnect_ServerTimeout,
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		ServerDisconnect_ByServer,
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		ServerDisconnect_ByClient,
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		ServerDisconnect_Other,
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		PresenceUpdate_SentToInvalidInstance,
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		UnhandledExceptionDuringInitialRoomLoad,
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		UnhandledExceptionDuringNonInitialLoad,
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		PreloadScenesCanceled,
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		FallbackFailure_UnhandledException,
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		FallbackFailure_NoInternetConnection,
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		FallbackFailure_Timeout,
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		FallbackFailure_Cancelled,
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		FallbackFailure_EndedInInvalidInstance,
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		FallbackFailure_EndedInIncorrectInstance,
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		FallbackFailure_EndedInIncorrectScene,
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		FallbackFailure_AlreadyInTargetInstance,
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		FallbackFailure_MatchmakingError
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task KONFDCDBCBH(Reason HBHJOPNAJMN, [Optional] Exception GGJDDHMDBJI);
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
