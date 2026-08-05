using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using RecRoom.DataLayer.Attributes;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_RoomWideContent_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : MGJKNLCKGOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x72D5D10", Offset = "0x72D4710", VA = "0x1872D5D10", Slot = "8")]
		public override void KLIFGJHDPHO(DIMDGJNLMOK registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6283490", Offset = "0x6281E90", VA = "0x186283490")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface FEDELHIAGOM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool EMADEEMNEON
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class MGHLGLIGNPI : FEDELHIAGOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private JAHIFEMIDHK LGHCFIEDAOH;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool EMADEEMNEON
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x72D5C00", Offset = "0x72D4600", VA = "0x1872D5C00", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x72D5B00", Offset = "0x72D4500", VA = "0x1872D5B00")]
	[POCMGODEOKB.MGMEIEHFBKI]
	internal static void AFNHMHOEPCJ(APIKLLPBEEI PLCAFBBHOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x882870", Offset = "0x881270", VA = "0x180882870")]
	[RecRoom.NoEngine.Common.Preserve]
	public MGHLGLIGNPI([CNNDHKODGDP(null)] JAHIFEMIDHK LGHCFIEDAOH)
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
