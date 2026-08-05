using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class KKDPFDNMONM
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static Thread DCCHHDNAIDE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static bool PFGJHFANOMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5D21FB0", Offset = "0x5D20BB0", VA = "0x185D21FB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5D22000", Offset = "0x5D20C00", VA = "0x185D22000")]
	[DGIJNOPMGJE(IOENMJMEHBM.Unity_AfterSceneLoad)]
	private static void JDNIOJNCFAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface EFJOKGEPKPF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event PCLAFNFCLNP JGIBAKCNAHP;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event DPGFNBILLJL OFENLADEDFE;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event BJEBEHNONNI PDJCDDIBAPG;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event FGAOAOLFCAK IFJOALODFCO;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event EINNHFLIBIO MBAKGFNPMGG;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event ACALCNBGBMA DIACKONLNHN;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event LEIFACEFMPB DPAPFACMKNM;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event NCBMNJFEDHC MOJCDBMDEBF;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event OMDJIJIDDPH ECDNAEKEHOO;
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void DPGFNBILLJL();
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void BJEBEHNONNI();
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void FGAOAOLFCAK();
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void ACALCNBGBMA();
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void LEIFACEFMPB();
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void NCBMNJFEDHC();
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void EINNHFLIBIO();
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate void PCLAFNFCLNP(bool MBPENCGBADO);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void OMDJIJIDDPH();
namespace RecRoom.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	internal class ApplicationQuitBehavior : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5D21CF0", Offset = "0x5D208F0", VA = "0x185D21CF0")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5D21DD0", Offset = "0x5D209D0", VA = "0x185D21DD0")]
		public static void SafeDestroyGameObject(GameObject LCHNDEILNAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x771300", Offset = "0x76FF00", VA = "0x180771300")]
		public ApplicationQuitBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class JADJFKEHCDP
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private static bool AMFEBBBJFGH
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5D21E70", Offset = "0x5D20A70", VA = "0x185D21E70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5D21EB0", Offset = "0x5D20AB0", VA = "0x185D21EB0")]
	[DGIJNOPMGJE(IOENMJMEHBM.Unity_AfterSceneLoad)]
	private static void JMCKLNABHHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5D21F70", Offset = "0x5D20B70", VA = "0x185D21F70")]
	internal static void LLJNJMOFAHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface EKJIMFKBFMN
{
	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<bool> BBFJBIHDDMD;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SetInnerFocusProvider(EKJIMFKBFMN AAEDHDLPGKK);
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
