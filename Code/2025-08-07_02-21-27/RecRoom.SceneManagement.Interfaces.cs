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
	public interface QOIZLNOTUDV
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x3B6F1E8D8555A0", Offset = "0x0", VA = "0x3B6F200D8555A0", Slot = "0")]
		bool DBPYNMDLMUS([Out] Scene? a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[ServiceLifetime(Lifetime.Application)]
	public interface GJPMDBUTLZM
	{
		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action<string, LoadSceneMode> TPRPQEPFLES;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event Action PQKDNNTQNRL;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3B7058803B6FF0", Offset = "0x0", VA = "0x3B705A003B6FF0", Slot = "4")]
		void NotifyBeforeEmptySceneTransition(LoadSceneMode loadSceneMode);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3B705E8D855588", Offset = "0x0", VA = "0x3B70600D855588", Slot = "5")]
		Task<Scene> RTOQRBBVAOT(string a, LoadSceneMode b = LoadSceneMode.Single, bool c = false, [Optional] StackTimer<string>.YOQUQHZDBKW d);

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xD85559E803B7097", Offset = "0x0", VA = "0xD8555A0003B7097", Slot = "6")]
		EYSFXLFSQHI CreatePreloadRequest(string sceneName, LoadSceneMode loadSceneMode, CancellationToken externalToken);

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3B7108803B70A0", Offset = "0x0", VA = "0x3B710A003B70A0", Slot = "7")]
		bool GTNHDMWIJMG([Out] string a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface EYSFXLFSQHI
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3B710E8D855588", Offset = "0x0", VA = "0x3B71100D855588", Slot = "0")]
		Task AUXCSWJWBVE();

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xD855586803B717A", Offset = "0x0", VA = "0xD855588003B717A", Slot = "1")]
		Task<QOIZLNOTUDV> UFNNRPTMFDK();
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
