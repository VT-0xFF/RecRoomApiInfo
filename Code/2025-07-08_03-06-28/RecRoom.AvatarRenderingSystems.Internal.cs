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
		[Cpp2IlInjected.Address(RVA = "0x7EE0F70", Offset = "0x7EDFD70", VA = "0x187EE0F70", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x286F3E0", Offset = "0x286E1E0", VA = "0x18286F3E0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class EAJDDOKGOBB : IKDEDNAOOMG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private CNLOBILHDCI LPOMJIHLHIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private DFDINHBLJIH COBLDNGCMDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private IRecRoomQualityConfigProvider IDHHCIENOGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private bool KHGNHKGFOLO;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7EE05D0", Offset = "0x7EDF3D0", VA = "0x187EE05D0")]
	[ONLJNMLDJBD.KDDDMPKOLFO.GACHHHHOLBP]
	internal static void HDNOHKALIMP(LOAHJOOKLEP CHDHLAGMCKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x705A490", Offset = "0x7059290", VA = "0x18705A490")]
	[UnityEngine.Scripting.Preserve]
	public EAJDDOKGOBB([OLOAAHJODHH(null)] DFDINHBLJIH BEGKLBJGHNH, [OLOAAHJODHH(null)] CNLOBILHDCI MNPPIJFLPDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7EE06C0", Offset = "0x7EDF4C0", VA = "0x187EE06C0")]
	private void KPJNBFOHOIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7EE08C0", Offset = "0x7EDF6C0", VA = "0x187EE08C0", Slot = "4")]
	public void PEGKOOJIDPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7EE0940", Offset = "0x7EDF740", VA = "0x187EE0940", Slot = "5")]
	public NONKHMPPJIB<Texture2D> PIIENALBPCE(CGKJGJENBJJ NABNPGPHNNO, [Optional] KMFBMBBKEMD OAEBFAAHGEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7EE0750", Offset = "0x7EDF550", VA = "0x187EE0750")]
	private uint MBMGMMLODCL(CGKJGJENBJJ NABNPGPHNNO, KMFBMBBKEMD OAEBFAAHGEJ)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface IKDEDNAOOMG
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PEGKOOJIDPF();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NONKHMPPJIB<Texture2D> PIIENALBPCE(CGKJGJENBJJ NABNPGPHNNO, [Optional] KMFBMBBKEMD OAEBFAAHGEJ);
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
