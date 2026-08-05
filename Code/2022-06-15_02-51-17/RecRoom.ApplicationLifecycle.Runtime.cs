using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface GMAIBHECFBP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event AOOJOBNJCDO HMMMPFFNONM;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event LDFIGOFBJIC JCFJPEDKEOM;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event GFIMFLCMBOF NEJGJHFJIDB;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event EPHDKDHBKPO KAHMJCMBDPH;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event FMGJECKKLAM IHNGDHMNHBB;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event JBKEBFMONBI KANKJMEGBKA;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event KELHFHGDGCP CADBGMMEHJA;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event FNLIHGBEKPB IAOPEIDJJDP;
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void LDFIGOFBJIC();
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void GFIMFLCMBOF();
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void EPHDKDHBKPO();
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void JBKEBFMONBI();
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void KELHFHGDGCP();
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void FMGJECKKLAM();
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void AOOJOBNJCDO(bool BGJHHLOFJLF);
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void FNLIHGBEKPB();
namespace RecRoom.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	internal class ApplicationQuitBehavior : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x4E3F070", Offset = "0x4E3DC70", VA = "0x184E3F070")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x4E3F170", Offset = "0x4E3DD70", VA = "0x184E3F170")]
		public static void SafeDestroyGameObject(GameObject JNOODOEOLDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xCEA600", Offset = "0xCE9200", VA = "0x180CEA600")]
		public ApplicationQuitBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class CNIHLLAMHFP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private static bool IBMJAGNELNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4E3F2D0", Offset = "0x4E3DED0", VA = "0x184E3F2D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4E3F230", Offset = "0x4E3DE30", VA = "0x184E3F230")]
	[NMAFIJJCKPG(LEMEFCIKAHM.Unity_AfterSceneLoad)]
	private static void JIBFOCILIBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4E3F310", Offset = "0x4E3DF10", VA = "0x184E3F310")]
	internal static void PLBGGCNAMNN()
	{
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
