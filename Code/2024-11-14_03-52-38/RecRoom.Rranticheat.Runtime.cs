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
	public class EACManager : MonoBehaviour, FKAKGBKBBDI
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ClientAuth FMOAIILACGF;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool LCNKMJIFKIO;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x74A4120", Offset = "0x74A3520", VA = "0x1874A4120")]
		public static string GenerateChallengeResponse(string AEKIBEALKOA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x74A4230", Offset = "0x74A3630", VA = "0x1874A4230")]
		private static void HJLJOPDOJFN(CFAOPDCFAPP.DBNMKAICEDL AKKEJIFPDJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x74A44A0", Offset = "0x74A38A0", VA = "0x1874A44A0")]
		private static bool KKGJIMCEFBI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x74A4770", Offset = "0x74A3B70", VA = "0x1874A4770")]
		private static void KMOADLPPPPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x74A47F0", Offset = "0x74A3BF0", VA = "0x1874A47F0")]
		private static void LJCHFIBAFBJ(object CPBBDLJLGOC, LoadProgressEventArgs AGFPPIEOOIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x74A3F50", Offset = "0x74A3350", VA = "0x1874A3F50")]
		private static void ABDLFDNDDEK(object CPBBDLJLGOC, LoadCompletedEventArgs AGFPPIEOOIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x74A4300", Offset = "0x74A3700", VA = "0x1874A4300")]
		private static void JBOLHEJBKKG(object CPBBDLJLGOC, StateChangedEventArgs AGFPPIEOOIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x74A4B40", Offset = "0x74A3F40", VA = "0x1874A4B40")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x74A4CD0", Offset = "0x74A40D0", VA = "0x1874A4CD0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x74A4900", Offset = "0x74A3D00", VA = "0x1874A4900")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x74A4770", Offset = "0x74A3B70", VA = "0x1874A4770")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x74A4A30", Offset = "0x74A3E30", VA = "0x1874A4A30")]
		private void PCNMIDMHAKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x74A4A70", Offset = "0x74A3E70", VA = "0x1874A4A70", Slot = "4")]
		public void PushNetworkMessage(CFAOPDCFAPP.DBNMKAICEDL AKKEJIFPDJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x89BD20", Offset = "0x89B120", VA = "0x18089BD20")]
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
