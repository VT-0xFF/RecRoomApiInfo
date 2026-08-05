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
	public class EACManager : MonoBehaviour, GLLFOKCNGDP
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ClientAuth FBJGIKMNGIL;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool ECLNCIPJFIK;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x627DD10", Offset = "0x627CB10", VA = "0x18627DD10")]
		public static string GenerateChallengeResponse(string GAIFAAJLEDG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x627D690", Offset = "0x627C490", VA = "0x18627D690")]
		private static void CFDAJBFAOHA(IFMNPEGOFEC.LJGPPOMIJAE JOPBACODGFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x627D760", Offset = "0x627C560", VA = "0x18627D760")]
		private static bool EMIOGAELEFK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x627DE20", Offset = "0x627CC20", VA = "0x18627DE20")]
		private static void INHFAEFPNEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x627DC00", Offset = "0x627CA00", VA = "0x18627DC00")]
		private static void FEIEAHFBMKJ(object PHOOIAOPOPJ, LoadProgressEventArgs CNDINMMAKMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x627DA30", Offset = "0x627C830", VA = "0x18627DA30")]
		private static void FCFCOHLJLPJ(object PHOOIAOPOPJ, LoadCompletedEventArgs CNDINMMAKMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x627DEE0", Offset = "0x627CCE0", VA = "0x18627DEE0")]
		private static void MKILAJIGBMO(object PHOOIAOPOPJ, StateChangedEventArgs CNDINMMAKMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x627E280", Offset = "0x627D080", VA = "0x18627E280")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x627E410", Offset = "0x627D210", VA = "0x18627E410")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x627E080", Offset = "0x627CE80", VA = "0x18627E080")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x627DE20", Offset = "0x627CC20", VA = "0x18627DE20")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x627DEA0", Offset = "0x627CCA0", VA = "0x18627DEA0")]
		private void JHCHGJHNKPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x627E1B0", Offset = "0x627CFB0", VA = "0x18627E1B0", Slot = "4")]
		public void PushNetworkMessage(IFMNPEGOFEC.LJGPPOMIJAE JOPBACODGFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x75F1C0", Offset = "0x75DFC0", VA = "0x18075F1C0")]
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
