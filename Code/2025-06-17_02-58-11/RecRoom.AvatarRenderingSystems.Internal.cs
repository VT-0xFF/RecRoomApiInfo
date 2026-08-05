using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_AvatarRenderingSystems_Internal
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7B72F10", Offset = "0x7B71910", VA = "0x187B72F10", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2796C60", Offset = "0x2795660", VA = "0x182796C60")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class HAKIDFOMNGH : NGEPHBEGDJD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private IJCDGJBAPLF KGEAOGILHNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private KFNMLAJAJEB MKLINELDNNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private IRecRoomQualityConfigProvider GPIPKJBBEPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private bool ALGNNAPDEJK;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7B72D80", Offset = "0x7B71780", VA = "0x187B72D80")]
	[CGLGNCLDKHN.CKJOAALDIOP.OPIHCDHBMNP]
	internal static void PKGIHPLBPEI(MHGNCMHMEKD DJGDNAKMFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6D0C860", Offset = "0x6D0B260", VA = "0x186D0C860")]
	[UnityEngine.Scripting.Preserve]
	public HAKIDFOMNGH([CNHMBDDCGKB(null)] KFNMLAJAJEB CCJGANLKFLJ, [CNHMBDDCGKB(null)] IJCDGJBAPLF GGMMAMFABMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7B72700", Offset = "0x7B71100", VA = "0x187B72700")]
	private void EPOCNOOIOFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7B72790", Offset = "0x7B71190", VA = "0x187B72790", Slot = "4")]
	public void HLCDNOOAGII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7B72810", Offset = "0x7B71210", VA = "0x187B72810", Slot = "5")]
	public ODDHNIEMFCD<Texture2D> LIIBKHOFEMK(AALNJLEFLEC EGDCGHONMKN, [Optional] BBNCMLFOPPH JKGCHKOAIPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7B72590", Offset = "0x7B70F90", VA = "0x187B72590")]
	private uint BJDJONIDICK(AALNJLEFLEC EGDCGHONMKN, BBNCMLFOPPH JKGCHKOAIPN)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface NGEPHBEGDJD
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HLCDNOOAGII();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ODDHNIEMFCD<Texture2D> LIIBKHOFEMK(AALNJLEFLEC EGDCGHONMKN, [Optional] BBNCMLFOPPH JKGCHKOAIPN);
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
