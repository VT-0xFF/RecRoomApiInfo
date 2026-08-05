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
	public interface XKPXRDXYUWY
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool DEOSOTHQJSX([Out] Scene? a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[ServiceLifetime(Lifetime.Application)]
	public interface XZONHRABVCZ
	{
		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action<string, LoadSceneMode> ZUMEZNCGURP;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event Action BBJYNCHNHBM;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void KBPBBQZYNEO(LoadSceneMode a);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<Scene> JRZUVWUOLAU(string a, LoadSceneMode b = LoadSceneMode.Single, bool c = false, [Optional] StackTimer<string>.FBXSUREIQOL d);

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "6")]
		EBNRGEMGOVN CreatePreloadRequest(string sceneName, LoadSceneMode loadSceneMode, CancellationToken externalToken);

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool AEQGNYRDPNL([Out] string a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface EBNRGEMGOVN
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task QFRTWWKFMYF();

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<XKPXRDXYUWY> NBIHGEXHKMB();
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
