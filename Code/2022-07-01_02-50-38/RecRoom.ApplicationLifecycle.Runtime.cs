using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface HPAFPEJGGEC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event CNDFOBGFFDB EAOGJCFPOOC;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event NLPIMOLPGBN EOMPEFKMIJO;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event JEGNBCECDLD HIFFBMILBOF;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event CLHGHCMENIK EFJPKEIOODK;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event FOOCIMOMLCM CIPGJNEDHMN;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event OPFGANKHHOF GNJLIBLDNJH;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event MMNFLBAJAJE KJPNKMBHGCJ;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event KMBODBHLJCM JDALFJFNNGK;
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void NLPIMOLPGBN();
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void JEGNBCECDLD();
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void CLHGHCMENIK();
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void OPFGANKHHOF();
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void MMNFLBAJAJE();
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void FOOCIMOMLCM();
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void CNDFOBGFFDB(bool KJKEMFNMDPF);
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void KMBODBHLJCM();
namespace RecRoom.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	internal class ApplicationQuitBehavior : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x4FF7650", Offset = "0x4FF5E50", VA = "0x184FF7650")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x4FF7750", Offset = "0x4FF5F50", VA = "0x184FF7750")]
		public static void SafeDestroyGameObject(GameObject HDDLEPINJNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x60B930", Offset = "0x60A130", VA = "0x18060B930")]
		public ApplicationQuitBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class FDCBCBGMJIL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private static bool MPFELNEGBPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4FF7970", Offset = "0x4FF6170", VA = "0x184FF7970")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4FF7890", Offset = "0x4FF6090", VA = "0x184FF7890")]
	[ABKMGPBGAPE(DAJECPDJCNA.Unity_AfterSceneLoad)]
	private static void CDGCMJJMEMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4FF7930", Offset = "0x4FF6130", VA = "0x184FF7930")]
	internal static void CNKONAOHGLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface CFFMGIEECNF
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool FELMLIIEELO
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<bool> MAJHEMJEMNH;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void SetInnerFocusProvider(CFFMGIEECNF KCGBHKNIAPF);
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
