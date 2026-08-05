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
	public class EACManager : MonoBehaviour, MGMAEAPAPOI
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ClientAuth LAEJDCKFPEJ;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool GDGOCDMFAMI;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x76E9EF0", Offset = "0x76E86F0", VA = "0x1876E9EF0")]
		public static string GenerateChallengeResponse(string HOKDGCPLBIN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x76E98A0", Offset = "0x76E80A0", VA = "0x1876E98A0")]
		private static void AEPMMMPCGKI(CDAJFFBKJBH.PCPMGNJBCIE OANAMCHLGCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x76E9B10", Offset = "0x76E8310", VA = "0x1876E9B10")]
		private static bool DBNAIMAPKKN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x76EA000", Offset = "0x76E8800", VA = "0x1876EA000")]
		private static void JDKDBAFHBJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x76E9DE0", Offset = "0x76E85E0", VA = "0x1876E9DE0")]
		private static void EMKOHEJCECD(object FAMAOOCHGPA, LoadProgressEventArgs AHKKDIDGCIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x76EA0C0", Offset = "0x76E88C0", VA = "0x1876EA0C0")]
		private static void ONPBIJPGPIO(object FAMAOOCHGPA, LoadCompletedEventArgs AHKKDIDGCIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x76E9970", Offset = "0x76E8170", VA = "0x1876E9970")]
		private static void BICLEDDLBBM(object FAMAOOCHGPA, StateChangedEventArgs AHKKDIDGCIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x76EA490", Offset = "0x76E8C90", VA = "0x1876EA490")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x76EA620", Offset = "0x76E8E20", VA = "0x1876EA620")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x76EA290", Offset = "0x76E8A90", VA = "0x1876EA290")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x76EA000", Offset = "0x76E8800", VA = "0x1876EA000")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x76EA080", Offset = "0x76E8880", VA = "0x1876EA080")]
		private void NCLIPNCPMLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x76EA3C0", Offset = "0x76E8BC0", VA = "0x1876EA3C0", Slot = "4")]
		public void PushNetworkMessage(CDAJFFBKJBH.PCPMGNJBCIE OANAMCHLGCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8B6A90", Offset = "0x8B5290", VA = "0x1808B6A90")]
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
