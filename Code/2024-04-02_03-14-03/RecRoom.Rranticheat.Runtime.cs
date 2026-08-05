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
	public class EACManager : MonoBehaviour, COAPDMLGPKO
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ClientAuth HNMJHGGHFPL;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool PGAHGOIJENK;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6788A90", Offset = "0x6787690", VA = "0x186788A90")]
		public static string GenerateChallengeResponse(string PPHKBEIIFJD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6788BA0", Offset = "0x67877A0", VA = "0x186788BA0")]
		private static void IBLPIDJBFJI(CALHLEJEMPF.OGLFKEALPLN FGGJAKAMDOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6788FE0", Offset = "0x6787BE0", VA = "0x186788FE0")]
		private static bool NGNBGAGMMIG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x67892B0", Offset = "0x6787EB0", VA = "0x1867892B0")]
		private static void OMCJCKKOCJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6788940", Offset = "0x6787540", VA = "0x186788940")]
		private static void GAFBGDOCNEK(object EBLNMKJEDPC, LoadProgressEventArgs IECADNEOACM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6788E10", Offset = "0x6787A10", VA = "0x186788E10")]
		private static void LBMMLKCDAFH(object EBLNMKJEDPC, LoadCompletedEventArgs IECADNEOACM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6788C70", Offset = "0x6787870", VA = "0x186788C70")]
		private static void KINEOBICEKG(object EBLNMKJEDPC, StateChangedEventArgs IECADNEOACM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6789530", Offset = "0x6788130", VA = "0x186789530")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x67896C0", Offset = "0x67882C0", VA = "0x1867896C0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6789330", Offset = "0x6787F30", VA = "0x186789330")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x67892B0", Offset = "0x6787EB0", VA = "0x1867892B0")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6788A50", Offset = "0x6787650", VA = "0x186788A50")]
		private void GJDAMIDLJDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6789460", Offset = "0x6788060", VA = "0x186789460", Slot = "4")]
		public void PushNetworkMessage(CALHLEJEMPF.OGLFKEALPLN FGGJAKAMDOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7B01F0", Offset = "0x7AEDF0", VA = "0x1807B01F0")]
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
