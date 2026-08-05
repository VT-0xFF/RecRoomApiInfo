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
	public class EACManager : MonoBehaviour, EEFACOKGMDP
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ClientAuth DPGAHALABIK;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool EKELMPKOKGJ;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x754F930", Offset = "0x754E330", VA = "0x18754F930")]
		public static string GenerateChallengeResponse(string KCIHHNMIAKE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x754FA40", Offset = "0x754E440", VA = "0x18754FA40")]
		private static void HGELNIIIMDO(LEKPMIOKLMN.OOFMEFBGJEN ELHNCLABHAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x754F660", Offset = "0x754E060", VA = "0x18754F660")]
		private static bool DEMPPCFHNMO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x754FB10", Offset = "0x754E510", VA = "0x18754FB10")]
		private static void HMAKLMBHCIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x754F510", Offset = "0x754DF10", VA = "0x18754F510")]
		private static void AIAPOHOFCFA(object KOPOKAHKGFN, LoadProgressEventArgs MHJMAFLOEOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x754FD30", Offset = "0x754E730", VA = "0x18754FD30")]
		private static void OEIGHJMBGNA(object KOPOKAHKGFN, LoadCompletedEventArgs MHJMAFLOEOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x754FB90", Offset = "0x754E590", VA = "0x18754FB90")]
		private static void KKCCPGEGKLN(object KOPOKAHKGFN, StateChangedEventArgs MHJMAFLOEOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x75500F0", Offset = "0x754EAF0", VA = "0x1875500F0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7550270", Offset = "0x754EC70", VA = "0x187550270")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x754FF00", Offset = "0x754E900", VA = "0x18754FF00")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x754FB10", Offset = "0x754E510", VA = "0x18754FB10")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x754F620", Offset = "0x754E020", VA = "0x18754F620")]
		private void CAAAPPNFNEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7550020", Offset = "0x754EA20", VA = "0x187550020", Slot = "4")]
		public void PushNetworkMessage(LEKPMIOKLMN.OOFMEFBGJEN ELHNCLABHAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA40", Offset = "0x8AB440", VA = "0x1808ACA40")]
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
