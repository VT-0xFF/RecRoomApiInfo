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
		[Cpp2IlInjected.Address(RVA = "0x6A972C0", Offset = "0x6A95EC0", VA = "0x186A972C0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2039EC0", Offset = "0x2038AC0", VA = "0x182039EC0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class GCCEFHEOFAI : INANGOAADEI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private HKBGOEFPCBL CKIJFLLJNCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private CDEIFEPMIKE AKDJPAHOIDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private IRecRoomQualityConfigProvider PLEHIJPNMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private bool PNICHAHNEGC;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6A96F20", Offset = "0x6A95B20", VA = "0x186A96F20")]
	[BOLBLOCFHKO.ENGLBNKHCKK.CLDNNCAHIAO]
	internal static void JIEKEBODNGC(EAEKKMJPCLA EBEEBGHJNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5DA1C20", Offset = "0x5DA0820", VA = "0x185DA1C20")]
	[UnityEngine.Scripting.Preserve]
	public GCCEFHEOFAI([JGAMIMHCGFI(null)] CDEIFEPMIKE MJNMHPCCNNB, [JGAMIMHCGFI(null)] HKBGOEFPCBL NCMHEILAIGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6A97190", Offset = "0x6A95D90", VA = "0x186A97190")]
	private void NPNMPLNKKAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6A96EA0", Offset = "0x6A95AA0", VA = "0x186A96EA0", Slot = "4")]
	public void FJEJIDNMHJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6A96930", Offset = "0x6A95530", VA = "0x186A96930", Slot = "5")]
	public MGEGMLPKNPK<Texture2D> EHEGELILOKB(DIPFLIIMFIM OCOAPIHPDMH, [Optional] EHJFAJIMFLL HHLMDDDPFNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6A97020", Offset = "0x6A95C20", VA = "0x186A97020")]
	private uint NGKGEFBHOHD(DIPFLIIMFIM OCOAPIHPDMH, EHJFAJIMFLL HHLMDDDPFNI)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface INANGOAADEI
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FJEJIDNMHJP();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MGEGMLPKNPK<Texture2D> EHEGELILOKB(DIPFLIIMFIM OCOAPIHPDMH, [Optional] EHJFAJIMFLL HHLMDDDPFNI);
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
