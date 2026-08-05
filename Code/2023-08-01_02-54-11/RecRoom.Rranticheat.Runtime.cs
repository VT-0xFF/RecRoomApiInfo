using System;
using System.Reflection;
using Cpp2IlInjected;
using EasyAntiCheat.Client;
using EasyAntiCheat.Client.ClientAuth;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.AntiCheat
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class EACManager : MonoBehaviour, IGGHHNNODMJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ClientAuth FJDPNKPKNBN;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool HIFMFJMCBDG;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7299A70", Offset = "0x7298A70", VA = "0x187299A70")]
		public static string GenerateChallengeResponse(string GIIOIOEIDDK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x729A150", Offset = "0x7299150", VA = "0x18729A150")]
		private static void OPCJMOCBNGP(JNOGGOGOGKA.EKJKJJBJGAL KPMKPNDNMBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7299BF0", Offset = "0x7298BF0", VA = "0x187299BF0")]
		private static bool LGINAMDKNMO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7299F00", Offset = "0x7298F00", VA = "0x187299F00")]
		private static void OJDJIGKGHHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7299750", Offset = "0x7298750", VA = "0x187299750")]
		private static void ACNLACJCFDE(object JMBIDBPJKEO, LoadProgressEventArgs MHIFOGLEKPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7299870", Offset = "0x7298870", VA = "0x187299870")]
		private static void CLJAOAJGAKG(object JMBIDBPJKEO, LoadCompletedEventArgs MHIFOGLEKPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7299F90", Offset = "0x7298F90", VA = "0x187299F90")]
		private static void OJEBHCCMHKO(object JMBIDBPJKEO, StateChangedEventArgs MHIFOGLEKPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x729A410", Offset = "0x7299410", VA = "0x18729A410")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x729A580", Offset = "0x7299580", VA = "0x18729A580")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x729A230", Offset = "0x7299230", VA = "0x18729A230")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7299F00", Offset = "0x7298F00", VA = "0x187299F00")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7299BA0", Offset = "0x7298BA0", VA = "0x187299BA0")]
		private void INEJNPMBBAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x729A330", Offset = "0x7299330", VA = "0x18729A330", Slot = "4")]
		public void PushNetworkMessage(JNOGGOGOGKA.EKJKJJBJGAL KPMKPNDNMBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x966250", Offset = "0x965250", VA = "0x180966250")]
		public EACManager()
		{
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
