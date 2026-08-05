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
	public class EACManager : MonoBehaviour, NOEEMBLAEBC
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ClientAuth HACCHBFHIOM;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool KGHCAKKHMEP;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x77816A0", Offset = "0x7780AA0", VA = "0x1877816A0")]
		public static string GenerateChallengeResponse(string GDKJKDOLADO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7781BA0", Offset = "0x7780FA0", VA = "0x187781BA0")]
		private static void NMCAKBFDGOG(COGIIOEGGJB.NFJHKKOBOPH PBJNGGAILNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7781C70", Offset = "0x7781070", VA = "0x187781C70")]
		private static bool NNDCCKKOOAE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7781B20", Offset = "0x7780F20", VA = "0x187781B20")]
		private static void KLBAFKLNAFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7781550", Offset = "0x7780950", VA = "0x187781550")]
		private static void DKEPACGHFJA(object HNHGEIDMCFO, LoadProgressEventArgs DCGLKKOBHOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x77817B0", Offset = "0x7780BB0", VA = "0x1877817B0")]
		private static void JCDIMHGCOAA(object HNHGEIDMCFO, LoadCompletedEventArgs DCGLKKOBHOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7781980", Offset = "0x7780D80", VA = "0x187781980")]
		private static void KAKOJHKGADF(object HNHGEIDMCFO, StateChangedEventArgs DCGLKKOBHOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7782130", Offset = "0x7781530", VA = "0x187782130")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x77822B0", Offset = "0x77816B0", VA = "0x1877822B0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7781F40", Offset = "0x7781340", VA = "0x187781F40")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7781B20", Offset = "0x7780F20", VA = "0x187781B20")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7781660", Offset = "0x7780A60", VA = "0x187781660")]
		private void EHKKDCOOBOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7782060", Offset = "0x7781460", VA = "0x187782060", Slot = "4")]
		public void PushNetworkMessage(COGIIOEGGJB.NFJHKKOBOPH PBJNGGAILNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D70", Offset = "0x8C6170", VA = "0x1808C6D70")]
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
