using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface GLEOEPJCKCE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event AJOKHLOIIIP DOFAHDNONGM;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event HLMALPFJJLJ JCPEDGKMAKO;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event GDBHEJNCION GNIIKDLBAAE;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event OMNKJGPPOPD FOCHHCGPBDF;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event GICKNKKCDNN IIFCJKBNPAH;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event IEFLJKCGNJN LFPIFLGOGGF;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event FGGPIKEPHFD CKFNHFCOCKK;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event HHMPDDAKFIO CMHCPFHOINI;
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void HLMALPFJJLJ();
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void GDBHEJNCION();
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void OMNKJGPPOPD();
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void IEFLJKCGNJN();
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void FGGPIKEPHFD();
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void GICKNKKCDNN();
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void AJOKHLOIIIP(bool ACIOFJHMAFF);
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void HHMPDDAKFIO();
namespace RecRoom.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	internal class ApplicationQuitBehavior : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1930090", Offset = "0x192EA90", VA = "0x181930090")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1930190", Offset = "0x192EB90", VA = "0x181930190")]
		public static void SafeDestroyGameObject(GameObject BHNNPCJCNFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x560A60", Offset = "0x55F460", VA = "0x180560A60")]
		public ApplicationQuitBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class MFFHHOEOFMC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private static bool AEIMEGMHKJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1930330", Offset = "0x192ED30", VA = "0x181930330")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1930250", Offset = "0x192EC50", VA = "0x181930250")]
	[HHLALKEPADJ(EEBHKBEBFLD.Unity_AfterSceneLoad)]
	private static void LPDEJFLNIEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x19302F0", Offset = "0x192ECF0", VA = "0x1819302F0")]
	internal static void MADAFGDOMHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface KCOOHGGDOPG
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool LGDAAPGJFHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<bool> HJINKIDNKIG;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void SetInnerFocusProvider(KCOOHGGDOPG GGMOFFJMKOE);
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
