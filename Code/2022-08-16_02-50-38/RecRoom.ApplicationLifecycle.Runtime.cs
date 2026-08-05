using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface FBPFPJOENID : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event PDDCJBPBFEO BOCOOCGKDKA;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event CJHPMKKFGDN ADGIMOCDCAK;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event OGDKMADDLDH DEBIHCNHLKN;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event OCHELIILNDJ ABDMBINNLGJ;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event MBLOEGBCDPL BDOIEEECGDB;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event NKBIJPFELAA JPECCCJKFMB;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event OGPMGDFBDCC BIKJDLKLAJL;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event COECGFKJPKI CEBFNOEFDGF;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event FCDAFNEFBBD IBLFJEGNABN;
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void CJHPMKKFGDN();
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void OGDKMADDLDH();
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void OCHELIILNDJ();
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void NKBIJPFELAA();
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void OGPMGDFBDCC();
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void COECGFKJPKI();
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void MBLOEGBCDPL();
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void PDDCJBPBFEO(bool JADDKONFNKF);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate void FCDAFNEFBBD();
namespace RecRoom.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal class ApplicationQuitBehavior : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5844AC0", Offset = "0x58436C0", VA = "0x185844AC0")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5844BC0", Offset = "0x58437C0", VA = "0x185844BC0")]
		public static void SafeDestroyGameObject(GameObject JPIPKHMPCNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xE66B60", Offset = "0xE65760", VA = "0x180E66B60")]
		public ApplicationQuitBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class MPGNNNEKDMO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private static bool HKCAEKCBDOF
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5844C80", Offset = "0x5843880", VA = "0x185844C80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5844CC0", Offset = "0x58438C0", VA = "0x185844CC0")]
	[CMANADLJIIG(PKJIHGJIELK.Unity_AfterSceneLoad)]
	private static void CMEOLNMPNEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5844D60", Offset = "0x5843960", VA = "0x185844D60")]
	internal static void KNBJHGMFCGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface HGPNCFPCAAL
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool JHJNOEKOOLC
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<bool> FMPPIPEIIEN;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void SetInnerFocusProvider(HGPNCFPCAAL JJOGCCBGKPA);
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
