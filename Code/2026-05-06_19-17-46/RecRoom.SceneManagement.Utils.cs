using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom.Async;
using RecRoom.DataStructures.Times;
using UnityEngine.SceneManagement;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public static class BUOBGYHTXMW
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		[CompilerGenerated]
		private struct <LoadSceneAsync>d__7 : IAsyncStateMachine
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
			public StackTimer<string>.OEAKSWPXIMF stackTimerScope;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			private TaskAwaiter<Scene> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xA35C6D0", Offset = "0xA35B0D0", VA = "0x18A35C6D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xA35C9D0", Offset = "0xA35B3D0", VA = "0x18A35C9D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA35C590", Offset = "0xA35AF90", VA = "0x18A35C590")]
		[AsyncStateMachine(typeof(<LoadSceneAsync>d__7))]
		[Obsolete("Use ISceneManagementService instead")]
		public static Task<Scene> WEQBXWETJKK(string a, LoadSceneMode b = LoadSceneMode.Single, bool c = false, [Optional] StackTimer<string>.OEAKSWPXIMF d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA35C440", Offset = "0xA35AE40", VA = "0x18A35C440")]
		[Obsolete("Use ISceneManagementService instead")]
		public static FCGSBMYYMMV<Scene> LoadScene(string sceneName, LoadSceneMode loadSceneMode = LoadSceneMode.Single)
		{
			return null;
		}
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
