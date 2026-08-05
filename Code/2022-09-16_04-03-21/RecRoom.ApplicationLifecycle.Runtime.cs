using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface HBPMAKKHOEK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event PIEJCKJPOPP JDJGKAMLEBH;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event BNPFKFFHKHM APPMGKEFBBH;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event JFFNCIJGBIG FHPJDKFPIJL;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event FFJLBNAMEIC KJBGIMOBDKN;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event EGPPPEGGCEO FKNBLLNNLPP;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event BMEIJJOOAEH GKDIENCKPBE;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event NLCLCBMBNKL FDODBFPMKNH;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event DADKFEMLHBE NFJKMBAHINP;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event LLONEIDMLCG HPCDDEAMGLD;
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void BNPFKFFHKHM();
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void JFFNCIJGBIG();
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void FFJLBNAMEIC();
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void BMEIJJOOAEH();
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void NLCLCBMBNKL();
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void DADKFEMLHBE();
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void EGPPPEGGCEO();
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void PIEJCKJPOPP(bool IEFJGDAEFMO);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate void LLONEIDMLCG();
namespace RecRoom.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal class ApplicationQuitBehavior : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x4215270", Offset = "0x4213A70", VA = "0x184215270")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x4215370", Offset = "0x4213B70", VA = "0x184215370")]
		public static void SafeDestroyGameObject(GameObject KFNNOPCEBCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x628F80", Offset = "0x627780", VA = "0x180628F80")]
		public ApplicationQuitBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class DBPKAIMCAKA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private static bool ANNFJBFMAEN
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4215430", Offset = "0x4213C30", VA = "0x184215430")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x42154B0", Offset = "0x4213CB0", VA = "0x1842154B0")]
	[FFPLOIOAGME(KHENOPADNMD.Unity_AfterSceneLoad)]
	private static void LGHMODLDJCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4215470", Offset = "0x4213C70", VA = "0x184215470")]
	internal static void KDGLCBCDIAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface PDMNEPLKHFK
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool HOGPMMIEEED
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<bool> JHHIBLCDAEF;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void SetInnerFocusProvider(PDMNEPLKHFK EDNNMDKDMNF);
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
