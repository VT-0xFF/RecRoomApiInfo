using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.CircuitsV2.ChipCulling.Data
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public struct ChipVisibilityConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private float maxVisibleDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private float chipBoundsScaleFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[SerializeField]
		private float portCutoffDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[SerializeField]
		private float portTextCutoffDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[SerializeField]
		private float titleTextCutoffDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[SerializeField]
		private int maxNormalResChips;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		private int transformSyncBatches;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		private int cullingBatches;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[SerializeField]
		private int bufferSize;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public float MaxVisibleDistanceSq
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x7A01E10", Offset = "0x7A01210", VA = "0x187A01E10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public float ChipBoundsScaleFactor
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x29403E0", Offset = "0x293F7E0", VA = "0x1829403E0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public float PortCutoffDistanceSq
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7A01E20", Offset = "0x7A01220", VA = "0x187A01E20")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public float PortTextCutoffDistanceSq
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x7A01E30", Offset = "0x7A01230", VA = "0x187A01E30")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public float TitleTextCutoffDistanceSq
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7A01E40", Offset = "0x7A01240", VA = "0x187A01E40")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int MaxNormalResChips
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xB52460", Offset = "0xB51860", VA = "0x180B52460")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int TransformSyncBatches
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x9D5BF0", Offset = "0x9D4FF0", VA = "0x1809D5BF0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int CullingBatches
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x9F2840", Offset = "0x9F1C40", VA = "0x1809F2840")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int BufferSize
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xBC4000", Offset = "0xBC3400", VA = "0x180BC4000")]
			get
			{
				return default(int);
			}
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[Flags]
public enum ODJGAHDLLFA
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Uninitialized = int.MinValue,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Visible = 1,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	NormalRes = 2,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	PortsVisible = 4,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	PortTextVisible = 8,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	TitleTextVisible = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	SpriteVisible = 0x20,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	CollidersEnabled = 0x40,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	All = int.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class KLKHHPCIIEG
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6B3EFF0", Offset = "0x6B3E3F0", VA = "0x186B3EFF0")]
	public static bool JPBNLPMMPCG(this ODJGAHDLLFA LCIAMICNGFI, ODJGAHDLLFA MGDFEHJDPGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7A02120", Offset = "0x7A01520", VA = "0x187A02120")]
	public static ODJGAHDLLFA OBNOCAPMKHB(this ODJGAHDLLFA LCIAMICNGFI, ODJGAHDLLFA MGDFEHJDPGB)
	{
		return default(ODJGAHDLLFA);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7A02110", Offset = "0x7A01510", VA = "0x187A02110")]
	public static ODJGAHDLLFA FOKJFLLMFFK(this ODJGAHDLLFA LCIAMICNGFI, ODJGAHDLLFA MGDFEHJDPGB)
	{
		return default(ODJGAHDLLFA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct JPINPHLLOGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public float FENPKCOEFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public float LGDLKBIHFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public float FEIOLBOLFFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public float BDGEIEDEJDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public float EHNPDFBIBEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public float ANOPBMNAKKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public float PADPAKGCPAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float GHDPLLKPLFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float GAGFIBCAOGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public float PNDDOPOCMKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public float EDFJPBNIDNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public float EFFMGDCOHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public float BOBEIINFIEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public float BKHOEELENCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public float ABECJIIJBCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public float OCCEPPLJKKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public float IDKMCPHDGFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public float BBJNEMBHHGN;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7A01E50", Offset = "0x7A01250", VA = "0x187A01E50")]
	public static JPINPHLLOGM MEFEAOCDBMM(Camera IBNBEBCPKKJ)
	{
		return default(JPINPHLLOGM);
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
