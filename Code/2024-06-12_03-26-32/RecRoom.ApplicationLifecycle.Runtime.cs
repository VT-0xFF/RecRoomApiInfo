using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class OEGNAOIMGCN
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static Thread IDCMGJBKIDM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static bool CNOINGFFGKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x675A9B0", Offset = "0x67595B0", VA = "0x18675A9B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x675A950", Offset = "0x6759550", VA = "0x18675A950")]
	[JINDIHIDKGM(CBKAKHJHIKE.Unity_AfterSceneLoad)]
	private static void JAPOJOAJPPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface OHNNOPNKKLN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event PEOJIGICKKM JLKDJBBHNNG;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event KLKDCJMDLID NBJEMGDMOCC;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event OODNLFDOAKE HHCIDMMBLDI;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event BAEHPNJFMJP AABHPGHHMKJ;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event HKAKIGACADL DCIJAHDFCKP;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event OIEDAACDHCC CAINMFLGLBA;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event ENPEEPDIEBF OPLGMMMGMGD;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event NIMDLGEFDMG MIFEHKPIABH;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event IGPLJJLIDCJ PHAPBKNKOKA;
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void KLKDCJMDLID();
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void OODNLFDOAKE();
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void BAEHPNJFMJP();
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void OIEDAACDHCC();
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void ENPEEPDIEBF();
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void NIMDLGEFDMG();
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void HKAKIGACADL();
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate void PEOJIGICKKM(bool IPHBFEGENLJ);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void IGPLJJLIDCJ();
namespace RecRoom.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	internal class ApplicationQuitBehavior : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x675A690", Offset = "0x6759290", VA = "0x18675A690")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x675A770", Offset = "0x6759370", VA = "0x18675A770")]
		public static void SafeDestroyGameObject(GameObject OLFFLDPKCIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x846CB0", Offset = "0x8458B0", VA = "0x180846CB0")]
		public ApplicationQuitBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class NEIIPHOPNLI
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private static bool DFMOHNOMCGE
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x675A910", Offset = "0x6759510", VA = "0x18675A910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x675A810", Offset = "0x6759410", VA = "0x18675A810")]
	[JINDIHIDKGM(CBKAKHJHIKE.Unity_AfterSceneLoad)]
	private static void EHHLDMLDHNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x675A8D0", Offset = "0x67594D0", VA = "0x18675A8D0")]
	internal static void LELJADPDEAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface GEAGLGNIKDI
{
	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<bool> EMAAHJAKPED;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SetInnerFocusProvider(GEAGLGNIKDI FEHIENDFJDE);
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
