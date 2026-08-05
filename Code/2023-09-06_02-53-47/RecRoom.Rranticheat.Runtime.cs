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
	public class EACManager : MonoBehaviour, OHLGKLFADLL
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ClientAuth HMEDGDIMKNC;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool CGDAFPLGBKC;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6FC13C0", Offset = "0x6FBF9C0", VA = "0x186FC13C0")]
		public static string GenerateChallengeResponse(string FNMHIPAACHN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6FC12E0", Offset = "0x6FBF8E0", VA = "0x186FC12E0")]
		private static void FBEPJGHBLBJ(PMOBGCJEOJH.CLCNDHHDCOJ GFHGIIOIPBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6FC1580", Offset = "0x6FBFB80", VA = "0x186FC1580")]
		private static bool JGFKOKIDHIN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6FC14F0", Offset = "0x6FBFAF0", VA = "0x186FC14F0")]
		private static void JDJELCPJNDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6FC11C0", Offset = "0x6FBF7C0", VA = "0x186FC11C0")]
		private static void EPNCBFHDNAN(object EIJJNIMLEDC, LoadProgressEventArgs ALLEPMFIHDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6FC1B50", Offset = "0x6FC0150", VA = "0x186FC1B50")]
		private static void PNDIIFPFOEB(object EIJJNIMLEDC, LoadCompletedEventArgs ALLEPMFIHDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6FC1890", Offset = "0x6FBFE90", VA = "0x186FC1890")]
		private static void LHLFACBGHBO(object EIJJNIMLEDC, StateChangedEventArgs ALLEPMFIHDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6FC1E30", Offset = "0x6FC0430", VA = "0x186FC1E30")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6FC1FA0", Offset = "0x6FC05A0", VA = "0x186FC1FA0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6FC1A50", Offset = "0x6FC0050", VA = "0x186FC1A50")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6FC14F0", Offset = "0x6FBFAF0", VA = "0x186FC14F0")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6FC1170", Offset = "0x6FBF770", VA = "0x186FC1170")]
		private void BEIOHPLOGDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6FC1D50", Offset = "0x6FC0350", VA = "0x186FC1D50", Slot = "4")]
		public void PushNetworkMessage(PMOBGCJEOJH.CLCNDHHDCOJ GFHGIIOIPBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7EAA60", Offset = "0x7E9060", VA = "0x1807EAA60")]
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
