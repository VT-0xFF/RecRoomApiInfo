using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using ExitGames.Client.Photon;
using RecRoom;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_ObjectModel_Dependencies_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ServiceBitset bitset0;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x8AD950", Offset = "0x8AC350", VA = "0x1808AD950", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x197E170", Offset = "0x197CB70", VA = "0x18197E170", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6F1DDA0", Offset = "0x6F1C7A0", VA = "0x186F1DDA0")]
		private void ACOMFCOBJKA(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6F1DFE0", Offset = "0x6F1C9E0", VA = "0x186F1DFE0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6F1E040", Offset = "0x6F1CA40", VA = "0x186F1E040")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[RegisterService(typeof(CCOGLMLHPNP), new string[] { "Photon" })]
public class LCEFBMMBMFF : DCJNOFKEBGO, GIGPPCKEGKB, CCOGLMLHPNP, NIFHAAMKMFC, GPMHGHCNDML, DGPGGKHFMFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[DependsOn]
	private EIAGLHCEIKL BNEOBONNMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	[DependsOn]
	private ABICAJPKFOD HKEAIDDCFHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly Hashtable FPNIMNHKJCC;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6F1DAC0", Offset = "0x6F1C4C0", VA = "0x186F1DAC0", Slot = "4")]
	public void InitReferences(POGCJGLPEEP KGNEDNNDCGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6F1DB60", Offset = "0x6F1C560", VA = "0x186F1DB60", Slot = "5")]
	public void MIDLBDOGLPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6F1D040", Offset = "0x6F1BA40", VA = "0x186F1D040", Slot = "6")]
	public void AMBCOLHDIJB(HPPPFLPICBH PNABAFEIDND, ReadOnlySpan<byte> ELHNCLABHAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6F1DC20", Offset = "0x6F1C620", VA = "0x186F1DC20", Slot = "11")]
	public void PBOBFEEAPDE(HPPPFLPICBH PBOOPMBMEMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6F1D190", Offset = "0x6F1BB90", VA = "0x186F1D190", Slot = "7")]
	public void BNMHGGAEDLJ(ReadOnlySpan<HPPPFLPICBH> FFPIFHDGABG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6F1D300", Offset = "0x6F1BD00", VA = "0x186F1D300")]
	private Hashtable CFGHINBOFBJ(Hashtable JABJKABPOEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6F1D560", Offset = "0x6F1BF60", VA = "0x186F1D560", Slot = "8")]
	private void HLDHOCPHHNN(EventData AENNPGAABBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6F1DBB0", Offset = "0x6F1C5B0", VA = "0x186F1DBB0", Slot = "9")]
	private void OHIECHPGLCJ(POGCJGLPEEP KGNEDNNDCGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6F19D60", Offset = "0x6F18760", VA = "0x186F19D60", Slot = "10")]
	private void ACPNJHKHIMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6F1DD20", Offset = "0x6F1C720", VA = "0x186F1DD20")]
	public LCEFBMMBMFF()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class JJODAPEKCBG
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public JJODAPEKCBG()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
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
