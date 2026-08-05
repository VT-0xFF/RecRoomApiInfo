using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class NJJAKHMKNAF
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static Thread OLMBHODHCKD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static bool AEOFCJNCFOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x606FFD0", Offset = "0x606F3D0", VA = "0x18606FFD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x606FF70", Offset = "0x606F370", VA = "0x18606FF70")]
	[MPOHMOIKDIC(BCAGKJLFEFM.Unity_AfterSceneLoad)]
	private static void EPIAPJMNNFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface ACBLFGIBDCK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event PDMMJPPBIIC DBIJODGPFNC;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event KFBKENEOGDF LLBOFPOPBEE;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event NJPHLAMMGKK NOGINBHHBMM;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event BNIOEFNEGFJ GDLLJNLHKJF;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event KIAEIOHOKAN HJDIFJMLAGD;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event JLFKBGICKPE EKIHEDJCNPJ;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event LDLGFHHBHBO CAIEFOPGDHA;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event JGNFFBFLGAB PPNFKPMNBGH;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event KIKCFODOMLI DIGLIOPKNDC;
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void KFBKENEOGDF();
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void NJPHLAMMGKK();
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void BNIOEFNEGFJ();
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void JLFKBGICKPE();
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void LDLGFHHBHBO();
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void JGNFFBFLGAB();
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void KIAEIOHOKAN();
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate void PDMMJPPBIIC(bool OPKPEPEOPFB);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void KIKCFODOMLI();
namespace RecRoom.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	internal class ApplicationQuitBehavior : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x606FCB0", Offset = "0x606F0B0", VA = "0x18606FCB0")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x606FD90", Offset = "0x606F190", VA = "0x18606FD90")]
		public static void SafeDestroyGameObject(GameObject LMKHHJAKBGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7BD2F0", Offset = "0x7BC6F0", VA = "0x1807BD2F0")]
		public ApplicationQuitBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class CBANGNLCLEH
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private static bool LOBBPHIKLJE
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x606FF30", Offset = "0x606F330", VA = "0x18606FF30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x606FE30", Offset = "0x606F230", VA = "0x18606FE30")]
	[MPOHMOIKDIC(BCAGKJLFEFM.Unity_AfterSceneLoad)]
	private static void EOPEJCOCBHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x606FEF0", Offset = "0x606F2F0", VA = "0x18606FEF0")]
	internal static void KHBFNIFIDNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface EPGHKPIDDAJ
{
	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<bool> KKPLKBNEAGC;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SetInnerFocusProvider(EPGHKPIDDAJ LCCBPGPJGNC);
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
