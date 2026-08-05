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
	public class EACManager : MonoBehaviour, ECPKNMJLFOP
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ClientAuth DFNNOKKLFJC;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool MHOMMFAKDCI;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x66FAF00", Offset = "0x66FA300", VA = "0x1866FAF00")]
		public static string GenerateChallengeResponse(string FHOBNDMBABG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x66FAC60", Offset = "0x66FA060", VA = "0x1866FAC60")]
		private static void CIHCCLEJIHB(FLMMGDKOGEN.NPCCLJAHMFK KFANGHDLFAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x66FB1F0", Offset = "0x66FA5F0", VA = "0x1866FB1F0")]
		private static bool MDJFBMODMJL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x66FB4C0", Offset = "0x66FA8C0", VA = "0x1866FB4C0")]
		private static void MKOEMONOIAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x66FB540", Offset = "0x66FA940", VA = "0x1866FB540")]
		private static void ODHBDNKIHHJ(object DDDMOJBOFJM, LoadProgressEventArgs KHFGKKJBPIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x66FAD30", Offset = "0x66FA130", VA = "0x1866FAD30")]
		private static void ELHCOKEHGKI(object DDDMOJBOFJM, LoadCompletedEventArgs KHFGKKJBPIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x66FB010", Offset = "0x66FA410", VA = "0x1866FB010")]
		private static void JPFPFLOGFAM(object DDDMOJBOFJM, StateChangedEventArgs KHFGKKJBPIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x66FB850", Offset = "0x66FAC50", VA = "0x1866FB850")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x66FB9E0", Offset = "0x66FADE0", VA = "0x1866FB9E0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x66FB650", Offset = "0x66FAA50", VA = "0x1866FB650")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x66FB4C0", Offset = "0x66FA8C0", VA = "0x1866FB4C0")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x66FB1B0", Offset = "0x66FA5B0", VA = "0x1866FB1B0")]
		private void KKALNJAPDBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x66FB780", Offset = "0x66FAB80", VA = "0x1866FB780", Slot = "4")]
		public void PushNetworkMessage(FLMMGDKOGEN.NPCCLJAHMFK KFANGHDLFAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7A08F0", Offset = "0x79FCF0", VA = "0x1807A08F0")]
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
