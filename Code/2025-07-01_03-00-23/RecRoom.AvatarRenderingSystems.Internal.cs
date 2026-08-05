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
		[Cpp2IlInjected.Address(RVA = "0x7DD05C0", Offset = "0x7DCEBC0", VA = "0x187DD05C0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x282D140", Offset = "0x282B740", VA = "0x18282D140")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class BGNPILAMGGN : BLIJBJLJOEK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private HMLNDDCMDIH LFMMEELIGOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NONJPMGFCKL LIKDIPILLGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private IRecRoomQualityConfigProvider ALOIONHDGOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private bool FBIHAAGDJHM;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7DD0390", Offset = "0x7DCE990", VA = "0x187DD0390")]
	[BNHIEDNKDNA.MLFEBCDGLFC.CIEDAEOKGHH]
	internal static void KOGGDFIPMLH(DCNOMJHNEOK FAIEEFHMPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6F593F0", Offset = "0x6F579F0", VA = "0x186F593F0")]
	[UnityEngine.Scripting.Preserve]
	public BGNPILAMGGN([GGNLMCAPMLP(null)] NONJPMGFCKL JEMGNCELELN, [GGNLMCAPMLP(null)] HMLNDDCMDIH AJNEEIMMKFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7DD0480", Offset = "0x7DCEA80", VA = "0x187DD0480")]
	private void MKIELGDMLNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7DCFC20", Offset = "0x7DCE220", VA = "0x187DCFC20", Slot = "4")]
	public void EKKFGBOOGAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7DCFCA0", Offset = "0x7DCE2A0", VA = "0x187DCFCA0", Slot = "5")]
	public MODONOMENDG<Texture2D> ENKBGLEAONB(FCNKIMHMKLB NNFMHGJKEOH, [Optional] FDMHDGANLHD MJNKOFMOBDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7DD0220", Offset = "0x7DCE820", VA = "0x187DD0220")]
	private uint IEEDECNELHG(FCNKIMHMKLB NNFMHGJKEOH, FDMHDGANLHD MJNKOFMOBDK)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface BLIJBJLJOEK
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EKKFGBOOGAI();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MODONOMENDG<Texture2D> ENKBGLEAONB(FCNKIMHMKLB NNFMHGJKEOH, [Optional] FDMHDGANLHD MJNKOFMOBDK);
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
