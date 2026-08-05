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
	public interface FOJHXFKKPJX
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool JBLVLSZZDKM([Out] Scene? a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[ServiceLifetime(Lifetime.Application)]
	public interface MXLKQSWRTRW
	{
		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action<string, LoadSceneMode> NJMTJBAKJBK;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event Action MVQHEDORJMP;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void XILRTQQWPIF(LoadSceneMode a);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<Scene> WMWGCYWODHL(string a, LoadSceneMode b = LoadSceneMode.Single, bool c = false, [Optional] StackTimer<string>.GJROWUWUMTO d);

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "6")]
		EATHSIARBZK CreatePreloadRequest(string sceneName, LoadSceneMode loadSceneMode, CancellationToken externalToken);

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool NUUVNRSBTNG([Out] string a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface EATHSIARBZK
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task SLNIJFEJANC();

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<FOJHXFKKPJX> VCTKPDITPJU();
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
