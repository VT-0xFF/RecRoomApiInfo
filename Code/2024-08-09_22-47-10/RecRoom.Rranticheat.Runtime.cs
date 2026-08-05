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
	public class EACManager : MonoBehaviour, DPKEFDBDLHM
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ClientAuth OHJOMLOMONN;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool JDKKHFEAOFP;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7003DF0", Offset = "0x70031F0", VA = "0x187003DF0")]
		public static string GenerateChallengeResponse(string JPDFGOGGKNI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7004540", Offset = "0x7003940", VA = "0x187004540")]
		private static void LLBLKCIIIIC(DIHGKHBHMEI.ECNKHGANBFE OGPKCLEACHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7004010", Offset = "0x7003410", VA = "0x187004010")]
		private static bool JBMLOEIMACE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x70044C0", Offset = "0x70038C0", VA = "0x1870044C0")]
		private static void LDIIOHCDJCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7003F00", Offset = "0x7003300", VA = "0x187003F00")]
		private static void IMKHKIIOOCN(object PDEAGMAMIGL, LoadProgressEventArgs ONJCOCNGKAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7004610", Offset = "0x7003A10", VA = "0x187004610")]
		private static void MIDKAHJCKGC(object PDEAGMAMIGL, LoadCompletedEventArgs ONJCOCNGKAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7004320", Offset = "0x7003720", VA = "0x187004320")]
		private static void KFDHHHMCGHB(object PDEAGMAMIGL, StateChangedEventArgs ONJCOCNGKAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x70049E0", Offset = "0x7003DE0", VA = "0x1870049E0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7004B70", Offset = "0x7003F70", VA = "0x187004B70")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x70047E0", Offset = "0x7003BE0", VA = "0x1870047E0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x70044C0", Offset = "0x70038C0", VA = "0x1870044C0")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x70042E0", Offset = "0x70036E0", VA = "0x1870042E0")]
		private void JHAHNKHFLNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7004910", Offset = "0x7003D10", VA = "0x187004910", Slot = "4")]
		public void PushNetworkMessage(DIHGKHBHMEI.ECNKHGANBFE OGPKCLEACHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x84C210", Offset = "0x84B610", VA = "0x18084C210")]
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
