using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RecRoom.DataLayer.Attributes;
using RecRoom.Logging.Attributes;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Rendering_Player_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : JOPFPPBONLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x722D2B0", Offset = "0x722BCB0", VA = "0x18722D2B0", Slot = "4")]
		public override void HEDMFNKAECO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8AE600", Offset = "0x8AD000", VA = "0x1808AE600")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Rendering_Player_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : MGJKNLCKGOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x722D340", Offset = "0x722BD40", VA = "0x18722D340", Slot = "8")]
		public override void KLIFGJHDPHO(DIMDGJNLMOK registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6283490", Offset = "0x6281E90", VA = "0x186283490")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface FPOHPPMLJNE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int? EFODIGGDIMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JNBIEIILHEL();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class HCLOAKAGGON : FPOHPPMLJNE
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly ANDGIEDMMDP AGICKJCJECJ;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly string LJPPDFEPJJK;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly string GJPMDDAFDJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private MADEEJNOHNA DDJIGFKEOAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private int? FAHBPEOLKHC;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int? EFODIGGDIMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x882870", Offset = "0x881270", VA = "0x180882870")]
	[UnityEngine.Scripting.Preserve]
	public HCLOAKAGGON([CNNDHKODGDP(null)][NotNull] MADEEJNOHNA JDGBNOGOAHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x722CED0", Offset = "0x722B8D0", VA = "0x18722CED0")]
	[POCMGODEOKB.MGMEIEHFBKI.CGAMGCLHOIE]
	[UsedImplicitly]
	public static void FICKBNHLLFH(APIKLLPBEEI PLCAFBBHOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x722D0B0", Offset = "0x722BAB0", VA = "0x18722D0B0", Slot = "5")]
	public void JNBIEIILHEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x722CB30", Offset = "0x722B530", VA = "0x18722CB30")]
	private void BECHHKHAPOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x722CFD0", Offset = "0x722B9D0", VA = "0x18722CFD0")]
	private bool HLBNLKAGIKO(string MAFGPBPAGIB, [Out] JLMPBCLECDO HCIHHGHFCCA)
	{
		return default(bool);
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
