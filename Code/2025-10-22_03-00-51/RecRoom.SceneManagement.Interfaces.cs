using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom.DataStructures.Times;
using RecRoom.ObjectModel;
using UnityEngine.SceneManagement;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.SceneManagement
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public interface HTUWLWBGCKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool KFAITRTDNJZ([Out] Scene? a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[ServiceLifetime(Lifetime.Application)]
	public interface WMLSAZACNDX
	{
		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action<string, LoadSceneMode> ZWLMWAFAFNT;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event Action XBRWCKKQIHE;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void IFMICFHYGRY(LoadSceneMode a);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<Scene> KKDNATEFMPS(string a, LoadSceneMode b = LoadSceneMode.Single, bool c = false, [Optional] StackTimer<string>.ERYHZSBUWXZ d);

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "6")]
		UWDFKAULHCP CreatePreloadRequest(string sceneName, LoadSceneMode loadSceneMode, CancellationToken externalToken);

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool NKNPKOXRCYR([Out] string a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface UWDFKAULHCP
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task BJKAHOWBEIF();

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<HTUWLWBGCKI> TENWFADTLDH();
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
