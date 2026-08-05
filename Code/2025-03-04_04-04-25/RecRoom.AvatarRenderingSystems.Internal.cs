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
		[Cpp2IlInjected.Address(RVA = "0x733D550", Offset = "0x733BB50", VA = "0x18733D550", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x245DCB0", Offset = "0x245C2B0", VA = "0x18245DCB0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class AKONFNOEGEK : MAAELNEGGKG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private FLHKLNGLCID HMOPFONIDDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private CMCKGIJHJHE ILNCNCKKBEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private IRecRoomQualityConfigProvider CBFDAFJAMLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private bool LAMMAOBONGB;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x733CCA0", Offset = "0x733B2A0", VA = "0x18733CCA0")]
	[HLOHOCOKELO.IDGFAEKKODB.GGCNFHIOHEN]
	internal static void JLOEIKCGHLK(GFKEMDIOCPC MGOKPJKELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0xD92610", Offset = "0xD90C10", VA = "0x180D92610")]
	[UnityEngine.Scripting.Preserve]
	public AKONFNOEGEK([IBJCGEMJMJL(null)] CMCKGIJHJHE NJDKDNFLIHG, [IBJCGEMJMJL(null)] FLHKLNGLCID ADLCLGKCJIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x733CB90", Offset = "0x733B190", VA = "0x18733CB90")]
	private void GGFAIEAMKGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x733CC20", Offset = "0x733B220", VA = "0x18733CC20", Slot = "4")]
	public void IIMGKGCONLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x733CDA0", Offset = "0x733B3A0", VA = "0x18733CDA0", Slot = "5")]
	public EBHOPDBMNPK<Texture2D> KPPOEFHNGBM(HMLBFHHALNB MAJGGDDPKGP, [Optional] IKKEFGFKHCN FJJOKDBOKAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x733D330", Offset = "0x733B930", VA = "0x18733D330")]
	private uint NFAEFBDEAIM(HMLBFHHALNB MAJGGDDPKGP, IKKEFGFKHCN FJJOKDBOKAE)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface MAAELNEGGKG
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IIMGKGCONLG();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EBHOPDBMNPK<Texture2D> KPPOEFHNGBM(HMLBFHHALNB MAJGGDDPKGP, [Optional] IKKEFGFKHCN FJJOKDBOKAE);
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
