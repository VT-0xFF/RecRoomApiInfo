using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using UnityEngine.SceneManagement;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class DKKLPKLDFBC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private struct FPEGPGDBHFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public EPDEFLOOMAM<string>.GONHOPCHFID stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8FB8860", Offset = "0x8FB6E60", VA = "0x188FB8860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8FB8B60", Offset = "0x8FB7160", VA = "0x188FB8B60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x8FB8720", Offset = "0x8FB6D20", VA = "0x188FB8720")]
	[AsyncStateMachine(typeof(FPEGPGDBHFB))]
	[Obsolete("Use ISceneManagementService instead")]
	public static Task<Scene> DGLHEIPHMOJ(string BDKEKHKPFBF, LoadSceneMode PICBMDCLCAA = LoadSceneMode.Single, bool FMMKKPEOMHI = false, [Optional] EPDEFLOOMAM<string>.GONHOPCHFID PJJGCDICCOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x8FB85D0", Offset = "0x8FB6BD0", VA = "0x188FB85D0")]
	[Obsolete("Use ISceneManagementService instead")]
	public static LDNIFFJFEMD<Scene> BFJEEIHOPBO(string BDKEKHKPFBF, LoadSceneMode PICBMDCLCAA = LoadSceneMode.Single)
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
