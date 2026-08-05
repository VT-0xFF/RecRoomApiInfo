using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface KECGFKLPAJE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event LAKHPHPCMGD JJBCJLALOEO;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event NOJLBCIHDIJ JBCFLHJDAGD;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event OKBIPACCKCB OAEOGKEJJDL;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event DCJIOLAMPLH AILCHMOCGGD;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event JHGFJKCAEOO DMGLMPIFJJN;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event AEBLFCDOCCC DLGKFBBKHCB;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event HMNJJMOCDMG BILLCFLDNBM;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event PONOIFEBEEA OBEPPBKLDAA;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event CFKEDEOHHNH FBGBNBMBNKM;
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void NOJLBCIHDIJ();
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void OKBIPACCKCB();
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void DCJIOLAMPLH();
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void AEBLFCDOCCC();
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void HMNJJMOCDMG();
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void PONOIFEBEEA();
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void JHGFJKCAEOO();
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void LAKHPHPCMGD(bool OOLMCMBOHIP);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate void CFKEDEOHHNH();
namespace RecRoom.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal class ApplicationQuitBehavior : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5E9B230", Offset = "0x5E9A230", VA = "0x185E9B230")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5E9B330", Offset = "0x5E9A330", VA = "0x185E9B330")]
		public static void SafeDestroyGameObject(GameObject BFJMKCMPBKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xF9D450", Offset = "0xF9C450", VA = "0x180F9D450")]
		public ApplicationQuitBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class MIHOOBDOFPP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private static bool HCGKMKDIKJB
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5E9B570", Offset = "0x5E9A570", VA = "0x185E9B570")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5E9B470", Offset = "0x5E9A470", VA = "0x185E9B470")]
	[AMBDGJEEPDK(AJGKCOCFBKH.Unity_AfterSceneLoad)]
	private static void ILMEFAAGLOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5E9B530", Offset = "0x5E9A530", VA = "0x185E9B530")]
	internal static void NMEKILDCNGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface PLHPKALCKNM
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool EHDJKHGGFAB
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<bool> LBBDNBBJDCB;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void SetInnerFocusProvider(PLHPKALCKNM AOGPIBDHPFM);
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
