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
	public class EACManager : MonoBehaviour, KGOKIHLLBIA
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ClientAuth NGALBMAIEJC;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool IFMCEEAAHOJ;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x689E0F0", Offset = "0x689CEF0", VA = "0x18689E0F0")]
		public static string GenerateChallengeResponse(string GDAGMCLPMEB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x689E020", Offset = "0x689CE20", VA = "0x18689E020")]
		private static void ABIBIMPFFGF(CNDMKHKHFCG.CABHDPGHHDP PENMOOOPINK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x689E200", Offset = "0x689D000", VA = "0x18689E200")]
		private static bool HOCMLAPNNCA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x689E990", Offset = "0x689D790", VA = "0x18689E990")]
		private static void PBEJEFFIGEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x689E880", Offset = "0x689D680", VA = "0x18689E880")]
		private static void ONPGPJLNGNG(object MJBACBKGPMA, LoadProgressEventArgs DKDAJJBPHGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x689E670", Offset = "0x689D470", VA = "0x18689E670")]
		private static void KGGMKAJDKDH(object MJBACBKGPMA, LoadCompletedEventArgs DKDAJJBPHGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x689E4D0", Offset = "0x689D2D0", VA = "0x18689E4D0")]
		private static void IDNIGFOJMCA(object MJBACBKGPMA, StateChangedEventArgs DKDAJJBPHGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x689EC00", Offset = "0x689DA00", VA = "0x18689EC00")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x689ED80", Offset = "0x689DB80", VA = "0x18689ED80")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x689EA10", Offset = "0x689D810", VA = "0x18689EA10")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x689E990", Offset = "0x689D790", VA = "0x18689E990")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x689E840", Offset = "0x689D640", VA = "0x18689E840")]
		private void LBEGBKJLDPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x689EB30", Offset = "0x689D930", VA = "0x18689EB30", Slot = "4")]
		public void PushNetworkMessage(CNDMKHKHFCG.CABHDPGHHDP PENMOOOPINK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7B0790", Offset = "0x7AF590", VA = "0x1807B0790")]
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
