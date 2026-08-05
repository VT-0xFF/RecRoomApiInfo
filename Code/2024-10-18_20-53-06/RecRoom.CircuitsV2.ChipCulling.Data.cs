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
			[Cpp2IlInjected.Address(RVA = "0x6CE7700", Offset = "0x6CE6B00", VA = "0x186CE7700")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public float ChipBoundsScaleFactor
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x242BC70", Offset = "0x242B070", VA = "0x18242BC70")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public float PortCutoffDistanceSq
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x6CE7710", Offset = "0x6CE6B10", VA = "0x186CE7710")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public float PortTextCutoffDistanceSq
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x6CE7720", Offset = "0x6CE6B20", VA = "0x186CE7720")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public float TitleTextCutoffDistanceSq
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x6CE7730", Offset = "0x6CE6B30", VA = "0x186CE7730")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int MaxNormalResChips
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x9B2E50", Offset = "0x9B2250", VA = "0x1809B2E50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int TransformSyncBatches
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x8AACD0", Offset = "0x8AA0D0", VA = "0x1808AACD0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int CullingBatches
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x8D1D10", Offset = "0x8D1110", VA = "0x1808D1D10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int BufferSize
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x92A830", Offset = "0x929C30", VA = "0x18092A830")]
			get
			{
				return default(int);
			}
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[Flags]
public enum PGFDEHKMPIK
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
public static class FAJMMMNPEPI
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5FA60F0", Offset = "0x5FA54F0", VA = "0x185FA60F0")]
	public static bool KLINEMCOLKP(this PGFDEHKMPIK HHHMBFBJEKP, PGFDEHKMPIK IDPDPLCMBDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6C6BEA0", Offset = "0x6C6B2A0", VA = "0x186C6BEA0")]
	public static PGFDEHKMPIK KAOFLHKBIGC(this PGFDEHKMPIK HHHMBFBJEKP, PGFDEHKMPIK IDPDPLCMBDA)
	{
		return default(PGFDEHKMPIK);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6C6BED0", Offset = "0x6C6B2D0", VA = "0x186C6BED0")]
	public static PGFDEHKMPIK GKLFABGEFFC(this PGFDEHKMPIK HHHMBFBJEKP, PGFDEHKMPIK IDPDPLCMBDA)
	{
		return default(PGFDEHKMPIK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct KOJKBPKNGNH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public float DCNGAAEOKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public float FCNFANDMDPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public float FEIAGGNKFOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public float PBNKOEHHBMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public float OFJIMGFGBKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public float MEOLAMJPJHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public float CIKGDPBMIJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float OLBPMCKEODA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float HJPLOPGOIPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public float OOBFECPNCKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public float DCGFOICPJBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public float JHDPFENLKEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public float FKMBIHBPNLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public float CMCMLHJMKHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public float LNFBENKLOPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public float DDNIPAIKKOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public float NFGBNGFJKPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public float LBNBCPDGPLI;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6CE7740", Offset = "0x6CE6B40", VA = "0x186CE7740")]
	public static KOJKBPKNGNH DCLCHLCPCHD(Camera KNCFDOBPMAF)
	{
		return default(KOJKBPKNGNH);
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
