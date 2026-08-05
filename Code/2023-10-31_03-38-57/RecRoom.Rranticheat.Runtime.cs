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
	public class EACManager : MonoBehaviour, JPAJFDAFAMA
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ClientAuth IDBINEMKPOH;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool IOMKIECLNJG;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x627C120", Offset = "0x627B520", VA = "0x18627C120")]
		public static string GenerateChallengeResponse(string JEBBIEADEBG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x627BE80", Offset = "0x627B280", VA = "0x18627BE80")]
		private static void DIJJDOKFOGF(OBHMDHOGMEE.AKIPKAGFHFD HEFGEKEDAKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x627C230", Offset = "0x627B630", VA = "0x18627C230")]
		private static bool LDJCEEIKDOG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x627BF50", Offset = "0x627B350", VA = "0x18627BF50")]
		private static void EAMEBDKKGEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x627BFD0", Offset = "0x627B3D0", VA = "0x18627BFD0")]
		private static void FHALLALEHJN(object IDDPIKCGHBG, LoadProgressEventArgs NIAPOIIDNMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x627BCB0", Offset = "0x627B0B0", VA = "0x18627BCB0")]
		private static void DBKALBLHLEB(object IDDPIKCGHBG, LoadCompletedEventArgs NIAPOIIDNMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x627BB10", Offset = "0x627AF10", VA = "0x18627BB10")]
		private static void AAGGAJPEOGF(object IDDPIKCGHBG, StateChangedEventArgs NIAPOIIDNMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x627C700", Offset = "0x627BB00", VA = "0x18627C700")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x627C890", Offset = "0x627BC90", VA = "0x18627C890")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x627C500", Offset = "0x627B900", VA = "0x18627C500")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x627BF50", Offset = "0x627B350", VA = "0x18627BF50")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x627C0E0", Offset = "0x627B4E0", VA = "0x18627C0E0")]
		private void FLJDDEKHMBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x627C630", Offset = "0x627BA30", VA = "0x18627C630", Slot = "4")]
		public void PushNetworkMessage(OBHMDHOGMEE.AKIPKAGFHFD HEFGEKEDAKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x75E5A0", Offset = "0x75D9A0", VA = "0x18075E5A0")]
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
